using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CountEdges;

[Export(typeof(EzToolType))]
public class CountEdgesToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Guid guid;

		public CountEdgesToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private CountEdgesTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (mTSQoGKxN4Y21xQpgm7i())
			{
				num = 2;
				if (!mTSQoGKxN4Y21xQpgm7i())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01fd;
			IL_002a:
			EzTool result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01fd;
			IL_01fd:
			int num2 = default;
			TaskAwaiter awaiter = default;
			CountEdgesToolType countEdgesToolType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (guid == TMIjB0qJWR)
							{
								_ = 1;
								if (!bALAi3Kx2L1LVs5Py97T())
								{
									num3 = 11;
									if (1 == 0)
									{
										goto IL_0073;
									}
								}
								else
								{
									num3 = 9;
								}
								goto IL_014a;
							}
							throw new ArgumentException();
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_0073;
						IL_014a:
						while (true)
						{
							switch (num3)
							{
							case 7:
							case 9:
								break;
							case 1:
								awaiter.GetResult();
								num3 = 3;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 1;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 8:
								return;
							case 0:
							case 11:
								_003Ctool_003E5__2 = new CountEdgesTool((InspectStepViewModel)g8jjhvKxcV71pVokW1W0(countEdgesToolType), isInitialized: true);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								result = _003Ctool_003E5__2;
								num3 = 12;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								if (mTSQoGKxN4Y21xQpgm7i())
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter = U5U7JgKxut8Zr0sV7Us3(vlZ8jvKx1i0SCdQsfUu2(_003Ctool_003E5__2, cells, cellRange));
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_014a;
							case 12:
								goto end_IL_014a;
							}
							goto IL_0073;
							continue;
							end_IL_014a:
							break;
						}
						goto end_IL_0040;
						IL_0073:
						num2 = (_003C_003E1__state = -1);
						num3 = 1;
						goto IL_014a;
						end_IL_0040:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					if (mTSQoGKxN4Y21xQpgm7i())
					{
						continue;
					}
					goto case 1;
				case 1:
					countEdgesToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object g8jjhvKxcV71pVokW1W0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vlZ8jvKx1i0SCdQsfUu2(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter U5U7JgKxut8Zr0sV7Us3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mTSQoGKxN4Y21xQpgm7i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bALAi3Kx2L1LVs5Py97T()
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
	private struct _003COnBeginAddInternal_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountEdgesToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CvsCellLocation cell = default;
			CountEdgesToolType countEdgesToolType = default;
			TaskAwaiter awaiter = default;
			CvsCell imageCell = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cell = X6gaSOKmLW4W4vHtCuHr(mEEmdQKxzxO8t948Aeng(countEdgesToolType.CurrentInputImageLink));
							num3 = 13;
							goto IL_01df;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_0080;
						IL_0080:
						num2 = (_003C_003E1__state = -1);
						num3 = 14;
						goto IL_01df;
						IL_01df:
						while (true)
						{
							switch (num3)
							{
							case 1:
								C44vgqKmeY91oLatJMp8(countEdgesToolType.EditableRegion, false);
								num3 = 7;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (royhWOKxhHswB73Syrys())
									{
										continue;
									}
									break;
								}
								goto case 14;
							case 4:
							case 11:
								break;
							case 10:
								countEdgesToolType.EditableRegion = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 50.0, 0.0, 0.0, imageCell);
								num3 = 8;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 5:
								return;
							case 0:
								awaiter = pP3UtYKmOVopGs3trdaq(countEdgesToolType.qFPjG8Ztpn());
								num3 = 6;
								if (!vuwxHcKxtmnZyapXS1iR())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 9:
								UABwLcKmawgfABus3ep1(countEdgesToolType.EditableRegion, true);
								num3 = 1;
								continue;
							case 13:
								imageCell = ((CvsCellCollection)H52CJOKmw5qTchZ1MNvN(XQk1RmKm5uTcjVYpv7Vf(nIb00LKmKLGwH1wJeIHe(countEdgesToolType))))[cell];
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								WUFF6QKmJxOQqyOfIWiF(countEdgesToolType.EditableRegion, false);
								_ = 1;
								num3 = ((!vuwxHcKxtmnZyapXS1iR()) ? 9 : 4);
								continue;
							case 7:
								countEdgesToolType.MH3j8yTHDc = new CvsEditableDisplayGraphic[1] { countEdgesToolType.EditableRegion };
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 14:
								awaiter.GetResult();
								goto end_IL_01df;
							}
							goto IL_0080;
							continue;
							end_IL_01df:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 1:
				case 3:
					countEdgesToolType = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					royhWOKxhHswB73Syrys();
					if (vuwxHcKxtmnZyapXS1iR())
					{
						num = 5;
						break;
					}
					num = 3;
					if (vuwxHcKxtmnZyapXS1iR())
					{
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
		internal static object mEEmdQKxzxO8t948Aeng(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation X6gaSOKmLW4W4vHtCuHr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.Parse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nIb00LKmKLGwH1wJeIHe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XQk1RmKm5uTcjVYpv7Vf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H52CJOKmw5qTchZ1MNvN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WUFF6QKmJxOQqyOfIWiF(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UABwLcKmawgfABus3ep1(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowXArrow = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void C44vgqKmeY91oLatJMp8(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowYArrow = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pP3UtYKmOVopGs3trdaq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool royhWOKxhHswB73Syrys()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vuwxHcKxtmnZyapXS1iR()
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
	private struct _003CAddTool_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public CountEdgesToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private CountEdgesTool _003CnewTool_003E5__6;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<double> _003C_003Eu__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			TaskAwaiter awaiter = default;
			CountEdgesToolType countEdgesToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCellCollection> awaiter6 = default;
			TaskAwaiter<CvsCellRange> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter<double> awaiter2 = default;
			Dictionary<string, object> dictionary = default;
			double result4 = default;
			CvsCellCollection result2 = default;
			string text = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result3 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					gpFZtyKmIhCjM3mUPQN2();
					num = (TFnSg2KmDA0eCox2mldw() ? 2 : 5);
					continue;
				case 0:
					try
					{
						int num3;
						if ((uint)num2 > 8u)
						{
							if (num2 == 9)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0a83;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)gFl06xKmfGUs39m6a7E0(e3x3JCKmVpXF4Q1iKHU8(Lp4f1TKmngT00bCkj3oI(AML0iKKmioZ8vPx1dbbe(countEdgesToolType))));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(countEdgesToolType.kKgjtdfEqj, countEdgesToolType.Inspect, out _003CtoolName_003E5__5);
								num4 = 6;
								goto IL_0427;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 13;
								goto IL_0427;
							case 7:
								awaiter6 = _003C_003Eu__6;
								num4 = 16;
								goto IL_0427;
							case 0:
								awaiter5 = _003C_003Eu__1;
								num4 = 28;
								goto IL_0427;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 5;
								goto IL_0427;
							case 3:
								awaiter4 = _003C_003Eu__4;
								num4 = 27;
								goto IL_0427;
							case 5:
								awaiter4 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num4 = 39;
								goto IL_0427;
							case 8:
								awaiter = _003C_003Eu__3;
								num4 = 7;
								goto IL_0427;
							case 1:
								awaiter3 = _003C_003Eu__2;
								num4 = 10;
								if (gpFZtyKmIhCjM3mUPQN2())
								{
									goto IL_0427;
								}
								goto IL_0899;
							case 6:
								{
									awaiter2 = _003C_003Eu__5;
									num4 = 35;
									if (0 == 0)
									{
										goto IL_0427;
									}
									goto IL_09cd;
								}
								IL_0427:
								while (true)
								{
									switch (num4)
									{
									case 27:
										_003C_003Eu__4 = default;
										num4 = 36;
										continue;
									case 60:
										return;
									case 21:
										num2 = (_003C_003E1__state = 8);
										_003C_003Eu__3 = awaiter;
										num4 = 42;
										continue;
									case 34:
										qCw6bKKmdh9g3YyVfkwU(CvsTraceEzb.Info, ijPHHaKmsWQbaMiyZBvJ(49466));
										num4 = 48;
										continue;
									case 20:
										awaiter.GetResult();
										num4 = 14;
										continue;
									case 63:
										_003C_003Eu__4 = awaiter4;
										num4 = 53;
										continue;
									case 1:
										break;
									case 58:
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__5 = awaiter2;
										num4 = 3;
										continue;
									case 16:
										_003C_003Eu__6 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 17;
										continue;
									case 31:
										awaiter.GetResult();
										awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 67;
										continue;
									case 22:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 0;
										continue;
									case 10:
										_003C_003Eu__2 = default;
										num4 = 51;
										continue;
									case 29:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)ijPHHaKmsWQbaMiyZBvJ(6148)), (int)result4);
										num4 = 47;
										continue;
									case 18:
										return;
									case 17:
										result2 = awaiter6.GetResult();
										num4 = 46;
										continue;
									case 40:
										_003C_003Eu__2 = awaiter3;
										num4 = 23;
										continue;
									case 37:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 60;
										continue;
									case 67:
										if (!awaiter4.IsCompleted)
										{
											num4 = 8;
											continue;
										}
										goto IL_0916;
									case 55:
										_003C_003Eu__3 = awaiter;
										num4 = 37;
										continue;
									case 48:
										awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 12;
										continue;
									case 46:
										qCw6bKKmdh9g3YyVfkwU(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49842));
										num4 = 24;
										continue;
									case 44:
										CvsTraceEzb.Info.TraceMessage((string)ijPHHaKmsWQbaMiyZBvJ(49436));
										awaiter = ((Task)hUBd9IKmZ0OfRisTuOta(Lp4f1TKmngT00bCkj3oI(AML0iKKmioZ8vPx1dbbe(countEdgesToolType)), countEdgesToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countEdgesToolType.NOtj0OCWwg), countEdgesToolType.EditableRegion)).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num4 = 11;
											continue;
										}
										goto IL_08fa;
									case 26:
										num2 = (_003C_003E1__state = -1);
										num4 = 20;
										if (true)
										{
											continue;
										}
										goto case 50;
									case 50:
										awaiter = pliyx5KmPj5EGR1pJ9g3(jl2x66KmryoaSvJejMGT(AML0iKKmioZ8vPx1dbbe(countEdgesToolType), text, cellLocation));
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											num4 = 55;
											continue;
										}
										goto case 31;
									case 7:
										_003C_003Eu__3 = default;
										num4 = 26;
										if (!TFnSg2KmDA0eCox2mldw())
										{
											continue;
										}
										goto case 65;
									case 65:
										num2 = (_003C_003E1__state = 1);
										num4 = 40;
										continue;
									case 66:
										awaiter3 = _003Csheet_003E5__2.PutCellExpressionAsync(countEdgesToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countEdgesToolType.fUdjYLuWsx), (string)tK6wmaKmg4EhCrvn4k9P(countEdgesToolType.InputImageLinks[P2UNFAKmlRZ6LoOsurys(countEdgesToolType)])).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num4 = 65;
											continue;
										}
										goto IL_0931;
									case 5:
										_003C_003Eu__3 = default;
										goto case 19;
									default:
										num4 = 19;
										if (gpFZtyKmIhCjM3mUPQN2())
										{
											continue;
										}
										goto case 59;
									case 59:
										cellLocation = countEdgesToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countEdgesToolType.KM2jVgkWbi);
										num4 = 50;
										continue;
									case 52:
										if (!awaiter5.IsCompleted)
										{
											num4 = 30;
											continue;
										}
										goto case 43;
									case 47:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)), (int)result4);
										num4 = 41;
										continue;
									case 28:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 43;
										continue;
									case 9:
										return;
									case 0:
										return;
									case 33:
										qCw6bKKmdh9g3YyVfkwU(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49576));
										num4 = 66;
										if (true)
										{
											continue;
										}
										goto case 39;
									case 39:
										num2 = (_003C_003E1__state = -1);
										num4 = 64;
										continue;
									case 54:
										_003CpasteRange_003E5__3 = result3;
										num4 = 33;
										if (0 == 0)
										{
											continue;
										}
										goto case 49;
									case 49:
									case 62:
										dictionary = new Dictionary<string, object>();
										num4 = 29;
										continue;
									case 61:
										num2 = (_003C_003E1__state = 5);
										num4 = 63;
										continue;
									case 64:
										goto IL_0670;
									case 8:
										goto IL_0688;
									case 2:
										if (!awaiter6.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											_003C_003Eu__6 = awaiter6;
											num4 = 45;
											continue;
										}
										goto case 17;
									case 13:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 31;
										continue;
									case 32:
										_003C_003Eu__1 = awaiter5;
										num4 = 57;
										if (gpFZtyKmIhCjM3mUPQN2())
										{
											continue;
										}
										goto case 45;
									case 45:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										num4 = 18;
										continue;
									case 25:
									case 56:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 24:
										_003CnewTool_003E5__6 = new CountEdgesTool((InspectStepViewModel)AML0iKKmioZ8vPx1dbbe(countEdgesToolType), isInitialized: false);
										awaiter = _003CnewTool_003E5__6.SetCellRangeAsync(result2, _003CpasteRange_003E5__3).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num4 = 21;
											continue;
										}
										goto case 20;
									case 11:
										num2 = (_003C_003E1__state = 4);
										num4 = 22;
										continue;
									case 53:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 43:
										result3 = awaiter5.GetResult();
										num4 = 54;
										continue;
									case 4:
										awaiter2 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(countEdgesToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countEdgesToolType.Mt5jL3EC8s), (string)ijPHHaKmsWQbaMiyZBvJ(1524)).GetAwaiter();
										num4 = 38;
										continue;
									case 30:
										num2 = (_003C_003E1__state = 0);
										num4 = 32;
										continue;
									case 35:
										_003C_003Eu__5 = default;
										num4 = 1;
										continue;
									case 42:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 23:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 38:
										goto IL_0899;
									case 14:
										qCw6bKKmdh9g3YyVfkwU(CvsTraceEzb.Info, ijPHHaKmsWQbaMiyZBvJ(50536));
										num4 = 68;
										continue;
									case 41:
										awaiter6 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										num4 = 2;
										if (gpFZtyKmIhCjM3mUPQN2())
										{
											continue;
										}
										goto case 19;
									case 19:
										num2 = (_003C_003E1__state = -1);
										goto IL_08fa;
									case 36:
										num2 = (_003C_003E1__state = -1);
										goto IL_0916;
									case 51:
										num2 = (_003C_003E1__state = -1);
										goto IL_0931;
									case 57:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 9;
										continue;
									case 15:
										CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(50496));
										goto case 49;
									case 3:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									case 12:
										goto IL_09cd;
									case 6:
										awaiter5 = countEdgesToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 52;
										continue;
									case 68:
										{
											result = _003CnewTool_003E5__6;
											goto end_IL_0072;
										}
										IL_0931:
										awaiter3.GetResult();
										CvsTraceEzb.Info.TraceMessage((string)ijPHHaKmsWQbaMiyZBvJ(49608));
										text = (string)HQofFqKmv5fAm4Jd4pWE(countEdgesToolType.FindInputFixtureCell(countEdgesToolType.kKgjtdfEqj));
										num4 = 59;
										continue;
										IL_08fa:
										awaiter.GetResult();
										num4 = 34;
										if (0 == 0)
										{
											continue;
										}
										goto case 36;
										IL_0916:
										awaiter4.GetResult();
										num4 = 44;
										continue;
									}
									break;
								}
								num2 = (_003C_003E1__state = -1);
								goto IL_0150;
								IL_09cd:
								if (!awaiter4.IsCompleted)
								{
									num4 = 61;
									goto IL_0427;
								}
								goto IL_0670;
								IL_0688:
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__4 = awaiter4;
								_ = 0;
								num4 = ((!gpFZtyKmIhCjM3mUPQN2()) ? 62 : 56);
								goto IL_0427;
								IL_0899:
								if (awaiter2.IsCompleted)
								{
									goto IL_0150;
								}
								num4 = 58;
								goto IL_0427;
								IL_0150:
								result4 = awaiter2.GetResult();
								num4 = 15;
								goto IL_0427;
								IL_0670:
								awaiter4.GetResult();
								num4 = 4;
								if (gpFZtyKmIhCjM3mUPQN2())
								{
									goto IL_0427;
								}
								goto IL_0688;
								end_IL_0072:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0a1b;
						}
						goto end_IL_0039;
						IL_0a1b:
						if (num3 == 1)
						{
							awaiter = pliyx5KmPj5EGR1pJ9g3(countEdgesToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0a83;
						}
						goto IL_0aac;
						IL_0a83:
						awaiter.GetResult();
						((ExceptionDispatchInfo)GTVkrrKmBUuqqeIGkxni((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3)).Throw();
						goto IL_0aac;
						IL_0aac:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0039:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
				case 5:
					countEdgesToolType = _003C_003E4__this;
					num = 0;
					continue;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						continue;
					}
					break;
				case 7:
					return;
				}
				_003Csheet_003E5__2 = null;
				num = 4;
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
		internal static object AML0iKKmioZ8vPx1dbbe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Lp4f1TKmngT00bCkj3oI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object e3x3JCKmVpXF4Q1iKHU8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gFl06xKmfGUs39m6a7E0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qCw6bKKmdh9g3YyVfkwU(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int P2UNFAKmlRZ6LoOsurys(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tK6wmaKmg4EhCrvn4k9P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ijPHHaKmsWQbaMiyZBvJ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HQofFqKmv5fAm4Jd4pWE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jl2x66KmryoaSvJejMGT(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pliyx5KmPj5EGR1pJ9g3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hUBd9IKmZ0OfRisTuOta(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GTVkrrKmBUuqqeIGkxni(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gpFZtyKmIhCjM3mUPQN2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TFnSg2KmDA0eCox2mldw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__49 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public CountEdgesToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__49(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					HmQZrdKmSEkfrqc6CZFY(this);
					goto case 2;
				case 3:
					yPYTV8Kmoxl0lBbqPGs0();
					_ = 1;
					num = ((!siM9wGKmGwBuWM7htfSn()) ? 5 : 4);
					break;
				case 0:
					_003C_003El__initialThreadId = KpcLo2KmkcY7xjOQtlhL();
					num = 6;
					break;
				case 2:
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 0;
				default:
					num = 0;
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
			int num = 8;
			int num2 = default;
			CountEdgesToolType countEdgesToolType = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					num2 = _003C_003E1__state;
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 12;
				case 12:
					countEdgesToolType = _003C_003E4__this;
					num = 4;
					if (siM9wGKmGwBuWM7htfSn())
					{
					}
					continue;
				case 10:
					_003C_003E1__state = 2;
					num = 7;
					continue;
				case 0:
					return true;
				case 15:
				case 17:
					_003C_003E1__state = 4;
					return true;
				case 3:
					_003C_003E2__current = new CellNameUpdate((string)BdiUesKmEFeJhF1Zvxbc(50650), oldNameIsInternal: true, (string)BdiUesKmEFeJhF1Zvxbc(36102), newNameIsInternal: true, isSupportSnippet: false);
					num = 10;
					if (0 == 0)
					{
						continue;
					}
					goto case 13;
				case 13:
					_003CcurrentVersion_003E5__2 = hq2uSpKm8n5mJlhgiNip(cells, range);
					_003ClatestVersion_003E5__3 = nT6CRSKmq5F2qWJ4GWVN(countEdgesToolType.kKgjtdfEqj);
					num = 1;
					continue;
				case 4:
					switch (num2)
					{
					case 3:
						break;
					case 4:
						goto IL_0073;
					default:
						goto IL_00fe;
					case 1:
						goto IL_0110;
					case 2:
						goto IL_01b4;
					case 0:
						goto IL_0268;
					}
					_003C_003E1__state = -1;
					num = 9;
					continue;
				case 5:
					return true;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				case 9:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 14;
						continue;
					}
					break;
				case 16:
					_003C_003E1__state = 1;
					num = 5;
					continue;
				case 7:
					return true;
				case 1:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						_ = 0;
						num = ((!JUJ5DNKmbyTtqwax3lPO()) ? 17 : 11);
						continue;
					}
					goto case 9;
				case 14:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, countEdgesToolType.Localizer);
					goto case 15;
				case 6:
				case 11:
					_003C_003E2__current = new CellNameUpdate(CdQUGaROfy7He9T0foW.KbIzwHEDLa(50586), oldNameIsInternal: true, (string)BdiUesKmEFeJhF1Zvxbc(42962), newNameIsInternal: true, isSupportSnippet: false);
					num = 16;
					continue;
				case 2:
					return false;
				case 18:
					break;
					IL_0268:
					_003C_003E1__state = -1;
					num = 13;
					continue;
					IL_01b4:
					_003C_003E1__state = -1;
					_003C_003E2__current = new CellNameUpdate((string)BdiUesKmEFeJhF1Zvxbc(50722), oldNameIsInternal: true, (string)BdiUesKmEFeJhF1Zvxbc(36142), newNameIsInternal: true, isSupportSnippet: false);
					_003C_003E1__state = 3;
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 1;
					IL_0110:
					_003C_003E1__state = -1;
					goto case 3;
					IL_00fe:
					num = 2;
					if (JUJ5DNKmbyTtqwax3lPO())
					{
						continue;
					}
					goto case 5;
					IL_0073:
					_003C_003E1__state = -1;
					num = 18;
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
			_003CGetUpdates_003Ed__49 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__49(0)
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
		internal static void yPYTV8Kmoxl0lBbqPGs0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HmQZrdKmSEkfrqc6CZFY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int KpcLo2KmkcY7xjOQtlhL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JUJ5DNKmbyTtqwax3lPO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool siM9wGKmGwBuWM7htfSn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int hq2uSpKm8n5mJlhgiNip(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int nT6CRSKmq5F2qWJ4GWVN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BdiUesKmEFeJhF1Zvxbc(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private static readonly Guid TMIjB0qJWR;

	private static readonly Guid[] ivGjZOCvnG;

	private readonly Dispatcher r7sjn51ZmJ;

	private readonly PasteBuffer kKgjtdfEqj;

	private readonly CvsCellLocation fUdjYLuWsx;

	private readonly CvsCellLocation NOtj0OCWwg;

	private readonly CvsCellLocation KM2jVgkWbi;

	private readonly CvsCellLocation Mt5jL3EC8s;

	private int rtbjJeasZP;

	[CompilerGenerated]
	private readonly Func<CvsCogShape, bool> OO7j9ScQmF;

	private int QEGjrwsYqt;

	private int Dsljhb2qBe;

	private CvsEditableDisplayGraphic[] MH3j8yTHDc;

	[CompilerGenerated]
	private CvsDisplayableRegion QpxjmaLZZ3;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ivGjZOCvnG;
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
			return (string)VJSpGyRBjZ8ULk96kGZ();
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
			return (string)FZJ2ZyRbKaQ9EtUKnui();
		}
	}

	public override bool IsReleased
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

	public string Directions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)fuLF05RGJH4A7l0Rwg8();
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
			return XAMLGraphicKeys.Tools_CountEdgesIcon;
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
			return XAMLGraphicKeys.Tools_CountEdgesIcon;
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
			return new string[2]
			{
				(string)oGhqaTRoPfWMYVvNMEN(),
				(string)pfJKfqRSWs9cViRyS42()
			};
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
			return rtbjJeasZP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref rtbjJeasZP, value, (string)Nk8pQ3RZtxgFlIBSsp9(3256));
		}
	}

	public override Func<CvsCogShape, bool> GraphicsLayerFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OO7j9ScQmF;
		}
	}

	public int RangeMin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QEGjrwsYqt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref QEGjrwsYqt, value, (string)Nk8pQ3RZtxgFlIBSsp9(27124));
		}
	}

	public int RangeMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dsljhb2qBe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Dsljhb2qBe, value, (string)Nk8pQ3RZtxgFlIBSsp9(27144));
		}
	}

	protected CvsDisplayableRegion EditableRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QpxjmaLZZ3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QpxjmaLZZ3 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CountEdgesToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 3:
				Mt5jL3EC8s = kKgjtdfEqj.GetCellOffset((string)Nk8pQ3RZtxgFlIBSsp9(26986));
				num = 1;
				break;
			default:
				NOtj0OCWwg = kKgjtdfEqj.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684));
				num = 10;
				if (XcWSJ4Rvx8Ti18KY5oQ())
				{
					break;
				}
				goto case 7;
			case 7:
				base._002Ector();
				r7sjn51ZmJ = (Dispatcher)GAAVJ0RPBVKVnTIewoC();
				num = 9;
				break;
			case 9:
				kKgjtdfEqj = PasteBuffer.FromBytes(Snippets.CountEdges);
				_ = 0;
				num = ((!XcWSJ4Rvx8Ti18KY5oQ()) ? 2 : 6);
				break;
			case 8:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 0;
				if (Yhi3SrRr8WgxHdhQbda())
				{
				}
				break;
			case 0:
				rtbjJeasZP = 310;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				AddSnippet(kKgjtdfEqj);
				num = 11;
				break;
			case 10:
				KM2jVgkWbi = kKgjtdfEqj.GetCellOffset((string)Nk8pQ3RZtxgFlIBSsp9(6522));
				num = 3;
				break;
			case 4:
			case 6:
				fUdjYLuWsx = kKgjtdfEqj.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				goto default;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__40))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.guid = guid;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__41))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnBeginAddInternal_003Ed__41 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				num = (Yhi3SrRr8WgxHdhQbda() ? 4 : 2);
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (XcWSJ4Rvx8Ti18KY5oQ())
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MH3j8yTHDc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__48))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__48 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__49))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__49(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CountEdgesToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (Yhi3SrRr8WgxHdhQbda() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				ivGjZOCvnG = new Guid[1] { TMIjB0qJWR };
				num = 5;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				E8KFo3RkJXSi9GwwaRr();
				num = 4;
				if (XcWSJ4Rvx8Ti18KY5oQ())
				{
					break;
				}
				goto case 4;
			case 4:
				TMIjB0qJWR = new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27164));
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task qFPjG8Ztpn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GAAVJ0RPBVKVnTIewoC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Dispatcher.CurrentDispatcher;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nk8pQ3RZtxgFlIBSsp9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XcWSJ4Rvx8Ti18KY5oQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yhi3SrRr8WgxHdhQbda()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VJSpGyRBjZ8ULk96kGZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.wn3ZZZ6Z2k();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FZJ2ZyRbKaQ9EtUKnui()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tt6ZtcS0eD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fuLF05RGJH4A7l0Rwg8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.kEBZ0ygEhF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oGhqaTRoPfWMYVvNMEN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pfJKfqRSWs9cViRyS42()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qm5ZLplBc4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E8KFo3RkJXSi9GwwaRr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
