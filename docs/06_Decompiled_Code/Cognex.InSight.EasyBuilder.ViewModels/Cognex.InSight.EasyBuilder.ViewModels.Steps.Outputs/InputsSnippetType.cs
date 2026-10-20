using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class InputsSnippetType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public InputsSnippetType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private InputsSnippet _003Cinputs_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			InputsSnippetType inputsSnippetType = default;
			EzSupportSnippet result = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					inputsSnippetType = _003C_003E4__this;
					AqfMKCKllnN0oOmyXsrK();
					num = ((!xBdrt6KlglvYxe5VAlRO()) ? 3 : 0);
					continue;
				case 0:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (!xBdrt6KlglvYxe5VAlRO())
					{
						continue;
					}
					goto case 5;
				case 5:
					_003Cinputs_003E5__2 = null;
					goto case 0;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Cinputs_003E5__2 = new InputsSnippet(inputsSnippetType.Parent);
							num3 = 6;
							goto IL_0104;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0156;
						IL_0156:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_0104;
						IL_0104:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (!xBdrt6KlglvYxe5VAlRO())
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter = ((Task)rfk4YQKlsf5Aae44nF9p(_003Cinputs_003E5__2, cells, cellRange)).GetAwaiter();
								xBdrt6KlglvYxe5VAlRO();
								num3 = (AqfMKCKllnN0oOmyXsrK() ? 2 : 0);
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 4:
								awaiter.GetResult();
								num3 = 10;
								if (!xBdrt6KlglvYxe5VAlRO())
								{
									continue;
								}
								break;
							case 0:
							case 5:
								break;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 4;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								continue;
							case 7:
								return;
							case 10:
								result = _003Cinputs_003E5__2;
								goto end_IL_0104;
							}
							goto IL_0156;
							continue;
							end_IL_0104:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cinputs_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					break;
				case 7:
					return;
				}
				num2 = _003C_003E1__state;
				num = 6;
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
		internal static object rfk4YQKlsf5Aae44nF9p(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AqfMKCKllnN0oOmyXsrK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xBdrt6KlglvYxe5VAlRO()
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
	private struct _003CAddSupportSnippet_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public InputsSnippetType _003C_003E4__this;

		public ISnippetManager snippetManager;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!KqqQEQKlraSioo2PVt3h())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01a0;
			IL_01e2:
			EzSupportSnippet result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01a0;
			IL_01a0:
			int num2 = default;
			InputsSnippetType inputsSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					goto IL_01e2;
				case 4:
					inputsSnippetType = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				try
				{
					TaskAwaiter<EzSupportSnippet> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = inputsSnippetType.FVPU1FvMbh(snippetManager).GetAwaiter();
						num3 = 6;
						goto IL_00ae;
					}
					awaiter = _003C_003Eu__1;
					goto IL_0123;
					IL_0123:
					_003C_003Eu__1 = default;
					num3 = 2;
					goto IL_00ae;
					IL_00ae:
					while (true)
					{
						switch (num3)
						{
						case 0:
						case 4:
							return;
						case 6:
							if (!awaiter.IsCompleted)
							{
								num3 = 8;
								continue;
							}
							goto case 9;
						case 7:
							_003C_003Eu__1 = awaiter;
							num3 = 1;
							continue;
						case 1:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							goto default;
						default:
							_ = 0;
							num3 = ((!IZkIIHKlv7LaRvoHWitH()) ? 3 : 0);
							continue;
						case 2:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							if (IZkIIHKlv7LaRvoHWitH())
							{
								continue;
							}
							goto case 8;
						case 8:
							num2 = (_003C_003E1__state = 0);
							num3 = 7;
							if (IZkIIHKlv7LaRvoHWitH())
							{
								continue;
							}
							break;
						case 3:
						case 5:
							break;
						case 9:
							result = awaiter.GetResult();
							goto end_IL_00ae;
						}
						goto IL_0123;
						continue;
						end_IL_00ae:
						break;
					}
				}
				catch (CvsNetworkException ex)
				{
					lXbaJtKlZ52eYb7TDU9i(Log, SsgllDKlPd5A8GnnXk1b(48200), ex);
					goto IL_0163;
				}
				goto end_IL_0026;
				IL_0163:
				result = null;
				end_IL_0026:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01e2;
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
		internal static object SsgllDKlPd5A8GnnXk1b(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lXbaJtKlZ52eYb7TDU9i(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IZkIIHKlv7LaRvoHWitH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KqqQEQKlraSioo2PVt3h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__8 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public InputsSnippetType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__8(int _003C_003E1__state)
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
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 4:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					num = 5;
					if (kKwi7iKlbaVssEEWftef())
					{
					}
					break;
				default:
					_003C_003El__initialThreadId = VgipAfKloSx17p53rnxM();
					num = 6;
					break;
				case 5:
					dBtQtQKlGQfPm3fDOMUP(this);
					g4LgcmKlBlYRw9CKHv0t();
					num = ((!kKwi7iKlbaVssEEWftef()) ? 1 : 0);
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
			int num = 10;
			int num2 = default;
			int num4 = default;
			InputsSnippetType inputsSnippetType = default;
			string supportSnippetName = default;
			while (true)
			{
				switch (num)
				{
				case 10:
					num2 = _003C_003E1__state;
					g4LgcmKlBlYRw9CKHv0t();
					num = (kKwi7iKlbaVssEEWftef() ? 6 : 5);
					continue;
				case 2:
					_003C_003E2__current = new AddCellVersionUpdate(num4, inputsSnippetType.Localizer, supportSnippetName);
					num = 0;
					continue;
				case 0:
					_003C_003E1__state = 1;
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				case 7:
					if (num2 != 0)
					{
						num = 8;
						continue;
					}
					_003C_003E1__state = -1;
					goto case 3;
				case 4:
				case 6:
					return false;
				default:
					num = 3;
					if (!kKwi7iKlbaVssEEWftef())
					{
						continue;
					}
					goto case 3;
				case 3:
				{
					int num3 = ojxSU2KlS0dCj43LrrUD(cells, range);
					num4 = lB1pKqKlkBRdwtvLWa5o(inputsSnippetType.BfR7agUGmG);
					supportSnippetName = (string)yqh2DfKl8fhMgltgrEY1(inputsSnippetType.BfR7agUGmG);
					if (num3 < num4)
					{
						num = 2;
						continue;
					}
					break;
				}
				case 9:
					return true;
				case 1:
				case 5:
					inputsSnippetType = _003C_003E4__this;
					num = 7;
					continue;
				case 8:
					if (num2 == 1)
					{
						_003C_003E1__state = -1;
						num = 11;
						continue;
					}
					goto case 4;
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
			_003CGetUpdates_003Ed__8 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__8(0)
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
		internal static void dBtQtQKlGQfPm3fDOMUP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VgipAfKloSx17p53rnxM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g4LgcmKlBlYRw9CKHv0t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kKwi7iKlbaVssEEWftef()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ojxSU2KlS0dCj43LrrUD(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int lB1pKqKlkBRdwtvLWa5o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yqh2DfKl8fhMgltgrEY1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	protected static readonly ILogger Log;

	private readonly Guid[] qTSUztYKJc;

	private readonly PasteBuffer BfR7agUGmG;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qTSUztYKJc;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputsSnippetType(AppStepViewModel appStepVm)
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
			case 6:
				qTSUztYKJc = new Guid[1]
				{
					new Guid((string)cSAw7yIlWqCbZ5TScPG(3408))
				};
				Ucc61TIfeV0kBB3XXhn();
				if (!DGRDBCIdRslccAdxyQA())
				{
					num = 0;
					if (!DGRDBCIdRslccAdxyQA())
					{
						break;
					}
					goto case 4;
				}
				num = 1;
				if (1 == 0)
				{
					return;
				}
				break;
			case 4:
				AddSnippet(BfR7agUGmG);
				num = 7;
				break;
			default:
				BfR7agUGmG = (PasteBuffer)xQCC0gIsbLkNLjGGKRB(iCpKdjIge0fGhWlbJ9H());
				num = 4;
				break;
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 6;
				break;
			case 0:
			case 2:
				base._002Ector(appStepVm);
				goto default;
			case 7:
				return;
			}
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
	[AsyncStateMachine(typeof(_003CAddSupportSnippet_003Ed__7))]
	public override Task<EzSupportSnippet> AddSupportSnippet(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddSupportSnippet_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.snippetManager = snippetManager;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__8))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__8(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InputsSnippetType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		Log = LogManager.GetLogger<InputsSnippetType>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EzSupportSnippet> FVPU1FvMbh(ISnippetManager P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.AddSupportSnippet(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cSAw7yIlWqCbZ5TScPG(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iCpKdjIge0fGhWlbJ9H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.Inputs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xQCC0gIsbLkNLjGGKRB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ucc61TIfeV0kBB3XXhn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DGRDBCIdRslccAdxyQA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
