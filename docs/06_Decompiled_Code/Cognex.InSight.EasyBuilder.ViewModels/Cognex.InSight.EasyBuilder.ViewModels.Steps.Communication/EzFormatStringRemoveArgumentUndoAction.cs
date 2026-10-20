using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class EzFormatStringRemoveArgumentUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringRemoveArgumentUndoAction _003C_003E4__this;

		private EzFormatStringViewModel _003Cvm_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzFormatStringRemoveArgumentUndoAction ezFormatStringRemoveArgumentUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003Cvm_003E5__2 = null;
					num = 6;
					continue;
				case 0:
					ezFormatStringRemoveArgumentUndoAction = _003C_003E4__this;
					_ = 0;
					num = (foAWwx5VTtk3Qto0stll() ? 1 : 5);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003Cvm_003E5__2 = ezFormatStringRemoveArgumentUndoAction.FpkiN630Ik();
							num3 = 21;
							goto IL_0249;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 22;
							goto IL_0249;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 6;
							goto IL_0249;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 23;
								if (true)
								{
									goto IL_0249;
								}
								goto IL_0312;
							}
							IL_0249:
							while (true)
							{
								switch (num3)
								{
								case 15:
									return;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 12;
									continue;
								case 18:
									awaiter.GetResult();
									num3 = 5;
									if (foAWwx5VTtk3Qto0stll())
									{
										continue;
									}
									goto case 13;
								case 13:
									awaiter = ax9by45V06GiYcGqWMZY(b7CUaU5VYXfYYpajXcZa(ezFormatStringRemoveArgumentUndoAction.EGTioksKDt));
									num3 = 7;
									continue;
								case 19:
									_003C_003Eu__1 = awaiter;
									num3 = 2;
									if (foAWwx5VTtk3Qto0stll())
									{
										continue;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
								case 8:
									ezFormatStringRemoveArgumentUndoAction.WDPiFG1M11 = _003Cvm_003E5__2.Expression;
									ezFormatStringRemoveArgumentUndoAction.EGTioksKDt = new UndoExpressionAction((CvsInSight)scP3Rh5VFcvHLJK1mx9Q(_003Cvm_003E5__2), Gi3CZ85VMlndgiqODYPl(_003Cvm_003E5__2), ezFormatStringRemoveArgumentUndoAction.WDPiFG1M11);
									num3 = 13;
									continue;
								case 21:
									ezFormatStringRemoveArgumentUndoAction.kSBiuqwLe7 = _003Cvm_003E5__2.Expression;
									_ = 0;
									if (foAWwx5VTtk3Qto0stll())
									{
										num3 = 10;
										if (!H1axvo5VyLEiLtgowbvH())
										{
											continue;
										}
										goto case 9;
									}
									num3 = 3;
									continue;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 18;
									if (0 == 0)
									{
										continue;
									}
									goto case 14;
								case 14:
									if (!awaiter.IsCompleted)
									{
										num3 = 16;
										continue;
									}
									goto case 24;
								case 22:
									awaiter.GetResult();
									goto case 3;
								case 7:
									if (awaiter.IsCompleted)
									{
										goto case 18;
									}
									num2 = (_003C_003E1__state = 1);
									goto case 19;
								default:
									num3 = 19;
									continue;
								case 11:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 20;
									continue;
								case 23:
									num2 = (_003C_003E1__state = -1);
									num3 = 24;
									continue;
								case 20:
									return;
								case 16:
									break;
								case 4:
									_003C_003Eu__1 = awaiter;
									num3 = 9;
									continue;
								case 5:
									awaiter = ax9by45V06GiYcGqWMZY(dWy6oG5VUCVn1CAma7S3(ezFormatStringRemoveArgumentUndoAction.EGTioksKDt));
									num3 = 14;
									continue;
								case 1:
								case 10:
									awaiter = ax9by45V06GiYcGqWMZY(_003Cvm_003E5__2.RemoveReferencesAsync(ezFormatStringRemoveArgumentUndoAction.aIri6gNY6r));
									num3 = 17;
									continue;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num3 = 0;
										continue;
									}
									goto case 22;
								case 24:
									awaiter.GetResult();
									goto end_IL_0249;
								}
								goto IL_0312;
								continue;
								end_IL_0249:
								break;
							}
							break;
							IL_0312:
							num2 = (_003C_003E1__state = 2);
							num3 = 11;
							if (H1axvo5VyLEiLtgowbvH())
							{
							}
							goto IL_0249;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cvm_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 7;
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
		internal static TaskAwaiter ax9by45V06GiYcGqWMZY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object scP3Rh5VFcvHLJK1mx9Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation Gi3CZ85VMlndgiqODYPl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b7CUaU5VYXfYYpajXcZa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoExpressionAction)P_0).SaveState();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dWy6oG5VUCVn1CAma7S3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoExpressionAction)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool foAWwx5VTtk3Qto0stll()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H1axvo5VyLEiLtgowbvH()
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
	private struct _003CRedo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringRemoveArgumentUndoAction _003C_003E4__this;

		private EzFormatStringViewModel _003Cvm_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KDHyZp5VxT9apgE94IRb();
			int num = ((!Tj3tfD5VHpdya6y8MDQh()) ? 5 : 3);
			int num2 = default;
			EzFormatStringRemoveArgumentUndoAction ezFormatStringRemoveArgumentUndoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					ezFormatStringRemoveArgumentUndoAction = _003C_003E4__this;
					goto case 2;
				case 4:
					_003Cvm_003E5__2 = null;
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Cvm_003E5__2 = ezFormatStringRemoveArgumentUndoAction.FpkiN630Ik();
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
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (Tj3tfD5VHpdya6y8MDQh())
									{
										continue;
									}
									goto case 1;
								}
								goto case 3;
							case 1:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								Tj3tfD5VHpdya6y8MDQh();
								num3 = ((!KDHyZp5VxT9apgE94IRb()) ? 1 : 0);
								continue;
							case 7:
								awaiter = qwoDWM5VQuPeYGeTw0NH(V3V1q25VmQbkQtqESI4T(ezFormatStringRemoveArgumentUndoAction.EGTioksKDt));
								num3 = 2;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								goto case 0;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 10:
								SQkYFy5VNBNRIPVbO42A(_003Cvm_003E5__2, ezFormatStringRemoveArgumentUndoAction.WDPiFG1M11);
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cvm_003E5__2 = null;
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
				case 6:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 7;
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
		internal static object V3V1q25VmQbkQtqESI4T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoExpressionAction)P_0).Redo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qwoDWM5VQuPeYGeTw0NH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SQkYFy5VNBNRIPVbO42A(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringViewModel)P_0).Refresh((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tj3tfD5VHpdya6y8MDQh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KDHyZp5VxT9apgE94IRb()
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
	private struct _003CUndo_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringRemoveArgumentUndoAction _003C_003E4__this;

		private EzFormatStringViewModel _003Cvm_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			flKf6X5VcoEKiVSsPG3W();
			int num = ((!XqqWOh5V2vLMqChMX6kk()) ? 4 : 5);
			int num2 = default;
			EzFormatStringRemoveArgumentUndoAction ezFormatStringRemoveArgumentUndoAction = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (XqqWOh5V2vLMqChMX6kk())
					{
						break;
					}
					goto case 6;
				case 6:
					_003Cvm_003E5__2 = null;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					ezFormatStringRemoveArgumentUndoAction = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Cvm_003E5__2 = ezFormatStringRemoveArgumentUndoAction.FpkiN630Ik();
							num3 = 9;
							goto IL_0151;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00ed;
						IL_00ed:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_0151;
						IL_0151:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								flKf6X5VcoEKiVSsPG3W();
								if (XqqWOh5V2vLMqChMX6kk())
								{
									num3 = 4;
									if (1 == 0)
									{
										return;
									}
								}
								else
								{
									num3 = 0;
									if (flKf6X5VcoEKiVSsPG3W())
									{
									}
								}
								continue;
							case 6:
								return;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 1;
							case 0:
							case 5:
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 9:
								awaiter = VZmJFP5VuCbPph0Idw19(Bhcmm45V1gHuTOJQ8OBu(ezFormatStringRemoveArgumentUndoAction.EGTioksKDt));
								num3 = 2;
								continue;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 1:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 10:
								_003Cvm_003E5__2.Refresh(ezFormatStringRemoveArgumentUndoAction.kSBiuqwLe7);
								goto end_IL_0151;
							}
							goto IL_00ed;
							continue;
							end_IL_0151:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cvm_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (!XqqWOh5V2vLMqChMX6kk())
					{
						return;
					}
					break;
				case 7:
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
		internal static object Bhcmm45V1gHuTOJQ8OBu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoExpressionAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VZmJFP5VuCbPph0Idw19(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XqqWOh5V2vLMqChMX6kk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool flKf6X5VcoEKiVSsPG3W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CommStepViewModel W7niAFliSb;

	private Type GFtidRhomL;

	private readonly IEnumerable<FormatStringArgViewModel> aIri6gNY6r;

	private string kSBiuqwLe7;

	private string WDPiFG1M11;

	private Type[] nDFiX9Jom5;

	private UndoExpressionAction EGTioksKDt;

	[CompilerGenerated]
	private readonly string mjfiSdxWml;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mjfiSdxWml;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EzFormatStringRemoveArgumentUndoAction(CommStepViewModel commAppStep, Type type, IEnumerable<FormatStringArgViewModel> argumentsToRemove)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		nDFiX9Jom5 = new Type[3]
		{
			typeof(WriteDataFtp),
			typeof(WriteDataSerial),
			typeof(WriteTcpIp)
		};
		base._002Ector();
		if (!nDFiX9Jom5.Contains(type))
		{
			throw new NotSupportedException(type.ToString());
		}
		W7niAFliSb = commAppStep;
		GFtidRhomL = type;
		aIri6gNY6r = argumentsToRemove;
		mjfiSdxWml = "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__9))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (AsblXD2YkaR9V6wocWa())
		{
			goto IL_001e;
		}
		goto IL_004c;
		IL_00a5:
		_003CDo_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (0 == 0)
		{
			goto IL_004c;
		}
		goto IL_00bf;
		IL_00bf:
		return stateMachine._003C_003Et__builder.Task;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				goto IL_0032;
			case 2:
				do
				{
					stateMachine._003C_003Et__builder = xcYtTH2UTG6VUrGPPFl();
					AsblXD2YkaR9V6wocWa();
					if (!Fctuiu2MGoLYeMSTKig())
					{
						num = 0;
						continue;
					}
					num = 4;
					break;
				}
				while (false);
				continue;
			default:
				goto IL_00a5;
			case 6:
				goto IL_00bf;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		stateMachine._003C_003E4__this = this;
		num = 5;
		if (1 == 0)
		{
			goto IL_0032;
		}
		goto IL_004c;
		IL_0032:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__10))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = xcYtTH2UTG6VUrGPPFl();
				Fctuiu2MGoLYeMSTKig();
				if (AsblXD2YkaR9V6wocWa())
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				num = 3;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (Fctuiu2MGoLYeMSTKig())
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__11))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AsblXD2YkaR9V6wocWa() ? 1 : 5);
		_003CUndo_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				if (!AsblXD2YkaR9V6wocWa())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel FpkiN630Ik()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AsblXD2YkaR9V6wocWa() ? 4 : 5);
		EzFormatStringViewModel result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				result = null;
				num = 6;
				if (Fctuiu2MGoLYeMSTKig())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				result = ((EzFormatStringSupportSnippet)zWvbGx2xOuWiAwVp2oB(W7niAFliSb)).FormatString;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				result = (EzFormatStringViewModel)TGfPZ122ZxX1plbvlfE(FPI6RA2N9pcaSc5B5PR(W7niAFliSb));
				num = 9;
				continue;
			case 8:
				result = ((EzFormatStringSupportSnippet)VL9xbk2QE95dT1DCNOd(W7niAFliSb)).FormatString;
				num = 3;
				continue;
			default:
				num = 8;
				continue;
			case 6:
				if (!(GFtidRhomL == SDQOhM2HxKX1EURAvMB(typeof(WriteDataFtp).TypeHandle)))
				{
					if (!brkwlI2mpeaPj102f58(GFtidRhomL, SDQOhM2HxKX1EURAvMB(typeof(WriteDataSerial).TypeHandle)))
					{
						if (GFtidRhomL == SDQOhM2HxKX1EURAvMB(typeof(WriteTcpIp).TypeHandle))
						{
							num = 1;
							continue;
						}
						break;
					}
					goto case 8;
				}
				goto case 2;
			case 3:
			case 7:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xcYtTH2UTG6VUrGPPFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fctuiu2MGoLYeMSTKig()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AsblXD2YkaR9V6wocWa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type SDQOhM2HxKX1EURAvMB(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zWvbGx2xOuWiAwVp2oB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool brkwlI2mpeaPj102f58(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VL9xbk2QE95dT1DCNOd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataSerial;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FPI6RA2N9pcaSc5B5PR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteTcpIp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TGfPZ122ZxX1plbvlfE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}
}
