using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;

public class UndoRemoveLink : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveLink _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_0288;
			IL_02b3:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_0288;
			IL_0054:
			int num2 = default;
			UndoRemoveLink undoRemoveLink = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				switch (num2)
				{
				default:
					num3 = 0;
					break;
				case 0:
					awaiter = _003C_003Eu__1;
					num3 = 3;
					break;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 7;
					break;
				}
				while (true)
				{
					switch (num3)
					{
					case 10:
					case 15:
						_003C_003Eu__1 = awaiter;
						num3 = 6;
						continue;
					case 11:
						awaiter = vuiTuCKheSKAbjciHEup(undoRemoveLink.xiZHOH9oLp.AppViewModel.ReadCurrentPropertyLinks());
						num3 = 5;
						if (HPgMvxKhw0GDM397WMed())
						{
							continue;
						}
						goto case 6;
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 12:
						return;
					case 8:
						return;
					case 1:
						_003C_003Eu__1 = awaiter;
						num3 = 14;
						continue;
					case 13:
						return;
					case 9:
						awaiter.GetResult();
						goto case 11;
					default:
						num3 = 11;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					case 2:
						num2 = (_003C_003E1__state = 1);
						HPgMvxKhw0GDM397WMed();
						num3 = ((!crNEdrKhJlfXTqiDZF36()) ? 15 : 13);
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 5:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						break;
					case 3:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
						awaiter = vuiTuCKheSKAbjciHEup(yp2x4nKhavIVFrnuhCey(undoRemoveLink.xiZHOH9oLp, undoRemoveLink.W8RHHOZ3tu));
						if (awaiter.IsCompleted)
						{
							goto case 9;
						}
						num3 = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 4;
					case 4:
						num2 = (_003C_003E1__state = 0);
						num3 = 1;
						if (HPgMvxKhw0GDM397WMed())
						{
							continue;
						}
						goto case 14;
					case 14:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						if (HPgMvxKhw0GDM397WMed())
						{
							continue;
						}
						break;
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
			goto IL_02b3;
			IL_0288:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 1:
					undoRemoveLink = _003C_003E4__this;
					goto IL_0054;
				case 2:
				case 3:
					goto IL_0054;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_02b3;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num2 = _003C_003E1__state;
			_ = 1;
			if (!crNEdrKhJlfXTqiDZF36())
			{
				num = 0;
			}
			else
			{
				num = 3;
				if (!HPgMvxKhw0GDM397WMed())
				{
					goto IL_0054;
				}
			}
			goto IL_0288;
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
		internal static object yp2x4nKhavIVFrnuhCey(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vuiTuCKheSKAbjciHEup(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HPgMvxKhw0GDM397WMed()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool crNEdrKhJlfXTqiDZF36()
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
	private struct _003CRedo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveLink _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!en2wEfKhOVpqTQsiS3Tl()) ? 3 : 5);
			UndoRemoveLink undoRemoveLink = default;
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
					undoRemoveLink = _003C_003E4__this;
					goto case 2;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 0;
								num3 = ((!en2wEfKhOVpqTQsiS3Tl()) ? 5 : 7);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 15;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0099;
							default:
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								return;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 7:
								awaiter = bsJBfAKhiPCr51MAHeWO(t8u0EsKhDToMWVgYwPDL(undoRemoveLink.xiZHOH9oLp, undoRemoveLink.W8RHHOZ3tu));
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 4:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 15:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 11:
								awaiter = ((Task)yt9XnPKhV6nBv4F08xSZ(eOBGkCKhnwRU099GRtFB(undoRemoveLink.xiZHOH9oLp))).GetAwaiter();
								num3 = 6;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto IL_0099;
							case 16:
								break;
								IL_0099:
								awaiter.GetResult();
								goto case 11;
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
		internal static object t8u0EsKhDToMWVgYwPDL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).RemoveLink((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bsJBfAKhiPCr51MAHeWO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eOBGkCKhnwRU099GRtFB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yt9XnPKhV6nBv4F08xSZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ReadCurrentPropertyLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool en2wEfKhOVpqTQsiS3Tl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IcX3rNKhI5WtbNFOet3h()
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
	private struct _003CSaveState_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveLink _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VG1cH8KhfA4kG3YVHjMm();
			int num = (C3QCR8KhduTohKKSpKH7() ? 1 : 5);
			int num2 = default;
			UndoRemoveLink undoRemoveLink = default;
			CvsCell cvsCell = default;
			CvsCellCollection result = default;
			CvsCellLocation sourceCellLocation = default;
			do
			{
				IL_01e1:
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)L5StC0Khg5cwjOaJclWL(((CvsInSight)pFItU7KhlmOllKjk1Mao(undoRemoveLink.xiZHOH9oLp)).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							num3 = 10;
							goto IL_011c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00cf;
						IL_00cf:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_011c;
						IL_011c:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 11:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 10:
								if (!awaiter.IsCompleted)
								{
									C3QCR8KhduTohKKSpKH7();
									num3 = (VG1cH8KhfA4kG3YVHjMm() ? 11 : 5);
									continue;
								}
								goto case 6;
							case 9:
								if (cvsCell != null)
								{
									num3 = 12;
									continue;
								}
								goto end_IL_011c;
							case 0:
								cvsCell = (CvsCell)Cdm6BiKhskV6ywm4HJP0(result, sourceCellLocation);
								num3 = 9;
								continue;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 7:
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 4:
								return;
							default:
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
								result = awaiter.GetResult();
								sourceCellLocation = undoRemoveLink.xiZHOH9oLp.GetSourceCellLocation(result, undoRemoveLink.W8RHHOZ3tu);
								num3 = 0;
								continue;
							case 12:
								undoRemoveLink.UekHwl1lY8 = (string)el76bZKhv9BtKruYjp07(cvsCell);
								goto end_IL_011c;
							}
							goto IL_00cf;
							continue;
							end_IL_011c:
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					goto IL_01e1;
				case 4:
					undoRemoveLink = _003C_003E4__this;
					num = 2;
					goto IL_01e1;
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
		internal static object pFItU7KhlmOllKjk1Mao(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L5StC0Khg5cwjOaJclWL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Cdm6BiKhskV6ywm4HJP0(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object el76bZKhv9BtKruYjp07(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VG1cH8KhfA4kG3YVHjMm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C3QCR8KhduTohKKSpKH7()
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
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveLink _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoRemoveLink undoRemoveLink = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 7;
								if (false)
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 15;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
								return;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (FpT6RxKhrB2P003JmgCX())
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter = hGINdkKhZTWiiDHNUPCs(((EasyBuilderApplicationViewModel)xp9D9BKhBWjnm2EFrx1Z(undoRemoveLink.xiZHOH9oLp)).ReadCurrentPropertyLinks());
								if (awaiter.IsCompleted)
								{
									break;
								}
								num2 = (_003C_003E1__state = 1);
								goto case 2;
							case 7:
								awaiter = hGINdkKhZTWiiDHNUPCs(undoRemoveLink.xiZHOH9oLp.AddLink(undoRemoveLink.W8RHHOZ3tu, undoRemoveLink.UekHwl1lY8));
								num3 = 1;
								if (sIlGDaKhPMTQj0cdcvwu())
								{
								}
								continue;
							case 2:
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 13:
								_003C_003Eu__1 = default;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_0171;
							case 3:
								return;
							case 4:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								FpT6RxKhrB2P003JmgCX();
								num3 = ((!sIlGDaKhPMTQj0cdcvwu()) ? 5 : 2);
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									if (sIlGDaKhPMTQj0cdcvwu())
									{
									}
									continue;
								}
								goto IL_0171;
							case 16:
								break;
								IL_0171:
								awaiter.GetResult();
								num3 = 11;
								continue;
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
				case 1:
				case 5:
					undoRemoveLink = _003C_003E4__this;
					num = 0;
					break;
				case 4:
					num2 = _003C_003E1__state;
					sIlGDaKhPMTQj0cdcvwu();
					num = (FpT6RxKhrB2P003JmgCX() ? 5 : 2);
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
		internal static TaskAwaiter hGINdkKhZTWiiDHNUPCs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xp9D9BKhBWjnm2EFrx1Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FpT6RxKhrB2P003JmgCX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sIlGDaKhPMTQj0cdcvwu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly PropertyLinks xiZHOH9oLp;

	private readonly string W8RHHOZ3tu;

	private string UekHwl1lY8;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)iV0p49yNe2u6KhLhp4W(dNsFUfyQi1e2vdDx0ag(), W8RHHOZ3tu, UekHwl1lY8);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRemoveLink(PropertyLinks links, string dstName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ovHTXvyUZyRRH4HWrpR();
		int num;
		if (!v2fYJgyHpINwmn6C688())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006a;
		IL_002a:
		W8RHHOZ3tu = dstName;
		num = 6;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				yhhowRymq66fuqJ3aoG(this);
				goto case 2;
			case 2:
			case 4:
				xiZHOH9oLp = links;
				break;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				qGjWaFyxy6XEGTO86xb();
				num = 3;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__6))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0066;
		IL_004c:
		_003CDo_003Ed__6 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0034;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
				goto IL_0034;
			case 2:
			case 3:
				goto IL_004c;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				ovHTXvyUZyRRH4HWrpR();
				if (v2fYJgyHpINwmn6C688())
				{
					num = 3;
					if (true)
					{
						continue;
					}
					goto IL_0034;
				}
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0034:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0066;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_004c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__7))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003Et__builder = hVaed5y2nmkB4yI8o17();
				_ = 1;
				if (v2fYJgyHpINwmn6C688())
				{
					num = 0;
					if (!v2fYJgyHpINwmn6C688())
					{
						break;
					}
					goto case 3;
				}
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__8))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 4:
				stateMachine._003C_003Et__builder = hVaed5y2nmkB4yI8o17();
				_ = 1;
				if (!v2fYJgyHpINwmn6C688())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 0;
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (v2fYJgyHpINwmn6C688())
		{
			goto IL_001e;
		}
		goto IL_0088;
		IL_001e:
		_003CUndo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_ = 1;
		num = (v2fYJgyHpINwmn6C688() ? 4 : 2);
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qGjWaFyxy6XEGTO86xb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yhhowRymq66fuqJ3aoG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ovHTXvyUZyRRH4HWrpR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v2fYJgyHpINwmn6C688()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dNsFUfyQi1e2vdDx0ag()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.LyAhTVgT4l();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iV0p49yNe2u6KhLhp4W(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder hVaed5y2nmkB4yI8o17()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
