using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoRemoveImages : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Vl6frEdO7bI0wWX6hwp();
			int num = ((!hvljFgd0lZAUva6Ag9f()) ? 5 : 4);
			UndoRemoveImages undoRemoveImages = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoRemoveImages = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)EXrkeSdH2TnEx3W4ISr(undoRemoveImages.x1d2rJpj9G);
							num3 = 9;
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
							case 0:
								awaiter = v5QW40dYLmHeuT0CqPi(classifier.FQt30A3AL(imagesFromIds, (string)LbosK8dT9Gre77V53u6()));
								num3 = 10;
								continue;
							case 6:
								return;
							case 7:
								return;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (!Vl6frEdO7bI0wWX6hwp())
								{
									continue;
								}
								goto case 9;
							case 9:
								if (classifier != null)
								{
									imagesFromIds = classifier.GetImagesFromIds(undoRemoveImages.zWD2icURfK);
									num3 = 0;
									continue;
								}
								goto end_IL_00d0;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								do
								{
									num2 = (_003C_003E1__state = 0);
									Vl6frEdO7bI0wWX6hwp();
									if (!hvljFgd0lZAUva6Ag9f())
									{
										num3 = 7;
										continue;
									}
									num3 = 2;
									break;
								}
								while (1 == 0);
								continue;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00d0:
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
		internal static object EXrkeSdH2TnEx3W4ISr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LbosK8dT9Gre77V53u6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.SelectedImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter v5QW40dYLmHeuT0CqPi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hvljFgd0lZAUva6Ag9f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vl6frEdO7bI0wWX6hwp()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveImages _003C_003E4__this;

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
			if (!MfjTQhdKxXiUAxSJXYP())
			{
				num = 1;
				if (MfjTQhdKxXiUAxSJXYP())
				{
				}
			}
			else
			{
				num = 5;
			}
			UndoRemoveImages undoRemoveImages = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoRemoveImages = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)tei4SfdCgyONyUVrov6(undoRemoveImages.x1d2rJpj9G);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 0:
								awaiter = afcs4xdNLBRrV6Wc2OV(classifier.FQt30A3AL(imagesFromIds, (string)Q8vJopdAHN8o65yIuaR()));
								num3 = 6;
								if (pmiTb8dJsa51ncEQaKY())
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									MfjTQhdKxXiUAxSJXYP();
									num3 = (pmiTb8dJsa51ncEQaKY() ? 10 : 7);
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 2:
								return;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (pmiTb8dJsa51ncEQaKY())
								{
									continue;
								}
								goto case 1;
							case 1:
								if (classifier != null)
								{
									imagesFromIds = classifier.GetImagesFromIds(undoRemoveImages.zWD2icURfK);
									num3 = 0;
									continue;
								}
								goto end_IL_0099;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0099:
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
		internal static object tei4SfdCgyONyUVrov6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q8vJopdAHN8o65yIuaR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.SelectedImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter afcs4xdNLBRrV6Wc2OV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pmiTb8dJsa51ncEQaKY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MfjTQhdKxXiUAxSJXYP()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveImages _003C_003E4__this;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			UndoRemoveImages undoRemoveImages = default;
			CvsCellLocation location = default;
			TaskAwaiter<byte[]> awaiter = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!cUOSIwdw6l8SL6SQJIA()) ? 4 : 0);
					continue;
				case 0:
				case 1:
					undoRemoveImages = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							location = ztfox6dG3ffeCCIFtyt(undoRemoveImages.x1d2rJpj9G);
							cUOSIwdw6l8SL6SQJIA();
							num3 = (Ub51psdpiWoqk0sNM1H() ? 7 : 5);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 5:
								if (location.IsValid)
								{
									num3 = 6;
									continue;
								}
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 9;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								if (!awaiter.IsCompleted)
								{
									goto case 3;
								}
								goto case 2;
							case 3:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 6:
								awaiter = ((CvsCogSocketSheet)OJaddHdjYdRU0xxAa9Z(SZ0vsVdRZGIOQ4AbLR9(undoRemoveImages.kUy2CSl1Z1))).CopyCellsAsync(new CvsCellRange(location)).GetAwaiter();
								num3 = 10;
								if (cUOSIwdw6l8SL6SQJIA())
								{
									continue;
								}
								return;
							case 9:
								return;
							case 2:
								result = awaiter.GetResult();
								num3 = 11;
								continue;
							case 11:
								undoRemoveImages.JGV26TsD2Q = result;
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (Ub51psdpiWoqk0sNM1H())
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
		internal static CvsCellLocation ztfox6dG3ffeCCIFtyt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetCellLocation();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SZ0vsVdRZGIOQ4AbLR9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OJaddHdjYdRU0xxAa9Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cUOSIwdw6l8SL6SQJIA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ub51psdpiWoqk0sNM1H()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoRemoveImages _003C_003E4__this;

		private Classifier _003Cclassifier_003E5__2;

		private ITopLevelProgressableOperation _003Coperation_003E5__3;

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
			UndoRemoveImages undoRemoveImages = default;
			CvsCellLocation location = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					iqW1hFdILjU1O8Vnm6p();
					if (!pUFRHjdWhQUr3I57RYA())
					{
						num = 6;
						break;
					}
					num = 2;
					if (true)
					{
						break;
					}
					goto case 5;
				case 0:
					_003Cclassifier_003E5__2 = null;
					goto case 2;
				case 5:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003Cclassifier_003E5__2 = (Classifier)KbR8D4dbbTmY4SrgrMQ(undoRemoveImages.x1d2rJpj9G);
							location = lnWlpSdeUDVQQVNkUu4(undoRemoveImages.x1d2rJpj9G);
							IOperationProgressManager operationProgressManager = undoRemoveImages.x1d2rJpj9G.GetClassifier().OperationProgressManager;
							_003Coperation_003E5__3 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? Nf8Pc0d7kPrq3hO0085(operationProgressManager, hOH7RYdlr8uxm36Nggt(), Array.Empty<StepDescriptor>()) : null);
						}
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
									num3 = 14;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
								if (!iqW1hFdILjU1O8Vnm6p())
								{
									goto IL_0290;
								}
							}
							goto IL_0111;
							IL_0111:
							while (true)
							{
								switch (num3)
								{
								case 13:
									if (_003Cclassifier_003E5__2 != null)
									{
										num3 = 11;
										if (pUFRHjdWhQUr3I57RYA())
										{
										}
										continue;
									}
									goto end_IL_00a9;
								case 6:
									awaiter.GetResult();
									goto case 7;
								case 15:
									num2 = (_003C_003E1__state = -1);
									goto case 6;
								default:
									num3 = 6;
									continue;
								case 1:
									break;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 16;
									continue;
								case 3:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										num3 = 1;
										continue;
									}
									goto case 6;
								case 16:
									return;
								case 0:
									_003C_003Eu__1 = awaiter;
									num3 = 2;
									continue;
								case 14:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									continue;
								case 8:
									awaiter = ((CvsCogSocket)Mcn0bjdyQiJ9gIK9pbg(undoRemoveImages.kUy2CSl1Z1)).Sheet.InternalPasteCellsAsync(new CvsCellRange(location), undoRemoveImages.JGV26TsD2Q, cutFromSameSheet: false, runSheet: true).GetAwaiter();
									num3 = 3;
									continue;
								case 11:
									if (location.IsValid)
									{
										num3 = 8;
										continue;
									}
									goto end_IL_00a9;
								case 7:
								case 9:
									awaiter = kcQxaFdnoeIgM6nEGFH(_003Cclassifier_003E5__2.Refresh());
									num3 = 4;
									continue;
								case 5:
								case 10:
									return;
								case 4:
									goto end_IL_0111;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 15;
									continue;
								case 17:
									goto IL_02c5;
								}
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								num3 = (iqW1hFdILjU1O8Vnm6p() ? 10 : 7);
								continue;
								end_IL_0111:
								break;
							}
							goto IL_0290;
							IL_02c5:
							awaiter.GetResult();
							goto end_IL_00a9;
							IL_0290:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								num3 = 0;
								goto IL_0111;
							}
							goto IL_02c5;
							end_IL_00a9:;
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__3 != null)
							{
								CErLs6dffNPcwcIsg8y(_003Coperation_003E5__3);
							}
						}
						_003Coperation_003E5__3 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cclassifier_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					if (!pUFRHjdWhQUr3I57RYA())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 1:
				case 6:
					undoRemoveImages = _003C_003E4__this;
					num = 5;
					if (pUFRHjdWhQUr3I57RYA())
					{
					}
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
		internal static object KbR8D4dbbTmY4SrgrMQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation lnWlpSdeUDVQQVNkUu4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetCellLocation();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hOH7RYdlr8uxm36Nggt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UndoRemoveImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Nf8Pc0d7kPrq3hO0085(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Mcn0bjdyQiJ9gIK9pbg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kcQxaFdnoeIgM6nEGFH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CErLs6dffNPcwcIsg8y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iqW1hFdILjU1O8Vnm6p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pUFRHjdWhQUr3I57RYA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsInSight kUy2CSl1Z1;

	private IClassifierHandle x1d2rJpj9G;

	private string[] zWD2icURfK;

	private byte[] JGV26TsD2Q;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)ajxqxaMFKySyxjfogoI();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRemoveImages(CvsInSight insight, IClassifierHandle handle, IEnumerable<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector();
		kUy2CSl1Z1 = insight;
		x1d2rJpj9G = handle;
		zWD2icURfK = images.Select([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage img) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return img.ImageId;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__7))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				EjRug7MDfYXwqpkTnhO();
				if (!D4Ckk7M8ksnOsgy6to7())
				{
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				num = 5;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__8))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 3:
				stateMachine._003C_003Et__builder = wfW7QOMsCCCHEMD4vSN();
				EjRug7MDfYXwqpkTnhO();
				if (D4Ckk7M8ksnOsgy6to7())
				{
					num = 5;
					if (EjRug7MDfYXwqpkTnhO())
					{
						continue;
					}
					goto case 4;
				}
				num = 0;
				if (!D4Ckk7M8ksnOsgy6to7())
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
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__9))]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		D4Ckk7M8ksnOsgy6to7();
		int num = ((!EjRug7MDfYXwqpkTnhO()) ? 2 : 5);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DSaveState_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = wfW7QOMsCCCHEMD4vSN();
				goto case 1;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!D4Ckk7M8ksnOsgy6to7())
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
				goto case 3;
			case 3:
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
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__10 stateMachine = default;
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
			case 2:
				stateMachine._003C_003Et__builder = wfW7QOMsCCCHEMD4vSN();
				_ = 1;
				if (D4Ckk7M8ksnOsgy6to7())
				{
					num = 0;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (!D4Ckk7M8ksnOsgy6to7())
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
	internal static object ajxqxaMFKySyxjfogoI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RemoveImages;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EjRug7MDfYXwqpkTnhO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool D4Ckk7M8ksnOsgy6to7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder wfW7QOMsCCCHEMD4vSN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
