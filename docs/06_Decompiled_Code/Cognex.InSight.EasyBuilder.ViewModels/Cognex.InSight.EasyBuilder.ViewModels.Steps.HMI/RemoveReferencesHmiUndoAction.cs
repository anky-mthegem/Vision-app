using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Runtime.ViewModels.EasyView;
using Cognex.InSight.Undo;
using Cognex.Utilities.Controls.ViewModels.Extensions;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.HMI;

public class RemoveReferencesHmiUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveReferencesHmiUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (rboTMt5a3bEmaMc3AKuN() ? 2 : 5);
			RemoveReferencesHmiUndoAction removeReferencesHmiUndoAction = default;
			int key = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<EasyViewItem>.Enumerator enumerator = removeReferencesHmiUndoAction.MHNenBFQaK.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									EasyViewItem current = enumerator.Current;
									rboTMt5a3bEmaMc3AKuN();
									int num3 = ((!d54gqB5a79Euirqssg5S()) ? 2 : 3);
									while (true)
									{
										switch (num3)
										{
										case 0:
										case 3:
											key = removeReferencesHmiUndoAction.HPueZbWQuU.Settings.Items.IndexOf(current);
											goto IL_00b0;
										default:
											goto IL_00b0;
										case 4:
											break;
										}
										break;
										IL_00b0:
										removeReferencesHmiUndoAction.F9YetOrPkZ[key] = current;
										num3 = 4;
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
							awaiter = ul7r8Q5a6XJwYwSO5nln(KwcdVj5aj6yGm5Huagj4());
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
				case 4:
					removeReferencesHmiUndoAction = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static object KwcdVj5aj6yGm5Huagj4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ul7r8Q5a6XJwYwSO5nln(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d54gqB5a79Euirqssg5S()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rboTMt5a3bEmaMc3AKuN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public EasyViewItem t;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass8_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bYkA9P5aRhIteLulZNjs();
			sxKWr05aWViqy6I28x0u(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CDo_003Eb__0(EasyViewItem item)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return R6RbDR5aybpOO7iKLWmX(s8W5lw5aT0JwxMhnUqbv(item), s8W5lw5aT0JwxMhnUqbv(t));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bYkA9P5aRhIteLulZNjs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sxKWr05aWViqy6I28x0u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a6oWyq5aC1D57UHVrrvK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HvuCVH5aAEydVvP4FK42()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object s8W5lw5aT0JwxMhnUqbv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyViewItem)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R6RbDR5aybpOO7iKLWmX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveReferencesHmiUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			RemoveReferencesHmiUndoAction removeReferencesHmiUndoAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (w9VKk05a0LeEhnpVONQO())
					{
						break;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							Dictionary<int, EasyViewItem>.ValueCollection.Enumerator enumerator = removeReferencesHmiUndoAction.F9YetOrPkZ.Values.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass8_0();
									_ = 0;
									int num3 = ((!w9VKk05a0LeEhnpVONQO()) ? 2 : 3);
									while (true)
									{
										switch (num3)
										{
										default:
											goto IL_007c;
										case 0:
										case 3:
											CS_0024_003C_003E8__locals2.t = enumerator.Current;
											goto IL_007c;
										case 4:
											break;
										}
										break;
										IL_007c:
										((EasyViewSettings)QX9T6Y5aMRDidogOKNim(removeReferencesHmiUndoAction.HPueZbWQuU)).Items.RemoveAll([MethodImpl(MethodImplOptions.NoInlining)] (EasyViewItem item) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass8_0.R6RbDR5aybpOO7iKLWmX(_003C_003Ec__DisplayClass8_0.s8W5lw5aT0JwxMhnUqbv(item), _003C_003Ec__DisplayClass8_0.s8W5lw5aT0JwxMhnUqbv(CS_0024_003C_003E8__locals2.t));
										});
										num3 = 4;
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
							awaiter = Wt6EoI5aYUjeMmZU8ous(Task.CompletedTask);
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
				case 0:
					removeReferencesHmiUndoAction = _003C_003E4__this;
					vpsBcP5aFWUlOVNZJvH9();
					num = ((!w9VKk05a0LeEhnpVONQO()) ? 1 : 4);
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
		internal static object QX9T6Y5aMRDidogOKNim(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HmiStepViewModel)P_0).Settings;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Wt6EoI5aYUjeMmZU8ous(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w9VKk05a0LeEhnpVONQO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vpsBcP5aFWUlOVNZJvH9()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveReferencesHmiUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (j7PwZu5aHDcj6lW5DXIc())
			{
				goto IL_001e;
			}
			goto IL_018b;
			IL_0037:
			int num2 = default;
			RemoveReferencesHmiUndoAction removeReferencesHmiUndoAction = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = GlfxFf5axvZe0KvyB1mc(removeReferencesHmiUndoAction.Do());
					num3 = 1;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
					if (j7PwZu5aHDcj6lW5DXIc())
					{
						goto IL_006f;
					}
				}
				while (true)
				{
					switch (num3)
					{
					case 8:
						return;
					case 3:
					case 6:
						break;
					default:
						num3 = 8;
						continue;
					case 0:
					case 2:
						_003C_003Eu__1 = awaiter;
						break;
					case 5:
						num2 = (_003C_003E1__state = 0);
						j7PwZu5aHDcj6lW5DXIc();
						num3 = ((!krIVrK5aUra1v5BA2hO1()) ? 6 : 0);
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							if (true)
							{
								continue;
							}
							goto case 4;
						}
						goto case 9;
					case 4:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (j7PwZu5aHDcj6lW5DXIc())
						{
						}
						continue;
					case 9:
						awaiter.GetResult();
						goto end_IL_008f;
					}
					goto IL_006f;
					continue;
					end_IL_008f:
					break;
				}
				goto end_IL_0037;
				IL_006f:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0037:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b6;
			IL_018b:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
				case 2:
					goto IL_0037;
				default:
					num = 5;
					continue;
				case 5:
					goto IL_01b6;
				case 3:
					goto IL_01cb;
				case 6:
					return;
				}
				break;
				IL_01cb:
				num2 = _003C_003E1__state;
				_ = 1;
				if (j7PwZu5aHDcj6lW5DXIc())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0037;
				}
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_001e;
			IL_01b6:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_018b;
			IL_001e:
			removeReferencesHmiUndoAction = _003C_003E4__this;
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
		internal static TaskAwaiter GlfxFf5axvZe0KvyB1mc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool krIVrK5aUra1v5BA2hO1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j7PwZu5aHDcj6lW5DXIc()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveReferencesHmiUndoAction _003C_003E4__this;

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
			goto IL_01a0;
			IL_001a:
			RemoveReferencesHmiUndoAction removeReferencesHmiUndoAction = _003C_003E4__this;
			num = 4;
			goto IL_01a0;
			IL_01a0:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (VwOZl95aQ9RonNe8LURB())
					{
					}
					continue;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							Dictionary<int, EasyViewItem>.Enumerator enumerator = removeReferencesHmiUndoAction.F9YetOrPkZ.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									KeyValuePair<int, EasyViewItem> current = enumerator.Current;
									_ = 1;
									int num3;
									if (!VwOZl95aQ9RonNe8LURB())
									{
										num3 = 2;
										if (!upiZkR5amuF86If8kqyJ())
										{
											goto IL_0085;
										}
									}
									else
									{
										num3 = 3;
									}
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										continue;
									}
									goto IL_0085;
									IL_0085:
									((EasyViewSettings)ppWkAr5aNaIM01rmqTRk(removeReferencesHmiUndoAction.HPueZbWQuU)).Items.Insert(current.Key, current.Value);
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = XQPecO5a2ylwELrDqUSJ(Task.CompletedTask);
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
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!VwOZl95aQ9RonNe8LURB()) ? 2 : 0);
					continue;
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
		internal static object ppWkAr5aNaIM01rmqTRk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((HmiStepViewModel)P_0).Settings;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XQPecO5a2ylwELrDqUSJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool upiZkR5amuF86If8kqyJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VwOZl95aQ9RonNe8LURB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly HmiStepViewModel HPueZbWQuU;

	private List<EasyViewItem> MHNenBFQaK;

	private readonly Dictionary<int, EasyViewItem> F9YetOrPkZ;

	[CompilerGenerated]
	private readonly string RRJeYgf73L;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RRJeYgf73L;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveReferencesHmiUndoAction(HmiStepViewModel hmi, List<EasyViewItem> itemsToBeRemoved)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		F9YetOrPkZ = new Dictionary<int, EasyViewItem>();
		base._002Ector();
		HPueZbWQuU = hmi;
		MHNenBFQaK = itemsToBeRemoved;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				s0mHEjQ0d17hqZu5GR9();
				if (nqIrs9QyRFM4yrT1Z4T())
				{
					num = 0;
					continue;
				}
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = HsVbq5QFGsovDh4eZmL();
				num = 1;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = HsVbq5QFGsovDh4eZmL();
				_ = 1;
				num = (s0mHEjQ0d17hqZu5GR9() ? 4 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (nqIrs9QyRFM4yrT1Z4T())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_0056;
			}
		}
		goto IL_0070;
		IL_0024:
		_003CRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0070;
		IL_0056:
		stateMachine._003C_003E1__state = -1;
		goto IL_0024;
		IL_0070:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto IL_0056;
			case 1:
			case 2:
				goto IL_0056;
			default:
				num = 5;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = HsVbq5QFGsovDh4eZmL();
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!s0mHEjQ0d17hqZu5GR9())
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
		}
		goto IL_0086;
		IL_0026:
		_003CUndo_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = HsVbq5QFGsovDh4eZmL();
		num = 5;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder HsVbq5QFGsovDh4eZmL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nqIrs9QyRFM4yrT1Z4T()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s0mHEjQ0d17hqZu5GR9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
