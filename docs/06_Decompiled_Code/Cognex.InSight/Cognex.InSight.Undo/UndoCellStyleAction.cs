using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoCellStyleAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStyleAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoCellStyleAction undoCellStyleAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				IL_01d2:
				switch (num)
				{
				case 0:
				case 1:
					undoCellStyleAction = _003C_003E4__this;
					goto case 2;
				case 4:
					while (true)
					{
						num2 = _003C_003E1__state;
						_ = 0;
						if (dcmKPysjiNVG03feJIN5())
						{
							break;
						}
						num = 5;
						if (1 == 0)
						{
							continue;
						}
						goto IL_01d2;
					}
					num = 0;
					if (dcmKPysjiNVG03feJIN5())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoCellStyleAction.qoq4z0SUQG = ((CvsResultSet)udHfulsjBp55lkRlmwQO(undoCellStyleAction.at04v6Wd4y)).Cells.GetCurrentFormatting(undoCellStyleAction.rPn48eU7j4);
							kZjsV6sjqCd0FBcYTGXh();
							num3 = ((!dcmKPysjiNVG03feJIN5()) ? 5 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 0:
							case 7:
								awaiter = MbCmiwsjcwIRW7dRvewA(Jm4Or5sjjG7gFGNKhj5I());
								num3 = 8;
								if (dcmKPysjiNVG03feJIN5())
								{
									continue;
								}
								goto case 8;
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 1;
								if (dcmKPysjiNVG03feJIN5())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
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
				default:
					num = 3;
					continue;
				case 3:
					break;
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
		internal static object udHfulsjBp55lkRlmwQO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jm4Or5sjjG7gFGNKhj5I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MbCmiwsjcwIRW7dRvewA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dcmKPysjiNVG03feJIN5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kZjsV6sjqCd0FBcYTGXh()
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
	private struct _003CDo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStyleAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			UndoCellStyleAction undoCellStyleAction = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01ae:
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!SNZhZAsjWpCsVlcTVEIG())
					{
						num = 5;
						if (Vx0jO9sj2yCptn8Aw60G())
						{
							goto IL_01ae;
						}
						goto case 4;
					}
					num = 0;
					goto IL_01ae;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoCellStyleAction.orb4V2XD8K(undoCellStyleAction.hkG4Z8DflK);
							num3 = 8;
							if (SNZhZAsjWpCsVlcTVEIG())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (false)
							{
								goto IL_0079;
							}
						}
						goto IL_0092;
						IL_0134:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 6;
						goto IL_0092;
						IL_0079:
						_003C_003Eu__1 = awaiter;
						goto IL_0134;
						IL_0092:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 0:
								break;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 0;
									continue;
								}
								goto case 10;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 3:
								awaiter = xpghvCsjturMk6ne4Csp(g2CgSAsj7CZr9FJv8c2s());
								num3 = 5;
								continue;
							default:
								goto IL_0134;
							case 8:
								undoCellStyleAction.cqulPxItMa = undoCellStyleAction.hkG4Z8DflK;
								_ = 0;
								if (!Vx0jO9sj2yCptn8Aw60G())
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 3;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_003b;
							}
							break;
						}
						goto IL_0079;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
				case 5:
					undoCellStyleAction = _003C_003E4__this;
					num = 4;
					goto IL_01ae;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (Vx0jO9sj2yCptn8Aw60G());
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
		internal static object g2CgSAsj7CZr9FJv8c2s()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter xpghvCsjturMk6ne4Csp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vx0jO9sj2yCptn8Aw60G()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SNZhZAsjWpCsVlcTVEIG()
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
	private struct _003CRedo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStyleAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoCellStyleAction undoCellStyleAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoCellStyleAction = _003C_003E4__this;
					_ = 1;
					num = (VB1sJFsjKaRk5nJ02HEI() ? 4 : 5);
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (wD5M3QsjCJK76E2iJZdd())
					{
						continue;
					}
					break;
				case 0:
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoCellStyleAction.orb4V2XD8K(undoCellStyleAction.cqulPxItMa);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								goto case 3;
							case 3:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
								return;
							case 9:
								awaiter = max8HksjoxB49i5JmCgH(tXdcussj5WUbN7k7bkcx());
								wD5M3QsjCJK76E2iJZdd();
								if (VB1sJFsjKaRk5nJ02HEI())
								{
									num3 = 3;
									continue;
								}
								num3 = 4;
								if (!VB1sJFsjKaRk5nJ02HEI())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 10:
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
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 1;
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
		internal static object tXdcussj5WUbN7k7bkcx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter max8HksjoxB49i5JmCgH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wD5M3QsjCJK76E2iJZdd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VB1sJFsjKaRk5nJ02HEI()
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
	private struct _003CUndo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStyleAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jdahodsjYgvKtW9qN9Ad();
			int num;
			if (oN3WD1sjPLGxnfHwgMly())
			{
				num = 5;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01cc;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01cc;
			IL_01cc:
			UndoCellStyleAction undoCellStyleAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoCellStyleAction = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoCellStyleAction.orb4V2XD8K(undoCellStyleAction.qoq4z0SUQG);
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (jdahodsjYgvKtW9qN9Ad())
							{
								goto IL_0139;
							}
						}
						goto IL_00dc;
						IL_0151:
						awaiter = ((Task)tt21nGsjNIvu3S0wImLG()).GetAwaiter();
						num3 = 0;
						goto IL_00dc;
						IL_0139:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (0 == 0)
						{
							goto IL_00dc;
						}
						goto IL_0151;
						IL_00dc:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								if (!jdahodsjYgvKtW9qN9Ad())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 7:
								break;
							case 3:
								goto IL_0151;
							case 0:
								if (!awaiter.IsCompleted)
								{
									oN3WD1sjPLGxnfHwgMly();
									if (jdahodsjYgvKtW9qN9Ad())
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 9;
									}
									num3 = 1;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_0139;
						end_IL_0061:;
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
		internal static object tt21nGsjNIvu3S0wImLG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oN3WD1sjPLGxnfHwgMly()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jdahodsjYgvKtW9qN9Ad()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight at04v6Wd4y;

	private readonly List<CvsCellFormat> hkG4Z8DflK;

	private readonly CvsCellRange rPn48eU7j4;

	private List<CvsCellFormat> qoq4z0SUQG;

	private List<CvsCellFormat> cqulPxItMa;

	private readonly string RkKlIM4uAg;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RkKlIM4uAg;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCellStyleAction(CvsInSight inSight, CvsCellRange cellRange, List<CvsCellFormat> cellFormats, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		rPn48eU7j4 = CvsCellRange.Empty;
		base._002Ector();
		at04v6Wd4y = inSight;
		hkG4Z8DflK = cellFormats;
		rPn48eU7j4 = cellRange;
		RkKlIM4uAg = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__9))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!aKCEAKWmKl1UGHY87IW()) ? 1 : 5);
				continue;
			case 4:
				stateMachine._003C_003Et__builder = dT4tDEWgaVfQ26vSnq4();
				num = 0;
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__10))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CDo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				if (VvmACWWyOLbbtLwV0tQ())
				{
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (aKCEAKWmKl1UGHY87IW() ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__11))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_005c;
		IL_00a5:
		_003CRedo_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
		IL_0093:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_005c;
		IL_0042:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a5;
		IL_001a:
		stateMachine._003C_003Et__builder = dT4tDEWgaVfQ26vSnq4();
		_ = 1;
		if (!VvmACWWyOLbbtLwV0tQ())
		{
			num = 0;
			if (!aKCEAKWmKl1UGHY87IW())
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 4;
			if (VvmACWWyOLbbtLwV0tQ())
			{
				goto IL_0093;
			}
		}
		goto IL_005c;
		IL_005c:
		switch (num)
		{
		case 2:
			break;
		case 5:
			goto IL_0042;
		case 0:
		case 1:
			goto IL_0093;
		default:
			goto IL_00a5;
		case 6:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__12))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!VvmACWWyOLbbtLwV0tQ())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0044;
			}
		}
		goto IL_005e;
		IL_0026:
		_003CUndo_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = dT4tDEWgaVfQ26vSnq4();
		goto IL_00a3;
		IL_0089:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (true)
		{
			goto IL_005e;
		}
		goto IL_00a3;
		IL_00a3:
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_005e;
		IL_0044:
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
		IL_005e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				goto IL_0044;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_0089;
			case 1:
			case 3:
				goto IL_00a3;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void orb4V2XD8K(List<CvsCellFormat> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		at04v6Wd4y.CogSocket.Sheet.ClearCellStyles(rPn48eU7j4);
		at04v6Wd4y.Results.Cells.GetCells(rPn48eU7j4);
		foreach (CvsCellFormat item in P_0)
		{
			string cellStyle = item.ToCellStyle();
			string graphicsStyle = item.ToGraphicsStyle();
			at04v6Wd4y.CogSocket.Sheet.SetCellStyles(item.Location, cellStyle, graphicsStyle);
		}
		at04v6Wd4y.MakeNewResult(updateExposedResults: true, runSheet: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder dT4tDEWgaVfQ26vSnq4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aKCEAKWmKl1UGHY87IW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VvmACWWyOLbbtLwV0tQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
