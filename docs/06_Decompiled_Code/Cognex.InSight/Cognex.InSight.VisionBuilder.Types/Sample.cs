using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

public class Sample
{
	[CompilerGenerated]
	private string ETkhfAmXtb;

	[CompilerGenerated]
	private string p4hhjqaCtl;

	[CompilerGenerated]
	private string[] WpWhcMWABv;

	[CompilerGenerated]
	private string hE0h5Rf9jT;

	[JsonProperty("sample_id")]
	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ETkhfAmXtb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ETkhfAmXtb = value;
		}
	}

	[JsonProperty("name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return p4hhjqaCtl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			p4hhjqaCtl = value;
		}
	}

	[JsonProperty("tag_ids")]
	public string[] TagIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WpWhcMWABv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WpWhcMWABv = value;
		}
	}

	[JsonProperty("created")]
	public string CreationDate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hE0h5Rf9jT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hE0h5Rf9jT = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sample()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v6immGcenqu7IBLgUvN();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sample(ImageMetadata metadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!K8LlH5cQvpJKKvIMhKt()) ? 6 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
				TagIds = metadata.TagIds;
				num = 5;
				if (K8LlH5cQvpJKKvIMhKt())
				{
					break;
				}
				goto case 4;
			case 4:
				Id = (string)i2p2aIcI76LNAPpyQlq(metadata);
				goto case 3;
			case 7:
				VgwWoYcurEFbcG07bSF(this);
				num = 4;
				break;
			case 0:
			case 2:
				v6immGcenqu7IBLgUvN();
				num = 7;
				break;
			case 5:
				CreationDate = metadata.Timestamp;
				num = 8;
				break;
			case 3:
			case 6:
				Name = metadata.Id;
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is Sample sample)
		{
			return vcqEqlcR3NBOdGhkunv(Id, sample.Id);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Id.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v6immGcenqu7IBLgUvN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K8LlH5cQvpJKKvIMhKt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yoUm2Nclx3YckWm3Uf9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VgwWoYcurEFbcG07bSF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i2p2aIcI76LNAPpyQlq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vcqEqlcR3NBOdGhkunv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
