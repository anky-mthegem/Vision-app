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
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class EditAnnulusViewModel : EditableGraphicsViewModel, QpXw26KT7OGd3H62pw
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditAnnulusViewModel _003C_003E4__this;

		public CvsInSightDisplay display;

		public bool undo;

		private CvsDisplayableAnnulus _003Cannulus_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mk87ZsKhulQhOsPV71DR();
			int num = (I0hrnQKhh8KhKnnKKsj5() ? 5 : 2);
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoGraphicChange undoGraphicChange = default;
			EditAnnulusViewModel editAnnulusViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_00ae;
							}
							num3 = 17;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (false)
							{
								goto IL_025d;
							}
						}
						goto IL_015a;
						IL_015a:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 19;
								continue;
							case 4:
								undoGraphicChange = new UndoGraphicChange(editAnnulusViewModel.InSight, editAnnulusViewModel.CellName, editAnnulusViewModel.MTywtY5jlS, _003Cannulus_003E5__2, display);
								num3 = 12;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								continue;
							case 13:
							case 15:
								break;
							case 17:
								if (editAnnulusViewModel.Enabled)
								{
									_003Cannulus_003E5__2 = new CvsDisplayableAnnulus((CvsGraphicAnnulus)w0ov4BKhzC0yDAlKqlf3(znMjG5Kht7XIxKrZ21H7(editAnnulusViewModel.Graphic)));
									num3 = 4;
									continue;
								}
								goto end_IL_0028;
							case 9:
								awaiter.GetResult();
								num3 = 18;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								if (editAnnulusViewModel.IsInitialized & undo)
								{
									awaiter = bM8aUrKt5I4sl4TeVOdv(OgKwS2KtKOO8TEppqP3w(g5hlqhKtLiohqf5EFoHe(editAnnulusViewModel.InSight), undoGraphicChange));
									num3 = 6;
									continue;
								}
								goto IL_01c8;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto case 9;
							default:
								num3 = 9;
								if (!I0hrnQKhh8KhKnnKKsj5())
								{
									continue;
								}
								goto case 18;
							case 7:
								awaiter.GetResult();
								goto case 18;
							case 18:
								editAnnulusViewModel.MTywtY5jlS = _003Cannulus_003E5__2;
								num3 = 20;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 5:
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 7;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 19:
								return;
							case 3:
								goto IL_025d;
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 16;
									continue;
								}
								goto case 9;
							case 20:
								_003Cannulus_003E5__2 = null;
								goto end_IL_0028;
							}
							break;
							IL_01c8:
							awaiter = bM8aUrKt5I4sl4TeVOdv(undoGraphicChange.Do());
							mk87ZsKhulQhOsPV71DR();
							num3 = (I0hrnQKhh8KhKnnKKsj5() ? 13 : 5);
						}
						goto IL_00ae;
						IL_00ae:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_015a;
						IL_025d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				editAnnulusViewModel = _003C_003E4__this;
				num = 4;
				if (I0hrnQKhh8KhKnnKKsj5())
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
		internal static object znMjG5Kht7XIxKrZ21H7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object w0ov4BKhzC0yDAlKqlf3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g5hlqhKtLiohqf5EFoHe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OgKwS2KtKOO8TEppqP3w(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bM8aUrKt5I4sl4TeVOdv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mk87ZsKhulQhOsPV71DR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I0hrnQKhh8KhKnnKKsj5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsDisplayableAnnulus MTywtY5jlS;

	private string t1ZwYEKl0n;

	private SourceLink aZWw0GtDUq;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Annulus;
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
			return t1ZwYEKl0n;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref t1ZwYEKl0n, value, (string)SuSwpHFA7Tp6evCsLFN(5436)))
			{
				FirePropertyChangedExplicit((string)SuSwpHFA7Tp6evCsLFN(27684));
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
			if (aZWw0GtDUq == null)
			{
				aZWw0GtDUq = new SourceLink(this);
			}
			return aZWw0GtDUq;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditAnnulusViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imageCellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!b7P148F4adTFLJUL4iA()) ? 5 : 7);
		while (true)
		{
			switch (num)
			{
			case 1:
				MTywtY5jlS = new CvsDisplayableAnnulus((CvsGraphicAnnulus)jj6TBKF6kmHgsZ4xgqh(Graphic.InSightGraphic));
				break;
			case 6:
				Refresh(cells, init: true);
				num = 8;
				continue;
			case 2:
				Graphic = (CvsEditableDisplayGraphic)THKcThFj3yJelbsFFXY(loc, cells, imageCellLocation);
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 7:
				w9GSocF3Zn9n4OF2ayp();
				num = 3;
				continue;
			case 3:
				base._002Ector(insight, loc, displayName);
				num = 2;
				if (b7P148F4adTFLJUL4iA())
				{
					continue;
				}
				break;
			case 8:
				return;
			}
			CxFKZXFC1BE7P7vjkNS(Graphic, this);
			num = 6;
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
		yTX1oHFRp6kHhukGSEn(Graphic, cells[inputImageCell]);
		LREgLKFWx8guaNXMSRG(Graphic as CvsDisplayableAnnulus, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSend_003Ed__12))]
	public override Task Send(bool undo = true, CvsInSightDisplay display = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSend_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				stateMachine.display = display;
				goto case 1;
			default:
				num = 1;
				continue;
			case 4:
				stateMachine.undo = undo;
				dZg32wF7fAHpgFBDYCW();
				if (b7P148F4adTFLJUL4iA())
				{
					num = 7;
					if (dZg32wF7fAHpgFBDYCW())
					{
					}
				}
				else
				{
					num = 0;
				}
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 6:
				stateMachine._003C_003Et__builder = eP8Uf9FT5s8MaF40Gus();
				num = 2;
				if (b7P148F4adTFLJUL4iA())
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
	private void tmvwZX4aPD(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w9GSocF3Zn9n4OF2ayp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object THKcThFj3yJelbsFFXY(CvsCellLocation loc, object P_1, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructAnnulus(loc, (CvsCellCollection)P_1, inputImageLocation);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jj6TBKF6kmHgsZ4xgqh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CxFKZXFC1BE7P7vjkNS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Tag = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b7P148F4adTFLJUL4iA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dZg32wF7fAHpgFBDYCW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SuSwpHFA7Tp6evCsLFN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yTX1oHFRp6kHhukGSEn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LREgLKFWx8guaNXMSRG(object P_0, object P_1, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateAnnulus((CvsDisplayableAnnulus)P_0, (CvsCellCollection)P_1, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder eP8Uf9FT5s8MaF40Gus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
