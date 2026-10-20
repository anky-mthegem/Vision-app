using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using BdfAmxxd7h5WZk7gxy;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CountEdges;

[Export(typeof(CountEdgesTool))]
public class CountEdgesTool : EzRangeTool<EditIntViewModel>, fOZu4ITbNGZ3gNxDns
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountEdgesTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (s3MRRuKxWdo5ker6gXYl() ? 4 : 3);
			int num2 = default;
			CountEdgesTool countEdgesTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					countEdgesTool = _003C_003E4__this;
					num = 5;
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = jyITwKKxTYxVqM7DCaIa(countEdgesTool.Region.Shift(delta));
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (1 == 0)
							{
								goto IL_00a1;
							}
						}
						goto IL_0130;
						IL_00a1:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							goto IL_0130;
						}
						goto IL_0177;
						IL_0177:
						awaiter.GetResult();
						goto end_IL_0061;
						IL_0130:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 4:
								return;
							case 7:
								break;
							case 5:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								if (waGhBqKxRageC1XVHi2h())
								{
									continue;
								}
								goto case 6;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								s3MRRuKxWdo5ker6gXYl();
								num3 = (waGhBqKxRageC1XVHi2h() ? 3 : 8);
								continue;
							case 9:
								goto IL_0177;
							}
							break;
						}
						goto IL_00a1;
						end_IL_0061:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
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
		internal static TaskAwaiter jyITwKKxTYxVqM7DCaIa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool waGhBqKxRageC1XVHi2h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s3MRRuKxWdo5ker6gXYl()
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
	private struct _003COnSetRange_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountEdgesTool _003C_003E4__this;

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
			if (!rk8L14Kx0CFEyiRmcZDP())
			{
				num = 3;
				if (rk8L14Kx0CFEyiRmcZDP())
				{
				}
			}
			else
			{
				num = 5;
				if (rk8L14Kx0CFEyiRmcZDP())
				{
				}
			}
			int num2 = default;
			int value = default;
			CountEdgesTool countEdgesTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<int> undoSetRange = default;
			int newMax = default;
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
							value = countEdgesTool.Count.Value;
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							case 0:
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								if (sAmovEKxyrN7rTFAbtLP())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (sAmovEKxyrN7rTFAbtLP())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 10:
								awaiter = dWlvKFKxUSBs5AnKQyCO(j4xa3gKxY2VQ8pbVbExC(countEdgesTool.InSight.UndoHandler, undoSetRange));
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								break;
							case 1:
								return;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 8:
								newMax = value;
								num3 = 6;
								continue;
							case 6:
								undoSetRange = new UndoSetRange<int>(countEdgesTool.Parent, (string)pKVA2qKxFJoEwuCqN8Nk(countEdgesTool), (string)UqioSGKxM09bTBmfAvau(countEdgesTool.Min), (string)UqioSGKxM09bTBmfAvau(countEdgesTool.Max), countEdgesTool.Min.Value, countEdgesTool.Max.Value, value, newMax);
								sAmovEKxyrN7rTFAbtLP();
								if (rk8L14Kx0CFEyiRmcZDP())
								{
									num3 = 0;
									continue;
								}
								num3 = 10;
								if (true)
								{
									continue;
								}
								break;
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
					goto case 2;
				default:
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 5:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				countEdgesTool = _003C_003E4__this;
				num = 4;
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
		internal static object pKVA2qKxFJoEwuCqN8Nk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UqioSGKxM09bTBmfAvau(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j4xa3gKxY2VQ8pbVbExC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter dWlvKFKxUSBs5AnKQyCO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sAmovEKxyrN7rTFAbtLP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rk8L14Kx0CFEyiRmcZDP()
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
	private struct _003CWriteFixturedGraphics_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountEdgesTool _003C_003E4__this;

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
			if (!jFJUxRKxxAG8w3Bg0KFG())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (!jrc9mlKxHjHaxT8k9j9E())
				{
					goto IL_02cf;
				}
			}
			goto IL_0276;
			IL_02cf:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_0276;
			IL_0276:
			int num2 = default;
			CountEdgesTool countEdgesTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					countEdgesTool = _003C_003E4__this;
					break;
				case 4:
					goto IL_02cf;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				TaskAwaiter<CvsCogSheetResult> awaiter = default;
				TaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 12;
						if (jFJUxRKxxAG8w3Bg0KFG())
						{
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 13;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 14;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						return;
					case 8:
						if (!awaiter2.IsCompleted)
						{
							num3 = 0;
							continue;
						}
						goto case 7;
					case 12:
						if (countEdgesTool.PinOnFixtureChange)
						{
							num3 = 1;
							if (jrc9mlKxHjHaxT8k9j9E())
							{
								continue;
							}
							goto case 13;
						}
						goto end_IL_00bb;
					case 13:
						_003C_003Eu__2 = default;
						num3 = 11;
						continue;
					case 5:
					case 6:
						num2 = (_003C_003E1__state = -1);
						goto case 7;
					default:
						num3 = 7;
						continue;
					case 7:
						awaiter2.GetResult();
						awaiter = countEdgesTool.InSight.CogSocket.Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
						num3 = 4;
						continue;
					case 10:
					case 15:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						continue;
					case 0:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 3:
						_003C_003Eu__2 = awaiter;
						goto case 10;
					case 1:
						awaiter2 = EditableGraphicHelper.SendGraphicAsync(countEdgesTool.InSight, E4VMxfKxm8FP9FI8Fvmw(countEdgesTool.Region), (CvsEditableDisplayGraphic)svQLnpKxQbFaGH5X3sWy(countEdgesTool.Region)).GetAwaiter();
						num3 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 14;
					case 14:
						_003C_003Eu__1 = default;
						jFJUxRKxxAG8w3Bg0KFG();
						num3 = (jrc9mlKxHjHaxT8k9j9E() ? 5 : 15);
						continue;
					case 4:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 3;
							continue;
						}
						break;
					case 9:
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 11:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 16:
						break;
					}
					awaiter.GetResult();
					break;
					continue;
					end_IL_00bb:
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
			goto IL_02cf;
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
		internal static CvsCellLocation E4VMxfKxm8FP9FI8Fvmw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object svQLnpKxQbFaGH5X3sWy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jrc9mlKxHjHaxT8k9j9E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jFJUxRKxxAG8w3Bg0KFG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EditIntViewModel X4ejySPaAJ;

	[CompilerGenerated]
	private EdgesViewModel hOEjxOV6y4;

	[CompilerGenerated]
	private CheckBoxViewModel kmbjviDuy8;

	[CompilerGenerated]
	private ListBoxViewModel FM8jeixJ7V;

	[CompilerGenerated]
	private EditIntViewModel lipj2FJngI;

	[CompilerGenerated]
	private EditIntViewModel q6VjqxLtp6;

	[CompilerGenerated]
	private IntViewModel j0ejiUtqEh;

	[CompilerGenerated]
	private CheckBoxViewModel d33jk4UrlG;

	[CompilerGenerated]
	private EditRegionViewModel dwmjPTOFpS;

	[CompilerGenerated]
	private CvsCellLocation pNajsyD0M1;

	private bool MMGjK1KslU;

	public EditIntViewModel EdgeContrast
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return X4ejySPaAJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			X4ejySPaAJ = value;
		}
	}

	public EdgesViewModel Edges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hOEjxOV6y4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hOEjxOV6y4 = value;
		}
	}

	public CheckBoxViewModel NormalizeScore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kmbjviDuy8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kmbjviDuy8 = value;
		}
	}

	public ListBoxViewModel EdgeTransition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FM8jeixJ7V;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FM8jeixJ7V = value;
		}
	}

	public EditIntViewModel EdgeWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lipj2FJngI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lipj2FJngI = value;
		}
	}

	public EditIntViewModel AngleRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q6VjqxLtp6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			q6VjqxLtp6 = value;
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
			return j0ejiUtqEh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			j0ejiUtqEh = value;
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
			return d33jk4UrlG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d33jk4UrlG = value;
		}
	}

	public EditRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dwmjPTOFpS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dwmjPTOFpS = value;
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
			return (string)C4ppAsRf3jdLo2id3mW(DkiDcmRntAyYgUqOR0Q(), VsTcKLRVgIuOYLD1sQa(Count));
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
			return XAMLGraphicKeys.Tools_CountEdgesIcon;
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
			return MMGjK1KslU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref MMGjK1KslU, value, (string)yYHpRJAtpeOJpUuHHBO(27084));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CountEdgesTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				MMGjK1KslU = true;
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				vm5oVPA1uWOA7yT0NLr(this, inspect, isInitialized);
				num = 6;
				break;
			case 3:
				N17H38AcOTZ9JpVFRPq();
				geFSTrAN9nR8XJfalDS();
				num = (X6i9imA2pAgAGfp4LHk() ? 4 : 5);
				break;
			case 1:
			case 5:
				pNajsyD0M1 = CvsCellLocation.Invalid;
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 24;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (num2 <= 1227782301)
				{
					if (num2 <= 781469175)
					{
						num = 14;
						if (!geFSTrAN9nR8XJfalDS())
						{
							return;
						}
						break;
					}
					switch (num2)
					{
					case 1195222419u:
						if (eBIustAhPNCds4SMQiI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7570)))
						{
							InputRegion = new InputRegionViewModel(this, cells, loc, Resources.InputRegion, (string)mB1WQ5ROAbvqWGt2tn9(), Region, IsInitialized);
							num = 13;
							break;
						}
						return;
					default:
						geFSTrAN9nR8XJfalDS();
						if (X6i9imA2pAgAGfp4LHk())
						{
							num = 16;
							if (X6i9imA2pAgAGfp4LHk())
							{
							}
						}
						else
						{
							num = 18;
							if (1 == 0)
							{
								return;
							}
						}
						break;
					case 1017635769u:
						if (eBIustAhPNCds4SMQiI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
						{
							Max = new EditIntViewModel(InSight, cells, loc, (string)nP72Z6RedpnsAlgnHQ5());
							num = 7;
							break;
						}
						return;
					}
				}
				else if (num2 > 2046460609)
				{
					if (num2 <= 3504813046u)
					{
						num = 41;
						if (1 == 0)
						{
							return;
						}
					}
					else if (num2 == 3655180391u)
					{
						if (eBIustAhPNCds4SMQiI(relativeCellName, yYHpRJAtpeOJpUuHHBO(27028)))
						{
							EdgeTransition = new ListBoxViewModel(InSight, cells, loc, (string)rBwxqoR54SbGYJ5Ak3s());
							AddProperty(EdgeTransition);
							return;
						}
						num = 19;
					}
					else
					{
						num = 12;
					}
				}
				else
				{
					num = 35;
				}
				break;
			case 23:
				return;
			case 38:
				return;
			case 40:
				return;
			case 24:
				num2 = LWHxmlAubxoFMDfJQn1(relativeCellName);
				num = 6;
				break;
			case 2:
				AddProperty(Edges);
				num = 40;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				AddProperty(Min);
				return;
			case 41:
				if (num2 != 3118149576u)
				{
					num = 21;
				}
				else if (eBIustAhPNCds4SMQiI(relativeCellName, yYHpRJAtpeOJpUuHHBO(25630)))
				{
					EdgeWidth = new EditIntViewModel(InSight, cells, loc, (string)P8TX8GRwu4jFptmvHsI());
					num = 22;
				}
				else
				{
					num = 27;
				}
				break;
			case 11:
				AddProperty(Count);
				num = 31;
				if (!X6i9imA2pAgAGfp4LHk())
				{
					break;
				}
				goto case 35;
			case 35:
				if (num2 != 1409224077)
				{
					switch (num2)
					{
					case 1756324894u:
						if (!eBIustAhPNCds4SMQiI(relativeCellName, yYHpRJAtpeOJpUuHHBO(27060)))
						{
							num = 5;
							goto end_IL_02de;
						}
						PfSjHfb3pF(loc);
						num = 32;
						goto end_IL_02de;
					default:
						num = 26;
						goto end_IL_02de;
					case 2046460609u:
						break;
					}
					if (!eBIustAhPNCds4SMQiI(relativeCellName, yYHpRJAtpeOJpUuHHBO(6122)))
					{
						num = 38;
						if (true)
						{
							break;
						}
						goto case 22;
					}
					Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
					num = 29;
					break;
				}
				if (!(relativeCellName == (string)yYHpRJAtpeOJpUuHHBO(25606)))
				{
					num = 1;
					break;
				}
				AngleRange = new EditIntViewModel(InSight, cells, loc, (string)lXUAebRJwBKpiNWZeFM());
				num = 3;
				break;
			case 30:
				return;
			case 31:
				return;
			case 36:
				return;
			case 14:
				if (num2 != 126945021)
				{
					switch (num2)
					{
					case 544534846u:
						if (relativeCellName == (string)yYHpRJAtpeOJpUuHHBO(27000))
						{
							EdgeContrast = new EditIntViewModel(InSight, cells, loc, Resources.EdgeContrast);
							num = 34;
							if (X6i9imA2pAgAGfp4LHk())
							{
								return;
							}
							break;
						}
						return;
					default:
						num = 10;
						if (1 == 0)
						{
							return;
						}
						break;
					case 781469175u:
						if (!(relativeCellName == (string)yYHpRJAtpeOJpUuHHBO(6148)))
						{
							num = 25;
							break;
						}
						Min = new EditIntViewModel(InSight, cells, loc, (string)wScvDRRaFQ1QE2SZxwq());
						num = 9;
						break;
					}
					break;
				}
				if (eBIustAhPNCds4SMQiI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(26972)))
				{
					Edges = new EdgesViewModel(InSight, cells, loc, (string)EFHuBrAzdlQ0FExEYWQ());
					goto case 2;
				}
				num = 17;
				if (true)
				{
					break;
				}
				goto case 3;
			case 32:
				return;
			case 5:
				return;
			default:
				num = 2;
				break;
			case 8:
				return;
			case 10:
				return;
			case 19:
				return;
			case 34:
				AddProperty(EdgeContrast);
				num = 8;
				break;
			case 26:
				return;
			case 25:
				return;
			case 22:
				AddProperty(EdgeWidth);
				num = 28;
				break;
			case 15:
				return;
			case 16:
			case 39:
				AddProperty(Region);
				num = 42;
				if (X6i9imA2pAgAGfp4LHk())
				{
					return;
				}
				break;
			case 33:
				return;
			case 27:
				return;
			case 0:
				return;
			case 28:
				return;
			case 17:
				return;
			case 29:
				AddProperty(Invert);
				return;
			case 13:
				AddProperty(InputRegion);
				num = 30;
				if (false)
				{
					return;
				}
				break;
			case 1:
				return;
			case 37:
				return;
			case 12:
				if (num2 == 3790059668u)
				{
					if (eBIustAhPNCds4SMQiI(relativeCellName, yYHpRJAtpeOJpUuHHBO(26986)))
					{
						Count = new IntViewModel(InSight, cells, loc, (string)Atrtk6RLsEoFt1ojtoM());
						num = 11;
					}
					else
					{
						num = 36;
					}
					break;
				}
				return;
			case 3:
				AddProperty(AngleRange);
				num = 37;
				if (X6i9imA2pAgAGfp4LHk())
				{
				}
				break;
			case 21:
				if (num2 == 3504813046u)
				{
					if (!(relativeCellName == (string)yYHpRJAtpeOJpUuHHBO(25574)))
					{
						num = 33;
						break;
					}
					NormalizeScore = new CheckBoxViewModel(InSight, cells, loc, (string)EbICcBRKXWeBDGSMK4a(), IsInitialized);
					AddProperty(NormalizeScore);
					num = 23;
				}
				else
				{
					num = 20;
					if (!geFSTrAN9nR8XJfalDS())
					{
						return;
					}
				}
				break;
			case 20:
				return;
			case 7:
				AddProperty(Max);
				num = 0;
				break;
			case 4:
			case 18:
				if (num2 == 1227782301)
				{
					if (eBIustAhPNCds4SMQiI(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684)))
					{
						Region = new EditRegionViewModel(InSight, cells, loc, (string)yhikSFRIwnZxWBWKEON(), aC48vfRDfotXKOITjoH(InputImage), showXArrow: true, showYArrow: false, IsInitialized);
						goto case 16;
					}
					return;
				}
				num = 15;
				if (false)
				{
					return;
				}
				break;
			case 42:
				return;
				end_IL_02de:
				break;
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
		int num;
		if (!X6i9imA2pAgAGfp4LHk())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (X6i9imA2pAgAGfp4LHk())
			{
			}
		}
		_003CShiftEditGraphics_003Ed__2 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 3:
				stateMachine.delta = delta;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = ajM9RtRigwvwWItfy6I();
				goto case 1;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (geFSTrAN9nR8XJfalDS())
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
	[SpecialName]
	[CompilerGenerated]
	private CvsCellLocation gYvjOH7Llu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return pNajsyD0M1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void PfSjHfb3pF(CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pNajsyD0M1 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				list.Add(cvsEditableDisplayGraphic);
				num = 6;
				continue;
			case 2:
			case 5:
				if (cvsEditableDisplayGraphic == null)
				{
					break;
				}
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)mSonKZRdYT672TAavFf(Region);
				goto case 2;
			case 4:
				do
				{
					list = new List<CvsEditableDisplayGraphic>();
					X6i9imA2pAgAGfp4LHk();
					if (!geFSTrAN9nR8XJfalDS())
					{
						num = 5;
						continue;
					}
					num = 3;
					break;
				}
				while (1 == 0);
				continue;
			case 6:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])KiYgtVRlEx3Qwq0pxLF(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__54))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		geFSTrAN9nR8XJfalDS();
		int num;
		if (!X6i9imA2pAgAGfp4LHk())
		{
			num = 3;
			if (!geFSTrAN9nR8XJfalDS())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0062;
		IL_0062:
		_003COnSetRange_003Ed__54 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 5:
				goto IL_0048;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = ajM9RtRigwvwWItfy6I();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_0048:
		stateMachine._003C_003E1__state = -1;
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (1 == 0)
		{
			goto IL_0048;
		}
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__55))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CWriteFixturedGraphics_003Ed__55 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				geFSTrAN9nR8XJfalDS();
				num = (X6i9imA2pAgAGfp4LHk() ? 5 : 0);
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldBeFiltered(CvsCogShape shape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0067;
		IL_0038:
		CvsCellLocation cvsCellLocation = default;
		if (!RBUN2GRsslUKe1pg4G6(cvsCellLocation.ToString(), Vt9cQQRgd0DBKHf14uD(shape)))
		{
			goto IL_00b7;
		}
		return true;
		IL_0067:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 2:
			case 5:
				goto IL_0038;
			default:
				num = 4;
				continue;
			case 0:
				goto IL_0092;
			case 4:
				goto IL_00b7;
			case 6:
				return cvsCellLocation.ToString().Equals((string)Vt9cQQRgd0DBKHf14uD(shape));
			}
			break;
			IL_0092:
			if (shape is CvsCogRegion)
			{
				geFSTrAN9nR8XJfalDS();
				if (X6i9imA2pAgAGfp4LHk())
				{
					num = 5;
					if (true)
					{
						continue;
					}
					goto IL_0038;
				}
				num = 3;
				continue;
			}
			return false;
		}
		goto IL_001a;
		IL_00b7:
		cvsCellLocation = gYvjOH7Llu();
		num = 6;
		goto IL_0067;
		IL_001a:
		cvsCellLocation = aC48vfRDfotXKOITjoH(Edges);
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void N17H38AcOTZ9JpVFRPq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vm5oVPA1uWOA7yT0NLr(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditIntViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool geFSTrAN9nR8XJfalDS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X6i9imA2pAgAGfp4LHk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint LWHxmlAubxoFMDfJQn1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eBIustAhPNCds4SMQiI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yYHpRJAtpeOJpUuHHBO(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EFHuBrAzdlQ0FExEYWQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Edges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Atrtk6RLsEoFt1ojtoM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EbICcBRKXWeBDGSMK4a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NormalizeScore;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rBwxqoR54SbGYJ5Ak3s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BlobColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P8TX8GRwu4jFptmvHsI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EdgeWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lXUAebRJwBKpiNWZeFM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AngleRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wScvDRRaFQ1QE2SZxwq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nP72Z6RedpnsAlgnHQ5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mB1WQ5ROAbvqWGt2tn9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rcKYeAISOR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yhikSFRIwnZxWBWKEON()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation aC48vfRDfotXKOITjoH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ajM9RtRigwvwWItfy6I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DkiDcmRntAyYgUqOR0Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.B3PYr5moCv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VsTcKLRVgIuOYLD1sQa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IntViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C4ppAsRf3jdLo2id3mW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mSonKZRdYT672TAavFf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KiYgtVRlEx3Qwq0pxLF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vt9cQQRgd0DBKHf14uD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RBUN2GRsslUKe1pg4G6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1);
	}
}
