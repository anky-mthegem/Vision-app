using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Properties;
using IdentityModel.OidcClient.Browser;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class Auth0ClientBrowser : IBrowser
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct nV5QgByjk2IMGdHQ6P : IAsyncStateMachine
		{
			public int t1Jn7Ga3fx;

			public AsyncVoidMethodBuilder tI7nm3OpZ6;

			public _003C_003Ec__DisplayClass9_0 rE7nnxNW0v;

			private TaskAwaiter XZln91sRAR;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 2;
				if (OfjxyPsu3XVtHkcrILt4())
				{
					goto IL_001e;
				}
				goto IL_0202;
				IL_001e:
				tI7nm3OpZ6.SetResult();
				num = 6;
				if (OfjxyPsu3XVtHkcrILt4())
				{
				}
				goto IL_0202;
				IL_0202:
				int num2 = default;
				_003C_003Ec__DisplayClass9_0 obj = default;
				while (true)
				{
					switch (num)
					{
					case 2:
						num2 = t1Jn7Ga3fx;
						_ = 1;
						num = ((!OfjxyPsu3XVtHkcrILt4()) ? 5 : 0);
						continue;
					case 1:
					case 5:
						obj = rE7nnxNW0v;
						num = 4;
						continue;
					case 4:
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = iGyy11suO6wcUkeCI3nM(obj._003C_003E4__this.RaVplQNbPV(obj.webView2));
								num3 = 4;
								goto IL_00d8;
							}
							awaiter = XZln91sRAR;
							goto IL_0169;
							IL_0169:
							XZln91sRAR = default;
							num3 = 9;
							if (false)
							{
								return;
							}
							goto IL_00d8;
							IL_00d8:
							while (true)
							{
								switch (num3)
								{
								case 4:
									if (!awaiter.IsCompleted)
									{
										Gdmk11sur4STl0whLdba();
										num3 = (OfjxyPsu3XVtHkcrILt4() ? 8 : 3);
										continue;
									}
									goto IL_0143;
								case 6:
									tI7nm3OpZ6.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									((CoreWebView2Environment)USFdvQsuQ1mUjuFjmqZV(taqGXQsuMtSttVSaohbY(obj.webView2))).BrowserProcessExited += obj.browserExitedHandler;
									num3 = 10;
									continue;
								case 9:
									num2 = (t1Jn7Ga3fx = -1);
									goto IL_0143;
								case 1:
								case 3:
									num2 = (t1Jn7Ga3fx = 0);
									num3 = 7;
									continue;
								case 5:
								case 8:
									break;
								case 0:
									return;
								case 7:
									XZln91sRAR = awaiter;
									num3 = 6;
									continue;
								case 10:
									{
										n1rIPqsueL3J1rqZcw1Y(taqGXQsuMtSttVSaohbY(obj.webView2), Lyg6jCsulLjfWh4R38cO(obj.options));
										goto end_IL_00d8;
									}
									IL_0143:
									awaiter.GetResult();
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								}
								goto IL_0169;
								continue;
								end_IL_00d8:
								break;
							}
						}
						catch (Exception exception)
						{
							t1Jn7Ga3fx = -2;
							tI7nm3OpZ6.SetException(exception);
							return;
						}
						t1Jn7Ga3fx = -2;
						break;
					case 6:
						return;
					}
					break;
				}
				goto IL_001e;
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				tI7nm3OpZ6.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter iGyy11suO6wcUkeCI3nM(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object taqGXQsuMtSttVSaohbY(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((WebView2)P_0).CoreWebView2;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object USFdvQsuQ1mUjuFjmqZV(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((CoreWebView2)P_0).Environment;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object Lyg6jCsulLjfWh4R38cO(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((BrowserOptions)P_0).StartUrl;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void n1rIPqsueL3J1rqZcw1Y(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				((CoreWebView2)P_0).Navigate((string)P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool Gdmk11sur4STl0whLdba()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool OfjxyPsu3XVtHkcrILt4()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public BrowserOptions options;

		public TaskCompletionSource<BrowserResult> authorizationCompletionSource;

		public Window hostWindow;

		public WebView2 webView2;

		public TaskCompletionSource<bool> browserExitedCompletionSource;

		public Auth0ClientBrowser _003C_003E4__this;

		public EventHandler<CoreWebView2BrowserProcessExitedEventArgs> browserExitedHandler;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass9_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			dUhnBNsDdZfXAuOuVTFm(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CIdentityModel_002EOidcClient_002EBrowser_002EIBrowser_002EInvokeAsync_003Eb__0(object sender, CoreWebView2NavigationStartingEventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					hostWindow.Close();
					num = 5;
					break;
				case 4:
				{
					if (!((string)aBxlajsDikvgkx3CnFII(e)).StartsWith((string)rDDbsIsDq6o4frFwtBxS(options)))
					{
						E4bfVdsDU4m5FYxWtZcR();
						if (!vfReHBsDTE444P8671Tl())
						{
							num = 0;
							if (vfReHBsDTE444P8671Tl())
							{
							}
						}
						else
						{
							num = 3;
						}
						break;
					}
					TaskCompletionSource<BrowserResult> taskCompletionSource = authorizationCompletionSource;
					BrowserResult browserResult = new BrowserResult();
					kWEpGHsDBMPeYQQvZkU5(browserResult, BrowserResultType.Success);
					browserResult.Response = e.Uri.ToString();
					taskCompletionSource.SetResult(browserResult);
					goto default;
				}
				case 0:
				case 1:
					return;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CIdentityModel_002EOidcClient_002EBrowser_002EIBrowser_002EInvokeAsync_003Eb__1(object sender, CancelEventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E4bfVdsDU4m5FYxWtZcR();
			int num;
			if (!vfReHBsDTE444P8671Tl())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0066;
			IL_002a:
			gCoKhhsDjahXtHnRnfae(webView2);
			num = 1;
			goto IL_0066;
			IL_0066:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
					if (!KDNSLUsDcdCG0qauVeUS(authorizationCompletionSource.Task))
					{
						goto IL_0094;
					}
					return;
				default:
					return;
				case 3:
					return;
				case 5:
					return;
				}
				break;
				IL_0094:
				authorizationCompletionSource.SetResult(new BrowserResult
				{
					ResultType = BrowserResultType.UserCancel
				});
				num = 5;
			}
			goto IL_002a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CIdentityModel_002EOidcClient_002EBrowser_002EIBrowser_002EInvokeAsync_003Eb__2(object sender, CoreWebView2BrowserProcessExitedEventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			browserExitedCompletionSource.SetResult(result: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(nV5QgByjk2IMGdHQ6P))]
		internal void _003CIdentityModel_002EOidcClient_002EBrowser_002EIBrowser_002EInvokeAsync_003Eb__3(object sender, EventArgs e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			nV5QgByjk2IMGdHQ6P stateMachine = default;
			do
			{
				IL_006c:
				switch (num)
				{
				case 3:
					stateMachine.tI7nm3OpZ6 = yD4UsxsD2W95D7Aq9STo();
					_ = 0;
					num = ((!E4bfVdsDU4m5FYxWtZcR()) ? 5 : 0);
					goto IL_006c;
				case 0:
				case 1:
					stateMachine.rE7nnxNW0v = this;
					goto case 2;
				case 2:
				case 5:
					stateMachine.t1Jn7Ga3fx = -1;
					break;
				default:
					num = 4;
					goto IL_006c;
				case 4:
					break;
				case 6:
					return;
				}
				stateMachine.tI7nm3OpZ6.Start(ref stateMachine);
				num = 6;
			}
			while (!vfReHBsDTE444P8671Tl());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dUhnBNsDdZfXAuOuVTFm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E4bfVdsDU4m5FYxWtZcR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vfReHBsDTE444P8671Tl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aBxlajsDikvgkx3CnFII(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CoreWebView2NavigationStartingEventArgs)P_0).Uri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rDDbsIsDq6o4frFwtBxS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BrowserOptions)P_0).EndUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kWEpGHsDBMPeYQQvZkU5(object P_0, BrowserResultType P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BrowserResult)P_0).ResultType = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gCoKhhsDjahXtHnRnfae(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((HwndHost)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KDNSLUsDcdCG0qauVeUS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).IsCompleted;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncVoidMethodBuilder yD4UsxsD2W95D7Aq9STo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncVoidMethodBuilder.Create();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CIdentityModel_002DOidcClient_002DBrowser_002DIBrowser_002DInvokeAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<BrowserResult> _003C_003Et__builder;

		public BrowserOptions options;

		public Auth0ClientBrowser _003C_003E4__this;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		private BrowserResult _003Cresult_003E5__2;

		private TimeSpan _003CbrowserExitedTimeout_003E5__3;

		private Task _003CbrowserExitedTimeoutTask_003E5__4;

		private TaskAwaiter<BrowserResult> _003C_003Eu__1;

		private TaskAwaiter<Task> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rsHmDosD7tVrS20H43Nb();
			int num;
			if (LP17axsDWbsJjBIAoWU1())
			{
				num = 5;
			}
			else
			{
				num = 6;
				if (!LP17axsDWbsJjBIAoWU1())
				{
					goto IL_05ca;
				}
			}
			goto IL_0063;
			IL_0063:
			Auth0ClientBrowser auth0ClientBrowser = default;
			TaskAwaiter<Task> awaiter = default;
			TaskAwaiter<BrowserResult> awaiter2 = default;
			int num2 = default;
			BrowserResult result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 2:
					auth0ClientBrowser = _003C_003E4__this;
					num = 8;
					continue;
				case 3:
				case 6:
					_003C_003E8__1 = null;
					goto case 7;
				default:
					num = 7;
					if (!rsHmDosD7tVrS20H43Nb())
					{
						continue;
					}
					goto case 7;
				case 7:
					_003Cresult_003E5__2 = null;
					num = 4;
					continue;
				case 4:
					_003CbrowserExitedTimeoutTask_003E5__4 = null;
					num = 1;
					continue;
				case 8:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 22;
								if (!LP17axsDWbsJjBIAoWU1())
								{
									goto IL_00df;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 16;
								if (!LP17axsDWbsJjBIAoWU1())
								{
									goto IL_0537;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 18;
						}
						goto IL_02cf;
						IL_00df:
						_003C_003E8__1.authorizationCompletionSource = new TaskCompletionSource<BrowserResult>();
						num3 = 26;
						goto IL_02cf;
						IL_02cf:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 14:
							{
								BrowserResult result = awaiter2.GetResult();
								_003Cresult_003E5__2 = result;
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 21;
							}
							case 21:
								_003C_003Eu__2 = awaiter;
								num3 = 5;
								continue;
							case 2:
								awaiter.GetResult();
								num3 = 1;
								if (rsHmDosD7tVrS20H43Nb())
								{
								}
								continue;
							case 24:
								_003CbrowserExitedTimeoutTask_003E5__4 = (Task)d892btsDxZCbo2fg3Ghm(_003CbrowserExitedTimeout_003E5__3);
								num3 = 17;
								continue;
							case 12:
							{
								_003C_003Ec__DisplayClass9_0 obj = _003C_003E8__1;
								Window window = new Window();
								LpXIIksDtbByhyAe4rGL(window, kgbOBx7BanbFa22Hp9.ol99ukmDA(53344));
								window.Title = Resources.AuthenticatingTitle;
								IRZiTosDCNWWuu9idpvr(window, auth0ClientBrowser.HostWindowSize.Width);
								qZJDDpsDKLBVC08kf0xK(window, auth0ClientBrowser.HostWindowSize.Height);
								LVuWJGsD5OjnGaUvpg4T(window, _003C_003E8__1.webView2);
								obj.hostWindow = window;
								_003C_003E8__1.webView2.NavigationStarting += [MethodImpl(MethodImplOptions.NoInlining)] (object sender, CoreWebView2NavigationStartingEventArgs e) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									int num4 = 4;
									while (true)
									{
										switch (num4)
										{
										default:
											_003C_003E8__1.hostWindow.Close();
											num4 = 5;
											break;
										case 4:
										{
											if (!((string)_003C_003Ec__DisplayClass9_0.aBxlajsDikvgkx3CnFII(e)).StartsWith((string)_003C_003Ec__DisplayClass9_0.rDDbsIsDq6o4frFwtBxS(_003C_003E8__1.options)))
											{
												_003C_003Ec__DisplayClass9_0.E4bfVdsDU4m5FYxWtZcR();
												if (!_003C_003Ec__DisplayClass9_0.vfReHBsDTE444P8671Tl())
												{
													num4 = 0;
													if (_003C_003Ec__DisplayClass9_0.vfReHBsDTE444P8671Tl())
													{
													}
												}
												else
												{
													num4 = 3;
												}
												break;
											}
											TaskCompletionSource<BrowserResult> taskCompletionSource = _003C_003E8__1.authorizationCompletionSource;
											BrowserResult browserResult = new BrowserResult();
											_003C_003Ec__DisplayClass9_0.kWEpGHsDBMPeYQQvZkU5(browserResult, BrowserResultType.Success);
											browserResult.Response = e.Uri.ToString();
											taskCompletionSource.SetResult(browserResult);
											goto default;
										}
										case 0:
										case 1:
											return;
										case 5:
											return;
										}
									}
								};
								GZVA4gsDoyxfx5GeORG5(_003C_003E8__1.hostWindow, (CancelEventHandler)([MethodImpl(MethodImplOptions.NoInlining)] (object sender, CancelEventArgs e) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									_003C_003Ec__DisplayClass9_0.E4bfVdsDU4m5FYxWtZcR();
									int num4;
									if (!_003C_003Ec__DisplayClass9_0.vfReHBsDTE444P8671Tl())
									{
										num4 = 4;
										if (false)
										{
											goto IL_002a;
										}
									}
									else
									{
										num4 = 3;
									}
									goto IL_0066;
									IL_002a:
									_003C_003Ec__DisplayClass9_0.gCoKhhsDjahXtHnRnfae(_003C_003E8__1.webView2);
									num4 = 1;
									goto IL_0066;
									IL_0066:
									while (true)
									{
										switch (num4)
										{
										case 0:
										case 4:
											break;
										case 1:
											if (!_003C_003Ec__DisplayClass9_0.KDNSLUsDcdCG0qauVeUS(_003C_003E8__1.authorizationCompletionSource.Task))
											{
												goto IL_0094;
											}
											return;
										default:
											return;
										case 3:
											return;
										case 5:
											return;
										}
										break;
										IL_0094:
										_003C_003E8__1.authorizationCompletionSource.SetResult(new BrowserResult
										{
											ResultType = BrowserResultType.UserCancel
										});
										num4 = 5;
									}
									goto IL_002a;
								}));
								num3 = 25;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							}
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								continue;
							case 20:
								DiPuxfsD3nSyBGtFMo9d(apCpg5b7ST, LogLevel.Info, string.Format((string)RQ1UH2sDr9lMy7pasX6q(53382), _003CbrowserExitedTimeout_003E5__3.TotalSeconds));
								num3 = 28;
								continue;
							case 1:
								if (z6XgAksD1fLtKMgOgaet(_003CbrowserExitedTimeoutTask_003E5__4))
								{
									num3 = 6;
									continue;
								}
								goto case 28;
							case 22:
								_003C_003E8__1 = new _003C_003Ec__DisplayClass9_0();
								num3 = 9;
								continue;
							case 3:
							case 10:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto case 14;
							default:
								num3 = 14;
								continue;
							case 0:
								_003C_003E8__1.webView2 = new WebView2();
								num3 = 12;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 11;
								continue;
							case 18:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 19:
								if (awaiter.IsCompleted)
								{
									goto case 2;
								}
								num2 = (_003C_003E1__state = 1);
								num3 = 21;
								if (LP17axsDWbsJjBIAoWU1())
								{
									continue;
								}
								goto case 26;
							case 26:
								_003C_003E8__1.browserExitedCompletionSource = new TaskCompletionSource<bool>();
								num3 = 0;
								continue;
							case 7:
								_003CbrowserExitedTimeout_003E5__3 = XfO8kpsDNo9hL88VrlDw(2.0);
								num3 = 24;
								if (0 == 0)
								{
									continue;
								}
								goto case 27;
							case 27:
								if (awaiter2.IsCompleted)
								{
									goto case 14;
								}
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 25:
								_003C_003E8__1.browserExitedHandler = [MethodImpl(MethodImplOptions.NoInlining)] (object sender, CoreWebView2BrowserProcessExitedEventArgs e) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									_003C_003E8__1.browserExitedCompletionSource.SetResult(result: true);
								};
								num3 = 23;
								if (LP17axsDWbsJjBIAoWU1())
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!z6XgAksD1fLtKMgOgaet(_003C_003E8__1.browserExitedCompletionSource.Task))
								{
									num3 = 20;
									continue;
								}
								goto case 28;
							case 23:
								NWJ6CksDPDWpETw2k1KL(_003C_003E8__1.hostWindow, (EventHandler)([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass9_0.nV5QgByjk2IMGdHQ6P))] (object sender, EventArgs e) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									int num4 = 3;
									_003C_003Ec__DisplayClass9_0.nV5QgByjk2IMGdHQ6P stateMachine = default;
									do
									{
										IL_006c:
										switch (num4)
										{
										case 3:
											stateMachine.tI7nm3OpZ6 = _003C_003Ec__DisplayClass9_0.yD4UsxsD2W95D7Aq9STo();
											_ = 0;
											num4 = ((!_003C_003Ec__DisplayClass9_0.E4bfVdsDU4m5FYxWtZcR()) ? 5 : 0);
											goto IL_006c;
										case 0:
										case 1:
											stateMachine.rE7nnxNW0v = _003C_003E8__1;
											goto case 2;
										case 2:
										case 5:
											stateMachine.t1Jn7Ga3fx = -1;
											break;
										default:
											num4 = 4;
											goto IL_006c;
										case 4:
											break;
										case 6:
											return;
										}
										stateMachine.tI7nm3OpZ6.Start(ref stateMachine);
										num4 = 6;
									}
									while (!_003C_003Ec__DisplayClass9_0.vfReHBsDTE444P8671Tl());
								}));
								LP17axsDWbsJjBIAoWU1();
								if (rsHmDosD7tVrS20H43Nb())
								{
									num3 = 3;
									continue;
								}
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
							case 13:
								HbhBG2sDYQUJJ5LqHIpB(_003C_003E8__1.hostWindow);
								awaiter2 = _003C_003E8__1.authorizationCompletionSource.Task.GetAwaiter();
								num3 = 27;
								continue;
							case 9:
								_003C_003E8__1.options = options;
								_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
								num3 = 4;
								if (!rsHmDosD7tVrS20H43Nb())
								{
									continue;
								}
								return;
							case 11:
								return;
							case 17:
								goto IL_0537;
							case 28:
								result2 = _003Cresult_003E5__2;
								goto end_IL_00c2;
							}
							break;
						}
						goto IL_00df;
						IL_0537:
						awaiter = Task.WhenAny(_003C_003E8__1.browserExitedCompletionSource.Task, _003CbrowserExitedTimeoutTask_003E5__4).GetAwaiter();
						num3 = 19;
						goto IL_02cf;
						end_IL_00c2:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003Cresult_003E5__2 = null;
						_003CbrowserExitedTimeoutTask_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				case 1:
					break;
				case 9:
					return;
				}
				break;
			}
			goto IL_05ca;
			IL_05ca:
			_003C_003Et__builder.SetResult(result2);
			num = 9;
			goto IL_0063;
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
		internal static void LpXIIksDtbByhyAe4rGL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FrameworkElement)P_0).Name = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IRZiTosDCNWWuu9idpvr(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FrameworkElement)P_0).Width = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qZJDDpsDKLBVC08kf0xK(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FrameworkElement)P_0).Height = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LVuWJGsD5OjnGaUvpg4T(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ContentControl)P_0).Content = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GZVA4gsDoyxfx5GeORG5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Window)P_0).Closing += (CancelEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NWJ6CksDPDWpETw2k1KL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Window)P_0).ContentRendered += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HbhBG2sDYQUJJ5LqHIpB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Window)P_0).Show();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan XfO8kpsDNo9hL88VrlDw(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TimeSpan.FromSeconds(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d892btsDxZCbo2fg3Ghm(TimeSpan P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.Delay(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z6XgAksD1fLtKMgOgaet(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).IsCompleted;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RQ1UH2sDr9lMy7pasX6q(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DiPuxfsD3nSyBGtFMo9d(object P_0, LogLevel P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Log(P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LP17axsDWbsJjBIAoWU1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rsHmDosD7tVrS20H43Nb()
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
	private struct _003CEnsureCoreWebView2Async_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WebView2 webView2;

		public Auth0ClientBrowser _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_026a;
			IL_001a:
			int num2 = _003C_003E1__state;
			YfHqi0sDMpgTrylHf78j();
			if (uFp8PisDOXIGxZjOp4Ql())
			{
				num = 0;
				if (YfHqi0sDMpgTrylHf78j())
				{
				}
			}
			else
			{
				num = 3;
			}
			goto IL_026a;
			IL_026a:
			Auth0ClientBrowser auth0ClientBrowser = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = nGNC38sDQxYxpmOy5UOw(webView2.EnsureCoreWebView2Async(auth0ClientBrowser.Environment));
								num3 = 0;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 4:
									return;
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									continue;
								case 0:
									if (awaiter.IsCompleted)
									{
										break;
									}
									num3 = 5;
									if (!YfHqi0sDMpgTrylHf78j())
									{
										continue;
									}
									goto case 6;
								case 6:
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									goto default;
								default:
									uFp8PisDOXIGxZjOp4Ql();
									num3 = ((!YfHqi0sDMpgTrylHf78j()) ? 1 : 8);
									continue;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 7:
									_003C_003Eu__1 = default;
									goto case 6;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (Exception ex)
						{
							xY48dPsDeB314J6UMNx0(apCpg5b7ST, LogLevel.Error, knhWalsDlaNXZPqlQoTR(53500), ex);
							if (auth0ClientBrowser.Environment == null)
							{
								OxwSZrsDuduS9eDdZ0HN(apCpg5b7ST, LogLevel.Info, knhWalsDlaNXZPqlQoTR(53568));
							}
							else
							{
								apCpg5b7ST.Log(LogLevel.Info, (string)g6CGl5sDIWosOmMhxx1q(kgbOBx7BanbFa22Hp9.ol99ukmDA(53626), auth0ClientBrowser.Environment.UserDataFolder));
								OxwSZrsDuduS9eDdZ0HN(apCpg5b7ST, LogLevel.Info, g6CGl5sDIWosOmMhxx1q(knhWalsDlaNXZPqlQoTR(53680), n7kmIHsDRZ7f71qggMJF(auth0ClientBrowser.Environment)));
								OxwSZrsDuduS9eDdZ0HN(apCpg5b7ST, LogLevel.Info, g6CGl5sDIWosOmMhxx1q(knhWalsDlaNXZPqlQoTR(53746), SYLMTnsDaPyNp0rsAh3k(auth0ClientBrowser.Environment)));
							}
							throw;
						}
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
				case 0:
				case 1:
					auth0ClientBrowser = _003C_003E4__this;
					goto case 2;
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
		internal static TaskAwaiter nGNC38sDQxYxpmOy5UOw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object knhWalsDlaNXZPqlQoTR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xY48dPsDeB314J6UMNx0(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OxwSZrsDuduS9eDdZ0HN(object P_0, LogLevel P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Log(P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g6CGl5sDIWosOmMhxx1q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n7kmIHsDRZ7f71qggMJF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CoreWebView2Environment)P_0).BrowserVersionString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SYLMTnsDaPyNp0rsAh3k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CoreWebView2Environment)P_0).FailureReportFolderPath;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uFp8PisDOXIGxZjOp4Ql()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YfHqi0sDMpgTrylHf78j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger apCpg5b7ST;

	[CompilerGenerated]
	private readonly CoreWebView2Environment iklpquSOSI;

	[CompilerGenerated]
	private Size YYbpTrc3iP;

	public CoreWebView2Environment Environment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iklpquSOSI;
		}
	}

	public Size HostWindowSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YYbpTrc3iP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YYbpTrc3iP = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Auth0ClientBrowser(CoreWebView2Environment web2Environment)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_0082:
			switch (num)
			{
			case 1:
			case 5:
				YYbpTrc3iP = new Size(1024.0, 768.0);
				goto case 2;
			case 0:
				do
				{
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					BRwVDbBMhFe8g1aIQy0();
					if (YPZsJPBQiLmP1Sw79Rs())
					{
						num = 3;
						continue;
					}
					num = 5;
					break;
				}
				while (!BRwVDbBMhFe8g1aIQy0());
				goto IL_0082;
			case 2:
			case 3:
				tAvxYfBl0VV8iab8jJw(this);
				break;
			default:
				num = 4;
				goto IL_0082;
			case 4:
				break;
			case 6:
				return;
			}
			iklpquSOSI = web2Environment;
			num = 6;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CIdentityModel_002DOidcClient_002DBrowser_002DIBrowser_002DInvokeAsync_003Ed__9))]
	Task<BrowserResult> IBrowser.InvokeAsync(BrowserOptions options, CancellationToken cancellationToken)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CIdentityModel_002DOidcClient_002DBrowser_002DIBrowser_002DInvokeAsync_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<BrowserResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.options = options;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnsureCoreWebView2Async_003Ed__10))]
	private Task RaVplQNbPV(WebView2 P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (YPZsJPBQiLmP1Sw79Rs() ? 2 : 5);
		_003CEnsureCoreWebView2Async_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = nss7DEBebuWRfITQmy8();
				num = 6;
				break;
			case 3:
				stateMachine.webView2 = P_0;
				goto case 1;
			default:
				num = 1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Auth0ClientBrowser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		apCpg5b7ST = LogManager.GetLogger<Auth0ClientBrowser>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tAvxYfBl0VV8iab8jJw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BRwVDbBMhFe8g1aIQy0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YPZsJPBQiLmP1Sw79Rs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nss7DEBebuWRfITQmy8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
