using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputLineViewModel : InputStructureViewModel
{
	private static SourceLink rJAyhrVZvV;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Line;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputLineViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (ieuJvkYFe60kcOo2Vcn())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_0078;
			}
		}
		goto IL_0041;
		IL_0041:
		while (true)
		{
			switch (num)
			{
			case 1:
				DefaultLink = rJAyhrVZvV;
				break;
			case 0:
			case 5:
				eShGOWYYsx5fUoM7Ctu();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				RefreshLinks(updateMember: true);
				num = 7;
				if (ieuJvkYFe60kcOo2Vcn())
				{
					continue;
				}
				goto case 2;
			case 2:
				base._002Ector(tool, loc, displayName, isInitialized);
				num = 1;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0078;
		IL_0078:
		Refresh(cells);
		num = 4;
		goto IL_0041;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InputLineViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eShGOWYYsx5fUoM7Ctu();
		rJAyhrVZvV = new SourceLink((string)HLbMwrYUqLeaiJW85oZ(), (string)MOhtKmYHUV7XZUhZ1TM(1838), CellType.Line);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eShGOWYYsx5fUoM7Ctu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ieuJvkYFe60kcOo2Vcn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yKnRpjYMieKq2FSVQcQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HLbMwrYUqLeaiJW85oZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rvMLAYkyXc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MOhtKmYHUV7XZUhZ1TM(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
