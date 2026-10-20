using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicComposite : CvsGraphicCompositeBase, ICvsEditableGraphic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicComposite(CvsCompositeSubregion[] subRegions, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cIWULW1LkEddNoxjbmZ();
		base._002Ector(subRegions, mustBeExtrudeable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicComposite(CvsGraphicCompositeBase graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cIWULW1LkEddNoxjbmZ();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicComposite(bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(mustBeExtrudeable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicComposite(CvsCellLocation cellLocation, CvsCogEditingCompositeRegion editComposite, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pDZ92h1hBaDhjbN9Cfe();
		int num;
		if (pRTVVR1sA2GU9kZqZfT())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (pDZ92h1hBaDhjbN9Cfe())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				cIWULW1LkEddNoxjbmZ();
				num = 3;
				continue;
			case 3:
				base._002Ector(cellLocation, editComposite, mustBeExtrudeable);
				break;
			case 5:
				return;
			}
			UniqueId = cellLocation.ToString();
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
		return new CvsGraphicComposite(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cIWULW1LkEddNoxjbmZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pRTVVR1sA2GU9kZqZfT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pDZ92h1hBaDhjbN9Cfe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
