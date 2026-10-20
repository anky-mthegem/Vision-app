using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "EditingNumber")]
public class CvsCogEditingNumber : CvsCogEditingObject
{
	[CompilerGenerated]
	private double OySCe9ZFyO;

	[CompilerGenerated]
	private double q93CF9r1IQ;

	[CompilerGenerated]
	private double y69CCChh9s;

	[CompilerGenerated]
	private int bQ8CYCd5jW;

	[CompilerGenerated]
	private double YXSC56Q7lF;

	[JsonProperty(PropertyName = "data", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OySCe9ZFyO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OySCe9ZFyO = value;
		}
	}

	[JsonProperty(PropertyName = "min", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q93CF9r1IQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			q93CF9r1IQ = value;
		}
	}

	[JsonProperty(PropertyName = "max", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y69CCChh9s;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			y69CCChh9s = value;
		}
	}

	[JsonProperty(PropertyName = "decimalPlaces")]
	public int DecimalPlaces
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bQ8CYCd5jW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bQ8CYCd5jW = value;
		}
	}

	[JsonProperty(PropertyName = "increment", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double Increment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YXSC56Q7lF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YXSC56Q7lF = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogEditingNumber()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!W5ZHbYsk7OcapbFtYTL())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				Increment = double.NaN;
				num = 6;
				break;
			case 0:
			case 2:
				DecimalPlaces = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 3:
				base._002Ector();
				goto case 0;
			case 4:
				IkParCsMugigKExf9V5();
				_ = 0;
				if (!Jyqyw4sd7j9DxdKJi7n())
				{
					num = 0;
					break;
				}
				num = 3;
				if (false)
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IkParCsMugigKExf9V5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jyqyw4sd7j9DxdKJi7n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W5ZHbYsk7OcapbFtYTL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
