using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "ShapesBase")]
public abstract class CvsCogShape : ICloneable
{
	internal const int DefaultColor = -16777077;

	[CompilerGenerated]
	private string E6TBk5eaWs;

	[CompilerGenerated]
	private int zyVBElkCGk;

	[CompilerGenerated]
	private int XNfBs4EAtJ;

	[CompilerGenerated]
	private string f3FB0aA8is;

	[CompilerGenerated]
	private string ocPBGnFhi7;

	[CompilerGenerated]
	private string ggFB7l0N67;

	[CompilerGenerated]
	private int oGTBWlFdk9;

	[CompilerGenerated]
	private int eFSBoqEQL5;

	[JsonProperty(PropertyName = "source", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E6TBk5eaWs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E6TBk5eaWs = value;
		}
	}

	[DefaultValue(-16777077)]
	[JsonProperty(PropertyName = "color", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zyVBElkCGk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zyVBElkCGk = value;
		}
	}

	[DefaultValue(-1)]
	[JsonProperty(PropertyName = "graphicId", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int GraphicId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XNfBs4EAtJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XNfBs4EAtJ = value;
		}
	}

	[JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
			return f3FB0aA8is;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f3FB0aA8is = value;
		}
	}

	[JsonProperty(PropertyName = "label", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ocPBGnFhi7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ocPBGnFhi7 = value;
		}
	}

	[DefaultValue("Arial")]
	[JsonProperty(PropertyName = "font", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string Font
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ggFB7l0N67;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ggFB7l0N67 = value;
		}
	}

	[DefaultValue(9)]
	[JsonProperty(PropertyName = "fontSize", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int FontSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oGTBWlFdk9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oGTBWlFdk9 = value;
		}
	}

	[JsonProperty(PropertyName = "lineThickness", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(1)]
	public int LineThickness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eFSBoqEQL5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eFSBoqEQL5 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogShape()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eQZkM5cC93iUx2vik6A();
		UvaWkPc6dpCDDN02iA4(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogShape(CvsCogShape other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!S5rAOicQKRD2mblxsmV()) ? 8 : 3);
		while (true)
		{
			switch (num)
			{
			case 6:
				FontSize = JTG4qLcqebDvNXh1d9Y(other);
				num = 2;
				continue;
			case 1:
			case 8:
				UvaWkPc6dpCDDN02iA4(this);
				num = 10;
				continue;
			case 7:
				Label = (string)JdQ0EtcI2doVeJPKE6E(other);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				GraphicId = BU8aY0cwJ9srZYgRMpk(other);
				num = 4;
				continue;
			case 10:
				CellLocation = (string)P9HXJIc4LxKihsURJvr(other);
				Color = MFgVmLcs5bp54vxUW9Z(other);
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				Font = (string)A0R3a5ccpT7ENvqLj5D(other);
				num = 6;
				if (!hDjgbccWsPRvACqQU28())
				{
					continue;
				}
				goto case 4;
			case 4:
				Name = (string)Xf0fC5cPDp8I4MEX5nf(other);
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					continue;
				}
				break;
			case 2:
				break;
			case 0:
			case 3:
				eQZkM5cC93iUx2vik6A();
				goto case 1;
			case 11:
				return;
			}
			LineThickness = tO1chvcioBieho5euJn(other);
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return n95hK9chtv1D7N5uOkg(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eQZkM5cC93iUx2vik6A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UvaWkPc6dpCDDN02iA4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S5rAOicQKRD2mblxsmV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hDjgbccWsPRvACqQU28()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P9HXJIc4LxKihsURJvr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MFgVmLcs5bp54vxUW9Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BU8aY0cwJ9srZYgRMpk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).GraphicId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xf0fC5cPDp8I4MEX5nf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JdQ0EtcI2doVeJPKE6E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Label;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A0R3a5ccpT7ENvqLj5D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Font;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JTG4qLcqebDvNXh1d9Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).FontSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tO1chvcioBieho5euJn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).LineThickness;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n95hK9chtv1D7N5uOkg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.MemberwiseClone();
	}
}
