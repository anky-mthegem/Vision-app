using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class IntViewModel : CellViewModel
{
	private int E5exo9ISWa;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Int;
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

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E5exo9ISWa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref E5exo9ISWa, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
			{
				FirePropertyChangedExplicit((string)BnEnkuUSiu8eQ1aqial(27684));
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
			if (!Error)
			{
				return (string)Mb4n1RUkQc3CNEVAUQw(BnEnkuUSiu8eQ1aqial(1906), Value);
			}
			return (string)wtSFtPU8LXh8YGMrdcE();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IntViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
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
			case 1:
			case 3:
				base._002Ector(insight, loc, displayName);
				goto default;
			default:
				Refresh(cells, init: true);
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 5:
				return;
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_ = 0;
			num = (zgKU1GUGP4Nv3hNtpkM() ? 3 : 4);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RefreshIntValue([MethodImpl(MethodImplOptions.NoInlining)] (int P_0) =>
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
	private void KCwxFRnLeS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zgKU1GUGP4Nv3hNtpkM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UgnpDrUo94Bd0Z4GsB1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BnEnkuUSiu8eQ1aqial(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mb4n1RUkQc3CNEVAUQw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wtSFtPU8LXh8YGMrdcE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Error;
	}
}
