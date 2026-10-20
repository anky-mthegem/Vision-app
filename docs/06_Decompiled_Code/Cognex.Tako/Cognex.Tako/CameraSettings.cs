using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using std;
using u;

namespace Cognex.Tako;

[Serializable]
public class CameraSettings : ISerializable, IXmlSerializable, IDisposable
{
	protected unsafe NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* _native;

	protected bool _is_disposed;

	private static int f = 1;

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	protected unsafe CameraSettings(SerializationInfo info, StreamingContext context)
	{
		//IL_0014: Expected I, but got I8
		//IL_001d: Expected I8, but got I
		//IL_003e: Expected I, but got I8
		//IL_022f: Expected I, but got I8
		//IL_0205: Expected I, but got I8
		//IL_020e: Expected I8, but got I
		//IL_027a: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr = _003CModule_003E.Cognex_002ETako_002EnativeNew_003Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_003E(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E obj2);
		try
		{
			P3* ptr2 = (P3*)(*(ulong*)ptr);
			*(long*)ptr = 0L;
			*(long*)(&obj2) = (nint)ptr2;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 68uL);
			}
			if (1 != info.GetInt32("version"))
			{
				throw new Exception("the data was saved in an other version. Current version: " + 1);
			}
			*(bool*)(*(ulong*)(&obj2)) = info.GetBoolean("persp");
			*(float*)(*(long*)(&obj2) + 4) = info.GetSingle("fov");
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_08DNELMMHJ_0040eyePoint_003F_0024AA_0040));
			try
			{
				array_003Cfloat_002C3_003E obj4 = b(info, &obj3);
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 8, ref obj4, 12);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj3, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_0M_0040CAHGCDPG_0040targetPoint_003F_0024AA_0040));
			try
			{
				array_003Cfloat_002C3_003E obj6 = b(info, &obj5);
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 20, ref obj6, 12);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj5);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj5, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj5);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj7, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_07KKJCEHGM_0040worldUp_003F_0024AA_0040));
			try
			{
				array_003Cfloat_002C3_003E obj8 = b(info, &obj7);
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 32, ref obj8, 12);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj7);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj7, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj7);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out P3.PK pK);
			*(float*)(&pK) = info.GetSingle("frustumLeft");
			System.Runtime.CompilerServices.Unsafe.As<P3.PK, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref pK, 4)) = info.GetSingle("frustumRight");
			System.Runtime.CompilerServices.Unsafe.As<P3.PK, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref pK, 8)) = info.GetSingle("frustumTop");
			System.Runtime.CompilerServices.Unsafe.As<P3.PK, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref pK, 12)) = info.GetSingle("frustumBottom");
			System.Runtime.CompilerServices.Unsafe.As<P3.PK, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref pK, 16)) = info.GetSingle("frustumNear");
			System.Runtime.CompilerServices.Unsafe.As<P3.PK, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref pK, 20)) = info.GetSingle("frustumFar");
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 44, ref pK, 24);
			NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr3 = (NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*)_003CModule_003E.@new(8uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj9);
			NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr5;
			try
			{
				if (ptr3 != null)
				{
					_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bctor_007D((unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*)(&obj9), &obj2);
					try
					{
						num = 1u;
						P3* ptr4 = (P3*)(*(ulong*)(&obj9));
						*(long*)(&obj9) = 0L;
						*(long*)ptr3 = (nint)ptr4;
						ptr5 = ptr3;
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj9);
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
				_003CModule_003E.delete(ptr3, 8uL);
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
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj9);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (*(long*)(&obj9) != 0L)
				{
					_003CModule_003E.delete((void*)(*(ulong*)(&obj9)), 68uL);
				}
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		try
		{
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
	}

	public unsafe CameraSettings(P3* native)
	{
		//IL_004b: Expected I, but got I8
		//IL_0022: Expected I, but got I8
		//IL_002a: Expected I8, but got I
		//IL_0092: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr = (NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*)_003CModule_003E.@new(8uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr4;
		try
		{
			if (ptr != null)
			{
				created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNew_003Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_002Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_0020const_0020_0026_003E(&obj, native);
				try
				{
					num = 1u;
					P3* ptr3 = (P3*)(*(ulong*)ptr2);
					*(long*)ptr2 = 0L;
					*(long*)ptr = (nint)ptr3;
					ptr4 = ptr;
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr4 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 8uL);
			throw;
		}
		try
		{
			_native = ptr4;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 68uL);
			}
		}
		_is_disposed = false;
	}

	public unsafe CameraSettings()
	{
		//IL_004a: Expected I, but got I8
		//IL_0021: Expected I, but got I8
		//IL_0029: Expected I8, but got I
		//IL_0091: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr = (NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*)_003CModule_003E.@new(8uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr4;
		try
		{
			if (ptr != null)
			{
				created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNew_003Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_003E(&obj);
				try
				{
					num = 1u;
					P3* ptr3 = (P3*)(*(ulong*)ptr2);
					*(long*)ptr2 = 0L;
					*(long*)ptr = (nint)ptr3;
					ptr4 = ptr;
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr4 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr, 8uL);
			throw;
		}
		try
		{
			_native = ptr4;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 68uL);
			}
		}
		_is_disposed = false;
	}

	public unsafe Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* native(Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002Elock(_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
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
		//IL_0015: Expected I, but got I8
		_003CModule_003E.delete(_native, 8uL);
		_native = null;
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//IL_000d: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		native(&obj);
		try
		{
			P3* ptr = (P3*)(*(ulong*)(&obj));
			ThrowIfDisposed();
			info.AddValue("version", 1);
			info.AddValue("persp", *(bool*)ptr);
			info.AddValue("fov", *(float*)((ulong)(nint)ptr + 4uL));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_08DNELMMHJ_0040eyePoint_003F_0024AA_0040));
			try
			{
				B(info, &obj2, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 8uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_0M_0040CAHGCDPG_0040targetPoint_003F_0024AA_0040));
			try
			{
				B(info, &obj3, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 20uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj3, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_07KKJCEHGM_0040worldUp_003F_0024AA_0040));
			try
			{
				B(info, &obj4, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 32uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj4, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			info.AddValue("frustumLeft", *(float*)((ulong)(nint)ptr + 44uL));
			info.AddValue("frustumRight", *(float*)((ulong)(nint)ptr + 48uL));
			info.AddValue("frustumTop", *(float*)((ulong)(nint)ptr + 52uL));
			info.AddValue("frustumBottom", *(float*)((ulong)(nint)ptr + 56uL));
			info.AddValue("frustumNear", *(float*)((ulong)(nint)ptr + 60uL));
			info.AddValue("frustumFar", *(float*)((ulong)(nint)ptr + 64uL));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
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

	public virtual XmlSchema GetSchema()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("CameraSettings already disposed");
		}
		return null;
	}

	public unsafe virtual void ReadXml(XmlReader reader)
	{
		//IL_0021: Expected I, but got I8
		//IL_002a: Expected I8, but got I
		//IL_004b: Expected I, but got I8
		//IL_01ed: Expected I, but got I8
		//IL_01c3: Expected I, but got I8
		//IL_01cc: Expected I8, but got I
		//IL_0238: Expected I, but got I8
		uint num = 0u;
		if (_is_disposed)
		{
			throw new ObjectDisposedException("CameraSettings already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr = _003CModule_003E.Cognex_002ETako_002EnativeNew_003Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_003E(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E obj2);
		try
		{
			P3* ptr2 = (P3*)(*(ulong*)ptr);
			*(long*)ptr = 0L;
			*(long*)(&obj2) = (nint)ptr2;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 68uL);
			}
			reader.ReadToDescendant("Version");
			if (1 != reader.ReadElementContentAsInt())
			{
				throw new Exception("the data was saved in an other versionative-> Current version: " + 1);
			}
			Z(reader, "Persp");
			*(bool*)(*(ulong*)(&obj2)) = reader.ReadElementContentAsBoolean();
			Z(reader, "Fov");
			*(float*)(*(long*)(&obj2) + 4) = reader.ReadElementContentAsFloat();
			array_003Cfloat_002C3_003E obj3 = P(reader, "EyePoint");
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 8, ref obj3, 12);
			array_003Cfloat_002C3_003E obj4 = P(reader, "TargetPoint");
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 20, ref obj4, 12);
			array_003Cfloat_002C3_003E obj5 = P(reader, "WorldUp");
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(*(long*)(&obj2) + 32, ref obj5, 12);
			Z(reader, "Frustum");
			reader.MoveToAttribute("left");
			*(float*)(*(long*)(&obj2) + 44) = reader.ReadContentAsFloat();
			reader.MoveToAttribute("right");
			*(float*)(*(long*)(&obj2) + 48) = reader.ReadContentAsFloat();
			reader.MoveToAttribute("top");
			*(float*)(*(long*)(&obj2) + 52) = reader.ReadContentAsFloat();
			reader.MoveToAttribute("bottom");
			*(float*)(*(long*)(&obj2) + 56) = reader.ReadContentAsFloat();
			reader.MoveToAttribute("near");
			*(float*)(*(long*)(&obj2) + 60) = reader.ReadContentAsFloat();
			reader.MoveToAttribute("far");
			*(float*)(*(long*)(&obj2) + 64) = reader.ReadContentAsFloat();
			reader.MoveToElement();
			NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr3 = (NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*)_003CModule_003E.@new(8uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj6);
			NativeRef_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr5;
			try
			{
				if (ptr3 != null)
				{
					_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bctor_007D((unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*)(&obj6), &obj2);
					try
					{
						num = 1u;
						P3* ptr4 = (P3*)(*(ulong*)(&obj6));
						*(long*)(&obj6) = 0L;
						*(long*)ptr3 = (nint)ptr4;
						ptr5 = ptr3;
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj6);
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
				_003CModule_003E.delete(ptr3, 8uL);
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
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj6);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (*(long*)(&obj6) != 0L)
				{
					_003CModule_003E.delete((void*)(*(ulong*)(&obj6)), 68uL);
				}
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		try
		{
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Atako_003A_003ACameraSettings_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
	}

	public unsafe virtual void WriteXml(XmlWriter writer)
	{
		//IL_0020: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("CameraSettings already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		native(&obj);
		try
		{
			P3* ptr = (P3*)(*(ulong*)(&obj));
			writer.WriteElementString("Version", 1.ToString());
			string value = ((*(byte*)ptr == 0) ? "0" : "1");
			writer.WriteElementString("Persp", value);
			float num = *(float*)((ulong)(nint)ptr + 4uL);
			writer.WriteElementString("Fov", num.ToString(CultureInfo.InvariantCulture));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_08LPLKEONK_0040EyePoint_003F_0024AA_0040));
			try
			{
				n(writer, &obj2, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 8uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_0M_0040DIEHPIAO_0040TargetPoint_003F_0024AA_0040));
			try
			{
				n(writer, &obj3, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 20uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj3, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_07FDOECFDK_0040WorldUp_003F_0024AA_0040));
			try
			{
				n(writer, &obj4, *(array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 32uL));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj4, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			writer.WriteStartElement("Frustum");
			float num2 = *(float*)((ulong)(nint)ptr + 44uL);
			writer.WriteAttributeString("left", num2.ToString(CultureInfo.InvariantCulture));
			float num3 = *(float*)((ulong)(nint)ptr + 48uL);
			writer.WriteAttributeString("right", num3.ToString(CultureInfo.InvariantCulture));
			float num4 = *(float*)((ulong)(nint)ptr + 52uL);
			writer.WriteAttributeString("top", num4.ToString(CultureInfo.InvariantCulture));
			float num5 = *(float*)((ulong)(nint)ptr + 56uL);
			writer.WriteAttributeString("bottom", num5.ToString(CultureInfo.InvariantCulture));
			float num6 = *(float*)((ulong)(nint)ptr + 60uL);
			writer.WriteAttributeString("near", num6.ToString(CultureInfo.InvariantCulture));
			float num7 = *(float*)((ulong)(nint)ptr + 64uL);
			writer.WriteAttributeString("far", num7.ToString(CultureInfo.InvariantCulture));
			writer.WriteEndElement();
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
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

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe override bool Equals(object onet)
	{
		//IL_0041: Expected I, but got I8
		//IL_0041: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("CameraSettings already disposed");
		}
		if (onet != null && this != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
			((CameraSettings)onet).native(&obj);
			bool result;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj2);
				native(&obj2);
				try
				{
					result = _003CModule_003E.u_002EP3_002E_003D_003D((P3*)(*(ulong*)(&obj2)), (P3*)(*(ulong*)(&obj)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj2);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
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
		return false;
	}

	protected void ThrowIfDisposed()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("CameraSettings already disposed");
		}
	}

	private unsafe static void n(XmlWriter P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, array_003Cfloat_002C3_003E P_2)
	{
		//IL_000e: Expected I, but got I8
		sbyte* value = ((16uL > (ulong)(*(long*)((ulong)(nint)P_1 + 24uL))) ? ((sbyte*)P_1) : ((sbyte*)(*(ulong*)P_1)));
		P_0.WriteStartElement(new string(value));
		float num = *(float*)(&P_2);
		P_0.WriteAttributeString("x", num.ToString(CultureInfo.InvariantCulture));
		float num2 = System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref P_2, 4));
		P_0.WriteAttributeString("y", num2.ToString(CultureInfo.InvariantCulture));
		float num3 = System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref P_2, 8));
		P_0.WriteAttributeString("z", num3.ToString(CultureInfo.InvariantCulture));
		P_0.WriteEndElement();
	}

	private unsafe static void B(SerializationInfo P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, array_003Cfloat_002C3_003E P_2)
	{
		//IL_001d: Expected I, but got I8
		//IL_007a: Expected I, but got I8
		//IL_00d8: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01MMEEDKFM_0040X_003F_0024AA_0040));
		try
		{
			sbyte* value = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr + 24uL))) ? ((sbyte*)ptr) : ((sbyte*)(*(ulong*)ptr)));
			P_0.AddValue(new string(value), *(float*)(&P_2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj2, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01NFFPALBN_0040Y_003F_0024AA_0040));
		try
		{
			sbyte* value2 = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr2 + 24uL))) ? ((sbyte*)ptr2) : ((sbyte*)(*(ulong*)ptr2)));
			P_0.AddValue(new string(value2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref P_2, 4)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj3, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01POHCFINO_0040Z_003F_0024AA_0040));
		try
		{
			sbyte* value3 = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr3 + 24uL))) ? ((sbyte*)ptr3) : ((sbyte*)(*(ulong*)ptr3)));
			P_0.AddValue(new string(value3), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref P_2, 8)));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj3, true, 0uL);
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
	}

	private unsafe static array_003Cfloat_002C3_003E P(XmlReader P_0, string P_1)
	{
		Z(P_0, P_1);
		P_0.MoveToAttribute("x");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E result);
		*(float*)(&result) = P_0.ReadContentAsFloat();
		P_0.MoveToAttribute("y");
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 4)) = P_0.ReadContentAsFloat();
		P_0.MoveToAttribute("z");
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 8)) = P_0.ReadContentAsFloat();
		P_0.MoveToElement();
		P_0.Read();
		return result;
	}

	private unsafe static array_003Cfloat_002C3_003E b(SerializationInfo P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1)
	{
		//IL_001d: Expected I, but got I8
		//IL_007a: Expected I, but got I8
		//IL_00d8: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01MMEEDKFM_0040X_003F_0024AA_0040));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E result);
		try
		{
			sbyte* value = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr + 24uL))) ? ((sbyte*)ptr) : ((sbyte*)(*(ulong*)ptr)));
			*(float*)(&result) = P_0.GetSingle(new string(value));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj2, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01NFFPALBN_0040Y_003F_0024AA_0040));
		try
		{
			sbyte* value2 = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr2 + 24uL))) ? ((sbyte*)ptr2) : ((sbyte*)(*(ulong*)ptr2)));
			System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 4)) = P_0.GetSingle(new string(value2));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = _003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj3, P_1, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_01POHCFINO_0040Z_003F_0024AA_0040));
		try
		{
			sbyte* value3 = ((16uL > (ulong)(*(long*)((ulong)(nint)ptr3 + 24uL))) ? ((sbyte*)ptr3) : ((sbyte*)(*(ulong*)ptr3)));
			System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref result, 8)) = P_0.GetSingle(new string(value3));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		try
		{
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj3, true, 0uL);
			return result;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
	}

	private static void Z(XmlReader P_0, string P_1)
	{
		if (P_0.Name != P_1)
		{
			throw new InvalidOperationException(P_1 + "element not found");
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

	~CameraSettings()
	{
		Dispose(A_0: false);
	}
}
