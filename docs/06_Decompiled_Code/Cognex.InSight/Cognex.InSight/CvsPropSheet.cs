using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsPropSheet
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public CvsCellLocation location;

		public string expr;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsPropSheet cvsPropSheet = default;
			int num2 = default;
			CvsPropertySheetResult rq4FtSkdQD = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						if ((uint)num2 > 1u)
						{
							cvsPropSheet.Ds6FJ2pfrx(_0020: true);
						}
						try
						{
							ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter awaiter;
							ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_012c;
								}
								awaiter2 = ((CvsCogSocketSheet)kK12tOshJDRIuJWEZShx(cvsPropSheet.HQQFoPXV5M)).PropSheetInitAsync(location, expr).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							CvsPropertySheetResult result = awaiter2.GetResult();
							cvsPropSheet.rq4FtSkdQD = result;
							awaiter = ((CvsCogSocketSheet)kK12tOshJDRIuJWEZShx(cvsPropSheet.HQQFoPXV5M)).RunAsync(true).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_012c;
							IL_012c:
							awaiter.GetResult();
							rq4FtSkdQD = cvsPropSheet.rq4FtSkdQD;
						}
						catch (CvsException)
						{
							cvsPropSheet.Ds6FJ2pfrx(_0020: false);
							throw;
						}
						catch (Exception innerException)
						{
							cvsPropSheet.Ds6FJ2pfrx(_0020: false);
							throw new CvsNetworkException(innerException);
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
					cvsPropSheet = _003C_003E4__this;
					oEUDAushgENsfZlEWDhI();
					num = ((!pJOCF3shZXhvIEYMELKM()) ? 1 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult(rq4FtSkdQD);
					num = 6;
					break;
				case 4:
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
		internal static object kK12tOshJDRIuJWEZShx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oEUDAushgENsfZlEWDhI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pJOCF3shZXhvIEYMELKM()
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
	private struct _003CCancelAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eD7BsCsh8IkvEoKIB8cM();
			int num;
			if (!aOHfjAshzb6AftfrewDX())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_01ad;
				}
			}
			goto IL_017a;
			IL_017a:
			CvsPropSheet cvsPropSheet = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						_ = 1;
						try
						{
							ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter awaiter;
							ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0129;
								}
								cvsPropSheet.Ds6FJ2pfrx(_0020: false);
								cvsPropSheet.OsCFA1BGpG = null;
								awaiter2 = cvsPropSheet.HQQFoPXV5M.Sheet.PropSheetCancelAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							awaiter = cvsPropSheet.HQQFoPXV5M.Sheet.RunAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0129;
							IL_0129:
							awaiter.GetResult();
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
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
				case 1:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_01ad;
			IL_01ad:
			cvsPropSheet = _003C_003E4__this;
			num = 2;
			goto IL_017a;
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
		internal static bool eD7BsCsh8IkvEoKIB8cM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aOHfjAshzb6AftfrewDX()
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
	private struct _003CAcceptAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public CvsCellLocation location;

		public string expr;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			CvsPropSheet cvsPropSheet = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						_ = 2;
						try
						{
							ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter3;
							ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
							TaskAwaiter<CvsCogSheetResult> awaiter;
							switch (num2)
							{
							default:
								cvsPropSheet.Ds6FJ2pfrx(_0020: false);
								cvsPropSheet.OsCFA1BGpG = null;
								awaiter3 = cvsPropSheet.HQQFoPXV5M.Sheet.PropSheetOkAsync(location, expr).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_00b3;
							case 0:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00b3;
							case 1:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_012f;
							case 2:
								{
									awaiter = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_012f:
								awaiter2.GetResult();
								awaiter = ((CvsCogSocket)Vac5TlsL9A8mq5GvNxJo(cvsPropSheet.iULFM32ApP)).Sheet.RunAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
								IL_00b3:
								awaiter3.GetResult();
								awaiter2 = ((Task)Vq6ZhSsLLQFr3De4DlBf(fkBC6MsLhY3t3IDtJIDv(cvsPropSheet.iULFM32ApP), location)).ConfigureAwait(false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_012f;
							}
							awaiter.GetResult();
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
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
				case 1:
				case 4:
					cvsPropSheet = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (BOwA0WsLwyGpDhmbdND7() ? 4 : 0);
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
		internal static object fkBC6MsLhY3t3IDtJIDv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).SheetInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vq6ZhSsLLQFr3De4DlBf(object P_0, CvsCellLocation loc)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).UpdateCurrentCellInfoAsync(loc);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vac5TlsL9A8mq5GvNxJo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BOwA0WsLwyGpDhmbdND7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SmgXNgsLsRgLmMvNGmRI()
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
	private struct _003CRunAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public string expr;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ONFDn0sLSBG7Zqg0spcA();
			int num;
			if (!pi6hHRsLE8xmI1eW0OLW())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0166;
				}
			}
			goto IL_0133;
			IL_0133:
			CvsPropertySheetResult rq4FtSkdQD = default;
			CvsPropSheet cvsPropSheet = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					_003C_003Et__builder.SetResult(rq4FtSkdQD);
					num = 6;
					continue;
				case 1:
					try
					{
						try
						{
							ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								awaiter = ((CvsCogSocketSheet)vIeCN3sLvoQAvERPyM2G(cvsPropSheet.HQQFoPXV5M)).PropSheetRunAsync(expr).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							CvsPropertySheetResult result = awaiter.GetResult();
							cvsPropSheet.rq4FtSkdQD = result;
							cvsPropSheet.iULFM32ApP.MakeNewResult(updateExposedResults: true);
							rq4FtSkdQD = cvsPropSheet.rq4FtSkdQD;
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
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
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0166;
			IL_0166:
			cvsPropSheet = _003C_003E4__this;
			num = 1;
			if (pi6hHRsLE8xmI1eW0OLW())
			{
			}
			goto IL_0133;
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
		internal static object vIeCN3sLvoQAvERPyM2G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ONFDn0sLSBG7Zqg0spcA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pi6hHRsLE8xmI1eW0OLW()
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
	private struct _003CRunUsingPreviousExpression_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0118;
			IL_0032:
			int num2 = _003C_003E1__state;
			num = 4;
			if (1 == 0)
			{
				goto IL_0045;
			}
			goto IL_0118;
			IL_0045:
			CvsPropSheet cvsPropSheet = default;
			CvsPropertySheetResult result = default;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter;
					if (num2 == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_00cc;
					}
					if (cvsPropSheet.rq4FtSkdQD != null)
					{
						awaiter = cvsPropSheet.RunAsync((string)KZf0vjsLA3kTGf18Kskw(cvsPropSheet.rq4FtSkdQD)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00cc;
					}
					result = null;
					goto end_IL_0048;
					IL_00cc:
					result = awaiter.GetResult();
					end_IL_0048:;
				}
				catch (CvsException)
				{
					throw;
				}
				catch (Exception innerException)
				{
					throw new CvsNetworkException(innerException);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_001a;
			IL_0118:
			while (true)
			{
				switch (num)
				{
				case 1:
					goto IL_0032;
				case 2:
				case 5:
					goto IL_0045;
				case 4:
					goto IL_0149;
				case 6:
					return;
				}
				break;
				IL_0149:
				cvsPropSheet = _003C_003E4__this;
				_ = 0;
				num = (A8MmFcsLHrJwgjW3v6HE() ? 5 : 0);
			}
			goto IL_001a;
			IL_001a:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (false)
			{
				goto IL_0032;
			}
			goto IL_0118;
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
		internal static object KZf0vjsLA3kTGf18Kskw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsPropertySheetResult)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A8MmFcsLHrJwgjW3v6HE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bE1ou3sLVZEBp4Cnd38v()
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
	private struct _003CChangeAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public string expr;

		public int argIndex;

		public string[] argValues;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!E6EnWTsLUOQRV70FFO8T()) ? 1 : 5);
			CvsPropSheet cvsPropSheet = default;
			CvsPropertySheetResult rq4FtSkdQD = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					cvsPropSheet = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				default:
					_003C_003Et__builder.SetResult(rq4FtSkdQD);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						try
						{
							ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								awaiter = ((CvsCogSocketSheet)wBPiaBsLT6F70x9cL61u(cvsPropSheet.HQQFoPXV5M)).PropSheetChangeAsync(expr, argIndex, argValues).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							CvsPropertySheetResult result = awaiter.GetResult();
							cvsPropSheet.rq4FtSkdQD = result;
							cvsPropSheet.iULFM32ApP.MakeNewResult(updateExposedResults: true);
							rq4FtSkdQD = cvsPropSheet.rq4FtSkdQD;
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
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
		internal static object wBPiaBsLT6F70x9cL61u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DZtx4tsLDCCWLLDPpROm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E6EnWTsLUOQRV70FFO8T()
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
	private struct _003CChangeGraphicAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public string expr;

		public int argIndex;

		public string[] argValues;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PNu8kvsLd9wisS4pWlAy();
			int num;
			if (!cp7qBAsLivVvmbVljvv6())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (!PNu8kvsLd9wisS4pWlAy())
				{
					goto IL_0047;
				}
			}
			goto IL_014d;
			IL_017a:
			CvsPropSheet cvsPropSheet = _003C_003E4__this;
			num = 2;
			goto IL_014d;
			IL_0047:
			CvsPropertySheetResult rq4FtSkdQD = default;
			_003C_003Et__builder.SetResult(rq4FtSkdQD);
			num = 6;
			goto IL_014d;
			IL_002a:
			int num2 = _003C_003E1__state;
			goto IL_017a;
			IL_014d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					break;
				case 3:
					goto IL_0047;
				case 2:
					try
					{
						try
						{
							ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								awaiter = cvsPropSheet.HQQFoPXV5M.Sheet.PropSheetChangeGraphicAsync(expr, argIndex, argValues).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							CvsPropertySheetResult result = awaiter.GetResult();
							cvsPropSheet.rq4FtSkdQD = result;
							cvsPropSheet.iULFM32ApP.MakeNewResult(updateExposedResults: true);
							rq4FtSkdQD = cvsPropSheet.rq4FtSkdQD;
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0047;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto IL_017a;
				case 1:
				case 4:
					goto IL_017a;
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
		internal static bool PNu8kvsLd9wisS4pWlAy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cp7qBAsLivVvmbVljvv6()
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
	private struct _003CGetResultAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsPropertySheetResult> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GMLWZlsLqAken1sgganv();
			int num;
			if (!XFVvVwsLBpe6fvFddPX4())
			{
				num = 2;
				if (!GMLWZlsLqAken1sgganv())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (XFVvVwsLBpe6fvFddPX4())
				{
				}
			}
			goto IL_013c;
			IL_0167:
			CvsPropSheet cvsPropSheet = _003C_003E4__this;
			num = 3;
			if (false)
			{
				return;
			}
			goto IL_013c;
			IL_013c:
			CvsPropertySheetResult rq4FtSkdQD = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					_003C_003Et__builder.SetResult(rq4FtSkdQD);
					num = 6;
					if (GMLWZlsLqAken1sgganv())
					{
						continue;
					}
					goto case 3;
				case 3:
					try
					{
						try
						{
							ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								awaiter = ((CvsCogSocketSheet)y5oDTwsLj1Qei2KsObZ6(cvsPropSheet.HQQFoPXV5M)).PropSheetGetResultAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							CvsPropertySheetResult result = awaiter.GetResult();
							cvsPropSheet.rq4FtSkdQD = result;
							rq4FtSkdQD = cvsPropSheet.rq4FtSkdQD;
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
						}
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
				case 1:
				case 4:
					goto IL_0167;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			num2 = _003C_003E1__state;
			goto IL_0167;
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
		internal static object y5oDTwsLj1Qei2KsObZ6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GMLWZlsLqAken1sgganv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XFVvVwsLBpe6fvFddPX4()
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
	private struct _003CAddGettersOnOk_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsPropSheet cvsPropSheet = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!HGfHEHsL22SjOGmySMWt())
					{
						num = 3;
						if (true)
						{
							continue;
						}
						goto case 0;
					}
					num = 0;
					continue;
				case 0:
				case 2:
					try
					{
						try
						{
							ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
							if (num2 != 0)
							{
								awaiter = ((Task)s3YsWcsL7S8SckdmlOf1(ch1L4usLW7jJNLGFc9XS(cvsPropSheet.HQQFoPXV5M))).ConfigureAwait(false).GetAwaiter();
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
						}
						catch (CvsException)
						{
							throw;
						}
						catch (Exception innerException)
						{
							throw new CvsNetworkException(innerException);
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
					num = 5;
					continue;
				case 1:
				case 3:
					cvsPropSheet = _003C_003E4__this;
					goto case 0;
				case 5:
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
		internal static object ch1L4usLW7jJNLGFc9XS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object s3YsWcsL7S8SckdmlOf1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).PropSheetAddGettersOnOkAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eAcBFdsLcBZ3x1MCAZvP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HGfHEHsL22SjOGmySMWt()
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
	private struct _003CGetDynamicArgBinder_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DynamicArgBinder> _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		private TaskAwaiter<DynamicArgBinder> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (EA2WBCsLCsYxAgsj3VP3() ? 3 : 4);
			int num2 = default;
			CvsPropSheet cvsPropSheet = default;
			DynamicArgBinder result = default;
			do
			{
				IL_0181:
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter<DynamicArgBinder> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)UOtC7WsLKRlaq2Vncwr9(cvsPropSheet.HQQFoPXV5M)).PropSheetGetDynamicArgBindingAsync().GetAwaiter();
							num3 = 2;
							goto IL_00b4;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00ed;
						IL_00ed:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_00b4;
						IL_00b4:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (!EA2WBCsLCsYxAgsj3VP3())
									{
										num3 = 4;
										continue;
									}
									num3 = 6;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 9;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 5:
							case 6:
								break;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (EA2WBCsLCsYxAgsj3VP3())
								{
								}
								continue;
							case 8:
								return;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00b4;
							}
							goto IL_00ed;
							continue;
							end_IL_00b4:
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
					goto IL_0181;
				case 1:
				case 3:
					cvsPropSheet = _003C_003E4__this;
					num = 5;
					if (true)
					{
						goto IL_0181;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (GKFsDUsLtlHGlrcHIjA5());
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
		internal static object UOtC7WsLKRlaq2Vncwr9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GKFsDUsLtlHGlrcHIjA5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EA2WBCsLCsYxAgsj3VP3()
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
	private struct _003CSetBoundArgs_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsPropSheet _003C_003E4__this;

		public string[] argNames;

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
			CvsPropSheet cvsPropSheet = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!Xa9skhsLoer9aypFyLyF())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto default;
					}
					num = 0;
					if (false)
					{
						return;
					}
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					cvsPropSheet = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = lbE0VWsLNkFEhlnteVHE(iiP3ItsLYMTmUpYT49M4(yAXy37sLP1Ns2u7eaZMN(cvsPropSheet.HQQFoPXV5M), argNames));
							Xa9skhsLoer9aypFyLyF();
							num3 = ((!a7kCjtsL5gVrOF0KUOcS()) ? 2 : 8);
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
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (a7kCjtsL5gVrOF0KUOcS())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									if (a7kCjtsL5gVrOF0KUOcS())
									{
										continue;
									}
									return;
								}
								break;
							case 2:
								return;
							case 9:
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
		internal static object yAXy37sLP1Ns2u7eaZMN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iiP3ItsLYMTmUpYT49M4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).PropSheetSetBoundArgsAsync((string[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lbE0VWsLNkFEhlnteVHE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a7kCjtsL5gVrOF0KUOcS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xa9skhsLoer9aypFyLyF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsInSight iULFM32ApP;

	private CvsCogSocket HQQFoPXV5M;

	private CvsCell OsCFA1BGpG;

	private CvsPropertySheetResult rq4FtSkdQD;

	private bool W5PFWTxLPv;

	public CvsCell LastPropertySheetCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OsCFA1BGpG;
		}
	}

	public CvsPropertySheetResult LastPropertySheetResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rq4FtSkdQD;
		}
	}

	public CvsCogView LastPropertySheetView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qlINKDHnB0rT6DMxNKU())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0080;
			IL_0026:
			if (rq4FtSkdQD != null)
			{
				goto IL_005e;
			}
			goto IL_00a7;
			IL_00a7:
			return null;
			IL_005e:
			if (MZBsgjH013awo5WcZIu(rq4FtSkdQD) != null)
			{
				goto IL_0041;
			}
			goto IL_00a7;
			IL_0080:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 3:
					goto IL_0041;
				case 1:
				case 4:
					goto IL_005e;
				default:
					num = 3;
					continue;
				case 5:
					goto IL_00a7;
				}
				break;
			}
			goto IL_0026;
			IL_0041:
			if (((Array)MZBsgjH013awo5WcZIu(rq4FtSkdQD)).Length == 0)
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_005e;
				}
				goto IL_0080;
			}
			return (CvsCogView)((object[])MZBsgjH013awo5WcZIu(rq4FtSkdQD))[0];
		}
	}

	public bool IsEditInProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return W5PFWTxLPv;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsPropSheet(CvsInSight inSight, CvsCogSocket cogSocket)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0033;
		IL_001a:
		iULFM32ApP = inSight;
		goto IL_008f;
		IL_0033:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				continue;
			case 0:
				goto IL_0073;
			default:
				goto IL_008f;
			case 6:
				return;
			}
			break;
			IL_0073:
			base._002Ector();
			_ = 0;
			num = (qlINKDHnB0rT6DMxNKU() ? 5 : 4);
		}
		goto IL_001a;
		IL_008f:
		HQQFoPXV5M = cogSocket;
		num = 6;
		if (TPOCjaHGe3x93jxsp9h())
		{
			return;
		}
		goto IL_0033;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qlINKDHnB0rT6DMxNKU())
		{
			num = 3;
			if (!qlINKDHnB0rT6DMxNKU())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
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
			case 0:
			case 3:
				if (W5PFWTxLPv)
				{
					break;
				}
				return;
			case 4:
				goto IL_008e;
			}
			break;
		}
		goto IL_002a;
		IL_008e:
		try
		{
			if (!euB5ZSH6tCTwIA5nmtp(HQQFoPXV5M))
			{
				zoO2MRHp6rBCWCf195W(CancelAsync());
			}
			return;
		}
		catch (Exception)
		{
			return;
		}
		IL_002a:
		BqeXhOHbs9qpTthAaHl(CvsTraceSDK.Error, P4ZK41HXjpGDO0ULqxv(7282));
		goto IL_008e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ds6FJ2pfrx(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		W5PFWTxLPv = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EditComplete()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ds6FJ2pfrx(_0020: false);
		OsCFA1BGpG = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__17))]
	public Task<CvsPropertySheetResult> InitAsync(CvsCellLocation location, string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CInitAsync_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.location = location;
		stateMachine.expr = expr;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCancelAsync_003Ed__18))]
	public Task CancelAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TPOCjaHGe3x93jxsp9h();
		int num = ((!qlINKDHnB0rT6DMxNKU()) ? 5 : 4);
		_003CCancelAsync_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (qlINKDHnB0rT6DMxNKU())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = rYuk9iH44rwe0wA0qvk();
				num = 1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptAsync_003Ed__19))]
	public Task AcceptAsync(CvsCellLocation location, string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TPOCjaHGe3x93jxsp9h();
		int num = ((!qlINKDHnB0rT6DMxNKU()) ? 6 : 3);
		_003CAcceptAsync_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 7:
				stateMachine.expr = expr;
				goto case 1;
			default:
				num = 1;
				break;
			case 2:
			case 6:
				stateMachine.location = location;
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAsync_003Ed__20))]
	public Task<CvsPropertySheetResult> RunAsync(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunAsync_003Ed__20 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.expr = expr;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunUsingPreviousExpression_003Ed__21))]
	public Task<CvsPropertySheetResult> RunUsingPreviousExpression()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunUsingPreviousExpression_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeAsync_003Ed__22))]
	public Task<CvsPropertySheetResult> ChangeAsync(string expr, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CChangeAsync_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.expr = expr;
		stateMachine.argIndex = argIndex;
		stateMachine.argValues = argValues;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeGraphicAsync_003Ed__23))]
	public Task<CvsPropertySheetResult> ChangeGraphicAsync(string expr, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CChangeGraphicAsync_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.expr = expr;
		stateMachine.argIndex = argIndex;
		stateMachine.argValues = argValues;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResultAsync_003Ed__24))]
	public Task<CvsPropertySheetResult> GetResultAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResultAsync_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsPropertySheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddGettersOnOk_003Ed__25))]
	public Task AddGettersOnOk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qlINKDHnB0rT6DMxNKU();
		int num = (TPOCjaHGe3x93jxsp9h() ? 3 : 5);
		_003CAddGettersOnOk_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetDynamicArgBinder_003Ed__26))]
	public Task<DynamicArgBinder> GetDynamicArgBinder()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetDynamicArgBinder_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<DynamicArgBinder>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetBoundArgs_003Ed__27))]
	public Task SetBoundArgs(string[] argNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!TPOCjaHGe3x93jxsp9h())
		{
			num = 2;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0070;
		IL_003e:
		_003CSetBoundArgs_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0070;
		IL_0070:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
			case 6:
				goto IL_003e;
			case 5:
				stateMachine.argNames = argNames;
				break;
			default:
				num = 3;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine._003C_003E1__state = -1;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qlINKDHnB0rT6DMxNKU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TPOCjaHGe3x93jxsp9h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P4ZK41HXjpGDO0ULqxv(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BqeXhOHbs9qpTthAaHl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool euB5ZSH6tCTwIA5nmtp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).IsDisposed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zoO2MRHp6rBCWCf195W(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MZBsgjH013awo5WcZIu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPropertySheetResult)P_0).Views;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder rYuk9iH44rwe0wA0qvk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
