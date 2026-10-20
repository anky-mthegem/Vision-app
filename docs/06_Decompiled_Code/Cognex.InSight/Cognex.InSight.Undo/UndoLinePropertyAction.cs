using System;
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

public class UndoLinePropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eZxfQHsKjlZPwF6Dvcoq();
			int num;
			if (V1SpKCsKB2qVxk4ZLvHO())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_016d;
			IL_01b1:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_016d;
			IL_016d:
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_019a;
			case 0:
			case 4:
				goto IL_01b1;
			case 5:
				return;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = gN9qghsK2jTbCxoJx4iE(HMq5YxsKcqvie0lNnyY8());
					eZxfQHsKjlZPwF6Dvcoq();
					num3 = ((!V1SpKCsKB2qVxk4ZLvHO()) ? 2 : 5);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 1;
					if (1 == 0)
					{
						goto IL_00e0;
					}
				}
				goto IL_0075;
				IL_0075:
				while (true)
				{
					switch (num3)
					{
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						return;
					case 1:
						_003C_003Eu__1 = default;
						num3 = 7;
						continue;
					case 2:
						return;
					case 3:
						break;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 8:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						continue;
					case 0:
					case 5:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto case 9;
					case 9:
						awaiter.GetResult();
						goto end_IL_0075;
					}
					goto IL_00e0;
					continue;
					end_IL_0075:
					break;
				}
				goto end_IL_002a;
				IL_00e0:
				_003C_003Eu__1 = awaiter;
				num3 = 6;
				goto IL_0075;
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_019a;
			IL_019a:
			_003C_003Et__builder.SetResult();
			num = 5;
			if (true)
			{
				goto IL_016d;
			}
			goto IL_01b1;
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
		internal static object HMq5YxsKcqvie0lNnyY8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gN9qghsK2jTbCxoJx4iE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V1SpKCsKB2qVxk4ZLvHO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eZxfQHsKjlZPwF6Dvcoq()
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
	private struct _003CDo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLinePropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!L94NNasKW0WcdRCPIvVD()) ? 1 : 2);
			int num2 = default;
			UndoLinePropertyAction undoLinePropertyAction = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					if (L94NNasKW0WcdRCPIvVD())
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = iVxd4EsKtVvjyoK4Fvts(undoLinePropertyAction.Redo());
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!L94NNasKW0WcdRCPIvVD())
							{
								goto IL_00da;
							}
						}
						goto IL_0123;
						IL_00da:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0123;
						IL_0123:
						while (true)
						{
							switch (num3)
							{
							case 7:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (L94NNasKW0WcdRCPIvVD())
								{
									num3 = 6;
									if (L94NNasKW0WcdRCPIvVD())
									{
										continue;
									}
									goto case 2;
								}
								num3 = 0;
								continue;
							case 2:
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 5:
								return;
							case 1:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0123;
							}
							goto IL_00da;
							continue;
							end_IL_0123:
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
					goto default;
				case 4:
					undoLinePropertyAction = _003C_003E4__this;
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
		internal static TaskAwaiter iVxd4EsKtVvjyoK4Fvts(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L94NNasKW0WcdRCPIvVD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kL4OuwsK77eP1j9M1F0R()
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
	private struct _003CRedo_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLinePropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditLineloc_003E5__2;

		private CvsCellLocation _003ClabelLoc_003E5__3;

		private CvsCellLocation _003CgetterLoc_003E5__4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private int _003Ci_003E5__5;

		private TaskAwaiter<CvsCogEditInfo[]> _003C_003Eu__2;

		private CvsCogEditingObject _003CeditingObj_003E5__6;

		private TaskAwaiter<CvsCogEditingObject> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_051e;
			IL_001a:
			UndoLinePropertyAction undoLinePropertyAction = _003C_003E4__this;
			num = 0;
			if (false)
			{
				goto IL_002d;
			}
			goto IL_051e;
			IL_051e:
			CvsCogEditInfo[] result = default;
			int num2 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter3 = default;
			CvsCogEditingObject result2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 2:
					goto IL_002d;
				case 0:
					try
					{
						TaskAwaiter<object> awaiter2;
						TaskAwaiter<CvsCogEditInfo[]> awaiter;
						switch (num2)
						{
						default:
							_003CeditLineloc_003E5__2 = undoLinePropertyAction.DropLocation;
							_003CeditLineloc_003E5__2.Row++;
							awaiter2 = ((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).PutCellExpressionAsync(_003CeditLineloc_003E5__2, undoLinePropertyAction.BdVgHYBJ56).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00f5;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00f5;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01c0;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0257;
						case 3:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0338;
						case 4:
							break;
							IL_0338:
							result = awaiter.GetResult();
							if (result != null && result.Length != 0)
							{
								_003CeditingObj_003E5__6 = null;
								break;
							}
							goto end_IL_004a;
							IL_00f5:
							awaiter2.GetResult();
							_003ClabelLoc_003E5__3 = undoLinePropertyAction.DropLocation;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4 = _003ClabelLoc_003E5__3;
							_003CgetterLoc_003E5__4.Row++;
							_003Ci_003E5__5 = 0;
							goto IL_029f;
							IL_029f:
							if (_003Ci_003E5__5 < undoLinePropertyAction.wgsg0TtPgs.Length)
							{
								awaiter2 = ((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).PutCellExpressionAsync(_003ClabelLoc_003E5__3, undoLinePropertyAction.WMkgUs20WW[_003Ci_003E5__5]).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01c0;
							}
							((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).Run(true);
							awaiter = ((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).GetEditInfoAsync(_003CeditLineloc_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0338;
							IL_01c0:
							awaiter2.GetResult();
							awaiter2 = ((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).PutCellExpressionAsync(_003CgetterLoc_003E5__4, (string)p5Dm2OsKPonruwiCUgBC(undoLinePropertyAction.wgsg0TtPgs[_003Ci_003E5__5], _003CeditLineloc_003E5__2.ToString())).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0257;
							IL_0257:
							awaiter2.GetResult();
							_003Ci_003E5__5++;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4.Column++;
							goto IL_029f;
						}
						try
						{
							int num3;
							if (num2 != 4)
							{
								JCalWksKCZso2KQA0719();
								if (!L1skiHsKKMG7SKAcOU5b())
								{
									num3 = 2;
									if (false)
									{
										return;
									}
								}
								else
								{
									num3 = 5;
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								num3 = 9;
							}
							while (true)
							{
								switch (num3)
								{
								case 7:
									return;
								case 3:
									num2 = (_003C_003E1__state = 4);
									num3 = 6;
									continue;
								case 4:
									result2 = awaiter3.GetResult();
									num3 = 10;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 1:
								case 5:
									if (!awaiter3.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 4;
								case 0:
								case 2:
									awaiter3 = ((CvsCogSocketSheet)MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight))).EditEditableObjectAsync((string)h3vSnpsKYpHf6SqeMilX(result[0])).GetAwaiter();
									goto case 1;
								case 6:
									_003C_003Eu__3 = awaiter3;
									goto case 8;
								default:
									num3 = 8;
									continue;
								case 9:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									if (JCalWksKCZso2KQA0719())
									{
										continue;
									}
									break;
								case 10:
									break;
								}
								break;
							}
							_003CeditingObj_003E5__6 = result2;
						}
						catch (Exception)
						{
						}
						if (_003CeditingObj_003E5__6 is CvsCogEditingShape cvsCogEditingShape)
						{
							IQH6w2sKxqOadAQJnxJF(MsGF4QsKo6usDRN8D7Kh(Dnlvb9sK5vGXCdZgohGr(undoLinePropertyAction.InSight)), s16xS6sKNtZDHyehPiRr(cvsCogEditingShape), undoLinePropertyAction.s3lgKkkIom);
						}
						_003CeditingObj_003E5__6 = null;
						end_IL_004a:;
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
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_002d:
			num2 = _003C_003E1__state;
			_ = 0;
			num = ((!JCalWksKCZso2KQA0719()) ? 4 : 5);
			goto IL_051e;
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
		internal static object Dnlvb9sK5vGXCdZgohGr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MsGF4QsKo6usDRN8D7Kh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p5Dm2OsKPonruwiCUgBC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h3vSnpsKYpHf6SqeMilX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object s16xS6sKNtZDHyehPiRr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IQH6w2sKxqOadAQJnxJF(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JCalWksKCZso2KQA0719()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L1skiHsKKMG7SKAcOU5b()
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
	private struct _003CUndo_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLinePropertyAction _003C_003E4__this;

		private CvsCellRange[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			UndoLinePropertyAction undoLinePropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoLinePropertyAction.ModifiedCells;
							e3f03psK1JICS0d132KI();
							num3 = (DBAoM2sKrHdVVjLDqnUI() ? 13 : 11);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (1 == 0)
							{
								goto IL_01b8;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 14;
								}
								goto case 10;
							case 14:
								awaiter = ((CvsCogSocketSheet)z0lyUqsKOoTVY33Vp4fE(j5mJaSsK3icOJUgvkKHQ(undoLinePropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 5;
								continue;
							case 0:
							case 11:
								_003C_003E7__wrap1 = modifiedCells;
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								continue;
							case 2:
							case 4:
								if (_003C_003E7__wrap2 >= _003C_003E7__wrap1.Length)
								{
									num3 = 12;
									continue;
								}
								cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
								num3 = 7;
								continue;
							case 8:
								_003C_003E7__wrap2 = 0;
								num3 = 2;
								continue;
							case 7:
								cellRange = new CvsCellRange(undoLinePropertyAction.DropLocation.Row + cvsCellRange.Row, undoLinePropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								num3 = 14;
								if (!DBAoM2sKrHdVVjLDqnUI())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 10;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 10:
							case 13:
								awaiter.GetResult();
								_003C_003E7__wrap2++;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 3:
								return;
							case 9:
								break;
							default:
								num3 = 3;
								continue;
							case 15:
								undoLinePropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
								goto end_IL_01e0;
							}
							goto IL_01b8;
							continue;
							end_IL_01e0:
							break;
						}
						goto end_IL_0018;
						IL_01b8:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0018:;
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
					num2 = _003C_003E1__state;
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					undoLinePropertyAction = _003C_003E4__this;
					e3f03psK1JICS0d132KI();
					if (DBAoM2sKrHdVVjLDqnUI())
					{
						num = 5;
						if (!DBAoM2sKrHdVVjLDqnUI())
						{
							break;
						}
						goto case 1;
					}
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
		internal static object j5mJaSsK3icOJUgvkKHQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z0lyUqsKOoTVY33Vp4fE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e3f03psK1JICS0d132KI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DBAoM2sKrHdVVjLDqnUI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string[] WMkgUs20WW;

	private string[] wgsg0TtPgs;

	private CvsCellRange tFcgwfKmDm;

	private CvsCellRange ciAgRayjbo;

	private CvsCellRange YU3gsF6Uhv;

	private CvsCellRange GDmg6TS79o;

	private string BdVgHYBJ56;

	private CvsCogLine s3lgKkkIom;

	[CompilerGenerated]
	private CvsInSight b0qgE8wD5g;

	private CvsCellLocation Ll1gQJlNe1;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b0qgE8wD5g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b0qgE8wD5g = value;
		}
	}

	public CvsCellLocation DropLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ll1gQJlNe1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!SHd7AFCLS15QMd7ylMe())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					Ll1gQJlNe1 = value;
					goto case 2;
				default:
					num = 2;
					if (!SHd7AFCLS15QMd7ylMe())
					{
						break;
					}
					goto case 2;
				case 2:
					GDmg6TS79o = new CvsCellRange(Ll1gQJlNe1.Row + ciAgRayjbo.Row, Ll1gQJlNe1.Column + ciAgRayjbo.Column, ciAgRayjbo.Rows, ciAgRayjbo.Columns);
					num = 5;
					if (SGH6l9Ch8AVt8wPla9f())
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					if (value.IsValid)
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
		}
	}

	public CvsCellRange[] ModifiedCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange[2] { tFcgwfKmDm, YU3gsF6Uhv };
		}
	}

	public CvsCellRange ValuesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GDmg6TS79o;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DropLine;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoLinePropertyAction(string editLineExpression, CvsCogLine line)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!SHd7AFCLS15QMd7ylMe())
		{
			num = 7;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_01ae;
			}
		}
		goto IL_0052;
		IL_0052:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				GDmg6TS79o = CvsCellRange.Invalid;
				num = 5;
				continue;
			case 9:
				BdVgHYBJ56 = editLineExpression;
				goto case 3;
			default:
				num = 3;
				continue;
			case 11:
				YU3gsF6Uhv = new CvsCellRange(1, 0, 1, wgsg0TtPgs.Length + 1);
				num = 12;
				continue;
			case 1:
				ciAgRayjbo = new CvsCellRange(1, 1, 1, wgsg0TtPgs.Length);
				num = 11;
				continue;
			case 3:
				s3lgKkkIom = line;
				num = 4;
				continue;
			case 0:
			case 7:
				qFWAbqC9G5I5j8lFMHA();
				num = 8;
				continue;
			case 10:
				base._002Ector();
				num = 9;
				continue;
			case 5:
				Ll1gQJlNe1 = CvsCellLocation.Invalid;
				num = 10;
				continue;
			case 8:
				WMkgUs20WW = new string[4]
				{
					(string)TpjcOmCS7XDMSpHadt5(17094),
					(string)TpjcOmCS7XDMSpHadt5(17104),
					(string)TpjcOmCS7XDMSpHadt5(17114),
					(string)TpjcOmCS7XDMSpHadt5(17124)
				};
				wgsg0TtPgs = new string[4]
				{
					(string)TpjcOmCS7XDMSpHadt5(17134),
					(string)TpjcOmCS7XDMSpHadt5(17160),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(17186),
					(string)TpjcOmCS7XDMSpHadt5(17212)
				};
				goto case 2;
			case 4:
				break;
			case 12:
				return;
			}
			break;
		}
		goto IL_01ae;
		IL_01ae:
		tFcgwfKmDm = new CvsCellRange(0, 1, 1, WMkgUs20WW.Length);
		num = 1;
		goto IL_0052;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__23))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SHd7AFCLS15QMd7ylMe();
		int num;
		if (SGH6l9Ch8AVt8wPla9f())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!SGH6l9Ch8AVt8wPla9f())
			{
				goto IL_004a;
			}
		}
		goto IL_0082;
		IL_004a:
		_003CSaveState_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		if (!SGH6l9Ch8AVt8wPla9f())
		{
			goto IL_0068;
		}
		goto IL_0082;
		IL_0068:
		stateMachine._003C_003E1__state = -1;
		goto IL_004a;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = nQvqBBCE3Pg8D0Xv9il();
				goto IL_0068;
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0068;
			default:
				num = 3;
				continue;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_004a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__24))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!SGH6l9Ch8AVt8wPla9f()) ? 2 : 4);
		_003CDo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = nQvqBBCE3Pg8D0Xv9il();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__25))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRedo_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (SGH6l9Ch8AVt8wPla9f() ? 4 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__26))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!SGH6l9Ch8AVt8wPla9f())
		{
			goto IL_001e;
		}
		goto IL_005a;
		IL_001e:
		_003CUndo_003Ed__26 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		SHd7AFCLS15QMd7ylMe();
		if (SGH6l9Ch8AVt8wPla9f())
		{
			num = 1;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_008d;
			}
		}
		goto IL_005a;
		IL_008d:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto IL_008d;
			default:
				goto IL_008d;
			case 4:
				stateMachine._003C_003Et__builder = nQvqBBCE3Pg8D0Xv9il();
				num = 0;
				if (SGH6l9Ch8AVt8wPla9f())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qFWAbqC9G5I5j8lFMHA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TpjcOmCS7XDMSpHadt5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SGH6l9Ch8AVt8wPla9f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SHd7AFCLS15QMd7ylMe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nQvqBBCE3Pg8D0Xv9il()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
