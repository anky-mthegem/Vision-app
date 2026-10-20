using System.Runtime.CompilerServices;
using Cognex.InSight.VisionBuilder.Types;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class UserSessionCache : IUserSessionCache
{
	private UserSession MqPpfSL1it;

	[CompilerGenerated]
	private static readonly UserSessionCache coYpjWneBw;

	public static UserSessionCache Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return coYpjWneBw;
		}
	}

	public Server LastLoggedInServer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MqPpfSL1it?.Server;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLoggedInFor(Server server)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MqPpfSL1it?.IsValidFor(server) ?? false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAccessTokenFor(Server server)
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
		goto IL_006f;
		IL_001a:
		UserSession mqPpfSL1it = MqPpfSL1it;
		HgmuAFj9GanNdtaf4Uf();
		num = (Sp0HB6jSGmsRLD4op1X() ? 4 : 0);
		goto IL_006f;
		IL_006f:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				if (mqPpfSL1it.IsValidFor(server))
				{
					num = 5;
					if (HgmuAFj9GanNdtaf4Uf())
					{
						continue;
					}
					goto case 0;
				}
				goto IL_00a3;
			case 0:
			case 1:
				if (mqPpfSL1it != null)
				{
					goto default;
				}
				goto IL_00a3;
			case 5:
				{
					return (string)bEJTlLjEYsishsskwoC(mqPpfSL1it);
				}
				IL_00a3:
				return "";
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetUserNameFor(Server server)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		UserSession mqPpfSL1it = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				if (mqPpfSL1it == null)
				{
					break;
				}
				goto default;
			default:
				if (mqPpfSL1it.IsValidFor(server))
				{
					num = 5;
					continue;
				}
				break;
			case 0:
				mqPpfSL1it = MqPpfSL1it;
				HgmuAFj9GanNdtaf4Uf();
				num = ((!Sp0HB6jSGmsRLD4op1X()) ? 4 : 3);
				continue;
			case 5:
				return (string)O2rjLEjvHfMYAb0BMhx(mqPpfSL1it);
			}
			break;
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreSession(UserSession userSession)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MqPpfSL1it = userSession;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSession()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MqPpfSL1it = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserSessionCache()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T0FTLVjH2HSnjNcWki0();
		sofONBjVPXB8dwx0u7O(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserSessionCache()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		coYpjWneBw = new UserSessionCache();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HgmuAFj9GanNdtaf4Uf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Sp0HB6jSGmsRLD4op1X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bEJTlLjEYsishsskwoC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UserSession)P_0).AccessToken;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O2rjLEjvHfMYAb0BMhx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UserSession)P_0).UserName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void T0FTLVjH2HSnjNcWki0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sofONBjVPXB8dwx0u7O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
