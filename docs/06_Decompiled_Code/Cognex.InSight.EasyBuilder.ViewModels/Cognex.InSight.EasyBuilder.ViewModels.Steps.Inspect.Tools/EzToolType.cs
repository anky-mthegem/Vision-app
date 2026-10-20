using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Layouts;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public abstract class EzToolType : EzSnippetType
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsCogShape, bool> _003C_003E9__5_0;

		public static Func<CvsEditableDisplayGraphic, bool> _003C_003E9__62_0;

		public static Func<PasteBufferCell, bool> _003C_003E9__101_0;

		public static Func<PasteBufferCell, bool> _003C_003E9__102_0;

		public static Func<PasteBufferCell, bool> _003C_003E9__103_0;

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
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			njv2TWKS2N6pcIl92h7o(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__5_0(CvsCogShape _)
		{
			while (false)
			{
				object obj = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCanAcceptAdd_003Eb__62_0(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (g == null)
			{
				return false;
			}
			return idLf9nKSc3uuyOoDbpa0(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateNamesInPasteBuffer_003Eb__101_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (nEui7AKS1Qa2ADWivOGv(c) != null)
			{
				return oZDN3gKShsTrd66ClDah(nEui7AKS1Qa2ADWivOGv(c), umRcEhKSuSqHYHuSoxV1(1188)) != -1;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetOrderInPasteBuffer_003Eb__102_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Name.EndsWith((string)umRcEhKSuSqHYHuSoxV1(3256), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindInputFixtureCell_003Eb__103_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Oqtw9qKSt2ivUJUe4OYE(nEui7AKS1Qa2ADWivOGv(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N6BfLvKSQuePb6DjTgL8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hw1V24KSNKieokGjvE0n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void njv2TWKS2N6pcIl92h7o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool idLf9nKSc3uuyOoDbpa0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).IsInBounds();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nEui7AKS1Qa2ADWivOGv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object umRcEhKSuSqHYHuSoxV1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oZDN3gKShsTrd66ClDah(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).LastIndexOf((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Oqtw9qKSt2ivUJUe4OYE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Guid g;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass29_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TE3XO8KkKqV4mLf6CtOo();
			POcRm9Kk5oUu5KKdctIE(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_IsLicensed_003Eb__1(CvsCogEasyBuilderLicense a)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WpmaS0KkwpjNm0opJ01P(a).Equals(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TE3XO8KkKqV4mLf6CtOo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void POcRm9Kk5oUu5KKdctIE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JOx1a4KSzTNC4Oo2ROLo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l1wxDqKkLKF2nE6GD7pn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Guid WpmaS0KkwpjNm0opJ01P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEasyBuilderLicense)P_0).License;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnBeginAdd_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzToolType ezToolType = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					kRpffdKkaoXymnoFHNav();
					if (Vi8Iv1KkJESuYNtd2E3g())
					{
						num = 3;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 4;
					continue;
				case 2:
				case 4:
					try
					{
						_ = 2;
						try
						{
							if ((uint)num2 > 1u)
							{
								if (num2 == 2)
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_030f;
								}
								_003C_003E7__wrap2 = 0;
							}
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 7;
									break;
								case 1:
									awaiter = _003C_003Eu__1;
									num3 = 9;
									break;
								case 0:
									awaiter = _003C_003Eu__1;
									num3 = 13;
									break;
								}
								while (true)
								{
									switch (num3)
									{
									case 0:
										if (!awaiter.IsCompleted)
										{
											Vi8Iv1KkJESuYNtd2E3g();
											num3 = (kRpffdKkaoXymnoFHNav() ? 15 : 3);
											continue;
										}
										break;
									case 9:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 17;
										continue;
									case 1:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num3 = 14;
											continue;
										}
										goto case 12;
									case 12:
										awaiter.GetResult();
										goto end_IL_01f7;
									case 14:
										_003C_003Eu__1 = awaiter;
										num3 = 8;
										if (!kRpffdKkaoXymnoFHNav())
										{
											continue;
										}
										return;
									case 2:
										return;
									case 13:
										_003C_003Eu__1 = default;
										num3 = 6;
										continue;
									case 4:
										awaiter = svh1guKkDOl25PAnnoY7(zBHB04KkI1WdMoyckPGb(ezToolType.AcceptAddCommand));
										num3 = 1;
										if (Vi8Iv1KkJESuYNtd2E3g())
										{
											continue;
										}
										goto case 11;
									case 11:
									case 15:
										_003C_003Eu__1 = awaiter;
										num3 = 5;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 3:
									case 10:
										num2 = (_003C_003E1__state = 1);
										goto case 11;
									case 7:
										ezToolType.IsEnabled = false;
										num3 = 16;
										if (!kRpffdKkaoXymnoFHNav())
										{
											continue;
										}
										goto case 8;
									case 8:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 5:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 2;
										if (!kRpffdKkaoXymnoFHNav())
										{
											continue;
										}
										goto case 6;
									case 6:
										num2 = (_003C_003E1__state = -1);
										goto case 12;
									default:
										num3 = 12;
										if (!kRpffdKkaoXymnoFHNav())
										{
											continue;
										}
										goto case 16;
									case 16:
										if (!((EasyBuilderLayout)Tyf80AKkOhTruUxt7QsK(wJZeULKkexeR2C9Kfi4d(ezToolType.Inspect))).aGPbbKPdxWt(ezToolType))
										{
											awaiter = svh1guKkDOl25PAnnoY7(zl8v9fKkisV5qW2ubkgf(ezToolType));
											num3 = 0;
										}
										else
										{
											num3 = 4;
										}
										continue;
									case 17:
										break;
									}
									awaiter.GetResult();
									break;
									continue;
									end_IL_01f7:
									break;
								}
							}
							catch (Exception ex)
							{
								_003C_003E7__wrap1 = ex;
								_003C_003E7__wrap2 = 1;
							}
							int num4 = _003C_003E7__wrap2;
							if (num4 == 1)
							{
								Exception ex2 = (Exception)_003C_003E7__wrap1;
								awaiter = svh1guKkDOl25PAnnoY7(ezToolType.gOqu5YVTlE(ex2));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_030f;
							}
							goto IL_0316;
							IL_030f:
							awaiter.GetResult();
							goto IL_0316;
							IL_0316:
							_003C_003E7__wrap1 = null;
						}
						finally
						{
							if (num2 < 0)
							{
								ezToolType.IsEnabled = true;
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
					num = 0;
					continue;
				case 1:
				case 3:
					ezToolType = _003C_003E4__this;
					goto case 2;
				case 0:
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
		internal static object wJZeULKkexeR2C9Kfi4d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Tyf80AKkOhTruUxt7QsK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).UILayout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zBHB04KkI1WdMoyckPGb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter svh1guKkDOl25PAnnoY7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zl8v9fKkisV5qW2ubkgf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).OnBeginAddInternal();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vi8Iv1KkJESuYNtd2E3g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kRpffdKkaoXymnoFHNav()
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
	private struct _003CHandleExceptionDuringAddAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Exception e;

		public EzToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (gjpCGdKkVpL3vCH0w4AD() ? 3 : 5);
			int num2 = default;
			TaskAwaiter awaiter = default;
			bool? flag2 = default;
			EzToolType ezToolType = default;
			CvsCellLocation? cvsCellLocation = default;
			CvsCogCellResult cvsCogCellResult = default;
			FailAddEventArgs e = default;
			CvsCellLocation valueOrDefault = default;
			CvsCellLocation? cvsCellLocation3 = default;
			CvsCell cvsCell = default;
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
							if (!(this.e is CvsNetworkException))
							{
								goto IL_0306;
							}
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 26;
							if (1 == 0)
							{
								goto IL_0212;
							}
						}
						goto IL_0392;
						IL_032b:
						bool? flag = flag2;
						goto IL_033b;
						IL_033b:
						flag2 = flag;
						if (flag2 != true)
						{
							goto IL_0306;
						}
						num3 = 4;
						goto IL_0392;
						IL_00f3:
						this.e = new Exception((string)FEty3eKkPSgTmL5FCJ0C());
						goto IL_0306;
						IL_0392:
						object obj4;
						while (true)
						{
							CvsCellLocation? cvsCellLocation2;
							object obj;
							switch (num3)
							{
							case 20:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 16:
								break;
							case 7:
								goto IL_009c;
							case 4:
							{
								InspectStepViewModel inspect = ezToolType.Inspect;
								if (inspect == null)
								{
									num3 = 23;
									continue;
								}
								EasyBuilderApplicationViewModel appViewModel = inspect.AppViewModel;
								if (appViewModel == null)
								{
									cvsCellLocation = null;
									num3 = 25;
									if (true)
									{
										continue;
									}
									goto case 25;
								}
								cvsCellLocation2 = appViewModel.Acquired2DImageLocation;
								goto IL_0298;
							}
							case 13:
							case 19:
								if (!(YrgTC5Kkrc0T8r5ITrpr(cvsCogCellResult) is CvsCogImage))
								{
									goto IL_00f3;
								}
								goto IL_0306;
							case 9:
								obj = WYaUdOKkBaW80MsprIeA();
								goto IL_011e;
							case 18:
							{
								EventHandler<FailAddEventArgs> eventHandler = ezToolType.iuZuRSVTfx;
								if (eventHandler != null)
								{
									eventHandler(ezToolType, e);
									num3 = 0;
									continue;
								}
								num3 = 1;
								if (tmDBRlKknlQwNedJL33M())
								{
									continue;
								}
								goto case 11;
							}
							case 11:
								if (cvsCogCellResult == null)
								{
									goto IL_00f3;
								}
								_ = 0;
								if (!tmDBRlKknlQwNedJL33M())
								{
									num3 = 3;
									if (tmDBRlKknlQwNedJL33M())
									{
										continue;
									}
									goto case 9;
								}
								num3 = 19;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 20;
									continue;
								}
								goto case 26;
							case 8:
								e = new FailAddEventArgs(this.e.Message);
								num3 = 18;
								continue;
							case 2:
								goto end_IL_0392;
							case 21:
								goto IL_01c2;
							case 22:
								return;
							case 10:
								goto IL_0212;
							case 5:
								goto IL_0226;
							case 12:
								valueOrDefault = cvsCellLocation3.GetValueOrDefault();
								num3 = 16;
								continue;
							case 23:
								cvsCellLocation = null;
								cvsCellLocation2 = cvsCellLocation;
								goto IL_0298;
							case 25:
								cvsCellLocation2 = cvsCellLocation;
								goto IL_0298;
							case 0:
							case 1:
								obj = ((AppStepViewModel)LvIR51KkfQvhuNY0C3uA(ezToolType))?.SetCurrentSnippet(((AppStepViewModel)LvIR51KkfQvhuNY0C3uA(ezToolType))?.Snippets?.FirstOrDefault(), false);
								if (obj == null)
								{
									num3 = 9;
									continue;
								}
								goto IL_011e;
							case 3:
							case 14:
								goto IL_0306;
							case 24:
								goto IL_032b;
							case 6:
								goto IL_0352;
							case 17:
								cvsCogCellResult = (CvsCogCellResult)xV5dv2Kkvm3CKFXaq7xI(cvsCell);
								goto case 11;
							default:
								num3 = 11;
								continue;
							case 26:
								{
									awaiter.GetResult();
									goto end_IL_0024;
								}
								IL_0298:
								cvsCellLocation3 = cvsCellLocation2;
								if (!cvsCellLocation3.HasValue)
								{
									goto IL_00f3;
								}
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
								IL_011e:
								awaiter = tFcexPKkb4YAn5SR2ZBp(obj);
								num3 = 15;
								if (gjpCGdKkVpL3vCH0w4AD())
								{
								}
								continue;
							}
							object obj2 = LvIR51KkfQvhuNY0C3uA(ezToolType);
							if (obj2 == null)
							{
								goto IL_0079;
							}
							object obj3 = TNvgKjKklU5MukDaKJAS(obj2);
							if (obj3 == null)
							{
								num3 = 21;
								if (tmDBRlKknlQwNedJL33M())
								{
									continue;
								}
								goto IL_009c;
							}
							obj4 = ayanJAKkgAExS06a0OYY(obj3);
							if (obj4 == null)
							{
								num3 = 6;
								if (!tmDBRlKknlQwNedJL33M())
								{
									return;
								}
								continue;
							}
							goto IL_0358;
							IL_009c:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 22;
							continue;
							end_IL_0392:
							break;
						}
						flag = flag2;
						goto IL_033b;
						IL_01c2:
						object obj5 = null;
						goto IL_0364;
						IL_0226:
						object obj6 = LvIR51KkfQvhuNY0C3uA(ezToolType);
						if (obj6 != null)
						{
							IRuntimeService runtimeService = ((AppStepViewModel)obj6).RuntimeService;
							if (runtimeService != null)
							{
								flag = P45lP4KkdWlINm7n2BAv(runtimeService);
								goto IL_033b;
							}
							num3 = 10;
							if (1 == 0)
							{
								goto IL_01c2;
							}
						}
						else
						{
							flag2 = null;
							num3 = 2;
						}
						goto IL_0392;
						IL_0212:
						flag2 = null;
						num3 = 24;
						if (false)
						{
							goto IL_0226;
						}
						goto IL_0392;
						IL_0306:
						Logger.FatalException((string)FQvyj2KkZ1XBMO8NkMbj(this.e), this.e);
						num3 = 8;
						goto IL_0392;
						IL_0358:
						obj5 = ((CvsCellCollection)gI9NfOKksWulb4BDpwTk(obj4))[valueOrDefault];
						goto IL_0364;
						IL_0352:
						obj5 = null;
						goto IL_0364;
						IL_0364:
						cvsCell = (CvsCell)obj5;
						if (cvsCell == null)
						{
							goto IL_00f3;
						}
						num3 = 17;
						goto IL_0392;
						IL_0079:
						obj5 = null;
						goto IL_0364;
						end_IL_0024:;
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
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 3:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				ezToolType = _003C_003E4__this;
				num = 2;
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
		internal static object LvIR51KkfQvhuNY0C3uA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P45lP4KkdWlINm7n2BAv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).AcceptsPointClouds;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TNvgKjKklU5MukDaKJAS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ayanJAKkgAExS06a0OYY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gI9NfOKksWulb4BDpwTk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xV5dv2Kkvm3CKFXaq7xI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YrgTC5Kkrc0T8r5ITrpr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogCellResult)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FEty3eKkPSgTmL5FCJ0C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.XqBGhIPXSN();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FQvyj2KkZ1XBMO8NkMbj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WYaUdOKkBaW80MsprIeA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tFcexPKkb4YAn5SR2ZBp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tmDBRlKknlQwNedJL33M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gjpCGdKkVpL3vCH0w4AD()
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
	private struct _003COnBeginAddInternal_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (FVOxfMKko8vFmGNM4Qf2() ? 2 : 4);
			int num2 = default;
			EzToolType ezToolType = default;
			int i = default;
			Delegate[] invocationList = default;
			Task[] array = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					ezToolType = _003C_003E4__this;
					num = 3;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((AppStepViewModel)C0Y5W2KkSlX0kF9fdUbT(ezToolType)).SetCurrentSnippet((EzSnippet)null, false).GetAwaiter();
							num3 = 25;
							goto IL_028e;
						case 2:
							awaiter = _003C_003Eu__1;
							goto IL_0138;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 4;
							goto IL_028e;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
								goto IL_028e;
							}
							IL_028e:
							while (true)
							{
								switch (num3)
								{
								case 12:
									ezToolType.RefreshInputImageLinks();
									awaiter = ezToolType.SetInputImageIndexAsync(0).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 8;
										continue;
									}
									goto IL_026a;
								case 17:
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									continue;
								case 23:
									for (; i < invocationList.Length; i++)
									{
										array[i] = ((Func<object, EventArgs, Task>)invocationList[i])(ezToolType, EventArgs.Empty);
									}
									num3 = 20;
									continue;
								case 7:
									_003C_003Eu__1 = default;
									num3 = 17;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 0);
									num3 = 16;
									continue;
								case 1:
								case 22:
									break;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 21;
									continue;
								case 13:
									awaiter.GetResult();
									num3 = 12;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								case 20:
									awaiter = ((Task)lT1QmcKkkI2ip2AI0hIB(array)).GetAwaiter();
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 14;
								case 14:
									num2 = (_003C_003E1__state = -1);
									num3 = 26;
									if (true)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 24;
									if (true)
									{
										continue;
									}
									goto case 25;
								case 25:
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 13;
								case 24:
									return;
								case 21:
									return;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 16:
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									if (JxXtX4KkGwBTGZD1sSw8())
									{
										continue;
									}
									goto case 4;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto IL_026a;
								default:
									num3 = 0;
									if (JxXtX4KkGwBTGZD1sSw8())
									{
										continue;
									}
									goto case 2;
								case 2:
									num2 = (_003C_003E1__state = 2);
									JxXtX4KkGwBTGZD1sSw8();
									if (FVOxfMKko8vFmGNM4Qf2())
									{
										num3 = 1;
										continue;
									}
									num3 = 11;
									if (!FVOxfMKko8vFmGNM4Qf2())
									{
										continue;
									}
									goto case 10;
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										if (JxXtX4KkGwBTGZD1sSw8())
										{
											continue;
										}
										goto case 11;
									}
									goto case 26;
								case 11:
								case 19:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
									invocationList = ezToolType.RLlucFFQxE.GetInvocationList();
									num3 = 18;
									if (FVOxfMKko8vFmGNM4Qf2())
									{
									}
									continue;
								case 5:
									i = 0;
									num3 = 23;
									if (FVOxfMKko8vFmGNM4Qf2())
									{
									}
									continue;
								case 18:
									array = new Task[invocationList.Length];
									num3 = 5;
									continue;
								case 26:
									{
										awaiter.GetResult();
										goto end_IL_028e;
									}
									IL_026a:
									awaiter.GetResult();
									if (ezToolType.RLlucFFQxE != null)
									{
										goto case 0;
									}
									goto end_IL_028e;
								}
								goto IL_0138;
								continue;
								end_IL_028e:
								break;
							}
							break;
							IL_0138:
							_003C_003Eu__1 = default;
							num3 = 14;
							goto IL_028e;
						}
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
		internal static object C0Y5W2KkSlX0kF9fdUbT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lT1QmcKkkI2ip2AI0hIB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.WhenAll((Task[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JxXtX4KkGwBTGZD1sSw8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FVOxfMKko8vFmGNM4Qf2()
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
	private struct _003COnAcceptAdd_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		private IDisposable _003C_003E7__wrap1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ITopLevelProgressableOperation _003C_003E7__wrap4;

		private IAsyncDisposable _003Cpause_003E5__6;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap6;

		private int _003C_003E7__wrap7;

		private EzTool _003CnewTool_003E5__9;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<EzTool> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (j4SlMlKk8l1BKU6RjJVB())
			{
				num = 3;
			}
			else
			{
				num = 1;
				if (!j4SlMlKk8l1BKU6RjJVB())
				{
					goto IL_06ad;
				}
			}
			goto IL_0665;
			IL_0665:
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzToolType ezToolType = default;
			TaskAwaiter<EzTool> awaiter4 = default;
			EzTool result2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						if ((uint)num2 > 5u)
						{
							_003C_003E7__wrap1 = (IDisposable)pwYY85Kkpp0tLoC5gvkG(CvsTraceEzb.Info, cR6rZFKkEoVtqG2frH07(48986));
						}
						try
						{
							if ((uint)num2 > 4u)
							{
								if (num2 == 5)
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_05f2;
								}
								_003C_003E7__wrap3 = 0;
							}
							try
							{
								if ((uint)num2 > 4u)
								{
									string text = (string)Y2USxBKk4gd3yTXkYAeK(RwptOaKkXQApYMerwJDp(), UGJyJgKk9bVypZRnXZjt(ezToolType) ?? "");
									IOperationProgressManager operationProgressManager = ezToolType.svKuTI37nn.OperationProgressManager;
									_003C_003E7__wrap4 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? UBT7DeKk7wAnHgtnwj7y(operationProgressManager, text, Array.Empty<StepDescriptor>()) : null);
								}
								try
								{
									TaskAwaiter<IAsyncDisposable> awaiter3;
									ValueTaskAwaiter awaiter2;
									IAsyncDisposable result;
									switch (num2)
									{
									default:
										awaiter3 = ((AppStepViewModel)zn32YJKk3mX43O4Su2d1(ezToolType)).PauseResults().GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											_003C_003Eu__1 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										}
										goto IL_013a;
									case 0:
										awaiter3 = _003C_003Eu__1;
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_013a;
									case 1:
									case 2:
									case 3:
										try
										{
											int num3;
											switch (num2)
											{
											default:
												num3 = 6;
												goto IL_0356;
											case 1:
												awaiter = _003C_003Eu__2;
												num3 = 13;
												goto IL_0356;
											case 3:
												awaiter = _003C_003Eu__2;
												goto IL_02eb;
											case 2:
												{
													awaiter4 = _003C_003Eu__3;
													_003C_003Eu__3 = default;
													num3 = 21;
													goto IL_0356;
												}
												IL_0356:
												while (true)
												{
													switch (num3)
													{
													case 5:
														return;
													case 16:
														num2 = (_003C_003E1__state = 3);
														num3 = 23;
														if (j4SlMlKk8l1BKU6RjJVB())
														{
															continue;
														}
														goto case 17;
													case 17:
														awaiter = ezToolType.s1Ou7UoL9J(_003CnewTool_003E5__9).GetAwaiter();
														if (!awaiter.IsCompleted)
														{
															num3 = 16;
															continue;
														}
														goto IL_03d2;
													case 8:
														awaiter4 = ezToolType.AddTool().GetAwaiter();
														num3 = 7;
														continue;
													case 7:
														if (!awaiter4.IsCompleted)
														{
															num3 = 11;
															if (aHNkyTKkqacOLid1XTVA())
															{
															}
															continue;
														}
														goto IL_02ce;
													case 2:
														return;
													case 13:
														_003C_003Eu__2 = default;
														num2 = (_003C_003E1__state = -1);
														num3 = 20;
														continue;
													case 9:
														_003CnewTool_003E5__9 = result2;
														num3 = 17;
														continue;
													case 4:
													{
														object obj = zn32YJKk3mX43O4Su2d1(ezToolType);
														if (obj == null)
														{
															num3 = 24;
															if (true)
															{
																continue;
															}
															goto case 15;
														}
														((InspectStepViewModel)obj).z9jASc0coS();
														goto case 24;
													}
													case 15:
														GHy37UKk6Xb8NkRXfl9m(_003CnewTool_003E5__9, true);
														num3 = 4;
														continue;
													case 19:
														_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num3 = 5;
														if (aHNkyTKkqacOLid1XTVA())
														{
														}
														continue;
													case 23:
														_003C_003Eu__2 = awaiter;
														_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num3 = 2;
														continue;
													case 21:
														num2 = (_003C_003E1__state = -1);
														goto IL_02ce;
													case 14:
													case 18:
														break;
													case 0:
														_003C_003Eu__2 = awaiter;
														num3 = 19;
														continue;
													case 6:
														awaiter = ((Task)qgyDEeKkjhxLhosZy92W(ezToolType)).GetAwaiter();
														_ = 0;
														if (!j4SlMlKk8l1BKU6RjJVB())
														{
															num3 = 14;
															continue;
														}
														num3 = 10;
														if (!aHNkyTKkqacOLid1XTVA())
														{
															continue;
														}
														goto case 3;
													case 3:
														_003C_003Eu__3 = awaiter4;
														goto case 22;
													default:
														num3 = 22;
														continue;
													case 12:
														num2 = (_003C_003E1__state = -1);
														goto IL_03d2;
													case 1:
													case 10:
														if (!awaiter.IsCompleted)
														{
															num2 = (_003C_003E1__state = 1);
															num3 = 0;
															continue;
														}
														goto case 20;
													case 11:
														num2 = (_003C_003E1__state = 2);
														num3 = 3;
														if (aHNkyTKkqacOLid1XTVA())
														{
														}
														continue;
													case 20:
														awaiter.GetResult();
														num3 = 8;
														if (true)
														{
															continue;
														}
														goto case 22;
													case 22:
														_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
														return;
													case 24:
														{
															_003CnewTool_003E5__9 = null;
															goto end_IL_0356;
														}
														IL_03d2:
														awaiter.GetResult();
														num3 = 15;
														continue;
														IL_02ce:
														result2 = awaiter4.GetResult();
														num3 = 9;
														if (aHNkyTKkqacOLid1XTVA())
														{
														}
														continue;
													}
													goto IL_02eb;
													continue;
													end_IL_0356:
													break;
												}
												break;
												IL_02eb:
												_003C_003Eu__2 = default;
												num3 = 12;
												goto IL_0356;
											}
										}
										catch (object obj2)
										{
											_003C_003E7__wrap6 = obj2;
										}
										if (_003Cpause_003E5__6 == null)
										{
											break;
										}
										awaiter2 = _003Cpause_003E5__6.DisposeAsync().GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 4);
											_003C_003Eu__4 = awaiter2;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											return;
										}
										goto IL_04f6;
									case 4:
										{
											awaiter2 = _003C_003Eu__4;
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											goto IL_04f6;
										}
										IL_04f6:
										awaiter2.GetResult();
										break;
										IL_013a:
										result = awaiter3.GetResult();
										_003Cpause_003E5__6 = result;
										_003C_003E7__wrap6 = null;
										_003C_003E7__wrap7 = 0;
										goto case 1;
									}
									object obj3 = _003C_003E7__wrap6;
									if (obj3 != null)
									{
										((ExceptionDispatchInfo)joprMjKkCxxl14ZPGLoE((obj3 as Exception) ?? throw obj3)).Throw();
									}
									_003C_003E7__wrap6 = null;
									_003Cpause_003E5__6 = null;
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap4 != null)
									{
										kt2sPUKkArjO5v6ke6GT(_003C_003E7__wrap4);
									}
								}
								_003C_003E7__wrap4 = null;
							}
							catch (Exception ex)
							{
								_003C_003E7__wrap2 = ex;
								_003C_003E7__wrap3 = 1;
							}
							int num4 = _003C_003E7__wrap3;
							if (num4 == 1)
							{
								Exception ex2 = (Exception)_003C_003E7__wrap2;
								awaiter = TYRlfPKkRHJIMitWc1Ay(ezToolType.gOqu5YVTlE(ex2));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_05f2;
							}
							goto IL_05f9;
							IL_05f2:
							awaiter.GetResult();
							goto IL_05f9;
							IL_05f9:
							_003C_003E7__wrap2 = null;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								kt2sPUKkArjO5v6ke6GT(_003C_003E7__wrap1);
							}
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
					goto case 5;
				default:
					num = 5;
					continue;
				case 4:
					ezToolType = _003C_003E4__this;
					goto case 1;
				case 0:
				case 3:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_06ad;
			IL_06ad:
			num2 = _003C_003E1__state;
			num = 4;
			goto IL_0665;
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
		internal static object cR6rZFKkEoVtqG2frH07(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pwYY85Kkpp0tLoC5gvkG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RwptOaKkXQApYMerwJDp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.coRG0InpdO();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UGJyJgKk9bVypZRnXZjt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).ToolType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y2USxBKk4gd3yTXkYAeK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UBT7DeKk7wAnHgtnwj7y(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zn32YJKk3mX43O4Su2d1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qgyDEeKkjhxLhosZy92W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).AddAccepted();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GHy37UKk6Xb8NkRXfl9m(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).IsInitialized = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object joprMjKkCxxl14ZPGLoE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kt2sPUKkArjO5v6ke6GT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TYRlfPKkRHJIMitWc1Ay(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j4SlMlKk8l1BKU6RjJVB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aHNkyTKkqacOLid1XTVA()
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
	private struct _003CFireAcceptAdd_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		public EzTool tool;

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
			if (d2vrcgKkWloxiY3ccUQa())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (e9lpTuKkTPOfX2Ql3vui())
				{
					return;
				}
			}
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzToolType ezToolType = default;
			Task[] array2 = default;
			Delegate[] array = default;
			int num4 = default;
			AcceptAddEventHandlerArgs arg = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_01a9;
						}
						int num3;
						if (ezToolType.otGuMqOjVe != null)
						{
							_ = 0;
							num3 = (d2vrcgKkWloxiY3ccUQa() ? 1 : 12);
							goto IL_012b;
						}
						goto end_IL_0024;
						IL_01a9:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 14;
						if (e9lpTuKkTPOfX2Ql3vui())
						{
						}
						goto IL_012b;
						IL_012b:
						while (true)
						{
							switch (num3)
							{
							case 4:
								awaiter = ((Task)HFG2ShKk0XHu6SNDZKMx(array2)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 14;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								continue;
							case 7:
								array2 = new Task[array.Length];
								num3 = 8;
								continue;
							case 8:
								num4 = 0;
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								array = (Delegate[])cwmu5lKkyW1xaWr28MRX(ezToolType.otGuMqOjVe);
								num3 = 7;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 10:
								num4++;
								goto case 5;
							case 5:
								if (num4 < array.Length)
								{
									array2[num4] = ((Func<object, AcceptAddEventHandlerArgs, Task>)array[num4])(ezToolType, arg);
									num3 = 10;
									continue;
								}
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 0:
							case 1:
								arg = new AcceptAddEventHandlerArgs(tool);
								num3 = 9;
								continue;
							case 13:
								return;
							case 11:
							case 12:
								break;
							case 14:
								awaiter.GetResult();
								goto end_IL_012b;
							}
							goto IL_01a9;
							continue;
							end_IL_012b:
							break;
						}
						end_IL_0024:;
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
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					ezToolType = _003C_003E4__this;
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
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
		internal static object cwmu5lKkyW1xaWr28MRX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Delegate)P_0).GetInvocationList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HFG2ShKk0XHu6SNDZKMx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.WhenAll((Task[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d2vrcgKkWloxiY3ccUQa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e9lpTuKkTPOfX2Ql3vui()
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
	private struct _003CCleanUpPastedToolOnFailedAdd_003Ed__72 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		public CvsCellRange pasteRange;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (Se3nFTKkMmB3mkgBL0Mv())
			{
				goto IL_001e;
			}
			goto IL_0289;
			IL_001e:
			int num2 = default;
			EzToolType ezToolType = default;
			try
			{
				int num3;
				TaskAwaiter<CvsCogSheetResult> awaiter2 = default;
				TaskAwaiter<object> awaiter = default;
				switch (num2)
				{
				default:
					num3 = 12;
					break;
				case 1:
					awaiter2 = _003C_003Eu__2;
					num3 = 5;
					break;
				case 0:
					awaiter = _003C_003Eu__1;
					num3 = 1;
					break;
				}
				while (true)
				{
					switch (num3)
					{
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 11;
						continue;
					case 10:
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						num3 = 9;
						continue;
					case 1:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 7;
						continue;
					case 6:
					case 14:
						num2 = (_003C_003E1__state = -1);
						num3 = 17;
						continue;
					case 2:
					case 13:
						if (!awaiter.IsCompleted)
						{
							num3 = 16;
							continue;
						}
						goto case 7;
					case 8:
						awaiter2 = _003Csheet_003E5__2.RunAsync().GetAwaiter();
						num3 = 3;
						continue;
					case 11:
						return;
					case 3:
						if (!awaiter2.IsCompleted)
						{
							num3 = 10;
							continue;
						}
						break;
					case 16:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						continue;
					case 15:
						if (RgSEL4Kkx9URBruW4vJT(pasteRange, CvsCellRange.Empty))
						{
							awaiter = _003Csheet_003E5__2.ClearCellsAsync(pasteRange).GetAwaiter();
							_ = 1;
							num3 = (Se3nFTKkMmB3mkgBL0Mv() ? 6 : 13);
							continue;
						}
						goto end_IL_01de;
					case 12:
						_003Csheet_003E5__2 = (CvsCogSocketSheet)nhaswNKkHruckY6m2yPr(Q7ddZWKkUaZUGx0erjVo(((AppStepViewModel)vv5J6sKkY6PGdcREqtsD(ezToolType)).InSight));
						num3 = 15;
						continue;
					case 0:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (0 == 0)
						{
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						_003C_003Eu__2 = default;
						goto case 6;
					case 7:
						awaiter.GetResult();
						goto case 8;
					default:
						num3 = 8;
						if (Se3nFTKkMmB3mkgBL0Mv())
						{
						}
						continue;
					case 17:
						break;
					}
					awaiter2.GetResult();
					break;
					continue;
					end_IL_01de:
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
			goto IL_02c4;
			IL_0289:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					goto IL_02c4;
				case 5:
					goto IL_02d5;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					if (!Se3nFTKkMmB3mkgBL0Mv())
					{
						continue;
					}
					goto case 1;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 7:
					return;
				}
				break;
				IL_02d5:
				ezToolType = _003C_003E4__this;
				_ = 1;
				if (Se3nFTKkMmB3mkgBL0Mv())
				{
					num = 6;
					if (mqemoWKkFxta1PG5xT9C())
					{
						continue;
					}
					goto IL_02c4;
				}
				num = 4;
			}
			goto IL_001e;
			IL_02c4:
			_003Csheet_003E5__2 = null;
			num = 1;
			goto IL_0289;
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
		internal static object vv5J6sKkY6PGdcREqtsD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q7ddZWKkUaZUGx0erjVo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nhaswNKkHruckY6m2yPr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RgSEL4Kkx9URBruW4vJT(CvsCellRange P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 != P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mqemoWKkFxta1PG5xT9C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Se3nFTKkMmB3mkgBL0Mv()
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
	private struct _003COnCancelAdd_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (kfcO6cKkQiD9wZUSdmmG())
			{
				goto IL_001e;
			}
			goto IL_0297;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = ((!xWosBNKkmjOrnbOSO19g()) ? 4 : 0);
			goto IL_0297;
			IL_0297:
			TaskAwaiter awaiter = default;
			EzToolType ezToolType = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 15;
								if (false)
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 14;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (false)
							{
								goto IL_007c;
							}
						}
						goto IL_01ef;
						IL_00c4:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 11;
							goto IL_01ef;
						}
						goto IL_0257;
						IL_01ef:
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 12:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 10:
							case 16:
								goto IL_00c4;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 15:
								awaiter = ezToolType.AddCanceled().GetAwaiter();
								num3 = 4;
								continue;
							case 3:
								return;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (xWosBNKkmjOrnbOSO19g())
								{
									continue;
								}
								goto case 5;
							case 5:
							{
								awaiter.GetResult();
								EventHandler eventHandler = ezToolType.HkuulEkKEZ;
								if (eventHandler != null)
								{
									eventHandler(ezToolType, EventArgs.Empty);
									break;
								}
								num3 = 12;
								if (xWosBNKkmjOrnbOSO19g())
								{
									continue;
								}
								goto case 2;
							}
							case 2:
							case 13:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (xWosBNKkmjOrnbOSO19g())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (awaiter.IsCompleted)
								{
									goto case 5;
								}
								goto IL_01be;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 17:
								goto IL_0257;
							}
							break;
							IL_01be:
							_ = 0;
							num3 = (xWosBNKkmjOrnbOSO19g() ? 13 : 16);
						}
						goto IL_007c;
						IL_0257:
						awaiter.GetResult();
						goto end_IL_003b;
						IL_007c:
						awaiter = E8HDMsKk2hwJW9SWc0AH(((AppStepViewModel)LmDCUPKkN4AJ32mdt7IK(ezToolType)).SetCurrentSnippet(ezToolType.Inspect.Snippets.FirstOrDefault(), false));
						goto IL_00c4;
						end_IL_003b:;
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
					continue;
				case 0:
				case 1:
					ezToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
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
		internal static object LmDCUPKkN4AJ32mdt7IK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter E8HDMsKk2hwJW9SWc0AH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xWosBNKkmjOrnbOSO19g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kfcO6cKkQiD9wZUSdmmG()
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
	private struct _003CRenameAndPasteTool_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public PasteBuffer pasteObject;

		public EzToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public bool runSheet;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!cnD7clKkcUuiMZXnOmD0())
			{
				goto IL_001e;
			}
			goto IL_01af;
			IL_001e:
			int num2 = default;
			EzToolType ezToolType = default;
			CvsCellRange result = default;
			try
			{
				PasteBuffer pasteBuffer = default;
				int num3;
				TaskAwaiter<CvsCellRange> awaiter = default;
				if (num2 != 0)
				{
					pasteBuffer = UpdateNamesInPasteBuffer(pasteObject, (InspectStepViewModel)IcCLBSKkumvBTCRCHLpl(ezToolType), out var _);
					num3 = 1;
					if (!cnD7clKkcUuiMZXnOmD0())
					{
						goto IL_0049;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 6;
					if (false)
					{
						goto IL_007e;
					}
				}
				goto IL_00fb;
				IL_016c:
				result = awaiter.GetResult();
				goto end_IL_001e;
				IL_00ce:
				num2 = (_003C_003E1__state = -1);
				num3 = 10;
				goto IL_00fb;
				IL_0049:
				if (!awaiter.IsCompleted)
				{
					num3 = 0;
					if (iFmPuFKk1Q3Qy7K6qVuW())
					{
						return;
					}
					goto IL_00fb;
				}
				goto IL_016c;
				IL_013e:
				_003C_003Eu__1 = default;
				num3 = 9;
				goto IL_00fb;
				IL_00fb:
				while (true)
				{
					switch (num3)
					{
					case 2:
						break;
					case 8:
						return;
					case 1:
						goto IL_007e;
					case 0:
						goto IL_00a9;
					case 9:
						goto IL_00ce;
					case 3:
					case 7:
						_003C_003Eu__1 = awaiter;
						goto default;
					case 6:
						goto IL_013e;
					default:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						continue;
					case 10:
						goto IL_016c;
					}
					break;
				}
				goto IL_0049;
				IL_007e:
				awaiter = ezToolType.PasteTool(pasteBuffer, cells, runSheet).GetAwaiter();
				num3 = 2;
				if (iFmPuFKk1Q3Qy7K6qVuW())
				{
					goto IL_00a9;
				}
				goto IL_00fb;
				IL_00a9:
				num2 = (_003C_003E1__state = 0);
				_ = 1;
				if (!iFmPuFKk1Q3Qy7K6qVuW())
				{
					num3 = 7;
					if (!cnD7clKkcUuiMZXnOmD0())
					{
						goto IL_00ce;
					}
				}
				else
				{
					num3 = 5;
					if (1 == 0)
					{
						goto IL_013e;
					}
				}
				goto IL_00fb;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ea;
			IL_01af:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_01ea;
				case 5:
					num2 = _003C_003E1__state;
					cnD7clKkcUuiMZXnOmD0();
					if (iFmPuFKk1Q3Qy7K6qVuW())
					{
						num = 2;
						if (iFmPuFKk1Q3Qy7K6qVuW())
						{
						}
						continue;
					}
					num = 0;
					if (cnD7clKkcUuiMZXnOmD0())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 1:
					ezToolType = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_01ea:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (iFmPuFKk1Q3Qy7K6qVuW())
			{
			}
			goto IL_01af;
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
		internal static object IcCLBSKkumvBTCRCHLpl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cnD7clKkcUuiMZXnOmD0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iFmPuFKk1Q3Qy7K6qVuW()
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
	private struct _003CPasteTool_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public PasteBuffer pasteObject;

		public EzToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public bool runSheet;

		private IDisposable _003C_003E7__wrap1;

		private CvsCellRange _003CdefaultPasteRange_003E5__3;

		private byte[] _003Cbytes_003E5__4;

		private CvsCellRange _003CpasteRange_003E5__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__2;

		private object _003C_003E7__wrap5;

		private int _003C_003E7__wrap6;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			EzToolType ezToolType = default;
			int num2 = default;
			TaskAwaiter awaiter4 = default;
			CvsCellRange result3 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					ezToolType = _003C_003E4__this;
					num = 4;
					if (hIYUO1KkhWhtlWUrAp7o())
					{
						continue;
					}
					goto case 4;
				case 4:
					try
					{
						if ((uint)num2 > 3u)
						{
							_003C_003E7__wrap1 = (IDisposable)Qj2wyeK8LZvjJfoXYmRB(CvsTraceEzb.Info, edFKv9KkzC59O5LZIjYn(49012));
						}
						try
						{
							TaskAwaiter<CvsCellCollection> awaiter3;
							TaskAwaiter<CvsCellRange> awaiter2;
							TaskAwaiter<object> awaiter;
							CvsCellRange result;
							CvsCellCollection result2;
							switch (num2)
							{
							default:
								_003CdefaultPasteRange_003E5__3 = RtYPglK8KgCgba2OLH7k(pasteObject);
								pasteObject = (PasteBuffer)eEOyhRK8web80mUJGtMl(pasteObject, ((AppStepViewModel)BsnnqkK859nLIpZ2jpst(ezToolType)).Snippets.Count() + 1);
								_003Cbytes_003E5__4 = (byte[])vHBW7LK8JfVZ7J5Ftvdo(pasteObject);
								if (cells == null)
								{
									awaiter3 = ((CvsCogSocketSheet)IhIIFKK8etJXNfjAqR6Y(O3RjavK8aWn6tsWgEFXL(ezToolType.Inspect.InSight))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_0126;
								}
								goto IL_0135;
							case 0:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0126;
							case 1:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01a1;
							case 2:
							{
								try
								{
									int num3;
									if (num2 != 2)
									{
										num3 = 7;
										goto IL_02b8;
									}
									awaiter4 = _003C_003Eu__3;
									goto IL_01cb;
									IL_01cb:
									_003C_003Eu__3 = default;
									num3 = 1;
									goto IL_02b8;
									IL_02b8:
									while (true)
									{
										switch (num3)
										{
										case 6:
										case 8:
											break;
										case 4:
											if (!awaiter4.IsCompleted)
											{
												num3 = 2;
												continue;
											}
											goto case 10;
										case 5:
										case 9:
											return;
										case 1:
											num2 = (_003C_003E1__state = -1);
											num3 = 10;
											if (!MUDSwmKktQ1GiEbYltCQ())
											{
												continue;
											}
											goto case 3;
										case 3:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											hIYUO1KkhWhtlWUrAp7o();
											if (MUDSwmKktQ1GiEbYltCQ())
											{
												num3 = 8;
												if (0 == 0)
												{
													continue;
												}
												goto case 1;
											}
											num3 = 9;
											continue;
										case 7:
											awaiter4 = FbUlICK8DEgXFZyNoqUR(EbtrTVK8IVBkanelpkqd(vJAxMeK8OLNO7hrab7QA(ezToolType.Inspect), _003CpasteRange_003E5__5, _003Cbytes_003E5__4, false, runSheet));
											num3 = 4;
											continue;
										case 2:
											num2 = (_003C_003E1__state = 2);
											num3 = 0;
											continue;
										case 0:
											_003C_003Eu__3 = awaiter4;
											goto case 3;
										default:
											num3 = 3;
											if (0 == 0)
											{
												continue;
											}
											goto case 10;
										case 10:
											awaiter4.GetResult();
											goto end_IL_02b8;
										}
										goto IL_01cb;
										continue;
										end_IL_02b8:
										break;
									}
								}
								catch (object obj)
								{
									_003C_003E7__wrap5 = obj;
									_003C_003E7__wrap6 = 1;
								}
								int num4 = _003C_003E7__wrap6;
								if (num4 != 1)
								{
									break;
								}
								awaiter = ((CvsCogSocketSheet)IhIIFKK8etJXNfjAqR6Y(O3RjavK8aWn6tsWgEFXL(vJAxMeK8OLNO7hrab7QA(BsnnqkK859nLIpZ2jpst(ezToolType))))).ClearCellsAsync(_003CpasteRange_003E5__5).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__4 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_039b;
							}
							case 3:
								{
									awaiter = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_039b;
								}
								IL_01a1:
								result = awaiter2.GetResult();
								_003CpasteRange_003E5__5 = result;
								_003C_003E7__wrap6 = 0;
								goto case 2;
								IL_0126:
								result2 = awaiter3.GetResult();
								cells = result2;
								goto IL_0135;
								IL_0135:
								awaiter2 = ((InspectStepViewModel)BsnnqkK859nLIpZ2jpst(ezToolType)).GetSnippetLocation(cells, _003CdefaultPasteRange_003E5__3, false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01a1;
								IL_039b:
								awaiter.GetResult();
								opi2RyK8iICb1bNGtTWQ(ExceptionDispatchInfo.Capture((_003C_003E7__wrap5 as Exception) ?? throw _003C_003E7__wrap5));
								break;
							}
							_003C_003E7__wrap5 = null;
							result3 = _003CpasteRange_003E5__5;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
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
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!hIYUO1KkhWhtlWUrAp7o()) ? 5 : 0);
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result3);
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
		internal static object edFKv9KkzC59O5LZIjYn(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Qj2wyeK8LZvjJfoXYmRB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CnxTraceChannel)P_0).TraceFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange RtYPglK8KgCgba2OLH7k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BsnnqkK859nLIpZ2jpst(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eEOyhRK8web80mUJGtMl(object P_0, int order)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SetOrderInPasteBuffer((PasteBuffer)P_0, order);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vHBW7LK8JfVZ7J5Ftvdo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).ToBytes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O3RjavK8aWn6tsWgEFXL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IhIIFKK8etJXNfjAqR6Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vJAxMeK8OLNO7hrab7QA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EbtrTVK8IVBkanelpkqd(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FbUlICK8DEgXFZyNoqUR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void opi2RyK8iICb1bNGtTWQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hIYUO1KkhWhtlWUrAp7o()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MUDSwmKktQ1GiEbYltCQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public string defaultName;

		public string uniqueName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass101_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			pL2R8FK8fNZPigYDHZLD(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CUpdateNamesInPasteBuffer_003Eb__1(PasteBufferCell cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			string text = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 7:
					text = (string)QKBP3lK8BnMB4Y8i0dT4(text, Y9u3j8K8ZB9cpbnecBPe(IY1iIwK8gUjXr2aKgOWB(1044)));
					goto case 4;
				case 5:
					flag = qjZcGxK8PwVSpqAA8NXy(text, IY1iIwK8gUjXr2aKgOWB(1044), StringComparison.Ordinal);
					num = 9;
					break;
				case 2:
					if (text == null)
					{
						num = 3;
						break;
					}
					if (BGyOAbK8lqkUO6IYLfRn(text, defaultName))
					{
						num = 1;
						break;
					}
					goto case 10;
				case 10:
					if (zEPYMAK8rbWkkITm2Hqj(text, ""))
					{
						goto case 5;
					}
					return;
				default:
					num = 5;
					break;
				case 9:
					if (flag)
					{
						PfvGZvK8nbuBP4n7mnfV();
						if (N1iA6iK8Vbgk2CCKNjGI())
						{
							num = 4;
							if (PfvGZvK8nbuBP4n7mnfV())
							{
								break;
							}
							goto case 5;
						}
						num = 0;
						if (N1iA6iK8Vbgk2CCKNjGI())
						{
						}
						break;
					}
					goto case 4;
				case 4:
				case 8:
					G4jkgiK8btr375BMa2bE(cell, EzSnippet.AssembleFullCellName(uniqueName, text, flag));
					num = 11;
					if (false)
					{
						return;
					}
					break;
				case 3:
					return;
				case 6:
					text = (string)vphEaGK8dCJ90kum18Ky(cell);
					num = 2;
					break;
				case 1:
					text = (string)WDEwARK8vjAoOkibZFMG(text, jMX7llK8sqjvuk2obMGX(defaultName, IY1iIwK8gUjXr2aKgOWB(1104)), "");
					num = 10;
					if (N1iA6iK8Vbgk2CCKNjGI())
					{
						return;
					}
					break;
				case 11:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pL2R8FK8fNZPigYDHZLD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PfvGZvK8nbuBP4n7mnfV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N1iA6iK8Vbgk2CCKNjGI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vphEaGK8dCJ90kum18Ky(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BGyOAbK8lqkUO6IYLfRn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Contains((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IY1iIwK8gUjXr2aKgOWB(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jMX7llK8sqjvuk2obMGX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WDEwARK8vjAoOkibZFMG(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Replace((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zEPYMAK8rbWkkITm2Hqj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qjZcGxK8PwVSpqAA8NXy(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Y9u3j8K8ZB9cpbnecBPe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QKBP3lK8BnMB4Y8i0dT4(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void G4jkgiK8btr375BMa2bE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((PasteBufferCell)P_0).Name = (string)P_1;
		}
	}

	protected static readonly ILogger Logger;

	protected const string InputImageCellName = "InputImage";

	protected const string InputFixtureCellName = "InputFixture";

	protected const string RegionCellName = "Region";

	protected const string PassFailCellName = "_JobPass";

	[CompilerGenerated]
	private CvsCogEasyBuilderConfig c1su3OQS6q;

	protected PasteBuffer _pasteObject;

	private bool WdHuIAJ1jZ;

	private bool yevuf9Vugu;

	[CompilerGenerated]
	private readonly Func<CvsCogShape, bool> xa3uE3IhlR;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand wJQubPotcJ;

	[CompilerGenerated]
	private Func<object, EventArgs, Task> RLlucFFQxE;

	[CompilerGenerated]
	private AddGraphicsChangedEventHandler roXuQN2CNA;

	[CompilerGenerated]
	private AsyncDelegateCommand EUXugjbCSE;

	[CompilerGenerated]
	private Func<object, AcceptAddEventHandlerArgs, Task> otGuMqOjVe;

	[CompilerGenerated]
	private EventHandler<FailAddEventArgs> iuZuRSVTfx;

	[CompilerGenerated]
	private AsyncDelegateCommand VUhu4fwNsZ;

	[CompilerGenerated]
	private EventHandler HkuulEkKEZ;

	private InspectStepViewModel svKuTI37nn;

	private IRuntimeModeService EDCuWUwQ6W;

	[CompilerGenerated]
	private readonly List<SourceLink> P18ujqqTsK;

	private int jXhuCksrOr;

	[CompilerGenerated]
	private readonly string PFLuOZf5Fc;

	public abstract string ToolType { get; }

	public abstract string Description { get; }

	public abstract bool IsReleased { get; }

	public abstract string Source { get; }

	public abstract string Icon { get; }

	public abstract string[] Path { get; }

	public abstract int Order { get; set; }

	public virtual bool IsTypeEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IsLicensed)
			{
				return FunctionsSupported;
			}
			return false;
		}
	}

	public CvsCogEasyBuilderConfig EasyBuilderConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c1su3OQS6q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c1su3OQS6q = value;
		}
	}

	private bool IsLicensed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (EasyBuilderConfig?.AllowedLicenses == null || ((Array)iZMA8rgZyPX7svXd2t6(EasyBuilderConfig)).Length == 0)
			{
				return true;
			}
			return ((IEnumerable<Guid>)dQu5XYgBnyiogSCN7nU(this)).Any([MethodImpl(MethodImplOptions.NoInlining)] (Guid P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass29_0();
				CS_0024_003C_003E8__locals2.g = P_0;
				return EasyBuilderConfig.AllowedLicenses.Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsCogEasyBuilderLicense a) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec__DisplayClass29_0.WpmaS0KkwpjNm0opJ01P(a).Equals(CS_0024_003C_003E8__locals2.g);
				});
			});
		}
	}

	public bool FunctionsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WdHuIAJ1jZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref WdHuIAJ1jZ, value, (string)WXyHSigbgwQ2HhmQ6cy(5164)))
			{
				FirePropertyChanged((string)WXyHSigbgwQ2HhmQ6cy(5204));
			}
		}
	}

	public string Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Path.LastOrDefault();
		}
	}

	public bool IsEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yevuf9Vugu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref yevuf9Vugu, value, (string)WXyHSigbgwQ2HhmQ6cy(5228));
		}
	}

	public virtual Func<CvsCogShape, bool> GraphicsLayerFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xa3uE3IhlR;
		}
	}

	public AsyncDelegateCommand BeginAddCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wJQubPotcJ;
		}
	}

	public AsyncDelegateCommand AcceptAddCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EUXugjbCSE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EUXugjbCSE = value;
		}
	}

	public AsyncDelegateCommand CancelAddCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VUhu4fwNsZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VUhu4fwNsZ = value;
		}
	}

	public virtual InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return svKuTI37nn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 4:
					if (svKuTI37nn != null)
					{
						num = 2;
						break;
					}
					goto case 3;
				case 7:
					RefreshInputImageLinks();
					num = 9;
					break;
				case 1:
				case 6:
					RuntimeModeService = (IRuntimeModeService)FX9L3JgWHw6BqSsnwgW(svKuTI37nn);
					num = 7;
					break;
				case 10:
					if (svKuTI37nn != null)
					{
						JNdr7DgRPimxCwLMamB(svKuTI37nn, new PropertyChangedEventHandler(gifudo8Z6D));
						goto case 0;
					}
					return;
				default:
					num = 0;
					break;
				case 2:
					RuntimeModeService = null;
					num = 8;
					break;
				case 0:
					svKuTI37nn.Snippets.CollectionChanged += URouAsAk6Q;
					goto case 1;
				case 3:
				case 5:
					svKuTI37nn = value;
					num = 10;
					break;
				case 8:
					svKuTI37nn.Snippets.CollectionChanged -= URouAsAk6Q;
					_ = 0;
					num = ((!hpKoXpgvoQvwjhySDG1()) ? 1 : 5);
					break;
				case 9:
					FunctionsSupported = CheckFunctions(SnippetObjects);
					num = 11;
					break;
				case 11:
					return;
				}
			}
		}
	}

	protected override CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			object obj = RXDsGmgSBJTavnCZHRq(this);
			if (obj == null)
			{
				return null;
			}
			return (CvsInSight)aeUDOFgqKNbnitpecAv(obj);
		}
	}

	private IRuntimeModeService RuntimeModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EDCuWUwQ6W;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cN6BV3gr4Uwnrsme3cK();
			int num = ((!hpKoXpgvoQvwjhySDG1()) ? 3 : 5);
			while (true)
			{
				switch (num)
				{
				case 6:
					EDCuWUwQ6W = value;
					goto case 1;
				default:
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					if (EDCuWUwQ6W == null)
					{
						break;
					}
					goto case 3;
				case 0:
				case 5:
					if (EDCuWUwQ6W != null)
					{
						num = 2;
						continue;
					}
					goto case 6;
				case 2:
					EDCuWUwQ6W.RuntimeModeChanged -= B59u6FGUdn;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
				case 4:
					EDCuWUwQ6W.RuntimeModeChanged += B59u6FGUdn;
					num = 7;
					continue;
				case 7:
					break;
				}
				break;
			}
			int isEnabled;
			if (IsTypeEnabled)
			{
				IRuntimeModeService runtimeModeService = RuntimeModeService;
				isEnabled = ((runtimeModeService != null && EEQuSOg0qBNmBVTUq9P(runtimeModeService)) ? 1 : 0);
			}
			else
			{
				isEnabled = 0;
			}
			IsEnabled = (byte)isEnabled != 0;
		}
	}

	public List<SourceLink> InputImageLinks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P18ujqqTsK;
		}
	}

	public virtual int InputImageIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jXhuCksrOr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JcNAaIg2LJideCsGjVA(this, value);
		}
	}

	public SourceLink CurrentInputImageLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputImageLinks[svPO7ZgcO67KmGjpbSq(this)];
		}
	}

	public virtual string DisabledDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PFLuOZf5Fc;
		}
	}

	public event Func<object, EventArgs, Task> BeginAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = RLlucFFQxE;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref RLlucFFQxE, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = RLlucFFQxE;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref RLlucFFQxE, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event AddGraphicsChangedEventHandler AddGraphicsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
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
			goto IL_0077;
			IL_001a:
			AddGraphicsChangedEventHandler addGraphicsChangedEventHandler = roXuQN2CNA;
			num = 6;
			goto IL_0077;
			IL_0077:
			AddGraphicsChangedEventHandler addGraphicsChangedEventHandler2 = default;
			AddGraphicsChangedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 6:
					addGraphicsChangedEventHandler2 = addGraphicsChangedEventHandler;
					cN6BV3gr4Uwnrsme3cK();
					num = (hpKoXpgvoQvwjhySDG1() ? 1 : 5);
					continue;
				case 0:
					if ((object)addGraphicsChangedEventHandler == addGraphicsChangedEventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 6;
				case 1:
				case 2:
					value2 = (AddGraphicsChangedEventHandler)Delegate.Combine(addGraphicsChangedEventHandler2, value);
					goto default;
				default:
					addGraphicsChangedEventHandler = Interlocked.CompareExchange(ref roXuQN2CNA, value2, addGraphicsChangedEventHandler2);
					num = 0;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
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
			goto IL_0039;
			IL_001a:
			AddGraphicsChangedEventHandler addGraphicsChangedEventHandler = default;
			AddGraphicsChangedEventHandler value2 = (AddGraphicsChangedEventHandler)NEyKeAgo18MiPbUlIrW(addGraphicsChangedEventHandler, value);
			goto IL_0099;
			IL_0039:
			AddGraphicsChangedEventHandler addGraphicsChangedEventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					goto IL_006e;
				case 4:
					if ((object)addGraphicsChangedEventHandler2 != addGraphicsChangedEventHandler)
					{
						goto IL_006e;
					}
					num = 7;
					if (true)
					{
						continue;
					}
					goto IL_0099;
				default:
					goto IL_0099;
				case 1:
					addGraphicsChangedEventHandler2 = roXuQN2CNA;
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
				IL_006e:
				addGraphicsChangedEventHandler = addGraphicsChangedEventHandler2;
				_ = 0;
				num = ((!hpKoXpgvoQvwjhySDG1()) ? 6 : 0);
			}
			goto IL_001a;
			IL_0099:
			addGraphicsChangedEventHandler2 = Interlocked.CompareExchange(ref roXuQN2CNA, value2, addGraphicsChangedEventHandler);
			num = 4;
			goto IL_0039;
		}
	}

	public event Func<object, AcceptAddEventHandlerArgs, Task> AcceptAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, AcceptAddEventHandlerArgs, Task> func = otGuMqOjVe;
			Func<object, AcceptAddEventHandlerArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, AcceptAddEventHandlerArgs, Task> value2 = (Func<object, AcceptAddEventHandlerArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref otGuMqOjVe, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, AcceptAddEventHandlerArgs, Task> func = otGuMqOjVe;
			Func<object, AcceptAddEventHandlerArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, AcceptAddEventHandlerArgs, Task> value2 = (Func<object, AcceptAddEventHandlerArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref otGuMqOjVe, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event EventHandler<FailAddEventArgs> FailAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FailAddEventArgs> eventHandler = iuZuRSVTfx;
			EventHandler<FailAddEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FailAddEventArgs> value2 = (EventHandler<FailAddEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref iuZuRSVTfx, value2, eventHandler2);
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
			EventHandler<FailAddEventArgs> eventHandler = iuZuRSVTfx;
			EventHandler<FailAddEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FailAddEventArgs> value2 = (EventHandler<FailAddEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref iuZuRSVTfx, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler CancelAdd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!cN6BV3gr4Uwnrsme3cK())
			{
				num = 2;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_007a;
				}
			}
			goto IL_0043;
			IL_0043:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					value2 = (EventHandler)d4rrEjgAHi6a7cGOwpA(eventHandler2, value);
					goto default;
				case 6:
					break;
				default:
					eventHandler = Interlocked.CompareExchange(ref HkuulEkKEZ, value2, eventHandler2);
					num = 5;
					continue;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 0:
				case 2:
					eventHandler = HkuulEkKEZ;
					num = 6;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_007a;
			IL_007a:
			eventHandler2 = eventHandler;
			num = 4;
			goto IL_0043;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hpKoXpgvoQvwjhySDG1();
			int num = (cN6BV3gr4Uwnrsme3cK() ? 4 : 6);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (cN6BV3gr4Uwnrsme3cK())
						{
						}
						break;
					}
					goto case 1;
				case 1:
				case 4:
					eventHandler = eventHandler2;
					num = 3;
					break;
				case 5:
					eventHandler2 = Interlocked.CompareExchange(ref HkuulEkKEZ, value2, eventHandler);
					num = 2;
					break;
				case 0:
				case 6:
					eventHandler2 = HkuulEkKEZ;
					goto case 1;
				case 3:
					value2 = (EventHandler)NEyKeAgo18MiPbUlIrW(eventHandler, value);
					goto case 5;
				default:
					num = 5;
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cN6BV3gr4Uwnrsme3cK();
		int num = ((!hpKoXpgvoQvwjhySDG1()) ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				zgn6DlgPwjuGA3uXx2A();
				num = 8;
				continue;
			case 1:
				xa3uE3IhlR = [MethodImpl(MethodImplOptions.NoInlining)] (CvsCogShape _) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				};
				P18ujqqTsK = new List<SourceLink>();
				num = 4;
				continue;
			case 4:
				PFLuOZf5Fc = "";
				num = 7;
				continue;
			case 9:
				CancelAddCommand = new AsyncDelegateCommand(AYfuN5tkXc, vlbuUkhdBW);
				num = 10;
				continue;
			case 7:
				base._002Ector();
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				wJQubPotcJ = new AsyncDelegateCommand(AU1ua0EmCk);
				break;
			case 8:
				WdHuIAJ1jZ = true;
				num = 1;
				if (!cN6BV3gr4Uwnrsme3cK())
				{
					continue;
				}
				break;
			case 5:
			case 6:
				break;
			case 10:
				return;
			}
			AcceptAddCommand = new AsyncDelegateCommand(OnAcceptAdd, JPZupjKrme);
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAdd_003Ed__46))]
	private Task AU1ua0EmCk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hpKoXpgvoQvwjhySDG1();
		int num;
		if (!cN6BV3gr4Uwnrsme3cK())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (cN6BV3gr4Uwnrsme3cK())
			{
				goto IL_0095;
			}
		}
		goto IL_0042;
		IL_0042:
		_003COnBeginAdd_003Ed__46 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				if (hpKoXpgvoQvwjhySDG1())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = grNlJxgGG6c73K9CWSG();
				goto case 1;
			case 4:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
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
		goto IL_0095;
		IL_0095:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandleExceptionDuringAddAsync_003Ed__47))]
	private Task gOqu5YVTlE(Exception P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CHandleExceptionDuringAddAsync_003Ed__47 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = grNlJxgGG6c73K9CWSG();
				num = 1;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (cN6BV3gr4Uwnrsme3cK() ? 4 : 5);
				break;
			case 2:
			case 5:
				stateMachine.e = P_0;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__48))]
	protected virtual Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003COnBeginAddInternal_003Ed__48 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = grNlJxgGG6c73K9CWSG();
				hpKoXpgvoQvwjhySDG1();
				num = (cN6BV3gr4Uwnrsme3cK() ? 4 : 0);
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireAddGraphicsChanged(List<CvsEditableDisplayGraphic> toBeRemoved, List<CvsEditableDisplayGraphic> toAdd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		roXuQN2CNA?.Invoke(this, new AddGraphicsChangedEventHandlerArgs(toBeRemoved, toAdd));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsCogRectangle GetAcquired2DImageBounds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!hpKoXpgvoQvwjhySDG1())
		{
			goto IL_001e;
		}
		goto IL_005d;
		IL_003a:
		object obj = null;
		goto IL_0045;
		IL_016f:
		CvsCogRectangle cvsCogRectangle = default;
		return cvsCogRectangle;
		IL_0040:
		object obj2;
		obj = hrR4S6g4OPcrtxvApwD(obj2);
		goto IL_0045;
		IL_001e:
		obj = null;
		goto IL_0045;
		IL_0045:
		CvsCogImage cvsCogImage = obj as CvsCogImage;
		goto IL_009a;
		IL_009a:
		if (cvsCogImage != null)
		{
			goto IL_0158;
		}
		goto IL_016f;
		IL_0158:
		UgGgUkg3gSaaur6Pfsr(cvsCogRectangle, Ul5Xt0g7LHXp4hSmVwt(cvsCogImage));
		num = 8;
		goto IL_005d;
		IL_005d:
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				break;
			case 7:
				goto IL_003a;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_009a;
			case 5:
				goto IL_009a;
			case 8:
				cvsCogRectangle.Height = ahRhKagjwtPZGy20NHh(cvsCogImage);
				num = 10;
				continue;
			case 2:
			case 3:
				goto IL_00c7;
			case 0:
				goto IL_00f3;
			case 4:
				cvsCogRectangle = new CvsCogRectangle(0.0, 0.0, 400.0, 400.0);
				num = 0;
				continue;
			case 1:
			case 6:
				goto IL_0158;
			case 10:
				goto IL_016f;
			}
			break;
			IL_00f3:
			cvsCellLocation = B2UZlpg8Y5YliVR436L(hdQ3i4gk1WMCZ9fTldD(RXDsGmgSBJTavnCZHRq(this)));
			_ = 0;
			if (!hpKoXpgvoQvwjhySDG1())
			{
				num = 1;
				continue;
			}
			num = 3;
			if (cN6BV3gr4Uwnrsme3cK())
			{
			}
			continue;
			IL_00c7:
			object obj3 = GkibeOgXmHlpYMwyMOX(gQauLtgpbX0uoDgxFyU(oYJEoOgEP05qVme5eUn(aeUDOFgqKNbnitpecAv(RXDsGmgSBJTavnCZHRq(this)))), cvsCellLocation);
			if (obj3 != null)
			{
				obj2 = ULFN9sg9tVAkco7jc4c(obj3);
				if (obj2 == null)
				{
					num = 7;
					continue;
				}
				goto IL_0040;
			}
			num = 9;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnAcceptAdd_003Ed__61))]
	protected Task OnAcceptAdd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (hpKoXpgvoQvwjhySDG1())
		{
			num = 3;
			if (!hpKoXpgvoQvwjhySDG1())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_009f;
			}
		}
		goto IL_005a;
		IL_005a:
		_003COnAcceptAdd_003Ed__61 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto IL_009f;
			default:
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 5:
				goto IL_009f;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_009f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005a;
		IL_002a:
		stateMachine._003C_003Et__builder = grNlJxgGG6c73K9CWSG();
		num = 4;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool JPZupjKrme()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsEditableDisplayGraphic[] editableGraphics = GetEditableGraphics();
		if (editableGraphics != null && editableGraphics.All([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g != null && _003C_003Ec.idLf9nKSc3uuyOoDbpa0(g);
		}) && !Q0mnFvg6tipiGy3xhdd(AcceptAddCommand))
		{
			return !CancelAddCommand.IsExecuting;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool vlbuUkhdBW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!Q0mnFvg6tipiGy3xhdd(AcceptAddCommand))
		{
			return !CancelAddCommand.IsExecuting;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireAcceptAdd_003Ed__67))]
	internal Task s1Ou7UoL9J(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CFireAcceptAdd_003Ed__67 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine.tool = P_0;
				goto default;
			case 4:
				do
				{
					stateMachine._003C_003E4__this = this;
					_ = 1;
					if (cN6BV3gr4Uwnrsme3cK())
					{
						num = 6;
						continue;
					}
					num = 1;
					break;
				}
				while (!hpKoXpgvoQvwjhySDG1());
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Task AddAccepted()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)dXKZligCtLbqOoJgksg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCleanUpPastedToolOnFailedAdd_003Ed__72))]
	protected Task CleanUpPastedToolOnFailedAdd(CvsCellRange pasteRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cN6BV3gr4Uwnrsme3cK();
		int num = ((!hpKoXpgvoQvwjhySDG1()) ? 3 : 6);
		_003CCleanUpPastedToolOnFailedAdd_003Ed__72 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = grNlJxgGG6c73K9CWSG();
				num = 1;
				break;
			case 2:
			case 3:
				stateMachine.pasteRange = pasteRange;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnCancelAdd_003Ed__77))]
	internal Task AYfuN5tkXc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (cN6BV3gr4Uwnrsme3cK() ? 2 : 3);
		_003COnCancelAdd_003Ed__77 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
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
	protected virtual Task AddCanceled()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	public abstract Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange);

	public abstract Task<EzTool> AddTool();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameAndPasteTool_003Ed__85))]
	protected Task<CvsCellRange> RenameAndPasteTool(PasteBuffer pasteObject, CvsCellCollection cells = null, bool runSheet = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRenameAndPasteTool_003Ed__85 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.pasteObject = pasteObject;
		stateMachine.cells = cells;
		stateMachine.runSheet = runSheet;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteTool_003Ed__86))]
	protected Task<CvsCellRange> PasteTool(PasteBuffer pasteObject, CvsCellCollection cells = null, bool runSheet = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPasteTool_003Ed__86 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.pasteObject = pasteObject;
		stateMachine.cells = cells;
		stateMachine.runSheet = runSheet;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void URouAsAk6Q(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InspectSnippetsCollectionChanged(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InspectSnippetsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gifudo8Z6D(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (LnLg33gydS6UcrlSFwO(SLa5N9gT6VBVJ9C4Ya9(P_1), WXyHSigbgwQ2HhmQ6cy(5250), StringComparison.Ordinal))
		{
			RuntimeModeService = (IRuntimeModeService)FX9L3JgWHw6BqSsnwgW(RXDsGmgSBJTavnCZHRq(this));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void B59u6FGUdn(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsEnabled = p8BcKmgFnsA0FewoTtk(this) && (RuntimeModeService?.IsOperatorOfflineAndNotInLiveMode ?? false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBuffer UpdateNamesInPasteBuffer(PasteBuffer defaultPasteBuffer, InspectStepViewModel inspect, out string toolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass101_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass101_0();
		PasteBuffer pasteBuffer = defaultPasteBuffer.Clone();
		PasteBufferCell pasteBufferCell = pasteBuffer.Cells.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.nEui7AKS1Qa2ADWivOGv(c) != null && _003C_003Ec.oZDN3gKShsTrd66ClDah(_003C_003Ec.nEui7AKS1Qa2ADWivOGv(c), _003C_003Ec.umRcEhKSuSqHYHuSoxV1(1188)) != -1;
		});
		CS_0024_003C_003E8__locals9.defaultName = ((IEnumerable<JToken>)ViR4wdgMLsc7VP2pJL6(pasteBufferCell)).Value<string>();
		CS_0024_003C_003E8__locals9.uniqueName = (string)WT23TWgYLOSEkhHGGDy(inspect, EzSnippet.RemoveSnippetIndexInName(CS_0024_003C_003E8__locals9.defaultName ?? ""));
		OlX9AEgUGOuKNx17oKo(pasteBufferCell, (JToken)CS_0024_003C_003E8__locals9.uniqueName);
		pasteBufferCell.Data[WXyHSigbgwQ2HhmQ6cy(1524)] = CS_0024_003C_003E8__locals9.uniqueName;
		pasteBuffer.Cells.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell cell) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			string text = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 7:
					text = (string)_003C_003Ec__DisplayClass101_0.QKBP3lK8BnMB4Y8i0dT4(text, _003C_003Ec__DisplayClass101_0.Y9u3j8K8ZB9cpbnecBPe(_003C_003Ec__DisplayClass101_0.IY1iIwK8gUjXr2aKgOWB(1044)));
					goto case 4;
				case 5:
					flag = _003C_003Ec__DisplayClass101_0.qjZcGxK8PwVSpqAA8NXy(text, _003C_003Ec__DisplayClass101_0.IY1iIwK8gUjXr2aKgOWB(1044), StringComparison.Ordinal);
					num = 9;
					break;
				case 2:
					if (text == null)
					{
						num = 3;
						break;
					}
					if (_003C_003Ec__DisplayClass101_0.BGyOAbK8lqkUO6IYLfRn(text, CS_0024_003C_003E8__locals9.defaultName))
					{
						num = 1;
						break;
					}
					goto case 10;
				case 10:
					if (!_003C_003Ec__DisplayClass101_0.zEPYMAK8rbWkkITm2Hqj(text, ""))
					{
						return;
					}
					goto case 5;
				default:
					num = 5;
					break;
				case 9:
					if (flag)
					{
						_003C_003Ec__DisplayClass101_0.PfvGZvK8nbuBP4n7mnfV();
						if (!_003C_003Ec__DisplayClass101_0.N1iA6iK8Vbgk2CCKNjGI())
						{
							num = 0;
							if (_003C_003Ec__DisplayClass101_0.N1iA6iK8Vbgk2CCKNjGI())
							{
							}
							break;
						}
						num = 4;
						if (_003C_003Ec__DisplayClass101_0.PfvGZvK8nbuBP4n7mnfV())
						{
							break;
						}
						goto case 5;
					}
					goto case 4;
				case 4:
				case 8:
					_003C_003Ec__DisplayClass101_0.G4jkgiK8btr375BMa2bE(cell, EzSnippet.AssembleFullCellName(CS_0024_003C_003E8__locals9.uniqueName, text, flag));
					num = 11;
					if (false)
					{
						return;
					}
					break;
				case 3:
					return;
				case 6:
					text = (string)_003C_003Ec__DisplayClass101_0.vphEaGK8dCJ90kum18Ky(cell);
					num = 2;
					break;
				case 1:
					text = (string)_003C_003Ec__DisplayClass101_0.WDEwARK8vjAoOkibZFMG(text, _003C_003Ec__DisplayClass101_0.jMX7llK8sqjvuk2obMGX(CS_0024_003C_003E8__locals9.defaultName, _003C_003Ec__DisplayClass101_0.IY1iIwK8gUjXr2aKgOWB(1104)), "");
					num = 10;
					if (_003C_003Ec__DisplayClass101_0.N1iA6iK8Vbgk2CCKNjGI())
					{
						return;
					}
					break;
				case 11:
					return;
				}
			}
		});
		toolName = CS_0024_003C_003E8__locals9.uniqueName;
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBuffer SetOrderInPasteBuffer(PasteBuffer pasteBuffer, int order)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = GmuuUpgHbWm256I9bQW(pasteBuffer);
		PasteBufferCell pasteBufferCell = ((PasteBuffer)obj).Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Name.EndsWith((string)_003C_003Ec.umRcEhKSuSqHYHuSoxV1(3256), StringComparison.Ordinal);
		});
		OlX9AEgUGOuKNx17oKo(pasteBufferCell, naIjhggxVwP0H4ktDxx(order));
		DHBKjDgmq8bCrM6cZoq(pasteBufferCell.Data, WXyHSigbgwQ2HhmQ6cy(1524), naIjhggxVwP0H4ktDxx(order));
		return (PasteBuffer)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected PasteBufferCell FindInputFixtureCell(PasteBuffer snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return snippet.Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.Oqtw9qKSt2ivUJUe4OYE(_003C_003Ec.nEui7AKS1Qa2ADWivOGv(c), CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshInputImageLinks()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (cN6BV3gr4Uwnrsme3cK() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				InputImageLinks.Add((SourceLink)t1TeAOgQkI6WqLEn7FF(Inspect));
				break;
			default:
				num = 4;
				if (hpKoXpgvoQvwjhySDG1())
				{
					continue;
				}
				break;
			case 4:
				break;
			case 0:
			case 3:
				InputImageLinks.Clear();
				goto case 1;
			case 5:
				return;
			}
			InputImageLinks.AddRange((IEnumerable<SourceLink>)iqyEf3gNHa5h44pvXNL(RXDsGmgSBJTavnCZHRq(this), CellType.Image));
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task SetInputImageIndexAsync(int value)
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
			default:
				UpdateFeatureGraphics();
				num = 5;
				if (cN6BV3gr4Uwnrsme3cK())
				{
				}
				continue;
			case 4:
				SetField(ref jXhuCksrOr, value, (string)WXyHSigbgwQ2HhmQ6cy(5290));
				hpKoXpgvoQvwjhySDG1();
				if (!cN6BV3gr4Uwnrsme3cK())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (!cN6BV3gr4Uwnrsme3cK())
				{
					continue;
				}
				break;
			case 1:
			case 3:
				((InspectStepViewModel)RXDsGmgSBJTavnCZHRq(this)).UpdateShowImageForInputImage(CurrentInputImageLink);
				goto default;
			case 5:
				break;
			}
			break;
		}
		return (Task)dXKZligCtLbqOoJgksg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EzToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		Logger = LogManager.GetLogger<EzToolType>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool TMQuu4Fy6X(Guid P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals2.g = P_0;
		return EasyBuilderConfig.AllowedLicenses.Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsCogEasyBuilderLicense a) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass29_0.WpmaS0KkwpjNm0opJ01P(a).Equals(CS_0024_003C_003E8__locals2.g);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zgn6DlgPwjuGA3uXx2A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hpKoXpgvoQvwjhySDG1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cN6BV3gr4Uwnrsme3cK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iZMA8rgZyPX7svXd2t6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEasyBuilderConfig)P_0).AllowedLicenses;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dQu5XYgBnyiogSCN7nU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippetType)P_0).Guids;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WXyHSigbgwQ2HhmQ6cy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder grNlJxgGG6c73K9CWSG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NEyKeAgo18MiPbUlIrW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RXDsGmgSBJTavnCZHRq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hdQ3i4gk1WMCZ9fTldD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation B2UZlpg8Y5YliVR436L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Acquired2DImageLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aeUDOFgqKNbnitpecAv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oYJEoOgEP05qVme5eUn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gQauLtgpbX0uoDgxFyU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GkibeOgXmHlpYMwyMOX(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ULFN9sg9tVAkco7jc4c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hrR4S6g4OPcrtxvApwD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ul5Xt0g7LHXp4hSmVwt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UgGgUkg3gSaaur6Pfsr(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogRectangle)P_0).Width = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ahRhKagjwtPZGy20NHh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q0mnFvg6tipiGy3xhdd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseDelegateCommand)P_0).IsExecuting;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dXKZligCtLbqOoJgksg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d4rrEjgAHi6a7cGOwpA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JNdr7DgRPimxCwLMamB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FX9L3JgWHw6BqSsnwgW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SLa5N9gT6VBVJ9C4Ya9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LnLg33gydS6UcrlSFwO(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EEQuSOg0qBNmBVTUq9P(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p8BcKmgFnsA0FewoTtk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).IsTypeEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ViR4wdgMLsc7VP2pJL6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WT23TWgYLOSEkhHGGDy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).GenerateUniqueSnippetName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OlX9AEgUGOuKNx17oKo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GmuuUpgHbWm256I9bQW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object naIjhggxVwP0H4ktDxx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DHBKjDgmq8bCrM6cZoq(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JToken)P_0)[P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t1TeAOgQkI6WqLEn7FF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).GetAcquiredImageSourceLink();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iqyEf3gNHa5h44pvXNL(object P_0, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).GetSourceLinks(reqDataType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JcNAaIg2LJideCsGjVA(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).SetInputImageIndexAsync(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int svPO7ZgcO67KmGjpbSq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).InputImageIndex;
	}
}
