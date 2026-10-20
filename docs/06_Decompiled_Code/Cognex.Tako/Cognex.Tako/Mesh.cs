using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class Mesh : ModelBaseWithTextureOrVertexColors
{
	public unsafe bool LambertInPoints
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iw func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Mesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<iw, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<iw, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AMesh_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002E_007Bdtor_007D), &obj);
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
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iF func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Mesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<iF, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<iF, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AMesh_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe Mesh(float[] vertices, uint[] indices, float[] normals)
	{
		//IL_00b0: Expected I, but got I8
		//IL_00d2: Expected I, but got I8
		//IL_0087: Expected I, but got I8
		//IL_011b: Expected I, but got I8
		//The blocks IL_0022, IL_0027, IL_0030, IL_0035, IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_0020. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0030, IL_0035, IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_002e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_003c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_003c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0030, IL_0035, IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_002e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_003c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_003e, IL_00df, IL_0100, IL_0105, IL_0111, IL_011b are reachable both inside and outside the pinned region starting at IL_003c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			ref float/*pinned*/ reference = ref *(float*)null;
			ref uint/*pinned*/ reference2 = ref *(uint*)null;
			ref float/*pinned*/ reference3 = ref *(float*)null;
			float* ptr4;
			uint* ptr5;
			float* ptr6;
			int num2;
			int num3;
			int num4;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr7;
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr11;
			if ((nint)vertices.LongLength > 0)
			{
				fixed (float* ptr = &vertices[0])
				{
					if ((nint)indices.LongLength > 0)
					{
						fixed (uint* ptr2 = &indices[0])
						{
							if ((nint)normals.LongLength > 0)
							{
								fixed (float* ptr3 = &normals[0])
								{
									ptr4 = ptr;
									ptr5 = ptr2;
									ptr6 = ptr3;
									ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
									try
									{
										if (ptr7 != null)
										{
											num2 = normals.Length;
											num3 = indices.Length;
											num4 = vertices.Length;
											created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
											try
											{
												num = 1u;
												*(long*)ptr7 = *(long*)ptr8;
												NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
												shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
												*(long*)ptr10 = 0L;
												*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
												try
												{
													_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
												}
												catch
												{
													//try-fault
													_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
													throw;
												}
												ptr11 = ptr7;
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
											ptr11 = null;
										}
									}
									catch
									{
										//try-fault
										_003CModule_003E.delete(ptr7, 24uL);
										throw;
									}
									try
									{
										_native = ptr11;
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
							}
							ptr4 = ptr;
							ptr5 = ptr2;
							ptr6 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
							ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
							try
							{
								if (ptr7 != null)
								{
									num2 = normals.Length;
									num3 = indices.Length;
									num4 = vertices.Length;
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
									try
									{
										num = 1u;
										*(long*)ptr7 = *(long*)ptr8;
										NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
										shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
										*(long*)ptr10 = 0L;
										*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
										try
										{
											_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
										}
										catch
										{
											//try-fault
											_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
											throw;
										}
										ptr11 = ptr7;
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
									ptr11 = null;
								}
							}
							catch
							{
								//try-fault
								_003CModule_003E.delete(ptr7, 24uL);
								throw;
							}
							try
							{
								_native = ptr11;
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
					}
					if ((nint)normals.LongLength > 0)
					{
						fixed (float* ptr3 = &normals[0])
						{
							ptr4 = ptr;
							ptr5 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
							ptr6 = ptr3;
							ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
							try
							{
								if (ptr7 != null)
								{
									num2 = normals.Length;
									num3 = indices.Length;
									num4 = vertices.Length;
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
									try
									{
										num = 1u;
										*(long*)ptr7 = *(long*)ptr8;
										NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
										shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
										*(long*)ptr10 = 0L;
										*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
										try
										{
											_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
										}
										catch
										{
											//try-fault
											_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
											throw;
										}
										ptr11 = ptr7;
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
									ptr11 = null;
								}
							}
							catch
							{
								//try-fault
								_003CModule_003E.delete(ptr7, 24uL);
								throw;
							}
							try
							{
								_native = ptr11;
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
					}
					ptr4 = ptr;
					ptr5 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					ptr6 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
					ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					try
					{
						if (ptr7 != null)
						{
							num2 = normals.Length;
							num3 = indices.Length;
							num4 = vertices.Length;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
							try
							{
								num = 1u;
								*(long*)ptr7 = *(long*)ptr8;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
								*(long*)ptr10 = 0L;
								*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
									throw;
								}
								ptr11 = ptr7;
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
							ptr11 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr7, 24uL);
						throw;
					}
					try
					{
						_native = ptr11;
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
			}
			if ((nint)indices.LongLength > 0)
			{
				fixed (uint* ptr2 = &indices[0])
				{
					if ((nint)normals.LongLength > 0)
					{
						fixed (float* ptr3 = &normals[0])
						{
							ptr4 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
							ptr5 = ptr2;
							ptr6 = ptr3;
							ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
							try
							{
								if (ptr7 != null)
								{
									num2 = normals.Length;
									num3 = indices.Length;
									num4 = vertices.Length;
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
									try
									{
										num = 1u;
										*(long*)ptr7 = *(long*)ptr8;
										NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
										shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
										*(long*)ptr10 = 0L;
										*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
										try
										{
											_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
										}
										catch
										{
											//try-fault
											_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
											throw;
										}
										ptr11 = ptr7;
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
									ptr11 = null;
								}
							}
							catch
							{
								//try-fault
								_003CModule_003E.delete(ptr7, 24uL);
								throw;
							}
							try
							{
								_native = ptr11;
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
					}
					ptr4 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					ptr5 = ptr2;
					ptr6 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
					ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					try
					{
						if (ptr7 != null)
						{
							num2 = normals.Length;
							num3 = indices.Length;
							num4 = vertices.Length;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
							try
							{
								num = 1u;
								*(long*)ptr7 = *(long*)ptr8;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
								*(long*)ptr10 = 0L;
								*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
									throw;
								}
								ptr11 = ptr7;
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
							ptr11 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr7, 24uL);
						throw;
					}
					try
					{
						_native = ptr11;
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
			}
			if ((nint)normals.LongLength > 0)
			{
				fixed (float* ptr3 = &normals[0])
				{
					ptr4 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					ptr5 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					ptr6 = ptr3;
					ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					try
					{
						if (ptr7 != null)
						{
							num2 = normals.Length;
							num3 = indices.Length;
							num4 = vertices.Length;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
							try
							{
								num = 1u;
								*(long*)ptr7 = *(long*)ptr8;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
								*(long*)ptr10 = 0L;
								*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
									throw;
								}
								ptr11 = ptr7;
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
							ptr11 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr7, 24uL);
						throw;
					}
					try
					{
						_native = ptr11;
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
			}
			ptr4 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			ptr5 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
			ptr6 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3);
			ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			try
			{
				if (ptr7 != null)
				{
					num2 = normals.Length;
					num3 = indices.Length;
					num4 = vertices.Length;
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
					try
					{
						num = 1u;
						*(long*)ptr7 = *(long*)ptr8;
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr7 + 8uL);
						shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr10 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9;
						*(long*)ptr10 = 0L;
						*(long*)((ulong)(nint)ptr10 + 8uL) = 0L;
						try
						{
							_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr9, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr8);
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr7 + 8uL));
							throw;
						}
						ptr11 = ptr7;
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
					ptr11 = null;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr7, 24uL);
				throw;
			}
			try
			{
				_native = ptr11;
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

	public unsafe Mesh(float[] vertices, uint[] indices)
	{
		//IL_008f: Expected I, but got I8
		//IL_00b1: Expected I, but got I8
		//IL_0066: Expected I, but got I8
		//IL_00fa: Expected I, but got I8
		//The blocks IL_001e, IL_0023, IL_002c, IL_00be, IL_00df, IL_00e4, IL_00f0, IL_00fa are reachable both inside and outside the pinned region starting at IL_001c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_002c, IL_00be, IL_00df, IL_00e4, IL_00f0, IL_00fa are reachable both inside and outside the pinned region starting at IL_002a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_002c, IL_00be, IL_00df, IL_00e4, IL_00f0, IL_00fa are reachable both inside and outside the pinned region starting at IL_002a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			ref float/*pinned*/ reference = ref *(float*)null;
			ref uint/*pinned*/ reference2 = ref *(uint*)null;
			float* ptr3;
			uint* ptr4;
			int num2;
			int num3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr5;
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr9;
			if ((nint)vertices.LongLength > 0)
			{
				fixed (float* ptr = &vertices[0])
				{
					if ((nint)indices.LongLength > 0)
					{
						fixed (uint* ptr2 = &indices[0])
						{
							ptr3 = ptr;
							ptr4 = ptr2;
							ptr5 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
							try
							{
								if (ptr5 != null)
								{
									num2 = indices.Length;
									num3 = vertices.Length;
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
									try
									{
										num = 1u;
										*(long*)ptr5 = *(long*)ptr6;
										NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr5 + 8uL);
										shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7;
										*(long*)ptr8 = 0L;
										*(long*)((ulong)(nint)ptr8 + 8uL) = 0L;
										try
										{
											_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr6);
										}
										catch
										{
											//try-fault
											_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr5 + 8uL));
											throw;
										}
										ptr9 = ptr5;
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
									ptr9 = null;
								}
							}
							catch
							{
								//try-fault
								_003CModule_003E.delete(ptr5, 24uL);
								throw;
							}
							try
							{
								_native = ptr9;
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
					}
					ptr3 = ptr;
					ptr4 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					ptr5 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					try
					{
						if (ptr5 != null)
						{
							num2 = indices.Length;
							num3 = vertices.Length;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
							try
							{
								num = 1u;
								*(long*)ptr5 = *(long*)ptr6;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr5 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7;
								*(long*)ptr8 = 0L;
								*(long*)((ulong)(nint)ptr8 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr6);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr5 + 8uL));
									throw;
								}
								ptr9 = ptr5;
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
							ptr9 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr5, 24uL);
						throw;
					}
					try
					{
						_native = ptr9;
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
			}
			if ((nint)indices.LongLength > 0)
			{
				fixed (uint* ptr2 = &indices[0])
				{
					ptr3 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					ptr4 = ptr2;
					ptr5 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
					try
					{
						if (ptr5 != null)
						{
							num2 = indices.Length;
							num3 = vertices.Length;
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
							try
							{
								num = 1u;
								*(long*)ptr5 = *(long*)ptr6;
								NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr5 + 8uL);
								shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7;
								*(long*)ptr8 = 0L;
								*(long*)((ulong)(nint)ptr8 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr6);
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr5 + 8uL));
									throw;
								}
								ptr9 = ptr5;
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
							ptr9 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr5, 24uL);
						throw;
					}
					try
					{
						_native = ptr9;
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
			}
			ptr3 = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			ptr4 = (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
			ptr5 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			try
			{
				if (ptr5 != null)
				{
					num2 = indices.Length;
					num3 = vertices.Length;
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
					try
					{
						num = 1u;
						*(long*)ptr5 = *(long*)ptr6;
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr7 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)((ulong)(nint)ptr5 + 8uL);
						shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7;
						*(long*)ptr8 = 0L;
						*(long*)((ulong)(nint)ptr8 + 8uL) = 0L;
						try
						{
							_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr7, (shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*)ptr6);
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr5 + 8uL));
							throw;
						}
						ptr9 = ptr5;
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
					ptr9 = null;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr5, 24uL);
				throw;
			}
			try
			{
				_native = ptr9;
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

	public unsafe Mesh(string filename)
	{
		//IL_0079: Expected I, but got I8
		//IL_009b: Expected I, but got I8
		//IL_004d: Expected I, but got I8
		//IL_00e4: Expected I, but got I8
		B b10 = null;
		string text = null;
		uint num = 0u;
		((Node)this)._002Ector();
		try
		{
			B b11 = new B();
			try
			{
				b10 = b11;
				text = filename;
				sbyte* ptr = B.internal_marshaler_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&text, b10.B);
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6;
				try
				{
					if (ptr2 != null)
					{
						created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr3 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_002Cchar_0020const_0020_002A_0020_0026_003E(&obj, &ptr);
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
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
			}
			catch
			{
				//try-fault
				((IDisposable)b10).Dispose();
				throw;
			}
			((IDisposable)b10).Dispose();
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe Mesh(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AMesh_003E*)ptrToShared.ToPointer()));
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

	public Mesh()
	{
	}

	public unsafe uint[] GetIndices()
	{
		//IL_0017: Expected I8, but got I
		//IL_0036: Expected I8, but got I
		//IL_006d: Expected I, but got I8
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E obj);
		native(&obj);
		uint[] array;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out i7 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Mesh_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<i7, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<i7, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			uint* ptr = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002Emethod_003Cunsigned_0020int_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AMesh_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out i7 func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Mesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<i7, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<i7, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 12)) = 0;
			uint* ptr2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002Emethod_003Cunsigned_0020int_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AMesh_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func2);
			array = new uint[(int)((nint)((byte*)ptr2 - (nuint)ptr) >> 2)];
			int num = 0;
			uint* ptr3 = ptr;
			if (ptr != ptr2)
			{
				do
				{
					array[num] = *ptr3;
					ptr3 = (uint*)((ulong)(nint)ptr3 + 4uL);
					num++;
				}
				while (ptr3 != ptr2);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002E_007Bdtor_007D), &obj);
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
		return array;
	}

	public unsafe virtual void Save(string filename, PlyFormat format)
	{
		//IL_0030: Expected I8, but got I
		B b10 = null;
		string text = null;
		DisposedCheck();
		B b11 = new B();
		try
		{
			b10 = b11;
			text = filename;
			sbyte* ptr = B.internal_marshaler_003Cchar_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&text, b10.B);
			B1 b12 = (B1)format;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iM func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Mesh_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<iM, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<iM, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E* ptr2 = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AMesh_003A_003A_002A_0029_0028char_0020const_0020_002A_002Cenum_0020cognex_003A_003Atako_003A_003APlyFormat_0029const_0020_002Cchar_0020const_0020_002A_0020_0026_002Cenum_0020cognex_003A_003Atako_003A_003APlyFormat_003E(ptr2, func, &ptr, &b12);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002E_007Bdtor_007D), &obj);
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
		catch
		{
			//try-fault
			((IDisposable)b10).Dispose();
			throw;
		}
		((IDisposable)b10).Dispose();
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AMesh_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMesh_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMesh_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
