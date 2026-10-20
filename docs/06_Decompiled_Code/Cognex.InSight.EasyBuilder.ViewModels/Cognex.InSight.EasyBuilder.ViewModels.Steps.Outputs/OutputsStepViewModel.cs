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
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using Cognex.Platform.IO.Configuration;
using Cognex.Platform.IO.Enumerations;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

[Export(typeof(AppStepViewModel))]
[Shared]
public class OutputsStepViewModel : AppStepViewModel, IInSightAppStep, ISnippetOwner, ISnippetConsumer
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBeginInitialization_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputsStepViewModel _003C_003E4__this;

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
			if (u7NRLpKgaSok2wrYLr8l())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_027c;
			IL_02cf:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_027c;
			IL_027c:
			int num2 = default;
			OutputsStepViewModel outputsStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					outputsStepViewModel = _003C_003E4__this;
					num = 4;
					continue;
				case 5:
					goto IL_02cf;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 1;
						if (false)
						{
							goto IL_003f;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 13;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 7;
				}
				goto IL_015f;
				IL_003f:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				goto IL_015f;
				IL_015f:
				while (true)
				{
					switch (num3)
					{
					case 3:
						break;
					case 10:
						awaiter = grsKLbKgOKI9dD7FcTHE(w5QASAKgICFMkfG8EDvN(outputsStepViewModel.OEZ7bXSrEQ().IoConfigurationService));
						num3 = 6;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						num2 = (_003C_003E1__state = 0);
						num3 = 12;
						continue;
					case 0:
						outputsStepViewModel.uF37oOWNFa();
						num3 = 10;
						if (true)
						{
							continue;
						}
						goto case 14;
					case 14:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							if (0 == 0)
							{
								continue;
							}
							goto case 1;
						}
						goto case 16;
					case 1:
						awaiter = grsKLbKgOKI9dD7FcTHE(outputsStepViewModel.ReleaseSnippets());
						num3 = 14;
						continue;
					case 11:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 12:
						_003C_003Eu__1 = awaiter;
						_ = 0;
						if (u7NRLpKgaSok2wrYLr8l())
						{
							num3 = 2;
							continue;
						}
						num3 = 15;
						if (0 == 0)
						{
							continue;
						}
						goto case 16;
					case 9:
						awaiter.GetResult();
						num3 = 17;
						if (!JCFPX4Kge4IeinrTxqw3())
						{
							continue;
						}
						goto case 2;
					case 2:
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 5:
						return;
					case 16:
						awaiter.GetResult();
						goto case 0;
					default:
						num3 = 0;
						continue;
					case 6:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 11;
							if (!JCFPX4Kge4IeinrTxqw3())
							{
								continue;
							}
							return;
						}
						goto case 9;
					case 15:
						return;
					case 13:
						_003C_003Eu__1 = default;
						num3 = 3;
						continue;
					case 7:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 17:
						outputsStepViewModel.DioSettingsViewModel = new DIOSettingsViewModel(outputsStepViewModel.OEZ7bXSrEQ().IoConfigurationService.InSightIOConfiguration, null, isSpreadsheetView: true);
						goto end_IL_015f;
					}
					goto IL_003f;
					continue;
					end_IL_015f:
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
			goto IL_02cf;
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
		internal static TaskAwaiter grsKLbKgOKI9dD7FcTHE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w5QASAKgICFMkfG8EDvN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).LoadConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u7NRLpKgaSok2wrYLr8l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JCFPX4Kge4IeinrTxqw3()
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
	private struct _003CDisposeAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public OutputsStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			ValueTaskAwaiter awaiter = default;
			TaskAwaiter awaiter2 = default;
			ValueTask valueTask = default;
			OutputsStepViewModel outputsStepViewModel = default;
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
					zPMTN6KgigxZhJiU1j63();
					if (kNtdruKgDZCKxcoqDmUZ())
					{
						num = 5;
						if (zPMTN6KgigxZhJiU1j63())
						{
						}
					}
					else
					{
						num = 0;
					}
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								zPMTN6KgigxZhJiU1j63();
								if (kNtdruKgDZCKxcoqDmUZ())
								{
									num3 = 13;
								}
								else
								{
									num3 = 9;
									if (1 == 0)
									{
										goto IL_0241;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (zPMTN6KgigxZhJiU1j63())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 2:
								awaiter2.GetResult();
								num3 = 6;
								continue;
							case 15:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter2;
								num3 = 3;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 11;
								if (kNtdruKgDZCKxcoqDmUZ())
								{
									continue;
								}
								goto case 14;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								continue;
							case 6:
								valueTask = outputsStepViewModel.vTC7EQQMI8();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 7;
								continue;
							case 1:
							case 9:
								if (awaiter2.IsCompleted)
								{
									goto case 2;
								}
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = valueTask.GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (kNtdruKgDZCKxcoqDmUZ())
									{
										continue;
									}
									return;
								}
								break;
							case 5:
								return;
							case 11:
								return;
							case 0:
							case 13:
								awaiter2 = pDa9fMKgnGM7Al0ILN9q(outputsStepViewModel.ReleaseSnippets());
								goto case 1;
							case 16:
								break;
							}
							break;
						}
						goto IL_0241;
						IL_0241:
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
				case 1:
				case 5:
					outputsStepViewModel = _003C_003E4__this;
					num = 2;
					if (false)
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
		internal static TaskAwaiter pDa9fMKgnGM7Al0ILN9q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kNtdruKgDZCKxcoqDmUZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zPMTN6KgigxZhJiU1j63()
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
	private struct _003CReleaseSnippets_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputsStepViewModel _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zqVfqwKgfy7mp13YTVqX();
			int num;
			if (c1iL8wKgV0FpsL0mUwRI())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0052;
				}
			}
			goto IL_02e3;
			IL_0052:
			int num2 = default;
			OutputsStepViewModel outputsStepViewModel = default;
			try
			{
				int num3;
				ValueTaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 8;
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
					num3 = 15;
				}
				ValueTask valueTask = default;
				while (true)
				{
					switch (num3)
					{
					case 7:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							num3 = 17;
							if (0 == 0)
							{
								continue;
							}
							goto case 11;
						}
						goto case 2;
					case 11:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 19;
						continue;
					case 19:
						awaiter.GetResult();
						num3 = 20;
						continue;
					case 2:
						awaiter.GetResult();
						goto case 6;
					default:
						num3 = 6;
						continue;
					case 16:
						awaiter = valueTask.GetAwaiter();
						zqVfqwKgfy7mp13YTVqX();
						if (c1iL8wKgV0FpsL0mUwRI())
						{
							num3 = 9;
							continue;
						}
						num3 = 1;
						if (0 == 0)
						{
							continue;
						}
						break;
					case 17:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 14;
						continue;
					case 0:
						return;
					case 4:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 0;
						continue;
					case 10:
						valueTask = wJO3N9KgdQYclAiCCj2j(outputsStepViewModel.InputsSnippet);
						num3 = 16;
						if (!zqVfqwKgfy7mp13YTVqX())
						{
							continue;
						}
						return;
					case 14:
						return;
					case 8:
						if (outputsStepViewModel.OutputsSnippet != null)
						{
							num3 = 5;
							if (true)
							{
								continue;
							}
							goto case 6;
						}
						goto IL_01f5;
					case 6:
						outputsStepViewModel.OutputsSnippet = null;
						goto IL_01f5;
					case 5:
						valueTask = wJO3N9KgdQYclAiCCj2j(outputsStepViewModel.OutputsSnippet);
						num3 = 3;
						if (zqVfqwKgfy7mp13YTVqX())
						{
						}
						continue;
					case 3:
						awaiter = valueTask.GetAwaiter();
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 18;
					case 18:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						continue;
					case 15:
						_003C_003Eu__1 = default;
						num3 = 18;
						continue;
					case 1:
					case 13:
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
					case 12:
						if (awaiter.IsCompleted)
						{
							goto case 19;
						}
						goto case 1;
					case 20:
						break;
						IL_01f5:
						if (outputsStepViewModel.InputsSnippet != null)
						{
							num3 = 10;
							continue;
						}
						goto end_IL_00da;
					}
					outputsStepViewModel.InputsSnippet = null;
					break;
					continue;
					end_IL_00da:
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
			goto IL_030e;
			IL_030e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02e3;
			IL_02e3:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					outputsStepViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_030e;
				case 6:
					return;
				}
				break;
			}
			goto IL_0052;
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
		internal static ValueTask wJO3N9KgdQYclAiCCj2j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c1iL8wKgV0FpsL0mUwRI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zqVfqwKgfy7mp13YTVqX()
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
	private struct _003CCompleteInitializationAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputsStepViewModel _003C_003E4__this;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			OutputsStepViewModel outputsStepViewModel = default;
			int num2 = default;
			Input input = default;
			int? num4 = default;
			Output output = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					outputsStepViewModel = _003C_003E4__this;
					num = 5;
					if (Oof6hoKglYcuWb9t8CXt())
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<EzSupportSnippet> awaiter2;
						TaskAwaiter awaiter;
						EzSupportSnippet result;
						switch (num2)
						{
						default:
							if (outputsStepViewModel.InputsSnippet != null)
							{
								outputsStepViewModel.InputsSnippet.Refresh();
								goto IL_0164;
							}
							awaiter2 = outputsStepViewModel.zil7gFmXsy.OfType<InputsSnippetType>().First().AddSupportSnippet((ISnippetManager)DsAu3OKgs4GfQ5sIYdie(outputsStepViewModel))
								.GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00e3;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00e3;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_015d;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01eb;
						case 3:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0265;
							}
							IL_015d:
							awaiter.GetResult();
							goto IL_0164;
							IL_0164:
							if (outputsStepViewModel.OutputsSnippet != null)
							{
								outputsStepViewModel.OutputsSnippet.Refresh();
								break;
							}
							awaiter2 = outputsStepViewModel.zil7gFmXsy.OfType<OutputsSnippetType>().First().AddSupportSnippet(outputsStepViewModel.AppViewModel)
								.GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01eb;
							IL_0265:
							awaiter.GetResult();
							break;
							IL_00e3:
							result = awaiter2.GetResult();
							outputsStepViewModel.InputsSnippet = result as InputsSnippet;
							awaiter = DBDpNkKgrHvUWOhBVJyS(H0mlYqKgvtkqupSHU0FZ(outputsStepViewModel, new SnippetAddedEventArgs(outputsStepViewModel.InputsSnippet, SnippetAddedEventType.Created)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_015d;
							IL_01eb:
							result = awaiter2.GetResult();
							outputsStepViewModel.OutputsSnippet = result as OutputsSnippet;
							awaiter = DBDpNkKgrHvUWOhBVJyS(H0mlYqKgvtkqupSHU0FZ(outputsStepViewModel, new SnippetAddedEventArgs(outputsStepViewModel.OutputsSnippet, SnippetAddedEventType.Created)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0265;
						}
						outputsStepViewModel.mwY7Chr26P = true;
						IEnumerator<DIOLineViewModel> enumerator = outputsStepViewModel.DioSettingsViewModel.Elements.GetEnumerator();
						try
						{
							while (sKpbp5KgGUxkYLDlq3Zd(enumerator))
							{
								DIOLineViewModel current = enumerator.Current;
								int num3 = 2;
								while (true)
								{
									switch (num3)
									{
									case 9:
										if (input != null)
										{
											num3 = 3;
											continue;
										}
										break;
									case 2:
										num4 = current.Model.InputLineIndex;
										num3 = 10;
										continue;
									case 1:
										outputsStepViewModel.SetForceDioLine(current, useDioSettingAsSource: false);
										num3 = 12;
										continue;
									case 6:
										if (num4.HasValue)
										{
											OutputsSnippet outputsSnippet = outputsStepViewModel.OutputsSnippet;
											num4 = current.Model.OutputLineIndex;
											output = (Output)nmL8FkKgB0Dr2Ha7uaHu(outputsSnippet, num4.Value);
											Oof6hoKglYcuWb9t8CXt();
											num3 = ((!G2imcvKggqt74TLiD3am()) ? 11 : 0);
											continue;
										}
										goto case 1;
									case 7:
									case 11:
										if (output == null)
										{
											break;
										}
										goto case 0;
									case 10:
										if (num4.HasValue)
										{
											num3 = 5;
											continue;
										}
										goto case 4;
									case 5:
									{
										InputsSnippet inputsSnippet = outputsStepViewModel.InputsSnippet;
										num4 = current.Model.InputLineIndex;
										input = (Input)oXfhqyKgPex41Wqi2bB3(inputsSnippet, num4.Value);
										num3 = 9;
										continue;
									}
									case 4:
										num4 = current.Model.OutputLineIndex;
										num3 = 6;
										continue;
									case 0:
									case 8:
										sIZ3BDKgbfGYVslKbCvB(output, current);
										num3 = 1;
										continue;
									case 3:
										K9pLu5KgZXEhcsyk2t6j(input, current);
										goto case 4;
									default:
										num3 = 4;
										continue;
									case 12:
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
								uQrP12KgoTUrDoAvJI6G(enumerator);
							}
						}
						outputsStepViewModel.mwY7Chr26P = false;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					num2 = _003C_003E1__state;
					Oof6hoKglYcuWb9t8CXt();
					num = (G2imcvKggqt74TLiD3am() ? 4 : 0);
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
		internal static object DsAu3OKgs4GfQ5sIYdie(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H0mlYqKgvtkqupSHU0FZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DBDpNkKgrHvUWOhBVJyS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oXfhqyKgPex41Wqi2bB3(object P_0, int index)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InputsSnippet)P_0).GetByIndex(index);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K9pLu5KgZXEhcsyk2t6j(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Input)P_0).DioLine = (DIOLineViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nmL8FkKgB0Dr2Ha7uaHu(object P_0, int index)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((OutputsSnippet)P_0).GetByIndex(index);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sIZ3BDKgbfGYVslKbCvB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Output)P_0).DioLine = (DIOLineViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sKpbp5KgGUxkYLDlq3Zd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uQrP12KgoTUrDoAvJI6G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Oof6hoKglYcuWb9t8CXt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G2imcvKggqt74TLiD3am()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public OutputsStepViewModel _003C_003E4__this;

		public CellViewModel targetProperty;

		public Func<CellViewModel, bool> predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass43_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yLeAFrKg8MvZK0gu3hHE();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Input> _003CGetSourceablePrimitivesGrouped_003Eb__0(DIOLineViewModel element)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.InputsSnippet.Inputs;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesGrouped_003Eb__4(_003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (_003C_003Eh__TransparentIdentifier0.input.ValueWithForce.YJwH11Te4e(targetProperty))
			{
				return predicate(_003C_003Eh__TransparentIdentifier0.input.ValueWithForce);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yLeAFrKg8MvZK0gu3hHE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oLO6XCKgSLWZhbIYr4b0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yJynarKgkRi4tMJLoXO5()
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

		public static Func<DIOLineViewModel, Input, _003C_003Ef__AnonymousType4<DIOLineViewModel, Input>> _003C_003E9__43_1;

		public static Func<_003C_003Ef__AnonymousType4<DIOLineViewModel, Input>, bool> _003C_003E9__43_2;

		public static Func<_003C_003Ef__AnonymousType4<DIOLineViewModel, Input>, bool> _003C_003E9__43_3;

		public static Func<_003C_003Ef__AnonymousType4<DIOLineViewModel, Input>, string> _003C_003E9__43_5;

		public static Func<_003C_003Ef__AnonymousType4<DIOLineViewModel, Input>, BoolViewModel> _003C_003E9__43_6;

		public static Func<Input, BoolViewModel> _003C_003E9__44_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QyHj5FKgpspvIK7J24q7();
			RumYnfKgXgxsgxkyZ28y(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal _003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003CGetSourceablePrimitivesGrouped_003Eb__43_1(DIOLineViewModel element, Input input)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { element, input };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesGrouped_003Eb__43_2(_003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (_003C_003Eh__TransparentIdentifier0.element.Index != 0)
			{
				return _003C_003Eh__TransparentIdentifier0.element.Direction == LineDirection.Input;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceablePrimitivesGrouped_003Eb__43_3(_003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.input.Line.Value == int.Parse(_003C_003Eh__TransparentIdentifier0.element.InputLineIndexText);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetSourceablePrimitivesGrouped_003Eb__43_5(_003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.rm6YsvlS5R();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BoolViewModel _003CGetSourceablePrimitivesGrouped_003Eb__43_6(_003C_003Ef__AnonymousType4<DIOLineViewModel, Input> _003C_003Eh__TransparentIdentifier0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.input.ValueWithForce;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BoolViewModel _003CGetLinkableProperties_003Eb__44_0(Input i)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (BoolViewModel)WKl4oGKg99o5XOKuqNEX(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FH5KE3Kgqtjf4pxdw5uR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xTdGeBKgEZgIeDRsiRLI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QyHj5FKgpspvIK7J24q7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RumYnfKgXgxsgxkyZ28y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WKl4oGKg99o5XOKuqNEX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Input)P_0).ValueWithForce;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDIOSettings_PropertyChanged_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public OutputsStepViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			steX9wKg4eaa65UBRJp1();
			int num;
			if (!c0IuXoKg7iaLBm0E1XG1())
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
			}
			goto IL_02bd;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02bd;
			IL_02bd:
			int num2 = default;
			IUndoAction undoAction = default;
			TaskAwaiter awaiter = default;
			OutputsStepViewModel outputsStepViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoAction = null;
							num3 = 9;
							goto IL_0230;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0192;
						IL_0192:
						_003C_003Eu__1 = default;
						num3 = 11;
						if (!steX9wKg4eaa65UBRJp1())
						{
							goto IL_01ae;
						}
						goto IL_0230;
						IL_01ae:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 12;
						goto IL_0230;
						IL_0230:
						while (true)
						{
							switch (num3)
							{
							case 4:
								undoAction = new DIOSettingsUndoAction((IIoConfigurationService)lqbBAEKgWGDy5OuLESl9(outputsStepViewModel.OEZ7bXSrEQ()), outputsStepViewModel.DioSettingsViewModel, DIOSettingsUndoAction.DIOSettingsProperty.DebounceDuration);
								num3 = 6;
								continue;
							case 9:
								if (DHo7c6Kgju2w6JyEdypy(e.PropertyName, kI7wmsKg3L2AJeXRrJ3P(35696), StringComparison.Ordinal))
								{
									num3 = 13;
									continue;
								}
								goto IL_00f1;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								}
								goto case 14;
							case 12:
								return;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								c0IuXoKg7iaLBm0E1XG1();
								if (!steX9wKg4eaa65UBRJp1())
								{
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								}
								num3 = 1;
								continue;
							case 7:
								if (VoEOjnKgy2sZgRwcDJ4H(outputsStepViewModel.DioSettingsViewModel.Model) != OLIOCBKg0VMaAQOKRc5p(outputsStepViewModel.DioSettingsViewModel))
								{
									undoAction = new DIOSettingsUndoAction((IIoConfigurationService)lqbBAEKgWGDy5OuLESl9(outputsStepViewModel.OEZ7bXSrEQ()), outputsStepViewModel.DioSettingsViewModel, DIOSettingsUndoAction.DIOSettingsProperty.DeenergizeInOffline);
									num3 = 2;
									continue;
								}
								goto case 2;
							case 5:
							case 10:
								break;
							case 1:
							case 8:
								goto IL_01ae;
							case 13:
								if (!(DLIhQrKgRfGEZKwuWePt(HpSkrnKgCVlquoUs2871(obf8XVKg6E8NZRjNMrMH(outputsStepViewModel.DioSettingsViewModel)) - pYSlWwKgAKcv17eAHWM1(outputsStepViewModel.DioSettingsViewModel)) > 0.0001))
								{
									goto IL_00f1;
								}
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 6:
								if (undoAction != null)
								{
									awaiter = yvGKWBKgYld5hwsXvCfV(jS7UtrKgM22w6oXE9RFD(((CvsInSight)sL52KrKgFLIosb2JW6j5(outputsStepViewModel)).UndoHandler, undoAction));
									goto case 0;
								}
								goto end_IL_0050;
							default:
								num3 = 0;
								continue;
							case 14:
								{
									awaiter.GetResult();
									goto end_IL_0050;
								}
								IL_00f1:
								if (DHo7c6Kgju2w6JyEdypy(P1I0jyKgT4kW6qqpBoP5(e), kI7wmsKg3L2AJeXRrJ3P(48450), StringComparison.Ordinal))
								{
									num3 = 7;
									continue;
								}
								goto case 2;
							}
							break;
						}
						goto IL_0192;
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
					if (steX9wKg4eaa65UBRJp1())
					{
						continue;
					}
					goto case 5;
				case 5:
					outputsStepViewModel = _003C_003E4__this;
					goto case 2;
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
		internal static object kI7wmsKg3L2AJeXRrJ3P(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DHo7c6Kgju2w6JyEdypy(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object obf8XVKg6E8NZRjNMrMH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).Model;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double HpSkrnKgCVlquoUs2871(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOConfiguration)P_0).DebounceDuration;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double pYSlWwKgAKcv17eAHWM1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).DebounceDuration;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double DLIhQrKgRfGEZKwuWePt(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Abs(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lqbBAEKgWGDy5OuLESl9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).IoConfigurationService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P1I0jyKgT4kW6qqpBoP5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VoEOjnKgy2sZgRwcDJ4H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOConfiguration)P_0).DeenergizeInOffline;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OLIOCBKg0VMaAQOKRc5p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).DeenergizeInOffline;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sL52KrKgFLIosb2JW6j5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jS7UtrKgM22w6oXE9RFD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yvGKWBKgYld5hwsXvCfV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool steX9wKg4eaa65UBRJp1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c0IuXoKg7iaLBm0E1XG1()
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
		public DIOLineViewModel line;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass50_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vVmiLFKgxsYcdM5MxDrx();
			oQ3V8oKgmTo9tnHDGmUD(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSelectedDioLine_PropertyChanged_003Eb__0(Output output)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)vVckxxKgQm4LyNK7M2FI(output)).Value == ((IOLineConfiguration)BWuG2HKgNxMaOAUyjT1M(line)).OutputLineIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vVmiLFKgxsYcdM5MxDrx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oQ3V8oKgmTo9tnHDGmUD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zEhlROKgUlmxNQCSMnnV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yi41NoKgHgEQDyEMHbZr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vVckxxKgQm4LyNK7M2FI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Output)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BWuG2HKgNxMaOAUyjT1M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).Model;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSelectedDioLine_PropertyChanged_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public OutputsStepViewModel _003C_003E4__this;

		public object sender;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!sbwFhwKgcok6X7DG9bUq()) ? 1 : 5);
			OutputsStepViewModel outputsStepViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			Output output = default;
			_003C_003Ec__DisplayClass50_0 obj2 = default;
			IUndoAction undoAction = default;
			do
			{
				IL_0595:
				switch (num)
				{
				case 4:
					outputsStepViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (((string)KbZhtyKg1gYSYVrs4O1o(e)).Equals((string)L29gZQKgunoyXMh9XNo3(48492), StringComparison.Ordinal))
							{
								num3 = 8;
								goto IL_0131;
							}
							goto IL_04ee;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_031a;
						IL_031a:
						awaiter.GetResult();
						num3 = 31;
						goto IL_0131;
						IL_0131:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 27:
								if (OsRmY7KsLNFHISfdb6UQ(KbZhtyKg1gYSYVrs4O1o(e), L29gZQKgunoyXMh9XNo3(1188), StringComparison.Ordinal))
								{
									num3 = 23;
									continue;
								}
								goto IL_0253;
							case 3:
								if (output != null && ((OutputLinksViewModel)j86uHyKsOkpyoqHPWmrB(output)).SelectedLink != kSm88uKsICSQ6hkHOsjK(obj2.line) as SourceLink)
								{
									num3 = 19;
									continue;
								}
								goto case 10;
							case 8:
							{
								DIOSettingsViewModel dioSettingsViewModel = outputsStepViewModel.DioSettingsViewModel;
								if (dioSettingsViewModel == null)
								{
									num3 = 15;
									continue;
								}
								object obj3 = Vi8TE9Kgh7h08XPW6uLY(dioSettingsViewModel);
								if (obj3 == null)
								{
									goto IL_02dd;
								}
								obj = rcLyXYKgtJq6FywHtr3X(obj3);
								goto IL_03e5;
							}
							case 5:
								if (!outputsStepViewModel.zy07j36kmj && !outputsStepViewModel.mwY7Chr26P)
								{
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto case 24;
								}
								goto IL_0205;
							case 24:
								undoAction = new DIOLineUndoAction(outputsStepViewModel.OEZ7bXSrEQ().IoConfigurationService, outputsStepViewModel.DioSettingsViewModel, obj2.line, DIOLineUndoAction.DIOLineProperty.Direction);
								goto case 10;
							default:
								num3 = 30;
								continue;
							case 17:
								if (obj2.line.JobResult != null)
								{
									num3 = 26;
									if (FkcOVvKg2W5mdYcB7fhu())
									{
										continue;
									}
									goto case 4;
								}
								goto case 10;
							case 4:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 7:
								undoAction = new DIOLineUndoAction(outputsStepViewModel.OEZ7bXSrEQ().IoConfigurationService, outputsStepViewModel.DioSettingsViewModel, obj2.line, DIOLineUndoAction.DIOLineProperty.Name);
								goto case 10;
							case 15:
								obj = null;
								goto IL_03e5;
							case 0:
								return;
							case 28:
								undoAction = new DIOLineUndoAction((IIoConfigurationService)a70afEKseGMCOWeVC5H3(outputsStepViewModel.OEZ7bXSrEQ()), outputsStepViewModel.DioSettingsViewModel, obj2.line, DIOLineUndoAction.DIOLineProperty.SignalType);
								num3 = 10;
								continue;
							case 9:
								obj2.line = sender as DIOLineViewModel;
								if (obj2.line != null)
								{
									num3 = 6;
									continue;
								}
								goto end_IL_0131;
							case 14:
								((DIOLineViewModel)Jm1J53KgzsBXhMl9VCPu(outputsStepViewModel.DioSettingsViewModel)).DetailsViewModel.DetailsChanged += outputsStepViewModel.Y3k7fOohf1;
								num3 = 21;
								continue;
							case 2:
							case 18:
								obj = null;
								goto IL_03e5;
							case 19:
								undoAction = new OutputLinksUndoAction(output);
								num3 = 20;
								continue;
							case 25:
								break;
							case 10:
							case 20:
							case 29:
							case 30:
								if (undoAction != null)
								{
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 11;
								}
								goto end_IL_0131;
							case 11:
								output = outputsStepViewModel.OutputsSnippet.Outputs.FirstOrDefault(obj2._003CSelectedDioLine_PropertyChanged_003Eb__0);
								num3 = 3;
								continue;
							case 23:
								if (Vw0pIHKsw4MFI7THZYPb(Q7KlLsKsKmbqCQK84jFQ(obj2.line.Model), ro5vwVKs5uI6beyk2HQ8(obj2.line)))
								{
									num3 = 7;
									continue;
								}
								goto IL_0253;
							case 22:
								outputsStepViewModel.SetForceDioLine(obj2.line, useDioSettingAsSource: true);
								num3 = 29;
								continue;
							case 16:
								if (!outputsStepViewModel.zy07j36kmj)
								{
									num3 = 28;
									continue;
								}
								goto IL_03aa;
							case 6:
								undoAction = null;
								num3 = 27;
								continue;
							case 21:
								goto end_IL_0131;
							case 12:
								awaiter = vlCfSeKsnLx78gmIgYgH(K8axIQKsiQxurdJyikiY(((CvsInSight)TUkLq3KsDhwwQD8PSqCO(outputsStepViewModel)).UndoHandler, undoAction));
								num3 = 25;
								continue;
							case 26:
								if (outputsStepViewModel.OutputsSnippet != null)
								{
									num3 = 11;
									continue;
								}
								goto case 10;
							case 1:
							case 13:
								outputsStepViewModel.zy07j36kmj = true;
								outputsStepViewModel.SetForceDioLine(obj2.line, useDioSettingAsSource: false);
								num3 = 24;
								continue;
							case 31:
								{
									outputsStepViewModel.zy07j36kmj = false;
									goto end_IL_0131;
								}
								IL_03e5:
								if (obj != null)
								{
									((DIOLineViewModel)Jm1J53KgzsBXhMl9VCPu(outputsStepViewModel.DioSettingsViewModel)).DetailsViewModel.DetailsChanged -= outputsStepViewModel.Y3k7fOohf1;
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									goto case 19;
								}
								goto IL_04ee;
								IL_0205:
								if (OsRmY7KsLNFHISfdb6UQ(KbZhtyKg1gYSYVrs4O1o(e), L29gZQKgunoyXMh9XNo3(48542), StringComparison.Ordinal))
								{
									num3 = 17;
									continue;
								}
								goto case 10;
								IL_03aa:
								if (!OsRmY7KsLNFHISfdb6UQ(KbZhtyKg1gYSYVrs4O1o(e), L29gZQKgunoyXMh9XNo3(35806), StringComparison.Ordinal))
								{
									if (OsRmY7KsLNFHISfdb6UQ(KbZhtyKg1gYSYVrs4O1o(e), CdQUGaROfy7He9T0foW.KbIzwHEDLa(48528), StringComparison.Ordinal))
									{
										num3 = 5;
										continue;
									}
									goto IL_0205;
								}
								goto case 1;
								IL_0253:
								if (OsRmY7KsLNFHISfdb6UQ(KbZhtyKg1gYSYVrs4O1o(e), L29gZQKgunoyXMh9XNo3(42896), StringComparison.Ordinal) && uroPkwKsJxAYLwMYUblZ(obj2.line.Model) != WI1pL5KsaH8pg4qG7rVa(obj2.line))
								{
									num3 = 16;
									continue;
								}
								goto IL_03aa;
							}
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							}
							goto IL_031a;
							IL_02dd:
							FkcOVvKg2W5mdYcB7fhu();
							num3 = (sbwFhwKgcok6X7DG9bUq() ? 1 : 18);
							continue;
							end_IL_0131:
							break;
						}
						goto end_IL_003b;
						IL_04ee:
						obj2 = new _003C_003Ec__DisplayClass50_0();
						num3 = 9;
						goto IL_0131;
						end_IL_003b:;
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
					if (true)
					{
						goto IL_0595;
					}
					goto case 0;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						goto IL_0595;
					}
					break;
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
		internal static object KbZhtyKg1gYSYVrs4O1o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L29gZQKgunoyXMh9XNo3(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vi8TE9Kgh7h08XPW6uLY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).SelectedDIOLine;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rcLyXYKgtJq6FywHtr3X(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).DetailsViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jm1J53KgzsBXhMl9VCPu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).SelectedDIOLine;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OsRmY7KsLNFHISfdb6UQ(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q7KlLsKsKmbqCQK84jFQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOLineConfiguration)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ro5vwVKs5uI6beyk2HQ8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vw0pIHKsw4MFI7THZYPb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SignalType uroPkwKsJxAYLwMYUblZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOLineConfiguration)P_0).SignalType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SignalType WI1pL5KsaH8pg4qG7rVa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).SignalType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a70afEKseGMCOWeVC5H3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).IoConfigurationService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j86uHyKsOkpyoqHPWmrB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Output)P_0).Signal;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kSm88uKsICSQ6hkHOsjK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).JobResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TUkLq3KsDhwwQD8PSqCO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K8axIQKsiQxurdJyikiY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vlCfSeKsnLx78gmIgYgH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FkcOVvKg2W5mdYcB7fhu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sbwFhwKgcok6X7DG9bUq()
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
	private struct _003CDetailsViewModel_PropertyChanged_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public OutputsStepViewModel _003C_003E4__this;

		public DetailsChangedArgs detailsChangedArgs;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			OutputsStepViewModel outputsStepViewModel = default;
			int num2 = default;
			LineDetailsViewModel lineDetailsViewModel = default;
			TaskAwaiter awaiter = default;
			LineDetailsUndoAction action = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					outputsStepViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!dsLQPaKsVAi79kjb5Wra())
					{
						num = 3;
						if (dsLQPaKsVAi79kjb5Wra())
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							lineDetailsViewModel = sender as LineDetailsViewModel;
							dsLQPaKsVAi79kjb5Wra();
							num3 = (bMKP2BKsfU1MNRvrOYCH() ? 9 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (false)
							{
								goto IL_0174;
							}
						}
						goto IL_00fc;
						IL_00fc:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 3:
								goto end_IL_00fc;
							case 4:
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								if (bMKP2BKsfU1MNRvrOYCH())
								{
								}
								continue;
							case 6:
								return;
							case 0:
							case 5:
								break;
							case 10:
								if (!awaiter.IsCompleted)
								{
									goto case 4;
								}
								goto case 11;
							case 8:
								awaiter = ralHHhKslrJuRsQ9xbty(outputsStepViewModel.InSight.UndoHandler.AddUndo(action));
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (!bMKP2BKsfU1MNRvrOYCH())
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter.GetResult();
								goto end_IL_00fc;
							}
							goto IL_0174;
							continue;
							end_IL_00fc:
							break;
						}
						goto end_IL_0067;
						IL_0174:
						if (lineDetailsViewModel != null)
						{
							action = new LineDetailsUndoAction((IIoConfigurationService)udKhCAKsdQntA68AlDdj(outputsStepViewModel.OEZ7bXSrEQ()), outputsStepViewModel.DioSettingsViewModel, lineDetailsViewModel, detailsChangedArgs);
							num3 = 8;
						}
						else
						{
							num3 = 3;
						}
						goto IL_00fc;
						end_IL_0067:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
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
		internal static object udKhCAKsdQntA68AlDdj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).IoConfigurationService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ralHHhKslrJuRsQ9xbty(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dsLQPaKsVAi79kjb5Wra()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bMKP2BKsfU1MNRvrOYCH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass55_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			KwB3VoKsvPVRVh1GHV7l(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSupports_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)a8fdeeKsriFFHmLIkPpK(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KwB3VoKsvPVRVh1GHV7l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RJqLRyKsgdJuJWH8IOjH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ghfvojKssEl602vHe34k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a8fdeeKsriFFHmLIkPpK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass56_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cEM71XKsBv2ewdOR8374();
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
		internal static void cEM71XKsBv2ewdOR8374()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bO7bOgKsPh6IrRlCWRJn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XdH2VvKsZd3vTZHWCswN()
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public OutputsStepViewModel _003C_003E4__this;

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
			int num = 3;
			int num2 = default;
			_003C_003Ec__DisplayClass56_0 obj = default;
			TaskAwaiter<EzSupportSnippet> awaiter = default;
			TaskAwaiter awaiter2 = default;
			OutputsStepViewModel outputsStepViewModel = default;
			EzSupportSnippet result = default;
			EzSnippet ezSnippet = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							obj = new _003C_003Ec__DisplayClass56_0();
							num3 = 18;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 19;
							break;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 22;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 21;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								num3 = 20;
								if (xa4xwKKsb4JJOAk5rtbT())
								{
									continue;
								}
								goto case 17;
							case 17:
								outputsStepViewModel.OutputsSnippet = result as OutputsSnippet;
								num3 = 13;
								continue;
							case 15:
								return;
							case 14:
								ezSnippet = null;
								num3 = 7;
								continue;
							case 7:
								if (!(ezSupportSnippetType is OutputsSnippetType))
								{
									if (ezSupportSnippetType is InputsSnippetType)
									{
										goto case 20;
									}
									goto case 9;
								}
								num3 = 5;
								continue;
							case 20:
								awaiter = ezSupportSnippetType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 18;
							case 18:
								obj.guid = guid;
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 21;
							case 21:
								_003C_003Eu__1 = default;
								num3 = 25;
								if (!VInEgWKsGTGOIu0SknGP())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 23:
								return;
							case 11:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 16:
								outputsStepViewModel.InputsSnippet = result as InputsSnippet;
								ezSnippet = outputsStepViewModel.InputsSnippet;
								goto case 9;
							case 9:
							case 12:
								if (ezSnippet != null)
								{
									awaiter2 = F5tB0hKsSUUWTQAUFoUr(rDy7PTKsoOOMHYcPTe4V(outputsStepViewModel, new SnippetAddedEventArgs(ezSnippet, action)));
									num3 = 27;
									continue;
								}
								goto end_IL_005c;
							case 5:
								awaiter = ezSupportSnippetType.CreateSupportSnippet(obj.guid, cells, snippetRange).GetAwaiter();
								num3 = 0;
								if (!VInEgWKsGTGOIu0SknGP())
								{
									continue;
								}
								goto case 19;
							case 19:
								_003C_003Eu__1 = default;
								num3 = 24;
								continue;
							case 10:
								ezSupportSnippetType = outputsStepViewModel.zil7gFmXsy.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0);
								num3 = 14;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 6;
							case 26:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 11;
									continue;
								}
								goto IL_02c7;
							case 24:
								num2 = (_003C_003E1__state = -1);
								goto IL_02c7;
							case 6:
								result = awaiter.GetResult();
								num3 = 16;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 26;
								continue;
							case 25:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 13:
								ezSnippet = outputsStepViewModel.OutputsSnippet;
								xa4xwKKsb4JJOAk5rtbT();
								num3 = (VInEgWKsGTGOIu0SknGP() ? 4 : 9);
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 28;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 27:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter2;
									num3 = 1;
									continue;
								}
								break;
							case 22:
								_003C_003Eu__2 = default;
								num3 = 3;
								continue;
							case 28:
								break;
								IL_02c7:
								result = awaiter.GetResult();
								num3 = 17;
								continue;
							}
							awaiter2.GetResult();
							break;
							continue;
							end_IL_005c:
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
					goto case 0;
				default:
					num = 0;
					if (!VInEgWKsGTGOIu0SknGP())
					{
						break;
					}
					goto case 0;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					outputsStepViewModel = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					VInEgWKsGTGOIu0SknGP();
					if (!xa4xwKKsb4JJOAk5rtbT())
					{
						num = 5;
						break;
					}
					num = 4;
					if (!xa4xwKKsb4JJOAk5rtbT())
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
		internal static object rDy7PTKsoOOMHYcPTe4V(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetAdded((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter F5tB0hKsSUUWTQAUFoUr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xa4xwKKsb4JJOAk5rtbT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VInEgWKsGTGOIu0SknGP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass57_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v8qcNPKsq3XhHt1ABCOw();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)AnatiRKsE8h7M4npIMg7(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void v8qcNPKsq3XhHt1ABCOw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fJUbuWKskw0eOIjbsLiA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uJH5yaKs8dWiBecLdGw4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AnatiRKsE8h7M4npIMg7(object P_0)
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public OutputsStepViewModel _003C_003E4__this;

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
			int num = ((!u4ip2tKspZtkJPSDrp9T()) ? 3 : 4);
			int num2 = default;
			_003C_003Ec__DisplayClass57_0 obj = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			OutputsStepViewModel outputsStepViewModel = default;
			do
			{
				IL_01f2:
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass57_0();
							num3 = 11;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (1 == 0)
							{
								goto IL_00ac;
							}
						}
						goto IL_00ea;
						IL_00ac:
						if (ezSupportSnippetType != null)
						{
							Ju5OCyKsXmuAiah9XSFJ();
							if (u4ip2tKspZtkJPSDrp9T())
							{
								num3 = 1;
							}
							else
							{
								num3 = 10;
								if (Ju5OCyKsXmuAiah9XSFJ())
								{
									goto IL_0139;
								}
							}
							goto IL_00ea;
						}
						goto end_IL_003b;
						IL_0139:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00ea;
						IL_00ea:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 2:
								ezSupportSnippetType = outputsStepViewModel.zil7gFmXsy.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0);
								num3 = 6;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								break;
							case 0:
								if (!awaiter.IsCompleted)
								{
									goto default;
								}
								goto case 12;
							case 7:
								goto IL_0139;
							default:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 1:
							case 3:
								awaiter = JdlbOXKs4maOmYQ8mnPK(xFMawKKs9RGeR3uNmy1U(ezSupportSnippetType, snippetRange, cells));
								num3 = 0;
								continue;
							case 11:
								obj.guid = guid;
								num3 = 2;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_003b;
							}
							break;
						}
						goto IL_00ac;
						end_IL_003b:;
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
					goto IL_01f2;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_01f2;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				outputsStepViewModel = _003C_003E4__this;
				num = 2;
			}
			while (0 == 0);
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
		internal static object xFMawKKs9RGeR3uNmy1U(object P_0, CvsCellRange range, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).UpdateSnippet(range, (CvsCellCollection)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JdlbOXKs4maOmYQ8mnPK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u4ip2tKspZtkJPSDrp9T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ju5OCyKsXmuAiah9XSFJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass58_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NQ5IkAKsjp2EhrE8kkuJ();
			H3Sqt4Ks6fVcbbmqGoj3(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)ptxZnqKsCnl0XtVoNFie(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NQ5IkAKsjp2EhrE8kkuJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void H3Sqt4Ks6fVcbbmqGoj3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool itwR8KKs7o2Vg3CrZwsq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dc3udhKs37wKDLZJFGNu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ptxZnqKsCnl0XtVoNFie(object P_0)
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputsStepViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (enLrwFKsRjmn7glDWB1Z())
			{
				goto IL_001e;
			}
			goto IL_0292;
			IL_001e:
			OutputsStepViewModel outputsStepViewModel = _003C_003E4__this;
			aIiuXkKsAcDc2DfX7uea();
			if (!enLrwFKsRjmn7glDWB1Z())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (enLrwFKsRjmn7glDWB1Z())
				{
					return;
				}
			}
			goto IL_0292;
			IL_0292:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 0;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 14;
							}
							goto IL_01ff;
						}
						awaiter = _003C_003Eu__1;
						goto IL_01e1;
						IL_01ff:
						while (true)
						{
							switch (num3)
							{
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 5:
							case 10:
								return;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 1;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								aIiuXkKsAcDc2DfX7uea();
								if (enLrwFKsRjmn7glDWB1Z())
								{
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 13;
								}
								num3 = 10;
								if (aIiuXkKsAcDc2DfX7uea())
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter = Y6LMSCKsTa9Ty68K0UmL(PLFGUuKsWT4FqfQncyUM(outputsStepViewModel.OutputsSnippet, e));
								num3 = 13;
								if (aIiuXkKsAcDc2DfX7uea())
								{
									continue;
								}
								goto case 1;
							case 1:
								awaiter.GetResult();
								awaiter = ((Task)PLFGUuKsWT4FqfQncyUM(outputsStepViewModel.InputsSnippet, e)).GetAwaiter();
								num3 = 4;
								continue;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								break;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 16;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 6:
							case 11:
								goto IL_01e1;
							default:
								num3 = 9;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0065;
							}
							break;
						}
						goto IL_0170;
						IL_0170:
						num2 = (_003C_003E1__state = -1);
						num3 = 1;
						goto IL_01ff;
						IL_01e1:
						_003C_003Eu__1 = default;
						goto IL_0170;
						end_IL_0065:;
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
		internal static object PLFGUuKsWT4FqfQncyUM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSupportSnippet)P_0).RemoveReferences((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Y6LMSCKsTa9Ty68K0UmL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aIiuXkKsAcDc2DfX7uea()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool enLrwFKsRjmn7glDWB1Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private EzSupportSnippetType[] zil7gFmXsy;

	private int OiA7MNglg7;

	[CompilerGenerated]
	private OutputsSnippet ktR7R2HNuJ;

	[CompilerGenerated]
	private InputsSnippet IDp740H1gv;

	private RuntimeViewModel km17l5Km8e;

	private bool fu57T7GhcK;

	private DIOSettingsViewModel RZa7WWQtBj;

	private bool zy07j36kmj;

	private bool mwY7Chr26P;

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Steps_OutputsIcon;
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
			return (string)pOWCmDIcI0AVMQpPG46(eQJQ6RINkO8wVD5W0SC(), CdQUGaROfy7He9T0foW.KbIzwHEDLa(3678), sXWQhcI2iITYFNnRRpB());
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
			return (string)PnstFOI1FA6kgV1sPS1();
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
			return Resources.OaALib19Hf();
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
			return AppStepHelpTopics.InputOutput;
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
			return OiA7MNglg7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref OiA7MNglg7, value, (string)elDDXhIuWCAMhj1oEtt(3256));
		}
	}

	public OutputsSnippet OutputsSnippet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ktR7R2HNuJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ktR7R2HNuJ = value;
		}
	}

	public InputsSnippet InputsSnippet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IDp740H1gv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IDp740H1gv = value;
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
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 6:
					base.AppViewModel = value;
					goto case 0;
				default:
					num = 0;
					break;
				case 4:
					br72YADLScvSRljdOjS(base.AppViewModel, new EventHandler(AppViewModel_ActiveStepChanged));
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 8:
					QbG5AmIzIFMyqOFKsjq(this, null);
					goto case 3;
				case 7:
				{
					QbG5AmIzIFMyqOFKsjq(this, ((RuntimeViewModel)LmN5uADK5PgvksO7ioH(base.AppViewModel))?.RuntimeModeService);
					object obj = LmN5uADK5PgvksO7ioH(base.AppViewModel);
					RuntimeService = (IRuntimeService)((obj != null) ? Bry206D5Dext0lu5RKS(obj) : null);
					kOU7cQRIKk((RuntimeViewModel)LmN5uADK5PgvksO7ioH(base.AppViewModel));
					num = 10;
					break;
				}
				case 3:
				case 9:
					RuntimeService = null;
					num = 6;
					break;
				case 0:
					if (base.AppViewModel != null)
					{
						num = 4;
						if (!lnv1jLImV46gHlg8IKG())
						{
							break;
						}
						goto case 5;
					}
					return;
				case 5:
					base.AppViewModel.ActiveStepChanged -= AppViewModel_ActiveStepChanged;
					_ = 0;
					num = (RAaHEQIxjReHI9eI6YT() ? 8 : 9);
					break;
				case 1:
					if (base.AppViewModel != null)
					{
						num = 5;
						break;
					}
					goto case 6;
				case 10:
					return;
				}
			}
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
			return fu57T7GhcK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref fu57T7GhcK, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3684));
		}
	}

	public DIOSettingsViewModel DioSettingsViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RZa7WWQtBj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			IEnumerator<DIOLineViewModel> enumerator = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (RZa7WWQtBj != null)
					{
						goto case 4;
					}
					return;
				case 0:
					if (RZa7WWQtBj != null)
					{
						num = 1;
						if (RAaHEQIxjReHI9eI6YT())
						{
							break;
						}
						goto case 2;
					}
					goto IL_019c;
				case 2:
					enumerator = RZa7WWQtBj.Elements.GetEnumerator();
					_ = 0;
					num = (RAaHEQIxjReHI9eI6YT() ? 7 : 4);
					break;
				case 4:
				case 5:
					iGd39NDni7sx1lPZBws(RZa7WWQtBj, new PropertyChangedEventHandler(RaV736Dnbo));
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					WirpsEDImIOG7joStGB(RZa7WWQtBj, new PropertyChangedEventHandler(RaV736Dnbo));
					num = 2;
					break;
				case 8:
					enumerator = RZa7WWQtBj.Elements.GetEnumerator();
					num = 9;
					break;
				case 3:
				case 7:
					try
					{
						while (enumerator.MoveNext())
						{
							DIOLineViewModel current2 = enumerator.Current;
							_ = 1;
							int num3 = (lnv1jLImV46gHlg8IKG() ? 4 : 3);
							while (true)
							{
								switch (num3)
								{
								case 2:
									((LineDetailsViewModel)y0UDptDiLcvHuOXNLVT(current2)).DetailsChanged -= Y3k7fOohf1;
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
								case 4:
									if (!jNHaW0DDRbyNZaI5WQI(current2))
									{
										break;
									}
									goto case 2;
								default:
									num3 = 2;
									continue;
								case 0:
								case 3:
									RS04biDwnMcckQvAWYD(current2, new PropertyChangedEventHandler(Rel7IRj9QL));
									goto case 1;
								case 5:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					goto IL_019c;
				default:
					num = 6;
					break;
				case 9:
					{
						try
						{
							while (lB6bB4DVuDmhYID7gAT(enumerator))
							{
								DIOLineViewModel current = enumerator.Current;
								_ = 0;
								int num2 = (RAaHEQIxjReHI9eI6YT() ? 1 : 4);
								while (true)
								{
									switch (num2)
									{
									case 3:
										if (!jNHaW0DDRbyNZaI5WQI(current))
										{
											break;
										}
										goto default;
									case 0:
									case 1:
										Cy9WjiDJdHmKQceQRuk(current, new PropertyChangedEventHandler(Rel7IRj9QL));
										num2 = 3;
										continue;
									default:
										((LineDetailsViewModel)y0UDptDiLcvHuOXNLVT(current)).DetailsChanged += Y3k7fOohf1;
										num2 = 5;
										continue;
									case 5:
										break;
									}
									break;
								}
							}
							return;
						}
						finally
						{
							if (enumerator != null)
							{
								XtxSAIDfyTYkZJFdCWm(enumerator);
							}
						}
					}
					IL_019c:
					SetField(ref RZa7WWQtBj, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3714));
					goto case 6;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputsStepViewModel()
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
			case 6:
				ShowInSightDisplay = false;
				num = 8;
				break;
			case 7:
				base._002Ector();
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 2:
				fu57T7GhcK = true;
				num = 7;
				break;
			case 4:
				StepDisplay = new RunStepDisplay(((EasyBuilderApplicationViewModel)HIGrfRIQlohvlsjkiXq(this))?.Display);
				num = 6;
				break;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				RAaHEQIxjReHI9eI6YT();
				num = ((!lnv1jLImV46gHlg8IKG()) ? 5 : 0);
				break;
			case 1:
			case 5:
				OiA7MNglg7 = 500;
				goto case 0;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBeginInitialization_003Ed__24))]
	public override Task BeginInitialization(EasyBuilderApplicationViewModel ezbVm, bool jobLoading)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lnv1jLImV46gHlg8IKG();
		int num = ((!RAaHEQIxjReHI9eI6YT()) ? 1 : 2);
		_003CBeginInitialization_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
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
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__25))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RAaHEQIxjReHI9eI6YT();
		int num = (lnv1jLImV46gHlg8IKG() ? 5 : 4);
		_003CDisposeAsync_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (RAaHEQIxjReHI9eI6YT())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = FEGKogIhxpifyKNYXkl();
				goto case 1;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReleaseSnippets_003Ed__26))]
	public Task ReleaseSnippets()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RAaHEQIxjReHI9eI6YT();
		int num = (lnv1jLImV46gHlg8IKG() ? 2 : 5);
		_003CReleaseSnippets_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = XZQ2GqItm3nRkNY6P43();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uF37oOWNFa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zil7gFmXsy = new EzSupportSnippetType[2]
		{
			new InputsSnippetType(this),
			new OutputsSnippetType(this)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCompleteInitializationAsync_003Ed__28))]
	public override Task CompleteInitializationAsync(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CCompleteInitializationAsync_003Ed__28 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!RAaHEQIxjReHI9eI6YT())
				{
					num = 4;
					break;
				}
				num = 0;
				if (RAaHEQIxjReHI9eI6YT())
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = XZQ2GqItm3nRkNY6P43();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private RuntimeViewModel OEZ7bXSrEQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return km17l5Km8e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void kOU7cQRIKk(RuntimeViewModel value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (lnv1jLImV46gHlg8IKG() ? 1 : 6);
		while (true)
		{
			switch (num)
			{
			case 3:
				km17l5Km8e = value;
				num = 5;
				if (RAaHEQIxjReHI9eI6YT())
				{
					continue;
				}
				goto case 8;
			case 8:
				RS04biDwnMcckQvAWYD(km17l5Km8e, new PropertyChangedEventHandler(RXD7StiWhd));
				num = 3;
				continue;
			case 2:
				Cy9WjiDJdHmKQceQRuk(km17l5Km8e, new PropertyChangedEventHandler(RXD7StiWhd));
				num = 7;
				continue;
			case 0:
			case 6:
				if (km17l5Km8e != null)
				{
					num = 8;
					continue;
				}
				goto case 3;
			case 5:
				eig7DSodeH();
				break;
			case 7:
				IsEnabled = ((IEnumerable<IOLineConfiguration>)UDsebPDOpH1O8ONIr9T(kbItNoDeXULc4JDcKVI(zWceMxDa5fbcVJ5DO5x(km17l5Km8e)))).Any();
				num = 9;
				continue;
			case 9:
				return;
			}
			if (km17l5Km8e != null)
			{
				num = 2;
				if (lnv1jLImV46gHlg8IKG())
				{
				}
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RXD7StiWhd(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eig7DSodeH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eig7DSodeH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsEditAllowed = OEZ7bXSrEQ()?.IsOperatorOfflineAndNotInLiveMode ?? false;
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
	public override IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass43_0();
		CS_0024_003C_003E8__locals8._003C_003E4__this = this;
		CS_0024_003C_003E8__locals8.targetProperty = targetProperty;
		CS_0024_003C_003E8__locals8.predicate = predicate;
		if (DioSettingsViewModel == null)
		{
			return Enumerable.Empty<IGrouping<string, CellViewModel>>();
		}
		if (CS_0024_003C_003E8__locals8.predicate == null)
		{
			CS_0024_003C_003E8__locals8.predicate = CellViewModel.oexw5f8eIR();
		}
		return DioSettingsViewModel.Elements.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (DIOLineViewModel element) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals8._003C_003E4__this.InputsSnippet.Inputs;
		}, [MethodImpl(MethodImplOptions.NoInlining)] (DIOLineViewModel element, Input input) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new { element, input };
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.element.Index != 0 && _003C_003Eh__TransparentIdentifier0.element.Direction == LineDirection.Input;
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Eh__TransparentIdentifier0.input.Line.Value == int.Parse(_003C_003Eh__TransparentIdentifier0.element.InputLineIndexText);
		})
			.Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Eh__TransparentIdentifier0.input.ValueWithForce.YJwH11Te4e(CS_0024_003C_003E8__locals8.targetProperty) && CS_0024_003C_003E8__locals8.predicate(_003C_003Eh__TransparentIdentifier0.input.ValueWithForce);
			})
			.GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return Resources.rm6YsvlS5R();
			}, [MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Eh__TransparentIdentifier0.input.ValueWithForce;
			});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<CellViewModel> GetLinkableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (InputsSnippet?.Inputs != null)
		{
			return InputsSnippet.Inputs.Select([MethodImpl(MethodImplOptions.NoInlining)] (Input i) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (BoolViewModel)_003C_003Ec.WKl4oGKg99o5XOKuqNEX(i);
			});
		}
		return Enumerable.Empty<CellViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDIOSettings_PropertyChanged_003Ed__49))]
	private void RaV736Dnbo(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDIOSettings_PropertyChanged_003Ed__49 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
			case 3:
				stateMachine.e = P_1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 0:
				stateMachine._003C_003Et__builder = i1RXLKDd010qwXLl0j3();
				_ = 0;
				if (!RAaHEQIxjReHI9eI6YT())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSelectedDioLine_PropertyChanged_003Ed__50))]
	private void Rel7IRj9QL(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (lnv1jLImV46gHlg8IKG())
		{
			goto IL_001e;
		}
		goto IL_00ac;
		IL_001e:
		_003CSelectedDioLine_PropertyChanged_003Ed__50 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_00ac;
		IL_00ac:
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = i1RXLKDd010qwXLl0j3();
				num = 6;
				continue;
			case 7:
				stateMachine.sender = P_0;
				lnv1jLImV46gHlg8IKG();
				if (RAaHEQIxjReHI9eI6YT())
				{
					num = 2;
					continue;
				}
				num = 0;
				if (1 == 0)
				{
					return;
				}
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				continue;
			case 2:
			case 3:
				stateMachine.e = P_1;
				break;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetForceDioLine(DIOLineViewModel line, bool useDioSettingAsSource)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int? num2 = default;
		Input byIndex = default;
		Output output = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				num2 = ((IOLineConfiguration)np8c7dDgo73y0jOUsiZ(line)).InputLineIndex;
				num = 0;
				break;
			case 3:
				if (RKJNW6DlQ1R6qrhc7IY(line) == LineDirection.Input)
				{
					num = 13;
					break;
				}
				goto IL_0079;
			case 4:
				if (useDioSettingAsSource)
				{
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				}
				mxq1V3DZlVSu4QDyfMP(line, (ForceIOLine)CfB5I7DPOuwG2ac6rRB(vSQc0xDsFY5DlZeJYgp(byIndex)));
				return;
			case 10:
				MPTD7gDrG1H3ogRVq9m(vSQc0xDsFY5DlZeJYgp(byIndex), (int)VhFojfDvBA2v589icfF(line));
				return;
			default:
				_ = 1;
				if (!lnv1jLImV46gHlg8IKG())
				{
					num = 8;
					break;
				}
				num = 2;
				if (lnv1jLImV46gHlg8IKG())
				{
				}
				break;
			case 5:
			{
				InputsSnippet inputsSnippet = InputsSnippet;
				num2 = ((IOLineConfiguration)np8c7dDgo73y0jOUsiZ(line)).InputLineIndex;
				byIndex = inputsSnippet.GetByIndex(num2.Value);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			}
			case 6:
				if (byIndex != null)
				{
					num = 4;
					break;
				}
				return;
			case 11:
				if (useDioSettingAsSource)
				{
					goto case 2;
				}
				mxq1V3DZlVSu4QDyfMP(line, (ForceIOLine)CfB5I7DPOuwG2ac6rRB(bT7acpDbjpiEGS0m40u(output)));
				num = 15;
				break;
			case 14:
				if (num2.HasValue)
				{
					num = 9;
					break;
				}
				return;
			case 1:
				if (output != null)
				{
					num = 11;
					break;
				}
				return;
			case 2:
			case 12:
				MPTD7gDrG1H3ogRVq9m(output.Force, (int)VhFojfDvBA2v589icfF(line));
				return;
			case 7:
			case 8:
				num2 = ((IOLineConfiguration)np8c7dDgo73y0jOUsiZ(line)).OutputLineIndex;
				num = 14;
				break;
			case 0:
				if (num2.HasValue)
				{
					num = 5;
					break;
				}
				goto IL_0079;
			case 9:
			{
				OutputsSnippet outputsSnippet = OutputsSnippet;
				num2 = line.Model.OutputLineIndex;
				output = (Output)GvtAmFDBlulNYlhZYwh(outputsSnippet, num2.Value);
				num = 1;
				break;
			}
			case 15:
				return;
				IL_0079:
				if (RKJNW6DlQ1R6qrhc7IY(line) == LineDirection.Output)
				{
					goto default;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDetailsViewModel_PropertyChanged_003Ed__54))]
	private void Y3k7fOohf1(object P_0, DetailsChangedArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RAaHEQIxjReHI9eI6YT();
		int num = (lnv1jLImV46gHlg8IKG() ? 3 : 5);
		_003CDetailsViewModel_PropertyChanged_003Ed__54 stateMachine = default;
		do
		{
			IL_0042:
			switch (num)
			{
			case 2:
				stateMachine.detailsChangedArgs = P_1;
				break;
			default:
				num = 7;
				goto IL_0042;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = i1RXLKDd010qwXLl0j3();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (RAaHEQIxjReHI9eI6YT())
				{
					goto IL_0042;
				}
				goto case 6;
			case 6:
				stateMachine.sender = P_0;
				num = 2;
				if (RAaHEQIxjReHI9eI6YT())
				{
					goto IL_0042;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (RAaHEQIxjReHI9eI6YT())
				{
					goto IL_0042;
				}
				break;
			case 7:
				break;
			case 8:
				return;
			}
			stateMachine._003C_003E1__state = -1;
			num = 4;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Supports(Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass55_0();
		CS_0024_003C_003E8__locals2.guid = guid;
		return zil7gFmXsy.Any([MethodImpl(MethodImplOptions.NoInlining)] (EzSupportSnippetType s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)_003C_003Ec__DisplayClass55_0.a8fdeeKsriFFHmLIkPpK(s)).Contains(CS_0024_003C_003E8__locals2.guid);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__56))]
	Task ISnippetOwner.AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange, SnippetAddedEventType action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__56 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.snippetRange = snippetRange;
				goto case 8;
			default:
				num = 8;
				continue;
			case 8:
				stateMachine.action = action;
				num = 9;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = XZQ2GqItm3nRkNY6P43();
				num = 5;
				continue;
			case 4:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine.cells = cells;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 6:
				stateMachine.guid = guid;
				_ = 0;
				num = (RAaHEQIxjReHI9eI6YT() ? 1 : 4);
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 10:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__57))]
	Task ISnippetOwner.UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lnv1jLImV46gHlg8IKG();
		int num = (RAaHEQIxjReHI9eI6YT() ? 1 : 6);
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__57 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.cells = cells;
				goto case 8;
			default:
				num = 8;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 8:
				stateMachine.snippetRange = snippetRange;
				num = 4;
				break;
			case 2:
			case 6:
				stateMachine.guid = guid;
				num = 7;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = XZQ2GqItm3nRkNY6P43();
				num = 3;
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
		int num = (lnv1jLImV46gHlg8IKG() ? 2 : 5);
		_003C_003Ec__DisplayClass58_0 obj = default;
		EzSupportSnippetType ezSupportSnippetType = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				obj = new _003C_003Ec__DisplayClass58_0();
				num = 1;
				break;
			case 4:
				ezSupportSnippetType = zil7gFmXsy.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0);
				goto default;
			case 1:
				obj.guid = guid;
				num = 4;
				break;
			default:
				if (ezSupportSnippetType != null)
				{
					num = 6;
					break;
				}
				return false;
			case 6:
				return GCMygZDGOoGma3TV6LO(ezSupportSnippetType, range, cells);
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
	Task ISnippetConsumer.AddDefaultReferences(SnippetAddedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)Efje2WDoLAEaRbr7G4T();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__61))]
	Task ISnippetConsumer.RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RAaHEQIxjReHI9eI6YT();
		int num = (lnv1jLImV46gHlg8IKG() ? 6 : 5);
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetConsumer_002DRemoveReferences_003Ed__61 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = XZQ2GqItm3nRkNY6P43();
				num = 4;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 2:
			case 6:
				stateMachine.e = e;
				goto case 1;
			default:
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task ISnippetConsumer.RenameReferences(SnippetRenamedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask vTC7EQQMI8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HIGrfRIQlohvlsjkiXq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RAaHEQIxjReHI9eI6YT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lnv1jLImV46gHlg8IKG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eQJQ6RINkO8wVD5W0SC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rm6YsvlS5R();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sXWQhcI2iITYFNnRRpB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.GutLPQjZrH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pOWCmDIcI0AVMQpPG46(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PnstFOI1FA6kgV1sPS1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.G8N9KIQENn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object elDDXhIuWCAMhj1oEtt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder FEGKogIhxpifyKNYXkl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder XZQ2GqItm3nRkNY6P43()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QbG5AmIzIFMyqOFKsjq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).RuntimeModeService = (IRuntimeModeService)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void br72YADLScvSRljdOjS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EasyBuilderApplicationViewModel)P_0).ActiveStepChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LmN5uADK5PgvksO7ioH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bry206D5Dext0lu5RKS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RS04biDwnMcckQvAWYD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Cy9WjiDJdHmKQceQRuk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zWceMxDa5fbcVJ5DO5x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IoConfigurationService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kbItNoDeXULc4JDcKVI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IIOConfigurationProvider)P_0).InSightIOConfiguration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UDsebPDOpH1O8ONIr9T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOConfiguration)P_0).LineConfigurations;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WirpsEDImIOG7joStGB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOSettingsViewModel)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jNHaW0DDRbyNZaI5WQI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).HasDetails;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y0UDptDiLcvHuOXNLVT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).DetailsViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iGd39NDni7sx1lPZBws(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOSettingsViewModel)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lB6bB4DVuDmhYID7gAT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XtxSAIDfyTYkZJFdCWm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder i1RXLKDd010qwXLl0j3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LineDirection RKJNW6DlQ1R6qrhc7IY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).Direction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object np8c7dDgo73y0jOUsiZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).Model;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vSQc0xDsFY5DlZeJYgp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Input)P_0).Force;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ForceIOLine VhFojfDvBA2v589icfF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).Force;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MPTD7gDrG1H3ogRVq9m(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ListBoxViewModel)P_0).Value = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CfB5I7DPOuwG2ac6rRB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ListBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mxq1V3DZlVSu4QDyfMP(object P_0, ForceIOLine P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOLineViewModel)P_0).Force = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GvtAmFDBlulNYlhZYwh(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputsSnippet)P_0).GetByIndex(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bT7acpDbjpiEGS0m40u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Output)P_0).Force;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GCMygZDGOoGma3TV6LO(object P_0, CvsCellRange range, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippetType)P_0).NeedsUpdate(range, (CvsCellCollection)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Efje2WDoLAEaRbr7G4T()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
