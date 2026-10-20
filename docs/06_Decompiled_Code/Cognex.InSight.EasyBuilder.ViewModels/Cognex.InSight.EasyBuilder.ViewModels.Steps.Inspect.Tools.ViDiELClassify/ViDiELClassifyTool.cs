using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.ViDiEL.ViewModels;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using Cognex.Mvvm;
using Cognex.ServiceLocator;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELClassify;

[Export(typeof(ViDiELClassifyTool))]
public class ViDiELClassifyTool : ViDiELEzToolBase
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__0_0;

		public static Func<bool> _003C_003E9__0_1;

		public static Func<ClassViewModel, bool> _003C_003E9__45_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cihseWKXLCf8OZyoHAt2();
			NTrbssKXKBZuWc669IbR(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__0_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_HasLabeledImages_003Eb__45_0(ClassViewModel cls)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DrWduFKXwktMZ7tLmE27(g4ZTJAKX5R9u5iF8bDTC(cls)) > 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xq0stHKpt8G4tTDmUQmk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vZxXyCKpzgeAl8BwLoW7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cihseWKXLCf8OZyoHAt2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NTrbssKXKBZuWc669IbR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g4ZTJAKX5R9u5iF8bDTC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).LabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int DrWduFKXwktMZ7tLmE27(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ImageListViewModel)P_0).Count;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyTool _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DuJPrMKXJK9rLWliXGJc();
			int num;
			if (!AiVxISKXaSvIIeZe2BCe())
			{
				num = 3;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_01b5;
			IL_01b5:
			ViDiELClassifyTool viDiELClassifyTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					viDiELClassifyTool = _003C_003E4__this;
					goto case 1;
				case 0:
				case 3:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 2:
					try
					{
						ValueTaskAwaiter awaiter;
						if (num2 != 0)
						{
							IEnumerator<ClassViewModel> enumerator = viDiELClassifyTool.SXjDdg5BGt.Classes.GetEnumerator();
							try
							{
								while (XDaOVfKXeNXtOYQM9bC1(enumerator))
								{
									enumerator.Current.CancelRename();
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									zYC7OSKXO5O9RJg6nHpj(enumerator);
								}
							}
							BK3MDTKXIc6UlQUBI6LZ(viDiELClassifyTool.SXjDdg5BGt);
							viDiELClassifyTool.SnippetName.PropertyChanged -= viDiELClassifyTool.t6GSeYYgnY;
							if (viDiELClassifyTool.RuntimeService != null)
							{
								viDiELClassifyTool.RuntimeService.IsRepeatingTriggerActiveChanged -= viDiELClassifyTool.do5S2X4OmG;
							}
							if (viDiELClassifyTool.RuntimeModeService != null)
							{
								viDiELClassifyTool.RuntimeModeService.RuntimeModeChanged -= viDiELClassifyTool.G1JSqPXF1u;
							}
							awaiter = viDiELClassifyTool.p2HSnGP8Jn().GetAwaiter();
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
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					if (AiVxISKXaSvIIeZe2BCe())
					{
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_01b5;
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
		internal static bool XDaOVfKXeNXtOYQM9bC1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zYC7OSKXO5O9RJg6nHpj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BK3MDTKXIc6UlQUBI6LZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Classifier)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DuJPrMKXJK9rLWliXGJc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AiVxISKXaSvIIeZe2BCe()
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
	private struct _003CInternalPostParse_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyTool _003C_003E4__this;

		public CvsCellCollection cells;

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
			if (!SCc6VAKXin8BEbxY2lFd())
			{
				num = 3;
				if (!qV6s5NKXDIa3COj9990t())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_0211;
			IL_0041:
			ViDiELClassifyTool viDiELClassifyTool = _003C_003E4__this;
			num = 4;
			goto IL_0211;
			IL_0211:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_0041;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (viDiELClassifyTool.SpreadsheetTool == null)
							{
								goto IL_00a0;
							}
							num3 = 6;
							if (false)
							{
								goto IL_0084;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (!qV6s5NKXDIa3COj9990t())
							{
								goto IL_01b1;
							}
						}
						goto IL_00e2;
						IL_01d1:
						awaiter.GetResult();
						goto end_IL_0067;
						IL_00a0:
						TikAlmKXfFJJsvmy4iEK(viDiELClassifyTool.SnippetName, new PropertyChangedEventHandler(viDiELClassifyTool.t6GSeYYgnY));
						goto IL_0084;
						IL_01b1:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							if (SCc6VAKXin8BEbxY2lFd())
							{
							}
							goto IL_00e2;
						}
						goto IL_01d1;
						IL_0084:
						awaiter = br0VFfKXdgdgVOYtd1Q0(viDiELClassifyTool.pF1StDwH2Q(cells));
						num3 = 5;
						goto IL_00e2;
						IL_00e2:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 9:
								break;
							case 1:
							case 3:
								goto IL_00a0;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 6:
								goto IL_0158;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 0:
								return;
							case 5:
								goto IL_01b1;
							case 11:
								goto IL_01d1;
							}
							break;
							IL_0158:
							IVeZDoKXV4Jmd0pkQEHj(viDiELClassifyTool.SpreadsheetTool, YnJTEWKXn0rn0svqFeUx(viDiELClassifyTool.SnippetName));
							_ = 1;
							num3 = ((!SCc6VAKXin8BEbxY2lFd()) ? 3 : 9);
						}
						goto IL_0084;
						end_IL_0067:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0041;
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
		internal static object YnJTEWKXn0rn0svqFeUx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetNameViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IVeZDoKXV4Jmd0pkQEHj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Classifier)P_0).UpdateToolName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TikAlmKXfFJJsvmy4iEK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter br0VFfKXdgdgVOYtd1Q0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qV6s5NKXDIa3COj9990t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SCc6VAKXin8BEbxY2lFd()
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
	private struct _003C_spreadsheetTool_PropertyChanged_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public ViDiELClassifyTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0374;
			IL_03b6:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_0374;
			IL_0374:
			ViDiELClassifyTool viDiELClassifyTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 2:
				case 4:
					goto IL_003d;
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					viDiELClassifyTool = _003C_003E4__this;
					goto IL_003d;
				case 3:
					goto IL_03b6;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_003d:
			int num2 = default;
			try
			{
				_ = 1;
				try
				{
					int num3;
					TaskAwaiter awaiter = default;
					if (num2 != 0)
					{
						if (num2 != 1)
						{
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_0168;
					}
					awaiter = _003C_003Eu__1;
					goto IL_00ff;
					IL_011b:
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 1);
						num3 = 19;
						goto IL_0168;
					}
					goto IL_0312;
					IL_0168:
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (!awaiter.IsCompleted)
							{
								num3 = 0;
								continue;
							}
							goto case 11;
						case 18:
							break;
						case 2:
							goto IL_00ba;
						case 12:
							viDiELClassifyTool.IsEditingClasses = fKV9oTKXbbFDFyKM8D7j(viDiELClassifyTool.SpreadsheetTool);
							num3 = 18;
							continue;
						case 10:
							goto IL_00ff;
						case 14:
						case 15:
							goto IL_011b;
						case 1:
							viDiELClassifyTool.wQpSBiM8gn();
							num3 = 5;
							continue;
						case 6:
							return;
						default:
							num3 = 10;
							continue;
						case 5:
							awaiter = NcDnjfKXBjd9RXE7pIk4(AwJWnXKXZLpNQd2M1Lwc(viDiELClassifyTool.SpreadsheetTool));
							num3 = 3;
							continue;
						case 0:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							num3 = 7;
							if (yNIpA1KXgn8MGeH4PamX())
							{
							}
							continue;
						case 16:
							break;
						case 13:
							num2 = (_003C_003E1__state = -1);
							num3 = 11;
							continue;
						case 9:
						case 17:
							num2 = (_003C_003E1__state = -1);
							num3 = 20;
							continue;
						case 8:
							MSvghtKXPyVgahrH1WKe(viDiELClassifyTool, Ni6WiCKXvNV3IAn2xmeX(49196));
							num3 = 16;
							continue;
						case 4:
							_003C_003Eu__1 = default;
							goto case 9;
						case 19:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 11:
							awaiter.GetResult();
							break;
						case 7:
							goto IL_02f8;
						case 20:
							goto IL_0312;
						}
						break;
						IL_00ba:
						if (pUDQvMKXrbdke81J6Q6j(dTHprtKXsxqv8QLNL0EC(e), Ni6WiCKXvNV3IAn2xmeX(49178), StringComparison.Ordinal))
						{
							num3 = 8;
							continue;
						}
						if (pUDQvMKXrbdke81J6Q6j(dTHprtKXsxqv8QLNL0EC(e), Ni6WiCKXvNV3IAn2xmeX(49220), StringComparison.Ordinal))
						{
							num3 = 1;
							continue;
						}
						if (!e.PropertyName.Equals((string)Ni6WiCKXvNV3IAn2xmeX(8004), StringComparison.Ordinal))
						{
							if (((string)dTHprtKXsxqv8QLNL0EC(e)).Equals((string)Ni6WiCKXvNV3IAn2xmeX(6478), StringComparison.Ordinal))
							{
								awaiter = viDiELClassifyTool.jDUSGq1Qpb().GetAwaiter();
								sMQiojKXlWunSx5uDqMh();
								num3 = (yNIpA1KXgn8MGeH4PamX() ? 9 : 15);
								continue;
							}
							break;
						}
						num3 = 12;
						if (true)
						{
							continue;
						}
						goto IL_02f8;
						IL_02f8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 6;
						if (true)
						{
							continue;
						}
						goto IL_0312;
					}
					goto end_IL_0042;
					IL_0312:
					awaiter.GetResult();
					goto end_IL_0042;
					IL_00ff:
					_003C_003Eu__1 = default;
					num3 = 13;
					if (!sMQiojKXlWunSx5uDqMh())
					{
						goto IL_011b;
					}
					goto IL_0168;
					end_IL_0042:;
				}
				catch (Exception exception)
				{
					ViDiELEzToolBase.Log.ErrorException((string)Ni6WiCKXvNV3IAn2xmeX(49250), exception);
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_03b6;
			IL_001a:
			num2 = _003C_003E1__state;
			_ = 1;
			if (!yNIpA1KXgn8MGeH4PamX())
			{
				num = 0;
				if (!sMQiojKXlWunSx5uDqMh())
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0374;
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
		internal static object dTHprtKXsxqv8QLNL0EC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ni6WiCKXvNV3IAn2xmeX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pUDQvMKXrbdke81J6Q6j(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MSvghtKXPyVgahrH1WKe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AwJWnXKXZLpNQd2M1Lwc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RefreshModelHealth();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NcDnjfKXBjd9RXE7pIk4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fKV9oTKXbbFDFyKM8D7j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).IsEditingClasses;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sMQiojKXlWunSx5uDqMh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yNIpA1KXgn8MGeH4PamX()
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
	private struct _003CUnlabeledImageCount_PropertyChanged_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PropertyChangedEventArgs e;

		public ViDiELClassifyTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kqG9p7KXog3dMERNcFDp();
			int num = ((!BpES6gKXGKZZadDg5ruT()) ? 4 : 5);
			ViDiELClassifyTool viDiELClassifyTool = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					viDiELClassifyTool = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
							goto IL_008e;
						}
						if (Ag6FD2KXkhkFx2xOPxHP(e.PropertyName, zFaQ4bKXSK0X5etmTdIS(27684), StringComparison.Ordinal))
						{
							_ = 0;
							num3 = ((!BpES6gKXGKZZadDg5ruT()) ? 6 : 3);
							goto IL_008e;
						}
						goto end_IL_0039;
						IL_008e:
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 3:
								awaiter = TaIGK3KXqu9wUNX5Lrs7(VQKk7PKX88w2Z1GHGkI3(viDiELClassifyTool.SpreadsheetTool));
								goto case 1;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (kqG9p7KXog3dMERNcFDp())
								{
								}
								continue;
							case 1:
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								return;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0039:;
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
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				case 2:
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
		internal static object zFaQ4bKXSK0X5etmTdIS(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ag6FD2KXkhkFx2xOPxHP(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VQKk7PKX88w2Z1GHGkI3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RefreshUnlabeledImages();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TaIGK3KXqu9wUNX5Lrs7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BpES6gKXGKZZadDg5ruT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kqG9p7KXog3dMERNcFDp()
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
	private struct _003CShiftEditGraphics_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			ViDiELClassifyTool viDiELClassifyTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					viDiELClassifyTool = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					sQIh3XKXpK2jQg5UOrIR();
					if (!q48n7oKXE2hhh46VkS9W())
					{
						num = 3;
						break;
					}
					num = 0;
					if (q48n7oKXE2hhh46VkS9W())
					{
						break;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (q48n7oKXE2hhh46VkS9W())
					{
						break;
					}
					goto case 2;
				case 2:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = I4MMDrKX9oTyTNwEG0Lx(DwDZTCKXXXdaGROubPyi(viDiELClassifyTool.Region, delta));
							num3 = 2;
							goto IL_00d5;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0099;
						IL_0099:
						_003C_003Eu__1 = default;
						num3 = 6;
						if (sQIh3XKXpK2jQg5UOrIR())
						{
							goto IL_00b5;
						}
						goto IL_00d5;
						IL_014d:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						goto IL_00d5;
						IL_00d5:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 5:
								break;
							case 0:
								goto IL_00b5;
							default:
								goto IL_0102;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 4:
							case 8:
								return;
							case 7:
								goto IL_014d;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									if (!sQIh3XKXpK2jQg5UOrIR())
									{
										continue;
									}
									goto case 6;
								}
								goto case 9;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0071;
							}
							break;
						}
						goto IL_0099;
						IL_0102:
						sQIh3XKXpK2jQg5UOrIR();
						if (q48n7oKXE2hhh46VkS9W())
						{
							num3 = 8;
						}
						else
						{
							num3 = 3;
							if (false)
							{
								goto IL_014d;
							}
						}
						goto IL_00d5;
						IL_00b5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_0102;
						end_IL_0071:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					if (false)
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
		internal static object DwDZTCKXXXdaGROubPyi(object P_0, float delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Shift(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter I4MMDrKX9oTyTNwEG0Lx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q48n7oKXE2hhh46VkS9W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sQIh3XKXpK2jQg5UOrIR()
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
	private struct _003CWriteFixturedGraphics_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rLUAHgKX7m3xvxdn9Sdu();
			int num = ((!ElZhCSKX4yHrBJVslT9k()) ? 5 : 2);
			ViDiELClassifyTool viDiELClassifyTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					viDiELClassifyTool = _003C_003E4__this;
					num = 3;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_007c;
							}
							num3 = 8;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
						}
						goto IL_018e;
						IL_018e:
						while (true)
						{
							switch (num3)
							{
							case 12:
							case 14:
								break;
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 11;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								ElZhCSKX4yHrBJVslT9k();
								num3 = ((!rLUAHgKX7m3xvxdn9Sdu()) ? 1 : 14);
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 8:
								awaiter2 = zItNxoKX6POgOI4U17Yl(EditableGraphicHelper.SendGraphicAsync(viDiELClassifyTool.InSight, yCTSJ7KX3KuePdheAtuA(viDiELClassifyTool.Region), (CvsEditableDisplayGraphic)gcNTbaKXjo5K4DvK3Mx3(viDiELClassifyTool.Region)));
								num3 = 6;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 2;
								continue;
							case 10:
								awaiter = ((CvsCogSocketSheet)lnJfNLKXA5fQlnalTRm7(IrI7JDKXCZNIWEaFEDGd(viDiELClassifyTool.InSight))).RunAsync(false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 16;
							case 6:
								if (!awaiter2.IsCompleted)
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								}
								goto IL_0175;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto IL_0175;
							default:
								num3 = 10;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 2:
								return;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 7:
								return;
							case 1:
							case 3:
								_003C_003Eu__1 = awaiter2;
								num3 = 9;
								continue;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_018e;
								}
								IL_0175:
								awaiter2.GetResult();
								goto case 10;
							}
							goto IL_007c;
							continue;
							end_IL_018e:
							break;
						}
						goto end_IL_0065;
						IL_007c:
						_003C_003Eu__2 = default;
						num3 = 5;
						goto IL_018e;
						end_IL_0065:;
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
		internal static CvsCellLocation yCTSJ7KX3KuePdheAtuA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gcNTbaKXjo5K4DvK3Mx3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter zItNxoKX6POgOI4U17Yl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IrI7JDKXCZNIWEaFEDGd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lnJfNLKXA5fQlnalTRm7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ElZhCSKX4yHrBJVslT9k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rLUAHgKX7m3xvxdn9Sdu()
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
	private struct _003CRefreshROIEditability_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELClassifyTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mGRWn1KXWuydrZb9QQ4T();
			int num = ((!p01KW0KXRGgPGCEidkUa()) ? 4 : 2);
			int num2 = default;
			ViDiELClassifyTool viDiELClassifyTool = default;
			TaskAwaiter awaiter = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					viDiELClassifyTool = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (viDiELClassifyTool.HasSamples)
							{
								num3 = 1;
							}
							else
							{
								object obj = fvexoWKXTdcBQ2QDbhi9(viDiELClassifyTool.Region);
								((CvsEditableDisplayGraphic)obj).EditFlags = apge5PKXyc5RppVD1ZF1(obj) | CvsEditFlags.Size;
								num3 = 12;
							}
							goto IL_0158;
						}
						awaiter = _003C_003Eu__1;
						goto IL_01db;
						IL_0158:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 7:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								mGRWn1KXWuydrZb9QQ4T();
								num3 = ((!p01KW0KXRGgPGCEidkUa()) ? 8 : 5);
								continue;
							case 10:
								return;
							case 1:
							{
								object obj2 = fvexoWKXTdcBQ2QDbhi9(viDiELClassifyTool.Region);
								((CvsEditableDisplayGraphic)obj2).EditFlags = apge5PKXyc5RppVD1ZF1(obj2) & ~CvsEditFlags.Size;
								goto case 12;
							}
							case 2:
								awaiter = ygtmuxKX0VCjX8yg45BN(viDiELClassifyTool.EnableRegionEdit.WriteImmediateAsync(flag));
								num3 = 6;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									goto case 11;
								}
								goto case 13;
							default:
								num3 = 11;
								continue;
							case 12:
								flag = !viDiELClassifyTool.HasSamples;
								num3 = 4;
								continue;
							case 4:
								if (viDiELClassifyTool.EnableRegionEdit != null)
								{
									num3 = 0;
									continue;
								}
								goto end_IL_0158;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 8:
							case 9:
								break;
							case 0:
								if (viDiELClassifyTool.EnableRegionEdit.Value != flag)
								{
									num3 = 2;
									continue;
								}
								goto end_IL_0158;
							case 13:
								awaiter.GetResult();
								goto end_IL_0158;
							}
							goto IL_01db;
							continue;
							end_IL_0158:
							break;
						}
						goto end_IL_0065;
						IL_01db:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_0158;
						end_IL_0065:;
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
		internal static object fvexoWKXTdcBQ2QDbhi9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsEditFlags apge5PKXyc5RppVD1ZF1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).EditFlags;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ygtmuxKX0VCjX8yg45BN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p01KW0KXRGgPGCEidkUa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mGRWn1KXWuydrZb9QQ4T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EditRegionViewModel C7QD5YwXJH;

	[CompilerGenerated]
	private EditIntViewModel c3aDpLkr1u;

	[CompilerGenerated]
	private CheckBoxViewModel K6RDUL6NP4;

	[CompilerGenerated]
	private CheckBoxViewModel QyaD736dMl;

	[CompilerGenerated]
	private CheckBoxViewModel iRXDNQoE1q;

	[CompilerGenerated]
	private bool FySDAY8G1h;

	private Classifier SXjDdg5BGt;

	private StringViewModel qDYD6XqP0g;

	private FloatViewModel KTyDuEFFZi;

	private BoolViewModel fL3DFgPseR;

	private FloatViewModel zimDXldjgw;

	[CompilerGenerated]
	private FloatViewModel aiODoUivcK;

	[CompilerGenerated]
	private readonly DelegateCommand RM0DSwLbRH;

	[CompilerGenerated]
	private readonly DelegateCommand XqYDDma8qh;

	private bool pcKD3FslhT;

	public bool CanEditClassifyTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (LmCoEmPhiPMqmJ1X0Ho() ? 4 : 2);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (R0D3FTZolkt2iuWDFgU(RuntimeModeService))
					{
						num = 5;
						continue;
					}
					break;
				case 1:
				case 4:
					if (RuntimeService == null)
					{
						break;
					}
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 2:
					if (RuntimeModeService == null)
					{
						break;
					}
					goto case 1;
				case 5:
					return !IXuwg6ZS6v2dFf6BnRm(RuntimeService);
				}
				break;
			}
			return false;
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
			return C7QD5YwXJH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C7QD5YwXJH = value;
		}
	}

	public EditIntViewModel ClassificationConfidence
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c3aDpLkr1u;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c3aDpLkr1u = value;
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
			_ = 0;
			int num = ((!T1aSvZPulNZjcGWcuSM()) ? 4 : 3);
			object obj;
			while (true)
			{
				switch (num)
				{
				case 1:
				{
					StringViewModel predictedClassString = PredictedClassString;
					if (predictedClassString == null)
					{
						goto default;
					}
					obj = predictedClassString.DisplayValue;
					goto IL_008b;
				}
				default:
					obj = null;
					goto IL_008b;
				case 0:
				case 3:
				{
					BoolViewModel isSampleUnclassified = IsSampleUnclassified;
					if (isSampleUnclassified != null)
					{
						if (isSampleUnclassified.Value)
						{
							obj = jDQ5HjZkM2Vetr94yEs();
							break;
						}
						goto case 1;
					}
					num = 1;
					continue;
				}
				case 5:
					{
						return base.ResultString;
					}
					IL_008b:
					if (obj == null)
					{
						num = 5;
						continue;
					}
					break;
				}
				break;
			}
			return (string)obj;
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
			return PredictedClassString;
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
			return XAMLGraphicKeys.Tools_ClassifyIcon;
		}
	}

	public CheckBoxViewModel SampleCollectionMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K6RDUL6NP4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K6RDUL6NP4 = value;
		}
	}

	public CheckBoxViewModel UnclassifiedDetectionMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QyaD736dMl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QyaD736dMl = value;
		}
	}

	public CheckBoxViewModel EnableRegionEdit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iRXDNQoE1q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iRXDNQoE1q = value;
		}
	}

	public bool IsMoreImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FySDAY8G1h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FySDAY8G1h = value;
		}
	}

	public IEnumerable<ClassViewModel> Classes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SpreadsheetTool.Classes;
		}
	}

	public bool HasClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Classifier sXjDdg5BGt = SXjDdg5BGt;
			return ((sXjDdg5BGt != null && Vu3WcpZ8jJDthp4OIxJ(sXjDdg5BGt.Classes) != 0) ? 1 : 0) > (false ? 1 : 0);
		}
	}

	public bool HasLabeledImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SXjDdg5BGt?.Classes.Any([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel cls) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.DrWduFKXwktMZ7tLmE27(_003C_003Ec.g4ZTJAKX5R9u5iF8bDTC(cls)) > 0;
			}) ?? false;
		}
	}

	public bool HasSamples
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Classifier sXjDdg5BGt = SXjDdg5BGt;
			if (sXjDdg5BGt == null)
			{
				return false;
			}
			return u8okrGZq6CPjU1LI0Iv(sXjDdg5BGt);
		}
	}

	public Classifier SpreadsheetTool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SXjDdg5BGt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (SXjDdg5BGt != null)
					{
						num = 6;
						break;
					}
					return;
				case 6:
					ETCYQ2ZIopN320IdKCh(SXjDdg5BGt, new PropertyChangedEventHandler(zZnSi3XPOR));
					num = 5;
					break;
				case 0:
				case 3:
					SXjDdg5BGt = value;
					goto case 7;
				default:
					num = 7;
					break;
				case 4:
					if (SXjDdg5BGt != null)
					{
						T1aSvZPulNZjcGWcuSM();
						num = ((!LmCoEmPhiPMqmJ1X0Ho()) ? 8 : 0);
						break;
					}
					goto case 0;
				case 1:
					if (SXjDdg5BGt != value)
					{
						num = 4;
						break;
					}
					return;
				case 5:
					bhOSZbeZ1H();
					num = 9;
					break;
				case 2:
				case 8:
					rTaI3QZEcZXRZoilBTc(SXjDdg5BGt, new PropertyChangedEventHandler(zZnSi3XPOR));
					goto case 0;
				case 9:
					return;
				}
			}
		}
	}

	public StringViewModel PredictedClassString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qDYD6XqP0g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
				case 2:
				case 5:
					rTaI3QZEcZXRZoilBTc(qDYD6XqP0g, new PropertyChangedEventHandler(DA4SPWmWC2));
					goto case 0;
				case 0:
				case 3:
					qDYD6XqP0g = value;
					goto case 4;
				default:
					num = 4;
					if (LmCoEmPhiPMqmJ1X0Ho())
					{
					}
					break;
				case 7:
					if (qDYD6XqP0g != value)
					{
						num = 1;
						break;
					}
					return;
				case 1:
					if (qDYD6XqP0g != null)
					{
						LmCoEmPhiPMqmJ1X0Ho();
						if (T1aSvZPulNZjcGWcuSM())
						{
							num = 5;
							break;
						}
						num = 0;
						if (true)
						{
							break;
						}
					}
					goto case 0;
				case 4:
					if (qDYD6XqP0g != null)
					{
						num = 6;
						break;
					}
					return;
				case 6:
					ETCYQ2ZIopN320IdKCh(qDYD6XqP0g, new PropertyChangedEventHandler(DA4SPWmWC2));
					num = 8;
					break;
				case 8:
					return;
				}
			}
		}
	}

	public FloatViewModel PredictedClassScore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KTyDuEFFZi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0092;
			IL_0092:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
					goto IL_003d;
				default:
					goto IL_0064;
				case 7:
					goto IL_0079;
				case 0:
				case 2:
					rTaI3QZEcZXRZoilBTc(KTyDuEFFZi, new PropertyChangedEventHandler(DA4SPWmWC2));
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					if (KTyDuEFFZi != value)
					{
						num = 3;
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0079:
			KTyDuEFFZi = value;
			goto IL_0064;
			IL_0064:
			if (KTyDuEFFZi != null)
			{
				num = 1;
				goto IL_0092;
			}
			return;
			IL_001a:
			if (KTyDuEFFZi == null)
			{
				goto IL_0079;
			}
			_ = 0;
			if (T1aSvZPulNZjcGWcuSM())
			{
				num = 0;
				if (1 == 0)
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0092;
			IL_003d:
			ETCYQ2ZIopN320IdKCh(KTyDuEFFZi, new PropertyChangedEventHandler(DA4SPWmWC2));
			num = 8;
			if (!T1aSvZPulNZjcGWcuSM())
			{
				goto IL_0064;
			}
			goto IL_0092;
		}
	}

	public BoolViewModel IsSampleUnclassified
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fL3DFgPseR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 7:
					fL3DFgPseR = value;
					goto case 3;
				default:
					num = 3;
					break;
				case 3:
					if (fL3DFgPseR != null)
					{
						goto case 5;
					}
					return;
				case 1:
					if (fL3DFgPseR != null)
					{
						LmCoEmPhiPMqmJ1X0Ho();
						num = (T1aSvZPulNZjcGWcuSM() ? 4 : 6);
						break;
					}
					goto case 7;
				case 2:
				case 4:
					rTaI3QZEcZXRZoilBTc(fL3DFgPseR, new PropertyChangedEventHandler(E2pSKa884C));
					num = 7;
					break;
				case 5:
				case 6:
					ETCYQ2ZIopN320IdKCh(fL3DFgPseR, new PropertyChangedEventHandler(E2pSKa884C));
					num = 8;
					break;
				case 0:
					if (fL3DFgPseR != value)
					{
						num = 1;
						break;
					}
					return;
				case 8:
					return;
				}
			}
		}
	}

	public FloatViewModel UnlabeledImageCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zimDXldjgw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (T1aSvZPulNZjcGWcuSM() ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (zimDXldjgw != value)
					{
						num = 7;
						continue;
					}
					return;
				case 2:
					zimDXldjgw.PropertyChanged += qppSksn29C;
					num = 8;
					continue;
				case 3:
				case 4:
					SetField(ref zimDXldjgw, value, (string)EVrOFFZ5frO57i5Fe8m(7724));
					break;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					zimDXldjgw.PropertyChanged -= qppSksn29C;
					goto case 3;
				case 7:
					if (zimDXldjgw != null)
					{
						num = 6;
						continue;
					}
					goto case 3;
				case 5:
					break;
				case 8:
					return;
				}
				if (zimDXldjgw != null)
				{
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	public FloatViewModel ModelHealth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aiODoUivcK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aiODoUivcK = value;
		}
	}

	public DelegateCommand StopEditingClassesCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RM0DSwLbRH;
		}
	}

	public DelegateCommand NextImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XqYDDma8qh;
		}
	}

	public bool IsEditingClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pcKD3FslhT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				case 4:
					MainViewModel = this;
					return;
				case 1:
					if (SetField(ref pcKD3FslhT, value, (string)EVrOFFZ5frO57i5Fe8m(8004)))
					{
						num = 5;
						break;
					}
					return;
				case 5:
					if (!pcKD3FslhT)
					{
						MainViewModel = null;
						num = 6;
					}
					else
					{
						LmCoEmPhiPMqmJ1X0Ho();
						num = (T1aSvZPulNZjcGWcuSM() ? 4 : 0);
					}
					break;
				case 6:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELClassifyTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				IsMoreImages = true;
				num = 5;
				if (!LmCoEmPhiPMqmJ1X0Ho())
				{
					break;
				}
				goto case 5;
			case 5:
				RM0DSwLbRH = new DelegateCommand(DoStopEditingClasses, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				goto case 1;
			default:
				num = 1;
				break;
			case 9:
				ViDiELEzToolBase.Log = LogManager.GetLogger<ViDiELClassifyTool>();
				LmCoEmPhiPMqmJ1X0Ho();
				if (T1aSvZPulNZjcGWcuSM())
				{
					num = 2;
					break;
				}
				num = 8;
				if (0 == 0)
				{
					break;
				}
				return;
			case 7:
			case 8:
				RuntimeModeService.RuntimeModeChanged += G1JSqPXF1u;
				num = 10;
				if (T1aSvZPulNZjcGWcuSM())
				{
					break;
				}
				goto case 1;
			case 1:
				XqYDDma8qh = new DelegateCommand(DoNextImage, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				num = 6;
				break;
			case 0:
				base._002Ector(inspect, isInitialized);
				num = 9;
				break;
			case 4:
				C543frPtnI5GpD0b6ab();
				num = 0;
				break;
			case 6:
				RuntimeService.IsRepeatingTriggerActiveChanged += do5S2X4OmG;
				goto case 7;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__1))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!LmCoEmPhiPMqmJ1X0Ho())
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
			if (1 == 0)
			{
				goto IL_0040;
			}
		}
		goto IL_0088;
		IL_0026:
		_003CDisposeAsync_003Ed__1 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		goto IL_006e;
		IL_0040:
		stateMachine._003C_003Et__builder = Q9sKXpPzynbe0f9Q8rq();
		num = 1;
		goto IL_0088;
		IL_006e:
		stateMachine._003C_003E1__state = -1;
		goto IL_0056;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 4:
				goto IL_0040;
			case 5:
				goto IL_0056;
			case 2:
			case 3:
				goto IL_006e;
			default:
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
		IL_0056:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
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
		goto IL_0054;
		IL_001a:
		PredictedClassString = null;
		num = 4;
		goto IL_0054;
		IL_0054:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				base.InternalPreParse();
				num = 6;
				continue;
			case 2:
			case 5:
				UnlabeledImageCount = null;
				goto default;
			case 4:
				PredictedClassScore = null;
				_ = 0;
				num = (T1aSvZPulNZjcGWcuSM() ? 5 : 0);
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__3))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!T1aSvZPulNZjcGWcuSM()) ? 4 : 6);
		_003CInternalPostParse_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = DvOOndZLruCsbCbaZKU();
				num = 1;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
				stateMachine.cells = cells;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
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
		int num = 33;
		if (!T1aSvZPulNZjcGWcuSM())
		{
			goto IL_001e;
		}
		goto IL_04f5;
		IL_001e:
		O8VVLQZdrJiFKIj4UFU(SampleCollectionMode, true);
		num = 14;
		goto IL_04f5;
		IL_04f5:
		uint num2 = default;
		ViDiELClassifyToolApi classifyService = default;
		IOperationProgressManager instanceOrDefault = default;
		while (true)
		{
			switch (num)
			{
			case 36:
				break;
			case 13:
				return;
			case 18:
				return;
			case 3:
				switch (num2)
				{
				default:
					num = 39;
					break;
				case 3801848300u:
					if (relativeCellName == (string)EVrOFFZ5frO57i5Fe8m(7596))
					{
						EnableRegionEdit = new CheckBoxViewModel(InSight, cells, loc, (string)FfOlCMZf8UfnkwKsdFp(), IsInitialized);
						num = 34;
					}
					else
					{
						num = 19;
					}
					break;
				case 3436554560u:
					if (Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7626)))
					{
						SampleCollectionMode = new CheckBoxViewModel(InSight, cells, loc, (string)Dn5S10ZlKOILBwvvhhV(), IsInitialized);
						num = 36;
						break;
					}
					return;
				}
				continue;
			case 34:
				O8VVLQZdrJiFKIj4UFU(EnableRegionEdit, true);
				T1aSvZPulNZjcGWcuSM();
				if (!LmCoEmPhiPMqmJ1X0Ho())
				{
					num = 0;
					continue;
				}
				num = 25;
				if (LmCoEmPhiPMqmJ1X0Ho())
				{
					return;
				}
				continue;
			case 15:
				IsSampleUnclassified.Internal = true;
				AddProperty(IsSampleUnclassified);
				return;
			case 35:
				if (num2 <= 103605221)
				{
					if (num2 != 40845415)
					{
						if (num2 != 48189819)
						{
							num = 20;
						}
						else if (Swcon8ZwG4hTDZHR0PF(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(7766)))
						{
							IsSampleUnclassified = new BoolViewModel(InSight, cells, loc, (string)DUPYRxZvuIXgVvC54wB());
							num = 15;
						}
						else
						{
							num = 10;
						}
						continue;
					}
					if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(7670))
					{
						UnclassifiedDetectionMode = new CheckBoxViewModel(InSight, cells, loc, (string)k2uFLUZg3o6WtZuChiD(), IsInitialized);
						num = 11;
						if (0 == 0)
						{
							continue;
						}
						goto case 24;
					}
					return;
				}
				if (num2 == 205723317)
				{
					if (!Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7842)))
					{
						num = 38;
						continue;
					}
					ClassificationConfidence = new EditIntViewModel(InSight, cells, loc, Resources.cJtZOINNil());
					AddProperty(ClassificationConfidence);
					goto case 25;
				}
				num = 9;
				if (T1aSvZPulNZjcGWcuSM())
				{
					continue;
				}
				return;
			case 14:
				AddProperty(SampleCollectionMode);
				return;
			case 24:
				AddProperty(UnlabeledImageCount);
				return;
			case 21:
				if (num2 != 1195222419)
				{
					if (num2 != 1227782301)
					{
						num = 12;
						continue;
					}
					if (relativeCellName == (string)EVrOFFZ5frO57i5Fe8m(5684))
					{
						Region = new EditRegionViewModel(InSight, cells, loc, (string)UDvk0KZn6gu2Ko1aZgx(), wJkY9mZVEa9F5nnfkaB(InputImage));
						num = 16;
						if (true)
						{
							continue;
						}
						goto case 5;
					}
					return;
				}
				if (Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7570)))
				{
					InputRegion = new InputRegionViewModel(this, cells, loc, (string)x9q2EMZDLw2Nx8akPTc(), (string)QAwKStZie6os8YZtpLe(), Region, IsInitialized);
					num = 26;
					if (0 == 0)
					{
						continue;
					}
					return;
				}
				num = 22;
				if (true)
				{
					continue;
				}
				goto case 25;
			case 38:
				return;
			case 42:
				if (num2 != 1047440877)
				{
					num = 30;
					if (true)
					{
						continue;
					}
					return;
				}
				if (Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7810)))
				{
					PredictedClassString = new StringViewModel(InSight, cells, loc, Resources.PredictedClass);
					num = 43;
					if (T1aSvZPulNZjcGWcuSM())
					{
						continue;
					}
					goto case 35;
				}
				num = 18;
				continue;
			case 31:
				return;
			case 16:
				AddProperty(Region);
				num = 1;
				if (true)
				{
					continue;
				}
				return;
			case 4:
				return;
			case 1:
				return;
			case 40:
				ETCYQ2ZIopN320IdKCh(SXjDdg5BGt, new PropertyChangedEventHandler(zZnSi3XPOR));
				return;
			case 30:
				return;
			case 26:
				AddProperty(InputRegion);
				return;
			case 5:
				SXjDdg5BGt = new Classifier(InSight, classifyService, instanceOrDefault, ((IRuntimeService)DZpwH0ZeBPiUso83yg1(Parent)).TriggerOnce, liveLabel: true, new ViDiELClassifierHandle(Parent, (string)YishoTZOY5EH1SOP5cd(this)));
				num = 40;
				if (!LmCoEmPhiPMqmJ1X0Ho())
				{
					continue;
				}
				goto case 20;
			case 20:
				if (num2 != 103605221)
				{
					num = 4;
					if (LmCoEmPhiPMqmJ1X0Ho())
					{
					}
				}
				else if (Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7724)))
				{
					UnlabeledImageCount = new FloatViewModel(InSight, cells, loc, (string)WXQwL4ZsoQ3dKUqXcwr());
					num = 24;
				}
				else
				{
					num = 6;
					if (LmCoEmPhiPMqmJ1X0Ho())
					{
					}
				}
				continue;
			case 11:
				AddProperty(UnclassifiedDetectionMode);
				return;
			case 6:
				return;
			case 41:
				return;
			case 8:
				return;
			case 17:
				AddProperty(PredictedClassScore);
				num = 27;
				continue;
			case 12:
				if (num2 == 1614356400)
				{
					if (!Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7936)))
					{
						num = 23;
						continue;
					}
					ModelHealth = new FloatViewModel(InSight, cells, loc, (string)tcpDhpZrAo98c1Ckugl());
					num = 32;
				}
				else
				{
					num = 8;
				}
				continue;
			case 9:
				if (num2 == 217666493)
				{
					if (!Swcon8ZwG4hTDZHR0PF(relativeCellName, EVrOFFZ5frO57i5Fe8m(7894)))
					{
						num = 31;
						if (LmCoEmPhiPMqmJ1X0Ho())
						{
						}
					}
					else
					{
						PredictedClassScore = new FloatViewModel(InSight, cells, loc, Resources.PredictedClassScore);
						num = 17;
					}
				}
				else
				{
					num = 42;
				}
				continue;
			case 32:
				AddProperty(ModelHealth);
				num = 44;
				if (true)
				{
					continue;
				}
				return;
			case 23:
				return;
			case 2:
				if (num2 > 1047440877)
				{
					if (num2 <= 1614356400)
					{
						num = 21;
						continue;
					}
					if (num2 != 2184184368u)
					{
						num = 3;
						continue;
					}
					if (!(relativeCellName == (string)EVrOFFZ5frO57i5Fe8m(7538)))
					{
						return;
					}
					ELFunctionCellLocation = loc;
					num = 7;
				}
				else
				{
					num = 35;
				}
				continue;
			case 22:
				return;
			case 7:
				classifyService = new ViDiELClassifyToolApi(((CvsCogSocketSheet)RRiIdnZJBhsNBu7R7ZF(InSight.CogSocket)).GetCellToolResourceNode(loc));
				instanceOrDefault = ((IServiceLocator)YsGEjjZa80UQcLxXVGZ()).GetInstanceOrDefault<IOperationProgressManager>((string)null);
				goto case 5;
			default:
				num = 5;
				if (LmCoEmPhiPMqmJ1X0Ho())
				{
				}
				continue;
			case 43:
				AddProperty(PredictedClassString);
				num = 29;
				continue;
			case 27:
				return;
			case 29:
				return;
			case 10:
				return;
			case 39:
				return;
			case 25:
			case 37:
				ClassificationConfidence.PropertyChanged += aMESsPim83;
				num = 41;
				continue;
			case 33:
				num2 = MFLpUOZKLOQvhSPCluw(relativeCellName);
				num = 2;
				continue;
			case 19:
				return;
			case 0:
			case 28:
				AddProperty(EnableRegionEdit);
				num = 13;
				if (true)
				{
					continue;
				}
				return;
			case 44:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t6GSeYYgnY(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((string)EM1NYtZPMtOlGsZsrDs(P_1) == CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436))
		{
			SpreadsheetTool.UpdateToolName((string)l4ChsPZZdY2l1xLkR3c(SnippetName));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void do5S2X4OmG(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		do
		{
			IL_0030:
			switch (num)
			{
			case 0:
			case 1:
				DoStopEditingClasses();
				break;
			case 4:
				if (P_1)
				{
					LmCoEmPhiPMqmJ1X0Ho();
					if (!T1aSvZPulNZjcGWcuSM())
					{
						num = 3;
						goto IL_0030;
					}
					num = 0;
					if (0 == 0)
					{
						goto IL_0030;
					}
				}
				break;
			case 5:
				return;
			}
			FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(7962));
			num = 5;
		}
		while (T1aSvZPulNZjcGWcuSM());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void G1JSqPXF1u(object P_0, RuntimeModeChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		do
		{
			IL_0070:
			switch (num)
			{
			case 1:
			case 3:
				if (!f9bYSfZbjbx1HX3pSng(P_1))
				{
					break;
				}
				goto case 0;
			case 5:
				if (!DZ2WAgZBFnwSNejpqdh(P_1))
				{
					T1aSvZPulNZjcGWcuSM();
					num = ((!LmCoEmPhiPMqmJ1X0Ho()) ? 3 : 0);
					goto IL_0070;
				}
				goto case 0;
			case 0:
			case 2:
				DoStopEditingClasses();
				break;
			default:
				num = 4;
				goto IL_0070;
			case 4:
				break;
			case 6:
				return;
			}
			FXpQypZGcU5sr6GBKmR(this, EVrOFFZ5frO57i5Fe8m(7962));
			num = 6;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoNextImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IRuntimeService)DZpwH0ZeBPiUso83yg1(Parent)).TriggerOnce();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoStopEditingClasses()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HYXy7IZplWi34Tf53DL(SpreadsheetTool, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_spreadsheetTool_PropertyChanged_003Ed__84))]
	private void zZnSi3XPOR(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!LmCoEmPhiPMqmJ1X0Ho())
		{
		}
		_003C_spreadsheetTool_PropertyChanged_003Ed__84 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (!LmCoEmPhiPMqmJ1X0Ho())
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				stateMachine.e = P_1;
				goto default;
			case 1:
				do
				{
					stateMachine._003C_003E4__this = this;
					_ = 1;
					if (LmCoEmPhiPMqmJ1X0Ho())
					{
						num = 0;
						continue;
					}
					num = 4;
					break;
				}
				while (LmCoEmPhiPMqmJ1X0Ho());
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = mfWX6bZXX9RmLIdCfBR();
				num = 1;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUnlabeledImageCount_PropertyChanged_003Ed__85))]
	private void qppSksn29C(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LmCoEmPhiPMqmJ1X0Ho();
		int num = ((!T1aSvZPulNZjcGWcuSM()) ? 6 : 2);
		_003CUnlabeledImageCount_PropertyChanged_003Ed__85 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = mfWX6bZXX9RmLIdCfBR();
				goto case 1;
			case 5:
				stateMachine.e = P_1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (false)
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DA4SPWmWC2(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wQpSBiM8gn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aMESsPim83(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bhOSZbeZ1H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void E2pSKa884C(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wQpSBiM8gn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__89))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (LmCoEmPhiPMqmJ1X0Ho() ? 4 : 2);
		_003CShiftEditGraphics_003Ed__89 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (!LmCoEmPhiPMqmJ1X0Ho())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = DvOOndZLruCsbCbaZKU();
				num = 1;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 6:
				stateMachine.delta = delta;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!T1aSvZPulNZjcGWcuSM())
		{
			goto IL_001e;
		}
		goto IL_0036;
		IL_009b:
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		list.Add(cvsEditableDisplayGraphic);
		num = 6;
		goto IL_0036;
		IL_00ac:
		return (CvsEditableDisplayGraphic[])oBXkEyZ4BI9xgGDJbp3(list);
		IL_0036:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				_ = 1;
				if (LmCoEmPhiPMqmJ1X0Ho())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)xVFnpcZ93tCQk0bNlVT(Region);
				num = 5;
				continue;
			default:
				goto IL_009b;
			case 6:
				goto IL_00ac;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		if (cvsEditableDisplayGraphic != null)
		{
			goto IL_009b;
		}
		goto IL_00ac;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__91))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T1aSvZPulNZjcGWcuSM();
		int num = (LmCoEmPhiPMqmJ1X0Ho() ? 2 : 5);
		_003CWriteFixturedGraphics_003Ed__91 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = DvOOndZLruCsbCbaZKU();
				goto case 1;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshROIEditability_003Ed__92))]
	private Task jDUSGq1Qpb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRefreshROIEditability_003Ed__92 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
				stateMachine._003C_003Et__builder = DvOOndZLruCsbCbaZKU();
				_ = 1;
				num = (LmCoEmPhiPMqmJ1X0Ho() ? 5 : 3);
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wQpSBiM8gn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using IEnumerator<ClassViewModel> enumerator = SXjDdg5BGt.Classes.GetEnumerator();
		while (Id2OhZZAa0hkn9kwGyO(enumerator))
		{
			ClassViewModel current = enumerator.Current;
			int num = 1;
			if (true)
			{
				while (true)
				{
					switch (num)
					{
					case 4:
						break;
					default:
						num = 3;
						continue;
					case 7:
						if (MnyW4IZ6GbIBIjKGUgV(PredictedClassScore) >= 0.0)
						{
							num = 4;
							continue;
						}
						goto IL_014e;
					case 0:
						PbVurMZjwaVjBa1lYLY(current, true);
						num = 7;
						continue;
					case 1:
						goto IL_00f9;
					case 2:
					case 6:
						ftQsKiZCnSt00nwiPA8(current, 0.0);
						num = 9;
						continue;
					case 5:
					case 8:
						PbVurMZjwaVjBa1lYLY(current, false);
						goto case 2;
					case 3:
					case 9:
						goto IL_014e;
					}
					break;
					IL_00f9:
					if (!Swcon8ZwG4hTDZHR0PF(IeVu4KZ7GYBFFrNQOCm(current), PkNY3XZ3qbYdujtCWFm(PredictedClassString)))
					{
						if (!current.IsPredicted)
						{
							goto IL_014e;
						}
						LmCoEmPhiPMqmJ1X0Ho();
						num = ((!T1aSvZPulNZjcGWcuSM()) ? 2 : 8);
					}
					else
					{
						num = 0;
					}
				}
			}
			ftQsKiZCnSt00nwiPA8(current, PredictedClassScore.Value / 100.0);
			IL_014e:;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bhOSZbeZ1H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qcxQs6ZRXTLb2hdMA2u(SXjDdg5BGt, ((double?)ClassificationConfidence?.Value / 100.0).GetValueOrDefault());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private ValueTask p2HSnGP8Jn()
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
	private Task pF1StDwH2Q(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C543frPtnI5GpD0b6ab()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T1aSvZPulNZjcGWcuSM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LmCoEmPhiPMqmJ1X0Ho()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder Q9sKXpPzynbe0f9Q8rq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder DvOOndZLruCsbCbaZKU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint MFLpUOZKLOQvhSPCluw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EVrOFFZ5frO57i5Fe8m(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Swcon8ZwG4hTDZHR0PF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RRiIdnZJBhsNBu7R7ZF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YsGEjjZa80UQcLxXVGZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Locator.Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DZpwH0ZeBPiUso83yg1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YishoTZOY5EH1SOP5cd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ETCYQ2ZIopN320IdKCh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x9q2EMZDLw2Nx8akPTc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QAwKStZie6os8YZtpLe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rcKYeAISOR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UDvk0KZn6gu2Ko1aZgx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation wJkY9mZVEa9F5nnfkaB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FfOlCMZf8UfnkwKsdFp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EnableROIEdit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O8VVLQZdrJiFKIj4UFU(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dn5S10ZlKOILBwvvhhV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SampleCollectionMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k2uFLUZg3o6WtZuChiD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UnclassifiedDetectionMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WXQwL4ZsoQ3dKUqXcwr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UnlabeledImageCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DUPYRxZvuIXgVvC54wB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IsSampleUnclassified;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tcpDhpZrAo98c1Ckugl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ModelHealth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EM1NYtZPMtOlGsZsrDs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object l4ChsPZZdY2l1xLkR3c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetNameViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DZ2WAgZBFnwSNejpqdh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeModeChangedEventArgs)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f9bYSfZbjbx1HX3pSng(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeModeChangedEventArgs)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FXpQypZGcU5sr6GBKmR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R0D3FTZolkt2iuWDFgU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IXuwg6ZS6v2dFf6BnRm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeService)P_0).IsRepeatingTriggerActive;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jDQ5HjZkM2Vetr94yEs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AIVhAkWsgm();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Vu3WcpZ8jJDthp4OIxJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<ClassViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u8okrGZq6CPjU1LI0Iv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Classifier)P_0).HasSamples;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rTaI3QZEcZXRZoilBTc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HYXy7IZplWi34Tf53DL(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Classifier)P_0).IsEditingClasses = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder mfWX6bZXX9RmLIdCfBR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xVFnpcZ93tCQk0bNlVT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oBXkEyZ4BI9xgGDJbp3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IeVu4KZ7GYBFFrNQOCm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PkNY3XZ3qbYdujtCWFm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PbVurMZjwaVjBa1lYLY(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ClassViewModel)P_0).IsPredicted = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double MnyW4IZ6GbIBIjKGUgV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ftQsKiZCnSt00nwiPA8(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ClassViewModel)P_0).PredictedScore = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Id2OhZZAa0hkn9kwGyO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qcxQs6ZRXTLb2hdMA2u(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Classifier)P_0).ClassificationThreshold = P_1;
	}
}
