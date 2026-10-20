namespace Cognex.CogNamer.Client.Attributes;

public static class CogNamerNetworkDeviceFamilyTypeExtensions
{
	public static CogNamerNetworkDeviceFamilyType GetFamily(this CogNamerNetworkDeviceType type)
	{
		return (CogNamerNetworkDeviceFamilyType)(type & CogNamerNetworkDeviceType.ParentTypeMask);
	}
}
