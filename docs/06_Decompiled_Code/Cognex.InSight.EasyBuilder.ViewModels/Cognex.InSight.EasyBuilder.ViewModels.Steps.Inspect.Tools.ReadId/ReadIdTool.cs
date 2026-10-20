#define TRACE
using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId;

[Export(typeof(ReadIdTool))]
public class ReadIdTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInternalPostParse_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadIdTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ReadIdTool readIdTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readIdTool.z0WICbcHIp();
							num3 = 10;
							if (pIDGPeK7jrD98HRQCNYt())
							{
								goto IL_0049;
							}
							goto IL_00f5;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_016a;
						IL_017f:
						awaiter.GetResult();
						goto end_IL_002d;
						IL_00f5:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 3:
								readIdTool.FirePropertyChanged((string)pYAOd5K76yTukawf8fIh(49980));
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								pIDGPeK7jrD98HRQCNYt();
								num3 = (BwS2EoK73IPAjrckE0h7() ? 2 : 0);
								continue;
							case 2:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 9:
								return;
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 10:
								Tm0owPK7CkoqyS1odPv1(readIdTool, pYAOd5K76yTukawf8fIh(49930));
								num3 = 3;
								continue;
							case 7:
								awaiter = rcGsRYK7AuXcPZ79FJZX(readIdTool.DCGIwc9SOm(cells));
								num3 = 4;
								continue;
							case 0:
							case 8:
								goto IL_016a;
							case 11:
								goto IL_017f;
							}
							break;
						}
						goto IL_0049;
						IL_0049:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							goto IL_00f5;
						}
						goto IL_017f;
						IL_016a:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						if (0 == 0)
						{
							goto IL_00f5;
						}
						goto IL_017f;
						end_IL_002d:;
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
					readIdTool = _003C_003E4__this;
					_ = 0;
					if (!BwS2EoK73IPAjrckE0h7())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (!pIDGPeK7jrD98HRQCNYt())
					{
						continue;
					}
					break;
				case 5:
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
		internal static object pYAOd5K76yTukawf8fIh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Tm0owPK7CkoqyS1odPv1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rcGsRYK7AuXcPZ79FJZX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BwS2EoK73IPAjrckE0h7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pIDGPeK7jrD98HRQCNYt()
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
	private struct _003CWriteFixturedGraphics_003Ed__107 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadIdTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			ReadIdTool readIdTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
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
								num3 = 11;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 15;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
								num2 = (_003C_003E1__state = -1);
								goto default;
							default:
								_ = 0;
								if (sFfl3QK7Rdty9eEYP7S8())
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 2;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								continue;
							case 11:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 14;
									continue;
								}
								goto case 7;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 6;
								continue;
							case 6:
								return;
							case 2:
							case 8:
								awaiter = ((CvsCogSocketSheet)vZ10hBK7YvZP5owYBnd7(B6IYegK7MaCQP7KpoLSX(readIdTool.InSight))).RunAsync(true).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 7:
							case 9:
								awaiter2.GetResult();
								goto case 2;
							case 1:
								awaiter2 = yB3ySmK7FjsqdRiS8Qur(A4FtOeK70DJR4h8jx4IA(readIdTool.InSight, RJ9oZgK7TW3U5XH5Nnto(readIdTool.Region), Y4B2mpK7yGBIIFfAfBmE(readIdTool.Region)));
								num3 = 3;
								continue;
							case 12:
								_003C_003Eu__2 = awaiter;
								num3 = 4;
								continue;
							case 0:
								return;
							case 14:
								_003C_003Eu__1 = awaiter2;
								num3 = 13;
								continue;
							case 15:
								_003C_003Eu__1 = default;
								num3 = 10;
								if (!fTqZK5K7WE7nPAJH6KIE())
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
					break;
				case 0:
				case 1:
					readIdTool = _003C_003E4__this;
					num = 5;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (fTqZK5K7WE7nPAJH6KIE() ? 2 : 0);
					continue;
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
		internal static CvsCellLocation RJ9oZgK7TW3U5XH5Nnto(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y4B2mpK7yGBIIFfAfBmE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A4FtOeK70DJR4h8jx4IA(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yB3ySmK7FjsqdRiS8Qur(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B6IYegK7MaCQP7KpoLSX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vZ10hBK7YvZP5owYBnd7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sFfl3QK7Rdty9eEYP7S8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fTqZK5K7WE7nPAJH6KIE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsFunctionArg, bool> _003C_003E9__120_0;

		public static Func<CvsFunctionArg, bool> _003C_003E9__120_1;

		public static Func<CvsFunctionArg, bool> _003C_003E9__121_0;

		public static Func<CvsFunctionArg, bool> _003C_003E9__121_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WbA9bAK7x2jj0AXqsFAq();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WbA9bAK7x2jj0AXqsFAq();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetExpectedOneDSymbologyArray_003Eb__120_0(CvsFunctionArg arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KiidxdK7N468AJkhM0pZ(nTYurCK7mjj9lWrmMsem(arg), hYvxL2K7QX1Cgemn1tNl(11724));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetExpectedOneDSymbologyArray_003Eb__120_1(CvsFunctionArg arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KiidxdK7N468AJkhM0pZ(nTYurCK7mjj9lWrmMsem(arg), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11924));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetExpectedTwoDSymbologyArray_003Eb__121_0(CvsFunctionArg arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KiidxdK7N468AJkhM0pZ(arg.Name, hYvxL2K7QX1Cgemn1tNl(12178));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetExpectedTwoDSymbologyArray_003Eb__121_1(CvsFunctionArg arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KiidxdK7N468AJkhM0pZ(nTYurCK7mjj9lWrmMsem(arg), hYvxL2K7QX1Cgemn1tNl(12204));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WbA9bAK7x2jj0AXqsFAq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X76qo8K7UOdQTknDhEpl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V2xtyKK7HHIePgcuM3MC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nTYurCK7mjj9lWrmMsem(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionArg)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hYvxL2K7QX1Cgemn1tNl(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KiidxdK7N468AJkhM0pZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private readonly List<ReadIdSymbologyViewModel> PjTImXhlby;

	[CompilerGenerated]
	private readonly List<ReadIdSymbologyViewModel> ICqI1vuiON;

	[CompilerGenerated]
	private EditIntViewModel WaDIzEP17F;

	[CompilerGenerated]
	private EditIntViewModel hdVfanbmcM;

	[CompilerGenerated]
	private ListBoxViewModel W3Ff5SUsxx;

	[CompilerGenerated]
	private ListBoxViewModel CRMfpl0QQ6;

	[CompilerGenerated]
	private ListBoxViewModel C1PfUFG35t;

	[CompilerGenerated]
	private ListBoxViewModel yfef75qBdu;

	[CompilerGenerated]
	private ListBoxViewModel URJfNItqnn;

	[CompilerGenerated]
	private ListBoxViewModel UrofAmD1BW;

	[CompilerGenerated]
	private CheckBoxViewModel NbXfdViRsv;

	[CompilerGenerated]
	private CheckBoxViewModel kBif6itBZh;

	[CompilerGenerated]
	private CheckBoxViewModel EMqfuCJaFM;

	[CompilerGenerated]
	private CheckBoxViewModel VqlfFt9uoZ;

	[CompilerGenerated]
	private CheckBoxViewModel k3XfXLrsEy;

	[CompilerGenerated]
	private EditIntViewModel qyifoNRJqV;

	[CompilerGenerated]
	private CheckBoxViewModel ieFfSuXGB5;

	[CompilerGenerated]
	private CheckBoxViewModel U0TfDTOtGP;

	[CompilerGenerated]
	private CheckBoxViewModel XIDf3uvbWo;

	[CompilerGenerated]
	private StringViewModel OCKfIEck1h;

	[CompilerGenerated]
	private EditRegionViewModel sMPffmy7rZ;

	[CompilerGenerated]
	private IntViewModel tgffEsaYos;

	private IEnumerable<ReadIdResultViewModel> JgdfbUZpo7;

	private readonly List<ReadIdResultViewModel> vKHfctKeUc;

	private static readonly ILogger O2HfQIAB72;

	private List<SymbologyType> dlxfgY9ejU;

	private List<SymbologyType> GSifMRDwUt;

	[CompilerGenerated]
	private readonly Dictionary<SymbologyType, ReadIdSymbologyViewModel> wA9fR7lfiA;

	[CompilerGenerated]
	private readonly Dictionary<SymbologyType, ReadIdSymbologyViewModel> RSDf4GFmVG;

	public List<ReadIdSymbologyViewModel> OneDimensionSymbologies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PjTImXhlby;
		}
	}

	public List<ReadIdSymbologyViewModel> TwoDimensionSymbologies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ICqI1vuiON;
		}
	}

	public EditIntViewModel MaxResults1D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WaDIzEP17F;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WaDIzEP17F = value;
		}
	}

	public EditIntViewModel MinimumDecodesBeforeOutput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hdVfanbmcM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hdVfanbmcM = value;
		}
	}

	public ListBoxViewModel AdvancedDecodeSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return W3Ff5SUsxx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			W3Ff5SUsxx = value;
		}
	}

	public ListBoxViewModel PerspectiveDistortion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CRMfpl0QQ6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CRMfpl0QQ6 = value;
		}
	}

	public ListBoxViewModel Polarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C1PfUFG35t;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C1PfUFG35t = value;
		}
	}

	public ListBoxViewModel SortMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yfef75qBdu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yfef75qBdu = value;
		}
	}

	public ListBoxViewModel QrCodeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return URJfNItqnn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			URJfNItqnn = value;
		}
	}

	public ListBoxViewModel SymbolDamage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UrofAmD1BW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UrofAmD1BW = value;
		}
	}

	public CheckBoxViewModel CheckSumEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NbXfdViRsv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NbXfdViRsv = value;
		}
	}

	public CheckBoxViewModel AllowIdentical1DSymbolsEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kBif6itBZh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kBif6itBZh = value;
		}
	}

	public CheckBoxViewModel ExpandUpcEEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EMqfuCJaFM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EMqfuCJaFM = value;
		}
	}

	public CheckBoxViewModel RectangularExtensionEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VqlfFt9uoZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VqlfFt9uoZ = value;
		}
	}

	public CheckBoxViewModel DiagnosticStringEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return k3XfXLrsEy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			k3XfXLrsEy = value;
		}
	}

	public EditIntViewModel Timeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qyifoNRJqV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qyifoNRJqV = value;
		}
	}

	public CheckBoxViewModel EnableTraining
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ieFfSuXGB5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ieFfSuXGB5 = value;
		}
	}

	public CheckBoxViewModel IgnorePolarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U0TfDTOtGP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U0TfDTOtGP = value;
		}
	}

	public CheckBoxViewModel AllowFlexibleGridSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XIDf3uvbWo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XIDf3uvbWo = value;
		}
	}

	public StringViewModel GetLearnedSymbology
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OCKfIEck1h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OCKfIEck1h = value;
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
			return sMPffmy7rZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sMPffmy7rZ = value;
		}
	}

	public IntViewModel NumResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tgffEsaYos;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tgffEsaYos = value;
		}
	}

	public IEnumerable<ReadIdResultViewModel> Results
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JgdfbUZpo7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref JgdfbUZpo7, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6452));
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
			return XAMLGraphicKeys.Tools_ReadIdIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadIdTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!iVCOkXG8Nj3Q55t1ndj())
		{
			num = 2;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_00f1;
			}
		}
		goto IL_006d;
		IL_006d:
		while (true)
		{
			switch (num)
			{
			case 10:
				wA9fR7lfiA = new Dictionary<SymbologyType, ReadIdSymbologyViewModel>();
				num = 9;
				continue;
			case 1:
				GSifMRDwUt = new List<SymbologyType>();
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				dlxfgY9ejU = new List<SymbologyType>();
				goto case 1;
			default:
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				SKjoGAGqj9wqLqbHyxZ();
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				RSDf4GFmVG = new Dictionary<SymbologyType, ReadIdSymbologyViewModel>();
				num = 5;
				continue;
			case 8:
				ICqI1vuiON = new List<ReadIdSymbologyViewModel>();
				break;
			case 3:
			case 6:
				break;
			case 5:
				base._002Ector(inspect, isInitialized);
				num = 11;
				continue;
			case 4:
				PjTImXhlby = new List<ReadIdSymbologyViewModel>();
				num = 8;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_00f1;
		IL_00f1:
		vKHfctKeUc = new List<ReadIdResultViewModel>();
		num = 7;
		goto IL_006d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private Dictionary<SymbologyType, ReadIdSymbologyViewModel> s4OI9Jpqha()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wA9fR7lfiA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private Dictionary<SymbologyType, ReadIdSymbologyViewModel> IAMIhMhQNr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RSDf4GFmVG;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!iVCOkXG8Nj3Q55t1ndj())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				rcTTXJGptur9os3IpL5(vKHfctKeUc);
				num = 7;
				break;
			case 4:
			case 5:
				V0PQiKGXfhgQ405AwMc(GSifMRDwUt);
				goto case 6;
			default:
				num = 6;
				break;
			case 1:
				kMfQZTGEydbChRJj8rJ(OneDimensionSymbologies);
				num = 9;
				break;
			case 0:
				KDTKZgG9CbapVS770Sb(IAMIhMhQNr());
				num = 8;
				break;
			case 7:
				V0PQiKGXfhgQ405AwMc(dlxfgY9ejU);
				goto case 4;
			case 9:
				kMfQZTGEydbChRJj8rJ(TwoDimensionSymbologies);
				_ = 0;
				num = (ECZaCRGkEMN2FG0WVb8() ? 3 : 5);
				break;
			case 6:
				s4OI9Jpqha().Clear();
				num = 0;
				break;
			case 8:
				base.InternalPreParse();
				num = 10;
				if (1 == 0)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__104))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CInternalPostParse_003Ed__104 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.cells = cells;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				iVCOkXG8Nj3Q55t1ndj();
				if (!ECZaCRGkEMN2FG0WVb8())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (ECZaCRGkEMN2FG0WVb8())
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
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCell cvsCell = default;
		IEnumerable<CvsFunctionArg> enumerable = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				try
				{
					CvsParse cvsParse = CvsParse.Parse((CvsFunctionTable)qABaDwGj2VFKsPIC7TD(InSight), (IExpressionConstants)krw4HqG62pTivB60m25(InSight), (string)FAimZyGCowMUAdRDe7t(cvsCell), DsDOl7GA2ADNRpBpB8x(FAimZyGCowMUAdRDe7t(cvsCell)));
					int num2;
					if (cvsParse == null)
					{
						iVCOkXG8Nj3Q55t1ndj();
						if (ECZaCRGkEMN2FG0WVb8())
						{
							num2 = 1;
							if (iVCOkXG8Nj3Q55t1ndj())
							{
							}
						}
						else
						{
							num2 = 4;
							if (1 == 0)
							{
								goto IL_00c6;
							}
						}
						goto IL_0097;
					}
					object obj = sXB0FiGRQLnY9Ixp1qc(cvsParse);
					goto IL_00e2;
					IL_00e2:
					object obj2;
					if (obj != null)
					{
						obj2 = ((CvsFunction)obj).Arguments;
						goto IL_007e;
					}
					num2 = 3;
					goto IL_0097;
					IL_00d7:
					obj = null;
					goto IL_00e2;
					IL_00c6:
					VW1IOWkjfh(enumerable);
					num2 = 5;
					goto IL_0097;
					IL_007e:
					enumerable = (IEnumerable<CvsFunctionArg>)obj2;
					if (enumerable != null)
					{
						goto IL_00c6;
					}
					return;
					IL_0097:
					switch (num2)
					{
					case 3:
						break;
					default:
						goto IL_00c6;
					case 0:
					case 1:
						goto IL_00d7;
					case 5:
						lwiIHWoNHm(enumerable);
						return;
					}
					obj2 = null;
					goto IL_007e;
				}
				catch (Exception ex)
				{
					anosPlGWuTuI9qhtHGU(O2HfQIAB72, LogLevel.Error, dF5LHUG7Ea7FVgOEAXi(9644), ex);
					GBn8NfGTqS4OEY2Mdiw(dF5LHUG7Ea7FVgOEAXi(9644));
					return;
				}
			case 7:
				UiQIl31huH(cells, cvsCell, loc, relativeCellName);
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				if (!t9tI438NQl(cells, cvsCell, loc, relativeCellName))
				{
					goto case 3;
				}
				return;
			case 3:
			case 5:
				if (!CxRIRyJh9N(cells, cvsCell, loc, relativeCellName))
				{
					num = 7;
					if (iVCOkXG8Nj3Q55t1ndj())
					{
					}
					break;
				}
				return;
			case 0:
				cvsCell = (CvsCell)gMfuYxG4tO2TMZtHoJP(cells, loc);
				num = 1;
				if (!iVCOkXG8Nj3Q55t1ndj())
				{
					break;
				}
				goto case 1;
			case 1:
				if (!MAtS14G34VjZ0KCXoGi(relativeCellName, dF5LHUG7Ea7FVgOEAXi(9614)))
				{
					if (!u10Icl2m8E(cells, cvsCell, loc, relativeCellName))
					{
						num = 8;
						if (0 == 0)
						{
							break;
						}
						goto case 7;
					}
					return;
				}
				_ = 1;
				num = ((!iVCOkXG8Nj3Q55t1ndj()) ? 4 : 3);
				break;
			case 8:
				if (!YRSIQbPVFR(cells, cvsCell, loc, relativeCellName))
				{
					goto case 6;
				}
				return;
			default:
				num = 6;
				break;
			case 9:
				return;
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
		if (Region?.Graphic == null)
		{
			return Array.Empty<CvsEditableDisplayGraphic>();
		}
		return new CvsEditableDisplayGraphic[1] { (CvsEditableDisplayGraphic)LWXACJGyg4BvLn4NrJ2(Region) };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__107))]
	internal override Task WriteFixturedGraphics()
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
		goto IL_0034;
		IL_001a:
		_003CWriteFixturedGraphics_003Ed__107 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 3;
				if (!iVCOkXG8Nj3Q55t1ndj())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = KZ3q4NG0nbw6gaXcIWu();
				_ = 0;
				if (ECZaCRGkEMN2FG0WVb8())
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0089;
				}
				num = 5;
				continue;
			case 3:
				goto IL_0089;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0089:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnResultsChanged(results);
		Results = vKHfctKeUc.Take(NumResults?.Value ?? 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool u10Icl2m8E(CvsCellCollection P_0, CvsCell P_1, CvsCellLocation P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 47;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 44:
				return true;
			case 38:
				if (num2 != 1008156421 || !MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10442)))
				{
					break;
				}
				MaxResults1D = new EditIntViewModel(InSight, P_0, P_2, Resources.OneDMaxResults, null, OperationProgressManager);
				M9tyIXo52Ze7hisvesf(MaxResults1D, true);
				num = 12;
				if (iVCOkXG8Nj3Q55t1ndj())
				{
				}
				continue;
			case 1:
				if (num2 != 1599826270)
				{
					_ = 1;
					if (!iVCOkXG8Nj3Q55t1ndj())
					{
						num = 25;
						if (true)
						{
							continue;
						}
						goto case 29;
					}
					num = 15;
					continue;
				}
				if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(9980)))
				{
					break;
				}
				k6jIgcGle4(SymbologyType.Code25, new CheckBoxViewModel(InSight, P_0, P_2, Resources.A6bZSj2ita() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
				num = 5;
				continue;
			case 29:
				return true;
			case 40:
				if (num2 != 3457463901u)
				{
					num = 17;
					continue;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(9894)))
				{
					k6jIgcGle4(SymbologyType.Code93, new CheckBoxViewModel(InSight, P_0, P_2, Resources.D9hZfjNAdl() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
					goto case 15;
				}
				num = 9;
				continue;
			case 48:
				if (num2 <= 2113161079)
				{
					num = 30;
					continue;
				}
				if (num2 > 3457463901u)
				{
					if (num2 > 3908989560u)
					{
						if (num2 != 3995984587u)
						{
							num = 16;
							continue;
						}
						if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(9778)))
						{
							num = 24;
							continue;
						}
						k6jIgcGle4(SymbologyType.Interleaved2of5, new CheckBoxViewModel(InSight, P_0, P_2, (string)OcobufGxThrMKEXORxj() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
						num = 45;
						continue;
					}
					switch (num2)
					{
					case 3908989560u:
						if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10010)))
						{
							break;
						}
						k6jIgcGle4(SymbologyType.Pdf417, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(iO13tpG2qBJyefxQAbW(), Resources.Enabled), IsInitialized, null, OperationProgressManager));
						num = 50;
						continue;
					case 3807285044u:
						if (MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10118)))
						{
							k6jIgcGle4(SymbologyType.DataBarExpanded, new CheckBoxViewModel(InSight, P_0, P_2, (string)EWCuDXGupsHgry6ocSp() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
							return true;
						}
						num = 31;
						continue;
					default:
						num = 18;
						continue;
					case 3884052344u:
						if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10380)))
						{
							num = 28;
							if (true)
							{
								continue;
							}
							break;
						}
						k6jIgcGle4(SymbologyType.IntelligentMailBarcode, new CheckBoxViewModel(InSight, P_0, P_2, (string)X2yUZToKC374pxopcPX() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
						num = 41;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					break;
				}
				num = 19;
				continue;
			case 30:
				if (num2 <= 1237980476)
				{
					if (num2 > 1008156421)
					{
						if (num2 != 1161981333)
						{
							num = 35;
						}
						else if (P_3 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(9748))
						{
							k6jIgcGle4(SymbologyType.Code39, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(YNZOIDGH0yKF3lg3f46(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
							num = 4;
						}
						else
						{
							num = 23;
						}
					}
					else if (num2 != 544644198)
					{
						num = 38;
					}
					else if (MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(9716)))
					{
						k6jIgcGle4(SymbologyType.Code128, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(Wu1CRWGMTRPaLyJ94Jj(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
						num = 10;
					}
					else
					{
						num = 33;
					}
					continue;
				}
				if (num2 > 1599826270)
				{
					switch (num2)
					{
					case 1875171414u:
						if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(9924)))
						{
							num = 2;
							continue;
						}
						k6jIgcGle4(SymbologyType.CodaBar, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(UtspB9GQjUIrlYdEVD9(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
						return true;
					default:
						num = 32;
						continue;
					case 1982846482u:
						break;
					}
					if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(9826))
					{
						k6jIgcGle4(SymbologyType.Pharmacode, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(Resources.Pharmacode, QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
						num = 29;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					num = 42;
					continue;
				}
				num = 46;
				if (0 == 0)
				{
					continue;
				}
				goto case 51;
			case 7:
				if (num2 != 3264454017u)
				{
					num = 40;
					continue;
				}
				if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10072)))
				{
					num = 11;
					continue;
				}
				k6jIgcGle4(SymbologyType.DataBarLimited, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(pQQhemG1VXrfOl8dFU7(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
				num = 22;
				continue;
			case 45:
				return true;
			case 35:
				if (num2 != 1228239286)
				{
					if (num2 != 1237980476)
					{
						num = 43;
						continue;
					}
					if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10166))
					{
						k6jIgcGle4(SymbologyType.EanUccComposite, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(Resources.FkPnIqVcwa(), Resources.Enabled), IsInitialized, null, OperationProgressManager));
						num = 6;
						if (ECZaCRGkEMN2FG0WVb8())
						{
							continue;
						}
						break;
					}
					num = 3;
					if (ECZaCRGkEMN2FG0WVb8())
					{
						continue;
					}
					goto case 36;
				}
				if (P_3 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(10276))
				{
					k6jIgcGle4(SymbologyType.JapanPost, new CheckBoxViewModel(InSight, P_0, P_2, (string)uORtcKGtbFrKAve9PRG() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
					return true;
				}
				break;
			case 6:
				return true;
			default:
				num = 26;
				continue;
			case 41:
				return true;
			case 16:
				if (num2 != 4229961672u)
				{
					num = 51;
					continue;
				}
				if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(9864))
				{
					k6jIgcGle4(SymbologyType.UpcEan, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(BIilTSGmEci4MDU47si(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
					return true;
				}
				break;
			case 10:
				return true;
			case 5:
				return true;
			case 50:
				return true;
			case 51:
				if (num2 == 4279719607u)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10040)))
					{
						num = 21;
						continue;
					}
					k6jIgcGle4(SymbologyType.DataBar, new CheckBoxViewModel(InSight, P_0, P_2, (string)AIqxDjGc9GGmKsp6O3W() + Resources.Enabled, IsInitialized, null, OperationProgressManager));
					num = 49;
					continue;
				}
				break;
			case 32:
				if (num2 == 2113161079)
				{
					if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10214))
					{
						k6jIgcGle4(SymbologyType.PostNet, new CheckBoxViewModel(InSight, P_0, P_2, Resources.etrJZqK8SX() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
						num = 44;
						if (true)
						{
							continue;
						}
					}
					break;
				}
				num = 27;
				continue;
			case 22:
				return true;
			case 19:
				if (num2 > 2302670708u)
				{
					if (num2 == 3135548153u)
					{
						if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(9956)))
						{
							num = 14;
							continue;
						}
						k6jIgcGle4(SymbologyType.Msi, new CheckBoxViewModel(InSight, P_0, P_2, (string)pUn8PDGN6oKJcWmpoWF() + (string)QnCwpsGYUcCxbqq1sC5(), IsInitialized, null, OperationProgressManager));
						num = 0;
					}
					else
					{
						num = 7;
					}
					continue;
				}
				switch (num2)
				{
				case 2302670708u:
					if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10356)))
					{
						num = 52;
						continue;
					}
					k6jIgcGle4(SymbologyType.Upu, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(TkM8QAoLKPhsOm3VRlH(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
					num = 36;
					continue;
				case 2172496840u:
					if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10246)))
					{
						k6jIgcGle4(SymbologyType.Planet, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(q5qmfvGh4gRHMOOiFRu(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
						return true;
					}
					num = 37;
					continue;
				}
				num = 20;
				if (true)
				{
					continue;
				}
				break;
			case 49:
				return true;
			case 47:
				num2 = h881LQGF9WwV9vqrRh8(P_3);
				num = 48;
				continue;
			case 4:
				return true;
			case 0:
				return true;
			case 15:
			case 39:
				return true;
			case 46:
				if (num2 == 1259063408)
				{
					if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10312))
					{
						k6jIgcGle4(SymbologyType.AustraliaPost, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(oMbxEDGzhvxA9fl9aaw(), Resources.Enabled), IsInitialized, null, OperationProgressManager));
						num = 13;
						if (!iVCOkXG8Nj3Q55t1ndj())
						{
							continue;
						}
						goto case 38;
					}
					num = 34;
					continue;
				}
				num = 1;
				if (iVCOkXG8Nj3Q55t1ndj())
				{
				}
				continue;
			case 36:
				return true;
			case 13:
				return true;
			case 12:
				AddProperty(MaxResults1D);
				num = 53;
				continue;
			case 53:
				return true;
			case 2:
			case 3:
			case 8:
			case 9:
			case 11:
			case 14:
			case 17:
			case 18:
			case 20:
			case 21:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 31:
			case 33:
			case 34:
			case 37:
			case 42:
			case 43:
			case 52:
				break;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool YRSIQbPVFR(CvsCellCollection P_0, CvsCell P_1, CvsCellLocation P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(P_3);
				num = 2;
				continue;
			case 23:
				return true;
			case 25:
				if (num2 != 2285466911u)
				{
					num = 8;
					continue;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10688)))
				{
					OdMIMmG3yF(SymbologyType.QrCode, new EditIntViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(apFifLowMTESHBl5VlP(), D2Zv5ZoIdPoBGw8STjm()), null, OperationProgressManager));
					num = 15;
					continue;
				}
				break;
			case 10:
				if (num2 != 244688896)
				{
					num = 14;
					continue;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10644)))
				{
					OdMIMmG3yF(SymbologyType.DataMatrix, new EditIntViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(s5WVptoOhOADe1lecXq(), D2Zv5ZoIdPoBGw8STjm()), null, OperationProgressManager));
					num = 12;
					if (0 == 0)
					{
						continue;
					}
					goto case 25;
				}
				break;
			case 16:
				if (num2 == 1965408862)
				{
					if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10542)))
					{
						num = 3;
						continue;
					}
					k6jIgcGle4(SymbologyType.MaxiCode, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(qqWm5coJ1rBEZYKgkfO(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
					num = 6;
				}
				else
				{
					num = 25;
				}
				continue;
			case 12:
				return true;
			default:
				num = 18;
				continue;
			case 15:
				return true;
			case 13:
				return true;
			case 19:
				if (num2 != 4016047421u)
				{
					break;
				}
				goto case 11;
			case 2:
				if (num2 > 2285466911u)
				{
					if (num2 <= 2757354660u)
					{
						num = 4;
						if (ECZaCRGkEMN2FG0WVb8())
						{
							continue;
						}
						goto case 10;
					}
					switch (num2)
					{
					case 2847481294u:
						if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10612)))
						{
							k6jIgcGle4(SymbologyType.DotCode, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(NMnVIkoekUaKtOB1TPt(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
							return true;
						}
						num = 17;
						continue;
					default:
						num = 19;
						continue;
					case 2823781649u:
						break;
					}
					if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10724)))
					{
						break;
					}
					OdMIMmG3yF(SymbologyType.MaxiCode, new EditIntViewModel(InSight, P_0, P_2, (string)qqWm5coJ1rBEZYKgkfO() + (string)D2Zv5ZoIdPoBGw8STjm(), null, OperationProgressManager));
					num = 0;
					continue;
				}
				num = 20;
				continue;
			case 4:
				if (num2 == 2570079815u)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10764)))
					{
						num = 24;
						continue;
					}
					OdMIMmG3yF(SymbologyType.AztecCode, new EditIntViewModel(InSight, P_0, P_2, (string)FICKRMoav7M2Se0XXp6() + (string)D2Zv5ZoIdPoBGw8STjm(), null, OperationProgressManager));
					return true;
				}
				if (num2 == 2757354660u)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10576)))
					{
						break;
					}
					k6jIgcGle4(SymbologyType.AztecCode, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(FICKRMoav7M2Se0XXp6(), Resources.Enabled), IsInitialized, null, OperationProgressManager));
					num = 23;
					continue;
				}
				iVCOkXG8Nj3Q55t1ndj();
				if (!ECZaCRGkEMN2FG0WVb8())
				{
					num = 21;
					continue;
				}
				num = 22;
				if (true)
				{
					continue;
				}
				goto case 20;
			case 20:
				if (num2 <= 375318049)
				{
					num = 10;
					continue;
				}
				if (num2 == 1438768572)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10512)))
					{
						break;
					}
					k6jIgcGle4(SymbologyType.QrCode, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(apFifLowMTESHBl5VlP(), QnCwpsGYUcCxbqq1sC5()), IsInitialized, null, OperationProgressManager));
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 19;
				}
				num = 16;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 0:
				return true;
			case 7:
				return true;
			case 6:
				return true;
			case 14:
				if (num2 == 375318049)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10806)))
					{
						num = 26;
						continue;
					}
					OdMIMmG3yF(SymbologyType.DotCode, new EditIntViewModel(InSight, P_0, P_2, (string)NMnVIkoekUaKtOB1TPt() + (string)D2Zv5ZoIdPoBGw8STjm(), null, OperationProgressManager));
					num = 27;
					continue;
				}
				break;
			case 11:
			case 21:
				if (P_3 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(10474))
				{
					k6jIgcGle4(SymbologyType.DataMatrix, new CheckBoxViewModel(InSight, P_0, P_2, (string)ipm9djGUs59ONsY6Sl0(Resources.WwanUjwSf4(), Resources.Enabled), IsInitialized, null, OperationProgressManager));
					num = 13;
				}
				else
				{
					num = 5;
				}
				continue;
			case 27:
				return true;
			case 3:
			case 5:
			case 8:
			case 9:
			case 17:
			case 18:
			case 22:
			case 24:
			case 26:
				break;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void k6jIgcGle4(SymbologyType P_0, CheckBoxViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iVCOkXG8Nj3Q55t1ndj();
		int num = ((!ECZaCRGkEMN2FG0WVb8()) ? 5 : 6);
		ReadIdSymbologyViewModel readIdSymbologyViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				((CellViewModel)Ip9o8OoDLNXZcojPCZk(readIdSymbologyViewModel)).Internal = true;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				readIdSymbologyViewModel.Enabled = P_1;
				goto case 2;
			case 9:
				return;
			case 8:
				AddProperty(P_1);
				num = 3;
				break;
			case 3:
				if (!P_0.Is1D())
				{
					if (P_0.Is2D())
					{
						num = 1;
						break;
					}
					return;
				}
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 6:
				readIdSymbologyViewModel = new ReadIdSymbologyViewModel(P_0);
				num = 7;
				break;
			case 4:
				s4OI9Jpqha().Add(P_0, readIdSymbologyViewModel);
				num = 9;
				if (ECZaCRGkEMN2FG0WVb8())
				{
					break;
				}
				goto case 1;
			case 1:
				IAMIhMhQNr().Add(P_0, readIdSymbologyViewModel);
				num = 10;
				if (!ECZaCRGkEMN2FG0WVb8())
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OdMIMmG3yF(SymbologyType P_0, EditIntViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ReadIdSymbologyViewModel readIdSymbologyViewModel = IAMIhMhQNr()[P_0];
		cVpromoie8W4YeA7d4i(readIdSymbologyViewModel, P_1);
		M9tyIXo52Ze7hisvesf(yEiEc9onL2p4hy1AIc3(readIdSymbologyViewModel), true);
		AddProperty(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CxRIRyJh9N(CvsCellCollection P_0, CvsCell P_1, CvsCellLocation P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!ECZaCRGkEMN2FG0WVb8())
		{
			goto IL_001e;
		}
		goto IL_0197;
		IL_0129:
		AddProperty(AllowFlexibleGridSize);
		num = 1;
		goto IL_0197;
		IL_0113:
		AddProperty(GetLearnedSymbology);
		num = 13;
		goto IL_0197;
		IL_0197:
		while (true)
		{
			switch (num)
			{
			case 11:
				break;
			case 5:
				if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(10844))
				{
					CheckBoxViewModel checkBoxViewModel = new CheckBoxViewModel(InSight, P_0, P_2, Resources.EnableTraining, IsInitialized, null, OperationProgressManager);
					M9tyIXo52Ze7hisvesf(checkBoxViewModel, true);
					EnableTraining = checkBoxViewModel;
					goto case 4;
				}
				num = 11;
				continue;
			case 3:
				AddProperty(IgnorePolarity);
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				return true;
			case 9:
				goto IL_0113;
			case 7:
				goto IL_0129;
			case 4:
			case 6:
				AddProperty(EnableTraining);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				return true;
			default:
				num = 7;
				if (ECZaCRGkEMN2FG0WVb8())
				{
					continue;
				}
				goto case 0;
			case 0:
				return true;
			case 2:
			case 10:
				goto IL_0219;
			case 13:
				return true;
			case 12:
				return false;
			}
			break;
			IL_0219:
			if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(10970)))
			{
				StringViewModel stringViewModel = new StringViewModel(InSight, P_0, P_2, Resources.GetLearnedSymbologyResult);
				M9tyIXo52Ze7hisvesf(stringViewModel, false);
				GetLearnedSymbology = stringViewModel;
				num = 9;
				if (iVCOkXG8Nj3Q55t1ndj())
				{
				}
			}
			else
			{
				num = 12;
			}
		}
		goto IL_001e;
		IL_001e:
		if (!(P_3 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(10876)))
		{
			if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(10922)))
			{
				_ = 1;
				num = (iVCOkXG8Nj3Q55t1ndj() ? 6 : 10);
			}
			else
			{
				CheckBoxViewModel checkBoxViewModel2 = new CheckBoxViewModel(InSight, P_0, P_2, (string)AYPL2DoV1RHCYZibsoG(), IsInitialized, null, OperationProgressManager);
				M9tyIXo52Ze7hisvesf(checkBoxViewModel2, true);
				IgnorePolarity = checkBoxViewModel2;
				num = 3;
				if (false)
				{
					goto IL_0113;
				}
			}
			goto IL_0197;
		}
		AllowFlexibleGridSize = new CheckBoxViewModel(InSight, P_0, P_2, Resources.AllowFlexibleGridSize, IsInitialized, null, OperationProgressManager)
		{
			Internal = true
		};
		goto IL_0129;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool t9tI438NQl(CvsCellCollection P_0, CvsCell P_1, CvsCellLocation P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 55:
				AddProperty(CheckSumEnabled);
				return true;
			case 46:
				return true;
			case 54:
				return true;
			case 53:
				M9tyIXo52Ze7hisvesf(CheckSumEnabled, true);
				num = 55;
				continue;
			case 49:
				AddProperty(SymbolDamage);
				goto case 27;
			case 33:
				M9tyIXo52Ze7hisvesf(SortMode, true);
				num = 5;
				if (!iVCOkXG8Nj3Q55t1ndj())
				{
					continue;
				}
				goto case 41;
			case 41:
				if (num2 != 1195222419)
				{
					num = 45;
					continue;
				}
				if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(7570)))
				{
					num = 20;
					if (0 == 0)
					{
						continue;
					}
					goto case 11;
				}
				InputRegion = new InputRegionViewModel(this, P_0, P_2, (string)pNqQZ0oZBQ1b0yyS2BP(), Resources.rcKYeAISOR(), Region, IsInitialized);
				num = 37;
				if (ECZaCRGkEMN2FG0WVb8())
				{
					continue;
				}
				goto case 15;
			case 23:
				if (num2 != 1985420906)
				{
					num = 36;
					continue;
				}
				if (!(P_3 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(11024)))
				{
					break;
				}
				AdvancedDecodeSettings = new ListBoxViewModel(InSight, P_0, P_2, Resources.AdvancedDecodeMode, null, OperationProgressManager);
				AdvancedDecodeSettings.Internal = true;
				goto case 50;
			case 56:
				if (num2 != 2724108074u)
				{
					break;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(11214)))
				{
					AllowIdentical1DSymbolsEnabled = new CheckBoxViewModel(InSight, P_0, P_2, (string)EL0x1oogeXh2re8aly8(), IsInitialized, null, OperationProgressManager);
					num = 47;
					continue;
				}
				_ = 1;
				if (iVCOkXG8Nj3Q55t1ndj())
				{
					num = 27;
					continue;
				}
				num = 29;
				if (0 == 0)
				{
					continue;
				}
				goto case 37;
			case 42:
				M9tyIXo52Ze7hisvesf(QrCodeMode, true);
				num = 43;
				continue;
			case 27:
			case 39:
				return true;
			case 52:
				AddProperty(AllowIdentical1DSymbolsEnabled);
				num = 46;
				continue;
			case 2:
				if (num2 != 1508320178)
				{
					num = 40;
					if (ECZaCRGkEMN2FG0WVb8())
					{
						continue;
					}
					goto case 12;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(11194)))
				{
					CheckSumEnabled = new CheckBoxViewModel(InSight, P_0, P_2, Resources.Checksum, IsInitialized, null, OperationProgressManager);
					num = 53;
					if (iVCOkXG8Nj3Q55t1ndj())
					{
					}
					continue;
				}
				break;
			case 12:
				return true;
			case 51:
				if (num2 != 3597210033u)
				{
					num = 7;
					continue;
				}
				if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(11320)))
				{
					break;
				}
				ExpandUpcEEnabled = new CheckBoxViewModel(InSight, P_0, P_2, (string)Y3tdWTosV6QWoqgTUL7(), IsInitialized, null, OperationProgressManager);
				M9tyIXo52Ze7hisvesf(ExpandUpcEEnabled, true);
				num = 30;
				continue;
			case 10:
				AddProperty(PerspectiveDistortion);
				return true;
			case 34:
				M9tyIXo52Ze7hisvesf(MinimumDecodesBeforeOutput, true);
				num = 44;
				continue;
			case 5:
				AddProperty(SortMode);
				num = 54;
				continue;
			case 1:
				return true;
			case 3:
				if (num2 != 72238190)
				{
					num = 41;
					continue;
				}
				if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(11130)))
				{
					SortMode = new ListBoxViewModel(InSight, P_0, P_2, Resources.SortMode, null, OperationProgressManager);
					num = 33;
					if (0 == 0)
					{
						continue;
					}
					goto case 31;
				}
				num = 16;
				continue;
			case 25:
				return true;
			case 31:
				if (num2 > 1985420906)
				{
					if (num2 > 2724108074u)
					{
						if (num2 <= 3844895164u)
						{
							num = 51;
							if (iVCOkXG8Nj3Q55t1ndj())
							{
							}
							continue;
						}
						if (num2 == 4233332083u)
						{
							if (!(P_3 == (string)dF5LHUG7Ea7FVgOEAXi(11428)))
							{
								num = 48;
								continue;
							}
							Timeout = new EditIntViewModel(InSight, P_0, P_2, (string)w22IWIoPYEGfERiKZLu(), null, OperationProgressManager);
							M9tyIXo52Ze7hisvesf(Timeout, true);
							num = 22;
							continue;
						}
						if (num2 != 4292390121u)
						{
							break;
						}
						if (MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(11110)))
						{
							Polarity = new ListBoxViewModel(InSight, P_0, P_2, (string)VOAHG9odlWEJEq3iySk(), null, OperationProgressManager);
							M9tyIXo52Ze7hisvesf(Polarity, true);
							num = 15;
							continue;
						}
						num = 13;
						if (0 == 0)
						{
							continue;
						}
						goto case 35;
					}
					num = 35;
					continue;
				}
				num = 0;
				continue;
			case 44:
				AddProperty(MinimumDecodesBeforeOutput);
				return true;
			case 43:
				AddProperty(QrCodeMode);
				num = 12;
				continue;
			case 7:
				if (num2 == 3844895164u)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(11346)))
					{
						num = 26;
						continue;
					}
					RectangularExtensionEnabled = new CheckBoxViewModel(InSight, P_0, P_2, (string)NxooUVovBfdVl1Ud1vQ(), IsInitialized, null, OperationProgressManager);
					num = 19;
					if (true)
					{
						continue;
					}
				}
				else
				{
					num = 18;
					if (true)
					{
						continue;
					}
				}
				break;
			case 11:
				AddProperty(RectangularExtensionEnabled);
				num = 8;
				continue;
			case 0:
				if (num2 <= 1227782301)
				{
					num = 3;
					continue;
				}
				if (num2 > 1572729914)
				{
					if (num2 == 1678927800)
					{
						if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(11264))
						{
							MinimumDecodesBeforeOutput = new EditIntViewModel(InSight, P_0, P_2, Resources.MinimumDecodesBeforeOutput, null, OperationProgressManager);
							num = 34;
							continue;
						}
						num = 38;
						if (0 == 0)
						{
							continue;
						}
						goto case 10;
					}
					num = 23;
					if (ECZaCRGkEMN2FG0WVb8())
					{
						continue;
					}
					goto case 43;
				}
				num = 2;
				continue;
			case 8:
				return true;
			case 4:
				num2 = h881LQGF9WwV9vqrRh8(P_3);
				num = 31;
				continue;
			case 35:
				if (num2 <= 2579138449u)
				{
					switch (num2)
					{
					case 2579138449u:
						if (MAtS14G34VjZ0KCXoGi(P_3, CdQUGaROfy7He9T0foW.KbIzwHEDLa(11150)))
						{
							QrCodeMode = new ListBoxViewModel(InSight, P_0, P_2, Resources.QRMode, null, OperationProgressManager);
							num = 42;
						}
						else
						{
							num = 14;
						}
						continue;
					default:
						num = 9;
						if (iVCOkXG8Nj3Q55t1ndj())
						{
						}
						continue;
					case 2070200511u:
						break;
					}
					if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(11390))
					{
						DiagnosticStringEnabled = new CheckBoxViewModel(InSight, P_0, P_2, (string)aPWEoworDKELXE4SEZs(), IsInitialized, null, OperationProgressManager);
						AddProperty(DiagnosticStringEnabled);
						return true;
					}
					num = 24;
					if (true)
					{
						continue;
					}
					goto case 45;
				}
				if (num2 != 2582710780u)
				{
					num = 56;
				}
				else if (P_3 == (string)dF5LHUG7Ea7FVgOEAXi(11166))
				{
					SymbolDamage = new ListBoxViewModel(InSight, P_0, P_2, (string)TcXHOwolgbvAbEiJqXQ(), null, OperationProgressManager);
					SymbolDamage.Internal = true;
					num = 49;
				}
				else
				{
					num = 6;
				}
				continue;
			case 40:
				if (num2 == 1572729914)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(11064)))
					{
						break;
					}
					PerspectiveDistortion = new ListBoxViewModel(InSight, P_0, P_2, (string)ShaWnEofec37UJSOdPk(), null, OperationProgressManager);
					M9tyIXo52Ze7hisvesf(PerspectiveDistortion, true);
					num = 10;
					continue;
				}
				num = 28;
				continue;
			case 19:
				M9tyIXo52Ze7hisvesf(RectangularExtensionEnabled, true);
				num = 11;
				continue;
			case 17:
				return true;
			case 15:
				AddProperty(Polarity);
				num = 25;
				continue;
			case 45:
				if (num2 == 1227782301)
				{
					if (!MAtS14G34VjZ0KCXoGi(P_3, dF5LHUG7Ea7FVgOEAXi(5684)))
					{
						num = 32;
						continue;
					}
					Region = new EditRegionViewModel(InSight, P_0, P_2, (string)YA4aD9oBPXu3dSBhJWt(), CglEotobCo17Gdp3NTY(InputImage));
					AddProperty(Region);
					num = 57;
					if (0 == 0)
					{
						continue;
					}
				}
				break;
			case 30:
				AddProperty(ExpandUpcEEnabled);
				return true;
			case 50:
				AddProperty(AdvancedDecodeSettings);
				return true;
			case 22:
				AddProperty(Timeout);
				num = 17;
				continue;
			case 47:
				M9tyIXo52Ze7hisvesf(AllowIdentical1DSymbolsEnabled, true);
				num = 52;
				continue;
			case 37:
				AddProperty(InputRegion);
				num = 1;
				continue;
			default:
				num = 50;
				if (true)
				{
					continue;
				}
				goto case 57;
			case 57:
				return true;
			case 6:
			case 9:
			case 13:
			case 14:
			case 16:
			case 18:
			case 20:
			case 21:
			case 24:
			case 26:
			case 28:
			case 29:
			case 32:
			case 36:
			case 38:
			case 48:
				break;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool UiQIl31huH(CvsCellCollection P_0, CvsCell P_1, CvsCellLocation P_2, string P_3)
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
		goto IL_004b;
		IL_0144:
		bool result = default;
		return result;
		IL_00ad:
		if (P_3 != null)
		{
			goto IL_00e4;
		}
		goto IL_0144;
		IL_00e4:
		if (P_3.EndsWith((string)dF5LHUG7Ea7FVgOEAXi(11474)))
		{
			num = 9;
			goto IL_004b;
		}
		goto IL_0144;
		IL_001a:
		if (P_3 != null)
		{
			_ = 0;
			num = ((!ECZaCRGkEMN2FG0WVb8()) ? 1 : 10);
			goto IL_004b;
		}
		goto IL_00ad;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 5:
				result = true;
				goto IL_0144;
			default:
				num = 4;
				continue;
			case 7:
				result = true;
				num = 11;
				continue;
			case 3:
				I6jITgnnN3(P_0, P_2);
				num = 5;
				continue;
			case 2:
			case 10:
				goto IL_00c4;
			case 1:
			case 6:
				goto IL_00e4;
			case 0:
				result = false;
				num = 8;
				if (ECZaCRGkEMN2FG0WVb8())
				{
					continue;
				}
				goto case 9;
			case 9:
				NumResults = new IntViewModel(InSight, P_0, P_2, Resources.SQ4LIAGhfV());
				AddProperty(NumResults);
				num = 7;
				continue;
			case 4:
			case 11:
				goto IL_0144;
			}
			break;
			IL_00c4:
			if (Khi6quoGAcVfiS1FXyO(P_3, dF5LHUG7Ea7FVgOEAXi(11450)))
			{
				num = 3;
				continue;
			}
			goto IL_00ad;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void I6jITgnnN3(CvsCellCollection P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		StringViewModel stringViewModel2 = default;
		StringViewModel stringViewModel = default;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 11:
				vKHfctKeUc.Add(new ReadIdResultViewModel(pTeK43oSihJYBQEmvuV(vKHfctKeUc), stringViewModel2, stringViewModel));
				goto default;
			default:
				_ = 0;
				num = (ECZaCRGkEMN2FG0WVb8() ? 5 : 0);
				break;
			case 1:
				AddProperty(stringViewModel2);
				num = 10;
				break;
			case 2:
				AddProperty(stringViewModel);
				num = 11;
				break;
			case 0:
			case 8:
				nH9IjFatjH(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11532), Resources.Width);
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				num2 = 0;
				num = 4;
				break;
			case 3:
				nH9IjFatjH(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11524), Resources.Y);
				goto case 0;
			case 5:
			case 6:
				nH9IjFatjH(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11516), Resources.X);
				num = 3;
				if (iVCOkXG8Nj3Q55t1ndj())
				{
				}
				break;
			case 4:
				stringViewModel2 = ddIIWwlEXR(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11450), Resources.AF1rnkEwmc());
				num = 1;
				break;
			case 10:
				stringViewModel = ddIIWwlEXR(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), (string)dF5LHUG7Ea7FVgOEAXi(11498), (string)XXb60SooPdXNPj3XfIZ());
				num = 2;
				break;
			case 9:
				nH9IjFatjH(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), (string)dF5LHUG7Ea7FVgOEAXi(6242), (string)Ev2bqNokHoGPqud3MTI());
				nH9IjFatjH(P_0, new CvsCellLocation(P_1.Row, P_1.Column + num2++), (string)dF5LHUG7Ea7FVgOEAXi(11548), (string)beQMuCo8JNDjjHBtZ3J());
				num = 12;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private StringViewModel ddIIWwlEXR(CvsCellCollection P_0, CvsCellLocation P_1, string P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new StringViewModel(InSight, P_0, P_1, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nH9IjFatjH(CvsCellCollection P_0, CvsCellLocation P_1, string P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AddProperty(new FloatViewModel(InSight, P_0, P_1, P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void z0WICbcHIp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!ECZaCRGkEMN2FG0WVb8()) ? 4 : 9);
		ReadIdSymbologyViewModel item2 = default;
		SymbologyType key2 = default;
		int num3 = default;
		int num2 = default;
		SymbologyType key = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				item2 = IAMIhMhQNr()[key2];
				goto case 4;
			case 11:
				num3++;
				num = 7;
				break;
			case 3:
				num3 = 0;
				goto case 7;
			default:
				num = 10;
				break;
			case 1:
			case 5:
				do
				{
					if (num2 >= G1QCJnoq2HSu9gkOqSo(dlxfgY9ejU))
					{
						num = 3;
						continue;
					}
					key = dlxfgY9ejU[num2];
					num = 6;
					break;
				}
				while (false);
				break;
			case 0:
			case 9:
				num2 = 0;
				num = 1;
				break;
			case 4:
			case 8:
				TwoDimensionSymbologies.Add(item2);
				num = 11;
				break;
			case 7:
			case 10:
				if (num3 < G1QCJnoq2HSu9gkOqSo(GSifMRDwUt))
				{
					key2 = GSifMRDwUt[num3];
					num = 2;
				}
				else
				{
					num = 13;
				}
				break;
			case 12:
				num2++;
				num = 5;
				break;
			case 6:
			{
				ReadIdSymbologyViewModel item = s4OI9Jpqha()[key];
				OneDimensionSymbologies.Add(item);
				num = 12;
				break;
			}
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VW1IOWkjfh(IEnumerable<CvsFunctionArg> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0 == null)
		{
			return;
		}
		List<CvsFunctionArg> list = P_0.ToList();
		CvsFunctionArg item = list.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionArg arg) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.KiidxdK7N468AJkhM0pZ(_003C_003Ec.nTYurCK7mjj9lWrmMsem(arg), _003C_003Ec.hYvxL2K7QX1Cgemn1tNl(11724));
		}).FirstOrDefault();
		int num = list.IndexOf(item);
		CvsFunctionArg item2 = list.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionArg arg) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.KiidxdK7N468AJkhM0pZ(_003C_003Ec.nTYurCK7mjj9lWrmMsem(arg), CdQUGaROfy7He9T0foW.KbIzwHEDLa(11924));
		}).FirstOrDefault();
		int num2 = list.IndexOf(item2);
		if (num != -1 && num2 != -1)
		{
			for (int num3 = num; num3 <= num2; num3++)
			{
				SymbologyType symbologyTypeBasedOnSymbologyString = IdSymbologyTypeExtensions.GetSymbologyTypeBasedOnSymbologyString(list[num3].Name);
				dlxfgY9ejU.Add(symbologyTypeBasedOnSymbologyString);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lwiIHWoNHm(IEnumerable<CvsFunctionArg> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0 == null)
		{
			return;
		}
		List<CvsFunctionArg> list = P_0.ToList();
		CvsFunctionArg item = list.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionArg arg) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.KiidxdK7N468AJkhM0pZ(arg.Name, _003C_003Ec.hYvxL2K7QX1Cgemn1tNl(12178));
		}).FirstOrDefault();
		int num = list.IndexOf(item);
		CvsFunctionArg item2 = list.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionArg arg) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.KiidxdK7N468AJkhM0pZ(_003C_003Ec.nTYurCK7mjj9lWrmMsem(arg), _003C_003Ec.hYvxL2K7QX1Cgemn1tNl(12204));
		}).FirstOrDefault();
		int num2 = list.IndexOf(item2);
		if (num == -1 || num2 == -1)
		{
			return;
		}
		for (int num3 = num; num3 <= num2; num3++)
		{
			CvsFunctionArg cvsFunctionArg = list[num3];
			if (!cvsFunctionArg.Name.Contains(CdQUGaROfy7He9T0foW.KbIzwHEDLa(11564)))
			{
				SymbologyType symbologyTypeBasedOnSymbologyString = IdSymbologyTypeExtensions.GetSymbologyTypeBasedOnSymbologyString(cvsFunctionArg.Name);
				GSifMRDwUt.Add(symbologyTypeBasedOnSymbologyString);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReadIdTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SKjoGAGqj9wqLqbHyxZ();
		O2HfQIAB72 = LogManager.GetLogger<ReadIdTool>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task DCGIwc9SOm(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SKjoGAGqj9wqLqbHyxZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ECZaCRGkEMN2FG0WVb8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iVCOkXG8Nj3Q55t1ndj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kMfQZTGEydbChRJj8rJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<ReadIdSymbologyViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rcTTXJGptur9os3IpL5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<ReadIdResultViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V0PQiKGXfhgQ405AwMc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<SymbologyType>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KDTKZgG9CbapVS770Sb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<SymbologyType, ReadIdSymbologyViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gMfuYxG4tO2TMZtHoJP(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dF5LHUG7Ea7FVgOEAXi(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MAtS14G34VjZ0KCXoGi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qABaDwGj2VFKsPIC7TD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).FunctionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object krw4HqG62pTivB60m25(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FAimZyGCowMUAdRDe7t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DsDOl7GA2ADNRpBpB8x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sXB0FiGRQLnY9Ixp1qc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).Function;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void anosPlGWuTuI9qhtHGU(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GBn8NfGTqS4OEY2Mdiw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Trace.WriteLine((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LWXACJGyg4BvLn4NrJ2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KZ3q4NG0nbw6gaXcIWu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint h881LQGF9WwV9vqrRh8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wu1CRWGMTRPaLyJ94Jj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HEEZX8qsYj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QnCwpsGYUcCxbqq1sC5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ipm9djGUs59ONsY6Sl0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YNZOIDGH0yKF3lg3f46()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VScZ3GQVva();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OcobufGxThrMKEXORxj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MZOYJ0DNF1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BIilTSGmEci4MDU47si()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ITphKlS1mQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UtspB9GQjUIrlYdEVD9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SkxZus14wb();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pUn8PDGN6oKJcWmpoWF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.mALVzyfFfk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iO13tpG2qBJyefxQAbW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.HIhJEUPkWZ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AIqxDjGc9GGmKsp6O3W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DataBar;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pQQhemG1VXrfOl8dFU7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RD3n5s3h3j();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EWCuDXGupsHgry6ocSp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PhDZzabjrr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q5qmfvGh4gRHMOOiFRu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.wotJwJ51fj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uORtcKGtbFrKAve9PRG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EuT0ajf7xi();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oMbxEDGzhvxA9fl9aaw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fP0BcmW3Qp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TkM8QAoLKPhsOm3VRlH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OaIhVJcSn3();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X2yUZToKC374pxopcPX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.lajYVBthZL();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M9tyIXo52Ze7hisvesf(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object apFifLowMTESHBl5VlP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rYP9UVpBL7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qqWm5coJ1rBEZYKgkfO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaxiCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FICKRMoav7M2Se0XXp6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cRCBCg9Cye();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NMnVIkoekUaKtOB1TPt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DotCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s5WVptoOhOADe1lecXq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WwanUjwSf4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D2Zv5ZoIdPoBGw8STjm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.H4HVM5pVB4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ip9o8OoDLNXZcojPCZk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ReadIdSymbologyViewModel)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cVpromoie8W4YeA7d4i(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ReadIdSymbologyViewModel)P_0).MaxResults = (EditIntViewModel)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yEiEc9onL2p4hy1AIc3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ReadIdSymbologyViewModel)P_0).MaxResults;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AYPL2DoV1RHCYZibsoG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IgnorePolarity;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ShaWnEofec37UJSOdPk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PerspectiveDistortion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VOAHG9odlWEJEq3iySk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Polarity;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TcXHOwolgbvAbEiJqXQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SymbolDamage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EL0x1oogeXh2re8aly8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AllowIdentical1DResults;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y3tdWTosV6QWoqgTUL7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ExpandUPC_E;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NxooUVovBfdVl1Ud1vQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RectangularExtension;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aPWEoworDKELXE4SEZs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ShowDecodedResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w22IWIoPYEGfERiKZLu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Timeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pNqQZ0oZBQ1b0yyS2BP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YA4aD9oBPXu3dSBhJWt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SearchRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation CglEotobCo17Gdp3NTY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Khi6quoGAcVfiS1FXyO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XXb60SooPdXNPj3XfIZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaursiNrNV();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pTeK43oSihJYBQEmvuV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<ReadIdResultViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ev2bqNokHoGPqud3MTI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object beQMuCo8JNDjjHBtZ3J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int G1QCJnoq2HSu9gkOqSo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<SymbologyType>)P_0).Count;
	}
}
