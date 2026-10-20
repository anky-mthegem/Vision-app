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
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteTcpIpType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public WriteTcpIpType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private WriteTcpIp _003CwriteTcp_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			WriteTcpIpType writeTcpIpType = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 6;
					if (!AJ1Gpt5vaKWM3oTgbdK7())
					{
						break;
					}
					goto case 6;
				case 6:
					writeTcpIpType = _003C_003E4__this;
					num = 1;
					if (AJ1Gpt5vaKWM3oTgbdK7())
					{
					}
					break;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteTcp_003E5__2 = new WriteTcpIp((CommStepViewModel)writeTcpIpType.Parent, writeTcpIpType.Localizer);
							num3 = 9;
							if (AJ1Gpt5vaKWM3oTgbdK7())
							{
								goto IL_007c;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_010a;
						IL_010a:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 1:
							case 8:
								goto IL_0098;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 7:
								return;
							case 9:
								goto IL_0161;
							case 10:
								result = _003CwriteTcp_003E5__2;
								goto end_IL_004a;
							}
							break;
							IL_0161:
							awaiter = _003CwriteTcp_003E5__2.SetCellRangeAsync(cells, cellRange).GetAwaiter();
							_ = 1;
							num3 = ((!AJ1Gpt5vaKWM3oTgbdK7()) ? 8 : 0);
						}
						goto IL_007c;
						IL_0098:
						if (awaiter.IsCompleted)
						{
							goto IL_0085;
						}
						num3 = 5;
						goto IL_010a;
						IL_007c:
						num2 = (_003C_003E1__state = -1);
						goto IL_0085;
						IL_0085:
						awaiter.GetResult();
						num3 = 10;
						if (1 == 0)
						{
							goto IL_0098;
						}
						goto IL_010a;
						end_IL_004a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteTcp_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					c9Vf8s5vJb2Wm6iKALk0();
					if (!AJ1Gpt5vaKWM3oTgbdK7())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 2;
					}
					num = 2;
					break;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 0:
				case 3:
					_003CwriteTcp_003E5__2 = null;
					goto case 2;
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
		internal static bool c9Vf8s5vJb2Wm6iKALk0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AJ1Gpt5vaKWM3oTgbdK7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__7 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public WriteTcpIpType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		private string _003Cname_003E5__4;

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
		public _003CGetUpdates_003Ed__7(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!jYIqU65vOuTvS0omUjaB())
			{
			}
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003El__initialThreadId = pqG9nA5vDL9GRQouIAlL();
					num = 6;
					break;
				case 4:
					s6KkDe5vI8aY5VL4XDtc(this);
					bVwu8P5veAFAwxhYbwqw();
					num = (jYIqU65vOuTvS0omUjaB() ? 1 : 0);
					break;
				case 5:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					num = 4;
					break;
				case 0:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
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
			int num = 5;
			int num2 = default;
			WriteTcpIpType writeTcpIpType = default;
			while (true)
			{
				switch (num)
				{
				case 11:
				case 14:
					if (_003CcurrentVersion_003E5__2 >= _003ClatestVersion_003E5__3)
					{
						break;
					}
					num = 13;
					if (bVwu8P5veAFAwxhYbwqw())
					{
						continue;
					}
					goto case 16;
				case 16:
					return true;
				default:
					jYIqU65vOuTvS0omUjaB();
					num = ((!bVwu8P5veAFAwxhYbwqw()) ? 14 : 4);
					continue;
				case 6:
					_003C_003E2__current = new LowerTimeoutBound();
					_003C_003E1__state = 2;
					num = 3;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 1:
					_003C_003E1__state = 3;
					num = 15;
					continue;
				case 12:
					_003Cname_003E5__4 = (string)vik0mW5vn25wcsk449qM(writeTcpIpType.HoFs8IUSrM);
					num = 7;
					continue;
				case 13:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, writeTcpIpType.Localizer, _003Cname_003E5__4);
					num = 1;
					continue;
				case 7:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 10;
						continue;
					}
					goto case 4;
				case 3:
					return true;
				case 2:
					writeTcpIpType = _003C_003E4__this;
					switch (num2)
					{
					case 1:
						break;
					case 2:
						goto IL_0153;
					default:
						return false;
					case 0:
						goto IL_0189;
					case 3:
						goto IL_01e4;
					}
					_003C_003E1__state = -1;
					goto default;
				case 4:
				case 8:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						num = 6;
						continue;
					}
					goto case 11;
				case 9:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					_003ClatestVersion_003E5__3 = Kj79LX5viPRfVOOTGYeI(writeTcpIpType.HoFs8IUSrM);
					num = 12;
					continue;
				case 15:
					return true;
				case 0:
					_003C_003E1__state = 1;
					num = 16;
					continue;
				case 10:
					_003C_003E2__current = new AddTcpServerOption(writeTcpIpType.Localizer);
					num = 0;
					continue;
				case 17:
					break;
					IL_01e4:
					_003C_003E1__state = -1;
					num = 17;
					continue;
					IL_0189:
					_003C_003E1__state = -1;
					num = 9;
					continue;
					IL_0153:
					_003C_003E1__state = -1;
					goto case 11;
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
			_003CGetUpdates_003Ed__7 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__7(0)
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
		internal static void s6KkDe5vI8aY5VL4XDtc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pqG9nA5vDL9GRQouIAlL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bVwu8P5veAFAwxhYbwqw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jYIqU65vOuTvS0omUjaB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Kj79LX5viPRfVOOTGYeI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vik0mW5vn25wcsk449qM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] HvWshmrNFu;

	private readonly PasteBuffer HoFs8IUSrM;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HvWshmrNFu;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteTcpIpType(CommStepViewModel commStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!z6yD5WhNO7ehStK7Wpp())
		{
			goto IL_001e;
		}
		goto IL_0051;
		IL_001e:
		HoFs8IUSrM = PasteBuffer.FromBytes((byte[])BZRSOYh1xEY0JudTL2c());
		num = 6;
		goto IL_0051;
		IL_0051:
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector(commStepVm);
				break;
			case 6:
				AddSnippet(HoFs8IUSrM, yWpsrgy0NV());
				num = 7;
				continue;
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 1;
				num = ((!VwhTS3h2r9WIId0M6MY()) ? 4 : 0);
				continue;
			case 1:
			case 4:
				HvWshmrNFu = new Guid[1]
				{
					new Guid((string)liUOIMhcFN3DU7JPicZ(31504))
				};
				num = 2;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer yWpsrgy0NV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = e6GqhYhuY12dPwt2eEQ();
		((SnippetLocalizer)obj).ExcludedStrings.Add((string)liUOIMhcFN3DU7JPicZ(30458));
		return (SnippetLocalizer)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateSupportSnippet_003Ed__6))]
	public override Task<EzSupportSnippet> CreateSupportSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateSupportSnippet_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__7))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__7(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object liUOIMhcFN3DU7JPicZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BZRSOYh1xEY0JudTL2c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.WriteTcpIp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z6yD5WhNO7ehStK7Wpp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VwhTS3h2r9WIId0M6MY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e6GqhYhuY12dPwt2eEQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}
}
