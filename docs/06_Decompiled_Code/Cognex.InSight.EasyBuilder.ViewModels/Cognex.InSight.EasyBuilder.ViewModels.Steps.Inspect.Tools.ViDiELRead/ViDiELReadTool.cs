using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Help;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.ViDiEL.ViewModels.Read;
using Cognex.Mvvm;
using Cognex.Ocr.Client;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELRead;

[Export(typeof(ViDiELReadTool))]
public class ViDiELReadTool : ViDiELEzToolBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ViDiELReadTool _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

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
			goto IL_0201;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0201;
			IL_0201:
			int num2 = default;
			ViDiELReadTool viDiELReadTool = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (Qj1bHAKEMmCOROgr77aF() ? 4 : 0);
					continue;
				case 1:
				case 4:
					viDiELReadTool = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							viDiELReadTool.UsePretrainedModel = null;
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
								awaiter = valueTask.GetAwaiter();
								num3 = 6;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 0:
							case 2:
								valueTask = viDiELReadTool.i76osxa51J();
								num3 = 10;
								if (d6c0WTKEYqZrwJJddNZo())
								{
								}
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 11;
							default:
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 9:
								viDiELReadTool.PretrainedModel = null;
								Qj1bHAKEMmCOROgr77aF();
								num3 = ((!d6c0WTKEYqZrwJJddNZo()) ? 5 : 0);
								continue;
							case 3:
								return;
							case 1:
							case 5:
								mNRRvcKEUOLTICof4NNX(viDiELReadTool.T07oYNJQOZ);
								goto case 0;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (Qj1bHAKEMmCOROgr77aF())
								{
									continue;
								}
								break;
							case 12:
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
					num = 3;
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
		internal static void mNRRvcKEUOLTICof4NNX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qj1bHAKEMmCOROgr77aF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d6c0WTKEYqZrwJJddNZo()
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
	private struct _003CWriteFixturedGraphics_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELReadTool _003C_003E4__this;

		private CvsEditableDisplayGraphic[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ViDiELReadTool viDiELReadTool = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			do
			{
				IL_030f:
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (LIaguIKENiR7kMQ3bAa3())
					{
						num = 4;
						goto IL_030f;
					}
					num = 0;
					if (LIaguIKENiR7kMQ3bAa3())
					{
						goto IL_030f;
					}
					goto case 0;
				case 1:
				case 4:
					viDiELReadTool = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 2;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 18;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 18:
								_003C_003Eu__2 = default;
								goto case 9;
							case 14:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								if (LIaguIKENiR7kMQ3bAa3())
								{
									continue;
								}
								goto case 4;
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								continue;
							case 2:
								_003C_003E7__wrap1 = viDiELReadTool.GetViewableEditGraphics();
								_ = 1;
								num3 = ((!mUyWI5KE2ij3gTcGxjJR()) ? 19 : 9);
								continue;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								continue;
							case 15:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 11;
								continue;
							case 11:
								return;
							case 13:
								_003C_003E7__wrap2++;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
							case 6:
								if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
								{
									CvsEditableDisplayGraphic cvsEditableDisplayGraphic = _003C_003E7__wrap1[_003C_003E7__wrap2];
									awaiter2 = oTS6UOKEuuZV3ZYGX5Qy(af95CTKE1speo18CPTjB(viDiELReadTool.InSight, YaUM4mKEcrH6xtIysA4T(cvsEditableDisplayGraphic), cvsEditableDisplayGraphic));
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								num3 = 5;
								continue;
							case 0:
								if (!awaiter2.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								goto IL_01ea;
							case 9:
							case 17:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								continue;
							case 1:
							case 19:
								_003C_003E7__wrap2 = 0;
								num3 = 6;
								continue;
							case 5:
								_003C_003E7__wrap1 = null;
								num3 = 7;
								continue;
							case 16:
								num2 = (_003C_003E1__state = -1);
								goto IL_01ea;
							default:
								num3 = 13;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 16;
								continue;
							case 7:
								awaiter = viDiELReadTool.InSight.CogSocket.Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (!mUyWI5KE2ij3gTcGxjJR())
									{
										continue;
									}
									return;
								}
								break;
							case 12:
								return;
							case 20:
								break;
								IL_01ea:
								awaiter2.GetResult();
								goto case 13;
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
					num = 3;
					if (mUyWI5KE2ij3gTcGxjJR())
					{
					}
					goto IL_030f;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (true);
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
		internal static CvsCellLocation YaUM4mKEcrH6xtIysA4T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object af95CTKE1speo18CPTjB(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter oTS6UOKEuuZV3ZYGX5Qy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LIaguIKENiR7kMQ3bAa3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mUyWI5KE2ij3gTcGxjJR()
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
	private struct _003CFocusOnPropertyChanged_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object sender;

		public PropertyChangedEventArgs e;

		public ViDiELReadTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RiGCsYKEhPO754pvFETA();
			int num;
			if (!gO1eCqKEtFXmwrXXst4n())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0056;
				}
			}
			goto IL_0272;
			IL_0028:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0272;
			IL_0069:
			int num2 = default;
			ViDiELReadTool viDiELReadTool = default;
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if (num2 == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 7;
					if (gO1eCqKEtFXmwrXXst4n())
					{
						goto IL_00bc;
					}
					goto IL_018a;
				}
				if (sender != null)
				{
					RiGCsYKEhPO754pvFETA();
					if (!gO1eCqKEtFXmwrXXst4n())
					{
						num3 = 4;
					}
					else
					{
						num3 = 1;
						if (1 == 0)
						{
							goto IL_0117;
						}
					}
					goto IL_018a;
				}
				goto end_IL_0069;
				IL_0117:
				if (ylyp6FKpKSpp8is3ExDA(mPq9kyKEzhdgCFjS2ul4(e), liPmynKpLbvdrMqKilMT(5436)))
				{
					num3 = 5;
					goto IL_018a;
				}
				goto end_IL_0069;
				IL_00bc:
				_003C_003Eu__1 = awaiter;
				num3 = 8;
				goto IL_018a;
				IL_018a:
				while (true)
				{
					switch (num3)
					{
					case 6:
						return;
					case 12:
						break;
					case 1:
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 12;
						continue;
					case 5:
					{
						EventHandler eventHandler = viDiELReadTool.Np0o0LvIk9;
						if (eventHandler == null)
						{
							num3 = 2;
							if (0 == 0)
							{
								continue;
							}
							goto case 9;
						}
						prVnG8Kp5Cx6mebWTIeG(eventHandler, sender, e);
						num3 = 13;
						if (gO1eCqKEtFXmwrXXst4n())
						{
						}
						continue;
					}
					case 9:
						if (!awaiter.IsCompleted)
						{
							goto case 1;
						}
						goto IL_01da;
					case 11:
						goto IL_0117;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 6;
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						goto IL_01da;
					case 10:
						goto end_IL_0069;
					case 0:
					case 4:
						do
						{
							if (e != null)
							{
								awaiter = viDiELReadTool.vfvoK8yLvw(sender, e).GetAwaiter();
								num3 = 9;
								continue;
							}
							num3 = 10;
							break;
						}
						while (!RiGCsYKEhPO754pvFETA());
						continue;
					case 2:
					case 13:
						{
							viDiELReadTool.Qa9oexdRbZ();
							goto end_IL_0069;
						}
						IL_01da:
						awaiter.GetResult();
						num3 = 11;
						if (!gO1eCqKEtFXmwrXXst4n())
						{
							continue;
						}
						goto end_IL_0069;
					}
					break;
				}
				goto IL_00bc;
				end_IL_0069:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0028;
			IL_0272:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto IL_0056;
				case 1:
				case 2:
					goto IL_0056;
				case 5:
					goto IL_0069;
				default:
					num = 4;
					if (RiGCsYKEhPO754pvFETA())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0028;
			IL_0056:
			viDiELReadTool = _003C_003E4__this;
			num = 5;
			if (1 == 0)
			{
				goto IL_0069;
			}
			goto IL_0272;
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
		internal static object mPq9kyKEzhdgCFjS2ul4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object liPmynKpLbvdrMqKilMT(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ylyp6FKpKSpp8is3ExDA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void prVnG8Kp5Cx6mebWTIeG(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RiGCsYKEhPO754pvFETA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gO1eCqKEtFXmwrXXst4n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IDisposable T07oYNJQOZ;

	[CompilerGenerated]
	private EventHandler Np0o0LvIk9;

	private bool DkioVaFjFs;

	private bool DwMoL21MM1;

	private CheckBoxViewModel xckoJcrFUO;

	private ListBoxViewModel mvCo9sZYaS;

	[CompilerGenerated]
	private EditRegionViewModel FMBorWOdo7;

	[CompilerGenerated]
	private StringViewModel fB9ohWD8IQ;

	[CompilerGenerated]
	private StringViewModel OMgo8Z95nf;

	[CompilerGenerated]
	private EditIntViewModel H6xomxGGK4;

	[CompilerGenerated]
	private EditStringViewModel XcNo1dEa62;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_ReadIcon;
		}
	}

	public override bool ShowHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DkioVaFjFs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref DkioVaFjFs, value, (string)nBkVXKrd4MUuBVNuYud(6502));
		}
	}

	public bool IsEditing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DwMoL21MM1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!sgiwVFrIrP277c0EltZ())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (false)
				{
					return;
				}
			}
			goto IL_0065;
			IL_0026:
			Qa9oexdRbZ();
			num = 5;
			goto IL_0065;
			IL_0065:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (DwMoL21MM1 != value)
					{
						goto IL_0042;
					}
					return;
				case 1:
					DwMoL21MM1 = value;
					break;
				case 5:
					return;
				}
				break;
				IL_0042:
				num = 1;
			}
			goto IL_0026;
		}
	}

	public bool IsV2ModelSelected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			string[] items = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (items != null)
					{
						goto case 4;
					}
					goto case 9;
				default:
					num = 4;
					if (esU6SZrOxCLKH4bUDP1())
					{
						break;
					}
					goto case 1;
				case 1:
				case 8:
					num2 = JSf84orAYTEW69LKOJq(PretrainedModel);
					num = 7;
					break;
				case 5:
					items = PretrainedModel.Items;
					_ = 0;
					if (esU6SZrOxCLKH4bUDP1())
					{
						num = 8;
						if (esU6SZrOxCLKH4bUDP1())
						{
							break;
						}
						goto case 2;
					}
					num = 3;
					break;
				case 2:
					if (num2 < items.Length)
					{
						goto case 3;
					}
					goto case 9;
				case 3:
				case 6:
					if (num2 != 1)
					{
						num = 9;
						break;
					}
					return true;
				case 4:
					if (num2 >= 0)
					{
						num = 2;
						break;
					}
					goto case 9;
				case 7:
					if (fOoc0krReaeKbDpsDk0(UsePretrainedModel))
					{
						num = 0;
						break;
					}
					goto case 9;
				case 9:
					return num2 == 2;
				}
			}
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
			StringViewModel readText = ReadText;
			return (string)(((readText != null) ? A0voE4rWU0JZhMc6ldu(readText) : null) ?? base.ResultString);
		}
	}

	public CheckBoxViewModel UsePretrainedModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xckoJcrFUO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (xckoJcrFUO == value)
					{
						num = 1;
						continue;
					}
					if (xckoJcrFUO != null)
					{
						_ = 1;
						if (!sgiwVFrIrP277c0EltZ())
						{
							num = 3;
							if (true)
							{
								continue;
							}
							goto case 6;
						}
						num = 5;
						continue;
					}
					goto case 0;
				case 8:
					Tcx7F2ryTAw5pZhcHbj(xckoJcrFUO, new PropertyChangedEventHandler(GGuo26vwfa));
					num = 6;
					continue;
				case 2:
				case 3:
					rL5MrXrT4vltHcirj7U(xckoJcrFUO, new PropertyChangedEventHandler(GGuo26vwfa));
					num = 0;
					continue;
				case 1:
					return;
				case 6:
					VCXncur0A8CyQ0lX5xm(xckoJcrFUO, true);
					num = 9;
					continue;
				case 0:
					xckoJcrFUO = value;
					break;
				case 9:
					return;
				}
				if (xckoJcrFUO != null)
				{
					num = 8;
					continue;
				}
				break;
			}
		}
	}

	public ListBoxViewModel PretrainedModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mvCo9sZYaS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 1:
					return;
				case 7:
					rL5MrXrT4vltHcirj7U(mvCo9sZYaS, new PropertyChangedEventHandler(obAoqlnVFu));
					num = 2;
					if (esU6SZrOxCLKH4bUDP1())
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					if (mvCo9sZYaS != null)
					{
						num = 8;
						if (sgiwVFrIrP277c0EltZ())
						{
						}
						break;
					}
					return;
				case 8:
					Tcx7F2ryTAw5pZhcHbj(mvCo9sZYaS, new PropertyChangedEventHandler(obAoqlnVFu));
					goto case 5;
				case 3:
					if (mvCo9sZYaS != value)
					{
						if (mvCo9sZYaS != null)
						{
							num = 7;
							break;
						}
						goto case 2;
					}
					num = 1;
					break;
				case 5:
				case 6:
					VCXncur0A8CyQ0lX5xm(mvCo9sZYaS, true);
					num = 9;
					break;
				case 2:
					mvCo9sZYaS = value;
					goto default;
				default:
					sgiwVFrIrP277c0EltZ();
					if (!esU6SZrOxCLKH4bUDP1())
					{
						num = 5;
						if (esU6SZrOxCLKH4bUDP1())
						{
							break;
						}
						goto case 3;
					}
					num = 0;
					if (sgiwVFrIrP277c0EltZ())
					{
						return;
					}
					break;
				case 9:
					return;
				}
			}
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
			return ReadText;
		}
	}

	public EditRegionViewModel SearchRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FMBorWOdo7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FMBorWOdo7 = value;
		}
	}

	public StringViewModel ReadText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fB9ohWD8IQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fB9ohWD8IQ = value;
		}
	}

	public StringViewModel FieldingPattern
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OMgo8Z95nf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OMgo8Z95nf = value;
		}
	}

	public EditIntViewModel CharacterFindThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return H6xomxGGK4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			H6xomxGGK4 = value;
		}
	}

	public EditStringViewModel FlexibleFielding
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XcNo1dEa62;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XcNo1dEa62 = value;
		}
	}

	public event EventHandler FocusChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					value2 = (EventHandler)sKqadZrDNlxxvoDRKfh(eventHandler2, value);
					goto case 5;
				default:
					num = 5;
					break;
				case 0:
					eventHandler = Np0o0LvIk9;
					sgiwVFrIrP277c0EltZ();
					if (esU6SZrOxCLKH4bUDP1())
					{
						num = 6;
						if (esU6SZrOxCLKH4bUDP1())
						{
							break;
						}
						goto case 5;
					}
					num = 4;
					break;
				case 5:
					eventHandler = Interlocked.CompareExchange(ref Np0o0LvIk9, value2, eventHandler2);
					num = 3;
					break;
				case 3:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					goto case 2;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sgiwVFrIrP277c0EltZ();
			int num = ((!esU6SZrOxCLKH4bUDP1()) ? 4 : 3);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					value2 = (EventHandler)CV2ZTsriEskAehEAajd(eventHandler2, value);
					goto case 5;
				default:
					num = 5;
					continue;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 5:
					eventHandler = Interlocked.CompareExchange(ref Np0o0LvIk9, value2, eventHandler2);
					num = 6;
					continue;
				case 0:
				case 3:
					eventHandler = Np0o0LvIk9;
					break;
				case 1:
				case 4:
					break;
				case 7:
					return;
				}
				eventHandler2 = eventHandler;
				num = 2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELReadTool(InspectStepViewModel inspect, bool isInitialized, SnippetLocalizer localizer = null)
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
			case 0:
			case 4:
				T07oYNJQOZ = OcrClient.State.StateChanged.Subscribe(junoiEZCas);
				num = 7;
				break;
			case 5:
				jqYBR6rn99v3MHcf8a6();
				num = 2;
				break;
			case 1:
			case 3:
				ViDiELEzToolBase.Log = LogManager.GetLogger<ViDiELReadTool>();
				goto case 0;
			case 2:
				DkioVaFjFs = true;
				num = 6;
				break;
			case 6:
				base._002Ector(inspect, isInitialized, localizer);
				goto default;
			default:
				_ = 0;
				if (!esU6SZrOxCLKH4bUDP1())
				{
					num = 0;
					if (!sgiwVFrIrP277c0EltZ())
					{
						break;
					}
					goto case 2;
				}
				num = 1;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__5))]
	public override ValueTask DisposeAsync()
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
		goto IL_004c;
		IL_0077:
		_003CDisposeAsync_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (!sgiwVFrIrP277c0EltZ())
		{
			goto IL_004c;
		}
		goto IL_0095;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 2:
			case 3:
				goto IL_0032;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_0077;
			case 0:
				goto IL_0095;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0095:
		stateMachine._003C_003Et__builder = FaCpEwrVtiH53sqLrq4();
		_ = 0;
		num = (esU6SZrOxCLKH4bUDP1() ? 4 : 3);
		goto IL_004c;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_0032;
		IL_0032:
		stateMachine._003C_003E1__state = -1;
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 22;
		if (!esU6SZrOxCLKH4bUDP1())
		{
			return;
		}
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				return;
			case 4:
				return;
			case 22:
				num2 = kSk6WHrfXLD2jwhbETS(relativeCellName);
				num = 14;
				break;
			case 21:
				if (num2 != 899010134)
				{
					num = 16;
					break;
				}
				if (xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6854)))
				{
					FlexibleFielding = new EditStringViewModel(InSight, cells, loc, (string)e6rwhTrPD8ZDs1KEr9S());
					AddProperty(FlexibleFielding);
					num = 28;
					if (0 == 0)
					{
						break;
					}
					return;
				}
				return;
			case 20:
				return;
			case 16:
				if (num2 == 1140402726 && xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6806)))
				{
					CharacterFindThreshold = new EditIntViewModel(InSight, cells, loc, (string)SfATx0rrGi4NDn80V6m());
					num = 26;
					break;
				}
				return;
			case 27:
				return;
			case 25:
				return;
			case 15:
				return;
			case 3:
				AddProperty(PretrainedModel);
				num = 1;
				break;
			case 19:
				return;
			case 1:
				return;
			case 2:
				return;
			case 26:
				AddProperty(CharacterFindThreshold);
				num = 19;
				break;
			case 24:
				if (num2 != 3770726449u)
				{
					return;
				}
				if (xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6650)))
				{
					SearchRegion = new EditRegionViewModel(InSight, cells, loc, Resources.SearchRegion, vg0fk0rgvRO0v395WHO(InputImage));
					num = 0;
					if (sgiwVFrIrP277c0EltZ())
					{
					}
				}
				else
				{
					num = 8;
				}
				break;
			case 9:
				AddProperty(UsePretrainedModel);
				num = 25;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				AddProperty(SearchRegion);
				return;
			case 12:
				AddProperty(FieldingPattern);
				num = 6;
				break;
			case 10:
				return;
			case 6:
				return;
			case 17:
			case 23:
				AddProperty(ReadText);
				return;
			case 14:
				if (num2 > 1815115965)
				{
					if (num2 > 2059818498)
					{
						if (num2 != 2927521861u)
						{
							num = 24;
							break;
						}
						if (xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6698)))
						{
							UsePretrainedModel = new CheckBoxViewModel(InSight, cells, loc, (string)lhQtELrvXqTuLsDnu80(), IsInitialized);
							num = 9;
							break;
						}
						num = 20;
						if (esU6SZrOxCLKH4bUDP1())
						{
							break;
						}
						return;
					}
					if (num2 != 1982454434)
					{
						_ = 1;
						if (!sgiwVFrIrP277c0EltZ())
						{
							num = 13;
							break;
						}
						num = 23;
						if (!sgiwVFrIrP277c0EltZ())
						{
							break;
						}
						goto case 12;
					}
					if (!(relativeCellName == (string)nBkVXKrd4MUuBVNuYud(6626)))
					{
						num = 15;
						break;
					}
					ELFunctionCellLocation = loc;
					num = 4;
					break;
				}
				if (num2 > 1140402726)
				{
					switch (num2)
					{
					case 1744355390u:
						break;
					default:
						num = 2;
						goto end_IL_039d;
					case 1815115965u:
						if (xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6772)))
						{
							FieldingPattern = new StringViewModel(InSight, cells, loc, Resources.FieldingPattern);
							num = 12;
						}
						else
						{
							num = 18;
						}
						goto end_IL_039d;
					}
					if (!xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6678)))
					{
						num = 11;
						break;
					}
					ReadText = new StringViewModel(InSight, cells, loc, (string)HdC2TMrsRXS5ScbylVv());
					goto case 17;
				}
				num = 21;
				if (!esU6SZrOxCLKH4bUDP1())
				{
					return;
				}
				break;
			case 7:
				return;
			case 11:
				return;
			case 18:
				return;
			default:
				num = 7;
				break;
			case 5:
			case 13:
				if (num2 == 2059818498)
				{
					if (!xlSgDUrlfV7WAKixoEd(relativeCellName, nBkVXKrd4MUuBVNuYud(6738)))
					{
						num = 10;
						break;
					}
					PretrainedModel = new ListBoxViewModel(InSight, cells, loc, Resources.UsePretrainedModel);
					num = 3;
				}
				else
				{
					num = 27;
				}
				break;
			case 28:
				return;
				end_IL_039d:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitializeAdditionalHelp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AdditionalHelpText = new List<ExtraHelpText>
		{
			new ExtraHelpText((string)Tf8Jo3rZaHHJjOTAQhZ(), DisplayHelpTextType.Header),
			new ExtraHelpText(Resources.ybG8KQe6IA(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)mBlZAWrBMUJUd42DYjK(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)BKhugfrbLFso5lkDbR2(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)ajXqeHrGcZ0di8rGow7(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)Tc5fxvro8pcNhA5YxM3(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)q2LhnwrS2skioybXIRx(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)s3UeWurkiyC35YJLCgp(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)Ig4yQTr8XGkHpmTJL2J(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)BRGudWrqOZPEUeibiar(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)zHPCddrE9n7VGUDB2GG(), DisplayHelpTextType.Header),
			new ExtraHelpText(Resources.FER8HdrbbD(), DisplayHelpTextType.Paragraph)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[1] { SearchRegion?.Graphic }.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g != null;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__11))]
	internal override Task WriteFixturedGraphics()
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
		goto IL_004a;
		IL_001a:
		_003CWriteFixturedGraphics_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = qpr66trpoXcOWNta3BR();
		num = 5;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (sgiwVFrIrP277c0EltZ())
				{
					num = 4;
					continue;
				}
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFocusOnPropertyChanged_003Ed__12))]
	protected override Task FocusOnPropertyChanged(object sender, PropertyChangedEventArgs e)
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
		goto IL_004e;
		IL_00af:
		_003CFocusOnPropertyChanged_003Ed__12 stateMachine = default;
		stateMachine.sender = sender;
		num = 3;
		goto IL_004e;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 3:
				goto IL_0034;
			default:
				goto IL_0077;
			case 0:
				goto IL_0093;
			case 7:
				goto IL_00af;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (esU6SZrOxCLKH4bUDP1())
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0093:
		stateMachine._003C_003Et__builder = qpr66trpoXcOWNta3BR();
		num = 6;
		if (!sgiwVFrIrP277c0EltZ())
		{
			goto IL_004e;
		}
		goto IL_00af;
		IL_001a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 8;
		if (1 == 0)
		{
			goto IL_0034;
		}
		goto IL_004e;
		IL_0034:
		stateMachine.e = e;
		goto IL_0077;
		IL_0077:
		_ = 1;
		if (!sgiwVFrIrP277c0EltZ())
		{
			num = 2;
			if (!esU6SZrOxCLKH4bUDP1())
			{
				goto IL_0093;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_004e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Qa9oexdRbZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		esU6SZrOxCLKH4bUDP1();
		int num = (sgiwVFrIrP277c0EltZ() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				if (!IsEditing)
				{
					break;
				}
				num = 3;
				if (esU6SZrOxCLKH4bUDP1())
				{
					continue;
				}
				goto case 3;
			case 3:
				MainViewModel = this;
				return;
			default:
				num = 5;
				continue;
			case 5:
				return;
			case 0:
			case 4:
				if (!vOocGxrXY1EhsweLAjM(Focus))
				{
					break;
				}
				goto case 1;
			case 6:
				return;
			}
			MainViewModel = null;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GGuo26vwfa(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		esU6SZrOxCLKH4bUDP1();
		int num;
		if (!sgiwVFrIrP277c0EltZ())
		{
			num = 3;
			if (!esU6SZrOxCLKH4bUDP1())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_008a;
		IL_002e:
		FirePropertyChanged((string)nBkVXKrd4MUuBVNuYud(6890));
		num = 5;
		goto IL_008a;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				ek3oP0lMT1();
				goto case 1;
			case 1:
			case 2:
				if (xlSgDUrlfV7WAKixoEd(eL4eLdr9GImm3H2t8fw(P_1), nBkVXKrd4MUuBVNuYud(5436)))
				{
					break;
				}
				return;
			default:
				goto IL_00a7;
			case 5:
				return;
			}
			break;
			IL_00a7:
			num = 4;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void obAoqlnVFu(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (xlSgDUrlfV7WAKixoEd(eL4eLdr9GImm3H2t8fw(P_1), nBkVXKrd4MUuBVNuYud(5436)))
		{
			RQyqmkr40nhYF1lI6J6(this, nBkVXKrd4MUuBVNuYud(6890));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void junoiEZCas(StateChangedArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		esU6SZrOxCLKH4bUDP1();
		int num = (sgiwVFrIrP277c0EltZ() ? 1 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
				if ((string)Ftl0Elr764FnZROx8oo(P_0) == ToolId)
				{
					num = 4;
					break;
				}
				return;
			case 4:
				IsEditing = SELIlsr3cSrXZbyhyy7(P_0) != States.None;
				goto default;
			default:
				ek3oP0lMT1();
				num = 6;
				break;
			case 0:
			case 5:
				if (P_0 != null)
				{
					num = 2;
					break;
				}
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cXvokOkxZv(FlexibleFieldingEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FlexibleFielding.Value = (string)FIsU4ZrjutOIeFBWb79(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ek3oP0lMT1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			return;
		}
		States valueOrDefault = default;
		States? state = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 1:
				if (UsePretrainedModel.Value)
				{
					num = 7;
					break;
				}
				return;
			case 3:
			case 6:
				valueOrDefault = state.GetValueOrDefault();
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				switch (valueOrDefault)
				{
				case States.Training:
				case States.EditLabels:
				case States.EditSamples:
					break;
				default:
					num = 0;
					goto end_IL_006d;
				case States.EditCharacterSize:
				case States.EditFielding:
					return;
				}
				IKrPjqrCESB7a6RbOVQ(ciXReqr6FWNOd87CBFX(), ToolId, NavigationAction.Reset);
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 4:
				RQyqmkr40nhYF1lI6J6(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6890));
				num = 9;
				break;
			case 7:
				state = ((State)ciXReqr6FWNOd87CBFX()).GetState(ToolId);
				_ = 0;
				num = ((!esU6SZrOxCLKH4bUDP1()) ? 6 : 8);
				break;
			case 2:
			case 8:
				if (state.HasValue)
				{
					goto case 3;
				}
				return;
			case 9:
				return;
				end_IL_006d:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask i76osxa51J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task vfvoK8yLvw(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.FocusOnPropertyChanged(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sKqadZrDNlxxvoDRKfh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool esU6SZrOxCLKH4bUDP1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sgiwVFrIrP277c0EltZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CV2ZTsriEskAehEAajd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jqYBR6rn99v3MHcf8a6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder FaCpEwrVtiH53sqLrq4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint kSk6WHrfXLD2jwhbETS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nBkVXKrd4MUuBVNuYud(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xlSgDUrlfV7WAKixoEd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation vg0fk0rgvRO0v395WHO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HdC2TMrsRXS5ScbylVv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ResultString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lhQtELrvXqTuLsDnu80()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UsePretrainedModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SfATx0rrGi4NDn80V6m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CharacterFindThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e6rwhTrPD8ZDs1KEr9S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FlexibleFielding;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tf8Jo3rZaHHJjOTAQhZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.m0o8BU1C7w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mBlZAWrBMUJUd42DYjK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bRF8YZbhLl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BKhugfrbLFso5lkDbR2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.sG48nVYMMj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ajXqeHrGcZ0di8rGow7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cg48CryUF2();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tc5fxvro8pcNhA5YxM3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UH78WPXnjS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q2LhnwrS2skioybXIRx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.L4h82Aqjsl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s3UeWurkiyC35YJLCgp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PT88vfqT86();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ig4yQTr8XGkHpmTJL2J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.C2f8Ps6fNR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BRGudWrqOZPEUeibiar()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.zPp8iVbeYs();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zHPCddrE9n7VGUDB2GG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qa98yg9Brj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder qpr66trpoXcOWNta3BR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vOocGxrXY1EhsweLAjM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InternalCheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eL4eLdr9GImm3H2t8fw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RQyqmkr40nhYF1lI6J6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ftl0Elr764FnZROx8oo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static States SELIlsr3cSrXZbyhyy7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FIsU4ZrjutOIeFBWb79(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FlexibleFieldingEventArgs)P_0).FlexibleFieldingValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ciXReqr6FWNOd87CBFX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OcrClient.State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IKrPjqrCESB7a6RbOVQ(object P_0, object P_1, NavigationAction P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((State)P_0).ExecuteNavigationAction((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JSf84orAYTEW69LKOJq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ListBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fOoc0krReaeKbDpsDk0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A0voE4rWU0JZhMc6ldu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DisplayValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rL5MrXrT4vltHcirj7U(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tcx7F2ryTAw5pZhcHbj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VCXncur0A8CyQ0lX5xm(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}
}
