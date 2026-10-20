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

public class UndoRegionPropertyAction : IUndoPropertyAction, IUndoAction
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
			sY8a8QsPZGGLWX4v7lub();
			int num = (BuZCILsPJBemnuDMofAg() ? 3 : 2);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = k0cyvssPzQAbsfAylGcR(b4U5TYsP8kCPGvAmqBqJ());
							_ = 1;
							num3 = (BuZCILsPJBemnuDMofAg() ? 6 : 3);
							goto IL_0111;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00bf;
						IL_0111:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 0:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (sY8a8QsPZGGLWX4v7lub())
									{
										continue;
									}
									goto case 1;
								}
								goto case 9;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (sY8a8QsPZGGLWX4v7lub())
								{
									continue;
								}
								break;
							case 5:
							case 6:
								break;
							case 4:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (sY8a8QsPZGGLWX4v7lub())
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0111;
							}
							goto IL_00bf;
							continue;
							end_IL_0111:
							break;
						}
						goto end_IL_003f;
						IL_00bf:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0111;
						end_IL_003f:;
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
					if (sY8a8QsPZGGLWX4v7lub())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static object b4U5TYsP8kCPGvAmqBqJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter k0cyvssPzQAbsfAylGcR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sY8a8QsPZGGLWX4v7lub()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BuZCILsPJBemnuDMofAg()
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

		public UndoRegionPropertyAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoRegionPropertyAction undoRegionPropertyAction = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					undoRegionPropertyAction = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!yK9nkPsYwFqVYR9iAgQe()) ? 4 : 0);
					continue;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Kb4tgmsYh1FYBukPnHUm(undoRegionPropertyAction.Redo());
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (false)
							{
								goto IL_0123;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 7:
								break;
							default:
								num3 = 6;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 9;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								goto IL_00e8;
							case 6:
								return;
							case 2:
							case 8:
								goto IL_0123;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_004c;
							}
							break;
							IL_00e8:
							num2 = (_003C_003E1__state = 0);
							LYDap4sYs77gG4d5uyNb();
							num3 = ((!yK9nkPsYwFqVYR9iAgQe()) ? 7 : 8);
						}
						goto IL_0068;
						IL_0123:
						_003C_003Eu__1 = awaiter;
						goto IL_0068;
						IL_0068:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_004c:;
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
		internal static TaskAwaiter Kb4tgmsYh1FYBukPnHUm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yK9nkPsYwFqVYR9iAgQe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LYDap4sYs77gG4d5uyNb()
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

		public UndoRegionPropertyAction _003C_003E4__this;

		private CvsCellLocation _003CeditRegionloc_003E5__2;

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
			BeNlTlsY9tAt4hSJJefT();
			int num = ((!VVmiZisYLmvAyTI7VoUx()) ? 1 : 2);
			UndoRegionPropertyAction undoRegionPropertyAction = default;
			CvsCogEditInfo[] result = default;
			int num2 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter3 = default;
			CvsCogEditingObject result2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<object> awaiter2;
						TaskAwaiter<CvsCogEditInfo[]> awaiter;
						switch (num2)
						{
						default:
							_003CeditRegionloc_003E5__2 = undoRegionPropertyAction.DropLocation;
							_003CeditRegionloc_003E5__2.Row++;
							awaiter2 = ((CvsCogSocketSheet)z58nDNsYEGE43On3qLvx(m0vLrZsYScTlNIti7pLK(undoRegionPropertyAction.InSight))).PutCellExpressionAsync(_003CeditRegionloc_003E5__2, undoRegionPropertyAction.apgq0vOT4F).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00d3;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00d3;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_019e;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0235;
						case 3:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0316;
						case 4:
							break;
							IL_0316:
							result = awaiter.GetResult();
							if (result != null && result.Length != 0)
							{
								_003CeditingObj_003E5__6 = null;
								break;
							}
							goto end_IL_0028;
							IL_00d3:
							awaiter2.GetResult();
							_003ClabelLoc_003E5__3 = undoRegionPropertyAction.DropLocation;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4 = _003ClabelLoc_003E5__3;
							_003CgetterLoc_003E5__4.Row++;
							_003Ci_003E5__5 = 0;
							goto IL_027d;
							IL_027d:
							if (_003Ci_003E5__5 < undoRegionPropertyAction.gv4q7MLkk7.Length)
							{
								awaiter2 = ((CvsCogSocketSheet)z58nDNsYEGE43On3qLvx(m0vLrZsYScTlNIti7pLK(undoRegionPropertyAction.InSight))).PutCellExpressionAsync(_003ClabelLoc_003E5__3, undoRegionPropertyAction.TH7qYDUWoB[_003Ci_003E5__5]).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
							((CvsCogSocketSheet)z58nDNsYEGE43On3qLvx(m0vLrZsYScTlNIti7pLK(undoRegionPropertyAction.InSight))).Run(true);
							awaiter = undoRegionPropertyAction.InSight.CogSocket.Sheet.GetEditInfoAsync(_003CeditRegionloc_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0316;
							IL_019e:
							awaiter2.GetResult();
							awaiter2 = undoRegionPropertyAction.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003CgetterLoc_003E5__4, string.Format(undoRegionPropertyAction.gv4q7MLkk7[_003Ci_003E5__5], _003CeditRegionloc_003E5__2.ToString())).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0235;
							IL_0235:
							awaiter2.GetResult();
							_003Ci_003E5__5++;
							_003ClabelLoc_003E5__3.Column++;
							_003CgetterLoc_003E5__4.Column++;
							goto IL_027d;
						}
						try
						{
							int num3;
							if (num2 != 4)
							{
								num3 = 9;
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								num3 = 7;
							}
							while (true)
							{
								switch (num3)
								{
								case 5:
									_003C_003Eu__3 = awaiter3;
									goto default;
								case 3:
									num2 = (_003C_003E1__state = 4);
									num3 = 5;
									continue;
								case 0:
									num2 = (_003C_003E1__state = -1);
									goto IL_03bb;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 2;
									continue;
								case 9:
									awaiter3 = ((CvsCogSocketSheet)z58nDNsYEGE43On3qLvx(m0vLrZsYScTlNIti7pLK(undoRegionPropertyAction.InSight))).EditEditableObjectAsync((string)sH66OqsYv7uCllQgeqC8(result[0])).GetAwaiter();
									_ = 0;
									num3 = (VVmiZisYLmvAyTI7VoUx() ? 8 : 6);
									continue;
								case 1:
								case 8:
									if (!awaiter3.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto IL_03bb;
								case 7:
									_003C_003Eu__3 = default;
									num3 = 0;
									continue;
								case 2:
									return;
								case 10:
									{
										_003CeditingObj_003E5__6 = result2;
										break;
									}
									IL_03bb:
									result2 = awaiter3.GetResult();
									num3 = 10;
									continue;
								}
								break;
							}
						}
						catch (Exception)
						{
						}
						if (_003CeditingObj_003E5__6 is CvsCogEditingShape cvsCogEditingShape)
						{
							TmdXhusYHkiqQ5w2cWAl(z58nDNsYEGE43On3qLvx(m0vLrZsYScTlNIti7pLK(undoRegionPropertyAction.InSight)), cvsCogEditingShape.Url, undoRegionPropertyAction.MHkqwnmr1u);
						}
						_003CeditingObj_003E5__6 = null;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					undoRegionPropertyAction = _003C_003E4__this;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
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
		internal static object m0vLrZsYScTlNIti7pLK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z58nDNsYEGE43On3qLvx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sH66OqsYv7uCllQgeqC8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TmdXhusYHkiqQ5w2cWAl(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ApplyEditableObjectAndRunSheet((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VVmiZisYLmvAyTI7VoUx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BeNlTlsY9tAt4hSJJefT()
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

		public UndoRegionPropertyAction _003C_003E4__this;

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
			int num = 5;
			UndoRegionPropertyAction undoRegionPropertyAction = default;
			int num2 = default;
			CvsCellRange[] modifiedCells = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellRange cellRange = default;
			do
			{
				IL_0286:
				switch (num)
				{
				case 0:
				case 1:
					undoRegionPropertyAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							modifiedCells = undoRegionPropertyAction.ModifiedCells;
							_ = 0;
							num3 = ((!cgminasYVlGQtUegSapu()) ? 10 : 3);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 14:
							{
								if (_003C_003E7__wrap2 >= _003C_003E7__wrap1.Length)
								{
									_003C_003E7__wrap1 = null;
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 9;
								}
								CvsCellRange cvsCellRange = _003C_003E7__wrap1[_003C_003E7__wrap2];
								cellRange = new CvsCellRange(undoRegionPropertyAction.DropLocation.Row + cvsCellRange.Row, undoRegionPropertyAction.DropLocation.Column + cvsCellRange.Column, cvsCellRange.Rows, cvsCellRange.Columns);
								num3 = 12;
								continue;
							}
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 13;
								continue;
							case 12:
								awaiter = ((CvsCogSocketSheet)KINUrKsYU66CkooUXxur(ARKB09sYDYva5HXFGULL(undoRegionPropertyAction.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 11;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (cgminasYVlGQtUegSapu())
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 13:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter.GetResult();
								num3 = 7;
								continue;
							case 0:
							case 3:
								_003C_003E7__wrap1 = modifiedCells;
								goto case 1;
							case 1:
							case 10:
								_003C_003E7__wrap2 = 0;
								num3 = 5;
								continue;
							case 7:
								_003C_003E7__wrap2++;
								num3 = 14;
								continue;
							case 15:
								undoRegionPropertyAction.InSight.MakeNewResult(updateExposedResults: true, runSheet: true);
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
				default:
					num = 4;
					if (cgminasYVlGQtUegSapu())
					{
						goto IL_0286;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					U1n8U6sYAY2PNMb3Dk2b();
					num = ((!cgminasYVlGQtUegSapu()) ? 3 : 0);
					goto IL_0286;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object ARKB09sYDYva5HXFGULL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KINUrKsYU66CkooUXxur(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cgminasYVlGQtUegSapu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U1n8U6sYAY2PNMb3Dk2b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private string[] TH7qYDUWoB;

	private string[] gv4q7MLkk7;

	private CvsCellRange N3cqmlIqFN;

	private CvsCellRange CP1qnX2KIR;

	private CvsCellRange QTDq9aGBfL;

	private CvsCellRange YX6qUqnsQ3;

	private string apgq0vOT4F;

	private CvsCogRegion MHkqwnmr1u;

	[CompilerGenerated]
	private CvsInSight bGmqR81Ze1;

	private CvsCellLocation WRrqs2b3fd;

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
			return bGmqR81Ze1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bGmqR81Ze1 = value;
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
			return WRrqs2b3fd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sEAhWuCZSLgdxAdNaUt();
			int num;
			if (!YgR9iHCJPiBA1TMlG5S())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					YX6qUqnsQ3 = new CvsCellRange(WRrqs2b3fd.Row + CP1qnX2KIR.Row, WRrqs2b3fd.Column + CP1qnX2KIR.Column, CP1qnX2KIR.Rows, CP1qnX2KIR.Columns);
					num = 5;
					if (YgR9iHCJPiBA1TMlG5S())
					{
					}
					break;
				case 1:
				case 4:
					WRrqs2b3fd = value;
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
			return new CvsCellRange[2] { N3cqmlIqFN, QTDq9aGBfL };
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
			return YX6qUqnsQ3;
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
			return (string)uCMOEpKsLoXsUk8VWHN();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoRegionPropertyAction(string editRegionExpression, CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (sEAhWuCZSLgdxAdNaUt())
		{
			num = 10;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_017f;
		IL_0026:
		N3cqmlIqFN = new CvsCellRange(0, 1, 1, TH7qYDUWoB.Length);
		num = 11;
		goto IL_017f;
		IL_017f:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				TH7qYDUWoB = new string[6]
				{
					(string)VKVqLdCzX9yTk57Vb2W(16916),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16924),
					(string)VKVqLdCzX9yTk57Vb2W(17294),
					(string)VKVqLdCzX9yTk57Vb2W(17310),
					(string)VKVqLdCzX9yTk57Vb2W(17328),
					(string)VKVqLdCzX9yTk57Vb2W(17344)
				};
				num = 7;
				continue;
			case 11:
				CP1qnX2KIR = new CvsCellRange(1, 1, 1, gv4q7MLkk7.Length);
				goto case 3;
			case 8:
				MHkqwnmr1u = region;
				num = 1;
				continue;
			case 6:
				WRrqs2b3fd = CvsCellLocation.Invalid;
				num = 5;
				continue;
			case 7:
				gv4q7MLkk7 = new string[6]
				{
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16950),
					(string)VKVqLdCzX9yTk57Vb2W(16972),
					(string)VKVqLdCzX9yTk57Vb2W(17360),
					(string)VKVqLdCzX9yTk57Vb2W(17390),
					(string)VKVqLdCzX9yTk57Vb2W(17422),
					(string)VKVqLdCzX9yTk57Vb2W(17452)
				};
				num = 4;
				if (sEAhWuCZSLgdxAdNaUt())
				{
					continue;
				}
				goto case 5;
			case 5:
				tSN1KPKwGNT0MTusmw8(this);
				apgq0vOT4F = editRegionExpression;
				goto case 8;
			default:
				num = 8;
				continue;
			case 0:
			case 10:
				LjPZFfC8v96RKTDo5A9();
				num = 2;
				if (sEAhWuCZSLgdxAdNaUt())
				{
					continue;
				}
				goto case 4;
			case 4:
				YX6qUqnsQ3 = CvsCellRange.Invalid;
				num = 6;
				continue;
			case 3:
			case 9:
				QTDq9aGBfL = new CvsCellRange(1, 0, 1, gv4q7MLkk7.Length + 1);
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 12:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__23))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YgR9iHCJPiBA1TMlG5S();
		int num;
		if (sEAhWuCZSLgdxAdNaUt())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_006d:
		_003CSaveState_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto IL_006d;
			case 2:
				goto IL_006d;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = nFTX2vKhMbt9xnOIGLL();
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_006d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__24))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YgR9iHCJPiBA1TMlG5S();
		int num = (sEAhWuCZSLgdxAdNaUt() ? 1 : 4);
		_003CDo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = nFTX2vKhMbt9xnOIGLL();
				num = 5;
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
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__25))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sEAhWuCZSLgdxAdNaUt();
		int num;
		if (!YgR9iHCJPiBA1TMlG5S())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (YgR9iHCJPiBA1TMlG5S())
			{
				goto IL_0060;
			}
		}
		goto IL_007a;
		IL_002a:
		_003CRedo_003Ed__25 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (1 == 0)
		{
			goto IL_003e;
		}
		goto IL_007a;
		IL_003e:
		stateMachine._003C_003Et__builder = nFTX2vKhMbt9xnOIGLL();
		goto IL_002a;
		IL_007a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 0:
			case 5:
				goto IL_003e;
			case 2:
				goto IL_0060;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_00a5;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_00a5:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_007a;
		IL_0060:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__26))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUndo_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = nFTX2vKhMbt9xnOIGLL();
				num = 1;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (YgR9iHCJPiBA1TMlG5S())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (sEAhWuCZSLgdxAdNaUt())
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
	internal static void LjPZFfC8v96RKTDo5A9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VKVqLdCzX9yTk57Vb2W(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tSN1KPKwGNT0MTusmw8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sEAhWuCZSLgdxAdNaUt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YgR9iHCJPiBA1TMlG5S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uCMOEpKsLoXsUk8VWHN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DropRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder nFTX2vKhMbt9xnOIGLL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
