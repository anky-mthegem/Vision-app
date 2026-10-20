using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.Runtime;

namespace kp16K3byhUkqwMQDFZ;

internal sealed class JHLvFIyVUX9ZfVXh6y : IAsyncDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPause_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public JHLvFIyVUX9ZfVXh6y _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JPvaOqKiduCHqO48FW48();
			int num;
			if (!v5hOZ2Kil6mUIaKnHDjY())
			{
				num = 1;
				if (v5hOZ2Kil6mUIaKnHDjY())
				{
				}
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0077;
				}
			}
			goto IL_01c2;
			IL_0049:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c2;
			IL_0077:
			JHLvFIyVUX9ZfVXh6y jHLvFIyVUX9ZfVXh6y = default;
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				if (num2 == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0180;
				}
				bool flag = false;
				object siDpl5LesJ = jHLvFIyVUX9ZfVXh6y.SiDpl5LesJ;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(siDpl5LesJ, ref lockTaken);
					v5hOZ2Kil6mUIaKnHDjY();
					switch ((!JPvaOqKiduCHqO48FW48()) ? 3 : 2)
					{
					case 0:
					case 2:
						if (jGNpTIRrgB++ == 0)
						{
							break;
						}
						goto end_IL_0089;
					}
					flag = true;
					end_IL_0089:;
				}
				finally
				{
					if (num2 < 0 && lockTaken)
					{
						Monitor.Exit(siDpl5LesJ);
					}
				}
				if (flag && jHLvFIyVUX9ZfVXh6y.iRVpRQ8xt5 != null)
				{
					awaiter = Qsq5APKisawo7HWBbtSq(bbAuqjKigNU1GM2FVNmP(jHLvFIyVUX9ZfVXh6y.iRVpRQ8xt5));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0180;
				}
				goto end_IL_0077;
				IL_0180:
				awaiter.GetResult();
				end_IL_0077:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0049;
			IL_01c2:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					if (!v5hOZ2Kil6mUIaKnHDjY())
					{
						continue;
					}
					break;
				case 5:
					break;
				case 3:
					jHLvFIyVUX9ZfVXh6y = _003C_003E4__this;
					goto IL_0077;
				case 2:
				case 4:
					goto IL_0077;
				default:
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0049;
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
		internal static object bbAuqjKigNU1GM2FVNmP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).Pause();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Qsq5APKisawo7HWBbtSq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JPvaOqKiduCHqO48FW48()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v5hOZ2Kil6mUIaKnHDjY()
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
	private struct _003CDisposeAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public JHLvFIyVUX9ZfVXh6y _003C_003E4__this;

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
			if (vtLvmlKivwjFE3yah0oC())
			{
				num = 1;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0182;
			IL_01b3:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0182;
			IL_0182:
			JHLvFIyVUX9ZfVXh6y jHLvFIyVUX9ZfVXh6y = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_01b3;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (vtLvmlKivwjFE3yah0oC())
					{
						continue;
					}
					goto case 4;
				case 4:
					jHLvFIyVUX9ZfVXh6y = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				TaskAwaiter awaiter;
				if (num2 == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0133;
				}
				bool flag = false;
				object siDpl5LesJ = jHLvFIyVUX9ZfVXh6y.SiDpl5LesJ;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(siDpl5LesJ, ref lockTaken);
					Td9QTVKirxe0UrCJtklp();
					int num3;
					if (vtLvmlKivwjFE3yah0oC())
					{
						num3 = 2;
						if (1 == 0)
						{
							goto IL_005c;
						}
					}
					else
					{
						num3 = 3;
						if (false)
						{
							goto IL_00a7;
						}
					}
					switch (num3)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_00a7;
					}
					goto IL_005c;
					IL_00a7:
					flag = true;
					goto end_IL_0038;
					IL_005c:
					if (--jGNpTIRrgB == 0)
					{
						goto IL_00a7;
					}
					end_IL_0038:;
				}
				finally
				{
					if (num2 < 0 && lockTaken)
					{
						CyXF9xKiPcQ6XncP6H8I(siDpl5LesJ);
					}
				}
				if (flag && jHLvFIyVUX9ZfVXh6y.iRVpRQ8xt5 != null)
				{
					awaiter = ((Task)ysOoYLKiZpCdJ8OP4sqy(jHLvFIyVUX9ZfVXh6y.iRVpRQ8xt5)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0133;
				}
				goto end_IL_0026;
				IL_0133:
				awaiter.GetResult();
				lcmY6oKiBgF0IP1T7whr(jHLvFIyVUX9ZfVXh6y.D3Yp4mh551, true, false);
				end_IL_0026:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b3;
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
		internal static void CyXF9xKiPcQ6XncP6H8I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Monitor.Exit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ysOoYLKiZpCdJ8OP4sqy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).Unpause();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lcmY6oKiBgF0IP1T7whr(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vtLvmlKivwjFE3yah0oC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Td9QTVKirxe0UrCJtklp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IRuntimeService iRVpRQ8xt5;

	private CvsInSight D3Yp4mh551;

	private object SiDpl5LesJ;

	private static int jGNpTIRrgB;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal JHLvFIyVUX9ZfVXh6y(IRuntimeService P_0, CvsInSight P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 5:
				D3Yp4mh551 = P_1;
				num = 7;
				if (KoIFFswa5odQZfmK8VX())
				{
					break;
				}
				goto default;
			default:
				iRVpRQ8xt5 = P_0;
				num = 5;
				break;
			case 0:
			case 1:
				SiDpl5LesJ = new object();
				num = 6;
				break;
			case 2:
				M0er9owOFihFd4fU3QR();
				_ = 1;
				if (!uLgyrrwepA5nUIxNphK())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto case 6;
				}
				num = 4;
				break;
			case 6:
				K9e0yywIdflYGq95T6i(this);
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPause_003Ed__5))]
	internal Task rotpMsombT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CPause_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				uLgyrrwepA5nUIxNphK();
				if (!KoIFFswa5odQZfmK8VX())
				{
					num = 0;
					if (KoIFFswa5odQZfmK8VX())
					{
						continue;
					}
					goto case 4;
				}
				num = 5;
				if (true)
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
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__6))]
	public ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDisposeAsync_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (KoIFFswa5odQZfmK8VX() ? 1 : 0);
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = VliHYIwDPgUKSy02jLh();
				num = 5;
				break;
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
	internal static void M0er9owOFihFd4fU3QR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K9e0yywIdflYGq95T6i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KoIFFswa5odQZfmK8VX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uLgyrrwepA5nUIxNphK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder VliHYIwDPgUKSy02jLh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}
}
