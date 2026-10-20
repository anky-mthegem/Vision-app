using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime;
using Cognex.InSight.Undo;
using Cognex.Platform.IO.Configuration;
using Cognex.Platform.IO.Enumerations;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class DIOLineUndoAction : IUndoAction
{
	public enum DIOLineProperty
	{
		Direction,
		Name,
		SignalType
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DIOLineUndoAction _003C_003E4__this;

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
			if (!Hn8RhiKsMTj7fvnLhtoq())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_028d;
				}
			}
			goto IL_025a;
			IL_025a:
			int num2 = default;
			DIOLineUndoAction dIOLineUndoAction = default;
			TaskAwaiter awaiter = default;
			SignalType signalType = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!Hn8RhiKsMTj7fvnLhtoq())
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
							if (dIOLineUndoAction.vsr7xNLiGF == DIOLineProperty.SignalType)
							{
								num3 = 6;
								if (0 == 0)
								{
									goto IL_00b6;
								}
							}
							else if (dIOLineUndoAction.vsr7xNLiGF == DIOLineProperty.Direction)
							{
								Hn8RhiKsMTj7fvnLhtoq();
								if (h5U5IrKsFkZyJPnw5g1u())
								{
									num3 = 2;
								}
								else
								{
									num3 = 0;
									if (1 == 0)
									{
										goto IL_0202;
									}
								}
								goto IL_00b6;
							}
							goto IL_01cd;
						}
						awaiter = _003C_003Eu__1;
						num3 = 1;
						goto IL_00b6;
						IL_0098:
						if (!awaiter.IsCompleted)
						{
							goto IL_012a;
						}
						goto IL_0218;
						IL_01cd:
						BDCeEmKsmZMvLlsEYd9V(h17m3LKsx3elxaY6MT4K(dIOLineUndoAction.AJT7wYgyCp), null);
						awaiter = mTAuJ0KsNgnGWIyZ9A3E(QZt9wdKsQGI1PSAaxKGq(dIOLineUndoAction.hke7H2MwdY));
						goto IL_0098;
						IL_014a:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_00b6;
						IL_00b6:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 5:
								break;
							default:
								num3 = 12;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								signalType = (SignalType)bZGMQ6KsUxbDSVnnAk4f(qVXpONKsYqnjA3ie23VU(typeof(SignalType).TypeHandle), dIOLineUndoAction.s3U7eB8ORl);
								num3 = 7;
								if (h5U5IrKsFkZyJPnw5g1u())
								{
									continue;
								}
								goto IL_012a;
							case 12:
								goto IL_012a;
							case 1:
								goto IL_014a;
							case 4:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 2:
							case 3:
								dIOLineUndoAction.srH7yDWPCq.SignalType = dIOLineUndoAction.srH7yDWPCq.AvailableSignalTypes[0];
								num3 = 9;
								if (Hn8RhiKsMTj7fvnLhtoq())
								{
								}
								continue;
							case 9:
							case 10:
								goto IL_01cd;
							case 7:
								goto IL_0202;
							case 13:
								goto IL_0218;
							}
							break;
						}
						goto IL_0098;
						IL_0202:
						PMGAupKsHNxAPPdYVvcW(dIOLineUndoAction.srH7yDWPCq, signalType);
						num3 = 10;
						goto IL_00b6;
						IL_0218:
						awaiter.GetResult();
						goto end_IL_0050;
						IL_012a:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						num3 = 11;
						if (!Hn8RhiKsMTj7fvnLhtoq())
						{
							goto IL_00b6;
						}
						goto IL_014a;
						end_IL_0050:;
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
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_028d;
			IL_028d:
			dIOLineUndoAction = _003C_003E4__this;
			num = 2;
			if (1 == 0)
			{
				return;
			}
			goto IL_025a;
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
		internal static Type qVXpONKsYqnjA3ie23VU(RuntimeTypeHandle P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bZGMQ6KsUxbDSVnnAk4f(Type P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Enum.ToObject(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PMGAupKsHNxAPPdYVvcW(object P_0, SignalType P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((DIOLineViewModel)P_0).SignalType = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h17m3LKsx3elxaY6MT4K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BDCeEmKsmZMvLlsEYd9V(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QZt9wdKsQGI1PSAaxKGq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mTAuJ0KsNgnGWIyZ9A3E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h5U5IrKsFkZyJPnw5g1u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hn8RhiKsMTj7fvnLhtoq()
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

		public DIOLineUndoAction _003C_003E4__this;

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
			goto IL_0192;
			IL_001a:
			int num2 = default;
			DIOLineUndoAction dIOLineUndoAction = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					dIOLineUndoAction.EF17Oewxqp(_0020: true);
					num3 = 0;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 9;
				}
				while (true)
				{
					switch (num3)
					{
					case 9:
						_003C_003Eu__1 = default;
						goto case 7;
					case 2:
						return;
					case 3:
					case 4:
						_003C_003Eu__1 = awaiter;
						goto case 1;
					default:
						num3 = 1;
						if (CvFbZiKscxrqh9EG22mA())
						{
						}
						continue;
					case 0:
						dIOLineUndoAction.AJT7wYgyCp.OkCommand.SafeExecute();
						num3 = 5;
						continue;
					case 5:
						awaiter = ((Task)iRwrOnKs15VKna9WnUkc(dIOLineUndoAction.hke7H2MwdY)).GetAwaiter();
						num3 = 6;
						continue;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						continue;
					case 7:
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 6:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							CvFbZiKscxrqh9EG22mA();
							num3 = (Xeyr1CKs2SlmtboCmkW6() ? 4 : 8);
							continue;
						}
						break;
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
			goto IL_01c3;
			IL_0192:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_01c3;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (CvFbZiKscxrqh9EG22mA())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 5:
					dIOLineUndoAction = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_01c3:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0192;
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
		internal static object iRwrOnKs15VKna9WnUkc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xeyr1CKs2SlmtboCmkW6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CvFbZiKscxrqh9EG22mA()
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
	private struct _003CUndo_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DIOLineUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!Gtv2UbKsu5C9wfF6v22C()) ? 2 : 5);
			DIOLineUndoAction dIOLineUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					dIOLineUndoAction = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							dIOLineUndoAction.ar57iFHkC2 = (LineDetailsViewModel)Ea36RWKstQJPO9T5SU42(dIOLineUndoAction.srH7yDWPCq);
							Gtv2UbKsu5C9wfF6v22C();
							if (!L7CeVLKshBMsmPxWkuKB())
							{
								num3 = 10;
							}
							else
							{
								num3 = 4;
								if (false)
								{
									goto IL_00ec;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						goto IL_0177;
						IL_0177:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 0:
							case 10:
								dIOLineUndoAction.EF17Oewxqp(_0020: false);
								num3 = 6;
								continue;
							case 4:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto case 4;
							case 1:
								break;
							case 6:
								SFamQfKvL8VNppd6G9lK(zYNFiyKszKyZqDIba76k(dIOLineUndoAction.AJT7wYgyCp), null);
								num3 = 2;
								continue;
							case 2:
								awaiter = kbTwULKvK4bFjmcO4cQp(dIOLineUndoAction.hke7H2MwdY.SaveConfiguration());
								num3 = 1;
								if (Gtv2UbKsu5C9wfF6v22C())
								{
									continue;
								}
								return;
							case 3:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								if (L7CeVLKshBMsmPxWkuKB())
								{
								}
								continue;
							case 11:
								goto IL_01c0;
							}
							break;
						}
						goto IL_00ec;
						IL_00ec:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							goto IL_0177;
						}
						goto IL_01c0;
						IL_01c0:
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
		internal static object Ea36RWKstQJPO9T5SU42(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOLineViewModel)P_0).DetailsViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zYNFiyKszKyZqDIba76k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SFamQfKvL8VNppd6G9lK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kbTwULKvK4bFjmcO4cQp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gtv2UbKsu5C9wfF6v22C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L7CeVLKshBMsmPxWkuKB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IIoConfigurationService hke7H2MwdY;

	private readonly DIOSettingsViewModel AJT7wYgyCp;

	private readonly DIOLineViewModel srH7yDWPCq;

	private readonly DIOLineProperty vsr7xNLiGF;

	private readonly object gg57vWMVY0;

	private readonly object s3U7eB8ORl;

	private readonly SignalType IbC72aYmuv;

	private readonly LineDetailsViewModel yi97qVcO0t;

	private LineDetailsViewModel ar57iFHkC2;

	[CompilerGenerated]
	private readonly string vLS7k3x8vS;

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
			return vLS7k3x8vS;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DIOLineUndoAction(IIoConfigurationService configService, DIOSettingsViewModel dioSettings, DIOLineViewModel dioLine, DIOLineProperty property, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		string arg = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				s3U7eB8ORl = pGZb1eD3rHMGMlivBMB(srH7yDWPCq);
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				if (vsr7xNLiGF == DIOLineProperty.Direction)
				{
					s3U7eB8ORl = srH7yDWPCq.Direction;
					num = 4;
					continue;
				}
				if (vsr7xNLiGF == DIOLineProperty.SignalType)
				{
					s3U7eB8ORl = HGVj1OD41wcfYuTrv4g(srH7yDWPCq);
					num = 17;
					continue;
				}
				if (vsr7xNLiGF == DIOLineProperty.Name)
				{
					num = 1;
					continue;
				}
				break;
			case 10:
				hke7H2MwdY = configService;
				AJT7wYgyCp = dioSettings;
				num = 2;
				continue;
			case 15:
				arg = (string)kQ6khjD7HP5jWYSKnsK();
				num = 5;
				continue;
			case 17:
				gg57vWMVY0 = a8Qv2wDXw6srLqgrtku(srH7yDWPCq.Model);
				yi97qVcO0t = (LineDetailsViewModel)qW5mlmD90VBH6J7Cyum(srH7yDWPCq);
				num = 15;
				continue;
			case 2:
				srH7yDWPCq = dioLine;
				vsr7xNLiGF = property;
				num = 0;
				continue;
			case 3:
				gg57vWMVY0 = mjM0c9DjRS4FnuNdRVh(mybao1DEXWqmW8ItMYQ(srH7yDWPCq));
				num = 16;
				if (Jo6YbhDkDkNqOJV7VEt())
				{
				}
				continue;
			case 13:
				xbuldCD8ylMXH50YYrB();
				num = 14;
				continue;
			case 16:
				arg = Resources.Name;
				num = 19;
				if (VBiWZWDS8xLrfiGneCl())
				{
					continue;
				}
				goto case 0;
			case 0:
				arg = "";
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				gg57vWMVY0 = ttGjX1DpvDWuYqPfJkY(mybao1DEXWqmW8ItMYQ(srH7yDWPCq));
				num = 18;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
			case 12:
				yi97qVcO0t = (LineDetailsViewModel)qW5mlmD90VBH6J7Cyum(srH7yDWPCq);
				goto default;
			default:
				arg = Resources.Direction;
				num = 7;
				continue;
			case 18:
				IbC72aYmuv = a8Qv2wDXw6srLqgrtku(srH7yDWPCq.Model);
				Jo6YbhDkDkNqOJV7VEt();
				num = (VBiWZWDS8xLrfiGneCl() ? 12 : 11);
				continue;
			case 14:
				K1AQghDqnv2w19EvkgL(this);
				num = 10;
				continue;
			case 5:
			case 7:
			case 19:
				break;
			}
			break;
		}
		vLS7k3x8vS = text ?? string.Format((string)GhckwUD6yAICr1vO8qU(), arg, gg57vWMVY0, s3U7eB8ORl);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)Qlhf9tDCOXPkLK2xZPC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__11))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				Jo6YbhDkDkNqOJV7VEt();
				num = (VBiWZWDS8xLrfiGneCl() ? 3 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__12))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = GZFvGQDAdSYh4SDuLBo();
				_ = 0;
				num = (VBiWZWDS8xLrfiGneCl() ? 2 : 5);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__13))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (Jo6YbhDkDkNqOJV7VEt() ? 2 : 5);
		_003CUndo_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (VBiWZWDS8xLrfiGneCl())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				if (VBiWZWDS8xLrfiGneCl())
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EF17Oewxqp(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		SignalType signalType = default;
		object obj2 = default;
		LineDirection lineDirection = default;
		LineDetailsViewModel lineDetailsViewModel2 = default;
		while (true)
		{
			object obj;
			LineDetailsViewModel lineDetailsViewModel;
			switch (num)
			{
			case 5:
				zPM4qPD0rkw7E5GCrx5(srH7yDWPCq.Model, IbC72aYmuv);
				num = 3;
				continue;
			case 10:
			case 13:
				signalType = (SignalType)VB6rYODW8kgmvNNPamJ(gMkq3xDRS6L2UMIMY5U(typeof(SignalType).TypeHandle), obj2);
				goto case 0;
			case 2:
				lineDirection = (LineDirection)VB6rYODW8kgmvNNPamJ(gMkq3xDRS6L2UMIMY5U(typeof(LineDirection).TypeHandle), obj2);
				num = 9;
				continue;
			case 6:
				return;
			case 15:
				return;
			case 16:
				A2goQ4Dy4ah9dy2AO5x(srH7yDWPCq, lineDirection);
				if (!P_0)
				{
					num = 5;
					continue;
				}
				goto case 14;
			case 9:
				mFHtCYDTBq7Qkpp2drr(mybao1DEXWqmW8ItMYQ(srH7yDWPCq), lineDirection);
				num = 16;
				continue;
			case 0:
			case 11:
				((IOLineConfiguration)mybao1DEXWqmW8ItMYQ(srH7yDWPCq)).SignalType = signalType;
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				obj = gg57vWMVY0;
				goto IL_014e;
			case 8:
				srH7yDWPCq.DetailsViewModel = lineDetailsViewModel2;
				num = 15;
				if (VBiWZWDS8xLrfiGneCl())
				{
					continue;
				}
				goto case 7;
			case 7:
				if (P_0)
				{
					obj = s3U7eB8ORl;
					goto IL_014e;
				}
				num = 1;
				continue;
			case 3:
				y0RaUnDFB3yhEWwMtkh(srH7yDWPCq, IbC72aYmuv);
				goto case 14;
			default:
				num = 14;
				continue;
			case 12:
				srH7yDWPCq.SignalType = signalType;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 14;
			case 14:
				yRL1FUDMC9kVo2u0tYE(srH7yDWPCq, lineDetailsViewModel2);
				num = 6;
				continue;
			case 4:
				lineDetailsViewModel = yi97qVcO0t;
				break;
			case 17:
				return;
				IL_014e:
				obj2 = obj;
				if (!P_0)
				{
					num = 4;
					if (VBiWZWDS8xLrfiGneCl())
					{
						continue;
					}
					goto case 8;
				}
				lineDetailsViewModel = ar57iFHkC2;
				break;
			}
			lineDetailsViewModel2 = lineDetailsViewModel;
			if (vsr7xNLiGF != DIOLineProperty.Direction)
			{
				if (vsr7xNLiGF == DIOLineProperty.SignalType)
				{
					_ = 0;
					if (!VBiWZWDS8xLrfiGneCl())
					{
						num = 0;
						if (Jo6YbhDkDkNqOJV7VEt())
						{
						}
					}
					else
					{
						num = 13;
					}
				}
				else
				{
					if (vsr7xNLiGF != DIOLineProperty.Name)
					{
						break;
					}
					IGQXmdDYvFYvfBcfm4y(srH7yDWPCq.Model, obj2 as string);
					srH7yDWPCq.Name = obj2 as string;
					num = 17;
				}
			}
			else
			{
				num = 2;
				if (false)
				{
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xbuldCD8ylMXH50YYrB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K1AQghDqnv2w19EvkgL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mybao1DEXWqmW8ItMYQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).Model;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LineDirection ttGjX1DpvDWuYqPfJkY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOLineConfiguration)P_0).Direction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SignalType a8Qv2wDXw6srLqgrtku(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOLineConfiguration)P_0).SignalType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qW5mlmD90VBH6J7Cyum(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).DetailsViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SignalType HGVj1OD41wcfYuTrv4g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).SignalType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kQ6khjD7HP5jWYSKnsK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SignalType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pGZb1eD3rHMGMlivBMB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOLineViewModel)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mjM0c9DjRS4FnuNdRVh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOLineConfiguration)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GhckwUD6yAICr1vO8qU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pd1hOYqP56();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VBiWZWDS8xLrfiGneCl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jo6YbhDkDkNqOJV7VEt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qlhf9tDCOXPkLK2xZPC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder GZFvGQDAdSYh4SDuLBo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type gMkq3xDRS6L2UMIMY5U(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VB6rYODW8kgmvNNPamJ(Type P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enum.ToObject(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mFHtCYDTBq7Qkpp2drr(object P_0, LineDirection P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOLineConfiguration)P_0).Direction = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A2goQ4Dy4ah9dy2AO5x(object P_0, LineDirection P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOLineViewModel)P_0).Direction = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zPM4qPD0rkw7E5GCrx5(object P_0, SignalType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOLineConfiguration)P_0).SignalType = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void y0RaUnDFB3yhEWwMtkh(object P_0, SignalType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOLineViewModel)P_0).SignalType = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yRL1FUDMC9kVo2u0tYE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOLineViewModel)P_0).DetailsViewModel = (LineDetailsViewModel)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IGQXmdDYvFYvfBcfm4y(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOLineConfiguration)P_0).Name = (string)P_1;
	}
}
