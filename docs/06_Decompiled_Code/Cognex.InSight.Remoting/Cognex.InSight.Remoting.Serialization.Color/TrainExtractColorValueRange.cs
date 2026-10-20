using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.Color;

[CvsSerializable(JsonName = "TrainExtractColorValueRange")]
public class TrainExtractColorValueRange
{
	private float[] ySUNIRjaGq;

	[CompilerGenerated]
	private readonly float iXHNrXL5dF;

	[CompilerGenerated]
	private readonly float XDiNQZcXrq;

	public float MinimumValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iXHNrXL5dF;
		}
	}

	public float MaximumValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XDiNQZcXrq;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorValueRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (xniwc5ZFZUVO65HnjBL() ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 2:
				iqtVPYZn1GdIJXeAkR8(this);
				num = 5;
				break;
			case 1:
			case 3:
				ySUNIRjaGq = new float[2];
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 4:
				DV2RuxZGJcFjDOnhfnQ();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorValueRange(float[] rangeValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xn2H8lZo2BI585MfLLG();
		int num = (xniwc5ZFZUVO65HnjBL() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				XDiNQZcXrq = rangeValue[1];
				num = 8;
				break;
			case 6:
				ySUNIRjaGq = new float[2];
				goto case 1;
			case 7:
				throw new ArgumentException();
			case 5:
				while (rangeValue != null && rangeValue.Length == 2)
				{
					iXHNrXL5dF = rangeValue[0];
					num = 4;
					if (true)
					{
						goto end_IL_009e;
					}
				}
				goto case 7;
			default:
				num = 7;
				break;
			case 1:
			case 2:
				iqtVPYZn1GdIJXeAkR8(this);
				num = 5;
				break;
			case 0:
			case 3:
				DV2RuxZGJcFjDOnhfnQ();
				num = 6;
				if (1 == 0)
				{
					return;
				}
				break;
			case 8:
				return;
				end_IL_009e:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DV2RuxZGJcFjDOnhfnQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iqtVPYZn1GdIJXeAkR8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xn2H8lZo2BI585MfLLG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xniwc5ZFZUVO65HnjBL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
