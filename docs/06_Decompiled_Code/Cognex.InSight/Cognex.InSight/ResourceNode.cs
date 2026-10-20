using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.Remoting.CogSocket;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class ResourceNode : IResourceUriProvider
{
	private readonly IResourceUriProvider VgvO330pyD;

	private readonly string teROLlbNmC;

	public string RootResourceUri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)eLshDFqV2AlCfdpmbsS(VgvO330pyD) + teROLlbNmC;
		}
	}

	public string HttpRootResourceUri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)Y3DFfCqAKWBdL9j2oqs(M2dOt9j1MR(), RootResourceUri);
		}
	}

	IRemoteDeviceApi IResourceUriProvider.DeviceApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M2dOt9j1MR();
		}
	}

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M2dOt9j1MR() != null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IRemoteDeviceApi M2dOt9j1MR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return VgvO330pyD.DeviceApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceNode GetChildResource(string childPath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new ResourceNode(this, childPath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ResourceNode(IResourceUriProvider parentNode, string relativePath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 4:
				teROLlbNmC = relativePath ?? "";
				if (!RootResourceUri.EndsWith((string)btSyDnqTQ0tf24Vg2Qj(3810)))
				{
					num = 5;
					if (EbQx2TqHv1dON36Liq1())
					{
					}
					break;
				}
				return;
			case 5:
				teROLlbNmC = (string)rBtX3gqdxD8qosE7VXc(teROLlbNmC, btSyDnqTQ0tf24Vg2Qj(3810));
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				rHXCvmqD9YiYftAcyeY();
				o9yXhEqvnwVSPrWZPpu();
				if (!EbQx2TqHv1dON36Liq1())
				{
					num = 3;
					if (!EbQx2TqHv1dON36Liq1())
					{
						break;
					}
					goto case 0;
				}
				num = 0;
				break;
			case 0:
			case 2:
				VgvO330pyD = parentNode;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				QCH8oMqUZ35h7TejxEI(this);
				goto case 0;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRootWithoutSeparator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RootResourceUri.Substring(0, UbgZxtqiGJsSf9wlyKw(RootResourceUri) - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetAsync<T>()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetAsync<T>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetAsync<T>(string relativePath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (string.IsNullOrEmpty(relativePath))
		{
			return M2dOt9j1MR().GetAsync<T>(GetRootWithoutSeparator());
		}
		return M2dOt9j1MR().GetAsync<T>(RootResourceUri + relativePath);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Stream> GetHttpAsync(string relativePath, TimeSpan timeout)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().MakeHttpGetRequest(RootResourceUri + relativePath, timeout);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> PostAsync<T>(string relativePath, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().PostAsync<T>(RootResourceUri + relativePath, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Stream> PostHttpAsync(string relativePath, TimeSpan timeout, string contentType, Stream dataStream)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().MakeHttpPostRequest(RootResourceUri + relativePath, timeout, contentType, dataStream);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Stream> PostHttpAsync(string relativePath, TimeSpan timeout, string contentType, Stream dataStream, int contentAt, params object[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().MakeHttpPostRequest(RootResourceUri + relativePath, timeout, contentType, dataStream, contentAt, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> PutAsync<T>(string relativePath, object arg = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().PutAsync<T>(RootResourceUri + relativePath, arg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task AddListener(string eventName, CogSocketEventHandler listener)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)F7dOxAqq0NdrPjWHJwP(M2dOt9j1MR(), RootResourceUri + eventName, listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RemoveListener(string eventName, CogSocketEventHandler listener)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M2dOt9j1MR().RemoveListener((string)rBtX3gqdxD8qosE7VXc(RootResourceUri, eventName), listener);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eLshDFqV2AlCfdpmbsS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IResourceUriProvider)P_0).RootResourceUri;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o9yXhEqvnwVSPrWZPpu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EbQx2TqHv1dON36Liq1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y3DFfCqAKWBdL9j2oqs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)P_0).MakeAbsoluteUrlFromRelativeIfRequired((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rHXCvmqD9YiYftAcyeY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QCH8oMqUZ35h7TejxEI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object btSyDnqTQ0tf24Vg2Qj(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rBtX3gqdxD8qosE7VXc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int UbgZxtqiGJsSf9wlyKw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F7dOxAqq0NdrPjWHJwP(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)P_0).AddListener((string)P_1, (CogSocketEventHandler)P_2);
	}
}
