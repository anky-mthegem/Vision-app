using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsSensorAlreadyConnectedException : CvsException
{
	private readonly bool O0bbzCGIdW;

	private readonly bool LawaPl26LS;

	private readonly string XZraImuClE;

	private readonly string Ahfa17gfR4;

	public bool IsRemoteConnection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return O0bbzCGIdW;
		}
	}

	public bool IsMaxGuiConnection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LawaPl26LS;
		}
	}

	public string Username
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XZraImuClE;
		}
	}

	public string Machine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ahfa17gfR4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsSensorAlreadyConnectedException(bool isRemoteConnection, string username, string machine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		iUNCasTSgx3NH3KMMhJ();
		int num;
		if (!HHLBOrTEXSWPNmHJL43())
		{
			num = 10;
			if (HHLBOrTEXSWPNmHJL43())
			{
			}
		}
		else
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 8:
				O0bbzCGIdW = true;
				num = 7;
				if (iUNCasTSgx3NH3KMMhJ())
				{
					continue;
				}
				goto case 2;
			case 2:
				O0bbzCGIdW = isRemoteConnection;
				num = 4;
				continue;
			case 0:
			case 10:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				continue;
			case 6:
				Ahfa17gfR4 = machine;
				num = 11;
				if (!HHLBOrTEXSWPNmHJL43())
				{
					continue;
				}
				goto case 9;
			case 9:
				base._002Ector(pPsb8pO9c9(isRemoteConnection, username, machine));
				break;
			case 7:
				XZraImuClE = "";
				num = 1;
				if (!HHLBOrTEXSWPNmHJL43())
				{
					continue;
				}
				goto case 4;
			case 4:
				XZraImuClE = username;
				num = 6;
				continue;
			case 1:
				Ahfa17gfR4 = "";
				num = 9;
				if (!HHLBOrTEXSWPNmHJL43())
				{
					continue;
				}
				break;
			case 11:
				return;
			}
			OCbaj1TvUrF5hLLBaWJ(this, -2147221502);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string pPsb8pO9c9(bool P_0, string P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0)
		{
			return string.Format((string)YGlnQHTHKYOfa3URAuL(), P_1, P_2);
		}
		return (string)OckdwsTAEY5dJeBXlbJ(SCBFjfTVZYpCNhwpGfn(), P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsSensorAlreadyConnectedException(string message, bool isRemoteConnection, string username, string machine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 6:
				O0bbzCGIdW = isRemoteConnection;
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 7:
				XZraImuClE = "";
				num = 1;
				continue;
			case 9:
				Ahfa17gfR4 = machine;
				num = 11;
				continue;
			case 4:
				O0bbzCGIdW = true;
				_ = 0;
				num = ((!iUNCasTSgx3NH3KMMhJ()) ? 8 : 7);
				continue;
			case 3:
				XZraImuClE = username;
				num = 9;
				continue;
			default:
				OCbaj1TvUrF5hLLBaWJ(this, -2147221502);
				num = 6;
				continue;
			case 0:
				base._002Ector(message);
				goto default;
			case 1:
				Ahfa17gfR4 = "";
				num = 0;
				if (!HHLBOrTEXSWPNmHJL43())
				{
					continue;
				}
				break;
			case 10:
				break;
			case 11:
				return;
			}
			kqDoToTDeLLtGPRRmZq();
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsSensorAlreadyConnectedException(string message, Exception innerException, bool isRemoteConnection, string username, string machine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 0:
				Ahfa17gfR4 = "";
				num = 9;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				OCbaj1TvUrF5hLLBaWJ(this, -2147221502);
				goto case 4;
			case 5:
				Ahfa17gfR4 = machine;
				num = 11;
				break;
			case 4:
			case 6:
				O0bbzCGIdW = isRemoteConnection;
				num = 1;
				if (!HHLBOrTEXSWPNmHJL43())
				{
					break;
				}
				goto case 8;
			case 8:
				kqDoToTDeLLtGPRRmZq();
				num = 10;
				break;
			case 1:
				XZraImuClE = username;
				num = 5;
				break;
			case 9:
				base._002Ector(message, innerException);
				goto case 3;
			default:
				num = 3;
				if (iUNCasTSgx3NH3KMMhJ())
				{
					break;
				}
				goto case 2;
			case 2:
			case 7:
				XZraImuClE = "";
				num = 0;
				break;
			case 10:
				O0bbzCGIdW = true;
				_ = 1;
				if (HHLBOrTEXSWPNmHJL43())
				{
					num = 4;
					break;
				}
				num = 7;
				if (false)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsSensorAlreadyConnectedException(string message, bool isRemoteConnection, bool isMaxGuiConnection, string username, string machine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (HHLBOrTEXSWPNmHJL43())
		{
			goto IL_001e;
		}
		goto IL_005d;
		IL_001e:
		O0bbzCGIdW = isRemoteConnection;
		num = 0;
		goto IL_005d;
		IL_005d:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
				kqDoToTDeLLtGPRRmZq();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				HResult = -2147221502;
				break;
			default:
				num = 3;
				continue;
			case 1:
			case 7:
				XZraImuClE = username;
				num = 9;
				continue;
			case 5:
				O0bbzCGIdW = true;
				_ = 0;
				num = ((!iUNCasTSgx3NH3KMMhJ()) ? 1 : 10);
				continue;
			case 0:
				LawaPl26LS = isMaxGuiConnection;
				goto case 1;
			case 8:
				base._002Ector(message);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				Ahfa17gfR4 = machine;
				num = 11;
				continue;
			case 2:
			case 10:
				XZraImuClE = "";
				Ahfa17gfR4 = "";
				num = 8;
				if (iUNCasTSgx3NH3KMMhJ())
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private CvsSensorAlreadyConnectedException(SerializationInfo info, StreamingContext context)
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
				Ahfa17gfR4 = "";
				num = 3;
				if (iUNCasTSgx3NH3KMMhJ())
				{
					break;
				}
				goto case 8;
			case 8:
				HResult = -2147221502;
				num = 0;
				break;
			case 3:
				base._002Ector(info, context);
				goto case 8;
			default:
				num = 8;
				break;
			case 4:
				XZraImuClE = "";
				num = 5;
				break;
			case 0:
				O0bbzCGIdW = JGWlt5TUqwIBDvMngjW(info, kgbOBx7BanbFa22Hp9.ol99ukmDA(8848));
				goto case 7;
			case 7:
			case 9:
				XZraImuClE = (string)AJAlerTTbeR3nvPSRpW(info, kgbOBx7BanbFa22Hp9.ol99ukmDA(8890));
				num = 10;
				break;
			case 10:
				Ahfa17gfR4 = (string)AJAlerTTbeR3nvPSRpW(info, sqYaLMTdS8hpScxSkTr(8912));
				num = 11;
				break;
			case 2:
				kqDoToTDeLLtGPRRmZq();
				HHLBOrTEXSWPNmHJL43();
				if (!iUNCasTSgx3NH3KMMhJ())
				{
					num = 9;
					if (0 == 0)
					{
						break;
					}
					goto case 7;
				}
				num = 6;
				break;
			case 1:
			case 6:
				O0bbzCGIdW = true;
				num = 4;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
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
		goto IL_00f2;
		IL_001a:
		egFI7YTqMTdVVR1YXag(info, sqYaLMTdS8hpScxSkTr(8912), Ahfa17gfR4, typeof(string));
		num = 7;
		goto IL_00f2;
		IL_00f2:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				egFI7YTqMTdVVR1YXag(info, kgbOBx7BanbFa22Hp9.ol99ukmDA(8848), O0bbzCGIdW, bbFYArTimOGshkOOyrU(typeof(bool).TypeHandle));
				_ = 0;
				num = ((!iUNCasTSgx3NH3KMMhJ()) ? 4 : 0);
				continue;
			case 5:
				base.GetObjectData(info, context);
				num = 6;
				continue;
			default:
				info.AddValue((string)sqYaLMTdS8hpScxSkTr(8890), XZraImuClE, bbFYArTimOGshkOOyrU(typeof(string).TypeHandle));
				num = 1;
				continue;
			case 0:
			case 2:
				info.AddValue((string)sqYaLMTdS8hpScxSkTr(8932), LawaPl26LS, bbFYArTimOGshkOOyrU(typeof(bool).TypeHandle));
				goto default;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OCbaj1TvUrF5hLLBaWJ(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iUNCasTSgx3NH3KMMhJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HHLBOrTEXSWPNmHJL43()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YGlnQHTHKYOfa3URAuL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SensorAlreadyConnectedException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SCBFjfTVZYpCNhwpGfn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.LocalConnection;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OckdwsTAEY5dJeBXlbJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kqDoToTDeLLtGPRRmZq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JGWlt5TUqwIBDvMngjW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetBoolean((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AJAlerTTbeR3nvPSRpW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sqYaLMTdS8hpScxSkTr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type bbFYArTimOGshkOOyrU(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void egFI7YTqMTdVVR1YXag(object P_0, object P_1, object P_2, Type P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2, P_3);
	}
}
