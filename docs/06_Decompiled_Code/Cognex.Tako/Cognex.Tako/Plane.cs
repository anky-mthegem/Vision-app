using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Media.Media3D;
using std;
using u;

namespace Cognex.Tako;

public class Plane : InteractiveModelImpl_003CCognex_003A_003ATako_003A_003AModelBaseWithTextureDefaultCoords_003E
{
	protected Box _roi;

	public unsafe bool DrawNormal
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xR func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Plane_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xR, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xR, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj);
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
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xE func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Plane_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xE, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xE, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj);
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
		}
	}

	public unsafe Plane(Vector3D normal, Point3D origin)
	{
		//IL_00a4: Expected I, but got I8
		//IL_00c6: Expected I, but got I8
		//IL_007b: Expected I, but got I8
		//IL_010f: Expected I, but got I8
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj3);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr5;
			try
			{
				if (ptr != null)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
					*(float*)(&obj) = (float)origin.X;
					System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)origin.Y;
					System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)origin.Z;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
					*(float*)(&obj2) = (float)normal.X;
					System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (float)normal.Y;
					System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) = (float)normal.Z;
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003APlane_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(&obj3, &obj2, &obj);
					try
					{
						num = 1u;
						*(long*)ptr = *(long*)ptr2;
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr + 8uL);
						shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr3;
						*(long*)ptr4 = 0L;
						*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
						try
						{
							_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr3, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr2);
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
							throw;
						}
						ptr5 = ptr;
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj3);
						}
						throw;
					}
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
			try
			{
				_native = ptr5;
			}
			catch
			{
				//try-fault
				if ((num & 1) != 0)
				{
					num &= 0xFFFFFFFEu;
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj3);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
				}
			}
			SetModelMatrixChangedCallback();
			BindDragCallbacksToEvents();
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe Plane(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003APlane_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003APlane_003E*)ptrToShared.ToPointer()));
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr, 24uL);
				throw;
			}
			_native = ptr2;
			SetModelMatrixChangedCallback();
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe void Set(Vector3D normal, Point3D origin)
	{
		//IL_0058: Expected I8, but got I
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
		*(float*)(&obj) = (float)origin.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)origin.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)origin.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
		*(float*)(&obj2) = (float)normal.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (float)normal.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) = (float)normal.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xf func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Plane_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xf, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xf, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj3);
		Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj3);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(ptr, func, &obj2, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		try
		{
			GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8))));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
			throw;
		}
		_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
	}

	public unsafe Vector3D GetNormal()
	{
		//IL_000e: Expected I8, but got I
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xS func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9DirectionalHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.As<xS, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xS, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj);
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
		return new Vector3D(*(float*)(&obj2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
	}

	public unsafe Point3D GetOrigin()
	{
		//IL_000e: Expected I8, but got I
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xS func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Box_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xS, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xS, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj);
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
		return new Point3D(*(float*)(&obj2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
	}

	public unsafe void SetBoundingROI(Box roi)
	{
		//IL_0015: Expected I8, but got I
		//IL_00a3: Expected I, but got I8
		//IL_00c4: Expected I, but got I8
		DisposedCheck();
		_roi = roi;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xU func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Plane_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xU, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xU, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* other = roi.native_shared(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E obj2);
			shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E* ptr = _003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003ABox_002Cclass_0020cognex_003A_003Atako_003A_003ANode_003E(&obj2, other);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj3);
				Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr2 = native(&obj3);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ABox_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ABox_003E_0020_003E(ptr2, func, ptr);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				try
				{
					GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8))));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
					throw;
				}
				_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
	}

	public Box GetBoundingROI()
	{
		return _roi;
	}

	public unsafe void ResetBoundingROI()
	{
		//IL_000e: Expected I8, but got I
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x2 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Plane_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<x2, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<x2, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003APlane_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003APlane_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), &obj);
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
		_roi = null;
	}

	public unsafe Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* native(Locker_003Ccognex_003A_003Atako_003A_003APlane_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003APlane_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003APlane_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003APlane_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
