using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

[Serializable]
public class CogNamerDevice : ICloneable
{
	private readonly IPAddress _asDiscoveredIpAddress;

	private readonly INetworkDeviceAttributeProvider _attributes;

	private readonly IPAddress _localInterface;

	private readonly CogNamerEthernetDeviceScope _scope;

	public INetworkDeviceAttributeProvider Attributes => _attributes;

	public CogNamerNetworkDeviceType Type
	{
		get
		{
			if (!(_attributes[CogNamerAttributeType.DeviceType] is CogNamerDeviceTypeAttribute cogNamerDeviceTypeAttribute))
			{
				return CogNamerNetworkDeviceType.Any;
			}
			return cogNamerDeviceTypeAttribute.Type;
		}
	}

	public CogNamerNetworkDeviceFamilyType FamilyType => Type.GetFamily();

	public CogNamerEthernetDeviceScope Scope => _scope;

	public string UniqueIdentity => HostName.ToLowerInvariant() + ((MacAddressLong >> 24 == 53284) ? (":" + MacAddressLong) : string.Empty) + (string.IsNullOrEmpty(SerialNumber) ? (":" + SerialNumber) : string.Empty);

	public string MacAddress => GetAttributeString(CogNamerAttributeType.MacAddress);

	[ComVisible(false)]
	public long MacAddressLong
	{
		get
		{
			if (_attributes[CogNamerAttributeType.MacAddress] is CogNamerMacAddressAttribute cogNamerMacAddressAttribute)
			{
				return cogNamerMacAddressAttribute.MacAddress;
			}
			return 0L;
		}
	}

	[ComVisible(false)]
	public IPAddress LocalInterface => _localInterface;

	public string LocalInterfaceString => _localInterface.ToString();

	public string VersionString => GetAttributeString(CogNamerAttributeType.SoftwareVersion);

	public Version Version
	{
		get
		{
			string versionString = VersionString;
			if (versionString == null)
			{
				return new Version(0, 0, 0);
			}
			if (Version.TryParse(versionString, out var result) || TryParseInSightVersion(versionString, out result))
			{
				return result;
			}
			return new Version(0, 0, 0);
		}
	}

	public string SerialNumber => GetAttributeString(CogNamerAttributeType.SerialNumber);

	public string ModelNumber => GetAttributeString(CogNamerAttributeType.ModelNumber);

	[ComVisible(false)]
	internal CogNamerNetworkSettingsAttribute NetworkSettings => _attributes[CogNamerAttributeType.NetworkSettings] as CogNamerNetworkSettingsAttribute;

	public bool IsDhcpEnabled
	{
		get
		{
			if (NetworkSettings != null)
			{
				return NetworkSettings.DhcpEnabled;
			}
			return false;
		}
	}

	public IPAddress IPAddress => _asDiscoveredIpAddress;

	public IPAddress IPAddressAsConfigured
	{
		get
		{
			if (!(_attributes[CogNamerAttributeType.IpAddress] is CogNamerIPAddressAttribute cogNamerIPAddressAttribute))
			{
				return null;
			}
			return cogNamerIPAddressAttribute.IPAddress;
		}
	}

	public IPAddress SubnetMask
	{
		get
		{
			if (NetworkSettings != null)
			{
				return NetworkSettings.SubnetMask;
			}
			return null;
		}
	}

	public IPAddress DefaultGateway
	{
		get
		{
			if (NetworkSettings != null)
			{
				return NetworkSettings.DefaultGateway;
			}
			return null;
		}
	}

	public IPAddress DnsServer
	{
		get
		{
			if (NetworkSettings != null)
			{
				return NetworkSettings.DnsServer;
			}
			return null;
		}
	}

	public string DomainName
	{
		get
		{
			if (NetworkSettings != null)
			{
				return NetworkSettings.DomainName;
			}
			return null;
		}
	}

	public string HostName
	{
		get
		{
			if (!(_attributes[CogNamerAttributeType.HostName] is CogNamerStringAttribute cogNamerStringAttribute))
			{
				return string.Empty;
			}
			return cogNamerStringAttribute.StringValue;
		}
	}

	public string Comments
	{
		get
		{
			if (!(_attributes[CogNamerAttributeType.Comments] is CogNamerStringAttribute cogNamerStringAttribute))
			{
				return string.Empty;
			}
			return cogNamerStringAttribute.StringValue;
		}
	}

	public string Description
	{
		get
		{
			if (!(_attributes[CogNamerAttributeType.Description] is CogNamerStringAttribute cogNamerStringAttribute))
			{
				return string.Empty;
			}
			return cogNamerStringAttribute.StringValue;
		}
	}

