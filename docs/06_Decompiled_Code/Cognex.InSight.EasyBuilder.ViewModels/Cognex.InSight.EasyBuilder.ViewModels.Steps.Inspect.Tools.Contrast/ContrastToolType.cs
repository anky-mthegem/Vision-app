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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Contrast;

[Export(typeof(EzToolType))]
public class ContrastToolType : CompositeRegionToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ContrastToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ContrastTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			scYt6lKQE1MBWtCe2jbE();
			int num = ((!vKFQ9SKQqjfKWseIhop2()) ? 5 : 6);
			EzTool result = default;
			int num2 = default;
			ContrastToolType contrastToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (vKFQ9SKQqjfKWseIhop2())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ContrastTool(contrastToolType.Inspect, isInitialized: true);
							num3 = 5;
							if (false)
							{
								goto IL_0079;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						goto IL_00ae;
						IL_00ae:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 6:
								goto IL_0095;
							default:
								num3 = 3;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto IL_00f2;
							case 1:
							case 9:
								if (awaiter.IsCompleted)
								{
									goto IL_00f2;
								}
								goto case 2;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 3:
								goto IL_0132;
							case 0:
								return;
							case 5:
								goto IL_0160;
							case 10:
								{
									result = _003Ctool_003E5__2;
									goto end_IL_0055;
								}
								IL_00f2:
								awaiter.GetResult();
								num3 = 10;
								continue;
							}
							break;
							IL_0160:
							awaiter = ((Task)gcKIVpKQp8CcdlTOkYae(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
							scYt6lKQE1MBWtCe2jbE();
							num3 = (vKFQ9SKQqjfKWseIhop2() ? 9 : 8);
						}
						goto IL_0079;
						IL_0132:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 0;
						goto IL_00ae;
						IL_0079:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (!vKFQ9SKQqjfKWseIhop2())
						{
							goto IL_0095;
						}
						goto IL_00ae;
						IL_0095:
						_003C_003Eu__1 = awaiter;
						goto IL_0132;
						end_IL_0055:;
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
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					contrastToolType = _003C_003E4__this;
					goto case 2;
				case 1:
					break;
				case 7:
					return;
				}
				_003Ctool_003E5__2 = null;
				num = 4;
				if (scYt6lKQE1MBWtCe2jbE())
				{
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
		internal static object gcKIVpKQp8CcdlTOkYae(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vKFQ9SKQqjfKWseIhop2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool scYt6lKQE1MBWtCe2jbE()
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

		public ContrastToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!EMTBD1KQXETVxyxjq3HF())
			{
				goto IL_001e;
			}
			goto IL_0221;
			IL_001e:
			int num2 = _003C_003E1__state;
			EMTBD1KQXETVxyxjq3HF();
			if (!HOO81kKQ9kZpnUEbbOke())
			{
				num = 3;
				if (HOO81kKQ9kZpnUEbbOke())
				{
				}
			}
			else
			{
				num = 0;
				if (HOO81kKQ9kZpnUEbbOke())
				{
					goto IL_0269;
				}
			}
			goto IL_0221;
			IL_0269:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0221;
			IL_0221:
			CvsCogRectangle acquired2DImageBounds = default;
			ContrastToolType contrastToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							acquired2DImageBounds = contrastToolType.GetAcquired2DImageBounds();
							HOO81kKQ9kZpnUEbbOke();
							num3 = (EMTBD1KQXETVxyxjq3HF() ? 1 : 6);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!EMTBD1KQXETVxyxjq3HF())
							{
								goto IL_0102;
							}
						}
						goto IL_011b;
						IL_011b:
						while (true)
						{
							switch (num3)
							{
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 2:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									if (EMTBD1KQXETVxyxjq3HF())
									{
										continue;
									}
									goto case 9;
								}
								goto case 11;
							case 9:
								contrastToolType.Wy1CtoULpj = new CvsEditableDisplayGraphic[1] { contrastToolType.EditableComposite };
								awaiter = contrastToolType.iQZCPuHC6Q().GetAwaiter();
								goto case 2;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 4:
								return;
							case 3:
								break;
							default:
								num3 = 5;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (EMTBD1KQXETVxyxjq3HF())
								{
									continue;
								}
								goto IL_0173;
							case 5:
								goto IL_0173;
							case 0:
							case 1:
								contrastToolType.EditableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, acquired2DImageBounds);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter.GetResult();
								goto end_IL_0049;
							}
							break;
						}
						goto IL_0102;
						IL_0173:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						goto IL_011b;
						IL_0102:
						_003C_003Eu__1 = awaiter;
						goto IL_0173;
						end_IL_0049:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0269;
				default:
					num = 4;
					continue;
				case 1:
				case 3:
					contrastToolType = _003C_003E4__this;
					goto case 0;
				case 4:
					goto IL_0269;
				case 6:
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
		internal static bool EMTBD1KQXETVxyxjq3HF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HOO81kKQ9kZpnUEbbOke()
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

		public ContrastToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private ContrastTool _003CnewTool_003E5__6;

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
			int num = 0;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			ContrastToolType contrastToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<object> awaiter6 = default;
			TaskAwaiter<CvsCellRange> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			TaskAwaiter<double> awaiter2 = default;
			CvsCellCollection result3 = default;
			Dictionary<string, object> dictionary = default;
			(double, double) minMax = default;
			CvsCellLocation cellLocation = default;
			string text = default;
			CvsCellRange result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003Csheet_003E5__2 = null;
					goto case 3;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (R5DQHfKQ4fxEZaBYEMW1())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
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
								goto IL_0b16;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)RTOIrDKQC49F0l6nU9LQ(kxcMYrKQ6wgTs650XwMf(eJWEBQKQjwPK6DNBApDf(SiTusOKQ3Sn6WKbHamBA(contrastToolType))));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(contrastToolType._pasteObject, contrastToolType.Inspect, out _003CtoolName_003E5__5);
								_ = 0;
								if (R5DQHfKQ4fxEZaBYEMW1())
								{
									num4 = 67;
								}
								else
								{
									num4 = 66;
									if (!R5DQHfKQ4fxEZaBYEMW1())
									{
										goto IL_0738;
									}
								}
								goto IL_0329;
							case 3:
								awaiter3 = _003C_003Eu__4;
								num4 = 25;
								if (!QmgKBpKQ7xBBWMRqLoFQ())
								{
									goto IL_0329;
								}
								goto IL_04a4;
							case 1:
								awaiter6 = _003C_003Eu__2;
								num4 = 14;
								goto IL_0329;
							case 0:
								awaiter5 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 18;
								if (R5DQHfKQ4fxEZaBYEMW1())
								{
									goto IL_0329;
								}
								goto IL_0528;
							case 4:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 20;
								goto IL_0329;
							case 7:
								awaiter4 = _003C_003Eu__6;
								num4 = 38;
								goto IL_0329;
							case 5:
								awaiter3 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num4 = 15;
								goto IL_0329;
							case 6:
								awaiter2 = _003C_003Eu__5;
								num4 = 58;
								goto IL_0329;
							case 8:
								awaiter = _003C_003Eu__3;
								num4 = 6;
								if (true)
								{
									goto IL_0329;
								}
								goto IL_08ae;
							case 2:
								{
									awaiter = _003C_003Eu__3;
									num4 = 48;
									goto IL_0329;
								}
								IL_09b8:
								awaiter.GetResult();
								JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49398));
								awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num4 = 51;
								if (true)
								{
									goto IL_0329;
								}
								goto IL_09f2;
								IL_04a4:
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								num4 = 57;
								goto IL_0329;
								IL_0329:
								while (true)
								{
									switch (num4)
									{
									case 53:
										result3 = awaiter4.GetResult();
										num4 = 9;
										continue;
									case 2:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)rLTMU9KQAmDQUYqlnKDp(6148)), minMax.Item1);
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)rLTMU9KQAmDQUYqlnKDp(6138)), minMax.Item2);
										num4 = 49;
										continue;
									case 18:
										num2 = (_003C_003E1__state = -1);
										num4 = 1;
										continue;
									case 60:
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__3 = awaiter;
										num4 = 34;
										continue;
									case 43:
										_003CnewTool_003E5__6 = new ContrastTool((InspectStepViewModel)SiTusOKQ3Sn6WKbHamBA(contrastToolType), isInitialized: false);
										num4 = 42;
										continue;
									case 49:
										awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num4 = 44;
											continue;
										}
										goto case 53;
									case 41:
										awaiter3.GetResult();
										num4 = 11;
										continue;
									case 55:
										dictionary = new Dictionary<string, object>();
										num4 = 2;
										continue;
									case 24:
										num2 = (_003C_003E1__state = 6);
										num4 = 21;
										if (QmgKBpKQ7xBBWMRqLoFQ())
										{
										}
										continue;
									case 10:
										_003C_003Eu__4 = awaiter3;
										num4 = 19;
										continue;
									case 35:
										num2 = (_003C_003E1__state = 5);
										num4 = 28;
										if (true)
										{
											continue;
										}
										goto case 12;
									case 12:
									{
										double result4 = awaiter2.GetResult();
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(50070));
										minMax = ContrastTool.GetMinMax(result4);
										num4 = 55;
										if (!QmgKBpKQ7xBBWMRqLoFQ())
										{
											continue;
										}
										goto case 11;
									}
									case 11:
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(49436));
										num4 = 30;
										continue;
									case 0:
									case 67:
										awaiter5 = contrastToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											_003C_003Eu__1 = awaiter5;
											num4 = 32;
											if (0 == 0)
											{
												continue;
											}
											goto case 46;
										}
										goto case 1;
									case 46:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 5;
										continue;
									case 63:
									case 66:
										num2 = (_003C_003E1__state = -1);
										num4 = 36;
										if (R5DQHfKQ4fxEZaBYEMW1())
										{
											continue;
										}
										goto case 50;
									case 50:
										cellLocation = contrastToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, contrastToolType.VH7CBctS40);
										num4 = 17;
										continue;
									case 31:
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										goto case 37;
									default:
										num4 = 37;
										if (0 == 0)
										{
											continue;
										}
										goto case 16;
									case 16:
										if (!awaiter.IsCompleted)
										{
											num4 = 22;
											if (true)
											{
												continue;
											}
											goto case 15;
										}
										goto IL_09f2;
									case 15:
										num2 = (_003C_003E1__state = -1);
										num4 = 41;
										continue;
									case 19:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 61:
										break;
									case 8:
										_003C_003Eu__2 = awaiter6;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										return;
									case 64:
										num2 = (_003C_003E1__state = -1);
										num4 = 12;
										continue;
									case 39:
										return;
									case 7:
										goto IL_0528;
									case 59:
										goto IL_056c;
									case 21:
										_003C_003Eu__5 = awaiter2;
										num4 = 46;
										continue;
									case 32:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 39;
										continue;
									case 29:
										awaiter6.GetResult();
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(49608));
										num4 = 26;
										if (QmgKBpKQ7xBBWMRqLoFQ())
										{
										}
										continue;
									case 56:
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(49466));
										num4 = 31;
										continue;
									case 33:
										if (!awaiter.IsCompleted)
										{
											num4 = 60;
											continue;
										}
										goto IL_08fd;
									case 17:
										awaiter = leRefgKQFmGmD4iUR8f8(M9weCaKQ0GnBGIcMNl2h(SiTusOKQ3Sn6WKbHamBA(contrastToolType), text, cellLocation));
										num4 = 59;
										continue;
									case 1:
										result2 = awaiter5.GetResult();
										num4 = 62;
										continue;
									case 47:
										if (!awaiter6.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											num4 = 8;
											if (QmgKBpKQ7xBBWMRqLoFQ())
											{
											}
											continue;
										}
										goto case 29;
									case 54:
										return;
									case 45:
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(49576));
										awaiter6 = _003Csheet_003E5__2.PutCellExpressionAsync(contrastToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, contrastToolType.WWqCKHUkRB), (string)UKHlFiKQTZ2B8r5C9lma(contrastToolType.InputImageLinks[XWCSTBKQW6aGMDDRPiVY(contrastToolType)])).GetAwaiter();
										num4 = 47;
										continue;
									case 42:
										awaiter = leRefgKQFmGmD4iUR8f8(lpcApHKQYP4InsVDm8AX(_003CnewTool_003E5__6, result3, _003CpasteRange_003E5__3));
										num4 = 16;
										if (R5DQHfKQ4fxEZaBYEMW1())
										{
											continue;
										}
										goto case 6;
									case 6:
										_003C_003Eu__3 = default;
										goto case 63;
									case 38:
										goto IL_0738;
									case 44:
										num2 = (_003C_003E1__state = 7);
										_003C_003Eu__6 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 3:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 52;
										if (true)
										{
											continue;
										}
										return;
									case 40:
										return;
									case 13:
										if (!awaiter2.IsCompleted)
										{
											num4 = 24;
											continue;
										}
										goto case 12;
									case 65:
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(50896));
										num4 = 68;
										continue;
									case 25:
										_003C_003Eu__4 = default;
										num4 = 4;
										if (true)
										{
											continue;
										}
										goto case 58;
									case 58:
										_003C_003Eu__5 = default;
										num4 = 64;
										continue;
									case 9:
										CvsTraceEzb.Info.TraceMessage((string)rLTMU9KQAmDQUYqlnKDp(49842));
										num4 = 43;
										continue;
									case 34:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 54;
										continue;
									case 5:
										return;
									case 62:
										_003CpasteRange_003E5__3 = result2;
										num4 = 45;
										continue;
									case 52:
										return;
									case 4:
										goto IL_08ae;
									case 37:
										if (!awaiter3.IsCompleted)
										{
											num4 = 35;
											continue;
										}
										goto case 41;
									case 26:
										text = (string)VtcrVMKQyVXsWsCbDPk5(contrastToolType.FindInputFixtureCell(contrastToolType._pasteObject));
										num4 = 50;
										continue;
									case 20:
										num2 = (_003C_003E1__state = -1);
										goto IL_08fd;
									case 51:
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 3);
											num4 = 10;
											if (R5DQHfKQ4fxEZaBYEMW1())
											{
												continue;
											}
										}
										goto case 23;
									case 23:
										awaiter3.GetResult();
										JtFr2CKQRqbms3qA8GgS(CvsTraceEzb.Info, rLTMU9KQAmDQUYqlnKDp(49436));
										num4 = 7;
										if (R5DQHfKQ4fxEZaBYEMW1())
										{
											continue;
										}
										goto case 28;
									case 28:
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 40;
										if (R5DQHfKQ4fxEZaBYEMW1())
										{
											continue;
										}
										goto case 57;
									case 57:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 27;
										continue;
									case 48:
										goto IL_09a3;
									case 36:
										goto IL_09f2;
									case 22:
										num2 = (_003C_003E1__state = 8);
										_003C_003Eu__3 = awaiter;
										num4 = 3;
										continue;
									case 30:
										awaiter2 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(contrastToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, contrastToolType.UV1CZoVLJG), (string)rLTMU9KQAmDQUYqlnKDp(1524)).GetAwaiter();
										num4 = 13;
										continue;
									case 27:
										return;
									case 14:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 29;
										continue;
									case 68:
										{
											result = _003CnewTool_003E5__6;
											goto end_IL_0084;
										}
										IL_08fd:
										awaiter.GetResult();
										num4 = 56;
										if (R5DQHfKQ4fxEZaBYEMW1())
										{
											continue;
										}
										goto case 51;
									}
									break;
								}
								goto IL_04a4;
								IL_09a3:
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_09b8;
								IL_08ae:
								num2 = (_003C_003E1__state = -1);
								num4 = 23;
								goto IL_0329;
								IL_0738:
								_003C_003Eu__6 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 53;
								if (QmgKBpKQ7xBBWMRqLoFQ())
								{
								}
								goto IL_0329;
								IL_0528:
								awaiter = leRefgKQFmGmD4iUR8f8(iZyysfKQMvVUDJYpNmBA(((AppStepViewModel)SiTusOKQ3Sn6WKbHamBA(contrastToolType)).InSight, contrastToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, contrastToolType.xWRCG33gIX), contrastToolType.EditableComposite));
								num4 = 33;
								if (R5DQHfKQ4fxEZaBYEMW1())
								{
									goto IL_0329;
								}
								goto IL_056c;
								IL_056c:
								if (!awaiter.IsCompleted)
								{
									num4 = 61;
									goto IL_0329;
								}
								goto IL_09b8;
								IL_09f2:
								awaiter.GetResult();
								num4 = 65;
								goto IL_0329;
								end_IL_0084:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0aae;
						}
						goto end_IL_004b;
						IL_0aae:
						if (num3 == 1)
						{
							awaiter = leRefgKQFmGmD4iUR8f8(contrastToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0b16;
						}
						goto IL_0b3f;
						IL_0b16:
						awaiter.GetResult();
						((ExceptionDispatchInfo)TqpoFXKQURfa11f23OCT((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3)).Throw();
						goto IL_0b3f;
						IL_0b3f:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_004b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 6;
					break;
				case 6:
					contrastToolType = _003C_003E4__this;
					R5DQHfKQ4fxEZaBYEMW1();
					if (QmgKBpKQ7xBBWMRqLoFQ())
					{
						num = 3;
						break;
					}
					num = 1;
					if (false)
					{
						return;
					}
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
		internal static object SiTusOKQ3Sn6WKbHamBA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eJWEBQKQjwPK6DNBApDf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kxcMYrKQ6wgTs650XwMf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RTOIrDKQC49F0l6nU9LQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rLTMU9KQAmDQUYqlnKDp(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JtFr2CKQRqbms3qA8GgS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int XWCSTBKQW6aGMDDRPiVY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UKHlFiKQTZ2B8r5C9lma(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VtcrVMKQyVXsWsCbDPk5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M9weCaKQ0GnBGIcMNl2h(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter leRefgKQFmGmD4iUR8f8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iZyysfKQMvVUDJYpNmBA(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lpcApHKQYP4InsVDm8AX(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TqpoFXKQURfa11f23OCT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R5DQHfKQ4fxEZaBYEMW1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QmgKBpKQ7xBBWMRqLoFQ()
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

		public ContrastToolType _003C_003E4__this;

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
			int num = (f8EQRPKQxrj9SZlBaTyR() ? 2 : 5);
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					break;
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 3;
				default:
					num = 3;
					break;
				case 1:
				case 2:
					qmYvfjKQQNsXVLrmXyrQ(this);
					num = 4;
					if (!f8EQRPKQxrj9SZlBaTyR())
					{
						break;
					}
					goto case 0;
				case 0:
				case 5:
					IhsNqjKQm1Y4w7mG94op();
					goto case 1;
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
			int num = 6;
			int num2 = default;
			ContrastToolType contrastToolType = default;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 11:
					return true;
				case 2:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					goto case 8;
				default:
					num = 8;
					continue;
				case 9:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 2;
						continue;
					}
					goto case 1;
				case 4:
					switch (num2)
					{
					case 2:
						break;
					default:
						return false;
					case 0:
						_003C_003E1__state = -1;
						num = 7;
						continue;
					case 1:
						_003C_003E1__state = -1;
						num = 1;
						continue;
					}
					_003C_003E1__state = -1;
					num = 14;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 6:
					num2 = _003C_003E1__state;
					num = 13;
					continue;
				case 8:
					_003C_003E1__state = 1;
					num = 0;
					continue;
				case 5:
				case 10:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, contrastToolType.Localizer);
					_003C_003E1__state = 2;
					goto case 3;
				case 7:
					_003CcurrentVersion_003E5__2 = gxPe8bKQNPti5M0oC56E(cells, range);
					num = 12;
					continue;
				case 1:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						QZIOObKQH65245nSrWgt();
						num = ((!f8EQRPKQxrj9SZlBaTyR()) ? 5 : 3);
						continue;
					}
					break;
				case 12:
					_003ClatestVersion_003E5__3 = a56cHTKQ20URsOHrUy3H(contrastToolType._pasteObject);
					num = 9;
					continue;
				case 13:
					contrastToolType = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
					return true;
				case 14:
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
		internal static void IhsNqjKQm1Y4w7mG94op()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qmYvfjKQQNsXVLrmXyrQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QZIOObKQH65245nSrWgt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f8EQRPKQxrj9SZlBaTyR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int gxPe8bKQNPti5M0oC56E(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a56cHTKQ20URsOHrUy3H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] aKKCslxKFP;

	private readonly CvsCellLocation WWqCKHUkRB;

	private readonly CvsCellLocation xWRCG33gIX;

	private readonly CvsCellLocation VH7CBctS40;

	private readonly CvsCellLocation UV1CZoVLJG;

	private int JJ4Cn11R9Q;

	private CvsEditableDisplayGraphic[] Wy1CtoULpj;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aKKCslxKFP;
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
			return Resources.Contrast;
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
			return (string)bu2R7YWSD83TYNsEy7t();
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
			return XAMLGraphicKeys.Tools_ContrastIcon;
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
			return XAMLGraphicKeys.Tools_ContrastIcon;
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
				(string)V7HSbGWkrP9NqqspPAF(),
				(string)e9v83VW814nvu8dhWoL()
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
			return JJ4Cn11R9Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref JJ4Cn11R9Q, value, (string)q0dmvdWoveMpiJ5GQ3P(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContrastToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0139;
		IL_001a:
		base._002Ector();
		num = 10;
		if (false)
		{
			goto IL_002d;
		}
		goto IL_0139;
		IL_0139:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 7:
			case 9:
				goto IL_002d;
			case 5:
				aKKCslxKFP = new Guid[1]
				{
					new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27442))
				};
				JJ4Cn11R9Q = 105;
				num = 8;
				continue;
			case 3:
			case 6:
				VH7CBctS40 = _pasteObject.GetCellOffset((string)q0dmvdWoveMpiJ5GQ3P(6522));
				goto IL_002d;
			case 2:
				xWRCG33gIX = _pasteObject.GetCellOffset((string)q0dmvdWoveMpiJ5GQ3P(5684));
				_ = 1;
				if (XTp2rAWZpEpJPkOwN1J())
				{
					num = 9;
					continue;
				}
				num = 3;
				if (XTp2rAWZpEpJPkOwN1J())
				{
				}
				continue;
			case 10:
				_pasteObject = (PasteBuffer)gDG9ltWGgYBiCP0v2tJ(SDdHmeWb98A7tHtEHeN());
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				WWqCKHUkRB = _pasteObject.GetCellOffset((string)q0dmvdWoveMpiJ5GQ3P(4928));
				goto case 2;
			default:
				num = 2;
				continue;
			case 4:
				AddSnippet(_pasteObject);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				B4deUTWBMkbgBaMmSus();
				num = 5;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_002d:
		UV1CZoVLJG = _pasteObject.GetCellOffset((string)q0dmvdWoveMpiJ5GQ3P(2206));
		num = 4;
		goto IL_0139;
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
		int num = 5;
		_003COnBeginAddInternal_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = fxQOW8WqDM0eWFjcPcy();
				hkiHj2WPnBYCtVWMtWU();
				num = (XTp2rAWZpEpJPkOwN1J() ? 4 : 2);
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Wy1CtoULpj;
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
	[DebuggerHidden]
	[CompilerGenerated]
	private Task iQZCPuHC6Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B4deUTWBMkbgBaMmSus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SDdHmeWb98A7tHtEHeN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.Contrast;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gDG9ltWGgYBiCP0v2tJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q0dmvdWoveMpiJ5GQ3P(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hkiHj2WPnBYCtVWMtWU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XTp2rAWZpEpJPkOwN1J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bu2R7YWSD83TYNsEy7t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.hTbZxrCKaw();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V7HSbGWkrP9NqqspPAF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e9v83VW814nvu8dhWoL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.A6xJ0EZQJY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder fxQOW8WqDM0eWFjcPcy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
