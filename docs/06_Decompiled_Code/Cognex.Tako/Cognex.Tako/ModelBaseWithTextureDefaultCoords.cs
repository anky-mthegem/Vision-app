using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class ModelBaseWithTextureDefaultCoords : ModelBase
{
	protected Image _texture;

	public override void SetColorSolid(Color value)
	{
		base.SetColorSolid(value);
		_texture = null;
	}

	public unsafe void SetColorTexture(Image image)
	{
		//IL_0015: Expected I8, but got I
		//IL_0098: Expected I, but got I8
		DisposedCheck();
		_texture = image;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xX func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureDefaultCoords_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xX, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xX, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = image.native_shared(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E* ptr2 = native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020_003E(ptr2, func, ptr);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
	}

	public Image GetColorTexture()
	{
		DisposedCheck();
		return _texture;
	}

	private void u()
	{
		if (!_is_disposed)
		{
			_texture = null;
		}
	}

	protected ModelBaseWithTextureDefaultCoords()
	{
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
		try
		{
			num = 1u;
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureDefaultCoords_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
	{
		if (A_0)
		{
			try
			{
				u();
				return;
			}
			finally
			{
				base.Dispose(A_0: true);
			}
		}
		base.Dispose(A_0: false);
	}
}
