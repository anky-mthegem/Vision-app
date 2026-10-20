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
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class DIOSettingsUndoAction : IUndoAction
{
	public enum DIOSettingsProperty
	{
		DebounceDuration,
		DeenergizeInOffline
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DIOSettingsUndoAction _003C_003E4__this;

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
			if (!vKr0eOKva6AkOsAOE50c())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01b6;
			IL_01b6:
			int num2 = default;
			DIOSettingsUndoAction dIOSettingsUndoAction = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					goto IL_003d;
				default:
					num = 3;
					if (!vKr0eOKva6AkOsAOE50c())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					dIOSettingsUndoAction = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_003d:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					((ICommand)EYMrXIKveGBNpGFjFUWI(dIOSettingsUndoAction.RmS7K0WSGm)).SafeExecute();
					vKr0eOKva6AkOsAOE50c();
					if (Ydd5EfKvJsHd3Kqd1k0A())
					{
						num3 = 6;
					}
					else
					{
						num3 = 9;
						if (vKr0eOKva6AkOsAOE50c())
						{
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 7;
				}
				while (true)
				{
					switch (num3)
					{
					case 4:
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 1;
						if (Ydd5EfKvJsHd3Kqd1k0A())
						{
							continue;
						}
						goto case 8;
					case 8:
						_003C_003Eu__1 = awaiter;
						goto case 2;
					default:
						num3 = 2;
						continue;
					case 3:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 0:
					case 6:
						awaiter = sHLaVMKvIgSgkoRxueye(aPnNPOKvO8pLY1EFVhJp(dIOSettingsUndoAction.aUX7s0Ioyo));
						num3 = 4;
						if (true)
						{
							continue;
						}
						return;
					case 5:
						return;
					case 9:
						return;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 7:
						_003C_003Eu__1 = default;
						num3 = 3;
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
			goto IL_0026;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_003d;
			}
			goto IL_01b6;
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
		internal static object EYMrXIKveGBNpGFjFUWI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aPnNPOKvO8pLY1EFVhJp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sHLaVMKvIgSgkoRxueye(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ydd5EfKvJsHd3Kqd1k0A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vKr0eOKva6AkOsAOE50c()
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

		public DIOSettingsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			DIOSettingsUndoAction dIOSettingsUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					dIOSettingsUndoAction = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							dIOSettingsUndoAction.rnD7PtGRAb(_0020: true);
							_ = 0;
							num3 = ((!DemDt1KvDJZfbngSsr6u()) ? 4 : 2);
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
							case 0:
							case 2:
								Da3mB8KvVaYBFkOfLmCY(QgNhW5Kvn6T6cJhwZBlt(dIOSettingsUndoAction.RmS7K0WSGm), null);
								goto case 1;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (DemDt1KvDJZfbngSsr6u())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								awaiter = DNfCaYKvdCGDsOybU18Y(fTiw6tKvfFg9xBtIaOrC(dIOSettingsUndoAction.aUX7s0Ioyo));
								num3 = 7;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
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
					goto case 5;
				default:
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					DemDt1KvDJZfbngSsr6u();
					num = ((!M2tVVFKvi35vKgwr9ddW()) ? 4 : 3);
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
		internal static object QgNhW5Kvn6T6cJhwZBlt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Da3mB8KvVaYBFkOfLmCY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fTiw6tKvfFg9xBtIaOrC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DNfCaYKvdCGDsOybU18Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DemDt1KvDJZfbngSsr6u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M2tVVFKvi35vKgwr9ddW()
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

		public DIOSettingsUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!TLgCxuKvgwVF7vvwFilY()) ? 1 : 5);
			int num2 = default;
			DIOSettingsUndoAction dIOSettingsUndoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							dIOSettingsUndoAction.rnD7PtGRAb(_0020: false);
							TLgCxuKvgwVF7vvwFilY();
							if (NE8Y7nKvlexvLE4jH2qf())
							{
								num3 = 7;
								if (TLgCxuKvgwVF7vvwFilY())
								{
									return;
								}
							}
							else
							{
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (TLgCxuKvgwVF7vvwFilY())
							{
								goto IL_006d;
							}
						}
						goto IL_010a;
						IL_010a:
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 5:
								break;
							case 0:
							case 7:
								dIOSettingsUndoAction.RmS7K0WSGm.OkCommand.SafeExecute();
								num3 = 5;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 10:
								goto IL_015e;
							}
							break;
						}
						goto IL_006d;
						IL_006d:
						awaiter = rqxkB9KvvQgB8woIKC2Z(iXC2aiKvsnyZekpxdbmY(dIOSettingsUndoAction.aUX7s0Ioyo));
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							goto IL_010a;
						}
						goto IL_015e;
						IL_015e:
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
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					dIOSettingsUndoAction = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
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
		internal static object iXC2aiKvsnyZekpxdbmY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rqxkB9KvvQgB8woIKC2Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NE8Y7nKvlexvLE4jH2qf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TLgCxuKvgwVF7vvwFilY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IIoConfigurationService aUX7s0Ioyo;

	private readonly DIOSettingsViewModel RmS7K0WSGm;

	private readonly DIOSettingsProperty Box7GxUOLD;

	private readonly object Kv67BBNLGn;

	private readonly object yf27ZrZ7Kt;

	[CompilerGenerated]
	private readonly string ivB7n7ULWI;

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
			return ivB7n7ULWI;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DIOSettingsUndoAction(IIoConfigurationService configService, DIOSettingsViewModel dioSettings, DIOSettingsProperty property, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		string text2 = default;
		if (Hx8OwRDUSWvdQlVavFL())
		{
			while (true)
			{
				switch (num)
				{
				case 5:
					yf27ZrZ7Kt = rknRmADN43FgLWL3Xwr(RmS7K0WSGm);
					goto default;
				default:
					RbbZm9DH976XND6DBoc();
					num = ((!Hx8OwRDUSWvdQlVavFL()) ? 6 : 3);
					continue;
				case 10:
					yf27ZrZ7Kt = Rkn1MQDu8g7tI37Ma9p(RmS7K0WSGm);
					num = 13;
					continue;
				case 13:
					text2 = (string)mR0NGVDhxJqS0pHQ1dp();
					num = 14;
					continue;
				case 4:
					aUX7s0Ioyo = configService;
					num = 2;
					if (Hx8OwRDUSWvdQlVavFL())
					{
						continue;
					}
					goto case 9;
				case 9:
					Kv67BBNLGn = PK4UNiD1f5P87qtV29K(rsAHRFDcoEEUS93rU7x(RmS7K0WSGm));
					num = 10;
					continue;
				case 2:
					RmS7K0WSGm = dioSettings;
					Box7GxUOLD = property;
					text2 = "";
					num = 11;
					continue;
				case 0:
					Kv67BBNLGn = zOkqvWDQPqyHD7keeAo(RmS7K0WSGm.Model);
					num = 5;
					continue;
				case 1:
					L0DyYgDxy7TUIHSNlkY();
					num = 12;
					continue;
				case 3:
				case 7:
					text2 = (string)P8w3etD2AbAoKyKfEpJ();
					break;
				case 11:
					if (Box7GxUOLD != DIOSettingsProperty.DebounceDuration)
					{
						if (Box7GxUOLD == DIOSettingsProperty.DeenergizeInOffline)
						{
							num = 9;
							continue;
						}
						break;
					}
					num = 0;
					continue;
				case 12:
					XrKiiiDmnLt5o8BmvGU(this);
					num = 4;
					continue;
				case 6:
				case 8:
				case 14:
					break;
				}
				break;
			}
		}
		ivB7n7ULWI = (string)(text ?? hojrvdDzcQQk7iAbCws(QBdsxqDt1210lFv1eW7(), text2, Kv67BBNLGn, yf27ZrZ7Kt));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)k1RRiaiLuBZlHFqkhQT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__7))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = pdl42TiKEjtZEDyYytP();
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				Hx8OwRDUSWvdQlVavFL();
				if (RbbZm9DH976XND6DBoc())
				{
					num = 1;
					break;
				}
				num = 4;
				if (Hx8OwRDUSWvdQlVavFL())
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
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
		int num = 4;
		_003CRedo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = pdl42TiKEjtZEDyYytP();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				Hx8OwRDUSWvdQlVavFL();
				num = (RbbZm9DH976XND6DBoc() ? 5 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__9))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = pdl42TiKEjtZEDyYytP();
				RbbZm9DH976XND6DBoc();
				num = (Hx8OwRDUSWvdQlVavFL() ? 5 : 0);
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rnD7PtGRAb(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0053;
		IL_001a:
		bool flag = default;
		((IOConfiguration)rsAHRFDcoEEUS93rU7x(RmS7K0WSGm)).DeenergizeInOffline = flag;
		num = 2;
		goto IL_0053;
		IL_0053:
		double num2 = default;
		object obj = default;
		while (true)
		{
			object kv67BBNLGn;
			switch (num)
			{
			case 6:
				break;
			case 9:
				RmS7K0WSGm.DebounceDuration = num2;
				return;
			default:
				num = 5;
				if (Hx8OwRDUSWvdQlVavFL())
				{
					continue;
				}
				goto case 1;
			case 1:
				kv67BBNLGn = Kv67BBNLGn;
				goto IL_00ad;
			case 5:
				return;
			case 3:
			case 8:
				num2 = (double)obj;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
			case 10:
				flag = (bool)obj;
				num = 6;
				continue;
			case 2:
				YKLPbUiw4QTkFxiB2VS(RmS7K0WSGm, flag);
				num = 12;
				continue;
			case 4:
				OG9Y5Yi52KJrdpYPrc5(rsAHRFDcoEEUS93rU7x(RmS7K0WSGm), num2);
				num = 9;
				continue;
			case 11:
				if (!(obj is double))
				{
					goto IL_00c4;
				}
				_ = 0;
				if (!Hx8OwRDUSWvdQlVavFL())
				{
					num = 10;
					if (Hx8OwRDUSWvdQlVavFL())
					{
						continue;
					}
					goto case 3;
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				if (P_0)
				{
					kv67BBNLGn = yf27ZrZ7Kt;
					goto IL_00ad;
				}
				num = 1;
				if (Hx8OwRDUSWvdQlVavFL())
				{
					continue;
				}
				return;
			case 12:
				return;
				IL_00ad:
				obj = kv67BBNLGn;
				if (Box7GxUOLD == DIOSettingsProperty.DebounceDuration)
				{
					num = 11;
					continue;
				}
				goto IL_00c4;
				IL_00c4:
				if (Box7GxUOLD == DIOSettingsProperty.DeenergizeInOffline && obj is bool)
				{
					goto case 7;
				}
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L0DyYgDxy7TUIHSNlkY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XrKiiiDmnLt5o8BmvGU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double zOkqvWDQPqyHD7keeAo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOConfiguration)P_0).DebounceDuration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double rknRmADN43FgLWL3Xwr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOSettingsViewModel)P_0).DebounceDuration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P8w3etD2AbAoKyKfEpJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DebounceDuration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rsAHRFDcoEEUS93rU7x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOSettingsViewModel)P_0).Model;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PK4UNiD1f5P87qtV29K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IOConfiguration)P_0).DeenergizeInOffline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rkn1MQDu8g7tI37Ma9p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DIOSettingsViewModel)P_0).DeenergizeInOffline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mR0NGVDhxJqS0pHQ1dp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.iLQn6pgPGy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QBdsxqDt1210lFv1eW7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.pd1hOYqP56();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hojrvdDzcQQk7iAbCws(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hx8OwRDUSWvdQlVavFL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RbbZm9DH976XND6DBoc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k1RRiaiLuBZlHFqkhQT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder pdl42TiKEjtZEDyYytP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OG9Y5Yi52KJrdpYPrc5(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IOConfiguration)P_0).DebounceDuration = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YKLPbUiw4QTkFxiB2VS(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DIOSettingsViewModel)P_0).DeenergizeInOffline = P_1;
	}
}
