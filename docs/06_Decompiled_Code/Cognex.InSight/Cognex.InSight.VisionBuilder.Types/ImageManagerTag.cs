using System.Runtime.CompilerServices;
using Cognex.ImageManager.Client.Tool;
using Cognex.ImageManager.Client.Tool.Interfaces;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

public class ImageManagerTag : ITag
{
	[CompilerGenerated]
	private string FtYpzu1EU1;

	[CompilerGenerated]
	private string IythP5m2Gw;

	[CompilerGenerated]
	private string uDZhI68rdI;

	[CompilerGenerated]
	private Style o0Xh1YV8YI;

	[CompilerGenerated]
	private string[] Q7ShxtH7Vi;

	[JsonProperty("date_created")]
	public string DateCreated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FtYpzu1EU1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FtYpzu1EU1 = value;
		}
	}

	[JsonProperty("name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IythP5m2Gw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IythP5m2Gw = value;
		}
	}

	[JsonProperty("tag_id")]
	public string TagId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uDZhI68rdI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uDZhI68rdI = value;
		}
	}

	[JsonProperty("style")]
	public Style Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o0Xh1YV8YI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o0Xh1YV8YI = value;
		}
	}

	[JsonProperty("image_ids")]
	public string[] ImageIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Q7ShxtH7Vi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q7ShxtH7Vi = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageManagerTag()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		O5UlNicDRdv5yANKcGU();
		PnCIomcUjgeS2lMha2U(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageManagerTag(InSightTag inSightTag)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 8:
				TagId = inSightTag.Id;
				num = 4;
				break;
			case 0:
			case 6:
				ImageIds = (string[])Bb9cjgcB3B2mYe9VpKI(inSightTag);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				PnCIomcUjgeS2lMha2U(this);
				E336aFcAYuN0X9mpLQ0();
				num = (WYL7JlcVvCBPrq1VSMO() ? 1 : 0);
				break;
			case 4:
			{
				Style style = new Style();
				vpCIQCcqFbMLtUsJAN3(style, rgkyRdciLwQrAuGACZW(inSightTag));
				Style = style;
				goto case 0;
			}
			case 1:
			case 2:
				DateCreated = (string)acjD0acTjrEg1I4QPGU(inSightTag);
				num = 5;
				break;
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				break;
			case 5:
				Name = (string)YIitj0cd9vZYeHtwCcN(inSightTag);
				goto case 8;
			default:
				num = 8;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O5UlNicDRdv5yANKcGU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PnCIomcUjgeS2lMha2U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WYL7JlcVvCBPrq1VSMO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E336aFcAYuN0X9mpLQ0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object acjD0acTjrEg1I4QPGU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightTag)P_0).DateCreated;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YIitj0cd9vZYeHtwCcN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightTag)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rgkyRdciLwQrAuGACZW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightTag)P_0).Color;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vpCIQCcqFbMLtUsJAN3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Style)P_0).Color = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bb9cjgcB3B2mYe9VpKI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightTag)P_0).ImageIds;
	}
}
