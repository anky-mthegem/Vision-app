using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Extensions;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Liger.Emulator.Properties;
using Cognex.Mvvm;
using Cognex.Platform;
using NLog;

namespace Cognex.InSight.Liger.Emulator;

public class ConfigurationViewModel : StandaloneViewModel
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	private List<ConfiguredOperationalMode> _modes;

	private PlatformMode _currentOperationalMode;

	private ConfiguredOperationalMode _configuration;

	private ConfiguredOperationalMode _initialConfiguration;

	private readonly PlatformMode _configurationToEdit;

	private readonly LigerEmulatorService _service;

	protected CancellationTokenSource _cancelSrc = new CancellationTokenSource();

	private bool _areCamerasSelectable;

	private SingleOperationStatus _primaryOperationStatus;

	public AsyncDelegateCommand PrimaryOperationCommand { get; }

	public PlatformMode CurrentOperationalMode => _currentOperationalMode;

	public string Configuration => _configuration?.Name ?? "";

	public ObservableCollection<AcquisionUnitViewModel> CameraInfoList { get; }

	public LauncherBusyOperationIndicator OperationsInProgressIndicator { get; }

	public bool AreCamerasSelectable
	{
		get
		{
			return _areCamerasSelectable;
		}
		set
		{
			SetField(ref _areCamerasSelectable, value, "AreCamerasSelectable");
		}
	}

	public SingleOperationStatus PrimaryOperationStatus
	{
		get
		{
			return _primaryOperationStatus;
		}
		set
		{
			SetField(ref _primaryOperationStatus, value, "PrimaryOperationStatus");
			PrimaryOperationCommand.RaiseCanExecuteChanged();
			RejectCommand.RaiseCanExecuteChanged();
		}
	}

	public ConfigurationViewModel(LigerEmulatorService service, string configurationToEdit)
	{
		_service = service;
		_modes = new List<ConfiguredOperationalMode>();
		_currentOperationalMode = PlatformMode.None;
		_configurationToEdit = EnumExtensions.TryParse<PlatformMode>(configurationToEdit).GetValueOrDefault();
		CameraInfoList = new ObservableCollection<AcquisionUnitViewModel>();
		PrimaryOperationCommand = new AsyncDelegateCommand(DoOperation, CanDoOperation);
		PrimaryOperationStatus = SingleOperationStatus.OperationNotStarted;
		OperationsInProgressIndicator = new LauncherBusyOperationIndicator(RejectCommand);
		OperationsInProgressIndicator.CancelButtonText = Resources.Cancel;
	}

	protected virtual bool CanDoOperation()
	{
		if (!OperationsInProgressIndicator.IsBusy)
		{
			return PrimaryOperationStatus == SingleOperationStatus.OperationNotStarted;
		}
		return false;
	}

	public override async Task Initialize()
	{
		await base.Initialize();
		using (OperationsInProgressIndicator.CreateOperation())
		{
			try
			{
				_modes = _service.ReadConfiguredOperationalModes();
				_currentOperationalMode = _service.ReadCurrentOperationalMode();
				_configuration = _modes.First((ConfiguredOperationalMode m) => m.PlatformMode == _configurationToEdit);
				_initialConfiguration = _configuration.Clone();
				IEnumerable<AcquisionUnitViewModel> range = _configuration.EmulationSettings.Select((CamEmulation cam) => new AcquisionUnitViewModel(cam));
				CameraInfoList.AddRange(range);
				AreCamerasSelectable = _configuration.EmulationSettings.Count > 1;
				FirePropertyChanged("Configuration");
				FirePropertyChanged("CameraInfoList");
			}
			catch (Exception arg)
			{
				await Broadcast(new ErrorMessageViewModel
				{
					Message = Resources.ErrorReadingEmulatorSettings,
					Heading = Resources.Emulator
				});
				Logger.Error($"Failure when reading configuration for emulator configuration {arg}");
				Complete(wasAccepted: false);
				return;
			}
		}
		RejectCommand.RaiseCanExecuteChanged();
	}

	private async Task DoOperation()
	{
		SingleOperationStatus finalStatus = SingleOperationStatus.OperationCompleted;
		using (OperationsInProgressIndicator.CreateOperation())
		{
			_ = 1;
			try
			{
				PrimaryOperationStatus = SingleOperationStatus.OperatingRunning;
				if (_configuration.HasSameEmulationSettingsAs(_initialConfiguration) || (_service.IsRunning && _configuration.PlatformMode == _currentOperationalMode && !(await Broadcast(new YesNoPromptViewModel
				{
					Message = Resources.ConfigureCausesRestart,
					Heading = Resources.UtilityAppTitle
				}))))
				{
					return;
				}
				Logger.Info($"Changing configuration {_configuration}");
				if (!_service.ChangeConfiguration(_configuration.CreateOperationalMode()))
				{
					throw new Exception("ChangeMode failed on the running controller");
				}
			}
			catch (Exception arg)
			{
				await Broadcast(new ErrorMessageViewModel
				{
					Message = Resources.ErrorConfiguringTheEmulator,
					Heading = Resources.Emulator
				});
				Logger.Error($"Failure to configure the emulator {arg}");
			}
			finally
			{
				PrimaryOperationStatus = finalStatus;
				Complete(wasAccepted: true);
			}
		}
	}

	protected override async Task DoReject()
	{
		if (OperationsInProgressIndicator.IsBusy)
		{
			_cancelSrc.Cancel();
			bool close = PrimaryOperationStatus != SingleOperationStatus.OperatingRunning;
			await OperationsInProgressIndicator.WaitForComplete();
			if (close)
			{
				Complete(wasAccepted: false);
			}
			else
			{
				RejectCommand.RaiseCanExecuteChanged();
			}
		}
		else
		{
			Complete(PrimaryOperationStatus == SingleOperationStatus.OperationCompleted);
		}
	}
}
