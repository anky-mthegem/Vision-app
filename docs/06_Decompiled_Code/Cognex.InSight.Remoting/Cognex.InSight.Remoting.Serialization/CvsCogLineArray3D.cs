using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "LineArray3D")]
public class CvsCogLineArray3D : CvsCogShape3D
{
	[CompilerGenerated]
	private float[] FNxBAZ0uU6;

	[CompilerGenerated]
	private string HjKBH1MTkp;

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
			return FNxBAZ0uU6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FNxBAZ0uU6 = value;
		}
	}

	[DefaultValue("Regular")]
	[JsonProperty(PropertyName = "style", DefaultValueHandling = DefaultValueHandling.Populate)]
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
			return HjKBH1MTkp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HjKBH1MTkp = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLineArray3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ltLsN9PetMeukmAovEQ();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogLineArray3D(float[] vertices, int color = -16777077, string cellLocation = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		we2w5xPv1yNWIiUGhWh();
		int num = (vcLFdZP3DA7Y8LpLJZx() ? 5 : 6);
		while (true)
		{
			switch (num)
			{
			case 4:
				CellLocation = cellLocation;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				Vertices = vertices;
				break;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				base._002Ector();
				num = 3;
				continue;
			case 0:
			case 6:
				ltLsN9PetMeukmAovEQ();
				goto case 1;
			case 2:
				break;
			case 7:
				return;
			}
			Color = color;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ltLsN9PetMeukmAovEQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool we2w5xPv1yNWIiUGhWh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vcLFdZP3DA7Y8LpLJZx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
