using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.Remoting.CogSocket;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class MathToolPasteCellsUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolPasteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i8MquiK19ymjGk5YlVS8();
			int num;
			if (!OSTHo7K14MbmdwMZCISJ())
			{
				num = 5;
				if (!i8MquiK19ymjGk5YlVS8())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0176;
			IL_01cf:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0176;
			IL_0176:
			int num2 = default;
			MathToolPasteCellsUndoAction mathToolPasteCellsUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					break;
				default:
					num = 1;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (i8MquiK19ymjGk5YlVS8())
					{
						continue;
					}
					goto case 4;
				case 4:
					mathToolPasteCellsUndoAction = _003C_003E4__this;
					break;
				case 1:
					goto IL_01cf;
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
					awaiter = wxQr6dK17QJTBkIFcnsk(mathToolPasteCellsUndoAction.Redo());
					num3 = 0;
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
					case 2:
					case 4:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 5:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 1:
						_003C_003Eu__1 = default;
						goto case 5;
					case 0:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 3:
						num2 = (_003C_003E1__state = 0);
						OSTHo7K14MbmdwMZCISJ();
						num3 = (i8MquiK19ymjGk5YlVS8() ? 4 : 5);
						continue;
					case 8:
						return;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 8;
						if (i8MquiK19ymjGk5YlVS8())
						{
							continue;
						}
						break;
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
			goto IL_01cf;
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
		internal static TaskAwaiter wxQr6dK17QJTBkIFcnsk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i8MquiK19ymjGk5YlVS8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OSTHo7K14MbmdwMZCISJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public _003C_003Ef__AnonymousType3<CvsCellLocation, CvsCellLocation> loc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass18_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			s40cffK1661uGptY561Q(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRedo_003Eb__1(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MDbZdxK1RdVQXgZOOuNj(PadK72K1AqjYOt4KmAWR(om3iseK1CoRkfwDiO3o6(c)), loc.source);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s40cffK1661uGptY561Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SdRXl4K13UGdO8TYardJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q4uJUkK1j0THoeusAbF8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object om3iseK1CoRkfwDiO3o6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation PadK72K1AqjYOt4KmAWR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MDbZdxK1RdVQXgZOOuNj(CvsCellLocation P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedo_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolPasteCellsUndoAction _003C_003E4__this;

		private int _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			MathToolPasteCellsUndoAction mathToolPasteCellsUndoAction = default;
			PasteBufferCell pasteBufferCell = default;
			string item = default;
			bool item2 = default;
			int num2 = default;
			do
			{
				IL_0357:
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_030a;
							}
							mathToolPasteCellsUndoAction.GjjO1WsS7N();
							_003C_003E7__wrap1 = 0;
						}
						try
						{
							if (num2 != 0)
							{
								byte[] array = mathToolPasteCellsUndoAction.HHIHAnBDJQ.ToArray();
								PasteBuffer pasteBuffer = (PasteBuffer)TiTL7aK1MAAxkQ23yh9k(array);
								var enumerator = mathToolPasteCellsUndoAction.GjjO1WsS7N().Zip(mathToolPasteCellsUndoAction.qMvO8io62C(), [MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation x, CvsCellLocation y) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return new
									{
										des = x,
										source = y
									};
								}).GetEnumerator();
								try
								{
									while (LAwY3nK1xs3x2W3xDbFy(enumerator))
									{
										_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass18_0();
										tF3MsbK1FsS1yGBbWa3X();
										int num3;
										if (l1gtvLK10Z4ARlJHDJxX())
										{
											num3 = 4;
										}
										else
										{
											num3 = 3;
											if (false)
											{
												goto IL_0108;
											}
										}
										goto IL_013f;
										IL_0108:
										CS_0024_003C_003E8__locals3.loc = enumerator.Current;
										num3 = 6;
										if (!l1gtvLK10Z4ARlJHDJxX())
										{
											goto IL_0126;
										}
										goto IL_013f;
										IL_0126:
										if (pasteBufferCell == null)
										{
											continue;
										}
										goto IL_00b7;
										IL_00b7:
										(string snippetName, string propName, bool isInternal) tuple = EzSnippet.SplitCellName((string)wUdrXsK1Y79K7UrdlNWD(pasteBufferCell));
										item = tuple.snippetName;
										item2 = tuple.isInternal;
										num3 = 5;
										goto IL_013f;
										IL_013f:
										while (true)
										{
											switch (num3)
											{
											case 1:
												break;
											case 6:
												pasteBufferCell = pasteBuffer.Cells.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
												{
													while (false)
													{
														_ = ((object[])null)[0];
													}
													return _003C_003Ec__DisplayClass18_0.MDbZdxK1RdVQXgZOOuNj(_003C_003Ec__DisplayClass18_0.PadK72K1AqjYOt4KmAWR(_003C_003Ec__DisplayClass18_0.om3iseK1CoRkfwDiO3o6(c)), CS_0024_003C_003E8__locals3.loc.source);
												});
												goto IL_0126;
											case 0:
											case 4:
												goto IL_0108;
											case 2:
											case 3:
												goto IL_0126;
											default:
												num3 = 1;
												continue;
											case 5:
												MPDQAEK1HrS6bOoZDmw9(pasteBufferCell, EzSnippet.AssembleFullCellName(item, IhBn1kK1UPAimuElKjIo(mathToolPasteCellsUndoAction.MathTool, CS_0024_003C_003E8__locals3.loc.des).ToString(), item2));
												num3 = 7;
												if (!tF3MsbK1FsS1yGBbWa3X())
												{
													continue;
												}
												goto IL_01b4;
											case 7:
												goto IL_01b4;
											}
											break;
										}
										goto IL_00b7;
										IL_01b4:;
									}
								}
								finally
								{
									if (num2 < 0 && enumerator != null)
									{
										itYiUbK1mAxIWFBJpfdN(enumerator);
									}
								}
								array = (byte[])x3mc6AK1Qt8IiVNpXbHR(pasteBuffer);
								awaiter = lwydFAK1cmlLpwORklp6(((CvsCogSocket)QHasA5K12fUqy8L10146(uxKArVK1NwoF7o7fyDJG(mathToolPasteCellsUndoAction.e5yHa4Rryk))).Sheet.InternalPasteCellsAsync(mathToolPasteCellsUndoAction.GjjO1WsS7N(), array, mathToolPasteCellsUndoAction.aplHdBrWbw, runSheet: true));
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
						catch (CvsNetworkException ex) when (cewopsK11QipEErheS8j(ex) is CogSocketErrorResponseReceivedException)
						{
							_003C_003E7__wrap1 = 1;
						}
						int num4 = _003C_003E7__wrap1;
						if (num4 == 1)
						{
							awaiter = lwydFAK1cmlLpwORklp6(mathToolPasteCellsUndoAction.Undo());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_030a;
						}
						goto end_IL_0018;
						IL_030a:
						awaiter.GetResult();
						throw new UndoActionCanceledException((string)nXROQsK1uFbM36Rqp0TQ());
						end_IL_0018:;
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
					goto IL_0357;
				case 1:
				case 5:
					mathToolPasteCellsUndoAction = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					tF3MsbK1FsS1yGBbWa3X();
					num = (l1gtvLK10Z4ARlJHDJxX() ? 5 : 4);
					goto IL_0357;
				case 0:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object TiTL7aK1MAAxkQ23yh9k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PasteBuffer.FromBytes((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wUdrXsK1Y79K7UrdlNWD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation IhBn1kK1UPAimuElKjIo(object P_0, CvsCellLocation actualCellLocation)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MathTool)P_0).GetVirtualCellLocation(actualCellLocation);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MPDQAEK1HrS6bOoZDmw9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((PasteBufferCell)P_0).Name = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LAwY3nK1xs3x2W3xDbFy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void itYiUbK1mAxIWFBJpfdN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x3mc6AK1Qt8IiVNpXbHR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).ToBytes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uxKArVK1NwoF7o7fyDJG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QHasA5K12fUqy8L10146(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lwydFAK1cmlLpwORklp6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cewopsK11QipEErheS8j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).InnerException;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nXROQsK1uFbM36Rqp0TQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.aJCZ45S7XD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l1gtvLK10Z4ARlJHDJxX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tF3MsbK1FsS1yGBbWa3X()
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
	private struct _003CSaveState_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolPasteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GuMZa0K1t1lPxlUx5mxB();
			int num = ((!iR38ZrK1hqEMF2B9scuZ()) ? 4 : 3);
			int num2 = default;
			MathToolPasteCellsUndoAction mathToolPasteCellsUndoAction = default;
			TaskAwaiter<byte[]> awaiter = default;
			byte[] result = default;
			CvsCellRange cellRange = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					mathToolPasteCellsUndoAction = _003C_003E4__this;
					num = 2;
					if (GuMZa0K1t1lPxlUx5mxB())
					{
					}
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
								if (!iR38ZrK1hqEMF2B9scuZ())
								{
									goto IL_008c;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
						}
						goto IL_0158;
						IL_008c:
						if (awaiter.IsCompleted)
						{
							goto IL_00f6;
						}
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						goto IL_0158;
						IL_00f6:
						result = awaiter.GetResult();
						_ = 0;
						num3 = ((!iR38ZrK1hqEMF2B9scuZ()) ? 9 : 6);
						goto IL_0158;
						IL_0158:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 13:
								awaiter = ((CvsCogSocket)nP9hkMKuKMwZIF8wLKiV(KUAULLKuL1kPuBptaBbJ(mathToolPasteCellsUndoAction.e5yHa4Rryk))).Sheet.CopyCellsAsync(cellRange).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 17;
									continue;
								}
								goto case 0;
							case 11:
								cellRange = mathToolPasteCellsUndoAction.qMvO8io62C();
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto IL_00f6;
							case 4:
								goto IL_00f6;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 5:
								cellRange = mathToolPasteCellsUndoAction.GjjO1WsS7N();
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 7:
								mathToolPasteCellsUndoAction.wy0H7fAMaH = result;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 12:
								_003C_003Eu__1 = default;
								goto case 9;
							case 2:
								awaiter = ((CvsCogSocketSheet)U8Q3N4K1z5uge8fTf4pU(mathToolPasteCellsUndoAction.e5yHa4Rryk.InSight.CogSocket)).CopyCellsAsync(cellRange).GetAwaiter();
								num3 = 3;
								continue;
							case 15:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 16;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (iR38ZrK1hqEMF2B9scuZ())
								{
									continue;
								}
								goto case 0;
							case 0:
								result = awaiter.GetResult();
								num3 = 18;
								continue;
							case 17:
								num2 = (_003C_003E1__state = 1);
								num3 = 1;
								if (GuMZa0K1t1lPxlUx5mxB())
								{
								}
								continue;
							case 18:
								mathToolPasteCellsUndoAction.s6vHNGwHDr = result;
								goto end_IL_006f;
							}
							break;
						}
						goto IL_008c;
						end_IL_006f:;
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
		internal static object U8Q3N4K1z5uge8fTf4pU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KUAULLKuL1kPuBptaBbJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nP9hkMKuKMwZIF8wLKiV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iR38ZrK1hqEMF2B9scuZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GuMZa0K1t1lPxlUx5mxB()
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
	private struct _003CUndo_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathToolPasteCellsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P46XvMKuwbri41ROoID2();
			int num;
			if (IbRN2CKu5QQL60rEYOGk())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (P46XvMKuwbri41ROoID2())
				{
				}
			}
			MathToolPasteCellsUndoAction mathToolPasteCellsUndoAction = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					mathToolPasteCellsUndoAction = _003C_003E4__this;
					goto case 1;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
								if (1 == 0)
								{
									goto IL_0128;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						goto IL_0168;
						IL_0168:
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter.GetResult();
								num3 = 6;
								if (IbRN2CKu5QQL60rEYOGk())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 7;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 14:
								return;
							case 12:
								break;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 6:
								cvsCellRange = mathToolPasteCellsUndoAction.qMvO8io62C();
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 3:
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 16;
								continue;
							case 2:
								awaiter = kAQ7KRKuIgNAqIHKAyIy(iJYLrJKuOnX87kw53tsY(GRMRNNKue7yWKCJs8j1C(dVCr4dKualwlEsFGywlT(rtvNEAKuJUaNSGTCBwPy(mathToolPasteCellsUndoAction.e5yHa4Rryk))), cvsCellRange, mathToolPasteCellsUndoAction.s6vHNGwHDr, false, true));
								num3 = 10;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 16:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							case 5:
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 8:
								awaiter = ((Task)iJYLrJKuOnX87kw53tsY(GRMRNNKue7yWKCJs8j1C(dVCr4dKualwlEsFGywlT(mathToolPasteCellsUndoAction.e5yHa4Rryk.InSight)), cvsCellRange, mathToolPasteCellsUndoAction.wy0H7fAMaH, false, true)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									P46XvMKuwbri41ROoID2();
									num3 = (IbRN2CKu5QQL60rEYOGk() ? 3 : 5);
									continue;
								}
								goto case 17;
							case 17:
								awaiter.GetResult();
								goto end_IL_0168;
							}
							goto IL_0128;
							continue;
							end_IL_0168:
							break;
						}
						goto end_IL_006f;
						IL_0128:
						cvsCellRange = mathToolPasteCellsUndoAction.GjjO1WsS7N();
						num3 = 2;
						goto IL_0168;
						end_IL_006f:;
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
					if (P46XvMKuwbri41ROoID2())
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
		internal static object rtvNEAKuJUaNSGTCBwPy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dVCr4dKualwlEsFGywlT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GRMRNNKue7yWKCJs8j1C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iJYLrJKuOnX87kw53tsY(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kAQ7KRKuIgNAqIHKAyIy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IbRN2CKu5QQL60rEYOGk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P46XvMKuwbri41ROoID2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InspectStepViewModel e5yHa4Rryk;

	private string T4VH5aZSD8;

	private CvsCellRange wssHpd4VPA;

	private CvsCellRange yleHUtTFsk;

	private byte[] wy0H7fAMaH;

	private byte[] s6vHNGwHDr;

	private byte[] HHIHAnBDJQ;

	private bool aplHdBrWbw;

	public MathTool MathTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return e5yHa4Rryk.Snippets.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return k21E7EykGXqvS3LV1r1(P_0.Name, T4VH5aZSD8);
			}) as MathTool;
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
			return (string)rslCZAyokgwjrFNTojn(mev4pFyGE7O6lytY4EO(), T4VH5aZSD8, wssHpd4VPA);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathToolPasteCellsUndoAction(InspectStepViewModel inspect, string mathToolName, CvsCellRange virtualSourceCellRange, byte[] pasteCells, CvsCellRange virtualDestCellRange, bool cut)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!hSy80uyrfHPjmNPHMH6()) ? 8 : 6);
		while (true)
		{
			switch (num)
			{
			case 7:
			case 8:
				aplHdBrWbw = cut;
				num = 10;
				if (!qqwfbZyPYUodfU1rKj2())
				{
					continue;
				}
				goto case 9;
			case 9:
				SwC4YpyBjWLOsRIjOGC(this);
				num = 5;
				continue;
			case 0:
			case 6:
				h3sb64yZcvFrlp7E3QE();
				num = 9;
				continue;
			case 2:
				T4VH5aZSD8 = mathToolName;
				num = 1;
				if (hSy80uyrfHPjmNPHMH6())
				{
					continue;
				}
				goto case 1;
			case 1:
				yleHUtTFsk = virtualSourceCellRange;
				break;
			default:
				num = 3;
				continue;
			case 5:
				e5yHa4Rryk = inspect;
				num = 2;
				continue;
			case 3:
				break;
			case 4:
				HHIHAnBDJQ = pasteCells;
				goto case 7;
			case 10:
				return;
			}
			wssHpd4VPA = virtualDestCellRange;
			num = 4;
			if (qqwfbZyPYUodfU1rKj2())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsCellRange qMvO8io62C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellRange result = default;
		MathTool mathTool = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				result = tAdZPsyb8lJrlXHXd3L(mathTool, yleHUtTFsk);
				num = 6;
				if (hSy80uyrfHPjmNPHMH6())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				mathTool = MathTool;
				goto case 0;
			case 0:
			case 2:
				if (mathTool == null)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 4:
				result = CvsCellRange.Invalid;
				_ = 0;
				if (!hSy80uyrfHPjmNPHMH6())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 5;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsCellRange GjjO1WsS7N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCellRange result = default;
		MathTool mathTool = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				result = CvsCellRange.Invalid;
				_ = 0;
				num = (hSy80uyrfHPjmNPHMH6() ? 4 : 0);
				continue;
			case 0:
			case 2:
				if (mathTool == null)
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 4:
				mathTool = MathTool;
				goto case 0;
			case 5:
				result = tAdZPsyb8lJrlXHXd3L(mathTool, wssHpd4VPA);
				num = 6;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__17))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qqwfbZyPYUodfU1rKj2();
		int num;
		if (hSy80uyrfHPjmNPHMH6())
		{
			num = 2;
		}
		else
		{
			num = 5;
			if (!hSy80uyrfHPjmNPHMH6())
			{
				goto IL_0095;
			}
		}
		goto IL_0042;
		IL_0042:
		_003CDo_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				if (hSy80uyrfHPjmNPHMH6())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = BFao8ryS37M1qQortKe();
				goto case 1;
			case 4:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (!qqwfbZyPYUodfU1rKj2())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0095;
		IL_0095:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (qqwfbZyPYUodfU1rKj2())
		{
		}
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__18))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hSy80uyrfHPjmNPHMH6();
		int num = (qqwfbZyPYUodfU1rKj2() ? 4 : 3);
		_003CRedo_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				if (!qqwfbZyPYUodfU1rKj2())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!qqwfbZyPYUodfU1rKj2())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = BFao8ryS37M1qQortKe();
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__19))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSaveState_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder = BFao8ryS37M1qQortKe();
				_ = 0;
				num = (hSy80uyrfHPjmNPHMH6() ? 4 : 3);
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__20))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qqwfbZyPYUodfU1rKj2();
		int num;
		if (hSy80uyrfHPjmNPHMH6())
		{
			num = 4;
			if (!hSy80uyrfHPjmNPHMH6())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0060;
			}
		}
		goto IL_007a;
		IL_007a:
		_003CUndo_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto IL_0060;
			case 2:
			case 3:
				goto IL_0060;
			default:
				num = 1;
				if (hSy80uyrfHPjmNPHMH6())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = BFao8ryS37M1qQortKe();
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_0060:
		stateMachine._003C_003E1__state = -1;
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_007a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool t5oOhEF91F(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return k21E7EykGXqvS3LV1r1(P_0.Name, T4VH5aZSD8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h3sb64yZcvFrlp7E3QE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SwC4YpyBjWLOsRIjOGC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hSy80uyrfHPjmNPHMH6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qqwfbZyPYUodfU1rKj2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange tAdZPsyb8lJrlXHXd3L(object P_0, CvsCellRange virtualCellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MathTool)P_0).GetActualCellRange(virtualCellRange);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mev4pFyGE7O6lytY4EO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.c6PhbJS68U();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rslCZAyokgwjrFNTojn(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder BFao8ryS37M1qQortKe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k21E7EykGXqvS3LV1r1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
