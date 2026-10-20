using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class UndoAddLink : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAddLink _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uvgfnIKuSGLHx8XF9yhV();
			int num;
			if (!pSo6PjKukadROat2cxc8())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (!uvgfnIKuSGLHx8XF9yhV())
				{
					goto IL_0075;
				}
			}
			goto IL_02af;
			IL_0039:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (pSo6PjKukadROat2cxc8())
			{
			}
			goto IL_02af;
			IL_0075:
			int num2 = default;
			UndoAddLink undoAddLink = default;
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_016f;
					}
					num3 = 2;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 10;
				}
				goto IL_01a0;
				IL_01a0:
				while (true)
				{
					switch (num3)
					{
					case 8:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						continue;
					case 4:
						if (!awaiter.IsCompleted)
						{
							num3 = 9;
							continue;
						}
						goto case 16;
					case 3:
						return;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							if (pSo6PjKukadROat2cxc8())
							{
							}
							continue;
						}
						goto IL_0212;
					case 2:
						awaiter = pFr6tlKuqi8fL46g4gI6(k2v1ymKu8AwlgEj4S2JV(undoAddLink.uT4HDkhaNh, undoAddLink.HcGH3nte7x, undoAddLink.AdVHIWhZVj));
						num3 = 7;
						continue;
					case 6:
					case 11:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						continue;
					case 0:
						_003C_003Eu__1 = awaiter;
						_ = 1;
						num3 = ((!pSo6PjKukadROat2cxc8()) ? 6 : 14);
						continue;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 15;
						continue;
					case 13:
					case 14:
						break;
					case 10:
						_003C_003Eu__1 = default;
						goto case 12;
					default:
						num3 = 12;
						continue;
					case 15:
						return;
					case 12:
						num2 = (_003C_003E1__state = -1);
						goto IL_0212;
					case 9:
						num2 = (_003C_003E1__state = 1);
						num3 = 0;
						if (pSo6PjKukadROat2cxc8())
						{
						}
						continue;
					case 5:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						if (uvgfnIKuSGLHx8XF9yhV())
						{
							continue;
						}
						goto case 16;
					case 16:
						{
							awaiter.GetResult();
							goto end_IL_01a0;
						}
						IL_0212:
						awaiter.GetResult();
						awaiter = pFr6tlKuqi8fL46g4gI6(RyPR6OKupXslSbD8Tesc(g8W2FTKuEIZJwoCBFHbZ(undoAddLink.uT4HDkhaNh)));
						num3 = 4;
						continue;
					}
					goto IL_016f;
					continue;
					end_IL_01a0:
					break;
				}
				goto end_IL_0075;
				IL_016f:
				num2 = (_003C_003E1__state = -1);
				num3 = 16;
				goto IL_01a0;
				end_IL_0075:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0039;
			IL_02af:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 3:
					break;
				case 5:
					undoAddLink = _003C_003E4__this;
					goto IL_0075;
				case 1:
				case 2:
					goto IL_0075;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0039;
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
		internal static object k2v1ymKu8AwlgEj4S2JV(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AddLink((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pFr6tlKuqi8fL46g4gI6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g8W2FTKuEIZJwoCBFHbZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RyPR6OKupXslSbD8Tesc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ReadCurrentPropertyLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uvgfnIKuSGLHx8XF9yhV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pSo6PjKukadROat2cxc8()
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
	private struct _003CRedo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAddLink _003C_003E4__this;

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
			TaskAwaiter awaiter = default;
			UndoAddLink undoAddLink = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					tArGOuKuXUYYwFoZuiaF();
					if (!KZ3L30Ku9TscGISgnOor())
					{
						num = 0;
						break;
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					return;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							_ = 0;
							if (tArGOuKuXUYYwFoZuiaF())
							{
								num3 = 15;
								if (false)
								{
									goto IL_009e;
								}
							}
							else
							{
								num3 = 5;
							}
						}
						goto IL_01a5;
						IL_01a5:
						while (true)
						{
							switch (num3)
							{
							case 8:
								return;
							case 5:
							case 13:
								break;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (tArGOuKuXUYYwFoZuiaF())
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = g0FM2YKu493Taajq42Iu(undoAddLink.uT4HDkhaNh.AddLink(undoAddLink.HcGH3nte7x, undoAddLink.AdVHIWhZVj));
								num3 = 4;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								break;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (tArGOuKuXUYYwFoZuiaF())
								{
									continue;
								}
								return;
							case 2:
								return;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 7:
								awaiter = g0FM2YKu493Taajq42Iu(TiksrnKu3B7qWHsP1NIm(LRNW2JKu7uSA8H7F8U3r(undoAddLink.uT4HDkhaNh)));
								num3 = 3;
								continue;
							case 6:
							case 15:
								awaiter.GetResult();
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								}
								goto case 16;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 14;
								if (tArGOuKuXUYYwFoZuiaF())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 6;
							case 16:
								awaiter.GetResult();
								goto end_IL_01a5;
							}
							goto IL_009e;
							continue;
							end_IL_01a5:
							break;
						}
						goto end_IL_004e;
						IL_009e:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_01a5;
						end_IL_004e:;
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
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					undoAddLink = _003C_003E4__this;
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
		internal static TaskAwaiter g0FM2YKu493Taajq42Iu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LRNW2JKu7uSA8H7F8U3r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TiksrnKu3B7qWHsP1NIm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ReadCurrentPropertyLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tArGOuKuXUYYwFoZuiaF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KZ3L30Ku9TscGISgnOor()
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
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
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
			k5H3ovKujYDoTQe2bqxI();
			int num;
			if (!PqZtRyKu66Fn4ouEEh9O())
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
			goto IL_016d;
			IL_01ab:
			_003C_003Et__builder.SetResult();
			num = 5;
			if (1 == 0)
			{
				return;
			}
			goto IL_016d;
			IL_016d:
			int num2 = default;
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
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 2:
					goto IL_01ab;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((Task)KNYHRjKuCDuXCXADp6oE()).GetAwaiter();
					k5H3ovKujYDoTQe2bqxI();
					num3 = (PqZtRyKu66Fn4ouEEh9O() ? 8 : 7);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 1:
						_003C_003Eu__1 = default;
						num3 = 5;
						continue;
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						goto case 3;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						continue;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						return;
					case 8:
						return;
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
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
			goto IL_01ab;
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
		internal static object KNYHRjKuCDuXCXADp6oE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k5H3ovKujYDoTQe2bqxI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PqZtRyKu66Fn4ouEEh9O()
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

		public UndoAddLink _003C_003E4__this;

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
			UndoAddLink undoAddLink = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (tqhvB7KuR7rRrOCdOZqQ() ? 3 : 5);
					break;
				case 1:
				case 5:
					undoAddLink = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								if (!tqhvB7KuR7rRrOCdOZqQ())
								{
									num3 = 4;
									if (!vltmuKKuAx15yDDXlSfC())
									{
										goto IL_008a;
									}
								}
								else
								{
									num3 = 15;
									if (tqhvB7KuR7rRrOCdOZqQ())
									{
										goto IL_01ef;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 5;
								if (tqhvB7KuR7rRrOCdOZqQ())
								{
									goto IL_0143;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00a5;
						IL_00a5:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							default:
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								goto IL_0143;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 1:
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_01ef;
							case 7:
								num2 = (_003C_003E1__state = 1);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 4:
								awaiter = r8apDkKuT6e9YLRRY46C(uaFYBOKuWgEtJK5KZFdi(undoAddLink.uT4HDkhaNh, undoAddLink.HcGH3nte7x));
								goto case 1;
							case 14:
								goto IL_01ef;
							case 10:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_008a;
						IL_0143:
						awaiter = r8apDkKuT6e9YLRRY46C(ENXCnuKu0wcU3CDeTQ49(GWQ0C9Kuyeu5CeAgKpIW(undoAddLink.uT4HDkhaNh)));
						num3 = 9;
						goto IL_00a5;
						IL_01ef:
						awaiter.GetResult();
						num3 = 13;
						goto IL_00a5;
						IL_008a:
						num2 = (_003C_003E1__state = -1);
						goto IL_01ef;
						end_IL_0061:;
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
		internal static object uaFYBOKuWgEtJK5KZFdi(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r8apDkKuT6e9YLRRY46C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GWQ0C9Kuyeu5CeAgKpIW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ENXCnuKu0wcU3CDeTQ49(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ReadCurrentPropertyLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vltmuKKuAx15yDDXlSfC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tqhvB7KuR7rRrOCdOZqQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly PropertyLinks uT4HDkhaNh;

	private readonly string HcGH3nte7x;

	private readonly string AdVHIWhZVj;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)KSx5Dhy6eaGGj0IEHxb(Resources.BQQhMdtDAe(), HcGH3nte7x, AdVHIWhZVj);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoAddLink(PropertyLinks links, string dstName, string srcName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Kg0yI7y4CaqDqxiToqs()) ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				TtjEDuyjhJT6cJLxAfu(this);
				num = 2;
				continue;
			case 6:
				AdVHIWhZVj = srcName;
				num = 7;
				continue;
			case 2:
				uT4HDkhaNh = links;
				break;
			default:
				num = 3;
				continue;
			case 3:
				break;
			case 0:
			case 4:
				AmMhajy3Ao35vscgxw9();
				goto case 1;
			case 7:
				return;
			}
			HcGH3nte7x = dstName;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__6))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Kg0yI7y4CaqDqxiToqs()) ? 3 : 5);
		_003CDo_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = ANF78iyCi9FkwwPJRxb();
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__7))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!eo0mGAy7Oa4gipG5XVi()) ? 1 : 5);
		_003CRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = ANF78iyCi9FkwwPJRxb();
				num = 4;
				if (!eo0mGAy7Oa4gipG5XVi())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (Kg0yI7y4CaqDqxiToqs() ? 1 : 4);
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
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
		eo0mGAy7Oa4gipG5XVi();
		int num = ((!Kg0yI7y4CaqDqxiToqs()) ? 4 : 2);
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = ANF78iyCi9FkwwPJRxb();
				goto case 1;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AmMhajy3Ao35vscgxw9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TtjEDuyjhJT6cJLxAfu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Kg0yI7y4CaqDqxiToqs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eo0mGAy7Oa4gipG5XVi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KSx5Dhy6eaGGj0IEHxb(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ANF78iyCi9FkwwPJRxb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
