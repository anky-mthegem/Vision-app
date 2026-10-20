using System.Runtime.CompilerServices;
using System.Windows.Media;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "FixtureData")]
public class FixtureData
{
	[CompilerGenerated]
	private double fp6C7DjrGL;

	[CompilerGenerated]
	private double lGWCWaXu8Z;

	[CompilerGenerated]
	private double qGBCoyY2op;

	[JsonProperty(PropertyName = "angle")]
	public double Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fp6C7DjrGL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fp6C7DjrGL = value;
		}
	}

	[JsonProperty(PropertyName = "x")]
	public double X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lGWCWaXu8Z;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lGWCWaXu8Z = value;
		}
	}

	[JsonProperty(PropertyName = "y")]
	public double Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qGBCoyY2op;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qGBCoyY2op = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Matrix GetPose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_003f;
		IL_001a:
		Matrix identity = default;
		identity.Translate(X, Y);
		goto IL_008c;
		IL_003f:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 4:
				goto IL_006c;
			default:
				goto IL_008c;
			case 5:
				return identity;
			}
			break;
			IL_006c:
			identity = Matrix.Identity;
			PZ8IIHwfXVTeKYsp0jV();
			num = (TWgH31wD9IvxD3ccPqr() ? 3 : 0);
		}
		goto IL_001a;
		IL_008c:
		identity.RotateAt(Angle, X, Y);
		num = 5;
		goto IL_003f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixtureData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wh5VhmwUUEGgU6dOXYt();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TWgH31wD9IvxD3ccPqr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PZ8IIHwfXVTeKYsp0jV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wh5VhmwUUEGgU6dOXYt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
