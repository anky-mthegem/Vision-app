using Cognex.Ocr.Client.Tool;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;

namespace Cognex.Ocr.Client;

public static class OcrClient
{
	internal static readonly string ApplicationDirectory = "ocr-web-app";

	public static State State => State.Instance;

	public static void RegisterAdapter(IOcrToolAdapter adapter)
	{
		ComponentManager.Instance.AddToolService(() => new OcrToolService
		{
			ToolAdapter = adapter
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
