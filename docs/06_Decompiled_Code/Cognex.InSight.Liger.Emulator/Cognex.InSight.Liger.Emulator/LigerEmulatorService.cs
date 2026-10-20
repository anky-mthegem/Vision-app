using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Cognex.Explorer.Common.AppServices;
using Cognex.Explorer.Common.Emulator;
using Cognex.Explorer.Integration;
using Cognex.Extensions;
using Cognex.Foundations.Wpf;
using Cognex.InSight.Liger.Emulator.Properties;
using Cognex.Platform;
using NLog;
using NLog.Config;
using NLog.Targets;
using Newtonsoft.Json;

namespace Cognex.InSight.Liger.Emulator;

public class LigerEmulatorService : EmulatorService
{
	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	private EmulatorInfo _info;

	private List<ConfiguredOperationalMode> _configurations;

	private OperationalMode _currentOperationalMode;

	private PlatformMode _currentPlatformMode;

	private bool _isEmulatorBroken;

	private Process _sheetsProcess;

	private Process _namerProcess;

	private readonly SemaphoreSlim _lockingSemaphore = new SemaphoreSlim(1);

	private Dispatcher _dispatcher;

	private const string _launching = "Launching";

	private const string _notLaunching = "NotLaunching";

	private const string _loggingFile = "PC Emulator";

	private const int _connectTimeoutSeconds = 10;

	private const int _inSightPcStartupTimeoutSeconds = 90;

	public override string Identifier => _info.UniqueId;

	public static string DataFolderPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Cognex\\In-Sight\\In-Sight", "25.1.0");

	public LigerEmulatorService()
	{
		SetDefaultConfiguration();
	}

	public override void Initialize(EmulatorInfo info)
	{
		_info = info;
		_lockingSemaphore.Wait();
		try
		{
			_dispatcher = Dispatcher.CurrentDispatcher;
			SetupLogging();
		}
		finally
		{
			_lockingSemaphore.Release();
		}
	}

	public override void OpenConfiguration(string configName)
	{
		Application.Current.Dispatcher?.Invoke((Func<Task>)(async () =>
		{
			await ConfigureEmulator(configName);
		})).IgnoreResult();
	}

	protected override void OnRefreshStatus()
	{
		ReadRunningStatus();
	}

	protected override void OnStarted(string configuration)
	{
		_lockingSemaphore.Wait();
		try
		{
			if (_isEmulatorBroken)
			{
				Logger.Error("Attempting to start the emulator when broken.");
				return;
			}
			try
			{
				ReadRunningStatus();
				if (string.IsNullOrWhiteSpace(configuration))
				{
					configuration = "None";
				}
				PlatformMode? newModeRequested = EnumExtensions.TryParse<PlatformMode>(configuration, ignoreCase: true);
				if (!newModeRequested.HasValue)
				{
					throw new ApplicationException("Requesting an invalid configuration " + configuration);
				}
				Logger.Info($"Changing mode from {_currentPlatformMode} to {newModeRequested}");
				ConfiguredOperationalMode configuredOperationalMode = _configurations.FirstOrDefault((ConfiguredOperationalMode c) => c.PlatformMode == newModeRequested.Value);
				if (configuredOperationalMode == null)
				{
					configuredOperationalMode = new ConfiguredOperationalMode();
					configuredOperationalMode.PlatformMode = PlatformMode.None;
				}
				if (!ChangeMode(configuredOperationalMode.CreateOperationalMode()))
				{
					throw new Exception($"Failure to change mode from {_currentPlatformMode} to {configuration}");
				}
				OnChange();
			}
			catch (Exception arg)
			{
				IsRunning = false;
				SetDefaultConfiguration();
				_isEmulatorBroken = true;
				Logger.Error($"Failed to start emulator {arg}");
				ShowMessage(Resources.EmulatorStartupFailure);
			}
		}
		finally
		{
			_lockingSemaphore.Release();
		}
	}

