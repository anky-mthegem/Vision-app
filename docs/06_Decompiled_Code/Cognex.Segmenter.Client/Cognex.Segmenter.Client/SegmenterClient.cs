using Cognex.Segmenter.Client.Tool;
using Cognex.Segmenter.Client.Tool.Interfaces;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;

namespace Cognex.Segmenter.Client;

public static class SegmenterClient
{
	internal static readonly string ApplicationDirectory = "segmenter-web-app";

	public static State State => State.Instance;

	public static void RegisterAdapter(ISegmenterToolAdapter adapter)
	{
		ComponentManager.Instance.AddToolService(() => new SegmenterToolService
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

	public static void BroadcastKeyboradEvent(string toolId, string pressedKey)
	{
		ComponentManager.Instance.BroadcastKeyDownEvent(toolId, pressedKey).Forget();
	}

	public static void OverrideHotkeySettings(HotkeyOverride[] customHotkeySettings)
	{
		ComponentManager.Instance.OverrideHotkeySettings(customHotkeySettings).Forget();
	}

	public static void EnableAllHotkeys(bool hotkeysEnabled)
	{
		ComponentManager.Instance.EnableAllHotkeys(hotkeysEnabled).Forget();
	}
}
