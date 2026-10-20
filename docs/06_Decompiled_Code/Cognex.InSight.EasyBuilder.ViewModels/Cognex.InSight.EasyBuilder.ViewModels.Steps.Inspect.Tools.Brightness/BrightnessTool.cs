using System;
using System.Collections.Generic;
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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Brightness;

[Export(typeof(BrightnessTool))]
public class BrightnessTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BrightnessTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TF45EbKNoVq8kximmxPa();
			int num = ((!LFaMi6KNG24EnWjjgrcZ()) ? 5 : 3);
			BrightnessTool brightnessTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					brightnessTool = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = A7UhN5KNSiOXID4vYy1t(brightnessTool.Region.Shift(delta));
							num3 = 0;
							goto IL_0134;
						}
						awaiter = _003C_003Eu__1;
						goto IL_008f;
						IL_008f:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_0134;
						IL_0134:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 8:
								break;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								return;
							case 1:
							case 4:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								TF45EbKNoVq8kximmxPa();
								if (!LFaMi6KNG24EnWjjgrcZ())
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								}
								num3 = 1;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0134;
							}
							goto IL_008f;
							continue;
							end_IL_0134:
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
					goto case 2;
				default:
					num = 2;
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
		internal static TaskAwaiter A7UhN5KNSiOXID4vYy1t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LFaMi6KNG24EnWjjgrcZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TF45EbKNoVq8kximmxPa()
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
	private struct _003COnSetRange_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BrightnessTool _003C_003E4__this;

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
			goto IL_01ea;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01ea;
			IL_01ea:
			int num2 = default;
			(double, double) minMax = default;
			BrightnessTool brightnessTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(RZSpbbKNqXmcFJOJEJWM(brightnessTool.Brightness));
							num3 = 8;
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
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 1:
								return;
							case 6:
								return;
							case 7:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 8:
								undoSetRange = new UndoSetRange<double>(brightnessTool.Parent, (string)PpJ4g7KNEpgLFThagCo0(brightnessTool), (string)IuKKb4KNpqAw1gyxAQ6a(brightnessTool.Min), (string)IuKKb4KNpqAw1gyxAQ6a(brightnessTool.Max), brightnessTool.Min.Value, brightnessTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 2;
								continue;
							case 2:
								awaiter = OfnhhWKN9ojGdTYeu38E(XHVO1lKNXw53soWHV48h(brightnessTool.InSight.UndoHandler, undoSetRange));
								num3 = 0;
								continue;
							case 5:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								_003C_003Eu__1 = awaiter;
								WybWddKN87Ptm86M09Fk();
								num3 = ((!UduKNyKNkDcRfiu54i6H()) ? 1 : 9);
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
				default:
					num = 4;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (UduKNyKNkDcRfiu54i6H())
					{
						num = 5;
						continue;
					}
					num = 3;
					if (false)
					{
						return;
					}
					continue;
				case 1:
				case 5:
					brightnessTool = _003C_003E4__this;
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
		internal static double RZSpbbKNqXmcFJOJEJWM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PpJ4g7KNEpgLFThagCo0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IuKKb4KNpqAw1gyxAQ6a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XHVO1lKNXw53soWHV48h(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OfnhhWKN9ojGdTYeu38E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UduKNyKNkDcRfiu54i6H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WybWddKN87Ptm86M09Fk()
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
	private struct _003CWriteFixturedGraphics_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BrightnessTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FREk1EKN49ZG8eypV9g8();
			int num = (mhvCZ1KN7VWAC2wi1Gqv() ? 5 : 4);
			BrightnessTool brightnessTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					brightnessTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
								if (1 == 0)
								{
									goto IL_0058;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 11;
								if (1 == 0)
								{
									goto IL_0203;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_0106;
						IL_0058:
						awaiter = ((CvsCogSocketSheet)S7ulrTKNAEKcWkxKZAZo(i5HjaGKNC6rSUdXcGBrt(brightnessTool.InSight))).RunAsync(false).GetAwaiter();
						num3 = 3;
						goto IL_0106;
						IL_0106:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 16;
							case 12:
								goto IL_0094;
							case 2:
								awaiter2 = dCLgjxKN6oWcg3lAihNK(EditableGraphicHelper.SendGraphicAsync(brightnessTool.InSight, FCGbxQKN3ySMcmu5mhwZ(brightnessTool.Region), (CvsEditableDisplayGraphic)RqnSDsKNjvkOWg8TwKxg(brightnessTool.Region)));
								num3 = 14;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto IL_00ed;
							default:
								num3 = 9;
								if (!mhvCZ1KN7VWAC2wi1Gqv())
								{
									continue;
								}
								goto case 14;
							case 14:
								if (!awaiter2.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto IL_00ed;
							case 8:
							case 10:
								_003C_003Eu__2 = awaiter;
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (brightnessTool.PinOnFixtureChange)
								{
									num3 = 2;
									continue;
								}
								goto end_IL_003f;
							case 0:
								num2 = (_003C_003E1__state = 1);
								goto case 8;
							case 11:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 6:
								return;
							case 4:
							case 13:
								goto IL_0203;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_003f;
								}
								IL_00ed:
								awaiter2.GetResult();
								break;
							}
							break;
							IL_0094:
							num2 = (_003C_003E1__state = 0);
							_ = 1;
							num3 = (mhvCZ1KN7VWAC2wi1Gqv() ? 8 : 13);
						}
						goto IL_0058;
						IL_0203:
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
						end_IL_003f:;
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
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 0:
				case 4:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 1;
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
		internal static CvsCellLocation FCGbxQKN3ySMcmu5mhwZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RqnSDsKNjvkOWg8TwKxg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter dCLgjxKN6oWcg3lAihNK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object i5HjaGKNC6rSUdXcGBrt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S7ulrTKNAEKcWkxKZAZo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FREk1EKN49ZG8eypV9g8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mhvCZ1KN7VWAC2wi1Gqv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private FloatViewModel NGTCzb8qZQ;

	[CompilerGenerated]
	private EditCompositeRegionViewModel anROarXQW9;

	[CompilerGenerated]
	private CheckBoxViewModel QjKO5ZMgtY;

	private bool zGNOpXQvdI;

	public FloatViewModel Brightness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NGTCzb8qZQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NGTCzb8qZQ = value;
		}
	}

	public EditCompositeRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return anROarXQW9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			anROarXQW9 = value;
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
			return QjKO5ZMgtY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QjKO5ZMgtY = value;
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
			return (string)Ykb59mWu5dWp1eQmKOS(EP6muvWc9I3u5L9rqxM(), pJQxDcW1i66oLZsu4oe(Brightness));
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
			return Brightness;
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
			return XAMLGraphicKeys.Tools_BrightnessIcon;
		}
	}

	public bool PinOnFixtureChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zGNOpXQvdI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref zGNOpXQvdI, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27084));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BrightnessTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ORH2SaWycFrrwkTTo4L();
		int num;
		if (!pne5DlW0KKva884DyZ7())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0043;
		IL_007f:
		k96B21WMmwVIyoTKiYa(this, inspect, isInitialized);
		num = 5;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				QbheibWFFsYVvsK2dUS();
				num = 3;
				continue;
			default:
				goto IL_007f;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		zGNOpXQvdI = true;
		goto IL_007f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
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
			case 1:
				AddProperty(Min);
				goto default;
			default:
				ORH2SaWycFrrwkTTo4L();
				if (!pne5DlW0KKva884DyZ7())
				{
					num = 14;
					if (ORH2SaWycFrrwkTTo4L())
					{
						break;
					}
					goto case 7;
				}
				num = 4;
				if (ORH2SaWycFrrwkTTo4L())
				{
					break;
				}
				goto case 11;
			case 7:
				if (!abqOPEWUs0gC1IQFEWp(relativeCellName, W8SRUMWYiKAO6lcmaDY(6148)))
				{
					if (!abqOPEWUs0gC1IQFEWp(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
					{
						num = 3;
						if (!pne5DlW0KKva884DyZ7())
						{
							break;
						}
						goto case 9;
					}
					Max = new EditFloatViewModel(InSight, cells, loc, (string)ceaVlGWxPQMZDV5TKq9());
					num = 13;
					if (!ORH2SaWycFrrwkTTo4L())
					{
						return;
					}
					break;
				}
				Min = new EditFloatViewModel(InSight, cells, loc, Resources.MjMVZlHh3y());
				num = 1;
				if (1 == 0)
				{
					return;
				}
				break;
			case 9:
				AddProperty(Region);
				num = 17;
				break;
			case 2:
				AddProperty(Invert);
				return;
			case 12:
				return;
			case 11:
				AddProperty(Brightness);
				num = 5;
				break;
			case 6:
				return;
			case 15:
				do
				{
					if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684))
					{
						Region = new EditCompositeRegionViewModel(InSight, cells, loc, Resources.l1fZTglVqg(), InputImage.CellLocation, IsInitialized);
						num = 9;
						continue;
					}
					num = 10;
					break;
				}
				while (false);
				break;
			case 13:
				AddProperty(Max);
				num = 16;
				break;
			case 4:
				return;
			case 3:
				do
				{
					if (!abqOPEWUs0gC1IQFEWp(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6122)))
					{
						if (abqOPEWUs0gC1IQFEWp(relativeCellName, W8SRUMWYiKAO6lcmaDY(19504)))
						{
							InputCompositeRegion = new InputCompositeRegionViewModel(this, cells, loc, (string)OFHlrXWQ1Y9kDCK0JFl(), (string)qTQBFcWNKa4jsOOou0K(), Region, IsInitialized);
							AddProperty(InputCompositeRegion);
							num = 6;
							continue;
						}
						num = 15;
						break;
					}
					Invert = new CheckBoxViewModel(InSight, cells, loc, (string)j22AqPWm4FYKSgubBLI(), IsInitialized);
					num = 2;
					break;
				}
				while (!ORH2SaWycFrrwkTTo4L());
				break;
			case 0:
				if (!(relativeCellName == (string)W8SRUMWYiKAO6lcmaDY(2152)))
				{
					num = 7;
					break;
				}
				Brightness = new FloatViewModel(InSight, cells, loc, (string)THL8NYWH7juD1WeSFXa());
				num = 11;
				break;
			case 16:
				return;
			case 8:
			case 14:
				return;
			case 5:
				return;
			case 10:
				return;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__17))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (ORH2SaWycFrrwkTTo4L())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
			if (pne5DlW0KKva884DyZ7())
			{
				goto IL_0093;
			}
		}
		goto IL_0058;
		IL_0058:
		_003CShiftEditGraphics_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				stateMachine.delta = delta;
				goto default;
			case 0:
			case 4:
				goto IL_0093;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0093:
		stateMachine._003C_003Et__builder = zK6dnDW24gSVu98YwlQ();
		num = 6;
		goto IL_0058;
		IL_0026:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0058;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsEditableDisplayGraphic graphic = default;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				graphic = Region.Graphic;
				_ = 0;
				if (ORH2SaWycFrrwkTTo4L())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			case 2:
			case 5:
				if (graphic == null)
				{
					break;
				}
				goto default;
			default:
				list.Add(graphic);
				num = 6;
				continue;
			case 1:
				list = new List<CvsEditableDisplayGraphic>();
				num = 4;
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
		return (CvsEditableDisplayGraphic[])IDW5S0WhSXEymoBmsMf(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__29))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ORH2SaWycFrrwkTTo4L();
		int num = (pne5DlW0KKva884DyZ7() ? 1 : 4);
		_003COnSetRange_003Ed__29 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = zK6dnDW24gSVu98YwlQ();
				num = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
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
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.1, 0.0, 255.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__31))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CWriteFixturedGraphics_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!pne5DlW0KKva884DyZ7())
				{
					num = 0;
					break;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = zK6dnDW24gSVu98YwlQ();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QbheibWFFsYVvsK2dUS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k96B21WMmwVIyoTKiYa(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ORH2SaWycFrrwkTTo4L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pne5DlW0KKva884DyZ7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W8SRUMWYiKAO6lcmaDY(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool abqOPEWUs0gC1IQFEWp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object THL8NYWH7juD1WeSFXa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Brightness;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ceaVlGWxPQMZDV5TKq9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j22AqPWm4FYKSgubBLI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OFHlrXWQ1Y9kDCK0JFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputCompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qTQBFcWNKa4jsOOou0K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tY8Y4bDug1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder zK6dnDW24gSVu98YwlQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EP6muvWc9I3u5L9rqxM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X07tjUoaZN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double pJQxDcW1i66oLZsu4oe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ykb59mWu5dWp1eQmKOS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IDW5S0WhSXEymoBmsMf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}
}
