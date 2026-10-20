using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using IawbpyxeWauKVJvQ4t;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

[Serializable]
public sealed class CogSocketErrorResponseReceivedException : CogSocketException
{
	[CompilerGenerated]
	private int ri2pikVgR;

	[CompilerGenerated]
	private object Xmvs2aZgW;

	public int ErrorCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ri2pikVgR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ri2pikVgR = value;
		}
	}

	public object AdditionalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Xmvs2aZgW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Xmvs2aZgW = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketErrorResponseReceivedException(int errorCode, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Up3nA6pQiuU3jfu5b70())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!YUv1YlptbXSfaLpx0Zj())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				base._002Ector(PXmKWRxae(errorCode), innerException);
				break;
			default:
				num = 3;
				if (Up3nA6pQiuU3jfu5b70())
				{
				}
				continue;
			case 3:
				break;
			case 0:
			case 4:
				KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
				goto case 1;
			case 5:
				return;
			}
			ErrorCode = errorCode;
			num = 5;
			if (Up3nA6pQiuU3jfu5b70())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketErrorResponseReceivedException(int errorCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Up3nA6pQiuU3jfu5b70();
		int num = ((!YUv1YlptbXSfaLpx0Zj()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
				goto case 1;
			case 1:
			case 3:
				base._002Ector(PXmKWRxae(errorCode));
				break;
			default:
				num = 2;
				continue;
			case 2:
				break;
			case 5:
				return;
			}
			ErrorCode = errorCode;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketErrorResponseReceivedException(int errorCode, object additionalData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!YUv1YlptbXSfaLpx0Zj()) ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
				AdditionalData = additionalData;
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				ErrorCode = errorCode;
				num = 6;
				continue;
			case 1:
			case 4:
				break;
			case 0:
			case 2:
				VRZBD7psVmq4uuPah1C();
				break;
			case 6:
				return;
			}
			base._002Ector(PXmKWRxae(errorCode, additionalData.ToString()));
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CogSocketErrorResponseReceivedException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YUv1YlptbXSfaLpx0Zj();
		int num;
		if (!Up3nA6pQiuU3jfu5b70())
		{
			num = 3;
			if (Up3nA6pQiuU3jfu5b70())
			{
			}
		}
		else
		{
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				VRZBD7psVmq4uuPah1C();
				num = 1;
				break;
			case 1:
				base._002Ector(info, context);
				goto case 2;
			case 2:
			case 6:
				if (info != null)
				{
					goto case 5;
				}
				return;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				ErrorCode = Rj3QWnp5Ym40SfPHhI6(info, ygj8rfprV6aveypdJft(596));
				num = 4;
				break;
			case 4:
				AdditionalData = r2QwiupyibEtGpohyNZ(info, ygj8rfprV6aveypdJft(618), LXTMSvpulO8xZ9uG4hQ(typeof(object).TypeHandle));
				num = 7;
				if (!YUv1YlptbXSfaLpx0Zj())
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
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
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
		goto IL_007e;
		IL_007e:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 4:
			case 5:
				goto IL_0036;
			case 2:
			case 3:
				fBX9hBp0ygxmtyAf8j6(info, ygj8rfprV6aveypdJft(596), ErrorCode);
				goto IL_00c9;
			default:
				num = 6;
				if (Up3nA6pQiuU3jfu5b70())
				{
				}
				continue;
			case 0:
				base.GetObjectData(info, context);
				num = 1;
				continue;
			case 6:
				goto IL_00c9;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_00c9:
		if (info != null)
		{
			goto IL_0036;
		}
		return;
		IL_0036:
		mFjtgZpjjnH3RF0eNlV(info, ygj8rfprV6aveypdJft(618), AdditionalData);
		num = 7;
		goto IL_007e;
		IL_001a:
		if (info != null)
		{
			_ = 0;
			num = ((!YUv1YlptbXSfaLpx0Zj()) ? 5 : 3);
			goto IL_007e;
		}
		goto IL_00c9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string PXmKWRxae(int P_0, string P_1 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!YUv1YlptbXSfaLpx0Zj())
		{
			goto IL_001e;
		}
		goto IL_009a;
		IL_001e:
		StringBuilder stringBuilder = default;
		stringBuilder.AppendLine((string)ygj8rfprV6aveypdJft(748));
		goto IL_0070;
		IL_009a:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
				goto IL_003f;
			case 4:
			case 6:
				goto IL_0070;
			case 0:
			case 2:
				if (P_1 != null)
				{
					break;
				}
				goto case 7;
			default:
				num = 1;
				if (Up3nA6pQiuU3jfu5b70())
				{
				}
				continue;
			case 5:
				stringBuilder = new StringBuilder();
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stringBuilder.ToString();
			}
			break;
			IL_003f:
			mZnNYvpb0446iVI8BB5(stringBuilder, ygj8rfprV6aveypdJft(650), P_0);
			Up3nA6pQiuU3jfu5b70();
			num = ((!YUv1YlptbXSfaLpx0Zj()) ? 6 : 0);
		}
		goto IL_001e;
		IL_0070:
		VdlX8LpAvuc75QDRu3v(stringBuilder, P_1);
		num = 7;
		goto IL_009a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YUv1YlptbXSfaLpx0Zj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Up3nA6pQiuU3jfu5b70()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VRZBD7psVmq4uuPah1C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ygj8rfprV6aveypdJft(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Rj3QWnp5Ym40SfPHhI6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetInt32((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type LXTMSvpulO8xZ9uG4hQ(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r2QwiupyibEtGpohyNZ(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fBX9hBp0ygxmtyAf8j6(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mFjtgZpjjnH3RF0eNlV(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mZnNYvpb0446iVI8BB5(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VdlX8LpAvuc75QDRu3v(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}
}
