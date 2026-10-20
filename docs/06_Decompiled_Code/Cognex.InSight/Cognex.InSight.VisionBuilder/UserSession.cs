using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.VisionBuilder.Types;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder;

public class UserSession
{
	[CompilerGenerated]
	private readonly Server JsCpkoQuQj;

	[CompilerGenerated]
	private readonly AuthenticationResult r2cpXqrfqo;

	public Server Server
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JsCpkoQuQj;
		}
	}

	public AuthenticationResult LoginResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return r2cpXqrfqo;
		}
	}

	public string UserName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LoginResult?.UserName ?? "";
		}
	}

	public string AccessToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!lGRpW4FS5d())
			{
				return "";
			}
			return LoginResult.AccessToken;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserSession(Server server, AuthenticationResult result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NYQ738BZZvT8ZV8o2ro();
		int num = ((!rtQge3BgWnX3ur8tMLQ()) ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
				utdpvDB8I27mVaVC6V7(this);
				num = 4;
				if (true)
				{
					break;
				}
				goto default;
			default:
				r2cpXqrfqo = result;
				num = 6;
				if (rtQge3BgWnX3ur8tMLQ())
				{
					break;
				}
				goto case 4;
			case 4:
				JsCpkoQuQj = server;
				goto default;
			case 0:
			case 2:
				phxuHjBJE2UXs8xU441();
				num = 1;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidFor(Server server)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CF86t2BzjyYdvcFcfTK(server, Server))
		{
			return lGRpW4FS5d();
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool lGRpW4FS5d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!sJeQkMjwSlf6fD6Isjo(LoginResult?.AccessToken))
		{
			return !llMp3vpCDV();
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool llMp3vpCDV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (LoginResult == null)
		{
			return true;
		}
		return qosByfjLUbjW29UxrXK(BvPfqTjsGK5LmfWU9oH(), xw0DgIjh0LcnnrBmcxG(LoginResult));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void phxuHjBJE2UXs8xU441()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void utdpvDB8I27mVaVC6V7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rtQge3BgWnX3ur8tMLQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NYQ738BZZvT8ZV8o2ro()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CF86t2BzjyYdvcFcfTK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Server)P_0 == (Server)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sJeQkMjwSlf6fD6Isjo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimeOffset BvPfqTjsGK5LmfWU9oH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return DateTimeOffset.UtcNow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimeOffset xw0DgIjh0LcnnrBmcxG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AuthenticationResult)P_0).AccessTokenExpiration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qosByfjLUbjW29UxrXK(DateTimeOffset P_0, DateTimeOffset P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 >= P_1;
	}
}
