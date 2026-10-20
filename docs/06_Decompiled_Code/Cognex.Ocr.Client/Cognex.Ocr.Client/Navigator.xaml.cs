using System;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Microsoft.Web.WebView2.Wpf;

namespace Cognex.Ocr.Client;

public partial class Navigator : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(Navigator), new FrameworkPropertyMetadata(false));

	public static readonly DependencyProperty IsAccessibleProproperty = IsAccessiblePropertyKey.DependencyProperty;

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(Navigator), new PropertyMetadata(OnForceUpdatePropertyChanged));

	private Subject<bool> preTrainOnlyModeSubject = new Subject<bool>();

	public static readonly DependencyProperty PreTrainOnlyModeProperty = DependencyProperty.Register("PreTrainOnlyMode", typeof(bool), typeof(Navigator), new PropertyMetadata(OnPreTrainOnlyModePropertyChanged));

	private Subject<bool> showTrainButtonSubject = new Subject<bool>();

	public static readonly DependencyProperty ShowTrainButtonProperty = DependencyProperty.Register("ShowTrainButton", typeof(bool), typeof(Navigator), new PropertyMetadata(true, OnShowTrainButtonPropertyChanged));

	private static readonly DependencyPropertyKey CharactersPropertyKey = DependencyProperty.RegisterReadOnly("Characters", typeof(int), typeof(Navigator), new FrameworkPropertyMetadata(0));

	public static readonly DependencyProperty CharactersProproperty = CharactersPropertyKey.DependencyProperty;

	private static readonly DependencyPropertyKey SamplesPropertyKey = DependencyProperty.RegisterReadOnly("Samples", typeof(int), typeof(Navigator), new FrameworkPropertyMetadata(0));

	public static readonly DependencyProperty SamplesProproperty = SamplesPropertyKey.DependencyProperty;

	private static readonly DependencyPropertyKey ConfidencePercentagePropertyKey = DependencyProperty.RegisterReadOnly("ConfidencePercentage", typeof(double?), typeof(Navigator), new FrameworkPropertyMetadata(null));

	public static readonly DependencyProperty ConfidencePercentageProproperty = ConfidencePercentagePropertyKey.DependencyProperty;

	public WebView2 WebView => webView;

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

	public bool PreTrainOnlyMode
	{
		get
		{
			return (bool)GetValue(PreTrainOnlyModeProperty);
		}
		set
		{
			SetValue(PreTrainOnlyModeProperty, value);
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

	public int Characters => (int)GetValue(CharactersPropertyKey.DependencyProperty);

	public int Samples => (int)GetValue(SamplesPropertyKey.DependencyProperty);

	public double? ConfidencePercentage => (double?)GetValue(ConfidencePercentagePropertyKey.DependencyProperty);

	public event EventHandler ContentInitialized;

	public Navigator()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, OcrClient.ApplicationDirectory, "#/navigator");
	}

	public async Task AssignToolAsync(string toolId)
	{
		await componentHandler.AssignToolAsync(toolId);
	}

	public async Task<string> GetToolId()
	{
		return await componentHandler.GetToolId();
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Navigator navigator && navigator?.componentHandler != null)
		{
			navigator.forceUpdateSubject.OnNext(navigator.ForceUpdate);
		}
	}

	private static void OnPreTrainOnlyModePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Navigator navigator && navigator?.componentHandler != null)
		{
			navigator.preTrainOnlyModeSubject.OnNext(navigator.PreTrainOnlyMode);
		}
	}

	private static void OnShowTrainButtonPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is Navigator navigator && navigator?.componentHandler != null)
		{
			navigator.showTrainButtonSubject.OnNext(navigator.ShowTrainButton);
		}
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
		bridge.AddDependencyPropertySync(this, ForceUpdateProperty, "forceUpdate", forceUpdateSubject);
		bridge.AddDependencyPropertySync(this, PreTrainOnlyModeProperty, "preTrainOnlyMode", preTrainOnlyModeSubject);
		bridge.AddDependencyPropertySync(this, ShowTrainButtonProperty, "showTrainButton", showTrainButtonSubject);
		bridge.AddDependencyPropertySync<int>(this, CharactersPropertyKey, "characters");
		bridge.AddDependencyPropertySync<int>(this, SamplesPropertyKey, "samples");
		bridge.AddDependencyPropertySync<double?>(this, ConfidencePercentagePropertyKey, "confidencePercentage");
	}
}