	protected override void OnStopped()
	{
		_lockingSemaphore.Wait();
		try
		{
			Logger.Info("Stopping PC emulator.");
			if (_isEmulatorBroken)
			{
				Logger.Error("Attempting to stop the emulator when broken.");
			}
			else if (IsRunning)
			{
				OperationalMode newOperationalMode = new OperationalMode
				{
					PlatformMode = PlatformMode.None
				};
				Logger.Info("Shutting down, stopping emulator");
				IsRunning = false;
				if (ChangeMode(newOperationalMode))
				{
					Logger.Error("Failure to stop the emulator");
				}
				OnChange();
			}
		}
		finally
		{
			_lockingSemaphore.Release();
		}
	}

	private async Task ConfigureEmulator(string configName)
	{
		_lockingSemaphore.Wait();
		try
		{
			if (_isEmulatorBroken)
			{
				ShowMessage(Resources.FailureInEmulator);
				return;
			}
			using MvvmViewBoostrapper mvvmFrameworkBootstrapper = new MvvmViewBoostrapper();
			ConfigurationViewModel viewModel = new ConfigurationViewModel(this, configName);
			ConfigureWindow window = new ConfigureWindow(viewModel);
			Task startTask = mvvmFrameworkBootstrapper.Start(window, showWindow: false);
			await viewModel.Initialize();
			if (!viewModel.Completed.IsCompleted)
			{
				WindowUtils.OpenCenteredDialog(window);
				await startTask;
				ReadRunningStatus();
			}
		}
		catch (Exception arg)
		{
			Logger.Error($"Error occurred while configuring.\n{arg}");
			_isEmulatorBroken = true;
		}
		finally
		{
			_lockingSemaphore.Release();
			OnConfigurationWindowClosed("");
		}
	}

	public void OnChange()
	{
		OnPropertyChanged("Configurations");
		OnPropertyChanged("IsRunning");
		OnPropertyChanged("CurrentConfiguration");
		OnStatusChanged("");
	}

	private bool ReadRunningStatus()
	{
		try
		{
			_configurations = ReadConfiguredOperationalModes();
			if (_configurations == null)
			{
				Logger.Error("The platform returned no configurations when read.");
				SetDefaultConfiguration();
				return false;
			}
			_currentPlatformMode = ReadCurrentOperationalMode();
			CurrentConfiguration = _currentPlatformMode.ToString();
			Configurations = _configurations.ToDictionary((ConfiguredOperationalMode c) => c.PlatformMode.ToString(), (ConfiguredOperationalMode c) => c.Name);
			IsRunning = _currentPlatformMode != PlatformMode.None;
			Exclusive = false;
			ExclusiveMessage = "";
		}
		catch (Exception ex)
		{
			Logger.Error("Exception when reading the runtime configuration.\n" + ex);
			SetDefaultConfiguration();
			return false;
		}
		return IsRunning;
	}

	private void SetDefaultConfiguration()
	{
		Exclusive = false;
		ExclusiveMessage = "";
		Configurations = new Dictionary<string, string>();
		CurrentConfiguration = "";
	}

	private ConfiguredOperationalMode CreateOperationalMode(PlatformMode platformMode, string name, int numCams, string camSlot, string resolution, string directory, bool isEnabled, bool isResolutionChangeSupported, bool isColor, bool is2DLineScan)
	{
		return new ConfiguredOperationalMode
		{
			PlatformMode = platformMode,
			Name = name,
			NumberOfCameras = numCams,
			EmulationSettings = new List<CamEmulation>
			{
				new CamEmulation
				{
					CamSlot = camSlot,
					Resolution = resolution,
					Directory = directory,
					Enabled = isEnabled,
					IsResolutionChangeSupported = isResolutionChangeSupported,
					IsColor = isColor,
					Is2DLineScan = is2DLineScan
				}
			}
		};
	}

