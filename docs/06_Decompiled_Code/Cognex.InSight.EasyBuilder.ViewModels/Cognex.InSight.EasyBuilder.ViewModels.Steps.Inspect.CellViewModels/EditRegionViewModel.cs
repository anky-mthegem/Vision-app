using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Graphic;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class EditRegionViewModel : EditableGraphicsViewModel, QpXw26KT7OGd3H62pw
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditRegionViewModel _003C_003E4__this;

		public CvsInSightDisplay display;

		public bool undo;

		private CvsDisplayableRegion _003Cregion_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EditRegionViewModel editRegionViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoGraphicChange undoGraphicChange = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					editRegionViewModel = _003C_003E4__this;
					NSGJ1kKt8pDcDhSqZRPq();
					num = (kpnpQUKtkJ8JuwnFe0UA() ? 1 : 4);
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
								if (1 == 0)
								{
									goto IL_02e0;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 16;
							case 5:
								if (editRegionViewModel.Enabled)
								{
									_003Cregion_003E5__2 = new CvsDisplayableRegion((CvsGraphicRegion)Mn2IVFKtEvrrqlmjyo6N(jV1cGKKtq3VOSWGBIBxQ(editRegionViewModel.Graphic)));
									undoGraphicChange = new UndoGraphicChange(editRegionViewModel.InSight, editRegionViewModel.CellName, editRegionViewModel.j6aySjrNA5, _003Cregion_003E5__2, display);
									if (editRegionViewModel.IsInitialized & undo)
									{
										num3 = 10;
										continue;
									}
									awaiter = ((Task)Gd27b9Kt9B1PkaUm5OC2(undoGraphicChange)).GetAwaiter();
									num3 = 11;
									continue;
								}
								goto end_IL_022a;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 16;
							case 16:
							case 18:
								awaiter.GetResult();
								num3 = 19;
								if (kpnpQUKtkJ8JuwnFe0UA())
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								NSGJ1kKt8pDcDhSqZRPq();
								if (!kpnpQUKtkJ8JuwnFe0UA())
								{
									num3 = 18;
									if (kpnpQUKtkJ8JuwnFe0UA())
									{
										continue;
									}
									goto case 5;
								}
								num3 = 3;
								continue;
							case 8:
							case 19:
								editRegionViewModel.j6aySjrNA5 = _003Cregion_003E5__2;
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = ((Task)d7GGKqKtXA4n6K1hwpss(bP85l8KtpOK71MBYOYL5(editRegionViewModel.InSight), undoGraphicChange)).GetAwaiter();
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									continue;
								}
								goto case 17;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 11:
								if (awaiter.IsCompleted)
								{
									goto case 16;
								}
								num3 = 2;
								if (kpnpQUKtkJ8JuwnFe0UA())
								{
									continue;
								}
								goto case 17;
							case 17:
								awaiter.GetResult();
								goto case 8;
							default:
								num3 = 8;
								if (kpnpQUKtkJ8JuwnFe0UA())
								{
									continue;
								}
								return;
							case 4:
								return;
							case 2:
								num2 = (_003C_003E1__state = 1);
								num3 = 7;
								continue;
							case 3:
							case 14:
								return;
							case 20:
								break;
							}
							goto IL_02e0;
							continue;
							end_IL_022a:
							break;
						}
						goto end_IL_0039;
						IL_02e0:
						_003Cregion_003E5__2 = null;
						end_IL_0039:;
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
					num2 = _003C_003E1__state;
					num = 5;
					continue;
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
		internal static object jV1cGKKtq3VOSWGBIBxQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Mn2IVFKtEvrrqlmjyo6N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bP85l8KtpOK71MBYOYL5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d7GGKqKtXA4n6K1hwpss(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Gd27b9Kt9B1PkaUm5OC2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoGraphicChange)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kpnpQUKtkJ8JuwnFe0UA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NSGJ1kKt8pDcDhSqZRPq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsDisplayableRegion j6aySjrNA5;

	private string WQOyD70BwE;

	private SourceLink MKby3CKjb6;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Region;
		}
	}

	public override bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WQOyD70BwE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref WQOyD70BwE, value, (string)N6Ou9fME5GwZNCCUfk0(5436)))
			{
				oqvgA0Mp2nxUZPZGc1c(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
			}
		}
	}

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (MKby3CKjb6 == null)
			{
				MKby3CKjb6 = new SourceLink(this);
			}
			return MKby3CKjb6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditRegionViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imageCellLocation, bool showXArrow, bool showYArrow, bool showAxesLabels)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsDisplayableRegion cvsDisplayableRegion = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				cvsDisplayableRegion.ShowYArrow = showYArrow;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				if (cvsDisplayableRegion != null)
				{
					goto default;
				}
				return;
			default:
				_ = 0;
				if (Lxf9hPMbPBrogwU76L3())
				{
					num = 6;
					break;
				}
				num = 1;
				if (Lxf9hPMbPBrogwU76L3())
				{
					break;
				}
				goto case 2;
			case 7:
				this._002Ector(insight, cells, loc, displayName, imageCellLocation);
				num = 2;
				if (xeZIxUMGheUl8jPt6P4())
				{
				}
				break;
			case 4:
			case 6:
				FQAnaaMSZC0nGWmySVF(cvsDisplayableRegion, showXArrow);
				goto case 1;
			case 2:
				cvsDisplayableRegion = Graphic as CvsDisplayableRegion;
				num = 8;
				break;
			case 0:
				ENHEtqModpqs1KEabJL();
				num = 7;
				break;
			case 3:
				bcIev7MknpXDwD6ZLSP(cvsDisplayableRegion, showAxesLabels);
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditRegionViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imageCellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				ENHEtqModpqs1KEabJL();
				num = 7;
				if (Lxf9hPMbPBrogwU76L3())
				{
					break;
				}
				goto case 7;
			case 7:
				base._002Ector(insight, loc, displayName);
				xeZIxUMGheUl8jPt6P4();
				num = ((!Lxf9hPMbPBrogwU76L3()) ? 1 : 4);
				break;
			case 5:
				Graphic.Tag = this;
				num = 6;
				break;
			case 1:
			case 3:
				j6aySjrNA5 = new CvsDisplayableRegion((CvsGraphicRegion)((CvsGraphic)GyM1LTMqo7uLH6jMndU(Graphic)).Clone());
				goto case 5;
			default:
				num = 5;
				if (xeZIxUMGheUl8jPt6P4())
				{
				}
				break;
			case 2:
			case 4:
				Graphic = (CvsEditableDisplayGraphic)rkLM2bM8fogARDaQMvQ(loc, cells, imageCellLocation);
				goto case 1;
			case 6:
				Refresh(cells, init: true);
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RefreshButtonTextValue([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Value = P_0;
		}, cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshGraphic(CvsCellCollection cells, bool pass, CvsCellLocation inputImageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds(Graphic, (CvsCell)MHkI5LMXGGL3q4xGPFw(cells, inputImageCell));
		EditableGraphicHelper.UpdateRegion(Graphic as CvsDisplayableRegion, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSend_003Ed__13))]
	public override Task Send(bool undo = true, CvsInSightDisplay display = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CSend_003Ed__13 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 3:
				stateMachine.display = display;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 2:
				stateMachine.undo = undo;
				goto case 0;
			case 7:
				stateMachine._003C_003Et__builder = YxqQq1M9nbSQxjexl0W();
				xeZIxUMGheUl8jPt6P4();
				if (!Lxf9hPMbPBrogwU76L3())
				{
					num = 0;
					break;
				}
				num = 6;
				if (xeZIxUMGheUl8jPt6P4())
				{
				}
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void vvgyX9wnAr(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ENHEtqModpqs1KEabJL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FQAnaaMSZC0nGWmySVF(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableRegion)P_0).ShowXArrow = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bcIev7MknpXDwD6ZLSP(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableRegion)P_0).ShowAxesLabels = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lxf9hPMbPBrogwU76L3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xeZIxUMGheUl8jPt6P4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rkLM2bM8fogARDaQMvQ(CvsCellLocation loc, object P_1, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructRegion(loc, (CvsCellCollection)P_1, inputImageLocation);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GyM1LTMqo7uLH6jMndU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N6Ou9fME5GwZNCCUfk0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oqvgA0Mp2nxUZPZGc1c(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MHkI5LMXGGL3q4xGPFw(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder YxqQq1M9nbSQxjexl0W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
