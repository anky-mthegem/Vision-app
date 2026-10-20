using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class Image : IDisposable
{
	public delegate void DeleteDelegate();

	protected unsafe NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* _native;

	protected DeleteDelegate _deleter;

	protected bool _is_disposed;

	public unsafe IntPtr DataPtr
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Image already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pf func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = native(&obj);
			IntPtr result;
			try
			{
				IntPtr intPtr = new IntPtr(_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002Emethod_003Cvoid_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AImage_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func));
				result = intPtr;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			return result;
		}
	}

	public unsafe ColorFormat ColorFormat
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Image already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PZ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = native(&obj);
			ColorFormat result;
			try
			{
				result = (ColorFormat)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003AColorFormat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AImage_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			return result;
		}
	}

	public unsafe int RowBytes
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Image already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AImage_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			return result;
		}
	}

	public unsafe int Height
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Image already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AImage_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			return result;
		}
	}

	public unsafe int Width
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Image already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AImage_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8))));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				throw;
			}
			_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			return result;
		}
	}

	public unsafe Image(IntPtr ptrToShared, DeleteDelegate del)
	{
		//IL_004c: Expected I, but got I8
		//IL_0054: Expected I, but got I8
		//IL_0025: Expected I, but got I8
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)_003CModule_003E.@new(24uL);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr5;
		try
		{
			if (ptr != null)
			{
				shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr2 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptrToShared.ToPointer();
				*(long*)ptr = *(long*)ptr2;
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)((ulong)(nint)ptr + 8uL);
				shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3;
				*(long*)ptr4 = 0L;
				*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
				try
				{
					_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3, ptr2);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
					throw;
				}
				ptr5 = ptr;
			}
			else
			{
				ptr5 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 24uL);
			throw;
		}
		_native = ptr5;
		_deleter = del;
		_is_disposed = false;
	}

	public unsafe Image(IntPtr ptrToShared)
	{
		//IL_004c: Expected I, but got I8
		//IL_0054: Expected I, but got I8
		//IL_0025: Expected I, but got I8
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)_003CModule_003E.@new(24uL);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr5;
		try
		{
			if (ptr != null)
			{
				shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr2 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptrToShared.ToPointer();
				*(long*)ptr = *(long*)ptr2;
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)((ulong)(nint)ptr + 8uL);
				shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3;
				*(long*)ptr4 = 0L;
				*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
				try
				{
					_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3, ptr2);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
					throw;
				}
				ptr5 = ptr;
			}
			else
			{
				ptr5 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 24uL);
			throw;
		}
		_native = ptr5;
		_deleter = null;
		_is_disposed = false;
	}

	public unsafe Image(IntPtr data_ptr, int width, int height, int row_bytes, ColorFormat color_format, DeleteDelegate del)
	{
		//IL_006c: Expected I, but got I8
		//IL_008e: Expected I, but got I8
		//IL_0043: Expected I, but got I8
		//IL_00d7: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)_003CModule_003E.@new(24uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr6;
		try
		{
			if (ptr != null)
			{
				BJ bJ2 = (BJ)color_format;
				void* ptr2 = (void*)data_ptr;
				created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AImage_002Cclass_0020cognex_003A_003Atako_003A_003AImage_002Cvoid_0020_002A_002Cint_0020_0026_002Cint_0020_0026_002Cint_0020_0026_002Cenum_0020cognex_003A_003Atako_003A_003AColorFormat_003E(&obj, &ptr2, &width, &height, &row_bytes, &bJ2);
				try
				{
					num = 1u;
					*(long*)ptr = *(long*)ptr3;
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)((ulong)(nint)ptr + 8uL);
					shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr4;
					*(long*)ptr5 = 0L;
					*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
					try
					{
						_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
						throw;
					}
					ptr6 = ptr;
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr6 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 24uL);
			throw;
		}
		try
		{
			_native = ptr6;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			}
		}
		_deleter = del;
		_is_disposed = false;
	}

	public unsafe Image(IntPtr data_ptr, int width, int height, int row_bytes, ColorFormat color_format)
	{
		//IL_006c: Expected I, but got I8
		//IL_008e: Expected I, but got I8
		//IL_0043: Expected I, but got I8
		//IL_00d7: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)_003CModule_003E.@new(24uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr6;
		try
		{
			if (ptr != null)
			{
				BJ bJ2 = (BJ)color_format;
				void* ptr2 = (void*)data_ptr;
				created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AImage_002Cclass_0020cognex_003A_003Atako_003A_003AImage_002Cvoid_0020_002A_002Cint_0020_0026_002Cint_0020_0026_002Cint_0020_0026_002Cenum_0020cognex_003A_003Atako_003A_003AColorFormat_003E(&obj, &ptr2, &width, &height, &row_bytes, &bJ2);
				try
				{
					num = 1u;
					*(long*)ptr = *(long*)ptr3;
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)((ulong)(nint)ptr + 8uL);
					shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr4;
					*(long*)ptr5 = 0L;
					*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
					try
					{
						_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*)ptr3);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
						throw;
					}
					ptr6 = ptr;
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr6 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 24uL);
			throw;
		}
		try
		{
			_native = ptr6;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			}
		}
		_deleter = null;
		_is_disposed = false;
	}

	private void u()
	{
		if (!_is_disposed)
		{
			W();
			_is_disposed = true;
		}
	}

	private unsafe void W()
	{
		//IL_004e: Expected I, but got I8
		//IL_003d: Expected I, but got I8
		if (_native == null)
		{
			return;
		}
		if (_deleter != null)
		{
			_deleter();
		}
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = _native;
		if (ptr != null)
		{
			ulong num = *(ulong*)((long)(nint)ptr + 8L + 8);
			if (num != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
			}
			_003CModule_003E.delete(ptr, 24uL);
		}
		_native = null;
	}

	public unsafe shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* native_shared(shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003AImage_003E_002Eshared(_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	protected void ThrowIfDisposed()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Image already disposed");
		}
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AImage_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003AImage_003E_002Elock((NativeRef_003Ccognex_003A_003Atako_003A_003AImage_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
	{
		if (A_0)
		{
			u();
			return;
		}
		try
		{
			W();
		}
		finally
		{
			base.Finalize();
		}
	}

	public virtual sealed void Dispose()
	{
		Dispose(A_0: true);
		GC.SuppressFinalize(this);
	}

	~Image()
	{
		Dispose(A_0: false);
	}
}
