using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public abstract class EzSupportSnippet : EzSnippet
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public CvsCellCollection cells;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fqf3DQKDRBbnq2F2ChZF();
			WDvPrnKDWBLrwtBE1tUb(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003COnResultsChanged_003Eb__0(CellViewModel p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			p.Refresh(cells);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fqf3DQKDRBbnq2F2ChZF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WDvPrnKDWBLrwtBE1tUb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WHQZyKKDC6uNQ2PBrlGE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xq7ZwRKDAxjVYN6CnbJr()
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
	private struct _003CRemoveReferences_003Ed__6 : IAsyncStateMachine
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
			if (!z7Jc1rKDyHdrADMUkaXi())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_01af;
				}
			}
			goto IL_016f;
			IL_016f:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pJJVcIKD0rDlgh7QP6qY(Task.CompletedTask);
							z7Jc1rKDyHdrADMUkaXi();
							if (wQe6YWKDTqcv1r7qo1ly())
							{
								num3 = 7;
								if (z7Jc1rKDyHdrADMUkaXi())
								{
									goto IL_0055;
								}
							}
							else
							{
								num3 = 5;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (false)
							{
								goto IL_012f;
							}
						}
						goto IL_00e0;
						IL_0055:
						_003C_003Eu__1 = awaiter;
						num3 = 6;
						goto IL_00e0;
						IL_00e0:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto IL_012f;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 4:
								return;
							case 9:
								goto IL_012f;
							}
							break;
						}
						goto IL_0055;
						IL_012f:
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
					goto IL_018c;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 5:
					return;
				}
				break;
				IL_018c:
				num = 3;
			}
			goto IL_01af;
			IL_01af:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_016f;
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
		internal static TaskAwaiter pJJVcIKD0rDlgh7QP6qY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wQe6YWKDTqcv1r7qo1ly()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z7Jc1rKDyHdrADMUkaXi()
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
	private struct _003CRemoveSupportSnippetReferences_003Ed__7 : IAsyncStateMachine
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
			int num = ((!kGOopsKDFCssCALpIZ9u()) ? 3 : 4);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
				case 4:
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
							awaiter = PC7645KDYoxw1x73tY6d(Task.CompletedTask);
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!kGOopsKDFCssCALpIZ9u())
							{
								goto IL_00e4;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 6:
								break;
							default:
								num3 = 5;
								if (kGOopsKDFCssCALpIZ9u())
								{
									continue;
								}
								return;
							case 5:
								return;
							case 2:
								goto IL_00e4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									goto IL_0107;
								}
								goto case 9;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (kGOopsKDFCssCALpIZ9u())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0050;
							}
							break;
							IL_0107:
							GX9HIoKDMxuo1MGycwcQ();
							num3 = (kGOopsKDFCssCALpIZ9u() ? 7 : 6);
						}
						goto IL_006b;
						IL_00e4:
						_003C_003Eu__1 = awaiter;
						goto IL_006b;
						IL_006b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0050:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					break;
				case 5:
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
		internal static TaskAwaiter PC7645KDYoxw1x73tY6d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kGOopsKDFCssCALpIZ9u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GX9HIoKDMxuo1MGycwcQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private bool TxmpEN1f9Q;

	public bool IsEditing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TxmpEN1f9Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref TxmpEN1f9Q, value, (string)uywEv45UApyD4u30pT6(1368));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzSupportSnippet(AppStepViewModel appStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		suG4pe5YGI0n9kcL9rU();
		base._002Ector(appStepVm, localizer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!qPjaFJ5MFpBell705qd())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (qPjaFJ5MFpBell705qd())
			{
			}
		}
		EzSupportSnippet obj = default;
		bool lockTaken = default;
		do
		{
			switch (num)
			{
			case 0:
			case 2:
				obj = this;
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_006d;
			case 4:
				break;
			}
			break;
			IL_006d:
			num = 4;
		}
		while (!qPjaFJ5MFpBell705qd());
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			_ = 1;
			int num2;
			if (!qPjaFJ5MFpBell705qd())
			{
				num2 = 2;
			}
			else
			{
				num2 = 3;
				if (1 == 0)
				{
					goto IL_00de;
				}
			}
			goto IL_00b3;
			IL_00de:
			_003C_003Ec__DisplayClass1_0 obj2 = default;
			obj2.cells = results.Cells;
			num2 = 4;
			if (true)
			{
				goto IL_00b3;
			}
			goto IL_00f6;
			IL_00f6:
			AllProperties.ForEach(obj2._003COnResultsChanged_003Eb__0);
			return;
			IL_00b3:
			switch (num2)
			{
			case 0:
			case 2:
				obj2 = new _003C_003Ec__DisplayClass1_0();
				break;
			case 4:
				goto IL_00f6;
			}
			goto IL_00de;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__6))]
	public virtual Task RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (Iw8Hp85FklqAAgYRXYc())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
			if (!Iw8Hp85FklqAAgYRXYc())
			{
				goto IL_00a1;
			}
		}
		goto IL_0040;
		IL_0067:
		_003CRemoveReferences_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0040;
		IL_00a1:
		return stateMachine._003C_003Et__builder.Task;
		IL_0026:
		stateMachine._003C_003E1__state = -1;
		goto IL_0067;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0067;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = ElUQgy5HOZJ92Y664ej();
				break;
			case 5:
				goto IL_00a1;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSupportSnippetReferences_003Ed__7))]
	public virtual Task RemoveSupportSnippetReferences(EzSnippet snippet)
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
		goto IL_0078;
		IL_001a:
		_003CRemoveSupportSnippetReferences_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 5;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = ElUQgy5HOZJ92Y664ej();
				qPjaFJ5MFpBell705qd();
				if (Iw8Hp85FklqAAgYRXYc())
				{
					num = 0;
					if (Iw8Hp85FklqAAgYRXYc())
					{
						continue;
					}
					goto case 0;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 0:
			case 1:
				stateMachine._003C_003E1__state = -1;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void suG4pe5YGI0n9kcL9rU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Iw8Hp85FklqAAgYRXYc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qPjaFJ5MFpBell705qd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uywEv45UApyD4u30pT6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ElUQgy5HOZJ92Y664ej()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
