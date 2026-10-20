using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class ModelBaseWithTextureOrVertexColors : ModelBase
{
	protected Image _texture;

	protected VertexColor _vertex_color;

	public override void SetColorSolid(Color value)
	{
		base.SetColorSolid(value);
		_texture = null;
		_vertex_color = null;
	}

	public unsafe void SetColorTexture(Image image, float[] texture_coordinates)
	{
		//IL_005e: Expected I8, but got I
		//IL_00ea: Expected I, but got I8
		DisposedCheck();
		_vertex_color = null;
		_texture = image;
		fixed (float* ptr = &texture_coordinates[0])
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E obj);
			_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002E_007Bctor_007D(&obj, (ulong)texture_coordinates.LongLength);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj2);
				_Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E dest = *_003CModule_003E.std_002Evector_003Cfloat_002Cstd_003A_003Aallocator_003Cfloat_003E_0020_003E_002Ebegin(&obj, &obj2);
				long num = texture_coordinates.LongLength * 4;
				float* last = (float*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref *ptr, num));
				float* first = ptr;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E obj3);
				_003CModule_003E.std_002E_Copy_no_deprecate_003Cfloat_0020_002A_002Cclass_0020std_003A_003A_Vector_iterator_003Cclass_0020std_003A_003A_Vector_val_003Cstruct_0020std_003A_003A_Simple_types_003Cfloat_003E_0020_003E_0020_003E_0020_003E(&obj3, first, last, dest);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out xi func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
				System.Runtime.CompilerServices.Unsafe.As<xi, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<xi, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj4);
				shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* ptr2 = _texture.native_shared(&obj4);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E obj5);
					Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E* ptr3 = native(&obj5);
					try
					{
						_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020const_0020_0026_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_002Cclass_0020std_003A_003Avector_003Cfloat_002Cclass_0020std_003A_003Aallocator_003Cfloat_003E_0020_003E_0020_0026_003E(ptr3, func, ptr2, &obj);
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002E_007Bdtor_007D), &obj5);
						throw;
					}
					try
					{
						GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8))));
					}
					catch
					{
						//try-fault
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)));
						throw;
					}
					_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
				if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)) != 0L)
				{
					_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)));
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
	}

	public Image GetColorTexture()
	{
		DisposedCheck();
		return _texture;
	}

	public unsafe float[] GetTextureCoordinates()
	{
		//IL_0017: Expected I8, but got I
		//IL_0036: Expected I8, but got I
		//IL_006d: Expected I, but got I8
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E obj);
		native(&obj);
		float[] array;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ip func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			float* ptr = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cfloat_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ip func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 12)) = 0;
			float* ptr2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cfloat_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func2);
			array = new float[(int)((nint)((byte*)ptr2 - (nuint)ptr) >> 2)];
			int num = 0;
			float* ptr3 = ptr;
			if (ptr != ptr2)
			{
				do
				{
					array[num] = *ptr3;
					ptr3 = (float*)((ulong)(nint)ptr3 + 4uL);
					num++;
				}
				while (ptr3 != ptr2);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe void SetColorByVertex(VertexColor vertex_color)
	{
		//IL_001c: Expected I8, but got I
		//IL_009f: Expected I, but got I8
		DisposedCheck();
		_texture = null;
		_vertex_color = vertex_color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xx func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xx, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xx, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E* ptr = vertex_color.native_shared(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E* ptr2 = native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AVertexColor_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AVertexColor_003E_0020_003E(ptr2, func, ptr);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AVertexColor_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
	}

	public VertexColor GetColorByVertex()
	{
		DisposedCheck();
		return _vertex_color;
	}

	public unsafe float[] GetVertices()
	{
		//IL_0017: Expected I8, but got I
		//IL_0036: Expected I8, but got I
		//IL_006d: Expected I, but got I8
		DisposedCheck();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E obj);
		native(&obj);
		float[] array;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ip func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			float* ptr = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cfloat_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ip func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBaseWithTextureOrVertexColors_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<ip, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func2, 12)) = 0;
			float* ptr2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002Emethod_003Cfloat_0020const_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003A_003A_002A_0029_0028void_0029const_0020_003E(&obj, func2);
			array = new float[(int)((nint)((byte*)ptr2 - (nuint)ptr) >> 2)];
			int num = 0;
			float* ptr3 = ptr;
			if (ptr != ptr2)
			{
				do
				{
					array[num] = *ptr3;
					ptr3 = (float*)((ulong)(nint)ptr3 + 4uL);
					num++;
				}
				while (ptr3 != ptr2);
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002E_007Bdtor_007D), &obj);
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

	private void u()
	{
		if (!_is_disposed)
		{
			_texture = null;
			_vertex_color = null;
		}
	}

	protected ModelBaseWithTextureOrVertexColors()
	{
	}

	protected unsafe Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AModelBaseWithTextureOrVertexColors_003E_002E_007Bdtor_007D), P_0);
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
				u();
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
