using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization.ViDiEL;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Segment;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Utils;
using Cognex.Mvvm;
using Cognex.Segmenter.Client;
using Cognex.Segmenter.Client.Tool;
using Cognex.Segmenter.Client.Tool.Interfaces;
using Cognex.WebToolEditControl.Core;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Segment;

public abstract class SegmentAdapterBase : ViDiELAdapterBase, ISegmenterToolAdapter
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public SegmentAdapterBase _003C_003E4__this;

		public NewResultArgs args;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass20_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mAZ2tVEQCEMAfjnWfV9();
			UELN0eEqAFaDBPyNfQm(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003COnNewResult_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.b8w2DrO72x?.Invoke(_003C_003E4__this, args);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mAZ2tVEQCEMAfjnWfV9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UELN0eEqAFaDBPyNfQm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool elTsXrEhNvZI1Go4v0y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool je1UKaEU3aDLUwBSibV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass24_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y8rlaZELXgsM84N0Jcr();
			LBfE2SEtleic2AYoAad(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CAddClass_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ClassesUpdatedArgs> eventHandler = _003C_003E4__this.IGL2jU0Pn8;
			if (eventHandler != null)
			{
				SegmentAdapterBase sender = _003C_003E4__this;
				ClassesUpdatedArgs classesUpdatedArgs = new ClassesUpdatedArgs();
				wi5TIAE9lg6T6gZKWFD(classesUpdatedArgs, toolId);
				eventHandler(sender, classesUpdatedArgs);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void y8rlaZELXgsM84N0Jcr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LBfE2SEtleic2AYoAad(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uirjy0EVVFrrPsR3A9f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fE4sssEiEAa4KsZm2SQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wi5TIAE9lg6T6gZKWFD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassesUpdatedArgs)P_0).toolId = (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddClass_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public ISegmenterClass segmenterClass;

		private TaskAwaiter<int> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int result = default;
			int num2 = default;
			_003C_003Ec__DisplayClass24_0 obj = default;
			TaskAwaiter<int> awaiter = default;
			SegmentAdapterBase segmentAdapterBase = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass24_0();
							_ = 0;
							num3 = ((!ir9F4nEvQqXeaBLfqjn()) ? 6 : 2);
							goto IL_006b;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0125;
						IL_006b:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (ir9F4nEvQqXeaBLfqjn())
									{
										continue;
									}
									goto case 1;
								}
								goto case 12;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 0:
							case 2:
								obj._003C_003E4__this = _003C_003E4__this;
								num3 = 3;
								if (ir9F4nEvQqXeaBLfqjn())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 6:
							case 8:
								break;
							case 7:
							{
								segmentAdapterBase.ThrowIfToolIdInvalid(obj.toolId);
								object obj2 = Kq2xZOE0WJ4YEV79OXt(segmentAdapterBase, obj.toolId);
								ELSegmenterClass eLSegmenterClass = new ELSegmenterClass();
								gXyamAEOyWHvva8GtDM(eLSegmenterClass, segmenterClass.classID);
								eLSegmenterClass.Name = (string)xZ2WpZEHTVxaJyOsqbA(segmenterClass);
								eLSegmenterClass.Color = BJonRuEYTONMGpSkFCk(AZQnZGETqQc64GqB4Sk(segmenterClass));
								ELSegmenterClass eLSegmenterClass2 = eLSegmenterClass;
								if (segmentAdapterBase._mainThreadDispatcher != null && !HTNTvnEJ31qj8sCUJMP(segmentAdapterBase._mainThreadDispatcher))
								{
									segmentAdapterBase._mainThreadDispatcher.Invoke(obj._003CAddClass_003Eb__0);
								}
								else
								{
									EventHandler<ClassesUpdatedArgs> eventHandler = segmentAdapterBase.IGL2jU0Pn8;
									if (eventHandler != null)
									{
										SegmentAdapterBase sender = segmentAdapterBase;
										ClassesUpdatedArgs classesUpdatedArgs = new ClassesUpdatedArgs();
										DmfRXLEKxyCjoNDCxdb(classesUpdatedArgs, obj.toolId);
										eventHandler(sender, classesUpdatedArgs);
									}
								}
								awaiter = ((SegmentToolApi)obj2).AddClass(eLSegmenterClass2).GetAwaiter();
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								return;
							}
							case 10:
								return;
							case 3:
								obj.toolId = toolId;
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								result = awaiter.GetResult();
								goto end_IL_006b;
							}
							goto IL_0125;
							continue;
							end_IL_006b:
							break;
						}
						goto end_IL_002e;
						IL_0125:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_006b;
						end_IL_002e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 5:
					num2 = _003C_003E1__state;
					ir9F4nEvQqXeaBLfqjn();
					num = (IM9QrcEZIFVRym16kvU() ? 4 : 3);
					break;
				case 1:
				case 3:
					segmentAdapterBase = _003C_003E4__this;
					goto case 2;
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
		internal static object Kq2xZOE0WJ4YEV79OXt(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gXyamAEOyWHvva8GtDM(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELSegmenterClass)P_0).Id = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xZ2WpZEHTVxaJyOsqbA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISegmenterClass)P_0).className;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AZQnZGETqQc64GqB4Sk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISegmenterClass)P_0).classBackColor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int BJonRuEYTONMGpSkFCk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u0I2AoNZFC((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HTNTvnEJ31qj8sCUJMP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Dispatcher)P_0).CheckAccess();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DmfRXLEKxyCjoNDCxdb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassesUpdatedArgs)P_0).toolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ir9F4nEvQqXeaBLfqjn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IM9QrcEZIFVRym16kvU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ELSegmenterClass, SegmenterClass> _003C_003E9__25_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JXJKn5ENMLDPYmNWt3B();
			VnikygEwvgqHkQGVi2f(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SegmenterClass _003CGetClasses_003Eb__25_0(ELSegmenterClass @class)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SegmenterClass segmenterClass = new SegmenterClass
			{
				classID = SUUFNHEprCsBjNL9vEY(@class)
			};
			njYBaREjVq7SYYSpnlI(segmenterClass, oKMrdZERyI7uCCaFgfj(RaNmufEG54s2hQ2pv5o(@class)));
			zf8VXwEWchYVEhWdBFk(segmenterClass, jLC6IZEIpth6VAkvsZQ(@class));
			return segmenterClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gb6IcJECeNCaVf5X8RP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAkEriEAb6wVZVfOsSn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JXJKn5ENMLDPYmNWt3B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VnikygEwvgqHkQGVi2f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int SUUFNHEprCsBjNL9vEY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterClass)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int RaNmufEG54s2hQ2pv5o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterClass)P_0).Color;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oKMrdZERyI7uCCaFgfj(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gCO2yTokFy(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void njYBaREjVq7SYYSpnlI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterClass)P_0).classBackColor = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jLC6IZEIpth6VAkvsZQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterClass)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zf8VXwEWchYVEhWdBFk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterClass)P_0).className = (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetClasses_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<ISegmenterClass>> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELSegmenterClass[]> _003C_003Eu__1;

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
			goto IL_01dd;
			IL_021f:
			ICollection<ISegmenterClass> result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01dd;
			IL_01dd:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
				case 4:
					goto IL_0039;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					goto IL_021f;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0039:
			SegmentAdapterBase segmentAdapterBase = default;
			try
			{
				int num3;
				TaskAwaiter<ELSegmenterClass[]> awaiter = default;
				if (num2 != 0)
				{
					segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
					num3 = 0;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					case 9:
						_003C_003Eu__1 = awaiter;
						goto case 7;
					default:
						num3 = 7;
						continue;
					case 2:
						_003C_003Eu__1 = default;
						num3 = 4;
						continue;
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (dycmwmEbCwkCJdyjkpS())
						{
							continue;
						}
						goto case 0;
					case 0:
						awaiter = segmentAdapterBase.GetTool(toolId).GetClasses().GetAwaiter();
						dycmwmEbCwkCJdyjkpS();
						num3 = (EQxJDjEewtt5Qvx2bYs() ? 8 : 6);
						continue;
					case 5:
						return;
					case 8:
						return;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						if (0 == 0)
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
					case 6:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							if (!EQxJDjEewtt5Qvx2bYs())
							{
								continue;
							}
						}
						break;
					case 10:
						break;
					}
					break;
				}
				result = ((IEnumerable<ISegmenterClass>)awaiter.GetResult().Select([MethodImpl(MethodImplOptions.NoInlining)] (ELSegmenterClass @class) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					SegmenterClass segmenterClass = new SegmenterClass
					{
						classID = _003C_003Ec.SUUFNHEprCsBjNL9vEY(@class)
					};
					_003C_003Ec.njYBaREjVq7SYYSpnlI(segmenterClass, _003C_003Ec.oKMrdZERyI7uCCaFgfj(_003C_003Ec.RaNmufEG54s2hQ2pv5o(@class)));
					_003C_003Ec.zf8VXwEWchYVEhWdBFk(segmenterClass, _003C_003Ec.jLC6IZEIpth6VAkvsZQ(@class));
					return segmenterClass;
				})).ToArray();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_021f;
			IL_001a:
			segmentAdapterBase = _003C_003E4__this;
			_ = 1;
			if (!EQxJDjEewtt5Qvx2bYs())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0039;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_01dd;
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
		internal static bool dycmwmEbCwkCJdyjkpS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQxJDjEewtt5Qvx2bYs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass26_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EFZpRkEy9pex3hQZe0J();
			qHTbqUEn7vrBAbC1xWL(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CUpdateClasses_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ClassesUpdatedArgs> eventHandler = _003C_003E4__this.IGL2jU0Pn8;
			if (eventHandler != null)
			{
				SegmentAdapterBase sender = _003C_003E4__this;
				ClassesUpdatedArgs classesUpdatedArgs = new ClassesUpdatedArgs();
				OkeUYLEfdjqIxGFrJx7(classesUpdatedArgs, toolId);
				eventHandler(sender, classesUpdatedArgs);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EFZpRkEy9pex3hQZe0J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qHTbqUEn7vrBAbC1xWL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IQCigrElUatGETwZ0s0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BP4iNUE7dl40hv1Vuw2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OkeUYLEfdjqIxGFrJx7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassesUpdatedArgs)P_0).toolId = (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateClasses_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<ISegmenterClass> editedClasses;

		public ICollection<int> deletedClassIDs;

		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		private SegmentToolApi _003Ctool_003E5__2;

		private bool _003CshouldRetrain_003E5__3;

		private IEnumerator<ISegmenterClass> _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<int> _003C_003E7__wrap4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!hLpQ8JEzTFXqh71IHdA())
			{
				goto IL_001e;
			}
			goto IL_057f;
			IL_001e:
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			try
			{
				if ((uint)num2 > 2u)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass26_0();
					_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
					_003C_003E8__1.toolId = toolId;
					segmentAdapterBase.ThrowIfToolIdInvalid(_003C_003E8__1.toolId);
					_003Ctool_003E5__2 = (SegmentToolApi)rcrwpW5XErQhwP5SyZQ(segmentAdapterBase, _003C_003E8__1.toolId);
					_003CshouldRetrain_003E5__3 = false;
				}
				try
				{
					TaskAwaiter awaiter = default;
					switch (num2)
					{
					default:
						_003C_003E7__wrap3 = editedClasses.GetEnumerator();
						goto case 0;
					case 0:
						try
						{
							if (num2 != 0)
							{
								goto IL_021a;
							}
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							goto IL_015d;
							IL_01db:
							int num3;
							ELSegmenterClass eLSegmenterClass = default;
							ISegmenterClass current = default;
							while (true)
							{
								switch (num3)
								{
								case 3:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										if (!FkJwEN52wjieh9HMaji())
										{
											continue;
										}
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									num3 = 11;
									continue;
								case 4:
									eLSegmenterClass = new ELSegmenterClass
									{
										Id = current.classID,
										Name = current.className,
										Color = FBGKDW5kLj65n7YBIJi(URSLnv5M2Ugk2vDOKx3(current))
									};
									num3 = 2;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									continue;
								case 2:
									awaiter = ytmx455rK84hwDUi38M(hHn8cq5mIdQyhjZCfIp(_003Ctool_003E5__2, eLSegmenterClass));
									num3 = 3;
									continue;
								case 5:
								case 7:
									break;
								case 0:
								case 6:
									return;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									FkJwEN52wjieh9HMaji();
									num3 = ((!hLpQ8JEzTFXqh71IHdA()) ? 5 : 0);
									continue;
								case 1:
									_003C_003Eu__1 = awaiter;
									goto case 10;
								default:
									num3 = 10;
									continue;
								case 11:
									goto IL_021a;
								}
								break;
							}
							goto IL_015d;
							IL_021a:
							if (MYdcrt5PQwDg5yykHhv(_003C_003E7__wrap3))
							{
								current = _003C_003E7__wrap3.Current;
								num3 = 4;
								goto IL_01db;
							}
							goto end_IL_00a6;
							IL_015d:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							goto IL_01db;
							end_IL_00a6:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap3 != null)
							{
								DCydws54jcsofoMsnKl(_003C_003E7__wrap3);
							}
						}
						_003C_003E7__wrap3 = null;
						_003C_003E7__wrap4 = deletedClassIDs.GetEnumerator();
						goto case 1;
					case 1:
						try
						{
							int num4;
							if (num2 != 1)
							{
								num4 = 2;
								if (FkJwEN52wjieh9HMaji())
								{
									goto IL_027d;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num4 = 8;
							}
							goto IL_0361;
							IL_0361:
							int current2 = default;
							while (true)
							{
								switch (num4)
								{
								case 9:
									break;
								case 8:
									_003C_003Eu__1 = default;
									num4 = 11;
									continue;
								case 10:
									return;
								case 11:
									num2 = (_003C_003E1__state = -1);
									num4 = 6;
									continue;
								case 1:
								case 5:
									awaiter = ytmx455rK84hwDUi38M(mCwsFc5gWPQ6rMb9Hlv(_003Ctool_003E5__2, current2));
									num4 = 0;
									if (!FkJwEN52wjieh9HMaji())
									{
										continue;
									}
									goto case 3;
								case 3:
								case 4:
									num2 = (_003C_003E1__state = 1);
									num4 = 7;
									continue;
								case 7:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num4 = 10;
									continue;
								case 6:
									awaiter.GetResult();
									num4 = 9;
									continue;
								case 0:
									if (!awaiter.IsCompleted)
									{
										goto case 3;
									}
									goto case 6;
								case 2:
								case 12:
									goto IL_03d1;
								}
								break;
							}
							goto IL_027d;
							IL_03d1:
							if (MYdcrt5PQwDg5yykHhv(_003C_003E7__wrap4))
							{
								current2 = _003C_003E7__wrap4.Current;
								_ = 0;
								if (hLpQ8JEzTFXqh71IHdA())
								{
									num4 = 5;
									if (FkJwEN52wjieh9HMaji())
									{
									}
								}
								else
								{
									num4 = 4;
								}
								goto IL_0361;
							}
							goto end_IL_0266;
							IL_027d:
							_003CshouldRetrain_003E5__3 = true;
							num4 = 12;
							if (true)
							{
								goto IL_0361;
							}
							goto IL_03d1;
							end_IL_0266:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap4 != null)
							{
								DCydws54jcsofoMsnKl(_003C_003E7__wrap4);
							}
						}
						_003C_003E7__wrap4 = null;
						segmentAdapterBase.ClearCaches(_003C_003E8__1.toolId);
						if (_003CshouldRetrain_003E5__3)
						{
							awaiter = ytmx455rK84hwDUi38M(segmentAdapterBase.TrainAsync(_003C_003E8__1.toolId, EIq67A51LBVmLDJ1VvK(segmentAdapterBase.CancellationSource)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_0082;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						break;
					}
					awaiter.GetResult();
					end_IL_0082:;
				}
				finally
				{
					if (num2 < 0)
					{
						if (segmentAdapterBase._mainThreadDispatcher != null && !JWbaJc5SveDC3K2T2xQ(segmentAdapterBase._mainThreadDispatcher))
						{
							Qd87cd56gmkAmfhqBJ1(segmentAdapterBase._mainThreadDispatcher, (Action)([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								EventHandler<ClassesUpdatedArgs> eventHandler2 = _003C_003E8__1._003C_003E4__this.IGL2jU0Pn8;
								if (eventHandler2 != null)
								{
									SegmentAdapterBase sender2 = _003C_003E8__1._003C_003E4__this;
									ClassesUpdatedArgs classesUpdatedArgs2 = new ClassesUpdatedArgs();
									_003C_003Ec__DisplayClass26_0.OkeUYLEfdjqIxGFrJx7(classesUpdatedArgs2, _003C_003E8__1.toolId);
									eventHandler2(sender2, classesUpdatedArgs2);
								}
							}));
						}
						else
						{
							EventHandler<ClassesUpdatedArgs> eventHandler = segmentAdapterBase.IGL2jU0Pn8;
							if (eventHandler != null)
							{
								SegmentAdapterBase sender = segmentAdapterBase;
								ClassesUpdatedArgs classesUpdatedArgs = new ClassesUpdatedArgs();
								YE0ILK5DMLnRisOjR0s(classesUpdatedArgs, _003C_003E8__1.toolId);
								eventHandler(sender, classesUpdatedArgs);
							}
						}
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003Ctool_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			hLpQ8JEzTFXqh71IHdA();
			if (!FkJwEN52wjieh9HMaji())
			{
				num = 1;
			}
			else
			{
				num = 0;
				if (!hLpQ8JEzTFXqh71IHdA())
				{
					goto IL_05ea;
				}
			}
			goto IL_057f;
			IL_05ea:
			segmentAdapterBase = _003C_003E4__this;
			num = 7;
			goto IL_057f;
			IL_057f:
			while (true)
			{
				switch (num)
				{
				case 7:
					break;
				case 1:
				case 3:
					_003C_003E8__1 = null;
					goto case 2;
				default:
					num = 2;
					continue;
				case 0:
				case 5:
					_003C_003Et__builder.SetResult();
					num = 8;
					if (hLpQ8JEzTFXqh71IHdA())
					{
						continue;
					}
					goto case 2;
				case 2:
					_003Ctool_003E5__2 = null;
					goto case 0;
				case 6:
					goto IL_05ea;
				case 4:
					num2 = _003C_003E1__state;
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object rcrwpW5XErQhwP5SyZQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object URSLnv5M2Ugk2vDOKx3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISegmenterClass)P_0).classBackColor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int FBGKDW5kLj65n7YBIJi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u0I2AoNZFC((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hHn8cq5mIdQyhjZCfIp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentToolApi)P_0).EditClass((ELSegmenterClass)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ytmx455rK84hwDUi38M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MYdcrt5PQwDg5yykHhv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DCydws54jcsofoMsnKl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mCwsFc5gWPQ6rMb9Hlv(object P_0, int classId)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentToolApi)P_0).DeleteClass(classId);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken EIq67A51LBVmLDJ1VvK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWbaJc5SveDC3K2T2xQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Dispatcher)P_0).CheckAccess();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Qd87cd56gmkAmfhqBJ1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Dispatcher)P_0).Invoke((Action)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YE0ILK5DMLnRisOjR0s(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassesUpdatedArgs)P_0).toolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hLpQ8JEzTFXqh71IHdA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FkJwEN52wjieh9HMaji()
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
	private struct _003CGetStats_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ISegmenterStats> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<SegmenterStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dQ4nXd5FMTkPuBeMOc5();
			int num = ((!F5nBRS58vJgXfu5lpcM()) ? 5 : 2);
			int num2 = default;
			ISegmenterStats result = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<SegmenterStats> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 4;
							goto IL_0088;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0179;
						IL_0179:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0088;
						IL_0088:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								if (F5nBRS58vJgXfu5lpcM())
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 10;
							case 4:
								awaiter = segmentAdapterBase.afO2JNGusQ.GetResultAsync(toolId, DlMHRQ5sBPSYrduamDm(segmentAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								dQ4nXd5FMTkPuBeMOc5();
								if (F5nBRS58vJgXfu5lpcM())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 0:
							case 5:
								return;
							case 6:
							case 8:
								break;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0088;
							}
							goto IL_0179;
							continue;
							end_IL_0088:
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
				case 4:
					segmentAdapterBase = _003C_003E4__this;
					num = 1;
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
		internal static CancellationToken DlMHRQ5sBPSYrduamDm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F5nBRS58vJgXfu5lpcM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dQ4nXd5FMTkPuBeMOc5()
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
	private struct _003CGetSample_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ISegmenterSample> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public string sampleId;

		private ResourceNode _003CtoolNode_003E5__2;

		private SegmenterSample _003CfoundSample_003E5__3;

		private TaskAwaiter<Dictionary<string, SegmenterSample>> _003C_003Eu__1;

		private SegmenterSample _003C_003E7__wrap3;

		private SegmenterSample _003C_003E7__wrap4;

		private SegmenterSample _003C_003E7__wrap5;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter<MaskBitmap> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<Dictionary<string, SegmenterSample>> awaiter3 = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<MaskBitmap> awaiter = default;
			MaskBitmap result = default;
			ISegmenterSample result3 = default;
			SegmenterSample segmenterSample = default;
			Dictionary<string, SegmenterSample> value = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003CfoundSample_003E5__3 = null;
					goto case 0;
				case 1:
				case 3:
					_003CtoolNode_003E5__2 = null;
					goto case 2;
				default:
					num = 2;
					if (!IDeRDH5E7fB42lAvA0b())
					{
						break;
					}
					goto case 7;
				case 7:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							_ = 0;
							num3 = ((!yvT35m5dBsELW3c7Fky()) ? 25 : 34);
							goto IL_0163;
						case 0:
							awaiter3 = _003C_003Eu__1;
							num3 = 22;
							goto IL_0163;
						case 1:
							awaiter2 = _003C_003Eu__2;
							goto IL_0399;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 14;
								goto IL_0163;
							}
							IL_03ba:
							if (!awaiter.IsCompleted)
							{
								num3 = 20;
								goto IL_0163;
							}
							goto IL_03d9;
							IL_03d9:
							result = awaiter.GetResult();
							num3 = 28;
							goto IL_0163;
							IL_0163:
							while (true)
							{
								switch (num3)
								{
								case 32:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									continue;
								case 31:
									xYlxWk5ctNFvWS2uKi4(_003C_003E7__wrap5, _003CfoundSample_003E5__3.labelsUrl);
									num3 = 10;
									continue;
								case 30:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 35:
									break;
								case 4:
									return;
								case 27:
									_003C_003E7__wrap5.id = (string)daBIpp53bOdvrJIWE3W(_003CfoundSample_003E5__3);
									_003C_003E7__wrap5.imageUrl = _003CfoundSample_003E5__3.imageUrl;
									num3 = 7;
									continue;
								case 15:
									result3 = segmenterSample;
									num3 = 36;
									continue;
								case 18:
								{
									if (value.TryGetValue(sampleId, out var value2))
									{
										result3 = value2;
										num3 = 12;
										if (true)
										{
											continue;
										}
										goto case 14;
									}
									goto IL_0345;
								}
								case 14:
									_003C_003Eu__3 = default;
									num3 = 2;
									continue;
								case 1:
									if (!awaiter3.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									break;
								case 10:
									_003C_003E7__wrap4 = _003C_003E7__wrap5;
									awaiter = segmentAdapterBase.Fr82vsr6oh((string)nF5m7L5uDu61qrdSnw5(_003CfoundSample_003E5__3), _003CtoolNode_003E5__2).GetAwaiter();
									num3 = 29;
									continue;
								case 7:
									_003C_003E7__wrap3 = _003C_003E7__wrap5;
									num3 = 3;
									continue;
								case 16:
								{
									string result2 = awaiter2.GetResult();
									RmdQLg5o2Xxt7PM9crh(_003C_003E7__wrap3, result2);
									num3 = 31;
									if (yvT35m5dBsELW3c7Fky())
									{
										continue;
									}
									return;
								}
								case 9:
									return;
								case 23:
									segmenterSample = _003C_003E7__wrap5;
									num3 = 24;
									continue;
								case 12:
									goto end_IL_0163;
								case 26:
									num2 = (_003C_003E1__state = -1);
									num3 = 35;
									continue;
								default:
									goto IL_0399;
								case 29:
									goto IL_03ba;
								case 2:
									goto IL_03d0;
								case 6:
									_003C_003Eu__2 = awaiter2;
									num3 = 5;
									continue;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 4;
									continue;
								case 22:
									_003C_003Eu__1 = default;
									num3 = 26;
									continue;
								case 0:
								case 34:
									if (segmentAdapterBase.VLD2RRwdn1.TryGetValue(toolId, out value))
									{
										num3 = 18;
										continue;
									}
									goto IL_0345;
								case 19:
									_003C_003Eu__3 = awaiter;
									num3 = 32;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 21;
									continue;
								case 33:
									goto IL_0473;
								case 11:
									segmentAdapterBase.VLD2RRwdn1.Add(toolId, new Dictionary<string, SegmenterSample> { { sampleId, segmenterSample } });
									goto case 15;
								case 21:
									_003C_003Eu__1 = awaiter3;
									num3 = 30;
									continue;
								case 3:
									awaiter2 = segmentAdapterBase.JpO20jQtaX((string)M3knTN5aQ3kOXpxfyBh(_003CfoundSample_003E5__3), _003CtoolNode_003E5__2).GetAwaiter();
									num3 = 13;
									continue;
								case 24:
									_003C_003E7__wrap3 = null;
									num3 = 33;
									continue;
								case 20:
									num2 = (_003C_003E1__state = 2);
									num3 = 19;
									continue;
								case 13:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 6;
										continue;
									}
									goto case 16;
								case 28:
									_003C_003E7__wrap4.labelImage = result;
									num3 = 23;
									continue;
								case 36:
									goto end_IL_0163;
									IL_0345:
									_003CtoolNode_003E5__2 = segmentAdapterBase.GetToolNode(toolId);
									awaiter3 = segmentAdapterBase.nhx2c38Geb.GetResultAsync(toolId, dp38ui55j2abg0e0tJU(segmentAdapterBase.CancellationSource)).GetAwaiter();
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 26;
								}
								if (awaiter3.GetResult().TryGetValue(sampleId, out _003CfoundSample_003E5__3))
								{
									_003C_003E7__wrap5 = new SegmenterSample();
									num3 = 27;
									continue;
								}
								result3 = null;
								break;
								IL_0473:
								_003C_003E7__wrap4 = null;
								_003C_003E7__wrap5 = null;
								if (!segmentAdapterBase.VLD2RRwdn1.ContainsKey(toolId))
								{
									num3 = 11;
									continue;
								}
								segmentAdapterBase.VLD2RRwdn1[toolId][sampleId] = segmenterSample;
								num3 = 15;
								continue;
								end_IL_0163:
								break;
							}
							break;
							IL_03d0:
							num2 = (_003C_003E1__state = -1);
							goto IL_03d9;
							IL_0399:
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 16;
							if (true)
							{
								goto IL_0163;
							}
							goto IL_03ba;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtoolNode_003E5__2 = null;
						_003CfoundSample_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					IDeRDH5E7fB42lAvA0b();
					num = (yvT35m5dBsELW3c7Fky() ? 1 : 0);
					break;
				case 4:
					segmentAdapterBase = _003C_003E4__this;
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 5:
					_003C_003Et__builder.SetResult(result3);
					num = 8;
					break;
				case 6:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 8:
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
		internal static CancellationToken dp38ui55j2abg0e0tJU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object daBIpp53bOdvrJIWE3W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmenterSample)P_0).id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M3knTN5aQ3kOXpxfyBh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmenterSample)P_0).imageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RmdQLg5o2Xxt7PM9crh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).image = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xYlxWk5ctNFvWS2uKi4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).labelsUrl = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nF5m7L5uDu61qrdSnw5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmenterSample)P_0).labelsUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yvT35m5dBsELW3c7Fky()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IDeRDH5E7fB42lAvA0b()
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
	private struct _003CGetSamples_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<ISegmenterSample>> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public int imageSize;

		private TaskAwaiter<Dictionary<string, SegmenterSample>> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<Dictionary<string, SegmenterSample>> awaiter = default;
			ICollection<ISegmenterSample> result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 3;
							goto IL_004f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00c1;
						IL_00c1:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_004f;
						IL_004f:
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 10;
							case 2:
								_003C_003Eu__1 = awaiter;
								vdLXxb5xxcIKN3nFPNg();
								num3 = ((!yI4Dg35BkTT4AvpcVFy()) ? 8 : 0);
								continue;
							case 7:
							case 8:
								break;
							case 6:
								return;
							case 1:
								awaiter = segmentAdapterBase.nhx2c38Geb.GetResultAsync(toolId, rSVTx25hLdBYHkJqw0n(segmentAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 3:
								segmentAdapterBase.T5I28ABQUE = imageSize;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								result = ((IEnumerable<ISegmenterSample>)awaiter.GetResult().Values).ToList();
								goto end_IL_004f;
							}
							goto IL_00c1;
							continue;
							end_IL_004f:
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
				case 0:
					num2 = _003C_003E1__state;
					yI4Dg35BkTT4AvpcVFy();
					num = ((!vdLXxb5xxcIKN3nFPNg()) ? 4 : 2);
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				segmentAdapterBase = _003C_003E4__this;
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
		internal static CancellationToken rSVTx25hLdBYHkJqw0n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yI4Dg35BkTT4AvpcVFy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vdLXxb5xxcIKN3nFPNg()
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
	private struct _003CDeleteSamples_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<string> sampleIds;

		private CancellationToken _003Ctoken_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_02ac;
			IL_001a:
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 10;
						if (!fS2Oo85UhD3lylA9Z4j())
						{
							goto IL_0037;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 4;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					fS2Oo85UhD3lylA9Z4j();
					num3 = (lwiDdl5QS9tnUjyA7xO() ? 5 : 3);
				}
				goto IL_0115;
				IL_0037:
				segmentAdapterBase.ClearCaches(toolId);
				num3 = 8;
				goto IL_0115;
				IL_0115:
				while (true)
				{
					switch (num3)
					{
					case 0:
						break;
					case 14:
						return;
					case 8:
						_003Ctoken_003E5__2 = y6mLKs5qsxAjvnWUfeL(segmentAdapterBase.CancellationSource);
						awaiter = vJsIEi5VTkncXGfd4KQ(segmentAdapterBase.dJr29Da5Zn(toolId, sampleIds, _003Ctoken_003E5__2));
						num3 = 1;
						continue;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 12;
							continue;
						}
						goto case 18;
					case 13:
						return;
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 14;
						continue;
					case 16:
						awaiter.GetResult();
						goto case 17;
					default:
						num3 = 17;
						if (0 == 0)
						{
							continue;
						}
						goto case 10;
					case 10:
						segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
						num3 = 0;
						continue;
					case 4:
						_003C_003Eu__1 = default;
						goto case 5;
					case 11:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 13;
						if (lwiDdl5QS9tnUjyA7xO())
						{
						}
						continue;
					case 17:
						awaiter = vJsIEi5VTkncXGfd4KQ(segmentAdapterBase.TrainAsync(toolId, _003Ctoken_003E5__2));
						num3 = 7;
						continue;
					case 12:
						num2 = (_003C_003E1__state = 1);
						num3 = 2;
						continue;
					case 2:
						_003C_003Eu__1 = awaiter;
						num3 = 9;
						continue;
					case 1:
						if (awaiter.IsCompleted)
						{
							goto case 16;
						}
						num3 = 11;
						if (true)
						{
							continue;
						}
						goto case 3;
					case 3:
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 5:
					case 15:
						num2 = (_003C_003E1__state = -1);
						num3 = 18;
						if (!lwiDdl5QS9tnUjyA7xO())
						{
							continue;
						}
						goto case 18;
					case 18:
						awaiter.GetResult();
						goto end_IL_0115;
					}
					goto IL_0037;
					continue;
					end_IL_0115:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ctoken_003E5__2 = default;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0328;
			IL_02ac:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					segmentAdapterBase = _003C_003E4__this;
					_ = 1;
					if (lwiDdl5QS9tnUjyA7xO())
					{
						num = 6;
						continue;
					}
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (true)
					{
						continue;
					}
					goto IL_0328;
				default:
					goto IL_0328;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0328:
			_003Ctoken_003E5__2 = default;
			num = 1;
			goto IL_02ac;
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
		internal static CancellationToken y6mLKs5qsxAjvnWUfeL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vJsIEi5VTkncXGfd4KQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fS2Oo85UhD3lylA9Z4j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lwiDdl5QS9tnUjyA7xO()
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
	private struct _003CLabelImage_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public IMaskBitmap maskImage;

		public string sampleId;

		private SegmentToolApi _003Ctool_003E5__2;

		private Bitmap _003Cbmp_003E5__3;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter<ELSegmenterModelStats> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<bool> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (ctSes75LGpl48EAY5lm() ? 5 : 7);
			SegmentAdapterBase segmentAdapterBase = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<bool> awaiter;
						switch (num2)
						{
						default:
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							_003Ctool_003E5__2 = segmentAdapterBase.GetTool(toolId);
							if (maskImage == null)
							{
								throw new ArgumentException((string)vXiokH5tgULCl9VMuI9(6880));
							}
							segmentAdapterBase.ClearCaches(toolId);
							_003Cbmp_003E5__3 = MaskBitmap.ToBitmap(maskImage);
							wXhIW759qWiZa9F9AxK(segmentAdapterBase.CancellationSource).ThrowIfCancellationRequested();
							_003C_003E7__wrap4 = 0;
							goto case 0;
						case 0:
						case 1:
						case 2:
						case 3:
						{
							try
							{
								TaskAwaiter<ELSegmenterModelStats> awaiter4;
								TaskAwaiter<string> awaiter3;
								TaskAwaiter awaiter2;
								ELSegmenterModelStats result;
								switch (num2)
								{
								default:
									if (nmGI5F5vONrUyJmJT2Q(sampleId))
									{
										awaiter4 = _003Ctool_003E5__2.GetModelStats().GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											_003C_003Eu__1 = awaiter4;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											return;
										}
										goto IL_0138;
									}
									awaiter2 = UEO2B15OeROZvK7PJiq(_003Ctool_003E5__2.LabelImage(sampleId, _003Cbmp_003E5__3));
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_023a;
								case 0:
									awaiter4 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0138;
								case 1:
									awaiter3 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_01c2;
								case 2:
									awaiter2 = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_023a;
								case 3:
									{
										awaiter2 = _003C_003Eu__3;
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										break;
									}
									IL_023a:
									awaiter2.GetResult();
									goto IL_0241;
									IL_01c2:
									awaiter3.GetResult();
									goto IL_0241;
									IL_0138:
									result = awaiter4.GetResult();
									if ((double)LUee4q5ZMWcEWZyC9tx(result) >= ctbNBK50xPmoeJgePNU(result))
									{
										throw new InvalidOperationException(Resources.ViDiELSegmentMemoryLimitError);
									}
									awaiter3 = _003Ctool_003E5__2.LabelCurrentImage(_003Cbmp_003E5__3).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_01c2;
									IL_0241:
									awaiter2 = UEO2B15OeROZvK7PJiq(segmentAdapterBase.TrainAsync(toolId, wXhIW759qWiZa9F9AxK(segmentAdapterBase.CancellationSource)));
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__3 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									break;
								}
								awaiter2.GetResult();
							}
							catch (CvsHttpNetworkException ex)
							{
								_003C_003E7__wrap3 = ex;
								_003C_003E7__wrap4 = 1;
							}
							catch (Exception ex2)
							{
								_003C_003E7__wrap3 = ex2;
								_003C_003E7__wrap4 = 2;
							}
							int num3 = _003C_003E7__wrap4;
							if (num3 != 1)
							{
								if (num3 != 2)
								{
									break;
								}
								Exception ex3 = (Exception)_003C_003E7__wrap3;
								object broadcaster = eNOQD65HytJyOpxKOuU();
								ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel
								{
									Heading = (string)ES35Fy5T6hLReIa6Rdg()
								};
								zyu1Xx5JuWcZpaul5ff(errorMessageViewModel, WVR8E95KqZuNsk7wK9N(ex3));
								awaiter = ((IViewModelBroadcaster)broadcaster).Broadcast(null, errorMessageViewModel).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__4 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0411;
							}
							object broadcaster2 = eNOQD65HytJyOpxKOuU();
							ErrorMessageViewModel errorMessageViewModel2 = new ErrorMessageViewModel
							{
								Heading = (string)ES35Fy5T6hLReIa6Rdg()
							};
							zyu1Xx5JuWcZpaul5ff(errorMessageViewModel2, PT4khM5YU45aJNPsc5c());
							awaiter = ((IViewModelBroadcaster)broadcaster2).Broadcast(null, errorMessageViewModel2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_037b;
						}
						case 4:
							awaiter = _003C_003Eu__4;
							_003C_003Eu__4 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_037b;
						case 5:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0411;
							}
							IL_0411:
							awaiter.GetResult();
							break;
							IL_037b:
							awaiter.GetResult();
							break;
						}
						_003C_003E7__wrap3 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003Cbmp_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 6;
					continue;
				case 2:
					_003Cbmp_003E5__3 = null;
					num = 3;
					continue;
				case 6:
					_003Ctool_003E5__2 = null;
					goto case 2;
				default:
					num = 2;
					continue;
				case 0:
				case 7:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 8;
					continue;
				case 1:
				case 5:
					break;
				case 8:
					return;
				}
				segmentAdapterBase = _003C_003E4__this;
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
		internal static object vXiokH5tgULCl9VMuI9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken wXhIW759qWiZa9F9AxK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nmGI5F5vONrUyJmJT2Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int LUee4q5ZMWcEWZyC9tx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterModelStats)P_0).NumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double ctbNBK50xPmoeJgePNU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterModelStats)P_0).MaxNumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UEO2B15OeROZvK7PJiq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eNOQD65HytJyOpxKOuU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ES35Fy5T6hLReIa6Rdg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELSegmentLabelError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PT4khM5YU45aJNPsc5c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELSegmentLabelGenericMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zyu1Xx5JuWcZpaul5ff(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WVR8E95KqZuNsk7wK9N(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LWuDtw5iHaxGjuPJbIu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ctSes75LGpl48EAY5lm()
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
	private struct _003CGetCurrentResult_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ISegmenterResult> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<SegmenterResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01d7;
			IL_001a:
			SegmentAdapterBase segmentAdapterBase = _003C_003E4__this;
			_ = 1;
			num = (myQflJ5ATFopPVHyEN7() ? 4 : 5);
			goto IL_01d7;
			IL_01d7:
			int num2 = default;
			ISegmenterResult result = default;
			TaskAwaiter<SegmenterResult> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!NCD6VT5CLjjYtvs2afk())
							{
								goto IL_0194;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter = segmentAdapterBase.TqO2F98msx.GetResultAsync(toolId, Nc0Prp5NDNGHLuutpK8(segmentAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 5;
								continue;
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 0:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = (myQflJ5ATFopPVHyEN7() ? 1 : 0);
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 2:
								return;
							case 10:
								break;
							}
							break;
						}
						goto IL_0194;
						IL_0194:
						result = awaiter.GetResult();
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
		internal static CancellationToken Nc0Prp5NDNGHLuutpK8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NCD6VT5CLjjYtvs2afk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool myQflJ5ATFopPVHyEN7()
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
	private struct _003CGetProjectionParams_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Vyb1I35pORgtT1JJQfk() ? 5 : 2);
			int num2 = default;
			ELTunableProjectionParams result = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter = default;
			do
			{
				IL_01d4:
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					goto IL_01d4;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 5;
							goto IL_010d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00de;
						IL_00de:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_010d;
						IL_010d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 8:
								return;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 10;
							case 5:
								awaiter = segmentAdapterBase.GsI2EH0moM.GetResultAsync(toolId, jEBfd55GeyOgvDe42et(segmentAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 3;
								continue;
							case 6:
							case 7:
								break;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								if (Vyb1I35pORgtT1JJQfk())
								{
									num3 = 7;
									continue;
								}
								num3 = 2;
								if (Vyb1I35pORgtT1JJQfk())
								{
								}
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!Vyb1I35pORgtT1JJQfk())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_010d;
							}
							goto IL_00de;
							continue;
							end_IL_010d:
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
					goto case 3;
				default:
					num = 3;
					if (0 == 0)
					{
						goto IL_01d4;
					}
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				segmentAdapterBase = _003C_003E4__this;
				num = 4;
			}
			while (GYdn9D5wPsD1fd0dIw5());
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
		internal static CancellationToken jEBfd55GeyOgvDe42et(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GYdn9D5wPsD1fd0dIw5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vyb1I35pORgtT1JJQfk()
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
	private struct _003CGetAutoTuneProjectionParameters_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ELTunableProjectionParams result = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					psVP3o5jxfEvtDkdNq5();
					if (aKxVll5R8H8lgNUNb1p())
					{
						num = 3;
						if (psVP3o5jxfEvtDkdNq5())
						{
						}
					}
					else
					{
						num = 0;
						if (false)
						{
							return;
						}
					}
					break;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (psVP3o5jxfEvtDkdNq5())
								{
								}
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								psVP3o5jxfEvtDkdNq5();
								if (aKxVll5R8H8lgNUNb1p())
								{
									num3 = 1;
									continue;
								}
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 1:
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 5:
								awaiter = ((SegmentToolApi)f7ERjs5IZjHRX8vvbyV(segmentAdapterBase, toolId)).GetAutoTuneProjectionParameters().GetAwaiter();
								num3 = 9;
								continue;
							case 4:
								return;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
						break;
					}
					goto case 1;
				case 1:
				case 3:
					segmentAdapterBase = _003C_003E4__this;
					goto case 0;
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
		internal static object f7ERjs5IZjHRX8vvbyV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aKxVll5R8H8lgNUNb1p()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool psVP3o5jxfEvtDkdNq5()
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
	private struct _003CSetProjectionParams_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public ELTunableProjectionParams projectionParams;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (Hq17B35WnVnxCidOm7V())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!Hq17B35WnVnxCidOm7V())
				{
					return;
				}
			}
			int num2 = default;
			ELTunableProjectionParams result = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					segmentAdapterBase = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 0:
								awaiter = ((SegmentToolApi)rpF1cQ5ec5tuFbRY9v9(segmentAdapterBase, toolId)).SetTunableProjectionParameters(projectionParams).GetAwaiter();
								_ = 1;
								num3 = (ajrnGA5bSCImFLCVNPk() ? 8 : 5);
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 9;
								if (true)
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
		internal static object rpF1cQ5ec5tuFbRY9v9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hq17B35WnVnxCidOm7V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ajrnGA5bSCImFLCVNPk()
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
	private struct _003CGetProjectionParamsFromCameraAsync_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELTunableProjectionParams> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<ELTunableProjectionParams> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!UQuVXj57g7MYcSZOsUH())
			{
				num = 5;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					return;
				}
			}
			int num2 = default;
			ELTunableProjectionParams result = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<ELTunableProjectionParams> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					segmentAdapterBase = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							YZl1W65lkWrUXTJqDOr();
							if (!UQuVXj57g7MYcSZOsUH())
							{
								num3 = 3;
							}
							else
							{
								num3 = 6;
								if (1 == 0)
								{
									goto IL_00cf;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_00e8;
						IL_00e8:
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 8:
								_003C_003Eu__1 = default;
								goto case 6;
							case 4:
								break;
							default:
								num3 = 1;
								continue;
							case 0:
							case 3:
							{
								object obj = HCdjQT5yeu7OvF537iL(segmentAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((SegmentToolApi)obj).GetTunableProjectionParameters().GetAwaiter();
								num3 = 9;
								continue;
							}
							case 1:
								goto IL_014f;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 5:
								return;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_005c;
							}
							break;
						}
						goto IL_00cf;
						IL_00cf:
						_003C_003Eu__1 = awaiter;
						goto IL_014f;
						IL_014f:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						goto IL_00e8;
						end_IL_005c:;
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
		internal static object HCdjQT5yeu7OvF537iL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YZl1W65lkWrUXTJqDOr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UQuVXj57g7MYcSZOsUH()
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
	private struct _003CGetImage_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Size requestedSize;

		public string endpointUrl;

		public ResourceNode toolNode;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ydj4MO5fUuxjSVXU6G6();
			int num = ((!lsCyqr5n5tO70X4HNkg()) ? 4 : 2);
			int num2 = default;
			string result2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					try
					{
						TaskAwaiter<Stream> awaiter;
						if (num2 != 0)
						{
							if (requestedSize != default(Size))
							{
								string text = (string)WjxMXH3213mLf3Z8DQI(mvLvUP5z4jYWUaXRHWa(6954), requestedSize.Width, requestedSize.Height);
								endpointUrl = (string)kFJLLC3X0gSgxxCf099(endpointUrl, text);
							}
							awaiter = toolNode.GetHttpAsync(endpointUrl, new TimeSpan(0, 1, 0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						Stream result = awaiter.GetResult();
						MemoryStream memoryStream = new MemoryStream();
						try
						{
							FnduO63MZEVXG1RnW2H(result, memoryStream);
							result2 = (string)IOJhm53mvuqheYGCsll(GExxVx3k0sLwENupEo2(memoryStream));
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)memoryStream)?.Dispose();
							}
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
					num = 3;
					continue;
				case 3:
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
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
		internal static object mvLvUP5z4jYWUaXRHWa(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WjxMXH3213mLf3Z8DQI(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kFJLLC3X0gSgxxCf099(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FnduO63MZEVXG1RnW2H(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).CopyTo((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GExxVx3k0sLwENupEo2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IOJhm53mvuqheYGCsll(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Convert.ToBase64String((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lsCyqr5n5tO70X4HNkg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ydj4MO5fUuxjSVXU6G6()
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
	private struct _003CGetMaskImage_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MaskBitmap> _003C_003Et__builder;

		public ResourceNode toolNode;

		public string endpointUrl;

		public Size requestedSize;

		public SegmentAdapterBase _003C_003E4__this;

		private TaskAwaiter<Bitmap> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IINBMM3r5KiOXyfTTcp();
			int num;
			if (!rW3e823P6xJCC8M2DSZ())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_006a;
				}
			}
			goto IL_035d;
			IL_006a:
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			MaskBitmap result = default;
			try
			{
				TaskAwaiter<Bitmap> awaiter = default;
				int num3;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__1;
						goto IL_017c;
					}
					num3 = 9;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
				}
				goto IL_00d0;
				IL_00d0:
				string url = default;
				Bitmap result2 = default;
				while (true)
				{
					switch (num3)
					{
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 10:
						num2 = (_003C_003E1__state = -1);
						goto IL_00b5;
					default:
						rW3e823P6xJCC8M2DSZ();
						if (!IINBMM3r5KiOXyfTTcp())
						{
							num3 = 17;
							continue;
						}
						num3 = 11;
						if (true)
						{
							continue;
						}
						goto case 14;
					case 14:
						num2 = (_003C_003E1__state = -1);
						num3 = 15;
						if (IINBMM3r5KiOXyfTTcp())
						{
							continue;
						}
						goto case 3;
					case 3:
						if (IvQS3x31oXDeIIuO26P(requestedSize, default))
						{
							num3 = 1;
							if (true)
							{
								continue;
							}
							break;
						}
						awaiter = ((CvsCogSocket)rhsNyY3Stnig4mM1O9J(segmentAdapterBase.InSight)).GetImageByHttpAsync(url, (string)null, (string)null, (string)null, (string)null, (string)null, (string)null, (string)NSkSA836kYB3o4Fc1hb(1982), (string)NSkSA836kYB3o4Fc1hb(1982)).GetAwaiter();
						num3 = 2;
						continue;
					case 13:
					case 17:
						break;
					case 5:
						num2 = (_003C_003E1__state = 1);
						num3 = 6;
						if (IINBMM3r5KiOXyfTTcp())
						{
							continue;
						}
						goto case 15;
					case 15:
						result2 = awaiter.GetResult();
						num3 = 18;
						continue;
					case 9:
						url = (string)GiwEqt3gARtE8MYNU8i(PokAge34woHWtRcKD27(toolNode), endpointUrl);
						num3 = 3;
						continue;
					case 1:
						awaiter = ((CvsCogSocket)rhsNyY3Stnig4mM1O9J(segmentAdapterBase.InSight)).GetImageByHttpAsync(url, requestedSize.Width.ToString(), requestedSize.Height.ToString(), (string)null, (string)null, (string)null, (string)null, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1982), (string)NSkSA836kYB3o4Fc1hb(1982)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 12;
							continue;
						}
						goto IL_00b5;
					case 4:
						_003C_003Eu__1 = default;
						num3 = 10;
						if (0 == 0)
						{
							continue;
						}
						goto case 12;
					case 12:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 16:
						return;
					case 2:
						if (awaiter.IsCompleted)
						{
							goto case 15;
						}
						num3 = 5;
						if (true)
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 16;
						continue;
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						continue;
					case 8:
					case 11:
					case 18:
						{
							result = (MaskBitmap)BqZoci3Dae93l1TD2R7(result2);
							goto end_IL_00d0;
						}
						IL_00b5:
						result2 = awaiter.GetResult();
						goto default;
					}
					goto IL_017c;
					continue;
					end_IL_00d0:
					break;
				}
				goto end_IL_006a;
				IL_017c:
				_003C_003Eu__1 = default;
				num3 = 14;
				goto IL_00d0;
				end_IL_006a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0028;
			IL_0028:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_035d;
			IL_035d:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 4:
					segmentAdapterBase = _003C_003E4__this;
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					goto IL_006a;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0028;
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
		internal static object PokAge34woHWtRcKD27(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).HttpRootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GiwEqt3gARtE8MYNU8i(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IvQS3x31oXDeIIuO26P(Size P_0, Size P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 != P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rhsNyY3Stnig4mM1O9J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NSkSA836kYB3o4Fc1hb(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BqZoci3Dae93l1TD2R7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MaskBitmap.FromBitmap((Bitmap)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IINBMM3r5KiOXyfTTcp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rW3e823P6xJCC8M2DSZ()
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
	private struct _003CGetModelStatsFromCameraAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SegmenterStats> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<ELSegmenterModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			SegmenterStats result = default;
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter<ELSegmenterModelStats> awaiter = default;
			ELSegmenterModelStats result2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							DfKCAk38Zkb5sdbFreG();
							num3 = (bCDv2P3FUOJOG8PtoJF() ? 4 : 8);
							goto IL_009d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_012f;
						IL_009d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 5:
								result2 = awaiter.GetResult();
								num3 = 10;
								continue;
							case 0:
							case 8:
							{
								object obj = yjyOdK3sVkrYGrfy1DW(segmentAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((SegmentToolApi)obj).GetModelStats().GetAwaiter();
								num3 = 1;
								continue;
							}
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 4:
							case 6:
								break;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 2:
								return;
							case 10:
							{
								SegmenterStats segmenterStats = new SegmenterStats();
								KvMYbB3EdNeWXekpTK0(segmenterStats, (float)lnhqBJ3dQGlM3kjrauV(result2));
								Exa3vY33m9L5JqFn4QD(segmenterStats, y83AMJ35oQcTOG6OwDM(result2));
								segmenterStats.numSamples = eXSMRF3aYxIe6QVuTcm(result2);
								segmenterStats.maxNumClasses = Fwwt3x3o5IEtMeN4lNR(segmentAdapterBase);
								result = segmenterStats;
								goto end_IL_009d;
							}
							}
							goto IL_012f;
							continue;
							end_IL_009d:
							break;
						}
						goto end_IL_0041;
						IL_012f:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 5;
						goto IL_009d;
						end_IL_0041:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
					segmentAdapterBase = _003C_003E4__this;
					_ = 1;
					if (bCDv2P3FUOJOG8PtoJF())
					{
						num = 0;
						break;
					}
					num = 4;
					if (bCDv2P3FUOJOG8PtoJF())
					{
						return;
					}
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
		internal static object yjyOdK3sVkrYGrfy1DW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double lnhqBJ3dQGlM3kjrauV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterModelStats)P_0).ModelHealth;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KvMYbB3EdNeWXekpTK0(object P_0, float P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterStats)P_0).modelHealth = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int y83AMJ35oQcTOG6OwDM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterModelStats)P_0).NumClasses;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Exa3vY33m9L5JqFn4QD(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterStats)P_0).numClasses = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int eXSMRF3aYxIe6QVuTcm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterModelStats)P_0).NumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Fwwt3x3o5IEtMeN4lNR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).MaxNumClasses;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DfKCAk38Zkb5sdbFreG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bCDv2P3FUOJOG8PtoJF()
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
	private struct _003CGetResultFromCameraAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SegmenterResult> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private ResourceNode _003CtoolNode_003E5__2;

		private ELSegmenterResult _003Cresult_003E5__3;

		private TaskAwaiter<ELSegmenterResult> _003C_003Eu__1;

		private bool _003ChasPredictions_003E5__4;

		private SegmenterResult _003C_003E7__wrap4;

		private SegmenterResult _003C_003E7__wrap5;

		private SegmenterResult _003C_003E7__wrap6;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter<MaskBitmap> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_04aa;
			IL_001a:
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			SegmenterResult result = default;
			try
			{
				int num3;
				TaskAwaiter<string> awaiter3 = default;
				TaskAwaiter<MaskBitmap> awaiter2 = default;
				TaskAwaiter<ELSegmenterResult> awaiter = default;
				string result2 = default;
				MaskBitmap maskBitmap = default;
				switch (num2)
				{
				default:
					segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
					num3 = 9;
					goto IL_0374;
				case 1:
					awaiter3 = _003C_003Eu__2;
					num3 = 7;
					goto IL_0374;
				case 2:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_028e;
				case 0:
					{
						awaiter = _003C_003Eu__1;
						num3 = 4;
						goto IL_0374;
					}
					IL_0374:
					while (true)
					{
						object value;
						switch (num3)
						{
						case 14:
							value = null;
							goto IL_004d;
						case 28:
							if (awaiter2.IsCompleted)
							{
								break;
							}
							goto case 0;
						case 23:
							result2 = awaiter3.GetResult();
							num3 = 3;
							if (0 == 0)
							{
								continue;
							}
							goto case 10;
						case 10:
						{
							ELSegmenterResult result3 = awaiter.GetResult();
							_003Cresult_003E5__3 = result3;
							num3 = 2;
							if (0 == 0)
							{
								continue;
							}
							goto case 30;
						}
						case 30:
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 17;
								continue;
							}
							goto case 10;
						case 12:
							_003C_003Eu__2 = awaiter3;
							num3 = 18;
							continue;
						case 8:
						case 11:
							_003C_003E7__wrap4 = _003C_003E7__wrap6;
							num3 = 1;
							continue;
						case 18:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							num3 = 21;
							continue;
						case 15:
							_003C_003E7__wrap6 = new SegmenterResult();
							_ = 1;
							if (ck8M923uDZM2KOjhF5W())
							{
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 23;
							}
							num3 = 8;
							if (WSOErW3cpaKH2Yqqrgl())
							{
								continue;
							}
							goto case 26;
						case 26:
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							continue;
						case 0:
						case 24:
							num2 = (_003C_003E1__state = 2);
							num3 = 29;
							continue;
						case 27:
							awaiter2 = segmentAdapterBase.Fr82vsr6oh((string)rAR9Yx3UqPpLDcjbCcl(_003Cresult_003E5__3), _003CtoolNode_003E5__2).GetAwaiter();
							num3 = 28;
							continue;
						case 3:
							ERlbcl3Vw0FrbVVPGWR(_003C_003E7__wrap4, result2);
							_003C_003E7__wrap5 = _003C_003E7__wrap6;
							if (_003ChasPredictions_003E5__4)
							{
								num3 = 27;
								continue;
							}
							maskBitmap = null;
							num3 = 5;
							continue;
						case 21:
							return;
						case 16:
							num2 = (_003C_003E1__state = -1);
							num3 = 23;
							continue;
						case 4:
							_003C_003Eu__1 = default;
							num3 = 26;
							continue;
						case 29:
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 6;
							continue;
						case 1:
							awaiter3 = segmentAdapterBase.JpO20jQtaX((string)LblnXu3qQuSxLVPhyOs(_003Cresult_003E5__3), _003CtoolNode_003E5__2).GetAwaiter();
							num3 = 19;
							if (0 == 0)
							{
								continue;
							}
							return;
						case 6:
							return;
						case 5:
						case 22:
							g0BaAf3iDot9G54lVxF(_003C_003E7__wrap5, maskBitmap);
							num3 = 31;
							continue;
						case 2:
						{
							ELSegmenterResult eLSegmenterResult = _003Cresult_003E5__3;
							if (eLSegmenterResult != null)
							{
								value = VuV8MZ3hEO7IXuW65PK(eLSegmenterResult);
								goto IL_004d;
							}
							num3 = 14;
							if (WSOErW3cpaKH2Yqqrgl())
							{
								continue;
							}
							goto case 17;
						}
						case 17:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 19:
							if (!awaiter3.IsCompleted)
							{
								num3 = 20;
								continue;
							}
							goto case 23;
						case 25:
						{
							object obj = FpISPH3xgSg1Toum7Zw(segmentAdapterBase, toolId);
							token.ThrowIfCancellationRequested();
							awaiter = ((SegmentToolApi)obj).GetResult().GetAwaiter();
							num3 = 30;
							continue;
						}
						case 9:
							_003CtoolNode_003E5__2 = (ResourceNode)Tk6cyE3BY1GUkk1q5Z0(segmentAdapterBase, toolId);
							num3 = 25;
							continue;
						case 20:
							num2 = (_003C_003E1__state = 1);
							goto case 12;
						default:
							num3 = 12;
							if (true)
							{
								continue;
							}
							goto case 13;
						case 13:
							result = new SegmenterResult();
							goto end_IL_0374;
						case 7:
							_003C_003Eu__2 = default;
							num3 = 16;
							continue;
						case 31:
							{
								result = _003C_003E7__wrap6;
								goto end_IL_0374;
							}
							IL_004d:
							if (string.IsNullOrEmpty((string)value))
							{
								num3 = 13;
								continue;
							}
							_003ChasPredictions_003E5__4 = !mZb8Nj3QXy8A5V4Lu6y(rAR9Yx3UqPpLDcjbCcl(_003Cresult_003E5__3));
							num3 = 15;
							continue;
						}
						goto IL_028e;
						continue;
						end_IL_0374:
						break;
					}
					break;
					IL_028e:
					maskBitmap = awaiter2.GetResult();
					num3 = 22;
					goto IL_0374;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CtoolNode_003E5__2 = null;
				_003Cresult_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			num = 7;
			goto IL_04aa;
			IL_04aa:
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 7:
					_003CtoolNode_003E5__2 = null;
					goto default;
				default:
					WSOErW3cpaKH2Yqqrgl();
					num = (ck8M923uDZM2KOjhF5W() ? 1 : 3);
					continue;
				case 1:
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 8;
					continue;
				case 2:
					segmentAdapterBase = _003C_003E4__this;
					num = 6;
					if (WSOErW3cpaKH2Yqqrgl())
					{
						continue;
					}
					goto case 3;
				case 3:
				case 4:
					_003Cresult_003E5__3 = null;
					goto case 1;
				case 0:
					num2 = _003C_003E1__state;
					num = 2;
					if (WSOErW3cpaKH2Yqqrgl())
					{
						continue;
					}
					return;
				case 8:
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
		internal static object Tk6cyE3BY1GUkk1q5Z0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FpISPH3xgSg1Toum7Zw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VuV8MZ3hEO7IXuW65PK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterResult)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rAR9Yx3UqPpLDcjbCcl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterResult)P_0).PredictionUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mZb8Nj3QXy8A5V4Lu6y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LblnXu3qQuSxLVPhyOs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterResult)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ERlbcl3Vw0FrbVVPGWR(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterResult)P_0).image = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g0BaAf3iDot9G54lVxF(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterResult)P_0).overlayImage = (IMaskBitmap)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WSOErW3cpaKH2Yqqrgl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ck8M923uDZM2KOjhF5W()
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
	private struct _003CGetSamplesFromCameraAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, SegmenterSample>> _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private ResourceNode _003CtoolNode_003E5__2;

		private SegmentToolApi _003Ctool_003E5__3;

		private Dictionary<string, SegmenterSample> _003Csamples_003E5__4;

		private ICollection<ELSegmenterSample> _003CsegmenterSamples_003E5__5;

		private Size _003ClowResSize_003E5__6;

		private TaskAwaiter<ELSegmenterSample[]> _003C_003Eu__1;

		private TaskAwaiter<Size> _003C_003Eu__2;

		private IEnumerator<ELSegmenterSample> _003C_003E7__wrap6;

		private ELSegmenterSample _003Csample_003E5__8;

		private Dictionary<string, SegmenterSample> _003C_003E7__wrap8;

		private string _003C_003E7__wrap9;

		private SegmenterSample _003C_003E7__wrap10;

		private SegmenterSample _003C_003E7__wrap11;

		private SegmenterSample _003C_003E7__wrap12;

		private TaskAwaiter<string> _003C_003Eu__3;

		private TaskAwaiter<MaskBitmap> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			Dictionary<string, SegmenterSample> result5 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			int num2 = default;
			TaskAwaiter<string> awaiter3 = default;
			TaskAwaiter<MaskBitmap> awaiter4 = default;
			string result3 = default;
			MaskBitmap result4 = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					num2 = _003C_003E1__state;
					num = 1;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult(result5);
					num = 10;
					break;
				case 0:
				case 4:
					_003Ctool_003E5__3 = null;
					goto case 2;
				default:
					num = 2;
					break;
				case 6:
				case 7:
					_003CsegmenterSamples_003E5__5 = null;
					num = 5;
					break;
				case 9:
					_003CtoolNode_003E5__2 = null;
					_ = 1;
					if (!JBAi6U3tF03oa2Pd2bC())
					{
						num = 0;
						break;
					}
					num = 7;
					if (qLuav03Lo6KhbxoZvFM())
					{
						break;
					}
					goto case 1;
				case 2:
					_003Csamples_003E5__4 = null;
					goto case 6;
				case 1:
					segmentAdapterBase = _003C_003E4__this;
					num = 3;
					break;
				case 3:
					try
					{
						TaskAwaiter<ELSegmenterSample[]> awaiter2;
						TaskAwaiter<Size> awaiter;
						ELSegmenterSample[] result;
						Size result2;
						switch (num2)
						{
						default:
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							_003CtoolNode_003E5__2 = segmentAdapterBase.GetToolNode(toolId);
							_003Ctool_003E5__3 = (SegmentToolApi)XgTswp39pUYtRMZo5Tc(segmentAdapterBase, toolId);
							token.ThrowIfCancellationRequested();
							_003Csamples_003E5__4 = new Dictionary<string, SegmenterSample>();
							awaiter2 = _003Ctool_003E5__3.GetSamples().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01ac;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01ac;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0243;
						case 2:
						case 3:
							break;
							IL_025a:
							_003C_003E7__wrap6 = _003CsegmenterSamples_003E5__5.GetEnumerator();
							break;
							IL_01ac:
							result = awaiter2.GetResult();
							_003CsegmenterSamples_003E5__5 = result;
							token.ThrowIfCancellationRequested();
							_003ClowResSize_003E5__6 = new Size(0, 0);
							if (_003CsegmenterSamples_003E5__5.Count() > 0)
							{
								awaiter = _003Ctool_003E5__3.GetInferenceSize().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0243;
							}
							goto IL_025a;
							IL_0243:
							result2 = awaiter.GetResult();
							_003ClowResSize_003E5__6 = segmentAdapterBase.gAX2LfTpYR(result2);
							goto IL_025a;
						}
						try
						{
							int num3;
							if (num2 != 2)
							{
								num3 = 12;
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num3 = 9;
							}
							while (true)
							{
								switch (num3)
								{
								case 28:
									FQ2G893ZFMNVvgq7D4N(_003C_003E7__wrap12, HRWWBD3v7pGCxB1bijb(_003Csample_003E5__8));
									_003C_003E7__wrap12.imageUrl = (string)R76rxO30hJ8ARc8rh49(_003Csample_003E5__8);
									num3 = 21;
									continue;
								case 6:
									if (!awaiter4.IsCompleted)
									{
										_ = 0;
										if (qLuav03Lo6KhbxoZvFM())
										{
											num3 = 10;
											if (qLuav03Lo6KhbxoZvFM())
											{
												continue;
											}
											goto case 12;
										}
										num3 = 0;
										continue;
									}
									goto case 8;
								case 12:
									if (num2 != 3)
									{
										break;
									}
									awaiter4 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									goto case 0;
								case 11:
									awaiter3 = segmentAdapterBase.JpO20jQtaX((string)R76rxO30hJ8ARc8rh49(_003Csample_003E5__8), _003CtoolNode_003E5__2, _003ClowResSize_003E5__6).GetAwaiter();
									num3 = 19;
									continue;
								case 7:
									_003C_003E7__wrap8 = _003Csamples_003E5__4;
									_003C_003E7__wrap9 = (string)HRWWBD3v7pGCxB1bijb(_003Csample_003E5__8);
									num3 = 14;
									continue;
								case 27:
									_003C_003E7__wrap12 = null;
									num3 = 26;
									continue;
								case 22:
									QETZWj3T7xYotEi8mCL(_003C_003E7__wrap12, pQNBrR3HMIkTo3eq48a(_003Csample_003E5__8));
									goto case 23;
								default:
									num3 = 23;
									continue;
								case 19:
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 24;
										continue;
									}
									goto case 13;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 20;
									continue;
								case 0:
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 8;
									continue;
								case 15:
									_003C_003E7__wrap10 = null;
									_003C_003E7__wrap11 = null;
									num3 = 27;
									if (!JBAi6U3tF03oa2Pd2bC())
									{
										continue;
									}
									return;
								case 20:
									return;
								case 26:
									_003Csample_003E5__8 = null;
									num3 = 29;
									if (JBAi6U3tF03oa2Pd2bC())
									{
									}
									continue;
								case 25:
									awaiter4 = segmentAdapterBase.Fr82vsr6oh((string)pQNBrR3HMIkTo3eq48a(_003Csample_003E5__8), _003CtoolNode_003E5__2, _003ClowResSize_003E5__6).GetAwaiter();
									num3 = 6;
									if (qLuav03Lo6KhbxoZvFM())
									{
										continue;
									}
									goto case 10;
								case 10:
								case 17:
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__4 = awaiter4;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								case 4:
									_003C_003E7__wrap8 = null;
									num3 = 2;
									continue;
								case 14:
									_003C_003E7__wrap12 = new SegmenterSample();
									num3 = 28;
									if (!JBAi6U3tF03oa2Pd2bC())
									{
										continue;
									}
									goto case 23;
								case 23:
									_003C_003E7__wrap11 = _003C_003E7__wrap12;
									num3 = 25;
									if (!JBAi6U3tF03oa2Pd2bC())
									{
										continue;
									}
									goto case 13;
								case 13:
									result3 = awaiter3.GetResult();
									num3 = 5;
									continue;
								case 21:
									_003C_003E7__wrap10 = _003C_003E7__wrap12;
									num3 = 11;
									continue;
								case 2:
									_003C_003E7__wrap9 = null;
									num3 = 15;
									continue;
								case 24:
									_003C_003Eu__3 = awaiter3;
									num3 = 3;
									continue;
								case 16:
									_003C_003E7__wrap8.Add(_003C_003E7__wrap9, _003C_003E7__wrap12);
									num3 = 4;
									continue;
								case 8:
									result4 = awaiter4.GetResult();
									num3 = 1;
									continue;
								case 1:
									GfMQXU3Y0IkyawefUBD(_003C_003E7__wrap11, result4);
									num3 = 16;
									if (JBAi6U3tF03oa2Pd2bC())
									{
									}
									continue;
								case 5:
									pfuW6N3OsF71XW57IB9(_003C_003E7__wrap10, result3);
									num3 = 22;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									continue;
								case 29:
									break;
								}
								if (xyevcg3JmOMRGJSogBa(_003C_003E7__wrap6))
								{
									_003Csample_003E5__8 = _003C_003E7__wrap6.Current;
									num3 = 7;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap6 != null)
							{
								exUQfC3KDQWxQPrYrg6(_003C_003E7__wrap6);
							}
						}
						_003C_003E7__wrap6 = null;
						result5 = _003Csamples_003E5__4;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CtoolNode_003E5__2 = null;
						_003Ctool_003E5__3 = null;
						_003Csamples_003E5__4 = null;
						_003CsegmenterSamples_003E5__5 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 9;
					break;
				case 10:
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
		internal static object XgTswp39pUYtRMZo5Tc(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HRWWBD3v7pGCxB1bijb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterSample)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FQ2G893ZFMNVvgq7D4N(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).id = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R76rxO30hJ8ARc8rh49(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterSample)P_0).ImageUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pfuW6N3OsF71XW57IB9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).image = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pQNBrR3HMIkTo3eq48a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELSegmenterSample)P_0).LabelsUrl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QETZWj3T7xYotEi8mCL(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).labelsUrl = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GfMQXU3Y0IkyawefUBD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmenterSample)P_0).labelImage = (IMaskBitmap)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xyevcg3JmOMRGJSogBa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void exUQfC3KDQWxQPrYrg6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qLuav03Lo6KhbxoZvFM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JBAi6U3tF03oa2Pd2bC()
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
	private struct _003CDeleteSamplesAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		public ICollection<string> sampleIds;

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
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					lXV9ff3CCtaqWXu9TAb();
					if (!lXnA3D3AXMe5LCAtM50())
					{
						num = 5;
						if (lXV9ff3CCtaqWXu9TAb())
						{
							break;
						}
						goto case 1;
					}
					num = 3;
					if (!lXnA3D3AXMe5LCAtM50())
					{
						break;
					}
					goto case 0;
				case 1:
				case 5:
					segmentAdapterBase = _003C_003E4__this;
					goto case 2;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 6:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								if (lXV9ff3CCtaqWXu9TAb())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								lXnA3D3AXMe5LCAtM50();
								if (lXV9ff3CCtaqWXu9TAb())
								{
									num3 = 3;
									if (lXnA3D3AXMe5LCAtM50())
									{
									}
								}
								else
								{
									num3 = 6;
								}
								continue;
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
							{
								object obj = Qgj2MW3NhqnNA3WmVUF(segmentAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((SegmentToolApi)obj).DeleteSamples(sampleIds).GetAwaiter();
								num3 = 4;
								continue;
							}
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								break;
							case 10:
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
					goto case 0;
				default:
					num = 0;
					if (lXnA3D3AXMe5LCAtM50())
					{
						return;
					}
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
		internal static object Qgj2MW3NhqnNA3WmVUF(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SegmentAdapterBase)P_0).GetTool((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lXV9ff3CCtaqWXu9TAb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lXnA3D3AXMe5LCAtM50()
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
	private struct _003CTrainAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter _003C_003Eu__1;

		private Exception _003Cex_003E5__6;

		private TaskAwaiter<bool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XXmf4P3ptyEbE0cJkZD();
			int num = ((!Eq9ANo3wa7uMaNpklTI()) ? 1 : 2);
			SegmentAdapterBase segmentAdapterBase = default;
			SegmentToolApi tool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter awaiter;
						if ((uint)num2 > 1u)
						{
							if (num2 == 2)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02d6;
							}
							segmentAdapterBase.ThrowIfToolIdInvalid(toolId);
							tool = segmentAdapterBase.GetTool(toolId);
							token.ThrowIfCancellationRequested();
							segmentAdapterBase.ClearCaches(toolId);
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = 0;
						}
						try
						{
							TaskAwaiter<bool> awaiter2;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0255;
								}
								_003C_003E7__wrap4 = 0;
							}
							try
							{
								int num3;
								if (num2 != 0)
								{
									awaiter = SiKwSN3Gukd59cSuN29(tool.Train());
									num3 = 5;
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 6;
									if (XXmf4P3ptyEbE0cJkZD())
									{
										goto IL_0119;
									}
								}
								goto IL_00c6;
								IL_0119:
								_003C_003Eu__1 = default;
								num3 = 2;
								goto IL_00c6;
								IL_00c6:
								while (true)
								{
									switch (num3)
									{
									case 3:
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num3 = 0;
										continue;
									case 0:
										return;
									case 6:
										break;
									case 4:
										_003C_003Eu__1 = awaiter;
										goto case 3;
									case 2:
										num2 = (_003C_003E1__state = -1);
										num3 = 9;
										continue;
									case 5:
										if (!awaiter.IsCompleted)
										{
											_ = 1;
											num3 = ((!XXmf4P3ptyEbE0cJkZD()) ? 8 : 7);
											continue;
										}
										goto case 9;
									case 1:
									case 8:
										num2 = (_003C_003E1__state = 0);
										num3 = 4;
										if (XXmf4P3ptyEbE0cJkZD())
										{
										}
										continue;
									case 9:
										awaiter.GetResult();
										goto end_IL_00c6;
									}
									goto IL_0119;
									continue;
									end_IL_00c6:
									break;
								}
							}
							catch (Exception ex)
							{
								_003C_003E7__wrap3 = ex;
								_003C_003E7__wrap4 = 1;
							}
							int num4 = _003C_003E7__wrap4;
							if (num4 == 1)
							{
								_003Cex_003E5__6 = (Exception)_003C_003E7__wrap3;
								IViewModelBroadcaster broadcaster = ViewModelBroadcaster.Default;
								ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel
								{
									Heading = (string)RYOvaY3RPo3o7jIauP9()
								};
								YshYmU3j4kCEUdkNIii(errorMessageViewModel, Resources.ViDiELSegmentTrainGenericMessage);
								awaiter2 = broadcaster.Broadcast(null, errorMessageViewModel).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0255;
							}
							_003C_003E7__wrap3 = null;
							goto end_IL_0075;
							IL_0255:
							awaiter2.GetResult();
							throw _003Cex_003E5__6;
							end_IL_0075:;
						}
						catch (object obj)
						{
							_003C_003E7__wrap1 = obj;
						}
						awaiter = SiKwSN3Gukd59cSuN29(uux4HS3I3WVUaN2xA7W(segmentAdapterBase));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02d6;
						IL_02d6:
						awaiter.GetResult();
						object obj2 = _003C_003E7__wrap1;
						if (obj2 != null)
						{
							EVU51j3baSD6933aJeJ(bUILDT3WN62714vQ771((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					segmentAdapterBase = _003C_003E4__this;
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
		internal static TaskAwaiter SiKwSN3Gukd59cSuN29(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RYOvaY3RPo3o7jIauP9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELSegmentTrainError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YshYmU3j4kCEUdkNIii(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uux4HS3I3WVUaN2xA7W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).RunToolAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bUILDT3WN62714vQ771(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EVU51j3baSD6933aJeJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Eq9ANo3wa7uMaNpklTI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XXmf4P3ptyEbE0cJkZD()
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
	private struct _003CRunToolAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SegmentAdapterBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Qxjp1X3lq0Vb0CZ8JYH() ? 2 : 5);
			int num2 = default;
			SegmentAdapterBase segmentAdapterBase = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					segmentAdapterBase = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							goto IL_00bd;
						}
						if (segmentAdapterBase.RunToolCallback != null)
						{
							num3 = 3;
							if (Qxjp1X3lq0Vb0CZ8JYH())
							{
								goto IL_006d;
							}
							goto IL_00bd;
						}
						goto end_IL_004c;
						IL_00bd:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							default:
								goto IL_008a;
							case 5:
								goto IL_00a4;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (Qxjp1X3lq0Vb0CZ8JYH())
								{
								}
								continue;
							case 1:
								return;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto IL_0166;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_004c;
							}
							break;
							IL_0166:
							_ = 1;
							if (Qxjp1X3lq0Vb0CZ8JYH())
							{
								num3 = 7;
								continue;
							}
							num3 = 6;
							if (Qxjp1X3lq0Vb0CZ8JYH())
							{
							}
						}
						goto IL_006d;
						IL_008a:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						if (false)
						{
							goto IL_00a4;
						}
						goto IL_00bd;
						IL_00a4:
						_003C_003Eu__1 = awaiter;
						goto IL_008a;
						IL_006d:
						awaiter = OGChmZ37QEbYaJsAF3X(segmentAdapterBase.RunToolCallback());
						num3 = 8;
						if (1 == 0)
						{
							goto IL_008a;
						}
						goto IL_00bd;
						end_IL_004c:;
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
		internal static TaskAwaiter OGChmZ37QEbYaJsAF3X(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N1eSRR3e3SkgrWeqXF9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qxjp1X3lq0Vb0CZ8JYH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly string FOk2uhkG2T;

	private static readonly string kqW2Z14jX4;

	private readonly AsyncCache<string, SegmenterStats> afO2JNGusQ;

	private readonly AsyncCache<string, SegmenterResult> TqO2F98msx;

	private readonly AsyncCache<string, Dictionary<string, SegmenterSample>> nhx2c38Geb;

	private readonly Dictionary<string, Dictionary<string, SegmenterSample>> VLD2RRwdn1;

	private readonly AsyncCache<string, ELTunableProjectionParams> GsI2EH0moM;

	private int T5I28ABQUE;

	[CompilerGenerated]
	private Func<Task> EM021bjiaP;

	[CompilerGenerated]
	private EventHandler<NewResultArgs> b8w2DrO72x;

	[CompilerGenerated]
	private EventHandler<ClassesUpdatedArgs> IGL2jU0Pn8;

	protected abstract int MaxNumClasses { get; }

	public Func<Task> RunToolCallback
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EM021bjiaP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EM021bjiaP = value;
		}
	}

	public event EventHandler<NewResultArgs> NewResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = b8w2DrO72x;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref b8w2DrO72x, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = b8w2DrO72x;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref b8w2DrO72x, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<ClassesUpdatedArgs> ClassesUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ClassesUpdatedArgs> eventHandler = IGL2jU0Pn8;
			EventHandler<ClassesUpdatedArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ClassesUpdatedArgs> value2 = (EventHandler<ClassesUpdatedArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IGL2jU0Pn8, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<ClassesUpdatedArgs> eventHandler = IGL2jU0Pn8;
			EventHandler<ClassesUpdatedArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ClassesUpdatedArgs> value2 = (EventHandler<ClassesUpdatedArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IGL2jU0Pn8, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SegmentAdapterBase(CvsInSight insight, Func<Task> triggerAcquisition)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector(insight, triggerAcquisition);
		afO2JNGusQ = new AsyncCache<string, SegmenterStats>(VQl2d504oM);
		TqO2F98msx = new AsyncCache<string, SegmenterResult>(qRr25TgQDs);
		nhx2c38Geb = new AsyncCache<string, Dictionary<string, SegmenterSample>>(jFW2fFoG6F);
		VLD2RRwdn1 = new Dictionary<string, Dictionary<string, SegmenterSample>>();
		GsI2EH0moM = new AsyncCache<string, ELTunableProjectionParams>(g6E2Y0QYgR);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(ISegmenterToolAdapter adapter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KgFSw7MGkHQGIMVf7V2();
		int num;
		if (YqScxdMpVCj69KCdCDy())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0082;
			}
		}
		goto IL_009e;
		IL_0028:
		object obj = qZ1yNVMW7BOKRZb8r2U(DDPqLfMItTxhehMRgAL());
		LocalizationOverride[] array = new LocalizationOverride[1];
		LocalizationOverride localizationOverride = new LocalizationOverride();
		u58sIOMb2ouoh0slFJp(localizationOverride, kqW2Z14jX4);
		MZCWAhMe8rhx6MJSsVR(localizationOverride, Resources.NextImage);
		array[0] = localizationOverride;
		XK9GDsMlhywSwLd2ob4(obj, array);
		num = 5;
		goto IL_009e;
		IL_0082:
		pDxipNMjx57cTKSZZlD(FOk2uhkG2T);
		goto IL_0028;
		IL_009e:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				gmYgL2MRbGCku1xlNI3(ExceptionLoggingDispatchProxyAsync.Create(adapter));
				goto IL_0082;
			case 1:
			case 2:
				goto IL_0082;
			default:
				num = 4;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0028;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalClearCaches(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		do
		{
			IL_008a:
			switch (num)
			{
			case 4:
				TqO2F98msx.Remove(toolId);
				_ = 0;
				if (YqScxdMpVCj69KCdCDy())
				{
					num = 0;
					goto IL_008a;
				}
				num = 5;
				if (0 == 0)
				{
					goto IL_008a;
				}
				break;
			case 1:
				GsI2EH0moM.Remove(toolId);
				num = 7;
				goto IL_008a;
			default:
				VLD2RRwdn1.Remove(toolId);
				num = 1;
				if (0 == 0)
				{
					goto IL_008a;
				}
				goto case 0;
			case 0:
			case 2:
				nhx2c38Geb.Remove(toolId);
				goto default;
			case 6:
				break;
			case 7:
				return;
			}
			afO2JNGusQ.Remove(toolId);
			num = 4;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnNewResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		_003C_003Ec__DisplayClass20_0 obj = default;
		while (true)
		{
			EventHandler<NewResultArgs> eventHandler;
			switch (num)
			{
			case 1:
			case 6:
				_mainThreadDispatcher.Invoke(obj._003COnNewResult_003Eb__0);
				num = 7;
				break;
			case 2:
				ThrowIfToolIdInvalid((string)TBdF99Myg8S9payCAJc(obj.args));
				num = 5;
				break;
			case 9:
				if (!_mainThreadDispatcher.CheckAccess())
				{
					goto case 1;
				}
				goto IL_0075;
			case 7:
				return;
			case 8:
				return;
			case 5:
				ClearCaches((string)TBdF99Myg8S9payCAJc(obj.args));
				YqScxdMpVCj69KCdCDy();
				num = (KgFSw7MGkHQGIMVf7V2() ? 1 : 0);
				break;
			case 10:
				obj = new _003C_003Ec__DisplayClass20_0();
				num = 3;
				if (YqScxdMpVCj69KCdCDy())
				{
					break;
				}
				goto case 3;
			case 3:
			{
				obj._003C_003E4__this = this;
				_003C_003Ec__DisplayClass20_0 obj2 = obj;
				NewResultArgs newResultArgs = new NewResultArgs();
				u1THw5M7F5h9ym9gaac(newResultArgs, toolId);
				obj2.args = newResultArgs;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			}
			case 0:
			case 4:
				if (_mainThreadDispatcher != null)
				{
					goto case 9;
				}
				goto IL_0075;
			default:
				num = 9;
				break;
			case 11:
				return;
				IL_0075:
				eventHandler = b8w2DrO72x;
				if (eventHandler == null)
				{
					num = 8;
					if (!YqScxdMpVCj69KCdCDy())
					{
						return;
					}
				}
				else
				{
					eventHandler(this, obj.args);
					num = 11;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddClass_003Ed__24))]
	public Task<int> AddClass(string toolId, ISegmenterClass segmenterClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddClass_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.segmenterClass = segmenterClass;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetClasses_003Ed__25))]
	public Task<ICollection<ISegmenterClass>> GetClasses(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetClasses_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISegmenterClass>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateClasses_003Ed__26))]
	public Task UpdateClasses(string toolId, ICollection<ISegmenterClass> editedClasses, ICollection<int> deletedClassIDs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateClasses_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.editedClasses = editedClasses;
		stateMachine.deletedClassIDs = deletedClassIDs;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetStats_003Ed__27))]
	public Task<ISegmenterStats> GetStats(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetStats_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ISegmenterStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSample_003Ed__28))]
	public Task<ISegmenterSample> GetSample(string toolId, string sampleId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSample_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ISegmenterSample>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.sampleId = sampleId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__29))]
	public Task<ICollection<ISegmenterSample>> GetSamples(string toolId, int imageSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__29 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISegmenterSample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.imageSize = imageSize;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamples_003Ed__30))]
	public Task DeleteSamples(string toolId, ICollection<string> sampleIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamples_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.sampleIds = sampleIds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelImage_003Ed__31))]
	public Task LabelImage(string toolId, string sampleId, IMaskBitmap maskImage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!YqScxdMpVCj69KCdCDy()) ? 7 : 3);
		_003CLabelImage_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				stateMachine.sampleId = sampleId;
				goto case 8;
			default:
				num = 8;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 8:
				stateMachine.maskImage = maskImage;
				num = 6;
				break;
			case 2:
			case 7:
				stateMachine.toolId = toolId;
				num = 5;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = r9ae46Mn36xiCXYtuqm();
				num = 1;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCurrentResult_003Ed__32))]
	public Task<ISegmenterResult> GetCurrentResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCurrentResult_003Ed__32 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ISegmenterResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetProjectionParams_003Ed__33))]
	public Task<ELTunableProjectionParams> GetProjectionParams(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetProjectionParams_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAutoTuneProjectionParameters_003Ed__34))]
	public Task<ELTunableProjectionParams> GetAutoTuneProjectionParameters(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAutoTuneProjectionParameters_003Ed__34 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetProjectionParams_003Ed__35))]
	public Task<ELTunableProjectionParams> SetProjectionParams(string toolId, ELTunableProjectionParams projectionParams)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetProjectionParams_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.projectionParams = projectionParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetProjectionParamsFromCameraAsync_003Ed__36))]
	private Task<ELTunableProjectionParams> g6E2Y0QYgR(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetProjectionParamsFromCameraAsync_003Ed__36 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELTunableProjectionParams>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImage_003Ed__37))]
	private Task<string> JpO20jQtaX(string P_0, ResourceNode P_1, Size P_2 = default(Size))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImage_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.endpointUrl = P_0;
		stateMachine.toolNode = P_1;
		stateMachine.requestedSize = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetMaskImage_003Ed__38))]
	private Task<MaskBitmap> Fr82vsr6oh(string P_0, ResourceNode P_1, Size P_2 = default(Size))
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetMaskImage_003Ed__38 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<MaskBitmap>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.endpointUrl = P_0;
		stateMachine.toolNode = P_1;
		stateMachine.requestedSize = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Size gAX2LfTpYR(Size P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KgFSw7MGkHQGIMVf7V2();
		int num;
		if (YqScxdMpVCj69KCdCDy())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 9;
		}
		goto IL_00e1;
		IL_002a:
		if (P_0.Height >= T5I28ABQUE)
		{
			goto IL_00bc;
		}
		num = 4;
		goto IL_00e1;
		IL_00bc:
		if (P_0.Width > P_0.Height)
		{
			goto IL_0046;
		}
		int width = (int)tt3LpRMfTIbXnGifr77((double)P_0.Width / (double)P_0.Height * (double)T5I28ABQUE);
		num = 5;
		goto IL_00e1;
		IL_0122:
		if (P_0.Width < T5I28ABQUE)
		{
			goto IL_002a;
		}
		goto IL_00bc;
		IL_0046:
		width = T5I28ABQUE;
		num = 7;
		goto IL_00e1;
		IL_00e1:
		int height = default;
		Size result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 9:
				break;
			case 10:
				goto IL_0046;
			case 5:
				height = T5I28ABQUE;
				num = 11;
				continue;
			case 0:
			case 1:
				goto IL_0068;
			case 7:
				height = (int)Math.Round((double)P_0.Height / (double)P_0.Width * (double)T5I28ABQUE);
				num = 8;
				continue;
			case 4:
				result = default;
				num = 6;
				continue;
			case 6:
				return result;
			default:
				num = 10;
				continue;
			case 3:
				return P_0;
			case 8:
			case 11:
				return new Size(width, height);
			}
			break;
			IL_0068:
			if (P_0.IsEmpty)
			{
				num = 3;
				continue;
			}
			goto IL_0122;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModelStatsFromCameraAsync_003Ed__40))]
	private Task<SegmenterStats> VQl2d504oM(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetModelStatsFromCameraAsync_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<SegmenterStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetResultFromCameraAsync_003Ed__41))]
	private Task<SegmenterResult> qRr25TgQDs(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetResultFromCameraAsync_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<SegmenterResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamplesFromCameraAsync_003Ed__42))]
	private Task<Dictionary<string, SegmenterSample>> jFW2fFoG6F(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamplesFromCameraAsync_003Ed__42 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, SegmenterSample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamplesAsync_003Ed__43))]
	private Task dJr29Da5Zn(string P_0, ICollection<string> P_1, CancellationToken P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDeleteSamplesAsync_003Ed__43 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.sampleIds = P_1;
		stateMachine.token = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainAsync_003Ed__44))]
	public Task TrainAsync(string toolId, CancellationToken token)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!KgFSw7MGkHQGIMVf7V2())
		{
			num = 2;
			if (KgFSw7MGkHQGIMVf7V2())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0056;
		IL_002a:
		_003CTrainAsync_003Ed__44 stateMachine = default;
		stateMachine.toolId = toolId;
		num = 6;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 6:
				stateMachine.token = token;
				goto case 7;
			default:
				num = 7;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!KgFSw7MGkHQGIMVf7V2())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = r9ae46Mn36xiCXYtuqm();
				goto case 1;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	protected abstract SegmentToolApi GetTool(string toolId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__46))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KgFSw7MGkHQGIMVf7V2();
		int num = ((!YqScxdMpVCj69KCdCDy()) ? 3 : 5);
		_003CRunToolAsync_003Ed__46 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = r9ae46Mn36xiCXYtuqm();
				goto case 1;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int u0I2AoNZFC(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ColorTranslator.FromHtml(P_0).ToArgb() & 0xFFFFFF;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string gCO2yTokFy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Color color = AgZRruMz2UonnBmuv8b(P_0);
		return (string)jTCTi8kX66JYR8nI5fh(t4KFVok28kM3ZLsZ8C2(880), color.R.ToString((string)t4KFVok28kM3ZLsZ8C2(886)), color.G.ToString((string)t4KFVok28kM3ZLsZ8C2(886)), color.B.ToString((string)t4KFVok28kM3ZLsZ8C2(886)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalDisposeCaches()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YqScxdMpVCj69KCdCDy();
		int num;
		if (!KgFSw7MGkHQGIMVf7V2())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_00bd;
			}
		}
		goto IL_005c;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 5:
				nhx2c38Geb.Dispose();
				goto IL_00bd;
			default:
				num = 4;
				continue;
			case 6:
				VNQxuhkkLYNTWi09BMO(GsI2EH0moM);
				num = 7;
				continue;
			case 0:
			case 3:
				afO2JNGusQ.Dispose();
				break;
			case 4:
				goto IL_00bd;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_00bd:
		emgiFVkMOFhw8NbEYCp(VLD2RRwdn1);
		num = 6;
		goto IL_005c;
		IL_002a:
		TqO2F98msx.Dispose();
		num = 5;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SegmentAdapterBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KgFSw7MGkHQGIMVf7V2();
		int num;
		if (YqScxdMpVCj69KCdCDy())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0079;
		IL_0058:
		FOk2uhkG2T = plfGltUiaC1OFfC2I8.OIRNC4VQ7F(894);
		goto IL_003f;
		IL_0079:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 2:
				goto IL_003f;
			case 1:
			case 4:
				goto IL_0058;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		goto IL_0058;
		IL_003f:
		kqW2Z14jX4 = (string)t4KFVok28kM3ZLsZ8C2(908);
		num = 5;
		goto IL_0079;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gmYgL2MRbGCku1xlNI3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmenterClient.RegisterAdapter((ISegmenterToolAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pDxipNMjx57cTKSZZlD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmenterClient.SetInitialTheme((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DDPqLfMItTxhehMRgAL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qZ1yNVMW7BOKRZb8r2U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CultureInfo)P_0).TwoLetterISOLanguageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u58sIOMb2ouoh0slFJp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LocalizationOverride)P_0).key = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MZCWAhMe8rhx6MJSsVR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((LocalizationOverride)P_0).value = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XK9GDsMlhywSwLd2ob4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmenterClient.SetLocale((string)P_0, (LocalizationOverride[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YqScxdMpVCj69KCdCDy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KgFSw7MGkHQGIMVf7V2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u1THw5M7F5h9ym9gaac(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((NewResultArgs)P_0).toolId = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TBdF99Myg8S9payCAJc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NewResultArgs)P_0).toolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder r9ae46Mn36xiCXYtuqm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double tt3LpRMfTIbXnGifr77(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color AgZRruMz2UonnBmuv8b(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t4KFVok28kM3ZLsZ8C2(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jTCTi8kX66JYR8nI5fh(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void emgiFVkMOFhw8NbEYCp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<string, Dictionary<string, SegmenterSample>>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VNQxuhkkLYNTWi09BMO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AsyncCache<string, ELTunableProjectionParams>)P_0).Dispose();
	}
}
