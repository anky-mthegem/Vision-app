using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using std;
using u;

namespace Cognex.Tako;

public class ExtrudedInSightRegion : InteractiveModelImpl_003CCognex_003A_003ATako_003A_003AModelBaseWithTextureDefaultCoords_003E
{
	public delegate void SizeChangedCallback();

	private EventHandler B;

	protected SizeChangedCallback _size_changed_cb;

	public unsafe float Curve
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xB func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ModelBase_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028float_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe float Depth
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xB func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Cylinder_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028float_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe float Width
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xB func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ZHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028float_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe float Height
	{
		get
		{
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xB func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ZHeightColor_0040tako_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
			//IL_000e: Expected I8, but got I
			DisposedCheck();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out xP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<xP, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028float_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
	public event EventHandler SizeChanged
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

	public unsafe ExtrudedInSightRegion(float height, float width, float depth, float curve)
	{
		//IL_005b: Expected I, but got I8
		//IL_007d: Expected I, but got I8
		//IL_0032: Expected I, but got I8
		//IL_00c6: Expected I, but got I8
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
					created_shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002EnativeNodeCreate_003Cclass_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cfloat_0020_0026_002Cfloat_0020_0026_003E(&obj, &height, &width, &depth, &curve);
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
			SetSizeChangedCallback();
			BindDragCallbacksToEvents();
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(A_0: true);
			throw;
		}
	}

	public unsafe ExtrudedInSightRegion(IntPtr ptrToShared)
	{
		//IL_0025: Expected I, but got I8
		try
		{
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_003CModule_003E.@new(24uL);
			NativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bctor_007D_003Cclass_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E(ptr, (shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*)ptrToShared.ToPointer()));
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

	[SpecialName]
	protected void raise_SizeChanged(object value0, EventArgs value1)
	{
		B?.Invoke(value0, value1);
	}

	private unsafe void u()
	{
		//IL_0013: Expected I8, but got I
		if (_native == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xb func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out SH sH);
		System.Runtime.CompilerServices.Unsafe.As<SH, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sH, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0020_003E(ptr, func, &sH);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj);
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
	}

	private void W()
	{
		if (!_is_disposed)
		{
			u();
		}
	}

	protected void RiseSizeChangedEvent()
	{
		EventArgs empty = EventArgs.Empty;
		B?.Invoke(this, empty);
	}

	protected unsafe void SetSizeChangedCallback()
	{
		//IL_0033: Expected I8, but got I
		DisposedCheck();
		delegate* unmanaged[Cdecl, Cdecl]<void> obj = (delegate* unmanaged[Cdecl, Cdecl]<void>)Marshal.GetFunctionPointerForDelegate(_size_changed_cb = RiseSizeChangedEvent).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out xb func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9ExtrudedInSightRegion_0040tako_0040cognex_0040_0040_0024_0024F_0024BEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<xb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.As<xb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 12)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* ptr = n(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028void_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028void_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj2);
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

	private unsafe Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* n(Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E_002Elock_003Cclass_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E((NativeRef_003Ccognex_003A_003Atako_003A_003ANode_003E*)_native, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), P_0);
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
}
