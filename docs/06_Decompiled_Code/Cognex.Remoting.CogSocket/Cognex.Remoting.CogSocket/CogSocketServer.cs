using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using A7c0WcVILREGX7lECq;
using IawbpyxeWauKVJvQ4t;
using Newtonsoft.Json;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp.Server;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

public class CogSocketServer : IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass12_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			chGEH4RFDCLr0lhxanm();
			FD8F8VRPvbK9w1c0AnQ(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterEndpointsById_003Eb__0(kHE6HCn2iTZpPEx1gT endpoint)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			object obj = jEIWYTRhrCmOpNkTu9n(qc7qH7RB5FhYlxKpWxv(endpoint));
			return (string)((obj != null) ? GU6WnoRiikXXmMceMJD(obj, tuNam1RSADRkXlDmKjq(368)) : null) == id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void chGEH4RFDCLr0lhxanm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FD8F8VRPvbK9w1c0AnQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y0rAvVR9H3J1W7icJYO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ga1X2WR6cS8BZ4Ta6Wb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qc7qH7RB5FhYlxKpWxv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WebSocketBehavior)P_0).Context;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jEIWYTRhrCmOpNkTu9n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WebSocketContext)P_0).QueryString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tuNam1RSADRkXlDmKjq(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GU6WnoRiikXXmMceMJD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((NameValueCollection)P_0)[(string)P_1];
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public IRemoteResourceRoot root;

		public IRemoteSerializer payloadSerializer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
			twQEklRY7ngvmwphjZN(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal kHE6HCn2iTZpPEx1gT _003C_002Ector_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new kHE6HCn2iTZpPEx1gT(root, payloadSerializer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void twQEklRY7ngvmwphjZN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CyjXLJRWWZd8k3gyZq3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HfrJC0Rl2C5YteTbxXJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private WebSocketServer Niiity5bQv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketServer(int portNum, IRemoteResourceRoot root, JsonSerializerSettings serializerSettings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BRrBrr4lSa4vLZrjVRK();
		this._002Ector(portNum, root, new JsonRemoteSerializer(serializerSettings));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketServer(int portNum, IRemoteResourceRoot root, IRemoteSerializer payloadSerializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003C_003Ec__DisplayClass3_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				obj.payloadSerializer = payloadSerializer;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 1:
				obj = new _003C_003Ec__DisplayClass3_0();
				num = 8;
				break;
			case 4:
				GiK94Q4YGv0Bgd0Qfgy(this);
				num = 2;
				break;
			case 2:
				Niiity5bQv = new WebSocketServer(portNum);
				num = 6;
				break;
			case 7:
				BRrBrr4lSa4vLZrjVRK();
				FrOiWn4WtukIT45juUr();
				if (s7iRGr4idnE03JATCul())
				{
					num = 0;
					if (FrOiWn4WtukIT45juUr())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			case 6:
				Niiity5bQv.AddWebSocketService((string)vtERVA4gqHLpnxQTyZu(1210), obj._003C_002Ector_003Eb__0);
				num = 9;
				break;
			case 8:
				obj.root = root;
				goto case 3;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ikDlZf4zcMHWwOZc7kH(Niiity5bQv);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (FrOiWn4WtukIT45juUr() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				Niiity5bQv = null;
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 0:
			case 3:
				break;
			case 1:
				g6IAVrDmLVnQJME4d2A(Niiity5bQv);
				goto default;
			case 5:
				return;
			}
			if (Niiity5bQv != null)
			{
				num = 1;
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> Post(string path, object[] args, string clientId = null, RequestOptions options = default(RequestOptions))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<kHE6HCn2iTZpPEx1gT> list = yM5iVDtMuG(clientId);
		if (list.Count == 0)
		{
			Task.FromResult(new object[0]);
		}
		List<Task<object>> list2 = new List<Task<object>>(list.Count);
		foreach (kHE6HCn2iTZpPEx1gT item in list)
		{
			list2.Add(item.bPmiALwEMq().PostAsync(path, args, options));
		}
		return Task.WhenAll(list2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> Get(string path, string clientId = null, RequestOptions options = default(RequestOptions))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<kHE6HCn2iTZpPEx1gT> list = yM5iVDtMuG(clientId);
		if (list.Count == 0)
		{
			Task.FromResult(new object[0]);
		}
		List<Task<object>> list2 = new List<Task<object>>(list.Count);
		foreach (kHE6HCn2iTZpPEx1gT item in list)
		{
			list2.Add(item.bPmiALwEMq().GetAsync(path, options));
		}
		return Task.WhenAll(list2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> Put(string path, object value, string clientId = null, RequestOptions options = default(RequestOptions))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<kHE6HCn2iTZpPEx1gT> list = yM5iVDtMuG(clientId);
		if (list.Count == 0)
		{
			Task.FromResult(new object[0]);
		}
		List<Task<object>> list2 = new List<Task<object>>(list.Count);
		foreach (kHE6HCn2iTZpPEx1gT item in list)
		{
			list2.Add(item.bPmiALwEMq().PutAsync(path, value, options));
		}
		return Task.WhenAll(list2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> TriggerEvent(string path, string clientId = null, RequestOptions options = default(RequestOptions))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<kHE6HCn2iTZpPEx1gT> list = yM5iVDtMuG(clientId);
		if (list.Count == 0)
		{
			Task.FromResult(new object[0]);
		}
		List<Task<object>> list2 = new List<Task<object>>(list.Count);
		foreach (kHE6HCn2iTZpPEx1gT item in list)
		{
			list2.Add(item.bPmiALwEMq().TriggerEventAsync(path, options));
		}
		return Task.WhenAll(list2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> InvokeDelegate(string path, object[] args, string clientId = null, RequestOptions options = default(RequestOptions))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<kHE6HCn2iTZpPEx1gT> list = yM5iVDtMuG(clientId);
		if (list.Count == 0)
		{
			Task.FromResult(new object[0]);
		}
		List<Task<object>> list2 = new List<Task<object>>(list.Count);
		foreach (kHE6HCn2iTZpPEx1gT item in list)
		{
			list2.Add(item.bPmiALwEMq().InvokeAsync(path, args, options));
		}
		return Task.WhenAll(list2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void UnsafeSendMessageAsync(CogSocketMessage message, string clientId = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!FrOiWn4WtukIT45juUr())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		List<kHE6HCn2iTZpPEx1gT> list = default;
		List<kHE6HCn2iTZpPEx1gT>.Enumerator enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				throw new ArgumentNullException(UNkfE94JEjYP98PsqC.cGFu3AUnFy(58));
			case 6:
				return;
			case 0:
			case 4:
				if (message != null)
				{
					if (message != null)
					{
						list = yM5iVDtMuG(clientId);
						goto case 2;
					}
					num = 3;
					continue;
				}
				goto case 1;
			case 2:
				if (c83tLMDphWtLNVFgprY(list) != 0)
				{
					enumerator = list.GetEnumerator();
					num = 7;
				}
				else
				{
					num = 6;
				}
				continue;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						ABxD0IDDGQ2X22Rk7xv(GGvthaD4JbkISf25E3R(enumerator.Current), message);
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		throw new ArgumentNullException((string)vtERVA4gqHLpnxQTyZu(58));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<kHE6HCn2iTZpPEx1gT> yM5iVDtMuG(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals3.id = P_0;
		IEnumerable<IWebSocketSession> enumerable = Niiity5bQv.WebSocketServices[UNkfE94JEjYP98PsqC.cGFu3AUnFy(1210)]?.Sessions?.Sessions;
		if (enumerable == null)
		{
			return new List<kHE6HCn2iTZpPEx1gT>();
		}
		IEnumerable<kHE6HCn2iTZpPEx1gT> source = enumerable.OfType<kHE6HCn2iTZpPEx1gT>();
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals3.id))
		{
			return source.ToList();
		}
		return source.Where([MethodImpl(MethodImplOptions.NoInlining)] (kHE6HCn2iTZpPEx1gT endpoint) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			object obj = _003C_003Ec__DisplayClass12_0.jEIWYTRhrCmOpNkTu9n(_003C_003Ec__DisplayClass12_0.qc7qH7RB5FhYlxKpWxv(endpoint));
			return (string)((obj != null) ? _003C_003Ec__DisplayClass12_0.GU6WnoRiikXXmMceMJD(obj, _003C_003Ec__DisplayClass12_0.tuNam1RSADRkXlDmKjq(368)) : null) == CS_0024_003C_003E8__locals3.id;
		}).ToList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BRrBrr4lSa4vLZrjVRK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s7iRGr4idnE03JATCul()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FrOiWn4WtukIT45juUr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GiK94Q4YGv0Bgd0Qfgy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vtERVA4gqHLpnxQTyZu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ikDlZf4zcMHWwOZc7kH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WebSocketServer)P_0).Start();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g6IAVrDmLVnQJME4d2A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WebSocketServer)P_0).Stop();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int c83tLMDphWtLNVFgprY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<kHE6HCn2iTZpPEx1gT>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GGvthaD4JbkISf25E3R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((kHE6HCn2iTZpPEx1gT)P_0).bPmiALwEMq();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ABxD0IDDGQ2X22Rk7xv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocket)P_0).UnsafeSendMessageAsync((CogSocketMessage)P_1);
	}
}
