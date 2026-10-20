using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal static class ConnectionTokenHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetBaseTokenAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Uri httpUri;

		private HttpClient _003Cclient_003E5__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!VrRPpYZIbv9UhDuFWar())
			{
				goto IL_001e;
			}
			goto IL_0037;
			IL_001e:
			_003Cclient_003E5__2 = null;
			goto IL_008b;
			IL_0037:
			int num2 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default;
			HttpResponseMessage result = default;
			HttpStatusCode httpStatusCode = default;
			string result2 = default;
			ConfiguredTaskAwaitable<string> configuredTaskAwaitable2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 4:
					goto IL_0068;
				default:
					goto IL_008b;
				case 1:
				case 2:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003Cclient_003E5__2 = HttpClientHelper.CreateHttpClient(httpUri);
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 16;
									if (false)
									{
										goto IL_0391;
									}
								}
								else
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 1;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num3 = 11;
							}
							while (true)
							{
								switch (num3)
								{
								case 3:
									awaiter2 = configuredTaskAwaitable.GetAwaiter();
									VrRPpYZIbv9UhDuFWar();
									if (!bAA2o7ZRs4OiBqmVk61())
									{
										num3 = 17;
										if (VrRPpYZIbv9UhDuFWar())
										{
											continue;
										}
										goto case 2;
									}
									num3 = 18;
									if (VrRPpYZIbv9UhDuFWar())
									{
										continue;
									}
									goto case 7;
								case 2:
								case 17:
									if (!awaiter2.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto IL_0317;
								case 10:
									throw new CvsHttpNetworkException((string)gdKdmjZau2O5wMMY5FK(48402), result.StatusCode);
								case 13:
									goto end_IL_022e;
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 6;
									if (true)
									{
										continue;
									}
									goto case 20;
								case 20:
									httpStatusCode = z8axDJZnscklAuxHYl0(result);
									goto case 8;
								case 7:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 14;
									if (true)
									{
										continue;
									}
									return;
								case 19:
									return;
								case 9:
									if (httpStatusCode != HttpStatusCode.NotFound)
									{
										break;
									}
									result2 = null;
									num3 = 21;
									continue;
								default:
									num3 = 4;
									continue;
								case 6:
									result2 = awaiter.GetResult();
									num3 = 13;
									continue;
								case 12:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 5:
									awaiter = configuredTaskAwaitable2.GetAwaiter();
									num3 = 15;
									continue;
								case 15:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 0;
										continue;
									}
									goto case 6;
								case 8:
								case 18:
									if (httpStatusCode == HttpStatusCode.OK)
									{
										if (!ibbDLbZ69alnnAuEaTe(BAuDPNZbu1RN5bElPcw(kYNvx4ZXbf1PMFYgY6i(((HttpContent)G9GfwZZG0KifCmmpXOi(result)).Headers)), gdKdmjZau2O5wMMY5FK(48378), StringComparison.Ordinal))
										{
											num3 = 10;
											if (bAA2o7ZRs4OiBqmVk61())
											{
											}
										}
										else
										{
											configuredTaskAwaitable2 = result.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
											num3 = 5;
										}
									}
									else
									{
										num3 = 9;
									}
									continue;
								case 11:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0317;
								case 0:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 19;
									continue;
								case 14:
									return;
								case 16:
									configuredTaskAwaitable = _003Cclient_003E5__2.GetAsync((string)gdKdmjZau2O5wMMY5FK(48328)).ConfigureAwait(continueOnCapturedContext: false);
									num3 = 3;
									continue;
								case 21:
									goto end_IL_022e;
								case 4:
									break;
									IL_0317:
									result = awaiter2.GetResult();
									num3 = 20;
									if (VrRPpYZIbv9UhDuFWar())
									{
										continue;
									}
									goto case 0;
								}
								goto IL_0391;
								continue;
								end_IL_022e:
								break;
							}
							goto end_IL_00ba;
							IL_0391:
							throw new CvsHttpNetworkException((string)gdKdmjZau2O5wMMY5FK(48506), z8axDJZnscklAuxHYl0(result));
							end_IL_00ba:;
						}
						finally
						{
							if (num2 < 0 && _003Cclient_003E5__2 != null)
							{
								jqenOoZpcr3oCIWQt4P(_003Cclient_003E5__2);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cclient_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 0;
					continue;
				case 6:
					return;
				}
				break;
				IL_0068:
				num2 = _003C_003E1__state;
				VrRPpYZIbv9UhDuFWar();
				if (bAA2o7ZRs4OiBqmVk61())
				{
					num = 5;
					continue;
				}
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto IL_008b;
			}
			goto IL_001e;
			IL_008b:
			_003C_003Et__builder.SetResult(result2);
			num = 6;
			goto IL_0037;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gdKdmjZau2O5wMMY5FK(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode z8axDJZnscklAuxHYl0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G9GfwZZG0KifCmmpXOi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kYNvx4ZXbf1PMFYgY6i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContentHeaders)P_0).ContentType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BAuDPNZbu1RN5bElPcw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MediaTypeHeaderValue)P_0).MediaType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ibbDLbZ69alnnAuEaTe(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jqenOoZpcr3oCIWQt4P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VrRPpYZIbv9UhDuFWar()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAA2o7ZRs4OiBqmVk61()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetTokenAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Uri httpUri;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			apBuWXZ05cxH6SdagcN();
			int num = (LZH6b7Z4vw6VgkHqTFn() ? 1 : 3);
			int num2 = default;
			ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default;
			string result2 = default;
			string result = default;
			do
			{
				IL_01b8:
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = GetBaseTokenAsync(httpUri).ConfigureAwait(continueOnCapturedContext: false);
							_ = 0;
							num3 = ((!apBuWXZ05cxH6SdagcN()) ? 2 : 8);
							goto IL_00e9;
						}
						awaiter = _003C_003Eu__1;
						goto IL_007a;
						IL_00e9:
						while (true)
						{
							switch (num3)
							{
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 11:
								if (result2 != null)
								{
									num3 = 10;
									continue;
								}
								result = null;
								goto end_IL_00e9;
							case 9:
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 6;
							case 10:
								result = (string)BGdStjZkYNjQ3IS9COC(result2);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								result2 = awaiter.GetResult();
								num3 = 11;
								continue;
							case 2:
								return;
							case 4:
								return;
							default:
								num3 = 9;
								continue;
							case 0:
							case 8:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 3;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								goto end_IL_00e9;
							}
							goto IL_007a;
							continue;
							end_IL_00e9:
							break;
						}
						goto end_IL_0028;
						IL_007a:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00e9;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						goto IL_01b8;
					}
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
			}
			while (apBuWXZ05cxH6SdagcN());
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BGdStjZkYNjQ3IS9COC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GenerateDerivedToken((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool apBuWXZ05cxH6SdagcN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LZH6b7Z4vw6VgkHqTFn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, byte, string> _003C_003E9__13_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			squQM3ZmmEyl5wHfkY8();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			squQM3ZmmEyl5wHfkY8();
			Uwuy52Zy6UPBBjDd0Cn(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetObfuscatedAssemblyPublicKey_003Eb__13_0(string str, byte keyByte)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return str = (string)qftRGJZZ9Sm99FCvJNV(str, Cl5ss3ZgcjeNhWBrRgw((byte)(keyByte ^ 0xDA)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void squQM3ZmmEyl5wHfkY8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rn2cIeZfxoaWYxrAFw4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SWI54sZFGbJQBPB7ijO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Uwuy52Zy6UPBBjDd0Cn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Cl5ss3ZgcjeNhWBrRgw(byte P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lqVIsxt9Fn(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qftRGJZZ9Sm99FCvJNV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}
	}

	public const string ConnectionTokenRequestEndpoint = "/system/connectionToken";

	public const string ConnectionTokenHttpHeader = "Cognex-InSight-Connection-Token";

	public const string UserHttpHeader = "Cognex-InSight-User";

	public const string ConnectionTokenQueryParameterName = "connectionToken";

	public const string UserQueryParameterName = "user";

	private static string xRnI6Wco85;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Authorize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xRnI6Wco85 = (string)Hiw7fALq6IEqBoOk9DO(Assembly.GetCallingAssembly());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Unauthorize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xRnI6Wco85 = "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetBaseTokenAsync_003Ed__9))]
	public static Task<string> GetBaseTokenAsync(Uri httpUri)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetBaseTokenAsync_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.httpUri = httpUri;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTokenAsync_003Ed__10))]
	public static Task<string> GetTokenAsync(Uri httpUri)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTokenAsync_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.httpUri = httpUri;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GenerateDerivedToken(string baseToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Araa8cLdtCct84Ia8Rr()) ? 9 : 10);
		int num2 = default;
		byte[] data = default;
		string text = default;
		byte[] bytes = default;
		string s = default;
		IncrementalHash incrementalHash = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				throw new ArgumentException((string)fhMh0fLj5dlHo3pj7pa(1300), kgbOBx7BanbFa22Hp9.ol99ukmDA(1358));
			case 3:
			case 9:
				num2 = Y4LwZkLWieU5pjLRDXh(baseToken) / 2;
				num = 7;
				continue;
			case 6:
				data = (byte[])ooCCrOLKmTrMB5uuveH(rwO0sqLCOxs2er848sq(RnKVkELtm2VI3EucGWZ(), text));
				num = 8;
				if (!tE7rFVLiEfVRkK0xfS6())
				{
					continue;
				}
				goto case 7;
			case 7:
				text = (string)OwdrWtL7grrsQEghoKU(baseToken, num2);
				goto case 5;
			default:
				num = 5;
				continue;
			case 8:
				bytes = ((Encoding)RnKVkELtm2VI3EucGWZ()).GetBytes(s);
				num = 2;
				continue;
			case 5:
				s = baseToken.Substring(0, num2);
				num = 6;
				if (!tE7rFVLiEfVRkK0xfS6())
				{
					continue;
				}
				goto case 1;
			case 1:
				if (num2 < 0)
				{
					goto case 3;
				}
				goto case 7;
			case 2:
				incrementalHash = (IncrementalHash)mN4oUKLohOjV7MmecQv(geksV2L5xJwgnc8eZum());
				num = 11;
				if (!tE7rFVLiEfVRkK0xfS6())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 10:
				if (!MJD1u9LBbWsHg1Y0Fcs(baseToken))
				{
					num2 = yZXZ9aL2AwdstlDB4wT(baseToken, nVfxiOLcOSkCZslaTs9(fhMh0fLj5dlHo3pj7pa(1380)));
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				}
				num = 4;
				if (Araa8cLdtCct84Ia8Rr())
				{
					continue;
				}
				break;
			case 11:
				break;
			}
			break;
		}
		byte[] array;
		try
		{
			incrementalHash.AppendData(data);
			tE7rFVLiEfVRkK0xfS6();
			switch ((!Araa8cLdtCct84Ia8Rr()) ? 3 : 2)
			{
			case 0:
			case 2:
				iQBQgMLPWK7IdtIIcio(incrementalHash, bytes);
				break;
			}
			array = (byte[])dXnqCXLYVA7AWfmdlAh(incrementalHash);
		}
		finally
		{
			if (incrementalHash != null)
			{
				UE7p87LNhyc7iWhnl41(incrementalHash);
			}
		}
		return (string)ooBfOWLxV3YxcJNqV6f(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] q3lIwNr2le(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Araa8cLdtCct84Ia8Rr();
		int num = (tE7rFVLiEfVRkK0xfS6() ? 3 : 5);
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				num2 = 0;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				if (num2 >= P_0.Length)
				{
					num = 7;
					continue;
				}
				P_0[num2] ^= 218;
				goto case 6;
			case 0:
			case 5:
				if (new string[1] { IJuIRLdrQ7((Assembly)skOS1HL1bFg1cSrmL8X()) }.Contains(xRnI6Wco85))
				{
					break;
				}
				goto case 1;
			default:
				num = 6;
				continue;
			case 6:
				num2++;
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string IJuIRLdrQ7(Assembly P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable<byte>)g4xWBEL33stE5ySPn5K(A2A65ILrwT2e4mhJjCM(P_0))).Aggregate("", [MethodImpl(MethodImplOptions.NoInlining)] (string str, byte keyByte) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return str = (string)_003C_003Ec.qftRGJZZ9Sm99FCvJNV(str, _003C_003Ec.Cl5ss3ZgcjeNhWBrRgw((byte)(keyByte ^ 0xDA)));
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string lqVIsxt9Fn(byte P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.ToString((string)fhMh0fLj5dlHo3pj7pa(1404));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionTokenHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		xRnI6Wco85 = "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hiw7fALq6IEqBoOk9DO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IJuIRLdrQ7((Assembly)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Araa8cLdtCct84Ia8Rr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tE7rFVLiEfVRkK0xfS6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MJD1u9LBbWsHg1Y0Fcs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fhMh0fLj5dlHo3pj7pa(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nVfxiOLcOSkCZslaTs9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToCharArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yZXZ9aL2AwdstlDB4wT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOfAny((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Y4LwZkLWieU5pjLRDXh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OwdrWtL7grrsQEghoKU(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RnKVkELtm2VI3EucGWZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rwO0sqLCOxs2er848sq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ooCCrOLKmTrMB5uuveH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return q3lIwNr2le((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static HashAlgorithmName geksV2L5xJwgnc8eZum()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HashAlgorithmName.SHA256;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mN4oUKLohOjV7MmecQv(HashAlgorithmName P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IncrementalHash.CreateHash(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iQBQgMLPWK7IdtIIcio(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IncrementalHash)P_0).AppendData((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dXnqCXLYVA7AWfmdlAh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IncrementalHash)P_0).GetHashAndReset();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UE7p87LNhyc7iWhnl41(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ooBfOWLxV3YxcJNqV6f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToBase64String((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object skOS1HL1bFg1cSrmL8X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Assembly.GetExecutingAssembly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A2A65ILrwT2e4mhJjCM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g4xWBEL33stE5ySPn5K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}
}
