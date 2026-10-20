using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class PngUpdate : ISnippetUpdate
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
			URWHjm5vS9BRARM6C4Tx();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			gIATLY5vkWFHBfECVcIp(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CApply_003Eb__2_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JEr2eX5vqVvlF0qgR5bu(UiixWG5v8DoMUu7x47E2(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(36482), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CApply_003Eb__2_1(PasteBuffer buffer, string s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)LIZLGw5vEwfmqFaOEHYX(54506);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void URWHjm5vS9BRARM6C4Tx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YLUbSr5vGIns1OuZdGuT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BjgBdK5voh3aksRp65P4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gIATLY5vkWFHBfECVcIp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UiixWG5v8DoMUu7x47E2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JEr2eX5vqVvlF0qgR5bu(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LIZLGw5vEwfmqFaOEHYX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private readonly SnippetLocalizer TfMKOiV0tE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PngUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (HJHqBkzIDbovBZE3VLo() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				TfMKOiV0tE = localizer;
				num = 5;
				break;
			case 4:
				oM9N62ziVZg2Fw2QNil(this);
				goto default;
			case 0:
			case 3:
				QNQaqDzDFQYpott7rPv();
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
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
		goto IL_005a;
		IL_001a:
		PasteBufferCell pasteBufferCell = originalSnippet.Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.JEr2eX5vqVvlF0qgR5bu(_003C_003Ec.UiixWG5v8DoMUu7x47E2(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(36482), StringComparison.Ordinal);
		});
		goto IL_0087;
		IL_005a:
		CvsCellLocation cvsCellLocation = default;
		CvsCellLocation cvsCellLocation2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				goto IL_0087;
			case 0:
				cvsCellLocation = hjcRN8zniPfgu7Pa3PA(originalSnippet);
				HJHqBkzIDbovBZE3VLo();
				if (!DbEOWZzOtZj5yjk6NYf())
				{
					num = 4;
					continue;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
			{
				CvsCellLocation offset = new CvsCellLocation(cvsCellLocation2.Row - cvsCellLocation.Row, cvsCellLocation2.Column - cvsCellLocation.Column);
				Func<PasteBuffer, string, string> expressionFactory = [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer, string s) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)_003C_003Ec.LIZLGw5vEwfmqFaOEHYX(54506);
				};
				Func<string, string> expressionLocalizer = [MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)StbyiBzdSW5YTysoZyF(TfMKOiV0tE, P_0);
				};
				return new ExpressionEditUpdate(offset, expressionFactory, expressionLocalizer).Apply(originalSnippet);
			}
			}
			break;
		}
		goto IL_001a;
		IL_0087:
		cvsCellLocation2 = dEjOfMzfJyg04CpSBHr(originalSnippet, XqVcAvzVs4ZRgoc360Z(pasteBufferCell));
		num = 5;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string NeLKC05fDp(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)StbyiBzdSW5YTysoZyF(TfMKOiV0tE, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QNQaqDzDFQYpott7rPv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oM9N62ziVZg2Fw2QNil(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DbEOWZzOtZj5yjk6NYf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HJHqBkzIDbovBZE3VLo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation hjcRN8zniPfgu7Pa3PA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XqVcAvzVs4ZRgoc360Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation dEjOfMzfJyg04CpSBHr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StbyiBzdSW5YTysoZyF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetLocalizer)P_0).LocalizeTopLevelExpression((string)P_1);
	}
}
