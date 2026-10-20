using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Undo;

public class UndoClearContent : UndoRangeAction, IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRedo_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearContent _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (RPSh6tscY0XCEvtdo2Xq() ? 1 : 4);
			int num2 = default;
			UndoClearContent undoClearContent = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 3:
					undoClearContent = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (RPSh6tscY0XCEvtdo2Xq())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							GZesQPscx0i52QC8ux7C(undoClearContent.StoredRanges[0]);
							num3 = 7;
							goto IL_00d1;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0084;
						IL_0084:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_00d1;
						IL_00d1:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 6:
								break;
							case 5:
								return;
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 7:
								I1rgIWscrrIyowscrYSd(WKCL7asc1GmB9PuLjM00(undoClearContent.InSight.CogSocket), undoClearContent.Range);
								num3 = 8;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (!c9DUsJscNkc6vgFHtU4i())
									{
										continue;
									}
									goto case 3;
								}
								goto case 10;
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 8:
								awaiter = w99vVAscOhmLqmCc3FPo(BBQRr3sc3Ly9o26JTqqM());
								_ = 0;
								num3 = (RPSh6tscY0XCEvtdo2Xq() ? 1 : 4);
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_00d1;
							}
							goto IL_0084;
							continue;
							end_IL_00d1:
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
		internal static void GZesQPscx0i52QC8ux7C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).DeleteExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WKCL7asc1GmB9PuLjM00(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void I1rgIWscrrIyowscrYSd(object P_0, CvsCellRange location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocketSheet)P_0).ClearCellsContentsAndRun(location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BBQRr3sc3Ly9o26JTqqM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter w99vVAscOhmLqmCc3FPo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RPSh6tscY0XCEvtdo2Xq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c9DUsJscNkc6vgFHtU4i()
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
	private struct _003CUndo_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoClearContent _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vMRNxvscMnAGeKYmgjiV();
			int num;
			if (!NS37xQscQBSgaVpV0IRh())
			{
				num = 5;
				if (!vMRNxvscMnAGeKYmgjiV())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01bf;
			IL_002e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01bf;
			IL_01bf:
			UndoClearContent undoClearContent = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 3:
					undoClearContent = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = LcIJpusclZqYKOeRok4m(undoClearContent.g4QlMQgItf());
							vMRNxvscMnAGeKYmgjiV();
							if (!NS37xQscQBSgaVpV0IRh())
							{
								num3 = 4;
								if (!vMRNxvscMnAGeKYmgjiV())
								{
									goto IL_008c;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (1 == 0)
							{
								goto IL_00de;
							}
						}
						goto IL_0114;
						IL_0114:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 2:
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 8:
								return;
							case 0:
							case 4:
								goto IL_00de;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 7:
								goto IL_0168;
							case 10:
								xWJymVsceUBWbyDT1Wh5(undoClearContent.StoredRanges[0]);
								goto end_IL_005a;
							}
							break;
						}
						goto IL_008c;
						IL_008c:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_0114;
						IL_00de:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							goto IL_0114;
						}
						goto IL_0168;
						IL_0168:
						awaiter.GetResult();
						num3 = 10;
						goto IL_0114;
						end_IL_005a:;
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
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static TaskAwaiter LcIJpusclZqYKOeRok4m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xWJymVsceUBWbyDT1Wh5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((StoredRange)P_0).RestoreExternalData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vMRNxvscMnAGeKYmgjiV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NS37xQscQBSgaVpV0IRh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private List<CvsCogCellResult> GW2loYQi6f;

	protected CvsCellRange Range
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return StoredRanges[0].Range;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)NBqXTD7ieOypCtIODDS(RRSDBB7dYH2jccVcW5d(), Range.ToString());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoClearContent(CvsInSight inSight, CvsCellRange cellRange, List<CvsCogCellResult> list)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(inSight, cellRange);
		GW2loYQi6f = list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__6))]
	public override Task Redo()
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
		goto IL_0086;
		IL_006c:
		_003CRedo_003Ed__6 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0032;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 3:
				goto IL_0032;
			case 0:
				goto IL_004a;
			case 2:
			case 5:
				goto IL_006c;
			default:
				num = 3;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_004a:
			stateMachine._003C_003Et__builder = qlaD1e7qyRdWau2YQQg();
			_ = 0;
			num = (rpTSIX7UwD5nE4DiH4Y() ? 4 : 5);
		}
		goto IL_001a;
		IL_0032:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0086;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__7))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0064;
		IL_004a:
		_003CUndo_003Ed__7 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0032;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				goto IL_0032;
			case 0:
			case 2:
				goto IL_004a;
			default:
				num = 5;
				if (rpTSIX7UwD5nE4DiH4Y())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				rpTSIX7UwD5nE4DiH4Y();
				num = ((!MAITf97TA3fbKsAU8Hd()) ? 4 : 0);
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0032:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0064;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_004a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task g4QlMQgItf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rpTSIX7UwD5nE4DiH4Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MAITf97TA3fbKsAU8Hd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RRSDBB7dYH2jccVcW5d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.UndoActionClearContent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NBqXTD7ieOypCtIODDS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder qlaD1e7qyRdWau2YQQg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
