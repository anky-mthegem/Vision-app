using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cognex.Cnx.ComponentModel.Implementation;
using Cognex.Cnx.Diagnostics;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Imaging;
using Cognex.Cnx.Imaging.Implementation;
using Cognex.Cnx.Implementation;
using Cognex.Cnx.Serialization.Implementation;
using Cognex.Explorer.Diagnostics;
using Cognex.Extensions.Specialized;
using Cognex.InSight.Layout;
using Cognex.Utilities;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public abstract class CvsImageBufferBase : CnxReferenceCountBase, ICvsImageBuffer, IDisposable
{
	protected CvsClippingRegion mClip;

	protected Size mSize;

	protected readonly CnxPixelFormat mPixelFormat;

	protected CvsDrawMode mDrawMode;

	protected CvsFont mDefaultFont;

	private float u4EkdIkgjd;

	private byte[] E4Iku4dJIx;

	private bool DoxkGQokBs;

	private bool gH3kDH3JKf;

	private IntPtr uD8keK0x1J;

	private IntPtr bNukSbtbd1;

	private IntPtr AlAkrJSWoo;

	private IntPtr INnkCv5ieH;

	private bool fkSk2wIdM0;

	private Matrix WZNkyB8fo1;

	private IntPtr QgskVSfr6N;

	private IntPtr rSnkv4rw0f;

	private Color OGqkZylWD6;

	private int ddBk869ufk;

	private CvsDashStyles h0Wkzyl9F4;

	private IntPtr YKBXPZ19oa;

	private Color lrdXIuettF;

	private IntPtr HJYX1VtQqX;

	private IntPtr zgSXxuJYja;

	private Color Q0gXFqKc1l;

	private CnxNativeMethods.BkMode sAoXbdxta1;

	private Color CoUXafeElp;

	private byte[] Nw5XO2Y5QV;

	private int dmjXpOVsWZ;

	private static readonly Point vjkXh7B0ex;

	public CvsFont DefaultFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (mDefaultFont == null)
			{
				mDefaultFont = CvsFont.CreateInstance(new Font((string)WB1PfA6zOWF9gD8cRDJ(36622), 9f, FontStyle.Regular), canDisposeFontIfUnused: true);
			}
			return mDefaultFont;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mDefaultFont = value;
		}
	}

	public float FontScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u4EkdIkgjd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (value <= 0f)
			{
				throw new ArgumentOutOfRangeException(kgbOBx7BanbFa22Hp9.ol99ukmDA(43342));
			}
			u4EkdIkgjd = value;
		}
	}

	public Size Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mSize;
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
			return mPixelFormat;
		}
	}

	public bool PrintBuffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DoxkGQokBs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DoxkGQokBs = value;
		}
	}

	public CvsClippingRegion Clip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mClip;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tTQ2oS6fq1OmsPcd1gf();
			int num = (SgX2Q96FmNr0Z9PUqB3() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 5:
					l0lk6D5yKm();
					num = 6;
					break;
				case 1:
				case 2:
					mClip = value;
					num = 4;
					break;
				case 0:
				case 3:
					if (mClip != value)
					{
						goto case 1;
					}
					return;
				case 4:
					IfIEx9pVHZJsnk3eABc(this);
					goto case 5;
				default:
					num = 5;
					break;
				case 6:
					return;
				}
			}
		}
	}

	public CvsDrawMode DrawMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mDrawMode;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_00a4;
			IL_001a:
			CnxNativeMethods.SetROP2(uD8keK0x1J, (CnxNativeMethods.R2)mDrawMode);
			num = 6;
			goto IL_00a4;
			IL_00a4:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 4:
					mDrawMode = value;
					goto case 0;
				case 5:
					if (mDrawMode == value)
					{
						return;
					}
					SgX2Q96FmNr0Z9PUqB3();
					if (!tTQ2oS6fq1OmsPcd1gf())
					{
						num = 0;
						continue;
					}
					num = 4;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
					continue;
				case 0:
				case 2:
					if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
					{
						break;
					}
					return;
				default:
					num = 3;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	protected Type PixelArrayElementType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SgX2Q96FmNr0Z9PUqB3();
			int num = ((!tTQ2oS6fq1OmsPcd1gf()) ? 1 : 5);
			int pixelFormatSize = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					pixelFormatSize = GetPixelFormatSize(PixelFormat);
					num = 3;
					break;
				case 1:
				case 2:
					if (pixelFormatSize != 16)
					{
						goto case 4;
					}
					return Ggqhphpo4m6C74Zb79Z(typeof(short).TypeHandle);
				default:
					num = 4;
					break;
				case 3:
					if (pixelFormatSize != 8)
					{
						goto case 1;
					}
					return typeof(byte);
				case 4:
					if (pixelFormatSize != 32)
					{
						num = 6;
						break;
					}
					return Ggqhphpo4m6C74Zb79Z(typeof(int).TypeHandle);
				case 6:
					throw new ApplicationException((string)sRcgPEpPUgcUuNkwrYJ(WB1PfA6zOWF9gD8cRDJ(43418), PixelFormat.ToString()));
				}
			}
		}
	}

	protected bool IsFinalizing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gH3kDH3JKf;
		}
	}

	public Matrix Transform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WZNkyB8fo1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SgX2Q96FmNr0Z9PUqB3();
			int num;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0063;
			IL_0063:
			while (true)
			{
				switch (num)
				{
				case 3:
					goto IL_003c;
				case 0:
				case 1:
					WZNkyB8fo1 = value;
					num = 3;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_003c:
			if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
			{
				goto IL_002a;
			}
			return;
			IL_002a:
			AoGkiR3d6U();
			num = 5;
			if (false)
			{
				goto IL_003c;
			}
			goto IL_0063;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsImageBufferBase(Size size, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tTQ2oS6fq1OmsPcd1gf();
		int num;
		if (!SgX2Q96FmNr0Z9PUqB3())
		{
			num = 9;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0042;
		IL_00bf:
		mSize = size;
		goto IL_00eb;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 9:
				K8us196mGkb614VBtJi();
				num = 4;
				continue;
			case 4:
				mDrawMode = CvsDrawMode.Normal;
				num = 2;
				if (SgX2Q96FmNr0Z9PUqB3())
				{
				}
				continue;
			case 2:
				u4EkdIkgjd = 1f;
				num = 8;
				if (true)
				{
					continue;
				}
				goto IL_00bf;
			case 3:
				goto IL_00bf;
			case 8:
				WZNkyB8fo1 = new Matrix();
				num = 7;
				continue;
			case 1:
			case 6:
				goto IL_00eb;
			case 5:
				c8pks6hJdT();
				num = 10;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					continue;
				}
				return;
			case 10:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		base._002Ector();
		goto IL_00bf;
		IL_00eb:
		mPixelFormat = format;
		num = 5;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void c8pks6hJdT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OGqkZylWD6 = (lrdXIuettF = (Q0gXFqKc1l = (CoUXafeElp = Color.Empty)));
		sAoXbdxta1 = (CnxNativeMethods.BkMode)(-1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 13:
				if (WorvpX6ypt5Tjsj2oNO(INnkCv5ieH, IntPtr.Zero))
				{
					num = 11;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						break;
					}
				}
				goto case 1;
			case 1:
				Qhr0JN6gTB5ANumTGmf(bNukSbtbd1);
				_ = 0;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					num = 5;
					break;
				}
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 5:
			case 6:
				bNukSbtbd1 = IntPtr.Zero;
				goto default;
			case 12:
				INnkCv5ieH = IntPtr.Zero;
				num = 1;
				break;
			case 2:
				if (WorvpX6ypt5Tjsj2oNO(bNukSbtbd1, IntPtr.Zero))
				{
					num = 13;
					break;
				}
				goto default;
			case 4:
				mSize = Size.Empty;
				num = 2;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 11;
			case 11:
				CnxNativeMethods.SelectObject(bNukSbtbd1, INnkCv5ieH);
				num = 12;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					break;
				}
				goto case 10;
			case 10:
				ReleaseDc();
				base.Dispose(disposing);
				num = 8;
				break;
			case 8:
				if (disposing)
				{
					num = 9;
					break;
				}
				return;
			case 9:
				Atw7MJ6ZiWWJipVCU0v(this);
				num = 14;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					break;
				}
				goto default;
			default:
				if (WorvpX6ypt5Tjsj2oNO(AlAkrJSWoo, IntPtr.Zero))
				{
					CnxNativeMethods.DeleteBitmap(AlAkrJSWoo);
					num = 0;
					break;
				}
				goto case 10;
			case 0:
				AlAkrJSWoo = IntPtr.Zero;
				num = 10;
				break;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~CvsImageBufferBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			gH3kDH3JKf = true;
			AXVVdQ6J0cjUSvtr2MJ(this, false);
		}
		finally
		{
			base.Finalize();
		}
	}

	protected abstract IntPtr GetDcCore();

	protected abstract void ReleaseDcCore(IntPtr hdc);

	public abstract Graphics GetGraphics();

	public abstract void ReleaseGraphics();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected IntPtr GetDc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 2);
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (!juVZ5M688QZYJ52oreL(uD8keK0x1J, IntPtr.Zero))
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(43328));
				goto case 4;
			default:
				goto IL_0089;
			case 4:
				try
				{
					uD8keK0x1J = GetDcCore();
					_ = 1;
					int num2;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						num2 = 2;
						if (false)
						{
							goto IL_00b7;
						}
					}
					else
					{
						num2 = 5;
					}
					goto IL_0150;
					IL_0150:
					while (true)
					{
						switch (num2)
						{
						case 1:
						case 5:
							break;
						case 4:
							if (fkSk2wIdM0)
							{
								num2 = 3;
								if (true)
								{
									continue;
								}
								goto case 7;
							}
							goto case 8;
						case 7:
							if (Trgu8up97klrqUChHR4(WZNkyB8fo1))
							{
								num2 = 4;
								continue;
							}
							goto case 3;
						case 0:
						case 2:
							fI8G09ps1RgYrKkaS4o(uD8keK0x1J, CnxNativeMethods.GraphicsMode.GM_ADVANCED);
							break;
						case 3:
							AoGkiR3d6U();
							num2 = 8;
							continue;
						case 6:
							m2kUV0pLqyeumNuJisk(uD8keK0x1J, (CnxNativeMethods.R2)mDrawMode);
							goto case 7;
						default:
							num2 = 7;
							continue;
						case 8:
							l0lk6D5yKm();
							goto end_IL_0150;
						}
						goto IL_00b7;
						continue;
						end_IL_0150:
						break;
					}
					goto end_IL_0093;
					IL_00b7:
					ThULo1phlBDrDhQa0KH(uD8keK0x1J, 3);
					num2 = 6;
					goto IL_0150;
					end_IL_0093:;
				}
				finally
				{
					disposable?.Dispose();
				}
				break;
			}
			break;
			IL_0089:
			num = 4;
		}
		return uD8keK0x1J;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ReleaseDc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 0:
				YKBXPZ19oa = IntPtr.Zero;
				goto case 11;
			default:
				num = 11;
				break;
			case 10:
				c8pks6hJdT();
				num = 1;
				break;
			case 1:
				YYjDOTpHPHxmPy1ey70(this, uD8keK0x1J);
				num = 12;
				break;
			case 11:
				if (!(zgSXxuJYja != IntPtr.Zero))
				{
					goto case 10;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 9:
				h0Va95pSoyfTlHcHesl(GetDc(), rSnkv4rw0f);
				qCSvEEpEJNjE76SxED5(QgskVSfr6N);
				goto case 3;
			case 8:
				if (QgskVSfr6N != IntPtr.Zero)
				{
					tTQ2oS6fq1OmsPcd1gf();
					num = ((!SgX2Q96FmNr0Z9PUqB3()) ? 9 : 14);
					break;
				}
				goto case 5;
			case 13:
				HpRUE6pvcD95AUGIvpx(YKBXPZ19oa);
				num = 0;
				break;
			case 7:
				zgSXxuJYja = IntPtr.Zero;
				HJYX1VtQqX = IntPtr.Zero;
				num = 10;
				if (true)
				{
					break;
				}
				goto case 12;
			case 12:
				uD8keK0x1J = IntPtr.Zero;
				num = 15;
				break;
			case 5:
				if (!WorvpX6ypt5Tjsj2oNO(YKBXPZ19oa, IntPtr.Zero))
				{
					goto case 11;
				}
				num = 13;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
			case 14:
				QgskVSfr6N = (rSnkv4rw0f = IntPtr.Zero);
				num = 5;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					break;
				}
				goto case 6;
			case 6:
				if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
				{
					num = 8;
					break;
				}
				return;
			case 4:
				CnxNativeMethods.SelectObject(uD8keK0x1J, zgSXxuJYja);
				num = 7;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void l0lk6D5yKm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
				{
					num = 0;
					break;
				}
				return;
			case 0:
				if (mClip != null)
				{
					_ = 1;
					num = (SgX2Q96FmNr0Z9PUqB3() ? 1 : 5);
				}
				else
				{
					P9HynHpDuc1pAkvP4dP(uD8keK0x1J, IntPtr.Zero);
					num = 6;
				}
				break;
			default:
				return;
			case 1:
				return;
			case 2:
			case 5:
				P9HynHpDuc1pAkvP4dP(uD8keK0x1J, PvdqDZpADnHCwOpiH6j(mClip));
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetPixel(int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxColorConversion.GdiToColor(OkwUD9pUepV1mPZg7oh(GetDc(), x, y));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPixel(int x, int y, Color color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CnxNativeMethods.SetPixel(GetDc(), x, y, I1QdoJpTpC2nLcIokbN(color));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IntPtr GetMemoryPtr(bool write, out int stride, out CnxPixelFormat nativePixelFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		stride = 0;
		nativePixelFormat = CnxPixelFormat.Format8bppGrayscale;
		return IntPtr.Zero;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, CvsFont font, Color foreColor, Color backColor, Rectangle rect, CvsTextFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(43364));
		try
		{
			DrawStringInternal(s, font, foreColor, backColor, rect, format, symbols: false);
		}
		finally
		{
			if (disposable != null)
			{
				DvvSaopdYf9pBBI3dsW(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SizeF MeasureInSightString(string s, CvsFont font)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tTQ2oS6fq1OmsPcd1gf();
		int num;
		if (!SgX2Q96FmNr0Z9PUqB3())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_004a;
		IL_0092:
		SizeF result = default;
		result.Width += MeasureString(s, font).Width;
		num = 5;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				result = new SizeF(0f, 0f);
				num = 3;
				continue;
			default:
				goto IL_0092;
			case 5:
				return result;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		result.Height = font.MaxFontHeight;
		goto IL_0092;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawImage(CvsImage image, Rectangle destRect, Rectangle sourceRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawImage(image.Buffer, destRect, sourceRect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawImage(Bitmap bmp, Point dest)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsImageBuffer cvsImageBuffer = new CvsImageBuffer(bmp, PixelFormat);
		DrawImageTransparent(cvsImageBuffer, new Rectangle(dest.X, dest.Y, cvsImageBuffer.Size.Width, QUmH0apiKKK4H16JaTu(cvsImageBuffer).Height), new Rectangle(0, 0, QUmH0apiKKK4H16JaTu(cvsImageBuffer).Width, QUmH0apiKKK4H16JaTu(cvsImageBuffer).Height), sUuCI1pqKSFjSxPV078());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SizeF MeasureString(string s)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MeasureString(s, DefaultFont, symbols: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SizeF MeasureString(string s, CvsFont font)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MeasureString(s, font, symbols: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawLine(Color color, int x1, int y1, int x2, int y2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawLine(color, x1, y1, x2, y2, 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawLine(Color color, int x1, int y1, int x2, int y2, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawLine(color, x1, y1, x2, y2, lineWidth, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawLines(Color color, Point[] points, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawLines(color, points, lineWidth, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawRectangle(Color color, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawRectangle(color, rect.X, rect.Y, rect.Width, rect.Height, 1, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawRectangle(Color color, int x, int y, int width, int height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawRectangle(color, x, y, width, height, 1, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawRectangle(Color color, int x, int y, int width, int height, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawRectangle(color, x, y, width, height, lineWidth, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw3DRectangle(Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Draw3DRectangle(qnq5AIpBqEy6Q3irZeX(), SystemColors.ControlLight, rp8uD8pjUS9Hn14mCIj(), c6JmwUpcoS5x9k6imjs(), i9Uoflp2Cws3m2X4Gq7(), rect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw3DRectangle(Color fillColor, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Draw3DRectangle(fillColor, LY9IXFpWJn5UQWi82I9(), rp8uD8pjUS9Hn14mCIj(), SystemColors.ControlDark, i9Uoflp2Cws3m2X4Gq7(), rect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw3DRectangle(Color fillColor, Color lightColor, Color lightLightColor, Color darkColor, Color darkDarkColor, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, kgbOBx7BanbFa22Hp9.ol99ukmDA(43388));
		try
		{
			int num;
			if (fillColor != Color.Empty)
			{
				num = 0;
				goto IL_0184;
			}
			goto IL_01d1;
			IL_01d1:
			DrawLine(lightLightColor, rect.X + 1, rect.Bottom - 3, rect.X + 1, rect.Y + 1);
			num = 2;
			goto IL_0184;
			IL_0184:
			while (true)
			{
				switch (num)
				{
				case 4:
				case 6:
					DrawLine(darkColor, rect.Right - 2, rect.Bottom - 2, rect.Right - 2, rect.Y);
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					DrawLine(lightLightColor, rect.X + 1, rect.Y + 1, rect.Right - 1, rect.Y + 1);
					num = 5;
					continue;
				case 3:
					DrawLine(lightColor, rect.X, rect.Y, rect.Right - 1, rect.Y);
					goto case 1;
				case 9:
					DrawLine(lightColor, rect.X, rect.Bottom - 2, rect.X, rect.Y);
					num = 3;
					continue;
				case 1:
				case 7:
					DrawLine(darkDarkColor, rect.X, rect.Bottom - 1, rect.Right - 1, rect.Bottom - 1);
					num = 10;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					goto case 5;
				case 5:
					DrawLine(darkColor, rect.X + 1, rect.Bottom - 2, rect.Right - 2, rect.Bottom - 2);
					goto default;
				default:
					SgX2Q96FmNr0Z9PUqB3();
					if (!tTQ2oS6fq1OmsPcd1gf())
					{
						num = 1;
						continue;
					}
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					break;
				case 0:
					FillRectangle(fillColor, new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4));
					num = 8;
					continue;
				case 10:
					DrawLine(darkDarkColor, rect.Right - 1, rect.Bottom - 1, rect.Right - 1, rect.Y + 1);
					return;
				}
				break;
			}
			goto IL_01d1;
		}
		finally
		{
			if (disposable != null)
			{
				DvvSaopdYf9pBBI3dsW(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawArc(color, cx, cy, radius, startAngle, sweepAngle, 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, Color foreColor, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, DefaultFont, foreColor, Color.Empty, new Rectangle(x, y, Size.Width - x, Size.Height - y), CvsTextFormat.Top);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, Color foreColor, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, DefaultFont, foreColor, Color.Empty, rect, CvsTextFormat.Top);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, Color foreColor, Color backColor, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, DefaultFont, foreColor, backColor, rect, CvsTextFormat.Top);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, Color foreColor, Color backColor, Rectangle rect, CvsTextFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, DefaultFont, foreColor, backColor, rect, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, CvsFont font, Color foreColor, Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, font, foreColor, Color.Empty, rect, CvsTextFormat.Top);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawString(string s, CvsFont font, Color foreColor, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawString(s, font, foreColor, Color.Empty, new Rectangle(x, y, Size.Width - x, Size.Height - y), CvsTextFormat.Top);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPolygon(Color color, Point[] points, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawPolygon(color, points, lineWidth, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPolygon(Color color, Point[] points)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawPolygon(color, points, 1, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float BfhkHANIrL(int P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tTQ2oS6fq1OmsPcd1gf();
		int num = (SgX2Q96FmNr0Z9PUqB3() ? 2 : 3);
		float num3 = default;
		while (true)
		{
			float num2;
			switch (num)
			{
			case 4:
				num3++;
				num = 5;
				if (SgX2Q96FmNr0Z9PUqB3())
				{
				}
				continue;
			case 1:
			case 2:
				num2 = 3f;
				goto IL_0053;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				if (P_1)
				{
					num2 = 4f;
					goto IL_0053;
				}
				goto case 1;
			case 5:
				break;
				IL_0053:
				num3 = num2;
				if (P_0 >= 2)
				{
					break;
				}
				goto case 4;
			}
			break;
		}
		return num3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawArrow(Color color, float x, float y, double angle, int lineWidth, bool large)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!tTQ2oS6fq1OmsPcd1gf())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_007d:
		float num2 = G1Wsqsp7BtNuk8RfX6t(lineWidth, large) * (float)lineWidth;
		tTQ2oS6fq1OmsPcd1gf();
		if (SgX2Q96FmNr0Z9PUqB3())
		{
			num = 0;
			if (SgX2Q96FmNr0Z9PUqB3())
			{
				goto IL_006a;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00a7;
			}
		}
		goto IL_0037;
		IL_00a7:
		Graphics graphics = default;
		SmoothingMode smoothingMode = default;
		try
		{
			ouJaSqpK4X72DH6fyPQ(graphics, SmoothingMode.AntiAlias);
			Txn4njp5xneRbFM6VBx(graphics, color, x, y, angle, num2);
			return;
		}
		finally
		{
			ouJaSqpK4X72DH6fyPQ(graphics, smoothingMode);
			ReleaseGraphics();
		}
		IL_0037:
		switch (num)
		{
		case 1:
		case 3:
			break;
		default:
			goto IL_006a;
		case 4:
			goto IL_007d;
		case 5:
			goto IL_00a7;
		}
		goto IL_001e;
		IL_001e:
		graphics = (Graphics)HDa6Hrptht09HXmA6ts(this);
		goto IL_006a;
		IL_006a:
		smoothingMode = sX6BwapCB7QbFKOXqIN(graphics);
		num = 5;
		if (true)
		{
			goto IL_0037;
		}
		goto IL_007d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Array GetPixels(int dimensions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		Array array = default;
		Size size = default;
		while (true)
		{
			switch (num)
			{
			default:
				array = new short[size.Width * Size.Height];
				goto case 3;
			case 5:
			{
				int width = size.Width;
				size = Size;
				array = new short[width, size.Height];
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 7;
			}
			case 7:
			{
				int width2 = size.Width;
				size = Size;
				array = new int[width2 * size.Height];
				num = 3;
				continue;
			}
			case 15:
			{
				int width6 = size.Width;
				size = Size;
				array = new byte[width6 * size.Height];
				num = 17;
				if (true)
				{
					continue;
				}
				goto case 10;
			}
			case 10:
				throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(43472), kgbOBx7BanbFa22Hp9.ol99ukmDA(43578));
			case 8:
				size = Size;
				goto default;
			case 13:
			{
				int width5 = size.Width;
				size = Size;
				array = new int[width5, size.Height];
				num = 16;
				continue;
			}
			case 11:
				size = Size;
				num = 15;
				continue;
			case 1:
			case 6:
				if (dimensions != 2)
				{
					num = 10;
					continue;
				}
				goto IL_0128;
			case 3:
			case 4:
			case 14:
			case 16:
			case 17:
			{
				Array pixels = array;
				CnxPixelFormat rawPixelFormat = mPixelFormat;
				Point location = new Point(0, 0);
				int width4 = Size.Width;
				size = Size;
				ReadPixels(pixels, 0, rawPixelFormat, location, width4 * size.Height);
				num = 18;
				continue;
			}
			case 12:
			{
				int width3 = size.Width;
				size = Size;
				array = new byte[width3, size.Height];
				num = 4;
				continue;
			}
			case 2:
				if (dimensions != 1)
				{
					SgX2Q96FmNr0Z9PUqB3();
					if (!tTQ2oS6fq1OmsPcd1gf())
					{
						num = 0;
						continue;
					}
					num = 6;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					break;
				}
				goto IL_0128;
			case 18:
				break;
				IL_0128:
				if (!(PixelArrayElementType == Ggqhphpo4m6C74Zb79Z(typeof(byte).TypeHandle)))
				{
					if (!lHucy9pYWIlyystJnPq(PixelArrayElementType, Ggqhphpo4m6C74Zb79Z(typeof(byte).TypeHandle)))
					{
						if (dimensions == 1)
						{
							size = Size;
							num = 7;
							if (0 == 0)
							{
								continue;
							}
							goto case 3;
						}
						size = Size;
						num = 13;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					if (dimensions != 1)
					{
						size = Size;
						num = 5;
					}
					else
					{
						num = 8;
					}
					continue;
				}
				if (dimensions == 1)
				{
					num = 11;
					continue;
				}
				size = Size;
				num = 12;
				continue;
			}
			break;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void ReplacePixels(Rectangle rect, Color colorMatch, Color colorReplace)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		int num4 = default;
		int num3 = default;
		Color color = default;
		int num2 = default;
		int num5 = default;
		CnxPixelFormat nativePixelFormat = default;
		int* ptr2 = default;
		int stride = default;
		IntPtr memoryPtr = default;
		int num8 = default;
		int* ptr = default;
		int num7 = default;
		while (true)
		{
			switch (num)
			{
			default:
				num = 6;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 2;
			case 2:
				num4 = colorReplace.ToArgb();
				num = 0;
				break;
			case 11:
				num3++;
				num = 13;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 13;
			case 13:
				if (num3 < rect.Right)
				{
					color = lqRuYppNwn7liCeBCYW(this, num3, num2);
					goto case 6;
				}
				num = 9;
				break;
			case 12:
				num5 = colorMatch.ToArgb();
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
			case 7:
				try
				{
					if (nativePixelFormat == CnxPixelFormat.Format32bppRgb)
					{
						int num6 = 13;
						if (!SgX2Q96FmNr0Z9PUqB3())
						{
						}
						while (true)
						{
							switch (num6)
							{
							case 2:
								ptr2 += stride;
								_ = 0;
								num6 = (tTQ2oS6fq1OmsPcd1gf() ? 1 : 6);
								break;
							case 9:
								ptr2 = (int*)((byte*)memoryPtr.ToPointer() + (nint)(rect.Y * stride) * (nint)4) + rect.X;
								num6 = 12;
								break;
							case 3:
							case 6:
							case 11:
								if (num8 <= 0)
								{
									num6 = 14;
									break;
								}
								ptr = ptr2;
								num7 = rect.Width;
								goto case 0;
							case 1:
							case 10:
								num8--;
								goto case 3;
							case 7:
								ptr++;
								num6 = 5;
								break;
							case 0:
								if (num7 > 0)
								{
									if ((*ptr & 0xFFFFFF) == num5)
									{
										num6 = 4;
										break;
									}
									goto case 7;
								}
								num6 = 2;
								break;
							case 13:
								num5 &= 0xFFFFFF;
								num6 = 8;
								break;
							case 8:
								stride /= 4;
								num6 = 9;
								break;
							case 12:
								num8 = rect.Height;
								num6 = 3;
								break;
							case 4:
								*ptr = num4;
								goto case 7;
							default:
								num6 = 7;
								break;
							case 5:
								num7--;
								num6 = 0;
								if (false)
								{
									return;
								}
								break;
							case 14:
								return;
							}
						}
					}
				}
				finally
				{
					ReleaseMemoryPtr();
				}
				goto IL_0284;
			case 1:
				memoryPtr = GetMemoryPtr(write: true, out stride, out nativePixelFormat);
				_ = 1;
				num = (SgX2Q96FmNr0Z9PUqB3() ? 7 : 3);
				break;
			case 0:
				rect.Intersect(new Rectangle(Point.Empty, Size));
				num = 1;
				break;
			case 9:
				num2++;
				num = 8;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					break;
				}
				goto case 6;
			case 6:
				if (color.ToArgb() == num5)
				{
					F1PBgRpxeJoqq6rmEtr(this, num3, num2, colorReplace);
					num = 11;
					break;
				}
				goto case 11;
			case 8:
			case 10:
				if (num2 < rect.Bottom)
				{
					num3 = rect.Left;
					goto case 13;
				}
				num = 14;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
			case 4:
				if (WorvpX6ypt5Tjsj2oNO(memoryPtr, IntPtr.Zero))
				{
					goto case 5;
				}
				goto IL_0284;
			case 14:
				return;
				IL_0284:
				num2 = rect.Top;
				num = 10;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void ReplaceGrayValues(Rectangle rect, Color[] colors)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		Color color = default;
		byte b6 = default;
		int num3 = default;
		int num2 = default;
		CnxPixelFormat nativePixelFormat = default;
		int stride = default;
		int* ptr = default;
		int num7 = default;
		int num6 = default;
		int* ptr2 = default;
		byte b2 = default;
		byte b3 = default;
		byte b4 = default;
		int* ptr3 = default;
		byte b = default;
		IntPtr memoryPtr = default;
		int num5 = default;
		byte b5 = default;
		byte val = default;
		byte val2 = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				color = colors[b6];
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (num3 >= rect.Bottom)
				{
					num = 16;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
				}
				num2 = rect.Left;
				num = 13;
				if (SgX2Q96FmNr0Z9PUqB3())
				{
				}
				continue;
			case 10:
				num2++;
				num = 4;
				continue;
			case 3:
			case 14:
				try
				{
					if (nativePixelFormat == CnxPixelFormat.Format32bppRgb)
					{
						int[] array = new int[256];
						for (int i = 0; i < 256; i++)
						{
							if (!colors[i].IsEmpty)
							{
								array[i] = colors[i].ToArgb() & 0xFFFFFF;
							}
							else
							{
								array[i] = -1;
							}
						}
						stride /= 4;
						try
						{
							fixed (int[] array2 = array)
							{
								int num4;
								if (array != null)
								{
									num4 = 7;
									goto IL_0273;
								}
								goto IL_02c8;
								IL_02c8:
								ptr = null;
								num4 = 0;
								goto IL_0273;
								IL_0273:
								while (true)
								{
									switch (num4)
									{
									case 11:
										if (num7 < 0)
										{
											goto IL_01f6;
										}
										num4 = 13;
										if (tTQ2oS6fq1OmsPcd1gf())
										{
											continue;
										}
										goto case 5;
									case 3:
									case 8:
									case 12:
										if (num6 > 0)
										{
											int num8 = *ptr2;
											b2 = (byte)(num8 >> 16);
											b3 = (byte)(num8 >> 8);
											b4 = (byte)num8;
											num4 = 9;
										}
										else
										{
											ptr3 += stride;
											num4 = 4;
										}
										continue;
									case 6:
										num7 = ptr[(int)b];
										num4 = 11;
										continue;
									case 0:
									case 14:
										ptr3 = (int*)((byte*)memoryPtr.ToPointer() + (nint)(rect.Y * stride) * (nint)4) + rect.X;
										num4 = 2;
										continue;
									case 13:
										*ptr2 = num7;
										goto IL_01f6;
									case 7:
										if (array2.Length != 0)
										{
											ptr = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]);
											num4 = 14;
										}
										else
										{
											_ = 1;
											num4 = ((!SgX2Q96FmNr0Z9PUqB3()) ? 15 : 8);
										}
										continue;
									case 2:
										num5 = rect.Height;
										num4 = 5;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									case 4:
										num5--;
										num4 = 16;
										if (0 == 0)
										{
											continue;
										}
										goto case 10;
									case 10:
										num6 = rect.Width;
										goto case 3;
									default:
										num4 = 3;
										if (0 == 0)
										{
											continue;
										}
										break;
									case 1:
									case 15:
										break;
									case 9:
										b = DHttTep1PNYq3TZit8X(b2, DHttTep1PNYq3TZit8X(b3, b4));
										num4 = 6;
										continue;
									case 5:
									case 16:
										{
											if (num5 > 0)
											{
												ptr2 = ptr3;
												num4 = 10;
												if (!SgX2Q96FmNr0Z9PUqB3())
												{
													continue;
												}
												goto case 3;
											}
											return;
										}
										IL_01f6:
										ptr2++;
										num6--;
										goto case 3;
									}
									break;
								}
								goto IL_02c8;
							}
						}
						finally
						{
							array2 = null;
						}
					}
				}
				finally
				{
					FDZGBhprrhpNqqY1RNg(this);
				}
				goto IL_030f;
			case 1:
				((ICvsImageBuffer)this).SetPixel(num2, num3, color);
				num = 10;
				continue;
			case 5:
				if (!color.IsEmpty)
				{
					num = 1;
					continue;
				}
				goto case 10;
			case 6:
				throw new ArgumentNullException((string)WB1PfA6zOWF9gD8cRDJ(43602));
			case 7:
				b6 = DHttTep1PNYq3TZit8X(b5, Math.Max(val, val2));
				num = 9;
				continue;
			case 11:
				memoryPtr = GetMemoryPtr(write: true, out stride, out nativePixelFormat);
				if (WorvpX6ypt5Tjsj2oNO(memoryPtr, IntPtr.Zero))
				{
					tTQ2oS6fq1OmsPcd1gf();
					num = (SgX2Q96FmNr0Z9PUqB3() ? 8 : 14);
					continue;
				}
				goto IL_030f;
			case 4:
			case 13:
				if (num2 < rect.Right)
				{
					int num9 = lqRuYppNwn7liCeBCYW(this, num2, num3).ToArgb();
					b5 = (byte)(num9 >> 16);
					val = (byte)(num9 >> 8);
					val2 = (byte)num9;
					num = 7;
					continue;
				}
				break;
			case 15:
				if (colors != null)
				{
					if (colors.Length != 256)
					{
						throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(43618), (string)WB1PfA6zOWF9gD8cRDJ(43602));
					}
					rect.Intersect(new Rectangle(Point.Empty, Size));
					num = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 6;
				continue;
			case 8:
			case 12:
				break;
			case 16:
				return;
				IL_030f:
				num3 = rect.Top;
				num = 2;
				continue;
			}
			num3++;
			num = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadPixels(Array pixels, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CopyPixels(pixels, startIndex, rawPixelFormat, location, pixelCount, write: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WritePixels(Array pixels, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CopyPixels(pixels, startIndex, rawPixelFormat, location, pixelCount, write: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadPixels(IntPtr pixels, CnxPixelFormat rawPixelFormat, Point location, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CopyPixels(pixels, rawPixelFormat, location, pixelCount, write: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WritePixels(IntPtr pixels, CnxPixelFormat rawPixelFormat, Point location, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CopyPixels(pixels, rawPixelFormat, location, pixelCount, write: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void StreamPixels(Stream stream, bool readFromStream, CnxPixelFormat streamPixelFormat, Rectangle region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 18;
		if (false)
		{
			goto IL_0074;
		}
		goto IL_01b7;
		IL_0074:
		Point location = default;
		location.Y++;
		goto IL_0087;
		IL_01b7:
		int num2 = default;
		IntPtr memoryPtr = default;
		int stride = default;
		CnxPixelFormat nativePixelFormat = default;
		int num4 = default;
		int num7 = default;
		int num6 = default;
		byte* ptr2 = default;
		while (true)
		{
			switch (num)
			{
			case 15:
				jT0pjDplwO0CfBGvCBh(stream, E4Iku4dJIx, 0, num2);
				num = 3;
				continue;
			case 4:
				if (readFromStream && region.X == 0)
				{
					num = 5;
					continue;
				}
				goto IL_03cc;
			case 3:
			case 12:
				break;
			case 16:
				memoryPtr = GetMemoryPtr(write: true, out stride, out nativePixelFormat);
				num = 14;
				continue;
			case 2:
				num4 = num2 * region.Height;
				num = 4;
				continue;
			case 10:
			case 17:
				num7 = num2;
				goto case 6;
			case 7:
				if (num6 < 1)
				{
					throw new EndOfStreamException((string)WB1PfA6zOWF9gD8cRDJ(43722));
				}
				num7 -= num6;
				if (num7 <= 0)
				{
					num = 9;
					continue;
				}
				goto case 6;
			case 14:
				if (WorvpX6ypt5Tjsj2oNO(memoryPtr, IntPtr.Zero))
				{
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 5;
				}
				goto IL_03cc;
			case 5:
				if (region.Width == mSize.Width)
				{
					num = 16;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
					continue;
				}
				goto IL_03cc;
			case 9:
				WritePixels(E4Iku4dJIx, 0, streamPixelFormat, location, region.Width);
				num = 12;
				continue;
			case 18:
				num2 = GetPixelFormatSize(streamPixelFormat) / 8 * region.Width;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				E4Iku4dJIx = new byte[num2];
				goto case 0;
			default:
				num = 0;
				continue;
			case 8:
				try
				{
					if (stride == Size.Width * GetPixelFormatSize(nativePixelFormat) / 8)
					{
						byte* ptr = (byte*)memoryPtr.ToPointer() + region.Y * stride;
						if (nativePixelFormat == streamPixelFormat)
						{
							if (stream is ICnxDirectMemoryStream cnxDirectMemoryStream)
							{
								while (true)
								{
									int num3 = cnxDirectMemoryStream.Read(new IntPtr(ptr), num4);
									num4 -= num3;
									if (num4 == 0)
									{
										break;
									}
									ptr += num3;
								}
								return;
							}
							if (stream is MemoryStream memoryStream)
							{
								try
								{
									byte[] array = (byte[])cfs0I0p3N2LS3iF9TLf(memoryStream);
									if ((int)memoryStream.Length - (int)eaAuqWpOH4SaaskaNkf(memoryStream) >= num4)
									{
										try
										{
											fixed (byte[] array2 = array)
											{
												if (array == null)
												{
													goto IL_02d7;
												}
												int num5 = 0;
												if (SgX2Q96FmNr0Z9PUqB3())
												{
												}
												goto IL_02ed;
												IL_030e:
												_ = 1;
												if (!SgX2Q96FmNr0Z9PUqB3())
												{
													num5 = 4;
												}
												else
												{
													num5 = 1;
													if (SgX2Q96FmNr0Z9PUqB3())
													{
													}
												}
												goto IL_02ed;
												IL_02ed:
												while (true)
												{
													switch (num5)
													{
													case 5:
														break;
													default:
														goto IL_030e;
													case 0:
														if (array2.Length == 0)
														{
															num5 = 5;
															continue;
														}
														ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array2[0]);
														goto case 1;
													case 1:
													case 2:
													case 3:
													case 4:
														do
														{
															ConvertPixels(new IntPtr(ptr), nativePixelFormat, new IntPtr(ptr2 + (int)eaAuqWpOH4SaaskaNkf(stream)), streamPixelFormat, region.Width * region.Height);
															num5 = 6;
														}
														while (SgX2Q96FmNr0Z9PUqB3());
														continue;
													case 6:
														oGr4JxpM8NbuHqsWNYu(stream, eaAuqWpOH4SaaskaNkf(stream) + num4);
														return;
													}
													break;
												}
												goto IL_02d7;
												IL_02d7:
												ptr2 = null;
												goto IL_030e;
											}
										}
										finally
										{
											array2 = null;
										}
									}
								}
								catch (UnauthorizedAccessException)
								{
								}
							}
						}
					}
				}
				finally
				{
					FDZGBhprrhpNqqY1RNg(this);
				}
				goto IL_03cc;
			case 1:
				if (E4Iku4dJIx.Length < num2)
				{
					num = 13;
					continue;
				}
				goto case 0;
			case 6:
			case 11:
				num6 = eGSAEdpQhFvqapiw8vG(stream, E4Iku4dJIx, num2 - num7, num7);
				num = 7;
				continue;
			case 0:
				location = region.Location;
				goto IL_0087;
			case 19:
				return;
				IL_03cc:
				if (E4Iku4dJIx != null)
				{
					num = 1;
					continue;
				}
				goto case 13;
			}
			break;
		}
		goto IL_0074;
		IL_0087:
		if (location.Y >= region.Bottom)
		{
			num = 19;
		}
		else if (!readFromStream)
		{
			ReadPixels(E4Iku4dJIx, 0, streamPixelFormat, location, region.Width);
			num = 15;
		}
		else
		{
			_ = 0;
			num = (tTQ2oS6fq1OmsPcd1gf() ? 17 : 6);
		}
		goto IL_01b7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CopyPixels(Array pixels, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount, bool write)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (!SgX2Q96FmNr0Z9PUqB3())
		{
		}
		int num3 = default;
		int num2 = default;
		GCHandle gCHandle = default;
		Type elementType = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 = 2;
				SgX2Q96FmNr0Z9PUqB3();
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					num = 10;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 4:
				num3 = 1;
				num = 1;
				continue;
			case 0:
			case 7:
				num3 = 4;
				goto case 1;
			case 1:
			case 6:
			case 10:
				if ((MMRgNrpuOTgjEENtKew(pixels) - startIndex) * num3 < pixelCount * num2)
				{
					num = 9;
					continue;
				}
				gCHandle = T1qMOZpIvjkfdWBC4Q2(pixels, GCHandleType.Pinned);
				num = 11;
				continue;
			case 3:
				if (elementType == Ggqhphpo4m6C74Zb79Z(typeof(byte).TypeHandle))
				{
					num = 4;
					continue;
				}
				if (lHucy9pYWIlyystJnPq(elementType, Ggqhphpo4m6C74Zb79Z(typeof(short).TypeHandle)))
				{
					goto case 2;
				}
				if (!lHucy9pYWIlyystJnPq(elementType, Ggqhphpo4m6C74Zb79Z(typeof(int).TypeHandle)))
				{
					throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(43806), (string)WB1PfA6zOWF9gD8cRDJ(43914));
				}
				goto case 0;
			case 8:
				num2 = Mw7Jafpe9wUbKA2j3jp(rawPixelFormat) / 8;
				num = 5;
				continue;
			case 9:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(43930), (string)WB1PfA6zOWF9gD8cRDJ(43914));
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				elementType = pixels.GetType().GetElementType();
				num = 3;
				continue;
			case 11:
				break;
			}
			break;
		}
		try
		{
			IntPtr pixels2 = new IntPtr(gCHandle.AddrOfPinnedObject().ToInt32() + startIndex * num3);
			CopyPixels(pixels2, rawPixelFormat, location, pixelCount, write);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CopyPixels(IntPtr pixels, CnxPixelFormat rawPixelFormat, Point location, int pixelCount, bool write)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (tTQ2oS6fq1OmsPcd1gf())
		{
			num = 3;
			if (!tTQ2oS6fq1OmsPcd1gf())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0045;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0045;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0089;
			case 4:
				goto IL_0089;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		int num2 = Mw7Jafpe9wUbKA2j3jp(rawPixelFormat) / 8;
		goto IL_0045;
		IL_0045:
		int stride = default;
		CnxPixelFormat nativePixelFormat = default;
		IntPtr memoryPtr = GetMemoryPtr(write, out stride, out nativePixelFormat);
		goto IL_0089;
		IL_0089:
		try
		{
			int num3 = Mw7Jafpe9wUbKA2j3jp(nativePixelFormat) / 8;
			_ = 1;
			int num4;
			if (!SgX2Q96FmNr0Z9PUqB3())
			{
				num4 = 3;
				if (1 == 0)
				{
					goto IL_00ab;
				}
			}
			else
			{
				num4 = 4;
			}
			goto IL_01d0;
			IL_01d0:
			int num5 = default;
			int num6 = default;
			IntPtr intPtr2 = default;
			int num8 = default;
			Size size = default;
			while (true)
			{
				switch (num4)
				{
				case 2:
				case 15:
					break;
				case 9:
				{
					IntPtr intPtr = new IntPtr(memoryPtr.ToInt32() + (num5 * num3 + num6 * stride));
					if (write)
					{
						N6VYQRpR5Ra5XZKyomh(intPtr, nativePixelFormat, pixels, rawPixelFormat, pixelCount);
						num4 = 6;
						continue;
					}
					N6VYQRpR5Ra5XZKyomh(pixels, rawPixelFormat, intPtr, nativePixelFormat, pixelCount);
					num4 = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				}
				case 12:
					ConvertPixels(intPtr2, nativePixelFormat, pixels, rawPixelFormat, num8);
					num4 = 15;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				case 5:
					num8 = rmesqupaNa4jAvubDR7(size.Width - num5, pixelCount);
					if (write)
					{
						num4 = 12;
						continue;
					}
					N6VYQRpR5Ra5XZKyomh(pixels, rawPixelFormat, intPtr2, nativePixelFormat, num8);
					num4 = 2;
					continue;
				case 1:
					return;
				case 7:
					num5 = 0;
					num4 = 10;
					continue;
				case 14:
				{
					int num7 = stride;
					size = Size;
					if (num7 == size.Width * num3)
					{
						num4 = 9;
						if (true)
						{
							continue;
						}
						goto case 8;
					}
					goto case 16;
				}
				case 8:
					size = Size;
					goto case 5;
				default:
					num4 = 5;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					goto IL_0229;
				case 4:
				case 11:
					goto IL_0229;
				case 10:
					num6++;
					num4 = 16;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
					continue;
				case 0:
				case 3:
					num5 = location.X;
					num4 = 13;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						continue;
					}
					goto case 13;
				case 13:
					num6 = location.Y;
					num4 = 14;
					continue;
				case 16:
					if (pixelCount > 0)
					{
						intPtr2 = new IntPtr(memoryPtr.ToInt32() + (num5 * num3 + num6 * stride));
						num4 = 8;
						continue;
					}
					return;
				}
				break;
			}
			goto IL_00ab;
			IL_0229:
			pixelCount -= num8;
			num4 = 7;
			goto IL_01d0;
			IL_00ab:
			pixels = new IntPtr(pixels.ToInt32() + num8 * num2);
			goto IL_0229;
		}
		finally
		{
			ReleaseMemoryPtr();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CopyFrom(ICvsImageBuffer other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 2);
		IntPtr destination = default;
		int stride = default;
		CnxPixelFormat nativePixelFormat = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (lcDhLRpG7Q7ycaKTYMd(Size, gBZ3ZCpnQefOfmuyIm0(other)))
				{
					goto case 1;
				}
				destination = GetMemoryPtr(write: true, out stride, out nativePixelFormat);
				break;
			case 1:
			case 3:
				throw new InvalidOperationException(kgbOBx7BanbFa22Hp9.ol99ukmDA(44040));
			default:
				goto IL_0092;
			case 4:
				break;
			}
			break;
			IL_0092:
			num = 4;
		}
		try
		{
			IntPtr source = ((CvsImageBufferBase)other).GetMemoryPtr(write: false, out var stride2, out var nativePixelFormat2);
			try
			{
				int num2 = 0;
				while (num2 < Size.Height)
				{
					N6VYQRpR5Ra5XZKyomh(destination, nativePixelFormat, source, nativePixelFormat2, Size.Width);
					tTQ2oS6fq1OmsPcd1gf();
					int num3 = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 2);
					while (true)
					{
						switch (num3)
						{
						case 1:
						case 3:
							source = new IntPtr(source.ToInt64() + stride2);
							goto case 4;
						default:
							num3 = 4;
							if (tTQ2oS6fq1OmsPcd1gf())
							{
								continue;
							}
							goto case 0;
						case 0:
						case 2:
							destination = new IntPtr(destination.ToInt64() + stride);
							goto case 1;
						case 4:
							num2++;
							num3 = 5;
							continue;
						case 5:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				FDZGBhprrhpNqqY1RNg((CvsImageBufferBase)other);
			}
		}
		finally
		{
			FDZGBhprrhpNqqY1RNg(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe static void ConvertPixels(IntPtr destination, CnxPixelFormat destinationFormat, IntPtr source, CnxPixelFormat sourceFormat, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 22;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_04e1;
		IL_04e1:
		int* ptr7 = default;
		int num15 = default;
		bool flag = default;
		short* dest = default;
		short num6 = default;
		int num8 = default;
		int num7 = default;
		int* ptr5 = default;
		int num4 = default;
		byte b = default;
		int num13 = default;
		int num18 = default;
		int num17 = default;
		int num2 = default;
		int num14 = default;
		byte b2 = default;
		int num16 = default;
		byte* ptr6 = default;
		short num3 = default;
		int num12 = default;
		short* ptr4 = default;
		byte b4 = default;
		int num10 = default;
		short num9 = default;
		byte* ptr3 = default;
		int num5 = default;
		short* ptr = default;
		short* ptr8 = default;
		int* ptr9 = default;
		byte* ptr10;
		byte* ptr11 = default;
		int num19 = default;
		int num20 = default;
		int* ptr13 = default;
		byte b5 = default;
		byte* source2 = default;
		byte b6 = default;
		while (true)
		{
			byte* ptr2;
			switch (num)
			{
			case 8:
			case 23:
				break;
			case 40:
				goto IL_00e7;
			case 16:
				goto IL_011e;
			case 24:
				*(ptr7++) = num15;
				num = 32;
				continue;
			case 11:
				flag = true;
				num = 63;
				continue;
			case 36:
				*(dest++) = num6;
				num8--;
				goto case 46;
			case 46:
				if (num8 <= 0)
				{
					flag = true;
					num = 20;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						continue;
					}
					goto IL_073d;
				}
				num7 = *(ptr5++);
				num = 58;
				continue;
			case 48:
				goto IL_0194;
			case 2:
				num4--;
				num = 34;
				continue;
			case 35:
				*(ptr2++) = b;
				*(ptr2++) = b;
				num = 3;
				continue;
			case 44:
				num13 = pixelCount;
				num = 0;
				continue;
			case 62:
				num18--;
				num = 21;
				continue;
			case 5:
				*(ptr7++) = num17;
				num = 48;
				continue;
			case 22:
				goto IL_023d;
			case 17:
				goto IL_024e;
			case 14:
				num2 = pixelCount;
				num = 64;
				continue;
			case 25:
				flag = true;
				num = 7;
				continue;
			case 56:
				flag = true;
				num = 43;
				if (true)
				{
					continue;
				}
				goto case 26;
			case 26:
				num14 = pixelCount;
				num = 19;
				continue;
			case 3:
				goto IL_0345;
			case 37:
			case 38:
				goto IL_0395;
			case 6:
				goto IL_03a7;
			case 68:
				return;
			case 41:
				b2 = (byte)((((num16 & 0xFF0000) >> 16) + ((num16 & 0xFF00) >> 8) + (num16 & 0xFF)) / 3);
				num = 55;
				continue;
			case 19:
			case 30:
				if (num14 <= 0)
				{
					num = 65;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					goto case 66;
				}
				b = *(ptr6++);
				*(ptr2++) = b;
				num = 35;
				continue;
			case 66:
				num15 = ((num3 & 0xF800) << 8) | ((num3 & 0x7E0) << 5) | ((num3 & 0x1F) << 3);
				num = 24;
				continue;
			case 10:
			case 21:
				goto IL_0434;
			case 49:
				*(ptr2++) = b5;
				num13--;
				num = 9;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					continue;
				}
				goto IL_073d;
			default:
				num = 12;
				continue;
			case 1:
				flag = true;
				num = 50;
				continue;
			case 13:
				num12--;
				goto IL_075b;
			case 70:
				goto IL_066e;
			case 34:
			case 53:
				if (num4 > 0)
				{
					short num11 = *(ptr4++);
					b4 = (byte)((num11 & 0x1F) << 3);
					*(ptr2++) = b4;
					b4 = (byte)((num11 & 0x7E0) >> 3);
					*(ptr2++) = b4;
					b4 = (byte)((num11 & 0xF800) >> 8);
					goto case 12;
				}
				num = 70;
				continue;
			case 60:
				vcqBWdpX1cXA9jpYrkf(destination, source, Mw7Jafpe9wUbKA2j3jp(sourceFormat) / 8 * pixelCount);
				num = 68;
				continue;
			case 18:
				goto IL_0705;
			case 69:
				flag = true;
				goto IL_073d;
			case 7:
			case 20:
			case 27:
			case 33:
			case 39:
			case 43:
			case 47:
			case 50:
			case 52:
			case 59:
			case 63:
				goto IL_073d;
			case 28:
				num10 = pixelCount;
				num = 23;
				continue;
			case 61:
			case 67:
				goto IL_075b;
			case 51:
			{
				byte b3 = (byte)((((num9 & 0xF800) >> 8) + ((num9 & 0x7E0) >> 3) + ((num9 & 0x1F) << 3)) / 3);
				*(ptr3++) = b3;
				num = 13;
				if (SgX2Q96FmNr0Z9PUqB3())
				{
				}
				continue;
			}
			case 4:
				num8 = pixelCount;
				num = 46;
				continue;
			case 0:
			case 9:
				goto IL_07bb;
			case 15:
				goto IL_07eb;
			case 45:
				goto IL_07fb;
			case 31:
				goto IL_0818;
			case 57:
				goto IL_0826;
			case 42:
				goto IL_0880;
			case 58:
				num6 = (short)(((num7 & 0xF80000) >> 8) | ((num7 & 0xFC00) >> 5) | ((num7 & 0xF8) >> 3));
				num = 36;
				continue;
			case 55:
				*(ptr3++) = b2;
				num5--;
				num = 38;
				continue;
			case 65:
				flag = true;
				goto IL_073d;
			case 54:
				num5 = pixelCount;
				num = 37;
				if (SgX2Q96FmNr0Z9PUqB3())
				{
				}
				continue;
			case 12:
				*(ptr2++) = b4;
				num = 2;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					continue;
				}
				goto case 29;
			case 29:
				num4 = pixelCount;
				num = 53;
				continue;
			case 32:
				num2--;
				goto case 64;
			case 64:
				if (num2 > 0)
				{
					num3 = *(ptr++);
					num = 66;
					continue;
				}
				num = 56;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					continue;
				}
				goto case 71;
			case 71:
				throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(44140));
			}
			break;
			IL_0880:
			switch (sourceFormat)
			{
			case CnxPixelFormat.Format16bppRgb565:
				break;
			case CnxPixelFormat.Format24bppRgb:
				goto IL_0105;
			case CnxPixelFormat.Format32bppRgb:
				goto IL_032c;
			default:
				goto IL_0894;
			}
			ptr8 = (short*)source.ToPointer();
			num12 = pixelCount;
			goto IL_075b;
			IL_0894:
			num = 52;
			continue;
			IL_032c:
			ptr9 = (int*)source.ToPointer();
			num = 54;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				continue;
			}
			goto IL_0345;
			IL_0105:
			ptr10 = (byte*)source.ToPointer();
			num = 28;
			if (!SgX2Q96FmNr0Z9PUqB3())
			{
				continue;
			}
			goto IL_011e;
			IL_011e:
			num10--;
			num = 8;
			continue;
			IL_0826:
			switch (sourceFormat)
			{
			case CnxPixelFormat.Format8bppGrayscale:
				break;
			case CnxPixelFormat.Format16bppRgb565:
				goto IL_01a9;
			default:
				goto IL_073d;
			case CnxPixelFormat.Format24bppRgb:
				goto IL_0843;
			}
			ptr11 = (byte*)source.ToPointer();
			num = 18;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				continue;
			}
			goto IL_0194;
			IL_0843:
			byte* ptr12 = (byte*)source.ToPointer();
			num19 = pixelCount;
			goto IL_03a7;
			IL_01a9:
			ptr = (short*)source.ToPointer();
			num = 14;
			if (SgX2Q96FmNr0Z9PUqB3())
			{
			}
			continue;
			IL_0194:
			num20--;
			goto IL_019a;
			IL_07bb:
			if (num13 > 0)
			{
				int num21 = *(ptr13++);
				b5 = (byte)(num21 & 0xFF);
				*(ptr2++) = b5;
				b5 = (byte)((num21 & 0xFF00) >> 8);
				*(ptr2++) = b5;
				b5 = (byte)((num21 & 0xFF0000) >> 16);
				num = 49;
			}
			else
			{
				num = 11;
			}
			continue;
			IL_029e:
			source2 = (byte*)source.ToPointer();
			num = 45;
			continue;
			IL_019a:
			if (num20 <= 0)
			{
				flag = true;
				goto IL_073d;
			}
			b6 = *(ptr11++);
			num = 40;
			continue;
			IL_0705:
			num20 = pixelCount;
			goto IL_019a;
			IL_066e:
			flag = true;
			SgX2Q96FmNr0Z9PUqB3();
			num = (tTQ2oS6fq1OmsPcd1gf() ? 27 : 61);
			continue;
			IL_023d:
			if (sourceFormat == destinationFormat)
			{
				num = 60;
				continue;
			}
			flag = false;
			num = 17;
			continue;
			IL_08ec:
			ptr4 = (short*)source.ToPointer();
			num = 29;
			continue;
			IL_075b:
			if (num12 > 0)
			{
				num9 = *(ptr8++);
				num = 51;
			}
			else
			{
				num = 69;
			}
			continue;
			IL_0279:
			ptr7 = (int*)destination.ToPointer();
			num = 57;
			continue;
			IL_026a:
			num = 47;
			continue;
			IL_0434:
			byte* ptr14;
			if (num18 > 0)
			{
				short num22 = (short)(((*(ptr14++) & 0xF8) >> 3) | ((*(ptr14++) & 0xFC) << 3) | ((*(ptr14++) & 0xF8) << 8));
				*(dest++) = num22;
				num = 62;
				continue;
			}
			flag = true;
			goto IL_073d;
			IL_07d2:
			ptr6 = (byte*)source.ToPointer();
			num = 26;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				continue;
			}
			goto IL_07eb;
			IL_07eb:
			num19--;
			num = 6;
			if (0 == 0)
			{
				continue;
			}
			goto IL_07fb;
			IL_03a7:
			if (num19 <= 0)
			{
				num = 1;
				continue;
			}
			int num23 = *(ptr12++) | (*(ptr12++) << 8) | (*(ptr12++) << 16);
			*(ptr7++) = num23;
			num = 15;
			continue;
			IL_07fb:
			CnxNativeMethods.BlitGrayToRGB565(source2, dest, 0, 2, 0, pixelCount, 1);
			flag = true;
			num = 33;
			if (true)
			{
				continue;
			}
			goto IL_0818;
			IL_0818:
			num18 = pixelCount;
			num = 10;
			continue;
			IL_0345:
			num14--;
			num = 30;
			if (!SgX2Q96FmNr0Z9PUqB3())
			{
				continue;
			}
			goto IL_073d;
			IL_024e:
			switch (destinationFormat)
			{
			case CnxPixelFormat.Format24bppRgb:
				break;
			default:
				goto IL_026a;
			case CnxPixelFormat.Format32bppRgb:
				goto IL_0279;
			case CnxPixelFormat.Format16bppRgb565:
				goto IL_0360;
			case CnxPixelFormat.Format8bppGrayscale:
				goto IL_0443;
			case CnxPixelFormat.Format8bppIndexed:
				goto IL_073d;
			}
			ptr2 = (byte*)destination.ToPointer();
			switch (sourceFormat)
			{
			case CnxPixelFormat.Format32bppRgb:
				break;
			default:
				goto IL_073d;
			case CnxPixelFormat.Format8bppGrayscale:
				goto IL_07d2;
			case CnxPixelFormat.Format16bppRgb565:
				goto IL_08ec;
			}
			ptr13 = (int*)source.ToPointer();
			num = 44;
			continue;
			IL_0443:
			ptr3 = (byte*)destination.ToPointer();
			num = 42;
			continue;
			IL_0360:
			dest = (short*)destination.ToPointer();
			switch (sourceFormat)
			{
			case CnxPixelFormat.Format24bppRgb:
				break;
			case CnxPixelFormat.Format8bppGrayscale:
				goto IL_029e;
			default:
				goto IL_0385;
			case CnxPixelFormat.Format32bppRgb:
				goto IL_047b;
			case CnxPixelFormat.Format8bppIndexed:
			case CnxPixelFormat.Format16bppRgb565:
				goto IL_073d;
			}
			ptr14 = (byte*)source.ToPointer();
			num = 31;
			continue;
			IL_047b:
			ptr5 = (int*)source.ToPointer();
			num = 4;
			continue;
			IL_0385:
			num = 59;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				continue;
			}
			goto IL_0395;
			IL_0395:
			if (num5 <= 0)
			{
				num = 25;
				continue;
			}
			num16 = *(ptr9++);
			num = 41;
		}
		goto IL_001a;
		IL_00e7:
		num17 = (b6 << 16) | (b6 << 8) | b6;
		num = 5;
		goto IL_04e1;
		IL_073d:
		if (!flag)
		{
			num = 71;
			goto IL_04e1;
		}
		return;
		IL_001a:
		if (num10 <= 0)
		{
			flag = true;
			goto IL_073d;
		}
		byte b7 = (byte)((*(ptr10++) + *(ptr10++) + *(ptr10++)) / 3);
		*(ptr3++) = b7;
		num = 16;
		if (!tTQ2oS6fq1OmsPcd1gf())
		{
			goto IL_00e7;
		}
		goto IL_04e1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe ICvsImageBuffer Transpose(CvsImageOrientation orientation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0046;
		IL_001a:
		int stride = default;
		CnxPixelFormat nativePixelFormat = default;
		IntPtr memoryPtr = GetMemoryPtr(write: false, out stride, out nativePixelFormat);
		num = 5;
		goto IL_0046;
		IL_0046:
		int* ptr = default;
		int* ptr2 = default;
		byte* ptr3 = default;
		short* ptr4 = default;
		byte* ptr5 = default;
		int num12 = default;
		int num14 = default;
		int* ptr6 = default;
		int num15 = default;
		int num11 = default;
		int* ptr14 = default;
		short* ptr7 = default;
		int num13 = default;
		short* ptr15 = default;
		int num10 = default;
		byte* ptr13 = default;
		byte* ptr9 = default;
		short* ptr12 = default;
		int num9 = default;
		byte* ptr11 = default;
		byte* ptr10 = default;
		int num8 = default;
		byte* ptr16 = default;
		while (true)
		{
			IL_0046_2:
			CvsImageBufferBase cvsImageBufferBase;
			switch (num)
			{
			case 1:
			case 3:
				return this;
			case 4:
				while (orientation == CvsImageOrientation.Normal)
				{
					_ = 1;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
						num = 0;
						if (SgX2Q96FmNr0Z9PUqB3())
						{
							continue;
						}
					}
					else
					{
						num = 3;
					}
					goto IL_0046_2;
				}
				cvsImageBufferBase = null;
				break;
			case 5:
				try
				{
					int num2 = GetPixelFormatSize(nativePixelFormat) / 8;
					Size size;
					int num3;
					int num4;
					int num5;
					int num6;
					switch (orientation)
					{
					case CvsImageOrientation.RotateClockwise90:
						size = new Size(Size.Height, Size.Width);
						num3 = 0;
						num4 = Size.Height - 1;
						num5 = -stride;
						num6 = num2;
						break;
					case CvsImageOrientation.Rotate180:
						size = Size;
						num3 = Size.Width - 1;
						num4 = Size.Height - 1;
						num5 = -num2;
						num6 = -stride;
						break;
					case CvsImageOrientation.RotateClockwise270:
						size = new Size(Size.Height, Size.Width);
						num3 = Size.Width - 1;
						num4 = 0;
						num5 = stride;
						num6 = -num2;
						break;
					default:
						throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(44240));
					}
					cvsImageBufferBase = (CvsImageBufferBase)zgCiW8pbGt6pW5eeCCf(size, PixelFormat);
					IntPtr memoryPtr2 = cvsImageBufferBase.GetMemoryPtr(write: false, out var stride2, out var nativePixelFormat2);
					try
					{
						int num7;
						if (nativePixelFormat2 != nativePixelFormat)
						{
							num7 = 17;
						}
						else
						{
							switch (nativePixelFormat)
							{
							case CnxPixelFormat.Format32bppRgb:
								break;
							default:
								goto IL_02a9;
							case CnxPixelFormat.Format8bppGrayscale:
								goto IL_0407;
							case CnxPixelFormat.Format16bppRgb565:
								goto IL_04be;
							case CnxPixelFormat.Format24bppRgb:
								goto IL_04e0;
							case CnxPixelFormat.Format8bppIndexed:
								goto end_IL_01be;
							}
							ptr = (int*)((byte*)memoryPtr.ToPointer() + num3 * 4 + num4 * stride);
							ptr2 = (int*)memoryPtr2.ToPointer();
							SgX2Q96FmNr0Z9PUqB3();
							if (tTQ2oS6fq1OmsPcd1gf())
							{
								num7 = 25;
								if (1 == 0)
								{
									goto IL_025b;
								}
							}
							else
							{
								num7 = 24;
								if (1 == 0)
								{
									goto IL_04a6;
								}
							}
						}
						goto IL_0325;
						IL_02a9:
						num7 = 42;
						if (SgX2Q96FmNr0Z9PUqB3())
						{
						}
						goto IL_0325;
						IL_0407:
						ptr3 = (byte*)memoryPtr.ToPointer() + num3 + num4 * stride;
						num7 = 30;
						goto IL_0325;
						IL_04be:
						ptr4 = (short*)((byte*)memoryPtr.ToPointer() + num3 * 2 + num4 * stride);
						num7 = 27;
						goto IL_0325;
						IL_04e0:
						ptr5 = (byte*)memoryPtr.ToPointer() + num3 * 3 + num4 * stride;
						num7 = 34;
						goto IL_0325;
						IL_0325:
						while (true)
						{
							byte* ptr8;
							switch (num7)
							{
							case 28:
								num12 = size.Height;
								num7 = 8;
								continue;
							case 24:
							case 40:
								num14--;
								num7 = 43;
								if (!SgX2Q96FmNr0Z9PUqB3())
								{
									continue;
								}
								goto case 3;
							case 3:
								ptr6 = ptr;
								num15 = size.Width;
								num7 = 26;
								continue;
							case 37:
								num11--;
								goto IL_0216;
							case 19:
							case 22:
								break;
							case 17:
								throw new InvalidOperationException();
							case 31:
								ptr2 = (int*)((byte*)ptr2 + stride2);
								num7 = 35;
								continue;
							case 16:
								num15--;
								goto case 26;
							case 26:
								if (num15 <= 0)
								{
									num7 = 31;
									continue;
								}
								*(ptr14++) = *ptr6;
								num7 = 10;
								continue;
							case 27:
								ptr7 = (short*)memoryPtr2.ToPointer();
								num7 = 29;
								continue;
							case 7:
								if (num13 <= 0)
								{
									num7 = 41;
									if (true)
									{
										continue;
									}
									goto case 0;
								}
								ptr15 = ptr7;
								num7 = 5;
								continue;
							case 0:
								num13--;
								goto case 7;
							default:
								num7 = 7;
								continue;
							case 25:
							case 33:
								num14 = size.Height;
								goto case 43;
							case 42:
								goto end_IL_01be;
							case 2:
							case 13:
								if (num10 <= 0)
								{
									ptr13 += stride2;
									ptr5 += num6;
									num7 = 37;
									continue;
								}
								*(ptr8++) = *ptr9;
								*(ptr8++) = ptr9[1];
								num7 = 23;
								if (0 == 0)
								{
									continue;
								}
								goto case 29;
							case 4:
								ptr12 = (short*)((byte*)ptr12 + num5);
								num9--;
								num7 = 22;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								num10--;
								num7 = 13;
								continue;
							case 8:
							case 20:
								goto IL_046b;
							case 21:
								num12--;
								num7 = 20;
								continue;
							case 35:
								ptr = (int*)((byte*)ptr + num6);
								goto case 24;
							case 34:
								goto IL_04a6;
							case 12:
								goto end_IL_01be;
							case 41:
								goto end_IL_01be;
							case 29:
								num13 = size.Height;
								goto case 7;
							case 18:
							case 38:
								goto IL_055c;
							case 39:
								ptr9 += num5;
								num7 = 9;
								continue;
							case 36:
								num11 = size.Height;
								goto IL_0216;
							case 5:
								ptr12 = ptr4;
								num7 = 14;
								continue;
							case 11:
								num10 = size.Width;
								num7 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								ptr9 = ptr5;
								num7 = 11;
								continue;
							case 30:
								ptr11 = (byte*)memoryPtr2.ToPointer();
								num7 = 28;
								continue;
							case 14:
								num9 = size.Width;
								num7 = 19;
								continue;
							case 32:
								ptr10 += num5;
								num8--;
								num7 = 18;
								continue;
							case 6:
								ptr4 = (short*)((byte*)ptr4 + num6);
								num7 = 0;
								continue;
							case 23:
								*(ptr8++) = ptr9[2];
								num7 = 39;
								continue;
							case 15:
								ptr7 = (short*)((byte*)ptr7 + stride2);
								num7 = 6;
								continue;
							case 10:
								ptr6 = (int*)((byte*)ptr6 + num5);
								num7 = 16;
								continue;
							case 43:
								{
									if (num14 > 0)
									{
										ptr14 = ptr2;
										num7 = 3;
										if (0 == 0)
										{
											continue;
										}
									}
									goto end_IL_01be;
								}
								IL_0216:
								if (num11 > 0)
								{
									ptr8 = ptr13;
									num7 = 1;
									continue;
								}
								goto end_IL_01be;
							}
							break;
							IL_055c:
							if (num8 > 0)
							{
								*(ptr16++) = *ptr10;
								num7 = 32;
							}
							else
							{
								ptr11 += stride2;
								ptr3 += num6;
								num7 = 21;
							}
							continue;
							IL_046b:
							if (num12 <= 0)
							{
								num7 = 12;
								continue;
							}
							ptr16 = ptr11;
							ptr10 = ptr3;
							num8 = size.Width;
							num7 = 38;
						}
						goto IL_025b;
						IL_025b:
						if (num9 <= 0)
						{
							num7 = 15;
						}
						else
						{
							*(ptr15++) = *ptr12;
							num7 = 4;
						}
						goto IL_0325;
						IL_04a6:
						ptr13 = (byte*)memoryPtr2.ToPointer();
						num7 = 36;
						goto IL_0325;
						end_IL_01be:;
					}
					finally
					{
						FDZGBhprrhpNqqY1RNg(cvsImageBufferBase);
					}
				}
				finally
				{
					FDZGBhprrhpNqqY1RNg(this);
				}
				return cvsImageBufferBase;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(string fileName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ImageFormat imageFormat = (ImageFormat)zZZDiFp6CoQQBo8nm8D(fileName);
		try
		{
			Bitmap bitmap = (Bitmap)LBHukSppH5eItF8mHTX(this);
			try
			{
				sLYkKSitLx(bitmap, fileName, imageFormat);
			}
			finally
			{
				if (bitmap != null)
				{
					DvvSaopdYf9pBBI3dsW(bitmap);
				}
			}
		}
		catch (ExternalException)
		{
			try
			{
				Bitmap bitmap2 = (Bitmap)OitB0tp0pVxeS7wWKci(this);
				try
				{
					sLYkKSitLx(bitmap2, fileName, imageFormat);
				}
				finally
				{
					if (bitmap2 != null)
					{
						DvvSaopdYf9pBBI3dsW(bitmap2);
					}
				}
			}
			catch (ExternalException inner)
			{
				throw new UnauthorizedAccessException((string)sRcgPEpPUgcUuNkwrYJ(WB1PfA6zOWF9gD8cRDJ(44264), fileName), inner);
			}
		}
		catch (IOException ex2)
		{
			throw new UnauthorizedAccessException(ex2.Message, ex2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sLYkKSitLx(Bitmap P_0, string P_1, ImageFormat P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		q7W6bSp49f3nsFHS5MB(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetPen(Color color, int width, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CnxNativeMethods.LOGBRUSH lplb = default;
		IntPtr intPtr = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				lplb.lbStyle = 0;
				num = 0;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				h0Wkzyl9F4 = dashStyle;
				num = 17;
				break;
			case 0:
				if (dashStyle == CvsDashStyles.SmallDash)
				{
					num = 16;
					break;
				}
				if (dashStyle == CvsDashStyles.SmallerDash)
				{
					goto case 3;
				}
				intPtr = CnxNativeMethods.ExtCreatePen((CnxNativeMethods.PS)(dashStyle | (CvsDashStyles)0x10000 | (CvsDashStyles)0x100 | (CvsDashStyles)0x2000), width, ref lplb, 0, null);
				goto case 12;
			case 6:
				lplb = new CnxNativeMethods.LOGBRUSH
				{
					lbColor = I1QdoJpTpC2nLcIokbN(color)
				};
				num = 8;
				break;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				if (h0Wkzyl9F4 != dashStyle)
				{
					num = 6;
					break;
				}
				return;
			case 4:
				if (!(OGqkZylWD6 != color))
				{
					num = 1;
					break;
				}
				goto case 6;
			case 3:
				intPtr = CnxNativeMethods.ExtCreatePen(CnxNativeMethods.PS.PS_USERSTYLE, 1, ref lplb, 2, new int[2] { 1, 1 });
				goto case 12;
			case 12:
				if (!juVZ5M688QZYJ52oreL(QgskVSfr6N, IntPtr.Zero))
				{
					h0Va95pSoyfTlHcHesl(GetDc(), intPtr);
					goto case 7;
				}
				num = 9;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 14;
			case 14:
				OGqkZylWD6 = color;
				num = 15;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				rSnkv4rw0f = h0Va95pSoyfTlHcHesl(GetDc(), intPtr);
				SgX2Q96FmNr0Z9PUqB3();
				num = (tTQ2oS6fq1OmsPcd1gf() ? 13 : 7);
				break;
			case 15:
				ddBk869ufk = width;
				num = 5;
				break;
			case 16:
				intPtr = CnxNativeMethods.ExtCreatePen(CnxNativeMethods.PS.PS_USERSTYLE, 1, ref lplb, 2, new int[2] { 2, 2 });
				num = 12;
				break;
			case 1:
				if (ddBk869ufk == width)
				{
					num = 2;
					break;
				}
				goto case 6;
			case 7:
			case 11:
				qCSvEEpEJNjE76SxED5(QgskVSfr6N);
				goto case 10;
			case 10:
			case 13:
				QgskVSfr6N = intPtr;
				num = 14;
				break;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetBackColor(Color backColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0099;
		IL_001a:
		sAoXbdxta1 = CnxNativeMethods.BkMode.OPAQUE;
		num = 7;
		if (!tTQ2oS6fq1OmsPcd1gf())
		{
			return;
		}
		goto IL_0099;
		IL_0099:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 3:
			case 4:
				return;
			case 2:
			case 8:
				CoUXafeElp = backColor;
				num = 11;
				continue;
			case 7:
				if (OOoVJKpFO1R03iPhsS1(CoUXafeElp, backColor))
				{
					num = 10;
					continue;
				}
				return;
			case 9:
				IweLdopffdDgiNgRhO7(GetDc(), CnxNativeMethods.BkMode.OPAQUE);
				break;
			default:
				num = 6;
				continue;
			case 0:
				if (!kMg0SXpkjOmnlE3ylc4(backColor, Color.Empty))
				{
					if (sAoXbdxta1 != CnxNativeMethods.BkMode.OPAQUE)
					{
						num = 9;
						if (tTQ2oS6fq1OmsPcd1gf())
						{
							continue;
						}
						goto case 2;
					}
					goto case 7;
				}
				num = 5;
				continue;
			case 10:
				CnxNativeMethods.SetBkColor(GetDc(), CnxColorConversion.ColorToGdi(backColor));
				goto case 2;
			case 5:
				if (sAoXbdxta1 != CnxNativeMethods.BkMode.TRANSPARENT)
				{
					IweLdopffdDgiNgRhO7(GetDc(), CnxNativeMethods.BkMode.TRANSPARENT);
					num = 1;
					continue;
				}
				return;
			case 1:
				sAoXbdxta1 = CnxNativeMethods.BkMode.TRANSPARENT;
				SgX2Q96FmNr0Z9PUqB3();
				if (!tTQ2oS6fq1OmsPcd1gf())
				{
					num = 2;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					goto case 5;
				}
				num = 4;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected IntPtr SetBrush(Color color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SgX2Q96FmNr0Z9PUqB3();
		int num = ((!tTQ2oS6fq1OmsPcd1gf()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (!OOoVJKpFO1R03iPhsS1(lrdXIuettF, color))
				{
					break;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				lrdXIuettF = color;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				YKBXPZ19oa = YXejAUpmxwEA5QK6Vnd(I1QdoJpTpC2nLcIokbN(color));
				num = 5;
				continue;
			case 3:
				if (!WorvpX6ypt5Tjsj2oNO(YKBXPZ19oa, IntPtr.Zero))
				{
					goto case 6;
				}
				goto case 1;
			case 1:
			case 2:
				HpRUE6pvcD95AUGIvpx(YKBXPZ19oa);
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return YKBXPZ19oa;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetFont(IntPtr hFont)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (true)
		{
			goto IL_0060;
		}
		goto IL_009f;
		IL_009f:
		HJYX1VtQqX = hFont;
		num = 7;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 1:
				zgSXxuJYja = h0Va95pSoyfTlHcHesl(GetDc(), hFont);
				goto default;
			default:
				SgX2Q96FmNr0Z9PUqB3();
				num = (tTQ2oS6fq1OmsPcd1gf() ? 2 : 6);
				continue;
			case 2:
			case 3:
			case 4:
			case 6:
				break;
			case 5:
				if (HJYX1VtQqX != hFont)
				{
					num = 0;
					continue;
				}
				return;
			case 0:
				if (!juVZ5M688QZYJ52oreL(zgSXxuJYja, IntPtr.Zero))
				{
					h0Va95pSoyfTlHcHesl(GetDc(), hFont);
					break;
				}
				num = 1;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnClipRegionChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nmBkEFjoGl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SgX2Q96FmNr0Z9PUqB3();
		int num;
		if (tTQ2oS6fq1OmsPcd1gf())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (SgX2Q96FmNr0Z9PUqB3())
			{
				goto IL_0045;
			}
		}
		goto IL_006c;
		IL_0093:
		AoGkiR3d6U();
		num = 5;
		goto IL_006c;
		IL_0045:
		if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
		{
			goto IL_0093;
		}
		return;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				fkSk2wIdM0 = true;
				break;
			case 1:
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_0093;
			case 5:
				return;
			}
			break;
		}
		goto IL_0045;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HX0kQdfgbE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				fkSk2wIdM0 = false;
				_ = 0;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					num = 0;
					break;
				}
				num = 4;
				if (true)
				{
					break;
				}
				return;
			default:
				AoGkiR3d6U();
				num = 5;
				break;
			case 0:
			case 1:
				if (WorvpX6ypt5Tjsj2oNO(uD8keK0x1J, IntPtr.Zero))
				{
					goto default;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SizeF MeasureString(string s, CvsFont font, bool symbols)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using (YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(44316)))
		{
			SetFont(L5bEA0pyGiMqAhNohY3(font, FontScale));
			tTQ2oS6fq1OmsPcd1gf();
			int num;
			if (!SgX2Q96FmNr0Z9PUqB3())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0051;
				}
			}
			else
			{
				num = 3;
			}
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_009d;
			}
			goto IL_0051;
			IL_009d:
			CnxNativeMethods.SIZE lpSize = default;
			return new SizeF(lpSize.cx + font.MaxOverhang, lpSize.cy);
			IL_0051:
			CnxNativeMethods.GetTextExtentPoint32(GetDc(), s, mWJs8apgkIGY5ghyjMh(s), out lpSize);
			goto IL_009d;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawImage(ICvsImageBuffer image, Rectangle destRect, Rectangle sourceRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(44346));
		try
		{
			if (image is CvsImageBufferBase)
			{
				_ = 1;
				int num;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					num = 2;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
						goto IL_004a;
					}
				}
				else
				{
					num = 3;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
				}
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					return;
				case 3:
					return;
				}
				goto IL_004a;
			}
			throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(44368), (string)WB1PfA6zOWF9gD8cRDJ(44418));
			IL_004a:
			tPwHiipJBRElwyLUHjA(GetDc(), destRect.X, destRect.Y, destRect.Width, destRect.Height, LZwubmpZAouFOQ5QbdS((CvsImageBufferBase)image), sourceRect.X, sourceRect.Y, sourceRect.Width, sourceRect.Height, CnxNativeMethods.RasterOp.SRCCOPY);
		}
		finally
		{
			if (disposable != null)
			{
				DvvSaopdYf9pBBI3dsW(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawImageTransparent(ICvsImageBuffer image, Rectangle destRect, Rectangle sourceRect, Color transparencyKey)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 2);
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (image is CvsImageBufferBase)
				{
					goto case 1;
				}
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(44368), kgbOBx7BanbFa22Hp9.ol99ukmDA(44418));
			case 1:
			case 3:
				disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(44432));
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				try
				{
					wT2nRdp8wIqctm0BMQT(GetDc(), destRect.X, destRect.Y, destRect.Width, destRect.Height, LZwubmpZAouFOQ5QbdS((CvsImageBufferBase)image), sourceRect.X, sourceRect.Y, sourceRect.Width, sourceRect.Height, I1QdoJpTpC2nLcIokbN(transparencyKey));
					return;
				}
				finally
				{
					if (disposable != null)
					{
						DvvSaopdYf9pBBI3dsW(disposable);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawLine(Color color, int x1, int y1, int x2, int y2, int lineWidth, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(44476));
		try
		{
			SetBackColor(Color.Empty);
			SgX2Q96FmNr0Z9PUqB3();
			int num;
			if (tTQ2oS6fq1OmsPcd1gf())
			{
				num = 2;
				if (!tTQ2oS6fq1OmsPcd1gf())
				{
					goto IL_004e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_006b;
			IL_006b:
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0094;
			case 4:
				IHKvTm0wNPB2kVdl4dL(GetDc(), x2, y2);
				return;
			}
			goto IL_004e;
			IL_0094:
			svqlfUpzy0dsZg0b0Hy(GetDc(), x1, y1, IntPtr.Zero);
			num = 4;
			goto IL_006b;
			IL_004e:
			SetPen(color, lineWidth, dashStyle);
			goto IL_0094;
		}
		finally
		{
			if (disposable != null)
			{
				DvvSaopdYf9pBBI3dsW(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawLines(Color color, Point[] points, int lineWidth, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, kgbOBx7BanbFa22Hp9.ol99ukmDA(44496));
		try
		{
			SetBackColor(Color.Empty);
			int num = 3;
			int num2 = default;
			Point point = default;
			while (true)
			{
				switch (num)
				{
				case 6:
				case 9:
					IHKvTm0wNPB2kVdl4dL(GetDc(), points[num2 + 1].X, points[num2 + 1].Y);
					goto case 4;
				default:
					num = 5;
					break;
				case 4:
				case 7:
					point = points[num2 + 1];
					num2 += 2;
					num = 10;
					break;
				case 2:
					num2 = 0;
					num = 1;
					break;
				case 0:
					point = vjkXh7B0ex;
					num = 2;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					SetPen(color, lineWidth, dashStyle);
					num = 0;
					break;
				case 8:
					CnxNativeMethods.MoveToEx(GetDc(), points[num2].X, points[num2].Y, IntPtr.Zero);
					_ = 0;
					num = (tTQ2oS6fq1OmsPcd1gf() ? 9 : 4);
					break;
				case 5:
					if (points[num2].Y == point.Y)
					{
						goto case 6;
					}
					num = 8;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 10:
					if (num2 < points.Length)
					{
						if (points[num2].X != point.X)
						{
							goto case 8;
						}
						goto case 5;
					}
					return;
				}
			}
		}
		finally
		{
			if (disposable != null)
			{
				DvvSaopdYf9pBBI3dsW(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawRectangle(Color color, int x, int y, int width, int height, int lineWidth, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using (CvsTrace.Display.Draw.TraceBlock((string)WB1PfA6zOWF9gD8cRDJ(43388)))
		{
			SetPen(color, lineWidth, dashStyle);
			IntPtr dc = GetDc();
			CnxNativeMethods.MoveToEx(dc, x, y, IntPtr.Zero);
			CnxNativeMethods.LineTo(dc, x + width, y);
			IHKvTm0wNPB2kVdl4dL(dc, x + width, y + height);
			CnxNativeMethods.LineTo(dc, x, y + height);
			IHKvTm0wNPB2kVdl4dL(dc, x, y);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPolygon(Color color, Point[] points, int lineWidth, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 2);
		IDisposable disposable = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				if (points.Length < 2)
				{
					return;
				}
				disposable = (IDisposable)YkvctEpwi0T5lLTBs1T(CvsTrace.Display.Draw, WB1PfA6zOWF9gD8cRDJ(44518));
				num = 5;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 0;
			default:
				num = 4;
				break;
			case 4:
				return;
			case 0:
			case 2:
				if (points == null)
				{
					return;
				}
				goto case 1;
			case 5:
				try
				{
					SetBackColor(Color.Empty);
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						case 0:
							SetPen(color, lineWidth, dashStyle);
							num2 = 5;
							if (tTQ2oS6fq1OmsPcd1gf())
							{
								break;
							}
							goto default;
						default:
							points[points.Length - 1] = points[0];
							num2 = 4;
							break;
						case 1:
						case 2:
						{
							Point[] array = points;
							points = new Point[points.Length + 1];
							sdGCsW0scdYyQx9fZPP(array, points, 0);
							goto default;
						}
						case 5:
							if (points[0] != points[points.Length - 1])
							{
								_ = 1;
								num2 = ((!SgX2Q96FmNr0Z9PUqB3()) ? 1 : 6);
								break;
							}
							goto case 4;
						case 4:
							points.GetType().GetElementType();
							num2 = 7;
							break;
						case 7:
							qde2BF0hXsOEKXFErVF(GetDc(), points, points.Length);
							return;
						}
					}
				}
				finally
				{
					if (disposable != null)
					{
						DvvSaopdYf9pBBI3dsW(disposable);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawEllipse(Color color, float x, float y, float width, float height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawEllipse(color, x, y, width, height, 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawEllipse(Color color, float x, float y, float width, float height, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nmBkEFjoGl();
		try
		{
			x *= 100f;
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					SetPen(color, lineWidth * 100, CvsDashStyles.Solid);
					num = 6;
					continue;
				case 1:
				case 5:
					width *= 100f;
					goto case 0;
				default:
					num = 0;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					goto case 0;
				case 0:
					height *= 100f;
					goto case 2;
				case 4:
					y *= 100f;
					tTQ2oS6fq1OmsPcd1gf();
					if (SgX2Q96FmNr0Z9PUqB3())
					{
						num = 2;
						continue;
					}
					num = 5;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						continue;
					}
					break;
				case 6:
					break;
				}
				break;
			}
			UQrE4h09mW4Qwat6TXM(GetDc(), ntHCAm0Lwt0GcgMU5on(x), Convert.ToInt32(y), ntHCAm0Lwt0GcgMU5on(x + width), ntHCAm0Lwt0GcgMU5on(y + height), 0, 0, 0, 0);
		}
		finally
		{
			HX0kQdfgbE();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle, int lineWidth)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrawArc(color, cx, cy, radius, startAngle, sweepAngle, lineWidth, CvsDashStyles.Solid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawArc(Color color, float cx, float cy, float radius, float startAngle, float sweepAngle, int lineWidth, CvsDashStyles dashStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nmBkEFjoGl();
		try
		{
			cx *= 100f;
			int num = 0;
			int x = default;
			double num4 = default;
			double num2 = default;
			IntPtr dc = default;
			int y = default;
			double num3 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					lineWidth *= 100;
					SetPen(color, lineWidth, dashStyle);
					_ = 1;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						num = 10;
						break;
					}
					num = 15;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
					break;
				case 8:
					x = COFHFy0EvuPCh6wWEbG(num4);
					num = 14;
					break;
				case 2:
					if (cy >= -2.1474836E+09f)
					{
						num = 17;
						break;
					}
					return;
				case 7:
					if (num2 >= -2147483648.0 && num2 <= 2147483647.0)
					{
						num = 16;
						if (true)
						{
							break;
						}
						goto case 12;
					}
					return;
				case 12:
					svqlfUpzy0dsZg0b0Hy(dc, x, y, IntPtr.Zero);
					num = 19;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						break;
					}
					goto case 6;
				case 6:
					if (num4 <= 2147483647.0)
					{
						num = 7;
						break;
					}
					return;
				case 16:
					if (cx >= -2.1474836E+09f && cx <= 2.1474836E+09f)
					{
						num = 2;
						if (!SgX2Q96FmNr0Z9PUqB3())
						{
							break;
						}
						goto case 17;
					}
					return;
				case 17:
					if (cy <= 2.1474836E+09f)
					{
						num = 8;
						if (SgX2Q96FmNr0Z9PUqB3())
						{
						}
						break;
					}
					return;
				case 9:
					num4 = (double)cx + (double)radius * CbgoAW0S36Q3bArnL7v(num3);
					num = 18;
					if (tTQ2oS6fq1OmsPcd1gf())
					{
						break;
					}
					goto case 3;
				case 3:
				case 10:
					dc = GetDc();
					num = 11;
					break;
				case 13:
					num3 = (double)startAngle * Math.PI / 180.0;
					num = 9;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						break;
					}
					goto case 11;
				case 11:
					if (!(radius < 0f))
					{
						goto case 13;
					}
					goto case 5;
				case 14:
					y = COFHFy0EvuPCh6wWEbG(num2);
					num = 12;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						break;
					}
					goto case 4;
				case 4:
					radius *= 100f;
					num = 1;
					break;
				case 18:
					num2 = (double)cy + (double)radius * Math.Sin(num3);
					if (num4 >= -2147483648.0)
					{
						goto case 6;
					}
					return;
				default:
					num = 6;
					break;
				case 0:
					cy *= 100f;
					num = 4;
					break;
				case 5:
				case 15:
					radius = 0f - radius;
					startAngle += 180f;
					num = 13;
					break;
				case 19:
					e6260j0vcCJ4N5Wp9LF(dc, Convert.ToInt32(cx), Convert.ToInt32(cy), ntHCAm0Lwt0GcgMU5on(radius), 0f - startAngle, 0f - sweepAngle);
					return;
				}
			}
		}
		finally
		{
			HX0kQdfgbE();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FillEllipse(Color color, float x, float y, float width, float height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nmBkEFjoGl();
		try
		{
			x *= 100f;
			tTQ2oS6fq1OmsPcd1gf();
			int num = (SgX2Q96FmNr0Z9PUqB3() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					width *= 100f;
					goto case 2;
				default:
					num = 2;
					break;
				case 5:
					SetPen(color, 100, CvsDashStyles.Solid);
					num = 6;
					break;
				case 2:
					height *= 100f;
					num = 5;
					break;
				case 0:
				case 4:
					y *= 100f;
					goto case 1;
				case 6:
				{
					IntPtr dc = GetDc();
					IntPtr hgdiobj = SetBrush(color);
					IntPtr hgdiobj2 = h0Va95pSoyfTlHcHesl(dc, hgdiobj);
					JvDeS30HFHtbRmxxPsA(dc, ntHCAm0Lwt0GcgMU5on(x), Convert.ToInt32(y), ntHCAm0Lwt0GcgMU5on(x + width), ntHCAm0Lwt0GcgMU5on(y + height));
					h0Va95pSoyfTlHcHesl(dc, hgdiobj2);
					return;
				}
				}
			}
		}
		finally
		{
			HX0kQdfgbE();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DrawStringInternal(string s, CvsFont font, Color foreColor, Color backColor, Rectangle rect, CvsTextFormat format, bool symbols)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CnxNativeMethods.RECT lpRect = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				CnxNativeMethods.DrawText(GetDc(), s, -1, ref lpRect, (CnxNativeMethods.TextFormat)((format & CvsTextFormat.DrawTextMask) | CvsTextFormat.NoPrefix));
				num = 9;
				break;
			case 6:
				Q0gXFqKc1l = foreColor;
				goto default;
			default:
				_ = 0;
				num = (tTQ2oS6fq1OmsPcd1gf() ? 1 : 0);
				break;
			case 1:
			case 4:
				SetFont(L5bEA0pyGiMqAhNohY3(font, FontScale));
				goto case 0;
			case 2:
				SetBackColor(backColor);
				num = 7;
				break;
			case 0:
			case 5:
				lpRect = rEdhhn0AJ2fr0gvbrCo(GwI37q0V0U3eX2Bj8SY(rect));
				num = 3;
				break;
			case 7:
				if (Q0gXFqKc1l != foreColor)
				{
					num = 8;
					if (SgX2Q96FmNr0Z9PUqB3())
					{
					}
					break;
				}
				goto case 1;
			case 8:
				CnxNativeMethods.SetTextColor(GetDc(), I1QdoJpTpC2nLcIokbN(foreColor));
				num = 6;
				if (!tTQ2oS6fq1OmsPcd1gf())
				{
					return;
				}
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe void FillRectangle(Color color, Rectangle rect)
	{
		//The blocks IL_0018, IL_0023, IL_0033, IL_0044, IL_0053, IL_005e, IL_006b, IL_0075, IL_0090, IL_0121, IL_012b, IL_013d, IL_0147, IL_0194, IL_01b4, IL_01d7, IL_01e7, IL_01fc, IL_0206, IL_0212, IL_021e, IL_0235, IL_0253, IL_0273, IL_02b1, IL_02c3, IL_02d3, IL_02de, IL_059e, IL_05aa, IL_05b4, IL_05ce, IL_05f5, IL_0602, IL_0636, IL_0657, IL_0667, IL_0675, IL_068a, IL_0694, IL_06ca, IL_06ee, IL_06f7, IL_0701, IL_071b, IL_0730, IL_074f are reachable both inside and outside the pinned region starting at IL_01bb. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CnxPixelFormat nativePixelFormat2 = default;
		int* ptr = default;
		IntPtr memoryPtr = default;
		int num6 = default;
		int num2 = default;
		int num4 = default;
		int num5 = default;
		byte b = default;
		byte* ptr5 = default;
		int num3 = default;
		int stride = default;
		byte a = default;
		CnxNativeMethods.BLENDFUNCTION blendFunction = default;
		int num10 = default;
		int* ptr2 = default;
		int stride2 = default;
		CnxPixelFormat nativePixelFormat = default;
		int num9 = default;
		int* ptr3 = default;
		int num8 = default;
		while (true)
		{
			int num7;
			int* ptr4;
			ref Rectangle reference;
			switch (num)
			{
			case 3:
				if (Nw5XO2Y5QV != null)
				{
					num = 21;
					if (!SgX2Q96FmNr0Z9PUqB3())
					{
						break;
					}
					goto case 7;
				}
				goto case 27;
			case 7:
				if (color.A == byte.MaxValue)
				{
					tTQ2oS6fq1OmsPcd1gf();
					num = (SgX2Q96FmNr0Z9PUqB3() ? 32 : 30);
					break;
				}
				if (PixelFormat == CnxPixelFormat.Format32bppRgb)
				{
					num = 3;
					break;
				}
				goto IL_0675;
			case 15:
				if (nativePixelFormat2 == PixelFormat)
				{
					num = 29;
					break;
				}
				goto IL_0675;
			case 19:
				ptr = (int*)memoryPtr.ToPointer();
				goto case 12;
			default:
				num = 12;
				break;
			case 21:
				if (dmjXpOVsWZ != color.ToArgb())
				{
					num = 27;
					break;
				}
				goto case 17;
			case 18:
				checked
				{
					Nw5XO2Y5QV[unchecked(num6 + 256)] = (byte)unchecked(checked(num2 + num4) / 255);
					Nw5XO2Y5QV[unchecked(num6 + 512)] = (byte)unchecked(checked(num2 + num5) / 255);
				}
				num6++;
				num2 += b;
				num = 31;
				break;
			case 28:
				NSb8E90iw9xTb8o2HR2(bNukSbtbd1, 0, 0, CnxColorConversion.ColorToGdi(color));
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
			{
				byte[] nw5XO2Y5QV = Nw5XO2Y5QV;
				while (true)
				{
					fixed (byte[] array = nw5XO2Y5QV)
					{
						if (nw5XO2Y5QV != null)
						{
							if (array.Length == 0)
							{
								num = 9;
								if (false)
								{
									goto IL_01d7;
								}
							}
							else
							{
								ptr5 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
								num = 13;
							}
							goto IL_0090_2;
						}
						goto IL_0235;
						IL_0090_2:
						while (true)
						{
							switch (num)
							{
							case 3:
								if (Nw5XO2Y5QV != null)
								{
									num = 21;
									if (!SgX2Q96FmNr0Z9PUqB3())
									{
										continue;
									}
									break;
								}
								goto case 27;
							case 7:
								break;
							case 15:
								goto IL_005e;
							case 19:
								ptr = (int*)memoryPtr.ToPointer();
								goto case 12;
							default:
								num = 12;
								continue;
							case 21:
								if (dmjXpOVsWZ != color.ToArgb())
								{
									num = 27;
									continue;
								}
								goto case 17;
							case 18:
								checked
								{
									Nw5XO2Y5QV[unchecked(num6 + 256)] = (byte)unchecked(checked(num2 + num4) / 255);
									Nw5XO2Y5QV[unchecked(num6 + 512)] = (byte)unchecked(checked(num2 + num5) / 255);
								}
								num6++;
								num2 += b;
								num = 31;
								continue;
							case 28:
								goto end_IL_0090;
							case 6:
								goto IL_01b4;
							case 22:
								goto IL_01d7;
							case 31:
							case 33:
								if (num6 >= 256)
								{
									num = 17;
									if (true)
									{
										continue;
									}
									goto case 26;
								}
								checked
								{
									Nw5XO2Y5QV[num6] = (byte)unchecked(checked(num2 + num3) / 255);
									num = 18;
									continue;
								}
							case 26:
								memoryPtr = GetMemoryPtr(write: true, out stride, out nativePixelFormat2);
								num = 19;
								continue;
							case 9:
								goto IL_0235;
							case 2:
								dmjXpOVsWZ = color.ToArgb();
								a = color.A;
								num = 20;
								continue;
							case 14:
								H65ZiV0qls0P8Omwl36(GetDc(), rect.X, rect.Y, rect.Width, rect.Height, bNukSbtbd1, 0, 0, 1, 1, blendFunction);
								num = 34;
								continue;
							case 10:
								blendFunction = default;
								num = 4;
								continue;
							case 27:
								if (Nw5XO2Y5QV != null)
								{
									goto case 2;
								}
								goto case 5;
							case 1:
							case 30:
								using (CvsTrace.Display.Draw.TraceBlock(kgbOBx7BanbFa22Hp9.ol99ukmDA(44544)))
								{
									if (PixelFormat == CnxPixelFormat.Format32bppRgb)
									{
										num7 = 13;
										while (true)
										{
											switch (num7)
											{
											case 15:
												num10 = color.ToArgb() & 0xFFFFFF;
												goto case 7;
											case 16:
												if (Clip != null)
												{
													num7 = 14;
													continue;
												}
												goto case 4;
											case 13:
												if (Clip != null)
												{
													if (gPGFE50DlK5Ft1PTf8V(Clip))
													{
														num7 = 1;
														continue;
													}
													break;
												}
												goto case 1;
											case 9:
												ptr2 += rect.X + rect.Y * stride2;
												num7 = 12;
												continue;
											case 0:
												if (nativePixelFormat != PixelFormat)
												{
													break;
												}
												num7 = 5;
												if (!SgX2Q96FmNr0Z9PUqB3())
												{
													continue;
												}
												goto case 2;
											case 2:
												num9--;
												goto case 18;
											case 18:
												if (num9 > 0)
												{
													ptr4 = ptr3++;
													*ptr4 = num10;
													num7 = 2;
													if (true)
													{
														continue;
													}
													goto case 9;
												}
												num7 = 8;
												continue;
											case 6:
												if (num8 > 0)
												{
													ptr3 = ptr2;
													num9 = rect.Width;
													num7 = 18;
												}
												else
												{
													ReleaseMemoryPtr();
													num7 = 20;
												}
												continue;
											case 8:
												ptr2 += stride2;
												num7 = 11;
												if (true)
												{
													continue;
												}
												goto case 5;
											case 5:
												stride2 /= 4;
												num7 = 9;
												if (tTQ2oS6fq1OmsPcd1gf())
												{
													continue;
												}
												goto case 1;
											case 1:
												rect.Intersect(new Rectangle(Point.Empty, Size));
												num7 = 16;
												if (true)
												{
													continue;
												}
												goto case 11;
											case 11:
											case 12:
												reference = ref rect;
												num8 = reference.Height--;
												num7 = 6;
												continue;
											case 14:
												rect.Intersect(HrfI8i0UU7Fd9airbPm(Clip));
												tTQ2oS6fq1OmsPcd1gf();
												num7 = ((!SgX2Q96FmNr0Z9PUqB3()) ? 17 : 19);
												continue;
											case 10:
												if (rect.Height <= 0)
												{
													break;
												}
												num7 = 15;
												if (true)
												{
													continue;
												}
												goto case 3;
											case 3:
												if (ptr2 == null)
												{
													break;
												}
												goto case 0;
											default:
												num7 = 0;
												continue;
											case 4:
											case 17:
												if (rect.Width > 0)
												{
													num7 = 10;
													continue;
												}
												break;
											case 7:
											case 19:
												ptr2 = (int*)GetMemoryPtr(write: true, out stride2, out nativePixelFormat).ToPointer();
												num7 = 3;
												continue;
											case 20:
												return;
											}
											break;
										}
									}
									jP74Um0TjI54TobO14Y(GetDc(), rEdhhn0AJ2fr0gvbrCo(GwI37q0V0U3eX2Bj8SY(rect)), SetBrush(color));
									return;
								}
							case 4:
								blendFunction.SourceConstantAlpha = color.A;
								num = 14;
								if (true)
								{
									continue;
								}
								goto IL_05ce;
							case 13:
								goto IL_05ce;
							case 16:
								num6 = 0;
								num = 33;
								continue;
							case 25:
								num3 = color.R * a;
								num4 = color.G * a;
								num5 = color.B * a;
								num = 11;
								if (tTQ2oS6fq1OmsPcd1gf())
								{
									continue;
								}
								goto case 17;
							case 17:
								rect.Intersect(new Rectangle(Point.Empty, Size));
								num = 26;
								continue;
							case 29:
								stride /= 4;
								num = 8;
								continue;
							case 11:
								num2 = 0;
								num = 16;
								continue;
							case 24:
								return;
							case 0:
								AlAkrJSWoo = EQYOQX0dT7Kmb9ftx7c(bNukSbtbd1, 1, 1);
								INnkCv5ieH = CnxNativeMethods.SelectObject(bNukSbtbd1, AlAkrJSWoo);
								num = 28;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								ptr += rect.X + rect.Y * stride;
								num = 6;
								continue;
							case 12:
								if (ptr != null)
								{
									num = 15;
									continue;
								}
								goto IL_0675_2;
							case 5:
							case 32:
								Nw5XO2Y5QV = new byte[768];
								num = 2;
								continue;
							case 23:
								ReleaseMemoryPtr();
								num = 24;
								continue;
							case 20:
								b = (byte)(255 - a);
								num = 25;
								continue;
							case 34:
								return;
							}
							if (color.A == byte.MaxValue)
							{
								tTQ2oS6fq1OmsPcd1gf();
								num = (SgX2Q96FmNr0Z9PUqB3() ? 32 : 30);
								continue;
							}
							if (PixelFormat == CnxPixelFormat.Format32bppRgb)
							{
								num = 3;
								continue;
							}
							goto IL_0675_2;
							IL_005e:
							if (nativePixelFormat2 == PixelFormat)
							{
								num = 29;
								continue;
							}
							goto IL_0675_2;
							IL_0675_2:
							if (bNukSbtbd1 == IntPtr.Zero)
							{
								num = 22;
								continue;
							}
							goto IL_01e7;
							continue;
							end_IL_0090:
							break;
						}
						goto IL_0194;
						IL_05ce:
						PDnkN0t6P6(ptr, rect.Width, rect.Height, stride, ptr5);
						break;
						IL_0194:
						NSb8E90iw9xTb8o2HR2(bNukSbtbd1, 0, 0, CnxColorConversion.ColorToGdi(color));
						num = 10;
						if (0 == 0)
						{
							goto IL_0090_2;
						}
						goto IL_01b4;
						IL_01d7:
						bNukSbtbd1 = CnxNativeMethods.CreateCompatibleDC(IntPtr.Zero);
						goto IL_01e7;
						IL_01e7:
						if (AlAkrJSWoo == IntPtr.Zero)
						{
							num = 0;
							goto IL_0090_2;
						}
						goto IL_0194;
						IL_01b4:
						nw5XO2Y5QV = Nw5XO2Y5QV;
						goto end_IL_01bd;
						IL_0235:
						ptr5 = null;
						goto IL_05ce;
						end_IL_01bd:;
					}
				}
				goto IL_05eb;
			}
			case 22:
				bNukSbtbd1 = CnxNativeMethods.CreateCompatibleDC(IntPtr.Zero);
				goto IL_01e7_2;
			case 31:
			case 33:
				if (num6 >= 256)
				{
					num = 17;
					if (true)
					{
						break;
					}
					goto case 26;
				}
				checked
				{
					Nw5XO2Y5QV[num6] = (byte)unchecked(checked(num2 + num3) / 255);
					num = 18;
					break;
				}
			case 26:
				memoryPtr = GetMemoryPtr(write: true, out stride, out nativePixelFormat2);
				num = 19;
				break;
			case 9:
				ptr5 = null;
				goto case 13;
			case 2:
				dmjXpOVsWZ = color.ToArgb();
				a = color.A;
				num = 20;
				break;
			case 14:
				H65ZiV0qls0P8Omwl36(GetDc(), rect.X, rect.Y, rect.Width, rect.Height, bNukSbtbd1, 0, 0, 1, 1, blendFunction);
				num = 34;
				break;
			case 10:
				blendFunction = default;
				num = 4;
				break;
			case 27:
				if (Nw5XO2Y5QV != null)
				{
					goto case 2;
				}
				goto case 5;
			case 1:
			case 30:
				using (CvsTrace.Display.Draw.TraceBlock(kgbOBx7BanbFa22Hp9.ol99ukmDA(44544)))
				{
					if (PixelFormat == CnxPixelFormat.Format32bppRgb)
					{
						num7 = 13;
						while (true)
						{
							switch (num7)
							{
							case 15:
								num10 = color.ToArgb() & 0xFFFFFF;
								goto case 7;
							case 16:
								if (Clip != null)
								{
									num7 = 14;
									continue;
								}
								goto case 4;
							case 13:
								if (Clip != null)
								{
									if (gPGFE50DlK5Ft1PTf8V(Clip))
									{
										num7 = 1;
										continue;
									}
									break;
								}
								goto case 1;
							case 9:
								ptr2 += rect.X + rect.Y * stride2;
								num7 = 12;
								continue;
							case 0:
								if (nativePixelFormat != PixelFormat)
								{
									break;
								}
								num7 = 5;
								if (!SgX2Q96FmNr0Z9PUqB3())
								{
									continue;
								}
								goto case 2;
							case 2:
								num9--;
								goto case 18;
							case 18:
								if (num9 > 0)
								{
									ptr4 = ptr3++;
									*ptr4 = num10;
									num7 = 2;
									if (true)
									{
										continue;
									}
									goto case 9;
								}
								num7 = 8;
								continue;
							case 6:
								if (num8 > 0)
								{
									ptr3 = ptr2;
									num9 = rect.Width;
									num7 = 18;
								}
								else
								{
									ReleaseMemoryPtr();
									num7 = 20;
								}
								continue;
							case 8:
								ptr2 += stride2;
								num7 = 11;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								stride2 /= 4;
								num7 = 9;
								if (tTQ2oS6fq1OmsPcd1gf())
								{
									continue;
								}
								goto case 1;
							case 1:
								rect.Intersect(new Rectangle(Point.Empty, Size));
								num7 = 16;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
							case 12:
								reference = ref rect;
								num8 = reference.Height--;
								num7 = 6;
								continue;
							case 14:
								rect.Intersect(HrfI8i0UU7Fd9airbPm(Clip));
								tTQ2oS6fq1OmsPcd1gf();
								num7 = ((!SgX2Q96FmNr0Z9PUqB3()) ? 17 : 19);
								continue;
							case 10:
								if (rect.Height <= 0)
								{
									break;
								}
								num7 = 15;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								if (ptr2 == null)
								{
									break;
								}
								goto case 0;
							default:
								num7 = 0;
								continue;
							case 4:
							case 17:
								if (rect.Width > 0)
								{
									num7 = 10;
									continue;
								}
								break;
							case 7:
							case 19:
								ptr2 = (int*)GetMemoryPtr(write: true, out stride2, out nativePixelFormat).ToPointer();
								num7 = 3;
								continue;
							case 20:
								return;
							}
							break;
						}
					}
					jP74Um0TjI54TobO14Y(GetDc(), rEdhhn0AJ2fr0gvbrCo(GwI37q0V0U3eX2Bj8SY(rect)), SetBrush(color));
					return;
				}
			case 4:
				blendFunction.SourceConstantAlpha = color.A;
				num = 14;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				PDnkN0t6P6(ptr, rect.Width, rect.Height, stride, ptr5);
				goto IL_05eb;
			case 16:
				num6 = 0;
				num = 33;
				break;
			case 25:
				num3 = color.R * a;
				num4 = color.G * a;
				num5 = color.B * a;
				num = 11;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					break;
				}
				goto case 17;
			case 17:
				rect.Intersect(new Rectangle(Point.Empty, Size));
				num = 26;
				break;
			case 29:
				stride /= 4;
				num = 8;
				break;
			case 11:
				num2 = 0;
				num = 16;
				break;
			case 24:
				return;
			case 0:
				AlAkrJSWoo = EQYOQX0dT7Kmb9ftx7c(bNukSbtbd1, 1, 1);
				INnkCv5ieH = CnxNativeMethods.SelectObject(bNukSbtbd1, AlAkrJSWoo);
				num = 28;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				ptr += rect.X + rect.Y * stride;
				num = 6;
				break;
			case 12:
				if (ptr != null)
				{
					num = 15;
					break;
				}
				goto IL_0675;
			case 5:
			case 32:
				Nw5XO2Y5QV = new byte[768];
				num = 2;
				break;
			case 23:
				ReleaseMemoryPtr();
				num = 24;
				break;
			case 20:
				b = (byte)(255 - a);
				num = 25;
				break;
			case 34:
				return;
				IL_05eb:
				num = 23;
				break;
				IL_0675:
				if (bNukSbtbd1 == IntPtr.Zero)
				{
					num = 22;
					break;
				}
				goto IL_01e7_2;
				IL_01e7_2:
				if (AlAkrJSWoo == IntPtr.Zero)
				{
					num = 0;
					break;
				}
				goto case 28;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void PDnkN0t6P6(int* P_0, int P_1, int P_2, int P_3, byte* P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SgX2Q96FmNr0Z9PUqB3();
		int num = ((!tTQ2oS6fq1OmsPcd1gf()) ? 6 : 3);
		int* ptr = default;
		int num3 = default;
		int num2 = default;
		do
		{
			IL_008b:
			switch (num)
			{
			case 7:
				*(ptr++) = P_4[(num3 & 0xFF) + 512] | (P_4[((num3 & 0xFF00) >> 8) + 256] << 8) | (P_4[(num3 & 0xFF0000) >> 16] << 16);
				break;
			default:
				num = 9;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					goto IL_008b;
				}
				goto case 0;
			case 0:
			case 3:
			case 5:
				if (P_2-- <= 0)
				{
					num = 10;
				}
				else
				{
					ptr = P_0;
					num = 1;
				}
				goto IL_008b;
			case 4:
			case 8:
				if (num2 > 0)
				{
					num3 = *ptr;
					num = 7;
				}
				else
				{
					num = 5;
				}
				goto IL_008b;
			case 1:
				P_0 += P_3;
				goto case 2;
			case 2:
			case 6:
				num2 = P_1;
				num = 4;
				if (!SgX2Q96FmNr0Z9PUqB3())
				{
					goto IL_008b;
				}
				break;
			case 9:
				break;
			case 10:
				return;
			}
			num2--;
			num = 8;
		}
		while (tTQ2oS6fq1OmsPcd1gf());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(IntPtr hdc, Rectangle destination, Point source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CnxNativeMethods.BitBlt(hdc, destination.X, destination.Y, destination.Width, destination.Height, GetDc(), source.X, source.Y, CnxNativeMethods.RasterOp.SRCCOPY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StretchTo(IntPtr hdc, Rectangle destRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tPwHiipJBRElwyLUHjA(hdc, destRect.X, destRect.Y, destRect.Width, destRect.Height, GetDc(), 0, 0, Size.Width, Size.Height, CnxNativeMethods.RasterOp.SRCCOPY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AoGkiR3d6U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (SgX2Q96FmNr0Z9PUqB3())
		{
			goto IL_001e;
		}
		goto IL_0040;
		IL_001e:
		CnxNativeMethods.XFORM lpXform = default;
		lpXform.eM21 /= 100f;
		goto IL_00b7;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				lpXform.eM11 /= 100f;
				goto case 2;
			case 2:
			case 6:
				lpXform.eM12 /= 100f;
				num = 0;
				if (tTQ2oS6fq1OmsPcd1gf())
				{
					continue;
				}
				goto IL_00b7;
			case 4:
				goto IL_00b7;
			case 7:
				CnxNativeMethods.SetWorldTransform(uD8keK0x1J, ref lpXform);
				num = 8;
				continue;
			case 3:
				lpXform = new CnxNativeMethods.XFORM((float[])((WZNkyB8fo1 == null) ? null : sYbdgq0BqdLyuHtHXew(WZNkyB8fo1)));
				if (fkSk2wIdM0)
				{
					_ = 0;
					if (!tTQ2oS6fq1OmsPcd1gf())
					{
						num = 6;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					return;
				}
				goto case 7;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_00b7:
		lpXform.eM22 /= 100f;
		num = 7;
		goto IL_0040;
	}

	public abstract Bitmap ToBitmap();

	public abstract Bitmap CreateBitmap();

	internal abstract IntPtr GetNewHBitmap();

	public abstract void WriteBitmap(ref Stream stm, CnxPixelFormat format);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object GetNativeStorage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReleaseNativeStorage(object storage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReleaseMemoryPtr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WriteBitmap(Stream stm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WriteBitmapHeader(Stream stm, int height)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void WriteBitmapBody(Stream stm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static int GetPixelFormatSize(CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return format switch
		{
			CnxPixelFormat.Format8bppGrayscale => 8, 
			CnxPixelFormat.Format16bppRgb565 => 16, 
			CnxPixelFormat.Format24bppRgb => 24, 
			CnxPixelFormat.Format32bppRgb => 32, 
			_ => throw new ArgumentException((string)WB1PfA6zOWF9gD8cRDJ(44574), kgbOBx7BanbFa22Hp9.ol99ukmDA(44676)), 
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsImageBufferBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		vjkXh7B0ex = new Point(int.MaxValue, int.MinValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K8us196mGkb614VBtJi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tTQ2oS6fq1OmsPcd1gf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SgX2Q96FmNr0Z9PUqB3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WorvpX6ypt5Tjsj2oNO(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qhr0JN6gTB5ANumTGmf(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteDC(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Atw7MJ6ZiWWJipVCU0v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GC.SuppressFinalize(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AXVVdQ6J0cjUSvtr2MJ(object P_0, bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxReferenceCountBase)P_0).Dispose(disposing);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool juVZ5M688QZYJ52oreL(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WB1PfA6zOWF9gD8cRDJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YkvctEpwi0T5lLTBs1T(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceBlock((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fI8G09ps1RgYrKkaS4o(IntPtr hdc, CnxNativeMethods.GraphicsMode Mode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetGraphicsMode(hdc, Mode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ThULo1phlBDrDhQa0KH(IntPtr hdc, int iStretchMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetStretchBltMode(hdc, iStretchMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int m2kUV0pLqyeumNuJisk(IntPtr hdc, CnxNativeMethods.R2 fnDrawMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetROP2(hdc, fnDrawMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Trgu8up97klrqUChHR4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Matrix)P_0).IsIdentity;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr h0Va95pSoyfTlHcHesl(IntPtr hdc, IntPtr hgdiobj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectObject(hdc, hgdiobj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qCSvEEpEJNjE76SxED5(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeletePen(hObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HpRUE6pvcD95AUGIvpx(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteBrush(hObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YYjDOTpHPHxmPy1ey70(object P_0, IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsImageBufferBase)P_0).ReleaseDcCore(hdc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IfIEx9pVHZJsnk3eABc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsImageBufferBase)P_0).OnClipRegionChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr PvdqDZpADnHCwOpiH6j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsClippingRegion)P_0).HRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int P9HynHpDuc1pAkvP4dP(IntPtr hdc, IntPtr hrgn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SelectClipRgn(hdc, hrgn);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OkwUD9pUepV1mPZg7oh(IntPtr hdc, int nXPos, int nYPos)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.GetPixel(hdc, nXPos, nYPos);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int I1QdoJpTpC2nLcIokbN(Color color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxColorConversion.ColorToGdi(color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DvvSaopdYf9pBBI3dsW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size QUmH0apiKKK4H16JaTu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferBase)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color sUuCI1pqKSFjSxPV078()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Black;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qnq5AIpBqEy6Q3irZeX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SystemColors.Control;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color rp8uD8pjUS9Hn14mCIj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SystemColors.ControlLightLight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color c6JmwUpcoS5x9k6imjs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SystemColors.ControlDark;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color i9Uoflp2Cws3m2X4Gq7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SystemColors.ControlDarkDark;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color LY9IXFpWJn5UQWi82I9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SystemColors.ControlLight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float G1Wsqsp7BtNuk8RfX6t(int P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BfhkHANIrL(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HDa6Hrptht09HXmA6ts(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferBase)P_0).GetGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SmoothingMode sX6BwapCB7QbFKOXqIN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Graphics)P_0).SmoothingMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ouJaSqpK4X72DH6fyPQ(object P_0, SmoothingMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).SmoothingMode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Txn4njp5xneRbFM6VBx(object P_0, Color P_1, float P_2, float P_3, double P_4, float P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).DrawArrow(P_1, P_2, P_3, P_4, P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Ggqhphpo4m6C74Zb79Z(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sRcgPEpPUgcUuNkwrYJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lHucy9pYWIlyystJnPq(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color lqRuYppNwn7liCeBCYW(object P_0, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).GetPixel(x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F1PBgRpxeJoqq6rmEtr(object P_0, int x, int y, Color color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICvsImageBuffer)P_0).SetPixel(x, y, color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte DHttTep1PNYq3TZit8X(byte P_0, byte P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FDZGBhprrhpNqqY1RNg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsImageBufferBase)P_0).ReleaseMemoryPtr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cfs0I0p3N2LS3iF9TLf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).GetBuffer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long eaAuqWpOH4SaaskaNkf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oGr4JxpM8NbuHqsWNYu(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int eGSAEdpQhFvqapiw8vG(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jT0pjDplwO0CfBGvCBh(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Mw7Jafpe9wUbKA2j3jp(CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetPixelFormatSize(format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MMRgNrpuOTgjEENtKew(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Array)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GCHandle T1qMOZpIvjkfdWBC4Q2(object P_0, GCHandleType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GCHandle.Alloc(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N6VYQRpR5Ra5XZKyomh(IntPtr destination, CnxPixelFormat destinationFormat, IntPtr source, CnxPixelFormat sourceFormat, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ConvertPixels(destination, destinationFormat, source, sourceFormat, pixelCount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rmesqupaNa4jAvubDR7(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size gBZ3ZCpnQefOfmuyIm0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lcDhLRpG7Q7ycaKTYMd(Size P_0, Size P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vcqBWdpX1cXA9jpYrkf(IntPtr destination, IntPtr source, int length)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CnxNativeMethods.CopyMemory(destination, source, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zgCiW8pbGt6pW5eeCCf(Size size, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsImageBufferFactory.CreateNew(size, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zZZDiFp6CoQQBo8nm8D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ImageUtils.GetImageFormat((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LBHukSppH5eItF8mHTX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).ToBitmap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OitB0tp0pVxeS7wWKci(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).CreateBitmap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q7W6bSp49f3nsFHS5MB(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Save((string)P_1, (ImageFormat)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kMg0SXpkjOmnlE3ylc4(Color P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IweLdopffdDgiNgRhO7(IntPtr hdc, CnxNativeMethods.BkMode iBkMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetBkMode(hdc, iBkMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OOoVJKpFO1R03iPhsS1(Color P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr YXejAUpmxwEA5QK6Vnd(int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateSolidBrush(crColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr L5bEA0pyGiMqAhNohY3(object P_0, float scale)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFont)P_0).GetHTextFont(scale);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mWJs8apgkIGY5ghyjMh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr LZwubmpZAouFOQ5QbdS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsImageBufferBase)P_0).GetDc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tPwHiipJBRElwyLUHjA(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, CnxNativeMethods.RasterOp dwRop)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.StretchBlt(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, nHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, nHeightSrc, dwRop);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wT2nRdp8wIqctm0BMQT(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int hHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int hHeightSrc, int crTransparent)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.TransparentBlt(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, hHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, hHeightSrc, crTransparent);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool svqlfUpzy0dsZg0b0Hy(IntPtr hdc, int X, int Y, IntPtr lpPoint)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.MoveToEx(hdc, X, Y, lpPoint);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IHKvTm0wNPB2kVdl4dL(IntPtr hdc, int nXEnd, int nYEnd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.LineTo(hdc, nXEnd, nYEnd);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sdGCsW0scdYyQx9fZPP(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Array)P_0).CopyTo((Array)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qde2BF0hXsOEKXFErVF(IntPtr hdc, object P_1, int cPoints)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.Polyline(hdc, (Point[])P_1, cPoints);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ntHCAm0Lwt0GcgMU5on(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UQrE4h09mW4Qwat6TXM(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXStartArc, int nYStartArc, int nXEndArc, int nYEndArc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.Arc(hdc, nLeftRect, nTopRect, nRightRect, nBottomRect, nXStartArc, nYStartArc, nXEndArc, nYEndArc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double CbgoAW0S36Q3bArnL7v(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Cos(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int COFHFy0EvuPCh6wWEbG(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e6260j0vcCJ4N5Wp9LF(IntPtr hdc, int X, int Y, int dwRadius, float eStartAngle, float eSweepAngle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.AngleArc(hdc, X, Y, dwRadius, eStartAngle, eSweepAngle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JvDeS30HFHtbRmxxPsA(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.Ellipse(hdc, nLeftRect, nTopRect, nRightRect, nBottomRect);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxRectangle GwI37q0V0U3eX2Bj8SY(Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxNativeMethods.RECT rEdhhn0AJ2fr0gvbrCo(CnxRectangle r)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return r;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gPGFE50DlK5Ft1PTf8V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsClippingRegion)P_0).IsRectangular;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle HrfI8i0UU7Fd9airbPm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsClippingRegion)P_0).GetBounds();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jP74Um0TjI54TobO14Y(IntPtr hDC, CnxNativeMethods.RECT lprc, IntPtr hbr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.FillRect(hDC, lprc, hbr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr EQYOQX0dT7Kmb9ftx7c(IntPtr hdc, int nWidth, int nHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateCompatibleBitmap(hdc, nWidth, nHeight);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NSb8E90iw9xTb8o2HR2(IntPtr hdc, int X, int Y, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.SetPixel(hdc, X, Y, crColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H65ZiV0qls0P8Omwl36(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, CnxNativeMethods.BLENDFUNCTION blendFunction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.AlphaBlend(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, nHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, nHeightSrc, blendFunction);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sYbdgq0BqdLyuHtHXew(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Matrix)P_0).Elements;
	}
}
