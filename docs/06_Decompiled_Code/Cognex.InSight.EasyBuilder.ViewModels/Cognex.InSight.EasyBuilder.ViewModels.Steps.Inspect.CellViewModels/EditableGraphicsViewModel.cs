using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.Graphic;
using DUIE9v8SVGR17TWQwQ;
using V1vT6w9Pg8H2LQdsrR;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public abstract class EditableGraphicsViewModel : CellViewModel, gvP0xAP1E5gtN932no, edFbVBhD6RDc8FLg4U
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShift_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EditableGraphicsViewModel _003C_003E4__this;

		public float delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (sAgxEQKhNjE7KdTd3g9H() ? 1 : 4);
			EditableGraphicsViewModel editableGraphicsViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					editableGraphicsViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							if (vHUsfIKh2ewnSeXSSKwa())
							{
								goto IL_00e8;
							}
							goto IL_0101;
						}
						if (!editableGraphicsViewModel.Error)
						{
							sAgxEQKhNjE7KdTd3g9H();
							if (!vHUsfIKh2ewnSeXSSKwa())
							{
								num3 = 4;
								if (!sAgxEQKhNjE7KdTd3g9H())
								{
									goto IL_0066;
								}
							}
							else
							{
								num3 = 8;
							}
							goto IL_0101;
						}
						goto end_IL_0035;
						IL_0080:
						eA4aXZKhcdlS2rqmqMyx(editableGraphicsViewModel.Graphic, CvsEditFlags.Location, delta, delta);
						num3 = 6;
						if (1 == 0)
						{
							goto IL_00a4;
						}
						goto IL_0101;
						IL_0066:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						if (1 == 0)
						{
							goto IL_0080;
						}
						goto IL_0101;
						IL_00a4:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_0101;
						IL_00e8:
						_003C_003Eu__1 = awaiter;
						goto IL_0066;
						IL_0101:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 0:
							case 4:
								goto IL_0080;
							case 7:
							case 8:
								goto IL_00a4;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 5:
								return;
							case 1:
								goto IL_00e8;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter = kXoyN0Kh1s5BncCejCo6(editableGraphicsViewModel.Send(undo: false));
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 9:
								_003C_003Eu__1 = default;
								goto IL_00a4;
							case 10:
								awaiter.GetResult();
								goto end_IL_0035;
							}
							break;
						}
						goto IL_0066;
						end_IL_0035:;
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
				case 1:
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
		internal static void eA4aXZKhcdlS2rqmqMyx(object P_0, CvsEditFlags P_1, float P_2, float P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsEditableDisplayGraphic)P_0).Adjust(P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kXoyN0Kh1s5BncCejCo6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sAgxEQKhNjE7KdTd3g9H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vHUsfIKh2ewnSeXSSKwa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private CvsEditableDisplayGraphic B19wBV4LyN;

	public CvsEditableDisplayGraphic Graphic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return B19wBV4LyN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B19wBV4LyN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EditableGraphicsViewModel(CvsInSight insight, CvsCellLocation imageCellLocation, string displayName, bool isInitialized = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zNYLHqF9dcgDgDHsK7B();
		base._002Ector(insight, imageCellLocation, displayName, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShift_003Ed__5))]
	public Task Shift(float delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CShift_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.delta = delta;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (!nca0UcFX4eRkODNu67K())
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (!nca0UcFX4eRkODNu67K())
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				xwdpZvFpOvrNMsM7EQ2();
				if (nca0UcFX4eRkODNu67K())
				{
					num = 1;
					if (xwdpZvFpOvrNMsM7EQ2())
					{
						continue;
					}
					goto case 0;
				}
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				if (!nca0UcFX4eRkODNu67K())
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanResize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Graphic.CanEdit(CvsEditFlags.Size);
	}

	public abstract void RefreshGraphic(CvsCellCollection cells, bool pass, CvsCellLocation inputImageCell);

	public abstract Task Send(bool undo = true, CvsInSightDisplay display = null);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zNYLHqF9dcgDgDHsK7B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xwdpZvFpOvrNMsM7EQ2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nca0UcFX4eRkODNu67K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
