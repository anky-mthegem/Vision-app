using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Helpers;

public class PasteToolUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PasteToolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RarpQQKGAIRDF2IWTsLv();
			int num = ((!Uuf6GDKGC4qyGkTrClW1()) ? 2 : 5);
			PasteToolUndoAction pasteToolUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					pasteToolUndoAction = _003C_003E4__this;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							pasteToolUndoAction.JdRdWGUVM6 = new byte[((Array)yypVirKGRmLntPVkM4Nm(pasteToolUndoAction.Inspect)).Length];
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 6:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 3:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = (Uuf6GDKGC4qyGkTrClW1() ? 7 : 6);
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								Y2EmG7KGWORYePbTvfTD(yypVirKGRmLntPVkM4Nm(pasteToolUndoAction.Inspect), pasteToolUndoAction.JdRdWGUVM6, pasteToolUndoAction.Inspect.CopyTool.Length);
								awaiter = F4FV4mKGyqDIPQAbKVtH(huFVfQKGTSo2CDqLxTUE());
								num3 = 8;
								if (RarpQQKGAIRDF2IWTsLv())
								{
								}
								continue;
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
					goto case 3;
				default:
					num = 3;
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
		internal static object yypVirKGRmLntPVkM4Nm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).CopyTool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y2EmG7KGWORYePbTvfTD(object P_0, object P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Array.Copy((Array)P_0, (Array)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object huFVfQKGTSo2CDqLxTUE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter F4FV4mKGyqDIPQAbKVtH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uuf6GDKGC4qyGkTrClW1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RarpQQKGAIRDF2IWTsLv()
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
	private struct _003CDo_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PasteToolUndoAction _003C_003E4__this;

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
			PasteToolUndoAction pasteToolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!YPjiqOKGFv7l06TA5Smp())
					{
						num = 3;
						if (!YPjiqOKGFv7l06TA5Smp())
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pasteToolUndoAction.XiSdT76WBT(pasteToolUndoAction.PasteWithShifting, pasteToolUndoAction.JdRdWGUVM6).GetAwaiter();
							num3 = 6;
							if (false)
							{
								goto IL_007a;
							}
							goto IL_00dd;
						}
						awaiter = _003C_003Eu__1;
						goto IL_011a;
						IL_011a:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_00dd;
						IL_00dd:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 6:
								goto IL_00a7;
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto IL_011a;
							case 2:
							case 5:
								goto IL_011a;
							case 0:
								goto IL_0130;
							case 4:
								return;
							case 9:
								pasteToolUndoAction.oe1dOT4pVv = pasteToolUndoAction.Inspect.CurrentTool;
								num3 = 10;
								if (tshajVKG0HIWfKGNp5Qm())
								{
									continue;
								}
								goto case 10;
							case 10:
								pasteToolUndoAction.Text = (string)xU2ufbKGMW30vcQw5qCT(Resources.AtgLJJo4Ue(), pasteToolUndoAction.Inspect.Snippets.Last().Name);
								goto end_IL_0050;
							}
							break;
							IL_0130:
							_003C_003Eu__1 = awaiter;
							tshajVKG0HIWfKGNp5Qm();
							num3 = (YPjiqOKGFv7l06TA5Smp() ? 2 : 8);
							continue;
							IL_00a7:
							if (!awaiter.IsCompleted)
							{
								num3 = 1;
								continue;
							}
							goto IL_0083;
						}
						goto IL_007a;
						IL_007a:
						num2 = (_003C_003E1__state = -1);
						goto IL_0083;
						IL_0083:
						awaiter.GetResult();
						num3 = 9;
						goto IL_00dd;
						end_IL_0050:;
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
						break;
					}
					goto case 1;
				case 1:
				case 3:
					pasteToolUndoAction = _003C_003E4__this;
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
		internal static object xU2ufbKGMW30vcQw5qCT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tshajVKG0HIWfKGNp5Qm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YPjiqOKGFv7l06TA5Smp()
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
	private struct _003CRedo_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PasteToolUndoAction _003C_003E4__this;

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
			if (ELJU9LKGYXAWSTussCPu())
			{
				num = 2;
				if (mkVdPLKGULJ5VNfQTm0k())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01b2;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01b2;
			IL_01b2:
			int num2 = default;
			PasteToolUndoAction pasteToolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = EgUbT2KGHPjgpQxGM7eG(pasteToolUndoAction.XiSdT76WBT(pasteToolUndoAction.PasteWithShifting, pasteToolUndoAction.JdRdWGUVM6));
							ELJU9LKGYXAWSTussCPu();
							num3 = (mkVdPLKGULJ5VNfQTm0k() ? 6 : 2);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 9;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 4;
								if (!mkVdPLKGULJ5VNfQTm0k())
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 10:
								pasteToolUndoAction.oe1dOT4pVv = (EzTool)tv4XppKGxqLsr6uEWAa9(pasteToolUndoAction.Inspect);
								break;
							}
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					pasteToolUndoAction = _003C_003E4__this;
					num = 3;
					continue;
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
		internal static TaskAwaiter EgUbT2KGHPjgpQxGM7eG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tv4XppKGxqLsr6uEWAa9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).CurrentTool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ELJU9LKGYXAWSTussCPu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mkVdPLKGULJ5VNfQTm0k()
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

		public PasteToolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wRQx7dKGm1OhLoQ2MgPu();
			int num;
			if (!Xw3q46KGQd5CJsM2qHTD())
			{
				num = 2;
				if (Xw3q46KGQd5CJsM2qHTD())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0189;
			IL_01b4:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0189;
			IL_0189:
			int num2 = default;
			PasteToolUndoAction pasteToolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_01b4;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					pasteToolUndoAction = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((Task)SNtDR3KG2ZLHjGns3lCb(new DeleteToolUndoAction(pasteToolUndoAction.Inspect, (string)t5Xf79KGNuw2s0HIueiC(pasteToolUndoAction.oe1dOT4pVv)))).GetAwaiter();
					_ = 1;
					num3 = (Xw3q46KGQd5CJsM2qHTD() ? 6 : 5);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 7;
				}
				while (true)
				{
					switch (num3)
					{
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 2;
						if (true)
						{
							continue;
						}
						goto case 3;
					case 3:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						continue;
					case 1:
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						if (true)
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (true)
						{
							continue;
						}
						return;
					case 2:
						return;
					case 0:
					case 5:
						if (awaiter.IsCompleted)
						{
							break;
						}
						goto case 1;
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
			goto IL_01b4;
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
		internal static object t5Xf79KGNuw2s0HIueiC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SNtDR3KG2ZLHjGns3lCb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseSnippetAddRemoveAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wRQx7dKGm1OhLoQ2MgPu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xw3q46KGQd5CJsM2qHTD()
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
	private struct _003CPaste_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PasteToolUndoAction _003C_003E4__this;

		public byte[] data;

		public bool shift;

		private IAsyncDisposable _003Cpause_003E5__2;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private byte[] _003CcopyData_003E5__5;

		private CvsCellCollection _003Ccells_003E5__6;

		private CvsCellRange _003CpasteCellRange_003E5__7;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		private TaskAwaiter<string> _003C_003Eu__5;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__6;

		private ValueTaskAwaiter _003C_003Eu__7;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y5SNSfKG19R6AV3vrLau();
			int num = ((!IkMMO9KGcan72Y8628c6()) ? 4 : 2);
			PasteToolUndoAction pasteToolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter7 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 3:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = pasteToolUndoAction.Inspect.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00cb;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00cb;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
							try
							{
								TaskAwaiter<CvsCellRange> awaiter6;
								TaskAwaiter<CvsCellCollection> awaiter5;
								TaskAwaiter<string> awaiter4;
								string result3;
								CvsCellRange result4;
								EzSnippet snippet;
								CvsCellCollection result2;
								switch (num2)
								{
								default:
								{
									PasteBuffer pasteBuffer = EzToolType.UpdateNamesInPasteBuffer(new PasteBuffer(JsonConvert.DeserializeObject<JObject>((string)INf0I6KGhhE3MtL1Kkcb(Fl41VRKGuuhOdmsO8SFT(), data))), pasteToolUndoAction.Inspect, out var _);
									_003CcopyData_003E5__5 = (byte[])dXKxk3KoLu1WId4IfEdv(Fl41VRKGuuhOdmsO8SFT(), hHG9KtKGzkqo1jfm4sVJ(pasteBuffer, MrMDX5KGthVwfmeccCrC(pasteToolUndoAction.Inspect.Snippets) + 1).ToString());
									awaiter5 = ((CvsCogSocketSheet)OFy1fwKowavFD395012c(mPgpZPKo5SoSe72vtneX(x9hWgJKoKsKMBljEloZL(pasteToolUndoAction.Inspect)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_01db;
								}
								case 1:
									awaiter5 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_01db;
								case 2:
									awaiter6 = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0258;
								case 3:
									awaiter3 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_02db;
								case 4:
									awaiter5 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0351;
								case 5:
									awaiter4 = _003C_003Eu__5;
									_003C_003Eu__5 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_03db;
								case 6:
									awaiter3 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0457;
								case 7:
									awaiter3 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_04d2;
								case 8:
								case 9:
									{
										try
										{
											int num3;
											if (num2 != 8)
											{
												num3 = 12;
												if (false)
												{
													return;
												}
											}
											else
											{
												awaiter3 = _003C_003Eu__4;
												num3 = 1;
											}
											while (true)
											{
												switch (num3)
												{
												case 13:
													return;
												case 4:
												case 14:
													return;
												case 11:
													awaiter3 = ((Task)rH51YaKoeFhfQIyCDZdM(pasteToolUndoAction.Inspect.CurrentTool, 10 * pasteToolUndoAction.UhOdC1JVNi)).GetAwaiter();
													if (!awaiter3.IsCompleted)
													{
														num3 = 6;
														if (y5SNSfKG19R6AV3vrLau())
														{
														}
														continue;
													}
													goto case 15;
												case 0:
													num2 = (_003C_003E1__state = -1);
													num3 = 16;
													if (0 == 0)
													{
														continue;
													}
													goto case 12;
												case 12:
													if (num2 == 9)
													{
														awaiter7 = _003C_003Eu__6;
														num3 = 2;
														if (1 == 0)
														{
															return;
														}
													}
													else
													{
														num3 = 11;
													}
													continue;
												case 3:
												case 10:
													_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
													num3 = 13;
													continue;
												case 6:
													num2 = (_003C_003E1__state = 8);
													_003C_003Eu__4 = awaiter3;
													num3 = 5;
													continue;
												case 7:
													if (!awaiter7.IsCompleted)
													{
														num2 = (_003C_003E1__state = 9);
														num3 = 8;
														continue;
													}
													break;
												case 5:
													_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
													y5SNSfKG19R6AV3vrLau();
													num3 = ((!IkMMO9KGcan72Y8628c6()) ? 3 : 14);
													continue;
												case 1:
													_003C_003Eu__4 = default;
													num2 = (_003C_003E1__state = -1);
													num3 = 15;
													continue;
												case 8:
													_003C_003Eu__6 = awaiter7;
													goto case 3;
												case 9:
													awaiter7 = ((CvsCogSocket)mPgpZPKo5SoSe72vtneX(pasteToolUndoAction.Inspect.InSight)).Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
													num3 = 7;
													if (IkMMO9KGcan72Y8628c6())
													{
														continue;
													}
													goto case 2;
												case 2:
													_003C_003Eu__6 = default;
													num3 = 0;
													if (IkMMO9KGcan72Y8628c6())
													{
														continue;
													}
													goto case 15;
												case 15:
													awaiter3.GetResult();
													goto case 9;
												default:
													num3 = 9;
													continue;
												case 16:
													break;
												}
												break;
											}
											awaiter7.GetResult();
										}
										catch (AggregateException ex)
										{
											MNvZjuKoIuF0oVJFO8ZQ(LogManager.GetLogger<PasteToolUndoAction>(), Ge9bRJKoOb4A88U2EXtQ(48786), ex);
										}
										break;
									}
									IL_01db:
									result2 = awaiter5.GetResult();
									_003Ccells_003E5__6 = result2;
									awaiter6 = pasteToolUndoAction.Inspect.GetSnippetLocation(_003Ccells_003E5__6, pasteToolUndoAction.MnAdj6tPSi).GetAwaiter();
									if (!awaiter6.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter6;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										return;
									}
									goto IL_0258;
									IL_03db:
									result3 = awaiter4.GetResult();
									awaiter3 = m7v3oNKoaoKJWNk941BQ(((ISnippetOwner)pasteToolUndoAction.Inspect).AddSnippet(new Guid(result3), _003Ccells_003E5__6, _003CpasteCellRange_003E5__7, SnippetAddedEventType.Created));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_0457;
									IL_0258:
									result4 = awaiter6.GetResult();
									_003CpasteCellRange_003E5__7 = result4;
									awaiter3 = m7v3oNKoaoKJWNk941BQ(p9Wo0xKoJ3KR3Q2kWXMo(x9hWgJKoKsKMBljEloZL(pasteToolUndoAction.Inspect), _003CpasteCellRange_003E5__7, _003CcopyData_003E5__5, false, false));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_02db;
									IL_04d2:
									awaiter3.GetResult();
									if (!shift)
									{
										break;
									}
									goto case 8;
									IL_02db:
									awaiter3.GetResult();
									awaiter5 = ((CvsCogSocketSheet)OFy1fwKowavFD395012c(mPgpZPKo5SoSe72vtneX(x9hWgJKoKsKMBljEloZL(pasteToolUndoAction.Inspect)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__2 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_0351;
									IL_0457:
									awaiter3.GetResult();
									snippet = pasteToolUndoAction.Inspect.Snippets.Last();
									awaiter3 = m7v3oNKoaoKJWNk941BQ(pasteToolUndoAction.Inspect.SetCurrentSnippet(snippet));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 7);
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_04d2;
									IL_0351:
									result2 = awaiter5.GetResult();
									_003Ccells_003E5__6 = result2;
									awaiter4 = ((CvsCogSocketSheet)OFy1fwKowavFD395012c(mPgpZPKo5SoSe72vtneX(x9hWgJKoKsKMBljEloZL(pasteToolUndoAction.Inspect)))).GetCellCommentAsync(_003CpasteCellRange_003E5__7.Location).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										_003C_003Eu__5 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									}
									goto IL_03db;
								}
								_003CcopyData_003E5__5 = null;
								_003Ccells_003E5__6 = null;
								_003CpasteCellRange_003E5__7 = default;
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003Cpause_003E5__2 == null)
							{
								break;
							}
							awaiter = cDRPG5KoDDssMVUQYTZB(_003Cpause_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 10);
								_003C_003Eu__7 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_07c2;
						case 10:
							{
								awaiter = _003C_003Eu__7;
								_003C_003Eu__7 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_07c2;
							}
							IL_07c2:
							awaiter.GetResult();
							break;
							IL_00cb:
							result = awaiter2.GetResult();
							_003Cpause_003E5__2 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							bbUoNUKonWXMqUhHD1LP(boVyDoKoiHFXH9sGWabD((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003Cpause_003E5__2 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 1:
				case 4:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				pasteToolUndoAction = _003C_003E4__this;
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
		internal static object Fl41VRKGuuhOdmsO8SFT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.UTF8;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object INf0I6KGhhE3MtL1Kkcb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetString((byte[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MrMDX5KGthVwfmeccCrC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<EzSnippet>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hHG9KtKGzkqo1jfm4sVJ(object P_0, int order)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EzToolType.SetOrderInPasteBuffer((PasteBuffer)P_0, order);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dXKxk3KoLu1WId4IfEdv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x9hWgJKoKsKMBljEloZL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mPgpZPKo5SoSe72vtneX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OFy1fwKowavFD395012c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p9Wo0xKoJ3KR3Q2kWXMo(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter m7v3oNKoaoKJWNk941BQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rH51YaKoeFhfQIyCDZdM(object P_0, int delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).ShiftEditGraphics(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ge9bRJKoOb4A88U2EXtQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MNvZjuKoIuF0oVJFO8ZQ(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask cDRPG5KoDDssMVUQYTZB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object boVyDoKoiHFXH9sGWabD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bbUoNUKonWXMqUhHD1LP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IkMMO9KGcan72Y8628c6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y5SNSfKG19R6AV3vrLau()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private byte[] JdRdWGUVM6;

	private readonly CvsCellRange MnAdj6tPSi;

	private readonly int UhOdC1JVNi;

	private EzTool oe1dOT4pVv;

	[CompilerGenerated]
	private string j7GdHvXklH;

	[CompilerGenerated]
	private readonly InspectStepViewModel IgRdwVUDSn;

	[CompilerGenerated]
	private readonly bool fPYdycMx7h;

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
			return j7GdHvXklH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			j7GdHvXklH = value;
		}
	}

	public InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IgRdwVUDSn;
		}
	}

	public bool PasteWithShifting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fPYdycMx7h;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteToolUndoAction(InspectStepViewModel inspect, bool shift, CvsCellRange copyCellRange, int pasteTimes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				MnAdj6tPSi = copyCellRange;
				num = 2;
				break;
			case 6:
				IgRdwVUDSn = inspect;
				_ = 1;
				if (!mktYk0flGIZO53XdgFg())
				{
					num = 5;
					break;
				}
				num = 0;
				if (BnnylHfd2KQIbtTQ9rR())
				{
					break;
				}
				goto case 2;
			case 7:
				vG8drkfsHk7xKv6vKZH(this);
				num = 6;
				break;
			case 3:
			case 5:
				fPYdycMx7h = shift;
				goto default;
			case 2:
				UhOdC1JVNi = pasteTimes;
				num = 8;
				break;
			case 1:
				umB56qfgQilV8XSdu9W();
				num = 7;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__15))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CSaveState_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 2:
				stateMachine._003C_003Et__builder = GvJZEsfv9884XQpLoWn();
				_ = 1;
				if (mktYk0flGIZO53XdgFg())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (BnnylHfd2KQIbtTQ9rR())
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__16))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!mktYk0flGIZO53XdgFg())
		{
		}
		_003CDo_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = GvJZEsfv9884XQpLoWn();
				mktYk0flGIZO53XdgFg();
				num = (BnnylHfd2KQIbtTQ9rR() ? 4 : 3);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__17))]
	public Task Redo()
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
		goto IL_0034;
		IL_001a:
		_003CRedo_003Ed__17 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_009f;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 4:
				goto IL_0065;
			case 5:
				stateMachine._003C_003Et__builder = GvJZEsfv9884XQpLoWn();
				num = 4;
				if (BnnylHfd2KQIbtTQ9rR())
				{
					continue;
				}
				goto IL_009f;
			default:
				goto IL_009f;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0065:
			stateMachine._003C_003E4__this = this;
			_ = 1;
			num = ((!mktYk0flGIZO53XdgFg()) ? 1 : 0);
		}
		goto IL_001a;
		IL_009f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__18))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUndo_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = GvJZEsfv9884XQpLoWn();
				num = 5;
				continue;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (mktYk0flGIZO53XdgFg())
				{
					num = 1;
					continue;
				}
				num = 4;
				if (BnnylHfd2KQIbtTQ9rR())
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
	[AsyncStateMachine(typeof(_003CPaste_003Ed__19))]
	private Task XiSdT76WBT(bool P_0, byte[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CPaste_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (BnnylHfd2KQIbtTQ9rR())
				{
					num = 0;
					continue;
				}
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 6:
				stateMachine._003C_003Et__builder = GvJZEsfv9884XQpLoWn();
				num = 1;
				continue;
			case 0:
			case 2:
				stateMachine.shift = P_0;
				num = 5;
				continue;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				if (BnnylHfd2KQIbtTQ9rR())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine.data = P_1;
				goto default;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!mktYk0flGIZO53XdgFg())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void umB56qfgQilV8XSdu9W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vG8drkfsHk7xKv6vKZH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BnnylHfd2KQIbtTQ9rR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mktYk0flGIZO53XdgFg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GvJZEsfv9884XQpLoWn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
