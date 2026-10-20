using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteTcpIp : EzFormatStringSupportSnippet
{
	private static class melMtYRiZObFS1FgwCn
	{
	}

	public enum TcpClientServerMode
	{
		TCPClient,
		TCPServer
	}

	public enum PacketTypes
	{
		CR_LF,
		CR,
		LF,
		Null,
		Custom
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParse_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteTcpIp _003C_003E4__this;

		public CvsCellCollection cells;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap1;

		private CvsCellLocation _003Cloc_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			WriteTcpIp writeTcpIp = default;
			TaskAwaiter awaiter = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					IgsQdV5sWDESMEHdH2s3();
					num = ((!GUGcYE5sRYX1JmBCOpDo()) ? 5 : 0);
					break;
				case 4:
					try
					{
						if (num2 != 0)
						{
							writeTcpIp.XAssws2FsZ();
							writeTcpIp.RemoveAllProperties();
							_003C_003E7__wrap1 = writeTcpIp.CellRange.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_05f4;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 26;
							if (GUGcYE5sRYX1JmBCOpDo())
							{
								goto IL_02fd;
							}
							goto IL_03ea;
							IL_02fd:
							while (true)
							{
								IL_02fd_2:
								object obj;
								switch (num3)
								{
								case 27:
									writeTcpIp.Port = new EditIntViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)Vtm3xp5sUnA0X6kEpAHZ());
									writeTcpIp.AddProperty(writeTcpIp.Port);
									num3 = 3;
									continue;
								case 10:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 13:
									num2 = (_003C_003E1__state = -1);
									goto IL_00f0;
								case 24:
									writeTcpIp.AddProperty(writeTcpIp.PacketType);
									goto end_IL_02fd;
								case 17:
									while (!text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(54024), StringComparison.Ordinal))
									{
										if (oAyvk45s0Un2gXaTEchW(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(33162), StringComparison.Ordinal))
										{
											writeTcpIp.TcpMode = new ListBoxViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)wcemp85sFygolGCZvIfJ());
											writeTcpIp.AddProperty(writeTcpIp.TcpMode);
											num3 = 21;
											if (IgsQdV5sWDESMEHdH2s3())
											{
												continue;
											}
											goto IL_02fd_2;
										}
										goto IL_01f5;
									}
									num3 = 25;
									if (GUGcYE5sRYX1JmBCOpDo())
									{
										continue;
									}
									goto case 18;
								case 18:
								{
									object obj2 = p8uGxf5sTgKpj7uO25BB(cells, _003Cloc_003E5__3);
									if (obj2 == null)
									{
										num3 = 2;
										continue;
									}
									obj = vVSq5u5syf9GfqnInoDe(obj2);
									goto IL_058d;
								}
								case 19:
									awaiter = WYRiLZ5smZ2LaxebWyP6(((EzFormatStringViewModel)B2XOMq5sxhVwPspwgmDx(writeTcpIp)).InitializeAsync(cells));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 10;
										continue;
									}
									goto IL_00f0;
								case 15:
									writeTcpIp.E58sKK7aDo = _003Cloc_003E5__3;
									num3 = 4;
									continue;
								case 12:
									bpmHI35sQRJnK3BRHNOs(B2XOMq5sxhVwPspwgmDx(writeTcpIp), new EventHandler(writeTcpIp.esbsyqNBEO));
									num3 = 15;
									continue;
								case 16:
									writeTcpIp.Timeout = new EditIntViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)kNfvYE5s1hh2SHBCF48l());
									num3 = 30;
									if (IgsQdV5sWDESMEHdH2s3())
									{
									}
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 20;
									if (0 == 0)
									{
										continue;
									}
									goto end_IL_02fd;
								case 30:
									break;
								case 1:
								case 3:
								case 4:
								case 5:
								case 7:
								case 8:
								case 21:
								case 22:
								case 29:
									goto end_IL_02fd;
								case 9:
									writeTcpIp.CustomTerminator = new EditIntViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)XnKaSE5s2gtU2QSdF92A());
									num3 = 11;
									continue;
								case 28:
									bqx2jA5sHc0MdOEAwVF8(writeTcpIp, new EzFormatStringViewModel((CommStepViewModel)writeTcpIp.Parent, writeTcpIp.GetType(), _003Cloc_003E5__3));
									num3 = 19;
									continue;
								case 20:
									return;
								case 11:
									writeTcpIp.AddProperty(writeTcpIp.CustomTerminator);
									goto end_IL_02fd;
								case 25:
									writeTcpIp.Enabled = new CheckBoxViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, Resources.Enabled, isInitialized: true);
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
									writeTcpIp.AddProperty(writeTcpIp.Enabled);
									_ = 0;
									num3 = ((!GUGcYE5sRYX1JmBCOpDo()) ? 1 : 29);
									continue;
								case 23:
									writeTcpIp.AddProperty(writeTcpIp.HostName);
									num3 = 7;
									continue;
								case 2:
									obj = null;
									goto IL_058d;
								case 14:
									writeTcpIp.MaxPacketSize = new EditIntViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)bHjQeq5sceQRaiEnpkSr());
									writeTcpIp.AddProperty(writeTcpIp.MaxPacketSize);
									num3 = 8;
									if (GUGcYE5sRYX1JmBCOpDo())
									{
										continue;
									}
									goto case 26;
								case 26:
									_003C_003Eu__1 = default;
									num3 = 13;
									continue;
								case 31:
									goto IL_05f4;
									IL_058d:
									text = (string)obj;
									if (text != null)
									{
										num3 = 17;
										continue;
									}
									goto IL_05f4;
									IL_00f0:
									awaiter.GetResult();
									num3 = 12;
									continue;
								}
								goto IL_03de;
								IL_01f5:
								if (oAyvk45s0Un2gXaTEchW(text, LgnFkF5sM3Bqns5Mr5v9(54064), StringComparison.Ordinal))
								{
									writeTcpIp.HostName = new EditStringViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)wT1rwF5sYmJVo9VVL95D());
									num3 = 23;
									continue;
								}
								if (!text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(54106), StringComparison.Ordinal))
								{
									if (!oAyvk45s0Un2gXaTEchW(text, LgnFkF5sM3Bqns5Mr5v9(54140), StringComparison.Ordinal))
									{
										if (!oAyvk45s0Un2gXaTEchW(text, LgnFkF5sM3Bqns5Mr5v9(54178), StringComparison.Ordinal))
										{
											if (text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(54224), StringComparison.Ordinal))
											{
												num3 = 9;
												if (IgsQdV5sWDESMEHdH2s3())
												{
												}
											}
											else if (!oAyvk45s0Un2gXaTEchW(text, LgnFkF5sM3Bqns5Mr5v9(54282), StringComparison.Ordinal))
											{
												if (!text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(54334), StringComparison.Ordinal))
												{
													break;
												}
												num3 = 16;
												if (false)
												{
													return;
												}
											}
											else
											{
												num3 = 14;
											}
											continue;
										}
										writeTcpIp.PacketType = new ListBoxViewModel(writeTcpIp.InSight, cells, _003Cloc_003E5__3, (string)g2LAVD5sNj5tfLbSCPc3());
										num3 = 24;
										if (GUGcYE5sRYX1JmBCOpDo())
										{
											continue;
										}
										goto IL_03de;
									}
									num3 = 28;
									continue;
								}
								num3 = 27;
								continue;
								IL_03de:
								writeTcpIp.AddProperty(writeTcpIp.Timeout);
								break;
								continue;
								end_IL_02fd:
								break;
							}
							goto IL_03ea;
							IL_05f4:
							if (vNrdps5suXUiepYyFdO6(_003C_003E7__wrap1))
							{
								_003Cloc_003E5__3 = _003C_003E7__wrap1.Current;
								num3 = 18;
								goto IL_02fd;
							}
							goto end_IL_0075;
							IL_03ea:
							_003Cloc_003E5__3 = default;
							num3 = 31;
							goto IL_02fd;
							end_IL_0075:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								pHSFKw5sh0f6AnvD15c9(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						IEnumerator<CellViewModel> enumerator = writeTcpIp.Properties.GetEnumerator();
						try
						{
							while (vNrdps5suXUiepYyFdO6(enumerator))
							{
								enumerator.Current.SourcePropertyChanged += writeTcpIp.cPpsH7D9mk;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								pHSFKw5sh0f6AnvD15c9(enumerator);
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
					goto default;
				case 0:
				case 1:
					writeTcpIp = _003C_003E4__this;
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
		internal static object p8uGxf5sTgKpj7uO25BB(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vVSq5u5syf9GfqnInoDe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oAyvk45s0Un2gXaTEchW(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wcemp85sFygolGCZvIfJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.rU2V9UVxeB();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LgnFkF5sM3Bqns5Mr5v9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wT1rwF5sYmJVo9VVL95D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.YccYpZkrht();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vtm3xp5sUnA0X6kEpAHZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.I9XJGVUMnP();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bqx2jA5sHc0MdOEAwVF8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringSupportSnippet)P_0).FormatString = (EzFormatStringViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B2XOMq5sxhVwPspwgmDx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringSupportSnippet)P_0).FormatString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WYRiLZ5smZ2LaxebWyP6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bpmHI35sQRJnK3BRHNOs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringViewModel)P_0).FormatStringClosed += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g2LAVD5sNj5tfLbSCPc3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.opYLBlXARD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XnKaSE5s2gtU2QSdF92A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.hdTZrK6fR3();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bHjQeq5sceQRaiEnpkSr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.xg7Vbsq32e();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kNfvYE5s1hh2SHBCF48l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Timeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vNrdps5suXUiepYyFdO6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pHSFKw5sh0f6AnvD15c9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GUGcYE5sRYX1JmBCOpDo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IgsQdV5sWDESMEHdH2s3()
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
	private struct _003CEnableSource_SourcePropertyChanged_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteTcpIp _003C_003E4__this;

		public object sender;

		public PropertyValueChangedEventArgs<CellViewModel> args;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (QOqALr5szhJej8cAeVWC() ? 2 : 5);
			WriteTcpIp writeTcpIp = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			PropertyLinks propertyLinks = default;
			CellViewModel cellViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					writeTcpIp = _003C_003E4__this;
					num = 4;
					break;
				case 4:
					try
					{
						int num3;
						object obj2;
						if (num2 != 0)
						{
							AppStepViewModel parent = writeTcpIp.Parent;
							if (parent == null)
							{
								num3 = 11;
								if (1 == 0)
								{
									goto IL_0069;
								}
							}
							else
							{
								object obj = nnLSgf5vLwDow7Sg5R8q(parent);
								if (obj != null)
								{
									obj2 = ((EasyBuilderApplicationViewModel)obj).PropertyLinks;
									goto IL_0074;
								}
								num3 = 3;
								if (1 == 0)
								{
									goto IL_01ae;
								}
							}
							goto IL_0131;
						}
						awaiter = _003C_003Eu__1;
						goto IL_017a;
						IL_01ae:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						goto IL_0131;
						IL_0074:
						propertyLinks = (PropertyLinks)obj2;
						if (propertyLinks != null)
						{
							num3 = 2;
							if (!gNvGDC5stlqURWVDZ94y())
							{
								goto IL_008b;
							}
							goto IL_0131;
						}
						goto end_IL_004a;
						IL_0131:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 4:
								goto IL_008b;
							case 2:
								cellViewModel = sender as CellViewModel;
								if (cellViewModel != null)
								{
									num3 = 4;
									continue;
								}
								goto end_IL_004a;
							case 6:
							case 7:
								return;
							case 0:
								goto IL_00e2;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									goto IL_01ae;
								}
								goto case 12;
							default:
								num3 = 1;
								if (gNvGDC5stlqURWVDZ94y())
								{
									continue;
								}
								goto IL_017a;
							case 8:
							case 9:
								goto IL_017a;
							case 11:
								goto IL_0190;
							case 1:
								goto IL_01ae;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_004a;
							}
							break;
							IL_00e2:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							QOqALr5szhJej8cAeVWC();
							num3 = (gNvGDC5stlqURWVDZ94y() ? 6 : 9);
						}
						goto IL_0069;
						IL_0190:
						obj2 = null;
						goto IL_0074;
						IL_017a:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_0131;
						IL_008b:
						awaiter = lijXrE5vKRxSfEmdeCIJ(propertyLinks.OnSourcePropertyChanged(cellViewModel, args));
						num3 = 10;
						goto IL_0131;
						IL_0069:
						obj2 = null;
						goto IL_0074;
						end_IL_004a:;
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
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object nnLSgf5vLwDow7Sg5R8q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lijXrE5vKRxSfEmdeCIJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gNvGDC5stlqURWVDZ94y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QOqALr5szhJej8cAeVWC()
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
	private struct _003CDisposeAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public WriteTcpIp _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (birast5vwxuR6H1GOofH())
			{
				goto IL_001e;
			}
			goto IL_01a2;
			IL_0035:
			int num2 = default;
			WriteTcpIp writeTcpIp = default;
			try
			{
				int num3;
				ValueTaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					writeTcpIp.XAssws2FsZ();
					_ = 0;
					num3 = ((!v45jw85v5UlUJKByXj3Q()) ? 1 : 9);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 8;
				}
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 9:
						awaiter = writeTcpIp.JO5sxBmCoI().GetAwaiter();
						num3 = 7;
						if (birast5vwxuR6H1GOofH())
						{
						}
						continue;
					case 5:
						return;
					case 1:
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						continue;
					case 8:
						_003C_003Eu__1 = default;
						num3 = 4;
						continue;
					case 4:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 7:
						if (awaiter.IsCompleted)
						{
							break;
						}
						goto case 1;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						if (v45jw85v5UlUJKByXj3Q())
						{
							continue;
						}
						goto case 6;
					case 6:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					default:
						num3 = 3;
						if (!birast5vwxuR6H1GOofH())
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
			goto IL_01cd;
			IL_01a2:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 0:
				case 2:
					goto IL_0035;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_01cd;
				case 5:
					goto IL_01e2;
				case 6:
					return;
				}
				break;
				IL_01e2:
				num2 = _003C_003E1__state;
				v45jw85v5UlUJKByXj3Q();
				num = ((!birast5vwxuR6H1GOofH()) ? 3 : 0);
			}
			goto IL_001e;
			IL_01cd:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01a2;
			IL_001e:
			writeTcpIp = _003C_003E4__this;
			goto IL_0035;
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
		internal static bool v45jw85v5UlUJKByXj3Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool birast5vwxuR6H1GOofH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation E58sKK7aDo;

	public static readonly int CustomTerminatorPacketType;

	public static readonly int TcpServerEnabled;

	[CompilerGenerated]
	private EditStringViewModel C5rsGqEgXr;

	[CompilerGenerated]
	private EditIntViewModel mPYsBYItxr;

	[CompilerGenerated]
	private CheckBoxViewModel BP9sZtiLWt;

	[CompilerGenerated]
	private ListBoxViewModel OYJsnugeZN;

	[CompilerGenerated]
	private EditIntViewModel Eg9stQEmbM;

	[CompilerGenerated]
	private EditIntViewModel zX7sYwKApt;

	[CompilerGenerated]
	private EditIntViewModel zEUs0c1waC;

	[CompilerGenerated]
	private ListBoxViewModel XPUsVsFCZF;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand K8fsLeh1Yp;

	[CompilerGenerated]
	private EventHandler OGBsJlesp0;

	private EzFormatStringViewModel BhTs9jgYBs;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)kVOMVrhF6KCkbOlsTTb();
		}
	}

	public EditStringViewModel HostName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C5rsGqEgXr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			C5rsGqEgXr = value;
		}
	}

	public EditIntViewModel Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mPYsBYItxr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mPYsBYItxr = value;
		}
	}

	public CheckBoxViewModel Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BP9sZtiLWt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BP9sZtiLWt = value;
		}
	}

	public ListBoxViewModel PacketType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OYJsnugeZN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OYJsnugeZN = value;
		}
	}

	public EditIntViewModel CustomTerminator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Eg9stQEmbM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Eg9stQEmbM = value;
		}
	}

	public EditIntViewModel MaxPacketSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zX7sYwKApt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zX7sYwKApt = value;
		}
	}

	public EditIntViewModel Timeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zEUs0c1waC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zEUs0c1waC = value;
		}
	}

	public ListBoxViewModel TcpMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XPUsVsFCZF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XPUsVsFCZF = value;
		}
	}

	public AsyncDelegateCommand TcpIpDetailsPanelToggle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K8fsLeh1Yp;
		}
	}

	public override EzFormatStringViewModel FormatString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BhTs9jgYBs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BhTs9jgYBs = value;
		}
	}

	public event EventHandler DetailsToggled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					eventHandler = Interlocked.CompareExchange(ref OGBsJlesp0, value2, eventHandler2);
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 1:
					eventHandler = OGBsJlesp0;
					num = 6;
					if (t0jMHDhWDb5vg1715dO())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					value2 = (EventHandler)b0N8mohMb8KsImx7Pbp(eventHandler2, value);
					goto default;
				case 6:
					break;
				case 7:
					return;
				}
				do
				{
					eventHandler2 = eventHandler;
					_ = 1;
					if (cULCFchTccXDbeXA2Ts())
					{
						num = 5;
						continue;
					}
					num = 0;
					break;
				}
				while (false);
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
			int num = 4;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					eventHandler = Interlocked.CompareExchange(ref OGBsJlesp0, value2, eventHandler2);
					num = 0;
					break;
				case 1:
					eventHandler2 = eventHandler;
					t0jMHDhWDb5vg1715dO();
					if (!cULCFchTccXDbeXA2Ts())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 2;
					}
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 2:
				case 5:
					value2 = (EventHandler)EGxgUBhY9ISYyZp9YMc(eventHandler2, value);
					goto default;
				case 4:
					eventHandler = OGBsJlesp0;
					num = 1;
					break;
				case 0:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteTcpIp(CommStepViewModel commStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		do
		{
			IL_004d:
			switch (num)
			{
			case 0:
				h6qRxyhyZ7tO3dZScHA();
				_ = 1;
				num = (cULCFchTccXDbeXA2Ts() ? 4 : 3);
				goto IL_004d;
			case 1:
			case 3:
				base._002Ector(commStepVm, localizer);
				break;
			case 5:
				return;
			}
			K8fsLeh1Yp = new AsyncDelegateCommand(ToggleDetailsPanel, [MethodImpl(MethodImplOptions.NoInlining)] () =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			});
			num = 5;
		}
		while (!cULCFchTccXDbeXA2Ts());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ToggleDetailsPanel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = OGBsJlesp0;
		if (eventHandler != null)
		{
			fX7fa0h0Ntvgh0noysa(eventHandler, this, EventArgs.Empty);
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParse_003Ed__50))]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CParse_003Ed__50 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine.cells = cells;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = VJmShwhUCBAeEMeaR3s();
				num = 1;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				cULCFchTccXDbeXA2Ts();
				num = ((!t0jMHDhWDb5vg1715dO()) ? 4 : 0);
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableSource_SourcePropertyChanged_003Ed__51))]
	private Task cPpsH7D9mk(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEnableSource_SourcePropertyChanged_003Ed__51 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XAssws2FsZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t0jMHDhWDb5vg1715dO();
		int num;
		if (!cULCFchTccXDbeXA2Ts())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_00da;
			}
		}
		IEnumerator<CellViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				enumerator = Properties.GetEnumerator();
				num = 6;
				if (cULCFchTccXDbeXA2Ts())
				{
				}
				continue;
			case 0:
			case 3:
				if (FormatString != null)
				{
					num = 1;
					if (cULCFchTccXDbeXA2Ts())
					{
					}
					continue;
				}
				goto case 4;
			case 2:
			case 5:
				ODJJ8bhx3BdZhakoFtk(FormatString);
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				xkVIaahHy5MMrxFMPl6(FormatString, new EventHandler(esbsyqNBEO));
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		goto IL_00da;
		IL_00da:
		try
		{
			while (PMjpAjhmva3WDYlE4rv(enumerator))
			{
				CellViewModel current = enumerator.Current;
				t0jMHDhWDb5vg1715dO();
				int num2;
				if (!cULCFchTccXDbeXA2Ts())
				{
					num2 = 2;
					if (false)
					{
						goto IL_0102;
					}
				}
				else
				{
					num2 = 3;
				}
				goto IL_011a;
				IL_011a:
				switch (num2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_0143;
				case 4:
					continue;
				}
				goto IL_0102;
				IL_0102:
				if (current == null)
				{
					continue;
				}
				goto IL_0143;
				IL_0143:
				current.SourcePropertyChanged -= cPpsH7D9mk;
				num2 = 4;
				goto IL_011a;
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__53))]
	public override ValueTask DisposeAsync()
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
		goto IL_0080;
		IL_001a:
		_003CDisposeAsync_003Ed__53 stateMachine = default;
		stateMachine._003C_003Et__builder = eb9DymhQmkxLndm4wWZ();
		_ = 1;
		num = (cULCFchTccXDbeXA2Ts() ? 5 : 0);
		goto IL_0080;
		IL_0080:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void esbsyqNBEO(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = OGBsJlesp0;
		if (eventHandler != null)
		{
			fX7fa0h0Ntvgh0noysa(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriteTcpIp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!cULCFchTccXDbeXA2Ts()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				TcpServerEnabled = 0;
				num = 5;
				break;
			case 3:
				CustomTerminatorPacketType = 4;
				goto default;
			case 0:
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask JO5sxBmCoI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h6qRxyhyZ7tO3dZScHA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t0jMHDhWDb5vg1715dO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cULCFchTccXDbeXA2Ts()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fX7fa0h0Ntvgh0noysa(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kVOMVrhF6KCkbOlsTTb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cVbmSZWo8n();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b0N8mohMb8KsImx7Pbp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EGxgUBhY9ISYyZp9YMc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder VJmShwhUCBAeEMeaR3s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xkVIaahHy5MMrxFMPl6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzFormatStringViewModel)P_0).FormatStringClosed -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ODJJ8bhx3BdZhakoFtk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzFormatStringViewModel)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PMjpAjhmva3WDYlE4rv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder eb9DymhQmkxLndm4wWZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}
}
