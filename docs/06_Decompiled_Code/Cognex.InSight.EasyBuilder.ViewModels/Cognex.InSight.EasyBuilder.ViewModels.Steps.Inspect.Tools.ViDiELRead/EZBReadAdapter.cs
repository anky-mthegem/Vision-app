using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.Read;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead;

public class EZBReadAdapter : ReadAdapterBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunToolAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EZBReadAdapter _003C_003E4__this;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SJ01TlKE0L2xtI7j7vR5();
			int num;
			if (w7H89wKEyO0ohQ8TtZNj())
			{
				num = 5;
				if (!w7H89wKEyO0ohQ8TtZNj())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (SJ01TlKE0L2xtI7j7vR5())
				{
				}
			}
			goto IL_01a2;
			IL_004f:
			int num2 = default;
			EZBReadAdapter eZBReadAdapter = default;
			try
			{
				TaskAwaiter<CvsCogSheetResult> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((CvsInSight)bYCT7SKEFjSPOW5RUEMk(eZBReadAdapter)).CogSocket.Sheet.RunAsync().GetAwaiter();
					num3 = 3;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 0;
					if (1 == 0)
					{
						goto IL_00d6;
					}
				}
				goto IL_012a;
				IL_00eb:
				num2 = (_003C_003E1__state = 0);
				_ = 1;
				num3 = (SJ01TlKE0L2xtI7j7vR5() ? 1 : 7);
				goto IL_012a;
				IL_00d6:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				if (false)
				{
					goto IL_00eb;
				}
				goto IL_012a;
				IL_012a:
				while (true)
				{
					switch (num3)
					{
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto case 9;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						continue;
					case 0:
						_003C_003Eu__1 = default;
						break;
					case 5:
						return;
					case 1:
					case 6:
						break;
					case 8:
						goto IL_00eb;
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 5;
						continue;
					case 9:
						awaiter.GetResult();
						goto end_IL_004f;
					}
					break;
				}
				goto IL_00d6;
				end_IL_004f:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01cd;
			IL_01a2:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 2:
				case 4:
					goto IL_004f;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_01cd;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			eZBReadAdapter = _003C_003E4__this;
			goto IL_004f;
			IL_01cd:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a2;
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
		internal static object bYCT7SKEFjSPOW5RUEMk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w7H89wKEyO0ohQ8TtZNj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SJ01TlKE0L2xtI7j7vR5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string e68oyE6tpW;

	private readonly Action<string, string> GeKoxK9MSw;

	private InspectStepViewModel oX6ov2XGI1;

	private InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oX6ov2XGI1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!Kdbaa7vNI9WJHUVXabO())
			{
				goto IL_001e;
			}
			goto IL_006a;
			IL_0051:
			oX6ov2XGI1 = value;
			goto IL_0099;
			IL_00b6:
			if (oX6ov2XGI1 == null)
			{
				goto IL_0051;
			}
			num = 6;
			goto IL_006a;
			IL_0099:
			if (oX6ov2XGI1 != null)
			{
				goto IL_00cb;
			}
			return;
			IL_001e:
			oX6ov2XGI1.SnippetPreRemove -= QTOoCW6UVJ;
			VGEEahv2D9MZPVxyw7Q();
			if (Kdbaa7vNI9WJHUVXabO())
			{
				num = 0;
				if (false)
				{
					goto IL_0051;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_00b6;
				}
			}
			goto IL_006a;
			IL_006a:
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 0:
				case 2:
					goto IL_0051;
				default:
					num = 5;
					continue;
				case 5:
					goto IL_0099;
				case 1:
					goto IL_00b6;
				case 3:
				case 4:
					goto IL_00cb;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_00cb:
			oX6ov2XGI1.SnippetPreRemove += QTOoCW6UVJ;
			num = 7;
			goto IL_006a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EZBReadAdapter(InspectStepViewModel inspect, Action<string, string> notifyFlexibleFieldingChanged = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(inspect.InSight, inspect.RuntimeService.TriggerOnce);
		e68oyE6tpW = "";
		GeKoxK9MSw = notifyFlexibleFieldingChanged;
		Inspect = inspect;
		InSight.ResultsChanged += YCioO9maZS;
		FlexibleFieldingChanged += jIGojR05gH;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Kdbaa7vNI9WJHUVXabO();
		int num = (VGEEahv2D9MZPVxyw7Q() ? 5 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				Inspect = null;
				num = 1;
				continue;
			case 1:
				if (InSight == null)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				axkcOwv1AhaV06KMmho(PcY1IXvcvFWTqqvi2x2(this), new EventHandler(YCioO9maZS));
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 6:
				return;
			}
			heyZcJvuqdUEMMlC3Kk(this);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jIGojR05gH(object P_0, FlexibleFieldingEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GeKoxK9MSw?.Invoke(e68oyE6tpW, (string)e9UQXnvhjgmPtELRgIL(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task QTOoCW6UVJ(object P_0, SnippetPreRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Kdbaa7vNI9WJHUVXabO();
		int num = (VGEEahv2D9MZPVxyw7Q() ? 4 : 3);
		ViDiELReadTool viDiELReadTool = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				FWLCskvz4rPJmHQCT3I(this, aymDBPvt6ZRmSCo89FJ(viDiELReadTool));
				num = 5;
				continue;
			case 1:
			case 4:
				if (viDiELReadTool == null)
				{
					break;
				}
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				viDiELReadTool = P_1.Snippet as ViDiELReadTool;
				goto case 1;
			case 5:
				break;
			}
			break;
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOnPropertyChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		InternalCheckBoxViewModel internalCheckBoxViewModel = default;
		ViDiELReadTool viDiELReadTool = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 2:
			case 3:
			{
				InspectStepViewModel inspectStepViewModel = Inspect;
				if (inspectStepViewModel == null)
				{
					goto case 5;
				}
				obj = inspectStepViewModel.btvmHNqEjR((string)WVP7fhrLEYx7BM9oHAQ(internalCheckBoxViewModel));
				goto IL_009a;
			}
			default:
				num = 5;
				break;
			case 4:
				internalCheckBoxViewModel = sender as InternalCheckBoxViewModel;
				Kdbaa7vNI9WJHUVXabO();
				if (!VGEEahv2D9MZPVxyw7Q())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				num = 3;
				break;
			case 5:
				obj = null;
				goto IL_009a;
			case 6:
				if (viDiELReadTool != null)
				{
					num = 7;
					break;
				}
				return;
			case 0:
			case 1:
				if (internalCheckBoxViewModel != null)
				{
					goto case 2;
				}
				return;
			case 7:
				{
					e68oyE6tpW = (internalCheckBoxViewModel.Value ? viDiELReadTool.ToolId : "");
					return;
				}
				IL_009a:
				viDiELReadTool = obj as ViDiELReadTool;
				num = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YCioO9maZS(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Kdbaa7vNI9WJHUVXabO();
		int num;
		if (!VGEEahv2D9MZPVxyw7Q())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (VGEEahv2D9MZPVxyw7Q())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				s6XlLTr5kPOXmyOSKUd(this, e68oyE6tpW);
				num = 5;
				break;
			case 1:
			case 2:
				if (lCOKHerKHRRmh2L8QH5(Inspect.RuntimeModeService))
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				if (!string.IsNullOrEmpty(e68oyE6tpW))
				{
					goto case 1;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResourceNode GetToolNode(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (ResourceNode)WihLr5racmwHt77xDh2(Chf9MRrwlsqik85qqi6(((CvsInSight)PcY1IXvcvFWTqqvi2x2(this)).CogSocket), rWXZHlrJ6bsGKMC20Ol(toolId));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__13))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGEEahv2D9MZPVxyw7Q();
		int num = ((!Kdbaa7vNI9WJHUVXabO()) ? 4 : 2);
		_003CRunToolAsync_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = c84dbKreoHGUBDfFJ3B();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PcY1IXvcvFWTqqvi2x2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void axkcOwv1AhaV06KMmho(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void heyZcJvuqdUEMMlC3Kk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Kdbaa7vNI9WJHUVXabO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VGEEahv2D9MZPVxyw7Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e9UQXnvhjgmPtELRgIL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FlexibleFieldingEventArgs)P_0).FlexibleFieldingValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aymDBPvt6ZRmSCo89FJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELEzToolBase)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FWLCskvz4rPJmHQCT3I(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).ClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WVP7fhrLEYx7BM9oHAQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lCOKHerKHRRmh2L8QH5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s6XlLTr5kPOXmyOSKUd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ReadAdapterBase)P_0).OnNewResult((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Chf9MRrwlsqik85qqi6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation rWXZHlrJ6bsGKMC20Ol(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WihLr5racmwHt77xDh2(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder c84dbKreoHGUBDfFJ3B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
