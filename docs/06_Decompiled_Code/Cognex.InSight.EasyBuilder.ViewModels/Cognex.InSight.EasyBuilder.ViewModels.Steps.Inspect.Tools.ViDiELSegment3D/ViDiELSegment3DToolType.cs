using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Segment;
using Cognex.Segmenter.Client.Tool.Interfaces;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELSegment3D;

[Export(typeof(EzToolType))]
public class ViDiELSegment3DToolType : EzToolType, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELSegment3DToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ViDiELSegment3DTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			EzTool result = default;
			int num2 = default;
			ViDiELSegment3DToolType viDiELSegment3DToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (Eb3qncKElkuOk2k1CAeT())
					{
					}
					continue;
				case 2:
				case 3:
					_003Ctool_003E5__2 = null;
					goto case 1;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					if (AZLFuAKEdPeAM1JYOdHj())
					{
						continue;
					}
					goto case 0;
				case 0:
					viDiELSegment3DToolType = _003C_003E4__this;
					num = 6;
					continue;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ViDiELSegment3DTool(viDiELSegment3DToolType.Inspect, isInitialized: true, viDiELSegment3DToolType.DNqo4CiNRi);
							AZLFuAKEdPeAM1JYOdHj();
							num3 = (Eb3qncKElkuOk2k1CAeT() ? 2 : 9);
							goto IL_0126;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0161;
						IL_0126:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 6:
								return;
							case 0:
							case 9:
								awaiter = ((Task)jtPclYKEgpZy9CHP1vRv(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
								num3 = 7;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 2:
							case 5:
								break;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 8;
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0126;
							}
							goto IL_0161;
							continue;
							end_IL_0126:
							break;
						}
						goto end_IL_0077;
						IL_0161:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0126;
						end_IL_0077:;
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
				_ = 1;
				if (Eb3qncKElkuOk2k1CAeT())
				{
					num = 1;
					continue;
				}
				num = 2;
				if (!AZLFuAKEdPeAM1JYOdHj())
				{
					break;
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
		internal static object jtPclYKEgpZy9CHP1vRv(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AZLFuAKEdPeAM1JYOdHj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Eb3qncKElkuOk2k1CAeT()
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
	private struct _003COnBeginAddInternal_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (oBgPIsKEve9fScDoMsBq() ? 1 : 4);
			int num2 = default;
			CvsCellLocation cvsCellLocation = default;
			ViDiELSegment3DToolType viDiELSegment3DToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cvsCellLocation = CvsCellLocation.Parse(viDiELSegment3DToolType.CurrentInputImageLink.Expression);
							num3 = 13;
							if (1 == 0)
							{
								goto IL_005e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_0190;
						IL_0190:
						while (true)
						{
							switch (num3)
							{
							case 11:
								break;
							case 6:
								nmWwyaKE8W9pC08HlbI4(viDiELSegment3DToolType.EditableRegion, wNdNcFKESCvVcHXdtrwi());
								num3 = 4;
								if (!oBgPIsKEve9fScDoMsBq())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (oBgPIsKEve9fScDoMsBq())
								{
								}
								continue;
							case 12:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							case 3:
								BflsMnKEkee2DEfCe2iv(viDiELSegment3DToolType.EditableRegion, wNdNcFKESCvVcHXdtrwi());
								num3 = 6;
								continue;
							case 1:
								awaiter = sVLnAgKEqikqStMwXAxC(viDiELSegment3DToolType.DaXobYlKI1());
								_ = 0;
								num3 = (UCe0dTKEsIe0mbfjk3na() ? 2 : 10);
								continue;
							case 2:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto case 14;
							case 0:
								ckq2m9KEorq8wEkx7Qn6(kGCOqWKEbSq40V5lrIxE(viDiELSegment3DToolType.EditableRegion), PAF4ggKEGdIDvO6oDVtU());
								num3 = 3;
								continue;
							case 4:
								viDiELSegment3DToolType.DsZoWKsRnp = new CvsEditableDisplayGraphic[1] { viDiELSegment3DToolType.EditableRegion };
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 5:
								wb2fAtKEBuJlQ2drgHun(viDiELSegment3DToolType.EditableRegion, false);
								num3 = 0;
								continue;
							case 13:
							{
								CvsCell imageCell = (CvsCell)NEJNXyKEZWaaljcL8HSk(((CvsResultSet)B3YD7QKEPpTegV72s17l(n4VG40KErVvZu7Pv5L23(viDiELSegment3DToolType))).Cells, cvsCellLocation);
								viDiELSegment3DToolType.EditableRegion = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, imageCell);
								num3 = 5;
								continue;
							}
							case 14:
								awaiter.GetResult();
								goto end_IL_0190;
							}
							goto IL_005e;
							continue;
							end_IL_0190:
							break;
						}
						goto end_IL_003b;
						IL_005e:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 14;
						goto IL_0190;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					break;
				case 6:
					return;
				}
				viDiELSegment3DToolType = _003C_003E4__this;
				num = 2;
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
		internal static object n4VG40KErVvZu7Pv5L23(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B3YD7QKEPpTegV72s17l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NEJNXyKEZWaaljcL8HSk(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wb2fAtKEBuJlQ2drgHun(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kGCOqWKEbSq40V5lrIxE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PAF4ggKEGdIDvO6oDVtU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.Llm99jZtB5();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ckq2m9KEorq8wEkx7Qn6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphic)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color wNdNcFKESCvVcHXdtrwi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Cyan;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BflsMnKEkee2DEfCe2iv(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nmWwyaKE8W9pC08HlbI4(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter sVLnAgKEqikqStMwXAxC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UCe0dTKEsIe0mbfjk3na()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oBgPIsKEve9fScDoMsBq()
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
	private struct _003CAddTool_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELSegment3DToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ViDiELSegment3DTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (g8FwSJKEp813yI8I2NAS() ? 6 : 2);
			EzTool result = default;
			ViDiELSegment3DToolType viDiELSegment3DToolType = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCellCollection> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			string text = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result3 = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
				case 6:
					viDiELSegment3DToolType = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						if ((uint)num2 > 6u)
						{
							if (num2 == 7)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_07b5;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)wJXkbiKE46PMTxEYTnNH(VpAw4WKE9Cs6Wbuf9iPk(((AppStepViewModel)TtxOBiKEXKQhefJKDc7F(viDiELSegment3DToolType)).InSight));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
							{
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(viDiELSegment3DToolType._pasteObject, (InspectStepViewModel)TtxOBiKEXKQhefJKDc7F(viDiELSegment3DToolType), out var _);
								num4 = 32;
								goto IL_03e3;
							}
							case 2:
								awaiter = _003C_003Eu__3;
								goto IL_02df;
							case 5:
								awaiter5 = _003C_003Eu__5;
								num4 = 18;
								if (1 == 0)
								{
									goto IL_01d6;
								}
								goto IL_03e3;
							case 3:
								awaiter4 = _003C_003Eu__4;
								num4 = 36;
								goto IL_03e3;
							case 1:
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 33;
								goto IL_03e3;
							case 0:
								awaiter2 = _003C_003Eu__1;
								num4 = 34;
								goto IL_03e3;
							case 4:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 40;
								goto IL_03e3;
							case 6:
								{
									awaiter = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num4 = 23;
									if (0 == 0)
									{
										goto IL_03e3;
									}
									goto IL_06f8;
								}
								IL_03e3:
								while (true)
								{
									switch (num4)
									{
									case 21:
										_003C_003Eu__5 = awaiter5;
										num4 = 2;
										continue;
									case 24:
										awaiter3 = _003Csheet_003E5__2.PutCellExpressionAsync(viDiELSegment3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELSegment3DToolType.JbDoghflB9), (string)TWUpkrKE7xPxgwrRSncM(viDiELSegment3DToolType.InputImageLinks[viDiELSegment3DToolType.InputImageIndex])).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											_ = 1;
											if (!g8FwSJKEp813yI8I2NAS())
											{
												num4 = 19;
												if (!g8FwSJKEp813yI8I2NAS())
												{
													continue;
												}
												goto case 35;
											}
											num4 = 48;
											continue;
										}
										goto case 15;
									case 35:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 30;
										continue;
									case 22:
										return;
									case 41:
										_003CnewTool_003E5__5 = new ViDiELSegment3DTool((InspectStepViewModel)TtxOBiKEXKQhefJKDc7F(viDiELSegment3DToolType), isInitialized: false, viDiELSegment3DToolType.DNqo4CiNRi);
										num4 = 10;
										continue;
									case 17:
										if (!awaiter.IsCompleted)
										{
											num4 = 3;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										goto IL_070d;
									case 6:
										return;
									case 33:
										break;
									case 23:
										num2 = (_003C_003E1__state = -1);
										num4 = 39;
										if (0 == 0)
										{
											continue;
										}
										goto case 29;
									case 29:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__4 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 0:
										if (!awaiter2.IsCompleted)
										{
											num4 = 35;
											continue;
										}
										goto case 38;
									case 12:
										awaiter = mwGHd9KE6s1dM2rVcsSn(skckLJKEjgOPg4wrQW18(TtxOBiKEXKQhefJKDc7F(viDiELSegment3DToolType), text, cellLocation));
										num4 = 17;
										continue;
									case 27:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 22;
										continue;
									case 47:
										num2 = (_003C_003E1__state = -1);
										goto IL_0293;
									case 20:
									case 48:
										goto IL_02df;
									case 42:
										_003C_003Eu__3 = awaiter;
										num4 = 13;
										continue;
									case 32:
										awaiter2 = viDiELSegment3DToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 0;
										continue;
									case 1:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 44:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 4);
											num4 = 42;
											continue;
										}
										goto IL_0603;
									case 36:
										_003C_003Eu__4 = default;
										num4 = 47;
										continue;
									case 15:
										awaiter3.GetResult();
										num4 = 28;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 6;
										continue;
									case 39:
										awaiter.GetResult();
										num4 = 49;
										continue;
									case 31:
										if (!awaiter4.IsCompleted)
										{
											goto case 29;
										}
										goto IL_0293;
									default:
										num4 = 29;
										continue;
									case 34:
										_003C_003Eu__1 = default;
										num4 = 45;
										continue;
									case 25:
										_003CpasteRange_003E5__3 = result3;
										num4 = 24;
										continue;
									case 9:
									case 19:
										num2 = (_003C_003E1__state = 1);
										num4 = 4;
										if (vsrlYvKEEKkCZHRB94cj())
										{
											continue;
										}
										return;
									case 30:
										return;
									case 45:
										num2 = (_003C_003E1__state = -1);
										num4 = 38;
										if (vsrlYvKEEKkCZHRB94cj())
										{
											continue;
										}
										goto case 28;
									case 28:
										text = (string)A90aOTKE3pSJDS8dwCel(viDiELSegment3DToolType.FindInputFixtureCell(viDiELSegment3DToolType._pasteObject));
										cellLocation = viDiELSegment3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELSegment3DToolType.xgOoR4mhln);
										num4 = 12;
										continue;
									case 46:
										if (!awaiter.IsCompleted)
										{
											num4 = 14;
											continue;
										}
										goto case 39;
									case 38:
										result3 = awaiter2.GetResult();
										num4 = 25;
										continue;
									case 8:
										_003C_003Eu__3 = awaiter;
										num4 = 26;
										continue;
									case 4:
										_003C_003Eu__2 = awaiter3;
										num4 = 1;
										continue;
									case 7:
										return;
									case 18:
										_003C_003Eu__5 = default;
										num4 = 43;
										continue;
									case 37:
										result2 = awaiter5.GetResult();
										num4 = 41;
										continue;
									case 40:
										num2 = (_003C_003E1__state = -1);
										goto IL_0603;
									case 43:
										num2 = (_003C_003E1__state = -1);
										num4 = 37;
										continue;
									case 16:
										num2 = (_003C_003E1__state = 5);
										num4 = 21;
										if (!g8FwSJKEp813yI8I2NAS())
										{
											continue;
										}
										goto case 5;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num4 = 11;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = 2);
										num4 = 27;
										continue;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 7;
										continue;
									case 10:
										awaiter = mwGHd9KE6s1dM2rVcsSn(PFWmScKERNiQv3ObQhfp(_003CnewTool_003E5__5, result2, _003CpasteRange_003E5__3));
										num4 = 46;
										continue;
									case 26:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 14:
										goto IL_06f8;
									case 11:
										goto IL_070d;
									case 49:
										{
											result = _003CnewTool_003E5__5;
											goto end_IL_0083;
										}
										IL_0603:
										awaiter.GetResult();
										awaiter5 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (awaiter5.IsCompleted)
										{
											goto case 37;
										}
										num4 = 16;
										if (true)
										{
											continue;
										}
										goto case 43;
										IL_0293:
										awaiter4.GetResult();
										awaiter = mwGHd9KE6s1dM2rVcsSn(EMi9kMKEATVqH6rJhyQV(c0gLZtKECX2b2YRwcqh7(viDiELSegment3DToolType.Inspect), viDiELSegment3DToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELSegment3DToolType.TUkoMWrC0t), viDiELSegment3DToolType.EditableRegion));
										num4 = 44;
										if (vsrlYvKEEKkCZHRB94cj())
										{
											continue;
										}
										goto IL_02df;
									}
									break;
								}
								goto IL_01d6;
								IL_06f8:
								num2 = (_003C_003E1__state = 6);
								num4 = 8;
								if (true)
								{
									goto IL_03e3;
								}
								goto IL_070d;
								IL_02df:
								_003C_003Eu__3 = default;
								num4 = 5;
								goto IL_03e3;
								IL_01d6:
								num2 = (_003C_003E1__state = -1);
								num4 = 15;
								goto IL_03e3;
								IL_070d:
								awaiter.GetResult();
								awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num4 = 31;
								goto IL_03e3;
								end_IL_0083:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_074e;
						}
						goto end_IL_004b;
						IL_074e:
						if (num3 == 1)
						{
							awaiter = mwGHd9KE6s1dM2rVcsSn(viDiELSegment3DToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_07b5;
						}
						goto IL_07de;
						IL_07b5:
						awaiter.GetResult();
						I3jFwuKETP7VMI3S3w7Z(bkHYaUKEWJjZ2t5Bqw9f((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_07de;
						IL_07de:
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
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
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
		internal static object TtxOBiKEXKQhefJKDc7F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VpAw4WKE9Cs6Wbuf9iPk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wJXkbiKE46PMTxEYTnNH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TWUpkrKE7xPxgwrRSncM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object A90aOTKE3pSJDS8dwCel(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object skckLJKEjgOPg4wrQW18(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mwGHd9KE6s1dM2rVcsSn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c0gLZtKECX2b2YRwcqh7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EMi9kMKEATVqH6rJhyQV(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PFWmScKERNiQv3ObQhfp(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bkHYaUKEWJjZ2t5Bqw9f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void I3jFwuKETP7VMI3S3w7Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vsrlYvKEEKkCZHRB94cj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g8FwSJKEp813yI8I2NAS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] kxmoQFU5IK;

	private readonly CvsCellLocation JbDoghflB9;

	private readonly CvsCellLocation TUkoMWrC0t;

	private readonly CvsCellLocation xgOoR4mhln;

	private EZBSegment3DAdapter DNqo4CiNRi;

	private int am5ol7Cx04;

	[CompilerGenerated]
	private CvsDisplayableRegion vtjoTucWHg;

	private CvsEditableDisplayGraphic[] DsZoWKsRnp;

	public override InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return base.Inspect;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!qob1QyvFGoI1iVPTUOj())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_0058;
				}
			}
			goto IL_007b;
			IL_0058:
			DNqo4CiNRi = new EZBSegment3DAdapter(base.Inspect);
			goto IL_0024;
			IL_003f:
			base.Inspect = value;
			goto IL_0058;
			IL_007b:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 2:
					goto IL_003f;
				case 1:
				case 4:
					goto IL_0058;
				default:
					num = 3;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_0024;
			IL_0024:
			xXt8mdvUBZ3C7PeyUU0(DNqo4CiNRi);
			num = 5;
			if (qob1QyvFGoI1iVPTUOj())
			{
				goto IL_003f;
			}
			goto IL_007b;
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
			return kxmoQFU5IK;
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
			return (string)WIi8IavH0dFy5kUI0I6();
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
			return (string)kJZv5OvxLAQyYMdjb0B();
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
			return XAMLGraphicKeys.Tools_Segment3DIcon;
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
			return XAMLGraphicKeys.Tools_Segment3DIcon;
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
				Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.Inspect,
				Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELTools
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
			return am5ol7Cx04;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref am5ol7Cx04, value, (string)X6XrPHvY7oE7tPT3Vrt(3256));
		}
	}

	public CvsDisplayableRegion EditableRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vtjoTucWHg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vtjoTucWHg = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELSegment3DToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!thWwQFv0bJ7KJm6jPm0()) ? 8 : 5);
		while (true)
		{
			switch (num)
			{
			case 9:
				JbDoghflB9 = _pasteObject.GetCellOffset((string)X6XrPHvY7oE7tPT3Vrt(4928));
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				TUkoMWrC0t = _pasteObject.GetCellOffset((string)X6XrPHvY7oE7tPT3Vrt(5684));
				num = 2;
				break;
			case 7:
				_pasteObject = (PasteBuffer)lgAOVLvMKcuuYpGb6hw(Snippets.ViDiELSegment3D);
				num = 9;
				break;
			case 3:
				AddSnippet(_pasteObject);
				num = 10;
				break;
			case 2:
				xgOoR4mhln = _pasteObject.GetCellOffset((string)X6XrPHvY7oE7tPT3Vrt(6522));
				num = 3;
				break;
			case 0:
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 1:
			case 8:
				am5ol7Cx04 = 140;
				num = 4;
				break;
			case 4:
				base._002Ector();
				num = 7;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DNqo4CiNRi.Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__28))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__29))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (qob1QyvFGoI1iVPTUOj() ? 2 : 3);
		_003COnBeginAddInternal_003Ed__29 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = EdWyp3vmc3gGHyZilAt();
				goto case 1;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
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
		return DsZoWKsRnp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__36))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__36 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enumerable.Empty<ISnippetUpdate>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViDiELSegment3DToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WmYNUXvQNE5evn80JSc();
		kxmoQFU5IK = new Guid[1]
		{
			new Guid((string)X6XrPHvY7oE7tPT3Vrt(6550))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task DaXobYlKI1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lgAOVLvMKcuuYpGb6hw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X6XrPHvY7oE7tPT3Vrt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool thWwQFv0bJ7KJm6jPm0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qob1QyvFGoI1iVPTUOj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xXt8mdvUBZ3C7PeyUU0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmentAdapterBase.Register((ISegmenterToolAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WIi8IavH0dFy5kUI0I6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELSegment3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kJZv5OvxLAQyYMdjb0B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELSegment3DDescription;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder EdWyp3vmc3gGHyZilAt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WmYNUXvQNE5evn80JSc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
