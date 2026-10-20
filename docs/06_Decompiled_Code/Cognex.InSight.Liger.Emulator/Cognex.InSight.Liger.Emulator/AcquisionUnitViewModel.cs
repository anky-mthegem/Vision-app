using System.Threading.Tasks;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Liger.Emulator.Properties;
using Cognex.Mvvm;
using Cognex.Platform;

namespace Cognex.InSight.Liger.Emulator;

public class AcquisionUnitViewModel : StandaloneViewModel
{
	private int _width = 640;

	private int _height = 480;

	private readonly CamEmulation _cameraEmulation;

	public bool IsEnabled
	{
		get
		{
			return _cameraEmulation.Enabled;
		}
		set
		{
			if (_cameraEmulation.Enabled != value)
			{
				_cameraEmulation.Enabled = value;
				FirePropertyChanged("IsEnabled");
			}
		}
	}

	public string Id => _cameraEmulation.CamSlot;

	public string Resolution
	{
		get
		{
			return _cameraEmulation.Resolution;
		}
		set
		{
			if (!(_cameraEmulation.Resolution != value) || IsEnabled)
			{
				_cameraEmulation.Resolution = value;
				FirePropertyChanged("Resolution");
			}
		}
	}

	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			if (SetField(ref _width, value, "Width"))
			{
				Resolution = $"{_width}x{_height}";
			}
		}
	}

	public int Height
	{
		get
		{
			return _height;
		}
		set
		{
			if (SetField(ref _height, value, "Height"))
			{
				Resolution = $"{_width}x{_height}";
			}
		}
	}

	public string Directory
	{
		get
		{
			return _cameraEmulation.Directory;
		}
		set
		{
			if (!(_cameraEmulation.Directory == value))
			{
				_cameraEmulation.Directory = value;
				FirePropertyChanged("Directory");
			}
		}
	}

	public AsyncDelegateCommand SelectFolderCmd { get; }

	public AcquisionUnitViewModel(CamEmulation emuSettings)
	{
		_cameraEmulation = emuSettings;
		IsEnabled = emuSettings.Enabled;
		Resolution = emuSettings.Resolution;
		string[] array = emuSettings.Resolution.Split('x');
		if (array.Length == 2)
		{
			_width = (int.TryParse(array[0].JustTheNumber(), out _width) ? _width : 640);
			_height = (int.TryParse(array[1].JustTheNumber(), out _height) ? _height : 480);
		}
		Directory = emuSettings.Directory.Replace('/', '\\');
		SelectFolderCmd = new AsyncDelegateCommand(OnSelectDirectory);
	}

	private async Task OnSelectDirectory()
	{
		SelectDirectoryViewModel selectDirVM = new SelectDirectoryViewModel
		{
			Message = string.Format(Resources.SelectDirectory, Id),
			Heading = "Cognex In-Sight",
			DefaultDirectory = _cameraEmulation.Directory
		};
		if (await Broadcast(selectDirVM))
		{
			Directory = selectDirVM.SelectedDirectory;
		}
	}
}
