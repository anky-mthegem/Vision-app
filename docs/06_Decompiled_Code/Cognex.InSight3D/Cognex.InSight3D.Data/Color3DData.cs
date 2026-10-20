using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.ThreeD.Common;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Data;

[DataContract(Name = "Color3DData")]
public class Color3DData
{
	[CompilerGenerated]
	private int DVh5uspR0;

	[CompilerGenerated]
	private int tQmW3mafI;

	[CompilerGenerated]
	private int IYLoJBx6R;

	[CompilerGenerated]
	private int ETajt2dIm;

	[DataMember]
	public int A
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DVh5uspR0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DVh5uspR0 = value;
		}
	}

	[DataMember]
	public int R
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tQmW3mafI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tQmW3mafI = value;
		}
	}

	[DataMember]
	public int G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IYLoJBx6R;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IYLoJBx6R = value;
		}
	}

	[DataMember]
	public int B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ETajt2dIm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ETajt2dIm = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color3DData FromColor(Color c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Color3DData color3DData = new Color3DData
		{
			A = c.A,
			R = c.R
		};
		qUOUJj4X61co13yU6XZ(color3DData, c.G);
		jtEcGe44jScBV8T7OQq(color3DData, c.B);
		return color3DData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color ToColor(Color3DData d)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Color(Convert.ToByte(RNmiqK4KqJPKh3n9cb6(d)), m74vfr4r5hOA3GvTpLI(ookoZb4eSqXkB7kkB1V(d)), m74vfr4r5hOA3GvTpLI(LGAAxv4lNLuTKGxIOrQ(d)), m74vfr4r5hOA3GvTpLI(bBSTPU4S5322HBwuetG(d)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color3DData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		z5RHrw4YSEhhroWhon9();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m5ItX5g3wkUXqECxYD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DxI0O1zmkhoIMacudQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qUOUJj4X61co13yU6XZ(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Color3DData)P_0).G = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jtEcGe44jScBV8T7OQq(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Color3DData)P_0).B = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RNmiqK4KqJPKh3n9cb6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Color3DData)P_0).A;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ookoZb4eSqXkB7kkB1V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Color3DData)P_0).R;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte m74vfr4r5hOA3GvTpLI(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToByte(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LGAAxv4lNLuTKGxIOrQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Color3DData)P_0).G;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bBSTPU4S5322HBwuetG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Color3DData)P_0).B;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z5RHrw4YSEhhroWhon9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}
}
