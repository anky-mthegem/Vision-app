using System.ComponentModel;
using System.Runtime.CompilerServices;
using AkHicK0bA1TrKhYAY7;
using Cognex.Designer.Core;
using Cognex.Designer.Remote;
using GHWKpuG7rE0PZAeeF5;
using qIFjqfmlh59tOESmGY;

namespace Cognex.InSight3D.Data;

[TypeConverter(typeof(Mq4vaXv9x0yxOEXRTf))]
[TypeName("3D Image")]
public class Image3D : IRemoteImage
{
	public const string ContentTypeID = "3D";

	[CompilerGenerated]
	private Ref vOdnevWT1;

	public Ref Ref
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vOdnevWT1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vOdnevWT1 = value;
		}
	}

	public string Url
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ref obj = Ref;
			if (obj == null)
			{
				return null;
			}
			return (string)s3v4644OICyaqPsJ50r(obj);
		}
	}

	public string ContentType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ref obj = Ref;
			if (obj == null)
			{
				return null;
			}
			return (string)punsMb4a0qWHWuMYFm1(obj);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Image3D Create(Ref @ref)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!HgrxoF4jcQJoxGZtbqF((@ref != null) ? punsMb4a0qWHWuMYFm1(@ref) : null, gYjcC14CTOwbn06Ke4d(14)))
		{
			Image3D image3D = new Image3D();
			FoABwH4tHhpSvHrTRUw(image3D, @ref);
			return image3D;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Image3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EUpS5p4HiI8FuAH8CA0();
		IJi18d4Wg88bN7HSnnn(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q8BLmc4pZgjPdqABs5Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KrNN5j4oGj3WtkkGbY6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s3v4644OICyaqPsJ50r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Ref)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object punsMb4a0qWHWuMYFm1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Ref)P_0).ContentType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gYjcC14CTOwbn06Ke4d(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HgrxoF4jcQJoxGZtbqF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FoABwH4tHhpSvHrTRUw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image3D)P_0).Ref = (Ref)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EUpS5p4HiI8FuAH8CA0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IJi18d4Wg88bN7HSnnn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
