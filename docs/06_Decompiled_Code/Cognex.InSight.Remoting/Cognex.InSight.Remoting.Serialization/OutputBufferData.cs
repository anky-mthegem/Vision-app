using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "outputBufferData")]
public class OutputBufferData
{
	[CompilerGenerated]
	private int xpIIuoTlUu;

	[CompilerGenerated]
	private CvsCogByteArray TVYIZMj0Cv;

	[JsonProperty("numOfElements")]
	public int ElementCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xpIIuoTlUu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xpIIuoTlUu = value;
		}
	}

	[JsonProperty("packetData")]
	public CvsCogByteArray BufferData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TVYIZMj0Cv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TVYIZMj0Cv = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputBufferData(CvsCogByteArray bufferData, int elementCount)
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
			case 1:
			case 4:
				zEvyYeq93h9tJ7qiBRo(this);
				goto case 2;
			case 2:
			case 5:
				ElementCount = elementCount;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				BufferData = bufferData;
				num = 6;
				break;
			case 0:
				LsBehFqNuv1XqLSfrSe();
				_ = 1;
				num = ((!HZIGXoqgoDs95o07iKq()) ? 4 : 5);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LsBehFqNuv1XqLSfrSe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zEvyYeq93h9tJ7qiBRo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bBLY6bqbMNn6AweXMwv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HZIGXoqgoDs95o07iKq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
