using System.Drawing;
using System.Runtime.CompilerServices;
using u;

namespace Cognex.Tako;

public struct LabelFormat
{
	public enum Anchor
	{
		ModelCenter,
		VisibleCenter,
		VisibleLeft,
		VisibleRight,
		VisibleTop,
		VisibleBottom
	}

	public int FontSize;

	public Color Color;

	public Anchor AnchorPoint;

	public static LabelFormat Default()
	{
		LabelFormat result = new LabelFormat
		{
			FontSize = 14
		};
		Color color = Color.FromArgb(255, 255, 255, 255);
		result.Color = color;
		result.AnchorPoint = Anchor.ModelCenter;
		return result;
	}

	public unsafe LabelFormat(PJ.P9 fmt)
	{
		FontSize = *(int*)(&fmt);
		Color color = Color.FromArgb(1, (int)((double)System.Runtime.CompilerServices.Unsafe.As<PJ.P9, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref fmt, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<PJ.P9, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref fmt, 8)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<PJ.P9, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref fmt, 12)) * 255.0));
		Color = color;
		AnchorPoint = System.Runtime.CompilerServices.Unsafe.As<PJ.P9, Anchor>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref fmt, 16));
	}

	public unsafe PJ.P9* native(PJ.P9* P_0)
	{
		*(float*)((ulong)(nint)P_0 + 4uL) = 1f;
		*(float*)((ulong)(nint)P_0 + 8uL) = 1f;
		*(float*)((ulong)(nint)P_0 + 12uL) = 1f;
		*(int*)((ulong)(nint)P_0 + 16uL) = 0;
		*(int*)P_0 = FontSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
		*(float*)(&sf) = (float)((double)Color.R / 255.0);
		System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)Color.G / 255.0);
		System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)Color.B / 255.0);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned((long)(nint)P_0 + 4L, ref sf, 12);
		*(Anchor*)((ulong)(nint)P_0 + 16uL) = AnchorPoint;
		return P_0;
	}
}
