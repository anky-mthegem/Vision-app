using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Layouts;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify.Updates;
using Cognex.InSight.Graphic;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Services;
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify;

[Export(typeof(EzToolType))]
public class ViDiELClassifyToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELClassifyToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ViDiELClassifyTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			ViDiELClassifyToolType viDiELClassifyToolType = default;
			EzTool result = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003Ctool_003E5__2 = null;
					goto case 2;
				case 6:
					num2 = _003C_003E1__state;
					TcR9dDKXM7P68ksRipYd();
					num = ((!fWFfaKKXFhLaBN6Gm704()) ? 2 : 0);
					break;
				case 0:
				case 1:
					viDiELClassifyToolType = _003C_003E4__this;
					num = 3;
					if (fWFfaKKXFhLaBN6Gm704())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ViDiELClassifyTool((InspectStepViewModel)LsDInqKXYFl2ORAqrH54(viDiELClassifyToolType), isInitialized: true);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 2;
							case 2:
							case 7:
								awaiter.GetResult();
								num3 = 10;
								if (fWFfaKKXFhLaBN6Gm704())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								if (awaiter.IsCompleted)
								{
									goto case 2;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								_ = 0;
								num3 = (fWFfaKKXFhLaBN6Gm704() ? 4 : 2);
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 1:
								awaiter = Pa4XjrKXUCw2c0hC6HVV(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
								num3 = 5;
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
					goto case 5;
				default:
					num = 5;
					if (TcR9dDKXM7P68ksRipYd())
					{
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
		internal static object LsDInqKXYFl2ORAqrH54(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Pa4XjrKXUCw2c0hC6HVV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fWFfaKKXFhLaBN6Gm704()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TcR9dDKXM7P68ksRipYd()
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
	private struct _003COnBeginAddInternal_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			ViDiELClassifyToolType viDiELClassifyToolType = default;
			CvsCellLocation cvsCellLocation = default;
			TaskAwaiter awaiter = default;
			CvsCell imageCell = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					viDiELClassifyToolType = _003C_003E4__this;
					_ = 1;
					num = ((!iBM6pTKXxtoMDouFJxuJ()) ? 4 : 0);
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cvsCellLocation = gUhG5SKXQX2kwjYf7s5n(MfuigUKXmu9YgP1fHMEQ(viDiELClassifyToolType.CurrentInputImageLink));
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								BcuaC2K95NR1JbXLRoKl(viDiELClassifyToolType.EditableRegion, eYmK66K9LCCG3EaiSKfw());
								goto case 13;
							default:
								num3 = 13;
								continue;
							case 13:
								viDiELClassifyToolType.BdaDlhhRop = new CvsEditableDisplayGraphic[1] { viDiELClassifyToolType.EditableRegion };
								goto case 7;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								break;
							case 6:
								imageCell = (CvsCell)apXAs4KX17CrkXLaNGNj(zFP6yXKXcoQQJZvLPNq2(JsWiRYKX21IfQkRajdyr(hGWXpnKXN90rAwqYvGDd(viDiELClassifyToolType))), cvsCellLocation);
								_ = 1;
								if (iBM6pTKXxtoMDouFJxuJ())
								{
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 5;
								continue;
							case 7:
							case 10:
								awaiter = IMlC2eK9wGf29sWGE8WE(viDiELClassifyToolType.abBDEmQi7e());
								num3 = 3;
								continue;
							case 11:
								XZLvRKK9KBylwDGaukZ9(viDiELClassifyToolType.EditableRegion, eYmK66K9LCCG3EaiSKfw());
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
							case 5:
								viDiELClassifyToolType.EditableRegion = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, imageCell);
								num3 = 2;
								continue;
							case 8:
								YALwG5KXzaaYHFnlTm3D(XBgvcdKXhwC2MipjttAI(viDiELClassifyToolType.EditableRegion), qxEdXNKXt5jVIDaKUoSh());
								num3 = 11;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 2:
								HGZ85SKXuBZP4YhBQep4(viDiELClassifyToolType.EditableRegion, false);
								num3 = 8;
								continue;
							case 14:
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
		internal static object MfuigUKXmu9YgP1fHMEQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation gUhG5SKXQX2kwjYf7s5n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.Parse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hGWXpnKXN90rAwqYvGDd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JsWiRYKX21IfQkRajdyr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zFP6yXKXcoQQJZvLPNq2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object apXAs4KX17CrkXLaNGNj(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HGZ85SKXuBZP4YhBQep4(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XBgvcdKXhwC2MipjttAI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qxEdXNKXt5jVIDaKUoSh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.zMPZaAeSWW();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YALwG5KXzaaYHFnlTm3D(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphic)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color eYmK66K9LCCG3EaiSKfw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Cyan;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XZLvRKK9KBylwDGaukZ9(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BcuaC2K95NR1JbXLRoKl(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter IMlC2eK9wGf29sWGE8WE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MUfKG2KXHA0WKxBH62tU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iBM6pTKXxtoMDouFJxuJ()
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
	private struct _003CAddTool_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELClassifyToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ViDiELClassifyTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		private IEnumerator<ClassViewModel> _003C_003E7__wrap5;

		private TaskAwaiter<string> _003C_003Eu__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!c4j1tgK9aFbqBrX4Ks6Q())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0b98;
				}
			}
			goto IL_0b61;
			IL_0b98:
			_003Csheet_003E5__2 = null;
			num = 6;
			goto IL_0b61;
			IL_0b61:
			EzTool result = default;
			ViDiELClassifyToolType viDiELClassifyToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					goto IL_0b98;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (!c4j1tgK9aFbqBrX4Ks6Q())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					viDiELClassifyToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if ((uint)num2 > 14u)
				{
					if (num2 == 15)
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0adc;
					}
					_003Csheet_003E5__2 = viDiELClassifyToolType.Inspect.InSight.CogSocket.Sheet;
					_003CpasteRange_003E5__3 = CvsCellRange.Empty;
					num3 = 0;
				}
				try
				{
					TaskAwaiter<CvsCellRange> awaiter5;
					TaskAwaiter<object> awaiter4;
					TaskAwaiter<CvsCogSheetResult> awaiter3;
					TaskAwaiter<CvsCellCollection> awaiter2;
					CvsCellRange result2;
					string text;
					CvsCellLocation cellLocation;
					CvsCellCollection result3;
					switch (num2)
					{
					default:
					{
						PasteBuffer pasteObject = EzToolType.UpdateNamesInPasteBuffer(viDiELClassifyToolType._pasteObject, viDiELClassifyToolType.Inspect, out var _);
						awaiter5 = viDiELClassifyToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter5;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
							return;
						}
						goto IL_0114;
					}
					case 0:
						awaiter5 = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0114;
					case 1:
						awaiter4 = _003C_003Eu__2;
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_01b1;
					case 2:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0248;
					case 3:
						awaiter3 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_02c3;
					case 4:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0360;
					case 5:
						awaiter2 = _003C_003Eu__5;
						_003C_003Eu__5 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_03db;
					case 6:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_045d;
					case 7:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0507;
					case 8:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0587;
					case 9:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_060e;
					case 10:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_06a9;
					case 11:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_071a;
					case 12:
					case 13:
						try
						{
							int num4;
							TaskAwaiter<string> awaiter6 = default;
							if (num2 != 12)
							{
								num4 = 0;
								if (false)
								{
									goto IL_0751;
								}
							}
							else
							{
								awaiter6 = _003C_003Eu__6;
								num4 = 8;
							}
							goto IL_085c;
							IL_085c:
							ClassViewModel current = default;
							while (true)
							{
								IL_085c_2:
								switch (num4)
								{
								case 8:
									break;
								case 4:
									awaiter6 = ((Classifier)kOnZ6kK9bAcZ062ClQVP(_003CnewTool_003E5__5))._LabelCurrentImage(current).GetAwaiter();
									num4 = 1;
									continue;
								case 11:
								case 14:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 13);
										num4 = 18;
										continue;
									}
									goto case 6;
								case 1:
									if (!awaiter6.IsCompleted)
									{
										num2 = (_003C_003E1__state = 12);
										num4 = 10;
										continue;
									}
									goto case 9;
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 13;
									continue;
								case 9:
									awaiter6.GetResult();
									goto case 3;
								default:
									num4 = 7;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
								case 16:
									awaiter.GetResult();
									num4 = 19;
									continue;
								case 18:
									_003C_003Eu__3 = awaiter;
									num4 = 17;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
									num4 = 12;
									continue;
								case 10:
									_003C_003Eu__6 = awaiter6;
									num4 = 2;
									continue;
								case 13:
									return;
								case 15:
									awaiter = jlXvPPK9DyhdcmkD1uMZ(qULE0nK9oY651svh2xa9(gK7iJTK9GceofdKjvWCk(_003CnewTool_003E5__5.SpreadsheetTool), ILw9U3K9qyqDt53tChHU(current), true));
									IxHpfVK9JXpbB3ojsxpn();
									if (!c4j1tgK9aFbqBrX4Ks6Q())
									{
										num4 = 14;
										if (0 == 0)
										{
											continue;
										}
										return;
									}
									num4 = 6;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 12:
									return;
								case 0:
									if (num2 == 13)
									{
										awaiter = _003C_003Eu__3;
										_003C_003Eu__3 = default;
										num4 = 5;
									}
									else
									{
										num4 = 3;
									}
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									goto case 6;
								case 3:
								case 7:
								case 19:
									while (YNPnovK9p9eQ4iPvGyfF(_003C_003E7__wrap5))
									{
										current = _003C_003E7__wrap5.Current;
										if (!f8GuXQK9ETZV4ZNYHg5H(ILw9U3K9qyqDt53tChHU(current), cTMNaSK9koxhYvXUpUfV()))
										{
											if (!f8GuXQK9ETZV4ZNYHg5H(ILw9U3K9qyqDt53tChHU(current), LyEXFkK98VG7XYl59iCt()))
											{
												continue;
											}
											num4 = 15;
										}
										else
										{
											num4 = 4;
										}
										goto IL_085c_2;
									}
									goto end_IL_085c;
								}
								goto IL_0751;
								continue;
								end_IL_085c:
								break;
							}
							goto end_IL_073d;
							IL_0751:
							_003C_003Eu__6 = default;
							num2 = (_003C_003E1__state = -1);
							num4 = 9;
							goto IL_085c;
							end_IL_073d:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap5 != null)
							{
								mVi6CBK9Xty9Ja5YDdc8(_003C_003E7__wrap5);
							}
						}
						_003C_003E7__wrap5 = null;
						goto IL_09eb;
					case 14:
						{
							awaiter = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0a50;
						}
						IL_071a:
						awaiter.GetResult();
						_003C_003E7__wrap5 = ((Classifier)kOnZ6kK9bAcZ062ClQVP(_003CnewTool_003E5__5)).Classes.GetEnumerator();
						goto case 12;
						IL_0114:
						result2 = awaiter5.GetResult();
						_003CpasteRange_003E5__3 = result2;
						awaiter4 = _003Csheet_003E5__2.PutCellExpressionAsync(viDiELClassifyToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELClassifyToolType.tuGDQbSfMd), viDiELClassifyToolType.InputImageLinks[TmK1kyK9e3JueYMM454o(viDiELClassifyToolType)].Expression).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter4;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_01b1;
						IL_09eb:
						awaiter = jlXvPPK9DyhdcmkD1uMZ(g9dRvvK99VhsULl8Wua2(_003CnewTool_003E5__5.SpreadsheetTool));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 14);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0a50;
						IL_01b1:
						awaiter4.GetResult();
						text = (string)OokfSNK9Ohh9VpVyptnK(viDiELClassifyToolType.FindInputFixtureCell(viDiELClassifyToolType._pasteObject));
						cellLocation = viDiELClassifyToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELClassifyToolType.Sy7DM04FkM);
						awaiter = jlXvPPK9DyhdcmkD1uMZ(t51gZJK9I0MtsIa21nPU(viDiELClassifyToolType.Inspect, text, cellLocation));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0248;
						IL_0507:
						awaiter.GetResult();
						awaiter = ((Task)dXLFXUK9ZR2y7ObNsbg3(_003CnewTool_003E5__5.SpreadsheetTool, losvsiK9BaMcu7o8y3b0(rrE36CK9r67aCgB8BqRJ(((AppStepViewModel)S3RipRK9ndg8CuI1F41p(viDiELClassifyToolType)).AppViewModel)))).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 8);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0587;
						IL_0248:
						awaiter.GetResult();
						Xe9hUTK9iNvtMyg5ktih(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49398));
						awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num2 = (_003C_003E1__state = 3);
							_003C_003Eu__4 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_02c3;
						IL_02c3:
						awaiter3.GetResult();
						Xe9hUTK9iNvtMyg5ktih(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
						awaiter = ((Task)uKn1AgK9frb4R6XTHBTP(C6XkRJK9V6HVf33VP0jr(S3RipRK9ndg8CuI1F41p(viDiELClassifyToolType)), viDiELClassifyToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELClassifyToolType.f22Dgr4qgq), viDiELClassifyToolType.EditableRegion)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 4);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0360;
						IL_0587:
						awaiter.GetResult();
						awaiter = jlXvPPK9DyhdcmkD1uMZ(qULE0nK9oY651svh2xa9(gK7iJTK9GceofdKjvWCk(kOnZ6kK9bAcZ062ClQVP(_003CnewTool_003E5__5)), ((EasyBuilderApplicationViewModel)TouvMWK9srQ8ct7I9HJd(S3RipRK9ndg8CuI1F41p(viDiELClassifyToolType))).UILayout.Class2Name, true));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 9);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_060e;
						IL_0360:
						awaiter.GetResult();
						Xe9hUTK9iNvtMyg5ktih(CvsTraceEzb.Info, aRYIiEK9dW5b5d8LMiY2(49466));
						awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 5);
							_003C_003Eu__5 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_03db;
						IL_0a50:
						awaiter.GetResult();
						break;
						IL_03db:
						result3 = awaiter2.GetResult();
						_003CnewTool_003E5__5 = new ViDiELClassifyTool(viDiELClassifyToolType.Inspect, isInitialized: false);
						awaiter = jlXvPPK9DyhdcmkD1uMZ(fYRTclK9lJo7kdYTjuGF(_003CnewTool_003E5__5, result3, _003CpasteRange_003E5__3));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 6);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_045d;
						IL_060e:
						awaiter.GetResult();
						_003CnewTool_003E5__5.ClassificationConfidence.Value = I1Z9ikK9SCDcEFeRFaB1(rrE36CK9r67aCgB8BqRJ(TouvMWK9srQ8ct7I9HJd(viDiELClassifyToolType.Inspect)));
						goto IL_09eb;
						IL_045d:
						awaiter.GetResult();
						if (gfIEKHK9g5uWREh8fe2J(_003CnewTool_003E5__5))
						{
							break;
						}
						if (k1QGXkK9vkaoX8MMXkyP(((EasyBuilderApplicationViewModel)TouvMWK9srQ8ct7I9HJd(S3RipRK9ndg8CuI1F41p(viDiELClassifyToolType))).UILayout))
						{
							awaiter = jlXvPPK9DyhdcmkD1uMZ(dXLFXUK9ZR2y7ObNsbg3(_003CnewTool_003E5__5.SpreadsheetTool, mcRkHhK9P6Eem66rgafd(rrE36CK9r67aCgB8BqRJ(TouvMWK9srQ8ct7I9HJd(S3RipRK9ndg8CuI1F41p(viDiELClassifyToolType))))));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0507;
						}
						awaiter = jlXvPPK9DyhdcmkD1uMZ(((Classifier)kOnZ6kK9bAcZ062ClQVP(_003CnewTool_003E5__5))._AddClass((string)cTMNaSK9koxhYvXUpUfV()));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 10);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_06a9;
						IL_06a9:
						awaiter.GetResult();
						awaiter = ((Task)dXLFXUK9ZR2y7ObNsbg3(_003CnewTool_003E5__5.SpreadsheetTool, LyEXFkK98VG7XYl59iCt())).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 11);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_071a;
					}
					result = _003CnewTool_003E5__5;
				}
				catch (object obj)
				{
					_003C_003E7__wrap3 = obj;
					num3 = 1;
					goto IL_0a74;
				}
				goto end_IL_0026;
				IL_0a74:
				if (num3 == 1)
				{
					awaiter = viDiELClassifyToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 15);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0adc;
				}
				goto IL_0b05;
				IL_0adc:
				awaiter.GetResult();
				SBcHqlK97EmOGGINJxU8(jpqISqK94ohq2vjvHLcq((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
				goto IL_0b05;
				IL_0b05:
				_003C_003E7__wrap3 = null;
				_003Csheet_003E5__2 = null;
				_003CpasteRange_003E5__3 = default;
				end_IL_0026:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Csheet_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0b98;
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
		internal static int TmK1kyK9e3JueYMM454o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OokfSNK9Ohh9VpVyptnK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object t51gZJK9I0MtsIa21nPU(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jlXvPPK9DyhdcmkD1uMZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Xe9hUTK9iNvtMyg5ktih(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S3RipRK9ndg8CuI1F41p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C6XkRJK9V6HVf33VP0jr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uKn1AgK9frb4R6XTHBTP(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aRYIiEK9dW5b5d8LMiY2(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fYRTclK9lJo7kdYTjuGF(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gfIEKHK9g5uWREh8fe2J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELClassifyTool)P_0).HasClasses;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TouvMWK9srQ8ct7I9HJd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k1QGXkK9vkaoX8MMXkyP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderLayout)P_0).ShouldModifyClasses;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rrE36CK9r67aCgB8BqRJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).UILayout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mcRkHhK9P6Eem66rgafd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderLayout)P_0).Class1Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dXLFXUK9ZR2y7ObNsbg3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0)._AddClass((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object losvsiK9BaMcu7o8y3b0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderLayout)P_0).Class2Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kOnZ6kK9bAcZ062ClQVP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELClassifyTool)P_0).SpreadsheetTool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gK7iJTK9GceofdKjvWCk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).ClassifyService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qULE0nK9oY651svh2xa9(object P_0, object P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).SetClassFailsTool((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int I1Z9ikK9SCDcEFeRFaB1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderLayout)P_0).ClassificationConfidence;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cTMNaSK9koxhYvXUpUfV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.ckYLQuEgUo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LyEXFkK98VG7XYl59iCt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.qumL7I7vi1();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ILw9U3K9qyqDt53tChHU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f8GuXQK9ETZV4ZNYHg5H(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YNPnovK9p9eQ4iPvGyfF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mVi6CBK9Xty9Ja5YDdc8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g9dRvvK99VhsULl8Wua2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RefreshJobFailClasses();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jpqISqK94ohq2vjvHLcq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SBcHqlK97EmOGGINJxU8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IxHpfVK9JXpbB3ojsxpn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c4j1tgK9aFbqBrX4Ks6Q()
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

		public static Func<string, string> _003C_003E9__36_0;

		public static Func<PasteBuffer, string> _003C_003E9__36_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MolEkoK96qvFSwxJu0aL();
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
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__36_0(string e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__36_1(PasteBuffer buffer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)CSHSCFK9C72DEShLADXS(49502);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MolEkoK96qvFSwxJu0aL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XnfY67K93UTTgyiGUdnl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V5urgsK9j6xd9e2UqwGc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CSHSCFK9C72DEShLADXS(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__36 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public ViDiELClassifyToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__36(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CaIioGK9RNXFxbt94OHm();
			int num;
			if (qGaqBlK9AhJMnHHZ7pED())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!qGaqBlK9AhJMnHHZ7pED())
				{
					goto IL_008d;
				}
			}
			goto IL_0056;
			IL_009f:
			HkOOHgK9WlSXtJMHPvgC();
			num = 5;
			goto IL_0056;
			IL_008d:
			QoULK3K9TPixCdHYnCjB(this);
			num = 2;
			if (0 == 0)
			{
				goto IL_0056;
			}
			goto IL_009f;
			IL_0056:
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					continue;
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 5:
					break;
				case 0:
				case 1:
					goto IL_009f;
				case 6:
					return;
				}
				break;
			}
			goto IL_008d;
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
			ViDiELClassifyToolType viDiELClassifyToolType = default;
			CvsCellLocation offset3 = default;
			CvsCellLocation offset5 = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 26:
				{
					CvsCellLocation offset2 = new CvsCellLocation(4, 7);
					_003C_003E2__current = new AddCellUpdate(offset2, viDiELClassifyToolType.dGWDIaQ1WM, viDiELClassifyToolType.Localizer);
					num = 27;
					if (true)
					{
						continue;
					}
					goto case 30;
				}
				case 30:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						_003C_003E2__current = new UnclassifedDetectionUpdate(viDiELClassifyToolType.Localizer);
						num = 16;
						continue;
					}
					goto case 0;
				case 2:
				case 3:
					return false;
				case 21:
					return true;
				case 0:
				case 23:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						num = 18;
						if (true)
						{
							continue;
						}
						goto case 11;
					}
					goto case 31;
				case 11:
					_003C_003E2__current = new EditArgumentUpdate(offset3, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec.CSHSCFK9C72DEShLADXS(49502);
					}, 0, null);
					goto case 6;
				default:
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 10;
				case 10:
					_003C_003E2__current = new ExpressionEditUpdate(offset5, viDiELClassifyToolType.pE7DfNaBo8, [MethodImpl(MethodImplOptions.NoInlining)] (string e) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return e;
					});
					_003C_003E1__state = 2;
					return true;
				case 24:
					return true;
				case 9:
					viDiELClassifyToolType = _003C_003E4__this;
					num = 8;
					if (qGaqBlK9AhJMnHHZ7pED())
					{
						continue;
					}
					goto case 13;
				case 13:
					offset5 = new CvsCellLocation(10, 4);
					num = 10;
					continue;
				case 5:
					return true;
				case 27:
					_003C_003E1__state = 1;
					num = 12;
					continue;
				case 1:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					num = 17;
					if (!CaIioGK9RNXFxbt94OHm())
					{
						continue;
					}
					goto case 29;
				case 29:
				{
					CvsCellLocation offset4 = new CvsCellLocation(4, 0);
					_003C_003E2__current = new CellNameUpdate(offset4, (string)llLV52K90yCrn8aSYCdN(7538), newNameIsInternal: false, isSupportSnippet: false);
					_003C_003E1__state = 5;
					num = 21;
					if (true)
					{
						continue;
					}
					goto case 25;
				}
				case 25:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 28;
					continue;
				case 7:
					_003C_003E1__state = 7;
					num = 14;
					continue;
				case 20:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 26;
						continue;
					}
					goto IL_0357;
				case 17:
					_003ClatestVersion_003E5__3 = IriwgrK9yHGmH66H1gcC(viDiELClassifyToolType._pasteObject);
					num = 20;
					continue;
				case 16:
					_003C_003E1__state = 6;
					num = 24;
					continue;
				case 28:
					_003C_003E1__state = 3;
					num = 19;
					if (0 == 0)
					{
						continue;
					}
					goto case 22;
				case 22:
					_003C_003E2__current = new CellNameUpdate(offset, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7936), newNameIsInternal: false, isSupportSnippet: false);
					num = 7;
					continue;
				case 19:
					return true;
				case 8:
					switch (num2)
					{
					case 0:
						break;
					case 5:
						goto IL_0088;
					case 2:
						goto IL_01cf;
					case 6:
						goto IL_01e2;
					case 4:
						goto IL_0226;
					case 3:
						goto IL_0350;
					default:
						goto IL_03a0;
					case 1:
						goto IL_03bc;
					case 8:
						goto IL_040f;
					case 7:
						goto IL_0459;
					}
					_003C_003E1__state = -1;
					num = 1;
					continue;
				case 12:
					return true;
				case 31:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, viDiELClassifyToolType.Localizer);
						_003C_003E1__state = 8;
						num = 4;
						continue;
					}
					break;
				case 4:
					return true;
				case 15:
					num2 = _003C_003E1__state;
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					goto case 18;
				case 18:
					offset = new CvsCellLocation(4, 1);
					num = 22;
					continue;
				case 6:
					_003C_003E1__state = 4;
					num = 5;
					continue;
				case 14:
					return true;
				case 32:
					break;
					IL_0459:
					_003C_003E1__state = -1;
					num = 31;
					continue;
					IL_040f:
					_003C_003E1__state = -1;
					num = 32;
					continue;
					IL_03bc:
					_003C_003E1__state = -1;
					num = 13;
					if (qGaqBlK9AhJMnHHZ7pED())
					{
						continue;
					}
					goto case 31;
					IL_03a0:
					qGaqBlK9AhJMnHHZ7pED();
					num = ((!CaIioGK9RNXFxbt94OHm()) ? 2 : 0);
					continue;
					IL_0350:
					_003C_003E1__state = -1;
					goto IL_0357;
					IL_0226:
					_003C_003E1__state = -1;
					goto IL_022d;
					IL_01e2:
					_003C_003E1__state = -1;
					goto case 0;
					IL_01cf:
					_003C_003E1__state = -1;
					num = 25;
					continue;
					IL_0088:
					_003C_003E1__state = -1;
					num = 30;
					if (true)
					{
						continue;
					}
					goto case 0;
					IL_0357:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						offset3 = new CvsCellLocation(0, 6);
						num = 11;
						continue;
					}
					goto IL_022d;
					IL_022d:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						num = 29;
						continue;
					}
					goto case 30;
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
			_003CGetUpdates_003Ed__36 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__36(0)
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
		internal static void HkOOHgK9WlSXtJMHPvgC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QoULK3K9TPixCdHYnCjB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qGaqBlK9AhJMnHHZ7pED()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CaIioGK9RNXFxbt94OHm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int IriwgrK9yHGmH66H1gcC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object llLV52K90yCrn8aSYCdN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private static readonly Guid[] NqsDcjiV5E;

	private readonly CvsCellLocation tuGDQbSfMd;

	private readonly CvsCellLocation f22Dgr4qgq;

	private readonly CvsCellLocation Sy7DM04FkM;

	private int aTLDRcBCwU;

	[CompilerGenerated]
	private CvsDisplayableRegion fluD4yaRaf;

	private CvsEditableDisplayGraphic[] BdaDlhhRop;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NqsDcjiV5E;
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
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.ViDiELClassify;
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
			return (string)udCCKkZMhcYZMKUT2TV();
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
			return XAMLGraphicKeys.Tools_ClassifyIcon;
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
			return XAMLGraphicKeys.Tools_ClassifyIcon;
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
				(string)WjgnOlZY3aNqSh9gULg(),
				(string)GHQNctZUw4ntyulYcIP()
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
			return aTLDRcBCwU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref aTLDRcBCwU, value, (string)jjv2FdZFcZD2vwNRgGQ(3256));
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
			return fluD4yaRaf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fluD4yaRaf = value;
		}
	}

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PointF.Empty;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELClassifyToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pcftgRZT8OZrEiMSW0a();
		int num = ((!ekxLlKZWPO96toakvUr()) ? 8 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
			case 8:
				_pasteObject = PasteBuffer.FromBytes((byte[])u0DmHcZ04ZtXcUcTWRL());
				num = 6;
				continue;
			case 4:
				aTLDRcBCwU = 130;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				base._002Ector();
				goto case 3;
			case 6:
				tuGDQbSfMd = _pasteObject.GetCellOffset((string)jjv2FdZFcZD2vwNRgGQ(4928));
				goto case 1;
			default:
				num = 1;
				continue;
			case 0:
			case 2:
				lGHuSjZyhPIsoZ8P99X();
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				f22Dgr4qgq = _pasteObject.GetCellOffset((string)jjv2FdZFcZD2vwNRgGQ(5684));
				num = 5;
				continue;
			case 9:
				AddSnippet(_pasteObject);
				num = 10;
				if (ekxLlKZWPO96toakvUr())
				{
					continue;
				}
				break;
			case 5:
				break;
			case 10:
				return;
			}
			Sy7DM04FkM = _pasteObject.GetCellOffset((string)jjv2FdZFcZD2vwNRgGQ(6522));
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__23))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__24))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003COnBeginAddInternal_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = PSCTsQZHYuLpfDZ3q5Q();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (pcftgRZT8OZrEiMSW0a() ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (pcftgRZT8OZrEiMSW0a() ? 4 : 3);
		CvsCell cvsCell = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 5:
				if (((CvsCogCellResult)ODZcbnZuTnwPF5EPOKR(cvsCell)).Value is CvsCogImage)
				{
					num = 2;
					if (ekxLlKZWPO96toakvUr())
					{
						break;
					}
					goto case 0;
				}
				return;
			case 0:
			case 3:
				base.UpdateFeatureGraphics();
				num = 1;
				break;
			case 2:
				v61SnCZhqhpYmxaY4NF(EditableRegion, cvsCell);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				cvsCellLocation = Bkb2IxZmIGFWfpqJooR(pKnCqBZxnZ6rcJ9Hhmg(CurrentInputImageLink));
				num = 6;
				break;
			case 8:
				if (cvsCell != null)
				{
					goto case 4;
				}
				return;
			case 7:
				cvsCell = (CvsCell)mFXWyVZ1OgGLNFhiMXA(VOKl1MZcs0L4r31wUDW(((CvsInSight)FP43T0Z2FxTtVYUMwE8(Ry88sBZNao7lswQnxbq(this))).Results), cvsCellLocation);
				goto case 8;
			default:
				num = 8;
				break;
			case 6:
				if (KYrQgIZQRXG5yY0Cmdk(cvsCellLocation, CvsCellLocation.Invalid))
				{
					num = 7;
					break;
				}
				return;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task OnGraphicChanged(object sender, CvsEditEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!ekxLlKZWPO96toakvUr()) ? 2 : 5);
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (cvsEditableDisplayGraphic != null)
				{
					num = 1;
					continue;
				}
				break;
			case 0:
			case 5:
				cvsEditableDisplayGraphic = rTDkiKZtXBfadLxh9oq(e) as CvsEditableDisplayGraphic;
				num = 4;
				continue;
			case 1:
				if (cvsEditableDisplayGraphic != EditableRegion)
				{
					break;
				}
				goto default;
			default:
				ef7P40ZzYErmHtrYoce(cvsEditableDisplayGraphic);
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BdaDlhhRop;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__35))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__36))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__36(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell dGWDIaQ1WM(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object snippetName = tJLX8gBLfFlFerPjPwv(P_0);
		string location = ((PasteBufferCell)J90EXWBKYt9o4rcmehW(P_0, new CvsCellLocation(4, 0))).Location;
		CvsCellLocation loc = new CvsCellLocation(pJpdlLB54faZLPghxRi(P_0).Row + 4, pJpdlLB54faZLPghxRi(P_0).Column + 7);
		string text = new CvsCellLocation(location).ToString(absoluteRow: true, absoluteColumn: true);
		string text2 = EzSnippet.AssembleFullCellName((string)snippetName, (string)jjv2FdZFcZD2vwNRgGQ(8040), isInternal: true);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = (string)Svw9i0BwWHbU4IOYyMl(jjv2FdZFcZD2vwNRgGQ(8062), text, jjv2FdZFcZD2vwNRgGQ(6970))
		};
		mFOWDsBJRakRwS94ftL(pasteBufferCell, text2);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string pE7DfNaBo8(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsCellLocation cvsCellLocation2 = default;
		string text5 = default;
		CvsCellLocation cvsCellLocation4 = default;
		string text4 = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellLocation locationFromOrigin = default;
		CvsCellLocation cvsCellLocation3 = default;
		string text = default;
		string text3 = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 8:
				cvsCellLocation2 = jRhubMBesq5aDD1WiQQ(P_0, lsjVD4Baf1ewRqc4YBR(jjv2FdZFcZD2vwNRgGQ(8102)));
				num = 7;
				break;
			default:
				text5 = cvsCellLocation4.ToString(absoluteRow: true, absoluteColumn: true);
				num = 3;
				break;
			case 3:
				text4 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				num = 9;
				break;
			case 1:
				locationFromOrigin = P_0.GetLocationFromOrigin((string)jjv2FdZFcZD2vwNRgGQ(8086));
				num = 10;
				break;
			case 6:
				cvsCellLocation4 = jRhubMBesq5aDD1WiQQ(P_0, lsjVD4Baf1ewRqc4YBR(jjv2FdZFcZD2vwNRgGQ(8118)));
				goto default;
			case 10:
				do
				{
					cvsCellLocation3 = jRhubMBesq5aDD1WiQQ(P_0, lsjVD4Baf1ewRqc4YBR(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8094)));
					ekxLlKZWPO96toakvUr();
					if (pcftgRZT8OZrEiMSW0a())
					{
						num = 4;
						continue;
					}
					num = 8;
					break;
				}
				while (pcftgRZT8OZrEiMSW0a());
				break;
			case 0:
				text = locationFromOrigin.ToString(absoluteRow: true, absoluteColumn: true);
				num = 11;
				break;
			case 9:
				text3 = cvsCellLocation2.ToString(absoluteRow: true, absoluteColumn: true);
				text2 = cvsCellLocation3.ToString(absoluteRow: true, absoluteColumn: true);
				num = 0;
				break;
			case 7:
				cvsCellLocation = jRhubMBesq5aDD1WiQQ(P_0, lsjVD4Baf1ewRqc4YBR(jjv2FdZFcZD2vwNRgGQ(8110)));
				num = 6;
				break;
			case 11:
				return (string)XdrC5sBOOgoCdR1NeYH(new string[11]
				{
					(string)jjv2FdZFcZD2vwNRgGQ(8126),
					text,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(8146),
					text2,
					(string)jjv2FdZFcZD2vwNRgGQ(8180),
					text3,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(8222),
					text4,
					(string)jjv2FdZFcZD2vwNRgGQ(8258),
					text5,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970)
				});
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViDiELClassifyToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		NqsDcjiV5E = new Guid[1]
		{
			new Guid((string)jjv2FdZFcZD2vwNRgGQ(8268))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task abBDEmQi7e()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lGHuSjZyhPIsoZ8P99X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u0DmHcZ04ZtXcUcTWRL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ViDiELClassify;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jjv2FdZFcZD2vwNRgGQ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ekxLlKZWPO96toakvUr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pcftgRZT8OZrEiMSW0a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object udCCKkZMhcYZMKUT2TV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.BhZ8MWSfjP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WjgnOlZY3aNqSh9gULg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GHQNctZUw4ntyulYcIP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELTools;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder PSCTsQZHYuLpfDZ3q5Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pKnCqBZxnZ6rcJ9Hhmg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Bkb2IxZmIGFWfpqJooR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KYrQgIZQRXG5yY0Cmdk(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ry88sBZNao7lswQnxbq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FP43T0Z2FxTtVYUMwE8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VOKl1MZcs0L4r31wUDW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mFXWyVZ1OgGLNFhiMXA(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ODZcbnZuTnwPF5EPOKR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v61SnCZhqhpYmxaY4NF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rTDkiKZtXBfadLxh9oq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditEventArgs)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ef7P40ZzYErmHtrYoce(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Fit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tJLX8gBLfFlFerPjPwv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J90EXWBKYt9o4rcmehW(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pJpdlLB54faZLPghxRi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Svw9i0BwWHbU4IOYyMl(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mFOWDsBJRakRwS94ftL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation lsjVD4Baf1ewRqc4YBR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation jRhubMBesq5aDD1WiQQ(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XdrC5sBOOgoCdR1NeYH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}
}
