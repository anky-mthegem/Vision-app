using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Common.JsonConverters;
using Cognex.InSight.Properties;
using Cognex.InSight.VisionBuilder.Exceptions;
using Cognex.InSight.VisionBuilder.Types;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class VisionBuilderApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateHttpClientAuthorizationAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01e9;
			IL_001a:
			VisionBuilderApi visionBuilderApi = _003C_003E4__this;
			num = 2;
			goto IL_01e9;
			IL_01e9:
			int num2 = default;
			string result2 = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!XyH6AcsD0qCcU2KfK5fF())
					{
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto default;
					}
					num = 5;
					continue;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					continue;
				case 2:
					try
					{
						TaskAwaiter<string> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = visionBuilderApi.HttpApi.GetAuthorizationTokenAsync().GetAwaiter();
							num3 = 1;
							if (XyH6AcsD0qCcU2KfK5fF())
							{
								goto IL_0088;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = ((!slH3xEsDp96NUxBQTZHy()) ? 2 : 4);
						}
						goto IL_013a;
						IL_009e:
						result = awaiter.GetResult();
						num3 = 0;
						if (1 == 0)
						{
							goto IL_00b2;
						}
						goto IL_013a;
						IL_00b2:
						E3PqkesDk68ol1XC2Arj(s6wSN8sD4HqrULPCVFAW(visionBuilderApi.UZLpEovFi3), new AuthenticationHeaderValue(kgbOBx7BanbFa22Hp9.ol99ukmDA(53818), result));
						num3 = 10;
						if (1 == 0)
						{
							return;
						}
						goto IL_013a;
						IL_013a:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 2:
							case 6:
								goto IL_009e;
							case 0:
								goto IL_00b2;
							case 3:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (slH3xEsDp96NUxBQTZHy())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 4:
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_009e;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 10:
								result2 = result;
								goto end_IL_0060;
							}
							break;
						}
						goto IL_0088;
						IL_0088:
						if (awaiter.IsCompleted)
						{
							goto IL_009e;
						}
						num3 = 7;
						goto IL_013a;
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
				break;
			}
			goto IL_001a;
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
		internal static object s6wSN8sD4HqrULPCVFAW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpClient)P_0).DefaultRequestHeaders;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void E3PqkesDk68ol1XC2Arj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpRequestHeaders)P_0).Authorization = (AuthenticationHeaderValue)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool slH3xEsDp96NUxBQTZHy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XyH6AcsD0qCcU2KfK5fF()
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
	private struct _003CLogoutAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter awaiter = default;
			VisionBuilderApi visionBuilderApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							goto IL_007d;
						}
						if (visionBuilderApi.HttpApi != null)
						{
							num3 = 1;
							goto IL_007d;
						}
						goto end_IL_0018;
						IL_007d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								awaiter = TTLD0QsDyoCaIwsJtphT(FCZskLsDmEy6bfvoUceI(visionBuilderApi.HttpApi));
								num3 = 2;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 9:
								return;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (ESeNkfsDF29KDhMuvvpg())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (Ed29IvsDfDAySYQb3V0x())
								{
									continue;
								}
								goto case 2;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (true)
									{
										continue;
									}
								}
								break;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					visionBuilderApi = _003C_003E4__this;
					_ = 1;
					if (ESeNkfsDF29KDhMuvvpg())
					{
						num = 1;
						if (Ed29IvsDfDAySYQb3V0x())
						{
							break;
						}
						goto default;
					}
					num = 4;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					break;
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
		internal static object FCZskLsDmEy6bfvoUceI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IVisionBuilderHttpApi)P_0).Logout();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TTLD0QsDyoCaIwsJtphT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ed29IvsDfDAySYQb3V0x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ESeNkfsDF29KDhMuvvpg()
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
	private struct _003COpenProjectAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public string versionId;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (hMVVaZsDgDoK8QW9Ql1x())
			{
				num = 3;
				if (!hMVVaZsDgDoK8QW9Ql1x())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_01e4;
			IL_0067:
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			try
			{
				string text = default;
				int num3;
				if (num2 != 0)
				{
					text = (string)jffIt1sD8pK9pQoTMGjs(fDPIIxsDJMYOG2mmiTuP(visionBuilderApi.k6vpc0mPJQ().Projects(projectId).Versions(versionId)));
					_ = 0;
					num3 = ((!hMVVaZsDgDoK8QW9Ql1x()) ? 5 : 7);
					goto IL_00f2;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_018c;
				IL_00f2:
				while (true)
				{
					switch (num3)
					{
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 8:
						return;
					case 4:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					default:
						num3 = 3;
						continue;
					case 9:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 10;
					case 0:
					case 7:
						awaiter = RF3Oi6sUwRlOlfSj3ang(Yk30i1sDz8S8Cpqep7KP(visionBuilderApi.HttpApi, text));
						num3 = 9;
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						if (true)
						{
							continue;
						}
						break;
					case 5:
					case 6:
						break;
					case 10:
						awaiter.GetResult();
						goto end_IL_00f2;
					}
					goto IL_018c;
					continue;
					end_IL_00f2:
					break;
				}
				goto end_IL_0067;
				IL_018c:
				_003C_003Eu__1 = default;
				num3 = 1;
				goto IL_00f2;
				end_IL_0067:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0041;
			IL_01e4:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					goto IL_0041;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
				case 5:
					goto IL_0067;
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			visionBuilderApi = _003C_003E4__this;
			goto IL_0067;
			IL_0041:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01e4;
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
		internal static object fDPIIxsDJMYOG2mmiTuP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Tools();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jffIt1sD8pK9pQoTMGjs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yk30i1sDz8S8Cpqep7KP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IVisionBuilderHttpApi)P_0).OpenUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter RF3Oi6sUwRlOlfSj3ang(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hMVVaZsDgDoK8QW9Ql1x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KrPTVgsDZrs9FD4TdvFp()
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
	private struct _003CListProjectsAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Project[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		private TaskAwaiter<Project[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01b8;
			IL_001a:
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			Project[] result = default;
			try
			{
				string url = default;
				if (num2 != 0)
				{
					url = (string)M2OwGysULlaafp9Q5Mn2(visionBuilderApi.U8Hp5RTu74().Projects());
				}
				try
				{
					TaskAwaiter<Project[]> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = visionBuilderApi.GetPagedArrayAsync<Project>(url, 100, (string)PkMIwPsU9jwxKOAUFugR(53834)).GetAwaiter();
						num3 = 1;
						goto IL_00c4;
					}
					awaiter = _003C_003Eu__1;
					goto IL_011d;
					IL_011d:
					_003C_003Eu__1 = default;
					num3 = 7;
					if (!iLQ49HsUh5nHx02Bsirx())
					{
						goto IL_00c4;
					}
					goto IL_0139;
					IL_0139:
					if (!awaiter.IsCompleted)
					{
						num3 = 6;
						goto IL_00c4;
					}
					goto IL_014f;
					IL_00c4:
					while (true)
					{
						switch (num3)
						{
						case 7:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 6:
							num2 = (_003C_003E1__state = 0);
							num3 = 2;
							continue;
						case 0:
							return;
						case 3:
						case 8:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							num3 = 0;
							continue;
						case 2:
							break;
						case 4:
						case 5:
							goto end_IL_00c4;
						case 1:
							goto IL_0139;
						case 9:
							goto IL_014f;
						}
						_003C_003Eu__1 = awaiter;
						iLQ49HsUh5nHx02Bsirx();
						num3 = (EHkbOTsUsvH2i4uvgLUh() ? 8 : 4);
						continue;
						end_IL_00c4:
						break;
					}
					goto IL_011d;
					IL_014f:
					result = awaiter.GetResult();
				}
				catch (VisionBuilderApiHttpException ex)
				{
					throw new VisionBuilderApiHttpException((string)ph9qSVsUELe2EhmjhemG(kgbOBx7BanbFa22Hp9.ol99ukmDA(53858), Echp2qsUSwDNNRN8W0rC(ex)), oC0117sUvqPxPC6gUOMe(ex));
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0221;
			IL_01b8:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 0:
					visionBuilderApi = _003C_003E4__this;
					EHkbOTsUsvH2i4uvgLUh();
					if (iLQ49HsUh5nHx02Bsirx())
					{
						num = 5;
						continue;
					}
					num = 1;
					if (!iLQ49HsUh5nHx02Bsirx())
					{
						continue;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					goto IL_0221;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0221:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (!EHkbOTsUsvH2i4uvgLUh())
			{
				return;
			}
			goto IL_01b8;
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
		internal static object M2OwGysULlaafp9Q5Mn2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PkMIwPsU9jwxKOAUFugR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Echp2qsUSwDNNRN8W0rC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ph9qSVsUELe2EhmjhemG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode oC0117sUvqPxPC6gUOMe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderApiHttpException)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EHkbOTsUsvH2i4uvgLUh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iLQ49HsUh5nHx02Bsirx()
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
	private struct _003CCreateProjectAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string name;

		public VisionBuilderApi _003C_003E4__this;

		private string _003Cid_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zOqgvusUVxprf12nmRmn();
			int num = ((!GYWXfgsUH4PkcywcLG4d()) ? 3 : 6);
			string result = default;
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			Dictionary<string, string> dictionary = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			string text = default;
			HttpResponseMessage result2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003Cid_003E5__2 = null;
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					visionBuilderApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							dictionary = new Dictionary<string, string> { 
							{
								(string)r5P1bwsUAPrOagDgRISC(4310),
								name
							} };
							num3 = 17;
							goto IL_033e;
						case 2:
							awaiter3 = _003C_003Eu__3;
							goto IL_00fe;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 21;
							goto IL_033e;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
								goto IL_033e;
							}
							IL_033e:
							while (true)
							{
								switch (num3)
								{
								case 20:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (GYWXfgsUH4PkcywcLG4d())
									{
										continue;
									}
									goto case 22;
								case 22:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 7:
									return;
								case 5:
								case 19:
									break;
								case 21:
									goto IL_011a;
								case 23:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 7;
									if (GYWXfgsUH4PkcywcLG4d())
									{
										continue;
									}
									goto case 3;
								case 3:
								case 12:
									num2 = (_003C_003E1__state = 0);
									num3 = 13;
									continue;
								case 17:
									text = (string)breTmLsUDNKBxH9oO73M(visionBuilderApi.U8Hp5RTu74().Projects());
									num3 = 1;
									continue;
								case 11:
									goto IL_0182;
								case 14:
									goto IL_01a1;
								case 16:
									num2 = (_003C_003E1__state = -1);
									num3 = 15;
									continue;
								case 13:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 2);
									num3 = 10;
									continue;
								case 1:
									awaiter = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
									num3 = 14;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 20;
									continue;
								case 18:
									throw new VisionBuilderApiHttpException(kgbOBx7BanbFa22Hp9.ol99ukmDA(53898), eEeC0GsUTdEh7MOb3Mno(result2));
								case 2:
									return;
								case 15:
									goto IL_02a8;
								case 0:
									goto IL_02fb;
								case 10:
									_003C_003Eu__3 = awaiter3;
									num3 = 23;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								default:
									num3 = 2;
									continue;
								case 4:
									return;
								case 24:
									result = _003Cid_003E5__2;
									goto end_IL_007c;
								}
								break;
								IL_01a1:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (zOqgvusUVxprf12nmRmn())
									{
										num3 = 5;
										if (1 == 0)
										{
											break;
										}
									}
									else
									{
										num3 = 12;
									}
									continue;
								}
								goto IL_0182;
								IL_0182:
								result2 = awaiter.GetResult();
								if (!wbfj8ZsUUxvosIxC4k0J(result2))
								{
									num3 = 18;
									continue;
								}
								awaiter2 = ((HttpContent)J7CDn3sUdK30BUpxlw1F(result2)).ReadAsStringAsync().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									num3 = 8;
									continue;
								}
								goto IL_02a8;
								IL_02fb:
								awaiter3.GetResult();
								num3 = 24;
								continue;
								IL_02a8:
								Dictionary<string, object> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(awaiter2.GetResult());
								_003Cid_003E5__2 = dictionary2[(string)r5P1bwsUAPrOagDgRISC(53942)] as string;
								awaiter3 = jXWcQEsUieuCq5cXuyJC(visionBuilderApi.pPOpmyGECc(_003Cid_003E5__2));
								if (!awaiter3.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto IL_02fb;
							}
							goto IL_00fe;
							IL_00fe:
							_003C_003Eu__3 = default;
							num3 = 22;
							if (!GYWXfgsUH4PkcywcLG4d())
							{
								goto IL_011a;
							}
							goto IL_033e;
							IL_011a:
							_003C_003Eu__2 = default;
							num3 = 16;
							goto IL_033e;
							end_IL_007c:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cid_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					break;
				case 7:
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
		internal static object r5P1bwsUAPrOagDgRISC(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object breTmLsUDNKBxH9oO73M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wbfj8ZsUUxvosIxC4k0J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode eEeC0GsUTdEh7MOb3Mno(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J7CDn3sUdK30BUpxlw1F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jXWcQEsUieuCq5cXuyJC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GYWXfgsUH4PkcywcLG4d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zOqgvusUVxprf12nmRmn()
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
	private struct _003CDeleteProjectAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WyeYyXsUBVq1XmjmQHSQ();
			int num = ((!zjcj59sUqvaXoN9dnYVq()) ? 1 : 4);
			VisionBuilderApi visionBuilderApi = default;
			int num2 = default;
			string text = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					visionBuilderApi = _003C_003E4__this;
					num = 2;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)H6JeK3sUjSW3VtGmCLSF(visionBuilderApi.U8Hp5RTu74().Projects(projectId));
							WyeYyXsUBVq1XmjmQHSQ();
							if (zjcj59sUqvaXoN9dnYVq())
							{
								num3 = 5;
							}
							else
							{
								num3 = 6;
								if (!zjcj59sUqvaXoN9dnYVq())
								{
									return;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 5:
								awaiter = visionBuilderApi.dxqpHhrLUB(text).GetAwaiter();
								num3 = 4;
								if (0 == 0)
								{
									break;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (0 == 0)
									{
										break;
									}
									goto case 1;
								}
								goto case 9;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								break;
							case 6:
							case 8:
								if (!zlqphxsUcGs2ImC5qqJJ(result))
								{
									num3 = 11;
									break;
								}
								goto end_IL_00ea;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								break;
							case 9:
								result = awaiter.GetResult();
								goto case 6;
							case 3:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								if (true)
								{
									break;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								break;
							case 11:
								throw new VisionBuilderApiHttpException((string)Rp2mWTsU2jteRq6qAous(53966) + projectId + (string)Rp2mWTsU2jteRq6qAous(350) + result.ReasonPhrase, yGvDDYsUW9AivjTnlQSW(result));
							}
							continue;
							end_IL_00ea:
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
		internal static object H6JeK3sUjSW3VtGmCLSF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zlqphxsUcGs2ImC5qqJJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Rp2mWTsU2jteRq6qAous(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode yGvDDYsUW9AivjTnlQSW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zjcj59sUqvaXoN9dnYVq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WyeYyXsUBVq1XmjmQHSQ()
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
	private struct _003CCreateToolChainAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aiYU6BsU7xUlunyJTtWH();
			int num = (B2OLmcsUtyPVBwWWSB3r() ? 2 : 5);
			VisionBuilderApi visionBuilderApi = default;
			int num2 = default;
			string text = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			Dictionary<string, string> dictionary = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					visionBuilderApi = _003C_003E4__this;
					num = 4;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)h1rxixsUCNMCZARgBIT7(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Toolchains());
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 9:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								break;
							case 7:
								return;
							case 2:
							case 5:
								if (!awaiter.IsCompleted)
								{
									goto case 3;
								}
								goto case 10;
							case 4:
								awaiter = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
								_ = 1;
								if (B2OLmcsUtyPVBwWWSB3r())
								{
									num3 = 9;
									break;
								}
								num3 = 5;
								if (B2OLmcsUtyPVBwWWSB3r())
								{
								}
								break;
							case 1:
								dictionary = new Dictionary<string, string> { 
								{
									(string)QrPsIssUK0KXogOO7LKA(4310),
									(string)QrPsIssUK0KXogOO7LKA(54000)
								} };
								num3 = 4;
								if (true)
								{
									break;
								}
								goto case 10;
							case 10:
								result = awaiter.GetResult();
								num3 = 11;
								break;
							case 11:
								if (!X7Kd2ysU5PYcnJ9rUTxo(result))
								{
									num3 = 12;
									break;
								}
								goto end_IL_00bc;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								break;
							case 12:
								throw new VisionBuilderApiHttpException((string)QrPsIssUK0KXogOO7LKA(54018), result.StatusCode);
							}
							continue;
							end_IL_00bc:
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
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object h1rxixsUCNMCZARgBIT7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QrPsIssUK0KXogOO7LKA(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X7Kd2ysU5PYcnJ9rUTxo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aiYU6BsU7xUlunyJTtWH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B2OLmcsUtyPVBwWWSB3r()
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
	private struct _003CListToolChainsAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<Dictionary<string, string>>> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			string text = default;
			VisionBuilderApi visionBuilderApi = default;
			HttpResponseMessage result = default;
			List<Dictionary<string, string>> result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_ = 0;
							num3 = ((!ek3aKQsUoiRmhQ70KfY8()) ? 5 : 12);
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 14;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 1;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 0:
							case 12:
								text = (string)lcbYRIsUYKuRxRoporLL(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Toolchains());
								num3 = 6;
								continue;
							case 6:
								awaiter = visionBuilderApi.n1Np6GCYAu(text).GetAwaiter();
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 8;
								if (zs2BNisUPFtkQdW7F5G9())
								{
								}
								continue;
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 15;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (ek3aKQsUoiRmhQ70KfY8())
								{
									continue;
								}
								goto case 14;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 10;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								goto IL_015c;
							default:
								num3 = 9;
								continue;
							case 16:
								if (!awaiter2.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								break;
							case 9:
								if (!result.IsSuccessStatusCode)
								{
									throw new VisionBuilderApiHttpException((string)fPGPSnsUN83kiY6abpsn(54066), h8iMKqsUxYVnyNw7AniU(result));
								}
								awaiter2 = ((HttpContent)pAZTNZsU13Y638uTpmto(result)).ReadAsStringAsync().GetAwaiter();
								num3 = 16;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									goto case 3;
								}
								goto IL_015c;
							case 15:
								_003C_003Eu__2 = awaiter2;
								num3 = 2;
								continue;
							case 17:
								break;
								IL_015c:
								result = awaiter.GetResult();
								goto case 9;
							}
							break;
						}
						List<Dictionary<string, string>>? list = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(awaiter2.GetResult());
						if (c1nhB1sUreqoI7dUKcdF(list) == 0)
						{
							throw new VisionBuilderApiException((string)f1NF1esU3weo98hFPf4K());
						}
						result2 = list;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 1:
				case 5:
					visionBuilderApi = _003C_003E4__this;
					num = 2;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (ek3aKQsUoiRmhQ70KfY8() ? 5 : 4);
					break;
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
		internal static object lcbYRIsUYKuRxRoporLL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fPGPSnsUN83kiY6abpsn(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode h8iMKqsUxYVnyNw7AniU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pAZTNZsU13Y638uTpmto(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int c1nhB1sUreqoI7dUKcdF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<Dictionary<string, string>>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f1NF1esU3weo98hFPf4K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Toolchain_NoToolchainsExist;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ek3aKQsUoiRmhQ70KfY8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zs2BNisUPFtkQdW7F5G9()
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
	private struct _003CListVersionsAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ToolchainVersion[]> _003C_003Et__builder;

		public string toolchainId;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<List<Dictionary<string, string>>> _003C_003Eu__1;

		private TaskAwaiter<ToolchainVersion[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (E0B8o2sUMe9Mwn4k4tQJ() ? 3 : 2);
			ToolchainVersion[] result3 = default;
			VisionBuilderApi visionBuilderApi = default;
			int num2 = default;
			string url = default;
			TaskAwaiter<ToolchainVersion[]> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result3);
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 4:
					try
					{
						TaskAwaiter<List<Dictionary<string, string>>> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_011c;
							}
							if (toolchainId != null)
							{
								goto IL_00ef;
							}
							awaiter = visionBuilderApi.ListToolChainsAsync(projectId).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						List<Dictionary<string, string>> result = awaiter.GetResult();
						toolchainId = result[0][(string)MZr4lwsUQTSYkJmpfIxS(54126)];
						goto IL_00ef;
						IL_00ef:
						url = (string)mWq9MasUl8JpGccu2w5C(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Toolchains(toolchainId)
							.VersionSnapshots());
						goto IL_011c;
						IL_011c:
						ToolchainVersion[] result2;
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 1;
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								num3 = 9;
								if (false)
								{
									goto IL_0240;
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
									awaiter2 = visionBuilderApi.GetPagedArrayAsync<ToolchainVersion>(url).GetAwaiter();
									num3 = 4;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 4:
									if (awaiter2.IsCompleted)
									{
										break;
									}
									_ = 0;
									if (NCahDYsUOUUIIvibX9AG())
									{
										num3 = 6;
										continue;
									}
									num3 = 0;
									if (NCahDYsUOUUIIvibX9AG())
									{
										continue;
									}
									goto case 7;
								case 2:
								case 6:
									num2 = (_003C_003E1__state = 1);
									goto case 0;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 8;
									if (NCahDYsUOUUIIvibX9AG())
									{
										continue;
									}
									goto case 0;
								case 0:
								case 3:
									_003C_003Eu__2 = awaiter2;
									goto case 7;
								default:
									num3 = 7;
									continue;
								case 9:
									_003C_003Eu__2 = default;
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 8:
									return;
								case 10:
									break;
								}
								break;
							}
							goto IL_0240;
							IL_0240:
							result2 = awaiter2.GetResult();
						}
						catch (VisionBuilderApiHttpException ex)
						{
							throw new VisionBuilderApiHttpException((string)xTJeabsUesff29i2QfK4(MZr4lwsUQTSYkJmpfIxS(54156), ex.Message), c7xmEAsUu1tB6mfaWcSw(ex));
						}
						if (result2.Length == 0)
						{
							throw new VisionBuilderApiException((string)cHy39lsUIVu7E55ZLlrv());
						}
						result3 = result2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				visionBuilderApi = _003C_003E4__this;
				num = 4;
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
		internal static object MZr4lwsUQTSYkJmpfIxS(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mWq9MasUl8JpGccu2w5C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xTJeabsUesff29i2QfK4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode c7xmEAsUu1tB6mfaWcSw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderApiHttpException)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cHy39lsUIVu7E55ZLlrv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Toolchain_NoVersionsExist;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NCahDYsUOUUIIvibX9AG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E0B8o2sUMe9Mwn4k4tQJ()
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
	private struct _003CGetToolChainArchiveAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public string toolChainId;

		public string versionId;

		private TaskAwaiter<ToolchainStatus[]> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private TaskAwaiter<byte[]> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!rsvTkDsUadZ1IIOL3qZl())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (rsvTkDsUadZ1IIOL3qZl())
				{
					return;
				}
			}
			VisionBuilderApi visionBuilderApi = default;
			byte[] result2 = default;
			int num2 = default;
			TaskAwaiter<ToolchainStatus[]> awaiter = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			TaskAwaiter<byte[]> awaiter3 = default;
			HttpResponseMessage result = default;
			string message = default;
			string text = default;
			ToolchainStatus[] result3 = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					visionBuilderApi = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 0:
				case 1:
					break;
				case 5:
					try
					{
						switch (num2)
						{
						case 2:
							goto IL_0156;
						case 1:
							goto IL_0196;
						case 0:
							goto IL_028a;
						}
						awaiter = visionBuilderApi.GetToolChainVersionStatusesAsync(projectId, toolChainId).GetAwaiter();
						int num3 = 2;
						goto IL_00c6;
						IL_028a:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num3 = 3;
						if (true)
						{
							goto IL_00c6;
						}
						goto IL_02aa;
						IL_0196:
						awaiter2 = _003C_003Eu__2;
						num3 = 19;
						if (xQVDyvsURiaL597KuAT1())
						{
							goto IL_00c6;
						}
						goto IL_01ae;
						IL_0156:
						awaiter3 = _003C_003Eu__3;
						num3 = 15;
						goto IL_00c6;
						IL_01ae:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						goto IL_00c6;
						IL_00c6:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!awaiter3.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 25;
							case 14:
								num2 = (_003C_003E1__state = 1);
								goto default;
							case 21:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							case 9:
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter3;
								num3 = 21;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 13:
								break;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									if (!rsvTkDsUadZ1IIOL3qZl())
									{
										continue;
									}
									goto default;
								}
								goto IL_024a;
							default:
								_003C_003Eu__2 = awaiter2;
								num3 = 8;
								if (rsvTkDsUadZ1IIOL3qZl())
								{
								}
								continue;
							case 16:
								result = awaiter2.GetResult();
								num3 = 23;
								continue;
							case 18:
								throw new VisionBuilderApiHttpException((string)o9FT9gsUXeLl675XWUbu(54240), qBGiWSsUpiR9haKC4MMu(result));
							case 3:
								num2 = (_003C_003E1__state = -1);
								goto IL_024a;
							case 19:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (rsvTkDsUadZ1IIOL3qZl())
								{
								}
								continue;
							case 11:
								return;
							case 15:
								goto IL_02aa;
							case 4:
								throw new VisionBuilderApiException(message);
							case 22:
								text = (string)bxXmOVsUGnbFeV43kLaH(Bwku8DsUbMRuu6rFip9P(new VisionBuilderUrlBuilder().BaseUrl(text), o9FT9gsUXeLl675XWUbu(54216), versionId));
								goto IL_0322;
							case 24:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 11;
								continue;
							case 7:
							case 10:
								goto IL_035f;
							case 17:
								if (versionId != null)
								{
									num3 = 22;
									continue;
								}
								goto IL_0322;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 24;
								continue;
							case 20:
								num2 = (_003C_003E1__state = -1);
								num3 = 25;
								continue;
							case 0:
								goto IL_03aa;
							case 23:
								if (nVQ7oRsU6ZQ5qQJGTNWF(result))
								{
									awaiter3 = ((HttpContent)DTr1NjsU0YswI476iP6p(result)).ReadAsByteArrayAsync().GetAwaiter();
									num3 = 6;
									continue;
								}
								num3 = 18;
								if (xQVDyvsURiaL597KuAT1())
								{
									continue;
								}
								goto case 25;
							case 25:
								{
									result2 = awaiter3.GetResult();
									goto end_IL_0060;
								}
								IL_0322:
								awaiter2 = visionBuilderApi.n1Np6GCYAu(text).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 16;
								IL_024a:
								result3 = awaiter.GetResult();
								num3 = 0;
								continue;
							}
							break;
							IL_03aa:
							(flag, message) = visionBuilderApi.IsToolchainVersionValid(result3, versionId);
							xQVDyvsURiaL597KuAT1();
							num3 = (rsvTkDsUadZ1IIOL3qZl() ? 1 : 10);
							continue;
							IL_035f:
							if (flag)
							{
								text = (string)bxXmOVsUGnbFeV43kLaH(BbwMn5sUnY7muLFGy7To(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Toolchains(toolChainId)));
								num3 = 17;
							}
							else
							{
								num3 = 4;
							}
						}
						goto IL_01ae;
						IL_02aa:
						_003C_003Eu__3 = default;
						num3 = 20;
						goto IL_00c6;
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
				num2 = _003C_003E1__state;
				num = 2;
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
		internal static object BbwMn5sUnY7muLFGy7To(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Archive();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bxXmOVsUGnbFeV43kLaH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object o9FT9gsUXeLl675XWUbu(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Bwku8DsUbMRuu6rFip9P(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Query((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nVQ7oRsU6ZQ5qQJGTNWF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode qBGiWSsUpiR9haKC4MMu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DTr1NjsU0YswI476iP6p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xQVDyvsURiaL597KuAT1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rsvTkDsUadZ1IIOL3qZl()
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
	private struct _003CGetToolChainVersionStatusesAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ToolchainStatus[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public string toolChainId;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			ToolchainStatus[] result = default;
			VisionBuilderApi visionBuilderApi = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			TaskAwaiter<string> awaiter = default;
			ToolchainStatus[] array = default;
			string text = default;
			string result3 = default;
			HttpResponseMessage result2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!t7ZwAtsUk4MXQIu7qh3g())
					{
						num = 4;
						if (FYoltCsU4XC6tiArEcUS())
						{
							break;
						}
						goto case 2;
					}
					num = 5;
					break;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				default:
					_003Cresponse_003E5__2 = null;
					num = 2;
					break;
				case 1:
				case 4:
					visionBuilderApi = _003C_003E4__this;
					num = 0;
					break;
				case 0:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 17;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
							break;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 10;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								if (array != null)
								{
									num3 = 14;
									break;
								}
								goto case 20;
							case 15:
								return;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								_003C_003Eu__1 = default;
								goto case 5;
							case 17:
								text = (string)EeQGq3sUFcgOgMDsj7Uq(gKAuISsUf79qAYbg1plS(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Toolchains(toolChainId)));
								num3 = 18;
								if (true)
								{
									break;
								}
								goto case 16;
							case 16:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								if (FYoltCsU4XC6tiArEcUS())
								{
									break;
								}
								goto case 14;
							case 14:
								if (array.Length == 0)
								{
									num3 = 20;
									break;
								}
								result = array;
								goto end_IL_024a;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (FYoltCsU4XC6tiArEcUS())
								{
									break;
								}
								goto case 10;
							case 10:
								_003C_003Eu__2 = default;
								num3 = 9;
								break;
							case 18:
								awaiter2 = visionBuilderApi.n1Np6GCYAu(text).GetAwaiter();
								_ = 0;
								if (!FYoltCsU4XC6tiArEcUS())
								{
									num3 = 5;
									if (true)
									{
										break;
									}
									goto case 17;
								}
								num3 = 0;
								break;
							case 4:
								result3 = awaiter.GetResult();
								num3 = 3;
								break;
							case 3:
								array = visionBuilderApi.Imdp7OjWHb<ToolchainStatus>(result3);
								num3 = 7;
								break;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								break;
							case 12:
								_003Cresponse_003E5__2 = result2;
								if (!zx52uSsUmw6V8ldkf3xI(_003Cresponse_003E5__2))
								{
									throw new VisionBuilderApiHttpException((string)vQ7GVUsUyF3vU355ifss(54314), _003Cresponse_003E5__2.StatusCode);
								}
								awaiter = ((HttpContent)K4NHTdsUgYuoQed3qSTl(_003Cresponse_003E5__2)).ReadAsStringAsync().GetAwaiter();
								goto case 19;
							default:
								num3 = 19;
								break;
							case 13:
								result2 = awaiter2.GetResult();
								num3 = 12;
								break;
							case 1:
								_003C_003Eu__2 = awaiter;
								num3 = 11;
								if (FYoltCsU4XC6tiArEcUS())
								{
									break;
								}
								goto case 19;
							case 19:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 1;
									break;
								}
								goto case 4;
							case 0:
							case 2:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 16;
									break;
								}
								goto case 13;
							case 20:
								throw new VisionBuilderApiHttpException((string)vQ7GVUsUyF3vU355ifss(54366), hBceNQsUZ4tGc1A12pGq(_003Cresponse_003E5__2));
							}
							continue;
							end_IL_024a:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cresponse_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 7:
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
		internal static object gKAuISsUf79qAYbg1plS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).RuntimeStatus();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EeQGq3sUFcgOgMDsj7Uq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zx52uSsUmw6V8ldkf3xI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vQ7GVUsUyF3vU355ifss(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K4NHTdsUgYuoQed3qSTl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode hBceNQsUZ4tGc1A12pGq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FYoltCsU4XC6tiArEcUS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t7ZwAtsUk4MXQIu7qh3g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public string versionId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass28_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aE2gp0sUzxtYgYTwymu7();
			saCL5UsTwKLrpuIIejwV(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CIsToolchainVersionValid_003Eb__0(ToolchainStatus s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rVfgPEsThg3u4bpNFBA0(p1R8tesTsfCN0DxU75i3(s), versionId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aE2gp0sUzxtYgYTwymu7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void saCL5UsTwKLrpuIIejwV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jMNaeYsUJOikEYv3deL9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YjoslHsU8nyHgnB5xgbm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p1R8tesTsfCN0DxU75i3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolchainStatus)P_0).VersionId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rVfgPEsThg3u4bpNFBA0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ToolchainStatusTool, bool> _003C_003E9__28_1;

		public static Func<ToolchainStatusTool, string> _003C_003E9__28_2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t4aCTBsTSc4sEEss7U3u();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t4aCTBsTSc4sEEss7U3u();
			f4Mi7AsTEbU1lMXlVl9o(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CIsToolchainVersionValid_003Eb__28_1(ToolchainStatusTool t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !vcoGbYsTvOT8AjndZ8VN(t);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CIsToolchainVersionValid_003Eb__28_2(ToolchainStatusTool t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)hxQGxLsTHCs2aF0WyKCM(t);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void t4aCTBsTSc4sEEss7U3u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool timEFWsTL4tAQwoxvPUh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aPnP8DsT9KsByMPTiXoo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void f4Mi7AsTEbU1lMXlVl9o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vcoGbYsTvOT8AjndZ8VN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolchainStatusTool)P_0).Ready;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hxQGxLsTHCs2aF0WyKCM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolchainStatusTool)P_0).Name;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadRuntimeArchiveAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public string versionId;

		private TaskAwaiter<List<Dictionary<string, string>>> _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			VisionBuilderApi visionBuilderApi = default;
			byte[] result = default;
			int num2 = default;
			TaskAwaiter<byte[]> awaiter = default;
			TaskAwaiter<List<Dictionary<string, string>>> awaiter2 = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					visionBuilderApi = _003C_003E4__this;
					Lt0tFysTVqq8YfBZ7flY();
					num = (wCYXNAsTAPIKVKlRajFN() ? 4 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 4;
								if (false)
								{
									goto IL_0217;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 9;
						}
						goto IL_00e3;
						IL_00e3:
						while (true)
						{
							switch (num3)
							{
							case 14:
								awaiter2 = visionBuilderApi.ListToolChainsAsync(projectId).GetAwaiter();
								_ = 1;
								num3 = (wCYXNAsTAPIKVKlRajFN() ? 3 : 6);
								continue;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
								awaiter = visionBuilderApi.ur0pn1wOkB(projectId, text, versionId).GetAwaiter();
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								goto case 12;
							default:
								num3 = 12;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter2;
								num3 = 7;
								continue;
							case 10:
								return;
							case 1:
							case 6:
								if (!awaiter2.IsCompleted)
								{
									goto case 2;
								}
								goto case 12;
							case 4:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (!wCYXNAsTAPIKVKlRajFN())
								{
									continue;
								}
								goto case 15;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto case 16;
							case 12:
								text = awaiter2.GetResult()[0][kgbOBx7BanbFa22Hp9.ol99ukmDA(54126)];
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 11;
								continue;
							case 8:
								return;
							case 11:
								break;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								result = awaiter.GetResult();
								goto end_IL_00e3;
							}
							goto IL_0217;
							continue;
							end_IL_00e3:
							break;
						}
						goto end_IL_004f;
						IL_0217:
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						goto IL_00e3;
						end_IL_004f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (false)
					{
						return;
					}
					break;
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
		internal static bool Lt0tFysTVqq8YfBZ7flY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wCYXNAsTAPIKVKlRajFN()
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
	private struct _003CAddSampleAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Bitmap image;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public BlobResource blobResource;

		public string imageName;

		public ImageMetadata imageMetadata;

		private MemoryStream _003CbitmapStream_003E5__2;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			string result = default;
			VisionBuilderApi visionBuilderApi = default;
			int num2 = default;
			TaskAwaiter<string> awaiter = default;
			do
			{
				IL_023b:
				switch (num)
				{
				default:
					_003CbitmapStream_003E5__2 = null;
					num = 0;
					goto IL_023b;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					goto IL_023b;
				case 1:
					visionBuilderApi = _003C_003E4__this;
					CbZ9ewsTDsRL4WmLbO0b();
					if (!pIJF4MsTUMWSrjOWiiEA())
					{
						num = 4;
						if (!pIJF4MsTUMWSrjOWiiEA())
						{
							goto IL_023b;
						}
						goto case 2;
					}
					num = 5;
					if (true)
					{
						goto IL_023b;
					}
					break;
				case 2:
				case 4:
					try
					{
						if (num2 != 0)
						{
							_003CbitmapStream_003E5__2 = new MemoryStream();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								image.Save(_003CbitmapStream_003E5__2, (ImageFormat)bhahc0sTTaxYHC58s3fs());
								num3 = 6;
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
								case 6:
									LqZwZ6sTdhtt05WtXHDy(_003CbitmapStream_003E5__2, 0L);
									num3 = 2;
									continue;
								case 0:
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 1:
									return;
								case 5:
									_003C_003Eu__1 = default;
									goto case 0;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 1;
									if (pIJF4MsTUMWSrjOWiiEA())
									{
									}
									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										pIJF4MsTUMWSrjOWiiEA();
										num3 = (CbZ9ewsTDsRL4WmLbO0b() ? 4 : 0);
										continue;
									}
									break;
								case 2:
									awaiter = visionBuilderApi.AddSampleAsync(projectId, blobResource, _003CbitmapStream_003E5__2, imageName, imageMetadata).GetAwaiter();
									num3 = 8;
									continue;
								case 3:
								case 4:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									goto case 9;
								default:
									num3 = 9;
									continue;
								case 10:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003CbitmapStream_003E5__2 != null)
							{
								hsdJ4gsTioexu1ZQshOA(_003CbitmapStream_003E5__2);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CbitmapStream_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					break;
				case 7:
					return;
				}
				num2 = _003C_003E1__state;
				num = 1;
			}
			while (CbZ9ewsTDsRL4WmLbO0b());
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
		internal static object bhahc0sTTaxYHC58s3fs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ImageFormat.Bmp;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LqZwZ6sTdhtt05WtXHDy(object P_0, long P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hsdJ4gsTioexu1ZQshOA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CbZ9ewsTDsRL4WmLbO0b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pIJF4MsTUMWSrjOWiiEA()
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
	private struct _003CAddSampleAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public Stream bitmapStream;

		public BlobResource blobResource;

		public string projectId;

		public string imageName;

		public ImageMetadata imageMetadata;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			string result2 = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			VisionBuilderApi visionBuilderApi = default;
			TaskAwaiter<string> awaiter2 = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = vw8hnxsTjsfJJSXKjq8T(visionBuilderApi.VWOp94Fj3d(bitmapStream, blobResource.UploadUrl));
							num3 = 19;
							goto IL_028c;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							goto IL_0092;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 9;
							goto IL_028c;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
								if (1 == 0)
								{
									goto IL_01fe;
								}
								goto IL_028c;
							}
							IL_028c:
							while (true)
							{
								switch (num3)
								{
								case 7:
									awaiter2 = visionBuilderApi.imJp0lLJ7G(projectId, imageName, result).GetAwaiter();
									num3 = 8;
									if (dUAITisTqvVgNsDZotWO())
									{
										continue;
									}
									break;
								case 11:
								case 17:
									break;
								case 15:
									_003C_003Eu__2 = awaiter2;
									num3 = 16;
									continue;
								case 9:
									_003C_003Eu__2 = default;
									num3 = 20;
									if (!UKOAbVsTBqROWoXPScXI())
									{
										continue;
									}
									return;
								case 4:
								case 10:
									return;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 1:
									goto IL_0129;
								case 8:
									if (!awaiter2.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto case 21;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 18;
									continue;
								case 3:
									awaiter2 = visionBuilderApi.EpgpUCXFvK(projectId, imageName, (string)HjHFV1sTc3kfWYFqh3yZ(blobResource), imageMetadata).GetAwaiter();
									num3 = 1;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 12;
									continue;
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 6;
									continue;
								case 12:
									return;
								case 6:
									goto IL_01fe;
								case 20:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 2);
									num3 = 15;
									if (!UKOAbVsTBqROWoXPScXI())
									{
										continue;
									}
									goto case 0;
								case 0:
									_003C_003Eu__2 = awaiter2;
									num3 = 13;
									continue;
								case 19:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 5;
										continue;
									}
									goto IL_01fe;
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									goto default;
								default:
									dUAITisTqvVgNsDZotWO();
									if (UKOAbVsTBqROWoXPScXI())
									{
										num3 = 17;
										continue;
									}
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 21;
								case 21:
									result2 = awaiter2.GetResult();
									goto end_IL_002f;
								}
								break;
								IL_0129:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 0;
									if (UKOAbVsTBqROWoXPScXI())
									{
									}
									continue;
								}
								goto IL_009b;
							}
							goto IL_0092;
							IL_01fe:
							awaiter.GetResult();
							num3 = 3;
							goto IL_028c;
							IL_0092:
							num2 = (_003C_003E1__state = -1);
							goto IL_009b;
							IL_009b:
							result = awaiter2.GetResult();
							num3 = 7;
							goto IL_028c;
							end_IL_002f:
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
					goto case 0;
				default:
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					visionBuilderApi = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (dUAITisTqvVgNsDZotWO() ? 5 : 4);
					break;
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
		internal static TaskAwaiter vw8hnxsTjsfJJSXKjq8T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HjHFV1sTc3kfWYFqh3yZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BlobResource)P_0).BlobUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dUAITisTqvVgNsDZotWO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UKOAbVsTBqROWoXPScXI()
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
	private struct _003CCreateBlobAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<BlobResource>> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public int numOfDataBlobs;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			List<BlobResource> result2 = default;
			VisionBuilderApi visionBuilderApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<string> awaiter;
						TaskAwaiter<HttpResponseMessage> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0169;
							}
							string text = (string)mB4RdAsTtlMyqlJjTGxJ(cmi7xrsT7KvNSNIu235S(visionBuilderApi.U8Hp5RTu74().Projects(projectId)));
							Dictionary<string, object> dictionary = new Dictionary<string, object> { 
							{
								(string)CZTLslsTCAdBGFuByB4k(54484),
								numOfDataBlobs
							} };
							awaiter2 = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						HttpResponseMessage result = awaiter2.GetResult();
						if (!AAmWlRsTKSK1BOiHn0AK(result))
						{
							throw new VisionBuilderApiHttpException(kgbOBx7BanbFa22Hp9.ol99ukmDA(54510), meaPp4sT5ZXDwbYUe6Yg(result));
						}
						awaiter = ((HttpContent)culARcsTog7MFTLlov6P(result)).ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0169;
						IL_0169:
						List<Dictionary<string, string>>? list = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(awaiter.GetResult());
						List<BlobResource> list2 = new List<BlobResource>();
						List<Dictionary<string, string>>.Enumerator enumerator = list.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Dictionary<string, string> current = enumerator.Current;
								dlderlsT2nGOcHYZRQ51();
								int num3;
								if (!shilDUsTW9f287oIYiXd())
								{
									num3 = 2;
								}
								else
								{
									num3 = 3;
									if (false)
									{
										continue;
									}
								}
								switch (num3)
								{
								case 0:
								case 2:
									list2.Add(new BlobResource(current[(string)CZTLslsTCAdBGFuByB4k(54568)], current[kgbOBx7BanbFa22Hp9.ol99ukmDA(54592)]));
									break;
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
							}
						}
						result2 = list2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				visionBuilderApi = _003C_003E4__this;
				shilDUsTW9f287oIYiXd();
				num = (dlderlsT2nGOcHYZRQ51() ? 1 : 5);
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
		internal static object cmi7xrsT7KvNSNIu235S(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Blobs();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mB4RdAsTtlMyqlJjTGxJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CZTLslsTCAdBGFuByB4k(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AAmWlRsTKSK1BOiHn0AK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode meaPp4sT5ZXDwbYUe6Yg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object culARcsTog7MFTLlov6P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dlderlsT2nGOcHYZRQ51()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool shilDUsTW9f287oIYiXd()
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
	private struct _003CUploadImageAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Stream bitmapStream;

		public VisionBuilderApi _003C_003E4__this;

		public string blobUrl;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gZfniXsTYpfZFr7hx0w5();
			int num;
			if (EedGUAsTPO8y4o0bpATw())
			{
				num = 3;
				if (!EedGUAsTPO8y4o0bpATw())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_025c;
			IL_0287:
			VisionBuilderApi visionBuilderApi = _003C_003E4__this;
			num = 2;
			if (gZfniXsTYpfZFr7hx0w5())
			{
				return;
			}
			goto IL_025c;
			IL_025c:
			StreamContent streamContent = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			int num2 = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							streamContent = new StreamContent(bitmapStream);
							EedGUAsTPO8y4o0bpATw();
							if (!gZfniXsTYpfZFr7hx0w5())
							{
								num3 = 1;
								if (!EedGUAsTPO8y4o0bpATw())
								{
									goto IL_008c;
								}
							}
							else
							{
								num3 = 11;
								if (gZfniXsTYpfZFr7hx0w5())
								{
									goto IL_01f5;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (!EedGUAsTPO8y4o0bpATw())
							{
								goto IL_016d;
							}
						}
						goto IL_00d4;
						IL_0142:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00b1:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						goto IL_0142;
						IL_01f5:
						if (!Fh9akBsTrjbT1AAiQxIo(result))
						{
							num3 = 12;
							goto IL_00d4;
						}
						goto end_IL_005a;
						IL_016d:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_00d4;
						IL_008c:
						awaiter = visionBuilderApi.tRlpRA4VqP(blobUrl, streamContent, _0020: false).GetAwaiter();
						num3 = 5;
						if (!EedGUAsTPO8y4o0bpATw())
						{
							goto IL_00b1;
						}
						goto IL_00d4;
						IL_00d4:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 8:
								goto IL_00b1;
							default:
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								mibeoFsT1C54tsYMiTen(tjCOSYsTNs86U9EkMlmt(streamContent), kgbOBx7BanbFa22Hp9.ol99ukmDA(54640), ePpdXCsTx5T5MB9Ih7bh(54672));
								num3 = 7;
								continue;
							case 2:
								goto IL_0142;
							case 4:
								goto IL_016d;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 6;
							case 0:
							case 1:
								mibeoFsT1C54tsYMiTen(tjCOSYsTNs86U9EkMlmt(streamContent), ePpdXCsTx5T5MB9Ih7bh(54612), ePpdXCsTx5T5MB9Ih7bh(50562));
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
								result = awaiter.GetResult();
								goto IL_01f5;
							case 9:
							case 11:
								goto IL_01f5;
							case 12:
								throw new VisionBuilderApiHttpException((string)ePpdXCsTx5T5MB9Ih7bh(54694), fNEQTcsT38p54lxNLs6s(result));
							}
							break;
						}
						goto IL_008c;
						end_IL_005a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					continue;
				case 1:
				case 5:
					goto IL_0287;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			num2 = _003C_003E1__state;
			goto IL_0287;
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
		internal static object tjCOSYsTNs86U9EkMlmt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpContent)P_0).Headers;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ePpdXCsTx5T5MB9Ih7bh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mibeoFsT1C54tsYMiTen(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fh9akBsTrjbT1AAiQxIo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode fNEQTcsT38p54lxNLs6s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EedGUAsTPO8y4o0bpATw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gZfniXsTYpfZFr7hx0w5()
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
	private struct _003CRegisterImageAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string imageName;

		public string blobUrl;

		public ImageMetadata imageMetadata;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			string result2 = default;
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			TaskAwaiter<string> awaiter = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			Dictionary<string, object> dictionary = default;
			string text = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 0:
					visionBuilderApi = _003C_003E4__this;
					_ = 1;
					if (!HKmVS6sTMj4RpCGGvj5B())
					{
						num = 5;
						if (HKmVS6sTMj4RpCGGvj5B())
						{
						}
					}
					else
					{
						num = 1;
						if (false)
						{
							return;
						}
					}
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_0267;
							}
							num3 = 9;
							if (1 == 0)
							{
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 13;
						}
						goto IL_00ea;
						IL_00ea:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 0;
								continue;
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto IL_015e;
							case 13:
								_003C_003Eu__1 = default;
								goto default;
							default:
								HKmVS6sTMj4RpCGGvj5B();
								num3 = (pAOAVOsTOXrHFc29Ge4Z() ? 6 : 12);
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto IL_015e;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									if (true)
									{
										continue;
									}
									return;
								}
								goto case 18;
							case 0:
								return;
							case 9:
								dictionary = new Dictionary<string, object>
								{
									{
										(string)eObtZ1sTQD3vpBmR83mh(54728),
										imageName
									},
									{
										(string)eObtZ1sTQD3vpBmR83mh(54748),
										blobUrl
									},
									{
										(string)eObtZ1sTQD3vpBmR83mh(41184),
										new Cognex.InSight.VisionBuilder.Types.ImageAttributes(imageMetadata)
									}
								};
								text = (string)eX57ypsTlcciQnae3xWD(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Images());
								num3 = 16;
								continue;
							case 17:
								_003C_003Eu__1 = awaiter2;
								num3 = 15;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								continue;
							case 16:
								awaiter2 = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
								num3 = 3;
								continue;
							case 12:
							case 14:
								break;
							case 11:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (!HKmVS6sTMj4RpCGGvj5B())
								{
									continue;
								}
								goto case 10;
							case 10:
								throw new VisionBuilderApiHttpException(kgbOBx7BanbFa22Hp9.ol99ukmDA(54770), gx9Ig8sTuvGo8RHnj0FK(result));
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 5:
								if (JZkjBssTex5X9UEAHL67(result))
								{
									awaiter = ((HttpContent)fT2xQbsTIxNx9JyYF7Nf(result)).ReadAsStringAsync().GetAwaiter();
									num3 = 1;
								}
								else
								{
									num3 = 10;
								}
								continue;
							case 18:
								{
									result2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(awaiter.GetResult())[(string)eObtZ1sTQD3vpBmR83mh(54808)] as string;
									goto end_IL_00ea;
								}
								IL_015e:
								result = awaiter2.GetResult();
								num3 = 5;
								continue;
							}
							goto IL_0267;
							continue;
							end_IL_00ea:
							break;
						}
						goto end_IL_0068;
						IL_0267:
						_003C_003Eu__2 = default;
						num3 = 2;
						goto IL_00ea;
						end_IL_0068:;
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
		internal static object eObtZ1sTQD3vpBmR83mh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eX57ypsTlcciQnae3xWD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JZkjBssTex5X9UEAHL67(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode gx9Ig8sTuvGo8RHnj0FK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fT2xQbsTIxNx9JyYF7Nf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pAOAVOsTOXrHFc29Ge4Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HKmVS6sTMj4RpCGGvj5B()
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
	private struct _003CAddImageSampleAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string imageName;

		public string imageId;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_039e;
			IL_001a:
			string result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (1 == 0)
			{
				goto IL_0032;
			}
			goto IL_039e;
			IL_0032:
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			try
			{
				int num3;
				TaskAwaiter<string> awaiter = default;
				TaskAwaiter<HttpResponseMessage> awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 14;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 4;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					ImXRJssTRBH20KcIZGVp();
					if (AT0avWsTaQHc56qFLvlL())
					{
						num3 = 16;
						if (AT0avWsTaQHc56qFLvlL())
						{
							return;
						}
					}
					else
					{
						num3 = 12;
						if (!ImXRJssTRBH20KcIZGVp())
						{
							goto IL_0120;
						}
					}
				}
				string text = default;
				List<Dictionary<string, object>> list = default;
				Dictionary<string, object> item = default;
				HttpResponseMessage result2 = default;
				while (true)
				{
					switch (num3)
					{
					case 7:
						text = visionBuilderApi.U8Hp5RTu74().Projects(projectId).Samples()
							.Build();
						list = new List<Dictionary<string, object>> { item };
						num3 = 0;
						continue;
					case 0:
						awaiter2 = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(list)).GetAwaiter();
						num3 = 13;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
						_003C_003Eu__1 = awaiter2;
						num3 = 5;
						if (ImXRJssTRBH20KcIZGVp())
						{
							continue;
						}
						goto case 11;
					case 11:
					case 16:
						if (!hTDdMysTG0PnDthY83mI(result2))
						{
							num3 = 15;
							continue;
						}
						awaiter = ((HttpContent)Pdrsx4sT6KV64eZA5V6i(result2)).ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 3;
							continue;
						}
						goto case 19;
					case 10:
						result2 = awaiter2.GetResult();
						goto case 11;
					case 17:
						return;
					case 3:
						break;
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 19;
						if (0 == 0)
						{
							continue;
						}
						goto case 18;
					case 18:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 15:
						if (result2.StatusCode == HttpStatusCode.Conflict)
						{
							num3 = 2;
							continue;
						}
						throw new VisionBuilderApiHttpException((string)NEKcNLsTnLGBNX3x5Agm(54860), bIAVBZsTbvcnBjJ3m5Yg(result2));
					case 2:
						throw new ArgumentException((string)sLWP32sTX2G4OfhMSSNJ(NEKcNLsTnLGBNX3x5Agm(54844), imageName, NEKcNLsTnLGBNX3x5Agm(42960)), imageName);
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 17;
						continue;
					case 4:
						_003C_003Eu__2 = default;
						num3 = 6;
						continue;
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 8:
					case 12:
						_003C_003Eu__1 = default;
						goto case 1;
					default:
						num3 = 1;
						if (ImXRJssTRBH20KcIZGVp())
						{
							continue;
						}
						goto case 14;
					case 14:
						item = new Dictionary<string, object>
						{
							{
								(string)NEKcNLsTnLGBNX3x5Agm(4310),
								imageName
							},
							{
								(string)NEKcNLsTnLGBNX3x5Agm(54828),
								new Dictionary<string, object> { 
								{
									(string)NEKcNLsTnLGBNX3x5Agm(54000),
									new Dictionary<string, string> { 
									{
										(string)NEKcNLsTnLGBNX3x5Agm(54808),
										imageId
									} }
								} }
							}
						};
						num3 = 7;
						continue;
					case 13:
						if (!awaiter2.IsCompleted)
						{
							num3 = 18;
							continue;
						}
						goto case 10;
					case 19:
						result = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(awaiter.GetResult())[0][(string)NEKcNLsTnLGBNX3x5Agm(54912)];
						goto end_IL_0264;
					}
					goto IL_0120;
					continue;
					end_IL_0264:
					break;
				}
				goto end_IL_0032;
				IL_0120:
				_003C_003Eu__2 = awaiter;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0032:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_001a;
			IL_039e:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 2:
					goto IL_0032;
				default:
					num = 3;
					continue;
				case 5:
					goto IL_03c9;
				case 1:
				case 4:
					visionBuilderApi = _003C_003E4__this;
					goto IL_0032;
				case 6:
					return;
				}
				break;
				IL_03c9:
				num2 = _003C_003E1__state;
				ImXRJssTRBH20KcIZGVp();
				num = ((!AT0avWsTaQHc56qFLvlL()) ? 4 : 0);
			}
			goto IL_001a;
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
		internal static object NEKcNLsTnLGBNX3x5Agm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hTDdMysTG0PnDthY83mI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sLWP32sTX2G4OfhMSSNJ(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode bIAVBZsTbvcnBjJ3m5Yg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Pdrsx4sT6KV64eZA5V6i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ImXRJssTRBH20KcIZGVp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AT0avWsTaQHc56qFLvlL()
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
	private struct _003CListSamplesAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Sample[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<Sample[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C51SIdsT0rvtvamm22lh();
			int num;
			if (kgcBn7sTpjjO6Sl3xBdu())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0203;
			IL_002a:
			Sample[] result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (C51SIdsT0rvtvamm22lh())
			{
			}
			goto IL_0203;
			IL_0203:
			int num2 = default;
			string url = default;
			VisionBuilderApi visionBuilderApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 3:
					try
					{
						if (num2 != 0)
						{
							url = (string)uFpprjsT4vtgHWWVHA9H(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Samples());
						}
						try
						{
							TaskAwaiter<Sample[]> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = visionBuilderApi.GetPagedArrayAsync<Sample>(url, 100, kgbOBx7BanbFa22Hp9.ol99ukmDA(53834)).GetAwaiter();
								num3 = 8;
								if (!kgcBn7sTpjjO6Sl3xBdu())
								{
									goto IL_00a2;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
							}
							goto IL_00e1;
							IL_019a:
							result = awaiter.GetResult();
							goto end_IL_0072;
							IL_00e1:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 5:
									break;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								case 4:
									_003C_003Eu__1 = default;
									num3 = 0;
									continue;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										C51SIdsT0rvtvamm22lh();
										if (!kgcBn7sTpjjO6Sl3xBdu())
										{
											num3 = 7;
											if (kgcBn7sTpjjO6Sl3xBdu())
											{
												continue;
											}
											goto case 3;
										}
										num3 = 5;
										if (true)
										{
											continue;
										}
										return;
									}
									goto IL_019a;
								case 6:
									return;
								case 2:
								case 7:
									goto IL_0182;
								case 9:
									goto IL_019a;
								}
								break;
							}
							goto IL_00a2;
							IL_00a2:
							num2 = (_003C_003E1__state = 0);
							goto IL_0182;
							IL_0182:
							_003C_003Eu__1 = awaiter;
							num3 = 3;
							if (!C51SIdsT0rvtvamm22lh())
							{
								goto IL_00e1;
							}
							goto IL_019a;
							end_IL_0072:;
						}
						catch (VisionBuilderApiHttpException ex)
						{
							throw new VisionBuilderApiHttpException((string)VEym5MsTFO51juYbKQOf(MskmSZsTkiSTLvJE8YPZ(54934), WORrxvsTfeJIe9gQEu7i(ex)), PWHecUsTmMjoBVR00cyF(ex));
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
					num = 2;
					continue;
				case 1:
				case 4:
					visionBuilderApi = _003C_003E4__this;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object uFpprjsT4vtgHWWVHA9H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MskmSZsTkiSTLvJE8YPZ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WORrxvsTfeJIe9gQEu7i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VEym5MsTFO51juYbKQOf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode PWHecUsTmMjoBVR00cyF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderApiHttpException)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kgcBn7sTpjjO6Sl3xBdu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C51SIdsT0rvtvamm22lh()
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
	private struct _003CListTagsAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageManagerTag[]> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!QPkAOMsTgbvEATH3GaX6())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (QPkAOMsTgbvEATH3GaX6())
				{
					goto IL_0324;
				}
			}
			goto IL_02ed;
			IL_02ed:
			int num2 = default;
			ImageManagerTag[] result = default;
			TaskAwaiter<string> awaiter = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			HttpResponseMessage result3 = default;
			string result2 = default;
			string text = default;
			VisionBuilderApi visionBuilderApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								goto IL_020f;
							}
							num3 = 5;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00b7;
						IL_00b7:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								}
								goto case 6;
							case 2:
								result3 = awaiter2.GetResult();
								goto case 17;
							default:
								num3 = 17;
								continue;
							case 6:
								result2 = awaiter.GetResult();
								num3 = 18;
								if (!QPkAOMsTgbvEATH3GaX6())
								{
									continue;
								}
								return;
							case 7:
							case 13:
								return;
							case 9:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								num3 = (KGUQnmsTyP3u2DhcVoe3() ? 7 : 11);
								continue;
							case 16:
								if (!awaiter2.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 2;
							case 4:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								continue;
							case 5:
								text = (string)A7UdNosTZC5L1JNoG03u(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Tags());
								num3 = 1;
								continue;
							case 1:
								awaiter2 = visionBuilderApi.n1Np6GCYAu(text).GetAwaiter();
								num3 = 16;
								continue;
							case 15:
								return;
							case 11:
							case 14:
								break;
							case 3:
								throw new VisionBuilderApiHttpException((string)G7joPksTzBKYwxtN0aLT(JkZQ0EsT8SMnwnjyTZFL(54966), result3.ReasonPhrase), wYpB3lsdw6oSZprpMIud(result3));
							case 17:
								if (EAIUPPsTJP0gbRNgA7QU(result3))
								{
									awaiter = ((HttpContent)iA3XtmsdsVHiH0tBgXSC(result3)).ReadAsStringAsync().GetAwaiter();
									num3 = 8;
								}
								else
								{
									num3 = 3;
								}
								continue;
							case 12:
								num2 = (_003C_003E1__state = 1);
								num3 = 9;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								if (QPkAOMsTgbvEATH3GaX6())
								{
								}
								continue;
							case 18:
								result = visionBuilderApi.Imdp7OjWHb<ImageManagerTag>(result2);
								goto end_IL_00b7;
							}
							goto IL_020f;
							continue;
							end_IL_00b7:
							break;
						}
						goto end_IL_004b;
						IL_020f:
						num2 = (_003C_003E1__state = -1);
						num3 = 6;
						goto IL_00b7;
						end_IL_004b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0324;
			IL_0324:
			visionBuilderApi = _003C_003E4__this;
			num = 5;
			goto IL_02ed;
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
		internal static object A7UdNosTZC5L1JNoG03u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EAIUPPsTJP0gbRNgA7QU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JkZQ0EsT8SMnwnjyTZFL(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G7joPksTzBKYwxtN0aLT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode wYpB3lsdw6oSZprpMIud(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iA3XtmsdsVHiH0tBgXSC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).Content;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KGUQnmsTyP3u2DhcVoe3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QPkAOMsTgbvEATH3GaX6()
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
	private struct _003CAddTagAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ImageManagerTag> _003C_003Et__builder;

		public string name;

		public string color;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			InDChPsdL3Mj0UxN5wqb();
			int num;
			if (pwpyh0sdhEvd9MY2ZSng())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0334;
			IL_002a:
			int num2 = _003C_003E1__state;
			num = 3;
			goto IL_0334;
			IL_0334:
			TaskAwaiter<string> awaiter = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			VisionBuilderApi visionBuilderApi = default;
			string text = default;
			Dictionary<string, object> dictionary = default;
			HttpResponseMessage result = default;
			ImageManagerTag result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_02d6;
							}
							num3 = 9;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
							if (InDChPsdL3Mj0UxN5wqb())
							{
								goto IL_006f;
							}
						}
						goto IL_0120;
						IL_0120:
						while (true)
						{
							switch (num3)
							{
							case 15:
								return;
							case 0:
								break;
							case 12:
								awaiter2 = visionBuilderApi.xcDpw0S2qt(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								}
								goto IL_0184;
							case 2:
								throw new VisionBuilderApiHttpException((string)empr89sdvIQ0q9TMReGh(KVWBFLsd9ppr5Y48jL63(55006), JEXVTTsdE7BHvfU6UvL2(result)), result.StatusCode);
							case 8:
								_003C_003Eu__1 = default;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto IL_0184;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 0;
								continue;
							case 6:
								text = visionBuilderApi.U8Hp5RTu74().Projects(projectId).Tags()
									.Build();
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 17:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								if (!InDChPsdL3Mj0UxN5wqb())
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								continue;
							case 1:
								if (AFsQ8TsdSKBXGLt6sTgd(result))
								{
									awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 16;
										if (pwpyh0sdhEvd9MY2ZSng())
										{
											continue;
										}
										goto case 8;
									}
									goto case 18;
								}
								num3 = 2;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter2;
								pwpyh0sdhEvd9MY2ZSng();
								if (InDChPsdL3Mj0UxN5wqb())
								{
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 16;
								}
								num3 = 17;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								dictionary = new Dictionary<string, object>
								{
									{
										(string)KVWBFLsd9ppr5Y48jL63(4310),
										name
									},
									{
										(string)KVWBFLsd9ppr5Y48jL63(54992),
										new Dictionary<string, string> { 
										{
											(string)KVWBFLsd9ppr5Y48jL63(33770),
											color
										} }
									}
								};
								num3 = 6;
								continue;
							case 11:
							case 14:
								goto IL_02d6;
							case 18:
								{
									result2 = JsonConvert.DeserializeObject<ImageManagerTag>(awaiter.GetResult());
									goto end_IL_003b;
								}
								IL_0184:
								result = awaiter2.GetResult();
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 7;
							}
							break;
						}
						goto IL_006f;
						IL_006f:
						_003C_003Eu__2 = awaiter;
						num3 = 7;
						goto IL_0120;
						IL_02d6:
						_003C_003Eu__2 = default;
						num3 = 3;
						goto IL_0120;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
					visionBuilderApi = _003C_003E4__this;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object KVWBFLsd9ppr5Y48jL63(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AFsQ8TsdSKBXGLt6sTgd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JEXVTTsdE7BHvfU6UvL2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).ReasonPhrase;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object empr89sdvIQ0q9TMReGh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pwpyh0sdhEvd9MY2ZSng()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InDChPsdL3Mj0UxN5wqb()
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
	private struct _003CAddImagesToTagsAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] imageIds;

		public VisionBuilderApi _003C_003E4__this;

		public string projectId;

		public string tagId;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JKNWbAsdHUJay2UtYtC5();
			int num;
			if (!m0ZdXXsdVgt2cvgH5QhT())
			{
				num = 5;
				if (!JKNWbAsdHUJay2UtYtC5())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_025e;
			IL_002e:
			VisionBuilderApi visionBuilderApi = _003C_003E4__this;
			num = 4;
			goto IL_025e;
			IL_025e:
			int num2 = default;
			Dictionary<string, object> dictionary = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			HttpResponseMessage result = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							dictionary = new Dictionary<string, object> { 
							{
								(string)G2MNdjsdA3ViWUJlZkBW(55034),
								imageIds
							} };
							num3 = 1;
							if (1 == 0)
							{
								goto IL_0099;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00c6;
						IL_00c6:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 10:
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								goto IL_0112;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 7:
							case 9:
								if (!JDtjLGsdUQgnsAFaI6au(result))
								{
									num3 = 12;
									continue;
								}
								goto end_IL_00c6;
							case 0:
								awaiter = visionBuilderApi.GKupKwf9SJ(text, visionBuilderApi.zjqpYW3Po3(dictionary)).GetAwaiter();
								num3 = 5;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = (JKNWbAsdHUJay2UtYtC5() ? 10 : 7);
									continue;
								}
								goto IL_0112;
							case 1:
								text = (string)f6JLkcsdDwjaCISTqfVM(visionBuilderApi.U8Hp5RTu74().Projects(projectId).Tags(tagId)
									.Samples());
								num3 = 0;
								continue;
							case 6:
								return;
							case 12:
								{
									throw new VisionBuilderApiHttpException((string)g4k1lvsdd1EW6LUqXNhe(G2MNdjsdA3ViWUJlZkBW(55064), VFG4hKsdT5eEU2kTOG5U(result)), AaREWysdibLGe6DYthKH(result));
								}
								IL_0112:
								result = awaiter.GetResult();
								goto case 7;
							}
							goto IL_0099;
							continue;
							end_IL_00c6:
							break;
						}
						goto end_IL_006b;
						IL_0099:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						goto IL_00c6;
						end_IL_006b:;
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
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static object G2MNdjsdA3ViWUJlZkBW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f6JLkcsdDwjaCISTqfVM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((VisionBuilderUrlBuilder)P_0).Build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JDtjLGsdUQgnsAFaI6au(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VFG4hKsdT5eEU2kTOG5U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).ReasonPhrase;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g4k1lvsdd1EW6LUqXNhe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode AaREWysdibLGe6DYthKH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JKNWbAsdHUJay2UtYtC5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m0ZdXXsdVgt2cvgH5QhT()
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
	private struct _003CPostAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		public HttpContent content;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wv890LsdBbZquwh1AJXZ();
			int num;
			if (iPCDLxsdqf5WatysGuAI())
			{
				num = 1;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (!iPCDLxsdqf5WatysGuAI())
				{
					goto IL_02a9;
				}
			}
			goto IL_0272;
			IL_0272:
			int num2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			TaskAwaiter<string> awaiter2 = default;
			VisionBuilderApi visionBuilderApi = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 0;
								if (wv890LsdBbZquwh1AJXZ())
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (wv890LsdBbZquwh1AJXZ())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 7;
							if (1 == 0)
							{
								goto IL_0070;
							}
						}
						goto IL_00a6;
						IL_01a6:
						awaiter2.GetResult();
						num3 = 2;
						goto IL_00a6;
						IL_00a6:
						while (true)
						{
							switch (num3)
							{
							case 14:
								return;
							case 8:
								break;
							case 7:
								_003C_003Eu__1 = default;
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 0:
								goto IL_00f9;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter2;
								num3 = 4;
								continue;
							case 2:
								awaiter = visionBuilderApi.HttpApi.PostAsync(visionBuilderApi.UZLpEovFi3, url, content).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 16;
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								continue;
							case 6:
							case 12:
								goto IL_018c;
							case 5:
								goto IL_01a6;
							case 13:
								return;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								continue;
							case 1:
							case 15:
								if (!awaiter2.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto IL_01a6;
							case 16:
								result = awaiter.GetResult();
								goto end_IL_003b;
							}
							break;
							IL_00f9:
							awaiter2 = visionBuilderApi.UpdateHttpClientAuthorizationAsync().GetAwaiter();
							_ = 0;
							num3 = (iPCDLxsdqf5WatysGuAI() ? 15 : 6);
						}
						goto IL_0070;
						IL_018c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 13;
						if (true)
						{
							goto IL_00a6;
						}
						goto IL_01a6;
						IL_0070:
						_003C_003Eu__2 = awaiter;
						goto IL_018c;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 1:
					goto IL_02a9;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_02a9:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_0272;
			IL_002a:
			visionBuilderApi = _003C_003E4__this;
			num = 2;
			goto IL_0272;
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
		internal static bool iPCDLxsdqf5WatysGuAI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wv890LsdBbZquwh1AJXZ()
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
	private struct _003CPutAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public bool useAuthorization;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		public HttpContent content;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			TaskAwaiter<string> awaiter2 = default;
			VisionBuilderApi visionBuilderApi = default;
			HttpResponseMessage result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 16;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 7;
								if (1 == 0)
								{
									return;
								}
							}
							goto IL_0182;
						}
						awaiter2 = _003C_003Eu__1;
						goto IL_01ef;
						IL_0182:
						while (true)
						{
							switch (num3)
							{
							case 9:
								awaiter2.GetResult();
								goto IL_004d;
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								continue;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									num3 = ((!NkhSoisdjEEC0tswnGFY()) ? 14 : 4);
									continue;
								}
								goto case 9;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 17;
							case 3:
							case 4:
								_003C_003Eu__1 = awaiter2;
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 12;
								continue;
							case 7:
								_003C_003Eu__2 = default;
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 0:
								awaiter2 = visionBuilderApi.UpdateHttpClientAuthorizationAsync().GetAwaiter();
								num3 = 10;
								continue;
							case 6:
							case 14:
								break;
							case 16:
								if (!useAuthorization)
								{
									gOynQWsdWTfqS9tCW8xX(xhtWdfsd2ZjO6sd4dtYE(visionBuilderApi.UZLpEovFi3), null);
									goto IL_004d;
								}
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 17:
								{
									result = awaiter.GetResult();
									goto end_IL_0182;
								}
								IL_004d:
								awaiter = visionBuilderApi.HttpApi.PutAsync(visionBuilderApi.UZLpEovFi3, url, content).GetAwaiter();
								num3 = 11;
								continue;
							}
							goto IL_01ef;
							continue;
							end_IL_0182:
							break;
						}
						goto end_IL_0018;
						IL_01ef:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0182;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 1:
				case 4:
					visionBuilderApi = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				NkhSoisdjEEC0tswnGFY();
				num = (xWWGg1sdc8UwRN3j01iI() ? 5 : 4);
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
		internal static object xhtWdfsd2ZjO6sd4dtYE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HttpClient)P_0).DefaultRequestHeaders;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gOynQWsdWTfqS9tCW8xX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HttpRequestHeaders)P_0).Authorization = (AuthenticationHeaderValue)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NkhSoisdjEEC0tswnGFY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xWWGg1sdc8UwRN3j01iI()
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
	private struct _003CGetPagedArrayAsync_003Ed__43<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T[]> _003C_003Et__builder;

		public int resultsPerPage;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		public string pagingQueryObjectName;

		private int _003Coffset_003E5__2;

		private List<T> _003Cresults_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (true ? 1 : 5);
			T[] result = default;
			int num2 = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			HttpResponseMessage result3 = default;
			T[] array = default;
			string text = default;
			VisionBuilderApi visionBuilderApi = default;
			string result2 = default;
			int num5 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 6:
					_003Cresults_003E5__3 = null;
					num = 4;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 6;
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 18;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
							break;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 23:
								result3 = awaiter.GetResult();
								num3 = 15;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 22:
								num4 = array.Length;
								goto IL_00a4;
							case 21:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 23;
							case 9:
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 15:
								if (!result3.IsSuccessStatusCode)
								{
									num3 = 7;
									continue;
								}
								awaiter2 = result3.Content.ReadAsStringAsync().GetAwaiter();
								goto case 10;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 20:
								_003Coffset_003E5__2 += resultsPerPage;
								num3 = 13;
								continue;
							case 1:
								return;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num3 = 19;
									continue;
								}
								goto case 8;
							case 19:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								continue;
							case 18:
								_003C_003Eu__2 = default;
								goto case 9;
							case 6:
								_003Coffset_003E5__2 = 0;
								num3 = 5;
								continue;
							case 2:
							case 14:
							{
								Dictionary<string, object> dictionary = new Dictionary<string, object>
								{
									{
										kgbOBx7BanbFa22Hp9.ol99ukmDA(55112),
										resultsPerPage
									},
									{
										kgbOBx7BanbFa22Hp9.ol99ukmDA(55126),
										_003Coffset_003E5__2
									}
								};
								text = visionBuilderApi.LFKpsZFGXF(url, dictionary, pagingQueryObjectName);
								num3 = 4;
								continue;
							}
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 23;
								continue;
							case 4:
								awaiter = visionBuilderApi.n1Np6GCYAu(text).GetAwaiter();
								num3 = 21;
								continue;
							case 12:
								_003C_003Eu__2 = awaiter2;
								num3 = 11;
								continue;
							case 8:
								result2 = awaiter2.GetResult();
								num3 = 17;
								continue;
							case 5:
								num5 = 0;
								_003Cresults_003E5__3 = new List<T>();
								_ = 0;
								num3 = (true ? 14 : 9);
								continue;
							case 7:
								throw new VisionBuilderApiHttpException(result3.ReasonPhrase, result3.StatusCode);
							default:
								num3 = 10;
								continue;
							case 13:
								if (num5 <= 0)
								{
									num3 = 24;
									continue;
								}
								goto case 2;
							case 17:
								array = visionBuilderApi.Imdp7OjWHb<T>(result2);
								if (array == null)
								{
									num4 = 0;
									goto IL_00a4;
								}
								num3 = 22;
								continue;
							case 24:
								{
									result = _003Cresults_003E5__3.ToArray();
									break;
								}
								IL_00a4:
								num5 = num4;
								_003Cresults_003E5__3.AddRange(array);
								num3 = 20;
								continue;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cresults_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 3:
					visionBuilderApi = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 7:
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
		internal static bool b3nVhtsd7Hv9hjotg8y7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NgJwUAsdtAj0XD77tHmU()
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
	private struct _003CGetAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tovITLsdCZTq7WW2rH8y();
			int num = (xcRg2qsdKaBNS1TUkJw9() ? 5 : 4);
			HttpResponseMessage result = default;
			int num2 = default;
			VisionBuilderApi visionBuilderApi = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			TaskAwaiter<string> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					visionBuilderApi = _003C_003E4__this;
					num = 2;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
								if (xcRg2qsdKaBNS1TUkJw9())
								{
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 1;
								if (!tovITLsdCZTq7WW2rH8y())
								{
									goto IL_01ac;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 4;
						}
						goto IL_00e8;
						IL_00e8:
						while (true)
						{
							switch (num3)
							{
							case 8:
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 15;
									if (tovITLsdCZTq7WW2rH8y())
									{
										continue;
									}
									goto case 1;
								}
								goto case 16;
							case 1:
								_003C_003Eu__2 = default;
								num3 = 5;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								awaiter2.GetResult();
								goto case 0;
							default:
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 14;
									continue;
								}
								goto case 3;
							case 2:
								return;
							case 14:
								_003C_003Eu__1 = awaiter2;
								num3 = 13;
								continue;
							case 6:
								return;
							case 11:
								return;
							case 15:
								break;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 2;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								awaiter2 = visionBuilderApi.UpdateHttpClientAuthorizationAsync().GetAwaiter();
								num3 = 7;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (xcRg2qsdKaBNS1TUkJw9())
								{
								}
								continue;
							case 0:
								awaiter = visionBuilderApi.HttpApi.GetAsync(visionBuilderApi.UZLpEovFi3, url).GetAwaiter();
								_ = 0;
								num3 = (tovITLsdCZTq7WW2rH8y() ? 10 : 6);
								continue;
							case 16:
								result = awaiter.GetResult();
								goto end_IL_00e8;
							}
							goto IL_01ac;
							continue;
							end_IL_00e8:
							break;
						}
						goto end_IL_0068;
						IL_01ac:
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						num3 = 12;
						goto IL_00e8;
						end_IL_0068:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
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
		internal static bool tovITLsdCZTq7WW2rH8y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xcRg2qsdKaBNS1TUkJw9()
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
	private struct _003CDeleteAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XjORKIsdoDj3tqZFTO7J();
			int num;
			if (xncyRfsd5Bi1RQ2KT4mB())
			{
				num = 1;
				if (XjORKIsdoDj3tqZFTO7J())
				{
				}
			}
			else
			{
				num = 4;
			}
			int num2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter2 = default;
			TaskAwaiter<string> awaiter = default;
			VisionBuilderApi visionBuilderApi = default;
			HttpResponseMessage result = default;
			do
			{
				IL_0270:
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_0270;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 1;
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 2;
							if (1 == 0)
							{
								return;
							}
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 13:
								num2 = (_003C_003E1__state = -1);
								_ = 1;
								num3 = (XjORKIsdoDj3tqZFTO7J() ? 9 : 15);
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 1:
								awaiter = visionBuilderApi.UpdateHttpClientAuthorizationAsync().GetAwaiter();
								num3 = 10;
								continue;
							case 5:
								awaiter2 = visionBuilderApi.HttpApi.DeleteAsync(visionBuilderApi.UZLpEovFi3, url).GetAwaiter();
								num3 = 12;
								continue;
							case 0:
								return;
							case 7:
								return;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 6;
							case 6:
							case 15:
								awaiter.GetResult();
								goto case 5;
							default:
								num3 = 5;
								if (xncyRfsd5Bi1RQ2KT4mB())
								{
									continue;
								}
								goto case 12;
							case 12:
								if (awaiter2.IsCompleted)
								{
									break;
								}
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 0;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 13;
								if (!XjORKIsdoDj3tqZFTO7J())
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__2 = awaiter2;
								goto case 9;
							case 14:
								num2 = (_003C_003E1__state = 1);
								num3 = 4;
								continue;
							case 16:
								break;
							}
							break;
						}
						result = awaiter2.GetResult();
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
					visionBuilderApi = _003C_003E4__this;
					num = 2;
					if (XjORKIsdoDj3tqZFTO7J())
					{
					}
					goto IL_0270;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (0 == 0);
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
		internal static bool xncyRfsd5Bi1RQ2KT4mB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XjORKIsdoDj3tqZFTO7J()
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
	private struct _003CPatchAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public VisionBuilderApi _003C_003E4__this;

		public string url;

		public HttpContent content;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			HttpResponseMessage result = default;
			int num2 = default;
			TaskAwaiter<HttpResponseMessage> awaiter = default;
			TaskAwaiter<string> awaiter2 = default;
			VisionBuilderApi visionBuilderApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 7;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 2;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							_ = 0;
							num3 = (g3u35EsdPtFLjr2ZQ2dS() ? 3 : 11);
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter2 = visionBuilderApi.UpdateHttpClientAuthorizationAsync().GetAwaiter();
								num3 = 9;
								if (Ek10aQsdYYmhjkhG5uw3())
								{
								}
								continue;
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								break;
							case 11:
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								_003C_003Eu__2 = awaiter;
								goto case 11;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								continue;
							case 2:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (!Ek10aQsdYYmhjkhG5uw3())
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (g3u35EsdPtFLjr2ZQ2dS())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 9:
								if (!awaiter2.IsCompleted)
								{
									num3 = 5;
									if (g3u35EsdPtFLjr2ZQ2dS())
									{
										continue;
									}
									goto case 0;
								}
								goto case 4;
							case 0:
								awaiter = visionBuilderApi.HttpApi.PatchAsync(visionBuilderApi.UZLpEovFi3, url, content).GetAwaiter();
								num3 = 15;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter2;
								num3 = 8;
								continue;
							case 14:
								return;
							case 4:
								awaiter2.GetResult();
								num3 = 0;
								if (g3u35EsdPtFLjr2ZQ2dS())
								{
									continue;
								}
								break;
							case 16:
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
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!g3u35EsdPtFLjr2ZQ2dS()) ? 3 : 5);
					break;
				case 1:
				case 5:
					visionBuilderApi = _003C_003E4__this;
					goto case 2;
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
		internal static bool g3u35EsdPtFLjr2ZQ2dS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ek10aQsdYYmhjkhG5uw3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly HttpClient UZLpEovFi3;

	private IVisionBuilderHttpApi gnqpQXZL8d;

	private static readonly ILogger ATjpNhBEXo;

	internal IVisionBuilderHttpApi HttpApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gnqpQXZL8d;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gnqpQXZL8d = value ?? throw new ArgumentNullException((string)qiepsnjdnSxelPoPp8w(13928));
		}
	}

	public Server Server
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HttpApi.Server;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rhV4hCjigTmhGYDdQ1W(HttpApi, value);
		}
	}

	public string CurrentUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)nE7042jqYRGwr5rL0AL(HttpApi);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisionBuilderApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!gO8FiEjDeb69nQVKavL())
		{
			num = 4;
			if (gO8FiEjDeb69nQVKavL())
			{
			}
		}
		else
		{
			num = 5;
			if (gO8FiEjDeb69nQVKavL())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				eFxLiXjUBtblR2FQ5ZC();
				break;
			case 3:
				HttpApi = new VisionBuilderHttpApi();
				num = 6;
				continue;
			case 2:
				rbWkbHjTkOgAqTPPGbL(this);
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
			case 5:
				break;
			case 6:
				return;
			}
			UZLpEovFi3 = new HttpClient();
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VisionBuilderUrlBuilder k6vpc0mPJQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new VisionBuilderUrlBuilder().BaseUrl((string)MWeaq1jBoW2UN1GsyMJ(HttpApi.Server));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private VisionBuilderUrlBuilder U8Hp5RTu74()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new VisionBuilderUrlBuilder().BaseUrl(Server.Url).Api();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private HttpContent zjqpYW3Po3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new StringContent((string)dCb79GjjJs8mlvLDw4R(P_0), (Encoding)BBodIIjchJTdfbA2q1u(), (string)qiepsnjdnSxelPoPp8w(13942));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private MWYkSOYC7csyeQKIBS[] Imdp7OjWHb<MWYkSOYC7csyeQKIBS>(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WrapperObjectDiscardingConverter<MWYkSOYC7csyeQKIBS[]> wrapperObjectDiscardingConverter = new WrapperObjectDiscardingConverter<MWYkSOYC7csyeQKIBS[]>();
		return JsonConvert.DeserializeObject<MWYkSOYC7csyeQKIBS[]>(P_0, new JsonConverter[1] { wrapperObjectDiscardingConverter });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateHttpClientAuthorizationAsync_003Ed__16))]
	public Task<string> UpdateHttpClientAuthorizationAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateHttpClientAuthorizationAsync_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogoutAsync_003Ed__17))]
	public Task LogoutAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!gO8FiEjDeb69nQVKavL())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_006a;
		IL_003a:
		_003CLogoutAsync_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 2;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 5:
				goto IL_003a;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine._003C_003E4__this = this;
		num = 4;
		if (1 == 0)
		{
			goto IL_003a;
		}
		goto IL_006a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLoggedIn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IVisionBuilderHttpApi httpApi = HttpApi;
		if (httpApi == null)
		{
			return false;
		}
		return jMo1Ffj295ZSINMQuH3(httpApi);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COpenProjectAsync_003Ed__19))]
	public Task OpenProjectAsync(string projectId, string versionId = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003COpenProjectAsync_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (HvxysgjAV34DjiZ4Jp7())
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine.projectId = projectId;
				num = 6;
				if (HvxysgjAV34DjiZ4Jp7())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine.versionId = versionId;
				goto default;
			default:
				_ = 1;
				num = (gO8FiEjDeb69nQVKavL() ? 3 : 0);
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 0:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 7;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListProjectsAsync_003Ed__20))]
	public Task<Project[]> ListProjectsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CListProjectsAsync_003Ed__20 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Project[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateProjectAsync_003Ed__21))]
	public Task<string> CreateProjectAsync(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateProjectAsync_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.name = name;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteProjectAsync_003Ed__22))]
	internal Task DeleteProjectAsync(string projectId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HvxysgjAV34DjiZ4Jp7();
		int num;
		if (!gO8FiEjDeb69nQVKavL())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (!HvxysgjAV34DjiZ4Jp7())
			{
				goto IL_00d1;
			}
		}
		goto IL_0084;
		IL_0084:
		_003CDeleteProjectAsync_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				continue;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 5:
				stateMachine.projectId = projectId;
				goto case 6;
			default:
				num = 6;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 7:
				goto IL_00d1;
			}
			break;
		}
		goto IL_002a;
		IL_00d1:
		return stateMachine._003C_003Et__builder.Task;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0084;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateToolChainAsync_003Ed__23))]
	private Task pPOpmyGECc(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HvxysgjAV34DjiZ4Jp7();
		int num = (gO8FiEjDeb69nQVKavL() ? 2 : 6);
		_003CCreateToolChainAsync_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = mg0sCUjWBmpkfvNcNtS();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine.projectId = P_0;
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListToolChainsAsync_003Ed__24))]
	public Task<List<Dictionary<string, string>>> ListToolChainsAsync(string projectId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CListToolChainsAsync_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<Dictionary<string, string>>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListVersionsAsync_003Ed__25))]
	public Task<ToolchainVersion[]> ListVersionsAsync(string projectId, string toolchainId = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CListVersionsAsync_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ToolchainVersion[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.toolchainId = toolchainId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetToolChainArchiveAsync_003Ed__26))]
	private Task<byte[]> ur0pn1wOkB(string P_0, string P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetToolChainArchiveAsync_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = P_0;
		stateMachine.toolChainId = P_1;
		stateMachine.versionId = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetToolChainVersionStatusesAsync_003Ed__27))]
	public Task<ToolchainStatus[]> GetToolChainVersionStatusesAsync(string projectId, string toolChainId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetToolChainVersionStatusesAsync_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ToolchainStatus[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.toolChainId = toolChainId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public (bool, string) IsToolchainVersionValid(ToolchainStatus[] allVersionStatuses, string versionId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals3.versionId = versionId;
		ToolchainStatus toolchainStatus = ((CS_0024_003C_003E8__locals3.versionId == null) ? allVersionStatuses[0] : allVersionStatuses.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ToolchainStatus s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass28_0.rVfgPEsThg3u4bpNFBA0(_003C_003Ec__DisplayClass28_0.p1R8tesTsfCN0DxU75i3(s), CS_0024_003C_003E8__locals3.versionId);
		}));
		if (toolchainStatus == null)
		{
			return (false, Resources.ToolchainStatus_UnableToSyncVersionIsMissing);
		}
		if (toolchainStatus.Ready)
		{
			return (true, string.Empty);
		}
		if (toolchainStatus.NotReadyTools == null)
		{
			return (false, Resources.ToolchainStatus_UnableToSyncNoToolsListed);
		}
		List<string> list = toolchainStatus.NotReadyTools.Where([MethodImpl(MethodImplOptions.NoInlining)] (ToolchainStatusTool t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !_003C_003Ec.vcoGbYsTvOT8AjndZ8VN(t);
		}).Select([MethodImpl(MethodImplOptions.NoInlining)] (ToolchainStatusTool t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec.hxQGxLsTHCs2aF0WyKCM(t);
		}).ToList();
		bool flag = list.Count == 0;
		string item = (flag ? "" : string.Format(Resources.ToolchainStatus_UnableToSyncListTools, string.Join(kgbOBx7BanbFa22Hp9.ol99ukmDA(13978), list)));
		return (flag, item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadRuntimeArchiveAsync_003Ed__29))]
	public Task<byte[]> DownloadRuntimeArchiveAsync(string projectId, string versionId = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDownloadRuntimeArchiveAsync_003Ed__29 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.versionId = versionId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddSampleAsync_003Ed__30))]
	public Task<string> AddSampleAsync(string projectId, BlobResource blobResource, Bitmap image, string imageName, ImageMetadata imageMetadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddSampleAsync_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.blobResource = blobResource;
		stateMachine.image = image;
		stateMachine.imageName = imageName;
		stateMachine.imageMetadata = imageMetadata;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddSampleAsync_003Ed__31))]
	public Task<string> AddSampleAsync(string projectId, BlobResource blobResource, Stream bitmapStream, string imageName, ImageMetadata imageMetadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddSampleAsync_003Ed__31 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.blobResource = blobResource;
		stateMachine.bitmapStream = bitmapStream;
		stateMachine.imageName = imageName;
		stateMachine.imageMetadata = imageMetadata;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateBlobAsync_003Ed__32))]
	public Task<List<BlobResource>> CreateBlobAsync(string projectId, int numOfDataBlobs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateBlobAsync_003Ed__32 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<BlobResource>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.numOfDataBlobs = numOfDataBlobs;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUploadImageAsync_003Ed__33))]
	private Task VWOp94Fj3d(Stream P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CUploadImageAsync_003Ed__33 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				stateMachine.blobUrl = P_1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				continue;
			case 5:
				stateMachine.bitmapStream = P_0;
				goto case 3;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				HvxysgjAV34DjiZ4Jp7();
				num = ((!gO8FiEjDeb69nQVKavL()) ? 2 : 7);
				continue;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!gO8FiEjDeb69nQVKavL())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRegisterImageAsync_003Ed__34))]
	private Task<string> EpgpUCXFvK(string P_0, string P_1, string P_2, ImageMetadata P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRegisterImageAsync_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = P_0;
		stateMachine.imageName = P_1;
		stateMachine.blobUrl = P_2;
		stateMachine.imageMetadata = P_3;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddImageSampleAsync_003Ed__35))]
	private Task<string> imJp0lLJ7G(string P_0, string P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddImageSampleAsync_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = P_0;
		stateMachine.imageName = P_1;
		stateMachine.imageId = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListSamplesAsync_003Ed__36))]
	public Task<Sample[]> ListSamplesAsync(string projectId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CListSamplesAsync_003Ed__36 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Sample[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CListTagsAsync_003Ed__37))]
	public Task<ImageManagerTag[]> ListTagsAsync(string projectId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CListTagsAsync_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageManagerTag[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTagAsync_003Ed__38))]
	public Task<ImageManagerTag> AddTagAsync(string projectId, string name, string color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTagAsync_003Ed__38 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ImageManagerTag>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.projectId = projectId;
		stateMachine.name = name;
		stateMachine.color = color;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddImagesToTagsAsync_003Ed__39))]
	public Task AddImagesToTagsAsync(string projectId, string tagId, string[] imageIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (gO8FiEjDeb69nQVKavL() ? 5 : 4);
		_003CAddImagesToTagsAsync_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				stateMachine.imageIds = imageIds;
				num = 8;
				if (!gO8FiEjDeb69nQVKavL())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = mg0sCUjWBmpkfvNcNtS();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine.tagId = tagId;
				goto case 6;
			default:
				num = 6;
				break;
			case 2:
				stateMachine.projectId = projectId;
				num = 7;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostAsync_003Ed__40))]
	private Task<HttpResponseMessage> xcDpw0S2qt(string P_0, HttpContent P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPostAsync_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine.content = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPutAsync_003Ed__41))]
	private Task<HttpResponseMessage> tRlpRA4VqP(string P_0, HttpContent P_1, bool P_2 = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPutAsync_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine.content = P_1;
		stateMachine.useAuthorization = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string LFKpsZFGXF(string P_0, Dictionary<string, object> P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UriBuilder uriBuilder = new UriBuilder(P_0);
		NameValueCollection nameValueCollection = HttpUtility.ParseQueryString("");
		if (P_2 == null)
		{
			foreach (KeyValuePair<string, object> item in P_1)
			{
				nameValueCollection.Add(item.Key, item.Value.ToString());
			}
		}
		else
		{
			nameValueCollection.Add(P_2, JsonConvert.SerializeObject(P_1));
		}
		uriBuilder.Query = HttpUtility.UrlDecode(nameValueCollection.ToString());
		return uriBuilder.Uri.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPagedArrayAsync_003Ed__43<>))]
	internal Task<T[]> GetPagedArrayAsync<T>(string url, int resultsPerPage = 100, string pagingQueryObjectName = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPagedArrayAsync_003Ed__43<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.resultsPerPage = resultsPerPage;
		stateMachine.pagingQueryObjectName = pagingQueryObjectName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAsync_003Ed__44))]
	private Task<HttpResponseMessage> n1Np6GCYAu(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAsync_003Ed__44 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteAsync_003Ed__45))]
	private Task<HttpResponseMessage> dxqpHhrLUB(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteAsync_003Ed__45 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPatchAsync_003Ed__46))]
	private Task<HttpResponseMessage> GKupKwf9SJ(string P_0, HttpContent P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPatchAsync_003Ed__46 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = P_0;
		stateMachine.content = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisionBuilderApi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eFxLiXjUBtblR2FQ5ZC();
		ATjpNhBEXo = LogManager.GetLogger<VisionBuilderApi>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eFxLiXjUBtblR2FQ5ZC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rbWkbHjTkOgAqTPPGbL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HvxysgjAV34DjiZ4Jp7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gO8FiEjDeb69nQVKavL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qiepsnjdnSxelPoPp8w(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rhV4hCjigTmhGYDdQ1W(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IVisionBuilderHttpApi)P_0).Server = (Server)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nE7042jqYRGwr5rL0AL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IVisionBuilderHttpApi)P_0).GetUserName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MWeaq1jBoW2UN1GsyMJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Server)P_0).RedirectUri;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dCb79GjjJs8mlvLDw4R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonConvert.SerializeObject(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BBodIIjchJTdfbA2q1u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jMo1Ffj295ZSINMQuH3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IVisionBuilderHttpApi)P_0).IsLoggedIn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mg0sCUjWBmpkfvNcNtS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
