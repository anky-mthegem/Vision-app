using System;
using System.Annotations;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.Extensions;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsErrorResponseNetworkException : CvsNetworkException
{
	public static readonly string DataPathKey;

	public static readonly string AdditionalDataMessageKey;

	public static readonly string AdditionalDataResourceIdKey;

	[CompilerGenerated]
	private int BNtxb4ObLa;

	[CompilerGenerated]
	private object AWBxa2eb4Q;

	public override string Message
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			string text = default;
			object value = default;
			string text2 = default;
			while (true)
			{
				IL_00cf:
				object obj;
				switch (num)
				{
				case 0:
					if (text == null)
					{
						break;
					}
					goto case 2;
				case 1:
					while (((IDictionary)AGUSnZEIogvh6ps1tMq(this)).TryGet(DataPathKey, out value))
					{
						c1jnrWEOTkuyEABSB0S();
						if (EdcjIREMA9btCjbj2GV())
						{
							num = 2;
							if (1 == 0)
							{
								continue;
							}
						}
						else
						{
							num = 6;
						}
						goto IL_00cf;
					}
					break;
				case 2:
				case 5:
					text2 = (string)BHGTlREaPd2TAAOwJEm(text2, Sj7Qv2ERpCVOueZH3sK(), hoqNAuElS7CBVvKYiIX(6116), text);
					num = 8;
					continue;
				case 4:
					obj = ErrorMessage;
					if (obj == null)
					{
						num = 7;
						continue;
					}
					goto IL_009f;
				case 7:
					obj = mp8tfvEupD8iYKhOnIo(this);
					goto IL_009f;
				case 3:
				case 6:
					text = value as string;
					goto case 0;
				default:
					num = 0;
					continue;
				case 8:
					break;
					IL_009f:
					text2 = (string)obj;
					if (!CogSocketRemoteDeviceApi.ShouldPutPathsInExceptions)
					{
						break;
					}
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				break;
			}
			return text2;
		}
	}

	public int ErrorCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BNtxb4ObLa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BNtxb4ObLa = value;
		}
	}

	[CanBeNull]
	public string ErrorMessage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
				case 5:
					return null;
				default:
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					return null;
				case 1:
				case 4:
				{
					JObject obj = AdditionalData as JObject;
					if (obj != null)
					{
						JToken? jToken = obj[AdditionalDataMessageKey];
						if (jToken == null)
						{
							goto case 3;
						}
						return jToken.ToString();
					}
					goto case 2;
				}
				case 0:
				{
					while (AdditionalData is JObject)
					{
						c1jnrWEOTkuyEABSB0S();
						if (EdcjIREMA9btCjbj2GV())
						{
							num = 5;
							if (true)
							{
								goto end_IL_003d;
							}
							continue;
						}
						goto IL_00cc;
					}
					object additionalData = AdditionalData;
					if (additionalData == null)
					{
						num = 6;
						break;
					}
					return additionalData.ToString();
				}
				case 6:
					{
						return null;
					}
					IL_00cc:
					num = 4;
					if (!EdcjIREMA9btCjbj2GV())
					{
						break;
					}
					goto case 6;
					end_IL_003d:
					break;
				}
			}
		}
	}

	[CanBeNull]
	public int? ErrorResourceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (AdditionalData as JObject)?[AdditionalDataResourceIdKey]?.ToObject<int>();
		}
	}

	[CanBeNull]
	public object AdditionalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AWBxa2eb4Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AWBxa2eb4Q = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsErrorResponseNetworkException(int errorCode, object additionalData, Exception innerException)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EdcjIREMA9btCjbj2GV();
		int num;
		if (c1jnrWEOTkuyEABSB0S())
		{
			num = 4;
			if (!c1jnrWEOTkuyEABSB0S())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_006d;
		IL_009a:
		base._002Ector(innerException);
		num = 2;
		goto IL_006d;
		IL_006d:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 5:
				AdditionalData = additionalData;
				num = 6;
				continue;
			case 2:
				ErrorCode = errorCode;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_009a;
			case 1:
			case 3:
				goto IL_009a;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		uHYBF0EQPthAZxMaqna();
		goto IL_009a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsErrorResponseNetworkException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!c1jnrWEOTkuyEABSB0S()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 5:
				ErrorCode = fak4o0EeCbfUZZ9KsEi(info, hoqNAuElS7CBVvKYiIX(6062));
				goto case 4;
			default:
				num = 4;
				if (EdcjIREMA9btCjbj2GV())
				{
				}
				continue;
			case 0:
			case 2:
				uHYBF0EQPthAZxMaqna();
				break;
			case 4:
				AdditionalData = info.GetValue((string)hoqNAuElS7CBVvKYiIX(6084), typeof(object));
				num = 6;
				if (EdcjIREMA9btCjbj2GV())
				{
				}
				continue;
			case 1:
			case 3:
				break;
			case 6:
				return;
			}
			base._002Ector(info, context);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		c1jnrWEOTkuyEABSB0S();
		int num = (EdcjIREMA9btCjbj2GV() ? 1 : 5);
		while (true)
		{
			switch (num)
			{
			default:
				base.GetObjectData(info, context);
				num = 6;
				break;
			case 2:
				throw new ArgumentException((string)hoqNAuElS7CBVvKYiIX(6140));
			case 0:
			case 5:
				if (info != null)
				{
					KaOjGUEnmMVHWcoyOw1(info, hoqNAuElS7CBVvKYiIX(6062), ErrorCode);
					num = 4;
					break;
				}
				num = 2;
				if (c1jnrWEOTkuyEABSB0S())
				{
					break;
				}
				goto case 4;
			case 4:
				info.AddValue((string)hoqNAuElS7CBVvKYiIX(6084), AdditionalData);
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsErrorResponseNetworkException()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EdcjIREMA9btCjbj2GV();
		int num;
		if (c1jnrWEOTkuyEABSB0S())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_004b;
		IL_0097:
		AdditionalDataResourceIdKey = (string)hoqNAuElS7CBVvKYiIX(6212);
		num = 6;
		if (0 == 0)
		{
			goto IL_004b;
		}
		goto IL_00b2;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				DataPathKey = kgbOBx7BanbFa22Hp9.ol99ukmDA(6182);
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_0097;
			default:
				goto IL_0097;
			case 0:
			case 1:
				goto IL_00b2;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		AdditionalDataMessageKey = (string)hoqNAuElS7CBVvKYiIX(6194);
		goto IL_0097;
		IL_00b2:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 2;
		goto IL_004b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uHYBF0EQPthAZxMaqna()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c1jnrWEOTkuyEABSB0S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EdcjIREMA9btCjbj2GV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hoqNAuElS7CBVvKYiIX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fak4o0EeCbfUZZ9KsEi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetInt32((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mp8tfvEupD8iYKhOnIo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AGUSnZEIogvh6ps1tMq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Exception)P_0).Data;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Sj7Qv2ERpCVOueZH3sK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Environment.NewLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BHGTlREaPd2TAAOwJEm(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KaOjGUEnmMVHWcoyOw1(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
