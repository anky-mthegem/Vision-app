using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common.Commands;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Controls.ViewModels.PropertySheet.FormatString;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Sensor;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using PwP36oJrJgiKa1qpQA;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class EzFormatStringViewModel : Cognex.Mvvm.BaseViewModel, IFormatStringViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellCollection cells;

		public EzFormatStringViewModel _003C_003E4__this;

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
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			PropertyInfo propertyInfo = default;
			int num4 = default;
			string expression = default;
			PropertyInfo[] properties = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						object obj;
						int num3;
						if (num2 != 0)
						{
							CvsCellCollection cvsCellCollection = cells;
							if (cvsCellCollection != null)
							{
								CvsCell cvsCell = cvsCellCollection[ezFormatStringViewModel.CellLocation];
								obj = ((cvsCell != null) ? GLTEBl5fnA90qw8k2RV4(cvsCell) : null);
								goto IL_0086;
							}
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						goto IL_01f7;
						IL_01f7:
						while (true)
						{
							switch (num3)
							{
							case 14:
								DBdord5fsNCyTmhXX79i(ezFormatStringViewModel, propertyInfo.Name);
								num3 = 13;
								continue;
							case 3:
								break;
							case 18:
								if (!awaiter.IsCompleted)
								{
									QXWiqj5fDcgywyadfyKA();
									if (!sSjptc5fiTh2LIklYqcc())
									{
										num3 = 5;
										continue;
									}
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 4;
								}
								goto case 11;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 7:
								goto IL_00ce;
							case 2:
								return;
							case 13:
								num4++;
								num3 = 20;
								continue;
							case 17:
								ezFormatStringViewModel.rvCikDMtR5 = new FormatStringViewModel(ezFormatStringViewModel.CellLocation, (CvsFunctionTable)oTn6WN5fV0BqaNeT79F2(ezFormatStringViewModel.InSight), (IExpressionConstants)fyX8pb5fdsBK3wYfgUph(bENY3J5ffBnCvLsH04fj(ezFormatStringViewModel.InSight)), ezFormatStringViewModel.InSight.Results.Cells, expression, ezFormatStringViewModel.cA0iP9B3CH);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								ezFormatStringViewModel.rvCikDMtR5.PropertyChanged += ezFormatStringViewModel.lDwiej7msU;
								ezFormatStringViewModel.rvCikDMtR5.ArgumentPropertyChanged += ezFormatStringViewModel.lrpiRasGpI;
								num3 = 15;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (!sSjptc5fiTh2LIklYqcc())
								{
									continue;
								}
								goto case 5;
							case 5:
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 4:
								hUlIf35flw3Z830j80vy(ezFormatStringViewModel.rvCikDMtR5.DeleteCommand, new EventHandler(ezFormatStringViewModel.zRRiy2JIr2));
								num3 = 16;
								continue;
							case 15:
								ezFormatStringViewModel.rvCikDMtR5.MoveUpCommand.CanExecuteChanged += ezFormatStringViewModel.Q8Nil9Q4r7;
								ezFormatStringViewModel.rvCikDMtR5.MoveDownCommand.CanExecuteChanged += ezFormatStringViewModel.zLCijLN8wQ;
								num3 = 4;
								continue;
							case 16:
								awaiter = SoS6t35fgMJ8tSebkErh(ezFormatStringViewModel.rvCikDMtR5.InitializeAsync());
								num3 = 18;
								if (QXWiqj5fDcgywyadfyKA())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 11:
								awaiter.GetResult();
								properties = ezFormatStringViewModel.GetType().GetProperties();
								num4 = 0;
								num3 = 19;
								continue;
							case 19:
							case 20:
								if (num4 < properties.Length)
								{
									propertyInfo = properties[num4];
									num3 = 14;
									continue;
								}
								goto end_IL_002f;
							}
							break;
						}
						obj = null;
						goto IL_0086;
						IL_00ce:
						obj = "";
						goto IL_00d3;
						IL_00d3:
						expression = (string)obj;
						ezFormatStringViewModel.cA0iP9B3CH = new EzFormatStringService(ezFormatStringViewModel.InSight, ezFormatStringViewModel.CellLocation);
						num3 = 17;
						if (sSjptc5fiTh2LIklYqcc())
						{
							return;
						}
						goto IL_01f7;
						IL_0086:
						if (obj != null)
						{
							goto IL_00d3;
						}
						num3 = 7;
						goto IL_01f7;
						end_IL_002f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					num2 = _003C_003E1__state;
					sSjptc5fiTh2LIklYqcc();
					num = ((!QXWiqj5fDcgywyadfyKA()) ? 5 : 0);
					break;
				case 0:
				case 1:
					ezFormatStringViewModel = _003C_003E4__this;
					num = 4;
					if (sSjptc5fiTh2LIklYqcc())
					{
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
		internal static object GLTEBl5fnA90qw8k2RV4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oTn6WN5fV0BqaNeT79F2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bENY3J5ffBnCvLsH04fj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Sensor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fyX8pb5fdsBK3wYfgUph(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSensor)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hUlIf35flw3Z830j80vy(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ICommand)P_0).CanExecuteChanged += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SoS6t35fgMJ8tSebkErh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DBdord5fsNCyTmhXX79i(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Mvvm.BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QXWiqj5fDcgywyadfyKA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sSjptc5fiTh2LIklYqcc()
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
	private struct _003CDoMoveUpAsync_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			int num2 = default;
			UndoFormatStringMoveArg undoFormatStringMoveArg = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01c4:
				switch (num)
				{
				case 1:
				case 4:
					ezFormatStringViewModel = _003C_003E4__this;
					num = 0;
					goto IL_01c4;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!GBavZH5fvKawL3ZCkkeS()) ? 2 : 4);
					goto IL_01c4;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoFormatStringMoveArg = new UndoFormatStringMoveArg(ezFormatStringViewModel.CommStep, ezFormatStringViewModel.Y7misQpeot, up: true);
							num3 = 8;
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
							case 0:
								_003C_003Eu__1 = default;
								goto case 4;
							case 4:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (GBavZH5fvKawL3ZCkkeS())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (GBavZH5fvKawL3ZCkkeS())
								{
									continue;
								}
								return;
							case 1:
							case 5:
								return;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								num3 = (GBavZH5fvKawL3ZCkkeS() ? 1 : 4);
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 8:
								awaiter = m5EXZr5fZR2GwecQIqjR(DFrhqt5fPy5lyul5MCJE(ezFormatStringViewModel.InSight.UndoHandler, undoFormatStringMoveArg));
								num3 = 3;
								if (GBavZH5fvKawL3ZCkkeS())
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (true);
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
		internal static object DFrhqt5fPy5lyul5MCJE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter m5EXZr5fZR2GwecQIqjR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GBavZH5fvKawL3ZCkkeS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QslAiY5fr8NuGxm3ke31()
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
	private struct _003CDoMoveDownAsync_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e8k6Eq5fbOnJnrwCaQeR();
			int num;
			if (pPDBJ25fB2LwgfpKuqSn())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01e8;
			IL_0041:
			int num2 = _003C_003E1__state;
			goto IL_0213;
			IL_01e8:
			UndoFormatStringMoveArg undoFormatStringMoveArg = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 3:
					goto IL_0041;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoFormatStringMoveArg = new UndoFormatStringMoveArg(ezFormatStringViewModel.CommStep, ezFormatStringViewModel.Y7misQpeot, up: false);
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_00af;
							}
						}
						goto IL_00eb;
						IL_0193:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_00eb;
						IL_00af:
						num2 = (_003C_003E1__state = 0);
						pPDBJ25fB2LwgfpKuqSn();
						if (!e8k6Eq5fbOnJnrwCaQeR())
						{
							num3 = 1;
						}
						else
						{
							num3 = 8;
							if (e8k6Eq5fbOnJnrwCaQeR())
							{
								goto IL_0193;
							}
						}
						goto IL_00eb;
						IL_00eb:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									if (!e8k6Eq5fbOnJnrwCaQeR())
									{
										continue;
									}
									return;
								}
								goto case 10;
							case 4:
								return;
							case 0:
								break;
							case 1:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (pPDBJ25fB2LwgfpKuqSn())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (e8k6Eq5fbOnJnrwCaQeR())
								{
								}
								continue;
							case 5:
								awaiter = pcSEbU5fS9QsS7XqexSr(kr0GXH5fo9y2B2v5CiJa(XpBqrJ5fGCZ46AEQJ1Tt(ezFormatStringViewModel.InSight), undoFormatStringMoveArg));
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								goto IL_0193;
							case 7:
							case 8:
								goto IL_0193;
							case 10:
								awaiter.GetResult();
								goto end_IL_0058;
							}
							break;
						}
						goto IL_00af;
						end_IL_0058:;
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
					num = 2;
					continue;
				case 1:
				case 4:
					goto IL_0213;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_0041;
			}
			goto IL_01e8;
			IL_0213:
			ezFormatStringViewModel = _003C_003E4__this;
			num = 5;
			goto IL_01e8;
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
		internal static object XpBqrJ5fGCZ46AEQJ1Tt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kr0GXH5fo9y2B2v5CiJa(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pcSEbU5fS9QsS7XqexSr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pPDBJ25fB2LwgfpKuqSn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e8k6Eq5fbOnJnrwCaQeR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public string toolName;

		public string propName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass74_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MAFWmr5fqwuT0Pexi3u7();
			RRycSE5fE6DvpXxwZ0Mk(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal _003C_003Ef__AnonymousType0<FormatStringArgument, string> _003CDoAddArgumentAsync_003Eb__0(FormatStringArgument arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new
			{
				arg = arg,
				label = toolName + CdQUGaROfy7He9T0foW.KbIzwHEDLa(1104) + propName + CdQUGaROfy7He9T0foW.KbIzwHEDLa(1104) + arg.SubPropertyLabel
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MAFWmr5fqwuT0Pexi3u7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RRycSE5fE6DvpXxwZ0Mk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M47fGe5fkSBsY0wDqQb7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cLBcs05f8cBh3qrCUUjD()
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
	private struct _003CDoAddArgumentAsync_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CellViewModel property;

		public EzFormatStringViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (UxjsyQ5fXQ8wJP7RV2bB())
			{
				goto IL_001e;
			}
			goto IL_05aa;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_05aa;
			IL_05aa:
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			_003C_003Ec__DisplayClass74_0 obj = default;
			string[] array = default;
			IEnumerable<FormatStringArgViewModel> source = default;
			FormatStringDataType dataType = default;
			FhUY4uBLEMII4DUtd7 fhUY4uBLEMII4DUtd = default;
			CvsCellRange cvsCellRange = default;
			string message = default;
			FormatStringArgViewModel formatStringArgViewModel = default;
			CvsReferenceRange cvsReferenceRange = default;
			CellType cellType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
					ezFormatStringViewModel = _003C_003E4__this;
					UxjsyQ5fXQ8wJP7RV2bB();
					num = ((!nOrJ2y5fpdssN5gybJVW()) ? 4 : 0);
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					try
					{
						_ = 1;
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter = _003C_003Eu__1;
									goto IL_02a2;
								}
								num3 = 27;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 2;
							}
							goto IL_0315;
							IL_0315:
							while (true)
							{
								switch (num3)
								{
								case 25:
									obj.toolName = array[0];
									num3 = 19;
									continue;
								case 23:
									awaiter = q1tOtx5fjCpDGe19BayT(((UndoRedoQueue)nBcXEO5f3LWdaxHHADWC(ezFormatStringViewModel.InSight)).AddUndo((IUndoAction)new UndoFormatStringAddArgument(ezFormatStringViewModel.CommStep, ezFormatStringViewModel.Y7misQpeot, source.ToArray())));
									if (!awaiter.IsCompleted)
									{
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 19;
									}
									goto case 7;
								case 19:
									obj.propName = (string)pXTUvM5f7387RdRSSqVa(array[1], ljbMVp5f4QnMiCyBYXqL(52802), "");
									num3 = 3;
									continue;
								case 12:
									dataType = FormatStringDataType.FloatingPoint;
									num3 = 6;
									continue;
								case 3:
								{
									IEnumerable<FormatStringArgument> formatStringArguments = fhUY4uBLEMII4DUtd.FormatStringArguments;
									if (formatStringArguments.Count() > 0)
									{
										source = formatStringArguments.Select(obj._003CDoAddArgumentAsync_003Eb__0).Select(ezFormatStringViewModel.seSi2HSQVF).Select(ezFormatStringViewModel.lRbiqDooS8);
										num3 = 23;
										if (nOrJ2y5fpdssN5gybJVW())
										{
											continue;
										}
									}
									goto end_IL_0315;
								}
								case 8:
									goto end_IL_0315;
								case 28:
									if (!cvsCellRange.IsValid)
									{
										message = (string)uWoY0K5fF7uvy4G2dYTt(new string[6]
										{
											CdQUGaROfy7He9T0foW.KbIzwHEDLa(52814),
											property.DisplayName,
											(string)ljbMVp5f4QnMiCyBYXqL(52890),
											(string)gS691m5f9OYkckhOrHZL(property),
											(string)ljbMVp5f4QnMiCyBYXqL(53002),
											(string)igw3RG5fWyPl4ZEDnltK(property)
										});
										num3 = 32;
									}
									else
									{
										num3 = 12;
									}
									continue;
								case 11:
								case 16:
								case 29:
									formatStringArgViewModel = new FormatStringArgViewModel(ezFormatStringViewModel.FormatStringViewModel, cvsReferenceRange, dataType);
									num3 = 31;
									continue;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 15:
									return;
								case 13:
									cvsCellRange = uUCdA85fAd9RSaFsLSNj(cvsReferenceRange);
									num3 = 28;
									if (!UxjsyQ5fXQ8wJP7RV2bB())
									{
										continue;
									}
									goto case 17;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num3 = 30;
										continue;
									}
									goto case 4;
								case 24:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 5:
								case 26:
									break;
								case 0:
									if (fhUY4uBLEMII4DUtd != null)
									{
										obj = new _003C_003Ec__DisplayClass74_0();
										array = ((string)gS691m5f9OYkckhOrHZL(property)).Split(new char[1] { '.' });
										num3 = 25;
										if (UxjsyQ5fXQ8wJP7RV2bB())
										{
										}
									}
									else
									{
										cvsReferenceRange = new CvsReferenceRange
										{
											Range = new CvsCellRange(FRCgFh5f6posUBIryyYh(property))
										};
										LstmLi5fCH9Wfxa86Vu8(cvsReferenceRange, true);
										num3 = 13;
									}
									continue;
								case 6:
									cellType = XTCyih5fRchawACiCtsu(property);
									goto case 22;
								default:
									num3 = 22;
									continue;
								case 31:
									p9mNkJ5fTyZBxrTKmJ4T(formatStringArgViewModel, igw3RG5fWyPl4ZEDnltK(property));
									num3 = 9;
									continue;
								case 7:
									awaiter.GetResult();
									num3 = 21;
									continue;
								case 20:
									return;
								case 14:
									awaiter = q1tOtx5fjCpDGe19BayT(IUO7585f0h1LDsbL7Gud(ezFormatStringViewModel.InSight.UndoHandler, new UndoFormatStringAddArgument(ezFormatStringViewModel.CommStep, ezFormatStringViewModel.Y7misQpeot, new FormatStringArgViewModel[1] { formatStringArgViewModel })));
									num3 = 17;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 20;
									continue;
								case 27:
									fhUY4uBLEMII4DUtd = property as FhUY4uBLEMII4DUtd7;
									num3 = 0;
									continue;
								case 9:
									oLQtXe5fybLxfyeleEUR(formatStringArgViewModel, igw3RG5fWyPl4ZEDnltK(property));
									num3 = 14;
									if (UxjsyQ5fXQ8wJP7RV2bB())
									{
									}
									continue;
								case 30:
									num2 = (_003C_003E1__state = 1);
									num3 = 24;
									continue;
								case 21:
									goto end_IL_0315;
								case 4:
									awaiter.GetResult();
									num3 = 8;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									continue;
								case 22:
									switch (cellType)
									{
									case CellType.String:
										dataType = FormatStringDataType.String;
										num3 = 29;
										continue;
									case CellType.Bool:
									case CellType.Int:
										dataType = FormatStringDataType.Integer;
										_ = 0;
										num3 = (nOrJ2y5fpdssN5gybJVW() ? 11 : 5);
										continue;
									}
									goto case 11;
								case 32:
									LwaiK0XSBJ.Error(message);
									goto end_IL_0315;
								}
								goto IL_02a2;
								continue;
								end_IL_0315:
								break;
							}
							goto end_IL_006a;
							IL_02a2:
							_003C_003Eu__1 = default;
							num3 = 18;
							goto IL_0315;
							end_IL_006a:;
						}
						catch (Exception ex)
						{
							GN89ea5fMYEgfa07tIuM(LwaiK0XSBJ, LogLevel.Error, ljbMVp5f4QnMiCyBYXqL(53046), ex);
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
		internal static object gS691m5f9OYkckhOrHZL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ljbMVp5f4QnMiCyBYXqL(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pXTUvM5f7387RdRSSqVa(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nBcXEO5f3LWdaxHHADWC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter q1tOtx5fjCpDGe19BayT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation FRCgFh5f6posUBIryyYh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LstmLi5fCH9Wfxa86Vu8(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsReferenceRange)P_0).SetAbsolute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange uUCdA85fAd9RSaFsLSNj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CellType XTCyih5fRchawACiCtsu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).DataType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object igw3RG5fWyPl4ZEDnltK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).LocalizedCellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void p9mNkJ5fTyZBxrTKmJ4T(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatStringArgViewModel)P_0).LocalizedCellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oLQtXe5fybLxfyeleEUR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatStringArgViewModel)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IUO7585f0h1LDsbL7Gud(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uWoY0K5fF7uvy4G2dYTt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Concat((string[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GN89ea5fMYEgfa07tIuM(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nOrJ2y5fpdssN5gybJVW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UxjsyQ5fXQ8wJP7RV2bB()
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
	private struct _003CDoRemoveArgumentAsync_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!jQl6qk5fYw0cD7KuJ7kR()) ? 2 : 5);
			int num2 = default;
			int index = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							index = xYBlEj5fHEmUDtSXWhVx(ezFormatStringViewModel.FormatStringViewModel);
							_ = 0;
							if (jQl6qk5fYw0cD7KuJ7kR())
							{
								num3 = 5;
							}
							else
							{
								num3 = 7;
								if (!jQl6qk5fYw0cD7KuJ7kR())
								{
									goto IL_00f2;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (false)
							{
								goto IL_008c;
							}
						}
						goto IL_011e;
						IL_011e:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								return;
							case 8:
								break;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 0:
							case 5:
								awaiter = YrMUmC5fxm2yuZqyUGWg(ezFormatStringViewModel.RemoveArgumentAsync(ezFormatStringViewModel.Arguments[index]));
								goto case 1;
							case 3:
								goto IL_00f2;
							case 9:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 8;
								continue;
							case 1:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0039;
							}
							break;
						}
						goto IL_008c;
						IL_008c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 6;
						if (wxd3mb5fUCccZ2imr4yc())
						{
						}
						goto IL_011e;
						IL_00f2:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						goto IL_011e;
						end_IL_0039:;
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
					continue;
				case 1:
				case 2:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				ezFormatStringViewModel = _003C_003E4__this;
				num = 4;
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
		internal static int xYBlEj5fHEmUDtSXWhVx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatStringViewModel)P_0).GetCurrentArgumentIndex();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YrMUmC5fxm2yuZqyUGWg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jQl6qk5fYw0cD7KuJ7kR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wxd3mb5fUCccZ2imr4yc()
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
	private struct _003CRemoveArgumentAsync_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringViewModel _003C_003E4__this;

		public FormatStringArgViewModel arg;

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
			EzFormatStringViewModel ezFormatStringViewModel = default;
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
							awaiter = ((Task)TA6u4l5f2j30mt10UDYB(VbsmkO5fNYiWGGfVhiRa(ezFormatStringViewModel.InSight), new UndoFormatStringRemoveArgument(ezFormatStringViewModel.CommStep, ezFormatStringViewModel.Y7misQpeot, arg))).GetAwaiter();
							num3 = 5;
							if (1 == 0)
							{
								goto IL_0057;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!e0Oetl5fmW9TIgh7IVBl())
							{
								goto IL_00e4;
							}
						}
						goto IL_0104;
						IL_0131:
						d93ytn5fQOdRb7yNALRs();
						num3 = ((!e0Oetl5fmW9TIgh7IVBl()) ? 1 : 3);
						goto IL_0104;
						IL_00e4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_0131;
						IL_0057:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0104;
						IL_0104:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								break;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (true)
									{
										continue;
									}
									goto case 0;
								}
								goto case 9;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								break;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (!d93ytn5fQOdRb7yNALRs())
								{
									continue;
								}
								return;
							case 3:
							case 4:
								return;
							case 7:
								goto IL_00e4;
							default:
								goto IL_0131;
							case 9:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_0057;
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
				case 1:
				case 4:
					ezFormatStringViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (e0Oetl5fmW9TIgh7IVBl() ? 4 : 0);
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
		internal static object VbsmkO5fNYiWGGfVhiRa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TA6u4l5f2j30mt10UDYB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e0Oetl5fmW9TIgh7IVBl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d93ytn5fQOdRb7yNALRs()
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
	private struct _003CRemoveReferencesAsync_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IEnumerable<FormatStringArgViewModel> arguments;

		public EzFormatStringViewModel _003C_003E4__this;

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
			if (!L3HUok5f1wrDFGfQiulr())
			{
				num = 4;
				if (L3HUok5f1wrDFGfQiulr())
				{
				}
			}
			else
			{
				num = 5;
				if (L3HUok5f1wrDFGfQiulr())
				{
				}
			}
			int num2 = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = F74JfW5fupfSiDvWupiY(Task.WhenAll(arguments.Select(ezFormatStringViewModel.FormatStringViewModel.RemoveArgumentAsync).ToList()));
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (!mEXIb85fcR7bR49skSit())
							{
								goto IL_0132;
							}
						}
						goto IL_00b6;
						IL_0132:
						if (!awaiter.IsCompleted)
						{
							mEXIb85fcR7bR49skSit();
							num3 = ((!L3HUok5f1wrDFGfQiulr()) ? 5 : 4);
							goto IL_00b6;
						}
						goto IL_0158;
						IL_0158:
						awaiter.GetResult();
						goto end_IL_002e;
						IL_00b6:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 7:
								return;
							case 8:
								break;
							case 9:
								goto IL_0158;
							}
							break;
						}
						goto IL_0132;
						end_IL_002e:;
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
					ezFormatStringViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (mEXIb85fcR7bR49skSit())
					{
						continue;
					}
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
		internal static TaskAwaiter F74JfW5fupfSiDvWupiY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mEXIb85fcR7bR49skSit()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L3HUok5f1wrDFGfQiulr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private FormatStringViewModel rvCikDMtR5;

	private IFormatStringCellService cA0iP9B3CH;

	private Type Y7misQpeot;

	private static ILogger LwaiK0XSBJ;

	[CompilerGenerated]
	private CommStepViewModel jSaiGwhiPY;

	[CompilerGenerated]
	private readonly CvsCellLocation D96iBuwLVw;

	private CvsInSight EbmiZb292X;

	[CompilerGenerated]
	private IAsyncCommand RoBinoQIFe;

	private readonly AsyncRelayCommand wJyitR4Y1j;

	private readonly AsyncRelayCommand x1ViY9eOrC;

	[CompilerGenerated]
	private readonly AsyncRelayCommand<CellViewModel> QQwi0kcoqK;

	private readonly AsyncRelayCommand MJ4iVohqyH;

	[CompilerGenerated]
	private AsyncRelayCommand qx8iL16xlQ;

	[CompilerGenerated]
	private EventHandler D5iiJToqTI;

	public FormatStringViewModel FormatStringViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rvCikDMtR5;
		}
	}

	public CommStepViewModel CommStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jSaiGwhiPY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jSaiGwhiPY = value;
		}
	}

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D96iBuwLVw;
		}
	}

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EbmiZb292X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (uw3t6QcvM1hMMsR7mvc())
			{
				num = 1;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0089;
				}
			}
			goto IL_0052;
			IL_0052:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (EbmiZb292X != null)
					{
						num = 6;
						continue;
					}
					goto case 4;
				case 4:
					EbmiZb292X = value;
					break;
				case 5:
					oUGn5kcG2kb0jQp3E6B(EbmiZb292X, new EventHandler(TRKi4j3mED));
					num = 7;
					continue;
				case 6:
					EbmiZb292X.ResultsChanged -= TRKi4j3mED;
					num = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0089;
			IL_0089:
			if (EbmiZb292X != null)
			{
				num = 5;
				if (pKOZ2ccr5q2skZ4A2Ua())
				{
				}
				goto IL_0052;
			}
		}
	}

	public string LeadingText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)tv5Ygbc8yr7vlWRNfsg(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(omGiwgcBC9i3vWbNwko(InSight), new UndoFormatStringPropertyChange<string>(CommStep, Y7misQpeot, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29612), LeadingText, value));
		}
	}

	public string TrailingText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)v7RepucEaI5i7EYHwJx(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(InSight.UndoHandler, new UndoFormatStringPropertyChange<string>(CommStep, Y7misQpeot, (string)JRqnticoX5Y1UUYkjul(29638), TrailingText, value));
		}
	}

	public FormatStringTerminator Terminator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xbd5ZWcpIALYr6ribZk(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(InSight.UndoHandler, new UndoFormatStringPropertyChange<FormatStringTerminator>(CommStep, Y7misQpeot, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29666), Terminator, value));
		}
	}

	public List<FormatStringTerminator> Terminators
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rvCikDMtR5.Terminators;
		}
	}

	public bool UseDelimiter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return POn9jZcXDqFcO3oVKrl(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((UndoRedoQueue)omGiwgcBC9i3vWbNwko(InSight)).AddUndo((IUndoAction)new UndoFormatStringPropertyChange<bool>(CommStep, Y7misQpeot, (string)JRqnticoX5Y1UUYkjul(29690), UseDelimiter, value));
		}
	}

	public FormatStringDelimiterType WhichDelimiter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ELSrWjc9PDx9Rxuy32s(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(InSight.UndoHandler, new UndoFormatStringPropertyChange<FormatStringDelimiterType>(CommStep, Y7misQpeot, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29718), WhichDelimiter, value));
		}
	}

	public FormatStringDelimiter StandardDelimiter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Um50BDc4Yk8hcOhHMfx(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(omGiwgcBC9i3vWbNwko(InSight), new UndoFormatStringPropertyChange<FormatStringDelimiter>(CommStep, Y7misQpeot, (string)JRqnticoX5Y1UUYkjul(29750), StandardDelimiter, value));
		}
	}

	public string CustomDelimiter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)kmYcBHc7AEBb0n9ohhH(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qgZln0cqn4Zwvl9pLN2(omGiwgcBC9i3vWbNwko(InSight), new UndoFormatStringPropertyChange<string>(CommStep, Y7misQpeot, (string)JRqnticoX5Y1UUYkjul(29788), CustomDelimiter, value));
		}
	}

	public ObservableCollection<FormatStringArgViewModel> Arguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rvCikDMtR5?.Arguments;
		}
	}

	public string Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)CVfYpqc34MAoE6h3nbL(rvCikDMtR5);
		}
	}

	public string Output
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)AOJ1WlcjmX7kSX2xsOu(rvCikDMtR5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rvCikDMtR5.Output = value;
		}
	}

	public string TemporaryErrorMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rvCikDMtR5.TemporaryErrorMessage;
		}
	}

	public IAsyncCommand Accept
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RoBinoQIFe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RoBinoQIFe = value;
		}
	}

	public IAsyncCommand MoveUpCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wJyitR4Y1j;
		}
	}

	public IAsyncCommand MoveDownCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x1ViY9eOrC;
		}
	}

	public AsyncRelayCommand<CellViewModel> AddCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QQwi0kcoqK;
		}
	}

	public IAsyncCommand DeleteCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MJ4iVohqyH;
		}
	}

	public AsyncRelayCommand CloseFormatStringCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qx8iL16xlQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qx8iL16xlQ = value;
		}
	}

	public event EventHandler FormatStringClosed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uw3t6QcvM1hMMsR7mvc();
			int num;
			if (!pKOZ2ccr5q2skZ4A2Ua())
			{
				num = 1;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 6;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_0049;
			IL_00aa:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = Interlocked.CompareExchange(ref D5iiJToqTI, value2, eventHandler2);
			num = 5;
			goto IL_0049;
			IL_0049:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 6:
					break;
				default:
					num = 4;
					if (!pKOZ2ccr5q2skZ4A2Ua())
					{
						continue;
					}
					goto case 5;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 3;
				case 0:
				case 1:
					eventHandler = D5iiJToqTI;
					num = 3;
					if (pKOZ2ccr5q2skZ4A2Ua())
					{
					}
					continue;
				case 4:
					goto IL_00aa;
				case 3:
					eventHandler2 = eventHandler;
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			value2 = (EventHandler)KK7NB7cRkkYoWGMJ1U7(eventHandler2, value);
			goto IL_00aa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					eventHandler2 = eventHandler;
					num = 0;
					break;
				case 0:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto default;
				default:
					_ = 0;
					if (uw3t6QcvM1hMMsR7mvc())
					{
						num = 1;
						if (pKOZ2ccr5q2skZ4A2Ua())
						{
						}
					}
					else
					{
						num = 5;
					}
					break;
				case 2:
					eventHandler = D5iiJToqTI;
					num = 6;
					break;
				case 4:
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 1:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref D5iiJToqTI, value2, eventHandler2);
					goto case 4;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EzFormatStringViewModel(CommStepViewModel commStepVm, Type type, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		while (true)
		{
			switch (num)
			{
			case 8:
				MJ4iVohqyH = new AsyncRelayCommand(OJBivJ91hu, jZOixY22Da);
				num = 9;
				break;
			case 4:
				InSight = (CvsInSight)mA8hPLcPZw6YVlwRXyq(commStepVm);
				num = 5;
				if (uw3t6QcvM1hMMsR7mvc())
				{
					break;
				}
				goto case 2;
			case 2:
				CommStep = commStepVm;
				goto case 0;
			case 1:
			case 10:
				base._002Ector();
				num = 2;
				break;
			case 6:
				CloseFormatStringCommand = new AsyncRelayCommand(DoCloseFormatString, CanCloseFormatString);
				num = 8;
				break;
			case 11:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 1;
				num = ((!pKOZ2ccr5q2skZ4A2Ua()) ? 10 : 0);
				break;
			case 0:
			case 3:
				Y7misQpeot = type;
				D96iBuwLVw = loc;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				x1ViY9eOrC = new AsyncRelayCommand(nBViOLTZwB, U95iCjCsRJ);
				num = 12;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				wJyitR4Y1j = new AsyncRelayCommand(ELhiWNaKLw, AW0iTN5av9);
				num = 7;
				break;
			case 5:
				QQwi0kcoqK = new AsyncRelayCommand<CellViewModel>(WMSiw6IUQq, iJ4iHaNhhG);
				goto case 6;
			default:
				num = 6;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__5))]
	public Task InitializeAsync(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uw3t6QcvM1hMMsR7mvc();
		int num = ((!pKOZ2ccr5q2skZ4A2Ua()) ? 1 : 4);
		_003CInitializeAsync_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = InZ4WocZhvWvUWr6ZeI();
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine.cells = cells;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lrpiRasGpI(object P_0, FormatStringArgumentChangedArg P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UndoRedoQueue)omGiwgcBC9i3vWbNwko(InSight)).AddUndo((IUndoAction)new UndoFormatStringArgumentChanged(CommStep, Y7misQpeot, P_0 as FormatStringArgViewModel, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bhPoGIcbNWCxebvF9VI(rvCikDMtR5, expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TRKi4j3mED(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!uw3t6QcvM1hMMsR7mvc())
		{
			goto IL_001e;
		}
		goto IL_0072;
		IL_001e:
		CvsCell cvsCell = default;
		if (cvsCell == null)
		{
			goto IL_002e;
		}
		num = 6;
		goto IL_0072;
		IL_002e:
		string output = default;
		Output = output;
		num = 9;
		goto IL_0072;
		IL_0072:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			case 1:
				goto IL_002e;
			case 3:
				output = (string)JRqnticoX5Y1UUYkjul(29514);
				num = 8;
				continue;
			case 6:
				text = F15wZMckr0NG5Mpkpqn(cvsCell) as string;
				goto case 7;
			default:
				num = 7;
				continue;
			case 8:
				goto IL_00a9;
			case 0:
			case 5:
				output = text;
				num = 1;
				continue;
			case 7:
				if (text == null)
				{
					goto IL_002e;
				}
				goto case 0;
			case 9:
				return;
			}
			break;
			IL_00a9:
			cvsCell = (CvsCell)d3bJoecSgj4IcS4yEfM(EbmiZb292X.Results.Cells, CellLocation);
			pKOZ2ccr5q2skZ4A2Ua();
			if (uw3t6QcvM1hMMsR7mvc())
			{
				num = 4;
				continue;
			}
			num = 0;
			if (uw3t6QcvM1hMMsR7mvc())
			{
				continue;
			}
			return;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Q8Nil9Q4r7(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EHILKec6JP7Y4ZGtZ9p(wJyitR4Y1j);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AW0iTN5av9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rvCikDMtR5.CanMoveUp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoMoveUpAsync_003Ed__63))]
	private Task ELhiWNaKLw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pKOZ2ccr5q2skZ4A2Ua();
		int num;
		if (uw3t6QcvM1hMMsR7mvc())
		{
			num = 2;
			if (pKOZ2ccr5q2skZ4A2Ua())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_007b;
			}
		}
		goto IL_0048;
		IL_007b:
		_003CDoMoveUpAsync_003Ed__63 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (true)
		{
			goto IL_0048;
		}
		goto IL_0095;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				goto IL_007b;
			case 4:
				goto IL_0095;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_007b;
		IL_0095:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0048;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zLCijLN8wQ(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EHILKec6JP7Y4ZGtZ9p(x1ViY9eOrC);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool U95iCjCsRJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return a7GUrLcC1Igu8wynhcL(rvCikDMtR5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoMoveDownAsync_003Ed__69))]
	private Task nBViOLTZwB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDoMoveDownAsync_003Ed__69 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = InZ4WocZhvWvUWr6ZeI();
				uw3t6QcvM1hMMsR7mvc();
				if (!pKOZ2ccr5q2skZ4A2Ua())
				{
					num = 2;
					if (uw3t6QcvM1hMMsR7mvc())
					{
						continue;
					}
					goto default;
				}
				num = 5;
				if (uw3t6QcvM1hMMsR7mvc())
				{
					continue;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
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
	private bool iJ4iHaNhhG(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAddArgumentAsync_003Ed__74))]
	private Task WMSiw6IUQq(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!pKOZ2ccr5q2skZ4A2Ua())
		{
			num = 6;
			if (pKOZ2ccr5q2skZ4A2Ua())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0078;
		IL_002a:
		_003CDoAddArgumentAsync_003Ed__74 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 2;
		if (pKOZ2ccr5q2skZ4A2Ua())
		{
		}
		goto IL_0078;
		IL_0078:
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 4:
				stateMachine.property = P_0;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zRRiy2JIr2(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EHILKec6JP7Y4ZGtZ9p(MJ4iVohqyH);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool jZOixY22Da()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XPlkh2cAnybkuTrf9UI(FormatStringViewModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRemoveArgumentAsync_003Ed__80))]
	private Task OJBivJ91hu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoRemoveArgumentAsync_003Ed__80 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				do
				{
					stateMachine._003C_003Et__builder = InZ4WocZhvWvUWr6ZeI();
					pKOZ2ccr5q2skZ4A2Ua();
					if (!uw3t6QcvM1hMMsR7mvc())
					{
						num = 5;
						continue;
					}
					num = 2;
					break;
				}
				while (!uw3t6QcvM1hMMsR7mvc());
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveArgumentAsync_003Ed__81))]
	public Task RemoveArgumentAsync(FormatStringArgViewModel arg)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CRemoveArgumentAsync_003Ed__81 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				pKOZ2ccr5q2skZ4A2Ua();
				if (uw3t6QcvM1hMMsR7mvc())
				{
					num = 0;
					if (pKOZ2ccr5q2skZ4A2Ua())
					{
					}
				}
				else
				{
					num = 2;
				}
				break;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine.arg = arg;
				goto case 6;
			default:
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanCloseFormatString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DoCloseFormatString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		D5iiJToqTI?.Invoke(this, EventArgs.Empty);
		return (Task)U2sO28cWJm8O6hGAsms();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lDwiej7msU(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!(I5dMTHcTZ3nwLtRHr9m(this).GetProperty((string)VGP72Acy3XDrONhFjVj(P_1)) == null))
		{
			aUrJ4nc0ACvRkFaL57l(this, P_1.PropertyName);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferencesAsync_003Ed__92))]
	public Task RemoveReferencesAsync(IEnumerable<FormatStringArgViewModel> arguments)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRemoveReferencesAsync_003Ed__92 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.arguments = arguments;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!uw3t6QcvM1hMMsR7mvc()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (rvCikDMtR5 == null)
				{
					goto case 4;
				}
				goto case 1;
			case 4:
				InSight = null;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				nS7HJ9cFahYglbBruyw(rvCikDMtR5, new PropertyChangedEventHandler(lDwiej7msU));
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EzFormatStringViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Lp0yBZcMqtw8wmDbJ6B();
		LwaiK0XSBJ = LogManager.GetLogger<EzFormatStringViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private _003C_003Ef__AnonymousType1<_003C_003Ef__AnonymousType0<FormatStringArgument, string>, ExpressionTextBoxViewModel> seSi2HSQVF(_003C_003Ef__AnonymousType0<FormatStringArgument, string> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new
		{
			_003C_003Eh__TransparentIdentifier0 = P_0,
			expressionViewModel = new ExpressionTextBoxViewModel(InSight.FunctionTable, InSight.Sensor.ProcessorConstants, null, 1)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private FormatStringArgViewModel lRbiqDooS8(_003C_003Ef__AnonymousType1<_003C_003Ef__AnonymousType0<FormatStringArgument, string>, ExpressionTextBoxViewModel> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new FormatStringArgViewModel(FormatStringViewModel, P_0._003C_003Eh__TransparentIdentifier0.arg.Expression, P_0._003C_003Eh__TransparentIdentifier0.label, P_0.expressionViewModel, P_0._003C_003Eh__TransparentIdentifier0.arg.DataType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mA8hPLcPZw6YVlwRXyq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uw3t6QcvM1hMMsR7mvc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pKOZ2ccr5q2skZ4A2Ua()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder InZ4WocZhvWvUWr6ZeI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object omGiwgcBC9i3vWbNwko(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).UndoHandler;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bhPoGIcbNWCxebvF9VI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringViewModel)P_0).Refresh((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oUGn5kcG2kb0jQp3E6B(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JRqnticoX5Y1UUYkjul(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d3bJoecSgj4IcS4yEfM(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F15wZMckr0NG5Mpkpqn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tv5Ygbc8yr7vlWRNfsg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).LeadingText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qgZln0cqn4Zwvl9pLN2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v7RepucEaI5i7EYHwJx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).TrailingText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormatStringTerminator xbd5ZWcpIALYr6ribZk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).Terminator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool POn9jZcXDqFcO3oVKrl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).UseDelimiter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormatStringDelimiterType ELSrWjc9PDx9Rxuy32s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).WhichDelimiter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FormatStringDelimiter Um50BDc4Yk8hcOhHMfx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).StandardDelimiter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kmYcBHc7AEBb0n9ohhH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).CustomDelimiter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CVfYpqc34MAoE6h3nbL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AOJ1WlcjmX7kSX2xsOu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).Output;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EHILKec6JP7Y4ZGtZ9p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseRelayCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a7GUrLcC1Igu8wynhcL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).CanMoveDown();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XPlkh2cAnybkuTrf9UI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringViewModel)P_0).CanRemoveArgument();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KK7NB7cRkkYoWGMJ1U7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U2sO28cWJm8O6hGAsms()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type I5dMTHcTZ3nwLtRHr9m(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VGP72Acy3XDrONhFjVj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aUrJ4nc0ACvRkFaL57l(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.Mvvm.BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nS7HJ9cFahYglbBruyw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.InSight.Controls.ViewModels.BaseViewModel)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lp0yBZcMqtw8wmDbJ6B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
