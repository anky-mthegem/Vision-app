using System.Runtime.CompilerServices;
using Cognex.ImageManager.Client.Tool.Interfaces;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

public class Element : IElement, IIdentifiableElement
{
	[CompilerGenerated]
	private string uElprEZ9hs;

	[CompilerGenerated]
	private string WISpCg1dr1;

	[CompilerGenerated]
	private string Sfop259gm9;

	[CompilerGenerated]
	private string[] hl7pydQvYG;

	[JsonProperty("id")]
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
			return uElprEZ9hs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uElprEZ9hs = value;
		}
	}

	[JsonProperty("filename")]
	public string FileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WISpCg1dr1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WISpCg1dr1 = value;
		}
	}

	[JsonProperty("date_created")]
	public string DateCreated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Sfop259gm9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Sfop259gm9 = value;
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
			return hl7pydQvYG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hl7pydQvYG = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Element()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		wjbHrRjg2NMmUGl1h0o(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Element(ImageMetadata metadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				base._002Ector();
				num = 7;
				continue;
			case 4:
			case 5:
				TagIds = metadata.TagIds;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				Id = (string)C43mD6jJebXRuUETLup(metadata);
				jqi7DZjmHPuMn8mAC6H();
				if (!NHkhVdjycQmaSXAaG56())
				{
					num = 0;
					if (jqi7DZjmHPuMn8mAC6H())
					{
						continue;
					}
					goto case 6;
				}
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 6:
				DateCreated = (string)E43o3Qcw4DbEl9fXqb3(metadata);
				goto case 4;
			case 0:
			case 3:
				FileName = (string)zlhfssjz5TcmpJ7slQx(metadata.Id, RHDnTyj8lOLv8wFhrM5(15484));
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 1:
				break;
			case 8:
				return;
			}
			U5vQcGjZijZaIB386Fh();
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wjbHrRjg2NMmUGl1h0o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jqi7DZjmHPuMn8mAC6H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NHkhVdjycQmaSXAaG56()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U5vQcGjZijZaIB386Fh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C43mD6jJebXRuUETLup(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RHDnTyj8lOLv8wFhrM5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zlhfssjz5TcmpJ7slQx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E43o3Qcw4DbEl9fXqb3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageMetadata)P_0).Timestamp;
	}
}
