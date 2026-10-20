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
public class RedLineCountToolType : RedLineToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateNewRedLineTool_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RedLineTool> _003C_003Et__builder;

		public RedLineCountToolType _003C_003E4__this;

		public InspectStepViewModel inspect;

		public bool isInitialized;

		public CvsCellCollection cells;

		public CvsCellRange pasteRange;

		private RedLineCountTool _003Ctool_003E5__2;

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
			if (!oGL7suK6nnIt7GbOf9dd())
			{
				num = 6;
			}
			else
			{
				num = 5;
				if (oGL7suK6nnIt7GbOf9dd())
				{
				}
			}
			RedLineTool result = default;
			int num2 = default;
			RedLineCountToolType redLineCountToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003Ctool_003E5__2 = null;
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					redLineCountToolType = _003C_003E4__this;
					num = 1;
					break;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new RedLineCountTool((string)iCo15rK6VLdNglq5NB67(redLineCountToolType), inspect, isInitialized);
							v4GAYHK6ioGAZcxptGsb();
							if (!oGL7suK6nnIt7GbOf9dd())
							{
								num3 = 7;
								if (!v4GAYHK6ioGAZcxptGsb())
								{
									return;
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
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 9;
								continue;
							case 1:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 0:
							case 7:
								awaiter = VHgAMnK6fU6sueO3cp7J(_003Ctool_003E5__2.SetCellRangeAsync(cells, pasteRange));
								num3 = 8;
								continue;
							case 2:
							case 5:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (awaiter.IsCompleted)
								{
									goto case 1;
								}
								goto case 2;
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
					goto default;
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
		internal static object iCo15rK6VLdNglq5NB67(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Source;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VHgAMnK6fU6sueO3cp7J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v4GAYHK6ioGAZcxptGsb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oGL7suK6nnIt7GbOf9dd()
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

		public static Func<PasteBuffer, string> _003C_003E9__25_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UONNXWK6gZDBkibaeLAu();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			NxdES1K6soIuvuWO7Gml(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__25_0(PasteBuffer buffer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)QcolOjK6vL6MSS82xm8a(49502);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UONNXWK6gZDBkibaeLAu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QG5utFK6dU2QweeioFig()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U4pxbuK6lExmXgvBprhc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NxdES1K6soIuvuWO7Gml(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QcolOjK6vL6MSS82xm8a(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__25 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public RedLineCountToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__25(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (CxNf6kK6PHeB9tvdPXLi() ? 4 : 5);
			while (true)
			{
				switch (num)
				{
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				default:
					num = 3;
					if (!CxNf6kK6PHeB9tvdPXLi())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 4:
					base._002Ector();
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 5:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					goto case 1;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
				num = 6;
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
			int num = 14;
			if (!CxNf6kK6PHeB9tvdPXLi())
			{
			}
			RedLineCountToolType redLineCountToolType = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				IL_0097:
				switch (num)
				{
				case 10:
					_003C_003E1__state = 4;
					num = 6;
					continue;
				case 24:
					_003C_003E2__current = new AddScoreCellUpdate(redLineCountToolType.Localizer);
					num = 9;
					continue;
				case 19:
					return true;
				case 7:
					return true;
				case 20:
					_003C_003E2__current = new AddGranularityUpdate(redLineCountToolType.Localizer);
					goto case 15;
				default:
					num = 15;
					continue;
				case 0:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						CvsCellLocation offset2 = new CvsCellLocation(5, 0);
						_003C_003E2__current = new EditArgumentUpdate(offset2, redLineCountToolType.Da2bRiTp6f, 0, null);
						num = 4;
						continue;
					}
					goto case 16;
				case 22:
					_003C_003E2__current = new EditArgumentUpdate(offset, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec.QcolOjK6vL6MSS82xm8a(49502);
					}, 0, null);
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 16;
				case 16:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 11;
						continue;
					}
					break;
				case 11:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, redLineCountToolType.Localizer);
					_003C_003E1__state = 6;
					return true;
				case 6:
					return true;
				case 17:
					return true;
				case 14:
					num2 = _003C_003E1__state;
					num = 12;
					continue;
				case 12:
					redLineCountToolType = _003C_003E4__this;
					num = 21;
					if (CRGc5NK6rHARHD7snJKg())
					{
						continue;
					}
					goto case 5;
				case 5:
					_003CcurrentVersion_003E5__2 = Kv3Eq4K6ZCBfObtvrmfH(cells, range);
					_003ClatestVersion_003E5__3 = LvyqUxK6BBVQi8ZbxbMk(redLineCountToolType._pasteObject);
					num = 2;
					if (!CxNf6kK6PHeB9tvdPXLi())
					{
						continue;
					}
					goto case 9;
				case 9:
					_003C_003E1__state = 2;
					num = 17;
					continue;
				case 18:
					_003C_003E1__state = 1;
					num = 7;
					continue;
				case 4:
					_003C_003E1__state = 5;
					num = 19;
					continue;
				case 2:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						_003C_003E2__current = new ToolDisabledJobPassUpdate();
						num = 18;
						continue;
					}
					goto case 8;
				case 8:
				case 13:
					if (_003CcurrentVersion_003E5__2 >= 2)
					{
						goto case 0;
					}
					num = 23;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					return false;
				case 15:
					_003C_003E1__state = 3;
					return true;
				case 21:
					while (true)
					{
						switch (num2)
						{
						case 5:
							break;
						case 1:
							goto IL_0063;
						case 6:
							goto IL_01c1;
						case 4:
							goto IL_01d4;
						case 2:
							goto IL_01e7;
						case 0:
							goto IL_02c6;
						case 3:
							goto end_IL_02f9;
						default:
							goto IL_031b;
						}
						_003C_003E1__state = -1;
						num = 16;
						goto IL_0097;
						IL_031b:
						CxNf6kK6PHeB9tvdPXLi();
						if (!CRGc5NK6rHARHD7snJKg())
						{
							num = 8;
							if (1 == 0)
							{
								continue;
							}
						}
						else
						{
							num = 1;
						}
						goto IL_0097;
						IL_0063:
						_003C_003E1__state = -1;
						num = 24;
						goto IL_0097;
						IL_01c1:
						_003C_003E1__state = -1;
						num = 25;
						goto IL_0097;
						IL_02c6:
						_003C_003E1__state = -1;
						num = 5;
						goto IL_0097;
						IL_01e7:
						_003C_003E1__state = -1;
						num = 20;
						goto IL_0097;
						IL_01d4:
						_003C_003E1__state = -1;
						num = 0;
						goto IL_0097;
						continue;
						end_IL_02f9:
						break;
					}
					_003C_003E1__state = -1;
					goto case 8;
				case 23:
					offset = new CvsCellLocation(0, 6);
					num = 22;
					continue;
				case 25:
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
			_003CGetUpdates_003Ed__25 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__25(0)
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
		internal static bool CRGc5NK6rHARHD7snJKg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CxNf6kK6PHeB9tvdPXLi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Kv3Eq4K6ZCBfObtvrmfH(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int LvyqUxK6BBVQi8ZbxbMk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private static Guid[] nHgb4ChDvC;

	private int wcRblFRLbW;

	protected override byte[] SnippetResource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte[])lV1TK38B1PBdNF12YBj();
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
			return nHgb4ChDvC;
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
			return new string[1] { (string)mIxcDR8bsMZICbStepa() };
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
			return (string)TFN6qG8GaiLl5nFewfG();
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
			return (string)pLlB4y8od8nMEhfpjL9();
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
			return XAMLGraphicKeys.Tools_CountPatternsIcon;
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
			return XAMLGraphicKeys.Tools_CountPatternsIcon;
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
			return wcRblFRLbW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref wcRblFRLbW, value, (string)CpWO0v8SniOfYg2vweS(3256));
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

	public override bool AdjustRangeLimits
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
	public RedLineCountToolType()
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
			default:
				base._002Ector();
				num = 5;
				continue;
			case 1:
			case 4:
				wcRblFRLbW = 300;
				goto default;
			case 0:
				break;
			case 5:
				return;
			}
			do
			{
				n5I94I8ZKp2FErlom4m();
				_ = 1;
				if (MJQcyW8P6HLojEmss6M())
				{
					num = 3;
					continue;
				}
				num = 4;
				if (MJQcyW8P6HLojEmss6M())
				{
				}
				break;
			}
			while (!J14bSs8rccDBYqNcDqc());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateNewRedLineTool_003Ed__24))]
	protected override Task<RedLineTool> CreateNewRedLineTool(InspectStepViewModel inspect, CvsCellCollection cells, CvsCellRange pasteRange, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateNewRedLineTool_003Ed__24 stateMachine = default;
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
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__25))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__25(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string Da2bRiTp6f(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HQ9oFs88sJ1OWVAHhFT(QWRkkT8kkOuaDgWU398(SnippetPasteBuffer.GetCellInTool(P_0, (string)CpWO0v8SniOfYg2vweS(4928)))).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RedLineCountToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		nHgb4ChDvC = new Guid[1]
		{
			new Guid((string)CpWO0v8SniOfYg2vweS(19838))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n5I94I8ZKp2FErlom4m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J14bSs8rccDBYqNcDqc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MJQcyW8P6HLojEmss6M()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lV1TK38B1PBdNF12YBj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.RedLineCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mIxcDR8bsMZICbStepa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qm5ZLplBc4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TFN6qG8GaiLl5nFewfG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UkvJ6Ny7cy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pLlB4y8od8nMEhfpjL9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.K3xJFpGw3s();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CpWO0v8SniOfYg2vweS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QWRkkT8kkOuaDgWU398(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation HQ9oFs88sJ1OWVAHhFT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.Parse((string)P_0);
	}
}
