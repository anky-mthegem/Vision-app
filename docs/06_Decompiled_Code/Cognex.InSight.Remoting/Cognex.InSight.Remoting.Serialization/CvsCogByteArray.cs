using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "Byte[]")]
public class CvsCogByteArray
{
	[CompilerGenerated]
	private string fpcUISlekJ;

	[JsonProperty(PropertyName = "base64")]
	public string Base64
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fpcUISlekJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fpcUISlekJ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogByteArray(string base64)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MTQ0W7WtaCmnYJJQ0E6();
		int num;
		if (!wyloOKWaf5NtMBrdGvS())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0080;
			}
		}
		goto IL_0040;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				zfmQdWWDR4dtduSHTMA(this);
				break;
			default:
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_0080;
		IL_0080:
		Base64 = base64;
		num = 5;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zfmQdWWDR4dtduSHTMA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MTQ0W7WtaCmnYJJQ0E6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wyloOKWaf5NtMBrdGvS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
