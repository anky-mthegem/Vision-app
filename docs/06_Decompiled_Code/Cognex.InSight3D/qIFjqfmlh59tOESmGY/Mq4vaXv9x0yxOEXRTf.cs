using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using AkHicK0bA1TrKhYAY7;
using Cognex.Designer.Remote;
using Cognex.Designer.Remote.View;
using Cognex.InSight3D.Data;
using GHWKpuG7rE0PZAeeF5;

namespace qIFjqfmlh59tOESmGY;

internal class Mq4vaXv9x0yxOEXRTf : TypeConverter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvertFrom(ITypeDescriptorContext P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!(P_1 == typeof(Ref)))
		{
			return P_1 == typeof(View);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertFrom(ITypeDescriptorContext P_0, CultureInfo P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (QlMDKI4yWAvdNpCL4fg())
		{
			num = 7;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_00a3;
			}
		}
		goto IL_0068;
		IL_00a3:
		Ref obj = default;
		if (obj == null)
		{
			num = 5;
		}
		else
		{
			if (!l0NDbL49Ktj1vGCPTu2(xrW6tE4dZJL7cS4U1U4(obj), M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(14), StringComparison.OrdinalIgnoreCase))
			{
				if (((string)xrW6tE4dZJL7cS4U1U4(obj)).Equals((string)x5vUlm4VcadKUfaKt8H(22), StringComparison.OrdinalIgnoreCase))
				{
					goto IL_00f3;
				}
				goto IL_012a;
			}
			num = 2;
		}
		goto IL_0068;
		IL_012a:
		return base.ConvertFrom(P_0, P_1, P_2);
		IL_0068:
		ThreeDLayer threeDLayer = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				return BBKSwT415qVRimG75Sw(obj);
			case 1:
				goto end_IL_0068;
			case 5:
				return mEOQbb4LEUQ7t54nt77(this, P_0, P_1, P_2);
			case 0:
			case 7:
				obj = P_2 as Ref;
				num = 1;
				continue;
			default:
				goto IL_00f3;
			case 8:
				return Image3D.Create(new Ref((string)x5vUlm4VcadKUfaKt8H(14), refAutoAdded: false, (string)tNIGFn4kRikGFkjB3Ow(threeDLayer)));
			}
			if (threeDLayer != null)
			{
				num = 8;
				continue;
			}
			goto IL_012a;
			continue;
			end_IL_0068:
			break;
		}
		goto IL_00a3;
		IL_00f3:
		threeDLayer = ((View)fmWkfF4I8vuJC4hM6x0(obj)).GetLayers<ThreeDLayer>().FirstOrDefault();
		num = 3;
		goto IL_0068;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvertTo(ITypeDescriptorContext P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_1 == SjYdjR4m9sQPbM0AhIe(typeof(Ref).TypeHandle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertTo(ITypeDescriptorContext P_0, CultureInfo P_1, object P_2, Type P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (eOdR404Q6MONeiqT7Nb() ? 4 : 2);
		Image3D image3D = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				image3D = P_2 as Image3D;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				if (image3D == null)
				{
					break;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (!HiWuRj47bHGXipwa1eg(P_3, SjYdjR4m9sQPbM0AhIe(typeof(Ref).TypeHandle)))
				{
					break;
				}
				goto case 1;
			case 5:
				return image3D.Ref;
			}
			break;
		}
		return zuqvFg46NvGEK2CM1Nb(this, P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mq4vaXv9x0yxOEXRTf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eUbTRI40LsLfG4KiJb6();
		KgxZmo4PRexXl24xy2e(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QlMDKI4yWAvdNpCL4fg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eOdR404Q6MONeiqT7Nb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mEOQbb4LEUQ7t54nt77(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xrW6tE4dZJL7cS4U1U4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Ref)P_0).ContentType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l0NDbL49Ktj1vGCPTu2(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BBKSwT415qVRimG75Sw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Image3D.Create((Ref)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x5vUlm4VcadKUfaKt8H(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fmWkfF4I8vuJC4hM6x0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return View.Create((Ref)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tNIGFn4kRikGFkjB3Ow(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ThreeDLayer)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type SjYdjR4m9sQPbM0AhIe(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HiWuRj47bHGXipwa1eg(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zuqvFg46NvGEK2CM1Nb(object P_0, object P_1, object P_2, object P_3, Type P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertTo((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eUbTRI40LsLfG4KiJb6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KgxZmo4PRexXl24xy2e(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TypeConverter)P_0)._002Ector();
	}
}
