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

[Export(typeof(PointToPointDistanceTool))]
public class PointToPointDistanceTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSetRange_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PointToPointDistanceTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0209;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0209;
			IL_0209:
			PointToPointDistanceTool pointToPointDistanceTool = default;
			int num2 = default;
			(double, double) minMax = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					pointToPointDistanceTool = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(kOZ2OAKx75PNTFyDOAJt(pointToPointDistanceTool.Distance));
							XOhI70Kx4MVuH5mErmDt();
							if (LqkCp0Kx9UpqJ9Xym8mx())
							{
								num3 = 4;
							}
							else
							{
								num3 = 2;
								if (XOhI70Kx4MVuH5mErmDt())
								{
								}
							}
							goto IL_008d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0106;
						IL_008d:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 2:
							case 6:
								break;
							case 9:
								return;
							case 0:
							case 4:
							{
								UndoSetRange<double> undoSetRange = new UndoSetRange<double>(pointToPointDistanceTool.Parent, (string)C1IVEdKx3XOxP2ig8tdS(pointToPointDistanceTool), pointToPointDistanceTool.Min.CellName, (string)VO4ErHKxjkR8MamktuuO(pointToPointDistanceTool.Max), pointToPointDistanceTool.Min.Value, pointToPointDistanceTool.Max.Value, minMax.Item1, minMax.Item2);
								awaiter = rRIym1KxAPH51pS6wUjD(CefZ2fKxCNCJFJo8Blm0(SE7bT7Kx6RR373WPrMkn(pointToPointDistanceTool.InSight), undoSetRange));
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							}
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_008d;
							}
							goto IL_0106;
							continue;
							end_IL_008d:
							break;
						}
						goto end_IL_0042;
						IL_0106:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_008d;
						end_IL_0042:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
					num2 = _003C_003E1__state;
					LqkCp0Kx9UpqJ9Xym8mx();
					num = ((!XOhI70Kx4MVuH5mErmDt()) ? 4 : 2);
					continue;
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
		internal static double kOZ2OAKx75PNTFyDOAJt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C1IVEdKx3XOxP2ig8tdS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VO4ErHKxjkR8MamktuuO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SE7bT7Kx6RR373WPrMkn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CefZ2fKxCNCJFJo8Blm0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rRIym1KxAPH51pS6wUjD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LqkCp0Kx9UpqJ9Xym8mx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XOhI70Kx4MVuH5mErmDt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InputPointViewModel jbeTGXUj5W;

	private InputPointViewModel mT0TBKwTFX;

	[CompilerGenerated]
	private FloatViewModel Nw0TZ5hleL;

	[CompilerGenerated]
	private LineViewModel NiZTnp1vEa;

	[CompilerGenerated]
	private LineViewModel wC8TtmprJ4;

	[CompilerGenerated]
	private CheckBoxViewModel jHUTYLRglx;

	public InputPointViewModel InputPoint0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jbeTGXUj5W;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Dh9D5c6QYHlfjX1mG1f())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 7;
			}
			goto IL_00cd;
			IL_004d:
			Doq4KlCJwgnMpfM0joe(jbeTGXUj5W, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
			num = 5;
			goto IL_00cd;
			IL_00cd:
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 2:
					goto IL_004d;
				case 4:
					if (jbeTGXUj5W != null)
					{
						num = 6;
						continue;
					}
					return;
				case 1:
				case 7:
					if (jbeTGXUj5W != null)
					{
						num = 2;
						continue;
					}
					goto case 5;
				case 0:
				case 3:
					if (jbeTGXUj5W != value)
					{
						goto case 1;
					}
					return;
				case 5:
					jbeTGXUj5W = value;
					goto case 4;
				default:
					num = 4;
					continue;
				case 8:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			BXkyfoCawaRxtn81uf9(jbeTGXUj5W, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
			num = 8;
			if (!p2VIWh6mQosuWu4U27Z())
			{
				goto IL_004d;
			}
			goto IL_00cd;
		}
	}

	public InputPointViewModel InputPoint1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mT0TBKwTFX;
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
				case 0:
					Doq4KlCJwgnMpfM0joe(mT0TBKwTFX, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 1;
					break;
				case 5:
				case 6:
					BXkyfoCawaRxtn81uf9(mT0TBKwTFX, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 7:
					if (mT0TBKwTFX != value)
					{
						num = 3;
						break;
					}
					return;
				case 2:
				case 4:
					if (mT0TBKwTFX != null)
					{
						goto case 5;
					}
					return;
				case 3:
					if (mT0TBKwTFX != null)
					{
						num = 0;
						if (p2VIWh6mQosuWu4U27Z())
						{
							break;
						}
					}
					goto case 1;
				case 1:
					mT0TBKwTFX = value;
					goto default;
				default:
					_ = 1;
					num = ((!Dh9D5c6QYHlfjX1mG1f()) ? 2 : 6);
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
			return Nw0TZ5hleL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Nw0TZ5hleL = value;
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
			return NiZTnp1vEa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NiZTnp1vEa = value;
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
			return wC8TtmprJ4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wC8TtmprJ4 = value;
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
			return jHUTYLRglx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jHUTYLRglx = value;
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
			return string.Format((string)nPpUhvCe8NhkR2CPcXZ(), QQtETECOpqkTN5xbwxi(Distance));
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
	public PointToPointDistanceTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		o6USne6Nf8QMr7Xp7vE();
		Idcont62A3V7eAu8mVc(this, inspect, isInitialized);
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
			case 1:
			case 3:
				InputPoint1 = null;
				goto default;
			default:
				base.InternalPreParse();
				num = 5;
				if (p2VIWh6mQosuWu4U27Z())
				{
					continue;
				}
				break;
			case 4:
				break;
			case 5:
				return;
			}
			InputPoint0 = null;
			Dh9D5c6QYHlfjX1mG1f();
			if (!p2VIWh6mQosuWu4U27Z())
			{
				num = 0;
				continue;
			}
			num = 3;
			if (false)
			{
				break;
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
			case 23:
				return;
			case 14:
				switch (num2)
				{
				default:
					num = 4;
					break;
				case 781469175u:
					if (!ldZrrr6uVjcQwTmmxkI(relativeCellName, QUsrXn611pHFWhO5mti(6148)))
					{
						num = 27;
						break;
					}
					Min = new EditFloatViewModel(InSight, cells, loc, Resources.MjMVZlHh3y());
					AddProperty(Min);
					return;
				case 1017635769u:
					if (!ldZrrr6uVjcQwTmmxkI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
					{
						return;
					}
					Max = new EditFloatViewModel(InSight, cells, loc, Resources.CsBVSmiZVr());
					num = 24;
					break;
				}
				break;
			case 25:
				return;
			case 24:
				AddProperty(Max);
				return;
			case 1:
				AddProperty(InputPoint1);
				return;
			case 13:
				AddProperty(InputPoint0);
				return;
			case 20:
				return;
			case 16:
				if (num2 <= 2046460609)
				{
					num = 22;
					if (1 == 0)
					{
						return;
					}
				}
				else if (num2 <= 3257189001u)
				{
					num = 12;
					if (1 == 0)
					{
						return;
					}
				}
				else if (num2 != 3345077989u)
				{
					Dh9D5c6QYHlfjX1mG1f();
					num = (p2VIWh6mQosuWu4U27Z() ? 7 : 19);
				}
				else if (ldZrrr6uVjcQwTmmxkI(relativeCellName, QUsrXn611pHFWhO5mti(21646)))
				{
					PixelLine = new LineViewModel(InSight, cells, loc, (string)eIlRTeCK8ERr9SIF5sP(), showStartArrow: true, showEndArrow: true);
					num = 5;
				}
				else
				{
					num = 11;
					if (false)
					{
						return;
					}
				}
				break;
			case 28:
				return;
			case 18:
				num2 = siEigP6cNRlcqlYSxTr(relativeCellName);
				num = 16;
				break;
			case 10:
				AddProperty(OutputLine);
				num = 25;
				break;
			case 3:
				if (num2 != 2046460609)
				{
					return;
				}
				if (ldZrrr6uVjcQwTmmxkI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6122)))
				{
					Invert = new CheckBoxViewModel(InSight, cells, loc, (string)l6pEjpCL941pWoYrd8u(), IsInitialized);
					AddProperty(Invert);
					num = 23;
				}
				else
				{
					num = 26;
				}
				break;
			case 26:
				return;
			case 0:
				AddProperty(Distance);
				return;
			case 21:
				return;
			case 7:
			case 9:
				if (num2 == 3554238594u)
				{
					if (ldZrrr6uVjcQwTmmxkI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(26158)))
					{
						Distance = new FloatViewModel(InSight, cells, loc, (string)sn7LCv6zPaKDqoUbG5H());
						num = 0;
						if (true)
						{
							break;
						}
						goto case 13;
					}
					return;
				}
				num = 2;
				break;
			case 12:
				if (num2 == 3240411382u)
				{
					if (relativeCellName == (string)QUsrXn611pHFWhO5mti(26132))
					{
						InputPoint1 = new InputPointViewModel(this, cells, loc, (string)F1XTZi6tYS9uhj3TSmb(MHHG356h31op2hUxQ16(), QUsrXn611pHFWhO5mti(21668)), IsInitialized);
						num = 1;
					}
					else
					{
						num = 20;
					}
					break;
				}
				num = 17;
				if (true)
				{
					break;
				}
				goto case 17;
			case 17:
				if (num2 != 3257189001u)
				{
					num = 15;
					if (!p2VIWh6mQosuWu4U27Z())
					{
						return;
					}
				}
				else if (ldZrrr6uVjcQwTmmxkI(relativeCellName, QUsrXn611pHFWhO5mti(26106)))
				{
					InputPoint0 = new InputPointViewModel(this, cells, loc, (string)F1XTZi6tYS9uhj3TSmb(MHHG356h31op2hUxQ16(), CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838)), IsInitialized);
					num = 13;
				}
				else
				{
					num = 28;
				}
				break;
			case 8:
				return;
			case 22:
				if (num2 <= 1017635769)
				{
					num = 14;
					break;
				}
				if (num2 == 1121964790)
				{
					if (ldZrrr6uVjcQwTmmxkI(relativeCellName, QUsrXn611pHFWhO5mti(9034)))
					{
						OutputLine = new LineViewModel(InSight, cells, loc, Resources.OutputLine, showStartArrow: true, showEndArrow: true);
						num = 10;
						break;
					}
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 3;
				break;
			case 15:
				return;
			case 11:
				return;
			case 27:
				return;
			default:
				num = 8;
				if (!Dh9D5c6QYHlfjX1mG1f())
				{
					break;
				}
				goto case 5;
			case 5:
				AddProperty(PixelLine);
				num = 29;
				break;
			case 2:
				return;
			case 4:
				return;
			case 6:
				return;
			case 19:
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
		int num = 0;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			default:
				list.Add(EditableGraphicHelper.ConstructLine(d8C75RC5OXdUyPSHR47(PixelLine), cells, d8C75RC5OXdUyPSHR47(OutputLine).ToString(absoluteRow: true, absoluteColumn: true)));
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				p2VIWh6mQosuWu4U27Z();
				num = (Dh9D5c6QYHlfjX1mG1f() ? 4 : 3);
				continue;
			case 1:
			case 3:
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
		return (CvsEditableDisplayGraphic[])I29UFsCwyjfCWYij5Iw(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		List<CvsEditableDisplayGraphic> list = default;
		CvsDisplayableLine line = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				list.Add(line);
				num = 6;
				continue;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				_ = 0;
				num = ((!p2VIWh6mQosuWu4U27Z()) ? 4 : 3);
				continue;
			case 2:
			case 4:
				if (line == null)
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 3:
				line = PixelLine.Line;
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])I29UFsCwyjfCWYij5Iw(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__38))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!p2VIWh6mQosuWu4U27Z()) ? 5 : 4);
		_003COnSetRange_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
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
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00ab;
		IL_001a:
		InputPointViewModel inputPoint = InputPoint0;
		if (inputPoint == null)
		{
			num = 3;
			goto IL_00ab;
		}
		inputPoint.RefreshLinks();
		goto IL_0041;
		IL_0041:
		InputPointViewModel inputPoint2 = InputPoint1;
		if (inputPoint2 == null)
		{
			num = 5;
		}
		else
		{
			inputPoint2.RefreshLinks();
			num = 8;
		}
		goto IL_00ab;
		IL_00ab:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				break;
			case 0:
				base.RefreshPotentialDependencies();
				num = 6;
				continue;
			default:
				goto IL_0041;
			case 6:
				goto IL_0058;
			case 5:
				return;
			case 8:
				return;
			}
			break;
			IL_0058:
			if (InSight == null)
			{
				return;
			}
			Dh9D5c6QYHlfjX1mG1f();
			if (p2VIWh6mQosuWu4U27Z())
			{
				num = 7;
				continue;
			}
			num = 1;
			if (true)
			{
				continue;
			}
			return;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o6USne6Nf8QMr7Xp7vE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Idcont62A3V7eAu8mVc(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p2VIWh6mQosuWu4U27Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Dh9D5c6QYHlfjX1mG1f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint siEigP6cNRlcqlYSxTr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QUsrXn611pHFWhO5mti(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ldZrrr6uVjcQwTmmxkI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MHHG356h31op2hUxQ16()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputPoint0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F1XTZi6tYS9uhj3TSmb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sn7LCv6zPaKDqoUbG5H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Distance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l6pEjpCL941pWoYrd8u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eIlRTeCK8ERr9SIF5sP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PixelLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation d8C75RC5OXdUyPSHR47(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I29UFsCwyjfCWYij5Iw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Doq4KlCJwgnMpfM0joe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BXkyfoCawaRxtn81uf9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nPpUhvCe8NhkR2CPcXZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X07tjUoaZN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double QQtETECOpqkTN5xbwxi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}
}
