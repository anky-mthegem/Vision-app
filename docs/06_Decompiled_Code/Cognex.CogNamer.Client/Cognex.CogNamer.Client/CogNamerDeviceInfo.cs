using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cognex.CogNamer.Client;

public class CogNamerDeviceInfo
{
	private string _name;

	private int _deviceType;

	private int _deviceSubType;

	private string _model;

	private string _description;

	private string _version;

	private string _fupVersion;

	private string _serialNumber;

	private readonly string _macId;

	private ICogNamerLocalNetworkInterface _primaryNetworkAdapter;

	private ICogNamerLocalNetworkInterface[] _networkAdapters;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public int DeviceType
	{
		get
		{
			return _deviceType;
		}
		set
		{
			_deviceType = value;
		}
	}

	public int DeviceSubType
	{
		get
		{
			return _deviceSubType;
		}
		set
		{
			_deviceSubType = value;
		}
	}

	public string Model
	{
		get
		{
			return _model;
		}
		set
		{
			_model = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

	public string Version
	{
		get
		{
			return _version;
		}
		set
		{
			_version = value;
		}
	}

	public string FupVersion
	{
		get
		{
			return _fupVersion;
		}
		set
		{
			_fupVersion = value;
		}
	}

	public string SerialNumber
	{
		get
		{
			return _serialNumber;
		}
		set
		{
			_serialNumber = value;
		}
	}

	public string MacId => _macId;

	public long MacIdNum
	{
		get
		{
			if (string.IsNullOrEmpty(_macId))
			{
				return 0L;
			}
			return long.Parse(_macId, NumberStyles.HexNumber);
		}
	}

	public ICogNamerLocalNetworkInterface PrimaryNetworkAdapter => _primaryNetworkAdapter;

	public ICogNamerLocalNetworkInterface[] NetworkAdapters => _networkAdapters;

	public CogNamerDeviceInfo()
	{
	}

	public CogNamerDeviceInfo(string name, int deviceType, int deviceSubType, string model, string description, string version, string fupVersion, string serialNumber, string macId)
	{
		_name = name;
		_deviceType = deviceType;
		_deviceSubType = deviceSubType;
		_model = model;
		_description = description;
		_version = version;
		_fupVersion = fupVersion;
		_serialNumber = serialNumber;
		_macId = macId;
	}

	public void SetNetworkInformation(ICogNamerLocalNetworkInterface primary, ICogNamerLocalNetworkInterface[] all)
	{
		_primaryNetworkAdapter = primary;
		_networkAdapters = all;
	}

	public static Version ParseVersionString(string val)
	{
		List<string> list = new List<string>(val.Split('.', '(', ')', ' '));
		list.RemoveAll((string s) => string.IsNullOrEmpty(s));
		list.TrimExcess();
		if (list.Count == 3)
		{
			int major = int.Parse(list[0]);
			int minor = int.Parse(list[1]);
			int build = int.Parse(list[2]);
			return new Version(major, minor, build, 0);
		}
		if (list.Count == 4)
		{
			int major2 = int.Parse(list[0]);
			int minor2 = int.Parse(list[1]);
			int build2 = int.Parse(list[2]);
			int revision = int.Parse(list[3]);
			return new Version(major2, minor2, build2, revision);
		}
		throw new FormatException();
	}
}
