using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class CvsHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IPAddress DnsResolve(string hostName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (true)
		{
			IPAddress result = default;
			IPAddress iPAddress = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					if (mX4rs6EpqijhKWZ2bD7(hostName, 0) > '9')
					{
						num = 0;
						continue;
					}
					goto case 7;
				case 5:
					if (hostName == null)
					{
						break;
					}
					num = 6;
					if (!DwRTS4EXTD8VgMpxNFv())
					{
						continue;
					}
					goto case 6;
				case 6:
					if (luneLXEbHiFYhCAInGT(hostName) != 0)
					{
						if (hostName[0] >= '0')
						{
							goto default;
						}
						goto case 0;
					}
					_ = 1;
					num = ((!DwRTS4EXTD8VgMpxNFv()) ? 1 : 4);
					continue;
				case 0:
					if (miq2ZhE0EXPTAGA7SFD(hostName, '.') >= 0)
					{
						num = 7;
						continue;
					}
					goto IL_00f5;
				case 7:
					{
						try
						{
							result = (IPAddress)fUt18tE4r5GiyAZZlLe(hostName);
							return result;
						}
						catch (FormatException)
						{
						}
						goto IL_00f5;
					}
					IL_00f5:
					try
					{
						IPAddress[] addressList = ((IPHostEntry)(cf4vbvEkvpttc8WKXET(hostName) ?? throw new CvsNetworkException((string)ItAw4cE69BYmEeS58ks()))).AddressList;
						int num2 = 1;
						while (true)
						{
							switch (num2)
							{
							case 0:
								break;
							case 4:
								break;
							case 3:
							case 6:
								return (IPAddress)fUt18tE4r5GiyAZZlLe(iPAddress.ToString());
							case 2:
							case 5:
								if (num3 < addressList.Length)
								{
									iPAddress = addressList[num3];
									num2 = 7;
									if (GvvMSKEGQQYQFMcuk19())
									{
										continue;
									}
									goto case 3;
								}
								num2 = 8;
								continue;
							case 7:
								if (iPAddress.AddressFamily != AddressFamily.InterNetwork)
								{
									num3++;
									num2 = 5;
									continue;
								}
								goto default;
							default:
								_ = 1;
								if (DwRTS4EXTD8VgMpxNFv())
								{
									num2 = 0;
									if (DwRTS4EXTD8VgMpxNFv())
									{
									}
								}
								else
								{
									num2 = 6;
								}
								continue;
							case 1:
								num3 = 0;
								num2 = 2;
								continue;
							case 8:
								throw new CvsNetworkException((string)ItAw4cE69BYmEeS58ks());
							}
							break;
						}
					}
					catch (SocketException innerException)
					{
						throw new CvsNetworkException((string)ItAw4cE69BYmEeS58ks(), innerException);
					}
					return result;
				}
				break;
			}
		}
		throw new CvsNetworkException((string)ItAw4cE69BYmEeS58ks());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsInSightLanguage GetLanguage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_011d;
		IL_001a:
		string text = default;
		CvsInSightLanguage result = default;
		if (!(text == (string)UIgAykEmubICPpVdfTD(6234)))
		{
			num = 6;
		}
		else
		{
			result = CvsInSightLanguage.Japanese;
			num = 0;
		}
		goto IL_011d;
		IL_011d:
		while (true)
		{
			switch (num)
			{
			case 12:
				break;
			case 7:
				if (S4IZv3EyAadv1xraTV6(text, UIgAykEmubICPpVdfTD(6266)))
				{
					result = CvsInSightLanguage.German;
					goto case 0;
				}
				num = 2;
				continue;
			case 1:
				if (text == (string)UIgAykEmubICPpVdfTD(6258))
				{
					result = CvsInSightLanguage.French;
					goto case 0;
				}
				num = 7;
				if (DwRTS4EXTD8VgMpxNFv())
				{
				}
				continue;
			case 4:
				result = CvsInSightLanguage.English;
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				if (S4IZv3EyAadv1xraTV6(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(6274)))
				{
					result = CvsInSightLanguage.Spanish;
					goto case 0;
				}
				goto case 4;
			default:
				num = 4;
				if (!DwRTS4EXTD8VgMpxNFv())
				{
					continue;
				}
				goto case 4;
			case 13:
				if (S4IZv3EyAadv1xraTV6(text, UIgAykEmubICPpVdfTD(6250)))
				{
					result = CvsInSightLanguage.SimplifiedChinese;
					DwRTS4EXTD8VgMpxNFv();
					if (!GvvMSKEGQQYQFMcuk19())
					{
						num = 5;
						if (DwRTS4EXTD8VgMpxNFv())
						{
						}
					}
					else
					{
						num = 8;
					}
				}
				else
				{
					num = 1;
				}
				continue;
			case 9:
				text = (string)XnsoPqEFWLo3bCSVDeV(nPncxDEfdV5B0lUvf0a());
				num = 12;
				continue;
			case 6:
				if (S4IZv3EyAadv1xraTV6(text, UIgAykEmubICPpVdfTD(6242)))
				{
					result = CvsInSightLanguage.Korean;
					num = 3;
					continue;
				}
				num = 13;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
			case 5:
			case 8:
			case 10:
			case 11:
			case 14:
				return result;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnhandledExceptionAlert(Exception ex, string eventName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JxGhWfEzadiArIOvdPI(x4IKSkE8IYooLLkmgVm(new string[8]
		{
			(string)UIgAykEmubICPpVdfTD(6282),
			(string)coVsxgEgNCa7vrqLAMu(ex.GetType()),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(6348),
			eventName,
			(string)UIgAykEmubICPpVdfTD(6414),
			(string)hFnwQ5EZCTXn4H65kJG(ex),
			(string)UIgAykEmubICPpVdfTD(6452),
			(string)cef9vXEJUUBMm6Vv3yf(ex)
		}), kgbOBx7BanbFa22Hp9.ol99ukmDA(6460), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetCurrentCulture(Thread guiThread)
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
			case 2:
			case 3:
				((Thread)SKdqa0vhrI5hM5WSiOs()).CurrentCulture = (CultureInfo)lEFOCFvwLJdCtFbZTeX(guiThread);
				goto case 0;
			default:
				num = 0;
				if (GvvMSKEGQQYQFMcuk19())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				if (HOFy6qvsBG81CyKXQgG(guiThread) != HOFy6qvsBG81CyKXQgG(SKdqa0vhrI5hM5WSiOs()))
				{
					goto case 2;
				}
				return;
			case 0:
				mf3VANvLYMZlkjpcoR7(Thread.CurrentThread, HOFy6qvsBG81CyKXQgG(guiThread));
				num = 6;
				break;
			case 4:
				if (lEFOCFvwLJdCtFbZTeX(guiThread) == lEFOCFvwLJdCtFbZTeX(Thread.CurrentThread))
				{
					_ = 1;
					if (DwRTS4EXTD8VgMpxNFv())
					{
						num = 3;
						if (DwRTS4EXTD8VgMpxNFv())
						{
						}
					}
					else
					{
						num = 5;
					}
					break;
				}
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LPr3wMv9oSM8vY5XktX();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int luneLXEbHiFYhCAInGT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ItAw4cE69BYmEeS58ks()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidHostName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char mX4rs6EpqijhKWZ2bD7(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int miq2ZhE0EXPTAGA7SFD(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fUt18tE4r5GiyAZZlLe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IPAddress.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cf4vbvEkvpttc8WKXET(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Dns.GetHostEntry((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GvvMSKEGQQYQFMcuk19()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DwRTS4EXTD8VgMpxNFv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nPncxDEfdV5B0lUvf0a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XnsoPqEFWLo3bCSVDeV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CultureInfo)P_0).TwoLetterISOLanguageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UIgAykEmubICPpVdfTD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S4IZv3EyAadv1xraTV6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object coVsxgEgNCa7vrqLAMu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hFnwQ5EZCTXn4H65kJG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cef9vXEJUUBMm6Vv3yf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).StackTrace;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x4IKSkE8IYooLLkmgVm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult JxGhWfEzadiArIOvdPI(object P_0, object P_1, MessageBoxButtons P_2, MessageBoxIcon P_3, MessageBoxDefaultButton P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MessageBox.Show((string)P_0, (string)P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lEFOCFvwLJdCtFbZTeX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HOFy6qvsBG81CyKXQgG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SKdqa0vhrI5hM5WSiOs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Thread.CurrentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mf3VANvLYMZlkjpcoR7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LPr3wMv9oSM8vY5XktX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
