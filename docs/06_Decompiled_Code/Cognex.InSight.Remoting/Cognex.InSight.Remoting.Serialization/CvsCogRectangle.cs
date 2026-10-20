using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Rectangle")]
public class CvsCogRectangle : CvsCogShape
{
	[CompilerGenerated]
	private double VoGB3dqMFf;

	[CompilerGenerated]
	private double qwDB92vgZl;

	[CompilerGenerated]
	private double ivHBLfdiBF;

	[CompilerGenerated]
	private double cNqBVTrmJN;

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
			return VoGB3dqMFf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VoGB3dqMFf = value;
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
			return qwDB92vgZl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qwDB92vgZl = value;
		}
	}

	[JsonProperty(PropertyName = "w", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ivHBLfdiBF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ivHBLfdiBF = value;
		}
	}

	[JsonProperty(PropertyName = "h", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cNqBVTrmJN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cNqBVTrmJN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRectangle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sa9l14IGey23jBs053y();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRectangle(double x, double y, double w, double h)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (JSxxJXIostCkbFIE6Ht())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_009e;
			}
		}
		goto IL_0050;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 4:
				Width = w;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 6:
				Y = y;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				X = x;
				goto case 3;
			case 7:
				break;
			case 1:
				base._002Ector();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				sa9l14IGey23jBs053y();
				num = 1;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_009e;
		IL_009e:
		Height = h;
		num = 8;
		goto IL_0050;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle ToRectangle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Rectangle((int)Math.Round(X, MidpointRounding.AwayFromZero), (int)itvL59InaDDDjHCTOmx(Y, MidpointRounding.AwayFromZero), (int)itvL59InaDDDjHCTOmx(Width, MidpointRounding.AwayFromZero), (int)itvL59InaDDDjHCTOmx(Height, MidpointRounding.AwayFromZero));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RectangleF ToRectangleF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new RectangleF((float)X, (float)Y, (float)Width, (float)Height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sa9l14IGey23jBs053y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JSxxJXIostCkbFIE6Ht()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zi9XhfIFqoGTH2Qa2dG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double itvL59InaDDDjHCTOmx(double P_0, MidpointRounding P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0, P_1);
	}
}
