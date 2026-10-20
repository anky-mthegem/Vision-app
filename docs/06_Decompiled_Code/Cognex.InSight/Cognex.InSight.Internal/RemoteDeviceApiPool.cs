#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Features;
using Cognex.Remoting.CogSocket;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

internal class RemoteDeviceApiPool
{
	private class TF1EwWuQ78UqpDNhua
	{
		public IRemoteDeviceApi TEJmv8YEEy;

		public int bZymZBbxDR;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TF1EwWuQ78UqpDNhua()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NM18V2seNIuxUV4laTp3();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NM18V2seNIuxUV4laTp3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h9ebrYseP3Ul293ThjfH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iOPpsWseYE1ensplbAtH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string wssAddressUri;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass7_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dtuvecser0WkmFiQygAy();
			PSiTPlse3Cw0HOvNQCR9(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CRetrieveDevice_003Eb__0(object sender, EventArgs args)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K0LUBEseOmlFtGAh5HE8(wssAddressUri);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dtuvecser0WkmFiQygAy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PSiTPlse3Cw0HOvNQCR9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aj1B1hsexnKPhXSyZfi1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a0SXWTse1DUYaNTDeINu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K0LUBEseOmlFtGAh5HE8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uK3X73hqsB((string)P_0);
		}
	}

	[CompilerGenerated]
	private static readonly FeatureFlag ikEXRLRm3u;

	internal static readonly TraceSwitch TraceSwitch;

	private static readonly Dictionary<string, TF1EwWuQ78UqpDNhua> ByWXs7Sr7L;

