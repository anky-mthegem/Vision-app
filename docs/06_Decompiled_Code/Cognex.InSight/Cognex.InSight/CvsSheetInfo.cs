using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsSheetInfo
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsSheetInfo _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cjjrPMsLIbp8W4qexSoo();
			int num;
			if (!SO8ejQsLR0NAK92yxdmC())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (!cjjrPMsLIbp8W4qexSoo())
				{
					return;
				}
			}
			CvsSheetInfo cvsSheetInfo = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					cvsSheetInfo = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							if (num2 == 0)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0118;
							}
							cvsSheetInfo.Reset();
							if (oHWieNsLnApEO8wHHCcZ(((CvsCogSocket)oMq9MNsLa24ajhBNTm0R(cvsSheetInfo.DClFCKSZRv)).Sheet))
							{
								object elKbPmCQog = cvsSheetInfo.ElKbPmCQog;
								bool lockTaken = false;
								try
								{
									Monitor.Enter(elKbPmCQog, ref lockTaken);
									cvsSheetInfo.GwmFzqUZ6b = ((CvsCogSocketSheet)TdaZc4sLGs7n8OrllsgR(cvsSheetInfo.DClFCKSZRv.CogSocket)).ID;
								}
								finally
								{
									if (num2 < 0 && lockTaken)
									{
										ONEToxsLXcRa2WTwhdJN(elKbPmCQog);
									}
								}
								awaiter = o55FG4sLbMAqIHEkUP7r(cvsSheetInfo.UpdateRowAndColumnSizes());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0118;
							}
							goto end_IL_0053;
							IL_0118:
							awaiter.GetResult();
							end_IL_0053:;
						}
						catch (Exception ex)
						{
							CvsTraceSDK.Error.TraceException(ex);
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object oMq9MNsLa24ajhBNTm0R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oHWieNsLnApEO8wHHCcZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).HasSheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TdaZc4sLGs7n8OrllsgR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ONEToxsLXcRa2WTwhdJN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter o55FG4sLbMAqIHEkUP7r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cjjrPMsLIbp8W4qexSoo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SO8ejQsLR0NAK92yxdmC()
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
	private struct _003CUpdateRowAndColumnSizes_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsSheetInfo _003C_003E4__this;

		private TaskAwaiter<(int[] rowHeights, int[] columnWidths)> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			CvsSheetInfo cvsSheetInfo = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!WfVUcGsL6AJcJexAyeuX()) ? 2 : 4);
					break;
				case 1:
				case 4:
					cvsSheetInfo = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (WfVUcGsL6AJcJexAyeuX())
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						int[] array;
						int[] array2;
						TaskAwaiter<(int[], int[])> awaiter;
						if (num2 != 0)
						{
							array = Array.Empty<int>();
							array2 = Array.Empty<int>();
							if (!BkZxBLsLkCGSTDsf5dG2(xpT1VDsL4uDfNCKjxprK(x0Ohq1sL0TNRwGWeceyu(cvsSheetInfo.DClFCKSZRv))))
							{
								goto IL_00fb;
							}
							awaiter = cvsSheetInfo.haMFr5gkyE().GetAwaiter();
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
						(array, array2) = awaiter.GetResult();
						goto IL_00fb;
						IL_00fb:
						object elKbPmCQog = cvsSheetInfo.ElKbPmCQog;
						bool lockTaken = false;
						try
						{
							Monitor.Enter(elKbPmCQog, ref lockTaken);
							cvsSheetInfo.nbqFepgjJU(array, array2);
						}
						finally
						{
							if (num2 < 0 && lockTaken)
							{
								fh9KZZsLfuDcUmtww2u0(elKbPmCQog);
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
		internal static object x0Ohq1sL0TNRwGWeceyu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xpT1VDsL4uDfNCKjxprK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BkZxBLsLkCGSTDsf5dG2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).HasSheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fh9KZZsLfuDcUmtww2u0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WfVUcGsL6AJcJexAyeuX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jIlojHsLpFdTwZES5sdR()
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
	private struct _003CUpdateCurrentCellInfoAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsSheetInfo _003C_003E4__this;

		public CvsCellLocation loc;

		private CvsCogEditInfo _003CeditInfo_003E5__2;

		private ConfiguredTaskAwaitable<CvsCogEditInfo>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private bool _003CeditingEnabled_003E5__3;

		private ConfiguredTaskAwaitable<CvsCogExpressionGraphic>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			CvsSheetInfo cvsSheetInfo = default;
			ConfiguredTaskAwaitable<CvsCogExpressionGraphic>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo>.ConfiguredTaskAwaiter awaiter2 = default;
			CvsCogExpressionGraphic result = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo> configuredTaskAwaitable2 = default;
			ConfiguredTaskAwaitable<CvsCogExpressionGraphic> configuredTaskAwaitable = default;
			CvsCogEditInfo result2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!oXlj1WsLFR66dgIdAi7e()) ? 5 : 4);
					continue;
				case 1:
				case 4:
					cvsSheetInfo = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
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
									num3 = 1;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 21;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num3 = 9;
							}
							while (true)
							{
								switch (num3)
								{
								case 4:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 12;
									if (oXlj1WsLFR66dgIdAi7e())
									{
										continue;
									}
									goto case 15;
								case 15:
									cvsSheetInfo.CurrentCellHasMaximizableGraphic = false;
									num3 = 24;
									continue;
								case 3:
									result = awaiter.GetResult();
									if (result != null)
									{
										num3 = 7;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									}
									goto case 19;
								case 1:
									configuredTaskAwaitable2 = ((CvsCogSocketSheet)GeOG3TsLy2v7gDRZLoh1(cvsSheetInfo.DClFCKSZRv.CogSocket)).GetDefaultGraphicAsync(loc).ConfigureAwait(continueOnCapturedContext: false);
									num3 = 5;
									continue;
								case 14:
									if (hhKugMsLgYYVNrqDW1YX(_003CeditInfo_003E5__2.EditingType, kgbOBx7BanbFa22Hp9.ol99ukmDA(13148)))
									{
										num3 = 17;
										continue;
									}
									goto IL_02a6;
								case 13:
									_003C_003Eu__2 = awaiter;
									num3 = 2;
									continue;
								case 23:
									return;
								case 10:
								case 22:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									goto case 18;
								default:
									num3 = 18;
									continue;
								case 8:
									return;
								case 6:
								case 20:
									num2 = (_003C_003E1__state = -1);
									goto IL_01e1;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									if (oXlj1WsLFR66dgIdAi7e())
									{
										continue;
									}
									goto case 11;
								case 11:
									_003CeditInfo_003E5__2 = result2;
									if (_003CeditInfo_003E5__2 != null)
									{
										num3 = 14;
										continue;
									}
									goto IL_02a6;
								case 5:
									awaiter2 = configuredTaskAwaitable2.GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num3 = 4;
										continue;
									}
									goto IL_01e1;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 23;
									if (!QIyPvqsLmIHjS49RaG7c())
									{
										continue;
									}
									goto case 18;
								case 18:
									if (!awaiter.IsCompleted)
									{
										num3 = 16;
										continue;
									}
									goto case 3;
								case 0:
									cvsSheetInfo.CurrentCellHasMaximizableGraphic = _003CeditingEnabled_003E5__3 && i1rfQxsLzK4c1eZqBByC(_003CeditInfo_003E5__2);
									break;
								case 21:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 17;
								case 17:
									_003CeditingEnabled_003E5__3 = jumVYosLZMjOyHSCYKj2(_003CeditInfo_003E5__2);
									configuredTaskAwaitable = ((CvsCogSocketSheet)GeOG3TsLy2v7gDRZLoh1(kJaUBxsLJ8k5ZoEhWKXZ(cvsSheetInfo.DClFCKSZRv))).GetExpressionGraphic(_003CeditInfo_003E5__2).ConfigureAwait(continueOnCapturedContext: false);
									goto case 10;
								case 19:
									cvsSheetInfo.CurrentCellHasGraphic = _003CeditingEnabled_003E5__3;
									num3 = 0;
									continue;
								case 7:
									_003CeditingEnabled_003E5__3 = XaopJvsL8fwJm0XpboV0(result);
									num3 = 19;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									oXlj1WsLFR66dgIdAi7e();
									if (QIyPvqsLmIHjS49RaG7c())
									{
										num3 = 22;
										if (true)
										{
											continue;
										}
										goto case 19;
									}
									num3 = 20;
									continue;
								case 16:
									num2 = (_003C_003E1__state = 1);
									num3 = 13;
									if (true)
									{
										continue;
									}
									break;
								case 24:
									break;
									IL_02a6:
									cvsSheetInfo.CurrentCellHasGraphic = false;
									num3 = 15;
									continue;
									IL_01e1:
									result2 = awaiter2.GetResult();
									num3 = 11;
									continue;
								}
								break;
							}
							_003CeditInfo_003E5__2 = null;
						}
						catch (Exception ex)
						{
							oR075Bs9ws4RJ4SpM6Pn(CvsTraceSDK.Error, ex);
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
					num = 0;
					continue;
				case 0:
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
		internal static object GeOG3TsLy2v7gDRZLoh1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hhKugMsLgYYVNrqDW1YX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jumVYosLZMjOyHSCYKj2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).IsEditableGraphic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kJaUBxsLJ8k5ZoEhWKXZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XaopJvsL8fwJm0XpboV0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogExpressionGraphic)P_0).EditingEnabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i1rfQxsLzK4c1eZqBByC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).IsMaximizableGraphic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oR075Bs9ws4RJ4SpM6Pn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oXlj1WsLFR66dgIdAi7e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QIyPvqsLmIHjS49RaG7c()
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
	private struct _003CSetRowHeights_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int[] rowHeights;

		public CvsCellRange activeRange;

		public CvsSheetInfo _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsSheetInfo cvsSheetInfo = default;
			int num2 = default;
			int[] rowHeightsAsync = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					cvsSheetInfo = _003C_003E4__this;
					DsueAts9s3NMtGCk9lvk();
					if (!romOy5s9hvxhDILVwGlJ())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 0;
					}
					num = 5;
					break;
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							if (rowHeights == null)
							{
								throw new ArgumentNullException();
							}
							if (activeRange.Row < 0 || activeRange.Rows < 0)
							{
								throw new ArgumentOutOfRangeException((string)fHHwTFs9L6r8rpZVcL8Q(7410));
							}
							object elKbPmCQog = cvsSheetInfo.ElKbPmCQog;
							bool lockTaken = false;
							try
							{
								Monitor.Enter(elKbPmCQog, ref lockTaken);
								_ = 0;
								int num3;
								if (DsueAts9s3NMtGCk9lvk())
								{
									num3 = 2;
									if (romOy5s9hvxhDILVwGlJ())
									{
										goto IL_00c7;
									}
								}
								else
								{
									num3 = 3;
									if (false)
									{
										goto IL_012a;
									}
								}
								goto IL_00ff;
								IL_00ff:
								switch (num3)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_012a;
								case 4:
									rowHeightsAsync = cvsSheetInfo.QdZFZG1ldB.ToArray();
									goto end_IL_00a3;
								}
								goto IL_00c7;
								IL_012a:
								ayMTr1s9S7m7t51qCix2(rowHeights, 0, cvsSheetInfo.QdZFZG1ldB, activeRange.Row, num4);
								num3 = 4;
								goto IL_00ff;
								IL_00c7:
								num4 = yHStTWs99B1CAyckDsoL(cvsSheetInfo.QdZFZG1ldB.Length - activeRange.Row, activeRange.Rows);
								goto IL_012a;
								end_IL_00a3:;
							}
							finally
							{
								if (num2 < 0 && lockTaken)
								{
									MrJ0Scs9EKuWvnDDQF6H(elKbPmCQog);
								}
							}
						}
						try
						{
							TaskAwaiter awaiter;
							int num5;
							if (num2 != 0)
							{
								awaiter = KBRLWZs9Hf75e41n96V2(((CvsCogSocketSheet)wGBPycs9vLYqmFwXxd6h(cvsSheetInfo.DClFCKSZRv.CogSocket)).SetRowHeightsAsync(rowHeightsAsync));
								num5 = 0;
								if (1 == 0)
								{
									goto IL_01a9;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num5 = 4;
							}
							goto IL_025c;
							IL_025c:
							while (true)
							{
								switch (num5)
								{
								case 5:
									break;
								case 4:
									_003C_003Eu__1 = default;
									goto case 3;
								case 1:
								case 8:
									num2 = (_003C_003E1__state = 0);
									num5 = 5;
									continue;
								case 2:
									return;
								case 3:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num5 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
									if (!awaiter.IsCompleted)
									{
										romOy5s9hvxhDILVwGlJ();
										num5 = (DsueAts9s3NMtGCk9lvk() ? 8 : 3);
										continue;
									}
									goto case 7;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num5 = 2;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									awaiter.GetResult();
									num5 = 10;
									if (!romOy5s9hvxhDILVwGlJ())
									{
										continue;
									}
									goto case 10;
								case 10:
									cvsSheetInfo.DClFCKSZRv.MakeNewResult(updateExposedResults: false, runSheet: true);
									goto end_IL_025c;
								}
								goto IL_01a9;
								continue;
								end_IL_025c:
								break;
							}
							goto end_IL_017a;
							IL_01a9:
							_003C_003Eu__1 = awaiter;
							num5 = 9;
							goto IL_025c;
							end_IL_017a:;
						}
						catch (Exception ex)
						{
							RfQKZ6s9VfF9G1JQKHl9(CvsTraceSDK.Error, ex);
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
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object fHHwTFs9L6r8rpZVcL8Q(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int yHStTWs99B1CAyckDsoL(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Min(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ayMTr1s9S7m7t51qCix2(object P_0, int P_1, object P_2, int P_3, int P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MrJ0Scs9EKuWvnDDQF6H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wGBPycs9vLYqmFwXxd6h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KBRLWZs9Hf75e41n96V2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RfQKZ6s9VfF9G1JQKHl9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DsueAts9s3NMtGCk9lvk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool romOy5s9hvxhDILVwGlJ()
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
	private struct _003CSetColumnWidths_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int[] columnWidths;

		public CvsCellRange activeRange;

		public CvsSheetInfo _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			CvsSheetInfo cvsSheetInfo = default;
			int num2 = default;
			int num4 = default;
			int[] array = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					cvsSheetInfo = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					FQccwvs9AWea0UvecAVr();
					num = ((!TdF3eFs9D7OPUV3ISRGx()) ? 5 : 4);
					break;
				case 2:
				case 4:
					try
					{
						if (num2 != 0)
						{
							if (columnWidths == null)
							{
								throw new ArgumentNullException();
							}
							if (activeRange.Column < 0 || activeRange.Columns < 0)
							{
								throw new ArgumentOutOfRangeException((string)N9HIG1s9UjNGU03wfujH(7410));
							}
							object elKbPmCQog = cvsSheetInfo.ElKbPmCQog;
							bool lockTaken = false;
							try
							{
								Monitor.Enter(elKbPmCQog, ref lockTaken);
								FQccwvs9AWea0UvecAVr();
								int num3 = (TdF3eFs9D7OPUV3ISRGx() ? 2 : 3);
								while (true)
								{
									switch (num3)
									{
									case 0:
									case 3:
										num4 = EoMUlGs9TPaklU7br8MV(cvsSheetInfo.QOuF82JoYg.Length - activeRange.Column, activeRange.Columns);
										break;
									case 4:
										array = cvsSheetInfo.QOuF82JoYg.ToArray();
										goto end_IL_013b;
									}
									kTZd7fs9dYtmkfdVKKjn(columnWidths, 0, cvsSheetInfo.QOuF82JoYg, activeRange.Column, num4);
									num3 = 4;
									continue;
									end_IL_013b:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && lockTaken)
								{
									FsSYuLs9iv1wX38PSiB6(elKbPmCQog);
								}
							}
						}
						try
						{
							TaskAwaiter awaiter;
							int num5;
							if (num2 != 0)
							{
								awaiter = ((Task)Tybwhts9jte9vUcjglHC(sVp5DMs9BHqjQ7skM7sc(c4qKc0s9qbQ7D4tOdAKX(cvsSheetInfo.DClFCKSZRv)), array)).GetAwaiter();
								num5 = 5;
								if (!FQccwvs9AWea0UvecAVr())
								{
									goto IL_01be;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num5 = 4;
								if (TdF3eFs9D7OPUV3ISRGx())
								{
								}
							}
							goto IL_027d;
							IL_027d:
							while (true)
							{
								switch (num5)
								{
								case 4:
									break;
								case 0:
									num2 = (_003C_003E1__state = -1);
									goto case 1;
								case 6:
									do
									{
										_003C_003Eu__1 = awaiter;
										TdF3eFs9D7OPUV3ISRGx();
										if (!FQccwvs9AWea0UvecAVr())
										{
											num5 = 1;
											continue;
										}
										num5 = 8;
										break;
									}
									while (false);
									continue;
								case 9:
									return;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num5 = 2;
										continue;
									}
									goto case 1;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num5 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num5 = 9;
									continue;
								case 1:
								case 7:
									awaiter.GetResult();
									num5 = 10;
									continue;
								case 10:
									cvsSheetInfo.DClFCKSZRv.MakeNewResult(updateExposedResults: false, runSheet: true);
									goto end_IL_027d;
								}
								goto IL_01be;
								continue;
								end_IL_027d:
								break;
							}
							goto end_IL_018b;
							IL_01be:
							_003C_003Eu__1 = default;
							num5 = 0;
							goto IL_027d;
							end_IL_018b:;
						}
						catch (Exception ex)
						{
							IN7XHJs9cLeXsU6a98se(CvsTraceSDK.Error, ex);
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
		internal static object N9HIG1s9UjNGU03wfujH(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EoMUlGs9TPaklU7br8MV(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Min(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kTZd7fs9dYtmkfdVKKjn(object P_0, int P_1, object P_2, int P_3, int P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FsSYuLs9iv1wX38PSiB6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c4qKc0s9qbQ7D4tOdAKX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sVp5DMs9BHqjQ7skM7sc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Tybwhts9jte9vUcjglHC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).SetColumnWidthsAsync((int[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IN7XHJs9cLeXsU6a98se(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FQccwvs9AWea0UvecAVr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TdF3eFs9D7OPUV3ISRGx()
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
	private struct _003CSetDefaultRowColSize_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange activeRange;

		public CvsSheetInfo _003C_003E4__this;

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
			CvsSheetInfo cvsSheetInfo = default;
			TaskAwaiter awaiter = default;
			int[] array = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					FimoWvs9WMLuGncOJmUX();
					if (ka7kpas929vMAcyZqp7X())
					{
						num = 3;
						if (ka7kpas929vMAcyZqp7X())
						{
							continue;
						}
						goto case 1;
					}
					num = 0;
					continue;
				case 1:
				case 3:
					cvsSheetInfo = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 0;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 16;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 2;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 15:
								awaiter = ogwiZks97DXAgMBPT6w5(cvsSheetInfo.SetColumnWidths(activeRange, array));
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!ka7kpas929vMAcyZqp7X()) ? 9 : 11);
									continue;
								}
								goto default;
							default:
								awaiter.GetResult();
								num3 = 4;
								continue;
							case 6:
								return;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 17;
								continue;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								break;
							case 2:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 3:
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 1);
								num3 = 5;
								continue;
							case 4:
							{
								int[] array2 = new int[activeRange.Rows];
								array2.Fill(20);
								awaiter = ogwiZks97DXAgMBPT6w5(cvsSheetInfo.SetRowHeights(activeRange, array2));
								num3 = 13;
								continue;
							}
							case 1:
								array.Fill(64);
								num3 = 15;
								continue;
							case 17:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								if (!FimoWvs9WMLuGncOJmUX())
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto default;
							case 0:
								array = new int[activeRange.Columns];
								num3 = 1;
								continue;
							case 18:
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
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (FimoWvs9WMLuGncOJmUX())
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
		internal static TaskAwaiter ogwiZks97DXAgMBPT6w5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ka7kpas929vMAcyZqp7X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FimoWvs9WMLuGncOJmUX()
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
	private struct _003CGetColumnAndRowSizesAsync_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(int[] rowHeights, int[] columnWidths)> _003C_003Et__builder;

		public CvsSheetInfo _003C_003E4__this;

		private int[] _003CrowHeights_003E5__2;

		private TaskAwaiter<int[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cWoQyms9t959CCv9SyDg();
			int num = ((!hHNVcys9CbSJeh9r3LeD()) ? 1 : 5);
			(int[], int[]) result = default;
			CvsSheetInfo cvsSheetInfo = default;
			int num2 = default;
			TaskAwaiter<int[]> awaiter = default;
			int[] result3 = default;
			int[] result2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 4:
					cvsSheetInfo = _003C_003E4__this;
					goto case 2;
				case 3:
					_003CrowHeights_003E5__2 = null;
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 13;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 5;
								if (hHNVcys9CbSJeh9r3LeD())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (!hHNVcys9CbSJeh9r3LeD())
								{
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								}
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003CrowHeights_003E5__2 = result3;
								goto case 15;
							default:
								num3 = 15;
								continue;
							case 7:
							case 14:
								result2 = awaiter.GetResult();
								num3 = 17;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 1);
								num3 = 8;
								continue;
							case 13:
								awaiter = ((CvsCogSocketSheet)pCP3oqs95CXe3tadTcSL(t3vBIas9K1L3IuCM5RMJ(cvsSheetInfo.DClFCKSZRv))).GetRowHeightsAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									if (cWoQyms9t959CCv9SyDg())
									{
										continue;
									}
									return;
								}
								goto case 16;
							case 6:
								return;
							case 15:
								awaiter = ((CvsCogSocket)t3vBIas9K1L3IuCM5RMJ(cvsSheetInfo.DClFCKSZRv)).Sheet.GetColumnWidthsAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto case 7;
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 11;
								if (cWoQyms9t959CCv9SyDg())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 16:
								result3 = awaiter.GetResult();
								num3 = 0;
								continue;
							case 17:
								result = (_003CrowHeights_003E5__2, result2);
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CrowHeights_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 7:
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
		internal static object t3vBIas9K1L3IuCM5RMJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pCP3oqs95CXe3tadTcSL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cWoQyms9t959CCv9SyDg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hHNVcys9CbSJeh9r3LeD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int DefaultRowPixels = 20;

	public const int DefaultColumnPixels = 64;

	private CvsInSight DClFCKSZRv;

	private CvsCellLocation Pj7F2iHEI5;

	private bool A5GFyoMxRY;

	private bool F6xFV7WFcy;

	private CvsCellLocation YQeFvFMQm0;

	private int[] QdZFZG1ldB;

	private int[] QOuF82JoYg;

	private string GwmFzqUZ6b;

	private object ElKbPmCQog;

	public string SheetID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GwmFzqUZ6b;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t5M2AdVbPERvqfyle2r();
			int num = ((!BfBrgVVXmawC9BxqmGP()) ? 3 : 2);
			bool lockTaken = default;
			object elKbPmCQog = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_0055;
				case 0:
				case 2:
					elKbPmCQog = ElKbPmCQog;
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_0055:
				num = 4;
			}
			try
			{
				Monitor.Enter(elKbPmCQog, ref lockTaken);
				GwmFzqUZ6b = value;
			}
			finally
			{
				if (lockTaken)
				{
					mtysL8VFKvGnWXiqBHN(elKbPmCQog);
				}
			}
		}
	}

	public CvsCellLocation CurrentCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Pj7F2iHEI5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t5M2AdVbPERvqfyle2r();
			int num = ((!BfBrgVVXmawC9BxqmGP()) ? 3 : 2);
			object elKbPmCQog = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					elKbPmCQog = ElKbPmCQog;
					goto case 1;
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_006c;
				case 4:
					break;
				}
				break;
				IL_006c:
				num = 4;
			}
			try
			{
				Monitor.Enter(elKbPmCQog, ref lockTaken);
				Pj7F2iHEI5 = value;
			}
			finally
			{
				if (lockTaken)
				{
					mtysL8VFKvGnWXiqBHN(elKbPmCQog);
				}
			}
		}
	}

	public bool CurrentCellHasGraphic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return A5GFyoMxRY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (BfBrgVVXmawC9BxqmGP())
			{
				num = 3;
				if (t5M2AdVbPERvqfyle2r())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0043;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_0043;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_007a;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			object elKbPmCQog = ElKbPmCQog;
			goto IL_0043;
			IL_0043:
			bool lockTaken = false;
			goto IL_007a;
			IL_007a:
			try
			{
				Monitor.Enter(elKbPmCQog, ref lockTaken);
				A5GFyoMxRY = value;
			}
			finally
			{
				if (lockTaken)
				{
					mtysL8VFKvGnWXiqBHN(elKbPmCQog);
				}
			}
		}
	}

	public bool CurrentCellHasMaximizableGraphic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F6xFV7WFcy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BfBrgVVXmawC9BxqmGP();
			int num;
			if (!t5M2AdVbPERvqfyle2r())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0041;
				}
			}
			object elKbPmCQog = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					elKbPmCQog = ElKbPmCQog;
					break;
				case 1:
				case 2:
					break;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					goto IL_007a;
				case 4:
					goto IL_007a;
				}
				break;
			}
			goto IL_0041;
			IL_007a:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(elKbPmCQog, ref lockTaken);
				F6xFV7WFcy = value;
				return;
			}
			finally
			{
				if (lockTaken)
				{
					mtysL8VFKvGnWXiqBHN(elKbPmCQog);
				}
			}
			IL_0041:
			lockTaken = false;
			goto IL_007a;
		}
	}

	public CvsCellLocation FirstVisibleCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YQeFvFMQm0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t5M2AdVbPERvqfyle2r();
			int num;
			if (BfBrgVVXmawC9BxqmGP())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0041;
				}
			}
			object elKbPmCQog = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					elKbPmCQog = ElKbPmCQog;
					break;
				case 1:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_0078;
				}
				break;
			}
			goto IL_0041;
			IL_0078:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(elKbPmCQog, ref lockTaken);
				YQeFvFMQm0 = value;
				return;
			}
			finally
			{
				if (lockTaken)
				{
					mtysL8VFKvGnWXiqBHN(elKbPmCQog);
				}
			}
			IL_0041:
			lockTaken = false;
			goto IL_0078;
		}
	}

	public int[] RowHeights
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QdZFZG1ldB;
		}
	}

	public int[] ColWidths
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QOuF82JoYg;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsSheetInfo(CvsInSight inSight)
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
		goto IL_00b9;
		IL_001a:
		A5GFyoMxRY = false;
		num = 3;
		goto IL_00b9;
		IL_00b9:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 11:
				QOuF82JoYg = new int[0];
				num = 7;
				if (!t5M2AdVbPERvqfyle2r())
				{
					continue;
				}
				goto case 4;
			case 4:
			case 5:
				ElKbPmCQog = new object();
				num = 1;
				continue;
			case 10:
				Pj7F2iHEI5 = new CvsCellLocation((string)oqTlu5VpcLvxukZhXAD(7402));
				YQeFvFMQm0 = new CvsCellLocation((string)oqTlu5VpcLvxukZhXAD(7402));
				num = 2;
				continue;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				ckPu2QV6qMlCPX1qJ8F(this);
				goto default;
			case 3:
				F6xFV7WFcy = false;
				num = 12;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				DClFCKSZRv = inSight;
				num = 10;
				if (t5M2AdVbPERvqfyle2r())
				{
				}
				continue;
			case 9:
				QdZFZG1ldB = new int[0];
				num = 11;
				if (!t5M2AdVbPERvqfyle2r())
				{
					continue;
				}
				goto case 7;
			case 7:
				GwmFzqUZ6b = "";
				_ = 0;
				if (!BfBrgVVXmawC9BxqmGP())
				{
					num = 8;
					continue;
				}
				num = 5;
				if (t5M2AdVbPERvqfyle2r())
				{
					return;
				}
				continue;
			case 12:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsSheetInfo Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t5M2AdVbPERvqfyle2r();
		int num;
		if (BfBrgVVXmawC9BxqmGP())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0067;
		IL_002a:
		bool lockTaken = false;
		num = 5;
		goto IL_0067;
		IL_0067:
		CvsSheetInfo cvsSheetInfo = default;
		object elKbPmCQog = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				cvsSheetInfo = new CvsSheetInfo(DClFCKSZRv);
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				elKbPmCQog = ElKbPmCQog;
				break;
			case 5:
				try
				{
					Monitor.Enter(elKbPmCQog, ref lockTaken);
					_ = 0;
					int num2;
					if (BfBrgVVXmawC9BxqmGP())
					{
						num2 = 7;
						if (false)
						{
							goto IL_00b4;
						}
					}
					else
					{
						num2 = 4;
					}
					goto IL_00e8;
					IL_00e8:
					while (true)
					{
						switch (num2)
						{
						case 0:
						case 7:
							break;
						case 1:
							cHXLBWVk7e0t2wuucLQ(cvsSheetInfo, F6xFV7WFcy);
							goto default;
						default:
							h1jwyjVfuHwc807URGf(cvsSheetInfo, YQeFvFMQm0);
							num2 = 5;
							continue;
						case 6:
							dwcuHZV4Bf9mNiScKBf(cvsSheetInfo, A5GFyoMxRY);
							num2 = 1;
							if (BfBrgVVXmawC9BxqmGP())
							{
								continue;
							}
							goto case 2;
						case 2:
							cvsSheetInfo.QdZFZG1ldB = (int[])QdZFZG1ldB.Clone();
							num2 = 8;
							continue;
						case 5:
							cvsSheetInfo.QOuF82JoYg = (int[])QOuF82JoYg.Clone();
							num2 = 2;
							continue;
						case 8:
							cvsSheetInfo.SheetID = GwmFzqUZ6b;
							return cvsSheetInfo;
						}
						break;
					}
					goto IL_00b4;
					IL_00b4:
					HqdmCoV0khJJqseoe3M(cvsSheetInfo, Pj7F2iHEI5);
					num2 = 6;
					goto IL_00e8;
				}
				finally
				{
					if (lockTaken)
					{
						mtysL8VFKvGnWXiqBHN(elKbPmCQog);
					}
				}
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!t5M2AdVbPERvqfyle2r())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_003d;
			}
		}
		object elKbPmCQog = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				elKbPmCQog = ElKbPmCQog;
				break;
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0074;
			}
			break;
		}
		goto IL_003d;
		IL_0074:
		bool lockTaken = default;
		try
		{
			Monitor.Enter(elKbPmCQog, ref lockTaken);
			_ = 0;
			switch ((!BfBrgVVXmawC9BxqmGP()) ? 3 : 2)
			{
			case 0:
			case 2:
				GwmFzqUZ6b = "";
				break;
			}
			K2nFDVV8RI();
			return;
		}
		finally
		{
			if (lockTaken)
			{
				mtysL8VFKvGnWXiqBHN(elKbPmCQog);
			}
		}
		IL_003d:
		lockTaken = false;
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__19))]
	public Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CInitializeAsync_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				t5M2AdVbPERvqfyle2r();
				if (BfBrgVVXmawC9BxqmGP())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (BfBrgVVXmawC9BxqmGP())
				{
					continue;
				}
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				num = 0;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
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
	[AsyncStateMachine(typeof(_003CUpdateRowAndColumnSizes_003Ed__20))]
	public Task UpdateRowAndColumnSizes()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0084;
		IL_001a:
		_003CUpdateRowAndColumnSizes_003Ed__20 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0084;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				BfBrgVVXmawC9BxqmGP();
				num = (t5M2AdVbPERvqfyle2r() ? 4 : 0);
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
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
	public void SetCurrentAndFirstVisibleCell(CvsCellLocation loc, CvsCellLocation firstVisibleLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t5M2AdVbPERvqfyle2r();
		int num;
		if (BfBrgVVXmawC9BxqmGP())
		{
			num = 1;
			if (false)
			{
				goto IL_010b;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_00cc;
		IL_009d:
		object obj;
		if (obj != null)
		{
			mQB8IiVZ7FTtOCfANRx(UpdateCurrentCellInfoAsync(loc));
			num = 4;
			if (t5M2AdVbPERvqfyle2r())
			{
				goto IL_004b;
			}
		}
		else
		{
			CurrentCellHasGraphic = false;
			num = 8;
		}
		goto IL_00cc;
		IL_004b:
		FirstVisibleCell = firstVisibleLoc;
		num = 2;
		goto IL_00cc;
		IL_0128:
		CvsInSight dClFCKSZRv;
		CvsResultSet results = dClFCKSZRv.Results;
		if (results != null)
		{
			obj = SWtWaEVg8211XlWmVqJ(results.Cells, loc);
			goto IL_009d;
		}
		goto IL_008c;
		IL_00cc:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 2:
				DClFCKSZRv.MakeNewResult(updateExposedResults: true);
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				dClFCKSZRv = DClFCKSZRv;
				if (dClFCKSZRv == null)
				{
					num = 10;
					continue;
				}
				goto IL_0128;
			case 3:
			case 5:
				goto IL_008c;
			case 8:
				CurrentCellHasMaximizableGraphic = false;
				goto IL_010b;
			default:
				num = 9;
				continue;
			case 4:
			case 9:
				goto IL_010b;
			case 10:
				goto IL_0122;
			case 0:
			case 1:
				if (TEIDyuVy2U3IylFfaJ7(CurrentCell, loc))
				{
					num = 7;
					continue;
				}
				goto IL_010b;
			case 11:
				return;
			}
			break;
		}
		goto IL_004b;
		IL_008c:
		obj = null;
		goto IL_009d;
		IL_010b:
		CurrentCell = loc;
		num = 6;
		if (BfBrgVVXmawC9BxqmGP())
		{
			goto IL_00cc;
		}
		goto IL_0122;
		IL_0122:
		obj = null;
		goto IL_009d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateCurrentCellInfoAsync_003Ed__37))]
	public Task UpdateCurrentCellInfoAsync(CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUpdateCurrentCellInfoAsync_003Ed__37 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				t5M2AdVbPERvqfyle2r();
				num = (BfBrgVVXmawC9BxqmGP() ? 4 : 0);
				break;
			case 2:
				stateMachine.loc = loc;
				goto default;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[] GetRowHeights(CvsCellRange activeRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		bool lockTaken = default;
		object elKbPmCQog = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				throw new ArgumentOutOfRangeException((string)oqTlu5VpcLvxukZhXAD(7410));
			default:
				lockTaken = false;
				num = 6;
				break;
			case 5:
				if (activeRange.Rows >= 0)
				{
					elKbPmCQog = ElKbPmCQog;
					goto default;
				}
				_ = 0;
				num = (BfBrgVVXmawC9BxqmGP() ? 1 : 4);
				break;
			case 0:
				if (activeRange.Row >= 0)
				{
					num = 5;
					break;
				}
				goto case 1;
			case 6:
				try
				{
					Monitor.Enter(elKbPmCQog, ref lockTaken);
					return HKCFGXsJrj(QdZFZG1ldB, activeRange.Row, activeRange.Rows, 20);
				}
				finally
				{
					if (lockTaken)
					{
						mtysL8VFKvGnWXiqBHN(elKbPmCQog);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetRowHeights_003Ed__43))]
	public Task SetRowHeights(CvsCellRange activeRange, int[] rowHeights)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSetRowHeights_003Ed__43 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				stateMachine.activeRange = activeRange;
				num = 1;
				break;
			case 0:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				num = 5;
				break;
			case 1:
				stateMachine.rowHeights = rowHeights;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				BfBrgVVXmawC9BxqmGP();
				if (t5M2AdVbPERvqfyle2r())
				{
					num = 3;
					break;
				}
				num = 7;
				if (BfBrgVVXmawC9BxqmGP())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int[] GetColumnWidths(CvsCellRange activeRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (t5M2AdVbPERvqfyle2r() ? 3 : 5);
		object elKbPmCQog = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (activeRange.Column >= 0)
				{
					num = 4;
					break;
				}
				goto case 2;
			case 4:
				if (activeRange.Columns < 0)
				{
					goto case 2;
				}
				elKbPmCQog = ElKbPmCQog;
				goto case 1;
			case 2:
			case 3:
				throw new ArgumentOutOfRangeException((string)oqTlu5VpcLvxukZhXAD(7410));
			default:
				num = 1;
				break;
			case 1:
				lockTaken = false;
				num = 6;
				break;
			case 6:
				try
				{
					Monitor.Enter(elKbPmCQog, ref lockTaken);
					return HKCFGXsJrj(QOuF82JoYg, activeRange.Column, activeRange.Columns, 64);
				}
				finally
				{
					if (lockTaken)
					{
						mtysL8VFKvGnWXiqBHN(elKbPmCQog);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColumnWidths_003Ed__45))]
	public Task SetColumnWidths(CvsCellRange activeRange, int[] columnWidths)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CSetColumnWidths_003Ed__45 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				num = 2;
				continue;
			case 7:
				stateMachine.columnWidths = columnWidths;
				goto default;
			default:
				_ = 0;
				num = (BfBrgVVXmawC9BxqmGP() ? 6 : 0);
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!t5M2AdVbPERvqfyle2r())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 3:
				stateMachine.activeRange = activeRange;
				num = 7;
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
	[AsyncStateMachine(typeof(_003CSetDefaultRowColSize_003Ed__46))]
	public Task SetDefaultRowColSize(CvsCellRange activeRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!t5M2AdVbPERvqfyle2r())
		{
			num = 5;
			if (t5M2AdVbPERvqfyle2r())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_00a0;
		IL_003e:
		_003CSetDefaultRowColSize_003Ed__46 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_00a0;
		IL_00a0:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 4:
				goto IL_003e;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = CQ3ILeVmnXHpUaXdEIe();
				break;
			case 6:
				stateMachine.activeRange = activeRange;
				goto case 2;
			default:
				num = 2;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		num = 6;
		if (false)
		{
			goto IL_003e;
		}
		goto IL_00a0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int[] HKCFGXsJrj(IList<int> P_0, int P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int count = P_0.Count - (P_1 + P_2);
		IEnumerable<int> second = Enumerable.Repeat(P_3, count);
		return P_0.Skip(P_1).Take(P_2).Concat(second)
			.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K2nFDVV8RI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (t5M2AdVbPERvqfyle2r())
		{
			goto IL_001e;
		}
		goto IL_0083;
		IL_001e:
		int? num2 = null;
		num = 12;
		goto IL_0083;
		IL_0083:
		int num8 = default;
		int num5 = default;
		while (true)
		{
			int? num7;
			int? num4;
			int num3;
			int num6;
			CvsInSight dClFCKSZRv2;
			int? num9;
			switch (num)
			{
			case 5:
				break;
			case 7:
				num7 = num2;
				goto IL_0040;
			case 8:
				num2 = null;
				goto case 2;
			default:
				num = 2;
				continue;
			case 2:
				num7 = num2;
				goto IL_0040;
			case 1:
			{
				CvsInSight dClFCKSZRv = DClFCKSZRv;
				if (dClFCKSZRv == null)
				{
					num = 5;
					continue;
				}
				CvsProcessorConstants processorConstants = dClFCKSZRv.ProcessorConstants;
				if (processorConstants != null)
				{
					num4 = processorConstants.SpreadsheetTotalRows;
					goto IL_0132;
				}
				num = 4;
				continue;
			}
			case 10:
			case 11:
				QOuF82JoYg = (int[])l3NyP0VJI3AruJUrTkZ(Array.Empty<int>(), num8, 64);
				num = 13;
				continue;
			case 4:
				num2 = null;
				num4 = num2;
				goto IL_0132;
			case 6:
				num2 = null;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 12;
			case 12:
				num4 = num2;
				goto IL_0132;
			case 3:
			case 9:
				num3 = 26;
				goto IL_0187;
			case 0:
				num6 = 600;
				goto IL_01c2;
			case 13:
				return;
				IL_01c2:
				num5 = num6;
				dClFCKSZRv2 = DClFCKSZRv;
				if (dClFCKSZRv2 != null)
				{
					CvsProcessorConstants processorConstants2 = dClFCKSZRv2.ProcessorConstants;
					if (processorConstants2 != null)
					{
						num7 = processorConstants2.SpreadsheetColumns;
						goto IL_0040;
					}
					num = 6;
					continue;
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				return;
				IL_0132:
				num9 = num4;
				if (!num9.HasValue)
				{
					num = 0;
					continue;
				}
				num6 = num9.GetValueOrDefault();
				goto IL_01c2;
				IL_0187:
				num8 = num3;
				QdZFZG1ldB = (int[])l3NyP0VJI3AruJUrTkZ(Array.Empty<int>(), num5, 20);
				goto case 10;
				IL_0040:
				num9 = num7;
				if (!num9.HasValue)
				{
					_ = 0;
					if (BfBrgVVXmawC9BxqmGP())
					{
						num = 3;
						if (BfBrgVVXmawC9BxqmGP())
						{
							continue;
						}
						goto case 8;
					}
					num = 11;
					if (BfBrgVVXmawC9BxqmGP())
					{
						continue;
					}
					goto case 0;
				}
				num3 = num9.GetValueOrDefault();
				goto IL_0187;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nbqFepgjJU(int[] P_0, int[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		int? num2 = default;
		while (true)
		{
			int? num3;
			int num5;
			int? num4;
			int? num6;
			int num7;
			int num8;
			switch (num)
			{
			case 1:
			case 12:
			{
				CvsInSight dClFCKSZRv2 = DClFCKSZRv;
				if (dClFCKSZRv2 == null)
				{
					num = 5;
					break;
				}
				CvsProcessorConstants processorConstants2 = dClFCKSZRv2.ProcessorConstants;
				if (processorConstants2 != null)
				{
					num3 = processorConstants2.SpreadsheetTotalRows;
					goto IL_00cc;
				}
				num = 4;
				if (1 == 0)
				{
					return;
				}
				break;
			}
			case 2:
				if (P_0 != null)
				{
					BfBrgVVXmawC9BxqmGP();
					if (t5M2AdVbPERvqfyle2r())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 10;
					}
					num = 12;
					if (true)
					{
						break;
					}
				}
				goto case 11;
			case 11:
				if (P_1 != null)
				{
					goto case 6;
				}
				return;
			default:
				num = 6;
				break;
			case 4:
				num2 = null;
				num3 = num2;
				goto IL_00cc;
			case 9:
				num2 = null;
				num = 10;
				break;
			case 8:
				num5 = 600;
				goto IL_0108;
			case 6:
			{
				CvsInSight dClFCKSZRv = DClFCKSZRv;
				if (dClFCKSZRv == null)
				{
					num = 13;
					break;
				}
				CvsProcessorConstants processorConstants = dClFCKSZRv.ProcessorConstants;
				if (processorConstants == null)
				{
					num = 9;
					if (BfBrgVVXmawC9BxqmGP())
					{
						break;
					}
					goto case 13;
				}
				num4 = processorConstants.SpreadsheetColumns;
				goto IL_0199;
			}
			case 7:
				num4 = num2;
				goto IL_0199;
			case 13:
				num2 = null;
				num = 7;
				break;
			case 5:
				num2 = null;
				goto case 0;
			case 10:
				num4 = num2;
				goto IL_0199;
			case 0:
			case 3:
				num3 = num2;
				goto IL_00cc;
			case 14:
				return;
				IL_00cc:
				num6 = num3;
				if (!num6.HasValue)
				{
					num = 8;
					if (true)
					{
						break;
					}
					goto case 9;
				}
				num5 = num6.GetValueOrDefault();
				goto IL_0108;
				IL_0199:
				num7 = num4 ?? 26;
				QOuF82JoYg = A2kFSMW38v(P_1, num7, 64);
				num = 14;
				break;
				IL_0108:
				num8 = num5;
				QdZFZG1ldB = (int[])l3NyP0VJI3AruJUrTkZ(P_0, num8, 20);
				num = 11;
				if (true)
				{
					break;
				}
				goto case 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int[] A2kFSMW38v(int[] P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int count = tAE6s6V8TygjlhBrA1p(0, P_1 - P_0.Length);
		IEnumerable<int> second = Enumerable.Repeat(P_2, count);
		return P_0.Take(P_1).Concat(second).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetColumnAndRowSizesAsync_003Ed__51))]
	private Task<(int[] rowHeights, int[] columnWidths)> haMFr5gkyE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetColumnAndRowSizesAsync_003Ed__51 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(int[], int[])>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ckPu2QV6qMlCPX1qJ8F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oqTlu5VpcLvxukZhXAD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BfBrgVVXmawC9BxqmGP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t5M2AdVbPERvqfyle2r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HqdmCoV0khJJqseoe3M(object P_0, CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSheetInfo)P_0).CurrentCell = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dwcuHZV4Bf9mNiScKBf(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSheetInfo)P_0).CurrentCellHasGraphic = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cHXLBWVk7e0t2wuucLQ(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSheetInfo)P_0).CurrentCellHasMaximizableGraphic = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h1jwyjVfuHwc807URGf(object P_0, CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSheetInfo)P_0).FirstVisibleCell = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mtysL8VFKvGnWXiqBHN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder CQ3ILeVmnXHpUaXdEIe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TEIDyuVy2U3IylFfaJ7(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left != right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SWtWaEVg8211XlWmVqJ(object P_0, CvsCellLocation cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[cell];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mQB8IiVZ7FTtOCfANRx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l3NyP0VJI3AruJUrTkZ(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return A2kFSMW38v((int[])P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tAE6s6V8TygjlhBrA1p(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}
}
