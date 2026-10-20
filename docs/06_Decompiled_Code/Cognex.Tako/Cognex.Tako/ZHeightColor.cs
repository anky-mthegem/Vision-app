using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class ZHeightColor : DirectionalHeightColor
{
	public new unsafe Color[] Colors
	{
		get
		{
			//IL_002f: Expected I8, but got I
			//IL_00d3: Expected I, but got I8
			//IL_00d6: Expected I, but got I8
			if (_native == null)
			{
				throw new ObjectDisposedException("VertexColor already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E obj);
			*(long*)(&obj) = 0L;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = 0L;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0L;
			Color[] array;
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out P7 func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9DirectionalHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj2);
				Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = native(&obj2);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E obj3);
					vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E* right = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002Emethod_003Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj3, func);
					try
					{
						_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_003D(&obj, right);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_Tidy(&obj3);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj2);
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
				long num = (System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) - *(long*)(&obj)) / 12;
				array = new Color[(int)num];
				int num2 = 0;
				if (0uL < (ulong)num)
				{
					long num3 = 0L;
					do
					{
						long num4 = num3 + *(long*)(&obj);
						Sf* ptr2 = (Sf*)num4;
						Sf* ptr3 = (Sf*)num4;
						Color color = Color.FromArgb(255, (int)((double)(*(float*)num4) * 255.0), (int)((double)(*(float*)((ulong)(nint)ptr3 + 4uL)) * 255.0), (int)((double)(*(float*)((ulong)(nint)ptr2 + 8uL)) * 255.0));
						array[num2] = color;
						num2++;
						num3 += 12;
					}
					while ((ulong)num2 < (ulong)((System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) - *(long*)(&obj)) / 12));
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_Tidy(&obj);
			return array;
		}
	}

	public unsafe float Max
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_native == null)
			{
				throw new ObjectDisposedException("VertexColor already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pp func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ZHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<Pp, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Pp, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = native(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AZHeightColor_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe float Min
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_native == null)
			{
				throw new ObjectDisposedException("VertexColor already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pp func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ZHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<Pp, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Pp, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = native(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AZHeightColor_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
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

	protected ZHeightColor()
	{
	}

	public unsafe ZHeightColor(created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p)
	{
		//IL_004f: Expected I, but got I8
		//IL_0057: Expected I, but got I8
		//IL_0026: Expected I, but got I8
		//IL_0092: Expected I, but got I8
		//IL_00ba: Expected I, but got I8
		try
		{
			base._002Ector();
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj);
				_003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E(&obj, (shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*)p);
				try
				{
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)_003CModule_003E.@new(24uL);
					NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr4;
					try
					{
						if (ptr != null)
						{
							*(long*)ptr = *(long*)(&obj);
							NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr2 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)((ulong)(nint)ptr + 8uL);
							shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr3 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr2;
							*(long*)ptr3 = 0L;
							*(long*)((ulong)(nint)ptr3 + 8uL) = 0L;
							try
							{
								_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr2, &obj);
							}
							catch
							{
								//try-fault
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
								throw;
							}
							ptr4 = ptr;
						}
						else
						{
							ptr4 = null;
						}
					}
					catch
					{
						//try-fault
						_003CModule_003E.delete(ptr, 24uL);
						throw;
					}
					_native = ptr4;
					_is_disposed = false;
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				}
			}
			catch
			{
				//try-fault
				base.Dispose(A_0: true);
				throw;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), p);
			throw;
		}
		ulong num = *(ulong*)((ulong)(nint)p + 8uL);
		if (num != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
		}
	}

	public unsafe ZHeightColor(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*)ptrToShared.ToPointer()));
			}
			catch
			{
				//try-fault
				_003CModule_003E.delete(ptr, 24uL);
				throw;
			}
			_native = ptr2;
			_is_disposed = false;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe ZHeightColor(float min, float max, Color[] colors)
	{
		//IL_00fc: Expected I, but got I8
		//IL_0120: Expected I, but got I8
		//IL_00d0: Expected I, but got I8
		//IL_016a: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E obj);
			*(long*)(&obj) = 0L;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = 0L;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0L;
			try
			{
				_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002Eresize(&obj, (ulong)colors.LongLength);
				int num2 = 0;
				if (0 < (nint)colors.LongLength)
				{
					long num3 = 0L;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
					do
					{
						*(float*)(&sf) = (float)((double)colors[num2].R / 255.0);
						System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)colors[num2].G / 255.0);
						System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)colors[num2].B / 255.0);
						// IL cpblk instruction
						System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(num3 + *(long*)(&obj), ref sf, 12);
						num2++;
						num3 += 12;
					}
					while (num2 < (nint)colors.LongLength);
				}
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)_003CModule_003E.@new(24uL);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj2);
				NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr5;
				try
				{
					if (ptr != null)
					{
						created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020_0026_003E(&obj2, &min, &max, &obj);
						try
						{
							num = 1u;
							*(long*)ptr = *(long*)ptr2;
							NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)((ulong)(nint)ptr + 8uL);
							shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr3;
							*(long*)ptr4 = 0L;
							*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
							try
							{
								_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr3, (shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr2);
							}
							catch
							{
								//try-fault
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
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
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj2);
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
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj2);
					}
					throw;
				}
				if ((num & 1) != 0)
				{
					num &= 0xFFFFFFFEu;
					if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
					}
				}
				_is_disposed = false;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.std_002Evector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E_002E_Tidy(&obj);
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe ZHeightColor(float min, float max)
	{
		//IL_0057: Expected I, but got I8
		//IL_0079: Expected I, but got I8
		//IL_002e: Expected I, but got I8
		//IL_00c2: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr5;
			try
			{
				if (ptr != null)
				{
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_003E(&obj, &min, &max);
					try
					{
						num = 1u;
						*(long*)ptr = *(long*)ptr2;
						NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr3 = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)((ulong)(nint)ptr + 8uL);
						shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr4 = (shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr3;
						*(long*)ptr4 = 0L;
						*(long*)((ulong)(nint)ptr4 + 8uL) = 0L;
						try
						{
							_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_003D((shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr3, (shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)ptr2);
						}
						catch
						{
							//try-fault
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
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
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
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
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
				}
			}
			_is_disposed = false;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe static ZHeightColor Viridis(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002EViridis));
		return new ZHeightColor(p);
	}

	public unsafe static ZHeightColor Inferno(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002EInferno));
		return new ZHeightColor(p);
	}

	public unsafe static ZHeightColor Plasma(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002EPlasma));
		return new ZHeightColor(p);
	}

	public unsafe static ZHeightColor Magma(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002EMagma));
		return new ZHeightColor(p);
	}

	public unsafe static ZHeightColor Turbo(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002ETurbo));
		return new ZHeightColor(p);
	}

	public unsafe static ZHeightColor Jet(float min, float max)
	{
		//IL_0014: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E obj);
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* ptr = &obj;
		created_shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* p = _003CModule_003E.Cognex_002ETako_002EnativeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cclass_0020std_003A_003Avector_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E_0020_003E_0020const_0020_0026_003E(&obj, &min, &max, (vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<vector_003Ccognex_003A_003Atako_003A_003AColor_002Cstd_003A_003Aallocator_003Ccognex_003A_003Atako_003A_003AColor_003E_0020_003E*, ulong>(ref _003CModule_003E.__imp_cognex_002Etako_002Ecolormaps_002EJet));
		return new ZHeightColor(p);
	}

	private void u()
	{
	}

	public unsafe shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* native_shared(shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002Eshared_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E(_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	protected new unsafe void ThrowIfDisposed()
	{
		if (_native == null)
		{
			throw new ObjectDisposedException("VertexColor already disposed");
		}
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AZHeightColor_0020const_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
	{
		if (A_0)
		{
			try
			{
				return;
			}
			finally
			{
				base.Dispose(A_0: true);
			}
		}
		base.Dispose(A_0: false);
	}
}
