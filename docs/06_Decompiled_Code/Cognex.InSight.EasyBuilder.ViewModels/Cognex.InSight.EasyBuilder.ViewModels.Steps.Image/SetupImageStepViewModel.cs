using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Image.AcquireActions;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Filmstrip.ViewModels;
using Cognex.InSight.Graphic;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Acq;
using Cognex.InSight.Runtime.ViewModels.Acq.AcquireActions;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

[Export(typeof(AppStepViewModel))]
[Shared]
public class SetupImageStepViewModel : AppStepViewModel, IInSightAppStep, IAcqInSightAppStep
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBeginInitialization_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SetupImageStepViewModel _003C_003E4__this;

		public bool jobLoading;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AhX9vB55hnYWJZtM63d1();
			int num;
			if (!mfgoak55tEWPv0vvv32R())
			{
				num = 1;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_026c;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (mfgoak55tEWPv0vvv32R())
			{
			}
			goto IL_026c;
			IL_026c:
			int num2 = default;
			SetupImageStepViewModel setupImageStepViewModel = default;
			TaskAwaiter awaiter = default;
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
							setupImageStepViewModel.cVaeala7Sm();
							num3 = 12;
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
							case 3:
								_003C_003Eu__1 = default;
								num3 = 13;
								if (mfgoak55tEWPv0vvv32R())
								{
								}
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								goto IL_0088;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto IL_0088;
							case 1:
							case 8:
								if (setupImageStepViewModel.AutoExposure != null)
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									return;
								}
								goto IL_008f;
							case 14:
								return;
							case 2:
								setupImageStepViewModel.RbuedE9lJB = new TunaISL38ViewModel(setupImageStepViewModel);
								goto end_IL_0149;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 14;
								continue;
							case 7:
								awaiter = MmS9gt5wL2iOOLkyX4k5(p6XZ9A55zp4sxbGiYcdn(setupImageStepViewModel.AutoExposure));
								num3 = 5;
								continue;
							case 4:
							case 11:
								if (!lhmKEQ5w5ox8vh6rOpb2(TSR2Vs5wKTUSKXlKG70m(setupImageStepViewModel)))
								{
									if (piu1Lm5ww4bn60QpIIcM(TSR2Vs5wKTUSKXlKG70m(setupImageStepViewModel)))
									{
										num3 = 15;
										continue;
									}
									goto end_IL_0149;
								}
								num3 = 2;
								continue;
							case 10:
								if (!((BaseIdeViewModel)TSR2Vs5wKTUSKXlKG70m(setupImageStepViewModel)).IsEmulator)
								{
									goto case 4;
								}
								goto end_IL_0149;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								if (!jobLoading)
								{
									_ = 0;
									if (!AhX9vB55hnYWJZtM63d1())
									{
										num3 = 4;
										continue;
									}
									num3 = 8;
									if (AhX9vB55hnYWJZtM63d1())
									{
										continue;
									}
									break;
								}
								goto IL_008f;
							case 15:
								break;
								IL_0088:
								awaiter.GetResult();
								goto IL_008f;
								IL_008f:
								setupImageStepViewModel.AutoExposure = null;
								num3 = 10;
								if (AhX9vB55hnYWJZtM63d1())
								{
									continue;
								}
								goto case 5;
							}
							setupImageStepViewModel.RbuedE9lJB = new TunaPumbaaViewModel(setupImageStepViewModel);
							break;
							continue;
							end_IL_0149:
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
				case 4:
					setupImageStepViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
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
		internal static object p6XZ9A55zp4sxbGiYcdn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AutoExposure)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MmS9gt5wL2iOOLkyX4k5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TSR2Vs5wKTUSKXlKG70m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lhmKEQ5w5ox8vh6rOpb2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).IsL38Device;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool piu1Lm5ww4bn60QpIIcM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).IsPumbaaDevice;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AhX9vB55hnYWJZtM63d1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mfgoak55tEWPv0vvv32R()
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
	private struct _003CDoAutoExposureAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SetupImageStepViewModel _003C_003E4__this;

		private ITopLevelProgressableOperation _003Cprogress_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Y7lMjn5wJpAJ0ndffsF7();
			int num;
			if (!TK61Cn5wan1vmZRcKscl())
			{
				num = 2;
				if (TK61Cn5wan1vmZRcKscl())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 6;
				if (!Y7lMjn5wJpAJ0ndffsF7())
				{
					goto IL_0585;
				}
			}
			goto IL_054a;
			IL_054a:
			SetupImageStepViewModel setupImageStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<EzSupportSnippet> awaiter2 = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 4:
					setupImageStepViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (Y7lMjn5wJpAJ0ndffsF7())
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						if ((uint)num2 <= 1u)
						{
							goto IL_00b1;
						}
						if (num2 == 2)
						{
							goto IL_035e;
						}
						object obj = nQoPVw5weSY2liThRSDd(setupImageStepViewModel);
						if (obj != null && !((EasyBuilderApplicationViewModel)obj).IsLiveMode)
						{
							_003Cprogress_003E5__2 = null;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto IL_00b1;
						}
						goto end_IL_006b;
						IL_00b1:
						try
						{
							_ = 1;
							try
							{
								int num3;
								if (num2 != 0)
								{
									if (num2 != 1)
									{
										num3 = 7;
									}
									else
									{
										awaiter = _003C_003Eu__2;
										num3 = 8;
									}
								}
								else
								{
									awaiter2 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 17;
									if (!Y7lMjn5wJpAJ0ndffsF7())
									{
										goto IL_01ef;
									}
								}
								goto IL_020a;
								IL_010e:
								result = awaiter2.GetResult();
								_ = 1;
								if (!TK61Cn5wan1vmZRcKscl())
								{
									num3 = 3;
								}
								else
								{
									num3 = 4;
									if (!Y7lMjn5wJpAJ0ndffsF7())
									{
										goto IL_0185;
									}
								}
								goto IL_020a;
								IL_020a:
								while (true)
								{
									switch (num3)
									{
									case 11:
										awaiter2 = setupImageStepViewModel.QuBeACVAPt.OfType<AutoExposureType>().First().AddSupportSnippet((ISnippetManager)nQoPVw5weSY2liThRSDd(setupImageStepViewModel))
											.GetAwaiter();
										num3 = 15;
										continue;
									case 5:
										if (!awaiter.IsCompleted)
										{
											num3 = 14;
											continue;
										}
										goto case 18;
									case 2:
										break;
									case 16:
										num2 = (_003C_003E1__state = 0);
										num3 = 13;
										continue;
									case 13:
										_003C_003Eu__1 = awaiter2;
										num3 = 1;
										continue;
									case 6:
										num2 = (_003C_003E1__state = -1);
										num3 = 18;
										continue;
									case 3:
									case 9:
										setupImageStepViewModel.AutoExposure = result as AutoExposure;
										goto case 4;
									case 8:
										goto IL_0185;
									case 4:
									case 10:
										awaiter = R8exgP5wDVv5vJhGLR14(xwFAYf5wIE8RO3XNo7HK(setupImageStepViewModel.AutoExposure));
										num3 = 5;
										if (Y7lMjn5wJpAJ0ndffsF7())
										{
											continue;
										}
										return;
									case 12:
										return;
									case 17:
										goto IL_01ef;
									default:
										num3 = 2;
										continue;
									case 7:
									{
										IOperationProgressManager operationProgressManager = setupImageStepViewModel.OperationProgressManager;
										if (operationProgressManager == null || !fFjHZD5wOrcE6TTHjAFN(operationProgressManager))
										{
											goto case 11;
										}
										_003Cprogress_003E5__2 = setupImageStepViewModel.OperationProgressManager.StartBlockingOperation(Resources.bV1nsALGfY());
										num3 = 11;
										if (true)
										{
											continue;
										}
										goto case 15;
									}
									case 15:
										if (awaiter2.IsCompleted)
										{
											break;
										}
										num3 = 16;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 1:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 12;
										if (Y7lMjn5wJpAJ0ndffsF7())
										{
											continue;
										}
										goto case 14;
									case 14:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter;
										num3 = 0;
										continue;
									case 18:
										awaiter.GetResult();
										goto end_IL_00b6;
									}
									break;
								}
								goto IL_010e;
								IL_0185:
								_003C_003Eu__2 = default;
								num3 = 6;
								if (TK61Cn5wan1vmZRcKscl())
								{
								}
								goto IL_020a;
								IL_01ef:
								num2 = (_003C_003E1__state = -1);
								goto IL_010e;
								end_IL_00b6:;
							}
							catch (Exception ex)
							{
								L9Ge7v5wn1VmLLD8cAhS(setupImageStepViewModel.F7JeNZXAub, cOQKMj5wiGTMfvCu0eiN(51258), ex);
							}
						}
						catch (object obj2)
						{
							_003C_003E7__wrap2 = obj2;
						}
						goto IL_035e;
						IL_035e:
						try
						{
							int num4;
							if (num2 != 2)
							{
								num4 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 2:
									if (!awaiter.IsCompleted)
									{
										num4 = 9;
										continue;
									}
									goto case 8;
								case 4:
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num4 = 3;
									continue;
								case 0:
									_003C_003Eu__2 = default;
									num4 = 5;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 2);
									num4 = 1;
									continue;
								case 1:
									_003C_003Eu__2 = awaiter;
									Y7lMjn5wJpAJ0ndffsF7();
									num4 = (TK61Cn5wan1vmZRcKscl() ? 10 : 7);
									continue;
								case 3:
									return;
								case 6:
									if (setupImageStepViewModel.AutoExposure != null)
									{
										awaiter = R8exgP5wDVv5vJhGLR14(HN56Ig5wVtNhXkyvt2u8(setupImageStepViewModel.AutoExposure));
										num4 = 2;
										continue;
									}
									break;
								case 8:
								case 10:
									awaiter.GetResult();
									num4 = 11;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									goto case 8;
								case 11:
									setupImageStepViewModel.AutoExposure = null;
									break;
								}
								break;
							}
						}
						catch (Exception exception)
						{
							setupImageStepViewModel.F7JeNZXAub.InfoException(CdQUGaROfy7He9T0foW.KbIzwHEDLa(51340), exception);
						}
						ITopLevelProgressableOperation topLevelProgressableOperation = _003Cprogress_003E5__2;
						if (topLevelProgressableOperation != null)
						{
							PtjgbL5wfnkMcD5PWLFH(topLevelProgressableOperation);
						}
						object obj3 = _003C_003E7__wrap2;
						if (obj3 != null)
						{
							wx2Twl5wlSeCgEMM0xuL(b3dBuh5wdJ512T8e2xXG((obj3 as Exception) ?? throw obj3));
						}
						_003C_003E7__wrap2 = null;
						end_IL_006b:;
					}
					catch (Exception exception2)
					{
						_003C_003E1__state = -2;
						_003Cprogress_003E5__2 = null;
						_003C_003Et__builder.SetException(exception2);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0585;
				default:
					goto IL_0585;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_0585:
			_003Cprogress_003E5__2 = null;
			num = 1;
			goto IL_054a;
			IL_002e:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_054a;
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
		internal static object nQoPVw5weSY2liThRSDd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fFjHZD5wOrcE6TTHjAFN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xwFAYf5wIE8RO3XNo7HK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AutoExposure)P_0).RunAutoExposureAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter R8exgP5wDVv5vJhGLR14(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cOQKMj5wiGTMfvCu0eiN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void L9Ge7v5wn1VmLLD8cAhS(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).InfoException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HN56Ig5wVtNhXkyvt2u8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AutoExposure)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PtjgbL5wfnkMcD5PWLFH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b3dBuh5wdJ512T8e2xXG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wx2Twl5wlSeCgEMM0xuL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y7lMjn5wJpAJ0ndffsF7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TK61Cn5wan1vmZRcKscl()
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
	private struct _003CDoSetCameraAsImageSource_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SetupImageStepViewModel _003C_003E4__this;

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
			SetupImageStepViewModel setupImageStepViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!kWh6Ie5wvTlNYWdWwXEt(setupImageStepViewModel.AppViewModel))
							{
								ogJ20g5wP37Ps2u75cma(setupImageStepViewModel.AcqSettings, new CameraAcquireAction((CvsInSight)CXLdXr5wrEoKG1pT0SEW(setupImageStepViewModel)));
								goto IL_010d;
							}
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						goto IL_0072;
						IL_0072:
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (U1PmSh5wgyiWE1u5cJyR())
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter.IsCompleted)
								{
									goto default;
								}
								goto case 12;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
							case 4:
								break;
							case 8:
								goto IL_0129;
							case 9:
								setupImageStepViewModel.FirePropertyChangedExplicit((string)d6OqI25wBpgj2tdYOeWs(51436));
								num3 = 0;
								continue;
							case 0:
								awaiter = ((Task)yCev935wb5TdIhghoCgs(setupImageStepViewModel.RuntimeService)).GetAwaiter();
								num3 = 3;
								continue;
							case 2:
								goto IL_016f;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
							IL_016f:
							setupImageStepViewModel.AcqSettings.AcquireAction = new Emulator3DCameraAcquireAction((CvsInSight)CXLdXr5wrEoKG1pT0SEW(setupImageStepViewModel));
							_ = 0;
							num3 = (U1PmSh5wgyiWE1u5cJyR() ? 4 : 10);
						}
						goto IL_010d;
						IL_0129:
						_003C_003Eu__1 = awaiter;
						num3 = 11;
						goto IL_0072;
						IL_010d:
						M25Qh35wZ2xHuNnHUThd(setupImageStepViewModel.AcqSettings, false);
						num3 = 9;
						if (!gXdGjC5wsXWLpFuEXmpm())
						{
							goto IL_0072;
						}
						goto IL_0129;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				setupImageStepViewModel = _003C_003E4__this;
				_ = 1;
				if (gXdGjC5wsXWLpFuEXmpm())
				{
					num = 4;
					continue;
				}
				num = 1;
				if (false)
				{
					break;
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
		internal static bool kWh6Ie5wvTlNYWdWwXEt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).IsL38Emulator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CXLdXr5wrEoKG1pT0SEW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ogJ20g5wP37Ps2u75cma(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AcquisitionSettingsViewModel)P_0).AcquireAction = (IAcquireAction)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M25Qh35wZ2xHuNnHUThd(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AcquisitionSettingsViewModel)P_0).IsImageSourceSetToImageFolder = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d6OqI25wBpgj2tdYOeWs(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yCev935wb5TdIhghoCgs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).TriggerOnce();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U1PmSh5wgyiWE1u5cJyR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gXdGjC5wsXWLpFuEXmpm()
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
	private struct _003CDoSetImageFolderAsImageSource_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SetupImageStepViewModel _003C_003E4__this;

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
			if (vPPID05wGT5EKBVlkhQd())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (EPrZBL5wob2vMecne9VK())
				{
					goto IL_0041;
				}
			}
			goto IL_0239;
			IL_0239:
			int num2 = default;
			SetupImageStepViewModel setupImageStepViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							AcquisitionSettingsViewModel acqSettings = setupImageStepViewModel.AcqSettings;
							CvsInSight inSight = setupImageStepViewModel.InSight;
							object obj = bMIl3U5wSASfvqQjbRS9(setupImageStepViewModel);
							object imageFolderActions;
							if (obj == null)
							{
								imageFolderActions = null;
							}
							else
							{
								FilmstripPanelViewModel filmstrip = ((EasyBuilderApplicationViewModel)obj).Filmstrip;
								imageFolderActions = ((filmstrip != null) ? a5fBLP5wkVPf6husbv10(filmstrip) : null);
							}
							object obj2 = bMIl3U5wSASfvqQjbRS9(setupImageStepViewModel);
							Pw4Uqr5wq6c5lpjgpvK3(acqSettings, new ImageFolderAcquireAction(inSight, (FilmstripActionsViewModel)imageFolderActions, (ImageManagementViewModel)((obj2 != null) ? oJxBN75w8TVQfcav93qH(obj2) : null)));
							num3 = 2;
							if (false)
							{
								goto IL_00c0;
							}
							goto IL_0186;
						}
						awaiter = _003C_003Eu__1;
						goto IL_01e1;
						IL_01e1:
						_003C_003Eu__1 = default;
						num3 = 5;
						if (0 == 0)
						{
							goto IL_0186;
						}
						goto IL_01f9;
						IL_01f9:
						awaiter.GetResult();
						goto end_IL_0056;
						IL_0186:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 2:
								goto IL_00e9;
							case 5:
								goto IL_0105;
							case 10:
								goto IL_011a;
							case 4:
								gXQy9a5wXEte0aUy4iqW(setupImageStepViewModel, hmOLnk5wpHmtBjmAneFQ(51436));
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto IL_011a;
							default:
								num3 = 10;
								continue;
							case 3:
							case 6:
								return;
							case 7:
							case 9:
								goto IL_01e1;
							case 11:
								goto IL_01f9;
							}
							break;
						}
						goto IL_00c0;
						IL_0105:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						if (false)
						{
							goto IL_011a;
						}
						goto IL_0186;
						IL_00e9:
						AZb8rn5wEj18vgiwnheZ(setupImageStepViewModel.AcqSettings, true);
						num3 = 4;
						if (!vPPID05wGT5EKBVlkhQd())
						{
							goto IL_0105;
						}
						goto IL_0186;
						IL_00c0:
						awaiter = sgpub25w4gl4Mn1tpEAb(kA34745w9sBngBraBUnB(setupImageStepViewModel.RuntimeService));
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							if (false)
							{
								goto IL_00e9;
							}
							goto IL_0186;
						}
						goto IL_01f9;
						IL_011a:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						_ = 1;
						num3 = (EPrZBL5wob2vMecne9VK() ? 9 : 3);
						goto IL_0186;
						end_IL_0056:;
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
				case 1:
				case 3:
					setupImageStepViewModel = _003C_003E4__this;
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
			goto IL_0041;
			IL_0041:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0239;
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
		internal static object bMIl3U5wSASfvqQjbRS9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a5fBLP5wkVPf6husbv10(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FilmstripPanelViewModel)P_0).ActionsVm;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oJxBN75w8TVQfcav93qH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).ImageManagement;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pw4Uqr5wq6c5lpjgpvK3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AcquisitionSettingsViewModel)P_0).AcquireAction = (IAcquireAction)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AZb8rn5wEj18vgiwnheZ(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AcquisitionSettingsViewModel)P_0).IsImageSourceSetToImageFolder = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hmOLnk5wpHmtBjmAneFQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gXQy9a5wXEte0aUy4iqW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kA34745w9sBngBraBUnB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).TriggerOnce();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sgpub25w4gl4Mn1tpEAb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vPPID05wGT5EKBVlkhQd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EPrZBL5wob2vMecne9VK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public object sender;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass61_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PNRX9u5wAlEBAEQVfwHU();
			kppmyB5wRl07nUMfm4t2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRegionProp_PropertyChanged_003Eb__0(CvsEditableDisplayGraphic p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kHiC9e5wWDSJDYPaeiS1(p) == sender;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PNRX9u5wAlEBAEQVfwHU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kppmyB5wRl07nUMfm4t2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tuc1sV5w6QTKS37a0WML()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GCOhyM5wC5j3uuSbDtEb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kHiC9e5wWDSJDYPaeiS1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Tag;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass66_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ylU5Qt5w0B634lV6Xk45();
			NJjlnL5wFsUHXUfTTJ5R(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EIAcqInSightAppStep_002ESupports_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)tNluAe5wMQaRx5fiI9RY(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ylU5Qt5w0B634lV6Xk45()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NJjlnL5wFsUHXUfTTJ5R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aC8mcN5wTqXQmxfBnLV1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KIIQv95wyJm241w0XE0X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tNluAe5wMQaRx5fiI9RY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass67_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SGWg1L5wHQracuIKvjpx();
			dNF0sU5wxNAOATmS9Pdc(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EIAcqInSightAppStep_002EAddSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)oCpRCh5wmO2tQ1Lj4Wge(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SGWg1L5wHQracuIKvjpx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dNF0sU5wxNAOATmS9Pdc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d0LPes5wYRGFByPy23OR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S6TvEc5wUF8C7FlEVmtR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oCpRCh5wmO2tQ1Lj4Wge(object P_0)
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DIAcqInSightAppStep_002DAddSnippet_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public SetupImageStepViewModel _003C_003E4__this;

		public CvsCellRange snippetRange;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			SetupImageStepViewModel setupImageStepViewModel = default;
			int num2 = default;
			_003C_003Ec__DisplayClass67_0 obj = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					setupImageStepViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
					while (true)
					{
						num2 = _003C_003E1__state;
						KMpQu15wNNHpsqCIiyvj();
						if (hAfIQW5wQ8g7S3a3mPKb())
						{
							break;
						}
						num = 5;
						if (true)
						{
							goto end_IL_0210;
						}
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass67_0();
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								_ = 1;
								num3 = (KMpQu15wNNHpsqCIiyvj() ? 9 : 10);
								continue;
							case 5:
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 2:
								obj.guid = guid;
								num3 = 3;
								continue;
							case 7:
								awaiter = ((CvsInSight)TZBRfS5w2ZdhAmiQVPws(setupImageStepViewModel)).CogSocket.Sheet.ClearCellsAsync(snippetRange).GetAwaiter();
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								if (setupImageStepViewModel.QuBeACVAPt.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EIAcqInSightAppStep_002EAddSnippet_003Eb__0) is AutoExposureType)
								{
									num3 = 7;
									continue;
								}
								goto end_IL_009a;
							case 6:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_009a:
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
				case 6:
					return;
					end_IL_0210:
					break;
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
		internal static object TZBRfS5w2ZdhAmiQVPws(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hAfIQW5wQ8g7S3a3mPKb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KMpQu15wNNHpsqCIiyvj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly List<CvsEditableDisplayGraphic> lMVe7APgN4;

	private readonly ILogger F7JeNZXAub;

	private EzSupportSnippetType[] QuBeACVAPt;

	private BaseViewModel RbuedE9lJB;

	private AcqEasyBuilder3dMotionInput S09e6bUwB8;

	private int DrueuuPU9j;

	private bool hYreFfWZHo;

	[CompilerGenerated]
	private AutoExposure pQ2eXyQCA0;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand bNseoAACbA;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand xBOeSKwsSA;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand cadeDDR3tD;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_SetupImageIcon;
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
			return (string)jC1TvexcqX2N0J2CdtV();
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
			return (string)Mmag0ix1pTbmX27E1g2();
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
			return (string)exwMgfxugkxvcqgs2ea();
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
			return AppStepHelpTopics.Image;
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
			return DrueuuPU9j;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref DrueuuPU9j, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3256));
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
			return hYreFfWZHo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!xay6xrxQ94EuLTaLPU3())
			{
				goto IL_001e;
			}
			goto IL_0040;
			IL_001e:
			ud3hujxtQpVGvd0EWbe(this, WBtyq3xhVbIMRkirKEF(28792));
			goto IL_00bf;
			IL_0040:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 4:
					if (SetField(ref hYreFfWZHo, value, (string)WBtyq3xhVbIMRkirKEF(3942)))
					{
						num = 0;
						continue;
					}
					return;
				case 0:
					FirePropertyChangedExplicit((string)WBtyq3xhVbIMRkirKEF(3996));
					_ = 0;
					if (!xay6xrxQ94EuLTaLPU3())
					{
						num = 5;
						if (true)
						{
							continue;
						}
						goto case 4;
					}
					num = 1;
					continue;
				default:
					goto IL_00bf;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_00bf:
			ImageStepDisplay obj = StepDisplay as ImageStepDisplay;
			if (obj == null)
			{
				num = 6;
				goto IL_0040;
			}
			obj.RefreshEditableGraphics();
		}
	}

	public bool IsEasyBuilderSimpleModeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !vKvassmLweaHbkvB3wS(PHdQ3axzPqfg37jeDnj(this));
		}
	}

	public bool IsEasyBuilderAdvancedModeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !vKvassmLweaHbkvB3wS(AppViewModel);
		}
	}

	public bool ShowEasyBuilderAdvancedMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
				default:
					if (!lpxOj2mKOsNUD4rib3p(PHdQ3axzPqfg37jeDnj(this)))
					{
						num = 5;
						continue;
					}
					break;
				case 4:
					if (!hYreFfWZHo)
					{
						break;
					}
					_ = 0;
					if (xay6xrxQ94EuLTaLPU3())
					{
						num = 3;
						if (!WdaB73xN8Jld0fkF717())
						{
							continue;
						}
						goto case 1;
					}
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 1:
				case 3:
					if (!IsEasyBuilderAdvancedModeSupported)
					{
						break;
					}
					goto default;
				case 5:
					return !AppViewModel.IsPumbaaDevice;
				}
				break;
			}
			return false;
		}
	}

	public bool ShowEasyBuilderEasyMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!hYreFfWZHo)
			{
				return IsEasyBuilderSimpleModeSupported;
			}
			return false;
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
				return (string)CsexZRm5SLExf1hhqRf();
			}
			return (string)y6kWx7mwR5dSGyqHABU();
		}
	}

	public AutoExposure AutoExposure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pQ2eXyQCA0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pQ2eXyQCA0 = value;
		}
	}

	public AcquisitionSettingsViewModel AcqSettings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AcquisitionSettingsViewModel)KtthiAmJfF1LrYrUQif(PHdQ3axzPqfg37jeDnj(this));
		}
	}

	public AcqEncoderCounterViewModel AcqEncoderCounter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AcqEncoderCounterViewModel)nXFlcAmaTRNo1HHvnhW(PHdQ3axzPqfg37jeDnj(this));
		}
	}

	public AsyncDelegateCommand AutoExposureAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bNseoAACbA;
		}
	}

	public AsyncDelegateCommand SetCameraAsImageSourceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xBOeSKwsSA;
		}
	}

	public AsyncDelegateCommand SetImageFolderAsImageSourceCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cadeDDR3tD;
		}
	}

	public bool IsImageSourceSetToImageFolder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AcquisitionSettingsViewModel acqSettings = AcqSettings;
			if (acqSettings == null)
			{
				return false;
			}
			return UbOEFImnLTfjp2IHGcM(acqSettings);
		}
	}

	public AsyncDelegateCommand LoadImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AsyncDelegateCommand)e2oY08mZ1Irv1XjHRmm(((BaseIdeViewModel)PHdQ3axzPqfg37jeDnj(this)).ImageManagement);
		}
	}

	CvsInSight IAcqInSightAppStep.AcqInSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsInSight)xg7GhHmBNJaU20x6Ryl(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetupImageStepViewModel()
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
			case 3:
			case 9:
				base._002Ector();
				num = 4;
				if (!WdaB73xN8Jld0fkF717())
				{
					continue;
				}
				goto case 7;
			case 7:
				cadeDDR3tD = new AsyncDelegateCommand(A5yep4dtXg);
				num = 10;
				if (!WdaB73xN8Jld0fkF717())
				{
					continue;
				}
				goto case 10;
			case 10:
				StepDisplay = new ImageStepDisplay(null, this);
				num = 0;
				continue;
			case 5:
				xBOeSKwsSA = new AsyncDelegateCommand(bjEe5aIBkH);
				num = 7;
				if (!WdaB73xN8Jld0fkF717())
				{
					continue;
				}
				goto case 0;
			case 0:
				ShowInSightDisplay = true;
				num = 11;
				continue;
			case 4:
				bNseoAACbA = new AsyncDelegateCommand(DoAutoExposureAsync);
				goto case 5;
			default:
				num = 5;
				continue;
			case 2:
			case 8:
				F7JeNZXAub = LogManager.GetLogger<AutoExposure>();
				goto case 3;
			case 1:
				SFhRG6x2QtVYh1v7Oh0();
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 6:
				break;
			case 11:
				return;
			}
			lMVe7APgN4 = new List<CvsEditableDisplayGraphic>();
			xay6xrxQ94EuLTaLPU3();
			if (WdaB73xN8Jld0fkF717())
			{
				num = 9;
				continue;
			}
			num = 8;
			if (WdaB73xN8Jld0fkF717())
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBeginInitialization_003Ed__42))]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CBeginInitialization_003Ed__42 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 5:
				stateMachine.jobLoading = jobLoading;
				goto default;
			default:
				xay6xrxQ94EuLTaLPU3();
				num = (WdaB73xN8Jld0fkF717() ? 1 : 6);
				break;
			case 0:
				stateMachine._003C_003Et__builder = KnhRNVmeUgRQPkJsQ3G();
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (WdaB73xN8Jld0fkF717())
				{
				}
				break;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cVaeala7Sm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QuBeACVAPt = new EzSupportSnippetType[1]
		{
			new AutoExposureType(this)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
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
			case 7:
				tq9iNBmI5nvVn75CF6v(AcqSettings, SetCameraAsImageSourceCommand);
				goto case 1;
			case 0:
				AcqSettings.EasyMode3DMotionInputAction = S09e6bUwB8.Command;
				goto case 7;
			default:
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				DewkYomObXvr4A6Vqaj(AcqSettings, AutoExposureAction);
				num = 4;
				break;
			case 2:
			case 6:
				S09e6bUwB8 = new AcqEasyBuilder3dMotionInput(AcqSettings);
				num = 0;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				Tbm1y7mDWwxRc6fiaQp(AcqSettings, SetImageFolderAsImageSourceCommand);
				num = 8;
				break;
			case 4:
				if (((BaseIdeViewModel)PHdQ3axzPqfg37jeDnj(this)).IsL38Device)
				{
					_ = 1;
					num = (WdaB73xN8Jld0fkF717() ? 1 : 6);
					break;
				}
				goto case 7;
			case 8:
				return (Task)MHNLiSmi7eTiSRu7cLV();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAutoExposureAsync_003Ed__48))]
	public Task DoAutoExposureAsync()
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
		goto IL_008a;
		IL_001a:
		_003CDoAutoExposureAsync_003Ed__48 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (WdaB73xN8Jld0fkF717())
		{
		}
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = KnhRNVmeUgRQPkJsQ3G();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!WdaB73xN8Jld0fkF717())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (WdaB73xN8Jld0fkF717())
				{
				}
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoSetCameraAsImageSource_003Ed__52))]
	private Task bjEe5aIBkH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDoSetCameraAsImageSource_003Ed__52 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder = KnhRNVmeUgRQPkJsQ3G();
				_ = 1;
				num = ((!WdaB73xN8Jld0fkF717()) ? 3 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoSetImageFolderAsImageSource_003Ed__56))]
	private Task A5yep4dtXg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CDoSetImageFolderAsImageSource_003Ed__56 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (xay6xrxQ94EuLTaLPU3())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 3:
				stateMachine._003C_003Et__builder = KnhRNVmeUgRQPkJsQ3G();
				WdaB73xN8Jld0fkF717();
				if (!xay6xrxQ94EuLTaLPU3())
				{
					num = 0;
					if (WdaB73xN8Jld0fkF717())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsEditableDisplayGraphic> GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lMVe7APgN4.Clear();
		foreach (AcqPropertyViewModel item in AcqSettings.SettingGroups.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (AcqPropertyGroupViewModel g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.Values;
		}))
		{
			bool flag = !IsEasyBuilderAdvancedMode && item.PropertyId.Contains(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28850));
			if (item is AcqRegionPropertyViewModel acqRegionPropertyViewModel && !flag)
			{
				CvsDisplayableRegion cvsDisplayableRegion = EditableGraphicHelper.ConstructRegion(acqRegionPropertyViewModel.LocalValue, acqRegionPropertyViewModel.Bounds, acqRegionPropertyViewModel.DisplayName);
				cvsDisplayableRegion.Tag = acqRegionPropertyViewModel;
				cvsDisplayableRegion.EditFlags &= ~(CvsEditFlags.Rotation | CvsEditFlags.Bend);
				lMVe7APgN4.Add(cvsDisplayableRegion);
			}
		}
		return lMVe7APgN4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteGraphic(CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!WdaB73xN8Jld0fkF717())
		{
			num = 7;
			if (WdaB73xN8Jld0fkF717())
			{
			}
		}
		else
		{
			num = 5;
		}
		AcqRegionPropertyViewModel acqRegionPropertyViewModel = default;
		CvsGraphicRegion region = default;
		CvsDisplayableRegion cvsDisplayableRegion = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				acqRegionPropertyViewModel.PropertyChanged -= Nv0eUfgJbx;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
			case 5:
				region = cvsDisplayableRegion.Region;
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				if (cvsDisplayableRegion != null)
				{
					num = 9;
					break;
				}
				return;
			case 0:
			case 7:
				cvsDisplayableRegion = editableGraphic as CvsDisplayableRegion;
				num = 8;
				break;
			case 6:
				acqRegionPropertyViewModel.LocalValue = new CvsCogRegion(hOXuWYmfBUL03OluBdp(region).X, hOXuWYmfBUL03OluBdp(region).Y, lhSR0imdBnUkcJ5Z0Bo(region), z7kQIImlyKLQjIpLIs4(region), DgSh0UmgdQljVYNlCEW(region), bWTwO9msSOsCpC4aW9d(region));
				num = 2;
				break;
			case 9:
				acqRegionPropertyViewModel = SMJmP7mVxZYwPCKUwYB(editableGraphic) as AcqRegionPropertyViewModel;
				num = 3;
				break;
			case 2:
				eVPqsSmvxRYpPnuGDu6(acqRegionPropertyViewModel, new PropertyChangedEventHandler(Nv0eUfgJbx));
				num = 10;
				break;
			case 3:
				if (acqRegionPropertyViewModel != null)
				{
					goto case 4;
				}
				return;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Nv0eUfgJbx(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!xay6xrxQ94EuLTaLPU3()) ? 1 : 3);
		CvsDisplayableRegion cvsDisplayableRegion = default;
		_003C_003Ec__DisplayClass61_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				SLhEpgmPAeYUWSfQ6Jc(cvsDisplayableRegion, (AcqRegionPropertyViewModel)obj.sender);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				obj = new _003C_003Ec__DisplayClass61_0();
				num = 5;
				break;
			case 2:
				cvsDisplayableRegion = lMVe7APgN4.FirstOrDefault(obj._003CRegionProp_PropertyChanged_003Eb__0) as CvsDisplayableRegion;
				goto default;
			case 5:
				obj.sender = P_0;
				num = 7;
				break;
			case 7:
				if (((string)o3WvWCmr6JWXuYLh8gU(P_1)).Equals(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28878), StringComparison.Ordinal))
				{
					num = 2;
					break;
				}
				return;
			default:
				if (cvsDisplayableRegion != null)
				{
					num = 6;
					break;
				}
				return;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IAcqInSightAppStep.Supports(Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass66_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass66_0();
		CS_0024_003C_003E8__locals2.guid = guid;
		return QuBeACVAPt.Any([MethodImpl(MethodImplOptions.NoInlining)] (EzSupportSnippetType s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)_003C_003Ec__DisplayClass66_0.tNluAe5wMQaRx5fiI9RY(s)).Contains(CS_0024_003C_003E8__locals2.guid);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DIAcqInSightAppStep_002DAddSnippet_003Ed__67))]
	Task IAcqInSightAppStep.AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DIAcqInSightAppStep_002DAddSnippet_003Ed__67 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				break;
			case 6:
				stateMachine._003C_003Et__builder = KnhRNVmeUgRQPkJsQ3G();
				WdaB73xN8Jld0fkF717();
				if (xay6xrxQ94EuLTaLPU3())
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				num = 4;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
			case 4:
				stateMachine.snippetRange = snippetRange;
				goto case 0;
			default:
				num = 0;
				break;
			case 7:
				stateMachine.guid = guid;
				goto case 3;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xay6xrxQ94EuLTaLPU3();
		int num;
		if (!WdaB73xN8Jld0fkF717())
		{
			num = 4;
			if (!xay6xrxQ94EuLTaLPU3())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_004d;
		IL_00c5:
		S09e6bUwB8 = null;
		num = 6;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 2;
				if (xay6xrxQ94EuLTaLPU3())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				RbuedE9lJB = null;
				num = 5;
				continue;
			case 0:
			case 4:
				(RbuedE9lJB as IDisposable)?.Dispose();
				goto case 1;
			case 2:
				goto IL_00c5;
			case 6:
				return base.DisposeAsync();
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		AcqEasyBuilder3dMotionInput s09e6bUwB = S09e6bUwB8;
		if (s09e6bUwB != null)
		{
			y9O8m4mbhZUJu3tvbsq(s09e6bUwB);
		}
		goto IL_00c5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SFhRG6x2QtVYh1v7Oh0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xay6xrxQ94EuLTaLPU3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WdaB73xN8Jld0fkF717()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jC1TvexcqX2N0J2CdtV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.eLNrUImDft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mmag0ix1pTbmX27E1g2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X0VrNjXnsD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object exwMgfxugkxvcqgs2ea()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.uYNrdCW387();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WBtyq3xhVbIMRkirKEF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ud3hujxtQpVGvd0EWbe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PHdQ3axzPqfg37jeDnj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vKvassmLweaHbkvB3wS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).IsL38Emulator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lpxOj2mKOsNUD4rib3p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).IsL38Device;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CsexZRm5SLExf1hhqRf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.JZ1nEiv8ZV();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y6kWx7mwR5dSGyqHABU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Cs2nc89D9l();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KtthiAmJfF1LrYrUQif(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).AcqSettings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nXFlcAmaTRNo1HHvnhW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).AcqEncoderCounter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KnhRNVmeUgRQPkJsQ3G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DewkYomObXvr4A6Vqaj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AcquisitionSettingsViewModel)P_0).AutoExposureAction = (AsyncDelegateCommand)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tq9iNBmI5nvVn75CF6v(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AcquisitionSettingsViewModel)P_0).SetCameraAsImageSourceCommand = (AsyncDelegateCommand)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tbm1y7mDWwxRc6fiaQp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AcquisitionSettingsViewModel)P_0).SetImageFolderAsImageSourceCommand = (AsyncDelegateCommand)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MHNLiSmi7eTiSRu7cLV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UbOEFImnLTfjp2IHGcM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AcquisitionSettingsViewModel)P_0).IsImageSourceSetToImageFolder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SMJmP7mVxZYwPCKUwYB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableGraphic)P_0).Tag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF hOXuWYmfBUL03OluBdp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double lhSR0imdBnUkcJ5Z0Bo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double z7kQIImlyKLQjIpLIs4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double DgSh0UmgdQljVYNlCEW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bWTwO9msSOsCpC4aW9d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eVPqsSmvxRYpPnuGDu6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o3WvWCmr6JWXuYLh8gU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SLhEpgmPAeYUWSfQ6Jc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateRegion((CvsDisplayableRegion)P_0, (AcqRegionPropertyViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e2oY08mZ1Irv1XjHRmm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageManagementViewModel)P_0).LoadImageCommand;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xg7GhHmBNJaU20x6Ryl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y9O8m4mbhZUJu3tvbsq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AcqEasyBuilder3dMotionInput)P_0).Dispose();
	}
}
