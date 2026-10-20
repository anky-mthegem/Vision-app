using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoClearCellNameAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearCellNameAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (POMJeEsjznWAfnq0IBgr() ? 4 : 2);
			UndoClearCellNameAction undoClearCellNameAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoClearCellNameAction = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							undoClearCellNameAction.B2wlJWNepu = ((CvsCellCollection)ztstAAscsuxbgCo2CIhe(YhvD9GscwR8oVQWMZeiu(undoClearCellNameAction.qKUlTeXrEm))).CreateCogCellResultList(undoClearCellNameAction.A8RlBvAeR2);
							_ = 1;
							if (!POMJeEsjznWAfnq0IBgr())
							{
								num3 = 3;
								if (1 == 0)
								{
									goto IL_0085;
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
							num3 = 9;
						}
						goto IL_0103;
						IL_009f:
						_003C_003Eu__1 = default;
						num3 = 6;
						if (POMJeEsjznWAfnq0IBgr())
						{
							goto IL_00bb;
						}
						goto IL_0103;
						IL_0085:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						if (1 == 0)
						{
							goto IL_009f;
						}
						goto IL_0103;
						IL_0103:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 9:
								goto IL_009f;
							case 6:
								goto IL_00bb;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto case 2;
								}
								goto case 10;
							case 4:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 5;
								if (true)
								{
									continue;
								}
								return;
							case 1:
								return;
							case 0:
							case 3:
								awaiter = sELsvPscLXVVXOGeqyRm(J381NNschWLwhpqgSF8A());
								num3 = 8;
								continue;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0046;
							}
							break;
						}
						goto IL_0085;
						IL_00bb:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_0103;
						end_IL_0046:;
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
		internal static object YhvD9GscwR8oVQWMZeiu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ztstAAscsuxbgCo2CIhe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J381NNschWLwhpqgSF8A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sELsvPscLXVVXOGeqyRm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B9joGPsj8I5T5sAOoKME()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool POMJeEsjznWAfnq0IBgr()
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
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearCellNameAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kQ9ui7sc96EhRXiDiLQv();
			int num = (bGCSmLscSND0HxoGwO7P() ? 4 : 2);
			UndoClearCellNameAction undoClearCellNameAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoClearCellNameAction = _003C_003E4__this;
					num = 3;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCogCellResult>.Enumerator enumerator = undoClearCellNameAction.B2wlJWNepu.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCogCellResult current = enumerator.Current;
									bGCSmLscSND0HxoGwO7P();
									int num3;
									if (kQ9ui7sc96EhRXiDiLQv())
									{
										num3 = 2;
										if (bGCSmLscSND0HxoGwO7P())
										{
											goto IL_008f;
										}
									}
									else
									{
										num3 = 3;
									}
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										continue;
									}
									goto IL_008f;
									IL_008f:
									T2rg2OscV09rOPvXFMq1(VZw35IscvXUUXII6h3CL(D9uLZQscEkULutvDK9tD(undoClearCellNameAction.qKUlTeXrEm)), new CvsCellLocation((string)WaeJncscH9EapWpsEMXr(current)));
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = geaVTqscDjNdnY1B6ZJ4(mT9xiFscAZ748msvD8Rt());
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
				default:
					num = 5;
					continue;
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
		internal static object D9uLZQscEkULutvDK9tD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VZw35IscvXUUXII6h3CL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WaeJncscH9EapWpsEMXr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T2rg2OscV09rOPvXFMq1(object P_0, CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellInfo(location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mT9xiFscAZ748msvD8Rt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter geaVTqscDjNdnY1B6ZJ4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kQ9ui7sc96EhRXiDiLQv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bGCSmLscSND0HxoGwO7P()
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
	private struct _003CRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearCellNameAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoClearCellNameAction undoClearCellNameAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					undoClearCellNameAction = _003C_003E4__this;
					INGcJNscTkgo6ZxKFVCL();
					num = ((!FIli3sscUNdpH8S3DiXF()) ? 1 : 5);
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCogCellResult>.Enumerator enumerator = undoClearCellNameAction.B2wlJWNepu.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCogCellResult current = enumerator.Current;
									FIli3sscUNdpH8S3DiXF();
									switch (INGcJNscTkgo6ZxKFVCL() ? 3 : 2)
									{
									case 0:
									case 2:
										z6eyAXscjqs2WXLknbNX(undoClearCellNameAction.qKUlTeXrEm.CogSocket.Sheet, new CvsCellInfo(new CvsCellLocation((string)o6CIk3scd45hQugJy5rq(current)), (string)jg72ilscimhNODEPAxTq(current), AeBhn4scqbAOLccbYHS1(current), yv0QqpscBv3CZo48fBe6(current)));
										break;
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
							awaiter = ((Task)OOSJEGsccSoLQgY0s9ef()).GetAwaiter();
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
		internal static object o6CIk3scd45hQugJy5rq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jg72ilscimhNODEPAxTq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AeBhn4scqbAOLccbYHS1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Input;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yv0QqpscBv3CZo48fBe6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Output;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void z6eyAXscjqs2WXLknbNX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).SetCellInfo((CvsCellInfo)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OOSJEGsccSoLQgY0s9ef()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FIli3sscUNdpH8S3DiXF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool INGcJNscTkgo6ZxKFVCL()
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

		public UndoClearCellNameAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CpckbUscWQnbkcLZsypE();
			int num = ((!bOalA7sc27cunGhyvxNS()) ? 2 : 4);
			UndoClearCellNameAction undoClearCellNameAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<CvsCogCellResult>.Enumerator enumerator = undoClearCellNameAction.B2wlJWNepu.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CvsCogCellResult current = enumerator.Current;
									bOalA7sc27cunGhyvxNS();
									int num3;
									if (!CpckbUscWQnbkcLZsypE())
									{
										num3 = 2;
										if (1 == 0)
										{
											goto IL_008f;
										}
									}
									else
									{
										num3 = 3;
									}
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										continue;
									}
									goto IL_008f;
									IL_008f:
									((CvsCogSocketSheet)nOh7tJsctEP9JG5Iv6re(DoPuY4sc7HDw4Bitseu3(undoClearCellNameAction.qKUlTeXrEm))).SetCellInfo(new CvsCellInfo(new CvsCellLocation(current.Location), (string)AVXXnascCB7TmsiLfWkZ(current), OdqPC9scKcgfhwccDf5J(current), qUgi8Tsc5aQqYCLW4ptO(current)));
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							awaiter = lI2i1UscPfNKHOe7brph(WX62JGscotciukwi3PvO());
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				undoClearCellNameAction = _003C_003E4__this;
				num = 5;
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
		internal static object DoPuY4sc7HDw4Bitseu3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nOh7tJsctEP9JG5Iv6re(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AVXXnascCB7TmsiLfWkZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OdqPC9scKcgfhwccDf5J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Input;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qUgi8Tsc5aQqYCLW4ptO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Output;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WX62JGscotciukwi3PvO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lI2i1UscPfNKHOe7brph(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bOalA7sc27cunGhyvxNS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CpckbUscWQnbkcLZsypE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight qKUlTeXrEm;

	private readonly CvsCellRange A8RlBvAeR2;

	private List<CvsCogCellResult> B2wlJWNepu;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)if3lxw7Va1KwjuNF3Fg(uhMnSK7HkWY13uFGVOW(), A8RlBvAeR2.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoClearCellNameAction(CvsInSight inSight, CvsCellRange cellRange)
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
			case 4:
				base._002Ector();
				break;
			case 5:
				n6Wx9r7ApPHQ1q9e8uL();
				_ = 0;
				num = ((!MC6F9L7Eai4rjjxCJ5o()) ? 6 : 0);
				continue;
			case 2:
				A8RlBvAeR2 = cellRange;
				num = 7;
				continue;
			case 0:
			case 1:
				A8RlBvAeR2 = CvsCellRange.Empty;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 7:
				return;
			}
			qKUlTeXrEm = inSight;
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MC6F9L7Eai4rjjxCJ5o();
		int num = (aCSaUs7va65KOQiB91d() ? 2 : 5);
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = bfhWM07D2vmpCn8Dvly();
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (MC6F9L7Eai4rjjxCJ5o())
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
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!MC6F9L7Eai4rjjxCJ5o()) ? 2 : 5);
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!aCSaUs7va65KOQiB91d())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = bfhWM07D2vmpCn8Dvly();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__8))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = bfhWM07D2vmpCn8Dvly();
				aCSaUs7va65KOQiB91d();
				num = (MC6F9L7Eai4rjjxCJ5o() ? 4 : 0);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
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
		_ = 0;
		int num;
		if (MC6F9L7Eai4rjjxCJ5o())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (aCSaUs7va65KOQiB91d())
			{
			}
		}
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = bfhWM07D2vmpCn8Dvly();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
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
	internal static object uhMnSK7HkWY13uFGVOW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionClearCellNames;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object if3lxw7Va1KwjuNF3Fg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MC6F9L7Eai4rjjxCJ5o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aCSaUs7va65KOQiB91d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n6Wx9r7ApPHQ1q9e8uL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder bfhWM07D2vmpCn8Dvly()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
