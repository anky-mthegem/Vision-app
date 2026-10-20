using System;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Microsoft.Web.WebView2.Wpf;

namespace Cognex.Segmenter.Client;

public partial class Navigator : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(Navigator), new FrameworkPropertyMetadata(false));

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(Navigator), new PropertyMetadata(OnForceUpdatePropertyChanged));

	private Subject<bool> showTrainButtonSubject = new Subject<bool>();

	public static readonly DependencyProperty ShowTrainButtonProperty = DependencyProperty.Register("ShowTrainButton", typeof(bool), typeof(Navigator), new PropertyMetadata(true, OnShowTrainButtonPropertyChanged));

	public bool IsAccessible => (bool)GetValue(IsAccessiblePropertyKey.DependencyProperty);

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

	public bool ShowTrainButton
	{
		get
		{
			return (bool)GetValue(ShowTrainButtonProperty);
		}
		set
		{
			SetValue(ShowTrainButtonProperty, value);
		}
	}

	public WebView2 WebView => webView;

	public event EventHandler ContentInitialized;

	public Navigator()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, SegmenterClient.ApplicationDirectory, "#/navigator", "NavigatorPage");
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Navigator navigator && navigator?.componentHandler != null)
		{
			navigator.forceUpdateSubject.OnNext(navigator.ForceUpdate);
		}
	}

	private static void OnShowTrainButtonPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Navigator navigator && navigator?.componentHandler != null)
		{
			navigator.showTrainButtonSubject.OnNext(navigator.ShowTrainButton);
		}
	}

	public async Task AssignToolAsync(string toolId)
	{
		await componentHandler.AssignToolAsync(toolId);
	}

	public void Dispose()
	{
		componentHandler.Dispose();
		webView.Dispose();
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
		bridge.AddDependencyPropertySync<bool>(this, IsAccessiblePropertyKey, "isAccessible");
		bridge.AddDependencyPropertySync(this, ForceUpdateProperty, "forceUpdate", forceUpdateSubject);
		bridge.AddDependencyPropertySync(this, ShowTrainButtonProperty, "showTrainButton", showTrainButtonSubject);
	}
}
