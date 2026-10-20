using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoAddClass : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAddClass _003C_003E4__this;

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
			UndoAddClass undoAddClass = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (sZ4BMZsrhZ8HjaY5QV4() ? 5 : 4);
					break;
				case 1:
				case 4:
					undoAddClass = _003C_003E4__this;
					num = 0;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (m2xl0asmrUWE7AJPkPZ())
					{
						break;
					}
					goto case 0;
				case 0:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = uydBJrs4OdYGVdlZ4bL(bxIWUHsP86Zb8rqJUM4(undoAddClass));
							num3 = 8;
							if (false)
							{
								goto IL_007f;
							}
							goto IL_009f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0149;
						IL_00fb:
						num2 = (_003C_003E1__state = 0);
						num3 = 7;
						goto IL_009f;
						IL_00e8:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						if (true)
						{
							goto IL_009f;
						}
						goto IL_00fb;
						IL_007f:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_00cc;
						IL_00cc:
						m2xl0asmrUWE7AJPkPZ();
						if (!sZ4BMZsrhZ8HjaY5QV4())
						{
							num3 = 6;
							if (false)
							{
								goto IL_00e8;
							}
						}
						else
						{
							num3 = 3;
							if (1 == 0)
							{
								goto IL_0149;
							}
						}
						goto IL_009f;
						IL_0149:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_009f;
						IL_009f:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							default:
								goto IL_00cc;
							case 7:
								goto IL_00e8;
							case 2:
								goto IL_00fb;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (sZ4BMZsrhZ8HjaY5QV4())
								{
								}
								continue;
							case 4:
							case 6:
								return;
							case 3:
							case 5:
								goto IL_0149;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_007f;
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
		internal static object bxIWUHsP86Zb8rqJUM4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter uydBJrs4OdYGVdlZ4bL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m2xl0asmrUWE7AJPkPZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sZ4BMZsrhZ8HjaY5QV4()
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

		public UndoAddClass _003C_003E4__this;

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
			Classifier classifier = default;
			UndoAddClass undoAddClass = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)rQhgK5sSfbwBTnwt3Hh(undoAddClass.DrUIgHmIqK);
							RJlvHss1Z6hY0KlMFmD();
							if (oirrIOsg7i9yOp6IyQI())
							{
								num3 = 3;
								if (false)
								{
									goto IL_0046;
								}
							}
							else
							{
								num3 = 9;
								if (1 == 0)
								{
									goto IL_0146;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 8;
						}
						goto IL_00c1;
						IL_0046:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_00c1;
						IL_00c1:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 7:
								return;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 0:
							case 3:
								if (classifier != null)
								{
									num3 = 5;
									continue;
								}
								goto end_IL_0018;
							case 2:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto IL_0146;
							case 5:
								awaiter = PiaMUasDC9Yb0Dl5hRg(gSpkBOs6lOhHEikV1gl(classifier, undoAddClass.HKkIkQV6Pd));
								goto case 2;
							case 10:
								goto IL_0146;
							}
							break;
						}
						goto IL_0046;
						IL_0146:
						awaiter.GetResult();
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (oirrIOsg7i9yOp6IyQI())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 1:
				case 3:
					undoAddClass = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				RJlvHss1Z6hY0KlMFmD();
				if (oirrIOsg7i9yOp6IyQI())
				{
					num = 3;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
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
		internal static object rQhgK5sSfbwBTnwt3Hh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gSpkBOs6lOhHEikV1gl(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0)._AddClass((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PiaMUasDC9Yb0Dl5hRg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oirrIOsg7i9yOp6IyQI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RJlvHss1Z6hY0KlMFmD()
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

		public UndoAddClass _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!Sn1T67s8dCXw15VhSMF())
			{
				goto IL_001e;
			}
			goto IL_01e2;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01e2;
			IL_01e2:
			int num2 = default;
			Classifier classifier = default;
			UndoAddClass undoAddClass = default;
			TaskAwaiter awaiter = default;
			ClassViewModel classViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)TJqZX5ssHH5IYNwjnPF(undoAddClass.DrUIgHmIqK);
							num3 = 7;
							goto IL_007d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_018a;
						IL_018a:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_007d;
						IL_007d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 4:
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = classifier._DoDeleteClass(classViewModel, null).GetAwaiter();
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (Sn1T67s8dCXw15VhSMF())
									{
										num3 = 5;
										if (eYkxOKsF0ejZMsEnDxV())
										{
										}
									}
									else
									{
										num3 = 2;
									}
									continue;
								}
								goto case 12;
							case 7:
								if (classifier != null)
								{
									num3 = 3;
									continue;
								}
								goto end_IL_007d;
							case 3:
								classViewModel = classifier.Classes.FirstOrDefault(undoAddClass.p72IqOtQoK);
								if (classViewModel != null)
								{
									num3 = 9;
									continue;
								}
								goto end_IL_007d;
							case 0:
								return;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 2:
							case 8:
								break;
							case 12:
								awaiter.GetResult();
								goto end_IL_007d;
							}
							goto IL_018a;
							continue;
							end_IL_007d:
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
				case 0:
				case 1:
					undoAddClass = _003C_003E4__this;
					num = 5;
					if (Sn1T67s8dCXw15VhSMF())
					{
						continue;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					eYkxOKsF0ejZMsEnDxV();
					num = ((!Sn1T67s8dCXw15VhSMF()) ? 2 : 0);
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
		internal static object TJqZX5ssHH5IYNwjnPF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sn1T67s8dCXw15VhSMF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eYkxOKsF0ejZMsEnDxV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsInSight GOCIXu84dN;

	private IClassifierHandle DrUIgHmIqK;

	private string HKkIkQV6Pd;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)eXeIHNXOwXe1cmi1V4E(), HKkIkQV6Pd);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoAddClass(CvsInSight insight, IClassifierHandle handle, string className)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mCdV7HXvILoEDAEfTYO();
		int num;
		if (CYthnJX9d8aWVDxaq8t())
		{
			num = 5;
			if (!CYthnJX9d8aWVDxaq8t())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 6;
			if (!CYthnJX9d8aWVDxaq8t())
			{
				goto IL_00b8;
			}
		}
		goto IL_005a;
		IL_0041:
		GOCIXu84dN = insight;
		goto IL_00b8;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 6:
				goto IL_0041;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				ESuQZSXZupnYc4Q5rIR();
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				GvSkZEX0h7ET4QHhkZL(this);
				goto IL_0041;
			case 1:
				goto IL_00b8;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		HKkIkQV6Pd = className;
		num = 7;
		if (1 == 0)
		{
			goto IL_0041;
		}
		goto IL_005a;
		IL_00b8:
		DrUIgHmIqK = handle;
		num = 4;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!mCdV7HXvILoEDAEfTYO())
		{
			num = 1;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0040;
		IL_00a3:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (CYthnJX9d8aWVDxaq8t())
		{
			goto IL_0040;
		}
		goto IL_00c1;
		IL_00c1:
		return stateMachine._003C_003Et__builder.Task;
		IL_0026:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a3;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 3;
				if (mCdV7HXvILoEDAEfTYO())
				{
				}
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = ebaZXEXHNeNZiTp0SxG();
				num = 4;
				continue;
			case 3:
				goto IL_00a3;
			case 6:
				goto IL_00c1;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (CYthnJX9d8aWVDxaq8t())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (mCdV7HXvILoEDAEfTYO())
			{
				goto IL_0070;
			}
		}
		goto IL_008a;
		IL_0036:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008a;
		IL_0070:
		stateMachine._003C_003E1__state = -1;
		goto IL_0036;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 5:
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = ebaZXEXHNeNZiTp0SxG();
				goto case 1;
			case 3:
				goto IL_0070;
			default:
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0036;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)EamFLGXT4LYKb6pgBfd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (CYthnJX9d8aWVDxaq8t())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = ebaZXEXHNeNZiTp0SxG();
				CYthnJX9d8aWVDxaq8t();
				if (mCdV7HXvILoEDAEfTYO())
				{
					num = 2;
					continue;
				}
				num = 0;
				if (!mCdV7HXvILoEDAEfTYO())
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
	[CompilerGenerated]
	private bool p72IqOtQoK(ClassViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fHrWHpXJ2ILlAujDjeJ(B6w4CCXYfle0XYdKTi4(P_0), HKkIkQV6Pd);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ESuQZSXZupnYc4Q5rIR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GvSkZEX0h7ET4QHhkZL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CYthnJX9d8aWVDxaq8t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mCdV7HXvILoEDAEfTYO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eXeIHNXOwXe1cmi1V4E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AddClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ebaZXEXHNeNZiTp0SxG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EamFLGXT4LYKb6pgBfd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B6w4CCXYfle0XYdKTi4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fHrWHpXJ2ILlAujDjeJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
