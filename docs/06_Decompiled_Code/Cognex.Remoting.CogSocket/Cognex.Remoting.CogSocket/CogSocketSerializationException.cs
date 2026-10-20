using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using IawbpyxeWauKVJvQ4t;
using Newtonsoft.Json.Linq;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

[Serializable]
public sealed class CogSocketSerializationException : CogSocketException
{
	[CompilerGenerated]
	private JToken ImXiumm1eG;

	public JToken Body
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ImXiumm1eG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ImXiumm1eG = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CogSocketSerializationException(Exception innerException, JToken body)
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
			case 1:
			case 3:
				base._002Ector((string)oWqRBP4PungaBo3xT4f(1100), innerException);
				break;
			case 0:
				AEjibb4FdlFC6tDA0TQ();
				_ = 1;
				num = ((!OFsU2q46KDISheWPCZU()) ? 3 : 4);
				continue;
			case 5:
				return;
			}
			Body = body;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CogSocketSerializationException(SerializationInfo info, StreamingContext context)
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
			case 2:
			case 4:
				if (info != null)
				{
					goto default;
				}
				return;
			default:
				Body = (JToken)DtuPKD4BrD4ZX9q4cu9(info, UNkfE94JEjYP98PsqC.cGFu3AUnFy(1198), typeof(JToken));
				num = 6;
				break;
			case 1:
				base._002Ector(info, context);
				OFsU2q46KDISheWPCZU();
				if (!zZQBTJ49tiK7vebHyw5())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 4;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
				num = 1;
				break;
			case 6:
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
		zZQBTJ49tiK7vebHyw5();
		int num;
		if (!OFsU2q46KDISheWPCZU())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_008f;
			}
		}
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			default:
				goto IL_0028;
			case 3:
				if (info != null)
				{
					goto IL_0028;
				}
				return;
			case 0:
			case 1:
				break;
			case 5:
				return;
			}
			break;
			IL_0028:
			am0o9q4SR8kIFdGrG44(info, oWqRBP4PungaBo3xT4f(1198), Body);
			num = 5;
		}
		goto IL_008f;
		IL_008f:
		mkV7WJ4hLyiFlh2wUkO(this, info, context);
		num = 3;
		goto IL_0060;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AEjibb4FdlFC6tDA0TQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oWqRBP4PungaBo3xT4f(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zZQBTJ49tiK7vebHyw5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OFsU2q46KDISheWPCZU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DtuPKD4BrD4ZX9q4cu9(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mkV7WJ4hLyiFlh2wUkO(object P_0, object P_1, StreamingContext P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void am0o9q4SR8kIFdGrG44(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
