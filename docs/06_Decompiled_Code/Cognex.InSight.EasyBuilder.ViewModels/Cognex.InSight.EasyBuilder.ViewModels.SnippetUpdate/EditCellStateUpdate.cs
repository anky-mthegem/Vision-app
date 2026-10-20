using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class EditCellStateUpdate : ISnippetUpdate
{
	private readonly SnippetLocalizer IIdKQ5Gu0C;

	private readonly string upqKgcgYYl;

	private CvsCellLocation lsUKMLeJ6C;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditCellStateUpdate(CvsCellLocation offset, string newState, SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!QCNDCPtpiPH295xhyQD())
		{
			num = 2;
			if (QCNDCPtpiPH295xhyQD())
			{
			}
		}
		else
		{
			num = 6;
			if (QCNDCPtpiPH295xhyQD())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Qx3ddlt9kXn9l3tw5yX(this);
				num = 5;
				break;
			case 4:
			case 6:
				IIdKQ5Gu0C = localizer;
				num = 7;
				break;
			case 0:
			case 2:
				fUbOnVtX8BSP030bjui();
				num = 1;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				lsUKMLeJ6C = offset;
				goto case 3;
			default:
				num = 3;
				if (QCNDCPtpiPH295xhyQD())
				{
				}
				break;
			case 3:
				upqKgcgYYl = newState;
				goto case 4;
			case 7:
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
		object obj = o1JMKWt4Pv1FsIGh8BV(originalSnippet);
		CvsCellLocation location = BUtlAEt777uhVHIIpsR(originalSnippet);
		location.Row += lsUKMLeJ6C.Row;
		location.Column += lsUKMLeJ6C.Column;
		((PasteBuffer)obj).GetCellAt(location);
		((PasteBufferCell)tFlcq7t3NIrvXOu8L5V(obj, location)).State = upqKgcgYYl;
		return (PasteBuffer)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fUbOnVtX8BSP030bjui()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qx3ddlt9kXn9l3tw5yX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bMcSTLtELFpXabMGpOc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QCNDCPtpiPH295xhyQD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o1JMKWt4Pv1FsIGh8BV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation BUtlAEt777uhVHIIpsR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tFlcq7t3NIrvXOu8L5V(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellAt(location);
	}
}
