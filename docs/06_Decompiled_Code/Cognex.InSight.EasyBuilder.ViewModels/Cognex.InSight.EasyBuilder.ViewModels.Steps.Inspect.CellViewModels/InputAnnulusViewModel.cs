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

public class InputAnnulusViewModel : InputStructureViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddRef_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InputAnnulusViewModel _003C_003E4__this;

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
			int num = 4;
			if (!bDTucLKtCPvdqArOUyZa())
			{
				goto IL_001e;
			}
			goto IL_030c;
			IL_001e:
			InputAnnulusViewModel inputAnnulusViewModel = _003C_003E4__this;
			yF8S1gKtALSDSd3QpGa0();
			num = ((!bDTucLKtCPvdqArOUyZa()) ? 1 : 0);
			goto IL_030c;
			IL_030c:
			int num2 = default;
			TaskAwaiter<object> awaiter2 = default;
			TaskAwaiter awaiter = default;
			EzTool ezTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							bDTucLKtCPvdqArOUyZa();
							if (!yF8S1gKtALSDSd3QpGa0())
							{
								num3 = 6;
								if (!bDTucLKtCPvdqArOUyZa())
								{
									return;
								}
							}
							else
							{
								num3 = 17;
							}
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 4;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 16;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 9;
								continue;
							case 4:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 10:
							case 17:
								if (ezTool != inputAnnulusViewModel.Tool)
								{
									num3 = 12;
									if (bDTucLKtCPvdqArOUyZa())
									{
										continue;
									}
									return;
								}
								goto IL_0238;
							case 2:
								return;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 0:
							case 6:
								awaiter = okVjPhKtRSC22jMUlYgi(inputAnnulusViewModel.i2YyBka4q1(link));
								num3 = 15;
								continue;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 16:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 1:
								ezTool = ((InspectStepViewModel)fxDyKrKtWGr8APYcqBA8(inputAnnulusViewModel.Tool)).DVPAElEC8W(link.Text);
								if (ezTool != null)
								{
									goto case 10;
								}
								goto IL_0238;
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 14:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									num3 = 5;
									continue;
								}
								break;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 7;
							case 12:
								ezTool.SetEnableInputGraphicValue(enable: false);
								goto end_IL_0194;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 7:
								awaiter.GetResult();
								num3 = 1;
								continue;
							case 18:
								break;
								IL_0238:
								awaiter2 = ((CvsCogSocketSheet)SbcPGfKtytJxnS3PyDeV(HOFBshKtTM8ZOTVFv2IL(inputAnnulusViewModel.InSight))).ApplyCellAttributesAsync(new CvsCellRange(wN39c9Kt0i9V2UdajJOu(inputAnnulusViewModel.EditAnnulus)), new DictionaryEntry[1]
								{
									new DictionaryEntry(tZZr5eKtFgZALAkHet1k(51034), wN39c9Kt0i9V2UdajJOu(ORYO9KKtMHlnrdjqx1MH(inputAnnulusViewModel.Tool)).ToString(absoluteRow: true, absoluteColumn: true))
								}).GetAwaiter();
								num3 = 14;
								continue;
							}
							awaiter2.GetResult();
							break;
							continue;
							end_IL_0194:
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
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
		internal static TaskAwaiter okVjPhKtRSC22jMUlYgi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fxDyKrKtWGr8APYcqBA8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HOFBshKtTM8ZOTVFv2IL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SbcPGfKtytJxnS3PyDeV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation wN39c9Kt0i9V2UdajJOu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tZZr5eKtFgZALAkHet1k(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ORYO9KKtMHlnrdjqx1MH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bDTucLKtCPvdqArOUyZa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yF8S1gKtALSDSd3QpGa0()
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

		public InputAnnulusViewModel _003C_003E4__this;

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
			_ = 0;
			int num = ((!pPgZtcKtYFKZT62MDlJ8()) ? 2 : 3);
			InputAnnulusViewModel inputAnnulusViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					inputAnnulusViewModel = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
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
								goto IL_02c7;
							}
							awaiter2 = NQuvAvKtHmEsQ9ZxdVgA(inputAnnulusViewModel.vNYyZ7ebY0(link));
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
						EzTool ezTool = (EzTool)M9XrVkKtmgjTiaJ8Jdra(Vc0pJlKtxCbygbJwTN2h(inputAnnulusViewModel.Tool), link.Text);
						if (ezTool == null || ezTool == inputAnnulusViewModel.Tool)
						{
							awaiter = ((CvsCogSocketSheet)n9tmnKKtulajZw3oBEl4(Aylx1tKt1oK0UeRGu2yX(inputAnnulusViewModel.InSight))).ApplyCellAttributesAsync(new CvsCellRange(KnVVuuKthCOgy1CHEmWm(inputAnnulusViewModel.EditAnnulus)), new DictionaryEntry[1]
							{
								new DictionaryEntry(CdQUGaROfy7He9T0foW.KbIzwHEDLa(51034), CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838))
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02c7;
						}
						bool flag = false;
						IEnumerator<EzTool> enumerator = ((InspectStepViewModel)Vc0pJlKtxCbygbJwTN2h(inputAnnulusViewModel.Tool)).Tools.GetEnumerator();
						try
						{
							while (pn9j6oKt2Yw9fyZcll59(enumerator))
							{
								EzTool current = enumerator.Current;
								int num3 = 5;
								while (true)
								{
									object obj;
									switch (num3)
									{
									case 1:
									{
										InputAnnulusViewModel inputAnnulus = current.InputAnnulus;
										if (inputAnnulus == null)
										{
											goto default;
										}
										obj = inputAnnulus.SelectedLink.Text;
										goto IL_019d;
									}
									default:
										zj2opUKtUCHv15j1iyhU();
										if (pPgZtcKtYFKZT62MDlJ8())
										{
											num3 = 0;
											continue;
										}
										num3 = 4;
										if (pPgZtcKtYFKZT62MDlJ8())
										{
											continue;
										}
										goto case 3;
									case 0:
									case 2:
										obj = null;
										goto IL_019d;
									case 3:
									case 4:
										flag = true;
										num3 = 6;
										continue;
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
										goto end_IL_0152;
									case 6:
										goto end_IL_0152;
										IL_019d:
										if (!RphorxKtNdippQvvZ2QD(obj, uZfBwwKtQmSPJjeWCvcc(link)))
										{
											break;
										}
										goto case 3;
									}
									goto IL_01ee;
									continue;
									end_IL_0152:
									break;
								}
								break;
								IL_01ee:;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								enumerator?.Dispose();
							}
						}
						if (!flag)
						{
							HmCSo1KtcBqMUAw6HL03(ezTool, true);
						}
						goto end_IL_0061;
						IL_02c7:
						awaiter.GetResult();
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
		internal static TaskAwaiter NQuvAvKtHmEsQ9ZxdVgA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vc0pJlKtxCbygbJwTN2h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M9XrVkKtmgjTiaJ8Jdra(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).DVPAElEC8W((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uZfBwwKtQmSPJjeWCvcc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RphorxKtNdippQvvZ2QD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pn9j6oKt2Yw9fyZcll59(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HmCSo1KtcBqMUAw6HL03(object P_0, bool enable)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).SetEnableInputGraphicValue(enable);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Aylx1tKt1oK0UeRGu2yX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n9tmnKKtulajZw3oBEl4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation KnVVuuKthCOgy1CHEmWm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pPgZtcKtYFKZT62MDlJ8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zj2opUKtUCHv15j1iyhU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly EditAnnulusViewModel aW2ynLSN7X;

	[CompilerGenerated]
	private readonly string oJXyta6ulm;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Annulus;
		}
	}

	public EditAnnulusViewModel EditAnnulus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aW2ynLSN7X;
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
			return oJXyta6ulm;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputAnnulusViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, string label, EditAnnulusViewModel editAnnulus, bool isInitialized)
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
				RefreshLinks(updateMember: true);
				num = 9;
				break;
			case 2:
			case 7:
				DefaultLink = new SourceLink((string)sMiKQtYSaG85kML6Ibw(), ja2pOlYk7FEwJww77em(editAnnulus).ToString(absoluteRow: true, absoluteColumn: true), CellType.Annulus);
				goto case 3;
			case 8:
				oJXyta6ulm = label;
				num = 5;
				break;
			case 0:
				base._002Ector(tool, loc, displayName, isInitialized);
				zuJ4apYGqVpx8F93U7l();
				num = (JkjvYyYb8CStbC5HxV2() ? 7 : 6);
				break;
			case 5:
				Refresh(cells, init: true);
				num = 4;
				if (JkjvYyYb8CStbC5HxV2())
				{
					break;
				}
				goto case 3;
			case 3:
			case 6:
				aW2ynLSN7X = editAnnulus;
				goto case 8;
			default:
				num = 8;
				break;
			case 1:
				WTrEtyYo28Y1YRnEdcx();
				num = 0;
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
		_ = 0;
		int num = ((!JkjvYyYb8CStbC5HxV2()) ? 5 : 2);
		_003CAddRef_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine.link = link;
				goto case 6;
			default:
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = qCerQuY8ee7UycJZmhE();
				goto case 1;
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
		int num = 6;
		_003CRemoveRef_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine.link = link;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = qCerQuY8ee7UycJZmhE();
				_ = 0;
				if (!JkjvYyYb8CStbC5HxV2())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (JkjvYyYb8CStbC5HxV2())
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
	[DebuggerHidden]
	[CompilerGenerated]
	private Task i2YyBka4q1(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.AddRef(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task vNYyZ7ebY0(SourceLink P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RemoveRef(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WTrEtyYo28Y1YRnEdcx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sMiKQtYSaG85kML6Ibw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IqB0fK82cs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ja2pOlYk7FEwJww77em(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JkjvYyYb8CStbC5HxV2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zuJ4apYGqVpx8F93U7l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder qCerQuY8ee7UycJZmhE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
