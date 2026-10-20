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

public partial class Evaluation : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(Evaluation), new FrameworkPropertyMetadata(false));

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(Evaluation), new PropertyMetadata(OnForceUpdatePropertyChanged));

	private Subject<bool> showSkipButtonSubject = new Subject<bool>();

	public static readonly DependencyProperty ShowSkipButtonProperty = DependencyProperty.Register("ShowSkipButton", typeof(bool), typeof(Evaluation), new PropertyMetadata(OnShowSkipButtonPropertyChanged));

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

	public event EventHandler ContentInitialized;

	public Evaluation()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, AnomalyDetectorClient.ApplicationDirectory, "#/evaluation", "EvaluationPage");
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Evaluation evaluation && evaluation?.componentHandler != null)
		{
			evaluation.forceUpdateSubject.OnNext(evaluation.ForceUpdate);
		}
	}

	private static void OnShowSkipButtonPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Evaluation { componentHandler: not null } evaluation)
		{
			evaluation.showSkipButtonSubject.OnNext(evaluation.ShowSkipButton);
		}
	}

	public async Task AssignToolAsync(string toolId)
	{
		await componentHandler.AssignToolAsync(toolId);
	}

	public async Task<string> GetToolId()
	{
		return await componentHandler.GetToolId();
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

	public void RegisterAdditionalProperties(WebCommunicationBridge<WebEditControlMessage> bridge)
	{
		bridge.AddDependencyPropertySync<bool>(this, IsAccessiblePropertyKey, "isAccessible");
		bridge.AddDependencyPropertySync(this, ShowSkipButtonProperty, "showSkipButton", showSkipButtonSubject);
		bridge.AddDependencyPropertySync(this, ForceUpdateProperty, "forceUpdate", forceUpdateSubject);
	}
}
