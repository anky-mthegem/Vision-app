using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class SftpUpdate : ISnippetUpdate
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PasteBufferCell, bool> _003C_003E9__2_0;

		public static Func<PasteBuffer, string, string> _003C_003E9__2_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EAXStQ5v9YdWCGE5Z4nX();
			SDnDIv5v4PvRDDCMeq9w(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CApply_003Eb__2_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CXqN0x5v3vgTrKV93LpG(vWKckk5v7SFEJwmpQ2Ag(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(43214), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CApply_003Eb__2_1(PasteBuffer buffer, string s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)zfwhmL5vjSVBQP61o6qf(54564);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RqYdPb5vplJeRU4K5cxf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FoWuB95vX6y8Re2qdQmy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EAXStQ5v9YdWCGE5Z4nX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SDnDIv5v4PvRDDCMeq9w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vWKckk5v7SFEJwmpQ2Ag(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CXqN0x5v3vgTrKV93LpG(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zfwhmL5vjSVBQP61o6qf(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private readonly SnippetLocalizer wZhKwrkuo9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SftpUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tnT9vhzlQDmhGQQTOI5();
		int num = (goYpLVzguyLfpAyIDYU() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				E5juxxzsSvLvKcI6ZsY();
				goto case 1;
			case 1:
			case 4:
				LfryeHzvnDEapTVFpf1(this);
				break;
			default:
				num = 2;
				continue;
			case 2:
				break;
			case 5:
				return;
			}
			wZhKwrkuo9 = localizer;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!tnT9vhzlQDmhGQQTOI5()) ? 2 : 4);
		CvsCellLocation cvsCellLocation = default;
		PasteBufferCell pasteBufferCell = default;
		CvsCellLocation cvsCellLocation2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				cvsCellLocation = AlgKeIzZahhyVWAduef(originalSnippet, TZBEh3zP5MpMonv2AnE(pasteBufferCell));
				num = 5;
				break;
			case 1:
			case 2:
				pasteBufferCell = originalSnippet.Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.CXqN0x5v3vgTrKV93LpG(_003C_003Ec.vWKckk5v7SFEJwmpQ2Ag(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(43214), StringComparison.Ordinal);
				});
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				cvsCellLocation2 = hRlQ3VzrPu66H88JfRF(originalSnippet);
				goto case 1;
			case 5:
			{
				CvsCellLocation offset = new CvsCellLocation(cvsCellLocation.Row - cvsCellLocation2.Row, cvsCellLocation.Column - cvsCellLocation2.Column);
				Func<PasteBuffer, string, string> expressionFactory = [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer, string s) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)_003C_003Ec.zfwhmL5vjSVBQP61o6qf(54564);
				};
				Func<string, string> expressionLocalizer = [MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)lGTo9DzB6tHeDLgmj2f(wZhKwrkuo9, P_0);
				};
				return new ExpressionEditUpdate(offset, expressionFactory, expressionLocalizer).Apply(originalSnippet);
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string QjbKHESoU4(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)lGTo9DzB6tHeDLgmj2f(wZhKwrkuo9, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E5juxxzsSvLvKcI6ZsY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LfryeHzvnDEapTVFpf1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tnT9vhzlQDmhGQQTOI5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool goYpLVzguyLfpAyIDYU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation hRlQ3VzrPu66H88JfRF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TZBEh3zP5MpMonv2AnE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation AlgKeIzZahhyVWAduef(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lGTo9DzB6tHeDLgmj2f(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetLocalizer)P_0).LocalizeTopLevelExpression((string)P_1);
	}
}
