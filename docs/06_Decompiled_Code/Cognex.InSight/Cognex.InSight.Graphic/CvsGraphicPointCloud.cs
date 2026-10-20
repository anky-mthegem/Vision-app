using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public class CvsGraphicPointCloud : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags RvqMJPu5ch;

	[CompilerGenerated]
	private CvsCogPointCloud lxuMMtVM0r;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RvqMJPu5ch;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (fyLXKUO4iEwoURiQwiN() ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					num = 3;
					continue;
				case 3:
					RvqMJPu5ch = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					break;
				case 5:
					return;
				}
				A73p9vOgI2yUl5Ephom(this, hTxDLaOy2vKqW36qtvk(33720));
				num = 5;
				if (fyLXKUO4iEwoURiQwiN())
				{
				}
			}
		}
	}

	public CvsCogPointCloud PointCloud
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lxuMMtVM0r;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lxuMMtVM0r = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPointCloud(CvsCellLocation cellLocation, CvsCogEditingPointCloud editPointCloud)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogPointCloud pointCloud = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				RvqMJPu5ch = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				break;
			case 3:
				pointCloud = (CvsCogPointCloud)oq47hyOfDoTaSYHGU4Z(editPointCloud);
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				pHMKjrOkKBqcPqI11Xg();
				_ = 0;
				num = (EP8eBKO0Pp6NsByXIKl() ? 5 : 0);
				continue;
			case 6:
				EditFlags = (CvsEditFlags)((editPointCloud.Move ? 1 : 0) | (wR2Go7OFixRjljRfWYS(editPointCloud) ? 2 : 0) | (LxqQ4IOmsbdhcbDVvey(editPointCloud) ? 4 : 0));
				num = 8;
				continue;
			case 7:
				FromSerializableGraphic(pointCloud);
				num = 6;
				if (EP8eBKO0Pp6NsByXIKl())
				{
					continue;
				}
				break;
			case 0:
			case 2:
				break;
			case 8:
				return;
			}
			base._002Ector(cellLocation, editPointCloud);
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPointCloud(CvsGraphicPointCloud graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fyLXKUO4iEwoURiQwiN())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0067;
		IL_0026:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 1;
		if (1 == 0)
		{
			goto IL_0037;
		}
		goto IL_0067;
		IL_0067:
		switch (num)
		{
		case 0:
		case 4:
			break;
		case 1:
			goto IL_0037;
		case 5:
			goto IL_004e;
		default:
			goto IL_0098;
		case 6:
			return;
		}
		goto IL_0026;
		IL_0037:
		RvqMJPu5ch = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		num = 5;
		if (!EP8eBKO0Pp6NsByXIKl())
		{
			goto IL_004e;
		}
		goto IL_0067;
		IL_0098:
		RvqMJPu5ch = graphic.RvqMJPu5ch;
		num = 6;
		goto IL_0067;
		IL_004e:
		base._002Ector(graphic);
		goto IL_0098;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPointCloud()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				RvqMJPu5ch = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				break;
			case 3:
				pHMKjrOkKBqcPqI11Xg();
				fyLXKUO4iEwoURiQwiN();
				num = (EP8eBKO0Pp6NsByXIKl() ? 4 : 0);
				continue;
			case 5:
				return;
			}
			base._002Ector();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPointCloud(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogPointCloud pointCloud)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(pointCloud);
		PointCloud = pointCloud;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogPointCloud(PointCloud);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pHMKjrOkKBqcPqI11Xg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oq47hyOfDoTaSYHGU4Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPointCloud)P_0).PointCloud;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wR2Go7OFixRjljRfWYS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LxqQ4IOmsbdhcbDVvey(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EP8eBKO0Pp6NsByXIKl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fyLXKUO4iEwoURiQwiN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hTxDLaOy2vKqW36qtvk(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A73p9vOgI2yUl5Ephom(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
