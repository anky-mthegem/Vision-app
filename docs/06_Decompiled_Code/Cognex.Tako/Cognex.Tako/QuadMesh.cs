using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class QuadMesh : ModelBaseWithTextureOrVertexColors, _51
{
	public unsafe bool LambertInPoints
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _5Q func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<_5Q, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_5Q, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMesh_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _5m func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMesh_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<_5m, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_5m, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMesh_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int Height
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _59 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMeshData_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _59 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Image_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe UnconnectedPointsDisplayMode UnconnectedPointsDisplayMode
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _5L func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<_5L, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_5L, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			UnconnectedPointsDisplayMode result;
			try
			{
				result = (UnconnectedPointsDisplayMode)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003AUnconnectedPointsDisplayMode_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMesh_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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
		set
		{
			//IL_0010: Expected I8, but got I
			DisposedCheck();
			BY bY2 = (BY)value;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _56 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<_56, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<_56, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMesh_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003AUnconnectedPointsDisplayMode_0029_002Cenum_0020cognex_003A_003Atako_003A_003AUnconnectedPointsDisplayMode_003E(ptr, func, &bY2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe QuadMesh(float[] vertices, int width, int height)
	{
		//IL_00a3: Expected I, but got I8
		//IL_00c5: Expected I, but got I8
		//IL_007a: Expected I, but got I8
		//IL_0112: Expected I, but got I8
		//The blocks IL_0052, IL_00d2, IL_00f3, IL_00fa, IL_0108 are reachable both inside and outside the pinned region starting at IL_001f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
			_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)vertices.LongLength);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj4);
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
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6;
						try
						{
							if (ptr2 != null)
							{
								created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMesh_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_002Cint_0020_0026_002Cint_0020_0026_003E(&obj4, &obj, &width, &height);
								try
								{
									num = 1u;
									*(long*)ptr2 = *(long*)ptr3;
									NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr2 + 8uL);
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
										_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr2 + 8uL));
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
										_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj4);
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
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj4);
							}
							throw;
						}
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) != 0L)
							{
								_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
							}
						}
					}
				}
				else
				{
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6;
					try
					{
						if (ptr2 != null)
						{
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMesh_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_002Cint_0020_0026_002Cint_0020_0026_003E(&obj4, &obj, &width, &height);
							try
							{
								num = 1u;
								*(long*)ptr2 = *(long*)ptr3;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr4 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr2 + 8uL);
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
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr2 + 8uL));
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
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj4);
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
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj4);
						}
						throw;
					}
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) != 0L)
						{
							_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
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
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe QuadMesh()
	{
		//IL_0053: Expected I, but got I8
		//IL_0075: Expected I, but got I8
		//IL_002a: Expected I, but got I8
		//IL_00be: Expected I, but got I8
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr5;
			try
			{
				if (ptr != null)
				{
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMesh_003E(&obj);
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
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				}
			}
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

	public unsafe QuadMesh(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMesh_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*)ptrToShared.ToPointer()));
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

	public unsafe virtual void ImportPacket(byte[] packet)
	{
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* qm = native_cast_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E(&obj);
		try
		{
			QuadMeshData.ImportPacket(qm, packet);
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
		//IL_000e: Expected I8, but got I
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _5J func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMeshData_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr = native(&obj);
		bool result;
		try
		{
			result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMeshData_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe void SetColorTextureFromImageTransform(Image image, ImageTransform imageTransform)
	{
		//IL_0024: Expected I8, but got I
		//IL_00ae: Expected I, but got I8
		DisposedCheck();
		_vertex_color = null;
		_texture = image;
		array_003Cfloat_002C6_003E obj = ImageTransform.to_NativeTransform(imageTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _5O func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9QuadMesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<_5O, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<_5O, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj2);
		shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr = _texture.native_shared(&obj2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E obj3);
			Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* ptr2 = native(&obj3);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AQuadMesh_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020const_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C6_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_002Cclass_0020std_003A_003Aarray_003Cfloat_002C6_003E_0020_003E(ptr2, func, ptr, &obj);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), &obj3);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* native_cast_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E(Locker_003Ccognex_003A_003Atako_003A_003AQuadMeshData_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMeshData_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AQuadMesh_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AQuadMesh_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
