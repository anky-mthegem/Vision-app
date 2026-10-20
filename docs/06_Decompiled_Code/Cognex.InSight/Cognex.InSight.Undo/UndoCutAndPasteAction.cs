using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoCutAndPasteAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCutAndPasteAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoCutAndPasteAction undoCutAndPasteAction = default;
			int num2 = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					undoCutAndPasteAction = _003C_003E4__this;
					goto case 2;
				case 0:
					do
					{
						num2 = _003C_003E1__state;
						ULEcpbscmsUDtNxOwVNm();
						if (NMsg6fscylYEBtMaqPuh())
						{
							num = 4;
							continue;
						}
						num = 3;
						break;
					}
					while (false);
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)N87O1oscZKU8x3V4rFuQ(TCTLv4scgvaucPSYwNOo(undoCutAndPasteAction.k3kljXDJ4W))).CopyCellsAsync(undoCutAndPasteAction.RNfl5jD9eQ).GetAwaiter();
							_ = 0;
							if (ULEcpbscmsUDtNxOwVNm())
							{
								num3 = 2;
								if (false)
								{
									goto IL_00a6;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_012c;
						IL_00a6:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (false)
						{
							return;
						}
						goto IL_012c;
						IL_012c:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 4:
								return;
							case 0:
							case 2:
								if (awaiter.IsCompleted)
								{
									goto case 6;
								}
								goto case 1;
							case 6:
								result = awaiter.GetResult();
								num3 = 10;
								if (NMsg6fscylYEBtMaqPuh())
								{
								}
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 1:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								if (ULEcpbscmsUDtNxOwVNm())
								{
									continue;
								}
								goto case 10;
							case 10:
								undoCutAndPasteAction.MrQlYmhULg = result;
								goto end_IL_012c;
							}
							goto IL_00a6;
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
		internal static object TCTLv4scgvaucPSYwNOo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N87O1oscZKU8x3V4rFuQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ULEcpbscmsUDtNxOwVNm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NMsg6fscylYEBtMaqPuh()
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
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCutAndPasteAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_0168;
			IL_01ba:
			UndoCutAndPasteAction undoCutAndPasteAction = _003C_003E4__this;
			num = 4;
			goto IL_0168;
			IL_0168:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_01a3;
				case 1:
				case 5:
					goto IL_01ba;
				case 0:
					goto IL_01cb;
				case 6:
					return;
				}
				break;
				IL_01cb:
				num2 = _003C_003E1__state;
				_ = 0;
				if (!iZaqmascJcMCaOTDoErZ())
				{
					num = 2;
					if (dbNQ3Fsc8W8f5w6GT97N())
					{
					}
				}
				else
				{
					num = 5;
				}
			}
			goto IL_001a;
			IL_01a3:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (true)
			{
				goto IL_0168;
			}
			goto IL_01ba;
			IL_001a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = undoCutAndPasteAction.Redo().GetAwaiter();
					_ = 1;
					if (!dbNQ3Fsc8W8f5w6GT97N())
					{
						num3 = 5;
						if (dbNQ3Fsc8W8f5w6GT97N())
						{
							return;
						}
					}
					else
					{
						num3 = 7;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
					if (dbNQ3Fsc8W8f5w6GT97N())
					{
					}
				}
				while (true)
				{
					switch (num3)
					{
					case 6:
						return;
					case 8:
						_003C_003Eu__1 = default;
						num3 = 2;
						continue;
					case 4:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						continue;
					case 1:
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 6;
						continue;
					case 2:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
					case 5:
						if (awaiter.IsCompleted)
						{
							break;
						}
						goto case 1;
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
			goto IL_01a3;
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
		internal static bool iZaqmascJcMCaOTDoErZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dbNQ3Fsc8W8f5w6GT97N()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCutAndPasteAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!l38v13sczHZiY9MFcEID()) ? 1 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<byte[]> awaiter2 = default;
			byte[] result = default;
			UndoCutAndPasteAction undoCutAndPasteAction = default;
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
							if (num2 != 1)
							{
								num3 = 14;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 1;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_ = 1;
							if (!EWc1vjs2wgKrlxPOb2jc())
							{
								num3 = 0;
							}
							else
							{
								num3 = 9;
								if (1 == 0)
								{
									goto IL_01fa;
								}
							}
						}
						goto IL_0055;
						IL_0055:
						while (true)
						{
							switch (num3)
							{
							case 12:
								result = awaiter2.GetResult();
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 15:
								_003C_003Eu__1 = awaiter2;
								num3 = 6;
								continue;
							case 11:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 15;
									continue;
								}
								goto case 12;
							case 14:
								awaiter2 = ((UndoHandler)OA3u2Zs2sOfghARnT6p7(undoCutAndPasteAction.k3kljXDJ4W)).SendCutAsync(undoCutAndPasteAction.lvdlcFMhXt).GetAwaiter();
								num3 = 11;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 0:
							case 4:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 8:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 5;
									continue;
								}
								goto case 16;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 5:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								continue;
							case 1:
								_003C_003Eu__2 = default;
								num3 = 13;
								continue;
							case 10:
								return;
							case 7:
								awaiter = SLMncRs2L3lRa3hqnHHv(gwm7jRs2hAB0conNr6Yb(undoCutAndPasteAction.k3kljXDJ4W, undoCutAndPasteAction.RNfl5jD9eQ, result, true, true));
								goto case 8;
							case 13:
								break;
							case 16:
								awaiter.GetResult();
								goto end_IL_0055;
							}
							goto IL_01fa;
							continue;
							end_IL_0055:
							break;
						}
						goto end_IL_0024;
						IL_01fa:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_0055;
						end_IL_0024:;
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
					break;
				case 5:
					undoCutAndPasteAction = _003C_003E4__this;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					if (!l38v13sczHZiY9MFcEID())
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
		internal static object OA3u2Zs2sOfghARnT6p7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gwm7jRs2hAB0conNr6Yb(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SLMncRs2L3lRa3hqnHHv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l38v13sczHZiY9MFcEID()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EWc1vjs2wgKrlxPOb2jc()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoCutAndPasteAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Sa7uVRs29KrWApAxuonT();
			int num;
			if (!dtlnnLs2SkvKbBkTgj2N())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (dtlnnLs2SkvKbBkTgj2N())
				{
					goto IL_0366;
				}
			}
			goto IL_0318;
			IL_0318:
			TaskAwaiter<byte[]> awaiter2 = default;
			UndoCutAndPasteAction undoCutAndPasteAction = default;
			TaskAwaiter awaiter = default;
			byte[] result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter2 = ((UndoHandler)UAYVOds2ELMiNfmEJJ3Q(undoCutAndPasteAction.k3kljXDJ4W)).SendCutAsync(undoCutAndPasteAction.RNfl5jD9eQ).GetAwaiter();
							num3 = 16;
							goto IL_01e0;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 6;
							goto IL_01e0;
						case 1:
							awaiter = _003C_003Eu__2;
							goto IL_0247;
						case 2:
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (Sa7uVRs29KrWApAxuonT())
								{
									goto IL_01e0;
								}
								goto IL_0290;
							}
							IL_01e0:
							while (true)
							{
								switch (num3)
								{
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 12;
									continue;
								case 16:
									if (!awaiter2.IsCompleted)
									{
										num3 = 18;
										continue;
									}
									goto case 2;
								case 2:
									result = awaiter2.GetResult();
									num3 = 4;
									continue;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 17:
									return;
								case 1:
									num2 = (_003C_003E1__state = 2);
									num3 = 0;
									continue;
								case 18:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 19;
									continue;
								case 15:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 11:
								case 13:
									awaiter = m3CZ1Zs2H7QahgVEeTuv(lZJ4LZs2vCN6Yj2Uh72J(undoCutAndPasteAction.k3kljXDJ4W, undoCutAndPasteAction.RNfl5jD9eQ, undoCutAndPasteAction.MrQlYmhULg, false, true));
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 21;
								case 4:
									awaiter = ((Task)lZJ4LZs2vCN6Yj2Uh72J(undoCutAndPasteAction.k3kljXDJ4W, undoCutAndPasteAction.lvdlcFMhXt, result, true, true)).GetAwaiter();
									num3 = 8;
									continue;
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 14;
									continue;
								case 0:
									_003C_003Eu__2 = awaiter;
									num3 = 10;
									continue;
								case 14:
									return;
								case 3:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 20;
									continue;
								case 20:
									break;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 9;
									continue;
								case 5:
									return;
								case 9:
									goto IL_0290;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 12;
								case 12:
									awaiter.GetResult();
									_ = 1;
									if (dtlnnLs2SkvKbBkTgj2N())
									{
										num3 = 5;
										if (true)
										{
											continue;
										}
										goto case 1;
									}
									num3 = 11;
									continue;
								case 21:
									awaiter.GetResult();
									goto end_IL_0029;
								}
								break;
							}
							goto IL_0247;
							IL_0290:
							num2 = (_003C_003E1__state = -1);
							num3 = 2;
							goto IL_01e0;
							IL_0247:
							_003C_003Eu__2 = default;
							num3 = 7;
							goto IL_01e0;
							end_IL_0029:
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
					num = 4;
					if (Sa7uVRs29KrWApAxuonT())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 1:
				case 2:
					undoCutAndPasteAction = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0366;
			IL_0366:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0318;
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
		internal static object UAYVOds2ELMiNfmEJJ3Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lZJ4LZs2vCN6Yj2Uh72J(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter m3CZ1Zs2H7QahgVEeTuv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sa7uVRs29KrWApAxuonT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dtlnnLs2SkvKbBkTgj2N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight k3kljXDJ4W;

	private readonly CvsCellRange lvdlcFMhXt;

	private readonly CvsCellRange RNfl5jD9eQ;

	private byte[] MrQlYmhULg;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)VpbU7g7YWMdLyOrJqD2(aR9RHc7PdlW7TRnCcpI(), RNfl5jD9eQ.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoCutAndPasteAction(CvsInSight inSight, CvsCellRange cutRange, CvsCellRange pasteRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		do
		{
			IL_0031:
			switch (num)
			{
			case 0:
				lvdlcFMhXt = cutRange;
				break;
			default:
				num = 7;
				goto IL_0031;
			case 4:
				KKIjOG752ZEXI70tWmT();
				num = 1;
				goto IL_0031;
			case 1:
				q657bv7oyeWrc14sFkS(this);
				mGBpME7KPQyViBt5Yju();
				if (oSsLoA7CN90aD2xZ0CS())
				{
					num = 5;
					goto IL_0031;
				}
				num = 8;
				if (true)
				{
					goto IL_0031;
				}
				goto case 2;
			case 6:
			case 8:
				RNfl5jD9eQ.Columns = Math.Max(lvdlcFMhXt.Columns, RNfl5jD9eQ.Columns);
				num = 9;
				if (oSsLoA7CN90aD2xZ0CS())
				{
					goto IL_0031;
				}
				goto case 3;
			case 3:
				RNfl5jD9eQ.Rows = Math.Max(lvdlcFMhXt.Rows, RNfl5jD9eQ.Rows);
				goto case 6;
			case 2:
			case 5:
				k3kljXDJ4W = inSight;
				num = 0;
				goto IL_0031;
			case 7:
				break;
			case 9:
				return;
			}
			RNfl5jD9eQ = pasteRange;
			num = 3;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!mGBpME7KPQyViBt5Yju())
				{
					num = 0;
					if (oSsLoA7CN90aD2xZ0CS())
					{
						break;
					}
					goto case 5;
				}
				num = 4;
				if (oSsLoA7CN90aD2xZ0CS())
				{
					break;
				}
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 0:
			case 2:
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (mGBpME7KPQyViBt5Yju() ? 1 : 2);
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = H0jOGM7Nc4NyvxmIhN8();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					break;
				}
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mGBpME7KPQyViBt5Yju();
		int num;
		if (oSsLoA7CN90aD2xZ0CS())
		{
			num = 4;
			if (!oSsLoA7CN90aD2xZ0CS())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0048;
		IL_0091:
		_003CRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				break;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = H0jOGM7Nc4NyvxmIhN8();
				num = 1;
				if (oSsLoA7CN90aD2xZ0CS())
				{
					continue;
				}
				goto IL_0091;
			case 5:
				goto IL_0091;
			case 1:
				stateMachine._003C_003E4__this = this;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0091;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (mGBpME7KPQyViBt5Yju() ? 2 : 4);
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = H0jOGM7Nc4NyvxmIhN8();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
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
	internal static void KKIjOG752ZEXI70tWmT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q657bv7oyeWrc14sFkS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oSsLoA7CN90aD2xZ0CS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mGBpME7KPQyViBt5Yju()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aR9RHc7PdlW7TRnCcpI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionPaste;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VpbU7g7YWMdLyOrJqD2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder H0jOGM7Nc4NyvxmIhN8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
