using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "Image3DLayer")]
public class CvsCogImage3DLayer
{
	private class c7Mj3NKaXeKaEFPpa6 : IEqualityComparer<CvsCogImage3DLayer>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CvsCogImage3DLayer P_0, CvsCogImage3DLayer P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 5:
					if (P_1 == null)
					{
						break;
					}
					goto case 6;
				default:
					num = 6;
					continue;
				case 6:
					if (q9yg1CZ1uHV2UZX6eM3(F1xrjHZAIeQuUF7rOyK(P_0), F1xrjHZAIeQuUF7rOyK(P_1)))
					{
						num = 1;
						continue;
					}
					break;
				case 1:
					if (ToTsKWZJrcofQbvStvN(P_0) == P_1.Image)
					{
						num = 8;
						continue;
					}
					break;
				case 0:
					if (P_1 == null)
					{
						_ = 1;
						num = (H6X12GZ0YkIek2ICmA3() ? 5 : 4);
						continue;
					}
					goto IL_00d6;
				case 7:
					if (P_0 == null)
					{
						num = 0;
						if (H6X12GZ0YkIek2ICmA3())
						{
						}
						continue;
					}
					goto IL_00d6;
				case 2:
				case 4:
					return true;
				case 8:
					{
						return dP9NfCel4I((CvsCogShape[])wreygcZ89e5sWTsfTUQ(P_0), (CvsCogShape[])wreygcZ89e5sWTsfTUQ(P_1));
					}
					IL_00d6:
					if (P_0 == null)
					{
						break;
					}
					goto case 3;
				}
				break;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(CvsCogImage3DLayer P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool dP9NfCel4I(CvsCogShape[] P_0, CvsCogShape[] P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 14;
			if (false)
			{
				goto IL_005b;
			}
			goto IL_0125;
			IL_005b:
			int num2 = num2 + 1;
			num = 3;
			goto IL_0125;
			IL_0125:
			bool flag = default;
			CvsCogPointCloud cvsCogPointCloud2 = default;
			CvsCogPointCloud cvsCogPointCloud = default;
			while (true)
			{
				switch (num)
				{
				case 14:
					if (P_0 == null)
					{
						H6X12GZ0YkIek2ICmA3();
						if (pNfnHLZB5ae8WtFx5bQ())
						{
							num = 5;
							continue;
						}
						num = 12;
						if (pNfnHLZB5ae8WtFx5bQ())
						{
							continue;
						}
						goto case 8;
					}
					goto IL_018d;
				case 2:
				case 6:
					break;
				case 1:
				case 5:
					if (P_1 == null)
					{
						num = 11;
						continue;
					}
					goto IL_018d;
				case 10:
					flag = true;
					num = 0;
					if (!H6X12GZ0YkIek2ICmA3())
					{
						continue;
					}
					goto case 4;
				case 4:
					if (P_1 == null)
					{
						num = 8;
						continue;
					}
					if (P_0.Length == P_1.Length)
					{
						num = 10;
						continue;
					}
					return false;
				case 13:
					cvsCogPointCloud2 = P_1[num2] as CvsCogPointCloud;
					if (cvsCogPointCloud == null || cvsCogPointCloud2 == null)
					{
						flag = qYUC7gZmjclhuZHrQuf(P_0[num2], P_1[num2]);
						num = 6;
						if (!H6X12GZ0YkIek2ICmA3())
						{
							continue;
						}
						goto case 14;
					}
					goto case 9;
				case 8:
					return false;
				case 9:
				case 12:
					flag = (string)wx9kDEZjkxNwBdXo32O(cvsCogPointCloud) == (string)wx9kDEZjkxNwBdXo32O(cvsCogPointCloud2);
					num = 2;
					continue;
				case 0:
					num2 = 0;
					goto case 3;
				default:
					num = 7;
					continue;
				case 3:
				case 7:
					if ((num2 < P_0.Length) & flag)
					{
						cvsCogPointCloud = P_0[num2] as CvsCogPointCloud;
						num = 13;
					}
					else
					{
						num = 15;
					}
					continue;
				case 11:
					return true;
				case 15:
					{
						return flag;
					}
					IL_018d:
					if (P_0 != null)
					{
						num = 4;
						continue;
					}
					goto case 8;
				}
				break;
			}
			goto IL_005b;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public c7Mj3NKaXeKaEFPpa6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JsFyJZZvJIipyecBUDX();
			eFiVy4Z3ANp4JwSF0uO(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F1xrjHZAIeQuUF7rOyK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogImage3DLayer)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q9yg1CZ1uHV2UZX6eM3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ToTsKWZJrcofQbvStvN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogImage3DLayer)P_0).Image;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wreygcZ89e5sWTsfTUQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogImage3DLayer)P_0).Graphics;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pNfnHLZB5ae8WtFx5bQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H6X12GZ0YkIek2ICmA3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wx9kDEZjkxNwBdXo32O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogPointCloud)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qYUC7gZmjclhuZHrQuf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return object.Equals(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JsFyJZZvJIipyecBUDX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eFiVy4Z3ANp4JwSF0uO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	[CompilerGenerated]
	private CvsCogShape[] uZqbkMLZl0;

	[CompilerGenerated]
	private readonly string utKbErWblY;

	[CompilerGenerated]
	private readonly CvsCogImage WZQbs3PHfA;

	[CompilerGenerated]
	private readonly double LEXb0bHcgw;

	[CompilerGenerated]
	private readonly double enxbGg8QrU;

	[CompilerGenerated]
	private int E1sb7IJr23;

	[CompilerGenerated]
	private int wkpbWSfjLb;

	public static IEqualityComparer<CvsCogImage3DLayer> DefaultEqualityComparer;

	[JsonProperty(PropertyName = "graphics", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogShape[] Graphics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uZqbkMLZl0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uZqbkMLZl0 = value;
		}
	}

	[JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Url
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return utKbErWblY;
		}
	}

	[JsonProperty(PropertyName = "image", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogImage Image
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WZQbs3PHfA;
		}
	}

	[JsonProperty(PropertyName = "minZ", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double MinZ
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LEXb0bHcgw;
		}
	}

	[JsonProperty(PropertyName = "maxZ", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double MaxZ
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return enxbGg8QrU;
		}
	}

	[DefaultValue(-16777077)]
	[JsonProperty(PropertyName = "edgeColor", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int EdgeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E1sb7IJr23;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E1sb7IJr23 = value;
		}
	}

	[DefaultValue(1)]
	[JsonProperty(PropertyName = "lineThickness", DefaultValueHandling = DefaultValueHandling.Populate)]
	public int LineThickness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wkpbWSfjLb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wkpbWSfjLb = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCogImage3DLayer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yI4XEL6tYTbQDxr0Vao();
		int num;
		if (!f3vGox6ae2F3iZKeL0c())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				num = 4;
				break;
			default:
				IyvsPI6DEh7vVSkMuRn(this);
				num = 5;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				uZqbkMLZl0 = new CvsCogShape[0];
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[JsonConstructor]
	internal CvsCogImage3DLayer(string url, CvsCogImage image, double minZ, double maxZ)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		f3vGox6ae2F3iZKeL0c();
		int num = ((!yI4XEL6tYTbQDxr0Vao()) ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 8:
				enxbGg8QrU = maxZ;
				goto case 2;
			case 0:
			case 3:
				PUwJsL6fDL2D50GOFHM();
				num = 7;
				break;
			case 4:
				base._002Ector();
				num = 1;
				break;
			case 7:
				uZqbkMLZl0 = new CvsCogShape[0];
				num = 4;
				break;
			case 2:
			case 6:
				LEXb0bHcgw = minZ;
				num = 9;
				break;
			case 5:
				WZQbs3PHfA = image;
				num = 8;
				break;
			case 1:
				utKbErWblY = url;
				goto case 5;
			default:
				num = 5;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCogImage3DLayer(string url, CvsCogImage image)
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
				uZqbkMLZl0 = new CvsCogShape[0];
				goto case 2;
			case 3:
				PUwJsL6fDL2D50GOFHM();
				_ = 0;
				num = (yI4XEL6tYTbQDxr0Vao() ? 4 : 6);
				continue;
			case 5:
				WZQbs3PHfA = image;
				num = 7;
				continue;
			case 2:
			case 6:
				base._002Ector();
				break;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				break;
			case 7:
				return;
			}
			utKbErWblY = url;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!f3vGox6ae2F3iZKeL0c())
		{
		}
		int? num3 = default;
		while (true)
		{
			int? num4;
			int? num2;
			int? num5;
			switch (num)
			{
			case 0:
			case 2:
				num3 = null;
				goto case 3;
			default:
				num = 3;
				if (f3vGox6ae2F3iZKeL0c())
				{
				}
				break;
			case 1:
			{
				string url = Url;
				if (url == null)
				{
					num = 6;
					break;
				}
				return url.GetHashCode();
			}
			case 4:
			case 5:
				num3 = null;
				num = 7;
				break;
			case 6:
			{
				CvsCogImage image = Image;
				if (image == null)
				{
					_ = 1;
					num = (f3vGox6ae2F3iZKeL0c() ? 5 : 0);
					break;
				}
				num4 = image.GetHashCode();
				goto IL_00d1;
			}
			case 3:
				num4 = num3;
				goto IL_00d1;
			case 7:
				{
					num2 = num3;
					goto IL_0102;
				}
				IL_00d1:
				num5 = num4;
				if (!num5.HasValue)
				{
					goto case 4;
				}
				num2 = 0 ^ num5.GetValueOrDefault();
				goto IL_0102;
				IL_0102:
				num3 = num2;
				return num3.GetValueOrDefault();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogImage3DLayer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PUwJsL6fDL2D50GOFHM();
		DefaultEqualityComparer = new c7Mj3NKaXeKaEFPpa6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yI4XEL6tYTbQDxr0Vao()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f3vGox6ae2F3iZKeL0c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IyvsPI6DEh7vVSkMuRn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PUwJsL6fDL2D50GOFHM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
