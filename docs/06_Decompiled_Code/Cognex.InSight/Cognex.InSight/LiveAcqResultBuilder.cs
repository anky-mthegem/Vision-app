using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class LiveAcqResultBuilder : ILiveAcqResultBuilder, IResultBuilder
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateNewResultSet_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsResultSet> _003C_003Et__builder;

		public LiveAcqResultBuilder _003C_003E4__this;

		private TaskAwaiter<CvsCogImage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!EmeUXxsSxht3N9vSuyAL()) ? 1 : 2);
			int num2 = default;
			LiveAcqResultBuilder liveAcqResultBuilder = default;
			TaskAwaiter<CvsCogImage> awaiter = default;
			CvsResultSet result = default;
			long id = default;
			CvsCogImage result2 = default;
			OrderedDictionary outputs = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!liveAcqResultBuilder.FkmacPN6q7)
							{
								num3 = 13;
							}
							else
							{
								if (liveAcqResultBuilder.gyganUWrYH != null)
								{
									goto IL_00f8;
								}
								cDpl43sS1v5OcqLVt3Ou();
								if (EmeUXxsSxht3N9vSuyAL())
								{
									num3 = 5;
									if (!EmeUXxsSxht3N9vSuyAL())
									{
										return;
									}
								}
								else
								{
									num3 = 3;
								}
							}
							goto IL_0090;
						}
						awaiter = _003C_003Eu__1;
						goto IL_01ae;
						IL_01ae:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_0090;
						IL_011b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						goto IL_0090;
						IL_0090:
						while (true)
						{
							switch (num3)
							{
							case 13:
								result = null;
								goto end_IL_0024;
							case 9:
								return;
							default:
								num3 = 6;
								continue;
							case 8:
								id = liveAcqResultBuilder.i4Ia75em7i++;
								num3 = 14;
								continue;
							case 0:
								break;
							case 11:
								goto IL_011b;
							case 2:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 10;
									continue;
								}
								goto case 7;
							case 7:
								result2 = awaiter.GetResult();
								num3 = 12;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 5:
								awaiter = liveAcqResultBuilder.ncIaoNHlZd.GetAcqImageProperties().GetAwaiter();
								goto case 2;
							case 12:
								liveAcqResultBuilder.gyganUWrYH = result2;
								num3 = 0;
								continue;
							case 6:
								goto IL_01ae;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 14:
							{
								CvsResultSet cvsResultSet = new CvsResultSet(id, liveAcqResultBuilder.ncIaoNHlZd.LatestAcqImageUrl, liveAcqResultBuilder.TrTamOmD3w, liveAcqResultBuilder.XHUaWIYMNq, (CvsSheetInfo)veOiN1sSOb9BPAKgI7lg(liveAcqResultBuilder.dpHatQ6UgC), (CvsCell)ciS1WlsSMRoPs66s65IJ(liveAcqResultBuilder.ifva3t3ceS), outputs, (CvsCogSheetResult)hB1cUOsSQYZYHfWHRoYW(liveAcqResultBuilder.H7QaAYjF0E));
								nmW7g8sSlVtjUvxCZTdD(cvsResultSet, liveAcqResultBuilder.HwHaYrxrtI++);
								result = cvsResultSet;
								goto end_IL_0024;
							}
							}
							break;
						}
						goto IL_00f8;
						IL_00f8:
						outputs = (OrderedDictionary)voGbYlsS3Tt9Z8pGVTB3(fx7GFbsSrIrVh98UdiWS(liveAcqResultBuilder.ncIaoNHlZd), liveAcqResultBuilder.gyganUWrYH);
						num3 = 8;
						if (true)
						{
							goto IL_0090;
						}
						goto IL_011b;
						end_IL_0024:;
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
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					liveAcqResultBuilder = _003C_003E4__this;
					num = 4;
					if (cDpl43sS1v5OcqLVt3Ou())
					{
						return;
					}
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
		internal static object fx7GFbsSrIrVh98UdiWS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICogSocketAcq)P_0).LatestAcqImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object voGbYlsS3Tt9Z8pGVTB3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return psjalwnhsy((string)P_0, (CvsCogImage)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object veOiN1sSOb9BPAKgI7lg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSheetInfo)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ciS1WlsSMRoPs66s65IJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsPropSheet)P_0).LastPropertySheetCell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hB1cUOsSQYZYHfWHRoYW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).LastSheetResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nmW7g8sSlVtjUvxCZTdD(object P_0, long value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsResultSet)P_0).CellRequestId = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EmeUXxsSxht3N9vSuyAL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cDpl43sS1v5OcqLVt3Ou()
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
	private struct _003C_003CCreateAndPublish_003Eb__40_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LiveAcqResultBuilder _003C_003E4__this;

		private TaskAwaiter<CvsResultSet> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EL07G9sSeraKrV88PiTB();
			int num;
			if (!nGjp5UsSuuyP0LuB3SYr())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!EL07G9sSeraKrV88PiTB())
				{
					return;
				}
			}
			int num2 = default;
			LiveAcqResultBuilder liveAcqResultBuilder = default;
			CvsResultSet result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 2:
				case 4:
					try
					{
						try
						{
							TaskAwaiter<CvsResultSet> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = liveAcqResultBuilder.gYxaO7cNHt().GetAwaiter();
								num3 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
							}
							while (true)
							{
								switch (num3)
								{
								case 5:
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									num3 = (EL07G9sSeraKrV88PiTB() ? 1 : 8);
									continue;
								case 4:
									return;
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 9;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 1:
								case 2:
									_003C_003Eu__1 = awaiter;
									goto case 3;
								case 9:
									result = awaiter.GetResult();
									num3 = 10;
									if (nGjp5UsSuuyP0LuB3SYr())
									{
									}
									continue;
								case 7:
									_003C_003Eu__1 = default;
									num3 = 0;
									continue;
								case 3:
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 10:
									liveAcqResultBuilder.MaqahRZY8e(result);
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							GOmgv2sSIyu1wY43aNIb(CvsTraceSDK.Error, ex);
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					liveAcqResultBuilder = _003C_003E4__this;
					goto case 2;
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
		internal static void GOmgv2sSIyu1wY43aNIb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EL07G9sSeraKrV88PiTB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nGjp5UsSuuyP0LuB3SYr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ICogSocketAcq ncIaoNHlZd;

	private readonly CvsCogSocketSheet H7QaAYjF0E;

	private readonly CvsSheetInfo dpHatQ6UgC;

	private readonly CvsProcessorConstants XHUaWIYMNq;

	private readonly CvsPropSheet ifva3t3ceS;

	private ILiveModeService MRVaLSr4Jg;

	private readonly object p5SakfAtOd;

	private CvsResultSet ykKaXCYZqg;

	private readonly object H9uafad2LY;

	[CompilerGenerated]
	private EventHandler kB8ajNFnvi;

	private bool FkmacPN6q7;

	private bool MpNa5yL49O;

	private int HwHaYrxrtI;

	private long i4Ia75em7i;

	private readonly CvsCellCollection TrTamOmD3w;

	private CvsCogImage gyganUWrYH;

	private int C43a9BcGIV;

	public ILiveModeService LiveModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MRVaLSr4Jg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 2:
				case 5:
					MRVaLSr4Jg = value;
					goto default;
				default:
					if (MRVaLSr4Jg != null)
					{
						num = 1;
						break;
					}
					return;
				case 4:
					if (MRVaLSr4Jg != null)
					{
						num = 6;
						break;
					}
					goto case 2;
				case 6:
					MRVaLSr4Jg.IsLiveAcquisitionChanged -= z5OabccHm7;
					_ = 0;
					num = (NI5RYnTOqj6Xj3enMNe() ? 5 : 0);
					break;
				case 1:
					nRVVVxTRSkJIVKqjmrm(MRVaLSr4Jg, new EventHandler(z5OabccHm7));
					num = 7;
					break;
				case 7:
					return;
				}
			}
		}
	}

	CvsResultSet IResultBuilder.Results
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fGYN9ITMR3HBvH0EiPk();
			int num;
			if (NI5RYnTOqj6Xj3enMNe())
			{
				num = 2;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 1:
				case 3:
					goto IL_0041;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_0078;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			object obj = p5SakfAtOd;
			goto IL_0041;
			IL_0041:
			bool lockTaken = false;
			goto IL_0078;
			IL_0078:
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				return ykKaXCYZqg;
			}
			finally
			{
				if (lockTaken)
				{
					CPV2P3TaLXMajwtpguO(obj);
				}
			}
		}
	}

	event EventHandler IResultBuilder.ResultsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (NI5RYnTOqj6Xj3enMNe())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (!NI5RYnTOqj6Xj3enMNe())
				{
					goto IL_007a;
				}
			}
			bool lockTaken = default;
			object h9uafad2LY = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					h9uafad2LY = H9uafad2LY;
					goto case 1;
				case 4:
					break;
				}
				break;
			}
			goto IL_007a;
			IL_007a:
			try
			{
				Monitor.Enter(h9uafad2LY, ref lockTaken);
				D46aBESyCC(value);
			}
			finally
			{
				if (lockTaken)
				{
					CPV2P3TaLXMajwtpguO(h9uafad2LY);
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (NI5RYnTOqj6Xj3enMNe())
			{
				num = 2;
				if (fGYN9ITMR3HBvH0EiPk())
				{
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0080;
				}
			}
			bool lockTaken = default;
			object h9uafad2LY = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					h9uafad2LY = H9uafad2LY;
					goto case 1;
				case 4:
					break;
				}
				break;
			}
			goto IL_0080;
			IL_0080:
			try
			{
				Monitor.Enter(h9uafad2LY, ref lockTaken);
				YHRaJnGtU9(value);
			}
			finally
			{
				if (lockTaken)
				{
					CPV2P3TaLXMajwtpguO(h9uafad2LY);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void D46aBESyCC(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (NI5RYnTOqj6Xj3enMNe())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_005a;
			}
		}
		goto IL_0079;
		IL_005a:
		EventHandler eventHandler = default;
		EventHandler value2 = (EventHandler)S4CPiPTQT8B78tH2gKm(eventHandler, value);
		goto IL_00a8;
		IL_00a8:
		EventHandler eventHandler2 = Interlocked.CompareExchange(ref kB8ajNFnvi, value2, eventHandler);
		num = 5;
		if (1 == 0)
		{
			return;
		}
		goto IL_0079;
		IL_0079:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				eventHandler = eventHandler2;
				num = 2;
				continue;
			case 5:
				if ((object)eventHandler2 == eventHandler)
				{
					num = 7;
					continue;
				}
				goto case 1;
			case 0:
			case 3:
				eventHandler2 = kB8ajNFnvi;
				goto case 1;
			case 2:
				break;
			default:
				num = 6;
				continue;
			case 6:
				goto IL_00a8;
			case 7:
				return;
			}
			break;
		}
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void YHRaJnGtU9(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (fGYN9ITMR3HBvH0EiPk())
		{
			goto IL_001e;
		}
		goto IL_003d;
		IL_006e:
		EventHandler eventHandler = default;
		EventHandler eventHandler2 = default;
		if ((object)eventHandler == eventHandler2)
		{
			num = 7;
			goto IL_003d;
		}
		goto IL_00ba;
		IL_00ba:
		eventHandler2 = eventHandler;
		num = 5;
		if (false)
		{
			return;
		}
		goto IL_003d;
		IL_003d:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto IL_006e;
			case 4:
			case 6:
				goto IL_006e;
			case 0:
				goto IL_007f;
			case 3:
				goto IL_009c;
			case 1:
			case 2:
				goto IL_00ba;
			case 7:
				return;
			}
			break;
			IL_007f:
			eventHandler = kB8ajNFnvi;
			_ = 0;
			num = ((!NI5RYnTOqj6Xj3enMNe()) ? 6 : 2);
		}
		goto IL_001e;
		IL_001e:
		EventHandler value2 = (EventHandler)LSSZRJTlAF2tWESdlnQ(eventHandler2, value);
		goto IL_009c;
		IL_009c:
		eventHandler = Interlocked.CompareExchange(ref kB8ajNFnvi, value2, eventHandler2);
		goto IL_006e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LiveAcqResultBuilder(ICogSocketAcq cogSocketAcq, CvsCogSocketSheet sheet, CvsSheetInfo sheetInfo, CvsProcessorConstants processorConstants, CvsPropSheet propSheet, ILiveModeService liveModeService, bool isRuntimeSupported)
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
			case 5:
			case 11:
				LiveModeService = liveModeService;
				num = 14;
				if (NI5RYnTOqj6Xj3enMNe())
				{
					break;
				}
				goto case 4;
			case 4:
				HymMapTeT7gT0bS8BGX();
				num = 13;
				break;
			case 10:
				TrTamOmD3w = new CvsCellCollection();
				BZXoRaTu4LK4qI7R5hA(this);
				num = 3;
				break;
			case 8:
				H7QaAYjF0E = sheet;
				goto case 12;
			default:
				num = 12;
				if (true)
				{
					break;
				}
				goto case 12;
			case 12:
				dpHatQ6UgC = sheetInfo;
				num = 7;
				if (NI5RYnTOqj6Xj3enMNe())
				{
					break;
				}
				goto case 6;
			case 6:
				H9uafad2LY = new object();
				num = 10;
				break;
			case 2:
			case 9:
				ifva3t3ceS = propSheet;
				FkmacPN6q7 = true;
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				MpNa5yL49O = isRuntimeSupported;
				goto case 5;
			case 0:
				ykKaXCYZqg = new CvsResultSet();
				num = 6;
				break;
			case 7:
				XHUaWIYMNq = processorConstants;
				_ = 1;
				if (fGYN9ITMR3HBvH0EiPk())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 2;
				break;
			case 3:
				ncIaoNHlZd = cogSocketAcq;
				num = 8;
				break;
			case 13:
				p5SakfAtOd = new object();
				num = 0;
				break;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool ouTaq2dJTt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ILiveModeService mRVaLSr4Jg = MRVaLSr4Jg;
		if (mRVaLSr4Jg == null)
		{
			return false;
		}
		return knyEB1TIvJuCJvHfyYl(mRVaLSr4Jg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ILiveAcqResultBuilder.SuspendUpdates()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ILiveAcqResultBuilder.ResumeUpdates()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IResultBuilder.Init()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NI5RYnTOqj6Xj3enMNe();
		int num = (fGYN9ITMR3HBvH0EiPk() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				FkmacPN6q7 = true;
				num = 1;
				continue;
			case 1:
				i4Ia75em7i = 0L;
				break;
			case 5:
				return;
			}
			ykKaXCYZqg = new CvsResultSet();
			num = 5;
			if (fGYN9ITMR3HBvH0EiPk())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IResultBuilder.Disconnect()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FkmacPN6q7 = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IResultBuilder.Stop()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IResultBuilder.MakeNewResult(bool updateExposedResults, bool runSheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iqYapAYR9o();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void IResultBuilder.WaitForResultBuildComplete()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void z5OabccHm7(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fGYN9ITMR3HBvH0EiPk())
		{
			num = 5;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				if (knyEB1TIvJuCJvHfyYl(LiveModeService))
				{
					goto default;
				}
				sSkPGLTnj9yeNwA0Xct(ncIaoNHlZd, new EventHandler(V7MaaBwZHV));
				num = 7;
				break;
			case 6:
				return;
			default:
				ncIaoNHlZd.ImageReady += V7MaaBwZHV;
				num = 6;
				break;
			case 0:
			case 5:
				gyganUWrYH = null;
				num = 1;
				break;
			case 1:
				if (MpNa5yL49O)
				{
					num = 4;
					break;
				}
				return;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void V7MaaBwZHV(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (Interlocked.Increment(ref C43a9BcGIV) == 1)
			{
				iqYapAYR9o();
			}
		}
		finally
		{
			Interlocked.Decrement(ref C43a9BcGIV);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateNewResultSet_003Ed__39))]
	private Task<CvsResultSet> gYxaO7cNHt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateNewResultSet_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsResultSet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iqYapAYR9o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003CCreateAndPublish_003Eb__40_0_003Ed))] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (NI5RYnTOqj6Xj3enMNe())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_009f;
				}
			}
			goto IL_0056;
			IL_00b3:
			_003C_003CCreateAndPublish_003Eb__40_0_003Ed stateMachine = default;
			return stateMachine._003C_003Et__builder.Task;
			IL_009f:
			stateMachine._003C_003E4__this = this;
			num = 5;
			if (true)
			{
				goto IL_0056;
			}
			goto IL_00b3;
			IL_0056:
			while (true)
			{
				switch (num)
				{
				case 2:
					stateMachine._003C_003Et__builder.Start(ref stateMachine);
					num = 6;
					continue;
				case 5:
					stateMachine._003C_003E1__state = -1;
					goto case 2;
				default:
					num = 2;
					continue;
				case 0:
				case 3:
					stateMachine._003C_003Et__builder = VHOVbgTbEKQG1o6sJVn();
					break;
				case 1:
				case 4:
					break;
				case 6:
					goto IL_00b3;
				}
				break;
			}
			goto IL_009f;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MaqahRZY8e(CvsResultSet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		object obj = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					_ = 0;
					switch ((!NI5RYnTOqj6Xj3enMNe()) ? 3 : 2)
					{
					case 0:
					case 2:
						if (ykKaXCYZqg == P_0)
						{
							return;
						}
						ykKaXCYZqg = P_0;
						break;
					default:
						return;
					case 3:
						return;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				yAIa4xpR3Z();
				num = 6;
				continue;
			case 0:
			case 2:
				lockTaken = false;
				goto default;
			case 1:
				return;
			case 5:
				break;
			case 6:
				return;
			}
			do
			{
				if (ouTaq2dJTt())
				{
					obj = p5SakfAtOd;
					_ = 0;
					if (!NI5RYnTOqj6Xj3enMNe())
					{
						num = 4;
						break;
					}
					num = 0;
					continue;
				}
				num = 1;
				break;
			}
			while (!NI5RYnTOqj6Xj3enMNe());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void yAIa4xpR3Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NI5RYnTOqj6Xj3enMNe();
		int num = ((!fGYN9ITMR3HBvH0EiPk()) ? 1 : 5);
		object h9uafad2LY = default;
		bool lockTaken = default;
		EventHandler eventHandler = default;
		while (true)
		{
			switch (num)
			{
			default:
				try
				{
					Monitor.Enter(h9uafad2LY, ref lockTaken);
					eventHandler = kB8ajNFnvi;
				}
				finally
				{
					if (lockTaken)
					{
						CPV2P3TaLXMajwtpguO(h9uafad2LY);
					}
				}
				if (eventHandler != null)
				{
					num = 2;
					break;
				}
				return;
			case 0:
			case 1:
				eventHandler = null;
				num = 6;
				break;
			case 6:
				h9uafad2LY = H9uafad2LY;
				num = 4;
				break;
			case 2:
				XUXktXTGwxwRGgxoIHl(eventHandler, this, EventArgs.Empty);
				num = 7;
				break;
			case 4:
				lockTaken = false;
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static OrderedDictionary psjalwnhsy(string P_0, CvsCogImage P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			return (OrderedDictionary)qyo73xTXjFNuChPQtkC(P_0, P_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CCreateAndPublish_003Eb__40_0_003Ed))]
	private Task tR3agqkUtB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (NI5RYnTOqj6Xj3enMNe())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_009f;
			}
		}
		goto IL_0056;
		IL_00b3:
		_003C_003CCreateAndPublish_003Eb__40_0_003Ed stateMachine = default;
		return stateMachine._003C_003Et__builder.Task;
		IL_009f:
		stateMachine._003C_003E4__this = this;
		num = 5;
		if (true)
		{
			goto IL_0056;
		}
		goto IL_00b3;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = VHOVbgTbEKQG1o6sJVn();
				break;
			case 1:
			case 4:
				break;
			case 6:
				goto IL_00b3;
			}
			break;
		}
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S4CPiPTQT8B78tH2gKm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NI5RYnTOqj6Xj3enMNe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fGYN9ITMR3HBvH0EiPk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LSSZRJTlAF2tWESdlnQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HymMapTeT7gT0bS8BGX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BZXoRaTu4LK4qI7R5hA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool knyEB1TIvJuCJvHfyYl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ILiveModeService)P_0).IsLiveAcquisition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nRVVVxTRSkJIVKqjmrm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILiveModeService)P_0).IsLiveAcquisitionChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CPV2P3TaLXMajwtpguO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sSkPGLTnj9yeNwA0Xct(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICogSocketAcq)P_0).ImageReady -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XUXktXTGwxwRGgxoIHl(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qyo73xTXjFNuChPQtkC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCogSheetResult.CreateCameraOutputs((string)P_0, (CvsCogImage)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder VHOVbgTbEKQG1o6sJVn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