	public List<ConfiguredOperationalMode> ReadConfiguredOperationalModes()
	{
		string directory = Path.Combine(DataFolderPath, "pubfs/Images");
		List<ConfiguredOperationalMode> list = new List<ConfiguredOperationalMode>
		{
			CreateOperationalMode(PlatformMode.IS2800M, "In-Sight 2800M", 1, "cam0", "720x540", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS2801M, "In-Sight 2801M", 1, "cam0", "1440x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS2802M, "In-Sight 2802M", 1, "cam0", "1920x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS2801C, "In-Sight 2801C", 1, "cam0", "1440x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS2802C, "In-Sight 2802C", 1, "cam0", "1920x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3801M, "In-Sight 3801M", 1, "cam0", "1440x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3803M, "In-Sight 3803M", 1, "cam0", "2048x1536", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3805M, "In-Sight 3805M", 1, "cam0", "2448x2048", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3808M, "In-Sight 3808M", 1, "cam0", "2840x2840", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3812M, "In-Sight 3812M", 1, "cam0", "4096x3000", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3816M, "In-Sight 3816M", 1, "cam0", "5320x3032", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3801C, "In-Sight 3801C", 1, "cam0", "1440x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3803C, "In-Sight 3803C", 1, "cam0", "2048x1536", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3805C, "In-Sight 3805C", 1, "cam0", "2448x2048", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3808C, "In-Sight 3808C", 1, "cam0", "2840x2840", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3812C, "In-Sight 3812C", 1, "cam0", "4096x3000", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3816C, "In-Sight 3816C", 1, "cam0", "5320x3032", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS3802L, "In-Sight 3802L", 1, "cam0", "2048x16376", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: true),
			CreateOperationalMode(PlatformMode.IS3804L, "In-Sight 3804L", 1, "cam0", "4096x16376", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: true),
			CreateOperationalMode(PlatformMode.ADV182M, "Advantage 182M", 1, "cam0", "1920x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.ADV182C, "Advantage 182C", 1, "cam0", "1920x1080", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8900M, "In-Sight 8900M", 1, "cam0", "800x600", directory, isEnabled: true, isResolutionChangeSupported: true, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8900C, "In-Sight 8900C", 1, "cam0", "800x600", directory, isEnabled: true, isResolutionChangeSupported: true, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8902M, "In-Sight 8902M", 1, "cam0", "1920x1200", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8902C, "In-Sight 8902C", 1, "cam0", "1920x1200", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8905M, "In-Sight 8905M", 1, "cam0", "2448x2048", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8905C, "In-Sight 8905C", 1, "cam0", "2448x2048", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8912M, "In-Sight 8912M", 1, "cam0", "4096x3000", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false),
			CreateOperationalMode(PlatformMode.IS8912C, "In-Sight 8912C", 1, "cam0", "4096x3000", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: true, is2DLineScan: false)
		};
		if (_info.Supports3D)
		{
			list.Add(CreateOperationalMode(PlatformMode.ISL38033, "In-Sight L38-033", 1, "cam0", "", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false));
			list.Add(CreateOperationalMode(PlatformMode.ISL38050, "In-Sight L38-050", 1, "cam0", "", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false));
			list.Add(CreateOperationalMode(PlatformMode.ISL38100, "In-Sight L38-100", 1, "cam0", "", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false));
			list.Add(CreateOperationalMode(PlatformMode.ISL38300, "In-Sight L38-300", 1, "cam0", "", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false));
			list.Add(CreateOperationalMode(PlatformMode.ISL38500, "In-Sight L38-500", 1, "cam0", "", directory, isEnabled: true, isResolutionChangeSupported: false, isColor: false, is2DLineScan: false));
		}
		return list;
	}

	public PlatformMode ReadCurrentOperationalMode()
	{
		if ((from x in Process.GetProcesses()
			where x.ProcessName.StartsWith("InSightSheets", StringComparison.OrdinalIgnoreCase)
			select x).ToArray().Any() || Status == "Launching")
		{
			return _currentPlatformMode;
		}
		return PlatformMode.None;
	}

	public bool ChangeConfiguration(OperationalMode newOperationalMode)
	{
		return true;
	}

	public bool ChangeMode(OperationalMode newOperationalMode)
	{
		SetOperationMode(newOperationalMode).IgnoreResult();
		return true;
	}

	private async Task SetOperationMode(OperationalMode mode)
	{
		try
		{
			bool flag = _currentPlatformMode != mode.PlatformMode;
			PlatformMode currentPlatformMode = _currentPlatformMode;
			_currentOperationalMode = mode;
			_currentPlatformMode = mode.PlatformMode;
			if (mode.PlatformMode == PlatformMode.None)
			{
				if (currentPlatformMode != PlatformMode.None)
				{
					Logger.Info("Platform: Operational Mode is set to None, stopping");
					StopEmulator();
				}
			}
			else if (flag)
			{
				Logger.Info($"Platform: Restart needed {currentPlatformMode} to {mode}");
				StopEmulator();
				await StartEmulator();
			}
		}
		catch (Exception arg)
		{
			Status = "NotLaunching";
			Logger.Error($"Platform: Exception in SetOperationMode\n{arg}");
		}
	}

	private void StopEmulator()
	{
		Process sheetsProcess = _sheetsProcess;
		if (sheetsProcess != null && !sheetsProcess.HasExited)
		{
			_sheetsProcess.Kill();
		}
		Process namerProcess = _namerProcess;
		if (namerProcess != null && !namerProcess.HasExited)
		{
			_namerProcess.Kill();
		}
	}

	private async Task StartEmulator()
	{
		string appPath = ".\\runtime\\";
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Cognex\\In-Sight\\In-Sight", _info.Version.ToString(), "config");
		string emulatorControllerRoot = Definitions.EmulatorControllerRoot;
		string portRegistryFilepath = Definitions.PortRegistryFilePath;
		SetupLogging();
		try
		{
			Directory.CreateDirectory(emulatorControllerRoot);
		}
		catch (Exception arg)
		{
			string text2 = "Exception creating emulator controllerRoot directory at path: " + emulatorControllerRoot + ".";
			Logger.Error($"{text2} {arg}");
			throw new ApplicationException(text2);
		}
		if (File.Exists(portRegistryFilepath))
		{
			try
			{
				File.Delete(portRegistryFilepath);
			}
			catch (Exception arg2)
			{
				string text3 = "Exception deleting portRegistry at path: " + portRegistryFilepath + ".";
				Logger.Error($"{text3} {arg2}");
				throw new ApplicationException(text3);
			}
		}
		string text4 = "--runtime --authname cam0 --controllerRoot \"" + emulatorControllerRoot + "\" --configRoot \"" + text + "\" --portRegistryFile \"" + portRegistryFilepath + "\" --useEphemeral --mockUserService";
		bool flag = _currentOperationalMode.PlatformMode.Is3D();
		text4 += (flag ? "" : (" --sensorSize " + _currentOperationalMode.EmulationSettings[0].Resolution));
		text4 += (_currentOperationalMode.EmulationSettings[0].IsColor ? " --color" : "");
		text4 += (_currentOperationalMode.EmulationSettings[0].Is2DLineScan ? " --2dlinescan" : "");
		string ligerAppName = "InSightSheets" + (flag ? "3D" : "");
		_sheetsProcess = await StartApplication(ligerAppName, appPath, text4, appPath);
		string text5 = _sheetsProcess.MainModule.FileVersionInfo?.ProductVersion ?? (_info.Version?.ToString() + " (999)");
		Status = "Launching";
		InSightSheetsPorts inSightSheetsPorts = ReadProcessRegistryFile<InSightSheetsPorts>(portRegistryFilepath, ligerAppName);
		if (inSightSheetsPorts == null || inSightSheetsPorts.Status.Equals("error", StringComparison.Ordinal))
		{
			Logger.Error("Platform: Insightsheets failed initialization\n");
			throw new ApplicationException("Insightsheets failed initialization");
		}
		string hostName = Dns.GetHostName();
		string arguments = "--type 14 --subtype 1 --appid 3 --interfaceIP 127.0.0.1 --hostname " + hostName + " --model \" " + Configurations[_currentPlatformMode.ToString()] + " Emulator\" --version \"" + text5 + "\" --services" + $" http={inSightSheetsPorts.LowPriority};hmi-http={inSightSheetsPorts.WebHmi}\"";
		_namerProcess = await StartApplication("CogNamerServer", appPath, arguments);
		Status = "NotLaunching";
	}

	private T ReadProcessRegistryFile<T>(string registryFilePath, string processName)
	{
		Process[] processesByName = Process.GetProcessesByName(processName);
		T result = default;
		int num = 0;
		while (processesByName.Length != 0 && num < 3000)
		{
			if (File.Exists(registryFilePath))
			{
				try
				{
					result = JsonConvert.DeserializeObject<T>(File.ReadAllText(registryFilePath));
					return result;
				}
				catch (Exception ex) when (ex is IOException)
				{
				}
			}
			processesByName = Process.GetProcessesByName(processName);
			Thread.Sleep(10);
			num++;
		}
		return result;
	}

	private static async Task<Process> StartApplication(string applicationName, string directory, string arguments = null, string workingDirectory = null, bool redirectStdio = true, Dictionary<string, string> environmentVariables = null)
	{
		if (!Process.GetProcessesByName(applicationName).Any())
		{
			try
			{
				if (workingDirectory == null)
				{
					workingDirectory = Environment.CurrentDirectory;
				}
				string text = Path.Combine(directory, applicationName) + ".exe";
				Logger.Info("Starting: " + text + "\nArguments: " + (arguments ?? "-") + "\nCurrent directory: " + workingDirectory + "\n");
				ProcessStartInfo processStartInfo = new ProcessStartInfo(text)
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = false,
					CreateNoWindow = true,
					WorkingDirectory = workingDirectory,
					RedirectStandardOutput = redirectStdio
				};
				if (environmentVariables != null)
				{
					foreach (KeyValuePair<string, string> environmentVariable in environmentVariables)
					{
						processStartInfo.EnvironmentVariables[environmentVariable.Key] = environmentVariable.Value;
					}
				}
				if (arguments != null)
				{
					processStartInfo.Arguments = arguments;
				}
				Process process = Process.Start(processStartInfo);
				if (redirectStdio)
				{
					process.OutputDataReceived += (object s, DataReceivedEventArgs e) =>
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							Logger.Info(e.Data);
						}
					};
					process.BeginOutputReadLine();
				}
				ChildProcessTracker.AddProcess(process);
				await AwaitProcessStart(applicationName, CancellationToken.None, TimeSpan.FromMilliseconds(2000.0));
				return process;
			}
			catch (Exception arg)
			{
				Logger.Error($"Failed to start the {applicationName} application\n{arg}");
				return null;
			}
		}
		return null;
	}

	private static async Task AwaitProcessStart(string applicationName, CancellationToken cancel, TimeSpan waitTime)
	{
		Stopwatch timer = Stopwatch.StartNew();
		while (timer.Elapsed < waitTime && !Process.GetProcessesByName(applicationName).Any())
		{
			await Task.Delay(100, cancel);
		}
	}

	private void SetupLogging()
	{
		try
		{
			XmlLoggingConfiguration xmlLoggingConfiguration = new XmlLoggingConfiguration(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "NLog.config"));
			xmlLoggingConfiguration.Variables["logDirectory"] = Path.Combine(AppHost.GetService<IApplicationUserFolders>().GetPublicUserDataFolder(), "Logs");
			xmlLoggingConfiguration.Variables["logFileName"] = "PC Emulator";
			LogManager.Configuration = xmlLoggingConfiguration;
			LogManager.ReconfigExistingLoggers();
		}
		catch
		{
			try
			{
				LoggingConfiguration loggingConfiguration = new LoggingConfiguration();
				string path = Path.Combine(AppHost.GetService<IApplicationUserFolders>().GetPublicUserDataFolder(), "Logs");
				string path2 = "PC Emulator.txt";
				FileTarget target = new FileTarget("PC Emulator")
				{
					FileName = Path.Combine(path, path2)
				};
				loggingConfiguration.AddRuleForAllLevels(target);
				LogManager.Configuration = loggingConfiguration;
				LogManager.ReconfigExistingLoggers();
			}
			catch
			{
			}
		}
	}

	private void ShowMessage(string messages)
	{
		_dispatcher.Invoke(() => MessageBox.Show(Application.Current.MainWindow, string.Format(Resources.EmulationFailure, Environment.NewLine, messages), Resources.EmulatorError, MessageBoxButton.OK, MessageBoxImage.Hand));
	}
}
