using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Cognex.Common;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Read;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Read;
using Cognex.Ocr.Client;
using Cognex.Ocr.Client.Tool;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Read;

public class ReadViewModel : PropertySheetViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NlPBTAhewYB4GaXtGyj();
			int num;
			if (!CPiOaOhlgaORv0wvsJm())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_02e9;
				}
			}
			goto IL_02b6;
			IL_02e9:
			ReadViewModel readViewModel = _003C_003E4__this;
			num = 1;
			if (0 == 0)
			{
				goto IL_02b6;
			}
			goto IL_02fc;
			IL_02fc:
			int num2 = _003C_003E1__state;
			num = 4;
			if (1 == 0)
			{
				return;
			}
			goto IL_02b6;
			IL_02b6:
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!CPiOaOhlgaORv0wvsJm())
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						if ((uint)num2 > 1u)
						{
							object obj = kbtO7eh7KcVsLYoptHY(readViewModel);
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)((obj != null) ? a9OQmhhnB7h2pKStuTE(obj, LOUSCbhyJq63uKki9ha(), Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = 1;
								break;
							case 0:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 4;
								break;
							case 1:
								awaiter = _003C_003Eu__1;
								num3 = 9;
								break;
							}
							while (true)
							{
								switch (num3)
								{
								case 10:
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									continue;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 14:
									return;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
									awaiter = KRy8YyhfN7SARTo3dFh(readViewModel.YyoaAACZAG());
									if (!awaiter.IsCompleted)
									{
										num3 = 12;
										if (!CPiOaOhlgaORv0wvsJm())
										{
											continue;
										}
										return;
									}
									goto case 3;
								case 0:
									return;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 16;
									if (!CPiOaOhlgaORv0wvsJm())
									{
										continue;
									}
									goto case 3;
								case 3:
									awaiter.GetResult();
									goto case 5;
								default:
									num3 = 5;
									continue;
								case 5:
									awaiter = KRy8YyhfN7SARTo3dFh(readViewModel.MCZavpKjfT());
									if (awaiter.IsCompleted)
									{
										break;
									}
									goto case 8;
								case 8:
								case 13:
									num2 = (_003C_003E1__state = 1);
									num3 = 10;
									continue;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									continue;
								case 2:
								case 11:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 12:
									num2 = (_003C_003E1__state = 0);
									NlPBTAhewYB4GaXtGyj();
									num3 = ((!CPiOaOhlgaORv0wvsJm()) ? 11 : 13);
									continue;
								case 16:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								RXjwBrhzp09eijUixVe(_003C_003E7__wrap1);
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
					goto default;
				case 4:
					break;
				case 0:
				case 5:
					goto IL_02fc;
				case 6:
					return;
				}
				break;
			}
			goto IL_02e9;
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
		internal static object kbtO7eh7KcVsLYoptHY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LOUSCbhyJq63uKki9ha()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Initializing;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a9OQmhhnB7h2pKStuTE(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KRy8YyhfN7SARTo3dFh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RXjwBrhzp09eijUixVe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NlPBTAhewYB4GaXtGyj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CPiOaOhlgaORv0wvsJm()
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
	private struct _003CAcceptChangesAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!AMfwLGUX7kb4T0ZW5MO())
			{
			}
			ReadViewModel readViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					readViewModel = _003C_003E4__this;
					fxkCGgU2xIlcW5M24iD();
					num = (AMfwLGUX7kb4T0ZW5MO() ? 1 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 1;
								if (1 == 0)
								{
									goto IL_0073;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 14;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (AMfwLGUX7kb4T0ZW5MO())
							{
							}
						}
						goto IL_0154;
						IL_0073:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_0154;
						IL_0154:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 16;
							case 14:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								return;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								}
								goto IL_013b;
							case 6:
								num2 = (_003C_003E1__state = 1);
								num3 = 5;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								goto IL_013b;
							default:
								num3 = 13;
								continue;
							case 0:
							case 4:
								return;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								AMfwLGUX7kb4T0ZW5MO();
								num3 = ((!fxkCGgU2xIlcW5M24iD()) ? 3 : 0);
								continue;
							case 13:
								awaiter = bfErAsUMbIGLZOXfZBy(readViewModel.NNNayNTXXV());
								num3 = 15;
								continue;
							case 3:
								return;
							case 1:
								awaiter = bfErAsUMbIGLZOXfZBy(readViewModel.StandardPropertySheetViewModel.CommitAsync());
								num3 = 2;
								continue;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_0154;
								}
								IL_013b:
								awaiter.GetResult();
								goto case 13;
							}
							goto IL_0073;
							continue;
							end_IL_0154:
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
				case 5:
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
		internal static TaskAwaiter bfErAsUMbIGLZOXfZBy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fxkCGgU2xIlcW5M24iD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AMfwLGUX7kb4T0ZW5MO()
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
	private struct _003CCancelChangesAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rIA0lYUkrhskX1XTRXJ();
			int num;
			if (!JOKGovUmDte6AE4iKI0())
			{
				num = 2;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0275;
				}
			}
			goto IL_0242;
			IL_0242:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					goto IL_0275;
				default:
					goto IL_0286;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0275:
			ReadViewModel readViewModel = _003C_003E4__this;
			num = 4;
			goto IL_0242;
			IL_002a:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				switch (num2)
				{
				default:
					num3 = 9;
					break;
				case 0:
					awaiter = _003C_003Eu__1;
					_ = 0;
					num3 = ((!rIA0lYUkrhskX1XTRXJ()) ? 2 : 8);
					break;
				case 1:
					awaiter = _003C_003Eu__1;
					num3 = 0;
					break;
				}
				while (true)
				{
					switch (num3)
					{
					case 7:
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 1;
						if (true)
						{
							continue;
						}
						goto case 4;
					case 4:
						num2 = (_003C_003E1__state = 0);
						num3 = 13;
						continue;
					case 11:
						return;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 15;
						if (JOKGovUmDte6AE4iKI0())
						{
						}
						continue;
					case 3:
						awaiter.GetResult();
						awaiter = nxnT80UPR1kyaHiTHrH(readViewModel.SmqauQUJ3G());
						num3 = 7;
						continue;
					case 9:
						awaiter = nxnT80UPR1kyaHiTHrH(UZUf9QUrS9vAFbRpSHe(readViewModel.StandardPropertySheetViewModel));
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							continue;
						}
						goto case 3;
					case 12:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 11;
						continue;
					case 15:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 5:
					case 8:
						_003C_003Eu__1 = default;
						goto case 2;
					case 13:
						_003C_003Eu__1 = awaiter;
						num3 = 12;
						if (true)
						{
							continue;
						}
						goto case 1;
					case 1:
						num2 = (_003C_003E1__state = 1);
						num3 = 14;
						continue;
					case 14:
						_003C_003Eu__1 = awaiter;
						num3 = 10;
						continue;
					case 10:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 2:
					case 6:
						num2 = (_003C_003E1__state = -1);
						goto case 3;
					default:
						num3 = 3;
						continue;
					case 16:
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
			goto IL_0286;
			IL_0286:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0242;
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
		internal static object UZUf9QUrS9vAFbRpSHe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RollbackAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter nxnT80UPR1kyaHiTHrH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rIA0lYUkrhskX1XTRXJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JOKGovUmDte6AE4iKI0()
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
	private struct _003CInsightOnResultsChanged_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			ReadViewModel readViewModel = default;
			int num2 = default;
			string text = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					readViewModel = _003C_003E4__this;
					WhhkUKU48yZOGAOlvN5();
					if (!L3g077UgRyN7RpKTl8I())
					{
						num = 5;
						break;
					}
					num = 4;
					if (!L3g077UgRyN7RpKTl8I())
					{
						break;
					}
					goto default;
				case 2:
				case 5:
					try
					{
						try
						{
							int num3;
							if (num2 != 0)
							{
								text = (string)sHvfoZUSHkjRC5mhyGY(IyDs49U16eBI2jBPFP9(readViewModel.htoa1MsAMS), null);
								num3 = 6;
								if (L3g077UgRyN7RpKTl8I())
								{
									goto IL_0064;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
							}
							goto IL_00b2;
							IL_00b2:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 7:
									if (!awaiter.IsCompleted)
									{
										_ = 1;
										num3 = (L3g077UgRyN7RpKTl8I() ? 9 : 10);
										continue;
									}
									goto case 11;
								case 4:
								case 10:
									num2 = (_003C_003E1__state = 0);
									goto default;
								default:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								case 2:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 6:
									if (ace1KAU6OKOHSwsVMKh(text, readViewModel.lnUagtcS6p))
									{
										num3 = 1;
										if (0 == 0)
										{
											continue;
										}
										return;
									}
									goto end_IL_00b2;
								case 0:
									return;
								case 3:
									awaiter = ((Task)xdRaaaUDQVLIWO1rdjv(readViewModel.StandardPropertySheetViewModel)).GetAwaiter();
									num3 = 7;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 11:
									awaiter.GetResult();
									goto end_IL_00b2;
								}
								goto IL_0064;
								continue;
								end_IL_00b2:
								break;
							}
							goto end_IL_003c;
							IL_0064:
							readViewModel.lnUagtcS6p = text;
							num3 = 3;
							goto IL_00b2;
							end_IL_003c:;
						}
						catch (Exception ex)
						{
							UvXaVRU8ITN2XEijJbh(GH5aJSCdTZ, ex.Message, ex);
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
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					if (!WhhkUKU48yZOGAOlvN5())
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
		internal static object IyDs49U16eBI2jBPFP9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sHvfoZUSHkjRC5mhyGY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).GetPrimaryImageUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ace1KAU6OKOHSwsVMKh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xdRaaaUDQVLIWO1rdjv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RefreshResults();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UvXaVRU8ITN2XEijJbh(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WhhkUKU48yZOGAOlvN5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L3g077UgRyN7RpKTl8I()
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
	private struct _003CStandardPropertySheetViewModel_OnResultsChanged_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (MekouAUs9AsH3RDm2d5())
			{
				goto IL_001e;
			}
			goto IL_01b0;
			IL_01b0:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 0;
					if (MekouAUs9AsH3RDm2d5())
					{
					}
					continue;
				case 0:
					goto IL_01e5;
				case 1:
				case 4:
					goto IL_01fc;
				case 3:
					goto IL_0213;
				case 6:
					return;
				}
				break;
				IL_0213:
				num2 = _003C_003E1__state;
				MekouAUs9AsH3RDm2d5();
				num = (AMxbVyUF2tnU6c1rIPr() ? 4 : 5);
			}
			goto IL_001e;
			IL_01fc:
			ReadViewModel readViewModel = _003C_003E4__this;
			goto IL_001e;
			IL_01e5:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (0 == 0)
			{
				goto IL_01b0;
			}
			goto IL_01fc;
			IL_001e:
			try
			{
				try
				{
					int num3;
					TaskAwaiter awaiter = default;
					if (num2 != 0)
					{
						rWmKVvUdDSI6iaHfTGZ(readViewModel.JXraRyXvmy, readViewModel.ToolId);
						num3 = 6;
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
						case 6:
							awaiter = XVkcDWUENYWEtBXUY2C(readViewModel.MCZavpKjfT());
							MekouAUs9AsH3RDm2d5();
							if (AMxbVyUF2tnU6c1rIPr())
							{
								num3 = 9;
								if (AMxbVyUF2tnU6c1rIPr())
								{
									continue;
								}
								goto case 2;
							}
							num3 = 2;
							continue;
						case 2:
						case 3:
							_003C_003Eu__1 = awaiter;
							goto case 7;
						default:
							num3 = 7;
							if (true)
							{
								continue;
							}
							goto case 5;
						case 5:
							_003C_003Eu__1 = default;
							num3 = 4;
							continue;
						case 7:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 8;
							if (0 == 0)
							{
								continue;
							}
							goto case 1;
						case 1:
						case 9:
							if (awaiter.IsCompleted)
							{
								break;
							}
							num3 = 0;
							if (AMxbVyUF2tnU6c1rIPr())
							{
								continue;
							}
							goto case 0;
						case 0:
							num2 = (_003C_003E1__state = 0);
							goto case 2;
						case 8:
							return;
						case 4:
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							continue;
						case 10:
							break;
						}
						break;
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					GH5aJSCdTZ.ErrorException((string)GbesuwU5Ta73DhKCTDd(ex), ex);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01e5;
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
		internal static void rWmKVvUdDSI6iaHfTGZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SpreadsheetReadAdapter)P_0).OnNewResult((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XVkcDWUENYWEtBXUY2C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GbesuwU5Ta73DhKCTDd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AMxbVyUF2tnU6c1rIPr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MekouAUs9AsH3RDm2d5()
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
	private struct _003CUpdateResultViewModelAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadViewModel _003C_003E4__this;

		private ELReadResult _003CfullResult_003E5__2;

		private IResultImage _003Cimage_003E5__3;

		private IResultCharacters _003Cchars_003E5__4;

		private TaskAwaiter<ELReadResult> _003C_003Eu__1;

		private TaskAwaiter<IResultImage> _003C_003Eu__2;

		private TaskAwaiter<IResultCharacters> _003C_003Eu__3;

		private TaskAwaiter<CharacterSize> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AGQsvSUanUb0WCfhhiQ();
			int num;
			if (mqmANPU3LBGm9wOelSN())
			{
				num = 1;
				if (!mqmANPU3LBGm9wOelSN())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 8;
				if (AGQsvSUanUb0WCfhhiQ())
				{
					goto IL_04ef;
				}
			}
			goto IL_052e;
			IL_052e:
			int num2 = default;
			TaskAwaiter<ELReadResult> awaiter = default;
			ReadViewModel readViewModel = default;
			TaskAwaiter<CharacterSize> awaiter2 = default;
			TaskAwaiter<IResultImage> awaiter4 = default;
			TaskAwaiter<IResultCharacters> awaiter3 = default;
			IResultCharacters result3 = default;
			ELReadResult result2 = default;
			IResultImage result4 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = readViewModel.JXraRyXvmy.GetToolResultAsync(readViewModel.ToolId).GetAwaiter();
							num3 = 20;
							goto IL_0256;
						case 3:
							awaiter2 = _003C_003Eu__4;
							num3 = 3;
							if (AGQsvSUanUb0WCfhhiQ())
							{
								goto IL_00ca;
							}
							goto IL_0256;
						case 1:
							awaiter4 = _003C_003Eu__2;
							num3 = 19;
							goto IL_0256;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 13;
							if (true)
							{
								goto IL_0256;
							}
							goto IL_035b;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								_ = 0;
								num3 = ((!mqmANPU3LBGm9wOelSN()) ? 1 : 23);
								goto IL_0256;
							}
							IL_037c:
							_003C_003Eu__4 = default;
							num3 = 17;
							goto IL_0256;
							IL_00ca:
							awaiter2 = readViewModel.JXraRyXvmy.GetCharacterSize(readViewModel.ToolId).GetAwaiter();
							num3 = 25;
							goto IL_0256;
							IL_0256:
							while (true)
							{
								switch (num3)
								{
								case 28:
									num2 = (_003C_003E1__state = 1);
									num3 = 24;
									continue;
								case 24:
									_003C_003Eu__2 = awaiter4;
									num3 = 10;
									continue;
								case 15:
									return;
								case 14:
									break;
								case 27:
									_003Cchars_003E5__4 = result3;
									num3 = 14;
									if (mqmANPU3LBGm9wOelSN())
									{
										continue;
									}
									return;
								case 0:
									return;
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 12;
									continue;
								case 1:
								case 6:
									_003CfullResult_003E5__2 = result2;
									awaiter4 = readViewModel.JXraRyXvmy.GetImage(readViewModel.ToolId).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num3 = 28;
										continue;
									}
									goto IL_032f;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 0;
									continue;
								case 30:
									awaiter3 = readViewModel.JXraRyXvmy.GetCharacters(readViewModel.ToolId).GetAwaiter();
									num3 = 11;
									if (mqmANPU3LBGm9wOelSN())
									{
										continue;
									}
									goto case 12;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									continue;
								case 17:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 18:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 26;
									if (mqmANPU3LBGm9wOelSN())
									{
										continue;
									}
									goto case 25;
								case 25:
									if (!awaiter2.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto case 21;
								case 20:
									if (!awaiter.IsCompleted)
									{
										num3 = 16;
										if (!AGQsvSUanUb0WCfhhiQ())
										{
											continue;
										}
										goto case 29;
									}
									goto case 5;
								case 29:
									_003Cimage_003E5__3 = result4;
									num3 = 30;
									continue;
								case 11:
									if (awaiter3.IsCompleted)
									{
										goto case 2;
									}
									num2 = (_003C_003E1__state = 2);
									goto case 22;
								default:
									num3 = 22;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
									num2 = (_003C_003E1__state = 3);
									num3 = 7;
									continue;
								case 7:
									_003C_003Eu__4 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 15;
									continue;
								case 19:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_032f;
								case 26:
									return;
								case 13:
									goto IL_035b;
								case 3:
									goto IL_037c;
								case 21:
								{
									CharacterSize result5 = awaiter2.GetResult();
									ReadResultViewModel result6 = readViewModel.Result;
									IResultImage resultImage = _003Cimage_003E5__3;
									result6.Image = (Image)((resultImage != null) ? EDmkUOUo2cpSXsGNW7E(resultImage) : null);
									jYfdDpUc3RsCYAcE8Fm(readViewModel.Result, _003Cchars_003E5__4);
									Y1f7aOUuPmLyB96CU5p(readViewModel.Result, result5);
									num3 = 31;
									continue;
								}
								case 2:
									result3 = awaiter3.GetResult();
									num3 = 27;
									continue;
								case 5:
								case 23:
									result2 = awaiter.GetResult();
									goto case 1;
								case 8:
									return;
								case 16:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								case 22:
									_003C_003Eu__3 = awaiter3;
									num3 = 18;
									continue;
								case 31:
									{
										ReadResultViewModel result = readViewModel.Result;
										ELReadResult eLReadResult = _003CfullResult_003E5__2;
										b7JaN6UxKDrWOn1TOdd(result, ((eLReadResult != null) ? bIZCIvUBciebNK4OxG7(eLReadResult) : null) ?? "");
										goto end_IL_0051;
									}
									IL_032f:
									result4 = awaiter4.GetResult();
									num3 = 29;
									continue;
								}
								break;
							}
							goto IL_00ca;
							IL_035b:
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 2;
							if (0 == 0)
							{
								goto IL_0256;
							}
							goto IL_037c;
							end_IL_0051:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CfullResult_003E5__2 = null;
						_003Cimage_003E5__3 = null;
						_003Cchars_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				case 5:
					goto IL_04ef;
				case 7:
					_003C_003Et__builder.SetResult();
					num = 9;
					continue;
				case 3:
				case 8:
					_003CfullResult_003E5__2 = null;
					goto case 6;
				default:
					num = 6;
					continue;
				case 6:
					_003Cimage_003E5__3 = null;
					num = 5;
					continue;
				case 9:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_04ef:
			_003Cchars_003E5__4 = null;
			num = 7;
			goto IL_052e;
			IL_002e:
			readViewModel = _003C_003E4__this;
			num = 2;
			goto IL_052e;
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
		internal static object EDmkUOUo2cpSXsGNW7E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IResultImage)P_0).Image;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jYfdDpUc3RsCYAcE8Fm(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ReadResultViewModel)P_0).Characters = (IResultCharacters)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y1f7aOUuPmLyB96CU5p(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ReadResultViewModel)P_0).CharacterSize = (CharacterSize)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bIZCIvUBciebNK4OxG7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadResult)P_0).String;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void b7JaN6UxKDrWOn1TOdd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ReadResultViewModel)P_0).String = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mqmANPU3LBGm9wOelSN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AGQsvSUanUb0WCfhhiQ()
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

		public static Func<PropertySheetArgViewModel, bool> _003C_003E9__42_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			k8yiQ0UQBDGCH75Is3I();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			k8yiQ0UQBDGCH75Is3I();
			jyjxAYUqqTegdyjdfnP(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterOutFlexibleFieldingArgument_003Eb__42_0(PropertySheetArgViewModel argument)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AfdBYXULxKEm0ad5l9B(t3pqVuUVNxTea1CNSlQ(argument), ysRjTWUi1HNxqXn6a9x(3032));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void k8yiQ0UQBDGCH75Is3I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uGeceZUhHFyJ6e1my0X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TPkmByUU9uiU0qv7DUy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jyjxAYUqqTegdyjdfnP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object t3pqVuUVNxTea1CNSlQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertySheetArgViewModel)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ysRjTWUi1HNxqXn6a9x(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AfdBYXULxKEm0ad5l9B(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	private static readonly ILogger GH5aJSCdTZ;

	private readonly MultiTargetPropertyChangedRouter pJdaFW6Dkx;

	private readonly PropertySheetConfiguration DwyacHEEc1;

	private readonly SpreadsheetReadAdapter JXraRyXvmy;

	private readonly PropertySheetStringArgViewModel yYYaEiKjEw;

	private readonly IDisposable RNKa8Yd4ej;

	private readonly CvsInSight htoa1MsAMS;

	public string ToolId;

	[CompilerGenerated]
	private readonly StandardPropertySheetViewModel SkraDMHsSQ;

	[CompilerGenerated]
	private readonly PropertySheetEnumArgViewModel HHeajiab63;

	[CompilerGenerated]
	private readonly PropertySheetRegionArgViewModel EW2aPAW3AP;

	[CompilerGenerated]
	private readonly ReadResultViewModel E7Saqwjw9m;

	private bool N9OaX9ruGH;

	private string lnUagtcS6p;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)uMv9BHPKKDujJNwKtoT(DwyacHEEc1)).DisplayName;
		}
	}

	public StandardPropertySheetViewModel StandardPropertySheetViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SkraDMHsSQ;
		}
	}

	public PropertySheetEnumArgViewModel TrainingMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HHeajiab63;
		}
	}

	public PropertySheetRegionArgViewModel RegionOfInterest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EW2aPAW3AP;
		}
	}

	public ReadResultViewModel Result
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E7Saqwjw9m;
		}
	}

	public bool ShowPretrainedResultsView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N9OaX9ruGH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref N9OaX9ruGH, value, (string)V9ty1hPCwyZYIgSsL7c(2932));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void C4Xa7BR5QH(object P_0, FlexibleFieldingEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MIeDxIPA7ceYvvgoDB7(yYYaEiKjEw, P_1.FlexibleFieldingValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadViewModel(CvsInSight insight, PropertySheetConfiguration configuration)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 4:
				AiWHldPIEasKSMAFViy(xGu1wtPlTwlSGdqaDcZ(RegionOfInterest), new EventHandler(MS8a54ImwC));
				num = 17;
				continue;
			case 11:
			case 16:
				JXraRyXvmy.FlexibleFieldingChangedEvent += C4Xa7BR5QH;
				num = 7;
				continue;
			case 8:
				rPXLJrPbGYlsrD4O5vj(JXraRyXvmy, RegionOfInterest.Width, XUsiGCPWNFR29JPv7of(RegionOfInterest));
				_ = 0;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					num = 18;
					continue;
				}
				num = 11;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					continue;
				}
				break;
			case 3:
				pJdaFW6Dkx = new MultiTargetPropertyChangedRouter();
				num = 19;
				continue;
			case 1:
				fmpOmdPjNNv0cXLAbLM(JXraRyXvmy);
				num = 5;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					continue;
				}
				goto case 15;
			case 15:
				EW2aPAW3AP = StandardPropertySheetViewModel.FindArgument<PropertySheetRegionArgViewModel>((string)V9ty1hPCwyZYIgSsL7c(3016));
				num = 8;
				continue;
			case 2:
				throw new ArgumentNullException((string)V9ty1hPCwyZYIgSsL7c(2080));
			case 19:
				BaNhsKPwOXkSHs6WT7K(this);
				if (configuration != null)
				{
					DwyacHEEc1 = configuration;
					SkraDMHsSQ = new StandardPropertySheetViewModel(configuration);
					num = 10;
				}
				else
				{
					num = 2;
				}
				continue;
			case 12:
				JXraRyXvmy.RunToolCallback = StandardPropertySheetViewModel.RefreshResults;
				num = 1;
				continue;
			case 0:
				eQFsgvP7Eiehv6MFFD7(htoa1MsAMS, new EventHandler(KqTaYLYsfE));
				RNKa8Yd4ej = ((State)u4tnKIPyFZcS5qpAsil()).StateChanged.Subscribe(u3Laf00BKr);
				num = 21;
				continue;
			case 20:
				HHeajiab63 = StandardPropertySheetViewModel.FindArgument<PropertySheetEnumArgViewModel>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2986));
				AiWHldPIEasKSMAFViy(TrainingMode, new EventHandler(nFQaLMVljX));
				num = 15;
				continue;
			case 6:
				VQfJqqPNDc7aHWQMfsE();
				num = 3;
				continue;
			case 5:
				pJdaFW6Dkx.Register(StandardPropertySheetViewModel, (string)V9ty1hPCwyZYIgSsL7c(2838), vqda00IrHP);
				goto case 20;
			default:
				num = 20;
				if (b6EnkIPJkfla7ScFsYt())
				{
				}
				continue;
			case 14:
				ToolId = qJre8dPpO1aV3RrY6La().ToString();
				num = 9;
				if (!b6EnkIPJkfla7ScFsYt())
				{
					continue;
				}
				goto case 10;
			case 10:
				xYoa9Cd72A();
				E7Saqwjw9m = new ReadResultViewModel();
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				htoa1MsAMS = insight;
				num = 0;
				continue;
			case 13:
			case 18:
				AiWHldPIEasKSMAFViy(OpfFnlPeThaJ65rFIDQ(RegionOfInterest), new EventHandler(MS8a54ImwC));
				num = 4;
				continue;
			case 17:
				yYYaEiKjEw = StandardPropertySheetViewModel.FindArgument<PropertySheetStringArgViewModel>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(3032));
				goto case 11;
			case 9:
				break;
			case 21:
				return;
			}
			JXraRyXvmy = SpreadsheetReadAdapter.GetInstance(insight, ((ICogSocketAcq)f4ZywEPRV02qtJfsi7M(PZSdkPPGhOG6yyI0yOg(insight))).ManualTriggerAsync);
			num = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				EdK6a5PzAOTiHrIMgFm(RegionOfInterest.HeightArgument, new EventHandler(MS8a54ImwC));
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				((PropertySheetArgViewModel)xGu1wtPlTwlSGdqaDcZ(RegionOfInterest)).CurrentValueChanged -= MS8a54ImwC;
				num = 7;
				continue;
			case 1:
			case 2:
				TrainingMode.CurrentValueChanged -= nFQaLMVljX;
				goto case 0;
			case 7:
				JXraRyXvmy.FlexibleFieldingChangedEvent -= C4Xa7BR5QH;
				num = 8;
				continue;
			case 6:
				bq5ZOVPnF2labYCQ0wg(RNKa8Yd4ej);
				num = 5;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					continue;
				}
				break;
			case 5:
				break;
			case 8:
				return;
			}
			qnWolmPfII0tYVXRAYq(htoa1MsAMS, new EventHandler(KqTaYLYsfE));
			_ = 0;
			if (!X0nJcZPY5gUFi2LoDxE())
			{
				num = 0;
				continue;
			}
			num = 1;
			if (1 == 0)
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__30))]
	public override Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X0nJcZPY5gUFi2LoDxE();
		int num;
		if (!b6EnkIPJkfla7ScFsYt())
		{
			num = 5;
			if (!X0nJcZPY5gUFi2LoDxE())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_008e;
		IL_002e:
		_003CInitializeAsync_003Ed__30 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 1;
		goto IL_008e;
		IL_008e:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = GAWliV429HiCT468YI4();
				num = 2;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!b6EnkIPJkfla7ScFsYt())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptChangesAsync_003Ed__31))]
	protected override Task AcceptChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X0nJcZPY5gUFi2LoDxE();
		int num;
		if (!b6EnkIPJkfla7ScFsYt())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_009d;
			}
		}
		goto IL_006a;
		IL_006a:
		_003CAcceptChangesAsync_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = GAWliV429HiCT468YI4();
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009d;
		IL_009d:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_006a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCancelChangesAsync_003Ed__32))]
	protected override Task CancelChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (X0nJcZPY5gUFi2LoDxE())
		{
			num = 4;
			if (b6EnkIPJkfla7ScFsYt())
			{
			}
		}
		else
		{
			num = 5;
		}
		_003CCancelChangesAsync_003Ed__32 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = GAWliV429HiCT468YI4();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCompleted(bool result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 5:
				JXraRyXvmy.RunToolCallback = null;
				goto case 0;
			default:
				num = 0;
				continue;
			case 6:
				TfWf2X4XCOgCL3FlPKT(JXraRyXvmy, ToolId);
				_ = 0;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					num = 2;
					continue;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 1:
			case 2:
				pJdaFW6Dkx.Unregister(StandardPropertySheetViewModel);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				Dispose();
				break;
			case 3:
			case 4:
				break;
			case 7:
				return;
			}
			ef8Owc4Mky9TGrogLyQ(this, result);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool EvaluateValidity()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X0nJcZPY5gUFi2LoDxE();
		int num = ((!b6EnkIPJkfla7ScFsYt()) ? 1 : 5);
		States? state = default;
		States? states = default;
		States states2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				state = ((State)u4tnKIPyFZcS5qpAsil()).GetState(ToolId);
				num = 3;
				break;
			case 3:
				states = state;
				num = 7;
				break;
			case 6:
				states2 = States.EditLabels;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				states2 = States.EditCharacterSize;
				num = 2;
				break;
			default:
				states = state;
				num = 6;
				break;
			case 2:
				if (states != states2)
				{
					goto default;
				}
				return false;
			case 8:
				return states != states2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInsightOnResultsChanged_003Ed__35))]
	private void KqTaYLYsfE(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CInsightOnResultsChanged_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (X0nJcZPY5gUFi2LoDxE() ? 5 : 0);
				continue;
			case 1:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num = 4;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return;
			}
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStandardPropertySheetViewModel_OnResultsChanged_003Ed__36))]
	private void vqda00IrHP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (X0nJcZPY5gUFi2LoDxE())
		{
			num = 4;
			if (b6EnkIPJkfla7ScFsYt())
			{
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_007b;
			}
		}
		goto IL_0048;
		IL_0048:
		_003CStandardPropertySheetViewModel_OnResultsChanged_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 4:
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_007b;
		IL_007b:
		stateMachine._003C_003Et__builder = uGGFst4kqmV8Z5JHtRh();
		num = 1;
		goto IL_0048;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateResultViewModelAsync_003Ed__37))]
	private Task MCZavpKjfT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!X0nJcZPY5gUFi2LoDxE()) ? 2 : 3);
		_003CUpdateResultViewModelAsync_003Ed__37 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (!b6EnkIPJkfla7ScFsYt())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
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
	private void nFQaLMVljX(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vbyadphn0x();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void vbyadphn0x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		States valueOrDefault = default;
		States? state = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				valueOrDefault = state.GetValueOrDefault();
				num = 4;
				break;
			case 9:
				if (state.GetValueOrDefault() == States.None)
				{
					num = 8;
					break;
				}
				return;
			case 0:
				if (SU0jF04mL2ldnOZwijT(TrainingMode) != 0L)
				{
					X0nJcZPY5gUFi2LoDxE();
					num = (b6EnkIPJkfla7ScFsYt() ? 7 : 5);
					break;
				}
				if (state.HasValue)
				{
					num = 9;
					break;
				}
				return;
			case 4:
				if (valueOrDefault != States.EditCharacterSize && valueOrDefault != States.EditFielding)
				{
					goto case 1;
				}
				return;
			default:
				num = 1;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					break;
				}
				goto case 10;
			case 10:
				state = ((State)u4tnKIPyFZcS5qpAsil()).GetState(ToolId);
				num = 0;
				if (!b6EnkIPJkfla7ScFsYt())
				{
					break;
				}
				goto case 8;
			case 8:
				iAOuXN4rjZRPMnapx0j(u4tnKIPyFZcS5qpAsil(), ToolId, NavigationAction.Train);
				num = 11;
				break;
			case 2:
			case 5:
				if (state.HasValue)
				{
					goto case 3;
				}
				goto case 1;
			case 1:
				((State)u4tnKIPyFZcS5qpAsil()).ExecuteNavigationAction(ToolId, NavigationAction.Reset);
				num = 6;
				break;
			case 6:
				return;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MS8a54ImwC(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JXraRyXvmy.AdjustDefaultCharacterSizeBasedOnRoi(yLZB0w4Prk5CDbVKGXd(RegionOfInterest), XUsiGCPWNFR29JPv7of(RegionOfInterest));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void u3Laf00BKr(StateChangedArgs P_0)
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
			case 7:
				if ((string)v3Thkn44UsLZ1qeu2Re(P_0) == ToolId)
				{
					num = 2;
					if (X0nJcZPY5gUFi2LoDxE())
					{
						break;
					}
					goto case 0;
				}
				return;
			case 0:
				UVQS1j4SHDDsgn53Pr5();
				num = 8;
				break;
			case 3:
				if (P_0 != null)
				{
					_ = 0;
					num = ((!X0nJcZPY5gUFi2LoDxE()) ? 5 : 7);
					break;
				}
				return;
			default:
				vbyadphn0x();
				num = 0;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					break;
				}
				goto case 2;
			case 2:
				QtTwZj4g3RcmWhkUISy(this);
				num = 6;
				break;
			case 6:
				ShowPretrainedResultsView = Ium6AA41C85Qkt5PFsm(P_0) == States.None;
				goto default;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xYoa9Cd72A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		PropertySheetArgViewModel propertySheetArgViewModel = default;
		while (true)
		{
			switch (num)
			{
			default:
				((ArgumentGroupViewModel)AI5t7N46UA2YLDWhX7y(StandardPropertySheetViewModel)).Arguments.Remove(propertySheetArgViewModel);
				num = 5;
				break;
			case 0:
				propertySheetArgViewModel = StandardPropertySheetViewModel.AllArgumentGroup.Arguments.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PropertySheetArgViewModel argument) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.AfdBYXULxKEm0ad5l9B(_003C_003Ec.t3pqVuUVNxTea1CNSlQ(argument), _003C_003Ec.ysRjTWUi1HNxqXn6a9x(3032));
				});
				_ = 0;
				if (X0nJcZPY5gUFi2LoDxE())
				{
					num = 3;
					break;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				return;
			case 1:
			case 3:
				if (propertySheetArgViewModel != null)
				{
					goto default;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReadViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VQfJqqPNDc7aHWQMfsE();
		GH5aJSCdTZ = LogManager.GetLogger<ReadViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task YyoaAACZAG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)JTkrc34DY3VWn5ZfRWt(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task NNNayNTXXV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)Lc4t7X48rQhvjoQrQQD(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task SmqauQUJ3G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)AsTdgq4Fvik9lkkKRxW(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uMv9BHPKKDujJNwKtoT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).Function;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X0nJcZPY5gUFi2LoDxE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b6EnkIPJkfla7ScFsYt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V9ty1hPCwyZYIgSsL7c(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MIeDxIPA7ceYvvgoDB7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetStringArgViewModel)P_0).Value = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VQfJqqPNDc7aHWQMfsE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BaNhsKPwOXkSHs6WT7K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid qJre8dPpO1aV3RrY6La()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Guid.NewGuid();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PZSdkPPGhOG6yyI0yOg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f4ZywEPRV02qtJfsi7M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Acq;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fmpOmdPjNNv0cXLAbLM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ReadAdapterBase.Register((IOcrToolAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AiWHldPIEasKSMAFViy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetArgViewModel)P_0).CurrentValueChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XUsiGCPWNFR29JPv7of(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetRegionArgViewModel)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rPXLJrPbGYlsrD4O5vj(object P_0, double roiWidth, double roiHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ReadAdapterBase)P_0).AdjustDefaultCharacterSizeBasedOnRoi(roiWidth, roiHeight);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OpfFnlPeThaJ65rFIDQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetRegionArgViewModel)P_0).HeightArgument;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xGu1wtPlTwlSGdqaDcZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetRegionArgViewModel)P_0).WidthArgument;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eQFsgvP7Eiehv6MFFD7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u4tnKIPyFZcS5qpAsil()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OcrClient.State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bq5ZOVPnF2labYCQ0wg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qnWolmPfII0tYVXRAYq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EdK6a5PzAOTiHrIMgFm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetArgViewModel)P_0).CurrentValueChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GAWliV429HiCT468YI4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TfWf2X4XCOgCL3FlPKT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).ClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ef8Owc4Mky9TGrogLyQ(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseCompletableViewModel)P_0).OnCompleted(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder uGGFst4kqmV8Z5JHtRh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long SU0jF04mL2ldnOZwijT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetEnumArgViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iAOuXN4rjZRPMnapx0j(object P_0, object P_1, NavigationAction P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((State)P_0).ExecuteNavigationAction((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double yLZB0w4Prk5CDbVKGXd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetRegionArgViewModel)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v3Thkn44UsLZ1qeu2Re(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QtTwZj4g3RcmWhkUISy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0).Validate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static States Ium6AA41C85Qkt5PFsm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UVQS1j4SHDDsgn53Pr5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CommandManager.InvalidateRequerySuggested();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AI5t7N46UA2YLDWhX7y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StandardPropertySheetViewModel)P_0).AllArgumentGroup;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JTkrc34DY3VWn5ZfRWt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).InitializeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Lc4t7X48rQhvjoQrQQD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).AcceptChangesAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AsTdgq4Fvik9lkkKRxW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).CancelChangesAsync();
	}
}
