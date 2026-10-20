using System;
using System.Reactive.Subjects;
using System.Runtime.InteropServices;
using Cognex.WebToolEditControl.Core;

namespace Cognex.AnomalyDetector.Client;

public class State
{
	private Subject<StateChangedArgs> stateChanged = new Subject<StateChangedArgs>();

	private IDisposable stateChangedSubscription;

	public static State Instance { get; } = new State();

	public IObservable<StateChangedArgs> StateChanged => stateChanged;

	private IStateService StateService => ComponentManager.Instance.GetStateService(AnomalyDetectorClient.ApplicationDirectory);

	private State()
	{
		stateChangedSubscription = StateService.ApplicationState.StateChanged.Subscribe((StateChangedArgs s) =>
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

	public void ExecuteNavigationAction(string toolId, NavigationAction action, [Optional] string parameter)
	{
		StateService.ExecuteNavigationAction(toolId, ConvertNavigationAction(action), (parameter == null) ? null : new object[1] { parameter }).Forget();
	}

	private string ConvertNavigationAction(NavigationAction action)
	{
		string text = action.ToString();
		return $"{char.ToLower(text[0])}{text.Substring(1)}";
	}
}
