using System;

namespace Cognex.Cnx.ComponentModel;

public interface IWaitableCnxAsyncMethod : ICnxAsyncMethod
{
	CnxCompletedEventArgs CompletedArguments { get; }

	event CnxCompletedEventHandler UnsafeCompleted;

	bool Wait(TimeSpan timeout);
}
