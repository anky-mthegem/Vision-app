#define TRACE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public abstract class EzSnippetType : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public CvsInSight insight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass13_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			enJ4y0KDlhtbNJerwe3i(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAreFunctionsSupported_003Eb__0(PasteBufferCell cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsParse cvsParse = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					zcGp3M37Ki.Log(LogLevel.Error, (string)vKPQAKKDbXk2HiVsrJxG(cell.Expression, EEvcsuKDBnIZetCJdGai(48140)));
					num = 6;
					continue;
				case 9:
					if (cvsParse != null)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 7:
					if (!eyGcRCKDZhsYckUUoSrG(cvsParse))
					{
						num = 3;
						continue;
					}
					break;
				case 1:
				case 8:
					if (BA61LnKDsYH8g6DDhjiK(text))
					{
						break;
					}
					goto case 0;
				case 5:
					text = (string)hhwdnMKDg3rBViP3Ap1J(cell);
					DgbfCcKDdl1W60sKb2Fo();
					num = (dJhd23KDfcHBsjpPhoYj() ? 8 : 0);
					continue;
				case 0:
				case 2:
					cvsParse = CvsParse.Parse((CvsFunctionTable)DZdoWjKDvRbBOt82ZArY(insight), (IExpressionConstants)SWsHBmKDrTFnBCRHmlmT(insight), text, 0);
					num = 9;
					continue;
				case 4:
					if (MtB0ThKDPdCsOXwSuD8a(cvsParse) != null)
					{
						break;
					}
					goto case 7;
				default:
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					GiK1UVKDGkIGnqFvWCAq((string)hhwdnMKDg3rBViP3Ap1J(cell) + (string)EEvcsuKDBnIZetCJdGai(48140));
					num = 10;
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void enJ4y0KDlhtbNJerwe3i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dJhd23KDfcHBsjpPhoYj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DgbfCcKDdl1W60sKb2Fo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hhwdnMKDg3rBViP3Ap1J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BA61LnKDsYH8g6DDhjiK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DZdoWjKDvRbBOt82ZArY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SWsHBmKDrTFnBCRHmlmT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MtB0ThKDPdCsOXwSuD8a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).Function;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eyGcRCKDZhsYckUUoSrG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).IsWellFormed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EEvcsuKDBnIZetCJdGai(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vKPQAKKDbXk2HiVsrJxG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GiK1UVKDGkIGnqFvWCAq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Trace.WriteLine((string)P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSnippet_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippetType _003C_003E4__this;

		public CvsCellRange range;

		public CvsCellCollection cells;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EzSnippetType ezSnippetType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						TaskAwaiter<byte[]> awaiter2;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_016c;
							}
							awaiter2 = ((CvsInSight)O1OvNCKDkiSa1tcPr5Ou(ezSnippetType)).UndoHandler.SendCopyAsync(range).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						PasteBuffer pasteBuffer = (PasteBuffer)N0jA7bKD8Lg76ssTV7kW(awaiter2.GetResult());
						IEnumerator<ISnippetUpdate> enumerator = ezSnippetType.GetUpdates(cells, range).GetEnumerator();
						try
						{
							while (YB1Pl7KDE2YnUooDbH1Q(enumerator))
							{
								pasteBuffer = (PasteBuffer)l2jYdfKDqKGmNiAhGQRZ(enumerator.Current, pasteBuffer);
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								cawSWaKDpFoN5NgdXorC(enumerator);
							}
						}
						awaiter = ExUAQiKD9S1SsnA7Pw9h(((CvsInSight)O1OvNCKDkiSa1tcPr5Ou(ezSnippetType)).PasteCellsAsync(range, (byte[])Ix4hyXKDX2OmbBJ6XjIp(pasteBuffer), false, true));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_016c;
						IL_016c:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					ezSnippetType = _003C_003E4__this;
					_ = 0;
					num = ((!zZr5lhKDoDtSfJbpffOh()) ? 5 : 0);
					break;
				case 6:
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
		internal static object O1OvNCKDkiSa1tcPr5Ou(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N0jA7bKD8Lg76ssTV7kW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PasteBuffer.FromBytes((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l2jYdfKDqKGmNiAhGQRZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetUpdate)P_0).Apply((PasteBuffer)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YB1Pl7KDE2YnUooDbH1Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cawSWaKDpFoN5NgdXorC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ix4hyXKDX2OmbBJ6XjIp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).ToBytes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ExUAQiKD9S1SsnA7Pw9h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zZr5lhKDoDtSfJbpffOh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FPFMLwKDS4MaImeOjRyx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Guid guid;

		public Func<PasteBufferCell, bool> _003C_003E9__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass19_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BJpPLoKD3RLQyw2hXGO8();
			iRwL0vKDjvC8uux40WiI(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CNeedsUpdate_003Eb__0(PasteBuffer s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Cells.Any([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Guid result;
				return Guid.TryParse((string)Car905KD6YXalUdbkcDt(c), out result) && result.Equals(guid);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CNeedsUpdate_003Eb__1(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Guid.TryParse((string)Car905KD6YXalUdbkcDt(c), out var result))
			{
				return result.Equals(guid);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BJpPLoKD3RLQyw2hXGO8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iRwL0vKDjvC8uux40WiI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DJkcIYKD4IKMH9Z86H2w()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool prGtE7KD7T59fI1yO9Hq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Car905KD6YXalUdbkcDt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Comment;
		}
	}

	private static readonly ILogger zcGp3M37Ki;

	private readonly List<PasteBuffer> pp5pIxEN7H;

	[CompilerGenerated]
	private SnippetLocalizer HBPpfFlnkZ;

	public abstract Guid[] Guids { get; }

	protected IReadOnlyList<PasteBuffer> SnippetObjects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pp5pIxEN7H;
		}
	}

	protected abstract CvsInSight InSight { get; }

	protected SnippetLocalizer Localizer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HBPpfFlnkZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HBPpfFlnkZ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SnippetLocalizer CreateDefaultSnippetLocalizer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new SnippetLocalizer((ResourceManager)rv4P5x5jHFIrZZwSDck());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AreFunctionsSupported(PasteBuffer obj, CvsInSight insight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals3.insight = insight;
		return obj.Cells.All([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell cell) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsParse cvsParse = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					zcGp3M37Ki.Log(LogLevel.Error, (string)_003C_003Ec__DisplayClass13_0.vKPQAKKDbXk2HiVsrJxG(cell.Expression, _003C_003Ec__DisplayClass13_0.EEvcsuKDBnIZetCJdGai(48140)));
					num = 6;
					continue;
				case 9:
					if (cvsParse != null)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 7:
					if (!_003C_003Ec__DisplayClass13_0.eyGcRCKDZhsYckUUoSrG(cvsParse))
					{
						num = 3;
						continue;
					}
					break;
				case 1:
				case 8:
					if (_003C_003Ec__DisplayClass13_0.BA61LnKDsYH8g6DDhjiK(text))
					{
						break;
					}
					goto case 0;
				case 5:
					text = (string)_003C_003Ec__DisplayClass13_0.hhwdnMKDg3rBViP3Ap1J(cell);
					_003C_003Ec__DisplayClass13_0.DgbfCcKDdl1W60sKb2Fo();
					num = (_003C_003Ec__DisplayClass13_0.dJhd23KDfcHBsjpPhoYj() ? 8 : 0);
					continue;
				case 0:
				case 2:
					cvsParse = CvsParse.Parse((CvsFunctionTable)_003C_003Ec__DisplayClass13_0.DZdoWjKDvRbBOt82ZArY(CS_0024_003C_003E8__locals3.insight), (IExpressionConstants)_003C_003Ec__DisplayClass13_0.SWsHBmKDrTFnBCRHmlmT(CS_0024_003C_003E8__locals3.insight), text, 0);
					num = 9;
					continue;
				case 4:
					if (_003C_003Ec__DisplayClass13_0.MtB0ThKDPdCsOXwSuD8a(cvsParse) != null)
					{
						break;
					}
					goto case 7;
				default:
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					_003C_003Ec__DisplayClass13_0.GiK1UVKDGkIGnqFvWCAq((string)_003C_003Ec__DisplayClass13_0.hhwdnMKDg3rBViP3Ap1J(cell) + (string)_003C_003Ec__DisplayClass13_0.EEvcsuKDBnIZetCJdGai(48140));
					num = 10;
					continue;
				case 10:
					return false;
				}
				break;
			}
			return true;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckFunctions(IEnumerable<PasteBuffer> snippets)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return snippets?.All([MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mkU5n350RIuL8gIcUEb(P_0, InSight);
		}) ?? false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddSnippet(PasteBuffer snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AddSnippet(snippet, CreateDefaultSnippetLocalizer());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddSnippet(PasteBuffer snippet, SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mkFjsE53biRU577wVCp();
		int num = ((!CSipDG579uFqrJetkvF()) ? 1 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
			{
				SnippetLocalizer localizer2 = Localizer;
				if (localizer2 == null)
				{
					num = 4;
					break;
				}
				localizer2.Localize(snippet);
				goto default;
			}
			default:
				pp5pIxEN7H.Add(snippet);
				num = 6;
				break;
			case 0:
			case 2:
				Localizer = localizer;
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateSnippet_003Ed__17))]
	public Task UpdateSnippet(CvsCellRange range, CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUpdateSnippet_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				CSipDG579uFqrJetkvF();
				if (!mkFjsE53biRU577wVCp())
				{
					num = 1;
					break;
				}
				num = 6;
				if (CSipDG579uFqrJetkvF())
				{
					break;
				}
				goto case 3;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 3:
				stateMachine.cells = cells;
				goto case 7;
			default:
				num = 7;
				break;
			case 1:
			case 2:
				stateMachine.range = range;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (mkFjsE53biRU577wVCp())
				{
				}
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public abstract IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool NeedsUpdate(CvsCellRange range, CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_006f;
		IL_001a:
		_003C_003Ec__DisplayClass19_0 obj = new _003C_003Ec__DisplayClass19_0();
		mkFjsE53biRU577wVCp();
		if (CSipDG579uFqrJetkvF())
		{
			num = 4;
			if (!CSipDG579uFqrJetkvF())
			{
				goto IL_0040;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_006f;
		IL_0040:
		throw new ArgumentException((string)AKVQGn5CA2oxLWOFrDr(1200));
		IL_006f:
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 5:
				goto IL_0040;
			default:
				num = 6;
				continue;
			case 3:
				throw new ArgumentException((string)AKVQGn5CA2oxLWOFrDr(1276));
			case 6:
				do
				{
					if (((IEnumerable<Guid>)rQN77p5RXDLqFDUyKOL(this)).Contains(obj.guid))
					{
						pasteBuffer = SnippetObjects.First(obj._003CNeedsUpdate_003Eb__0);
						num = 7;
						continue;
					}
					num = 3;
					break;
				}
				while (1 == 0);
				continue;
			case 1:
			case 4:
				if (FtfKdG56gfDqbrMViLE(cells[range.Location]))
				{
					obj.guid = g2Vfjx5ArAkd6LCiGSe(cells, range);
					goto case 6;
				}
				goto IL_0040;
			case 7:
				return wYOQ1U5Wv2vjA26Nxmx(cells, range) < px8PSa5TuTK5rKP0GPR(pasteBuffer);
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsCellLocation GetCellLocation(CvsCellLocation pasteOrigin, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellLocation(pasteOrigin.Row + offset.Row, pasteOrigin.Column + offset.Column);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzSnippetType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CSipDG579uFqrJetkvF();
		int num;
		if (!mkFjsE53biRU577wVCp())
		{
			num = 2;
			if (!CSipDG579uFqrJetkvF())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0060;
		IL_0043:
		pp5pIxEN7H = new List<PasteBuffer>();
		goto IL_0087;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 3:
				goto IL_0043;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0087;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		cTRIZN5yE23DVUe9jSK();
		goto IL_0043;
		IL_0087:
		base._002Ector();
		num = 5;
		goto IL_0060;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EzSnippetType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cTRIZN5yE23DVUe9jSK();
		zcGp3M37Ki = LogManager.GetLogger<EzSnippetType>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool swypSglfbh(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mkU5n350RIuL8gIcUEb(P_0, InSight);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rv4P5x5jHFIrZZwSDck()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EZBSnippetStrings.ResourceManager;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CSipDG579uFqrJetkvF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mkFjsE53biRU577wVCp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FtfKdG56gfDqbrMViLE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).HasComment;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AKVQGn5CA2oxLWOFrDr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid g2Vfjx5ArAkd6LCiGSe(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetSnippetGuid(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rQN77p5RXDLqFDUyKOL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippetType)P_0).Guids;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wYOQ1U5Wv2vjA26Nxmx(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetSnippetVersion(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int px8PSa5TuTK5rKP0GPR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cTRIZN5yE23DVUe9jSK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mkU5n350RIuL8gIcUEb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AreFunctionsSupported((PasteBuffer)P_0, (CvsInSight)P_1);
	}
}
