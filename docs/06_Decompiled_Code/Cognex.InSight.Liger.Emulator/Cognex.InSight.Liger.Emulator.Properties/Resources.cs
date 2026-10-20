using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cognex.InSight.Liger.Emulator.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("Cognex.InSight.Liger.Emulator.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	public static string AssignImageDirectories => ResourceManager.GetString("AssignImageDirectories", resourceCulture);

	public static string Cancel => ResourceManager.GetString("Cancel", resourceCulture);

	public static string ConfigureCausesRestart => ResourceManager.GetString("ConfigureCausesRestart", resourceCulture);

	public static string EmulationFailure => ResourceManager.GetString("EmulationFailure", resourceCulture);

	public static string Emulator => ResourceManager.GetString("Emulator", resourceCulture);

	public static string EmulatorError => ResourceManager.GetString("EmulatorError", resourceCulture);

	public static string EmulatorStartupFailure => ResourceManager.GetString("EmulatorStartupFailure", resourceCulture);

	public static string ErrorConfiguringTheEmulator => ResourceManager.GetString("ErrorConfiguringTheEmulator", resourceCulture);

	public static string ErrorReadingEmulatorSettings => ResourceManager.GetString("ErrorReadingEmulatorSettings", resourceCulture);

	public static string FailureInEmulator => ResourceManager.GetString("FailureInEmulator", resourceCulture);

	public static string SelectDirectory => ResourceManager.GetString("SelectDirectory", resourceCulture);

	public static string UtilityAppTitle => ResourceManager.GetString("UtilityAppTitle", resourceCulture);

	internal Resources()
	{
	}
}
