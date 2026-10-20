using System.Runtime.CompilerServices;
using u;

namespace Cognex.Tako;

public class MousePos
{
	private int u;

	private double W;

	private double n;

	private double B;

	public double Z
	{
		get
		{
			return B;
		}
		set
		{
			B = value;
		}
	}

	public double Y
	{
		get
		{
			return n;
		}
		set
		{
			n = value;
		}
	}

	public double X
	{
		get
		{
			return W;
		}
		set
		{
			W = value;
		}
	}

	public int Id
	{
		get
		{
			return u;
		}
		set
		{
			u = value;
		}
	}

	public MousePos(int id_in, double x_in, double y_in, double z_in)
	{
		u = id_in;
		W = x_in;
		n = y_in;
		B = z_in;
	}

	public unsafe static MousePos toMousePos(Bk p)
	{
		return new MousePos(*(int*)(&p), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref p, 4)), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref p, 8)), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref p, 12)));
	}
}
