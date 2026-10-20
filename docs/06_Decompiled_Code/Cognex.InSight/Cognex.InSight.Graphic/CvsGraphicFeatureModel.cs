using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public sealed class CvsGraphicFeatureModel : CvsGraphic
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsGraphicFeature, CvsGraphicFeature> _003C_003E9__1_0;

		public static Func<CvsCogFeature, CvsGraphicFeature> _003C_003E9__2_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uIFgHksNGKCBeNpddCDK();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uIFgHksNGKCBeNpddCDK();
			NcK4iksNXKKMLaA1X9gd(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsGraphicFeature _003C_002Ector_003Eb__1_0(CvsGraphicFeature f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsGraphicFeature(f);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsGraphicFeature _003CFromSerializableGraphic_003Eb__2_0(CvsCogFeature f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsGraphicFeature cvsGraphicFeature = new CvsGraphicFeature();
			KEfE23sNbv5VU5SVjwI8(cvsGraphicFeature, f);
			return cvsGraphicFeature;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uIFgHksNGKCBeNpddCDK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XwMkU7sNaamgwcMvEcOf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gDD09lsNnopujFTAd2gy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NcK4iksNXKKMLaA1X9gd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KEfE23sNbv5VU5SVjwI8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphicFeature)P_0).FromSerializableGraphic((CvsCogFeature)P_1);
		}
	}

	private CvsGraphicFeature[] wGuJtbEX8K;

	public IReadOnlyList<CvsGraphicFeature> Features
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wGuJtbEX8K?.ToList();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFeatureModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!jx8oAvrm241tCwJGT9V())
		{
			goto IL_001e;
		}
		goto IL_0036;
		IL_001e:
		base._002Ector();
		goto IL_0080;
		IL_0036:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 4:
				do
				{
					yqdGwjrgxWGOh7kFjPU();
					_ = 1;
					if (pHj6tVryHtoEs7rkkxA())
					{
						num = 0;
						continue;
					}
					num = 3;
					break;
				}
				while (false);
				continue;
			default:
				goto IL_0080;
			case 5:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0080:
		DX1JAF5PTe(Array.Empty<CvsGraphicFeature>(), HklCcmrZrY0ShRaQ4av(), CvsCellLocation.Invalid);
		num = 5;
		goto IL_0036;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFeatureModel(CvsGraphicFeatureModel featureModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00b7;
		IL_0072:
		CvsGraphicFeature[] array = featureModel.Features.Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsGraphicFeature f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsGraphicFeature(f);
		}).ToArray();
		goto IL_0055;
		IL_00b7:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 5:
				goto IL_0030;
			case 0:
				goto IL_0055;
			case 2:
			case 3:
				goto IL_0072;
			default:
				num = 0;
				continue;
			case 6:
				return;
			}
			break;
			IL_0030:
			yqdGwjrgxWGOh7kFjPU();
			_ = 1;
			if (pHj6tVryHtoEs7rkkxA())
			{
				num = 3;
				continue;
			}
			num = 4;
			if (pHj6tVryHtoEs7rkkxA())
			{
			}
		}
		goto IL_001a;
		IL_0055:
		DX1JAF5PTe(array, PJCtIcrJvcEV0V4mcVj(featureModel), fKPL87r84L0voGPO9OG(featureModel));
		num = 6;
		goto IL_00b7;
		IL_001a:
		base._002Ector();
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogFeatureModel featureModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(featureModel);
		wGuJtbEX8K = featureModel.Features.Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCogFeature f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsGraphicFeature cvsGraphicFeature = new CvsGraphicFeature();
			_003C_003Ec.KEfE23sNbv5VU5SVjwI8(cvsGraphicFeature, f);
			return cvsGraphicFeature;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicFeatureModel(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DX1JAF5PTe(CvsGraphicFeature[] P_0, Color P_1, CvsCellLocation P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!jx8oAvrm241tCwJGT9V()) ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				wGuJtbEX8K = P_0;
				num = 4;
				continue;
			case 4:
				mColor = P_1;
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 1:
				mCellLocation = P_2;
				break;
			case 6:
				return;
			}
			OnPropertyChanged(null);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yqdGwjrgxWGOh7kFjPU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color HklCcmrZrY0ShRaQ4av()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Green;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jx8oAvrm241tCwJGT9V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pHj6tVryHtoEs7rkkxA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color PJCtIcrJvcEV0V4mcVj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Color;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation fKPL87r84L0voGPO9OG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).CellLocation;
	}
}
