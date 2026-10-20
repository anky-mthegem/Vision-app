using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using u;

namespace Cognex.Tako;

public class TrackingTarget : IDisposable
{
	protected unsafe NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* _native;

	protected bool _is_disposed;

	public unsafe int NodeId
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_native == null)
			{
				throw new ObjectDisposedException("TrackingTarget already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003FNodeId_0040TrackingTarget_0040tako_0040cognex_0040_0040_0024_0024FQEBAHXZ;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ATrackingTarget_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe bool IsTrackingNode
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_native == null)
			{
				throw new ObjectDisposedException("TrackingTarget already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003FIsTrackingNode_0040TrackingTarget_0040tako_0040cognex_0040_0040_0024_0024FQEBA_NXZ;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ATrackingTarget_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe bool IsTrackingAll
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_native == null)
			{
				throw new ObjectDisposedException("TrackingTarget already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003FIsTrackingAll_0040TrackingTarget_0040tako_0040cognex_0040_0040_0024_0024FQEBA_NXZ;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003ATrackingTarget_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe static TrackingTarget AllFast()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pe pe);
		return new TrackingTarget(_003CModule_003E.u_002EPe_002EAllFast(&pe));
	}

	[Obsolete("Deprecated. Use AllFast()")]
	public unsafe static TrackingTarget All()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pe pe);
		return new TrackingTarget(_003CModule_003E.u_002EPe_002EAllFast(&pe));
	}

	public unsafe static TrackingTarget AllPrecise()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pe pe);
		return new TrackingTarget(_003CModule_003E.u_002EPe_002EAllPrecise(&pe));
	}

	public unsafe static TrackingTarget NodePrecise(int id)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pe pe);
		return new TrackingTarget(_003CModule_003E.u_002EPe_002ENodePrecise(&pe, id));
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

	public unsafe Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* native(Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002Elock(_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	protected unsafe TrackingTarget(Pe* native)
	{
		//IL_004b: Expected I, but got I8
		//IL_0022: Expected I, but got I8
		//IL_002a: Expected I8, but got I
		//IL_0091: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = (NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*)_003CModule_003E.@new(8uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
		NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr4;
		try
		{
			if (ptr != null)
			{
				created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNew_003Cclass_0020cognex_003A_003Atako_003A_003ATrackingTarget_002Cclass_0020cognex_003A_003Atako_003A_003ATrackingTarget_0020const_0020_0026_003E(&obj, native);
				try
				{
					num = 1u;
					Pe* ptr3 = (Pe*)(*(ulong*)ptr2);
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
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 8uL);
			}
		}
		_is_disposed = false;
	}

	public unsafe TrackingTarget(IntPtr ptrToNative)
	{
		//IL_004c: Expected I, but got I8
		//IL_001d: Expected I8, but got I
		//IL_0023: Expected I, but got I8
		//IL_002b: Expected I8, but got I
		//IL_0092: Expected I, but got I8
		uint num = 0u;
		base._002Ector();
		NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = (NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*)_003CModule_003E.@new(8uL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
		NativeRef_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr3;
		try
		{
			if (ptr != null)
			{
				*(long*)(&obj) = (nint)ptrToNative.ToPointer();
				try
				{
					num = 1u;
					Pe* ptr2 = (Pe*)(*(ulong*)(&obj));
					*(long*)(&obj) = 0L;
					*(long*)ptr = (nint)ptr2;
					ptr3 = ptr;
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr3 = null;
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
			_native = ptr3;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_ptr_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E_002E_007Bdtor_007D), &obj);
			}
			throw;
		}
		if ((num & 1) != 0)
		{
			num &= 0xFFFFFFFEu;
			if (*(long*)(&obj) != 0L)
			{
				_003CModule_003E.delete((void*)(*(ulong*)(&obj)), 8uL);
			}
		}
		_is_disposed = false;
	}

	protected unsafe void ThrowIfDisposed()
	{
		if (_native == null)
		{
			throw new ObjectDisposedException("TrackingTarget already disposed");
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

	~TrackingTarget()
	{
		Dispose(A_0: false);
	}
}
