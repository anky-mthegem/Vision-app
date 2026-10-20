using System;
using System.IO;
using System.Net;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerNetworkSettingsAttribute : CogNamerNetworkDeviceAttribute
{
	private readonly bool _dhcpEnabled;

	private readonly bool _usingLlip;

	private readonly IPAddress _subnetMask;

	private readonly IPAddress _defaultGateway;

	private readonly IPAddress _dnsServer;

	private readonly string _domainName;

	public bool DhcpEnabled => _dhcpEnabled;

	public bool UsingLinkLocal => _usingLlip;

	public IPAddress SubnetMask => _subnetMask;

	public IPAddress DefaultGateway => _defaultGateway;

	public IPAddress DnsServer => _dnsServer;

	public string DomainName => _domainName;

	public override string StringValue => $"Dhcp Enabled: {_dhcpEnabled}\nLink Local IP: {_usingLlip}\nSubnet Mask: {_subnetMask}\nDefault Gateway: {_defaultGateway}\nDns Server: {_dnsServer}\nDomain Name: {_domainName}";

	internal CogNamerNetworkSettingsAttribute(byte[] data)
		: base(CogNamerAttributeType.NetworkSettings, data)
	{
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
		byte b = binaryReader.ReadByte();
		_dhcpEnabled = (b & 1) != 0;
		_usingLlip = (b & 2) != 0;
		_subnetMask = CogNamerPacket.ReadIP(binaryReader);
		_defaultGateway = CogNamerPacket.ReadIP(binaryReader);
		_dnsServer = CogNamerPacket.ReadIP(binaryReader);
		_domainName = CogNamerPacket.ReadString(binaryReader);
	}
}
