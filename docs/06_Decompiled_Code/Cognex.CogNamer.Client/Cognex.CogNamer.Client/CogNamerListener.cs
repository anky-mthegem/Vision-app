using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cognex.CogNamer.Client.Attributes;
using Cognex.CogNamer.Client.Common;
using Cognex.Internal;

namespace Cognex.CogNamer.Client;

public class CogNamerListener : IDisposable
{
	public enum CommandSupport
	{
		NotSupported,
		OnlyDuringIPREQUEST,
		Supported
	}

	public delegate void SendCommandExDelegate(int cmd, byte flags, CogNamerErrorCode resultCode, CogNamerRecordList records, IPEndPoint endPoint);

	protected class CogNamerProtocolHandler
	{
		public enum NamerCommand
		{
			NOOP,
			Hello,
			Identify,
			IPRequest,
			IPAssign,
			FactoryReset,
			SetAttribute,
			Flash,
			QueryCache,
			RestartSystem,
			GetAttribute,
			ResetAdminPassword
		}

		[Flags]
		public enum NamerFlags
		{
			None = 0,
			SupportsCommandProbe = 0x20,
			Broadcast = 0x40,
			Response = 0x80
		}

		public class CogNamerResponse : IDisposable
		{
			public readonly NamerCommand Command;

			public readonly long MacAddress;

			public bool GotResponse;

			public CogNamerErrorCode ErrorCode;

			public CogNamerRecordList Records;

			public ManualResetEvent ResponseReceivedEvent = new ManualResetEvent(initialState: false);

			public CogNamerResponse(NamerCommand cmd, long macAddress)
			{
				Command = cmd;
				MacAddress = macAddress;
			}

			public void Dispose()
			{
				ResponseReceivedEvent.Close();
			}
		}

		private static readonly TraceSwitch _switch = new TraceSwitch("CogNamerNetworkMonitor", "Trace Level");

		private const int NamerPort = 1069;

		private const int FlexibleNamerProtocolVersion = 4;

		private readonly List<CogNamerResponse> _waitingMessages = new List<CogNamerResponse>();

		private const int NamerMagic4 = 1128746573;

		private readonly CogNamerListener _netMonitor;

		private readonly ICogNamerNetworkMonitorNetworkInterface _netInterface;

		private AutoResetEvent _responseReceivedEvent = new AutoResetEvent(initialState: false);

		private Dictionary<CogNamerCommand, NamerCommand> _CommandMap;

		public SendCommandExDelegate TestCallback;

		private IEncrypt mEncryptor;

		public event CogNamerPacketEventHandler PacketReceived;

		public CogNamerProtocolHandler(CogNamerListener netMonitor, ICogNamerNetworkMonitorNetworkInterface netInterface, IEncrypt encrypt = null)
		{
			_netMonitor = netMonitor;
			_netInterface = netInterface;
			if (encrypt == null)
			{
				encrypt = new CogNamerEncrypt();
			}
			mEncryptor = encrypt;
			_netInterface.PacketReceived += HandlePacket;
		}

		public void SendRefresh()
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList(2);
			MemoryStream memoryStream = new MemoryStream(256);
			BinaryWriter bw = new BinaryWriter(memoryStream);
			foreach (CogNamerDevice item in _netMonitor.GetHostCache())
			{
				if (memoryStream.Position + Encoding.UTF8.GetByteCount(item.HostName) > 8150)
				{
					break;
				}
				CogNamerPacket.WriteIP(bw, item.IPAddress);
				CogNamerPacket.WriteString(bw, item.HostName);
			}
			if (memoryStream.Position != 0L)
			{
				cogNamerRecordList.Add(new CogNamerRecord(CogNamerAttributeType.KnownSystems, memoryStream.ToArray()));
			}
			if (_netMonitor.DiscoverMisconfiguredDevices)
			{
				SendCommandEx(NamerCommand.Identify, NamerFlags.Broadcast, CogNamerErrorCode.Success, cogNamerRecordList, new IPEndPoint(IPAddress.Broadcast, 1069));
			}
			else
			{
				SendCommandEx(NamerCommand.Identify, NamerFlags.None, CogNamerErrorCode.Success, cogNamerRecordList, null);
			}
		}

