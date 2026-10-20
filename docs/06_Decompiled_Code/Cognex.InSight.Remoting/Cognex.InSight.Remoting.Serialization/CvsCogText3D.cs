using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Text3D")]
public class CvsCogText3D : CvsCogShape
{
	[CompilerGenerated]
	private double[] iJwylk7lew;

	[CompilerGenerated]
	private int adIybw7gHE;

	[CompilerGenerated]
	private string I9hyeEXrje;

	[JsonProperty(PropertyName = "position", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double[] Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iJwylk7lew;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iJwylk7lew = value;
		}
	}

	[JsonProperty(PropertyName = "textsize", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return adIybw7gHE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			adIybw7gHE = value;
		}
	}

	[JsonProperty(PropertyName = "text", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return I9hyeEXrje;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			I9hyeEXrje = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogText3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cZiPMrcpJULsMo5i2wc();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogText3D(double[] position, int size, string text, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UqR8Fscx7faWXD0Oagg();
		int num;
		if (cSUMd4cELDBBvArCLXC())
		{
			num = 2;
			if (!cSUMd4cELDBBvArCLXC())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_00ba;
		IL_002e:
		Color = color;
		num = 3;
		goto IL_00ba;
		IL_00ba:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				break;
			case 3:
				CellLocation = cellLocation;
				num = 9;
				if (cSUMd4cELDBBvArCLXC())
				{
					continue;
				}
				goto case 6;
			case 6:
				base._002Ector();
				num = 8;
				continue;
			case 7:
				Text = text;
				break;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 6;
				continue;
			case 8:
				Position = position;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				Size = size;
				goto case 7;
			default:
				num = 7;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cZiPMrcpJULsMo5i2wc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cSUMd4cELDBBvArCLXC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UqR8Fscx7faWXD0Oagg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
