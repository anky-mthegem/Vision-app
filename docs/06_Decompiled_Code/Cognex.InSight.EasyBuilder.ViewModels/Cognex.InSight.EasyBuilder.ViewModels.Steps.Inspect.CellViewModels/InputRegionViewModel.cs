using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputRegionViewModel : InputStructureViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRef_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InputRegionViewModel _003C_003E4__this;

		public SourceLink link;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ANBp6fKz1eaASvsTcMld();
			int num = (JKAwmsKzuNVtGKcmlsUJ() ? 5 : 4);
			int num2 = default;
			InputRegionViewModel inputRegionViewModel = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<object> awaiter = default;
			EzTool ezTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					inputRegionViewModel = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							ANBp6fKz1eaASvsTcMld();
							num3 = (JKAwmsKzuNVtGKcmlsUJ() ? 7 : 13);
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 5;
							break;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 17;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								continue;
							case 12:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 15;
								if (ANBp6fKz1eaASvsTcMld())
								{
									continue;
								}
								goto case 6;
							case 6:
								ezTool.SetEnableInputGraphicValue(enable: false);
								goto end_IL_027d;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 4:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter2;
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 17;
							case 17:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 13:
								awaiter2 = SME07EKzhjaisCiIGHEt(inputRegionViewModel.hU0y13eDX2(link));
								if (!awaiter2.IsCompleted)
								{
									goto case 1;
								}
								goto case 10;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 4;
								continue;
							case 3:
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 2:
								if (ezTool == null || ezTool == inputRegionViewModel.Tool)
								{
									awaiter = ((CvsCogSocketSheet)RXMogO5LK6I4dVcT0erP(inputRegionViewModel.InSight.CogSocket)).ApplyCellAttributesAsync(new CvsCellRange(WeSt0d5L5Kc7LnCeI64v(inputRegionViewModel.EditRegion)), new DictionaryEntry[1]
									{
										new DictionaryEntry(jXe2rR5LwvDIuFLZvBPq(51034), WeSt0d5L5Kc7LnCeI64v(BbKlAj5LJ3oj6qcioTip(inputRegionViewModel.Tool)).ToString(absoluteRow: true, absoluteColumn: true))
									}).GetAwaiter();
									num3 = 12;
								}
								else
								{
									num3 = 6;
								}
								continue;
							case 14:
								_003C_003Eu__2 = awaiter;
								num3 = 16;
								continue;
							case 10:
								awaiter2.GetResult();
								ezTool = (EzTool)v9BXvn5LLPf9L0lx3YSb(Mth9n4Kztg8xencbwGJD(inputRegionViewModel.Tool), GwsYJwKzzoIfpL7HXJ1x(link));
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 18:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_027d:
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
					continue;
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
		internal static TaskAwaiter SME07EKzhjaisCiIGHEt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Mth9n4Kztg8xencbwGJD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GwsYJwKzzoIfpL7HXJ1x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object v9BXvn5LLPf9L0lx3YSb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).DVPAElEC8W((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RXMogO5LK6I4dVcT0erP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation WeSt0d5L5Kc7LnCeI64v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jXe2rR5LwvDIuFLZvBPq(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BbKlAj5LJ3oj6qcioTip(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ANBp6fKz1eaASvsTcMld()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JKAwmsKzuNVtGKcmlsUJ()
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
	private struct _003CRemoveRef_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InputRegionViewModel _003C_003E4__this;

		public SourceLink link;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oIGkuH5LeL16b0mipeeH();
			int num;
			if (IENr5F5LaqvnhS8BnI6c())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (!IENr5F5LaqvnhS8BnI6c())
				{
					return;
				}
			}
			InputRegionViewModel inputRegionViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					inputRegionViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						TaskAwaiter awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_029b;
							}
							awaiter2 = JI2GWB5LOe3kZjAZ1hAj(inputRegionViewModel.yg8yzC8E40(link));
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						awaiter2.GetResult();
						EzTool ezTool = (EzTool)RP8EpK5Li3kgO6oqqNCP(irmv1I5LI38nKx9gDCOS(inputRegionViewModel.Tool), KmYwoP5LDTSBc4x0tm5n(link));
						if (ezTool == null || ezTool == inputRegionViewModel.Tool)
						{
							awaiter = ((CvsCogSocket)QC8PVE5LfHrnOVcdROOm(inputRegionViewModel.InSight)).Sheet.ApplyCellAttributesAsync(new CvsCellRange(D7e4UG5Ld3uPB84wcrkQ(inputRegionViewModel.EditRegion)), new DictionaryEntry(YoNx5J5LlmVDa0SDm4ud(51034), YoNx5J5LlmVDa0SDm4ud(1838))).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_029b;
						}
						bool flag = false;
						IEnumerator<EzTool> enumerator = ((InspectStepViewModel)irmv1I5LI38nKx9gDCOS(inputRegionViewModel.Tool)).Tools.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								EzTool current = enumerator.Current;
								_ = 0;
								int num3 = ((!IENr5F5LaqvnhS8BnI6c()) ? 2 : 5);
								while (true)
								{
									object obj;
									switch (num3)
									{
									case 2:
									case 3:
										flag = true;
										num3 = 6;
										continue;
									case 1:
									{
										InputRegionViewModel inputRegion = current.InputRegion;
										if (inputRegion == null)
										{
											goto case 4;
										}
										obj = KmYwoP5LDTSBc4x0tm5n(inputRegion.SelectedLink);
										goto IL_0198;
									}
									default:
										num3 = 4;
										if (!oIGkuH5LeL16b0mipeeH())
										{
											continue;
										}
										goto case 0;
									case 0:
									case 5:
										if (current == ezTool)
										{
											break;
										}
										num3 = 1;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									case 4:
										obj = null;
										goto IL_0198;
									case 6:
										goto end_IL_0143;
										IL_0198:
										if (!((string)obj == (string)KmYwoP5LDTSBc4x0tm5n(link)))
										{
											break;
										}
										goto case 2;
									}
									goto IL_01c2;
									continue;
									end_IL_0143:
									break;
								}
								break;
								IL_01c2:;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								wJXlH75LnjH1BUKqlcUo(enumerator);
							}
						}
						if (!flag)
						{
							E9ZoHM5LVhg6s98NKYqR(ezTool, true);
						}
						goto end_IL_0039;
						IL_029b:
						awaiter.GetResult();
						end_IL_0039:;
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
					continue;
				case 2:
					break;
				case 0:
				case 3:
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
		internal static TaskAwaiter JI2GWB5LOe3kZjAZ1hAj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object irmv1I5LI38nKx9gDCOS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KmYwoP5LDTSBc4x0tm5n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RP8EpK5Li3kgO6oqqNCP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).DVPAElEC8W((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wJXlH75LnjH1BUKqlcUo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void E9ZoHM5LVhg6s98NKYqR(object P_0, bool enable)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).SetEnableInputGraphicValue(enable);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QC8PVE5LfHrnOVcdROOm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation D7e4UG5Ld3uPB84wcrkQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YoNx5J5LlmVDa0SDm4ud(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IENr5F5LaqvnhS8BnI6c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oIGkuH5LeL16b0mipeeH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly EditRegionViewModel xxaxaCSmfM;

	[CompilerGenerated]
	private readonly string GJkx5cX6A1;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Region;
		}
	}

	public EditRegionViewModel EditRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xxaxaCSmfM;
		}
	}

	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GJkx5cX6A1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputRegionViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, string label, EditRegionViewModel editRegion, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		d6uaUUYzaT09lKoYf3i();
		int num = (cfDlVrULbZH8PSCqhqp() ? 6 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				DefaultLink = new SourceLink(Resources.IqB0fK82cs(), lKJDRmU58iOqrNBp6v5(editRegion).ToString(absoluteRow: true, absoluteColumn: true), CellType.Region);
				num = 1;
				if (cfDlVrULbZH8PSCqhqp())
				{
				}
				break;
			case 7:
				GJkx5cX6A1 = label;
				num = 3;
				break;
			case 3:
				Refresh(cells, init: true);
				num = 8;
				if (cfDlVrULbZH8PSCqhqp())
				{
				}
				break;
			case 4:
				base._002Ector(tool, loc, displayName, isInitialized);
				goto case 2;
			case 1:
				xxaxaCSmfM = editRegion;
				goto case 7;
			default:
				num = 7;
				break;
			case 0:
			case 5:
				VrhbPWUK6c9vjknUhF4();
				num = 4;
				break;
			case 8:
				RefreshLinks(updateMember: true);
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddRef_003Ed__9))]
	public override Task AddRef(SourceLink link)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CAddRef_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				cfDlVrULbZH8PSCqhqp();
				if (d6uaUUYzaT09lKoYf3i())
				{
					num = 6;
					if (d6uaUUYzaT09lKoYf3i())
					{
						break;
					}
					goto case 1;
				}
				num = 5;
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine.link = link;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveRef_003Ed__10))]
	public override Task RemoveRef(SourceLink link)
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
		goto IL_009e;
		IL_001a:
		_003CRemoveRef_003Ed__10 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_009e;
		IL_009e:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (cfDlVrULbZH8PSCqhqp())
				{
					num = 6;
					continue;
				}
				num = 3;
				if (d6uaUUYzaT09lKoYf3i())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
			case 6:
				stateMachine.link = link;
				break;
			default:
				num = 4;
				if (!cfDlVrULbZH8PSCqhqp())
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
	[DebuggerHidden]
	[CompilerGenerated]
	private Task hU0y13eDX2(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.AddRef(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task yg8yzC8E40(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RemoveRef(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VrhbPWUK6c9vjknUhF4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation lKJDRmU58iOqrNBp6v5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool d6uaUUYzaT09lKoYf3i()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cfDlVrULbZH8PSCqhqp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
