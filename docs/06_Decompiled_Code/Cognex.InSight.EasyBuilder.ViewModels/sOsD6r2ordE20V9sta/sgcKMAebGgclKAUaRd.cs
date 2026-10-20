using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace sOsD6r2ordE20V9sta;

internal class sgcKMAebGgclKAUaRd : ISnippetUpdate
{
	private static readonly CvsCellLocation tA0l5WSXKp;

	private static readonly CvsCellLocation hZdlpu9cWx;

	private static readonly CvsCellLocation aH6lU3CUw2;

	private readonly AddCellUpdate ggil7kbuDP;

	private readonly LocationUpdate UsWlNWdLJi;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public sgcKMAebGgclKAUaRd(SnippetLocalizer P_0, CvsFunctionTable P_1, IExpressionConstants P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AQ5rk8jPRaglwWtwHs7() ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				UvwsgYjZgvRRQNVnHmq();
				break;
			case 3:
				UsWlNWdLJi = new LocationUpdate(aH6lU3CUw2, hZdlpu9cWx, SnippetUpdateHelper.GetAbsRefLocationOfCell, tA0l5WSXKp, P_1, P_2);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				ggil7kbuDP = new AddCellUpdate(tA0l5WSXKp, uDFlaRSxEv, P_0);
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 1:
			case 4:
				break;
			case 6:
				return;
			}
			base._002Ector();
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				pasteBuffer = (PasteBuffer)DfTPbujbv0PdW0WjX1M(ggil7kbuDP, pasteBuffer);
				goto default;
			case 4:
				do
				{
					pasteBuffer = (PasteBuffer)C9qvs6jB0fq7yZ8qoMj(P_0);
					_ = 1;
					if (AQ5rk8jPRaglwWtwHs7())
					{
						num = 0;
						continue;
					}
					num = 3;
					break;
				}
				while (1 == 0);
				break;
			default:
				pasteBuffer = UsWlNWdLJi.Apply(pasteBuffer);
				num = 5;
				if (AQ5rk8jPRaglwWtwHs7())
				{
				}
				break;
			case 5:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell uDFlaRSxEv(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(tA0l5WSXKp);
		string absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, hZdlpu9cWx);
		string expression = (string)ODmqpYjGUgN4vH6prVt(CdQUGaROfy7He9T0foW.KbIzwHEDLa(25782), absRefLocationOfCell);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin)
		{
			Expression = expression
		};
		gTG8ZFjodcXMsRlbI8h(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static sgcKMAebGgclKAUaRd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				UvwsgYjZgvRRQNVnHmq();
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				hZdlpu9cWx = new CvsCellLocation(4, 0);
				break;
			case 4:
				tA0l5WSXKp = new CvsCellLocation(4, 3);
				AQ5rk8jPRaglwWtwHs7();
				if (!B4CjhBjr4jSNu82KUIY())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (B4CjhBjr4jSNu82KUIY())
				{
					continue;
				}
				break;
			case 6:
				return;
			}
			aH6lU3CUw2 = new CvsCellLocation(4, 2);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UvwsgYjZgvRRQNVnHmq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B4CjhBjr4jSNu82KUIY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AQ5rk8jPRaglwWtwHs7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C9qvs6jB0fq7yZ8qoMj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DfTPbujbv0PdW0WjX1M(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ODmqpYjGUgN4vH6prVt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gTG8ZFjodcXMsRlbI8h(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}
}
