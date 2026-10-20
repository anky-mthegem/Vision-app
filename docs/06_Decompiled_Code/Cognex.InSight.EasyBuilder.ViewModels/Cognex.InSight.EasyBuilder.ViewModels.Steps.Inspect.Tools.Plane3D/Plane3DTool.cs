using System;
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
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Plane3D;

[Export(typeof(Plane3DTool))]
public class Plane3DTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteFixturedGraphics_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Plane3DTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			Plane3DTool plane3DTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					plane3DTool = _003C_003E4__this;
					_ = 1;
					num = (NxR5PjK3RIOxVmvqwqvA() ? 1 : 5);
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					if (qeL9SvK3A8RDSGvUZfTi())
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_00c4;
							}
							num3 = 15;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 9;
							if (1 == 0)
							{
								return;
							}
						}
						goto IL_01f4;
						IL_01f4:
						while (true)
						{
							switch (num3)
							{
							case 10:
								awaiter2.GetResult();
								num3 = 13;
								if (!NxR5PjK3RIOxVmvqwqvA())
								{
									continue;
								}
								goto case 2;
							case 2:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (qeL9SvK3A8RDSGvUZfTi())
									{
										num3 = 6;
										continue;
									}
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 9;
								}
								goto case 16;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
							case 12:
								break;
							case 6:
							case 8:
								goto IL_00dc;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 5;
								continue;
							case 15:
								awaiter2 = LZ8T62K3WGdG5Xi4YFgg(plane3DTool.GetViewableEditGraphics().Select(plane3DTool.NrZEO3w9ul).WhenAll());
								if (!awaiter2.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 10;
							case 5:
								return;
							case 14:
								return;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 13:
								awaiter = ((CvsCogSocketSheet)IcFFOnK3Tc5HqxFuNWIX(plane3DTool.InSight.CogSocket)).RunAsync(false).GetAwaiter();
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 3:
								_003C_003Eu__2 = awaiter;
								num3 = 0;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_00c4;
						IL_00c4:
						_003C_003Eu__2 = default;
						num3 = 4;
						if (false)
						{
							goto IL_00dc;
						}
						goto IL_01f4;
						IL_00dc:
						num2 = (_003C_003E1__state = 1);
						num3 = 3;
						goto IL_01f4;
						end_IL_0061:;
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
		internal static TaskAwaiter LZ8T62K3WGdG5Xi4YFgg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IcFFOnK3Tc5HqxFuNWIX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qeL9SvK3A8RDSGvUZfTi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NxR5PjK3RIOxVmvqwqvA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EditCompositeRegionViewModel G2NE2qsBEy;

	[CompilerGenerated]
	private EditCompositeRegionViewModel EjrEqK8qFu;

	[CompilerGenerated]
	private EditCompositeRegionViewModel WwJEieWyY7;

	[CompilerGenerated]
	private Plane3DViewModel F8SEkxJjL3;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PlaneIcon;
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
			return OutputPlane;
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

	public EditCompositeRegionViewModel Region1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return G2NE2qsBEy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G2NE2qsBEy = value;
		}
	}

	public EditCompositeRegionViewModel Region2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EjrEqK8qFu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EjrEqK8qFu = value;
		}
	}

	public EditCompositeRegionViewModel Region3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WwJEieWyY7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WwJEieWyY7 = value;
		}
	}

	public Plane3DViewModel OutputPlane
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F8SEkxJjL3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			F8SEkxJjL3 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Plane3DTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XREXXISNSrYlLKrv3LQ();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00bb;
		IL_001a:
		if (!wkNT3WSctp0ZHcg4GHd(relativeCellName, i1M6cLS2yn4IG4ByhtT(19132)))
		{
			urcDCUSmxd6uiuFPGNt();
			num = (W4K7L4SQfCtI8p7frTf() ? 10 : 8);
			goto IL_00bb;
		}
		Region1 = new EditCompositeRegionViewModel(InSight, cells, loc, Resources.Region, QHwUwtS1RNvKMcPtAjb(InputImage), IsInitialized, mustBeExtrudeable: true);
		goto IL_012e;
		IL_012e:
		AddProperty(Region1);
		num = 9;
		if (!urcDCUSmxd6uiuFPGNt())
		{
			return;
		}
		goto IL_00bb;
		IL_00bb:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 8:
				if (!wkNT3WSctp0ZHcg4GHd(relativeCellName, i1M6cLS2yn4IG4ByhtT(19150)))
				{
					num = 5;
					continue;
				}
				Region2 = new EditCompositeRegionViewModel(InSight, cells, loc, (string)v2uYGRSuDRuX7rC9BQM(), QHwUwtS1RNvKMcPtAjb(InputImage), IsInitialized, mustBeExtrudeable: true);
				goto case 12;
			case 0:
				AddProperty(Region3);
				num = 2;
				continue;
			case 9:
				return;
			default:
				num = 12;
				continue;
			case 12:
				AddProperty(Region2);
				num = 7;
				continue;
			case 6:
				AddProperty(OutputPlane);
				num = 13;
				continue;
			case 4:
			case 10:
				goto IL_012e;
			case 7:
				return;
			case 5:
				if (relativeCellName == (string)i1M6cLS2yn4IG4ByhtT(19168))
				{
					Region3 = new EditCompositeRegionViewModel(InSight, cells, loc, (string)v2uYGRSuDRuX7rC9BQM(), QHwUwtS1RNvKMcPtAjb(InputImage), IsInitialized, mustBeExtrudeable: true);
					num = 0;
					continue;
				}
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (!wkNT3WSctp0ZHcg4GHd(relativeCellName, i1M6cLS2yn4IG4ByhtT(19186)))
				{
					return;
				}
				OutputPlane = new Plane3DViewModel(InSight, cells, loc, (string)u8bLCSShSyrX37aKnWI());
				num = 6;
				continue;
			case 2:
				return;
			case 13:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__2))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!urcDCUSmxd6uiuFPGNt()) ? 1 : 3);
		_003CWriteFixturedGraphics_003Ed__2 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = uojIGAStAEHJugDEDw6();
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (W4K7L4SQfCtI8p7frTf())
				{
				}
				break;
			case 6:
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
		return NowEHrWl8V().Select([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel cvm) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (cvm as EditableGraphicsViewModel)?.Graphic;
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic graphic) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return graphic != null;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CellViewModel[] NowEHrWl8V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CellViewModel[4] { Region1, Region2, Region3, OutputPlane };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task NrZEO3w9ul(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)K0ty0VkLRjKVLq7xvjC(InSight, pGgxDjSzQHpfSifPLCq(P_0), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XREXXISNSrYlLKrv3LQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool urcDCUSmxd6uiuFPGNt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W4K7L4SQfCtI8p7frTf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i1M6cLS2yn4IG4ByhtT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wkNT3WSctp0ZHcg4GHd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation QHwUwtS1RNvKMcPtAjb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v2uYGRSuDRuX7rC9BQM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u8bLCSShSyrX37aKnWI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ThGJTlbv2H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder uojIGAStAEHJugDEDw6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pGgxDjSzQHpfSifPLCq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K0ty0VkLRjKVLq7xvjC(object P_0, CvsCellLocation loc, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
	}
}
