using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Line3D")]
public class CvsCogLine3D : CvsCogShape3D
{
	private double[] Cn45T0tsVn;

	private double[] PvJ5vAh21I;

	[CompilerGenerated]
	private string QDH5zkhJrf;

	[JsonProperty(PropertyName = "start", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Start
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cn45T0tsVn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Cn45T0tsVn = value;
		}
	}

	[JsonProperty(PropertyName = "end", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] End
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PvJ5vAh21I;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PvJ5vAh21I = value;
		}
	}

	[DefaultValue("Regular")]
	[JsonProperty(PropertyName = "style", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QDH5zkhJrf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QDH5zkhJrf = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLine3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VYmDgGPmiI2xqxspIup();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLine3D(double[] start, double[] end, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				Color = color;
				num = 7;
				break;
			case 2:
			case 3:
				End = end;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 6:
				base._002Ector();
				num = 5;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				Start = start;
				goto case 2;
			case 7:
				CellLocation = cellLocation;
				num = 8;
				if (mAC1jaPjUmJn5VxP8dh())
				{
				}
				break;
			case 4:
				VYmDgGPmiI2xqxspIup();
				uUJ1gBP8kVpSD4rcErB();
				if (mAC1jaPjUmJn5VxP8dh())
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 7;
				}
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VYmDgGPmiI2xqxspIup()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uUJ1gBP8kVpSD4rcErB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mAC1jaPjUmJn5VxP8dh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
