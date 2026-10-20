#define TRACE
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cognex.InSight.Sensor;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.UserAccess.Internal;

internal class CvsClassicConnectedUser : ICvsConnectedUser
{
	private readonly CvsUser iI6hyv8a25;

	private readonly string eY2hVxOJ3x;

	private static readonly string[] Hvvhv4jwWN;

	private static readonly string[] sibhZyErtY;

	private static readonly string[] iChh8lKWwX;

	private static readonly TraceSwitch AEQhzafOrk;

	public bool HasAnyModifyPermissions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wRDu992KA8JBHkOGTby(iI6hyv8a25) != CvsInSightSecurityAccess.None;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsClassicConnectedUser(CvsUser user)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!t5ubOY2WFNkSYFfwdcB())
		{
			num = 6;
			if (!VXSScY22sq4FDXWQuer())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_008c;
		IL_002a:
		tSDSaY2t7PgggXZrmxv(this);
		num = 5;
		goto IL_008c;
		IL_008c:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 6:
				LsUDVG27y61pXbReIj5();
				num = 1;
				continue;
			case 2:
				mpFh2Ik6d7();
				num = 7;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				iI6hyv8a25 = user;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				eY2hVxOJ3x = user.Name;
				goto default;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsClassicConnectedUser(string username, string password, CvsInSightSecurityAccess access, bool ftpReadEnabled, bool ftpWriteEnabled, bool customViewDefaultEnabled)
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
		goto IL_00a9;
		IL_001a:
		mpFh2Ik6d7();
		num = 7;
		goto IL_00a9;
		IL_00a9:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				break;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 1;
				if (!t5ubOY2WFNkSYFfwdcB())
				{
					num = 5;
					continue;
				}
				num = 6;
				if (t5ubOY2WFNkSYFfwdcB())
				{
				}
				continue;
			case 3:
				iI6hyv8a25 = new CvsUser((string)ChGevG2CHehok1XHfN3(16568), string.Empty, access, ftpReadEnabled, ftpWriteEnabled, customViewDefaultEnabled);
				break;
			case 1:
			case 5:
				tSDSaY2t7PgggXZrmxv(this);
				num = 0;
				continue;
			case 0:
				eY2hVxOJ3x = username;
				goto case 3;
			default:
				num = 3;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasModifyPermission(string permission)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t5ubOY2WFNkSYFfwdcB();
		int num = ((!VXSScY22sq4FDXWQuer()) ? 3 : 9);
		bool flag = default;
		CvsInSightSecurityAccess cvsInSightSecurityAccess = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				flag = false;
				goto case 3;
			case 2:
				switch (cvsInSightSecurityAccess)
				{
				case CvsInSightSecurityAccess.None:
					break;
				default:
					goto IL_0068;
				case CvsInSightSecurityAccess.Full:
					goto IL_0099;
				case CvsInSightSecurityAccess.Locked:
					goto IL_010c;
				case CvsInSightSecurityAccess.Protected:
					goto IL_0134;
				}
				flag = false;
				num = 6;
				break;
			case 10:
				cvsInSightSecurityAccess = wRDu992KA8JBHkOGTby(iI6hyv8a25);
				num = 2;
				if (VXSScY22sq4FDXWQuer())
				{
					break;
				}
				goto case 3;
			default:
				num = 5;
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				if (flag)
				{
					num = 11;
					break;
				}
				return false;
			case 0:
			case 9:
				flag = false;
				num = 10;
				break;
			case 11:
				{
					return HasVisiblePermission(permission);
				}
				IL_0134:
				flag = vU7hrm5wLS(permission, sibhZyErtY);
				num = 4;
				break;
				IL_010c:
				flag = vU7hrm5wLS(permission, iChh8lKWwX);
				num = 7;
				break;
				IL_0099:
				flag = vU7hrm5wLS(permission, Hvvhv4jwWN);
				goto case 3;
				IL_0068:
				num = 1;
				if (VXSScY22sq4FDXWQuer())
				{
					break;
				}
				goto case 10;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasVisiblePermission(string permission)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool vU7hrm5wLS(string P_0, string[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		uint num2 = default;
		string[] array = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 20:
				if (num2 == 394919476)
				{
					if (!M9l3Tc2o7TTL9oxTXKJ(P_0, ChGevG2CHehok1XHfN3(16202)))
					{
						num = 2;
						continue;
					}
					goto IL_0207;
				}
				if (num2 != 1570489899)
				{
					num = 12;
					continue;
				}
				if (!M9l3Tc2o7TTL9oxTXKJ(P_0, ChGevG2CHehok1XHfN3(16022)))
				{
					num = 19;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				return m2ZwUd2YBvhlBTOh39D(iI6hyv8a25);
			case 5:
				num2 = yZeFcg25i9ZJ0VFGDTN(P_0);
				num = 9;
				continue;
			case 9:
				if (num2 <= 1970408259)
				{
					num = 22;
					continue;
				}
				if (num2 <= 2376030657u)
				{
					num = 21;
					if (0 == 0)
					{
						continue;
					}
				}
				else if (num2 == 2394224446u)
				{
					if (M9l3Tc2o7TTL9oxTXKJ(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(16334)))
					{
						return i14MZU2NxX3vWVOhyRs(iI6hyv8a25);
					}
				}
				else
				{
					num = 16;
					if (true)
					{
						continue;
					}
				}
				goto case 1;
			default:
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 15:
			case 18:
				return false;
			case 1:
			case 2:
			case 3:
			case 4:
			case 7:
			case 8:
			case 11:
			case 12:
			case 13:
			case 17:
			case 19:
			case 23:
				array = P_1;
				num3 = 0;
				num = 0;
				continue;
			case 10:
				return true;
			case 22:
				if (num2 > 1570489899)
				{
					if (num2 != 1925570036)
					{
						num = 6;
						continue;
					}
					if (!M9l3Tc2o7TTL9oxTXKJ(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(16154)))
					{
						num = 1;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					if (wRDu992KA8JBHkOGTby(iI6hyv8a25) == CvsInSightSecurityAccess.Locked)
					{
						goto case 15;
					}
					return iI6hyv8a25.FtpReadEnabled;
				}
				num = 20;
				continue;
			case 6:
				if (num2 == 1970408259)
				{
					if (!(P_0 == (string)ChGevG2CHehok1XHfN3(16220)))
					{
						num = 7;
						continue;
					}
					goto IL_0207;
				}
				num = 4;
				continue;
			case 16:
				if (num2 == 3388460431u)
				{
					if (!M9l3Tc2o7TTL9oxTXKJ(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(16178)))
					{
						num = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 20;
					}
					return iI6hyv8a25.OnlineJobSaveEnabled;
				}
				goto case 1;
			case 21:
				if (num2 == 1996865873)
				{
					if (M9l3Tc2o7TTL9oxTXKJ(P_0, ChGevG2CHehok1XHfN3(15768)))
					{
						return htv6DU2PpVu48QmHJgu(iI6hyv8a25);
					}
					num = 23;
					continue;
				}
				if (num2 == 2376030657u)
				{
					if (M9l3Tc2o7TTL9oxTXKJ(P_0, ChGevG2CHehok1XHfN3(15820)))
					{
						if (wRDu992KA8JBHkOGTby(iI6hyv8a25) == CvsInSightSecurityAccess.Locked)
						{
							return false;
						}
						return i14MZU2NxX3vWVOhyRs(iI6hyv8a25);
					}
					num = 13;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				_ = 1;
				if (t5ubOY2WFNkSYFfwdcB())
				{
					num = 15;
					continue;
				}
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 14:
				if (num3 < array.Length)
				{
					string text = array[num3];
					if (AuHi8p2x6KyrAPnrdVl(P_0, text))
					{
						num = 10;
						continue;
					}
					num3++;
					num = 14;
					continue;
				}
				num = 24;
				if (true)
				{
					continue;
				}
				break;
			case 24:
				break;
				IL_0207:
				if (wRDu992KA8JBHkOGTby(iI6hyv8a25) == CvsInSightSecurityAccess.Locked)
				{
					return false;
				}
				return i14MZU2NxX3vWVOhyRs(iI6hyv8a25);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool HkEhCXDibX(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (M9l3Tc2o7TTL9oxTXKJ(P_0, P_1))
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mpFh2Ik6d7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (!RBchkP21EDDkTKeNL7q(AEQhzafOrk))
			{
				return;
			}
			int num = 0;
			int num2 = default;
			string[] arrayOfEveryPermission = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					num2++;
					num = 9;
					break;
				case 1:
				case 6:
					Hk5Txc2O6HE2IqZbhSx();
					goto case 2;
				case 2:
				case 7:
					arrayOfEveryPermission = CvsPermissionDefinitions.ArrayOfEveryPermission;
					num2 = 0;
					num = 5;
					break;
				case 4:
					TZdhGn23ry2LNIgNj2T(text, G19gZc2rP0Ba1giTBpr(AEQhzafOrk));
					num = 8;
					break;
				default:
					num = 3;
					break;
				case 5:
				case 9:
					if (num2 < arrayOfEveryPermission.Length)
					{
						text = arrayOfEveryPermission[num2];
					}
					else
					{
						num = 10;
						if (VXSScY22sq4FDXWQuer())
						{
							break;
						}
					}
					goto case 3;
				case 3:
					if (!HasModifyPermission(text))
					{
						goto case 8;
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					TZdhGn23ry2LNIgNj2T(kgbOBx7BanbFa22Hp9.ol99ukmDA(16588), G19gZc2rP0Ba1giTBpr(AEQhzafOrk));
					_ = 0;
					if (!VXSScY22sq4FDXWQuer())
					{
						num = 7;
						break;
					}
					num = 6;
					if (t5ubOY2WFNkSYFfwdcB())
					{
					}
					break;
				case 10:
					nHaF0K2MEMGgMBKJgl8();
					return;
				}
			}
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsClassicConnectedUser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0352;
		IL_001a:
		LsUDVG27y61pXbReIj5();
		_ = 0;
		num = ((!VXSScY22sq4FDXWQuer()) ? 3 : 6);
		goto IL_0352;
		IL_0352:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 6:
				Hvvhv4jwWN = new string[32]
				{
					(string)ChGevG2CHehok1XHfN3(16094),
					(string)ChGevG2CHehok1XHfN3(15968),
					(string)ChGevG2CHehok1XHfN3(15676),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15706),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16102),
					(string)ChGevG2CHehok1XHfN3(16122),
					(string)ChGevG2CHehok1XHfN3(15796),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16138),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16154),
					(string)ChGevG2CHehok1XHfN3(16178),
					(string)ChGevG2CHehok1XHfN3(16202),
					(string)ChGevG2CHehok1XHfN3(16220),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16248),
					(string)ChGevG2CHehok1XHfN3(15984),
					(string)ChGevG2CHehok1XHfN3(16272),
					(string)ChGevG2CHehok1XHfN3(16296),
					(string)ChGevG2CHehok1XHfN3(16316),
					(string)ChGevG2CHehok1XHfN3(16022),
					(string)ChGevG2CHehok1XHfN3(16334),
					(string)ChGevG2CHehok1XHfN3(15740),
					(string)ChGevG2CHehok1XHfN3(16006),
					(string)ChGevG2CHehok1XHfN3(16362),
					(string)ChGevG2CHehok1XHfN3(16372),
					(string)ChGevG2CHehok1XHfN3(16048),
					(string)ChGevG2CHehok1XHfN3(16398),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16066),
					(string)ChGevG2CHehok1XHfN3(15950),
					(string)ChGevG2CHehok1XHfN3(15656),
					(string)ChGevG2CHehok1XHfN3(15848),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15884),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15920),
					(string)ChGevG2CHehok1XHfN3(16428)
				};
				goto case 2;
			case 4:
				AEQhzafOrk = new TraceSwitch(kgbOBx7BanbFa22Hp9.ol99ukmDA(16668), (string)ChGevG2CHehok1XHfN3(16698));
				num = 7;
				continue;
			case 5:
				iChh8lKWwX = new string[4]
				{
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15676),
					(string)ChGevG2CHehok1XHfN3(16048),
					(string)ChGevG2CHehok1XHfN3(15920),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16428)
				};
				num = 4;
				continue;
			case 2:
			case 3:
				sibhZyErtY = new string[14]
				{
					(string)ChGevG2CHehok1XHfN3(15676),
					(string)ChGevG2CHehok1XHfN3(15706),
					(string)ChGevG2CHehok1XHfN3(16102),
					(string)ChGevG2CHehok1XHfN3(16154),
					(string)ChGevG2CHehok1XHfN3(15984),
					(string)ChGevG2CHehok1XHfN3(15796),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16048),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15656),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(16372),
					(string)ChGevG2CHehok1XHfN3(16398),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15848),
					(string)ChGevG2CHehok1XHfN3(15884),
					kgbOBx7BanbFa22Hp9.ol99ukmDA(15920),
					(string)ChGevG2CHehok1XHfN3(16428)
				};
				goto case 5;
			default:
				num = 5;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LsUDVG27y61pXbReIj5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tSDSaY2t7PgggXZrmxv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VXSScY22sq4FDXWQuer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t5ubOY2WFNkSYFfwdcB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ChGevG2CHehok1XHfN3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightSecurityAccess wRDu992KA8JBHkOGTby(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsUser)P_0).Access;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint yZeFcg25i9ZJ0VFGDTN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M9l3Tc2o7TTL9oxTXKJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool htv6DU2PpVu48QmHJgu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsUser)P_0).OnlineOfflineEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m2ZwUd2YBvhlBTOh39D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsUser)P_0).FtpReadEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i14MZU2NxX3vWVOhyRs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsUser)P_0).FtpWriteEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AuHi8p2x6KyrAPnrdVl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HkEhCXDibX((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RBchkP21EDDkTKeNL7q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TraceSwitch)P_0).TraceInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G19gZc2rP0Ba1giTBpr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Switch)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TZdhGn23ry2LNIgNj2T(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Trace.WriteLine((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hk5Txc2O6HE2IqZbhSx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Trace.Indent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nHaF0K2MEMGgMBKJgl8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Trace.Unindent();
	}
}
