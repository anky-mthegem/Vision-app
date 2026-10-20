using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[Serializable]
[CvsSerializable(JsonName = "Rectangle3D")]
public class CvsCogRect3D : CvsCogShape3D
{
	[CompilerGenerated]
	private double[] KywBRWMRVm;

	[CompilerGenerated]
	private bool sgtBaCstCl;

	[CompilerGenerated]
	private string lsIBxFGjsx;

	[CompilerGenerated]
	private string oofB6BcVQV;

	[CompilerGenerated]
	private string TDsBpcFkkG;

	[JsonProperty(PropertyName = "size")]
	public double[] Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KywBRWMRVm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KywBRWMRVm = value;
		}
	}

	[JsonProperty(PropertyName = "axisIndicator", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool AxisIndicator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sgtBaCstCl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sgtBaCstCl = value;
		}
	}

	[DefaultValue("X")]
	[JsonProperty(PropertyName = "xAxisLabel", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string xAxisLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lsIBxFGjsx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lsIBxFGjsx = value;
		}
	}

	[DefaultValue("Y")]
	[JsonProperty(PropertyName = "yAxisLabel", DefaultValueHandling = DefaultValueHandling.Populate)]
	public string yAxisLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oofB6BcVQV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oofB6BcVQV = value;
		}
	}

	[JsonProperty(PropertyName = "zAxisLabel", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue("Z")]
	public string zAxisLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TDsBpcFkkG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TDsBpcFkkG = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRect3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SLkqX1ITQmcsGDqjODA();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogRect3D(double[] modelMatrix, double[] size, int color = -16777077, string cellLocation = "")
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
			case 4:
				Color = color;
				goto case 0;
			case 0:
			case 5:
				CellLocation = cellLocation;
				num = 8;
				continue;
			case 3:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				base._002Ector();
				num = 7;
				continue;
			case 7:
				ModelMatrix = modelMatrix;
				num = 2;
				continue;
			case 2:
				Size = size;
				break;
			case 8:
				return;
			}
			_ = 1;
			if (hfiKiqI5wCwTDm1aebr())
			{
				num = 0;
				continue;
			}
			num = 1;
			if (!Tq2g1UIK8vUXihNgFTJ())
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SLkqX1ITQmcsGDqjODA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Tq2g1UIK8vUXihNgFTJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hfiKiqI5wCwTDm1aebr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
