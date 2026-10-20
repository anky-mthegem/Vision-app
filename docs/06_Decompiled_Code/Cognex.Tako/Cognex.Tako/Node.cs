using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class Node : HasChrono, IDisposable
{
	public delegate void ModelMatrixChangedCallback();

	private EventHandler B;

	protected ModelMatrixChangedCallback _model_matrix_changed_cb;

	protected bool _is_disposed = false;

	protected Chrono chrono_;

	protected unsafe NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* _native = null;

	public unsafe virtual Chrono Chrono
	{
		get
		{
			//IL_0023: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			if (chrono_ == null)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ig func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9HasChrono_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
				Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
				try
				{
					chrono_ = new Chrono(_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cclass_0020cognex_003A_003Atako_003A_003AChrono_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AHasChrono_003A_003A_002A_0029_0028void_0029_003E(ptr, func));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
			return chrono_;
		}
	}

	public unsafe ColorMode ColorMode
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Xz func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			ColorMode result;
			try
			{
				result = (ColorMode)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003AColorMode_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe float Opacity
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iu func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BFI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out iW func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BFA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028float_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe bool Visible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ii func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Tako Node already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ix func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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

	[SpecialName]
	public event EventHandler ModelMatrixChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			B = (EventHandler)Delegate.Combine(B, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			B = (EventHandler)Delegate.Remove(B, value);
		}
	}

	public unsafe virtual void SetColorSolid(Color value)
	{
		//IL_0064: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
		*(float*)(&sf) = (float)((double)value.R / 255.0);
		System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
		System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ij func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0026_003E(ptr, func, &sf);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe Color GetColorSolid()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ic func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			Sf* ptr2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlockUnaligned(ref sf2, ptr2, 12);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
		return Color.FromArgb(255, (int)((double)(*(float*)(&sf2)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf2, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf2, 8)) * 255.0));
	}

	[SpecialName]
	protected void raise_ModelMatrixChanged(object value0, EventArgs value1)
	{
		B?.Invoke(value0, value1);
	}

	public unsafe void SetModelMatrix(Transform tr)
	{
		//IL_0022: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
		array_003Cfloat_002C16_003E obj = Transform.to_NativeTransform(tr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out iX func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C16_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C16_003E_0020_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj2);
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

	public unsafe Transform GetModelMatrix()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out iR func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
		Transform result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C16_003E obj2);
			result = Transform.to_ManagedTransform(*_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C16_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* native_shared(shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Eshared(_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	protected unsafe Node()
	{
		//IL_000f: Expected I, but got I8
	}

	protected void DisposedCheck()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
	}

	protected void RiseModelMatrixChangedEvent()
	{
		EventArgs empty = EventArgs.Empty;
		B?.Invoke(this, empty);
	}

	protected unsafe void SetModelMatrixChangedCallback()
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Tako Node already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<void> obj = (delegate* unmanaged[Cdecl, Cdecl]<void>)Marshal.GetFunctionPointerForDelegate(_model_matrix_changed_cb = RiseModelMatrixChangedEvent).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BEI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028void_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj2);
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
		//IL_0023: Expected I8, but got I
		//IL_00bd: Expected I, but got I8
		//IL_00ac: Expected I, but got I8
		if (_native == null)
		{
			return;
		}
		chrono_?.ResetNative();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out i5 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Node_0040tako_0040cognex_0040_0040_0024_0024F_0024BEI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out SH sH);
		System.Runtime.CompilerServices.Unsafe.As<SH, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sH, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ANode_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0020_003E(ptr, func, &sH);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<SH*, void>)(&_003CModule_003E.u_002ESH_002E_007Bdtor_007D), &sH);
			throw;
		}
		_003CModule_003E.u_002E2H_002E_Tidy((_2H*)(&sH));
		NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* native = _native;
		if (native != null)
		{
			ulong num = *(ulong*)((long)(nint)native + 8L + 8);
			if (num != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
			}
			_003CModule_003E.delete(native, 24uL);
		}
		_native = null;
	}

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* n(Locker_003Ccognex_003A_003Atako_003A_003ANode_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), P_0);
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

	~Node()
	{
		Dispose(A_0: false);
	}
}
