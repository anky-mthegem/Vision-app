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

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;

public class AutoExposureType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public AutoExposureType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private AutoExposure _003CautoExposure_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!n3qoTv55xQy0AvRRKp4i())
			{
				goto IL_001e;
			}
			goto IL_01c2;
			IL_001e:
			_003CautoExposure_003E5__2 = null;
			num = 5;
			if (false)
			{
				goto IL_0031;
			}
			goto IL_01c2;
			IL_0031:
			int num2 = default;
			AutoExposureType autoExposureType = default;
			EzSupportSnippet result = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					_003CautoExposure_003E5__2 = new AutoExposure((SetupImageStepViewModel)autoExposureType.Parent, autoExposureType.Localizer);
					_ = 1;
					if (!JnUtxL55mMSm0aE59BtV())
					{
						num3 = 7;
					}
					else
					{
						num3 = 1;
						if (!n3qoTv55xQy0AvRRKp4i())
						{
							goto IL_00ca;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
				}
				while (true)
				{
					switch (num3)
					{
					case 8:
						_003C_003Eu__1 = default;
						num3 = 9;
						continue;
					case 1:
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						continue;
					case 4:
						return;
					case 3:
						if (!awaiter.IsCompleted)
						{
							goto case 1;
						}
						goto case 5;
					case 6:
						break;
					default:
						num3 = 4;
						continue;
					case 0:
					case 7:
						awaiter = h3hOGR55QAEEwTolSle5(_003CautoExposure_003E5__2.SetCellRangeAsync(cells, cellRange));
						num3 = 3;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
						num2 = (_003C_003E1__state = -1);
						num3 = 5;
						continue;
					case 5:
						awaiter.GetResult();
						num3 = 10;
						continue;
					case 10:
						result = _003CautoExposure_003E5__2;
						goto end_IL_00f1;
					}
					goto IL_00ca;
					continue;
					end_IL_00f1:
					break;
				}
				goto end_IL_0031;
				IL_00ca:
				_003C_003Eu__1 = awaiter;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				end_IL_0031:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CautoExposure_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_001e;
			IL_01c2:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					goto IL_0031;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
					autoExposureType = _003C_003E4__this;
					n3qoTv55xQy0AvRRKp4i();
					if (JnUtxL55mMSm0aE59BtV())
					{
						num = 6;
						if (JnUtxL55mMSm0aE59BtV())
						{
						}
					}
					else
					{
						num = 1;
					}
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					if (n3qoTv55xQy0AvRRKp4i())
					{
						continue;
					}
					return;
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
		internal static TaskAwaiter h3hOGR55QAEEwTolSle5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n3qoTv55xQy0AvRRKp4i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JnUtxL55mMSm0aE59BtV()
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

		public AutoExposureType _003C_003E4__this;

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
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003El__initialThreadId = LI0GdR551Y6uJsEt8kja();
					num = 6;
					continue;
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 4:
					PuhkrA55cYlJhcZvY2Ug();
					num = 0;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				base._002Ector();
				_ = 0;
				num = (BPnNcU55Nut8Oqw8SMXA() ? 1 : 5);
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
			int num = 9;
			AutoExposureType autoExposureType = default;
			int num3 = default;
			int snippetVersion = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					autoExposureType = _003C_003E4__this;
					num = 3;
					if (BPnNcU55Nut8Oqw8SMXA())
					{
						continue;
					}
					goto case 0;
				case 0:
					return true;
				case 1:
					return false;
				default:
					BPnNcU55Nut8Oqw8SMXA();
					num = (O7kAvs5520hjvKcPZeH8() ? 8 : 4);
					continue;
				case 9:
					num3 = _003C_003E1__state;
					num = 2;
					continue;
				case 6:
					if (num3 == 1)
					{
						_003C_003E1__state = -1;
						num = 11;
						continue;
					}
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 7;
				case 7:
				case 8:
					_003C_003E1__state = 1;
					num = 0;
					continue;
				case 3:
					if (num3 == 0)
					{
						_003C_003E1__state = -1;
						goto default;
					}
					num = 6;
					continue;
				case 4:
				case 5:
				{
					int num2 = PAZDeC55uHIE5DD3PVN3(cells, range);
					snippetVersion = SnippetPasteBuffer.GetSnippetVersion(autoExposureType.IaNvZb1o39);
					if (num2 < snippetVersion)
					{
						num = 10;
						continue;
					}
					break;
				}
				case 10:
					_003C_003E2__current = new AddCellVersionUpdate(snippetVersion, autoExposureType.Localizer);
					goto case 7;
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
		internal static void PuhkrA55cYlJhcZvY2Ug()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int LI0GdR551Y6uJsEt8kja()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BPnNcU55Nut8Oqw8SMXA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O7kAvs5520hjvKcPZeH8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PAZDeC55uHIE5DD3PVN3(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}
	}

	private readonly Guid[] fE8vB0DPC0;

	private readonly PasteBuffer IaNvZb1o39;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fE8vB0DPC0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoExposureType(SetupImageStepViewModel imageStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TVSQhRxi4VjCVsmqoRI();
		int num = ((!ViZEZGxDCCLhWX2UFjH()) ? 5 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				fE8vB0DPC0 = new Guid[1]
				{
					new Guid((string)FcPWMIxV1BOtUF1iOlt(28716))
				};
				goto case 2;
			case 6:
				IaNvZb1o39 = (PasteBuffer)temptIxdtGFkG0VkJN5(jcsVqUxfdc8LMvjfxLo());
				num = 1;
				continue;
			case 0:
			case 3:
				dj4PHrxnCLHgGGH8F23();
				num = 4;
				continue;
			case 1:
				AddSnippet(IaNvZb1o39, fDKvGJhNuJ());
				num = 7;
				continue;
			case 2:
			case 5:
				base._002Ector(imageStep);
				goto case 6;
			case 7:
				return;
			}
			num = 6;
			if (TVSQhRxi4VjCVsmqoRI())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer fDKvGJhNuJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = pUeLABxl6hfwqFEGqoa();
		((SnippetLocalizer)obj).ExcludedCellOffsets.Add(IaNvZb1o39.GetCellOffset((string)FcPWMIxV1BOtUF1iOlt(28674)));
		((SnippetLocalizer)obj).ExcludedCellOffsets.Add(IaNvZb1o39.GetCellOffset((string)FcPWMIxV1BOtUF1iOlt(28620)));
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
	internal static void dj4PHrxnCLHgGGH8F23()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FcPWMIxV1BOtUF1iOlt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jcsVqUxfdc8LMvjfxLo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.AutoExposure;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object temptIxdtGFkG0VkJN5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ViZEZGxDCCLhWX2UFjH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TVSQhRxi4VjCVsmqoRI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pUeLABxl6hfwqFEGqoa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}
}
