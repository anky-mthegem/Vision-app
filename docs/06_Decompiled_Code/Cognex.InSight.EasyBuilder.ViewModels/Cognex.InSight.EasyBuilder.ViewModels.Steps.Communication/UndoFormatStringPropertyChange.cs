using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class UndoFormatStringPropertyChange<T> : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringPropertyChange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			UndoFormatStringPropertyChange<T> undoFormatStringPropertyChange = default;
			int num2 = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					undoFormatStringPropertyChange = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (true ? 4 : 5);
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezFormatStringViewModel = undoFormatStringPropertyChange.gqAkQVNB5g();
							num3 = 7;
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
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = ((1 == 0) ? 4 : 0);
								continue;
							case 4:
								return;
							case 5:
								return;
							case 7:
								awaiter = undoFormatStringPropertyChange.rfSkgupf53(ezFormatStringViewModel, undoFormatStringPropertyChange.uxLkWhO7Fg).GetAwaiter();
								num3 = 2;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
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
					break;
				default:
					num = 0;
					continue;
				case 0:
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
		internal static bool fZnMBh5d8hH7gCHZdi2f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yrrjoB5dqqX3AatpD44H()
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
	private struct _003CRedo_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringPropertyChange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (true ? 1 : 3);
			int num2 = default;
			UndoFormatStringPropertyChange<T> undoFormatStringPropertyChange = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoFormatStringPropertyChange.Do().GetAwaiter();
							_ = 0;
							num3 = (true ? 1 : 7);
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
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 7:
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 2;
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
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					undoFormatStringPropertyChange = _003C_003E4__this;
					goto case 2;
				case 4:
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
		internal static bool L8ZNRP5dEahObePv3ihx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool krYZCq5dpINZPpd1eAE6()
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
	private struct _003CUndo_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringPropertyChange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			UndoFormatStringPropertyChange<T> undoFormatStringPropertyChange = default;
			int num2 = default;
			EzFormatStringViewModel ezFormatStringViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					undoFormatStringPropertyChange = _003C_003E4__this;
					num = 4;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((1 == 0) ? 2 : 0);
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezFormatStringViewModel = undoFormatStringPropertyChange.gqAkQVNB5g();
							num3 = 3;
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
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 1:
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 3:
								awaiter = undoFormatStringPropertyChange.rfSkgupf53(ezFormatStringViewModel, undoFormatStringPropertyChange.yREkTrg1Nu).GetAwaiter();
								_ = 0;
								num3 = (true ? 4 : 9);
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 0:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 10:
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
		internal static bool jNrIYD5dXgJT6b26tlpA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oSi84Q5d9AqICE3kJU18()
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
	private struct _003CWriteProperty_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoFormatStringPropertyChange<T> _003C_003E4__this;

		public EzFormatStringViewModel vm;

		public T value;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoFormatStringPropertyChange<T> undoFormatStringPropertyChange = default;
			int num2 = default;
			string qCrkl1OBo = default;
			TaskAwaiter awaiter = default;
			uint num4 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					undoFormatStringPropertyChange = _003C_003E4__this;
					_ = 0;
					num = (true ? 1 : 4);
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							qCrkl1OBo = undoFormatStringPropertyChange.QCrkl1OBo2;
							num3 = 29;
							goto IL_038c;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 34;
							goto IL_038c;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 38;
							goto IL_038c;
						case 2:
							awaiter = _003C_003Eu__1;
							goto IL_074f;
						case 5:
							awaiter = _003C_003Eu__1;
							num3 = 16;
							goto IL_038c;
						case 4:
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = ((1 == 0) ? 2 : 0);
							goto IL_038c;
						case 6:
							awaiter = _003C_003Eu__1;
							num3 = 37;
							goto IL_038c;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 36;
								goto IL_038c;
							}
							IL_038c:
							while (true)
							{
								switch (num3)
								{
								case 18:
									return;
								case 31:
									if (!awaiter.IsCompleted)
									{
										num3 = 27;
										continue;
									}
									goto case 12;
								case 2:
								case 48:
									awaiter.GetResult();
									num3 = 39;
									continue;
								case 47:
									_003C_003Eu__1 = awaiter;
									num3 = 55;
									continue;
								case 1:
									return;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 47;
										continue;
									}
									goto case 34;
								case 32:
									if (num4 <= 2033735801)
									{
										num3 = 28;
										continue;
									}
									if (num4 <= 2834199722u)
									{
										if (num4 != 2642257843u)
										{
											num3 = 14;
											continue;
										}
										if (qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29718))
										{
											awaiter = vm.FormatStringViewModel.SetWhichDelimiterAsync((FormatStringDelimiterType)Convert.ChangeType(value, typeof(FormatStringDelimiterType))).GetAwaiter();
											if (!awaiter.IsCompleted)
											{
												num3 = 21;
												continue;
											}
											goto IL_01a7;
										}
										goto end_IL_038c;
									}
									if (num4 != 2900577975u)
									{
										num3 = 9;
									}
									else if (qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29788))
									{
										awaiter = vm.FormatStringViewModel.SetCustomDelimiterAsync((string)Convert.ChangeType(value, typeof(string))).GetAwaiter();
										num3 = 35;
									}
									else
									{
										num3 = 22;
									}
									continue;
								case 20:
									num2 = (_003C_003E1__state = 2);
									num3 = 30;
									continue;
								case 6:
									goto end_IL_038c;
								case 11:
									num2 = (_003C_003E1__state = -1);
									goto IL_01a7;
								case 37:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 57;
									continue;
								case 43:
									_003C_003Eu__1 = awaiter;
									num3 = 24;
									continue;
								case 30:
									_003C_003Eu__1 = awaiter;
									num3 = 46;
									continue;
								case 22:
									goto end_IL_038c;
								case 54:
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__1 = awaiter;
									num3 = 26;
									continue;
								case 0:
								case 40:
									_003C_003Eu__1 = default;
									num3 = 11;
									continue;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										num3 = 43;
										continue;
									}
									goto case 2;
								case 16:
									_003C_003Eu__1 = default;
									num3 = 49;
									continue;
								case 45:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 27:
									num2 = (_003C_003E1__state = 3);
									num3 = 19;
									continue;
								case 12:
									awaiter.GetResult();
									goto end_IL_038c;
								case 46:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 52;
									continue;
								case 35:
									if (!awaiter.IsCompleted)
									{
										num3 = 54;
										continue;
									}
									goto case 57;
								case 36:
									_003C_003Eu__1 = default;
									num3 = 50;
									continue;
								case 24:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 5;
									continue;
								case 41:
									goto end_IL_038c;
								case 3:
									switch (num4)
									{
									case 1257157120u:
										if (!(qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29666)))
										{
											goto end_IL_038c;
										}
										awaiter = vm.FormatStringViewModel.SetTerminatorAsync((FormatStringTerminator)Convert.ChangeType(value, typeof(FormatStringTerminator))).GetAwaiter();
										num3 = 33;
										break;
									default:
										num3 = 23;
										break;
									case 2033735801u:
										if (qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29750))
										{
											awaiter = vm.FormatStringViewModel.SetStandardDelimiterAsync((FormatStringDelimiter)Convert.ChangeType(value, typeof(FormatStringDelimiter))).GetAwaiter();
											num3 = 7;
										}
										else
										{
											num3 = 44;
										}
										break;
									}
									continue;
								case 13:
									if (!awaiter.IsCompleted)
									{
										num3 = 42;
										continue;
									}
									goto case 25;
								case 34:
									awaiter.GetResult();
									num3 = 53;
									continue;
								case 42:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									continue;
								case 39:
									goto end_IL_038c;
								case 9:
									if (num4 == 4000293869u)
									{
										if (qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29690))
										{
											awaiter = vm.FormatStringViewModel.SetUseDelimiterAsync((bool)Convert.ChangeType(value, typeof(bool))).GetAwaiter();
											num3 = 31;
										}
										else
										{
											num3 = 51;
										}
									}
									else
									{
										num3 = 56;
									}
									continue;
								case 10:
									awaiter.GetResult();
									num3 = 6;
									continue;
								case 53:
									goto end_IL_038c;
								case 33:
									if (!awaiter.IsCompleted)
									{
										num3 = 20;
										continue;
									}
									goto case 10;
								case 23:
									goto end_IL_038c;
								case 26:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 17;
									continue;
								case 14:
									if (num4 == 2834199722u && qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29612))
									{
										awaiter = vm.FormatStringViewModel.SetLeadingTextAsync((string)Convert.ChangeType(value, typeof(string))).GetAwaiter();
										num3 = 13;
										continue;
									}
									goto end_IL_038c;
								case 49:
									num2 = (_003C_003E1__state = -1);
									goto case 2;
								case 29:
									num4 = _003CPrivateImplementationDetails_003E.ComputeStringHash(qCrkl1OBo);
									num3 = 32;
									continue;
								case 5:
									return;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 28:
									if (num4 != 378987374)
									{
										num3 = 3;
									}
									else if (qCrkl1OBo == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29638))
									{
										awaiter = vm.FormatStringViewModel.SetTrailingTextAsync((string)Convert.ChangeType(value, typeof(string))).GetAwaiter();
										num3 = 4;
									}
									else
									{
										num3 = 41;
									}
									continue;
								case 17:
									return;
								case 55:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 18;
									continue;
								case 52:
									break;
								case 25:
									awaiter.GetResult();
									goto end_IL_038c;
								case 38:
									num2 = (_003C_003E1__state = -1);
									num3 = 12;
									continue;
								case 51:
									goto end_IL_038c;
								case 15:
									return;
								case 19:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 1;
									continue;
								case 56:
									goto end_IL_038c;
								case 50:
									num2 = (_003C_003E1__state = -1);
									num3 = 25;
									continue;
								case 44:
									goto end_IL_038c;
								case 21:
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								case 57:
									{
										awaiter.GetResult();
										goto end_IL_038c;
									}
									IL_01a7:
									awaiter.GetResult();
									goto end_IL_038c;
								}
								goto IL_074f;
								continue;
								end_IL_038c:
								break;
							}
							break;
							IL_074f:
							_003C_003Eu__1 = default;
							num3 = 45;
							goto IL_038c;
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
		internal static bool C9llAq5d4wTtEinAuKCD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sYMWFP5d7wrOu5yC0VgB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CommStepViewModel JIGkRiKT3f;

	private Type DnRk4iUR1M;

	private string QCrkl1OBo2;

	private T yREkTrg1Nu;

	private T uxLkWhO7Fg;

	private Type[] G9Ikj8PnIL;

	[CompilerGenerated]
	private string JoBkC5Ixba;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JoBkC5Ixba;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JoBkC5Ixba = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFormatStringPropertyChange(CommStepViewModel commAppStep, Type type, string propertyName, T oldValue, T newValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		G9Ikj8PnIL = new Type[3]
		{
			typeof(WriteDataFtp),
			typeof(WriteDataSerial),
			typeof(WriteTcpIp)
		};
		base._002Ector();
		if (!G9Ikj8PnIL.Contains(type))
		{
			throw new NotSupportedException(type.ToString());
		}
		JIGkRiKT3f = commAppStep;
		DnRk4iUR1M = type;
		QCrkl1OBo2 = propertyName;
		yREkTrg1Nu = oldValue;
		uxLkWhO7Fg = newValue;
		Text = string.Format(Resources.jG8ti4sE3u(), propertyName, oldValue, newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoFormatStringPropertyChange<>._003CDo_003Ed__11))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 4 : 3);
		_003CDo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoFormatStringPropertyChange<>._003CRedo_003Ed__12))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 1 : 5);
		_003CRedo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoFormatStringPropertyChange<>._003CUndo_003Ed__14))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CUndo_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = ((1 == 0) ? 4 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel gqAkQVNB5g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		EzFormatStringViewModel result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				result = null;
				num = 4;
				continue;
			default:
				num = 1;
				continue;
			case 4:
				if (!(DnRk4iUR1M == typeof(WriteDataFtp)))
				{
					if (DnRk4iUR1M == typeof(WriteDataSerial))
					{
						goto case 1;
					}
					if (DnRk4iUR1M == typeof(WriteTcpIp))
					{
						num = 0;
						continue;
					}
					break;
				}
				num = 8;
				continue;
			case 8:
				result = JIGkRiKT3f.WriteDataFtp.FormatString;
				_ = 0;
				num = ((1 == 0) ? 7 : 6);
				continue;
			case 0:
				result = JIGkRiKT3f.WriteTcpIp.FormatString;
				num = 9;
				continue;
			case 1:
				result = JIGkRiKT3f.WriteDataSerial.FormatString;
				break;
			case 3:
			case 5:
			case 6:
			case 7:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoFormatStringPropertyChange<>._003CWriteProperty_003Ed__16))]
	private Task rfSkgupf53(EzFormatStringViewModel P_0, T gLCfyXXQdJuoyKQ19Z)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteProperty_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.vm = P_0;
		stateMachine.value = gLCfyXXQdJuoyKQ19Z;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YTUSeK1TvDiK8Z9vLHd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NsaZ661ym2YaaUexp5y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
