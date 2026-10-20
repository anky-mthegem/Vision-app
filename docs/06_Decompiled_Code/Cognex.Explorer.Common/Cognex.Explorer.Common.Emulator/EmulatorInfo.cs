using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Media;

namespace Cognex.Explorer.Common.Emulator;

[Serializable]
[DataContract]
public class EmulatorInfo
{
	[NonSerialized]
	private ImageSource _icon;

	[DataMember]
	public string UniqueId { get; set; }

	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public bool Is32Bit { get; set; }

	[DataMember]
	public string EntryPoint { get; set; }

	[DataMember]
	public Version HostVersion { get; set; }

	[DataMember]
	public Version Version { get; set; }

	[DataMember]
	public string ConfigurationEntryPoint { get; set; }

	[DataMember]
	public string[] ExcludedEmulators { get; set; } = new string[0];

	[DataMember]
	public bool IsOfflineProgrammingKeySupported { get; set; }

	[DataMember]
	public bool EmulatorConfigureButtonSupported { get; set; } = true;

	[DataMember]
	public bool Supports3D { get; set; }

	public string Directory { get; set; }

	public ImageSource Icon
	{
		get
		{
			return _icon;
		}
		set
		{
			_icon = value;
		}
	}

	public EmulatorInfo()
	{
	}

	public EmulatorInfo(EmulatorInfo original)
	{
		_icon = original._icon;
		UniqueId = original.UniqueId;
		Name = original.Name;
		Is32Bit = original.Is32Bit;
		EntryPoint = original.EntryPoint;
		HostVersion = original.HostVersion;
		Version = original.Version;
		ConfigurationEntryPoint = original.ConfigurationEntryPoint;
		Directory = original.Directory;
		ExcludedEmulators = (string[])original.ExcludedEmulators.Clone();
		IsOfflineProgrammingKeySupported = original.IsOfflineProgrammingKeySupported;
		EmulatorConfigureButtonSupported = original.EmulatorConfigureButtonSupported;
		Supports3D = original.Supports3D;
	}

	public string GetEntryPointPath()
	{
		return Path.Combine(Directory, EntryPoint);
	}

	public string GetConfigurationEntryPoint()
	{
		return Path.Combine(Directory, ConfigurationEntryPoint);
	}
}
