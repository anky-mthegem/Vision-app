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

[Export(typeof(PointToLineDistanceTool))]
public class PointToLineDistanceTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSetRange_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PointToLineDistanceTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VIZcLtKxkgWBWyddxRMk();
			int num;
			if (!T4OrHQKx8WcVcBbH4eLr())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (T4OrHQKx8WcVcBbH4eLr())
				{
				}
			}
			goto IL_0231;
			IL_002a:
			PointToLineDistanceTool pointToLineDistanceTool = _003C_003E4__this;
			num = 2;
			goto IL_0231;
			IL_0231:
			int num2 = default;
			(double, double) minMax = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> action = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (T4OrHQKx8WcVcBbH4eLr())
					{
					}
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(pointToLineDistanceTool.Distance.Value);
							num3 = 8;
							if (T4OrHQKx8WcVcBbH4eLr())
							{
								goto IL_0081;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
						}
						goto IL_00e3;
						IL_00e3:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 6:
								return;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 5:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (!VIZcLtKxkgWBWyddxRMk())
									{
										num3 = 7;
										if (T4OrHQKx8WcVcBbH4eLr())
										{
										}
										continue;
									}
									num3 = 2;
									if (VIZcLtKxkgWBWyddxRMk())
									{
										continue;
									}
									goto case 1;
								}
								goto case 10;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (VIZcLtKxkgWBWyddxRMk())
								{
									continue;
								}
								goto case 8;
							case 8:
								action = new UndoSetRange<double>(pointToLineDistanceTool.Parent, (string)zuZgvwKxqkq3wqeOTYho(pointToLineDistanceTool), (string)jhH30kKxEZbZ6apFBsbK(pointToLineDistanceTool.Min), (string)jhH30kKxEZbZ6apFBsbK(pointToLineDistanceTool.Max), pointToLineDistanceTool.Min.Value, pointToLineDistanceTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 9;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_00e3;
							}
							goto IL_0081;
							continue;
							end_IL_00e3:
							break;
						}
						goto end_IL_005a;
						IL_0081:
						awaiter = DOcTkBKxX8BKkWMd6ykN(((UndoRedoQueue)vDYdKdKxpAbHpOFoyHaN(pointToLineDistanceTool.InSight)).AddUndo((IUndoAction)action));
						num3 = 5;
						if (false)
						{
							return;
						}
						goto IL_00e3;
						end_IL_005a:;
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
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
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
		internal static object zuZgvwKxqkq3wqeOTYho(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jhH30kKxEZbZ6apFBsbK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vDYdKdKxpAbHpOFoyHaN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DOcTkBKxX8BKkWMd6ykN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VIZcLtKxkgWBWyddxRMk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T4OrHQKx8WcVcBbH4eLr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InputPointViewModel UaHTy54XWs;

	private InputLineViewModel On8Txt432N;

	[CompilerGenerated]
	private FloatViewModel D1xTv8v4nV;

	[CompilerGenerated]
	private LineViewModel yVoTeA2mSy;

	[CompilerGenerated]
	private LineViewModel MKuT2VeXax;

	[CompilerGenerated]
	private CheckBoxViewModel PRTTqK83ud;

	public InputPointViewModel InputPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UaHTy54XWs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!UXjEQQ63vA6RvajlTpo())
			{
				goto IL_001e;
			}
			goto IL_0067;
			IL_001e:
			if (UaHTy54XWs != null)
			{
				num = 4;
				goto IL_0067;
			}
			return;
			IL_0067:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 3:
					if (UaHTy54XWs == null)
					{
						goto case 7;
					}
					goto case 2;
				case 7:
					UaHTy54XWs = value;
					break;
				default:
					num = 5;
					if (UXjEQQ63vA6RvajlTpo())
					{
						continue;
					}
					goto case 4;
				case 4:
					Vtw9w76YDZFKw8Sy9Kg(UaHTy54XWs, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					continue;
				case 0:
					if (UaHTy54XWs != value)
					{
						UXjEQQ63vA6RvajlTpo();
						if (d77e7u6jEOmw5OVq5Iy())
						{
							num = 6;
							continue;
						}
						num = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					return;
				case 2:
				case 6:
					UaHTy54XWs.PropertyChanged -= SourceLink_PropertyChanged;
					num = 7;
					continue;
				case 8:
					return;
				}
				break;
			}
			goto IL_001e;
		}
	}

	public InputLineViewModel InputLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return On8Txt432N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d77e7u6jEOmw5OVq5Iy();
			int num = ((!UXjEQQ63vA6RvajlTpo()) ? 1 : 7);
			while (true)
			{
				switch (num)
				{
				case 6:
					if (On8Txt432N != null)
					{
						num = 3;
						break;
					}
					return;
				case 3:
					Vtw9w76YDZFKw8Sy9Kg(On8Txt432N, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 1:
				case 2:
					On8Txt432N.PropertyChanged -= SourceLink_PropertyChanged;
					num = 4;
					break;
				case 0:
				case 7:
					if (On8Txt432N != value)
					{
						num = 5;
						break;
					}
					return;
				case 5:
					if (On8Txt432N != null)
					{
						goto case 1;
					}
					goto case 4;
				case 4:
					On8Txt432N = value;
					goto case 6;
				default:
					num = 6;
					break;
				case 8:
					return;
				}
			}
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
			return D1xTv8v4nV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			D1xTv8v4nV = value;
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
			return yVoTeA2mSy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yVoTeA2mSy = value;
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
			return MKuT2VeXax;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MKuT2VeXax = value;
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
			return PRTTqK83ud;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PRTTqK83ud = value;
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
			return string.Format((string)eJ9jmj6U5pusxwnThwV(), gLScUt6H1RUPyZlRcnw(Distance));
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
	public PointToLineDistanceTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vOr1M9663OmZw4w83lV();
		nELGjB6CMiBtjnhqmdx(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		d77e7u6jEOmw5OVq5Iy();
		int num = (UXjEQQ63vA6RvajlTpo() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				base.InternalPreParse();
				num = 5;
				break;
			case 0:
			case 1:
				InputPoint = null;
				num = 4;
				break;
			case 4:
				InputLine = null;
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				return;
			case 9:
				return;
			default:
				num = 6;
				break;
			case 14:
				AddProperty(InputPoint);
				num = 13;
				break;
			case 15:
				AddProperty(Distance);
				num = 28;
				break;
			case 3:
				return;
			case 19:
				return;
			case 10:
				AddProperty(OutputLine);
				num = 23;
				break;
			case 17:
				AddProperty(PixelLine);
				num = 29;
				break;
			case 4:
				num2 = J4lqwU6AmtMaPsE6mPt(relativeCellName);
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 26:
				return;
			case 13:
				return;
			case 20:
				return;
			case 27:
				return;
			case 25:
				if (num2 != 2046460609)
				{
					num = 8;
					break;
				}
				if (relativeCellName == (string)GCDJnZ6RstmyVIdGmim(6122))
				{
					Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
					goto case 7;
				}
				return;
			case 1:
				return;
			case 24:
				if (num2 != 946482371)
				{
					num = 3;
					break;
				}
				if (!lkH5Zy6WBy2l8Rcg6VG(relativeCellName, GCDJnZ6RstmyVIdGmim(26178)))
				{
					return;
				}
				InputPoint = new InputPointViewModel(this, cells, loc, Resources.InputPoint, IsInitialized);
				num = 14;
				break;
			case 18:
				return;
			case 2:
				if (num2 > 1121964790)
				{
					if (num2 <= 2349032177u)
					{
						num = 25;
						break;
					}
					if (num2 == 3345077989u)
					{
						if (!lkH5Zy6WBy2l8Rcg6VG(relativeCellName, GCDJnZ6RstmyVIdGmim(21646)))
						{
							return;
						}
						PixelLine = new LineViewModel(InSight, cells, loc, Resources.PixelLine, showStartArrow: true, showEndArrow: true);
						num = 17;
						if (0 == 0)
						{
							break;
						}
						goto case 8;
					}
					if (num2 != 3554238594u)
					{
						num = 18;
						break;
					}
					if (lkH5Zy6WBy2l8Rcg6VG(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(26158)))
					{
						Distance = new FloatViewModel(InSight, cells, loc, (string)ObbN3C6yCxCX2I6PKxj());
						num = 15;
						break;
					}
					return;
				}
				num = 5;
				if (d77e7u6jEOmw5OVq5Iy())
				{
					return;
				}
				break;
			case 12:
			case 16:
				return;
			case 7:
			case 22:
				AddProperty(Invert);
				num = 19;
				break;
			case 23:
				return;
			case 8:
				if (num2 == 2349032177u)
				{
					if (lkH5Zy6WBy2l8Rcg6VG(relativeCellName, GCDJnZ6RstmyVIdGmim(26202)))
					{
						InputLine = new InputLineViewModel(this, cells, loc, (string)iEfl9p6TbdZcE4yrIVu(), IsInitialized);
						num = 0;
						break;
					}
					num = 21;
					if (true)
					{
						break;
					}
					goto case 2;
				}
				num = 26;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				if (num2 > 946482371)
				{
					switch (num2)
					{
					default:
						num = 11;
						goto end_IL_0056;
					case 1017635769u:
						break;
					case 1121964790u:
						if (lkH5Zy6WBy2l8Rcg6VG(relativeCellName, GCDJnZ6RstmyVIdGmim(9034)))
						{
							OutputLine = new LineViewModel(InSight, cells, loc, Resources.OutputLine, showStartArrow: true, showEndArrow: true);
							num = 10;
						}
						else
						{
							num = 9;
						}
						goto end_IL_0056;
					}
					if (!lkH5Zy6WBy2l8Rcg6VG(relativeCellName, GCDJnZ6RstmyVIdGmim(6138)))
					{
						d77e7u6jEOmw5OVq5Iy();
						num = (UXjEQQ63vA6RvajlTpo() ? 16 : 7);
						break;
					}
					Max = new EditFloatViewModel(InSight, cells, loc, (string)LMluCw60yUrF5Uvs3QK());
					AddProperty(Max);
					num = 20;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				if (num2 != 781469175)
				{
					num = 24;
					if (1 == 0)
					{
						return;
					}
					break;
				}
				if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)))
				{
					num = 1;
					break;
				}
				Min = new EditFloatViewModel(InSight, cells, loc, Resources.MjMVZlHh3y());
				AddProperty(Min);
				return;
			case 21:
				return;
			case 28:
				return;
			case 0:
				AddProperty(InputLine);
				num = 27;
				break;
			case 6:
				return;
			case 29:
				return;
				end_IL_0056:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (d77e7u6jEOmw5OVq5Iy() ? 3 : 2);
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				list.Add(EditableGraphicHelper.ConstructLine(DP1lKL6FUJ0bBjR74RY(PixelLine), cells, OutputLine.CellLocation.ToString(absoluteRow: true, absoluteColumn: true)));
				num = 5;
				continue;
			case 1:
			case 3:
				if (reqDataType != CellType.Line)
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				if (!d77e7u6jEOmw5OVq5Iy())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 5:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])CTl2SV6M7r0HjfVrr1f(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		d77e7u6jEOmw5OVq5Iy();
		int num;
		if (UXjEQQ63vA6RvajlTpo())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0059;
			}
		}
		goto IL_0090;
		IL_006c:
		object obj = null;
		goto IL_0077;
		IL_0077:
		CvsDisplayableLine cvsDisplayableLine = (CvsDisplayableLine)obj;
		if (cvsDisplayableLine != null)
		{
			goto IL_0059;
		}
		goto IL_00bb;
		IL_0059:
		List<CvsEditableDisplayGraphic> list = default;
		list.Add(cvsDisplayableLine);
		num = 6;
		if (1 == 0)
		{
			goto IL_006c;
		}
		goto IL_0090;
		IL_00bb:
		return (CvsEditableDisplayGraphic[])CTl2SV6M7r0HjfVrr1f(list);
		IL_0090:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				break;
			case 4:
				goto IL_0059;
			case 3:
				goto IL_006c;
			default:
				num = 4;
				continue;
			case 6:
				goto IL_00bb;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		LineViewModel pixelLine = PixelLine;
		if (pixelLine == null)
		{
			num = 3;
			goto IL_0090;
		}
		obj = pixelLine.Line;
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__38))]
	internal override Task OnSetRange()
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
		goto IL_005e;
		IL_001a:
		_003COnSetRange_003Ed__38 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005e;
		IL_005e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				break;
			case 5:
				do
				{
					stateMachine._003C_003Et__builder = Avrqb46xJLPVLeshKku();
					_ = 1;
					if (d77e7u6jEOmw5OVq5Iy())
					{
						num = 4;
						continue;
					}
					num = 2;
					break;
				}
				while (1 == 0);
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
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
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 1:
			case 3:
				if (InSight != null)
				{
					goto case 2;
				}
				return;
			case 2:
			case 7:
			{
				InputPointViewModel inputPoint = InputPoint;
				if (inputPoint == null)
				{
					num = 5;
					break;
				}
				inputPoint.RefreshLinks();
				goto case 5;
			}
			default:
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				base.RefreshPotentialDependencies();
				UXjEQQ63vA6RvajlTpo();
				if (d77e7u6jEOmw5OVq5Iy())
				{
					num = 7;
					if (d77e7u6jEOmw5OVq5Iy())
					{
					}
				}
				else
				{
					num = 3;
				}
				break;
			case 5:
			case 6:
			{
				InputLineViewModel inputLine = InputLine;
				if (inputLine != null)
				{
					inputLine.RefreshLinks();
					num = 8;
					break;
				}
				num = 0;
				if (d77e7u6jEOmw5OVq5Iy())
				{
				}
				break;
			}
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vOr1M9663OmZw4w83lV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nELGjB6CMiBtjnhqmdx(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UXjEQQ63vA6RvajlTpo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool d77e7u6jEOmw5OVq5Iy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint J4lqwU6AmtMaPsE6mPt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GCDJnZ6RstmyVIdGmim(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lkH5Zy6WBy2l8Rcg6VG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iEfl9p6TbdZcE4yrIVu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ObbN3C6yCxCX2I6PKxj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Distance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LMluCw60yUrF5Uvs3QK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation DP1lKL6FUJ0bBjR74RY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CTl2SV6M7r0HjfVrr1f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vtw9w76YDZFKw8Sy9Kg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eJ9jmj6U5pusxwnThwV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X07tjUoaZN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double gLScUt6H1RUPyZlRcnw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Avrqb46xJLPVLeshKku()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
