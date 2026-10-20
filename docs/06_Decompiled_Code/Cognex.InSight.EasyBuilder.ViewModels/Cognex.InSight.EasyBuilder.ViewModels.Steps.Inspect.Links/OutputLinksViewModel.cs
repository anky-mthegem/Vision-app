using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;

public class OutputLinksViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public CvsCell cell;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass11_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rrgXCtK2kHeWJFip9Bkl();
			wkl2fNK28nHWOHcqhHma(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefresh_003Eb__0(SourceLink f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ocpta6K2qs1yFJvZdF9d(f.Expression, cell.Expression);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rrgXCtK2kHeWJFip9Bkl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wkl2fNK28nHWOHcqhHma(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EZPocOK2osKScPflD0Td()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MsCQeCK2Sx6lxXJxFP2L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ocpta6K2qs1yFJvZdF9d(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveReferences_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputLinksViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private OutputResetToDefaultAction _003Cundo_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			OutputLinksViewModel outputLinksViewModel = default;
			TaskAwaiter awaiter = default;
			CvsCellRange cvsCellRange = default;
			CvsCellLocation location = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (S7twA2K2p5uwGRj4JYyT())
					{
					}
					continue;
				case 4:
					outputLinksViewModel = _003C_003E4__this;
					_ = 0;
					num = ((!klupGiK2E1dWYfen0CVm()) ? 1 : 0);
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (outputLinksViewModel.SelectedLink == null)
							{
								goto IL_02a8;
							}
							num3 = 25;
							goto IL_02ef;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 14;
							goto IL_02ef;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 10;
							goto IL_02ef;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
								if (S7twA2K2p5uwGRj4JYyT())
								{
									break;
								}
								goto IL_02ef;
							}
							IL_02ef:
							while (true)
							{
								switch (num3)
								{
								case 1:
									awaiter = jBpo5AK2j6BaLYnnNyHv(zeU5MHK26SHLlEnul7R4(_003Cundo_003E5__2));
									if (!awaiter.IsCompleted)
									{
										num3 = 6;
										continue;
									}
									goto case 23;
								case 3:
								case 17:
									if (!cvsCellRange.Contains(location))
									{
										goto end_IL_02ef;
									}
									_003Cundo_003E5__2 = new OutputResetToDefaultAction(outputLinksViewModel);
									num3 = 18;
									if (0 == 0)
									{
										continue;
									}
									goto case 16;
								case 16:
									num2 = (_003C_003E1__state = -1);
									goto IL_00e2;
								case 13:
								case 19:
									num2 = (_003C_003E1__state = 2);
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 23;
								case 23:
									awaiter.GetResult();
									num3 = 11;
									continue;
								case 14:
									_003C_003Eu__1 = default;
									num3 = 22;
									continue;
								case 18:
									awaiter = jBpo5AK2j6BaLYnnNyHv(NgKiRYK237eqAT9AcKPd(_003Cundo_003E5__2));
									num3 = 21;
									continue;
								case 22:
									num2 = (_003C_003E1__state = -1);
									num3 = 23;
									if (klupGiK2E1dWYfen0CVm())
									{
										continue;
									}
									goto case 11;
								case 11:
									_003Cundo_003E5__2 = null;
									num3 = 2;
									if (!S7twA2K2p5uwGRj4JYyT())
									{
										continue;
									}
									goto case 10;
								case 10:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 26;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 20:
									break;
								case 0:
									_003C_003Eu__1 = default;
									num3 = 16;
									continue;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									if (S7twA2K2p5uwGRj4JYyT())
									{
									}
									continue;
								case 8:
									if (awaiter.IsCompleted)
									{
										goto end_IL_0066;
									}
									goto case 13;
								case 7:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								case 9:
									return;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									continue;
								case 25:
									location = McZ2ZEK294rXZ1DB3nlS(iP4N6uK2XDvvFPJsOCkk(outputLinksViewModel.SelectedLink));
									num3 = 24;
									if (klupGiK2E1dWYfen0CVm())
									{
										continue;
									}
									goto end_IL_02ef;
								case 2:
									goto end_IL_02ef;
								case 24:
									if (location.IsValid)
									{
										num3 = 20;
										continue;
									}
									goto end_IL_02ef;
								case 6:
									num2 = (_003C_003E1__state = 1);
									goto case 5;
								default:
									num3 = 5;
									continue;
								case 21:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										num3 = 12;
										continue;
									}
									goto IL_00e2;
								case 15:
									return;
								case 26:
									goto end_IL_0066;
									IL_00e2:
									awaiter.GetResult();
									num3 = 1;
									continue;
								}
								cvsCellRange = tiiCQJK27HmuEyObfnL8(OL2mRbK24l0j79dx3A4O(e));
								S7twA2K2p5uwGRj4JYyT();
								num3 = ((!klupGiK2E1dWYfen0CVm()) ? 13 : 17);
								continue;
								end_IL_02ef:
								break;
							}
							goto IL_02a8;
							IL_02a8:
							awaiter = jBpo5AK2j6BaLYnnNyHv(m7AxoDK2CccoSVaFFv0n());
							num3 = 8;
							goto IL_02ef;
							end_IL_0066:
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
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
		internal static object iP4N6uK2XDvvFPJsOCkk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation McZ2ZEK294rXZ1DB3nlS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.TryParse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OL2mRbK24l0j79dx3A4O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange tiiCQJK27HmuEyObfnL8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NgKiRYK237eqAT9AcKPd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((OutputResetToDefaultAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jBpo5AK2j6BaLYnnNyHv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zeU5MHK26SHLlEnul7R4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((OutputResetToDefaultAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m7AxoDK2CccoSVaFFv0n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool klupGiK2E1dWYfen0CVm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S7twA2K2p5uwGRj4JYyT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private AppStepViewModel fbqOf35mbL;

	[CompilerGenerated]
	private readonly SourceLink fKMOE0aw3Y;

	[CompilerGenerated]
	private readonly string sFHOb498mZ;

	[CompilerGenerated]
	private readonly CvsCellLocation q3AOcNCuNZ;

	private List<SourceLink> Nw3OQscqI0;

	private SourceLink U53Og2DLRg;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sFHOb498mZ;
		}
	}

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q3AOcNCuNZ;
		}
	}

	public List<SourceLink> Links
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Nw3OQscqI0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Nw3OQscqI0, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27670));
		}
	}

	public SourceLink SelectedLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U53Og2DLRg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 10;
			while (true)
			{
				object obj2;
				object obj;
				switch (num)
				{
				case 0:
				case 5:
					obj2 = null;
					goto IL_0023;
				case 9:
					((CvsCogSocketSheet)ie9i3mTXfnfcOYxslTn(nbm7PTTpwlecHdMJ2yk(rd2iEcTkAsvpsuscSun(fbqOf35mbL)))).PutCellExpressionAndRunSheet(CellLocation, (string)bZDwv2T9sTWdipeDSjg(U53Og2DLRg));
					goto case 2;
				case 6:
				{
					CvsResultSet results = ((CvsInSight)rd2iEcTkAsvpsuscSun(fbqOf35mbL)).Results;
					if (results == null)
					{
						num = 1;
						break;
					}
					obj = nEg0pqTSXtBfmwte5L3(uEbRDvT8uKbk2nitrOL(results), CellLocation);
					goto IL_00cd;
				}
				case 3:
					U53Og2DLRg = value;
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					obj = null;
					goto IL_00cd;
				default:
					_ = 0;
					if (!WaHLwpTPxNapaV8u1J2())
					{
						num = 2;
						break;
					}
					num = 0;
					if (WaHLwpTPxNapaV8u1J2())
					{
						break;
					}
					goto case 8;
				case 8:
					AHXGX2T3YbWLtVwlqxD(this, Kr63IFT7G1PpSIfZfTx(5136));
					num = 11;
					if (yf2qbiTZmehGCoAccZy())
					{
					}
					break;
				case 4:
					if (U53Og2DLRg != value)
					{
						num = 3;
						break;
					}
					return;
				case 2:
				case 7:
					gNwDPAT4ZWWbZLGrTrk(rd2iEcTkAsvpsuscSun(fbqOf35mbL), true, false);
					num = 8;
					break;
				case 10:
					if (value != null)
					{
						num = 4;
						break;
					}
					return;
				case 11:
					return;
					IL_0023:
					if (KCPFoRTEXSTB1gN2mUu(obj2, U53Og2DLRg.Expression))
					{
						num = 9;
						if (WaHLwpTPxNapaV8u1J2())
						{
							break;
						}
						goto case 9;
					}
					return;
					IL_00cd:
					if (obj != null)
					{
						obj2 = x8twuHTqr9vrh7bUcUb(obj);
						goto IL_0023;
					}
					goto default;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputLinksViewModel(AppStepViewModel appStepViewModel, CvsCellCollection cells, CvsCellLocation loc, string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 7:
			case 9:
				if (SelectedLink == null)
				{
					num = 3;
					break;
				}
				return;
			case 4:
				q3AOcNCuNZ = loc;
				sFHOb498mZ = name;
				goto case 0;
			default:
				num = 0;
				break;
			case 3:
				SelectedLink = vghO3Gq9XT();
				num = 11;
				break;
			case 5:
				lW0vckTb2eeM2LRXv2l(this);
				num = 8;
				break;
			case 0:
				fKMOE0aw3Y = new SourceLink((string)UodcFWTGs5HvXsVC5kW(), CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838), CellType.Output);
				yf2qbiTZmehGCoAccZy();
				num = (WaHLwpTPxNapaV8u1J2() ? 1 : 9);
				break;
			case 1:
			case 6:
				Refresh(cells);
				goto case 7;
			case 2:
				AvKTMvTBTQqSf6BYG2H();
				num = 10;
				break;
			case 10:
				Nw3OQscqI0 = new List<SourceLink>();
				num = 5;
				break;
			case 8:
				fbqOf35mbL = appStepViewModel;
				num = 4;
				if (!WaHLwpTPxNapaV8u1J2())
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal SourceLink vghO3Gq9XT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fKMOE0aw3Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00bb;
		IL_001a:
		_003C_003Ec__DisplayClass11_0 obj = new _003C_003Ec__DisplayClass11_0();
		num = 0;
		goto IL_00bb;
		IL_00bb:
		SourceLink sourceLink = default;
		int num2 = default;
		List<SourceLink> list = default;
		SourceLink[] array = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				obj.cell = (CvsCell)nEg0pqTSXtBfmwte5L3(cells, CellLocation);
				num = 8;
				continue;
			case 8:
				if (obj.cell != null)
				{
					yf2qbiTZmehGCoAccZy();
					num = ((!WaHLwpTPxNapaV8u1J2()) ? 12 : 13);
					continue;
				}
				return;
			case 11:
			case 12:
				if (sourceLink != null)
				{
					num = 9;
					continue;
				}
				return;
			case 1:
				num2 = 0;
				num = 3;
				continue;
			case 6:
				list.Add(vghO3Gq9XT());
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 4:
			{
				if (num2 >= array.Length)
				{
					goto case 14;
				}
				SourceLink item = array[num2];
				list.Add(item);
				num2++;
				num = 4;
				continue;
			}
			default:
				num = 14;
				continue;
			case 14:
				Links = list;
				num = 2;
				if (WaHLwpTPxNapaV8u1J2())
				{
					continue;
				}
				goto case 0;
			case 0:
				list = new List<SourceLink>();
				num = 6;
				continue;
			case 9:
				SelectedLink = sourceLink;
				num = 15;
				continue;
			case 10:
			case 13:
				sourceLink = list.FirstOrDefault(obj._003CRefresh_003Eb__0);
				goto case 11;
			case 7:
				array = (SourceLink[])hmf6UvToHwbDpDcANg2(fbqOf35mbL.AppViewModel, CellType.Output);
				num = 1;
				continue;
			case 15:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__20))]
	internal Task vlFODZL8Hh(SnippetPreRemoveEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!yf2qbiTZmehGCoAccZy())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0040;
		IL_006f:
		_003CRemoveReferences_003Ed__20 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 2;
		if (!yf2qbiTZmehGCoAccZy())
		{
			goto IL_0040;
		}
		goto IL_0087;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 6;
				continue;
			case 6:
				goto IL_006f;
			case 2:
				goto IL_0087;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (WaHLwpTPxNapaV8u1J2())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = MCGh95TjxsA79lj5DVN();
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		stateMachine.e = P_0;
		goto IL_006f;
		IL_0087:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AvKTMvTBTQqSf6BYG2H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lW0vckTb2eeM2LRXv2l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UodcFWTGs5HvXsVC5kW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rvMLAYkyXc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WaHLwpTPxNapaV8u1J2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yf2qbiTZmehGCoAccZy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hmf6UvToHwbDpDcANg2(object P_0, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).GetSourceLinks(reqDataType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nEg0pqTSXtBfmwte5L3(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rd2iEcTkAsvpsuscSun(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uEbRDvT8uKbk2nitrOL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x8twuHTqr9vrh7bUcUb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KCPFoRTEXSTB1gN2mUu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nbm7PTTpwlecHdMJ2yk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ie9i3mTXfnfcOYxslTn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bZDwv2T9sTWdipeDSjg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gNwDPAT4ZWWbZLGrTrk(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kr63IFT7G1PpSIfZfTx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AHXGX2T3YbWLtVwlqxD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder MCGh95TjxsA79lj5DVN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
