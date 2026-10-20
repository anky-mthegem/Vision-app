using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance;

[Export(typeof(LineToLineDistanceTool))]
public class LineToLineDistanceTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSetRange_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineToLineDistanceTool _003C_003E4__this;

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
			(double, double) minMax = default;
			LineToLineDistanceTool lineToLineDistanceTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(A656P8KxZXS8MZ2sbJMC(lineToLineDistanceTool.Distance));
							num3 = 3;
							goto IL_006a;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0039;
						IL_0039:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_006a;
						IL_006a:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 6:
								break;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 8;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 0:
								return;
							case 2:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 4:
								awaiter = lG0yRvKxSnJAnbeGMgne(ULJeEhKxoFLsF1UJJpYN(E1x2xmKxGjX6fikkqxUQ(lineToLineDistanceTool.InSight), undoSetRange));
								_ = 1;
								num3 = ((!D7rqy6KxP0eytJFw4aoq()) ? 9 : 5);
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								undoSetRange = new UndoSetRange<double>(lineToLineDistanceTool.Parent, (string)C1d12oKxBs5smsnnBKxy(lineToLineDistanceTool), lineToLineDistanceTool.Min.CellName, (string)HSxorJKxbbtGHnTxXy7y(lineToLineDistanceTool.Max), lineToLineDistanceTool.Min.Value, lineToLineDistanceTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 4;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_006a;
							}
							goto IL_0039;
							continue;
							end_IL_006a:
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
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!D7rqy6KxP0eytJFw4aoq())
					{
						num = 5;
						break;
					}
					num = 4;
					if (D7rqy6KxP0eytJFw4aoq())
					{
					}
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					lineToLineDistanceTool = _003C_003E4__this;
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
		internal static double A656P8KxZXS8MZ2sbJMC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C1d12oKxBs5smsnnBKxy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HSxorJKxbbtGHnTxXy7y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object E1x2xmKxGjX6fikkqxUQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ULJeEhKxoFLsF1UJJpYN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lG0yRvKxSnJAnbeGMgne(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xEPilTKxrQ8hBIWr4rPQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D7rqy6KxP0eytJFw4aoq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InputLineViewModel bgSTgfoVjh;

	private InputLineViewModel U3BTMHmJcY;

	[CompilerGenerated]
	private ListBoxViewModel c0fTRUHIMO;

	[CompilerGenerated]
	private FloatViewModel HPFT4JeCVH;

	[CompilerGenerated]
	private LineViewModel KDrTluVwom;

	[CompilerGenerated]
	private LineViewModel iF3TTcNpTY;

	[CompilerGenerated]
	private CheckBoxViewModel ASvTW63Xv6;

	public InputLineViewModel InputLine0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bgSTgfoVjh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
				case 1:
					if (bgSTgfoVjh != value)
					{
						num = 4;
						break;
					}
					return;
				case 2:
					FQnNTp6XjPfuEEbrZLm(bgSTgfoVjh, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					dW23eQ6r5cG3pQVpfQ3();
					if (vSZYMv6vxCyWvwexGXQ())
					{
						num = 6;
						if (vSZYMv6vxCyWvwexGXQ())
						{
							break;
						}
						goto case 7;
					}
					num = 0;
					if (true)
					{
						break;
					}
					goto case 3;
				case 7:
					if (bgSTgfoVjh != null)
					{
						goto case 0;
					}
					return;
				case 3:
				case 6:
					bgSTgfoVjh = value;
					goto case 7;
				default:
					num = 7;
					break;
				case 4:
					if (bgSTgfoVjh != null)
					{
						num = 2;
						break;
					}
					goto case 3;
				case 0:
				case 5:
					ajQh2V69av7IAJPsD3J(bgSTgfoVjh, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 8:
					return;
				}
			}
		}
	}

	public InputLineViewModel InputLine1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U3BTMHmJcY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 6:
					U3BTMHmJcY = value;
					goto default;
				case 7:
					if (U3BTMHmJcY != value)
					{
						num = 1;
						break;
					}
					return;
				case 5:
					U3BTMHmJcY.PropertyChanged -= SourceLink_PropertyChanged;
					dW23eQ6r5cG3pQVpfQ3();
					num = (vSZYMv6vxCyWvwexGXQ() ? 6 : 2);
					break;
				case 1:
					if (U3BTMHmJcY != null)
					{
						num = 5;
						break;
					}
					goto case 3;
				default:
					if (U3BTMHmJcY != null)
					{
						num = 0;
						break;
					}
					return;
				case 0:
					ajQh2V69av7IAJPsD3J(U3BTMHmJcY, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 8:
					return;
				}
			}
		}
	}

	public ListBoxViewModel MeasurementType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c0fTRUHIMO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c0fTRUHIMO = value;
		}
	}

	public FloatViewModel Distance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HPFT4JeCVH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HPFT4JeCVH = value;
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
			return KDrTluVwom;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KDrTluVwom = value;
		}
	}

	public LineViewModel PixelLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iF3TTcNpTY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iF3TTcNpTY = value;
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
			return ASvTW63Xv6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ASvTW63Xv6 = value;
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
			return (string)UdaMML6o7rpdh51EfhW(Resources.X07tjUoaZN(), XEQVUp64Y25HH66ZhXg(Distance));
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
			return Distance;
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
			return XAMLGraphicKeys.Tools_DistanceIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineToLineDistanceTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ykRBIj6P0CdHlHPwVey();
		KVSJgm6Z60iFSDT52vc(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
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
			case 0:
				InputLine0 = null;
				_ = 1;
				if (!dW23eQ6r5cG3pQVpfQ3())
				{
					num = 3;
					if (dW23eQ6r5cG3pQVpfQ3())
					{
					}
				}
				else
				{
					num = 4;
				}
				continue;
			case 1:
			case 3:
				InputLine1 = null;
				break;
			case 5:
				return;
			}
			base.InternalPreParse();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 30;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 20:
				return;
			case 24:
				AddProperty(InputLine0);
				num = 3;
				break;
			case 8:
				return;
			default:
				num = 28;
				if (0 == 0)
				{
					break;
				}
				goto case 25;
			case 25:
				switch (num2)
				{
				default:
					return;
				case 3345077989u:
					if (relativeCellName == (string)mPljZ16bpVBO8urbqcT(21646))
					{
						PixelLine = new LineViewModel(InSight, cells, loc, Resources.PixelLine, showStartArrow: true, showEndArrow: true);
						num = 6;
						break;
					}
					return;
				case 3554238594u:
					if (relativeCellName == (string)mPljZ16bpVBO8urbqcT(26158))
					{
						Distance = new FloatViewModel(InSight, cells, loc, (string)cxNNUl6k1qMR8BrXe1b());
						AddProperty(Distance);
						num = 1;
					}
					else
					{
						num = 26;
					}
					break;
				}
				break;
			case 9:
				return;
			case 21:
				if (num2 != 693400640)
				{
					num = 27;
				}
				else if (MTTeA06G03ihjDhKNeK(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21622)))
				{
					InputLine1 = new InputLineViewModel(this, cells, loc, string.Format(Resources.InputLine0, mPljZ16bpVBO8urbqcT(21668)), IsInitialized);
					num = 0;
				}
				else
				{
					num = 7;
				}
				break;
			case 30:
				num2 = grPsT96BeuHRQxyND3M(relativeCellName);
				num = 4;
				break;
			case 10:
				if (num2 != 2046460609)
				{
					return;
				}
				if (!MTTeA06G03ihjDhKNeK(relativeCellName, mPljZ16bpVBO8urbqcT(6122)))
				{
					num = 8;
					break;
				}
				Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
				num = 5;
				if (!dW23eQ6r5cG3pQVpfQ3())
				{
					break;
				}
				return;
			case 4:
				if (num2 <= 1017635769)
				{
					_ = 1;
					if (dW23eQ6r5cG3pQVpfQ3())
					{
						num = 16;
						if (vSZYMv6vxCyWvwexGXQ())
						{
							break;
						}
						goto case 21;
					}
					num = 14;
					if (dW23eQ6r5cG3pQVpfQ3())
					{
					}
					break;
				}
				if (num2 > 2046460609)
				{
					if (num2 != 2884501787u)
					{
						num = 25;
						break;
					}
					if (!MTTeA06G03ihjDhKNeK(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(26498)))
					{
						return;
					}
					MeasurementType = new ListBoxViewModel(InSight, cells, loc, (string)qggXms6SfjMr6A1Id4X());
					num = 11;
				}
				else if (num2 == 1121964790)
				{
					if (!MTTeA06G03ihjDhKNeK(relativeCellName, mPljZ16bpVBO8urbqcT(9034)))
					{
						return;
					}
					OutputLine = new LineViewModel(InSight, cells, loc, (string)Jrakyd6qY7xCycKhifm(), showStartArrow: true, showEndArrow: true);
					num = 19;
				}
				else
				{
					num = 10;
				}
				break;
			case 27:
				if (num2 != 710178259)
				{
					num = 29;
				}
				else if (MTTeA06G03ihjDhKNeK(relativeCellName, mPljZ16bpVBO8urbqcT(21598)))
				{
					InputLine0 = new InputLineViewModel(this, cells, loc, (string)UdaMML6o7rpdh51EfhW(Resources.InputLine0, mPljZ16bpVBO8urbqcT(1838)), IsInitialized);
					num = 24;
				}
				else
				{
					num = 23;
				}
				break;
			case 26:
				return;
			case 2:
			case 14:
				if (num2 <= 710178259)
				{
					num = 21;
					break;
				}
				if (num2 == 781469175)
				{
					if (!MTTeA06G03ihjDhKNeK(relativeCellName, mPljZ16bpVBO8urbqcT(6148)))
					{
						return;
					}
					Min = new EditFloatViewModel(InSight, cells, loc, Resources.MjMVZlHh3y());
					num = 17;
					if (false)
					{
						return;
					}
					break;
				}
				num = 15;
				if (true)
				{
					break;
				}
				goto case 17;
			case 1:
				return;
			case 22:
				return;
			case 13:
				return;
			case 28:
				return;
			case 0:
				AddProperty(InputLine1);
				num = 22;
				if (!vSZYMv6vxCyWvwexGXQ())
				{
					return;
				}
				break;
			case 18:
				return;
			case 6:
				AddProperty(PixelLine);
				num = 31;
				break;
			case 11:
				AddProperty(MeasurementType);
				num = 12;
				break;
			case 15:
				if (num2 == 1017635769)
				{
					if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
					{
						num = 18;
						break;
					}
					Max = new EditFloatViewModel(InSight, cells, loc, (string)sTPAbX68LInrbs3f4oy());
					AddProperty(Max);
					return;
				}
				return;
			case 29:
				return;
			case 17:
				AddProperty(Min);
				return;
			case 12:
				return;
			case 7:
				return;
			case 3:
				return;
			case 19:
				AddProperty(OutputLine);
				num = 13;
				break;
			case 16:
				return;
			case 23:
				return;
			case 5:
				AddProperty(Invert);
				num = 20;
				if (!vSZYMv6vxCyWvwexGXQ())
				{
					return;
				}
				break;
			case 31:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!dW23eQ6r5cG3pQVpfQ3())
		{
		}
		List<CvsEditableDisplayGraphic> list = default;
		CvsDisplayableLine cvsDisplayableLine = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				num = 4;
				if (!dW23eQ6r5cG3pQVpfQ3())
				{
					continue;
				}
				goto case 4;
			case 4:
			{
				LineViewModel pixelLine = PixelLine;
				if (pixelLine == null)
				{
					_ = 0;
					num = (vSZYMv6vxCyWvwexGXQ() ? 1 : 5);
					continue;
				}
				obj = pixelLine.Line;
				goto IL_0077;
			}
			default:
				list.Add(cvsDisplayableLine);
				num = 6;
				continue;
			case 1:
			case 2:
				obj = null;
				goto IL_0077;
			case 6:
				break;
				IL_0077:
				cvsDisplayableLine = (CvsDisplayableLine)obj;
				if (cvsDisplayableLine == null)
				{
					break;
				}
				goto default;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])nk13QD6EQadXDpw8BXP(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			default:
				list.Add(EditableGraphicHelper.ConstructLine(EWxX3G6p4e1AFynswfN(PixelLine), cells, EWxX3G6p4e1AFynswfN(OutputLine).ToString(absoluteRow: true, absoluteColumn: true)));
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				_ = 1;
				num = (dW23eQ6r5cG3pQVpfQ3() ? 3 : 4);
				continue;
			case 1:
			case 4:
				if (reqDataType != CellType.Line)
				{
					break;
				}
				goto default;
			case 5:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])nk13QD6EQadXDpw8BXP(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__42))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnSetRange_003Ed__42 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (vSZYMv6vxCyWvwexGXQ())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 4;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003Et__builder = pAHjTM67kgUonRMuvK5();
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
	public static (double min, double max) GetMinMax(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.05, 0.0, 9999999999.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (InSight != null)
				{
					num = 0;
					break;
				}
				return;
			case 5:
				base.RefreshPotentialDependencies();
				num = 2;
				if (dW23eQ6r5cG3pQVpfQ3())
				{
				}
				break;
			default:
			{
				InputLineViewModel inputLine2 = InputLine1;
				if (inputLine2 == null)
				{
					num = 1;
					break;
				}
				inputLine2.RefreshLinks();
				num = 8;
				break;
			}
			case 1:
				return;
			case 0:
			{
				InputLineViewModel inputLine = InputLine0;
				if (inputLine != null)
				{
					inputLine.RefreshLinks();
					goto default;
				}
				vSZYMv6vxCyWvwexGXQ();
				if (dW23eQ6r5cG3pQVpfQ3())
				{
					num = 6;
					break;
				}
				num = 7;
				if (1 == 0)
				{
					return;
				}
				break;
			}
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ykRBIj6P0CdHlHPwVey()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KVSJgm6Z60iFSDT52vc(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vSZYMv6vxCyWvwexGXQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dW23eQ6r5cG3pQVpfQ3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint grPsT96BeuHRQxyND3M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mPljZ16bpVBO8urbqcT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MTTeA06G03ihjDhKNeK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UdaMML6o7rpdh51EfhW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qggXms6SfjMr6A1Id4X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MeasurementType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cxNNUl6k1qMR8BrXe1b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Distance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sTPAbX68LInrbs3f4oy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Jrakyd6qY7xCycKhifm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nk13QD6EQadXDpw8BXP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation EWxX3G6p4e1AFynswfN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FQnNTp6XjPfuEEbrZLm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ajQh2V69av7IAJPsD3J(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XEQVUp64Y25HH66ZhXg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder pAHjTM67kgUonRMuvK5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
