using System;
using System.Windows;
using System.Windows.Markup;
using Cognex.Mvvm.Wpf;
using Xceed.Wpf.Toolkit;

namespace Cognex.InSight.Liger.Emulator;

public partial class ConfigureWindow : BaseViewModelWindow, IComponentConnector
{
	public static readonly string EditingConfig = "EditingConfiguration";

	public ConfigureWindow(ConfigurationViewModel viewModel)
		: base(viewModel, viewModel.OperationsInProgressIndicator)
	{
		Licenser.LicenseKey = "WTK38P14YBG4TKJ9Z6A";
		Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
		{
			Source = new Uri("pack://application:,,,/Cognex.Foundations.Themes;component/DarkTheme.xaml")
		});
		InitializeComponent();
	}
}
