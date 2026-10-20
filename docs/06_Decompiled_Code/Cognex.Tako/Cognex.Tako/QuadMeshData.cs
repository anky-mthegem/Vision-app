using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class QuadMeshData : _51, IDisposable
{
	protected unsafe NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* _native;

	protected bool _is_disposed;

	public unsafe virtual int Height
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako QuadMeshData already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _59 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMeshData_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int Width
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako QuadMeshData already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _59 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe QuadMeshData(float[] vertices, int width, int height)
	{
		//IL_00aa: Expected I, but got I8
		//IL_00cc: Expected I, but got I8
		//IL_0081: Expected I, but got I8
		//IL_0119: Expected I, but got I8
		//The blocks IL_0059, IL_00d9, IL_00fa, IL_0101, IL_010f are reachable both inside and outside the pinned region starting at IL_0026. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		uint num = 0u;
		_is_disposed = false;
		base._002Ector();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
		_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)vertices.LongLength);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj4);
			if ((nint)vertices.LongLength > 0)
			{
				fixed (float* ptr = &vertices[0])
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj2);
					_Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E dest = *_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002Ebegin(&obj, &obj2);
					long num2 = vertices.LongLength * 4;
					float* last = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref *ptr, num2));
					float* first = ptr;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj3);
					_003CModule_003E.std_002E_Copy_no_deprecate_003Cfloat_0020_002A_002Cclass_0020std_003A_003A_Vector_iterator_003Cclass_0020std_003A_003A_Vector_val_003Cstruct_0020std_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E_0020_003E(&obj3, first, last, dest);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_003CModule_003E.@new(24uL);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr6;
					try
					{
						if (ptr2 != null)
						{
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_002Cint_0020_0026_002Cint_0020_0026_003E(&obj4, &obj, &width, &height);
							try
							{
								num = 1u;
								*(long*)ptr2 = *(long*)ptr3;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)((ulong)(nint)ptr2 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4;
								*(long*)ptr5 = 0L;
								*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr2 + 8uL));
									throw;
								}
								ptr6 = ptr2;
							}
							catch
							{
								//try-fault
								if ((num & 1) != 0)
								{
									num &= 0xFFFFFFFEu;
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj4);
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
						_003CModule_003E.delete(ptr2, 24uL);
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
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj4);
						}
						throw;
					}
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) != 0L)
						{
							_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
						}
					}
				}
			}
			else
			{
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_003CModule_003E.@new(24uL);
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr6;
				try
				{
					if (ptr2 != null)
					{
						created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_002Cint_0020_0026_002Cint_0020_0026_003E(&obj4, &obj, &width, &height);
						try
						{
							num = 1u;
							*(long*)ptr2 = *(long*)ptr3;
							NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)((ulong)(nint)ptr2 + 8uL);
							shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4;
							*(long*)ptr5 = 0L;
							*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
							try
							{
								_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3);
							}
							catch
							{
								//try-fault
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr2 + 8uL));
								throw;
							}
							ptr6 = ptr2;
						}
						catch
						{
							//try-fault
							if ((num & 1) != 0)
							{
								num &= 0xFFFFFFFEu;
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj4);
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
					_003CModule_003E.delete(ptr2, 24uL);
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
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj4);
					}
					throw;
				}
				if ((num & 1) != 0)
				{
					num &= 0xFFFFFFFEu;
					if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
					}
				}
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_Tidy(&obj);
	}

	public unsafe QuadMeshData(IntPtr ptrToShared)
	{
		//IL_0053: Expected I, but got I8
		//IL_005b: Expected I, but got I8
		//IL_002c: Expected I, but got I8
		_is_disposed = false;
		base._002Ector();
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_003CModule_003E.@new(24uL);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr5;
		try
		{
			if (ptr != null)
			{
				shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptrToShared.ToPointer();
				*(long*)ptr = *(long*)ptr2;
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)((ulong)(nint)ptr + 8uL);
				shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3;
				*(long*)ptr4 = 0L;
				*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
				try
				{
					_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3, ptr2);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
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
	}

	public unsafe QuadMeshData(string filename)
	{
		//IL_0080: Expected I, but got I8
		//IL_00a2: Expected I, but got I8
		//IL_0054: Expected I, but got I8
		//IL_00ef: Expected I, but got I8
		B b10 = null;
		string text = null;
		uint num = 0u;
		_is_disposed = false;
		base._002Ector();
		B b11 = new B();
		try
		{
			b10 = b11;
			text = filename;
			sbyte* ptr = B.internal_marshaler_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&text, b10.B);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr6;
			try
			{
				if (ptr2 != null)
				{
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cchar_0020const_0020_002A_0020_0026_003E(&obj, &ptr);
					try
					{
						num = 1u;
						*(long*)ptr2 = *(long*)ptr3;
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)((ulong)(nint)ptr2 + 8uL);
						shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr5 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4;
						*(long*)ptr5 = 0L;
						*(long*)((ulong)(nint)ptr5 + 8uL) = 0L;
						try
						{
							_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr4, (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3);
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr2 + 8uL));
							throw;
						}
						ptr6 = ptr2;
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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
				_003CModule_003E.delete(ptr2, 24uL);
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
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				}
			}
		}
		catch
		{
			//try-fault
			((IDisposable)b10).Dispose();
			throw;
		}
		((IDisposable)b10).Dispose();
	}

	public unsafe QuadMeshData()
	{
		//IL_005a: Expected I, but got I8
		//IL_007c: Expected I, but got I8
		//IL_0031: Expected I, but got I8
		//IL_00c5: Expected I, but got I8
		uint num = 0u;
		_is_disposed = false;
		base._002Ector();
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_003CModule_003E.@new(24uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr5;
		try
		{
			if (ptr != null)
			{
				created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_002Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_003E(&obj);
				try
				{
					num = 1u;
					*(long*)ptr = *(long*)ptr2;
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)((ulong)(nint)ptr + 8uL);
					shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3;
					*(long*)ptr4 = 0L;
					*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
					try
					{
						_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr3, (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)ptr2);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
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
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
			}
		}
	}

	public unsafe static void ImportPacket(Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* qm, byte[] packet)
	{
		//IL_004c: Expected I8, but got I
		//IL_0031->IL0031: Incompatible stack types: I8 vs Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj);
		try
		{
			ulong newsize = (ulong)packet.LongLength;
			_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Eresize(&obj, newsize, 0);
			if (System.Runtime.CompilerServices.Unsafe.As<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) != 0)
			{
				sbyte* value = (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref 16uL > (ulong)System.Runtime.CompilerServices.Unsafe.As<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 24)) ? ref *(byte*)(&obj) : ref *(byte*)(*(long*)(&obj)));
				IntPtr destination = new IntPtr(value);
				Marshal.Copy(packet, 0, destination, packet.Length);
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _5Y func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMeshData_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028class_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020_0026_003E(qm, func, &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	public unsafe virtual void ImportPacket(byte[] packet)
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako QuadMeshData already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* qm = native(&obj);
		try
		{
			ImportPacket(qm, packet);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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
	public unsafe virtual bool IsComplete()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako QuadMeshData already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _5J func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMeshData_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = native(&obj);
		bool result;
		try
		{
			result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), &obj);
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
		//IL_002f: Expected I, but got I8
		//IL_001e: Expected I, but got I8
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr = _native;
		if (ptr != null)
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* ptr2 = ptr;
			ulong num = *(ulong*)((long)(nint)ptr2 + 8L + 8);
			if (num != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
			}
			_003CModule_003E.delete(ptr2, 24uL);
			_native = null;
		}
	}

	protected void DisposedCheck()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako QuadMeshData already disposed");
		}
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002Elock((NativeRef_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E_002E_007Bdtor_007D), P_0);
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

	~QuadMeshData()
	{
		Dispose(A_0: false);
	}
}
