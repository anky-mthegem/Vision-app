using System;
using System.Runtime.CompilerServices;
using std;
using u;

namespace Cognex.Tako;

public class MeshStrip : Mesh
{
	public unsafe MeshStrip(float[] vertices, uint[] indices, float[] normals)
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
											created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr8 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_002Cfloat_0020_002A_0020_0026_002Cint_003E(&obj, &ptr4, &num4, &ptr5, &num3, &ptr6, &num2);
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

	public unsafe MeshStrip(float[] vertices, uint[] indices)
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
									created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
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
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
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
							created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
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
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr6 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_002Cfloat_0020_002A_0020_0026_002Cint_002Cunsigned_0020int_0020_002A_0020_0026_002Cint_003E(&obj, &ptr3, &num3, &ptr4, &num2);
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

	public unsafe MeshStrip(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AMeshStrip_003E*)ptrToShared.ToPointer()));
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

	public override void Save(string filename, PlyFormat format)
	{
		throw new InvalidOperationException("Can't save mesh strips to ply");
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AMeshStrip_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AMeshStrip_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AMeshStrip_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AMeshStrip_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AMeshStrip_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
