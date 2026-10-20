using System;
using System.Runtime.CompilerServices;
using std;
using u;

namespace Cognex.Tako;

public class ConvexPolygon2D : ModelBaseWithTextureDefaultCoords
{
	public unsafe ConvexPolygon2D(float[] vertices)
	{
		//IL_009a: Expected I, but got I8
		//IL_00bc: Expected I, but got I8
		//IL_0071: Expected I, but got I8
		//IL_0105: Expected I, but got I8
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			fixed (float* ptr = &vertices[0])
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
				_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)vertices.LongLength);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj2);
					_Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E dest = *_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002Ebegin(&obj, &obj2);
					long num2 = vertices.LongLength * 4;
					float* last = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref *ptr, num2));
					float* first = ptr;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj3);
					_003CModule_003E.std_002E_Copy_no_deprecate_003Cfloat_0020_002A_002Cclass_0020std_003A_003A_Vector_iterator_003Cclass_0020std_003A_003A_Vector_val_003Cstruct_0020std_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E_0020_003E(&obj3, first, last, dest);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj4);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6;
					try
					{
						if (ptr2 != null)
						{
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AConvexPolygon2D_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0020_003E(&obj4, &obj);
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
					SetModelMatrixChangedCallback();
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
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe ConvexPolygon2D(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AConvexPolygon2D_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E*)ptrToShared.ToPointer()));
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

	public unsafe void UpdateVertices(float[] vertices)
	{
		//IL_004e: Expected I8, but got I
		DisposedCheck();
		fixed (float* ptr = &vertices[0])
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
			_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)vertices.LongLength);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj2);
				_Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E dest = *_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002Ebegin(&obj, &obj2);
				long num = vertices.LongLength * 4;
				float* last = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref *ptr, num));
				float* first = ptr;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj3);
				_003CModule_003E.std_002E_Copy_no_deprecate_003Cfloat_0020_002A_002Cclass_0020std_003A_003A_Vector_iterator_003Cclass_0020std_003A_003A_Vector_val_003Cstruct_0020std_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E_0020_003E(&obj3, first, last, dest);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out xZ func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ConvexPolygon2D_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
				System.Runtime.CompilerServices.Unsafe.As<xZ, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<xZ, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E obj4);
				Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E* ptr2 = u(&obj4);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AConvexPolygon2D_003A_003A_002A_0029_0028class_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0029_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0020_003E(ptr2, func, &obj);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
				try
				{
					GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8))));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
					throw;
				}
				_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_Tidy(&obj);
		}
	}

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E* u(Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AConvexPolygon2D_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AConvexPolygon2D_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
