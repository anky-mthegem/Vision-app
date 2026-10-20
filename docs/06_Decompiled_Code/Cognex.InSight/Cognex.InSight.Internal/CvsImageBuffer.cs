using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cognex.Cnx.ComponentModel.Implementation;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Imaging;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsImageBuffer : CvsImageBufferBase
{
	private CnxReferenceHandle<CvsImageBufferDib> YOvkwaKdVa;

	[NonSerialized]
	private Graphics YyckRABH3e;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsImageBuffer(Size size, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				YOvkwaKdVa.Set(new CvsImageBufferDib(aAVfru65NT9BKD1TgnG(size), format, null));
				num = 5;
				break;
			case 1:
			case 3:
				base._002Ector(size, format);
				goto default;
			case 0:
				LBBGrl6K8hpW04H2v3V();
				BYP0LL6thYgaxryl4Fv();
				num = ((!OkHVeL6COWqv7I9PJka()) ? 3 : 4);
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsImageBuffer(ICvsImageBuffer other, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!BYP0LL6thYgaxryl4Fv()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				this._002Ector(Vgs6GR6oJS04lCy6c8b(other), format);
				goto case 2;
			default:
				num = 2;
				if (OkHVeL6COWqv7I9PJka())
				{
				}
				break;
			case 2:
				CopyFrom(other);
				num = 5;
				if (BYP0LL6thYgaxryl4Fv())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				LBBGrl6K8hpW04H2v3V();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsImageBuffer(Bitmap bmp, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (BYP0LL6thYgaxryl4Fv() ? 1 : 4);
		IntPtr intPtr2 = default;
		while (true)
		{
			switch (num)
			{
			default:
				intPtr2 = kU3SFJ6Pi0iTqGquFLt(bmp);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				this._002Ector(bmp.Size, format);
				goto default;
			case 0:
			case 1:
				LBBGrl6K8hpW04H2v3V();
				num = 3;
				break;
			case 5:
				try
				{
					IntPtr intPtr = m0wkoI6Ybyl4be9RvRP(GetDc());
					try
					{
						IntPtr hgdiobj = oW5RlO6NouMMbneHd7U(intPtr, intPtr2);
						try
						{
							Bf5du06xcpWKfow2MeH(GetDc(), 0, 0, Size.Width, Size.Height, intPtr, 0, 0, CnxNativeMethods.RasterOp.SRCCOPY);
							return;
						}
						finally
						{
							CnxNativeMethods.SelectObject(intPtr, hgdiobj);
						}
					}
					finally
					{
						CnxNativeMethods.DeleteDC(intPtr);
					}
				}
				finally
				{
					CnxNativeMethods.DeleteBitmap(intPtr2);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsImageBuffer FromResource(Assembly assembly, string resourceId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BYP0LL6thYgaxryl4Fv();
		int num;
		if (!OkHVeL6COWqv7I9PJka())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0042;
			}
		}
		Stream stream = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stream = (Stream)MOyDMa61cipuxmDxgJG(assembly, resourceId);
				break;
			case 1:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_007d;
			}
			break;
		}
		goto IL_0042;
		IL_007d:
		throw new ArgumentException((string)q6FpCc63u2DfduILfol(rsB7dK6rAZj3apAkLsS(43276), resourceId));
		IL_0042:
		if (stream == null)
		{
			goto IL_007d;
		}
		try
		{
			return new CvsImageBuffer(new Bitmap(stream), CnxPixelFormat.Format32bppRgb);
		}
		finally
		{
			oA0Bx46O5YXbbYtpQRl(stream);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!OkHVeL6COWqv7I9PJka())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 0:
				base.Dispose(disposing);
				_ = 1;
				if (!OkHVeL6COWqv7I9PJka())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 3;
				if (true)
				{
					break;
				}
				goto default;
			case 1:
			case 4:
				if (disposing)
				{
					goto default;
				}
				return;
			default:
				YOvkwaKdVa.Set(null);
				num = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IntPtr GetDcCore()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Hwpa166MdEmLy3NTrWu(YOvkwaKdVa.Get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReleaseDcCore(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ReleaseGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IntPtr GetMemoryPtr(bool write, out int stride, out CnxPixelFormat nativePixelFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nativePixelFormat = PixelFormat;
		stride = YOvkwaKdVa.Get().Stride;
		return CvgYr66QMsZIYoh9Yg3(YOvkwaKdVa.Get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReleaseGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!BYP0LL6thYgaxryl4Fv())
		{
			goto IL_001e;
		}
		goto IL_003b;
		IL_001e:
		fpslhC6l60fiuRnhBbk(YyckRABH3e);
		goto IL_00ae;
		IL_003b:
		while (true)
		{
			IL_003b_2:
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 3:
				if (!IsFinalizing)
				{
					break;
				}
				goto IL_00ae;
			case 0:
				while (true)
				{
					if (YyckRABH3e != null)
					{
						OkHVeL6COWqv7I9PJka();
						if (BYP0LL6thYgaxryl4Fv())
						{
							break;
						}
						num = 5;
						if (BYP0LL6thYgaxryl4Fv())
						{
							goto IL_003b_2;
						}
						continue;
					}
					return;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto IL_00ae;
			case 4:
				goto IL_00ae;
			case 6:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_00ae:
		YyckRABH3e = null;
		num = 6;
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Bitmap ToBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		int num2 = default;
		Size size = default;
		Bitmap bitmap = default;
		ColorPalette colorPalette = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				num2 = 0;
				goto case 6;
			default:
				num = 10;
				continue;
			case 1:
			{
				int width = size.Width;
				size = Size;
				bitmap = new Bitmap(width, size.Height, pyBdPG6exuSpEZegEnk(YOvkwaKdVa.Get()), I8I6UG6ufhFNalfMYSh(PixelFormat), CvgYr66QMsZIYoh9Yg3(YOvkwaKdVa.Get()));
				num = 4;
				if (!OkHVeL6COWqv7I9PJka())
				{
					continue;
				}
				goto case 8;
			}
			case 8:
				bitmap.Palette = colorPalette;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
			case 7:
			case 10:
				if (num2 >= 256)
				{
					num = 8;
					continue;
				}
				((Color[])ThYS4Y6a4IRf7bkEYF2(colorPalette))[num2] = BBbLpR6nXEQPouq1vyk(num2, num2, num2);
				num = 0;
				if (BYP0LL6thYgaxryl4Fv())
				{
					continue;
				}
				break;
			case 5:
				size = Size;
				num = 1;
				continue;
			case 2:
			case 3:
				colorPalette = (ColorPalette)zGwmbe6RdspjbYmkXHk(bitmap);
				num = 9;
				if (BYP0LL6thYgaxryl4Fv())
				{
					continue;
				}
				goto case 4;
			case 4:
				if (jDo9iu6IJ0OHMJqE2HY(bitmap) != System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
				{
					break;
				}
				BYP0LL6thYgaxryl4Fv();
				if (!OkHVeL6COWqv7I9PJka())
				{
					num = 2;
					continue;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 0:
				num2++;
				goto case 6;
			case 11:
				break;
			}
			break;
		}
		return bitmap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Bitmap CreateBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Bitmap)IlCFrC6XGFGFSJ5fNVq((IntPtr)LZSiJ16GmjnoHaNe86R(YOvkwaKdVa.Get()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetNativeStorage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YOvkwaKdVa.Get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override IntPtr GetNewHBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using CvsImageBuffer cvsImageBuffer = new CvsImageBuffer(this, PixelFormat);
		return BBB1J96bLpQshZ9qVFm(cvsImageBuffer.YOvkwaKdVa.Get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteBitmap(ref Stream stm, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		byte[] array2 = default;
		int num2 = default;
		int num3 = default;
		BinaryWriter binaryWriter = default;
		CnxNativeMethods.BITMAPFILEHEADER bITMAPFILEHEADER = default;
		byte[] array = default;
		CnxNativeMethods.BITMAPINFO info = default;
		Size size = default;
		while (true)
		{
			switch (num)
			{
			case 12:
			{
				ReadPixels(array2, (int)vvNmm56pTLOICekWR1c(stm), format, Point.Empty, num2);
				Stream obj = stm;
				mGlXC060F2NtKjdvbfP(obj, vvNmm56pTLOICekWR1c(obj) + num3);
				num = 8;
				break;
			}
			case 13:
				binaryWriter = new BinaryWriter(stm);
				bITMAPFILEHEADER.Write(binaryWriter);
				num = 2;
				break;
			case 1:
				ReadPixels(array, 0, PixelFormat, Point.Empty, num2);
				num = 6;
				break;
			case 5:
				array2 = null;
				num = 7;
				break;
			case 2:
				info.Write(binaryWriter);
				num = 5;
				break;
			case 7:
				try
				{
					array2 = (byte[])U351KQ66D9Uj6SSAhqL((MemoryStream)stm);
				}
				catch (Exception ex)
				{
					ex.ToString();
				}
				num2 = size.Width * size.Height;
				goto case 14;
			default:
				num = 14;
				if (false)
				{
					return;
				}
				break;
			case 8:
				return;
			case 3:
			case 4:
				if (stm == null)
				{
					stm = new MemoryStream(new byte[bITMAPFILEHEADER.bfSize], 0, bITMAPFILEHEADER.bfSize, writable: true, publiclyVisible: true);
					num = 13;
					break;
				}
				goto case 13;
			case 10:
				size = Size;
				num = 15;
				if (0 == 0)
				{
					break;
				}
				goto case 15;
			case 15:
				info = new CnxNativeMethods.BITMAPINFO(new CnxVector2F(size.Width, size.Height), format, null);
				num = 0;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				binaryWriter.Write(array);
				num = 16;
				if (BYP0LL6thYgaxryl4Fv())
				{
					break;
				}
				goto case 0;
			case 0:
				bITMAPFILEHEADER = new CnxNativeMethods.BITMAPFILEHEADER(info);
				OkHVeL6COWqv7I9PJka();
				num = ((!BYP0LL6thYgaxryl4Fv()) ? 11 : 4);
				break;
			case 9:
			case 11:
				if (array2 == null)
				{
					array = new byte[num3];
					num = 1;
				}
				else
				{
					num = 12;
				}
				break;
			case 14:
				num3 = num2 * info.bmiHeader.biBitCount / 8;
				goto case 9;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Graphics GetGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (BYP0LL6thYgaxryl4Fv())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (OkHVeL6COWqv7I9PJka())
			{
				goto IL_00a9;
			}
		}
		goto IL_005d;
		IL_005d:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				YyckRABH3e = (Graphics)tpW7Lk64FghGUUuLgcf(GetDc());
				num = 2;
				continue;
			case 2:
				YyckRABH3e.InterpolationMode = InterpolationMode.NearestNeighbor;
				break;
			default:
				num = 5;
				continue;
			case 0:
			case 3:
				if (YyckRABH3e == null)
				{
					goto case 1;
				}
				goto case 6;
			case 5:
				break;
			case 6:
				return YyckRABH3e;
			}
			break;
		}
		goto IL_00a9;
		IL_00a9:
		G2gLgL6kSquWfpGiL2r(YyckRABH3e, SmoothingMode.None);
		num = 6;
		goto IL_005d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LBBGrl6K8hpW04H2v3V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxVector2 aAVfru65NT9BKD1TgnG(Size vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BYP0LL6thYgaxryl4Fv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OkHVeL6COWqv7I9PJka()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size Vgs6GR6oJS04lCy6c8b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr kU3SFJ6Pi0iTqGquFLt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Bitmap)P_0).GetHbitmap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr m0wkoI6Ybyl4be9RvRP(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateCompatibleDC(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr oW5RlO6NouMMbneHd7U(IntPtr hdc, IntPtr hgdiobj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectObject(hdc, hgdiobj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Bf5du06xcpWKfow2MeH(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, CnxNativeMethods.RasterOp dwRop)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.BitBlt(hdcDest, nXDest, nYDest, nWidth, nHeight, hdcSrc, nXSrc, nYSrc, dwRop);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MOyDMa61cipuxmDxgJG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rsB7dK6rAZj3apAkLsS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q6FpCc63u2DfduILfol(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oA0Bx46O5YXbbYtpQRl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr Hwpa166MdEmLy3NTrWu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferDib)P_0).GetDc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr CvgYr66QMsZIYoh9Yg3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferDib)P_0).Scan0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fpslhC6l60fiuRnhBbk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pyBdPG6exuSpEZegEnk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferDib)P_0).Stride;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat I8I6UG6ufhFNalfMYSh(CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsImageBufferFactory.GetImagingPixelFormat(format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PixelFormat jDo9iu6IJ0OHMJqE2HY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).PixelFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zGwmbe6RdspjbYmkXHk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Palette;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ThYS4Y6a4IRf7bkEYF2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ColorPalette)P_0).Entries;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color BBbLpR6nXEQPouq1vyk(int P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LZSiJ16GmjnoHaNe86R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferDib)P_0).GetNativeStorage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IlCFrC6XGFGFSJ5fNVq(IntPtr P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Image.FromHbitmap(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr BBB1J96bLpQshZ9qVFm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferDib)P_0).DetachHBitmap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U351KQ66D9Uj6SSAhqL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).GetBuffer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long vvNmm56pTLOICekWR1c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mGlXC060F2NtKjdvbfP(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tpW7Lk64FghGUUuLgcf(IntPtr P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Graphics.FromHdc(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G2gLgL6kSquWfpGiL2r(object P_0, SmoothingMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).SmoothingMode = P_1;
	}
}
