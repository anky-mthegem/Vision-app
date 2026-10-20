using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Runtime.ViewModels.Cells;
using e0SWISkZIyw0sYl1Ml;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class Plane3DViewModel : CellViewModel, QpXw26KT7OGd3H62pw
{
	private SourceLink dgSxwOh94Q;

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dgSxwOh94Q ?? (dgSxwOh94Q = new SourceLink(this));
		}
	}

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Plane3D;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Plane3DViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				Refresh(cells, init: true);
				num = 5;
				break;
			case 0:
				AYjhXYHL3joS1yjUQ0g();
				_ = 0;
				num = ((!eGXd2fUtFlGBUweK7T9()) ? 4 : 3);
				break;
			case 1:
			case 3:
				base._002Ector(insight, loc, displayName);
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AYjhXYHL3joS1yjUQ0g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eGXd2fUtFlGBUweK7T9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ErFksvUzGEaKEUfkC8q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
