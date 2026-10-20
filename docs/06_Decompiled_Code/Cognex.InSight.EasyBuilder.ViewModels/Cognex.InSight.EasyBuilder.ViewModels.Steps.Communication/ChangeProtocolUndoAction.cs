using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Undo;
using Cognex.Utilities.Sdk.InSightController;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class ChangeProtocolUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveState_003Ed__6 : IAsyncStateMachine
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
			V0VKbt5OHZq99Ou2mIys();
			int num;
			if (!u063h95OxKDVItqTeAyi())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (u063h95OxKDVItqTeAyi())
				{
				}
			}
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = vx6SI15OmJqTWRpZvLJN(Task.CompletedTask);
							num3 = 8;
							if (!V0VKbt5OHZq99Ou2mIys())
							{
								goto IL_0049;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							if (false)
							{
								goto IL_00dc;
							}
						}
						goto IL_007a;
						IL_00dc:
						if (!awaiter.IsCompleted)
						{
							V0VKbt5OHZq99Ou2mIys();
							num3 = (u063h95OxKDVItqTeAyi() ? 5 : 7);
							goto IL_007a;
						}
						goto IL_0131;
						IL_0131:
						awaiter.GetResult();
						goto end_IL_0028;
						IL_0049:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						goto IL_007a;
						IL_007a:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
								return;
							case 8:
								goto IL_00dc;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								break;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 9:
								goto IL_0131;
							}
							break;
						}
						goto IL_0049;
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
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static TaskAwaiter vx6SI15OmJqTWRpZvLJN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V0VKbt5OHZq99Ou2mIys()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u063h95OxKDVItqTeAyi()
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
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChangeProtocolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!Vr87RX5OQjhClTKYI5pR())
			{
				goto IL_001e;
			}
			goto IL_01b4;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = ((!Vr87RX5OQjhClTKYI5pR()) ? 4 : 2);
			goto IL_01b4;
			IL_01b4:
			ChangeProtocolUndoAction changeProtocolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = iJAGeA5O2rHLex3HPVQu(changeProtocolUndoAction.vGJ22BKdqV.FactoryProtocol.GEu2LkjbgE().WriteImmediateAsync(changeProtocolUndoAction.J3E2itFmvd.ToString()));
							_ = 0;
							num3 = ((!Vr87RX5OQjhClTKYI5pR()) ? 3 : 7);
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
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								if (!oabYe05ONromEjJ9JDAy())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 4:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
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
				case 1:
				case 2:
					changeProtocolUndoAction = _003C_003E4__this;
					num = 5;
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
			goto IL_001e;
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
		internal static TaskAwaiter iJAGeA5O2rHLex3HPVQu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vr87RX5OQjhClTKYI5pR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oabYe05ONromEjJ9JDAy()
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
	private struct _003CRedo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChangeProtocolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!CH6iSg5OcJEo0DUfUXVX())
			{
				goto IL_001e;
			}
			goto IL_01c8;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 1;
			num = (XcI5xj5O12SBGbpejYT6() ? 5 : 4);
			goto IL_01c8;
			IL_01c8:
			ChangeProtocolUndoAction changeProtocolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = lktj4d5OhvUVUK6NjvXR(((FactoryProtocol)VwH3CS5OutlaW0ZaDRNC(changeProtocolUndoAction.vGJ22BKdqV)).GEu2LkjbgE().WriteImmediateAsync(changeProtocolUndoAction.J3E2itFmvd.ToString()));
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (XcI5xj5O12SBGbpejYT6())
							{
								goto IL_00ce;
							}
						}
						goto IL_0128;
						IL_00ce:
						awaiter.GetResult();
						num3 = 10;
						goto IL_0128;
						IL_0128:
						while (true)
						{
							switch (num3)
							{
							case 9:
								if (awaiter.IsCompleted)
								{
									break;
								}
								_ = 0;
								if (CH6iSg5OcJEo0DUfUXVX())
								{
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (CH6iSg5OcJEo0DUfUXVX())
								{
									continue;
								}
								return;
							default:
								return;
							case 2:
								return;
							case 7:
								break;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 10:
								hjdRhs5Ot3T04TpGca8J(changeProtocolUndoAction.vGJ22BKdqV, changeProtocolUndoAction.J3E2itFmvd);
								goto end_IL_0128;
							}
							goto IL_00ce;
							continue;
							end_IL_0128:
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
					goto case 0;
				default:
					num = 0;
					continue;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 4:
					changeProtocolUndoAction = _003C_003E4__this;
					goto case 2;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object VwH3CS5OutlaW0ZaDRNC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).FactoryProtocol;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lktj4d5OhvUVUK6NjvXR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hjdRhs5Ot3T04TpGca8J(object P_0, FfpType P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CommStepViewModel)P_0).xLge8fEcnH(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CH6iSg5OcJEo0DUfUXVX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XcI5xj5O12SBGbpejYT6()
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
	private struct _003CUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChangeProtocolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			w3HHeW5OzZOO6xK5Qj6U();
			int num;
			if (!hRjM4k5ILmKBAuDeVFdD())
			{
				num = 4;
				if (!w3HHeW5OzZOO6xK5Qj6U())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 1;
				if (!w3HHeW5OzZOO6xK5Qj6U())
				{
					goto IL_01e2;
				}
			}
			goto IL_01ab;
			IL_01ab:
			ChangeProtocolUndoAction changeProtocolUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 4:
					goto IL_01e2;
				default:
					goto IL_01f3;
				case 5:
					changeProtocolUndoAction = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_01e2:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_01ab;
			IL_002e:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ApaVlJ5I5fS2qrIXSEZs(((CellViewModel)OO5vWW5IKjeRCnbyHvAy(changeProtocolUndoAction.vGJ22BKdqV.FactoryProtocol)).WriteImmediateAsync(changeProtocolUndoAction.sAl2qpwhuF.ToString()));
					num3 = 3;
					goto IL_00f3;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00a1;
				IL_00a1:
				_003C_003Eu__1 = default;
				num3 = 1;
				goto IL_00f3;
				IL_00f3:
				while (true)
				{
					switch (num3)
					{
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						continue;
					case 1:
						num2 = (_003C_003E1__state = -1);
						num3 = 8;
						continue;
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						continue;
					case 2:
					case 5:
						break;
					case 4:
					case 9:
						return;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto default;
					default:
						_ = 1;
						num3 = ((!hRjM4k5ILmKBAuDeVFdD()) ? 9 : 2);
						continue;
					case 8:
						awaiter.GetResult();
						num3 = 10;
						continue;
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							continue;
						}
						goto case 8;
					case 10:
						jUSBuJ5Iwqe44WbgOvNu(changeProtocolUndoAction.vGJ22BKdqV, changeProtocolUndoAction.sAl2qpwhuF);
						goto end_IL_00f3;
					}
					goto IL_00a1;
					continue;
					end_IL_00f3:
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
			goto IL_01f3;
			IL_01f3:
			_003C_003Et__builder.SetResult();
			num = 6;
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
		internal static object OO5vWW5IKjeRCnbyHvAy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FactoryProtocol)P_0).GEu2LkjbgE();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ApaVlJ5I5fS2qrIXSEZs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jUSBuJ5Iwqe44WbgOvNu(object P_0, FfpType P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CommStepViewModel)P_0).xLge8fEcnH(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w3HHeW5OzZOO6xK5Qj6U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hRjM4k5ILmKBAuDeVFdD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CommStepViewModel vGJ22BKdqV;

	private readonly FfpType sAl2qpwhuF;

	private readonly FfpType J3E2itFmvd;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)AMRGOqN8L0CceQo7ONs(), nIqUyiNq4KEdgfs4Jst(CommStepViewModel.FfpTypeStringConverter, sAl2qpwhuF), nIqUyiNq4KEdgfs4Jst(CommStepViewModel.FfpTypeStringConverter, J3E2itFmvd));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChangeProtocolUndoAction(CommStepViewModel commStep, FfpType oldProtocol, FfpType newProtocol)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DMihqVNooUPRtwCyHDF();
		int num = ((!x1KK67NGmCbwjHqA5p8()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
				J3E2itFmvd = newProtocol;
				num = 7;
				if (x1KK67NGmCbwjHqA5p8())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				CjavDdNS1ke5Fq3vlDj();
				num = 5;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				sAl2qpwhuF = oldProtocol;
				num = 1;
				break;
			case 5:
				dMjy8pNkrTwA3oML3ao(this);
				goto case 2;
			case 2:
			case 3:
				vGJ22BKdqV = commStep;
				goto case 6;
			default:
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__6))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!x1KK67NGmCbwjHqA5p8()) ? 3 : 4);
		_003CSaveState_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = oVciGrNEtUnyQCHHrIQ();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				DMihqVNooUPRtwCyHDF();
				num = (x1KK67NGmCbwjHqA5p8() ? 1 : 5);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__8))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!DMihqVNooUPRtwCyHDF())
		{
		}
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				DMihqVNooUPRtwCyHDF();
				num = (x1KK67NGmCbwjHqA5p8() ? 1 : 4);
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = oVciGrNEtUnyQCHHrIQ();
				num = 5;
				if (x1KK67NGmCbwjHqA5p8())
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DMihqVNooUPRtwCyHDF();
		int num;
		if (x1KK67NGmCbwjHqA5p8())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (!x1KK67NGmCbwjHqA5p8())
			{
				goto IL_00b9;
			}
		}
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = oVciGrNEtUnyQCHHrIQ();
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b9;
		IL_00b9:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CjavDdNS1ke5Fq3vlDj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dMjy8pNkrTwA3oML3ao(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool x1KK67NGmCbwjHqA5p8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DMihqVNooUPRtwCyHDF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AMRGOqN8L0CceQo7ONs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.znyhSQ8CwN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nIqUyiNq4KEdgfs4Jst(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertToString(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder oVciGrNEtUnyQCHHrIQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
