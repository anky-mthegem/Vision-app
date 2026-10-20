using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.Remoting.CogSocket;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class MathToolExpressionUndoAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolExpressionUndoAction _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellLocation _003CcellLocation_003E5__3;

		private MathTool _003CmathTool_003E5__4;

		private int _003C_003E7__wrap4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_06c3;
			IL_0684:
			_003C_003Et__builder.SetResult();
			num = 8;
			goto IL_06c3;
			IL_06c3:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 6:
					goto IL_0661;
				case 7:
					goto IL_0684;
				case 3:
					num2 = _003C_003E1__state;
					num = 6;
					continue;
				case 0:
					_003Csheet_003E5__2 = null;
					goto default;
				default:
					_003CmathTool_003E5__4 = null;
					num = 7;
					continue;
				case 8:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0661:
			MathToolExpressionUndoAction mathToolExpressionUndoAction = _003C_003E4__this;
			LAIjDeK1O8Y4hcNlbbxx();
			if (hb5suBK1eKO20laoD2wG())
			{
				num = 1;
				if (false)
				{
					goto IL_0684;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_06c3;
			IL_001a:
			try
			{
				if ((uint)num2 <= 4u)
				{
					goto IL_0080;
				}
				TaskAwaiter awaiter = default;
				if (num2 == 5)
				{
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_060c;
				}
				_003Csheet_003E5__2 = (CvsCogSocketSheet)sBKaRWK1ITNkqk0p74lB(mathToolExpressionUndoAction.lfnOVbjW25.InSight.CogSocket);
				_003CcellLocation_003E5__3 = mathToolExpressionUndoAction.CellLocation;
				_003CmathTool_003E5__4 = mathToolExpressionUndoAction.MathTool;
				string text = default;
				if (_003CmathTool_003E5__4 != null)
				{
					text = (string)MKGkFNK1D2tUZgY7f1cU(_003CmathTool_003E5__4, mathToolExpressionUndoAction.W4pO9TWVe9);
					_003C_003E7__wrap4 = 0;
					goto IL_0080;
				}
				goto end_IL_001a;
				IL_060c:
				awaiter.GetResult();
				throw new UndoActionCanceledException((string)IrQTcfK1gHRrLFothBdJ());
				IL_0080:
				try
				{
					int num3;
					TaskAwaiter<object> awaiter2 = default;
					switch (num2)
					{
					default:
						if (w2Mso0K1isFB4BYq60pB(text))
						{
							num3 = 23;
						}
						else
						{
							awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(_003CcellLocation_003E5__3, text).GetAwaiter();
							num3 = 19;
						}
						goto IL_0334;
					case 1:
						awaiter2 = _003C_003Eu__1;
						num3 = 18;
						goto IL_0334;
					case 4:
						awaiter = _003C_003Eu__2;
						num3 = 2;
						goto IL_0334;
					case 3:
						awaiter2 = _003C_003Eu__1;
						num3 = 0;
						if (!hb5suBK1eKO20laoD2wG())
						{
							goto IL_0280;
						}
						goto IL_0334;
					case 0:
						awaiter2 = _003C_003Eu__1;
						num3 = 24;
						goto IL_0334;
					case 2:
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							goto IL_00e2;
						}
						IL_00fb:
						awaiter2.GetResult();
						goto IL_0103;
						IL_0103:
						awaiter = iTKkPkK1lTLi5tEXXvBX(mathToolExpressionUndoAction.U1EOYOol23(_003Csheet_003E5__2));
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 15;
						goto IL_0334;
						IL_0334:
						while (true)
						{
							switch (num3)
							{
							case 28:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 1:
							case 9:
								if (!awaiter2.IsCompleted)
								{
									num3 = 26;
									if (LAIjDeK1O8Y4hcNlbbxx())
									{
									}
									continue;
								}
								goto case 13;
							case 11:
							case 21:
								break;
							case 14:
								goto IL_00fb;
							case 20:
								goto IL_0103;
							case 10:
								return;
							case 22:
								awaiter2.GetResult();
								num3 = 12;
								continue;
							case 13:
								awaiter2.GetResult();
								num3 = 20;
								if (hb5suBK1eKO20laoD2wG())
								{
									continue;
								}
								goto case 23;
							case 23:
								awaiter2 = _003Csheet_003E5__2.ClearCellsAsync(new CvsCellRange(_003CcellLocation_003E5__3)).GetAwaiter();
								hb5suBK1eKO20laoD2wG();
								if (!LAIjDeK1O8Y4hcNlbbxx())
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 26;
								}
								num3 = 11;
								if (!LAIjDeK1O8Y4hcNlbbxx())
								{
									continue;
								}
								goto end_IL_0081;
							case 26:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 12:
								awaiter2 = _003Csheet_003E5__2.ApplyCellAttributesAsync(new CvsCellRange(_003CcellLocation_003E5__3), new DictionaryEntry(MVSLXWK1VKGb5Qr67D1N(51034), w26g4IK1d83rxvNnRlZN(dX3GHAK1fTogj7gXHPmb(_003CmathTool_003E5__4)).ToString(absoluteRow: true, absoluteColumn: true))).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									num3 = 27;
									continue;
								}
								goto IL_00fb;
							case 25:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 29:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 4:
								goto IL_0280;
							case 24:
								_003C_003Eu__1 = default;
								num3 = 28;
								continue;
							case 32:
								_003C_003Eu__1 = awaiter2;
								num3 = 7;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 30;
								continue;
							case 19:
								if (!awaiter2.IsCompleted)
								{
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								}
								goto case 33;
							case 5:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 10;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter2;
								num3 = 17;
								continue;
							case 33:
								awaiter2.GetResult();
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 8:
								if (!w2Mso0K1isFB4BYq60pB(mathToolExpressionUndoAction.DEsOr8I6iV))
								{
									goto IL_0103;
								}
								awaiter2 = _003Csheet_003E5__2.PutCellNameAsync(_003CcellLocation_003E5__3, EzSnippet.AssembleFullCellName((string)SiAuJlK1nKfXIup2N3VQ(_003CmathTool_003E5__4), mathToolExpressionUndoAction.NMYOL5JnGi.ToString(absoluteRow: false, absoluteColumn: false))).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 22;
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 5;
								if (hb5suBK1eKO20laoD2wG())
								{
									continue;
								}
								goto case 31;
							case 31:
								num2 = (_003C_003E1__state = -1);
								num3 = 33;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 15:
								num2 = (_003C_003E1__state = 4);
								num3 = 25;
								continue;
							case 18:
								_003C_003Eu__1 = default;
								num3 = 31;
								continue;
							case 27:
								_003C_003Eu__1 = awaiter2;
								num3 = 29;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__2 = default;
								num3 = 3;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 34;
								if (0 == 0)
								{
									continue;
								}
								goto case 17;
							case 17:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 30:
								return;
							case 34:
								goto end_IL_0081;
							}
							break;
						}
						goto IL_00e2;
						IL_0280:
						num2 = (_003C_003E1__state = 2);
						num3 = 32;
						goto IL_0334;
						IL_00e2:
						num2 = (_003C_003E1__state = -1);
						num3 = 22;
						if (!hb5suBK1eKO20laoD2wG())
						{
							goto IL_00fb;
						}
						goto IL_0334;
						end_IL_0081:
						break;
					}
					awaiter.GetResult();
				}
				catch (CvsNetworkException ex) when (ex.InnerException is CogSocketErrorResponseReceivedException)
				{
					_003C_003E7__wrap4 = 1;
				}
				int num4 = _003C_003E7__wrap4;
				if (num4 == 1)
				{
					mathToolExpressionUndoAction.W4pO9TWVe9 = string.Empty;
					awaiter = mathToolExpressionUndoAction.Undo().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 5);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_060c;
				}
				end_IL_001a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Csheet_003E5__2 = null;
				_003CmathTool_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			num = 0;
			if (1 == 0)
			{
				goto IL_0661;
			}
			goto IL_06c3;
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
		internal static object sBKaRWK1ITNkqk0p74lB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MKGkFNK1D2tUZgY7f1cU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MathTool)P_0).TranslateToSpreadsheet((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w2Mso0K1isFB4BYq60pB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SiAuJlK1nKfXIup2N3VQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MVSLXWK1VKGb5Qr67D1N(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dX3GHAK1fTogj7gXHPmb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation w26g4IK1d83rxvNnRlZN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iTKkPkK1lTLi5tEXXvBX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IrQTcfK1gHRrLFothBdJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.aJCZ45S7XD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hb5suBK1eKO20laoD2wG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LAIjDeK1O8Y4hcNlbbxx()
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
	private struct _003CUndo_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolExpressionUndoAction _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellLocation _003CcellLocation_003E5__3;

		private MathTool _003CmathTool_003E5__4;

		private int _003C_003E7__wrap4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!RD6PeaK1v4Y76DNx5UOI())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0080;
			IL_0039:
			MathToolExpressionUndoAction mathToolExpressionUndoAction = _003C_003E4__this;
			goto IL_00d0;
			IL_0080:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 4:
					goto IL_0039;
				case 5:
					_003CmathTool_003E5__4 = null;
					num = 7;
					if (!RD6PeaK1v4Y76DNx5UOI())
					{
						continue;
					}
					goto case 6;
				case 6:
					_003Csheet_003E5__2 = null;
					goto case 5;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 7;
				case 7:
					_003C_003Et__builder.SetResult();
					num = 8;
					if (oH9Dy3K1srWwAmYlXqrr())
					{
						continue;
					}
					goto IL_00d0;
				case 2:
				case 3:
					goto IL_00d0;
				case 8:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			int num2 = _003C_003E1__state;
			num = 4;
			if (false)
			{
				goto IL_0039;
			}
			goto IL_0080;
			IL_00d0:
			try
			{
				if ((uint)num2 <= 4u)
				{
					goto IL_0124;
				}
				TaskAwaiter<object> awaiter = default;
				if (num2 == 5)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_06d4;
				}
				_003Csheet_003E5__2 = (CvsCogSocketSheet)w3BmcCK1Zd2TOVOB6sUI(Xhc0RIK1PQbBVM6cW65V(uHsqHtK1rKbH3VF8Qoo4(mathToolExpressionUndoAction.lfnOVbjW25)));
				_003CcellLocation_003E5__3 = mathToolExpressionUndoAction.CellLocation;
				_003CmathTool_003E5__4 = mathToolExpressionUndoAction.MathTool;
				if (_003CmathTool_003E5__4 != null)
				{
					_003C_003E7__wrap4 = 0;
					goto IL_0124;
				}
				goto end_IL_00d0;
				IL_06d4:
				awaiter.GetResult();
				throw new UndoActionCanceledException((string)vODvgXK1qmafRQBJwrrV());
				IL_0124:
				try
				{
					string text = default;
					int num3;
					TaskAwaiter awaiter2 = default;
					switch (num2)
					{
					default:
						text = (string)UO9KeMK1BiCKExOOqUOA(_003CmathTool_003E5__4, mathToolExpressionUndoAction.DEsOr8I6iV);
						num3 = 11;
						if (RD6PeaK1v4Y76DNx5UOI())
						{
							goto IL_0160;
						}
						goto IL_03c5;
					case 1:
						awaiter = _003C_003Eu__1;
						num3 = 9;
						goto IL_03c5;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_03c5;
					case 4:
						awaiter2 = _003C_003Eu__2;
						goto IL_0476;
					case 0:
						awaiter = _003C_003Eu__1;
						num3 = 0;
						if (oH9Dy3K1srWwAmYlXqrr())
						{
							goto IL_03c5;
						}
						goto IL_05c5;
					case 3:
						{
							awaiter = _003C_003Eu__1;
							num3 = 12;
							goto IL_03c5;
						}
						IL_03c5:
						while (true)
						{
							switch (num3)
							{
							case 27:
								break;
							case 29:
								goto IL_017c;
							case 22:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								continue;
							case 34:
								num2 = (_003C_003E1__state = -1);
								num3 = 35;
								continue;
							case 28:
								if (!awaiter.IsCompleted)
								{
									num3 = 32;
									continue;
								}
								goto IL_02b0;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									if (true)
									{
										continue;
									}
									goto case 12;
								}
								goto IL_0562;
							case 12:
								_003C_003Eu__1 = default;
								num3 = 22;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								if (!RD6PeaK1v4Y76DNx5UOI())
								{
									continue;
								}
								goto case 11;
							case 11:
								if (!jt1O3EK1b1vtFnMnHgZQ(text))
								{
									awaiter = _003Csheet_003E5__2.PutCellExpressionAsync(_003CcellLocation_003E5__3, text).GetAwaiter();
									num3 = 5;
									continue;
								}
								RD6PeaK1v4Y76DNx5UOI();
								if (oH9Dy3K1srWwAmYlXqrr())
								{
									num3 = 18;
									if (RD6PeaK1v4Y76DNx5UOI())
									{
									}
									continue;
								}
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 32;
							case 17:
								_003C_003Eu__2 = awaiter2;
								num3 = 25;
								if (oH9Dy3K1srWwAmYlXqrr())
								{
									continue;
								}
								return;
							case 15:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_02b0;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								awaiter = _003Csheet_003E5__2.ApplyCellAttributesAsync(new CvsCellRange(_003CcellLocation_003E5__3), new DictionaryEntry(tfPyyYK1oNXmht6g6R8N(51034), pb4rspK1kl0htwFNdVe5(UCjctCK1SjMhXkduFwQM(_003CmathTool_003E5__4)).ToString(absoluteRow: true, absoluteColumn: true))).GetAwaiter();
								num3 = 21;
								continue;
							case 19:
							case 23:
								goto IL_034f;
							case 25:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 24;
								continue;
							case 24:
								return;
							case 32:
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 2:
								awaiter.GetResult();
								num3 = 23;
								continue;
							case 7:
							case 31:
								goto IL_0476;
							case 0:
								goto IL_048e;
							case 30:
								num2 = (_003C_003E1__state = 0);
								num3 = 29;
								continue;
							case 21:
								if (awaiter.IsCompleted)
								{
									goto case 2;
								}
								num3 = 20;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									num3 = 17;
									continue;
								}
								goto case 35;
							case 20:
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								num3 = 26;
								if (!RD6PeaK1v4Y76DNx5UOI())
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = _003Csheet_003E5__2.PutCellNameAsync(_003CcellLocation_003E5__3, EzSnippet.AssembleFullCellName((string)Xo9WwOK1GhxKg8P3vJGI(_003CmathTool_003E5__4), mathToolExpressionUndoAction.NMYOL5JnGi.ToString(absoluteRow: false, absoluteColumn: false))).GetAwaiter();
								num3 = 28;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0562;
							case 14:
								goto IL_0574;
							case 13:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 33:
								return;
							case 1:
							case 18:
								goto IL_05c5;
							case 26:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 35:
								{
									awaiter2.GetResult();
									goto end_IL_0125;
								}
								IL_0562:
								awaiter.GetResult();
								num3 = 27;
								continue;
								IL_02b0:
								awaiter.GetResult();
								num3 = 4;
								continue;
							}
							break;
						}
						goto IL_0160;
						IL_05c5:
						awaiter = _003Csheet_003E5__2.ClearCellsAsync(new CvsCellRange(_003CcellLocation_003E5__3)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 30;
							goto IL_03c5;
						}
						goto IL_057d;
						IL_034f:
						awaiter2 = RRYZheK181Q7C1x2wwVT(mathToolExpressionUndoAction.U1EOYOol23(_003Csheet_003E5__2));
						num3 = 16;
						goto IL_03c5;
						IL_0574:
						num2 = (_003C_003E1__state = -1);
						goto IL_057d;
						IL_057d:
						awaiter.GetResult();
						num3 = 19;
						goto IL_03c5;
						IL_0476:
						_003C_003Eu__2 = default;
						num3 = 34;
						if (true)
						{
							goto IL_03c5;
						}
						goto IL_048e;
						IL_048e:
						_003C_003Eu__1 = default;
						num3 = 14;
						goto IL_03c5;
						IL_0160:
						if (!jt1O3EK1b1vtFnMnHgZQ(mathToolExpressionUndoAction.W4pO9TWVe9))
						{
							goto IL_034f;
						}
						num3 = 10;
						if (1 == 0)
						{
							goto IL_017c;
						}
						goto IL_03c5;
						IL_017c:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 33;
						goto IL_03c5;
						end_IL_0125:
						break;
					}
				}
				catch (CvsNetworkException ex) when (ex.InnerException is CogSocketErrorResponseReceivedException)
				{
					_003C_003E7__wrap4 = 1;
				}
				int num4 = _003C_003E7__wrap4;
				if (num4 == 1)
				{
					awaiter = _003Csheet_003E5__2.ClearCellsAsync(new CvsCellRange(_003CcellLocation_003E5__3)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 5);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_06d4;
				}
				end_IL_00d0:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Csheet_003E5__2 = null;
				_003CmathTool_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			num = 6;
			if (RD6PeaK1v4Y76DNx5UOI())
			{
				return;
			}
			goto IL_0080;
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
		internal static object uHsqHtK1rKbH3VF8Qoo4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xhc0RIK1PQbBVM6cW65V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w3BmcCK1Zd2TOVOB6sUI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UO9KeMK1BiCKExOOqUOA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MathTool)P_0).TranslateToSpreadsheet((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jt1O3EK1b1vtFnMnHgZQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xo9WwOK1GhxKg8P3vJGI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tfPyyYK1oNXmht6g6R8N(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UCjctCK1SjMhXkduFwQM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation pb4rspK1kl0htwFNdVe5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter RRYZheK181Q7C1x2wwVT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vODvgXK1qmafRQBJwrrV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.aJCZ45S7XD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oH9Dy3K1srWwAmYlXqrr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RD6PeaK1v4Y76DNx5UOI()
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
	private struct _003CRunAndUpdate_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet sheet;

		public MathToolExpressionUndoAction _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (VFA2i4K1p44dPyBEvXKD() ? 5 : 2);
			MathToolExpressionUndoAction mathToolExpressionUndoAction = default;
			int num2 = default;
			GroupTool groupTool = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					mathToolExpressionUndoAction = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = sheet.RunAndGetCellResults().GetAwaiter();
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (false)
							{
								goto IL_0183;
							}
						}
						goto IL_00e0;
						IL_0183:
						num2 = (_003C_003E1__state = -1);
						num3 = 0;
						goto IL_00e0;
						IL_00e0:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 8:
								if (groupTool != null)
								{
									num3 = 11;
									continue;
								}
								goto end_IL_00e0;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								}
								goto case 0;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 0:
								result = awaiter.GetResult();
								num3 = 4;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								goto default;
							default:
								_ = 0;
								if (KM3N9sK1EGXdokFehLlo())
								{
									num3 = 6;
									continue;
								}
								num3 = 1;
								if (VFA2i4K1p44dPyBEvXKD())
								{
									return;
								}
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 4:
								groupTool = GqvUHXK1XeGq7Rm94CDb(mathToolExpressionUndoAction.lfnOVbjW25) as GroupTool;
								goto case 1;
							case 2:
								return;
							case 5:
							case 6:
								break;
							case 11:
								groupTool.nnG4uPQKIR(result);
								goto end_IL_00e0;
							}
							goto IL_0183;
							continue;
							end_IL_00e0:
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
		internal static object GqvUHXK1XeGq7Rm94CDb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).CurrentTool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KM3N9sK1EGXdokFehLlo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VFA2i4K1p44dPyBEvXKD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InspectStepViewModel lfnOVbjW25;

	private CvsCellLocation NMYOL5JnGi;

	private string gltOJEm67I;

	private string W4pO9TWVe9;

	private string DEsOr8I6iV;

	public MathTool MathTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lfnOVbjW25.Snippets.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return f27XF8yvVeKKx13mUkc(P_0.Name, gltOJEm67I);
			}) as MathTool;
		}
	}

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!XVU2U9ynFFokg8mDKlS())
			{
			}
			CvsCellLocation result = default;
			MathTool mathTool = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					result = CvsCellLocation.Invalid;
					_ = 0;
					if (RtXt03yix5q1FCe4pH0())
					{
						num = 5;
						continue;
					}
					num = 0;
					if (RtXt03yix5q1FCe4pH0())
					{
						continue;
					}
					goto case 1;
				case 2:
					if (mathTool == null)
					{
						break;
					}
					goto default;
				case 1:
				case 5:
					mathTool = MathTool;
					num = 2;
					continue;
				default:
					result = ANgBZgyf3SGL946ySqa(mathTool, NMYOL5JnGi);
					num = 6;
					continue;
				case 6:
					break;
				}
				break;
			}
			return result;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)HnsrTdyl8sbw6oT9S3T(u7HkEByds3YKdYQqOCn(), gltOJEm67I, NMYOL5JnGi);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathToolExpressionUndoAction(InspectStepViewModel inspect, string mathToolName, CvsCellLocation virtualLoc, string newExpression, string oldExpression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				gltOJEm67I = mathToolName;
				goto default;
			default:
				RtXt03yix5q1FCe4pH0();
				if (!XVU2U9ynFFokg8mDKlS())
				{
					num = 7;
					if (RtXt03yix5q1FCe4pH0())
					{
						continue;
					}
					goto case 4;
				}
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 4:
			case 7:
				NMYOL5JnGi = virtualLoc;
				break;
			case 3:
				DEsOr8I6iV = oldExpression;
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				lfnOVbjW25 = inspect;
				num = 2;
				continue;
			case 6:
				mJRiiCyVDlJubxF1Mu4(this);
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 6;
				continue;
			case 5:
			case 8:
				break;
			case 9:
				return;
			}
			W4pO9TWVe9 = newExpression;
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Redo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__13))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRedo_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = gMCOJ0ygc7yy3NS4PIN();
				_ = 1;
				num = ((!XVU2U9ynFFokg8mDKlS()) ? 2 : 5);
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)VjVKnhyskaSJWWEe4FH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__15))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CUndo_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = gMCOJ0ygc7yy3NS4PIN();
				XVU2U9ynFFokg8mDKlS();
				num = ((!RtXt03yix5q1FCe4pH0()) ? 5 : 4);
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (RtXt03yix5q1FCe4pH0())
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
	[AsyncStateMachine(typeof(_003CRunAndUpdate_003Ed__16))]
	private Task U1EOYOol23(CvsCogSocketSheet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRunAndUpdate_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 5:
				stateMachine.sheet = P_0;
				goto default;
			default:
				XVU2U9ynFFokg8mDKlS();
				num = (RtXt03yix5q1FCe4pH0() ? 6 : 2);
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool XRXO0ORoE8(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return f27XF8yvVeKKx13mUkc(P_0.Name, gltOJEm67I);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mJRiiCyVDlJubxF1Mu4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UndoAction)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RtXt03yix5q1FCe4pH0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XVU2U9ynFFokg8mDKlS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ANgBZgyf3SGL946ySqa(object P_0, CvsCellLocation virtualCellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MathTool)P_0).GetActualCellLocation(virtualCellLocation);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u7HkEByds3YKdYQqOCn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.iGohfZEuvd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HnsrTdyl8sbw6oT9S3T(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder gMCOJ0ygc7yy3NS4PIN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VjVKnhyskaSJWWEe4FH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f27XF8yvVeKKx13mUkc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
