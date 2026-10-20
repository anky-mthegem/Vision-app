using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EditingCross")]
public class CvsCogEditingCross : CvsCogEditingShape
{
	[CompilerGenerated]
	private bool scDFW8auS2;

	[CompilerGenerated]
	private bool HThFoleiy8;

	[CompilerGenerated]
	private bool CWyFPmtW3l;

	[JsonProperty(PropertyName = "move", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Move
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return scDFW8auS2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			scDFW8auS2 = value;
		}
	}

	[JsonProperty(PropertyName = "rotate", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Rotate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HThFoleiy8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HThFoleiy8 = value;
		}
	}

	[JsonProperty(PropertyName = "resize", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Resize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CWyFPmtW3l;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CWyFPmtW3l = value;
		}
	}

	public CvsCogCross Cross
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Shape as CvsCogCross;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEditingCross()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (MA38PksRqy9dXCa9bGG())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_007a;
			}
		}
		goto IL_003c;
		IL_003c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector();
				break;
			default:
				goto IL_0059;
			case 0:
			case 2:
				yRy3GgsxnnmR9Bkt0ss();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			break;
			IL_0059:
			num = 4;
		}
		goto IL_007a;
		IL_007a:
		Resize = true;
		num = 5;
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yRy3GgsxnnmR9Bkt0ss()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MA38PksRqy9dXCa9bGG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LKQGVZsEyY1hZWfcn1m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
