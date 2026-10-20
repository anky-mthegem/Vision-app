using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoColorPropertyAction : IUndoPropertyAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__21 : IAsyncStateMachine
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
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0188;
			IL_01b5:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_0188;
			IL_0188:
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 4:
				goto IL_0039;
			default:
				goto IL_01b5;
			case 5:
				return;
			}
			goto IL_001a;
			IL_0039:
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = drLGGnscarECL2mO0CFg(PGJUvxscRlgNAGDfcS22());
					AWxMfHscIJE4xeTg8Mro();
					if (KrIB8VscupiWpkExZt5f())
					{
						num3 = 4;
						if (AWxMfHscIJE4xeTg8Mro())
						{
						}
					}
					else
					{
						num3 = 7;
						if (false)
						{
							goto IL_00a1;
						}
					}
					goto IL_00e5;
				}
				awaiter = _003C_003Eu__1;
				goto IL_0132;
				IL_00e5:
				while (true)
				{
					switch (num3)
					{
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (true)
						{
							continue;
						}
						return;
					case 1:
						return;
					case 8:
						break;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 1;
						continue;
					case 0:
					case 4:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 9;
					case 5:
					case 7:
						goto IL_0132;
					case 9:
						awaiter.GetResult();
						goto end_IL_0039;
					}
					break;
				}
				goto IL_00a1;
				IL_00a1:
				_003C_003Eu__1 = awaiter;
				num3 = 3;
				goto IL_00e5;
				IL_0132:
				_003C_003Eu__1 = default;
				num3 = 6;
				goto IL_00e5;
				end_IL_0039:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b5;
			IL_001a:
			num2 = _003C_003E1__state;
			_ = 1;
			if (!AWxMfHscIJE4xeTg8Mro())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0039;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0188;
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
		internal static object PGJUvxscRlgNAGDfcS22()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter drLGGnscarECL2mO0CFg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KrIB8VscupiWpkExZt5f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AWxMfHscIJE4xeTg8Mro()
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
	private struct _003CDo_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoColorPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WNiHJdscnDsN0nQL1WOD();
			int num = (sv49FHscGUbymJqE5sfe() ? 1 : 4);
			UndoColorPropertyAction undoColorPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					undoColorPropertyAction = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = sZrkEGscX1m6q5Sb9Lia(undoColorPropertyAction.Redo());
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (false)
							{
								goto IL_0150;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								WNiHJdscnDsN0nQL1WOD();
								num3 = ((!sv49FHscGUbymJqE5sfe()) ? 5 : 0);
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							case 7:
								return;
							case 9:
								break;
							}
							break;
						}
						goto IL_0150;
						IL_0150:
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
		internal static TaskAwaiter sZrkEGscX1m6q5Sb9Lia(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WNiHJdscnDsN0nQL1WOD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sv49FHscGUbymJqE5sfe()
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
	private struct _003CRedo_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoColorPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CredLoc_003E5__2;

		private CvsCellLocation _003CgreenLoc_003E5__3;

		private CvsCellLocation _003CblueLoc_003E5__4;

		private CvsCellLocation _003CcolorLoc_003E5__5;

		private CvsCellLocation _003ClabelLoc_003E5__6;

		private CvsCellLocation _003CeditIntLoc_003E5__7;

		private string[] _003C_003E7__wrap7;

		private int _003C_003E7__wrap8;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lb4hRssc6qjNU0tgXuY7();
			int num;
			if (bsF0kqscbPZkCGZYsgmM())
			{
				num = 1;
				if (!bsF0kqscbPZkCGZYsgmM())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_06a8;
			IL_002e:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_06a8;
			IL_06a8:
			UndoColorPropertyAction undoColorPropertyAction = default;
			TaskAwaiter<object> awaiter = default;
			int num4 = default;
			int num5 = default;
			string expression = default;
			string[] orBlAWRfLJ = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					undoColorPropertyAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003CredLoc_003E5__2 = undoColorPropertyAction.DropLocation;
							num3 = 0;
							if (lb4hRssc6qjNU0tgXuY7())
							{
								goto IL_0099;
							}
							goto IL_0545;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 22;
							if (1 == 0)
							{
								goto IL_0241;
							}
							goto IL_0545;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 17;
							goto IL_0545;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 24;
								goto IL_0545;
							}
							IL_0545:
							while (true)
							{
								switch (num3)
								{
								case 35:
									break;
								case 0:
									_003CredLoc_003E5__2.Row++;
									_003CgreenLoc_003E5__3 = _003CredLoc_003E5__2;
									num3 = 36;
									continue;
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 25;
										if (0 == 0)
										{
											continue;
										}
										goto case 20;
									}
									goto case 9;
								case 20:
									awaiter.GetResult();
									bsF0kqscbPZkCGZYsgmM();
									num3 = (lb4hRssc6qjNU0tgXuY7() ? 37 : 7);
									continue;
								case 15:
									_003CeditIntLoc_003E5__7.Column++;
									num4 -= 8;
									num3 = 13;
									continue;
								case 13:
									num5++;
									goto IL_0151;
								case 36:
									_003CgreenLoc_003E5__3.Column++;
									num3 = 28;
									continue;
								case 32:
									num5 = 0;
									goto IL_0151;
								case 26:
									num2 = (_003C_003E1__state = -1);
									num3 = 20;
									if (0 == 0)
									{
										continue;
									}
									goto case 23;
								case 23:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 1;
									continue;
								case 5:
									_003CeditIntLoc_003E5__7 = _003CredLoc_003E5__2;
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 17;
								case 17:
									_003C_003Eu__1 = default;
									num3 = 29;
									if (0 == 0)
									{
										continue;
									}
									goto case 10;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 40:
									goto IL_0241;
								case 11:
									goto IL_025f;
								case 34:
									goto IL_026e;
								case 3:
									_003CeditIntLoc_003E5__7.Column++;
									num3 = 40;
									if (lb4hRssc6qjNU0tgXuY7())
									{
									}
									continue;
								case 22:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 21:
									_003C_003E7__wrap8 = 0;
									num3 = 31;
									continue;
								case 30:
									_003C_003Eu__1 = awaiter;
									num3 = 23;
									if (!lb4hRssc6qjNU0tgXuY7())
									{
										continue;
									}
									goto case 8;
								case 8:
									((CvsCogSocketSheet)iaKwTQsc0tKryyGBiATq(wCwsiQscp38B0N3dMUf6(undoColorPropertyAction.InSight))).Run(true);
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto end_IL_006c;
								case 33:
									goto end_IL_006c;
								case 18:
									_003CblueLoc_003E5__4.Column++;
									num3 = 27;
									if (true)
									{
										continue;
									}
									goto case 25;
								case 25:
									num2 = (_003C_003E1__state = 2);
									num3 = 39;
									continue;
								case 4:
								case 31:
									if (_003C_003E7__wrap8 >= _003C_003E7__wrap7.Length)
									{
										_003C_003E7__wrap7 = null;
										awaiter = ((CvsCogSocket)wCwsiQscp38B0N3dMUf6(undoColorPropertyAction.InSight)).Sheet.PutCellExpressionAsync(_003CcolorLoc_003E5__5, string.Format((string)hIBIP2sc4OcNwRJvMkXU(55356), _003CredLoc_003E5__2.ToString(), _003CgreenLoc_003E5__3.ToString(), _003CblueLoc_003E5__4.ToString())).GetAwaiter();
										num3 = 6;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									}
									expression = _003C_003E7__wrap7[_003C_003E7__wrap8];
									num3 = 12;
									continue;
								case 12:
									awaiter = ((CvsCogSocket)wCwsiQscp38B0N3dMUf6(undoColorPropertyAction.InSight)).Sheet.PutCellExpressionAsync(_003ClabelLoc_003E5__6, expression).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 30;
										continue;
									}
									goto case 20;
								case 27:
									_003CcolorLoc_003E5__5 = _003CredLoc_003E5__2;
									num3 = 38;
									if (!lb4hRssc6qjNU0tgXuY7())
									{
										continue;
									}
									goto case 24;
								case 24:
									_003C_003Eu__1 = default;
									num3 = 26;
									if (!lb4hRssc6qjNU0tgXuY7())
									{
										continue;
									}
									goto case 39;
								case 39:
									_003C_003Eu__1 = awaiter;
									num3 = 10;
									continue;
								case 14:
									orBlAWRfLJ = undoColorPropertyAction.orBlAWRfLJ;
									num3 = 32;
									continue;
								case 29:
									num2 = (_003C_003E1__state = -1);
									goto IL_04a1;
								case 1:
									return;
								case 7:
								case 16:
									awaiter = ((CvsCogSocketSheet)iaKwTQsc0tKryyGBiATq(wCwsiQscp38B0N3dMUf6(undoColorPropertyAction.InSight))).PutCellExpressionAsync(_003CeditIntLoc_003E5__7, (string)hIBIP2sc4OcNwRJvMkXU(55324)).GetAwaiter();
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 28;
								case 28:
									_003CblueLoc_003E5__4 = _003CgreenLoc_003E5__3;
									num3 = 18;
									continue;
								case 19:
								case 37:
									goto IL_052b;
								default:
									num3 = 33;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 34;
										continue;
									}
									goto IL_04a1;
								case 9:
									awaiter.GetResult();
									num3 = 8;
									continue;
								case 38:
									_003CcolorLoc_003E5__5.Row++;
									num3 = 35;
									if (true)
									{
										continue;
									}
									goto case 41;
								case 41:
									{
										undoColorPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
										goto end_IL_006b;
									}
									IL_04a1:
									awaiter.GetResult();
									_003ClabelLoc_003E5__6.Column++;
									num3 = 3;
									continue;
									IL_0151:
									if (num5 >= orBlAWRfLJ.Length)
									{
										num3 = 41;
										continue;
									}
									_ = orBlAWRfLJ[num5];
									undoColorPropertyAction.InSight.SetInteger(_003CeditIntLoc_003E5__7, (undoColorPropertyAction.JVclkrQYPG >> num4) & 0xFF);
									num3 = 15;
									continue;
								}
								break;
							}
							goto IL_0099;
							IL_0241:
							_003C_003E7__wrap8++;
							num3 = 4;
							if (!bsF0kqscbPZkCGZYsgmM())
							{
								goto IL_025f;
							}
							goto IL_0545;
							IL_025f:
							num4 = 16;
							num3 = 14;
							if (1 == 0)
							{
								goto IL_026e;
							}
							goto IL_0545;
							IL_026e:
							num2 = (_003C_003E1__state = 1);
							goto IL_052b;
							IL_052b:
							_003C_003Eu__1 = awaiter;
							break;
							IL_0099:
							_003ClabelLoc_003E5__6 = undoColorPropertyAction.DropLocation;
							_003CeditIntLoc_003E5__7 = _003CredLoc_003E5__2;
							_003C_003E7__wrap7 = undoColorPropertyAction.orBlAWRfLJ;
							num3 = 21;
							goto IL_0545;
							end_IL_006c:
							break;
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_006b:;
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
			goto IL_002e;
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
		internal static object wCwsiQscp38B0N3dMUf6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iaKwTQsc0tKryyGBiATq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hIBIP2sc4OcNwRJvMkXU(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bsF0kqscbPZkCGZYsgmM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lb4hRssc6qjNU0tgXuY7()
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
	private struct _003CUndo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoColorPropertyAction _003C_003E4__this;

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
			_ = 0;
			int num;
			if (Jvkk2ZsckGioYjAtu0sr())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0050;
				}
			}
			goto IL_02b5;
			IL_02b5:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 5:
					goto IL_0050;
				default:
					num = 2;
					continue;
				case 2:
					goto IL_02e0;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0050:
			UndoColorPropertyAction undoColorPropertyAction = default;
			try
			{
				CvsCellRange[] modifiedCells = default;
				int num3;
				TaskAwaiter<object> awaiter = default;
				if (num2 != 0)
				{
					modifiedCells = undoColorPropertyAction.ModifiedCells;
					num3 = 14;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 2;
				}
				CvsCellRange cellRange = default;
				CvsCellRange cvsCellRange = default;
				while (true)
				{
					switch (num3)
					{
					case 2:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 13;
					case 13:
						_003C_003E7__wrap2 = 0;
						num3 = 1;
						continue;
					case 12:
						awaiter = ((CvsCogSocket)A0VjvxscFVJmOvmisapl(undoColorPropertyAction.InSight)).Sheet.ClearCellsAsync(cellRange).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							goto case 5;
						}
						goto case 8;
					case 11:
						_003C_003E7__wrap1 = null;
						num3 = 15;
						continue;
					case 4:
						_003C_003E7__wrap2++;
						num3 = 7;
						continue;
					case 14:
						_003C_003E7__wrap1 = modifiedCells;
						num3 = 13;
						if (true)
						{
							continue;
						}
						goto case 1;
					case 1:
					case 7:
						if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
						{
							cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
							Q0F5QIscfNr1iRGDEWMD();
							if (!Jvkk2ZsckGioYjAtu0sr())
							{
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							}
							num3 = 0;
							continue;
						}
						num3 = 11;
						continue;
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 5:
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						if (!Q0F5QIscfNr1iRGDEWMD())
						{
							continue;
						}
						goto case 8;
					case 8:
						awaiter.GetResult();
						num3 = 4;
						if (true)
						{
							continue;
						}
						goto case 10;
					case 10:
						_003C_003Eu__1 = awaiter;
						goto case 9;
					default:
						num3 = 9;
						if (Jvkk2ZsckGioYjAtu0sr())
						{
							continue;
						}
						goto case 0;
					case 0:
					case 3:
						cellRange = new CvsCellRange(undoColorPropertyAction.DropLocation.Row + cvsCellRange.Row, undoColorPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
						num3 = 12;
						continue;
					case 15:
						undoColorPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
			goto IL_02e0;
			IL_0026:
			undoColorPropertyAction = _003C_003E4__this;
			num = 5;
			goto IL_02b5;
			IL_02e0:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_02b5;
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
		internal static object A0VjvxscFVJmOvmisapl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jvkk2ZsckGioYjAtu0sr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q0F5QIscfNr1iRGDEWMD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string[] orBlAWRfLJ;

	private CvsCellRange IKoltRSbZ4;

	private CvsCellRange WUVlWPeXAw;

	private CvsCellRange FvKl3Q0gau;

	private string X10lLvoYNO;

	private int JVclkrQYPG;

	[CompilerGenerated]
	private CvsInSight Yb2lXWJNMV;

	private CvsCellLocation HWOlfhgQmx;

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
			return Yb2lXWJNMV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yb2lXWJNMV = value;
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
			return HWOlfhgQmx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WrYef67jdJCbV0gmM05();
			int num = ((!OnxBEt7BsoXdvgb962d()) ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 2:
					FvKl3Q0gau = new CvsCellRange(HWOlfhgQmx.Row + 2, HWOlfhgQmx.Column, 1, 1);
					num = 5;
					if (OnxBEt7BsoXdvgb962d())
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					HWOlfhgQmx = value;
					goto case 2;
				default:
					num = 2;
					break;
				case 0:
				case 3:
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
			return new CvsCellRange[2] { IKoltRSbZ4, WUVlWPeXAw };
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
			return FvKl3Q0gau;
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
			return (string)V4dFdl770l1kyswqLnG();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoColorPropertyAction(string name, int currentValue)
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
		goto IL_0032;
		IL_001a:
		d1wgs572kRlkPQG4jbX(this);
		goto IL_00ee;
		IL_0032:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 7:
				IKoltRSbZ4 = new CvsCellRange(0, 0, 2, 3);
				num = 10;
				continue;
			case 1:
			case 2:
				FvKl3Q0gau = CvsCellRange.Invalid;
				num = 3;
				continue;
			case 8:
				goto IL_00a5;
			default:
				goto IL_00ee;
			case 6:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				continue;
			case 3:
				HWOlfhgQmx = CvsCellLocation.Invalid;
				num = 0;
				continue;
			case 9:
				JVclkrQYPG = currentValue;
				num = 7;
				continue;
			case 10:
				WUVlWPeXAw = new CvsCellRange(2, 0, 1, 1);
				num = 11;
				continue;
			case 11:
				return;
			}
			break;
			IL_00a5:
			orBlAWRfLJ = new string[3]
			{
				kgbOBx7BanbFa22Hp9.ol99ukmDA(17026),
				(string)uFlHfx7ca4b4cyA7Y95(17038),
				(string)uFlHfx7ca4b4cyA7Y95(17054)
			};
			_ = 1;
			num = ((!WrYef67jdJCbV0gmM05()) ? 1 : 4);
		}
		goto IL_001a;
		IL_00ee:
		X10lLvoYNO = (string)BbGKFl7Whd7T0sSK9YU(uFlHfx7ca4b4cyA7Y95(16904), name);
		num = 9;
		goto IL_0032;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__21))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OnxBEt7BsoXdvgb962d();
		int num = (WrYef67jdJCbV0gmM05() ? 2 : 3);
		_003CSaveState_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = BDyTSD7t3ca0l4rq3c1();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__22))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WrYef67jdJCbV0gmM05();
		int num;
		if (OnxBEt7BsoXdvgb962d())
		{
			num = 4;
			if (WrYef67jdJCbV0gmM05())
			{
			}
		}
		else
		{
			num = 1;
		}
		_003CDo_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = BDyTSD7t3ca0l4rq3c1();
				num = 5;
				if (OnxBEt7BsoXdvgb962d())
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__23))]
	public Task Redo()
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
		goto IL_0034;
		IL_001a:
		_003CRedo_003Ed__23 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0065;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0065;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				continue;
			case 4:
				goto IL_0093;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0093:
			stateMachine._003C_003E4__this = this;
			OnxBEt7BsoXdvgb962d();
			num = (WrYef67jdJCbV0gmM05() ? 5 : 0);
		}
		goto IL_001a;
		IL_0065:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__24))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OnxBEt7BsoXdvgb962d();
		int num;
		if (!WrYef67jdJCbV0gmM05())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0046;
			}
		}
		goto IL_008a;
		IL_008a:
		_003CUndo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = BDyTSD7t3ca0l4rq3c1();
				goto case 1;
			case 4:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0046;
		IL_0046:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uFlHfx7ca4b4cyA7Y95(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d1wgs572kRlkPQG4jbX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BbGKFl7Whd7T0sSK9YU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OnxBEt7BsoXdvgb962d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WrYef67jdJCbV0gmM05()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V4dFdl770l1kyswqLnG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DropColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder BDyTSD7t3ca0l4rq3c1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
