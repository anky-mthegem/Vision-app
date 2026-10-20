using System.Runtime.CompilerServices;
using std;

namespace Cognex.Tako;

public class ImageTransform
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

	public ImageTransform(float[] t)
	{
		u = t;
	}

	public ImageTransform(float m11, float m12, float m21, float m22, float offsetX, float offsetY)
	{
		u = new float[6] { m11, m12, offsetX, m21, m22, offsetY };
	}

	public unsafe static ImageTransform to_ManagedTransform(array_003Cfloat_002C6_003E v)
	{
		//IL_001a: Expected I, but got I8
		float[] array = new float[6];
		int num = 0;
		array_003Cfloat_002C6_003E* ptr = &v;
		do
		{
			array[num] = *(float*)ptr;
			num++;
			ptr = (array_003Cfloat_002C6_003E*)((ulong)(nint)ptr + 4uL);
		}
		while (num < 6);
		return new ImageTransform(array);
	}

	public unsafe static array_003Cfloat_002C6_003E to_NativeTransform(ImageTransform v)
	{
		//IL_001a: Expected I, but got I8
		int num = 0;
		float[] array = v.u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C6_003E result);
		array_003Cfloat_002C6_003E* ptr = &result;
		do
		{
			*(float*)ptr = array[num];
			num++;
			ptr = (array_003Cfloat_002C6_003E*)((ulong)(nint)ptr + 4uL);
		}
		while (num < 6);
		return result;
	}

	public override string ToString()
	{
		float[] array = u;
		string text = " , ";
		return string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("{" + array[0], text), array[1]), text), array[2]), text), array[3]), "\n"), array[4]), text), array[5]), "}");
	}
}
