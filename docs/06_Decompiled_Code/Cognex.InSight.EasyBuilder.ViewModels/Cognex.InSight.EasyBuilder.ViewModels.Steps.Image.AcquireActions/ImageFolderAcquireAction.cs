using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.Filmstrip;
using Cognex.Filmstrip.Commands;
using Cognex.Filmstrip.Frame;
using Cognex.InSight.Filmstrip.ViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Sensor;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image.AcquireActions;

public class ImageFolderAcquireAction : IAcquireAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAcquire_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ImageFolderAcquireAction _003C_003E4__this;

		private int _003Cwidth_003E5__2;

		private int _003Cheight_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G20hOk5J5A3dObs2CBME();
			int num = (mw0EjR5JwYjqVWjwGvO6() ? 4 : 5);
			ImageFolderAcquireAction imageFolderAcquireAction = default;
			TaskAwaiter<bool> awaiter3 = default;
			int num2 = default;
			do
			{
				IL_0614:
				switch (num)
				{
				case 1:
					imageFolderAcquireAction = _003C_003E4__this;
					num = 2;
					goto IL_0614;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					goto IL_0614;
				case 2:
					try
					{
						TaskAwaiter<object> awaiter2;
						TaskAwaiter awaiter;
						switch (num2)
						{
						default:
							if (imageFolderAcquireAction.jQ3eW0wu83 == null)
							{
								FilmstripActionsViewModel xFue4BP2Ax = imageFolderAcquireAction.XFue4BP2Ax;
								int? num3;
								if (xFue4BP2Ax == null)
								{
									num3 = null;
								}
								else
								{
									Controller controller = xFue4BP2Ax.Controller;
									if (controller == null)
									{
										num3 = null;
									}
									else
									{
										object obj = tUSwEZ5JJscVSRSmKsE4(controller);
										if (obj == null)
										{
											num3 = null;
										}
										else
										{
											ReadOnlyObservableCollection<Model> frames = ((Cognex.Filmstrip.Filmstrip)obj).Frames;
											num3 = ((frames != null) ? new int?(Nnhfci5JauSRxL0d5OOv(frames)) : ((int?)null));
										}
									}
								}
								int? num4 = num3;
								if (num4.GetValueOrDefault() > 0)
								{
									break;
								}
								CvsInSight lwHeRkh03V = imageFolderAcquireAction.LwHeRkh03V;
								int? num5;
								if (lwHeRkh03V == null)
								{
									num5 = null;
								}
								else
								{
									object obj2 = Q5wk9V5JewPP5rwixE1Q(lwHeRkh03V);
									if (obj2 == null)
									{
										num5 = null;
									}
									else
									{
										object obj3 = a30nAR5JOD6q7SLRW2qS(obj2);
										num5 = ((obj3 != null) ? new int?(MMYvOa5JIFt3pKES8waa(obj3)) : ((int?)null));
									}
								}
								_003Cwidth_003E5__2 = num5 ?? 1280;
								CvsInSight lwHeRkh03V2 = imageFolderAcquireAction.LwHeRkh03V;
								int? num6;
								if (lwHeRkh03V2 == null)
								{
									num6 = null;
								}
								else
								{
									object obj4 = Q5wk9V5JewPP5rwixE1Q(lwHeRkh03V2);
									if (obj4 == null)
									{
										num6 = null;
									}
									else
									{
										object obj5 = a30nAR5JOD6q7SLRW2qS(obj4);
										num6 = ((obj5 != null) ? new int?(HcgB9D5JDD0fWQmaj4WX(obj5)) : ((int?)null));
									}
								}
								_003Cheight_003E5__3 = num6 ?? 1024;
								if (imageFolderAcquireAction.E1deTP1kaP != null)
								{
									awaiter3 = ((CvsCogSocket)StUiR55JimnGJlh1m8DH(imageFolderAcquireAction.LwHeRkh03V)).AcceptsPointCloudsAsync().GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_025c;
								}
							}
							goto end_IL_004a;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_025c;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_02e0;
						case 2:
							awaiter = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0362;
						case 3:
							break;
							IL_0362:
							awaiter.GetResult();
							goto end_IL_004a;
							IL_025c:
							if (awaiter3.GetResult())
							{
								awaiter2 = ((ResourceNode)x4aNZZ5Jn9KvyIdLUgCr(imageFolderAcquireAction.LwHeRkh03V.CogSocket)).PostAsync<object>(CdQUGaROfy7He9T0foW.KbIzwHEDLa(51498), Array.Empty<object>()).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_02e0;
							}
							awaiter = TGbBQj5JVAGTM6EYnker(imageFolderAcquireAction.E1deTP1kaP.LoadSingleColorImage(_003Cwidth_003E5__2, _003Cheight_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0362;
							IL_02e0:
							awaiter2.GetResult();
							goto end_IL_004a;
						}
						try
						{
							int num7;
							if (num2 != 3)
							{
								num7 = 6;
								if (false)
								{
									goto IL_0382;
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__1;
								num7 = 0;
							}
							goto IL_042f;
							IL_0571:
							if (!awaiter3.IsCompleted)
							{
								goto IL_047e;
							}
							goto IL_058f;
							IL_047e:
							num2 = (_003C_003E1__state = 3);
							num7 = 11;
							if (G20hOk5J5A3dObs2CBME())
							{
								goto IL_042f;
							}
							goto IL_0497;
							IL_0382:
							object obj6 = chBFOm5JdibZ9JCRtybH(imageFolderAcquireAction.XFue4BP2Ax);
							if (obj6 == null)
							{
								goto IL_03d3;
							}
							Ttvdv65JgHYNMvhbsOH2(obj6, null);
							num7 = 4;
							goto IL_042f;
							IL_058f:
							awaiter3.GetResult();
							goto end_IL_036f;
							IL_03d3:
							object obj7 = suZrgY5JsdVHRmlHKZbF(imageFolderAcquireAction.XFue4BP2Ax);
							if (obj7 == null)
							{
								num7 = 14;
							}
							else
							{
								Ttvdv65JgHYNMvhbsOH2(obj7, null);
								num7 = 7;
								if (!G20hOk5J5A3dObs2CBME())
								{
									goto IL_040b;
								}
							}
							goto IL_042f;
							IL_04af:
							imageFolderAcquireAction.jQ3eW0wu83 = new TaskCompletionSource<bool>();
							_ = 0;
							if (G20hOk5J5A3dObs2CBME())
							{
								num7 = 3;
							}
							else
							{
								num7 = 5;
								if (1 == 0)
								{
									goto IL_058f;
								}
							}
							goto IL_042f;
							IL_0497:
							_003C_003Eu__1 = awaiter3;
							num7 = 2;
							if (G20hOk5J5A3dObs2CBME())
							{
								goto IL_042f;
							}
							goto IL_04af;
							IL_042f:
							while (true)
							{
								switch (num7)
								{
								case 12:
									break;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num7 = 15;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									num7 = 13;
									continue;
								case 4:
									goto IL_03d3;
								case 7:
								case 14:
									goto IL_040b;
								default:
									num7 = 9;
									continue;
								case 5:
								case 8:
									goto IL_047e;
								case 11:
									goto IL_0497;
								case 6:
									goto IL_04af;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 10:
									imageFolderAcquireAction.TDJejZylMO = chBFOm5JdibZ9JCRtybH(imageFolderAcquireAction.XFue4BP2Ax) is ToggleLoopingCommand toggleLoopingCommand && !eShsZm5Jl1AENGdIR3D2(toggleLoopingCommand);
									if (imageFolderAcquireAction.TDJejZylMO)
									{
										num7 = 12;
										continue;
									}
									goto IL_03d3;
								case 1:
								case 3:
									imageFolderAcquireAction.necelGJSZn.FramePlayed += imageFolderAcquireAction.LHMeQvQrFY;
									GPyIyl5Jf2QRS4HtdnDL(imageFolderAcquireAction.necelGJSZn, new EventHandler(imageFolderAcquireAction.aRHegQR009));
									num7 = 10;
									continue;
								case 9:
									goto IL_0571;
								case 15:
									goto IL_058f;
								}
								break;
							}
							goto IL_0382;
							IL_040b:
							awaiter3 = imageFolderAcquireAction.jQ3eW0wu83.Task.GetAwaiter();
							goto IL_0571;
							end_IL_036f:;
						}
						finally
						{
							if (num2 < 0)
							{
								XkSSH65JvGDxmj8LTP98(imageFolderAcquireAction.necelGJSZn, new EventHandler(imageFolderAcquireAction.aRHegQR009));
								imageFolderAcquireAction.necelGJSZn.FramePlayed -= imageFolderAcquireAction.LHMeQvQrFY;
								imageFolderAcquireAction.jQ3eW0wu83 = null;
							}
						}
						end_IL_004a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (G20hOk5J5A3dObs2CBME());
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
		internal static object tUSwEZ5JJscVSRSmKsE4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Controller)P_0).Filmstrip;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Nnhfci5JauSRxL0d5OOv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ReadOnlyCollection<Model>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q5wk9V5JewPP5rwixE1Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Sensor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a30nAR5JOD6q7SLRW2qS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsSensor)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MMYvOa5JIFt3pKES8waa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).ImageWidth;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HcgB9D5JDD0fWQmaj4WX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).ImageHeight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object StUiR55JimnGJlh1m8DH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x4aNZZ5Jn9KvyIdLUgCr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).CameraResourceNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TGbBQj5JVAGTM6EYnker(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GPyIyl5Jf2QRS4HtdnDL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IReplayer)P_0).PlaybackError += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object chBFOm5JdibZ9JCRtybH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FilmstripActionsViewModel)P_0).ToggleLoopPlaybackCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eShsZm5Jl1AENGdIR3D2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ToggleLoopingCommand)P_0).Enabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ttvdv65JgHYNMvhbsOH2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object suZrgY5JsdVHRmlHKZbF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FilmstripActionsViewModel)P_0).PlayNextCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XkSSH65JvGDxmj8LTP98(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IReplayer)P_0).PlaybackError -= (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G20hOk5J5A3dObs2CBME()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mw0EjR5JwYjqVWjwGvO6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight LwHeRkh03V;

	private readonly FilmstripActionsViewModel XFue4BP2Ax;

	private readonly IReplayer necelGJSZn;

	private readonly ImageManagementViewModel E1deTP1kaP;

	private TaskCompletionSource<bool> jQ3eW0wu83;

	private bool TDJejZylMO;

	public bool IsPlayback
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageFolderAcquireAction(CvsInSight insight, FilmstripActionsViewModel imageFolderActions, ImageManagementViewModel imageManagement)
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
			case 5:
				XFue4BP2Ax = imageFolderActions;
				num = 4;
				break;
			case 3:
				JWMdOgmFI5nN8uX56Rp();
				_ = 1;
				if (!PFSKODm0W6OR5caCh8S())
				{
					num = 6;
					break;
				}
				num = 0;
				if (ViYVSxmyuuWHEe1fXWl())
				{
					break;
				}
				return;
			case 4:
			{
				FilmstripActionsViewModel xFue4BP2Ax = XFue4BP2Ax;
				object obj;
				if (xFue4BP2Ax == null)
				{
					obj = null;
				}
				else
				{
					object obj2 = sBCSBxmYJtNfgx7gAhE(xFue4BP2Ax);
					if (obj2 == null)
					{
						obj = null;
					}
					else
					{
						IFilmstripSubject subject = ((Controller)obj2).Subject;
						obj = ((subject != null) ? vmZXG6mUrnYFYexHIdd(subject) : null);
					}
				}
				necelGJSZn = (IReplayer)obj;
				E1deTP1kaP = imageManagement;
				num = 7;
				if (ViYVSxmyuuWHEe1fXWl())
				{
					break;
				}
				goto case 0;
			}
			case 0:
			case 2:
				LwHeRkh03V = insight;
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 6:
				t2P3pnmMRYLQEF40T4w(this);
				goto case 0;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcquire_003Ed__9))]
	public Task Acquire()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		_003CAcquire_003Ed__9 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_005f;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			default:
				num = 0;
				continue;
			case 0:
				goto IL_005f;
			case 3:
				goto IL_0077;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_0077:
			stateMachine._003C_003Et__builder = adHOLamHEJCmI2hOsuD();
			ViYVSxmyuuWHEe1fXWl();
			num = (PFSKODm0W6OR5caCh8S() ? 5 : 4);
		}
		goto IL_001a;
		IL_005f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LHMeQvQrFY(object P_0, Model P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		J2leMkS7Wk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aRHegQR009(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		J2leMkS7Wk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void J2leMkS7Wk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!ViYVSxmyuuWHEe1fXWl())
		{
			goto IL_001e;
		}
		goto IL_00bc;
		IL_00bc:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 5:
			case 6:
				goto IL_003a;
			case 2:
			case 4:
			case 8:
				goto IL_0053;
			case 3:
				goto IL_0070;
			case 1:
				LwHeRkh03V.MakeNewResult(updateExposedResults: true, runSheet: true);
				num = 3;
				if (true)
				{
					continue;
				}
				goto IL_0053;
			default:
				goto IL_00e9;
			case 7:
				return;
			case 9:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_003a:
		TaskCompletionSource<bool> taskCompletionSource = jQ3eW0wu83;
		if (taskCompletionSource == null)
		{
			num = 7;
			if (false)
			{
				goto IL_0053;
			}
		}
		else
		{
			taskCompletionSource.SetResult(result: true);
			num = 9;
		}
		goto IL_00bc;
		IL_0070:
		if (!TDJejZylMO)
		{
			goto IL_0053;
		}
		num = 0;
		goto IL_00bc;
		IL_001e:
		object obj = wq9ZTcmxcSNLjRVxyaY(XFue4BP2Ax);
		if (obj == null)
		{
			num = 2;
			goto IL_00bc;
		}
		VdN7xOmmChq3Mbl3Ppi(obj, null);
		goto IL_00e9;
		IL_0053:
		TDJejZylMO = false;
		goto IL_003a;
		IL_00e9:
		PFSKODm0W6OR5caCh8S();
		if (!ViYVSxmyuuWHEe1fXWl())
		{
			num = 6;
			if (PFSKODm0W6OR5caCh8S())
			{
				goto IL_0070;
			}
		}
		else
		{
			num = 8;
		}
		goto IL_00bc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JWMdOgmFI5nN8uX56Rp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t2P3pnmMRYLQEF40T4w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sBCSBxmYJtNfgx7gAhE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FilmstripActionsViewModel)P_0).Controller;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vmZXG6mUrnYFYexHIdd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IFilmstripSubject)P_0).Replayer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ViYVSxmyuuWHEe1fXWl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PFSKODm0W6OR5caCh8S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder adHOLamHEJCmI2hOsuD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wq9ZTcmxcSNLjRVxyaY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FilmstripActionsViewModel)P_0).ToggleLoopPlaybackCommand;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VdN7xOmmChq3Mbl3Ppi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICommand)P_0).SafeExecute(P_1);
	}
}
