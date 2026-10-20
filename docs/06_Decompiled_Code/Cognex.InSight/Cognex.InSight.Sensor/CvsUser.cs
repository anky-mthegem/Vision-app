using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Sensor;

[Serializable]
[Guid("11C3C515-4D12-48e5-8508-3C31CA7A9EF4")]
public sealed class CvsUser : ICloneable
{
	internal const int MAX_NAME_LENGTH_W_NULL = 16;

	public const int MaxUserNameLength = 15;

	public const int MaxPasswordLength = 15;

	private static readonly char[] DYHoOGlCkk;

	private string DIiopEDlKX;

	private string JtEohDqjhH;

	private CvsInSightSecurityAccess hloo4NsmF7;

	private bool eewolrsvJ3;

	private bool bVKogGV1f2;

	private bool iqIoqmp0pL;

	private bool GV9oTgDecO;

	private bool rYQoBxBUOD;

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DIiopEDlKX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y5qgullWAfWNJGMjNXH();
			int num;
			if (JvSyoJl2IgmNU9u86p3())
			{
				num = 2;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (!JvSyoJl2IgmNU9u86p3())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 3;
				case 3:
					DIiopEDlKX = value;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					if (value != null)
					{
						if (qeskNQlClaLJVRZFpf5(value))
						{
							goto case 3;
						}
						throw new ArgumentException((string)I3iIHwlK9CgrdbKAIPF());
					}
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			throw new ArgumentNullException();
		}
	}

	public string Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JtEohDqjhH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (JvSyoJl2IgmNU9u86p3())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_005a;
			IL_0026:
			JtEohDqjhH = value;
			num = 5;
			goto IL_005a;
			IL_005a:
			while (true)
			{
				switch (num)
				{
				case 1:
					throw new ArgumentNullException();
				case 0:
				case 3:
					if (value == null)
					{
						goto IL_008d;
					}
					if (JLsvpEl5qNtLvyk3xNM(value))
					{
						break;
					}
					throw new ArgumentException((string)WwGOJ2lon7yWCyN9aDB());
				case 5:
					return;
				}
				break;
				IL_008d:
				num = 1;
			}
			goto IL_0026;
		}
	}

	public CvsInSightSecurityAccess Access
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hloo4NsmF7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 1:
				case 2:
					if (value != CvsInSightSecurityAccess.Locked)
					{
						num = 0;
						if (true)
						{
							break;
						}
					}
					goto default;
				default:
					hloo4NsmF7 = value;
					num = 6;
					break;
				case 0:
					if (value == CvsInSightSecurityAccess.Protected)
					{
						goto default;
					}
					throw new ArgumentException();
				case 4:
					if (value != CvsInSightSecurityAccess.Full)
					{
						_ = 1;
						num = ((!y5qgullWAfWNJGMjNXH()) ? 2 : 5);
						break;
					}
					goto default;
				case 6:
					return;
				}
			}
		}
	}

	public bool FtpReadEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eewolrsvJ3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eewolrsvJ3 = value;
		}
	}

	public bool FtpWriteEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bVKogGV1f2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bVKogGV1f2 = value;
		}
	}

	public bool CustomViewDefaultEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iqIoqmp0pL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iqIoqmp0pL = value;
		}
	}

	public bool OnlineOfflineEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Access != CvsInSightSecurityAccess.Full)
			{
				if (Access == CvsInSightSecurityAccess.Protected)
				{
					return GV9oTgDecO;
				}
				return false;
			}
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GV9oTgDecO = value;
		}
	}

	public bool OnlineJobSaveEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rYQoBxBUOD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rYQoBxBUOD = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsUser(string name, string password, CvsInSightSecurityAccess access, bool ftpReadEnabled, bool ftpWriteEnabled, bool customViewDefaultEnabled)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y5qgullWAfWNJGMjNXH() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				Initialize(name, password, access, ftpReadEnabled, ftpWriteEnabled, customViewDefaultEnabled);
				num = 5;
				continue;
			case 1:
			case 2:
				Eyi6Wblt39suDYk7gNo(this);
				goto case 3;
			case 0:
			case 4:
				NmkJ18l7qLeiETvPyWj();
				goto case 1;
			case 5:
				return;
			}
			num = 3;
			if (y5qgullWAfWNJGMjNXH())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsUser(CvsUser original)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 6:
				Eyi6Wblt39suDYk7gNo(this);
				num = 0;
				continue;
			default:
				bVKogGV1f2 = original.bVKogGV1f2;
				num = 7;
				if (JvSyoJl2IgmNU9u86p3())
				{
					continue;
				}
				goto case 3;
			case 3:
				rYQoBxBUOD = original.rYQoBxBUOD;
				num = 11;
				continue;
			case 0:
				DIiopEDlKX = original.DIiopEDlKX;
				num = 8;
				if (!y5qgullWAfWNJGMjNXH())
				{
					continue;
				}
				goto case 7;
			case 7:
				iqIoqmp0pL = original.iqIoqmp0pL;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				GV9oTgDecO = original.GV9oTgDecO;
				num = 3;
				continue;
			case 8:
				JtEohDqjhH = original.JtEohDqjhH;
				y5qgullWAfWNJGMjNXH();
				if (JvSyoJl2IgmNU9u86p3())
				{
					num = 9;
					continue;
				}
				num = 10;
				if (true)
				{
					continue;
				}
				break;
			case 4:
			case 9:
				hloo4NsmF7 = original.hloo4NsmF7;
				eewolrsvJ3 = original.eewolrsvJ3;
				goto default;
			case 1:
				break;
			case 11:
				return;
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsUser()
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
			default:
				Initialize("", "", CvsInSightSecurityAccess.Full, ftpReadEnabled: true, ftpWriteEnabled: true, customViewDefaultEnabled: true);
				num = 5;
				if (!y5qgullWAfWNJGMjNXH())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 1:
			case 4:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
			NmkJ18l7qLeiETvPyWj();
			_ = 0;
			if (JvSyoJl2IgmNU9u86p3())
			{
				num = 4;
				continue;
			}
			num = 3;
			if (0 == 0)
			{
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsUser(string name, string password, CvsInSightSecurityAccess access, bool ftpReadEnabled, bool ftpWriteEnabled, bool customViewDefaultEnabled, bool onlineOfflineEnabled)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y5qgullWAfWNJGMjNXH() ? 1 : 4);
		do
		{
			IL_004d:
			switch (num)
			{
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				if (true)
				{
					goto IL_004d;
				}
				goto case 3;
			case 3:
				Eyi6Wblt39suDYk7gNo(this);
				break;
			case 5:
				return;
			}
			qdmobKcX1E(name, password, access, ftpReadEnabled, ftpWriteEnabled, customViewDefaultEnabled, onlineOfflineEnabled, _0020: false);
			num = 5;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsUser(string name, string password, CvsInSightSecurityAccess access, bool ftpReadEnabled, bool ftpWriteEnabled, bool customViewDefaultEnabled, bool onlineOfflineEnabled, bool onlineJobSaveEnabled)
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
			case 0:
				NmkJ18l7qLeiETvPyWj();
				_ = 0;
				num = ((!JvSyoJl2IgmNU9u86p3()) ? 4 : 3);
				continue;
			case 1:
			case 3:
				Eyi6Wblt39suDYk7gNo(this);
				break;
			case 5:
				return;
			}
			qdmobKcX1E(name, password, access, ftpReadEnabled, ftpWriteEnabled, customViewDefaultEnabled, onlineOfflineEnabled, onlineJobSaveEnabled);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(string name, string password, CvsInSightSecurityAccess access, bool ftpReadEnabled, bool ftpWriteEnabled, bool customViewDefaultEnabled)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qdmobKcX1E(name, password, access, ftpReadEnabled, ftpWriteEnabled, customViewDefaultEnabled, true, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qdmobKcX1E(string P_0, string P_1, CvsInSightSecurityAccess P_2, bool P_3, bool P_4, bool P_5, bool P_6, bool P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 0:
				Password = P_1;
				y5qgullWAfWNJGMjNXH();
				num = (JvSyoJl2IgmNU9u86p3() ? 1 : 4);
				continue;
			case 1:
			case 2:
				hloo4NsmF7 = P_2;
				num = 7;
				continue;
			case 9:
				GV9oTgDecO = P_6;
				num = 8;
				continue;
			case 3:
				bVKogGV1f2 = P_4;
				break;
			case 6:
				Name = P_0;
				num = 0;
				continue;
			case 7:
				eewolrsvJ3 = P_3;
				num = 3;
				continue;
			case 8:
				rYQoBxBUOD = P_7;
				num = 10;
				if (!y5qgullWAfWNJGMjNXH())
				{
					continue;
				}
				break;
			case 10:
				return;
			}
			iqIoqmp0pL = P_5;
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidUserNameOrPasswordChar(char c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		bool flag = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				flag = false;
				num = 6;
				continue;
			default:
				flag = true;
				num = 1;
				continue;
			case 1:
				num2++;
				num = 3;
				continue;
			case 3:
			case 4:
			case 8:
				if (num2 < DYHoOGlCkk.Length)
				{
					num = 9;
					continue;
				}
				break;
			case 10:
				flag = true;
				num = 2;
				continue;
			case 9:
				if (!flag)
				{
					if (DYHoOGlCkk[num2].Equals(c))
					{
						goto default;
					}
					goto case 1;
				}
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				if (!char.IsLetterOrDigit(c))
				{
					num2 = 0;
					_ = 1;
					if (y5qgullWAfWNJGMjNXH())
					{
						num = 7;
						continue;
					}
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 9;
				}
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
			case 11:
				break;
			}
			break;
		}
		return flag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidUserName(string s)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return X26FT0lPY2XcFljG6Bf(s, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidPassword(string s)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return X26FT0lPY2XcFljG6Bf(s, true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool bZhoapdshQ(string P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num4 = default;
		bool result = default;
		int num3 = default;
		Encoding encoding = default;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 9:
				if (!P_1)
				{
					num = 1;
					break;
				}
				num2 = 0;
				goto IL_0151;
			case 2:
				while (num4 < ix4wcjlrmJsbocJ9VUN(P_0))
				{
					if (qMihLpl1WUwi1clSLS7(jnyaU6lxdhCl353J1tm(P_0, num4)))
					{
						num4++;
						continue;
					}
					goto IL_00e8;
				}
				num = 6;
				if (JvSyoJl2IgmNU9u86p3())
				{
					break;
				}
				goto case 7;
			case 7:
				result = false;
				num = 11;
				break;
			case 10:
				if (P_0.Length >= num3 && Cwcj3NlNhw1H9BET5h0(encoding, P_0) <= 15)
				{
					goto case 5;
				}
				result = false;
				num = 13;
				break;
			default:
				num = 5;
				if (!y5qgullWAfWNJGMjNXH())
				{
					break;
				}
				goto case 2;
			case 0:
				result = true;
				num = 9;
				break;
			case 4:
			case 12:
				encoding = (Encoding)sOyijPlY61mPiw8ZOxy();
				num = 10;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				num4 = 0;
				num = 2;
				break;
			case 3:
			case 8:
				P_0 = string.Empty;
				goto case 4;
			case 1:
				num2 = 1;
				goto IL_0151;
			case 6:
			case 11:
			case 13:
				{
					return result;
				}
				IL_0151:
				num3 = num2;
				if (P_0 == null)
				{
					_ = 1;
					num = ((!y5qgullWAfWNJGMjNXH()) ? 8 : 12);
					break;
				}
				goto case 4;
				IL_00e8:
				num = 7;
				if (JvSyoJl2IgmNU9u86p3())
				{
					break;
				}
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool IsEqual(CvsUser userSettings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (y5qgullWAfWNJGMjNXH())
		{
			goto IL_001e;
		}
		goto IL_009c;
		IL_001e:
		if (GV9oTgDecO == userSettings.GV9oTgDecO)
		{
			num = 9;
			goto IL_009c;
		}
		goto IL_0145;
		IL_0145:
		return false;
		IL_009c:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 0:
				goto IL_0039;
			case 3:
				goto IL_0059;
			case 7:
				goto IL_0079;
			default:
				goto IL_00c9;
			case 1:
			case 5:
				if (iqIoqmp0pL == userSettings.iqIoqmp0pL)
				{
					num = 6;
					continue;
				}
				goto IL_0145;
			case 2:
				if (hloo4NsmF7 == userSettings.hloo4NsmF7)
				{
					num = 7;
					continue;
				}
				goto IL_0145;
			case 4:
			case 8:
				if (bVKogGV1f2 == userSettings.bVKogGV1f2)
				{
					goto case 1;
				}
				goto IL_0145;
			case 9:
				return rYQoBxBUOD == userSettings.rYQoBxBUOD;
			}
			break;
			IL_0079:
			if (eewolrsvJ3 == userSettings.eewolrsvJ3)
			{
				goto IL_00c9;
			}
			goto IL_0145;
			IL_00c9:
			_ = 0;
			num = ((!JvSyoJl2IgmNU9u86p3()) ? 1 : 8);
			continue;
			IL_0059:
			if (BKHfRnl38WYbJPdtQce(DIiopEDlKX, userSettings.DIiopEDlKX))
			{
				num = 0;
				continue;
			}
			goto IL_0145;
			IL_0039:
			if (BKHfRnl38WYbJPdtQce(JtEohDqjhH, userSettings.JtEohDqjhH))
			{
				num = 2;
				continue;
			}
			goto IL_0145;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsUser(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsUser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		DYHoOGlCkk = new char[2] { '_', '-' };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NmkJ18l7qLeiETvPyWj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Eyi6Wblt39suDYk7gNo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JvSyoJl2IgmNU9u86p3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y5qgullWAfWNJGMjNXH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qeskNQlClaLJVRZFpf5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsValidUserName((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I3iIHwlK9CgrdbKAIPF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidUsername;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JLsvpEl5qNtLvyk3xNM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsValidPassword((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WwGOJ2lon7yWCyN9aDB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidPassword;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X26FT0lPY2XcFljG6Bf(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bZhoapdshQ((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sOyijPlY61mPiw8ZOxy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Cwcj3NlNhw1H9BET5h0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char jnyaU6lxdhCl353J1tm(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qMihLpl1WUwi1clSLS7(char c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsValidUserNameOrPasswordChar(c);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ix4wcjlrmJsbocJ9VUN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BKHfRnl38WYbJPdtQce(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
