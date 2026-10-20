using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace EWWMshcielYPHTNN2p;

internal class P47d6pq2XTTdvapjBq : ISnippetUpdate
{
	private static readonly CvsCellLocation IWGlek1Kdt;

	private static readonly CvsCellLocation Hiel2WDnWD;

	private static readonly CvsCellLocation tcblqk0mBD;

	private readonly AddCellUpdate rl4li9y2tO;

	private readonly LocationUpdate eZGlkCG8Gb;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public P47d6pq2XTTdvapjBq(SnippetLocalizer P_0, CvsFunctionTable P_1, IExpressionConstants P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (yjNwWoj2ixxXe4Y0r7J())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_004d;
			}
		}
		goto IL_007d;
		IL_00a8:
		eZGlkCG8Gb = new LocationUpdate(tcblqk0mBD, Hiel2WDnWD, SnippetUpdateHelper.GetAbsRefLocationOfCell, IWGlek1Kdt, P_1, P_2);
		num = 6;
		goto IL_007d;
		IL_004d:
		rl4li9y2tO = new AddCellUpdate(IWGlek1Kdt, R6klv67DqT, P_0);
		goto IL_00a8;
		IL_007d:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				keegPGj1FeIL7lOhwUw(this);
				break;
			case 2:
			case 4:
				break;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_00a8;
			case 6:
				return;
			}
			break;
		}
		goto IL_004d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (yjNwWoj2ixxXe4Y0r7J())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (!yjNwWoj2ixxXe4Y0r7J())
			{
				goto IL_009e;
			}
		}
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				pasteBuffer = (PasteBuffer)wbvlHxjtFyYgx3EAfCl(eZGlkCG8Gb, pasteBuffer);
				num = 5;
				continue;
			case 1:
			case 2:
				pasteBuffer = (PasteBuffer)ddXovwjhZEquwAmauK7(rl4li9y2tO, pasteBuffer);
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				pasteBuffer = (PasteBuffer)hFZk8Yjujdklpe1q8R6(P_0);
				goto case 1;
			case 5:
				break;
			}
			break;
		}
		goto IL_009e;
		IL_009e:
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell R6klv67DqT(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(IWGlek1Kdt);
		string text = (string)AVlQmXjzfGJ0VjWDemU(P_0, Hiel2WDnWD);
		string expression = (string)nIEKn36LG0tE3Icf6mP(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26038), text);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin)
		{
			Expression = expression
		};
		sDFUoQ6KrSfxM3wO0Ve(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static P47d6pq2XTTdvapjBq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yjNwWoj2ixxXe4Y0r7J();
		int num;
		if (!cZmKMRjc12i5g3V4XoX())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (cZmKMRjc12i5g3V4XoX())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				IWGlek1Kdt = new CvsCellLocation(4, 3);
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				PNhRZi65GsnyOXpCH6K();
				goto case 1;
			case 4:
				tcblqk0mBD = new CvsCellLocation(4, 2);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				Hiel2WDnWD = new CvsCellLocation(4, 0);
				goto case 4;
			default:
				num = 4;
				if (!yjNwWoj2ixxXe4Y0r7J())
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void keegPGj1FeIL7lOhwUw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yjNwWoj2ixxXe4Y0r7J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cZmKMRjc12i5g3V4XoX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hFZk8Yjujdklpe1q8R6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ddXovwjhZEquwAmauK7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wbvlHxjtFyYgx3EAfCl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AVlQmXjzfGJ0VjWDemU(object P_0, CvsCellLocation cellOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.GetAbsRefLocationOfCell((PasteBuffer)P_0, cellOffset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nIEKn36LG0tE3Icf6mP(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sDFUoQ6KrSfxM3wO0Ve(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PNhRZi65GsnyOXpCH6K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
