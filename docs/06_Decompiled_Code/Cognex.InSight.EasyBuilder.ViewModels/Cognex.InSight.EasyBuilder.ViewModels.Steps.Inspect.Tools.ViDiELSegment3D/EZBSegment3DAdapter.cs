using System;
using System.ComponentModel;
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
using Cognex.InSight.ViDiEL.ViewModels.Segment;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELSegment3D;

public class EZBSegment3DAdapter : SegmentAdapterBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunToolAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EZBSegment3DAdapter _003C_003E4__this;

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
			int num;
			if (!KSC5RAKq0xAPySjy3vdp())
			{
				num = 3;
				if (KSC5RAKq0xAPySjy3vdp())
				{
				}
			}
			else
			{
				num = 5;
			}
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			EZBSegment3DAdapter eZBSegment3DAdapter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
								if (1 == 0)
								{
									goto IL_0075;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 12;
						}
						goto IL_01d1;
						IL_0075:
						awaiter = ((CvsCogSocketSheet)AMveCyKqY6xLwK3sMZX5(WSxvLWKqManGvvLhddxQ(eZBSegment3DAdapter.InSight))).RunAsync(true).GetAwaiter();
						num3 = 8;
						if (KSC5RAKq0xAPySjy3vdp())
						{
							goto IL_00a1;
						}
						goto IL_01d1;
						IL_00a1:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_01d1;
						IL_01d1:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 7:
								break;
							case 10:
								goto IL_00a1;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 9:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								return;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 12:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (T8afbuKqy8Uenn37Jl6Z())
								{
									continue;
								}
								goto case 14;
							case 14:
								awaiter2 = i5n51HKqFxpK0qi38PA7(eZBSegment3DAdapter.MYuXF6VnO0());
								if (!awaiter2.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 0;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 10;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 1);
								num3 = 9;
								continue;
							case 6:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								}
								goto case 16;
							case 0:
								awaiter2.GetResult();
								goto default;
							default:
								_ = 0;
								if (!T8afbuKqy8Uenn37Jl6Z())
								{
									num3 = 6;
									continue;
								}
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Eu__1 = awaiter2;
								num3 = 1;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_005c;
							}
							break;
						}
						goto IL_0075;
						end_IL_005c:;
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
					continue;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				eZBSegment3DAdapter = _003C_003E4__this;
				num = 4;
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
		internal static TaskAwaiter i5n51HKqFxpK0qi38PA7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WSxvLWKqManGvvLhddxQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AMveCyKqY6xLwK3sMZX5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T8afbuKqy8Uenn37Jl6Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KSC5RAKq0xAPySjy3vdp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private InspectStepViewModel HjLXSiuUGF;

	private string N4nXDDd2BE;

	private InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HjLXSiuUGF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_00bd;
			IL_001a:
			HjLXSiuUGF.SnippetPreRemove += jrJXAE2VDP;
			num = 9;
			goto IL_00bd;
			IL_00bd:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 6:
					HjLXSiuUGF.SnippetPreRemove -= jrJXAE2VDP;
					YqUvvKsEaZuKjcEsfoi();
					if (deDR7HsqETVP3Dn7Gtr())
					{
						num = 7;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 2:
				case 5:
					HjLXSiuUGF.SnippetAdded += oD1XdaSSnE;
					num = 1;
					continue;
				case 8:
					if (HjLXSiuUGF != null)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 3:
				case 7:
					HjLXSiuUGF = value;
					goto case 0;
				default:
					num = 0;
					continue;
				case 0:
					if (HjLXSiuUGF != null)
					{
						goto case 2;
					}
					return;
				case 4:
					HjLXSiuUGF.SnippetAdded -= oD1XdaSSnE;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 9:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public string FocusedToolId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N4nXDDd2BE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N4nXDDd2BE = value;
		}
	}

	protected override int MaxNumClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EZBSegment3DAdapter(InspectStepViewModel inspect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 1:
				base._002Ector((CvsInSight)F1Z8eXsXNqxSvh9lbEk(inspect), ((IRuntimeService)HP3Iu4s9UbEr3fRXsEN(inspect)).TriggerOnce);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				Inspect = inspect;
				goto case 2;
			case 5:
				aETDQlspu9BZjeu41iC();
				num = 1;
				break;
			case 2:
			case 4:
				vGnskns7HqZ2KXTJxQa(zY6iBBs4CAAHipvwpAC(this), new EventHandler(FI8Xufk2Zm));
				num = 7;
				break;
			case 6:
				N4nXDDd2BE = "";
				goto default;
			default:
				_ = 0;
				if (!deDR7HsqETVP3Dn7Gtr())
				{
					num = 2;
					if (deDR7HsqETVP3Dn7Gtr())
					{
						break;
					}
					goto case 5;
				}
				num = 0;
				break;
			case 7:
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
		deDR7HsqETVP3Dn7Gtr();
		int num = (YqUvvKsEaZuKjcEsfoi() ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				if (zY6iBBs4CAAHipvwpAC(this) == null)
				{
					break;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				((CvsInSight)zY6iBBs4CAAHipvwpAC(this)).ResultsChanged -= FI8Xufk2Zm;
				break;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				Inspect = null;
				goto case 1;
			case 3:
				break;
			case 6:
				return;
			}
			ikFy2ys3k7tsODLpCKQ(this);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task jrJXAE2VDP(object P_0, SnippetPreRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YqUvvKsEaZuKjcEsfoi();
		int num;
		if (deDR7HsqETVP3Dn7Gtr())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_009c;
		IL_002a:
		string text = default;
		qMpDSwsAWusB5B6f3V8(this, text);
		num = 5;
		goto IL_009c;
		IL_009c:
		ViDiELSegment3DTool viDiELSegment3DTool = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (bUbsq7sRWnE3uhkkIHD(N4nXDDd2BE, text))
				{
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				}
				goto case 9;
			case 2:
				N4nXDDd2BE = "";
				num = 9;
				continue;
			case 8:
				if (viDiELSegment3DTool != null)
				{
					num = 6;
					if (!YqUvvKsEaZuKjcEsfoi())
					{
						continue;
					}
					goto case 3;
				}
				goto case 9;
			case 3:
				text = (string)GJqWrNsCYBU60o5GF8t(viDiELSegment3DTool);
				break;
			case 0:
			case 1:
				viDiELSegment3DTool = P_1.Snippet as ViDiELSegment3DTool;
				num = 8;
				continue;
			case 6:
				CDj3gss60fOeioaxGth(FWNbRksjiRT262lKi1o(viDiELSegment3DTool), new PropertyChangedEventHandler(fuKX6AAviK));
				num = 3;
				continue;
			case 9:
				return (Task)vWV3aisWIFcDInEVQ3J();
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task oD1XdaSSnE(object P_0, SnippetAddedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		ViDiELSegment3DTool viDiELSegment3DTool = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				if (viDiELSegment3DTool != null)
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				MNClDksypTT7rgpgqMS(FWNbRksjiRT262lKi1o(viDiELSegment3DTool), new PropertyChangedEventHandler(fuKX6AAviK));
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 4:
				RunToolCallback();
				num = 7;
				if (deDR7HsqETVP3Dn7Gtr())
				{
					continue;
				}
				goto case 2;
			case 2:
				N4nXDDd2BE = viDiELSegment3DTool.ToolId;
				goto case 0;
			case 3:
				viDiELSegment3DTool = c6vMEFsTn95eZleqrLu(P_1) as ViDiELSegment3DTool;
				_ = 0;
				num = (deDR7HsqETVP3Dn7Gtr() ? 6 : 0);
				continue;
			case 7:
				break;
			}
			break;
		}
		return (Task)vWV3aisWIFcDInEVQ3J();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fuKX6AAviK(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		ViDiELSegment3DTool viDiELSegment3DTool = default;
		InternalCheckBoxViewModel internalCheckBoxViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (viDiELSegment3DTool != null)
				{
					num = 7;
					if (deDR7HsqETVP3Dn7Gtr())
					{
						break;
					}
					goto case 1;
				}
				return;
			case 1:
				internalCheckBoxViewModel = P_0 as InternalCheckBoxViewModel;
				YqUvvKsEaZuKjcEsfoi();
				num = (deDR7HsqETVP3Dn7Gtr() ? 5 : 0);
				break;
			default:
				viDiELSegment3DTool = Inspect.btvmHNqEjR((string)bR0pXMsFnOExr9Npy0F(internalCheckBoxViewModel)) as ViDiELSegment3DTool;
				num = 6;
				break;
			case 4:
				if (bUbsq7sRWnE3uhkkIHD(ABMHjZs0oL6RoCcPr8v(P_1), CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
				{
					num = 1;
					break;
				}
				return;
			case 2:
			case 5:
				if (internalCheckBoxViewModel != null)
				{
					goto default;
				}
				return;
			case 7:
				N4nXDDd2BE = (string)(internalCheckBoxViewModel.Value ? GJqWrNsCYBU60o5GF8t(viDiELSegment3DTool) : "");
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FI8Xufk2Zm(object P_0, EventArgs P_1)
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
			case 4:
				SBQnYisUQTTP9ehRYwV(this, N4nXDDd2BE);
				num = 6;
				break;
			case 0:
				if (!chaRLisMpV8wL5ceUM8(N4nXDDd2BE))
				{
					_ = 0;
					num = ((!deDR7HsqETVP3Dn7Gtr()) ? 5 : 3);
					break;
				}
				return;
			case 2:
			case 5:
				if (!nKAMROsYWnBmh5GBTWv(Inspect))
				{
					goto case 4;
				}
				return;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				if (Inspect.RuntimeModeService.IsOperatorOfflineAndNotInLiveMode)
				{
					goto case 2;
				}
				return;
			case 6:
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
		return (ResourceNode)T1F5c5smQGBdIvDgN6l(zA9wcpsHI9ZOwJSTCiR(((CvsInSight)zY6iBBs4CAAHipvwpAC(this)).CogSocket), VbHUAgsxBsmNguiiCdn(toolId));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__17))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		deDR7HsqETVP3Dn7Gtr();
		int num;
		if (!YqUvvKsEaZuKjcEsfoi())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (YqUvvKsEaZuKjcEsfoi())
			{
			}
		}
		_003CRunToolAsync_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = PkYi9psQVPJDe7Ju3hr();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override SegmentToolApi GetTool(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmentToolApi segmentToolApi = new SegmentToolApi();
		UKD35ds2gqk1QKs93Y9(segmentToolApi, NdEofUsNv1GF3xKUWTx(this, toolId));
		return segmentToolApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task MYuXF6VnO0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)hxlcg3scrFUgoLHmkbC(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aETDQlspu9BZjeu41iC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F1Z8eXsXNqxSvh9lbEk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HP3Iu4s9UbEr3fRXsEN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zY6iBBs4CAAHipvwpAC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vGnskns7HqZ2KXTJxQa(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool deDR7HsqETVP3Dn7Gtr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YqUvvKsEaZuKjcEsfoi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ikFy2ys3k7tsODLpCKQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FWNbRksjiRT262lKi1o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).Focus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CDj3gss60fOeioaxGth(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GJqWrNsCYBU60o5GF8t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELEzToolBase)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qMpDSwsAWusB5B6f3V8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).ClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bUbsq7sRWnE3uhkkIHD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vWV3aisWIFcDInEVQ3J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c6vMEFsTn95eZleqrLu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetAddedEventArgs)P_0).Snippet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MNClDksypTT7rgpgqMS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ABMHjZs0oL6RoCcPr8v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bR0pXMsFnOExr9Npy0F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool chaRLisMpV8wL5ceUM8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nKAMROsYWnBmh5GBTWv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).IsEasyBuilderAdvancedMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SBQnYisUQTTP9ehRYwV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentAdapterBase)P_0).OnNewResult((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zA9wcpsHI9ZOwJSTCiR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation VbHUAgsxBsmNguiiCdn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T1F5c5smQGBdIvDgN6l(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder PkYi9psQVPJDe7Ju3hr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NdEofUsNv1GF3xKUWTx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UKD35ds2gqk1QKs93Y9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentToolApi)P_0).ToolNode = (ResourceNode)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hxlcg3scrFUgoLHmkbC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SegmentAdapterBase)P_0).RunToolAsync();
	}
}
