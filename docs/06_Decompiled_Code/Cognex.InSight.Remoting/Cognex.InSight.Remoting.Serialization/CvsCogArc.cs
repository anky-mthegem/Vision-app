using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Arc")]
public class CvsCogArc : CvsCogShape
{
	[CompilerGenerated]
	private float zSiYPD2Ofb;

	[CompilerGenerated]
	private float xfSYjajXux;

	[CompilerGenerated]
	private float GCSYcgql2Y;

	[CompilerGenerated]
	private bool ELdYdqm9vN;

	[CompilerGenerated]
	private float WFFYTr9RBf;

	[CompilerGenerated]
	private float vvsYvNdI9F;

	[JsonProperty(PropertyName = "angle0", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Angle0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zSiYPD2Ofb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zSiYPD2Ofb = value;
		}
	}

	[JsonProperty(PropertyName = "angle1", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Angle1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xfSYjajXux;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xfSYjajXux = value;
		}
	}

	[JsonProperty(PropertyName = "radius", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Radius
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GCSYcgql2Y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GCSYcgql2Y = value;
		}
	}

	[JsonProperty(PropertyName = "rotateClockwise", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool RotateClockwise
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ELdYdqm9vN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ELdYdqm9vN = value;
		}
	}

	[JsonProperty(PropertyName = "x", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WFFYTr9RBf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WFFYTr9RBf = value;
		}
	}

	[JsonProperty(PropertyName = "y", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vvsYvNdI9F;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vvsYvNdI9F = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogArc(float centerX, float centerY, float angle0, float angle1, float radius, bool rotateClockwise = false, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 10:
				X = centerX;
				num = 6;
				continue;
			case 2:
			case 7:
				RotateClockwise = rotateClockwise;
				Color = color;
				break;
			case 3:
				base._002Ector();
				num = 10;
				continue;
			case 9:
				Angle0 = 0f - angle0;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				Angle1 = 0f - angle1;
				num = 0;
				if (JcLWgoPC2ywwyqNYFGe())
				{
					continue;
				}
				goto case 0;
			case 0:
				Radius = radius;
				_ = 1;
				if (e4cQ7yP6NoM3kdkr6V1())
				{
					num = 1;
					continue;
				}
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				v22joTP4pmAxTleIg0w();
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				Y = centerY;
				num = 9;
				if (JcLWgoPC2ywwyqNYFGe())
				{
					continue;
				}
				break;
			case 1:
			case 8:
				break;
			case 11:
				return;
			}
			CellLocation = cellLocation;
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v22joTP4pmAxTleIg0w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JcLWgoPC2ywwyqNYFGe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e4cQ7yP6NoM3kdkr6V1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
