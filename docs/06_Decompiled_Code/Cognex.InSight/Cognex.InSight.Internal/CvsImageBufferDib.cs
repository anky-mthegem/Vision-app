using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cognex.Cnx.ComponentModel.Implementation;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Imaging;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
internal class CvsImageBufferDib : CnxReferenceCountBase
{
	private CnxPixelFormat j7LXlB07Lr;

	private readonly int wMxXgmgbFx;

	private IntPtr lFJXq1s3C4;

	private readonly CnxVector2 xTVXTlYZOr;

	private IntPtr a6GXBY7Ry6;

	private readonly int ET2XJt9SC5;

	private IntPtr igKXMh7RAI;

	private IntPtr jI6Xo2Ecd0;

	private readonly int jcgXAfxKu9;

	internal static int __allocatedBytes;

	private static readonly ICvsImageConfigurationSource Fs8XtCtKLu;

	private static readonly CnxPixelFormat R9hXWQaG7s;

	internal IntPtr Scan0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return a6GXBY7Ry6;
		}
	}

	internal int Stride
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ET2XJt9SC5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsImageBufferDib()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		Type type = default;
		Type[] emptyTypes = default;
		object[] array = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				type = wKKyHq07FBO6yubCHy4(fysOb60WfO7njdf1Exb(), "Cognex.InSight.Internal.CvsDefaultImageConfiguration");
				goto case 2;
			case 5:
				emptyTypes = Type.EmptyTypes;
				num = 6;
				break;
			case 0:
				R9hXWQaG7s = FNLfmD0580sK3xkc2iw(Fs8XtCtKLu);
				num = 9;
				break;
			case 2:
			case 3:
				if (JAfV4S0tClmREEB03b4(type, null))
				{
					num = 4;
					break;
				}
				array = new object[0];
				goto case 5;
			case 6:
				Fs8XtCtKLu = (ICvsImageConfigurationSource)lGm47Q0KZTwIfDNuQ3t(type.GetConstructor(emptyTypes), array);
				num = 0;
				break;
			case 4:
				throw new InvalidOperationException((string)NcOO5a0Cc70YPRqXKoA(44692));
			default:
				num = 5;
				break;
			case 8:
				O7O3vN02owF4jZViEVd();
				_ = 1;
				if (pQT2bs0cOAFNkHpNrbx())
				{
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				num = 7;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe CvsImageBufferDib(CnxVector2 size, CnxPixelFormat pixelFormat, int[] palette)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_012c;
		IL_001a:
		if (palette == null)
		{
			goto IL_004b;
		}
		num = 7;
		goto IL_012c;
		IL_004b:
		int x = default;
		int y = default;
		if (palette != null && palette.Length != 256)
		{
			num = 21;
		}
		else
		{
			x = size.X;
			y = size.Y;
			num = 9;
		}
		goto IL_012c;
		IL_012c:
		Type typeFromHandle = default;
		CnxNativeMethods.BITMAPINFO pbmi = default;
		bool lockTaken = default;
		CnxNativeMethods.BITMAP bITMAP = default;
		while (true)
		{
			IntPtr ppvBits;
			switch (num)
			{
			case 4:
				break;
			case 13:
				O7O3vN02owF4jZViEVd();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				throw new ArgumentException((string)NcOO5a0Cc70YPRqXKoA(44866));
			case 22:
				typeFromHandle = typeof(CvsImageBufferDib);
				num = 20;
				if (pQT2bs0cOAFNkHpNrbx())
				{
				}
				continue;
			case 12:
				pbmi = new CnxNativeMethods.BITMAPINFO(wKQlgA0o0YQnIhUfEYQ(size), pixelFormat, palette);
				num = 16;
				if (!pQT2bs0cOAFNkHpNrbx())
				{
					continue;
				}
				goto case 11;
			case 11:
				jcgXAfxKu9 = x * y * wMxXgmgbFx;
				num = 1;
				continue;
			case 20:
				lockTaken = false;
				num = 23;
				if (true)
				{
					continue;
				}
				goto case 21;
			case 21:
				throw new ArgumentOutOfRangeException(kgbOBx7BanbFa22Hp9.ol99ukmDA(45012));
			case 10:
			case 14:
				lFJXq1s3C4 = CnxNativeMethods.CreateDIBSection(IntPtr.Zero, ref pbmi, 0, out ppvBits, IntPtr.Zero, 0);
				a6GXBY7Ry6 = ppvBits;
				goto case 15;
			default:
				num = 15;
				continue;
			case 8:
				goto IL_019b;
			case 2:
			case 19:
				if (pixelFormat == CnxPixelFormat.Unknown)
				{
					pixelFormat = R9hXWQaG7s;
					num = 8;
					continue;
				}
				goto IL_019b;
			case 5:
				goto IL_01c3;
			case 6:
				bITMAP = default;
				num = 18;
				continue;
			case 9:
				xTVXTlYZOr = new CnxVector2(x, y);
				j7LXlB07Lr = pixelFormat;
				num = 12;
				if (aiWOeP0jr0AoMoAAqWV())
				{
					continue;
				}
				goto case 17;
			case 17:
				wMxXgmgbFx = muGu3W0360ssRPcLgU4(j7LXlB07Lr) / 8;
				num = 11;
				continue;
			case 16:
				ppvBits = IntPtr.Zero;
				goto case 10;
			case 1:
				if (ET2XJt9SC5 == 0)
				{
					num = 3;
					continue;
				}
				goto case 22;
			case 18:
				YDSXon0rKknlZC9NXFe(lFJXq1s3C4, xwgMXB01cgy3KArEcYf(qvktPc0xlMh2tVItBog(typeof(CnxNativeMethods.BITMAP).TypeHandle)), new IntPtr(&bITMAP));
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 15;
			case 15:
				if (NNZxgo0PDI1RcsQWHjA(lFJXq1s3C4, IntPtr.Zero))
				{
					throw new OutOfMemoryException((string)xkVjEV0YGFyt6uVr8ZI(NcOO5a0Cc70YPRqXKoA(45146), size.ToString()));
				}
				if (!JnWWib0N9Mcx9k49TWU(a6GXBY7Ry6, IntPtr.Zero))
				{
					goto case 17;
				}
				num = 6;
				if (aiWOeP0jr0AoMoAAqWV())
				{
					continue;
				}
				goto case 3;
			case 3:
				ET2XJt9SC5 = xTVXTlYZOr.X * wMxXgmgbFx;
				num = 22;
				continue;
			case 0:
				ET2XJt9SC5 = (bITMAP.bmWidthBytes + 3) / 4 * 4;
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 23;
			case 23:
				try
				{
					Monitor.Enter(typeFromHandle, ref lockTaken);
					_ = 1;
					switch (pQT2bs0cOAFNkHpNrbx() ? 3 : 2)
					{
					case 0:
					case 2:
						__allocatedBytes += jcgXAfxKu9;
						break;
					}
					OwUtZT0Ogpp0RbaC3Hx(jcgXAfxKu9);
					return;
				}
				finally
				{
					if (lockTaken)
					{
						PCwW8M0MfZOaxgrUcsc(typeFromHandle);
					}
				}
			}
			break;
			IL_01c3:
			base._002Ector();
			pQT2bs0cOAFNkHpNrbx();
			num = ((!aiWOeP0jr0AoMoAAqWV()) ? 14 : 19);
			continue;
			IL_019b:
			if (pixelFormat != CnxPixelFormat.Format8bppIndexed)
			{
				num = 4;
				continue;
			}
			goto IL_004b;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int BitsPerPixel(CnxPixelFormat pixelFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		switch (pixelFormat)
		{
		case CnxPixelFormat.Format1bppMonochrome:
			return 1;
		case CnxPixelFormat.Format8bppGrayscale:
		case CnxPixelFormat.Format8bppIndexed:
			return 8;
		case CnxPixelFormat.Format16bppRgb565:
			return 16;
		case CnxPixelFormat.Format24bppRgb:
			return 24;
		case CnxPixelFormat.Format32bppRgb:
		case CnxPixelFormat.Format32bppARgb:
			return 32;
		default:
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(45226));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~CvsImageBufferDib()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			Dispose(disposing: false);
		}
		finally
		{
			qDBhhl0Q5kgjfhLwRWo(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IntPtr GetDc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		aiWOeP0jr0AoMoAAqWV();
		int num = (pQT2bs0cOAFNkHpNrbx() ? 1 : 8);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 8:
				H2PX46uxT0();
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				if (NNZxgo0PDI1RcsQWHjA(jI6Xo2Ecd0, IntPtr.Zero))
				{
					goto case 3;
				}
				UlOrAa0e8KD57bOR5Ir(igKXMh7RAI, CnxNativeMethods.GraphicsMode.GM_ADVANCED);
				num = 2;
				if (!pQT2bs0cOAFNkHpNrbx())
				{
					continue;
				}
				break;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				if (igKXMh7RAI == IntPtr.Zero)
				{
					num = 11;
					continue;
				}
				jI6Xo2Ecd0 = Suvd340lOlTXEJKVcVv(igKXMh7RAI, lFJXq1s3C4);
				goto case 1;
			case 10:
				igKXMh7RAI = CnxNativeMethods.CreateCompatibleDC(IntPtr.Zero);
				num = 7;
				continue;
			case 9:
				if (igKXMh7RAI == IntPtr.Zero)
				{
					num = 10;
					continue;
				}
				goto IL_0171;
			case 2:
				GU9TKn0uf9xuIVa8qoR(igKXMh7RAI, 3);
				num = 6;
				continue;
			case 4:
				eq4FP10aOcMuXODTVJS(igKXMh7RAI, 0, 0);
				num = 12;
				continue;
			case 11:
				throw new OutOfMemoryException((string)NcOO5a0Cc70YPRqXKoA(45278));
			case 6:
				WOw3QR0IZteClAwhSWv(igKXMh7RAI, CnxNativeMethods.BkMode.TRANSPARENT);
				goto IL_0171;
			case 3:
				throw new OutOfMemoryException((string)NcOO5a0Cc70YPRqXKoA(45378));
			case 12:
				break;
				IL_0171:
				WynXlF0RvdXHfOMvKl7(igKXMh7RAI, IntPtr.Zero);
				num = 4;
				continue;
			}
			break;
		}
		return igKXMh7RAI;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void ReleaseDc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pQT2bs0cOAFNkHpNrbx();
		int num;
		if (aiWOeP0jr0AoMoAAqWV())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0082;
			}
		}
		goto IL_00b5;
		IL_00b5:
		while (true)
		{
			switch (num)
			{
			case 1:
				igKXMh7RAI = IntPtr.Zero;
				num = 7;
				continue;
			case 0:
			case 5:
				if (igKXMh7RAI != IntPtr.Zero)
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				return;
			case 4:
				Suvd340lOlTXEJKVcVv(igKXMh7RAI, jI6Xo2Ecd0);
				goto case 2;
			case 3:
				break;
			case 2:
			case 6:
				jI6Xo2Ecd0 = IntPtr.Zero;
				break;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 7:
				return;
			}
			break;
		}
		goto IL_0082;
		IL_0082:
		fSimbk0nj9gH0kDxM6x(igKXMh7RAI);
		num = 1;
		goto IL_00b5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		Type type = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (disposing)
				{
					num = 1;
					continue;
				}
				goto IL_0160;
			case 9:
				CnxNativeMethods.DeleteBitmap(lFJXq1s3C4);
				num = 10;
				if (!pQT2bs0cOAFNkHpNrbx())
				{
					continue;
				}
				goto case 2;
			case 2:
				try
				{
					Monitor.Enter(type, ref lockTaken);
					pQT2bs0cOAFNkHpNrbx();
					int num2 = ((!aiWOeP0jr0AoMoAAqWV()) ? 2 : 3);
					while (true)
					{
						switch (num2)
						{
						case 0:
						case 3:
							if (jcgXAfxKu9 > 0)
							{
								break;
							}
							goto end_IL_009f;
						case 4:
							GC.RemoveMemoryPressure(jcgXAfxKu9);
							goto end_IL_009f;
						}
						__allocatedBytes -= jcgXAfxKu9;
						num2 = 4;
						continue;
						end_IL_009f:
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						PCwW8M0MfZOaxgrUcsc(type);
					}
				}
				lFJXq1s3C4 = IntPtr.Zero;
				goto case 0;
			case 8:
				base.Dispose(disposing);
				num = 11;
				continue;
			case 0:
			case 7:
				a6GXBY7Ry6 = IntPtr.Zero;
				num = 8;
				continue;
			case 4:
			case 5:
				lockTaken = false;
				num = 2;
				if (!pQT2bs0cOAFNkHpNrbx())
				{
					continue;
				}
				goto case 6;
			case 6:
				if (!JnWWib0N9Mcx9k49TWU(lFJXq1s3C4, IntPtr.Zero))
				{
					goto case 0;
				}
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				nEURtZ0Gs4TiwJnlpaI(this);
				goto IL_0160;
			case 10:
				type = qvktPc0xlMh2tVItBog(typeof(CvsImageBufferDib).TypeHandle);
				break;
			case 11:
				return;
				IL_0160:
				ReleaseDc();
				num = 6;
				if (aiWOeP0jr0AoMoAAqWV())
				{
					continue;
				}
				goto case 10;
			}
			aiWOeP0jr0AoMoAAqWV();
			num = ((!pQT2bs0cOAFNkHpNrbx()) ? 4 : 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void H2PX46uxT0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (lFJXq1s3C4 == IntPtr.Zero)
		{
			throw new ObjectDisposedException((string)NcOO5a0Cc70YPRqXKoA(45480));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object GetNativeStorage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H2PX46uxT0();
		return lFJXq1s3C4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IntPtr DetachHBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H2PX46uxT0();
		IntPtr result = lFJXq1s3C4;
		lFJXq1s3C4 = IntPtr.Zero;
		Dispose();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O7O3vN02owF4jZViEVd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fysOb60WfO7njdf1Exb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Assembly.GetExecutingAssembly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type wKKyHq07FBO6yubCHy4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetType((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JAfV4S0tClmREEB03b4(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NcOO5a0Cc70YPRqXKoA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lGm47Q0KZTwIfDNuQ3t(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ConstructorInfo)P_0).Invoke((object[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxPixelFormat FNLfmD0580sK3xkc2iw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageConfigurationSource)P_0).ImageConvertFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aiWOeP0jr0AoMoAAqWV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pQT2bs0cOAFNkHpNrbx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxVector2F wKQlgA0o0YQnIhUfEYQ(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NNZxgo0PDI1RcsQWHjA(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xkVjEV0YGFyt6uVr8ZI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JnWWib0N9Mcx9k49TWU(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type qvktPc0xlMh2tVItBog(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xwgMXB01cgy3KArEcYf(Type P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Marshal.SizeOf(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YDSXon0rKknlZC9NXFe(IntPtr hGdiObj, int cbBuffer, IntPtr lpvObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.GetObject(hGdiObj, cbBuffer, lpvObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int muGu3W0360ssRPcLgU4(CnxPixelFormat pixelFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitsPerPixel(pixelFormat);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OwUtZT0Ogpp0RbaC3Hx(long P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GC.AddMemoryPressure(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PCwW8M0MfZOaxgrUcsc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qDBhhl0Q5kgjfhLwRWo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0.Finalize();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Suvd340lOlTXEJKVcVv(IntPtr hdc, IntPtr hgdiobj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectObject(hdc, hgdiobj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UlOrAa0e8KD57bOR5Ir(IntPtr hdc, CnxNativeMethods.GraphicsMode Mode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetGraphicsMode(hdc, Mode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GU9TKn0uf9xuIVa8qoR(IntPtr hdc, int iStretchMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetStretchBltMode(hdc, iStretchMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WOw3QR0IZteClAwhSWv(IntPtr hdc, CnxNativeMethods.BkMode iBkMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetBkMode(hdc, iBkMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WynXlF0RvdXHfOMvKl7(IntPtr hdc, IntPtr hrgn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectClipRgn(hdc, hrgn);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eq4FP10aOcMuXODTVJS(IntPtr hdc, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetViewportOrgEx(hdc, x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fSimbk0nj9gH0kDxM6x(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteDC(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nEURtZ0Gs4TiwJnlpaI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GC.SuppressFinalize(P_0);
	}
}
