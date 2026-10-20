using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.Cnx.Diagnostics;
using Cognex.Common;
using Cognex.Diagnostics.Logging;
using Cognex.Explorer.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Common;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using Cognex.InSight.Undo;
using Cognex.InSight.UserAccess;
using Cognex.InSight.UserAccess.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsInSight : IFilmstripPlayer, IFilmstripRecorder, IDisposable
{
	private delegate void j3EucQmZOJ747RYNKn(object address, int port, string username, string password, bool forceConnect, CvsInSightLanguage language, Thread guiThread);

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetDefaultGraphicAsync_003Ed__131 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogEditInfo> _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public CvsCellLocation location;

		private TaskAwaiter<CvsCogEditInfo> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			z4f77ZsswPSfwGbZCP0g();
			int num = ((!Jrn1V5swzmUhYmOt4h3Q()) ? 2 : 3);
			int num2 = default;
			CvsInSight cvsInSight = default;
			CvsCogEditInfo result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					try
					{
						try
						{
							TaskAwaiter<CvsCogEditInfo> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = cvsInSight.CogSocket.Sheet.GetDefaultGraphicAsync(location).GetAwaiter();
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
								if (1 == 0)
								{
									goto IL_0140;
								}
							}
							goto IL_00de;
							IL_0158:
							result = awaiter.GetResult();
							goto end_IL_0042;
							IL_0140:
							if (!awaiter.IsCompleted)
							{
								num3 = 1;
								if (0 == 0)
								{
									goto IL_00de;
								}
							}
							goto IL_0158;
							IL_00de:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 7:
									_003C_003Eu__1 = default;
									goto case 2;
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								case 0:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 2:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 8:
									return;
								case 5:
									goto end_IL_00de;
								case 9:
									goto IL_0158;
								}
								_003C_003Eu__1 = awaiter;
								Jrn1V5swzmUhYmOt4h3Q();
								num3 = (z4f77ZsswPSfwGbZCP0g() ? 2 : 0);
								continue;
								end_IL_00de:
								break;
							}
							goto IL_0140;
							end_IL_0042:;
						}
						catch (Exception)
						{
							result = null;
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
					num = 4;
					if (!z4f77ZsswPSfwGbZCP0g())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					cvsInSight = _003C_003E4__this;
					num = 5;
					if (z4f77ZsswPSfwGbZCP0g())
					{
					}
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
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
		internal static bool Jrn1V5swzmUhYmOt4h3Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z4f77ZsswPSfwGbZCP0g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct tu3auXkwxM1eergOw7 : IAsyncStateMachine
		{
			public int oxyn4MaEy2;

			public AsyncTaskMethodBuilder FupnlKPPT4;

			public _003C_003Ec__DisplayClass136_0 eV2ngLWUeb;

			private TaskAwaiter tqlnq8ICAi;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				AFSJZssu9pSM99wwplsX();
				int num = (y5eW2BsuSeVL7dSVZCAh() ? 5 : 2);
				int num2 = default;
				_003C_003Ec__DisplayClass136_0 obj = default;
				while (true)
				{
					switch (num)
					{
					case 3:
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = bmgQACsuvCD9EeELAVjK(obj._003C_003E4__this.V1YxqC4Q8n(obj.rootCogSocketUri, obj.httpUri, obj.cameraPath, obj.sheetPath, obj.username, obj.password, t2LT4asuEGBI0ZlTIFVP(), _0020: false, obj.acqFactory));
								y5eW2BsuSeVL7dSVZCAh();
								num3 = ((!AFSJZssu9pSM99wwplsX()) ? 2 : 6);
							}
							else
							{
								awaiter = tqlnq8ICAi;
								num3 = 1;
								if (y5eW2BsuSeVL7dSVZCAh())
								{
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									break;
								case 1:
									tqlnq8ICAi = default;
									num3 = 7;
									continue;
								case 3:
									FupnlKPPT4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									return;
								case 2:
									return;
								case 8:
									num2 = (oxyn4MaEy2 = 0);
									num3 = 5;
									continue;
								case 7:
									num2 = (oxyn4MaEy2 = -1);
									num3 = 9;
									continue;
								case 5:
									tqlnq8ICAi = awaiter;
									num3 = 3;
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
							oxyn4MaEy2 = -2;
							FupnlKPPT4.SetException(exception);
							return;
						}
						oxyn4MaEy2 = -2;
						break;
					default:
						num = 4;
						continue;
					case 1:
					case 5:
						obj = eV2ngLWUeb;
						num = 3;
						continue;
					case 4:
						break;
					case 0:
					case 2:
						num2 = oxyn4MaEy2;
						goto case 1;
					case 6:
						return;
					}
					FupnlKPPT4.SetResult();
					num = 6;
				}
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
				FupnlKPPT4.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static CvsInSightLanguage t2LT4asuEGBI0ZlTIFVP()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CvsHelper.GetLanguage();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter bmgQACsuvCD9EeELAVjK(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AFSJZssu9pSM99wwplsX()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool y5eW2BsuSeVL7dSVZCAh()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public CvsInSight _003C_003E4__this;

		public Uri rootCogSocketUri;

		public Uri httpUri;

		public string cameraPath;

		public string sheetPath;

		public string username;

		public string password;

		public ICogSocketAcqFactory acqFactory;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass136_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			poTdcCssLycV8UsRtZGS(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(tu3auXkwxM1eergOw7))]
		internal Task _003CConnect_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!C9pIQcsssp0IYR0LdBod())
			{
				goto IL_001e;
			}
			goto IL_0090;
			IL_0090:
			tu3auXkwxM1eergOw7 stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 3:
					goto IL_003c;
				case 5:
					goto IL_0054;
				case 2:
				case 4:
					goto IL_0076;
				default:
					num = 0;
					if (PIdPv4sshCTghpo7cETk())
					{
					}
					continue;
				case 6:
					return stateMachine.FupnlKPPT4.Task;
				}
				break;
				IL_0054:
				stateMachine.FupnlKPPT4 = mxtJCZss95Xjtn0hZdEl();
				_ = 0;
				num = (C9pIQcsssp0IYR0LdBod() ? 3 : 4);
			}
			goto IL_001e;
			IL_0076:
			stateMachine.oxyn4MaEy2 = -1;
			goto IL_001e;
			IL_003c:
			stateMachine.eV2ngLWUeb = this;
			goto IL_0076;
			IL_001e:
			stateMachine.FupnlKPPT4.Start(ref stateMachine);
			num = 6;
			if (!C9pIQcsssp0IYR0LdBod())
			{
				goto IL_003c;
			}
			goto IL_0090;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void poTdcCssLycV8UsRtZGS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C9pIQcsssp0IYR0LdBod()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PIdPv4sshCTghpo7cETk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncTaskMethodBuilder mxtJCZss95Xjtn0hZdEl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncTaskMethodBuilder.Create();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct vfHQLfZxslOhenuAd3 : IAsyncStateMachine
		{
			public int X3LnTXynDq;

			public AsyncTaskMethodBuilder iEnnBPhr4C;

			public _003C_003Ec__DisplayClass136_1 jw1nJvEjBW;

			private _003C_003Ec__DisplayClass136_2 kc0nMbL4GS;

			private TaskAwaiter ShjnovsPof;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 0;
				int num = ((!YU8RPTsuHnLZ8RxZOfv0()) ? 6 : 2);
				_003C_003Ec__DisplayClass136_1 obj = default;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 1:
					case 6:
						obj = jw1nJvEjBW;
						num = 4;
						break;
					case 3:
						kc0nMbL4GS = null;
						num = 5;
						break;
					case 0:
					case 2:
						num2 = X3LnTXynDq;
						goto case 1;
					case 5:
						iEnnBPhr4C.SetResult();
						num = 7;
						break;
					case 4:
						try
						{
							if (num2 != 0)
							{
								kc0nMbL4GS = new _003C_003Ec__DisplayClass136_2();
								kc0nMbL4GS.CS_0024_003C_003E8__locals2 = obj;
								OAYjUDsuA03mEgApU4o1(obj.guiThread);
								kc0nMbL4GS.asyncException = null;
							}
							try
							{
								TaskAwaiter awaiter;
								if (num2 != 0)
								{
									awaiter = D9GhS7suU1AAEkD6EnHf(obj.CS_0024_003C_003E8__locals1._003C_003E4__this.V1YxqC4Q8n(obj.CS_0024_003C_003E8__locals1.rootCogSocketUri, obj.CS_0024_003C_003E8__locals1.httpUri, obj.CS_0024_003C_003E8__locals1.cameraPath, obj.CS_0024_003C_003E8__locals1.sheetPath, obj.CS_0024_003C_003E8__locals1.username, obj.CS_0024_003C_003E8__locals1.password, HX58rlsuDPghb1BIwMQo(), _0020: true, obj.CS_0024_003C_003E8__locals1.acqFactory));
									if (!awaiter.IsCompleted)
									{
										num2 = (X3LnTXynDq = 0);
										ShjnovsPof = awaiter;
										iEnnBPhr4C.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
								}
								else
								{
									awaiter = ShjnovsPof;
									ShjnovsPof = default;
									num2 = (X3LnTXynDq = -1);
								}
								awaiter.GetResult();
							}
							catch (Exception asyncException)
							{
								kc0nMbL4GS.asyncException = asyncException;
							}
							finally
							{
								if (num2 < 0)
								{
									try
									{
										obj.CS_0024_003C_003E8__locals1._003C_003E4__this.rcTFlgyD7e.Send([MethodImpl(MethodImplOptions.NoInlining)] (object o) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											kc0nMbL4GS.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.HandleConnectCompleted(kc0nMbL4GS.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, new CvsConnectCompletedEventArgs(kc0nMbL4GS.asyncException));
										}, null);
									}
									catch (Exception exception)
									{
										obj.CS_0024_003C_003E8__locals1._003C_003E4__this.M9sxU718oA.DebugException((string)u4oMpGsuT4OScmKT0mmS(56984), exception);
									}
								}
							}
						}
						catch (Exception exception2)
						{
							X3LnTXynDq = -2;
							kc0nMbL4GS = null;
							iEnnBPhr4C.SetException(exception2);
							return;
						}
						X3LnTXynDq = -2;
						goto case 3;
					default:
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				iEnnBPhr4C.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void OAYjUDsuA03mEgApU4o1(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				CvsHelper.SetCurrentCulture((Thread)P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static CvsInSightLanguage HX58rlsuDPghb1BIwMQo()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CvsHelper.GetLanguage();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter D9GhS7suU1AAEkD6EnHf(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object u4oMpGsuT4OScmKT0mmS(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool YU8RPTsuHnLZ8RxZOfv0()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool G5nLMVsuVWpF9WbGLBIT()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public Thread guiThread;

		public _003C_003Ec__DisplayClass136_0 CS_0024_003C_003E8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass136_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tY9XITssve5qDOWD05Kn();
			OL5iwgssH9wtLb414bN1(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(vfHQLfZxslOhenuAd3))]
		internal Task _003CConnect_003Eb__1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cPoKcussElZF0PeGo0rm();
			int num = ((!AvJp36ssSkDSYji4WNgM()) ? 5 : 4);
			vfHQLfZxslOhenuAd3 stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					stateMachine.iEnnBPhr4C = IOpAgLssVqyQqHueTRCI();
					goto case 1;
				case 3:
					stateMachine.iEnnBPhr4C.Start(ref stateMachine);
					num = 6;
					continue;
				case 2:
					stateMachine.X3LnTXynDq = -1;
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					stateMachine.jw1nJvEjBW = this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					break;
				}
				break;
			}
			return stateMachine.iEnnBPhr4C.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tY9XITssve5qDOWD05Kn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OL5iwgssH9wtLb414bN1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AvJp36ssSkDSYji4WNgM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cPoKcussElZF0PeGo0rm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncTaskMethodBuilder IOpAgLssVqyQqHueTRCI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncTaskMethodBuilder.Create();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass136_2
	{
		public Exception asyncException;

		public _003C_003Ec__DisplayClass136_1 CS_0024_003C_003E8__locals2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass136_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			eCDimfssU8VA2wy6wg59(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CConnect_003Eb__2(object o)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.HandleConnectCompleted(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, new CvsConnectCompletedEventArgs(asyncException));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eCDimfssU8VA2wy6wg59(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CQ0khissAB37tyBKBaBS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool doYMXassDfv5w0ntAYCN()
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
	private struct _003CClearSheetAsync_003Ed__146 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsInSight cvsInSight = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			do
			{
				IL_0349:
				switch (num)
				{
				case 0:
					cvsInSight = _003C_003E4__this;
					YOAM9ossTs2ZqfFyisMx();
					num = ((!z8nb4issd8NmSnlZt15a()) ? 1 : 5);
					goto IL_0349;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					goto IL_0349;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							cvsInSight.DeleteExternalCellData();
							num3 = 20;
							goto IL_01c4;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
							goto IL_01c4;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 19;
							goto IL_01c4;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
								if (z8nb4issd8NmSnlZt15a())
								{
									goto IL_0111;
								}
								goto IL_01c4;
							}
							IL_01c4:
							while (true)
							{
								switch (num3)
								{
								case 4:
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 1:
								case 16:
									if (!awaiter.IsCompleted)
									{
										num3 = 6;
										if (z8nb4issd8NmSnlZt15a())
										{
										}
										continue;
									}
									goto case 11;
								case 7:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 5:
									break;
								case 2:
									num2 = (_003C_003E1__state = 1);
									num3 = 21;
									continue;
								case 8:
									if (!awaiter2.IsCompleted)
									{
										num3 = 18;
										continue;
									}
									goto case 22;
								case 21:
									_003C_003Eu__1 = awaiter;
									goto case 4;
								case 18:
									num2 = (_003C_003E1__state = 2);
									num3 = 14;
									continue;
								case 9:
									awaiter = cwIh5ossimdFC9GFJGw9(cvsInSight.HandleUndoChangedAsync(UndoEventType.Reset));
									num3 = 13;
									continue;
								case 14:
									_003C_003Eu__2 = awaiter2;
									num3 = 17;
									continue;
								case 13:
									if (awaiter.IsCompleted)
									{
										goto IL_011a;
									}
									goto case 2;
								default:
									num3 = 2;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 15;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 10:
									cvsInSight.HandleUndoChanged(UndoEventType.Reset);
									num3 = 9;
									continue;
								case 20:
									goto IL_026a;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
									awaiter2 = cvsInSight.NK8xdPcxcK.Sheet.ClearCellsAsync(cvsInSight.ProcessorConstants.SpreadsheetRange).GetAwaiter();
									num3 = 8;
									continue;
								case 19:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 22;
									continue;
								case 11:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 22:
									awaiter2.GetResult();
									goto end_IL_004b;
								}
								break;
								IL_026a:
								awaiter = cvsInSight.b7SxCkd8vk.ResetAsync().GetAwaiter();
								z8nb4issd8NmSnlZt15a();
								num3 = (YOAM9ossTs2ZqfFyisMx() ? 16 : 4);
							}
							goto IL_0111;
							IL_0111:
							num2 = (_003C_003E1__state = -1);
							goto IL_011a;
							IL_011a:
							awaiter.GetResult();
							num3 = 0;
							goto IL_01c4;
							end_IL_004b:
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static TaskAwaiter cwIh5ossimdFC9GFJGw9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YOAM9ossTs2ZqfFyisMx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z8nb4issd8NmSnlZt15a()
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
	private struct _003CPasteCellsAsync_003Ed__149 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public CvsCellRange cellRange;

		public byte[] bytes;

		public bool cutFromSameSheet;

		public bool runSheet;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NLaTWyssqj951afdLGbT();
			int num;
			if (!uu4muFssBrLdqdefis6D())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_020b;
			IL_020b:
			int num2 = default;
			CvsCellLocation location = default;
			CvsInSight cvsInSight = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							location = aO4veFssjOlbJuxbPxG0(cvsInSight.i1Uxe9iPoR);
							num3 = 1;
							goto IL_00ee;
						}
						awaiter = _003C_003Eu__1;
						goto IL_012d;
						IL_012d:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_00ee;
						IL_00ee:
						while (true)
						{
							switch (num3)
							{
							case 3:
								cvsInSight.i1Uxe9iPoR.CurrentCell = CvsCellLocation.Invalid;
								_ = 0;
								num3 = ((!NLaTWyssqj951afdLGbT()) ? 4 : 6);
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 1:
								if (cellRange.Contains(location))
								{
									num3 = 3;
									if (uu4muFssBrLdqdefis6D())
									{
									}
									continue;
								}
								goto case 2;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 4:
							case 7:
								break;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 2:
							case 6:
								awaiter = NHxOI4ssWeBNhMnrlJSM(ixDsI2ss2MsyDxUSFiAe(Bflje9sscO1VDnwfODep(cvsInSight.NK8xdPcxcK), cellRange, bytes, cutFromSameSheet, runSheet));
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 11;
							case 8:
								return;
							case 11:
								awaiter.GetResult();
								goto end_IL_00ee;
							}
							goto IL_012d;
							continue;
							end_IL_00ee:
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
					num = 5;
					continue;
				case 1:
				case 3:
					cvsInSight = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_020b;
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
		internal static CvsCellLocation aO4veFssjOlbJuxbPxG0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).CurrentCell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Bflje9sscO1VDnwfODep(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ixDsI2ss2MsyDxUSFiAe(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NHxOI4ssWeBNhMnrlJSM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NLaTWyssqj951afdLGbT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uu4muFssBrLdqdefis6D()
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
	private struct _003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayImageAsync_003Ed__152 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public Bitmap bmp;

		public string imageName;

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
			CvsInSight cvsInSight = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					XRPLr6ss7u9uoFS5rAsh();
					num = (ud4CARsstarUZVGAn7pr() ? 5 : 4);
					break;
				case 1:
				case 4:
					cvsInSight = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!ud4CARsstarUZVGAn7pr())
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							hwxgY5ssK8eecBKQF5K7(cvsInSight.M9sxU718oA, GKKObOssCpj8Jn29SXYs(49862));
							num3 = 1;
							goto IL_0133;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00e1;
						IL_019f:
						num2 = (_003C_003E1__state = -1);
						num3 = 5;
						goto IL_0133;
						IL_00e1:
						_003C_003Eu__1 = default;
						goto IL_019f;
						IL_0133:
						while (true)
						{
							switch (num3)
							{
							case 1:
							{
								CvsCogSocket cogSocket = cvsInSight.CogSocket;
								Bitmap bitmap = bmp;
								string text = imageName;
								awaiter = VRsWrCss5VwAHqZgPmEQ(cogSocket.PostImageByHTTPAndRunSheetAsync(bitmap, null, text, sync: true));
								num3 = 8;
								if (ud4CARsstarUZVGAn7pr())
								{
								}
								continue;
							}
							case 2:
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (true)
								{
									continue;
								}
								break;
							case 0:
								break;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 4:
								return;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto IL_0180;
								}
								goto case 5;
							case 6:
							case 9:
								goto IL_019f;
							case 5:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								cvsInSight.M9sxU718oA.Debug(kgbOBx7BanbFa22Hp9.ol99ukmDA(49920));
								num3 = 11;
								continue;
							case 11:
								cvsInSight.MakeNewResult(updateExposedResults: false);
								goto end_IL_006b;
							}
							break;
							IL_0180:
							num2 = (_003C_003E1__state = 0);
							_ = 0;
							num3 = (XRPLr6ss7u9uoFS5rAsh() ? 3 : 9);
						}
						goto IL_00e1;
						end_IL_006b:;
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
		internal static object GKKObOssCpj8Jn29SXYs(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hwxgY5ssK8eecBKQF5K7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Debug((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VRsWrCss5VwAHqZgPmEQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XRPLr6ss7u9uoFS5rAsh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ud4CARsstarUZVGAn7pr()
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
	private struct _003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayPointCloudAsync_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public Stream rawData;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CvsInSight cvsInSight = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							S88PQTssNRGtgtlXeO5P(cvsInSight.M9sxU718oA, wUOo9UssYHIfJFv0Humu(49976));
							num3 = 9;
							goto IL_011e;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0073;
						IL_0073:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_011e;
						IL_011e:
						while (true)
						{
							switch (num3)
							{
							case 9:
								awaiter = ((Task)m3fUXKssxPrX1OVUW7oV(cvsInSight.CogSocket, rawData)).GetAwaiter();
								num3 = 3;
								continue;
							case 6:
								break;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 5:
							case 8:
								S88PQTssNRGtgtlXeO5P(cvsInSight.M9sxU718oA, kgbOBx7BanbFa22Hp9.ol99ukmDA(50044));
								num3 = 11;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								_ = 1;
								if (!LESm96ssPUom8BCka2pZ())
								{
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 5;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 4;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 4:
							case 7:
								awaiter.GetResult();
								goto case 5;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 11:
								cvsInSight.MakeNewResult(updateExposedResults: false);
								goto end_IL_011e;
							}
							goto IL_0073;
							continue;
							end_IL_011e:
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
				case 1:
				case 5:
					cvsInSight = _003C_003E4__this;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				etLpxosso4NnTL4oaOqW();
				num = ((!LESm96ssPUom8BCka2pZ()) ? 5 : 2);
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
		internal static object wUOo9UssYHIfJFv0Humu(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void S88PQTssNRGtgtlXeO5P(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Debug((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m3fUXKssxPrX1OVUW7oV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).PostPointCloudByHTTPAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool etLpxosso4NnTL4oaOqW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LESm96ssPUom8BCka2pZ()
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
	private struct _003CGetPointCloudDataAsync_003Ed__161 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public string url;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!yRDso8ss14jGEwDmbrPL()) ? 1 : 5);
			int num2 = default;
			CvsInSight cvsInSight = default;
			Stream result = default;
			do
			{
				IL_0197:
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					if (KCxAV2ssrdt0VqCu3j3u())
					{
					}
					goto IL_0197;
				case 4:
					try
					{
						TaskAwaiter<Stream> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsInSight.CogSocket.GetPointCloudByHttpAsync(url).GetAwaiter();
							num3 = 0;
							if (KCxAV2ssrdt0VqCu3j3u())
							{
							}
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
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 1:
							case 4:
								return;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								num3 = (yRDso8ss14jGEwDmbrPL() ? 1 : 8);
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto case 6;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
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
				case 2:
					cvsInSight = _003C_003E4__this;
					num = 4;
					goto IL_0197;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (!KCxAV2ssrdt0VqCu3j3u());
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
		internal static bool yRDso8ss14jGEwDmbrPL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KCxAV2ssrdt0VqCu3j3u()
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
	private struct _003CGetPointCloudThumbDataAsync_003Ed__162 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public string url;

		private Stream _003CpointCloudDatReader_003E5__2;

		private MemoryStream _003Cms_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0033;
			IL_007c:
			_003Cms_003E5__3 = null;
			goto IL_0066;
			IL_0033:
			CvsInSight cvsInSight = default;
			int num2 = default;
			TaskAwaiter awaiter3 = default;
			byte[] result3 = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					break;
				default:
					num = 6;
					continue;
				case 4:
				case 5:
					goto IL_0066;
				case 6:
					goto IL_007c;
				case 3:
					goto IL_0093;
				case 1:
				case 2:
					cvsInSight = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						TaskAwaiter<bool> awaiter2;
						TaskAwaiter<Stream> awaiter;
						Stream result;
						bool result2;
						switch (num2)
						{
						default:
							awaiter2 = cvsInSight.CogSocket.IsQuadMeshAsync(url).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_013c;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_013c;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01d0;
						case 2:
							break;
							IL_01d0:
							result = awaiter.GetResult();
							_003CpointCloudDatReader_003E5__2 = result;
							break;
							IL_013c:
							result2 = awaiter2.GetResult();
							url = (string)(result2 ? wfT4JvssQiiD4eubIRrP(url, ou0qJIssMCd8flnhrXpB(50110)) : url);
							awaiter = cvsInSight.GetPointCloudDataAsync(url).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01d0;
						}
						try
						{
							if (num2 != 2)
							{
								_003Cms_003E5__3 = new MemoryStream();
							}
							try
							{
								int num3;
								if (num2 != 2)
								{
									IOCQbLss3buLigsndRZ1();
									num3 = ((!Xc3S0fssOxn3cJdbfCHW()) ? 1 : 5);
								}
								else
								{
									awaiter3 = _003C_003Eu__3;
									num3 = 6;
								}
								while (true)
								{
									switch (num3)
									{
									case 2:
										num2 = (_003C_003E1__state = -1);
										num3 = 4;
										continue;
									case 9:
										_003C_003Eu__3 = awaiter3;
										goto case 3;
									case 7:
										return;
									case 3:
									case 5:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									default:
										num3 = 7;
										continue;
									case 4:
										awaiter3.GetResult();
										num3 = 10;
										continue;
									case 0:
									case 1:
										awaiter3 = QYFtOosse4k5R1qnlxJi(byMFQ5ssl0hCpS4BYaGJ(_003CpointCloudDatReader_003E5__2, _003Cms_003E5__3));
										if (!awaiter3.IsCompleted)
										{
											num3 = 8;
											continue;
										}
										goto case 4;
									case 6:
										_003C_003Eu__3 = default;
										num3 = 2;
										continue;
									case 8:
										num2 = (_003C_003E1__state = 2);
										num3 = 9;
										continue;
									case 10:
										result3 = (byte[])qs4NrDssujiKmB9S9N3F(_003Cms_003E5__3);
										break;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003Cms_003E5__3 != null)
								{
									Fetuc2ssIkAAKv9sKyUq(_003Cms_003E5__3);
								}
							}
						}
						finally
						{
							if (num2 < 0 && _003CpointCloudDatReader_003E5__2 != null)
							{
								Fetuc2ssIkAAKv9sKyUq(_003CpointCloudDatReader_003E5__2);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CpointCloudDatReader_003E5__2 = null;
						_003Cms_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 7;
					if (true)
					{
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
				IL_0093:
				num2 = _003C_003E1__state;
				Xc3S0fssOxn3cJdbfCHW();
				num = (IOCQbLss3buLigsndRZ1() ? 2 : 4);
			}
			goto IL_001a;
			IL_0066:
			_003C_003Et__builder.SetResult(result3);
			num = 8;
			goto IL_0033;
			IL_001a:
			_003CpointCloudDatReader_003E5__2 = null;
			goto IL_007c;
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
		internal static object ou0qJIssMCd8flnhrXpB(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wfT4JvssQiiD4eubIRrP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object byMFQ5ssl0hCpS4BYaGJ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).CopyToAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QYFtOosse4k5R1qnlxJi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qs4NrDssujiKmB9S9N3F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fetuc2ssIkAAKv9sKyUq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IOCQbLss3buLigsndRZ1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xc3S0fssOxn3cJdbfCHW()
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
	private struct _003CGetZRange_003Ed__163 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(double?, double?)> _003C_003Et__builder;

		public string url;

		public CvsInSight _003C_003E4__this;

		private double? _003CminZ_003E5__2;

		private string _003CroiMaxZUrl_003E5__3;

		private TaskAwaiter<double> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (bJ8gB6ssaa5fs0ACYUU8())
			{
				goto IL_001e;
			}
			goto IL_0318;
			IL_001e:
			int num2 = default;
			CvsInSight cvsInSight = default;
			(double?, double?) result2 = default;
			try
			{
				_ = 1;
				double? item = default;
				try
				{
					int num3;
					TaskAwaiter<double> awaiter = default;
					if (num2 != 0)
					{
						if (num2 != 1)
						{
							num3 = 0;
							if (bJ8gB6ssaa5fs0ACYUU8())
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 17;
						if (bJ8gB6ssaa5fs0ACYUU8())
						{
							goto IL_0229;
						}
					}
					goto IL_0175;
					IL_0175:
					double result = default;
					string path = default;
					while (true)
					{
						switch (num3)
						{
						case 7:
							return;
						case 3:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 11;
							continue;
						case 15:
							num2 = (_003C_003E1__state = 0);
							num3 = 13;
							continue;
						case 18:
							_003CroiMaxZUrl_003E5__3 = (string)yRdSR1ssGUYl4LJQg105(url, uQhhUPssn6UcjPRa6CxQ(50168));
							num3 = 9;
							continue;
						case 2:
							if (!awaiter.IsCompleted)
							{
								num3 = 12;
								continue;
							}
							goto case 11;
						case 13:
							_003C_003Eu__1 = awaiter;
							_ = 0;
							num3 = ((!tMVrdrssRf4DIYAQr4QS()) ? 4 : 5);
							continue;
						case 17:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto case 4;
						case 12:
							num2 = (_003C_003E1__state = 1);
							num3 = 10;
							continue;
						case 14:
							if (!awaiter.IsCompleted)
							{
								num3 = 15;
								continue;
							}
							goto case 4;
						case 4:
						case 8:
							result = awaiter.GetResult();
							_003CminZ_003E5__2 = result;
							awaiter = ((IRemoteDeviceApi)lm8XotssXkyJq2DEuLiD(cvsInSight.CogSocket)).GetAsync<double>(_003CroiMaxZUrl_003E5__3).GetAwaiter();
							goto case 2;
						default:
							num3 = 2;
							continue;
						case 10:
							_003C_003Eu__1 = awaiter;
							num3 = 1;
							continue;
						case 1:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 7;
							continue;
						case 5:
						case 6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 0:
							break;
						case 9:
							awaiter = cvsInSight.CogSocket.DeviceApi.GetAsync<double>(path).GetAwaiter();
							num3 = 14;
							continue;
						case 11:
							result = awaiter.GetResult();
							num3 = 16;
							continue;
						case 16:
							item = result;
							num3 = 19;
							continue;
						case 19:
							_003CroiMaxZUrl_003E5__3 = null;
							goto end_IL_0175;
						}
						goto IL_0229;
						continue;
						end_IL_0175:
						break;
					}
					goto end_IL_0023;
					IL_0229:
					path = (string)yRdSR1ssGUYl4LJQg105(url, uQhhUPssn6UcjPRa6CxQ(50148));
					num3 = 18;
					goto IL_0175;
					end_IL_0023:;
				}
				catch (Exception ex)
				{
					GGPK2lssb4rxpdFsT6b3(cvsInSight.M9sxU718oA, kgbOBx7BanbFa22Hp9.ol99ukmDA(50188), ex);
					_003CminZ_003E5__2 = null;
					item = null;
				}
				result2 = (_003CminZ_003E5__2, item);
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0377;
			IL_0318:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 1:
					cvsInSight = _003C_003E4__this;
					num = 2;
					continue;
				case 5:
					goto IL_035a;
				default:
					goto IL_0377;
				case 6:
					return;
				}
				break;
				IL_035a:
				num2 = _003C_003E1__state;
				_ = 0;
				num = ((!tMVrdrssRf4DIYAQr4QS()) ? 4 : 0);
			}
			goto IL_001e;
			IL_0377:
			_003C_003Et__builder.SetResult(result2);
			num = 6;
			goto IL_0318;
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
		internal static object uQhhUPssn6UcjPRa6CxQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yRdSR1ssGUYl4LJQg105(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lm8XotssXkyJq2DEuLiD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).DeviceApi;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GGPK2lssb4rxpdFsT6b3(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).DebugException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tMVrdrssRf4DIYAQr4QS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bJ8gB6ssaa5fs0ACYUU8()
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
	private struct _003CAsTask_003Ed__172 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public string eventName;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CvsInSight cvsInSight = default;
			TaskCompletionSource<bool> taskCompletionSource = default;
			TaskAwaiter<bool> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					cvsInSight = _003C_003E4__this;
					MyJom3sskuQ46dQwP3rB();
					num = ((!AWFbm6ss4mLdKljWD9by()) ? 5 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							taskCompletionSource = new TaskCompletionSource<bool>();
							_ = 1;
							if (!MyJom3sskuQ46dQwP3rB())
							{
								num3 = 9;
								if (false)
								{
									goto IL_0085;
								}
							}
							else
							{
								num3 = 3;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0159;
						IL_0085:
						awaiter = taskCompletionSource.Task.GetAwaiter();
						num3 = 5;
						if (false)
						{
							goto IL_009d;
						}
						goto IL_0159;
						IL_009d:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_0159;
						IL_0159:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 1:
								goto IL_009d;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 0:
							case 9:
								cvsInSight.MQZx8aduyT.GetOrAdd(eventName, [MethodImpl(MethodImplOptions.NoInlining)] (string _) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return new List<TaskCompletionSource<bool>>();
								}).Add(taskCompletionSource);
								num3 = 7;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_0085;
						end_IL_0061:;
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
		internal static bool AWFbm6ss4mLdKljWD9by()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MyJom3sskuQ46dQwP3rB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public object sender;

		public string eventName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass173_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DTAKwEssmmiJcfLRm7ha();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DTAKwEssmmiJcfLRm7ha()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H4wJOLssfSduwf29KhC8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jP7LcissFBb8tlme6bnK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NfPyOBssysOVLIX1lsSw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass173_1
	{
		public EventHandler eh;

		public _003C_003Ec__DisplayClass173_0 CS_0024_003C_003E8__locals1;

		public Action _003C_003E9__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass173_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yW3tZrssJFBBICrD2go6();
			fLnbcWss8kW9dD6MlEVw(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CHandleEvent_003Eb__1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UHxcO9sszGGpbD5OwCyq(eh, CS_0024_003C_003E8__locals1.sender, EventArgs.Empty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yW3tZrssJFBBICrD2go6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fLnbcWss8kW9dD6MlEVw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ui44S0ssg11EmAuriaDg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ph28KdssZ76pB6qqwjkL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UHxcO9sszGGpbD5OwCyq(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass173_2
	{
		public TaskCompletionSource<bool> item;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass173_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WxXpeSshhS2sJTeTS8md();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CHandleEvent_003Eb__2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			item.SetResult(result: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WxXpeSshhS2sJTeTS8md()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FyhlJEshwqfFYD3PDtC7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PvO62ishsk9X3P0Ev9aq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public CvsInSight _003C_003E4__this;

		public UndoEventType type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass176_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WcM9lQshShfw7pcWIMqn();
			U4n570shE1g1XZcp5RMI(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CHandleUndoChanged_003Eb__0(object _)
		{
			while (false)
			{
				object obj = ((object[])null)[0];
			}
			_003C_003E4__this.HandleUndoChanged(type, checkThreadContext: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WcM9lQshShfw7pcWIMqn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void U4n570shE1g1XZcp5RMI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eciZ1NshLBaCHok04mXU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m0uor7sh9cT6w1OgFHl7()
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
	private struct _003CHandleUndoChangedAsync_003Ed__177 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public UndoEventType type;

		private UndoEventArgs _003Cargs_003E5__2;

		private Delegate[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XIS2DMshH7NepkHMOMgn();
			int num;
			if (oYEHFGshv6oEGM2l6oBk())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_027d;
			IL_027d:
			CvsInSight cvsInSight = default;
			int num2 = default;
			UndoEventHandlerAsync undoEventHandlerAsync = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					cvsInSight = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoEventHandlerAsync = cvsInSight.lxeFb5Feul;
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								if (oYEHFGshv6oEGM2l6oBk())
								{
									num3 = 1;
									continue;
								}
								num3 = 8;
								if (XIS2DMshH7NepkHMOMgn())
								{
								}
								continue;
							case 8:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (!XIS2DMshH7NepkHMOMgn())
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Eu__1 = default;
								goto case 8;
							case 10:
								_003C_003E7__wrap3++;
								num3 = 12;
								continue;
							case 3:
								awaiter.GetResult();
								num3 = 10;
								if (oYEHFGshv6oEGM2l6oBk())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 5:
							case 12:
								if (_003C_003E7__wrap3 >= _003C_003E7__wrap2.Length)
								{
									_003C_003E7__wrap2 = null;
									num3 = 15;
								}
								else
								{
									awaiter = swEOT1shAwhrT3VV1oyO(((UndoEventHandlerAsync)_003C_003E7__wrap2[_003C_003E7__wrap3])(cvsInSight, _003Cargs_003E5__2));
									num3 = 7;
								}
								continue;
							case 0:
								return;
							case 14:
								_003C_003E7__wrap3 = 0;
								num3 = 5;
								continue;
							case 4:
								if (undoEventHandlerAsync != null)
								{
									_003Cargs_003E5__2 = new UndoEventArgs(type);
									_003C_003E7__wrap2 = (Delegate[])rHp17NshVtEpV0eP73NP(undoEventHandlerAsync);
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 7;
								}
								goto end_IL_0127;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									if (true)
									{
										continue;
									}
									break;
								}
								goto case 3;
							case 15:
								break;
							}
							_003Cargs_003E5__2 = null;
							break;
							continue;
							end_IL_0127:
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
					goto case 1;
				default:
					num = 1;
					continue;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (oYEHFGshv6oEGM2l6oBk())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			num2 = _003C_003E1__state;
			num = 5;
			goto IL_027d;
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
		internal static object rHp17NshVtEpV0eP73NP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Delegate)P_0).GetInvocationList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter swEOT1shAwhrT3VV1oyO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oYEHFGshv6oEGM2l6oBk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XIS2DMshH7NepkHMOMgn()
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
	private struct _003CinternalConnect_003Ed__184 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public string cameraPath;

		public string sheetPath;

		public Uri rootUrl;

		public string username;

		public string password;

		public bool blockEvents;

		public Uri httpUri;

		public CvsInSightLanguage language;

		public ICogSocketAcqFactory acqFactory;

		private IDisposable _003C_003E7__wrap1;

		private IPAddress _003CipAddress_003E5__3;

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
			if (tPeJKoshDP0TMFt9AP0r())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0054;
				}
			}
			goto IL_03ce;
			IL_03ce:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 2:
					goto IL_003b;
				case 1:
				case 3:
					goto IL_0054;
				case 4:
					goto IL_0067;
				default:
					num = 5;
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
			goto IL_0024;
			IL_0067:
			int num2 = default;
			CvsInSight cvsInSight = default;
			try
			{
				if (num2 != 0)
				{
					cvsInSight.jlfxsQHPFU = cameraPath ?? string.Empty;
					cvsInSight.XNnx6nbV7X = sheetPath ?? cameraPath;
					_003C_003E7__wrap1 = CvsTraceSDK.Info.TraceFunction(cvsInSight.LcgxjxZB2U((string)HAMxUDshTGLVhZH8xOxU(50242)));
				}
				try
				{
					if (num2 != 0)
					{
						string host = rootUrl.Host;
						if (host == null)
						{
							throw new CvsNetworkException((string)UQw6CPshdWZHcIJEJBwT());
						}
						if (cvsInSight.State != CvsInSightState.NotConnected)
						{
							cvsInSight.Disconnect();
						}
						username = ((username == null) ? string.Empty : username);
						password = ((password == null) ? string.Empty : password);
						_003CipAddress_003E5__3 = (IPAddress)YUxr43shiBtGVKoBSSNh(host);
					}
					try
					{
						if (num2 != 0)
						{
							cvsInSight.EventManager = new EventManager(cvsInSight);
							if (blockEvents)
							{
								MpmTQhshqaDLdnCbtFCI(cvsInSight.EventManager);
							}
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = aCxmQMshB0NcxnJPN7f3(cvsInSight.WohxTrM4Kg(rootUrl, httpUri, cvsInSight.jlfxsQHPFU, cvsInSight.XNnx6nbV7X, username, language, acqFactory));
								num3 = 0;
								if (mbk8CushUPrLRvRWjmPN())
								{
									goto IL_01b7;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
							goto IL_01f0;
							IL_01d0:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_01f0:
							while (true)
							{
								switch (num3)
								{
								case 5:
								case 6:
									break;
								case 7:
									goto IL_01d0;
								default:
									num3 = 3;
									continue;
								case 8:
									_003C_003Eu__1 = default;
									break;
								case 3:
									return;
								case 4:
									_003C_003Eu__1 = awaiter;
									num3 = 7;
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										tPeJKoshDP0TMFt9AP0r();
										if (mbk8CushUPrLRvRWjmPN())
										{
											num3 = 5;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										num3 = 2;
										if (true)
										{
											continue;
										}
										goto case 1;
									}
									goto case 9;
								case 1:
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									goto end_IL_016b;
								}
								break;
							}
							goto IL_01b7;
							IL_01b7:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							if (!tPeJKoshDP0TMFt9AP0r())
							{
								goto IL_01d0;
							}
							goto IL_01f0;
							end_IL_016b:;
						}
						catch (Exception)
						{
							cvsInSight.TluxMbchkd();
							cvsInSight.EventManager = null;
							throw;
						}
						cvsInSight.xqgx0qiAEY = _003CipAddress_003E5__3;
						cvsInSight.Xxlxww20tn = _003CipAddress_003E5__3.ToString();
						cvsInSight.eubxRGhOdU = PJIaPFshjHetfjleyvop(rootUrl);
						cvsInSight.xS4xHwV7ol = username;
						cvsInSight.BmtxK2pf6u = password;
					}
					catch (CvsException ex2)
					{
						if (ex2 is CvsNotConnectedException)
						{
							throw new CvsNetworkException((string)vv6x4mshcQAPKKIFLLLS(), ex2);
						}
						if (ex2 is CvsNetworkException && j60iYWsh7hm9WviVBN0E(k0ZAWXsh2eK2qHLhyokn(ex2), cZaLidshWerKK6LyBFKV()))
						{
							throw new CvsNetworkException((string)vv6x4mshcQAPKKIFLLLS(), ex2);
						}
						throw;
					}
					catch (Exception innerException)
					{
						throw new CvsNetworkException(innerException);
					}
					_003CipAddress_003E5__3 = null;
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						Iq5n8OshtjDEEPR0DLTK(_003C_003E7__wrap1);
					}
				}
				_003C_003E7__wrap1 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0024;
			IL_0024:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_003b;
			}
			goto IL_03ce;
			IL_0054:
			cvsInSight = _003C_003E4__this;
			num = 4;
			if (false)
			{
				goto IL_0067;
			}
			goto IL_03ce;
			IL_003b:
			num2 = _003C_003E1__state;
			goto IL_0054;
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
		internal static object HAMxUDshTGLVhZH8xOxU(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UQw6CPshdWZHcIJEJBwT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.IPAddressNotSpecified;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YUxr43shiBtGVKoBSSNh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsHelper.DnsResolve((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MpmTQhshqaDLdnCbtFCI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EventManager)P_0).BlockEvents();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter aCxmQMshB0NcxnJPN7f3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PJIaPFshjHetfjleyvop(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Uri)P_0).Port;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vv6x4mshcQAPKKIFLLLS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ConnectFailed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k0ZAWXsh2eK2qHLhyokn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cZaLidshWerKK6LyBFKV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.NoResponse;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j60iYWsh7hm9WviVBN0E(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Iq5n8OshtjDEEPR0DLTK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tPeJKoshDP0TMFt9AP0r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mbk8CushUPrLRvRWjmPN()
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
	private struct _003CConnectCogSocket_003Ed__186 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public CvsInSightLanguage language;

		public Uri rootUrl;

		public Uri httpUri;

		public string cameraPath;

		public string sheetPath;

		public string username;

		public ICogSocketAcqFactory acqFactory;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AyrP0vshKOBHp9koERGP();
			int num = ((!zkVmanshCIvJKIc9YIQi()) ? 2 : 5);
			int num2 = default;
			CvsInSight cvsInSight = default;
			TaskAwaiter awaiter = default;
			CvsFunctionTable cvsFunctionTable = default;
			CvsProcessorConstants cvsProcessorConstants = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003C_003E7__wrap1 = (IDisposable)BYVgU3shoQ2B5Sj6V4eP(CvsTraceSDK.Info, cvsInSight.LcgxjxZB2U((string)TN4y19sh5Rfn2RiOJWEI(50276)));
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 27;
									if (AyrP0vshKOBHp9koERGP())
									{
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 22;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
								if (1 == 0)
								{
									goto IL_03be;
								}
							}
							goto IL_04be;
							IL_04be:
							while (true)
							{
								switch (num3)
								{
								case 12:
									return;
								case 19:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 12;
									continue;
								case 20:
									l2MhUBshRJ4X0Y9tssvI(cvsInSight.Xcsx2Wv5TK.StateChanged, new CvsStateChangedEventArgs(cvsInSight.fIQxGWeG7D, CvsInSightStateChangedReason.Normal, cvsInSight.Ci8xV3RoU8));
									num3 = 31;
									continue;
								case 4:
								case 23:
									if (cvsFunctionTable == null)
									{
										num3 = 9;
										if (0 == 0)
										{
											continue;
										}
										goto case 5;
									}
									BD6QWXshIegPVblRQNMd(cvsInSight.NK8xdPcxcK, cvsFunctionTable);
									num3 = 21;
									if (true)
									{
										continue;
									}
									goto case 30;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 25;
										continue;
									}
									goto IL_040b;
								case 9:
									PW2ROUshePOx4SeYpbV9(cvsInSight.NK8xdPcxcK);
									QXRHJPsh1lrGWiAIApZd(KHLxnZX5vu, RVGA2ZshxS1qfyn0vMLL(cvsInSight.NK8xdPcxcK), RwYsvcshuyOUIiyBolc7(cvsInSight.NK8xdPcxcK));
									num3 = 28;
									continue;
								case 7:
									cvsInSight.IPdxrcTulv = language;
									num3 = 30;
									continue;
								case 22:
									_003C_003Eu__1 = default;
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 24;
								case 24:
									cvsInSight.JjLxvIXWu9.ResultsChanged += cvsInSight.qYUxB7qmkA;
									num3 = 15;
									continue;
								case 16:
									WynO3vshlX2D6QaJUP0h(cvsInSight.BsGxZoGsDw, new EventHandler(cvsInSight.Fv8xJWSsBx));
									cvsFunctionTable = (CvsFunctionTable)OJGEvBshNeVTUxISVV05(KHLxnZX5vu, RVGA2ZshxS1qfyn0vMLL(cvsInSight.NK8xdPcxcK));
									goto case 4;
								case 6:
									awaiter.GetResult();
									num3 = 17;
									continue;
								case 30:
									awaiter = cvsInSight.d1HxAyDj1T(rootUrl, httpUri, cameraPath, sheetPath, username, acqFactory).GetAwaiter();
									num3 = 3;
									continue;
								case 8:
								case 29:
									awaiter = z4ElFIshOyNxKDS81mEk(KhyJOJsh3bt7xfqmb4O8(cvsInSight.i1Uxe9iPoR));
									num3 = 5;
									continue;
								case 10:
								case 13:
									cvsInSight.NK8xdPcxcK.GetProcessorConstants();
									QXRHJPsh1lrGWiAIApZd(ow5x9AvbBI, RVGA2ZshxS1qfyn0vMLL(cvsInSight.NK8xdPcxcK), cvsInSight.NK8xdPcxcK.ProcessorConstants);
									num3 = 8;
									continue;
								case 2:
									cvsProcessorConstants = (CvsProcessorConstants)OJGEvBshNeVTUxISVV05(ow5x9AvbBI, cvsInSight.NK8xdPcxcK.ConnectionId);
									num3 = 18;
									continue;
								case 18:
									if (cvsProcessorConstants == null)
									{
										_ = 1;
										if (AyrP0vshKOBHp9koERGP())
										{
											num3 = 4;
											if (zkVmanshCIvJKIc9YIQi())
											{
												continue;
											}
											goto case 6;
										}
										num3 = 13;
										continue;
									}
									Ie3dRMshreUeuZmhLYkY(cvsInSight.NK8xdPcxcK, cvsProcessorConstants);
									num3 = 29;
									continue;
								case 15:
									cvsInSight.BsGxZoGsDw = new LiveAcqResultBuilder((ICogSocketAcq)ndwWH6shMx742uJbLNKd(cvsInSight.NK8xdPcxcK), (CvsCogSocketSheet)alnpqWshQOvNbf6B5dxg(cvsInSight.NK8xdPcxcK), cvsInSight.i1Uxe9iPoR, cvsInSight.ProcessorConstants, cvsInSight.afHxDIlTiO, cvsInSight.LiveModeService, cvsInSight.NK8xdPcxcK.IsRuntimeSupported);
									num3 = 16;
									continue;
								case 21:
								case 28:
									cvsInSight.fIQxGWeG7D = CvsInSightState.Connected;
									num3 = 11;
									continue;
								case 26:
									cvsInSight.afHxDIlTiO = new CvsPropSheet(cvsInSight, cvsInSight.NK8xdPcxcK);
									num3 = 2;
									continue;
								case 3:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto case 6;
								case 0:
									break;
								case 11:
								{
									CvsUser user = new CvsUser(kgbOBx7BanbFa22Hp9.ol99ukmDA(16862), "", CvsInSightSecurityAccess.Full, ftpReadEnabled: true, ftpWriteEnabled: true, customViewDefaultEnabled: false);
									cvsInSight.ConnectedUser = new CvsClassicConnectedUser(user);
									num3 = 20;
									continue;
								}
								case 14:
									num2 = (_003C_003E1__state = -1);
									goto IL_040b;
								case 1:
									cvsInSight.JjLxvIXWu9 = new ResultBuilder(cvsInSight.CameraPath, cvsInSight.KgZx78PC4V, cvsInSight.NK8xdPcxcK.Sheet, cvsInSight.ProcessorConstants, cvsInSight.i1Uxe9iPoR, cvsInSight.afHxDIlTiO);
									num3 = 24;
									if (!AyrP0vshKOBHp9koERGP())
									{
										continue;
									}
									goto case 17;
								case 17:
									IW92yrshYUsdq1L8Zm8x(cvsInSight.NK8xdPcxcK.SetLanguage((CultureInfo)lbUJhZshPDXYIweQ58TX(Thread.CurrentThread)));
									num3 = 26;
									continue;
								case 27:
									cvsInSight.Ci8xV3RoU8++;
									num3 = 7;
									if (zkVmanshCIvJKIc9YIQi())
									{
										continue;
									}
									goto case 25;
								case 25:
									num2 = (_003C_003E1__state = 1);
									goto case 19;
								default:
									num3 = 19;
									continue;
								case 31:
									{
										cvsInSight.NK8xdPcxcK.ResultChangedEnabled = true;
										goto end_IL_04be;
									}
									IL_040b:
									awaiter.GetResult();
									num3 = 1;
									continue;
								}
								goto IL_03be;
								continue;
								end_IL_04be:
								break;
							}
							goto end_IL_0065;
							IL_03be:
							num2 = (_003C_003E1__state = -1);
							num3 = 6;
							goto IL_04be;
							end_IL_0065:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								INxNRBshaK0w48FLvT75(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				cvsInSight = _003C_003E4__this;
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
		internal static object TN4y19sh5Rfn2RiOJWEI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BYVgU3shoQ2B5Sj6V4eP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lbUJhZshPDXYIweQ58TX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Thread)P_0).CurrentUICulture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IW92yrshYUsdq1L8Zm8x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Task)P_0).Wait();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OJGEvBshNeVTUxISVV05(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Hashtable)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RVGA2ZshxS1qfyn0vMLL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).ConnectionId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QXRHJPsh1lrGWiAIApZd(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Hashtable)P_0)[P_1] = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ie3dRMshreUeuZmhLYkY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).ProcessorConstants = (CvsProcessorConstants)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KhyJOJsh3bt7xfqmb4O8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).InitializeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter z4ElFIshOyNxKDS81mEk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ndwWH6shMx742uJbLNKd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Acq;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object alnpqWshQOvNbf6B5dxg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WynO3vshlX2D6QaJUP0h(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IResultBuilder)P_0).ResultsChanged += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PW2ROUshePOx4SeYpbV9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).GetFunctionTable();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RwYsvcshuyOUIiyBolc7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BD6QWXshIegPVblRQNMd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).FunctionTable = (CvsFunctionTable)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l2MhUBshRJ4X0Y9tssvI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EventManager.CachedManagedEvent)P_0).AddEvent((EventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void INxNRBshaK0w48FLvT75(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zkVmanshCIvJKIc9YIQi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AyrP0vshKOBHp9koERGP()
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
	private struct _003CCreateCvsCogSocket_003Ed__193 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		public Uri rootUrl;

		public Uri httpUrl;

		public string path;

		public string sheetPath;

		public string username;

		public ICogSocketAcqFactory acqFactory;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter<CvsCogSocket> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i9XkVxshGBkuc3OJI8pj();
			int num = ((!fg7xBUshn8cUeWbkNYXa()) ? 4 : 2);
			int num2 = default;
			CvsInSight cvsInSight = default;
			CvsCogSocket result = default;
			do
			{
				IL_02a9:
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_02a9;
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = (IDisposable)mwgAylshXnabCdGqpfdM(CvsTraceSDK.Info, cvsInSight.LcgxjxZB2U(kgbOBx7BanbFa22Hp9.ol99ukmDA(50312)));
						}
						try
						{
							try
							{
								TaskAwaiter<CvsCogSocket> awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = CvsCogSocket.CreateAsync(rootUrl, httpUrl, path, sheetPath, username, cvsInSight.E9bxkvQqYO, acqFactory).GetAwaiter();
									num3 = 9;
									if (i9XkVxshGBkuc3OJI8pj())
									{
										return;
									}
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
									case 4:
									case 5:
										return;
									case 3:
									case 6:
										num2 = (_003C_003E1__state = -1);
										num3 = 0;
										continue;
									case 9:
										if (!awaiter.IsCompleted)
										{
											num3 = 1;
											if (fg7xBUshn8cUeWbkNYXa())
											{
												continue;
											}
											goto case 2;
										}
										goto case 0;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto default;
									default:
										_ = 0;
										num3 = ((!fg7xBUshn8cUeWbkNYXa()) ? 3 : 5);
										continue;
									case 7:
										_003C_003Eu__1 = awaiter;
										num3 = 2;
										continue;
									case 1:
										num2 = (_003C_003E1__state = 0);
										num3 = 7;
										continue;
									case 8:
										_003C_003Eu__1 = default;
										goto case 3;
									case 0:
										result = awaiter.GetResult();
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										break;
									case 10:
										break;
									}
									break;
								}
								cvsInSight.NK8xdPcxcK = result;
							}
							catch (Exception)
							{
								throw;
							}
							y4LeGkshbJ7iPTbYAgpx(cvsInSight.NK8xdPcxcK, new EventHandler(cvsInSight.dFextTd6fX));
							cvsInSight.NK8xdPcxcK.ResultChanged += cvsInSight.BX4xWMIAsl;
							RTlH1vshpccgmhR18sfC(ON8DsJsh6RNul3MmD94N(cvsInSight.NK8xdPcxcK), new CvsCogSocketSheet.SheetUpdatedEventHandler(cvsInSight.GEjx3ESUIg));
							cvsInSight.NK8xdPcxcK.Sheet.SheetIDChanged += cvsInSight.p0PxLIQgcY;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								yhkcIksh0uo3DUOlOnYG(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
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
					goto IL_02a9;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				cvsInSight = _003C_003E4__this;
				num = 5;
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
		internal static object mwgAylshXnabCdGqpfdM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void y4LeGkshbJ7iPTbYAgpx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).Closed += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ON8DsJsh6RNul3MmD94N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RTlH1vshpccgmhR18sfC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SheetUpdated += (CvsCogSocketSheet.SheetUpdatedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yhkcIksh0uo3DUOlOnYG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fg7xBUshn8cUeWbkNYXa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i9XkVxshGBkuc3OJI8pj()
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
	private struct _003CCvsCogSocketSheetIDChanged_003Ed__197 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CvsInSight _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			CvsInSight cvsInSight = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (qfFYtCsh4HtbwD7cvXeG())
					{
						num = 4;
						if (qfFYtCsh4HtbwD7cvXeG())
						{
							break;
						}
						goto case 0;
					}
					num = 0;
					if (Yoc15Rshk757Qlmn9v9N())
					{
						return;
					}
					break;
				case 0:
				case 2:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = AQdaOHshFwKUaZKZaCfo(ljMwksshfbgBSJkAfJlI(cvsInSight.i1Uxe9iPoR));
								num3 = 0;
								if (false)
								{
									goto IL_0061;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								Yoc15Rshk757Qlmn9v9N();
								if (!qfFYtCsh4HtbwD7cvXeG())
								{
									num3 = 8;
									if (Yoc15Rshk757Qlmn9v9N())
									{
										return;
									}
								}
								else
								{
									num3 = 2;
									if (Yoc15Rshk757Qlmn9v9N())
									{
									}
								}
							}
							goto IL_00fd;
							IL_0061:
							_003C_003Eu__1 = default;
							goto IL_00b3;
							IL_00fd:
							while (true)
							{
								switch (num3)
								{
								case 2:
								case 5:
									break;
								case 4:
									return;
								case 6:
								case 8:
									goto IL_00b3;
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									if (qfFYtCsh4HtbwD7cvXeG())
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 9;
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 9:
									awaiter.GetResult();
									goto end_IL_003e;
								}
								break;
							}
							goto IL_0061;
							IL_00b3:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							goto IL_00fd;
							end_IL_003e:;
						}
						catch (Exception ex)
						{
							uwO95UshyWajmhk509NH(cvsInSight.M9sxU718oA, LogLevel.Error, iypMgishmIoE00e9L6NR(50352), ex);
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
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					cvsInSight = _003C_003E4__this;
					goto case 0;
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
		internal static object ljMwksshfbgBSJkAfJlI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).InitializeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AQdaOHshFwKUaZKZaCfo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iypMgishmIoE00e9L6NR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uwO95UshyWajmhk509NH(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qfFYtCsh4HtbwD7cvXeG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yoc15Rshk757Qlmn9v9N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private int KgZx78PC4V;

	private static int JkMxm33aCD;

	private static readonly Hashtable KHLxnZX5vu;

	private static readonly Hashtable ow5x9AvbBI;

	private readonly ILogger M9sxU718oA;

	private IPAddress xqgx0qiAEY;

	private string Xxlxww20tn;

	private int eubxRGhOdU;

	private string jlfxsQHPFU;

	private string XNnx6nbV7X;

	private string xS4xHwV7ol;

	private string BmtxK2pf6u;

	private bool PwDxEa89dP;

	private TaskCompletionSource<object> n1oxQw9yS5;

	private bool wMRxNZ65iG;

	private CvsSensor hVIxiSJ47j;

	private CvsCogSocket NK8xdPcxcK;

	private bool sYAxu8HX06;

	private CvsInSightState fIQxGWeG7D;

	private CvsPropSheet afHxDIlTiO;

	private readonly CvsSheetInfo i1Uxe9iPoR;

	private readonly ImageConfig mGexS0PTgN;

	private CvsInSightLanguage IPdxrcTulv;

	private readonly UndoHandler b7SxCkd8vk;

	private EventManager Xcsx2Wv5TK;

	private readonly object E7uxyolAY3;

	private int Ci8xV3RoU8;

	private IResultBuilder JjLxvIXWu9;

	private ILiveAcqResultBuilder BsGxZoGsDw;

	private readonly ConcurrentDictionary<string, List<TaskCompletionSource<bool>>> MQZx8aduyT;

	[CompilerGenerated]
	private CvsStateChangedEventHandler U1Wxza847C;

	[CompilerGenerated]
	private EventHandler aqRFPxGJjk;

	[CompilerGenerated]
	private EventHandler sqlFIcAHZn;

	[CompilerGenerated]
	private EventHandler aoVF1gx1Ae;

	[CompilerGenerated]
	private CvsConnectCompletedEventHandler nUvFxguTcd;

	[CompilerGenerated]
	private UndoEventHandler llwFFecGkV;

	[CompilerGenerated]
	private UndoEventHandlerAsync lxeFb5Feul;

	[CompilerGenerated]
	private EventHandler W2rFaM41K3;

	[CompilerGenerated]
	private EventHandler re0FOgJbH6;

	[CompilerGenerated]
	private EventHandler gByFpCJOLM;

	private ILiveModeService OfIFhHSGSS;

	private IOnlineOfflineService XI8F49E6cO;

	private SynchronizationContext rcTFlgyD7e;

	private SynchronizationContext z6JFgOvOTo;

	private int t3vFq4bxtU;

	[CompilerGenerated]
	private Func<CvsCogShape, bool> pEpFT3h823;

	public int mHmiHttpPort;

	[CompilerGenerated]
	private ICvsConnectedUser lMVFBhe7tn;

	internal SynchronizationContext MainThreadContext
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (rcTFlgyD7e != null)
			{
				return rcTFlgyD7e;
			}
			LwLU9XvqDvUGkomF6nU(M9sxU718oA, KIpH2mvUhpjL1pAttMk(6520));
			return z6JFgOvOTo;
		}
	}

	internal int MainThreadID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t3vFq4bxtU;
		}
	}

	public CvsInSightState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!PwDxEa89dP)
			{
				return fIQxGWeG7D;
			}
			return CvsInSightState.NotConnected;
		}
	}

	public Func<CvsCogShape, bool> GraphicsLayerFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pEpFT3h823;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pEpFT3h823 = value;
		}
	}

	public bool HasSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (CogSocket != null)
			{
				return B2DV3AvBZ1WOh85CkVu(CogSocket.Sheet);
			}
			return false;
		}
	}

	public IPAddress RemoteIPAddress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xqgx0qiAEY;
		}
	}

	public string RemoteIPAddressString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Xxlxww20tn;
		}
	}

	public int Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eubxRGhOdU;
		}
	}

	public int HmiHttpPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mHmiHttpPort;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mHmiHttpPort = value;
		}
	}

	public string CameraPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jlfxsQHPFU;
		}
	}

	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xS4xHwV7ol;
		}
	}

	public string Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BmtxK2pf6u;
		}
	}

	public CvsInSightLanguage Language
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IPdxrcTulv;
		}
	}

	internal IOnlineOfflineService OnlineOfflineService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XI8F49E6cO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					if (XI8F49E6cO != null)
					{
						num = 5;
						break;
					}
					return;
				case 5:
					aq5mLNvcomCnj2lExdF(XI8F49E6cO, new EventHandler(Ohrx4ie0Zi));
					num = 7;
					if (sKFnQlvHS3sKEJ7bgEW())
					{
					}
					break;
				case 2:
				case 4:
					XI8F49E6cO = value;
					goto default;
				case 1:
					if (XI8F49E6cO != null)
					{
						num = 6;
						break;
					}
					goto case 2;
				case 6:
					fFlD16vj3hfueKFmJtb(XI8F49E6cO, new EventHandler(Ohrx4ie0Zi));
					_ = 1;
					num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 4 : 0);
					break;
				case 7:
					return;
				}
			}
		}
	}

	internal ILiveModeService LiveModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OfIFhHSGSS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_00b5;
			IL_001a:
			WBUQoGv2uYdb91NgdSs(OfIFhHSGSS, new EventHandler(M37xhaEHBT));
			num = 4;
			goto IL_00b5;
			IL_00b5:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 8:
					if (OfIFhHSGSS != null)
					{
						sKFnQlvHS3sKEJ7bgEW();
						num = ((!ciof1svv4RqcPuxU6WK()) ? 5 : 0);
						continue;
					}
					goto case 4;
				case 4:
					OfIFhHSGSS = value;
					goto case 3;
				case 6:
					OfIFhHSGSS.IsLiveAcquisitionChanged += M37xhaEHBT;
					num = 9;
					continue;
				case 3:
				case 5:
					if (BsGxZoGsDw != null)
					{
						goto case 7;
					}
					goto case 2;
				default:
					num = 7;
					continue;
				case 7:
					zPjulpvWKYji9qe0YQO(BsGxZoGsDw, value);
					num = 2;
					continue;
				case 2:
					if (OfIFhHSGSS != null)
					{
						num = 6;
						continue;
					}
					return;
				case 9:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public bool IsLiveAcquisition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ILiveModeService liveModeService = LiveModeService;
			if (liveModeService == null)
			{
				return false;
			}
			return fiHJDjv7PasYHdddLED(liveModeService);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (LiveModeService == null)
			{
				throw new CvsNotConnectedException(Resources.InternalError);
			}
			LiveModeService.IsLiveAcquisition = value;
		}
	}

	public bool IsOnline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IOnlineOfflineService onlineOfflineService = OnlineOfflineService;
			if (onlineOfflineService == null)
			{
				return false;
			}
			return skDMP5vtE3RimLqh78x(onlineOfflineService);
		}
	}

	public CvsResultSet Results
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!ciof1svv4RqcPuxU6WK()) ? 1 : 3);
			IResultBuilder resultBuilder = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (State != CvsInSightState.NotConnected)
					{
						goto default;
					}
					goto case 5;
				default:
					if (resultBuilder == null)
					{
						num = 5;
						break;
					}
					return (CvsResultSet)ffXCNQvCkap721QhKJq(resultBuilder);
				case 0:
				case 3:
					resultBuilder = ResultBuilder;
					num = 4;
					break;
				case 5:
					return new CvsResultSet();
				}
			}
		}
	}

	public CvsSensor Sensor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hVIxiSJ47j;
		}
	}

	public CvsSheetInfo SheetInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i1Uxe9iPoR;
		}
	}

	public CvsCogSocket CogSocket
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NK8xdPcxcK;
		}
	}

	public CvsPropSheet PropSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return afHxDIlTiO;
		}
	}

	public CvsFunctionTable FunctionTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NK8xdPcxcK?.FunctionTable;
		}
	}

	public CvsProcessorConstants ProcessorConstants
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NK8xdPcxcK?.ProcessorConstants;
		}
	}

	public ICvsConnectedUser ConnectedUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lMVFBhe7tn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lMVFBhe7tn = value;
		}
	}

	public UndoHandler UndoHandler
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b7SxCkd8vk;
		}
	}

	bool IFilmstripPlayer.CanPlay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (CogSocket != null)
			{
				return State != CvsInSightState.NotConnected;
			}
			return false;
		}
	}

	bool IFilmstripRecorder.IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return State == CvsInSightState.Connected;
		}
	}

	string IFilmstripRecorder.SheetId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CogSocket?.Sheet?.ID;
		}
	}

	internal bool AbortConnection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sYAxu8HX06;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sYAxu8HX06 = value;
		}
	}

	internal EventManager EventManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Xcsx2Wv5TK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Xcsx2Wv5TK = value;
		}
	}

	private IResultBuilder ResultBuilder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!IsLiveAcquisition)
			{
				return JjLxvIXWu9;
			}
			return BsGxZoGsDw;
		}
	}

	public event CvsStateChangedEventHandler StateChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsStateChangedEventHandler cvsStateChangedEventHandler = default;
			CvsStateChangedEventHandler cvsStateChangedEventHandler2 = default;
			CvsStateChangedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					if ((object)cvsStateChangedEventHandler == cvsStateChangedEventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 5:
					cvsStateChangedEventHandler = U1Wxza847C;
					_ = 1;
					num = (sKFnQlvHS3sKEJ7bgEW() ? 4 : 6);
					break;
				default:
					cvsStateChangedEventHandler = Interlocked.CompareExchange(ref U1Wxza847C, value2, cvsStateChangedEventHandler2);
					num = 2;
					if (sKFnQlvHS3sKEJ7bgEW())
					{
					}
					break;
				case 1:
				case 6:
					cvsStateChangedEventHandler2 = cvsStateChangedEventHandler;
					num = 0;
					if (ciof1svv4RqcPuxU6WK())
					{
						break;
					}
					goto case 0;
				case 0:
					value2 = (CvsStateChangedEventHandler)oDSSOfvV8c26tAsakkX(cvsStateChangedEventHandler2, value);
					goto default;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_007e;
			IL_001a:
			CvsStateChangedEventHandler cvsStateChangedEventHandler = default;
			CvsStateChangedEventHandler cvsStateChangedEventHandler2 = default;
			if ((object)cvsStateChangedEventHandler != cvsStateChangedEventHandler2)
			{
				goto IL_0035;
			}
			num = 7;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
			}
			goto IL_007e;
			IL_0035:
			cvsStateChangedEventHandler2 = cvsStateChangedEventHandler;
			num = 1;
			goto IL_007e;
			IL_007e:
			CvsStateChangedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					break;
				case 2:
					goto IL_0035;
				case 0:
				case 3:
					cvsStateChangedEventHandler = Interlocked.CompareExchange(ref U1Wxza847C, value2, cvsStateChangedEventHandler2);
					break;
				case 1:
					value2 = (CvsStateChangedEventHandler)Xdj44FvAfZfxn5nUpcj(cvsStateChangedEventHandler2, value);
					goto default;
				default:
					sKFnQlvHS3sKEJ7bgEW();
					if (!ciof1svv4RqcPuxU6WK())
					{
						num = 5;
						continue;
					}
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					cvsStateChangedEventHandler = U1Wxza847C;
					num = 2;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public event EventHandler IsLiveAcquisitionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (sKFnQlvHS3sKEJ7bgEW() ? 6 : 5);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			do
			{
				IL_0043:
				switch (num)
				{
				case 3:
					value2 = (EventHandler)oDSSOfvV8c26tAsakkX(eventHandler2, value);
					break;
				default:
					num = 4;
					goto IL_0043;
				case 0:
				case 5:
					eventHandler = aqRFPxGJjk;
					goto case 1;
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					num = 3;
					goto IL_0043;
				case 2:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (ciof1svv4RqcPuxU6WK())
						{
							goto IL_0043;
						}
						break;
					}
					goto case 1;
				case 4:
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref aqRFPxGJjk, value2, eventHandler2);
				num = 2;
			}
			while (ciof1svv4RqcPuxU6WK());
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					eventHandler = eventHandler2;
					num = 2;
					break;
				case 2:
					value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler, value);
					goto default;
				default:
					sKFnQlvHS3sKEJ7bgEW();
					if (ciof1svv4RqcPuxU6WK())
					{
						num = 6;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					num = 5;
					break;
				case 4:
				case 5:
					if ((object)eventHandler2 != eventHandler)
					{
						goto case 0;
					}
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					eventHandler2 = aqRFPxGJjk;
					num = 0;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
				case 6:
					eventHandler2 = Interlocked.CompareExchange(ref aqRFPxGJjk, value2, eventHandler);
					goto case 4;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler IsOnlineChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!ciof1svv4RqcPuxU6WK())
			{
				goto IL_001e;
			}
			goto IL_0078;
			IL_001e:
			EventHandler eventHandler = sqlFIcAHZn;
			num = 5;
			goto IL_0078;
			IL_0078:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 3:
				case 6:
					eventHandler = Interlocked.CompareExchange(ref sqlFIcAHZn, value2, eventHandler2);
					goto case 2;
				case 5:
					eventHandler2 = eventHandler;
					num = 0;
					continue;
				case 0:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto default;
				default:
					sKFnQlvHS3sKEJ7bgEW();
					if (!ciof1svv4RqcPuxU6WK())
					{
						num = 2;
						continue;
					}
					num = 6;
					if (ciof1svv4RqcPuxU6WK())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (!sKFnQlvHS3sKEJ7bgEW())
						{
							continue;
						}
						return;
					}
					goto case 5;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
				goto IL_001e;
			}
			goto IL_0071;
			IL_00a6:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = Interlocked.CompareExchange(ref sqlFIcAHZn, value2, eventHandler2);
			num = 0;
			if (true)
			{
				goto IL_0071;
			}
			goto IL_00c0;
			IL_00c0:
			eventHandler2 = eventHandler;
			goto IL_0052;
			IL_0052:
			value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler2, value);
			goto IL_00a6;
			IL_001e:
			if ((object)eventHandler == eventHandler2)
			{
				num = 7;
				if (!ciof1svv4RqcPuxU6WK())
				{
					goto IL_0035;
				}
				goto IL_0071;
			}
			goto IL_00c0;
			IL_0071:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 4:
					goto IL_0035;
				case 2:
				case 6:
					goto IL_0052;
				default:
					num = 5;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						continue;
					}
					goto IL_00a6;
				case 5:
					goto IL_00a6;
				case 1:
				case 3:
					goto IL_00c0;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0035:
			eventHandler = sqlFIcAHZn;
			_ = 0;
			num = ((!ciof1svv4RqcPuxU6WK()) ? 6 : 3);
			goto IL_0071;
		}
	}

	public event EventHandler ResultsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 1 : 5);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					eventHandler2 = eventHandler;
					num = 4;
					continue;
				case 0:
				case 1:
					eventHandler = aoVF1gx1Ae;
					num = 2;
					continue;
				case 4:
					value2 = (EventHandler)oDSSOfvV8c26tAsakkX(eventHandler2, value);
					break;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (true)
						{
							continue;
						}
						break;
					}
					goto case 2;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref aoVF1gx1Ae, value2, eventHandler2);
				num = 6;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
				goto IL_001e;
			}
			goto IL_008b;
			IL_005b:
			EventHandler eventHandler = aoVF1gx1Ae;
			num = 5;
			goto IL_008b;
			IL_004d:
			EventHandler eventHandler2 = eventHandler;
			num = 2;
			if (1 == 0)
			{
				goto IL_005b;
			}
			goto IL_008b;
			IL_008b:
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref aoVF1gx1Ae, value2, eventHandler2);
					break;
				case 5:
					goto IL_004d;
				case 6:
					goto IL_005b;
				case 2:
					value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler2, value);
					goto default;
				default:
					sKFnQlvHS3sKEJ7bgEW();
					num = (ciof1svv4RqcPuxU6WK() ? 1 : 0);
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_001e:
			if ((object)eventHandler != eventHandler2)
			{
				goto IL_004d;
			}
			num = 7;
			goto IL_008b;
		}
	}

	public event CvsConnectCompletedEventHandler ConnectCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (ciof1svv4RqcPuxU6WK())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
					goto IL_00b3;
				}
			}
			goto IL_0043;
			IL_0043:
			CvsConnectCompletedEventHandler value2 = default;
			CvsConnectCompletedEventHandler cvsConnectCompletedEventHandler = default;
			CvsConnectCompletedEventHandler cvsConnectCompletedEventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					value2 = (CvsConnectCompletedEventHandler)Delegate.Combine(cvsConnectCompletedEventHandler, value);
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
				case 4:
					if ((object)cvsConnectCompletedEventHandler2 == cvsConnectCompletedEventHandler)
					{
						num = 7;
						continue;
					}
					goto case 6;
				case 6:
					cvsConnectCompletedEventHandler = cvsConnectCompletedEventHandler2;
					num = 1;
					continue;
				case 5:
					cvsConnectCompletedEventHandler2 = Interlocked.CompareExchange(ref nUvFxguTcd, value2, cvsConnectCompletedEventHandler);
					goto case 3;
				case 0:
				case 2:
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_00b3;
			IL_00b3:
			cvsConnectCompletedEventHandler2 = nUvFxguTcd;
			num = 6;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
			}
			goto IL_0043;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKFnQlvHS3sKEJ7bgEW();
			int num;
			if (ciof1svv4RqcPuxU6WK())
			{
				num = 6;
				if (!ciof1svv4RqcPuxU6WK())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
			}
			goto IL_005b;
			IL_003c:
			CvsConnectCompletedEventHandler cvsConnectCompletedEventHandler = default;
			CvsConnectCompletedEventHandler value2 = (CvsConnectCompletedEventHandler)Xdj44FvAfZfxn5nUpcj(cvsConnectCompletedEventHandler, value);
			goto IL_00ab;
			IL_005b:
			CvsConnectCompletedEventHandler cvsConnectCompletedEventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 3:
					goto IL_003c;
				default:
					num = 5;
					continue;
				case 0:
				case 6:
					cvsConnectCompletedEventHandler2 = nUvFxguTcd;
					break;
				case 5:
					goto IL_00ab;
				case 2:
					if ((object)cvsConnectCompletedEventHandler2 == cvsConnectCompletedEventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			cvsConnectCompletedEventHandler = cvsConnectCompletedEventHandler2;
			num = 3;
			if (false)
			{
				goto IL_003c;
			}
			goto IL_005b;
			IL_00ab:
			cvsConnectCompletedEventHandler2 = Interlocked.CompareExchange(ref nUvFxguTcd, value2, cvsConnectCompletedEventHandler);
			num = 2;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
			}
			goto IL_005b;
		}
	}

	public event UndoEventHandler UndoChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!sKFnQlvHS3sKEJ7bgEW())
			{
			}
			UndoEventHandler undoEventHandler2 = default;
			UndoEventHandler undoEventHandler = default;
			UndoEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoEventHandler2 = llwFFecGkV;
					num = 3;
					break;
				case 1:
				case 4:
					if ((object)undoEventHandler2 == undoEventHandler)
					{
						num = 7;
						break;
					}
					goto case 3;
				case 6:
					undoEventHandler2 = Interlocked.CompareExchange(ref llwFFecGkV, value2, undoEventHandler);
					goto case 1;
				case 3:
					undoEventHandler = undoEventHandler2;
					_ = 1;
					num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 0);
					break;
				case 0:
				case 2:
					value2 = (UndoEventHandler)oDSSOfvV8c26tAsakkX(undoEventHandler, value);
					goto case 6;
				default:
					num = 6;
					if (1 == 0)
					{
						return;
					}
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoEventHandler undoEventHandler2 = default;
			UndoEventHandler undoEventHandler = default;
			UndoEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					if ((object)undoEventHandler2 == undoEventHandler)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					undoEventHandler = undoEventHandler2;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					undoEventHandler2 = Interlocked.CompareExchange(ref llwFFecGkV, value2, undoEventHandler);
					num = 5;
					continue;
				case 6:
					value2 = (UndoEventHandler)Delegate.Remove(undoEventHandler, value);
					goto default;
				case 0:
					break;
				case 7:
					return;
				}
				do
				{
					undoEventHandler2 = llwFFecGkV;
					sKFnQlvHS3sKEJ7bgEW();
					if (!ciof1svv4RqcPuxU6WK())
					{
						num = 4;
						continue;
					}
					num = 2;
					break;
				}
				while (1 == 0);
			}
		}
	}

	public event UndoEventHandlerAsync UndoChangedAsync
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoEventHandlerAsync undoEventHandlerAsync = default;
			UndoEventHandlerAsync value2 = default;
			UndoEventHandlerAsync undoEventHandlerAsync2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					undoEventHandlerAsync = Interlocked.CompareExchange(ref lxeFb5Feul, value2, undoEventHandlerAsync2);
					goto case 3;
				case 5:
					value2 = (UndoEventHandlerAsync)oDSSOfvV8c26tAsakkX(undoEventHandlerAsync2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 1:
				case 2:
					undoEventHandlerAsync2 = undoEventHandlerAsync;
					num = 5;
					break;
				case 3:
				case 4:
					if ((object)undoEventHandlerAsync == undoEventHandlerAsync2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 0:
					undoEventHandlerAsync = lxeFb5Feul;
					sKFnQlvHS3sKEJ7bgEW();
					num = (ciof1svv4RqcPuxU6WK() ? 2 : 3);
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!ciof1svv4RqcPuxU6WK()) ? 6 : 4);
			UndoEventHandlerAsync undoEventHandlerAsync2 = default;
			UndoEventHandlerAsync undoEventHandlerAsync = default;
			UndoEventHandlerAsync value2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					if ((object)undoEventHandlerAsync2 == undoEventHandlerAsync)
					{
						num = 7;
						if (sKFnQlvHS3sKEJ7bgEW())
						{
						}
						continue;
					}
					break;
				case 0:
				case 4:
					undoEventHandlerAsync2 = lxeFb5Feul;
					num = 2;
					continue;
				case 1:
					value2 = (UndoEventHandlerAsync)Xdj44FvAfZfxn5nUpcj(undoEventHandlerAsync, value);
					goto default;
				default:
					undoEventHandlerAsync2 = Interlocked.CompareExchange(ref lxeFb5Feul, value2, undoEventHandlerAsync);
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					break;
				case 7:
					return;
				}
				undoEventHandlerAsync = undoEventHandlerAsync2;
				num = 1;
			}
		}
	}

	public event EventHandler NamedEditCellValueChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKFnQlvHS3sKEJ7bgEW();
			int num;
			if (ciof1svv4RqcPuxU6WK())
			{
				num = 5;
				if (!ciof1svv4RqcPuxU6WK())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_005e;
			IL_005e:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 4:
					break;
				case 1:
					value2 = (EventHandler)oDSSOfvV8c26tAsakkX(eventHandler2, value);
					goto case 2;
				default:
					num = 2;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						continue;
					}
					goto case 2;
				case 2:
					eventHandler = Interlocked.CompareExchange(ref W2rFaM41K3, value2, eventHandler2);
					break;
				case 0:
				case 5:
					eventHandler = W2rFaM41K3;
					num = 6;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						continue;
					}
					goto IL_00c8;
				case 6:
					goto IL_00c8;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_00c8:
			eventHandler2 = eventHandler;
			num = 1;
			goto IL_005e;
			IL_002e:
			if ((object)eventHandler == eventHandler2)
			{
				num = 7;
				goto IL_005e;
			}
			goto IL_00c8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 2:
					eventHandler2 = W2rFaM41K3;
					num = 1;
					break;
				case 1:
					eventHandler = eventHandler2;
					num = 6;
					break;
				case 6:
					value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler, value);
					goto default;
				default:
					ciof1svv4RqcPuxU6WK();
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 0:
				case 3:
					eventHandler2 = Interlocked.CompareExchange(ref W2rFaM41K3, value2, eventHandler);
					goto case 4;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler ReadyForResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					eventHandler = re0FOgJbH6;
					_ = 1;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					}
					num = 6;
					break;
				case 0:
				case 1:
					eventHandler2 = eventHandler;
					goto case 2;
				case 2:
				case 6:
					value2 = (EventHandler)oDSSOfvV8c26tAsakkX(eventHandler2, value);
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					eventHandler = Interlocked.CompareExchange(ref re0FOgJbH6, value2, eventHandler2);
					num = 4;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						break;
					}
					goto case 4;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 0;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ciof1svv4RqcPuxU6WK();
			int num;
			if (!sKFnQlvHS3sKEJ7bgEW())
			{
				num = 5;
				if (!ciof1svv4RqcPuxU6WK())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 6;
				if (!ciof1svv4RqcPuxU6WK())
				{
					goto IL_0059;
				}
			}
			goto IL_00a3;
			IL_002e:
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = eventHandler2;
			num = 3;
			if (false)
			{
				goto IL_003c;
			}
			goto IL_00a3;
			IL_006c:
			EventHandler value2 = default;
			eventHandler2 = Interlocked.CompareExchange(ref re0FOgJbH6, value2, eventHandler);
			num = 2;
			goto IL_00a3;
			IL_00a3:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 6:
					break;
				case 0:
				case 5:
					goto IL_003c;
				case 2:
					goto IL_0059;
				case 4:
					goto IL_006c;
				case 3:
					value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler, value);
					goto IL_006c;
				default:
					num = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_003c:
			eventHandler2 = re0FOgJbH6;
			goto IL_002e;
			IL_0059:
			if ((object)eventHandler2 != eventHandler)
			{
				goto IL_002e;
			}
			num = 7;
			if (1 == 0)
			{
				goto IL_006c;
			}
			goto IL_00a3;
		}
	}

	public event EventHandler DisplayChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ciof1svv4RqcPuxU6WK();
			int num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 3);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					eventHandler2 = gByFpCJOLM;
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						break;
					}
					goto case 2;
				case 5:
					eventHandler2 = Interlocked.CompareExchange(ref gByFpCJOLM, value2, eventHandler);
					goto case 1;
				case 2:
					eventHandler = eventHandler2;
					num = 6;
					break;
				case 6:
					value2 = (EventHandler)oDSSOfvV8c26tAsakkX(eventHandler, value);
					goto case 5;
				default:
					num = 5;
					if (1 == 0)
					{
						return;
					}
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (ciof1svv4RqcPuxU6WK())
			{
				num = 2;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
			}
			else
			{
				num = 4;
			}
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 5:
					value2 = (EventHandler)Xdj44FvAfZfxn5nUpcj(eventHandler2, value);
					goto default;
				case 1:
					eventHandler2 = eventHandler;
					num = 5;
					break;
				default:
					eventHandler = Interlocked.CompareExchange(ref gByFpCJOLM, value2, eventHandler2);
					num = 6;
					break;
				case 0:
				case 2:
					eventHandler = gByFpCJOLM;
					num = 1;
					if (false)
					{
						return;
					}
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsInSight()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		while (true)
		{
			switch (num)
			{
			case 7:
				BmtxK2pf6u = string.Empty;
				num = 6;
				continue;
			case 17:
				cRCxXj8JLN();
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				b7SxCkd8vk = new UndoHandler(this);
				num = 18;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 16:
				Xxlxww20tn = (string)KIpH2mvUhpjL1pAttMk(6502);
				num = 14;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto case 11;
			case 11:
				YPlXJZvDI9WoZpWYwBw();
				sKFnQlvHS3sKEJ7bgEW();
				num = ((!ciof1svv4RqcPuxU6WK()) ? 16 : 12);
				continue;
			case 6:
				mGexS0PTgN = new ImageConfig();
				num = 3;
				continue;
			case 19:
				LiveModeService = new ControllerLiveModeService(this);
				num = 0;
				continue;
			case 13:
				KgZx78PC4V = JkMxm33aCD;
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				XNnx6nbV7X = string.Empty;
				xS4xHwV7ol = string.Empty;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 14;
			case 14:
				eubxRGhOdU = 8082;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 18;
			case 18:
				i1Uxe9iPoR = new CvsSheetInfo(this);
				num = 17;
				continue;
			case 3:
				E7uxyolAY3 = new object();
				num = 4;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				continue;
			case 9:
				jlfxsQHPFU = string.Empty;
				num = 8;
				continue;
			case 15:
				JkMxm33aCD++;
				num = 19;
				continue;
			case 10:
				hVIxiSJ47j = new CvsSensor(this);
				num = 20;
				continue;
			case 1:
			case 12:
				M9sxU718oA = LogManager.GetLogger<CvsInSight>();
				xqgx0qiAEY = IPAddress.Parse(kgbOBx7BanbFa22Hp9.ol99ukmDA(6502));
				goto case 2;
			case 4:
				MQZx8aduyT = new ConcurrentDictionary<string, List<TaskCompletionSource<bool>>>();
				mHmiHttpPort = 80;
				hpSwTpvTLl3jjnM8q9R(this);
				goto case 13;
			default:
				num = 13;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 20:
				return;
			}
			OnlineOfflineService = null;
			ConnectedUser = new NullUser();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			AbortConnection = true;
			TluxMbchkd();
		}
		finally
		{
			GC.SuppressFinalize(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NyVxOhfaap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ciof1svv4RqcPuxU6WK();
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				t3vFq4bxtU = QHCEWMvdtJ8w8FaqfIa(Thread.CurrentThread);
				num = 5;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					continue;
				}
				goto case 2;
			case 2:
				rcTFlgyD7e = (SynchronizationContext)LCVRoTvilF3sqtQnL9t();
				return;
			default:
				return;
			case 1:
				return;
			case 5:
				break;
			case 6:
				return;
			}
			do
			{
				if (SynchronizationContext.Current == null)
				{
					z6JFgOvOTo = new WindowsFormsSynchronizationContext();
					num = 6;
					continue;
				}
				num = 2;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ValidateCellName(CvsCellLocation cell, string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YPY2jVv5GfhRAaGTqfB(cell, name, EsvxsHvKEXH6Wic6pfV(Results), Sensor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic ConvertToCvsGraphic(CvsCellLocation location, CvsCogEditingObject obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		CvsGraphic result = default;
		if (0 == 0)
		{
			CvsCogEditingPoint editPoint = default;
			CvsCogEditingCompositeRegion editComposite2 = default;
			CvsCogEditingCircle editCircle = default;
			CvsCogEditingAnnulus editAnn = default;
			CvsCogEditingOffset editOffset = default;
			CvsCogEditingCross editCross = default;
			CvsCogEditingLine editLine = default;
			CvsCogEditingPolygon editPolygon = default;
			CvsCogEditingBox3D editBox = default;
			CvsCogEditingPolyline editComposite = default;
			CvsCogEditingMaskedRegion maskedRegion = default;
			CvsCogEditingRegion editRegion2 = default;
			while (true)
			{
				switch (num)
				{
				case 21:
				case 32:
					result = new CvsGraphicPoint(location, editPoint);
					num = 11;
					continue;
				case 1:
					result = new CvsGraphicComposite(location, editComposite2, mustBeExtrudeable: false);
					num = 22;
					if (0 == 0)
					{
						continue;
					}
					goto case 23;
				case 23:
					editCircle = (CvsCogEditingCircle)obj;
					num = 7;
					continue;
				case 33:
					editAnn = (CvsCogEditingAnnulus)obj;
					num = 10;
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						continue;
					}
					break;
				case 19:
				case 25:
					result = new CvsGraphicOffset(location, editOffset);
					num = 27;
					continue;
				case 30:
					editCross = (CvsCogEditingCross)obj;
					num = 8;
					continue;
				case 5:
					result = new CvsGraphicLine(location, editLine);
					num = 9;
					continue;
				case 20:
					editPolygon = (CvsCogEditingPolygon)obj;
					num = 18;
					continue;
				case 31:
					result = new CvsGraphicBox3D(location, editBox);
					num = 24;
					if (ciof1svv4RqcPuxU6WK())
					{
						continue;
					}
					break;
				case 10:
					result = new CvsGraphicAnnulus(location, editAnn);
					break;
				case 6:
					editComposite = (CvsCogEditingPolyline)obj;
					num = 35;
					continue;
				case 29:
					editOffset = (CvsCogEditingOffset)obj;
					ciof1svv4RqcPuxU6WK();
					if (!sKFnQlvHS3sKEJ7bgEW())
					{
						num = 25;
						continue;
					}
					num = 32;
					if (true)
					{
						continue;
					}
					goto case 26;
				case 34:
					editComposite2 = (CvsCogEditingCompositeRegion)obj;
					num = 1;
					continue;
				case 12:
					maskedRegion = (CvsCogEditingMaskedRegion)obj;
					num = 17;
					if (0 == 0)
					{
						continue;
					}
					goto case 35;
				case 35:
					result = new CvsGraphicPolylinePath(location, editComposite);
					break;
				case 2:
					if (!(obj is CvsCogEditingAnnulus))
					{
						if (!(obj is CvsCogEditingCircle))
						{
							if (obj is CvsCogEditingCompositeRegion)
							{
								num = 34;
								continue;
							}
							if (obj is CvsCogEditingCross)
							{
								num = 30;
								if (0 == 0)
								{
									continue;
								}
								goto case 19;
							}
							if (obj is CvsCogEditingFixture)
							{
								CvsCogEditingFixture editFixture = (CvsCogEditingFixture)obj;
								result = new CvsGraphicFixture(location, editFixture);
								num = 16;
								continue;
							}
							if (obj is CvsCogEditingLine)
							{
								editLine = (CvsCogEditingLine)obj;
								num = 5;
								continue;
							}
							if (obj is CvsCogEditingMaskedRegion)
							{
								num = 12;
								continue;
							}
							if (obj is CvsCogEditingOffset)
							{
								goto case 29;
							}
							if (!(obj is CvsCogEditingPoint))
							{
								if (obj is CvsCogEditingPolygon)
								{
									num = 20;
									continue;
								}
								if (obj is CvsCogEditingPolyline)
								{
									num = 6;
									continue;
								}
								if (obj is CvsCogEditingRectangle)
								{
									CvsCogEditingRectangle editRect = (CvsCogEditingRectangle)obj;
									result = new CvsGraphicRegion(location, editRect);
									num = 0;
									continue;
								}
								if (obj is CvsCogEditingRegion)
								{
									num = 4;
									continue;
								}
								if (!(obj is CvsCogEditingBox3D))
								{
									if (!(obj is CvsCogEditingRegion3D))
									{
										_ = obj is CvsCogEditingBlobs;
										num = 36;
										continue;
									}
									CvsCogEditingRegion3D editRegion = (CvsCogEditingRegion3D)obj;
									result = new CvsGraphicRegion3D(location, editRegion);
									num = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 18;
								}
								editBox = (CvsCogEditingBox3D)obj;
								num = 31;
								if (!sKFnQlvHS3sKEJ7bgEW())
								{
									continue;
								}
								goto case 4;
							}
							editPoint = (CvsCogEditingPoint)obj;
							goto case 21;
						}
						num = 23;
						if (true)
						{
							continue;
						}
						goto case 6;
					}
					num = 33;
					continue;
				case 17:
					result = new CvsGraphicMaskedRegion(location, maskedRegion);
					break;
				default:
					num = 29;
					continue;
				case 8:
					result = new CvsGraphicCross(location, editCross);
					num = 28;
					continue;
				case 15:
					result = null;
					num = 2;
					continue;
				case 7:
					result = new CvsGraphicCircle(location, editCircle);
					num = 3;
					if (true)
					{
						continue;
					}
					break;
				case 18:
					result = new CvsGraphicPolygon(location, editPolygon);
					num = 14;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 26:
					result = new CvsGraphicRegion(location, editRegion2);
					break;
				case 4:
					editRegion2 = (CvsCogEditingRegion)obj;
					num = 26;
					continue;
				case 36:
					throw new NotSupportedException();
				case 0:
				case 3:
				case 9:
				case 11:
				case 13:
				case 14:
				case 16:
				case 22:
				case 24:
				case 27:
				case 28:
					break;
				}
				break;
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetDefaultGraphicAsync_003Ed__131))]
	public Task<CvsCogEditInfo> GetDefaultGraphicAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetDefaultGraphicAsync_003Ed__131 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogEditInfo>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.location = location;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ConnectAsync(Uri rootCogSocketUri, Uri httpUri, string cameraPath, ICogSocketAcqFactory acqFactory, NetworkCredential credentials = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConnectAsync(rootCogSocketUri, httpUri, cameraPath, cameraPath, acqFactory, credentials);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ConnectAsync(Uri rootCogSocketUri, Uri httpUri, string cameraPath, string sheetPath, ICogSocketAcqFactory acqFactory, NetworkCredential credentials = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Connect(rootCogSocketUri, httpUri, cameraPath, sheetPath, credentials?.UserName, (string)((credentials != null) ? zW1yINvoHJtYF024KEJ(credentials) : null), asynchronous: true, acqFactory);
		return n1oxQw9yS5?.Task ?? throw new InvalidOperationException((string)teUFulvPHLbMIW6cfDx());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Connect(Uri rootCogSocketUri, Uri httpUri, string cameraPath, string username, string password, bool asynchronous)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Connect(rootCogSocketUri, httpUri, cameraPath, cameraPath, username, password, asynchronous, new CvsCogSocketAcqFactory());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConnectWithFactory(Uri rootCogSocketUri, Uri httpUri, string cameraPath, string sheetPath, string username, string password, bool asynchronous, ICogSocketAcqFactory factory)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Connect(rootCogSocketUri, httpUri, cameraPath, sheetPath, username, password, asynchronous, factory);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Connect(Uri rootCogSocketUri, Uri httpUri, string cameraPath, string sheetPath, string username, string password, bool asynchronous, ICogSocketAcqFactory acqFactory)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ciof1svv4RqcPuxU6WK();
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 10);
		_003C_003Ec__DisplayClass136_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				obj.acqFactory = acqFactory;
				num = 2;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				continue;
			case 1:
			case 9:
				if (nUvFxguTcd == null)
				{
					num = 5;
					continue;
				}
				goto IL_00af;
			case 7:
				obj._003C_003E4__this = this;
				num = 12;
				continue;
			case 0:
			case 10:
				obj = new _003C_003Ec__DisplayClass136_0();
				num = 7;
				continue;
			case 3:
				obj.httpUri = httpUri;
				obj.cameraPath = cameraPath;
				num = 6;
				continue;
			case 11:
				obj.password = password;
				num = 8;
				continue;
			case 5:
				throw new InvalidOperationException(Resources.NeedConnectCompleted);
			case 6:
				obj.sheetPath = sheetPath;
				num = 4;
				continue;
			case 12:
				obj.rootCogSocketUri = rootCogSocketUri;
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				if (asynchronous)
				{
					goto case 1;
				}
				goto IL_00af;
			case 4:
				obj.username = username;
				goto case 11;
			default:
				num = 11;
				continue;
			case 13:
				break;
				IL_00af:
				if (State != CvsInSightState.NotConnected)
				{
					Disconnect();
					num = 13;
					continue;
				}
				break;
			}
			break;
		}
		try
		{
			NyVxOhfaap();
			if (asynchronous)
			{
				AbortConnection = false;
				try
				{
					_003C_003Ec__DisplayClass136_1 obj2 = new _003C_003Ec__DisplayClass136_1();
					obj2.CS_0024_003C_003E8__locals1 = obj;
					PwDxEa89dP = true;
					n1oxQw9yS5 = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
					obj2.guiThread = (Thread)g9fjWuvYy81rbCTuA2c();
					Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass136_1.vfHQLfZxslOhenuAd3))] () =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						_003C_003Ec__DisplayClass136_1.cPoKcussElZF0PeGo0rm();
						int num2 = ((!_003C_003Ec__DisplayClass136_1.AvJp36ssSkDSYji4WNgM()) ? 5 : 4);
						_003C_003Ec__DisplayClass136_1.vfHQLfZxslOhenuAd3 stateMachine = default;
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 4:
								stateMachine.iEnnBPhr4C = _003C_003Ec__DisplayClass136_1.IOpAgLssVqyQqHueTRCI();
								goto case 1;
							case 3:
								stateMachine.iEnnBPhr4C.Start(ref stateMachine);
								num2 = 6;
								continue;
							case 2:
								stateMachine.X3LnTXynDq = -1;
								goto case 3;
							default:
								num2 = 3;
								continue;
							case 1:
							case 5:
								stateMachine.jw1nJvEjBW = obj2;
								num2 = 2;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 6:
								break;
							}
							break;
						}
						return stateMachine.iEnnBPhr4C.Task;
					});
					return;
				}
				catch (Exception)
				{
					PwDxEa89dP = false;
					throw;
				}
			}
			AbortConnection = false;
			jta5usvNNtD6QhDQ86q(Task.Run((Func<Task>)obj._003CConnect_003Eb__0));
		}
		catch (Exception exception)
		{
			if (asynchronous)
			{
				HandleConnectCompleted(this, new CvsConnectCompletedEventArgs(exception));
				return;
			}
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (State != CvsInSightState.NotConnected)
		{
			lgaxosg7fy(CvsInSightStateChangedReason.Normal);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInteger(CvsCellLocation location, int cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCogEditInfo[] result = default;
		CvsCogEditingNumber cvsCogEditingNumber = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				result = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).GetEditInfoAsync(location).Result;
				num = 0;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				aMCnJtvrFZFDg665R7X(rNPQQvvxNj0gbVcC5N8(CogSocket), cvsCogEditingNumber.Url, cellValue);
				goto case 2;
			case 2:
			case 4:
				lPVxcBvUL7(location);
				num = 7;
				break;
			case 5:
				if (cvsCogEditingNumber != null)
				{
					goto default;
				}
				return;
			default:
				ciof1svv4RqcPuxU6WK();
				num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 1 : 2);
				break;
			case 0:
				cvsCogEditingNumber = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).EditEditableObjectAsync((string)ElBAyPv11SfwEY2FF7H(result[0])).Result as CvsCogEditingNumber;
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetListBoxIndex(CvsCellLocation location, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sKFnQlvHS3sKEJ7bgEW();
		int num = ((!ciof1svv4RqcPuxU6WK()) ? 5 : 3);
		CvsCogListBox cvsCogListBox = default;
		CvsCogEditInfo[] result = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				cvsCogListBox = CogSocket.Sheet.EditEditableObjectAsync((string)ElBAyPv11SfwEY2FF7H(result[0])).Result as CvsCogListBox;
				num = 2;
				break;
			case 4:
				lPVxcBvUL7(location);
				num = 7;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				aMCnJtvrFZFDg665R7X(rNPQQvvxNj0gbVcC5N8(CogSocket), JqMs5xv3HgNOCTE450f(cvsCogListBox), index);
				num = 4;
				break;
			case 2:
				if (cvsCogListBox != null)
				{
					goto case 6;
				}
				return;
			default:
				num = 6;
				break;
			case 0:
			case 3:
				result = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).GetEditInfoAsync(location).Result;
				goto case 1;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCheckBox(CvsCellLocation location, bool cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CvsCogEditingBoolean cvsCogEditingBoolean = default;
		CvsCogEditInfo[] result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				cvsCogEditingBoolean = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).EditEditableObjectAsync((string)ElBAyPv11SfwEY2FF7H(result[0])).Result as CvsCogEditingBoolean;
				goto case 2;
			case 3:
				aMCnJtvrFZFDg665R7X(CogSocket.Sheet, JqMs5xv3HgNOCTE450f(cvsCogEditingBoolean), cellValue);
				num = 4;
				break;
			case 5:
				result = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).GetEditInfoAsync(location).Result;
				_ = 1;
				num = (sKFnQlvHS3sKEJ7bgEW() ? 6 : 0);
				break;
			case 2:
			case 6:
				if (cvsCogEditingBoolean != null)
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				break;
			case 4:
				lPVxcBvUL7(location);
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFloat(CvsCellLocation location, double cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogEditingNumber cvsCogEditingNumber = default;
		CvsCogEditInfo[] result = default;
		while (true)
		{
			switch (num)
			{
			default:
				aMCnJtvrFZFDg665R7X(rNPQQvvxNj0gbVcC5N8(CogSocket), JqMs5xv3HgNOCTE450f(cvsCogEditingNumber), cellValue);
				num = 0;
				break;
			case 2:
			case 5:
				if (cvsCogEditingNumber != null)
				{
					goto default;
				}
				return;
			case 4:
				result = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).GetEditInfoAsync(location).Result;
				num = 1;
				break;
			case 0:
				lPVxcBvUL7(location);
				num = 7;
				break;
			case 1:
				cvsCogEditingNumber = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).EditEditableObjectAsync((string)ElBAyPv11SfwEY2FF7H(result[0])).Result as CvsCogEditingNumber;
				ciof1svv4RqcPuxU6WK();
				num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 5 : 6);
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetString(CvsCellLocation location, string cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogEditInfo[] result = default;
		CvsCogEditingString cvsCogEditingString = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				result = CogSocket.Sheet.GetEditInfoAsync(location).Result;
				sKFnQlvHS3sKEJ7bgEW();
				if (ciof1svv4RqcPuxU6WK())
				{
					num = 2;
					break;
				}
				num = 3;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				break;
			case 3:
			case 4:
				lPVxcBvUL7(location);
				num = 7;
				break;
			case 5:
				aMCnJtvrFZFDg665R7X(rNPQQvvxNj0gbVcC5N8(CogSocket), JqMs5xv3HgNOCTE450f(cvsCogEditingString), cellValue);
				goto case 3;
			case 1:
			case 2:
				cvsCogEditingString = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).EditEditableObjectAsync(result[0].Url).Result as CvsCogEditingString;
				num = 6;
				break;
			case 6:
				if (cvsCogEditingString != null)
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClickButton(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogEditInfo[] result = default;
		CvsCogEditingButton cvsCogEditingButton = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				result = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).GetEditInfoAsync(location).Result;
				_ = 0;
				if (ciof1svv4RqcPuxU6WK())
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				num = 5;
				break;
			case 3:
				aMCnJtvrFZFDg665R7X(CogSocket.Sheet, cvsCogEditingButton.Url, 1);
				num = 0;
				break;
			case 2:
			case 5:
				if (cvsCogEditingButton != null)
				{
					goto case 3;
				}
				goto case 0;
			default:
				num = 3;
				break;
			case 0:
				((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).Run(true);
				num = 7;
				break;
			case 1:
			case 6:
				cvsCogEditingButton = ((CvsCogSocketSheet)rNPQQvvxNj0gbVcC5N8(CogSocket)).EditEditableObjectAsync((string)ElBAyPv11SfwEY2FF7H(result[0])).Result as CvsCogEditingButton;
				goto case 2;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MakeNewResult(bool updateExposedResults, bool runSheet = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ResultBuilder?.MakeNewResult(updateExposedResults, runSheet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitSheet()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MakeNewResult(updateExposedResults: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearSheetAsync_003Ed__146))]
	public Task ClearSheetAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ciof1svv4RqcPuxU6WK();
		int num;
		if (!sKFnQlvHS3sKEJ7bgEW())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
			}
		}
		_003CClearSheetAsync_003Ed__146 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 3;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloneExternalCellData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!ciof1svv4RqcPuxU6WK()) ? 3 : 2);
		IEnumerator<CvsCell> enumerator = default;
		IExternalCellData externalCellData = default;
		IExternalCellDataHandler externalCellDataHandler = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				enumerator = Results.Cells.GetEnumerator();
				goto case 4;
			case 0:
			case 2:
				if (Results != null)
				{
					goto case 1;
				}
				return;
			case 4:
				try
				{
					while (djLUupvQL3xUJuCysEW(enumerator))
					{
						CvsCell current = enumerator.Current;
						int num2 = 1;
						while (true)
						{
							switch (num2)
							{
							default:
								if (externalCellData != null)
								{
									num2 = 5;
									continue;
								}
								break;
							case 0:
								if (externalCellDataHandler != null)
								{
									ciof1svv4RqcPuxU6WK();
									num2 = (sKFnQlvHS3sKEJ7bgEW() ? 6 : 4);
									continue;
								}
								break;
							case 5:
								externalCellData.CopyPaste();
								num2 = 7;
								continue;
							case 2:
							case 4:
								externalCellData = externalCellDataHandler.SaveState(this, Ckq8U0vMd5k13Srj6R5(current));
								goto default;
							case 1:
								externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(current);
								num2 = 0;
								continue;
							case 7:
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						QeVjkGvlPWLdpqZmZOD(enumerator);
					}
				}
			}
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteExternalCellData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ciof1svv4RqcPuxU6WK();
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 2 : 3);
		IEnumerator<CvsCell> enumerator = default;
		IExternalCellData externalCellData = default;
		IExternalCellDataHandler externalCellDataHandler = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				enumerator = ((CvsCellCollection)EsvxsHvKEXH6Wic6pfV(Results)).GetEnumerator();
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				if (Results != null)
				{
					goto case 1;
				}
				return;
			case 4:
				try
				{
					while (enumerator.MoveNext())
					{
						CvsCell current = enumerator.Current;
						ciof1svv4RqcPuxU6WK();
						int num2 = (sKFnQlvHS3sKEJ7bgEW() ? 3 : 6);
						while (true)
						{
							switch (num2)
							{
							case 4:
								if (externalCellData != null)
								{
									num2 = 5;
									continue;
								}
								break;
							case 0:
							case 6:
								externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(current);
								goto case 1;
							case 2:
								externalCellData = externalCellDataHandler.SaveState(this, Ckq8U0vMd5k13Srj6R5(current));
								goto case 4;
							default:
								num2 = 4;
								continue;
							case 1:
							case 3:
								if (externalCellDataHandler == null)
								{
									break;
								}
								num2 = 2;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								ujLB3Ave5R0g7JSJLlE(externalCellData);
								num2 = 7;
								if (!sKFnQlvHS3sKEJ7bgEW())
								{
									continue;
								}
								break;
							case 7:
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						QeVjkGvlPWLdpqZmZOD(enumerator);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteCellsAsync_003Ed__149))]
	public Task PasteCellsAsync(CvsCellRange cellRange, byte[] bytes, bool cutFromSameSheet, bool runSheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (ciof1svv4RqcPuxU6WK())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_007c;
		IL_0026:
		_003CPasteCellsAsync_003Ed__149 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 10;
		goto IL_007c;
		IL_007c:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 6:
				stateMachine.bytes = bytes;
				num = 9;
				continue;
			case 1:
				stateMachine.cellRange = cellRange;
				num = 6;
				continue;
			case 9:
				stateMachine.cutFromSameSheet = cutFromSameSheet;
				goto default;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 3;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					continue;
				}
				goto default;
			default:
				stateMachine.runSheet = runSheet;
				num = 8;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto case 10;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayImageAsync_003Ed__152))]
	Task IFilmstripPlayer.PlayImageAsync(Bitmap bmp, string imageName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 7 : 4);
		_003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayImageAsync_003Ed__152 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine.bmp = bmp;
				goto case 3;
			case 3:
			case 7:
				stateMachine.imageName = imageName;
				goto case 5;
			default:
				num = 5;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
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
	string IFilmstripRecorder.GetPrimaryImageUrl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Results?.GetPrimaryImageUrl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Bitmap IFilmstripRecorder.GetImage(string url, CogSocketImageFormat fmt)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!sKFnQlvHS3sKEJ7bgEW())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0090;
			}
		}
		goto IL_0061;
		IL_0026:
		return null;
		IL_0090:
		if (Results.IsEmpty)
		{
			goto IL_0026;
		}
		num = 1;
		goto IL_0061;
		IL_0061:
		Rectangle primaryImageRectangle = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (Q1y5b2vuAiK5btMEADq(Results))
				{
					primaryImageRectangle = Results.GetPrimaryImageRectangle();
					num = 5;
					continue;
				}
				break;
			case 0:
			case 3:
				goto IL_0090;
			case 5:
				return CogSocket.GetImageByHttp(url, primaryImageRectangle.Size, primaryImageRectangle, CvsInterpolationAlgorithm.Subsampling, fmt);
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayPointCloudAsync_003Ed__159))]
	Task IFilmstripPlayer.PlayPointCloudAsync(Stream rawData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CCognex_002DInSight_002DIFilmstripPlayer_002DPlayPointCloudAsync_003Ed__159 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine.rawData = rawData;
				goto case 0;
			default:
				num = 0;
				break;
			case 5:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				_ = 1;
				num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 3 : 6);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	string IFilmstripRecorder.GetPrimaryPointCloudUrl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (ciof1svv4RqcPuxU6WK())
		{
			num = 6;
			if (sKFnQlvHS3sKEJ7bgEW())
			{
			}
		}
		else
		{
			num = 5;
		}
		CvsCogShape[] array = default;
		while (true)
		{
			object obj;
			CvsCogImage3DLayer inputImage3DLayer;
			switch (num)
			{
			case 3:
			{
				if (array.Length == 0)
				{
					num = 4;
					break;
				}
				CvsCogPointCloud obj2 = array[0] as CvsCogPointCloud;
				if (obj2 == null)
				{
					num = 7;
					break;
				}
				return (string)AlUEsovRR6w77L9xEf4(obj2);
			}
			case 1:
			case 5:
				obj = null;
				goto IL_0086;
			case 0:
			case 6:
				while (true)
				{
					CvsResultSet results = Results;
					if (results == null)
					{
						break;
					}
					inputImage3DLayer = results.GetInputImage3DLayer();
					if (inputImage3DLayer == null)
					{
						num = 2;
						if (0 == 0)
						{
							goto end_IL_009f;
						}
						continue;
					}
					goto IL_0081;
				}
				goto case 1;
			case 2:
				obj = null;
				goto IL_0086;
			default:
				num = 3;
				break;
			case 4:
				return null;
			case 7:
				{
					return null;
				}
				IL_0081:
				obj = MqFn0svILGCVBlFOfFq(inputImage3DLayer);
				goto IL_0086;
				IL_0086:
				array = (CvsCogShape[])obj;
				if (array != null)
				{
					goto case 3;
				}
				goto case 4;
				end_IL_009f:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPointCloudDataAsync_003Ed__161))]
	public Task<Stream> GetPointCloudDataAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPointCloudDataAsync_003Ed__161 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPointCloudThumbDataAsync_003Ed__162))]
	public Task<byte[]> GetPointCloudThumbDataAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPointCloudThumbDataAsync_003Ed__162 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetZRange_003Ed__163))]
	public Task<(double?, double?)> GetZRange(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetZRange_003Ed__163 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(double?, double?)>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool sdSxpSUBa3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (EventManager == null)
		{
			return true;
		}
		return LnNxvxvau0GR0C9FghW(EventManager);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleResultsChanged(object sender, CvsInternalEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = CvsTrace.Display.ResultsUpdate.TraceResultFunction(this, (string)KIpH2mvUhpjL1pAttMk(6574));
		try
		{
			if (Ci8xV3RoU8 != Yc5yStvnAfIFO4fpt9N(e))
			{
				return;
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					return;
				default:
					if (k9uExbvGZJfwHNfdR42() != null)
					{
						num = 5;
						continue;
					}
					break;
				case 5:
					rcTFlgyD7e = (SynchronizationContext)LCVRoTvilF3sqtQnL9t();
					num = 6;
					continue;
				case 0:
					if (!sdSxpSUBa3())
					{
						if (rcTFlgyD7e != null)
						{
							break;
						}
						goto default;
					}
					_ = 0;
					num = (ciof1svv4RqcPuxU6WK() ? 4 : 3);
					continue;
				case 6:
					break;
				}
				break;
			}
			HandleEvent(sender, aoVF1gx1Ae, kgbOBx7BanbFa22Hp9.ol99ukmDA(6618));
		}
		finally
		{
			if (disposable != null)
			{
				QeVjkGvlPWLdpqZmZOD(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleStateChanged(object sender, CvsStateChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 5 : 10);
		CvsStateChangedEventHandler cvsStateChangedEventHandler = default;
		int num2 = default;
		Delegate[] array = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				try
				{
					VIxbmdvbNPSVtkxitRg(cvsStateChangedEventHandler, sender, e);
				}
				catch (Exception ex)
				{
					GWMODVv6bsNFx8BSr78(ex, KIpH2mvUhpjL1pAttMk(6776));
				}
				num2++;
				goto case 9;
			case 9:
				if (num2 >= array.Length)
				{
					num = 11;
					break;
				}
				cvsStateChangedEventHandler = (CvsStateChangedEventHandler)array[num2];
				num = 6;
				break;
			case 7:
				M9sxU718oA.Debug((string)KIpH2mvUhpjL1pAttMk(6650));
				num = 1;
				break;
			case 0:
			case 10:
				if (Ci8xV3RoU8 != e.ConnectionCookie)
				{
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				_ = e.Reason;
				_ = 1;
				num = 3;
				break;
			case 2:
				array = (Delegate[])ugOhxXvXni7bNwwTFve(U1Wxza847C);
				num = 8;
				break;
			case 4:
			case 5:
				cvsStateChangedEventHandler = null;
				goto case 2;
			default:
				num = 2;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
					return;
				}
				break;
			case 1:
				return;
			case 8:
				num2 = 0;
				num = 9;
				break;
			case 3:
				if (U1Wxza847C != null)
				{
					goto case 4;
				}
				return;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void M37xhaEHBT(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KSsxULvpZJd5n6jxeKL(EventManager.IsLiveAcquisitionChanged);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ohrx4ie0Zi(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KSsxULvpZJd5n6jxeKL(EventManager.IsOnlineChanged);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleIsLiveAcquisitionChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!sdSxpSUBa3())
		{
			HandleEvent(sender, aqRFPxGJjk, (string)KIpH2mvUhpjL1pAttMk(6804));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleIsOnlineChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!sdSxpSUBa3())
		{
			HandleEvent(sender, sqlFIcAHZn, kgbOBx7BanbFa22Hp9.ol99ukmDA(6856));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleNamedEditCellValueChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!sdSxpSUBa3())
		{
			HandleEvent(sender, W2rFaM41K3, kgbOBx7BanbFa22Hp9.ol99ukmDA(6890));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAsTask_003Ed__172))]
	private Task G4Kxldvje1(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!ciof1svv4RqcPuxU6WK())
		{
			goto IL_001e;
		}
		goto IL_0050;
		IL_001e:
		_003CAsTask_003Ed__172 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00b7;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 0:
			case 2:
				stateMachine.eventName = P_0;
				break;
			default:
				num = 5;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 3;
				continue;
			case 3:
				goto IL_0095;
			case 1:
			case 4:
				goto IL_00b7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0095:
			stateMachine._003C_003E4__this = this;
			ciof1svv4RqcPuxU6WK();
			num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 0);
		}
		goto IL_001e;
		IL_00b7:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0050;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleEvent(object sender, EventHandler eventHandler, string eventName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		_003C_003Ec__DisplayClass173_0 obj2 = default;
		_003C_003Ec__DisplayClass173_1 obj = default;
		int num3 = default;
		Delegate[] array = default;
		List<TaskCompletionSource<bool>> value = default;
		Delegate obj3 = default;
		List<TaskCompletionSource<bool>>.Enumerator enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				obj2 = new _003C_003Ec__DisplayClass173_0();
				num = 1;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				break;
			case 4:
				obj.eh = null;
				goto case 0;
			default:
				num = 0;
				break;
			case 7:
				obj2.eventName = eventName;
				num = 9;
				break;
			case 6:
			case 10:
				if (num3 >= array.Length)
				{
					if (MQZx8aduyT.TryGetValue(obj.CS_0024_003C_003E8__locals1.eventName, out value))
					{
						num = 3;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					return;
				}
				obj3 = array[num3];
				num = 14;
				break;
			case 1:
				obj2.sender = sender;
				num = 7;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					break;
				}
				goto case 5;
			case 5:
			case 12:
				obj.CS_0024_003C_003E8__locals1 = obj2;
				num = 4;
				break;
			case 0:
				array = (Delegate[])ugOhxXvXni7bNwwTFve(eventHandler);
				num = 2;
				if (ciof1svv4RqcPuxU6WK())
				{
					break;
				}
				goto case 14;
			case 14:
				obj.eh = (EventHandler)obj3;
				s8P2NWv0ukowiK0tE8L(obj.CS_0024_003C_003E8__locals1, new Action(obj._003CHandleEvent_003Eb__1));
				num3++;
				goto case 6;
			case 2:
				num3 = 0;
				goto case 6;
			case 9:
				if (eventHandler != null)
				{
					num = 13;
					break;
				}
				return;
			case 11:
				try
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass173_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass173_2();
						_ = 1;
						int num2;
						if (!sKFnQlvHS3sKEJ7bgEW())
						{
							num2 = 2;
						}
						else
						{
							num2 = 3;
							if (1 == 0)
							{
								goto IL_020a;
							}
						}
						goto IL_01df;
						IL_020a:
						s8P2NWv0ukowiK0tE8L(obj.CS_0024_003C_003E8__locals1, (Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							CS_0024_003C_003E8__locals2.item.SetResult(result: true);
						}));
						num2 = 4;
						if (1 == 0)
						{
							continue;
						}
						goto IL_01df;
						IL_01df:
						switch (num2)
						{
						case 0:
						case 2:
							CS_0024_003C_003E8__locals2.item = enumerator.Current;
							break;
						case 4:
							continue;
						}
						goto IL_020a;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				D0ji7Pv4MJyIhRJ2jCx(value);
				num = 15;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				enumerator = value.GetEnumerator();
				num = 11;
				break;
			case 13:
				obj = new _003C_003Ec__DisplayClass173_1();
				_ = 1;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
					num = 6;
					if (ciof1svv4RqcPuxU6WK())
					{
						break;
					}
					goto case 2;
				}
				num = 12;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleConnectCompleted(object sender, CvsConnectCompletedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			PwDxEa89dP = false;
			if (AbortConnection && State != CvsInSightState.NotConnected)
			{
				TluxMbchkd();
			}
			if (State == CvsInSightState.NotConnected && EventManager != null)
			{
				EventManager.RemoveAllEvents();
				EventManager = null;
				IResultBuilder jjLxvIXWu = JjLxvIXWu9;
				if (jjLxvIXWu != null)
				{
					sDV1whvkZTs3Z7o8Vwr(jjLxvIXWu);
				}
				ILiveAcqResultBuilder bsGxZoGsDw = BsGxZoGsDw;
				if (bsGxZoGsDw != null)
				{
					sDV1whvkZTs3Z7o8Vwr(bsGxZoGsDw);
				}
			}
			if (nUvFxguTcd != null)
			{
				CvsConnectCompletedEventHandler cvsConnectCompletedEventHandler = null;
				Delegate[] invocationList = nUvFxguTcd.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					cvsConnectCompletedEventHandler = (CvsConnectCompletedEventHandler)invocationList[i];
					try
					{
						Ra7VXRvf14SYWJmqHeS(cvsConnectCompletedEventHandler, sender, e);
					}
					catch (Exception ex)
					{
						GWMODVv6bsNFx8BSr78(ex, kgbOBx7BanbFa22Hp9.ol99ukmDA(6944));
					}
				}
			}
			if (EventManager != null && EventManager.EventsBlocked)
			{
				DBMPJGvFPhaD7kq7fYr(EventManager);
			}
			else if (EventManager != null)
			{
				M9sxU718oA.Debug(kgbOBx7BanbFa22Hp9.ol99ukmDA(6980));
			}
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			K2ixgkktQj(e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K2ixgkktQj(CvsConnectCompletedEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (sKFnQlvHS3sKEJ7bgEW() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 4:
				yMrlFpvyBDGGZdLLTFL(n1oxQw9yS5, J0QJVpvmZvnr0c77vtb(P_0));
				goto case 5;
			default:
				num = 6;
				break;
			case 0:
			case 2:
				if (n1oxQw9yS5 == null)
				{
					return;
				}
				if (J0QJVpvmZvnr0c77vtb(P_0) != null)
				{
					num = 4;
					break;
				}
				n1oxQw9yS5.TrySetResult(null);
				num = 5;
				if (true)
				{
					break;
				}
				return;
			case 1:
				return;
			case 3:
				return;
			case 5:
			case 6:
				n1oxQw9yS5 = null;
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HandleUndoChanged(UndoEventType type, bool checkThreadContext = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_008b;
		IL_001a:
		int num2 = default;
		Delegate[] invocationList = default;
		UndoEventArgs e = default;
		if (num2 >= invocationList.Length)
		{
			num = 14;
		}
		else
		{
			act3VXvZLE4B7guCsbj((UndoEventHandler)invocationList[num2], this, e);
			num = 0;
			if (1 == 0)
			{
				goto IL_0147;
			}
		}
		goto IL_008b;
		IL_0147:
		_003C_003Ec__DisplayClass176_0 obj = default;
		obj.type = type;
		_ = 1;
		num = ((!sKFnQlvHS3sKEJ7bgEW()) ? 6 : 9);
		goto IL_008b;
		IL_008b:
		UndoEventHandler undoEventHandler = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 0:
				num2++;
				num = 4;
				continue;
			case 13:
				invocationList = undoEventHandler.GetInvocationList();
				goto case 8;
			case 3:
			case 6:
				undoEventHandler = llwFFecGkV;
				if (undoEventHandler != null)
				{
					num = 5;
					continue;
				}
				return;
			case 7:
				return;
			default:
				num = 13;
				continue;
			case 2:
				obj = new _003C_003Ec__DisplayClass176_0();
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (rcTFlgyD7e != null)
				{
					n3GCi3vgaVduB6TP30s(rcTFlgyD7e, new SendOrPostCallback(obj._003CHandleUndoChanged_003Eb__0), null);
					num = 7;
					continue;
				}
				goto IL_006d;
			case 10:
				obj._003C_003E4__this = this;
				num = 12;
				continue;
			case 12:
				goto IL_0147;
			case 5:
				if (checkThreadContext)
				{
					num = 11;
					continue;
				}
				goto IL_006d;
			case 8:
			case 9:
				num2 = 0;
				num = 1;
				continue;
			case 14:
				return;
				IL_006d:
				e = new UndoEventArgs(obj.type);
				goto case 13;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandleUndoChangedAsync_003Ed__177))]
	internal Task HandleUndoChangedAsync(UndoEventType type)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!ciof1svv4RqcPuxU6WK())
		{
			goto IL_001e;
		}
		goto IL_0050;
		IL_001e:
		_003CHandleUndoChangedAsync_003Ed__177 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 2:
			case 3:
				stateMachine.type = type;
				goto case 6;
			default:
				num = 6;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 5;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 3);
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CinternalConnect_003Ed__184))]
	private Task V1YxqC4Q8n(Uri P_0, Uri P_1, string P_2, string P_3, string P_4, string P_5, CvsInSightLanguage P_6, bool P_7, ICogSocketAcqFactory P_8)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CinternalConnect_003Ed__184 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine._003C_003E4__this = this;
				stateMachine.rootUrl = P_0;
				num = 6;
				continue;
			case 6:
				stateMachine.httpUri = P_1;
				_ = 1;
				num = (sKFnQlvHS3sKEJ7bgEW() ? 1 : 0);
				continue;
			case 10:
				stateMachine.username = P_4;
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine.cameraPath = P_2;
				num = 9;
				continue;
			case 9:
				stateMachine.sheetPath = P_3;
				num = 10;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
				}
				continue;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 8;
				continue;
			case 11:
				stateMachine.acqFactory = P_8;
				num = 5;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 7:
				stateMachine.language = P_6;
				stateMachine.blockEvents = P_7;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine.password = P_5;
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 12;
				continue;
			case 12:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 13;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					continue;
				}
				break;
			case 13:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConnectCogSocket_003Ed__186))]
	private Task WohxTrM4Kg(Uri P_0, Uri P_1, string P_2, string P_3, string P_4, CvsInSightLanguage P_5, ICogSocketAcqFactory P_6)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0069;
		IL_00e1:
		_003CConnectCogSocket_003Ed__186 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 5;
		if (ciof1svv4RqcPuxU6WK())
		{
			goto IL_0069;
		}
		goto IL_00f9;
		IL_0069:
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 0:
				stateMachine.cameraPath = P_2;
				num = 10;
				continue;
			case 10:
				stateMachine.sheetPath = P_3;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				stateMachine.username = P_4;
				num = 9;
				continue;
			case 6:
				goto IL_00bf;
			case 3:
			case 8:
				goto IL_00e1;
			case 5:
				goto IL_00f9;
			case 1:
			case 11:
				stateMachine._003C_003E4__this = this;
				num = 7;
				continue;
			case 2:
				stateMachine.httpUri = P_1;
				num = 0;
				continue;
			case 7:
				stateMachine.rootUrl = P_0;
				num = 2;
				continue;
			case 12:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_00bf:
			stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
			_ = 0;
			num = (ciof1svv4RqcPuxU6WK() ? 11 : 3);
		}
		goto IL_001a;
		IL_00f9:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 12;
		if (sKFnQlvHS3sKEJ7bgEW())
		{
		}
		goto IL_0069;
		IL_001a:
		stateMachine.language = P_5;
		stateMachine.acqFactory = P_6;
		goto IL_00e1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qYUxB7qmkA(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!IsLiveAcquisition)
		{
			mv4xfnBtUF();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Fv8xJWSsBx(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IsLiveAcquisition)
		{
			mv4xfnBtUF();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TluxMbchkd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)Sf5o8fvJTnptW5BPPdE(CvsTraceSDK.Info, LcgxjxZB2U((string)KIpH2mvUhpjL1pAttMk(7064)));
		try
		{
			object e7uxyolAY = E7uxyolAY3;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(e7uxyolAY, ref lockTaken);
				if (Xcsx2Wv5TK != null)
				{
					try
					{
						wqIbPOv84iAqCTe1Stu(Xcsx2Wv5TK);
					}
					catch (Exception)
					{
					}
				}
				try
				{
					IResultBuilder jjLxvIXWu = JjLxvIXWu9;
					if (jjLxvIXWu == null)
					{
						ciof1svv4RqcPuxU6WK();
						switch (sKFnQlvHS3sKEJ7bgEW() ? 3 : 2)
						{
						case 0:
						case 2:
							break;
						default:
							goto end_IL_005c;
						case 3:
							goto end_IL_005c;
						}
					}
					else
					{
						zPPdodvzwGE7C3WI15o(jjLxvIXWu);
					}
					BsGxZoGsDw?.Disconnect();
					end_IL_005c:;
				}
				catch (Exception)
				{
				}
				if (afHxDIlTiO != null)
				{
					yda3C0Hwkx4ggvOoIwV(afHxDIlTiO);
					afHxDIlTiO = null;
				}
				cRCxXj8JLN(_0020: false);
			}
			finally
			{
				if (lockTaken)
				{
					yKuxv8HsiaQMNlvJVp3(e7uxyolAY);
				}
			}
			if (NK8xdPcxcK != null)
			{
				NqIi4uHLdtnnKiwrAnh(KHLxnZX5vu, QgOjLgHhrDCZfQduh07(NK8xdPcxcK), null);
				NqIi4uHLdtnnKiwrAnh(ow5x9AvbBI, QgOjLgHhrDCZfQduh07(NK8xdPcxcK), null);
				eHl737H9JCExsmOboko(NK8xdPcxcK);
				NK8xdPcxcK = null;
			}
		}
		finally
		{
			if (disposable != null)
			{
				QeVjkGvlPWLdpqZmZOD(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lgaxosg7fy(CvsInSightStateChangedReason P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)Sf5o8fvJTnptW5BPPdE(CvsTraceSDK.Info, LcgxjxZB2U((string)KIpH2mvUhpjL1pAttMk(7102)));
		try
		{
			if (P_0 != CvsInSightStateChangedReason.Timeout)
			{
				E9bxkvQqYO();
			}
			if (PwDxEa89dP)
			{
				AbortConnection = true;
				return;
			}
			CvsInSightState state = State;
			TluxMbchkd();
			if (wMRxNZ65iG)
			{
				return;
			}
			try
			{
				wMRxNZ65iG = true;
				ciof1svv4RqcPuxU6WK();
				int num;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					num = 2;
					if (1 == 0)
					{
						goto IL_0088;
					}
				}
				else
				{
					num = 5;
					if (sKFnQlvHS3sKEJ7bgEW())
					{
						goto IL_00dd;
					}
				}
				goto IL_0107;
				IL_00dd:
				JT4AKRHSThQZjBbp5CJ(EventManager, new CvsStateChangedEventArgs(CvsInSightState.NotConnected, P_0, Ci8xV3RoU8));
				goto IL_0088;
				IL_0107:
				while (true)
				{
					switch (num)
					{
					case 4:
						break;
					case 6:
						if (!PwDxEa89dP)
						{
							num = 7;
							if (sKFnQlvHS3sKEJ7bgEW())
							{
							}
							continue;
						}
						return;
					case 0:
					case 2:
						if (EventManager != null)
						{
							goto case 1;
						}
						return;
					case 3:
						goto IL_00dd;
					default:
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
					case 5:
						if (state != CvsInSightState.NotConnected)
						{
							num = 3;
							continue;
						}
						break;
					case 7:
						EventManager = null;
						return;
					}
					break;
				}
				goto IL_0088;
				IL_0088:
				EventManager.RemoveAllEvents();
				num = 6;
				goto IL_0107;
			}
			finally
			{
				wMRxNZ65iG = false;
			}
		}
		finally
		{
			if (disposable != null)
			{
				QeVjkGvlPWLdpqZmZOD(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateCvsCogSocket_003Ed__193))]
	private Task d1HxAyDj1T(Uri P_0, Uri P_1, string P_2, string P_3, string P_4, ICogSocketAcqFactory P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00d5;
		IL_001a:
		_003CCreateCvsCogSocket_003Ed__193 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 11;
		goto IL_00d5;
		IL_00d5:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 6:
				stateMachine.acqFactory = P_5;
				num = 8;
				continue;
			case 3:
			case 5:
				stateMachine.sheetPath = P_3;
				stateMachine.username = P_4;
				goto case 1;
			case 10:
				stateMachine.rootUrl = P_0;
				num = 2;
				continue;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				continue;
			case 9:
				stateMachine._003C_003E4__this = this;
				num = 10;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder = q3CjbovODcCOJ9D1YR7();
				num = 9;
				continue;
			case 0:
				stateMachine.path = P_2;
				goto default;
			default:
				ciof1svv4RqcPuxU6WK();
				if (sKFnQlvHS3sKEJ7bgEW())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
				}
				num = 3;
				continue;
			case 2:
				stateMachine.httpUrl = P_1;
				num = 0;
				continue;
			case 11:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dFextTd6fX(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (State != CvsInSightState.NotConnected)
		{
			lgaxosg7fy(CvsInSightStateChangedReason.Timeout);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BX4xWMIAsl(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GEjx3ESUIg(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MakeNewResult(updateExposedResults: false, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCvsCogSocketSheetIDChanged_003Ed__197))]
	private void p0PxLIQgcY(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CCvsCogSocketSheetIDChanged_003Ed__197 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = KpAwLMHEjhoT2LVh6Kf();
				_ = 1;
				num = (sKFnQlvHS3sKEJ7bgEW() ? 3 : 0);
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void E9bxkvQqYO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Tb2AHWHveaRg5p1mLJI(ResultBuilder);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cRCxXj8JLN(bool P_0 = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (ciof1svv4RqcPuxU6WK())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_00c5;
			}
		}
		goto IL_0047;
		IL_0047:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 4;
				if (ciof1svv4RqcPuxU6WK())
				{
					continue;
				}
				goto IL_007c;
			case 4:
				goto IL_007c;
			case 3:
				goto IL_00a6;
			case 0:
			case 6:
				goto IL_00c5;
			case 1:
				usrLUfHVLSVFUaMx4pN(i1Uxe9iPoR);
				num = 7;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_00a6:
		ILiveAcqResultBuilder bsGxZoGsDw = BsGxZoGsDw;
		if (bsGxZoGsDw != null)
		{
			y5mRedHH8WEVUs4Zxtw(bsGxZoGsDw);
		}
		goto IL_002e;
		IL_007c:
		b7SxCkd8vk.Reset(P_0);
		num = 1;
		if (sKFnQlvHS3sKEJ7bgEW())
		{
		}
		goto IL_0047;
		IL_002e:
		fIQxGWeG7D = CvsInSightState.NotConnected;
		goto IL_007c;
		IL_00c5:
		IResultBuilder jjLxvIXWu = JjLxvIXWu9;
		if (jjLxvIXWu != null)
		{
			jjLxvIXWu.Init();
			goto IL_00a6;
		}
		num = 3;
		goto IL_0047;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mv4xfnBtUF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using (CvsTrace.Display.ResultsUpdate.TraceResultFunction(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(7142)))
		{
			EventManager xcsx2Wv5TK = Xcsx2Wv5TK;
			if (xcsx2Wv5TK == null)
			{
				ciof1svv4RqcPuxU6WK();
				int num;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					num = 2;
					if (false)
					{
						return;
					}
				}
				else
				{
					num = 3;
				}
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 3:
					break;
				}
			}
			else
			{
				xcsx2Wv5TK.ResultsChanged?.AddEvent(new CvsInternalEventArgs(Ci8xV3RoU8));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string LcgxjxZB2U(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)OELTIjHAFMdM00NVxM2(KIpH2mvUhpjL1pAttMk(7190), CameraPath, KgZx78PC4V, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lPVxcBvUL7(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!sKFnQlvHS3sKEJ7bgEW())
		{
		}
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				if (cvsCell != null)
				{
					num = 0;
					break;
				}
				return;
			case 4:
			case 5:
				KSsxULvpZJd5n6jxeKL(E4bNAaHTCZ1QpMdi7XN(EventManager));
				num = 7;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					break;
				}
				goto case 2;
			case 2:
				cvsCell = ((CvsCellCollection)EsvxsHvKEXH6Wic6pfV(Results))[P_0];
				_ = 1;
				if (!sKFnQlvHS3sKEJ7bgEW())
				{
					num = 6;
					if (ciof1svv4RqcPuxU6WK())
					{
						break;
					}
					goto case 3;
				}
				num = 5;
				break;
			case 3:
				if (!KcbJpQHU8ma3b3B1Dd6(woJE0EHDohvk6iLvZ0j(cvsCell)))
				{
					goto case 4;
				}
				return;
			case 0:
				if (cvsCell.IsEditCell)
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				if (false)
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InvokeReadyForResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = CvsTrace.Display.ResultsUpdate.TraceResultFunction(this, (string)KIpH2mvUhpjL1pAttMk(7236));
		try
		{
			int num;
			if (!HasSheet)
			{
				num = 0;
				goto IL_007c;
			}
			object obj = EhkNIWHdLGcRWqGxnd0(SheetInfo);
			goto IL_004a;
			IL_004a:
			EventArgs<string> e = (string)obj;
			num = 1;
			goto IL_007c;
			IL_007c:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					if (lljVPkHiSxoqgoeyOQq(CogSocket))
					{
						goto default;
					}
					goto case 4;
				default:
					sKFnQlvHS3sKEJ7bgEW();
					num = ((!ciof1svv4RqcPuxU6WK()) ? 6 : 2);
					continue;
				case 1:
					if (CogSocket != null)
					{
						num = 5;
						continue;
					}
					goto case 2;
				case 4:
				case 6:
				{
					EventHandler eventHandler = re0FOgJbH6;
					if (eventHandler == null)
					{
						num = 7;
						continue;
					}
					qY3plBHqmSZmJ1EbqdT(eventHandler, this, e);
					return;
				}
				case 2:
				case 3:
					if (!IsLiveAcquisition)
					{
						goto case 4;
					}
					return;
				case 7:
					return;
				}
				break;
			}
			obj = null;
			goto IL_004a;
		}
		finally
		{
			if (disposable != null)
			{
				QeVjkGvlPWLdpqZmZOD(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void OnDisplayShownChanged(bool isShown)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		EventArgs<KeyValuePair<string, bool>> e = default;
		while (true)
		{
			object key;
			switch (num)
			{
			case 5:
				return;
			case 0:
			case 2:
			{
				EventHandler eventHandler = gByFpCJOLM;
				if (eventHandler == null)
				{
					return;
				}
				qY3plBHqmSZmJ1EbqdT(eventHandler, this, e);
				num = 6;
				break;
			}
			default:
				num = 5;
				break;
			case 1:
			case 3:
				key = null;
				goto IL_007f;
			case 4:
			{
				CvsSheetInfo sheetInfo = SheetInfo;
				if (sheetInfo != null)
				{
					key = sheetInfo.SheetID;
					goto IL_007f;
				}
				_ = 1;
				if (sKFnQlvHS3sKEJ7bgEW())
				{
					num = 0;
					break;
				}
				num = 3;
				if (false)
				{
					return;
				}
				break;
			}
			case 6:
				return;
				IL_007f:
				e = new KeyValuePair<string, bool>((string)key, isShown);
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsInSight()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ciof1svv4RqcPuxU6WK();
		int num;
		if (!sKFnQlvHS3sKEJ7bgEW())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				JkMxm33aCD = 0;
				num = 3;
				break;
			case 3:
				KHLxnZX5vu = new Hashtable();
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				ow5x9AvbBI = new Hashtable();
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				YPlXJZvDI9WoZpWYwBw();
				goto case 1;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oDSSOfvV8c26tAsakkX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ciof1svv4RqcPuxU6WK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sKFnQlvHS3sKEJ7bgEW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xdj44FvAfZfxn5nUpcj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YPlXJZvDI9WoZpWYwBw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KIpH2mvUhpjL1pAttMk(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hpSwTpvTLl3jjnM8q9R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QHCEWMvdtJ8w8FaqfIa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).ManagedThreadId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LCVRoTvilF3sqtQnL9t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SyncContextService.GetCurrentContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LwLU9XvqDvUGkomF6nU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Debug((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B2DV3AvBZ1WOh85CkVu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).HasSheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fFlD16vj3hfueKFmJtb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOnlineOfflineService)P_0).IsOnlineChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aq5mLNvcomCnj2lExdF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOnlineOfflineService)P_0).IsOnlineChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WBUQoGv2uYdb91NgdSs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILiveModeService)P_0).IsLiveAcquisitionChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zPjulpvWKYji9qe0YQO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILiveAcqResultBuilder)P_0).LiveModeService = (ILiveModeService)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fiHJDjv7PasYHdddLED(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ILiveModeService)P_0).IsLiveAcquisition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool skDMP5vtE3RimLqh78x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOnlineOfflineService)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ffXCNQvCkap721QhKJq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IResultBuilder)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EsvxsHvKEXH6Wic6pfV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YPY2jVv5GfhRAaGTqfB(CvsCellLocation cell, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCell.ValidateCellName(cell, (string)P_1, (CvsCellCollection)P_2, (CvsSensor)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zW1yINvoHJtYF024KEJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NetworkCredential)P_0).Password;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object teUFulvPHLbMIW6cfDx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidStateMissingCompletionResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g9fjWuvYy81rbCTuA2c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Thread.CurrentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jta5usvNNtD6QhDQ86q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rNPQQvvxNj0gbVcC5N8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ElBAyPv11SfwEY2FF7H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditInfo)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aMCnJtvrFZFDg665R7X(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JqMs5xv3HgNOCTE450f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingObject)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder q3CjbovODcCOJ9D1YR7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Ckq8U0vMd5k13Srj6R5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool djLUupvQL3xUJuCysEW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QeVjkGvlPWLdpqZmZOD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ujLB3Ave5R0g7JSJLlE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IExternalCellData)P_0).Delete();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q1y5b2vuAiK5btMEADq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).IsValidImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MqFn0svILGCVBlFOfFq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage3DLayer)P_0).Graphics;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AlUEsovRR6w77L9xEf4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPointCloud)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LnNxvxvau0GR0C9FghW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventManager)P_0).TimeToStop;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Yc5yStvnAfIFO4fpt9N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInternalEventArgs)P_0).ConnectionCookie;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k9uExbvGZJfwHNfdR42()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SynchronizationContext.Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ugOhxXvXni7bNwwTFve(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Delegate)P_0).GetInvocationList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VIxbmdvbNPSVtkxitRg(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (CvsStateChangedEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GWMODVv6bsNFx8BSr78(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsHelper.UnhandledExceptionAlert((Exception)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KSsxULvpZJd5n6jxeKL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventManager.CachedManagedEvent)P_0).AddEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s8P2NWv0ukowiK0tE8L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		handleEvent((Action)P_1);
		[MethodImpl(MethodImplOptions.NoInlining)]
		void handleEvent(Action action)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			try
			{
				_003C_003Ec__DisplayClass173_0.NfPyOBssysOVLIX1lsSw(action);
			}
			catch (Exception ex)
			{
				CvsHelper.UnhandledExceptionAlert(ex, ((_003C_003Ec__DisplayClass173_0)P_0).eventName);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D0ji7Pv4MJyIhRJ2jCx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<TaskCompletionSource<bool>>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sDV1whvkZTs3Z7o8Vwr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IResultBuilder)P_0).Stop();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ra7VXRvf14SYWJmqHeS(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (CvsConnectCompletedEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DBMPJGvFPhaD7kq7fYr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventManager)P_0).UnblockEvents();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J0QJVpvmZvnr0c77vtb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsConnectCompletedEventArgs)P_0).Exception;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yMrlFpvyBDGGZdLLTFL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TaskCompletionSource<object>)P_0).TrySetException((Exception)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n3GCi3vgaVduB6TP30s(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SynchronizationContext)P_0).Send((SendOrPostCallback)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void act3VXvZLE4B7guCsbj(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (UndoEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Sf5o8fvJTnptW5BPPdE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wqIbPOv84iAqCTe1Stu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventManager)P_0).StopThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zPPdodvzwGE7C3WI15o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IResultBuilder)P_0).Disconnect();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yda3C0Hwkx4ggvOoIwV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsPropSheet)P_0).Disconnect();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yKuxv8HsiaQMNlvJVp3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QgOjLgHhrDCZfQduh07(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).ConnectionId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NqIi4uHLdtnnKiwrAnh(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Hashtable)P_0)[P_1] = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eHl737H9JCExsmOboko(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocket)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JT4AKRHSThQZjBbp5CJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EventManager)P_0).FireImmediateStateChanged((CvsStateChangedEventArgs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder KpAwLMHEjhoT2LVh6Kf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tb2AHWHveaRg5p1mLJI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IResultBuilder)P_0).WaitForResultBuildComplete();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y5mRedHH8WEVUs4Zxtw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IResultBuilder)P_0).Init();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void usrLUfHVLSVFUaMx4pN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSheetInfo)P_0).Reset();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OELTIjHAFMdM00NVxM2(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object woJE0EHDohvk6iLvZ0j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KcbJpQHU8ma3b3B1Dd6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E4bNAaHTCZ1QpMdi7XN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventManager)P_0).NamedEditCellValueChanged;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EhkNIWHdLGcRWqGxnd0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSheetInfo)P_0).SheetID;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lljVPkHiSxoqgoeyOQq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).IsRuntimeSupported;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qY3plBHqmSZmJ1EbqdT(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}
}
