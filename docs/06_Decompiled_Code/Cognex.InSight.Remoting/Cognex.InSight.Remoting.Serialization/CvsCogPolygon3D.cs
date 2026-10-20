using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "Polygon3D")]
public class CvsCogPolygon3D : CvsCogShape3D
{
	[CompilerGenerated]
	private float[] M4DBJLGQSf;

	[CompilerGenerated]
	private string TOtBK5HJTD;

	[JsonProperty(PropertyName = "vertices", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public float[] Vertices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M4DBJLGQSf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M4DBJLGQSf = value;
		}
	}

	[JsonProperty(PropertyName = "style", DefaultValueHandling = DefaultValueHandling.Populate)]
	[DefaultValue("Regular")]
	public string Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TOtBK5HJTD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TOtBK5HJTD = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPolygon3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogPolygon3D(float[] vertices, int color = -16777077, string cellLocation = "")
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
			case 0:
				d9mieXIEJ2cbxy0GoTA();
				wcrybgIRrFyYUkFQiUf();
				num = ((!DJIQ8nIV4vcKHo2NQJe()) ? 6 : 5);
				continue;
			case 2:
				Color = color;
				break;
			case 1:
			case 5:
				base._002Ector();
				num = 3;
				continue;
			case 3:
				Vertices = vertices;
				goto case 2;
			default:
				num = 2;
				continue;
			case 4:
			case 6:
				break;
			case 7:
				return;
			}
			CellLocation = cellLocation;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DJIQ8nIV4vcKHo2NQJe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wcrybgIRrFyYUkFQiUf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d9mieXIEJ2cbxy0GoTA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
