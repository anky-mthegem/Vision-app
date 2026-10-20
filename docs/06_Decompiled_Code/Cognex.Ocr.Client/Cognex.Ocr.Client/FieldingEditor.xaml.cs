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

public partial class FieldingEditor : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(FieldingEditor), new FrameworkPropertyMetadata(false));

	public static readonly DependencyProperty IsAccessibleProproperty = IsAccessiblePropertyKey.DependencyProperty;

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(FieldingEditor), new PropertyMetadata(OnForceUpdatePropertyChanged));

	private Subject<bool> isAdvancedFieldingSupportedSubject = new Subject<bool>();

	public static readonly DependencyProperty IsAdvancedFieldingSupportedProperty = DependencyProperty.Register("IsAdvancedFieldingSupported", typeof(bool), typeof(FieldingEditor), new PropertyMetadata(OnIsAdvancedFieldingSupportedPropertyChanged));

	private Subject<string> flexibleFieldingValueSubject = new Subject<string>();

	public static readonly DependencyProperty FlexibleFieldingValueProperty = DependencyProperty.Register("FlexibleFieldingValue", typeof(string), typeof(FieldingEditor), new PropertyMetadata(OnFlexibleFieldingValuePropertyChanged));

	private static readonly DependencyPropertyKey FlexibleFieldingSelectedPropertyKey = DependencyProperty.RegisterReadOnly("FlexibleFieldingSelected", typeof(bool), typeof(FieldingEditor), new FrameworkPropertyMetadata(false));

	public static readonly DependencyProperty FlexibleFieldingSelectedProproperty = FlexibleFieldingSelectedPropertyKey.DependencyProperty;

	private Subject<string> flexibleFieldingReferenceSubject = new Subject<string>();

	public static readonly DependencyProperty FlexibleFieldingReferenceProperty = DependencyProperty.Register("FlexibleFieldingReference", typeof(string), typeof(FieldingEditor), new FrameworkPropertyMetadata("", OnFlexibleFieldingReferencePropertyChanged));

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

	public FieldingEditor()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, OcrClient.ApplicationDirectory, "#/fieldingEditor");
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is FieldingEditor fieldingEditor && fieldingEditor?.componentHandler != null)
		{
			fieldingEditor.forceUpdateSubject.OnNext(fieldingEditor.ForceUpdate);
		}
	}

	private static void OnIsAdvancedFieldingSupportedPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is FieldingEditor fieldingEditor && fieldingEditor?.componentHandler != null)
		{
			fieldingEditor.isAdvancedFieldingSupportedSubject.OnNext(fieldingEditor.IsAdvancedFieldingSupported);
		}
	}

	private static void OnFlexibleFieldingValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is FieldingEditor fieldingEditor && fieldingEditor?.componentHandler != null)
		{
			fieldingEditor.flexibleFieldingValueSubject.OnNext(fieldingEditor.FlexibleFieldingValue);
		}
	}

	private static void OnFlexibleFieldingReferencePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is FieldingEditor fieldingEditor && fieldingEditor?.componentHandler != null)
		{
			fieldingEditor.flexibleFieldingReferenceSubject.OnNext(fieldingEditor.FlexibleFieldingReference);
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
		bridge.AddDependencyPropertySync<bool>(this, IsAccessiblePropertyKey, "isAccessible");
		bridge.AddDependencyPropertySync(this, ForceUpdateProperty, "forceUpdate", forceUpdateSubject);
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
