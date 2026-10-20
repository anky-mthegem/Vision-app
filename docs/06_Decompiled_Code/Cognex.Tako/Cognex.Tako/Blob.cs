using System;
using System.Runtime.CompilerServices;
using System.Windows.Media.Media3D;
using std;
using u;

namespace Cognex.Tako;

public class Blob : ModelBase
{
	public unsafe Blob(float[] centers, Vector3D boxsize)
	{
		//IL_00c4: Expected I, but got I8
		//IL_00e6: Expected I, but got I8
		//IL_009b: Expected I, but got I8
		//IL_012f: Expected I, but got I8
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			fixed (float* ptr = &centers[0])
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
				_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)centers.LongLength);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj2);
					_Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E dest = *_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002Ebegin(&obj, &obj2);
					long num2 = centers.LongLength * 4;
					float* last = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref *ptr, num2));
					float* first = ptr;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj3);
					_003CModule_003E.std_002E_Copy_no_deprecate_003Cfloat_0020_002A_002Cclass_0020std_003A_003A_Vector_iterator_003Cclass_0020std_003A_003A_Vector_val_003Cstruct_0020std_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E_0020_003E(&obj3, first, last, dest);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj5);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* native;
					try
					{
						if (ptr2 != null)
						{
							System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj4);
							*(float*)(&obj4) = (float)boxsize.X;
							System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 4)) = (float)boxsize.Y;
							System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) = (float)boxsize.Z;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003ABlob_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(&obj5, &obj, &obj4);
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
								native = ptr2;
							}
							catch
							{
								//try-fault
								if ((num & 1) != 0)
								{
									num &= 0xFFFFFFFEu;
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj5);
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
						_003CModule_003E.delete(ptr2, 24uL);
						throw;
					}
					try
					{
						_native = native;
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj5);
						}
						throw;
					}
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)) != 0L)
						{
							_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)));
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

	public unsafe Blob(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* native;
			try
			{
				native = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003ABlob_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003ABlob_003E*)ptrToShared.ToPointer()));
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

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003ABlob_003E* u(Locker_003Ccognex_003A_003Atako_003A_003ABlob_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003ABlob_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ABlob_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ABlob_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
