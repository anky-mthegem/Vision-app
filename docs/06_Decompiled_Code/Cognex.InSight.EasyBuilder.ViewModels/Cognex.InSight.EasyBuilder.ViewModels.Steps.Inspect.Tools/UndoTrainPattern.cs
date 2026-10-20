using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.Mvvm;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public class UndoTrainPattern : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoTrainPattern _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Q32kRpK8Q75E49tD3kB0())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_045c;
			IL_049e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_045c;
			IL_045c:
			UndoTrainPattern undoTrainPattern = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 5:
					undoTrainPattern = _003C_003E4__this;
					num = 4;
					continue;
				default:
					goto IL_049e;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				TaskAwaiter<byte[]> awaiter;
				int num3;
				byte[] result = default;
				switch (num2)
				{
				default:
					awaiter = undoTrainPattern.r87Fl5jLk2().CogSocket.Sheet.CopyCellsAsync(undoTrainPattern.gLlFOmSULX()).GetAwaiter();
					num3 = 23;
					if (!eULwYJK8mkmn7ts4MALx())
					{
						goto IL_006d;
					}
					goto IL_00d5;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 14;
					goto IL_00d5;
				case 3:
					awaiter = _003C_003Eu__1;
					num3 = 8;
					goto IL_00d5;
				case 1:
					awaiter = _003C_003Eu__1;
					num3 = 20;
					if (0 == 0)
					{
						goto IL_00d5;
					}
					goto IL_023a;
				case 0:
					{
						awaiter = _003C_003Eu__1;
						num3 = 25;
						if (eULwYJK8mkmn7ts4MALx())
						{
							goto IL_00d5;
						}
						goto IL_039d;
					}
					IL_00d5:
					while (true)
					{
						switch (num3)
						{
						case 10:
							break;
						case 29:
							result = awaiter.GetResult();
							undoTrainPattern.KZJFKyL0yN(result);
							break;
						default:
							num3 = 10;
							if (true)
							{
								continue;
							}
							goto case 23;
						case 23:
							if (!awaiter.IsCompleted)
							{
								num3 = 12;
								continue;
							}
							goto case 16;
						case 1:
							undoTrainPattern.nxkFZU4unH(result);
							num3 = 9;
							continue;
						case 16:
							result = awaiter.GetResult();
							undoTrainPattern.zsKFkcUpnC(result);
							_ = 0;
							num3 = ((!eULwYJK8mkmn7ts4MALx()) ? 3 : 13);
							continue;
						case 14:
							goto IL_01ae;
						case 19:
							num2 = (_003C_003E1__state = 2);
							num3 = 17;
							continue;
						case 2:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 15:
							return;
						case 7:
							return;
						case 25:
							goto IL_023a;
						case 6:
						case 13:
							awaiter = ((CvsCogSocketSheet)aFgwygK82ZQ4wWEbcc5a(QEF8DJK8NlL4mCArgo4e(undoTrainPattern.r87Fl5jLk2()))).CopyCellsAsync(undoTrainPattern.JsCFyCZUQw()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 28;
								continue;
							}
							goto case 29;
						case 3:
						case 21:
							num2 = (_003C_003E1__state = 3);
							num3 = 0;
							continue;
						case 5:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 7;
							continue;
						case 8:
							_003C_003Eu__1 = default;
							num3 = 24;
							if (eULwYJK8mkmn7ts4MALx())
							{
								continue;
							}
							goto case 9;
						case 9:
							awaiter = ((CvsCogSocketSheet)aFgwygK82ZQ4wWEbcc5a(QEF8DJK8NlL4mCArgo4e(undoTrainPattern.r87Fl5jLk2()))).CopyCellsAsync(undoTrainPattern.JsCFyCZUQw()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								goto case 3;
							}
							goto case 4;
						case 27:
							_003C_003Eu__1 = awaiter;
							num3 = 18;
							continue;
						case 22:
							_003C_003Eu__1 = awaiter;
							num3 = 5;
							continue;
						case 26:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 15;
							continue;
						case 24:
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
							continue;
						case 4:
							result = awaiter.GetResult();
							num3 = 30;
							continue;
						case 18:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 17:
							goto IL_039d;
						case 0:
							_003C_003Eu__1 = awaiter;
							num3 = 26;
							continue;
						case 11:
							num2 = (_003C_003E1__state = -1);
							num3 = 29;
							continue;
						case 20:
							_003C_003Eu__1 = default;
							num3 = 11;
							continue;
						case 28:
							num2 = (_003C_003E1__state = 1);
							num3 = 22;
							if (eULwYJK8mkmn7ts4MALx())
							{
								continue;
							}
							goto case 12;
						case 12:
							num2 = (_003C_003E1__state = 0);
							num3 = 27;
							if (eULwYJK8mkmn7ts4MALx())
							{
								continue;
							}
							goto case 30;
						case 30:
							undoTrainPattern.V6BFYJ9KHR(result);
							goto end_IL_0027;
						}
						break;
					}
					goto IL_006d;
					IL_039d:
					_003C_003Eu__1 = awaiter;
					num3 = 2;
					goto IL_00d5;
					IL_023a:
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					num3 = 16;
					goto IL_00d5;
					IL_01ae:
					num2 = (_003C_003E1__state = -1);
					goto IL_01b7;
					IL_006d:
					PSNHfrK81ydT3pCxcv9V(OaqYw8K8cuW0pOQHiPjo(undoTrainPattern.n5pFeykSQI()));
					awaiter = ((CvsCogSocket)QEF8DJK8NlL4mCArgo4e(undoTrainPattern.r87Fl5jLk2())).Sheet.CopyCellsAsync(undoTrainPattern.gLlFOmSULX()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num3 = 19;
						goto IL_00d5;
					}
					goto IL_01b7;
					IL_01b7:
					result = awaiter.GetResult();
					num3 = 1;
					goto IL_00d5;
					end_IL_0027:
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
			goto IL_049e;
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
		internal static object QEF8DJK8NlL4mCArgo4e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aFgwygK82ZQ4wWEbcc5a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OaqYw8K8cuW0pOQHiPjo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ButtonViewModel)P_0).Command;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PSNHfrK81ydT3pCxcv9V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((DelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eULwYJK8mkmn7ts4MALx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q32kRpK8Q75E49tD3kB0()
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
	private struct _003CRedo_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoTrainPattern _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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
			goto IL_0367;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				goto IL_0031;
			}
			goto IL_0367;
			IL_0367:
			int num2 = default;
			UndoTrainPattern undoTrainPattern = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					goto IL_0031;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = CBnQFJKqKDFCpVl2eb37(vKBVZkKqLOK0C6yqeIy5(mAwvWAK8z16tJF2m1eZN(VoKjcRK8teeXkUpOilqK(undoTrainPattern.r87Fl5jLk2())), undoTrainPattern.gLlFOmSULX(), undoTrainPattern.mMOFBa7j2o(), false, false));
							num3 = 16;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 1;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 9;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 6;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 10:
								awaiter = CBnQFJKqKDFCpVl2eb37(vKBVZkKqLOK0C6yqeIy5(mAwvWAK8z16tJF2m1eZN(undoTrainPattern.r87Fl5jLk2().CogSocket), undoTrainPattern.JsCFyCZUQw(), undoTrainPattern.AYGFtpThl8(), false, false));
								num3 = 14;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
							case 17:
								zwyh2HKq5cyNvt5s8rx5(undoTrainPattern.n5pFeykSQI());
								num3 = 19;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 21;
							default:
								num3 = 21;
								continue;
							case 6:
								awaiter.GetResult();
								fWFZqMK8hiwsPpUPaFrP();
								num3 = ((!mX86MHK8ugGp5n9LQ731()) ? 8 : 17);
								continue;
							case 8:
								return;
							case 18:
								return;
							case 20:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 19:
								awaiter = ((Task)LgHQ4ZKqwbFrkMWQPvWn()).GetAwaiter();
								num3 = 11;
								continue;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 15;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								num2 = (_003C_003E1__state = 1);
								num3 = 4;
								continue;
							case 21:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 20;
								continue;
							case 15:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									num3 = 12;
									continue;
								}
								break;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 22;
								continue;
							case 22:
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
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0031:
			undoTrainPattern = _003C_003E4__this;
			mX86MHK8ugGp5n9LQ731();
			if (!fWFZqMK8hiwsPpUPaFrP())
			{
				num = 1;
			}
			else
			{
				num = 0;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_0367;
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
		internal static object VoKjcRK8teeXkUpOilqK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mAwvWAK8z16tJF2m1eZN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vKBVZkKqLOK0C6yqeIy5(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter CBnQFJKqKDFCpVl2eb37(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zwyh2HKq5cyNvt5s8rx5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ButtonViewModel)P_0).FireCommandExecuted();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LgHQ4ZKqwbFrkMWQPvWn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mX86MHK8ugGp5n9LQ731()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fWFZqMK8hiwsPpUPaFrP()
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
	private struct _003CSaveState_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (ds85Q8Kqa0GpEaZqdbtq() ? 3 : 4);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Pp4ikvKqOMo7PHHOR4Ll(ULtanQKqeZMga1RP8til());
							ds85Q8Kqa0GpEaZqdbtq();
							if (XSsORPKqJ519lScdLPQM())
							{
								num3 = 5;
								if (ds85Q8Kqa0GpEaZqdbtq())
								{
								}
							}
							else
							{
								num3 = 2;
								if (!XSsORPKqJ519lScdLPQM())
								{
									goto IL_00f0;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (false)
							{
								goto IL_00d3;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (XSsORPKqJ519lScdLPQM())
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (ds85Q8Kqa0GpEaZqdbtq())
								{
								}
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 0:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 6:
								return;
							case 4:
								break;
							case 2:
							case 3:
								goto IL_00f0;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
						}
						goto IL_00d3;
						IL_00f0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00d3:
						_003C_003Eu__1 = awaiter;
						goto IL_00f0;
						end_IL_0024:;
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
				case 2:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static object ULtanQKqeZMga1RP8til()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Pp4ikvKqOMo7PHHOR4Ll(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XSsORPKqJ519lScdLPQM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ds85Q8Kqa0GpEaZqdbtq()
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
	private struct _003CUndo_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoTrainPattern _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YEt5cwKqIukGN7XUMBZ0();
			int num;
			if (!h6Ut6KKqD4mHhrpBobZC())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_03a0;
				}
			}
			goto IL_035a;
			IL_035a:
			int num2 = default;
			UndoTrainPattern undoTrainPattern = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((CvsCogSocketSheet)I9MAs9Kqn21rKbMhoXsK(Ylph7uKqi0GPIDs8WqTv(undoTrainPattern.r87Fl5jLk2()))).InternalPasteCellsAsync(undoTrainPattern.gLlFOmSULX(), undoTrainPattern.HrYFiacsmU(), false, false).GetAwaiter();
							num3 = 17;
							if (!YEt5cwKqIukGN7XUMBZ0())
							{
								return;
							}
							goto IL_00bc;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 9;
							goto IL_00bc;
						case 1:
							awaiter = _003C_003Eu__1;
							goto IL_01b4;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
								if (YEt5cwKqIukGN7XUMBZ0())
								{
									goto IL_00bc;
								}
								goto IL_0149;
							}
							IL_00bc:
							while (true)
							{
								switch (num3)
								{
								case 8:
									return;
								case 15:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 11;
									if (!h6Ut6KKqD4mHhrpBobZC())
									{
										continue;
									}
									return;
								case 3:
									return;
								case 13:
									break;
								case 12:
								case 16:
									yqOnI7KqdXteZX8rSKtE(undoTrainPattern.n5pFeykSQI());
									num3 = 18;
									continue;
								case 1:
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									continue;
								case 20:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto case 22;
								case 0:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 10;
									continue;
								case 11:
									goto IL_01b4;
								case 10:
									goto IL_01d9;
								case 18:
									goto IL_01f7;
								case 4:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto case 19;
								case 19:
									awaiter.GetResult();
									num3 = 14;
									continue;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 13;
									continue;
								case 14:
									awaiter = apfspvKqf3H9IkbQeqaZ(HrB4ODKqVZb1JepxDJ3v(I9MAs9Kqn21rKbMhoXsK(Ylph7uKqi0GPIDs8WqTv(undoTrainPattern.r87Fl5jLk2())), undoTrainPattern.JsCFyCZUQw(), undoTrainPattern.WrIFsrbm5P(), false, false));
									if (!awaiter.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto case 7;
								case 7:
									awaiter.GetResult();
									goto case 12;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									h6Ut6KKqD4mHhrpBobZC();
									if (!YEt5cwKqIukGN7XUMBZ0())
									{
										num3 = 16;
										continue;
									}
									num3 = 1;
									if (YEt5cwKqIukGN7XUMBZ0())
									{
										continue;
									}
									goto case 21;
								case 21:
									num2 = (_003C_003E1__state = 1);
									num3 = 15;
									continue;
								case 22:
									awaiter.GetResult();
									goto end_IL_0029;
								}
								break;
							}
							goto IL_0149;
							IL_01b4:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 7;
							if (YEt5cwKqIukGN7XUMBZ0())
							{
								goto IL_00bc;
							}
							goto IL_01d9;
							IL_01d9:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 8;
							if (YEt5cwKqIukGN7XUMBZ0())
							{
								goto IL_00bc;
							}
							goto IL_01f7;
							IL_01f7:
							awaiter = apfspvKqf3H9IkbQeqaZ(Task.CompletedTask);
							num3 = 20;
							if (h6Ut6KKqD4mHhrpBobZC())
							{
							}
							goto IL_00bc;
							IL_0149:
							num2 = (_003C_003E1__state = -1);
							num3 = 22;
							goto IL_00bc;
							end_IL_0029:
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
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					undoTrainPattern = _003C_003E4__this;
					goto case 2;
				case 0:
				case 5:
					break;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_03a0;
			IL_03a0:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_035a;
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
		internal static object Ylph7uKqi0GPIDs8WqTv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I9MAs9Kqn21rKbMhoXsK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HrB4ODKqVZb1JepxDJ3v(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter apfspvKqf3H9IkbQeqaZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yqOnI7KqdXteZX8rSKtE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ButtonViewModel)P_0).FireCommandExecuted();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YEt5cwKqIukGN7XUMBZ0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h6Ut6KKqD4mHhrpBobZC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private CvsInSight K99FVHYeMv;

	[CompilerGenerated]
	private string PNFFL1Gpct;

	[CompilerGenerated]
	private CvsCellRange PUiFJdg1QV;

	[CompilerGenerated]
	private CvsCellRange Ra5F9DvxUX;

	[CompilerGenerated]
	private ButtonViewModel oIqFrUygL6;

	[CompilerGenerated]
	private byte[] qssFhxMnbj;

	[CompilerGenerated]
	private byte[] tWfF8ZOEtJ;

	[CompilerGenerated]
	private byte[] FZbFmYyqOB;

	[CompilerGenerated]
	private byte[] M23F17MLw3;

	private string CellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PNFFL1Gpct;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PNFFL1Gpct = value;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)htDQ57sBtyXN08s0NNq(pFCU2GsZchF4Ad6ifnW(), CellName);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoTrainPattern(CvsInSight insight, string cellName, CvsCellLocation patternLocation, CvsCellLocation latchLocation, ButtonViewModel trainButton)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			default:
				c7ZFHCkEv9(new CvsCellRange(patternLocation));
				num = 6;
				break;
			case 6:
				OhOFxs3J6x(new CvsCellRange(latchLocation));
				num = 0;
				break;
			case 7:
				skxfufsPaKqeZJtwshH(this);
				num = 1;
				break;
			case 0:
				iHCF2dNNn2(trainButton);
				num = 9;
				break;
			case 1:
				yX8FTDd60Q(insight);
				UvTrpesvIaQbof3mFEa();
				if (kmJhI3ssrH34aEKrUk9())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 8;
				}
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 8:
				LXmldqsriMxanJWH5f5();
				num = 7;
				break;
			case 3:
			case 5:
				CellName = cellName;
				goto default;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private CvsInSight r87Fl5jLk2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return K99FVHYeMv;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void yX8FTDd60Q(CvsInSight value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		K99FVHYeMv = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private CvsCellRange gLlFOmSULX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PUiFJdg1QV;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void c7ZFHCkEv9(CvsCellRange value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PUiFJdg1QV = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private CvsCellRange JsCFyCZUQw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Ra5F9DvxUX;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void OhOFxs3J6x(CvsCellRange value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ra5F9DvxUX = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private ButtonViewModel n5pFeykSQI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return oIqFrUygL6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void iHCF2dNNn2(ButtonViewModel value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oIqFrUygL6 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private byte[] HrYFiacsmU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return qssFhxMnbj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void zsKFkcUpnC(byte[] value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qssFhxMnbj = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private byte[] WrIFsrbm5P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tWfF8ZOEtJ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void KZJFKyL0yN(byte[] value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tWfF8ZOEtJ = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private byte[] mMOFBa7j2o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return FZbFmYyqOB;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void nxkFZU4unH(byte[] value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FZbFmYyqOB = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private byte[] AYGFtpThl8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M23F17MLw3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void V6BFYJ9KHR(byte[] value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		M23F17MLw3 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__39))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UvTrpesvIaQbof3mFEa();
		int num;
		if (kmJhI3ssrH34aEKrUk9())
		{
			num = 1;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0075;
			}
		}
		goto IL_0042;
		IL_0042:
		_003CDo_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = GBrm1jsbjPUrs73vvHG();
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0075;
		IL_0075:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__40))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (kmJhI3ssrH34aEKrUk9())
		{
			num = 1;
			if (!kmJhI3ssrH34aEKrUk9())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (UvTrpesvIaQbof3mFEa())
			{
				goto IL_0078;
			}
		}
		goto IL_0092;
		IL_0042:
		_003CRedo_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0092;
		IL_0078:
		stateMachine._003C_003E1__state = -1;
		goto IL_0042;
		IL_002a:
		stateMachine._003C_003Et__builder = GBrm1jsbjPUrs73vvHG();
		num = 3;
		if (false)
		{
			goto IL_0042;
		}
		goto IL_0092;
		IL_0092:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 4:
				goto IL_0042;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto IL_0078;
			case 2:
			case 5:
				goto IL_0078;
			default:
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__41))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kmJhI3ssrH34aEKrUk9();
		int num = (UvTrpesvIaQbof3mFEa() ? 4 : 2);
		_003CSaveState_003Ed__41 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (UvTrpesvIaQbof3mFEa())
				{
				}
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = GBrm1jsbjPUrs73vvHG();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__42))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (kmJhI3ssrH34aEKrUk9())
		{
			num = 1;
		}
		else
		{
			num = 5;
			if (UvTrpesvIaQbof3mFEa())
			{
			}
		}
		_003CUndo_003Ed__42 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = GBrm1jsbjPUrs73vvHG();
				num = 4;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LXmldqsriMxanJWH5f5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void skxfufsPaKqeZJtwshH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kmJhI3ssrH34aEKrUk9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UvTrpesvIaQbof3mFEa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pFCU2GsZchF4Ad6ifnW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.b9WhqbwKKe();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object htDQ57sBtyXN08s0NNq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GBrm1jsbjPUrs73vvHG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
