using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cognex.InSight.Properties;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsInvalidLogonException : CvsException
{
	private readonly bool XfabZBicsX;

	public bool IsInvalidUsername
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XfabZBicsX;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidLogonException(bool isInvalidUsername)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!FgMYrDU8Hc5bGw4Jg8R())
		{
			num = 2;
			if (FgMYrDU8Hc5bGw4Jg8R())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0056;
		IL_002a:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 5;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 6:
				base._002Ector((string)MP6hFOUzduNr22MZ92x());
				goto case 3;
			default:
				num = 3;
				if (!FgMYrDU8Hc5bGw4Jg8R())
				{
					continue;
				}
				goto case 5;
			case 5:
				XfabZBicsX = true;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				XfabZBicsX = isInvalidUsername;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				HResult = -2147221503;
				goto case 1;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidLogonException(string message, bool isInvalidUsername)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				XfabZBicsX = true;
				goto case 0;
			case 5:
				ueF73cTsPhF9cdSeNMo(this, -2147221503);
				num = 4;
				break;
			case 0:
			case 2:
				base._002Ector(message);
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				XfabZBicsX = isInvalidUsername;
				num = 7;
				break;
			case 3:
				WQOYMQTwVT1vbfWaRYt();
				FgMYrDU8Hc5bGw4Jg8R();
				if (!HjG8MrUJ6BMs6kLyWEH())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidLogonException(string message, Exception innerException, bool isInvalidUsername)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (HjG8MrUJ6BMs6kLyWEH() ? 1 : 6);
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				XfabZBicsX = isInvalidUsername;
				num = 7;
				break;
			case 0:
			case 1:
				WQOYMQTwVT1vbfWaRYt();
				num = 2;
				if (HjG8MrUJ6BMs6kLyWEH())
				{
					break;
				}
				goto case 3;
			case 3:
				base._002Ector(message, innerException);
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				ueF73cTsPhF9cdSeNMo(this, -2147221503);
				goto case 4;
			case 2:
				XfabZBicsX = true;
				num = 3;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private CvsInvalidLogonException(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!HjG8MrUJ6BMs6kLyWEH()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 6:
				base._002Ector(info, context);
				goto case 2;
			default:
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				XfabZBicsX = true;
				num = 6;
				break;
			case 2:
				HResult = -2147221503;
				num = 5;
				if (HjG8MrUJ6BMs6kLyWEH())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				WQOYMQTwVT1vbfWaRYt();
				goto case 1;
			case 5:
				XfabZBicsX = lZwHPOThdlr9uXy5Q1O(info, kgbOBx7BanbFa22Hp9.ol99ukmDA(8808));
				num = 7;
				break;
			case 7:
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
		UIOjQuTLZ8rPdoX2ZOf(this, info, context);
		info.AddValue(kgbOBx7BanbFa22Hp9.ol99ukmDA(8808), XfabZBicsX, lomFRLT9nMlCpFHIVFc(typeof(bool).TypeHandle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MP6hFOUzduNr22MZ92x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidLogonException;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HjG8MrUJ6BMs6kLyWEH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FgMYrDU8Hc5bGw4Jg8R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WQOYMQTwVT1vbfWaRYt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ueF73cTsPhF9cdSeNMo(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lZwHPOThdlr9uXy5Q1O(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetBoolean((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UIOjQuTLZ8rPdoX2ZOf(object P_0, object P_1, StreamingContext P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).GetObjectData((SerializationInfo)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type lomFRLT9nMlCpFHIVFc(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
