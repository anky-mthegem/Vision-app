using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Offset")]
public class CvsCogOffset : CvsCogShape
{
	[CompilerGenerated]
	private double YlwBlxbAnL;

	[CompilerGenerated]
	private double oBtBbfOpxb;

	[CompilerGenerated]
	private double FbFBeMTihJ;

	[CompilerGenerated]
	private double B7kBFbunci;

	[CompilerGenerated]
	private double VbqBCX8xb7;

	[JsonProperty(PropertyName = "x", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YlwBlxbAnL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YlwBlxbAnL = value;
		}
	}

	[JsonProperty(PropertyName = "y", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oBtBbfOpxb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oBtBbfOpxb = value;
		}
	}

	[JsonProperty(PropertyName = "xOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double XOrigin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FbFBeMTihJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FbFBeMTihJ = value;
		}
	}

	[JsonProperty(PropertyName = "yOrigin", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double YOrigin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return B7kBFbunci;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B7kBFbunci = value;
		}
	}

	[JsonProperty(PropertyName = "angle", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VbqBCX8xb7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VbqBCX8xb7 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogOffset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JyUX7QI4sWTHQejX5MO();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogOffset(double x, double y, double xo, double yo, double a)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0053;
		IL_001a:
		JyUX7QI4sWTHQejX5MO();
		num = 2;
		goto IL_0053;
		IL_0053:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 1:
				X = x;
				num = 4;
				continue;
			case 4:
				Y = y;
				goto case 0;
			default:
				num = 0;
				continue;
			case 5:
			case 7:
				YOrigin = yo;
				goto case 3;
			case 0:
				XOrigin = xo;
				dxHhNOI6LAGsNp0dAHP();
				num = (atGr37ICGpNg83rjuCx() ? 7 : 3);
				continue;
			case 3:
			case 6:
				Angle = a;
				num = 9;
				continue;
			case 2:
				base._002Ector();
				num = 1;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JyUX7QI4sWTHQejX5MO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool atGr37ICGpNg83rjuCx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dxHhNOI6LAGsNp0dAHP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
