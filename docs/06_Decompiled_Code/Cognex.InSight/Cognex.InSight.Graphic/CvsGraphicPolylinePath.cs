using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicPolylinePath : CvsGraphicCompositeBase
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
			return CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolylinePath(CvsCompositeSubregion[] subRegions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kEUYGMM1ma0qwsyVPPh();
		base._002Ector(subRegions, mustBeExtrudeable: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolylinePath(CvsGraphicPolylinePath graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolylinePath()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kEUYGMM1ma0qwsyVPPh();
		base._002Ector(mustBeExtrudeable: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolylinePath(CvsCellLocation cellLocation, CvsCogEditingPolyline editComposite)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(cellLocation, editComposite);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPolylinePath(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kEUYGMM1ma0qwsyVPPh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rpqkdDMNolwGPoBNoCy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eIjAjsMx1JhZjqGGolb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
