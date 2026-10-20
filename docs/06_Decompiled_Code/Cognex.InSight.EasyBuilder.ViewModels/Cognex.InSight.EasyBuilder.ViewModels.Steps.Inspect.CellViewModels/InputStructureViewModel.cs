using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public abstract class InputStructureViewModel : CellViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string expr;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass27_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Tr8BRo5Lv9TTYi81ySjf();
			gbnPMh5LrCiC8sa4qLue(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshSelectedLink_003Eb__0(SourceLink n)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vMXSrt5LZvnEUmM9c7Q9(zokmTZ5LP8Jlp4ZAvELW(n), expr);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Tr8BRo5Lv9TTYi81ySjf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gbnPMh5LrCiC8sa4qLue(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lrN9Vb5Lgnka0G5UV6Bu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F9b7bU5LsepJsV7Ss55i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zokmTZ5LP8Jlp4ZAvELW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vMXSrt5LZvnEUmM9c7Q9(object P_0, object P_1)
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
	private struct _003CSetSelectedLinkBackground_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InputStructureViewModel _003C_003E4__this;

		public SourceLink link;

		public bool undo;

		private TaskAwaiter<IUndoAction> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WB7LAe5LB8EDET8Mf3Ue();
			int num = (x8q4qw5LbV12blGRkHJB() ? 5 : 3);
			InputStructureViewModel inputStructureViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					inputStructureViewModel = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter<IUndoAction> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inputStructureViewModel.SetSelectedLink(link, undo).GetAwaiter();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!WB7LAe5LB8EDET8Mf3Ue())
							{
								goto IL_0093;
							}
						}
						goto IL_00f9;
						IL_0093:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00f9;
						IL_00f9:
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							default:
								return;
							case 2:
								return;
							case 7:
								break;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = ((!WB7LAe5LB8EDET8Mf3Ue()) ? 2 : 6);
								continue;
							case 3:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00f9;
							}
							goto IL_0093;
							continue;
							end_IL_00f9:
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
					num = 2;
					if (x8q4qw5LbV12blGRkHJB())
					{
					}
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
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
		internal static bool WB7LAe5LB8EDET8Mf3Ue()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x8q4qw5LbV12blGRkHJB()
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
	private struct _003CSetSelectedLink_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUndoAction> _003C_003Et__builder;

		public SourceLink link;

		public InputStructureViewModel _003C_003E4__this;

		public bool undo;

		private UndoStructureChange _003Caction_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!YDuBFw5LG6KfnisqLUCa()) ? 1 : 5);
			int num2 = default;
			TaskAwaiter awaiter = default;
			InputStructureViewModel inputStructureViewModel = default;
			IUndoAction result = default;
			SourceLink xbNx61cLP = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 16;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 1;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 15:
							case 17:
								_003C_003Eu__1 = awaiter;
								num3 = 14;
								continue;
							case 18:
							case 21:
								inputStructureViewModel.FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5136));
								num3 = 3;
								continue;
							case 10:
								return;
							case 0:
								JqKsCw5Lkwq2NPDmQhH4(inputStructureViewModel, ERIP7V5LSb6bbLMefX36(5436));
								JqKsCw5Lkwq2NPDmQhH4(inputStructureViewModel, ERIP7V5LSb6bbLMefX36(28306));
								num3 = 19;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									goto case 15;
								}
								goto case 9;
							case 2:
								return;
							case 4:
								if (inputStructureViewModel.xbNx61cLP6 == link)
								{
									break;
								}
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 13;
							case 13:
								inputStructureViewModel.xbNx61cLP6 = link;
								num3 = 0;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 21;
								continue;
							case 20:
								if (!awaiter.IsCompleted)
								{
									num3 = 23;
									continue;
								}
								goto IL_01bd;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 3:
								result = _003Caction_003E5__2;
								num3 = 24;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 22;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01bd;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!HudFo55LoG9h5ZpedfE3())
								{
									continue;
								}
								goto case 23;
							case 23:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 22:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 10;
								continue;
							case 19:
								if (!VIPedy5Lq9EFypDMi9bg(inputStructureViewModel.CellExpression, jdCTcq5L8ZHlLYgnSdYC(inputStructureViewModel.xbNx61cLP6)))
								{
									break;
								}
								_003Caction_003E5__2 = new UndoStructureChange((InspectStepViewModel)U8MpZO5LEh5WepGVUIqU(inputStructureViewModel.Tool), inputStructureViewModel.Tool.Name, inputStructureViewModel.DisplayName, xbNx61cLP, inputStructureViewModel.xbNx61cLP6);
								if (!undo)
								{
									awaiter = _003Caction_003E5__2.Do().GetAwaiter();
									num3 = 12;
									continue;
								}
								HudFo55LoG9h5ZpedfE3();
								if (!YDuBFw5LG6KfnisqLUCa())
								{
									num3 = 17;
									continue;
								}
								num3 = 11;
								if (!HudFo55LoG9h5ZpedfE3())
								{
									continue;
								}
								goto case 7;
							case 7:
								xbNx61cLP = inputStructureViewModel.xbNx61cLP6;
								num3 = 13;
								continue;
							case 16:
								if (link == null)
								{
									break;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 11:
								awaiter = B3lU6Y5L4HpwWvQK8WTh(OLGYfe5L9sKRIhJRG3Qc(mH1rxV5LXgSvm590ltcd(hM8tZd5LpZ7kCbn8CyFh(inputStructureViewModel.Tool)), _003Caction_003E5__2));
								num3 = 20;
								continue;
							case 24:
								goto end_IL_021a;
								IL_01bd:
								awaiter.GetResult();
								num3 = 18;
								continue;
							}
							result = null;
							break;
							continue;
							end_IL_021a:
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (!HudFo55LoG9h5ZpedfE3())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					inputStructureViewModel = _003C_003E4__this;
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
		internal static object ERIP7V5LSb6bbLMefX36(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JqKsCw5Lkwq2NPDmQhH4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jdCTcq5L8ZHlLYgnSdYC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VIPedy5Lq9EFypDMi9bg(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U8MpZO5LEh5WepGVUIqU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hM8tZd5LpZ7kCbn8CyFh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mH1rxV5LXgSvm590ltcd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OLGYfe5L9sKRIhJRG3Qc(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter B3lU6Y5L4HpwWvQK8WTh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YDuBFw5LG6KfnisqLUCa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HudFo55LoG9h5ZpedfE3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public string selectedText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass34_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rbYXjF5LjjHLX7mQvI6D();
			P1BLIF5L6fXeJen3hE3o(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRemoveReferences_003Eb__0(CellViewModel k)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wC07Oe5LCKSMChkKNsJH(k, selectedText) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rbYXjF5LjjHLX7mQvI6D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void P1BLIF5L6fXeJen3hE3o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QytepD5L7wJi5lLYWfsC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lC0d4X5L3MhG7Mr7PMKB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wC07Oe5LCKSMChkKNsJH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).FindMatch((string)P_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveReferences_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUndoAction> _003C_003Et__builder;

		public InputStructureViewModel _003C_003E4__this;

		public EzSnippet snippetToBeRemoved;

		private TaskAwaiter<IUndoAction> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (IiwIlJ5LAu2LtMihjWMn())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_003d;
				}
			}
			goto IL_0222;
			IL_0222:
			int num2 = default;
			_003C_003Ec__DisplayClass34_0 obj = default;
			TaskAwaiter<IUndoAction> awaiter = default;
			IUndoAction result = default;
			InputStructureViewModel inputStructureViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 4:
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass34_0();
							fIKu9u5LRPTmPyThaTma();
							if (IiwIlJ5LAu2LtMihjWMn())
							{
								num3 = 11;
								if (1 == 0)
								{
									goto IL_0076;
								}
							}
							else
							{
								num3 = 10;
								if (1 == 0)
								{
									goto IL_0091;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00ff;
						IL_015e:
						result = awaiter.GetResult();
						num3 = 12;
						goto IL_00ff;
						IL_0076:
						num2 = (_003C_003E1__state = -1);
						goto IL_015e;
						IL_0091:
						awaiter = inputStructureViewModel.ResetToDefault().GetAwaiter();
						num3 = 6;
						goto IL_00ff;
						IL_00ff:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 8:
								goto IL_0091;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto IL_015e;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (!fIKu9u5LRPTmPyThaTma())
								{
									continue;
								}
								goto IL_015e;
							case 9:
							case 10:
								goto IL_015e;
							case 7:
								goto IL_0170;
							case 0:
							case 11:
								goto IL_019b;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 12:
								goto end_IL_004e;
							}
							break;
							IL_019b:
							obj.selectedText = inputStructureViewModel.SelectedLink?.Text;
							if (obj.selectedText != null)
							{
								num3 = 7;
								continue;
							}
							goto IL_01e5;
							IL_01e5:
							result = null;
							goto end_IL_004e;
							IL_0170:
							if (snippetToBeRemoved.AllProperties.FirstOrDefault(obj._003CRemoveReferences_003Eb__0) != null)
							{
								num3 = 8;
								continue;
							}
							goto IL_01e5;
						}
						goto IL_0076;
						end_IL_004e:;
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
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (!fIKu9u5LRPTmPyThaTma())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_003d;
			IL_003d:
			inputStructureViewModel = _003C_003E4__this;
			num = 2;
			goto IL_0222;
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
		internal static bool IiwIlJ5LAu2LtMihjWMn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fIKu9u5LRPTmPyThaTma()
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
	private struct _003CResetToDefault_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUndoAction> _003C_003Et__builder;

		public InputStructureViewModel _003C_003E4__this;

		public bool addToUndoQueue;

		private TaskAwaiter<IUndoAction> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			InputStructureViewModel inputStructureViewModel = default;
			IUndoAction result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter<IUndoAction> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inputStructureViewModel.SetSelectedLink(inputStructureViewModel.DefaultLink, addToUndoQueue).GetAwaiter();
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = ((!vc60m15LW6pfivyu2fPg()) ? 2 : 0);
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 4:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								break;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
							case 5:
								_003C_003Eu__1 = default;
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
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!vc60m15LW6pfivyu2fPg()) ? 2 : 0);
					break;
				case 0:
				case 1:
					inputStructureViewModel = _003C_003E4__this;
					num = 5;
					if (ftZaHE5LTtqsrDQafYwG())
					{
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
		internal static bool vc60m15LW6pfivyu2fPg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ftZaHE5LTtqsrDQafYwG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EzTool nofx7sGutV;

	private SourceLink HSSxN3pTZC;

	private string PEMxAgr5eV;

	private List<SourceLink> wiVxdxdSlL;

	private SourceLink xbNx61cLP6;

	protected EzTool Tool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nofx7sGutV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nofx7sGutV = value;
		}
	}

	public override bool IsReadOnly
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

	protected SourceLink DefaultLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HSSxN3pTZC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HSSxN3pTZC = value;
			xbNx61cLP6 = HSSxN3pTZC;
		}
	}

	public string DefaultExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)SrkIUxUOqYdYYnxJsGI(DefaultLink);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XQgO0cUIvnEDoZx3H11(DefaultLink, value);
		}
	}

	public bool IsDefault
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SelectedLink == DefaultLink;
		}
	}

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)GKYV43UD9CMriJdyNBV(SelectedLink);
		}
	}

	public string CellExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PEMxAgr5eV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref PEMxAgr5eV, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(28274)))
			{
				RefreshSelectedLink();
			}
		}
	}

	public List<SourceLink> Links
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wiVxdxdSlL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref wiVxdxdSlL, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27670));
		}
	}

	public SourceLink SelectedLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xbNx61cLP6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (value != null)
			{
				sqYPMXUVBGlSM8qMtxS(oGvxpLPX62(value, IsInitialized), false);
			}
		}
	}

	public override bool IsLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SelectedLink != DefaultLink;
		}
	}

	public override string DisplayValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputStructureViewModel(EzTool tool, CvsCellLocation loc, string displayName, bool isInitialized)
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
			case 1:
			case 5:
				wiVxdxdSlL = new List<SourceLink>();
				goto case 0;
			case 4:
				Tool = tool;
				num = 6;
				break;
			case 3:
				akWK2TUafZxyoW8ETSa();
				_ = 1;
				num = ((!l6RAGvUJ2U0ic2ZsZHb()) ? 5 : 0);
				break;
			case 0:
			case 2:
				base._002Ector((CvsInSight)s8pB6oUehBcLFPxSLKi(tool), loc, displayName, isInitialized);
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				CellExpression = cell.Expression;
				return;
			case 4:
				return;
			case 5:
				return;
			case 6:
				if (cellLocation.IsValid)
				{
					num = 1;
					continue;
				}
				return;
			case 0:
				cellLocation = CellLocation;
				num = 6;
				continue;
			case 1:
				if (cell == null)
				{
					CellExpression = DefaultExpression;
					num = 7;
					if (!l6RAGvUJ2U0ic2ZsZHb())
					{
						continue;
					}
					goto case 6;
				}
				break;
			case 7:
				return;
			}
			l6RAGvUJ2U0ic2ZsZHb();
			if (!UmX9jZUwjDuEDqFaNOG())
			{
				num = 5;
				if (!UmX9jZUwjDuEDqFaNOG())
				{
					break;
				}
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshSelectedLink()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		SourceLink sourceLink = default;
		_003C_003Ec__DisplayClass27_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				if (xbNx61cLP6 != sourceLink)
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				if (l6RAGvUJ2U0ic2ZsZHb())
				{
				}
				break;
			case 8:
				obj = new _003C_003Ec__DisplayClass27_0();
				num = 1;
				break;
			case 3:
			case 10:
				if (sourceLink != null)
				{
					num = 9;
					break;
				}
				return;
			case 4:
			case 6:
				FirePropertyChanged((string)R3jBIKUiowqujHlLSZn(5436));
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				FirePropertyChanged((string)R3jBIKUiowqujHlLSZn(5136));
				num = 11;
				break;
			case 1:
				obj.expr = CellExpression;
				num = 0;
				break;
			case 5:
				xbNx61cLP6 = sourceLink;
				goto case 4;
			case 7:
				woo8UwUnqHhZs9pxpmY(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(28306));
				num = 2;
				break;
			case 0:
				sourceLink = Links.FirstOrDefault(obj._003CRefreshSelectedLink_003Eb__0);
				UmX9jZUwjDuEDqFaNOG();
				if (l6RAGvUJ2U0ic2ZsZHb())
				{
					num = 4;
					break;
				}
				num = 10;
				if (false)
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
	[AsyncStateMachine(typeof(_003CSetSelectedLinkBackground_003Ed__32))]
	private Task oGvxpLPX62(SourceLink P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSetSelectedLinkBackground_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine.undo = P_1;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 6:
				stateMachine._003C_003Et__builder = OEgbXrUfiaQ1HpWjX08();
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine.link = P_0;
				UmX9jZUwjDuEDqFaNOG();
				if (l6RAGvUJ2U0ic2ZsZHb())
				{
					num = 7;
					if (!l6RAGvUJ2U0ic2ZsZHb())
					{
						break;
					}
					goto default;
				}
				num = 5;
				if (UmX9jZUwjDuEDqFaNOG())
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetSelectedLink_003Ed__33))]
	public Task<IUndoAction> SetSelectedLink(SourceLink link, bool undo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetSelectedLink_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IUndoAction>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.link = link;
		stateMachine.undo = undo;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__34))]
	internal override Task<IUndoAction> RemoveReferences(EzSnippet snippetToBeRemoved)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRemoveReferences_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IUndoAction>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.snippetToBeRemoved = snippetToBeRemoved;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CResetToDefault_003Ed__35))]
	public Task<IUndoAction> ResetToDefault(bool addToUndoQueue = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CResetToDefault_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IUndoAction>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.addToUndoQueue = addToUndoQueue;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static List<SourceLink> GetLinks(InspectStepViewModel inspect, EzSnippet tool, CellType dataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<SourceLink> list = new List<SourceLink>();
		List<EzSnippet> list2 = new List<EzSnippet>();
		if (tool != null)
		{
			list2 = inspect.GetDependentSnippets(tool, recursive: true);
		}
		foreach (EzSnippet snippet in inspect.Snippets)
		{
			if (!list2.Contains(snippet))
			{
				SourceLink[] sourceLinks = snippet.GetSourceLinks(dataType);
				foreach (SourceLink item in sourceLinks)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshLinks(bool updateMember = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (l6RAGvUJ2U0ic2ZsZHb())
		{
			goto IL_001e;
		}
		goto IL_00b5;
		IL_0107:
		List<SourceLink> links = default;
		links.Insert(0, DefaultLink);
		num = 7;
		goto IL_00b5;
		IL_00b5:
		SourceLink sourceLink = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 5:
				links = GetLinks((InspectStepViewModel)YbF2T8UdIyQy4TGTg5n(Tool), Tool, sYkIWbUlV7Fh2lbodFm(this));
				num = 0;
				continue;
			case 2:
				xbNx61cLP6 = sourceLink;
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 9:
				if (!updateMember)
				{
					SelectedLink = sourceLink;
					num = 8;
					continue;
				}
				goto case 2;
			default:
				num = 2;
				continue;
			case 1:
			case 8:
				goto IL_00f0;
			case 0:
				goto IL_0107;
			case 3:
			case 6:
				if (sourceLink != null)
				{
					goto case 4;
				}
				goto IL_00f0;
			case 10:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_00f0:
		Links = links;
		num = 10;
		if (UmX9jZUwjDuEDqFaNOG())
		{
			goto IL_00b5;
		}
		goto IL_0107;
		IL_001e:
		sourceLink = links.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (SourceLink P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)SrkIUxUOqYdYYnxJsGI(P_0) == CellExpression;
		});
		_ = 1;
		if (!l6RAGvUJ2U0ic2ZsZHb())
		{
			num = 6;
			if (!UmX9jZUwjDuEDqFaNOG())
			{
				goto IL_00f0;
			}
		}
		else
		{
			num = 9;
			if (l6RAGvUJ2U0ic2ZsZHb())
			{
			}
		}
		goto IL_00b5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task AddRef(SourceLink link)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task RemoveRef(SourceLink link)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)EbDia4UgZZy4FLiuQLO();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool s3exUNhmRX(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)SrkIUxUOqYdYYnxJsGI(P_0) == CellExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void akWK2TUafZxyoW8ETSa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s8pB6oUehBcLFPxSLKi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UmX9jZUwjDuEDqFaNOG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l6RAGvUJ2U0ic2ZsZHb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SrkIUxUOqYdYYnxJsGI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XQgO0cUIvnEDoZx3H11(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SourceLink)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GKYV43UD9CMriJdyNBV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R3jBIKUiowqujHlLSZn(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void woo8UwUnqHhZs9pxpmY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConfiguredTaskAwaitable sqYPMXUVBGlSM8qMtxS(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Task)P_0).ConfigureAwait(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder OEgbXrUfiaQ1HpWjX08()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YbF2T8UdIyQy4TGTg5n(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).Parent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CellType sYkIWbUlV7Fh2lbodFm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EbDia4UgZZy4FLiuQLO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
