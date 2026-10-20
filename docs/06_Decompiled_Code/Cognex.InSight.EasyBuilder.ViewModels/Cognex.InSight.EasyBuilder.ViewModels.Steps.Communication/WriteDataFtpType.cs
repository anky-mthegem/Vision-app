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

public class WriteDataFtpType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public WriteDataFtpType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private WriteDataFtp _003CwriteData_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			WriteDataFtpType writeDataFtpType = default;
			EzSupportSnippet result = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_0207:
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					odYEQt5l2LFdbdRyZ1jW();
					if (MMoZ3k5lNDrpc3OLFxNF())
					{
						num = 6;
						if (!odYEQt5l2LFdbdRyZ1jW())
						{
							goto IL_0207;
						}
						goto case 1;
					}
					num = 5;
					if (!odYEQt5l2LFdbdRyZ1jW())
					{
						goto IL_0207;
					}
					goto case 4;
				case 1:
				case 6:
					writeDataFtpType = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					goto IL_0207;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteData_003E5__2 = new WriteDataFtp((CommStepViewModel)writeDataFtpType.Parent, writeDataFtpType.Localizer);
							MMoZ3k5lNDrpc3OLFxNF();
							if (!odYEQt5l2LFdbdRyZ1jW())
							{
								num3 = 4;
							}
							else
							{
								num3 = 8;
								if (!MMoZ3k5lNDrpc3OLFxNF())
								{
									goto IL_01be;
								}
							}
							goto IL_00d5;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0126;
						IL_00d5:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 9;
							case 5:
							case 8:
								break;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 4:
								awaiter = vjHViN5lc1hjBixu7PRT(_003CwriteData_003E5__2.SetCellRangeAsync(cells, cellRange));
								num3 = 3;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 7:
								return;
							case 10:
								goto IL_01be;
							}
							break;
						}
						goto IL_0126;
						IL_01be:
						result = _003CwriteData_003E5__2;
						goto end_IL_0072;
						IL_0126:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00d5;
						end_IL_0072:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteData_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					goto IL_0207;
				case 3:
					break;
				case 7:
					return;
				}
				_003CwriteData_003E5__2 = null;
				num = 4;
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
		internal static TaskAwaiter vjHViN5lc1hjBixu7PRT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MMoZ3k5lNDrpc3OLFxNF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool odYEQt5l2LFdbdRyZ1jW()
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

		public WriteDataFtpType _003C_003E4__this;

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
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					fobFub5ltHe2C6BoYtPj(this);
					num = 2;
					break;
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				default:
					_003C_003El__initialThreadId = zGHMme5lznIw7coCTK7R();
					num = 6;
					break;
				case 5:
					FipBeQ5lhhiKnfE1dhAK();
					zlsC0w5l1bX3y52Vlp2h();
					num = ((!cjrVaZ5lub3A67icub9K()) ? 4 : 0);
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
			int num = 12;
			if (0 == 0)
			{
				WriteDataFtpType writeDataFtpType = default;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 7:
						break;
					case 10:
						if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
						{
							_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, writeDataFtpType.Localizer, _003Cname_003E5__4);
							num = 7;
							continue;
						}
						goto case 17;
					case 12:
						num2 = _003C_003E1__state;
						num = 14;
						if (cjrVaZ5lub3A67icub9K())
						{
						}
						continue;
					case 14:
						writeDataFtpType = _003C_003E4__this;
						num = 0;
						continue;
					default:
						_003C_003E1__state = 1;
						num = 1;
						if (zlsC0w5l1bX3y52Vlp2h())
						{
							continue;
						}
						goto case 1;
					case 1:
						return true;
					case 16:
						_003CcurrentVersion_003E5__2 = IDVpZ15gLadTPYSLD448(cells, range);
						_003ClatestVersion_003E5__3 = GcQ5kK5gKJXtgHRqIOIZ(writeDataFtpType.SZ9PO8feWs);
						zlsC0w5l1bX3y52Vlp2h();
						if (!cjrVaZ5lub3A67icub9K())
						{
							num = 15;
							if (0 == 0)
							{
								continue;
							}
							goto case 11;
						}
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 6;
					case 11:
						return false;
					case 2:
						_003C_003E2__current = new SftpUpdate(writeDataFtpType.Localizer);
						goto default;
					case 6:
						_003C_003E2__current = new MqttUpdate(writeDataFtpType.Localizer);
						_003C_003E1__state = 2;
						num = 9;
						if (true)
						{
							continue;
						}
						goto case 3;
					case 3:
						if (_003CcurrentVersion_003E5__2 < 2)
						{
							num = 6;
							continue;
						}
						goto case 10;
					case 9:
						return true;
					case 13:
						if (_003CcurrentVersion_003E5__2 < 1)
						{
							num = 2;
							continue;
						}
						goto case 3;
					case 0:
						switch (num2)
						{
						case 3:
							_003C_003E1__state = -1;
							num = 17;
							continue;
						case 1:
							break;
						case 0:
							_003C_003E1__state = -1;
							num = 16;
							continue;
						case 2:
							_003C_003E1__state = -1;
							num = 10;
							continue;
						default:
							num = 11;
							continue;
						}
						_003C_003E1__state = -1;
						num = 3;
						if (zlsC0w5l1bX3y52Vlp2h())
						{
							continue;
						}
						goto case 16;
					case 5:
					case 15:
						_003Cname_003E5__4 = (string)TgLLhF5g54wa1lipeGHv(writeDataFtpType.SZ9PO8feWs);
						num = 13;
						continue;
					case 17:
						return false;
					}
					break;
				}
			}
			_003C_003E1__state = 3;
			return true;
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
		internal static void FipBeQ5lhhiKnfE1dhAK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fobFub5ltHe2C6BoYtPj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int zGHMme5lznIw7coCTK7R()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zlsC0w5l1bX3y52Vlp2h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cjrVaZ5lub3A67icub9K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int IDVpZ15gLadTPYSLD448(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int GcQ5kK5gKJXtgHRqIOIZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TgLLhF5g54wa1lipeGHv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] rxpPC55UmI;

	private readonly PasteBuffer SZ9PO8feWs;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rxpPC55UmI;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteDataFtpType(CommStepViewModel commStepVm)
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
		goto IL_0033;
		IL_0093:
		SZ9PO8feWs = (PasteBuffer)NFsjYiu4MyPjJOKqCdS(Snippets.WriteDataFtp);
		goto IL_0068;
		IL_0033:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 5;
				if (!VTPumFup5GW17xUeibV())
				{
					continue;
				}
				goto IL_0068;
			case 1:
			case 4:
				goto IL_0068;
			case 3:
				irtDbpuXJ5wHXbPWDCK();
				num = 6;
				continue;
			case 5:
				goto IL_0093;
			case 6:
				goto IL_00b3;
			case 7:
				return;
			}
			break;
			IL_00b3:
			rxpPC55UmI = new Guid[1]
			{
				new Guid((string)QjmdgMu9Uk5choSgWJk(30276))
			};
			VTPumFup5GW17xUeibV();
			num = ((!qkXWQkuEkeEDr0jlbeX()) ? 1 : 0);
		}
		goto IL_001a;
		IL_0068:
		AddSnippet(SZ9PO8feWs, b6GPjCYpdm());
		num = 7;
		goto IL_0033;
		IL_001a:
		base._002Ector(commStepVm);
		goto IL_0093;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer b6GPjCYpdm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = irAI6Vu71y6YyjDLiWf();
		((SnippetLocalizer)obj).ExcludedCellOffsets.Add(SZ9PO8feWs.GetCellOffset((string)QjmdgMu9Uk5choSgWJk(30352)));
		CvsCellLocation cellOffset = SZ9PO8feWs.GetCellOffset((string)QjmdgMu9Uk5choSgWJk(30398));
		CvsCellLocation item = cellOffset;
		item.Column += 2;
		((SnippetLocalizer)obj).ExcludedCellOffsets.Add(cellOffset);
		((SnippetLocalizer)obj).ExcludedCellOffsets.Add(item);
		((SnippetLocalizer)obj).ExcludedStrings.Add((string)QjmdgMu9Uk5choSgWJk(30458));
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
	internal static void irtDbpuXJ5wHXbPWDCK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QjmdgMu9Uk5choSgWJk(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NFsjYiu4MyPjJOKqCdS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qkXWQkuEkeEDr0jlbeX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VTPumFup5GW17xUeibV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object irAI6Vu71y6YyjDLiWf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}
}
