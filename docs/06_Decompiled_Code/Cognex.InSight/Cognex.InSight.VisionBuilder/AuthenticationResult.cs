using System;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using IdentityModel.OidcClient;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class AuthenticationResult
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Claim> _003C_003E9__1_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sOvG2msDXFZnWvqhkbHU();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sOvG2msDXFZnWvqhkbHU();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFromOidcLoginResult_003Eb__1_1(Claim c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return myvQj0sD6lvX6MYbSgkK(c.Type, N7h2Z6sDb4nk9qlvqcgM(4310));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sOvG2msDXFZnWvqhkbHU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J1pJgrsDnCFmHPQLgI1y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YZC6dbsDGDayuq7MRJCW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N7h2Z6sDb4nk9qlvqcgM(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool myvQj0sD6lvX6MYbSgkK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private readonly string Al3pBRdwjr;

	[CompilerGenerated]
	private readonly string eUppJFkcWj;

	[CompilerGenerated]
	private readonly DateTimeOffset AbApM5vWTE;

	[CompilerGenerated]
	private readonly object kQRpoVYq3e;

	public string UserName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Al3pBRdwjr;
		}
	}

	public string AccessToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eUppJFkcWj;
		}
	}

	public DateTimeOffset AccessTokenExpiration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AbApM5vWTE;
		}
	}

	public object Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kQRpoVYq3e;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AuthenticationResult(string userName, string token, DateTimeOffset expiration, object data = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				eUppJFkcWj = token;
				goto case 1;
			default:
				num = 1;
				break;
			case 5:
				kQRpoVYq3e = data;
				num = 8;
				if (K6lcqRBIyGEOtagyLuB())
				{
				}
				break;
			case 7:
				uYL3SuBR3bv8CiwMYbS();
				num = 4;
				break;
			case 1:
				AbApM5vWTE = expiration;
				num = 5;
				break;
			case 4:
				base._002Ector();
				_ = 0;
				num = (PPcKMBBuO1MptaaUpxC() ? 6 : 0);
				break;
			case 2:
			case 6:
				Al3pBRdwjr = userName;
				goto case 0;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AuthenticationResult FromOidcLoginResult(LoginResult loginResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (loginResult.IsError)
		{
			return null;
		}
		return new AuthenticationResult((string)gm7ICwBao9XcN5vsW8I(loginResult), (string)tk7vySBnIgpWi3tnBF2(loginResult), m9DdfMBGromWWmfasd3(loginResult), loginResult);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uYL3SuBR3bv8CiwMYbS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PPcKMBBuO1MptaaUpxC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K6lcqRBIyGEOtagyLuB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gm7ICwBao9XcN5vsW8I(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetUserName((LoginResult)P_0);
		[MethodImpl(MethodImplOptions.NoInlining)]
		static string GetUserName(LoginResult loginResult)
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
			goto IL_0091;
			IL_001a:
			if (loginResult != null)
			{
				num = 4;
				if (K6lcqRBIyGEOtagyLuB())
				{
				}
				goto IL_0091;
			}
			goto IL_00ec;
			IL_00ec:
			string result = default;
			return result;
			IL_0091:
			while (true)
			{
				object obj;
				switch (num)
				{
				case 0:
				case 1:
					break;
				default:
				{
					Claim claim = ((ClaimsPrincipal)Xcqq1GBbBYTCxGqjb2a(loginResult)).FindFirst((Predicate<Claim>)([MethodImpl(MethodImplOptions.NoInlining)] (Claim c) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return _003C_003Ec.myvQj0sD6lvX6MYbSgkK(c.Type, _003C_003Ec.N7h2Z6sDb4nk9qlvqcgM(4310));
					}));
					if (claim == null)
					{
						num = 6;
						if (true)
						{
							continue;
						}
						goto case 4;
					}
					obj = M8fvskB6J45FlO9xJi0(claim);
					goto IL_00eb;
				}
				case 4:
					if (!YylqgVBXgeZM3Hn4hVM(loginResult))
					{
						goto default;
					}
					goto IL_00ec;
				case 5:
					do
					{
						result = string.Empty;
						_ = 0;
						if (PPcKMBBuO1MptaaUpxC())
						{
							num = 0;
							break;
						}
						num = 2;
					}
					while (false);
					continue;
				case 6:
					{
						obj = null;
						goto IL_00eb;
					}
					IL_00eb:
					result = (string)obj;
					goto IL_00ec;
				}
				break;
			}
			goto IL_001a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tk7vySBnIgpWi3tnBF2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LoginResult)P_0).AccessToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimeOffset m9DdfMBGromWWmfasd3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LoginResult)P_0).AccessTokenExpiration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YylqgVBXgeZM3Hn4hVM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Result)P_0).IsError;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xcqq1GBbBYTCxGqjb2a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LoginResult)P_0).User;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M8fvskB6J45FlO9xJi0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Claim)P_0).Value;
	}
}
