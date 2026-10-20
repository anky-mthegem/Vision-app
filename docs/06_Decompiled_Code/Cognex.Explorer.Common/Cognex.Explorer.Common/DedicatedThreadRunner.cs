using System;
using System.Threading;
using System.Windows.Threading;

namespace Cognex.Explorer.Common;

public static class DedicatedThreadRunner
{
	private static readonly AutoResetEvent _readyToRun;

	private static readonly AutoResetEvent _resultReady;

	private static readonly AutoResetEvent _stopThread;

	private static readonly object _lockObject;

	private static readonly Thread _dedicatedThread;

	private static object _result;

	private static Func<object> _function;

	static DedicatedThreadRunner()
	{
		_readyToRun = new AutoResetEvent(initialState: false);
		_resultReady = new AutoResetEvent(initialState: false);
		_stopThread = new AutoResetEvent(initialState: false);
		_lockObject = new object();
		_dedicatedThread = new Thread(ProcessFunctions)
		{
			Name = "DedicatedThreadRunner",
			IsBackground = true
		};
		_dedicatedThread.Start();
		AppDomain.CurrentDomain.ProcessExit += (object sender, EventArgs args) =>
		{
			_stopThread.Set();
			_dedicatedThread.Join();
		};
	}

	private static void ProcessFunctions()
	{
		while (WaitHandle.WaitAny(new WaitHandle[2] { _stopThread, _readyToRun }) != 0)
		{
			_result = _function();
			_resultReady.Set();
		}
		Dispatcher.FromThread(Thread.CurrentThread)?.InvokeShutdown();
	}

	public static TResult Run<TResult>(Func<TResult> function)
	{
		if (_dedicatedThread.ManagedThreadId == Thread.CurrentThread.ManagedThreadId)
		{
			return function();
		}
		lock (_lockObject)
		{
			_function = () => function();
			_readyToRun.Set();
			_resultReady.WaitOne();
			return (TResult)_result;
		}
	}
}
