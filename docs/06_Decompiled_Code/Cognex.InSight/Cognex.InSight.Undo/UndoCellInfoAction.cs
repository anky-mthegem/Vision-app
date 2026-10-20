using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoCellInfoAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellInfoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoCellInfoAction undoCellInfoAction = default;
			CvsCellLocation cvsCellLocation = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					undoCellInfoAction = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							tZ7xAVsB3POecSlAC2M0(undoCellInfoAction.cRo4ea5SeL);
							tZ7xAVsB3POecSlAC2M0(undoCellInfoAction.jfM4D0WFJV);
							undoCellInfoAction.gAn4GlYfHf.Clear();
							IEnumerator<INamedOperand> enumerator = ((IEnumerable<INamedOperand>)undoCellInfoAction.GtT4iWIV9l).GetEnumerator();
							try
							{
								while (kC8xKWsBQbc6LSIbfQfo(enumerator))
								{
									CvsCellInfo cvsCellInfo = (CvsCellInfo)enumerator.Current;
									bool flag = false;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.btB4dt0Z4p).GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											CvsCellInfo cvsCellInfo2 = (CvsCellInfo)enumerator2.Current;
											int num3 = 6;
											while (true)
											{
												switch (num3)
												{
												case 5:
													undoCellInfoAction.gAn4GlYfHf.Add(F5GMXosBOQk50xgXUUwd(cvsCellInfo));
													break;
												case 1:
												case 2:
													if (cvsCellInfo.Equals(cvsCellInfo2))
													{
														break;
													}
													goto case 5;
												default:
													num3 = 5;
													if (0 == 0)
													{
														continue;
													}
													goto case 6;
												case 6:
													cvsCellLocation = F5GMXosBOQk50xgXUUwd(cvsCellInfo);
													num3 = 3;
													continue;
												case 0:
												case 4:
													break;
												case 3:
													goto IL_013f;
												case 7:
													goto end_IL_00ef;
												}
												flag = true;
												num3 = 7;
												continue;
												IL_013f:
												if (cvsCellLocation.Equals(F5GMXosBOQk50xgXUUwd(cvsCellInfo2)))
												{
													HDpA5fsBr7NCjqldTccx();
													num3 = (aCNsVWsB1L3pTx1YB4Iw() ? 1 : 0);
													continue;
												}
												goto IL_017c;
												continue;
												end_IL_00ef:
												break;
											}
											break;
											IL_017c:;
										}
									}
									finally
									{
										if (num2 < 0 && enumerator2 != null)
										{
											x3gYlDsBMB7u1dOYJRdQ(enumerator2);
										}
									}
									if (!flag)
									{
										undoCellInfoAction.cRo4ea5SeL.Add(F5GMXosBOQk50xgXUUwd(cvsCellInfo));
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									x3gYlDsBMB7u1dOYJRdQ(enumerator);
								}
							}
							enumerator = ((IEnumerable<INamedOperand>)undoCellInfoAction.btB4dt0Z4p).GetEnumerator();
							try
							{
								while (kC8xKWsBQbc6LSIbfQfo(enumerator))
								{
									CvsCellInfo cvsCellInfo3 = (CvsCellInfo)enumerator.Current;
									bool flag2 = false;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.GtT4iWIV9l).GetEnumerator();
									try
									{
										while (kC8xKWsBQbc6LSIbfQfo(enumerator2))
										{
											cvsCellLocation = F5GMXosBOQk50xgXUUwd((CvsCellInfo)enumerator2.Current);
											aCNsVWsB1L3pTx1YB4Iw();
											int num4 = (HDpA5fsBr7NCjqldTccx() ? 3 : 2);
											while (true)
											{
												switch (num4)
												{
												default:
													flag2 = true;
													num4 = 4;
													if (!HDpA5fsBr7NCjqldTccx())
													{
														continue;
													}
													goto case 0;
												case 0:
												case 2:
													if (!cvsCellLocation.Equals(F5GMXosBOQk50xgXUUwd(cvsCellInfo3)))
													{
														goto IL_02b0;
													}
													goto default;
												case 4:
													break;
												}
												break;
											}
											break;
											IL_02b0:;
										}
									}
									finally
									{
										if (num2 < 0)
										{
											enumerator2?.Dispose();
										}
									}
									if (!flag2)
									{
										undoCellInfoAction.jfM4D0WFJV.Add(F5GMXosBOQk50xgXUUwd(cvsCellInfo3));
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									x3gYlDsBMB7u1dOYJRdQ(enumerator);
								}
							}
							undoCellInfoAction.kpq4SqBMDA = true;
							awaiter = ((Task)seuKxssBlxO3LVTPAmiA()).GetAwaiter();
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
					aCNsVWsB1L3pTx1YB4Iw();
					num = (HDpA5fsBr7NCjqldTccx() ? 2 : 0);
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
		internal static void tZ7xAVsB3POecSlAC2M0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((List<CvsCellLocation>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation F5GMXosBOQk50xgXUUwd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void x3gYlDsBMB7u1dOYJRdQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kC8xKWsBQbc6LSIbfQfo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object seuKxssBlxO3LVTPAmiA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aCNsVWsB1L3pTx1YB4Iw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HDpA5fsBr7NCjqldTccx()
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
	private struct _003CDo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellInfoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (TkUWv0sBuFNeuixjuYXL() ? 5 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoCellInfoAction undoCellInfoAction = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					if (TkUWv0sBuFNeuixjuYXL())
					{
					}
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
								num3 = 8;
								if (false)
								{
									goto IL_006d;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 5;
								if (false)
								{
									goto IL_009b;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_01d1;
						IL_006d:
						_003C_003Eu__1 = default;
						num3 = 13;
						goto IL_01d1;
						IL_01d1:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 14:
								return;
							case 12:
								goto IL_009b;
							case 2:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								continue;
							case 1:
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (!TkUWv0sBuFNeuixjuYXL())
									{
										continue;
									}
									goto case 7;
								}
								goto case 6;
							case 7:
								awaiter = vVUkGasBIK2lV83BPnBV(undoCellInfoAction.Redo());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 9;
									continue;
								}
								goto case 16;
							case 4:
								return;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 3:
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 8:
								if (undoCellInfoAction.kpq4SqBMDA)
								{
									goto case 7;
								}
								awaiter = vVUkGasBIK2lV83BPnBV(undoCellInfoAction.SaveState());
								kCa2NtsBeM1oPvJwI9M6();
								if (TkUWv0sBuFNeuixjuYXL())
								{
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 15;
								if (TkUWv0sBuFNeuixjuYXL())
								{
								}
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 6:
								awaiter.GetResult();
								num3 = 7;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0054;
							}
							break;
						}
						goto IL_006d;
						IL_009b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (TkUWv0sBuFNeuixjuYXL())
						{
						}
						goto IL_01d1;
						end_IL_0054:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					break;
				case 4:
					undoCellInfoAction = _003C_003E4__this;
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
		internal static TaskAwaiter vVUkGasBIK2lV83BPnBV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kCa2NtsBeM1oPvJwI9M6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TkUWv0sBuFNeuixjuYXL()
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
	private struct _003CRedo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellInfoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			UndoCellInfoAction undoCellInfoAction = default;
			CvsCellLocation cvsCellLocation = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					undoCellInfoAction = _003C_003E4__this;
					_ = 0;
					if (sgKopksBR3p4vySLsfq9())
					{
						num = 0;
						if (!yE1KJOsBaRx05nHZ7jrH())
						{
							continue;
						}
						goto case 0;
					}
					num = 5;
					continue;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCellLocation> list = new List<CvsCellLocation>();
							list.AddRange(undoCellInfoAction.jfM4D0WFJV);
							list.AddRange(undoCellInfoAction.gAn4GlYfHf);
							List<CvsCellLocation>.Enumerator enumerator = list.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCellLocation current = enumerator.Current;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.btB4dt0Z4p).GetEnumerator();
									try
									{
										while (iXwaBmsB6PnE2q9I3Uyl(enumerator2))
										{
											CvsCellInfo cvsCellInfo = (CvsCellInfo)enumerator2.Current;
											cvsCellLocation = ByV9pvsBnwKmMfRbx5Wx(cvsCellInfo);
											if (cvsCellLocation.Equals(current))
											{
												try
												{
													pANMaYsBb3mgmEoLkyjw(wMSN0jsBXKy3FeRxk57i(zMn7QAsBGH9DsKU7S6NL(undoCellInfoAction.BIO4uMRfEf)), cvsCellInfo);
												}
												catch (ArgumentException)
												{
												}
												catch (CvsCommunicationException)
												{
												}
												break;
											}
										}
									}
									finally
									{
										if (num2 < 0 && enumerator2 != null)
										{
											MAWZJVsBp0ffHZTw8kAF(enumerator2);
										}
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							enumerator = undoCellInfoAction.cRo4ea5SeL.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCellLocation current2 = enumerator.Current;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.GtT4iWIV9l).GetEnumerator();
									try
									{
										while (iXwaBmsB6PnE2q9I3Uyl(enumerator2))
										{
											CvsCellInfo cvsCellInfo2 = (CvsCellInfo)enumerator2.Current;
											int num3 = 3;
											do
											{
												IL_01ca:
												switch (num3)
												{
												case 3:
													cvsCellLocation = ByV9pvsBnwKmMfRbx5Wx(cvsCellInfo2);
													yE1KJOsBaRx05nHZ7jrH();
													num3 = (sgKopksBR3p4vySLsfq9() ? 4 : 0);
													goto IL_01ca;
												case 1:
												case 4:
													goto IL_019f;
												case 5:
													goto end_IL_01ca;
												}
												goto IL_01f7;
												IL_019f:
												if (!cvsCellLocation.Equals(current2))
												{
													goto IL_0224;
												}
												goto IL_01f7;
												IL_01f7:
												wUcHsesB0tqAS7en9i1D(wMSN0jsBXKy3FeRxk57i(zMn7QAsBGH9DsKU7S6NL(undoCellInfoAction.BIO4uMRfEf)), ByV9pvsBnwKmMfRbx5Wx(cvsCellInfo2));
												num3 = 5;
												continue;
												end_IL_01ca:
												break;
											}
											while (0 == 0);
											break;
											IL_0224:;
										}
									}
									finally
									{
										if (num2 < 0)
										{
											enumerator2?.Dispose();
										}
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = u3BldfsBkog7DByIwIPd(KEPSwhsB41XE6bJ8eeZh());
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
		internal static CvsCellLocation ByV9pvsBnwKmMfRbx5Wx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zMn7QAsBGH9DsKU7S6NL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wMSN0jsBXKy3FeRxk57i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pANMaYsBb3mgmEoLkyjw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCellInfo((CvsCellInfo)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iXwaBmsB6PnE2q9I3Uyl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MAWZJVsBp0ffHZTw8kAF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wUcHsesB0tqAS7en9i1D(object P_0, CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellInfo(location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KEPSwhsB41XE6bJ8eeZh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter u3BldfsBkog7DByIwIPd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sgKopksBR3p4vySLsfq9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yE1KJOsBaRx05nHZ7jrH()
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
	private struct _003CUndo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCellInfoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NJQqocsBf3vwAS8l6pnF();
			int num;
			if (!FJORtNsBFATuwI2XGU6I())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0304;
				}
			}
			goto IL_02d1;
			IL_02d1:
			UndoCellInfoAction undoCellInfoAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCellLocation> list = new List<CvsCellLocation>();
							list.AddRange(undoCellInfoAction.cRo4ea5SeL);
							list.AddRange(undoCellInfoAction.gAn4GlYfHf);
							List<CvsCellLocation>.Enumerator enumerator = list.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCellLocation current = enumerator.Current;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.GtT4iWIV9l).GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											CvsCellInfo cvsCellInfo = (CvsCellInfo)enumerator2.Current;
											if (nkRKJWsBma6CYXZyP0PD(cvsCellInfo).Equals(current))
											{
												try
												{
													Bqc8YdsBZcrHT2eydHIX(fZ6vVYsBg7Cyeaqy6QIP(K96TLtsByVj7i6RlXwuX(undoCellInfoAction.BIO4uMRfEf)), cvsCellInfo);
												}
												catch (ArgumentException)
												{
												}
												catch (CvsCommunicationException)
												{
												}
												break;
											}
										}
									}
									finally
									{
										if (num2 < 0 && enumerator2 != null)
										{
											E5ThwdsBJgEjKuTYSp3T(enumerator2);
										}
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							enumerator = undoCellInfoAction.jfM4D0WFJV.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCellLocation current2 = enumerator.Current;
									IEnumerator<INamedOperand> enumerator2 = ((IEnumerable<INamedOperand>)undoCellInfoAction.btB4dt0Z4p).GetEnumerator();
									try
									{
										while (wOXpp7sBzsVmcEhNc7dl(enumerator2))
										{
											CvsCellLocation cvsCellLocation = nkRKJWsBma6CYXZyP0PD((CvsCellInfo)enumerator2.Current);
											_ = 1;
											int num3 = (FJORtNsBFATuwI2XGU6I() ? 2 : 3);
											while (true)
											{
												switch (num3)
												{
												default:
													e7oSbAsB8E2al8c2VEQ3(fZ6vVYsBg7Cyeaqy6QIP(undoCellInfoAction.BIO4uMRfEf.CogSocket), current2);
													num3 = 4;
													if (NJQqocsBf3vwAS8l6pnF())
													{
														continue;
													}
													goto case 0;
												case 0:
												case 3:
													if (!cvsCellLocation.Equals(current2))
													{
														goto IL_01e9;
													}
													goto default;
												case 4:
													break;
												}
												break;
											}
											break;
											IL_01e9:;
										}
									}
									finally
									{
										if (num2 < 0 && enumerator2 != null)
										{
											E5ThwdsBJgEjKuTYSp3T(enumerator2);
										}
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = BB1VvFsjwItUJ4R4NCUr(Task.CompletedTask);
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
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 4:
					break;
				case 2:
					undoCellInfoAction = _003C_003E4__this;
					num = 1;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0304;
			IL_0304:
			num2 = _003C_003E1__state;
			num = 2;
			goto IL_02d1;
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
		internal static CvsCellLocation nkRKJWsBma6CYXZyP0PD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K96TLtsByVj7i6RlXwuX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fZ6vVYsBg7Cyeaqy6QIP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Bqc8YdsBZcrHT2eydHIX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCellInfo((CvsCellInfo)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void E5ThwdsBJgEjKuTYSp3T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void e7oSbAsB8E2al8c2VEQ3(object P_0, CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellInfo(location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wOXpp7sBzsVmcEhNc7dl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter BB1VvFsjwItUJ4R4NCUr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NJQqocsBf3vwAS8l6pnF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FJORtNsBFATuwI2XGU6I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsCellInfoCollection GtT4iWIV9l;

	private readonly CvsCellInfoCollection btB4dt0Z4p;

	private readonly CvsInSight BIO4uMRfEf;

	private readonly List<CvsCellLocation> gAn4GlYfHf;

	private readonly List<CvsCellLocation> jfM4D0WFJV;

	private readonly List<CvsCellLocation> cRo4ea5SeL;

	private bool kpq4SqBMDA;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)uHUVG1WbdS3deUtaNHI();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCellInfoAction(CvsInSight inSight, CvsCellInfoCollection originalCellInfoCollection, CvsCellInfoCollection newCellInfoCollection)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0092;
		IL_005d:
		GtT4iWIV9l = originalCellInfoCollection;
		goto IL_003b;
		IL_007a:
		base._002Ector();
		goto IL_005d;
		IL_0092:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 6:
			case 9:
				goto IL_003b;
			case 1:
				BIO4uMRfEf = inSight;
				num = 10;
				continue;
			case 7:
				goto IL_005d;
			case 0:
			case 4:
				goto IL_007a;
			default:
				num = 7;
				continue;
			case 8:
				jfM4D0WFJV = new List<CvsCellLocation>();
				num = 2;
				continue;
			case 3:
				gAn4GlYfHf = new List<CvsCellLocation>();
				num = 8;
				continue;
			case 5:
				GabNRbWXsRPAvsCYaR5();
				num = 3;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		cRo4ea5SeL = new List<CvsCellLocation>();
		_ = 0;
		if (b4pl7rWnVYRJFdgyt7L())
		{
			num = 0;
		}
		else
		{
			num = 9;
			if (!b4pl7rWnVYRJFdgyt7L())
			{
				goto IL_007a;
			}
		}
		goto IL_0092;
		IL_003b:
		btB4dt0Z4p = newCellInfoCollection;
		num = 1;
		goto IL_0092;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__9))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		b4pl7rWnVYRJFdgyt7L();
		int num = (h5tn3FWG1YPZDES15v9() ? 3 : 4);
		_003CSaveState_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = K8CliaW66ZO9kW1ymjb();
				num = 5;
				if (b4pl7rWnVYRJFdgyt7L())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__11))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003Et__builder = K8CliaW66ZO9kW1ymjb();
				h5tn3FWG1YPZDES15v9();
				num = (b4pl7rWnVYRJFdgyt7L() ? 4 : 0);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__12))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (h5tn3FWG1YPZDES15v9() ? 5 : 4);
		_003CRedo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!h5tn3FWG1YPZDES15v9())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (!h5tn3FWG1YPZDES15v9())
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__13))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		h5tn3FWG1YPZDES15v9();
		int num = ((!b4pl7rWnVYRJFdgyt7L()) ? 4 : 2);
		_003CUndo_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = K8CliaW66ZO9kW1ymjb();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GabNRbWXsRPAvsCYaR5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b4pl7rWnVYRJFdgyt7L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h5tn3FWG1YPZDES15v9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uHUVG1WbdS3deUtaNHI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionCellNameChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder K8CliaW66ZO9kW1ymjb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
