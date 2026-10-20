using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputPlaneViewModel : InputStructureViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public CvsInSight insight;

		public Func<CvsCellLocation, bool> _003C_003E9__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fhXuZHKzAhQAUNwQP3WM();
			xrKdKHKzRC3KJZT9knZe(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetInitialPlaneExpressionAsync_003Eb__1(CellRefRange cellRef)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Nke662KzFx6AWxZI457N(cellRef).All([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation loc) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((CvsResultSet)EYbGguKzM1wTGl57YTXx(insight)).Cells[loc] != null && !gi5fIRKzUFd4kgT91oig(YVZQA4KzYhKruZ09f3U0(((CvsResultSet)EYbGguKzM1wTGl57YTXx(insight)).Cells, loc));
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetInitialPlaneExpressionAsync_003Eb__2(CvsCellLocation loc)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (((CvsResultSet)EYbGguKzM1wTGl57YTXx(insight)).Cells[loc] != null)
			{
				return !gi5fIRKzUFd4kgT91oig(YVZQA4KzYhKruZ09f3U0(((CvsResultSet)EYbGguKzM1wTGl57YTXx(insight)).Cells, loc));
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fhXuZHKzAhQAUNwQP3WM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xrKdKHKzRC3KJZT9knZe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WNwERJKz6y83kxTGDVom()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U9JWaRKzCoRyKf5YnfKk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cKtggHKzWWYjDIEStcEs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object shWHabKzTlJja5CMrP9i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int KVIH8QKzy4lMxTSwV5Uf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D7Srl0Kz0T3Yidp3J0TY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CellReferences;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange Nke662KzFx6AWxZI457N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EYbGguKzM1wTGl57YTXx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YVZQA4KzYhKruZ09f3U0(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gi5fIRKzUFd4kgT91oig(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Error;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetInitialPlaneExpressionAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel inspect;

		public CvsCellLocation planeLocation;

		public string defaultPlane;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Gb43ulKzxEpElrraUI2f();
			int num = ((!QUOlZ9KzHENUkdwDjdAm()) ? 4 : 2);
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals6 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<object> awaiter2 = default;
			TaskAwaiter<bool> awaiter = default;
			SourceLink sourceLink = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass1_0();
							num3 = 24;
							break;
						case 1:
							awaiter3 = _003C_003Eu__2;
							num3 = 19;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 3;
							break;
						case 4:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 16;
							break;
						case 3:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 10;
							break;
						case 2:
							awaiter = _003C_003Eu__3;
							num3 = 2;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(planeLocation, (string)kkxQ2DKz2xvImrPsT1oO(sourceLink)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 30;
									continue;
								}
								goto case 12;
							case 25:
								_003C_003Eu__1 = awaiter2;
								num3 = 32;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 29;
								if (QUOlZ9KzHENUkdwDjdAm())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 31;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 13:
								return;
							case 7:
								num2 = (_003C_003E1__state = 3);
								num3 = 28;
								continue;
							case 32:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 23:
								if (!awaiter3.IsCompleted)
								{
									goto case 11;
								}
								goto case 0;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (QUOlZ9KzHENUkdwDjdAm())
								{
									continue;
								}
								goto case 30;
							case 30:
								num2 = (_003C_003E1__state = 0);
								num3 = 25;
								if (QUOlZ9KzHENUkdwDjdAm())
								{
									continue;
								}
								return;
							case 29:
								return;
							case 31:
								return;
							case 22:
								if (!awaiter2.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 17;
							case 12:
								awaiter2.GetResult();
								num3 = 27;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__3 = default;
								num3 = 20;
								continue;
							case 17:
								awaiter2.GetResult();
								num3 = 33;
								if (Gb43ulKzxEpElrraUI2f())
								{
								}
								continue;
							case 19:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 20:
								num2 = (_003C_003E1__state = -1);
								goto IL_024b;
							case 18:
								if (!awaiter3.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								break;
							case 24:
							{
								List<SourceLink> links = InputStructureViewModel.GetLinks(inspect, null, CellType.Plane3D);
								CS_0024_003C_003E8__locals6.insight = (CvsInSight)wY2uFMKzmLM8CKnbFLrc(inspect);
								_003Csheet_003E5__2 = (CvsCogSocketSheet)TOP42SKzNPrvFIoKXxiP(qtCebfKzQ3DjWGA1RyuV(CS_0024_003C_003E8__locals6.insight));
								sourceLink = links.FirstOrDefault(ValidateLinkExpression);
								QUOlZ9KzHENUkdwDjdAm();
								num3 = ((!Gb43ulKzxEpElrraUI2f()) ? 4 : 14);
								continue;
							}
							case 33:
								awaiter3 = _003Csheet_003E5__2.RunAsync().GetAwaiter();
								num3 = 18;
								continue;
							case 21:
								num2 = (_003C_003E1__state = 2);
								goto case 26;
							default:
								num3 = 26;
								if (Gb43ulKzxEpElrraUI2f())
								{
								}
								continue;
							case 15:
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__2 = awaiter3;
								num3 = 6;
								continue;
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 35;
								continue;
							case 34:
								awaiter = _003Csheet_003E5__2.GetCellPropertyAsync<bool>(planeLocation, (string)tpB4WhKzcPUu7AeKDaqJ(51222)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 21;
									continue;
								}
								goto IL_024b;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 11:
							case 14:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 13;
								if (QUOlZ9KzHENUkdwDjdAm())
								{
									continue;
								}
								goto case 26;
							case 26:
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								awaiter3.GetResult();
								num3 = 34;
								continue;
							case 27:
								awaiter3 = _003Csheet_003E5__2.RunAsync().GetAwaiter();
								num3 = 23;
								if (!Gb43ulKzxEpElrraUI2f())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								if (sourceLink != null)
								{
									num3 = 5;
									continue;
								}
								goto case 27;
							case 28:
								_003C_003Eu__1 = awaiter2;
								num3 = 9;
								continue;
							case 35:
								break;
								IL_024b:
								if (awaiter.GetResult())
								{
									awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(planeLocation, defaultPlane).GetAwaiter();
									num3 = 22;
									continue;
								}
								goto end_IL_032d;
							}
							awaiter3.GetResult();
							break;
							continue;
							end_IL_032d:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 1;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					_003Csheet_003E5__2 = null;
					goto default;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
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
		internal static object wY2uFMKzmLM8CKnbFLrc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qtCebfKzQ3DjWGA1RyuV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TOP42SKzNPrvFIoKXxiP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kkxQ2DKz2xvImrPsT1oO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tpB4WhKzcPUu7AeKDaqJ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QUOlZ9KzHENUkdwDjdAm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gb43ulKzxEpElrraUI2f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Plane3D;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputPlaneViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized, Plane3DViewModel referencePlane)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OAj5T5Ym0br1PxkjRXi();
		int num;
		if (zLysMwYxXK0aXNlZ2kl())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (false)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				RefreshLinks(updateMember: true);
				num = 7;
				continue;
			case 0:
			case 2:
				FwLjy7YQrDBvcbEcQ6m();
				num = 5;
				continue;
			case 5:
				base._002Ector(tool, loc, displayName, isInitialized);
				num = 1;
				continue;
			case 1:
				DefaultLink = new SourceLink((string)RMD9MZYNAbj7350hFwe(), usyqSWY2uscua4NmSvR(referencePlane).ToString(absoluteRow: true, absoluteColumn: true), CellType.Plane3D);
				break;
			case 7:
				return;
			}
			Refresh(cells);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetInitialPlaneExpressionAsync_003Ed__1))]
	internal static Task ibey8PGG1m(InspectStepViewModel P_0, string P_1, CvsCellLocation P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zLysMwYxXK0aXNlZ2kl();
		int num = (OAj5T5Ym0br1PxkjRXi() ? 7 : 3);
		_003CSetInitialPlaneExpressionAsync_003Ed__1 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.planeLocation = P_2;
				goto case 4;
			default:
				num = 4;
				if (!OAj5T5Ym0br1PxkjRXi())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 6:
				stateMachine.defaultPlane = P_1;
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 7:
				stateMachine.inspect = P_0;
				num = 6;
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
	public void MoveDefaultLink()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Links.Remove(DefaultLink);
		Links.Add(DefaultLink);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FwLjy7YQrDBvcbEcQ6m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RMD9MZYNAbj7350hFwe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ReferencePlane;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation usyqSWY2uscua4NmSvR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zLysMwYxXK0aXNlZ2kl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OAj5T5Ym0br1PxkjRXi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
