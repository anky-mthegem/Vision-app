using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Height;

[Export(typeof(HeightTool))]
public class HeightTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightTool _003C_003E4__this;

		public int delta;

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
			HeightTool heightTool = default;
			do
			{
				IL_016a:
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)la74TZK0tua8HRHBJej8(heightTool.Region, delta)).GetAwaiter();
							_ = 0;
							if (Nb8TOHK0um4PBdDobSsF())
							{
								num3 = 5;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								num3 = 6;
							}
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
								return;
							case 0:
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (Nb8TOHK0um4PBdDobSsF())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
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
					break;
				default:
					num = 0;
					goto IL_016a;
				case 1:
				case 3:
					heightTool = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					Nb8TOHK0um4PBdDobSsF();
					if (Twhh8eK0hswvnyNL9oG2())
					{
						num = 5;
						goto IL_016a;
					}
					num = 3;
					if (!Twhh8eK0hswvnyNL9oG2())
					{
						goto IL_016a;
					}
					break;
				case 0:
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
		internal static object la74TZK0tua8HRHBJej8(object P_0, float delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Shift(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Nb8TOHK0um4PBdDobSsF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Twhh8eK0hswvnyNL9oG2()
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
	private struct _003CWriteFixturedGraphics_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O2C7UjKFwCDC670ucu80();
			int num;
			if (!Yx87KQKFJ8XdNOdqfhkc())
			{
				num = 3;
				if (!O2C7UjKFwCDC670ucu80())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
				if (!O2C7UjKFwCDC670ucu80())
				{
					goto IL_004b;
				}
			}
			goto IL_028f;
			IL_002e:
			int num2 = _003C_003E1__state;
			goto IL_02c4;
			IL_02d5:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				return;
			}
			goto IL_028f;
			IL_02c4:
			HeightTool heightTool = _003C_003E4__this;
			num = 4;
			goto IL_028f;
			IL_004b:
			try
			{
				TaskAwaiter<CvsCogSheetResult> awaiter = default;
				int num3;
				TaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__2;
						goto IL_013d;
					}
					num3 = 14;
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 2;
					if (Yx87KQKFJ8XdNOdqfhkc())
					{
					}
				}
				goto IL_01e6;
				IL_01e6:
				while (true)
				{
					switch (num3)
					{
					case 13:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						if (0 == 0)
						{
							continue;
						}
						goto case 6;
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 3;
					case 3:
						_003C_003Eu__1 = awaiter2;
						_ = 0;
						num3 = ((!O2C7UjKFwCDC670ucu80()) ? 10 : 5);
						continue;
					case 1:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 11;
							continue;
						}
						goto case 16;
					case 14:
						awaiter2 = k50m1NKFeS1DUNQXjhJc(((IEnumerable<CvsEditableDisplayGraphic>)cPrePaKFaNt3699aGlYe(heightTool)).Select(heightTool.xsWRyyDRKS).WhenAll());
						num3 = 8;
						continue;
					case 2:
						_003C_003Eu__1 = default;
						num3 = 9;
						continue;
					case 4:
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 10:
					case 12:
						break;
					case 0:
						goto IL_0159;
					case 7:
						return;
					case 11:
						_003C_003Eu__2 = awaiter;
						num3 = 6;
						continue;
					case 8:
						if (!awaiter2.IsCompleted)
						{
							num3 = 15;
							if (0 == 0)
							{
								continue;
							}
							goto case 9;
						}
						goto IL_01cd;
					case 9:
						num2 = (_003C_003E1__state = -1);
						goto IL_01cd;
					default:
						num3 = 0;
						continue;
					case 15:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						continue;
					case 16:
						{
							awaiter.GetResult();
							goto end_IL_004b;
						}
						IL_01cd:
						awaiter2.GetResult();
						goto IL_0159;
					}
					break;
				}
				goto IL_013d;
				IL_013d:
				_003C_003Eu__2 = default;
				num3 = 13;
				if (!O2C7UjKFwCDC670ucu80())
				{
					goto IL_0159;
				}
				goto IL_01e6;
				IL_0159:
				awaiter = ((CvsCogSocketSheet)X5bC6eKFI5TM7uOpUFqu(WxwNoyKFOd7X5Ox1f95Q(heightTool.InSight))).RunAsync(false).GetAwaiter();
				num3 = 1;
				goto IL_01e6;
				end_IL_004b:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_02d5;
			IL_028f:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 4:
					goto IL_004b;
				default:
					num = 2;
					if (Yx87KQKFJ8XdNOdqfhkc())
					{
					}
					continue;
				case 1:
				case 5:
					goto IL_02c4;
				case 2:
					goto IL_02d5;
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
		internal static object cPrePaKFaNt3699aGlYe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).GetEditableGraphics();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter k50m1NKFeS1DUNQXjhJc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WxwNoyKFOd7X5Ox1f95Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X5bC6eKFI5TM7uOpUFqu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O2C7UjKFwCDC670ucu80()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yx87KQKFJ8XdNOdqfhkc()
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
	private struct _003COnSetRange_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightTool _003C_003E4__this;

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
			(double, double) minMax = default;
			HeightTool heightTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (njJ7o2KFiBiWY2O7EDxx() ? 4 : 5);
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(pjlsgHKFnmyMCPlRccxs(heightTool.Height));
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							IL_014c:
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 7:
								while (true)
								{
									undoSetRange = new UndoSetRange<double>(heightTool.Parent, (string)WmLjh3KFV2MW8bJLWXru(heightTool), heightTool.Min.CellName, heightTool.Max.CellName, heightTool.Min.Value, heightTool.Max.Value, minMax.Item1, minMax.Item2);
									_ = 0;
									if (OMkkBgKFDLcfkrvYeoBE())
									{
										break;
									}
									num3 = 8;
									if (false)
									{
										continue;
									}
									goto IL_014c;
								}
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 0:
								return;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (OMkkBgKFDLcfkrvYeoBE())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 1:
							case 6:
								awaiter = wxFbvIKFlKlE6nSB6HFG(OGtrsOKFdkMHwYPS0ACM(SfaGgkKFflT7DDBGW2Za(heightTool.InSight), undoSetRange));
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
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
					goto default;
				case 1:
				case 5:
					heightTool = _003C_003E4__this;
					num = 0;
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
		internal static double pjlsgHKFnmyMCPlRccxs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WmLjh3KFV2MW8bJLWXru(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SfaGgkKFflT7DDBGW2Za(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OGtrsOKFdkMHwYPS0ACM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter wxFbvIKFlKlE6nSB6HFG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OMkkBgKFDLcfkrvYeoBE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool njJ7o2KFiBiWY2O7EDxx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private Plane3DViewModel eq7RqV0VHj;

	private FloatViewModel EocRiNJFNx;

	[CompilerGenerated]
	private ListBoxViewModel zBBRkVs80M;

	[CompilerGenerated]
	private CheckBoxViewModel SwkRPgUKo6;

	[CompilerGenerated]
	private EditCompositeRegionViewModel UOaRsnk9oe;

	private PointViewModel iJ5RK4Nte6;

	public FloatViewModel Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EocRiNJFNx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
			goto IL_0095;
			IL_001a:
			EocRiNJFNx.PropertyChanged += owZRO2h6gF;
			num = 8;
			if (O2eOqt7KNfKFN7oCHWI())
			{
				goto IL_0041;
			}
			goto IL_0095;
			IL_0041:
			if (EocRiNJFNx != null)
			{
				goto IL_001a;
			}
			return;
			IL_0095:
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					break;
				case 6:
					goto IL_0041;
				case 0:
				case 1:
					EocRiNJFNx.PropertyChanged -= owZRO2h6gF;
					num = 2;
					continue;
				case 7:
					EwnRHlea9L();
					goto IL_0041;
				default:
					num = 6;
					continue;
				case 3:
					if (EocRiNJFNx != null)
					{
						goto IL_00d3;
					}
					goto case 2;
				case 2:
					EocRiNJFNx = value;
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
				IL_00d3:
				_ = 1;
				num = (O2eOqt7KNfKFN7oCHWI() ? 4 : 0);
			}
			goto IL_001a;
		}
	}

	public ListBoxViewModel Measurement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zBBRkVs80M;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zBBRkVs80M = value;
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
			return SwkRPgUKo6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SwkRPgUKo6 = value;
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
			return UOaRsnk9oe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UOaRsnk9oe = value;
		}
	}

	public PointViewModel OutputPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iJ5RK4Nte6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iJ5RK4Nte6 = value;
			EwnRHlea9L();
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
			return (string)LSIo5S7sJZPoYECL078(zyutwH7lYGtnikTVlGM(), O52CT87gSKA2IHoGhe0(Height));
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
			return Height;
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
			return XAMLGraphicKeys.Tools_HeightIcon;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeightTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LiACfT75WRN8Xy60Gi7();
		O514G47wOuIoZGNPnHd(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CvsCellCollection cells2 = default;
		CvsCellLocation inputCompositeRegionLocation = default;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 35:
				zUsGNO7fgvc3S9SmkRm(eq7RqV0VHj, true);
				num = 38;
				break;
			case 4:
				return;
			case 36:
				return;
			case 1:
				if (Region != null)
				{
					num = 13;
					break;
				}
				return;
			case 7:
				xtCRwZmkUT();
				return;
			case 14:
				return;
			case 17:
				return;
			case 37:
				return;
			case 20:
				return;
			default:
				num = 34;
				break;
			case 24:
				return;
			case 26:
				return;
			case 31:
				AddProperty(Invert);
				num = 36;
				break;
			case 3:
				cells2 = cells;
				inputCompositeRegionLocation = CvsCellLocation.Invalid;
				num = 16;
				break;
			case 6:
				return;
			case 12:
				AddProperty(InputPlane);
				num = 14;
				if (0 == 0)
				{
					break;
				}
				goto case 10;
			case 10:
			case 15:
				if (num2 == 2350678467u && YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(25000)))
				{
					Measurement = new ListBoxViewModel(InSight, cells2, loc, (string)WhUd7n7ekdgV0B20MjF());
					AddProperty(Measurement);
				}
				return;
			case 16:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(relativeCellName);
				num = 27;
				break;
			case 2:
			case 8:
				if (num2 == 1017635769)
				{
					if (!YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(6138)))
					{
						return;
					}
					Max = new EditFloatViewModel(InSight, cells2, loc, (string)mCKlBo7IMio7i7i2M9g());
					num = 25;
				}
				else
				{
					num = 9;
				}
				break;
			case 30:
				if (num2 <= 466695522)
				{
					num = 23;
				}
				else if (num2 == 781469175)
				{
					if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)))
					{
						return;
					}
					Min = new EditFloatViewModel(InSight, cells2, loc, (string)CGO2Nc7OcTE43VQBAPo());
					AddProperty(Min);
					num = 19;
				}
				else
				{
					H6lCHH7LSbpVLSeLhtu();
					num = (O2eOqt7KNfKFN7oCHWI() ? 15 : 2);
				}
				break;
			case 28:
				return;
			case 23:
				if (num2 != 449038019)
				{
					num = 29;
					break;
				}
				if (YsAFrP7aq1enqM3Idet(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9162)))
				{
					InputPlane = new InputPlaneViewModel(this, cells2, loc, Resources.InputPlane, IsInitialized, eq7RqV0VHj);
					num = 12;
					if (!H6lCHH7LSbpVLSeLhtu())
					{
						return;
					}
					break;
				}
				return;
			case 19:
				return;
			case 5:
			{
				HeightTool heightTool = this;
				num = 3;
				break;
			}
			case 25:
				AddProperty(Max);
				num = 32;
				if (true)
				{
					break;
				}
				goto case 27;
			case 27:
				if (num2 <= 1227782301)
				{
					num = 30;
					break;
				}
				if (num2 > 2350678467u)
				{
					if (num2 != 2438518426u)
					{
						if (num2 == 3007377802u)
						{
							if (YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(19504)))
							{
								inputCompositeRegionLocation = loc;
								num = 1;
								if (H6lCHH7LSbpVLSeLhtu())
								{
									break;
								}
								goto case 1;
							}
							num = 6;
							break;
						}
						if (num2 != 3733526636u)
						{
							num = 37;
							break;
						}
						if (YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(9186)))
						{
							eq7RqV0VHj = new Plane3DViewModel(InSight, cells2, loc, (string)cPmtNQ7VFuZC2J19mBN());
							num = 35;
							break;
						}
						num = 11;
						if (0 == 0)
						{
							break;
						}
						goto case 33;
					}
					if (YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(24420)))
					{
						OutputPoint = new PointViewModel(InSight, cells2, loc, Resources.OutputPoint);
						num = 33;
						break;
					}
					return;
				}
				if (num2 == 2046460609)
				{
					if (!(relativeCellName == (string)oiNuGP7JttlCM3eY8TA(6122)))
					{
						num = 26;
						break;
					}
					Invert = new CheckBoxViewModel(InSight, cells2, loc, (string)STJ8bB7De4dgD8aYY0p(), IsInitialized);
					num = 31;
					break;
				}
				goto case 10;
			case 9:
				if (num2 == 1227782301)
				{
					if (relativeCellName == (string)oiNuGP7JttlCM3eY8TA(5684))
					{
						Region = new EditCompositeRegionViewModel(InSight, cells2, loc, (string)iYDYaH7immP0LqXKVn4(), fsWEkt7nPTGidZRKeLO(InputImage), IsInitialized, mustBeExtrudeable: true);
						num = 21;
						break;
					}
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 12;
				}
				return;
			case 22:
				AddProperty(Height);
				num = 20;
				if (false)
				{
					return;
				}
				break;
			case 0:
				return;
			case 33:
				AddProperty(OutputPoint);
				num = 17;
				if (0 == 0)
				{
					break;
				}
				goto case 18;
			case 18:
				if (inputCompositeRegionLocation.IsValid)
				{
					num = 7;
					break;
				}
				return;
			case 21:
				AddProperty(Region);
				num = 18;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				xtCRwZmkUT();
				num = 4;
				break;
			case 11:
				return;
			case 32:
				return;
			case 29:
				if (num2 == 466695522)
				{
					if (!YsAFrP7aq1enqM3Idet(relativeCellName, oiNuGP7JttlCM3eY8TA(2374)))
					{
						num = 24;
						break;
					}
					Height = new FloatViewModel(InSight, cells2, loc, Resources.Height);
					num = 22;
				}
				else
				{
					num = 28;
				}
				break;
			case 34:
				return;
			case 38:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__4))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CShiftEditGraphics_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				continue;
			case 2:
			case 6:
				stateMachine.delta = delta;
				goto case 4;
			default:
				num = 4;
				continue;
			case 5:
				stateMachine._003C_003Et__builder = qHZ4FN7d0b76HYXQMPE();
				_ = 1;
				if (!O2eOqt7KNfKFN7oCHWI())
				{
					num = 3;
					if (!O2eOqt7KNfKFN7oCHWI())
					{
						continue;
					}
					goto case 0;
				}
				num = 6;
				if (!O2eOqt7KNfKFN7oCHWI())
				{
					continue;
				}
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void owZRO2h6gF(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_1.PropertyName.Equals(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436), StringComparison.Ordinal))
		{
			EwnRHlea9L();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[2]
		{
			Region?.Graphic,
			OutputPoint?.Point
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
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__35))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CWriteFixturedGraphics_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!O2eOqt7KNfKFN7oCHWI())
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (H6lCHH7LSbpVLSeLhtu())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder = qHZ4FN7d0b76HYXQMPE();
				_ = 1;
				num = (O2eOqt7KNfKFN7oCHWI() ? 3 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__36))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (O2eOqt7KNfKFN7oCHWI() ? 4 : 5);
		_003COnSetRange_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = qHZ4FN7d0b76HYXQMPE();
				num = 3;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
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
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.1, -962.5, 962.5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EwnRHlea9L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		O2eOqt7KNfKFN7oCHWI();
		int num = ((!H6lCHH7LSbpVLSeLhtu()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				fZmRuv7rRpuHTa7vSkn(OutputPoint.Point, vsWiNG7vPJSFhcQ5HYO(this));
				num = 5;
				break;
			case 1:
				if (OutputPoint != null)
				{
					goto default;
				}
				return;
			case 0:
			case 4:
				if (Height != null)
				{
					num = 1;
					break;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task xsWRyyDRKS(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)m1B9tP7B6QmnoK9bFLl(InSight, P_0.CellLocation, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LiACfT75WRN8Xy60Gi7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O514G47wOuIoZGNPnHd(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H6lCHH7LSbpVLSeLhtu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O2eOqt7KNfKFN7oCHWI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oiNuGP7JttlCM3eY8TA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YsAFrP7aq1enqM3Idet(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WhUd7n7ekdgV0B20MjF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Measurement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CGO2Nc7OcTE43VQBAPo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mCKlBo7IMio7i7i2M9g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object STJ8bB7De4dgD8aYY0p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iYDYaH7immP0LqXKVn4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SearchRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation fsWEkt7nPTGidZRKeLO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cPmtNQ7VFuZC2J19mBN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ReferencePlane;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zUsGNO7fgvc3S9SmkRm(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder qHZ4FN7d0b76HYXQMPE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zyutwH7lYGtnikTVlGM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DEKmM9764B();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double O52CT87gSKA2IHoGhe0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LSIo5S7sJZPoYECL078(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vsWiNG7vPJSFhcQ5HYO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ResultString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fZmRuv7rRpuHTa7vSkn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayablePoint)P_0).Label = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tl25fa7PvW98rypjdVN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputCompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xFBjF07ZoX7SQQVhDeR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tY8Y4bDug1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m1B9tP7B6QmnoK9bFLl(object P_0, CvsCellLocation loc, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
	}
}
