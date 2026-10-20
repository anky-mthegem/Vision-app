using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoImport : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImport _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yfTnI8sWlHrDrAcBpjo();
			int num = ((!hcFbaysIemv10cRu86K()) ? 4 : 5);
			int num2 = default;
			UndoImport undoImport = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = wB9OhKsbdErrXe1fljZ(undoImport.aT722ueM8s());
							num3 = 3;
							if (1 == 0)
							{
								goto IL_005d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (1 == 0)
							{
								goto IL_008a;
							}
						}
						goto IL_00aa;
						IL_008a:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00aa:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 2:
								break;
							case 4:
								return;
							case 0:
								goto IL_008a;
							default:
								num3 = 4;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									goto IL_00ed;
								}
								goto case 9;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								goto case 6;
							case 9:
								awaiter.GetResult();
								goto end_IL_003f;
							}
							break;
							IL_00ed:
							yfTnI8sWlHrDrAcBpjo();
							num3 = ((!hcFbaysIemv10cRu86K()) ? 8 : 2);
						}
						goto IL_005d;
						IL_005d:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						if (1 == 0)
						{
							return;
						}
						goto IL_00aa;
						end_IL_003f:;
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
					continue;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				undoImport = _003C_003E4__this;
				num = 3;
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
		internal static TaskAwaiter wB9OhKsbdErrXe1fljZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hcFbaysIemv10cRu86K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yfTnI8sWlHrDrAcBpjo()
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

		public UndoImport _003C_003E4__this;

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
			UndoImport undoImport = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (Lkr6vgsea2Eq5qY3LXT())
					{
						break;
					}
					goto case 0;
				case 0:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = undoImport.aT722ueM8s().GetAwaiter();
								num3 = 4;
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
								case 2:
								case 6:
									_003C_003Eu__1 = awaiter;
									goto case 0;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 0);
									Lkr6vgsea2Eq5qY3LXT();
									num3 = ((!jbBAgeslDfhpJZfT5AA()) ? 6 : 0);
									continue;
								case 5:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									break;
								case 0:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									continue;
								case 1:
									return;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (UndoActionCanceledException)
						{
							undoImport.MeJ2aaQvkW = new string[0];
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
				case 1:
				case 2:
					undoImport = _003C_003E4__this;
					num = 0;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!Lkr6vgsea2Eq5qY3LXT())
					{
						num = 5;
						break;
					}
					num = 2;
					if (!Lkr6vgsea2Eq5qY3LXT())
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
		internal static bool Lkr6vgsea2Eq5qY3LXT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jbBAgeslDfhpJZfT5AA()
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
	private struct _003CImportImages_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImport _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!P4EVDVs7uulxfUcQojh()) ? 5 : 2);
			int num2 = default;
			Classifier classifier = default;
			UndoImport undoImport = default;
			TaskAwaiter<string[]> awaiter = default;
			string[] result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)YcKefGsn8OnYsQFOnIE(undoImport.INj2xXqKT6);
							_ = 0;
							if (P4EVDVs7uulxfUcQojh())
							{
								num3 = 2;
							}
							else
							{
								num3 = 8;
								if (jyZdTMsyvI3Tf1ChDVb())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (!P4EVDVs7uulxfUcQojh())
							{
								goto IL_007f;
							}
						}
						goto IL_0118;
						IL_00d3:
						result = awaiter.GetResult();
						num3 = 11;
						goto IL_0118;
						IL_0118:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								num3 = 10;
								continue;
							default:
								return;
							case 8:
								return;
							case 7:
								break;
							case 9:
								goto IL_0097;
							case 3:
								awaiter = classifier.beG6cP0CX(undoImport.Cdh2ooMpUB).GetAwaiter();
								num3 = 9;
								continue;
							case 6:
								goto IL_00d3;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 2:
								if (classifier != null)
								{
									num3 = 3;
									continue;
								}
								goto end_IL_0024;
							case 11:
								undoImport.MeJ2aaQvkW = result;
								goto end_IL_0024;
							}
							break;
						}
						goto IL_007f;
						IL_007f:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						if (!P4EVDVs7uulxfUcQojh())
						{
							goto IL_0097;
						}
						goto IL_0118;
						IL_0097:
						if (awaiter.IsCompleted)
						{
							goto IL_00d3;
						}
						num2 = (_003C_003E1__state = 0);
						num3 = 7;
						goto IL_0118;
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
					continue;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				undoImport = _003C_003E4__this;
				num = 3;
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
		internal static object YcKefGsn8OnYsQFOnIE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P4EVDVs7uulxfUcQojh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jyZdTMsyvI3Tf1ChDVb()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoImport _003C_003E4__this;

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
			Classifier classifier = default;
			UndoImport undoImport = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			do
			{
				IL_01a2:
				switch (num)
				{
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)p4kjRqd20DJYvRrlQRl(undoImport.INj2xXqKT6);
							_ = 0;
							if (O7vQQHsf99cH8XmHbIA())
							{
								num3 = 10;
							}
							else
							{
								num3 = 8;
								if (1 == 0)
								{
									return;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 10:
								if (classifier != null)
								{
									goto case 1;
								}
								goto end_IL_00c1;
							case 6:
								return;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 8:
								imagesFromIds = classifier.GetImagesFromIds(undoImport.MeJ2aaQvkW);
								num3 = 7;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 7:
								awaiter = YaaDGgdMJMTtxov8nPk(classifier.FQt30A3AL(imagesFromIds, (string)GybddKdXrWcBirrmsY1()));
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00c1:
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
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!c8FnyWszhmkWClPZavB()) ? 4 : 2);
					goto IL_01a2;
				case 1:
				case 4:
					undoImport = _003C_003E4__this;
					num = 0;
					goto IL_01a2;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (!c8FnyWszhmkWClPZavB());
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
		internal static object p4kjRqd20DJYvRrlQRl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GybddKdXrWcBirrmsY1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UndoImport;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YaaDGgdMJMTtxov8nPk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O7vQQHsf99cH8XmHbIA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c8FnyWszhmkWClPZavB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IClassifierHandle INj2xXqKT6;

	private List<string> Cdh2ooMpUB;

	private string[] MeJ2aaQvkW;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)Jr4iaQXz2Cc1Kbl71Qb();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoImport(IClassifierHandle handle, List<string> fileNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector();
		INj2xXqKT6 = handle;
		Cdh2ooMpUB = fileNames;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bt3TkrXnR0Z8AqmOvWK();
		int num;
		if (!ypvasrXfg6OFWr4kg9U())
		{
			num = 1;
			if (ypvasrXfg6OFWr4kg9U())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_008a;
		IL_002e:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AudE60M2JfsTAnmMGVl();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (ypvasrXfg6OFWr4kg9U() ? 4 : 0);
				break;
			case 1:
				stateMachine._003C_003Et__builder = AudE60M2JfsTAnmMGVl();
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CImportImages_003Ed__8))]
	private Task aT722ueM8s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CImportImages_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				ypvasrXfg6OFWr4kg9U();
				if (bt3TkrXnR0Z8AqmOvWK())
				{
					num = 0;
					if (!ypvasrXfg6OFWr4kg9U())
					{
						break;
					}
					goto case 0;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = AudE60M2JfsTAnmMGVl();
				num = 4;
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
		return (Task)n3NJV8MXU5XcPikVP3c();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!bt3TkrXnR0Z8AqmOvWK()) ? 3 : 5);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (bt3TkrXnR0Z8AqmOvWK())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AudE60M2JfsTAnmMGVl();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Jr4iaQXz2Cc1Kbl71Qb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Import;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder AudE60M2JfsTAnmMGVl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bt3TkrXnR0Z8AqmOvWK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ypvasrXfg6OFWr4kg9U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n3NJV8MXU5XcPikVP3c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
