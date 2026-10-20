using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using NLog;

namespace Cognex.Platform;

public static class Network
{
	public class RegisteredPort
	{
		public string Id { get; set; }

		public int Port { get; set; }

		public RegisteredPort()
		{
		}

		public RegisteredPort(string id, int port)
		{
			Id = id;
			Port = port;
		}
	}

	private class NetworkChangeListener : IDisposable
	{
		private bool _disposed;

		public event Action NetworkChanged;

		public NetworkChangeListener()
		{
			NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
			NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
		}

		public void Dispose()
		{
			if (!_disposed)
			{
				NetworkChange.NetworkAddressChanged -= NetworkChange_NetworkAddressChanged;
				NetworkChange.NetworkAvailabilityChanged -= NetworkChange_NetworkAvailabilityChanged;
				_disposed = true;
			}
		}

		public bool DisposeIfUnused()
		{
			if (NetworkChanged == null)
			{
				Dispose();
				return true;
			}
			return false;
		}

		private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
		{
			NetworkChanged?.Invoke();
		}

		private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
		{
			NetworkChanged?.Invoke();
		}
	}

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	private static Lazy<NetworkChangeListener> Listener = new Lazy<NetworkChangeListener>();

	public static event Action NetworkChanged
	{
		add
		{
			Listener.Value.NetworkChanged += value;
		}
		remove
		{
			Listener.Value.NetworkChanged -= value;
			if (Listener.Value.DisposeIfUnused())
			{
				Listener = new Lazy<NetworkChangeListener>();
			}
		}
	}

	public static IEnumerable<IPAddress> GetAllNetworkIpAddresses()
	{
		return from ip in (from ni in NetworkInterface.GetAllNetworkInterfaces()
				where ni.OperationalStatus == OperationalStatus.Up
				select ni).SelectMany((NetworkInterface netInfo) => netInfo.GetIPProperties().UnicastAddresses)
			where ip.Address.AddressFamily == AddressFamily.InterNetwork
			select ip.Address;
	}

	public static int GetFreeTcpPort(IPAddress address)
	{
		TcpListener tcpListener = new TcpListener(address, 0);
		tcpListener.Start();
		int port = ((IPEndPoint)tcpListener.LocalEndpoint).Port;
		tcpListener.Stop();
		return port;
	}

	public static IEnumerable<string> GetAllNetworkAdapters()
	{
		return from a in (from ni in NetworkInterface.GetAllNetworkInterfaces()
				where ni.OperationalStatus == OperationalStatus.Up
				select ni).SelectMany((NetworkInterface netInfo) => netInfo.GetIPProperties().UnicastAddresses.Select((UnicastIPAddressInformation ipInfo) => new
			{
				Adapter = netInfo,
				Ip = ipInfo
			}))
			where a.Ip.Address.AddressFamily == AddressFamily.InterNetwork
			select $"{a.Ip.Address} ({a.Adapter.Description})";
	}

	public static string GetAdapterId(IPAddress address)
	{
		return NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault((NetworkInterface ni) => ni.GetIPProperties().UnicastAddresses.Any((UnicastIPAddressInformation a) => a.Address.Equals(address)))?.Id;
	}

	public static IEnumerable<IPAddress> GetAdapterIPs(string adapterId)
	{
		return from a in (from ni in NetworkInterface.GetAllNetworkInterfaces()
				where ni.Id.Equals(adapterId)
				select ni).SelectMany((NetworkInterface netInfo) => netInfo.GetIPProperties().UnicastAddresses)
			select a.Address into a
			where a.AddressFamily == AddressFamily.InterNetwork
			select a;
	}

	public static bool InstallHttpsServerPort(int port, string thumb)
	{
		if (!IsVistaOrGreater())
		{
			Logger.Error("Not running Vista or better");
			throw new NotSupportedException("This OS is not supported.");
		}
		Logger.Info("Running Vista or better");
		string arguments = $"http delete sslcert ipport=0.0.0.0:{port}";
		new ProcessStartInfo("netsh", arguments);
		string arg = "{3B339108-3606-4267-9328-7C466542DB7E}";
		arguments = $"http add sslcert ipport=0.0.0.0:{port} certhash={thumb} appid={arg}";
		if (RunProcess(new ProcessStartInfo("netsh", arguments), out var result, out var error))
		{
			return true;
		}
		Logger.Error($"Install cert error, output: {result} error: {error}");
		return false;
	}

	public static bool UninstallHttpsServerPort(int port)
	{
		if (!IsVistaOrGreater())
		{
			throw new NotSupportedException("This OS is not supported.");
		}
		string arguments = $"http delete sslcert ipport=0.0.0.0:{port}";
		if (RunProcess(new ProcessStartInfo("netsh", arguments), out var result, out var error))
		{
			return true;
		}
		Logger.Warn($"Cert failed to remove or first install, output: {result} error: {error}");
		return false;
	}

	public static bool RunProcess(ProcessStartInfo startInfo, out string result, out string error)
	{
		startInfo.UseShellExecute = false;
		startInfo.RedirectStandardOutput = true;
		startInfo.RedirectStandardError = true;
		startInfo.CreateNoWindow = true;
		result = null;
		error = null;
		try
		{
			using Process process = Process.Start(startInfo);
			process.WaitForExit();
			using (StreamReader streamReader = process.StandardOutput)
			{
				result = streamReader.ReadToEnd();
			}
			using (StreamReader streamReader2 = process.StandardError)
			{
				error = streamReader2.ReadToEnd();
			}
			if (process.ExitCode != 0)
			{
				return false;
			}
		}
		catch (Exception ex)
		{
			Logger.Error($"RunProcess Exception ex:{ex}");
			error = ex.Message;
			return false;
		}
		return true;
	}

	public static bool IsVistaOrGreater()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			return oSVersion.Version.Major >= 6;
		}
		return false;
	}
}
