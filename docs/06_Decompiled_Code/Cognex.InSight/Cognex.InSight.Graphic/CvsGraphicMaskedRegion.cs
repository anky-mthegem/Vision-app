using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicMaskedRegion : CvsGraphicCompositeBase
{
	protected override CvsEditFlags ValidEditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicMaskedRegion(CvsCompositeSubregion[] subRegions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		o8lapXOvWkyffV1aot8();
		base._002Ector(subRegions, mustBeExtrudeable: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicMaskedRegion(CvsGraphicMaskedRegion graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicMaskedRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		o8lapXOvWkyffV1aot8();
		base._002Ector(mustBeExtrudeable: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicMaskedRegion(CvsCellLocation cellLocation, CvsCogEditingMaskedRegion maskedRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		o8lapXOvWkyffV1aot8();
		base._002Ector(cellLocation, maskedRegion);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicMaskedRegion(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void o8lapXOvWkyffV1aot8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MadqSPOSD0PYuX0v7YV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tWKicyOEirOToC8ng3y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
