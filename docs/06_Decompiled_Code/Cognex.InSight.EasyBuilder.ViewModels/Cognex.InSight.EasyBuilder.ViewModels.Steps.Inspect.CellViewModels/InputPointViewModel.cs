using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputPointViewModel : InputStructureViewModel
{
	private static SourceLink S6DymMGDmy;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Point;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputPointViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized)
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
			case 0:
				base._002Ector(tool, loc, displayName, isInitialized);
				_ = 1;
				if (!L5Ad0kY1WVENn94RoSv())
				{
					num = 6;
					if (THwwpsYc7bEc3fYJmaA())
					{
						break;
					}
					goto case 5;
				}
				num = 4;
				break;
			case 5:
				jaKtIxYu1bqfRUS4bZA();
				num = 0;
				if (!L5Ad0kY1WVENn94RoSv())
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				DefaultLink = S6DymMGDmy;
				goto default;
			default:
				Refresh(cells, init: true);
				num = 1;
				break;
			case 1:
				RefreshLinks(updateMember: true);
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InputPointViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jaKtIxYu1bqfRUS4bZA();
		S6DymMGDmy = new SourceLink((string)qxUraoYhEIiCr4q7nTq(), (string)uv1v3bYtirovmQ8Y17a(1838), CellType.Point);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jaKtIxYu1bqfRUS4bZA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool THwwpsYc7bEc3fYJmaA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L5Ad0kY1WVENn94RoSv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qxUraoYhEIiCr4q7nTq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rvMLAYkyXc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uv1v3bYtirovmQ8Y17a(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
