using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public abstract class ViDiELEzToolBase : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ViDiELEzToolBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			ViDiELEzToolBase viDiELEzToolBase = default;
			ValueTaskAwaiter awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (rXI5I4Kqgf8IYEMeaybf() ? 4 : 0);
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					viDiELEzToolBase = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
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
								_003C_003Eu__2 = default;
								num3 = 10;
							}
							goto IL_00b9;
						}
						awaiter2 = _003C_003Eu__1;
						goto IL_021d;
						IL_00b9:
						while (true)
						{
							switch (num3)
							{
							case 16:
								if (viDiELEzToolBase.InSight != null)
								{
									num3 = 8;
									continue;
								}
								goto case 2;
							case 9:
								_003C_003Eu__2 = awaiter;
								num3 = 17;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto case 11;
							default:
								num3 = 11;
								continue;
							case 7:
								if (viDiELEzToolBase.Focus != null)
								{
									num3 = 1;
									continue;
								}
								goto case 16;
							case 13:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								_ = 0;
								if (LZVn1EKql5STG2sftaVJ())
								{
									num3 = 15;
									continue;
								}
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 17:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (!rXI5I4Kqgf8IYEMeaybf())
								{
									continue;
								}
								goto case 8;
							case 8:
								awaiter2 = viDiELEzToolBase.Lh4X5wsdAJ(viDiELEzToolBase.ELFunctionCellLocation, _0020: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 13;
									continue;
								}
								goto case 11;
							case 1:
								VKOfpYKqsP8Yte9MeDbv(viDiELEzToolBase.Focus, new PropertyChangedEventHandler(viDiELEzToolBase.S1SFzp0NYs));
								num3 = 16;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 18;
							case 5:
							case 15:
								return;
							case 14:
								num2 = (_003C_003E1__state = 1);
								num3 = 9;
								continue;
							case 11:
								awaiter2.GetResult();
								num3 = 2;
								continue;
							case 4:
							case 6:
								break;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 3:
								return;
							case 2:
								awaiter = viDiELEzToolBase.cnyXpt7IeH().GetAwaiter();
								num3 = 0;
								continue;
							case 18:
								awaiter.GetResult();
								goto end_IL_00b9;
							}
							goto IL_021d;
							continue;
							end_IL_00b9:
							break;
						}
						goto end_IL_0061;
						IL_021d:
						_003C_003Eu__1 = default;
						num3 = 12;
						goto IL_00b9;
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
					if (rXI5I4Kqgf8IYEMeaybf())
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
		internal static void VKOfpYKqsP8Yte9MeDbv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LZVn1EKql5STG2sftaVJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rXI5I4Kqgf8IYEMeaybf()
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
	private struct _003CInternalPostParse_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELEzToolBase _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01df;
			IL_001a:
			ViDiELEzToolBase viDiELEzToolBase = _003C_003E4__this;
			_ = 0;
			if (Hwup1rKqv0QPkIn5WD0r())
			{
				num = 5;
				if (!Hwup1rKqv0QPkIn5WD0r())
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 0;
			}
			goto IL_01df;
			IL_01df:
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					goto IL_003d;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (viDiELEzToolBase.Focus == null)
							{
								goto IL_00f5;
							}
							_ = 1;
							num3 = (D6yiTuKqrUSfWBl9Yqyx() ? 8 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_012c;
						IL_00f5:
						awaiter = viDiELEzToolBase.k1DXUlJP5d(cells).GetAwaiter();
						num3 = 6;
						goto IL_012c;
						IL_012c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 8:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 7:
								uYEWDWKqPMVWNdafeV7g(viDiELEzToolBase.Focus, new PropertyChangedEventHandler(viDiELEzToolBase.S1SFzp0NYs));
								num3 = 9;
								if (Hwup1rKqv0QPkIn5WD0r())
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 9:
								break;
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_012c;
							}
							goto IL_00f5;
							continue;
							end_IL_012c:
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
				break;
			}
			goto IL_001a;
			IL_003d:
			num2 = _003C_003E1__state;
			num = 1;
			goto IL_01df;
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
		internal static void uYEWDWKqPMVWNdafeV7g(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hwup1rKqv0QPkIn5WD0r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D6yiTuKqrUSfWBl9Yqyx()
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
	private struct _003CFocusOnPropertyChangedNoExcept_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ViDiELEzToolBase _003C_003E4__this;

		public object sender;

		public PropertyChangedEventArgs args;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wjcNIeKqBo4avQLwUOci();
			int num;
			if (lyeFxdKqZsaLammRHE3h())
			{
				num = 1;
				if (!lyeFxdKqZsaLammRHE3h())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01ea;
			IL_002e:
			ViDiELEzToolBase viDiELEzToolBase = _003C_003E4__this;
			num = 5;
			if (wjcNIeKqBo4avQLwUOci())
			{
			}
			goto IL_01ea;
			IL_01ea:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!wjcNIeKqBo4avQLwUOci())
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = viDiELEzToolBase.FocusOnPropertyChanged(sender, args).GetAwaiter();
								num3 = 0;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								default:
									return;
								case 6:
									return;
								case 0:
									if (!awaiter.IsCompleted)
									{
										lyeFxdKqZsaLammRHE3h();
										num3 = (wjcNIeKqBo4avQLwUOci() ? 6 : 5);
										continue;
									}
									break;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 7;
									continue;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
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
							awaiter.GetResult();
						}
						catch (Exception exception)
						{
							Log.ErrorException((string)Gh79VBKqbIfSR9ZwdFLr(49034), exception);
						}
					}
					catch (Exception exception2)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception2);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static object Gh79VBKqbIfSR9ZwdFLr(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lyeFxdKqZsaLammRHE3h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wjcNIeKqBo4avQLwUOci()
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
	private struct _003CFocusOnPropertyChanged_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public ViDiELEzToolBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (SP9NjpKqoFxtwRRwVvMj() ? 1 : 4);
			int num2 = default;
			ViDiELEzToolBase viDiELEzToolBase = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					viDiELEzToolBase = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							goto IL_00b9;
						}
						if ((string)igWjrvKqSBXJ04lmaimR(e) == (string)ffHfvqKqkWCQsrJuaZTj(5436))
						{
							num3 = 1;
							goto IL_00b9;
						}
						goto end_IL_005b;
						IL_00b9:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								EtvaWGKqGXhBgXkZXu05();
								num3 = ((!SP9NjpKqoFxtwRRwVvMj()) ? 9 : 0);
								continue;
							case 1:
								awaiter = viDiELEzToolBase.c26XaQm6Wc(viDiELEzToolBase.ELFunctionCellLocation, NWTZX9Kq821YADGUEI6f(viDiELEzToolBase.Focus)).GetAwaiter();
								num3 = 2;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 0;
							case 4:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 0:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_005b:;
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
		internal static object igWjrvKqSBXJ04lmaimR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ffHfvqKqkWCQsrJuaZTj(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NWTZX9Kq821YADGUEI6f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InternalCheckBoxViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EtvaWGKqGXhBgXkZXu05()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SP9NjpKqoFxtwRRwVvMj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct setMIrRVClq7fd8DfhB : IAsyncStateMachine
		{
			public int k9I1ZUYmAn;

			public AsyncTaskMethodBuilder BQC1nIHfgy;

			public _003C_003Ec__DisplayClass13_0 cBF1thcIuX;

			private ITopLevelProgressableOperation XnE1Y8fwtv;

			private TaskAwaiter X7b10geJAs;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vxNje05ZIOErxCMcTOSl();
				int num;
				if (vyjXpC5ZO4B9HZ26WTjG())
				{
					num = 1;
				}
				else
				{
					num = 5;
					if (1 == 0)
					{
						goto IL_028a;
					}
				}
				goto IL_0257;
				IL_02a5:
				int num2 = k9I1ZUYmAn;
				num = 4;
				if (!vyjXpC5ZO4B9HZ26WTjG())
				{
					return;
				}
				goto IL_0257;
				IL_028a:
				BQC1nIHfgy.SetResult();
				num = 6;
				if (vyjXpC5ZO4B9HZ26WTjG())
				{
					goto IL_0257;
				}
				goto IL_02a5;
				IL_0257:
				_003C_003Ec__DisplayClass13_0 obj = default;
				Task task = default;
				while (true)
				{
					switch (num)
					{
					case 4:
						obj = cBF1thcIuX;
						num = 2;
						continue;
					case 2:
						try
						{
							if (num2 != 0)
							{
								task = obj._003C_003E4__this.Lh4X5wsdAJ(obj.loc, obj.isEditing);
								ITopLevelProgressableOperation xnE1Y8fwtv = null;
								InspectStepViewModel parent = obj._003C_003E4__this.Parent;
								if (parent != null && parent.OperationProgressManager?.HasNoOperationsPending == true)
								{
									xnE1Y8fwtv = (ITopLevelProgressableOperation)kMyhCt5Zim3YjCymPMO2(obj._003C_003E4__this.Parent.OperationProgressManager, r29Kku5ZDUlGAViEPu4v(), Array.Empty<StepDescriptor>());
								}
								XnE1Y8fwtv = xnE1Y8fwtv;
							}
							try
							{
								TaskAwaiter awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = FheP9L5ZnTqP642F8CdA(task);
									num3 = 3;
								}
								else
								{
									awaiter = X7b10geJAs;
									num3 = 8;
									if (!vyjXpC5ZO4B9HZ26WTjG())
									{
										goto IL_0126;
									}
								}
								goto IL_0187;
								IL_0126:
								X7b10geJAs = awaiter;
								num3 = 5;
								goto IL_0187;
								IL_0187:
								while (true)
								{
									switch (num3)
									{
									case 3:
										if (!awaiter.IsCompleted)
										{
											num3 = 7;
											continue;
										}
										goto case 9;
									case 2:
									case 4:
										return;
									case 0:
										break;
									case 1:
									case 6:
										num2 = (k9I1ZUYmAn = -1);
										num3 = 9;
										continue;
									case 8:
										X7b10geJAs = default;
										goto case 1;
									case 5:
										BQC1nIHfgy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto default;
									default:
										vyjXpC5ZO4B9HZ26WTjG();
										if (vxNje05ZIOErxCMcTOSl())
										{
											num3 = 1;
											continue;
										}
										num3 = 2;
										if (vxNje05ZIOErxCMcTOSl())
										{
										}
										continue;
									case 7:
										num2 = (k9I1ZUYmAn = 0);
										num3 = 0;
										continue;
									case 9:
										awaiter.GetResult();
										goto end_IL_0187;
									}
									goto IL_0126;
									continue;
									end_IL_0187:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && XnE1Y8fwtv != null)
								{
									XnE1Y8fwtv.Dispose();
								}
							}
							XnE1Y8fwtv = null;
						}
						catch (Exception exception)
						{
							k9I1ZUYmAn = -2;
							BQC1nIHfgy.SetException(exception);
							return;
						}
						k9I1ZUYmAn = -2;
						break;
					case 0:
					case 1:
						goto IL_02a5;
					case 6:
						return;
					}
					break;
				}
				goto IL_028a;
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BQC1nIHfgy.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object r29Kku5ZDUlGAViEPu4v()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return Resources.PmoLR7aWNX();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object kMyhCt5Zim3YjCymPMO2(object P_0, object P_1, object P_2)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter FheP9L5ZnTqP642F8CdA(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool vyjXpC5ZO4B9HZ26WTjG()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool vxNje05ZIOErxCMcTOSl()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public ViDiELEzToolBase _003C_003E4__this;

		public CvsCellLocation loc;

		public bool isEditing;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass13_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IMby5WKqpAGTbyWOA08H();
			OEdrTUKqXGYp0ViJVr7q(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(setMIrRVClq7fd8DfhB))]
		internal Task _003CSetIsEditingWithProgressAsync_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!EXFKdVKqE0EAAyJVnnum()) ? 1 : 2);
			setMIrRVClq7fd8DfhB stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					stateMachine.k9I1ZUYmAn = -1;
					goto default;
				default:
					stateMachine.BQC1nIHfgy.Start(ref stateMachine);
					num = 6;
					break;
				case 5:
					stateMachine.cBF1thcIuX = this;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					stateMachine.BQC1nIHfgy = AsyncTaskMethodBuilder.Create();
					num = 5;
					break;
				case 6:
					return stateMachine.BQC1nIHfgy.Task;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IMby5WKqpAGTbyWOA08H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OEdrTUKqXGYp0ViJVr7q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aos81LKqqOqrak6MGpEr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EXFKdVKqE0EAAyJVnnum()
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
	private struct _003CSetIsEditingWithProgressAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELEzToolBase _003C_003E4__this;

		public CvsCellLocation loc;

		public bool isEditing;

		private TaskAwaiter<Task> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!TfXnLVKq9sKZhEdWNtJK())
			{
				goto IL_001e;
			}
			goto IL_0207;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_0207;
			IL_0207:
			int num2 = default;
			_003C_003Ec__DisplayClass13_0 obj = default;
			TaskAwaiter<Task> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!JGvirOKq47ntUjJ6heF4()) ? 3 : 0);
					continue;
				case 1:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass13_0();
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (JGvirOKq47ntUjJ6heF4())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								obj.isEditing = isEditing;
								num3 = 11;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 9:
								obj._003C_003E4__this = _003C_003E4__this;
								num3 = 10;
								if (TfXnLVKq9sKZhEdWNtJK())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 5:
								return;
							case 11:
								awaiter = ((Dispatcher)yN8NpDKq70YLYKt5v8nZ()).InvokeAsync((Func<Task>)obj._003CSetIsEditingWithProgressAsync_003Eb__0).GetAwaiter();
								goto case 3;
							case 10:
								obj.loc = loc;
								_ = 1;
								if (JGvirOKq47ntUjJ6heF4())
								{
									num3 = 3;
									continue;
								}
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (true)
								{
									continue;
								}
								break;
							case 12:
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
		internal static object yN8NpDKq70YLYKt5v8nZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dispatcher.CurrentDispatcher;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TfXnLVKq9sKZhEdWNtJK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JGvirOKq47ntUjJ6heF4()
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
	private struct _003CSetIsEditingAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELEzToolBase _003C_003E4__this;

		public CvsCellLocation loc;

		public bool isEditing;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			ViDiELEzToolBase viDiELEzToolBase = default;
			int num2 = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_009e;
							}
							awaiter = Wy6cECKqCZRQrO1i7xLR(t4k1ayKq6cJhy2QXZpKy(viDiELEzToolBase.y2fX7wXppg));
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
						goto IL_009e;
						IL_009e:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 3;
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								num3 = 1;
								if (false)
								{
									goto IL_0202;
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									if (!bxd270Kqji6si3ww2nH6())
									{
										continue;
									}
									goto case 4;
								case 4:
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 5:
									return;
								case 1:
									_003C_003Eu__2 = default;
									num3 = 2;
									continue;
								case 0:
									if (awaiter2.IsCompleted)
									{
										break;
									}
									num2 = (_003C_003E1__state = 1);
									num3 = 8;
									if (LjSI01Kq3AWccIvYQlr6())
									{
										continue;
									}
									goto case 3;
								case 3:
									if (viDiELEzToolBase.InSight == null)
									{
										num3 = 9;
										if (LjSI01Kq3AWccIvYQlr6())
										{
											continue;
										}
										goto end_IL_019f;
									}
									awaiter2 = ((ResourceNode)rY1I5MKqWRrPteVROtF5(u97oSFKqRgvXVpaILo8p(KxLiKcKqAXiRXLV6rVHn(viDiELEzToolBase.InSight)), loc)).PutAsync<object>(CdQUGaROfy7He9T0foW.KbIzwHEDLa(49118), (object)isEditing).GetAwaiter();
									num3 = 0;
									continue;
								case 9:
									goto end_IL_019f;
								case 8:
									_003C_003Eu__2 = awaiter2;
									goto default;
								default:
									LjSI01Kq3AWccIvYQlr6();
									num3 = ((!bxd270Kqji6si3ww2nH6()) ? 7 : 6);
									continue;
								case 6:
									return;
								case 10:
									break;
								}
								goto IL_0202;
								continue;
								end_IL_019f:
								break;
							}
							goto end_IL_009e;
							IL_0202:
							awaiter2.GetResult();
							end_IL_009e:;
						}
						finally
						{
							if (num2 < 0)
							{
								Nx2sHgKqTBJi7QLE7oN1(viDiELEzToolBase.y2fX7wXppg);
							}
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
				case 5:
					do
					{
						viDiELEzToolBase = _003C_003E4__this;
						bxd270Kqji6si3ww2nH6();
						if (!LjSI01Kq3AWccIvYQlr6())
						{
							num = 4;
							continue;
						}
						num = 0;
						break;
					}
					while (1 == 0);
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
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
		internal static object t4k1ayKq6cJhy2QXZpKy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Wy6cECKqCZRQrO1i7xLR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KxLiKcKqAXiRXLV6rVHn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u97oSFKqRgvXVpaILo8p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rY1I5MKqWRrPteVROtF5(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Nx2sHgKqTBJi7QLE7oN1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).Release();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LjSI01Kq3AWccIvYQlr6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bxd270Kqji6si3ww2nH6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected static ILogger Log;

	private readonly SemaphoreSlim y2fX7wXppg;

	[CompilerGenerated]
	private CvsCellLocation HU6XN8ESBZ;

	public CvsCellLocation ELFunctionCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HU6XN8ESBZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HU6XN8ESBZ = value;
		}
	}

	public string ToolId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!hS3nTXsSUdSNLdcO7Di(ELFunctionCellLocation, CvsCellLocation.Invalid))
			{
				return ELFunctionCellLocation.ToString();
			}
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ViDiELEzToolBase(InspectStepViewModel inspect, bool isInitialized, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (bWHeORsG60jaUok4JaM())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_003b;
			}
		}
		goto IL_005a;
		IL_0081:
		base._002Ector(inspect, isInitialized);
		num = 5;
		if (false)
		{
			return;
		}
		goto IL_005a;
		IL_003b:
		y2fX7wXppg = new SemaphoreSlim(1, 1);
		goto IL_0081;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				break;
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0081;
			case 5:
				return;
			}
			break;
		}
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__9))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CDisposeAsync_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!OIEgpPsoiLZ1JwbRaGB()) ? 4 : 0);
				break;
			case 2:
			case 4:
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
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__10))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CInternalPostParse_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = D3Ujr1skXJ6q3I197Su();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!bWHeORsG60jaUok4JaM()) ? 5 : 6);
				continue;
			case 2:
			case 6:
				stateMachine.cells = cells;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				continue;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
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
	[AsyncStateMachine(typeof(_003CFocusOnPropertyChangedNoExcept_003Ed__11))]
	private void S1SFzp0NYs(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!bWHeORsG60jaUok4JaM()) ? 5 : 2);
		_003CFocusOnPropertyChangedNoExcept_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine.sender = P_0;
				num = 1;
				if (bWHeORsG60jaUok4JaM())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				break;
			case 1:
				stateMachine.args = P_1;
				goto default;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = QTWFuHs80yrv4kW4Ru1();
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFocusOnPropertyChanged_003Ed__12))]
	protected virtual Task FocusOnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!bWHeORsG60jaUok4JaM())
		{
			goto IL_001e;
		}
		goto IL_00a6;
		IL_001e:
		_003CFocusOnPropertyChanged_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (OIEgpPsoiLZ1JwbRaGB())
		{
		}
		goto IL_00a6;
		IL_00a6:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = ((!OIEgpPsoiLZ1JwbRaGB()) ? 4 : 0);
				continue;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				if (bWHeORsG60jaUok4JaM())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = D3Ujr1skXJ6q3I197Su();
				num = 6;
				continue;
			case 2:
			case 4:
				stateMachine.e = e;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetIsEditingWithProgressAsync_003Ed__13))]
	private Task c26XaQm6Wc(CvsCellLocation P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSetIsEditingWithProgressAsync_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				stateMachine.isEditing = P_1;
				goto case 4;
			default:
				num = 4;
				if (bWHeORsG60jaUok4JaM())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = D3Ujr1skXJ6q3I197Su();
				_ = 0;
				if (!bWHeORsG60jaUok4JaM())
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 7:
				stateMachine.loc = P_0;
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				if (0 == 0)
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
	[AsyncStateMachine(typeof(_003CSetIsEditingAsync_003Ed__14))]
	private Task Lh4X5wsdAJ(CvsCellLocation P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bWHeORsG60jaUok4JaM();
		int num;
		if (!OIEgpPsoiLZ1JwbRaGB())
		{
			num = 1;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_007c;
			}
		}
		goto IL_00ae;
		IL_00ae:
		_003CSetIsEditingAsync_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = D3Ujr1skXJ6q3I197Su();
				num = 2;
				continue;
			case 4:
				stateMachine.loc = P_0;
				num = 7;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			case 5:
			case 6:
				break;
			case 7:
				stateMachine.isEditing = P_1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_007c;
		IL_007c:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		goto IL_00ae;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask cnyXpt7IeH()
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
	private Task k1DXUlJP5d(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bWHeORsG60jaUok4JaM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OIEgpPsoiLZ1JwbRaGB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hS3nTXsSUdSNLdcO7Di(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder D3Ujr1skXJ6q3I197Su()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder QTWFuHs80yrv4kW4Ru1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}
}
