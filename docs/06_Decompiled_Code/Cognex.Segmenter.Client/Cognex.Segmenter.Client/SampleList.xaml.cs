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

public partial class SampleList : UserControl, IWebComponent, IDisposable, IComponentConnector
{
	private IWebComponentHandler componentHandler;

	private static readonly DependencyPropertyKey IsAccessiblePropertyKey = DependencyProperty.RegisterReadOnly("IsAccessible", typeof(bool), typeof(SampleList), new FrameworkPropertyMetadata(false));

	private Subject<bool> forceUpdateSubject = new Subject<bool>();

	public static readonly DependencyProperty ForceUpdateProperty = DependencyProperty.Register("ForceUpdate", typeof(bool), typeof(SampleList), new PropertyMetadata(OnForceUpdatePropertyChanged));

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

	public WebView2 WebView => webView;

	public event EventHandler ContentInitialized;

	public SampleList()
	{
		InitializeComponent();
		componentHandler = ComponentManager.Instance.RegisterUserControl(this, SegmenterClient.ApplicationDirectory, "#/samplelist", "SampleListPage");
	}

	private static void OnForceUpdatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		if (d is SampleList sampleList && sampleList?.componentHandler != null)
		{
			sampleList.forceUpdateSubject.OnNext(sampleList.ForceUpdate);
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
	}
}
