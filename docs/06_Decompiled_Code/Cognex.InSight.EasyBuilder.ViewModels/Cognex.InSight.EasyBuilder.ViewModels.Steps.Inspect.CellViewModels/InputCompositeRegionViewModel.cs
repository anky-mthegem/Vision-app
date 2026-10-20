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

public class InputCompositeRegionViewModel : InputStructureViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRef_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InputCompositeRegionViewModel _003C_003E4__this;

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
			int num = 3;
			if (mrRpELKtz3c20WBHe83T())
			{
				goto IL_001e;
			}
			goto IL_032d;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_032d;
			IL_032d:
			InputCompositeRegionViewModel inputCompositeRegionViewModel = default;
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			EzTool ezTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					inputCompositeRegionViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
								if (mrRpELKtz3c20WBHe83T())
								{
									goto IL_0069;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 7;
								if (!ePRFK4KttGcnPuhN5Xv2())
								{
									goto IL_02d4;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_021f;
						IL_01e4:
						awaiter2.GetResult();
						ezTool = (EzTool)loy8sAKzwXj7s2yVjaYP(OcbFP2KzK3BoFY6eF0k9(inputCompositeRegionViewModel.Tool), d03i5VKz5cKm0UOIpcjo(link));
						if (ezTool != null)
						{
							goto IL_008b;
						}
						goto IL_0177;
						IL_021f:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 8:
								goto IL_008b;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto IL_00d7;
							case 6:
							case 9:
								goto IL_00d7;
							case 5:
								num2 = (_003C_003E1__state = 1);
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter2 = tp6uqoKzLxHBo7i40i9W(inputCompositeRegionViewModel.m3uyYTHVV8(link));
								num3 = 1;
								continue;
							case 12:
								return;
							case 7:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_004c;
							case 0:
								goto end_IL_004c;
							case 15:
								goto IL_01e4;
							default:
								num3 = 8;
								continue;
							case 2:
							case 10:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 16;
								if (ePRFK4KttGcnPuhN5Xv2())
								{
									continue;
								}
								goto case 14;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								if (mrRpELKtz3c20WBHe83T())
								{
								}
								continue;
							case 13:
								return;
							case 17:
								goto IL_02d4;
							case 18:
								goto IL_02ea;
							}
							break;
						}
						goto IL_0069;
						IL_008b:
						if (ezTool != inputCompositeRegionViewModel.Tool)
						{
							goto IL_00d7;
						}
						goto IL_0177;
						IL_00d7:
						ezTool.SetEnableInputGraphicValue(enable: false);
						num3 = 0;
						goto IL_021f;
						IL_0069:
						if (awaiter2.IsCompleted)
						{
							goto IL_01e4;
						}
						_ = 1;
						num3 = (mrRpELKtz3c20WBHe83T() ? 6 : 10);
						goto IL_021f;
						IL_02d4:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							goto IL_021f;
						}
						goto IL_02ea;
						IL_0177:
						awaiter = inputCompositeRegionViewModel.InSight.CogSocket.Sheet.ApplyCellAttributesAsync(new CvsCellRange(K32vFlKzJJLyMa9ckOej(inputCompositeRegionViewModel.EditCompositeRegion)), new DictionaryEntry(xdBhJqKzaKOGEGnqBqns(51034), K32vFlKzJJLyMa9ckOej(DlcgdLKze1DhPVwIf3l7(inputCompositeRegionViewModel.Tool)).ToString(absoluteRow: true, absoluteColumn: true))).GetAwaiter();
						num3 = 17;
						goto IL_021f;
						IL_02ea:
						awaiter.GetResult();
						end_IL_004c:;
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
					num = 0;
					continue;
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					if (mrRpELKtz3c20WBHe83T())
					{
						num = 5;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static TaskAwaiter tp6uqoKzLxHBo7i40i9W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OcbFP2KzK3BoFY6eF0k9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d03i5VKz5cKm0UOIpcjo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object loy8sAKzwXj7s2yVjaYP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).DVPAElEC8W((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation K32vFlKzJJLyMa9ckOej(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xdBhJqKzaKOGEGnqBqns(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DlcgdLKze1DhPVwIf3l7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ePRFK4KttGcnPuhN5Xv2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mrRpELKtz3c20WBHe83T()
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

		public InputCompositeRegionViewModel _003C_003E4__this;

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
			jvWN0kKzIasO9LQAemFA();
			int num;
			if (dpNlYYKzO8c3nRwy9Rvk())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_005c;
				}
			}
			goto IL_0317;
			IL_0317:
			InputCompositeRegionViewModel inputCompositeRegionViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (dpNlYYKzO8c3nRwy9Rvk())
					{
						continue;
					}
					goto case 1;
				case 1:
					inputCompositeRegionViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
				case 3:
					break;
				case 2:
				case 4:
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
								goto IL_02d4;
							}
							awaiter2 = CLJeP5KzDtQVhilVofK3(inputCompositeRegionViewModel.e9xy0TE97B(link));
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
						EzTool ezTool = (EzTool)PbRxMCKziqC7UHgLGCy8(inputCompositeRegionViewModel.Tool.Parent, link?.Text);
						if (ezTool == null || ezTool == inputCompositeRegionViewModel.Tool)
						{
							awaiter = ((CvsCogSocketSheet)iRkyW0KzsjxwqlIShFMZ(csPAWbKzgfI8B7L8kUCR(inputCompositeRegionViewModel.InSight))).ApplyCellAttributesAsync(new CvsCellRange(uYOM05KzvWZlSBM0w2xQ(inputCompositeRegionViewModel.EditCompositeRegion)), new DictionaryEntry[1]
							{
								new DictionaryEntry(b9yrwuKzrlUJHaDyd5e4(51034), b9yrwuKzrlUJHaDyd5e4(1838))
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02d4;
						}
						bool flag = false;
						IEnumerator<EzTool> enumerator = ((InspectStepViewModel)S877pMKznyOPJUsy5uZR(inputCompositeRegionViewModel.Tool)).Tools.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								EzTool current = enumerator.Current;
								int num3 = 3;
								while (true)
								{
									object obj;
									switch (num3)
									{
									default:
										obj = null;
										goto IL_015b;
									case 1:
									case 4:
									{
										InputCompositeRegionViewModel inputCompositeRegion = current.InputCompositeRegion;
										if (inputCompositeRegion != null)
										{
											obj = hGuPpZKzV2JW4xdhTYtF(inputCompositeRegion.SelectedLink);
											goto IL_015b;
										}
										goto default;
									}
									case 0:
										flag = true;
										num3 = 6;
										continue;
									case 3:
										if (current != ezTool)
										{
											_ = 1;
											num3 = ((!jvWN0kKzIasO9LQAemFA()) ? 4 : 5);
											continue;
										}
										break;
									case 6:
										goto end_IL_019a;
										IL_015b:
										if (Py7QSDKzfvR7UGvmBUyn(obj, hGuPpZKzV2JW4xdhTYtF(link)))
										{
											num3 = 0;
											continue;
										}
										break;
									}
									goto IL_01fb;
									continue;
									end_IL_019a:
									break;
								}
								break;
								IL_01fb:;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								nFfXocKzdnvsw2S9tWwA(enumerator);
							}
						}
						if (!flag)
						{
							iZtejGKzlOjkMxdAcyGf(ezTool, true);
						}
						goto end_IL_006d;
						IL_02d4:
						awaiter.GetResult();
						end_IL_006d:;
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
			goto IL_005c;
			IL_005c:
			num2 = _003C_003E1__state;
			num = 1;
			goto IL_0317;
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
		internal static TaskAwaiter CLJeP5KzDtQVhilVofK3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PbRxMCKziqC7UHgLGCy8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).DVPAElEC8W((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S877pMKznyOPJUsy5uZR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hGuPpZKzV2JW4xdhTYtF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Py7QSDKzfvR7UGvmBUyn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nFfXocKzdnvsw2S9tWwA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iZtejGKzlOjkMxdAcyGf(object P_0, bool enable)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).SetEnableInputGraphicValue(enable);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object csPAWbKzgfI8B7L8kUCR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iRkyW0KzsjxwqlIShFMZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation uYOM05KzvWZlSBM0w2xQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b9yrwuKzrlUJHaDyd5e4(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dpNlYYKzO8c3nRwy9Rvk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jvWN0kKzIasO9LQAemFA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly EditCompositeRegionViewModel gyhyVebXap;

	[CompilerGenerated]
	private readonly string hvwyLjXf48;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.CompositeRegion;
		}
	}

	public EditCompositeRegionViewModel EditCompositeRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gyhyVebXap;
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
			return hvwyLjXf48;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputCompositeRegionViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, string label, EditCompositeRegionViewModel editCompositeRegion, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (b3OOgqYEwY1uILmu1VL() ? 5 : 8);
		do
		{
			IL_005a:
			switch (num)
			{
			case 3:
				base._002Ector(tool, loc, displayName, isInitialized);
				break;
			case 7:
				gyhyVebXap = editCompositeRegion;
				goto case 6;
			default:
				num = 6;
				goto IL_005a;
			case 1:
				Refresh(cells, init: true);
				num = 4;
				goto IL_005a;
			case 4:
				RefreshLinks(updateMember: true);
				num = 9;
				goto IL_005a;
			case 0:
			case 8:
				hhd28lYpFiZDxkloO0x();
				num = 3;
				goto IL_005a;
			case 6:
				hvwyLjXf48 = label;
				num = 1;
				goto IL_005a;
			case 2:
			case 5:
				break;
			case 9:
				return;
			}
			DefaultLink = new SourceLink((string)SH2IfRYX6eYEwIX62jE(), ufLvxgY9eD0Ha6vv25i(editCompositeRegion).ToString(absoluteRow: true, absoluteColumn: true), CellType.CompositeRegion);
			num = 7;
		}
		while (vrQpboYqG4Ye9ibIBln());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddRef_003Ed__9))]
	public override Task AddRef(SourceLink link)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		_003CAddRef_003Ed__9 stateMachine = default;
		stateMachine.link = link;
		goto IL_0059;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				goto IL_0059;
			case 4:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0059:
		b3OOgqYEwY1uILmu1VL();
		num = (vrQpboYqG4Ye9ibIBln() ? 1 : 5);
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveRef_003Ed__10))]
	public override Task RemoveRef(SourceLink link)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vrQpboYqG4Ye9ibIBln();
		int num = (b3OOgqYEwY1uILmu1VL() ? 6 : 2);
		_003CRemoveRef_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.link = link;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = DwsmloY4NZLgF8dbht2();
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
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
	[CompilerGenerated]
	[DebuggerHidden]
	private Task m3uyYTHVV8(SourceLink P_0)
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
	private Task e9xy0TE97B(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RemoveRef(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hhd28lYpFiZDxkloO0x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SH2IfRYX6eYEwIX62jE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IqB0fK82cs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ufLvxgY9eD0Ha6vv25i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vrQpboYqG4Ye9ibIBln()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b3OOgqYEwY1uILmu1VL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder DwsmloY4NZLgF8dbht2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
