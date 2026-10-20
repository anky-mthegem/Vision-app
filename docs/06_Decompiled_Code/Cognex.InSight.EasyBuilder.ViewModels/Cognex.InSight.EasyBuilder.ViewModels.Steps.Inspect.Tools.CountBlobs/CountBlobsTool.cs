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

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CountBlobs;

[Export(typeof(CountBlobsTool))]
public class CountBlobsTool : EzRangeTool<EditIntViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountBlobsTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			CountBlobsTool countBlobsTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = KdGh3KKm4eGublNUw0Dk(jTvBnxKm9pceIxOyZtP9(countBlobsTool.Region, delta));
							_ = 0;
							num3 = ((!yVCjx9KmpvLydZKmWn5v()) ? 8 : 3);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (hmH0hnKmXjwBSBVSkA9c())
								{
								}
								continue;
							case 0:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 2:
								return;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (hmH0hnKmXjwBSBVSkA9c())
								{
								}
								continue;
							case 9:
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
				default:
					num = 4;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					yVCjx9KmpvLydZKmWn5v();
					if (!hmH0hnKmXjwBSBVSkA9c())
					{
						num = 3;
						if (yVCjx9KmpvLydZKmWn5v())
						{
							continue;
						}
						goto case 1;
					}
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 3:
					countBlobsTool = _003C_003E4__this;
					goto case 2;
				case 4:
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
		internal static object jTvBnxKm9pceIxOyZtP9(object P_0, float delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Shift(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KdGh3KKm4eGublNUw0Dk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yVCjx9KmpvLydZKmWn5v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hmH0hnKmXjwBSBVSkA9c()
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
	private struct _003COnSetRange_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountBlobsTool _003C_003E4__this;

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
			if (!kChsTDKm3ox2G9dWa8MC())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01ec;
			IL_0228:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01ec;
			IL_01ec:
			CountBlobsTool countBlobsTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num = 2;
					continue;
				case 1:
				case 4:
					countBlobsTool = _003C_003E4__this;
					num = 5;
					continue;
				case 2:
					goto IL_0228;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3 = default;
				int num4;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					num3 = HBqbrFKmjg76xsneRSxQ(countBlobsTool.Count);
					num4 = 10;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num4 = 0;
				}
				UndoSetRange<int> undoSetRange = default;
				while (true)
				{
					switch (num4)
					{
					case 9:
						num2 = (_003C_003E1__state = 0);
						num4 = 4;
						continue;
					case 10:
					{
						int newMax = num3;
						undoSetRange = new UndoSetRange<int>(countBlobsTool.Parent, (string)gK0T7gKm6sCHsi6ETZAm(countBlobsTool), (string)JZcOgcKmCVO36BxS8UYG(countBlobsTool.Min), (string)JZcOgcKmCVO36BxS8UYG(countBlobsTool.Max), countBlobsTool.Min.Value, countBlobsTool.Max.Value, num3, newMax);
						RLJjMPKm7jG8DYpWxLw3();
						if (!kChsTDKm3ox2G9dWa8MC())
						{
							num4 = 5;
							if (true)
							{
								continue;
							}
							goto case 1;
						}
						num4 = 7;
						continue;
					}
					case 1:
					case 5:
						awaiter = cZDV05KmWuVhpMKTobY5(I8dHPQKmRxhCvkoMS1Yh(gRscPpKmAR2es0PdvTLu(countBlobsTool.InSight), undoSetRange));
						num4 = 8;
						if (RLJjMPKm7jG8DYpWxLw3())
						{
							continue;
						}
						goto case 8;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num4 = 9;
							continue;
						}
						break;
					case 2:
						num2 = (_003C_003E1__state = -1);
						num4 = 11;
						continue;
					case 6:
						return;
					case 7:
						return;
					case 0:
						_003C_003Eu__1 = default;
						num4 = 2;
						continue;
					case 4:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					default:
						num4 = 3;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 11:
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
			goto IL_0228;
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
		internal static int HBqbrFKmjg76xsneRSxQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gK0T7gKm6sCHsi6ETZAm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JZcOgcKmCVO36BxS8UYG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gRscPpKmAR2es0PdvTLu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I8dHPQKmRxhCvkoMS1Yh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter cZDV05KmWuVhpMKTobY5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RLJjMPKm7jG8DYpWxLw3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kChsTDKm3ox2G9dWa8MC()
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
	private struct _003CWriteFixturedGraphics_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountBlobsTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!dP4V0aKmynpm5GfNoXUg())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					return;
				}
			}
			CountBlobsTool countBlobsTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					countBlobsTool = _003C_003E4__this;
					num = 1;
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
				case 4:
					break;
				case 1:
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
								awaiter = _003C_003Eu__2;
								num3 = 10;
								if (dP4V0aKmynpm5GfNoXUg())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
								num2 = (_003C_003E1__state = 1);
								num3 = 7;
								if (p1obhLKmTx6yfS5aYGXl())
								{
									continue;
								}
								goto case 13;
							case 13:
								awaiter = ((CvsCogSocketSheet)DnZAL2KmHd04XRCpVMok(zPkYTOKmUWaZGLcLrEuD(countBlobsTool.InSight))).RunAsync(false).GetAwaiter();
								goto case 3;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 0;
								continue;
							case 6:
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto IL_010d;
							default:
								num3 = 13;
								if (!dP4V0aKmynpm5GfNoXUg())
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter2 = MS8276KmY16LbMAoxKbK(I7J0cJKmM9oGjAFFIel6(countBlobsTool.InSight, fW7PWBKm0FdWgLvANF2p(countBlobsTool.Region), PxDN8wKmFCnaRDy3VFAB(countBlobsTool.Region)));
								if (!awaiter2.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto IL_010d;
							case 3:
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (countBlobsTool.PinOnFixtureChange)
								{
									num3 = 9;
									if (p1obhLKmTx6yfS5aYGXl())
									{
										continue;
									}
									return;
								}
								goto end_IL_0126;
							case 4:
								return;
							case 0:
								return;
							case 10:
								_003C_003Eu__2 = default;
								num3 = 15;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								p1obhLKmTx6yfS5aYGXl();
								if (dP4V0aKmynpm5GfNoXUg())
								{
									num3 = 3;
									if (p1obhLKmTx6yfS5aYGXl())
									{
										continue;
									}
									goto case 11;
								}
								num3 = 14;
								continue;
							case 7:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (p1obhLKmTx6yfS5aYGXl())
								{
									continue;
								}
								break;
							case 16:
								break;
								IL_010d:
								awaiter2.GetResult();
								goto case 13;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0126:
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
					goto default;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				num = 5;
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
		internal static CvsCellLocation fW7PWBKm0FdWgLvANF2p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PxDN8wKmFCnaRDy3VFAB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object I7J0cJKmM9oGjAFFIel6(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MS8276KmY16LbMAoxKbK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zPkYTOKmUWaZGLcLrEuD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DnZAL2KmHd04XRCpVMok(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p1obhLKmTx6yfS5aYGXl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dP4V0aKmynpm5GfNoXUg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private CheckBoxViewModel aGpCFTgdAU;

	[CompilerGenerated]
	private BlobsViewModel y9uCXERwCx;

	[CompilerGenerated]
	private EditIntViewModel GcWCoppVa6;

	[CompilerGenerated]
	private CheckBoxViewModel b2hCSpfuOC;

	[CompilerGenerated]
	private ListBoxViewModel iV2CDExoCw;

	[CompilerGenerated]
	private CheckBoxViewModel jJ5C3U95B3;

	[CompilerGenerated]
	private ListBoxViewModel tvSCIMDwg6;

	[CompilerGenerated]
	private EditFloatViewModel E20Cf8iS1U;

	[CompilerGenerated]
	private EditFloatViewModel HnhCEmkbqC;

	[CompilerGenerated]
	private IntViewModel In7CbttBnd;

	[CompilerGenerated]
	private CheckBoxViewModel cGMCcKxedv;

	[CompilerGenerated]
	private EditCompositeRegionViewModel AXACQHaChm;

	private bool xMJCguMypc;

	public CheckBoxViewModel AutoThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aGpCFTgdAU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aGpCFTgdAU = value;
		}
	}

	public BlobsViewModel Blobs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y9uCXERwCx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y9uCXERwCx = value;
		}
	}

	public EditIntViewModel Threshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GcWCoppVa6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GcWCoppVa6 = value;
		}
	}

	public CheckBoxViewModel FillHoles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b2hCSpfuOC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b2hCSpfuOC = value;
		}
	}

	public ListBoxViewModel BlobColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iV2CDExoCw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iV2CDExoCw = value;
		}
	}

	public CheckBoxViewModel Boundary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jJ5C3U95B3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jJ5C3U95B3 = value;
		}
	}

	public ListBoxViewModel BackgroundColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tvSCIMDwg6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tvSCIMDwg6 = value;
		}
	}

	public EditFloatViewModel MinArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E20Cf8iS1U;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E20Cf8iS1U = value;
		}
	}

	public EditFloatViewModel MaxArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HnhCEmkbqC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HnhCEmkbqC = value;
		}
	}

	public IntViewModel Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return In7CbttBnd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			In7CbttBnd = value;
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
			return cGMCcKxedv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cGMCcKxedv = value;
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
			return AXACQHaChm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AXACQHaChm = value;
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
			return (string)xnCevjRmvuKaQtIjwtR(Resources.B3PYr5moCv(), XNc2qxRxm8ExS3STjCe(Count));
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
			return Count;
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
			return XAMLGraphicKeys.Tools_CountBlobsIcon;
		}
	}

	public bool PinOnFixtureChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xMJCguMypc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref xMJCguMypc, value, (string)PUl8lNRXhaMeDcbq7tm(27084));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CountBlobsTool(InspectStepViewModel inspect, bool isInitialized)
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
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				cxj15WRq3S88e89GoYW();
				if (chMlWxR81Y9J5gNDL1p())
				{
					num = 0;
					if (chMlWxR81Y9J5gNDL1p())
					{
						continue;
					}
					goto case 0;
				}
				num = 3;
				continue;
			case 0:
			case 1:
				xMJCguMypc = true;
				break;
			case 5:
				return;
			}
			vcOXgGREbhnRAJJtasK(this, inspect, isInitialized);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 45:
				AddProperty(AutoThreshold);
				num = 25;
				break;
			case 20:
				AddProperty(MaxArea);
				return;
			case 42:
				AddProperty(FillHoles);
				return;
			case 23:
				if (num2 != 4249096401u)
				{
					num = 2;
					break;
				}
				if (!wpdKbyR9Cdxey3LC6mk(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19366)))
				{
					num = 22;
					break;
				}
				AutoThreshold = new CheckBoxViewModel(InSight, cells, loc, (string)em0QjYR3uUDju3lEUiX(), IsInitialized);
				num = 45;
				break;
			case 3:
				AddProperty(BlobColor);
				num = 44;
				break;
			case 34:
				AddProperty(Blobs);
				num = 18;
				break;
			case 15:
				num2 = HQcAfSRp7DqcQISqR2Y(relativeCellName);
				num = 7;
				break;
			case 21:
			case 39:
				AddProperty(BackgroundColor);
				num = 33;
				if (!cxj15WRq3S88e89GoYW())
				{
					break;
				}
				goto case 43;
			case 43:
				if (num2 != 297380477)
				{
					_ = 1;
					num = (cxj15WRq3S88e89GoYW() ? 21 : 46);
					break;
				}
				if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(27254)))
				{
					BlobColor = new ListBoxViewModel(InSight, cells, loc, (string)eNeJ1ZRCw3ZUKSsrW7E());
					num = 3;
					break;
				}
				num = 37;
				if (0 == 0)
				{
					break;
				}
				goto case 16;
			case 1:
				if (num2 != 607465875)
				{
					return;
				}
				if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(25122)))
				{
					FillHoles = new CheckBoxViewModel(InSight, cells, loc, (string)SBUVsRR6MeRr98wFfeW(), IsInitialized);
					num = 42;
					break;
				}
				num = 12;
				if (cxj15WRq3S88e89GoYW())
				{
				}
				break;
			case 5:
			case 46:
				if (num2 != 338031498)
				{
					num = 4;
					break;
				}
				if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(27330)))
				{
					num = 17;
					break;
				}
				MinArea = new EditFloatViewModel(InSight, cells, loc, (string)uH7lCVRWIZUA3SUfSpn());
				num = 6;
				if (chMlWxR81Y9J5gNDL1p())
				{
					break;
				}
				return;
			case 38:
				return;
			case 30:
				return;
			case 6:
				AddProperty(MinArea);
				num = 31;
				break;
			case 8:
				return;
			case 0:
				return;
			case 28:
				return;
			case 26:
				return;
			case 35:
				return;
			case 29:
				switch (num2)
				{
				default:
					num = 0;
					if (cxj15WRq3S88e89GoYW())
					{
					}
					break;
				case 2046460609u:
					if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(6122)))
					{
						Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
						AddProperty(Invert);
						return;
					}
					num = 8;
					break;
				case 1227782301u:
					if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(5684)))
					{
						Region = new EditCompositeRegionViewModel(InSight, cells, loc, (string)ypWsYURYYnFQP4lo68P(), v9e2thRU2PQBNpLedWi(InputImage), IsInitialized);
						AddProperty(Region);
						num = 49;
					}
					else
					{
						num = 14;
					}
					break;
				}
				break;
			case 41:
				AddProperty(Max);
				return;
			case 17:
				return;
			case 44:
				return;
			case 14:
				return;
			case 25:
				return;
			case 22:
				return;
			case 12:
				return;
			case 16:
				AddProperty(Threshold);
				return;
			case 9:
				return;
			case 4:
				return;
			case 47:
				return;
			case 11:
				if (num2 == 144703504)
				{
					if (!wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(27348)))
					{
						return;
					}
					MaxArea = new EditFloatViewModel(InSight, cells, loc, (string)YhaXGXRTYGKKT5T0233());
					num = 20;
				}
				else
				{
					num = 43;
				}
				break;
			case 10:
				if (num2 == 394884504)
				{
					if (relativeCellName == (string)PUl8lNRXhaMeDcbq7tm(24738))
					{
						Threshold = new EditIntViewModel(InSight, cells, loc, (string)skJsWgRjonso7W4Cynx());
						num = 16;
						if (false)
						{
							return;
						}
					}
					else
					{
						num = 19;
					}
				}
				else
				{
					num = 1;
				}
				break;
			case 31:
				return;
			case 19:
				return;
			case 13:
				if (num2 > 338031498)
				{
					if (num2 > 607465875)
					{
						if (num2 == 781469175)
						{
							if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(6148)))
							{
								Min = new EditIntViewModel(InSight, cells, loc, (string)K6aMp6RyOW5CQSCLFix());
								AddProperty(Min);
							}
							return;
						}
						num = 24;
					}
					else
					{
						num = 10;
						if (!chMlWxR81Y9J5gNDL1p())
						{
							return;
						}
					}
					break;
				}
				num = 11;
				if (!cxj15WRq3S88e89GoYW())
				{
					break;
				}
				goto case 27;
			case 27:
				if (num2 == 3007377802u)
				{
					if (!wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(19504)))
					{
						num = 40;
						if (1 == 0)
						{
							return;
						}
						break;
					}
					InputCompositeRegion = new InputCompositeRegionViewModel(this, cells, loc, (string)yKSpxFRFeDrrPK38cDO(), (string)D6r8vJRMXOuoTdbp6jk(), Region, IsInitialized);
					num = 48;
					if (!chMlWxR81Y9J5gNDL1p())
					{
						return;
					}
				}
				else
				{
					num = 38;
				}
				break;
			case 24:
				if (num2 == 1017635769)
				{
					if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(6138)))
					{
						Max = new EditIntViewModel(InSight, cells, loc, (string)oNoS2tR0eyfkyD5M8iO());
						num = 41;
					}
					else
					{
						num = 32;
					}
				}
				else
				{
					num = 28;
				}
				break;
			case 18:
				return;
			case 7:
				if (num2 > 1017635769)
				{
					if (num2 > 3007377802u)
					{
						if (num2 <= 3537120455u)
						{
							if (num2 != 3511250224u)
							{
								num = 36;
								break;
							}
							if (!wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(27276)))
							{
								return;
							}
							BackgroundColor = new ListBoxViewModel(InSight, cells, loc, (string)CAjLqqRA06aNWGK0wUV());
							goto case 21;
						}
						if (num2 != 3790059668u)
						{
							num = 23;
							break;
						}
						if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(26986)))
						{
							Count = new IntViewModel(InSight, cells, loc, (string)zpt7XTR7L84pM7SJIKE());
							AddProperty(Count);
							return;
						}
						num = 47;
						break;
					}
					if (num2 > 2046460609)
					{
						if (num2 != 2902779963u)
						{
							num = 27;
							break;
						}
						if (!wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(27240)))
						{
							return;
						}
						Blobs = new BlobsViewModel(InSight, cells, loc, (string)lAyAGxR417dHe0NlU1G());
						num = 34;
					}
					else
					{
						num = 29;
					}
					break;
				}
				num = 13;
				break;
			case 37:
				return;
			default:
				num = 30;
				break;
			case 48:
				AddProperty(InputCompositeRegion);
				num = 26;
				break;
			case 32:
				return;
			case 36:
				if (num2 == 3537120455u)
				{
					if (wpdKbyR9Cdxey3LC6mk(relativeCellName, PUl8lNRXhaMeDcbq7tm(27310)))
					{
						Boundary = new CheckBoxViewModel(InSight, cells, loc, (string)DaoY3FRRyVAPOHvl7JI(), IsInitialized);
						AddProperty(Boundary);
						return;
					}
					num = 35;
				}
				else
				{
					num = 9;
				}
				break;
			case 2:
				return;
			case 40:
				return;
			case 33:
				return;
			case 49:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__2))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (cxj15WRq3S88e89GoYW() ? 6 : 5);
		_003CShiftEditGraphics_003Ed__2 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (!cxj15WRq3S88e89GoYW())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = TxXbaXRHUwNBVowk3jn();
				goto case 1;
			case 3:
				stateMachine.delta = delta;
				goto case 4;
			default:
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!chMlWxR81Y9J5gNDL1p())
		{
			goto IL_001e;
		}
		goto IL_006e;
		IL_0099:
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		list.Add(cvsEditableDisplayGraphic);
		num = 6;
		goto IL_006e;
		IL_00aa:
		return list.ToArray();
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 5:
				goto IL_003a;
			case 2:
			case 4:
				goto IL_0056;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_0099;
			case 6:
				goto IL_00aa;
			}
			break;
			IL_003a:
			list = new List<CvsEditableDisplayGraphic>();
			_ = 0;
			num = ((!chMlWxR81Y9J5gNDL1p()) ? 4 : 0);
		}
		goto IL_001e;
		IL_001e:
		cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)Ajtra0RQuie4y0B01hf(Region);
		goto IL_0056;
		IL_0056:
		if (cvsEditableDisplayGraphic != null)
		{
			goto IL_0099;
		}
		goto IL_00aa;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__62))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnSetRange_003Ed__62 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = TxXbaXRHUwNBVowk3jn();
				cxj15WRq3S88e89GoYW();
				num = (chMlWxR81Y9J5gNDL1p() ? 2 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__63))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cxj15WRq3S88e89GoYW();
		int num = ((!chMlWxR81Y9J5gNDL1p()) ? 1 : 3);
		_003CWriteFixturedGraphics_003Ed__63 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				if (cxj15WRq3S88e89GoYW())
				{
				}
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vcOXgGREbhnRAJJtasK(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditIntViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool chMlWxR81Y9J5gNDL1p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cxj15WRq3S88e89GoYW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint HQcAfSRp7DqcQISqR2Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PUl8lNRXhaMeDcbq7tm(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wpdKbyR9Cdxey3LC6mk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lAyAGxR417dHe0NlU1G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Blobs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zpt7XTR7L84pM7SJIKE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object em0QjYR3uUDju3lEUiX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AutoThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object skJsWgRjonso7W4Cynx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Threshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SBUVsRR6MeRr98wFfeW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FillHoles;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eNeJ1ZRCw3ZUKSsrW7E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BlobColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CAjLqqRA06aNWGK0wUV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BackgroundColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DaoY3FRRyVAPOHvl7JI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Boundary;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uH7lCVRWIZUA3SUfSpn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MinArea;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YhaXGXRTYGKKT5T0233()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaxArea;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K6aMp6RyOW5CQSCLFix()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oNoS2tR0eyfkyD5M8iO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yKSpxFRFeDrrPK38cDO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputCompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D6r8vJRMXOuoTdbp6jk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tY8Y4bDug1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ypWsYURYYnFQP4lo68P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.l1fZTglVqg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation v9e2thRU2PQBNpLedWi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder TxXbaXRHUwNBVowk3jn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XNc2qxRxm8ExS3STjCe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IntViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xnCevjRmvuKaQtIjwtR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ajtra0RQuie4y0B01hf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}
}
