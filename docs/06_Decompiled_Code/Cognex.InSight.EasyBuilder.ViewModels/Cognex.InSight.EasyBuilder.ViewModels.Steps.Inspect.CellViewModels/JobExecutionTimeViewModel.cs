using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class JobExecutionTimeViewModel : CellViewModel
{
	private double QLHx3DppWq;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Float;
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

	public double Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QLHx3DppWq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref QLHx3DppWq, value, (string)SxOSH5U3WPkif9p2A7h(5436)))
			{
				FirePropertyChangedExplicit((string)SxOSH5U3WPkif9p2A7h(27684));
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
			return string.Format((string)SxOSH5U3WPkif9p2A7h(28208), Value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JobExecutionTimeViewModel(CvsInSight insight, CvsCellCollection cells, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cWcm9oUXpZR3AXDstE3();
		int num = (n78OIbUpVeUSG7GlniK() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				base._002Ector(insight, displayName);
				goto default;
			default:
				Refresh(cells);
				num = 5;
				break;
			case 0:
			case 1:
				bpTJ9sU9HOYmkG7GHWL();
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wW5xSDCNSa();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void wW5xSDCNSa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = SF917LU7KxftVALwQlW(vJGs6eU4MDrke2mMrbp(InSight));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bpTJ9sU9HOYmkG7GHWL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool n78OIbUpVeUSG7GlniK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cWcm9oUXpZR3AXDstE3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vJGs6eU4MDrke2mMrbp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double SF917LU7KxftVALwQlW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).ExecutionTime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SxOSH5U3WPkif9p2A7h(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
