using System;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Microsoft.Web.WebView2.Wpf;

namespace Cognex.AnomalyDetector.Client;

public partial class MainPage : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private Subject<bool> showSkipButtonSubject = new Subject<bool>();

	public static readonly DependencyProperty ShowSkipButtonProperty = DependencyProperty.Register("ShowSkipButton", typeof(bool), typeof(MainPage), new PropertyMetadata(OnShowSkipButtonPropertyChanged));

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(MainPage), new PropertyMetadata(OnForceUpdatePropertyChanged));

	public bool ShowSkipButton
	{
		get
		{
			return (bool)GetValue(ShowSkipButtonProperty);
		}
		set
		{
			SetValue(ShowSkipButtonProperty, value);
		}
	}

	public WebView2 WebView => webView;

	public bool ForceUpdate
	{
		get
		{
			return (bool)GetValue(ForceUpdateProperty);
		}
		set
		{
			SetValue(ForceUpdateProperty, value);
		}
	}

	public event EventHandler ContentInitialized;

	public MainPage()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, AnomalyDetectorClient.ApplicationDirectory, "#/mainpage", "MainPage");
	}

	private static void OnShowSkipButtonPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.showSkipButtonSubject.OnNext(mainPage.ShowSkipButton);
		}
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.forceUpdateSubject.OnNext(mainPage.ForceUpdate);
		}
	}

	public async Task AssignToolAsync(string toolId)
	{
		await componentHandler.AssignToolAsync(toolId);
	}

	public void OnContentInitialized()
	{
		ContentInitialized?.Invoke(this, EventArgs.Empty);
	}

	public async Task<string> GetToolId()
	{
		return await componentHandler.GetToolId();
	}

	public void RegisterAdditionalProperties(WebCommunicationBridge<WebEditControlMessage> bridge)
	{
		bridge.AddDependencyPropertySync(this, ShowSkipButtonProperty, "showSkipButton", showSkipButtonSubject);
		bridge.AddDependencyPropertySync(this, ForceUpdateProperty, "forceUpdate", forceUpdateSubject);
	}

	public void Dispose()
	{
		componentHandler.Dispose();
		webView.Dispose();
	}
}
