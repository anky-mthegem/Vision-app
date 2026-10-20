using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class ExpressionEditUpdate : ISnippetUpdate
{
	private readonly Func<PasteBuffer, string, string> A5sKRAaCFM;

	private readonly Func<string, string> BYKK4NMvqV;

	private CvsCellLocation xVgKltJZEk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExpressionEditUpdate(CvsCellLocation offset, Func<PasteBuffer, string, string> expressionFactory, Func<string, string> expressionLocalizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		xVgKltJZEk = offset;
		A5sKRAaCFM = expressionFactory;
		BYKK4NMvqV = expressionLocalizer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sWBA4NtjDFJb120dJWX();
		int num;
		if (!ptFB5qt6dDptRq8YUjh())
		{
			num = 4;
		}
		else
		{
			num = 6;
			if (ptFB5qt6dDptRq8YUjh())
			{
			}
		}
		PasteBuffer pasteBuffer = default;
		CvsCellLocation origin = default;
		PasteBufferCell cellAt = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				pasteBuffer = (PasteBuffer)YC55NatCtER5sGZM1AF(originalSnippet);
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				origin = originalSnippet.Origin;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				origin.Row += xVgKltJZEk.Row;
				num = 7;
				break;
			case 7:
				origin.Column += xVgKltJZEk.Column;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
			case 6:
				bEJermtREo8sMq3mwQq(cellAt, BYKK4NMvqV(A5sKRAaCFM(pasteBuffer, (string)hU6d6YtA5Rr4uVCPGsg(cellAt))));
				num = 8;
				break;
			case 3:
				cellAt = pasteBuffer.GetCellAt(origin);
				goto case 5;
			case 8:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YC55NatCtER5sGZM1AF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hU6d6YtA5Rr4uVCPGsg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bEJermtREo8sMq3mwQq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sWBA4NtjDFJb120dJWX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ptFB5qt6dDptRq8YUjh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
