using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.StepHeight3D;

[Export(typeof(StepHeight3DTool))]
public class StepHeight3DTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSetRange_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public StepHeight3DTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O8cXD4K4THZnona7It65();
			int num = (ui8TQLK4WNj9KyB3JhZl() ? 1 : 2);
			int num2 = default;
			(double, double) minMax = default;
			StepHeight3DTool stepHeight3DTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
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
							minMax = GetMinMax(ariGeQK4y1NwH32vwvi2(stepHeight3DTool.HeightDiff));
							_ = 0;
							num3 = ((!ui8TQLK4WNj9KyB3JhZl()) ? 3 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (O8cXD4K4THZnona7It65())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (O8cXD4K4THZnona7It65())
									{
									}
									continue;
								}
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 7:
								undoSetRange = new UndoSetRange<double>(stepHeight3DTool.Parent, stepHeight3DTool.Name, stepHeight3DTool.Min.CellName, stepHeight3DTool.Max.CellName, stepHeight3DTool.Min.Value, stepHeight3DTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 4;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter = ksNUsVK4MjHAxdke10qg(r6Rq8PK4FTbigE8JRIG9(igeDfkK407K88SRxDD3l(stepHeight3DTool.InSight), undoSetRange));
								goto case 2;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 9;
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
					break;
				case 4:
					stepHeight3DTool = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static double ariGeQK4y1NwH32vwvi2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object igeDfkK407K88SRxDD3l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r6Rq8PK4FTbigE8JRIG9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ksNUsVK4MjHAxdke10qg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ui8TQLK4WNj9KyB3JhZl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O8cXD4K4THZnona7It65()
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
	private struct _003CWriteFixturedGraphics_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public StepHeight3DTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			StepHeight3DTool stepHeight3DTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
								if (!NMl4feK4xTfY20EpvU09())
								{
									goto IL_0035;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 10;
								if (1 == 0)
								{
									return;
								}
							}
							goto IL_0066;
						}
						awaiter2 = _003C_003Eu__1;
						goto IL_0035;
						IL_0035:
						_003C_003Eu__1 = default;
						num3 = 11;
						goto IL_0066;
						IL_0066:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 7:
								break;
							case 11:
								num2 = (_003C_003E1__state = -1);
								goto case 3;
							default:
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 6:
								_003C_003Eu__1 = awaiter2;
								num3 = 8;
								if (NMl4feK4xTfY20EpvU09())
								{
									continue;
								}
								goto case 3;
							case 3:
								awaiter2.GetResult();
								num3 = 4;
								continue;
							case 4:
								awaiter = ((CvsCogSocket)cfm0V3K42fWEWfL1qTqK(stepHeight3DTool.InSight)).Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 1;
								continue;
							case 15:
								return;
							case 12:
								return;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (NMl4feK4xTfY20EpvU09())
								{
									continue;
								}
								goto case 0;
							case 0:
								if (awaiter2.IsCompleted)
								{
									goto case 3;
								}
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (DtyhJuK4msZcf9Gu4FAe())
								{
									num3 = 7;
									if (!DtyhJuK4msZcf9Gu4FAe())
									{
										continue;
									}
									goto case 13;
								}
								num3 = 6;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								if (DtyhJuK4msZcf9Gu4FAe())
								{
								}
								continue;
							case 14:
								awaiter2 = sbbZ10K4NhB6K6G5sjyg(((IEnumerable<CvsEditableDisplayGraphic>)FULHSOK4QcQWoYcABm1M(stepHeight3DTool)).Select(stepHeight3DTool.VYP3cK3OR4).WhenAll());
								num3 = 0;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								goto case 16;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 12;
								if (NMl4feK4xTfY20EpvU09())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__2 = default;
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_0066;
							}
							goto IL_0035;
							continue;
							end_IL_0066:
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
					if (DtyhJuK4msZcf9Gu4FAe())
					{
					}
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!NMl4feK4xTfY20EpvU09()) ? 3 : 0);
					break;
				case 0:
				case 1:
					stepHeight3DTool = _003C_003E4__this;
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
		internal static object FULHSOK4QcQWoYcABm1M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).GetEditableGraphics();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sbbZ10K4NhB6K6G5sjyg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cfm0V3K42fWEWfL1qTqK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NMl4feK4xTfY20EpvU09()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DtyhJuK4msZcf9Gu4FAe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private Plane3DViewModel OnN3j2JrPQ;

	[CompilerGenerated]
	private FloatViewModel RZo3CYfUk2;

	[CompilerGenerated]
	private IntViewModel dfg3OmAjGT;

	[CompilerGenerated]
	private FloatViewModel TKf3HUdhxd;

	[CompilerGenerated]
	private IntViewModel tpt3w58LLr;

	[CompilerGenerated]
	private FloatViewModel pEf3yFrqKX;

	[CompilerGenerated]
	private EditCompositeRegionViewModel LPw3x84u1U;

	[CompilerGenerated]
	private EditCompositeRegionViewModel IOG3vGEj0e;

	[CompilerGenerated]
	private CheckBoxViewModel rR43e4JaLU;

	[CompilerGenerated]
	private LineViewModel hUu32aq10J;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_StepHeightIcon;
		}
	}

	public override string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)hHwWBEbbPGg6smtMw3N(K1wqEcbBp7bOXjaBaEZ(), HeightDiff.Value);
		}
	}

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HeightDiff;
		}
	}

	public override bool AllowsAnyImageAsInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public FloatViewModel BaseHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RZo3CYfUk2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RZo3CYfUk2 = value;
		}
	}

	public IntViewModel BaseColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dfg3OmAjGT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dfg3OmAjGT = value;
		}
	}

	public FloatViewModel MeasureHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TKf3HUdhxd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TKf3HUdhxd = value;
		}
	}

	public IntViewModel MeasureColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tpt3w58LLr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tpt3w58LLr = value;
		}
	}

	public FloatViewModel HeightDiff
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pEf3yFrqKX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pEf3yFrqKX = value;
		}
	}

	public EditCompositeRegionViewModel BaseRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LPw3x84u1U;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LPw3x84u1U = value;
		}
	}

	public EditCompositeRegionViewModel MeasureRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IOG3vGEj0e;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IOG3vGEj0e = value;
		}
	}

	public CheckBoxViewModel Invert
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rR43e4JaLU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rR43e4JaLU = value;
		}
	}

	public LineViewModel OutputLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hUu32aq10J;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hUu32aq10J = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StepHeight3DTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		K95jdDbZ6dlegy7oovo(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__47))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnSetRange_003Ed__47 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder = b7jDp4bGdtoZP5OunGw();
				dgKGlLbrsb1AOJRaty9();
				num = ((!RbgTtnbPVf1TQw5parV()) ? 4 : 3);
				continue;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				if (true)
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
	public static (double min, double max) GetMinMax(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.1, -962.5, 962.5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!RbgTtnbPVf1TQw5parV())
		{
			num = 35;
		}
		else
		{
			num = 29;
			if (false)
			{
				return;
			}
		}
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 27:
				if (num2 != 2008302446)
				{
					num = 31;
				}
				else if (mgp6f7bkSH3VOc1sJnB(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9134)))
				{
					IntViewModel intViewModel2 = new IntViewModel(InSight, cells, loc, (string)YEWH1hbjTIDbDlS4656());
					zgVD4Kb7H1tFLhoNOdh(intViewModel2, true);
					MeasureColor = intViewModel2;
					num = 4;
				}
				else
				{
					num = 3;
				}
				break;
			case 14:
				return;
			case 26:
				AddProperty(Invert);
				num = 16;
				break;
			case 42:
				return;
			case 36:
				return;
			case 1:
				return;
			case 12:
				return;
			case 33:
				return;
			case 4:
				AddProperty(MeasureColor);
				num = 36;
				break;
			case 23:
				return;
			case 11:
				return;
			case 29:
				return;
			case 5:
				switch (num2)
				{
				case 2607905591u:
					if (!mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(9004)))
					{
						num = 21;
						goto end_IL_0399;
					}
					MeasureRegion = new EditCompositeRegionViewModel(InSight, cells, loc, (string)caTFPhbpJmE0W7qY8dS(), aU4IQJbE7BfYanH6Hyg(InputImage), IsInitialized, mustBeExtrudeable: true);
					num = 15;
					goto end_IL_0399;
				default:
					num = 1;
					goto end_IL_0399;
				case 2175226210u:
					break;
				}
				if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(8956)))
				{
					HeightDiff = new FloatViewModel(InSight, cells, loc, (string)M8Tl3Vb8rb5pHcdFHV4());
					AddProperty(HeightDiff);
					return;
				}
				num = 38;
				if (dgKGlLbrsb1AOJRaty9())
				{
					break;
				}
				goto case 24;
			case 13:
				return;
			case 18:
				if (num2 != 2046460609)
				{
					num = 5;
					break;
				}
				if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(6122)))
				{
					Invert = new CheckBoxViewModel(InSight, cells, loc, (string)aovKu0bXExARROC6S6Q(), IsInitialized);
					num = 26;
					break;
				}
				num = 30;
				if (!RbgTtnbPVf1TQw5parV())
				{
					break;
				}
				return;
			case 32:
				if (num2 <= 2008302446)
				{
					if (num2 <= 1017635769)
					{
						if (num2 != 449038019)
						{
							num = 39;
							break;
						}
						if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(9162)))
						{
							InputPlane = new InputPlaneViewModel(this, cells, loc, Resources.InputPlane, IsInitialized, OnN3j2JrPQ);
							AddProperty(InputPlane);
							num = 23;
							break;
						}
						num = 6;
						if (dgKGlLbrsb1AOJRaty9())
						{
							break;
						}
						return;
					}
					if (num2 == 1121964790)
					{
						if (mgp6f7bkSH3VOc1sJnB(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9034)))
						{
							OutputLine = new LineViewModel(InSight, cells, loc, (string)wesUpQb9TEyWfnlvL6y(), showStartArrow: false, showEndArrow: true);
							num = 9;
							if (0 == 0)
							{
								break;
							}
							goto case 0;
						}
						num = 37;
						break;
					}
					num = 24;
					break;
				}
				if (num2 > 2607905591u)
				{
					if (num2 <= 3255580271u)
					{
						if (num2 != 3162943052u)
						{
							num = 40;
							break;
						}
						if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(8980)))
						{
							BaseRegion = new EditCompositeRegionViewModel(InSight, cells, loc, Resources.Region, aU4IQJbE7BfYanH6Hyg(InputImage), IsInitialized, mustBeExtrudeable: true);
							AddProperty(BaseRegion);
						}
						return;
					}
					if (num2 != 3733526636u)
					{
						num = 25;
						if (0 == 0)
						{
							break;
						}
						goto case 5;
					}
					if (mgp6f7bkSH3VOc1sJnB(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9186)))
					{
						OnN3j2JrPQ = new Plane3DViewModel(InSight, cells, loc, Resources.ReferencePlane);
						num = 2;
					}
					else
					{
						num = 42;
					}
					break;
				}
				num = 18;
				if (1 == 0)
				{
					return;
				}
				break;
			case 7:
				AddProperty(Min);
				return;
			case 25:
				if (num2 != 4089259843u)
				{
					num = 19;
				}
				else if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(9058)))
				{
					FloatViewModel floatViewModel2 = new FloatViewModel(InSight, cells, loc, (string)ruZQQ2b4g9rdsDorMcR());
					zgVD4Kb7H1tFLhoNOdh(floatViewModel2, true);
					BaseHeight = floatViewModel2;
					AddProperty(BaseHeight);
					num = 22;
				}
				else
				{
					num = 28;
					if (!dgKGlLbrsb1AOJRaty9())
					{
						return;
					}
				}
				break;
			case 16:
				return;
			case 0:
			case 35:
				num2 = P5LvX0boKa2et98Wi0R(relativeCellName);
				num = 32;
				break;
			case 40:
			{
				if (num2 != 3255580271u)
				{
					return;
				}
				if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(9082)))
				{
					num = 41;
					break;
				}
				IntViewModel intViewModel = new IntViewModel(InSight, cells, loc, (string)L9AbdLb3IDel2YUbGQs());
				zgVD4Kb7H1tFLhoNOdh(intViewModel, true);
				BaseColor = intViewModel;
				num = 10;
				break;
			}
			case 21:
				return;
			case 41:
				return;
			default:
				num = 17;
				break;
			case 34:
				AddProperty(MeasureHeight);
				return;
			case 39:
				switch (num2)
				{
				default:
					num = 8;
					if (false)
					{
						return;
					}
					break;
				case 781469175u:
					if (mgp6f7bkSH3VOc1sJnB(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)))
					{
						Min = new EditFloatViewModel(InSight, cells, loc, (string)Cn4UV8bqsmuOKO6B9ZS());
						num = 7;
						break;
					}
					return;
				case 1017635769u:
					if (mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(6138)))
					{
						Max = new EditFloatViewModel(InSight, cells, loc, Resources.CsBVSmiZVr());
						AddProperty(Max);
						num = 13;
						break;
					}
					num = 33;
					if (1 == 0)
					{
						return;
					}
					break;
				}
				break;
			case 3:
				return;
			case 28:
				return;
			case 31:
				return;
			case 30:
				return;
			case 15:
				AddProperty(MeasureRegion);
				num = 14;
				break;
			case 2:
				zgVD4Kb7H1tFLhoNOdh(OnN3j2JrPQ, true);
				num = 43;
				if (RbgTtnbPVf1TQw5parV())
				{
					return;
				}
				break;
			case 6:
				return;
			case 9:
				AddProperty(OutputLine);
				num = 12;
				if (RbgTtnbPVf1TQw5parV())
				{
					return;
				}
				break;
			case 37:
				return;
			case 19:
				return;
			case 24:
				if (num2 == 1860880000)
				{
					if (!mgp6f7bkSH3VOc1sJnB(relativeCellName, WFtILCbSBJ4X6ymQYyJ(9104)))
					{
						return;
					}
					FloatViewModel floatViewModel = new FloatViewModel(InSight, cells, loc, Resources.MeasureHeight);
					zgVD4Kb7H1tFLhoNOdh(floatViewModel, true);
					MeasureHeight = floatViewModel;
					num = 34;
				}
				else
				{
					num = 27;
				}
				break;
			case 10:
				AddProperty(BaseColor);
				num = 20;
				break;
			case 22:
				return;
			case 20:
				return;
			case 8:
				return;
			case 38:
				return;
			case 17:
				return;
			case 43:
				return;
				end_IL_0399:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshGraphics(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (RbgTtnbPVf1TQw5parV() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				IKCDkOb6KMAYamiSZ3r(BaseRegion, BaseHeight, BaseColor);
				break;
			default:
				num = 2;
				if (!RbgTtnbPVf1TQw5parV())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				base.RefreshGraphics(cells);
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			KIR3btVYIs(MeasureRegion, MeasureHeight, MeasureColor);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[3]
		{
			BaseRegion?.Graphic,
			MeasureRegion?.Graphic,
			OutputLine?.Line
		}.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g != null;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__52))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CWriteFixturedGraphics_003Ed__52 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = b7jDp4bGdtoZP5OunGw();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				RbgTtnbPVf1TQw5parV();
				num = (dgKGlLbrsb1AOJRaty9() ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static void KIR3btVYIs(EditCompositeRegionViewModel P_0, FloatViewModel P_1, IntViewModel P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00b0;
		IL_001a:
		int valueOrDefault = default;
		CvsDisplayableComposite cvsDisplayableComposite = default;
		if (valueOrDefault == 16711680)
		{
			num = 2;
		}
		else
		{
			O7qG1ZbTSjJFjNQZAka(cvsDisplayableComposite, Color.Green, vUTdl7bys4aAnnYbkPS());
			num = 11;
		}
		goto IL_00b0;
		IL_00b0:
		int? num2 = default;
		int? num4 = default;
		while (true)
		{
			int? num3;
			switch (num)
			{
			case 3:
				break;
			case 7:
				cvsDisplayableComposite = dAJXyabC9NgllfatXyj(P_0) as CvsDisplayableComposite;
				dgKGlLbrsb1AOJRaty9();
				num = ((!RbgTtnbPVf1TQw5parV()) ? 6 : 0);
				continue;
			case 0:
				return;
			case 8:
				return;
			case 1:
			case 6:
				if (cvsDisplayableComposite != null)
				{
					num = 5;
					continue;
				}
				return;
			case 9:
				num3 = num2;
				goto IL_0091;
			default:
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				((CvsGraphic)Fy4ZcObAi27dXISqaCO(cvsDisplayableComposite)).Label = (string)((P_1 == null || P_1.Error) ? null : hHwWBEbbPGg6smtMw3N(Resources.DEKmM9764B(), U8NoT6bRpwjWV54dctx(P_1)));
				if (P_2 != null)
				{
					num3 = P_2.Value;
					goto IL_0091;
				}
				num = 4;
				continue;
			case 10:
				valueOrDefault = num4.GetValueOrDefault();
				num = 3;
				continue;
			case 2:
				O7qG1ZbTSjJFjNQZAka(cvsDisplayableComposite, Color.Red, sBUYGxbWbsLwiX5Fx0R());
				return;
			case 4:
				num2 = null;
				num = 9;
				continue;
			case 11:
				return;
				IL_0091:
				num4 = num3;
				if (num4.HasValue)
				{
					goto case 10;
				}
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task VYP3cK3OR4(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)zQIJuBbFsCUMEdN5RpP(InSight, XdI9rlb0dUjNMXJnHL9(P_0), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K95jdDbZ6dlegy7oovo(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dgKGlLbrsb1AOJRaty9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RbgTtnbPVf1TQw5parV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K1wqEcbBp7bOXjaBaEZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DEKmM9764B();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hHwWBEbbPGg6smtMw3N(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder b7jDp4bGdtoZP5OunGw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint P5LvX0boKa2et98Wi0R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WFtILCbSBJ4X6ymQYyJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mgp6f7bkSH3VOc1sJnB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M8Tl3Vb8rb5pHcdFHV4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cn4UV8bqsmuOKO6B9ZS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation aU4IQJbE7BfYanH6Hyg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object caTFPhbpJmE0W7qY8dS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aovKu0bXExARROC6S6Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wesUpQb9TEyWfnlvL6y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ruZQQ2b4g9rdsDorMcR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BaseHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zgVD4Kb7H1tFLhoNOdh(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L9AbdLb3IDel2YUbGQs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BaseColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YEWH1hbjTIDbDlS4656()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MeasureColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IKCDkOb6KMAYamiSZ3r(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KIR3btVYIs((EditCompositeRegionViewModel)P_0, (FloatViewModel)P_1, (IntViewModel)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dAJXyabC9NgllfatXyj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fy4ZcObAi27dXISqaCO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double U8NoT6bRpwjWV54dctx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color sBUYGxbWbsLwiX5Fx0R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.OrangeRed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O7qG1ZbTSjJFjNQZAka(object P_0, Color P_1, Color P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.dahdGvXUmN((CvsDisplayableComposite)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color vUTdl7bys4aAnnYbkPS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.LimeGreen;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation XdI9rlb0dUjNMXJnHL9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zQIJuBbFsCUMEdN5RpP(object P_0, CvsCellLocation loc, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
	}
}
