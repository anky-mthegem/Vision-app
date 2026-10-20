using System;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public abstract class CogNamerNetworkDeviceAttribute
{
	[NonSerialized]
	private readonly CogNamerAttributeType _browseName;

	protected byte[] _data;

	public abstract string StringValue { get; }

	public CogNamerAttributeType AttributeType => _browseName;

	public virtual string DisplayName
	{
		get
		{
			string displayName = GetDisplayName(_browseName);
			if (!string.IsNullOrEmpty(displayName))
			{
				return BrowseName;
			}
			return displayName;
		}
	}

	public virtual string BrowseName => _browseName.ToString();

	public virtual string Description => null;

	protected CogNamerNetworkDeviceAttribute(CogNamerAttributeType type, byte[] data)
	{
		_browseName = type;
		_data = data;
	}

	private static string GetDisplayName(CogNamerAttributeType attributeName)
	{
		switch (attributeName)
		{
		case CogNamerAttributeType.Comments:
			return "Comments";
		case CogNamerAttributeType.Description:
			return "Description";
		case CogNamerAttributeType.DeviceType:
			return "Device Type";
		case CogNamerAttributeType.GroupName:
			return "Group Name";
		case CogNamerAttributeType.IpAddress:
			return "IP Address";
		case CogNamerAttributeType.LanguageId:
			return "Language ID";
		case CogNamerAttributeType.MacAddress:
			return "MAC Address";
		case CogNamerAttributeType.ModelNumber:
			return "Model Number";
		case CogNamerAttributeType.NetworkSettings:
			return "Network Settings";
		case CogNamerAttributeType.OrderingNumber:
			return "Ordering Number";
		case CogNamerAttributeType.SerialNumber:
			return "Serial Number";
		case CogNamerAttributeType.Services:
			return "Services";
		case CogNamerAttributeType.SoftwareVersion:
			return "Software Version";
		case CogNamerAttributeType.HostName:
			return "Name";
		default:
			CogNamerTrace.TraceError($"CogNamerNetworkDeviceAttribute.GetDisplayName : Unrecognized CogNamerAttributeType '{(int)attributeName}' ");
			return string.Empty;
		}
	}

	public override string ToString()
	{
		return StringValue;
	}

	public override bool Equals(object obj)
	{
		if (obj is CogNamerNetworkDeviceAttribute)
		{
			CogNamerNetworkDeviceAttribute cogNamerNetworkDeviceAttribute = (CogNamerNetworkDeviceAttribute)obj;
			if (AttributeType == cogNamerNetworkDeviceAttribute.AttributeType)
			{
				return StringValue.Equals(((CogNamerNetworkDeviceAttribute)obj).StringValue);
			}
			return false;
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return StringValue.GetHashCode() ^ AttributeType.GetHashCode();
	}

	public static CogNamerNetworkDeviceAttribute FromRecord(CogNamerRecord record)
	{
		if (!record.IsAttributeRecord)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (record.RecordType)
		{
		case CogNamerAttributeType.HostName:
		case CogNamerAttributeType.ModelNumber:
		case CogNamerAttributeType.SerialNumber:
		case CogNamerAttributeType.SoftwareVersion:
		case CogNamerAttributeType.Description:
		case CogNamerAttributeType.GroupName:
		case CogNamerAttributeType.OrderingNumber:
		case CogNamerAttributeType.LanguageId:
		case CogNamerAttributeType.Comments:
			return new CogNamerStringAttribute(record.RecordType, record.Data);
		case CogNamerAttributeType.DeviceType:
			return new CogNamerDeviceTypeAttribute(record.Data);
		case CogNamerAttributeType.IpAddress:
			return new CogNamerIPAddressAttribute(record.Data);
		case CogNamerAttributeType.MacAddress:
			return new CogNamerMacAddressAttribute(record.Data);
		case CogNamerAttributeType.NetworkSettings:
			return new CogNamerNetworkSettingsAttribute(record.Data);
		case CogNamerAttributeType.Services:
			return new CogNamerServicesAttribute(record.Data);
		case CogNamerAttributeType.ApplicationId:
			return new CogNamerApplicationIdAttribute(record.Data);
		default:
			return new CogNamerUnknownAttribute(record.RecordType, record.Data);
		}
	}

	public CogNamerRecord ToRecord()
	{
		return new CogNamerRecord(_browseName, _data);
	}
}
