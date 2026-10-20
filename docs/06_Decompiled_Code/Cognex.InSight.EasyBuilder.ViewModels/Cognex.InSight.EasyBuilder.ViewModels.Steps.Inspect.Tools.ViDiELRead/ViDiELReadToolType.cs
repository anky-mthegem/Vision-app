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
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead.Updates;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Read;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead;

[Export(typeof(EzToolType))]
public class ViDiELReadToolType : EzToolType, IGraphicToolType, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELReadToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ViDiELReadTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ViDiELReadToolType viDiELReadToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					AIUIDGKpJwSYWKuW9qa8();
					num = ((!zw7MT1KpwPtmey3BcG31()) ? 6 : 4);
					break;
				default:
					_003Ctool_003E5__2 = null;
					num = 0;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ViDiELReadTool((InspectStepViewModel)inO3qNKpaaYXLsjYZnNF(viDiELReadToolType), isInitialized: true);
							num3 = 9;
							if (1 == 0)
							{
								goto IL_006f;
							}
							goto IL_00f6;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0178;
						IL_0178:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 5:
								break;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 9:
								goto IL_0093;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 7:
								awaiter.GetResult();
								num3 = 3;
								continue;
							case 1:
							case 6:
								if (!awaiter.IsCompleted)
								{
									break;
								}
								goto case 7;
							case 3:
								viDiELReadToolType.o1eSabWJyy(_003Ctool_003E5__2);
								num3 = 11;
								continue;
							case 0:
								goto IL_0178;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 11:
								result = _003Ctool_003E5__2;
								goto end_IL_004a;
							}
							break;
							IL_0093:
							awaiter = pCoswtKpOt34NoreUZmQ(yXEomQKpe5h3oJo0jB43(_003Ctool_003E5__2, cells, cellRange));
							AIUIDGKpJwSYWKuW9qa8();
							num3 = ((!zw7MT1KpwPtmey3BcG31()) ? 5 : 6);
						}
						goto IL_006f;
						IL_006f:
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						goto IL_00f6;
						end_IL_004a:;
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
				case 1:
				case 4:
					viDiELReadToolType = _003C_003E4__this;
					num = 2;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
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
		internal static object inO3qNKpaaYXLsjYZnNF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yXEomQKpe5h3oJo0jB43(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pCoswtKpOt34NoreUZmQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zw7MT1KpwPtmey3BcG31()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AIUIDGKpJwSYWKuW9qa8()
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
	private struct _003COnBeginAddInternal_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELReadToolType _003C_003E4__this;

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
			if (hl9bEVKpIgxdP5WobUIe())
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
				if (1 == 0)
				{
					goto IL_003f;
				}
			}
			goto IL_03ed;
			IL_0026:
			ViDiELReadToolType viDiELReadToolType = _003C_003E4__this;
			goto IL_0050;
			IL_003f:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_03ed;
			IL_0050:
			try
			{
				CvsCellLocation cvsCellLocation = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					cvsCellLocation = CvsCellLocation.Parse((string)tqrl45KpirB5NGpK1kC6(viDiELReadToolType.CurrentInputImageLink));
					num3 = 13;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 2;
					if (1 == 0)
					{
						goto IL_02c8;
					}
				}
				goto IL_0135;
				IL_02c8:
				w6ZvjhKpoiJh9KNwX9D9(viDiELReadToolType.SearchRegion, GoOnohKpBD5FEV0D2uNr());
				num3 = 8;
				goto IL_0135;
				IL_0135:
				CvsCell imageCell = default;
				double num5 = default;
				double width = default;
				double num4 = default;
				while (true)
				{
					switch (num3)
					{
					case 10:
						viDiELReadToolType.SearchRegion = EditableGraphicHelper.ConstructRegionCenteredToImage(CvsCellLocation.Invalid, imageCell, new SizeF(700f, 170f));
						num5 = 15.0;
						num3 = 16;
						continue;
					case 3:
					case 6:
						width = num4 * 2.0 / 3.0;
						goto case 1;
					case 5:
						eJqeyqKprVbU0kQhYc8a(viDiELReadToolType.CharacterSize, false);
						num3 = 12;
						if (true)
						{
							continue;
						}
						goto case 7;
					case 7:
						awaiter = EeePcAKpSnNI8EnREYEn(viDiELReadToolType.U8kSUYnoRT());
						num3 = 11;
						continue;
					case 18:
						eJqeyqKprVbU0kQhYc8a(viDiELReadToolType.SearchRegion, false);
						oIZaB4KpZka5CjemZ6OC(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.SearchRegion), VDiLmXKpGrLLMpvPFbhJ());
						goto case 9;
					default:
						num3 = 9;
						continue;
					case 8:
						viDiELReadToolType.xYMSIYa2eR = new CvsEditableDisplayGraphic[2] { viDiELReadToolType.CharacterSize, viDiELReadToolType.SearchRegion };
						num3 = 7;
						if (!MgM7WsKpDYTbt1ALxKkA())
						{
							continue;
						}
						goto case 17;
					case 17:
						BQWBmYKpbC9P4faF2LC5(viDiELReadToolType.CharacterSize, GoOnohKpBD5FEV0D2uNr());
						viDiELReadToolType.CharacterSize.SelectedColor = GoOnohKpBD5FEV0D2uNr();
						num3 = 18;
						continue;
					case 1:
					case 4:
						viDiELReadToolType.CharacterSize = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, (double)GuGm3RKpsgeYlIE8hj2R(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.SearchRegion)).X + BrK0q4Kpv0WWC9eP8cI4(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.SearchRegion)) / 2.0, (double)GuGm3RKpsgeYlIE8hj2R(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.SearchRegion)).Y + num5, width, num4, 0.0, 0.0, imageCell);
						num3 = 5;
						continue;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 20;
						continue;
					case 19:
						num2 = (_003C_003E1__state = 0);
						num3 = 14;
						continue;
					case 14:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 15:
						break;
					case 9:
						BQWBmYKpbC9P4faF2LC5(viDiELReadToolType.SearchRegion, GoOnohKpBD5FEV0D2uNr());
						num3 = 15;
						if (true)
						{
							continue;
						}
						goto case 16;
					case 16:
						num4 = ER3MTlKpgimMIQcWpevQ(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.SearchRegion)) - 2.0 * num5;
						_ = 0;
						num3 = ((!hl9bEVKpIgxdP5WobUIe()) ? 1 : 6);
						continue;
					case 12:
						oIZaB4KpZka5CjemZ6OC(qKAOMoKplYg9x4oO8h4k(viDiELReadToolType.CharacterSize), I8D4cfKpPX6XqAqdW78O());
						num3 = 17;
						continue;
					case 11:
						if (!awaiter.IsCompleted)
						{
							num3 = 19;
							if (hl9bEVKpIgxdP5WobUIe())
							{
								continue;
							}
							goto case 13;
						}
						goto case 20;
					case 13:
						imageCell = (CvsCell)ghU7nKKpdJN3WWg8B4Zx(v4DqNKKpfgQRFbnBybBr(S9y3fiKpVUPPAscopfTc(FnqoKrKpnwK1LbMGYslf(viDiELReadToolType))), cvsCellLocation);
						num3 = 10;
						if (hl9bEVKpIgxdP5WobUIe())
						{
							continue;
						}
						goto case 2;
					case 2:
						_003C_003Eu__1 = default;
						num3 = 0;
						continue;
					case 20:
						awaiter.GetResult();
						goto end_IL_0135;
					}
					goto IL_02c8;
					continue;
					end_IL_0135:
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
			goto IL_041a;
			IL_041a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_03ed;
			IL_03ed:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 5:
					goto IL_003f;
				case 2:
				case 3:
					goto IL_0050;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto IL_041a;
				case 4:
					goto IL_041a;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static object tqrl45KpirB5NGpK1kC6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FnqoKrKpnwK1LbMGYslf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object S9y3fiKpVUPPAscopfTc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object v4DqNKKpfgQRFbnBybBr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ghU7nKKpdJN3WWg8B4Zx(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qKAOMoKplYg9x4oO8h4k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double ER3MTlKpgimMIQcWpevQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicRegion)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF GuGm3RKpsgeYlIE8hj2R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicRegion)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double BrK0q4Kpv0WWC9eP8cI4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicRegion)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eJqeyqKprVbU0kQhYc8a(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I8D4cfKpPX6XqAqdW78O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.uWyBVUh1i2();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oIZaB4KpZka5CjemZ6OC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphic)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color GoOnohKpBD5FEV0D2uNr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Cyan;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BQWBmYKpbC9P4faF2LC5(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VDiLmXKpGrLLMpvPFbhJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.SearchRegion;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w6ZvjhKpoiJh9KNwX9D9(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EeePcAKpSnNI8EnREYEn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hl9bEVKpIgxdP5WobUIe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MgM7WsKpDYTbt1ALxKkA()
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
	private struct _003CAddTool_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELReadToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ViDiELReadTool _003CnewTool_003E5__5;

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
			int num = 3;
			if (!kDAwoCKpk1UkPN06FfXD())
			{
				goto IL_001e;
			}
			goto IL_09d4;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = (kDAwoCKpk1UkPN06FfXD() ? 2 : 0);
			goto IL_09d4;
			IL_09d4:
			EzTool result = default;
			ViDiELReadToolType viDiELReadToolType = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<object> awaiter4 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			CvsCellRange result2 = default;
			CvsCellLocation cellLocation = default;
			string text = default;
			CvsCellLocation cellLocation2 = default;
			CvsCellCollection result3 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
				case 2:
					viDiELReadToolType = _003C_003E4__this;
					num = 6;
					continue;
				case 5:
					_003Csheet_003E5__2 = null;
					goto case 0;
				case 6:
					try
					{
						int num3;
						if ((uint)num2 > 7u)
						{
							if (num2 == 8)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_094f;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)YAVitXKppNYKOA4FoK40(((CvsInSight)mqKksOKpEcFcC4uogTuQ(lPYO9XKpqY0oNaninrvU(viDiELReadToolType))).CogSocket);
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
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(viDiELReadToolType._pasteObject, (InspectStepViewModel)lPYO9XKpqY0oNaninrvU(viDiELReadToolType), out var _);
								num4 = 0;
								if (wrlDHGKp8k2CImDY70nm())
								{
								}
								goto IL_0788;
							}
							case 1:
								awaiter4 = _003C_003Eu__2;
								num4 = 33;
								goto IL_0788;
							case 4:
								awaiter5 = _003C_003Eu__4;
								num4 = 38;
								goto IL_0788;
							case 3:
								awaiter4 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 42;
								if (false)
								{
									goto IL_0456;
								}
								goto IL_0788;
							case 6:
								awaiter3 = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num4 = 29;
								goto IL_0788;
							case 5:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 19;
								goto IL_0788;
							case 0:
								awaiter2 = _003C_003Eu__1;
								num4 = 28;
								if (false)
								{
									goto IL_05b9;
								}
								goto IL_0788;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 51;
								if (wrlDHGKp8k2CImDY70nm())
								{
									goto IL_0603;
								}
								goto IL_0788;
							case 7:
								{
									awaiter = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									num4 = 45;
									goto IL_0788;
								}
								IL_0788:
								while (true)
								{
									switch (num4)
									{
									case 51:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 2;
										continue;
									case 1:
										result2 = awaiter2.GetResult();
										num4 = 13;
										continue;
									case 40:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 34;
										if (true)
										{
											continue;
										}
										goto case 50;
									case 50:
										_003C_003Eu__1 = awaiter2;
										num4 = 54;
										continue;
									case 11:
										num2 = (_003C_003E1__state = -1);
										num4 = 7;
										continue;
									case 9:
										num2 = (_003C_003E1__state = -1);
										num4 = 1;
										continue;
									case 37:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 5;
										continue;
									case 8:
									case 30:
										if (!awaiter5.IsCompleted)
										{
											num4 = 20;
											continue;
										}
										goto case 7;
									case 7:
										awaiter5.GetResult();
										num4 = 21;
										continue;
									case 38:
										_003C_003Eu__4 = default;
										num4 = 11;
										if (wrlDHGKp8k2CImDY70nm())
										{
										}
										continue;
									case 34:
										return;
									case 26:
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__5 = awaiter3;
										num4 = 47;
										if (kDAwoCKpk1UkPN06FfXD())
										{
											continue;
										}
										goto case 19;
									case 19:
										num2 = (_003C_003E1__state = -1);
										goto IL_0224;
									case 45:
										awaiter.GetResult();
										viDiELReadToolType.o1eSabWJyy(_003CnewTool_003E5__5);
										num4 = 56;
										if (!wrlDHGKp8k2CImDY70nm())
										{
											continue;
										}
										goto case 10;
									case 10:
									case 43:
										if (!awaiter4.IsCompleted)
										{
											num4 = 46;
											if (true)
											{
												continue;
											}
											goto case 6;
										}
										goto IL_0398;
									case 6:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 53;
										if (kDAwoCKpk1UkPN06FfXD())
										{
											continue;
										}
										goto case 46;
									case 46:
										num2 = (_003C_003E1__state = 1);
										num4 = 39;
										continue;
									case 29:
										num2 = (_003C_003E1__state = -1);
										num4 = 52;
										if (wrlDHGKp8k2CImDY70nm())
										{
										}
										continue;
									case 22:
										if (!awaiter3.IsCompleted)
										{
											num4 = 26;
											continue;
										}
										goto IL_05b9;
									case 48:
									{
										ResourceNode cellToolResourceNode = _003Csheet_003E5__2.GetCellToolResourceNode(cellLocation);
										CogSize cogSize = new CogSize();
										dD2VisKpCCukHhCSxEux(cogSize, r5pcMkKp6L8l7bCPL2C7(YEX6YAKpjYh1iCXeSe3Z(viDiELReadToolType.CharacterSize)));
										WpS0FCKpR9s9Xp7PfnaP(cogSize, lN1cQ4KpAvJMXdSMrbq3(YEX6YAKpjYh1iCXeSe3Z(viDiELReadToolType.CharacterSize)));
										CogSize arg = cogSize;
										awaiter4 = cellToolResourceNode.PutAsync<object>(CdQUGaROfy7He9T0foW.KbIzwHEDLa(49136), arg).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num4 = 17;
											continue;
										}
										goto case 42;
									}
									case 49:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter;
											num4 = 18;
											continue;
										}
										goto case 2;
									case 27:
										num2 = (_003C_003E1__state = 5);
										num4 = 32;
										continue;
									case 55:
										num2 = (_003C_003E1__state = -1);
										goto IL_0398;
									case 25:
										_003C_003Eu__4 = awaiter5;
										num4 = 6;
										if (true)
										{
											continue;
										}
										goto case 20;
									case 20:
										num2 = (_003C_003E1__state = 4);
										num4 = 25;
										continue;
									case 54:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 31;
										continue;
									case 33:
										_003C_003Eu__2 = default;
										num4 = 55;
										continue;
									case 53:
										return;
									case 13:
										_003CpasteRange_003E5__3 = result2;
										num4 = 36;
										continue;
									case 23:
										return;
									case 47:
										break;
									case 41:
										text = (string)LhApsXKp4MLO6PKVsnO0(viDiELReadToolType.FindInputFixtureCell(viDiELReadToolType._pasteObject));
										cellLocation2 = viDiELReadToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELReadToolType.QkhS6qDrXp);
										num4 = 4;
										continue;
									case 36:
										goto IL_04bd;
									case 14:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 42:
										awaiter4.GetResult();
										awaiter5 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										goto case 8;
									case 32:
										_003C_003Eu__3 = awaiter;
										num4 = 14;
										continue;
									case 44:
										_003C_003Eu__2 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 23;
										continue;
									case 31:
										return;
									case 52:
										goto IL_05b9;
									case 39:
										goto IL_05d2;
									case 15:
										return;
									case 24:
										goto IL_0603;
									case 2:
										awaiter.GetResult();
										num4 = 12;
										continue;
									case 16:
										if (awaiter.IsCompleted)
										{
											goto case 45;
										}
										num4 = 3;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
										num2 = (_003C_003E1__state = 7);
										_003C_003Eu__3 = awaiter;
										num4 = 37;
										continue;
									case 4:
										awaiter = tdXRECKp3Hn1oVow3BPf(TxaqNOKp7xxmfZak3oY1(viDiELReadToolType.Inspect, text, cellLocation2));
										num4 = 49;
										if (true)
										{
											continue;
										}
										goto case 18;
									case 18:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 15;
										if (kDAwoCKpk1UkPN06FfXD())
										{
											continue;
										}
										goto case 21;
									case 21:
										awaiter = ((Task)CT985kKpWfJmWxLghHb4(mqKksOKpEcFcC4uogTuQ(lPYO9XKpqY0oNaninrvU(viDiELReadToolType)), viDiELReadToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELReadToolType.cL2SuxNVTD), viDiELReadToolType.SearchRegion)).GetAwaiter();
										if (awaiter.IsCompleted)
										{
											goto IL_0224;
										}
										num4 = 27;
										if (!wrlDHGKp8k2CImDY70nm())
										{
											continue;
										}
										goto case 28;
									case 28:
										_003C_003Eu__1 = default;
										num4 = 9;
										continue;
									case 5:
										return;
									case 35:
										num2 = (_003C_003E1__state = 0);
										num4 = 50;
										if (wrlDHGKp8k2CImDY70nm())
										{
										}
										continue;
									case 17:
										num2 = (_003C_003E1__state = 3);
										goto case 44;
									default:
										num4 = 44;
										if (kDAwoCKpk1UkPN06FfXD())
										{
											continue;
										}
										goto case 0;
									case 0:
										awaiter2 = viDiELReadToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num4 = 35;
											continue;
										}
										goto case 1;
									case 12:
										cellLocation = viDiELReadToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELReadToolType.vhSSFsE4Ak);
										num4 = 48;
										continue;
									case 56:
										{
											result = _003CnewTool_003E5__5;
											goto end_IL_00b1;
										}
										IL_0398:
										awaiter4.GetResult();
										num4 = 41;
										continue;
										IL_0224:
										awaiter.GetResult();
										awaiter3 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										num4 = 22;
										continue;
									}
									break;
									IL_04bd:
									awaiter4 = _003Csheet_003E5__2.PutCellExpressionAsync(viDiELReadToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELReadToolType.XO1SdQDZ00), (string)MnbhsYKp9eik31GP7Zwk(viDiELReadToolType.InputImageLinks[MfvrqmKpXl6xn7XctQUr(viDiELReadToolType)])).GetAwaiter();
									_ = 1;
									num4 = (wrlDHGKp8k2CImDY70nm() ? 8 : 43);
								}
								goto IL_0456;
								IL_0603:
								_003CnewTool_003E5__5 = new ViDiELReadTool((InspectStepViewModel)lPYO9XKpqY0oNaninrvU(viDiELReadToolType), isInitialized: false);
								awaiter = ((Task)WgSgQ4KpTmLI3UqF7q1m(_003CnewTool_003E5__5, result3, _003CpasteRange_003E5__3)).GetAwaiter();
								num4 = 16;
								goto IL_0788;
								IL_0456:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
								IL_05b9:
								result3 = awaiter3.GetResult();
								num4 = 24;
								if (wrlDHGKp8k2CImDY70nm())
								{
									goto IL_05d2;
								}
								goto IL_0788;
								IL_05d2:
								_003C_003Eu__2 = awaiter4;
								num4 = 40;
								if (1 == 0)
								{
									return;
								}
								goto IL_0788;
								end_IL_00b1:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_08e8;
						}
						goto end_IL_0079;
						IL_08e8:
						if (num3 == 1)
						{
							awaiter = tdXRECKp3Hn1oVow3BPf(viDiELReadToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 8);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_094f;
						}
						goto IL_0978;
						IL_094f:
						awaiter.GetResult();
						cQowsfKp0Uwx8fTEiI9j(CdOVOVKpyvK9PPNPBXxd((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0978;
						IL_0978:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0079:;
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
					continue;
				case 7:
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
		internal static object lPYO9XKpqY0oNaninrvU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mqKksOKpEcFcC4uogTuQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YAVitXKppNYKOA4FoK40(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MfvrqmKpXl6xn7XctQUr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MnbhsYKp9eik31GP7Zwk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LhApsXKp4MLO6PKVsnO0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TxaqNOKp7xxmfZak3oY1(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tdXRECKp3Hn1oVow3BPf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YEX6YAKpjYh1iCXeSe3Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double r5pcMkKp6L8l7bCPL2C7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicRegion)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dD2VisKpCCukHhCSxEux(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CogSize)P_0).Height = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double lN1cQ4KpAvJMXdSMrbq3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicRegion)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WpS0FCKpR9s9Xp7PfnaP(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CogSize)P_0).Width = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CT985kKpWfJmWxLghHb4(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WgSgQ4KpTmLI3UqF7q1m(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CdOVOVKpyvK9PPNPBXxd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cQowsfKp0Uwx8fTEiI9j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kDAwoCKpk1UkPN06FfXD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wrlDHGKp8k2CImDY70nm()
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

		public static Func<PasteBuffer, string> _003C_003E9__52_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VklOKhKpY1DGC69BMeJi();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VklOKhKpY1DGC69BMeJi();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__52_0(PasteBuffer snippet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)EEbJO8KpUROEl1Y4tcAZ(49166);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VklOKhKpY1DGC69BMeJi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YctjufKpF1LhlZbVs0Jo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fDjgD9KpMuSDGMLfj4FS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EEbJO8KpUROEl1Y4tcAZ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__52 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public ViDiELReadToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__52(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q4K01TKpxgHXiM2vZNnP();
			int num = ((!F0Vmw4KpH3C033RhrGcy()) ? 3 : 5);
			while (true)
			{
				switch (num)
				{
				case 1:
					xorGowKpmYkUVJ1NyATU(this);
					goto case 2;
				case 2:
				case 3:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003El__initialThreadId = SL7dcwKpQMBkZLiG5pKt();
					num = 6;
					break;
				case 0:
				case 5:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					num = 1;
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
			int num = 4;
			ViDiELReadToolType viDiELReadToolType = default;
			CvsCellLocation offset2 = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003E1__state = 4;
					return true;
				case 16:
					_003C_003E2__current = new AddFlexFieldingAndCharFindThreshold(viDiELReadToolType.Localizer);
					num = 3;
					continue;
				case 13:
					if (_003CcurrentVersion_003E5__2 >= 3)
					{
						goto case 23;
					}
					offset2 = new CvsCellLocation(4, 0);
					goto case 20;
				default:
					num = 20;
					continue;
				case 9:
					_003C_003E2__current = new AddCellUpdate(offset, viDiELReadToolType.phFSpaw5ki, viDiELReadToolType.Localizer);
					num = 19;
					continue;
				case 2:
					return true;
				case 11:
					return true;
				case 24:
					_003C_003E1__state = 1;
					return true;
				case 12:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						num = 16;
						continue;
					}
					goto IL_011d;
				case 23:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						num = 22;
						continue;
					}
					goto case 12;
				case 8:
					return false;
				case 19:
					_003C_003E1__state = 2;
					goto case 0;
				case 1:
					switch (num2)
					{
					case 4:
						break;
					case 5:
						goto IL_0116;
					case 3:
						goto IL_013c;
					case 1:
						goto IL_0156;
					case 0:
						goto IL_019e;
					default:
						goto IL_01e8;
					case 2:
						goto IL_031c;
					case 6:
						goto IL_032f;
					}
					_003C_003E1__state = -1;
					num = 12;
					continue;
				case 15:
					viDiELReadToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 6:
				case 21:
					_003C_003E2__current = (ISnippetUpdate)hr35wiKpcmHdhHpbrfrw(LZDofbKp2hL4hiF2WMG2(6698), false);
					num = 24;
					continue;
				case 17:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, viDiELReadToolType.Localizer);
					_003C_003E1__state = 6;
					num = 18;
					continue;
				case 7:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					num = 14;
					if (F0Vmw4KpH3C033RhrGcy())
					{
						continue;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					num = 15;
					continue;
				case 20:
					_003C_003E2__current = new EditArgumentUpdate(offset2, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer snippet) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec.EEbJO8KpUROEl1Y4tcAZ(49166);
					}, 0, null);
					_003C_003E1__state = 3;
					num = 11;
					continue;
				case 3:
					_003C_003E1__state = 5;
					num = 2;
					if (!Q4K01TKpxgHXiM2vZNnP())
					{
						continue;
					}
					goto case 14;
				case 14:
					_003ClatestVersion_003E5__3 = oGZ56aKpN7OFA95GY1I0(viDiELReadToolType._pasteObject);
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						F0Vmw4KpH3C033RhrGcy();
						num = ((!Q4K01TKpxgHXiM2vZNnP()) ? 21 : 0);
						continue;
					}
					goto case 13;
				case 0:
				case 10:
					return true;
				case 18:
					return true;
				case 22:
					_003C_003E2__current = new PretrainedModelSelectionUpdate(viDiELReadToolType.Localizer);
					num = 5;
					continue;
				case 25:
					break;
					IL_011d:
					if (_003CcurrentVersion_003E5__2 >= _003ClatestVersion_003E5__3)
					{
						break;
					}
					num = 17;
					if (0 == 0)
					{
						continue;
					}
					goto case 11;
					IL_032f:
					_003C_003E1__state = -1;
					num = 25;
					if (F0Vmw4KpH3C033RhrGcy())
					{
						continue;
					}
					goto case 22;
					IL_031c:
					_003C_003E1__state = -1;
					num = 13;
					continue;
					IL_01e8:
					num = 8;
					if (!Q4K01TKpxgHXiM2vZNnP())
					{
						continue;
					}
					goto case 15;
					IL_019e:
					_003C_003E1__state = -1;
					num = 7;
					continue;
					IL_0156:
					_003C_003E1__state = -1;
					offset = new CvsCellLocation(2, 3);
					num = 9;
					continue;
					IL_013c:
					_003C_003E1__state = -1;
					num = 23;
					continue;
					IL_0116:
					_003C_003E1__state = -1;
					goto IL_011d;
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
			_003CGetUpdates_003Ed__52 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__52(0)
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
		internal static void xorGowKpmYkUVJ1NyATU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int SL7dcwKpQMBkZLiG5pKt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F0Vmw4KpH3C033RhrGcy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q4K01TKpxgHXiM2vZNnP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oGZ56aKpN7OFA95GY1I0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LZDofbKp2hL4hiF2WMG2(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hr35wiKpcmHdhHpbrfrw(object P_0, bool isSupportSnippet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellNameUpdate.MakeInternal((string)P_0, isSupportSnippet);
		}
	}

	private static readonly Guid[] LRSSAo9bYW;

	private readonly CvsCellLocation XO1SdQDZ00;

	private readonly CvsCellLocation QkhS6qDrXp;

	private readonly CvsCellLocation cL2SuxNVTD;

	private readonly CvsCellLocation vhSSFsE4Ak;

	private EZBReadAdapter BL8SXXQjGr;

	private readonly Dictionary<string, ViDiELReadTool> LeISohMhrs;

	private int DqUSSGRKt3;

	[CompilerGenerated]
	private CvsDisplayableRegion EQtSD9kTTE;

	[CompilerGenerated]
	private CvsDisplayableRegion wVVS3JIld5;

	private CvsEditableDisplayGraphic[] xYMSIYa2eR;

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
			int num = 0;
			if (!dnQUBSrM7YxY5AeIoDy())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 0:
					base.Inspect = value;
					gylgfXrFiYsiI0GObXG();
					num = (dnQUBSrM7YxY5AeIoDy() ? 4 : 3);
					continue;
				case 1:
				case 3:
					BL8SXXQjGr = new EZBReadAdapter(base.Inspect, h16ozLEv3R);
					break;
				case 5:
					return;
				}
				ReadAdapterBase.Register(BL8SXXQjGr);
				num = 5;
			}
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
			return LRSSAo9bYW;
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
			return (string)RHRLbKrNGvi5FAy4uRB();
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
			return (string)CT783pr2f7F5yO4jlpL();
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
			return XAMLGraphicKeys.Tools_ReadIcon;
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
			return XAMLGraphicKeys.Tools_ReadIcon;
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
				(string)DsRiBYrcCeX0JuP8KsJ(),
				(string)g00N45r1GETDiDiRAGL()
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
			return DqUSSGRKt3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref DqUSSGRKt3, value, (string)NVahtBrHt7e6wPW2lMa(3256));
		}
	}

	public CvsDisplayableRegion CharacterSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EQtSD9kTTE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EQtSD9kTTE = value;
		}
	}

	public CvsDisplayableRegion SearchRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wVVS3JIld5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wVVS3JIld5 = value;
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
	public ViDiELReadToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 10:
				LeISohMhrs = new Dictionary<string, ViDiELReadTool>();
				num = 1;
				break;
			case 2:
				vhSSFsE4Ak = _pasteObject.GetCellOffset((string)NVahtBrHt7e6wPW2lMa(6626));
				num = 10;
				break;
			case 3:
			case 4:
				_pasteObject = PasteBuffer.FromBytes((byte[])hxEmvqrU4a5Wrwv2odw());
				num = 0;
				break;
			case 6:
				GIOEYbrY8FDUKL5URKE();
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				XO1SdQDZ00 = _pasteObject.GetCellOffset((string)NVahtBrHt7e6wPW2lMa(4928));
				QkhS6qDrXp = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
				goto default;
			case 9:
				base._002Ector();
				_ = 0;
				num = (gylgfXrFiYsiI0GObXG() ? 4 : 7);
				break;
			case 1:
				AddSnippet(_pasteObject);
				num = 11;
				break;
			default:
				cL2SuxNVTD = _pasteObject.GetCellOffset((string)NVahtBrHt7e6wPW2lMa(6650));
				num = 2;
				break;
			case 8:
				DqUSSGRKt3 = 135;
				num = 9;
				break;
			case 11:
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
		EZBReadAdapter bL8SXXQjGr = BL8SXXQjGr;
		if (bL8SXXQjGr != null)
		{
			C8KHE3rxy5YNhHgu2mS(bL8SXXQjGr);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void h16ozLEv3R(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (LeISohMhrs.TryGetValue(P_0, out var value))
		{
			DyFSEZrQxOKQisPDnn6(aZ9bvwrm98ZQ6tLQ2vU(value), P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__33))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__34))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003COnBeginAddInternal_003Ed__34 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				if (gylgfXrFiYsiI0GObXG())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
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
		return xYMSIYa2eR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__45))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__45 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!gylgfXrFiYsiI0GObXG()) ? 3 : 8);
		CvsCell cvsCell = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				cViIfKPaWtIWvObsKCs(CharacterSize, cvsCell);
				num = 10;
				break;
			case 7:
				cvsCell = (CvsCell)X8V1jSP5JEUdc9VbE4X(((CvsResultSet)wx1EuaPKowdj3Fn3Zqi(mv3jhSPLE87a1lKCZ90(d7LyoQrzMU8wYZNSW6c(this)))).Cells, cvsCellLocation);
				num = 5;
				break;
			case 1:
			case 3:
				cvsCellLocation = Ls6i4ErhQY1ACyPpCD0(tcYT0YruIbqhsXoiA1I(CurrentInputImageLink));
				num = 6;
				break;
			case 0:
			case 8:
				base.UpdateFeatureGraphics();
				goto case 1;
			case 6:
				if (q0G7E5rtwnCR4Z04WOg(cvsCellLocation, CvsCellLocation.Invalid))
				{
					num = 7;
					break;
				}
				return;
			case 5:
				if (cvsCell != null)
				{
					goto case 9;
				}
				return;
			default:
				num = 9;
				break;
			case 9:
				if (muDNrcPJlFjwT3XCs69(PvqhmCPwrYBnrjq26Sc(cvsCell)) is CvsCogImage)
				{
					num = 4;
					break;
				}
				return;
			case 4:
				EditableGraphicHelper.UpdateEditBounds(SearchRegion, cvsCell);
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void o1eSabWJyy(ViDiELReadTool P_0)
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
			case 0:
				LeISohMhrs[(string)hWerRoPem8m8XalrlHE(P_0)].FocusChanged -= TpoS5D6JhI;
				_ = 0;
				num = ((!gylgfXrFiYsiI0GObXG()) ? 1 : 5);
				continue;
			case 2:
			case 5:
				OAkGEYPO0m0wM1GRSr1(P_0, new EventHandler(TpoS5D6JhI));
				break;
			case 4:
				if (LeISohMhrs.ContainsKey((string)hWerRoPem8m8XalrlHE(P_0)))
				{
					num = 0;
					if (!dnQUBSrM7YxY5AeIoDy())
					{
						continue;
					}
					break;
				}
				goto case 2;
			case 6:
				return;
			}
			LeISohMhrs[(string)hWerRoPem8m8XalrlHE(P_0)] = P_0;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TpoS5D6JhI(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gylgfXrFiYsiI0GObXG())
		{
			num = 8;
			if (dnQUBSrM7YxY5AeIoDy())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0053;
		IL_003b:
		object obj;
		ViDiELReadTool viDiELReadTool = obj as ViDiELReadTool;
		goto IL_00ba;
		IL_009d:
		object obj2 = d7LyoQrzMU8wYZNSW6c(this);
		InternalCheckBoxViewModel internalCheckBoxViewModel = default;
		if (obj2 != null)
		{
			obj = ((AppStepViewModel)obj2).btvmHNqEjR((string)cePyDQPILJgDWQdp7MH(internalCheckBoxViewModel));
			goto IL_003b;
		}
		goto IL_002a;
		IL_00ba:
		if (viDiELReadTool != null)
		{
			num = 7;
			if (gylgfXrFiYsiI0GObXG())
			{
				goto IL_0053;
			}
			goto IL_00d0;
		}
		return;
		IL_00d0:
		if (internalCheckBoxViewModel != null)
		{
			num = 5;
			goto IL_0053;
		}
		return;
		IL_0053:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				break;
			default:
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				o1eSabWJyy(viDiELReadTool);
				num = 2;
				continue;
			case 5:
				goto IL_009d;
			case 1:
				goto IL_00ba;
			case 4:
				goto IL_00d0;
			case 0:
			case 8:
				internalCheckBoxViewModel = P_0 as InternalCheckBoxViewModel;
				num = 4;
				continue;
			case 2:
				a2PuvyPDeSZeLwRniQm(BL8SXXQjGr, P_0, P_1);
				num = 9;
				if (true)
				{
					continue;
				}
				return;
			case 9:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		obj = null;
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task OnGraphicChanged(object sender, CvsEditEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (dnQUBSrM7YxY5AeIoDy())
		{
			goto IL_001e;
		}
		goto IL_00c2;
		IL_00c2:
		RectangleF rectangleF = default;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		RectangleF bounds = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 3:
				PlmOmBPfJ7IOk2PULl3(CharacterSize, rectangleF);
				num = 11;
				continue;
			case 1:
			case 8:
				if (cvsEditableDisplayGraphic != null)
				{
					num = 5;
					continue;
				}
				goto IL_0158;
			case 2:
				cvsEditableDisplayGraphic = IY7Cu3PihJbb98yapkR(e) as CvsEditableDisplayGraphic;
				gylgfXrFiYsiI0GObXG();
				if (dnQUBSrM7YxY5AeIoDy())
				{
					num = 10;
					if (gylgfXrFiYsiI0GObXG())
					{
						continue;
					}
					goto case 3;
				}
				num = 8;
				continue;
			case 5:
				if (cvsEditableDisplayGraphic == CharacterSize)
				{
					num = 4;
					if (gylgfXrFiYsiI0GObXG())
					{
						continue;
					}
					goto case 9;
				}
				if (cvsEditableDisplayGraphic == SearchRegion)
				{
					num = 0;
					continue;
				}
				goto IL_0158;
			case 9:
				bounds = y3IkENPVXPeE96dHVJp(CharacterSize);
				goto IL_011f;
			default:
				num = 6;
				if (!dnQUBSrM7YxY5AeIoDy())
				{
					continue;
				}
				goto IL_0107;
			case 7:
			case 10:
				goto IL_0107;
			case 6:
				goto IL_011f;
			case 4:
				k9OanXPnqxDkaOk4AEp(cvsEditableDisplayGraphic);
				num = 9;
				continue;
			case 11:
				goto IL_0158;
			}
			break;
		}
		goto IL_001e;
		IL_011f:
		SearchRegion.FitToContain(bounds);
		goto IL_0158;
		IL_0158:
		return (Task)IWDx4UPdiIyk3t169Df();
		IL_001e:
		k9OanXPnqxDkaOk4AEp(cvsEditableDisplayGraphic);
		goto IL_0107;
		IL_0107:
		rectangleF = y3IkENPVXPeE96dHVJp(SearchRegion);
		num = 3;
		if (true)
		{
			goto IL_00c2;
		}
		goto IL_011f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__52))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__52(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell phFSpaw5ki(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!gylgfXrFiYsiI0GObXG())
		{
			goto IL_001e;
		}
		goto IL_003a;
		IL_001e:
		CvsCellLocation cvsCellLocation = default;
		string text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
		goto IL_0098;
		IL_003a:
		string name = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				goto IL_006b;
			default:
				goto IL_0098;
			case 0:
			case 1:
				cvsCellLocation = new CvsCellLocation((string)WE3RMOPs7StmaJbCRRP(pJ1pyhPgYmT3CEarcy0(P_0, vhSSFsE4Ak)));
				num = 5;
				if (gylgfXrFiYsiI0GObXG())
				{
					continue;
				}
				goto case 6;
			case 6:
			{
				PasteBufferCell pasteBufferCell = new PasteBufferCell(new CvsCellLocation(cvsCellLocation.Row + 2, P_0.Origin.Column + 3));
				s388BkPr4CxGO6RHqo1(pasteBufferCell, Bxb0BnPveh40oLSW6OW(NVahtBrHt7e6wPW2lMa(6928), text, NVahtBrHt7e6wPW2lMa(6970)));
				pasteBufferCell.Name = name;
				return pasteBufferCell;
			}
			}
			break;
			IL_006b:
			name = EzSnippet.AssembleFullCellName((string)aKuOVNPll3J5IHsoRZc(P_0), CdQUGaROfy7He9T0foW.KbIzwHEDLa(6772));
			_ = 1;
			num = (dnQUBSrM7YxY5AeIoDy() ? 4 : 0);
		}
		goto IL_001e;
		IL_0098:
		cvsCellLocation = P_0.Origin;
		num = 6;
		goto IL_003a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViDiELReadToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GIOEYbrY8FDUKL5URKE();
		LRSSAo9bYW = new Guid[1]
		{
			new Guid((string)NVahtBrHt7e6wPW2lMa(6976))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task U8kSUYnoRT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GIOEYbrY8FDUKL5URKE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hxEmvqrU4a5Wrwv2odw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ViDiELRead;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NVahtBrHt7e6wPW2lMa(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gylgfXrFiYsiI0GObXG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dnQUBSrM7YxY5AeIoDy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C8KHE3rxy5YNhHgu2mS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aZ9bvwrm98ZQ6tLQ2vU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELReadTool)P_0).FlexibleFielding;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DyFSEZrQxOKQisPDnn6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EditStringViewModel)P_0).Value = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RHRLbKrNGvi5FAy4uRB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELRead;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CT783pr2f7F5yO4jlpL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELReadDescription;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DsRiBYrcCeX0JuP8KsJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g00N45r1GETDiDiRAGL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELTools;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tcYT0YruIbqhsXoiA1I(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Ls6i4ErhQY1ACyPpCD0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q0G7E5rtwnCR4Z04WOg(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d7LyoQrzMU8wYZNSW6c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mv3jhSPLE87a1lKCZ90(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wx1EuaPKowdj3Fn3Zqi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X8V1jSP5JEUdc9VbE4X(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PvqhmCPwrYBnrjq26Sc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object muDNrcPJlFjwT3XCs69(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cViIfKPaWtIWvObsKCs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hWerRoPem8m8XalrlHE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELEzToolBase)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OAkGEYPO0m0wM1GRSr1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELReadTool)P_0).FocusChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cePyDQPILJgDWQdp7MH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a2PuvyPDeSZeLwRniQm(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EZBReadAdapter)P_0).FocusOnPropertyChanged(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IY7Cu3PihJbb98yapkR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditEventArgs)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k9OanXPnqxDkaOk4AEp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Fit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF y3IkENPVXPeE96dHVJp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).BoundingBox;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PlmOmBPfJ7IOk2PULl3(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).FitWithin(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IWDx4UPdiIyk3t169Df()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aKuOVNPll3J5IHsoRZc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pJ1pyhPgYmT3CEarcy0(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WE3RMOPs7StmaJbCRRP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bxb0BnPveh40oLSW6OW(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s388BkPr4CxGO6RHqo1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}
}
