using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;
using Cognex.InSight.Undo;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;

public class OutputLinksUndoAction : IUndoAction
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
			_ = 1;
			int num = (s1IHtNK2nnd2e1hk99Lv() ? 3 : 2);
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
							awaiter = lgNbQVK2f1jPfo1iT2uc(aLWTEIK2VFAhJTdZgZXi());
							num3 = 2;
							if (1 == 0)
							{
								goto IL_0041;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!eQnbwOK2ipDNB3RQEKvO())
							{
								goto IL_0076;
							}
						}
						goto IL_00eb;
						IL_0076:
						_003C_003Eu__1 = default;
						goto IL_0041;
						IL_00eb:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								break;
							case 5:
								return;
							case 7:
								goto IL_0076;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									goto IL_00b1;
								}
								goto case 9;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
							IL_00b1:
							s1IHtNK2nnd2e1hk99Lv();
							num3 = (eQnbwOK2ipDNB3RQEKvO() ? 4 : 3);
						}
						goto IL_0041;
						IL_0041:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (!eQnbwOK2ipDNB3RQEKvO())
						{
							return;
						}
						goto IL_00eb;
						end_IL_0024:;
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
				case 4:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
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
		internal static object aLWTEIK2VFAhJTdZgZXi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lgNbQVK2f1jPfo1iT2uc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eQnbwOK2ipDNB3RQEKvO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s1IHtNK2nnd2e1hk99Lv()
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

		public OutputLinksUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (sOMCCcK2lb3MYm5ZOnD2())
			{
				goto IL_001e;
			}
			goto IL_01a5;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (sOMCCcK2lb3MYm5ZOnD2())
			{
			}
			goto IL_01a5;
			IL_01a5:
			int num2 = default;
			OutputLinksUndoAction outputLinksUndoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							CYIVi0K2gTyKhJwWw8Gk(outputLinksUndoAction.h6wOXu41Uf, outputLinksUndoAction.pGqOS4bklR);
							num3 = 4;
							goto IL_012a;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00a5;
						IL_00a5:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_012a;
						IL_012a:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 5:
								return;
							case 4:
								awaiter = pTuX9LK2vJuqZikYiSlB(jK3L4IK2sdHlF1q0KGA6());
								num3 = 8;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 0:
							case 6:
								break;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (K3FLstK2dBcSEDW1CDA8())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								if (sOMCCcK2lb3MYm5ZOnD2())
								{
									num3 = 0;
									continue;
								}
								num3 = 1;
								if (!sOMCCcK2lb3MYm5ZOnD2())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_012a;
							}
							goto IL_00a5;
							continue;
							end_IL_012a:
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
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 5:
					outputLinksUndoAction = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!K3FLstK2dBcSEDW1CDA8())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (!K3FLstK2dBcSEDW1CDA8())
					{
						return;
					}
					continue;
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
		internal static void CYIVi0K2gTyKhJwWw8Gk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((OutputLinksViewModel)P_0).SelectedLink = (SourceLink)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jK3L4IK2sdHlF1q0KGA6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pTuX9LK2vJuqZikYiSlB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K3FLstK2dBcSEDW1CDA8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sOMCCcK2lb3MYm5ZOnD2()
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

		public OutputLinksUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (JBsWdgK2PqqeALFKd1SN())
			{
				goto IL_001e;
			}
			goto IL_017b;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_017b;
			IL_017b:
			OutputLinksUndoAction outputLinksUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cqWSTJK2ZgXhYvlJWKIj(outputLinksUndoAction.Do());
							num3 = 8;
							goto IL_009f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0109;
						IL_0109:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_009f;
						IL_009f:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								uTFfglK2rUMJH48pCVr0();
								num3 = (JBsWdgK2PqqeALFKd1SN() ? 4 : 7);
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (!JBsWdgK2PqqeALFKd1SN())
									{
										continue;
									}
									break;
								}
								goto case 9;
							case 4:
							case 5:
								break;
							case 0:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_009f;
							}
							goto IL_0109;
							continue;
							end_IL_009f:
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					outputLinksUndoAction = _003C_003E4__this;
					uTFfglK2rUMJH48pCVr0();
					num = (JBsWdgK2PqqeALFKd1SN() ? 4 : 0);
					continue;
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
		internal static TaskAwaiter cqWSTJK2ZgXhYvlJWKIj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uTFfglK2rUMJH48pCVr0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JBsWdgK2PqqeALFKd1SN()
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

		public OutputLinksUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			OutputLinksUndoAction outputLinksUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					outputLinksUndoAction = _003C_003E4__this;
					sJ87VAK2Blu6jXQUHm3r();
					num = (Un6i4NK2bKqcLMtINP1v() ? 1 : 4);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (Un6i4NK2bKqcLMtINP1v())
					{
					}
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							LjdBQuK2GY9pFPJrMZcD(outputLinksUndoAction.h6wOXu41Uf, outputLinksUndoAction.KZKOoqWolC);
							num3 = 5;
							if (false)
							{
								goto IL_007b;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!sJ87VAK2Blu6jXQUHm3r())
							{
								goto IL_0138;
							}
						}
						goto IL_0151;
						IL_00e7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						if (Un6i4NK2bKqcLMtINP1v())
						{
						}
						goto IL_0151;
						IL_0138:
						_003C_003Eu__1 = awaiter;
						goto IL_00e7;
						IL_007b:
						_003C_003Eu__1 = default;
						goto IL_00ae;
						IL_00ae:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_0151;
						IL_0151:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 5:
								awaiter = Task.CompletedTask.GetAwaiter();
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto IL_00ae;
							case 7:
							case 9:
								goto IL_00ae;
							case 6:
								if (!awaiter.IsCompleted)
								{
									goto IL_00cd;
								}
								goto case 10;
							case 8:
								goto IL_00e7;
							case 2:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 1:
								return;
							case 0:
								goto IL_0138;
							default:
								num3 = 8;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0058;
							}
							break;
							IL_00cd:
							Un6i4NK2bKqcLMtINP1v();
							num3 = (sJ87VAK2Blu6jXQUHm3r() ? 4 : 9);
						}
						goto IL_007b;
						end_IL_0058:;
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
		internal static void LjdBQuK2GY9pFPJrMZcD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((OutputLinksViewModel)P_0).SelectedLink = (SourceLink)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sJ87VAK2Blu6jXQUHm3r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Un6i4NK2bKqcLMtINP1v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private OutputLinksViewModel h6wOXu41Uf;

	private SourceLink KZKOoqWolC;

	private SourceLink pGqOS4bklR;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)jBZsx4TvhIvW7py7LLZ(Kt9JL5TlSlXnrd41CjI(), LhSR4CTgZDaqBb96ecp(h6wOXu41Uf), kiIISiTssIn8qEqeHRG(KZKOoqWolC), pGqOS4bklR.Text);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputLinksUndoAction(Output output)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!AXgheqTOa5AOOmqcPCh())
		{
			goto IL_001e;
		}
		goto IL_0087;
		IL_001e:
		pGqOS4bklR = MV2BQUTd6SxSaHYxOkY(wWRYTpTffiBfTpNUtU9(output)) as SourceLink;
		num = 7;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
				BI2OPjTijyoIO53W1tq(this);
				num = 5;
				if (AXgheqTOa5AOOmqcPCh())
				{
					continue;
				}
				goto case 2;
			case 2:
				GmyC7XTDovbkutkMrPU();
				num = 1;
				if (AXgheqTOa5AOOmqcPCh())
				{
					continue;
				}
				goto case 5;
			case 5:
				h6wOXu41Uf = (OutputLinksViewModel)Ggg55RTnecBhQEXsi4D(output);
				goto default;
			default:
				_ = 1;
				if (!phHm1jTIR7ndagtZKbp())
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				num = 0;
				continue;
			case 3:
			case 6:
				KZKOoqWolC = (SourceLink)vIqpfUTVp5pjqqeJ4dr(Ggg55RTnecBhQEXsi4D(output));
				break;
			case 7:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AXgheqTOa5AOOmqcPCh();
		int num = (phHm1jTIR7ndagtZKbp() ? 3 : 4);
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (phHm1jTIR7ndagtZKbp())
				{
				}
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
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
		int num = 4;
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = nKuuZHTrLalpJk5Sdcp();
				_ = 1;
				if (phHm1jTIR7ndagtZKbp())
				{
					num = 2;
					break;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (AXgheqTOa5AOOmqcPCh())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
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
		int num = 3;
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder = nKuuZHTrLalpJk5Sdcp();
				AXgheqTOa5AOOmqcPCh();
				if (phHm1jTIR7ndagtZKbp())
				{
					num = 0;
					if (!phHm1jTIR7ndagtZKbp())
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		phHm1jTIR7ndagtZKbp();
		int num;
		if (AXgheqTOa5AOOmqcPCh())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_008a;
		IL_005e:
		_003CUndo_003Ed__9 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 3:
				goto IL_005e;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder = nKuuZHTrLalpJk5Sdcp();
		goto IL_005e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GmyC7XTDovbkutkMrPU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BI2OPjTijyoIO53W1tq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ggg55RTnecBhQEXsi4D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Output)P_0).Signal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vIqpfUTVp5pjqqeJ4dr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputLinksViewModel)P_0).SelectedLink;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wWRYTpTffiBfTpNUtU9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Output)P_0).DioLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MV2BQUTd6SxSaHYxOkY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).JobResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AXgheqTOa5AOOmqcPCh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool phHm1jTIR7ndagtZKbp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kt9JL5TlSlXnrd41CjI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pd1hOYqP56();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LhSR4CTgZDaqBb96ecp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputLinksViewModel)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kiIISiTssIn8qEqeHRG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jBZsx4TvhIvW7py7LLZ(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nKuuZHTrLalpJk5Sdcp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
