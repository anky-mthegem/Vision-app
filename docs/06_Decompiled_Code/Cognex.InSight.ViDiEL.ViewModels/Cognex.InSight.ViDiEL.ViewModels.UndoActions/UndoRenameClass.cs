using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoRenameClass : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRenameClass _003C_003E4__this;

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
			if (TgaMovdzPlZceaHYC85())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_01a1;
				}
			}
			goto IL_016e;
			IL_016e:
			int num2 = default;
			UndoRenameClass undoRenameClass = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = v7Xr0REMbB5QaKBYYRp(W8vOfeEXn4VLUyNUWAd(undoRenameClass));
							num3 = 5;
							if (false)
							{
								goto IL_0042;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00a2;
						IL_00a2:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								break;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (TgaMovdzPlZceaHYC85())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 0:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								fnsT35E2k1wq1jsDlGc();
								num3 = ((!TgaMovdzPlZceaHYC85()) ? 3 : 4);
								continue;
							case 1:
								_003C_003Eu__1 = default;
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00a2;
							}
							goto IL_0042;
							continue;
							end_IL_00a2:
							break;
						}
						goto end_IL_0024;
						IL_0042:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00a2;
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
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 2:
					undoRenameClass = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_01a1;
			IL_01a1:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (fnsT35E2k1wq1jsDlGc())
			{
			}
			goto IL_016e;
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
		internal static object W8vOfeEXn4VLUyNUWAd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v7Xr0REMbB5QaKBYYRp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TgaMovdzPlZceaHYC85()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fnsT35E2k1wq1jsDlGc()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRenameClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!jO36DnEmWVATM4FCmcE()) ? 1 : 5);
			UndoRenameClass undoRenameClass = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					undoRenameClass = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = undoRenameClass.Woj2nI1xn1.GetClassifier();
							num3 = 9;
							goto IL_0098;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0128;
						IL_0128:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_0098;
						IL_0098:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								num3 = ((!jO36DnEmWVATM4FCmcE()) ? 1 : 5);
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (true)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 5:
							case 6:
								break;
							case 9:
								if (classifier != null)
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								}
								goto end_IL_0098;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								}
								goto case 10;
							case 8:
								awaiter = hYied3ErOiUqRP7c180(classifier.vWIlFv0oG(undoRenameClass.MLo2HrZN9U, undoRenameClass.QIR2pqcBHr));
								num3 = 0;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0098;
							}
							goto IL_0128;
							continue;
							end_IL_0098:
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
		internal static TaskAwaiter hYied3ErOiUqRP7c180(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vv05HQEkqUQjbggEugI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jO36DnEmWVATM4FCmcE()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRenameClass _003C_003E4__this;

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
			UndoRenameClass undoRenameClass = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					undoRenameClass = _003C_003E4__this;
					CHGxbaE4O7W0jeT6xTC();
					num = (wmjIdFEPuvIMG0KGFVb() ? 1 : 0);
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)uZjM22EgiFh6Sklucpo(undoRenameClass.Woj2nI1xn1);
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 7;
							if (CHGxbaE4O7W0jeT6xTC())
							{
								goto IL_0140;
							}
						}
						goto IL_00ac;
						IL_0140:
						if (classifier != null)
						{
							CHGxbaE4O7W0jeT6xTC();
							num3 = (wmjIdFEPuvIMG0KGFVb() ? 3 : 9);
							goto IL_00ac;
						}
						goto end_IL_005f;
						IL_00ac:
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								return;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (true)
								{
									continue;
								}
								return;
							case 9:
								return;
							case 0:
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 3:
								awaiter = EkDFdGE1NxOxrHkYb7G(classifier.vWIlFv0oG(undoRenameClass.QIR2pqcBHr, undoRenameClass.MLo2HrZN9U));
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_00ac;
							}
							goto IL_0140;
							continue;
							end_IL_00ac:
							break;
						}
						end_IL_005f:;
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
		internal static object uZjM22EgiFh6Sklucpo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EkDFdGE1NxOxrHkYb7G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wmjIdFEPuvIMG0KGFVb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CHGxbaE4O7W0jeT6xTC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IClassifierHandle Woj2nI1xn1;

	private string MLo2HrZN9U;

	private string QIR2pqcBHr;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)aMnGg9MaDib6VoncNBR(Resources.RenameClass, MLo2HrZN9U, QIR2pqcBHr);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRenameClass(IClassifierHandle handle, string oldClassName, string newClassName)
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
		goto IL_0082;
		IL_001a:
		WJgNi7M3AO18rZyAUli(this);
		num = 4;
		goto IL_0082;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				MLo2HrZN9U = oldClassName;
				num = 0;
				continue;
			case 0:
				QIR2pqcBHr = newClassName;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				oUaB0fM5kKK0q0acsxy();
				_ = 1;
				num = (DRbUiAMEjkAcS0Gd2tg() ? 5 : 2);
				continue;
			case 4:
				Woj2nI1xn1 = handle;
				goto default;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				DUIFbWMdUu92LgpuwgU();
				num = (DRbUiAMEjkAcS0Gd2tg() ? 5 : 0);
				continue;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (DUIFbWMdUu92LgpuwgU())
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
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
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DUIFbWMdUu92LgpuwgU();
		int num = ((!DRbUiAMEjkAcS0Gd2tg()) ? 1 : 4);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = mWeZ3uMo9Hk53aaj77q();
				num = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)SpdTH5McG2h2cRY0yUM();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = mWeZ3uMo9Hk53aaj77q();
				num = 0;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (DRbUiAMEjkAcS0Gd2tg())
				{
				}
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				do
				{
					stateMachine._003C_003E4__this = this;
					_ = 0;
					if (!DUIFbWMdUu92LgpuwgU())
					{
						num = 5;
						continue;
					}
					num = 4;
					if (DRbUiAMEjkAcS0Gd2tg())
					{
					}
					break;
				}
				while (!DUIFbWMdUu92LgpuwgU());
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oUaB0fM5kKK0q0acsxy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WJgNi7M3AO18rZyAUli(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DUIFbWMdUu92LgpuwgU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DRbUiAMEjkAcS0Gd2tg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aMnGg9MaDib6VoncNBR(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder mWeZ3uMo9Hk53aaj77q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SpdTH5McG2h2cRY0yUM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
