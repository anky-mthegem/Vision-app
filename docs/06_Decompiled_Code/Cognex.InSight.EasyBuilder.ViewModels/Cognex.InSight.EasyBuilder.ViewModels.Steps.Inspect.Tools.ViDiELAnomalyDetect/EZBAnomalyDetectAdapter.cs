using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELAnomalyDetect;

public class EZBAnomalyDetectAdapter : AnomalyDetectAdapterBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunToolAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EZBAnomalyDetectAdapter _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (cpi6ARK9xhrin7C1vcly() ? 3 : 5);
			int num2 = default;
			EZBAnomalyDetectAdapter eZBAnomalyDetectAdapter = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					eZBAnomalyDetectAdapter = _003C_003E4__this;
					goto case 2;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 14;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 1;
							break;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 10;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								_003C_003Eu__2 = awaiter;
								num3 = 0;
								continue;
							case 10:
								_003C_003Eu__2 = default;
								num3 = 12;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter2;
								_ = 0;
								if (U7dZNGK9Hc3y04QKOv9B())
								{
									num3 = 9;
									continue;
								}
								num3 = 6;
								if (U7dZNGK9Hc3y04QKOv9B())
								{
									continue;
								}
								goto case 0;
							case 15:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								continue;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 6;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 2:
								return;
							case 14:
								awaiter2 = nDGdOBK9mJfb1XWlxEyu(eZBAnomalyDetectAdapter.o06DKrgXJv());
								if (!awaiter2.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 4;
							case 3:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 2;
								continue;
							case 5:
								return;
							case 4:
								awaiter2.GetResult();
								awaiter = ((CvsCogSocketSheet)q4mhrWK92KLLotrbSZpH(wEZYsCK9NSNru9OTVJy1(ifTmWGK9QJaL31G03v8n(eZBAnomalyDetectAdapter)))).RunAsync(true).GetAwaiter();
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (!cpi6ARK9xhrin7C1vcly())
								{
									continue;
								}
								break;
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
					goto case 1;
				default:
					num = 1;
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
		internal static TaskAwaiter nDGdOBK9mJfb1XWlxEyu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ifTmWGK9QJaL31G03v8n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wEZYsCK9NSNru9OTVJy1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object q4mhrWK92KLLotrbSZpH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U7dZNGK9Hc3y04QKOv9B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cpi6ARK9xhrin7C1vcly()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string k2KDZTibJI;

	private InspectStepViewModel iAsDndGDiB;

	private InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iAsDndGDiB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_00fd;
			IL_002f:
			if (iAsDndGDiB != null)
			{
				num = 4;
				goto IL_00fd;
			}
			return;
			IL_00e4:
			iAsDndGDiB = value;
			goto IL_002f;
			IL_00fd:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
					goto IL_002f;
				case 2:
				case 5:
					iAsDndGDiB.SnippetPreRemove -= lR9DiuEbqE;
					goto IL_00e4;
				case 4:
					iAsDndGDiB.SnippetAdded += InsDktAGU3;
					num = 8;
					continue;
				case 8:
					iAsDndGDiB.SnippetPreRemove += lR9DiuEbqE;
					num = 9;
					if (aDNOGNBooBvX7PR3mlu())
					{
					}
					continue;
				case 6:
					goto IL_00b7;
				case 3:
				case 7:
					goto IL_00e4;
				default:
					num = 0;
					continue;
				case 9:
					return;
				}
				break;
				IL_00b7:
				iAsDndGDiB.SnippetAdded -= InsDktAGU3;
				_ = 1;
				num = ((!aDNOGNBooBvX7PR3mlu()) ? 5 : 7);
			}
			goto IL_001a;
			IL_001a:
			if (iAsDndGDiB == null)
			{
				goto IL_00e4;
			}
			num = 6;
			goto IL_00fd;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EZBAnomalyDetectAdapter(InspectStepViewModel inspect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				base._002Ector((CvsInSight)xQt4dCBSWJfOECsEU8M(inspect), ((IRuntimeService)lKihrRBk0XmPBjPgfMA(inspect)).TriggerOnce);
				num = 0;
				break;
			default:
				zdEFZ2BqBh0xxgXR5rv(rCO1oQB8pbeZXYqPVmv(this), new EventHandler(kbQDsBS1TU));
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				aDNOGNBooBvX7PR3mlu();
				if (qMfIYYBGvS8R7QsDcLA())
				{
					num = 5;
					if (!aDNOGNBooBvX7PR3mlu())
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				break;
			case 0:
				Inspect = inspect;
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qMfIYYBGvS8R7QsDcLA();
		int num = (aDNOGNBooBvX7PR3mlu() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				Inspect = null;
				num = 1;
				break;
			case 4:
				uw4f3EBENI7ZsvLkjQP(rCO1oQB8pbeZXYqPVmv(this), new EventHandler(kbQDsBS1TU));
				goto default;
			default:
				NRphWCBptBTfcXyXBx4(this);
				num = 6;
				break;
			case 1:
				if (rCO1oQB8pbeZXYqPVmv(this) != null)
				{
					num = 4;
					break;
				}
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task lR9DiuEbqE(object P_0, SnippetPreRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!qMfIYYBGvS8R7QsDcLA()) ? 3 : 4);
		ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				DPgRQCB9tFD99nhfcPx(viDiELAnomalyDetectTool, new EventHandler(sK8DPDKILv));
				goto case 5;
			default:
				num = 5;
				if (qMfIYYBGvS8R7QsDcLA())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				if (viDiELAnomalyDetectTool != null)
				{
					num = 2;
					continue;
				}
				break;
			case 5:
				Fb05GwB7VDft8B6IDx2(this, ywKTj0B4y5qv4SUNc9D(viDiELAnomalyDetectTool));
				num = 6;
				continue;
			case 0:
			case 4:
				viDiELAnomalyDetectTool = MmVpDaBXsulAuDk27tk(P_1) as ViDiELAnomalyDetectTool;
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		return (Task)XkdaoxB3xGWk7Vd4K8w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task InsDktAGU3(object P_0, SnippetAddedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (aDNOGNBooBvX7PR3mlu() ? 5 : 4);
		ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
		while (true)
		{
			switch (num)
			{
			default:
				k2KDZTibJI = (string)ywKTj0B4y5qv4SUNc9D(viDiELAnomalyDetectTool);
				num = 6;
				continue;
			case 1:
				if (viDiELAnomalyDetectTool != null)
				{
					num = 2;
					continue;
				}
				break;
			case 2:
				viDiELAnomalyDetectTool.FocusChanged += sK8DPDKILv;
				goto default;
			case 0:
			case 4:
				viDiELAnomalyDetectTool = P_1.Snippet as ViDiELAnomalyDetectTool;
				num = 1;
				continue;
			case 6:
				break;
			}
			break;
		}
		return (Task)XkdaoxB3xGWk7Vd4K8w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sK8DPDKILv(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		InternalCheckBoxViewModel internalCheckBoxViewModel = default;
		ViDiELAnomalyDetectTool viDiELAnomalyDetectTool = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 3:
				internalCheckBoxViewModel = P_0 as InternalCheckBoxViewModel;
				aDNOGNBooBvX7PR3mlu();
				if (qMfIYYBGvS8R7QsDcLA())
				{
					num = 5;
					break;
				}
				num = 0;
				if (aDNOGNBooBvX7PR3mlu())
				{
				}
				break;
			case 0:
			case 4:
				if (viDiELAnomalyDetectTool != null)
				{
					num = 7;
					break;
				}
				return;
			case 2:
				obj = null;
				goto IL_005a;
			case 6:
			{
				InspectStepViewModel inspectStepViewModel = Inspect;
				if (inspectStepViewModel != null)
				{
					obj = inspectStepViewModel.btvmHNqEjR(internalCheckBoxViewModel.CellName);
					goto IL_005a;
				}
				goto case 2;
			}
			default:
				num = 2;
				break;
			case 1:
			case 5:
				if (internalCheckBoxViewModel != null)
				{
					num = 6;
					if (qMfIYYBGvS8R7QsDcLA())
					{
						break;
					}
					goto case 7;
				}
				return;
			case 7:
				{
					k2KDZTibJI = (kl71iWBjM1sW6IEVbol(internalCheckBoxViewModel) ? viDiELAnomalyDetectTool.ToolId : "");
					return;
				}
				IL_005a:
				viDiELAnomalyDetectTool = obj as ViDiELAnomalyDetectTool;
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kbQDsBS1TU(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qMfIYYBGvS8R7QsDcLA();
		int num;
		if (!aDNOGNBooBvX7PR3mlu())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0051;
		IL_0078:
		OnNewResult(k2KDZTibJI);
		num = 5;
		goto IL_0051;
		IL_0051:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_0078;
			case 0:
			case 4:
				if (!PlKnryB6MTcnRaxyc3t(k2KDZTibJI))
				{
					break;
				}
				return;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		if (((IRuntimeModeService)ieYau2BCXacUF25xwI2(iAsDndGDiB)).IsOperatorOfflineAndNotInLiveMode)
		{
			goto IL_0078;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResourceNode GetToolNode(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (ResourceNode)ztnDV3BWxMIGRm9B1Bn(((CvsCogSocket)UeKcwrBAcCfu7uFaXA5(rCO1oQB8pbeZXYqPVmv(this))).Sheet, pIFVHmBROabf9b2c0g7(toolId));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__12))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		aDNOGNBooBvX7PR3mlu();
		int num = ((!qMfIYYBGvS8R7QsDcLA()) ? 3 : 4);
		_003CRunToolAsync_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = XxD8ONBTvyPu2O8ivC4();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AnomalyDetectToolApi GetTool(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectToolApi anomalyDetectToolApi = new AnomalyDetectToolApi();
		A51eFtB0Cqb5ipnTnx7(anomalyDetectToolApi, MZwS48ByqNdm6VjR8sE(this, toolId));
		return anomalyDetectToolApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task o06DKrgXJv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RunToolAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xQt4dCBSWJfOECsEU8M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lKihrRBk0XmPBjPgfMA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rCO1oQB8pbeZXYqPVmv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zdEFZ2BqBh0xxgXR5rv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qMfIYYBGvS8R7QsDcLA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aDNOGNBooBvX7PR3mlu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uw4f3EBENI7ZsvLkjQP(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NRphWCBptBTfcXyXBx4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MmVpDaBXsulAuDk27tk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetPreRemoveEventArgs)P_0).Snippet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DPgRQCB9tFD99nhfcPx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAnomalyDetectTool)P_0).FocusChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ywKTj0B4y5qv4SUNc9D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELEzToolBase)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Fb05GwB7VDft8B6IDx2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).ClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XkdaoxB3xGWk7Vd4K8w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kl71iWBjM1sW6IEVbol(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InternalCheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PlKnryB6MTcnRaxyc3t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ieYau2BCXacUF25xwI2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UeKcwrBAcCfu7uFaXA5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pIFVHmBROabf9b2c0g7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ztnDV3BWxMIGRm9B1Bn(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder XxD8ONBTvyPu2O8ivC4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MZwS48ByqNdm6VjR8sE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A51eFtB0Cqb5ipnTnx7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AnomalyDetectToolApi)P_0).ToolNode = (ResourceNode)P_1;
	}
}
