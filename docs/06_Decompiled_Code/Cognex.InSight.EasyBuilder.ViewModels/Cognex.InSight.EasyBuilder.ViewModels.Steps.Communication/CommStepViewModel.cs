using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common;
using Cognex.Common.Localization;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using Cognex.Utilities.Sdk.InSightController;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

[Shared]
[Export(typeof(AppStepViewModel))]
public class CommStepViewModel : AppStepViewModel, IInSightAppStep, ISnippetOwner, ISnippetConsumer
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (i0kdiB5a16smABDhKwsu() ? 4 : 3);
			int num2 = default;
			ValueTaskAwaiter awaiter = default;
			TaskAwaiter awaiter2 = default;
			ValueTask valueTask = default;
			CommStepViewModel commStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
								if (!QS8pWa5acHYMVAslleOM())
								{
									goto IL_0041;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 2;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
						}
						goto IL_0181;
						IL_0041:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							goto IL_0181;
						}
						goto IL_021b;
						IL_021b:
						awaiter.GetResult();
						goto end_IL_0024;
						IL_0181:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 0:
								num2 = (_003C_003E1__state = 1);
								num3 = 6;
								if (i0kdiB5a16smABDhKwsu())
								{
								}
								continue;
							case 8:
								valueTask = commStepViewModel.h13257fa9k();
								num3 = 9;
								continue;
							case 6:
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								if (i0kdiB5a16smABDhKwsu())
								{
								}
								continue;
							case 7:
								return;
							case 11:
								return;
							case 14:
								awaiter2 = commStepViewModel.RC72aFp3lv().GetAwaiter();
								_ = 0;
								if (QS8pWa5acHYMVAslleOM())
								{
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 10;
								}
								num3 = 7;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 15:
								return;
							case 1:
							case 12:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 3;
									if (i0kdiB5a16smABDhKwsu())
									{
									}
									continue;
								}
								goto case 4;
							case 4:
								awaiter2.GetResult();
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = valueTask.GetAwaiter();
								break;
							default:
								num3 = 5;
								if (QS8pWa5acHYMVAslleOM())
								{
									continue;
								}
								goto case 13;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 2:
								_003C_003Eu__2 = default;
								num3 = 13;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								continue;
							case 16:
								goto IL_021b;
							}
							break;
						}
						goto IL_0041;
						end_IL_0024:;
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
					if (QS8pWa5acHYMVAslleOM())
					{
						continue;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (QS8pWa5acHYMVAslleOM())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				commStepViewModel = _003C_003E4__this;
				num = 2;
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
		internal static bool QS8pWa5acHYMVAslleOM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i0kdiB5a16smABDhKwsu()
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
	private struct _003COnProtocolChanged_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

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
			goto IL_05ee;
			IL_001a:
			CommStepViewModel commStepViewModel = _003C_003E4__this;
			num = 2;
			goto IL_05ee;
			IL_05ee:
			int num2 = default;
			TaskAwaiter awaiter = default;
			RemoveProtocolUndoAction removeProtocolUndoAction = default;
			string undoBusyMessage = default;
			FfpType result = default;
			ChangeProtocolUndoAction action = default;
			FfpType result2 = default;
			UndoActionBlockingProgressWrapper undoActionBlockingProgressWrapper = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 4:
					num2 = _003C_003E1__state;
					HWd4Sl5ah8fgcdC0W6fQ();
					num = ((!Uh2aFo5auZoKML5Pl9gF()) ? 5 : 0);
					continue;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (Ln3gKH5atRR3k7BeR10O(commStepViewModel.XVh2WGEYOD))
							{
								num3 = 7;
							}
							else
							{
								if (commStepViewModel.Protocol != FfpType.None)
								{
									goto IL_00fa;
								}
								num3 = 2;
							}
							goto IL_0492;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 25;
							goto IL_0492;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 18;
							goto IL_0492;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 29;
							goto IL_0492;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
								goto IL_0492;
							}
							IL_00fa:
							if (commStepViewModel.Protocol == FfpType.None)
							{
								goto IL_0298;
							}
							num3 = 26;
							goto IL_0492;
							IL_0492:
							while (true)
							{
								switch (num3)
								{
								case 5:
									removeProtocolUndoAction = new RemoveProtocolUndoAction(commStepViewModel, commStepViewModel.FactoryProtocol.Name);
									num3 = 23;
									if (!HWd4Sl5ah8fgcdC0W6fQ())
									{
										continue;
									}
									return;
								case 11:
									return;
								case 21:
								case 27:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 28:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 22;
									continue;
								case 24:
									num2 = (_003C_003E1__state = -1);
									goto IL_00ee;
								case 18:
									_003C_003Eu__1 = default;
									num3 = 24;
									continue;
								case 8:
									return;
								case 0:
									return;
								case 19:
									awaiter.GetResult();
									num3 = 37;
									continue;
								case 36:
									num2 = (_003C_003E1__state = 0);
									HWd4Sl5ah8fgcdC0W6fQ();
									if (Uh2aFo5auZoKML5Pl9gF())
									{
										num3 = 34;
										if (!HWd4Sl5ah8fgcdC0W6fQ())
										{
											continue;
										}
										goto case 14;
									}
									num3 = 27;
									continue;
								case 14:
									awaiter.GetResult();
									awaiter = ((Task)f6pV755eO10YcZpoHKNO(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.FactoryProtocol, SnippetAddedEventType.Created))).GetAwaiter();
									num3 = 16;
									continue;
								case 13:
									undoBusyMessage = (string)DjabxY5e5YsYOkdFoVcN(CbR8P45eLUcPxD17tApX(), UoFNZJ5eKXP1YZKf0PXL(FfpTypeStringConverter, FfpType.None), UoFNZJ5eKXP1YZKf0PXL(FfpTypeStringConverter, result));
									num3 = 30;
									continue;
								case 20:
									action = new ChangeProtocolUndoAction(commStepViewModel, result2, commStepViewModel.Protocol);
									num3 = 17;
									continue;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto case 21;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									continue;
								case 30:
									undoActionBlockingProgressWrapper = new UndoActionBlockingProgressWrapper(commStepViewModel.OperationProgressManager, removeProtocolUndoAction, (string)QdZfoE5ewbYfARwWl9c7(removeProtocolUndoAction), undoBusyMessage);
									num3 = 33;
									continue;
								case 10:
									_003C_003Eu__1 = default;
									num3 = 15;
									continue;
								case 17:
									awaiter = ((UndoRedoQueue)qSN5N85eD2KiQTq7WD3k(PlOCtG5eJmYcIlN9QbdP(commStepViewModel))).AddUndo((IUndoAction)action).GetAwaiter();
									num3 = 31;
									continue;
								case 4:
									awaiter.GetResult();
									break;
								case 23:
									Enum.TryParse<FfpType>(((EditStringViewModel)BIikRL5azInvxUmELm60(commStepViewModel.FactoryProtocol)).Value, out result);
									num3 = 13;
									continue;
								case 33:
									awaiter = he3qDJ5eepGTka2Ie7tZ(wxXmLg5eaq3ThZVQUhbO(((CvsInSight)PlOCtG5eJmYcIlN9QbdP(commStepViewModel)).UndoHandler, undoActionBlockingProgressWrapper));
									num3 = 12;
									if (true)
									{
										continue;
									}
									return;
								case 22:
									return;
								case 7:
									break;
								case 26:
								{
									if (commStepViewModel.FactoryProtocol != null)
									{
										goto IL_0298;
									}
									AddProtocolUndoAction addProtocolUndoAction = new AddProtocolUndoAction(commStepViewModel, default, commStepViewModel.Protocol.ToString());
									awaiter = he3qDJ5eepGTka2Ie7tZ(wxXmLg5eaq3ThZVQUhbO(((CvsInSight)PlOCtG5eJmYcIlN9QbdP(commStepViewModel)).UndoHandler, addProtocolUndoAction));
									num3 = 32;
									if (Uh2aFo5auZoKML5Pl9gF())
									{
										continue;
									}
									goto case 32;
								}
								case 32:
									if (awaiter.IsCompleted)
									{
										goto case 14;
									}
									num3 = 6;
									if (!HWd4Sl5ah8fgcdC0W6fQ())
									{
										continue;
									}
									goto case 12;
								case 12:
									if (awaiter.IsCompleted)
									{
										goto IL_00ee;
									}
									num3 = 36;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
									if (commStepViewModel.FactoryProtocol?.GEu2LkjbgE() != null && Enum.TryParse<FfpType>((string)VqtT1n5eI2sYCyUrKC1t(BIikRL5azInvxUmELm60(commStepViewModel.FactoryProtocol)), out result2))
									{
										num3 = 20;
										if (HWd4Sl5ah8fgcdC0W6fQ())
										{
										}
										continue;
									}
									goto end_IL_004d;
								case 9:
								case 34:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									continue;
								case 16:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 3;
										continue;
									}
									goto case 4;
								case 2:
									goto IL_0440;
								case 25:
									_003C_003Eu__1 = default;
									num3 = 35;
									continue;
								case 29:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto case 14;
								default:
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 35:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 31:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__1 = awaiter;
										num3 = 28;
										continue;
									}
									goto case 19;
								case 37:
									break;
									IL_00ee:
									awaiter.GetResult();
									break;
								}
								break;
								IL_0440:
								if (commStepViewModel.FactoryProtocol != null)
								{
									num3 = 5;
									continue;
								}
								goto IL_00fa;
							}
							goto end_IL_004c;
							IL_0298:
							if (commStepViewModel.Protocol == FfpType.None)
							{
								break;
							}
							num3 = 1;
							goto IL_0492;
							end_IL_004d:
							break;
						}
						throw new InvalidOperationException((string)mvLBgD5eiTUiwloVh3n8(51632));
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
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
		internal static bool Ln3gKH5atRR3k7BeR10O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).IsNonZero;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BIikRL5azInvxUmELm60(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FactoryProtocol)P_0).GEu2LkjbgE();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CbR8P45eLUcPxD17tApX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.znyhSQ8CwN();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UoFNZJ5eKXP1YZKf0PXL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TypeConverter)P_0).ConvertToString(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DjabxY5e5YsYOkdFoVcN(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QdZfoE5ewbYfARwWl9c7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseSnippetAddRemoveAction)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PlOCtG5eJmYcIlN9QbdP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wxXmLg5eaq3ThZVQUhbO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter he3qDJ5eepGTka2Ie7tZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f6pV755eO10YcZpoHKNO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VqtT1n5eI2sYCyUrKC1t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditStringViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qSN5N85eD2KiQTq7WD3k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mvLBgD5eiTUiwloVh3n8(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uh2aFo5auZoKML5Pl9gF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HWd4Sl5ah8fgcdC0W6fQ()
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
	private struct _003CBeginInitialization_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (D2bOHJ5eVyfCZFvXebB4() ? 2 : 4);
			CommStepViewModel commStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					commStepViewModel = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = CGdbFs5ef9MjKEFaTwC7(commStepViewModel.RC72aFp3lv());
							D2bOHJ5eVyfCZFvXebB4();
							if (HqOL0R5enDIBhpIJw2hO())
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_0065;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						goto IL_009b;
						IL_0065:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_009b;
						IL_009b:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								if (!D2bOHJ5eVyfCZFvXebB4())
								{
									continue;
								}
								return;
							case 2:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (HqOL0R5enDIBhpIJw2hO())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 3;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 3:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								commStepViewModel.rjNe0RHViX();
								goto end_IL_009b;
							}
							goto IL_0065;
							continue;
							end_IL_009b:
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
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static TaskAwaiter CGdbFs5ef9MjKEFaTwC7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HqOL0R5enDIBhpIJw2hO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D2bOHJ5eVyfCZFvXebB4()
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
	private struct _003CCompleteInitializationAsync_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		public ISnippetManager snippetManager;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private WriteImageFtp _003CwriteImage_003E5__2;

		private WriteDataFtp _003CwriteData_003E5__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!rHlEvV5elQKei7iyE1Fe())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			CommStepViewModel commStepViewModel = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<EzSupportSnippet> awaiter = default;
			WriteTcpIp value = default;
			WriteDataSerial value2 = default;
			int num2 = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!rHlEvV5elQKei7iyE1Fe())
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							commStepViewModel.SnippetManager = snippetManager;
							num3 = 84;
							if (1 == 0)
							{
								goto IL_0095;
							}
							goto IL_052c;
						case 3:
							awaiter2 = _003C_003Eu__2;
							num3 = 62;
							goto IL_052c;
						case 12:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 76;
							if (false)
							{
								goto IL_020f;
							}
							goto IL_052c;
						case 9:
							awaiter2 = _003C_003Eu__2;
							num3 = 48;
							goto IL_052c;
						case 7:
							awaiter2 = _003C_003Eu__2;
							num3 = 89;
							goto IL_052c;
						case 5:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 30;
							if (1 == 0)
							{
								goto IL_041a;
							}
							goto IL_052c;
						case 11:
							awaiter2 = _003C_003Eu__2;
							num3 = 5;
							goto IL_052c;
						case 4:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 15;
							goto IL_052c;
						case 8:
							awaiter = _003C_003Eu__1;
							num3 = 83;
							if (0 == 0)
							{
								goto IL_052c;
							}
							goto IL_07ae;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 77;
							goto IL_052c;
						case 13:
							awaiter2 = _003C_003Eu__2;
							num3 = 80;
							goto IL_052c;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 28;
							goto IL_052c;
						case 6:
							awaiter2 = _003C_003Eu__2;
							num3 = 6;
							goto IL_052c;
						case 10:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 40;
							if (1 == 0)
							{
								return;
							}
							goto IL_052c;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 55;
								goto IL_052c;
							}
							IL_052c:
							while (true)
							{
								ReadDataSerial value4;
								switch (num3)
								{
								case 45:
									break;
								case 6:
									_003C_003Eu__2 = default;
									num3 = 63;
									continue;
								case 73:
								{
									WriteFtpSettings value3 = awaiter.GetResult() as WriteFtpSettings;
									commStepViewModel.WriteFtpSettings = value3;
									num3 = 78;
									continue;
								}
								case 81:
									awaiter = commStepViewModel.PmG2bZgFnW.OfType<WriteDataSerialType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
										.GetAwaiter();
									num3 = 92;
									continue;
								case 72:
									_003C_003Eu__1 = awaiter;
									num3 = 65;
									continue;
								case 18:
									commStepViewModel.WriteTcpIp = value;
									num3 = 32;
									continue;
								case 42:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 61;
								case 61:
									commStepViewModel.WriteDataSerial = value2;
									num3 = 41;
									continue;
								case 29:
									if (commStepViewModel.WriteTcpIp == null)
									{
										num3 = 96;
										continue;
									}
									goto case 20;
								case 41:
									awaiter2 = FG32qa5esZqUTNC4APcD(gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.WriteDataSerial, SnippetAddedEventType.Created)));
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 11);
										num3 = 64;
										continue;
									}
									goto case 93;
								case 87:
									return;
								case 13:
								case 31:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 79:
									num2 = (_003C_003E1__state = 12);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 49:
									goto IL_020f;
								case 60:
									return;
								case 23:
									commStepViewModel.WriteDataFtp = _003CwriteData_003E5__3;
									awaiter2 = FG32qa5esZqUTNC4APcD(gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.WriteDataFtp, SnippetAddedEventType.Created)));
									num3 = 88;
									if (0 == 0)
									{
										continue;
									}
									goto case 32;
								case 32:
									awaiter2 = ((Task)gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.WriteTcpIp, SnippetAddedEventType.Created))).GetAwaiter();
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 89;
								case 89:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 82;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									return;
								case 34:
									return;
								case 16:
									awaiter = commStepViewModel.PmG2bZgFnW.OfType<WriteFtpSettingsType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
										.GetAwaiter();
									if (awaiter.IsCompleted)
									{
										goto case 73;
									}
									num2 = (_003C_003E1__state = 0);
									num3 = 72;
									if (0 == 0)
									{
										continue;
									}
									goto case 58;
								case 58:
									num2 = (_003C_003E1__state = -1);
									num3 = 73;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 52;
								case 52:
									if (commStepViewModel.ReadDataSerial == null)
									{
										num3 = 75;
										continue;
									}
									goto end_IL_0040;
								case 9:
									num2 = (_003C_003E1__state = 8);
									num3 = 36;
									continue;
								case 22:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 69;
										continue;
									}
									goto case 3;
								case 75:
									awaiter = commStepViewModel.PmG2bZgFnW.OfType<ReadDataSerialType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
										.GetAwaiter();
									num3 = 74;
									continue;
								case 59:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto case 77;
								case 0:
									if (commStepViewModel.WriteDataFtp == null)
									{
										num3 = 2;
										continue;
									}
									goto case 29;
								case 37:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 70;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									return;
								case 69:
									return;
								case 50:
									goto IL_041a;
								case 88:
									if (!awaiter2.IsCompleted)
									{
										num3 = 7;
										if (0 == 0)
										{
											continue;
										}
										goto case 77;
									}
									goto case 82;
								case 77:
									result = awaiter.GetResult();
									num3 = 95;
									continue;
								case 57:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 60;
									continue;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 26;
									continue;
								case 39:
									_003C_003Eu__1 = awaiter;
									num3 = 19;
									continue;
								case 76:
									num2 = (_003C_003E1__state = -1);
									goto IL_04b6;
								case 94:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 51;
									if (rHlEvV5elQKei7iyE1Fe())
									{
									}
									continue;
								case 7:
									num2 = (_003C_003E1__state = 7);
									break;
								default:
									num3 = 45;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									return;
								case 70:
									return;
								case 2:
									awaiter = commStepViewModel.PmG2bZgFnW.OfType<WriteDataFtpType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
										.GetAwaiter();
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto case 85;
								case 85:
									_003C_003Eu__2 = awaiter2;
									num3 = 68;
									continue;
								case 46:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 25:
									_003C_003Eu__1 = awaiter;
									num3 = 94;
									continue;
								case 67:
									_003C_003Eu__2 = awaiter2;
									num3 = 46;
									if (rHlEvV5elQKei7iyE1Fe())
									{
									}
									continue;
								case 36:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 40:
									goto IL_07ae;
								case 80:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 98;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
									awaiter2.GetResult();
									_003CwriteImage_003E5__2 = null;
									num3 = 0;
									continue;
								case 51:
									return;
								case 54:
									value2 = awaiter.GetResult() as WriteDataSerial;
									num3 = 61;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								case 11:
									awaiter2.GetResult();
									goto IL_0846;
								case 68:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 82:
									awaiter2.GetResult();
									num3 = 38;
									if (rHlEvV5elQKei7iyE1Fe())
									{
									}
									continue;
								case 62:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_08d1;
								case 64:
									_003C_003Eu__2 = awaiter2;
									num3 = 37;
									continue;
								case 21:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__2 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 87;
										continue;
									}
									goto IL_08d1;
								case 66:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 17;
									continue;
								case 92:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 10);
										num3 = 39;
										continue;
									}
									goto case 54;
								case 84:
									if (commStepViewModel.WriteFtpSettings != null)
									{
										goto IL_0846;
									}
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto case 28;
								case 28:
									_003C_003Eu__2 = default;
									HqEVcG5ed22XmSTd1nD8();
									if (!rHlEvV5elQKei7iyE1Fe())
									{
										num3 = 31;
										if (0 == 0)
										{
											continue;
										}
										goto case 48;
									}
									num3 = 20;
									continue;
								case 48:
									_003C_003Eu__2 = default;
									num3 = 90;
									continue;
								case 44:
									return;
								case 56:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										num3 = 67;
										continue;
									}
									goto case 1;
								case 33:
									if (!awaiter2.IsCompleted)
									{
										num3 = 50;
										if (true)
										{
											continue;
										}
										goto case 65;
									}
									goto case 98;
								case 65:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 96;
								case 96:
									awaiter = commStepViewModel.PmG2bZgFnW.OfType<WriteTcpIpType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
										.GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 10;
								case 4:
									num2 = (_003C_003E1__state = 2);
									num3 = 25;
									continue;
								case 55:
									_003C_003Eu__1 = default;
									num3 = 58;
									continue;
								case 63:
									num2 = (_003C_003E1__state = -1);
									num3 = 35;
									continue;
								case 27:
									awaiter2 = FG32qa5esZqUTNC4APcD(commStepViewModel.WriteFtpSettings.LinkWriteDataServerSettings(_003CwriteData_003E5__3));
									num3 = 91;
									if (!rHlEvV5elQKei7iyE1Fe())
									{
										continue;
									}
									goto case 35;
								case 35:
									awaiter2.GetResult();
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 12;
								case 12:
									if (!awaiter2.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto case 86;
								case 91:
									if (!awaiter2.IsCompleted)
									{
										num3 = 49;
										continue;
									}
									goto case 35;
								case 10:
									value = awaiter.GetResult() as WriteTcpIp;
									num3 = 18;
									continue;
								case 53:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									num3 = 43;
									continue;
								case 83:
									_003C_003Eu__1 = default;
									num3 = 42;
									continue;
								case 5:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 93;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 86;
								case 86:
									awaiter2.GetResult();
									goto case 20;
								case 97:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 34;
									continue;
								case 78:
									awaiter2 = FG32qa5esZqUTNC4APcD(gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.WriteFtpSettings, SnippetAddedEventType.Created)));
									if (!awaiter2.IsCompleted)
									{
										num3 = 53;
										continue;
									}
									goto case 11;
								case 95:
									_003CwriteImage_003E5__2 = result as WriteImageFtp;
									awaiter2 = FG32qa5esZqUTNC4APcD(commStepViewModel.WriteFtpSettings.LinkWriteImageServerSettings(_003CwriteImage_003E5__2));
									num3 = 21;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 9);
									num3 = 24;
									continue;
								case 43:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 44;
									if (0 == 0)
									{
										continue;
									}
									goto case 93;
								case 93:
									awaiter2.GetResult();
									num3 = 52;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 3;
								case 3:
									result = awaiter.GetResult();
									num3 = 47;
									continue;
								case 17:
									return;
								case 38:
									_003CwriteData_003E5__3 = null;
									num3 = 29;
									continue;
								case 30:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 74:
									if (!awaiter.IsCompleted)
									{
										num3 = 79;
										continue;
									}
									goto IL_04b6;
								case 90:
									num2 = (_003C_003E1__state = -1);
									num3 = 86;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 47;
								case 47:
									_003CwriteData_003E5__3 = result as WriteDataFtp;
									num3 = 27;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									return;
								case 26:
									return;
								case 8:
									return;
								case 20:
								case 71:
									if (commStepViewModel.WriteDataSerial == null)
									{
										num3 = 81;
										continue;
									}
									goto case 52;
								case 24:
									_003C_003Eu__2 = awaiter2;
									num3 = 57;
									if (HqEVcG5ed22XmSTd1nD8())
									{
										continue;
									}
									goto case 98;
								case 98:
									{
										awaiter2.GetResult();
										goto end_IL_0040;
									}
									IL_08d1:
									awaiter2.GetResult();
									commStepViewModel.WriteImageFtp = _003CwriteImage_003E5__2;
									awaiter2 = FG32qa5esZqUTNC4APcD(gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.WriteImageFtp, SnippetAddedEventType.Created)));
									num3 = 56;
									continue;
									IL_0846:
									if (commStepViewModel.WriteImageFtp == null)
									{
										awaiter = commStepViewModel.PmG2bZgFnW.OfType<WriteImageFtpType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
											.GetAwaiter();
										num3 = 59;
										continue;
									}
									goto case 0;
									IL_04b6:
									value4 = awaiter.GetResult() as ReadDataSerial;
									commStepViewModel.ReadDataSerial = value4;
									awaiter2 = ((Task)gUX8Jm5egEpoj7qaPfGs(commStepViewModel, new SnippetAddedEventArgs(commStepViewModel.ReadDataSerial, SnippetAddedEventType.Created))).GetAwaiter();
									num3 = 33;
									continue;
								}
								break;
							}
							goto IL_0095;
							IL_07ae:
							num2 = (_003C_003E1__state = -1);
							num3 = 54;
							goto IL_052c;
							IL_041a:
							num2 = (_003C_003E1__state = 13);
							num3 = 85;
							goto IL_052c;
							IL_020f:
							num2 = (_003C_003E1__state = 6);
							num3 = 66;
							goto IL_052c;
							IL_0095:
							_003C_003Eu__2 = awaiter2;
							num3 = 97;
							goto IL_052c;
							end_IL_0040:
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
					continue;
				case 1:
				case 5:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				commStepViewModel = _003C_003E4__this;
				num = 2;
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
		internal static object gUX8Jm5egEpoj7qaPfGs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FG32qa5esZqUTNC4APcD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HqEVcG5ed22XmSTd1nD8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rHlEvV5elQKei7iyE1Fe()
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
	private struct _003CAddFactoryProtocol_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XdpBf95erXuqcyLhUcfp();
			int num = ((!rJOvR85evaZm8JA0GheW()) ? 4 : 5);
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<EzSupportSnippet> awaiter2 = default;
			FactoryProtocol value = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					commStepViewModel = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_0203;
							}
							num3 = 14;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 10;
							if (!rJOvR85evaZm8JA0GheW())
							{
								goto IL_00cf;
							}
						}
						goto IL_00e8;
						IL_0203:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_00e8;
						IL_00e8:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__2 = awaiter;
								num3 = 9;
								continue;
							case 4:
								break;
							case 5:
								return;
							case 11:
								goto IL_00cf;
							default:
								num3 = 4;
								if (rJOvR85evaZm8JA0GheW())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
									return;
								}
								goto case 16;
							case 12:
							case 15:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								continue;
							case 2:
								value = awaiter2.GetResult() as FactoryProtocol;
								num3 = 11;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 0;
								if (rJOvR85evaZm8JA0GheW())
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 5;
									continue;
								}
								goto case 2;
							case 3:
							case 13:
								goto IL_0203;
							case 14:
								awaiter2 = commStepViewModel.PmG2bZgFnW.OfType<FactoryProtocolType>().First().AddSupportSnippet(commStepViewModel.SnippetManager)
									.GetAwaiter();
								num3 = 7;
								continue;
							case 9:
								goto IL_024d;
							case 16:
								awaiter.GetResult();
								goto end_IL_0065;
							}
							break;
							IL_024d:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							rJOvR85evaZm8JA0GheW();
							num3 = ((!XdpBf95erXuqcyLhUcfp()) ? 15 : 3);
						}
						goto IL_008e;
						IL_008e:
						awaiter = hhHLTo5ePO1t5rhTJs2k(commStepViewModel.FireSnippetAdded(new SnippetAddedEventArgs(commStepViewModel.FactoryProtocol, SnippetAddedEventType.Created)));
						num3 = 1;
						if (false)
						{
							return;
						}
						goto IL_00e8;
						IL_00cf:
						commStepViewModel.FactoryProtocol = value;
						goto IL_008e;
						end_IL_0065:;
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
					if (1 == 0)
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
		internal static TaskAwaiter hhHLTo5ePO1t5rhTJs2k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rJOvR85evaZm8JA0GheW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XdpBf95erXuqcyLhUcfp()
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
	private struct _003COnEnterStep_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		public StepBase previousStep;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CommStepViewModel commStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					commStepViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = dZT6rA5ebj6NUlFouTLo(commStepViewModel.rab2p7ym4N(previousStep));
							num3 = 6;
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
							case 5:
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (!WCm8Ye5eBAKqrhWK0ZZk())
									{
										num3 = 7;
										if (WCm8Ye5eBAKqrhWK0ZZk())
										{
										}
										continue;
									}
									num3 = 4;
									if (XeSUAy5eZxxlgtPC5sPg())
									{
										continue;
									}
									break;
								}
								goto case 9;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 10:
								break;
							}
							break;
						}
						commStepViewModel.i7jeJjQ1GX();
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
				case 4:
					num2 = _003C_003E1__state;
					XeSUAy5eZxxlgtPC5sPg();
					num = (WCm8Ye5eBAKqrhWK0ZZk() ? 5 : 0);
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
		internal static TaskAwaiter dZT6rA5ebj6NUlFouTLo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XeSUAy5eZxxlgtPC5sPg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WCm8Ye5eBAKqrhWK0ZZk()
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
	private struct _003COnLeaveStep_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

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
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					commStepViewModel = _003C_003E4__this;
					yALfGV5eoOt3fCDwSOkG();
					if (Cgj94o5eG5qcAKoyGmfI())
					{
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 2;
					}
					num = 0;
					if (false)
					{
						return;
					}
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = commStepViewModel.VP62U8t2Xg(nextStep).GetAwaiter();
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									Cgj94o5eG5qcAKoyGmfI();
									if (!yALfGV5eoOt3fCDwSOkG())
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									}
									num3 = 0;
									if (!yALfGV5eoOt3fCDwSOkG())
									{
										continue;
									}
									return;
								}
								goto case 3;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 3:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							case 8:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 10:
								commStepViewModel.c1b2o4Dse8(null);
								break;
							}
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
		internal static bool Cgj94o5eG5qcAKoyGmfI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yALfGV5eoOt3fCDwSOkG()
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
	private struct _003CCommStepViewModel_PropertyChanged_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public CommStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0238;
			IL_001a:
			CommStepViewModel commStepViewModel = _003C_003E4__this;
			_ = 0;
			if (rggw0d5eSgSC4Sd9xeno())
			{
				num = 4;
				if (!rggw0d5eSgSC4Sd9xeno())
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 0;
			}
			goto IL_0238;
			IL_0238:
			int num2 = default;
			string text = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 5:
					goto IL_003d;
				case 2:
				case 4:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								text = (string)BY0WZl5e8F7ZRv89kDSe(e);
								num3 = 4;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
								if (!rggw0d5eSgSC4Sd9xeno())
								{
									goto IL_0089;
								}
							}
							goto IL_00a4;
							IL_00fa:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							_ = 0;
							if (rggw0d5eSgSC4Sd9xeno())
							{
								num3 = 3;
								if (YEYIhG5ekvdrA3SMDpMj())
								{
								}
							}
							else
							{
								num3 = 5;
							}
							goto IL_00a4;
							IL_0089:
							num2 = (_003C_003E1__state = 0);
							goto IL_00fa;
							IL_00a4:
							while (true)
							{
								switch (num3)
								{
								case 3:
								case 6:
									return;
								case 0:
									break;
								default:
									num3 = 2;
									continue;
								case 9:
									awaiter.GetResult();
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto IL_00fa;
								case 2:
									goto IL_00fa;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto case 9;
								case 1:
									goto end_IL_0051;
								case 10:
									goto IL_0160;
								case 4:
									goto IL_017f;
								case 5:
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (rggw0d5eSgSC4Sd9xeno())
									{
										continue;
									}
									goto case 11;
								case 11:
									_003C_003Eu__1 = default;
									goto case 5;
								case 12:
									goto end_IL_0051;
								}
								break;
								IL_017f:
								if (fqKD5q5eEC1xlV8GuboK(text, djUtND5eqU6vchNwCqGD(29110)))
								{
									awaiter = Al6KwE5eph92cgVblEIM(commStepViewModel.Ps1eVhNAWQ());
									num3 = 7;
								}
								else
								{
									num3 = 10;
								}
								continue;
								IL_0160:
								if (!fqKD5q5eEC1xlV8GuboK(text, djUtND5eqU6vchNwCqGD(2274)))
								{
									num3 = 1;
									continue;
								}
								commStepViewModel.i7jeJjQ1GX();
								goto end_IL_0051;
							}
							goto IL_0089;
							end_IL_0051:;
						}
						catch (Exception ex)
						{
							ATKnn95e90LXv0Wdw42O(JnD2EyMtIT, Msxef25eXJpmaBaqBTmK(ex), ex);
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (YEYIhG5ekvdrA3SMDpMj())
					{
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_003d:
			num2 = _003C_003E1__state;
			num = 1;
			goto IL_0238;
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
		internal static object BY0WZl5e8F7ZRv89kDSe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object djUtND5eqU6vchNwCqGD(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fqKD5q5eEC1xlV8GuboK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Al6KwE5eph92cgVblEIM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Msxef25eXJpmaBaqBTmK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ATKnn95e90LXv0Wdw42O(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rggw0d5eSgSC4Sd9xeno()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YEYIhG5ekvdrA3SMDpMj()
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
	private struct _003CJobManagement_JobLoaded_003Ed__75 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!FXkHW05e7Xl9mb27CpZm())
			{
			}
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					commStepViewModel = _003C_003E4__this;
					FXkHW05e7Xl9mb27CpZm();
					num = ((!ONsKeK5e4kWVIKVuT3Cg()) ? 1 : 5);
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = DGeH9O5e3cujs0BlmSmI(commStepViewModel.oDXehJ1f06());
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							IL_00f9:
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 6:
								while (true)
								{
									num2 = (_003C_003E1__state = 0);
									FXkHW05e7Xl9mb27CpZm();
									if (ONsKeK5e4kWVIKVuT3Cg())
									{
										break;
									}
									num3 = 4;
									if (false)
									{
										continue;
									}
									goto IL_00f9;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 7:
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
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
		internal static TaskAwaiter DGeH9O5e3cujs0BlmSmI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ONsKeK5e4kWVIKVuT3Cg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FXkHW05e7Xl9mb27CpZm()
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
	private struct _003CResetFactoryProtocol_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (commStepViewModel.FactoryProtocol != null)
							{
								num3 = 8;
								goto IL_004c;
							}
							goto IL_0179;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00bc;
						IL_0179:
						commStepViewModel.xLge8fEcnH(FfpType.None);
						goto end_IL_0018;
						IL_00d8:
						commStepViewModel.FactoryProtocol = null;
						num3 = 12;
						goto IL_004c;
						IL_00bc:
						_003C_003Eu__1 = default;
						num3 = 10;
						if (hDmDoc5ejjldLphyna3F())
						{
							goto IL_004c;
						}
						goto IL_00d8;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 6:
							case 7:
								break;
							case 11:
								goto IL_00d8;
							case 8:
								valueTask = commStepViewModel.FactoryProtocol.DisposeAsync();
								num3 = 5;
								continue;
							case 2:
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (!xtq9en5e6Pg7f3X8faEQ())
									{
										continue;
									}
									goto case 10;
								}
								goto IL_0124;
							case 10:
								num2 = (_003C_003E1__state = -1);
								goto IL_0124;
							case 5:
								goto IL_013f;
							case 1:
								return;
							case 12:
								goto IL_0179;
								IL_0124:
								awaiter.GetResult();
								num3 = 11;
								if (xtq9en5e6Pg7f3X8faEQ())
								{
								}
								continue;
							}
							break;
							IL_013f:
							awaiter = valueTask.GetAwaiter();
							_ = 0;
							num3 = ((!hDmDoc5ejjldLphyna3F()) ? 6 : 4);
						}
						goto IL_00bc;
						end_IL_0018:;
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
					if (xtq9en5e6Pg7f3X8faEQ())
					{
					}
					continue;
				case 0:
				case 1:
					commStepViewModel = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (xtq9en5e6Pg7f3X8faEQ() ? 4 : 0);
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
		internal static bool hDmDoc5ejjldLphyna3F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xtq9en5e6Pg7f3X8faEQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public CellViewModel targetProperty;

		public Func<CellViewModel, bool> predicate;

		public CommStepViewModel _003C_003E4__this;

		public EzSnippet snippet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass93_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TVoAOv5eRsyTQUf1mgLB();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesFromSnippet_003Eb__0(CellViewModel property)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Ht9TOO5eWOAYbEYUbaIw(property) && dRsFor5eTuVGLQ92nuTx(property, targetProperty))
			{
				return predicate(property);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePrimitivesFromSnippet_003Eb__1(CellViewModel property)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)DYxEk95e0QiBI50kkStw(_003C_003E4__this.WgN2ceLdo8, PpaVMc5eyC78t9yIAXjV(snippet));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TVoAOv5eRsyTQUf1mgLB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qLaLTQ5eCrBriqhPCD8w()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fbkBoX5eAyksa0PYPRFD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ht9TOO5eWOAYbEYUbaIw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).IsPrimitive;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dRsFor5eTuVGLQ92nuTx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).YJwH11Te4e((CellViewModel)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PpaVMc5eyC78t9yIAXjV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DYxEk95e0QiBI50kkStw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass96_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			coq6yO5eYkGwopCSISQk(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSupports_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void coq6yO5eYkGwopCSISQk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mqPTbI5eFX6vaivwAc8r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TyIXHv5eMjredgCYSJD7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass97_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lfJo255exwdLBjOUBlUb();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lfJo255exwdLBjOUBlUb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zLcWAO5eUfgkPmATWZrt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool murTMc5eH0OofdDfS8NS()
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public CommStepViewModel _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange snippetRange;

		public SnippetAddedEventType action;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CYMZ935eQgneT1T1ZxES();
			int num;
			if (PF6tYe5emKC4wjk81Q3X())
			{
				num = 5;
				if (!PF6tYe5emKC4wjk81Q3X())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_09f5;
			IL_0a4a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (CYMZ935eQgneT1T1ZxES())
			{
				return;
			}
			goto IL_09f5;
			IL_09f5:
			CommStepViewModel commStepViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 3;
				case 3:
					commStepViewModel = _003C_003E4__this;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 1:
					goto IL_0a4a;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				_003C_003Ec__DisplayClass97_0 obj = default;
				int num3;
				TaskAwaiter<EzSupportSnippet> awaiter = default;
				TaskAwaiter awaiter2 = default;
				EzSnippet ezSnippet = default;
				EzSupportSnippet result = default;
				EzSupportSnippetType ezSupportSnippetType = default;
				ReadDataSerialType readDataSerialType = default;
				WriteDataFtpType writeDataFtpType = default;
				WriteTcpIpType writeTcpIpType = default;
				WriteFtpSettingsType writeFtpSettingsType = default;
				WriteImageFtpType writeImageFtpType = default;
				switch (num2)
				{
				default:
					obj = new _003C_003Ec__DisplayClass97_0();
					num3 = 7;
					if (false)
					{
						goto IL_0066;
					}
					goto IL_07b6;
				case 4:
					awaiter = _003C_003Eu__1;
					num3 = 46;
					if (1 == 0)
					{
						goto IL_072b;
					}
					goto IL_07b6;
				case 6:
					awaiter = _003C_003Eu__1;
					num3 = 62;
					if (CYMZ935eQgneT1T1ZxES())
					{
						goto IL_01cd;
					}
					goto IL_07b6;
				case 0:
					awaiter = _003C_003Eu__1;
					num3 = 12;
					goto IL_07b6;
				case 7:
					awaiter2 = _003C_003Eu__2;
					num3 = 22;
					goto IL_07b6;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 51;
					if (CYMZ935eQgneT1T1ZxES())
					{
					}
					goto IL_07b6;
				case 5:
					awaiter = _003C_003Eu__1;
					num3 = 3;
					if (1 == 0)
					{
						goto IL_06e2;
					}
					goto IL_07b6;
				case 2:
					awaiter = _003C_003Eu__1;
					num3 = 53;
					goto IL_07b6;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_05a5;
					}
					IL_07b6:
					while (true)
					{
						switch (num3)
						{
						case 56:
							break;
						case 33:
							num2 = (_003C_003E1__state = 7);
							num3 = 17;
							continue;
						case 18:
							num2 = (_003C_003E1__state = 4);
							num3 = 8;
							continue;
						case 27:
							ezSnippet = commStepViewModel.WriteDataSerial;
							goto IL_072b;
						case 70:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 57;
							if (PF6tYe5emKC4wjk81Q3X())
							{
								continue;
							}
							goto case 13;
						case 13:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 2;
							continue;
						case 26:
							commStepViewModel.WriteImageFtp = result as WriteImageFtp;
							ezSnippet = commStepViewModel.WriteImageFtp;
							num3 = 69;
							continue;
						case 7:
							obj.guid = guid;
							ezSupportSnippetType = commStepViewModel.PmG2bZgFnW.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0);
							ezSnippet = null;
							_ = 0;
							if (PF6tYe5emKC4wjk81Q3X())
							{
								num3 = 61;
								continue;
							}
							num3 = 50;
							if (0 == 0)
							{
								continue;
							}
							goto case 49;
						case 57:
							return;
						case 30:
							return;
						case 12:
							goto IL_01cd;
						case 49:
							commStepViewModel.WriteDataFtp = result as WriteDataFtp;
							ezSnippet = commStepViewModel.WriteDataFtp;
							num3 = 5;
							continue;
						case 40:
							commStepViewModel.WriteFtpSettings = result as WriteFtpSettings;
							ezSnippet = commStepViewModel.WriteFtpSettings;
							goto IL_072b;
						case 55:
							num2 = (_003C_003E1__state = 2);
							num3 = 24;
							continue;
						case 0:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 65:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 30;
							continue;
						case 34:
							if (readDataSerialType != null)
							{
								awaiter = readDataSerialType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
								num3 = 23;
								if (true)
								{
									continue;
								}
								goto case 70;
							}
							num3 = 29;
							continue;
						case 48:
							goto IL_02b7;
						case 17:
							_003C_003Eu__2 = awaiter2;
							num3 = 67;
							continue;
						case 45:
							ezSnippet = commStepViewModel.WriteTcpIp;
							num3 = 15;
							continue;
						case 36:
							goto IL_02f4;
						case 43:
							goto IL_0334;
						case 16:
						case 50:
							goto IL_0353;
						case 59:
							goto IL_0371;
						case 62:
							goto IL_038d;
						case 24:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 71;
							continue;
						case 21:
							num2 = (_003C_003E1__state = 6);
							num3 = 65;
							continue;
						case 51:
							goto IL_03df;
						case 72:
							commStepViewModel.WriteTcpIp = result as WriteTcpIp;
							num3 = 45;
							if (0 == 0)
							{
								continue;
							}
							goto case 52;
						case 52:
							_003C_003Eu__1 = awaiter;
							num3 = 13;
							continue;
						case 39:
							readDataSerialType = ezSupportSnippetType as ReadDataSerialType;
							num3 = 34;
							continue;
						case 3:
							_003C_003Eu__1 = default;
							num3 = 20;
							continue;
						case 60:
							goto IL_044e;
						case 67:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 9;
							continue;
						case 8:
							_003C_003Eu__1 = awaiter;
							num3 = 70;
							continue;
						case 22:
							_003C_003Eu__2 = default;
							num3 = 11;
							continue;
						case 19:
							goto IL_04aa;
						case 20:
							num2 = (_003C_003E1__state = -1);
							num3 = 63;
							continue;
						case 32:
							goto IL_04d0;
						case 47:
							writeDataFtpType = ezSupportSnippetType as WriteDataFtpType;
							num3 = 56;
							if (0 == 0)
							{
								continue;
							}
							return;
						case 9:
							return;
						case 28:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								num3 = 52;
								if (PF6tYe5emKC4wjk81Q3X())
								{
									continue;
								}
								goto case 41;
							}
							goto case 63;
						case 41:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 35:
							if (!(ezSupportSnippetType is FactoryProtocolType factoryProtocolType))
							{
								writeTcpIpType = ezSupportSnippetType as WriteTcpIpType;
								num3 = 36;
								if (PF6tYe5emKC4wjk81Q3X())
								{
									continue;
								}
								goto case 1;
							}
							awaiter = factoryProtocolType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								num3 = 68;
								continue;
							}
							goto IL_05a5;
						case 1:
						case 61:
							writeFtpSettingsType = ezSupportSnippetType as WriteFtpSettingsType;
							num3 = 48;
							continue;
						case 64:
							goto IL_05a5;
						case 63:
							result = awaiter.GetResult();
							num3 = 6;
							continue;
						case 37:
							goto IL_05d8;
						case 6:
							commStepViewModel.WriteDataSerial = result as WriteDataSerial;
							num3 = 27;
							if (!CYMZ935eQgneT1T1ZxES())
							{
								continue;
							}
							goto case 58;
						case 58:
							result = awaiter.GetResult();
							commStepViewModel.ReadDataSerial = result as ReadDataSerial;
							num3 = 25;
							continue;
						case 54:
							ezSnippet = commStepViewModel.FactoryProtocol;
							num3 = 4;
							continue;
						case 44:
							num2 = (_003C_003E1__state = -1);
							num3 = 19;
							if (0 == 0)
							{
								continue;
							}
							goto case 23;
						case 23:
							if (!awaiter.IsCompleted)
							{
								num3 = 21;
								continue;
							}
							goto case 58;
						case 42:
							_003C_003Eu__1 = awaiter;
							num3 = 41;
							continue;
						case 2:
							return;
						case 10:
							goto IL_06e2;
						case 53:
							_003C_003Eu__1 = default;
							num3 = 44;
							continue;
						case 11:
							num2 = (_003C_003E1__state = -1);
							num3 = 73;
							if (0 == 0)
							{
								continue;
							}
							goto case 25;
						case 25:
							ezSnippet = commStepViewModel.ReadDataSerial;
							goto IL_072b;
						case 4:
						case 5:
						case 15:
						case 29:
						case 69:
							goto IL_072b;
						case 71:
							return;
						case 14:
							return;
						default:
							num3 = 64;
							continue;
						case 38:
							awaiter2 = bNYL3n5e2CkhvY1Xk0fH(DayKWp5eN116t6YaMDlq(commStepViewModel, new SnippetAddedEventArgs(ezSnippet, action)));
							if (!awaiter2.IsCompleted)
							{
								num3 = 33;
								continue;
							}
							goto case 73;
						case 68:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 14;
							if (0 == 0)
							{
								continue;
							}
							goto case 31;
						case 31:
							num2 = (_003C_003E1__state = 1);
							num3 = 42;
							continue;
						case 66:
							_003C_003Eu__1 = awaiter;
							num3 = 0;
							continue;
						case 46:
							_003C_003Eu__1 = default;
							num3 = 60;
							if (!CYMZ935eQgneT1T1ZxES())
							{
								continue;
							}
							goto case 73;
						case 73:
							awaiter2.GetResult();
							goto end_IL_002f;
						}
						break;
						IL_05d8:
						if (!(ezSupportSnippetType is WriteDataSerialType writeDataSerialType))
						{
							num3 = 39;
							continue;
						}
						awaiter = writeDataSerialType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
						num3 = 28;
						continue;
						IL_0334:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							num3 = 66;
							continue;
						}
						goto IL_035c;
						IL_0457:
						result = awaiter.GetResult();
						num3 = 72;
						continue;
						IL_04d0:
						if (writeImageFtpType != null)
						{
							awaiter = writeImageFtpType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
							num3 = 59;
						}
						else
						{
							num3 = 47;
						}
						continue;
						IL_02f4:
						if (writeTcpIpType == null)
						{
							num3 = 37;
							continue;
						}
						awaiter = writeTcpIpType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 18;
							continue;
						}
						goto IL_0457;
						IL_02b7:
						if (writeFtpSettingsType != null)
						{
							awaiter = writeFtpSettingsType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
							num3 = 43;
						}
						else
						{
							writeImageFtpType = ezSupportSnippetType as WriteImageFtpType;
							num3 = 32;
						}
						continue;
						IL_044e:
						num2 = (_003C_003E1__state = -1);
						goto IL_0457;
					}
					goto IL_0066;
					IL_06e2:
					if (awaiter.IsCompleted)
					{
						goto IL_04aa;
					}
					num3 = 55;
					goto IL_07b6;
					IL_072b:
					if (ezSnippet != null)
					{
						num3 = 38;
						goto IL_07b6;
					}
					break;
					IL_05a5:
					result = awaiter.GetResult();
					commStepViewModel.FactoryProtocol = result as FactoryProtocol;
					num3 = 54;
					goto IL_07b6;
					IL_04aa:
					result = awaiter.GetResult();
					num3 = 49;
					goto IL_07b6;
					IL_03df:
					num2 = (_003C_003E1__state = -1);
					goto IL_03e8;
					IL_01cd:
					_003C_003Eu__1 = default;
					goto IL_0353;
					IL_0353:
					num2 = (_003C_003E1__state = -1);
					goto IL_035c;
					IL_035c:
					result = awaiter.GetResult();
					num3 = 40;
					if (false)
					{
						goto IL_0371;
					}
					goto IL_07b6;
					IL_0371:
					if (awaiter.IsCompleted)
					{
						goto IL_03e8;
					}
					num3 = 31;
					if (!PF6tYe5emKC4wjk81Q3X())
					{
						goto IL_038d;
					}
					goto IL_07b6;
					IL_0066:
					if (writeDataFtpType == null)
					{
						num3 = 35;
					}
					else
					{
						awaiter = writeDataFtpType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
						num3 = 10;
					}
					goto IL_07b6;
					IL_038d:
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					num3 = 58;
					goto IL_07b6;
					IL_03e8:
					result = awaiter.GetResult();
					num3 = 26;
					goto IL_07b6;
					end_IL_002f:
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
			goto IL_0a4a;
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
		internal static object DayKWp5eN116t6YaMDlq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bNYL3n5e2CkhvY1Xk0fH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PF6tYe5emKC4wjk81Q3X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CYMZ935eQgneT1T1ZxES()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass98_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			isSr7O5eurkSPwTQsX24(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)M9dfHT5eh1CNYiY5LZUq(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void isSr7O5eurkSPwTQsX24(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MrtitC5ecEXK4qa85tEB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MRJM2q5e1PRFVONte6nh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M9dfHT5eh1CNYiY5LZUq(object P_0)
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__98 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public CommStepViewModel _003C_003E4__this;

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
			_ = 0;
			int num = ((!QYJoUl5etQ5vApV0TGp0()) ? 5 : 2);
			CommStepViewModel commStepViewModel = default;
			int num2 = default;
			_003C_003Ec__DisplayClass98_0 obj = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					commStepViewModel = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass98_0();
							_ = 1;
							num3 = (TPdL3J5ezWaPhQDSdQUw() ? 5 : 6);
							goto IL_00da;
						}
						awaiter = _003C_003Eu__1;
						goto IL_011d;
						IL_00da:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 10:
								num2 = (_003C_003E1__state = 0);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 5:
							case 8:
								break;
							case 0:
							case 6:
								obj.guid = guid;
								num3 = 2;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 12;
							case 3:
								awaiter = LQhNf45OKuFrT3DqR0lQ(nLiOsg5OLDaZvZAyNQiY(ezSupportSnippetType, snippetRange, cells));
								num3 = 11;
								continue;
							case 2:
								ezSupportSnippetType = commStepViewModel.PmG2bZgFnW.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0);
								if (ezSupportSnippetType != null)
								{
									num3 = 3;
									if (!TPdL3J5ezWaPhQDSdQUw())
									{
										continue;
									}
									goto case 12;
								}
								goto end_IL_00da;
							case 12:
								awaiter.GetResult();
								goto end_IL_00da;
							}
							goto IL_011d;
							continue;
							end_IL_00da:
							break;
						}
						goto end_IL_005b;
						IL_011d:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00da;
						end_IL_005b:;
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
		internal static object nLiOsg5OLDaZvZAyNQiY(object P_0, CvsCellRange range, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).UpdateSnippet(range, (CvsCellCollection)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter LQhNf45OKuFrT3DqR0lQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QYJoUl5etQ5vApV0TGp0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TPdL3J5ezWaPhQDSdQUw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass99_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass99_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G97crY5OJrsZwgI9i5XN();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)eXE3hc5OajL1KVYjHrQ4(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void G97crY5OJrsZwgI9i5XN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool brYZxF5O5GIRxxNr3dQJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JU8eqS5Owv4TB4TBXBKg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eXE3hc5OajL1KVYjHrQ4(object P_0)
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
	private struct _003CAddDefaultReferences_003Ed__101 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GyW7YI5OeVuTkbxYyHlp();
			int num;
			if (!USksEU5OO4fCX6EeiE55())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (USksEU5OO4fCX6EeiE55())
				{
				}
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)AtBqA35OILVG2lyaIYDw()).GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (!GyW7YI5OeVuTkbxYyHlp())
							{
								goto IL_0167;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								GyW7YI5OeVuTkbxYyHlp();
								num3 = ((!USksEU5OO4fCX6EeiE55()) ? 5 : 7);
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
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
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 7:
								return;
							case 9:
								break;
							}
							break;
						}
						goto IL_0167;
						IL_0167:
						awaiter.GetResult();
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
				case 5:
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
		internal static object AtBqA35OILVG2lyaIYDw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GyW7YI5OeVuTkbxYyHlp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool USksEU5OO4fCX6EeiE55()
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
	private struct _003CRemoveReferences_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!KuUK245OijcUwOsCpNSm()) ? 1 : 5);
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = aKBZFN5OnC9oVVjZJcGG(commStepViewModel.WriteDataFtp.RemoveSupportSnippetReferencesAsync(e));
							num3 = 27;
							break;
						case 3:
							awaiter = _003C_003Eu__1;
							num3 = 12;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 6;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 22;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 24;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter.GetResult();
								goto case 14;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 24:
								_003C_003Eu__1 = default;
								num3 = 17;
								continue;
							case 27:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 16;
									if (b57fy95ODDOnU43dESTX())
									{
										continue;
									}
									goto case 12;
								}
								goto IL_00e4;
							case 12:
								_003C_003Eu__1 = default;
								num3 = 26;
								continue;
							case 22:
								num2 = (_003C_003E1__state = -1);
								goto IL_00e4;
							case 10:
								return;
							case 18:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 7;
							case 1:
								awaiter = aKBZFN5OnC9oVVjZJcGG(u6R9sQ5OVfUxvPWlcMhL(commStepViewModel.WriteTcpIp, e));
								num3 = 18;
								continue;
							case 3:
								return;
							case 14:
							case 23:
								awaiter = commStepViewModel.WriteDataSerial.RemoveSupportSnippetReferencesAsync(e).GetAwaiter();
								num3 = 25;
								continue;
							case 19:
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 0:
								awaiter = aKBZFN5OnC9oVVjZJcGG(hFp8IS5OfC71mO2Nfme1(commStepViewModel.FactoryProtocol, e));
								if (!awaiter.IsCompleted)
								{
									num3 = 19;
									continue;
								}
								break;
							case 17:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 2:
							case 21:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (b57fy95ODDOnU43dESTX())
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter.GetResult();
								num3 = 20;
								if (KuUK245OijcUwOsCpNSm())
								{
								}
								continue;
							case 5:
								return;
							case 13:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 25:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									num3 = 9;
									continue;
								}
								goto case 4;
							case 26:
								num2 = (_003C_003E1__state = -1);
								num3 = 28;
								continue;
							case 20:
								if (commStepViewModel.FactoryProtocol != null)
								{
									num3 = 0;
									continue;
								}
								goto end_IL_0210;
							case 8:
								return;
							case 9:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 16:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = (b57fy95ODDOnU43dESTX() ? 21 : 23);
								continue;
							case 28:
								break;
								IL_00e4:
								awaiter.GetResult();
								num3 = 1;
								if (b57fy95ODDOnU43dESTX())
								{
									continue;
								}
								return;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0210:
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
				case 4:
					commStepViewModel = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static TaskAwaiter aKBZFN5OnC9oVVjZJcGG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u6R9sQ5OVfUxvPWlcMhL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringSupportSnippet)P_0).RemoveSupportSnippetReferencesAsync((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hFp8IS5OfC71mO2Nfme1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSupportSnippet)P_0).RemoveReferences((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b57fy95ODDOnU43dESTX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KuUK245OijcUwOsCpNSm()
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
	private struct _003CRenameReferences_003Ed__103 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sKS2Cp5OdERv2pPKgH0W();
			int num = (eRBsN65Ol4KmuA2ja0Ae() ? 4 : 3);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)zva4lI5OgV9MddQk6c5a()).GetAwaiter();
							num3 = 6;
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
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (true)
								{
									continue;
								}
								return;
							default:
								return;
							case 2:
								return;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								_ = 1;
								if (eRBsN65Ol4KmuA2ja0Ae())
								{
									num3 = 2;
									continue;
								}
								num3 = 0;
								if (sKS2Cp5OdERv2pPKgH0W())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
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
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
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
		internal static object zva4lI5OgV9MddQk6c5a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sKS2Cp5OdERv2pPKgH0W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eRBsN65Ol4KmuA2ja0Ae()
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
	private struct _003CReleaseAllCommFields_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CommStepViewModel _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			CommStepViewModel commStepViewModel = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (commStepViewModel.j792XC3ZYD() == null)
							{
								goto IL_0227;
							}
							num3 = 63;
							goto IL_03b2;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 55;
							goto IL_03b2;
						case 6:
							awaiter = _003C_003Eu__1;
							num3 = 31;
							goto IL_03b2;
						case 7:
							awaiter = _003C_003Eu__1;
							num3 = 12;
							goto IL_03b2;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (!wGZYsb5OsSGcvNgmFCZ6())
							{
								goto IL_02b6;
							}
							goto IL_03b2;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 52;
							goto IL_03b2;
						case 5:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 45;
							if (flctpe5Ov4i6ejpKVL2e())
							{
							}
							goto IL_03b2;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 35;
							goto IL_03b2;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 32;
								goto IL_03b2;
							}
							IL_0773:
							commStepViewModel.WriteTcpIp = null;
							num3 = 42;
							goto IL_03b2;
							IL_0227:
							if (commStepViewModel.WriteFtpSettings == null)
							{
								goto IL_00eb;
							}
							num3 = 51;
							if (!wGZYsb5OsSGcvNgmFCZ6())
							{
								goto IL_0242;
							}
							goto IL_03b2;
							IL_05f6:
							num2 = (_003C_003E1__state = -1);
							goto IL_05ff;
							IL_00eb:
							if (commStepViewModel.WriteImageFtp != null)
							{
								num3 = 20;
								goto IL_03b2;
							}
							goto IL_05db;
							IL_05ff:
							awaiter.GetResult();
							num3 = 47;
							goto IL_03b2;
							IL_05db:
							if (commStepViewModel.WriteDataFtp != null)
							{
								num3 = 54;
								if (wGZYsb5OsSGcvNgmFCZ6())
								{
									goto IL_03b2;
								}
								goto IL_05f6;
							}
							goto IL_0758;
							IL_02b6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 25;
							if (!wGZYsb5OsSGcvNgmFCZ6())
							{
								goto IL_02d4;
							}
							goto IL_03b2;
							IL_0758:
							if (commStepViewModel.WriteTcpIp != null)
							{
								num3 = 58;
								if (!flctpe5Ov4i6ejpKVL2e())
								{
									goto IL_03b2;
								}
								goto IL_0773;
							}
							goto IL_07e7;
							IL_02d4:
							_003C_003Eu__1 = awaiter;
							num3 = 34;
							goto IL_03b2;
							IL_07e7:
							if (commStepViewModel.WriteDataSerial == null)
							{
								goto IL_02fa;
							}
							num3 = 19;
							goto IL_03b2;
							IL_0242:
							num2 = (_003C_003E1__state = -1);
							num3 = 16;
							if (!wGZYsb5OsSGcvNgmFCZ6())
							{
								goto IL_025b;
							}
							goto IL_03b2;
							IL_02fa:
							if (commStepViewModel.ReadDataSerial != null)
							{
								num3 = 39;
								goto IL_03b2;
							}
							goto IL_0824;
							IL_025b:
							num2 = (_003C_003E1__state = -1);
							goto IL_07fc;
							IL_0824:
							if (commStepViewModel.FactoryProtocol != null)
							{
								num3 = 30;
								goto IL_03b2;
							}
							break;
							IL_07fc:
							awaiter.GetResult();
							num3 = 23;
							goto IL_03b2;
							IL_03b2:
							while (true)
							{
								switch (num3)
								{
								case 37:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 41:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 33:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 27;
									continue;
								case 18:
									break;
								case 52:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_012a;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto case 57;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 10;
										if (wGZYsb5OsSGcvNgmFCZ6())
										{
											continue;
										}
										goto case 5;
									}
									goto case 1;
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 44;
									continue;
								case 16:
									awaiter.GetResult();
									commStepViewModel.ReadDataSerial = null;
									num3 = 7;
									continue;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 56;
									continue;
								case 25:
									return;
								case 31:
									_003C_003Eu__1 = default;
									num3 = 0;
									continue;
								case 19:
									valueTask = ieP9hc5OrV5J4Iuud52p(commStepViewModel.WriteDataSerial);
									num3 = 48;
									continue;
								case 1:
									awaiter.GetResult();
									num3 = 50;
									continue;
								case 32:
									num2 = (_003C_003E1__state = -1);
									num3 = 57;
									continue;
								case 8:
								case 40:
									goto IL_0227;
								case 0:
									goto IL_0242;
								case 45:
									goto IL_025b;
								case 21:
									num2 = (_003C_003E1__state = 3);
									num3 = 61;
									continue;
								case 23:
									commStepViewModel.WriteDataSerial = null;
									num3 = 66;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 29:
									return;
								case 34:
									goto IL_02b6;
								case 24:
									goto IL_02d4;
								case 35:
									num2 = (_003C_003E1__state = -1);
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto IL_02fa;
								case 66:
									goto IL_02fa;
								case 50:
									commStepViewModel.WriteFtpSettings = null;
									num3 = 18;
									continue;
								case 39:
									valueTask = commStepViewModel.ReadDataSerial.DisposeAsync();
									num3 = 13;
									continue;
								case 51:
									valueTask = ieP9hc5OrV5J4Iuud52p(commStepViewModel.WriteFtpSettings);
									num3 = 36;
									continue;
								case 36:
									awaiter = valueTask.GetAwaiter();
									num3 = 2;
									continue;
								case 13:
									awaiter = valueTask.GetAwaiter();
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 62;
								case 62:
									if (!awaiter.IsCompleted)
									{
										num3 = 28;
										if (flctpe5Ov4i6ejpKVL2e())
										{
										}
										continue;
									}
									goto IL_07fc;
								case 57:
									awaiter.GetResult();
									commStepViewModel.WriteDataFtp = null;
									goto IL_0758;
								default:
									num3 = 65;
									continue;
								case 20:
									valueTask = ieP9hc5OrV5J4Iuud52p(commStepViewModel.WriteImageFtp);
									awaiter = valueTask.GetAwaiter();
									num3 = 15;
									continue;
								case 11:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto IL_012a;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 29;
									if (true)
									{
										continue;
									}
									return;
								case 60:
									return;
								case 14:
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__1 = awaiter;
									num3 = 41;
									continue;
								case 9:
									if (awaiter.IsCompleted)
									{
										goto case 16;
									}
									num3 = 14;
									if (wGZYsb5OsSGcvNgmFCZ6())
									{
										continue;
									}
									goto case 64;
								case 64:
									awaiter = valueTask.GetAwaiter();
									num3 = 17;
									continue;
								case 43:
									return;
								case 53:
									awaiter = valueTask.GetAwaiter();
									num3 = 11;
									if (!flctpe5Ov4i6ejpKVL2e())
									{
										continue;
									}
									goto case 22;
								case 22:
									awaiter.GetResult();
									commStepViewModel.WriteImageFtp = null;
									goto IL_05db;
								case 55:
									goto IL_05f6;
								case 4:
									awaiter = valueTask.GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 7);
										num3 = 24;
										continue;
									}
									goto IL_06a0;
								case 15:
									if (!awaiter.IsCompleted)
									{
										num3 = 33;
										if (!flctpe5Ov4i6ejpKVL2e())
										{
											continue;
										}
										return;
									}
									goto case 22;
								case 27:
									return;
								case 59:
									return;
								case 56:
									num2 = (_003C_003E1__state = -1);
									goto IL_06a0;
								case 49:
									num2 = (_003C_003E1__state = 4);
									num3 = 37;
									continue;
								case 28:
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 43;
									continue;
								case 58:
									goto IL_06ec;
								case 63:
									valueTask = commStepViewModel.j792XC3ZYD().DisposeAsync();
									num3 = 53;
									continue;
								case 54:
									valueTask = ieP9hc5OrV5J4Iuud52p(commStepViewModel.WriteDataFtp);
									num3 = 64;
									continue;
								case 30:
									valueTask = commStepViewModel.FactoryProtocol.DisposeAsync();
									num3 = 4;
									continue;
								case 65:
									goto IL_0758;
								case 47:
									goto IL_0773;
								case 61:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 59;
									continue;
								case 38:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 60;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 1);
									num3 = 38;
									continue;
								case 48:
									awaiter = valueTask.GetAwaiter();
									num3 = 62;
									continue;
								case 42:
									goto IL_07e7;
								case 26:
								case 46:
									goto IL_07fc;
								case 44:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									if (!flctpe5Ov4i6ejpKVL2e())
									{
										continue;
									}
									goto IL_0824;
								case 7:
									goto IL_0824;
								case 67:
									{
										commStepViewModel.FactoryProtocol = null;
										goto end_IL_002e;
									}
									IL_06a0:
									awaiter.GetResult();
									num3 = 67;
									continue;
									IL_012a:
									awaiter.GetResult();
									commStepViewModel.c1b2o4Dse8(null);
									_ = 0;
									num3 = ((!wGZYsb5OsSGcvNgmFCZ6()) ? 26 : 40);
									continue;
								}
								break;
								IL_06ec:
								valueTask = ieP9hc5OrV5J4Iuud52p(commStepViewModel.WriteTcpIp);
								awaiter = valueTask.GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 49;
									continue;
								}
								goto IL_05ff;
							}
							goto IL_00eb;
							end_IL_002e:
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
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 1:
					commStepViewModel = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				_ = 1;
				num = (flctpe5Ov4i6ejpKVL2e() ? 5 : 0);
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
		internal static ValueTask ieP9hc5OrV5J4Iuud52p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wGZYsb5OsSGcvNgmFCZ6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool flctpe5Ov4i6ejpKVL2e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static ILogger JnD2EyMtIT;

	private EzSupportSnippetType[] PmG2bZgFnW;

	private readonly string WgN2ceLdo8;

	private int viU2QObHkx;

	[CompilerGenerated]
	private WriteFtpSettings zA12g4WuSD;

	[CompilerGenerated]
	private WriteImageFtp VTM2M5FFWI;

	private WriteDataFtp D992RhUZaB;

	private FactoryProtocol JGI24Hu4t7;

	public static readonly LocalizedEnumTypeConverter<FfpType> FfpTypeStringConverter;

	private FfpType kex2llkQ0E;

	[CompilerGenerated]
	private readonly FfpType[] SqE2TqldNM;

	private ScopedCounter XVh2WGEYOD;

	private WriteTcpIp rmU2jEhyGP;

	private WriteDataSerial EN92CAps5s;

	[CompilerGenerated]
	private ReadDataSerial JQo2Or4cyv;

	private EzSupportSnippet a9Z2HXoWSS;

	private RuntimeViewModel eeA2wLkl7i;

	[CompilerGenerated]
	private ISnippetManager CLQ2ywA6hT;

	private bool VN82xMdJSj;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_CommunicationIcon;
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
			return Resources.Communication;
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
			return (string)gGkObbQ1BZmxfvi29nR();
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
			return (string)flA6ZjQuL15hWDJqwek();
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
			return AppStepHelpTopics.Communication;
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
			return viU2QObHkx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref viU2QObHkx, value, (string)MFDwibQHTR27LB50yKf(3256));
		}
	}

	public WriteFtpSettings WriteFtpSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zA12g4WuSD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zA12g4WuSD = value;
		}
	}

	public WriteImageFtp WriteImageFtp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VTM2M5FFWI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VTM2M5FFWI = value;
		}
	}

	public WriteDataFtp WriteDataFtp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D992RhUZaB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					i7jeJjQ1GX();
					num = 8;
					continue;
				case 0:
				case 2:
					D992RhUZaB = value;
					num = 3;
					continue;
				case 1:
					if (D992RhUZaB != null)
					{
						num = 7;
						continue;
					}
					goto case 0;
				case 3:
					if (D992RhUZaB == null)
					{
						goto case 4;
					}
					goto case 6;
				default:
					num = 6;
					if (WWRuQDQYNSsF7lnBfVC())
					{
					}
					continue;
				case 6:
					cD5sOBQtNf0u13JUToo(D992RhUZaB, new EventHandler(DetailsPanelToggled));
					goto case 4;
				case 7:
					break;
				case 8:
					return;
				}
				do
				{
					HjJOeSQhoW5n0EJnSTi(D992RhUZaB, new EventHandler(DetailsPanelToggled));
					_ = 1;
					if (WWRuQDQYNSsF7lnBfVC())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (WWRuQDQYNSsF7lnBfVC())
					{
					}
					break;
				}
				while (1 == 0);
			}
		}
	}

	public FactoryProtocol FactoryProtocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JGI24Hu4t7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GgMYAVQMJTrs38bFfBK();
			int num;
			if (!WWRuQDQYNSsF7lnBfVC())
			{
				num = 5;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 7;
				if (WWRuQDQYNSsF7lnBfVC())
				{
					goto IL_009b;
				}
			}
			goto IL_0047;
			IL_002a:
			if (JGI24Hu4t7 == null)
			{
				goto IL_00de;
			}
			goto IL_00f0;
			IL_009b:
			JGI24Hu4t7.DetailsToggled -= DetailsPanelToggled;
			num = 4;
			goto IL_0047;
			IL_00f0:
			NAEW9rQzkGGZ1ZxbcYq(JGI24Hu4t7, new EventHandler(DetailsPanelToggled));
			num = 6;
			goto IL_0047;
			IL_00de:
			i7jeJjQ1GX();
			num = 8;
			if (0 == 0)
			{
				goto IL_0047;
			}
			goto IL_00f0;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 5:
					if (JGI24Hu4t7 != null)
					{
						goto IL_009b;
					}
					goto case 4;
				case 1:
				case 7:
					goto IL_009b;
				case 4:
					SetField(ref JGI24Hu4t7, value, (string)MFDwibQHTR27LB50yKf(2274));
					num = 2;
					continue;
				case 6:
					goto IL_00de;
				case 3:
					goto IL_00f0;
				case 8:
					return;
				}
				break;
			}
			goto IL_002a;
		}
	}

	public string IndustrialEthernetHeader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)qbgO21NKoUbQrmWAUoR(Resources.wiPY3Old17(), ek4KH2NLqj66M0b3NtJ(FfpTypeStringConverter, Protocol));
		}
	}

	public FfpType Protocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kex2llkQ0E;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref kex2llkQ0E, value, (string)MFDwibQHTR27LB50yKf(29110)))
			{
				BFkkm1N5yQkYpvYmmAC(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29130));
			}
		}
	}

	public FfpType[] AvailableProtocols
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SqE2TqldNM;
		}
	}

	public WriteTcpIp WriteTcpIp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rmU2jEhyGP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
			goto IL_006b;
			IL_006b:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 7:
					break;
				case 1:
					goto IL_0033;
				case 3:
				case 5:
					goto IL_004e;
				default:
					num = 4;
					continue;
				case 6:
					goto IL_009e;
				case 4:
					goto IL_00ae;
				case 0:
					goto IL_00d5;
				case 8:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_009e:
			i7jeJjQ1GX();
			num = 8;
			goto IL_006b;
			IL_0033:
			if (rmU2jEhyGP == null)
			{
				goto IL_001a;
			}
			num = 0;
			if (!GgMYAVQMJTrs38bFfBK())
			{
				goto IL_004e;
			}
			goto IL_006b;
			IL_001a:
			rmU2jEhyGP = value;
			goto IL_004e;
			IL_004e:
			if (rmU2jEhyGP == null)
			{
				goto IL_009e;
			}
			goto IL_00ae;
			IL_00ae:
			bQAVqENJqST9pIG14up(rmU2jEhyGP, new EventHandler(DetailsPanelToggled));
			num = 6;
			if (GgMYAVQMJTrs38bFfBK())
			{
				goto IL_006b;
			}
			goto IL_00d5;
			IL_00d5:
			MKCXDGNwfDs4imvuxRk(rmU2jEhyGP, new EventHandler(DetailsPanelToggled));
			GgMYAVQMJTrs38bFfBK();
			if (WWRuQDQYNSsF7lnBfVC())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0033;
				}
			}
			else
			{
				num = 7;
			}
			goto IL_006b;
		}
	}

	public WriteDataSerial WriteDataSerial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EN92CAps5s;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GgMYAVQMJTrs38bFfBK();
			int num = (WWRuQDQYNSsF7lnBfVC() ? 7 : 4);
			while (true)
			{
				switch (num)
				{
				case 6:
					i7jeJjQ1GX();
					num = 8;
					continue;
				case 1:
				case 7:
					gq1PnxNajuhXGhMfAcN(EN92CAps5s, new EventHandler(DetailsPanelToggled));
					num = 2;
					continue;
				case 5:
					if (EN92CAps5s == null)
					{
						goto case 6;
					}
					goto case 3;
				default:
					num = 3;
					if (!WWRuQDQYNSsF7lnBfVC())
					{
						continue;
					}
					goto case 3;
				case 3:
					cOrM1xNePgeePDy6CP2(EN92CAps5s, new EventHandler(DetailsPanelToggled));
					num = 6;
					continue;
				case 0:
				case 4:
					if (EN92CAps5s == null)
					{
						break;
					}
					goto case 1;
				case 2:
					break;
				case 8:
					return;
				}
				EN92CAps5s = value;
				num = 5;
			}
		}
	}

	public ReadDataSerial ReadDataSerial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JQo2Or4cyv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JQo2Or4cyv = value;
		}
	}

	public override EasyBuilderApplicationViewModel AppViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return base.AppViewModel;
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
			if (GgMYAVQMJTrs38bFfBK())
			{
				num = 10;
			}
			else
			{
				num = 1;
				if (!GgMYAVQMJTrs38bFfBK())
				{
					goto IL_00d2;
				}
			}
			goto IL_0065;
			IL_00fa:
			((JobManagementViewModel)fPLDCdNnQcLOZVDE7Qs(base.AppViewModel)).JobLoaded -= Mcper6f4xO;
			num = 9;
			goto IL_0065;
			IL_00d2:
			base.AppViewModel.JobManagement.JobLoaded += Mcper6f4xO;
			num = 5;
			if (0 == 0)
			{
				goto IL_0065;
			}
			goto IL_00fa;
			IL_0065:
			while (true)
			{
				switch (num)
				{
				case 8:
					TGO10pNi5NC5gHYixjR(base.AppViewModel, new EventHandler(AppViewModel_ActiveStepChanged));
					num = 3;
					if (GgMYAVQMJTrs38bFfBK())
					{
						continue;
					}
					goto case 6;
				case 6:
					base.AppViewModel = value;
					goto case 4;
				default:
					num = 4;
					continue;
				case 2:
					base.AppViewModel.ActiveStepChanged += AppViewModel_ActiveStepChanged;
					break;
				case 1:
				case 7:
					break;
				case 3:
					goto IL_00fa;
				case 5:
				{
					object obj = JiOH3uNfwkcVadAsgFu(base.AppViewModel);
					RuntimeModeService = (IRuntimeModeService)((obj != null) ? IC22jiNdFRpYp6lKl32(obj) : null);
					RuntimeService = ((RuntimeViewModel)JiOH3uNfwkcVadAsgFu(base.AppViewModel))?.RuntimeService;
					XTL23SLuhv((RuntimeViewModel)JiOH3uNfwkcVadAsgFu(base.AppViewModel));
					num = 11;
					continue;
				}
				case 9:
					pl451INVGMB40ZQIqyF(this, null);
					RuntimeService = null;
					num = 6;
					continue;
				case 4:
					if (base.AppViewModel != null)
					{
						num = 2;
						if (true)
						{
							continue;
						}
						goto case 0;
					}
					return;
				case 0:
				case 10:
					if (base.AppViewModel != null)
					{
						num = 8;
						continue;
					}
					goto case 6;
				case 11:
					return;
				}
				break;
			}
			goto IL_00d2;
		}
	}

	public ISnippetManager SnippetManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CLQ2ywA6hT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CLQ2ywA6hT = value;
		}
	}

	public bool IsEditAllowed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VN82xMdJSj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref VN82xMdJSj, value, (string)MFDwibQHTR27LB50yKf(3684));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ImportingConstructor]
	public CommStepViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			default:
				VN82xMdJSj = true;
				num = 6;
				break;
			case 8:
				viU2QObHkx = 400;
				num = 10;
				break;
			case 6:
				base._002Ector();
				StepDisplay = new RunStepDisplay(((EasyBuilderApplicationViewModel)awthH6QNVrwObB2uYBy(this))?.Display);
				num = 3;
				break;
			case 3:
				ShowInSightDisplay = true;
				num = 1;
				if (!WWRuQDQYNSsF7lnBfVC())
				{
					break;
				}
				goto case 7;
			case 7:
				WgN2ceLdo8 = (string)slCDYgQxi2dGiOsNTvf(Resources.Communication, MFDwibQHTR27LB50yKf(1104));
				num = 8;
				break;
			case 9:
				OfyAcwQUqRViYGNDNXj();
				num = 7;
				break;
			case 10:
				SqE2TqldNM = ((IEnumerable)IB38WLQQ0ydVvPaGb6p(tbT8b5QmIZf7g4cQ0Fg(typeof(FfpType).TypeHandle))).Cast<FfpType>().ToArray();
				_ = 1;
				num = (WWRuQDQYNSsF7lnBfVC() ? 2 : 0);
				break;
			case 0:
			case 4:
				XVh2WGEYOD = new ScopedCounter();
				goto default;
			case 1:
				pJQ9MgQ2oviJWTCMur1(this, new PropertyChangedEventHandler(Q7ke9BgCJp));
				num = 11;
				if (!GgMYAVQMJTrs38bFfBK())
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__4))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CDisposeAsync_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!WWRuQDQYNSsF7lnBfVC()) ? 5 : 4);
				break;
			case 1:
				stateMachine._003C_003Et__builder = KkXn5CQcmR4MdHkt4nR();
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rjNe0RHViX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PmG2bZgFnW = new EzSupportSnippetType[7]
		{
			new WriteFtpSettingsType(this),
			new WriteDataFtpType(this),
			new WriteImageFtpType(this),
			new WriteTcpIpType(this),
			new WriteDataSerialType(this),
			new ReadDataSerialType(this),
			new FactoryProtocolType(this)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnProtocolChanged_003Ed__47))]
	private Task Ps1eVhNAWQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003COnProtocolChanged_003Ed__47 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				WWRuQDQYNSsF7lnBfVC();
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 4 : 5);
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBeginInitialization_003Ed__60))]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WWRuQDQYNSsF7lnBfVC())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0060;
		IL_0026:
		_003CBeginInitialization_003Ed__60 stateMachine = default;
		stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
		num = 4;
		if (WWRuQDQYNSsF7lnBfVC())
		{
		}
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!WWRuQDQYNSsF7lnBfVC())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCompleteInitializationAsync_003Ed__61))]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WWRuQDQYNSsF7lnBfVC() ? 1 : 4);
		_003CCompleteInitializationAsync_003Ed__61 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine.snippetManager = snippetManager;
				goto case 6;
			default:
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddFactoryProtocol_003Ed__62))]
	internal Task kBOeL4AFAY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CAddFactoryProtocol_003Ed__62 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003E4__this = this;
				GgMYAVQMJTrs38bFfBK();
				if (WWRuQDQYNSsF7lnBfVC())
				{
					num = 5;
					break;
				}
				num = 1;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnEnterStep_003Ed__63))]
	protected override Task OnEnterStep(StepBase previousStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnEnterStep_003Ed__63 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				WWRuQDQYNSsF7lnBfVC();
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 6 : 4);
				break;
			case 2:
				stateMachine.previousStep = previousStep;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnLeaveStep_003Ed__64))]
	protected override Task OnLeaveStep(StepBase nextStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003COnLeaveStep_003Ed__64 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (WWRuQDQYNSsF7lnBfVC())
				{
				}
				break;
			case 6:
				stateMachine.nextStep = nextStep;
				goto default;
			default:
				_ = 0;
				if (GgMYAVQMJTrs38bFfBK())
				{
					num = 0;
					break;
				}
				num = 5;
				if (!WWRuQDQYNSsF7lnBfVC())
				{
					break;
				}
				goto case 4;
			case 0:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DetailsPanelToggled(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (GgMYAVQMJTrs38bFfBK())
		{
			num = 5;
		}
		else
		{
			num = 1;
			if (WWRuQDQYNSsF7lnBfVC())
			{
				goto IL_00a9;
			}
		}
		goto IL_0072;
		IL_0072:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (j792XC3ZYD() == (EzSupportSnippet)sender)
				{
					num = 2;
					continue;
				}
				c1b2o4Dse8((EzSupportSnippet)sender);
				goto default;
			default:
				i7jeJjQ1GX();
				num = 6;
				continue;
			case 2:
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_00a9;
		IL_00a9:
		c1b2o4Dse8(null);
		num = 4;
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void i7jeJjQ1GX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		BaseViewModel value = default;
		EzSupportSnippet ezSupportSnippet = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 8:
			case 9:
			case 12:
				MainViewModel = value;
				num = 11;
				if (WWRuQDQYNSsF7lnBfVC())
				{
				}
				break;
			case 14:
				if (!(ezSupportSnippet is FactoryProtocol))
				{
					if (!(ezSupportSnippet is WriteDataFtp))
					{
						num = 0;
						break;
					}
					c1b2o4Dse8(WriteDataFtp);
					goto case 7;
				}
				c1b2o4Dse8(FactoryProtocol);
				num = 5;
				if (GgMYAVQMJTrs38bFfBK())
				{
					break;
				}
				goto case 10;
			case 3:
			case 4:
				c1b2o4Dse8(null);
				num = 10;
				break;
			case 6:
				ezSupportSnippet = j792XC3ZYD();
				num = 14;
				if (WWRuQDQYNSsF7lnBfVC())
				{
				}
				break;
			case 11:
				ShowInSightDisplay = MainViewModel == this;
				num = 16;
				break;
			case 15:
				if (ezSupportSnippet is WriteDataSerial)
				{
					c1b2o4Dse8(WriteDataSerial);
					value = (BaseViewModel)hfy8fsNIPY20KGuNZBn(WriteDataSerial);
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				_ = 0;
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 13 : 3);
				break;
			case 10:
				value = null;
				num = 2;
				break;
			case 7:
			case 13:
				value = WriteDataFtp.FormatString;
				goto case 1;
			default:
				num = 9;
				break;
			case 0:
				if (!(ezSupportSnippet is WriteTcpIp))
				{
					num = 15;
					break;
				}
				c1b2o4Dse8(WriteTcpIp);
				value = (BaseViewModel)hfy8fsNIPY20KGuNZBn(WriteTcpIp);
				num = 8;
				if (0 == 0)
				{
					break;
				}
				return;
			case 5:
				value = FactoryProtocol;
				num = 12;
				break;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCommStepViewModel_PropertyChanged_003Ed__67))]
	private void Q7ke9BgCJp(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCommStepViewModel_PropertyChanged_003Ed__67 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine.e = P_1;
				goto case 3;
			default:
				num = 3;
				if (!WWRuQDQYNSsF7lnBfVC())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 0:
				break;
			case 7:
				return;
			}
			do
			{
				stateMachine._003C_003Et__builder = YEZKcGNDKCh11ZJQSNV();
				GgMYAVQMJTrs38bFfBK();
				if (WWRuQDQYNSsF7lnBfVC())
				{
					num = 5;
					continue;
				}
				num = 6;
				break;
			}
			while (WWRuQDQYNSsF7lnBfVC());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private EzSupportSnippet j792XC3ZYD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return a9Z2HXoWSS;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void c1b2o4Dse8(EzSupportSnippet value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GgMYAVQMJTrs38bFfBK();
		int num = (WWRuQDQYNSsF7lnBfVC() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 6:
				if (a9Z2HXoWSS != null)
				{
					num = 4;
					break;
				}
				return;
			case 1:
			case 2:
				a9Z2HXoWSS = value;
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				if (a9Z2HXoWSS != null)
				{
					num = 5;
					break;
				}
				goto case 1;
			case 4:
				jSpnqkNlICnl7KlJXZE(a9Z2HXoWSS, true);
				num = 7;
				break;
			case 5:
				jSpnqkNlICnl7KlJXZE(a9Z2HXoWSS, false);
				goto case 1;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CJobManagement_JobLoaded_003Ed__75))]
	private Task Mcper6f4xO(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WWRuQDQYNSsF7lnBfVC())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (!GgMYAVQMJTrs38bFfBK())
			{
				goto IL_00b5;
			}
		}
		_003CJobManagement_JobLoaded_003Ed__75 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 4;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b5;
		IL_00b5:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetFactoryProtocol_003Ed__76))]
	internal Task oDXehJ1f06()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CResetFactoryProtocol_003Ed__76 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 1 : 0);
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void xLge8fEcnH(FfpType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)PdcmZhNgCLWvNv6HjOa(XVh2WGEYOD);
		try
		{
			Protocol = P_0;
		}
		finally
		{
			if (disposable != null)
			{
				aWg0UmNskMf47I2AAuw(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private RuntimeViewModel EeC2DfIQ3g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return eeA2wLkl7i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void XTL23SLuhv(RuntimeViewModel value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (WWRuQDQYNSsF7lnBfVC())
		{
			goto IL_001e;
		}
		goto IL_00c1;
		IL_001e:
		eeA2wLkl7i.PropertyChanged -= bbZem9vcDn;
		num = 6;
		goto IL_00c1;
		IL_00c1:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				break;
			default:
				if (eeA2wLkl7i != null)
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				return;
			case 3:
				if (eeA2wLkl7i != null)
				{
					_ = 1;
					if (!WWRuQDQYNSsF7lnBfVC())
					{
						num = 7;
						continue;
					}
					num = 2;
					if (false)
					{
						return;
					}
					continue;
				}
				goto case 6;
			case 0:
				eeA2wLkl7i.PropertyChanged += bbZem9vcDn;
				num = 8;
				continue;
			case 6:
				eeA2wLkl7i = value;
				num = 5;
				continue;
			case 5:
				nAUe1L8XLD();
				goto default;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bbZem9vcDn(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nAUe1L8XLD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nAUe1L8XLD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RuntimeViewModel runtimeViewModel = EeC2DfIQ3g();
		IsEditAllowed = runtimeViewModel != null && vWdRewNv1ZRDxVQTnbZ(runtimeViewModel);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (predicate == null)
		{
			predicate = CellViewModel.oexw5f8eIR();
		}
		IEnumerable<IGrouping<string, CellViewModel>> first = oKbez0vloh(WriteFtpSettings, predicate, targetProperty);
		IEnumerable<IGrouping<string, CellViewModel>> second = oKbez0vloh(WriteImageFtp, predicate, targetProperty);
		IEnumerable<IGrouping<string, CellViewModel>> second2 = oKbez0vloh(WriteDataFtp, predicate, targetProperty);
		IEnumerable<IGrouping<string, CellViewModel>> second3 = oKbez0vloh(WriteTcpIp, predicate, targetProperty);
		IEnumerable<IGrouping<string, CellViewModel>> second4 = oKbez0vloh(WriteDataSerial, predicate, targetProperty);
		return Enumerable.Concat(second: oKbez0vloh(ReadDataSerial, predicate, targetProperty), first: first.Concat(second).Concat(second2).Concat(second3)
			.Concat(second4));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<IGrouping<string, CellViewModel>> oKbez0vloh(EzSnippet P_0, Func<CellViewModel, bool> P_1, CellViewModel P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass93_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass93_0();
		CS_0024_003C_003E8__locals10.targetProperty = P_2;
		CS_0024_003C_003E8__locals10.predicate = P_1;
		CS_0024_003C_003E8__locals10._003C_003E4__this = this;
		CS_0024_003C_003E8__locals10.snippet = P_0;
		IEnumerable<IGrouping<string, CellViewModel>> result = Enumerable.Empty<IGrouping<string, CellViewModel>>();
		if (CS_0024_003C_003E8__locals10.snippet != null)
		{
			result = CS_0024_003C_003E8__locals10.snippet.Properties.Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel property) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec__DisplayClass93_0.Ht9TOO5eWOAYbEYUbaIw(property) && _003C_003Ec__DisplayClass93_0.dRsFor5eTuVGLQ92nuTx(property, CS_0024_003C_003E8__locals10.targetProperty) && CS_0024_003C_003E8__locals10.predicate(property);
			}).GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel property) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (string)_003C_003Ec__DisplayClass93_0.DYxEk95e0QiBI50kkStw(CS_0024_003C_003E8__locals10._003C_003E4__this.WgN2ceLdo8, _003C_003Ec__DisplayClass93_0.PpaVMc5eyC78t9yIAXjV(CS_0024_003C_003E8__locals10.snippet));
			});
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePropertiesGrouped(CellViewModel targetProperty, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (predicate == null)
		{
			predicate = CellViewModel.oexw5f8eIR();
		}
		if (targetProperty.DataType == CellType.Bool || targetProperty.DisplayName == Resources.Enabled || targetProperty.DataType == CellType.Empty)
		{
			return GetSourceablePrimitivesGrouped(null, predicate);
		}
		return Enumerable.Empty<IGrouping<string, CellViewModel>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<CellViewModel> GetLinkableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return WriteDataFtp.Properties.Concat(WriteImageFtp.Properties).Concat(WriteTcpIp.Properties).Concat(WriteDataSerial.Properties)
			.Concat(ReadDataSerial.Properties);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Supports(Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass96_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass96_0();
		CS_0024_003C_003E8__locals2.guid = guid;
		return PmG2bZgFnW.Any([MethodImpl(MethodImplOptions.NoInlining)] (EzSupportSnippetType s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(CS_0024_003C_003E8__locals2.guid);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__97))]
	Task ISnippetOwner.AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange, SnippetAddedEventType action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WWRuQDQYNSsF7lnBfVC())
		{
			num = 8;
			if (!GgMYAVQMJTrs38bFfBK())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_010c;
			}
		}
		goto IL_0044;
		IL_009f:
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__97 stateMachine = default;
		stateMachine.action = action;
		num = 5;
		if (true)
		{
			goto IL_0044;
		}
		goto IL_00b4;
		IL_010c:
		stateMachine._003C_003E1__state = -1;
		num = 4;
		goto IL_0044;
		IL_00b4:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 10;
		if (true)
		{
			goto IL_0044;
		}
		goto IL_00ce;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			default:
				num = 7;
				continue;
			case 0:
			case 8:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 6;
				if (WWRuQDQYNSsF7lnBfVC())
				{
				}
				continue;
			case 7:
				goto IL_009f;
			case 4:
				goto IL_00b4;
			case 3:
				goto IL_00ce;
			case 1:
			case 2:
				stateMachine.guid = guid;
				num = 3;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 5:
				goto IL_010c;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_00ce:
		stateMachine.cells = cells;
		num = 9;
		goto IL_0044;
		IL_002a:
		stateMachine.snippetRange = snippetRange;
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__98))]
	Task ISnippetOwner.UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
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
		goto IL_00a2;
		IL_001a:
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__98 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00eb;
		IL_00a2:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
				stateMachine.guid = guid;
				num = 8;
				if (WWRuQDQYNSsF7lnBfVC())
				{
				}
				continue;
			case 4:
				stateMachine.snippetRange = snippetRange;
				_ = 0;
				if (!GgMYAVQMJTrs38bFfBK())
				{
					num = 0;
					continue;
				}
				num = 1;
				if (!WWRuQDQYNSsF7lnBfVC())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 7;
				continue;
			case 8:
				stateMachine.cells = cells;
				goto case 4;
			default:
				num = 4;
				continue;
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 0:
			case 6:
				goto IL_00eb;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_00eb:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 9;
		goto IL_00a2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISnippetOwner.SnippetNeedsUpdate(Guid guid, CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (WWRuQDQYNSsF7lnBfVC() ? 4 : 5);
		_003C_003Ec__DisplayClass99_0 obj = default;
		EzSupportSnippetType ezSupportSnippetType = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				obj.guid = guid;
				num = 3;
				break;
			case 0:
			case 5:
				obj = new _003C_003Ec__DisplayClass99_0();
				goto case 1;
			case 2:
				if (ezSupportSnippetType != null)
				{
					num = 6;
					if (GgMYAVQMJTrs38bFfBK())
					{
						break;
					}
					goto case 3;
				}
				return false;
			case 3:
				ezSupportSnippetType = PmG2bZgFnW.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0);
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return ymFIZ0NrBV0E2pgkQ4g(ezSupportSnippetType, range, cells);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddDefaultReferences_003Ed__101))]
	public Task AddDefaultReferences(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!GgMYAVQMJTrs38bFfBK()) ? 2 : 4);
		_003CAddDefaultReferences_003Ed__101 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (GgMYAVQMJTrs38bFfBK())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__102))]
	public Task RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRemoveReferences_003Ed__102 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 2;
				break;
			case 6:
				stateMachine.e = e;
				goto default;
			default:
				WWRuQDQYNSsF7lnBfVC();
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 1 : 5);
				break;
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 6;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameReferences_003Ed__103))]
	public Task RenameReferences(SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!GgMYAVQMJTrs38bFfBK()) ? 4 : 2);
		_003CRenameReferences_003Ed__103 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReleaseAllCommFields_003Ed__104))]
	private Task RC72aFp3lv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GgMYAVQMJTrs38bFfBK();
		int num;
		if (!WWRuQDQYNSsF7lnBfVC())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0044;
		IL_006f:
		_003CReleaseAllCommFields_003Ed__104 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (GgMYAVQMJTrs38bFfBK())
		{
			goto IL_0044;
		}
		goto IL_008d;
		IL_008d:
		stateMachine._003C_003E4__this = this;
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_006f;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_006f;
			case 1:
				goto IL_008d;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = J7FVbONOaDHPfHRbmGx();
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CommStepViewModel()
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
			case 0:
				OfyAcwQUqRViYGNDNXj();
				WWRuQDQYNSsF7lnBfVC();
				num = ((!GgMYAVQMJTrs38bFfBK()) ? 4 : 3);
				continue;
			case 1:
			case 3:
				JnD2EyMtIT = LogManager.GetLogger<CommStepViewModel>();
				break;
			case 5:
				return;
			}
			FfpTypeStringConverter = new LocalizedEnumTypeConverter<FfpType>();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private ValueTask h13257fa9k()
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
	private Task rab2p7ym4N(StepBase P_0)
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
	private Task VP62U8t2Xg(StepBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnLeaveStep(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OfyAcwQUqRViYGNDNXj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MFDwibQHTR27LB50yKf(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object slCDYgQxi2dGiOsNTvf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type tbT8b5QmIZf7g4cQ0Fg(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IB38WLQQ0ydVvPaGb6p(Type P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enum.GetValues(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object awthH6QNVrwObB2uYBy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pJQ9MgQ2oviJWTCMur1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GgMYAVQMJTrs38bFfBK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WWRuQDQYNSsF7lnBfVC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder KkXn5CQcmR4MdHkt4nR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gGkObbQ1BZmxfvi29nR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.zTl9qrYoEJ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object flA6ZjQuL15hWDJqwek()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.D3PZgTLa3n();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HjJOeSQhoW5n0EJnSTi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteDataFtp)P_0).DetailsToggled -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cD5sOBQtNf0u13JUToo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteDataFtp)P_0).DetailsToggled += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NAEW9rQzkGGZ1ZxbcYq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FactoryProtocol)P_0).DetailsToggled += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ek4KH2NLqj66M0b3NtJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertToString(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qbgO21NKoUbQrmWAUoR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BFkkm1N5yQkYpvYmmAC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MKCXDGNwfDs4imvuxRk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteTcpIp)P_0).DetailsToggled -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bQAVqENJqST9pIG14up(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteTcpIp)P_0).DetailsToggled += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gq1PnxNajuhXGhMfAcN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteDataSerial)P_0).DetailsToggled -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cOrM1xNePgeePDy6CP2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WriteDataSerial)P_0).DetailsToggled += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder J7FVbONOaDHPfHRbmGx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hfy8fsNIPY20KGuNZBn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder YEZKcGNDKCh11ZJQSNV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TGO10pNi5NC5gHYixjR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyBuilderApplicationViewModel)P_0).ActiveStepChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fPLDCdNnQcLOZVDE7Qs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).JobManagement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pl451INVGMB40ZQIqyF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).RuntimeModeService = (IRuntimeModeService)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JiOH3uNfwkcVadAsgFu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IC22jiNdFRpYp6lKl32(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jSpnqkNlICnl7KlJXZE(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSupportSnippet)P_0).IsEditing = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PdcmZhNgCLWvNv6HjOa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ScopedCounter)P_0).Increment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aWg0UmNskMf47I2AAuw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vWdRewNv1ZRDxVQTnbZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ymFIZ0NrBV0E2pgkQ4g(object P_0, CvsCellRange range, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippetType)P_0).NeedsUpdate(range, (CvsCellCollection)P_2);
	}
}
