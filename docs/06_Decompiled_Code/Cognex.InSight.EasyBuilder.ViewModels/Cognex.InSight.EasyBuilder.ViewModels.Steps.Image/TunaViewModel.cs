using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Runtime;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public abstract class TunaViewModel<T> : BaseViewModel where T : class, IDisposable
{
	protected SetupImageStepViewModel _appViewModel;

	[CompilerGenerated]
	private T mKyebc17s3;

	public T TunaSensorApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mKyebc17s3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mKyebc17s3 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TunaViewModel(SetupImageStepViewModel viewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector();
				num = 1;
				break;
			case 6:
				_appViewModel.RuntimeModeService.RuntimeModeChanged += jNfeIalfjW;
				num = 7;
				break;
			default:
				_appViewModel.PropertyChanged += PIqe3Hv3jN;
				num = 6;
				break;
			case 1:
				_appViewModel = viewModel;
				goto default;
			case 0:
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}

	protected abstract void CreateTunaSensorApi();

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PIqe3Hv3jN(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_1.PropertyName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(28792))
		{
			niHefPOgTe();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jNfeIalfjW(object P_0, RuntimeModeChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		niHefPOgTe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void niHefPOgTe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 1:
				_appViewModel.ShowInSightDisplay = true;
				goto case 3;
			case 0:
				if (_appViewModel.RuntimeModeService.IsOperatorOfflineAndNotInLiveMode)
				{
					_ = 0;
					num = (true ? 7 : 3);
					break;
				}
				goto IL_0073;
			case 4:
				return;
			case 9:
				_appViewModel.ShowInSightDisplay = false;
				return;
			default:
				num = 4;
				break;
			case 5:
				_appViewModel.MainViewModel = this;
				num = 9;
				break;
			case 2:
			case 7:
				if (TunaSensorApi != null)
				{
					return;
				}
				CreateTunaSensorApi();
				num = 5;
				break;
			case 3:
			case 8:
				weReE6s8iG();
				num = 11;
				break;
			case 10:
				if (_appViewModel.IsEasyBuilderAdvancedMode)
				{
					num = 0;
					break;
				}
				goto IL_0073;
			case 11:
				return;
				IL_0073:
				if (TunaSensorApi != null)
				{
					_appViewModel.MainViewModel = null;
					num = 1;
				}
				else
				{
					num = 6;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void weReE6s8iG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TunaSensorApi?.Dispose();
		TunaSensorApi = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 8:
				_appViewModel = null;
				num = 0;
				break;
			default:
				_appViewModel.ShowInSightDisplay = true;
				num = 8;
				break;
			case 5:
				if (_appViewModel.MainViewModel == this)
				{
					num = 7;
					break;
				}
				goto case 8;
			case 7:
				_appViewModel.MainViewModel = null;
				goto default;
			case 0:
				weReE6s8iG();
				num = 9;
				break;
			case 1:
			case 2:
				obj = null;
				goto IL_00d0;
			case 6:
			{
				SetupImageStepViewModel appViewModel = _appViewModel;
				if (appViewModel != null)
				{
					obj = appViewModel.RuntimeModeService;
					goto IL_00d0;
				}
				_ = 0;
				num = (true ? 2 : 3);
				break;
			}
			case 9:
				return;
				IL_00d0:
				if (obj != null)
				{
					_appViewModel.RuntimeModeService.RuntimeModeChanged -= jNfeIalfjW;
					num = 5;
					break;
				}
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fw9MJEm6PtUDndb80KG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rb94RomCQKZFDJwotoy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
