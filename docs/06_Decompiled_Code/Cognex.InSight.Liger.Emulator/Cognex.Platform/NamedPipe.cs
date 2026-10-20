using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Extensions;
using NLog;
using Newtonsoft.Json;

namespace Cognex.Platform;

public class NamedPipe
{
	public class Server : IDisposable
	{
		private readonly string _name;

		private NamedPipeServerStream _serverStream;

		private StreamReader _reader;

		private bool _isRunning = true;

		private readonly object _syncRoot = new object();

		public event Func<string, string> RequestReceived;

		public Server(string name)
		{
			_name = name;
			CreatePipe();
		}

		public void Dispose()
		{
			Stop();
			DisposePipe();
		}

		public void Run()
		{
			Task.Factory.StartNew((Func<Task>)(async () =>
			{
				while (IsRunning())
				{
					try
					{
						if (_serverStream != null)
						{
							_serverStream?.WaitForConnection();
							while (IsRunning())
							{
								string arg = _reader.ReadLine();
								string text = RequestReceived?.Invoke(arg) ?? "{}";
								if (!text.EndsWith(Environment.NewLine))
								{
									text += Environment.NewLine;
								}
								byte[] bytes = Encoding.UTF8.GetBytes(text);
								_serverStream?.Write(bytes, 0, bytes.Length);
							}
						}
					}
					catch (UnauthorizedAccessException)
					{
						Logger.Error("Another process is running unable to run the " + _name + " channel");
						Stop();
					}
					catch (IOException)
					{
					}
					catch (Exception arg2)
					{
						Logger.Error(string.Format("Failure in {0} server {1}\n{2}", "NamedPipe", _name, arg2));
					}
					if (IsRunning())
					{
						await Task.Delay(100);
						DisposePipe();
						CreatePipe();
					}
				}
				Logger.Info("NamedPipe " + _name + " has exited");
			}), TaskCreationOptions.LongRunning);
		}

		public void Stop()
		{
			lock (_syncRoot)
			{
				_isRunning = false;
			}
		}

		private bool IsRunning()
		{
			lock (_syncRoot)
			{
				return _isRunning;
			}
		}

		private void CreatePipe()
		{
			try
			{
				PipeSecurity pipeSecurity = new PipeSecurity();
				pipeSecurity.AddAccessRule(new PipeAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), PipeAccessRights.ReadWrite | PipeAccessRights.CreateNewInstance, AccessControlType.Allow));
				_serverStream = new NamedPipeServerStream(_name, PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous, 20000, 20000, pipeSecurity);
				_reader = new StreamReader(_serverStream);
			}
			catch (Exception arg)
			{
				Logger.Error(string.Format("Failure to create {0} server {1}\n{2}", "NamedPipe", _name, arg));
			}
		}

		private void DisposePipe()
		{
			try
			{
				NamedPipeServerStream serverStream = _serverStream;
				if (serverStream != null && serverStream.IsConnected)
				{
					_serverStream?.Disconnect();
				}
				_reader?.Dispose();
				_serverStream = null;
				_reader = null;
			}
			catch (Exception)
			{
			}
		}
	}

	public class Client : IDisposable
	{
		private NamedPipeClientStream _clientStream;

		private StreamReader _reader;

		private readonly string _name;

		public Client(string name)
		{
			_name = name;
			_clientStream = new NamedPipeClientStream(".", name, PipeDirection.InOut);
			_reader = new StreamReader(_clientStream);
		}

		public void Dispose()
		{
			try
			{
				_reader?.Dispose();
				_reader = null;
				_clientStream.Dispose();
				_clientStream = null;
			}
			catch (Exception arg)
			{
				Logger.Error(string.Format("Error disposing client {0} {1}\n{2}", "NamedPipe", _name, arg));
			}
		}

		public bool IsConnected()
		{
			return _clientStream?.IsConnected ?? false;
		}

		public async Task Connect(CancellationToken cancel)
		{
			if (!IsConnected())
			{
				await Task.WhenAny(cancel.AsTask(), _clientStream.ConnectAsync(cancel));
			}
		}

		public async Task<string> Request(string msg)
		{
			if (!_clientStream.IsConnected)
			{
				throw new ApplicationException("NamedPipe failure: client not connected.");
			}
			if (!msg.EndsWith(Environment.NewLine))
			{
				msg += Environment.NewLine;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(msg);
			try
			{
				await _clientStream.WriteAsync(bytes, 0, bytes.Length);
			}
			catch (Exception arg)
			{
				Logger.Error(string.Format("Error sending message to {0} {1}\n{2}", "NamedPipe", _name, arg));
				return "";
			}
			return await _reader.ReadLineAsync();
		}
	}

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public static async Task<string> SendToControllerService(Client client, string url, string toSendData = null)
	{
		return await client.Request(JsonConvert.SerializeObject(new Message(url)
		{
			Data = toSendData
		})).ConfigureAwait(continueOnCapturedContext: false);
	}

	public static async Task<InSightControllerState> SetControllerState(Client client, bool state, string ipAddress = null, string apiVersion = null, int maxCameras = 0, KeyValuePair<string, string>[] capablities = null, IEnumerable<CamEmulation> emuSettings = null)
	{
		return ReadStateFromResponse(await SendToControllerService(client, "putControl", JsonConvert.SerializeObject(new ProcessControl
		{
			EnableController = state,
			IpAddress = ipAddress,
			ApiVersion = apiVersion,
			MaxCameras = maxCameras,
			Capablities = capablities,
			EmulationSettings = emuSettings?.ToArray()
		})));
	}

	public static async Task<InSightControllerState> GetControllerState(Client client)
	{
		return ReadStateFromResponse(await SendToControllerService(client, "getStatus"));
	}

	private static InSightControllerState ReadStateFromResponse(string rcvStr)
	{
		if (string.IsNullOrWhiteSpace(rcvStr))
		{
			return null;
		}
		Message message = JsonConvert.DeserializeObject<Message>(rcvStr);
		if (message != null && message.Url == "getStatus" && message.Data != null)
		{
			try
			{
				return JsonConvert.DeserializeObject<InSightControllerState>(message.Data);
			}
			catch (Exception arg)
			{
				Logger.Error($"Unexpected error when deserializing the state {arg}");
				return null;
			}
		}
		Logger.Error("Unexpected return when getting the state");
		return null;
	}
}
