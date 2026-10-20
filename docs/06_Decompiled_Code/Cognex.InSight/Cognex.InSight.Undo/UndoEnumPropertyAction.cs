using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoEnumPropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__25 : IAsyncStateMachine
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
			int num = 0;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = QHUCOrs2CrMmsh6XaeLH(wjQ8B5s2t0K0rCyFCo3K());
							num3 = 6;
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
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (w9Y5ces2W3hKQEHmNP94())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 3:
								return;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!mGO4Y5s27YI2jZNLF8wR()) ? 7 : 0);
									continue;
								}
								break;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
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
				case 0:
					break;
				case 5:
					return;
				}
				do
				{
					num2 = _003C_003E1__state;
					mGO4Y5s27YI2jZNLF8wR();
					if (!w9Y5ces2W3hKQEHmNP94())
					{
						num = 4;
						continue;
					}
					num = 3;
					if (w9Y5ces2W3hKQEHmNP94())
					{
						break;
					}
					return;
				}
				while (1 == 0);
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
		internal static object wjQ8B5s2t0K0rCyFCo3K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QHUCOrs2CrMmsh6XaeLH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w9Y5ces2W3hKQEHmNP94()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mGO4Y5s27YI2jZNLF8wR()
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
	private struct _003CDo_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEnumPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jmJNL7s2Kdj0GceX00xp();
			int num;
			if (!rpOnAUs253IilkQgr5wI())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (rpOnAUs253IilkQgr5wI())
				{
				}
			}
			int num2 = default;
			UndoEnumPropertyAction undoEnumPropertyAction = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = NJ92eds2Pi8My9Ka7Nrl(qluf3Is2oBq43HZMRaoN(undoEnumPropertyAction));
							_ = 1;
							num3 = (rpOnAUs253IilkQgr5wI() ? 3 : 2);
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
							case 0:
							case 2:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 8:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				undoEnumPropertyAction = _003C_003E4__this;
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
		internal static object qluf3Is2oBq43HZMRaoN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoEnumPropertyAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NJ92eds2Pi8My9Ka7Nrl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jmJNL7s2Kdj0GceX00xp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rpOnAUs253IilkQgr5wI()
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
	private struct _003CRedo_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEnumPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			R5BPk1s2NNMMdVAblb33();
			int num;
			if (wV9FMXs2Y4IIkmPWFcU8())
			{
				num = 1;
				if (R5BPk1s2NNMMdVAblb33())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0180;
			IL_01ab:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0180;
			IL_0180:
			UndoEnumPropertyAction undoEnumPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_01ab;
				case 3:
					undoEnumPropertyAction = _003C_003E4__this;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = mjAJ6fs2xanxedNiRmdk(undoEnumPropertyAction.InsertControlExpression(undoEnumPropertyAction.DropLocation));
					num3 = 7;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 0;
					if (false)
					{
						goto IL_0068;
					}
				}
				goto IL_0109;
				IL_0068:
				num2 = (_003C_003E1__state = 0);
				num3 = 4;
				if (!wV9FMXs2Y4IIkmPWFcU8())
				{
					goto IL_0081;
				}
				goto IL_0109;
				IL_0081:
				num2 = (_003C_003E1__state = -1);
				num3 = 9;
				if (R5BPk1s2NNMMdVAblb33())
				{
					goto IL_009a;
				}
				goto IL_0109;
				IL_0109:
				while (true)
				{
					switch (num3)
					{
					case 8:
						return;
					case 5:
						break;
					case 1:
					case 6:
						goto IL_0081;
					case 0:
						goto IL_009a;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							continue;
						}
						goto case 9;
					case 4:
						goto IL_00cc;
					case 2:
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 8;
						continue;
					case 9:
						awaiter.GetResult();
						goto end_IL_002e;
					}
					break;
					IL_00cc:
					_003C_003Eu__1 = awaiter;
					_ = 0;
					num3 = ((!wV9FMXs2Y4IIkmPWFcU8()) ? 1 : 2);
				}
				goto IL_0068;
				IL_009a:
				_003C_003Eu__1 = default;
				goto IL_0081;
				end_IL_002e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ab;
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
		internal static TaskAwaiter mjAJ6fs2xanxedNiRmdk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wV9FMXs2Y4IIkmPWFcU8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R5BPk1s2NNMMdVAblb33()
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
	private struct _003CInsertControlExpression_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellLocation location;

		public UndoEnumPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditEnumLoc_003E5__2;

		private CvsCellLocation _003CitemsLoc_003E5__3;

		private string _003Cexpression_003E5__4;

		private TaskAwaiter<object> _003C_003Eu__1;

		private CvsCellRange _003Crange_003E5__5;

		private List<string>.Enumerator _003C_003E7__wrap5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			TaskAwaiter<object> awaiter = default;
			UndoEnumPropertyAction undoEnumPropertyAction = default;
			string expression = default;
			string current = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (zWEqXDs21P94fDImqtSP())
					{
						break;
					}
					goto case 0;
				case 0:
					try
					{
						switch (num2)
						{
						default:
						{
							CvsCellLocation cvsCellLocation = location;
							_003CeditEnumLoc_003E5__2 = location;
							_003CeditEnumLoc_003E5__2.Row++;
							_003CitemsLoc_003E5__3 = _003CeditEnumLoc_003E5__2;
							_003CitemsLoc_003E5__3.Row++;
							awaiter = ((CvsCogSocketSheet)ER53ARs2ObESvyhaWedS(A3oHbQs23C7j0svIPppN(undoEnumPropertyAction.InSight))).PutCellExpressionAsync(cvsCellLocation, undoEnumPropertyAction.lvKlsBB85j).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00fb;
						}
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00fb;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01a2;
						case 2:
							try
							{
								int num3;
								if (num2 != 2)
								{
									num3 = 4;
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
									case 6:
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num3 = 5;
										continue;
									case 5:
										return;
									case 9:
										expression = (string)cIMajXs2M9smHcLRF20Q(YH3uUss2lS1Ujh9cxMhQ(16904), current);
										_ = 1;
										if (!XIv8lIs2rUJYGLTWyoHh())
										{
											num3 = 7;
											continue;
										}
										num3 = 0;
										if (zWEqXDs21P94fDImqtSP())
										{
											continue;
										}
										goto case 11;
									case 0:
									case 8:
										awaiter.GetResult();
										num3 = 11;
										if (!XIv8lIs2rUJYGLTWyoHh())
										{
											continue;
										}
										goto case 3;
									case 3:
										_003C_003Eu__1 = default;
										num3 = 1;
										continue;
									case 1:
										num2 = (_003C_003E1__state = -1);
										goto case 0;
									case 11:
										_003CitemsLoc_003E5__3.Row++;
										num3 = 12;
										continue;
									case 10:
										if (awaiter.IsCompleted)
										{
											goto case 0;
										}
										num3 = 6;
										if (zWEqXDs21P94fDImqtSP())
										{
											continue;
										}
										goto case 2;
									case 2:
									case 7:
										awaiter = ((CvsCogSocketSheet)ER53ARs2ObESvyhaWedS(A3oHbQs23C7j0svIPppN(undoEnumPropertyAction.InSight))).PutCellExpressionAsync(_003CitemsLoc_003E5__3, expression).GetAwaiter();
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										break;
									case 4:
									case 12:
										break;
									}
									if (_003C_003E7__wrap5.MoveNext())
									{
										current = _003C_003E7__wrap5.Current;
										num3 = 9;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)_003C_003E7__wrap5/*cast due to constrained. prefix*/).Dispose();
								}
							}
							_003C_003E7__wrap5 = default;
							_003Cexpression_003E5__4 = (string)cIMajXs2M9smHcLRF20Q(_003Cexpression_003E5__4, _003Crange_003E5__5.ToString());
							goto IL_03f7;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_01bd:
							if (undoEnumPropertyAction.xaqlEZQ5DH != null)
							{
								_003Crange_003E5__5 = new CvsCellRange(_003CitemsLoc_003E5__3.Row, _003CitemsLoc_003E5__3.Column, XmZ8TSs2QNVUSEUj1V7j(undoEnumPropertyAction.xaqlEZQ5DH), 1);
								_003C_003E7__wrap5 = undoEnumPropertyAction.xaqlEZQ5DH.GetEnumerator();
								goto case 2;
							}
							goto IL_03f7;
							IL_00fb:
							awaiter.GetResult();
							_003Cexpression_003E5__4 = undoEnumPropertyAction.DlVl6F0Wqu;
							if (undoEnumPropertyAction.vP9lKySs8k != null)
							{
								awaiter = ((CvsCogSocketSheet)ER53ARs2ObESvyhaWedS(undoEnumPropertyAction.InSight.CogSocket)).PutCellExpressionAsync(_003CitemsLoc_003E5__3, (string)cIMajXs2M9smHcLRF20Q(undoEnumPropertyAction.vP9lKySs8k, _003CeditEnumLoc_003E5__2.ToString())).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_01a2;
							}
							goto IL_01bd;
							IL_03f7:
							awaiter = ((CvsCogSocketSheet)ER53ARs2ObESvyhaWedS(A3oHbQs23C7j0svIPppN(undoEnumPropertyAction.InSight))).PutCellExpressionAsync(_003CeditEnumLoc_003E5__2, _003Cexpression_003E5__4).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
							IL_01a2:
							awaiter.GetResult();
							_003CitemsLoc_003E5__3.Row++;
							goto IL_01bd;
						}
						awaiter.GetResult();
						((CvsCogSocketSheet)ER53ARs2ObESvyhaWedS(A3oHbQs23C7j0svIPppN(undoEnumPropertyAction.InSight))).Run(true);
						if (undoEnumPropertyAction.lLolHEHX3X >= 0)
						{
							x0L0P6s2eN8S4sWBDB7G(undoEnumPropertyAction.InSight, _003CeditEnumLoc_003E5__2, undoEnumPropertyAction.lLolHEHX3X);
						}
						undoEnumPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cexpression_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 1:
				case 6:
					undoEnumPropertyAction = _003C_003E4__this;
					num = 0;
					break;
				case 3:
					_003Cexpression_003E5__4 = null;
					goto case 4;
				case 2:
					num2 = _003C_003E1__state;
					_ = 1;
					if (XIv8lIs2rUJYGLTWyoHh())
					{
						num = 5;
						break;
					}
					num = 6;
					if (1 == 0)
					{
						return;
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
		internal static object A3oHbQs23C7j0svIPppN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ER53ARs2ObESvyhaWedS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cIMajXs2M9smHcLRF20Q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int XmZ8TSs2QNVUSEUj1V7j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<string>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YH3uUss2lS1Ujh9cxMhQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void x0L0P6s2eN8S4sWBDB7G(object P_0, CvsCellLocation location, int index)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).SetListBoxIndex(location, index);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zWEqXDs21P94fDImqtSP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XIv8lIs2rUJYGLTWyoHh()
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
	private struct _003CUndo_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoEnumPropertyAction _003C_003E4__this;

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
			_ = 1;
			int num = (OsCqG0s2I96MC20FvDcR() ? 1 : 4);
			UndoEnumPropertyAction undoEnumPropertyAction = default;
			CvsCellRange[] array = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			CvsCellRange cvsCellRange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					if (m2OraPs2umK13O15Tk98())
					{
						continue;
					}
					goto case 2;
				case 2:
					undoEnumPropertyAction = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							array = (CvsCellRange[])cHviXRs2RcVxWqe2VcCR(undoEnumPropertyAction);
							num3 = 3;
							if (1 == 0)
							{
								goto IL_007a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_01cd;
						IL_01cd:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 13:
								break;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
							case 10:
								_003C_003E7__wrap2++;
								num3 = 1;
								continue;
							case 14:
								_003C_003E7__wrap1 = null;
								num3 = 15;
								continue;
							case 0:
								cellRange = new CvsCellRange(undoEnumPropertyAction.DropLocation.Row + cvsCellRange.Row, undoEnumPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								m2OraPs2umK13O15Tk98();
								if (!OsCqG0s2I96MC20FvDcR())
								{
									num3 = 12;
									if (m2OraPs2umK13O15Tk98())
									{
										continue;
									}
									goto case 11;
								}
								num3 = 8;
								continue;
							case 11:
								_003C_003E7__wrap2 = 0;
								num3 = 13;
								continue;
							case 4:
							case 12:
								awaiter = ((CvsCogSocketSheet)c7LoRms2aDhYgea5v4Ss(undoEnumPropertyAction.InSight.CogSocket)).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 5;
								continue;
							case 3:
								_003C_003E7__wrap1 = array;
								num3 = 11;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto IL_025c;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_025c;
							case 15:
								{
									undoEnumPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
									goto end_IL_01cd;
								}
								IL_025c:
								awaiter.GetResult();
								goto case 8;
							}
							goto IL_007a;
							continue;
							end_IL_01cd:
							break;
						}
						goto end_IL_0061;
						IL_007a:
						if (_003C_003E7__wrap2 >= _003C_003E7__wrap1.Length)
						{
							num3 = 14;
						}
						else
						{
							cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
							num3 = 0;
						}
						goto IL_01cd;
						end_IL_0061:;
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
		internal static object cHviXRs2RcVxWqe2VcCR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoEnumPropertyAction)P_0).ModifiedCells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c7LoRms2aDhYgea5v4Ss(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m2OraPs2umK13O15Tk98()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OsCqG0s2I96MC20FvDcR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellRange tQqlwF9BFt;

	private CvsCellRange DhklRNOOLX;

	private string lvKlsBB85j;

	private string DlVl6F0Wqu;

	private int lLolHEHX3X;

	private string vP9lKySs8k;

	private List<string> xaqlEZQ5DH;

	[CompilerGenerated]
	private CvsInSight f9xlQcwwOn;

	private CvsCellLocation PiDlNW6vsy;

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
			return f9xlQcwwOn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f9xlQcwwOn = value;
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
			return PiDlNW6vsy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sN8xZ77foyPCyAwMxRJ();
			int num;
			if (!MtvYHM7FIYpCxITqkwf())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_006c;
				}
			}
			goto IL_00ff;
			IL_00d4:
			CvsCellRange dhklRNOOLX = default;
			dhklRNOOLX.Column += PiDlNW6vsy.Column;
			goto IL_0093;
			IL_006c:
			if (value.IsValid)
			{
				num = 8;
				goto IL_00ff;
			}
			return;
			IL_0093:
			if (vP9lKySs8k == null)
			{
				goto IL_002a;
			}
			num = 2;
			if (false)
			{
				goto IL_00aa;
			}
			goto IL_00ff;
			IL_00aa:
			dhklRNOOLX = TbMHtd7Zv6EAf2gknK2(this);
			num = 1;
			goto IL_00ff;
			IL_00ff:
			while (true)
			{
				switch (num)
				{
				case 9:
					break;
				case 1:
					goto IL_0041;
				case 0:
				case 3:
					goto IL_006c;
				case 8:
					PiDlNW6vsy = value;
					num = 6;
					continue;
				case 7:
					goto IL_0093;
				case 6:
					goto IL_00aa;
				case 2:
					dhklRNOOLX.Row++;
					num = 9;
					continue;
				case 4:
				case 5:
					goto IL_00d4;
				default:
					num = 7;
					if (MtvYHM7FIYpCxITqkwf())
					{
					}
					continue;
				case 10:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			DhklRNOOLX = dhklRNOOLX;
			num = 10;
			if (!sN8xZ77foyPCyAwMxRJ())
			{
				goto IL_0041;
			}
			goto IL_00ff;
			IL_0041:
			dhklRNOOLX.Row += PiDlNW6vsy.Row;
			goto IL_00d4;
		}
	}

	public virtual CvsCellRange[] ModifiedCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange[1] { tQqlwF9BFt };
		}
	}

	protected virtual CvsCellRange DefaultValuesRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange(1, 0, 1, 1);
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
			return DhklRNOOLX;
		}
	}

	public virtual string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DropListBox;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoEnumPropertyAction(UndoEnumPropertyActionArgs args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector((string)A4g0qc7mRHJNj5liMYp(args), (string)TejKRb7yP7yFqYiWVZc(args), lIyVY57gGkTjkmWQvEn(args), args.ValueExpression, args.Items);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoEnumPropertyAction(string name, string editEnumExpression, int currentIndex, string valueExpression, List<string> items)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		tQqlwF9BFt = new CvsCellRange(0, 0, 2, 1);
		DhklRNOOLX = CvsCellRange.Invalid;
		PiDlNW6vsy = CvsCellLocation.Invalid;
		base._002Ector();
		lvKlsBB85j = string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(16904), name);
		DlVl6F0Wqu = editEnumExpression;
		lLolHEHX3X = currentIndex;
		vP9lKySs8k = valueExpression;
		xaqlEZQ5DH = items;
		if (vP9lKySs8k != null)
		{
			tQqlwF9BFt.Rows++;
		}
		if (xaqlEZQ5DH != null)
		{
			tQqlwF9BFt.Rows += xaqlEZQ5DH.Count;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__25))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!MtvYHM7FIYpCxITqkwf())
		{
			num = 1;
			if (!sN8xZ77foyPCyAwMxRJ())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (!sN8xZ77foyPCyAwMxRJ())
			{
				goto IL_0077;
			}
		}
		goto IL_0044;
		IL_008d:
		_003CSaveState_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0044;
		IL_0077:
		stateMachine._003C_003Et__builder = o19rAR7JQIwW1L8VZT0();
		num = 4;
		goto IL_0044;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_008d;
		IL_0044:
		switch (num)
		{
		case 4:
			break;
		case 0:
		case 1:
			goto IL_0077;
		default:
			goto IL_008d;
		case 5:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__26))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = o19rAR7JQIwW1L8VZT0();
				MtvYHM7FIYpCxITqkwf();
				num = ((!sN8xZ77foyPCyAwMxRJ()) ? 4 : 3);
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__27))]
	public virtual Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sN8xZ77foyPCyAwMxRJ();
		int num = (MtvYHM7FIYpCxITqkwf() ? 5 : 3);
		_003CRedo_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = o19rAR7JQIwW1L8VZT0();
				goto case 1;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInsertControlExpression_003Ed__28))]
	protected Task InsertControlExpression(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!MtvYHM7FIYpCxITqkwf())
		{
			num = 3;
			if (MtvYHM7FIYpCxITqkwf())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_0075:
		_003CInsertControlExpression_003Ed__28 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0075;
			case 5:
				goto IL_0075;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine.location = location;
		goto IL_0075;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__29))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUndo_003Ed__29 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!MtvYHM7FIYpCxITqkwf())
				{
					num = 1;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = o19rAR7JQIwW1L8VZT0();
				num = 4;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A4g0qc7mRHJNj5liMYp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoEnumPropertyActionArgs)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TejKRb7yP7yFqYiWVZc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoEnumPropertyActionArgs)P_0).EditEnumExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lIyVY57gGkTjkmWQvEn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoEnumPropertyActionArgs)P_0).CurrentIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sN8xZ77foyPCyAwMxRJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MtvYHM7FIYpCxITqkwf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange TbMHtd7Zv6EAf2gknK2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoEnumPropertyAction)P_0).DefaultValuesRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder o19rAR7JQIwW1L8VZT0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
