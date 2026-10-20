using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class UndoGraphicChange : IUndoAction, IMergeableUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0185;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0185;
			IL_0185:
			int num2 = default;
			UndoGraphicChange undoGraphicChange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoGraphicChange.LjjvachCrp(undoGraphicChange.KUZvF5rJc0()).GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!TkXROR5KKKF2g0DI2MCe())
							{
								goto IL_006d;
							}
						}
						while (true)
						{
							IL_008d:
							switch (num3)
							{
							case 4:
								return;
							case 7:
								break;
							default:
								num3 = 4;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 6;
							case 0:
								while (!awaiter.IsCompleted)
								{
									_ = 1;
									if (X9djWU5K5d53EjeiF8fh())
									{
										num3 = 8;
										if (0 == 0)
										{
											goto IL_008d;
										}
										continue;
									}
									goto IL_011f;
								}
								goto case 9;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								{
									awaiter.GetResult();
									goto end_IL_008d;
								}
								IL_011f:
								num3 = 2;
								if (TkXROR5KKKF2g0DI2MCe())
								{
									continue;
								}
								goto case 1;
							}
							goto IL_006d;
							continue;
							end_IL_008d:
							break;
						}
						goto end_IL_002f;
						IL_006d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_002f:;
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
					num2 = _003C_003E1__state;
					TkXROR5KKKF2g0DI2MCe();
					num = ((!X9djWU5K5d53EjeiF8fh()) ? 2 : 4);
					continue;
				case 1:
				case 2:
					undoGraphicChange = _003C_003E4__this;
					num = 0;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static bool TkXROR5KKKF2g0DI2MCe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X9djWU5K5d53EjeiF8fh()
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

		public UndoGraphicChange _003C_003E4__this;

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
			if (EDIAHP5Kwg9SwF3iNGa5())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_02b4;
				}
			}
			goto IL_0270;
			IL_003d:
			int num2 = default;
			UndoGraphicChange undoGraphicChange = default;
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__1;
						goto IL_00ef;
					}
					num3 = 13;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 15;
					if (bkXaPN5KJgUJ6MVUEv0S())
					{
					}
				}
				goto IL_0168;
				IL_010b:
				if (!awaiter.IsCompleted)
				{
					num2 = (_003C_003E1__state = 1);
					num3 = 4;
					goto IL_0168;
				}
				goto IL_0230;
				IL_0168:
				while (true)
				{
					switch (num3)
					{
					case 7:
						return;
					case 2:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							if (EDIAHP5Kwg9SwF3iNGa5())
							{
								continue;
							}
							goto case 13;
						}
						goto IL_014f;
					case 13:
						awaiter = ApqdN45KaeI4E6M2UZQe(undoGraphicChange.LjjvachCrp(undoGraphicChange.KUZvF5rJc0()));
						num3 = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						if (true)
						{
							continue;
						}
						goto case 5;
					case 5:
						undoGraphicChange.lSov5VpqEn();
						num3 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 12:
					case 14:
						break;
					case 10:
						goto IL_010b;
					case 8:
						awaiter = undoGraphicChange.ztCvUUgjsj(undoGraphicChange.KUZvF5rJc0()).GetAwaiter();
						num3 = 10;
						continue;
					case 6:
					case 11:
						num2 = (_003C_003E1__state = -1);
						goto IL_014f;
					default:
						num3 = 5;
						continue;
					case 15:
						goto IL_01bb;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						continue;
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 4:
						_003C_003Eu__1 = awaiter;
						num3 = 9;
						continue;
					case 16:
						goto IL_0230;
						IL_014f:
						awaiter.GetResult();
						goto case 5;
					}
					break;
					IL_01bb:
					_003C_003Eu__1 = default;
					_ = 0;
					num3 = ((!EDIAHP5Kwg9SwF3iNGa5()) ? 14 : 11);
				}
				goto IL_00ef;
				IL_0230:
				awaiter.GetResult();
				goto end_IL_003d;
				IL_00ef:
				_003C_003Eu__1 = default;
				num3 = 1;
				if (bkXaPN5KJgUJ6MVUEv0S())
				{
					goto IL_010b;
				}
				goto IL_0168;
				end_IL_003d:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_02b4;
			IL_0270:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 4:
					goto IL_003d;
				default:
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 5:
					goto IL_02b4;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			undoGraphicChange = _003C_003E4__this;
			num = 4;
			if (!EDIAHP5Kwg9SwF3iNGa5())
			{
				goto IL_003d;
			}
			goto IL_0270;
			IL_02b4:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0270;
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
		internal static TaskAwaiter ApqdN45KaeI4E6M2UZQe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EDIAHP5Kwg9SwF3iNGa5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bkXaPN5KJgUJ6MVUEv0S()
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
	private struct _003CSaveState_003Ed__26 : IAsyncStateMachine
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
			_ = 1;
			int num;
			if (!NIFBTJ5KORBBTh1exOFp())
			{
				num = 4;
				if (!OOSwKP5KeMjple8ixIgn())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (!OOSwKP5KeMjple8ixIgn())
				{
					goto IL_01a0;
				}
			}
			goto IL_016d;
			IL_01a0:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_016d;
			IL_016d:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				default:
					goto IL_01a0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					if (true)
					{
						continue;
					}
					return;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((Task)eh71Pa5KIxC38EXVTKje()).GetAwaiter();
					num3 = 4;
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
					case 8:
						_003C_003Eu__1 = default;
						goto case 5;
					case 0:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						continue;
					case 4:
						if (!awaiter.IsCompleted)
						{
							NIFBTJ5KORBBTh1exOFp();
							num3 = (OOSwKP5KeMjple8ixIgn() ? 3 : 5);
							continue;
						}
						break;
					case 5:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 7:
						return;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
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
			goto IL_01a0;
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
		internal static object eh71Pa5KIxC38EXVTKje()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OOSwKP5KeMjple8ixIgn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NIFBTJ5KORBBTh1exOFp()
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
	private struct _003CUndo_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HJEjqg5KimcHssfAHxsw();
			int num = ((!uJ7HaF5KDlTVdciCV17I()) ? 2 : 4);
			UndoGraphicChange undoGraphicChange = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoGraphicChange = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_007f;
							}
						}
						goto IL_01e3;
						IL_01e3:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 10:
								return;
							case 7:
								break;
							case 15:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								awaiter.GetResult();
								undoGraphicChange.g8Svph8MAQ();
								num3 = 5;
								if (!HJEjqg5KimcHssfAHxsw())
								{
									continue;
								}
								goto case 5;
							case 5:
								awaiter = T1nZTa5KnpZNW0co0Sn9(undoGraphicChange.ztCvUUgjsj(undoGraphicChange.pdsv6axufb()));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									if (uJ7HaF5KDlTVdciCV17I())
									{
										continue;
									}
									goto case 0;
								}
								goto case 16;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter;
								HJEjqg5KimcHssfAHxsw();
								if (uJ7HaF5KDlTVdciCV17I())
								{
									num3 = 2;
									continue;
								}
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 6:
								return;
							case 9:
								awaiter = T1nZTa5KnpZNW0co0Sn9(undoGraphicChange.LjjvachCrp(undoGraphicChange.pdsv6axufb()));
								if (!awaiter.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 1;
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_01e3;
							}
							goto IL_007f;
							continue;
							end_IL_01e3:
							break;
						}
						goto end_IL_0050;
						IL_007f:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						if (HJEjqg5KimcHssfAHxsw())
						{
						}
						goto IL_01e3;
						end_IL_0050:;
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
					if (true)
					{
						continue;
					}
					break;
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
		internal static TaskAwaiter T1nZTa5KnpZNW0co0Sn9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uJ7HaF5KDlTVdciCV17I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HJEjqg5KimcHssfAHxsw()
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
	private struct _003CWrite_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicChange _003C_003E4__this;

		public CvsEditableDisplayGraphic graphic;

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
			UndoGraphicChange undoGraphicChange = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					undoGraphicChange = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					Ed9VJv5Kfv9V12OnIPk4();
					if (OGFeZy5KVXYjOqEo5J7y())
					{
						num = 5;
						if (OGFeZy5KVXYjOqEo5J7y())
						{
							continue;
						}
						goto case 4;
					}
					num = 2;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 10;
								if (!OGFeZy5KVXYjOqEo5J7y())
								{
									goto IL_006d;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_00f6;
						IL_006d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 12;
						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 9:
								break;
							case 6:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 14;
									continue;
								}
								goto case 16;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 10:
								awaiter2 = B1AjU05KlT8oOakpUOBf(EditableGraphicHelper.SendGraphicAsync(undoGraphicChange.pu3vcqNwqT, q8iCjb5Kdk2wxfA1rlEu(graphic), graphic));
								num3 = 15;
								continue;
							case 12:
								return;
							case 1:
								_003C_003Eu__1 = awaiter2;
								Ed9VJv5Kfv9V12OnIPk4();
								num3 = ((!OGFeZy5KVXYjOqEo5J7y()) ? 6 : 9);
								continue;
							case 3:
								return;
							case 13:
								_003C_003Eu__2 = default;
								num3 = 7;
								continue;
							case 14:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								if (!awaiter2.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 5;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (!Ed9VJv5Kfv9V12OnIPk4())
								{
									continue;
								}
								goto case 5;
							case 5:
								awaiter2.GetResult();
								awaiter = ((CvsCogSocketSheet)kVyAOo5KsfogumN2eWuh(Y98ys95KgwnFkmRTBUml(undoGraphicChange.pu3vcqNwqT))).RunAsync(false).GetAwaiter();
								goto case 6;
							case 16:
								awaiter.GetResult();
								goto end_IL_00f6;
							}
							goto IL_006d;
							continue;
							end_IL_00f6:
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
		internal static CvsCellLocation q8iCjb5Kdk2wxfA1rlEu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter B1AjU05KlT8oOakpUOBf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y98ys95KgwnFkmRTBUml(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kVyAOo5KsfogumN2eWuh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OGFeZy5KVXYjOqEo5J7y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ed9VJv5Kfv9V12OnIPk4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public CvsEditableDisplayGraphic newSubregion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass31_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			j893405KP9Md30XZShCY();
			wVbH855KZSZeDqdFCZvo(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CDoUpdateSubregions_003Eb__0(ICvsEditableDisplayGraphic graphic)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HVFNo55KoYuphZoXYjWF(((CvsGraphic)kmEb3o5KBotuTaKFmGSm(graphic)).UniqueId, bUrQZC5KGwg8Tx25ydai(haTEJM5Kbu8wV7LlQOy0(newSubregion)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void j893405KP9Md30XZShCY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wVbH855KZSZeDqdFCZvo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PyuI4R5Kvp2Mdum8T05a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PnGHeZ5Krcys3Ma0XQfY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kmEb3o5KBotuTaKFmGSm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object haTEJM5Kbu8wV7LlQOy0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bUrQZC5KGwg8Tx25ydai(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).UniqueId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HVFNo55KoYuphZoXYjWF(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public CvsEditableDisplayGraphic oldSubregion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass32_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			llkZrF5K80m2O7y4OwRp();
			fcuJ0R5KqUUYnWS77oE9(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUndoUpdateSubregions_003Eb__0(ICvsEditableDisplayGraphic graphic)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JdD8g05KX8HFVowcpVJv(k7HjLU5KES10RMoALDOT(graphic.InSightGraphic), k7HjLU5KES10RMoALDOT(CWAjkv5Kp5GKZHPL9cwL(oldSubregion)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void llkZrF5K80m2O7y4OwRp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fcuJ0R5KqUUYnWS77oE9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GE1HGK5KSfQA0Q1YKZZy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wBy91h5KkpgoFacdkGtK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k7HjLU5KES10RMoALDOT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).UniqueId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CWAjkv5Kp5GKZHPL9cwL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JdD8g05KX8HFVowcpVJv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateGraphic_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoGraphicChange _003C_003E4__this;

		public CvsEditableDisplayGraphic graphic;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QHuMsg5K4AU8y6Mq3Q8L();
			int num = ((!qX0dWZ5K9d9OVaiFAD9M()) ? 4 : 5);
			UndoGraphicChange undoGraphicChange = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					undoGraphicChange = _003C_003E4__this;
					num = 1;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (!qX0dWZ5K9d9OVaiFAD9M())
							{
								goto IL_00ca;
							}
							goto IL_00e3;
						}
						if (undoGraphicChange.Display != null)
						{
							num3 = 0;
							goto IL_00e3;
						}
						goto end_IL_0061;
						IL_0120:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						if (0 == 0)
						{
							goto IL_00e3;
						}
						goto IL_013a;
						IL_00ca:
						_003C_003Eu__1 = awaiter;
						goto IL_0120;
						IL_013a:
						awaiter = ((Task)S6iwnl5K32FjbUbnIY6Y(uDlfEM5K7oTHyVGq5dYy(undoGraphicChange.Display), graphic)).GetAwaiter();
						num3 = 6;
						goto IL_00e3;
						IL_00e3:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								return;
							case 2:
							case 3:
								goto end_IL_00e3;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0120;
							case 8:
								goto IL_0120;
							case 0:
								goto IL_013a;
							case 4:
								_003C_003Eu__1 = default;
								goto case 1;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0061;
							}
							num2 = (_003C_003E1__state = 0);
							_ = 0;
							if (qX0dWZ5K9d9OVaiFAD9M())
							{
								num3 = 2;
								continue;
							}
							num3 = 1;
							if (QHuMsg5K4AU8y6Mq3Q8L())
							{
							}
							continue;
							end_IL_00e3:
							break;
						}
						goto IL_00ca;
						end_IL_0061:;
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
		internal static object uDlfEM5K7oTHyVGq5dYy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSightDisplay)P_0).InteractiveGraphics;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S6iwnl5K32FjbUbnIY6Y(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSightDisplayInteractiveGraphics)P_0).UpdateGraphic((CvsEditableDisplayGraphic)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qX0dWZ5K9d9OVaiFAD9M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QHuMsg5K4AU8y6Mq3Q8L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public ICvsEditableDisplayGraphic newSubregion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass34_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sITh535KCmmlGUwUt1yJ();
			gNBg585KAC4pOUwSSxMt(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetSubregion_003Eb__2(ICvsEditableDisplayGraphic oldSubregion)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FcyMXi5KTifhenjEdlch(gPLH915KWLt30yDsbZA7(a6Vtm95KRxioZV04KYrQ(oldSubregion)), ((CvsGraphic)a6Vtm95KRxioZV04KYrQ(newSubregion)).UniqueId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sITh535KCmmlGUwUt1yJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gNBg585KAC4pOUwSSxMt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AWsSfV5KjxkE5EbaUfq6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KgEnDi5K6nqM16eF0qA2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a6Vtm95KRxioZV04KYrQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gPLH915KWLt30yDsbZA7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).UniqueId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FcyMXi5KTifhenjEdlch(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_1
	{
		public ICvsEditableDisplayGraphic oldSubregion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass34_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FMwCwf5KFRRsD9rABc8q();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetSubregion_003Eb__3(ICvsEditableDisplayGraphic newSubregion)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)bMbwXL5KYjNVGgBTf4fh(C2Osak5KMgpXvOLXKpmE(newSubregion)) == (string)bMbwXL5KYjNVGgBTf4fh(oldSubregion.InSightGraphic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FMwCwf5KFRRsD9rABc8q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hYA6fI5Ky0Leg4xe4Gwb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MjTgvE5K0Rud1CLtrFdt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C2Osak5KMgpXvOLXKpmE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bMbwXL5KYjNVGgBTf4fh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).UniqueId;
		}
	}

	private static readonly TimeSpan wiLvEOESmE;

	public bool _isSubregionChange;

	private DateTime IuJvbScoLk;

	private readonly CvsInSight pu3vcqNwqT;

	[CompilerGenerated]
	private readonly CvsEditableDisplayGraphic T6uvQs82yD;

	[CompilerGenerated]
	private CvsEditableDisplayGraphic N0ivgDFAlk;

	[CompilerGenerated]
	private ICvsEditableDisplayGraphic cX3vMUuuBu;

	[CompilerGenerated]
	private readonly string UMEvRpgHZl;

	[CompilerGenerated]
	private readonly CvsInSightDisplay keTv4OZJ2y;

	private string CellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UMEvRpgHZl;
		}
	}

	private CvsInSightDisplay Display
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return keTv4OZJ2y;
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
			return (string)aBdnySHj82YEtkvBAPl(Resources.pd1hOYqP56(), CellName, y4adLgH3PSL9Tdvqyhk(pdsv6axufb()), y4adLgH3PSL9Tdvqyhk(KUZvF5rJc0()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoGraphicChange(CvsInSight insight, string cellName, CvsEditableDisplayGraphic oldGraphic, CvsEditableDisplayGraphic newGraphic, CvsInSightDisplay display)
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
			case 0:
				IuJvbScoLk = DateTime.UtcNow;
				num = 7;
				continue;
			case 1:
			case 3:
				base._002Ector();
				goto case 2;
			case 2:
			case 6:
				pu3vcqNwqT = insight ?? throw new ArgumentNullException((string)CmtJCPH7dxwewE83SqN(28336));
				T6uvQs82yD = oldGraphic ?? throw new ArgumentNullException((string)CmtJCPH7dxwewE83SqN(28354));
				PnrvXa0Sun(newGraphic ?? throw new ArgumentNullException((string)CmtJCPH7dxwewE83SqN(28378)));
				UMEvRpgHZl = cellName ?? throw new ArgumentNullException((string)CmtJCPH7dxwewE83SqN(28402));
				keTv4OZJ2y = display;
				goto case 4;
			default:
				num = 4;
				continue;
			case 4:
				mNWv7JwhoG();
				num = 0;
				if (BCt2kIHXprLd62uFDm5())
				{
					continue;
				}
				break;
			case 5:
				break;
			case 7:
				return;
			}
			aoAgXpH4Lr9YOqlcQfC();
			_ = 0;
			if (!BCt2kIHXprLd62uFDm5())
			{
				num = 6;
				if (gfRGVZH9sMR0GT42v9j())
				{
				}
			}
			else
			{
				num = 3;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private CvsEditableDisplayGraphic pdsv6axufb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return T6uvQs82yD;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private CvsEditableDisplayGraphic KUZvF5rJc0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return N0ivgDFAlk;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void PnrvXa0Sun(CvsEditableDisplayGraphic value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N0ivgDFAlk = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private ICvsEditableDisplayGraphic i3svSrdVDI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return cX3vMUuuBu;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void KGrvDfEmfv(ICvsEditableDisplayGraphic value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cX3vMUuuBu = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__24))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0072;
		IL_001a:
		_003CDo_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
		gfRGVZH9sMR0GT42v9j();
		num = (BCt2kIHXprLd62uFDm5() ? 4 : 0);
		goto IL_0072;
		IL_0072:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__25))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
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
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 4:
				stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
				_ = 0;
				num = (BCt2kIHXprLd62uFDm5() ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__26))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSaveState_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
				BCt2kIHXprLd62uFDm5();
				if (!gfRGVZH9sMR0GT42v9j())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__27))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BCt2kIHXprLd62uFDm5();
		int num = (gfRGVZH9sMR0GT42v9j() ? 4 : 3);
		_003CUndo_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (BCt2kIHXprLd62uFDm5())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
				num = 5;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWrite_003Ed__28))]
	private Task LjjvachCrp(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CWrite_003Ed__28 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
				gfRGVZH9sMR0GT42v9j();
				if (BCt2kIHXprLd62uFDm5())
				{
					num = 5;
					break;
				}
				num = 2;
				if (BCt2kIHXprLd62uFDm5())
				{
					break;
				}
				goto case 1;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 0:
				stateMachine.graphic = P_0;
				goto case 6;
			default:
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanMerge(IUndoAction undoAction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		UndoGraphicChange undoGraphicChange = default;
		CvsCellLocation cellLocation = default;
		bool result = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (!qFTknWHWZfsNWZQ2EqF(qlnS4IHRWuHnLLboJuB(IuJvbScoLk, undoGraphicChange.IuJvbScoLk), wiLvEOESmE) || undoGraphicChange._isSubregionChange)
				{
					break;
				}
				num = 4;
				if (BCt2kIHXprLd62uFDm5())
				{
					continue;
				}
				goto default;
			default:
				if (!cellLocation.Equals(UEsmDPHAYwi8YNrcdZE(EGmVDxHCt2GB7qAaQYL(undoGraphicChange))))
				{
					break;
				}
				num = 6;
				if (BCt2kIHXprLd62uFDm5())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				if (KUZvF5rJc0().GetType() == undoGraphicChange.KUZvF5rJc0().GetType())
				{
					num = 9;
					if (gfRGVZH9sMR0GT42v9j())
					{
					}
					continue;
				}
				break;
			case 4:
				if (!_isSubregionChange)
				{
					num = 2;
					continue;
				}
				break;
			case 10:
				if (undoGraphicChange != null)
				{
					BCt2kIHXprLd62uFDm5();
					num = ((!gfRGVZH9sMR0GT42v9j()) ? 1 : 8);
					continue;
				}
				break;
			case 7:
				result = false;
				num = 0;
				continue;
			case 9:
				cellLocation = KUZvF5rJc0().CellLocation;
				goto default;
			case 2:
				result = true;
				num = 11;
				continue;
			case 0:
				undoGraphicChange = undoAction as UndoGraphicChange;
				num = 10;
				continue;
			case 11:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MergeInto(IUndoAction undoAction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!gfRGVZH9sMR0GT42v9j()) ? 1 : 4);
		UndoGraphicChange undoGraphicChange = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				DCfdmaHTTggCw1EQf4b(undoGraphicChange, KUZvF5rJc0());
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				undoGraphicChange.IuJvbScoLk = IuJvbScoLk;
				num = 6;
				if (!gfRGVZH9sMR0GT42v9j())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				undoGraphicChange = undoAction as UndoGraphicChange;
				num = 3;
				if (gfRGVZH9sMR0GT42v9j())
				{
				}
				break;
			case 3:
				if (undoGraphicChange != null)
				{
					goto case 2;
				}
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lSov5VpqEn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003C_003Ec__DisplayClass31_0 obj = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 3:
			case 8:
				obj = new _003C_003Ec__DisplayClass31_0();
				goto case 4;
			case 6:
				return;
			case 5:
				TbmgegH0UtxKI1L6nNZ(Display.InteractiveGraphics, KUZvF5rJc0(), obj.newSubregion, num2);
				num = 7;
				continue;
			case 7:
				return;
			case 2:
				if (_isSubregionChange)
				{
					if (Display != null)
					{
						if (KUZvF5rJc0().Children.Length > pdsv6axufb().Children.Length)
						{
							_ = 0;
							num = ((!BCt2kIHXprLd62uFDm5()) ? 9 : 8);
						}
						else
						{
							((CvsInSightDisplayInteractiveGraphics)XWuXSUHFdTyK9YMAbVB(Display)).RemoveSubregion(KUZvF5rJc0(), i3svSrdVDI());
							num = 10;
						}
						continue;
					}
					num = 0;
					if (BCt2kIHXprLd62uFDm5())
					{
						continue;
					}
					goto case 5;
				}
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 9:
				obj.newSubregion = a7bvNWFE2l(i3svSrdVDI());
				break;
			default:
				num = 1;
				continue;
			case 1:
				break;
			case 10:
				return;
			}
			num2 = ((IEnumerable<ICvsEditableDisplayGraphic>)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).IndexOf(obj._003CDoUpdateSubregions_003Eb__0);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void g8Svph8MAQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003C_003Ec__DisplayClass32_0 obj = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 3:
			case 5:
				obj.oldSubregion = a7bvNWFE2l(i3svSrdVDI());
				break;
			case 8:
				return;
			case 4:
				TbmgegH0UtxKI1L6nNZ(XWuXSUHFdTyK9YMAbVB(Display), pdsv6axufb(), obj.oldSubregion, num2);
				num = 10;
				if (!gfRGVZH9sMR0GT42v9j())
				{
					continue;
				}
				return;
			case 7:
				return;
			default:
				_ = 1;
				num = (gfRGVZH9sMR0GT42v9j() ? 1 : 3);
				continue;
			case 9:
				pwxUNEHMZn303wNHL46(XWuXSUHFdTyK9YMAbVB(Display), pdsv6axufb(), i3svSrdVDI());
				num = 7;
				continue;
			case 2:
				if (_isSubregionChange)
				{
					if (Display == null)
					{
						num = 8;
						continue;
					}
					if (((Array)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).Length > ((Array)k17dhiHyDQsX6V20DHp(pdsv6axufb())).Length)
					{
						num = 9;
						continue;
					}
					obj = new _003C_003Ec__DisplayClass32_0();
					goto default;
				}
				num = 0;
				if (BCt2kIHXprLd62uFDm5())
				{
					continue;
				}
				break;
			case 1:
			case 6:
				break;
			case 10:
				return;
			}
			num2 = pdsv6axufb().Children.IndexOf(obj._003CUndoUpdateSubregions_003Eb__0);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateGraphic_003Ed__33))]
	private Task ztCvUUgjsj(CvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gfRGVZH9sMR0GT42v9j();
		int num;
		if (BCt2kIHXprLd62uFDm5())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_008a;
		IL_002a:
		_003CUpdateGraphic_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = Yu5jJPH6ANZ3bvN6UbB();
				goto case 1;
			case 3:
				stateMachine.graphic = P_0;
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mNWv7JwhoG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (gfRGVZH9sMR0GT42v9j() ? 10 : 2);
		while (true)
		{
			switch (num)
			{
			case 7:
				_isSubregionChange = true;
				num = 9;
				continue;
			case 8:
				return;
			default:
				num = 3;
				if (gfRGVZH9sMR0GT42v9j())
				{
				}
				continue;
			case 4:
				KGrvDfEmfv(a7bvNWFE2l(i3svSrdVDI()));
				num = 5;
				continue;
			case 9:
				return;
			case 0:
			case 2:
				if (((Array)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).Length <= ((Array)k17dhiHyDQsX6V20DHp(pdsv6axufb())).Length)
				{
					if (((Array)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).Length < ((Array)k17dhiHyDQsX6V20DHp(pdsv6axufb())).Length)
					{
						goto case 3;
					}
					KGrvDfEmfv(null);
					num = 11;
					continue;
				}
				goto case 1;
			case 3:
				KGrvDfEmfv(((ICvsEditableDisplayGraphic[])k17dhiHyDQsX6V20DHp(pdsv6axufb())).Find([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					_003C_003Ec__DisplayClass34_1 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass34_1();
					CS_0024_003C_003E8__locals5.oldSubregion = P_0;
					return !((IEnumerable<ICvsEditableDisplayGraphic>)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).Any([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic newSubregion) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec__DisplayClass34_1.bMbwXL5KYjNVGgBTf4fh(_003C_003Ec__DisplayClass34_1.C2Osak5KMgpXvOLXKpmE(newSubregion)) == (string)_003C_003Ec__DisplayClass34_1.bMbwXL5KYjNVGgBTf4fh(CS_0024_003C_003E8__locals5.oldSubregion.InSightGraphic);
					});
				}));
				num = 6;
				continue;
			case 1:
			case 10:
				KGrvDfEmfv(KUZvF5rJc0().Children.Find([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass34_0();
					CS_0024_003C_003E8__locals4.newSubregion = P_0;
					return !((IEnumerable<ICvsEditableDisplayGraphic>)k17dhiHyDQsX6V20DHp(pdsv6axufb())).Any([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic oldSubregion) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return _003C_003Ec__DisplayClass34_0.FcyMXi5KTifhenjEdlch(_003C_003Ec__DisplayClass34_0.gPLH915KWLt30yDsbZA7(_003C_003Ec__DisplayClass34_0.a6Vtm95KRxioZV04KYrQ(oldSubregion)), ((CvsGraphic)_003C_003Ec__DisplayClass34_0.a6Vtm95KRxioZV04KYrQ(CS_0024_003C_003E8__locals4.newSubregion)).UniqueId);
					});
				}));
				num = 4;
				continue;
			case 5:
				_isSubregionChange = true;
				num = 8;
				if (!gfRGVZH9sMR0GT42v9j())
				{
					continue;
				}
				break;
			case 6:
				break;
			case 11:
				return;
			}
			KGrvDfEmfv(a7bvNWFE2l(i3svSrdVDI()));
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsEditableDisplayGraphic a7bvNWFE2l(ICvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsEditableDisplayGraphic result = default;
		if (BCt2kIHXprLd62uFDm5())
		{
			while (true)
			{
				switch (num)
				{
				case 11:
					break;
				case 0:
					result = new CvsDisplayableRegion((CvsGraphicRegion)P_0.InSightGraphic.Clone());
					num = 12;
					continue;
				case 10:
					result = new CvsDisplayableAnnulus((CvsGraphicAnnulus)M7pBMNHYU9MBZ4DTqLu(P_0.InSightGraphic));
					num = 3;
					if (BCt2kIHXprLd62uFDm5())
					{
						continue;
					}
					goto IL_01a6;
				case 2:
					goto IL_00ce;
				case 1:
				case 8:
					goto IL_00ea;
				case 4:
				case 7:
					goto IL_00ff;
				case 9:
					result = new CvsDisplayableComposite((CvsGraphicComposite)((CvsGraphic)tEnn36HUejde55UvaQd(P_0)).Clone());
					goto IL_01a6;
				default:
					num = 6;
					continue;
				case 3:
				case 5:
				case 6:
				case 12:
					goto IL_01a6;
				}
				break;
				IL_00ea:
				if (!(P_0 is CvsDisplayableCircle))
				{
					if (P_0 is CvsDisplayableAnnulus)
					{
						num = 10;
						continue;
					}
					if (P_0 is CvsDisplayableComposite)
					{
						num = 9;
						continue;
					}
					if (P_0 is CvsDisplayablePolygon)
					{
						goto IL_00ff;
					}
					if (P_0 is CvsDisplayableRegion)
					{
						num = 0;
						if (true)
						{
							continue;
						}
					}
					goto IL_01a6;
				}
				num = 11;
				continue;
				IL_00ff:
				result = new CvsDisplayablePolygon((CvsGraphicPolygon)M7pBMNHYU9MBZ4DTqLu(tEnn36HUejde55UvaQd(P_0)));
				num = 5;
				continue;
				IL_00ce:
				result = null;
				gfRGVZH9sMR0GT42v9j();
				num = (BCt2kIHXprLd62uFDm5() ? 8 : 4);
			}
		}
		result = new CvsDisplayableCircle((CvsGraphicCircle)M7pBMNHYU9MBZ4DTqLu(P_0.InSightGraphic));
		goto IL_01a6;
		IL_01a6:
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UndoGraphicChange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		aoAgXpH4Lr9YOqlcQfC();
		wiLvEOESmE = L4UADlHHc5kQNyOYrlN(400.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool LVZvAbWgl4(ICvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass34_0();
		CS_0024_003C_003E8__locals2.newSubregion = P_0;
		return !((IEnumerable<ICvsEditableDisplayGraphic>)k17dhiHyDQsX6V20DHp(pdsv6axufb())).Any([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic oldSubregion) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass34_0.FcyMXi5KTifhenjEdlch(_003C_003Ec__DisplayClass34_0.gPLH915KWLt30yDsbZA7(_003C_003Ec__DisplayClass34_0.a6Vtm95KRxioZV04KYrQ(oldSubregion)), ((CvsGraphic)_003C_003Ec__DisplayClass34_0.a6Vtm95KRxioZV04KYrQ(CS_0024_003C_003E8__locals2.newSubregion)).UniqueId);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool ze5vdBDb1D(ICvsEditableDisplayGraphic P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass34_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass34_1();
		CS_0024_003C_003E8__locals2.oldSubregion = P_0;
		return !((IEnumerable<ICvsEditableDisplayGraphic>)k17dhiHyDQsX6V20DHp(KUZvF5rJc0())).Any([MethodImpl(MethodImplOptions.NoInlining)] (ICvsEditableDisplayGraphic newSubregion) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec__DisplayClass34_1.bMbwXL5KYjNVGgBTf4fh(_003C_003Ec__DisplayClass34_1.C2Osak5KMgpXvOLXKpmE(newSubregion)) == (string)_003C_003Ec__DisplayClass34_1.bMbwXL5KYjNVGgBTf4fh(CS_0024_003C_003E8__locals2.oldSubregion.InSightGraphic);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aoAgXpH4Lr9YOqlcQfC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CmtJCPH7dxwewE83SqN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BCt2kIHXprLd62uFDm5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gfRGVZH9sMR0GT42v9j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y4adLgH3PSL9Tdvqyhk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).AdjustmentString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aBdnySHj82YEtkvBAPl(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Yu5jJPH6ANZ3bvN6UbB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EGmVDxHCt2GB7qAaQYL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UndoGraphicChange)P_0).KUZvF5rJc0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation UEsmDPHAYwi8YNrcdZE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan qlnS4IHRWuHnLLboJuB(DateTime P_0, DateTime P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 - P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qFTknWHWZfsNWZQ2EqF(TimeSpan P_0, TimeSpan P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 < P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DCfdmaHTTggCw1EQf4b(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UndoGraphicChange)P_0).PnrvXa0Sun((CvsEditableDisplayGraphic)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k17dhiHyDQsX6V20DHp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Children;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TbmgegH0UtxKI1L6nNZ(object P_0, object P_1, object P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplayInteractiveGraphics)P_0).AddSubregion((CvsEditableDisplayGraphic)P_1, (ICvsEditableDisplayGraphic)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XWuXSUHFdTyK9YMAbVB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InteractiveGraphics;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pwxUNEHMZn303wNHL46(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplayInteractiveGraphics)P_0).RemoveSubregion((CvsEditableDisplayGraphic)P_1, (ICvsEditableDisplayGraphic)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M7pBMNHYU9MBZ4DTqLu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tEnn36HUejde55UvaQd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan L4UADlHHc5kQNyOYrlN(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TimeSpan.FromMilliseconds(P_0);
	}
}
