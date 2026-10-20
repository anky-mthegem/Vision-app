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
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Segment;
using Cognex.Mvvm;
using Cognex.Segmenter.Client;
using Cognex.WebToolEditControl.Core;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Segment;

public class SegmentViewModel : PropertySheetViewModel, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__3_0;

		public static Func<PropertySheetArgViewModel, bool> _003C_003E9__39_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CN1DuBhx0biXucx32LV();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CN1DuBhx0biXucx32LV();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__3_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetAutoTuneEnableDisable_003Eb__39_0(PropertySheetArgViewModel arg)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)lemuBYhhQrj2pyFs5GX(arg) == (string)XIAxDqhULJ8KEZQh3qR(7764);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CN1DuBhx0biXucx32LV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RKshfXhuRNorubLrpX0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b6K6kohBY3xcf6iLKO0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lemuBYhhQrj2pyFs5GX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertySheetArgViewModel)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XIAxDqhULJ8KEZQh3qR(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshResults_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!Gc4ygShQoKFrXETUCdd())
			{
				goto IL_001e;
			}
			goto IL_01ad;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01ad;
			IL_01ad:
			int num2 = default;
			SegmentViewModel segmentViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (T1xG7DhqbnadQSevejc() ? 5 : 0);
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = r0JSPuhio6Uyva6hYPB(KdBiJghVLvYBXqx08U6(segmentViewModel.StandardPropertySheetViewModel));
							T1xG7DhqbnadQSevejc();
							num3 = ((!Gc4ygShQoKFrXETUCdd()) ? 7 : 9);
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
							case 8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 0:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 8;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 5:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 10:
								segmentViewModel.BQDalo9tbe();
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
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					segmentViewModel = _003C_003E4__this;
					goto case 2;
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
		internal static object KdBiJghVLvYBXqx08U6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RefreshResults();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r0JSPuhio6Uyva6hYPB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gc4ygShQoKFrXETUCdd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T1xG7DhqbnadQSevejc()
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
	private struct _003CInitializeAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!dYkcs8htyiCLm7jt4Hl())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (!KapOeRhLa4tXoxs9oNx())
				{
					goto IL_005c;
				}
			}
			goto IL_01fb;
			IL_01fb:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 3:
					goto IL_003f;
				case 2:
					goto IL_005c;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto IL_0228;
				case 1:
				case 4:
					goto IL_0228;
				case 6:
					return;
				}
				break;
			}
			goto IL_0024;
			IL_0228:
			SegmentViewModel segmentViewModel = _003C_003E4__this;
			num = 2;
			if (dYkcs8htyiCLm7jt4Hl())
			{
			}
			goto IL_01fb;
			IL_005c:
			int num2 = default;
			try
			{
				if (num2 != 0)
				{
					object obj = Cla7Cwh9RSxihPRHXfD(segmentViewModel);
					_003C_003E7__wrap1 = (ITopLevelProgressableOperation)((obj != null) ? KDDIIDhZa8oc7NtdeRX(obj, qjHablhvnnCm6pwIafu(), Array.Empty<StepDescriptor>()) : null);
				}
				try
				{
					TaskAwaiter awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = segmentViewModel.wYgaBZIgDB().GetAwaiter();
						num3 = 6;
						goto IL_00de;
					}
					awaiter = _003C_003Eu__1;
					goto IL_015f;
					IL_015f:
					_003C_003Eu__1 = default;
					num3 = 8;
					goto IL_00de;
					IL_00de:
					while (true)
					{
						switch (num3)
						{
						case 7:
							_003C_003Eu__1 = awaiter;
							num3 = 2;
							if (!dYkcs8htyiCLm7jt4Hl())
							{
								continue;
							}
							goto case 2;
						case 2:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							goto default;
						default:
							_ = 0;
							num3 = ((!KapOeRhLa4tXoxs9oNx()) ? 1 : 0);
							continue;
						case 8:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 6:
							if (!awaiter.IsCompleted)
							{
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 3;
							}
							goto case 9;
						case 3:
							num2 = (_003C_003E1__state = 0);
							num3 = 7;
							continue;
						case 1:
						case 5:
							break;
						case 0:
						case 4:
							return;
						case 9:
							awaiter.GetResult();
							goto end_IL_00de;
						}
						goto IL_015f;
						continue;
						end_IL_00de:
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
			goto IL_0024;
			IL_0024:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!KapOeRhLa4tXoxs9oNx())
			{
				goto IL_003f;
			}
			goto IL_01fb;
			IL_003f:
			num2 = _003C_003E1__state;
			goto IL_0228;
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
		internal static object Cla7Cwh9RSxihPRHXfD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qjHablhvnnCm6pwIafu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Initializing;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KDDIIDhZa8oc7NtdeRX(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KapOeRhLa4tXoxs9oNx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dYkcs8htyiCLm7jt4Hl()
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
	private struct _003CInsightOnResultsChanged_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

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
			zOOalFh0aEpQn35CUCc();
			int num;
			if (!v25oPdhOvWf5W1NL57Z())
			{
				num = 4;
				if (v25oPdhOvWf5W1NL57Z())
				{
				}
			}
			else
			{
				num = 2;
				if (v25oPdhOvWf5W1NL57Z())
				{
					goto IL_0208;
				}
			}
			goto IL_01af;
			IL_01af:
			int num2 = default;
			SegmentViewModel segmentViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = segmentViewModel.InsightOnResultsChangedAsync(sender, e).GetAwaiter();
								num3 = 6;
								if (false)
								{
									goto IL_005f;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
								if (1 == 0)
								{
									goto IL_00ca;
								}
							}
							goto IL_011a;
							IL_00ca:
							_003C_003Eu__1 = awaiter;
							goto IL_00fa;
							IL_00fa:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_005f:
							num2 = (_003C_003E1__state = 0);
							num3 = 5;
							goto IL_011a;
							IL_011a:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 7:
									break;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 4;
									if (zOOalFh0aEpQn35CUCc())
									{
										continue;
									}
									goto case 6;
								case 6:
									if (!awaiter.IsCompleted)
									{
										_ = 0;
										if (zOOalFh0aEpQn35CUCc())
										{
											num3 = 7;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										num3 = 8;
										if (zOOalFh0aEpQn35CUCc())
										{
											continue;
										}
										goto case 4;
									}
									goto case 9;
								case 0:
									return;
								case 5:
									goto IL_00ca;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 3:
								case 8:
									goto IL_00fa;
								default:
									num3 = 0;
									continue;
								case 9:
									awaiter.GetResult();
									goto end_IL_0035;
								}
								break;
							}
							goto IL_005f;
							end_IL_0035:;
						}
						catch (Exception ex)
						{
							SiFN0whTEnuknO0Ihut(QydaCmd2hZ, s8AWD4hHvHyZTsTMc27(ex), ex);
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
					num = 3;
					continue;
				case 1:
				case 2:
					segmentViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0208;
			IL_0208:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01af;
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
		internal static object s8AWD4hHvHyZTsTMc27(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SiFN0whTEnuknO0Ihut(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zOOalFh0aEpQn35CUCc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v25oPdhOvWf5W1NL57Z()
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
	private struct _003CInsightOnResultsChangedAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e171YphJIZ8hO8J5KKu();
			int num = ((!SXRcaEhY2CBLXmTrufZ()) ? 5 : 2);
			SegmentViewModel segmentViewModel = default;
			int num2 = default;
			string text = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					segmentViewModel = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							text = (string)VbfhKJhCCNr0pJoIvaA(jKfNAehKjB9p7Oonvkg(segmentViewModel.InSight), null);
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_0146;
							}
						}
						goto IL_00c3;
						IL_0146:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch (num3)
							{
							case 7:
								segmentViewModel.UndaioL2Bp = text;
								num3 = 10;
								if (SXRcaEhY2CBLXmTrufZ())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (JWtX24hAiiHpVRlUXG1(text, segmentViewModel.UndaioL2Bp))
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 10;
								}
								goto end_IL_00c3;
							case 10:
								awaiter = PibbZHhwmtLgvrbJsfL(IBWuTdhNLGKrGB7DNEM(segmentViewModel.StandardPropertySheetViewModel));
								num3 = 1;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								SXRcaEhY2CBLXmTrufZ();
								num3 = (e171YphJIZ8hO8J5KKu() ? 6 : 0);
								continue;
							case 2:
								_003C_003Eu__1 = default;
								break;
							case 9:
								return;
							case 6:
							case 8:
								break;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								}
								goto case 11;
							case 0:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 11:
								awaiter.GetResult();
								goto end_IL_00c3;
							}
							goto IL_0146;
							continue;
							end_IL_00c3:
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
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (e171YphJIZ8hO8J5KKu())
				{
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
		internal static object jKfNAehKjB9p7Oonvkg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VbfhKJhCCNr0pJoIvaA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).GetPrimaryImageUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWtX24hAiiHpVRlUXG1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IBWuTdhNLGKrGB7DNEM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).RefreshResults();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PibbZHhwmtLgvrbJsfL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SXRcaEhY2CBLXmTrufZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e171YphJIZ8hO8J5KKu()
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
	private struct _003CAcceptChangesAsync_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q8F3athGXiR5Rh9MvbE();
			int num;
			if (nKZv7Phplsf0QmqcRyl())
			{
				num = 2;
				if (!nKZv7Phplsf0QmqcRyl())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0244;
			IL_0297:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0244;
			IL_0244:
			int num2 = default;
			SegmentViewModel segmentViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					segmentViewModel = _003C_003E4__this;
					num = 4;
					continue;
				default:
					goto IL_0297;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 15;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 0;
						if (false)
						{
							goto IL_01f1;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_ = 1;
					if (!Q8F3athGXiR5Rh9MvbE())
					{
						num3 = 10;
						if (!nKZv7Phplsf0QmqcRyl())
						{
							goto IL_0121;
						}
					}
					else
					{
						num3 = 13;
					}
				}
				goto IL_0186;
				IL_0186:
				while (true)
				{
					switch (num3)
					{
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 14;
						continue;
					case 9:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						if (true)
						{
							continue;
						}
						break;
					case 5:
					case 13:
						break;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 15;
					case 15:
						awaiter = ((Task)ihcIsohRnqaDU2JHQIH(segmentViewModel.StandardPropertySheetViewModel)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 9;
							continue;
						}
						goto case 1;
					case 14:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						continue;
					case 12:
						if (!awaiter.IsCompleted)
						{
							num3 = 11;
							continue;
						}
						goto case 16;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 4:
					case 10:
						goto IL_0121;
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 2:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 1:
						awaiter.GetResult();
						awaiter = XryGL1hjDX8V4csY7o8(segmentViewModel.gLXaeN8Z3Q());
						goto case 12;
					default:
						num3 = 12;
						continue;
					case 3:
						return;
					case 11:
						goto IL_01f1;
					case 16:
						awaiter.GetResult();
						goto end_IL_002e;
					}
					break;
				}
				goto IL_006b;
				IL_0121:
				_003C_003Eu__1 = default;
				goto IL_006b;
				IL_01f1:
				num2 = (_003C_003E1__state = 1);
				num3 = 6;
				goto IL_0186;
				IL_006b:
				num2 = (_003C_003E1__state = -1);
				num3 = 1;
				goto IL_0186;
				end_IL_002e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0297;
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
		internal static object ihcIsohRnqaDU2JHQIH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StandardPropertySheetViewModel)P_0).CommitAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XryGL1hjDX8V4csY7o8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nKZv7Phplsf0QmqcRyl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q8F3athGXiR5Rh9MvbE()
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
	private struct _003CCancelChangesAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			SegmentViewModel segmentViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					segmentViewModel = _003C_003E4__this;
					_ = 1;
					if (!MEjs6ZhWJLgg1hXqVFa())
					{
						num = 1;
						if (BXsdvDhIDfVNgQj4CJ4())
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 0;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 2;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 9:
								return;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 14;
								continue;
							case 4:
							case 11:
								return;
							case 0:
								awaiter = vkfeodhbwahxykk2O9t(segmentViewModel.StandardPropertySheetViewModel.RollbackAsync());
								num3 = 3;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto case 8;
							case 1:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 13;
								if (BXsdvDhIDfVNgQj4CJ4())
								{
									continue;
								}
								goto default;
							default:
								awaiter = vkfeodhbwahxykk2O9t(segmentViewModel.c5WatusMG3());
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								if (!MEjs6ZhWJLgg1hXqVFa())
								{
									num3 = 11;
									continue;
								}
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 8:
								awaiter.GetResult();
								goto default;
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
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
		internal static TaskAwaiter vkfeodhbwahxykk2O9t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BXsdvDhIDfVNgQj4CJ4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MEjs6ZhWJLgg1hXqVFa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger QydaCmd2hZ;

	private readonly IDisposable jbcarbXj9D;

	private string UndaioL2Bp;

	[CompilerGenerated]
	private readonly CvsInSight EiJa6DGV6X;

	[CompilerGenerated]
	private readonly PropertySheetConfiguration YJLanKotof;

	[CompilerGenerated]
	private readonly MultiTargetPropertyChangedRouter l5BaHBOCwl;

	[CompilerGenerated]
	private readonly SpreadsheetSegmentAdapter ihTapsJ7KY;

	[CompilerGenerated]
	private readonly string a5maW0lZqw;

	[CompilerGenerated]
	private readonly StandardPropertySheetViewModel CivaSEt4gd;

	private bool FuoaKnW1sv;

	[CompilerGenerated]
	private readonly DelegateCommand FGaamuJqb4;

	private SegmentProjectionParamsViewModel knGaMEH8jB;

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
			return EiJa6DGV6X;
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
			return YJLanKotof;
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
			return l5BaHBOCwl;
		}
	}

	public SpreadsheetSegmentAdapter ToolAdapter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ihTapsJ7KY;
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
			return a5maW0lZqw;
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
			return ((CvsFunction)bh0BA2PBZB9cbSydDaW(PropSheetConfig)).DisplayName;
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
			return CivaSEt4gd;
		}
	}

	public bool IsSegmentDialogInteractableOnStartup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FuoaKnW1sv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref FuoaKnW1sv, value, (string)CeqrBjP6bXIMsVlJIcF(2856));
		}
	}

	public DelegateCommand DoAutoTune
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FGaamuJqb4;
		}
	}

	public SegmentProjectionParamsViewModel SegmentProjectionParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return knGaMEH8jB;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SegmentViewModel(CvsInSight insight, PropertySheetConfiguration configuration, SegmentProjectionParamsViewModel segmentProjectionParams = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 17;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_016e;
		IL_001a:
		S0LDB8PEPAp9TYOQj5Q(knGaMEH8jB);
		num = 11;
		goto IL_016e;
		IL_016e:
		while (true)
		{
			IL_016e_2:
			switch (num)
			{
			case 1:
				break;
			case 17:
				l8UlKdP1I0xqLDiXG7g();
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				CivaSEt4gd = new StandardPropertySheetViewModel(configuration);
				num = 2;
				continue;
			case 5:
			case 13:
				throw new ArgumentNullException((string)CeqrBjP6bXIMsVlJIcF(2080));
			case 18:
				knGaMEH8jB = segmentProjectionParams;
				if (knGaMEH8jB != null)
				{
					num = 15;
					if (BpCkWUPguEuH6GGeQBj())
					{
					}
					continue;
				}
				return;
			case 4:
				PropChangedRouter.Register(StandardPropertySheetViewModel, (string)CeqrBjP6bXIMsVlJIcF(2838), K9tahis5l6);
				cr4qnZPFoug11Jgul80(InSight, new EventHandler(InsightOnResultsChanged));
				jbcarbXj9D = ((State)QTN3B6PsWxCDenNfWMi()).StateChanged.Subscribe(ip2aTVABB9);
				num = 18;
				continue;
			case 12:
				SegmentAdapterBase.Register(ToolAdapter);
				num = 4;
				if (!BpCkWUPguEuH6GGeQBj())
				{
					continue;
				}
				goto case 0;
			case 0:
				YJLanKotof = configuration;
				num = 9;
				continue;
			case 10:
				pnsFyxPSgjPsKNRWrcW(this);
				num = 6;
				continue;
			case 2:
				a5maW0lZqw = wLI6knPD7kwjDMqFZTF().ToString();
				goto case 16;
			default:
				num = 16;
				continue;
			case 3:
				throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2606));
			case 6:
				while (insight != null)
				{
					if (configuration != null)
					{
						EiJa6DGV6X = insight;
						num = 0;
					}
					else
					{
						qpwKVtP4IkWdXpGprnu();
						if (!BpCkWUPguEuH6GGeQBj())
						{
							num = 13;
							if (1 == 0)
							{
								continue;
							}
						}
						else
						{
							num = 7;
						}
					}
					goto IL_016e_2;
				}
				num = 3;
				if (qpwKVtP4IkWdXpGprnu())
				{
					continue;
				}
				goto case 7;
			case 7:
			case 14:
				FGaamuJqb4 = new DelegateCommand(knGaMEH8jB.PerformAutoTune, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				num = 1;
				continue;
			case 15:
				R7Pi9PPdtG04UsqI1u2(knGaMEH8jB, ToolId);
				goto case 7;
			case 8:
				l5BaHBOCwl = new MultiTargetPropertyChangedRouter();
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				BQDalo9tbe();
				num = 19;
				if (0 == 0)
				{
					continue;
				}
				goto case 16;
			case 16:
				ihTapsJ7KY = SpreadsheetSegmentAdapter.GetInstance(InSight, ((CvsCogSocket)HmGaagP8HWRu6dUw2sF(InSight)).Acq.ManualTriggerAsync);
				ToolAdapter.RunToolCallback = RefreshResults;
				num = 12;
				if (!BpCkWUPguEuH6GGeQBj())
				{
					continue;
				}
				return;
			case 19:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cFNUA8P5vQvynmL74wB(jbcarbXj9D);
		FgNEq1P3XLjpyYPtXNu(InSight, new EventHandler(InsightOnResultsChanged));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshResults_003Ed__5))]
	protected Task RefreshResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BpCkWUPguEuH6GGeQBj();
		int num;
		if (qpwKVtP4IkWdXpGprnu())
		{
			num = 5;
			if (!qpwKVtP4IkWdXpGprnu())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00c1;
			}
		}
		goto IL_0048;
		IL_008f:
		_003CRefreshResults_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_00c1:
		return stateMachine._003C_003Et__builder.Task;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_008f;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = rYjgpNPaLrAh4RaI0rH();
				num = 1;
				if (!BpCkWUPguEuH6GGeQBj())
				{
					continue;
				}
				goto IL_008f;
			case 4:
				goto IL_008f;
			case 1:
				stateMachine._003C_003E4__this = this;
				break;
			case 6:
				goto IL_00c1;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCompleted(bool result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qpwKVtP4IkWdXpGprnu();
		int num = (BpCkWUPguEuH6GGeQBj() ? 4 : 6);
		while (true)
		{
			switch (num)
			{
			case 2:
				Dispose();
				num = 7;
				if (BpCkWUPguEuH6GGeQBj())
				{
				}
				continue;
			case 5:
				PropChangedRouter.Unregister(StandardPropertySheetViewModel);
				break;
			case 0:
			case 6:
				O6DlMjPo5uFuWjHOoM3(ToolAdapter, ToolId);
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				ToolAdapter.RunToolCallback = null;
				num = 5;
				continue;
			case 7:
				return;
			}
			uwZR5iPcSXEEJM5rIQt(this, result);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__7))]
	public override Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qpwKVtP4IkWdXpGprnu();
		int num;
		if (!BpCkWUPguEuH6GGeQBj())
		{
			num = 3;
			if (!qpwKVtP4IkWdXpGprnu())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0048;
		IL_0073:
		_003CInitializeAsync_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0073;
			case 5:
				stateMachine._003C_003E4__this = this;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0073;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInsightOnResultsChanged_003Ed__8))]
	protected void InsightOnResultsChanged(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (BpCkWUPguEuH6GGeQBj())
		{
			goto IL_001e;
		}
		goto IL_0056;
		IL_003c:
		_003CInsightOnResultsChanged_003Ed__8 stateMachine = default;
		stateMachine.e = e;
		goto IL_008b;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 0:
			case 3:
				goto IL_003c;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto IL_008b;
			case 5:
				goto IL_008b;
			case 7:
				goto IL_009d;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 6;
				continue;
			case 8:
				return;
			}
			break;
			IL_009d:
			stateMachine._003C_003Et__builder = Cq8e8cPuHl2sZKGWTyd();
			_ = 0;
			if (!qpwKVtP4IkWdXpGprnu())
			{
				num = 0;
				if (qpwKVtP4IkWdXpGprnu())
				{
					continue;
				}
				goto IL_003c;
			}
			num = 4;
		}
		goto IL_001e;
		IL_008b:
		stateMachine._003C_003E1__state = -1;
		num = 2;
		goto IL_0056;
		IL_001e:
		stateMachine.sender = sender;
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInsightOnResultsChangedAsync_003Ed__9))]
	protected virtual Task InsightOnResultsChangedAsync(object sender, EventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (BpCkWUPguEuH6GGeQBj())
		{
			goto IL_001e;
		}
		goto IL_009a;
		IL_001e:
		_003CInsightOnResultsChangedAsync_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (BpCkWUPguEuH6GGeQBj())
		{
		}
		goto IL_009a;
		IL_009a:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (!BpCkWUPguEuH6GGeQBj())
				{
					num = 4;
					continue;
				}
				num = 3;
				if (!BpCkWUPguEuH6GGeQBj())
				{
					continue;
				}
				goto case 2;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 0;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptChangesAsync_003Ed__34))]
	protected override Task AcceptChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!qpwKVtP4IkWdXpGprnu()) ? 1 : 3);
		_003CAcceptChangesAsync_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = rYjgpNPaLrAh4RaI0rH();
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
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
	[AsyncStateMachine(typeof(_003CCancelChangesAsync_003Ed__35))]
	protected override Task CancelChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CCancelChangesAsync_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = rYjgpNPaLrAh4RaI0rH();
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (BpCkWUPguEuH6GGeQBj())
				{
					num = 0;
					if (qpwKVtP4IkWdXpGprnu())
					{
						break;
					}
					goto default;
				}
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K9tahis5l6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			NSr9nxPxlZ0K7nYe4kC(ToolAdapter, ToolId);
		}
		catch (Exception ex)
		{
			vvUGnNPUbviMxef9jfL(QydaCmd2hZ, vOnwxZPhxXRLaYQfm6w(ex), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool EvaluateValidity()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((State)QTN3B6PsWxCDenNfWMi()).GetState(ToolId) == States.Evaluation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ip2aTVABB9(StateChangedArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 6:
				IsSegmentDialogInteractableOnStartup = true;
				num = 7;
				break;
			case 4:
				if (!mm3rh4PqPWZgS8GpB9H(IHMKnDPQwMYg0WCgsj8(P_0), ToolId))
				{
					return;
				}
				BpCkWUPguEuH6GGeQBj();
				if (qpwKVtP4IkWdXpGprnu())
				{
					num = 1;
					break;
				}
				num = 0;
				if (qpwKVtP4IkWdXpGprnu())
				{
					break;
				}
				return;
			case 5:
				if (P_0 != null)
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto default;
				}
				return;
			default:
				O8NkdQPVSNSAMv6yRbD();
				num = 6;
				break;
			case 1:
			case 2:
				Validate();
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BQDalo9tbe()
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
			case 0:
				if (knGaMEH8jB != null)
				{
					qpwKVtP4IkWdXpGprnu();
					num = (BpCkWUPguEuH6GGeQBj() ? 5 : 4);
					break;
				}
				return;
			case 1:
			case 4:
				propertySheetArgViewModel = ((ArgumentGroupViewModel)zcJ73TPimhAlJt6ph3n(StandardPropertySheetViewModel)).Arguments.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PropertySheetArgViewModel arg) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)_003C_003Ec.lemuBYhhQrj2pyFs5GX(arg) == (string)_003C_003Ec.XIAxDqhULJ8KEZQh3qR(7764);
				});
				goto case 2;
			case 2:
			case 5:
				if (propertySheetArgViewModel != null)
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				break;
			case 3:
				YtWE2OPt6Sy0y2rDvoe(knGaMEH8jB, !BXtX49PLWITpDiHsS8Y(propertySheetArgViewModel));
				num = 6;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SegmentViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		QydaCmd2hZ = LogManager.GetLogger<SegmentViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task wYgaBZIgDB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)V3IgOsP9fDsIXdPtmor(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task gLXaeN8Z3Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)wfpXSnPvyPCRrsl7PMr(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task c5WatusMG3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)mkwUJePZQ310Yq5abIK(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l8UlKdP1I0xqLDiXG7g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pnsFyxPSgjPsKNRWrcW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CeqrBjP6bXIMsVlJIcF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid wLI6knPD7kwjDMqFZTF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Guid.NewGuid();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HmGaagP8HWRu6dUw2sF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cr4qnZPFoug11Jgul80(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QTN3B6PsWxCDenNfWMi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SegmenterClient.State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R7Pi9PPdtG04UsqI1u2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentProjectionParamsViewModel)P_0).ToolId = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S0LDB8PEPAp9TYOQj5Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentProjectionParamsViewModel)P_0).InitializeProjectionParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qpwKVtP4IkWdXpGprnu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BpCkWUPguEuH6GGeQBj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cFNUA8P5vQvynmL74wB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FgNEq1P3XLjpyYPtXNu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder rYjgpNPaLrAh4RaI0rH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O6DlMjPo5uFuWjHOoM3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).ClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uwZR5iPcSXEEJM5rIQt(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseCompletableViewModel)P_0).OnCompleted(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder Cq8e8cPuHl2sZKGWTyd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bh0BA2PBZB9cbSydDaW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).Function;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NSr9nxPxlZ0K7nYe4kC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentAdapterBase)P_0).OnNewResult((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vOnwxZPhxXRLaYQfm6w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vvUGnNPUbviMxef9jfL(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).ErrorException((string)P_1, (Exception)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IHMKnDPQwMYg0WCgsj8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mm3rh4PqPWZgS8GpB9H(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O8NkdQPVSNSAMv6yRbD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CommandManager.InvalidateRequerySuggested();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zcJ73TPimhAlJt6ph3n(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StandardPropertySheetViewModel)P_0).AllArgumentGroup;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BXtX49PLWITpDiHsS8Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetArgViewModel)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YtWE2OPt6Sy0y2rDvoe(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentProjectionParamsViewModel)P_0).EnableAutoTune = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V3IgOsP9fDsIXdPtmor(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).InitializeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wfpXSnPvyPCRrsl7PMr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).AcceptChangesAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mkwUJePZQ310Yq5abIK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).CancelChangesAsync();
	}
}
