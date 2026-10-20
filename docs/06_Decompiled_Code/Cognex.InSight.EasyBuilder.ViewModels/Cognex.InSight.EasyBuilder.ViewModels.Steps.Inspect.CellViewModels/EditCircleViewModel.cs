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

public class EditCircleViewModel : EditableGraphicsViewModel, QpXw26KT7OGd3H62pw
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditCircleViewModel _003C_003E4__this;

		public CvsInSightDisplay display;

		public bool undo;

		private CvsDisplayableCircle _003Ccircle_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GPns52KtJbLdpQH5PaOi();
			int num = ((!sD3jWXKtw9vmdsGRdAxD()) ? 4 : 2);
			int num2 = default;
			TaskAwaiter awaiter = default;
			EditCircleViewModel editCircleViewModel = default;
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
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 14;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
							case 10:
								editCircleViewModel.RngwJLgLtc = _003Ccircle_003E5__2;
								num3 = 20;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								undoGraphicChange = new UndoGraphicChange(editCircleViewModel.InSight, editCircleViewModel.CellName, editCircleViewModel.RngwJLgLtc, _003Ccircle_003E5__2, display);
								goto case 1;
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto IL_009e;
							case 14:
								_003C_003Eu__1 = default;
								num3 = 13;
								if (!GPns52KtJbLdpQH5PaOi())
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 19:
								_003C_003Eu__1 = awaiter;
								num3 = 18;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_009e;
							case 11:
								_003C_003Eu__1 = default;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 17:
								_003Ccircle_003E5__2 = new CvsDisplayableCircle((CvsGraphicCircle)Oc0kHmKtevWsKHaJrypZ(buUeRLKtamRATDQvSd9C(editCircleViewModel.Graphic)));
								sD3jWXKtw9vmdsGRdAxD();
								if (GPns52KtJbLdpQH5PaOi())
								{
									num3 = 1;
									if (GPns52KtJbLdpQH5PaOi())
									{
									}
								}
								else
								{
									num3 = 4;
								}
								continue;
							case 0:
								num2 = (_003C_003E1__state = 1);
								num3 = 19;
								continue;
							case 1:
							case 3:
								if (editCircleViewModel.IsInitialized & undo)
								{
									num3 = 6;
									continue;
								}
								awaiter = ((Task)xoMFd1KtilICIQWtxdAA(undoGraphicChange)).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto case 16;
								}
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 18:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								if (editCircleViewModel.Enabled)
								{
									num3 = 17;
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								continue;
							case 6:
								awaiter = HlOwGrKtDYAwZDOEL8JU(EvaQriKtI55f9d1iuZRR(CbKPTJKtOLZMIjAgI33I(editCircleViewModel.InSight), undoGraphicChange));
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 20:
								{
									_003Ccircle_003E5__2 = null;
									break;
								}
								IL_009e:
								awaiter.GetResult();
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 14;
							}
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
					break;
				default:
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					editCircleViewModel = _003C_003E4__this;
					num = 3;
					if (sD3jWXKtw9vmdsGRdAxD())
					{
						continue;
					}
					break;
				case 5:
					break;
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
		internal static object buUeRLKtamRATDQvSd9C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Oc0kHmKtevWsKHaJrypZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CbKPTJKtOLZMIjAgI33I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EvaQriKtI55f9d1iuZRR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HlOwGrKtDYAwZDOEL8JU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xoMFd1KtilICIQWtxdAA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoGraphicChange)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sD3jWXKtw9vmdsGRdAxD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GPns52KtJbLdpQH5PaOi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsDisplayableCircle RngwJLgLtc;

	private string RpYw9EHNb6;

	private SourceLink sRlwrXllQy;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Circle;
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
			return RpYw9EHNb6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref RpYw9EHNb6, value, (string)dokuufFHbUUTybQJOtn(5436)))
			{
				FirePropertyChangedExplicit((string)dokuufFHbUUTybQJOtn(27684));
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
			return sRlwrXllQy ?? (sRlwrXllQy = new SourceLink(this));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditCircleViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imageCellLocation)
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
			case 0:
			case 3:
				RngwJLgLtc = new CvsDisplayableCircle((CvsGraphicCircle)BSRECXFUYvwjWhAHTDK(o4CpUIFYmqukAJF8xVG(Graphic)));
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 5:
				Graphic = (CvsEditableDisplayGraphic)qinTOgFM5L0bLRckq1i(loc, cells, imageCellLocation);
				goto case 0;
			case 7:
				base._002Ector(insight, loc, displayName);
				b6dv3CFyM4gBvjLJOkv();
				num = ((!VO0uEDF050ra6MybQvj()) ? 5 : 0);
				continue;
			case 1:
				Refresh(cells, init: true);
				num = 8;
				continue;
			case 6:
				cEsTgHFFl94lpJDPdHY();
				num = 7;
				if (b6dv3CFyM4gBvjLJOkv())
				{
					continue;
				}
				break;
			case 4:
				break;
			case 8:
				return;
			}
			Graphic.Tag = this;
			num = 1;
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
		iP1RjIFmWxq25kBmCvA(Graphic, aj2GvgFxAGGbqUD3pHe(cells, inputImageCell));
		EditableGraphicHelper.UpdateCircle(Graphic as CvsDisplayableCircle, cells, pass);
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
			case 2:
			case 4:
				stateMachine.undo = undo;
				num = 1;
				if (VO0uEDF050ra6MybQvj())
				{
				}
				break;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!VO0uEDF050ra6MybQvj())
				{
					num = 4;
					if (VO0uEDF050ra6MybQvj())
					{
					}
				}
				else
				{
					num = 7;
				}
				break;
			case 1:
				stateMachine.display = display;
				goto case 0;
			default:
				num = 0;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 5:
			case 7:
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
	private void uHhwVRZ0ya(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cEsTgHFFl94lpJDPdHY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qinTOgFM5L0bLRckq1i(CvsCellLocation loc, object P_1, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructCircle(loc, (CvsCellCollection)P_1, inputImageLocation);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o4CpUIFYmqukAJF8xVG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BSRECXFUYvwjWhAHTDK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b6dv3CFyM4gBvjLJOkv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VO0uEDF050ra6MybQvj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dokuufFHbUUTybQJOtn(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aj2GvgFxAGGbqUD3pHe(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iP1RjIFmWxq25kBmCvA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}
}
