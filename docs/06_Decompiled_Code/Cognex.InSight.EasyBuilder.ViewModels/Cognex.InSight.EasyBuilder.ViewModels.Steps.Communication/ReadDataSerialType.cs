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

public class ReadDataSerialType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public ReadDataSerialType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ReadDataSerial _003CreadDataSerial_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (si4CUW5dt7pxpce9mcpD())
			{
				goto IL_001e;
			}
			goto IL_01cb;
			IL_001e:
			EzSupportSnippet result = default;
			_003C_003Et__builder.SetResult(result);
			num = 7;
			goto IL_01cb;
			IL_01cb:
			int num2 = default;
			ReadDataSerialType readDataSerialType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CreadDataSerial_003E5__2 = new ReadDataSerial((CommStepViewModel)readDataSerialType.Parent, readDataSerialType.Localizer);
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 4:
								awaiter = xeXRU85lLbUDjSLI44Pn(HEsgmw5dzuyKSVqlQ79v(_003CreadDataSerial_003E5__2, cells, cellRange));
								_ = 0;
								if (kGXLAh5dhMsliX9C5bFo())
								{
									num3 = 8;
									continue;
								}
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								if (!si4CUW5dt7pxpce9mcpD())
								{
									continue;
								}
								return;
							case 7:
								return;
							case 1:
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto case 2;
								}
								goto case 6;
							case 6:
								awaiter.GetResult();
								num3 = 10;
								if (!si4CUW5dt7pxpce9mcpD())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 10:
								result = _003CreadDataSerial_003E5__2;
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CreadDataSerial_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
					readDataSerialType = _003C_003E4__this;
					_ = 1;
					if (si4CUW5dt7pxpce9mcpD())
					{
						num = 4;
						continue;
					}
					num = 1;
					if (kGXLAh5dhMsliX9C5bFo())
					{
						continue;
					}
					goto case 6;
				case 6:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					_003CreadDataSerial_003E5__2 = null;
					num = 5;
					continue;
				case 7:
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
		internal static object HEsgmw5dzuyKSVqlQ79v(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter xeXRU85lLbUDjSLI44Pn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kGXLAh5dhMsliX9C5bFo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool si4CUW5dt7pxpce9mcpD()
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

		public ReadDataSerialType _003C_003E4__this;

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
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				default:
					_003C_003El__initialThreadId = VgADj35laNhAJlUCi6A6();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					qElwXD5lJus8kgoYaEXP(this);
					_ = 0;
					num = (R9VnPI5lKo4IYTeiIlqb() ? 1 : 4);
					break;
				case 0:
					W1WsZL5lwALoVGBnuQtM();
					num = 5;
					if (!R9VnPI5lKo4IYTeiIlqb())
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
			x6Uh0A5l5tq0vmIU56h0();
			int num;
			if (R9VnPI5lKo4IYTeiIlqb())
			{
				num = 7;
				if (!R9VnPI5lKo4IYTeiIlqb())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_00d3;
			IL_002e:
			int num2 = default;
			ReadDataSerialType readDataSerialType = default;
			string supportSnippetName = default;
			_003C_003E2__current = new AddCellVersionUpdate(num2, readDataSerialType.Localizer, supportSnippetName);
			num = 3;
			goto IL_00d3;
			IL_00d3:
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 9:
					break;
				case 4:
					readDataSerialType = _003C_003E4__this;
					num = 6;
					continue;
				case 6:
					if (num3 != 0)
					{
						num = 2;
						continue;
					}
					_003C_003E1__state = -1;
					goto case 5;
				case 1:
				case 8:
					return true;
				case 2:
					if (num3 == 1)
					{
						_003C_003E1__state = -1;
						num = 11;
					}
					else
					{
						num = 10;
					}
					continue;
				case 0:
				case 7:
					num3 = _003C_003E1__state;
					num = 4;
					continue;
				case 3:
					_003C_003E1__state = 1;
					goto case 1;
				case 10:
					return false;
				default:
					num = 5;
					continue;
				case 5:
				{
					int num4 = cqquRh5le4PKHSExUtji(cells, range);
					num2 = VLWQPO5lOIlRdh1Dhtty(readDataSerialType.C6fkL1943s);
					supportSnippetName = (string)FC5BRa5lILuPZ0dKSuvR(readDataSerialType.C6fkL1943s);
					if (num4 < num2)
					{
						num = 9;
						continue;
					}
					goto case 11;
				}
				case 11:
					return false;
				}
				break;
			}
			goto IL_002e;
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
		internal static void W1WsZL5lwALoVGBnuQtM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qElwXD5lJus8kgoYaEXP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VgADj35laNhAJlUCi6A6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R9VnPI5lKo4IYTeiIlqb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x6Uh0A5l5tq0vmIU56h0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int cqquRh5le4PKHSExUtji(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VLWQPO5lOIlRdh1Dhtty(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FC5BRa5lILuPZ0dKSuvR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] PAvkV43MkK;

	private readonly PasteBuffer C6fkL1943s;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PAvkV43MkK;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadDataSerialType(CommStepViewModel commStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wDiEFSuDdo0i8ap11rn();
		int num = (K5p8u8ui4XtNbvKBV5c() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				SnHo7runvvAttguCU1k();
				num = 5;
				break;
			case 6:
				AddSnippet(C6fkL1943s, LHak0nUeu9());
				num = 7;
				if (wDiEFSuDdo0i8ap11rn())
				{
					break;
				}
				goto default;
			default:
				C6fkL1943s = (PasteBuffer)gMevqvudjTERSj1PTFA(rXobhkufyhJ6LeA4lec());
				num = 6;
				break;
			case 2:
				base._002Ector(commStepVm);
				goto default;
			case 5:
				PAvkV43MkK = new Guid[1]
				{
					new Guid((string)BCQyCxuV0T9fU2RIKI1(30200))
				};
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer LHak0nUeu9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (SnippetLocalizer)LLIKxKuleiVq2ikXMFV();
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
	internal static void SnHo7runvvAttguCU1k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BCQyCxuV0T9fU2RIKI1(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rXobhkufyhJ6LeA4lec()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ReadDataSerial;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gMevqvudjTERSj1PTFA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wDiEFSuDdo0i8ap11rn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K5p8u8ui4XtNbvKBV5c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LLIKxKuleiVq2ikXMFV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}
}
