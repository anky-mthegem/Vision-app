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
using Cognex.InSight.EasyBuilder.ViewModels.Steps;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class PropertyLinksType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public PropertyLinksType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private PropertyLinks _003CwriteImage_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U4D6ZFKf3joHaoKddfse();
			int num = (JV9ca7KfjHb5T9GkD95x() ? 2 : 4);
			int num2 = default;
			EzSupportSnippet result = default;
			PropertyLinksType propertyLinksType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteImage_003E5__2 = new PropertyLinks(propertyLinksType.hTcU6Eylml);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									if (!JV9ca7KfjHb5T9GkD95x())
									{
										continue;
									}
									goto case 1;
								}
								goto case 9;
							case 1:
								awaiter = ((Task)IR9LfyKf6CH0FXY4uiGR(_003CwriteImage_003E5__2, cells, cellRange)).GetAwaiter();
								num3 = 3;
								if (U4D6ZFKf3joHaoKddfse())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								num3 = (JV9ca7KfjHb5T9GkD95x() ? 5 : 7);
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (!JV9ca7KfjHb5T9GkD95x())
								{
									continue;
								}
								return;
							case 4:
							case 7:
								return;
							case 2:
								_003C_003Eu__1 = default;
								goto case 5;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								result = _003CwriteImage_003E5__2;
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteImage_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 2:
					propertyLinksType = _003C_003E4__this;
					num = 6;
					continue;
				case 3:
					break;
				case 7:
					return;
				}
				_003CwriteImage_003E5__2 = null;
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
		internal static object IR9LfyKf6CH0FXY4uiGR(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U4D6ZFKf3joHaoKddfse()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JV9ca7KfjHb5T9GkD95x()
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

		public PropertyLinksType _003C_003E4__this;

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
			AQZZZwKfCLDi2u1XEZDF();
			int num;
			if (!W0kt7AKfARE6DlxZ7Tv8())
			{
				num = 5;
				if (!AQZZZwKfCLDi2u1XEZDF())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0081;
			IL_002e:
			_003C_003El__initialThreadId = iPtPC6KfW7DN0xJe13nD();
			num = 6;
			goto IL_0081;
			IL_0081:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
					base._002Ector();
					goto case 2;
				case 0:
				case 5:
					RZ5IqDKfRGM4PcQkoeAL();
					num = 1;
					continue;
				case 2:
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
			int num = 6;
			if (!AQZZZwKfCLDi2u1XEZDF())
			{
				goto IL_001e;
			}
			goto IL_0090;
			IL_0030:
			int num2 = default;
			if (num2 != 1)
			{
				num = 10;
			}
			else
			{
				_003C_003E1__state = -1;
				num = 11;
				if (W0kt7AKfARE6DlxZ7Tv8())
				{
				}
			}
			goto IL_0090;
			IL_00e2:
			int num3 = vFekXWKfTyGoMp6AOPFN(cells, range);
			PropertyLinksType propertyLinksType = default;
			int num4 = ldeSh1KfyZ2TJjo9GNWW(propertyLinksType.eJhUdD1BIK);
			string supportSnippetName = (string)GHhh5QKf00HC4v6MwQOc(propertyLinksType.eJhUdD1BIK);
			if (num3 < num4)
			{
				num = 3;
				if (0 == 0)
				{
					goto IL_0090;
				}
				goto IL_011d;
			}
			goto IL_0157;
			IL_011d:
			_003C_003E2__current = new AddCellVersionUpdate(num4, propertyLinksType.Localizer, supportSnippetName);
			num = 7;
			goto IL_0090;
			IL_001e:
			if (num2 != 0)
			{
				num = 9;
				if (false)
				{
					goto IL_0030;
				}
				goto IL_0090;
			}
			_003C_003E1__state = -1;
			goto IL_00e2;
			IL_0090:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 9:
					goto IL_0030;
				case 7:
					_003C_003E1__state = 1;
					goto case 1;
				case 4:
					goto IL_0058;
				case 10:
					return false;
				default:
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 5:
					goto IL_00e2;
				case 3:
					goto IL_011d;
				case 1:
				case 8:
					return true;
				case 11:
					goto IL_0157;
				}
				break;
				IL_0058:
				propertyLinksType = _003C_003E4__this;
				_ = 1;
				num = (W0kt7AKfARE6DlxZ7Tv8() ? 1 : 0);
			}
			goto IL_001e;
			IL_0157:
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
		internal static void RZ5IqDKfRGM4PcQkoeAL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int iPtPC6KfW7DN0xJe13nD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AQZZZwKfCLDi2u1XEZDF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W0kt7AKfARE6DlxZ7Tv8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vFekXWKfTyGoMp6AOPFN(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ldeSh1KfyZ2TJjo9GNWW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GHhh5QKf00HC4v6MwQOc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] C1GUAEjCuA;

	private readonly PasteBuffer eJhUdD1BIK;

	private readonly EasyBuilderApplicationViewModel hTcU6Eylml;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C1GUAEjCuA;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertyLinksType(EasyBuilderApplicationViewModel appVm)
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
			case 5:
				C1GUAEjCuA = new Guid[1]
				{
					new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1916))
				};
				break;
			case 0:
				RJuc4eaU9obHherQlKj();
				MVi8o2aYbZwONRdypqa();
				if (!kHlyKHaMqRwlekTcRhw())
				{
					num = 6;
					continue;
				}
				num = 5;
				if (kHlyKHaMqRwlekTcRhw())
				{
					continue;
				}
				goto case 7;
			case 7:
				AddSnippet(eJhUdD1BIK);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				eJhUdD1BIK = (PasteBuffer)h0jSjSaxQPNOsWVosZN(HsWQivaHn8oVaESP4Ec());
				num = 7;
				if (!MVi8o2aYbZwONRdypqa())
				{
					continue;
				}
				goto case 3;
			case 3:
				hTcU6Eylml = appVm;
				goto case 4;
			default:
				num = 4;
				continue;
			case 2:
			case 6:
				break;
			case 8:
				return;
			}
			base._002Ector(appVm.Inspect);
			num = 3;
		}
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
	internal static void RJuc4eaU9obHherQlKj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HsWQivaHn8oVaESP4Ec()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.PropertyLinks;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h0jSjSaxQPNOsWVosZN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kHlyKHaMqRwlekTcRhw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MVi8o2aYbZwONRdypqa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
