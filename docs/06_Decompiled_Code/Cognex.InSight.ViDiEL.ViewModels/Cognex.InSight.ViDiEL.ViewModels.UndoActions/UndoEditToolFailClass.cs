using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoEditToolFailClass : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__6 : IAsyncStateMachine
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
			_ = 0;
			int num = ((!oQQ7m0svBOssvBLZspD()) ? 4 : 2);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = PgwInhsOU0XujyJQbup(i2EedSs0gFNwm7faG1m());
							oQQ7m0svBOssvBLZspD();
							if (!or5l66sZdpmcgsjOFSB())
							{
								num3 = 7;
							}
							else
							{
								num3 = 8;
								if (or5l66sZdpmcgsjOFSB())
								{
									goto IL_00f3;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (!oQQ7m0svBOssvBLZspD())
							{
								goto IL_014f;
							}
						}
						goto IL_00b0;
						IL_00f3:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						if (true)
						{
							goto IL_00b0;
						}
						goto IL_0106;
						IL_0165:
						awaiter.GetResult();
						goto end_IL_0052;
						IL_011e:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (1 == 0)
						{
							return;
						}
						goto IL_00b0;
						IL_0106:
						_003C_003Eu__1 = default;
						num3 = 5;
						if (0 == 0)
						{
							goto IL_00b0;
						}
						goto IL_011e;
						IL_00b0:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 6:
								break;
							case 1:
								goto IL_0106;
							case 5:
								goto IL_011e;
							case 8:
								return;
							case 0:
							case 7:
								goto IL_014f;
							case 9:
								goto IL_0165;
							}
							break;
						}
						goto IL_00f3;
						IL_014f:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							goto IL_00b0;
						}
						goto IL_0165;
						end_IL_0052:;
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
		internal static object i2EedSs0gFNwm7faG1m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PgwInhsOU0XujyJQbup(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oQQ7m0svBOssvBLZspD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool or5l66sZdpmcgsjOFSB()
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
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEditToolFailClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hsSPXHsH57OSDloUmbA();
			int num = (bfvr4msTFdVv8jUEl3q() ? 2 : 3);
			int num2 = default;
			UndoEditToolFailClass undoEditToolFailClass = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = IP9SDXsYrMGFjkZCfhk(undoEditToolFailClass.f1nIUQ3bWU(undoEditToolFailClass.BpV2IDCgIt));
							_ = 1;
							if (!bfvr4msTFdVv8jUEl3q())
							{
								num3 = 1;
								if (!hsSPXHsH57OSDloUmbA())
								{
									goto IL_005c;
								}
							}
							else
							{
								num3 = 2;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0107;
						IL_005c:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						if (1 == 0)
						{
							goto IL_0071;
						}
						goto IL_0107;
						IL_0071:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_0107;
						IL_0107:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 6:
								goto IL_0071;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								if (!bfvr4msTFdVv8jUEl3q())
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (bfvr4msTFdVv8jUEl3q())
								{
								}
								continue;
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							default:
								return;
							case 2:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_0028;
							}
							break;
						}
						goto IL_005c;
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
				default:
					num = 5;
					continue;
				case 1:
				case 2:
					undoEditToolFailClass = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
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
		internal static TaskAwaiter IP9SDXsYrMGFjkZCfhk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hsSPXHsH57OSDloUmbA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bfvr4msTFdVv8jUEl3q()
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
	private struct _003CRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEditToolFailClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!SNiYZVsJbUJm7qsTTb1())
			{
				goto IL_001e;
			}
			goto IL_0183;
			IL_0035:
			int num2 = default;
			UndoEditToolFailClass undoEditToolFailClass = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = NmIGWvsCci45q10kB4f(undoEditToolFailClass.f1nIUQ3bWU(undoEditToolFailClass.BpV2IDCgIt));
					num3 = 0;
					goto IL_010c;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00a7;
				IL_00a7:
				_003C_003Eu__1 = default;
				num3 = 4;
				if (!SNiYZVsJbUJm7qsTTb1())
				{
					goto IL_00c3;
				}
				goto IL_010c;
				IL_00c3:
				if (!awaiter.IsCompleted)
				{
					num3 = 6;
					goto IL_010c;
				}
				goto IL_0143;
				IL_010c:
				while (true)
				{
					switch (num3)
					{
					case 6:
						break;
					case 2:
					case 3:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						continue;
					case 7:
						return;
					case 5:
					case 8:
						goto end_IL_010c;
					case 0:
						goto IL_00c3;
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						continue;
					case 9:
						goto IL_0143;
					}
					num2 = (_003C_003E1__state = 0);
					DrhW7hsKSdRMtBEuJTs();
					num3 = ((!SNiYZVsJbUJm7qsTTb1()) ? 8 : 3);
					continue;
					end_IL_010c:
					break;
				}
				goto IL_00a7;
				IL_0143:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ae;
			IL_0183:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 2:
				case 4:
					goto IL_0035;
				default:
					num = 0;
					continue;
				case 0:
					goto IL_01ae;
				case 3:
					goto IL_01c3;
				case 6:
					return;
				}
				break;
				IL_01c3:
				num2 = _003C_003E1__state;
				SNiYZVsJbUJm7qsTTb1();
				if (DrhW7hsKSdRMtBEuJTs())
				{
					num = 4;
					continue;
				}
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_001e;
			IL_01ae:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0183;
			IL_001e:
			undoEditToolFailClass = _003C_003E4__this;
			goto IL_0035;
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
		internal static TaskAwaiter NmIGWvsCci45q10kB4f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SNiYZVsJbUJm7qsTTb1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DrhW7hsKSdRMtBEuJTs()
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
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEditToolFailClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			UndoEditToolFailClass undoEditToolFailClass = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoEditToolFailClass.f1nIUQ3bWU(!undoEditToolFailClass.BpV2IDCgIt).GetAwaiter();
							num3 = 4;
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
								if (!awaiter.IsCompleted)
								{
									CIvSycsAsViwe5sG2Ly();
									num3 = (qjmWSpsNRq3kZV0XnYc() ? 2 : 6);
									continue;
								}
								break;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 5:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (qjmWSpsNRq3kZV0XnYc())
								{
								}
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					undoEditToolFailClass = _003C_003E4__this;
					num = 4;
					break;
				case 5:
					num2 = _003C_003E1__state;
					qjmWSpsNRq3kZV0XnYc();
					if (!CIvSycsAsViwe5sG2Ly())
					{
						num = 2;
						if (0 == 0)
						{
							break;
						}
						goto default;
					}
					num = 0;
					if (qjmWSpsNRq3kZV0XnYc())
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
		internal static bool CIvSycsAsViwe5sG2Ly()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qjmWSpsNRq3kZV0XnYc()
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
	private struct _003CSetIsFail_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEditToolFailClass _003C_003E4__this;

		public bool isFail;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!nVrtbpswswOfElH6WBw()) ? 5 : 4);
			UndoEditToolFailClass undoEditToolFailClass = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					undoEditToolFailClass = _003C_003E4__this;
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)q3UgUfsGU47he5WT3XT(undoEditToolFailClass.wadIzFiQHK);
							num3 = 2;
							if (!nVrtbpswswOfElH6WBw())
							{
								goto IL_0085;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (false)
							{
								goto IL_00f3;
							}
						}
						goto IL_015f;
						IL_00f3:
						_003C_003Eu__1 = default;
						goto IL_0133;
						IL_0133:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_015f;
						IL_0085:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						goto IL_015f;
						IL_015f:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 2:
								if (classifier != null)
								{
									awaiter = v2LtegsjDEZbjr7etsg(uOYhZBsRFHwsM5dGuAD(classifier, undoEditToolFailClass.wDX2OiZZHJ, isFail));
									num3 = 4;
									continue;
								}
								goto end_IL_0063;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 3:
							case 5:
								return;
							case 6:
								goto IL_00f3;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								num3 = ((!L1VIsaspal6SmNoBDLK()) ? 3 : 0);
								continue;
							case 0:
							case 7:
								goto IL_0133;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0063;
							}
							break;
						}
						goto IL_0085;
						end_IL_0063:;
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
		internal static object q3UgUfsGU47he5WT3XT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uOYhZBsRFHwsM5dGuAD(object P_0, object P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).F5oYhHPHM((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v2LtegsjDEZbjr7etsg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nVrtbpswswOfElH6WBw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L1VIsaspal6SmNoBDLK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IClassifierHandle wadIzFiQHK;

	private readonly string wDX2OiZZHJ;

	private readonly bool BpV2IDCgIt;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)MsyLPMX7xTfD3TuM9Ar(PCWZCWXbuOngfe6spjJ(), wDX2OiZZHJ, BpV2IDCgIt ? gD1qReXl1wXFjMgJFN5() : tyr2ehXefqK7DufYgeu());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoEditToolFailClass(IClassifierHandle classifierHandle, string classLabel, bool isFail)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (DWdRTeXRm9cf5u1TMgw())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (!DWdRTeXRm9cf5u1TMgw())
			{
				goto IL_00af;
			}
		}
		goto IL_0074;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 6:
				BpV2IDCgIt = isFail;
				num = 7;
				continue;
			case 0:
			case 4:
				qeqSIcXI2eOOU6wNsYu();
				num = 2;
				if (DWdRTeXRm9cf5u1TMgw())
				{
					continue;
				}
				goto default;
			default:
				wDX2OiZZHJ = classLabel;
				num = 6;
				continue;
			case 1:
				wadIzFiQHK = classifierHandle;
				goto default;
			case 2:
				break;
			case 7:
				return;
			}
			break;
		}
		goto IL_00af;
		IL_00af:
		Ru85k7XW3rj66Dek6Mo(this);
		num = 1;
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!DWdRTeXRm9cf5u1TMgw()) ? 2 : 4);
		_003CSaveState_003Ed__6 stateMachine = default;
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
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = K8GVdNXyqbxrRsguVBK();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!DWdRTeXRm9cf5u1TMgw()) ? 4 : 5);
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = K8GVdNXyqbxrRsguVBK();
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__8))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DWdRTeXRm9cf5u1TMgw();
		int num;
		if (!fDAD7FXjQSlacOyoOwy())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (!DWdRTeXRm9cf5u1TMgw())
			{
				goto IL_0062;
			}
		}
		goto IL_007c;
		IL_00c1:
		_003CRedo_003Ed__8 stateMachine = default;
		return stateMachine._003C_003Et__builder.Task;
		IL_0062:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a7;
		IL_007c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (DWdRTeXRm9cf5u1TMgw())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 4:
				break;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_00a7;
			case 6:
				goto IL_00c1;
			}
			break;
		}
		goto IL_0062;
		IL_00a7:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (true)
		{
			goto IL_007c;
		}
		goto IL_00c1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!fDAD7FXjQSlacOyoOwy())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				do
				{
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					DWdRTeXRm9cf5u1TMgw();
					if (fDAD7FXjQSlacOyoOwy())
					{
						num = 5;
						continue;
					}
					num = 0;
					break;
				}
				while (!DWdRTeXRm9cf5u1TMgw());
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetIsFail_003Ed__10))]
	private Task f1nIUQ3bWU(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fDAD7FXjQSlacOyoOwy())
		{
			num = 6;
		}
		else
		{
			num = 3;
			if (fDAD7FXjQSlacOyoOwy())
			{
				goto IL_0058;
			}
		}
		goto IL_0084;
		IL_0084:
		_003CSetIsFail_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				continue;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = K8GVdNXyqbxrRsguVBK();
				break;
			case 1:
			case 3:
				break;
			case 2:
				stateMachine.isFail = P_0;
				goto case 5;
			default:
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0058;
		IL_0058:
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_0084;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qeqSIcXI2eOOU6wNsYu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ru85k7XW3rj66Dek6Mo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DWdRTeXRm9cf5u1TMgw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fDAD7FXjQSlacOyoOwy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PCWZCWXbuOngfe6spjJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SetClassToolResultFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tyr2ehXefqK7DufYgeu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gD1qReXl1wXFjMgJFN5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Fail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MsyLPMX7xTfD3TuM9Ar(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder K8GVdNXyqbxrRsguVBK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
