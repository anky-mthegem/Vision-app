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
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId.ReadIdUpdates;
using Cognex.InSight.Graphic;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId;

[Export(typeof(EzToolType))]
public class ReadIdToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ReadIdToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ReadIdTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (nIFWgUK7cOK25q6w6KB2())
			{
				goto IL_001e;
			}
			goto IL_01dd;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 0;
			if (SwrHsYK72LKTSI74C1au())
			{
				num = 5;
				if (nIFWgUK7cOK25q6w6KB2())
				{
				}
			}
			else
			{
				num = 0;
				if (false)
				{
					goto IL_0225;
				}
			}
			goto IL_01dd;
			IL_0225:
			EzTool result = default;
			_003C_003Et__builder.SetResult(result);
			num = 7;
			goto IL_01dd;
			IL_01dd:
			ReadIdToolType readIdToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 3:
					_003Ctool_003E5__2 = null;
					num = 4;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ReadIdTool((InspectStepViewModel)d8xTjyK71Qn1asMacTO0(readIdToolType), isInitialized: true);
							num3 = 7;
							if (nIFWgUK7cOK25q6w6KB2())
							{
								goto IL_007e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00bb;
						IL_0152:
						num2 = (_003C_003E1__state = 0);
						goto IL_0094;
						IL_0094:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_007e:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							goto IL_00bb;
						}
						goto IL_013f;
						IL_013f:
						awaiter.GetResult();
						num3 = 10;
						if (0 == 0)
						{
							goto IL_00bb;
						}
						goto IL_0152;
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								break;
							case 3:
							case 5:
								goto IL_0094;
							default:
								num3 = 8;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 7:
								goto IL_010c;
							case 9:
								goto IL_013f;
							case 0:
								goto IL_0152;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								return;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0056;
							}
							break;
							IL_010c:
							awaiter = dnOOdSK7hNqjJIF5m0SI(dACyPbK7uMyfNn6gEr3p(_003Ctool_003E5__2, cells, cellRange));
							_ = 1;
							num3 = (nIFWgUK7cOK25q6w6KB2() ? 5 : 6);
						}
						goto IL_007e;
						end_IL_0056:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					readIdToolType = _003C_003E4__this;
					goto case 0;
				case 4:
					goto IL_0225;
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
		internal static object d8xTjyK71Qn1asMacTO0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dACyPbK7uMyfNn6gEr3p(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter dnOOdSK7hNqjJIF5m0SI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SwrHsYK72LKTSI74C1au()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nIFWgUK7cOK25q6w6KB2()
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

		public ReadIdToolType _003C_003E4__this;

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
			CvsCellLocation cvsCellLocation = default;
			ReadIdToolType readIdToolType = default;
			TaskAwaiter awaiter = default;
			CvsCell imageCell = default;
			CvsCogRectangle acquired2DImageBounds = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cvsCellLocation = KAC4ogK3Km2FC7qNLrUG(s1Ynp2K3LrWBvN8PSKME(readIdToolType.CurrentInputImageLink));
							_ = 0;
							if (biutH7K7tF7rcVkEQFpa())
							{
								num3 = 3;
								if (false)
								{
									goto IL_0047;
								}
							}
							else
							{
								num3 = 2;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 14;
							if (false)
							{
								goto IL_01d8;
							}
						}
						goto IL_00bf;
						IL_0047:
						imageCell = (CvsCell)OfCup8K3JICxQHTas1SV(f5vnN1K3wX79jy78EGhu(((CvsInSight)XUr5TiK35FDWMeRq0mwj(readIdToolType)).Results), cvsCellLocation);
						acquired2DImageBounds = readIdToolType.GetAcquired2DImageBounds();
						num3 = 13;
						goto IL_00bf;
						IL_00bf:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 3:
								break;
							case 14:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 4:
								tBvfx7K3ipLYVxFxl2rU(readIdToolType.Region, eiFAwxK3DCIN9GHUkQdl());
								num3 = 9;
								continue;
							case 5:
								awaiter = oox7vkK3Vt8GPkVMwvo8(readIdToolType.EA9flvfSDS());
								goto default;
							default:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 6;
									continue;
								}
								goto case 15;
							case 11:
								lWrXqhK3OU5f5hftNyV9(readIdToolType.Region, false);
								num3 = 10;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								if (XnbfhZK7zMxOtiE8JVNu())
								{
								}
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 9:
								FvZHlHK3nZZVFJaucgrr(readIdToolType.Region, eiFAwxK3DCIN9GHUkQdl());
								readIdToolType.yxIfHZPqWd = new CvsEditableDisplayGraphic[1] { readIdToolType.Region };
								num3 = 5;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								continue;
							case 8:
								return;
							case 10:
								goto IL_01d8;
							case 13:
								readIdToolType.Region = EditableGraphicHelper.ConstructRegionCenteredToImage(CvsCellLocation.Invalid, imageCell, new SizeF((float)NqMVBBK3apjlqt8HXOVe(acquired2DImageBounds) / 4f, (float)QFVE7MK3eJvhuNHsCuHS(acquired2DImageBounds) / 4f));
								num3 = 11;
								continue;
							case 15:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_0047;
						IL_01d8:
						((CvsGraphic)MSpVXxK3IZE1HL8OqSHn(readIdToolType.Region)).Label = Resources.SearchRegion;
						num3 = 4;
						goto IL_00bf;
						end_IL_0018:;
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
					readIdToolType = _003C_003E4__this;
					biutH7K7tF7rcVkEQFpa();
					num = (XnbfhZK7zMxOtiE8JVNu() ? 5 : 0);
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (false)
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
		internal static object s1Ynp2K3LrWBvN8PSKME(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation KAC4ogK3Km2FC7qNLrUG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.Parse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XUr5TiK35FDWMeRq0mwj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object f5vnN1K3wX79jy78EGhu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OfCup8K3JICxQHTas1SV(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double NqMVBBK3apjlqt8HXOVe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double QFVE7MK3eJvhuNHsCuHS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lWrXqhK3OU5f5hftNyV9(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MSpVXxK3IZE1HL8OqSHn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color eiFAwxK3DCIN9GHUkQdl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Cyan;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tBvfx7K3ipLYVxFxl2rU(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FvZHlHK3nZZVFJaucgrr(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oox7vkK3Vt8GPkVMwvo8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool biutH7K7tF7rcVkEQFpa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XnbfhZK7zMxOtiE8JVNu()
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
	private struct _003CAddTool_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ReadIdToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ReadIdTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!t9ZUWiK3d2935vRnpsWe())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_0820;
			IL_0866:
			_003Csheet_003E5__2 = null;
			num = 3;
			goto IL_0820;
			IL_0820:
			ReadIdToolType readIdToolType = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					goto IL_0866;
				case 1:
				case 6:
					readIdToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						continue;
					}
					return;
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
				if ((uint)num2 > 6u)
				{
					if (num2 == 7)
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_079b;
					}
					_003Csheet_003E5__2 = ((CvsInSight)WPGTS9K3l9LLLVvlMiKj(readIdToolType.Inspect)).CogSocket.Sheet;
					_003CpasteRange_003E5__3 = CvsCellRange.Empty;
					num3 = 0;
				}
				try
				{
					PasteBuffer pasteObject = default;
					int num4;
					TaskAwaiter<CvsCellCollection> awaiter4 = default;
					TaskAwaiter<object> awaiter3 = default;
					TaskAwaiter<CvsCellRange> awaiter2 = default;
					CvsCellCollection result3 = default;
					CvsCellRange result2 = default;
					string text = default;
					CvsCellLocation cellLocation;
					switch (num2)
					{
					default:
					{
						pasteObject = EzToolType.UpdateNamesInPasteBuffer(readIdToolType._pasteObject, (InspectStepViewModel)nWOEwiK3gls4iXqjZPLj(readIdToolType), out var _);
						num4 = 13;
						goto IL_0244;
					}
					case 5:
						awaiter4 = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num4 = 46;
						goto IL_0244;
					case 4:
						awaiter = _003C_003Eu__3;
						num4 = 42;
						if (1 == 0)
						{
							goto IL_00ed;
						}
						goto IL_0244;
					case 2:
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_04b0;
					case 6:
						awaiter = _003C_003Eu__3;
						num4 = 32;
						goto IL_0244;
					case 3:
						awaiter4 = _003C_003Eu__4;
						num4 = 31;
						if (!t9ZUWiK3d2935vRnpsWe())
						{
							goto IL_0244;
						}
						goto IL_05c8;
					case 1:
						awaiter3 = _003C_003Eu__2;
						num4 = 38;
						goto IL_0244;
					case 0:
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num4 = 28;
							goto IL_0244;
						}
						IL_0244:
						while (true)
						{
							switch (num4)
							{
							case 20:
								return;
							case 11:
								num2 = (_003C_003E1__state = 4);
								num4 = 19;
								continue;
							case 2:
								return;
							case 0:
								break;
							case 27:
								goto IL_0126;
							case 30:
								awaiter3.GetResult();
								num4 = 12;
								continue;
							case 32:
								_003C_003Eu__3 = default;
								num4 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 18;
							case 18:
							case 39:
								_003CnewTool_003E5__5 = new ReadIdTool(readIdToolType.Inspect, isInitialized: false);
								awaiter = kWrJrYK3P3DjyN52GZVl(CeHfAqK3BRqguNuhvvoY(_003CnewTool_003E5__5, result3, _003CpasteRange_003E5__3));
								if (!awaiter.IsCompleted)
								{
									num4 = 35;
									if (BWCOpiK3fpbH7lrjuIvV())
									{
										continue;
									}
									goto case 34;
								}
								goto case 47;
							case 34:
								if (!awaiter2.IsCompleted)
								{
									num4 = 44;
									continue;
								}
								goto case 48;
							case 13:
								awaiter2 = readIdToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
								num4 = 34;
								continue;
							case 10:
								awaiter = ((Task)fj4TC2K3ZBv4AQ5qQSBL(WPGTS9K3l9LLLVvlMiKj(nWOEwiK3gls4iXqjZPLj(readIdToolType)), readIdToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, readIdToolType.wdHfjOu2ln), readIdToolType.Region)).GetAwaiter();
								goto case 33;
							default:
								num4 = 33;
								continue;
							case 6:
								goto IL_031b;
							case 3:
								_003C_003Eu__4 = awaiter4;
								num4 = 26;
								if (t9ZUWiK3d2935vRnpsWe())
								{
								}
								continue;
							case 35:
								num2 = (_003C_003E1__state = 6);
								num4 = 1;
								continue;
							case 25:
								awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num4 = 22;
									continue;
								}
								goto case 29;
							case 15:
								if (!awaiter4.IsCompleted)
								{
									num4 = 40;
									if (BWCOpiK3fpbH7lrjuIvV())
									{
										continue;
									}
									goto case 9;
								}
								goto case 14;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num4 = 45;
								continue;
							case 22:
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__4 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num4 = 24;
								continue;
							case 21:
								num2 = (_003C_003E1__state = -1);
								num4 = 37;
								if (0 == 0)
								{
									continue;
								}
								goto case 44;
							case 44:
								num2 = (_003C_003E1__state = 0);
								num4 = 41;
								continue;
							case 1:
								_003C_003Eu__3 = awaiter;
								num4 = 36;
								continue;
							case 4:
								_003CpasteRange_003E5__3 = result2;
								awaiter3 = _003Csheet_003E5__2.PutCellExpressionAsync(readIdToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, readIdToolType.D4kfWO9KGo), readIdToolType.InputImageLinks[pyZsOpK3sWVVjAjgiuxh(readIdToolType)].Expression).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter3;
									num4 = 43;
									continue;
								}
								goto case 30;
							case 16:
							case 17:
								return;
							case 7:
								goto IL_04c7;
							case 37:
								awaiter.GetResult();
								num4 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 31;
							case 31:
								_003C_003Eu__4 = default;
								num4 = 23;
								continue;
							case 48:
								result2 = awaiter2.GetResult();
								num4 = 4;
								continue;
							case 41:
								_003C_003Eu__1 = awaiter2;
								num4 = 9;
								if (BWCOpiK3fpbH7lrjuIvV())
								{
									continue;
								}
								goto case 40;
							case 40:
								num2 = (_003C_003E1__state = 5);
								num4 = 3;
								if (BWCOpiK3fpbH7lrjuIvV())
								{
									continue;
								}
								goto case 36;
							case 36:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 8;
								continue;
							case 42:
								_003C_003Eu__3 = default;
								num4 = 21;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 12:
								text = (string)ePQQxCK3vj4XFf0i3ACw(readIdToolType.FindInputFixtureCell(readIdToolType._pasteObject));
								num4 = 0;
								continue;
							case 24:
								return;
							case 38:
								goto IL_05c8;
							case 29:
								awaiter4.GetResult();
								num4 = 10;
								continue;
							case 43:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							case 46:
								num2 = (_003C_003E1__state = -1);
								num4 = 14;
								continue;
							case 23:
								num2 = (_003C_003E1__state = -1);
								num4 = 29;
								continue;
							case 26:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num4 = 20;
								continue;
							case 33:
								if (!awaiter.IsCompleted)
								{
									num4 = 11;
									continue;
								}
								goto case 37;
							case 28:
								num2 = (_003C_003E1__state = -1);
								num4 = 48;
								continue;
							case 47:
								awaiter.GetResult();
								num4 = 49;
								continue;
							case 5:
								awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								num4 = 15;
								continue;
							case 14:
								result3 = awaiter4.GetResult();
								goto case 18;
							case 45:
								return;
							case 19:
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 2;
								if (BWCOpiK3fpbH7lrjuIvV())
								{
									continue;
								}
								goto case 49;
							case 49:
								result = _003CnewTool_003E5__5;
								goto end_IL_005e;
							}
							break;
							IL_031b:
							if (!awaiter.IsCompleted)
							{
								num4 = 27;
								continue;
							}
							goto IL_04b0;
							IL_0126:
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							_ = 1;
							if (!t9ZUWiK3d2935vRnpsWe())
							{
								num4 = 17;
								continue;
							}
							num4 = 18;
							if (true)
							{
								continue;
							}
							return;
						}
						goto IL_00ed;
						IL_05c8:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num4 = 30;
						goto IL_0244;
						IL_04b0:
						awaiter.GetResult();
						num4 = 25;
						if (BWCOpiK3fpbH7lrjuIvV())
						{
							goto IL_0244;
						}
						goto IL_04c7;
						IL_04c7:
						num2 = (_003C_003E1__state = -1);
						num4 = 47;
						goto IL_0244;
						IL_00ed:
						cellLocation = readIdToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, readIdToolType.mC9fCv3lOT);
						awaiter = kWrJrYK3P3DjyN52GZVl(rrUFZIK3rVEy1d0PcTdY(nWOEwiK3gls4iXqjZPLj(readIdToolType), text, cellLocation));
						num4 = 6;
						goto IL_0244;
						end_IL_005e:
						break;
					}
				}
				catch (object obj)
				{
					_003C_003E7__wrap3 = obj;
					num3 = 1;
					goto IL_0734;
				}
				goto end_IL_0026;
				IL_0734:
				if (num3 == 1)
				{
					awaiter = kWrJrYK3P3DjyN52GZVl(readIdToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 7);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_079b;
				}
				goto IL_07c4;
				IL_079b:
				awaiter.GetResult();
				nh53ycK3GEJynVaJWNtl(xFeZrOK3bY5QP8JcFdgi((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
				goto IL_07c4;
				IL_07c4:
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
			goto IL_0866;
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
		internal static object WPGTS9K3l9LLLVvlMiKj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nWOEwiK3gls4iXqjZPLj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pyZsOpK3sWVVjAjgiuxh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ePQQxCK3vj4XFf0i3ACw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rrUFZIK3rVEy1d0PcTdY(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kWrJrYK3P3DjyN52GZVl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fj4TC2K3ZBv4AQ5qQSBL(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CeHfAqK3BRqguNuhvvoY(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xFeZrOK3bY5QP8JcFdgi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nh53ycK3GEJynVaJWNtl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BWCOpiK3fpbH7lrjuIvV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t9ZUWiK3d2935vRnpsWe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__32 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public ReadIdToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__32(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qxrb6cK3oTJoGTRIEbwQ())
			{
				num = 3;
				if (vEVjnJK3ScGsYmgbZ23E())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0052;
			IL_002a:
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			num = 5;
			goto IL_0052;
			IL_0052:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 4;
				default:
					num = 4;
					continue;
				case 4:
					_003C_003El__initialThreadId = N1o49EK38xr4b9cOEpIV();
					num = 6;
					continue;
				case 5:
					WAhiQeK3k6uDRotHLoUH(this);
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
			int num = 10;
			ReadIdToolType readIdToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 18:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 5;
						continue;
					}
					goto case 1;
				case 2:
					readIdToolType = _003C_003E4__this;
					num = 6;
					continue;
				case 9:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						_003C_003E2__current = new AddPharmacodeUpdate(readIdToolType.Localizer);
						goto case 13;
					}
					goto case 21;
				case 7:
					return true;
				case 20:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					num = 17;
					continue;
				case 19:
					return true;
				case 3:
				case 11:
					return false;
				case 1:
					if (_003CcurrentVersion_003E5__2 >= 3)
					{
						goto case 9;
					}
					_003C_003E2__current = new FailOnNoResultsUpdate(readIdToolType.Localizer);
					goto case 8;
				default:
					num = 8;
					continue;
				case 16:
					return true;
				case 4:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, readIdToolType.Localizer);
						_003C_003E1__state = 5;
						num = 7;
						continue;
					}
					break;
				case 15:
					_003C_003E1__state = 1;
					num = 19;
					continue;
				case 6:
					switch (num2)
					{
					case 5:
						_003C_003E1__state = -1;
						num = 22;
						continue;
					case 1:
						_003C_003E1__state = -1;
						num = 1;
						continue;
					case 0:
						_003C_003E1__state = -1;
						num = 20;
						if (vEVjnJK3ScGsYmgbZ23E())
						{
						}
						continue;
					case 2:
						_003C_003E1__state = -1;
						num = 9;
						continue;
					case 3:
						_003C_003E1__state = -1;
						num = 21;
						continue;
					case 4:
						_003C_003E1__state = -1;
						num = 4;
						continue;
					}
					_ = 0;
					if (!qxrb6cK3oTJoGTRIEbwQ())
					{
						num = 13;
						if (!vEVjnJK3ScGsYmgbZ23E())
						{
							continue;
						}
						goto case 7;
					}
					num = 11;
					continue;
				case 5:
					_003C_003E2__current = new AddTrainingUpdate(readIdToolType.Localizer);
					num = 15;
					continue;
				case 13:
				case 14:
					_003C_003E1__state = 3;
					return true;
				case 12:
					_003C_003E2__current = new AddPostalCodeUpdate(readIdToolType.Localizer);
					_003C_003E1__state = 4;
					num = 0;
					continue;
				case 21:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						num = 12;
						continue;
					}
					goto case 4;
				case 17:
					_003ClatestVersion_003E5__3 = Ij4qGVK3qr0URmuFv349(readIdToolType._pasteObject);
					num = 18;
					if (!vEVjnJK3ScGsYmgbZ23E())
					{
						continue;
					}
					goto case 0;
				case 0:
					return true;
				case 8:
					_003C_003E1__state = 2;
					num = 16;
					continue;
				case 10:
					num2 = _003C_003E1__state;
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				case 22:
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
			_003CGetUpdates_003Ed__32 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__32(0)
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
		internal static void WAhiQeK3k6uDRotHLoUH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int N1o49EK38xr4b9cOEpIV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qxrb6cK3oTJoGTRIEbwQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vEVjnJK3ScGsYmgbZ23E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Ij4qGVK3qr0URmuFv349(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	public static readonly Guid[] _guids;

	private readonly CvsCellLocation D4kfWO9KGo;

	private readonly CvsCellLocation wdHfjOu2ln;

	private readonly CvsCellLocation mC9fCv3lOT;

	private int if3fOk7ahF;

	private CvsEditableDisplayGraphic[] yxIfHZPqWd;

	[CompilerGenerated]
	private CvsDisplayableRegion K76fwxa5as;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _guids;
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
			return (string)wZ4ie3o3TZQPP6SOrhG();
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
			return (string)fq8GiCojGrYnHydbUBZ();
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
			return XAMLGraphicKeys.Tools_ReadIdIcon;
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
			return XAMLGraphicKeys.Tools_ReadIdIcon;
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
				(string)JqGMmMo6KocCATOFeVa(),
				Resources.xdOY7hqn3C()
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
			return if3fOk7ahF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref if3fOk7ahF, value, (string)ygcjw2o7R4rCFGVsXaf(3256));
		}
	}

	public CvsDisplayableRegion Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K76fwxa5as;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K76fwxa5as = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadIdToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		do
		{
			IL_00c7:
			switch (num)
			{
			case 3:
			case 8:
				_pasteObject = (PasteBuffer)kEk5opo4nAugI00pK8s(dGjtvno9kDAoSHLpO8R());
				num = 0;
				goto IL_00c7;
			case 6:
				if3fOk7ahF = 140;
				_ = 0;
				if (Qt3YfDoEfyypd7keiHM())
				{
					num = 5;
					if (bhlpUjopK1H6VSvvoun())
					{
					}
					goto IL_00c7;
				}
				num = 8;
				if (true)
				{
					goto IL_00c7;
				}
				goto case 4;
			case 1:
				wdHfjOu2ln = _pasteObject.GetCellOffset((string)ygcjw2o7R4rCFGVsXaf(5684));
				num = 4;
				goto IL_00c7;
			case 9:
				AddSnippet(_pasteObject);
				num = 10;
				goto IL_00c7;
			case 0:
				D4kfWO9KGo = _pasteObject.GetCellOffset((string)ygcjw2o7R4rCFGVsXaf(4928));
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					goto IL_00c7;
				}
				goto case 2;
			case 2:
			case 5:
				base._002Ector();
				goto case 3;
			case 4:
				mC9fCv3lOT = _pasteObject.GetCellOffset((string)ygcjw2o7R4rCFGVsXaf(6522));
				num = 9;
				if (true)
				{
					goto IL_00c7;
				}
				break;
			case 7:
				break;
			case 10:
				return;
			}
			nf9jDboXYBVNAF2koZa();
			num = 6;
		}
		while (Qt3YfDoEfyypd7keiHM());
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
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		_003COnBeginAddInternal_003Ed__24 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0067;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				goto IL_0067;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 0;
				if (Qt3YfDoEfyypd7keiHM())
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E4__this = this;
				Qt3YfDoEfyypd7keiHM();
				if (bhlpUjopK1H6VSvvoun())
				{
					num = 4;
					if (true)
					{
						continue;
					}
					goto IL_0067;
				}
				num = 1;
				if (Qt3YfDoEfyypd7keiHM())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0067:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yxIfHZPqWd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__31))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__31 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__32))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__32(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReadIdToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nf9jDboXYBVNAF2koZa();
		_guids = new Guid[1]
		{
			new Guid((string)ygcjw2o7R4rCFGVsXaf(11598))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task EA9flvfSDS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nf9jDboXYBVNAF2koZa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dGjtvno9kDAoSHLpO8R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ReadId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kEk5opo4nAugI00pK8s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ygcjw2o7R4rCFGVsXaf(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qt3YfDoEfyypd7keiHM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bhlpUjopK1H6VSvvoun()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wZ4ie3o3TZQPP6SOrhG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IJL9DOgYRW();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fq8GiCojGrYnHydbUBZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.n0v9IfyVlN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JqGMmMo6KocCATOFeVa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}
}
