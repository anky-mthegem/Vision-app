using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.Extensions.Specialized;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Helpers;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Internal.Analysis;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using IXHqQxfoEA8Uykucse;
using V1vT6w9Pg8H2LQdsrR;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;

[Export(typeof(AppStepViewModel))]
[Shared]
public class InspectStepViewModel : AppStepViewModel, IInSightAppStep, ISnippetOwner, ISnippetConsumer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<EzToolType> _003C_003E9__8_0;

		public static Func<EzToolType, bool> _003C_003E9__8_1;

		public static Func<EzTool, bool> _003C_003E9__57_0;

		public static Func<EzTool, Task> _003C_003E9__57_1;

		public static Func<EzToolType, int> _003C_003E9__75_0;

		public static Func<ToolCategory, bool> _003C_003E9__75_1;

		public static Func<EzSnippet, CellViewModel, _003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>> _003C_003E9__162_1;

		public static Func<_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>, string> _003C_003E9__162_3;

		public static Func<_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>, CellViewModel> _003C_003E9__162_4;

		public static Func<EzSnippet, CellViewModel, _003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>> _003C_003E9__163_1;

		public static Func<_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>, string> _003C_003E9__163_3;

		public static Func<_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel>, CellViewModel> _003C_003E9__163_4;

		public static Func<EzTool, CvsEditableDisplayGraphic[]> _003C_003E9__180_0;

		public static Func<CvsEditableDisplayGraphic[], bool> _003C_003E9__180_1;

		public static Func<CvsEditableDisplayGraphic[], IEnumerable<CvsEditableDisplayGraphic>> _003C_003E9__180_2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oF3VQVKrp3HEgjtjkgSK();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oF3VQVKrp3HEgjtjkgSK();
			BEmXlMKrX6G0KwojGbCN(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003C_002Ector_003Eb__8_0(EzToolType x, EzToolType y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x.Order.CompareTo(fnRXCqKr9cQKR0jYsxCe(y));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__8_1(EzToolType toolType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CWXMxJKr4tfA6uVpjDm1(toolType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCompleteInitializationAsync_003Eb__57_0(EzTool it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jGy5MGKr7ASq41xWs4I4(it);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CCompleteInitializationAsync_003Eb__57_1(EzTool tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)PNqr8KKr3TwIKyU3rYWO(tool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CInitToolTypes_003Eb__75_0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fnRXCqKr9cQKR0jYsxCe(t);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitToolTypes_003Eb__75_1(ToolCategory c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nsa5nAKrCUS0lhuf2O8l(PnPaSfKrjLtiaEb6ZVXy(c), KCnNIfKr6BJmqOUWlhdA());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal _003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003CGetSourceablePropertiesGrouped_003Eb__162_1(EzSnippet tool, CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { tool, prop };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePropertiesGrouped_003Eb__162_3(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.tool.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CellViewModel _003CGetSourceablePropertiesGrouped_003Eb__162_4(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.prop;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal _003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003CGetSourceablePrimitivesGrouped_003Eb__163_1(EzSnippet tool, CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { tool, prop };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePrimitivesGrouped_003Eb__163_3(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.tool.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CellViewModel _003CGetSourceablePrimitivesGrouped_003Eb__163_4(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.prop;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsEditableDisplayGraphic[] _003CGetViewableEditGraphics_003Eb__180_0(EzTool tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsEditableDisplayGraphic[])pgWjpIKrABSSK1eL24Z8(tool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetViewableEditGraphics_003Eb__180_1(CvsEditableDisplayGraphic[] graphics)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return graphics != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<CvsEditableDisplayGraphic> _003CGetViewableEditGraphics_003Eb__180_2(CvsEditableDisplayGraphic[] graphics)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return graphics;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oF3VQVKrp3HEgjtjkgSK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uhbKJeKrqydo0x74JolI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vjlKIiKrE2TID4HFklTQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BEmXlMKrX6G0KwojGbCN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int fnRXCqKr9cQKR0jYsxCe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Order;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CWXMxJKr4tfA6uVpjDm1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).IsReleased;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jGy5MGKr7ASq41xWs4I4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).zFBbb42F97A();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PNqr8KKr3TwIKyU3rYWO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).hFa6aQHHed();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PnPaSfKrjLtiaEb6ZVXy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolCategory)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KCnNIfKr6BJmqOUWlhdA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.F0Z0bUM6Xp();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nsa5nAKrCUS0lhuf2O8l(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pgWjpIKrABSSK1eL24Z8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).GetViewableEditGraphics();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (a0h1noKrRDeQgmGgwEr0())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_014a;
				}
			}
			goto IL_0117;
			IL_0117:
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						ValueTaskAwaiter awaiter;
						if (num2 != 0)
						{
							inspectStepViewModel.SNIdalGwKh.Dispose();
							IEnumerator<IDisposable> enumerator = inspectStepViewModel.ToolTypes.OfType<IDisposable>().GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									IXcMH4KrT7XeuoQs5H7x(enumerator.Current);
								}
							}
							finally
							{
								if (num2 < 0)
								{
									enumerator?.Dispose();
								}
							}
							awaiter = inspectStepViewModel.apKAMhmLUe().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
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
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_014a;
			IL_014a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0117;
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
		internal static void IXcMH4KrT7XeuoQs5H7x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a0h1noKrRDeQgmGgwEr0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GEQsR7KrWLcuUFJjCXVJ()
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
	private struct _003COnEnterStep_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public StepBase previousStep;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VSlNJlKryxMH5un7A32q();
			int num;
			if (!yjWd9lKr0kHuniyy54oF())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (!VSlNJlKryxMH5un7A32q())
				{
					return;
				}
			}
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 4;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 6;
								if (!VSlNJlKryxMH5un7A32q())
								{
									goto IL_006b;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00a7;
						IL_01c8:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							goto IL_00a7;
						}
						goto IL_0113;
						IL_00fe:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0113;
						IL_0144:
						awaiter.GetResult();
						goto IL_01ab;
						IL_013b:
						num2 = (_003C_003E1__state = -1);
						goto IL_0144;
						IL_006b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 16;
						if (yjWd9lKr0kHuniyy54oF())
						{
							goto IL_0089;
						}
						goto IL_00a7;
						IL_0089:
						if (awaiter.IsCompleted)
						{
							goto IL_0144;
						}
						goto IL_0232;
						IL_0232:
						num2 = (_003C_003E1__state = 1);
						num3 = 9;
						goto IL_00a7;
						IL_00a7:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 10:
								break;
							case 7:
								goto IL_0089;
							default:
								num3 = 5;
								continue;
							case 2:
								goto IL_00fe;
							case 9:
								goto IL_012a;
							case 8:
								goto IL_013b;
							case 4:
								return;
							case 6:
								awaiter = inspectStepViewModel.G4hARKt0FV(previousStep).GetAwaiter();
								num3 = 0;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (VSlNJlKryxMH5un7A32q())
								{
									continue;
								}
								goto IL_01ab;
							case 14:
							case 15:
								goto IL_01ab;
							case 0:
								goto IL_01c8;
							case 13:
								awaiter = TJaNoMKrFIDdFYYu4lCE(inspectStepViewModel.SetCurrentSnippet(inspectStepViewModel.RuntimeModeFocusTool ?? inspectStepViewModel.w70ABQLieC ?? inspectStepViewModel.Snippets.FirstOrDefault()));
								num3 = 7;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto IL_0232;
							case 5:
								goto IL_0232;
							case 16:
								return;
							case 1:
								goto IL_025b;
							case 17:
								inspectStepViewModel.yEtN0uVcH4();
								goto end_IL_004e;
							}
							break;
							IL_025b:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_ = 1;
							num3 = ((!yjWd9lKr0kHuniyy54oF()) ? 10 : 15);
						}
						goto IL_006b;
						IL_012a:
						_003C_003Eu__1 = awaiter;
						num3 = 12;
						goto IL_00a7;
						IL_01ab:
						pOvccaKrYPXbulguLNnq(P8GloJKrMnBtpwCA9XLe(inspectStepViewModel), true, false);
						num3 = 17;
						if (!yjWd9lKr0kHuniyy54oF())
						{
							goto IL_00a7;
						}
						goto IL_01c8;
						IL_0113:
						awaiter.GetResult();
						num3 = 13;
						if (VSlNJlKryxMH5un7A32q())
						{
							goto IL_00a7;
						}
						goto IL_012a;
						end_IL_004e:;
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
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static TaskAwaiter TJaNoMKrFIDdFYYu4lCE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P8GloJKrMnBtpwCA9XLe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pOvccaKrYPXbulguLNnq(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VSlNJlKryxMH5un7A32q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yjWd9lKr0kHuniyy54oF()
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
	private struct _003COnLeaveStep_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public StepBase nextStep;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					inspectStepViewModel = _003C_003E4__this;
					_ = 1;
					num = (JfOcfIKrHJYw5v236nxH() ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = uLBpcvKrxFZd691ekvIw(inspectStepViewModel.yOIA40vKsY(nextStep));
							num3 = 1;
							goto IL_015f;
						case 2:
							awaiter = _003C_003Eu__1;
							goto IL_00a6;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 2;
							goto IL_015f;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
								goto IL_015f;
							}
							IL_015f:
							while (true)
							{
								switch (num3)
								{
								case 18:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									JfOcfIKrHJYw5v236nxH();
									if (IaMFHuKrUSe94Fvo54tP())
									{
										num3 = 14;
										if (IaMFHuKrUSe94Fvo54tP())
										{
											continue;
										}
										break;
									}
									num3 = 12;
									continue;
								case 12:
								case 20:
									break;
								case 9:
									num2 = (_003C_003E1__state = -1);
									goto IL_00c5;
								case 10:
									awaiter.GetResult();
									num3 = 5;
									continue;
								case 13:
									inspectStepViewModel.w70ABQLieC = inspectStepViewModel.CurrentTool;
									num3 = 16;
									if (IaMFHuKrUSe94Fvo54tP())
									{
										continue;
									}
									return;
								case 11:
									return;
								case 0:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									continue;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 21;
								case 21:
									num2 = (_003C_003E1__state = 2);
									num3 = 19;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_020f;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 17;
								case 17:
									if (awaiter.IsCompleted)
									{
										goto IL_00c5;
									}
									num3 = 21;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
									if (awaiter.IsCompleted)
									{
										goto IL_020f;
									}
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								case 23:
									return;
								case 22:
									if (inspectStepViewModel.AddingToolType != null)
									{
										awaiter = uLBpcvKrxFZd691ekvIw(KONrqQKrm8SLq6dhtWsW(inspectStepViewModel.AddingToolType));
										if (awaiter.IsCompleted)
										{
											goto case 10;
										}
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 7;
									}
									goto case 5;
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 18;
									if (true)
									{
										continue;
									}
									return;
								case 4:
								case 14:
									return;
								case 16:
									inspectStepViewModel.RuntimeModeFocusTool = null;
									num3 = 22;
									continue;
								case 19:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 5:
									awaiter = uLBpcvKrxFZd691ekvIw(inspectStepViewModel.SetCurrentSnippet(null));
									num3 = 17;
									continue;
								case 24:
									{
										inspectStepViewModel.ToolFilter = "";
										goto end_IL_015f;
									}
									IL_00c5:
									awaiter.GetResult();
									inspectStepViewModel.yEtN0uVcH4();
									num3 = 24;
									continue;
									IL_020f:
									awaiter.GetResult();
									num3 = 13;
									continue;
								}
								goto IL_00a6;
								continue;
								end_IL_015f:
								break;
							}
							break;
							IL_00a6:
							_003C_003Eu__1 = default;
							num3 = 9;
							goto IL_015f;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					num2 = _003C_003E1__state;
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
		internal static TaskAwaiter uLBpcvKrxFZd691ekvIw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KONrqQKrm8SLq6dhtWsW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).AYfuN5tkXc();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IaMFHuKrUSe94Fvo54tP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JfOcfIKrHJYw5v236nxH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass47_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bjs2JtKr2WwCa3G2MtSN();
			clUt2hKrc1gCtqngkPnF(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESupports_003Eb__0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)H9gLUJKr1TtP4oSgeHLa(t)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESupports_003Eb__1(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)H9gLUJKr1TtP4oSgeHLa(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bjs2JtKr2WwCa3G2MtSN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void clUt2hKrc1gCtqngkPnF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hDHoHIKrQPbejQ5qQ0Pe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YtPM5TKrNJ2SyaRWRTIM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H9gLUJKr1TtP4oSgeHLa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass48_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FvPeloKrtyhqoB8Ns02D();
			PaSOrVKrzJ57OqYKv4r4(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)lprZCZKPLPjhPsTQgVcq(t)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__1(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)lprZCZKPLPjhPsTQgVcq(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FvPeloKrtyhqoB8Ns02D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PaSOrVKrzJ57OqYKv4r4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool njunaxKruKuHYUWRLx8i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mhJ7xTKrhdDDxeDdIXTh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lprZCZKPLPjhPsTQgVcq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public InspectStepViewModel _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		public SnippetAddedEventType action;

		private TaskAwaiter<EzTool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			_003C_003Ec__DisplayClass48_0 obj = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<EzTool> awaiter3 = default;
			TaskAwaiter<EzSupportSnippet> awaiter = default;
			EzSnippet ezSnippet = default;
			InspectStepViewModel inspectStepViewModel = default;
			EzTool result = default;
			EzSupportSnippet result2 = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							obj = new _003C_003Ec__DisplayClass48_0();
							num3 = 16;
							if (false)
							{
								goto IL_0040;
							}
							goto IL_0150;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 4;
							goto IL_0150;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 20;
							goto IL_0150;
						case 3:
							awaiter2 = _003C_003Eu__2;
							num3 = 17;
							goto IL_0150;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 37;
								goto IL_0150;
							}
							IL_0150:
							while (true)
							{
								switch (num3)
								{
								case 15:
									break;
								case 29:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 28:
									num2 = (_003C_003E1__state = 3);
									num3 = 35;
									continue;
								case 20:
									num2 = (_003C_003E1__state = -1);
									num3 = 30;
									continue;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 31:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter3;
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 27;
								case 27:
									if (!awaiter2.IsCompleted)
									{
										num3 = 28;
										continue;
									}
									goto case 38;
								case 11:
									return;
								case 0:
									goto end_IL_0150;
								default:
									num3 = 12;
									if (ePaTQbKPKG9EI9bZcr8T())
									{
										continue;
									}
									goto case 12;
								case 12:
									ezSnippet = null;
									num3 = 23;
									continue;
								case 2:
									ezSnippet = inspectStepViewModel.JobPassFail;
									goto IL_0216;
								case 36:
									awaiter2 = ChI7cDKPOI7qE5E12v02(WHO9uPKPeXu7E1StiEhu(inspectStepViewModel, new SnippetAddedEventArgs(result, action)));
									num3 = 24;
									if (ePaTQbKPKG9EI9bZcr8T())
									{
										continue;
									}
									return;
								case 13:
									return;
								case 33:
									return;
								case 21:
								case 22:
								{
									InternalCheckBoxViewModel showImage = result.ShowImage;
									if (showImage != null && showImage.Value)
									{
										aYGje5KPJ41FKlSTfq12(q6LeiYKPavqOQatXh1j1(result), false);
									}
									inspectStepViewModel.r4yADFiXZx(result);
									result.RefreshPotentialDependencies();
									num3 = 36;
									continue;
								}
								case 32:
									num2 = (_003C_003E1__state = -1);
									num3 = 38;
									continue;
								case 30:
								{
									result = awaiter3.GetResult();
									object obj2 = ApInmCKPwh2oDuSWr7RE(result);
									if (obj2 != null)
									{
										if (((InternalCheckBoxViewModel)obj2).Value)
										{
											aYGje5KPJ41FKlSTfq12(ApInmCKPwh2oDuSWr7RE(result), false);
											num3 = 22;
											continue;
										}
										goto case 21;
									}
									num3 = 21;
									continue;
								}
								case 14:
									num2 = (_003C_003E1__state = 1);
									num3 = 5;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 11;
									continue;
								case 19:
								case 26:
									inspectStepViewModel.JobPassFail = result2 as JobPassFail;
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 1:
									return;
								case 24:
									if (!awaiter2.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto case 7;
								case 9:
									result2 = awaiter.GetResult();
									_ = 0;
									num3 = ((!ePaTQbKPKG9EI9bZcr8T()) ? 13 : 19);
									continue;
								case 23:
									if (ezSupportSnippetType is JobPassFailType)
									{
										num3 = 8;
										continue;
									}
									goto IL_0216;
								case 6:
								{
									EzToolType ezToolType = inspectStepViewModel.ToolTypes.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0);
									if (ezToolType == null)
									{
										ezSupportSnippetType = inspectStepViewModel.Wd8APvDnN4.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__1);
										goto case 12;
									}
									awaiter3 = ezToolType.CreateTool(obj.guid, cells, cellRange).GetAwaiter();
									num3 = 34;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								}
								case 5:
									_003C_003Eu__2 = awaiter2;
									num3 = 10;
									continue;
								case 7:
									awaiter2.GetResult();
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 34;
								case 34:
									if (!awaiter3.IsCompleted)
									{
										num3 = 31;
										continue;
									}
									goto case 30;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 18:
									awaiter2 = ((Task)WHO9uPKPeXu7E1StiEhu(inspectStepViewModel, new SnippetAddedEventArgs(ezSnippet, action))).GetAwaiter();
									num3 = 27;
									if (tU4hqvKP5k171uvn5eHD())
									{
									}
									continue;
								case 8:
									awaiter = ezSupportSnippetType.CreateSupportSnippet(obj.guid, cells, cellRange).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 15;
										if (tU4hqvKP5k171uvn5eHD())
										{
										}
										continue;
									}
									goto case 9;
								case 37:
									_003C_003Eu__3 = default;
									num3 = 29;
									continue;
								case 35:
									_003C_003Eu__2 = awaiter2;
									num3 = 25;
									continue;
								case 25:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 17:
									_003C_003Eu__2 = default;
									num3 = 32;
									continue;
								case 16:
									obj.guid = guid;
									num3 = 6;
									if (true)
									{
										continue;
									}
									goto case 38;
								case 38:
									{
										awaiter2.GetResult();
										goto end_IL_0150;
									}
									IL_0216:
									if (ezSnippet != null)
									{
										num3 = 18;
										continue;
									}
									goto end_IL_0150;
								}
								goto IL_0040;
								continue;
								end_IL_0150:
								break;
							}
							break;
							IL_0040:
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 1;
							goto IL_0150;
						}
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
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					ePaTQbKPKG9EI9bZcr8T();
					num = ((!tU4hqvKP5k171uvn5eHD()) ? 4 : 0);
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
		internal static object ApInmCKPwh2oDuSWr7RE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Focus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aYGje5KPJ41FKlSTfq12(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InternalCheckBoxViewModel)P_0).Value = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object q6LeiYKPavqOQatXh1j1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).ShowImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WHO9uPKPeXu7E1StiEhu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ChI7cDKPOI7qE5E12v02(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ePaTQbKPKG9EI9bZcr8T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tU4hqvKP5k171uvn5eHD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass49_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iRWODHKPi6Sett1nPcR6();
			YxvVTTKPnmiCNBwoiLZc(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)OXEmCPKPVUl7OBd9DuVE(t)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__1(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iRWODHKPi6Sett1nPcR6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YxvVTTKPnmiCNBwoiLZc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mY6g8ZKPIFZUlFF1nXtf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I1564qKPDRwyXmEQhNJU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OXEmCPKPVUl7OBd9DuVE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public InspectStepViewModel _003C_003E4__this;

		public CvsCellRange snippetRange;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (FNoGd5KPd3km3bdfWYAW() ? 4 : 2);
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_018c;
							}
							num3 = 19;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 18;
							if (FNoGd5KPd3km3bdfWYAW())
							{
							}
						}
						goto IL_00d0;
						IL_00d0:
						while (true)
						{
							switch (num3)
							{
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 6:
								return;
							case 2:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_00d0;
							default:
								num3 = 3;
								continue;
							case 8:
								awaiter = IxNd0yKPgYcHOkf1WEPY(NMsu9lKPl3hdXu87mW9I(ezSupportSnippetType, snippetRange, cells));
								num3 = 9;
								if (true)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 18:
								_003C_003Eu__1 = default;
								num3 = 13;
								continue;
							case 14:
							case 16:
								break;
							case 3:
								goto end_IL_00d0;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 12;
							case 17:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								continue;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (!FNoGd5KPd3km3bdfWYAW())
								{
									continue;
								}
								goto case 9;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 20;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 10:
								if (ezSupportSnippetType != null)
								{
									num3 = 8;
									continue;
								}
								goto end_IL_00d0;
							case 19:
							{
								_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass49_0();
								CS_0024_003C_003E8__locals3.guid = guid;
								EzToolType ezToolType = inspectStepViewModel.ToolTypes.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return ((IEnumerable<Guid>)_003C_003Ec__DisplayClass49_0.OXEmCPKPVUl7OBd9DuVE(t)).Contains(CS_0024_003C_003E8__locals3.guid);
								});
								if (ezToolType == null)
								{
									ezSupportSnippetType = inspectStepViewModel.Wd8APvDnN4.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSupportSnippetType s) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return s.Guids.Contains(CS_0024_003C_003E8__locals3.guid);
									});
									TKqaESKPfEw6gnCrioVH();
									num3 = (FNoGd5KPd3km3bdfWYAW() ? 14 : 0);
									continue;
								}
								awaiter = IxNd0yKPgYcHOkf1WEPY(NMsu9lKPl3hdXu87mW9I(ezToolType, snippetRange, cells));
								num3 = 5;
								if (TKqaESKPfEw6gnCrioVH())
								{
									continue;
								}
								goto case 20;
							}
							case 20:
								awaiter.GetResult();
								goto end_IL_00d0;
							}
							goto IL_018c;
							continue;
							end_IL_00d0:
							break;
						}
						goto end_IL_004c;
						IL_018c:
						_003C_003Eu__1 = default;
						num3 = 17;
						if (TKqaESKPfEw6gnCrioVH())
						{
							goto IL_00d0;
						}
						end_IL_004c:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					if (!TKqaESKPfEw6gnCrioVH())
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
		internal static object NMsu9lKPl3hdXu87mW9I(object P_0, CvsCellRange range, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).UpdateSnippet(range, (CvsCellCollection)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter IxNd0yKPgYcHOkf1WEPY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TKqaESKPfEw6gnCrioVH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FNoGd5KPd3km3bdfWYAW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass50_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			qyhQjGKPru8MqZOvTOfn(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)bsHUKhKPPJJ6cfKEYcQI(t)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__1(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qyhQjGKPru8MqZOvTOfn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HxQwQxKPs3Air2hPplo5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N08P4TKPvHJWah5OU2xh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bsHUKhKPPJJ6cfKEYcQI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBeginInitialization_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public bool jobLoading;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					_ = 0;
					if (L1pseiKPZO6XhuCDvNku())
					{
						num = 5;
						if (pWI2mHKPBCVqfsEUS2hE())
						{
						}
						continue;
					}
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = vpxjjtKPbipF9REuGfr7(inspectStepViewModel.RemoveAllSnippets(jobLoading));
							_ = 1;
							num3 = (pWI2mHKPBCVqfsEUS2hE() ? 9 : 2);
							goto IL_009c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00f1;
						IL_009c:
						while (true)
						{
							switch (num3)
							{
							case 8:
								inspectStepViewModel.CopyTool = null;
								num3 = 10;
								continue;
							case 5:
								return;
							default:
								num3 = 6;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (true)
								{
									continue;
								}
								break;
							case 6:
								break;
							case 1:
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									goto case 1;
								}
								goto case 4;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter.GetResult();
								num3 = 8;
								continue;
							case 10:
								inspectStepViewModel.t64NVHXFJK();
								goto end_IL_009c;
							}
							goto IL_00f1;
							continue;
							end_IL_009c:
							break;
						}
						goto end_IL_003f;
						IL_00f1:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_009c;
						end_IL_003f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static TaskAwaiter vpxjjtKPbipF9REuGfr7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L1pseiKPZO6XhuCDvNku()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pWI2mHKPBCVqfsEUS2hE()
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
	private struct _003CCompleteInitializationAsync_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public ISnippetManager snippetManager;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private EzTool[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Ctj65GKPo4kb68MMUOKa() ? 3 : 5);
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellCollection> awaiter5 = default;
			TaskAwaiter<byte[]> awaiter4 = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter<EzSupportSnippet> awaiter2 = default;
			EzTool[] array2 = default;
			JobPassFail value = default;
			CvsCellLocation location = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							inspectStepViewModel.tiqAjVFA8H(snippetManager);
							num3 = 45;
							goto IL_07c3;
						case 6:
							awaiter = _003C_003Eu__2;
							goto IL_0253;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 54;
							goto IL_07c3;
						case 3:
							awaiter5 = _003C_003Eu__3;
							num3 = 56;
							goto IL_07c3;
						case 2:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 17;
							goto IL_07c3;
						case 7:
							awaiter = _003C_003Eu__2;
							num3 = 48;
							if (false)
							{
								goto IL_0533;
							}
							goto IL_07c3;
						case 0:
							awaiter4 = _003C_003Eu__1;
							num3 = 60;
							goto IL_07c3;
						case 4:
							awaiter3 = _003C_003Eu__4;
							num3 = 21;
							if (Ctj65GKPo4kb68MMUOKa())
							{
							}
							goto IL_07c3;
						case 5:
							awaiter2 = _003C_003Eu__5;
							num3 = 71;
							if (Ctj65GKPo4kb68MMUOKa())
							{
							}
							goto IL_07c3;
						case 8:
							{
								awaiter = _003C_003Eu__2;
								num3 = 64;
								goto IL_07c3;
							}
							IL_07c3:
							while (true)
							{
								object obj2;
								switch (num3)
								{
								case 15:
									num2 = (_003C_003E1__state = -1);
									goto IL_007e;
								case 13:
									awaiter = tcExmCKPkW3ZPGW8IT8I(inspectStepViewModel.SetCurrentSnippet(null));
									num3 = 2;
									continue;
								case 59:
									if (!awaiter4.IsCompleted)
									{
										num3 = 39;
										continue;
									}
									goto case 0;
								case 52:
									_003C_003Eu__2 = awaiter;
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 9;
								case 9:
									num2 = (_003C_003E1__state = 8);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 62;
									continue;
								case 44:
									if (!awaiter5.IsCompleted)
									{
										num3 = 32;
										continue;
									}
									goto case 1;
								case 56:
									break;
								case 68:
									_003C_003E7__wrap1 = array2;
									_003C_003E7__wrap2 = 0;
									num3 = 61;
									continue;
								case 41:
									inspectStepViewModel.JobPassFail = value;
									awaiter = ((Task)eKD3NoKP3taoM2gTiwg0(inspectStepViewModel, new SnippetAddedEventArgs(inspectStepViewModel.JobPassFail, SnippetAddedEventType.Created))).GetAwaiter();
									num3 = 31;
									continue;
								case 66:
									num2 = (_003C_003E1__state = -1);
									num3 = 55;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 7);
									num3 = 22;
									continue;
								case 71:
									_003C_003Eu__5 = default;
									num3 = 69;
									continue;
								case 57:
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 3:
									return;
								case 19:
									obj2 = null;
									goto IL_020b;
								case 38:
								case 53:
									goto end_IL_07c3;
								case 45:
									awaiter4 = ((UndoHandler)yldksZKPSAK6XnlwK60F(inspectStepViewModel.InSight)).SendCopyAsync(new CvsCellRange(0, 0, 1, 1)).GetAwaiter();
									num3 = 59;
									continue;
								case 30:
									return;
								case 11:
									_003C_003Eu__2 = awaiter;
									num3 = 37;
									if (Ctj65GKPo4kb68MMUOKa())
									{
									}
									continue;
								case 36:
									_003C_003Eu__3 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								case 26:
									if (inspectStepViewModel.JobPassFail != null)
									{
										goto IL_026f;
									}
									awaiter2 = inspectStepViewModel.Wd8APvDnN4.OfType<JobPassFailType>().First().AddSupportSnippet(inspectStepViewModel.n7LAWSmuQk())
										.GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										num3 = 12;
										continue;
									}
									goto case 4;
								case 12:
									_003C_003Eu__5 = awaiter2;
									num3 = 35;
									continue;
								case 25:
									if (location.IsValid)
									{
										object obj = ((result != null) ? BkQlBoKPXZ3whdigZqRZ(result, location.Row, location.Column) : null);
										if (obj != null)
										{
											obj2 = ((CvsCell)obj).Name;
											goto IL_020b;
										}
										num3 = 19;
										continue;
									}
									goto case 26;
								case 20:
									inspectStepViewModel.BbDNhcWMZm();
									goto IL_0416;
								case 27:
									return;
								case 65:
									inspectStepViewModel.PaletteFilterText = "";
									num3 = 50;
									continue;
								case 21:
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0474;
								case 8:
									array2 = inspectStepViewModel.Tools.Where([MethodImpl(MethodImplOptions.NoInlining)] (EzTool it) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return _003C_003Ec.jGy5MGKr7ASq41xWs4I4(it);
									}).ToArray();
									num3 = 68;
									continue;
								case 58:
									if (!awaiter.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto IL_0548;
								case 69:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 39:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter4;
									num3 = 47;
									continue;
								case 32:
									num2 = (_003C_003E1__state = 3);
									num3 = 36;
									continue;
								case 5:
									return;
								case 72:
									goto IL_0533;
								case 55:
									goto IL_0548;
								case 49:
									goto IL_055f;
								case 46:
									_003C_003Eu__4 = awaiter3;
									num3 = 43;
									if (true)
									{
										continue;
									}
									goto case 37;
								case 37:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 27;
									continue;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 30;
									if (uYToZXKPGvmpEZVks7YO())
									{
										continue;
									}
									goto case 28;
								case 28:
									_003C_003E7__wrap1 = null;
									num3 = 63;
									continue;
								case 16:
									num2 = (_003C_003E1__state = 4);
									num3 = 46;
									continue;
								case 31:
									goto IL_05e5;
								case 70:
									return;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 72;
										if (true)
										{
											continue;
										}
										return;
									}
									goto IL_074b;
								case 10:
									return;
								case 50:
									if (inspectStepViewModel.DefaultSimplifiedCategories.IsExactCount(0))
									{
										goto IL_0416;
									}
									num3 = 20;
									if (true)
									{
										continue;
									}
									goto case 40;
								case 40:
									num2 = (_003C_003E1__state = 1);
									num3 = 52;
									continue;
								case 6:
									awaiter = tcExmCKPkW3ZPGW8IT8I(inspectStepViewModel.Ip9AfAmPAi());
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 73;
								case 29:
									num2 = (_003C_003E1__state = -1);
									num3 = 73;
									continue;
								case 35:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 42:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 5;
									continue;
								case 67:
									inspectStepViewModel.w70ABQLieC = null;
									goto IL_0705;
								case 64:
									_003C_003Eu__2 = default;
									num3 = 29;
									continue;
								case 17:
									num2 = (_003C_003E1__state = -1);
									goto IL_074b;
								case 23:
								case 34:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 62:
									return;
								case 48:
									_003C_003Eu__2 = default;
									num3 = 66;
									continue;
								case 1:
									result = awaiter5.GetResult();
									location = GRv5MMKPpa5cJkPqWjXE(J2OAXmKPEjPYPTF83E5W(inspectStepViewModel));
									goto case 25;
								default:
									num3 = 25;
									continue;
								case 0:
									awaiter4.GetResult();
									num3 = 8;
									continue;
								case 51:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 47:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 70;
									if (uYToZXKPGvmpEZVks7YO())
									{
										continue;
									}
									goto case 43;
								case 43:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 10;
									continue;
								case 60:
									_003C_003Eu__1 = default;
									num3 = 51;
									continue;
								case 24:
								case 61:
									if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
									{
										EzTool snippet = _003C_003E7__wrap1[_003C_003E7__wrap2];
										awaiter = tcExmCKPkW3ZPGW8IT8I(inspectStepViewModel.RemoveSnippet(snippet));
										if (!awaiter.IsCompleted)
										{
											num3 = 40;
											continue;
										}
										goto IL_007e;
									}
									num3 = 28;
									continue;
								case 33:
									if (inspectStepViewModel.Snippets.Contains(inspectStepViewModel.w70ABQLieC))
									{
										goto IL_0705;
									}
									num3 = 67;
									if (!Ctj65GKPo4kb68MMUOKa())
									{
										continue;
									}
									goto case 4;
								case 4:
									value = awaiter2.GetResult() as JobPassFail;
									num3 = 41;
									continue;
								case 54:
									_003C_003Eu__2 = default;
									num3 = 15;
									continue;
								case 18:
									va6yv5KPjshKqRjn0N1E(inspectStepViewModel, null);
									num3 = 6;
									continue;
								case 63:
								{
									if (!inspectStepViewModel.Snippets.Any())
									{
										goto case 33;
									}
									EzSnippet[] array = inspectStepViewModel.Snippets.OrderBy(AppStepViewModel.GetSnippetItemOrder).ToArray();
									inspectStepViewModel.Snippets.Clear();
									Array.ForEach(array, inspectStepViewModel.Snippets.Add);
									num3 = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 22;
								}
								case 22:
									_003C_003Eu__2 = awaiter;
									num3 = 42;
									if (0 == 0)
									{
										continue;
									}
									goto case 73;
								case 73:
									{
										awaiter.GetResult();
										goto end_IL_0036;
									}
									IL_007e:
									awaiter.GetResult();
									num3 = 49;
									if (0 == 0)
									{
										continue;
									}
									goto case 13;
									IL_0705:
									awaiter5 = ((CvsCogSocket)w024maKPqE59cmP1yGm1(pqD35lKP8AyHkRX3I7ix(inspectStepViewModel))).Sheet.RunAndGetCellResults().GetAwaiter();
									num3 = 44;
									continue;
									IL_020b:
									if (!kZN6svKP90QJZ09uKSFY(obj2))
									{
										goto case 26;
									}
									awaiter3 = ((CvsCogSocketSheet)sNOHolKP4kAyEInfOUbj(w024maKPqE59cmP1yGm1(pqD35lKP8AyHkRX3I7ix(inspectStepViewModel)))).PutCellNameAsync(location, vcn1DCKP7ubnlqKKPev4(21842)).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 16;
										continue;
									}
									goto IL_0474;
									IL_074b:
									awaiter.GetResult();
									num3 = 33;
									continue;
									IL_0474:
									awaiter3.GetResult();
									num3 = 26;
									continue;
									IL_0416:
									inspectStepViewModel.EE1d5Mi5A3 = false;
									num3 = 18;
									continue;
								}
								_003C_003Eu__3 = default;
								uYToZXKPGvmpEZVks7YO();
								num3 = (Ctj65GKPo4kb68MMUOKa() ? 38 : 23);
								continue;
								IL_05e5:
								if (!awaiter.IsCompleted)
								{
									num3 = 57;
									if (!uYToZXKPGvmpEZVks7YO())
									{
										return;
									}
									continue;
								}
								goto IL_0268;
								continue;
								end_IL_07c3:
								break;
							}
							goto IL_0253;
							IL_0533:
							num2 = (_003C_003E1__state = 2);
							num3 = 11;
							if (1 == 0)
							{
								goto IL_0548;
							}
							goto IL_07c3;
							IL_0548:
							awaiter.GetResult();
							num3 = 65;
							if (!uYToZXKPGvmpEZVks7YO())
							{
								goto IL_055f;
							}
							goto IL_07c3;
							IL_055f:
							_003C_003E7__wrap2++;
							num3 = 24;
							goto IL_07c3;
							IL_0253:
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0268;
							IL_0268:
							awaiter.GetResult();
							goto IL_026f;
							IL_026f:
							awaiter = tcExmCKPkW3ZPGW8IT8I(Task.WhenAll(inspectStepViewModel.Tools.Select([MethodImpl(MethodImplOptions.NoInlining)] (EzTool tool) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return (Task)_003C_003Ec.PNqr8KKr3TwIKyU3rYWO(tool);
							})));
							num3 = 58;
							goto IL_07c3;
							end_IL_0036:
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
					break;
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object yldksZKPSAK6XnlwK60F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tcExmCKPkW3ZPGW8IT8I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pqD35lKP8AyHkRX3I7ix(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w024maKPqE59cmP1yGm1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J2OAXmKPEjPYPTF83E5W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation GRv5MMKPpa5cJkPqWjXE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).Acquired2DImageLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BkQlBoKPXZ3whdigZqRZ(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetCell(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kZN6svKP90QJZ09uKSFY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sNOHolKP4kAyEInfOUbj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vcn1DCKP7ubnlqKKPev4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eKD3NoKP3taoM2gTiwg0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void va6yv5KPjshKqRjn0N1E(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).RefreshPotentialDependencies((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uYToZXKPGvmpEZVks7YO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ctj65GKPo4kb68MMUOKa()
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
	private struct _003CRuntimeModeService_RuntimeModeChanged_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RuntimeModeChangedEventArgs a;

		public InspectStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			asUcMxKP6uCuI3bCJSn7();
			int num = (uWmq9eKPCU0HTvgujVQ2() ? 4 : 5);
			int num2 = default;
			EzTool snippet = default;
			InspectStepViewModel inspectStepViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						if (num2 == 0)
						{
							goto IL_0051;
						}
						RuntimeModeChangedEventArgs e = a;
						if (e == null || !F3yFJkKPAj4bhb19S5Ta(e))
						{
							goto IL_0051;
						}
						goto end_IL_0028;
						IL_0051:
						try
						{
							int num3;
							if (num2 != 0)
							{
								snippet = inspectStepViewModel.CurrentTool;
								num3 = 0;
								if (1 == 0)
								{
									goto IL_006a;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
								if (uWmq9eKPCU0HTvgujVQ2())
								{
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 9:
									break;
								default:
									num3 = 12;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									num2 = (_003C_003E1__state = -1);
									goto IL_00e7;
								case 7:
									snippet = inspectStepViewModel.RuntimeModeFocusTool;
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
								case 13:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
									awaiter = HQovHwKPTX6tSLGOscsZ(inspectStepViewModel.SetCurrentSnippet(snippet, isRuntimeModeChange: true));
									if (awaiter.IsCompleted)
									{
										goto IL_00e7;
									}
									asUcMxKP6uCuI3bCJSn7();
									if (!uWmq9eKPCU0HTvgujVQ2())
									{
										num3 = 13;
										if (asUcMxKP6uCuI3bCJSn7())
										{
											continue;
										}
										goto case 8;
									}
									num3 = 11;
									continue;
								case 8:
									_003C_003Eu__1 = default;
									num3 = 5;
									continue;
								case 10:
								case 11:
									oDFN8mKPysQSkPDlv2MN(inspectStepViewModel.PasteUnshiftCommand);
									num3 = 2;
									if (!uWmq9eKPCU0HTvgujVQ2())
									{
										continue;
									}
									goto case 0;
								case 0:
									if (Ag1swqKPWOIaa8UpGiWF(xFgGERKPRpOKBea4bNkC(inspectStepViewModel)))
									{
										num3 = 7;
										continue;
									}
									goto case 1;
								case 3:
									inspectStepViewModel.RuntimeModeFocusTool = null;
									num3 = 1;
									continue;
								case 6:
									inspectStepViewModel.PasteCommand.RaiseCanExecuteChanged();
									goto case 10;
								case 12:
									return;
								case 2:
									mnwRJpKP0YI73C2Hmdto(inspectStepViewModel, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4114));
									num3 = 14;
									continue;
								case 14:
									{
										mnwRJpKP0YI73C2Hmdto(inspectStepViewModel, CdQUGaROfy7He9T0foW.KbIzwHEDLa(48620));
										goto end_IL_0091;
									}
									IL_00e7:
									awaiter.GetResult();
									num3 = 6;
									continue;
								}
								goto IL_006a;
								continue;
								end_IL_0091:
								break;
							}
							goto end_IL_0051;
							IL_006a:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							end_IL_0051:;
						}
						catch (Exception ex)
						{
							tvvAxfHbyB.WarnException((string)YVHn2sKPFTr4W1RSP6Pu(ex), ex);
						}
						end_IL_0028:;
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
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
		internal static bool F3yFJkKPAj4bhb19S5Ta(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeModeChangedEventArgs)P_0).IsSubsystemChangeOnly;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xFgGERKPRpOKBea4bNkC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).RuntimeModeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ag1swqKPWOIaa8UpGiWF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HQovHwKPTX6tSLGOscsZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oDFN8mKPysQSkPDlv2MN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mnwRJpKP0YI73C2Hmdto(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YVHn2sKPFTr4W1RSP6Pu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool asUcMxKP6uCuI3bCJSn7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uWmq9eKPCU0HTvgujVQ2()
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
	private struct _003CGetSnippetLocation_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public CvsCellRange range;

		public bool right;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (fcHJDhKPMZOLfWNKpc1n())
					{
						num = 0;
						continue;
					}
					num = 5;
					if (dT0CfoKPYyKj7sMv5qi1())
					{
					}
					continue;
				case 0:
				case 1:
					inspectStepViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<CvsCellRange> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inspectStepViewModel.n7LAWSmuQk().GetSnippetLocation(range, right).GetAwaiter();
							num3 = 5;
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
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (dT0CfoKPYyKj7sMv5qi1())
								{
								}
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 2:
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 8:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = (dT0CfoKPYyKj7sMv5qi1() ? 3 : 0);
									continue;
								}
								break;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
				_003C_003Et__builder.SetResult(result);
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
		internal static bool fcHJDhKPMZOLfWNKpc1n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dT0CfoKPYyKj7sMv5qi1()
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
	private struct _003CGetSnippetLocation_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange range;

		public bool right;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					fA76paKPH4GTJwsT85dK();
					if (JYNjXaKPUyOKlwtfKrm0())
					{
						num = 0;
						break;
					}
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto default;
				case 2:
					try
					{
						TaskAwaiter<CvsCellRange> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inspectStepViewModel.n7LAWSmuQk().GetSnippetLocation(cells, range, right).GetAwaiter();
							_ = 1;
							num3 = ((!fA76paKPH4GTJwsT85dK()) ? 1 : 3);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 0:
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 7:
								return;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (true)
								{
									continue;
								}
								break;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 1:
					inspectStepViewModel = _003C_003E4__this;
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
		internal static bool JYNjXaKPUyOKlwtfKrm0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fA76paKPH4GTJwsT85dK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public Guid id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass73_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vbKptOKPQBLOmUfejPLT();
			EqiU0OKPNu6QHpdWHolv(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindToolType_003Eb__0(EzToolType t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)WOMYkkKP2wNegWmxY8jM(t)).Contains(id);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vbKptOKPQBLOmUfejPLT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EqiU0OKPNu6QHpdWHolv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WlqX7YKPxkf3g7v5N7Un()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jxmLHBKPmkfKhaYrSrSX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WOMYkkKP2wNegWmxY8jM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public string[] categoryNames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass75_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EHTZ1iKPukbj5vGUfAvP();
			LfJdt0KPh4RJQIX6tTco(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitToolTypes_003Eb__2(ToolCategory category)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return z2iSiqKPts1amuaCGtwr(category.Name, categoryNames.Last());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EHTZ1iKPukbj5vGUfAvP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LfJdt0KPh4RJQIX6tTco(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool STjfwMKPcL6eThRsUOMc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G4OCRJKP1UoO4qEyYIsX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z2iSiqKPts1amuaCGtwr(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass75_1
	{
		public string name;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass75_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rKD8mnKZKwQtt0YnJ6qC();
			ig2hmiKZ522HkB73QpiQ(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitToolTypes_003Eb__3(ToolCategory c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q9mjZEKZJLqFv1qcHukZ(SmkEDKKZwGfxl7PlIMun(c), name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rKD8mnKZKwQtt0YnJ6qC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ig2hmiKZ522HkB73QpiQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Na6R7iKPzWTgUp4iqCqa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wGsDQhKZLHVQHgb2NJot()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SmkEDKKZwGfxl7PlIMun(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolCategory)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q9mjZEKZJLqFv1qcHukZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnPaste_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					_ = 1;
					num = ((!mX78IXKZebi683nqURU9()) ? 1 : 4);
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = nttgu7KZOrkelCoKgOen(inspectStepViewModel.GAwA59UD5w(_0020: true));
							_ = 1;
							num3 = (mX78IXKZebi683nqURU9() ? 1 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 1:
								return;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (mX78IXKZebi683nqURU9())
								{
								}
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
		internal static TaskAwaiter nttgu7KZOrkelCoKgOen(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MlZMgUKZaTm1nRS6TRbU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mX78IXKZebi683nqURU9()
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
	private struct _003COnPasteUnshift_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

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
			InspectStepViewModel inspectStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					mKepCiKZIDNDbq68E2Ve();
					num = ((!FnZnJMKZDE3t4u0MPTXF()) ? 5 : 0);
					break;
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = x10FkEKZinseNA2NGuxi(inspectStepViewModel.GAwA59UD5w(_0020: false));
							num3 = 0;
							goto IL_011e;
						}
						awaiter = _003C_003Eu__1;
						goto IL_007e;
						IL_007e:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (FnZnJMKZDE3t4u0MPTXF())
						{
						}
						goto IL_011e;
						IL_011e:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 7:
								break;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 4:
							case 6:
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!FnZnJMKZDE3t4u0MPTXF())
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								mKepCiKZIDNDbq68E2Ve();
								if (FnZnJMKZDE3t4u0MPTXF())
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_011e;
							}
							goto IL_007e;
							continue;
							end_IL_011e:
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
		internal static TaskAwaiter x10FkEKZinseNA2NGuxi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mKepCiKZIDNDbq68E2Ve()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FnZnJMKZDE3t4u0MPTXF()
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
	private struct _003COnPaste_003Ed__122 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool shift;

		public InspectStepViewModel _003C_003E4__this;

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
			InspectStepViewModel inspectStepViewModel = default;
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (FdWHMnKZntO3NPRJTDF5() ? 3 : 0);
					continue;
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							if (shift)
							{
								inspectStepViewModel.f6cAiOYCKR++;
							}
							PasteToolUndoAction undoAction = new PasteToolUndoAction(inspectStepViewModel, shift, inspectStepViewModel.Q4ZAqKq0Iy, inspectStepViewModel.f6cAiOYCKR);
							undoActionBlockingProgressWrapper = new UndoActionBlockingProgressWrapper(inspectStepViewModel.OperationProgressManager, undoAction, (string)BJKMMHKZfMG6kHvWst34(), (string)CUE6fyKZd1ZMhonCJ6Ub());
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = DnywFYKZsmVEGYA2J6Ml(iLdptDKZgm7w6p8TWkMG(((CvsInSight)FnmqAGKZl2TEiRcbTZ0Z(inspectStepViewModel)).UndoHandler, undoActionBlockingProgressWrapper));
								_ = 0;
								if (FdWHMnKZntO3NPRJTDF5())
								{
									num3 = 4;
								}
								else
								{
									num3 = 6;
									if (false)
									{
										goto IL_00d5;
									}
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
								case 8:
									num2 = (_003C_003E1__state = 0);
									goto case 2;
								case 1:
									break;
								default:
									num3 = 3;
									continue;
								case 2:
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 7:
									_003C_003Eu__1 = default;
									num3 = 5;
									continue;
								case 3:
									return;
								case 0:
								case 4:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									goto end_IL_00f5;
								}
								goto IL_00d5;
								continue;
								end_IL_00f5:
								break;
							}
							goto end_IL_0086;
							IL_00d5:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							end_IL_0086:;
						}
						catch (Exception ex)
						{
							cB00ssKZraoyOmWN55SM(tvvAxfHbyB, ppC68VKZvaRiUYC0weUK(ex), ex);
							FailAddEventArgs e = new FailAddEventArgs((string)ppC68VKZvaRiUYC0weUK(ex));
							inspectStepViewModel.Sp8Azi12BL?.Invoke(inspectStepViewModel, e);
						}
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
				case 1:
				case 3:
					inspectStepViewModel = _003C_003E4__this;
					goto case 0;
				case 4:
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
		internal static object BJKMMHKZfMG6kHvWst34()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DTYL8Jm4jB();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CUE6fyKZd1ZMhonCJ6Ub()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.knw9yFBiPT();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FnmqAGKZl2TEiRcbTZ0Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iLdptDKZgm7w6p8TWkMG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DnywFYKZsmVEGYA2J6Ml(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ppC68VKZvaRiUYC0weUK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cB00ssKZraoyOmWN55SM(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).FatalException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FdWHMnKZntO3NPRJTDF5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pe3q8PKZVGF5a6VL3j9m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public EzToolType tool;

		public Func<ToolCategory, bool> _003C_003E9__0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass128_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vqVbPgKZB414EPaOYOCC();
			iTHNFQKZb3yyiu5fDDlQ(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateFilteredSimplifiedCategories_003Eb__0(ToolCategory it)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ce7DrkKZSR3UhZii3D6I(NPP6aPKZGF22k5J4jbEu(it), iM1aFKKZonr5UbKPOF5A(tool));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vqVbPgKZB414EPaOYOCC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iTHNFQKZb3yyiu5fDDlQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y8MPXQKZPjJYf6ecNCgv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z2YYoEKZZwj5hkpt0p3v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NPP6aPKZGF22k5J4jbEu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToolCategory)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iM1aFKKZonr5UbKPOF5A(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Category;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ce7DrkKZSR3UhZii3D6I(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetCurrentSnippet_003Ed__152 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet snippet;

		public InspectStepViewModel _003C_003E4__this;

		public bool isRuntimeModeChange;

		private IDisposable _003C_003E7__wrap1;

		private EzTool _003Ctool_003E5__3;

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
			int num = ((!KjwmXxKZ8ccgjYR2s26p()) ? 1 : 3);
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			Dictionary<string, object> dictionary3 = default;
			EzTool currentTool = default;
			Dictionary<string, object> dictionary2 = default;
			InternalCheckBoxViewModel internalCheckBoxViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (iWua8YKZkfggNRrOGuGQ())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003C_003E7__wrap1 = CvsTraceEzb.Info.TraceFunction(CdQUGaROfy7He9T0foW.KbIzwHEDLa(48658));
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 9;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 21;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num3 = 34;
								if (!iWua8YKZkfggNRrOGuGQ())
								{
									goto IL_03ca;
								}
							}
							goto IL_04a8;
							IL_04a8:
							while (true)
							{
								object obj2;
								object obj;
								object obj3;
								switch (num3)
								{
								case 17:
									break;
								case 3:
									dictionary3 = inspectStepViewModel.V4DAuY3oul(currentTool, _0020: false);
									num3 = 15;
									continue;
								case 24:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 23;
									continue;
								case 31:
									_003C_003Eu__1 = awaiter2;
									num3 = 24;
									continue;
								case 4:
									inspectStepViewModel.CurrentTool = _003Ctool_003E5__3;
									num3 = 32;
									continue;
								case 0:
								case 12:
								{
									EzTool ezTool = inspectStepViewModel.vATAFT7HML(_003Ctool_003E5__3);
									if (currentTool != ezTool)
									{
										num3 = 3;
										continue;
									}
									goto case 22;
								}
								case 25:
									num2 = (_003C_003E1__state = 1);
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
									awaiter2 = H7q6BBKZEofshobNdqxd(rImaHoKZqa7GvnnkXAhH(inspectStepViewModel.CurrentTool));
									if (!awaiter2.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto IL_033c;
								case 5:
									obj2 = null;
									goto IL_0172;
								case 1:
									obj = null;
									goto IL_01d2;
								case 14:
									num2 = (_003C_003E1__state = 0);
									num3 = 31;
									continue;
								case 18:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 28:
									inspectStepViewModel.FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4088));
									num3 = 35;
									if (0 == 0)
									{
										continue;
									}
									goto case 21;
								case 21:
									_003C_003Eu__2 = default;
									num3 = 27;
									continue;
								case 7:
									goto end_IL_04a8;
								case 2:
									obj2 = null;
									goto IL_0172;
								case 19:
								{
									currentTool = inspectStepViewModel.CurrentTool;
									IRuntimeModeService runtimeModeService = inspectStepViewModel.RuntimeModeService;
									if (runtimeModeService == null)
									{
										num3 = 13;
										if (iWua8YKZkfggNRrOGuGQ())
										{
											continue;
										}
										goto case 32;
									}
									if (runtimeModeService.IsOperatorOfflineAndNotInLiveMode)
									{
										goto case 13;
									}
									inspectStepViewModel.RuntimeModeFocusTool = _003Ctool_003E5__3;
									num3 = 17;
									if (iWua8YKZkfggNRrOGuGQ())
									{
										continue;
									}
									goto case 8;
								}
								case 32:
									dictionary2 = new Dictionary<string, object>();
									if (currentTool != null)
									{
										obj = currentTool.Focus;
										goto IL_01d2;
									}
									num3 = 1;
									if (iWua8YKZkfggNRrOGuGQ())
									{
										continue;
									}
									goto end_IL_0074;
								case 29:
									goto end_IL_0074;
								case 13:
									if ((inspectStepViewModel.CurrentTool != _003Ctool_003E5__3) | isRuntimeModeChange)
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 26;
									}
									goto case 35;
								case 26:
									dictionary2.AppendDictionary(dictionary3);
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									if (v8NUPRKZ3M62HeCkxkU9(dictionary3) > 0)
									{
										num3 = 26;
										continue;
									}
									goto case 22;
								case 27:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 33;
								case 33:
									num2 = (_003C_003E1__state = -1);
									goto IL_033c;
								case 11:
								case 30:
									if (!((IRuntimeModeService)NT61LOKZplS7lcYycACM(inspectStepViewModel)).IsLiveMode)
									{
										goto case 13;
									}
									num3 = 29;
									if (0 == 0)
									{
										continue;
									}
									goto case 34;
								case 34:
									_003C_003Eu__1 = default;
									num3 = 33;
									continue;
								case 22:
								{
									Dictionary<string, object> dictionary = inspectStepViewModel.V4DAuY3oul(inspectStepViewModel.CurrentTool);
									if (dictionary.Count > 0)
									{
										dictionary2.AppendDictionary(dictionary);
										num3 = 20;
										continue;
									}
									goto IL_03ca;
								}
								case 23:
									return;
								case 20:
									goto IL_03ca;
								case 8:
									_003C_003Eu__2 = awaiter;
									num3 = 18;
									continue;
								case 9:
									_003Ctool_003E5__3 = (EzTool)snippet;
									if (inspectStepViewModel.CurrentTool != null)
									{
										num3 = 6;
										continue;
									}
									goto case 19;
								case 10:
								case 16:
								{
									CvsInSight inSight = inspectStepViewModel.InSight;
									if (inSight != null)
									{
										CvsResultSet results = inSight.Results;
										if (results != null)
										{
											obj2 = LtEY70KZ46NN7d6hn0Sv(ASuMDcKZXaqx1tnN7lRD(results), OVMSqQKZ9Q8toEW7FGeN(internalCheckBoxViewModel));
											goto IL_0172;
										}
										num3 = 5;
										continue;
									}
									goto case 2;
								}
								default:
									num3 = 2;
									continue;
								case 35:
									{
										_003Ctool_003E5__3 = null;
										goto IL_0571;
									}
									IL_01d2:
									internalCheckBoxViewModel = (InternalCheckBoxViewModel)obj;
									if (internalCheckBoxViewModel == null)
									{
										goto IL_0181;
									}
									goto case 10;
									IL_0172:
									if (obj2 != null)
									{
										internalCheckBoxViewModel.WriteViaRun(dictionary2, value: false);
									}
									goto IL_0181;
									IL_0181:
									obj3 = NT61LOKZplS7lcYycACM(inspectStepViewModel);
									if (obj3 != null && awCtFqKZ76cTVMPQsTuZ(obj3))
									{
										EzTool currentTool2 = inspectStepViewModel.CurrentTool;
										if (currentTool2 != null)
										{
											InternalCheckBoxViewModel focus = currentTool2.Focus;
											if (focus == null)
											{
												num3 = 0;
												continue;
											}
											focus.WriteViaRun(dictionary2, value: true);
											num3 = 12;
											if (0 == 0)
											{
												continue;
											}
											goto case 13;
										}
									}
									goto case 0;
									IL_033c:
									awaiter2.GetResult();
									num3 = 19;
									continue;
								}
								if (isRuntimeModeChange)
								{
									_ = 0;
									num3 = ((!iWua8YKZkfggNRrOGuGQ()) ? 10 : 30);
									continue;
								}
								goto end_IL_0074;
								continue;
								end_IL_04a8:
								break;
							}
							goto IL_0255;
							IL_03ca:
							awaiter = ((CvsCogSocketSheet)PhbQOYKZCmD0C1tx8GEe(WxwsBAKZ6kW6rSJIF6I4(zOxn1LKZjNURGRLkF3HE(inspectStepViewModel)))).RunAsync(dictionary2, IjfpUJKZAt0DZpbEXiio(inspectStepViewModel.OperationProgressManager)).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_0255;
							}
							num3 = 25;
							goto IL_04a8;
							IL_0255:
							awaiter.GetResult();
							num3 = 28;
							goto IL_04a8;
							end_IL_0074:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								yXkt82KZReDOUroahFOS(_003C_003E7__wrap1);
							}
						}
						goto end_IL_0052;
						IL_0571:
						_003C_003E7__wrap1 = null;
						end_IL_0052:;
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
					num = 5;
					if (!KjwmXxKZ8ccgjYR2s26p())
					{
						continue;
					}
					break;
				case 5:
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
		internal static object rImaHoKZqa7GvnnkXAhH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).AwaitIfUpdatingName();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter H7q6BBKZEofshobNdqxd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NT61LOKZplS7lcYycACM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).RuntimeModeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ASuMDcKZXaqx1tnN7lRD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation OVMSqQKZ9Q8toEW7FGeN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LtEY70KZ46NN7d6hn0Sv(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool awCtFqKZ76cTVMPQsTuZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int v8NUPRKZ3M62HeCkxkU9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Dictionary<string, object>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zOxn1LKZjNURGRLkF3HE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WxwsBAKZ6kW6rSJIF6I4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PhbQOYKZCmD0C1tx8GEe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IjfpUJKZAt0DZpbEXiio(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yXkt82KZReDOUroahFOS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iWua8YKZkfggNRrOGuGQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KjwmXxKZ8ccgjYR2s26p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CExposedProperties_003Ed__159 : IEnumerable<CellViewModel>, IEnumerable, IEnumerator<CellViewModel>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CellViewModel _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private EzSnippet snippet;

		public EzSnippet _003C_003E3__snippet;

		private Stack<CellViewModel> _003Cstack_003E5__2;

		private CellViewModel _003Cnext_003E5__3;

		CellViewModel IEnumerator<CellViewModel>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CExposedProperties_003Ed__159(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_007b;
			IL_002c:
			_003C_003El__initialThreadId = rfhoexKZ0mhN1X2XnnSW();
			num = 6;
			if (false)
			{
				goto IL_0043;
			}
			goto IL_007b;
			IL_007b:
			switch (num)
			{
			case 1:
			case 5:
				break;
			default:
				goto IL_002c;
			case 2:
				goto IL_0043;
			case 0:
				this._003C_003E1__state = _003C_003E1__state;
				goto IL_002c;
			case 6:
				return;
			}
			goto IL_001a;
			IL_0043:
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			MJESTOKZTYUtXvyBBXOa();
			num = ((!wdYAIVKZW0fplDqpyrO2()) ? 4 : 5);
			goto IL_007b;
			IL_001a:
			ckR1Q7KZyq7InsEGvOmV(this);
			num = 0;
			if (false)
			{
				goto IL_002c;
			}
			goto IL_007b;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			IEnumerator<FixtureViewModel> enumerator = default;
			int num2 = default;
			FixtureArrayViewModel fixtureArrayViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 11:
					try
					{
						while (h7ly1DKZFRhnkKFO7G3s(enumerator))
						{
							FixtureViewModel current = enumerator.Current;
							wdYAIVKZW0fplDqpyrO2();
							int num3;
							if (!MJESTOKZTYUtXvyBBXOa())
							{
								num3 = 2;
								if (!wdYAIVKZW0fplDqpyrO2())
								{
									goto IL_0044;
								}
							}
							else
							{
								num3 = 3;
							}
							switch (num3)
							{
							case 0:
							case 2:
								break;
							default:
								continue;
							}
							goto IL_0044;
							IL_0044:
							_003Cstack_003E5__2.Push(current);
						}
					}
					finally
					{
						if (enumerator != null)
						{
							yOtIyeKZM51jM6KLynsj(enumerator);
						}
					}
					goto IL_00a4;
				case 5:
					_003C_003E2__current = _003Cnext_003E5__3;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
					_003Cstack_003E5__2 = new Stack<CellViewModel>(snippet.AllProperties.Reverse());
					num = 12;
					break;
				case 7:
					num2 = _003C_003E1__state;
					wdYAIVKZW0fplDqpyrO2();
					if (!MJESTOKZTYUtXvyBBXOa())
					{
						num = 13;
						if (wdYAIVKZW0fplDqpyrO2())
						{
							break;
						}
						goto case 8;
					}
					num = 2;
					break;
				case 8:
					fixtureArrayViewModel = _003Cnext_003E5__3 as FixtureArrayViewModel;
					if (fixtureArrayViewModel == null)
					{
						goto IL_00a4;
					}
					num = 6;
					if (true)
					{
						break;
					}
					goto case 10;
				case 10:
					return true;
				case 14:
					if (num2 == 1)
					{
						_003C_003E1__state = -1;
						num = 8;
					}
					else
					{
						num = 9;
					}
					break;
				case 1:
				case 13:
					if (num2 != 0)
					{
						num = 14;
						break;
					}
					_003C_003E1__state = -1;
					num = 0;
					break;
				case 3:
					_003C_003E1__state = 1;
					num = 10;
					break;
				case 4:
				case 12:
					while (true)
					{
						if (_003Cstack_003E5__2.Any())
						{
							_003Cnext_003E5__3 = _003Cstack_003E5__2.Pop();
							if (!_003Cnext_003E5__3.Internal)
							{
								num = 5;
								break;
							}
							continue;
						}
						num = 15;
						if (MJESTOKZTYUtXvyBBXOa())
						{
						}
						break;
					}
					break;
				case 6:
					enumerator = fixtureArrayViewModel.Fixtures.Reverse().GetEnumerator();
					goto case 2;
				case 9:
					return false;
				case 15:
					{
						return false;
					}
					IL_00a4:
					_003Cnext_003E5__3 = null;
					num = 4;
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<CellViewModel> IEnumerable<CellViewModel>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CExposedProperties_003Ed__159 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CExposedProperties_003Ed__159(0);
			}
			obj.snippet = _003C_003E3__snippet;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<CellViewModel>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ckR1Q7KZyq7InsEGvOmV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rfhoexKZ0mhN1X2XnnSW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wdYAIVKZW0fplDqpyrO2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MJESTOKZTYUtXvyBBXOa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h7ly1DKZFRhnkKFO7G3s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yOtIyeKZM51jM6KLynsj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass162_0
	{
		public InspectStepViewModel _003C_003E4__this;

		public Func<CellViewModel, bool> predicate;

		public List<CvsCellLocation> dependentCells;

		public CellViewModel targetProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass162_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vmbrH0KZHQMlPA5BKE5f();
			QWnQHfKZxQ3CGTb8D4dA(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<CellViewModel> _003CGetSourceablePropertiesGrouped_003Eb__0(EzSnippet tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.ExposedProperties(tool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePropertiesGrouped_003Eb__2(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IsSourceableProperty(_003C_003Eh__TransparentIdentifier0.prop);
			[MethodImpl(MethodImplOptions.NoInlining)]
			bool IsSourceableProperty(CellViewModel property)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				TLoaGNKZUW2GmI1FwFCT();
				int num = (TMGZHoKZYZfZiH5pyLOF() ? 1 : 5);
				while (true)
				{
					switch (num)
					{
					case 0:
					case 1:
						if (!N2GELGKZQgp69jfrPSmE(property))
						{
							num = 2;
							continue;
						}
						goto case 4;
					case 4:
						if (!dependentCells.Contains(ynCDpPKZN4FbuBbdtCXe(property)))
						{
							num = 7;
							continue;
						}
						break;
					default:
						if (!(property is BlobsViewModel))
						{
							break;
						}
						num = 4;
						if (TMGZHoKZYZfZiH5pyLOF())
						{
							continue;
						}
						goto case 2;
					case 2:
						if (!(property is InputImageViewModel))
						{
							num = 6;
							continue;
						}
						goto case 4;
					case 6:
						if (property is ImageViewModel)
						{
							goto case 4;
						}
						goto default;
					case 7:
						return targetProperty.YJwH11Te4e(property);
					}
					break;
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePropertiesGrouped_003Eb__5(CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IsSourceableProperty(prop))
			{
				return predicate(prop);
			}
			return false;
			[MethodImpl(MethodImplOptions.NoInlining)]
			bool IsSourceableProperty(CellViewModel property)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				TLoaGNKZUW2GmI1FwFCT();
				int num = (TMGZHoKZYZfZiH5pyLOF() ? 1 : 5);
				while (true)
				{
					switch (num)
					{
					case 0:
					case 1:
						if (!N2GELGKZQgp69jfrPSmE(property))
						{
							num = 2;
							continue;
						}
						goto case 4;
					case 4:
						if (!dependentCells.Contains(ynCDpPKZN4FbuBbdtCXe(property)))
						{
							num = 7;
							continue;
						}
						break;
					default:
						if (!(property is BlobsViewModel))
						{
							break;
						}
						num = 4;
						if (TMGZHoKZYZfZiH5pyLOF())
						{
							continue;
						}
						goto case 2;
					case 2:
						if (!(property is InputImageViewModel))
						{
							num = 6;
							continue;
						}
						goto case 4;
					case 6:
						if (property is ImageViewModel)
						{
							goto case 4;
						}
						goto default;
					case 7:
						return targetProperty.YJwH11Te4e(property);
					}
					break;
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePropertiesGrouped_003Eb__6(CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)MxNrqAKZm4tfC9g2ReRq(_003C_003E4__this.JobPassFail);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vmbrH0KZHQMlPA5BKE5f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QWnQHfKZxQ3CGTb8D4dA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TMGZHoKZYZfZiH5pyLOF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TLoaGNKZUW2GmI1FwFCT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MxNrqAKZm4tfC9g2ReRq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N2GELGKZQgp69jfrPSmE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).IsPrimitive;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation ynCDpPKZN4FbuBbdtCXe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass163_0
	{
		public InspectStepViewModel _003C_003E4__this;

		public CellViewModel targetProperty;

		public Func<CellViewModel, bool> predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass163_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			r6mFeqKZ1yPIw1SpkY78();
			WwjcLdKZux81cGyODWt4(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<CellViewModel> _003CGetSourceablePrimitivesGrouped_003Eb__0(EzSnippet tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.ExposedProperties(tool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesGrouped_003Eb__2(_003C_003Ef__AnonymousType2<EzSnippet, CellViewModel> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (_003C_003Eh__TransparentIdentifier0.prop.IsPrimitive && _003C_003Eh__TransparentIdentifier0.prop.YJwH11Te4e(targetProperty))
			{
				return predicate(_003C_003Eh__TransparentIdentifier0.prop);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesGrouped_003Eb__5(CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (PPremYKZh8JwLq39XMrK(prop) && P0Ag9kKZtaoyvmfUoQaS(prop, targetProperty))
			{
				return predicate(prop);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePrimitivesGrouped_003Eb__6(CellViewModel prop)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.JobPassFail.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void r6mFeqKZ1yPIw1SpkY78()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WwjcLdKZux81cGyODWt4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MlfElrKZ2b9wtdLPKEbq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KfOUljKZcJcSr7urYIDU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PPremYKZh8JwLq39XMrK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).IsPrimitive;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P0Ag9kKZtaoyvmfUoQaS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).YJwH11Te4e((CellViewModel)P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CTool_AcceptAdd_003Ed__164 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public AcceptAddEventHandlerArgs e;

		private AddToolUndoAction _003CundoAction_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QT3sFCKZzufq5LPsE9TU();
			int num;
			if (!FkF9BsKBL1ZWjQgBP7an())
			{
				num = 2;
				if (!QT3sFCKZzufq5LPsE9TU())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_039f;
			IL_0411:
			_003CundoAction_003E5__2 = null;
			num = 3;
			if (1 == 0)
			{
				return;
			}
			goto IL_039f;
			IL_039f:
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				default:
					num = 4;
					continue;
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 6;
					continue;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (QT3sFCKZzufq5LPsE9TU())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					goto IL_0411;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
				switch (num2)
				{
				default:
					awaiter = tyrlDyKB5BGNxyPJ31q8(inspectStepViewModel.AcceptAdd((EzTool)AmfjG9KBKg4T0dbET4UO(e)));
					num3 = 21;
					goto IL_0205;
				case 0:
					awaiter = _003C_003Eu__1;
					num3 = 6;
					if (false)
					{
						goto IL_01a7;
					}
					goto IL_0205;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					goto IL_010f;
				case 1:
					{
						awaiter = _003C_003Eu__1;
						num3 = 15;
						if (0 == 0)
						{
							goto IL_0205;
						}
						goto IL_032d;
					}
					IL_0205:
					while (true)
					{
						switch (num3)
						{
						case 5:
							awaiter.GetResult();
							num3 = 7;
							continue;
						case 3:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							}
							goto IL_032d;
						case 7:
							_003CundoAction_003E5__2 = new AddToolUndoAction(inspectStepViewModel, daRTBkKBwKaUsnkHkjtO(AmfjG9KBKg4T0dbET4UO(e)), ((EzSnippet)AmfjG9KBKg4T0dbET4UO(e)).Name);
							awaiter = inspectStepViewModel.FireSnippetAdded(new SnippetAddedEventArgs((EzSnippet)AmfjG9KBKg4T0dbET4UO(e), SnippetAddedEventType.Created)).GetAwaiter();
							num3 = 3;
							continue;
						case 20:
							num2 = (_003C_003E1__state = -1);
							num3 = 5;
							continue;
						case 8:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 9;
							continue;
						case 18:
						case 19:
							break;
						case 15:
							goto IL_0128;
						case 12:
							undoActionBlockingProgressWrapper = new UndoActionBlockingProgressWrapper(inspectStepViewModel.OperationProgressManager, _003CundoAction_003E5__2, (string)esDWDiKBeWGoR8cJvUrG(lSpKRDKBJsI0QMkuslqn(), wEEp5LKBavmQyIOoiaus(AmfjG9KBKg4T0dbET4UO(e))), (string)esDWDiKBeWGoR8cJvUrG(lEt9HdKBO2SthNFMdjOR(), wEEp5LKBavmQyIOoiaus(AmfjG9KBKg4T0dbET4UO(e))));
							num3 = 13;
							continue;
						case 9:
							return;
						case 16:
						case 17:
							goto IL_01a7;
						case 13:
							goto IL_01bf;
						case 2:
							_003C_003Eu__1 = awaiter;
							goto IL_0307;
						default:
							num3 = 14;
							continue;
						case 1:
							num2 = (_003C_003E1__state = -1);
							num3 = 11;
							continue;
						case 21:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							}
							goto case 5;
						case 4:
							_003C_003Eu__1 = awaiter;
							num3 = 8;
							continue;
						case 10:
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 0;
							if (true)
							{
								continue;
							}
							return;
						case 0:
							return;
						case 14:
							goto IL_0307;
						case 11:
							goto IL_032d;
						case 6:
							goto IL_0340;
						case 22:
							goto end_IL_002f;
						}
						break;
					}
					goto IL_010f;
					IL_01a7:
					if (awaiter.IsCompleted)
					{
						break;
					}
					num3 = 10;
					if (1 == 0)
					{
						goto IL_01bf;
					}
					goto IL_0205;
					IL_0128:
					_003C_003Eu__1 = default;
					num3 = 1;
					goto IL_0205;
					IL_01bf:
					awaiter = tyrlDyKB5BGNxyPJ31q8(MmR7KYKBiNJ3CkJtjHfq(slcVSQKBDVgKoRITsvD9(qkGGfnKBI5fAD7TJVxk3(inspectStepViewModel)), undoActionBlockingProgressWrapper));
					_ = 0;
					if (QT3sFCKZzufq5LPsE9TU())
					{
						num3 = 17;
					}
					else
					{
						num3 = 18;
						if (1 == 0)
						{
							goto IL_0307;
						}
					}
					goto IL_0205;
					IL_032d:
					awaiter.GetResult();
					num3 = 12;
					if (0 == 0)
					{
						goto IL_0205;
					}
					goto IL_0340;
					IL_0340:
					_003C_003Eu__1 = default;
					num3 = 20;
					goto IL_0205;
					IL_0307:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_010f:
					num2 = (_003C_003E1__state = -1);
					num3 = 22;
					if (!QT3sFCKZzufq5LPsE9TU())
					{
						goto IL_0128;
					}
					goto IL_0205;
					end_IL_002f:
					break;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CundoAction_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0411;
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
		internal static object AmfjG9KBKg4T0dbET4UO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AcceptAddEventHandlerArgs)P_0).Tool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tyrlDyKB5BGNxyPJ31q8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange daRTBkKBwKaUsnkHkjtO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lSpKRDKBJsI0QMkuslqn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.coRG0InpdO();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wEEp5LKBavmQyIOoiaus(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object esDWDiKBeWGoR8cJvUrG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lEt9HdKBO2SthNFMdjOR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.nuY9CivFDK();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qkGGfnKBI5fAD7TJVxk3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object slcVSQKBDVgKoRITsvD9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MmR7KYKBiNJ3CkJtjHfq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QT3sFCKZzufq5LPsE9TU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FkF9BsKBL1ZWjQgBP7an()
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
	private struct _003CAcceptAdd_003Ed__165 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public EzTool tool;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					goto case 0;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (pE9S4uKBnZnsBeK5Wk1k())
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							inspectStepViewModel.r4yADFiXZx(tool);
							num3 = 2;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 13;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 22;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 17;
							case 17:
								awaiter.GetResult();
								num3 = 7;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 1:
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									if (pE9S4uKBnZnsBeK5Wk1k())
									{
										continue;
									}
									goto case 3;
								}
								goto case 13;
							case 3:
								awaiter.GetResult();
								inspectStepViewModel.AddingSnippetType = null;
								if (!inspectStepViewModel.EE1d5Mi5A3)
								{
									goto case 5;
								}
								goto end_IL_00e1;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 18;
							case 18:
								_003C_003Eu__1 = awaiter;
								sjHCqkKBVVganSXcIkn7();
								num3 = (pE9S4uKBnZnsBeK5Wk1k() ? 1 : 5);
								continue;
							case 20:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 24;
								continue;
							case 7:
								awaiter = xRHd30KBf0xN65p2oZEQ(inspectStepViewModel.Ip9AfAmPAi());
								num3 = 15;
								if (pE9S4uKBnZnsBeK5Wk1k())
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = 1);
								num3 = 18;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 2);
								num3 = 4;
								continue;
							case 2:
								awaiter = xRHd30KBf0xN65p2oZEQ(inspectStepViewModel.SetCurrentSnippet(tool));
								num3 = 12;
								continue;
							case 8:
								return;
							case 24:
								return;
							case 19:
								fwZMlkKBsuG2lb8v28sD(inspectStepViewModel.Analyzer);
								num3 = 25;
								continue;
							case 13:
								awaiter.GetResult();
								awaiter = xRHd30KBf0xN65p2oZEQ(TVTYngKBdogKIRaOq8kY(tool));
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (sjHCqkKBVVganSXcIkn7())
									{
									}
									continue;
								}
								goto case 3;
							case 22:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 5:
							case 21:
								Akym6NKBgehF4ffmadER(ICJZhnKBlta2hioY9on1(inspectStepViewModel), true, true);
								num3 = 19;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 23:
								num2 = (_003C_003E1__state = 0);
								num3 = 16;
								if (pE9S4uKBnZnsBeK5Wk1k())
								{
									continue;
								}
								break;
							case 25:
								break;
							}
							PG2NJHKBva6K3G8A3gHw(inspectStepViewModel, null);
							break;
							continue;
							end_IL_00e1:
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
					goto case 3;
				default:
					num = 3;
					break;
				case 4:
					num2 = _003C_003E1__state;
					pE9S4uKBnZnsBeK5Wk1k();
					if (sjHCqkKBVVganSXcIkn7())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 3;
					}
					num = 5;
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
		internal static TaskAwaiter xRHd30KBf0xN65p2oZEQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TVTYngKBdogKIRaOq8kY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).hFa6aQHHed();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ICJZhnKBlta2hioY9on1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Akym6NKBgehF4ffmadER(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fwZMlkKBsuG2lb8v28sD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsJobAnalyzer)P_0).Reset();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PG2NJHKBva6K3G8A3gHw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).RefreshPotentialDependencies((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pE9S4uKBnZnsBeK5Wk1k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sjHCqkKBVVganSXcIkn7()
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
	private struct _003CRemoveSnippet_003Ed__170 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public EzSnippet tool;

		private EzSnippet _003CnextCurrentSnippet_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_061d;
			IL_001a:
			InspectStepViewModel inspectStepViewModel = _003C_003E4__this;
			_ = 0;
			num = ((!RmTqQGKBrbUqqeVhm8FI()) ? 4 : 0);
			goto IL_061d;
			IL_061d:
			int num2 = default;
			TaskAwaiter awaiter = default;
			int previousIndex = default;
			int nextIndex = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (FnGIPOKBPuwIdpRwq847())
					{
					}
					continue;
				case 1:
					num2 = _003C_003E1__state;
					num = 6;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003CnextCurrentSnippet_003E5__2 = null;
							num3 = 2;
							break;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 16;
							break;
						case 3:
							awaiter = _003C_003Eu__1;
							num3 = 33;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 27;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 23;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 37;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 36:
								awaiter.GetResult();
								num3 = 8;
								continue;
							case 34:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 19;
									continue;
								}
								goto case 14;
							case 33:
								_003C_003Eu__1 = default;
								num3 = 41;
								continue;
							case 26:
								if (inspectStepViewModel.CurrentSnippet == null && _003CnextCurrentSnippet_003E5__2 != null)
								{
									awaiter = oNcCw5KBZfg77xLOxEPo(inspectStepViewModel.SetCurrentSnippet(_003CnextCurrentSnippet_003E5__2));
									if (awaiter.IsCompleted)
									{
										break;
									}
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 11;
								}
								goto end_IL_0458;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 39;
								continue;
							case 14:
								awaiter.GetResult();
								num3 = 32;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 35;
								continue;
							case 0:
								return;
							case 8:
								awaiter = oNcCw5KBZfg77xLOxEPo(inspectStepViewModel.FireSnippetRemove(new SnippetRemoveEventArgs((CvsCellCollection)kKjyevKBGKcOqhgPkNE4(aQ7vf8KBbm1SgvnoeC3J(Naky64KBBw3g5ObiG2RS(inspectStepViewModel))), tool)));
								num3 = 12;
								continue;
							case 5:
							case 31:
								awaiter = oNcCw5KBZfg77xLOxEPo(inspectStepViewModel.SetCurrentSnippet(null));
								num3 = 6;
								continue;
							case 35:
								return;
							case 39:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								if (true)
								{
									continue;
								}
								return;
							case 3:
								return;
							case 24:
							{
								int index = inspectStepViewModel.Snippets.IndexOf(tool);
								inspectStepViewModel.GetSnippetSiblingIndices(index, out previousIndex, out nextIndex);
								num3 = 22;
								if (!FnGIPOKBPuwIdpRwq847())
								{
									continue;
								}
								goto case 19;
							}
							case 19:
								num2 = (_003C_003E1__state = 3);
								num3 = 13;
								if (RmTqQGKBrbUqqeVhm8FI())
								{
									continue;
								}
								goto case 12;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 20;
									if (RmTqQGKBrbUqqeVhm8FI())
									{
										continue;
									}
									goto case 6;
								}
								goto case 1;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 36;
							case 1:
							case 18:
								awaiter.GetResult();
								num3 = 17;
								continue;
							case 4:
								_003CnextCurrentSnippet_003E5__2 = inspectStepViewModel.Snippets[previousIndex];
								goto case 5;
							case 38:
								return;
							case 28:
								if (previousIndex <= -1)
								{
									goto case 5;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 22;
							case 22:
								if (nextIndex >= 0)
								{
									_003CnextCurrentSnippet_003E5__2 = inspectStepViewModel.Snippets[nextIndex];
									_ = 1;
									if (!FnGIPOKBPuwIdpRwq847())
									{
										num3 = 31;
										if (1 == 0)
										{
											return;
										}
									}
									else
									{
										num3 = 1;
									}
								}
								else
								{
									num3 = 28;
								}
								continue;
							case 23:
								num2 = (_003C_003E1__state = -1);
								num3 = 36;
								if (RmTqQGKBrbUqqeVhm8FI())
								{
									continue;
								}
								goto case 25;
							case 25:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									return;
								}
								goto case 29;
							case 21:
								return;
							case 37:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 29;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 2);
								num3 = 40;
								if (0 == 0)
								{
									continue;
								}
								goto case 32;
							case 32:
								inspectStepViewModel.RefreshPotentialDependencies(null);
								num3 = 30;
								continue;
							case 2:
								if (inspectStepViewModel.CurrentSnippet == tool)
								{
									num3 = 24;
									continue;
								}
								goto case 8;
							case 27:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							case 29:
								awaiter.GetResult();
								awaiter = oNcCw5KBZfg77xLOxEPo(inspectStepViewModel.Ip9AfAmPAi());
								num3 = 7;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 38;
								continue;
							case 17:
								awaiter = oNcCw5KBZfg77xLOxEPo(inspectStepViewModel.RemoveSnippetInternal(tool));
								goto case 25;
							default:
								num3 = 25;
								if (!FnGIPOKBPuwIdpRwq847())
								{
									continue;
								}
								goto case 16;
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 42;
								if (true)
								{
									continue;
								}
								goto case 40;
							case 40:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 21;
								if (true)
								{
									continue;
								}
								goto case 41;
							case 41:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 20:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 30:
								if (inspectStepViewModel.Snippets.Any())
								{
									oSpjLUKBoao28SG9omME(Naky64KBBw3g5ObiG2RS(inspectStepViewModel), true, true);
									num3 = 26;
									continue;
								}
								goto case 26;
							case 15:
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter;
								num3 = 34;
								if (RmTqQGKBrbUqqeVhm8FI())
								{
									continue;
								}
								break;
							case 42:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0458:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnextCurrentSnippet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003CnextCurrentSnippet_003E5__2 = null;
					num = 5;
					if (true)
					{
						continue;
					}
					return;
				case 7:
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
		internal static TaskAwaiter oNcCw5KBZfg77xLOxEPo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Naky64KBBw3g5ObiG2RS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aQ7vf8KBbm1SgvnoeC3J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kKjyevKBGKcOqhgPkNE4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oSpjLUKBoao28SG9omME(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RmTqQGKBrbUqqeVhm8FI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FnGIPOKBPuwIdpRwq847()
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
	private struct _003CSnippet_CopyAsync_003Ed__171 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object sender;

		public InspectStepViewModel _003C_003E4__this;

		private EzTool _003Ctool_003E5__2;

		private ITopLevelProgressableOperation _003C_003E7__wrap2;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					inspectStepViewModel = _003C_003E4__this;
					uuTtHaKBSBZCZFLlaPvG();
					if (!G6RWn1KBkrU5vFM68x8i())
					{
						num = 0;
						break;
					}
					num = 6;
					if (true)
					{
						break;
					}
					return;
				default:
					_003Ctool_003E5__2 = null;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 0:
				case 2:
					try
					{
						if (num2 == 0)
						{
							goto IL_00c0;
						}
						_003Ctool_003E5__2 = sender as EzTool;
						if (_003Ctool_003E5__2 != null)
						{
							_003C_003E7__wrap2 = inspectStepViewModel.OperationProgressManager.StartBlockingOperation((string)Yw3QogKBq3x9ObURiaEd(Resources.gCMZ2dpbtf(), c9RG3oKB84vTyEn2ZG1C(_003Ctool_003E5__2)));
							goto IL_00c0;
						}
						goto end_IL_0072;
						IL_00c0:
						try
						{
							TaskAwaiter<byte[]> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = inspectStepViewModel.itEAIEepPY(_003Ctool_003E5__2).GetAwaiter();
								num3 = 0;
								if (false)
								{
									goto IL_00e4;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
							}
							goto IL_0130;
							IL_0130:
							while (true)
							{
								switch (num3)
								{
								case 9:
									break;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									goto default;
								default:
									uuTtHaKBSBZCZFLlaPvG();
									num3 = (G6RWn1KBkrU5vFM68x8i() ? 10 : 2);
									continue;
								case 7:
								case 10:
									inspectStepViewModel.CopyTool = result;
									num3 = 9;
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 4;
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
								case 5:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 4:
									result = awaiter.GetResult();
									goto case 7;
								case 11:
									inspectStepViewModel.f6cAiOYCKR = 0;
									goto end_IL_0130;
								}
								goto IL_00e4;
								continue;
								end_IL_0130:
								break;
							}
							goto end_IL_00c0;
							IL_00e4:
							inspectStepViewModel.Q4ZAqKq0Iy = XdcUJxKBEcVqPLVOGPME(_003Ctool_003E5__2);
							num3 = 11;
							goto IL_0130;
							end_IL_00c0:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap2 != null)
							{
								UZWTMlKBpKU2suEBlThn(_003C_003E7__wrap2);
							}
						}
						_003C_003E7__wrap2 = null;
						end_IL_0072:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static object c9RG3oKB84vTyEn2ZG1C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yw3QogKBq3x9ObURiaEd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange XdcUJxKBEcVqPLVOGPME(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UZWTMlKBpKU2suEBlThn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uuTtHaKBSBZCZFLlaPvG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G6RWn1KBkrU5vFM68x8i()
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
	private struct _003CCopyToolData_003Ed__172 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public EzTool tool;

		public InspectStepViewModel _003C_003E4__this;

		private List<(string, string)> _003CremovedLinks_003E5__2;

		private byte[] _003Ccopy_003E5__3;

		private IEnumerator<CellViewModel> _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		private List<(string, string)>.Enumerator _003C_003E7__wrap4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oyjXWJKB9gwXdeuxlvZr();
			int num = ((!uubKIBKBXLaksRxnxSih()) ? 3 : 4);
			TaskAwaiter awaiter2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			string text = default;
			CvsCell cvsCell = default;
			int num2 = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003Ccopy_003E5__3 = null;
					num = 5;
					break;
				case 7:
					_003CremovedLinks_003E5__2 = null;
					goto case 2;
				default:
					num = 2;
					break;
				case 6:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						byte[] result2;
						switch (num2)
						{
						default:
							_003CremovedLinks_003E5__2 = new List<(string, string)>();
							_003C_003E7__wrap3 = tool.Properties.GetEnumerator();
							goto case 0;
						case 0:
							try
							{
								if (num2 != 0)
								{
									goto IL_026d;
								}
								awaiter2 = _003C_003Eu__1;
								int num3 = 11;
								goto IL_0123;
								IL_0123:
								while (true)
								{
									switch (num3)
									{
									default:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 10;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
										_003C_003Eu__1 = awaiter2;
										goto default;
									case 10:
										return;
									case 0:
									case 8:
									{
										CvsCellLocation cvsCellLocation = N83agtKB37OfiSPfBoYs(((EasyBuilderApplicationViewModel)KC1oZTKB7U64iUQhvavm(inspectStepViewModel)).PropertyLinks, text);
										cvsCell = (CvsCell)rITAulKBA1sK1WX4B0M0(WkrrdSKBCmYOBBlUeeei(pTumE5KB6HpyviaeiqAQ(PmMPbSKBjy2Tv2EXPkoh(inspectStepViewModel))), cvsCellLocation);
										num3 = 9;
										continue;
									}
									case 2:
										num2 = (_003C_003E1__state = 0);
										num3 = 3;
										continue;
									case 4:
										awaiter2.GetResult();
										num3 = 13;
										if (true)
										{
											continue;
										}
										goto case 12;
									case 12:
										_003CremovedLinks_003E5__2.Add((text, (string)UIs29VKBRGm6qygZWytD(cvsCell)));
										awaiter2 = EStYMaKBToks82yLJCY1(Kq40VbKBWsmnZAMTpruR(((EasyBuilderApplicationViewModel)KC1oZTKB7U64iUQhvavm(inspectStepViewModel)).PropertyLinks, text));
										num3 = 5;
										continue;
									case 5:
										if (!awaiter2.IsCompleted)
										{
											num3 = 2;
											continue;
										}
										goto case 4;
									case 9:
										if (cvsCell != null)
										{
											num3 = 12;
											continue;
										}
										break;
									case 11:
										_003C_003Eu__1 = default;
										num3 = 1;
										continue;
									case 1:
										num2 = (_003C_003E1__state = -1);
										num3 = 4;
										continue;
									case 13:
										break;
									}
									break;
								}
								goto IL_026d;
								IL_026d:
								if (ouLk5SKBy9hacBPyJxDl(_003C_003E7__wrap3))
								{
									text = (string)vpp3a7KB4fraHOnkYW9K(_003C_003E7__wrap3.Current);
									uubKIBKBXLaksRxnxSih();
									num3 = (oyjXWJKB9gwXdeuxlvZr() ? 7 : 8);
									goto IL_0123;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap3 != null)
								{
									mhCH4sKB0PoE0F7frbnm(_003C_003E7__wrap3);
								}
							}
							_003C_003E7__wrap3 = null;
							awaiter = ((CvsInSight)PmMPbSKBjy2Tv2EXPkoh(inspectStepViewModel)).UndoHandler.SendCopyAsync(e1ThMhKBFgEkoxy5m4bm(tool)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0316;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0316;
						case 2:
							break;
							IL_0316:
							result2 = awaiter.GetResult();
							_003Ccopy_003E5__3 = result2;
							_003C_003E7__wrap4 = _003CremovedLinks_003E5__2.GetEnumerator();
							break;
						}
						try
						{
							int num4;
							if (num2 != 2)
							{
								num4 = 2;
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num4 = 6;
							}
							while (true)
							{
								switch (num4)
								{
								case 9:
									num2 = (_003C_003E1__state = 2);
									num4 = 10;
									continue;
								case 6:
									_003C_003Eu__1 = default;
									num4 = 1;
									continue;
								case 0:
									if (!awaiter2.IsCompleted)
									{
										num4 = 9;
										if (uubKIBKBXLaksRxnxSih())
										{
											continue;
										}
										return;
									}
									break;
								case 7:
									return;
								case 1:
									num2 = (_003C_003E1__state = -1);
									break;
								case 3:
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								default:
									num4 = 7;
									continue;
								case 10:
									_003C_003Eu__1 = awaiter2;
									oyjXWJKB9gwXdeuxlvZr();
									if (!uubKIBKBXLaksRxnxSih())
									{
										num4 = 5;
										if (uubKIBKBXLaksRxnxSih())
										{
											continue;
										}
										goto case 3;
									}
									num4 = 3;
									continue;
								case 5:
								case 8:
									break;
								case 2:
								case 11:
									if (_003C_003E7__wrap4.MoveNext())
									{
										(string, string) current = _003C_003E7__wrap4.Current;
										string item = current.Item1;
										string item2 = current.Item2;
										awaiter2 = EStYMaKBToks82yLJCY1(l4pIUmKBY7iiPGj9tE1D(gH4Vl4KBMQLHdwPunxa4(inspectStepViewModel.AppViewModel), item, item2));
										num4 = 0;
										if (uubKIBKBXLaksRxnxSih())
										{
											continue;
										}
										goto case 1;
									}
									goto end_IL_042f;
								}
								awaiter2.GetResult();
								num4 = 11;
								continue;
								end_IL_042f:
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap4/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap4 = default;
						result = _003Ccopy_003E5__3;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CremovedLinks_003E5__2 = null;
						_003Ccopy_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 7;
					break;
				case 1:
				case 3:
					inspectStepViewModel = _003C_003E4__this;
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 8;
					break;
				case 8:
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
		internal static object vpp3a7KB4fraHOnkYW9K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KC1oZTKB7U64iUQhvavm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation N83agtKB37OfiSPfBoYs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).GetSourceCellLocation((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PmMPbSKBjy2Tv2EXPkoh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pTumE5KB6HpyviaeiqAQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WkrrdSKBCmYOBBlUeeei(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rITAulKBA1sK1WX4B0M0(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UIs29VKBRGm6qygZWytD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Kq40VbKBWsmnZAMTpruR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EStYMaKBToks82yLJCY1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ouLk5SKBy9hacBPyJxDl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mhCH4sKB0PoE0F7frbnm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange e1ThMhKBFgEkoxy5m4bm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gH4Vl4KBMQLHdwPunxa4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).PropertyLinks;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l4pIUmKBY7iiPGj9tE1D(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AddLink((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uubKIBKBXLaksRxnxSih()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oyjXWJKB9gwXdeuxlvZr()
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
	private struct _003CRemoveAllSnippets_003Ed__173 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public bool jobLoading;

		private int _003Ci_003E5__2;

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
			TaskAwaiter awaiter = default;
			InspectStepViewModel inspectStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!UhltJAKBH20V1iNcfTTo())
					{
						num = 5;
						if (OhflfeKBU8QeH8A9rvCD())
						{
							break;
						}
						goto case 0;
					}
					num = 0;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								if (!UhltJAKBH20V1iNcfTTo())
								{
									num3 = 14;
									if (1 == 0)
									{
										goto IL_0060;
									}
								}
								else
								{
									num3 = 19;
									if (false)
									{
										goto IL_0255;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 16;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (!OhflfeKBU8QeH8A9rvCD())
							{
								goto IL_01b1;
							}
						}
						goto IL_0273;
						IL_0273:
						while (true)
						{
							switch (num3)
							{
							case 11:
								break;
							case 21:
								if (!jobLoading)
								{
									num3 = 10;
									continue;
								}
								goto case 17;
							case 7:
								inspectStepViewModel.MainViewModel = null;
								num3 = 22;
								continue;
							case 1:
								return;
							case 16:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00d1;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 13:
							case 19:
								num2 = (_003C_003E1__state = 1);
								num3 = 9;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 18;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 17:
								inspectStepViewModel.JobPassFail = null;
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 14:
								_003Ci_003E5__2 = inspectStepViewModel.Snippets.Count - 1;
								num3 = 20;
								continue;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 18:
								return;
							case 8:
								goto IL_01b1;
							case 6:
								goto IL_01c6;
							case 10:
								awaiter = inspectStepViewModel.SetCurrentSnippet(null).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_00d1;
								}
								goto case 13;
							case 3:
								goto IL_0234;
							case 12:
							{
								int num4 = _003Ci_003E5__2 - 1;
								_003Ci_003E5__2 = num4;
								goto IL_0255;
							}
							case 20:
								goto IL_0255;
							default:
								num3 = 8;
								continue;
							case 22:
								{
									inspectStepViewModel.UpdateShowInSightDisplay();
									goto end_IL_003b;
								}
								IL_00d1:
								awaiter.GetResult();
								num3 = 17;
								if (!UhltJAKBH20V1iNcfTTo())
								{
									continue;
								}
								goto case 4;
							}
							break;
						}
						goto IL_0060;
						IL_0234:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						goto IL_0273;
						IL_01b1:
						inspectStepViewModel.Snippets.Clear();
						num3 = 21;
						goto IL_0273;
						IL_0255:
						if (_003Ci_003E5__2 > -1)
						{
							awaiter = inspectStepViewModel.RemoveSnippetAt(_003Ci_003E5__2, removingAll: true).GetAwaiter();
							num3 = 11;
							if (UhltJAKBH20V1iNcfTTo())
							{
								goto IL_0234;
							}
							goto IL_0273;
						}
						goto IL_01b1;
						IL_01cf:
						awaiter.GetResult();
						num3 = 12;
						goto IL_0273;
						IL_01c6:
						num2 = (_003C_003E1__state = -1);
						goto IL_01cf;
						IL_0060:
						if (awaiter.IsCompleted)
						{
							goto IL_01cf;
						}
						num3 = 4;
						if (UhltJAKBH20V1iNcfTTo())
						{
						}
						goto IL_0273;
						end_IL_003b:;
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
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (OhflfeKBU8QeH8A9rvCD())
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					goto case 0;
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
		internal static bool OhflfeKBU8QeH8A9rvCD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UhltJAKBH20V1iNcfTTo()
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
	private struct _003CMoveTool_003Ed__174 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int sourceIndex;

		public InspectStepViewModel _003C_003E4__this;

		public EzTool source;

		public int insertIndex;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (PnhSsOKBxEQt6VSgGcQ8())
			{
				num = 3;
				if (lgWgUrKBmeQqTCFKqZWg())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_0281;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0281;
			IL_0281:
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			L3xsfUdIkfTQrRcPb8 l3xsfUdIkfTQrRcPb = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 2;
							goto IL_00c3;
						}
						if ((uint)sourceIndex < (uint)YyGOc7KBQF6Av0yG5tbo(inspectStepViewModel.Snippets))
						{
							num3 = 0;
							goto IL_00c3;
						}
						goto end_IL_0050;
						IL_00c3:
						while (true)
						{
							switch (num3)
							{
							case 8:
								insertIndex = 0;
								num3 = 11;
								if (!lgWgUrKBmeQqTCFKqZWg())
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 11:
								if (sourceIndex != insertIndex)
								{
									goto case 12;
								}
								goto end_IL_00c3;
							default:
								num3 = 12;
								continue;
							case 6:
								return;
							case 10:
								return;
							case 7:
								insertIndex = YyGOc7KBQF6Av0yG5tbo(inspectStepViewModel.Snippets) - 1;
								_ = 1;
								num3 = (lgWgUrKBmeQqTCFKqZWg() ? 6 : 9);
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 1:
								if (insertIndex >= YyGOc7KBQF6Av0yG5tbo(inspectStepViewModel.Snippets))
								{
									num3 = 7;
									continue;
								}
								goto case 3;
							case 13:
								awaiter = tKXtFoKBt0Axoh0GXUkF(iqnX7tKBh5C2oNeEyDhj(KhZe8xKBut9cEVXjBIbe(Epk8NXKB1gfXCYbZvyPc(inspectStepViewModel)), l3xsfUdIkfTQrRcPb));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								}
								break;
							case 12:
								l3xsfUdIkfTQrRcPb = new L3xsfUdIkfTQrRcPb8(inspectStepViewModel, sourceIndex, insertIndex, (string)WGHwY6KBcKu9YpMe0BD7(b0N5VPKBNpb1o3KrpAE2(), eBvO7eKB2CRqbT94Z1hN(source)));
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
							case 9:
								if (insertIndex >= 0)
								{
									goto case 11;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (source != null)
								{
									num3 = 1;
									continue;
								}
								goto end_IL_00c3;
							case 14:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00c3:
							break;
						}
						end_IL_0050:;
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
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static int YyGOc7KBQF6Av0yG5tbo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<EzSnippet>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b0N5VPKBNpb1o3KrpAE2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.WDArmTU1K1();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eBvO7eKB2CRqbT94Z1hN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WGHwY6KBcKu9YpMe0BD7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Epk8NXKB1gfXCYbZvyPc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KhZe8xKBut9cEVXjBIbe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iqnX7tKBh5C2oNeEyDhj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tKXtFoKBt0Axoh0GXUkF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PnhSsOKBxEQt6VSgGcQ8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lgWgUrKBmeQqTCFKqZWg()
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
	private struct _003CUpdateJobPassFail_003Ed__181 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yKuhHLKBzHPBifxC0C9L();
			int num;
			if (!xkY8JSKbL5aaR1T5IZGu())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0386;
			IL_03d9:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0386;
			IL_0386:
			int num2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 1;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					break;
				case 1:
					goto IL_03d9;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				if ((uint)num2 > 2u)
				{
					_003C_003E7__wrap1 = CvsTraceEzb.Info.TraceFunction((string)eZYZ9iKbKN2A1SK8if3v(48696));
				}
				try
				{
					TaskAwaiter<object> awaiter;
					TaskAwaiter<CvsCogSheetResult> awaiter2;
					switch (num2)
					{
					default:
						if (inspectStepViewModel.JobPassFail != null)
						{
							StringBuilder stringBuilder = new StringBuilder();
							IEnumerator<EzTool> enumerator = inspectStepViewModel.Tools.GetEnumerator();
							try
							{
								CvsCellLocation cellLocation = default;
								while (enumerator.MoveNext())
								{
									EzTool current = enumerator.Current;
									int num3 = 0;
									while (true)
									{
										switch (num3)
										{
										case 0:
											if (ypmBM0Kb5nGaWmTkm6yp(current) != null)
											{
												num3 = 1;
												continue;
											}
											break;
										case 3:
										case 6:
											eWv2KIKbwB4d6Q3001D9(stringBuilder, eZYZ9iKbKN2A1SK8if3v(18708));
											goto case 2;
										case 5:
											if (stringBuilder.Length > 0)
											{
												goto default;
											}
											goto case 2;
										default:
											_ = 1;
											num3 = ((!xkY8JSKbL5aaR1T5IZGu()) ? 6 : 2);
											continue;
										case 1:
											cellLocation = current.JobPass.CellLocation;
											num3 = 5;
											continue;
										case 2:
										case 4:
											eWv2KIKbwB4d6Q3001D9(stringBuilder, cellLocation.ToString(absoluteRow: true, absoluteColumn: true));
											num3 = 7;
											continue;
										case 7:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									YZVkytKbJ85afF47qMXK(enumerator);
								}
							}
							if (stringBuilder.ToString().Length == 0)
							{
								awaiter = ((CvsCogSocketSheet)liqjS3KbOd2A4aa3BiPS(Tj9jsSKbehil3C8fG2kX(RGrjEtKbaKEAM72wJ3IO(inspectStepViewModel)))).PutCellExpressionAsync(H3tIX0KbDrDCPhERAVCf(wEG71JKbIXjL7rls2rSp(inspectStepViewModel.JobPassFail)), (string)eZYZ9iKbKN2A1SK8if3v(21668)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_020b;
							}
							awaiter = ((CvsCogSocketSheet)liqjS3KbOd2A4aa3BiPS(Tj9jsSKbehil3C8fG2kX(RGrjEtKbaKEAM72wJ3IO(inspectStepViewModel)))).PutCellExpressionAsync(H3tIX0KbDrDCPhERAVCf(wEG71JKbIXjL7rls2rSp(inspectStepViewModel.JobPassFail)), stringBuilder.ToString()).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0309;
						}
						goto end_IL_004c;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_020b;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_027d;
					case 2:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0309;
						}
						IL_027d:
						awaiter2.GetResult();
						break;
						IL_020b:
						awaiter.GetResult();
						awaiter2 = ((CvsCogSocketSheet)liqjS3KbOd2A4aa3BiPS(inspectStepViewModel.InSight.CogSocket)).RunAsync(false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_027d;
						IL_0309:
						awaiter.GetResult();
						break;
					}
					kQkchlKbnnUFK9XbRbvs(R44ODJKbirmRKPvmMULm(inspectStepViewModel.JobPassFail));
					end_IL_004c:;
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						YZVkytKbJ85afF47qMXK(_003C_003E7__wrap1);
					}
				}
				_003C_003E7__wrap1 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_03d9;
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
		internal static object eZYZ9iKbKN2A1SK8if3v(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ypmBM0Kb5nGaWmTkm6yp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).JobPass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eWv2KIKbwB4d6Q3001D9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StringBuilder)P_0).Append((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YZVkytKbJ85afF47qMXK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RGrjEtKbaKEAM72wJ3IO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Tj9jsSKbehil3C8fG2kX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object liqjS3KbOd2A4aa3BiPS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wEG71JKbIXjL7rls2rSp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JobPassFail)P_0).ToolsPass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation H3tIX0KbDrDCPhERAVCf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R44ODJKbirmRKPvmMULm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JobPassFail)P_0).ExecutionTime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kQkchlKbnnUFK9XbRbvs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((JobExecutionTimeViewModel)P_0).Reset();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yKuhHLKBzHPBifxC0C9L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xkY8JSKbL5aaR1T5IZGu()
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
	private struct _003CSendGraphic_003Ed__182 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsEditableDisplayGraphic editableGraphic;

		public CvsInSightDisplay inSightDisplay;

		public InspectStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WHYGsaKbV3xZc2F23hFZ();
			int num = (ihwUdKKbfSpRps6V8cCK() ? 1 : 3);
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			gvP0xAP1E5gtN932no gvP0xAP1E5gtN932no2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 13;
								if (false)
								{
									goto IL_0058;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
							goto IL_011d;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_020a;
						IL_006e:
						gvP0xAP1E5gtN932no2 = GKAuZIKblZVuCtEFuXGK(editableGraphic) as gvP0xAP1E5gtN932no;
						if (gvP0xAP1E5gtN932no2 != null)
						{
							num3 = 11;
						}
						else
						{
							awaiter = ((Task)gqFGWwKbvYQMYvRFUknN(DNSnqiKbsm06Gm9jlC92(inspectStepViewModel), editableGraphic)).GetAwaiter();
							num3 = 5;
							if (ihwUdKKbfSpRps6V8cCK())
							{
							}
						}
						goto IL_011d;
						IL_0058:
						editableGraphic = (CvsEditableDisplayGraphic)cPpftkKbdA4NZkFTkoPV(editableGraphic);
						goto IL_006e;
						IL_011d:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 17:
								break;
							case 13:
								goto IL_008f;
							case 11:
								awaiter = XKcP2JKbgsUir7OYoO1p(gvP0xAP1E5gtN932no2.Send(_0020: true, inSightDisplay));
								num3 = 9;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 15:
								return;
							default:
								num3 = 7;
								if (WHYGsaKbV3xZc2F23hFZ())
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 16;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 1);
								num3 = 6;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 14:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 18;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 7:
								goto IL_020a;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 10;
							case 9:
								if (awaiter.IsCompleted)
								{
									goto IL_020a;
								}
								num3 = 3;
								if (WHYGsaKbV3xZc2F23hFZ())
								{
									continue;
								}
								goto case 10;
							case 10:
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 18;
							case 18:
								awaiter.GetResult();
								goto end_IL_003f;
							}
							break;
							IL_008f:
							if (cPpftkKbdA4NZkFTkoPV(editableGraphic) != null)
							{
								_ = 0;
								num3 = ((!WHYGsaKbV3xZc2F23hFZ()) ? 10 : 17);
								continue;
							}
							goto IL_006e;
						}
						goto IL_0058;
						IL_020a:
						awaiter.GetResult();
						end_IL_003f:;
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
					if (WHYGsaKbV3xZc2F23hFZ())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 4:
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
		internal static object cPpftkKbdA4NZkFTkoPV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GKAuZIKblZVuCtEFuXGK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Tag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XKcP2JKbgsUir7OYoO1p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DNSnqiKbsm06Gm9jlC92(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gqFGWwKbvYQMYvRFUknN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, (CvsEditableDisplayGraphic)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WHYGsaKbV3xZc2F23hFZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ihwUdKKbfSpRps6V8cCK()
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
	private struct _003CSendGraphic_003Ed__184 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel _003C_003E4__this;

		public CvsCellLocation loc;

		public CvsEditableDisplayGraphic editableGraphic;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!fD7G6YKbrLGbbFemZu4M()) ? 4 : 3);
			InspectStepViewModel inspectStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Mm2ueEKbBoJfDhi3jE39(EditableGraphicHelper.SendGraphicAsync((CvsInSight)H5R7PfKbZyaWsiFVqTTc(inspectStepViewModel), loc, editableGraphic));
							_ = 0;
							if (fD7G6YKbrLGbbFemZu4M())
							{
								num3 = 2;
							}
							else
							{
								num3 = 1;
								if (!fD7G6YKbrLGbbFemZu4M())
								{
									goto IL_013c;
								}
							}
							goto IL_00d0;
						}
						awaiter = _003C_003Eu__1;
						goto IL_014f;
						IL_00d0:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 9;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 3:
								return;
							case 6:
								break;
							case 1:
							case 5:
								goto IL_014f;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							break;
						}
						goto IL_013c;
						IL_014f:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_00d0;
						IL_013c:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						goto IL_00d0;
						end_IL_0061:;
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
		internal static object H5R7PfKbZyaWsiFVqTTc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Mm2ueEKbBoJfDhi3jE39(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fD7G6YKbrLGbbFemZu4M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P9E6F0KbPmqdOvX5WaKc()
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
	private struct _003CSnippet_RemoveAsync_003Ed__187 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object sender;

		public InspectStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bAXiGQKbbsBcn9mGDiNF();
			int num = (YHKPKwKbGZfinmpZUSqH() ? 1 : 5);
			int num2 = default;
			EzSnippet ezSnippet = default;
			TaskAwaiter awaiter = default;
			IUndoAction undoAction = default;
			InspectStepViewModel inspectStepViewModel = default;
			do
			{
				IL_0206:
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					goto IL_0206;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezSnippet = sender as EzSnippet;
							num3 = 1;
							goto IL_013b;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0081;
						IL_0081:
						_003C_003Eu__1 = default;
						num3 = 10;
						goto IL_013b;
						IL_013b:
						while (true)
						{
							switch (num3)
							{
							case 5:
								undoAction = inspectStepViewModel.U0qAcS9NOW(ezSnippet.Name);
								num3 = 4;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 0:
							case 8:
								break;
							case 4:
							{
								UndoActionBlockingProgressWrapper action = new UndoActionBlockingProgressWrapper(inspectStepViewModel.OperationProgressManager, undoAction, (string)As23mDKbSShiL7srkGwU(Resources.nuY9CivFDK(), ipWl1LKbobWpmIVdZ9bx(ezSnippet)), (string)As23mDKbSShiL7srkGwU(KjpZfEKbkMZRewih8fhC(), ezSnippet.Name));
								awaiter = EWYAgCKb8c6hdA74H4nm(inspectStepViewModel.InSight.UndoHandler.AddUndo(action));
								num3 = 3;
								continue;
							}
							case 7:
								return;
							case 2:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 12;
							case 9:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = ((!YHKPKwKbGZfinmpZUSqH()) ? 2 : 0);
								continue;
							case 1:
								if (ezSnippet != null)
								{
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto case 12;
								}
								goto end_IL_013b;
							case 12:
								awaiter.GetResult();
								goto end_IL_013b;
							}
							goto IL_0081;
							continue;
							end_IL_013b:
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
					break;
				default:
					num = 3;
					goto IL_0206;
				case 4:
					inspectStepViewModel = _003C_003E4__this;
					goto case 1;
				case 3:
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
		internal static object ipWl1LKbobWpmIVdZ9bx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object As23mDKbSShiL7srkGwU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KjpZfEKbkMZRewih8fhC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.coRG0InpdO();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EWYAgCKb8c6hdA74H4nm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAXiGQKbbsBcn9mGDiNF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YHKPKwKbGZfinmpZUSqH()
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
	private struct _003CPublishCellTags_003Ed__189 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight insight;

		public CvsCellRange selectedRange;

		public InspectStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_03a8;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 1;
			if (!NBF7RDKbq1nZnm03Mj7F())
			{
				goto IL_0031;
			}
			goto IL_03a8;
			IL_03a8:
			CvsCell cvsCell = default;
			string text = default;
			InspectStepViewModel inspectStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					goto IL_0031;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							HashSet<string> hashSet = new HashSet<string>();
							List<CvsCellInfo> list = new List<CvsCellInfo>();
							IEnumerator<INamedOperand> enumerator = ((IEnumerable<INamedOperand>)((CvsCellCollection)KKPu6XKbXrZ2ToyNgsm6(nuIbG8Kbp8wqrsBpxcRv(insight))).CreateCellInfoCollection()).GetEnumerator();
							try
							{
								while (I710ndKb4NacN60wKQto(enumerator))
								{
									CvsCellInfo cvsCellInfo = (CvsCellInfo)enumerator.Current;
									TOr82sKbE71cVOl5Flog();
									int num3;
									if (NBF7RDKbq1nZnm03Mj7F())
									{
										num3 = 2;
										if (1 == 0)
										{
											goto IL_00c4;
										}
									}
									else
									{
										num3 = 3;
										if (1 == 0)
										{
											continue;
										}
									}
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										continue;
									}
									goto IL_00c4;
									IL_00c4:
									hashSet.Add((string)SPmlq8Kb90ci4wHYNtT9(cvsCellInfo));
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									Pk72GUKb7oIUn3diIMAR(enumerator);
								}
							}
							IEnumerator<CvsCellLocation> enumerator2 = selectedRange.GetEnumerator();
							try
							{
								while (I710ndKb4NacN60wKQto(enumerator2))
								{
									CvsCellLocation current = enumerator2.Current;
									NBF7RDKbq1nZnm03Mj7F();
									int num4 = (TOr82sKbE71cVOl5Flog() ? 9 : 2);
									while (true)
									{
										switch (num4)
										{
										case 5:
											if (W5Sb2pKbjyCc199CyY57(cvsCell))
											{
												num4 = 10;
												continue;
											}
											goto case 4;
										case 7:
											hashSet.Add(text);
											num4 = 6;
											if (NBF7RDKbq1nZnm03Mj7F())
											{
												continue;
											}
											goto case 6;
										case 6:
											list.Add(new CvsCellInfo(current, text, cvsCell.Input || AHjFhoKb65gffk5xfTBV(cvsCell), output: true));
											num4 = 12;
											continue;
										case 10:
											if (!AHjFhoKb65gffk5xfTBV(cvsCell))
											{
												break;
											}
											goto case 4;
										case 1:
											if (!gujMgWKb3gu8VMBnkKxZ(cvsCell))
											{
												num4 = 5;
												continue;
											}
											break;
										case 4:
										case 9:
											text = cvsCell.Name;
											goto case 3;
										default:
											num4 = 3;
											continue;
										case 8:
											if (HMiqL9KbAjJyrGKv0KU9(cvsCell))
											{
												num4 = 11;
												if (true)
												{
													continue;
												}
												goto case 0;
											}
											goto IL_02aa;
										case 0:
										case 2:
											cvsCell = ((CvsCellCollection)KKPu6XKbXrZ2ToyNgsm6(nuIbG8Kbp8wqrsBpxcRv(insight)))[current];
											num4 = 1;
											continue;
										case 11:
											text = inspectStepViewModel.yaYAQONBAh(hashSet, cvsCell.GetOutputBaseName(insight));
											goto IL_02aa;
										case 3:
											if (jmSVnNKbCUIZPPGaXC1j(text))
											{
												num4 = 8;
												continue;
											}
											break;
										case 12:
											break;
											IL_02aa:
											if (text != null)
											{
												num4 = 7;
												continue;
											}
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator2 != null)
								{
									Pk72GUKb7oIUn3diIMAR(enumerator2);
								}
							}
							awaiter = UJIcfhKbRkJwViiwtHGC(inspectStepViewModel.R2XAgO4Ykv(insight, list));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						awaiter.GetResult();
						AsD959KbWs1jDydMDrsO(insight, true, true);
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
				break;
			}
			goto IL_001a;
			IL_0031:
			inspectStepViewModel = _003C_003E4__this;
			NBF7RDKbq1nZnm03Mj7F();
			num = ((!TOr82sKbE71cVOl5Flog()) ? 5 : 0);
			goto IL_03a8;
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
		internal static object nuIbG8Kbp8wqrsBpxcRv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KKPu6XKbXrZ2ToyNgsm6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SPmlq8Kb90ci4wHYNtT9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I710ndKb4NacN60wKQto(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pk72GUKb7oIUn3diIMAR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gujMgWKb3gu8VMBnkKxZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W5Sb2pKbjyCc199CyY57(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Error;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AHjFhoKb65gffk5xfTBV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).IsAcquireImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jmSVnNKbCUIZPPGaXC1j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HMiqL9KbAjJyrGKv0KU9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CanBeOutputPin();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UJIcfhKbRkJwViiwtHGC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AsD959KbWs1jDydMDrsO(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NBF7RDKbq1nZnm03Mj7F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TOr82sKbE71cVOl5Flog()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass190_0
	{
		public HashSet<string> existingNames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass190_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UCMYJfKb0psPWeGdGNVy();
			HdkMTHKbFryOkHrCk1S6(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetUniqueTagName_003Eb__0(string name)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return existingNames.Contains(name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UCMYJfKb0psPWeGdGNVy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HdkMTHKbFryOkHrCk1S6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AkFYfxKbTReu2mZXBfoU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tY9CWPKbyfTgIdOdHS3U()
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
	private struct _003CWriteCellInfos_003Ed__192 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<CvsCellInfo> newInfos;

		public CvsInSight insight;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!PU1PnxKbMulPcg8v12kh())
			{
				goto IL_001e;
			}
			goto IL_01de;
			IL_001e:
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				if (num2 != 0)
				{
					List<Task> list = new List<Task>();
					List<CvsCellInfo>.Enumerator enumerator = newInfos.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CvsCellInfo current = enumerator.Current;
							_ = 1;
							int num3;
							if (!NbmZEuKbY804NUeShfar())
							{
								num3 = 2;
								if (false)
								{
									goto IL_005b;
								}
							}
							else
							{
								num3 = 3;
							}
							switch (num3)
							{
							case 0:
							case 2:
								break;
							default:
								continue;
							}
							goto IL_005b;
							IL_005b:
							list.Add(((CvsCogSocketSheet)OxLP2wKbHNvD2WtLtbIy(WpupgdKbUTB91v657fsR(insight))).ApplyCellAttributesAsync(new CvsCellRange(bOATfsKbxhRAY2wDkCiR(current)), new DictionaryEntry[3]
							{
								new DictionaryEntry(CdQUGaROfy7He9T0foW.KbIzwHEDLa(3900), AX1b1qKbmUedkeoCoOtf(current)),
								new DictionaryEntry(HAN43RKbQCurFSelEsBQ(3912), EJI7mrKbNFBxLoS94A7m(current)),
								new DictionaryEntry(HAN43RKbQCurFSelEsBQ(3926), KCWjojKb29YfCccUs6FV(current))
							}));
						}
					}
					finally
					{
						if (num2 < 0)
						{
							((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
						}
					}
					awaiter = oeGkMxKbcs3F34XFFSNk(Task.WhenAll(list));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
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
			goto IL_020b;
			IL_01de:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					goto IL_020b;
				case 4:
					goto IL_0220;
				case 5:
					return;
				}
				break;
				IL_0220:
				num2 = _003C_003E1__state;
				PU1PnxKbMulPcg8v12kh();
				num = ((!NbmZEuKbY804NUeShfar()) ? 3 : 0);
			}
			goto IL_001e;
			IL_020b:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_01de;
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
		internal static object WpupgdKbUTB91v657fsR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OxLP2wKbHNvD2WtLtbIy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation bOATfsKbxhRAY2wDkCiR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AX1b1qKbmUedkeoCoOtf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HAN43RKbQCurFSelEsBQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EJI7mrKbNFBxLoS94A7m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Input;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KCWjojKb29YfCccUs6FV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Output;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oeGkMxKbcs3F34XFFSNk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PU1PnxKbMulPcg8v12kh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NbmZEuKbY804NUeShfar()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass194_0
	{
		public EzTool tool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass194_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			np6fLsKbhnpO7smsngZu(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetConsumer_002ERemoveReferences_003Eb__0(EzTool t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (t is GroupTool groupTool)
			{
				return groupTool.Children.Contains(tool);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void np6fLsKbhnpO7smsngZu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gnSBTLKb1irvgdCPk4Ir()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FEiPgnKbuOA6ULicYZOc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass194_1
	{
		public InputStructureViewModel p;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass194_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			xUpfBCKGLKZ9pxq5SopP(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetConsumer_002ERemoveReferences_003Eb__1(SourceLink k)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Px7uF7KGwqVOQ2FEQ4Tf(vSVV3IKGKk6ZfuHTqNvg(k), up7SI5KG5o9PbIAnpb9k(p));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xUpfBCKGLKZ9pxq5SopP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s0YLw9KbtoY74VCFAGbb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TWF6rtKbzmJdyXqNwVrx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vSVV3IKGKk6ZfuHTqNvg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object up7SI5KG5o9PbIAnpb9k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InputStructureViewModel)P_0).CellExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Px7uF7KGwqVOQ2FEQ4Tf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__194 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetPreRemoveEventArgs e;

		public InspectStepViewModel _003C_003E4__this;

		private _003C_003Ec__DisplayClass194_0 _003C_003E8__1;

		private IEnumerator<EzTool> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private GroupTool _003Cgtool_003E5__3;

		private IEnumerator<InputStructureViewModel> _003C_003E7__wrap3;

		private SnippetPreRemoveEventArgs _003C_003E7__wrap4;

		private TaskAwaiter<IUndoAction> _003C_003Eu__3;

		private EzTool _003Ct_003E5__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			n9lApdKGaAO4SO3nvJ1J();
			int num = ((!Svci2eKGJ0EsmxH9NwgG()) ? 4 : 6);
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			InspectStepViewModel inspectStepViewModel = default;
			EzTool current = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<IUndoAction> awaiter3 = default;
			InputStructureViewModel current2 = default;
			int num2 = default;
			string item = default;
			SourceLink sourceLink = default;
			_003C_003Ec__DisplayClass194_1 obj = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						EzSnippet snippet;
						switch (num2)
						{
						default:
							_003C_003E8__1 = new _003C_003Ec__DisplayClass194_0();
							if (K3TUYXKGeOMjjytHHy4I(e) is GroupTool groupTool)
							{
								_003C_003E7__wrap1 = groupTool.Children.GetEnumerator();
								goto case 0;
							}
							goto IL_02fa;
						case 0:
						case 1:
							try
							{
								int num3;
								if (num2 != 0)
								{
									if (num2 != 1)
									{
										num3 = 0;
										if (!Svci2eKGJ0EsmxH9NwgG())
										{
											goto IL_00ab;
										}
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										num3 = 4;
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									Svci2eKGJ0EsmxH9NwgG();
									if (!n9lApdKGaAO4SO3nvJ1J())
									{
										num3 = 1;
									}
									else
									{
										num3 = 10;
										if (!Svci2eKGJ0EsmxH9NwgG())
										{
											goto IL_012a;
										}
									}
								}
								goto IL_016b;
								IL_016b:
								while (true)
								{
									switch (num3)
									{
									case 3:
										break;
									case 11:
										return;
									case 1:
									case 5:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_012a;
									case 6:
									case 10:
										goto IL_012a;
									case 7:
										awaiter2 = e.RefreshCells().GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											goto case 12;
										}
										goto case 8;
									default:
										num3 = 12;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 12;
									case 12:
										num2 = (_003C_003E1__state = 1);
										num3 = 2;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 9;
									case 9:
										num2 = (_003C_003E1__state = 0);
										num3 = 3;
										if (0 == 0)
										{
											continue;
										}
										goto case 0;
									case 2:
										_003C_003Eu__2 = awaiter2;
										num3 = 16;
										continue;
									case 8:
										awaiter2.GetResult();
										num3 = 17;
										continue;
									case 4:
										_003C_003Eu__2 = default;
										num3 = 13;
										if (true)
										{
											continue;
										}
										goto case 15;
									case 15:
										if (!awaiter.IsCompleted)
										{
											num3 = 9;
											continue;
										}
										goto IL_012a;
									case 13:
										num2 = (_003C_003E1__state = -1);
										num3 = 8;
										continue;
									case 14:
										awaiter = F1RBueKGDGRnmao0VVV5(IeHiFlKGIShy2skRlNZM(e, new DeleteToolUndoAction(inspectStepViewModel, (string)fy74ONKGOhhf0PfJP43n(current))));
										num3 = 15;
										if (n9lApdKGaAO4SO3nvJ1J())
										{
										}
										continue;
									case 16:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 11;
										continue;
									case 0:
									case 17:
										if (_003C_003E7__wrap1.MoveNext())
										{
											current = _003C_003E7__wrap1.Current;
											num3 = 14;
											continue;
										}
										goto end_IL_008e;
									}
									break;
								}
								goto IL_00ab;
								IL_012a:
								awaiter.GetResult();
								num3 = 7;
								goto IL_016b;
								IL_00ab:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
								end_IL_008e:;
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap1 != null)
								{
									f6a6RnKGi64PqDsFHdEU(_003C_003E7__wrap1);
								}
							}
							_003C_003E7__wrap1 = null;
							goto IL_02fa;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_03f0;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_048c;
						case 4:
						case 5:
							try
							{
								int num4;
								if (num2 != 4)
								{
									num4 = 19;
								}
								else
								{
									awaiter3 = _003C_003Eu__3;
									num4 = 7;
								}
								while (true)
								{
									switch (num4)
									{
									case 18:
										awaiter.GetResult();
										_003C_003E7__wrap4 = null;
										num4 = 20;
										continue;
									case 3:
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__3 = awaiter3;
										num4 = 9;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									case 4:
									case 15:
										_003C_003Eu__1 = default;
										num4 = 0;
										continue;
									case 19:
										if (num2 != 5)
										{
											num4 = 6;
											continue;
										}
										awaiter = _003C_003Eu__1;
										goto case 4;
									case 1:
										if (!VorU7gKGgu5bmnnjqo8C(current2))
										{
											_003C_003E7__wrap4 = e;
											num4 = 12;
											continue;
										}
										break;
									case 17:
									{
										IUndoAction result = awaiter3.GetResult();
										awaiter = F1RBueKGDGRnmao0VVV5(IeHiFlKGIShy2skRlNZM(_003C_003E7__wrap4, result));
										num4 = 2;
										continue;
									}
									case 0:
										num2 = (_003C_003E1__state = -1);
										num4 = 18;
										if (n9lApdKGaAO4SO3nvJ1J())
										{
										}
										continue;
									case 10:
									case 13:
										_003C_003Eu__1 = awaiter;
										num4 = 16;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 2;
									case 2:
										if (!awaiter.IsCompleted)
										{
											num4 = 5;
											continue;
										}
										goto case 18;
									case 9:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 11;
										continue;
									case 8:
										if (!awaiter3.IsCompleted)
										{
											num4 = 3;
											continue;
										}
										goto case 17;
									case 14:
										num2 = (_003C_003E1__state = -1);
										num4 = 17;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									case 12:
										awaiter3 = current2.ResetToDefault().GetAwaiter();
										num4 = 8;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 7;
									case 7:
										_003C_003Eu__3 = default;
										goto case 14;
									default:
										num4 = 14;
										if (0 == 0)
										{
											continue;
										}
										goto case 16;
									case 16:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 5:
										num2 = (_003C_003E1__state = 5);
										Svci2eKGJ0EsmxH9NwgG();
										num4 = ((!n9lApdKGaAO4SO3nvJ1J()) ? 10 : 4);
										continue;
									case 11:
										return;
									case 6:
									case 20:
										break;
									}
									if (jCh87KKGsNCAv7s3VDQ1(_003C_003E7__wrap3))
									{
										current2 = _003C_003E7__wrap3.Current;
										num4 = 1;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap3 != null)
								{
									f6a6RnKGi64PqDsFHdEU(_003C_003E7__wrap3);
								}
							}
							_003C_003E7__wrap3 = null;
							_003C_003E7__wrap1 = inspectStepViewModel.Tools.GetEnumerator();
							break;
						case 6:
						case 7:
						case 8:
						case 9:
						case 10:
							break;
							IL_0493:
							_003C_003E7__wrap3 = _003C_003E8__1.tool.AllProperties.OfType<InputStructureViewModel>().GetEnumerator();
							goto case 4;
							IL_03f0:
							awaiter.GetResult();
							awaiter = F1RBueKGDGRnmao0VVV5(IeHiFlKGIShy2skRlNZM(e, new UndoCompositeCellExpressionChange(inspectStepViewModel, ((CellViewModel)D8T5ExKGVCVjvNKI5kXC(_003Cgtool_003E5__3)).CellName, (string)yJ27MTKGfoaWJoDZuWSo(25476), (string)ujZb4wKGlWUsEtyQIuxH(CN7eL0KGd2uPg3MgxLel(_003C_003E8__1.tool)), append: false)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_048c;
							IL_02fa:
							snippet = e.Snippet;
							_003C_003E8__1.tool = snippet as EzTool;
							if (_003C_003E8__1.tool != null)
							{
								_003Cgtool_003E5__3 = inspectStepViewModel.Tools.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzTool t) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return t is GroupTool groupTool2 && groupTool2.Children.Contains(_003C_003E8__1.tool);
								}) as GroupTool;
								if (_003Cgtool_003E5__3 != null)
								{
									awaiter = F1RBueKGDGRnmao0VVV5(e.AddUndo(new UndoCompositeCellExpressionChange(inspectStepViewModel, _003Cgtool_003E5__3.ToolsPass.CellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(18708), ((CellViewModel)tRY35WKGnI4nsju9T4bF(_003C_003E8__1.tool)).CellName, append: false)));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_03f0;
								}
								goto IL_0493;
							}
							goto end_IL_0028;
							IL_048c:
							awaiter.GetResult();
							goto IL_0493;
						}
						try
						{
							if ((uint)(num2 - 6) <= 3u)
							{
								goto IL_07c0;
							}
							if (num2 != 10)
							{
								goto IL_0d81;
							}
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0d73;
							IL_0d7a:
							_003Ct_003E5__6 = null;
							goto IL_0d81;
							IL_07c0:
							try
							{
								int num5;
								switch (num2)
								{
								default:
									num5 = 35;
									break;
								case 7:
									awaiter = _003C_003Eu__1;
									num5 = 17;
									break;
								case 9:
									awaiter = _003C_003Eu__1;
									num5 = 32;
									break;
								case 6:
									awaiter3 = _003C_003Eu__3;
									num5 = 37;
									break;
								case 8:
									awaiter3 = _003C_003Eu__3;
									num5 = 33;
									break;
								}
								while (true)
								{
									IUndoAction result;
									switch (num5)
									{
									case 24:
										num2 = (_003C_003E1__state = -1);
										goto IL_07eb;
									case 9:
									case 25:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num5 = 0;
										continue;
									case 33:
										_003C_003Eu__3 = default;
										num5 = 24;
										continue;
									case 14:
										item = EzSnippet.SplitCellName((string)Srf076KGvE7G2iZY6PB0(sourceLink)).snippetName;
										num5 = 8;
										continue;
									case 34:
										num2 = (_003C_003E1__state = -1);
										num5 = 29;
										if (true)
										{
											continue;
										}
										goto case 7;
									case 7:
										awaiter.GetResult();
										num5 = 19;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									case 1:
										awaiter3 = obj.p.ResetToDefault().GetAwaiter();
										num5 = 4;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 31;
									case 31:
										_003C_003Eu__3 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num5 = 23;
										continue;
									case 29:
										result = awaiter3.GetResult();
										awaiter = F1RBueKGDGRnmao0VVV5(IeHiFlKGIShy2skRlNZM(_003C_003E7__wrap4, result));
										num5 = 22;
										if (!n9lApdKGaAO4SO3nvJ1J())
										{
											continue;
										}
										goto case 16;
									case 16:
										_003C_003E7__wrap4 = null;
										break;
									case 6:
										if (!awaiter3.IsCompleted)
										{
											num5 = 5;
											continue;
										}
										goto case 29;
									case 22:
										if (!awaiter.IsCompleted)
										{
											num5 = 3;
											continue;
										}
										goto IL_0aba;
									case 2:
										_003C_003Eu__1 = awaiter;
										num5 = 13;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = 7);
										num5 = 2;
										continue;
									case 27:
										num2 = (_003C_003E1__state = 8);
										_003C_003Eu__3 = awaiter3;
										goto case 9;
									case 36:
										return;
									case 11:
										if (!VorU7gKGgu5bmnnjqo8C(obj.p))
										{
											CvsCellLocation location = CvsCellLocation.TryParse(obj.p.CellExpression);
											if (location.IsValid && _003C_003E8__1.tool.CellRange.Contains(location))
											{
												num5 = 21;
												continue;
											}
											sourceLink = obj.p.Links.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetConsumer_002ERemoveReferences_003Eb__1);
											if (sourceLink != null)
											{
												num5 = 14;
												continue;
											}
										}
										break;
									case 37:
										_003C_003Eu__3 = default;
										num5 = 34;
										continue;
									case 28:
										num2 = (_003C_003E1__state = 9);
										num5 = 30;
										continue;
									case 8:
										if (ankr36KGrRQxA9nJKQPS(_003C_003E8__1.tool.Name, item))
										{
											_003C_003E7__wrap4 = e;
											num5 = 1;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										break;
									case 15:
										return;
									case 12:
									case 18:
										num2 = (_003C_003E1__state = -1);
										goto IL_0aba;
									case 19:
										_003C_003E7__wrap4 = null;
										num5 = 38;
										if (Svci2eKGJ0EsmxH9NwgG())
										{
											continue;
										}
										goto case 4;
									case 4:
										if (!awaiter3.IsCompleted)
										{
											num5 = 27;
											continue;
										}
										goto IL_07eb;
									case 21:
										_003C_003E7__wrap4 = e;
										num5 = 20;
										continue;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num5 = 36;
										continue;
									case 23:
										return;
									case 0:
										return;
									case 32:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num5 = 7;
										if (0 == 0)
										{
											continue;
										}
										goto case 17;
									case 17:
										_003C_003Eu__1 = default;
										goto default;
									default:
										_ = 1;
										num5 = ((!n9lApdKGaAO4SO3nvJ1J()) ? 12 : 9);
										continue;
									case 26:
										obj.p = _003C_003E7__wrap3.Current;
										num5 = 11;
										continue;
									case 5:
										num2 = (_003C_003E1__state = 6);
										num5 = 31;
										continue;
									case 30:
										_003C_003Eu__1 = awaiter;
										num5 = 10;
										continue;
									case 10:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num5 = 15;
										if (0 == 0)
										{
											continue;
										}
										goto case 20;
									case 20:
										awaiter3 = obj.p.ResetToDefault().GetAwaiter();
										num5 = 6;
										continue;
									case 35:
									case 38:
										break;
										IL_07eb:
										result = awaiter3.GetResult();
										awaiter = ((Task)IeHiFlKGIShy2skRlNZM(_003C_003E7__wrap4, result)).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num5 = 28;
											continue;
										}
										goto case 7;
										IL_0aba:
										awaiter.GetResult();
										num5 = 16;
										continue;
									}
									if (jCh87KKGsNCAv7s3VDQ1(_003C_003E7__wrap3))
									{
										obj = new _003C_003Ec__DisplayClass194_1();
										num5 = 26;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap3 != null)
								{
									_003C_003E7__wrap3.Dispose();
								}
							}
							_003C_003E7__wrap3 = null;
							if (_003Ct_003E5__6 is ISnippetConsumer snippetConsumer)
							{
								awaiter = F1RBueKGDGRnmao0VVV5(DxVpjeKGPAaE8e59n2wl(snippetConsumer, e));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 10);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0d73;
							}
							goto IL_0d7a;
							IL_0d81:
							while (_003C_003E7__wrap1.MoveNext())
							{
								_003Ct_003E5__6 = _003C_003E7__wrap1.Current;
								if (_003Ct_003E5__6 == _003C_003E8__1.tool)
								{
									continue;
								}
								_003C_003E7__wrap3 = _003Ct_003E5__6.AllProperties.OfType<InputStructureViewModel>().GetEnumerator();
								goto IL_07c0;
							}
							goto end_IL_0767;
							IL_0d73:
							awaiter.GetResult();
							goto IL_0d7a;
							end_IL_0767:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								f6a6RnKGi64PqDsFHdEU(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						_003Cgtool_003E5__3 = null;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 5:
					inspectStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 7:
					return;
				}
				_003C_003E8__1 = null;
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
		internal static object K3TUYXKGeOMjjytHHy4I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fy74ONKGOhhf0PfJP43n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IeHiFlKGIShy2skRlNZM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter F1RBueKGDGRnmao0VVV5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void f6a6RnKGi64PqDsFHdEU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tRY35WKGnI4nsju9T4bF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Pass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D8T5ExKGVCVjvNKI5kXC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((GroupTool)P_0).ToolExecutionTimes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yJ27MTKGfoaWJoDZuWSo(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CN7eL0KGd2uPg3MgxLel(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).ExecutionTime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ujZb4wKGlWUsEtyQIuxH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VorU7gKGgu5bmnnjqo8C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InputStructureViewModel)P_0).IsDefault;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jCh87KKGsNCAv7s3VDQ1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Srf076KGvE7G2iZY6PB0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ankr36KGrRQxA9nJKQPS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DxVpjeKGPAaE8e59n2wl(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetConsumer)P_0).RemoveReferences((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Svci2eKGJ0EsmxH9NwgG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n9lApdKGaAO4SO3nvJ1J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static ILogger tvvAxfHbyB;

	private readonly ObservableCollection<ToolCategory> FvPAvCZaVQ;

	private readonly List<EzToolType> evWAerkZFD;

	private byte[] NUoA2uJEWC;

	private CvsCellRange Q4ZAqKq0Iy;

	private int f6cAiOYCKR;

	private readonly EzToolType[] W1DAktOFcA;

	private EzSupportSnippetType[] Wd8APvDnN4;

	private int Jf0As7mSmL;

	private bool KOmAKLKQuY;

	private string eWVAGFnRx1;

	private EzTool w70ABQLieC;

	[CompilerGenerated]
	private EzTool hkxAZLEM1n;

	[CompilerGenerated]
	private ISnippetManager sayAnH2mK3;

	private EzToolType[] u0SAteTInG;

	[CompilerGenerated]
	private readonly DelegateCommand PQwAYCxZaf;

	[CompilerGenerated]
	private IEnumerable<ToolCategory> x6lA0O8O03;

	[CompilerGenerated]
	private IEnumerable<ToolCategory> kBnAV2X0Id;

	private IEnumerable<ToolCategory> pZxAL4xs1i;

	private ToolCategory KP8AJufAGH;

	[CompilerGenerated]
	private DelegateCommand Ng9A9ZX4tB;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand V0VArGDnZY;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand OibAh96ooq;

	private string Mf8A8dtfiV;

	[CompilerGenerated]
	private EventHandler RDFAm9NFxP;

	[CompilerGenerated]
	private EventHandler KeYA1CG1qu;

	[CompilerGenerated]
	private EventHandler<FailAddEventArgs> Sp8Azi12BL;

	private readonly IReadOnlyObservableCastCollection<EzTool> SNIdalGwKh;

	public EventHandler AddCompleted;

	private bool EE1d5Mi5A3;

	private JobPassFail XG2dp1Ckxy;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_InspectPartIcon;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)imuQB1n68QytVntBDmd();
		}
	}

	public override string Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.zLfruqTZFu();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ueYYBNw8rk();
		}
	}

	public override string HelpTopic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AppStepHelpTopics.Inspect;
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Jf0As7mSmL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Jf0As7mSmL, value, (string)FJhIpJnCre13JLO4EBC(3256));
		}
	}

	public bool IsEasyBuilderAdvancedMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KOmAKLKQuY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (X6DCAun4LT77jfrayXc())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_008e;
				}
			}
			goto IL_005f;
			IL_005f:
			while (true)
			{
				switch (num)
				{
				default:
				{
					EzSnippet currentSnippet = CurrentSnippet;
					if (currentSnippet == null)
					{
						num = 5;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					AIiZrNnRCrxY10X5PmI(currentSnippet);
					return;
				}
				case 1:
					N8QmtNnA2o3JprDHNFr(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3996));
					goto default;
				case 0:
				case 4:
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_008e;
			IL_008e:
			if (SetField(ref KOmAKLKQuY, value, (string)FJhIpJnCre13JLO4EBC(3942)))
			{
				num = 1;
				goto IL_005f;
			}
		}
	}

	public string AdvancedModeToggleTooltip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!IsEasyBuilderAdvancedMode)
			{
				return (string)aonBrhnWbso2R3VGY15();
			}
			return (string)FB1DnfnTkDBm4ktpVhP();
		}
	}

	public string PaletteFilterText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eWVAGFnRx1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref eWVAGFnRx1, value, (string)FJhIpJnCre13JLO4EBC(4050)))
			{
				zIyNYXJes6();
			}
		}
	}

	public EzTool RuntimeModeFocusTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hkxAZLEM1n;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hkxAZLEM1n = value;
		}
	}

	public override CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return base.InSight;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			X6DCAun4LT77jfrayXc();
			int num = (qWfIXTn7IbIk60iYoB2() ? 5 : 2);
			while (true)
			{
				switch (num)
				{
				case 6:
					base.InSight = value;
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 2:
					if (base.InSight == null)
					{
						goto case 6;
					}
					goto case 1;
				case 4:
					if (base.InSight != null)
					{
						num = 3;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					return;
				case 1:
				case 5:
					GicwY6nFcEAodTJxoyv(Analyzer, null);
					num = 6;
					if (!qWfIXTn7IbIk60iYoB2())
					{
						break;
					}
					goto case 3;
				case 3:
					GicwY6nFcEAodTJxoyv(Analyzer, InSight);
					num = 7;
					if (!X6DCAun4LT77jfrayXc())
					{
						return;
					}
					break;
				case 7:
					return;
				}
			}
		}
	}

	public EzToolType[] ToolTypes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u0SAteTInG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref u0SAteTInG, value, (string)FJhIpJnCre13JLO4EBC(4172));
		}
	}

	public DelegateCommand AddAllTypesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PQwAYCxZaf;
		}
	}

	public IEnumerable<ToolCategory> DefaultSimplifiedCategories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x6lA0O8O03;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			x6lA0O8O03 = value;
		}
	}

	public IEnumerable<ToolCategory> SimplifiedCategories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kBnAV2X0Id;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kBnAV2X0Id = value;
		}
	}

	public IEnumerable<ToolCategory> FilteredSimplifiedCategories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pZxAL4xs1i;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref pZxAL4xs1i, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4218));
		}
	}

	public ToolCategory[] Categories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FvPAvCZaVQ.ToArray();
		}
	}

	public ToolCategory SelectedCategory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KP8AJufAGH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref KP8AJufAGH, value, (string)FJhIpJnCre13JLO4EBC(4278)))
			{
				Sn6ApW22ZC();
			}
		}
	}

	public EzToolType[] FilteredTools
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (EzToolType[])Rm5fnEntPQhTq75JWfT(evWAerkZFD);
		}
	}

	public byte[] CopyTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NUoA2uJEWC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					uVMMGLnzloUjHfuTSlG(PasteCommand);
					goto case 0;
				case 5:
					N8QmtNnA2o3JprDHNFr(this, FJhIpJnCre13JLO4EBC(4114));
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					uVMMGLnzloUjHfuTSlG(PasteUnshiftCommand);
					goto case 5;
				default:
					num = 5;
					break;
				case 4:
					if (SetField(ref NUoA2uJEWC, value, (string)FJhIpJnCre13JLO4EBC(4314)))
					{
						_ = 0;
						num = (X6DCAun4LT77jfrayXc() ? 3 : 0);
						break;
					}
					return;
				case 6:
					return;
				}
			}
		}
	}

	public bool CanCopyTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (CurrentTool != null && JrTwNFVLDdQj96jYm12(CurrentTool.CopyCommand))
			{
				return IsActive;
			}
			return false;
		}
	}

	public bool CanPasteTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (JrTwNFVLDdQj96jYm12(PasteCommand))
			{
				return IsActive;
			}
			return false;
		}
	}

	public double ExecutionTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0.0;
		}
	}

	public DelegateCommand ClearSearchTextCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ng9A9ZX4tB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ng9A9ZX4tB = value;
		}
	}

	public AsyncDelegateCommand PasteCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return V0VArGDnZY;
		}
	}

	public AsyncDelegateCommand PasteUnshiftCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OibAh96ooq;
		}
	}

	public string ToolFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mf8A8dtfiV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			X6DCAun4LT77jfrayXc();
			int num = (qWfIXTn7IbIk60iYoB2() ? 6 : 2);
			while (true)
			{
				switch (num)
				{
				case 4:
					Mf8A8dtfiV = value;
					num = 5;
					if (X6DCAun4LT77jfrayXc())
					{
						break;
					}
					goto default;
				default:
					Sn6ApW22ZC();
					num = 1;
					break;
				case 0:
				case 2:
					if (Mf8A8dtfiV != value)
					{
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 5;
					}
					return;
				case 5:
					SS3AU71vfn();
					goto default;
				case 1:
					TjQxywnx4JcwTwhwtoI(this, FJhIpJnCre13JLO4EBC(4334));
					num = 7;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public EzToolType AddingToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (EzToolType)AddingSnippetType;
		}
	}

	public IReadOnlyObservableCastCollection<EzTool> Tools
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SNIdalGwKh;
		}
	}

	public EzTool CurrentTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (EzTool)CurrentSnippet;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CurrentSnippet = value;
		}
	}

	public bool CanLinkProperties
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			object obj = JgLJvTVK7wks4e1cFF6(this);
			if (obj == null)
			{
				return false;
			}
			return !LlN4txVEW3DWFVlMrrM(obj);
		}
	}

	public JobPassFail JobPassFail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XG2dp1Ckxy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (X6DCAun4LT77jfrayXc())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (!X6DCAun4LT77jfrayXc())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					TjQxywnx4JcwTwhwtoI(this, FJhIpJnCre13JLO4EBC(2454));
					num = 6;
					if (X6DCAun4LT77jfrayXc())
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					GDcct3V4ByfXZeUGah6(XG2dp1Ckxy);
					num = 5;
					break;
				case 5:
					XG2dp1Ckxy = value;
					goto case 3;
				default:
					num = 3;
					if (qWfIXTn7IbIk60iYoB2())
					{
					}
					break;
				case 0:
				case 2:
					if (XG2dp1Ckxy != null)
					{
						goto case 1;
					}
					goto case 5;
				case 6:
					return;
				}
			}
		}
	}

	public event EventHandler BeginAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					eventHandler = Interlocked.CompareExchange(ref RDFAm9NFxP, value2, eventHandler2);
					num = 6;
					break;
				case 1:
					eventHandler = RDFAm9NFxP;
					num = 4;
					break;
				case 0:
				case 2:
					value2 = (EventHandler)mGFHy5VsbuQrxeeK8vE(eventHandler2, value);
					goto default;
				case 4:
					eventHandler2 = eventHandler;
					X6DCAun4LT77jfrayXc();
					num = (qWfIXTn7IbIk60iYoB2() ? 5 : 0);
					break;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 4;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (qWfIXTn7IbIk60iYoB2() ? 1 : 6);
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					eventHandler = Interlocked.CompareExchange(ref RDFAm9NFxP, value2, eventHandler2);
					num = 3;
					if (qWfIXTn7IbIk60iYoB2())
					{
					}
					break;
				case 1:
				case 2:
					value2 = (EventHandler)CQQs3xVvOopXApjTw2k(eventHandler2, value);
					goto case 4;
				default:
					num = 4;
					break;
				case 3:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (qWfIXTn7IbIk60iYoB2())
						{
						}
						break;
					}
					goto case 5;
				case 0:
				case 6:
					eventHandler = RDFAm9NFxP;
					num = 5;
					break;
				case 5:
					eventHandler2 = eventHandler;
					goto case 1;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler CancelAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (X6DCAun4LT77jfrayXc())
			{
				num = 6;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0068;
			IL_0026:
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			if ((object)eventHandler != eventHandler2)
			{
				goto IL_0037;
			}
			num = 7;
			goto IL_0068;
			IL_009d:
			EventHandler value2 = default;
			eventHandler = Interlocked.CompareExchange(ref KeYA1CG1qu, value2, eventHandler2);
			num = 1;
			goto IL_0068;
			IL_0049:
			value2 = (EventHandler)mGFHy5VsbuQrxeeK8vE(eventHandler2, value);
			goto IL_009d;
			IL_0037:
			eventHandler2 = eventHandler;
			goto IL_0049;
			IL_0068:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					goto IL_0037;
				case 2:
				case 3:
					goto IL_0049;
				default:
					num = 5;
					if (X6DCAun4LT77jfrayXc())
					{
						continue;
					}
					goto IL_009d;
				case 5:
					goto IL_009d;
				case 0:
				case 6:
					eventHandler = KeYA1CG1qu;
					num = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qWfIXTn7IbIk60iYoB2();
			int num;
			if (X6DCAun4LT77jfrayXc())
			{
				num = 2;
				if (qWfIXTn7IbIk60iYoB2())
				{
				}
			}
			else
			{
				num = 5;
			}
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					eventHandler = eventHandler2;
					num = 1;
					break;
				default:
					eventHandler2 = Interlocked.CompareExchange(ref KeYA1CG1qu, value2, eventHandler);
					num = 4;
					if (!qWfIXTn7IbIk60iYoB2())
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					eventHandler2 = KeYA1CG1qu;
					num = 6;
					break;
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (qWfIXTn7IbIk60iYoB2())
						{
						}
						break;
					}
					goto case 6;
				case 1:
					value2 = (EventHandler)CQQs3xVvOopXApjTw2k(eventHandler, value);
					goto default;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler<FailAddEventArgs> FailAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FailAddEventArgs> eventHandler = Sp8Azi12BL;
			EventHandler<FailAddEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FailAddEventArgs> value2 = (EventHandler<FailAddEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sp8Azi12BL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FailAddEventArgs> eventHandler = Sp8Azi12BL;
			EventHandler<FailAddEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FailAddEventArgs> value2 = (EventHandler<FailAddEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Sp8Azi12BL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ImportingConstructor]
	public InspectStepViewModel([ImportMany] EzToolType[] toolTypes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 11:
			case 13:
				StepDisplay = new InspectStepDisplay(null, this);
				num = 5;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					break;
				}
				goto case 7;
			case 7:
				FvPAvCZaVQ = new ObservableCollection<ToolCategory>();
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				Array.Sort(toolTypes, [MethodImpl(MethodImplOptions.NoInlining)] (EzToolType x, EzToolType y) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return x.Order.CompareTo(_003C_003Ec.fnRXCqKr9cQKR0jYsxCe(y));
				});
				W1DAktOFcA = toolTypes;
				toolTypes = toolTypes.Where([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType toolType) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.CWXMxJKr4tfA6uVpjDm1(toolType);
				}).ToArray();
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				ShowInSightDisplay = true;
				num = 17;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 1;
			case 1:
				EE1d5Mi5A3 = true;
				num = 2;
				break;
			case 0:
				V0VArGDnZY = new AsyncDelegateCommand(VkuNzaA62W, Uy2N172DLv);
				num = 8;
				break;
			case 9:
				evWAerkZFD = new List<EzToolType>();
				num = 16;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				base._002Ector();
				num = 14;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					break;
				}
				goto case 16;
			case 16:
				Jf0As7mSmL = 300;
				_ = 0;
				if (X6DCAun4LT77jfrayXc())
				{
					num = 15;
					break;
				}
				num = 11;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				return;
			case 14:
				ClearSearchTextCommand = new DelegateCommand(tdFN8bAbHE, ttDNmhfaKR);
				goto case 0;
			default:
				num = 0;
				break;
			case 4:
			case 15:
				eWVAGFnRx1 = "";
				Mf8A8dtfiV = string.Empty;
				num = 1;
				break;
			case 6:
				ToolTypes = toolTypes;
				SNIdalGwKh = Snippets.CastElementType<EzSnippet, EzTool>();
				num = 10;
				break;
			case 8:
				OibAh96ooq = new AsyncDelegateCommand(CZNAak5Jqc, Uy2N172DLv);
				num = 12;
				break;
			case 3:
				HP83hfn3q5oFSZ7o1a9();
				num = 7;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 10;
			case 10:
				PQwAYCxZaf = new DelegateCommand(p0bNLPd1Pr);
				goto case 11;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__9))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!X6DCAun4LT77jfrayXc()) ? 1 : 2);
		_003CDisposeAsync_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = YriCtsnjM4AqWpLFFJd();
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zIyNYXJes6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<EzSnippet> enumerator = Snippets.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.mSa5R0Ugrt(eWVAGFnRx1);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				vCnYv5nyX86oB7wc8qO(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnEnterStep_003Ed__35))]
	protected override Task OnEnterStep(StepBase previousStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!qWfIXTn7IbIk60iYoB2())
		{
		}
		_003COnEnterStep_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				qWfIXTn7IbIk60iYoB2();
				num = ((!X6DCAun4LT77jfrayXc()) ? 6 : 4);
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine.previousStep = previousStep;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnLeaveStep_003Ed__36))]
	protected override Task OnLeaveStep(StepBase nextStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnLeaveStep_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				X6DCAun4LT77jfrayXc();
				if (qWfIXTn7IbIk60iYoB2())
				{
					num = 4;
					break;
				}
				num = 0;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine.nextStep = nextStep;
				goto case 3;
			default:
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yEtN0uVcH4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N8QmtNnA2o3JprDHNFr(this, FJhIpJnCre13JLO4EBC(4088));
		N8QmtNnA2o3JprDHNFr(this, FJhIpJnCre13JLO4EBC(4114));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X6DCAun4LT77jfrayXc();
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 9;
		}
		else
		{
			num = 6;
			if (false)
			{
				return;
			}
		}
		int num2 = default;
		EzTool[] array = default;
		EzTool ezTool = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
			case 6:
				if (num2 < array.Length)
				{
					ezTool = array[num2];
					num = 3;
				}
				else
				{
					num = 1;
				}
				break;
			case 7:
				jZ7Ak6nMm6WRdVj5ZBl(ezTool, cells);
				goto case 8;
			default:
				num = 8;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				num2++;
				num = 4;
				break;
			case 3:
				if (Tools.Contains(ezTool))
				{
					num = 7;
					break;
				}
				goto case 8;
			case 0:
			case 9:
				array = Tools.ToArray();
				num = 5;
				break;
			case 1:
				iJRmjZnYxFL363uNdNX(JobPassFail, cells);
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				num2 = 0;
				goto case 2;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISnippetOwner.Supports(Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X6DCAun4LT77jfrayXc();
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00a8;
			}
		}
		goto IL_0079;
		IL_0079:
		_003C_003Ec__DisplayClass47_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			default:
				if (!ToolTypes.Any(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESupports_003Eb__0))
				{
					num = 5;
					continue;
				}
				return true;
			case 4:
				obj.guid = guid;
				goto default;
			case 5:
				goto IL_00a8;
			}
			break;
		}
		goto IL_002a;
		IL_00a8:
		return Wd8APvDnN4.Any(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESupports_003Eb__1);
		IL_002a:
		obj = new _003C_003Ec__DisplayClass47_0();
		num = 4;
		goto IL_0079;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__48))]
	Task ISnippetOwner.AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange, SnippetAddedEventType action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X6DCAun4LT77jfrayXc();
		int num = (qWfIXTn7IbIk60iYoB2() ? 7 : 3);
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__48 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 8;
				if (qWfIXTn7IbIk60iYoB2())
				{
				}
				break;
			case 8:
				stateMachine.guid = guid;
				num = 5;
				break;
			case 9:
				stateMachine.cellRange = cellRange;
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				stateMachine.action = action;
				num = 4;
				break;
			case 5:
				stateMachine.cells = cells;
				num = 9;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__49))]
	Task ISnippetOwner.UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__49 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 7;
				break;
			case 4:
			case 6:
				stateMachine.snippetRange = snippetRange;
				goto case 5;
			case 2:
				stateMachine.guid = guid;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
				stateMachine.cells = cells;
				goto default;
			default:
				_ = 1;
				num = ((!qWfIXTn7IbIk60iYoB2()) ? 6 : 8);
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISnippetOwner.SnippetNeedsUpdate(Guid guid, CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!X6DCAun4LT77jfrayXc())
			{
				goto IL_00fb;
			}
		}
		EzSupportSnippetType ezSupportSnippetType = default;
		EzToolType ezToolType = default;
		_003C_003Ec__DisplayClass50_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (ezSupportSnippetType != null)
				{
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 6;
				}
				return false;
			case 6:
				return wqkkugnUV1Fm4VrBe7Q(ezToolType, range, cells);
			case 7:
				ezToolType = ToolTypes.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0);
				num = 3;
				continue;
			case 3:
				if (ezToolType == null)
				{
					ezSupportSnippetType = Wd8APvDnN4.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__1);
					num = 5;
					continue;
				}
				goto case 6;
			default:
				num = 6;
				continue;
			case 1:
			case 2:
				obj.guid = guid;
				num = 7;
				continue;
			case 0:
			case 4:
				obj = new _003C_003Ec__DisplayClass50_0();
				goto case 1;
			case 8:
				break;
			}
			break;
		}
		goto IL_00fb;
		IL_00fb:
		return wqkkugnUV1Fm4VrBe7Q(ezSupportSnippetType, range, cells);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private ISnippetManager n7LAWSmuQk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sayAnH2mK3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void tiqAjVFA8H(ISnippetManager value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sayAnH2mK3 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBeginInitialization_003Ed__55))]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (X6DCAun4LT77jfrayXc())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0040;
		IL_00bf:
		_003CBeginInitialization_003Ed__55 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 2;
		goto IL_0040;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 6;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (qWfIXTn7IbIk60iYoB2())
				{
				}
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				goto IL_00bf;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine.jobLoading = jobLoading;
		goto IL_00bf;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t64NVHXFJK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Wd8APvDnN4 = new EzSupportSnippetType[1]
		{
			new JobPassFailType(this)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCompleteInitializationAsync_003Ed__57))]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!X6DCAun4LT77jfrayXc()) ? 6 : 3);
		_003CCompleteInitializationAsync_003Ed__57 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.snippetManager = snippetManager;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 5;
				if (X6DCAun4LT77jfrayXc())
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
	[AsyncStateMachine(typeof(_003CRuntimeModeService_RuntimeModeChanged_003Ed__58))]
	protected override void RuntimeModeService_RuntimeModeChanged(object sender, RuntimeModeChangedEventArgs a)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRuntimeModeService_RuntimeModeChanged_003Ed__58 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 4:
				stateMachine._003C_003Et__builder = XEL57TnHLnIe7bi4eva();
				_ = 1;
				num = (qWfIXTn7IbIk60iYoB2() ? 6 : 0);
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
				stateMachine.a = a;
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RuntimeService_SheetExecuted(object sender, CvsCogSessionResult e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TjQxywnx4JcwTwhwtoI(this, FJhIpJnCre13JLO4EBC(4142));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SourceLink GetAcquiredImageSourceLink()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation cvsCellLocation = qJC842nQgLNbuMfs9i9(sjTN7rnmhQbO6FHUVJh(this));
		return new SourceLink(Resources.Acquired, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true), CellType.Image);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_007e;
		IL_00b5:
		List<SourceLink> list = default;
		SourceLink[] sourceLinks = default;
		list.AddRange(sourceLinks);
		num = 9;
		if (0 == 0)
		{
			goto IL_007e;
		}
		goto IL_00c8;
		IL_01b5:
		return (SourceLink[])yN93WQncghuOkUqkFCY(list);
		IL_00c8:
		IEnumerator<EzSnippet> enumerator = Snippets.GetEnumerator();
		num = 8;
		if (X6DCAun4LT77jfrayXc())
		{
			goto IL_007e;
		}
		goto IL_00e4;
		IL_007e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 5:
				goto IL_0038;
			case 2:
				if (sourceLinks != null)
				{
					num = 5;
					continue;
				}
				goto IL_01b5;
			case 7:
				sourceLinks = JobPassFail.GetSourceLinks(reqDataType);
				goto case 2;
			default:
				num = 2;
				continue;
			case 3:
			case 6:
				goto IL_00b5;
			case 1:
				goto IL_00c8;
			case 8:
				goto IL_00e4;
			case 9:
				goto IL_01b5;
			}
			break;
		}
		goto IL_0026;
		IL_00e4:
		try
		{
			while (QYtWqRn2jLy3vFUlAfi(enumerator))
			{
				SourceLink[] array = (SourceLink[])qGfIh6nNm2Z8JYA5g8A(enumerator.Current, reqDataType);
				X6DCAun4LT77jfrayXc();
				int num2;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					num2 = 4;
					if (false)
					{
						goto IL_0112;
					}
				}
				else
				{
					num2 = 2;
				}
				goto IL_0141;
				IL_0112:
				if (array == null)
				{
					continue;
				}
				goto IL_0128;
				IL_0128:
				if (array.Length == 0)
				{
					continue;
				}
				goto IL_0172;
				IL_0172:
				list.AddRange(array);
				num2 = 5;
				goto IL_0141;
				IL_0141:
				while (true)
				{
					switch (num2)
					{
					case 0:
					case 4:
						break;
					case 1:
					case 2:
						goto IL_0128;
					default:
						num2 = 3;
						if (qWfIXTn7IbIk60iYoB2())
						{
						}
						continue;
					case 3:
						goto IL_0172;
					case 5:
						goto IL_0183;
					}
					break;
				}
				goto IL_0112;
				IL_0183:;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				vCnYv5nyX86oB7wc8qO(enumerator);
			}
		}
		if (JobPassFail != null)
		{
			num = 7;
			goto IL_007e;
		}
		goto IL_01b5;
		IL_0026:
		list = new List<SourceLink>();
		num = 1;
		if (false)
		{
			goto IL_0038;
		}
		goto IL_007e;
		IL_0038:
		if (sourceLinks.Length != 0)
		{
			goto IL_00b5;
		}
		goto IL_01b5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSnippetLocation_003Ed__62))]
	public Task<CvsCellRange> GetSnippetLocation(CvsCellRange range, bool right = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSnippetLocation_003Ed__62 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.range = range;
		stateMachine.right = right;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSnippetLocation_003Ed__63))]
	public Task<CvsCellRange> GetSnippetLocation(CvsCellCollection cells, CvsCellRange range, bool right = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSnippetLocation_003Ed__63 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.range = range;
		stateMachine.right = right;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void p0bNLPd1Pr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ToolTypes = W1DAktOFcA;
		XC0Nr0BeQJ(ToolTypes, ((EasyBuilderApplicationViewModel)sjTN7rnmhQbO6FHUVJh(this))?.EasyBuilderConfig);
		TjQxywnx4JcwTwhwtoI(this, FJhIpJnCre13JLO4EBC(4194));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzToolType ySbNJ0Jgqg(ToolCategory P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (X6DCAun4LT77jfrayXc())
		{
			num = 1;
			if (qWfIXTn7IbIk60iYoB2())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_010a;
		IL_002a:
		EzToolType ezToolType = null;
		num = 5;
		goto IL_010a;
		IL_010a:
		IEnumerator<ToolCategory> enumerator = default;
		IEnumerator<EzToolType> enumerator2 = default;
		EzToolType ezToolType2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 3:
				enumerator = P_0.Categories.GetEnumerator();
				num = 6;
				continue;
			case 2:
			case 4:
				try
				{
					while (QYtWqRn2jLy3vFUlAfi(enumerator2))
					{
						EzToolType current2 = enumerator2.Current;
						X6DCAun4LT77jfrayXc();
						int num3;
						if (!qWfIXTn7IbIk60iYoB2())
						{
							num3 = 3;
							if (!X6DCAun4LT77jfrayXc())
							{
								goto IL_0078;
							}
						}
						else
						{
							num3 = 2;
						}
						goto IL_009b;
						IL_009b:
						switch (num3)
						{
						case 0:
						case 3:
							break;
						default:
							goto IL_00c4;
						case 4:
							goto end_IL_00d5;
						}
						goto IL_0078;
						IL_0078:
						if (!MOGwdTn1CHSg1VvVGbR(current2.ToolType, P_1))
						{
							continue;
						}
						goto IL_00c4;
						IL_00c4:
						ezToolType = current2;
						num3 = 4;
						goto IL_009b;
						continue;
						end_IL_00d5:
						break;
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						vCnYv5nyX86oB7wc8qO(enumerator2);
					}
				}
				if (ezToolType == null)
				{
					goto case 3;
				}
				goto IL_0202;
			default:
				num = 3;
				continue;
			case 5:
				enumerator2 = P_0.Tools.GetEnumerator();
				goto case 2;
			case 6:
				{
					try
					{
						while (QYtWqRn2jLy3vFUlAfi(enumerator))
						{
							ToolCategory current = enumerator.Current;
							_ = 1;
							int num2;
							if (!qWfIXTn7IbIk60iYoB2())
							{
								num2 = 4;
							}
							else
							{
								num2 = 2;
								if (1 == 0)
								{
									break;
								}
							}
							while (true)
							{
								switch (num2)
								{
								case 1:
								case 2:
									goto IL_0174;
								default:
									num2 = 3;
									if (true)
									{
										continue;
									}
									break;
								case 3:
									break;
								case 0:
								case 4:
									ezToolType2 = ySbNJ0Jgqg(current, P_1);
									goto IL_0174;
								case 5:
									goto end_IL_018d;
								}
								goto IL_01b6;
								IL_0174:
								if (ezToolType2 == null)
								{
									goto IL_01e5;
								}
								goto IL_01b6;
								IL_01b6:
								ezToolType = ezToolType2;
								num2 = 5;
								continue;
								end_IL_018d:
								break;
							}
							break;
							IL_01e5:;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							vCnYv5nyX86oB7wc8qO(enumerator);
						}
					}
					goto IL_0202;
				}
				IL_0202:
				return ezToolType;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzToolType ILpN9grMIy(Guid P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass73_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass73_0();
		CS_0024_003C_003E8__locals2.id = P_0;
		return ToolTypes.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)_003C_003Ec__DisplayClass73_0.WOMYkkKP2wNegWmxY8jM(t)).Contains(CS_0024_003C_003E8__locals2.id);
		}) ?? throw new ArgumentException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitToolTypes(CvsCogEasyBuilderConfig config)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XC0Nr0BeQJ(ToolTypes, config);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XC0Nr0BeQJ(IEnumerable<EzToolType> P_0, CvsCogEasyBuilderConfig P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ToolCategory toolCategory = new ToolCategory
		{
			Name = Resources.Y3bBa3uy7v()
		};
		List<ToolCategory> list = new List<ToolCategory>();
		foreach (EzToolType item in P_0)
		{
			item.EasyBuilderConfig = P_1;
			if (item.Inspect == null)
			{
				InitializeToolType(item);
			}
		}
		P_0 = P_0.OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (EzToolType t) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.fnRXCqKr9cQKR0jYsxCe(t);
		});
		foreach (EzToolType item2 in P_0)
		{
			_003C_003Ec__DisplayClass75_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass75_0();
			if (!item2.IsTypeEnabled)
			{
				continue;
			}
			CS_0024_003C_003E8__locals8.categoryNames = item2.Path;
			ToolCategory toolCategory2 = toolCategory;
			string[] array = CS_0024_003C_003E8__locals8.categoryNames;
			for (int num = 0; num < array.Length; num++)
			{
				_003C_003Ec__DisplayClass75_1 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass75_1();
				CS_0024_003C_003E8__locals7.name = array[num];
				ToolCategory toolCategory3 = toolCategory2.Categories.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ToolCategory c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec__DisplayClass75_1.q9mjZEKZJLqFv1qcHukZ(_003C_003Ec__DisplayClass75_1.SmkEDKKZwGfxl7PlIMun(c), CS_0024_003C_003E8__locals7.name);
				});
				if (toolCategory3 != null)
				{
					toolCategory2 = toolCategory3;
					continue;
				}
				ToolCategory toolCategory4 = new ToolCategory
				{
					Name = CS_0024_003C_003E8__locals7.name
				};
				toolCategory2.Categories.Add(toolCategory4);
				toolCategory2 = toolCategory4;
			}
			ToolCategory toolCategory5 = list.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ToolCategory category) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec__DisplayClass75_0.z2iSiqKPts1amuaCGtwr(category.Name, CS_0024_003C_003E8__locals8.categoryNames.Last());
			});
			if (toolCategory5 == null)
			{
				toolCategory5 = new ToolCategory
				{
					Name = CS_0024_003C_003E8__locals8.categoryNames.Last()
				};
				if (toolCategory5.Name.StartsWith(Resources.F0Z0bUM6Xp()))
				{
					toolCategory5.IsExpanded = true;
				}
				toolCategory5.Tools.Add(item2);
				list.Add(toolCategory5);
			}
			else
			{
				toolCategory5.Tools.Add(item2);
			}
			toolCategory2.Tools.Add(item2);
		}
		toolCategory.IsSelected = true;
		toolCategory.IsExpanded = true;
		foreach (ToolCategory category in toolCategory.Categories)
		{
			category.IsExpanded = true;
		}
		FvPAvCZaVQ.Add(toolCategory);
		ToolCategory toolCategory6 = toolCategory.Categories.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ToolCategory c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.nsa5nAKrCUS0lhuf2O8l(_003C_003Ec.PnPaSfKrjLtiaEb6ZVXy(c), _003C_003Ec.KCnNIfKr6BJmqOUWlhdA());
		});
		if (toolCategory6 != null)
		{
			toolCategory.Categories.Move(toolCategory.Categories.IndexOf(toolCategory6), 0);
		}
		DefaultSimplifiedCategories = list;
		BbDNhcWMZm();
		SelectedCategory = toolCategory;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeToolType(EzToolType toolType)
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
			case 3:
				toolType.BeginAdd += jufANcNKGE;
				num = 0;
				continue;
			case 0:
				ljtPPBnhCN0fS846yv0(toolType, new EventHandler(hkXAAMQCTZ));
				goto case 6;
			default:
				num = 6;
				continue;
			case 5:
				oIFKEinu3KXFaivNb2l(toolType, this);
				_ = 0;
				num = ((!X6DCAun4LT77jfrayXc()) ? 2 : 3);
				continue;
			case 6:
				toolType.AcceptAdd += ITVAo669G5;
				break;
			case 2:
			case 4:
				break;
			case 7:
				return;
			}
			toolType.FailAdd += fJIAdQVcAK;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BbDNhcWMZm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FilteredSimplifiedCategories = DefaultSimplifiedCategories.Select([MethodImpl(MethodImplOptions.NoInlining)] (ToolCategory P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ToolCategory toolCategory = new ToolCategory(P_0);
			toolCategory.SetToDefault();
			toolCategory.IsExpanded = (string)EV3a9hVjQ4c55QyRkHF(toolCategory) == Resources.F0Z0bUM6Xp();
			return toolCategory;
		}).ToList();
		SimplifiedCategories = FilteredSimplifiedCategories.ToList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tdFN8bAbHE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ToolFilter = string.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ttDNmhfaKR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Uy2N172DLv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (((IRuntimeModeService)JgLJvTVK7wks4e1cFF6(this)).IsOperatorOfflineAndNotInLiveMode)
		{
			return NUoA2uJEWC != null;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnPaste_003Ed__120))]
	private Task VkuNzaA62W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnPaste_003Ed__120 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				qWfIXTn7IbIk60iYoB2();
				if (!X6DCAun4LT77jfrayXc())
				{
					num = 5;
					break;
				}
				num = 3;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 2;
			case 2:
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
	[AsyncStateMachine(typeof(_003COnPasteUnshift_003Ed__121))]
	private Task CZNAak5Jqc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qWfIXTn7IbIk60iYoB2();
		int num;
		if (X6DCAun4LT77jfrayXc())
		{
			num = 3;
			if (qWfIXTn7IbIk60iYoB2())
			{
			}
		}
		else
		{
			num = 2;
			if (!X6DCAun4LT77jfrayXc())
			{
				goto IL_006e;
			}
		}
		goto IL_00a0;
		IL_00a0:
		_003COnPasteUnshift_003Ed__121 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				goto IL_004c;
			case 1:
			case 2:
				goto IL_006e;
			case 5:
				goto IL_0086;
			default:
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0032;
		IL_006e:
		stateMachine._003C_003E4__this = this;
		num = 5;
		if (!X6DCAun4LT77jfrayXc())
		{
			goto IL_0086;
		}
		goto IL_00a0;
		IL_0086:
		stateMachine._003C_003E1__state = -1;
		goto IL_0032;
		IL_004c:
		stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
		goto IL_006e;
		IL_0032:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (false)
		{
			goto IL_004c;
		}
		goto IL_00a0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnPaste_003Ed__122))]
	private Task GAwA59UD5w(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_00b7;
			}
		}
		goto IL_003e;
		IL_003e:
		_003COnPaste_003Ed__122 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.shift = P_0;
				goto case 6;
			default:
				num = 6;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 2:
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_00b7;
		IL_00b7:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Sn6ApW22ZC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)flHP5rV5H4aGGuxJoOm(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4358));
		try
		{
			bygT0PVwEbaxlAsn0qK(evWAerkZFD);
			X6DCAun4LT77jfrayXc();
			int num;
			if (!qWfIXTn7IbIk60iYoB2())
			{
				num = 2;
				if (qWfIXTn7IbIk60iYoB2())
				{
					goto IL_004e;
				}
			}
			else
			{
				num = 3;
			}
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0091;
			}
			goto IL_004e;
			IL_0091:
			TjQxywnx4JcwTwhwtoI(this, FJhIpJnCre13JLO4EBC(4404));
			return;
			IL_004e:
			O42A7YvKGg(SelectedCategory);
			goto IL_0091;
		}
		finally
		{
			if (disposable != null)
			{
				vCnYv5nyX86oB7wc8qO(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SS3AU71vfn()
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
		goto IL_02bf;
		IL_001a:
		List<ToolCategory> list = new List<ToolCategory>();
		num = 8;
		goto IL_02bf;
		IL_02bf:
		IEnumerator<ToolCategory> enumerator = default;
		string text2 = default;
		string[] array2 = default;
		string[] array = default;
		int num3 = default;
		ToolCategory toolCategory = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 7:
				try
				{
					while (QYtWqRn2jLy3vFUlAfi(enumerator))
					{
						IEnumerator<EzToolType> enumerator2 = enumerator.Current.Tools.GetEnumerator();
						try
						{
							while (QYtWqRn2jLy3vFUlAfi(enumerator2))
							{
								_003C_003Ec__DisplayClass128_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass128_0();
								int num2 = 9;
								while (true)
								{
									switch (num2)
									{
									case 10:
										if (!ws3SNtVOFhPAMyl96iK(CS_0024_003C_003E8__locals7.tool.ToolType, text2, StringComparison.CurrentCultureIgnoreCase))
										{
											num2 = 4;
											continue;
										}
										goto IL_015a;
									case 9:
										CS_0024_003C_003E8__locals7.tool = enumerator2.Current;
										array2 = array;
										num3 = 0;
										num2 = 12;
										continue;
									case 1:
										list.Add(toolCategory);
										num2 = 2;
										if (!qWfIXTn7IbIk60iYoB2())
										{
											continue;
										}
										goto case 0;
									case 0:
										if (text2.Length > 0)
										{
											num2 = 10;
											continue;
										}
										goto case 8;
									case 3:
										if (toolCategory == null)
										{
											goto case 14;
										}
										goto case 6;
									default:
										num2 = 14;
										continue;
									case 2:
										aT4jjTVnjWvRMnt0KcI(toolCategory, true);
										num2 = 6;
										continue;
									case 5:
									case 7:
										if (ws3SNtVOFhPAMyl96iK(k7Xe5aVDFXIL97fi1fj(CS_0024_003C_003E8__locals7.tool), text2, StringComparison.CurrentCultureIgnoreCase))
										{
											goto IL_015a;
										}
										goto case 8;
									case 12:
									case 13:
										if (num3 >= array2.Length)
										{
											num2 = 15;
											if (!qWfIXTn7IbIk60iYoB2())
											{
												continue;
											}
											goto case 14;
										}
										text2 = array2[num3];
										num2 = 0;
										continue;
									case 14:
									{
										ToolCategory toolCategory2 = new ToolCategory();
										sMO93wViaTb26p5jFEg(toolCategory2, k7Xe5aVDFXIL97fi1fj(CS_0024_003C_003E8__locals7.tool));
										toolCategory = toolCategory2;
										num2 = 1;
										continue;
									}
									case 8:
									case 11:
										num3++;
										num2 = 13;
										continue;
									case 6:
										toolCategory.Tools.Add(CS_0024_003C_003E8__locals7.tool);
										goto case 8;
									case 4:
										if (!ws3SNtVOFhPAMyl96iK(zLoERNVIOHbFKGBdgBq(CS_0024_003C_003E8__locals7.tool), text2, StringComparison.CurrentCultureIgnoreCase))
										{
											X6DCAun4LT77jfrayXc();
											if (qWfIXTn7IbIk60iYoB2())
											{
												num2 = 8;
												continue;
											}
											num2 = 7;
											if (X6DCAun4LT77jfrayXc())
											{
												continue;
											}
											break;
										}
										goto IL_015a;
									case 15:
										break;
										IL_015a:
										toolCategory = list.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ToolCategory it) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass128_0.Ce7DrkKZSR3UhZii3D6I(_003C_003Ec__DisplayClass128_0.NPP6aPKZGF22k5J4jbEu(it), _003C_003Ec__DisplayClass128_0.iM1aFKKZonr5UbKPOF5A(CS_0024_003C_003E8__locals7.tool));
										});
										num2 = 3;
										continue;
									}
									break;
								}
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								vCnYv5nyX86oB7wc8qO(enumerator2);
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						vCnYv5nyX86oB7wc8qO(enumerator);
					}
				}
				goto case 0;
			case 0:
				FilteredSimplifiedCategories = list;
				num = 9;
				continue;
			case 3:
			case 6:
				list = SimplifiedCategories.ToList();
				goto case 0;
			default:
				num = 0;
				continue;
			case 8:
				text = (string)A4ETe4Vag49AwfXOcuL(lNj7DeVJpJTWoTl4XDN(ToolFilter));
				_ = 0;
				num = ((!X6DCAun4LT77jfrayXc()) ? 6 : 4);
				continue;
			case 5:
				enumerator = DefaultSimplifiedCategories.GetEnumerator();
				num = 7;
				continue;
			case 2:
			case 4:
				if (E7p8olVeuOWICWLxf0p(text))
				{
					goto case 3;
				}
				array = text.Split(' ');
				num = 5;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void O42A7YvKGg(ToolCategory P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)flHP5rV5H4aGGuxJoOm(CvsTraceEzb.Info, FJhIpJnCre13JLO4EBC(4434));
		try
		{
			if (P_0 == null)
			{
				return;
			}
			IEnumerator<ToolCategory> enumerator = P_0.Categories.GetEnumerator();
			try
			{
				while (QYtWqRn2jLy3vFUlAfi(enumerator))
				{
					ToolCategory current = enumerator.Current;
					_ = 1;
					switch (qWfIXTn7IbIk60iYoB2() ? 3 : 2)
					{
					case 0:
					case 2:
						O42A7YvKGg(current);
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					vCnYv5nyX86oB7wc8qO(enumerator);
				}
			}
			string text = (string)A4ETe4Vag49AwfXOcuL(lNj7DeVJpJTWoTl4XDN(ToolFilter));
			IEnumerator<EzToolType> enumerator2;
			if (r02dMmVV9MJ4kDL80m8(text) > 0)
			{
				string[] array = (string[])dde61UVfdKmm2f6FXQf(text, new char[1] { ' ' });
				enumerator2 = P_0.Tools.GetEnumerator();
				try
				{
					int num2 = default;
					string text2 = default;
					string[] array2 = default;
					while (QYtWqRn2jLy3vFUlAfi(enumerator2))
					{
						EzToolType current2 = enumerator2.Current;
						int num = 0;
						while (true)
						{
							switch (num)
							{
							case 2:
								num2 = 0;
								num = 3;
								continue;
							case 8:
								if (gCkgr2VlSUUrT3eSN1U(lNj7DeVJpJTWoTl4XDN(zLoERNVIOHbFKGBdgBq(current2)), text2) < 0)
								{
									goto default;
								}
								goto case 4;
							default:
								_ = 1;
								if (!qWfIXTn7IbIk60iYoB2())
								{
									num = 1;
									if (qWfIXTn7IbIk60iYoB2())
									{
									}
								}
								else
								{
									num = 4;
								}
								continue;
							case 3:
							case 7:
								if (num2 < array2.Length)
								{
									text2 = array2[num2];
									num = 10;
									if (X6DCAun4LT77jfrayXc())
									{
										continue;
									}
									goto case 2;
								}
								num = 11;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
							case 6:
								evWAerkZFD.Add(current2);
								num = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								array2 = array;
								num = 2;
								continue;
							case 1:
							case 5:
								if (gCkgr2VlSUUrT3eSN1U(((string)k7Xe5aVDFXIL97fi1fj(current2)).ToLower(), text2) < 0)
								{
									goto IL_010c;
								}
								goto case 4;
							case 10:
								if (r02dMmVV9MJ4kDL80m8(text2) <= 0)
								{
									goto IL_010c;
								}
								if (gCkgr2VlSUUrT3eSN1U(lNj7DeVJpJTWoTl4XDN(kLfc42VdgFfk6Mi4K0p(current2)), text2) < 0)
								{
									num = 8;
									continue;
								}
								goto case 4;
							case 9:
							case 11:
								break;
								IL_010c:
								num2++;
								num = 7;
								continue;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator2 != null)
					{
						vCnYv5nyX86oB7wc8qO(enumerator2);
					}
				}
			}
			enumerator2 = P_0.Tools.GetEnumerator();
			try
			{
				while (QYtWqRn2jLy3vFUlAfi(enumerator2))
				{
					EzToolType current3 = enumerator2.Current;
					X6DCAun4LT77jfrayXc();
					int num3;
					if (!qWfIXTn7IbIk60iYoB2())
					{
						num3 = 2;
						if (!X6DCAun4LT77jfrayXc())
						{
							goto IL_02b7;
						}
					}
					else
					{
						num3 = 3;
					}
					switch (num3)
					{
					case 0:
					case 2:
						break;
					default:
						continue;
					}
					goto IL_02b7;
					IL_02b7:
					evWAerkZFD.Add(current3);
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					vCnYv5nyX86oB7wc8qO(enumerator2);
				}
			}
		}
		finally
		{
			if (disposable != null)
			{
				vCnYv5nyX86oB7wc8qO(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task jufANcNKGE(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!X6DCAun4LT77jfrayXc()) ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			{
				EventHandler eventHandler = RDFAm9NFxP;
				if (eventHandler == null)
				{
					break;
				}
				eventHandler(this, EventArgs.Empty);
				num = 5;
				continue;
			}
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				AddingSnippetType = P_0 as EzToolType;
				goto case 1;
			case 4:
			case 5:
				break;
			}
			break;
		}
		return (Task)JPpxfFVgxdISDlAvYfT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnAddingSnippetTypeChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N8QmtNnA2o3JprDHNFr(this, FJhIpJnCre13JLO4EBC(4504));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hkXAAMQCTZ(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qWfIXTn7IbIk60iYoB2();
		int num;
		if (X6DCAun4LT77jfrayXc())
		{
			num = 3;
			if (qWfIXTn7IbIk60iYoB2())
			{
			}
		}
		else
		{
			num = 4;
			if (!X6DCAun4LT77jfrayXc())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
			case 4:
				break;
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				AddingSnippetType = null;
				break;
			case 5:
				return;
			}
			EventHandler eventHandler = KeYA1CG1qu;
			if (eventHandler == null)
			{
				break;
			}
			eventHandler(this, EventArgs.Empty);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fJIAdQVcAK(object P_0, FailAddEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (X6DCAun4LT77jfrayXc())
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
			if (!X6DCAun4LT77jfrayXc())
			{
				return;
			}
		}
		goto IL_005f;
		IL_0026:
		EventHandler<FailAddEventArgs> eventHandler = Sp8Azi12BL;
		if (eventHandler == null)
		{
			num = 1;
		}
		else
		{
			eventHandler(this, P_1);
			num = 7;
		}
		goto IL_005f;
		IL_005f:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
			case 5:
				break;
			default:
				num = 3;
				if (qWfIXTn7IbIk60iYoB2())
				{
				}
				continue;
			case 6:
			{
				EventHandler eventHandler2 = KeYA1CG1qu;
				if (eventHandler2 != null)
				{
					igRHPLVri8vPIWls3tE(eventHandler2, this, EventArgs.Empty);
				}
				break;
			}
			case 1:
				return;
			case 0:
			case 4:
				AddingSnippetType = null;
				num = 6;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCurrentSnippetChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Action<string> action = FirePropertyChanged;
		Axxv85VPlMYSlVjsmU0(FgqmkYdnnf(), action, new object[1] { CdQUGaROfy7He9T0foW.KbIzwHEDLa(3804) });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetCurrentSnippet_003Ed__152))]
	public override Task SetCurrentSnippet(EzSnippet snippet, bool isRuntimeModeChange = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSetCurrentSnippet_003Ed__152 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine.snippet = snippet;
				num = 7;
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				continue;
			case 7:
				stateMachine.isRuntimeModeChange = isRuntimeModeChange;
				goto case 0;
			default:
				num = 0;
				if (X6DCAun4LT77jfrayXc())
				{
					continue;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				qWfIXTn7IbIk60iYoB2();
				if (X6DCAun4LT77jfrayXc())
				{
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateShowImageForInputImage(SourceLink link)
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
		goto IL_00cd;
		IL_0037:
		Dictionary<string, object> dictionary = default;
		((CvsCogSocketSheet)fTFRxUVoCqvN8NMRZP8(((CvsInSight)VabG47VGcMNwNunnCQi(this)).CogSocket)).Run(dictionary);
		num = 7;
		if (false)
		{
			goto IL_005a;
		}
		goto IL_00cd;
		IL_00cd:
		EzTool ezTool = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			default:
				goto IL_0037;
			case 2:
			case 6:
				goto IL_005a;
			case 5:
				return;
			case 3:
				goto IL_009f;
			case 0:
				if (ww00N0VbPhZkMPLZlHx(dictionary) > 0)
				{
					goto IL_0037;
				}
				return;
			case 8:
				return;
			}
			break;
			IL_009f:
			if (link != null)
			{
				ezTool = (EzTool)dHomwE5fPG(cG86fPVB2dBRHMCGnXY(BCM0XkVZCyD73OO8WRH(link)));
				qWfIXTn7IbIk60iYoB2();
				if (X6DCAun4LT77jfrayXc())
				{
					num = 6;
					continue;
				}
				num = 1;
				if (false)
				{
					return;
				}
			}
			else
			{
				num = 5;
			}
		}
		goto IL_001a;
		IL_005a:
		dictionary = V4DAuY3oul(ezTool);
		num = 0;
		goto IL_00cd;
		IL_001a:
		kj9NvnVSP56B9MYdO16(VabG47VGcMNwNunnCQi(this), true, false);
		num = 8;
		if (!X6DCAun4LT77jfrayXc())
		{
			goto IL_0037;
		}
		goto IL_00cd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void kuYA6dLHYx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (qWfIXTn7IbIk60iYoB2())
		{
			goto IL_001e;
		}
		goto IL_005e;
		IL_001e:
		kj9NvnVSP56B9MYdO16(VabG47VGcMNwNunnCQi(this), true, false);
		num = 6;
		goto IL_005e;
		IL_005e:
		Dictionary<string, object> dictionary = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				((CvsCogSocket)QLDssOVkBVmZ6WLHHa5(VabG47VGcMNwNunnCQi(this))).Sheet.Run(dictionary);
				break;
			case 4:
				dictionary = V4DAuY3oul(CurrentTool);
				X6DCAun4LT77jfrayXc();
				num = (qWfIXTn7IbIk60iYoB2() ? 5 : 0);
				continue;
			case 0:
			case 1:
				if (dictionary.Count > 0)
				{
					num = 2;
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<string, object> V4DAuY3oul(EzTool P_0, bool P_1 = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		string text = null;
		if (P_0 != null)
		{
			if (P_0.ShowImage != null)
			{
				text = P_0.ShowImage.CellName;
			}
			else
			{
				EzTool ezTool = vATAFT7HML(P_0);
				if (ezTool?.ShowImage != null)
				{
					text = ezTool.ShowImage.CellName;
				}
			}
		}
		if (text != null)
		{
			dictionary.Add(text, P_1);
		}
		return dictionary;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzTool vATAFT7HML(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		EzTool result = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 2:
				result = null;
				X6DCAun4LT77jfrayXc();
				num = ((!qWfIXTn7IbIk60iYoB2()) ? 5 : 0);
				continue;
			case 3:
				obj = null;
				goto IL_0040;
			default:
				num = 6;
				continue;
			case 6:
				if (!cvsCellLocation.IsValid)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				result = WrlAbkIDX4(cvsCellLocation);
				num = 7;
				continue;
			case 1:
			case 5:
				if (P_0 != null)
				{
					obj = P_0.InputImage;
					goto IL_0040;
				}
				num = 3;
				continue;
			case 7:
				break;
				IL_0040:
				if (obj == null)
				{
					break;
				}
				cvsCellLocation = CvsCellLocation.TryParse((string)dYkZQjVq3VISB1qqFxs(OrDLWxV8gRJg3j4uJK9(P_0)));
				goto case 6;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CExposedProperties_003Ed__159))]
	protected override IEnumerable<CellViewModel> ExposedProperties(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CExposedProperties_003Ed__159(-2)
		{
			_003C_003E3__snippet = snippet
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<CellViewModel> pa7AXHuyRj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerable<CellViewModel> enumerable = JobPassFail?.Properties;
		return enumerable ?? Enumerable.Empty<CellViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<CellViewModel> GetLinkableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.SelectMany(ExposedProperties).Concat(pa7AXHuyRj());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePropertiesGrouped(CellViewModel targetProperty, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass162_0 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass162_0();
		CS_0024_003C_003E8__locals12._003C_003E4__this = this;
		CS_0024_003C_003E8__locals12.predicate = predicate;
		CS_0024_003C_003E8__locals12.targetProperty = targetProperty;
		if (CS_0024_003C_003E8__locals12.predicate == null)
		{
			CS_0024_003C_003E8__locals12.predicate = CellViewModel.oexw5f8eIR();
		}
		CS_0024_003C_003E8__locals12.dependentCells = GetDependentCells(new CvsCellRange(CS_0024_003C_003E8__locals12.targetProperty.CellLocation), recursive: true);
		IEnumerable<IGrouping<string, CellViewModel>> first = Snippets.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet tool) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals12._003C_003E4__this.ExposedProperties(tool);
		}, [MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet tool, CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { tool, prop };
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IsSourceableProperty(_003C_003Eh__TransparentIdentifier0.prop);
		}).GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.tool.Name;
		}, [MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.prop;
		});
		IEnumerable<IGrouping<string, CellViewModel>> second = pa7AXHuyRj().Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IsSourceableProperty(prop) && CS_0024_003C_003E8__locals12.predicate(prop);
		}).GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec__DisplayClass162_0.MxNrqAKZm4tfC9g2ReRq(CS_0024_003C_003E8__locals12._003C_003E4__this.JobPassFail);
		});
		return first.Concat(second);
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IsSourceableProperty(CellViewModel property)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass162_0.TLoaGNKZUW2GmI1FwFCT();
			int num = (_003C_003Ec__DisplayClass162_0.TMGZHoKZYZfZiH5pyLOF() ? 1 : 5);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (!_003C_003Ec__DisplayClass162_0.N2GELGKZQgp69jfrPSmE(property))
					{
						num = 2;
						continue;
					}
					goto case 4;
				case 4:
					if (!CS_0024_003C_003E8__locals12.dependentCells.Contains(_003C_003Ec__DisplayClass162_0.ynCDpPKZN4FbuBbdtCXe(property)))
					{
						num = 7;
						continue;
					}
					break;
				default:
					if (!(property is BlobsViewModel))
					{
						break;
					}
					num = 4;
					if (_003C_003Ec__DisplayClass162_0.TMGZHoKZYZfZiH5pyLOF())
					{
						continue;
					}
					goto case 2;
				case 2:
					if (!(property is InputImageViewModel))
					{
						num = 6;
						continue;
					}
					goto case 4;
				case 6:
					if (property is ImageViewModel)
					{
						goto case 4;
					}
					goto default;
				case 7:
					return CS_0024_003C_003E8__locals12.targetProperty.YJwH11Te4e(property);
				}
				break;
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass163_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass163_0();
		CS_0024_003C_003E8__locals11._003C_003E4__this = this;
		CS_0024_003C_003E8__locals11.targetProperty = targetProperty;
		CS_0024_003C_003E8__locals11.predicate = predicate;
		if (CS_0024_003C_003E8__locals11.predicate == null)
		{
			CS_0024_003C_003E8__locals11.predicate = CellViewModel.oexw5f8eIR();
		}
		IEnumerable<IGrouping<string, CellViewModel>> first = Snippets.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet tool) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals11._003C_003E4__this.ExposedProperties(tool);
		}, [MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet tool, CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { tool, prop };
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.prop.IsPrimitive && _003C_003Eh__TransparentIdentifier0.prop.YJwH11Te4e(CS_0024_003C_003E8__locals11.targetProperty) && CS_0024_003C_003E8__locals11.predicate(_003C_003Eh__TransparentIdentifier0.prop);
		}).GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.tool.Name;
		}, [MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.prop;
		});
		IEnumerable<IGrouping<string, CellViewModel>> second = pa7AXHuyRj().Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass163_0.PPremYKZh8JwLq39XMrK(prop) && _003C_003Ec__DisplayClass163_0.P0Ag9kKZtaoyvmfUoQaS(prop, CS_0024_003C_003E8__locals11.targetProperty) && CS_0024_003C_003E8__locals11.predicate(prop);
		}).GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel prop) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals11._003C_003E4__this.JobPassFail.Name;
		});
		return first.Concat(second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTool_AcceptAdd_003Ed__164))]
	private Task ITVAo669G5(object P_0, AcceptAddEventHandlerArgs P_1)
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
		goto IL_009a;
		IL_001a:
		_003CTool_AcceptAdd_003Ed__164 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_009a;
		IL_009a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				_ = 0;
				if (X6DCAun4LT77jfrayXc())
				{
					num = 6;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 2:
			case 4:
				stateMachine.e = P_1;
				goto case 0;
			default:
				num = 0;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptAdd_003Ed__165))]
	public Task AcceptAdd(EzTool tool)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CAcceptAdd_003Ed__165 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.tool = tool;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				qWfIXTn7IbIk60iYoB2();
				num = ((!X6DCAun4LT77jfrayXc()) ? 4 : 0);
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 5:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 6;
				if (0 == 0)
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
	internal void z9jASc0coS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler addCompleted = AddCompleted;
		if (addCompleted != null)
		{
			igRHPLVri8vPIWls3tE(addCompleted, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r4yADFiXZx(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		Action<int, EzTool> action = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				action = TWiA3kfexc;
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				if (!UpYcSOVpRifiHqfJCde(FgqmkYdnnf()))
				{
					num = 0;
					break;
				}
				goto IL_0091;
			case 5:
				return;
			case 8:
				return;
			case 0:
				if (((Thread)A7mDSxVXItaOs7oSbBY(FgqmkYdnnf())).ManagedThreadId == 1)
				{
					num = 1;
					break;
				}
				goto IL_0091;
			case 9:
				P_0.Remove += Snippet_RemoveAsync;
				X6DCAun4LT77jfrayXc();
				if (!qWfIXTn7IbIk60iYoB2())
				{
					num = 7;
					if (X6DCAun4LT77jfrayXc())
					{
						break;
					}
					goto case 2;
				}
				num = 5;
				break;
			case 2:
			case 7:
				P_0.Rename += Snippet_Rename;
				num = 4;
				break;
			case 1:
				HBxorjV9ZxPBeMgACR0(FgqmkYdnnf(), action, new object[2]
				{
					Snippets.Count(),
					P_0
				});
				return;
			case 3:
				P_0.DependencyChanged += Snippet_DependencyChanged;
				num = 9;
				break;
			case 4:
				P_0.Copy += Snippet_CopyAsync;
				num = 10;
				if (!X6DCAun4LT77jfrayXc())
				{
					return;
				}
				break;
			case 11:
				return;
				IL_0091:
				TWiA3kfexc(Snippets.Count(), P_0);
				num = 11;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TWiA3kfexc(int P_0, EzTool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Snippets.Insert(P_0, P_1);
		zIyNYXJes6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippet_003Ed__170))]
	public override Task RemoveSnippet(EzSnippet tool)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_006b:
		_003CRemoveSnippet_003Ed__170 stateMachine = default;
		stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
		num = 0;
		if (X6DCAun4LT77jfrayXc())
		{
			goto IL_0034;
		}
		goto IL_0087;
		IL_0087:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (X6DCAun4LT77jfrayXc())
		{
			goto IL_0034;
		}
		goto IL_00a5;
		IL_0034:
		switch (num)
		{
		case 2:
		case 5:
			break;
		case 4:
			goto IL_006b;
		case 6:
			goto IL_0087;
		default:
			goto IL_00a5;
		case 0:
			goto IL_00b9;
		case 7:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_001a;
		IL_001a:
		stateMachine.tool = tool;
		goto IL_00a5;
		IL_00a5:
		stateMachine._003C_003E1__state = -1;
		num = 6;
		if (true)
		{
			goto IL_0034;
		}
		goto IL_00b9;
		IL_00b9:
		stateMachine._003C_003E4__this = this;
		_ = 1;
		if (qWfIXTn7IbIk60iYoB2())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_006b;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSnippet_CopyAsync_003Ed__171))]
	protected override Task Snippet_CopyAsync(object sender, EventArgs args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CSnippet_CopyAsync_003Ed__171 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 0:
			case 2:
				stateMachine.sender = sender;
				goto case 6;
			default:
				num = 6;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!X6DCAun4LT77jfrayXc())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (X6DCAun4LT77jfrayXc())
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
	[AsyncStateMachine(typeof(_003CCopyToolData_003Ed__172))]
	private Task<byte[]> itEAIEepPY(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCopyToolData_003Ed__172 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.tool = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveAllSnippets_003Ed__173))]
	protected override Task RemoveAllSnippets(bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CRemoveAllSnippets_003Ed__173 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine.jobLoading = jobLoading;
				goto default;
			default:
				_ = 0;
				if (!X6DCAun4LT77jfrayXc())
				{
					num = 6;
					break;
				}
				num = 5;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 0;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMoveTool_003Ed__174))]
	public Task MoveTool(EzTool source, int sourceIndex, int insertIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X6DCAun4LT77jfrayXc();
		int num = (qWfIXTn7IbIk60iYoB2() ? 1 : 3);
		_003CMoveTool_003Ed__174 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine.sourceIndex = sourceIndex;
				goto case 2;
			default:
				num = 2;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine.source = source;
				num = 8;
				break;
			case 1:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 5;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 2:
				stateMachine.insertIndex = insertIndex;
				num = 7;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsEditableDisplayGraphic> GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Tools.Select([MethodImpl(MethodImplOptions.NoInlining)] (EzTool tool) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsEditableDisplayGraphic[])_003C_003Ec.pgWjpIKrABSSK1eL24Z8(tool);
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic[] graphics) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return graphics != null;
		}).SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic[] graphics) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return graphics;
		})
			.ToList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateJobPassFail_003Ed__181))]
	internal Task Ip9AfAmPAi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qWfIXTn7IbIk60iYoB2();
		int num;
		if (X6DCAun4LT77jfrayXc())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0074;
		IL_002a:
		_003CUpdateJobPassFail_003Ed__181 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (X6DCAun4LT77jfrayXc())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendGraphic_003Ed__182))]
	public Task SendGraphic(CvsEditableDisplayGraphic editableGraphic, CvsInSightDisplay inSightDisplay = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CSendGraphic_003Ed__182 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.inSightDisplay = inSightDisplay;
				goto default;
			default:
				qWfIXTn7IbIk60iYoB2();
				num = ((!X6DCAun4LT77jfrayXc()) ? 3 : 0);
				break;
			case 7:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 2;
				break;
			case 3:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 6:
				stateMachine.editableGraphic = editableGraphic;
				num = 1;
				break;
			case 0:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCompositeViewModelGraphic(CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		EditCompositeRegionViewModel editCompositeRegionViewModel = default;
		CvsDisplayableComposite cvsDisplayableComposite = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				editCompositeRegionViewModel = PPZfp7V7sI95slFWYoy(editableGraphic) as EditCompositeRegionViewModel;
				qWfIXTn7IbIk60iYoB2();
				if (X6DCAun4LT77jfrayXc())
				{
					num = 6;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 2:
				cvsDisplayableComposite = editableGraphic as CvsDisplayableComposite;
				goto default;
			case 0:
				wIbcigV3EFauIRe0jZZ(editCompositeRegionViewModel, cvsDisplayableComposite);
				num = 7;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				if (editCompositeRegionViewModel != null)
				{
					num = 2;
					if (X6DCAun4LT77jfrayXc())
					{
						break;
					}
					goto default;
				}
				return;
			default:
				if (cvsDisplayableComposite != null)
				{
					num = 0;
					break;
				}
				return;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendGraphic_003Ed__184))]
	public Task SendGraphic(CvsCellLocation loc, CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!X6DCAun4LT77jfrayXc())
		{
			goto IL_001e;
		}
		goto IL_0078;
		IL_001e:
		_003CSendGraphic_003Ed__184 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 7;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.loc = loc;
				num = 3;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				num = 5;
				continue;
			case 3:
				stateMachine.editableGraphic = editableGraphic;
				break;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (qWfIXTn7IbIk60iYoB2())
				{
					num = 6;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EzTool DVPAElEC8W(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (EzTool)btvmHNqEjR(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal EzTool WrlAbkIDX4(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (EzTool)dHomwE5fPG(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSnippet_RemoveAsync_003Ed__187))]
	protected override Task Snippet_RemoveAsync(object sender)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!qWfIXTn7IbIk60iYoB2())
		{
		}
		_003CSnippet_RemoveAsync_003Ed__187 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (X6DCAun4LT77jfrayXc())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				_ = 0;
				num = ((!X6DCAun4LT77jfrayXc()) ? 4 : 5);
				break;
			case 2:
				stateMachine.sender = sender;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IUndoAction U0qAcS9NOW(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new DeleteToolUndoAction(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPublishCellTags_003Ed__189))]
	public Task PublishCellTags(CvsInSight insight, CvsCellRange selectedRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CPublishCellTags_003Ed__189 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = GlPqcfn0UERm4MPJGCs();
				_ = 1;
				num = (qWfIXTn7IbIk60iYoB2() ? 3 : 2);
				continue;
			case 3:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 0:
				stateMachine.selectedRange = selectedRange;
				goto case 6;
			default:
				num = 6;
				if (!qWfIXTn7IbIk60iYoB2())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine.insight = insight;
				num = 0;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (X6DCAun4LT77jfrayXc())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string yaYAQONBAh(HashSet<string> P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass190_0 obj = new _003C_003Ec__DisplayClass190_0();
		obj.existingNames = P_0;
		Predicate<string> doesNameAlreadyExist = [MethodImpl(MethodImplOptions.NoInlining)] (string name) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return obj.existingNames.Contains(name);
		};
		return GenerateUniqueName(P_1, doesNameAlreadyExist);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GenerateUniqueName(string baseName, Predicate<string> doesNameAlreadyExist)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = baseName;
		int num = 1;
		while (doesNameAlreadyExist(text))
		{
			text = baseName + num;
			num++;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteCellInfos_003Ed__192))]
	private Task R2XAgO4Ykv(CvsInSight P_0, List<CvsCellInfo> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteCellInfos_003Ed__192 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.insight = P_0;
		stateMachine.newInfos = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.AddDefaultReferences(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__194))]
	Task ISnippetConsumer.RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X6DCAun4LT77jfrayXc();
		int num;
		if (!qWfIXTn7IbIk60iYoB2())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (qWfIXTn7IbIk60iYoB2())
			{
				goto IL_004a;
			}
		}
		goto IL_00a0;
		IL_00a0:
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__194 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 1:
			case 5:
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 4:
				stateMachine.e = e;
				goto case 2;
			default:
				num = 2;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_004a;
		IL_004a:
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_00a0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.RenameReferences(SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)JPpxfFVgxdISDlAvYfT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InspectStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HP83hfn3q5oFSZ7o1a9();
		tvvAxfHbyB = LogManager.GetLogger<InspectStepViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private ValueTask apKAMhmLUe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task G4hARKt0FV(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnEnterStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task yOIA40vKsY(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnLeaveStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static ToolCategory RFDAlE3uk5(ToolCategory P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ToolCategory toolCategory = new ToolCategory(P_0);
		toolCategory.SetToDefault();
		toolCategory.IsExpanded = (string)EV3a9hVjQ4c55QyRkHF(toolCategory) == Resources.F0Z0bUM6Xp();
		return toolCategory;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HP83hfn3q5oFSZ7o1a9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X6DCAun4LT77jfrayXc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qWfIXTn7IbIk60iYoB2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder YriCtsnjM4AqWpLFFJd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object imuQB1n68QytVntBDmd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FJhIpJnCre13JLO4EBC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N8QmtNnA2o3JprDHNFr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AIiZrNnRCrxY10X5PmI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).UpdateOnEditModeChange();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aonBrhnWbso2R3VGY15()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.vtuYncr2GF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FB1DnfnTkDBm4ktpVhP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.yVyYYjLOu8();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vCnYv5nyX86oB7wc8qO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GlPqcfn0UERm4MPJGCs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GicwY6nFcEAodTJxoyv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsJobAnalyzer)P_0).InSight = (CvsInSight)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jZ7Ak6nMm6WRdVj5ZBl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iJRmjZnYxFL363uNdNX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JobPassFail)P_0).Refresh((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wqkkugnUV1Fm4VrBe7Q(object P_0, CvsCellRange range, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippetType)P_0).NeedsUpdate(range, (CvsCellCollection)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder XEL57TnHLnIe7bi4eva()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TjQxywnx4JcwTwhwtoI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sjTN7rnmhQbO6FHUVJh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation qJC842nQgLNbuMfs9i9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Acquired2DImageLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qGfIh6nNm2Z8JYA5g8A(object P_0, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).GetSourceLinks(reqDataType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QYtWqRn2jLy3vFUlAfi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yN93WQncghuOkUqkFCY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<SourceLink>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MOGwdTn1CHSg1VvVGbR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oIFKEinu3KXFaivNb2l(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzToolType)P_0).Inspect = (InspectStepViewModel)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ljtPPBnhCN0fS846yv0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzToolType)P_0).CancelAdd += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rm5fnEntPQhTq75JWfT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<EzToolType>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uVMMGLnzloUjHfuTSlG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JrTwNFVLDdQj96jYm12(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AsyncDelegateCommand)P_0).CanInvoke();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JgLJvTVK7wks4e1cFF6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object flHP5rV5H4aGGuxJoOm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bygT0PVwEbaxlAsn0qK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<EzToolType>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lNj7DeVJpJTWoTl4XDN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A4ETe4Vag49AwfXOcuL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E7p8olVeuOWICWLxf0p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ws3SNtVOFhPAMyl96iK(object P_0, object P_1, StringComparison comparison)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1, comparison);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zLoERNVIOHbFKGBdgBq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Description;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k7Xe5aVDFXIL97fi1fj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Category;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sMO93wViaTb26p5jFEg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ToolCategory)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aT4jjTVnjWvRMnt0KcI(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ToolCategory)P_0).IsExpanded = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int r02dMmVV9MJ4kDL80m8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dde61UVfdKmm2f6FXQf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kLfc42VdgFfk6Mi4K0p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).ToolType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gCkgr2VlSUUrT3eSN1U(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JPpxfFVgxdISDlAvYfT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mGFHy5VsbuQrxeeK8vE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CQQs3xVvOopXApjTw2k(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void igRHPLVri8vPIWls3tE(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Axxv85VPlMYSlVjsmU0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).BeginInvoke((Delegate)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BCM0XkVZCyD73OO8WRH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation cG86fPVB2dBRHMCGnXY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ww00N0VbPhZkMPLZlHx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dictionary<string, object>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VabG47VGcMNwNunnCQi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fTFRxUVoCqvN8NMRZP8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kj9NvnVSP56B9MYdO16(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QLDssOVkBVmZ6WLHHa5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OrDLWxV8gRJg3j4uJK9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).InputImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dYkZQjVq3VISB1qqFxs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InputStructureViewModel)P_0).CellExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LlN4txVEW3DWFVlMrrM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UpYcSOVpRifiHqfJCde(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).CheckAccess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A7mDSxVXItaOs7oSbBY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).Thread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HBxorjV9ZxPBeMgACR0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).Invoke((Delegate)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ValueTask GDcct3V4ByfXZeUGah6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PPZfp7V7sI95slFWYoy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableGraphic)P_0).Tag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wIbcigV3EFauIRe0jZZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EditCompositeRegionViewModel)P_0).UpdateCompositeRegion((CvsDisplayableComposite)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EV3a9hVjQ4c55QyRkHF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ToolCategory)P_0).Name;
	}
}
