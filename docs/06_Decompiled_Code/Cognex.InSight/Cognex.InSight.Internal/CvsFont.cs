using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Cnx.Implementation;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsFont : IDisposable
{
	private static readonly CvsFontCache Yq2W9knOp9;

	private Font wQ0WUHKN8p;

	private IntPtr zt0W0sjdyA;

	private float abMWw7nsMm;

	private static string zMXWRAG0os;

	private static bool UIDWsMM39M;

	private static FontFamily vr7W6eId77;

	public readonly int TextFontAscent;

	public readonly int TextFontDescent;

	public readonly int MaxFontHeight;

	public readonly int MaxOverhang;

	public readonly int LineSpacing;

	public Font TextFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wQ0WUHKN8p;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsFont CreateInstance(Font font, bool canDisposeFontIfUnused = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SFoqPvaMLxqj5wnUhe9();
		int num = ((!UgdL5DaOhT1e4QZFZuT()) ? 3 : 2);
		bool lockTaken = default;
		CvsFontCache yq2W9knOp = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0055;
			case 0:
			case 2:
				yq2W9knOp = Yq2W9knOp9;
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_0055:
			num = 4;
		}
		try
		{
			Monitor.Enter(yq2W9knOp, ref lockTaken);
			return Yq2W9knOp9.GetOrCreate(font, canDisposeFontIfUnused);
		}
		finally
		{
			if (lockTaken)
			{
				GjIUSYaQXCGKYertO0N(yq2W9knOp);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsFont(Font font)
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
		goto IL_01ed;
		IL_001a:
		MaxOverhang = lfcgOja0DuPI8ulBKGv((double)TextFontAscent * 0.25);
		num = 18;
		goto IL_01ed;
		IL_01ed:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 15:
				break;
			case 8:
				zMXWRAG0os = (string)jYYbFLaRFks4oBMb6SN(36622);
				vr7W6eId77 = new FontFamily(text);
				num = 6;
				continue;
			case 14:
				wQ0WUHKN8p = font;
				num = 13;
				continue;
			case 16:
				text = (string)WCyDXeaIW81U5HqXLXs();
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				MaxFontHeight = TextFontAscent + TextFontDescent;
				LineSpacing = F0NJuna6ixr2cNLSbMh(G3ZWnCkZKv(wQ0WUHKN8p), MaxFontHeight);
				num = 7;
				continue;
			case 0:
				if (!W26ySNaGF7THymxEfcy(j8QmqianMrWAtllQnXL(font), zMXWRAG0os))
				{
					goto case 14;
				}
				_ = 1;
				if (!SFoqPvaMLxqj5wnUhe9())
				{
					num = 4;
					if (UgdL5DaOhT1e4QZFZuT())
					{
						continue;
					}
					goto case 9;
				}
				num = 3;
				continue;
			case 9:
				if (Environment.OSVersion.Version.Major == 5)
				{
					num = 11;
					if (SFoqPvaMLxqj5wnUhe9())
					{
					}
					continue;
				}
				goto case 6;
			case 4:
			case 10:
				font = new Font(vr7W6eId77, qMuaiDaXbfU5i8hM3MQ(font), font.Style, font.Unit, XWoQe9abtnhVSnwoPb1(font));
				num = 14;
				continue;
			case 12:
				if (!UIDWsMM39M)
				{
					UIDWsMM39M = true;
					num = 9;
					continue;
				}
				goto case 6;
			case 17:
				base._002Ector();
				num = 12;
				if (UgdL5DaOhT1e4QZFZuT())
				{
					continue;
				}
				goto case 7;
			case 7:
				if (qkEDIFaptrkgQsYxiZj(font))
				{
					break;
				}
				return;
			case 1:
				if (tqBpAnaabIEio0YHM4e(text, jYYbFLaRFks4oBMb6SN(36622)))
				{
					num = 8;
					continue;
				}
				goto case 6;
			case 11:
				if (jWgvmtaul1vciOH3Ybx(((OperatingSystem)AsrKovae1FfvOpo0ruh()).Version) == 0)
				{
					num = 16;
					continue;
				}
				goto case 6;
			case 6:
				if (zMXWRAG0os == null)
				{
					goto case 14;
				}
				goto case 0;
			default:
				num = 0;
				continue;
			case 5:
				KDuru8alM0ATIujprwo();
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 13;
			case 13:
				TextFontAscent = KgAW7cV2s5(wQ0WUHKN8p);
				TextFontDescent = n99Wm4pi4l(wQ0WUHKN8p);
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 18:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~CvsFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			xPaWcbtG1A(_0020: false);
		}
		finally
		{
			Byx2gaa4fIqhDmg0ikp(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDefaultFontName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (!W26ySNaGF7THymxEfcy(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(6250)))
				{
					_ = 0;
					if (UgdL5DaOhT1e4QZFZuT())
					{
						num = 5;
						if (UgdL5DaOhT1e4QZFZuT())
						{
							continue;
						}
						break;
					}
					num = 8;
					continue;
				}
				text2 = (string)jYYbFLaRFks4oBMb6SN(41900);
				num = 1;
				continue;
			case 6:
				if (!(text == (string)jYYbFLaRFks4oBMb6SN(6234)))
				{
					num = 0;
					continue;
				}
				text2 = (string)jYYbFLaRFks4oBMb6SN(41876);
				num = 2;
				continue;
			case 3:
			case 5:
				if (text == (string)jYYbFLaRFks4oBMb6SN(6242))
				{
					text2 = kgbOBx7BanbFa22Hp9.ol99ukmDA(41916);
					num = 9;
					continue;
				}
				goto default;
			case 7:
				text = (string)s3Prj3afsl2HHwQOPF7(EUuEtqak82gvQTGW2et());
				num = 6;
				continue;
			default:
				return (string)jYYbFLaRFks4oBMb6SN(36622);
			case 1:
			case 2:
			case 9:
				break;
			}
			break;
		}
		try
		{
			Font font = new Font(text2, 9f);
			if (!mAjc5camLdH4HjvG2g0(((FontFamily)m251XoaFrYqa4iISBZw(font)).GetName(1033), text2))
			{
				text2 = kgbOBx7BanbFa22Hp9.ol99ukmDA(36622);
			}
			font.Dispose();
		}
		catch
		{
			text2 = (string)jYYbFLaRFks4oBMb6SN(36622);
		}
		return text2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xPaWcbtG1A(_0020: true);
		W9VUGUay2ME00oi6TdE(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xPaWcbtG1A(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SFoqPvaMLxqj5wnUhe9();
		int num;
		if (UgdL5DaOhT1e4QZFZuT())
		{
			num = 2;
			if (SFoqPvaMLxqj5wnUhe9())
			{
			}
		}
		else
		{
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (Xr2gClag2pJHIC9nrBV(zt0W0sjdyA, IntPtr.Zero))
				{
					goto case 1;
				}
				goto case 4;
			case 5:
				if (wQ0WUHKN8p != null)
				{
					num = 3;
					break;
				}
				return;
			case 1:
			case 6:
				x2DB54aZtjCMQ2W817g(zt0W0sjdyA);
				num = 8;
				break;
			case 7:
				wQ0WUHKN8p = null;
				num = 9;
				break;
			case 4:
				if (P_0)
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				break;
			case 3:
				jLtuU5aJ8C32MpFLIM2(wQ0WUHKN8p);
				num = 7;
				break;
			case 8:
				zt0W0sjdyA = IntPtr.Zero;
				num = 4;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntPtr GetHTextFont(float scale)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!SFoqPvaMLxqj5wnUhe9())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				zt0W0sjdyA = iUkXowazATknPbp8ukl(wQ0WUHKN8p, scale);
				num = 5;
				continue;
			case 4:
				AfAW5kxCDD(scale);
				UgdL5DaOhT1e4QZFZuT();
				num = ((!SFoqPvaMLxqj5wnUhe9()) ? 3 : 0);
				continue;
			case 1:
			case 3:
				if (!V0G3IBa8iaQrhXtjPbC(zt0W0sjdyA, IntPtr.Zero))
				{
					break;
				}
				goto default;
			case 5:
				break;
			}
			break;
		}
		return zt0W0sjdyA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AfAW5kxCDD(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SFoqPvaMLxqj5wnUhe9();
		int num = ((!UgdL5DaOhT1e4QZFZuT()) ? 2 : 6);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				if (abMWw7nsMm != P_0)
				{
					goto case 1;
				}
				return;
			case 4:
				zt0W0sjdyA = IntPtr.Zero;
				num = 7;
				break;
			case 3:
				if (zt0W0sjdyA != IntPtr.Zero)
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				if (!SFoqPvaMLxqj5wnUhe9())
				{
					break;
				}
				goto case 5;
			case 5:
				x2DB54aZtjCMQ2W817g(zt0W0sjdyA);
				num = 4;
				break;
			case 1:
			case 2:
				abMWw7nsMm = P_0;
				num = 3;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IntPtr l0KWYjswI8(Font P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UgdL5DaOhT1e4QZFZuT();
		int num = (SFoqPvaMLxqj5wnUhe9() ? 2 : 6);
		CnxNativeMethods.LOGFONT lOGFONT = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				P_0.ToLogFont(lOGFONT);
				num = 1;
				continue;
			case 1:
				if (P_1 != 1f)
				{
					goto default;
				}
				goto case 4;
			case 0:
			case 6:
				lOGFONT = new CnxNativeMethods.LOGFONT();
				num = 5;
				if (UgdL5DaOhT1e4QZFZuT())
				{
					continue;
				}
				goto default;
			default:
				lOGFONT.lfHeight = aOVK8dnwSJROKwlmXRs((float)lOGFONT.lfHeight * P_1);
				num = 4;
				continue;
			case 4:
				lOGFONT.lfQuality = CnxNativeMethods.LogFontQuality.NONANTIALIASED_QUALITY;
				num = 7;
				if (UgdL5DaOhT1e4QZFZuT())
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return FvfADInsVOgmm6CQ0c5(lOGFONT);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int KgAW7cV2s5(Font P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		float num = qTmRAAnhqtno3bGSFLY(m251XoaFrYqa4iISBZw(P_0), P_0.Style);
		float num2 = NFvB6hn9mVJJSkJi0JW(m251XoaFrYqa4iISBZw(P_0), pRkLkLnLulgowYwTfTH(P_0));
		return (int)vyhKFcnS0dZepUciwt1(qMuaiDaXbfU5i8hM3MQ(P_0) * (num / num2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int n99Wm4pi4l(Font P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		float num = cxlxAYnEOStN8pwtI1w(P_0.FontFamily, pRkLkLnLulgowYwTfTH(P_0));
		float num2 = NFvB6hn9mVJJSkJi0JW(m251XoaFrYqa4iISBZw(P_0), pRkLkLnLulgowYwTfTH(P_0));
		return (int)vyhKFcnS0dZepUciwt1(P_0.Size * (num / num2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int G3ZWnCkZKv(Font P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (int)vyhKFcnS0dZepUciwt1(hGB2pHnvugNLadQxwD3(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KDuru8alM0ATIujprwo();
		Yq2W9knOp9 = new CvsFontCache([MethodImpl(MethodImplOptions.NoInlining)] (Font f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFont(f);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GjIUSYaQXCGKYertO0N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UgdL5DaOhT1e4QZFZuT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SFoqPvaMLxqj5wnUhe9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KDuru8alM0ATIujprwo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AsrKovae1FfvOpo0ruh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Environment.OSVersion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jWgvmtaul1vciOH3Ybx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Version)P_0).Minor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WCyDXeaIW81U5HqXLXs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetDefaultFontName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jYYbFLaRFks4oBMb6SN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tqBpAnaabIEio0YHM4e(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j8QmqianMrWAtllQnXL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W26ySNaGF7THymxEfcy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float qMuaiDaXbfU5i8hM3MQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte XWoQe9abtnhVSnwoPb1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).GdiCharSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int F0NJuna6ixr2cNLSbMh(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qkEDIFaptrkgQsYxiZj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Italic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lfcgOja0DuPI8ulBKGv(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Byx2gaa4fIqhDmg0ikp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0.Finalize();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EUuEtqak82gvQTGW2et()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s3Prj3afsl2HHwQOPF7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CultureInfo)P_0).TwoLetterISOLanguageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m251XoaFrYqa4iISBZw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).FontFamily;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mAjc5camLdH4HjvG2g0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W9VUGUay2ME00oi6TdE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GC.SuppressFinalize(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xr2gClag2pJHIC9nrBV(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool x2DB54aZtjCMQ2W817g(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.DeleteFont(hObject);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jLtuU5aJ8C32MpFLIM2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Font)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V0G3IBa8iaQrhXtjPbC(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr iUkXowazATknPbp8ukl(object P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return l0KWYjswI8((Font)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aOVK8dnwSJROKwlmXRs(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr FvfADInsVOgmm6CQ0c5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxNativeMethods.CreateFontIndirect((CnxNativeMethods.LOGFONT)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qTmRAAnhqtno3bGSFLY(object P_0, FontStyle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FontFamily)P_0).GetCellAscent(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FontStyle pRkLkLnLulgowYwTfTH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Style;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NFvB6hn9mVJJSkJi0JW(object P_0, FontStyle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FontFamily)P_0).GetEmHeight(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vyhKFcnS0dZepUciwt1(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Ceiling(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cxlxAYnEOStN8pwtI1w(object P_0, FontStyle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FontFamily)P_0).GetCellDescent(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float hGB2pHnvugNLadQxwD3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).GetHeight();
	}
}
