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
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class FactoryProtocolType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public FactoryProtocolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private FactoryProtocol _003CfactoryProtocol_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dtTGAL5ICpV3GZmkIalW();
			int num;
			if (UegDRZ5I6xGltMAViiAd())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_01f2;
			IL_002a:
			FactoryProtocolType factoryProtocolType = _003C_003E4__this;
			num = 1;
			goto IL_01f2;
			IL_01f2:
			EzSupportSnippet result = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 4:
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CfactoryProtocol_003E5__2 = new FactoryProtocol((CommStepViewModel)factoryProtocolType.Parent);
							num3 = 0;
							if (1 == 0)
							{
								goto IL_0079;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							if (dtTGAL5ICpV3GZmkIalW())
							{
							}
						}
						goto IL_0164;
						IL_0091:
						awaiter.GetResult();
						num3 = 10;
						goto IL_0164;
						IL_0164:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 2:
							case 7:
								goto IL_0091;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 0:
								awaiter = ((Task)g68Q7u5IABDJObvsf4sK(_003CfactoryProtocol_003E5__2, cells, cellRange)).GetAwaiter();
								num3 = 8;
								if (UegDRZ5I6xGltMAViiAd())
								{
									continue;
								}
								goto case 4;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_0091;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								goto IL_0129;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								if (dtTGAL5ICpV3GZmkIalW())
								{
								}
								continue;
							case 10:
								result = _003CfactoryProtocol_003E5__2;
								goto end_IL_0051;
							}
							break;
							IL_0129:
							_003C_003Eu__1 = default;
							_ = 1;
							num3 = ((!dtTGAL5ICpV3GZmkIalW()) ? 4 : 2);
						}
						goto IL_0079;
						IL_0079:
						if (!awaiter.IsCompleted)
						{
							num3 = 5;
							if (0 == 0)
							{
								goto IL_0164;
							}
						}
						goto IL_0091;
						end_IL_0051:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CfactoryProtocol_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 5:
					_003CfactoryProtocol_003E5__2 = null;
					goto case 4;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object g68Q7u5IABDJObvsf4sK(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UegDRZ5I6xGltMAViiAd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dtTGAL5ICpV3GZmkIalW()
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

		public FactoryProtocolType _003C_003E4__this;

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
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0033;
			IL_001a:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_006e;
			IL_0033:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_006e;
				case 5:
					goto IL_0083;
				case 1:
				case 4:
					aDotwo5IyYWxrUsW9p5x(this);
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
				IL_0083:
				q2tk405ITfZWnJwCqLpp();
				_ = 0;
				if (!UCQIAp5IR5cRPrmLCX1Q())
				{
					num = 0;
					if (RwEWZl5IWbDTXKoqDUyo())
					{
					}
				}
				else
				{
					num = 4;
				}
			}
			goto IL_001a;
			IL_006e:
			_003C_003El__initialThreadId = rt5u1l5I0Sh3XNaFkANV();
			num = 6;
			goto IL_0033;
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
			int num = 0;
			FactoryProtocolType factoryProtocolType = default;
			int num3 = default;
			int num2 = default;
			string supportSnippetName = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					factoryProtocolType = _003C_003E4__this;
					num = 10;
					if (UCQIAp5IR5cRPrmLCX1Q())
					{
						continue;
					}
					goto case 10;
				case 10:
					if (num3 != 0)
					{
						num = 8;
						continue;
					}
					_003C_003E1__state = -1;
					goto case 5;
				case 2:
					return true;
				case 8:
					do
					{
						if (num3 == 1)
						{
							_003C_003E1__state = -1;
							num = 11;
							continue;
						}
						num = 9;
						break;
					}
					while (false);
					continue;
				case 6:
				case 7:
					_003C_003E1__state = 1;
					num = 2;
					continue;
				case 3:
					_003C_003E2__current = new AddCellVersionUpdate(num2, factoryProtocolType.Localizer, supportSnippetName);
					goto case 6;
				case 9:
					return false;
				default:
					num = 5;
					continue;
				case 5:
				{
					int snippetVersion = cells.GetSnippetVersion(range);
					num2 = N5VUtv5IFAP2fot6xcJy(factoryProtocolType.iuCqplY83B);
					supportSnippetName = (string)cosLPl5IMOn309Xc5YdQ(factoryProtocolType.iuCqplY83B);
					if (snippetVersion >= num2)
					{
						break;
					}
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				case 0:
					num3 = _003C_003E1__state;
					UCQIAp5IR5cRPrmLCX1Q();
					num = ((!RwEWZl5IWbDTXKoqDUyo()) ? 4 : 6);
					continue;
				case 11:
					break;
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
		internal static void q2tk405ITfZWnJwCqLpp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aDotwo5IyYWxrUsW9p5x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rt5u1l5I0Sh3XNaFkANV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UCQIAp5IR5cRPrmLCX1Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RwEWZl5IWbDTXKoqDUyo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int N5VUtv5IFAP2fot6xcJy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cosLPl5IMOn309Xc5YdQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] HC7q5yAaS3;

	private readonly PasteBuffer iuCqplY83B;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HC7q5yAaS3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FactoryProtocolType(CommStepViewModel commStep)
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
			case 3:
				AddSnippet(iuCqplY83B);
				num = 7;
				break;
			case 2:
			case 4:
				base._002Ector(commStep);
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 6:
				HC7q5yAaS3 = new Guid[1]
				{
					new Guid((string)C2j5ErN2P3edOU6WfFF(29240))
				};
				goto case 2;
			case 0:
				iuCqplY83B = (PasteBuffer)jOhX1NN1khGxrODeMYA(HlK8tINcHibIOAyhTo4());
				num = 3;
				break;
			case 5:
				LCpbjYNNMJPqnC5Xiiw();
				zq6Nc0NQFsUHbMVLAgP();
				if (!yI5DdoNm46tRGVNhjCb())
				{
					num = 4;
					if (!zq6Nc0NQFsUHbMVLAgP())
					{
						break;
					}
					goto case 0;
				}
				num = 6;
				if (1 == 0)
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
	internal static void LCpbjYNNMJPqnC5Xiiw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C2j5ErN2P3edOU6WfFF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HlK8tINcHibIOAyhTo4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.FactoryProtocol;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jOhX1NN1khGxrODeMYA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yI5DdoNm46tRGVNhjCb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zq6Nc0NQFsUHbMVLAgP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
