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

public class EditCompositeRegionViewModel : EditableGraphicsViewModel, QpXw26KT7OGd3H62pw
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditCompositeRegionViewModel _003C_003E4__this;

		public CvsInSightDisplay display;

		public bool undo;

		private CvsDisplayableComposite _003CcompositeRegion_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			m7QI8WKtVIVc41RI8Mti();
			int num;
			if (YcOU2BKtnM4imcBAcmCi())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			TaskAwaiter awaiter = default;
			EditCompositeRegionViewModel editCompositeRegionViewModel = default;
			UndoGraphicChange undoGraphicChange = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
								if (m7QI8WKtVIVc41RI8Mti())
								{
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 13;
							}
							goto IL_01df;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0238;
						IL_01df:
						while (true)
						{
							switch (num3)
							{
							case 17:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 7:
								gP1isoKtlyelTFyQkUWN(_003CcompositeRegion_003E5__2, editCompositeRegionViewModel);
								num3 = 11;
								continue;
							case 3:
								awaiter = rVXHPyKtvSEbJTdEsKss(kika6oKtspxM2ckHKaEB(U6dpC7KtgyIIAQEU59Sb(editCompositeRegionViewModel.InSight), undoGraphicChange));
								num3 = 4;
								continue;
							case 10:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 14:
								editCompositeRegionViewModel.CsIwmNkyMX = _003CcompositeRegion_003E5__2;
								num3 = 20;
								continue;
							case 18:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 9:
							case 19:
								_003C_003Eu__1 = default;
								num3 = 17;
								continue;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto IL_0144;
							case 12:
								if (editCompositeRegionViewModel.Enabled)
								{
									num3 = 5;
									if (YcOU2BKtnM4imcBAcmCi())
									{
										continue;
									}
									goto case 13;
								}
								goto end_IL_01df;
							case 13:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0144;
							case 1:
								awaiter.GetResult();
								goto case 14;
							case 8:
								if (!(editCompositeRegionViewModel.IsInitialized & undo))
								{
									awaiter = rVXHPyKtvSEbJTdEsKss(iGGVk5KtrGmp5Dv7Whm8(undoGraphicChange));
									num3 = 16;
								}
								else
								{
									num3 = 3;
								}
								continue;
							case 11:
								undoGraphicChange = new UndoGraphicChange(editCompositeRegionViewModel.InSight, editCompositeRegionViewModel.CellName, editCompositeRegionViewModel.CsIwmNkyMX, _003CcompositeRegion_003E5__2, display);
								num3 = 8;
								continue;
							case 6:
								return;
							case 0:
								num2 = (_003C_003E1__state = 1);
								num3 = 18;
								continue;
							case 2:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								_003CcompositeRegion_003E5__2 = new CvsDisplayableComposite((CvsGraphicComposite)t4ARTaKtdQumUWXNY63v(MGfTbVKtfo6x7SFbcZef(editCompositeRegionViewModel.Graphic)));
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto case 1;
							case 20:
								{
									_003CcompositeRegion_003E5__2 = null;
									goto end_IL_01df;
								}
								IL_0144:
								awaiter.GetResult();
								num3 = 14;
								continue;
							}
							goto IL_0238;
							continue;
							end_IL_01df:
							break;
						}
						goto end_IL_0028;
						IL_0238:
						YcOU2BKtnM4imcBAcmCi();
						if (m7QI8WKtVIVc41RI8Mti())
						{
							num3 = 2;
						}
						else
						{
							num3 = 19;
							if (m7QI8WKtVIVc41RI8Mti())
							{
							}
						}
						goto IL_01df;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (YcOU2BKtnM4imcBAcmCi())
					{
						continue;
					}
					break;
				case 1:
				case 5:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				editCompositeRegionViewModel = _003C_003E4__this;
				num = 3;
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
		internal static object MGfTbVKtfo6x7SFbcZef(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object t4ARTaKtdQumUWXNY63v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gP1isoKtlyelTFyQkUWN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Tag = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U6dpC7KtgyIIAQEU59Sb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kika6oKtspxM2ckHKaEB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rVXHPyKtvSEbJTdEsKss(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iGGVk5KtrGmp5Dv7Whm8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoGraphicChange)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YcOU2BKtnM4imcBAcmCi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m7QI8WKtVIVc41RI8Mti()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsDisplayableComposite CsIwmNkyMX;

	private string TBYw1JOMeh;

	private SourceLink ljlwz6ZV77;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.CompositeRegion;
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
			return TBYw1JOMeh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref TBYw1JOMeh, value, (string)StuFyaFtRXY5Q00CNtA(5436)))
			{
				raMi93FzxngoVuYjigj(this, StuFyaFtRXY5Q00CNtA(27684));
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
			if (ljlwz6ZV77 == null)
			{
				ljlwz6ZV77 = new SourceLink(this);
			}
			return ljlwz6ZV77;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditCompositeRegionViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imagecellLocation, bool isInitialized, bool mustBeExtrudeable = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!sJ9i2dFNos0EVia7txk())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				CsIwmNkyMX = new CvsDisplayableComposite((CvsGraphicComposite)eyfS1RFhQcLl2KN81yg(DDcNWcFuB4bA1U3SLtO(Graphic)));
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				base._002Ector(insight, loc, displayName, isInitialized);
				_ = 0;
				num = ((!WWOB4GFQrPol6vnZv1C()) ? 7 : 6);
				break;
			case 1:
				JMNVckF11bf3XWFpslw(Graphic, this);
				goto default;
			case 2:
			case 6:
				Graphic = (CvsEditableDisplayGraphic)wLwni3FcDtP1LVQEyNH(CellLocation, cells, imagecellLocation, mustBeExtrudeable);
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				VGYp2LF2SkK9IAecmP4();
				num = 0;
				break;
			case 3:
				JMNVckF11bf3XWFpslw(CsIwmNkyMX, this);
				num = 8;
				break;
			case 8:
				Refresh(cells, init: true);
				num = 9;
				break;
			case 9:
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
		YuwvrxMLOFCjWHK03Jp(Graphic, cells[inputImageCell]);
		EditableGraphicHelper.UpdateCompositeRegion(Graphic as CvsDisplayableComposite, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateCompositeRegion(CvsDisplayableComposite composite)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CsIwmNkyMX = new CvsDisplayableComposite((CvsGraphicComposite)eyfS1RFhQcLl2KN81yg(DDcNWcFuB4bA1U3SLtO(composite)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSend_003Ed__16))]
	public override Task Send(bool undo = true, CvsInSightDisplay display = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CSend_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (WWOB4GFQrPol6vnZv1C())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder = vBpbk5MKU40VfZNkgyX();
				num = 1;
				continue;
			case 5:
				stateMachine.undo = undo;
				_ = 0;
				if (WWOB4GFQrPol6vnZv1C())
				{
					num = 6;
					if (WWOB4GFQrPol6vnZv1C())
					{
						continue;
					}
					goto case 3;
				}
				num = 0;
				continue;
			case 3:
			case 6:
				stateMachine.display = display;
				goto default;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void AygwhPafsC(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VGYp2LF2SkK9IAecmP4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wLwni3FcDtP1LVQEyNH(CvsCellLocation loc, object P_1, CvsCellLocation inputImageLocation, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructComposite(loc, (CvsCellCollection)P_1, inputImageLocation, mustBeExtrudeable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JMNVckF11bf3XWFpslw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Tag = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DDcNWcFuB4bA1U3SLtO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eyfS1RFhQcLl2KN81yg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WWOB4GFQrPol6vnZv1C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sJ9i2dFNos0EVia7txk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StuFyaFtRXY5Q00CNtA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void raMi93FzxngoVuYjigj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YuwvrxMLOFCjWHK03Jp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder vBpbk5MKU40VfZNkgyX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
