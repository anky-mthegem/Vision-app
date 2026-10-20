using System;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Imaging;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsImageData : ICvsImageData
{
	private readonly int iLEX3DFv0x;

	private readonly int CSJXLyEvIi;

	private readonly IntPtr rqYXkLKhLP;

	private readonly CnxPixelFormat vGYXX3l5us;

	private readonly int MOEXfQ27bM;

	private readonly CvsImageLockMode bsWXjCBF3C;

	public int Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iLEX3DFv0x;
		}
	}

	public int Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CSJXLyEvIi;
		}
	}

	public CnxPixelFormat PixelFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vGYXX3l5us;
		}
	}

	public IntPtr Scan0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rqYXkLKhLP;
		}
	}

	public int Stride
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MOEXfQ27bM;
		}
	}

	public CvsImageLockMode LockMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bsWXjCBF3C;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsImageData(int width, int height, IntPtr scan0, CnxPixelFormat pixelFormat, int stride, CvsImageLockMode lockMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!RZ1Kps49EdJQRlY8Ex2())
		{
			num = 5;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 9;
		}
		goto IL_007a;
		IL_0026:
		vGYXX3l5us = pixelFormat;
		num = 6;
		goto IL_007a;
		IL_007a:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				MOEXfQ27bM = stride;
				goto case 7;
			case 0:
			case 5:
				bW2qMP4SbxHdIGkSWCq();
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				rqYXkLKhLP = scan0;
				break;
			default:
				num = 1;
				continue;
			case 3:
				liTuNE4ELmMn7l7OXBj(this);
				num = 2;
				continue;
			case 2:
				iLEX3DFv0x = width;
				num = 8;
				continue;
			case 8:
				CSJXLyEvIi = height;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
			case 9:
				bsWXjCBF3C = lockMode;
				num = 10;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsImageData(int width, int height, IntPtr scan0, CnxPixelFormat pixelFormat, int stride)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bW2qMP4SbxHdIGkSWCq();
		this._002Ector(width, height, scan0, pixelFormat, stride, CvsImageLockMode.ReadWrite);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bW2qMP4SbxHdIGkSWCq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void liTuNE4ELmMn7l7OXBj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a2vxeb4LtM9PB2NE1og()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RZ1Kps49EdJQRlY8Ex2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
