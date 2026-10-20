using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Line")]
public class CvsCogLine : CvsCogShape
{
	[CompilerGenerated]
	private int fVh5WYtSJp;

	[CompilerGenerated]
	private int VNK5opc0qx;

	[CompilerGenerated]
	private double DCG5PdE3Do;

	[CompilerGenerated]
	private double FIv5jrd07B;

	[CompilerGenerated]
	private double vU45cJUDEk;

	[CompilerGenerated]
	private double MwD5dcdov3;

	[DefaultValue(0)]
	[JsonProperty(PropertyName = "adornment0", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int Adornment0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fVh5WYtSJp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fVh5WYtSJp = value;
		}
	}

	[DefaultValue(0)]
	[JsonProperty(PropertyName = "adornment1", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int Adornment1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VNK5opc0qx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VNK5opc0qx = value;
		}
	}

	[JsonProperty(PropertyName = "x0", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double X0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DCG5PdE3Do;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DCG5PdE3Do = value;
		}
	}

	[JsonProperty(PropertyName = "y0", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Y0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FIv5jrd07B;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FIv5jrd07B = value;
		}
	}

	[JsonProperty(PropertyName = "x1", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double X1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vU45cJUDEk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vU45cJUDEk = value;
		}
	}

	[JsonProperty(PropertyName = "y1", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Y1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MwD5dcdov3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MwD5dcdov3 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLine()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLine(double x0, double y0, double x1, double y1, int adornment0 = 0, int adornment1 = 0, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!xBXd5mP1pjSwICaLjLP())
		{
			goto IL_001e;
		}
		goto IL_00d7;
		IL_001e:
		Y1 = y1;
		num = 0;
		goto IL_00d7;
		IL_00d7:
		while (true)
		{
			switch (num)
			{
			case 10:
				break;
			case 2:
				Adornment1 = adornment1;
				Color = color;
				goto case 7;
			case 3:
			case 6:
				Y0 = y0;
				num = 1;
				if (!NrXDkaPJE9g55aCxUmi())
				{
					continue;
				}
				goto case 7;
			case 7:
			case 8:
				CellLocation = cellLocation;
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				X0 = x0;
				xBXd5mP1pjSwICaLjLP();
				num = ((!NrXDkaPJE9g55aCxUmi()) ? 6 : 7);
				continue;
			case 0:
				Adornment0 = adornment0;
				num = 2;
				continue;
			case 9:
				base._002Ector();
				num = 5;
				continue;
			case 1:
				X1 = x1;
				break;
			default:
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 9;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xBXd5mP1pjSwICaLjLP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NrXDkaPJE9g55aCxUmi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
