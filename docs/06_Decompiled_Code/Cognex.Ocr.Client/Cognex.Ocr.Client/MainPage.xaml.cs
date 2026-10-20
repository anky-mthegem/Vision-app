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

public partial class MainPage : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private Subject<bool> showSkipButtonSubject = new Subject<bool>();

	public static readonly DependencyProperty ShowSkipButtonProperty = DependencyProperty.Register("ShowSkipButton", typeof(bool), typeof(MainPage), new PropertyMetadata(OnShowSkipButtonPropertyChanged));

	private Subject<bool> isAdvancedFieldingSupportedSubject = new Subject<bool>();

	public static readonly DependencyProperty IsAdvancedFieldingSupportedProperty = DependencyProperty.Register("IsAdvancedFieldingSupported", typeof(bool), typeof(MainPage), new PropertyMetadata(true, OnIsAdvancedFieldingSupportedPropertyChanged));

	private Subject<string> flexibleFieldingValueSubject = new Subject<string>();

	public static readonly DependencyProperty FlexibleFieldingValueProperty = DependencyProperty.Register("FlexibleFieldingValue", typeof(string), typeof(MainPage), new PropertyMetadata(OnFlexibleFieldingValuePropertyChanged));

	private static readonly DependencyPropertyKey FlexibleFieldingSelectedPropertyKey = DependencyProperty.RegisterReadOnly("FlexibleFieldingSelected", typeof(bool), typeof(MainPage), new FrameworkPropertyMetadata(false, FlexibleFieldingSelected_PropertyChanged));

	public static readonly DependencyProperty FlexibleFieldingSelectedProproperty = FlexibleFieldingSelectedPropertyKey.DependencyProperty;

	private Subject<string> flexibleFieldingReferenceSubject = new Subject<string>();

	public static readonly DependencyProperty FlexibleFieldingReferenceProperty = DependencyProperty.Register("FlexibleFieldingReference", typeof(string), typeof(MainPage), new FrameworkPropertyMetadata("", OnFlexibleFieldingReferencePropertyChanged));

	public WebView2 WebView => webView;

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

	public bool IsAdvancedFieldingSupported
	{
		get
		{
			return (bool)GetValue(IsAdvancedFieldingSupportedProperty);
		}
		set
		{
			SetValue(IsAdvancedFieldingSupportedProperty, value);
		}
	}

	public string FlexibleFieldingValue
	{
		get
		{
			return (string)GetValue(FlexibleFieldingValueProperty);
		}
		set
		{
			SetValue(FlexibleFieldingValueProperty, value);
		}
	}

	public bool FlexibleFieldingSelected => (bool)GetValue(FlexibleFieldingSelectedPropertyKey.DependencyProperty);

	public string FlexibleFieldingReference
	{
		get
		{
			return (string)GetValue(FlexibleFieldingReferenceProperty);
		}
		set
		{
			SetValue(FlexibleFieldingReferenceProperty, value);
		}
	}

	public event EventHandler ContentInitialized;

	public event EventHandler<bool> FlexibleFieldingSelectedChanged;

	public MainPage()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, OcrClient.ApplicationDirectory, "#/mainPage");
	}

	private static void OnShowSkipButtonPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.showSkipButtonSubject.OnNext(mainPage.ShowSkipButton);
		}
	}

	private static void OnIsAdvancedFieldingSupportedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.isAdvancedFieldingSupportedSubject.OnNext(mainPage.IsAdvancedFieldingSupported);
		}
	}

	private static void OnFlexibleFieldingValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.flexibleFieldingValueSubject.OnNext(mainPage.FlexibleFieldingValue);
		}
	}

	private static void FlexibleFieldingSelected_PropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
	{
		if (obj is MainPage { FlexibleFieldingSelectedChanged: { } eventHandler })
		{
			eventHandler(obj, (bool)e.NewValue);
		}
	}

	private static void OnFlexibleFieldingReferencePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is MainPage mainPage && mainPage?.componentHandler != null)
		{
			mainPage.flexibleFieldingReferenceSubject.OnNext(mainPage.FlexibleFieldingReference);
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

	public void OnContentInitialized()
	{
		ContentInitialized?.Invoke(this, EventArgs.Empty);
	}

	public void RegisterAdditionalProperties(WebCommunicationBridge<WebEditControlMessage> bridge)
	{
		bridge.AddDependencyPropertySync(this, ShowSkipButtonProperty, "showSkipButton", showSkipButtonSubject);
		bridge.AddDependencyPropertySync(this, IsAdvancedFieldingSupportedProperty, "isAdvancedFieldingSupported", isAdvancedFieldingSupportedSubject);
		bridge.AddDependencyPropertySync(this, FlexibleFieldingValueProperty, "flexibleFieldingValue", flexibleFieldingValueSubject);
		bridge.AddDependencyPropertySync<bool>(this, FlexibleFieldingSelectedPropertyKey, "flexibleFieldingSelected");
		bridge.AddDependencyPropertySync(this, FlexibleFieldingReferenceProperty, "flexibleFieldingReference", flexibleFieldingReferenceSubject);
	}

	public void Dispose()
	{
		componentHandler.Dispose();
		webView.Dispose();
	}
}
