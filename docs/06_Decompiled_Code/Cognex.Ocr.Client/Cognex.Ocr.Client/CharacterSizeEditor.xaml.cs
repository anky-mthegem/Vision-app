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

public partial class CharacterSizeEditor : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(CharacterSizeEditor), new FrameworkPropertyMetadata(false));

	public static readonly DependencyProperty IsAccessibleProproperty = IsAccessiblePropertyKey.DependencyProperty;

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(CharacterSizeEditor), new PropertyMetadata(OnForceUpdatePropertyChanged));

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

	public event EventHandler ContentInitialized;

	public CharacterSizeEditor()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, OcrClient.ApplicationDirectory, "#/characterSize");
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is CharacterSizeEditor characterSizeEditor && characterSizeEditor?.componentHandler != null)
		{
			characterSizeEditor.forceUpdateSubject.OnNext(characterSizeEditor.ForceUpdate);
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
	}

	public void Dispose()
	{
		componentHandler.Dispose();
		webView.Dispose();
	}
}