	internal CogNamerDevice(INetworkDeviceAttributeProvider attributes, IPAddress asDiscoveredIpAddress, IPAddress localInterface, CogNamerEthernetDeviceScope scope)
	{
		_attributes = attributes;
		_asDiscoveredIpAddress = asDiscoveredIpAddress;
		_localInterface = localInterface;
		_scope = scope;
	}

	internal CogNamerDevice(CogNamerDevice original)
	{
		_attributes = original._attributes;
		_asDiscoveredIpAddress = original._asDiscoveredIpAddress;
		_localInterface = original._localInterface;
	}

	object ICloneable.Clone()
	{
		return new CogNamerDevice(this);
	}

	internal bool IsEqual(object obj)
	{
		if (!(obj is CogNamerDevice cogNamerDevice))
		{
			return false;
		}
		return UniqueIdentity == cogNamerDevice.UniqueIdentity;
	}

	public override bool Equals(object obj)
	{
		return IsEqual(obj);
	}

	public override int GetHashCode()
	{
		return HostName.GetHashCode() + ((MacAddressLong >> 24 == 53284) ? MacAddress.GetHashCode() : 0) + ((SerialNumber != null) ? SerialNumber.GetHashCode() : 0);
	}

	public bool Matches(CogNamerDevice host)
	{
		bool result = false;
		if (host != null)
		{
			if (host.Type != CogNamerNetworkDeviceType.InSightEmulatorPcHost && host.MacAddressLong >> 24 != 53284)
			{
				result = host.HostName.Equals(HostName, StringComparison.CurrentCultureIgnoreCase);
			}
			else if (MacAddressLong == host.MacAddressLong)
			{
				result = true;
			}
		}
		return result;
	}

	private static bool TryParseInSightVersion(string text, out Version ver)
	{
		ver = null;
		text = ((text == null) ? "" : text);
		string[] array = text.Trim().Split(' ');
		if (array.Length == 0 || array.Length > 3)
		{
			return false;
		}
		string[] array2 = array[0].Split('.');
		if (array2.Length <= 1 || array2.Length > 4)
		{
			return false;
		}
		try
		{
			int major = int.Parse(array2[0], CultureInfo.InvariantCulture);
			int minor = int.Parse(array2[1], CultureInfo.InvariantCulture);
			int revision = ((array2.Length > 2) ? int.Parse(array2[2], CultureInfo.InvariantCulture) : 0);
			int build = 0;
			if (array.Length > 1)
			{
				string text2 = array[array.Length - 1];
				if (text2.StartsWith("(") && text2.EndsWith(")"))
				{
					build = int.Parse(text2.Substring(1, text2.Length - 2), CultureInfo.InvariantCulture);
				}
			}
			ver = new Version(major, minor, build, revision);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public Dictionary<string, int> GetServices()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		if (_attributes[CogNamerAttributeType.Services] is CogNamerServicesAttribute { Services: var services })
		{
			for (int i = 0; i < services.Length; i++)
			{
				CogNamerServicesAttribute.Service service = services[i];
				dictionary.Add(service.Name, service.Port);
			}
		}
		return dictionary;
	}

	public int GetServicePort(string serviceName)
	{
		if (!(_attributes[CogNamerAttributeType.Services] is CogNamerServicesAttribute cogNamerServicesAttribute))
		{
			return -1;
		}
		return cogNamerServicesAttribute.GetServicePort(serviceName);
	}

	[ComVisible(false)]
	private string GetAttributeString(CogNamerAttributeType attributeType)
	{
		string result = string.Empty;
		CogNamerNetworkDeviceAttribute cogNamerNetworkDeviceAttribute = _attributes[attributeType];
		if (cogNamerNetworkDeviceAttribute != null)
		{
			result = cogNamerNetworkDeviceAttribute.StringValue;
		}
		return result;
	}

	public byte[] GetDeviceSpecificAttribute(int attributeId)
	{
		return _attributes[(CogNamerAttributeType)attributeId]?.ToRecord().Data;
	}

	public string GetDeviceSpecificAttributeString(int attributeId)
	{
		CogNamerNetworkDeviceAttribute cogNamerNetworkDeviceAttribute = _attributes[(CogNamerAttributeType)attributeId];
		if (cogNamerNetworkDeviceAttribute != null)
		{
			return cogNamerNetworkDeviceAttribute.ToRecord().GetString();
		}
		return string.Empty;
	}

	public bool InFailSafeMode()
	{
		if (_attributes[CogNamerAttributeType.ApplicationId] is CogNamerApplicationIdAttribute cogNamerApplicationIdAttribute)
		{
			return cogNamerApplicationIdAttribute.IsInFailSafe;
		}
		return false;
	}
}
