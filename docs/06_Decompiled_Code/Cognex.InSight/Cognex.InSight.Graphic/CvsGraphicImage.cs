using System;
using System.Runtime.CompilerServices;
using Cognex.Cnx.ComponentModel.Implementation;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicImage : CvsGraphic, IDisposable
{
	private CnxReferenceHandle<CvsImage> JV4J954i7s;

	public CvsImage Image
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JV4J954i7s.Get();
		}
	}

	public bool IsResultImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WaFRsP3od4VnFMmnE7T(this) < 0;
		}
	}

	public bool IsSourceImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WaFRsP3od4VnFMmnE7T(this) >= 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphicImage(ImageConfig image)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nr9Npf3CqjrbxbWNWLE())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_003f;
		IL_007b:
		JV4J954i7s.Set(new CvsImage());
		num = 5;
		goto IL_003f;
		IL_003f:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				XM3Ex13KknbSIjc8CNL();
				break;
			case 4:
				goto IL_007b;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		base._002Ector(image);
		goto IL_007b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicImage(CvsGraphicImage graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nr9Npf3CqjrbxbWNWLE();
		int num = ((!SRPQg83tyt1ZHFg7NPR()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector(graphic);
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 4:
				XM3Ex13KknbSIjc8CNL();
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			JV4J954i7s.Set((CvsImage)ffeqDU35DkKWkGnpmF8(graphic));
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicImage(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JV4J954i7s.Set(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XM3Ex13KknbSIjc8CNL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SRPQg83tyt1ZHFg7NPR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nr9Npf3CqjrbxbWNWLE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ffeqDU35DkKWkGnpmF8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicImage)P_0).Image;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WaFRsP3od4VnFMmnE7T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Id;
	}
}
