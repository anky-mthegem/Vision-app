using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Cognex.AnomalyDetector.Client;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.Common;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.WebToolEditControl.Core;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.AnomalyDetect;

public class AnomalyDetectViewModel : PropertySheetViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectViewModel _003C_003E4__this;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

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
			if (lcQAKxURI30BAKw1GPS())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01ef;
			IL_003d:
			AnomalyDetectViewModel anomalyDetectViewModel = _003C_003E4__this;
			num = 4;
			goto IL_01ef;
			IL_01ef:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					goto IL_003d;
				case 4:
					try
					{
						if (num2 != 0)
						{
							object obj = qoBjoAUIooHaJmd5xYv(anomalyDetectViewModel);
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)((obj != null) ? NmMjy8UWRcn3LKaT0FO(obj, Resources.Initializing, Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = y8X3d1UbXEUJ77DotIW(anomalyDetectViewModel.ea7Va6L3rh());
								_ = 1;
								if (!bthfMeUjdFwXLRnCSk6())
								{
									num3 = 7;
									if (false)
									{
										goto IL_00a7;
									}
								}
								else
								{
									num3 = 2;
									if (!lcQAKxURI30BAKw1GPS())
									{
										return;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 6;
							}
							goto IL_0108;
							IL_00a7:
							_003C_003Eu__1 = default;
							num3 = 1;
							goto IL_0108;
							IL_0108:
							while (true)
							{
								switch (num3)
								{
								case 6:
									break;
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 0:
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									}
									goto case 9;
								case 2:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									goto case 2;
								case 8:
									return;
								case 4:
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								case 9:
									awaiter.GetResult();
									goto end_IL_0108;
								}
								goto IL_00a7;
								continue;
								end_IL_0108:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
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
					goto case 5;
				default:
					num = 5;
					continue;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			goto IL_003d;
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
		internal static object qoBjoAUIooHaJmd5xYv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NmMjy8UWRcn3LKaT0FO(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter y8X3d1UbXEUJ77DotIW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lcQAKxURI30BAKw1GPS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bthfMeUjdFwXLRnCSk6()
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
	private struct _003CInsightOnResultsChanged_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AnomalyDetectViewModel _003C_003E4__this;

		public object sender;

		public EventArgs e;

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
			if (KH44r8UeZJphqApjMYJ())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_01f2;
				}
			}
			goto IL_01bf;
			IL_01bf:
			int num2 = default;
			AnomalyDetectViewModel anomalyDetectViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					anomalyDetectViewModel = _003C_003E4__this;
					num = 1;
					continue;
				case 1:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = vOcfWLUyE2qdHEHS0YU(mn4cDBU70EK53D4nfYl(anomalyDetectViewModel, sender, e));
								num3 = 8;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
								if (false)
								{
									goto IL_00b6;
								}
							}
							goto IL_0128;
							IL_00cf:
							num2 = (_003C_003E1__state = 0);
							oeWIMuUlijPYp2WIMyW();
							num3 = (KH44r8UeZJphqApjMYJ() ? 5 : 3);
							goto IL_0128;
							IL_00b6:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							if (!KH44r8UeZJphqApjMYJ())
							{
								goto IL_00cf;
							}
							goto IL_0128;
							IL_0128:
							while (true)
							{
								switch (num3)
								{
								case 4:
									_003C_003Eu__1 = default;
									break;
								case 2:
								case 5:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								case 1:
									return;
								case 3:
								case 6:
									break;
								case 7:
									goto IL_00cf;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto case 9;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									goto end_IL_0049;
								}
								break;
							}
							goto IL_00b6;
							end_IL_0049:;
						}
						catch (Exception ex)
						{
							dsErt7Uf47PZNC5IJ6T(B52Vhfk02f, lPoJXfUndNIW5DGmyMm(ex), ex);
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
				case 6:
					return;
				}
				break;
			}
			goto IL_01f2;
			IL_01f2:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (oeWIMuUlijPYp2WIMyW())
			{
				return;
			}
			goto IL_01bf;
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
		internal static object mn4cDBU70EK53D4nfYl(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AnomalyDetectViewModel)P_0).InsightOnResultsChangedAsync(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vOcfWLUyE2qdHEHS0YU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lPoJXfUndNIW5DGmyMm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dsErt7Uf47PZNC5IJ6T(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KH44r8UeZJphqApjMYJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oeWIMuUlijPYp2WIMyW()
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
	private struct _003CInsightOnResultsChangedAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			string text = default;
			AnomalyDetectViewModel anomalyDetectViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (imOfPIUzqUBxYhpDQdZ())
					{
						num = 0;
						break;
					}
					num = 5;
					if (true)
					{
						break;
					}
					return;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)m5QYXoQMXrAr0I4dYCA(pcSmJ1QX58XvD5Lj6iX(anomalyDetectViewModel.InSight), null);
							num3 = 6;
							goto IL_0136;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0094;
						IL_0094:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (false)
						{
							goto IL_00ac;
						}
						goto IL_0136;
						IL_00ac:
						awaiter = EyaCTCQrmRjh9sAEsop(nAbYRBQmyuur4VYEO9c(anomalyDetectViewModel.StandardPropertySheetViewModel));
						num3 = 0;
						goto IL_0136;
						IL_0136:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 8:
								anomalyDetectViewModel.oGHVl8KnDC = text;
								num3 = 2;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (imOfPIUzqUBxYhpDQdZ())
								{
									continue;
								}
								break;
							case 5:
							case 7:
								break;
							case 2:
								goto IL_00ac;
							case 6:
								if (hdEK2jQkjnXGZeGY7v6(text, anomalyDetectViewModel.oGHVl8KnDC))
								{
									_ = 0;
									if (imOfPIUzqUBxYhpDQdZ())
									{
										num3 = 8;
										if (true)
										{
											continue;
										}
										goto case 0;
									}
									num3 = 5;
									continue;
								}
								goto end_IL_004a;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 4;
								}
								goto case 11;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								awaiter.GetResult();
								goto end_IL_004a;
							}
							break;
						}
						goto IL_0094;
						end_IL_004a:;
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
						break;
					}
					goto case 0;
				case 0:
				case 1:
					anomalyDetectViewModel = _003C_003E4__this;
					goto case 2;
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
		internal static object pcSmJ1QX58XvD5Lj6iX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m5QYXoQMXrAr0I4dYCA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).GetPrimaryImageUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hdEK2jQkjnXGZeGY7v6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nAbYRBQmyuur4VYEO9c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RefreshResults();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EyaCTCQrmRjh9sAEsop(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool imOfPIUzqUBxYhpDQdZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kNr2u9Q2LuT9IDNvh4D()
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
	private struct _003CAcceptChangesAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			amPX2JQ4Y5Mc27NAhB0();
			int num;
			if (eVVlNEQPKoeGSYLpBWq())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (amPX2JQ4Y5Mc27NAhB0())
				{
				}
			}
			AnomalyDetectViewModel anomalyDetectViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					anomalyDetectViewModel = _003C_003E4__this;
					num = 1;
					if (eVVlNEQPKoeGSYLpBWq())
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
							if (num2 != 1)
							{
								num3 = 0;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 14;
								if (1 == 0)
								{
									goto IL_0181;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
							if (!eVVlNEQPKoeGSYLpBWq())
							{
								goto IL_0236;
							}
						}
						goto IL_00dd;
						IL_01c4:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_00dd;
						IL_00dd:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (!amPX2JQ4Y5Mc27NAhB0())
									{
										continue;
									}
									goto case 7;
								}
								goto case 6;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								if (!amPX2JQ4Y5Mc27NAhB0())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
								awaiter.GetResult();
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 2;
									continue;
								}
								goto IL_0236;
							case 15:
								return;
							case 14:
								break;
							case 8:
								awaiter = pJDOhbQgxhqKYqHHdXQ(anomalyDetectViewModel.DT7VVqj41c());
								num3 = 3;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 12:
							case 13:
								goto IL_01c4;
							case 0:
								awaiter = anomalyDetectViewModel.StandardPropertySheetViewModel.CommitAsync().GetAwaiter();
								num3 = 1;
								continue;
							case 10:
								goto IL_01f2;
							case 4:
							case 9:
								return;
							case 16:
								goto IL_0236;
							}
							break;
							IL_01f2:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							amPX2JQ4Y5Mc27NAhB0();
							num3 = (eVVlNEQPKoeGSYLpBWq() ? 9 : 12);
						}
						goto IL_0181;
						IL_0181:
						_003C_003Eu__1 = default;
						goto IL_01c4;
						IL_0236:
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
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
		internal static TaskAwaiter pJDOhbQgxhqKYqHHdXQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eVVlNEQPKoeGSYLpBWq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool amPX2JQ4Y5Mc27NAhB0()
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
	private struct _003CCancelChangesAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnomalyDetectViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (CyDwLOQS3wNCBl53gp9())
			{
				goto IL_001e;
			}
			goto IL_022e;
			IL_0287:
			int num2 = _003C_003E1__state;
			CyDwLOQS3wNCBl53gp9();
			if (!CUdDL3Q1DnX8aacPnWR())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (!CUdDL3Q1DnX8aacPnWR())
				{
					return;
				}
			}
			goto IL_022e;
			IL_022e:
			AnomalyDetectViewModel anomalyDetectViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					anomalyDetectViewModel = _003C_003E4__this;
					num = 0;
					continue;
				default:
					goto IL_0270;
				case 5:
					goto IL_0287;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0270:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (true)
			{
				goto IL_022e;
			}
			goto IL_0287;
			IL_001e:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 4;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 14;
						if (!CUdDL3Q1DnX8aacPnWR())
						{
							goto IL_01d8;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					num3 = 6;
				}
				goto IL_00ab;
				IL_00ab:
				while (true)
				{
					switch (num3)
					{
					case 10:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 14:
						_003C_003Eu__1 = default;
						goto case 13;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						continue;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 0;
						continue;
					case 6:
						awaiter.GetResult();
						break;
					default:
						num3 = 12;
						continue;
					case 2:
					case 9:
						num2 = (_003C_003E1__state = 0);
						num3 = 1;
						continue;
					case 11:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 10;
							continue;
						}
						goto case 16;
					case 1:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						continue;
					case 13:
					case 15:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 0:
						return;
					case 4:
						awaiter = CIVvgkQD3KtucgK9dUE(uvGk4sQ6Zbw7T9as5M2(anomalyDetectViewModel.StandardPropertySheetViewModel));
						num3 = 5;
						continue;
					case 5:
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							num3 = ((!CyDwLOQS3wNCBl53gp9()) ? 9 : 15);
							continue;
						}
						goto case 6;
					case 3:
						return;
					case 12:
						break;
					case 16:
						awaiter.GetResult();
						goto end_IL_00ab;
					}
					goto IL_01d8;
					continue;
					end_IL_00ab:
					break;
				}
				goto end_IL_001e;
				IL_01d8:
				awaiter = CIVvgkQD3KtucgK9dUE(anomalyDetectViewModel.XjWVNghqJS());
				num3 = 11;
				goto IL_00ab;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0270;
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
		internal static object uvGk4sQ6Zbw7T9as5M2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RollbackAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter CIVvgkQD3KtucgK9dUE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CUdDL3Q1DnX8aacPnWR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CyDwLOQS3wNCBl53gp9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger B52Vhfk02f;

	private readonly IDisposable MooVTUlEDL;

	private string oGHVl8KnDC;

	[CompilerGenerated]
	private readonly CvsInSight KQPVBL5ABi;

	[CompilerGenerated]
	private readonly PropertySheetConfiguration Kw5VeDG6UR;

	[CompilerGenerated]
	private readonly MultiTargetPropertyChangedRouter zLBVtQlI7H;

	[CompilerGenerated]
	private readonly SpreadsheetAnomalyDetectAdapter w5dV3OWyFr;

	[CompilerGenerated]
	private readonly string dxEVC6DJGP;

	[CompilerGenerated]
	private readonly StandardPropertySheetViewModel uEAVrL3pEe;

	private bool R8IViPdAu7;

	protected CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KQPVBL5ABi;
		}
	}

	protected PropertySheetConfiguration PropSheetConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Kw5VeDG6UR;
		}
	}

	protected MultiTargetPropertyChangedRouter PropChangedRouter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zLBVtQlI7H;
		}
	}

	public SpreadsheetAnomalyDetectAdapter ToolAdapter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return w5dV3OWyFr;
		}
	}

	public string ToolId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dxEVC6DJGP;
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
			return (string)OirMuy4A4HxGtUXnjk7(guglpq4CbDyuAHTDdyT(PropSheetConfig));
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
			return uEAVrL3pEe;
		}
	}

	public bool IsAnomalyDetectDialogInteractableOnStartup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return R8IViPdAu7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref R8IViPdAu7, value, (string)QMei8F49r7BXPO47dpt(3140));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnomalyDetectViewModel(CvsInSight insight, PropertySheetConfiguration configuration)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 11:
				YqPk6Y4tPBhDFjq10ZV(this);
				num = 7;
				break;
			case 2:
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				num = 0;
				if (Jg44EV4L7Z5bHHtmice())
				{
				}
				break;
			case 8:
				ToolAdapter.RunToolCallback = StandardPropertySheetViewModel.RefreshResults;
				num = 1;
				break;
			case 5:
				w5dV3OWyFr = SpreadsheetAnomalyDetectAdapter.GetInstance(InSight, ((ICogSocketAcq)Bak5Qf40EliN1RJLMUV(GKkqRI4ZVQ2blNYqhjs(InSight))).ManualTriggerAsync);
				goto case 8;
			default:
				num = 8;
				break;
			case 3:
			case 9:
				MooVTUlEDL = ((State)KAfMcR4ToVRaQ3memqN()).StateChanged.Subscribe(R71VoHFwNW);
				num = 12;
				break;
			case 0:
				zLBVtQlI7H = new MultiTargetPropertyChangedRouter();
				num = 11;
				break;
			case 1:
				uUVid34ObHCMyMQn3St(ToolAdapter);
				PropChangedRouter.Register(StandardPropertySheetViewModel, (string)QMei8F49r7BXPO47dpt(2838), BtjVxqngt6);
				num = 10;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				KQPVBL5ABi = insight ?? throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2606));
				Kw5VeDG6UR = configuration ?? throw new ArgumentNullException((string)QMei8F49r7BXPO47dpt(2080));
				uEAVrL3pEe = new StandardPropertySheetViewModel(configuration);
				_ = 0;
				num = ((!e97Wb54io6f4WPRygQ2()) ? 3 : 6);
				break;
			case 10:
				ytbDoY4HskHyppWXkQC(InSight, new EventHandler(InsightOnResultsChanged));
				goto case 3;
			case 4:
			case 6:
				dxEVC6DJGP = m0dAhK4vEYOyZFpJhGS().ToString();
				num = 5;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MooVTUlEDL.Dispose();
		KZrBrU4YPR01HC1BSRb(InSight, new EventHandler(InsightOnResultsChanged));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCompleted(bool result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Jg44EV4L7Z5bHHtmice())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0060;
		IL_00a5:
		Dispose();
		num = 7;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 2:
				PropChangedRouter.Unregister(StandardPropertySheetViewModel);
				break;
			default:
				num = 6;
				continue;
			case 5:
				ToolAdapter.RunToolCallback = null;
				num = 2;
				continue;
			case 1:
			case 4:
				goto IL_00a5;
			case 0:
			case 3:
				ToolAdapter.ClearCaches(ToolId);
				num = 5;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		base.OnCompleted(result);
		goto IL_00a5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__6))]
	public override Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CInitializeAsync_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = z5qQsv4JL2ECffGEbud();
				e97Wb54io6f4WPRygQ2();
				num = (Jg44EV4L7Z5bHHtmice() ? 5 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
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
	[AsyncStateMachine(typeof(_003CInsightOnResultsChanged_003Ed__7))]
	protected void InsightOnResultsChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jg44EV4L7Z5bHHtmice();
		int num;
		if (e97Wb54io6f4WPRygQ2())
		{
			num = 7;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (Jg44EV4L7Z5bHHtmice())
			{
			}
		}
		goto IL_00aa;
		IL_00aa:
		_003CInsightOnResultsChanged_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				break;
			case 1:
				goto IL_0048;
			case 6:
				stateMachine.sender = sender;
				num = 2;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine.e = e;
				goto IL_0048;
			default:
				num = 1;
				if (e97Wb54io6f4WPRygQ2())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = EJpTc94K4AQCAvDVbj8();
				num = 3;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0048:
		stateMachine._003C_003E1__state = -1;
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		if (!e97Wb54io6f4WPRygQ2())
		{
			goto IL_0048;
		}
		goto IL_00aa;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInsightOnResultsChangedAsync_003Ed__8))]
	protected virtual Task InsightOnResultsChangedAsync(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jg44EV4L7Z5bHHtmice();
		int num;
		if (e97Wb54io6f4WPRygQ2())
		{
			num = 5;
			if (Jg44EV4L7Z5bHHtmice())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0048;
		IL_0085:
		_003CInsightOnResultsChangedAsync_003Ed__8 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 3:
				goto IL_0085;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0085;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptChangesAsync_003Ed__33))]
	protected override Task AcceptChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CAcceptChangesAsync_003Ed__33 stateMachine = default;
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
			case 5:
				stateMachine._003C_003Et__builder = z5qQsv4JL2ECffGEbud();
				_ = 0;
				if (e97Wb54io6f4WPRygQ2())
				{
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
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
	[AsyncStateMachine(typeof(_003CCancelChangesAsync_003Ed__34))]
	protected override Task CancelChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Jg44EV4L7Z5bHHtmice();
		int num = ((!e97Wb54io6f4WPRygQ2()) ? 5 : 4);
		_003CCancelChangesAsync_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = z5qQsv4JL2ECffGEbud();
				num = 1;
				if (Jg44EV4L7Z5bHHtmice())
				{
				}
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BtjVxqngt6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			JLJ1qV4N9PsZ08gAZvZ(ToolAdapter, ToolId);
		}
		catch (Exception ex)
		{
			yFEHUf4phAyWILBEwp3(B52Vhfk02f, CFEsx44wYaYYUbvXaq2(ex), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool EvaluateValidity()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((State)KAfMcR4ToVRaQ3memqN()).GetState(ToolId) == States.Evaluation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void R71VoHFwNW(StateChangedArgs P_0)
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
			case 1:
			case 5:
				if (K3MeOF4GPHhut2hSuIl(P_0.ToolId, ToolId))
				{
					num = 2;
					break;
				}
				return;
			case 0:
				IsAnomalyDetectDialogInteractableOnStartup = true;
				num = 7;
				if (e97Wb54io6f4WPRygQ2())
				{
					break;
				}
				goto case 2;
			case 2:
				Validate();
				goto default;
			default:
				db61fD4RC8i5cMUFaAq();
				num = 0;
				break;
			case 6:
				if (P_0 != null)
				{
					_ = 0;
					num = (e97Wb54io6f4WPRygQ2() ? 5 : 4);
					break;
				}
				return;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnomalyDetectViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SCxsgs4jxC8wJcRGIx5();
		B52Vhfk02f = LogManager.GetLogger<AnomalyDetectViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task ea7Va6L3rh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)OvSUYu4IXpPOhg8uR0W(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task DT7VVqj41c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)IjDZOu4WxwvxFwMtpFI(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task XjWVNghqJS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)ARw9Dc4b02K4DVIZdC7(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YqPk6Y4tPBhDFjq10ZV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QMei8F49r7BXPO47dpt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid m0dAhK4vEYOyZFpJhGS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Guid.NewGuid();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GKkqRI4ZVQ2blNYqhjs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bak5Qf40EliN1RJLMUV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Acq;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uUVid34ObHCMyMQn3St(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectAdapterBase.Register((IAnomalyDetectorAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ytbDoY4HskHyppWXkQC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KAfMcR4ToVRaQ3memqN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AnomalyDetectorClient.State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e97Wb54io6f4WPRygQ2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jg44EV4L7Z5bHHtmice()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZrBrU4YPR01HC1BSRb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder z5qQsv4JL2ECffGEbud()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder EJpTc94K4AQCAvDVbj8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object guglpq4CbDyuAHTDdyT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).Function;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OirMuy4A4HxGtUXnjk7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JLJ1qV4N9PsZ08gAZvZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AnomalyDetectAdapterBase)P_0).OnNewResult((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CFEsx44wYaYYUbvXaq2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yFEHUf4phAyWILBEwp3(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K3MeOF4GPHhut2hSuIl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void db61fD4RC8i5cMUFaAq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CommandManager.InvalidateRequerySuggested();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SCxsgs4jxC8wJcRGIx5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OvSUYu4IXpPOhg8uR0W(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).InitializeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IjDZOu4WxwvxFwMtpFI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).AcceptChangesAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ARw9Dc4b02K4DVIZdC7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).CancelChangesAsync();
	}
}
