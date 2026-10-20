using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax.PatMaxUpdates;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;

[Export(typeof(EzToolType))]
public class RedLinePresenceToolType : RedLineToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateNewRedLineTool_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RedLineTool> _003C_003Et__builder;

		public RedLinePresenceToolType _003C_003E4__this;

		public InspectStepViewModel inspect;

		public bool isInitialized;

		public CvsCellCollection cells;

		public CvsCellRange pasteRange;

		private RedLineTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yj9CdWK6GRhHbDntURQa();
			int num;
			if (eSQdcPK6bMvQwQSDElo4())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_0237;
				}
			}
			goto IL_0200;
			IL_0200:
			RedLineTool result = default;
			RedLinePresenceToolType redLinePresenceToolType = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					if (!Yj9CdWK6GRhHbDntURQa())
					{
						continue;
					}
					goto case 4;
				case 4:
					redLinePresenceToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new RedLineTool((string)Wwp8BTK6oRDZPER8aFf7(redLinePresenceToolType), inspect, isInitialized);
							eSQdcPK6bMvQwQSDElo4();
							num3 = ((!Yj9CdWK6GRhHbDntURQa()) ? 1 : 9);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 3:
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 0:
							case 1:
								awaiter = oyktkpK6k6s5JVMRes3e(vTuFGBK6SEvJhpam3AJk(_003Ctool_003E5__2, cells, pasteRange));
								num3 = 5;
								if (Yj9CdWK6GRhHbDntURQa())
								{
								}
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								goto case 8;
							case 6:
								return;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 10:
								result = _003Ctool_003E5__2;
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_0237;
			IL_0237:
			_003Ctool_003E5__2 = null;
			num = 6;
			goto IL_0200;
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
		internal static object Wwp8BTK6oRDZPER8aFf7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Source;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vTuFGBK6SEvJhpam3AJk(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oyktkpK6k6s5JVMRes3e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eSQdcPK6bMvQwQSDElo4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yj9CdWK6GRhHbDntURQa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PasteBuffer, string> _003C_003E9__23_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sQKPHGK6EjHWJYVHSu0V();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sQKPHGK6EjHWJYVHSu0V();
			FlcT41K6ptDTROJKQ9KK(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__23_0(PasteBuffer buffer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)ftZ5IrK6XT85J65IA9Z0(49502);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sQKPHGK6EjHWJYVHSu0V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YQyedoK68FAufD97UVYq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tb7mocK6qJflRoKo5Vso()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FlcT41K6ptDTROJKQ9KK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ftZ5IrK6XT85J65IA9Z0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__23 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public RedLinePresenceToolType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

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
		public _003CGetUpdates_003Ed__23(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 4:
					Soyn4uK63r4UBLWsV5SJ(this);
					S0RWBUK695qhhhPgLZSm();
					if (mFEuQLK64X5uNqNcUQHc())
					{
						num = 0;
						break;
					}
					num = 5;
					if (S0RWBUK695qhhhPgLZSm())
					{
						break;
					}
					goto default;
				default:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					if (mFEuQLK64X5uNqNcUQHc())
					{
					}
					break;
				case 1:
					ufnpkKK67Gapp6FcEx23();
					num = 4;
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
			RedLinePresenceToolType redLinePresenceToolType = default;
			int num2 = default;
			CvsCellLocation offset = default;
			while (true)
			{
				switch (num)
				{
				case 19:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 13;
						continue;
					}
					goto case 15;
				case 5:
				case 11:
					_003C_003E1__state = 3;
					num = 1;
					continue;
				case 0:
					return true;
				case 18:
					_003C_003E1__state = 1;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 8;
				case 8:
					redLinePresenceToolType = _003C_003E4__this;
					num = 14;
					if (true)
					{
						continue;
					}
					goto case 9;
				case 9:
					_003ClatestVersion_003E5__3 = ibb4eMK66dlLKRtSuIOM(redLinePresenceToolType._pasteObject);
					num = 19;
					continue;
				case 1:
					return true;
				case 17:
					return true;
				default:
					num = 20;
					continue;
				case 4:
					_003C_003E1__state = 4;
					goto case 7;
				case 14:
					switch (num2)
					{
					case 1:
						break;
					case 3:
						goto IL_00af;
					case 2:
						goto IL_00c2;
					default:
						return false;
					case 0:
						goto IL_0179;
					case 5:
						goto IL_0193;
					case 4:
						goto IL_027f;
					}
					_003C_003E1__state = -1;
					_003C_003E2__current = new AddScoreCellUpdate(redLinePresenceToolType.Localizer);
					_003C_003E1__state = 2;
					num = 17;
					if (true)
					{
						continue;
					}
					goto case 18;
				case 12:
					_003C_003E1__state = 5;
					return true;
				case 10:
					num2 = _003C_003E1__state;
					num = 8;
					continue;
				case 6:
					_003C_003E2__current = new EditArgumentUpdate(offset, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec.ftZ5IrK6XT85J65IA9Z0(49502);
					}, 0, null);
					num = 4;
					continue;
				case 3:
					_003CcurrentVersion_003E5__2 = K6U1MBK6j1wy4tj6l12u(cells, range);
					num = 9;
					continue;
				case 2:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, redLinePresenceToolType.Localizer);
					num = 12;
					if (0 == 0)
					{
						continue;
					}
					goto case 20;
				case 20:
					_003C_003E2__current = new AddGranularityUpdate(redLinePresenceToolType.Localizer);
					_ = 1;
					num = ((!mFEuQLK64X5uNqNcUQHc()) ? 5 : 7);
					continue;
				case 15:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						offset = new CvsCellLocation(0, 6);
						num = 6;
						continue;
					}
					goto IL_0286;
				case 7:
				case 16:
					return true;
				case 13:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 18;
					continue;
				case 21:
					break;
					IL_027f:
					_003C_003E1__state = -1;
					goto IL_0286;
					IL_0193:
					_003C_003E1__state = -1;
					num = 21;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
					IL_0179:
					_003C_003E1__state = -1;
					num = 3;
					continue;
					IL_00c2:
					_003C_003E1__state = -1;
					goto case 20;
					IL_0286:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 2;
						continue;
					}
					break;
					IL_00af:
					_003C_003E1__state = -1;
					num = 15;
					continue;
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
			_003CGetUpdates_003Ed__23 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__23(0)
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
		internal static void ufnpkKK67Gapp6FcEx23()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Soyn4uK63r4UBLWsV5SJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S0RWBUK695qhhhPgLZSm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mFEuQLK64X5uNqNcUQHc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int K6U1MBK6j1wy4tj6l12u(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ibb4eMK66dlLKRtSuIOM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private static Guid[] KCFbTOxLUg;

	private int BSKbW7XlQH;

	protected override byte[] SnippetResource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte[])MDL4xT8XWnpSF1ilKpY();
		}
	}

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KCFbTOxLUg;
		}
	}

	public override string[] Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new string[1] { Resources.A6xJ0EZQJY() };
		}
	}

	public override string ToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.jcfJofZQAa();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)J5oT7i89VtPddpRci5v();
		}
	}

	public override string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PatMaxPatternPresenceIcon;
		}
	}

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PatMaxPatternPresenceIcon;
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BSKbW7XlQH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref BSKbW7XlQH, value, (string)z82Gk284XHl4EWmmAZ0(3256));
		}
	}

	public override bool AssignDefaultFixture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RedLinePresenceToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!HTEbtB8EDUsPp62OXKE())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0055;
		IL_003b:
		BSKbW7XlQH = 125;
		goto IL_007c;
		IL_0055:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_003b;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_007c;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		jdZktG8pwXuX9XNeqSX();
		goto IL_003b;
		IL_007c:
		base._002Ector();
		num = 5;
		goto IL_0055;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateNewRedLineTool_003Ed__22))]
	protected override Task<RedLineTool> CreateNewRedLineTool(InspectStepViewModel inspect, CvsCellCollection cells, CvsCellRange pasteRange, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateNewRedLineTool_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<RedLineTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.inspect = inspect;
		stateMachine.cells = cells;
		stateMachine.pasteRange = pasteRange;
		stateMachine.isInitialized = isInitialized;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__23))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__23(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RedLinePresenceToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jdZktG8pwXuX9XNeqSX();
		KCFbTOxLUg = new Guid[1]
		{
			new Guid((string)z82Gk284XHl4EWmmAZ0(19914))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jdZktG8pwXuX9XNeqSX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XF0LZJ8qetXDk87IfjS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HTEbtB8EDUsPp62OXKE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MDL4xT8XWnpSF1ilKpY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.RedLinePresence;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J5oT7i89VtPddpRci5v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.nX0JDDUnd9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z82Gk284XHl4EWmmAZ0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
