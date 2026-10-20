using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace Cognex.Platform;

public static class ProcessAsync
{
	public class ProcessResults
	{
		public Process Process { get; }

		public IEnumerable<string> StandardOutput { get; }

		public IEnumerable<string> StandardError { get; }

		public ProcessResults(Process process, IEnumerable<string> standardOutput, IEnumerable<string> standardError)
		{
			Process = process;
			StandardOutput = standardOutput;
			StandardError = standardError;
		}
	}

	public static Task<ProcessResults> RunAsync(string fileName)
	{
		return RunAsync(new ProcessStartInfo(fileName));
	}

	public static Task<ProcessResults> RunAsync(string fileName, string arguments)
	{
		return RunAsync(new ProcessStartInfo(fileName, arguments));
	}

	public static Task<ProcessResults> RunAsync(string fileName, string userName, SecureString password, string domain)
	{
		return RunAsync(new ProcessStartInfo(fileName)
		{
			UserName = userName,
			Password = password,
			Domain = domain
		});
	}

	public static Task<ProcessResults> RunAsync(string fileName, string arguments, string userName, SecureString password, string domain)
	{
		return RunAsync(new ProcessStartInfo(fileName, arguments)
		{
			UserName = userName,
			Password = password,
			Domain = domain
		});
	}

	public static Task<ProcessResults> RunAsync(ProcessStartInfo processStartInfo)
	{
		return RunAsync(processStartInfo, new Progress<ProcessResults>((ProcessResults results) =>
		{
		}), null, CancellationToken.None, TimeSpan.FromSeconds(10.0));
	}

	public static Task<ProcessResults> RunAsync(ProcessStartInfo processStartInfo, IProgress<ProcessResults> progress, Action<Process> closeAction, CancellationToken cancellationToken, TimeSpan closeTimeout)
	{
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardInput = true;
		processStartInfo.RedirectStandardError = true;
		TaskCompletionSource<ProcessResults> tcs = new TaskCompletionSource<ProcessResults>(TaskCreationOptions.RunContinuationsAsynchronously);
		List<string> standardOutput = new List<string>();
		List<string> standardError = new List<string>();
		Process process = new Process
		{
			StartInfo = processStartInfo,
			EnableRaisingEvents = true
		};
		CancellationTokenRegistration cancelRegistration = cancellationToken.Register(async () =>
		{
			try
			{
				Stopwatch time = new Stopwatch();
				time.Start();
				bool closeIssued = false;
				while (true)
				{
					if (process.MainWindowHandle != IntPtr.Zero && !closeIssued)
					{
						process.CloseMainWindow();
						closeIssued = true;
					}
					if (!closeIssued)
					{
						if (closeAction != null)
						{
							closeAction(process);
						}
						else
						{
							process.Kill();
						}
						closeIssued = true;
					}
					else
					{
						if (closeIssued && time.Elapsed > closeTimeout)
						{
							process.Kill();
							tcs.TrySetCanceled();
							return;
						}
						if (process.HasExited)
						{
							break;
						}
					}
					await Task.Delay(250);
				}
				tcs.TrySetResult(new ProcessResults(process, standardOutput, standardError));
			}
			catch (Exception)
			{
			}
		});
		process.OutputDataReceived += (object sender, DataReceivedEventArgs args) =>
		{
			if (args.Data != null)
			{
				progress?.Report(new ProcessResults(process, new List<string> { args.Data }, new List<string>()));
				standardOutput.Add(args.Data);
			}
		};
		process.ErrorDataReceived += (object sender, DataReceivedEventArgs args) =>
		{
			if (args.Data != null)
			{
				progress?.Report(new ProcessResults(process, new List<string>(), new List<string> { args.Data }));
				standardError.Add(args.Data);
			}
		};
		cancellationToken.ThrowIfCancellationRequested();
		process.Exited += (object sender, EventArgs args) =>
		{
			tcs.TrySetResult(new ProcessResults(process, standardOutput, standardError));
			cancelRegistration.Dispose();
		};
		if (!process.Start())
		{
			tcs.TrySetException(new InvalidOperationException("Failed to start process"));
		}
		process.BeginOutputReadLine();
		process.BeginErrorReadLine();
		return tcs.Task;
	}
}
