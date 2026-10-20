using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cognex.InSight3D.Acquistion;
using Cognex.ThreeD.Geometry;
using YYNs7EWJ0BnMDIuHpG;

namespace Cognex.InSight3D.Helpers;

public static class PointCloudHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IImageGeometry3D GetGeometry3D(this PointCloudData d)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream(d.EncodedPointCloud);
		try
		{
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			try
			{
				return (IImageGeometry3D)WC7k4H2pPp9dVynV3h(binaryReader);
			}
			finally
			{
				if (binaryReader != null)
				{
					Lwirju5ZJq9pXpVhlh(binaryReader);
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				Lwirju5ZJq9pXpVhlh(memoryStream);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WC7k4H2pPp9dVynV3h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return U2UsKSXlrvh88x8y6C.eUElSBHmx((BinaryReader)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lwirju5ZJq9pXpVhlh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oAx1ytfZSf5ef29fX2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qp6pvlGI8x3DJRdbTl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
