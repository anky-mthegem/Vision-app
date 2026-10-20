using System.Runtime.CompilerServices;
using IawbpyxeWauKVJvQ4t;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cognex.Remoting.CogSocket;

public abstract class CogSocketMessage
{
	[JsonProperty(PropertyName = "id", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return field;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			field = value;
		}
	}

	[JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return field;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			field = value;
		}
	}

	[JsonProperty(PropertyName = "path", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return field;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			field = value;
		}
	}

	[JsonProperty(PropertyName = "body", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
			return field;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			field = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object GetPayload(IRemoteSerializer remoteSerializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (rS5UWrpWtxvwvX9Bh3c())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0077;
			}
		}
		goto IL_008f;
		IL_0039:
		JsonRemoteSerializer jsonRemoteSerializer = default;
		return jsonRemoteSerializer.DeserializeFromJToken(Body);
		IL_0077:
		string text = default;
		if (jsonRemoteSerializer == null)
		{
			text = (string)Hblkk3pYN2yZwykNBtM(Body);
			num = 6;
			goto IL_008f;
		}
		goto IL_0039;
		IL_008f:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 4:
				goto end_IL_008f;
			case 1:
				return null;
			case 2:
			case 3:
				goto IL_0077;
			default:
				num = 4;
				continue;
			case 6:
				return remoteSerializer.Deserialize<object>(text);
			}
			if (Body == null)
			{
				num = 1;
				continue;
			}
			jsonRemoteSerializer = remoteSerializer as JsonRemoteSerializer;
			goto IL_0077;
			continue;
			end_IL_008f:
			break;
		}
		goto IL_0039;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPayload(object payload, IRemoteSerializer remoteSerializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		JsonRemoteSerializer jsonRemoteSerializer = default;
		JToken jToken = default;
		do
		{
			IL_0065:
			switch (num)
			{
			case 9:
				Body = null;
				rS5UWrpWtxvwvX9Bh3c();
				if (!F8AiBfplbycLE18p3x8())
				{
					num = 1;
					goto IL_0065;
				}
				num = 0;
				if (rS5UWrpWtxvwvX9Bh3c())
				{
					goto IL_0065;
				}
				break;
			case 8:
				jsonRemoteSerializer = remoteSerializer as JsonRemoteSerializer;
				num = 5;
				if (true)
				{
					goto IL_0065;
				}
				return;
			case 1:
			case 4:
				return;
			default:
				num = 2;
				goto IL_0065;
			case 5:
				if (payload != null)
				{
					if (jToken != null)
					{
						goto case 2;
					}
					if (jsonRemoteSerializer == null)
					{
						Body = (JToken)VBM8mypzgLqka7oXe1v(remoteSerializer.Serialize(payload));
						num = 11;
					}
					else
					{
						num = 7;
					}
					goto IL_0065;
				}
				num = 9;
				if (!F8AiBfplbycLE18p3x8())
				{
					goto IL_0065;
				}
				return;
			case 10:
				return;
			case 3:
				jToken = payload as JToken;
				num = 8;
				goto IL_0065;
			case 0:
				return;
			case 6:
				return;
			case 2:
				Body = jToken;
				return;
			case 7:
				break;
			case 11:
				return;
			}
			Body = (JToken)goPDg6pgTpZC83cfIdy(jsonRemoteSerializer, payload);
			num = 10;
		}
		while (true);
	}

	public abstract string GetMessageType();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CogSocketMessage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		H88Lxu4m9qCW2AqO52D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rS5UWrpWtxvwvX9Bh3c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F8AiBfplbycLE18p3x8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hblkk3pYN2yZwykNBtM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonConvert.SerializeObject(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object goPDg6pgTpZC83cfIdy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JsonRemoteSerializer)P_0).SerializeToJToken(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VBM8mypzgLqka7oXe1v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JToken.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H88Lxu4m9qCW2AqO52D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