	private static readonly object fCRX6qxOiZ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private static FeatureFlag feWX0xEaBL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ikEXRLRm3u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RemoteDeviceApiPool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gSqRSE476rueDJXE4JB();
		int num;
		if (!wO3jYN4tWZ4k39mfimJ())
		{
			num = 5;
			if (!gSqRSE476rueDJXE4JB())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0072;
		IL_002e:
		fCRX6qxOiZ = new object();
		num = 4;
		goto IL_0072;
		IL_0072:
		while (true)
		{
			switch (num)
			{
			case 6:
				TraceSwitch = new TraceSwitch((string)ElPNOo4KkM9pJlMybQh(45920), (string)ElPNOo4KkM9pJlMybQh(45956));
				break;
			case 2:
			{
				FeatureDescriptor featureDescriptor = new FeatureDescriptor();
				dKbjAd45TQmqa2Y0LBt(featureDescriptor, ElPNOo4KkM9pJlMybQh(45708));
				vtxLsk4obMKX5KjxRJ0(featureDescriptor, ElPNOo4KkM9pJlMybQh(45798));
				ikEXRLRm3u = (FeatureFlag)eV8wl84PY0EtAiW5JTs(featureDescriptor);
				num = 6;
				continue;
			}
			case 0:
			case 5:
				sIncfN4CW42wjW9ddv4();
				num = 2;
				continue;
			case 4:
				ByWXs7Sr7L = new Dictionary<string, TF1EwWuQ78UqpDNhua>();
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IRemoteDeviceApi RetrieveDevice(string wssAddressUri, string httpAddressUri, string username)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gSqRSE476rueDJXE4JB())
		{
			num = 2;
			if (!gSqRSE476rueDJXE4JB())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0043;
		IL_008a:
		IDisposable disposable = (IDisposable)lK6Gmc4YkZ4UVWEygTq(CvsTraceSDK.Info, ElPNOo4KkM9pJlMybQh(46036));
		num = 5;
		goto IL_0043;
		IL_0043:
		_003C_003Ec__DisplayClass7_0 obj2 = default;
		CogSocketRemoteDeviceApi cogSocketRemoteDeviceApi = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 3;
				if (wO3jYN4tWZ4k39mfimJ())
				{
				}
				continue;
			case 0:
			case 2:
				obj2 = new _003C_003Ec__DisplayClass7_0();
				break;
			case 3:
				goto IL_008a;
			case 5:
				try
				{
					TF1EwWuQ78UqpDNhua value = null;
					Task task = null;
					object obj = fCRX6qxOiZ;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						_ = 0;
						switch ((!gSqRSE476rueDJXE4JB()) ? 3 : 2)
						{
						case 0:
						case 2:
							if (ByWXs7Sr7L.TryGetValue(obj2.wssAddressUri, out value))
							{
								break;
							}
							goto end_IL_00b7;
						}
						value.bZymZBbxDR++;
						end_IL_00b7:;
					}
					finally
					{
						if (lockTaken)
						{
							wP198m4NioysEYI91dP(obj);
						}
					}
					if (value == null)
					{
						string result = ConnectionTokenHelper.GetTokenAsync(new Uri(httpAddressUri)).Result;
						obj = fCRX6qxOiZ;
						lockTaken = false;
						try
						{
							Monitor.Enter(obj, ref lockTaken);
							int num2 = 2;
							if (false)
							{
								goto IL_017d;
							}
							goto IL_0227;
							IL_017d:
							ByWXs7Sr7L[obj2.wssAddressUri] = value;
							num2 = 10;
							goto IL_0227;
							IL_0227:
							while (true)
							{
								switch (num2)
								{
								case 7:
								case 8:
									break;
								case 0:
									throw LdoYiZ4rP7CalnqvISg(task);
								case 6:
									cogSocketRemoteDeviceApi = new CogSocketRemoteDeviceApi(result);
									cogSocketRemoteDeviceApi.Initialize(obj2.wssAddressUri, httpAddressUri, username);
									num2 = 9;
									continue;
								case 2:
									if (!ByWXs7Sr7L.TryGetValue(obj2.wssAddressUri, out value))
									{
										num2 = 6;
										continue;
									}
									goto case 10;
								case 3:
									PjF4b04xOSbIDjeTwdO(cogSocketRemoteDeviceApi, new EventHandler(obj2._003CRetrieveDevice_003Eb__0));
									goto case 1;
								default:
									num2 = 1;
									continue;
								case 1:
									task = (Task)q86i2d412heZ8Ey6yk7(cogSocketRemoteDeviceApi);
									_ = 1;
									if (wO3jYN4tWZ4k39mfimJ())
									{
										num2 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									}
									num2 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									cogSocketRemoteDeviceApi.PreviewMessage += eQXXmAYkiB;
									num2 = 3;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
								case 5:
									if (task.Exception == null)
									{
										value = new TF1EwWuQ78UqpDNhua
										{
											TEJmv8YEEy = cogSocketRemoteDeviceApi
										};
										break;
									}
									num2 = 0;
									if (gSqRSE476rueDJXE4JB())
									{
										continue;
									}
									goto case 10;
								case 10:
									value.bZymZBbxDR++;
									goto end_IL_0227;
								}
								goto IL_017d;
								continue;
								end_IL_0227:
								break;
							}
						}
						finally
						{
							if (lockTaken)
							{
								wP198m4NioysEYI91dP(obj);
							}
						}
					}
					if (task != null)
					{
						try
						{
							task.Wait();
						}
						catch (AggregateException ex)
						{
							FwfXXl43kwHLivZnfDC(obj2.wssAddressUri);
							throw pyDh8l4O0GwcAOW829w(ex);
						}
					}
					return value.TEJmv8YEEy;
				}
				finally
				{
					disposable?.Dispose();
				}
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		obj2.wssAddressUri = wssAddressUri;
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void uK3X73hqsB(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)lK6Gmc4YkZ4UVWEygTq(CvsTraceSDK.Info, EGBEu24QZnkDvWxNtIG(ElPNOo4KkM9pJlMybQh(46068), CR6Ft64MXKRYZ8Zn48v(P_0)));
		try
		{
			lock (fCRX6qxOiZ)
			{
				int num = 0;
				TF1EwWuQ78UqpDNhua value = default;
				while (true)
				{
					switch (num)
					{
					case 1:
					case 3:
						gR8JCT4l7NuvjXI4nZe(value.TEJmv8YEEy);
						goto default;
					case 0:
						while (ByWXs7Sr7L.TryGetValue(P_0, out value))
						{
							wO3jYN4tWZ4k39mfimJ();
							if (!gSqRSE476rueDJXE4JB())
							{
								num = 4;
								if (gSqRSE476rueDJXE4JB())
								{
									goto end_IL_0065;
								}
								continue;
							}
							num = 3;
							goto end_IL_0065;
						}
						goto default;
					default:
						ByWXs7Sr7L.Remove(P_0);
						num = 5;
						break;
					case 5:
						{
							wsDCq94eFkEej7TDVeR(CvsTraceSDK.Info, EGBEu24QZnkDvWxNtIG(ElPNOo4KkM9pJlMybQh(46114), CR6Ft64MXKRYZ8Zn48v(P_0)));
							return;
						}
						end_IL_0065:
						break;
					}
				}
			}
		}
		finally
		{
			if (disposable != null)
			{
				gR8JCT4l7NuvjXI4nZe(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrement(string addressUri)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)lK6Gmc4YkZ4UVWEygTq(CvsTraceSDK.Info, EGBEu24QZnkDvWxNtIG(ElPNOo4KkM9pJlMybQh(46200), CR6Ft64MXKRYZ8Zn48v(addressUri)));
		try
		{
			bool flag = false;
			object obj = fCRX6qxOiZ;
			bool lockTaken = false;
			TF1EwWuQ78UqpDNhua value = default;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 2:
						if (value.bZymZBbxDR <= 0)
						{
							goto case 5;
						}
						goto end_IL_0069;
					default:
						num = 5;
						continue;
					case 5:
						flag = true;
						goto case 4;
					case 1:
					case 3:
						return;
					case 4:
					case 6:
						ByWXs7Sr7L.Remove(addressUri);
						num = 7;
						continue;
					case 0:
						if (ByWXs7Sr7L.TryGetValue(addressUri, out value))
						{
							value.bZymZBbxDR--;
							num = 2;
							if (gSqRSE476rueDJXE4JB())
							{
								continue;
							}
							goto case 4;
						}
						_ = 0;
						if (!gSqRSE476rueDJXE4JB())
						{
							num = 6;
							if (0 == 0)
							{
								continue;
							}
							return;
						}
						num = 3;
						if (!wO3jYN4tWZ4k39mfimJ())
						{
							continue;
						}
						break;
					case 7:
						break;
					}
					wsDCq94eFkEej7TDVeR(CvsTraceSDK.Info, EGBEu24QZnkDvWxNtIG(ElPNOo4KkM9pJlMybQh(46222), CR6Ft64MXKRYZ8Zn48v(addressUri)));
					break;
					continue;
					end_IL_0069:
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					wP198m4NioysEYI91dP(obj);
				}
			}
			if (flag)
			{
				gR8JCT4l7NuvjXI4nZe(value.TEJmv8YEEy);
			}
		}
		finally
		{
			if (disposable != null)
			{
				gR8JCT4l7NuvjXI4nZe(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void eQXXmAYkiB(object P_0, MessagePayloadPreviewEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		string text = default;
		while (true)
		{
			object obj;
			string text2;
			switch (num)
			{
			case 8:
				wsDCq94eFkEej7TDVeR(CvsTraceSDK.RxPayloadCogSocket, text);
				num = 0;
				break;
			case 5:
				if (WfsfDg4ukTbCEi3qTdS(P_1))
				{
					_ = 1;
					num = (wO3jYN4tWZ4k39mfimJ() ? 6 : 9);
					break;
				}
				wsDCq94eFkEej7TDVeR(CvsTraceSDK.TxCogSocket, (string)sJPryO4ISrfUpJnX5dH(P_1));
				goto case 0;
			case 0:
			case 3:
				if (!WoK3qO4nKbmGFbe7TOH(TraceSwitch))
				{
					num = 4;
					break;
				}
				goto IL_0068;
			case 6:
				return;
			case 7:
				return;
			case 4:
				if (!S0FgML4XBvJqcZx2OeR(A12sV84GORpJXHGyBtn()))
				{
					return;
				}
				goto IL_0068;
			case 1:
			case 9:
				text = (string)sJPryO4ISrfUpJnX5dH(P_1);
				num = 10;
				break;
			default:
				num = 3;
				break;
			case 2:
				obj = ElPNOo4KkM9pJlMybQh(46284);
				goto IL_013c;
			case 10:
				if (SbbFFQ4R2GGg82KxQNB(CvsTraceSDK.RxCogSocket))
				{
					wsDCq94eFkEej7TDVeR(CvsTraceSDK.RxCogSocket, R9XltV4aR1P6y0xdB47(text, 100));
					num = 8;
					break;
				}
				goto case 8;
			case 11:
				return;
				IL_0068:
				if (!WfsfDg4ukTbCEi3qTdS(P_1))
				{
					num = 2;
					if (gSqRSE476rueDJXE4JB())
					{
						break;
					}
					goto case 4;
				}
				obj = ElPNOo4KkM9pJlMybQh(46304);
				goto IL_013c;
				IL_013c:
				text2 = (string)obj;
				d3hpNS4b1o24ET6FPeH(P_1.Payload, text2);
				num = 11;
				if (gSqRSE476rueDJXE4JB())
				{
					break;
				}
				goto case 10;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string XM9XnI8ThB(string P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0.Length <= P_1)
		{
			return P_0;
		}
		return (string)N9BEjG40GBmLWEOAIyT(ElPNOo4KkM9pJlMybQh(46324), P_0.Substring(0, Math.Min(P_1, BXULo846ExbFG79UNj9(P_0))), ElPNOo4KkM9pJlMybQh(42482), l1CgWr4psCghwt6DREb(P_0, BXULo846ExbFG79UNj9(P_0) - 10));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string fglX9LcByb(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)HvPGvr44n9kv806dCZ0(ElPNOo4KkM9pJlMybQh(46350), P_1, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string TGHXUBpK8X(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int startIndex = XBpSWR4kbrJxxadJNDp(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(3810));
		return P_0.Substring(startIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoteDeviceApiPool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sIncfN4CW42wjW9ddv4();
		SkeNE54frVTfOIZilWk(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sIncfN4CW42wjW9ddv4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ElPNOo4KkM9pJlMybQh(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dKbjAd45TQmqa2Y0LBt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Id = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vtxLsk4obMKX5KjxRJ0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FeatureDescriptor)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eV8wl84PY0EtAiW5JTs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return FeatureRegistry.RegisterFeature((FeatureDescriptor)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gSqRSE476rueDJXE4JB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wO3jYN4tWZ4k39mfimJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lK6Gmc4YkZ4UVWEygTq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wP198m4NioysEYI91dP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PjF4b04xOSbIDjeTwdO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocketRemoteDeviceApi)P_0).Closed += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q86i2d412heZ8Ey6yk7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogSocketRemoteDeviceApi)P_0).Connect();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LdoYiZ4rP7CalnqvISg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Task)P_0).Exception;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FwfXXl43kwHLivZnfDC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uK3X73hqsB((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pyDh8l4O0GwcAOW829w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).InnerException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CR6Ft64MXKRYZ8Zn48v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TGHXUBpK8X((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EGBEu24QZnkDvWxNtIG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fglX9LcByb((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gR8JCT4l7NuvjXI4nZe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wsDCq94eFkEej7TDVeR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WfsfDg4ukTbCEi3qTdS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MessagePayloadPreviewEventArgs)P_0).IsIncoming;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sJPryO4ISrfUpJnX5dH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MessagePayloadPreviewEventArgs)P_0).Payload;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SbbFFQ4R2GGg82KxQNB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R9XltV4aR1P6y0xdB47(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XM9XnI8ThB((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WoK3qO4nKbmGFbe7TOH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TraceSwitch)P_0).TraceInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A12sV84GORpJXHGyBtn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return feWX0xEaBL();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S0FgML4XBvJqcZx2OeR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FeatureFlag)P_0).IsEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d3hpNS4b1o24ET6FPeH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Trace.WriteLine(P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BXULo846ExbFG79UNj9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l1CgWr4psCghwt6DREb(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N9BEjG40GBmLWEOAIyT(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HvPGvr44n9kv806dCZ0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XBpSWR4kbrJxxadJNDp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).LastIndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SkeNE54frVTfOIZilWk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