		public void SendIdentify(IPAddress ip)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList(1);
			byte[] addressBytes = ip.GetAddressBytes();
			Array.Reverse(addressBytes);
			cogNamerRecordList.Add(new CogNamerRecord(CogNamerAttributeType.IpAddress, addressBytes));
			SendCommandEx(NamerCommand.Identify, NamerFlags.None, CogNamerErrorCode.Success, cogNamerRecordList, null);
		}

		public void SendIdentify(string name)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList(1);
			cogNamerRecordList.Add(new CogNamerRecord(CogNamerAttributeType.HostName, name));
			SendCommandEx(NamerCommand.Identify, NamerFlags.None, CogNamerErrorCode.Success, cogNamerRecordList, null);
		}

		public bool SendSupportsCommand(CogNamerDevice device, CogNamerCommand cmd)
		{
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(GetNamerCommand(cmd), NamerFlags.SupportsCommandProbe, null, device, 1000, 3);
			if (cogNamerResponse.GotResponse)
			{
				return cogNamerResponse.ErrorCode == CogNamerErrorCode.Success;
			}
			return false;
		}

		public CommandSupport GetSupportsCommand(CogNamerDevice device, CogNamerCommand cmd)
		{
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(GetNamerCommand(cmd), NamerFlags.SupportsCommandProbe, null, device, 1000, 3);
			if (cogNamerResponse.GotResponse)
			{
				if (cogNamerResponse.ErrorCode == CogNamerErrorCode.Success)
				{
					return CommandSupport.Supported;
				}
				if (cogNamerResponse.ErrorCode == CogNamerErrorCode.ErrorOnlySupportedDuringIpRequest)
				{
					return CommandSupport.OnlyDuringIPREQUEST;
				}
				return CommandSupport.NotSupported;
			}
			return CommandSupport.NotSupported;
		}

		public void SendSetNetwork(CogNamerDevice device, string username, string password, string hostname, bool useDhcp, IPAddress ip, IPAddress subnet, IPAddress gateway, IPAddress dns, string domainName, bool reset, int timeout, int retries)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			byte[] array = new byte[6];
			Array.Copy(BitConverter.GetBytes(device.MacAddressLong), array, 6);
			Array.Reverse(array);
			cogNamerRecordList.Add(CogNamerAttributeType.MacAddress, array);
			if (username != null && username != string.Empty)
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryWriter bw = new BinaryWriter(memoryStream);
				CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(username));
				CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(password));
				cogNamerRecordList.Add(CogNamerAttributeType.Credentials, memoryStream.ToArray());
			}
			cogNamerRecordList.Add(CogNamerAttributeType.HostName, hostname);
			if (ip == null)
			{
				ip = IPAddress.Any;
			}
			if (dns == null)
			{
				dns = IPAddress.Any;
			}
			if (gateway == null)
			{
				gateway = IPAddress.Any;
			}
			if (domainName == null)
			{
				domainName = string.Empty;
			}
			if (!useDhcp)
			{
				cogNamerRecordList.Add(new CogNamerIPAddressAttribute(ip).ToRecord());
				MemoryStream memoryStream2 = new MemoryStream();
				BinaryWriter bw2 = new BinaryWriter(memoryStream2);
				memoryStream2.WriteByte(0);
				CogNamerPacket.WriteIP(bw2, subnet);
				CogNamerPacket.WriteIP(bw2, gateway);
				CogNamerPacket.WriteIP(bw2, dns);
				CogNamerPacket.WriteString(bw2, domainName);
				cogNamerRecordList.Add(CogNamerAttributeType.NetworkSettings, memoryStream2.ToArray());
			}
			else
			{
				cogNamerRecordList.Add(CogNamerAttributeType.NetworkSettings, new byte[1] { 1 });
			}
			if (reset)
			{
				SendFactoryReset(device, username, password, timeout, retries);
				return;
			}
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(NamerCommand.IPAssign, NamerFlags.None, cogNamerRecordList, device, timeout, retries);
			if (cogNamerResponse == null || !cogNamerResponse.GotResponse)
			{
				throw new CogNamerCommunicationException(Strings.ResponseNotReceived);
			}
			if (cogNamerResponse.ErrorCode == CogNamerErrorCode.Success)
			{
				return;
			}
			throw new CogNamerException(cogNamerResponse.ErrorCode);
		}

		public void SendFactoryReset(CogNamerDevice device, string username, string password, int timeout, int retries)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			byte[] array = new byte[6];
			Array.Copy(BitConverter.GetBytes(device.MacAddressLong), array, 6);
			Array.Reverse(array);
			cogNamerRecordList.Add(CogNamerAttributeType.MacAddress, array);
			if (username != null && username != string.Empty)
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryWriter bw = new BinaryWriter(memoryStream);
				CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(username));
				CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(password));
				cogNamerRecordList.Add(CogNamerAttributeType.Credentials, memoryStream.ToArray());
			}
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(NamerCommand.FactoryReset, NamerFlags.None, cogNamerRecordList, device, timeout, retries);
			if (cogNamerResponse == null || !cogNamerResponse.GotResponse)
			{
				throw new CogNamerCommunicationException(Strings.ResponseNotReceived);
			}
			if (cogNamerResponse.ErrorCode != CogNamerErrorCode.Success)
			{
				throw new CogNamerException(cogNamerResponse.ErrorCode);
			}
		}

		public void SendRestart(CogNamerDevice device, string username, string password)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			cogNamerRecordList.Add(((CogNamerMacAddressAttribute)device.Attributes[CogNamerAttributeType.MacAddress]).ToRecord());
			if (username != null && username != string.Empty)
			{
				cogNamerRecordList.Add(CreateCredentialsRecord(username, password));
			}
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(NamerCommand.RestartSystem, NamerFlags.None, cogNamerRecordList, device, 1000, 3);
			if (cogNamerResponse == null || !cogNamerResponse.GotResponse)
			{
				throw new CogNamerCommunicationException(Strings.ResponseNotReceived);
			}
			if (cogNamerResponse.ErrorCode != CogNamerErrorCode.Success)
			{
				throw new CogNamerException(cogNamerResponse.ErrorCode);
			}
		}

		public void SendFlash(CogNamerDevice device)
		{
			SendCommand(NamerCommand.Flash, NamerFlags.None, null, device);
		}

		public void SendResetAdminPassword(CogNamerDevice device)
		{
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(NamerCommand.ResetAdminPassword, NamerFlags.Broadcast, null, device, 1000, 3);
			if (cogNamerResponse == null || !cogNamerResponse.GotResponse)
			{
				throw new CogNamerCommunicationException(Strings.ResponseNotReceived);
			}
			if (cogNamerResponse.ErrorCode != CogNamerErrorCode.Success)
			{
				throw new CogNamerException(cogNamerResponse.ErrorCode);
			}
		}

		public string GetDefaultHostName(CogNamerDevice device)
		{
			return (GetAttribute(device, CogNamerAttributeType.DefaultName) as CogNamerStringAttribute).StringValue;
		}

		public CogNamerNetworkDeviceAttribute GetAttribute(CogNamerDevice device, CogNamerAttributeType attribute)
		{
			return GetAttributes(device, new CogNamerAttributeType[1] { attribute })[attribute];
		}

		public INetworkDeviceAttributeProvider GetAttributes(CogNamerDevice device, CogNamerAttributeType[] attributes)
		{
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			CogNamerAttributeType[] array = attributes;
			foreach (CogNamerAttributeType type in array)
			{
				cogNamerRecordList.Add(new CogNamerRecord(type, string.Empty));
			}
			CogNamerResponse cogNamerResponse = SendCommandGetResponse(NamerCommand.GetAttribute, NamerFlags.None, cogNamerRecordList, device, 1000, 3);
			if (cogNamerResponse == null || !cogNamerResponse.GotResponse)
			{
				throw new CogNamerCommunicationException(Strings.ResponseNotReceived);
			}
			if (cogNamerResponse.ErrorCode == CogNamerErrorCode.ErrorNonExistentRecord)
			{
				if (cogNamerResponse.Records.Count == 0)
				{
					throw new CogNamerException(cogNamerResponse.ErrorCode);
				}
			}
			else if (cogNamerResponse.ErrorCode != CogNamerErrorCode.Success)
			{
				throw new CogNamerException(cogNamerResponse.ErrorCode);
			}
			CogNamerNetworkDeviceAttributeDictionary cogNamerNetworkDeviceAttributeDictionary = new CogNamerNetworkDeviceAttributeDictionary();
			array = attributes;
			foreach (CogNamerAttributeType type2 in array)
			{
				CogNamerNetworkDeviceAttribute attribute = cogNamerResponse.Records.GetAttribute(type2);
				if (attribute != null)
				{
					cogNamerNetworkDeviceAttributeDictionary.Add(attribute);
				}
			}
			return cogNamerNetworkDeviceAttributeDictionary;
		}

		private void HandlePacket(object sender, ICogNamerPacketReceivedEventArgs p)
		{
			if (p.Length < 8)
			{
				return;
			}
			using MemoryStream input = new MemoryStream(p.Data, 0, p.Length);
			using BinaryReader binaryReader = new BinaryReader(input);
			int num = IPAddress.NetworkToHostOrder(binaryReader.ReadInt32());
			if (1128746573 != num)
			{
				return;
			}
			try
			{
				int num2 = binaryReader.ReadByte();
				int num3 = binaryReader.ReadByte();
				int num4 = CogNamerPacket.ReadVarInt(binaryReader);
				if (_switch.TraceVerbose)
				{
					CogNamerTrace.WriteLine(string.Format(CultureInfo.CurrentCulture, "CvsNetworkMonitor: ReceivePacket - Magic[{0:x}] Version[{1}] Cmd[{2}]", new object[3] { num, num2, num4 }));
				}
				if (num2 == 4)
				{
					if ((num3 & 0x80) != 0)
					{
						HandleResponsePacket((NamerCommand)num4, p, binaryReader);
					}
					else if ((num3 & 0x20) == 0)
					{
						switch ((NamerCommand)num4)
						{
						case NamerCommand.Hello:
							HandleHelloPacket(p, binaryReader);
							break;
						case NamerCommand.IPRequest:
							HandleIPRequest(p, binaryReader);
							break;
						}
					}
				}
				p.Handled = true;
			}
			catch (Exception ex)
			{
				CogNamerTrace.WriteLineIf(_switch.TraceWarning, "CvsNetworkMonitor: ReceivePacket - WARNING - UNEXPECTED ERROR! " + ex.Message);
			}
		}

		public void NetworkChangedNotify()
		{
			SendRefresh();
		}

		private void HandleHelloPacket(ICogNamerPacketReceivedEventArgs p, BinaryReader br)
		{
			CogNamerPacket.ReadVarInt(br);
			CogNamerRecordList cogNamerRecordList = ReadRecords(br);
			IPAddress address = ((!(cogNamerRecordList.GetAttribute(CogNamerAttributeType.NetworkSettings) is CogNamerNetworkSettingsAttribute cogNamerNetworkSettingsAttribute)) ? IPAddress.Any : cogNamerNetworkSettingsAttribute.SubnetMask);
			CogNamerEthernetDeviceScope cogNamerEthernetDeviceScope = (p.IsPacketLocal(address) ? CogNamerEthernetDeviceScope.SubnetLocal : (IsRemoteSubnetPacket(p) ? CogNamerEthernetDeviceScope.RemoteSubnet : CogNamerEthernetDeviceScope.LinkLocal));
			_ = (CogNamerDeviceTypeAttribute)cogNamerRecordList.GetAttribute(CogNamerAttributeType.DeviceType);
			if (cogNamerEthernetDeviceScope == CogNamerEthernetDeviceScope.SubnetLocal || cogNamerEthernetDeviceScope == CogNamerEthernetDeviceScope.RemoteSubnet || _netMonitor.DiscoverMisconfiguredDevices)
			{
				CogNamerDevice cogNamerDevice = new CogNamerDevice(cogNamerRecordList.GetAttributes(), p.IPEndPoint.Address, p.LocalIP, cogNamerEthernetDeviceScope);
				if (PacketReceived != null)
				{
					PacketReceived(this, new CogNamerPacketEventArgs(CogNamerCommand.Hello, cogNamerDevice));
				}
				_netMonitor.AddHostToCache(cogNamerDevice);
			}
		}

		private void HandleIPRequest(ICogNamerPacketReceivedEventArgs p, BinaryReader br)
		{
			if (PacketReceived != null)
			{
				CogNamerPacket.ReadVarInt(br);
				CogNamerDevice device = new CogNamerDevice(ReadRecords(br).GetAttributes(), p.IPEndPoint.Address, p.LocalIP, CogNamerEthernetDeviceScope.LinkLocal);
				PacketReceived(this, new CogNamerPacketEventArgs(CogNamerCommand.IPRequest, device));
			}
		}

		private void HandleResponsePacket(NamerCommand nCmd, ICogNamerPacketReceivedEventArgs p, BinaryReader br)
		{
			int errorCode = CogNamerPacket.ReadVarInt(br);
			CogNamerRecordList cogNamerRecordList = null;
			lock (_waitingMessages)
			{
				foreach (CogNamerResponse waitingMessage in _waitingMessages)
				{
					if (waitingMessage.Command == nCmd)
					{
						if (cogNamerRecordList == null)
						{
							cogNamerRecordList = ReadRecords(br);
						}
						if (!(cogNamerRecordList.GetAttribute(CogNamerAttributeType.MacAddress) is CogNamerMacAddressAttribute cogNamerMacAddressAttribute))
						{
							break;
						}
						if (cogNamerMacAddressAttribute.MacAddress == waitingMessage.MacAddress)
						{
							waitingMessage.ErrorCode = (CogNamerErrorCode)errorCode;
							waitingMessage.Records = cogNamerRecordList;
							waitingMessage.GotResponse = true;
							waitingMessage.ResponseReceivedEvent.Set();
							break;
						}
					}
				}
			}
		}

		private void HandleQueryCache(ICogNamerPacketReceivedEventArgs p)
		{
			MemoryStream memoryStream = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(memoryStream);
			CogNamerErrorCode resultCode = CogNamerErrorCode.Success;
			foreach (CogNamerDevice item in _netMonitor.GetHostCache())
			{
				int num = 4 + CogNamerPacket.GetStringLength(item.HostName);
				if (memoryStream.Length + num > 8100)
				{
					resultCode = CogNamerErrorCode.ErrorQueryCacheRecordTruncated;
					break;
				}
				CogNamerPacket.WriteIP(bw, item.IPAddress);
				CogNamerPacket.WriteString(bw, item.HostName);
			}
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			cogNamerRecordList.Add(CogNamerAttributeType.KnownSystems, memoryStream.ToArray());
			SendResponse(NamerCommand.QueryCache, NamerFlags.None, resultCode, cogNamerRecordList, p.IPEndPoint);
		}

		public CogNamerRecord CreateCredentialsRecord(string user, string pass)
		{
			MemoryStream memoryStream = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(memoryStream);
			CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(user));
			CogNamerPacket.WriteString(bw, mEncryptor.Encrypt(pass));
			return new CogNamerRecord(CogNamerAttributeType.Credentials, memoryStream.ToArray());
		}

		public void RegisterCommandMapping(CogNamerCommand cmd, NamerCommand pCmd)
		{
			if (_CommandMap == null)
			{
				_CommandMap = new Dictionary<CogNamerCommand, NamerCommand>();
			}
			if (_CommandMap.ContainsKey(cmd))
			{
				_CommandMap.Remove(cmd);
			}
			_CommandMap.Add(cmd, pCmd);
		}

		private NamerCommand GetNamerCommand(CogNamerCommand cmd)
		{
			switch (cmd)
			{
			case CogNamerCommand.FactoryReset:
				return NamerCommand.FactoryReset;
			case CogNamerCommand.Flash:
				return NamerCommand.Flash;
			case CogNamerCommand.IPRequest:
				return NamerCommand.IPRequest;
			case CogNamerCommand.SetNetwork:
				return NamerCommand.IPAssign;
			case CogNamerCommand.Restart:
				return NamerCommand.RestartSystem;
			case CogNamerCommand.SetAttribute:
				return NamerCommand.SetAttribute;
			case CogNamerCommand.ResetAdminPassword:
				return NamerCommand.ResetAdminPassword;
			default:
				if (_CommandMap.ContainsKey(cmd))
				{
					return _CommandMap[cmd];
				}
				return NamerCommand.NOOP;
			}
		}

		public void SendCommand(NamerCommand cmd, NamerFlags flags, CogNamerRecordList records, CogNamerDevice device)
		{
			if (records == null)
			{
				records = new CogNamerRecordList();
			}
			if (records.FindRecord(CogNamerAttributeType.MacAddress) == null)
			{
				byte[] array = new byte[6];
				Array.Copy(BitConverter.GetBytes(device.MacAddressLong), array, 6);
				Array.Reverse(array);
				records.Add(new CogNamerRecord(CogNamerAttributeType.MacAddress, array));
			}
			IPEndPoint iPEndPoint = null;
			if (CanSendUnicast(device))
			{
				SendCommandEx(cmd, flags, CogNamerErrorCode.Success, records, GetUnicastEndpoint(device));
			}
			else if (_netMonitor.DiscoverMisconfiguredDevices || device.Scope == CogNamerEthernetDeviceScope.LinkLocal)
			{
				iPEndPoint = new IPEndPoint(IPAddress.Broadcast, 1069);
				flags |= NamerFlags.Broadcast;
				SendCommandEx(cmd, flags, CogNamerErrorCode.Success, records, iPEndPoint);
			}
		}

		private IPEndPoint GetUnicastEndpoint(CogNamerDevice device)
		{
			int num = device.GetServicePort("cognamer-udp");
			if (num <= 0)
			{
				num = 1069;
			}
			return new IPEndPoint(device.IPAddress, num);
		}

		private bool CanSendUnicast(CogNamerDevice device)
		{
			if (device.Scope == CogNamerEthernetDeviceScope.LinkLocal)
			{
				return false;
			}
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			byte[] array = new byte[6];
			Array.Copy(BitConverter.GetBytes(device.MacAddressLong), array, 6);
			Array.Reverse(array);
			cogNamerRecordList.Add(new CogNamerRecord(CogNamerAttributeType.MacAddress, array));
			return SendCommandGetResponse(NamerCommand.NOOP, NamerFlags.None, cogNamerRecordList, GetUnicastEndpoint(device), device.MacAddressLong, 1000, 3).GotResponse;
		}

		private void SendResponse(NamerCommand cmd, NamerFlags flags, CogNamerErrorCode resultCode, CogNamerRecordList records, IPEndPoint endPoint)
		{
			flags |= NamerFlags.Response;
			SendCommandEx(cmd, flags, resultCode, records, endPoint);
		}

		public void SendCommandEx(NamerCommand cmd, NamerFlags flags, CogNamerErrorCode resultCode, CogNamerRecordList records, IPEndPoint endPoint)
		{
			if (_netMonitor.TestMode)
			{
				TestCallback((int)cmd, (byte)flags, resultCode, records, null);
				return;
			}
			byte[] buffer = new CogNamerPacket((int)cmd, (byte)flags, (int)resultCode, records).GetBuffer();
			try
			{
				if (endPoint == null)
				{
					_netInterface.SendSubnetBroadcast(buffer, buffer.Length);
				}
				else
				{
					_netInterface.SendPacket(buffer, buffer.Length, endPoint);
				}
			}
			catch (SocketException)
			{
			}
		}

		public CogNamerResponse SendCommandGetResponse(NamerCommand cmd, NamerFlags flags, CogNamerRecordList records, CogNamerDevice device, int timeout, int retries)
		{
			IPEndPoint endPoint = null;
			if ((flags & NamerFlags.Broadcast) == 0 && device.Scope != CogNamerEthernetDeviceScope.LinkLocal && CanSendUnicast(device))
			{
				endPoint = GetUnicastEndpoint(device);
			}
			else if (_netMonitor.DiscoverMisconfiguredDevices || device.Scope == CogNamerEthernetDeviceScope.LinkLocal)
			{
				endPoint = new IPEndPoint(IPAddress.Broadcast, 1069);
				flags |= NamerFlags.Broadcast;
			}
			if (records == null)
			{
				records = new CogNamerRecordList();
			}
			if (records.FindRecord(CogNamerAttributeType.MacAddress) == null)
			{
				byte[] array = new byte[6];
				Array.Copy(BitConverter.GetBytes(device.MacAddressLong), array, 6);
				Array.Reverse(array);
				records.Add(new CogNamerRecord(CogNamerAttributeType.MacAddress, array));
			}
			return SendCommandGetResponse(cmd, flags, records, endPoint, device.MacAddressLong, timeout, retries);
		}

		public CogNamerResponse SendCommandGetResponse(NamerCommand cmd, NamerFlags flags, CogNamerRecordList records, IPEndPoint endPoint, long macAddress, int timeout, int retries)
		{
			CogNamerResponse cogNamerResponse = new CogNamerResponse(cmd, macAddress);
			lock (_waitingMessages)
			{
				_waitingMessages.Add(cogNamerResponse);
			}
			for (int i = 0; i < retries; i++)
			{
				if (cogNamerResponse.GotResponse)
				{
					break;
				}
				SendCommandEx(cmd, flags, CogNamerErrorCode.Success, records, endPoint);
				cogNamerResponse.GotResponse = cogNamerResponse.ResponseReceivedEvent.WaitOne(timeout, exitContext: false);
			}
			lock (_waitingMessages)
			{
				_waitingMessages.Remove(cogNamerResponse);
				return cogNamerResponse;
			}
		}

		private CogNamerRecordList ReadRecords(BinaryReader br)
		{
			int num = CogNamerPacket.ReadVarInt(br);
			if (br.BaseStream.Position + num > br.BaseStream.Length)
			{
				throw new CogNamerCommunicationException("Inconsistent Length");
			}
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			try
			{
				while (br.BaseStream.Position + 2 < br.BaseStream.Length)
				{
					int type = br.ReadByte();
					int count = CogNamerPacket.ReadVarInt(br);
					cogNamerRecordList.Add(new CogNamerRecord((CogNamerAttributeType)type, br.ReadBytes(count)));
				}
			}
			catch (EndOfStreamException)
			{
			}
			return cogNamerRecordList;
		}

		private bool IsRemoteSubnetPacket(ICogNamerPacketReceivedEventArgs p)
		{
			foreach (ICogNamerRemoteSubnet remoteSubnet in _netMonitor.RemoteSubnets)
			{
				int num = BitConverter.ToInt32(remoteSubnet.IPAddress.GetAddressBytes(), 0);
				int num2 = BitConverter.ToInt32(remoteSubnet.Mask.GetAddressBytes(), 0);
				int num3 = BitConverter.ToInt32(p.IPEndPoint.Address.GetAddressBytes(), 0);
				if ((num & num2) == (num3 & num2))
				{
					return true;
				}
			}
			return false;
		}
	}

	protected class CogNamerRemoteSubnetBrowser
	{
		private readonly ICogNamerRemoteSubnet mSubnet;

		public const int DiscoveryRateMsDefault = 50;

		private readonly int mDiscoveryRateMs;

		private const int mInterScanDelay = 120000;

		private readonly int mMaxHostAddress;

		private readonly uint mNetAddress;

		private object mSyncRoot = new object();

		private volatile TaskCompletionSource<bool> mRefresh = new TaskCompletionSource<bool>();

		public ICogNamerRemoteSubnet RemoteSubnet => mSubnet;

		public CogNamerRemoteSubnetBrowser(ICogNamerRemoteSubnet subnet, IProgress<CogNamerDevice> progress, CancellationToken cancel, int discoveryRate = 50)
		{
			CogNamerRemoteSubnetBrowser cogNamerRemoteSubnetBrowser = this;
			mSubnet = subnet;
			mDiscoveryRateMs = discoveryRate;
			mNetAddress = (uint)IPAddress.NetworkToHostOrder((int)(BitConverter.ToUInt32(subnet.IPAddress.GetAddressBytes(), 0) & BitConverter.ToUInt32(subnet.Mask.GetAddressBytes(), 0)));
			mMaxHostAddress = IPAddress.NetworkToHostOrder((int)(~BitConverter.ToUInt32(subnet.Mask.GetAddressBytes(), 0)));
			Task.Run(() => cogNamerRemoteSubnetBrowser.ResolveDevices(progress, cancel)).ConfigureAwait(continueOnCapturedContext: false);
		}

		public void Refresh()
		{
			Task.Run(() => mRefresh.TrySetResult(result: true));
		}

		private async Task ResolveDevices(IProgress<CogNamerDevice> progress, CancellationToken cancel)
		{
			while (!cancel.IsCancellationRequested)
			{
				try
				{
					List<Task> tasklist = new List<Task>();
					Task<bool> originalRefreshTask = mRefresh.Task;
					int i = 1;
					while (i <= mMaxHostAddress)
					{
						uint ipAddr = mNetAddress + (uint)i;
						Task item = Task.Run(async () =>
						{
							if (originalRefreshTask.IsCompleted || cancel.IsCancellationRequested)
							{
								return;
							}
							IPAddress ip = new IPAddress(BitConverter.GetBytes(IPAddress.HostToNetworkOrder((int)ipAddr)));
							try
							{
								CogNamerDevice cogNamerDevice = await ResolveDeviceAsync(ip, cancel).ConfigureAwait(continueOnCapturedContext: false);
								if (cogNamerDevice != null)
								{
									progress.Report(cogNamerDevice);
								}
							}
							catch (CogNamerCommunicationException)
							{
							}
						});
						tasklist.Add(item);
						if (cancel.IsCancellationRequested)
						{
							break;
						}
						await Task.Delay(mDiscoveryRateMs, cancel);
						if (mRefresh.Task.IsCompleted)
						{
							break;
						}
						int num = i + 1;
						i = num;
					}
					await ScanAndWait(tasklist, cancel);
					mRefresh = new TaskCompletionSource<bool>();
				}
				catch (OperationCanceledException)
				{
				}
				catch (Exception)
				{
				}
			}
		}

		private async Task ScanAndWait(List<Task> tasklist, CancellationToken cancel)
		{
			await Task.WhenAny(mRefresh.Task, Task.WhenAll(tasklist)).WithWaitCancellation(cancel).ConfigureAwait(continueOnCapturedContext: false);
			await Task.WhenAny(mRefresh.Task, Task.Delay(120000)).WithWaitCancellation(cancel).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	protected static class CogNamerResolver
	{
		private enum ResolveMode
		{
			Unicast,
			LocalBroadcast,
			SubnetBroadcast,
			Loopback
		}

		private const int RecvPacketSize = 8196;

		private const int RecvBufferSize = 130000;

		private const int NamerMagic4 = 1128746573;

		private const int NamerPort = 1069;

		private const int AltNamerPort = 51069;

		private const int FlexibleNamerProtocolVersion = 4;

		private static int ResolveReadTimeout = 50;

		public static async Task<CogNamerDevice> ResolveAsync(CogNamerNetworkDeviceAttribute filter, int timeout, IPAddress dstIp, CancellationToken cancel = default(CancellationToken))
		{
			CogNamerDevice device = null;
			ResolveMode mode = GetResolveMode(dstIp);
			Dictionary<Socket, ICogNamerNetworkAdapter> netSockets = null;
			List<CancellationTokenRegistration> registrationList = new List<CancellationTokenRegistration>();
			try
			{
				CogNamerProtocolHandler.NamerFlags namerFlags = CogNamerProtocolHandler.NamerFlags.None;
				if (dstIp.Equals(IPAddress.Broadcast))
				{
					namerFlags = CogNamerProtocolHandler.NamerFlags.Broadcast;
				}
				netSockets = BindSockets(mode);
				CogNamerRecordList cogNamerRecordList = new CogNamerRecordList(1);
				if (filter != null)
				{
					cogNamerRecordList.Add(filter.ToRecord());
				}
				CogNamerPacket packet = new CogNamerPacket(2, (byte)namerFlags, 0, cogNamerRecordList);
				byte[] recvBuffer = new byte[8196];
				int timeoutTicks = Environment.TickCount + timeout;
				int sendCount = 0;
				while (device == null && timeoutTicks - Environment.TickCount > 0)
				{
					foreach (Socket s in netSockets.Keys)
					{
						if (cancel != CancellationToken.None)
						{
							registrationList.Add(cancel.Register(() =>
							{
								try
								{
									s.Close();
								}
								catch
								{
								}
							}));
						}
						switch (mode)
						{
						case ResolveMode.SubnetBroadcast:
						case ResolveMode.Loopback:
							await SendSubnetBroadcastAsync(netSockets[s], s, packet);
							break;
						case ResolveMode.LocalBroadcast:
							await SendLocalBroadcastAsync(s, packet);
							break;
						case ResolveMode.Unicast:
							await SendUnicastAsync(s, packet, dstIp, sendCount > 0);
							break;
						}
					}
					int num = sendCount + 1;
					sendCount = num;
					int nextSend = Environment.TickCount + timeout / 3;
					IPEndPoint packetEndpoint = new IPEndPoint(IPAddress.Any, 0);
					while (device == null && nextSend > Environment.TickCount)
					{
						await Task.Delay(ResolveReadTimeout, cancel);
						List<Socket> list = new List<Socket>(netSockets.Keys);
						Socket.Select(list, null, null, 0);
						foreach (Socket s2 in list)
						{
							_ = IPAddress.Any;
							SocketFlags flags = SocketFlags.None;
							SocketExtensions.ReceiveInfo receiveInfo = await s2.ReceiveFromAsync(recvBuffer, recvBuffer.Length, packetEndpoint, flags);
							CogNamerNetworkAdapter networkInterface = GetNetworkInterface(receiveInfo.PacketInfo.Interface);
							IPAddress localAddress = ((networkInterface != null) ? networkInterface.IP : IPAddress.Any);
							device = ProcessPacket(netSockets[s2], ((IPEndPoint)receiveInfo.EndPoint).Address, receiveInfo.Buffer, receiveInfo.Length, mode, localAddress);
							if (device != null && filter != null && !ContainsAttribute(device, filter))
							{
								device = null;
							}
						}
					}
				}
				return device;
			}
			catch (SocketException ex)
			{
				throw new CogNamerCommunicationException(ex);
			}
			catch (ObjectDisposedException)
			{
				throw new CogNamerCommunicationException("Timeout");
			}
			finally
			{
				foreach (Socket key in netSockets.Keys)
				{
					key.Close();
				}
				registrationList.ForEach((CancellationTokenRegistration r) =>
				{
					r.Dispose();
				});
			}
		}

		public static CogNamerDevice Resolve(CogNamerNetworkDeviceAttribute filter, int timeout, IPAddress dstIp)
		{
			CogNamerDevice cogNamerDevice = null;
			ResolveMode resolveMode = GetResolveMode(dstIp);
			Dictionary<Socket, ICogNamerNetworkAdapter> dictionary = null;
			try
			{
				CogNamerProtocolHandler.NamerFlags namerFlags = CogNamerProtocolHandler.NamerFlags.None;
				if (dstIp.Equals(IPAddress.Broadcast))
				{
					namerFlags = CogNamerProtocolHandler.NamerFlags.Broadcast;
				}
				dictionary = BindSockets(resolveMode);
				CogNamerRecordList cogNamerRecordList = new CogNamerRecordList(1);
				if (filter != null)
				{
					cogNamerRecordList.Add(filter.ToRecord());
				}
				CogNamerPacket packet = new CogNamerPacket(2, (byte)namerFlags, 0, cogNamerRecordList);
				byte[] array = new byte[8196];
				int num = Environment.TickCount + timeout;
				int num2 = 0;
				while (cogNamerDevice == null && num - Environment.TickCount > 0)
				{
					foreach (Socket key in dictionary.Keys)
					{
						switch (resolveMode)
						{
						case ResolveMode.SubnetBroadcast:
						case ResolveMode.Loopback:
							SendSubnetBroadcast(dictionary[key], key, packet);
							break;
						case ResolveMode.LocalBroadcast:
							SendLocalBroadcast(key, packet);
							break;
						case ResolveMode.Unicast:
							SendUnicast(key, packet, dstIp, num2 > 0);
							break;
						}
					}
					num2++;
					int num3 = Environment.TickCount + timeout / 3;
					int num4 = num3 - Environment.TickCount;
					EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
					while (cogNamerDevice == null && num4 > 0)
					{
						List<Socket> list = new List<Socket>(dictionary.Keys);
						Socket.Select(list, null, null, num4 * 1000);
						foreach (Socket item in list)
						{
							IPAddress any = IPAddress.Any;
							SocketFlags socketFlags = SocketFlags.None;
							int len = item.ReceiveMessageFrom(array, 0, array.Length, ref socketFlags, ref remoteEP, out var ipPacketInformation);
							CogNamerNetworkAdapter networkInterface = GetNetworkInterface(ipPacketInformation.Interface);
							any = ((networkInterface != null) ? networkInterface.IP : IPAddress.Any);
							cogNamerDevice = ProcessPacket(dictionary[item], ((IPEndPoint)remoteEP).Address, array, len, resolveMode, any);
							if (cogNamerDevice != null && filter != null && !ContainsAttribute(cogNamerDevice, filter))
							{
								cogNamerDevice = null;
							}
						}
						num4 = num3 - Environment.TickCount;
					}
				}
			}
			catch (SocketException ex)
			{
				throw new CogNamerCommunicationException(ex);
			}
			finally
			{
				foreach (Socket key2 in dictionary.Keys)
				{
					key2.Close();
				}
			}
			return cogNamerDevice;
		}

		private static Dictionary<Socket, ICogNamerNetworkAdapter> BindSockets(ResolveMode mode)
		{
			Dictionary<Socket, ICogNamerNetworkAdapter> dictionary = new Dictionary<Socket, ICogNamerNetworkAdapter>();
			switch (mode)
			{
			case ResolveMode.Unicast:
			{
				Socket key2 = BindCogNamerSocket(IPAddress.Any, 0, reuse: false);
				dictionary[key2] = null;
				break;
			}
			case ResolveMode.Loopback:
			{
				CogNamerNetworkAdapter[] allNetworkAdapters = CogNamerNetworkAdapter.GetAllNetworkAdapters();
				foreach (CogNamerNetworkAdapter cogNamerNetworkAdapter2 in allNetworkAdapters)
				{
					if (cogNamerNetworkAdapter2.IsLoopback)
					{
						Socket key3 = BindCogNamerSocket(cogNamerNetworkAdapter2.IP, 0, reuse: false);
						dictionary[key3] = cogNamerNetworkAdapter2;
					}
				}
				break;
			}
			default:
			{
				bool flag = mode == ResolveMode.LocalBroadcast;
				CogNamerNetworkAdapter[] allNetworkAdapters = CogNamerNetworkAdapter.GetAllNetworkAdapters();
				foreach (CogNamerNetworkAdapter cogNamerNetworkAdapter in allNetworkAdapters)
				{
					Socket key = BindCogNamerSocket(cogNamerNetworkAdapter.IP, flag ? 1069 : 0, flag);
					dictionary[key] = cogNamerNetworkAdapter;
				}
				break;
			}
			}
			return dictionary;
		}

		private static Socket BindCogNamerSocket(IPAddress localIP, int port, bool reuse)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, 130000);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
			socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, 1);
			if (reuse)
			{
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
			}
			socket.Bind(new IPEndPoint(localIP, port));
			NetworkUtils.DisableUdpConnReset(socket);
			return socket;
		}

		private static Task SendSubnetBroadcastAsync(ICogNamerNetworkAdapter adapter, Socket sock, CogNamerPacket packet)
		{
			return sock.SendToAsync(new IPEndPoint(adapter.SubnetBroadcast, 1069), packet.GetBuffer(), packet.GetBuffer().Length);
		}

		private static void SendSubnetBroadcast(ICogNamerNetworkAdapter adapter, Socket sock, CogNamerPacket packet)
		{
			byte[] buffer = packet.GetBuffer();
			sock.SendTo(buffer, buffer.Length, SocketFlags.None, new IPEndPoint(adapter.SubnetBroadcast, 1069));
		}

		private static Task SendLocalBroadcastAsync(Socket sock, CogNamerPacket packet)
		{
			return sock.SendToAsync(new IPEndPoint(IPAddress.Broadcast, 1069), packet.GetBuffer(), packet.GetBuffer().Length);
		}

		private static void SendLocalBroadcast(Socket sock, CogNamerPacket packet)
		{
			sock.SendTo(packet.GetBuffer(), packet.GetBuffer().Length, SocketFlags.None, new IPEndPoint(IPAddress.Broadcast, 1069));
		}

		private static Task SendUnicastAsync(Socket sock, CogNamerPacket packet, IPAddress dstIp, bool altPort)
		{
			if (dstIp.Equals(IPAddress.Loopback))
			{
				dstIp = IPAddress.Parse("127.255.255.255");
			}
			List<Task> list = new List<Task>();
			list.Add(sock.SendToAsync(new IPEndPoint(dstIp, 1069), packet.GetBuffer(), packet.GetBuffer().Length));
			if (altPort)
			{
				list.Add(sock.SendToAsync(new IPEndPoint(dstIp, 51069), packet.GetBuffer(), packet.GetBuffer().Length));
			}
			return Task.WhenAll(list);
		}

		private static void SendUnicast(Socket sock, CogNamerPacket packet, IPAddress dstIp, bool altPort)
		{
			sock.SendTo(packet.GetBuffer(), packet.GetBuffer().Length, SocketFlags.None, new IPEndPoint(dstIp, 1069));
			if (altPort)
			{
				sock.SendTo(packet.GetBuffer(), packet.GetBuffer().Length, SocketFlags.None, new IPEndPoint(dstIp, 51069));
			}
		}

		private static CogNamerDevice ProcessPacket(ICogNamerNetworkAdapter adapter, IPAddress deviceEndPoint, byte[] buffer, int len, ResolveMode mode, IPAddress localAddress)
		{
			if (len < 8)
			{
				return null;
			}
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(buffer, 0, len));
			int num = IPAddress.NetworkToHostOrder(binaryReader.ReadInt32());
			if (1128746573 != num)
			{
				return null;
			}
			try
			{
				int num2 = binaryReader.ReadByte();
				int num3 = binaryReader.ReadByte();
				int num4 = CogNamerPacket.ReadVarInt(binaryReader);
				bool broadcast = (num3 & 0x40) != 0;
				if (num2 == 4 && (num3 & 0x80) == 0 && (num3 & 0x20) == 0 && num4 == 1)
				{
					CogNamerPacket.ReadVarInt(binaryReader);
					INetworkDeviceAttributeProvider attributes = ReadRecords(binaryReader, len).GetAttributes();
					CogNamerEthernetDeviceScope scope = GetScope(adapter, attributes, broadcast, mode);
					return new CogNamerDevice(attributes, deviceEndPoint, localAddress, scope);
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		private static CogNamerEthernetDeviceScope GetScope(ICogNamerNetworkAdapter adapter, INetworkDeviceAttributeProvider attributes, bool broadcast, ResolveMode mode)
		{
			CogNamerIPAddressAttribute cogNamerIPAddressAttribute = attributes[CogNamerAttributeType.IpAddress] as CogNamerIPAddressAttribute;
			if (attributes[CogNamerAttributeType.NetworkSettings] is CogNamerNetworkSettingsAttribute cogNamerNetworkSettingsAttribute && cogNamerIPAddressAttribute != null)
			{
				if (mode == ResolveMode.Unicast)
				{
					CogNamerNetworkAdapter[] allNetworkAdapters = CogNamerNetworkAdapter.GetAllNetworkAdapters();
					for (int i = 0; i < allNetworkAdapters.Length; i++)
					{
						if (allNetworkAdapters[i].IsInSubnet(cogNamerIPAddressAttribute.IPAddress))
						{
							return CogNamerEthernetDeviceScope.SubnetLocal;
						}
					}
					return CogNamerEthernetDeviceScope.RemoteSubnet;
				}
				if (adapter != null)
				{
					if (adapter.IsLoopback || (adapter.SubnetMask.Equals(cogNamerNetworkSettingsAttribute.SubnetMask) && adapter.IsInSubnet(cogNamerIPAddressAttribute.IPAddress)))
					{
						return CogNamerEthernetDeviceScope.SubnetLocal;
					}
					if (broadcast || mode == ResolveMode.LocalBroadcast)
					{
						return CogNamerEthernetDeviceScope.LinkLocal;
					}
				}
			}
			return CogNamerEthernetDeviceScope.Unknown;
		}

		private static CogNamerRecordList ReadRecords(BinaryReader br, int len)
		{
			int num = CogNamerPacket.ReadVarInt(br);
			if (br.BaseStream.Position + num > len)
			{
				throw new CogNamerCommunicationException("Inconsistent Length");
			}
			CogNamerRecordList cogNamerRecordList = new CogNamerRecordList();
			try
			{
				while (br.BaseStream.Position + 2 < len)
				{
					int type = br.ReadByte();
					int count = CogNamerPacket.ReadVarInt(br);
					cogNamerRecordList.Add(new CogNamerRecord((CogNamerAttributeType)type, br.ReadBytes(count)));
				}
			}
			catch (EndOfStreamException)
			{
			}
			return cogNamerRecordList;
		}

		private static bool ContainsAttribute(CogNamerDevice host, CogNamerNetworkDeviceAttribute filterAttr)
		{
			bool result = false;
			if (host.Attributes.Contains(filterAttr.AttributeType) && host.Attributes[filterAttr.AttributeType].Equals(filterAttr))
			{
				result = true;
			}
			return result;
		}

		private static ResolveMode GetResolveMode(IPAddress dstIP)
		{
			if (dstIP.Equals(IPAddress.Broadcast))
			{
				return ResolveMode.LocalBroadcast;
			}
			if (dstIP.Equals(IPAddress.Any))
			{
				return ResolveMode.SubnetBroadcast;
			}
			if (dstIP.Equals(IPAddress.Loopback))
			{
				return ResolveMode.Loopback;
			}
			return ResolveMode.Unicast;
		}

		private static CogNamerNetworkAdapter GetNetworkInterface(int index)
		{
			CogNamerNetworkAdapter[] allNetworkAdapters = CogNamerNetworkAdapter.GetAllNetworkAdapters();
			foreach (CogNamerNetworkAdapter cogNamerNetworkAdapter in allNetworkAdapters)
			{
				if (cogNamerNetworkAdapter.Index == index)
				{
					return cogNamerNetworkAdapter;
				}
			}
			return null;
		}
	}

	internal static TraceSwitch __switch = new TraceSwitch("CogNamerNetworkMonitor", "Trace Level");

	private readonly int _discoveryRateMs;

	protected ICogNamerNetworkMonitorNetworkInterface _netInterface;

	protected CogNamerProtocolHandler _V4Handler;

	private readonly object _lockHosts = new object();

	private CogNamerNetworkDeviceType[] _deviceTypes = new CogNamerNetworkDeviceType[1];

	private bool _refreshQueued;

	private readonly SynchronizationContext _syncContext;

	private bool _isDisposed;

	private IList<CogNamerDevice> _hosts;

	private readonly Dictionary<string, CogNamerDevice> _internalHosts = new Dictionary<string, CogNamerDevice>();

	private readonly AutoResetEvent _newHostEvent = new AutoResetEvent(initialState: false);

	private bool _discoverMisconfiguredDevices;

	private readonly Dictionary<long, CogNamerDevice> _bootList = new Dictionary<long, CogNamerDevice>();

	private readonly Dictionary<long, int> _bootTimes = new Dictionary<long, int>();

	private bool _testMode;

	private readonly List<ICogNamerRemoteSubnet> _remoteSubnets = new List<ICogNamerRemoteSubnet>();

	private List<ICogNamerRemoteSubnet> _internalRemoteSubnets = new List<ICogNamerRemoteSubnet>();

	private readonly List<CogNamerRemoteSubnetBrowser> _remoteSubnetBrowsers = new List<CogNamerRemoteSubnetBrowser>();

	private CancellationTokenSource mSubnetBrowserCancel = new CancellationTokenSource();

	public static int ResolveTimeout = 2000;

	internal bool IsDisposed => _isDisposed;

	public ICollection<CogNamerDevice> Hosts
	{
		get
		{
			lock (_lockHosts)
			{
				if (_hosts == null)
				{
					List<CogNamerDevice> list = new List<CogNamerDevice>();
					foreach (CogNamerDevice value in _internalHosts.Values)
					{
						list.Add(value);
					}
					_hosts = list.AsReadOnly();
				}
				return _hosts;
			}
		}
	}

	public bool DiscoverMisconfiguredDevices
	{
		get
		{
			return _discoverMisconfiguredDevices;
		}
		set
		{
			_discoverMisconfiguredDevices = value;
		}
	}

	public CogNamerNetworkDeviceType[] DeviceTypes
	{
		get
		{
			return _deviceTypes;
		}
		set
		{
			_deviceTypes = value;
			Refresh();
		}
	}

	public IList<ICogNamerRemoteSubnet> RemoteSubnets => _remoteSubnets;

	internal bool TestMode => _testMode;

	public event CogNamerPacketEventHandler SystemBootDetected;

	public event CogNamerPacketEventHandler PacketReceived;

	public event PropertyChangedEventHandler HostsChanged;

	public CogNamerListener()
		: this(null)
	{
	}

	public CogNamerListener(ICogNamerNetworkMonitorNetworkInterface netInterface)
		: this(null, netInterface)
	{
	}

	public CogNamerListener(SynchronizationContext sync, ICogNamerNetworkMonitorNetworkInterface netInterface, int remoteSubnetDiscoveryMsRate = 50)
	{
		if (Environment.OSVersion.Version.CompareTo(new Version(5, 1)) < 0)
		{
			throw new PlatformNotSupportedException();
		}
		try
		{
			_syncContext = sync;
			_netInterface = netInterface ?? new CogNamerNetworkMonitorNetworkInterface();
			_discoveryRateMs = remoteSubnetDiscoveryMsRate;
			_V4Handler = new CogNamerProtocolHandler(this, _netInterface);
			_V4Handler.PacketReceived += NamerPacketNotify;
			_netInterface.Start();
		}
		catch (Exception ex)
		{
			CogNamerTrace.TraceError("Exception in CvsNetworkMonitor.Initialize: " + ex.ToString());
			DoDispose();
			throw;
		}
	}

	public void Dispose()
	{
		DoDispose();
		GC.SuppressFinalize(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected virtual void DoDispose()
	{
		_isDisposed = true;
		mSubnetBrowserCancel.Cancel();
		_remoteSubnetBrowsers.Clear();
		if (_netInterface != null)
		{
			_netInterface.Dispose();
			_netInterface = null;
		}
	}

	private void NotifyHostsChanged(PropertyChangedEventArgs propertyChangedEventArgs)
	{
		if (HostsChanged == null)
		{
			return;
		}
		if (_syncContext == null)
		{
			HostsChanged(this, propertyChangedEventArgs);
			return;
		}
		SendOrPostCallback d = (object o) =>
		{
			HostsChanged(this, propertyChangedEventArgs);
		};
		_syncContext.Post(d, this);
	}

	private void NotifySystemBootDetected(CogNamerPacketEventArgs e)
	{
		if (SystemBootDetected == null)
		{
			return;
		}
		if (_syncContext == null)
		{
			SystemBootDetected(this, e);
			return;
		}
		SendOrPostCallback d = (object o) =>
		{
			CogNamerPacketEventArgs e2 = o as CogNamerPacketEventArgs;
			if (SystemBootDetected != null)
			{
				SystemBootDetected(this, e2);
			}
		};
		_syncContext.Post(d, e);
	}

	public virtual void Refresh()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(null);
		}
		if (!_refreshQueued)
		{
			_refreshQueued = true;
			ClearHosts();
			_bootList.Clear();
			_bootTimes.Clear();
			_netInterface.ClearCachedInterfaceInfo();
			UpdateRemoteSubnetBrowsers();
			ThreadPool.QueueUserWorkItem(SendIdentify, this);
		}
	}

	internal void ConfigureTestMode(bool val, SendCommandExDelegate callbackTarget)
	{
		_V4Handler.TestCallback = callbackTarget;
		_testMode = val;
	}

	private bool TryIpParse(string name, out IPAddress ip)
	{
		if ((name[0] >= '0' && name[0] <= '9') || name.IndexOf('.') >= 0)
		{
			try
			{
				ip = IPAddress.Parse(name);
				return true;
			}
			catch (FormatException)
			{
			}
		}
		ip = null;
		return false;
	}

	public CogNamerDevice Resolve(string name)
	{
		if (TryIpParse(name, out var ip))
		{
			return Resolve(ip);
		}
		lock (_lockHosts)
		{
			foreach (CogNamerDevice value in _internalHosts.Values)
			{
				if (string.Compare(value.HostName, name, ignoreCase: true) == 0)
				{
					return value;
				}
			}
		}
		CogNamerDevice cogNamerDevice = null;
		try
		{
			cogNamerDevice = ResolveDevice(name);
		}
		catch (CogNamerCommunicationException)
		{
		}
		if (cogNamerDevice == null && DiscoverMisconfiguredDevices)
		{
			try
			{
				cogNamerDevice = ResolveDevice(name, broadcast: true);
			}
			catch (CogNamerCommunicationException)
			{
			}
		}
		return cogNamerDevice;
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(string name, CancellationToken cancel)
	{
		return ResolveDeviceAsync(name, broadcast: false, cancel);
	}

	public static CogNamerDevice ResolveDevice(string name)
	{
		return ResolveDevice(name, broadcast: false);
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(string name, bool broadcast, CancellationToken cancel)
	{
		return CogNamerResolver.ResolveAsync(new CogNamerStringAttribute(CogNamerAttributeType.HostName, name), ResolveTimeout, broadcast ? IPAddress.Broadcast : IPAddress.Any, cancel);
	}

	public static CogNamerDevice ResolveDevice(string name, bool broadcast)
	{
		return CogNamerResolver.Resolve(new CogNamerStringAttribute(CogNamerAttributeType.HostName, name), ResolveTimeout, broadcast ? IPAddress.Broadcast : IPAddress.Any);
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(PhysicalAddress macId, bool broadcast, CancellationToken cancel)
	{
		return CogNamerResolver.ResolveAsync(new CogNamerMacAddressAttribute(macId.GetAddressBytes()), ResolveTimeout, broadcast ? IPAddress.Broadcast : IPAddress.Any, cancel);
	}

	public static CogNamerDevice ResolveDevice(PhysicalAddress macId, bool broadcast)
	{
		return CogNamerResolver.Resolve(new CogNamerMacAddressAttribute(macId.GetAddressBytes()), ResolveTimeout, broadcast ? IPAddress.Broadcast : IPAddress.Any);
	}

	public static CogNamerDevice ResolveDevice(PhysicalAddress macId, bool broadcast, int timeout)
	{
		return CogNamerResolver.Resolve(new CogNamerMacAddressAttribute(macId.GetAddressBytes()), timeout, broadcast ? IPAddress.Broadcast : IPAddress.Any);
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(IPAddress ip, CancellationToken cancel)
	{
		return CogNamerResolver.ResolveAsync(null, ResolveTimeout, ip, cancel);
	}

	public static CogNamerDevice ResolveDevice(IPAddress ip)
	{
		return CogNamerResolver.Resolve(null, ResolveTimeout, ip);
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(IPAddress ip, PhysicalAddress macId, CancellationToken cancel = default(CancellationToken))
	{
		return CogNamerResolver.ResolveAsync(new CogNamerMacAddressAttribute(macId.GetAddressBytes()), ResolveTimeout, ip, cancel);
	}

	public static CogNamerDevice ResolveDevice(IPAddress ip, PhysicalAddress macId)
	{
		return CogNamerResolver.Resolve(new CogNamerMacAddressAttribute(macId.GetAddressBytes()), ResolveTimeout, ip);
	}

	public static Task<CogNamerDevice> ResolveDeviceAsync(IPAddress ip, string hostName, CancellationToken cancel = default(CancellationToken))
	{
		return CogNamerResolver.ResolveAsync(new CogNamerStringAttribute(CogNamerAttributeType.HostName, hostName), ResolveTimeout, ip, cancel);
	}

	public static CogNamerDevice ResolveDevice(IPAddress ip, string hostName)
	{
		return CogNamerResolver.Resolve(new CogNamerStringAttribute(CogNamerAttributeType.HostName, hostName), ResolveTimeout, ip);
	}

	public async Task<CogNamerDevice> ResolveAsync(IPAddress ip, CancellationToken cancel = default(CancellationToken))
	{
		lock (_lockHosts)
		{
			foreach (CogNamerDevice value in _internalHosts.Values)
			{
				if (value.IPAddress.Equals(ip))
				{
					return value;
				}
			}
		}
		CogNamerDevice device = null;
		try
		{
			device = await ResolveDeviceAsync(ip, cancel).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (CogNamerCommunicationException)
		{
		}
		return device;
	}

	public CogNamerDevice Resolve(IPAddress ip)
	{
		lock (_lockHosts)
		{
			foreach (CogNamerDevice value in _internalHosts.Values)
			{
				if (value.IPAddress.Equals(ip))
				{
					return value;
				}
			}
		}
		CogNamerDevice result = null;
		try
		{
			result = ResolveDevice(ip);
		}
		catch (CogNamerCommunicationException)
		{
		}
		return result;
	}

	public void SendFlash(CogNamerDevice sensor)
	{
		_V4Handler.SendFlash(sensor);
	}

	public void SendResetToFactoryDefaults(CogNamerDevice system, string username, string password, int timeout = 1000, int retries = 3)
	{
		_V4Handler.SendFactoryReset(system, username, password, timeout, retries);
	}

	public void SendSetNetwork(CogNamerDevice sensor, string username, string password, string hostname, bool useDhcp, IPAddress ip, IPAddress subnet, IPAddress gateway, IPAddress dns, string domainName, bool reset, int timeout = 1000, int retries = 3)
	{
		_V4Handler.SendSetNetwork(sensor, username, password, hostname, useDhcp, ip, subnet, gateway, dns, domainName, reset, timeout, retries);
	}

	public void SendResetAdminPassword(CogNamerDevice sensor)
	{
		_V4Handler.SendResetAdminPassword(sensor);
	}

	public bool SupportsCommand(CogNamerDevice sensor, CogNamerCommand cmd)
	{
		return _V4Handler.SendSupportsCommand(sensor, cmd);
	}

	public CommandSupport GetSupportsCommand(CogNamerDevice sensor, CogNamerCommand cmd)
	{
		return _V4Handler.GetSupportsCommand(sensor, cmd);
	}

	public void SendRestartCommand(CogNamerDevice sensor, string username, string password)
	{
		_V4Handler.SendRestart(sensor, username, password);
	}

	public string GetDefaultHostName(CogNamerDevice device)
	{
		return _V4Handler.GetDefaultHostName(device);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal CogNamerDevice RequestAdditionalAttributes(CogNamerDevice device, CogNamerAttributeType[] attributeTypes)
	{
		List<CogNamerNetworkDeviceAttribute> list = new List<CogNamerNetworkDeviceAttribute>();
		try
		{
			List<CogNamerAttributeType> list2 = new List<CogNamerAttributeType>(attributeTypes);
			for (int i = 0; i < list2.Count; i++)
			{
				if (device.Attributes.Contains(list2[i]))
				{
					list2.Remove(list2[i--]);
				}
			}
			if (list2.Count > 0)
			{
				foreach (CogNamerNetworkDeviceAttribute attribute in _V4Handler.GetAttributes(device, list2.ToArray()))
				{
					list.Add(attribute);
				}
			}
			if (list.Count > 0)
			{
				CogNamerNetworkDeviceAttributeDictionary cogNamerNetworkDeviceAttributeDictionary = new CogNamerNetworkDeviceAttributeDictionary(device.Attributes);
				foreach (CogNamerNetworkDeviceAttribute item in list)
				{
					cogNamerNetworkDeviceAttributeDictionary.Add(item);
				}
				return new CogNamerDevice(cogNamerNetworkDeviceAttributeDictionary, device.IPAddress, device.LocalInterface, device.Scope);
			}
		}
		catch (CogNamerCommunicationException)
		{
		}
		catch (CogNamerException)
		{
		}
		return device;
	}

	private void SendIdentify(object state)
	{
		if (_isDisposed)
		{
			return;
		}
		_refreshQueued = false;
		Random random = new Random();
		int num = random.Next(0, 500);
		for (int i = 0; i < 4; i++)
		{
			Thread.Sleep(num);
			num += (i + 1) * 750 + random.Next(0, 500);
			try
			{
				lock (_lockHosts)
				{
					if (_isDisposed)
					{
						break;
					}
					CogNamerTrace.WriteLineIf(__switch.TraceVerbose, "CogNamerNetworkListener: V4 Refresh");
					_V4Handler.SendRefresh();
				}
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	private void InvalidateHostsCollection()
	{
		_hosts = null;
	}

	private void AddHost(CogNamerDevice host)
	{
		lock (_lockHosts)
		{
			_internalHosts.Add(host.MacAddress, host);
			_newHostEvent.Set();
			InvalidateHostsCollection();
			NotifyHostsChanged(new AddHostPropertyChangedEventArgs("Hosts", host));
		}
		CogNamerTrace.WriteLineIf(__switch.TraceVerbose, "CvsNetworkListener: AddHost " + host.HostName + "  " + host.IPAddress.ToString());
	}

	private void MarkHostChanged(CogNamerDevice oldHost, CogNamerDevice newHost)
	{
		lock (_lockHosts)
		{
			_internalHosts.Remove(oldHost.MacAddress);
			_internalHosts.Add(newHost.MacAddress, newHost);
			_newHostEvent.Set();
			InvalidateHostsCollection();
			NotifyHostsChanged(new ChangeHostPropertyChangedEventArgs("Hosts", oldHost, newHost));
		}
		CogNamerTrace.WriteLineIf(__switch.TraceVerbose, $"CvsNetworkListener: ChangeHost from {oldHost.HostName}  {oldHost} to {newHost.HostName}  {newHost}");
	}

	private void ClearHosts()
	{
		lock (_lockHosts)
		{
			_internalHosts.Clear();
			InvalidateHostsCollection();
			NotifyHostsChanged(new ClearHostsPropertyChangedEventArgs("Hosts"));
		}
		CogNamerTrace.WriteLineIf(__switch.TraceVerbose, "CvsNetworkListener: ClearHosts");
	}

	private CogNamerDevice GetHost(string mac)
	{
		lock (_lockHosts)
		{
			return _internalHosts.ContainsKey(mac) ? _internalHosts[mac] : null;
		}
	}

	internal IEnumerable<CogNamerDevice> GetHostCache()
	{
		List<CogNamerDevice> list = new List<CogNamerDevice>();
		lock (_lockHosts)
		{
			foreach (CogNamerDevice value in _internalHosts.Values)
			{
				list.Add(value);
			}
			return list;
		}
	}

	internal void AddHostToCache(CogNamerDevice newHost)
	{
		if (!IsSupportedHostType(newHost.Type))
		{
			return;
		}
		lock (_lockHosts)
		{
			CogNamerDevice host = GetHost(newHost.MacAddress);
			if (host != null)
			{
				foreach (CogNamerNetworkDeviceAttribute attribute in newHost.Attributes)
				{
					if (!attribute.Equals(host.Attributes[attribute.AttributeType]))
					{
						MarkHostChanged(host, newHost);
						break;
					}
				}
				return;
			}
			AddHost(newHost);
		}
	}

	private bool IsSupportedHostType(CogNamerNetworkDeviceType type)
	{
		for (int i = 0; i < _deviceTypes.Length; i++)
		{
			if (_deviceTypes[i] == type || _deviceTypes[i] == CogNamerNetworkDeviceType.Any)
			{
				return true;
			}
			if ((_deviceTypes[i] & CogNamerNetworkDeviceType.SubtypeMask) == 0 && _deviceTypes[i] == (type & CogNamerNetworkDeviceType.ParentTypeMask))
			{
				return true;
			}
		}
		return false;
	}

	public static void IdentifyDevice(string hostName, TimeSpan duration, ManualResetEvent stopEvt, ICogNamerNetworkMonitorNetworkInterface netInterface)
	{
		new CogNamerIdentifyService(hostName, netInterface).Identify(duration, stopEvt);
	}

	public static void ResetPassword(string deviceAddress, ManualResetEvent stopEvt, Action<string, int> statusCallBack, ICogNamerNetworkMonitorNetworkInterface netInterface)
	{
		CogNamerResetPasswordService cogNamerResetPasswordService = new CogNamerResetPasswordService(deviceAddress, netInterface);
		cogNamerResetPasswordService.ResetPassword(stopEvt, statusCallBack);
		if (!cogNamerResetPasswordService.Success)
		{
			throw new CogNamerCommandFailedException(-1, string.Empty);
		}
	}

	public static void ResetDeviceToDefaults(string deviceAddress, string username, string password, ManualResetEvent stopEvt, Action<string> statusCallBack, ICogNamerNetworkMonitorNetworkInterface netInterface)
	{
		new CogNamerResetToDefaultService(deviceAddress, username, password, netInterface).ResetToDefaults(stopEvt, statusCallBack);
	}

	public static void ChangeNetworkSettings(string hostName, string username, string password, ICogNamerEthernetSettings settings, ManualResetEvent stopEvt, Action<string> statusCallBack, ICogNamerNetworkMonitorNetworkInterface netInterface)
	{
		new CogNamerChangeSettingsService(hostName, username, password, netInterface).Change(settings, stopEvt, statusCallBack);
	}

	private void NamerPacketNotify(object sender, CogNamerPacketEventArgs e)
	{
		if (PacketReceived != null)
		{
			PacketReceived(this, e);
		}
		if (!IsSupportedHostType(e.Device.Type))
		{
			return;
		}
		if (e.Command == CogNamerCommand.IPRequest)
		{
			if (!_bootTimes.ContainsKey(e.Device.MacAddressLong) || Environment.TickCount - _bootTimes[e.Device.MacAddressLong] > 10000)
			{
				_bootList[e.Device.MacAddressLong] = e.Device;
				_bootTimes[e.Device.MacAddressLong] = Environment.TickCount;
				NotifySystemBootDetected(e);
			}
		}
		else if (e.Command == CogNamerCommand.Hello && _bootList.ContainsKey(e.Device.MacAddressLong))
		{
			NotifySystemBootDetected(e);
			_bootList.Remove(e.Device.MacAddressLong);
			_bootTimes.Remove(e.Device.MacAddressLong);
		}
	}

	private void UpdateRemoteSubnetBrowsers()
	{
		bool flag = _remoteSubnets.Count != _remoteSubnetBrowsers.Count;
		if (!flag)
		{
			for (int i = 0; i < _remoteSubnets.Count; i++)
			{
				if (!_remoteSubnetBrowsers[i].RemoteSubnet.Equals(_remoteSubnets[i]))
				{
					flag = true;
				}
			}
		}
		if (flag)
		{
			mSubnetBrowserCancel.Cancel();
			_remoteSubnetBrowsers.Clear();
			mSubnetBrowserCancel = new CancellationTokenSource();
			lock (_lockHosts)
			{
				_internalRemoteSubnets = new List<ICogNamerRemoteSubnet>(_remoteSubnets);
			}
			for (int j = 0; j < _remoteSubnets.Count; j++)
			{
				_remoteSubnetBrowsers.Add(new CogNamerRemoteSubnetBrowser(_remoteSubnets[j], new Progress<CogNamerDevice>(AddHostToCache), mSubnetBrowserCancel.Token, _discoveryRateMs));
			}
		}
		else
		{
			for (int k = 0; k < _remoteSubnetBrowsers.Count; k++)
			{
				_remoteSubnetBrowsers[k].Refresh();
			}
		}
	}
}
