using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoCellStateAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStateAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			UndoCellStateAction undoCellStateAction = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)iMYtkqsj95Hr0CbVvqi3(VLQSAcsjLmW056txnqB3(undoCellStateAction.SVM4rgQPWe))).CopyCellsAsync(undoCellStateAction.USa4CF5bBZ).GetAwaiter();
							_ = 1;
							if (!KB1qJ1sjhkHUC0MiskhB())
							{
								num3 = 3;
								if (KB1qJ1sjhkHUC0MiskhB())
								{
									goto IL_005b;
								}
							}
							else
							{
								num3 = 2;
								if (!uRw5XEsjsgH9fXAOYWJV())
								{
									goto IL_00eb;
								}
							}
							goto IL_007b;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00eb;
						IL_007b:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							default:
								num3 = 9;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 9:
								return;
							case 2:
							case 5:
								goto IL_00eb;
							case 8:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 0:
							case 3:
								if (awaiter.IsCompleted)
								{
									goto case 8;
								}
								num3 = 1;
								if (uRw5XEsjsgH9fXAOYWJV())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								undoCellStateAction.gMq4yNjxuS = result;
								goto end_IL_0018;
							}
							break;
						}
						goto IL_005b;
						IL_00eb:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_007b;
						IL_005b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0018:;
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
					undoCellStateAction = _003C_003E4__this;
					uRw5XEsjsgH9fXAOYWJV();
					num = ((!KB1qJ1sjhkHUC0MiskhB()) ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static object VLQSAcsjLmW056txnqB3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iMYtkqsj95Hr0CbVvqi3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uRw5XEsjsgH9fXAOYWJV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KB1qJ1sjhkHUC0MiskhB()
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
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellStateAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!DQInBGsjSOAGsbBgyUUU()) ? 5 : 4);
			UndoCellStateAction undoCellStateAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					undoCellStateAction = _003C_003E4__this;
					num = 1;
					break;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = FhCuIlsjvMdHs7XDPITx(undoCellStateAction.Redo());
							num3 = 0;
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
							case 4:
								return;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!awaiter.IsCompleted)
								{
									H2DIhxsjEgcmbEqD4tWM();
									num3 = ((!DQInBGsjSOAGsbBgyUUU()) ? 2 : 7);
									continue;
								}
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
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
					goto default;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
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
		internal static TaskAwaiter FhCuIlsjvMdHs7XDPITx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DQInBGsjSOAGsbBgyUUU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H2DIhxsjEgcmbEqD4tWM()
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

		public UndoCellStateAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01ad;
			IL_001a:
			int num2 = default;
			UndoCellStateAction undoCellStateAction = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					undoCellStateAction.SVM4rgQPWe.CogSocket.Sheet.ApplyCellAttributes(undoCellStateAction.USa4CF5bBZ, true, new DictionaryEntry(dR1RF4sjAVcPIql9vCWd(4352), undoCellStateAction.F8j42TA9Ch));
					GqHmNysjVcIdwwO7ZykU();
					num3 = ((!CQr637sjHxC0F4rn7XAB()) ? 9 : 7);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 6;
					if (GqHmNysjVcIdwwO7ZykU())
					{
						goto IL_0158;
					}
				}
				goto IL_00d0;
				IL_00d0:
				while (true)
				{
					switch (num3)
					{
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 10;
					case 6:
						_003C_003Eu__1 = default;
						num3 = 1;
						continue;
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 4:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					default:
						num3 = 3;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 5:
						return;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						continue;
					case 9:
						return;
					case 0:
					case 7:
						break;
					case 10:
						awaiter.GetResult();
						goto end_IL_00d0;
					}
					goto IL_0158;
					continue;
					end_IL_00d0:
					break;
				}
				goto end_IL_001a;
				IL_0158:
				awaiter = Task.CompletedTask.GetAwaiter();
				num3 = 8;
				goto IL_00d0;
				end_IL_001a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0212;
			IL_01ad:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 4:
					undoCellStateAction = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (GqHmNysjVcIdwwO7ZykU())
					{
						num = 2;
						if (CQr637sjHxC0F4rn7XAB())
						{
							continue;
						}
						goto case 1;
					}
					num = 4;
					continue;
				default:
					goto IL_0212;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0212:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01ad;
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
		internal static object dR1RF4sjAVcPIql9vCWd(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CQr637sjHxC0F4rn7XAB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GqHmNysjVcIdwwO7ZykU()
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

		public UndoCellStateAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (FrK0oCsjUeNKUvQnHDQl() ? 2 : 4);
			int num2 = default;
			UndoCellStateAction undoCellStateAction = default;
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
							awaiter = KFl0R0sjdOqnIknUkJ6p(rdXRw4sjTH4m2ITDxWwY(undoCellStateAction.SVM4rgQPWe, undoCellStateAction.USa4CF5bBZ, undoCellStateAction.gMq4yNjxuS, false, true));
							num3 = 2;
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
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 5:
								return;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (FrK0oCsjUeNKUvQnHDQl())
								{
								}
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!tkutSusjDP3H9qA5mA6E()) ? 4 : 3);
									continue;
								}
								break;
							case 8:
								_003C_003Eu__1 = default;
								goto case 4;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
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
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 2:
					undoCellStateAction = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 4:
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
		internal static object rdXRw4sjTH4m2ITDxWwY(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KFl0R0sjdOqnIknUkJ6p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tkutSusjDP3H9qA5mA6E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FrK0oCsjUeNKUvQnHDQl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight SVM4rgQPWe;

	private CvsCellRange USa4CF5bBZ;

	private readonly string F8j42TA9Ch;

	private byte[] gMq4yNjxuS;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)OecneyWfRL35CCOdrPl(hbiMcYWk4kYfxuU7Y2m(), USa4CF5bBZ.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoCellStateAction(CvsInSight inSight, CvsCellRange cellRange, string state)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_0073:
			switch (num)
			{
			case 0:
				Ha2vtrW4UF4yHWQluio();
				OlgQnZW0QXUuXFbvnvZ();
				num = ((!uoPlWKWp3Fu0uAoauku()) ? 2 : 5);
				goto IL_0073;
			case 4:
				F8j42TA9Ch = state;
				num = 7;
				goto IL_0073;
			case 1:
			case 5:
				base._002Ector();
				num = 6;
				if (true)
				{
					goto IL_0073;
				}
				goto case 6;
			case 6:
				SVM4rgQPWe = inSight;
				break;
			case 7:
				return;
			}
			USa4CF5bBZ = cellRange;
			num = 4;
		}
		while (uoPlWKWp3Fu0uAoauku());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!OlgQnZW0QXUuXFbvnvZ()) ? 1 : 2);
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
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
			case 1:
				stateMachine._003C_003Et__builder = VSfVSvWFGVcGWCIflPC();
				num = 5;
				if (!OlgQnZW0QXUuXFbvnvZ())
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (uoPlWKWp3Fu0uAoauku())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_00a7;
			}
		}
		goto IL_005c;
		IL_005c:
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (uoPlWKWp3Fu0uAoauku())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 1:
			case 5:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_00a7;
		IL_00a7:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!OlgQnZW0QXUuXFbvnvZ())
		{
		}
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003Et__builder = VSfVSvWFGVcGWCIflPC();
				OlgQnZW0QXUuXFbvnvZ();
				num = (uoPlWKWp3Fu0uAoauku() ? 5 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = VSfVSvWFGVcGWCIflPC();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				OlgQnZW0QXUuXFbvnvZ();
				if (uoPlWKWp3Fu0uAoauku())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				goto default;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (uoPlWKWp3Fu0uAoauku())
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
	internal static void Ha2vtrW4UF4yHWQluio()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uoPlWKWp3Fu0uAoauku()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OlgQnZW0QXUuXFbvnvZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hbiMcYWk4kYfxuU7Y2m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionCellState;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OecneyWfRL35CCOdrPl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder VSfVSvWFGVcGWCIflPC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
