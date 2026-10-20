using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PixelCount.PixelCountUpdates;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PixelCount;

[Export(typeof(EzToolType))]
public class PixelCountToolType : CompositeRegionToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public PixelCountToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private PixelCountTool _003Ctool_003E5__2;

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
			if (!vnHvwGKj0G3XxfiwdKXj())
			{
				num = 5;
				if (!Q31C0nKjyscLV3aKO8fD())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_01f7;
			IL_0226:
			EzTool result = default;
			_003C_003Et__builder.SetResult(result);
			num = 7;
			goto IL_01f7;
			IL_01f7:
			PixelCountToolType pixelCountToolType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 2:
					pixelCountToolType = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new PixelCountTool((InspectStepViewModel)HFV1ZqKjFsJUD3BQJDKj(pixelCountToolType), isInitialized: true);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							Q31C0nKjyscLV3aKO8fD();
							if (!vnHvwGKj0G3XxfiwdKXj())
							{
								num3 = 4;
							}
							else
							{
								num3 = 8;
								if (1 == 0)
								{
									goto IL_01ae;
								}
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
							case 8:
								awaiter.GetResult();
								num3 = 10;
								if (Q31C0nKjyscLV3aKO8fD())
								{
									continue;
								}
								goto case 1;
							case 1:
								awaiter = ((Task)VMuEDJKjM8LKuHJF69ET(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (vnHvwGKj0G3XxfiwdKXj())
									{
									}
									continue;
								}
								goto case 7;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (!vnHvwGKj0G3XxfiwdKXj())
								{
									continue;
								}
								return;
							case 3:
								return;
							case 4:
							case 5:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (!vnHvwGKj0G3XxfiwdKXj())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							case 10:
								break;
							}
							break;
						}
						goto IL_01ae;
						IL_01ae:
						result = _003Ctool_003E5__2;
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
				default:
					num = 6;
					continue;
				case 3:
				case 4:
					goto IL_0226;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			_003Ctool_003E5__2 = null;
			goto IL_0226;
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
		internal static object HFV1ZqKjFsJUD3BQJDKj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VMuEDJKjM8LKuHJF69ET(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q31C0nKjyscLV3aKO8fD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vnHvwGKj0G3XxfiwdKXj()
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
	private struct _003COnBeginAddInternal_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PixelCountToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			PixelCountToolType pixelCountToolType = default;
			int num2 = default;
			CvsCogRectangle acquired2DImageBounds = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					pixelCountToolType = _003C_003E4__this;
					_ = 0;
					if (QknxeUKjYLPJygDGfpCF())
					{
						num = 1;
						if (QknxeUKjYLPJygDGfpCF())
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							acquired2DImageBounds = pixelCountToolType.GetAcquired2DImageBounds();
							QknxeUKjYLPJygDGfpCF();
							num3 = (NM46uEKjUm4y5nU7ybd3() ? 1 : 3);
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
							case 8:
								awaiter = E5qmCfKjHW7kWHYllPtO(pixelCountToolType.bJQbdjUu55());
								num3 = 7;
								continue;
							case 6:
								pixelCountToolType.CMlbDrl8qb = new CvsEditableDisplayGraphic[1] { pixelCountToolType.EditableComposite };
								num3 = 8;
								if (!NM46uEKjUm4y5nU7ybd3())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (QknxeUKjYLPJygDGfpCF())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 5;
							default:
								num3 = 5;
								if (QknxeUKjYLPJygDGfpCF())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 10:
								return;
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 0:
							case 3:
								pixelCountToolType.EditableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, acquired2DImageBounds);
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 11:
								break;
							}
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static TaskAwaiter E5qmCfKjHW7kWHYllPtO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QknxeUKjYLPJygDGfpCF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NM46uEKjUm4y5nU7ybd3()
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
	private struct _003CAddTool_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public PixelCountToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private PixelCountTool _003CnewTool_003E5__6;

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
			PixelCountToolType pixelCountToolType = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<double> awaiter6 = default;
			TaskAwaiter<object> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			CvsCellLocation cellLocation = default;
			Dictionary<string, object> dictionary = default;
			(double, double) minMax = default;
			CvsCellRange result3 = default;
			CvsCellCollection result2 = default;
			string text = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					pixelCountToolType = _003C_003E4__this;
					num = 0;
					break;
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
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
								goto IL_0ad2;
							}
							_003Csheet_003E5__2 = ((CvsInSight)z5vj3rKjQR4rnWgZES7E(pixelCountToolType.Inspect)).CogSocket.Sheet;
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(pixelCountToolType._pasteObject, (InspectStepViewModel)mpCZHcKjNT5bC8ruWtlx(pixelCountToolType), out _003CtoolName_003E5__5);
								num4 = 43;
								goto IL_028e;
							case 5:
								awaiter3 = _003C_003Eu__4;
								num4 = 4;
								goto IL_028e;
							case 8:
								awaiter = _003C_003Eu__3;
								num4 = 1;
								goto IL_028e;
							case 6:
								awaiter6 = _003C_003Eu__5;
								num4 = 49;
								goto IL_028e;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 23;
								goto IL_028e;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 59;
								goto IL_028e;
							case 1:
								awaiter5 = _003C_003Eu__2;
								num4 = 50;
								goto IL_028e;
							case 7:
								awaiter4 = _003C_003Eu__6;
								num4 = 16;
								if (!HMfgFfKjmMxDcgxSctHO())
								{
									goto IL_028e;
								}
								goto IL_063a;
							case 3:
								awaiter3 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num4 = 7;
								goto IL_028e;
							case 0:
								{
									awaiter2 = _003C_003Eu__1;
									num4 = 39;
									goto IL_028e;
								}
								IL_028e:
								while (true)
								{
									switch (num4)
									{
									case 67:
										num2 = (_003C_003E1__state = -1);
										goto IL_00cf;
									case 35:
										cellLocation = pixelCountToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, pixelCountToolType.t41bXQAnqf);
										num4 = 32;
										continue;
									case 26:
										return;
									case 17:
										num2 = (_003C_003E1__state = 3);
										num4 = 11;
										continue;
									case 41:
										dictionary = new Dictionary<string, object>();
										num4 = 33;
										if (0 == 0)
										{
											continue;
										}
										goto case 7;
									case 7:
										num2 = (_003C_003E1__state = -1);
										num4 = 15;
										continue;
									case 15:
										awaiter3.GetResult();
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49436));
										num4 = 58;
										continue;
									case 40:
										_003C_003Eu__6 = awaiter4;
										num4 = 44;
										continue;
									case 5:
										awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										num4 = 53;
										continue;
									case 47:
									case 62:
										_003C_003Eu__3 = awaiter;
										num4 = 19;
										continue;
									case 52:
										if (!awaiter3.IsCompleted)
										{
											num4 = 17;
											continue;
										}
										goto case 15;
									case 33:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)oMLpXHKj2xGlaMRZOfR9(6148)), minMax.Item1);
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)), minMax.Item2);
										num4 = 5;
										if (true)
										{
											continue;
										}
										goto case 37;
									case 37:
										if (!awaiter3.IsCompleted)
										{
											num4 = 18;
											continue;
										}
										goto IL_00cf;
									case 58:
										awaiter = UGpShSKjtm8K2M7UBgnn(EditableGraphicHelper.SendGraphicAsync((CvsInSight)z5vj3rKjQR4rnWgZES7E(mpCZHcKjNT5bC8ruWtlx(pixelCountToolType)), pixelCountToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, pixelCountToolType.L51bFNZrT6), pixelCountToolType.EditableComposite));
										goto case 46;
									default:
										num4 = 46;
										continue;
									case 22:
										break;
									case 20:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 8);
											f8ID0BKjx1Ht5LUAiWyg();
											if (!HMfgFfKjmMxDcgxSctHO())
											{
												num4 = 47;
												if (0 == 0)
												{
													continue;
												}
												goto case 34;
											}
											num4 = 2;
											if (true)
											{
												continue;
											}
											goto case 43;
										}
										goto IL_0749;
									case 34:
										if (!awaiter2.IsCompleted)
										{
											num4 = 14;
											continue;
										}
										break;
									case 19:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 50:
										_003C_003Eu__2 = default;
										num4 = 12;
										continue;
									case 10:
										goto end_IL_028e;
									case 31:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										return;
									case 4:
										_003C_003Eu__4 = default;
										num4 = 67;
										if (f8ID0BKjx1Ht5LUAiWyg())
										{
											continue;
										}
										return;
									case 42:
										return;
									case 44:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 38;
										continue;
									case 1:
										_003C_003Eu__3 = default;
										goto case 2;
									case 43:
										awaiter2 = pixelCountToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 34;
										if (!HMfgFfKjmMxDcgxSctHO())
										{
											continue;
										}
										goto case 45;
									case 45:
										num2 = (_003C_003E1__state = 4);
										num4 = 8;
										continue;
									case 55:
										_003C_003Eu__1 = awaiter2;
										num4 = 57;
										continue;
									case 48:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 42;
										continue;
									case 53:
										if (!awaiter4.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											num4 = 40;
											continue;
										}
										goto IL_0683;
									case 23:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0580;
									case 28:
									{
										double result4 = awaiter6.GetResult();
										CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(50070));
										minMax = PixelCountTool.GetMinMax(result4);
										num4 = 41;
										if (true)
										{
											continue;
										}
										goto case 21;
									}
									case 21:
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 37;
										continue;
									case 14:
										num2 = (_003C_003E1__state = 0);
										num4 = 55;
										continue;
									case 51:
										return;
									case 60:
										return;
									case 38:
										return;
									case 66:
										goto IL_063a;
									case 64:
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49576));
										num4 = 29;
										continue;
									case 16:
										_003C_003Eu__6 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0683;
									case 49:
										_003C_003Eu__5 = default;
										num4 = 54;
										continue;
									case 11:
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 12:
										num2 = (_003C_003E1__state = -1);
										num4 = 10;
										continue;
									case 0:
										_003CpasteRange_003E5__3 = result3;
										num4 = 64;
										continue;
									case 3:
										_003CnewTool_003E5__6 = new PixelCountTool((InspectStepViewModel)mpCZHcKjNT5bC8ruWtlx(pixelCountToolType), isInitialized: false);
										awaiter = UGpShSKjtm8K2M7UBgnn(ds7VBiKjzYM3xMaMy4sQ(_003CnewTool_003E5__6, result2, _003CpasteRange_003E5__3));
										num4 = 20;
										continue;
									case 2:
									case 65:
										num2 = (_003C_003E1__state = -1);
										goto IL_0749;
									case 46:
										if (!awaiter.IsCompleted)
										{
											num4 = 45;
											continue;
										}
										goto IL_0879;
									case 8:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 51;
										if (f8ID0BKjx1Ht5LUAiWyg())
										{
											continue;
										}
										goto case 36;
									case 36:
										_003C_003Eu__5 = awaiter6;
										num4 = 31;
										continue;
									case 24:
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49842));
										num4 = 3;
										continue;
									case 25:
										num2 = (_003C_003E1__state = -1);
										num4 = 22;
										continue;
									case 29:
										awaiter5 = _003Csheet_003E5__2.PutCellExpressionAsync(pixelCountToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, pixelCountToolType.pAVbuDfkoD), (string)UkIoDhKju2pImUKF86kC(pixelCountToolType.InputImageLinks[Siw7SyKj19k8Td4XriJS(pixelCountToolType)])).GetAwaiter();
										num4 = 66;
										continue;
									case 61:
										if (!awaiter.IsCompleted)
										{
											num4 = 56;
											continue;
										}
										goto IL_0580;
									case 39:
										_003C_003Eu__1 = default;
										num4 = 25;
										if (true)
										{
											continue;
										}
										goto case 59;
									case 59:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0879;
									case 9:
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 26;
										if (true)
										{
											continue;
										}
										goto case 54;
									case 54:
										num2 = (_003C_003E1__state = -1);
										num4 = 28;
										continue;
									case 18:
										num2 = (_003C_003E1__state = 5);
										num4 = 9;
										continue;
									case 27:
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49436));
										awaiter6 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(pixelCountToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, pixelCountToolType.Ratbom599O), (string)oMLpXHKj2xGlaMRZOfR9(1524)).GetAwaiter();
										if (!awaiter6.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 36;
											continue;
										}
										goto case 28;
									case 57:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 63;
										if (!HMfgFfKjmMxDcgxSctHO())
										{
											continue;
										}
										goto case 56;
									case 56:
										num2 = (_003C_003E1__state = 2);
										num4 = 48;
										continue;
									case 32:
										awaiter = UGpShSKjtm8K2M7UBgnn(InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)mpCZHcKjNT5bC8ruWtlx(pixelCountToolType), text, cellLocation));
										num4 = 61;
										if (true)
										{
											continue;
										}
										goto case 30;
									case 30:
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49608));
										text = (string)Fx3wD6Kjh4bDdvdZahnU(pixelCountToolType.FindInputFixtureCell(pixelCountToolType._pasteObject));
										num4 = 35;
										if (f8ID0BKjx1Ht5LUAiWyg())
										{
											continue;
										}
										goto case 6;
									case 6:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 60;
										if (true)
										{
											continue;
										}
										goto case 13;
									case 13:
										CvsTraceEzb.Info.TraceMessage((string)oMLpXHKj2xGlaMRZOfR9(49398));
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 52;
										if (true)
										{
											continue;
										}
										return;
									case 63:
										return;
									case 68:
										{
											result = _003CnewTool_003E5__6;
											goto end_IL_007a;
										}
										IL_0580:
										awaiter.GetResult();
										num4 = 13;
										continue;
										IL_0683:
										result2 = awaiter4.GetResult();
										num4 = 24;
										continue;
										IL_0749:
										awaiter.GetResult();
										CvsTraceEzb.Info.TraceMessage((string)oMLpXHKj2xGlaMRZOfR9(50108));
										num4 = 68;
										continue;
										IL_0879:
										awaiter.GetResult();
										bxtM0NKjc4epiV2CSeoe(CvsTraceEzb.Info, oMLpXHKj2xGlaMRZOfR9(49466));
										num4 = 21;
										if (true)
										{
											continue;
										}
										goto case 9;
										IL_00cf:
										awaiter3.GetResult();
										num4 = 27;
										if (0 == 0)
										{
											continue;
										}
										goto case 35;
									}
									result3 = awaiter2.GetResult();
									num4 = 0;
									continue;
									end_IL_028e:
									break;
								}
								goto IL_0446;
								IL_063a:
								if (!awaiter5.IsCompleted)
								{
									num4 = 6;
									goto IL_028e;
								}
								goto IL_0446;
								IL_0446:
								awaiter5.GetResult();
								num4 = 30;
								goto IL_028e;
								end_IL_007a:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0a6a;
						}
						goto end_IL_0041;
						IL_0a6a:
						if (num3 == 1)
						{
							awaiter = pixelCountToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0ad2;
						}
						goto IL_0afb;
						IL_0ad2:
						awaiter.GetResult();
						uCjjPvK6KooVQB89b4Hb(GqVnXuK6LZHDrfBMqnUM((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0afb;
						IL_0afb:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0041:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003Csheet_003E5__2 = null;
					num = 2;
					break;
				case 6:
					num2 = _003C_003E1__state;
					HMfgFfKjmMxDcgxSctHO();
					num = (f8ID0BKjx1Ht5LUAiWyg() ? 4 : 5);
					break;
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
		internal static object z5vj3rKjQR4rnWgZES7E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mpCZHcKjNT5bC8ruWtlx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oMLpXHKj2xGlaMRZOfR9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bxtM0NKjc4epiV2CSeoe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Siw7SyKj19k8Td4XriJS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UkIoDhKju2pImUKF86kC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fx3wD6Kjh4bDdvdZahnU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UGpShSKjtm8K2M7UBgnn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ds7VBiKjzYM3xMaMy4sQ(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GqVnXuK6LZHDrfBMqnUM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uCjjPvK6KooVQB89b4Hb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f8ID0BKjx1Ht5LUAiWyg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HMfgFfKjmMxDcgxSctHO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__29 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public PixelCountToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__29(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (DRLChDK6wMyg1VLNFEjj() ? 5 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					ENHnp9K6JBOlcm00pSli();
					goto case 1;
				case 1:
				case 5:
					OGTvIoK6aKTLBHOs2nZI(this);
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				default:
					num = 3;
					continue;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = HYVuJkK6eWTWElKUhDn1();
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
			int num = 15;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_00c8;
			IL_001a:
			_003C_003E2__current = (ISnippetUpdate)OsRhn5K6Ik9eHXydypOb(UK9cCjK6Dc6R4t802ZZm(19548), false);
			num = 16;
			goto IL_00c8;
			IL_00c8:
			PixelCountToolType pixelCountToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 17:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, pixelCountToolType.Localizer);
					num = 3;
					continue;
				case 11:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 7;
					continue;
				case 20:
					_003C_003E2__current = new ErrFreeRangeLimitMax(pixelCountToolType.Localizer);
					_003C_003E1__state = 5;
					goto case 4;
				case 6:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 0;
						continue;
					}
					goto case 19;
				case 16:
					_003C_003E1__state = 2;
					goto case 9;
				default:
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					goto case 14;
				case 14:
					return false;
				case 0:
					_003C_003E2__current = (ISnippetUpdate)OsRhn5K6Ik9eHXydypOb(CdQUGaROfy7He9T0foW.KbIzwHEDLa(19480), false);
					num = 5;
					if (JWChJbK65mKjiS9V0lr9())
					{
						continue;
					}
					goto case 10;
				case 10:
					_003ClatestVersion_003E5__3 = SnippetPasteBuffer.GetSnippetVersion(pixelCountToolType._pasteObject);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				case 9:
					return true;
				case 19:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 17;
						continue;
					}
					goto case 8;
				case 4:
				case 18:
					return true;
				case 8:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 20;
						continue;
					}
					goto case 21;
				case 12:
					return true;
				case 5:
					_003C_003E1__state = 1;
					num = 12;
					continue;
				case 1:
				case 13:
					pixelCountToolType = _003C_003E4__this;
					switch (num2)
					{
					case 0:
						_003C_003E1__state = -1;
						_003CcurrentVersion_003E5__2 = kj0QYAK6OuI4xcO8lAid(cells, range);
						num = 10;
						continue;
					case 2:
						_003C_003E1__state = -1;
						num = 11;
						continue;
					case 5:
						break;
					case 1:
						_003C_003E1__state = -1;
						num = 2;
						continue;
					default:
						num = 14;
						continue;
					case 3:
						_003C_003E1__state = -1;
						num = 19;
						continue;
					case 4:
						_003C_003E1__state = -1;
						num = 8;
						continue;
					}
					_003C_003E1__state = -1;
					num = 21;
					if (!DRLChDK6wMyg1VLNFEjj())
					{
						continue;
					}
					goto case 8;
				case 7:
					_003C_003E1__state = 3;
					return true;
				case 15:
					num2 = _003C_003E1__state;
					DRLChDK6wMyg1VLNFEjj();
					num = (JWChJbK65mKjiS9V0lr9() ? 13 : 4);
					continue;
				case 3:
					_003C_003E1__state = 4;
					return true;
				case 21:
					return false;
				}
				break;
			}
			goto IL_001a;
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
			_003CGetUpdates_003Ed__29 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__29(0)
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
		internal static void ENHnp9K6JBOlcm00pSli()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OGTvIoK6aKTLBHOs2nZI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HYVuJkK6eWTWElKUhDn1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWChJbK65mKjiS9V0lr9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DRLChDK6wMyg1VLNFEjj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int kj0QYAK6OuI4xcO8lAid(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OsRhn5K6Ik9eHXydypOb(object P_0, bool isSupportSnippet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellNameUpdate.MakeInternal((string)P_0, isSupportSnippet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UK9cCjK6Dc6R4t802ZZm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private static readonly Guid[] btHb6hSsHP;

	private readonly CvsCellLocation pAVbuDfkoD;

	private readonly CvsCellLocation L51bFNZrT6;

	private readonly CvsCellLocation t41bXQAnqf;

	private readonly CvsCellLocation Ratbom599O;

	private int Mq2bSIVi2G;

	private CvsEditableDisplayGraphic[] CMlbDrl8qb;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return btHb6hSsHP;
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
			return (string)FsQbvMkYjsNo57h53U1();
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
			return (string)xHxRcikUoD0nCQ1u4e0();
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

	public override string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PixelCountIcon;
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
			return XAMLGraphicKeys.Tools_PixelCountIcon;
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
				(string)DFgpyXkHK2PpWsw1h8f(),
				Resources.A6xJ0EZQJY()
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
			return Mq2bSIVi2G;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Mq2bSIVi2G, value, (string)bFPfB4kMFaqME6N2Lrc(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PixelCountToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		do
		{
			IL_0046:
			switch (num)
			{
			case 5:
				pAVbuDfkoD = _pasteObject.GetCellOffset((string)bFPfB4kMFaqME6N2Lrc(4928));
				break;
			default:
				num = 4;
				goto IL_0046;
			case 2:
			case 8:
				base._002Ector();
				num = 0;
				goto IL_0046;
			case 7:
				ClfRwRk04El8155vtKo();
				dCedOIkToNLxNb3i6PZ();
				if (!XXWPhWkyZQIBFcVlXcP())
				{
					num = 10;
					goto IL_0046;
				}
				num = 8;
				if (0 == 0)
				{
					goto IL_0046;
				}
				goto case 0;
			case 6:
				Ratbom599O = _pasteObject.GetCellOffset((string)bFPfB4kMFaqME6N2Lrc(2706));
				num = 3;
				goto IL_0046;
			case 9:
				t41bXQAnqf = _pasteObject.GetCellOffset((string)bFPfB4kMFaqME6N2Lrc(6522));
				num = 6;
				if (true)
				{
					goto IL_0046;
				}
				goto case 3;
			case 3:
				AddSnippet(_pasteObject);
				num = 11;
				if (true)
				{
					goto IL_0046;
				}
				goto case 1;
			case 1:
			case 10:
				Mq2bSIVi2G = 110;
				goto case 2;
			case 0:
				_pasteObject = (PasteBuffer)DFKJkQkFZ3mPnc03KnE(Snippets.PixelCount);
				num = 5;
				goto IL_0046;
			case 4:
				break;
			case 11:
				return;
			}
			L51bFNZrT6 = _pasteObject.GetCellOffset((string)bFPfB4kMFaqME6N2Lrc(5684));
			num = 9;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__24))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__25))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XXWPhWkyZQIBFcVlXcP();
		int num = ((!dCedOIkToNLxNb3i6PZ()) ? 5 : 2);
		_003COnBeginAddInternal_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = ES3mF6kxxANXgQNOqr8();
				num = 1;
				if (dCedOIkToNLxNb3i6PZ())
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
		return CMlbDrl8qb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__28))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__29))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__29(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PixelCountToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		btHb6hSsHP = new Guid[1]
		{
			new Guid((string)bFPfB4kMFaqME6N2Lrc(19590))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task bJQbdjUu55()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ClfRwRk04El8155vtKo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DFKJkQkFZ3mPnc03KnE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bFPfB4kMFaqME6N2Lrc(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dCedOIkToNLxNb3i6PZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XXWPhWkyZQIBFcVlXcP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FsQbvMkYjsNo57h53U1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PixelCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xHxRcikUoD0nCQ1u4e0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.spCJRPBLDy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DFgpyXkHK2PpWsw1h8f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ES3mF6kxxANXgQNOqr8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
