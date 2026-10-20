using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoLabelImages : IUndoAction
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ClassifyImage, string> _003C_003E9__5_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cXbpQgdrseEqDOTTReV();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cXbpQgdrseEqDOTTReV();
			SeGXOjdP7p1KbUfGhN7(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__5_0(ClassifyImage img)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)NUyPi7d4aYBZTGqJto5(img);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cXbpQgdrseEqDOTTReV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XdL6I0dk66yDEVnoNdy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AFZvMfdmU5OLBQ8fpig()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SeGXOjdP7p1KbUfGhN7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NUyPi7d4aYBZTGqJto5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLabelImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			UndoLabelImages undoLabelImages = default;
			int num2 = default;
			do
			{
				IL_019a:
				switch (num)
				{
				case 4:
					undoLabelImages = _003C_003E4__this;
					_ = 0;
					if (qui3FMdgsAB483BBRqt())
					{
						num = 0;
						if (0 == 0)
						{
							goto IL_019a;
						}
						goto case 1;
					}
					num = 5;
					goto IL_019a;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					goto IL_019a;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = MC5p5Ud6voYIiO1wt3H(NYftXwdS2E8BQrxib55(undoLabelImages));
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (qui3FMdgsAB483BBRqt())
								{
									num3 = 8;
									if (Ot9XD6d1rTD8lxpAKA0())
									{
									}
								}
								else
								{
									num3 = 5;
								}
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (Ot9XD6d1rTD8lxpAKA0())
								{
								}
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							default:
								return;
							case 5:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object NYftXwdS2E8BQrxib55(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MC5p5Ud6voYIiO1wt3H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qui3FMdgsAB483BBRqt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ot9XD6d1rTD8lxpAKA0()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLabelImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01c4;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c4;
			IL_01c4:
			int num2 = default;
			Classifier classifier = default;
			UndoLabelImages undoLabelImages = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = undoLabelImages.lKv2V35u6u.GetClassifier();
							num3 = 1;
							if (false)
							{
								goto IL_004d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00dd;
						IL_0075:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						if (nxL40dd88JPeuyCerKh())
						{
							goto IL_008d;
						}
						goto IL_00dd;
						IL_00dd:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 2:
								goto IL_0075;
							case 8:
								goto IL_008d;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								return;
							case 4:
							case 10:
								num2 = (_003C_003E1__state = 0);
								goto IL_0075;
							default:
								num3 = 2;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 0:
								awaiter = EpZbELdF49WeCL1F6M5(classifier.Q7XCNWHf0(imagesFromIds, undoLabelImages.Soe2hWR0o1));
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 6:
								return;
							case 1:
								if (classifier != null)
								{
									num3 = 8;
									continue;
								}
								goto end_IL_002f;
							case 11:
								goto IL_0182;
							}
							break;
						}
						goto IL_004d;
						IL_004d:
						if (!awaiter.IsCompleted)
						{
							CfO3n9dD2ALBMHPdAYo();
							if (!nxL40dd88JPeuyCerKh())
							{
								num3 = 10;
								if (1 == 0)
								{
									goto IL_0075;
								}
							}
							else
							{
								num3 = 6;
							}
							goto IL_00dd;
						}
						goto IL_0182;
						IL_008d:
						imagesFromIds = classifier.GetImagesFromIds(undoLabelImages.FWl2TMwOsa);
						num3 = 0;
						goto IL_00dd;
						IL_0182:
						awaiter.GetResult();
						end_IL_002f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!nxL40dd88JPeuyCerKh()) ? 5 : 0);
					continue;
				case 1:
				case 5:
					undoLabelImages = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static TaskAwaiter EpZbELdF49WeCL1F6M5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CfO3n9dD2ALBMHPdAYo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nxL40dd88JPeuyCerKh()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoLabelImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter = default;
			Classifier classifier = default;
			UndoLabelImages undoLabelImages = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			do
			{
				IL_0288:
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 13;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_ = 1;
								if (!irL7fIddVlaD0HQvDaq())
								{
									num3 = 10;
									if (irL7fIddVlaD0HQvDaq())
									{
										goto IL_00b0;
									}
								}
								else
								{
									num3 = 4;
								}
							}
							goto IL_01b2;
						}
						awaiter = _003C_003Eu__1;
						goto IL_014b;
						IL_01b2:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 6;
								if (rV70OtdsVfuLNyIl9S9())
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 12:
								break;
							case 2:
								return;
							case 6:
								goto end_IL_01b2;
							case 13:
								classifier = (Classifier)w8Ufn7dEGjotsnw1oG8(undoLabelImages.lKv2V35u6u);
								num3 = 5;
								continue;
							case 7:
								goto IL_00e6;
							case 11:
								imagesFromIds = classifier.GetImagesFromIds(undoLabelImages.FWl2TMwOsa);
								num3 = 7;
								continue;
							case 9:
								goto end_IL_0018;
							case 10:
							case 14:
								_003C_003Eu__1 = default;
								goto case 4;
							case 17:
								goto IL_014b;
							case 3:
								goto IL_0173;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 17;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 18;
							case 4:
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 5:
								if (classifier != null)
								{
									num3 = 11;
									continue;
								}
								goto end_IL_0018;
							case 18:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							awaiter = Ga7qUVd5c17R50ceBe8(classifier.Q7XCNWHf0(imagesFromIds, undoLabelImages.SgS2GuUJfw));
							if (!awaiter.IsCompleted)
							{
								num3 = 1;
								if (false)
								{
									return;
								}
								continue;
							}
							goto IL_0160;
							IL_00e6:
							if (undoLabelImages.Snb2NNhJs1)
							{
								num3 = 12;
								continue;
							}
							awaiter = classifier.Oait7AyuH(imagesFromIds).GetAwaiter();
							num3 = 0;
							continue;
							end_IL_01b2:
							break;
						}
						goto IL_00b0;
						IL_0173:
						_003C_003Eu__1 = awaiter;
						num3 = 16;
						goto IL_01b2;
						IL_0160:
						awaiter.GetResult();
						num3 = 9;
						if (false)
						{
							goto IL_0173;
						}
						goto IL_01b2;
						IL_014b:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0160;
						IL_00b0:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						goto IL_01b2;
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
				case 5:
					undoLabelImages = _003C_003E4__this;
					_ = 0;
					if (!rV70OtdsVfuLNyIl9S9())
					{
						num = 1;
						goto IL_0288;
					}
					num = 0;
					if (rV70OtdsVfuLNyIl9S9())
					{
						goto IL_0288;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_0288;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object w8Ufn7dEGjotsnw1oG8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Ga7qUVd5c17R50ceBe8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rV70OtdsVfuLNyIl9S9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool irL7fIddVlaD0HQvDaq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IClassifierHandle lKv2V35u6u;

	private bool Snb2NNhJs1;

	private string SgS2GuUJfw;

	private string Soe2hWR0o1;

	private string[] FWl2TMwOsa;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)wstcR2Mmfp58ywnmof0(Resources.LabelImagesArgs, Snb2NNhJs1 ? SgS2GuUJfw : Resources.Unlabeled, Soe2hWR0o1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoLabelImages(IClassifierHandle classifierHandle, List<ClassifyImage> images, string newClassLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector();
		ClassifyImage classifyImage = images[0];
		lKv2V35u6u = classifierHandle;
		Snb2NNhJs1 = classifyImage.IsLabeled;
		SgS2GuUJfw = classifyImage.Label;
		Soe2hWR0o1 = newClassLabel;
		FWl2TMwOsa = images.Select([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage img) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec.NUyPi7d4aYBZTGqJto5(img);
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eOthfZMkpmAVRVlXFEI();
		int num;
		if (pDIh5aMM3WlAfSTIAl6())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_009f;
			}
		}
		goto IL_005a;
		IL_005a:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = y0O0LCMreWu5G8vevX2();
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 5:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!pDIh5aMM3WlAfSTIAl6())
		{
			goto IL_001e;
		}
		goto IL_0094;
		IL_001e:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		eOthfZMkpmAVRVlXFEI();
		if (pDIh5aMM3WlAfSTIAl6())
		{
			num = 1;
			if (false)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0094;
		IL_0094:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				goto IL_0042;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto IL_0042;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_0042:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (eOthfZMkpmAVRVlXFEI())
		{
		}
		goto IL_0094;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)bDwD3rMPSiH6TyxPGTo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (pDIh5aMM3WlAfSTIAl6())
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (pDIh5aMM3WlAfSTIAl6() ? 3 : 5);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wstcR2Mmfp58ywnmof0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pDIh5aMM3WlAfSTIAl6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eOthfZMkpmAVRVlXFEI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder y0O0LCMreWu5G8vevX2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bDwD3rMPSiH6TyxPGTo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
