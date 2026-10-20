namespace Cognex.CogNamer.Client;

public interface ICogNamerEthernetSettings
{
	string HostName { get; set; }

	bool Dhcp { get; set; }

	string IpAddress { get; set; }

	string SubMask { get; set; }

	string Gateway { get; set; }

	string PrimaryDNS { get; set; }

	string DomainName { get; set; }
}
