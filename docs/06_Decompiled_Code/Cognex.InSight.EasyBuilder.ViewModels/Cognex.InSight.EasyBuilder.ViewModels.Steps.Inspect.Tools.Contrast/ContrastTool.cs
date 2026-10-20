using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Contrast;

[Export(typeof(ContrastTool))]
public class ContrastTool : EzRangeTool<EditFloatViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ContrastTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xvBGAkKQV1hvpQ2q9tMZ();
			int num = ((!U7Y35uKQf1slla5vjaqp()) ? 1 : 5);
			int num2 = default;
			ContrastTool contrastTool = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = l7xqReKQljiPWpS43rPt(hyg8HRKQdk5oac4PNT0I(contrastTool.Region, delta));
							num3 = 0;
							if (false)
							{
								goto IL_0052;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						goto IL_00c0;
						IL_013e:
						awaiter.GetResult();
						goto end_IL_0028;
						IL_0081:
						num2 = (_003C_003E1__state = 0);
						_ = 0;
						num3 = ((!xvBGAkKQV1hvpQ2q9tMZ()) ? 5 : 8);
						goto IL_00c0;
						IL_0052:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						if (false)
						{
							goto IL_0065;
						}
						goto IL_00c0;
						IL_0065:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							if (!xvBGAkKQV1hvpQ2q9tMZ())
							{
								goto IL_0081;
							}
							goto IL_00c0;
						}
						goto IL_013e;
						IL_00c0:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 8:
								break;
							case 0:
								goto IL_0065;
							case 3:
								goto IL_0081;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 5:
								return;
							case 9:
								goto IL_013e;
							}
							break;
						}
						goto IL_0052;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					contrastTool = _003C_003E4__this;
					num = 4;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
				case 1:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
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
		internal static object hyg8HRKQdk5oac4PNT0I(object P_0, float delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Shift(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter l7xqReKQljiPWpS43rPt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xvBGAkKQV1hvpQ2q9tMZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U7Y35uKQf1slla5vjaqp()
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
	private struct _003COnSetRange_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ContrastTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			(double, double) minMax = default;
			ContrastTool contrastTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(QixZeZKQvkD5WaGbHc2m(contrastTool.Contrast));
							monJ4tKQgS3aWU5OfWJ5();
							if (!VUOfj3KQsSyBrFuKDVXK())
							{
								num3 = 1;
								if (!monJ4tKQgS3aWU5OfWJ5())
								{
									goto IL_004f;
								}
							}
							else
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_00ac;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_0069;
						IL_00c2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						goto IL_0069;
						IL_004f:
						_003C_003Eu__1 = awaiter;
						goto IL_00c2;
						IL_00ac:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_0069;
						IL_0069:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 3:
								goto IL_00ac;
							default:
								goto IL_00c2;
							case 0:
							case 1:
							{
								UndoSetRange<double> undoSetRange = new UndoSetRange<double>(contrastTool.Parent, (string)hCQfwAKQrOiEUpShETFY(contrastTool), (string)nIQ7VoKQPSEXmgPPJ5Pa(contrastTool.Min), (string)nIQ7VoKQPSEXmgPPJ5Pa(contrastTool.Max), contrastTool.Min.Value, contrastTool.Max.Value, minMax.Item1, minMax.Item2);
								awaiter = ((Task)G6lCYZKQZpJ72UrBxaOr(contrastTool.InSight.UndoHandler, undoSetRange)).GetAwaiter();
								num3 = 6;
								if (monJ4tKQgS3aWU5OfWJ5())
								{
									continue;
								}
								goto case 6;
							}
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 8:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_004f;
						end_IL_0018:;
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
					num = 0;
					continue;
				case 3:
					num2 = _003C_003E1__state;
					monJ4tKQgS3aWU5OfWJ5();
					num = (VUOfj3KQsSyBrFuKDVXK() ? 5 : 4);
					continue;
				case 1:
				case 4:
					contrastTool = _003C_003E4__this;
					goto case 2;
				case 0:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (VUOfj3KQsSyBrFuKDVXK())
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
		internal static double QixZeZKQvkD5WaGbHc2m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FloatViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hCQfwAKQrOiEUpShETFY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nIQ7VoKQPSEXmgPPJ5Pa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G6lCYZKQZpJ72UrBxaOr(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool monJ4tKQgS3aWU5OfWJ5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VUOfj3KQsSyBrFuKDVXK()
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
	private struct _003CWriteFixturedGraphics_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ContrastTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0257;
			IL_001a:
			int num2 = default;
			ContrastTool contrastTool = default;
			try
			{
				int num3;
				TaskAwaiter<CvsCogSheetResult> awaiter = default;
				TaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 2;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 10;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 14;
					if (false)
					{
						goto IL_0214;
					}
				}
				while (true)
				{
					switch (num3)
					{
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 2:
						awaiter2 = QUu9jUKQkfyjYT4gCdA5(cUa2jYKQSiOwLxtKqULU(contrastTool.InSight, uZHOLVKQGX1FUmgsCf0H(contrastTool.Region), G2PX8CKQogj5xLueJ16M(contrastTool.Region)));
						num3 = 8;
						continue;
					case 3:
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 6;
						continue;
					default:
						awaiter = ((CvsCogSocket)RPj0GXKQ8mp5FG6gRLWb(contrastTool.InSight)).Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
						num3 = 13;
						continue;
					case 13:
						if (!awaiter.IsCompleted)
						{
							num3 = 15;
							continue;
						}
						break;
					case 6:
						awaiter2.GetResult();
						goto default;
					case 9:
						_003C_003Eu__2 = awaiter;
						num3 = 11;
						if (!pyhKueKQbV5QCOKa1mMg())
						{
							continue;
						}
						goto case 10;
					case 10:
						_003C_003Eu__2 = default;
						num3 = 4;
						continue;
					case 11:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 8:
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							num3 = 0;
							continue;
						}
						goto case 6;
					case 14:
						_003C_003Eu__1 = default;
						_ = 1;
						if (pyhKueKQbV5QCOKa1mMg())
						{
							num3 = 1;
							continue;
						}
						num3 = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 15;
					case 15:
						num2 = (_003C_003E1__state = 1);
						num3 = 9;
						continue;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 12;
						continue;
					case 12:
						return;
					case 16:
						break;
					}
					break;
				}
				goto IL_0214;
				IL_0214:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_028e;
			IL_0257:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					goto IL_028e;
				case 0:
					goto IL_02a3;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 6:
					return;
				}
				break;
				IL_02a3:
				contrastTool = _003C_003E4__this;
				pyhKueKQbV5QCOKa1mMg();
				if (!Ig3W8WKQBxT9mEBEId8k())
				{
					num = 4;
					if (Ig3W8WKQBxT9mEBEId8k())
					{
						continue;
					}
					goto IL_028e;
				}
				num = 5;
			}
			goto IL_001a;
			IL_028e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0257;
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
		internal static CvsCellLocation uZHOLVKQGX1FUmgsCf0H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G2PX8CKQogj5xLueJ16M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cUa2jYKQSiOwLxtKqULU(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QUu9jUKQkfyjYT4gCdA5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RPj0GXKQ8mp5FG6gRLWb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ig3W8WKQBxT9mEBEId8k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pyhKueKQbV5QCOKa1mMg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private FloatViewModel bgcCqXOncb;

	[CompilerGenerated]
	private EditCompositeRegionViewModel F0PCiawAdw;

	[CompilerGenerated]
	private CheckBoxViewModel NMoCkPkQEg;

	public FloatViewModel Contrast
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bgcCqXOncb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bgcCqXOncb = value;
		}
	}

	public EditCompositeRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F0PCiawAdw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			F0PCiawAdw = value;
		}
	}

	public override string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)gfbPw2WsRTgmc5DYJnx(sp5P0MWlAepdMg8nRkE(), fr9qorWg4IvhUPdJU20(Contrast));
		}
	}

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Contrast;
		}
	}

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_ContrastIcon;
		}
	}

	public CheckBoxViewModel Invert
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NMoCkPkQEg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NMoCkPkQEg = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContrastTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eqAeTXWwFpC8yYe08B6();
		NWGABkWJyYqFfa5089w(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!I7wi9BWeVxRiCQUYa8m(relativeCellName, Bf7hwtWahR6Il3hDI8E(5684)))
				{
					num = 15;
					break;
				}
				Region = new EditCompositeRegionViewModel(InSight, cells, loc, (string)IKZ8N3WfnjQjyi8dRQF(), YMd9HPWdX1tVKBGyxxh(InputImage), IsInitialized);
				num = 16;
				break;
			case 0:
				AddProperty(InputCompositeRegion);
				num = 1;
				break;
			case 8:
				if (!I7wi9BWeVxRiCQUYa8m(relativeCellName, Bf7hwtWahR6Il3hDI8E(2206)))
				{
					num = 7;
					break;
				}
				Contrast = new FloatViewModel(InSight, cells, loc, (string)UWiIpDWOE4yLZbeiOV3());
				AddProperty(Contrast);
				num = 9;
				break;
			case 4:
				if (!I7wi9BWeVxRiCQUYa8m(relativeCellName, Bf7hwtWahR6Il3hDI8E(6122)))
				{
					num = 5;
					break;
				}
				Invert = new CheckBoxViewModel(InSight, cells, loc, (string)U5swcOWic2haeWfZF4r(), IsInitialized);
				AddProperty(Invert);
				return;
			case 7:
				if (!I7wi9BWeVxRiCQUYa8m(relativeCellName, Bf7hwtWahR6Il3hDI8E(6148)))
				{
					num = 13;
					if (false)
					{
						return;
					}
					break;
				}
				Min = new EditFloatViewModel(InSight, cells, loc, (string)VTnkRZWIXS7wGxZipw7());
				AddProperty(Min);
				return;
			case 9:
				return;
			default:
				num = 2;
				break;
			case 13:
				if (!I7wi9BWeVxRiCQUYa8m(relativeCellName, Bf7hwtWahR6Il3hDI8E(6138)))
				{
					num = 4;
					break;
				}
				Max = new EditFloatViewModel(InSight, cells, loc, (string)ykaJaoWDSwfZXX6WMN4());
				num = 6;
				if (true)
				{
					break;
				}
				return;
			case 16:
				AddProperty(Region);
				num = 17;
				break;
			case 15:
				return;
			case 5:
				if (!(relativeCellName == (string)Bf7hwtWahR6Il3hDI8E(19504)))
				{
					num = 3;
					if (!OgWBCRWKqIwpblut4wy())
					{
						return;
					}
				}
				else
				{
					InputCompositeRegion = new InputCompositeRegionViewModel(this, cells, loc, (string)qTjZU1WnV9JY4U1ibkb(), (string)GUo0wkWVPUaL4eiPLXE(), Region, IsInitialized);
					num = 0;
				}
				break;
			case 11:
				return;
			case 14:
				return;
			case 10:
			case 12:
				return;
			case 2:
				return;
			case 1:
				return;
			case 6:
				AddProperty(Max);
				_ = 0;
				num = (OgWBCRWKqIwpblut4wy() ? 12 : 14);
				break;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__5))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!UYvMS6W5Sj8BM5shGni())
		{
			num = 6;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_00c7;
			}
		}
		_003CShiftEditGraphics_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				continue;
			case 5:
				stateMachine.delta = delta;
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 7:
				break;
			}
			break;
		}
		goto IL_00c7;
		IL_00c7:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OgWBCRWKqIwpblut4wy();
		int num;
		if (!UYvMS6W5Sj8BM5shGni())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0087;
		IL_0046:
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic graphic = default;
		list.Add(graphic);
		num = 6;
		if (1 == 0)
		{
			goto IL_0059;
		}
		goto IL_0087;
		IL_0059:
		list = new List<CvsEditableDisplayGraphic>();
		goto IL_002a;
		IL_002a:
		graphic = Region.Graphic;
		num = 3;
		if (UYvMS6W5Sj8BM5shGni())
		{
			goto IL_0046;
		}
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 4:
				goto IL_0046;
			case 0:
			case 5:
				goto IL_0059;
			case 3:
				if (graphic != null)
				{
					goto IL_0046;
				}
				goto case 6;
			default:
				num = 4;
				continue;
			case 6:
				return (CvsEditableDisplayGraphic[])NmRausWvAWUHHUJH6NJ(list);
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__25))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UYvMS6W5Sj8BM5shGni();
		int num = ((!OgWBCRWKqIwpblut4wy()) ? 3 : 5);
		_003COnSetRange_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = VNKAgcWr6HgLbFd8vnX();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (double min, double max) GetMinMax(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzRangeTool<EditFloatViewModel>.GetMinMax(value, 0.1, 0.0, 255.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__27))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!UYvMS6W5Sj8BM5shGni())
		{
		}
		_003CWriteFixturedGraphics_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = VNKAgcWr6HgLbFd8vnX();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (UYvMS6W5Sj8BM5shGni())
				{
				}
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (UYvMS6W5Sj8BM5shGni() ? 4 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eqAeTXWwFpC8yYe08B6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NWGABkWJyYqFfa5089w(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditFloatViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OgWBCRWKqIwpblut4wy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UYvMS6W5Sj8BM5shGni()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bf7hwtWahR6Il3hDI8E(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I7wi9BWeVxRiCQUYa8m(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UWiIpDWOE4yLZbeiOV3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Contrast;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VTnkRZWIXS7wGxZipw7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ykaJaoWDSwfZXX6WMN4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U5swcOWic2haeWfZF4r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Invert;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qTjZU1WnV9JY4U1ibkb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputCompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GUo0wkWVPUaL4eiPLXE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tY8Y4bDug1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IKZ8N3WfnjQjyi8dRQF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.l1fZTglVqg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation YMd9HPWdX1tVKBGyxxh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sp5P0MWlAepdMg8nRkE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X07tjUoaZN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fr9qorWg4IvhUPdJU20(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gfbPw2WsRTgmc5DYJnx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NmRausWvAWUHHUJH6NJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder VNKAgcWr6HgLbFd8vnX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
