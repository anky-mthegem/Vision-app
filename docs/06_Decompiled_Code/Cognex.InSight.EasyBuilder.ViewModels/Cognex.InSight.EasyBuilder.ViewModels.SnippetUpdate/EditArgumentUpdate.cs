using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class EditArgumentUpdate : ISnippetUpdate
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string newArg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v8jGM35vdA2dp7VpbUWu();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__0(PasteBuffer _)
		{
			while (false)
			{
				object obj = ((object[])null)[0];
			}
			return newArg;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void v8jGM35vdA2dp7VpbUWu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cINXnn5vVAg11oKrkyav()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y5TUrk5vfj55ISZrkG8x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ExpressionEditUpdate G48KIer7TZ;

	private readonly int z6YKfec2lx;

	private readonly SnippetLocalizer G5MKEEWapm;

	private readonly bool JX5Kb3ZXvk;

	private readonly Func<PasteBuffer, string> XLSKc5bt9V;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditArgumentUpdate(CvsCellLocation offset, string newArg, int argIndex, SnippetLocalizer localizer, bool ignoreInvalidArgIndex = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (HWrqqQtGP95PkrruWEp())
		{
			num = 5;
		}
		else
		{
			num = 10;
			if (!HWrqqQtGP95PkrruWEp())
			{
				goto IL_0136;
			}
		}
		goto IL_003d;
		IL_003d:
		_003C_003Ec__DisplayClass5_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				z6YKfec2lx = argIndex;
				goto case 9;
			default:
				num = 9;
				continue;
			case 7:
				JX5Kb3ZXvk = ignoreInvalidArgIndex;
				num = 3;
				if (HWrqqQtGP95PkrruWEp())
				{
					continue;
				}
				goto case 9;
			case 9:
				G5MKEEWapm = localizer;
				num = 7;
				continue;
			case 6:
				G48KIer7TZ = new ExpressionEditUpdate(offset, JxVKDt6HHi, mrBK3qwnKb);
				num = 11;
				if (zQRCUetorMxl6WkIfXV())
				{
				}
				continue;
			case 8:
				obj.newArg = newArg;
				num = 2;
				continue;
			case 2:
				base._002Ector();
				num = 4;
				continue;
			case 3:
				XLSKc5bt9V = obj._003C_002Ector_003Eb__0;
				num = 6;
				continue;
			case 0:
			case 5:
				gZDx2ZtS77rU2Tnqc8o();
				break;
			case 1:
			case 10:
				break;
			case 11:
				return;
			}
			break;
		}
		goto IL_0136;
		IL_0136:
		obj = new _003C_003Ec__DisplayClass5_0();
		num = 8;
		goto IL_003d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditArgumentUpdate(CvsCellLocation offset, Func<PasteBuffer, string> argFactory, int argIndex, SnippetLocalizer localizer, bool ignoreInvalidArgIndex = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		z6YKfec2lx = argIndex;
		G5MKEEWapm = localizer;
		JX5Kb3ZXvk = ignoreInvalidArgIndex;
		XLSKc5bt9V = argFactory;
		G48KIer7TZ = new ExpressionEditUpdate(offset, JxVKDt6HHi, mrBK3qwnKb);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string JxVKDt6HHi(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zQRCUetorMxl6WkIfXV();
		int num = ((!HWrqqQtGP95PkrruWEp()) ? 4 : 3);
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				text = CvsParse.ReplaceArg(P_1, z6YKfec2lx, XLSKc5bt9V(P_0));
				goto case 1;
			case 1:
			case 4:
				if (text != null)
				{
					break;
				}
				goto case 2;
			default:
				num = 2;
				if (zQRCUetorMxl6WkIfXV())
				{
				}
				continue;
			case 2:
				if (JX5Kb3ZXvk)
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				return P_1;
			}
			break;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string mrBK3qwnKb(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HWrqqQtGP95PkrruWEp();
		int num = (zQRCUetorMxl6WkIfXV() ? 1 : 7);
		string text2 = default;
		string text = default;
		while (true)
		{
			object obj;
			SnippetLocalizer g5MKEEWapm;
			switch (num)
			{
			case 6:
				if (JX5Kb3ZXvk)
				{
					num = 3;
					break;
				}
				goto IL_0085;
			case 2:
				if (text2 == null)
				{
					num = 6;
					break;
				}
				goto IL_0085;
			case 0:
			case 7:
				text2 = CvsParse.FindArg(P_0, z6YKfec2lx);
				num = 2;
				break;
			case 1:
			case 5:
				obj = text2;
				goto IL_0065;
			case 3:
				return P_0;
			default:
				num = 4;
				break;
			case 4:
				obj = null;
				goto IL_00e3;
			case 8:
				{
					return (string)MmrEE7t8ipkDmHfaJf9(P_0, z6YKfec2lx, text);
				}
				IL_0065:
				text = (string)obj;
				XXLU3btkPewL5CHo67H(text2, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1544));
				num = 8;
				if (true)
				{
					break;
				}
				goto case 3;
				IL_0085:
				g5MKEEWapm = G5MKEEWapm;
				if (g5MKEEWapm == null)
				{
					goto case 4;
				}
				obj = g5MKEEWapm.LocalizeArg(text2);
				goto IL_00e3;
				IL_00e3:
				if (obj == null)
				{
					goto case 1;
				}
				goto IL_0065;
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
		return (PasteBuffer)i0hR5ctqOJkZTDM7KnT(G48KIer7TZ, originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gZDx2ZtS77rU2Tnqc8o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HWrqqQtGP95PkrruWEp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zQRCUetorMxl6WkIfXV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XXLU3btkPewL5CHo67H(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MmrEE7t8ipkDmHfaJf9(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i0hR5ctqOJkZTDM7KnT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ExpressionEditUpdate)P_0).Apply((PasteBuffer)P_1);
	}
}
