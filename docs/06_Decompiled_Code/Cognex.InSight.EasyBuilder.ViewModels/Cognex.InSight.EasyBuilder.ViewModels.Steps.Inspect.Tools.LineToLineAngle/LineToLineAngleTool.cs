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

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineToLineAngle;

[Export(typeof(LineToLineAngleTool))]
public class LineToLineAngleTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSetRange_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineToLineAngleTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			LineToLineAngleTool lineToLineAngleTool = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
			(double, double) minMax = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					lineToLineAngleTool = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (KJ3N7PKTukC4ibnFjC8c() ? 5 : 0);
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 15;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
							}
							goto IL_0242;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_01d2;
						IL_0242:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 14:
								break;
							case 2:
								awaiter.GetResult();
								num3 = 14;
								continue;
							case 13:
								undoSetRange = new UndoSetRange<double>(lineToLineAngleTool.Parent, (string)Gq0jt1KTt4gpHlASnGRt(lineToLineAngleTool), lineToLineAngleTool.Min.CellName, lineToLineAngleTool.Max.CellName, lineToLineAngleTool.Min.Value, lineToLineAngleTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 5;
								continue;
							case 11:
								goto IL_010c;
							case 16:
								return;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 16;
								if (nDrE4rKT1W4KQ6gPwvAE())
								{
									continue;
								}
								goto case 15;
							case 15:
								minMax = GetMinMax(RDM0PrKTheZP6eur9ipY(lineToLineAngleTool.Angle));
								num3 = 13;
								continue;
							case 5:
								goto IL_018a;
							case 17:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								continue;
							default:
								goto IL_01d2;
							case 12:
								goto IL_01eb;
							case 4:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 0:
								return;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								}
								goto case 18;
							case 18:
								awaiter.GetResult();
								break;
							}
							break;
							IL_018a:
							if (!lineToLineAngleTool.IsInitialized)
							{
								awaiter = ((Task)YE3YPvKy5s4dqqKFXB8J(undoSetRange)).GetAwaiter();
								num3 = 6;
							}
							else
							{
								num3 = 11;
							}
							continue;
							IL_010c:
							awaiter = bmfKQ6KyKNvk0g7X0cHj(reDu5wKyLEvYdZXB23cR(EamSPgKTz1Zu34WWrUBj(lineToLineAngleTool.InSight), undoSetRange));
							_ = 1;
							num3 = (KJ3N7PKTukC4ibnFjC8c() ? 10 : 7);
						}
						goto end_IL_0061;
						IL_01eb:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_0242;
						IL_01d2:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						if (KJ3N7PKTukC4ibnFjC8c())
						{
							goto IL_01eb;
						}
						goto IL_0242;
						end_IL_0061:;
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
		internal static double RDM0PrKTheZP6eur9ipY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Gq0jt1KTt4gpHlASnGRt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EamSPgKTz1Zu34WWrUBj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object reDu5wKyLEvYdZXB23cR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bmfKQ6KyKNvk0g7X0cHj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YE3YPvKy5s4dqqKFXB8J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoSetRange<double>)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nDrE4rKT1W4KQ6gPwvAE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KJ3N7PKTukC4ibnFjC8c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InputLineViewModel zkLMO8gHoS;

	private InputLineViewModel d2hMHsYSba;

	[CompilerGenerated]
	private FloatViewModel iK5Mw6vlIj;

	[CompilerGenerated]
	private PointViewModel cFFMyk7ay5;

	[CompilerGenerated]
	private PointViewModel Mh5MxeMQWT;

	[CompilerGenerated]
	private CheckBoxViewModel QCOMvnGiPd;

	public InputLineViewModel InputLine0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zkLMO8gHoS;
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
				case 1:
					zkLMO8gHoS = value;
					goto case 3;
				default:
					num = 3;
					break;
				case 7:
					if (zkLMO8gHoS != value)
					{
						num = 0;
						break;
					}
					return;
				case 0:
					if (zkLMO8gHoS != null)
					{
						_ = 1;
						num = (Vy1mvK9oSQw7RI5ZJX3() ? 4 : 6);
						break;
					}
					goto case 1;
				case 2:
				case 6:
					zkLMO8gHoS.PropertyChanged -= SourceLink_PropertyChanged;
					num = 1;
					if (Vy1mvK9oSQw7RI5ZJX3())
					{
					}
					break;
				case 4:
				case 5:
					V14oDu9ATd2oHoib5Fg(zkLMO8gHoS, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					if (zkLMO8gHoS != null)
					{
						goto case 4;
					}
					return;
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
			return d2hMHsYSba;
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
				case 2:
				case 4:
					U1ojPI9RJVFGgFYjc4x(d2hMHsYSba, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					goto case 0;
				case 7:
					if (d2hMHsYSba != null)
					{
						num = 6;
						break;
					}
					return;
				case 5:
					if (d2hMHsYSba != null)
					{
						_ = 0;
						num = (oyUin59GEkTpoBmxgj0() ? 4 : 0);
						break;
					}
					goto case 0;
				case 0:
				case 3:
					d2hMHsYSba = value;
					goto case 7;
				default:
					num = 7;
					if (!Vy1mvK9oSQw7RI5ZJX3())
					{
						break;
					}
					goto case 6;
				case 6:
					d2hMHsYSba.PropertyChanged += SourceLink_PropertyChanged;
					num = 8;
					break;
				case 1:
					if (d2hMHsYSba != value)
					{
						num = 5;
						break;
					}
					return;
				case 8:
					return;
				}
			}
		}
	}

	public FloatViewModel Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iK5Mw6vlIj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iK5Mw6vlIj = value;
		}
	}

	public PointViewModel OutputPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cFFMyk7ay5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cFFMyk7ay5 = value;
		}
	}

	public PointViewModel PixelPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mh5MxeMQWT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mh5MxeMQWT = value;
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
			return QCOMvnGiPd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QCOMvnGiPd = value;
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
			return (string)fQCbOQ9pQsJdG1fpOX6(ffgc8y9WNoh39nJy5Y0(), dCpTl09T64QBH24hZht(Angle));
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
			return Angle;
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
			return XAMLGraphicKeys.Tools_AngleIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineToLineAngleTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vUJJ8E9SfoYMmfMkYtI();
		uKTWin9k7Zt4AAXKab5(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
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
			default:
				base.InternalPreParse();
				num = 5;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				InputLine1 = null;
				goto default;
			case 4:
				InputLine0 = null;
				oyUin59GEkTpoBmxgj0();
				if (Vy1mvK9oSQw7RI5ZJX3())
				{
					num = 3;
					if (Vy1mvK9oSQw7RI5ZJX3())
					{
					}
				}
				else
				{
					num = 0;
				}
				break;
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
		int num = 18;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 14:
				AddProperty(Max);
				num = 27;
				break;
			case 23:
				AddProperty(PixelPoint);
				num = 29;
				break;
			case 11:
				return;
			case 24:
				return;
			case 13:
				return;
			case 27:
				return;
			case 3:
				if (num2 <= 969184184)
				{
					num = 2;
				}
				else if (num2 > 2046460609)
				{
					if (num2 != 2438518426u)
					{
						oyUin59GEkTpoBmxgj0();
						num = ((!Vy1mvK9oSQw7RI5ZJX3()) ? 10 : 26);
					}
					else if (v6h76F9qcnvb1QdGhGu(relativeCellName, dS1Tix98Km9W63tH3SM(24420)))
					{
						OutputPoint = new PointViewModel(InSight, cells, loc, Resources.OutputPoint);
						num = 0;
					}
					else
					{
						num = 4;
					}
				}
				else
				{
					num = 12;
				}
				break;
			case 2:
				if (num2 > 710178259)
				{
					if (num2 != 781469175)
					{
						num = 8;
						if (Vy1mvK9oSQw7RI5ZJX3())
						{
							return;
						}
					}
					else if (v6h76F9qcnvb1QdGhGu(relativeCellName, dS1Tix98Km9W63tH3SM(6148)))
					{
						Min = new EditFloatViewModel(InSight, cells, loc, (string)PsvN0T9Xclm2wlqs9Ba());
						num = 7;
					}
					else
					{
						num = 1;
					}
					break;
				}
				switch (num2)
				{
				default:
					num = 11;
					break;
				case 710178259u:
					if (!(relativeCellName == (string)dS1Tix98Km9W63tH3SM(21598)))
					{
						num = 19;
						break;
					}
					InputLine0 = new InputLineViewModel(this, cells, loc, (string)fQCbOQ9pQsJdG1fpOX6(fRvQgU9ED6t48Ui5CHQ(), dS1Tix98Km9W63tH3SM(1838)), IsInitialized);
					num = 15;
					break;
				case 693400640u:
					if (v6h76F9qcnvb1QdGhGu(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21622)))
					{
						InputLine1 = new InputLineViewModel(this, cells, loc, (string)fQCbOQ9pQsJdG1fpOX6(fRvQgU9ED6t48Ui5CHQ(), dS1Tix98Km9W63tH3SM(21668)), IsInitialized);
						num = 5;
						break;
					}
					return;
				}
				break;
			case 25:
				return;
			case 21:
				if (num2 != 2046460609)
				{
					num = 25;
					break;
				}
				if (relativeCellName == (string)dS1Tix98Km9W63tH3SM(6122))
				{
					Invert = new CheckBoxViewModel(InSight, cells, loc, (string)wYjOWc99S50Zyr364wW(), IsInitialized);
					goto case 22;
				}
				return;
			case 15:
				AddProperty(InputLine0);
				return;
			default:
				num = 28;
				if (oyUin59GEkTpoBmxgj0())
				{
					break;
				}
				goto case 9;
			case 9:
			case 10:
				if (num2 == 3285284015u && v6h76F9qcnvb1QdGhGu(relativeCellName, dS1Tix98Km9W63tH3SM(24446)))
				{
					PixelPoint = new PointViewModel(InSight, cells, loc, (string)NwbCuX94fMOwc3xS5sc());
					num = 23;
					if (oyUin59GEkTpoBmxgj0())
					{
						break;
					}
					goto case 18;
				}
				return;
			case 28:
				return;
			case 6:
				return;
			case 8:
				if (num2 != 969184184)
				{
					num = 20;
					break;
				}
				if (v6h76F9qcnvb1QdGhGu(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24406)))
				{
					Angle = new FloatViewModel(InSight, cells, loc, Resources.Angle);
					AddProperty(Angle);
					num = 6;
					break;
				}
				return;
			case 7:
				AddProperty(Min);
				num = 13;
				break;
			case 16:
				return;
			case 5:
				AddProperty(InputLine1);
				num = 16;
				if (Vy1mvK9oSQw7RI5ZJX3())
				{
				}
				break;
			case 17:
				return;
			case 18:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(relativeCellName);
				num = 3;
				if (oyUin59GEkTpoBmxgj0())
				{
					break;
				}
				goto case 22;
			case 22:
			case 26:
				AddProperty(Invert);
				num = 24;
				break;
			case 19:
				return;
			case 12:
				if (num2 != 1017635769)
				{
					num = 21;
					break;
				}
				if (v6h76F9qcnvb1QdGhGu(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
				{
					Max = new EditFloatViewModel(InSight, cells, loc, Resources.CsBVSmiZVr());
					num = 14;
					break;
				}
				return;
			case 0:
				AddProperty(OutputPoint);
				num = 17;
				if (false)
				{
					return;
				}
				break;
			case 20:
				return;
			case 1:
				return;
			case 4:
				return;
			case 29:
				return;
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
		Vy1mvK9oSQw7RI5ZJX3();
		int num;
		if (oyUin59GEkTpoBmxgj0())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0081;
			}
		}
		goto IL_0042;
		IL_0042:
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				if (reqDataType == CellType.Point)
				{
					break;
				}
				goto case 5;
			default:
				goto IL_005f;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 3:
				break;
			case 5:
				return (CvsEditableDisplayGraphic[])rJELqd937Wyy9lVSiYE(list);
			}
			break;
			IL_005f:
			num = 3;
		}
		goto IL_0081;
		IL_0081:
		list.Add(EditableGraphicHelper.ConstructPoint(rVGEXG979biCJlu2pAB(PixelPoint), cells, OutputPoint.CellLocation.ToString(absoluteRow: true, absoluteColumn: true)));
		num = 5;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RmFM4GfQ6G(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (r7oHPs96XrbwP69E6xu(tJkcXm9jbTQFcN9HP0Q(P_1), dS1Tix98Km9W63tH3SM(5136), StringComparison.Ordinal))
		{
			FireDependencyChanged();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Vy1mvK9oSQw7RI5ZJX3())
		{
			num = 4;
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_009d;
			}
		}
		goto IL_006a;
		IL_00b0:
		List<CvsEditableDisplayGraphic> list = default;
		return list.ToArray();
		IL_009d:
		CvsDisplayablePoint cvsDisplayablePoint = default;
		list.Add(cvsDisplayablePoint);
		num = 6;
		if (true)
		{
			goto IL_006a;
		}
		goto IL_00b0;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				list = new List<CvsEditableDisplayGraphic>();
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				cvsDisplayablePoint = (CvsDisplayablePoint)bn8uaU9CLYrgOIUn8Mp(PixelPoint);
				num = 2;
				if (!Vy1mvK9oSQw7RI5ZJX3())
				{
					continue;
				}
				goto case 2;
			case 2:
				if (cvsDisplayablePoint != null)
				{
					break;
				}
				goto IL_00b0;
			case 6:
				goto IL_00b0;
			}
			break;
		}
		goto IL_009d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__39))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Vy1mvK9oSQw7RI5ZJX3())
		{
			num = 3;
			if (!oyUin59GEkTpoBmxgj0())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0074;
		IL_0044:
		_003COnSetRange_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = jmtf9a9yXFSPIMxYdcM();
		num = 5;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				goto IL_0044;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				if (oyUin59GEkTpoBmxgj0())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_0044;
		}
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (double min, double max) GetMinMax(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.05, -180.0, 180.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Vy1mvK9oSQw7RI5ZJX3())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0058;
		IL_0026:
		if (InSight != null)
		{
			num = 1;
			goto IL_0058;
		}
		return;
		IL_0058:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				num = 5;
				continue;
			case 7:
				return;
			case 1:
				InputLine0?.RefreshLinks();
				goto case 3;
			case 3:
			case 5:
			case 6:
			{
				InputLineViewModel inputLine = InputLine1;
				if (inputLine != null)
				{
					inputLine.RefreshLinks();
					num = 8;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 7;
				continue;
			}
			case 0:
			case 4:
				base.RefreshPotentialDependencies();
				num = 2;
				if (Vy1mvK9oSQw7RI5ZJX3())
				{
				}
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vUJJ8E9SfoYMmfMkYtI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uKTWin9k7Zt4AAXKab5(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oyUin59GEkTpoBmxgj0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vy1mvK9oSQw7RI5ZJX3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dS1Tix98Km9W63tH3SM(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v6h76F9qcnvb1QdGhGu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fRvQgU9ED6t48Ui5CHQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputLine0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fQCbOQ9pQsJdG1fpOX6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PsvN0T9Xclm2wlqs9Ba()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wYjOWc99S50Zyr364wW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NwbCuX94fMOwc3xS5sc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation rVGEXG979biCJlu2pAB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rJELqd937Wyy9lVSiYE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tJkcXm9jbTQFcN9HP0Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool r7oHPs96XrbwP69E6xu(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bn8uaU9CLYrgOIUn8Mp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PointViewModel)P_0).Point;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V14oDu9ATd2oHoib5Fg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U1ojPI9RJVFGgFYjc4x(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ffgc8y9WNoh39nJy5Y0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.nmgB6vE0Vn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dCpTl09T64QBH24hZht(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder jmtf9a9yXFSPIMxYdcM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
