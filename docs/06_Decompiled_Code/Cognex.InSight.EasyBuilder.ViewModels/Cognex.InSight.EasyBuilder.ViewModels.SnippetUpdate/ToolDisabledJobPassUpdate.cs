using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class ToolDisabledJobPassUpdate : ISnippetUpdate
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!yi2wOutW4aaxcCCQRol()) ? 2 : 4);
		string text2 = default;
		CvsCellLocation cellLocation2 = default;
		string text = default;
		CvsCellLocation cvsCellLocation2 = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				text2 = cellLocation2.ToString(absoluteRow: true, absoluteColumn: true);
				num = 5;
				break;
			case 1:
			case 2:
				text = cvsCellLocation2.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
			{
				object obj = QLYT7ptywFU4pnm6t7a(originalSnippet);
				cvsCellLocation = Ds0Ihht0bT0SWw71qwI(obj);
				string snippetName = (string)RHAyt6tFggZQ4crPypD(obj);
				cellLocation = ((PasteBuffer)obj).GetCellLocation(EzSnippet.AssembleFullCellName(snippetName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(31614), isInternal: true));
				cvsCellLocation2 = LpKUR9tYvUuqUhw1YBI(obj, EzSnippet.AssembleFullCellName(snippetName, (string)tkHYeTtMND4yJM3A1C3(8420)));
				cellLocation2 = ((PasteBuffer)obj).GetCellLocation(EzSnippet.AssembleFullCellName(snippetName, (string)tkHYeTtMND4yJM3A1C3(31632)));
				goto case 1;
			}
			case 5:
			{
				CvsCellLocation offset = new CvsCellLocation(cellLocation.Row - cvsCellLocation.Row, cellLocation.Column - cvsCellLocation.Column);
				string newArg = (string)gVR9VEtU7HHAyvHQlTt(text, tkHYeTtMND4yJM3A1C3(18708), text2);
				return new EditArgumentUpdate(offset, newArg, 0, null).Apply(originalSnippet);
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolDisabledJobPassUpdate()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eBhVEgtHBe4MBWbDBHn();
		SEOCqHtxrdcgCr45i6m(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QLYT7ptywFU4pnm6t7a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Ds0Ihht0bT0SWw71qwI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RHAyt6tFggZQ4crPypD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tkHYeTtMND4yJM3A1C3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation LpKUR9tYvUuqUhw1YBI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellLocation((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gVR9VEtU7HHAyvHQlTt(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yi2wOutW4aaxcCCQRol()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XCnRyYtTGjytyYeax3L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eBhVEgtHBe4MBWbDBHn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SEOCqHtxrdcgCr45i6m(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
