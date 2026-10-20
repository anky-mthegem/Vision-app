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

public class EditPointViewModel : EditableGraphicsViewModel, QpXw26KT7OGd3H62pw
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSend_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditPointViewModel _003C_003E4__this;

		public CvsInSightDisplay display;

		public bool undo;

		private CvsDisplayablePoint _003Cpoint_003E5__2;

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
			if (!vVKZCyKtZGVILwNBnnFg())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (vVKZCyKtZGVILwNBnnFg())
				{
					goto IL_0041;
				}
			}
			goto IL_0336;
			IL_0336:
			EditPointViewModel editPointViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoGraphicChange undoGraphicChange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					editPointViewModel = _003C_003E4__this;
					goto case 2;
				case 1:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 8;
								if (false)
								{
									goto IL_0082;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_01da;
						IL_0082:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 13;
						goto IL_01da;
						IL_01da:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 8:
								if (editPointViewModel.Enabled)
								{
									_ = 0;
									if (jVHoeuKtP9hCqM98SWNM())
									{
										num3 = 18;
										continue;
									}
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								}
								goto end_IL_01da;
							case 5:
								if (editPointViewModel.IsInitialized & undo)
								{
									num3 = 19;
									continue;
								}
								awaiter = ((Task)uyIhpGKtSkqpQPrx9OFu(undoGraphicChange)).GetAwaiter();
								num3 = 9;
								continue;
							case 3:
							case 11:
							case 17:
								editPointViewModel.bSAy6PxkdN = _003Cpoint_003E5__2;
								num3 = 20;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 12:
								return;
							case 19:
								awaiter = Ggp2LaKtolquvtvGT7gx(iKpnsIKtGlYlfjwh6osA(YEH5gyKtb0CT3NEKr2nL(editPointViewModel.InSight), undoGraphicChange));
								num3 = 16;
								continue;
							case 15:
								return;
							case 13:
								awaiter.GetResult();
								goto case 3;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 18:
								_003Cpoint_003E5__2 = new CvsDisplayablePoint((CvsGraphicPoint)IpqTqNKtBKKT8asjv6fd(editPointViewModel.Graphic.InSightGraphic));
								undoGraphicChange = new UndoGraphicChange(editPointViewModel.InSight, editPointViewModel.CellName, editPointViewModel.bSAy6PxkdN, _003Cpoint_003E5__2, display);
								num3 = 5;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto case 3;
							case 7:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								continue;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								}
								goto case 13;
							case 20:
								_003Cpoint_003E5__2 = null;
								goto end_IL_01da;
							}
							goto IL_0082;
							continue;
							end_IL_01da:
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
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0336;
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
		internal static object IpqTqNKtBKKT8asjv6fd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YEH5gyKtb0CT3NEKr2nL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iKpnsIKtGlYlfjwh6osA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Ggp2LaKtolquvtvGT7gx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uyIhpGKtSkqpQPrx9OFu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoGraphicChange)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jVHoeuKtP9hCqM98SWNM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vVKZCyKtZGVILwNBnnFg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsDisplayablePoint bSAy6PxkdN;

	private string yc9yugsyJK;

	private SourceLink uHtyFx9s9M;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Point;
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
			return yc9yugsyJK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref yc9yugsyJK, value, (string)waiLGNMratSfb3xHSl2(5436)))
			{
				rjQQ7hMPqNnBNYvDXMy(this, waiLGNMratSfb3xHSl2(27684));
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
			if (uHtyFx9s9M == null)
			{
				uHtyFx9s9M = new SourceLink(this);
			}
			return uHtyFx9s9M;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditPointViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, CvsCellLocation imageCellLocation)
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
			case 3:
				kYx2qRMv8e8hOTbaU2d(Graphic, this);
				num = 6;
				break;
			case 7:
				bSAy6PxkdN = new CvsDisplayablePoint((CvsGraphicPoint)v7PwKVMs6SWZGK30kWa(bBSDVHMgKOZXK7YtRoE(Graphic)));
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
				SwbbMeMdroeZqHEyugW();
				fjmqYiMV4ErLYQJDmYB();
				num = (HeIQWwMfuOvxFOJgBRY() ? 5 : 4);
				break;
			case 2:
			case 5:
				Graphic = (CvsEditableDisplayGraphic)sdo4FFMlqsfZplP6YyY(loc, cells, imageCellLocation);
				num = 7;
				break;
			case 1:
			case 4:
				base._002Ector(insight, loc, displayName);
				goto case 2;
			case 6:
				Refresh(cells, init: true);
				num = 8;
				if (false)
				{
					return;
				}
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
		GmenyRMBeV2y5H9cXUP(Graphic, pBC5mMMZtptty6hUOsQ(cells, inputImageCell));
		EditableGraphicHelper.UpdatePoint(Graphic as CvsDisplayablePoint, cells, pass, Value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSend_003Ed__12))]
	public override Task Send(bool undo = true, CvsInSightDisplay display = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSend_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				if (!HeIQWwMfuOvxFOJgBRY())
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (HeIQWwMfuOvxFOJgBRY())
				{
				}
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 2:
			case 3:
				stateMachine.display = display;
				goto default;
			case 5:
				stateMachine.undo = undo;
				_ = 1;
				num = (HeIQWwMfuOvxFOJgBRY() ? 1 : 2);
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void hLCyA9mcql(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SwbbMeMdroeZqHEyugW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sdo4FFMlqsfZplP6YyY(CvsCellLocation loc, object P_1, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructPoint(loc, (CvsCellCollection)P_1, inputImageLocation);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bBSDVHMgKOZXK7YtRoE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v7PwKVMs6SWZGK30kWa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kYx2qRMv8e8hOTbaU2d(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Tag = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fjmqYiMV4ErLYQJDmYB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HeIQWwMfuOvxFOJgBRY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object waiLGNMratSfb3xHSl2(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rjQQ7hMPqNnBNYvDXMy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pBC5mMMZtptty6hUOsQ(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GmenyRMBeV2y5H9cXUP(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}
}
