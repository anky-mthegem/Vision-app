using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ImageFilter;

public class ShowOutputImageUpdate : ISnippetUpdate
{
	private readonly AddCellUpdate vpfRW2SToA;

	private readonly EditArgumentUpdate P5yRjp5RtS;

	private readonly CvsCellLocation fYKRC6qC5d;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShowOutputImageUpdate(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCellLocation offset = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				vpfRW2SToA = new AddCellUpdate(fYKRC6qC5d, F5WRluShIG, localizer);
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 2:
				fYKRC6qC5d = new CvsCellLocation(6, 7);
				goto case 0;
			case 6:
				bwkCFn4HRWtAhpJb1uT();
				num = 7;
				break;
			case 5:
				offset = new CvsCellLocation(6, 0);
				num = 4;
				if (zu2JJg4ULVdmCTpp6hn())
				{
				}
				break;
			case 7:
				ItDBeE4xkdLZG2fVB1G(this);
				zu2JJg4ULVdmCTpp6hn();
				num = (mMZ6Mj4YptYWYhRw5Eq() ? 1 : 0);
				break;
			case 4:
				P5yRjp5RtS = new EditArgumentUpdate(offset, MyDRTbcBKS, 18, null);
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell F5WRluShIG(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = (string)oN3Qoi4mkTamnOeVruH(P_0);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(fYKRC6qC5d);
		sN9Xmm4NVi8WpTF6L9t(pasteBufferCell, p68enu4Q3KSpmRreRAa(24872));
		aaxxFS42vkQ17rbgDld(pasteBufferCell, EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24930)));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string MyDRTbcBKS(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mMZ6Mj4YptYWYhRw5Eq();
		int num = (zu2JJg4ULVdmCTpp6hn() ? 2 : 6);
		CvsCellLocation cvsCellLocation = default;
		PasteBufferCell cellInTool3 = default;
		PasteBufferCell cellInTool = default;
		string text2 = default;
		string text = default;
		string text4 = default;
		string text3 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				cvsCellLocation = WlV9f44uv9CPtAjZ3Gn(rPBtfL4h6U8tVR6AmtK(cellInTool3));
				num = 8;
				break;
			case 0:
			case 6:
				CvsParse.FindAllArgs((string)xbM3BE4cT3d1LdeN7aY(SnippetPasteBuffer.GetCellInTool(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24642)))).Count();
				goto case 1;
			case 1:
			case 2:
			{
				PasteBufferCell cellInTool2 = SnippetPasteBuffer.GetCellInTool(P_0, (string)p68enu4Q3KSpmRreRAa(24964), isInternal: true);
				cellInTool = SnippetPasteBuffer.GetCellInTool(P_0, (string)p68enu4Q3KSpmRreRAa(8420));
				cellInTool3 = SnippetPasteBuffer.GetCellInTool(P_0, (string)p68enu4Q3KSpmRreRAa(24986), isInternal: true);
				CvsCellLocation location = KlE7Zs41vxHnMNQ1wcl(P_0).Location;
				location.Row += fYKRC6qC5d.Row;
				location.Column += fYKRC6qC5d.Column;
				text2 = location.ToString(absoluteRow: true, absoluteColumn: true);
				cvsCellLocation = WlV9f44uv9CPtAjZ3Gn(cellInTool2.Location);
				num = 3;
				break;
			}
			case 5:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 7;
				break;
			case 8:
				text4 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 9;
				break;
			case 3:
				text3 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 4;
				if (mMZ6Mj4YptYWYhRw5Eq())
				{
					break;
				}
				goto case 4;
			case 4:
				cvsCellLocation = WlV9f44uv9CPtAjZ3Gn(rPBtfL4h6U8tVR6AmtK(cellInTool));
				goto case 5;
			default:
				num = 5;
				break;
			case 9:
				return (string)JcEoV64tfT9BZDZVWQr(new string[8]
				{
					text,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18556),
					text2,
					(string)p68enu4Q3KSpmRreRAa(17770),
					text3,
					(string)p68enu4Q3KSpmRreRAa(17770),
					text4,
					(string)p68enu4Q3KSpmRreRAa(6970)
				});
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
		PasteBuffer pasteBuffer = vpfRW2SToA.Apply(originalSnippet);
		return (PasteBuffer)X0b8wL4zfq9ELLuo4aK(P5yRjp5RtS, pasteBuffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bwkCFn4HRWtAhpJb1uT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ItDBeE4xkdLZG2fVB1G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mMZ6Mj4YptYWYhRw5Eq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zu2JJg4ULVdmCTpp6hn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oN3Qoi4mkTamnOeVruH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p68enu4Q3KSpmRreRAa(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sN9Xmm4NVi8WpTF6L9t(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aaxxFS42vkQ17rbgDld(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xbM3BE4cT3d1LdeN7aY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange KlE7Zs41vxHnMNQ1wcl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation WlV9f44uv9CPtAjZ3Gn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rPBtfL4h6U8tVR6AmtK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JcEoV64tfT9BZDZVWQr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X0b8wL4zfq9ELLuo4aK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditArgumentUpdate)P_0).Apply((PasteBuffer)P_1);
	}
}
