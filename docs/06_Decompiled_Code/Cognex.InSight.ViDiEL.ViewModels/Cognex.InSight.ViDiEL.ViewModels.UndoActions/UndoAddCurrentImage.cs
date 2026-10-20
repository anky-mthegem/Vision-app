using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.UndoActions;

public class UndoAddCurrentImage : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoAddCurrentImage _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (W2tyTpsEKKY3YRcPTHB() ? 5 : 2);
			int num2 = default;
			TaskAwaiter<byte[]> awaiter = default;
			TaskAwaiter<string> awaiter2 = default;
			Classifier classifier = default;
			UndoAddCurrentImage undoAddCurrentImage = default;
			byte[] result = default;
			CvsCellLocation location = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
								if (1 == 0)
								{
									goto IL_0069;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 7;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 13;
							if (!nZePFysdS6X48LVUEUf())
							{
								goto IL_0230;
							}
						}
						goto IL_0188;
						IL_0082:
						awaiter2 = classifier._LabelCurrentImage(undoAddCurrentImage.ofkIbEbdCo).GetAwaiter();
						num3 = 3;
						goto IL_0188;
						IL_0069:
						result = awaiter.GetResult();
						num3 = 20;
						if (!nZePFysdS6X48LVUEUf())
						{
							goto IL_0082;
						}
						goto IL_0188;
						IL_0230:
						location = YoFNG9s3E59qVYIAwjw(undoAddCurrentImage.QmyIsxNblq);
						if (location.IsValid)
						{
							num3 = 18;
							goto IL_0188;
						}
						goto end_IL_0050;
						IL_0188:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 2:
							case 8:
								goto IL_0082;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								continue;
							case 16:
								_003C_003Eu__2 = awaiter;
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 17;
							case 17:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 10;
								continue;
							case 7:
								_003C_003Eu__2 = default;
								num3 = 19;
								continue;
							case 19:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 5:
								classifier = (Classifier)NoAVR1s52GHkGKHkAJW(undoAddCurrentImage.QmyIsxNblq);
								num3 = 0;
								if (!W2tyTpsEKKY3YRcPTHB())
								{
									continue;
								}
								goto default;
							default:
							{
								string result2 = awaiter2.GetResult();
								undoAddCurrentImage.Dv5IwgDVAT = result2;
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 3;
							}
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num3 = 1;
									if (W2tyTpsEKKY3YRcPTHB())
									{
									}
									continue;
								}
								goto default;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto default;
							case 0:
								goto IL_01f1;
							case 10:
								return;
							case 11:
								goto IL_0230;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 12;
								if (W2tyTpsEKKY3YRcPTHB())
								{
								}
								continue;
							case 18:
								awaiter = ((CvsCogSocketSheet)Kae3tUsa1tdUHT2Poti(undoAddCurrentImage.f6hIQaMetQ.CogSocket)).CopyCellsAsync(new CvsCellRange(location)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 16;
									if (true)
									{
										continue;
									}
									return;
								}
								break;
							case 15:
								return;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								continue;
							case 20:
								undoAddCurrentImage.VnQI4IENcV = result;
								goto end_IL_0050;
							}
							break;
							IL_01f1:
							if (classifier != null)
							{
								_ = 1;
								if (W2tyTpsEKKY3YRcPTHB())
								{
									num3 = 4;
									continue;
								}
								num3 = 8;
								if (!nZePFysdS6X48LVUEUf())
								{
									return;
								}
								continue;
							}
							goto end_IL_0050;
						}
						goto IL_0069;
						end_IL_0050:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				undoAddCurrentImage = _003C_003E4__this;
				num = 3;
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
		internal static object NoAVR1s52GHkGKHkAJW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation YoFNG9s3E59qVYIAwjw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetCellLocation();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Kae3tUsa1tdUHT2Poti(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nZePFysdS6X48LVUEUf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W2tyTpsEKKY3YRcPTHB()
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

		public UndoAddCurrentImage _003C_003E4__this;

		private Classifier _003Cclassifier_003E5__2;

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
			if (!uiUtNmscqY6bADT96Zj())
			{
				num = 6;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_02dc;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 7;
			goto IL_02dc;
			IL_02dc:
			UndoAddCurrentImage undoAddCurrentImage = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation location = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
					undoAddCurrentImage = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 9;
								if (false)
								{
									goto IL_022b;
								}
							}
							goto IL_016e;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_00ea;
						IL_016e:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							case 14:
								_003Cclassifier_003E5__2 = (Classifier)o7WVkhsu4HCdxet55Ta(undoAddCurrentImage.QmyIsxNblq);
								num3 = 1;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 6:
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 17;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 10:
								break;
							case 1:
								location = RRFV1asBsaBjgHeNKT1(undoAddCurrentImage.QmyIsxNblq);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								if (_003Cclassifier_003E5__2 != null)
								{
									num3 = 15;
									continue;
								}
								goto end_IL_0052;
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 7:
							case 12:
								return;
							default:
								num3 = 10;
								continue;
							case 5:
								goto IL_01c9;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 16;
									continue;
								}
								goto case 18;
							case 17:
								return;
							case 8:
								goto IL_022b;
							case 15:
								if (location.IsValid)
								{
									awaiter = oDjPGcsQqoQD4kRSalC(cikETksUVmQKN2Fc32i(PDYGv3shCBcA7BUVSRN(OVWBCfsxHrWbWvtbUhV(undoAddCurrentImage.f6hIQaMetQ)), new CvsCellRange(location), undoAddCurrentImage.VnQI4IENcV, false, true));
									if (awaiter.IsCompleted)
									{
										break;
									}
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 18;
								}
								goto end_IL_0052;
							case 18:
								awaiter.GetResult();
								goto end_IL_0052;
							}
							break;
							IL_01c9:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							e0ZvocsosV6f1r0W6OZ();
							num3 = ((!uiUtNmscqY6bADT96Zj()) ? 12 : 6);
						}
						goto IL_00ea;
						IL_022b:
						awaiter = oDjPGcsQqoQD4kRSalC(zqNHSUsq6Pf3OBv8XGv(_003Cclassifier_003E5__2));
						num3 = 11;
						goto IL_016e;
						IL_00ea:
						awaiter.GetResult();
						num3 = 8;
						goto IL_016e;
						end_IL_0052:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cclassifier_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 6:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003Cclassifier_003E5__2 = null;
					num = 3;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static object o7WVkhsu4HCdxet55Ta(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation RRFV1asBsaBjgHeNKT1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetCellLocation();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OVWBCfsxHrWbWvtbUhV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PDYGv3shCBcA7BUVSRN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cikETksUVmQKN2Fc32i(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oDjPGcsQqoQD4kRSalC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zqNHSUsq6Pf3OBv8XGv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).Refresh();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e0ZvocsosV6f1r0W6OZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uiUtNmscqY6bADT96Zj()
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

		public UndoAddCurrentImage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (JE9RlksVHdU6dPuZtGJ())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01f7;
			IL_0222:
			UndoAddCurrentImage undoAddCurrentImage = _003C_003E4__this;
			num = 3;
			if (!JE9RlksVHdU6dPuZtGJ())
			{
				return;
			}
			goto IL_01f7;
			IL_01f7:
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			IEnumerable<ClassifyImage> imagesFromIds = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier = (Classifier)WVllRRsLkcyo39F7Tq2(undoAddCurrentImage.QmyIsxNblq);
							num3 = 9;
							goto IL_012c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_016d;
						IL_016d:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_012c;
						IL_012c:
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 8:
								return;
							case 9:
								if (classifier != null)
								{
									imagesFromIds = classifier.GetImagesFromIds(new string[1] { undoAddCurrentImage.Dv5IwgDVAT });
									num3 = 10;
									if (RtXqlpsiQahk6CAyRgD())
									{
									}
									continue;
								}
								goto end_IL_012c;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (JE9RlksVHdU6dPuZtGJ())
									{
										continue;
									}
									goto case 2;
								}
								goto case 11;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								RtXqlpsiQahk6CAyRgD();
								num3 = ((!JE9RlksVHdU6dPuZtGJ()) ? 1 : 8);
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 1:
							case 7:
								break;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = OqtKkUs9w6N277xJHVF(classifier.FQt30A3AL(imagesFromIds, (string)rbmNsust88dXluX1ydC()));
								num3 = 0;
								continue;
							case 11:
								awaiter.GetResult();
								goto end_IL_012c;
							}
							goto IL_016d;
							continue;
							end_IL_012c:
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 1:
				case 2:
					goto IL_0222;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			goto IL_0222;
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
		internal static object WVllRRsLkcyo39F7Tq2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IClassifierHandle)P_0).GetClassifier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rbmNsust88dXluX1ydC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UndoAddImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OqtKkUs9w6N277xJHVF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JE9RlksVHdU6dPuZtGJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RtXqlpsiQahk6CAyRgD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsInSight f6hIQaMetQ;

	private IClassifierHandle QmyIsxNblq;

	private ClassViewModel ofkIbEbdCo;

	private string Dv5IwgDVAT;

	private byte[] VnQI4IENcV;

	string IUndoAction.Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)OhPZrJXw1AmtMa6Qrfe(), Ot87suXpVhmkNh6pNp7(ofkIbEbdCo));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoAddCurrentImage(CvsInSight insight, IClassifierHandle classifierHandle, ClassViewModel classViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				Do6BJ1XABuATwCVJaah();
				vh8l4XXKcPisAZhfYS6();
				num = (LDlVMaXCGfKF3PBO03f() ? 2 : 6);
				continue;
			case 4:
				ofkIbEbdCo = classViewModel;
				num = 7;
				continue;
			case 1:
			case 6:
				bkRTnFXN1OB8yuXvF60(this);
				num = 0;
				continue;
			case 0:
				f6hIQaMetQ = insight;
				break;
			case 7:
				return;
			}
			QmyIsxNblq = classifierHandle;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8))]
	Task IUndoAction.Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!LDlVMaXCGfKF3PBO03f()) ? 1 : 2);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = gBv4yuXGcBhp2mGUU8h();
				num = 5;
				if (vh8l4XXKcPisAZhfYS6())
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!LDlVMaXCGfKF3PBO03f())
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9))]
	Task IUndoAction.Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!vh8l4XXKcPisAZhfYS6())
		{
			goto IL_001e;
		}
		goto IL_005c;
		IL_009f:
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
			case 4:
				goto IL_0042;
			default:
				num = 0;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto IL_0042;
			case 0:
				goto IL_009f;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_0042:
		stateMachine._003C_003E1__state = -1;
		goto IL_009f;
		IL_001e:
		stateMachine._003C_003Et__builder = gBv4yuXGcBhp2mGUU8h();
		_ = 1;
		if (!LDlVMaXCGfKF3PBO03f())
		{
			num = 3;
			if (false)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task IUndoAction.SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11))]
	Task IUndoAction.Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!vh8l4XXKcPisAZhfYS6()) ? 3 : 4);
		_003CCognex_002DInSight_002DUndo_002DIUndoAction_002DUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = gBv4yuXGcBhp2mGUU8h();
				num = 5;
				if (LDlVMaXCGfKF3PBO03f())
				{
				}
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				if (LDlVMaXCGfKF3PBO03f())
				{
				}
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Do6BJ1XABuATwCVJaah()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bkRTnFXN1OB8yuXvF60(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vh8l4XXKcPisAZhfYS6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LDlVMaXCGfKF3PBO03f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OhPZrJXw1AmtMa6Qrfe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AddImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ot87suXpVhmkNh6pNp7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder gBv4yuXGcBhp2mGUU8h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
