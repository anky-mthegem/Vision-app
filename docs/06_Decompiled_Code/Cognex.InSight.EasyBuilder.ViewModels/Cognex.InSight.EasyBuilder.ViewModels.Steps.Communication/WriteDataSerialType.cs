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

public class WriteDataSerialType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public WriteDataSerialType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private WriteDataSerial _003CwriteDataSerial_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01f4;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 4;
			goto IL_01f4;
			IL_01f4:
			WriteDataSerialType writeDataSerialType = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					_003CwriteDataSerial_003E5__2 = null;
					num = 6;
					continue;
				case 4:
					writeDataSerialType = _003C_003E4__this;
					sVm5qh5gpcLRlYqId6Rw();
					num = (O2pr5H5gEn4nbyvtB5yG() ? 5 : 0);
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteDataSerial_003E5__2 = new WriteDataSerial((CommStepViewModel)writeDataSerialType.Parent, writeDataSerialType.Localizer);
							num3 = 3;
							goto IL_00bc;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0133;
						IL_0133:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_00bc;
						IL_00bc:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								if (O2pr5H5gEn4nbyvtB5yG())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 4:
								return;
							case 5:
							case 9:
								break;
							case 7:
								if (!awaiter.IsCompleted)
								{
									sVm5qh5gpcLRlYqId6Rw();
									if (!O2pr5H5gEn4nbyvtB5yG())
									{
										num3 = 9;
										continue;
									}
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 0;
							case 0:
								awaiter.GetResult();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								awaiter = YpXdsV5g9fiV0TqxUfVd(Rwid9U5gXE9dAOh7G2pT(_003CwriteDataSerial_003E5__2, cells, cellRange));
								num3 = 7;
								continue;
							case 10:
								result = _003CwriteDataSerial_003E5__2;
								goto end_IL_00bc;
							}
							goto IL_0133;
							continue;
							end_IL_00bc:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteDataSerial_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 7:
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
		internal static object Rwid9U5gXE9dAOh7G2pT(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YpXdsV5g9fiV0TqxUfVd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O2pr5H5gEn4nbyvtB5yG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sVm5qh5gpcLRlYqId6Rw()
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

		public WriteDataSerialType _003C_003E4__this;

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
				case 3:
					base._002Ector();
					goto case 2;
				case 5:
					do
					{
						KVcVc45g3ZjxtlG4u8EA();
						_ = 0;
						if (!fqhvhT5g4U6Sn4pgHGI0())
						{
							num = 4;
							continue;
						}
						num = 3;
						break;
					}
					while (gHKMUg5g7wQHAePHwJyt());
					break;
				case 0:
					_003C_003El__initialThreadId = HDik7x5gjJPCQnvHlUvs();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 0;
				default:
					num = 0;
					if (!fqhvhT5g4U6Sn4pgHGI0())
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
			int num = 7;
			int num2 = default;
			int num4 = default;
			WriteDataSerialType writeDataSerialType = default;
			string supportSnippetName = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 3:
					if (num2 != 0)
					{
						num = 4;
						if (fqhvhT5g4U6Sn4pgHGI0())
						{
							continue;
						}
						goto case 0;
					}
					_003C_003E1__state = -1;
					goto case 1;
				case 0:
					return false;
				default:
					num = 1;
					continue;
				case 6:
					_003C_003E1__state = 1;
					goto case 8;
				case 1:
				{
					int num3 = VREib85g6pfFEjPkmX9F(cells, range);
					num4 = YhdCMy5gCYXqKkBiuxQM(writeDataSerialType.XEpPYRiQdG);
					supportSnippetName = SnippetPasteBuffer.GetSupportSnippetName(writeDataSerialType.XEpPYRiQdG);
					if (num3 < num4)
					{
						num = 10;
						continue;
					}
					break;
				}
				case 10:
					_003C_003E2__current = new AddCellVersionUpdate(num4, writeDataSerialType.Localizer, supportSnippetName);
					num = 6;
					continue;
				case 8:
				case 9:
					return true;
				case 4:
					if (num2 == 1)
					{
						_003C_003E1__state = -1;
						num = 11;
						continue;
					}
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					writeDataSerialType = _003C_003E4__this;
					fqhvhT5g4U6Sn4pgHGI0();
					if (gHKMUg5g7wQHAePHwJyt())
					{
						num = 9;
						continue;
					}
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					break;
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
		internal static void KVcVc45g3ZjxtlG4u8EA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HDik7x5gjJPCQnvHlUvs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fqhvhT5g4U6Sn4pgHGI0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gHKMUg5g7wQHAePHwJyt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VREib85g6pfFEjPkmX9F(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int YhdCMy5gCYXqKkBiuxQM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] kstPtoIEPQ;

	private readonly PasteBuffer XEpPYRiQdG;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kstPtoIEPQ;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteDataSerialType(CommStepViewModel commStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0078;
		IL_001a:
		XEpPYRiQdG = (PasteBuffer)wvfgl7umnSwMFx5o7ba(qHkyUVuxC6AZrckCE0y());
		num = 1;
		goto IL_0078;
		IL_0078:
		while (true)
		{
			switch (num)
			{
			case 4:
				epWRCKuUfBBqW7B08q1();
				num = 6;
				continue;
			case 1:
				AddSnippet(XEpPYRiQdG, mgSPnJsgw9());
				num = 7;
				continue;
			case 2:
			case 5:
				base._002Ector(commStepVm);
				break;
			case 6:
				kstPtoIEPQ = new Guid[1]
				{
					new Guid((string)HHhylXuHYG7PGXci3OI(30470))
				};
				Lr1xeguY5d4aYhw3vRj();
				if (!HjO9VTuMRA3osHCisOb())
				{
					num = 0;
					continue;
				}
				num = 5;
				if (false)
				{
					return;
				}
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer mgSPnJsgw9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SnippetLocalizer snippetLocalizer = EzSnippetType.CreateDefaultSnippetLocalizer();
		snippetLocalizer.ExcludedStrings.Add((string)HHhylXuHYG7PGXci3OI(30458));
		return snippetLocalizer;
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
	internal static void epWRCKuUfBBqW7B08q1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HHhylXuHYG7PGXci3OI(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qHkyUVuxC6AZrckCE0y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.WriteDataSerial;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wvfgl7umnSwMFx5o7ba(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HjO9VTuMRA3osHCisOb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lr1xeguY5d4aYhw3vRj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
