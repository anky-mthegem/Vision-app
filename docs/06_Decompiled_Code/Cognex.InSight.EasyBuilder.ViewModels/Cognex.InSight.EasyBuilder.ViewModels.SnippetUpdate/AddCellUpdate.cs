using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class AddCellUpdate : ISnippetUpdate
{
	private readonly Func<PasteBuffer, PasteBufferCell> Tmds1YQRGH;

	private readonly Func<PasteBuffer, CvsCellLocation, PasteBufferCell> vx3sztRAhe;

	private readonly CvsCellLocation RmGKaaltQK;

	private readonly CvsCellLocation Al9K50KuCE;

	private readonly bool wEeKpg1XQQ;

	private readonly SnippetLocalizer PkbKUZK22r;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddCellUpdate(CvsCellLocation offset, Func<PasteBuffer, PasteBufferCell> cellFactory, SnippetLocalizer localizer, bool replaceCell = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		RmGKaaltQK = offset;
		Tmds1YQRGH = cellFactory;
		wEeKpg1XQQ = replaceCell;
		PkbKUZK22r = localizer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddCellUpdate(CvsCellLocation offset, Func<PasteBuffer, CvsCellLocation, PasteBufferCell> cellFactory, CvsCellLocation cellFactoryCellOffset, SnippetLocalizer localizer, bool replaceCell = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		RmGKaaltQK = offset;
		vx3sztRAhe = cellFactory;
		Al9K50KuCE = cellFactoryCellOffset;
		wEeKpg1XQQ = replaceCell;
		PkbKUZK22r = localizer;
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
		goto IL_00ef;
		IL_001a:
		PasteBufferCell pasteBufferCell = default;
		PkbKUZK22r.Localize(pasteBufferCell);
		num = 11;
		goto IL_00ef;
		IL_00ef:
		CvsCellLocation rmGKaaltQK = default;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				break;
			case 0:
				rmGKaaltQK = RmGKaaltQK;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				rmGKaaltQK.Row += qjfpkThzpx00dgJ1whs(originalSnippet).Row;
				T3JEGyhtxgEvsuqXdZe();
				if (l7Zg9dhhG2boFJivLHP())
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 9;
				}
				num = 6;
				continue;
			case 9:
				pasteBuffer.AddCell(pasteBufferCell);
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				S3IfIlt5uW7WikPlFWG(pasteBufferCell, rmGKaaltQK.ToString());
				num = 9;
				continue;
			case 7:
				rmGKaaltQK.Column += qjfpkThzpx00dgJ1whs(originalSnippet).Column;
				num = 4;
				continue;
			case 2:
				if (wEeKpg1XQQ)
				{
					goto default;
				}
				return originalSnippet;
			case 1:
			case 3:
				if (TsJSpltLRASUhejRkrG(originalSnippet, rmGKaaltQK))
				{
					num = 2;
					continue;
				}
				goto default;
			default:
				pasteBuffer = (PasteBuffer)p3DN8CtKoTB6rEKCK5p(originalSnippet);
				pasteBufferCell = waDsmJxdjH(pasteBuffer);
				num = 8;
				continue;
			case 11:
				return pasteBuffer;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell waDsmJxdjH(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vx3sztRAhe?.Invoke(P_0, Al9K50KuCE) ?? Tmds1YQRGH(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation qjfpkThzpx00dgJ1whs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TsJSpltLRASUhejRkrG(object P_0, CvsCellLocation offsetLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Contains(offsetLoc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p3DN8CtKoTB6rEKCK5p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S3IfIlt5uW7WikPlFWG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Location = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l7Zg9dhhG2boFJivLHP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T3JEGyhtxgEvsuqXdZe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
