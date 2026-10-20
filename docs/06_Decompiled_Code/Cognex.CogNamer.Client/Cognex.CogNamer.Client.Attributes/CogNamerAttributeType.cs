namespace Cognex.CogNamer.Client.Attributes;

public enum CogNamerAttributeType
{
	None = 0,
	KnownSystems = 1,
	Credentials = 2,
	DeviceType = 32,
	MacAddress = 33,
	HostName = 34,
	IpAddress = 35,
	NetworkSettings = 36,
	ModelNumber = 37,
	SerialNumber = 38,
	SoftwareVersion = 39,
	Description = 40,
	GroupName = 41,
	OrderingNumber = 42,
	Services = 43,
	LanguageId = 44,
	Comments = 45,
	ApplicationId = 46,
	DefaultName = 47,
	ProductIdentity = 48,
	MinimumVersion = 49,
	MinAttribute = DeviceType,
	MaxGenericAttribute = 63,
	MinDeviceSpecificAttribute = 64,
	MaxDeviceSpecificAttribute = 127
}
