using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;

public class RemoveCellUpdate : ISnippetUpdate
{
	private CvsCellLocation xA7GOXtfQE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveCellUpdate(CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QTpsniKL3ktDqqt5X3gK();
		int num = (m28ZWKKLjqo57bEXBVgG() ? 1 : 3);
		do
		{
			IL_004f:
			switch (num)
			{
			case 0:
			case 3:
				PCGcHMKL6UHMYN6RDnRJ();
				num = 4;
				goto IL_004f;
			case 4:
				base._002Ector();
				break;
			case 5:
				return;
			}
			xA7GOXtfQE = offset;
			num = 5;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = qwLxecKLCgwMNJVxCWPr(originalSnippet);
		CvsCellLocation origin = originalSnippet.Origin;
		origin.Row += xA7GOXtfQE.Row;
		origin.Column += xA7GOXtfQE.Column;
		mqqW9RKLAFT4F3YuO51x(obj, origin);
		return (PasteBuffer)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PCGcHMKL6UHMYN6RDnRJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QTpsniKL3ktDqqt5X3gK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m28ZWKKLjqo57bEXBVgG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qwLxecKLCgwMNJVxCWPr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mqqW9RKLAFT4F3YuO51x(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBuffer)P_0).RemoveCell(location);
	}
}
