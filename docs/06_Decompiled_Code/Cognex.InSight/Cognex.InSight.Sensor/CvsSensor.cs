using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Sensor;

[Serializable]
public sealed class CvsSensor
{
	private string u3Ho1UTunR;

	private static char[] xp0oxlW0cX;

	[NonSerialized]
	private readonly CvsInSight qSmoFTAs0K;

	public CvsHostType SystemType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsHostType.InSightSensor;
		}
	}

	public string HostName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return u3Ho1UTunR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			u3Ho1UTunR = value;
		}
	}

	public int MaxCellNameLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 127;
		}
	}

	public CvsProcessorConstants ProcessorConstants
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsProcessorConstants)RjHHRTldiHWYvC9DFqA(qSmoFTAs0K);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsSensor(CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		orSxEIl9Wqunxi6KcV3();
		int num = ((!EkOuYBlLZpuEGy6yOoD()) ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				qSmoFTAs0K = inSight;
				num = 5;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 1:
			case 2:
				zdmwDZlSR8kHAdlodRD(this);
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidCellNameCharacter(char c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!char.IsLetterOrDigit(c) && c != '_')
		{
			return c == '.';
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ValidateCellName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int num2 = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				throw new ArgumentException((string)s3nO2DlVkxbIVvr9aOZ(35066));
			case 2:
				if (m5AwyJlUj7IPSgagqVL(yTVKHolAGPf9G6yh8nc(name, 0)))
				{
					goto case 0;
				}
				if (wAKCj2lT3leasgHpKJ8(yTVKHolAGPf9G6yh8nc(name, 0)))
				{
					goto case 7;
				}
				return;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 12:
				if (num2 >= o4pCv6lDDjvXtlfRorh(name))
				{
					num = 15;
					break;
				}
				return;
			case 6:
				throw new ArgumentException((string)s3nO2DlVkxbIVvr9aOZ(35028));
			case 3:
				do
				{
					if (zSJp9vlEg3NapG6KGkH(name))
					{
						num = 9;
						break;
					}
					if (((Array)pHHRCTlHnwprrThecUC(Ev7FRclvomkxWVYbm8S(), name)).Length <= MaxCellNameLength)
					{
						if (name.IndexOfAny(xp0oxlW0cX) < 0)
						{
							num3 = 0;
							_ = 0;
							if (EkOuYBlLZpuEGy6yOoD())
							{
								num = 10;
								if (orSxEIl9Wqunxi6KcV3())
								{
								}
							}
							else
							{
								num = 7;
							}
							break;
						}
						num = 11;
						continue;
					}
					num = 6;
					if (orSxEIl9Wqunxi6KcV3())
					{
					}
					break;
				}
				while (false);
				break;
			case 9:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(34996));
			case 13:
			case 14:
				if (num2 >= o4pCv6lDDjvXtlfRorh(name))
				{
					num = 12;
					break;
				}
				if (m5AwyJlUj7IPSgagqVL(yTVKHolAGPf9G6yh8nc(name, num2)))
				{
					num = 5;
					break;
				}
				goto case 12;
			case 1:
			case 4:
			case 10:
				if (num3 < o4pCv6lDDjvXtlfRorh(name))
				{
					if (!IsValidCellNameCharacter(yTVKHolAGPf9G6yh8nc(name, num3)))
					{
						throw new ArgumentException((string)s3nO2DlVkxbIVvr9aOZ(35066));
					}
					num3++;
					num = 1;
				}
				else
				{
					num = 2;
				}
				break;
			case 7:
			case 8:
				if (name.Length > 1)
				{
					num2 = 1;
					num = 14;
					break;
				}
				return;
			case 5:
				num2++;
				num = 13;
				break;
			case 0:
				throw new ArgumentException((string)s3nO2DlVkxbIVvr9aOZ(35124));
			case 15:
				throw new ArgumentException((string)s3nO2DlVkxbIVvr9aOZ(35190));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSensorID(CvsHostType type, string hostName, string macAddress, string ipAddress)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EkOuYBlLZpuEGy6yOoD();
		int num = (orSxEIl9Wqunxi6KcV3() ? 3 : 2);
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				result = (string)s3nO2DlVkxbIVvr9aOZ(35290) + macAddress;
				break;
			default:
				num = 5;
				continue;
			case 0:
			case 2:
				result = string.Empty;
				goto case 1;
			case 1:
			case 3:
				if (zSJp9vlEg3NapG6KGkH(macAddress))
				{
					result = (string)KLhhyxliflUEl8MPRdY(CultureInfo.InvariantCulture, s3nO2DlVkxbIVvr9aOZ(35316), type, hostName, ipAddress);
					num = 6;
				}
				else
				{
					num = 4;
				}
				continue;
			case 5:
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsSensor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrPNDclqj85CIcby08b();
		char[] array = new char[5];
		x9aK58lB8hGJcPyNpLO(array, __ldtoken(_003CPrivateImplementationDetails_003E._5EAAA7A7F5EF2ECC852D1BDDC65C50F2A8C38B0B4A9FCF45B1A60F8BABE4803B));
		xp0oxlW0cX = array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zdmwDZlSR8kHAdlodRD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EkOuYBlLZpuEGy6yOoD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool orSxEIl9Wqunxi6KcV3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zSJp9vlEg3NapG6KGkH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ev7FRclvomkxWVYbm8S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pHHRCTlHnwprrThecUC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s3nO2DlVkxbIVvr9aOZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char yTVKHolAGPf9G6yh8nc(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int o4pCv6lDDjvXtlfRorh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m5AwyJlUj7IPSgagqVL(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.IsDigit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wAKCj2lT3leasgHpKJ8(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.IsLetter(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RjHHRTldiHWYvC9DFqA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KLhhyxliflUEl8MPRdY(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KrPNDclqj85CIcby08b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x9aK58lB8hGJcPyNpLO(object P_0, RuntimeFieldHandle P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}
}
