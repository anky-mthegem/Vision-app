using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteFtpSettingsType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public WriteFtpSettingsType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private WriteFtpSettings _003CwriteFtpSettings_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			WriteFtpSettingsType writeFtpSettingsType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003CwriteFtpSettings_003E5__2 = null;
					num = 5;
					break;
				case 6:
					writeFtpSettingsType = _003C_003E4__this;
					HjYBDF5g1Hx83NAj0dYu();
					if (h64Ev65gc1ybZ8LVLLn3())
					{
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 2;
					}
					num = 0;
					if (true)
					{
						break;
					}
					goto case 5;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteFtpSettings_003E5__2 = new WriteFtpSettings(writeFtpSettingsType.Parent);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = ((!h64Ev65gc1ybZ8LVLLn3()) ? 1 : 4);
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 1;
							case 1:
							case 7:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							case 0:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (HjYBDF5g1Hx83NAj0dYu())
								{
								}
								continue;
							case 9:
								awaiter = lGgXTI5ghZbhiG4ZZZ5Q(f6MK8K5gukBevOuKOu2a(_003CwriteFtpSettings_003E5__2, cells, cellRange));
								num3 = 3;
								if (HjYBDF5g1Hx83NAj0dYu())
								{
								}
								continue;
							case 4:
							case 5:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 10:
								result = _003CwriteFtpSettings_003E5__2;
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteFtpSettings_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
					num2 = _003C_003E1__state;
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
		internal static object f6MK8K5gukBevOuKOu2a(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lGgXTI5ghZbhiG4ZZZ5Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h64Ev65gc1ybZ8LVLLn3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HjYBDF5g1Hx83NAj0dYu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__6 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public WriteFtpSettingsType _003C_003E4__this;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetUpdates_003Ed__6(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tBSDMC5gziXWhNZq97q7();
			int num = ((!jUqMQk5gtbiZ36gYjlcO()) ? 2 : 5);
			while (true)
			{
				switch (num)
				{
				case 4:
					base._002Ector();
					num = 1;
					break;
				default:
					_003C_003El__initialThreadId = pB7udj5sKfmydN3KrhW4();
					num = 6;
					break;
				case 1:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 0:
				case 5:
					UChGh05sLLGEmJ81V3Wb();
					num = 4;
					if (tBSDMC5gziXWhNZq97q7())
					{
						return;
					}
					break;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!tBSDMC5gziXWhNZq97q7()) ? 1 : 2);
			int num4 = default;
			WriteFtpSettingsType writeFtpSettingsType = default;
			int num2 = default;
			string supportSnippetName = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (num4 != 1)
					{
						num = 9;
						if (jUqMQk5gtbiZ36gYjlcO())
						{
							continue;
						}
						goto case 0;
					}
					_003C_003E1__state = -1;
					num = 11;
					continue;
				case 0:
				case 1:
					num4 = _003C_003E1__state;
					num = 3;
					if (tBSDMC5gziXWhNZq97q7())
					{
					}
					continue;
				case 9:
					return false;
				case 3:
					writeFtpSettingsType = _003C_003E4__this;
					num = 8;
					continue;
				case 6:
					_003C_003E1__state = 1;
					num = 7;
					continue;
				default:
				{
					int num3 = G318MW5s5Wt0053V7CXr(cells, range);
					num2 = bZ07jm5swaokZX02AAXB(writeFtpSettingsType.KI1P8vhS49);
					supportSnippetName = (string)aI13xE5sJFabYIg9dveL(writeFtpSettingsType.KI1P8vhS49);
					if (num3 >= num2)
					{
						break;
					}
					num = 10;
					if (jUqMQk5gtbiZ36gYjlcO())
					{
						continue;
					}
					goto case 8;
				}
				case 8:
					if (num4 == 0)
					{
						_003C_003E1__state = -1;
						goto default;
					}
					num = 4;
					continue;
				case 7:
					return true;
				case 10:
					_003C_003E2__current = new AddCellVersionUpdate(num2, writeFtpSettingsType.Localizer, supportSnippetName);
					num = 6;
					continue;
				case 11:
					break;
				}
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__6 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__6(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UChGh05sLLGEmJ81V3Wb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pB7udj5sKfmydN3KrhW4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jUqMQk5gtbiZ36gYjlcO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tBSDMC5gziXWhNZq97q7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int G318MW5s5Wt0053V7CXr(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int bZ07jm5swaokZX02AAXB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aI13xE5sJFabYIg9dveL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] RxrPhPIccE;

	private readonly PasteBuffer KI1P8vhS49;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RxrPhPIccE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteFtpSettingsType(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (afpfVthacxqofaXdd0e())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_008d;
		IL_0026:
		AddSnippet(KI1P8vhS49);
		num = 7;
		if (!afpfVthacxqofaXdd0e())
		{
			goto IL_0042;
		}
		goto IL_008d;
		IL_008d:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 4:
				goto IL_0042;
			case 2:
			case 6:
				goto IL_0074;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto IL_00be;
			case 1:
				goto IL_00be;
			case 0:
			case 3:
				qBE10ohOPCq6XPBClw2();
				num = 4;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0042:
		RxrPhPIccE = new Guid[1]
		{
			new Guid((string)PRV8IMhIhfk2otd7NJb(30626))
		};
		goto IL_0074;
		IL_00be:
		KI1P8vhS49 = (PasteBuffer)TVgik5hiChZGXvdDKIx(WJhKRahDaIsb2NpBx3C());
		num = 5;
		goto IL_008d;
		IL_0074:
		base._002Ector(appStepVm);
		goto IL_00be;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateSupportSnippet_003Ed__5))]
	public override Task<EzSupportSnippet> CreateSupportSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateSupportSnippet_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__6))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__6(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qBE10ohOPCq6XPBClw2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PRV8IMhIhfk2otd7NJb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WJhKRahDaIsb2NpBx3C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.WriteFtpSettings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TVgik5hiChZGXvdDKIx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool afpfVthacxqofaXdd0e()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sQDNflhe5W148vhvjiy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
