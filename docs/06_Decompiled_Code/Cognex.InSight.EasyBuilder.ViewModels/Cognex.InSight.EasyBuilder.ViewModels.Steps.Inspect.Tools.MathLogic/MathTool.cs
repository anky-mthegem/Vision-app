using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Help;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Sensor;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using JjejQO32q1E0Mow99G;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

[Export(typeof(MathTool))]
public class MathTool : EzTool, ISnippetConsumer
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInternalPostParse_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_033f;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 0;
			if (eMyMRxKRGOPaBO430qxs())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_033f;
			IL_033f:
			CvsCellRange cellRange = default;
			MathTool mathTool = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation location = default;
			CvsCellLocation lastLocation = default;
			List<MiniSheetRow> list = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (epoIjlKRoalFMMmgPEtt())
					{
					}
					continue;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellRange = mathTool.CellRange;
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 15;
							if (false)
							{
								goto IL_02d4;
							}
						}
						goto IL_00d8;
						IL_02d4:
						mathTool.MvKQ1RTxff(cells);
						num3 = 11;
						goto IL_00d8;
						IL_00d8:
						while (true)
						{
							switch (num3)
							{
							case 19:
								mathTool.C3egSP8j5X = new CvsCellRange(location, lastLocation);
								mathTool.QhygDSE15X = mathTool.C3egSP8j5X;
								num3 = 14;
								if (eMyMRxKRGOPaBO430qxs())
								{
									continue;
								}
								goto case 8;
							case 8:
							case 18:
								num2 = (_003C_003E1__state = -1);
								num3 = 21;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 9:
								mathTool.MiniSheet = list;
								break;
							default:
								num3 = 20;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								location.Row += 2;
								lastLocation = location;
								lastLocation.Row += 7;
								lastLocation.Column += 7;
								num3 = 19;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								location = cellRange.Location;
								num3 = 16;
								if (eMyMRxKRGOPaBO430qxs())
								{
									continue;
								}
								goto case 7;
							case 7:
								num4++;
								num3 = 17;
								continue;
							case 15:
								_003C_003Eu__1 = default;
								goto case 8;
							case 10:
								mathTool.QhygDSE15X.Column = 0;
								list = new List<MiniSheetRow>();
								num3 = 2;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 3:
								awaiter = kgS4XCKRSlLkFwvfyaDc(mathTool.MlggUCZZ2v(cells));
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									if (epoIjlKRoalFMMmgPEtt())
									{
									}
									continue;
								}
								goto case 21;
							case 2:
								num4 = 0;
								num3 = 0;
								continue;
							case 11:
								mathTool.DDXQk0EoFu(cells);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								mathTool.QhygDSE15X.Row = 0;
								num3 = 10;
								continue;
							case 0:
							case 17:
								do
								{
									if (num4 < 8)
									{
										list.Add(new MiniSheetRow(mathTool.InSight)
										{
											Header = num4.ToString()
										});
										num3 = 7;
										if (epoIjlKRoalFMMmgPEtt())
										{
										}
										break;
									}
									_ = 0;
									if (!eMyMRxKRGOPaBO430qxs())
									{
										num3 = 8;
										continue;
									}
									num3 = 5;
									break;
								}
								while (1 == 0);
								continue;
							case 1:
								return;
							case 20:
								break;
							case 13:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								continue;
							case 21:
								awaiter.GetResult();
								goto end_IL_00d8;
							}
							goto IL_02d4;
							continue;
							end_IL_00d8:
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
					goto case 5;
				default:
					num = 5;
					continue;
				case 1:
				case 3:
					mathTool = _003C_003E4__this;
					goto case 2;
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
		internal static TaskAwaiter kgS4XCKRSlLkFwvfyaDc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eMyMRxKRGOPaBO430qxs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool epoIjlKRoalFMMmgPEtt()
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
	private struct _003CShiftEditGraphics_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		public int delta;

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
			goto IL_0176;
			IL_01a1:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (true)
			{
				goto IL_0176;
			}
			goto IL_01b8;
			IL_01db:
			MathTool mathTool = _003C_003E4__this;
			goto IL_001a;
			IL_01b8:
			int num2 = _003C_003E1__state;
			nW7BssKRkR5ehvfHOsdM();
			if (!nPlYjfKR8gn0PhfFepF8())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_01db;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			goto IL_0176;
			IL_001a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = mathTool.Point.Shift(delta).GetAwaiter();
					num3 = 7;
					if (nPlYjfKR8gn0PhfFepF8())
					{
						goto IL_0048;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 2;
				}
				goto IL_007d;
				IL_005d:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				IL_007d:
				while (true)
				{
					switch (num3)
					{
					case 1:
					case 6:
						break;
					case 3:
					case 5:
						goto IL_005d;
					default:
						num3 = 8;
						continue;
					case 8:
						return;
					case 0:
						_003C_003Eu__1 = awaiter;
						nW7BssKRkR5ehvfHOsdM();
						if (!nPlYjfKR8gn0PhfFepF8())
						{
							num3 = 5;
							continue;
						}
						num3 = 1;
						if (nW7BssKRkR5ehvfHOsdM())
						{
							continue;
						}
						goto case 7;
					case 4:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						continue;
					case 2:
						_003C_003Eu__1 = default;
						break;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							continue;
						}
						goto case 9;
					case 9:
						awaiter.GetResult();
						goto end_IL_001a;
					}
					break;
				}
				goto IL_0048;
				IL_0048:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				if (false)
				{
					goto IL_005d;
				}
				goto IL_007d;
				end_IL_001a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01a1;
			IL_0176:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					num = 0;
					continue;
				case 0:
					goto IL_01a1;
				case 5:
					goto IL_01b8;
				case 1:
				case 3:
					goto IL_01db;
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
		internal static bool nW7BssKRkR5ehvfHOsdM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nPlYjfKR8gn0PhfFepF8()
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
	private struct _003C_emptyCellViewModel_SourcePropertyChanged_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyValueChangedEventArgs<CellViewModel> args;

		public MathTool _003C_003E4__this;

		private string _003CnewExpression_003E5__2;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			MathTool mathTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!mErcA9KRqk2mxrt3SrFC()) ? 4 : 0);
					break;
				case 6:
					_003CnewExpression_003E5__2 = null;
					num = 3;
					break;
				case 0:
				case 1:
					mathTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<object> awaiter2;
						TaskAwaiter awaiter;
						switch (num2)
						{
						default:
							_003CnewExpression_003E5__2 = (string)QJTQDHKRp3PR0I7QZuA5(args.Current);
							_003C_003E7__wrap2 = 0;
							goto case 0;
						case 0:
						{
							try
							{
								int num3;
								if (num2 != 0)
								{
									awaiter = mathTool.J5wQsO8KVf(_003CnewExpression_003E5__2).GetAwaiter();
									num3 = 0;
									goto IL_0140;
								}
								awaiter = _003C_003Eu__1;
								goto IL_00c4;
								IL_00c4:
								_003C_003Eu__1 = default;
								num3 = 3;
								goto IL_0140;
								IL_0140:
								while (true)
								{
									switch (num3)
									{
									case 5:
									case 6:
										break;
									case 4:
									case 8:
										return;
									case 1:
										_003C_003Eu__1 = awaiter;
										num3 = 7;
										if (!XUkjh6KRErvd1inP62oJ())
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = -1);
										num3 = 9;
										continue;
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto default;
									default:
										_ = 1;
										num3 = ((!XUkjh6KRErvd1inP62oJ()) ? 8 : 6);
										continue;
									case 2:
										num2 = (_003C_003E1__state = 0);
										num3 = 1;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
										if (!awaiter.IsCompleted)
										{
											num3 = 2;
											continue;
										}
										goto case 9;
									case 9:
										awaiter.GetResult();
										goto end_IL_0140;
									}
									goto IL_00c4;
									continue;
									end_IL_0140:
									break;
								}
							}
							catch (CvsErrorResponseNetworkException ex) when (ex.ErrorCode == -1610415712)
							{
								_003C_003E7__wrap2 = 1;
							}
							int num4 = _003C_003E7__wrap2;
							if (num4 != 1)
							{
								break;
							}
							_003CnewExpression_003E5__2 = (string)EtmExeKR4ZcVdIbxOcc0(crkOH3KRXSnEU0Jrq75Y(50240), PfFIa8KR9udGVNh8Leey(args.Current));
							awaiter2 = ((CvsCogSocketSheet)aFhrQCKRjSPdY87TTYIk(YBSKs6KR3WyUDJrQbGnF(rJxiMPKR7dbo1aHvGYmN(mathTool.Parent)))).PutCellCommentAsync(mathTool.wXIgWk37S0, (string)EtmExeKR4ZcVdIbxOcc0(crkOH3KRXSnEU0Jrq75Y(50248), d53VCBKR6kDxobTFSK4B())).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_02aa;
						}
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_02aa;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_030f;
							}
							IL_030f:
							awaiter.GetResult();
							break;
							IL_02aa:
							awaiter2.GetResult();
							awaiter = rYn4W5KRCUiXtt249mOR(mathTool.J5wQsO8KVf(_003CnewExpression_003E5__2));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_030f;
						}
						EventHandler eventHandler = mathTool.hXagim4wBj;
						if (eventHandler != null)
						{
							IgTqexKRACJ8oeYd1fuc(eventHandler, mathTool, EventArgs.Empty);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnewExpression_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 7:
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
		internal static object QJTQDHKRp3PR0I7QZuA5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).RefExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object crkOH3KRXSnEU0Jrq75Y(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PfFIa8KR9udGVNh8Leey(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EtmExeKR4ZcVdIbxOcc0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rJxiMPKR7dbo1aHvGYmN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YBSKs6KR3WyUDJrQbGnF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aFhrQCKRjSPdY87TTYIk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d53VCBKR6kDxobTFSK4B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.OTfB10y8eS();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rYn4W5KRCUiXtt249mOR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IgTqexKRACJ8oeYd1fuc(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mErcA9KRqk2mxrt3SrFC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XUkjh6KRErvd1inP62oJ()
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
	private struct _003CAddReferenceAsync_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		public string newExpression;

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
			MathTool mathTool = default;
			CvsParse cvsParse = default;
			TaskAwaiter awaiter = default;
			string text = default;
			IUndoAction action = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					if (!kO5UI9KRWtFEnTfAIqnV())
					{
						continue;
					}
					goto case 0;
				case 0:
					mathTool = _003C_003E4__this;
					GkuohdKRRPfPho7oi5oO();
					num = (kO5UI9KRWtFEnTfAIqnV() ? 1 : 5);
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cvsParse = CvsParse.Parse((CvsFunctionTable)lw3PUEKRTCX3mQD2NNn0(mathTool.InSight), mathTool.InSight.ProcessorConstants, newExpression, g8BeyyKRydjHO2GNVxfq(newExpression), null, -1, (INamedOperandCollection)nDMtCfKR0I9l9CEWwY14(mathTool.xJugoFUm9e), mathTool.PfZgfxJ24d.IsValidFunction);
							num3 = 1;
							goto IL_01b8;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0182;
						IL_015f:
						text = TranslateFromSpreadsheet(newExpression, cvsParse, mathTool.QhygDSE15X, mathTool.C3egSP8j5X);
						num3 = 3;
						goto IL_01b8;
						IL_0116:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						_ = 0;
						if (GkuohdKRRPfPho7oi5oO())
						{
							num3 = 2;
							if (1 == 0)
							{
								return;
							}
						}
						else
						{
							num3 = 5;
							if (kO5UI9KRWtFEnTfAIqnV())
							{
								goto IL_015f;
							}
						}
						goto IL_01b8;
						IL_01b8:
						while (true)
						{
							switch (num3)
							{
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								action = mathTool.A5tQrXQV2T(cvsParse, text);
								num3 = 9;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 9:
								awaiter = xkNtZ4KRM5eQTZbNn70a(((UndoRedoQueue)fVyU8AKRFZc6iyXPQkfc(mathTool.InSight)).AddUndo(action));
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 11;
							case 4:
								break;
							case 2:
							case 6:
								return;
							case 1:
								goto IL_015f;
							case 5:
							case 7:
								goto IL_0182;
							case 0:
								goto IL_019e;
							default:
								num3 = 4;
								continue;
							case 11:
								awaiter.GetResult();
								goto end_IL_0050;
							}
							break;
						}
						goto IL_0116;
						IL_0182:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (!GkuohdKRRPfPho7oi5oO())
						{
							goto IL_019e;
						}
						goto IL_01b8;
						IL_019e:
						_003C_003Eu__1 = awaiter;
						goto IL_0116;
						end_IL_0050:;
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
		internal static object lw3PUEKRTCX3mQD2NNn0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int g8BeyyKRydjHO2GNVxfq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nDMtCfKR0I9l9CEWwY14(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ExpressionTextBoxViewModel)P_0).TagMap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fVyU8AKRFZc6iyXPQkfc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter xkNtZ4KRM5eQTZbNn70a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GkuohdKRRPfPho7oi5oO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kO5UI9KRWtFEnTfAIqnV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public CvsCellLocation cellLoc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass63_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q21uS9KRH4VLlMfOJ9ES();
			OqwW9FKRxfa8inBhUyMb(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindCellVm_003Eb__1(CellViewModel cellVm)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ra0mR5KRmyEUh2BK7LMZ(cellVm) == cellLoc;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q21uS9KRH4VLlMfOJ9ES()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OqwW9FKRxfa8inBhUyMb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lO7nw6KRYKu6oyOmYO1a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xySwGtKRUloh1PNI90Gj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation ra0mR5KRmyEUh2BK7LMZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteCellsAsync_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

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
			TaskAwaiter awaiter = default;
			MathTool mathTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							goto IL_00b4;
						}
						if (mathTool.JOvQBNw5eC())
						{
							num3 = 2;
							goto IL_00b4;
						}
						goto end_IL_0029;
						IL_00b4:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 3:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 2:
								awaiter = ((Task)lWIfOoKR1UxODvRv5rlP(YA7JRNKR2sXdWeFvw1sL(mathTool.InSight), new MathToolDeleteCellsUndoAction(mathTool.Parent, (string)evkvkrKRckwD6gGaJ1iG(mathTool), mathTool.SelectedVirtualRange))).GetAwaiter();
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								jBmMVRKRQoVPRwOeb2rY();
								num3 = (Aka7D4KRNJ1PYaV4NcmM() ? 6 : 5);
								continue;
							case 4:
								_003C_003Eu__1 = default;
								goto case 6;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 4:
					mathTool = _003C_003E4__this;
					_ = 1;
					num = (Aka7D4KRNJ1PYaV4NcmM() ? 1 : 5);
					continue;
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
		internal static object YA7JRNKR2sXdWeFvw1sL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object evkvkrKRckwD6gGaJ1iG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lWIfOoKR1UxODvRv5rlP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jBmMVRKRQoVPRwOeb2rY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Aka7D4KRNJ1PYaV4NcmM()
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
	private struct _003CCutCellsAsync_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eD5J8lKRuoy2VCGdonkn();
			int num;
			if (!BYJ3piKRhfacwms29gGM())
			{
				num = 3;
				if (BYJ3piKRhfacwms29gGM())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_022f;
			IL_002e:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_022f;
			IL_022f:
			MathTool mathTool = default;
			TaskAwaiter<byte[]> awaiter = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
					mathTool = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_00fe;
						}
						int num3;
						if (mathTool.VQ9Qn8b96Z())
						{
							num3 = 10;
							if (false)
							{
								goto IL_0088;
							}
							goto IL_00bb;
						}
						goto end_IL_006b;
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 0:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 9;
								continue;
							case 3:
							case 6:
								goto IL_00fe;
							case 9:
								return;
							case 11:
								mathTool.fpsgyvYO9O = result;
								num3 = 12;
								if (BYJ3piKRhfacwms29gGM())
								{
								}
								continue;
							case 8:
								mathTool.JAbg2HGBg4 = CvsCellRange.Invalid;
								num3 = 5;
								continue;
							case 10:
								mathTool.VBMge6OXv9 = null;
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								result = awaiter.GetResult();
								num3 = 11;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_ = 1;
									if (BYJ3piKRhfacwms29gGM())
									{
										num3 = 3;
										if (eD5J8lKRuoy2VCGdonkn())
										{
											continue;
										}
										goto case 11;
									}
									num3 = 0;
									continue;
								}
								goto case 2;
							case 5:
								awaiter = ((CvsCogSocketSheet)n3XgokKRtDbb9XufbMS2(mathTool.InSight.CogSocket)).CopyCellsAsync(mathTool.SelectedSheetRange).GetAwaiter();
								num3 = 7;
								continue;
							case 12:
								mathTool.HH0gx1FILw = mathTool.SelectedSheetRange;
								goto end_IL_006b;
							}
							break;
						}
						goto IL_0088;
						IL_0088:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						goto IL_00bb;
						IL_00fe:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00bb;
						end_IL_006b:;
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
					if (!BYJ3piKRhfacwms29gGM())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static object n3XgokKRtDbb9XufbMS2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eD5J8lKRuoy2VCGdonkn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BYJ3piKRhfacwms29gGM()
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
	private struct _003CCopyCellsAsync_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

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
			TaskAwaiter<byte[]> awaiter = default;
			MathTool mathTool = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_0147;
						}
						int num3;
						if (mathTool.GcAQYWFs8N())
						{
							num3 = 9;
							goto IL_006f;
						}
						goto end_IL_002d;
						IL_006f:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								num3 = ((!hRFktHKRzDHcAaQUduTl()) ? 1 : 3);
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (hRFktHKRzDHcAaQUduTl())
								{
									continue;
								}
								return;
							case 3:
							case 5:
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 2;
							case 2:
								result = awaiter.GetResult();
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								mathTool.fpsgyvYO9O = null;
								num3 = 0;
								if (!SWAwCGKWL108WO8Y6qtN())
								{
									continue;
								}
								goto case 11;
							case 11:
								mathTool.VBMge6OXv9 = result;
								num3 = 12;
								if (true)
								{
									continue;
								}
								break;
							case 1:
							case 6:
								break;
							case 0:
								mathTool.HH0gx1FILw = CvsCellRange.Invalid;
								awaiter = ((CvsCogSocketSheet)u0ldfdKW5Z3wrYqgOOma(Rx4QrFKWK1Qu9NBPRGDK(mathTool.InSight))).CopyCellsAsync(mathTool.SelectedSheetRange).GetAwaiter();
								num3 = 7;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 12:
								mathTool.JAbg2HGBg4 = mathTool.SelectedSheetRange;
								goto end_IL_006f;
							}
							goto IL_0147;
							continue;
							end_IL_006f:
							break;
						}
						goto end_IL_002d;
						IL_0147:
						_003C_003Eu__1 = default;
						num3 = 10;
						goto IL_006f;
						end_IL_002d:;
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
				case 4:
					num2 = _003C_003E1__state;
					SWAwCGKWL108WO8Y6qtN();
					if (hRFktHKRzDHcAaQUduTl())
					{
						num = 0;
						if (hRFktHKRzDHcAaQUduTl())
						{
							break;
						}
						goto case 0;
					}
					num = 3;
					if (SWAwCGKWL108WO8Y6qtN())
					{
						return;
					}
					break;
				case 0:
				case 1:
					mathTool = _003C_003E4__this;
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
		internal static object Rx4QrFKWK1Qu9NBPRGDK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u0ldfdKW5Z3wrYqgOOma(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hRFktHKRzDHcAaQUduTl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SWAwCGKWL108WO8Y6qtN()
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
	private struct _003CPasteCellsAsync_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pc1Oh8KWw8VlBtlI9nV2();
			int num;
			if (!y2dr5AKWJ0yAAXolv90m())
			{
				num = 5;
				if (y2dr5AKWJ0yAAXolv90m())
				{
				}
			}
			else
			{
				num = 2;
				if (y2dr5AKWJ0yAAXolv90m())
				{
					goto IL_034e;
				}
			}
			goto IL_0317;
			IL_0317:
			MathTool mathTool = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCellRange virtualSourceCellRange = default;
			byte[] pasteCells = default;
			CvsCellRange selectedVirtualRange = default;
			bool cut = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					mathTool = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 16;
							if (y2dr5AKWJ0yAAXolv90m())
							{
							}
							goto IL_0174;
						}
						if (mathTool.qF2QVvKfmd())
						{
							num3 = 0;
							goto IL_0174;
						}
						goto end_IL_0054;
						IL_0174:
						while (true)
						{
							switch (num3)
							{
							case 6:
								awaiter = fip2pnKWIylJvIiWbpGn(RXFBXRKWOdqXla3RZgMw(eosL1qKWebRlDr8Fxnkd(mathTool.InSight), new MathToolPasteCellsUndoAction(mathTool.Parent, mathTool.Name, virtualSourceCellRange, pasteCells, selectedVirtualRange, cut)));
								if (!awaiter.IsCompleted)
								{
									num3 = 17;
									continue;
								}
								break;
							case 0:
								selectedVirtualRange = mathTool.SelectedVirtualRange;
								num3 = 9;
								continue;
							case 12:
								selectedVirtualRange.Rows = virtualSourceCellRange.Rows;
								num3 = 19;
								continue;
							case 18:
								cut = false;
								if (mathTool.VBMge6OXv9 != null)
								{
									num3 = 1;
									continue;
								}
								if (mathTool.fpsgyvYO9O != null)
								{
									virtualSourceCellRange = gNNl7SKWaSAcg2UVbAue(mathTool.HH0gx1FILw, mathTool.C3egSP8j5X);
									num3 = 15;
									continue;
								}
								goto case 4;
							case 19:
								selectedVirtualRange.Columns = virtualSourceCellRange.Columns;
								num3 = 6;
								continue;
							case 17:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 1:
								virtualSourceCellRange = gNNl7SKWaSAcg2UVbAue(mathTool.JAbg2HGBg4, mathTool.C3egSP8j5X);
								pasteCells = mathTool.VBMge6OXv9;
								cut = false;
								pc1Oh8KWw8VlBtlI9nV2();
								if (!y2dr5AKWJ0yAAXolv90m())
								{
									num3 = 7;
									continue;
								}
								num3 = 4;
								if (pc1Oh8KWw8VlBtlI9nV2())
								{
									continue;
								}
								goto case 4;
							case 4:
							case 5:
							case 7:
							case 8:
								if (virtualSourceCellRange.IsValid)
								{
									goto case 12;
								}
								goto end_IL_0174;
							default:
								num3 = 12;
								continue;
							case 9:
								virtualSourceCellRange = CvsCellRange.Invalid;
								num3 = 13;
								if (pc1Oh8KWw8VlBtlI9nV2())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (!y2dr5AKWJ0yAAXolv90m())
								{
									continue;
								}
								goto case 11;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 15;
							case 15:
								pasteCells = mathTool.fpsgyvYO9O;
								num3 = 14;
								if (pc1Oh8KWw8VlBtlI9nV2())
								{
									continue;
								}
								return;
							case 2:
								return;
							case 14:
								cut = true;
								goto case 4;
							case 13:
								pasteCells = null;
								num3 = 18;
								continue;
							case 16:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 20:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0174:
							break;
						}
						end_IL_0054:;
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
			goto IL_034e;
			IL_034e:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!pc1Oh8KWw8VlBtlI9nV2())
			{
				return;
			}
			goto IL_0317;
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
		internal static CvsCellRange gNNl7SKWaSAcg2UVbAue(CvsCellRange actualCellRange, CvsCellRange sheetRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetVirtualCellRange(actualCellRange, sheetRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eosL1qKWebRlDr8Fxnkd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RXFBXRKWOdqXla3RZgMw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter fip2pnKWIylJvIiWbpGn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pc1Oh8KWw8VlBtlI9nV2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y2dr5AKWJ0yAAXolv90m()
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
	private struct _003C_expressionViewModel_AcceptChanges_003Ed__107 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

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
			EzOperandCollection namedOperands = default;
			MathTool mathTool = default;
			TaskAwaiter awaiter = default;
			CvsParse cvsParse = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (nWflNiKWDV4AkqKXZFrW())
					{
						num = 5;
						break;
					}
					num = 3;
					if (!Y42YtiKWirlWymQuCuK7())
					{
						break;
					}
					return;
				case 2:
				case 3:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								namedOperands = mathTool.g6cQiZcckd();
								num3 = 1;
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
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
								case 8:
									awaiter = i6VKIMKWlRAEFZ2h8Odd(mathTool.P16QhE0acS(cvsParse));
									goto case 3;
								case 0:
									_003C_003Eu__1 = default;
									num3 = 4;
									continue;
								case 3:
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									break;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 7;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 0);
									goto case 6;
								default:
									num3 = 6;
									continue;
								case 5:
									if (cvsParse.IsWellFormed)
									{
										_ = 0;
										num3 = (nWflNiKWDV4AkqKXZFrW() ? 8 : 10);
										continue;
									}
									goto end_IL_0115;
								case 1:
									cvsParse = CvsParse.Parse((CvsFunctionTable)INIX1bKWn42FHd9WXQf7(mathTool.InSight), (IExpressionConstants)OLM8BJKWVNQqf3jIyTlM(mathTool.InSight), mathTool.xJugoFUm9e.Expression, ypZcTbKWdHNcWPqBFOtx(MlBX2SKWfnxf8mIimOtc(mathTool.xJugoFUm9e)), null, -1, namedOperands, mathTool.PfZgfxJ24d.IsValidFunction);
									num3 = 5;
									if (nWflNiKWDV4AkqKXZFrW())
									{
										continue;
									}
									break;
								case 11:
									break;
								}
								awaiter.GetResult();
								break;
								continue;
								end_IL_0115:
								break;
							}
						}
						catch (Exception ex)
						{
							d7Nup5KWsGWJrum5cxWm(UZvgX4gWcU, JZRvwlKWgdbHrwwuhZwc(ex), ex);
						}
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
					if (!Y42YtiKWirlWymQuCuK7())
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					mathTool = _003C_003E4__this;
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
		internal static object INIX1bKWn42FHd9WXQf7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OLM8BJKWVNQqf3jIyTlM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MlBX2SKWfnxf8mIimOtc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ExpressionTextBoxViewModel)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ypZcTbKWdHNcWPqBFOtx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter i6VKIMKWlRAEFZ2h8Odd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JZRvwlKWgdbHrwwuhZwc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d7Nup5KWsGWJrum5cxWm(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nWflNiKWDV4AkqKXZFrW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y42YtiKWirlWymQuCuK7()
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
	private struct _003CWriteCellExpressionAsync_003Ed__110 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		public CvsParse parseInfo;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LOta5wKWv69Xusv30O8O();
			int num = (UsYqTAKWrqlP2ej7U2OI() ? 5 : 3);
			int num2 = default;
			MathTool mathTool = default;
			IUndoAction undoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					mathTool = _003C_003E4__this;
					num = 2;
					if (LOta5wKWv69Xusv30O8O())
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								undoAction = mathTool.A5tQrXQV2T(parseInfo, mathTool.xJugoFUm9e.Expression);
								num3 = 2;
								goto IL_015a;
							}
							awaiter = _003C_003Eu__1;
							goto IL_00fa;
							IL_01ba:
							num2 = (_003C_003E1__state = -1);
							num3 = 1;
							goto IL_015a;
							IL_00fa:
							_003C_003Eu__1 = default;
							goto IL_01ba;
							IL_015a:
							while (true)
							{
								switch (num3)
								{
								case 9:
									break;
								case 2:
									awaiter = h81df6KWBWdJcbUvqY00(oe5iPIKWZ96abEPM9Ux9(YqPd93KWPF3BUrXbbDa5(mathTool.InSight), undoAction));
									num3 = 4;
									continue;
								case 1:
									awaiter.GetResult();
									num3 = 9;
									continue;
								case 3:
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 10;
									continue;
								case 8:
									goto end_IL_015a;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto case 1;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									if (!LOta5wKWv69Xusv30O8O())
									{
										num3 = 5;
										if (true)
										{
											continue;
										}
										goto case 4;
									}
									num3 = 7;
									continue;
								case 5:
								case 6:
									goto IL_01ba;
								case 11:
									goto end_IL_006e;
								}
								EventHandler eventHandler = mathTool.hXagim4wBj;
								if (eventHandler == null)
								{
									num3 = 11;
									if (UsYqTAKWrqlP2ej7U2OI())
									{
									}
									continue;
								}
								NFKehSKWbbiLGvsyRQRe(eventHandler, mathTool, EventArgs.Empty);
								goto end_IL_006e;
								continue;
								end_IL_015a:
								break;
							}
							goto IL_00fa;
							end_IL_006e:;
						}
						catch (Exception)
						{
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
		internal static object YqPd93KWPF3BUrXbbDa5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oe5iPIKWZ96abEPM9Ux9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter h81df6KWBWdJcbUvqY00(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NFKehSKWbbiLGvsyRQRe(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LOta5wKWv69Xusv30O8O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UsYqTAKWrqlP2ej7U2OI()
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__125 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MathTool _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private CvsCellLocation _003Cloc_003E5__2;

		private int _003Cr_003E5__3;

		private int _003Cc_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!PpF3isKWoUsT6dfAIh4W())
			{
				num = 5;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0476;
			IL_04b2:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0476;
			IL_0476:
			MathTool mathTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 4:
					mathTool = _003C_003E4__this;
					num = 2;
					continue;
				case 3:
					goto IL_04b2;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					_003Cloc_003E5__2 = CvsCellLocation.Invalid;
					num3 = 11;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 10;
					if (false)
					{
						goto IL_040a;
					}
				}
				goto IL_01e7;
				IL_040a:
				_003Cr_003E5__3 = mathTool.C3egSP8j5X.Row;
				num3 = 24;
				goto IL_01e7;
				IL_01e7:
				string text = default;
				string text2 = default;
				CvsCellRange cvsCellRange = default;
				int num5 = default;
				CvsCell cvsCell = default;
				CellRefRange cellRefRange = default;
				bool flag = default;
				int num4 = default;
				CvsParse cvsParse = default;
				while (true)
				{
					switch (num3)
					{
					case 27:
						_003C_003Eu__1 = awaiter;
						num3 = 21;
						continue;
					case 15:
					{
						string newExpression = mathTool.QYKQ8jpE7K(text);
						string oldExpression = mathTool.QYKQ8jpE7K(text2);
						MathToolExpressionUndoAction action = new MathToolExpressionUndoAction(mathTool.Parent, (string)VmP78DKWA5qK4dhZWMNu(mathTool), otKErxKWRB4kCFvxLkrB(_003Cloc_003E5__2, mathTool.C3egSP8j5X), newExpression, oldExpression);
						awaiter = e.AddUndo(action).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							continue;
						}
						goto case 19;
					}
					case 3:
					case 16:
						if (_003Cc_003E5__4 > mathTool.C3egSP8j5X.LastColumn)
						{
							num3 = 9;
							continue;
						}
						_003Cloc_003E5__2.Column = _003Cc_003E5__4;
						num3 = 17;
						continue;
					case 23:
						if (!cvsCellRange.IsEmpty)
						{
							num3 = 12;
							continue;
						}
						goto IL_0328;
					case 8:
					case 22:
						_003Cc_003E5__4 = num5 + 1;
						num3 = 3;
						continue;
					case 17:
						cvsCell = (CvsCell)sQmURcKWkVCenkPxflX2(IGPRxmKWS4cYicGj1gUj(e), _003Cloc_003E5__2);
						num3 = 6;
						continue;
					case 14:
						cvsCellRange = vLFbU0KW7Bv2xYMqeNg2(aVE2cdKW9MNV8sXoCAIU(fSv4uFKWX2HXC8hkqSPH(e)), JK5JK5KW4YeAoaxYJGao(cellRefRange));
						num3 = 23;
						continue;
					case 18:
						_003Cr_003E5__3 = num5 + 1;
						num3 = 28;
						continue;
					case 12:
						text = (string)Xcuir7KWC0amPFGGtJF1(text.Substring(0, cellRefRange.TextStart), Jh4px9KW3KnAg7yY6cg6(mathTool.MissingProperty).ToString(absoluteRow: true, absoluteColumn: true), Vpc6e8KW6DT3USS2a6m2(text, I0AAZaKWj5O1h4oBdUwh(cellRefRange)));
						goto case 13;
					default:
						num3 = 13;
						continue;
					case 5:
					case 7:
						flag = false;
						num3 = 20;
						continue;
					case 0:
					case 25:
						if (num4 >= 0)
						{
							cellRefRange = (CellRefRange)((object[])N5gJrqKWpPcibM70eqqw(cvsParse))[num4];
							num3 = 14;
							continue;
						}
						if (flag)
						{
							num3 = 15;
							continue;
						}
						goto IL_03bf;
					case 1:
						num2 = (_003C_003E1__state = 0);
						num3 = 27;
						continue;
					case 26:
						num4 = ((Array)N5gJrqKWpPcibM70eqqw(cvsParse)).Length - 1;
						num3 = 0;
						continue;
					case 9:
						num5 = _003Cr_003E5__3;
						num3 = 18;
						if (!PpF3isKWoUsT6dfAIh4W())
						{
							continue;
						}
						goto case 10;
					case 10:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 19;
						continue;
					case 13:
						flag = true;
						goto IL_0328;
					case 20:
						text2 = (string)PQiaULKW8J16RE3Cp2H5(cvsCell);
						text = text2;
						num3 = 2;
						if (PpF3isKWoUsT6dfAIh4W())
						{
						}
						continue;
					case 2:
						cvsParse = CvsParse.Parse(mathTool.InSight.FunctionTable, (IExpressionConstants)u9Pj4TKWq0qfAH1oIbNm(mathTool.InSight), text, l37mh6KWEuTumaxRSEAg(cvsCell.Expression));
						num3 = 26;
						if (!PpF3isKWoUsT6dfAIh4W())
						{
							continue;
						}
						goto case 6;
					case 6:
						if (cvsCell == null)
						{
							goto IL_03bf;
						}
						MtjQIcKWG7u8eIjQ9xAE();
						if (!PpF3isKWoUsT6dfAIh4W())
						{
							num3 = 7;
							if (true)
							{
								continue;
							}
							goto case 19;
						}
						num3 = 8;
						if (true)
						{
							continue;
						}
						goto case 21;
					case 19:
						awaiter.GetResult();
						goto IL_03bf;
					case 21:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						continue;
					case 4:
						return;
					case 11:
						break;
					case 24:
					case 28:
						{
							if (_003Cr_003E5__3 <= mathTool.C3egSP8j5X.LastRow)
							{
								_003Cloc_003E5__2.Row = _003Cr_003E5__3;
								_003Cc_003E5__4 = mathTool.C3egSP8j5X.Column;
								num3 = 16;
								if (MtjQIcKWG7u8eIjQ9xAE())
								{
									continue;
								}
								goto case 9;
							}
							goto end_IL_01e7;
						}
						IL_0328:
						num4--;
						num3 = 25;
						continue;
						IL_03bf:
						num5 = _003Cc_003E5__4;
						goto case 8;
					}
					goto IL_040a;
					continue;
					end_IL_01e7:
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
			goto IL_04b2;
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
		internal static object IGPRxmKWS4cYicGj1gUj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sQmURcKWkVCenkPxflX2(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PQiaULKW8J16RE3Cp2H5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u9Pj4TKWq0qfAH1oIbNm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int l37mh6KWEuTumaxRSEAg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N5gJrqKWpPcibM70eqqw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CellReferences;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fSv4uFKWX2HXC8hkqSPH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange aVE2cdKW9MNV8sXoCAIU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange JK5JK5KW4YeAoaxYJGao(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange vLFbU0KW7Bv2xYMqeNg2(CvsCellRange P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellRange.Intersect(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation Jh4px9KW3KnAg7yY6cg6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int I0AAZaKWj5O1h4oBdUwh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellRefRange)P_0).TextEnd;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vpc6e8KW6DT3USS2a6m2(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xcuir7KWC0amPFGGtJF1(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VmP78DKWA5qK4dhZWMNu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation otKErxKWRB4kCFvxLkrB(CvsCellLocation actualCellLocation, CvsCellRange sheetRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetVirtualCellLocation(actualCellLocation, sheetRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MtjQIcKWG7u8eIjQ9xAE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PpF3isKWoUsT6dfAIh4W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger UZvgX4gWcU;

	private ExpressionTextBoxViewModel xJugoFUm9e;

	private CvsCellRange C3egSP8j5X;

	private CvsCellRange QhygDSE15X;

	private CvsCellLocation Gokg3FTjlw;

	private CvsCellLocation OdxgIs1tfL;

	private readonly MathToolFunctionValidation PfZgfxJ24d;

	private readonly List<string> d1QgELAJft;

	private static readonly string zhbgbtWmWw;

	private static bool efqgchsoto;

	private string[] dCGgQjO9F8;

	private string VKuggvA3uf;

	[CompilerGenerated]
	private EditPointViewModel lwygMgaE8X;

	[CompilerGenerated]
	private StringViewModel noRgRVRJwT;

	private List<MiniSheetRow> KMAg4cWjOa;

	private CvsCellLocation tVyglHQmnL;

	private EmptyCellViewModel AK7gTGQicv;

	private CvsCellLocation wXIgWk37S0;

	private bool xiGgjaXSjS;

	private CvsCellRange YAcgC4vuqN;

	private CvsCellRange c4agOIKIVa;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand rVggH1GX5Z;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand XB6gwGnuNh;

	private byte[] fpsgyvYO9O;

	private CvsCellRange HH0gx1FILw;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand RcPgvgn6ui;

	private byte[] VBMge6OXv9;

	private CvsCellRange JAbg2HGBg4;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand Wu8gqe5Bbw;

	[CompilerGenerated]
	private EventHandler hXagim4wBj;

	public override bool ShowHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return efqgchsoto;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref efqgchsoto, value, (string)GRop46pssAn5jiRLwK2(6502));
		}
	}

	public string[] VirtualFloatCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dCGgQjO9F8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref dCGgQjO9F8, value, (string)GRop46pssAn5jiRLwK2(21750));
		}
	}

	public string VirtualPassCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0038;
			IL_0038:
			CvsCellLocation actualCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
					goto IL_0065;
				default:
					goto IL_008d;
				case 5:
					goto IL_00a5;
				}
				break;
				IL_0065:
				actualCellLocation = CvsCellLocation.TryParse(PassCell);
				qa8sqopVDLk4iwX8JJp();
				if (olCYdvpfKakK9EldPKl())
				{
					num = 3;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto IL_008d;
			}
			goto IL_001a;
			IL_00a5:
			CvsCellLocation virtualCellLocation = default;
			return virtualCellLocation.ToString();
			IL_008d:
			virtualCellLocation = GetVirtualCellLocation(actualCellLocation);
			num = 5;
			if (qa8sqopVDLk4iwX8JJp())
			{
				goto IL_0038;
			}
			goto IL_00a5;
			IL_001a:
			if (actualCellLocation.IsValid)
			{
				goto IL_008d;
			}
			return zhbgbtWmWw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCellLocation virtualCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					if (value == null)
					{
						_ = 1;
						num = (olCYdvpfKakK9EldPKl() ? 4 : 0);
						continue;
					}
					virtualCellLocation = n3nbRupvoRytg2D9gF8(value);
					goto case 2;
				case 0:
				case 1:
					return;
				case 2:
				case 4:
					if (virtualCellLocation.IsValid)
					{
						break;
					}
					PassCell = zhbgbtWmWw;
					num = 7;
					continue;
				default:
					num = 6;
					continue;
				case 3:
					return;
				case 6:
					break;
				case 7:
					return;
				}
				PassCell = GetActualCellLocation(virtualCellLocation).ToString();
				num = 3;
			}
		}
	}

	private string PassCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VKuggvA3uf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 9;
			string text = default;
			CvsCell cvsCell = default;
			CvsCellLocation cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					((CvsCogSocketSheet)TU0wSDpBqQiYdOC9duS(kHh7l4pZxaak2ePHSMX(InSight))).PutCellExpressionAndRunSheet(OdxgIs1tfL, text);
					num = 8;
					if (!olCYdvpfKakK9EldPKl())
					{
						break;
					}
					goto case 10;
				case 10:
					if (value != zhbgbtWmWw)
					{
						num = 0;
						break;
					}
					goto IL_00b6;
				case 8:
					zNcyInpbiJnotASDBCn(this, GRop46pssAn5jiRLwK2(21808));
					num = 11;
					if (qa8sqopVDLk4iwX8JJp())
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					cvsCell = ((CvsCellCollection)n5Z2mFprptXTxv4pW4Z(InSight.Results))[OdxgIs1tfL];
					if (cvsCell == null)
					{
						goto case 8;
					}
					goto case 3;
				case 0:
					throw new ArgumentException();
				case 4:
					if (!OdxgIs1tfL.IsValid)
					{
						goto case 8;
					}
					goto default;
				default:
					_ = 0;
					num = (qa8sqopVDLk4iwX8JJp() ? 1 : 3);
					break;
				case 9:
					cvsCellLocation = CvsCellLocation.TryParse(value);
					num = 2;
					break;
				case 3:
				case 6:
				{
					object obj = vlo9VQpPk37OXlWiKUi(cvsCell);
					text = (string)(cvsCellLocation.IsValid ? VKuggvA3uf : GRop46pssAn5jiRLwK2(21668));
					if ((string)obj != text)
					{
						num = 7;
						break;
					}
					goto case 8;
				}
				case 2:
					if (!cvsCellLocation.IsValid)
					{
						num = 10;
						if (!qa8sqopVDLk4iwX8JJp())
						{
							return;
						}
						break;
					}
					goto IL_00b6;
				case 11:
					return;
					IL_00b6:
					if (SetField(ref VKuggvA3uf, value, (string)GRop46pssAn5jiRLwK2(21788)))
					{
						num = 4;
						break;
					}
					return;
				}
			}
		}
	}

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_SheetIcon;
		}
	}

	public EditPointViewModel Point
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lwygMgaE8X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lwygMgaE8X = value;
		}
	}

	public StringViewModel MissingProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return noRgRVRJwT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			noRgRVRJwT = value;
		}
	}

	public List<MiniSheetRow> MiniSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KMAg4cWjOa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref KMAg4cWjOa, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21948));
		}
	}

	public CvsCellLocation CurrentVirtualCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tVyglHQmnL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCellLocation cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					cvsCellLocation = tVyglHQmnL;
					_ = 0;
					num = ((!qa8sqopVDLk4iwX8JJp()) ? 12 : 11);
					break;
				case 10:
				case 12:
					AK7gTGQicv.SourcePropertyChanged += e7AQPw7575;
					num = 7;
					break;
				case 13:
					AK7gTGQicv.SourcePropertyChanged -= e7AQPw7575;
					goto case 0;
				default:
					num = 0;
					break;
				case 7:
					XRloAJpmjfCcVNBfla5(MiniSheet[tVyglHQmnL.Row], tVyglHQmnL.Column, AK7gTGQicv);
					num = 14;
					break;
				case 3:
					if (MiniSheet[cvsCellLocation.Row].GetColumn(cvsCellLocation.Column) is EmptyCellViewModel)
					{
						num = 2;
						if (olCYdvpfKakK9EldPKl())
						{
						}
						break;
					}
					goto case 6;
				case 2:
					XRloAJpmjfCcVNBfla5(MiniSheet[cvsCellLocation.Row], cvsCellLocation.Column, null);
					num = 6;
					break;
				case 6:
					if (AK7gTGQicv != null)
					{
						num = 13;
						break;
					}
					goto case 0;
				case 9:
					if (!cvsCellLocation.IsValid)
					{
						goto case 6;
					}
					num = 3;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					if (tVyglHQmnL.IsValid && PMWbkdpQ9ciBTmrwodN(MiniSheet[tVyglHQmnL.Row], tVyglHQmnL.Column) == null)
					{
						num = 8;
						break;
					}
					return;
				case 1:
				case 11:
					if (SetField(ref tVyglHQmnL, value, (string)GRop46pssAn5jiRLwK2(21970)))
					{
						num = 9;
						if (qa8sqopVDLk4iwX8JJp())
						{
							break;
						}
						goto case 0;
					}
					return;
				case 0:
					CurrentSheetCellLocation = GetActualCellLocation(tVyglHQmnL);
					num = 4;
					break;
				case 8:
					AK7gTGQicv = new EmptyCellViewModel();
					SetCellLocationAsVirtualDependency(AK7gTGQicv);
					goto case 10;
				case 14:
					return;
				}
			}
		}
	}

	public CvsCellLocation CurrentSheetCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wXIgWk37S0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			CvsCell cvsCell = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (SetField(ref wXIgWk37S0, value, (string)GRop46pssAn5jiRLwK2(22026)))
					{
						num = 9;
						break;
					}
					return;
				case 0:
					IsCurrentCellBoundExternally = false;
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					if (cvsCell != null)
					{
						num = 1;
						break;
					}
					if (xJugoFUm9e == null)
					{
						goto case 0;
					}
					goto case 2;
				case 1:
					if (xJugoFUm9e != null)
					{
						_ = 0;
						num = ((!qa8sqopVDLk4iwX8JJp()) ? 2 : 8);
						break;
					}
					goto case 3;
				case 3:
					IsCurrentCellBoundExternally = di2QK5IlRF(wXIgWk37S0)?.IsBoundExternally ?? false;
					return;
				case 2:
				case 6:
					xJugoFUm9e.Expression = string.Empty;
					num = 0;
					if (!olCYdvpfKakK9EldPKl())
					{
						break;
					}
					goto case 9;
				case 9:
					cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(n5Z2mFprptXTxv4pW4Z(S2xy7fpNr5SKvJsaRF2(InSight)), wXIgWk37S0);
					num = 5;
					break;
				case 4:
				case 8:
					xJugoFUm9e.Expression = QYKQ8jpE7K((string)vlo9VQpPk37OXlWiKUi(cvsCell));
					goto case 3;
				default:
					num = 3;
					break;
				case 10:
					return;
				}
			}
		}
	}

	public bool IsCurrentCellBoundExternally
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xiGgjaXSjS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref xiGgjaXSjS, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(22078));
		}
	}

	public CvsCellRange SelectedVirtualRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YAcgC4vuqN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref YAcgC4vuqN, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(22138)))
			{
				SelectedSheetRange = GetActualCellRange(YAcgC4vuqN);
			}
		}
	}

	public CvsCellRange SelectedSheetRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c4agOIKIVa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref c4agOIKIVa, value, (string)GRop46pssAn5jiRLwK2(22182));
		}
	}

	public AsyncDelegateCommand DeleteCellsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rVggH1GX5Z;
		}
	}

	public AsyncDelegateCommand CutCellsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XB6gwGnuNh;
		}
	}

	public AsyncDelegateCommand CopyCellsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RcPgvgn6ui;
		}
	}

	public AsyncDelegateCommand PasteCellsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Wu8gqe5Bbw;
		}
	}

	public ExpressionTextBoxViewModel ExpressionTextBoxViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!qa8sqopVDLk4iwX8JJp()) ? 3 : 2);
			EzOperandCollection tagMap = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					xJugoFUm9e = new ExpressionTextBoxViewModel(InSight.FunctionTable, new ExpressionConstants(8, 8, Fl5kmdpcSpTdE7QHgo6(HHwqmKp2E0TkrGsGGgf(InSight.Sensor))), tagMap);
					num = 4;
					continue;
				case 1:
				case 3:
					tagMap = g6cQiZcckd();
					num = 7;
					continue;
				case 0:
				case 2:
					if (xJugoFUm9e != null)
					{
						break;
					}
					goto case 1;
				case 4:
					xJugoFUm9e.IsValidFunction = PfZgfxJ24d.IsValidFunction;
					goto case 6;
				default:
					num = 6;
					continue;
				case 5:
					xJugoFUm9e.RejectChanges += X0XQ95atkr;
					num = 8;
					continue;
				case 6:
					xJugoFUm9e.AcceptChanges += OxUQJl4Zok;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					break;
				}
				break;
			}
			return xJugoFUm9e;
		}
	}

	public event EventHandler ExpressionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!olCYdvpfKakK9EldPKl())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_005d;
			IL_0026:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = Interlocked.CompareExchange(ref hXagim4wBj, value2, eventHandler2);
			num = 5;
			goto IL_005d;
			IL_005d:
			while (true)
			{
				switch (num)
				{
				case 1:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					break;
				case 0:
				case 4:
					eventHandler = hXagim4wBj;
					num = 6;
					continue;
				case 6:
					eventHandler2 = eventHandler;
					num = 1;
					if (qa8sqopVDLk4iwX8JJp())
					{
						continue;
					}
					goto case 5;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (olCYdvpfKakK9EldPKl())
						{
						}
						continue;
					}
					goto case 6;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qa8sqopVDLk4iwX8JJp())
			{
				num = 2;
			}
			else
			{
				num = 6;
				if (olCYdvpfKakK9EldPKl())
				{
				}
			}
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			do
			{
				IL_0043:
				switch (num)
				{
				case 4:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					break;
				default:
					num = 5;
					goto IL_0043;
				case 0:
				case 2:
					eventHandler = hXagim4wBj;
					goto case 1;
				case 3:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (qa8sqopVDLk4iwX8JJp())
						{
							goto IL_0043;
						}
					}
					goto case 1;
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					num = 4;
					if (olCYdvpfKakK9EldPKl())
					{
					}
					goto IL_0043;
				case 5:
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref hXagim4wBj, value2, eventHandler2);
				num = 3;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MathTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 1:
				RcPgvgn6ui = new AsyncDelegateCommand(d4lQ0nuFtS, GcAQYWFs8N);
				num = 3;
				break;
			case 6:
				PropertyFilterPredicate = [MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					qa8sqopVDLk4iwX8JJp();
					int num2;
					if (!olCYdvpfKakK9EldPKl())
					{
						num2 = 4;
						if (1 == 0)
						{
							goto IL_002a;
						}
					}
					else
					{
						num2 = 2;
						if (olCYdvpfKakK9EldPKl())
						{
						}
					}
					goto IL_0069;
					IL_004b:
					CvsCellLocation cvsCellLocation = default;
					if (cvsCellLocation.IsValid)
					{
						goto IL_0090;
					}
					goto IL_00cb;
					IL_00b2:
					return !mil38nXIAcBJcUWRkOk(LTQiGtXodQ1GTPZDlG5(P_0), CdQUGaROfy7He9T0foW.KbIzwHEDLa(22292));
					IL_0090:
					if (!C3egSP8j5X.Contains(MX1j1NpXKlQJokmvqXJ(P_0)))
					{
						num2 = 5;
						if (true)
						{
							goto IL_0069;
						}
						goto IL_00b2;
					}
					goto IL_00cb;
					IL_0069:
					while (true)
					{
						switch (num2)
						{
						case 0:
						case 4:
							break;
						case 1:
						case 2:
							goto IL_004b;
						default:
							num2 = 3;
							continue;
						case 3:
							goto IL_0090;
						case 5:
							goto IL_00b2;
						}
						break;
					}
					goto IL_002a;
					IL_00cb:
					return false;
					IL_002a:
					cvsCellLocation = MX1j1NpXKlQJokmvqXJ(P_0);
					goto IL_004b;
				};
				num = 4;
				break;
			case 4:
				d1QgELAJft.Add(zhbgbtWmWw);
				num = 0;
				break;
			case 3:
				XB6gwGnuNh = new AsyncDelegateCommand(sWqQtywH9r, VQ9Qn8b96Z);
				Wu8gqe5Bbw = new AsyncDelegateCommand(hRkQLqs0xI, qF2QVvKfmd);
				num = 6;
				break;
			case 10:
				XxvQeRpdsZ5IQGHjLDf();
				num = 16;
				if (!olCYdvpfKakK9EldPKl())
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				QhygDSE15X = CvsCellRange.Invalid;
				num = 15;
				break;
			case 15:
				Gokg3FTjlw = CvsCellLocation.Invalid;
				OdxgIs1tfL = CvsCellLocation.Invalid;
				d1QgELAJft = new List<string>();
				num = 12;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				KMAg4cWjOa = new List<MiniSheetRow>();
				tVyglHQmnL = CvsCellLocation.Invalid;
				num = 7;
				break;
			case 14:
				PfZgfxJ24d = new MathToolFunctionValidation((CvsFunctionTable)XajewxpgjIu7oiTKbKn(InSight));
				goto case 8;
			case 7:
				wXIgWk37S0 = CvsCellLocation.Invalid;
				num = 11;
				break;
			case 12:
				VKuggvA3uf = zhbgbtWmWw;
				num = 13;
				break;
			case 0:
				VirtualFloatCells = d1QgELAJft.ToArray();
				num = 17;
				break;
			case 8:
			case 9:
				rVggH1GX5Z = new AsyncDelegateCommand(a1WQZRIc1U, JOvQBNw5eC);
				num = 1;
				break;
			case 16:
				C3egSP8j5X = CvsCellRange.Invalid;
				_ = 1;
				if (olCYdvpfKakK9EldPKl())
				{
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 7;
				}
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				base._002Ector(inspect, isInitialized, new xvgAPk0UambZRUM2x1((ResourceManager)ebYcHSpljilearF0oFl()));
				goto case 14;
			default:
				num = 14;
				break;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal CvsCellRange TP4gdGfuAg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return C3egSP8j5X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzOperandCollection g6cQiZcckd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qa8sqopVDLk4iwX8JJp();
		int num;
		if (!olCYdvpfKakK9EldPKl())
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
		goto IL_014c;
		IL_002a:
		EzOperandCollection ezOperandCollection = new EzOperandCollection();
		num = 1;
		goto IL_014c;
		IL_014c:
		IEnumerator<IGrouping<string, CellViewModel>> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			default:
				try
				{
					while (zdOqTupopXkE2H0uoZd(enumerator))
					{
						IGrouping<string, CellViewModel> current = enumerator.Current;
						_ = 1;
						int num2;
						if (!olCYdvpfKakK9EldPKl())
						{
							num2 = 2;
							if (1 == 0)
							{
								goto IL_005e;
							}
						}
						else
						{
							num2 = 3;
						}
						switch (num2)
						{
						case 0:
						case 2:
							break;
						default:
							continue;
						}
						goto IL_005e;
						IL_005e:
						ezOperandCollection.AddRange(current.Select([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel cell) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return new EzOperand(cell);
						}));
					}
				}
				finally
				{
					if (enumerator != null)
					{
						quC4yspSMxgNVnTHTBW(enumerator);
					}
				}
				qsEfXpp8MUhtUD8lURM(ezOperandCollection, new NamedCellOperand(CdQUGaROfy7He9T0foW.KbIzwHEDLa(21842), nBu81Epku80poWd7Iss(Parent.AppViewModel)));
				num = 5;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				continue;
			case 1:
				enumerator = ((EasyBuilderApplicationViewModel)zi6Dl3pGfEUaoffJtE7(Parent)).GetSourceablePropertiesGrouped((CellViewModel)new EmptyCellViewModel(), PropertyFilterPredicate).GetEnumerator();
				goto default;
			case 5:
				return ezOperandCollection;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetActualCellLocation(CvsCellLocation virtualCellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			default:
				result.Column += C3egSP8j5X.Column;
				num = 5;
				break;
			case 1:
			case 3:
				result.Row += C3egSP8j5X.Row;
				goto default;
			case 4:
				result = virtualCellLocation;
				_ = 0;
				num = (qa8sqopVDLk4iwX8JJp() ? 3 : 0);
				break;
			case 5:
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetVirtualCellLocation(CvsCellLocation actualCellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetVirtualCellLocation(actualCellLocation, C3egSP8j5X);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellLocation GetVirtualCellLocation(CvsCellLocation actualCellLocation, CvsCellRange sheetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (olCYdvpfKakK9EldPKl() ? 2 : 3);
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				result.Row -= sheetRange.Row;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				result = actualCellLocation;
				goto case 1;
			case 4:
				result.Column -= sheetRange.Column;
				num = 5;
				break;
			case 5:
				return result;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellRange GetActualCellRange(CvsCellRange virtualCellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellRange result = virtualCellRange;
		result.Location = GetActualCellLocation(virtualCellRange.Location);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange GetVirtualCellRange(CvsCellRange actualCellRange, CvsCellRange sheetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellRange result = actualCellRange;
		result.Location = OaE5YfpqxL5XOGWFBnc(actualCellRange.Location, sheetRange);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OdxgIs1tfL = CvsCellLocation.Invalid;
		base.InternalPreParse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__37))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qa8sqopVDLk4iwX8JJp();
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0048;
			}
		}
		goto IL_007c;
		IL_00ab:
		_003CInternalPostParse_003Ed__37 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_007c;
		IL_00bd:
		stateMachine._003C_003E1__state = -1;
		num = 6;
		goto IL_007c;
		IL_007c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 6:
				goto IL_0048;
			case 5:
				goto IL_0062;
			default:
				num = 4;
				continue;
			case 1:
			case 2:
				goto IL_00ab;
			case 4:
				goto IL_00bd;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_0062:
		stateMachine.cells = cells;
		goto IL_00bd;
		IL_0048:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (false)
		{
			goto IL_0062;
		}
		goto IL_007c;
		IL_002a:
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		goto IL_00ab;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				if (!TImAxHpEDEbsXHZCPkf(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21862)))
				{
					num = 5;
					break;
				}
				Point = new EditPointViewModel(InSight, cells, loc, (string)JdtJBrppjM5mlftVLOx(), MX1j1NpXKlQJokmvqXJ(InputImage));
				AddProperty(Point);
				num = 12;
				break;
			case 13:
				PassCell = cvsCellLocation.ToString();
				num = 10;
				break;
			case 8:
				return;
			case 2:
				return;
			case 0:
				cvsCellLocation = n3nbRupvoRytg2D9gF8(vlo9VQpPk37OXlWiKUi(gAPf5ap9MgoVQhweBr8(cells, loc)));
				if (cvsCellLocation.IsValid)
				{
					num = 13;
					break;
				}
				PassCell = (string)wrcm7sp4ROt0MuSeXHl();
				num = 14;
				break;
			case 12:
				return;
			case 5:
				if (relativeCellName == (string)GRop46pssAn5jiRLwK2(21876))
				{
					MissingProperty = new StringViewModel(InSight, cells, loc, Resources.MissingProperty);
					goto case 6;
				}
				num = 1;
				break;
			case 4:
				return;
			case 6:
			case 7:
				AddProperty(MissingProperty);
				return;
			default:
				num = 4;
				break;
			case 3:
			case 11:
				if (TImAxHpEDEbsXHZCPkf(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21788)))
				{
					OdxgIs1tfL = loc;
					num = 0;
					if (false)
					{
						return;
					}
				}
				else
				{
					num = 2;
				}
				break;
			case 1:
				if (relativeCellName == (string)GRop46pssAn5jiRLwK2(21910))
				{
					Gokg3FTjlw = loc;
					num = 8;
				}
				else
				{
					_ = 1;
					num = ((!olCYdvpfKakK9EldPKl()) ? 11 : 7);
				}
				break;
			case 10:
				return;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitializeAdditionalHelp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AdditionalHelpText = new List<ExtraHelpText>
		{
			new ExtraHelpText((string)lq8M0sp7vyfSCDkmTtT(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)yAopP0p3Em1Wo03ICF1(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)LjJp3fpjG3yTnGp13S6(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)Ehfpwdp6IQ7ZJ78xl7V(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)c1hYv8pCBjFRo4FgWiu(), DisplayHelpTextType.Indented),
			new ExtraHelpText((string)z1Re25pAkwkWSslAUxw(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)a5ExCPpREPPK8WQ55xB(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText(Resources.AwG0xaVbO3(), DisplayHelpTextType.IndentedHeader),
			new ExtraHelpText(Resources.FIL0eguU8U(), DisplayHelpTextType.Indented),
			new ExtraHelpText(Resources.IZ1VNymuK7(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)adBoudpWw7C2ag5LDIM(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)uXDPH9pT2kkerc8krdv(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText(Resources.QEYV5wGXPO(), DisplayHelpTextType.IndentedHeader),
			new ExtraHelpText((string)XsJj6Tpy3jLa9VX4yD9(), DisplayHelpTextType.Indented),
			new ExtraHelpText(Resources.nOb0Zukunp(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)SbrJf8p0iJ54VQi4Ot7(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)MQ4Wu7pFP2TEOBgosEc(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)KTYfTXpMZXqCFMDqHLv(), DisplayHelpTextType.Indented)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DDXQk0EoFu(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cvsCellLocation = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 7:
				if (!cvsCellLocation.IsValid)
				{
					PassCell = (string)wrcm7sp4ROt0MuSeXHl();
					num = 9;
				}
				else
				{
					num = 8;
				}
				break;
			case 2:
			case 3:
				cvsCellLocation = n3nbRupvoRytg2D9gF8(cvsCell.Expression);
				goto case 7;
			default:
				num = 7;
				break;
			case 0:
				if (OdxgIs1tfL.IsValid)
				{
					qa8sqopVDLk4iwX8JJp();
					if (!olCYdvpfKakK9EldPKl())
					{
						num = 5;
						break;
					}
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				return;
			case 8:
				PassCell = cvsCellLocation.ToString();
				num = 6;
				break;
			case 4:
				if (cvsCell != null)
				{
					goto case 2;
				}
				return;
			case 1:
			case 5:
				cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(P_0, OdxgIs1tfL);
				num = 4;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__53))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		olCYdvpfKakK9EldPKl();
		int num;
		if (qa8sqopVDLk4iwX8JJp())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_008f;
			}
		}
		goto IL_0042;
		IL_0042:
		_003CShiftEditGraphics_003Ed__53 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine.delta = delta;
				break;
			default:
				num = 5;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
				goto case 1;
			case 5:
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_008f;
		IL_008f:
		stateMachine._003C_003E1__state = -1;
		num = 3;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		olCYdvpfKakK9EldPKl();
		int num;
		if (qa8sqopVDLk4iwX8JJp())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (!qa8sqopVDLk4iwX8JJp())
			{
				goto IL_0077;
			}
		}
		goto IL_0040;
		IL_0077:
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		list.Add(cvsEditableDisplayGraphic);
		num = 6;
		if (qa8sqopVDLk4iwX8JJp())
		{
			goto IL_0040;
		}
		goto IL_008e;
		IL_008e:
		cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)Li3l0WpUL3pCsTkhqVh(Point);
		num = 2;
		goto IL_0040;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 2:
				if (cvsEditableDisplayGraphic != null)
				{
					break;
				}
				goto case 6;
			case 1:
				goto IL_008e;
			case 0:
			case 5:
				list = new List<CvsEditableDisplayGraphic>();
				num = 1;
				continue;
			case 6:
				return (CvsEditableDisplayGraphic[])Y6JBCCpH1Nr4oV0Kf6Y(list);
			}
			break;
		}
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCellLocationAsVirtualDependency(CellViewModel cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YlD0FSpxulUCKf4ZDuJ(cell, Gokg3FTjlw);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_emptyCellViewModel_SourcePropertyChanged_003Ed__61))]
	private Task e7AQPw7575(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_emptyCellViewModel_SourcePropertyChanged_003Ed__61 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddReferenceAsync_003Ed__62))]
	private Task J5wQsO8KVf(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!olCYdvpfKakK9EldPKl()) ? 1 : 6);
		_003CAddReferenceAsync_003Ed__62 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine.newExpression = P_0;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CellViewModel di2QK5IlRF(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass63_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass63_0();
		CS_0024_003C_003E8__locals2.cellLoc = P_0;
		return Parent.AppViewModel.GetSourceablePrimitivesGrouped().SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (IGrouping<string, CellViewModel> g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g;
		}).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel cellVm) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass63_0.ra0mR5KRmyEUh2BK7LMZ(cellVm) == CS_0024_003C_003E8__locals2.cellLoc;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ft7QGHVkxS(CvsCellRange? P_0 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (P_0 ?? SelectedSheetRange).Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation cvsCellLocation) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return di2QK5IlRF(cvsCellLocation)?.IsBoundExternally ?? false;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool JOvQBNw5eC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!ft7QGHVkxS())
		{
			return SelectedSheetRange.IsValid;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteCellsAsync_003Ed__85))]
	private Task a1WQZRIc1U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 2;
			if (!qa8sqopVDLk4iwX8JJp())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_008c;
		IL_0046:
		_003CDeleteCellsAsync_003Ed__85 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_008c;
		IL_008c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 4:
				goto IL_0046;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (qa8sqopVDLk4iwX8JJp())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
		goto IL_0046;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool VQ9Qn8b96Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!ft7QGHVkxS())
		{
			return SelectedSheetRange.IsValid;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCutCellsAsync_003Ed__90))]
	private Task sWqQtywH9r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_005c;
		IL_00a1:
		_003CCutCellsAsync_003Ed__90 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 3:
				goto IL_0042;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto IL_0042;
			case 0:
				goto IL_00a1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0042:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a1;
		IL_001a:
		stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
		olCYdvpfKakK9EldPKl();
		if (qa8sqopVDLk4iwX8JJp())
		{
			num = 5;
			if (false)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GcAQYWFs8N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!ft7QGHVkxS())
		{
			return SelectedSheetRange.IsValid;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCopyCellsAsync_003Ed__97))]
	private Task d4lQ0nuFtS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qa8sqopVDLk4iwX8JJp())
		{
			num = 2;
			if (!qa8sqopVDLk4iwX8JJp())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_005c;
		IL_0042:
		_003CCopyCellsAsync_003Ed__97 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 4:
				goto IL_0042;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0089;
			case 3:
				goto IL_0089;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		num = 4;
		if (!qa8sqopVDLk4iwX8JJp())
		{
			goto IL_0042;
		}
		goto IL_005c;
		IL_0089:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool qF2QVvKfmd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		CvsCellRange selectedVirtualRange = default;
		CvsCellLocation currentSheetCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				selectedVirtualRange.Columns = HH0gx1FILw.Columns;
				goto default;
			case 0:
				if (VBMge6OXv9 == null)
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto default;
				}
				goto case 13;
			case 2:
				selectedVirtualRange.Rows = JAbg2HGBg4.Rows;
				_ = 1;
				if (olCYdvpfKakK9EldPKl())
				{
					num = 12;
					continue;
				}
				num = 4;
				if (qa8sqopVDLk4iwX8JJp())
				{
					continue;
				}
				goto default;
			default:
				if (!ft7QGHVkxS(GetActualCellRange(selectedVirtualRange)))
				{
					num = 10;
					continue;
				}
				break;
			case 9:
				selectedVirtualRange = SelectedVirtualRange;
				num = 5;
				continue;
			case 10:
				currentSheetCellLocation = CurrentSheetCellLocation;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 4:
				selectedVirtualRange.Columns = JAbg2HGBg4.Columns;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (!currentSheetCellLocation.IsValid)
				{
					break;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				if (fpsgyvYO9O != null)
				{
					num = 13;
					continue;
				}
				break;
			case 5:
				if (VBMge6OXv9 == null)
				{
					if (fpsgyvYO9O != null)
					{
						selectedVirtualRange.Rows = HH0gx1FILw.Rows;
						num = 8;
						continue;
					}
					goto default;
				}
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 13;
			case 13:
				return QhygDSE15X.Contains(selectedVirtualRange);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteCellsAsync_003Ed__104))]
	private Task hRkQLqs0xI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CPasteCellsAsync_003Ed__104 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				qa8sqopVDLk4iwX8JJp();
				if (!olCYdvpfKakK9EldPKl())
				{
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				num = 1;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_expressionViewModel_AcceptChanges_003Ed__107))]
	private void OxUQJl4Zok(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qa8sqopVDLk4iwX8JJp();
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 4;
			if (!qa8sqopVDLk4iwX8JJp())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_008e;
		IL_002e:
		_003C_expressionViewModel_AcceptChanges_003Ed__107 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008e;
		IL_008e:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = BPTqKFp1DbSr3OIqDSK();
				num = 3;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 1;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X0XQ95atkr(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string expression = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				ExpressionTextBoxViewModel.Expression = expression;
				num = 7;
				if (!olCYdvpfKakK9EldPKl())
				{
					break;
				}
				goto case 1;
			case 1:
				cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(((CvsResultSet)S2xy7fpNr5SKvJsaRF2(InSight)).Cells, CurrentSheetCellLocation);
				num = 2;
				break;
			case 2:
				if (cvsCell == null)
				{
					goto case 4;
				}
				goto default;
			default:
				qa8sqopVDLk4iwX8JJp();
				num = (olCYdvpfKakK9EldPKl() ? 5 : 6);
				break;
			case 0:
				expression = string.Empty;
				num = 1;
				break;
			case 3:
			case 6:
				expression = QYKQ8jpE7K((string)vlo9VQpPk37OXlWiKUi(cvsCell));
				goto case 4;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IUndoAction A5tQrXQV2T(CvsParse P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCell cvsCell = default;
		string oldExpression = default;
		string expression = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (cvsCell != null)
				{
					_ = 0;
					num = ((!qa8sqopVDLk4iwX8JJp()) ? 7 : 2);
					break;
				}
				goto case 5;
			case 6:
				oldExpression = string.Empty;
				num = 1;
				break;
			case 2:
			case 3:
				expression = cvsCell.Expression;
				goto case 0;
			default:
				num = 0;
				break;
			case 5:
			case 7:
				TranslateToSpreadsheet(P_1, P_0, QhygDSE15X, C3egSP8j5X);
				num = 8;
				break;
			case 1:
				cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(n5Z2mFprptXTxv4pW4Z(S2xy7fpNr5SKvJsaRF2(InSight)), CurrentSheetCellLocation);
				num = 4;
				break;
			case 0:
				oldExpression = QYKQ8jpE7K(expression);
				goto case 5;
			case 8:
				return new MathToolExpressionUndoAction(Parent, (string)mQVHpGpu8rdAeVFtinH(this), CurrentVirtualCellLocation, P_1, oldExpression);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteCellExpressionAsync_003Ed__110))]
	private Task P16QhE0acS(CvsParse P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		olCYdvpfKakK9EldPKl();
		int num = ((!qa8sqopVDLk4iwX8JJp()) ? 3 : 6);
		_003CWriteCellExpressionAsync_003Ed__110 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 4:
				stateMachine.parseInfo = P_0;
				goto case 5;
			default:
				num = 5;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string TranslateToSpreadsheet(string virtualExpr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsParse parseInfo = CvsParse.Parse((CvsFunctionTable)XajewxpgjIu7oiTKbKn(InSight), (IExpressionConstants)OyYfpVphxZXF8hkXqJO(InSight), virtualExpr, BI9TiqptNgLPbD9ANCt(virtualExpr), null, -1, g6cQiZcckd(), PfZgfxJ24d.IsValidFunction);
		return TranslateToSpreadsheet(virtualExpr, parseInfo, QhygDSE15X, C3egSP8j5X);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string TranslateToSpreadsheet(string virtualExpr, CvsParse parseInfo, CvsCellRange virtualSheetRange, CvsCellRange sheetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		olCYdvpfKakK9EldPKl();
		int num = ((!qa8sqopVDLk4iwX8JJp()) ? 2 : 4);
		string text = default;
		CvsParseTokenRange cvsParseTokenRange = default;
		string text2 = default;
		CvsCellRange cvsCellRange = default;
		CvsCellRange cvsCellRange2 = default;
		int num2 = default;
		bool flag = default;
		bool flag2 = default;
		bool flag3 = default;
		bool flag4 = default;
		CvsCellLocation location = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				text = (string)NPrA3lXJP1yT6vUAxxP(UeKUAHX5aJk3OgZnaix(text, 0, cvsParseTokenRange.Start), text2, EUGMORXw9IF0H69JPqG(text, cvsParseTokenRange.End));
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				cvsCellRange.Row += sheetRange.Row;
				num = 16;
				break;
			case 14:
				cvsCellRange = cvsCellRange2;
				num = 11;
				break;
			case 6:
				num2 = ((Array)T3Ba6Lpzitow8gJv5c7(parseInfo)).Length - 1;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
			case 7:
				if (num2 >= 0)
				{
					cvsParseTokenRange = ((CvsParseTokenRange[])T3Ba6Lpzitow8gJv5c7(parseInfo))[num2];
					goto case 2;
				}
				num = 17;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				if (virtualSheetRange.Contains(cvsCellRange2))
				{
					goto case 14;
				}
				goto case 12;
			default:
				num = 14;
				break;
			case 2:
			case 3:
				text2 = null;
				if (cvsParseTokenRange.Type.Equals(CdQUGaROfy7He9T0foW.KbIzwHEDLa(22222), StringComparison.Ordinal))
				{
					num = 10;
					if (olCYdvpfKakK9EldPKl())
					{
					}
					break;
				}
				if (hEtvU8XKImjB3qrgm9C(cvsParseTokenRange.Type, CdQUGaROfy7He9T0foW.KbIzwHEDLa(22264), StringComparison.Ordinal))
				{
					TC5QmQQKGp(cvsParseTokenRange.Text, out cvsCellRange2, out flag, out flag2, out flag3, out flag4);
					num = 13;
					break;
				}
				goto case 12;
			case 16:
				cvsCellRange.Column += sheetRange.Column;
				num = 1;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				text = virtualExpr;
				num = 6;
				break;
			case 1:
				text2 = cvsCellRange.ToString(flag, flag2, flag3, flag4);
				goto case 12;
			case 12:
				if (text2 != null)
				{
					num = 9;
					break;
				}
				goto case 8;
			case 8:
				num2--;
				num = 7;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 10;
			case 10:
				location = ((INamedOperandCollection)S9TgURXLJgWKPSnWcbs(parseInfo)).FindByName(cvsParseTokenRange.Text).Location;
				num = 15;
				break;
			case 15:
				text2 = location.ToString(absoluteRow: true, absoluteColumn: true);
				num = 12;
				break;
			case 17:
				return text;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string QYKQ8jpE7K(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EzOperandCollection namedOperands = g6cQiZcckd();
		CvsParse parseInfo = CvsParse.Parse(InSight.FunctionTable, InSight.ProcessorConstants, P_0, BI9TiqptNgLPbD9ANCt(P_0), null, -1, namedOperands, PfZgfxJ24d.IsValidFunction);
		return TranslateFromSpreadsheet(P_0, parseInfo, QhygDSE15X, C3egSP8j5X);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string TranslateFromSpreadsheet(string sheetExpr, CvsParse parseInfo, CvsCellRange virtualSheetRange, CvsCellRange sheetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 7;
			if (olCYdvpfKakK9EldPKl())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0075;
		IL_002a:
		CvsParseTokenRange cvsParseTokenRange = default;
		CvsCellRange cvsCellRange = default;
		bool flag = default;
		bool flag2 = default;
		bool flag3 = default;
		bool flag4 = default;
		TC5QmQQKGp(cvsParseTokenRange.Text, out cvsCellRange, out flag, out flag2, out flag3, out flag4);
		num = 2;
		goto IL_0075;
		IL_0075:
		string text2 = default;
		CvsCellRange virtualCellRange = default;
		int num2 = default;
		INamedOperand namedOperand = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 8:
			case 12:
				if (text2 != null)
				{
					num = 16;
					continue;
				}
				goto case 4;
			case 10:
				virtualCellRange = GetVirtualCellRange(cvsCellRange, sheetRange);
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				text2 = virtualCellRange.ToString(flag, flag2, flag3, flag4);
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 13:
				num2--;
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 14:
			case 15:
				if (num2 < 0)
				{
					num = 17;
					continue;
				}
				cvsParseTokenRange = ((CvsParseTokenRange[])T3Ba6Lpzitow8gJv5c7(parseInfo))[num2];
				text2 = null;
				num = 9;
				continue;
			case 1:
				num2 = ((Array)T3Ba6Lpzitow8gJv5c7(parseInfo)).Length - 1;
				num = 14;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				continue;
			case 3:
				if (cvsCellRange.Count() == 1 && !sheetRange.Contains(cvsCellRange.Location))
				{
					namedOperand = (INamedOperand)N8SHdwXaKI2IRcxH4KN(parseInfo.SymbolicTags, cvsParseTokenRange.Text);
				}
				if (!sheetRange.Contains(cvsCellRange))
				{
					if (namedOperand != null)
					{
						num = 11;
						continue;
					}
					goto case 8;
				}
				num = 10;
				continue;
			case 16:
				text = (string)NPrA3lXJP1yT6vUAxxP(UeKUAHX5aJk3OgZnaix(text, 0, cvsParseTokenRange.Start), text2, text.Substring(cvsParseTokenRange.End));
				goto case 4;
			case 2:
				namedOperand = null;
				num = 3;
				continue;
			case 0:
			case 7:
				text = sheetExpr;
				num = 1;
				continue;
			case 11:
				text2 = namedOperand.Name;
				num = 8;
				continue;
			case 9:
				if (cvsParseTokenRange.Type.Equals((string)GRop46pssAn5jiRLwK2(22264), StringComparison.Ordinal))
				{
					num = 6;
					continue;
				}
				goto case 8;
			case 17:
				return text;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void TC5QmQQKGp(string P_0, out CvsCellRange P_1, out bool P_2, out bool P_3, out bool P_4, out bool P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		string[] array = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (array.Length == 2)
				{
					goto case 6;
				}
				return;
			case 9:
				array = (string[])TMpDnYXOuGOrop80986(P_0, new char[1] { ':' });
				num = 8;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 5;
			case 5:
				P_4 = FN6joyXDjVd0k0yxc25(EUGMORXw9IF0H69JPqG(array[1], 1), '$') >= 0;
				num = 11;
				break;
			case 1:
				P_4 = false;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
			case 7:
				P_5 = array[1].StartsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1702));
				num = 5;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 8;
			case 8:
				P_3 = mil38nXIAcBJcUWRkOk(array[0], CdQUGaROfy7He9T0foW.KbIzwHEDLa(1702));
				_ = 1;
				if (olCYdvpfKakK9EldPKl())
				{
					num = 6;
					break;
				}
				num = 0;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				break;
			case 2:
				P_5 = false;
				goto case 1;
			default:
				num = 1;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 10;
			case 10:
				P_1 = tI23RUXeW8jGB5J4Aci(P_0);
				num = 9;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				P_2 = FN6joyXDjVd0k0yxc25(EUGMORXw9IF0H69JPqG(array[0], 1), '$') >= 0;
				num = 2;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 10;
		}
		else
		{
			num = 2;
			if (olCYdvpfKakK9EldPKl())
			{
				return;
			}
		}
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				xJugoFUm9e.Expression = QYKQ8jpE7K((string)vlo9VQpPk37OXlWiKUi(cvsCell));
				goto case 9;
			default:
				num = 9;
				break;
			case 7:
				base.OnResultsChanged(results);
				num = 11;
				break;
			case 6:
				MvKQ1RTxff(results.Cells);
				num = 7;
				break;
			case 3:
				cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(results.Cells, CurrentSheetCellLocation);
				num = 4;
				break;
			case 9:
				IsCurrentCellBoundExternally = di2QK5IlRF(CurrentSheetCellLocation)?.IsBoundExternally ?? false;
				goto case 8;
			case 1:
			case 2:
				F3Rr91Xi3XSaEk2BxkE(xJugoFUm9e, g6cQiZcckd());
				num = 3;
				break;
			case 8:
				if (!tddwnEXVQ2WGJvp5Osj(results))
				{
					num = 6;
					break;
				}
				goto case 7;
			case 4:
				if (cvsCell == null)
				{
					yvWuO6XnqehN67ccIPf(xJugoFUm9e, string.Empty);
					num = 8;
				}
				else
				{
					num = 5;
				}
				break;
			case 0:
			case 10:
				if (xJugoFUm9e != null)
				{
					goto case 1;
				}
				goto case 8;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MvKQ1RTxff(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 37;
		int num3 = default;
		int num2 = default;
		CvsCellLocation invalid = default;
		CellViewModel cellViewModel = default;
		bool flag = default;
		CvsCellLocation cvsCellLocation = default;
		MiniSheetRow miniSheetRow = default;
		CvsCell cvsCell = default;
		CellViewModel cellViewModel2 = default;
		string displayName = default;
		while (true)
		{
			switch (num)
			{
			case 8:
			case 45:
			case 57:
				num3++;
				goto case 27;
			case 27:
				if (num3 >= 8)
				{
					num2++;
					num = 30;
				}
				else
				{
					invalid.Column = C3egSP8j5X.Column + num3;
					num = 23;
				}
				break;
			case 34:
				if (!(cellViewModel is CheckBoxViewModel))
				{
					num = 20;
					break;
				}
				goto case 4;
			case 37:
				flag = false;
				num = 3;
				break;
			case 25:
				if (!(cellViewModel is EmptyCellViewModel))
				{
					FmtgaD3wrF(cellViewModel, null);
					num = 32;
					break;
				}
				goto case 8;
			case 23:
				cvsCellLocation = new CvsCellLocation(num2, num3);
				qa8sqopVDLk4iwX8JJp();
				if (!olCYdvpfKakK9EldPKl())
				{
					num = 44;
					break;
				}
				num = 57;
				if (0 == 0)
				{
					break;
				}
				goto case 41;
			case 1:
				miniSheetRow = MiniSheet[num2];
				num3 = 0;
				num = 27;
				break;
			case 19:
				if (!(cellViewModel is ListBoxViewModel))
				{
					num = 24;
					break;
				}
				goto case 4;
			case 13:
				if (cvsCell == null)
				{
					if (cellViewModel != null)
					{
						num = 25;
						break;
					}
					goto case 8;
				}
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 28;
			case 28:
				if (!(cellViewModel is RegionViewModel))
				{
					num = 29;
					break;
				}
				goto case 4;
			case 18:
				SetCellLocationAsVirtualDependency(AK7gTGQicv);
				num = 14;
				break;
			case 48:
				if (!(cellViewModel is ButtonViewModel))
				{
					num = 49;
					if (0 == 0)
					{
						break;
					}
					goto case 36;
				}
				goto case 4;
			case 36:
				if (MtGdQlXd96X39Zab5I8(cvsCell))
				{
					num = 47;
					break;
				}
				if (cvsCell.CellResult.Value is CvsCogPoint)
				{
					if (!(cellViewModel is PointViewModel))
					{
						num = 54;
						break;
					}
				}
				else if (!(l1GP27Xg0uwpbTJ8rXP(Q8Q850XlDq8HkJaoJiM(cvsCell)) is CvsCogLine))
				{
					if (l1GP27Xg0uwpbTJ8rXP(Q8Q850XlDq8HkJaoJiM(cvsCell)) is CvsCogFixture)
					{
						num = 21;
						break;
					}
					if (!(l1GP27Xg0uwpbTJ8rXP(Q8Q850XlDq8HkJaoJiM(cvsCell)) is CvsCogCircle))
					{
						if (((CvsCogCellResult)Q8Q850XlDq8HkJaoJiM(cvsCell)).Value is CvsCogRegion)
						{
							num = 28;
							if (!olCYdvpfKakK9EldPKl())
							{
								break;
							}
							goto case 56;
						}
						if (!(cellViewModel is StringViewModel))
						{
							num = 7;
							break;
						}
					}
					else if (!(cellViewModel is CircleViewModel))
					{
						num = 17;
						if (!olCYdvpfKakK9EldPKl())
						{
							break;
						}
					}
				}
				else if (!(cellViewModel is LineViewModel))
				{
					num = 10;
					break;
				}
				goto case 4;
			case 47:
				if (!(cellViewModel is ErrorViewModel))
				{
					cellViewModel2 = new ErrorViewModel(InSight, P_0, invalid, displayName);
				}
				goto case 4;
			case 6:
			case 44:
				cellViewModel = (CellViewModel)PMWbkdpQ9ciBTmrwodN(miniSheetRow, num3);
				num = 41;
				if (!olCYdvpfKakK9EldPKl())
				{
					break;
				}
				goto case 7;
			case 7:
				cellViewModel2 = new StringViewModel(InSight, P_0, invalid, displayName);
				num = 4;
				break;
			case 26:
				cellViewModel2 = new FloatViewModel(InSight, P_0, invalid, displayName);
				num = 42;
				break;
			case 0:
				if (!(cellViewModel is EditStringViewModel))
				{
					cellViewModel2 = new EditStringViewModel(InSight, P_0, invalid, displayName);
					num = 40;
					break;
				}
				goto case 4;
			case 3:
				invalid = CvsCellLocation.Invalid;
				num = 33;
				if (0 == 0)
				{
					break;
				}
				goto case 20;
			case 20:
				cellViewModel2 = new CheckBoxViewModel(InSight, P_0, invalid, displayName, IsInitialized);
				num = 16;
				if (true)
				{
					break;
				}
				goto case 27;
			case 14:
				AK7gTGQicv.SourcePropertyChanged += e7AQPw7575;
				MiniSheet[cvsCellLocation.Row].SetColumn(cvsCellLocation.Column, AK7gTGQicv);
				num = 38;
				if (!olCYdvpfKakK9EldPKl())
				{
					break;
				}
				goto case 4;
			case 21:
				if (!(cellViewModel is FixtureViewModel))
				{
					num = 50;
					if (!olCYdvpfKakK9EldPKl())
					{
						break;
					}
					goto case 30;
				}
				goto case 4;
			case 30:
				if (num2 >= KqHy7qXrBqwkG1gdCJ7(MiniSheet))
				{
					num = 2;
					break;
				}
				invalid.Row = C3egSP8j5X.Row + num2;
				num = 1;
				break;
			case 17:
				cellViewModel2 = new CircleViewModel(InSight, P_0, invalid, displayName);
				num = 12;
				break;
			case 50:
				cellViewModel2 = new FixtureViewModel(InSight, P_0, invalid, displayName);
				num = 51;
				break;
			case 11:
				cellViewModel2 = new EditIntViewModel(InSight, P_0, invalid, displayName);
				num = 31;
				break;
			case 10:
				cellViewModel2 = new LineViewModel(InSight, P_0, invalid, displayName);
				goto case 4;
			case 24:
				cellViewModel2 = new ListBoxViewModel(InSight, P_0, invalid, displayName);
				goto case 4;
			case 32:
				if (cvsCellLocation.Equals(CurrentVirtualCellLocation))
				{
					num = 46;
					break;
				}
				MiniSheet[cvsCellLocation.Row].SetColumn(cvsCellLocation.Column, null);
				num = 5;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 4;
			case 29:
				cellViewModel2 = new RegionViewModel(InSight, P_0, invalid, displayName);
				num = 58;
				break;
			case 55:
				cellViewModel2 = new EditFloatViewModel(InSight, P_0, invalid, displayName);
				num = 43;
				break;
			case 39:
				flag = true;
				goto IL_04f0;
			case 41:
				cvsCell = (CvsCell)gAPf5ap9MgoVQhweBr8(P_0, invalid);
				num = 13;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 4;
			case 35:
				FireDependencyChanged();
				num = 59;
				break;
			case 52:
				if (!(cellViewModel is EditIntViewModel))
				{
					num = 11;
					break;
				}
				goto case 4;
			case 54:
				cellViewModel2 = new PointViewModel(InSight, P_0, invalid, displayName);
				goto case 4;
			default:
				num = 22;
				break;
			case 56:
				if (cellViewModel2 is QpXw26KT7OGd3H62pw)
				{
					num = 39;
					break;
				}
				goto IL_04f0;
			case 4:
			case 12:
			case 15:
			case 16:
			case 22:
			case 31:
			case 40:
			case 42:
			case 43:
			case 51:
			case 58:
				if (cellViewModel2 == null)
				{
					goto IL_04f0;
				}
				XRloAJpmjfCcVNBfla5(miniSheetRow, num3, cellViewModel2);
				if (cellViewModel == null || cellViewModel is EmptyCellViewModel)
				{
					R9XQzoYv9P(cellViewModel2);
					goto case 56;
				}
				FmtgaD3wrF(cellViewModel, cellViewModel2);
				cellViewModel2.IsBoundExternally = Axs7FyXsXPQcIgS1ila(cellViewModel);
				num = 56;
				break;
			case 46:
				AK7gTGQicv = new EmptyCellViewModel();
				num = 18;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				if (flag)
				{
					num = 35;
					break;
				}
				return;
			case 33:
				num2 = 0;
				goto case 30;
			case 9:
				cellViewModel2 = null;
				displayName = (string)rl1aYYXfQpEXHtIPRAD(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1906), cvsCellLocation);
				if (!(cvsCell is CvsCellFloat))
				{
					if (cvsCell is CvsCellEditFloat)
					{
						if (!(cellViewModel is EditFloatViewModel))
						{
							num = 55;
							break;
						}
					}
					else
					{
						if (cvsCell is CvsCellCheckBox)
						{
							num = 34;
							break;
						}
						if (!(cvsCell is CvsCellButton))
						{
							if (cvsCell is CvsCellEditInt)
							{
								num = 52;
								break;
							}
							if (cvsCell is CvsCellListBox)
							{
								num = 19;
								if (true)
								{
									break;
								}
								goto case 24;
							}
							if (cvsCell is CvsCellString)
							{
								num = 36;
								break;
							}
							if (cvsCell is CvsCellEditString)
							{
								num = 0;
								if (true)
								{
									break;
								}
								goto case 19;
							}
						}
						else
						{
							num = 48;
							if (0 == 0)
							{
								break;
							}
						}
					}
					goto case 4;
				}
				num = 53;
				break;
			case 5:
			case 38:
				flag = true;
				num = 8;
				break;
			case 49:
				cellViewModel2 = new ButtonViewModel(InSight, P_0, invalid, displayName);
				num = 15;
				break;
			case 53:
				if (!(cellViewModel is FloatViewModel))
				{
					num = 26;
					if (1 == 0)
					{
						return;
					}
					break;
				}
				goto case 4;
			case 59:
				return;
				IL_04f0:
				mSlIxYXvEKTjj9LjSVT(miniSheetRow, num2.ToString());
				goto case 8;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void R9XQzoYv9P(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!qa8sqopVDLk4iwX8JJp())
		{
			goto IL_001e;
		}
		goto IL_003e;
		IL_001e:
		CvsCellLocation virtualCellLocation = default;
		string item = virtualCellLocation.ToString();
		goto IL_0146;
		IL_003e:
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 8:
				return;
			case 10:
			{
				List<string> list = d1QgELAJft;
				virtualCellLocation = GetVirtualCellLocation(P_0.CellLocation);
				list.Add(virtualCellLocation.ToString());
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			}
			case 7:
				iq8JM3XPCGpcScaipMC(d1QgELAJft);
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				virtualCellLocation = GetVirtualCellLocation(MX1j1NpXKlQJokmvqXJ(P_0));
				num = 9;
				continue;
			case 0:
			case 2:
				if (lvXg5wSm4P(P_0))
				{
					num = 1;
					continue;
				}
				return;
			case 3:
				VirtualFloatCells = d1QgELAJft.ToArray();
				num = 11;
				continue;
			case 4:
				goto IL_0136;
			default:
				goto IL_0146;
			case 11:
				return;
			}
			break;
			IL_0136:
			if (P_0 != null)
			{
				AddProperty(P_0);
				_ = 0;
				if (!qa8sqopVDLk4iwX8JJp())
				{
					num = 6;
					if (!qa8sqopVDLk4iwX8JJp())
					{
						return;
					}
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 8;
			}
		}
		goto IL_001e;
		IL_0146:
		if (!d1QgELAJft.Contains(item))
		{
			num = 10;
			goto IL_003e;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FmtgaD3wrF(CellViewModel P_0, CellViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		CvsCellLocation actualCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				RemoveProperty(P_0);
				num = 7;
				break;
			case 4:
				VirtualFloatCells = d1QgELAJft.ToArray();
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
			case 9:
				wIbyBnXB4bkDfxrJ0l2(P_0, P_1);
				num = 12;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				if (d1QgELAJft.Remove(GetVirtualCellLocation(actualCellLocation).ToString()))
				{
					num = 4;
					break;
				}
				goto case 5;
			case 2:
				if (!TImAxHpEDEbsXHZCPkf(PassCell, actualCellLocation.ToString()))
				{
					goto case 0;
				}
				PassCell = zhbgbtWmWw;
				num = 0;
				if (qa8sqopVDLk4iwX8JJp())
				{
					break;
				}
				goto case 11;
			case 11:
				if (!WMKyEDXZv3d39bwyhfP(P_1))
				{
					num = 2;
					break;
				}
				goto case 5;
			case 7:
				if (P_1 != null)
				{
					_ = 1;
					if (!olCYdvpfKakK9EldPKl())
					{
						num = 3;
						break;
					}
					num = 6;
					if (olCYdvpfKakK9EldPKl())
					{
					}
					break;
				}
				goto case 6;
			case 10:
				if (P_0 == null)
				{
					num = 1;
					break;
				}
				actualCellLocation = MX1j1NpXKlQJokmvqXJ(P_0);
				num = 11;
				break;
			case 3:
			case 8:
				R9XQzoYv9P(P_1);
				goto case 6;
			case 1:
				return;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool lvXg5wSm4P(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0 != null)
		{
			if (!(P_0 is FloatViewModel))
			{
				return GDb9XmXbfaPagtx5m5C(P_0);
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.AddDefaultReferences(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)XwnwadXGv1DZOWEjXWS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__125))]
	Task ISnippetConsumer.RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!olCYdvpfKakK9EldPKl())
		{
		}
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__125 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine.e = e;
				goto default;
			default:
				qa8sqopVDLk4iwX8JJp();
				num = ((!olCYdvpfKakK9EldPKl()) ? 6 : 0);
				break;
			case 2:
				stateMachine._003C_003Et__builder = oujjJHpYyDNh47lCM9D();
				num = 5;
				if (olCYdvpfKakK9EldPKl())
				{
				}
				break;
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.RenameReferences(SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)XwnwadXGv1DZOWEjXWS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MathTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qa8sqopVDLk4iwX8JJp();
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 4;
			if (olCYdvpfKakK9EldPKl())
			{
			}
		}
		else
		{
			num = 1;
		}
		do
		{
			IL_004e:
			switch (num)
			{
			case 2:
				zhbgbtWmWw = Resources.HkEL6iaLKo();
				break;
			case 0:
			case 4:
				XxvQeRpdsZ5IQGHjLDf();
				num = 5;
				goto IL_004e;
			case 5:
				UZvgX4gWcU = LogManager.GetLogger<MathTool>();
				num = 2;
				goto IL_004e;
			case 6:
				return;
			}
			efqgchsoto = true;
			num = 6;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool r6Ygpmj02u(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qa8sqopVDLk4iwX8JJp();
		int num;
		if (!olCYdvpfKakK9EldPKl())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (olCYdvpfKakK9EldPKl())
			{
			}
		}
		goto IL_0069;
		IL_004b:
		CvsCellLocation cvsCellLocation = default;
		if (cvsCellLocation.IsValid)
		{
			goto IL_0090;
		}
		goto IL_00cb;
		IL_00b2:
		return !mil38nXIAcBJcUWRkOk(LTQiGtXodQ1GTPZDlG5(P_0), CdQUGaROfy7He9T0foW.KbIzwHEDLa(22292));
		IL_0090:
		if (!C3egSP8j5X.Contains(MX1j1NpXKlQJokmvqXJ(P_0)))
		{
			num = 5;
			if (true)
			{
				goto IL_0069;
			}
			goto IL_00b2;
		}
		goto IL_00cb;
		IL_0069:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				goto IL_004b;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_0090;
			case 5:
				goto IL_00b2;
			}
			break;
		}
		goto IL_002a;
		IL_00cb:
		return false;
		IL_002a:
		cvsCellLocation = MX1j1NpXKlQJokmvqXJ(P_0);
		goto IL_004b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task MlggUCZZ2v(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool RnZg74HL5V(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return di2QK5IlRF(P_0)?.IsBoundExternally ?? false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XxvQeRpdsZ5IQGHjLDf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ebYcHSpljilearF0oFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EZBSnippetStrings.ResourceManager;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XajewxpgjIu7oiTKbKn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).FunctionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qa8sqopVDLk4iwX8JJp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool olCYdvpfKakK9EldPKl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GRop46pssAn5jiRLwK2(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation n3nbRupvoRytg2D9gF8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n5Z2mFprptXTxv4pW4Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vlo9VQpPk37OXlWiKUi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kHh7l4pZxaak2ePHSMX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TU0wSDpBqQiYdOC9duS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zNcyInpbiJnotASDBCn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.Mvvm.BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zi6Dl3pGfEUaoffJtE7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zdOqTupopXkE2H0uoZd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void quC4yspSMxgNVnTHTBW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation nBu81Epku80poWd7Iss(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Acquired2DImageLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qsEfXpp8MUhtUD8lURM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzOperandCollection)P_0).Add((INamedOperand)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation OaE5YfpqxL5XOGWFBnc(CvsCellLocation actualCellLocation, CvsCellRange sheetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetVirtualCellLocation(actualCellLocation, sheetRange);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TImAxHpEDEbsXHZCPkf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JdtJBrppjM5mlftVLOx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Point;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation MX1j1NpXKlQJokmvqXJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gAPf5ap9MgoVQhweBr8(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wrcm7sp4ROt0MuSeXHl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HkEL6iaLKo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lq8M0sp7vyfSCDkmTtT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.mE50h8p6pm();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yAopP0p3Em1Wo03ICF1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.QDU09mPEII();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LjJp3fpjG3yTnGp13S6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tqT0L2SdRb();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ehfpwdp6IQ7ZJ78xl7V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VIJ0t3XP7A();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c1hYv8pCBjFRo4FgWiu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ML900WQ5KC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z1Re25pAkwkWSslAUxw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VMM0q6MUn3();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a5ExCPpREPPK8WQ55xB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.hWp0wuUfgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object adBoudpWw7C2ag5LDIM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.wBK0mu8V74();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uXDPH9pT2kkerc8krdv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.jBG0zeTV5K();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XsJj6Tpy3jLa9VX4yD9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HMVVUsqDc7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SbrJf8p0iJ54VQi4Ot7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.KZY0kUnJ3N();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MQ4Wu7pFP2TEOBgosEc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Ty80sdFsR6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KTYfTXpMZXqCFMDqHLv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.U9n0Guaui9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder oujjJHpYyDNh47lCM9D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Li3l0WpUL3pCsTkhqVh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y6JBCCpH1Nr4oV0Kf6Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YlD0FSpxulUCKf4ZDuJ(object P_0, CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).CellLocation = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XRloAJpmjfCcVNBfla5(object P_0, int c, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((MiniSheetRow)P_0).SetColumn(c, (CellViewModel)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PMWbkdpQ9ciBTmrwodN(object P_0, int c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MiniSheetRow)P_0).GetColumn(c);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S2xy7fpNr5SKvJsaRF2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HHwqmKp2E0TkrGsGGgf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSensor)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Fl5kmdpcSpTdE7QHgo6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).MaxExpressionStack;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder BPTqKFp1DbSr3OIqDSK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mQVHpGpu8rdAeVFtinH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OyYfpVphxZXF8hkXqJO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BI9TiqptNgLPbD9ANCt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T3Ba6Lpzitow8gJv5c7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).TokenRanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S9TgURXLJgWKPSnWcbs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).SymbolicTags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hEtvU8XKImjB3qrgm9C(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UeKUAHX5aJk3OgZnaix(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EUGMORXw9IF0H69JPqG(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NPrA3lXJP1yT6vUAxxP(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N8SHdwXaKI2IRcxH4KN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((INamedOperandCollection)P_0).FindMatch((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange tI23RUXeW8jGB5J4Aci(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellRange.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TMpDnYXOuGOrop80986(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mil38nXIAcBJcUWRkOk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FN6joyXDjVd0k0yxc25(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F3Rr91Xi3XSaEk2BxkE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ExpressionTextBoxViewModel)P_0).TagMap = (INamedOperandCollection)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yvWuO6XnqehN67ccIPf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ExpressionTextBoxViewModel)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tddwnEXVQ2WGJvp5Osj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).IsEmpty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rl1aYYXfQpEXHtIPRAD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MtGdQlXd96X39Zab5I8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q8Q850XlDq8HkJaoJiM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l1GP27Xg0uwpbTJ8rXP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Axs7FyXsXPQcIgS1ila(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).IsBoundExternally;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mSlIxYXvEKTjj9LjSVT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((MiniSheetRow)P_0).Header = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KqHy7qXrBqwkG1gdCJ7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<MiniSheetRow>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iq8JM3XPCGpcScaipMC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<string>)P_0).Sort();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WMKyEDXZv3d39bwyhfP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return lvXg5wSm4P((CellViewModel)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wIbyBnXB4bkDfxrJ0l2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).ReplacedWith((CellViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GDb9XmXbfaPagtx5m5C(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XwnwadXGv1DZOWEjXWS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LTQiGtXodQ1GTPZDlG5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}
}
