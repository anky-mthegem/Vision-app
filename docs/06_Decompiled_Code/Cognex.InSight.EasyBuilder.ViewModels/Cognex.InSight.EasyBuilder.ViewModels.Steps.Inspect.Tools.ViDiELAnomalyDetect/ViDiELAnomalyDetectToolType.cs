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
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
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
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELAnomalyDetect;

[Export(typeof(EzToolType))]
public class ViDiELAnomalyDetectToolType : EzToolType, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ViDiELAnomalyDetectToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ViDiELAnomalyDetectTool _003Ctool_003E5__2;

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
			if (!cy0FBTK4g5wsJPJIT7pV())
			{
				num = 1;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01d9;
			IL_003d:
			int num2 = default;
			ViDiELAnomalyDetectToolType viDiELAnomalyDetectToolType = default;
			EzTool result = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					_003Ctool_003E5__2 = new ViDiELAnomalyDetectTool((InspectStepViewModel)RUMvv6K4smEeWcwiWk7F(viDiELAnomalyDetectToolType), isInitialized: true, viDiELAnomalyDetectToolType.ny43I6P5bB);
					num3 = 1;
					if (cy0FBTK4g5wsJPJIT7pV())
					{
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
					if (!QOkqsrK4lGofKYyHWbHb())
					{
						goto IL_00f0;
					}
				}
				while (true)
				{
					switch (num3)
					{
					case 5:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							if (QOkqsrK4lGofKYyHWbHb())
							{
								continue;
							}
							goto case 3;
						}
						goto case 2;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 1:
						awaiter = kcebd2K4vxPNUu4FhQC9(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
						num3 = 5;
						continue;
					case 4:
						break;
					case 9:
						goto IL_00f0;
					default:
						num3 = 4;
						continue;
					case 0:
					case 6:
						num2 = (_003C_003E1__state = -1);
						goto case 2;
					case 2:
					case 7:
						awaiter.GetResult();
						num3 = 10;
						continue;
					case 8:
						goto IL_016e;
					case 10:
						result = _003Ctool_003E5__2;
						goto end_IL_003d;
					}
					break;
					IL_016e:
					_003C_003Eu__1 = default;
					_ = 1;
					num3 = (cy0FBTK4g5wsJPJIT7pV() ? 2 : 0);
				}
				goto IL_00c6;
				IL_00c6:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				return;
				IL_00f0:
				_003C_003Eu__1 = awaiter;
				goto IL_00c6;
				end_IL_003d:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ctool_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0235;
			IL_01d9:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
				case 4:
					goto IL_003d;
				default:
					num = 3;
					continue;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 6:
					viDiELAnomalyDetectToolType = _003C_003E4__this;
					goto IL_003d;
				case 3:
					goto IL_0235;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			num = 6;
			if (!QOkqsrK4lGofKYyHWbHb())
			{
				goto IL_003d;
			}
			goto IL_01d9;
			IL_0235:
			_003Ctool_003E5__2 = null;
			num = 5;
			if (1 == 0)
			{
				return;
			}
			goto IL_01d9;
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
		internal static object RUMvv6K4smEeWcwiWk7F(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kcebd2K4vxPNUu4FhQC9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QOkqsrK4lGofKYyHWbHb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cy0FBTK4g5wsJPJIT7pV()
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

		public ViDiELAnomalyDetectToolType _003C_003E4__this;

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
			ViDiELAnomalyDetectToolType viDiELAnomalyDetectToolType = default;
			CvsCellLocation cell = default;
			TaskAwaiter awaiter = default;
			CvsCell imageCell = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!ECR9GHK4Pt8W5XiqfO9K())
					{
						num = 0;
						continue;
					}
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				case 0:
				case 1:
					viDiELAnomalyDetectToolType = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cell = CvsCellLocation.Parse((string)ueBL4DK4ZlX9qHHR2svQ(viDiELAnomalyDetectToolType.CurrentInputImageLink));
							num3 = 9;
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
							case 12:
								num2 = (_003C_003E1__state = 0);
								goto case 7;
							case 13:
								gBtPk9K4S1LOk6vfN27s(trdE42K4GBeelYP9Zfqy(viDiELAnomalyDetectToolType.EditableRegion), MFhB86K4oXWII44HgF7S());
								Rxnw00K483RHMLTGVkLh(viDiELAnomalyDetectToolType.EditableRegion, JIhTdDK4kjyYJVeKymNf());
								viDiELAnomalyDetectToolType.EditableRegion.SelectedColor = JIhTdDK4kjyYJVeKymNf();
								num3 = 6;
								continue;
							case 6:
								viDiELAnomalyDetectToolType.myk3EseYWa = new CvsEditableDisplayGraphic[1] { viDiELAnomalyDetectToolType.EditableRegion };
								awaiter = z7IUK9K4qXUAX6OBxRup(viDiELAnomalyDetectToolType.gV33u7Lcoe());
								num3 = 3;
								continue;
							case 7:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 4:
								return;
							case 10:
								viDiELAnomalyDetectToolType.EditableRegion = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, imageCell);
								eXPkBIK4rc4mQnwRR4hg();
								num3 = ((!ECR9GHK4Pt8W5XiqfO9K()) ? 11 : 8);
								continue;
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 12;
							default:
								num3 = 12;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (!ECR9GHK4Pt8W5XiqfO9K())
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 9:
								imageCell = ((CvsCellCollection)cwwI8iK4bGspObxn73SI(ae9gwgK4Bf45ntp8LFV6(viDiELAnomalyDetectToolType.InSight)))[cell];
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 11:
								viDiELAnomalyDetectToolType.EditableRegion.ShowAxesLabels = false;
								num3 = 13;
								if (eXPkBIK4rc4mQnwRR4hg())
								{
									continue;
								}
								break;
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
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (ECR9GHK4Pt8W5XiqfO9K())
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
		internal static object ueBL4DK4ZlX9qHHR2svQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ae9gwgK4Bf45ntp8LFV6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cwwI8iK4bGspObxn73SI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object trdE42K4GBeelYP9Zfqy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableRegion)P_0).Region;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MFhB86K4oXWII44HgF7S()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.InputRegion;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gBtPk9K4S1LOk6vfN27s(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphic)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color JIhTdDK4kjyYJVeKymNf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.Cyan;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Rxnw00K483RHMLTGVkLh(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Color = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter z7IUK9K4qXUAX6OBxRup(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eXPkBIK4rc4mQnwRR4hg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ECR9GHK4Pt8W5XiqfO9K()
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

		public ViDiELAnomalyDetectToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ViDiELAnomalyDetectTool _003CnewTool_003E5__5;

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
			TaskAwaiter awaiter = default;
			ViDiELAnomalyDetectToolType viDiELAnomalyDetectToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCogSheetResult> awaiter5 = default;
			TaskAwaiter<CvsCellRange> awaiter4 = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter<object> awaiter2 = default;
			string expression = default;
			CvsCellLocation cellLocation = default;
			CvsCellCollection result2 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
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
								goto IL_0794;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)RBd3ExK49arneSdiM7qU(((AppStepViewModel)LfDHknK4XOthhhlqwIFv(viDiELAnomalyDetectToolType)).InSight.CogSocket);
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
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(viDiELAnomalyDetectToolType._pasteObject, viDiELAnomalyDetectToolType.Inspect, out var _);
								num4 = 1;
								if (GH1OVeK4pPrt0Yem13JG())
								{
									return;
								}
								goto IL_0141;
							}
							case 6:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 48;
								goto IL_0141;
							case 3:
								awaiter5 = _003C_003Eu__4;
								goto IL_054c;
							case 0:
								awaiter4 = _003C_003Eu__1;
								num4 = 24;
								goto IL_0141;
							case 5:
								awaiter3 = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num4 = 30;
								goto IL_0141;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 19;
								goto IL_0141;
							case 4:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0612;
							case 1:
								{
									awaiter2 = _003C_003Eu__2;
									num4 = 13;
									goto IL_0141;
								}
								IL_0141:
								while (true)
								{
									switch (num4)
									{
									case 43:
										return;
									case 12:
										expression = viDiELAnomalyDetectToolType.FindInputFixtureCell(viDiELAnomalyDetectToolType._pasteObject).Expression;
										num4 = 0;
										continue;
									case 11:
										break;
									case 26:
									case 28:
										return;
									case 17:
										return;
									case 31:
										num2 = (_003C_003E1__state = -1);
										goto case 37;
									default:
										num4 = 37;
										continue;
									case 48:
										num2 = (_003C_003E1__state = -1);
										num4 = 34;
										continue;
									case 39:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											_003C_003Eu__3 = awaiter;
											num4 = 7;
											continue;
										}
										goto case 34;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 3;
										if (GH1OVeK4pPrt0Yem13JG())
										{
										}
										continue;
									case 44:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter4;
										num4 = 14;
										continue;
									case 15:
										num2 = (_003C_003E1__state = 3);
										num4 = 25;
										continue;
									case 8:
										num2 = (_003C_003E1__state = 2);
										num4 = 23;
										if (true)
										{
											continue;
										}
										goto case 19;
									case 19:
										_003C_003Eu__3 = default;
										num4 = 31;
										if (true)
										{
											continue;
										}
										goto case 24;
									case 24:
										_003C_003Eu__1 = default;
										num4 = 36;
										if (true)
										{
											continue;
										}
										goto case 14;
									case 14:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 17;
										continue;
									case 13:
										_003C_003Eu__2 = default;
										num4 = 10;
										if (true)
										{
											continue;
										}
										goto case 30;
									case 30:
										num2 = (_003C_003E1__state = -1);
										num4 = 27;
										continue;
									case 38:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 16;
										if (GH1OVeK4pPrt0Yem13JG())
										{
										}
										continue;
									case 45:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 35;
										if (true)
										{
											continue;
										}
										goto case 18;
									case 18:
									{
										CvsCellRange result3 = awaiter4.GetResult();
										_003CpasteRange_003E5__3 = result3;
										awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(viDiELAnomalyDetectToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELAnomalyDetectToolType.AVp3S7d8y9), (string)ck8pfPK44EoNplQKvV6w(viDiELAnomalyDetectToolType.InputImageLinks[viDiELAnomalyDetectToolType.InputImageIndex])).GetAwaiter();
										num4 = 22;
										continue;
									}
									case 37:
										awaiter.GetResult();
										num4 = 5;
										continue;
									case 0:
										cellLocation = viDiELAnomalyDetectToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELAnomalyDetectToolType.jRO33fCa9W);
										num4 = 33;
										continue;
									case 5:
										awaiter5 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										if (!awaiter5.IsCompleted)
										{
											num4 = 15;
											if (PoxgHOK4E9VYb2gGfCQW())
											{
												continue;
											}
											goto case 10;
										}
										goto case 41;
									case 10:
										num2 = (_003C_003E1__state = -1);
										num4 = 9;
										continue;
									case 27:
										result2 = awaiter3.GetResult();
										num4 = 47;
										continue;
									case 32:
										num2 = (_003C_003E1__state = 5);
										num4 = 6;
										if (0 == 0)
										{
											continue;
										}
										goto case 4;
									case 4:
										if (!awaiter4.IsCompleted)
										{
											num4 = 44;
											continue;
										}
										goto case 18;
									case 23:
										_003C_003Eu__3 = awaiter;
										num4 = 2;
										if (0 == 0)
										{
											continue;
										}
										goto case 34;
									case 34:
										awaiter.GetResult();
										num4 = 49;
										if (PoxgHOK4E9VYb2gGfCQW())
										{
											continue;
										}
										return;
									case 35:
										return;
									case 22:
										if (!awaiter2.IsCompleted)
										{
											num4 = 21;
											if (PoxgHOK4E9VYb2gGfCQW())
											{
												continue;
											}
											return;
										}
										goto case 9;
									case 3:
										return;
									case 33:
										awaiter = rZ1VHHK43bGeEu0h09v8(fYcX9jK47mHQ85XoEtem(viDiELAnomalyDetectToolType.Inspect, expression, cellLocation));
										if (!awaiter.IsCompleted)
										{
											num4 = 8;
											continue;
										}
										goto case 37;
									case 20:
										num2 = (_003C_003E1__state = 4);
										num4 = 46;
										continue;
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 43;
										continue;
									case 29:
									case 40:
										goto end_IL_0141;
									case 42:
										if (!awaiter3.IsCompleted)
										{
											num4 = 32;
											continue;
										}
										goto case 27;
									case 36:
										num2 = (_003C_003E1__state = -1);
										num4 = 18;
										continue;
									case 41:
										awaiter5.GetResult();
										awaiter = rZ1VHHK43bGeEu0h09v8(DT6PrZK465oydrR028jT(GDejD6K4je5m6UG6clGK(viDiELAnomalyDetectToolType.Inspect), viDiELAnomalyDetectToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, viDiELAnomalyDetectToolType.iXO3DXgNuG), viDiELAnomalyDetectToolType.EditableRegion));
										num4 = 11;
										continue;
									case 46:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 21:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter2;
										num4 = 38;
										continue;
									case 6:
										_003C_003Eu__5 = awaiter3;
										num4 = 45;
										continue;
									case 1:
										awaiter4 = viDiELAnomalyDetectToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 4;
										continue;
									case 16:
										return;
									case 25:
										goto IL_0695;
									case 47:
										_003CnewTool_003E5__5 = new ViDiELAnomalyDetectTool((InspectStepViewModel)LfDHknK4XOthhhlqwIFv(viDiELAnomalyDetectToolType), isInitialized: false, viDiELAnomalyDetectToolType.ny43I6P5bB);
										awaiter = ((Task)YgoE46K4C6gyZCveBVQe(_003CnewTool_003E5__5, result2, _003CpasteRange_003E5__3)).GetAwaiter();
										num4 = 39;
										continue;
									case 9:
										awaiter2.GetResult();
										num4 = 12;
										continue;
									case 49:
										result = _003CnewTool_003E5__5;
										goto end_IL_0050;
									}
									if (!awaiter.IsCompleted)
									{
										num4 = 20;
										if (!PoxgHOK4E9VYb2gGfCQW())
										{
											return;
										}
										continue;
									}
									goto IL_0612;
									IL_0695:
									_003C_003Eu__4 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									_ = 1;
									num4 = ((!GH1OVeK4pPrt0Yem13JG()) ? 26 : 40);
									continue;
									end_IL_0141:
									break;
								}
								goto IL_054c;
								IL_054c:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 41;
								goto IL_0141;
								IL_0612:
								awaiter.GetResult();
								awaiter3 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								num4 = 42;
								goto IL_0141;
								end_IL_0050:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_072d;
						}
						goto end_IL_0018;
						IL_072d:
						if (num3 == 1)
						{
							awaiter = rZ1VHHK43bGeEu0h09v8(viDiELAnomalyDetectToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0794;
						}
						goto IL_07bd;
						IL_0794:
						awaiter.GetResult();
						iIPK0IK4R9DMelYasFfS(hllGeFK4AJLf48EcoRRg((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_07bd;
						IL_07bd:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0018:;
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
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					_003Csheet_003E5__2 = null;
					num = 4;
					break;
				case 1:
				case 6:
					viDiELAnomalyDetectToolType = _003C_003E4__this;
					goto case 0;
				case 3:
					do
					{
						num2 = _003C_003E1__state;
						_ = 0;
						if (!PoxgHOK4E9VYb2gGfCQW())
						{
							num = 0;
							continue;
						}
						num = 6;
						break;
					}
					while (!PoxgHOK4E9VYb2gGfCQW());
					break;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
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
		internal static object LfDHknK4XOthhhlqwIFv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RBd3ExK49arneSdiM7qU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ck8pfPK44EoNplQKvV6w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fYcX9jK47mHQ85XoEtem(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rZ1VHHK43bGeEu0h09v8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GDejD6K4je5m6UG6clGK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DT6PrZK465oydrR028jT(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YgoE46K4C6gyZCveBVQe(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hllGeFK4AJLf48EcoRRg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iIPK0IK4R9DMelYasFfS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PoxgHOK4E9VYb2gGfCQW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GH1OVeK4pPrt0Yem13JG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] xaD3XewbCH;

	private int kdk3o9V8e4;

	private readonly CvsCellLocation AVp3S7d8y9;

	private readonly CvsCellLocation iXO3DXgNuG;

	private readonly CvsCellLocation jRO33fCa9W;

	private EZBAnomalyDetectAdapter ny43I6P5bB;

	[CompilerGenerated]
	private CvsDisplayableRegion wFW3fxP1rD;

	private CvsEditableDisplayGraphic[] myk3EseYWa;

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
			KQShcJbIEeFFOtnrQ3U();
			int num = (DTANGTbDg5VhoV09uIm() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 2:
					etshHqblxbcMFf1Cs7o(ny43I6P5bB);
					num = 5;
					continue;
				case 1:
				case 3:
					ny43I6P5bB = new EZBAnomalyDetectAdapter(base.Inspect);
					goto case 2;
				case 0:
				case 4:
					base.Inspect = value;
					goto case 1;
				case 5:
					return;
				}
				num = 2;
				if (DTANGTbDg5VhoV09uIm())
				{
				}
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
			return xaD3XewbCH;
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
			return kdk3o9V8e4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref kdk3o9V8e4, value, (string)DhPNKLbfB0ZHPAm0BiO(3256));
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
			return (string)dmK1X0bgKyu8hNkFB1c();
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
			return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELAnomalyDetectDescription;
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
			return XAMLGraphicKeys.Tools_AnomalyDetectIcon;
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
			return XAMLGraphicKeys.Tools_AnomalyDetectIcon;
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
				(string)KbnGnDbsixK8rZLqIXI(),
				(string)WPUwM4bv2DWgJBf4rOe()
			};
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
			return wFW3fxP1rD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wFW3fxP1rD = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELAnomalyDetectToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DTANGTbDg5VhoV09uIm();
		int num;
		if (KQShcJbIEeFFOtnrQ3U())
		{
			num = 8;
		}
		else
		{
			num = 1;
			if (DTANGTbDg5VhoV09uIm())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				_pasteObject = (PasteBuffer)cl7uldbV93pvQnebUUj(caOXi9bn9sgNy9SGXl5());
				goto case 1;
			case 1:
			case 4:
				AVp3S7d8y9 = _pasteObject.GetCellOffset((string)DhPNKLbfB0ZHPAm0BiO(4928));
				goto case 7;
			default:
				num = 7;
				if (DTANGTbDg5VhoV09uIm())
				{
				}
				break;
			case 7:
				iXO3DXgNuG = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684));
				num = 5;
				break;
			case 3:
				base._002Ector();
				num = 6;
				break;
			case 9:
				kdk3o9V8e4 = 135;
				num = 3;
				break;
			case 5:
				jRO33fCa9W = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				AddSnippet(_pasteObject);
				num = 10;
				break;
			case 0:
			case 8:
				Tuqyn8biTdC5sC629dR();
				num = 9;
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
		EZBAnomalyDetectAdapter eZBAnomalyDetectAdapter = ny43I6P5bB;
		if (eZBAnomalyDetectAdapter != null)
		{
			bejiUZbduKoEMco45KL(eZBAnomalyDetectAdapter);
		}
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
		DTANGTbDg5VhoV09uIm();
		int num;
		if (KQShcJbIEeFFOtnrQ3U())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0044;
		IL_0071:
		_003COnBeginAddInternal_003Ed__29 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_0071;
			case 5:
				goto IL_0071;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_0071;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return myk3EseYWa;
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
	static ViDiELAnomalyDetectToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Tuqyn8biTdC5sC629dR();
		xaD3XewbCH = new Guid[1]
		{
			new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8880))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task gV33u7Lcoe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tuqyn8biTdC5sC629dR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object caOXi9bn9sgNy9SGXl5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ViDiELAnomalyDetect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cl7uldbV93pvQnebUUj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DhPNKLbfB0ZHPAm0BiO(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KQShcJbIEeFFOtnrQ3U()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DTANGTbDg5VhoV09uIm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bejiUZbduKoEMco45KL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void etshHqblxbcMFf1Cs7o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectAdapterBase.Register((IAnomalyDetectorAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dmK1X0bgKyu8hNkFB1c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELAnomalyDetect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KbnGnDbsixK8rZLqIXI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.EasyBuilder.ViewModels.Properties.Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WPUwM4bv2DWgJBf4rOe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Cognex.InSight.ViDiEL.ViewModels.Properties.Resources.ViDiELTools;
	}
}
