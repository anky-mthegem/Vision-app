using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.Mvvm;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public abstract class EzRangeTool<TCellViewModel> : EzTool where TCellViewModel : CellViewModel
{
	[CompilerGenerated]
	private readonly AsyncDelegateCommand AcZdrAye8C;

	[CompilerGenerated]
	private TCellViewModel QYedhdyFsB;

	[CompilerGenerated]
	private TCellViewModel bfHd8lqFhH;

	public AsyncDelegateCommand SetRangeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AcZdrAye8C;
		}
	}

	public TCellViewModel Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QYedhdyFsB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QYedhdyFsB = value;
		}
	}

	public TCellViewModel Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bfHd8lqFhH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bfHd8lqFhH = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzRangeTool(InspectStepViewModel inspect, bool isInitialized)
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
			case 0:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 0;
				num = ((1 == 0) ? 4 : 3);
				continue;
			case 1:
			case 3:
				base._002Ector(inspect, isInitialized);
				break;
			case 5:
				return;
			}
			AcZdrAye8C = new AsyncDelegateCommand(OnSetRange, zgtd9pvZkF);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool zgtd9pvZkF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (!RuntimeModeService.IsOperatorOfflineAndNotInLiveMode)
				{
					num = 10;
					break;
				}
				if (EnabledStatus != null)
				{
					_ = 0;
					num = ((1 == 0) ? 4 : 8);
					break;
				}
				goto IL_0135;
			case 6:
				return false;
			default:
				num = 1;
				break;
			case 9:
				return false;
			case 0:
				if (!Max.IsBoundExternally)
				{
					num = 11;
					break;
				}
				goto IL_0182;
			case 5:
				if (Min.SourceProperty == null)
				{
					num = 0;
					break;
				}
				goto IL_0182;
			case 10:
				return false;
			case 2:
			case 8:
				if (!EnabledStatus.Value)
				{
					goto case 3;
				}
				goto IL_0135;
			case 3:
			case 4:
				return false;
			case 1:
				if (Max != null)
				{
					if (!Min.IsBoundExternally)
					{
						num = 5;
						break;
					}
					goto IL_0182;
				}
				num = 9;
				break;
			case 11:
				{
					if (Max.SourceProperty == null)
					{
						return InternalCanSetRange();
					}
					goto IL_0182;
				}
				IL_0135:
				if (!HasError)
				{
					if (Min == null)
					{
						goto case 9;
					}
					goto case 1;
				}
				num = 6;
				break;
				IL_0182:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnErrorChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SetRangeCommand.RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool InternalCanSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	internal abstract Task OnSetRange();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (double min, double max) GetMinMax(double value, double rangePercent, double minLimit, double maxLimit)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		double num = Math.Abs(value * rangePercent);
		double item = Math.Max(minLimit, value - num);
		double item2 = Math.Min(maxLimit, value + num);
		return (min: item, max: item2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalSourcePropertyChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SetRangeCommand.RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalEnabledStatusPropertyChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SetRangeCommand.RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnRuntimeModeChanged(bool online, bool liveMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnRuntimeModeChanged(online, liveMode);
		SetRangeCommand.RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zvF60YlRoUnpMBKtc6X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lOu9OVlWpEet5pyYyKO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
