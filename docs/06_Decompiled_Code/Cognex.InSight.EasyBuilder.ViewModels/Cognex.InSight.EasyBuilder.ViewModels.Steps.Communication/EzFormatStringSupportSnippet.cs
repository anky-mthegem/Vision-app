using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public abstract class EzFormatStringSupportSnippet : EzSupportSnippet
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveSupportSnippetReferencesAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzFormatStringSupportSnippet _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01fc;
			IL_001a:
			EzFormatStringSupportSnippet ezFormatStringSupportSnippet = _003C_003E4__this;
			num = 5;
			goto IL_01fc;
			IL_01fc:
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzFormatStringRemoveArgumentUndoAction action = default;
			List<FormatStringArgViewModel> argumentsToRemove = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 5:
					try
					{
						object obj2;
						int num3;
						if (num2 != 0)
						{
							object obj = q0xSlx5VzjUqiXTnR97T(ezFormatStringSupportSnippet);
							if (obj != null)
							{
								obj2 = ((EzFormatStringViewModel)obj).Arguments;
								goto IL_0097;
							}
							num3 = 2;
							if (!IIJ4AH5VhlKe2sEkTsuO())
							{
								goto IL_004e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (MJOSbv5VtdeTO8apO2kB())
							{
								goto IL_008c;
							}
						}
						goto IL_015d;
						IL_015d:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								goto IL_008c;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 5:
								action = new EzFormatStringRemoveArgumentUndoAction(ezFormatStringSupportSnippet.Parent as CommStepViewModel, ulMeDB5fKnsOyPh2TcMQ(ezFormatStringSupportSnippet), argumentsToRemove);
								num3 = 9;
								if (IIJ4AH5VhlKe2sEkTsuO())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 9:
								awaiter = vPSBFt5f55QE8UIIsr0p(e.AddUndo(action));
								num3 = 8;
								continue;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto case 4;
								}
								goto case 11;
							case 11:
								awaiter.GetResult();
								goto end_IL_002b;
							}
							break;
						}
						goto IL_004e;
						IL_004e:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						goto IL_015d;
						IL_0097:
						if (obj2 != null)
						{
							argumentsToRemove = nNnicZbNGL(((EzFormatStringViewModel)q0xSlx5VzjUqiXTnR97T(ezFormatStringSupportSnippet)).Arguments, (EzSnippet)SGuPqm5fLF9x2HKecm84(e)).ToList();
							_ = 0;
							num3 = ((!IIJ4AH5VhlKe2sEkTsuO()) ? 6 : 5);
							goto IL_015d;
						}
						goto end_IL_002b;
						IL_008c:
						obj2 = null;
						goto IL_0097;
						end_IL_002b:;
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
					if (!MJOSbv5VtdeTO8apO2kB())
					{
						continue;
					}
					goto case 2;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (IIJ4AH5VhlKe2sEkTsuO() ? 4 : 0);
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
		internal static object q0xSlx5VzjUqiXTnR97T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringSupportSnippet)P_0).FormatString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SGuPqm5fLF9x2HKecm84(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type ulMeDB5fKnsOyPh2TcMQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vPSBFt5f55QE8UIIsr0p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IIJ4AH5VhlKe2sEkTsuO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MJOSbv5VtdeTO8apO2kB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetArgumentsInSnippet_003Ed__6 : IEnumerable<FormatStringArgViewModel>, IEnumerable, IEnumerator<FormatStringArgViewModel>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private FormatStringArgViewModel _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<FormatStringArgViewModel> arguments;

		public IEnumerable<FormatStringArgViewModel> _003C_003E3__arguments;

		private EzSnippet snippet;

		public EzSnippet _003C_003E3__snippet;

		private IEnumerator<FormatStringArgViewModel> _003C_003E7__wrap1;

		FormatStringArgViewModel IEnumerator<FormatStringArgViewModel>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetArgumentsInSnippet_003Ed__6(int _003C_003E1__state)
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
				case 1:
				case 2:
					T2WAtU5farDXovQgZMsw(this);
					num = 4;
					break;
				default:
					_003C_003El__initialThreadId = qwWKKh5feycmy4I6g7cH();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 5:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					_ = 1;
					num = ((!fwElKe5fJvRbkt58KJed()) ? 2 : 0);
					break;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
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
			goto IL_0051;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = ((!GM0ukx5fwYhn3ohWGyQZ()) ? 3 : 4);
			goto IL_0051;
			IL_0051:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					if (num2 != -3)
					{
						goto default;
					}
					goto case 5;
				default:
					if ((uint)(num2 - 1) <= 1u)
					{
						num = 5;
						if (fwElKe5fJvRbkt58KJed())
						{
						}
						continue;
					}
					return;
				case 5:
					try
					{
						return;
					}
					finally
					{
						_003C_003Em__Finally1();
					}
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bool result = default;
			try
			{
				int num = _003C_003E1__state;
				int num2 = 2;
				if (false)
				{
					goto IL_0021;
				}
				goto IL_0168;
				IL_0021:
				result = true;
				num2 = 3;
				goto IL_0168;
				IL_0168:
				FormatStringArgViewModel current = default;
				while (true)
				{
					switch (num2)
					{
					case 16:
						break;
					case 11:
						_003C_003E7__wrap1 = arguments.GetEnumerator();
						_003C_003E1__state = -3;
						goto case 8;
					case 10:
					case 12:
						_003C_003E1__state = 2;
						num2 = 15;
						continue;
					case 1:
					case 5:
						goto end_IL_0168;
					case 9:
						_003C_003E2__current = current;
						num2 = 6;
						if (0 == 0)
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Em__Finally1();
						num2 = 0;
						continue;
					case 4:
						if (s4diQnZJml(snippet, current))
						{
							num2 = 9;
							continue;
						}
						if (LcdigROtWq(snippet, current))
						{
							num2 = 13;
							continue;
						}
						goto case 8;
					case 14:
						goto end_IL_0168;
					case 8:
						if (WDp6jm5fO9kKUnEgmZVq(_003C_003E7__wrap1))
						{
							current = _003C_003E7__wrap1.Current;
							num2 = 4;
							continue;
						}
						num2 = 7;
						if (GM0ukx5fwYhn3ohWGyQZ())
						{
							continue;
						}
						goto case 13;
					case 13:
						_003C_003E2__current = current;
						goto case 10;
					case 2:
						switch (num)
						{
						case 0:
							_003C_003E1__state = -1;
							num2 = 11;
							continue;
						case 2:
							_003C_003E1__state = -3;
							break;
						default:
							result = false;
							fwElKe5fJvRbkt58KJed();
							num2 = (GM0ukx5fwYhn3ohWGyQZ() ? 5 : 12);
							continue;
						case 1:
							_003C_003E1__state = -3;
							break;
						}
						goto case 8;
					case 6:
						_003C_003E1__state = 1;
						num2 = 16;
						continue;
					case 3:
						goto end_IL_0168;
					default:
						num2 = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						_003C_003E7__wrap1 = null;
						num2 = 17;
						continue;
					case 15:
						result = true;
						num2 = 14;
						continue;
					case 17:
						result = false;
						goto end_IL_0168;
					}
					goto IL_0021;
					continue;
					end_IL_0168:
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _003C_003Em__Finally1()
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
					vQVAaH5fIFVVF7YAgW4Y(_003C_003E7__wrap1);
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					if (_003C_003E7__wrap1 != null)
					{
						goto default;
					}
					return;
				case 4:
					_003C_003E1__state = -1;
					fwElKe5fJvRbkt58KJed();
					num = ((!GM0ukx5fwYhn3ohWGyQZ()) ? 3 : 0);
					break;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<FormatStringArgViewModel> IEnumerable<FormatStringArgViewModel>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetArgumentsInSnippet_003Ed__6 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetArgumentsInSnippet_003Ed__6(0);
			}
			obj.arguments = _003C_003E3__arguments;
			obj.snippet = _003C_003E3__snippet;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<FormatStringArgViewModel>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T2WAtU5farDXovQgZMsw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int qwWKKh5feycmy4I6g7cH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GM0ukx5fwYhn3ohWGyQZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fwElKe5fJvRbkt58KJed()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WDp6jm5fO9kKUnEgmZVq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vQVAaH5fIFVVF7YAgW4Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}
	}

	private static ILogger HbXiMM06Po;

	public abstract EzFormatStringViewModel FormatString { get; set; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzFormatStringSupportSnippet(AppStepViewModel appStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		p6VBBoce4f8kWnjuw6y();
		base._002Ector(appStepVm, localizer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSupportSnippetReferencesAsync_003Ed__5))]
	public Task RemoveSupportSnippetReferencesAsync(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		f4YxBZcJiNHlG3LefZu();
		int num = (dfmUSqcakwWoN2jp50v() ? 4 : 2);
		_003CRemoveSupportSnippetReferencesAsync_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine.e = e;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = dsYqUqcO6ojAAcOk4u1();
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetArgumentsInSnippet_003Ed__6))]
	private static IEnumerable<FormatStringArgViewModel> nNnicZbNGL(IEnumerable<FormatStringArgViewModel> P_0, EzSnippet P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetArgumentsInSnippet_003Ed__6(-2)
		{
			_003C_003E3__arguments = P_0,
			_003C_003E3__snippet = P_1
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EzFormatStringSupportSnippet()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		p6VBBoce4f8kWnjuw6y();
		HbXiMM06Po = LogManager.GetLogger<EzFormatStringSupportSnippet>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static bool s4diQnZJml(EzSnippet P_0, FormatStringArgViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bool result = default;
		try
		{
			CvsCellRange range = default;
			if (((P_1 != null) ? F711VMcI1S0nRn8iXVk(P_1) : null) != null)
			{
				range = SZ6NDYcipA8CkM5yEmw(CUM2kCcDEbTYqV4ycja(P_1.LocationViewModel));
				goto IL_0096;
			}
			result = false;
			_ = 0;
			int num;
			if (!f4YxBZcJiNHlG3LefZu())
			{
				num = 3;
				if (true)
				{
					goto IL_006b;
				}
				goto IL_0096;
			}
			num = 2;
			if (f4YxBZcJiNHlG3LefZu())
			{
				goto IL_006b;
			}
			goto end_IL_000e;
			IL_00a9:
			CvsCellRange cvsCellRange = default;
			result = cvsCellRange.Contains(range);
			goto end_IL_000e;
			IL_0096:
			cvsCellRange = nuQmB9cn1ECchDWeGXG(P_0);
			num = 4;
			if (0 == 0)
			{
				goto IL_006b;
			}
			goto IL_00a9;
			IL_006b:
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto IL_0096;
			case 4:
				goto IL_00a9;
			}
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			epYKydcffyFAlJLDiyU(HbXiMM06Po, LogLevel.Error, b5PR0FcVIqUlo6hAKqf(29526), ex);
			result = false;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static bool LcdigROtWq(EzSnippet P_0, FormatStringArgViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (!igSVK3cl0cmXqnVvOTq(AgZ1OpcdvgFSMKdZ6w7(P_0)))
			{
				return u4gjH2csOPVtena3WJl(new Regex(CdQUGaROfy7He9T0foW.KbIzwHEDLa(29566) + P_0.CellNamePrefix + CdQUGaROfy7He9T0foW.KbIzwHEDLa(29572)), JGx1OacgV1ITdA88LYs(P_1));
			}
			dfmUSqcakwWoN2jp50v();
			int num;
			if (f4YxBZcJiNHlG3LefZu())
			{
				num = 2;
				if (false)
				{
					goto IL_003a;
				}
				goto IL_004e;
			}
			num = 3;
			if (f4YxBZcJiNHlG3LefZu())
			{
				goto IL_004e;
			}
			goto end_IL_000e;
			IL_004e:
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				goto end_IL_000e;
			case 3:
				goto end_IL_000e;
			}
			goto IL_003a;
			IL_003a:
			return false;
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			HbXiMM06Po.LogException(LogLevel.Error, (string)b5PR0FcVIqUlo6hAKqf(29580), ex);
			return false;
		}
		bool result = default;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p6VBBoce4f8kWnjuw6y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f4YxBZcJiNHlG3LefZu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dfmUSqcakwWoN2jp50v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder dsYqUqcO6ojAAcOk4u1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F711VMcI1S0nRn8iXVk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgViewModel)P_0).LocationViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CUM2kCcDEbTYqV4ycja(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ReferenceRangeTextBoxViewModel)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange SZ6NDYcipA8CkM5yEmw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsReferenceRange)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange nuQmB9cn1ECchDWeGXG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).CellRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b5PR0FcVIqUlo6hAKqf(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void epYKydcffyFAlJLDiyU(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AgZ1OpcdvgFSMKdZ6w7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).CellNamePrefix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool igSVK3cl0cmXqnVvOTq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JGx1OacgV1ITdA88LYs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u4gjH2csOPVtena3WJl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Regex)P_0).IsMatch((string)P_1);
	}
}
