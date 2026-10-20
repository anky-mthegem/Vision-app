using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public class UndoToolNameChange : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoToolNameChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0164;
			IL_01ac:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_0164;
			IL_0164:
			UndoToolNameChange undoToolNameChange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0195;
				case 5:
					goto IL_01ac;
				case 1:
					goto IL_01bd;
				case 6:
					return;
				}
				break;
				IL_01bd:
				undoToolNameChange = _003C_003E4__this;
				_ = 1;
				if (jFFj0KK87qi4IngshJwm())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (false)
				{
					return;
				}
			}
			goto IL_001a;
			IL_0195:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (0 == 0)
			{
				goto IL_0164;
			}
			goto IL_01ac;
			IL_001a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = undoToolNameChange.OZOFScVJ7A(undoToolNameChange.jbAFfqKIG4(), undoToolNameChange.HlPFcMckOL()).GetAwaiter();
					num3 = 1;
					goto IL_00ae;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00e5;
				IL_00e5:
				_003C_003Eu__1 = default;
				num3 = 6;
				goto IL_00ae;
				IL_00ae:
				while (true)
				{
					switch (num3)
					{
					case 7:
						return;
					case 2:
					case 3:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						continue;
					case 8:
						num2 = (_003C_003E1__state = 0);
						_ = 0;
						num3 = (hRigQ2K847HfxLYeWfgf() ? 3 : 4);
						continue;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						continue;
					case 4:
					case 5:
						break;
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto case 9;
					case 9:
						awaiter.GetResult();
						goto end_IL_00ae;
					}
					goto IL_00e5;
					continue;
					end_IL_00ae:
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
			goto IL_0195;
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
		internal static bool hRigQ2K847HfxLYeWfgf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jFFj0KK87qi4IngshJwm()
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
	private struct _003CRedo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoToolNameChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (gR8Y3qK8jS4qY0uRtfrW() ? 2 : 3);
			UndoToolNameChange undoToolNameChange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoToolNameChange = _003C_003E4__this;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoToolNameChange.OZOFScVJ7A(undoToolNameChange.jbAFfqKIG4(), undoToolNameChange.HlPFcMckOL()).GetAwaiter();
							num3 = 2;
							goto IL_0100;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00b5;
						IL_00b5:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0100;
						IL_0100:
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 0:
							case 4:
								return;
							case 5:
							case 7:
								break;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								kJpClbK83I9skPU2ejvI();
								num3 = (gR8Y3qK8jS4qY0uRtfrW() ? 7 : 0);
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0100;
							}
							goto IL_00b5;
							continue;
							end_IL_0100:
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
				case 5:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static bool kJpClbK83I9skPU2ejvI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gR8Y3qK8jS4qY0uRtfrW()
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
	private struct _003CSaveState_003Ed__17 : IAsyncStateMachine
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
			int num = 4;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 4:
					num2 = _003C_003E1__state;
					iIh21WK8CjegxBMYZPBq();
					if (WCfwrEK86SyZk2ZkAUY2())
					{
						num = 0;
						if (iIh21WK8CjegxBMYZPBq())
						{
						}
					}
					else
					{
						num = 3;
						if (iIh21WK8CjegxBMYZPBq())
						{
							return;
						}
					}
					break;
				case 0:
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)DHi4hIK8ATO3y6QkYZky()).GetAwaiter();
							iIh21WK8CjegxBMYZPBq();
							num3 = ((!WCfwrEK86SyZk2ZkAUY2()) ? 7 : 3);
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
							case 8:
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 0:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (!iIh21WK8CjegxBMYZPBq())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
					goto default;
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
		internal static object DHi4hIK8ATO3y6QkYZky()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WCfwrEK86SyZk2ZkAUY2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iIh21WK8CjegxBMYZPBq()
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
	private struct _003CUndo_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoToolNameChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!QIHUluK8WMDIdIrOj2Ja())
			{
			}
			int num2 = default;
			UndoToolNameChange undoToolNameChange = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!RYtq67K8R8eDu2S3sUtg()) ? 5 : 0);
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoToolNameChange.OZOFScVJ7A(undoToolNameChange.HlPFcMckOL(), undoToolNameChange.jbAFfqKIG4()).GetAwaiter();
							RYtq67K8R8eDu2S3sUtg();
							num3 = (QIHUluK8WMDIdIrOj2Ja() ? 6 : 7);
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
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (RYtq67K8R8eDu2S3sUtg())
									{
										continue;
									}
									return;
								}
								break;
							case 2:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
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
					goto case 4;
				default:
					num = 4;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					undoToolNameChange = _003C_003E4__this;
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
		internal static bool RYtq67K8R8eDu2S3sUtg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QIHUluK8WMDIdIrOj2Ja()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public string currentName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass19_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			K4l0X4K802XbRHnksWmO(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CWriteToolName_003Eb__0(EzSnippet t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eN9wjTK8MRU65vAC0MaG(Wr1LwkK8FpwYOLCZvliA(t), currentName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K4l0X4K802XbRHnksWmO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NSG7amK8Tr5EVaeNHmCH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool as9j2BK8yrnPdB6GU8V5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Wr1LwkK8FpwYOLCZvliA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eN9wjTK8MRU65vAC0MaG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteToolName_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string currentName;

		public UndoToolNameChange _003C_003E4__this;

		public string newName;

		private TaskAwaiter _003C_003Eu__1;

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
			goto IL_01c8;
			IL_001a:
			int num2 = default;
			UndoToolNameChange undoToolNameChange = default;
			try
			{
				_003C_003Ec__DisplayClass19_0 obj = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					obj = new _003C_003Ec__DisplayClass19_0();
					num3 = 0;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
					if (false)
					{
						goto IL_00b5;
					}
				}
				goto IL_012d;
				IL_00b5:
				EzSnippet ezSnippet = undoToolNameChange.DbBFD7xShG().Snippets.FirstOrDefault(obj._003CWriteToolName_003Eb__0);
				r3hrfVK8YFHj8cIaNRdM();
				num3 = ((!oA7CrwK8U7iGOkhGKG4n()) ? 6 : 11);
				goto IL_012d;
				IL_012d:
				while (true)
				{
					switch (num3)
					{
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						continue;
					case 0:
						obj.currentName = currentName;
						num3 = 9;
						continue;
					case 1:
						awaiter = ikI60PK8xoyp19R9aXlv(aDyuWoK8H6tQKaHGEQiW(ezSnippet, newName));
						num3 = 5;
						continue;
					case 10:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 7:
						return;
					case 11:
						return;
					case 9:
						break;
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 12;
						continue;
					case 2:
					case 6:
						if (ezSnippet != null)
						{
							num3 = 1;
							continue;
						}
						goto end_IL_012d;
					case 5:
						if (!awaiter.IsCompleted)
						{
							goto case 3;
						}
						goto case 12;
					default:
						num3 = 3;
						continue;
					case 4:
						_003C_003Eu__1 = default;
						num3 = 8;
						continue;
					case 12:
						awaiter.GetResult();
						goto end_IL_012d;
					}
					goto IL_00b5;
					continue;
					end_IL_012d:
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
			goto IL_020a;
			IL_01c8:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					undoToolNameChange = _003C_003E4__this;
					break;
				case 3:
					goto IL_020a;
				case 5:
					goto IL_021f;
				case 6:
					return;
				}
				break;
				IL_021f:
				num2 = _003C_003E1__state;
				oA7CrwK8U7iGOkhGKG4n();
				num = ((!r3hrfVK8YFHj8cIaNRdM()) ? 4 : 0);
			}
			goto IL_001a;
			IL_020a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c8;
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
		internal static object aDyuWoK8H6tQKaHGEQiW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).llY5g2dfVP((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ikI60PK8xoyp19R9aXlv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r3hrfVK8YFHj8cIaNRdM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oA7CrwK8U7iGOkhGKG4n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private AppStepViewModel AHCFMBOPuP;

	[CompilerGenerated]
	private string oKJFRj16DT;

	[CompilerGenerated]
	private string CLmF4R0O7S;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)N7x9myslLTgOnI4BrKX(fwKn66sdgUHD84CeTI8(), jbAFfqKIG4(), HlPFcMckOL());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoToolNameChange(AppStepViewModel appStepVm, string oldName, string newName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WidVf1sVAPr2yORxrE6())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_005d;
			}
		}
		goto IL_0076;
		IL_005d:
		b9mF3y9MBQ(appStepVm);
		goto IL_0035;
		IL_0035:
		R3qFEKqQnr(oldName);
		num = 3;
		goto IL_0076;
		IL_0076:
		while (true)
		{
			switch (num)
			{
			case 3:
				n76FQA2V5g(newName);
				num = 7;
				continue;
			case 6:
				break;
			case 0:
			case 5:
				hYX6uesfidIcnqBNR3F();
				goto case 1;
			case 2:
				goto IL_005d;
			default:
				num = 6;
				continue;
			case 1:
			case 4:
				base._002Ector();
				num = 2;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0035;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private AppStepViewModel DbBFD7xShG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AHCFMBOPuP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void b9mF3y9MBQ(AppStepViewModel value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AHCFMBOPuP = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string jbAFfqKIG4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return oKJFRj16DT;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void R3qFEKqQnr(string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oKJFRj16DT = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string HlPFcMckOL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CLmF4R0O7S;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void n76FQA2V5g(string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CLmF4R0O7S = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__15))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (dpWuPNsngVDr4mH9ZT4())
		{
			num = 1;
			if (WidVf1sVAPr2yORxrE6())
			{
			}
		}
		else
		{
			num = 3;
		}
		_003CDo_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = nfvUd1sgDWKrmkSfZjF();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__16))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WidVf1sVAPr2yORxrE6();
		int num;
		if (dpWuPNsngVDr4mH9ZT4())
		{
			num = 4;
			if (WidVf1sVAPr2yORxrE6())
			{
			}
		}
		else
		{
			num = 2;
		}
		_003CRedo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WidVf1sVAPr2yORxrE6())
				{
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = nfvUd1sgDWKrmkSfZjF();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (WidVf1sVAPr2yORxrE6())
				{
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__17))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WidVf1sVAPr2yORxrE6() ? 2 : 4);
		_003CSaveState_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__18))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WidVf1sVAPr2yORxrE6();
		int num = ((!dpWuPNsngVDr4mH9ZT4()) ? 2 : 4);
		_003CUndo_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteToolName_003Ed__19))]
	private Task OZOFScVJ7A(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WidVf1sVAPr2yORxrE6())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (!dpWuPNsngVDr4mH9ZT4())
			{
				goto IL_006c;
			}
		}
		goto IL_00ba;
		IL_006c:
		_003CWriteToolName_003Ed__19 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 3;
		if (WidVf1sVAPr2yORxrE6())
		{
			goto IL_0088;
		}
		goto IL_00ba;
		IL_0088:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		goto IL_00ba;
		IL_00ba:
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.currentName = P_0;
				num = 6;
				if (dpWuPNsngVDr4mH9ZT4())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 7;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto IL_0088;
			case 0:
			case 1:
				break;
			case 4:
			case 5:
				goto IL_0088;
			case 6:
				stateMachine.newName = P_1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hYX6uesfidIcnqBNR3F()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dpWuPNsngVDr4mH9ZT4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WidVf1sVAPr2yORxrE6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fwKn66sdgUHD84CeTI8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.wUXheeBbQ4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N7x9myslLTgOnI4BrKX(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nfvUd1sgDWKrmkSfZjF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
