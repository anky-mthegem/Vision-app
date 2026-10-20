using System;
using System.Reactive.Subjects;
using Cognex.WebToolEditControl.Core;

namespace Cognex.Ocr.Client;

public class State
{
	private Subject<StateChangedArgs> stateChanged = new Subject<StateChangedArgs>();

	private IDisposable stateChangedSubscription;

	public static State Instance { get; } = new State();

	public IObservable<StateChangedArgs> StateChanged => stateChanged;

	private IStateService StateService => ComponentManager.Instance.GetStateService(OcrClient.ApplicationDirectory);

	private State()
	{
		stateChangedSubscription = StateService.ApplicationState.StateChanged.Subscribe((Cognex.WebToolEditControl.Core.StateChangedArgs s) =>
		{
			stateChanged.OnNext(new StateChangedArgs(s.ToolId, (States)Enum.Parse(typeof(States), s.State.ToString())));
		});
	}

	public States? GetState(string toolId)
	{
		object state = StateService.ApplicationState.GetState(toolId);
		if (state == null)
		{
			return null;
		}
		return (States)Enum.Parse(typeof(States), state.ToString());
	}

	public void ExecuteNavigationAction(string toolId, NavigationAction action)
	{
		StateService.ExecuteNavigationAction(toolId, ConvertNavigationAction(action)).Forget();
	}

	private string ConvertNavigationAction(NavigationAction action)
	{
		string text = action.ToString();
		return $"{char.ToLower(text[0])}{text.Substring(1)}";
	}
}
