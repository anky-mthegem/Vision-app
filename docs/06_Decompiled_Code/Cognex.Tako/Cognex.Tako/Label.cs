using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Media3D;
using std;
using u;

namespace Cognex.Tako;

public class Label : TextBase
{
	public unsafe Point3D Position
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iK func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9DirectionalHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<iK, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<iK, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E* ptr = u(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ALabel_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ALabel_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ALabel_003E_002E_007Bdtor_007D), &obj);
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
		set
		{
			//IL_0033: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
			*(float*)(&obj) = (float)value.X;
			System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)value.Y;
			System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)value.Z;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out i3 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Label_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<i3, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<i3, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E* ptr = u(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ALabel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ALabel_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(ptr, func, &obj);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ALabel_003E_002E_007Bdtor_007D), &obj2);
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
	}

	public unsafe Label(string text)
	{
		//IL_0064: Expected I, but got I8
		//IL_00a0: Expected I, but got I8
		//IL_003b: Expected I, but got I8
		//IL_00ed: Expected I, but got I8
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj2);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* native;
			try
			{
				if (ptr != null)
				{
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = StringHelper.to_UTF8(&obj, text);
					try
					{
						num = 1u;
						created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003ALabel_002Cclass_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E(&obj2, ptr2);
						try
						{
							num = 3u;
							*(long*)ptr = *(long*)ptr3;
							NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr + 8uL);
							shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr4;
							*(long*)ptr5 = 0L;
							*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
							try
							{
								_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr3);
							}
							catch
							{
								//try-fault
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
								throw;
							}
							native = ptr;
						}
						catch
						{
							//try-fault
							if ((num & 2) != 0)
							{
								num &= 0xFFFFFFFDu;
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj2);
							}
							throw;
						}
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
						}
						throw;
					}
				}
				else
				{
					native = null;
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
				try
				{
					_native = native;
				}
				catch
				{
					//try-fault
					if ((num & 2) != 0)
					{
						num &= 0xFFFFFFFDu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj2);
					}
					throw;
				}
				if ((num & 2) != 0)
				{
					num &= 0xFFFFFFFDu;
					if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
					}
				}
			}
			catch
			{
				//try-fault
				if ((num & 1) != 0)
				{
					num &= 0xFFFFFFFEu;
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				}
				throw;
			}
			if ((num & 1) == 0)
			{
				return;
			}
			num &= 0xFFFFFFFEu;
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
				return;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe Label(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* native;
			try
			{
				native = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003ALabel_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003ALabel_003E*)ptrToShared.ToPointer()));
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr, 24uL);
				throw;
			}
			_native = native;
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

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E* u(Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003ALabel_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ALabel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ALabel_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
