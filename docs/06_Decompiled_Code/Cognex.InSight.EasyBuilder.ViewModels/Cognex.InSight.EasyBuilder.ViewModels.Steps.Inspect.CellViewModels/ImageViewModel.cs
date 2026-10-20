using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class ImageViewModel : CellViewModel, QpXw26KT7OGd3H62pw
{
	private string jiayKu13tL;

	private SourceLink DSGyGErrs0;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Image;
		}
	}

	public override bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jiayKu13tL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref jiayKu13tL, value, (string)V3a3leYZEXxxtrBAA4q(5436)))
			{
				agLQ6eYBvb1gxEZITPq(this, V3a3leYZEXxxtrBAA4q(27684));
			}
		}
	}

	public override string DisplayValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Value;
		}
	}

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (DSGyGErrs0 == null)
			{
				DSGyGErrs0 = new SourceLink(this);
			}
			return DSGyGErrs0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!VTKGvlYv9g6lfNMOMFx()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				base._002Ector(insight, loc, displayName);
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				EifsTuYPZsR9xhukR5I();
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			Refresh(cells);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RefreshStringValue([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Value = P_0;
		}, cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void aoKyPSQaLQ(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EifsTuYPZsR9xhukR5I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VTKGvlYv9g6lfNMOMFx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IGTsVWYrr1UJPtATBmH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V3a3leYZEXxxtrBAA4q(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void agLQ6eYBvb1gxEZITPq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}
}
