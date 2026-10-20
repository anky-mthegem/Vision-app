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
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.HeightMap;

[Export(typeof(HeightMapTool))]
public class HeightMapTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightMapTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!EjVvbIKFyoEDvgUxyjbI()) ? 1 : 4);
			int num2 = default;
			HeightMapTool heightMapTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					heightMapTool = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = HnBvZlKFFy1JQs7uVI5Z(heightMapTool.Region.Shift(delta));
							num3 = 1;
							if (!EjVvbIKFyoEDvgUxyjbI())
							{
								goto IL_007a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_00f3;
						IL_00f3:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = (aJDBSLKF0NuIHePWFrfC() ? 2 : 5);
								continue;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 2:
								return;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00f3;
							}
							goto IL_007a;
							continue;
							end_IL_00f3:
							break;
						}
						goto end_IL_004c;
						IL_007a:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00f3;
						end_IL_004c:;
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
					num = 3;
					continue;
				case 3:
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
		internal static TaskAwaiter HnBvZlKFFy1JQs7uVI5Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EjVvbIKFyoEDvgUxyjbI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aJDBSLKF0NuIHePWFrfC()
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
	private struct _003CWriteFixturedGraphics_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightMapTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oiHPiLKFMNhIhmMNTWs7();
			int num = ((!MVMU3jKFYYOrF24qhEwT()) ? 1 : 4);
			HeightMapTool heightMapTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					heightMapTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 1;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 7;
								continue;
							case 1:
								awaiter2 = gkXY7KKFmBC4hechI9u3(gim8swKFxmJtOhhBumMX(heightMapTool.InSight, IC0UELKFUKDoClIhiKFx(heightMapTool.Region), ifvijDKFHwvBxNVd4Ri4(heightMapTool.Region)));
								num3 = 9;
								continue;
							case 8:
								_003C_003Eu__2 = awaiter;
								num3 = 11;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (MVMU3jKFYYOrF24qhEwT())
								{
								}
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								break;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 0:
								awaiter = ((CvsCogSocketSheet)pSMqfRKFNSsGPxwFScBJ(KZNhg0KFQNd7dAQcwDqG(heightMapTool.InSight))).RunAsync(false).GetAwaiter();
								num3 = 6;
								continue;
							case 2:
							case 15:
								_003C_003Eu__1 = awaiter2;
								goto case 3;
							case 10:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Eu__2 = default;
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 4:
								awaiter2.GetResult();
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_ = 1;
									if (MVMU3jKFYYOrF24qhEwT())
									{
										num3 = 12;
										if (oiHPiLKFMNhIhmMNTWs7())
										{
											continue;
										}
										goto case 10;
									}
									num3 = 15;
									continue;
								}
								goto case 4;
							case 16:
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
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (false)
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
		internal static CvsCellLocation IC0UELKFUKDoClIhiKFx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ifvijDKFHwvBxNVd4Ri4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gim8swKFxmJtOhhBumMX(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gkXY7KKFmBC4hechI9u3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KZNhg0KFQNd7dAQcwDqG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pSMqfRKFNSsGPxwFScBJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oiHPiLKFMNhIhmMNTWs7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MVMU3jKFYYOrF24qhEwT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ImageViewModel LdQRm8b808;

	[CompilerGenerated]
	private EditRegionViewModel CrTR1yav0g;

	[CompilerGenerated]
	private CheckBoxViewModel qbvRz3lVwh;

	[CompilerGenerated]
	private CheckBoxViewModel EAs4a6jKuN;

	public ImageViewModel OutputImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LdQRm8b808;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LdQRm8b808 = value;
		}
	}

	public EditRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CrTR1yav0g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CrTR1yav0g = value;
		}
	}

	public CheckBoxViewModel Colorize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qbvRz3lVwh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qbvRz3lVwh = value;
		}
	}

	public CheckBoxViewModel FillHoles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EAs4a6jKuN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EAs4a6jKuN = value;
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
			return XAMLGraphicKeys.Tools_ImageFilterIcon;
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
	public HeightMapTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kI9X7877cLBdJWUU0sv();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
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
		goto IL_007d;
		IL_001a:
		AddProperty(FillHoles);
		num = 14;
		goto IL_007d;
		IL_007d:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				AddProperty(Region);
				num = 13;
				continue;
			case 1:
				return;
			default:
				num = 10;
				if (zmfhj679eeKVFGnbhli())
				{
					continue;
				}
				goto case 9;
			case 9:
				if (o3rhO7732PA8nxYvkSt(relativeCellName, eYyoeP7jQlh5ihpgOoI(7570)))
				{
					InputRegion = new InputRegionViewModel(this, cells, loc, Resources.InputRegion, (string)NKOf4L7CHiSnAo6bprW(), Region, IsInitialized);
					goto case 10;
				}
				num = 8;
				continue;
			case 7:
				return;
			case 2:
			case 3:
				if (!o3rhO7732PA8nxYvkSt(relativeCellName, eYyoeP7jQlh5ihpgOoI(25102)))
				{
					if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(25122)))
					{
						num = 7;
						continue;
					}
					FillHoles = new CheckBoxViewModel(InSight, cells, loc, Resources.FillHoles, IsInitialized);
					num = 6;
					if (zmfhj679eeKVFGnbhli())
					{
						continue;
					}
					goto case 5;
				}
				Colorize = new CheckBoxViewModel(InSight, cells, loc, Resources.Colorize, IsInitialized);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 0:
				if (o3rhO7732PA8nxYvkSt(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24642)))
				{
					OutputImage = new ImageViewModel(InSight, cells, loc, (string)edOWCn76lHCBwWRqWSn());
					goto case 5;
				}
				num = 9;
				continue;
			case 11:
				return;
			case 5:
			case 12:
				AddProperty(OutputImage);
				num = 1;
				continue;
			case 8:
				if (!(relativeCellName == (string)eYyoeP7jQlh5ihpgOoI(5684)))
				{
					H222g274VC9tuxInysK();
					num = (zmfhj679eeKVFGnbhli() ? 2 : 12);
				}
				else
				{
					Region = new EditRegionViewModel(InSight, cells, loc, (string)f1IVP17ACP01jvQP4AF(), fNfUlt7R7rGqnEZ5V9x(InputImage));
					num = 4;
				}
				continue;
			case 10:
				AddProperty(InputRegion);
				return;
			case 13:
				return;
			case 14:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__22))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CShiftEditGraphics_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				stateMachine._003C_003Et__builder = oIwNlN7WDcTE3vC4wfi();
				num = 0;
				if (zmfhj679eeKVFGnbhli())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine.delta = delta;
				goto default;
			default:
				_ = 1;
				num = (H222g274VC9tuxInysK() ? 1 : 5);
				break;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
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
		H222g274VC9tuxInysK();
		int num;
		if (zmfhj679eeKVFGnbhli())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (!zmfhj679eeKVFGnbhli())
			{
				goto IL_0087;
			}
		}
		goto IL_0040;
		IL_0040:
		CvsEditableDisplayGraphic graphic = default;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (graphic != null)
				{
					break;
				}
				goto case 6;
			default:
				num = 5;
				continue;
			case 0:
			case 4:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 5:
				break;
			case 1:
			case 3:
				graphic = Region.Graphic;
				num = 2;
				continue;
			case 6:
				return (CvsEditableDisplayGraphic[])n1a6817TJyP7MjwwRJs(list);
			}
			break;
		}
		goto IL_0087;
		IL_0087:
		list.Add(graphic);
		num = 6;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__24))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H222g274VC9tuxInysK();
		int num;
		if (zmfhj679eeKVFGnbhli())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (!zmfhj679eeKVFGnbhli())
			{
				goto IL_0091;
			}
		}
		goto IL_005a;
		IL_0091:
		_003CWriteFixturedGraphics_003Ed__24 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		if (0 == 0)
		{
			goto IL_005a;
		}
		goto IL_00a5;
		IL_00a5:
		stateMachine._003C_003Et__builder = oIwNlN7WDcTE3vC4wfi();
		num = 4;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				break;
			case 0:
			case 2:
				goto IL_00a5;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0091;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kI9X7877cLBdJWUU0sv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zmfhj679eeKVFGnbhli()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H222g274VC9tuxInysK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o3rhO7732PA8nxYvkSt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eYyoeP7jQlh5ihpgOoI(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object edOWCn76lHCBwWRqWSn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NKOf4L7CHiSnAo6bprW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rcKYeAISOR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f1IVP17ACP01jvQP4AF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation fNfUlt7R7rGqnEZ5V9x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder oIwNlN7WDcTE3vC4wfi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n1a6817TJyP7MjwwRJs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}
}
