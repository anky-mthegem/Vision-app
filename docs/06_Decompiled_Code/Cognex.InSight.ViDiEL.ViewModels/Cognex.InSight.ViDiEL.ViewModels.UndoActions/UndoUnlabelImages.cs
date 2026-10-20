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

public class UndoUnlabelImages : IUndoAction
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ClassifyImage, string> _003C_003E9__3_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nZY0fdEDrCFBLfZ0WId();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nZY0fdEDrCFBLfZ0WId();
			pAgsagE86uQXU2LQmEc(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__3_0(ClassifyImage img)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)ARONifEFbkdQt8UKkeF(img);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nZY0fdEDrCFBLfZ0WId()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gGhP7CES6PFrsETOahk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ueh8MJE6YtHFELklcGW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pAgsagE86uQXU2LQmEc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ARONifEFbkdQt8UKkeF(object P_0)
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoUnlabelImages _003C_003E4__this;

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
			if (!ioQqfyEdQhUIuGtc4iJ())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (!g4KWiHEsoBkEqlEODYk())
				{
					return;
				}
			}
			int num2 = default;
			UndoUnlabelImages undoUnlabelImages = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = CiSHvuE5qrGXpOFLQf9(NGARXfEE3ZNK3rMNvrc(undoUnlabelImages));
							_ = 0;
							if (g4KWiHEsoBkEqlEODYk())
							{
								num3 = 7;
								if (false)
								{
									goto IL_004e;
								}
							}
							else
							{
								num3 = 1;
								if (!g4KWiHEsoBkEqlEODYk())
								{
									goto IL_0070;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00e3;
						IL_00e3:
						while (true)
						{
							switch (num3)
							{
							case 4:
								break;
							case 8:
								goto IL_0070;
							case 2:
								goto IL_0087;
							case 1:
							case 6:
								goto IL_009a;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 3:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
						}
						goto IL_004e;
						IL_009a:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00e3;
						IL_0087:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						goto IL_00e3;
						IL_0070:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						if (!g4KWiHEsoBkEqlEODYk())
						{
							goto IL_0087;
						}
						goto IL_00e3;
						IL_004e:
						_003C_003Eu__1 = default;
						goto IL_009a;
						end_IL_0024:;
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
				case 1:
				case 2:
					undoUnlabelImages = _003C_003E4__this;
					num = 3;
					if (ioQqfyEdQhUIuGtc4iJ())
					{
					}
					continue;
				case 4:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object NGARXfEE3ZNK3rMNvrc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter CiSHvuE5qrGXpOFLQf9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g4KWiHEsoBkEqlEODYk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ioQqfyEdQhUIuGtc4iJ()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoUnlabelImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hgC5LuE35NvjGhjlDTj();
			int num;
			if (!t7F15sEaaM3a1g1spyZ())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_01f2;
			IL_01f2:
			UndoUnlabelImages undoUnlabelImages = default;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					undoUnlabelImages = _003C_003E4__this;
					goto case 2;
				case 4:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)cZI2ZAEoRf8TmgqB8Oa(undoUnlabelImages.mua2WXNHZC);
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 0:
								return;
							case 2:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 8:
								if (classifier != null)
								{
									num3 = 5;
									continue;
								}
								goto end_IL_00d9;
							case 5:
								imagesFromIds = classifier.GetImagesFromIds(undoUnlabelImages.W5e2KY63oM);
								num3 = 7;
								continue;
							case 7:
								awaiter = klwyMwEcai33gnc9EUI(classifier.Oait7AyuH(imagesFromIds));
								hgC5LuE35NvjGhjlDTj();
								num3 = ((!t7F15sEaaM3a1g1spyZ()) ? 1 : 2);
								continue;
							case 1:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (!t7F15sEaaM3a1g1spyZ())
								{
									continue;
								}
								break;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00d9:
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
					num = 4;
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
			goto IL_01f2;
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
		internal static object cZI2ZAEoRf8TmgqB8Oa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter klwyMwEcai33gnc9EUI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hgC5LuE35NvjGhjlDTj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t7F15sEaaM3a1g1spyZ()
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
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoUnlabelImages _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!JJfmwcEuBugdJK4Up7k())
			{
				goto IL_001e;
			}
			goto IL_01ab;
			IL_0214:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_01ab;
			IL_01ab:
			UndoUnlabelImages undoUnlabelImages = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_01dc;
				default:
					goto IL_01fd;
				case 4:
					goto IL_0214;
				case 6:
					return;
				}
				break;
				IL_01dc:
				undoUnlabelImages = _003C_003E4__this;
				JJfmwcEuBugdJK4Up7k();
				num = (Y9lkOfEBIhf4gjOLqQe() ? 5 : 0);
			}
			goto IL_001e;
			IL_01fd:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (true)
			{
				goto IL_01ab;
			}
			goto IL_0214;
			IL_001e:
			try
			{
				Classifier classifier = default;
				int num3;
				if (num2 != 0)
				{
					classifier = (Classifier)QjE34fExN06uf0AhcrZ(undoUnlabelImages.mua2WXNHZC);
					JJfmwcEuBugdJK4Up7k();
					num3 = ((!Y9lkOfEBIhf4gjOLqQe()) ? 1 : 8);
					goto IL_012a;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_008e;
				IL_0169:
				awaiter.GetResult();
				goto end_IL_001e;
				IL_012a:
				IEnumerable<ClassifyImage> imagesFromIds = default;
				while (true)
				{
					switch (num3)
					{
					case 10:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						continue;
					case 3:
						imagesFromIds = classifier.GetImagesFromIds(undoUnlabelImages.W5e2KY63oM);
						num3 = 2;
						continue;
					case 5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (true)
						{
							continue;
						}
						break;
					case 7:
					case 8:
						break;
					case 2:
						goto IL_00a6;
					case 0:
					case 1:
						if (classifier != null)
						{
							num3 = 3;
							continue;
						}
						goto end_IL_001e;
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 4:
						return;
					case 9:
						_003C_003Eu__1 = awaiter;
						goto case 5;
					default:
						num3 = 5;
						continue;
					case 11:
						goto IL_0169;
					}
					break;
				}
				goto IL_008e;
				IL_008e:
				_003C_003Eu__1 = default;
				num3 = 10;
				if (false)
				{
					goto IL_00a6;
				}
				goto IL_012a;
				IL_00a6:
				awaiter = classifier.Q7XCNWHf0(imagesFromIds, undoUnlabelImages.zMV2SXLhVq).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num3 = 6;
					goto IL_012a;
				}
				goto IL_0169;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01fd;
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
		internal static object QjE34fExN06uf0AhcrZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JJfmwcEuBugdJK4Up7k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y9lkOfEBIhf4gjOLqQe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IClassifierHandle mua2WXNHZC;

	private string zMV2SXLhVq;

	private string[] W5e2KY63oM;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)hnTNj1MxKMjZrxcMA0f(), zMV2SXLhVq);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoUnlabelImages(IClassifierHandle classifierHandle, List<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector();
		mua2WXNHZC = classifierHandle;
		zMV2SXLhVq = images[0].Label;
		W5e2KY63oM = images.Select([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage img) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec.ARONifEFbkdQt8UKkeF(img);
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!noy5QPMBK4FDdiwQgO2())
		{
			num = 2;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0088;
		IL_0044:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__6 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 1;
		if (false)
		{
			goto IL_0058;
		}
		goto IL_0088;
		IL_0088:
		switch (num)
		{
		case 5:
			goto IL_0044;
		case 0:
		case 2:
			goto IL_0058;
		case 1:
			stateMachine._003C_003E1__state = -1;
			break;
		case 6:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_0026;
		IL_0026:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (!RkQhicMuNFdgVZnIyyS())
		{
			goto IL_0044;
		}
		goto IL_0088;
		IL_0058:
		stateMachine._003C_003Et__builder = amVWJrMh0ssInJ9N5HZ();
		num = 5;
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (noy5QPMBK4FDdiwQgO2() ? 5 : 3);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (RkQhicMuNFdgVZnIyyS())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)VZNZSpMU44q0W1Axyhb();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				do
				{
					stateMachine._003C_003Et__builder = amVWJrMh0ssInJ9N5HZ();
					RkQhicMuNFdgVZnIyyS();
					if (noy5QPMBK4FDdiwQgO2())
					{
						num = 4;
						continue;
					}
					num = 3;
					break;
				}
				while (noy5QPMBK4FDdiwQgO2());
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (!noy5QPMBK4FDdiwQgO2())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hnTNj1MxKMjZrxcMA0f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UnlabelImagesArg;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RkQhicMuNFdgVZnIyyS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool noy5QPMBK4FDdiwQgO2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder amVWJrMh0ssInJ9N5HZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VZNZSpMU44q0W1Axyhb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
