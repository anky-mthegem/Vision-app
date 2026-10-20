using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoGraphicAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			UndoGraphicAction undoGraphicAction = default;
			byte[] result = default;
			do
			{
				IL_0199:
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter<byte[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)khEwupsWMLWsPpkjaRl9(wXFeeGsWOrh3UcPyXFqj(undoGraphicAction.Ja1gavuOxR))).CopyCellsAsync(new CvsCellRange((string)IR7tIKsWQx1VI2IUYbFZ(undoGraphicAction.F0FghEAQsr))).GetAwaiter();
							num3 = 0;
							goto IL_00cd;
						}
						awaiter = _003C_003Eu__1;
						goto IL_013b;
						IL_013b:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (RDTFZcsWrWumWt7H4dlk())
						{
							goto IL_00cd;
						}
						goto IL_0157;
						IL_0157:
						undoGraphicAction.Tp8g4Rb5Rg = result;
						goto end_IL_0018;
						IL_00cd:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								if (!lHgfUJsW3XSqeVrcG2qO())
								{
									continue;
								}
								return;
							case 1:
							case 4:
								return;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								num3 = ((!lHgfUJsW3XSqeVrcG2qO()) ? 1 : 3);
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 6;
							case 3:
							case 5:
								break;
							case 10:
								goto IL_0157;
							}
							break;
						}
						goto IL_013b;
						end_IL_0018:;
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
					goto IL_0199;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (RDTFZcsWrWumWt7H4dlk())
					{
						num = 5;
						if (!lHgfUJsW3XSqeVrcG2qO())
						{
							goto IL_0199;
						}
						goto case 1;
					}
					num = 3;
					if (RDTFZcsWrWumWt7H4dlk())
					{
						goto IL_0199;
					}
					break;
				case 1:
				case 5:
					undoGraphicAction = _003C_003E4__this;
					goto case 2;
				case 0:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (RDTFZcsWrWumWt7H4dlk());
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
		internal static object wXFeeGsWOrh3UcPyXFqj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object khEwupsWMLWsPpkjaRl9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IR7tIKsWQx1VI2IUYbFZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RDTFZcsWrWumWt7H4dlk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lHgfUJsW3XSqeVrcG2qO()
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
	private struct _003CDo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicAction _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (SkxyRDsWeEgHfBLfu13n())
			{
				goto IL_001e;
			}
			goto IL_0235;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 0;
			if (SkxyRDsWeEgHfBLfu13n())
			{
				goto IL_0035;
			}
			goto IL_0235;
			IL_0235:
			TaskAwaiter<byte[]> awaiter = default;
			UndoGraphicAction undoGraphicAction = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					goto IL_0035;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							goto IL_01a8;
						}
						if (undoGraphicAction.TC8gOZwiVn != null)
						{
							BsQRH6sWlpgESSJIoVYA();
							if (!SkxyRDsWeEgHfBLfu13n())
							{
								num3 = 7;
								if (SkxyRDsWeEgHfBLfu13n())
								{
								}
							}
							else
							{
								num3 = 8;
								if (1 == 0)
								{
									goto IL_01f3;
								}
							}
							goto IL_01a8;
						}
						goto end_IL_004a;
						IL_01f3:
						undoGraphicAction.E4vgl4Ec5T = result;
						goto end_IL_004a;
						IL_01a8:
						while (true)
						{
							switch (num3)
							{
							case 11:
								result = awaiter.GetResult();
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 10:
								return;
							case 0:
							case 7:
								if (undoGraphicAction.K9KgpXS5iB != null)
								{
									num3 = 9;
									if (SkxyRDsWeEgHfBLfu13n())
									{
									}
									continue;
								}
								goto end_IL_01a8;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 9:
								Xbs7O2sWR2LVFLCoRdxx(((CvsCogSocket)m8TD6hsWubg83Pr9tj3Z(undoGraphicAction.Ja1gavuOxR)).Sheet, F0B9wosWIo4X7Fug9Qea(undoGraphicAction.TC8gOZwiVn), undoGraphicAction.K9KgpXS5iB);
								awaiter = ((CvsCogSocketSheet)AQBZEhsWaZ7MiI4gZPmf(m8TD6hsWubg83Pr9tj3Z(undoGraphicAction.Ja1gavuOxR))).CopyCellsAsync(new CvsCellRange(undoGraphicAction.F0FghEAQsr.Location)).GetAwaiter();
								num3 = 1;
								continue;
							case 1:
								if (awaiter.IsCompleted)
								{
									goto case 11;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 12:
								break;
							}
							goto IL_01f3;
							continue;
							end_IL_01a8:
							break;
						}
						end_IL_004a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0035;
				case 0:
					goto IL_0266;
				case 6:
					return;
				}
				break;
				IL_0266:
				undoGraphicAction = _003C_003E4__this;
				_ = 0;
				num = ((!BsQRH6sWlpgESSJIoVYA()) ? 1 : 4);
			}
			goto IL_001e;
			IL_0035:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0235;
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
		internal static object m8TD6hsWubg83Pr9tj3Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F0B9wosWIo4X7Fug9Qea(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Xbs7O2sWR2LVFLCoRdxx(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AQBZEhsWaZ7MiI4gZPmf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BsQRH6sWlpgESSJIoVYA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SkxyRDsWeEgHfBLfu13n()
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
	private struct _003CRedo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!adtv3NsWGUDie5LH9cqS())
			{
			}
			UndoGraphicAction undoGraphicAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					undoGraphicAction = _003C_003E4__this;
					goto case 0;
				case 3:
					do
					{
						num2 = _003C_003E1__state;
						adtv3NsWGUDie5LH9cqS();
						if (!rp583lsWnj3EKnfMgbot())
						{
							num = 0;
							continue;
						}
						num = 5;
						break;
					}
					while (!rp583lsWnj3EKnfMgbot());
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (false)
							{
								goto IL_00ef;
							}
							goto IL_011b;
						}
						if (undoGraphicAction.E4vgl4Ec5T != null)
						{
							num3 = 8;
							goto IL_011b;
						}
						goto end_IL_0075;
						IL_011b:
						while (true)
						{
							switch (num3)
							{
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (rp583lsWnj3EKnfMgbot())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 10;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 2:
								return;
							case 9:
								break;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 8:
								awaiter = kbyRsmsWbEEBwAuGE27D(undoGraphicAction.Ja1gavuOxR.PasteCellsAsync(new CvsCellRange((string)vRaamesWXiN703L0ZJi4(undoGraphicAction.F0FghEAQsr)), undoGraphicAction.E4vgl4Ec5T, cutFromSameSheet: false, runSheet: true));
								rp583lsWnj3EKnfMgbot();
								num3 = ((!adtv3NsWGUDie5LH9cqS()) ? 7 : 5);
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_011b;
							}
							goto IL_00ef;
							continue;
							end_IL_011b:
							break;
						}
						goto end_IL_0075;
						IL_00ef:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_011b;
						end_IL_0075:;
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
		internal static object vRaamesWXiN703L0ZJi4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kbyRsmsWbEEBwAuGE27D(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rp583lsWnj3EKnfMgbot()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool adtv3NsWGUDie5LH9cqS()
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
	private struct _003CUndo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (XgjKS2sWpKXR9xpuDuSB() ? 4 : 3);
			UndoGraphicAction undoGraphicAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoGraphicAction = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!ocLAM0sW6pGyu0cfZ7dp())
							{
								goto IL_007e;
							}
							goto IL_0097;
						}
						if (undoGraphicAction.Tp8g4Rb5Rg != null)
						{
							ocLAM0sW6pGyu0cfZ7dp();
							if (!XgjKS2sWpKXR9xpuDuSB())
							{
								num3 = 2;
								if (false)
								{
									return;
								}
							}
							else
							{
								num3 = 3;
							}
							goto IL_0097;
						}
						goto end_IL_0035;
						IL_017d:
						awaiter.GetResult();
						goto end_IL_0035;
						IL_00ec:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							if (!XgjKS2sWpKXR9xpuDuSB())
							{
								goto IL_0097;
							}
							goto IL_0108;
						}
						goto IL_017d;
						IL_0108:
						awaiter = ((Task)Jt5XkusW4ZEM1aYSTeWO(undoGraphicAction.Ja1gavuOxR, new CvsCellRange((string)Ggv5JisW0qDljLKs7YNu(undoGraphicAction.F0FghEAQsr)), undoGraphicAction.Tp8g4Rb5Rg, false, true)).GetAwaiter();
						goto IL_00ec;
						IL_00d2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 6;
						if (0 == 0)
						{
							goto IL_0097;
						}
						goto IL_00ec;
						IL_007e:
						_003C_003Eu__1 = awaiter;
						goto IL_00d2;
						IL_0097:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 8:
								break;
							default:
								num3 = 9;
								continue;
							case 9:
								goto IL_00d2;
							case 1:
							case 3:
								goto IL_00ec;
							case 0:
							case 2:
								goto IL_0108;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								goto IL_017d;
							}
							break;
						}
						goto IL_007e;
						end_IL_0035:;
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
				case 5:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object Ggv5JisW0qDljLKs7YNu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jt5XkusW4ZEM1aYSTeWO(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ocLAM0sW6pGyu0cfZ7dp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XgjKS2sWpKXR9xpuDuSB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight Ja1gavuOxR;

	private CvsCogEditingShape TC8gOZwiVn;

	private CvsCogShape K9KgpXS5iB;

	private CvsCogEditInfo F0FghEAQsr;

	private byte[] Tp8g4Rb5Rg;

	private byte[] E4vgl4Ec5T;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			string text = ((F0FghEAQsr != null) ? zb97SmtcbopKFi5jDWo(F0FghEAQsr).ToString() : string.Empty);
			return (string)v9LCyftWc6sUBGlWFFN(fRMEurt2XB8O4jR85rn(), text);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoGraphicAction(CvsInSight inSight, CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0056;
		IL_001a:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 7;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
			case 5:
				K9KgpXS5iB = editedShape;
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				F0FghEAQsr = editInfo;
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				base._002Ector();
				_ = 1;
				if (!l4HRrLtjK1judUGtRnm())
				{
					num = 1;
					continue;
				}
				num = 4;
				if (!l4HRrLtjK1judUGtRnm())
				{
					continue;
				}
				goto case 1;
			case 3:
				TC8gOZwiVn = originalShape;
				goto case 4;
			case 1:
			case 2:
				Ja1gavuOxR = inSight;
				num = 0;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__9))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!c3Ya07tB1Vqn1dipjuD())
		{
			goto IL_001e;
		}
		goto IL_0090;
		IL_0040:
		_003CSaveState_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0090;
		IL_0076:
		stateMachine._003C_003E1__state = -1;
		goto IL_0040;
		IL_0090:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 3:
				goto IL_0040;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto IL_0076;
			case 2:
			case 4:
				goto IL_0076;
			default:
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		stateMachine._003C_003Et__builder = IJ9njTt7snuka3Dx9RQ();
		_ = 1;
		if (!l4HRrLtjK1judUGtRnm())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (!c3Ya07tB1Vqn1dipjuD())
			{
				goto IL_0076;
			}
		}
		goto IL_0090;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__10))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CDo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder = IJ9njTt7snuka3Dx9RQ();
				_ = 1;
				num = ((!l4HRrLtjK1judUGtRnm()) ? 4 : 0);
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!l4HRrLtjK1judUGtRnm())
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__11))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!l4HRrLtjK1judUGtRnm())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00b3;
			}
		}
		goto IL_0052;
		IL_0052:
		_003CRedo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = IJ9njTt7snuka3Dx9RQ();
				break;
			case 6:
				goto IL_00b3;
			}
			break;
		}
		goto IL_0026;
		IL_00b3:
		return stateMachine._003C_003Et__builder.Task;
		IL_0026:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0052;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__12))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (c3Ya07tB1Vqn1dipjuD())
		{
			num = 5;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0086;
		IL_0026:
		_003CUndo_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = IJ9njTt7snuka3Dx9RQ();
				goto case 1;
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c3Ya07tB1Vqn1dipjuD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l4HRrLtjK1judUGtRnm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zb97SmtcbopKFi5jDWo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditInfo)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fRMEurt2XB8O4jR85rn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionGraphicChange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v9LCyftWc6sUBGlWFFN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder IJ9njTt7snuka3Dx9RQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
