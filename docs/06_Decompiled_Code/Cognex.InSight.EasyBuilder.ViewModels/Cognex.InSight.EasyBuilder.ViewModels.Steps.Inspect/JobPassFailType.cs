using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;

public class JobPassFailType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public JobPassFailType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private JobPassFail _003CjobPassFail_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			JobPassFailType jobPassFailType = default;
			EzSupportSnippet result = default;
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
							if (num2 != 1)
							{
								num3 = 4;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 1;
								if (YVqbIlKGGLPtnvMUiHed())
								{
									goto IL_01dc;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_015c;
						IL_015c:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 10:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 8;
									continue;
								}
								goto IL_0215;
							case 8:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								if (YVqbIlKGGLPtnvMUiHed())
								{
								}
								continue;
							case 3:
							case 16:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 6:
								return;
							case 7:
								_003C_003Eu__1 = awaiter2;
								num3 = 13;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 11;
								if (tUgKoXKGb9yeYJ0n9rjP())
								{
									continue;
								}
								goto case 12;
							case 12:
								awaiter = ((ResourceNode)hiwjOmKGqEEQDZ92NLAA(rUjyTvKG8k5bRFafa0iK(Re3AEoKGk5qDdR1puj4t(jobPassFailType)))).PutAsync<object>((string)AofR4RKGEdRuNyP8DIl1(48734), (object)jMcFAcKGXZPg7JRGWBIo(SPuNeQKGpUTK6RApWDnL(_003CjobPassFail_003E5__2)).ToString()).GetAwaiter();
								goto case 0;
							case 14:
								awaiter2 = UfZoVNKGSubVelPPmJaJ(S0gl9jKGovUqHYxGGv8h(_003CjobPassFail_003E5__2, cells, cellRange));
								num3 = 5;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								goto case 15;
							default:
								num3 = 15;
								continue;
							case 11:
								return;
							case 5:
								break;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto IL_0215;
							case 4:
								_003CjobPassFail_003E5__2 = new JobPassFail(jobPassFailType.Parent);
								num3 = 14;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto IL_024b;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 6;
								if (YVqbIlKGGLPtnvMUiHed())
								{
								}
								continue;
							case 17:
								{
									result = _003CjobPassFail_003E5__2;
									goto end_IL_0018;
								}
								IL_0215:
								awaiter.GetResult();
								num3 = 17;
								continue;
							}
							break;
						}
						goto IL_01dc;
						IL_024b:
						awaiter2.GetResult();
						num3 = 12;
						goto IL_015c;
						IL_01dc:
						if (!awaiter2.IsCompleted)
						{
							tUgKoXKGb9yeYJ0n9rjP();
							if (YVqbIlKGGLPtnvMUiHed())
							{
								num3 = 0;
							}
							else
							{
								num3 = 16;
								if (YVqbIlKGGLPtnvMUiHed())
								{
								}
							}
							goto IL_015c;
						}
						goto IL_024b;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CjobPassFail_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_ = 0;
					num = ((!tUgKoXKGb9yeYJ0n9rjP()) ? 2 : 0);
					continue;
				case 6:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 0:
				case 3:
					_003CjobPassFail_003E5__2 = null;
					break;
				case 1:
					jobPassFailType = _003C_003E4__this;
					num = 5;
					continue;
				case 2:
				case 4:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object S0gl9jKGovUqHYxGGv8h(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UfZoVNKGSubVelPPmJaJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Re3AEoKGk5qDdR1puj4t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rUjyTvKG8k5bRFafa0iK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hiwjOmKGqEEQDZ92NLAA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).CameraResourceNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AofR4RKGEdRuNyP8DIl1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SPuNeQKGpUTK6RApWDnL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JobPassFail)P_0).Pass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation jMcFAcKGXZPg7JRGWBIo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tUgKoXKGb9yeYJ0n9rjP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YVqbIlKGGLPtnvMUiHed()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__6 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public JobPassFailType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		private string _003Cname_003E5__4;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
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
		public _003CGetUpdates_003Ed__6(int _003C_003E1__state)
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
			goto IL_007b;
			IL_0062:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_004d;
			IL_007b:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 4:
					goto IL_0030;
				case 5:
					goto IL_004d;
				case 2:
				case 3:
					goto IL_0062;
				default:
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
				IL_0030:
				oAYg3hKG75Vixmnw93JA();
				_ = 0;
				if (!eMFvnMKG9PCuMh4F0Pbq())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				goto IL_004d;
			}
			goto IL_001a;
			IL_004d:
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
			num = 6;
			goto IL_007b;
			IL_001a:
			KNgLspKG3MWApkPZgQny(this);
			goto IL_0062;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 19;
			CvsCellLocation offset = default;
			JobPassFailType jobPassFailType = default;
			CvsCellLocation offset2 = default;
			CvsCellLocation offset5 = default;
			int num2 = default;
			CvsCellLocation offset4 = default;
			CvsCellLocation offset3 = default;
			while (true)
			{
				CvsCellLocation offset6;
				CvsCellLocation offset7;
				switch (num)
				{
				case 23:
					_003C_003E1__state = 9;
					return true;
				case 25:
					_003C_003E2__current = new AddCellUpdate(offset, jobPassFailType.KeadMAkpuu, jobPassFailType.Localizer);
					_003C_003E1__state = 2;
					return true;
				case 16:
					_003C_003E1__state = 3;
					num = 6;
					continue;
				case 38:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 3;
						if (eMFvnMKG9PCuMh4F0Pbq())
						{
							continue;
						}
						goto case 32;
					}
					goto case 8;
				case 32:
					_003C_003E2__current = new EditArgumentUpdate(offset2, ssfdRUjDcr, 0, null);
					num = 23;
					if (true)
					{
						continue;
					}
					goto case 12;
				case 12:
					jobPassFailType = _003C_003E4__this;
					num = 18;
					continue;
				case 0:
					return true;
				case 20:
					return true;
				case 7:
					offset5 = new CvsCellLocation(1, 3);
					num = 4;
					continue;
				case 14:
				{
					CvsCellLocation offset9 = new CvsCellLocation(1, 6);
					_003C_003E2__current = new EditArgumentUpdate(offset9, ssfdRUjDcr, 0, null);
					_003C_003E1__state = 6;
					num = 1;
					if (!JoYQQXKG4wXP7ypQQ8Sn())
					{
						continue;
					}
					goto case 35;
				}
				case 35:
					_003CcurrentVersion_003E5__2 = rHsJL0KGjUDVUuukdwuo(cells, range);
					_003ClatestVersion_003E5__3 = Sug1CbKG6Rma4u7cfSoP(jobPassFailType.m94dl6BWu5);
					num = 13;
					continue;
				case 19:
					num2 = _003C_003E1__state;
					num = 12;
					if (true)
					{
						continue;
					}
					goto case 27;
				case 27:
					return true;
				case 37:
					return true;
				case 26:
					return true;
				case 1:
					return true;
				case 13:
					_003Cname_003E5__4 = SnippetPasteBuffer.GetSupportSnippetName(jobPassFailType.m94dl6BWu5);
					num = 38;
					continue;
				case 5:
					return false;
				case 17:
					offset4 = new CvsCellLocation(2, 7);
					num = 33;
					if (true)
					{
						continue;
					}
					goto case 18;
				case 18:
					switch (num2)
					{
					case 9:
						break;
					case 2:
						goto IL_0061;
					case 8:
						goto IL_00e0;
					case 4:
						goto IL_00f3;
					case 7:
						goto IL_01c5;
					case 1:
						goto IL_01d8;
					case 11:
						goto IL_01eb;
					case 6:
						goto IL_01fe;
					case 0:
						goto IL_0235;
					default:
						goto IL_0291;
					case 5:
						goto IL_0343;
					case 3:
						goto IL_0469;
					case 10:
						goto IL_0511;
					}
					_003C_003E1__state = -1;
					goto case 9;
				case 9:
				case 31:
				{
					CvsCellLocation offset8 = new CvsCellLocation(4, 7);
					_003C_003E2__current = new EditArgumentUpdate(offset8, ssfdRUjDcr, 0, null);
					_003C_003E1__state = 10;
					num = 36;
					continue;
				}
				case 30:
					_003C_003E1__state = 8;
					num = 0;
					continue;
				case 8:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						JoYQQXKG4wXP7ypQQ8Sn();
						if (!eMFvnMKG9PCuMh4F0Pbq())
						{
							num = 9;
							continue;
						}
						num = 22;
						if (JoYQQXKG4wXP7ypQQ8Sn())
						{
						}
						continue;
					}
					goto case 24;
				case 15:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, jobPassFailType.Localizer, _003Cname_003E5__4);
					num = 21;
					continue;
				case 28:
					_003C_003E1__state = 5;
					return true;
				default:
					num = 14;
					continue;
				case 34:
					_003C_003E1__state = 7;
					num = 27;
					continue;
				case 2:
					_003C_003E2__current = new EditArgumentUpdate(offset3, ssfdRUjDcr, 0, null);
					num = 34;
					continue;
				case 21:
					_003C_003E1__state = 11;
					num = 26;
					continue;
				case 29:
					_003C_003E1__state = 1;
					num = 37;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					return true;
				case 10:
					offset2 = new CvsCellLocation(3, 7);
					num = 32;
					continue;
				case 3:
					_003C_003E2__current = new AddCellVersionUpdate(1, jobPassFailType.Localizer, _003Cname_003E5__4);
					num = 29;
					if (eMFvnMKG9PCuMh4F0Pbq())
					{
						continue;
					}
					goto case 11;
				case 11:
				case 22:
					offset = new CvsCellLocation(1, 2);
					num = 25;
					continue;
				case 24:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 15;
						continue;
					}
					break;
				case 36:
					return true;
				case 33:
					_003C_003E2__current = new EditArgumentUpdate(offset4, ssfdRUjDcr, 0, null);
					num = 30;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					_003C_003E2__current = new EditArgumentUpdate(offset5, ssfdRUjDcr, 0, null);
					num = 16;
					continue;
				case 39:
					break;
					IL_0511:
					_003C_003E1__state = -1;
					num = 24;
					if (eMFvnMKG9PCuMh4F0Pbq())
					{
						continue;
					}
					goto case 33;
					IL_0469:
					_003C_003E1__state = -1;
					offset6 = new CvsCellLocation(1, 4);
					_003C_003E2__current = new EditArgumentUpdate(offset6, ssfdRUjDcr, 0, null);
					_003C_003E1__state = 4;
					num = 20;
					continue;
					IL_0343:
					_003C_003E1__state = -1;
					goto case 14;
					IL_0291:
					num = 5;
					continue;
					IL_0235:
					_003C_003E1__state = -1;
					num = 35;
					continue;
					IL_01fe:
					_003C_003E1__state = -1;
					offset3 = new CvsCellLocation(1, 7);
					num = 2;
					continue;
					IL_01eb:
					_003C_003E1__state = -1;
					num = 39;
					continue;
					IL_01d8:
					_003C_003E1__state = -1;
					num = 8;
					continue;
					IL_01c5:
					_003C_003E1__state = -1;
					num = 17;
					continue;
					IL_00f3:
					_003C_003E1__state = -1;
					offset7 = new CvsCellLocation(1, 5);
					_003C_003E2__current = new EditArgumentUpdate(offset7, ssfdRUjDcr, 0, null);
					num = 28;
					if (eMFvnMKG9PCuMh4F0Pbq())
					{
						continue;
					}
					goto case 7;
					IL_00e0:
					_003C_003E1__state = -1;
					num = 10;
					continue;
					IL_0061:
					_003C_003E1__state = -1;
					num = 7;
					if (!JoYQQXKG4wXP7ypQQ8Sn())
					{
						continue;
					}
					goto case 16;
				}
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
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
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__6 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__6(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
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
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oAYg3hKG75Vixmnw93JA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KNgLspKG3MWApkPZgQny(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eMFvnMKG9PCuMh4F0Pbq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JoYQQXKG4wXP7ypQQ8Sn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rHsJL0KGjUDVUuukdwuo(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Sug1CbKG6Rma4u7cfSoP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] VK6d4AV9eu;

	private readonly PasteBuffer m94dl6BWu5;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VK6d4AV9eu;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JobPassFailType(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00b2;
		IL_0048:
		AddSnippet(m94dl6BWu5);
		num = 7;
		if (q1FviLfaB8N7Nisrd56())
		{
			goto IL_0064;
		}
		goto IL_00b2;
		IL_00b2:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
				goto IL_0048;
			default:
				goto IL_0064;
			case 6:
				goto IL_007e;
			case 4:
				base._002Ector(appStepVm);
				goto IL_0064;
			case 7:
				return;
			}
			break;
			IL_007e:
			cmU6D1fe5XRLIaYikqd();
			_ = 0;
			num = ((!r5S6lFfJbBpdJXFKFXo()) ? 2 : 5);
		}
		goto IL_001a;
		IL_0064:
		m94dl6BWu5 = (PasteBuffer)K899c7fDbMG5sMtxSk9(gIh4lofIlIaQe7NhcDe());
		num = 0;
		goto IL_00b2;
		IL_001a:
		VK6d4AV9eu = new Guid[1]
		{
			new Guid((string)YZK1w4fO3g5BZKfCVh5(4852))
		};
		num = 4;
		if (false)
		{
			goto IL_0048;
		}
		goto IL_00b2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateSupportSnippet_003Ed__5))]
	public override Task<EzSupportSnippet> CreateSupportSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateSupportSnippet_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__6))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__6(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell KeadMAkpuu(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell cellInTool = SnippetPasteBuffer.GetCellInTool(m94dl6BWu5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928), isInternal: true, isSupportSnippet: true);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(new CvsCellLocation(Utp5dificKZfQBbivFE(P_0).Row + 1, Utp5dificKZfQBbivFE(P_0).Column + 2));
		FdQoCufVmkeIDaAoCXY(pasteBufferCell, ((EasyBuilderApplicationViewModel)lXHButfnWNffuqonduY(Parent)).Acquired2DImageLocation.ToString(absoluteRow: true, absoluteColumn: true));
		fhUM4lffpEpSLPoVhbc(pasteBufferCell, cellInTool.Name);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ssfdRUjDcr(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellLocation(SnippetPasteBuffer.GetCellInTool(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928), isInternal: true, isSupportSnippet: true)?.Location).ToString(absoluteRow: true, absoluteColumn: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cmU6D1fe5XRLIaYikqd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YZK1w4fO3g5BZKfCVh5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gIh4lofIlIaQe7NhcDe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.JobPassFail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K899c7fDbMG5sMtxSk9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool r5S6lFfJbBpdJXFKFXo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q1FviLfaB8N7Nisrd56()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Utp5dificKZfQBbivFE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lXHButfnWNffuqonduY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FdQoCufVmkeIDaAoCXY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fhUM4lffpEpSLPoVhbc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}
}
