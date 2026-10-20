using Cognex.AnomalyDetector.Client.Tool;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;

namespace Cognex.AnomalyDetector.Client;

public static class AnomalyDetectorClient
{
	internal static readonly string ApplicationDirectory = "anomaly-detector-web-app";

	public static State State => State.Instance;

	public static void RegisterAdapter(IAnomalyDetectorAdapter adapter)
	{
		ComponentManager.Instance.AddToolService(() => new AnomalyDetectorToolService
		{
			AnomalyDetectorAdapter = adapter
		}, ApplicationDirectory);
	}

	public static void SetInitialTheme(string themeName)
	{
		ComponentManager.Instance.AddComponentInitializationCallback(async (IWebComponent c) =>
		{
			using WebMethodBridge<WebEditControlMessage> bridge = new WebMethodBridge<WebEditControlMessage>(c.WebView, "ThemeService", null);
			await bridge.CallWebActionAsync("setTheme", themeName);
		});
	}

	public static void SetLocale(string language, params LocalizationOverride[] localizationOverrides)
	{
		ComponentManager.Instance.SetLocale(language, localizationOverrides).Forget();
	}
}
