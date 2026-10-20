using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Cognex.CogNamer.Client;
using Cognex.CogNamer.Client.Attributes;
using Cognex.Diagnostics.Logging;
using Cognex.Explorer.Common;
using Cognex.Explorer.Integration;
using Cognex.InSight.IDE.Common;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.Wpf;
using Cognex.InSight3D.Services;
using Cognex.ServiceLocator;
using Cognex.Utilities;
using MiADQg66xs74MkKsSp;
using fwndm9dOZy61LXFGHR;
using yyxNxr46PpWKp3KBKn;

namespace Cognex.InSight.Liger.SpreadsheetEditor.Shell;

public partial class SpreadsheetEditor : InSightDocumentBase, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeEditorControl_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SpreadsheetEditor _003C_003E4__this;

		public InSightStartupArgs startupArgs;

		private SpreadsheetIdeViewModel _003CviewModel_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NNDqDWNrPak31J5xYO();
			int num = (Yvl6noCPtH7BO6j0d4() ? 5 : 4);
			SpreadsheetEditor spreadsheetEditor = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003CviewModel_003E5__2 = null;
					num = 3;
					if (NNDqDWNrPak31J5xYO())
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					spreadsheetEditor = _003C_003E4__this;
					num = 6;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							((AppDomain)dwtn3rWSi7pbj9mg8H()).UnhandledException += spreadsheetEditor.soBj5i8pn;
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							Yvl6noCPtH7BO6j0d4();
							num3 = ((!NNDqDWNrPak31J5xYO()) ? 1 : 0);
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
								return;
							case 2:
								AsyncPump.RunSync(_003CviewModel_003E5__2.Initialize);
								num3 = 14;
								continue;
							case 16:
								spreadsheetEditor.qXgrZtrei(new SpreadsheetIdeControl(_003CviewModel_003E5__2));
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_0221;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								if (Yvl6noCPtH7BO6j0d4())
								{
								}
								continue;
							case 9:
								ConnectionTokenHelper.Authorize();
								num3 = 15;
								if (NNDqDWNrPak31J5xYO())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 10:
								_003C_003Eu__1 = default;
								goto case 1;
							case 3:
								cPVTPK36o51aklHw5R(_003CviewModel_003E5__2, startupArgs);
								num3 = 2;
								continue;
							case 15:
								_003CviewModel_003E5__2 = ((IServiceLocator)hxWmheHBIQ2VedIxRK()).GetInstance<SpreadsheetIdeViewModel>((string)null);
								num3 = 3;
								continue;
							case 7:
								spreadsheetEditor.ContentHost.Content = spreadsheetEditor.RBCa2a2cR();
								num3 = 13;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 1:
							case 11:
								num2 = (_003C_003E1__state = -1);
								goto IL_0221;
							case 14:
								((JobManagementViewModel)TaCEuvobXqyncPoq2G(_003CviewModel_003E5__2)).JobNameChanged += spreadsheetEditor.JobManagementService_JobNameChanged;
								uxlQmTQdQGs5OW7IHU(_003CviewModel_003E5__2, vmSTqY40DO4wrpYytu(spreadsheetEditor));
								jhSIWfreeESW5oBFtW(spreadsheetEditor, _003CviewModel_003E5__2.JobManagement.JobName);
								awaiter = hllWS0DTX8pL9tir7Z(CacheAccessor.ClearCache());
								num3 = 6;
								continue;
							case 13:
								jAdnSWAKuAa7QFbqyh(_003CviewModel_003E5__2.Runtime, new EventHandler(spreadsheetEditor.OnClose));
								num3 = 17;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 17:
								{
									jb0bv0TCYfBK1odjY4(spreadsheetEditor.RBCa2a2cR());
									break;
								}
								IL_0221:
								awaiter.GetResult();
								num3 = 16;
								continue;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CviewModel_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 7:
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
		internal static object dwtn3rWSi7pbj9mg8H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AppDomain.CurrentDomain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hxWmheHBIQ2VedIxRK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Locator.Current;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cPVTPK36o51aklHw5R(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseIdeViewModel)P_0).StartupArgs = (InSightStartupArgs)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TaCEuvobXqyncPoq2G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).JobManagement;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vmSTqY40DO4wrpYytu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InSightDocumentBase)P_0).DisconnectHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uxlQmTQdQGs5OW7IHU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseIdeViewModel)P_0).ConnectionClosed += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jhSIWfreeESW5oBFtW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InSightDocumentBase)P_0).JobName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter hllWS0DTX8pL9tir7Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jAdnSWAKuAa7QFbqyh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((RuntimeViewModel)P_0).LogoutUser += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jb0bv0TCYfBK1odjY4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SpreadsheetEditorControlInjector.SpreadsheetEditorControl = (Control)P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NNDqDWNrPak31J5xYO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yvl6noCPtH7BO6j0d4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private SpreadsheetIdeControl OOi4PrDjx;

	private bool wVUvdgsW8;

	private bool QXL3UlSWy;

	protected override string EditorName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)SHHSDMpgDvM9Hch5Lx(64);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpreadsheetEditor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KnYESf2KnUDRZMNUj9();
		int num = ((!dDbilos8J54MRe7QnG()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				InitializeComponent();
				break;
			default:
				num = 4;
				if (!dDbilos8J54MRe7QnG())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				VQEQrJLrPKxUU5oNY2();
				num = 5;
				if (KnYESf2KnUDRZMNUj9())
				{
					continue;
				}
				break;
			case 4:
				break;
			case 5:
				DbmTKvVMu8Ln9yVyhj(this);
				goto case 2;
			case 6:
				return;
			}
			ReconnectViewModelFunction = UTbMvW3Pw;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private SpreadsheetIdeControl RBCa2a2cR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OOi4PrDjx;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void qXgrZtrei(SpreadsheetIdeControl value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OOi4PrDjx = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IEnumerable<Assembly> GetLocatorAssemblies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LKu0YjFoiHNVBIbbhl.O2s6P7bKu.Concat(new Assembly[1] { GetType().Assembly }).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ILogger GetLogger()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LogManager.GetLogger<SpreadsheetEditor>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override InSightStartupArgs SetStartupArgs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InSightStartupArgs instance = ((IServiceLocator)x9rofZbPyFtBWuDJcO()).GetInstance<InSightStartupArgs>((string)null);
		hWrDc2E6xJdnYWJdjE(instance, (CogNamerDevice)((IDiscoveredTarget)((object[])PNGQVRt6pSTeWwpfbB(this))[0]).Attributes[(string)SHHSDMpgDvM9Hch5Lx(102)]);
		iHW6RNwFqa9pcknqSE(instance, SelectedTargets[0].Attributes.ContainsKey((string)SHHSDMpgDvM9Hch5Lx(134)) && (XiaTHaRex8yO2Q1oO7((CogNamerApplicationIdAttribute)((IDiscoveredTarget)((object[])PNGQVRt6pSTeWwpfbB(this))[0]).Attributes[(string)SHHSDMpgDvM9Hch5Lx(134)]) == 3 || XiaTHaRex8yO2Q1oO7((CogNamerApplicationIdAttribute)((IDiscoveredTarget)((object[])PNGQVRt6pSTeWwpfbB(this))[0]).Attributes[(string)SHHSDMpgDvM9Hch5Lx(134)]) == 4));
		return base.SetStartupArgs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeEditorControl_003Ed__10))]
	protected override Task InitializeEditorControl(InSightStartupArgs startupArgs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CInitializeEditorControl_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (KnYESf2KnUDRZMNUj9())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine.startupArgs = startupArgs;
				goto default;
			default:
				_ = 0;
				num = ((!KnYESf2KnUDRZMNUj9()) ? 1 : 5);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DisposeEditorControl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KnYESf2KnUDRZMNUj9();
		int num = (dDbilos8J54MRe7QnG() ? 3 : 8);
		SpreadsheetIdeViewModel spreadsheetIdeViewModel = default;
		while (true)
		{
			object obj2;
			object obj;
			switch (num)
			{
			case 7:
				if (((spreadsheetIdeViewModel != null) ? Q5U6JQaSjYmjE84OxV(spreadsheetIdeViewModel) : null) != null)
				{
					UYQMYSe9aAdexLxoUX(spreadsheetIdeViewModel.Runtime, new EventHandler(OnClose));
					num = 9;
					break;
				}
				goto case 9;
			case 10:
			{
				SpreadsheetIdeControl spreadsheetIdeControl = RBCa2a2cR();
				if (spreadsheetIdeControl == null)
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 4;
				}
				obj2 = KQdViCgiY1XVtV4CHL(spreadsheetIdeControl);
				goto IL_009a;
			}
			case 4:
				htx9QmJlVac7cbqCcQ(spreadsheetIdeViewModel, wlpnSQfFPoDi7oEUM1(this));
				num = 7;
				break;
			case 5:
				obj2 = null;
				goto IL_009a;
			case 11:
				if (spreadsheetIdeViewModel != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				if (spreadsheetIdeViewModel == null)
				{
					goto default;
				}
				obj = lJawr0GMKBghxSW3Mr(spreadsheetIdeViewModel);
				goto IL_0151;
			case 1:
				return;
			case 9:
				((IDisposable)spreadsheetIdeViewModel).Dispose();
				num = 12;
				break;
			default:
				obj = null;
				goto IL_0151;
			case 0:
			case 8:
				if (!wVUvdgsW8)
				{
					wVUvdgsW8 = true;
					num = 10;
					if (true)
					{
						break;
					}
					goto case 9;
				}
				num = 1;
				break;
			case 12:
				return;
				IL_009a:
				spreadsheetIdeViewModel = obj2 as SpreadsheetIdeViewModel;
				num = 11;
				if (!dDbilos8J54MRe7QnG())
				{
					break;
				}
				goto case 11;
				IL_0151:
				if (obj != null)
				{
					((JobManagementViewModel)Ujj8TkIhDS0v0nyyYP(spreadsheetIdeViewModel)).JobNameChanged -= JobManagementService_JobNameChanged;
					num = 4;
					break;
				}
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task UTbMvW3Pw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)t6pDqB0IiUyQ1h1B4C();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void soBj5i8pn(object P_0, UnhandledExceptionEventArgs P_1)
	{
		peseITOjm0KO7bCmHg(LogManager.GetLogger<SpreadsheetEditor>(), SHHSDMpgDvM9Hch5Lx(324), T7xNequNAMnNHcvA5f(P_1) as Exception);
		D7ZgokKbv9GfNNHjnY(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VQEQrJLrPKxUU5oNY2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QydVltWcCHDiPv4cA0.RScLt1ez0Xo5H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DbmTKvVMu8Ln9yVyhj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InSightDocumentBase)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KnYESf2KnUDRZMNUj9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dDbilos8J54MRe7QnG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SHHSDMpgDvM9Hch5Lx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BPZOUyCNIstMNXq2qm.sDbguHB1e(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x9rofZbPyFtBWuDJcO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Locator.Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PNGQVRt6pSTeWwpfbB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DocumentBase)P_0).SelectedTargets;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hWrDc2E6xJdnYWJdjE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InSightStartupArgs)P_0).CogNamerDevice = (CogNamerDevice)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XiaTHaRex8yO2Q1oO7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CogNamerApplicationIdAttribute)P_0).ApplicationId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iHW6RNwFqa9pcknqSE(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InSightStartupArgs)P_0).IsEmulator = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KQdViCgiY1XVtV4CHL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FrameworkElement)P_0).DataContext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lJawr0GMKBghxSW3Mr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).JobManagement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ujj8TkIhDS0v0nyyYP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).JobManagement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wlpnSQfFPoDi7oEUM1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSightDocumentBase)P_0).DisconnectHandler;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void htx9QmJlVac7cbqCcQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseIdeViewModel)P_0).ConnectionClosed -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q5U6JQaSjYmjE84OxV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UYQMYSe9aAdexLxoUX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((RuntimeViewModel)P_0).LogoutUser -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t6pDqB0IiUyQ1h1B4C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EirbdX5M6ekalt3EjY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T7xNequNAMnNHcvA5f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UnhandledExceptionEventArgs)P_0).ExceptionObject;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void peseITOjm0KO7bCmHg(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D7ZgokKbv9GfNNHjnY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InSightDocumentBase)P_0).DisposeEditorControl();
	}
}
