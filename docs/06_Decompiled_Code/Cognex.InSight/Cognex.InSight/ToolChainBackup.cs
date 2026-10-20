using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cognex.Diagnostics.Logging;
using Cognex.Features;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public static class ToolChainBackup
{
	private static readonly ILogger M8vOx0dYKu;

	public const string ArchiveExtension = ".ovr";

	[CompilerGenerated]
	private static readonly FeatureFlag<string> UwJOFoy6tj;

	public static bool IsEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (pM9wmddyOWdfhDCKX73(L9dOI7PU3R()))
			{
				return !string.IsNullOrWhiteSpace(L9dOI7PU3R().Value);
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private static FeatureFlag<string> L9dOI7PU3R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UwJOFoy6tj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveToolChainArchiveIfEnabled(string projectName, string versionName, int versionIndex, byte[] archive)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OR8wvodFil1BZjUjSXv();
		int num;
		if (!HukuWpdm1ysorWJVHmc())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (HukuWpdm1ysorWJVHmc())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
				return;
			case 2:
				return;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0088;
			case 4:
				goto IL_0088;
			}
			break;
		}
		goto IL_002a;
		IL_0088:
		string text = default;
		try
		{
			string value = L9dOI7PU3R().Value;
			Directory.CreateDirectory(value);
			string path = (string)RvBwSZdJ7rYPdhC5pfU(kgbOBx7BanbFa22Hp9.ol99ukmDA(11380), new object[4]
			{
				KEoHbcdgfBMe2HWQF6V(projectName),
				versionIndex,
				KEoHbcdgfBMe2HWQF6V(versionName),
				aXe8jwdZvwbrZ3wRhLh(11414)
			});
			text = Path.Combine(value, path);
			c8Wsj0d8NMgv4Z398Ia(text, archive);
			return;
		}
		catch (PathTooLongException ex)
		{
			H1bl1Miw2cJPnKp4vUX(M8vOx0dYKu, LogLevel.Info, F8LUTQdzrTR5Zq4nnQk(aXe8jwdZvwbrZ3wRhLh(11426), text, aXe8jwdZvwbrZ3wRhLh(11500)), ex);
			return;
		}
		catch (Exception ex2)
		{
			H1bl1Miw2cJPnKp4vUX(M8vOx0dYKu, LogLevel.Info, dCI1PpisaeqrFOjnuAO(aXe8jwdZvwbrZ3wRhLh(11526), text), ex2);
			return;
		}
		IL_002a:
		if (!IsEnabled)
		{
			return;
		}
		text = string.Empty;
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string m3ZOPNMTTo(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HukuWpdm1ysorWJVHmc();
		int num;
		if (OR8wvodFil1BZjUjSXv())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
			case 5:
				if (AetFtPi9LapChnc23Co(text) > 32)
				{
					goto case 1;
				}
				goto case 6;
			default:
				num = 1;
				continue;
			case 0:
			case 4:
				if (!xwEenwihG8UFVjqFs1l(P_0))
				{
					text = (string)jfSKJKiLLioFvmqUgxI(P_0, aXe8jwdZvwbrZ3wRhLh(11594), aXe8jwdZvwbrZ3wRhLh(444));
					goto case 2;
				}
				num = 3;
				continue;
			case 1:
				text = text.Substring(0, 32);
				num = 6;
				if (OR8wvodFil1BZjUjSXv())
				{
					continue;
				}
				goto case 6;
			case 6:
				return text;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		return string.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearToolChainArchiveFolderIfEnabled()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!S4HVuWiS2tRiyPrhbTM())
		{
			return;
		}
		try
		{
			string[] files = Directory.GetFiles(L9dOI7PU3R().Value, (string)aXe8jwdZvwbrZ3wRhLh(11614), SearchOption.TopDirectoryOnly);
			foreach (string text in files)
			{
				try
				{
					joXEawiEUv3vK10q4qq(text);
				}
				catch (Exception ex)
				{
					H1bl1Miw2cJPnKp4vUX(M8vOx0dYKu, LogLevel.Info, (string)aXe8jwdZvwbrZ3wRhLh(11628) + text + kgbOBx7BanbFa22Hp9.ol99ukmDA(11724) + (string)KRbg6NivQHHHbllMeK9(ex), ex);
				}
			}
		}
		catch (Exception ex2)
		{
			H1bl1Miw2cJPnKp4vUX(M8vOx0dYKu, LogLevel.Info, aXe8jwdZvwbrZ3wRhLh(11732), ex2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ToolChainBackup()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HukuWpdm1ysorWJVHmc();
		int num = ((!OR8wvodFil1BZjUjSXv()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
				M8vOx0dYKu = (ILogger)WIpl3PiHCJg91JBNUOf(kgbOBx7BanbFa22Hp9.ol99ukmDA(11804));
				break;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 1;
				continue;
			case 5:
				return;
			}
			FeatureDescriptor featureDescriptor = new FeatureDescriptor();
			EvZJkRiVq06xqbEYAI0(featureDescriptor, kgbOBx7BanbFa22Hp9.ol99ukmDA(11838));
			Ah1sM0iAZYxLDnF0bwE(featureDescriptor, kgbOBx7BanbFa22Hp9.ol99ukmDA(11918));
			UwJOFoy6tj = FeatureRegistry.RegisterFeature<string>(featureDescriptor);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pM9wmddyOWdfhDCKX73(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FeatureFlag)P_0).IsEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OR8wvodFil1BZjUjSXv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HukuWpdm1ysorWJVHmc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KEoHbcdgfBMe2HWQF6V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return m3ZOPNMTTo((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aXe8jwdZvwbrZ3wRhLh(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RvBwSZdJ7rYPdhC5pfU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, (object[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c8Wsj0d8NMgv4Z398Ia(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		File.WriteAllBytes((string)P_0, (byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F8LUTQdzrTR5Zq4nnQk(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H1bl1Miw2cJPnKp4vUX(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dCI1PpisaeqrFOjnuAO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xwEenwihG8UFVjqFs1l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jfSKJKiLLioFvmqUgxI(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AetFtPi9LapChnc23Co(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S4HVuWiS2tRiyPrhbTM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void joXEawiEUv3vK10q4qq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		File.Delete((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KRbg6NivQHHHbllMeK9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WIpl3PiHCJg91JBNUOf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LogManager.GetLogger((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EvZJkRiVq06xqbEYAI0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Id = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ah1sM0iAZYxLDnF0bwE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Description = (string)P_1;
	}
}
