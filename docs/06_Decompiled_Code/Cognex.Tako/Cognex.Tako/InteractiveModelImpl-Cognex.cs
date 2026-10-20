using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class InteractiveModelImpl_003CCognex_003A_003ATako_003A_003AModelBaseWithTextureDefaultCoords_003E : ModelBaseWithTextureDefaultCoords, InteractiveModel
{
	private delegate void DragCallback(int P_0);

	private EventHandler<DragEventArgs> b;

	private EventHandler<DragEventArgs> Z;

	private DragCallback f;

	private DragCallback S;

	[SpecialName]
	public virtual event EventHandler<DragEventArgs> DragEndEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			Z = (EventHandler<DragEventArgs>)Delegate.Combine(Z, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			Z = (EventHandler<DragEventArgs>)Delegate.Remove(Z, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<DragEventArgs> DragBeginEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			b = (EventHandler<DragEventArgs>)Delegate.Combine(b, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			b = (EventHandler<DragEventArgs>)Delegate.Remove(b, value);
		}
	}

	[SpecialName]
	protected virtual void raise_DragBeginEvent(object value0, DragEventArgs value1)
	{
		b?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_DragEndEvent(object value0, DragEventArgs value1)
	{
		Z?.Invoke(value0, value1);
	}

	private unsafe void u()
	{
		//IL_0013: Expected I8, but got I
		//IL_0087: Expected I8, but got I
		if (_native == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sz sz);
		System.Runtime.CompilerServices.Unsafe.As<Sz, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sz, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr = P(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0020_003E(ptr, func, &sz);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sz*, void>)(&_003CModule_003E.u_002ESz_002E_007Bdtor_007D), &sz);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_003E*)(&sz));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func2);
		*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sz sz2);
		System.Runtime.CompilerServices.Unsafe.As<Sz, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sz2, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr2 = P(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0020_003E(ptr2, func2, &sz2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sz*, void>)(&_003CModule_003E.u_002ESz_002E_007Bdtor_007D), &sz2);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_003E*)(&sz2));
	}

	private void W()
	{
		if (!_is_disposed)
		{
			u();
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
	{
		if (A_0)
		{
			try
			{
				W();
				return;
			}
			finally
			{
				base.Dispose(A_0: true);
			}
		}
		try
		{
			u();
		}
		finally
		{
			base.Dispose(A_0: false);
		}
	}

	~InteractiveModelImpl_003CCognex_003A_003ATako_003A_003AModelBaseWithTextureDefaultCoords_003E()
	{
		Dispose(A_0: false);
	}

	protected InteractiveModelImpl_003CCognex_003A_003ATako_003A_003AModelBaseWithTextureDefaultCoords_003E()
	{
	}

	protected unsafe void BindDragCallbacksToEvents()
	{
		//IL_0033: Expected I8, but got I
		//IL_00b0: Expected I8, but got I
		DisposedCheck();
		delegate* unmanaged[Cdecl, Cdecl]<int, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<int, void>)Marshal.GetFunctionPointerForDelegate(f = n).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr = P(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj2);
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
		delegate* unmanaged[Cdecl, Cdecl]<int, void> obj3 = (delegate* unmanaged[Cdecl, Cdecl]<int, void>)Marshal.GetFunctionPointerForDelegate(S = B).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func2);
		*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj4);
		Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr2 = P(&obj4);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0029_003E(ptr2, func2, &obj3);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj4);
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

	private void n(int P_0)
	{
		raise_DragBeginEvent(this, new DragEventArgs(P_0));
	}

	private void B(int P_0)
	{
		raise_DragEndEvent(this, new DragEventArgs(P_0));
	}

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* P(Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AInteractiveModel_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
public class InteractiveModelImpl_003CCognex_003A_003ATako_003A_003ALineSeg_003E : LineSeg, InteractiveModel
{
	private delegate void DragCallback(int P_0);

	private EventHandler<DragEventArgs> b;

	private EventHandler<DragEventArgs> Z;

	private DragCallback f;

	private DragCallback S;

	[SpecialName]
	public virtual event EventHandler<DragEventArgs> DragEndEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			Z = (EventHandler<DragEventArgs>)Delegate.Combine(Z, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			Z = (EventHandler<DragEventArgs>)Delegate.Remove(Z, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<DragEventArgs> DragBeginEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			b = (EventHandler<DragEventArgs>)Delegate.Combine(b, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			b = (EventHandler<DragEventArgs>)Delegate.Remove(b, value);
		}
	}

	[SpecialName]
	protected virtual void raise_DragBeginEvent(object value0, DragEventArgs value1)
	{
		b?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_DragEndEvent(object value0, DragEventArgs value1)
	{
		Z?.Invoke(value0, value1);
	}

	private unsafe void u()
	{
		//IL_0013: Expected I8, but got I
		//IL_0087: Expected I8, but got I
		if (_native == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sz sz);
		System.Runtime.CompilerServices.Unsafe.As<Sz, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sz, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr = P(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0020_003E(ptr, func, &sz);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sz*, void>)(&_003CModule_003E.u_002ESz_002E_007Bdtor_007D), &sz);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_003E*)(&sz));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func2);
		*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sz sz2);
		System.Runtime.CompilerServices.Unsafe.As<Sz, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sz2, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr2 = P(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0020_003E(ptr2, func2, &sz2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sz*, void>)(&_003CModule_003E.u_002ESz_002E_007Bdtor_007D), &sz2);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_003E*)(&sz2));
	}

	private void W()
	{
		if (!_is_disposed)
		{
			u();
		}
	}

	[HandleProcessCorruptedStateExceptions]
	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
	{
		if (A_0)
		{
			try
			{
				W();
				return;
			}
			finally
			{
				base.Dispose(A_0: true);
			}
		}
		try
		{
			u();
		}
		finally
		{
			base.Dispose(A_0: false);
		}
	}

	protected InteractiveModelImpl_003CCognex_003A_003ATako_003A_003ALineSeg_003E()
	{
	}

	protected unsafe void BindDragCallbacksToEvents()
	{
		//IL_0033: Expected I8, but got I
		//IL_00b0: Expected I8, but got I
		DisposedCheck();
		delegate* unmanaged[Cdecl, Cdecl]<int, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<int, void>)Marshal.GetFunctionPointerForDelegate(f = n).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr = P(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj2);
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
		delegate* unmanaged[Cdecl, Cdecl]<int, void> obj3 = (delegate* unmanaged[Cdecl, Cdecl]<int, void>)Marshal.GetFunctionPointerForDelegate(S = B).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xD func2);
		*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9InteractiveModel_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E obj4);
		Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* ptr2 = P(&obj4);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AInteractiveModel_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0029_003E(ptr2, func2, &obj3);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), &obj4);
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

	private void n(int P_0)
	{
		raise_DragBeginEvent(this, new DragEventArgs(P_0));
	}

	private void B(int P_0)
	{
		raise_DragEndEvent(this, new DragEventArgs(P_0));
	}

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* P(Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AInteractiveModel_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AInteractiveModel_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}
}
