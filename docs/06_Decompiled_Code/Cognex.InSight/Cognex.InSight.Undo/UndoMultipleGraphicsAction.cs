using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

internal class UndoMultipleGraphicsAction : UndoAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoMultipleGraphicsAction _003C_003E4__this;

		private List<(CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)>.Enumerator _003C_003E7__wrap1;

		private CvsCellRange _003CcellRange_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			UndoMultipleGraphicsAction undoMultipleGraphicsAction = default;
			TaskAwaiter<byte[]> awaiter = default;
			(CvsCogEditInfo, CvsCogEditingShape, CvsCogShape) current = default;
			byte[] result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = undoMultipleGraphicsAction.kaQgivbLVZ.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_01df;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 4;
							goto IL_0184;
							IL_0112:
							_003C_003Eu__1 = awaiter;
							num3 = 6;
							goto IL_0184;
							IL_01df:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current = _003C_003E7__wrap1.Current;
								_ = 1;
								if (!VelyXNsKQSoR78Lcc8Is())
								{
									num3 = 5;
								}
								else
								{
									num3 = 7;
									if (!UyJAfqsKMuo6ZeTsrVK8())
									{
										goto IL_0112;
									}
								}
								goto IL_0184;
							}
							goto end_IL_0045;
							IL_0184:
							while (true)
							{
								switch (num3)
								{
								case 1:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 7:
								case 9:
									undoMultipleGraphicsAction.tBigdBxSZN.Add((_003CcellRange_003E5__3, result));
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 5:
									_003CcellRange_003E5__3 = new CvsCellRange((string)XEXu0NsKlPqapmEfJTyZ(current.Item1));
									awaiter = ((CvsCogSocketSheet)XEueMgsKuvlJEShoSlH2(KYEGZ7sKeYOKd2qt0Fr2(undoMultipleGraphicsAction.zbVgN95Ejs))).CopyCellsAsync(_003CcellRange_003E5__3).GetAwaiter();
									num3 = 2;
									if (VelyXNsKQSoR78Lcc8Is())
									{
									}
									continue;
								case 10:
									result = awaiter.GetResult();
									goto case 7;
								case 11:
									break;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 10;
								case 3:
									num2 = (_003C_003E1__state = 0);
									num3 = 11;
									continue;
								case 8:
									return;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto IL_01df;
								case 12:
									goto IL_01df;
								}
								break;
							}
							goto IL_0112;
							end_IL_0045:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
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
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (UyJAfqsKMuo6ZeTsrVK8())
					{
						num = 4;
						if (UyJAfqsKMuo6ZeTsrVK8())
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 1:
				case 4:
					undoMultipleGraphicsAction = _003C_003E4__this;
					goto case 0;
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
		internal static object XEXu0NsKlPqapmEfJTyZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KYEGZ7sKeYOKd2qt0Fr2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XEueMgsKuvlJEShoSlH2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UyJAfqsKMuo6ZeTsrVK8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VelyXNsKQSoR78Lcc8Is()
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

		public UndoMultipleGraphicsAction _003C_003E4__this;

		private List<(CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)>.Enumerator _003C_003E7__wrap1;

		private (CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape) _003Cupdate_003E5__3;

		private CvsCellRange _003CcellRange_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NAS5JqsKIHclcgGIi61r();
			int num = (pFxhbtsKRJ6R8Sqh7yZS() ? 3 : 5);
			UndoMultipleGraphicsAction undoMultipleGraphicsAction = default;
			TaskAwaiter<byte[]> awaiter2 = default;
			TaskAwaiter awaiter3 = default;
			byte[] result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					undoMultipleGraphicsAction = _003C_003E4__this;
					num = 4;
					break;
				case 4:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						if ((uint)num2 > 1u)
						{
							if (num2 == 2)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03fc;
							}
							_003C_003E7__wrap1 = undoMultipleGraphicsAction.kaQgivbLVZ.GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 4;
									if (!NAS5JqsKIHclcgGIi61r())
									{
										goto IL_00a4;
									}
								}
								else
								{
									awaiter2 = _003C_003Eu__2;
									num3 = 19;
									if (1 == 0)
									{
										goto IL_0358;
									}
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
							}
							goto IL_0155;
							IL_0233:
							_003CcellRange_003E5__4 = new CvsCellRange((string)cP1g1BsKb5V7jdNmpWq1(_003Cupdate_003E5__3.editInfo));
							awaiter2 = ((CvsCogSocketSheet)qjTPopsKnyGBsEFaxb0F(QOFb8ksKaGNpblnXcrgx(undoMultipleGraphicsAction.zbVgN95Ejs))).CopyCellsAsync(_003CcellRange_003E5__4).GetAwaiter();
							num3 = 10;
							goto IL_0155;
							IL_0155:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 11:
									break;
								case 18:
									_003C_003Eu__1 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 14;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 5;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 5:
									goto IL_013c;
								default:
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 10;
								case 10:
									if (!awaiter2.IsCompleted)
									{
										goto IL_01c6;
									}
									goto case 2;
								case 2:
								case 15:
									result = awaiter2.GetResult();
									num3 = 6;
									continue;
								case 12:
									num2 = (_003C_003E1__state = -1);
									goto case 2;
								case 19:
									_003C_003Eu__2 = default;
									num3 = 12;
									continue;
								case 16:
									_003Cupdate_003E5__3 = default;
									num3 = 20;
									continue;
								case 9:
									goto IL_0233;
								case 6:
									undoMultipleGraphicsAction.y7BguO3hBh.Add((_003CcellRange_003E5__4, result));
									num3 = 16;
									continue;
								case 7:
									if (!awaiter3.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto IL_013c;
								case 17:
									if (_003Cupdate_003E5__3.originalShape == null || _003Cupdate_003E5__3.editedShape == null)
									{
										goto case 16;
									}
									num3 = 13;
									if (NAS5JqsKIHclcgGIi61r())
									{
										continue;
									}
									goto case 13;
								case 13:
									awaiter3 = ((Task)SqOhY5sKXhLut02uix1N(qjTPopsKnyGBsEFaxb0F(QOFb8ksKaGNpblnXcrgx(undoMultipleGraphicsAction.zbVgN95Ejs)), NHchgGsKGQHToxi6FWNJ(_003Cupdate_003E5__3.originalShape), _003Cupdate_003E5__3.editedShape)).GetAwaiter();
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 14:
									return;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 18;
									continue;
								case 4:
								case 20:
									goto IL_0358;
								}
								break;
								IL_01c6:
								_ = 1;
								num3 = ((!pFxhbtsKRJ6R8Sqh7yZS()) ? 1 : 2);
							}
							goto IL_00a4;
							IL_0358:
							if (_003C_003E7__wrap1.MoveNext())
							{
								_003Cupdate_003E5__3 = _003C_003E7__wrap1.Current;
								num3 = 17;
								if (1 == 0)
								{
									goto IL_013c;
								}
								goto IL_0155;
							}
							goto end_IL_0087;
							IL_013c:
							awaiter3.GetResult();
							goto IL_0233;
							IL_00a4:
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							num3 = 3;
							goto IL_0155;
							end_IL_0087:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
						awaiter = ((CvsCogSocketSheet)qjTPopsKnyGBsEFaxb0F(QOFb8ksKaGNpblnXcrgx(undoMultipleGraphicsAction.zbVgN95Ejs))).RunAsync(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03fc;
						IL_03fc:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
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
		internal static object QOFb8ksKaGNpblnXcrgx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qjTPopsKnyGBsEFaxb0F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NHchgGsKGQHToxi6FWNJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SqOhY5sKXhLut02uix1N(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).ApplyEditableObjectAsync((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cP1g1BsKb5V7jdNmpWq1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NAS5JqsKIHclcgGIi61r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pFxhbtsKRJ6R8Sqh7yZS()
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

		public UndoMultipleGraphicsAction _003C_003E4__this;

		private List<(CvsCellRange cellRange, byte[] buffer)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nu4dv2sKpIftOWpwersM();
			int num;
			if (l5R8pysK6gFdNgjRBofr())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_02b6;
			IL_02b6:
			UndoMultipleGraphicsAction undoMultipleGraphicsAction = default;
			TaskAwaiter awaiter2 = default;
			(CvsCellRange, byte[]) current = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 3:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0273;
							}
							_003C_003E7__wrap1 = undoMultipleGraphicsAction.y7BguO3hBh.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_01cf;
							}
							awaiter2 = _003C_003Eu__1;
							int num3 = 9;
							goto IL_00ee;
							IL_00b9:
							if (awaiter2.IsCompleted)
							{
								goto IL_01a9;
							}
							goto IL_01ba;
							IL_01cf:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current = _003C_003E7__wrap1.Current;
								_ = 0;
								if (l5R8pysK6gFdNgjRBofr())
								{
									num3 = 7;
									if (nu4dv2sKpIftOWpwersM())
									{
										goto IL_00b9;
									}
								}
								else
								{
									num3 = 4;
								}
								goto IL_00ee;
							}
							goto end_IL_0086;
							IL_01ba:
							num2 = (_003C_003E1__state = 0);
							num3 = 6;
							if (true)
							{
								goto IL_00ee;
							}
							goto IL_01cf;
							IL_01a9:
							awaiter2.GetResult();
							num3 = 10;
							goto IL_00ee;
							IL_00ee:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 6:
									_003C_003Eu__1 = awaiter2;
									goto case 5;
								default:
									num3 = 5;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 3;
									if (nu4dv2sKpIftOWpwersM())
									{
									}
									continue;
								case 3:
									return;
								case 0:
								case 7:
									awaiter2 = undoMultipleGraphicsAction.zbVgN95Ejs.PasteCellsAsync(current.Item1, current.Item2, cutFromSameSheet: false, runSheet: false).GetAwaiter();
									num3 = 1;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									continue;
								case 8:
									goto IL_01a9;
								case 2:
								case 4:
									goto IL_01ba;
								case 10:
									goto IL_01cf;
								}
								break;
							}
							goto IL_00b9;
							end_IL_0086:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
						awaiter = ((CvsCogSocketSheet)Yq6h9ysK4JIAiqV15dVS(bHZlNrsK0JsE2IiLcKAN(undoMultipleGraphicsAction.zbVgN95Ejs))).RunAsync(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0273;
						IL_0273:
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
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			undoMultipleGraphicsAction = _003C_003E4__this;
			num = 3;
			goto IL_02b6;
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
		internal static object bHZlNrsK0JsE2IiLcKAN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yq6h9ysK4JIAiqV15dVS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l5R8pysK6gFdNgjRBofr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nu4dv2sKpIftOWpwersM()
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

		public UndoMultipleGraphicsAction _003C_003E4__this;

		private List<(CvsCellRange cellRange, byte[] buffer)>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoMultipleGraphicsAction undoMultipleGraphicsAction = default;
			TaskAwaiter awaiter2 = default;
			(CvsCellRange, byte[]) current = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					undoMultipleGraphicsAction = _003C_003E4__this;
					_ = 0;
					num = ((!HwSyi6sKkFfXX8fgxD3v()) ? 1 : 4);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0250;
							}
							_003C_003E7__wrap1 = undoMultipleGraphicsAction.tBigdBxSZN.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_01ac;
							}
							awaiter2 = _003C_003Eu__1;
							goto IL_016d;
							IL_0132:
							int num3;
							while (true)
							{
								IL_0132_2:
								switch (num3)
								{
								case 4:
									return;
								case 1:
									while (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_ = 1;
										if (myH0mPsKf45sIT4faeve())
										{
											num3 = 8;
											if (!HwSyi6sKkFfXX8fgxD3v())
											{
												continue;
											}
										}
										else
										{
											num3 = 9;
										}
										goto IL_0132_2;
									}
									goto case 7;
								case 7:
									awaiter2.GetResult();
									num3 = 10;
									continue;
								case 2:
								case 9:
									_003C_003Eu__1 = awaiter2;
									num3 = 3;
									if (!myH0mPsKf45sIT4faeve())
									{
										continue;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 5:
								case 8:
									break;
								case 6:
									awaiter2 = gs7YBbsKmWNhx0EYddn6(XpO9mUsKFbZAMfHP2GLg(undoMultipleGraphicsAction.zbVgN95Ejs, current.Item1, current.Item2, false, false));
									num3 = 1;
									continue;
								case 10:
									goto IL_01ac;
								}
								break;
							}
							goto IL_016d;
							IL_01ac:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current = _003C_003E7__wrap1.Current;
								num3 = 6;
								goto IL_0132;
							}
							goto end_IL_0069;
							IL_016d:
							_003C_003Eu__1 = default;
							num3 = 0;
							goto IL_0132;
							end_IL_0069:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
						awaiter = ((CvsCogSocketSheet)J69mWOsKgZtdvgeAaeoq(zXHBp2sKy2HNRLRynyrV(undoMultipleGraphicsAction.zbVgN95Ejs))).RunAsync(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0250;
						IL_0250:
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
		internal static object XpO9mUsKFbZAMfHP2GLg(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gs7YBbsKmWNhx0EYddn6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zXHBp2sKy2HNRLRynyrV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J69mWOsKgZtdvgeAaeoq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HwSyi6sKkFfXX8fgxD3v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool myH0mPsKf45sIT4faeve()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight zbVgN95Ejs;

	private readonly List<(CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)> kaQgivbLVZ;

	private readonly List<(CvsCellRange cellRange, byte[] buffer)> tBigdBxSZN;

	private readonly List<(CvsCellRange cellRange, byte[] buffer)> y7BguO3hBh;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			quIrcLCHd3WPg7Ov6M6();
			int num = ((!P74BVSCvR2FnstnKkkQ()) ? 3 : 2);
			List<(CvsCogEditInfo, CvsCogEditingShape, CvsCogShape)>.Enumerator enumerator = default;
			List<string> list = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					enumerator = kaQgivbLVZ.GetEnumerator();
					break;
				default:
					goto IL_005f;
				case 0:
				case 2:
					list = new List<string>();
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_005f:
				num = 4;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					(CvsCogEditInfo, CvsCogEditingShape, CvsCogShape) current = enumerator.Current;
					_ = 1;
					switch (quIrcLCHd3WPg7Ov6M6() ? 3 : 2)
					{
					case 0:
					case 2:
						list.Add((string)MS8CMKCV2ScUkybkaUI(current.Item1));
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
			}
			return (string)NYTDhwCUJq9DmQgMRel(OIJuTECASTqg01Cmb9d(), string.Join((string)NPu3vpCDploqH49T6hD(7604), list));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoMultipleGraphicsAction(CvsInSight inSight, List<(CvsCogEditInfo editInfo, CvsCogEditingShape originalShape, CvsCogShape editedShape)> updates)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		tBigdBxSZN = new List<(CvsCellRange, byte[])>();
		y7BguO3hBh = new List<(CvsCellRange, byte[])>();
		base._002Ector();
		zbVgN95Ejs = inSight;
		kaQgivbLVZ = updates;
		foreach (var item in kaQgivbLVZ)
		{
			_ = item;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__7))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!P74BVSCvR2FnstnKkkQ()) ? 3 : 2);
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
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
		int num;
		if (!quIrcLCHd3WPg7Ov6M6())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_00bf;
			}
		}
		goto IL_008c;
		IL_008c:
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = wUoHmECTVRLmxOk8AOo();
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (quIrcLCHd3WPg7Ov6M6())
				{
				}
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				goto IL_00bf;
			}
			break;
		}
		goto IL_0026;
		IL_00bf:
		return stateMachine._003C_003Et__builder.Task;
		IL_0026:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!P74BVSCvR2FnstnKkkQ()) ? 4 : 5);
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = wUoHmECTVRLmxOk8AOo();
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (P74BVSCvR2FnstnKkkQ() ? 1 : 2);
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (P74BVSCvR2FnstnKkkQ())
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
	internal static object MS8CMKCV2ScUkybkaUI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditInfo)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OIJuTECASTqg01Cmb9d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionGraphicChange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NPu3vpCDploqH49T6hD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NYTDhwCUJq9DmQgMRel(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool P74BVSCvR2FnstnKkkQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool quIrcLCHd3WPg7Ov6M6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder wUoHmECTVRLmxOk8AOo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
