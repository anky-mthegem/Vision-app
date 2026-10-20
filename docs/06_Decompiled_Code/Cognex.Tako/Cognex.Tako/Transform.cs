using System.Runtime.CompilerServices;
using std;

namespace Cognex.Tako;

public class Transform
{
	private float[] u;

	public float[] values
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

	public Transform(float[] t)
	{
		u = t;
	}

	public unsafe static Transform to_ManagedTransform(array_003Cfloat_002C16_003E v)
	{
		//IL_001b: Expected I, but got I8
		float[] array = new float[16];
		int num = 0;
		array_003Cfloat_002C16_003E* ptr = &v;
		do
		{
			array[num] = *(float*)ptr;
			num++;
			ptr = (array_003Cfloat_002C16_003E*)((ulong)(nint)ptr + 4uL);
		}
		while (num < 16);
		return new Transform(array);
	}

	public unsafe static array_003Cfloat_002C16_003E to_NativeTransform(Transform v)
	{
		//IL_001a: Expected I, but got I8
		int num = 0;
		float[] array = v.u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C16_003E result);
		array_003Cfloat_002C16_003E* ptr = &result;
		do
		{
			*(float*)ptr = array[num];
			num++;
			ptr = (array_003Cfloat_002C16_003E*)((ulong)(nint)ptr + 4uL);
		}
		while (num < 16);
		return result;
	}

	public override string ToString()
	{
		float[] array = u;
		string text = " , ";
		string text2 = "\n";
		return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("{" + array[0], text), array[1]), text), array[2]), text), array[3]), text2), array[4]), text), array[5]), text), array[6]), text), array[7]), text2), array[8]), text), array[9]), text), array[10]), text), array[11]), text2), array[12]), text), array[13]), text), array[14]), text), array[15]), "}");
	}
}
