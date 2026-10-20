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

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ImageFilter;

[Export(typeof(ImageFilterTool))]
public class ImageFilterTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImageFilterTool _003C_003E4__this;

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
			ImageFilterTool imageFilterTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (ArmB0rK0GbYf3JOUW84o())
					{
						break;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = j3XwZgK0S5DMeQbtQvJf(imageFilterTool.Region.Shift(delta));
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 8:
								return;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = ((!zVNsnMK0outJJWIYfjXl()) ? 7 : 8);
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
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
					goto case 5;
				default:
					num = 5;
					break;
				case 4:
					num2 = _003C_003E1__state;
					ArmB0rK0GbYf3JOUW84o();
					num = (zVNsnMK0outJJWIYfjXl() ? 3 : 0);
					break;
				case 0:
				case 1:
					imageFilterTool = _003C_003E4__this;
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
		internal static TaskAwaiter j3XwZgK0S5DMeQbtQvJf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ArmB0rK0GbYf3JOUW84o()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zVNsnMK0outJJWIYfjXl()
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
	private struct _003CWriteFixturedGraphics_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImageFilterTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter2 = default;
			TaskAwaiter awaiter = default;
			ImageFilterTool imageFilterTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 5;
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 7;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 2;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Eu__2 = awaiter2;
								num3 = 14;
								continue;
							case 7:
								_003C_003Eu__2 = default;
								goto case 0;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								xZm3a2K0kdx4fG8pfC37();
								num3 = ((!e7vCGsK08kym6hRNmEAN()) ? 1 : 0);
								continue;
							case 1:
							case 11:
								return;
							case 4:
								awaiter2 = ((CvsCogSocket)PuPJQGK09EJ20N3h93GM(imageFilterTool.InSight)).Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 15;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								}
								goto IL_01a4;
							case 0:
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 9:
								return;
							case 15:
								if (awaiter2.IsCompleted)
								{
									break;
								}
								num2 = (_003C_003E1__state = 1);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								awaiter = icRd70K0XEeO34KvxLxv(lpoHMMK0pyyBd58PXkxm(imageFilterTool.InSight, TXSZLpK0qWY4MNKeWSfx(imageFilterTool.Region), MoPfPrK0EgsaQCeyetGs(imageFilterTool.Region)));
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto IL_01a4;
							default:
								num3 = 4;
								if (!e7vCGsK08kym6hRNmEAN())
								{
									continue;
								}
								break;
							case 16:
								break;
								IL_01a4:
								awaiter.GetResult();
								goto case 4;
							}
							break;
						}
						awaiter2.GetResult();
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
				case 0:
				case 1:
					imageFilterTool = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					xZm3a2K0kdx4fG8pfC37();
					if (e7vCGsK08kym6hRNmEAN())
					{
						num = 3;
						break;
					}
					num = 0;
					if (!xZm3a2K0kdx4fG8pfC37())
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
		internal static CvsCellLocation TXSZLpK0qWY4MNKeWSfx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MoPfPrK0EgsaQCeyetGs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lpoHMMK0pyyBd58PXkxm(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter icRd70K0XEeO34KvxLxv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PuPJQGK09EJ20N3h93GM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xZm3a2K0kdx4fG8pfC37()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e7vCGsK08kym6hRNmEAN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ImageViewModel z73RoymDlZ;

	[CompilerGenerated]
	private ListBoxViewModel SNKRSDndXZ;

	[CompilerGenerated]
	private EditIntViewModel C3oRD4LLl5;

	[CompilerGenerated]
	private EditIntViewModel IcQR3ino4j;

	[CompilerGenerated]
	private CheckBoxViewModel psORIlyFWd;

	[CompilerGenerated]
	private EditIntViewModel vmARfyOcAF;

	[CompilerGenerated]
	private EditIntViewModel o7WREg3VUp;

	[CompilerGenerated]
	private EditIntViewModel EvvRbJF0em;

	[CompilerGenerated]
	private EditFloatViewModel fNfRcTvkAo;

	[CompilerGenerated]
	private EditIntViewModel N4nRQq0EIG;

	[CompilerGenerated]
	private EditRegionViewModel KfMRgI0Il6;

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
			return z73RoymDlZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			z73RoymDlZ = value;
		}
	}

	public ListBoxViewModel Filter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SNKRSDndXZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SNKRSDndXZ = value;
		}
	}

	public EditIntViewModel KernelRows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C3oRD4LLl5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C3oRD4LLl5 = value;
		}
	}

	public EditIntViewModel KernelColumns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IcQR3ino4j;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IcQR3ino4j = value;
		}
	}

	public CheckBoxViewModel AutoThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return psORIlyFWd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			psORIlyFWd = value;
		}
	}

	public EditIntViewModel Threshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vmARfyOcAF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vmARfyOcAF = value;
		}
	}

	public EditIntViewModel Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o7WREg3VUp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o7WREg3VUp = value;
		}
	}

	public EditIntViewModel Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EvvRbJF0em;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EvvRbJF0em = value;
		}
	}

	public EditFloatViewModel Gain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fNfRcTvkAo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fNfRcTvkAo = value;
		}
	}

	public EditIntViewModel Smoothness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N4nRQq0EIG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N4nRQq0EIG = value;
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
			return KfMRgI0Il6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KfMRgI0Il6 = value;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageFilterTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fZ8bju4v9UDvUbX7ntd();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 34;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 37:
				if (num2 != 3610299293u)
				{
					num = 35;
					break;
				}
				if (K0ti1u4PA3IGIuhp5MX(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24684)))
				{
					KernelRows = new EditIntViewModel(InSight, cells, loc, (string)EPLfNH48dJxPNy2JdWI());
					AddProperty(KernelRows);
					num = 38;
					if (Rx1qIi4sndH0Ks55hON())
					{
					}
					break;
				}
				num = 20;
				if (true)
				{
					break;
				}
				goto case 29;
			case 4:
				return;
			case 24:
				AddProperty(Filter);
				num = 31;
				if (1 == 0)
				{
					return;
				}
				break;
			case 31:
				return;
			case 3:
			case 21:
				if (num2 == 781469175)
				{
					if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)))
					{
						num = 2;
						break;
					}
					Min = new EditIntViewModel(InSight, cells, loc, (string)qejn7n4X0HdNI7lA2Rc());
					AddProperty(Min);
					num = 18;
				}
				else
				{
					num = 29;
					if (false)
					{
						return;
					}
				}
				break;
			case 7:
				return;
			case 34:
				num2 = SRL6vh4rmUF8oQgsn2L(relativeCellName);
				num = 32;
				break;
			case 15:
				AddProperty(AutoThreshold);
				num = 14;
				break;
			case 23:
				if (num2 == 1227782301)
				{
					if (!(relativeCellName == (string)V9SZ8L4ZHxB5ZyuChqE(5684)))
					{
						num = 22;
						if (true)
						{
							break;
						}
						goto case 34;
					}
					Region = new EditRegionViewModel(InSight, cells, loc, (string)PL7HUf4oETyDj7cpuho(), BHhC5n4SdZMM0hE6Q0F(InputImage));
					AddProperty(Region);
					num = 25;
					break;
				}
				num = 33;
				break;
			case 6:
				if (num2 != 4249096401u)
				{
					num = 7;
				}
				else if (K0ti1u4PA3IGIuhp5MX(relativeCellName, V9SZ8L4ZHxB5ZyuChqE(19366)))
				{
					AutoThreshold = new CheckBoxViewModel(InSight, cells, loc, (string)RUxCt24EqsXevAa4bW5(), IsInitialized);
					num = 15;
				}
				else
				{
					num = 26;
				}
				break;
			case 11:
				return;
			case 2:
				return;
			default:
				num = 9;
				if (1 == 0)
				{
					return;
				}
				break;
			case 19:
				return;
			case 26:
				return;
			case 32:
				if (num2 <= 2092037521)
				{
					if (num2 <= 1017635769)
					{
						num = 16;
						if (!Rx1qIi4sndH0Ks55hON())
						{
							break;
						}
						goto case 33;
					}
					if (num2 == 1195222419)
					{
						if (!K0ti1u4PA3IGIuhp5MX(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7570)))
						{
							return;
						}
						InputRegion = new InputRegionViewModel(this, cells, loc, (string)zaq5Tp4bhR7bTG2pBrs(), (string)jMxD6c4G8oddIa7dvVT(), Region, IsInitialized);
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 12;
					}
					num = 23;
					break;
				}
				if (num2 <= 3809547600u)
				{
					num = 28;
					break;
				}
				if (num2 == 3894442339u)
				{
					if (!K0ti1u4PA3IGIuhp5MX(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24708)))
					{
						return;
					}
					KernelColumns = new EditIntViewModel(InSight, cells, loc, (string)rw23tE4qSj6nmsxWBpk());
					num = 13;
					break;
				}
				goto case 10;
			case 33:
				if (num2 != 2092037521 || !K0ti1u4PA3IGIuhp5MX(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24642)))
				{
					return;
				}
				OutputImage = new ImageViewModel(InSight, cells, loc, (string)m3KqJU4B8ZXcvca6OdQ());
				num = 12;
				break;
			case 14:
				return;
			case 18:
				return;
			case 8:
				return;
			case 30:
				AddProperty(Gain);
				num = 36;
				if (EbuWBL4g06Tf9JY437s())
				{
					break;
				}
				goto case 10;
			case 10:
			case 27:
				if (num2 != 4104765591u)
				{
					num = 6;
					if (1 == 0)
					{
						return;
					}
				}
				else if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(24668))
				{
					Filter = new ListBoxViewModel(InSight, cells, loc, (string)omM8vP4k0xa20DiS2cN());
					num = 24;
				}
				else
				{
					num = 17;
				}
				break;
			case 20:
				return;
			case 25:
				return;
			case 17:
				return;
			case 29:
				if (num2 != 1017635769 || !K0ti1u4PA3IGIuhp5MX(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
				{
					return;
				}
				Max = new EditIntViewModel(InSight, cells, loc, (string)OX7iV449au1OuxM9tOy());
				AddProperty(Max);
				num = 8;
				if (1 == 0)
				{
					return;
				}
				break;
			case 16:
				if (num2 == 394884504)
				{
					if (!K0ti1u4PA3IGIuhp5MX(relativeCellName, V9SZ8L4ZHxB5ZyuChqE(24738)))
					{
						num = 4;
						break;
					}
					Threshold = new EditIntViewModel(InSight, cells, loc, (string)sffUnZ4pdVaXn574PnS());
					AddProperty(Threshold);
					num = 1;
					if (Rx1qIi4sndH0Ks55hON())
					{
						return;
					}
					break;
				}
				_ = 0;
				if (EbuWBL4g06Tf9JY437s())
				{
					num = 21;
					if (!EbuWBL4g06Tf9JY437s())
					{
						return;
					}
				}
				else
				{
					num = 27;
				}
				break;
			case 36:
				return;
			case 13:
				AddProperty(KernelColumns);
				num = 11;
				break;
			case 28:
				if (num2 != 2608886558u)
				{
					num = 37;
					break;
				}
				if (K0ti1u4PA3IGIuhp5MX(relativeCellName, V9SZ8L4ZHxB5ZyuChqE(24760)))
				{
					Gain = new EditFloatViewModel(InSight, cells, loc, (string)hdUD9p44iQ9h5okm3ff());
					num = 30;
					break;
				}
				return;
			case 35:
				if (num2 == 3809547600u && K0ti1u4PA3IGIuhp5MX(relativeCellName, V9SZ8L4ZHxB5ZyuChqE(24772)))
				{
					Smoothness = new EditIntViewModel(InSight, cells, loc, (string)FPP7l0477s7TKHWL82N());
					AddProperty(Smoothness);
					num = 39;
					if (0 == 0)
					{
						break;
					}
					goto case 13;
				}
				return;
			case 22:
				return;
			case 9:
				return;
			case 38:
				return;
			case 5:
				return;
			case 12:
				AddProperty(OutputImage);
				num = 5;
				break;
			case 0:
				AddProperty(InputRegion);
				num = 19;
				if (false)
				{
					return;
				}
				break;
			case 1:
				return;
			case 39:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__48))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!EbuWBL4g06Tf9JY437s()) ? 4 : 3);
		_003CShiftEditGraphics_003Ed__48 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = BaV4Oe433CKtgjxiHAQ();
				goto case 1;
			case 5:
				stateMachine.delta = delta;
				goto case 6;
			default:
				num = 6;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (Rx1qIi4sndH0Ks55hON() ? 4 : 2);
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic graphic = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				list.Add(graphic);
				num = 6;
				continue;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 3:
				if (graphic == null)
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 4:
				graphic = Region.Graphic;
				num = 3;
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
		return (CvsEditableDisplayGraphic[])HSy34U4jPaoVpcjDDq8(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__50))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!EbuWBL4g06Tf9JY437s())
		{
			goto IL_001e;
		}
		goto IL_004a;
		IL_001e:
		_003CWriteFixturedGraphics_003Ed__50 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = BaV4Oe433CKtgjxiHAQ();
				_ = 1;
				if (Rx1qIi4sndH0Ks55hON())
				{
					num = 2;
					continue;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fZ8bju4v9UDvUbX7ntd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EbuWBL4g06Tf9JY437s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rx1qIi4sndH0Ks55hON()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint SRL6vh4rmUF8oQgsn2L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K0ti1u4PA3IGIuhp5MX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V9SZ8L4ZHxB5ZyuChqE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m3KqJU4B8ZXcvca6OdQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zaq5Tp4bhR7bTG2pBrs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jMxD6c4G8oddIa7dvVT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rcKYeAISOR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PL7HUf4oETyDj7cpuho()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation BHhC5n4SdZMM0hE6Q0F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object omM8vP4k0xa20DiS2cN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Filter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EPLfNH48dJxPNy2JdWI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.KernelRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rw23tE4qSj6nmsxWBpk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.KernelColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RUxCt24EqsXevAa4bW5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AutoThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sffUnZ4pdVaXn574PnS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Threshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qejn7n4X0HdNI7lA2Rc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OX7iV449au1OuxM9tOy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hdUD9p44iQ9h5okm3ff()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Gain;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FPP7l0477s7TKHWL82N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Smoothness;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder BaV4Oe433CKtgjxiHAQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HSy34U4jPaoVpcjDDq8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}
}
