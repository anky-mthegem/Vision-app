using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Media;
using Cognex.ThreeD.Geometry;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Services;

public class DownloadedQuadMeshData : IDownloadedData
{
	[CompilerGenerated]
	private Task<QuadMesh> hTgyNEKvr;

	[CompilerGenerated]
	private ResourceDownloadWithProgress<byte[]> cwF16ZoO6;

	[CompilerGenerated]
	private ResourceDownloadWithProgress<Bitmap> bpsRvhw0r;

	[CompilerGenerated]
	private Task<Matrix> ruxDl9s4V;

	public Task<QuadMesh> LowRes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hTgyNEKvr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hTgyNEKvr = value;
		}
	}

	public ResourceDownloadWithProgress<byte[]> HighRes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cwF16ZoO6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cwF16ZoO6 = value;
		}
	}

	public ResourceDownloadWithProgress<Bitmap> Texture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bpsRvhw0r;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bpsRvhw0r = value;
		}
	}

	public Task<Matrix> TextureTransform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ruxDl9s4V;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ruxDl9s4V = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DownloadedQuadMeshData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!eWJKym0NxfhXDafuBR())
		{
			goto IL_001e;
		}
		goto IL_0050;
		IL_001e:
		Texture = new ResourceDownloadWithProgress<Bitmap>();
		num = 0;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 3:
				HighRes = new ResourceDownloadWithProgress<byte[]>();
				break;
			case 0:
				TextureTransform = null;
				num = 8;
				continue;
			case 7:
				yIoybVJPPF4SLhaiH5();
				num = 1;
				continue;
			case 2:
			case 5:
				LowRes = null;
				num = 3;
				continue;
			case 1:
				Qkde2X8XTlWJIgJWMi(this);
				_ = 1;
				num = ((!QHY7uPPpTu3ftdi6bZ()) ? 5 : 6);
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yIoybVJPPF4SLhaiH5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qkde2X8XTlWJIgJWMi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eWJKym0NxfhXDafuBR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QHY7uPPpTu3ftdi6bZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
