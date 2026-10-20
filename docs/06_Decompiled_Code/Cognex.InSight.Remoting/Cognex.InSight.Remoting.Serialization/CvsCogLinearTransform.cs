using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "LinearTransform")]
public class CvsCogLinearTransform
{
	[CompilerGenerated]
	private double cxCbzHkfhO;

	[CompilerGenerated]
	private double qW3eA5qK9a;

	[CompilerGenerated]
	private double fBbeH3yEQD;

	[CompilerGenerated]
	private double JPKeUbrvxc;

	[CompilerGenerated]
	private double nE6ellBGDO;

	[CompilerGenerated]
	private double hC8ebPrHw1;

	[DefaultValue(1)]
	[JsonProperty(PropertyName = "m00", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	public double M00
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cxCbzHkfhO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cxCbzHkfhO = value;
		}
	}

	[DefaultValue(0)]
	[JsonProperty(PropertyName = "m01", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	public double M01
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qW3eA5qK9a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qW3eA5qK9a = value;
		}
	}

	[JsonProperty(PropertyName = "m10", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	[DefaultValue(0)]
	public double M10
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fBbeH3yEQD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fBbeH3yEQD = value;
		}
	}

	[JsonProperty(PropertyName = "m11", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	[DefaultValue(1)]
	public double M11
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JPKeUbrvxc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JPKeUbrvxc = value;
		}
	}

	[DefaultValue(0)]
	[JsonProperty(PropertyName = "tx", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	public double XOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nE6ellBGDO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nE6ellBGDO = value;
		}
	}

	[JsonProperty(PropertyName = "ty", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
	[DefaultValue(0)]
	public double YOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hC8ebPrHw1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hC8ebPrHw1 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLinearTransform()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		utguYA6TTZQwdJq2CQu();
		hXdP9l6oWBJ3SY2goiQ(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLinearTransform(double m00, double m01, double m10, double m11, double xOffset, double yOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (nXNKg165QoCTO4hxReX() ? 5 : 8);
		while (true)
		{
			switch (num)
			{
			case 4:
				hXdP9l6oWBJ3SY2goiQ(this);
				num = 9;
				if (!nXNKg165QoCTO4hxReX())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 8:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 4;
				continue;
			case 2:
				M11 = m11;
				goto case 5;
			case 7:
				YOffset = yOffset;
				num = 10;
				continue;
			case 5:
			case 6:
				XOffset = xOffset;
				num = 7;
				continue;
			case 1:
				M10 = m10;
				goto case 2;
			default:
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				M01 = m01;
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 9:
				break;
			case 10:
				return;
			}
			M00 = m00;
			num = 3;
			if (nXNKg165QoCTO4hxReX())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void utguYA6TTZQwdJq2CQu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hXdP9l6oWBJ3SY2goiQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HPpMSQ6KfFQlqdXIaxm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nXNKg165QoCTO4hxReX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
