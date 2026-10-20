using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoReferenceRedirectAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__7 : IAsyncStateMachine
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
			_ = 0;
			int num;
			if (Qyu4DJsP7vlu0Q580nwP())
			{
				num = 4;
				if (QmrXUPsPtXGhCHeshQyt())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (!Qyu4DJsP7vlu0Q580nwP())
				{
					goto IL_01a4;
				}
			}
			goto IL_0171;
			IL_01bb:
			int num2 = _003C_003E1__state;
			num = 3;
			if (!Qyu4DJsP7vlu0Q580nwP())
			{
				return;
			}
			goto IL_0171;
			IL_0171:
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_01a4;
			case 0:
			case 4:
				goto IL_01bb;
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
					awaiter = RWU18asPCjvbyE4i5wyv(Task.CompletedTask);
					num3 = 8;
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
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 0;
						if (!QmrXUPsPtXGhCHeshQyt())
						{
							continue;
						}
						goto case 8;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						break;
					case 4:
						_003C_003Eu__1 = default;
						goto case 1;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						continue;
					case 0:
						return;
					case 1:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 3:
						num2 = (_003C_003E1__state = 0);
						Qyu4DJsP7vlu0Q580nwP();
						num3 = (QmrXUPsPtXGhCHeshQyt() ? 1 : 7);
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
			goto IL_01a4;
			IL_01a4:
			_003C_003Et__builder.SetResult();
			num = 5;
			if (true)
			{
				goto IL_0171;
			}
			goto IL_01bb;
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
		internal static TaskAwaiter RWU18asPCjvbyE4i5wyv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qyu4DJsP7vlu0Q580nwP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QmrXUPsPtXGhCHeshQyt()
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

		public UndoReferenceRedirectAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xITHgesPKa81JIEUQP7H();
			int num;
			if (!ltLVNxsP5tEWoZ1dR7yA())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			UndoReferenceRedirectAction undoReferenceRedirectAction = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = vWwpmYsPoIGJVj5jNVap(undoReferenceRedirectAction.Redo());
							_ = 1;
							if (!ltLVNxsP5tEWoZ1dR7yA())
							{
								num3 = 3;
								if (!xITHgesPKa81JIEUQP7H())
								{
									goto IL_006b;
								}
							}
							else
							{
								num3 = 2;
								if (false)
								{
									goto IL_00a2;
								}
							}
							goto IL_00eb;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0133;
						IL_014b:
						awaiter.GetResult();
						goto end_IL_003d;
						IL_00eb:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 8:
								return;
							case 0:
							case 3:
								goto IL_00a2;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 2:
							case 5:
								goto IL_0133;
							case 9:
								goto IL_014b;
							}
							break;
						}
						goto IL_006b;
						IL_0133:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (0 == 0)
						{
							goto IL_00eb;
						}
						goto IL_014b;
						IL_00a2:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_00eb;
						}
						goto IL_014b;
						IL_006b:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						if (!xITHgesPKa81JIEUQP7H())
						{
							return;
						}
						goto IL_00eb;
						end_IL_003d:;
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
				case 1:
				case 2:
					undoReferenceRedirectAction = _003C_003E4__this;
					num = 5;
					if (xITHgesPKa81JIEUQP7H())
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static TaskAwaiter vWwpmYsPoIGJVj5jNVap(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xITHgesPKa81JIEUQP7H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ltLVNxsP5tEWoZ1dR7yA()
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

		public UndoReferenceRedirectAction _003C_003E4__this;

		private Dictionary<CvsCellLocation, string> _003CnewExpressions_003E5__2;

		private Dictionary<CvsCellLocation, string> _003CnewCellStates_003E5__3;

		private Dictionary<CvsCellLocation, string>.Enumerator _003C_003E7__wrap3;

		private Dictionary<CvsCellRange, byte[]> _003C_003E7__wrap4;

		private CvsCellRange _003C_003E7__wrap5;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private object _003C_003E7__wrap6;

		private int _003C_003E7__wrap7;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoReferenceRedirectAction undoReferenceRedirectAction = default;
			CvsCellRange cvsCellRange = default;
			string text = default;
			CellRefRange cellRefRange = default;
			int num4 = default;
			CellRefRange[] array = default;
			TaskAwaiter<byte[]> awaiter3 = default;
			CvsCellRange cvsCellRange2 = default;
			KeyValuePair<CvsCellLocation, string> current4 = default;
			byte[] result = default;
			TaskAwaiter<object> awaiter2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					if (!zEkvYXsPYiqUjFyWbP6I())
					{
						break;
					}
					goto case 6;
				case 6:
					_003C_003Et__builder.SetResult();
					num = 8;
					break;
				case 5:
					undoReferenceRedirectAction = _003C_003E4__this;
					_ = 1;
					if (!zEkvYXsPYiqUjFyWbP6I())
					{
						num = 7;
						if (cEW2bZsPPARP8QiTC7iD())
						{
							break;
						}
						goto case 2;
					}
					num = 4;
					if (true)
					{
						break;
					}
					goto case 1;
				case 2:
				case 7:
					try
					{
						TaskAwaiter awaiter;
						switch (num2)
						{
						default:
						{
							_003CnewExpressions_003E5__2 = new Dictionary<CvsCellLocation, string>();
							_003CnewCellStates_003E5__3 = new Dictionary<CvsCellLocation, string>();
							undoReferenceRedirectAction.q94q5aNR3j = new Dictionary<CvsCellRange, byte[]>();
							IEnumerator<CvsCell> enumerator = ((CvsResultSet)Ofm9tfsPNJXh2KpQpBk3(undoReferenceRedirectAction.RZ0qf7PI3d)).Cells.GetEnumerator();
							try
							{
								while (pvDj8IsPXqBi19VKrjC0(enumerator))
								{
									CvsCell current = enumerator.Current;
									_ = 0;
									int num3 = ((!cEW2bZsPPARP8QiTC7iD()) ? 8 : 7);
									while (true)
									{
										switch (num3)
										{
										case 12:
											if (current.CellStateReference != null)
											{
												num3 = 14;
												if (!zEkvYXsPYiqUjFyWbP6I())
												{
													continue;
												}
												goto case 5;
											}
											goto IL_0124;
										case 5:
										{
											bool flag = cbrptZsPrKUK1ee1Zt5E(VCZ61AsP1EnOrgQrECGb(current), kgbOBx7BanbFa22Hp9.ol99ukmDA(42546));
											_003CnewCellStates_003E5__3.Add(current.Location, undoReferenceRedirectAction.sb6qc4k5jo.ToString(flag, flag));
											goto IL_0124;
										}
										case 1:
											if (cvsCellRange.Rows == 1)
											{
												num3 = 13;
												if (!zEkvYXsPYiqUjFyWbP6I())
												{
													continue;
												}
												goto case 10;
											}
											goto IL_0360;
										case 10:
											text = current.Expression;
											goto case 8;
										case 14:
											if (AyoAiZsPx14fR34F49f6(CvsCellLocation.TryParse((string)VCZ61AsP1EnOrgQrECGb(current)), undoReferenceRedirectAction.ADtqj6Pg1e))
											{
												num3 = 5;
												continue;
											}
											goto IL_0124;
										case 0:
										case 7:
											if (!AyoAiZsPx14fR34F49f6(current.Location, undoReferenceRedirectAction.sb6qc4k5jo))
											{
												num3 = 12;
												continue;
											}
											break;
										case 11:
											cvsCellRange = MwULShsPlwv7Dij1C3yY(cellRefRange);
											num3 = 1;
											if (0 == 0)
											{
												continue;
											}
											goto case 9;
										case 9:
											cvsCellRange = MwULShsPlwv7Dij1C3yY(cellRefRange);
											num3 = 4;
											continue;
										case 6:
											text = null;
											num3 = 17;
											continue;
										case 16:
										case 18:
											if (num4 < 0)
											{
												if (text != null)
												{
													_003CnewExpressions_003E5__2.Add(TrP5OPsPGPT6b4fwd7MB(current), text);
													num3 = 19;
													continue;
												}
												break;
											}
											cellRefRange = array[num4];
											num3 = 9;
											continue;
										case 3:
											if (text == null)
											{
												num3 = 10;
												if (true)
												{
													continue;
												}
												goto case 13;
											}
											goto case 8;
										case 13:
											cvsCellRange = MwULShsPlwv7Dij1C3yY(cellRefRange);
											num3 = 2;
											continue;
										case 2:
											if (AyoAiZsPx14fR34F49f6(cvsCellRange.Location, undoReferenceRedirectAction.ADtqj6Pg1e))
											{
												num3 = 3;
												continue;
											}
											goto IL_0360;
										case 17:
											num4 = array.Length - 1;
											num3 = 18;
											continue;
										case 4:
											if (cvsCellRange.Columns == 1)
											{
												goto case 11;
											}
											goto IL_0360;
										default:
											num3 = 11;
											continue;
										case 8:
										case 15:
											text = (string)FsyTipsPnwBonULXAYah(TbUddKsPuwRCbsPOBdqE(text, 0, AVqB72sPeMnEjRkO1cna(cellRefRange)), undoReferenceRedirectAction.sb6qc4k5jo.ToString(QUyQfksPIHLdC6W4tQN5(cellRefRange), kkXTCasPR0hAPlZsfUFl(cellRefRange)), PKUPBAsPapKLOsnoY8nS(text, cellRefRange.TextEnd));
											goto IL_0360;
										case 19:
											break;
											IL_0360:
											num4--;
											num3 = 16;
											continue;
											IL_0124:
											array = (CellRefRange[])GvEnh6sPQ4oqoBbgKx0h(CvsParse.Parse((CvsFunctionTable)ROZ1wcsP3eM6XNXVtOgH(undoReferenceRedirectAction.RZ0qf7PI3d), (IExpressionConstants)kwUh19sPOKMvBoLqMx15(undoReferenceRedirectAction.RZ0qf7PI3d), (string)dGTHUdsPMxMaUBeboAj2(current), 0));
											num3 = 6;
											continue;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									KajXjrsPbGmuORTmmKQ4(enumerator);
								}
							}
							_003C_003E7__wrap3 = _003CnewExpressions_003E5__2.GetEnumerator();
							goto case 0;
						}
						case 0:
							try
							{
								if (num2 != 0)
								{
									goto IL_055f;
								}
								awaiter3 = _003C_003Eu__1;
								int num7 = 11;
								goto IL_0425;
								IL_0425:
								while (true)
								{
									switch (num7)
									{
									case 2:
										cvsCellRange2 = new CvsCellRange(current4.Key);
										num7 = 8;
										continue;
									case 6:
										_003C_003E7__wrap4[_003C_003E7__wrap5] = result;
										num7 = 0;
										continue;
									case 5:
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									default:
										num7 = 12;
										continue;
									case 8:
										_003C_003E7__wrap4 = undoReferenceRedirectAction.q94q5aNR3j;
										_003C_003E7__wrap5 = cvsCellRange2;
										num7 = 1;
										continue;
									case 7:
									case 9:
										result = awaiter3.GetResult();
										num7 = 6;
										continue;
									case 11:
										_003C_003Eu__1 = default;
										num7 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									case 1:
										awaiter3 = ((CvsCogSocketSheet)pe4TO8sPpCaMFwiffxL5(i60JjnsP6lfQl3sVU0Ps(undoReferenceRedirectAction.RZ0qf7PI3d))).CopyCellsAsync(cvsCellRange2).GetAwaiter();
										_ = 1;
										if (!zEkvYXsPYiqUjFyWbP6I())
										{
											num7 = 13;
											continue;
										}
										num7 = 7;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 12:
										return;
									case 4:
										num2 = (_003C_003E1__state = -1);
										goto case 7;
									case 0:
										_003C_003E7__wrap4 = null;
										num7 = 14;
										continue;
									case 10:
										num2 = (_003C_003E1__state = 0);
										num7 = 5;
										if (cEW2bZsPPARP8QiTC7iD())
										{
											continue;
										}
										goto case 3;
									case 3:
									case 13:
										if (!awaiter3.IsCompleted)
										{
											num7 = 10;
											continue;
										}
										goto case 7;
									case 14:
										break;
									}
									break;
								}
								goto IL_055f;
								IL_055f:
								if (_003C_003E7__wrap3.MoveNext())
								{
									current4 = _003C_003E7__wrap3.Current;
									num7 = 2;
									goto IL_0425;
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)_003C_003E7__wrap3/*cast due to constrained. prefix*/).Dispose();
								}
							}
							_003C_003E7__wrap3 = default;
							_003C_003E7__wrap7 = 0;
							goto case 1;
						case 1:
						{
							try
							{
								if (num2 != 1)
								{
									_003C_003E7__wrap3 = _003CnewExpressions_003E5__2.GetEnumerator();
								}
								try
								{
									int num5;
									if (num2 != 1)
									{
										num5 = 2;
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										num5 = 5;
									}
									while (true)
									{
										switch (num5)
										{
										case 9:
											num2 = (_003C_003E1__state = 1);
											zEkvYXsPYiqUjFyWbP6I();
											num5 = ((!cEW2bZsPPARP8QiTC7iD()) ? 8 : 7);
											continue;
										case 6:
											if (!awaiter2.IsCompleted)
											{
												num5 = 9;
												continue;
											}
											goto case 10;
										case 0:
											return;
										case 10:
											awaiter2.GetResult();
											num5 = 11;
											continue;
										case 4:
										case 8:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											return;
										default:
											num5 = 0;
											continue;
										case 3:
										case 7:
											_003C_003Eu__2 = awaiter2;
											goto case 4;
										case 5:
											_003C_003Eu__2 = default;
											num5 = 1;
											continue;
										case 1:
											num2 = (_003C_003E1__state = -1);
											num5 = 10;
											continue;
										case 2:
										case 11:
											if (_003C_003E7__wrap3.MoveNext())
											{
												KeyValuePair<CvsCellLocation, string> current2 = _003C_003E7__wrap3.Current;
												awaiter2 = ((CvsCogSocketSheet)pe4TO8sPpCaMFwiffxL5(i60JjnsP6lfQl3sVU0Ps(undoReferenceRedirectAction.RZ0qf7PI3d))).PutCellExpressionAsync(current2.Key, current2.Value).GetAwaiter();
												num5 = 6;
												continue;
											}
											break;
										}
										break;
									}
								}
								finally
								{
									if (num2 < 0)
									{
										((IDisposable)_003C_003E7__wrap3/*cast due to constrained. prefix*/).Dispose();
									}
								}
								_003C_003E7__wrap3 = default;
								Dictionary<CvsCellLocation, string>.Enumerator enumerator2 = _003CnewCellStates_003E5__3.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										KeyValuePair<CvsCellLocation, string> current3 = enumerator2.Current;
										_ = 1;
										switch (zEkvYXsPYiqUjFyWbP6I() ? 3 : 2)
										{
										case 0:
										case 2:
											((CvsCogSocketSheet)pe4TO8sPpCaMFwiffxL5(i60JjnsP6lfQl3sVU0Ps(undoReferenceRedirectAction.RZ0qf7PI3d))).ApplyCellAttributes(new CvsCellRange(current3.Key), false, new DictionaryEntry[1]
											{
												new DictionaryEntry(eGVpKFsP0yfS68s2Q7gU(4352), current3.Value)
											});
											break;
										}
									}
								}
								finally
								{
									if (num2 < 0)
									{
										((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
									}
								}
								((CvsCogSocketSheet)pe4TO8sPpCaMFwiffxL5(undoReferenceRedirectAction.RZ0qf7PI3d.CogSocket)).Run(true);
							}
							catch (object obj)
							{
								_003C_003E7__wrap6 = obj;
								_003C_003E7__wrap7 = 1;
							}
							int num6 = _003C_003E7__wrap7;
							if (num6 != 1)
							{
								break;
							}
							awaiter = WZeugUsP4sBUcfx0eYKP(undoReferenceRedirectAction.Undo());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_08bc;
						}
						case 2:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_08bc;
							}
							IL_08bc:
							awaiter.GetResult();
							ExceptionDispatchInfo.Capture((_003C_003E7__wrap6 as Exception) ?? throw _003C_003E7__wrap6).Throw();
							break;
						}
						_003C_003E7__wrap6 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnewExpressions_003E5__2 = null;
						_003CnewCellStates_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				case 1:
					_003CnewCellStates_003E5__3 = null;
					num = 6;
					break;
				case 3:
				case 4:
					_003CnewExpressions_003E5__2 = null;
					goto case 1;
				default:
					num = 1;
					break;
				case 8:
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
		internal static object Ofm9tfsPNJXh2KpQpBk3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AyoAiZsPx14fR34F49f6(CvsCellLocation left, CvsCellLocation right)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return left == right;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VCZ61AsP1EnOrgQrECGb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellStateReference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cbrptZsPrKUK1ee1Zt5E(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ROZ1wcsP3eM6XNXVtOgH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kwUh19sPOKMvBoLqMx15(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dGTHUdsPMxMaUBeboAj2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GvEnh6sPQ4oqoBbgKx0h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CellReferences;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange MwULShsPlwv7Dij1C3yY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int AVqB72sPeMnEjRkO1cna(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellRefRange)P_0).TextStart;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TbUddKsPuwRCbsPOBdqE(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QUyQfksPIHLdC6W4tQN5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).AbsoluteRow;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kkXTCasPR0hAPlZsfUFl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).AbsoluteColumn;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PKUPBAsPapKLOsnoY8nS(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FsyTipsPnwBonULXAYah(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation TrP5OPsPGPT6b4fwd7MB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pvDj8IsPXqBi19VKrjC0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KajXjrsPbGmuORTmmKQ4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object i60JjnsP6lfQl3sVU0Ps(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pe4TO8sPpCaMFwiffxL5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eGVpKFsP0yfS68s2Q7gU(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WZeugUsP4sBUcfx0eYKP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cEW2bZsPPARP8QiTC7iD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zEkvYXsPYiqUjFyWbP6I()
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

		public UndoReferenceRedirectAction _003C_003E4__this;

		private Dictionary<CvsCellRange, byte[]>.Enumerator _003C_003E7__wrap1;

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
			if (!oMftXwsPfKruXUbf0NaZ())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (oMftXwsPfKruXUbf0NaZ())
				{
				}
			}
			goto IL_023d;
			IL_0047:
			UndoReferenceRedirectAction undoReferenceRedirectAction = _003C_003E4__this;
			num = 2;
			goto IL_023d;
			IL_023d:
			int num2 = default;
			TaskAwaiter awaiter = default;
			KeyValuePair<CvsCellRange, byte[]> current = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 3:
					goto IL_0047;
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = undoReferenceRedirectAction.q94q5aNR3j.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_01b1;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 9;
							if (false)
							{
								goto IL_00cc;
							}
							goto IL_0176;
							IL_0176:
							while (true)
							{
								switch (num3)
								{
								case 0:
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									break;
								case 3:
								case 7:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 5:
									if (awaiter.IsCompleted)
									{
										goto case 3;
									}
									_ = 1;
									if (!oMftXwsPfKruXUbf0NaZ())
									{
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 9;
									}
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 1;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 6;
									continue;
								case 6:
									num2 = (_003C_003E1__state = -1);
									goto case 3;
								case 1:
									_003C_003Eu__1 = awaiter;
									goto case 4;
								default:
									num3 = 4;
									continue;
								case 10:
									goto IL_01b1;
								}
								break;
							}
							goto IL_00cc;
							IL_01b1:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current = _003C_003E7__wrap1.Current;
								num3 = 8;
								goto IL_0176;
							}
							goto end_IL_0070;
							IL_00cc:
							awaiter = zipAbHsPmFrGQ6s5g2XK(TXZoxOsPFtbmtgE1LbwS(undoReferenceRedirectAction.RZ0qf7PI3d, current.Key, current.Value, false, false));
							num3 = 5;
							goto IL_0176;
							end_IL_0070:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
						((CvsCogSocketSheet)SbNenTsPg2Pfm26GvKjE(JqXvOOsPyjSU2WqgqihF(undoReferenceRedirectAction.RZ0qf7PI3d))).Run(true);
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
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			goto IL_0047;
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
		internal static object TXZoxOsPFtbmtgE1LbwS(object P_0, CvsCellRange cellRange, object P_2, bool cutFromSameSheet, bool runSheet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(cellRange, (byte[])P_2, cutFromSameSheet, runSheet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter zipAbHsPmFrGQ6s5g2XK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JqXvOOsPyjSU2WqgqihF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SbNenTsPg2Pfm26GvKjE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool irmScysPkTiXIXhqUGkC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oMftXwsPfKruXUbf0NaZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight RZ0qf7PI3d;

	private CvsCellLocation ADtqj6Pg1e;

	private CvsCellLocation sb6qc4k5jo;

	private Dictionary<CvsCellRange, byte[]> q94q5aNR3j;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)rgQ0tLCy1rjM0BwpM4B(kgbOBx7BanbFa22Hp9.ol99ukmDA(17268), ADtqj6Pg1e.ToString(), sb6qc4k5jo.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal UndoReferenceRedirectAction(CvsInSight inSight, CvsCellLocation oldReference, CvsCellLocation newReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 6:
				RZ0qf7PI3d = inSight;
				goto default;
			default:
				s4Kre8CFZVHV7E5DQeA();
				num = ((!IXejZ4CfYBLn2vOWjvu()) ? 2 : 5);
				continue;
			case 0:
				LJbwGZCmh70ojXB0FnI(this);
				num = 6;
				if (IXejZ4CfYBLn2vOWjvu())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 5:
				ADtqj6Pg1e = oldReference;
				goto case 2;
			case 2:
			case 4:
				sb6qc4k5jo = newReference;
				num = 7;
				if (IXejZ4CfYBLn2vOWjvu())
				{
					continue;
				}
				break;
			case 1:
				break;
			case 7:
				return;
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			num = 0;
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
		int num = 3;
		_003CSaveState_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = Y1PmwaCgfslN5duaSgf();
				IXejZ4CfYBLn2vOWjvu();
				if (!s4Kre8CFZVHV7E5DQeA())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
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
		_ = 0;
		int num;
		if (IXejZ4CfYBLn2vOWjvu())
		{
			num = 2;
			if (s4Kre8CFZVHV7E5DQeA())
			{
			}
		}
		else
		{
			num = 5;
		}
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (s4Kre8CFZVHV7E5DQeA())
				{
				}
				break;
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
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!IXejZ4CfYBLn2vOWjvu())
		{
			goto IL_001e;
		}
		goto IL_0050;
		IL_001e:
		_003CRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				s4Kre8CFZVHV7E5DQeA();
				num = (IXejZ4CfYBLn2vOWjvu() ? 1 : 0);
				continue;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IXejZ4CfYBLn2vOWjvu();
		int num;
		if (!s4Kre8CFZVHV7E5DQeA())
		{
			num = 2;
			if (s4Kre8CFZVHV7E5DQeA())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_005c;
		IL_002e:
		_003CUndo_003Ed__10 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 3;
		if (false)
		{
			goto IL_0042;
		}
		goto IL_005c;
		IL_00a7:
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		goto IL_002e;
		IL_0042:
		stateMachine._003C_003E1__state = -1;
		goto IL_0089;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 3:
				goto IL_0042;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_0089;
			case 5:
				goto IL_0089;
			case 0:
			case 2:
				goto IL_00a7;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_0089:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (IXejZ4CfYBLn2vOWjvu())
		{
			goto IL_005c;
		}
		goto IL_00a7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LJbwGZCmh70ojXB0FnI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IXejZ4CfYBLn2vOWjvu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s4Kre8CFZVHV7E5DQeA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rgQ0tLCy1rjM0BwpM4B(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Y1PmwaCgfslN5duaSgf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
