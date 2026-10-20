using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Shapes3DBase")]
public class CvsCogShape3D : CvsCogShape
{
	[CompilerGenerated]
	private int ahjBPOrXs3;

	[CompilerGenerated]
	private float zT9BjZlV7x;

	[CompilerGenerated]
	private string sFuBcHeTBF;

	[CompilerGenerated]
	private double[] dsQBdDQ4ow;

	[JsonProperty(PropertyName = "edgeColor", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(-16777077)]
	public int EdgeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ahjBPOrXs3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ahjBPOrXs3 = value;
		}
	}

	[JsonProperty(PropertyName = "markerSize", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue(1)]
	public float MarkerSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zT9BjZlV7x;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zT9BjZlV7x = value;
		}
	}

	[DefaultValue("Default")]
	[JsonProperty(PropertyName = "modelMode", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string ModelMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sFuBcHeTBF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sFuBcHeTBF = value;
		}
	}

	[JsonProperty(PropertyName = "modelMatrix", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] ModelMatrix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dsQBdDQ4ow;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dsQBdDQ4ow = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogShape3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FWsr4jcZedEqBuU979c();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogShape3D(CvsCogShape3D other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 5:
				ModelMatrix = other.ModelMatrix;
				num = 7;
				if (auQGWTcuQ69cS9Vt0kt())
				{
					break;
				}
				goto case 6;
			case 6:
				ModelMode = (string)a6v1YDcaYAXlZIgmoj9(other);
				num = 5;
				break;
			case 1:
			case 4:
				base._002Ector(other);
				goto case 0;
			case 3:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				_ = 0;
				if (!auQGWTcuQ69cS9Vt0kt())
				{
					num = 0;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				EdgeColor = DiK4VCctO3Cn5n13Lj5(other);
				goto case 6;
			default:
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FWsr4jcZedEqBuU979c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool auQGWTcuQ69cS9Vt0kt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kxtqBlcHxCvLdFY0rKv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DiK4VCctO3Cn5n13Lj5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).EdgeColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a6v1YDcaYAXlZIgmoj9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).ModelMode;
	}
}
