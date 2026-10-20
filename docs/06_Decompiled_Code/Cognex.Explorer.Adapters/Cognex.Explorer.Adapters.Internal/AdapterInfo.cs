using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media.Imaging;
using b4Zxkh9w1NDrmwo2EQ;

namespace Cognex.Explorer.Adapters.Internal;

[DataContract]
public class AdapterInfo : IAdapter
{
	private string z31pEFUB4;

	[CompilerGenerated]
	private string OKekLMqZ2;

	[CompilerGenerated]
	private Version zVg1gOLFM;

	[CompilerGenerated]
	private Version f32iPl6qZ;

	[CompilerGenerated]
	private bool qwRvIkt80;

	[CompilerGenerated]
	private string qTI2jDuEM;

	[CompilerGenerated]
	private string fd5cbDYJV;

	[CompilerGenerated]
	private bool udflwUVPu;

	[CompilerGenerated]
	private DateTime kDcPmfeWU;

	[CompilerGenerated]
	private string UlEYUFFmU;

	[CompilerGenerated]
	private readonly List<string> K2pZsPxb7;

	[CompilerGenerated]
	private string vEuaxYOyy;

	[CompilerGenerated]
	private BitmapImage toVefb7cW;

	private static AdapterInfo xKF8Fqg2o44u1Flq8r;

	[DataMember]
	public string AdapterGroup
	{
		[CompilerGenerated]
		get
		{
			return OKekLMqZ2;
		}
		[CompilerGenerated]
		set
		{
			OKekLMqZ2 = value;
		}
	}

	[DataMember(Name = "Version")]
	public string VersionStr
	{
		get
		{
			return Version?.ToString();
		}
		set
		{
			Version = (Version.TryParse(value, out var result) ? result : null);
		}
	}

	public Version Version
	{
		[CompilerGenerated]
		get
		{
			return zVg1gOLFM;
		}
		[CompilerGenerated]
		private set
		{
			zVg1gOLFM = value;
		}
	}

	[DataMember(Name = "HostVersion")]
	public string HostVersionStr
	{
		get
		{
			return HostVersion?.ToString();
		}
		set
		{
			HostVersion = (Version.TryParse(value, out var result) ? result : null);
		}
	}

	public Version HostVersion
	{
		[CompilerGenerated]
		get
		{
			return f32iPl6qZ;
		}
		[CompilerGenerated]
		private set
		{
			f32iPl6qZ = value;
		}
	}

	[DataMember]
	public bool SupportsDiscovery
	{
		[CompilerGenerated]
		get
		{
			return qwRvIkt80;
		}
		[CompilerGenerated]
		set
		{
			qwRvIkt80 = value;
		}
	}

	[DataMember]
	public string EntryPoint
	{
		[CompilerGenerated]
		get
		{
			return qTI2jDuEM;
		}
		[CompilerGenerated]
		set
		{
			qTI2jDuEM = value;
		}
	}

	[DataMember]
	public string UniqueId
	{
		[CompilerGenerated]
		get
		{
			return fd5cbDYJV;
		}
		[CompilerGenerated]
		set
		{
			fd5cbDYJV = value;
		}
	}

	[DataMember]
	public bool Is32Bit
	{
		[CompilerGenerated]
		get
		{
			return udflwUVPu;
		}
		[CompilerGenerated]
		set
		{
			udflwUVPu = value;
		}
	}

	[DataMember]
	public DateTime ReleaseDate
	{
		[CompilerGenerated]
		get
		{
			return kDcPmfeWU;
		}
		[CompilerGenerated]
		set
		{
			kDcPmfeWU = value;
		}
	}

	public string Directory
	{
		[CompilerGenerated]
		get
		{
			return UlEYUFFmU;
		}
		[CompilerGenerated]
		set
		{
			UlEYUFFmU = value;
		}
	}

	[DataMember]
	public List<string> SupportedLanguages
	{
		[CompilerGenerated]
		get
		{
			return K2pZsPxb7;
		}
	}

	[DataMember]
	public string HelpFile
	{
		[CompilerGenerated]
		get
		{
			return vEuaxYOyy;
		}
		[CompilerGenerated]
		set
		{
			vEuaxYOyy = value;
		}
	}

	[DataMember]
	public string LogoPath
	{
		get
		{
			return z31pEFUB4;
		}
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						Logo = null;
						return;
					default:
						if (!RZhfTWe5R3NMLSvxfI(z31pEFUB4))
						{
							num2 = 2;
							if (pRxgiQ2oiMFENir4EN() == null)
							{
								continue;
							}
							break;
						}
						goto case 4;
					case 2:
						Logo = new BitmapImage(new Uri((string)PMFJ9JLlWmTOKZBOoA(z31pEFUB4)));
						qu1P9MGVJvt3aSV0jP(Logo);
						num2 = 3;
						if (pRxgiQ2oiMFENir4EN() == null)
						{
							continue;
						}
						break;
					case 1:
						z31pEFUB4 = value;
						num2 = 0;
						if (VslYbnfvUrUtWNXrT7())
						{
							continue;
						}
						break;
					case 3:
						return;
					}
					break;
				}
			}
		}
	}

	public BitmapImage Logo
	{
		[CompilerGenerated]
		get
		{
			return toVefb7cW;
		}
		[CompilerGenerated]
		private set
		{
			toVefb7cW = value;
		}
	}

	public AdapterInfo()
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		base._002Ector();
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			K2pZsPxb7 = new List<string>();
			num = 1;
			if (true)
			{
				num = 1;
			}
		}
	}

	public string GetEntryPointPath()
	{
		return Path.Combine(Directory, EntryPoint);
	}

	internal static bool VslYbnfvUrUtWNXrT7()
	{
		return xKF8Fqg2o44u1Flq8r == null;
	}

	internal static AdapterInfo pRxgiQ2oiMFENir4EN()
	{
		return xKF8Fqg2o44u1Flq8r;
	}

	internal static bool RZhfTWe5R3NMLSvxfI(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object PMFJ9JLlWmTOKZBOoA(object P_0)
	{
		return Uri.UnescapeDataString((string)P_0);
	}

	internal static void qu1P9MGVJvt3aSV0jP(object P_0)
	{
		((Freezable)P_0).Freeze();
	}
}
