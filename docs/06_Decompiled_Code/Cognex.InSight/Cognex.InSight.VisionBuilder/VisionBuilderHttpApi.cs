using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Auth0.OidcClient;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Common;
using Cognex.InSight.Properties;
using Cognex.InSight.VisionBuilder.Types;
using IdentityModel.OidcClient;
using Microsoft.Web.WebView2.Core;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class VisionBuilderHttpApi : IVisionBuilderHttpApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAuthorizationTokenAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public VisionBuilderHttpApi _003C_003E4__this;

		private TaskAwaiter<AuthenticationResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			VisionBuilderHttpApi visionBuilderHttpApi = default;
			string result2 = default;
			int num2 = default;
			TaskAwaiter<AuthenticationResult> awaiter = default;
			AuthenticationResult result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					visionBuilderHttpApi = _003C_003E4__this;
					num = 0;
					break;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					raA2o3sdNXWNSu2v2hcA();
					num = (LEA0oasdxhutWu4TvKJK() ? 5 : 2);
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (KD5DyTsd140jF2wOAExk(visionBuilderHttpApi.muTpDkT4ev, visionBuilderHttpApi.Server))
							{
								num3 = 5;
							}
							else
							{
								awaiter = visionBuilderHttpApi.AuthenticateUserAsync().GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_00ac;
								}
								num3 = 10;
								if (1 == 0)
								{
									goto IL_01c3;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 1;
							if (LEA0oasdxhutWu4TvKJK())
							{
								num3 = 11;
								if (!raA2o3sdNXWNSu2v2hcA())
								{
									goto IL_00ca;
								}
							}
							else
							{
								num3 = 3;
							}
						}
						goto IL_0121;
						IL_00ca:
						gJO67Psd3CCKGHDCRyk6(visionBuilderHttpApi.muTpDkT4ev, new UserSession(visionBuilderHttpApi.Server, result));
						num3 = 12;
						goto IL_0121;
						IL_01c3:
						result2 = (string)sN8FKAsdrJnCs2u7PluP(visionBuilderHttpApi.muTpDkT4ev, visionBuilderHttpApi.Server);
						num3 = 2;
						goto IL_0121;
						IL_00ac:
						result = awaiter.GetResult();
						goto IL_00ca;
						IL_0121:
						while (true)
						{
							switch (num3)
							{
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 7:
								break;
							case 9:
							case 11:
								goto IL_00ca;
							case 3:
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 4:
								return;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 2:
								goto end_IL_0060;
							case 5:
								goto IL_01c3;
							case 12:
								result2 = (string)sN8FKAsdrJnCs2u7PluP(visionBuilderHttpApi.muTpDkT4ev, visionBuilderHttpApi.Server);
								goto end_IL_0060;
							}
							break;
						}
						goto IL_00ac;
						end_IL_0060:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
			}
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
		internal static bool KD5DyTsd140jF2wOAExk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUserSessionCache)P_0).IsLoggedInFor((Server)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sN8FKAsdrJnCs2u7PluP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUserSessionCache)P_0).GetAccessTokenFor((Server)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gJO67Psd3CCKGHDCRyk6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IUserSessionCache)P_0).StoreSession((UserSession)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool raA2o3sdNXWNSu2v2hcA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LEA0oasdxhutWu4TvKJK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string url;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass11_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jI3PeGsdQVSQW9AApN9F();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Process _003COpenUrl_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Process)gVXQVNsdlhTD3p1x2iIY(url);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jI3PeGsdQVSQW9AApN9F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UCfGOxsdOc4DtEP0Phve()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CfG7DYsdMuwS2CaHkemm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gVXQVNsdlhTD3p1x2iIY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Process.Start((string)P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COpenUrl_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		private TaskAwaiter<Process> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!pNFjs8sdetvDqcsIa0l3()) ? 3 : 4);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter<Process> awaiter;
						int num3;
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass11_0 obj = new _003C_003Ec__DisplayClass11_0();
							obj.url = url;
							awaiter = Task.Run([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return (Process)_003C_003Ec__DisplayClass11_0.gVXQVNsdlhTD3p1x2iIY(obj.url);
							}).GetAwaiter();
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 7:
								return;
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 6;
								if (!irlAZAsdu8UvQX42ldgO())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (pNFjs8sdetvDqcsIa0l3())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = 0);
								irlAZAsdu8UvQX42ldgO();
								if (!pNFjs8sdetvDqcsIa0l3())
								{
									num3 = 4;
									continue;
								}
								num3 = 0;
								if (irlAZAsdu8UvQX42ldgO())
								{
								}
								continue;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 9:
								break;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					return;
				}
			}
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
		internal static bool pNFjs8sdetvDqcsIa0l3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool irlAZAsdu8UvQX42ldgO()
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
	private struct _003CGetAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public HttpClient client;

		public string url;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			L3aRp6sdRDEQ5oWadR7h();
			int num;
			if (c3fN7hsdIM2EUxOjv9Oj())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
				if (L3aRp6sdRDEQ5oWadR7h())
				{
					return;
				}
			}
			goto IL_0194;
			IL_0194:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 2:
					goto IL_0046;
				default:
					num = 4;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto IL_0046;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0046:
			HttpResponseMessage result = default;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = client.GetAsync(url).GetAwaiter();
					num3 = 3;
					goto IL_00e9;
				}
				awaiter = _003C_003Eu__1;
				goto IL_0089;
				IL_0089:
				_003C_003Eu__1 = default;
				num3 = 0;
				goto IL_00e9;
				IL_00e9:
				while (true)
				{
					switch (num3)
					{
					case 4:
						return;
					case 5:
					case 6:
						break;
					case 1:
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 0;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 4;
						continue;
					case 3:
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							num3 = ((!L3aRp6sdRDEQ5oWadR7h()) ? 2 : 6);
							continue;
						}
						goto case 9;
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						continue;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00e9;
					}
					goto IL_0089;
					continue;
					end_IL_00e9:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_002a;
			IL_002a:
			_003C_003Et__builder.SetResult(result);
			num = 5;
			if (!c3fN7hsdIM2EUxOjv9Oj())
			{
				goto IL_0046;
			}
			goto IL_0194;
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
		internal static bool c3fN7hsdIM2EUxOjv9Oj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L3aRp6sdRDEQ5oWadR7h()
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
	private struct _003CPutAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public HttpClient client;

		public string url;

		public HttpContent payload;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CMfokhsdnI8lFBWGukXL();
			int num = ((!OL6wnusdaUVqxVFpWybQ()) ? 1 : 3);
			int num2 = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter<HttpResponseMessage> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = client.PutAsync(url, payload).GetAwaiter();
							num3 = 8;
							goto IL_00df;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0098;
						IL_0098:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_00df;
						IL_00df:
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 3:
							case 5:
								break;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!CMfokhsdnI8lFBWGukXL()) ? 6 : 3);
									continue;
								}
								goto case 9;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00df;
							}
							goto IL_0098;
							continue;
							end_IL_00df:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
			}
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
		internal static bool OL6wnusdaUVqxVFpWybQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CMfokhsdnI8lFBWGukXL()
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
	private struct _003CPostAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public HttpClient client;

		public string url;

		public HttpContent payload;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (xO8cehsdG0XrcXS5vf9F())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (yO8Gi7sdXH3HEbEwmqDp())
				{
				}
			}
			int num2 = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					try
					{
						TaskAwaiter<HttpResponseMessage> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = client.PostAsync(url, payload).GetAwaiter();
							num3 = 6;
							goto IL_00e5;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0096;
						IL_0096:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_00e5;
						IL_00e5:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 2:
							case 4:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (true)
								{
									continue;
								}
								break;
							case 3:
							case 5:
								break;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (xO8cehsdG0XrcXS5vf9F())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								num3 = (xO8cehsdG0XrcXS5vf9F() ? 2 : 3);
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00e5;
							}
							goto IL_0096;
							continue;
							end_IL_00e5:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
			}
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
		internal static bool xO8cehsdG0XrcXS5vf9F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yO8Gi7sdXH3HEbEwmqDp()
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
	private struct _003CDeleteAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public HttpClient client;

		public string url;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!NRZUOAsd6ZyKQVxT8MrT())
			{
				num = 4;
				if (!RWYbgSsdbuRJltYAA3pu())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (NRZUOAsd6ZyKQVxT8MrT())
				{
					return;
				}
			}
			goto IL_0186;
			IL_0186:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 2;
					continue;
				case 2:
					goto IL_01ad;
				case 0:
				case 4:
					goto IL_01c5;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_01c5:
			int num2 = _003C_003E1__state;
			goto IL_002a;
			IL_002a:
			HttpResponseMessage result = default;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = client.DeleteAsync(url).GetAwaiter();
					num3 = 3;
					goto IL_00b3;
				}
				awaiter = _003C_003Eu__1;
				goto IL_010c;
				IL_010c:
				_003C_003Eu__1 = default;
				num3 = 0;
				goto IL_00b3;
				IL_00b3:
				while (true)
				{
					switch (num3)
					{
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						continue;
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 1;
						if (!NRZUOAsd6ZyKQVxT8MrT())
						{
							continue;
						}
						goto case 3;
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							if (!NRZUOAsd6ZyKQVxT8MrT())
							{
								continue;
							}
							break;
						}
						goto case 9;
					case 5:
					case 6:
						break;
					case 8:
						num2 = (_003C_003E1__state = 0);
						NRZUOAsd6ZyKQVxT8MrT();
						num3 = (RWYbgSsdbuRJltYAA3pu() ? 7 : 6);
						continue;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00b3;
					}
					goto IL_010c;
					continue;
					end_IL_00b3:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ad;
			IL_01ad:
			_003C_003Et__builder.SetResult(result);
			num = 5;
			if (true)
			{
				goto IL_0186;
			}
			goto IL_01c5;
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
		internal static bool RWYbgSsdbuRJltYAA3pu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NRZUOAsd6ZyKQVxT8MrT()
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
	private struct _003CPatchAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public string url;

		public HttpContent payload;

		public HttpClient client;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!AD10bvsdp9Zp0qM5I5if()) ? 4 : 2);
			int num2 = default;
			HttpRequestMessage httpRequestMessage = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							httpRequestMessage = new HttpRequestMessage(new HttpMethod((string)CBJ6h4sd46ZPHw6dEv0A(55142)), url);
							num3 = 7;
							if (!AD10bvsdp9Zp0qM5I5if())
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 6;
								if (AD10bvsdp9Zp0qM5I5if())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 1:
								awaiter = client.SendAsync(httpRequestMessage).GetAwaiter();
								num3 = 8;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 7:
								UVAxoJsdkyS1BhjIT9GD(httpRequestMessage, payload);
								AD10bvsdp9Zp0qM5I5if();
								if (g5YMn1sd0Tv2HCvfu7XF())
								{
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								}
								num3 = 0;
								continue;
							case 2:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 5;
			}
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
		internal static object CBJ6h4sd46ZPHw6dEv0A(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UVAxoJsdkyS1BhjIT9GD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpRequestMessage)P_0).Content = (HttpContent)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AD10bvsdp9Zp0qM5I5if()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g5YMn1sd0Tv2HCvfu7XF()
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
	private struct _003CAuthenticateUserAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<AuthenticationResult> _003C_003Et__builder;

		public VisionBuilderHttpApi _003C_003E4__this;

		private CoreWebView2Environment _003CwebView2Env_003E5__2;

		private ScopedEnvironmentVariable _003C_003E7__wrap2;

		private TaskAwaiter<CoreWebView2Environment> _003C_003Eu__1;

		private TaskAwaiter<LoginResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (!TCsifAsdFuX6HTlfUSO6())
			{
			}
			int num2 = default;
			CoreWebView2Environment result2 = default;
			VisionBuilderHttpApi visionBuilderHttpApi = default;
			Dictionary<string, string> extraParameters = default;
			Auth0Client auth0Client = default;
			AuthenticationResult result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_0223;
							}
							_003CwebView2Env_003E5__2 = null;
							_003C_003E7__wrap2 = new ScopedEnvironmentVariable((string)CRSUrGsdmXCUahMrqNWK(55156), null);
						}
						try
						{
							TaskAwaiter<CoreWebView2Environment> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = CoreWebView2Environment.CreateAsync(null, (string)A2OW4dsdye4dLJrc6yDY()).GetAwaiter();
								num3 = 2;
								if (false)
								{
									goto IL_0072;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
							}
							goto IL_00dc;
							IL_00dc:
							while (true)
							{
								switch (num3)
								{
								case 7:
									break;
								case 6:
									result2 = awaiter.GetResult();
									num3 = 10;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									return;
								case 0:
									goto IL_0123;
								case 9:
									return;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 6;
									if (!TCsifAsdFuX6HTlfUSO6())
									{
										continue;
									}
									goto case 2;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 6;
								case 10:
									_003CwebView2Env_003E5__2 = result2;
									goto end_IL_004d;
								}
								break;
							}
							goto IL_0072;
							IL_0123:
							_003C_003Eu__1 = default;
							num3 = 5;
							goto IL_00dc;
							IL_0072:
							_003C_003Eu__1 = awaiter;
							TCsifAsdFuX6HTlfUSO6();
							if (lKQ9JksdfyPctEWJ7vKT())
							{
								num3 = 1;
							}
							else
							{
								num3 = 9;
								if (!lKQ9JksdfyPctEWJ7vKT())
								{
									goto IL_0123;
								}
							}
							goto IL_00dc;
							end_IL_004d:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap2 != null)
							{
								SehrHOsdgSEGjd9cIpyD(_003C_003E7__wrap2);
							}
						}
						_003C_003E7__wrap2 = null;
						Auth0ClientOptions auth0ClientOptions = new Auth0ClientOptions();
						fFl9GdsdJJ8cbT6pM7Ml(auth0ClientOptions, jhGCQmsdZ3lMDc8B6tLd(visionBuilderHttpApi.Server));
						rlte6Psd8PkcWD47ePNv(auth0ClientOptions, visionBuilderHttpApi.Server.ClientId);
						x4M2Posiw2kNqiaI2GvJ(auth0ClientOptions, qZpZAusdzr479bOTb15O(visionBuilderHttpApi.Server));
						auth0ClientOptions.Browser = new Auth0ClientBrowser(_003CwebView2Env_003E5__2);
						extraParameters = new Dictionary<string, string> { 
						{
							(string)CRSUrGsdmXCUahMrqNWK(55210),
							(string)TM8tOJsisX6s43sREapa(visionBuilderHttpApi.Server)
						} };
						auth0Client = new Auth0Client(auth0ClientOptions);
						goto IL_0223;
						IL_0223:
						try
						{
							TaskAwaiter<LoginResult> awaiter2;
							if (num2 != 1)
							{
								awaiter2 = auth0Client.LoginAsync(extraParameters).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
							}
							LoginResult result3 = awaiter2.GetResult();
							if (DgJHgasihp3UhORIJgeW(result3) && (string)h9hQV5siLTAuwWeU923T(result3) != (string)CRSUrGsdmXCUahMrqNWK(55230))
							{
								string empty = string.Empty;
								empty = (string)((!((string)h9hQV5siLTAuwWeU923T(result3) == (string)CRSUrGsdmXCUahMrqNWK(55254))) ? C2obIDsiScYfFdrYwcwJ() : dMFIYcsi9r8Qw8d57iBZ());
								throw new Exception(empty);
							}
							result = AuthenticationResult.FromOidcLoginResult(result3);
						}
						catch (Exception ex)
						{
							hCySPIsiE9Rf8fKMgZZ8(visionBuilderHttpApi.muTpDkT4ev);
							jUCUuJsiv96t1ahgdqx1(yVKpGC5YUx, string.Format((string)CRSUrGsdmXCUahMrqNWK(55284), Environment.NewLine, ex), ex);
							throw;
						}
						finally
						{
							if (num2 < 0)
							{
								CoreWebView2Environment coreWebView2Environment = _003CwebView2Env_003E5__2;
								mP43A3siVXEfAOVULNIp((coreWebView2Environment != null) ? tiN3mIsiHN2m0RF1R81q(coreWebView2Environment) : null);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwebView2Env_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
					visionBuilderHttpApi = _003C_003E4__this;
					_ = 1;
					if (TCsifAsdFuX6HTlfUSO6())
					{
						num = 4;
						if (TCsifAsdFuX6HTlfUSO6())
						{
						}
						continue;
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 7:
					return;
				}
				_003CwebView2Env_003E5__2 = null;
				num = 0;
			}
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
		internal static object CRSUrGsdmXCUahMrqNWK(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A2OW4dsdye4dLJrc6yDY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x2FpdvV068();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SehrHOsdgSEGjd9cIpyD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jhGCQmsdZ3lMDc8B6tLd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Server)P_0).Domain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fFl9GdsdJJ8cbT6pM7Ml(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Auth0ClientOptions)P_0).Domain = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rlte6Psd8PkcWD47ePNv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Auth0ClientOptions)P_0).ClientId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qZpZAusdzr479bOTb15O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Server)P_0).RedirectUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void x4M2Posiw2kNqiaI2GvJ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Auth0ClientOptions)P_0).RedirectUri = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TM8tOJsisX6s43sREapa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Server)P_0).Audience;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DgJHgasihp3UhORIJgeW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Result)P_0).IsError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h9hQV5siLTAuwWeU923T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Result)P_0).Error;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dMFIYcsi9r8Qw8d57iBZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AccessDenied;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C2obIDsiScYfFdrYwcwJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.GenericLoginError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hCySPIsiE9Rf8fKMgZZ8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IUserSessionCache)P_0).ClearSession();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jUCUuJsiv96t1ahgdqx1(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tiN3mIsiHN2m0RF1R81q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CoreWebView2Environment)P_0).UserDataFolder;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mP43A3siVXEfAOVULNIp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yn4puBDarc((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lKQ9JksdfyPctEWJ7vKT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TCsifAsdFuX6HTlfUSO6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger yVKpGC5YUx;

	private readonly IUserSessionCache muTpDkT4ev;

	[CompilerGenerated]
	private Server OBipeWfIeZ;

	public Server Server
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OBipeWfIeZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OBipeWfIeZ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisionBuilderHttpApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m1Rtxrjxu69GjWPjWSq();
		int num;
		if (!Fi40L3j1AvkEw4o1LDw())
		{
			num = 3;
			if (!m1Rtxrjxu69GjWPjWSq())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_004b;
		IL_00a3:
		Server = (Server)D9wkLhjOM2J1BuSdeiU(muTpDkT4ev);
		num = 6;
		goto IL_004b;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 5;
				if (m1Rtxrjxu69GjWPjWSq())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				jmZ4lmj3B8QVw5ajVAt(this);
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				j9GugQjrRA811ePiUlR();
				goto case 1;
			case 5:
				goto IL_00a3;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		muTpDkT4ev = UserSessionCache.Instance;
		goto IL_00a3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAuthorizationTokenAsync_003Ed__3))]
	public Task<string> GetAuthorizationTokenAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAuthorizationTokenAsync_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLoggedIn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YI8OxajMe1c0NAm8Rkx(muTpDkT4ev, Server);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Logout()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		muTpDkT4ev.ClearSession();
		return (Task)wLkO2gjQE6yMkR94etg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetUserName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return muTpDkT4ev.GetUserNameFor(Server);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COpenUrl_003Ed__11))]
	public Task OpenUrl(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (m1Rtxrjxu69GjWPjWSq())
		{
			num = 2;
			if (Fi40L3j1AvkEw4o1LDw())
			{
			}
		}
		else
		{
			num = 5;
		}
		_003COpenUrl_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine.url = url;
				num = 4;
				if (Fi40L3j1AvkEw4o1LDw())
				{
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = leHZP6jlmH1lAJc3KW8();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAsync_003Ed__12))]
	public Task<HttpResponseMessage> GetAsync(HttpClient client, string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAsync_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.client = client;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPutAsync_003Ed__13))]
	public Task<HttpResponseMessage> PutAsync(HttpClient client, string url, HttpContent payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPutAsync_003Ed__13 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.client = client;
		stateMachine.url = url;
		stateMachine.payload = payload;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostAsync_003Ed__14))]
	public Task<HttpResponseMessage> PostAsync(HttpClient client, string url, HttpContent payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostAsync_003Ed__14 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.client = client;
		stateMachine.url = url;
		stateMachine.payload = payload;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteAsync_003Ed__15))]
	public Task<HttpResponseMessage> DeleteAsync(HttpClient client, string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteAsync_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.client = client;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPatchAsync_003Ed__16))]
	public Task<HttpResponseMessage> PatchAsync(HttpClient client, string url, HttpContent payload)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPatchAsync_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.client = client;
		stateMachine.url = url;
		stateMachine.payload = payload;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAuthenticateUserAsync_003Ed__17))]
	protected virtual Task<AuthenticationResult> AuthenticateUserAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAuthenticateUserAsync_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<AuthenticationResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string x2FpdvV068()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = SfmZibjRVSLo3X4ebjE(z7prC9jePFPbyEBh2gF(), UWHJjdjuwR4VJcZ2gGB(13986), UWHJjdjuwR4VJcZ2gGB(15032), i6HJIijINIbDI1dJBGv());
		mg4YPrjaSN7ua8wmTjm(obj);
		return (string)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Yn4puBDarc(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		try
		{
			u7DSk5jn4UryGIC45Rc(P_0, true);
		}
		catch (Exception ex)
		{
			yVKpGC5YUx.LogException(LogLevel.Warn, (string)fFYJ8VjGK3Ry0qIBkeO(kgbOBx7BanbFa22Hp9.ol99ukmDA(15044), P_0, UWHJjdjuwR4VJcZ2gGB(344)), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisionBuilderHttpApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		j9GugQjrRA811ePiUlR();
		yVKpGC5YUx = LogManager.GetLogger<VisionBuilderHttpApi>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j9GugQjrRA811ePiUlR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jmZ4lmj3B8QVw5ajVAt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D9wkLhjOM2J1BuSdeiU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IUserSessionCache)P_0).LastLoggedInServer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m1Rtxrjxu69GjWPjWSq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fi40L3j1AvkEw4o1LDw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YI8OxajMe1c0NAm8Rkx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IUserSessionCache)P_0).IsLoggedInFor((Server)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wLkO2gjQE6yMkR94etg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder leHZP6jlmH1lAJc3KW8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z7prC9jePFPbyEBh2gF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Path.GetTempPath();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UWHJjdjuwR4VJcZ2gGB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i6HJIijINIbDI1dJBGv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Path.GetRandomFileName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SfmZibjRVSLo3X4ebjE(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mg4YPrjaSN7ua8wmTjm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Directory.CreateDirectory((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u7DSk5jn4UryGIC45Rc(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Directory.Delete((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fFYJ8VjGK3Ry0qIBkeO(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
