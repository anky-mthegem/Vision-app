using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using std;
using u;

namespace Cognex.Tako;

public class Engine : Scene, HasRenderChrono, IDisposable
{
	public unsafe delegate void MousePosChangedCallback(Bk* mpos);

	public unsafe delegate void SelectionChangedCallback(int* current, int* last);

	public unsafe delegate void CreateCallback(int* id, Bm mode);

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe delegate bool ViewerDragCallback(int A_0, BL A_1, array_003Cfloat_002C3_003E* A_2);

	public delegate void CursorChangeCallback(int A_0);

	private EventHandler<SelectionChangedEventArgs> P;

	private EventHandler<MousePosChangedEventArgs> b;

	private EventHandler<CreatorEventArgs> Z;

	private EventHandler<Scene.DragEventArgs> f;

	private EventHandler<DragEventArgs> S;

	protected readonly Dictionary<int, Node> nodes_ = new Dictionary<int, Node>();

	protected unsafe NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* pbuffer_ = null;

	protected MousePosChangedCallback mouse_pos_changed_cb_;

	protected SelectionChangedCallback selection_changed_cb_;

	protected CreateCallback create_cb_;

	protected ViewerDragCallback viewer_drag_cb_;

	protected CursorChangeCallback cursor_change_cb_;

	protected bool _is_disposed = false;

	protected RenderChrono chrono_;

	public unsafe virtual bool WireframeAsEdges
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCPA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCOI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual System.Drawing.Color GridColor
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out be func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCMA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return System.Drawing.Color.FromArgb(255, (int)((double)(*(float*)(&sf)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) * 255.0));
		}
		set
		{
			//IL_0064: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			*(float*)(&sf) = (float)((double)value.R / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bN func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCLI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E(ptr, func, &sf);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual GridUnits GridUnits
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZX func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCLA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			GridUnits result;
			try
			{
				result = (GridUnits)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003AGridUnits_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001d: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			Be be2 = (Be)value;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZR func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCKI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003AGridUnits_0020const_0020_0026_0029_002Cenum_0020cognex_003A_003Atako_003A_003AGridUnits_003E(ptr, func, &be2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual bool ShowGrid
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCKA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCJI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual float CreatorOpacity
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bO func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCHA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bL func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCGA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028float_0020const_0020_0026_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual System.Drawing.Color CreatorColor
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out be func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCGI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return System.Drawing.Color.FromArgb(255, (int)((double)(*(float*)(&sf)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) * 255.0));
		}
		set
		{
			//IL_0064: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			*(float*)(&sf) = (float)((double)value.R / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bN func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCFI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E(ptr, func, &sf);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public virtual RenderChrono Chrono
	{
		get
		{
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			return chrono_;
		}
	}

	public unsafe virtual int SelectionPixelTolerance
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bQ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual bool DisableLambertOnAllowedModels
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BFA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BEI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual bool AxesVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBLI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBLA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe bool DisplayGraphicInfo
	{
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBEI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual string ColorbarLabel
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zu func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCAI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			string result;
			try
			{
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
				result = StringHelper.from_UTF8(&obj2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
				return result;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
		}
		set
		{
			//IL_0024: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			StringHelper.to_UTF8(&obj, value);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Zx func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCAA_0040AA;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
				Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020_0026_003E(ptr, func, &obj);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj, true, 0uL);
				return;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
		}
	}

	public unsafe virtual System.Drawing.Color ColorbarTicksColor
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out be func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBPI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return System.Drawing.Color.FromArgb(255, (int)((double)(*(float*)(&sf)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) * 255.0));
		}
		set
		{
			//IL_0064: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			*(float*)(&sf) = (float)((double)value.R / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bN func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBPA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_003E(ptr, func, &sf);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int ColorbarDecimalPlaces
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bQ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBOI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBOA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int ColorbarSubdivisions
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bQ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBNI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBNA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual bool ColorbarVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBMI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zb func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBMA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028bool_0029_002Cbool_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual LightType LightType
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bA func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			LightType result;
			try
			{
				result = (LightType)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003ALightType_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001d: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			BO bO2 = (BO)value;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out by func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003ALightType_0029_002Cenum_0020cognex_003A_003Atako_003A_003ALightType_003E(ptr, func, &bO2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int SceneCuttingPlane
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bQ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BII_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BIA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual CameraControlModeType CameraControlMode
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bo func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BGI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			CameraControlModeType result;
			try
			{
				result = (CameraControlModeType)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003ACameraMode_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001d: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			B6 b10 = (B6)value;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bV func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BHA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003ACameraControlMode_0020const_0020_0026_0029_002Cenum_0020cognex_003A_003Atako_003A_003ACameraControlMode_003E(ptr, func, &b10);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual CameraModeType CameraMode
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bo func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BGI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			B9 b10;
			try
			{
				b10 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003ACameraMode_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return (b10 != 0) ? CameraModeType.Orthographic : CameraModeType.Perspective;
		}
		set
		{
			//IL_0029: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			B9 b10 = ((value != CameraModeType.Perspective) ? ((B9)1) : ((B9)0));
			B9 b11 = b10;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bT func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BGA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003ACameraMode_0020const_0020_0026_0029_002Cenum_0020cognex_003A_003Atako_003A_003ACameraMode_003E(ptr, func, &b11);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual System.Drawing.Color SelectionBoxColor
	{
		get
		{
			//IL_0008: Expected I8, but got I
			//IL_00f3: Expected I, but got I8
			//IL_00b9: Expected I, but got I8
			//IL_00c6: Expected I, but got I8
			//IL_0024: Expected I8, but got I
			long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr2);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out be func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBHA_0040AA;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
				Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
				System.Drawing.Color color = System.Drawing.Color.FromArgb(255, (int)((double)(*(float*)(&sf)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) * 255.0));
				System.Drawing.Color color2 = color;
				return color;
			}
			catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr2) != 0)
			{
				uint num2 = 0u;
				_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						Zv* ptr3 = ptr2;
						throw new ArgumentException(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr3 + 8)))((nint)ptr3)));
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num2 != 0;
					}).Invoke())
					{
					}
					if (num2 != 0)
					{
						throw;
					}
					System.Runtime.CompilerServices.Unsafe.SkipInit(out System.Drawing.Color result);
					return result;
				}
				finally
				{
					_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
				}
			}
		}
		set
		{
			//IL_0008: Expected I8, but got I
			//IL_00f6: Expected I, but got I8
			//IL_00bc: Expected I, but got I8
			//IL_00c9: Expected I, but got I8
			//IL_006c: Expected I8, but got I
			long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			*(float*)(&sf) = (float)((double)value.R / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr2);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out bN func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBGI_0040AA;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
				Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0026_003E(ptr, func, &sf);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
			}
			catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr2) != 0)
			{
				uint num2 = 0u;
				_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						Zv* ptr3 = ptr2;
						throw new ArgumentException(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr3 + 8)))((nint)ptr3)));
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num2 != 0;
					}).Invoke())
					{
					}
					if (num2 != 0)
					{
						throw;
					}
				}
				finally
				{
					_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
				}
			}
		}
	}

	public unsafe virtual Vector3D CameraUpDirection
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b0 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return new Vector3D(*(float*)(&obj2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
	}

	public unsafe virtual Point3D CameraPosition
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b0 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return new Point3D(*(float*)(&obj2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
	}

	public unsafe virtual Point3D CameraTarget
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b0 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return new Point3D(*(float*)(&obj2), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)), System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
	}

	public unsafe virtual System.Drawing.Color BackColor
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out be func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BOI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &sf, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return System.Drawing.Color.FromArgb(255, (int)((double)(*(float*)(&sf)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) * 255.0), (int)((double)System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) * 255.0));
		}
		set
		{
			//IL_0064: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Sf sf);
			*(float*)(&sf) = (float)((double)value.R / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 4)) = (float)((double)value.G / 255.0);
			System.Runtime.CompilerServices.Unsafe.As<Sf, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sf, 8)) = (float)((double)value.B / 255.0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bN func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BOA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AColor_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AColor_0020_0026_003E(ptr, func, &sf);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual DisplayMode Mode
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ba func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BNI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			DisplayMode result;
			try
			{
				result = (DisplayMode)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cenum_0020cognex_003A_003Atako_003A_003ADisplayMode_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			//IL_001d: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			Bd bd2 = (Bd)value;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bm func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BNA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003ADisplayMode_0029_002Cenum_0020cognex_003A_003Atako_003A_003ADisplayMode_003E(ptr, func, &bd2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int Selected
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bQ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBGA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			int result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBFA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual float HeightColorWeight
	{
		get
		{
			//IL_001b: Expected I8, but got I
			if (_is_disposed)
			{
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bO func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BDA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			float result;
			try
			{
				result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cfloat_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
				throw new ObjectDisposedException("Engine already disposed");
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bL func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028float_0020const_0020_0026_0029_002Cfloat_0020_0026_003E(ptr, func, &value);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
	public virtual event EventHandler<DragEventArgs> OnChangeCursor
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			S = (EventHandler<DragEventArgs>)Delegate.Combine(S, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			S = (EventHandler<DragEventArgs>)Delegate.Remove(S, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<Scene.DragEventArgs> OnDrag
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			f = (EventHandler<Scene.DragEventArgs>)Delegate.Combine(f, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			f = (EventHandler<Scene.DragEventArgs>)Delegate.Remove(f, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<CreatorEventArgs> OnCreated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			Z = (EventHandler<CreatorEventArgs>)Delegate.Combine(Z, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			Z = (EventHandler<CreatorEventArgs>)Delegate.Remove(Z, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<MousePosChangedEventArgs> MousePosChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			b = (EventHandler<MousePosChangedEventArgs>)Delegate.Combine(b, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			b = (EventHandler<MousePosChangedEventArgs>)Delegate.Remove(b, value);
		}
	}

	[SpecialName]
	public virtual event EventHandler<SelectionChangedEventArgs> SelectionChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			P = (EventHandler<SelectionChangedEventArgs>)Delegate.Combine(P, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			P = (EventHandler<SelectionChangedEventArgs>)Delegate.Remove(P, value);
		}
	}

	public static string GetVersion()
	{
		return "vc140-21_1";
	}

	public unsafe Engine(IntPtr dc)
	{
		//IL_0013: Expected I, but got I8
		//IL_0053: Expected I8, but got I
		n((bM*)dc.ToPointer());
		SetSelectionChangedCallback();
		SetMousePosChangedCallback();
		SetCreateCallback();
		SetViewerDragCallback();
		SetChangeCursorCallback();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bw func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9HasRenderChrono_0040tako_0040cognex_0040_0040_0024_0024F_0024B7AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			chrono_ = new RenderChrono(_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020cognex_003A_003Atako_003A_003ARenderChrono_0020_002A_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AHasRenderChrono_003A_003A_002A_0029_0028void_0029_003E(ptr, func));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
		//IL_003d: Expected I, but got I8
		//IL_002c: Expected I, but got I8
		chrono_?.ResetNative();
		NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr = pbuffer_;
		if (ptr != null)
		{
			ulong num = *(ulong*)((long)(nint)ptr + 8L + 8);
			if (num != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)num);
			}
			_003CModule_003E.delete(ptr, 24uL);
		}
		pbuffer_ = null;
	}

	[SpecialName]
	protected virtual void raise_SelectionChanged(object value0, SelectionChangedEventArgs value1)
	{
		P?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_MousePosChanged(object value0, MousePosChangedEventArgs value1)
	{
		b?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_OnCreated(object value0, CreatorEventArgs value1)
	{
		Z?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_OnDrag(object value0, Scene.DragEventArgs value1)
	{
		f?.Invoke(value0, value1);
	}

	[SpecialName]
	protected virtual void raise_OnChangeCursor(object value0, DragEventArgs value1)
	{
		S?.Invoke(value0, value1);
	}

	public unsafe void MouseMoveEvent(int x, int y, MouseModifiers mod)
	{
		//IL_0064: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out SB sB);
		*(long*)(&sB) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7EventBase_0040tako_0040cognex_0040_00406B_0040);
		try
		{
			*(long*)(&sB) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7MouseMotionEvent_0040tako_0040cognex_0040_00406B_0040);
			System.Runtime.CompilerServices.Unsafe.As<SB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<SB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<SB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 16)) = 0;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sj*, void>)(&_003CModule_003E.u_002ESj_002E_007Bdtor_007D), &sB);
			throw;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.As<SB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 8)) = x;
			System.Runtime.CompilerServices.Unsafe.As<SB, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 12)) = y;
			System.Runtime.CompilerServices.Unsafe.As<SB, MouseModifiers>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sB, 16)) = mod;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b4 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<b4, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AMouseMotionEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AMouseMotionEvent_0020_0026_003E(ptr, func, &sB);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<SB*, void>)(&_003CModule_003E.u_002ESB_002E_007Bdtor_007D), &sB);
			throw;
		}
	}

	public unsafe void MouseWheelEvent(int delta, double xpos, double ypos, MouseModifiers mod)
	{
		//IL_0075: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sn sn);
		*(long*)(&sn) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7EventBase_0040tako_0040cognex_0040_00406B_0040);
		try
		{
			*(long*)(&sn) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7MouseWheelEvent_0040tako_0040cognex_0040_00406B_0040);
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 20)) = 0;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sj*, void>)(&_003CModule_003E.u_002ESj_002E_007Bdtor_007D), &sn);
			throw;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 8)) = delta;
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 12)) = (int)xpos;
			System.Runtime.CompilerServices.Unsafe.As<Sn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 16)) = (int)ypos;
			System.Runtime.CompilerServices.Unsafe.As<Sn, MouseModifiers>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sn, 20)) = mod;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bp func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BCI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<bp, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AMouseWheelEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AMouseWheelEvent_0020_0026_003E(ptr, func, &sn);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sn*, void>)(&_003CModule_003E.u_002ESn_002E_007Bdtor_007D), &sn);
			throw;
		}
	}

	public unsafe void MouseUpEvent(MouseButton button, System.Windows.Point pos, MouseModifiers mod)
	{
		//IL_0066: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Su su);
		_003CModule_003E.u_002ESu_002E_007Bctor_007D(&su);
		try
		{
			if (button == MouseButton.Left)
			{
				System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 12)) = 0;
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 12)) = ((button == MouseButton.Middle) ? 1 : 2);
			}
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 8)) = 1;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 16)) = (int)pos.X;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 20)) = (int)pos.Y;
			System.Runtime.CompilerServices.Unsafe.As<Su, MouseModifiers>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 24)) = mod;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b3 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<b3, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020_0026_003E(ptr, func, &su);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Su*, void>)(&_003CModule_003E.u_002ESu_002E_007Bdtor_007D), &su);
			throw;
		}
	}

	public unsafe void MouseDownEvent(MouseButton button, System.Windows.Point pos, MouseModifiers mod)
	{
		//IL_0066: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Su su);
		_003CModule_003E.u_002ESu_002E_007Bctor_007D(&su);
		try
		{
			if (button == MouseButton.Left)
			{
				System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 12)) = 0;
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 12)) = ((button == MouseButton.Middle) ? 1 : 2);
			}
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 8)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 16)) = (int)pos.X;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 20)) = (int)pos.Y;
			System.Runtime.CompilerServices.Unsafe.As<Su, MouseModifiers>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 24)) = mod;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b3 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<b3, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020_0026_003E(ptr, func, &su);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Su*, void>)(&_003CModule_003E.u_002ESu_002E_007Bdtor_007D), &su);
			throw;
		}
	}

	public unsafe void ResizeEvent(int width, int height)
	{
		//IL_0049: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sb sb);
		*(long*)(&sb) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7EventBase_0040tako_0040cognex_0040_00406B_0040);
		try
		{
			*(long*)(&sb) = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7SizeChangedEvent_0040tako_0040cognex_0040_00406B_0040);
			System.Runtime.CompilerServices.Unsafe.As<Sb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sb, 8)) = width;
			System.Runtime.CompilerServices.Unsafe.As<Sb, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sb, 12)) = height;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sj*, void>)(&_003CModule_003E.u_002ESj_002E_007Bdtor_007D), &sb);
			throw;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bK func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<bK, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003ASizeChangedEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003ASizeChangedEvent_0020_0026_003E(ptr, func, &sb);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Sb*, void>)(&_003CModule_003E.u_002ESb_002E_007Bdtor_007D), &sb);
			throw;
		}
	}

	public void EscKeyEvent()
	{
		EscKeyEvent(0.0, 0.0);
	}

	public unsafe void EscKeyEvent(double x, double y)
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Su su);
		_003CModule_003E.u_002ESu_002E_007Bctor_007D(&su);
		try
		{
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 12)) = 3;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 8)) = 1;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 16)) = (int)x;
			System.Runtime.CompilerServices.Unsafe.As<Su, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref su, 20)) = (int)y;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b3 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
			System.Runtime.CompilerServices.Unsafe.As<b3, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 8;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003AMouseButtonEvent_0020_0026_003E(ptr, func, &su);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Su*, void>)(&_003CModule_003E.u_002ESu_002E_007Bdtor_007D), &su);
			throw;
		}
	}

	public unsafe virtual int AddNode(Node node)
	{
		//IL_0024: Expected I8, but got I
		//IL_009b: Expected I, but got I8
		if (node == null)
		{
			throw new ArgumentNullException();
		}
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bD func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BJA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* ptr = node.native_shared(&obj);
		int num;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj2);
			try
			{
				num = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020_003E(ptr2, func, ptr);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
		nodes_.Add(num, node);
		return num;
	}

	public unsafe virtual void SetInteractiveModel(int id, [MarshalAs(UnmanagedType.U1)] bool enable_interactive, int handles_to_enable)
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bH func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BKA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_002Cbool_002Cint_0029_002Cint_0020_0026_002Cbool_0020_0026_002Cint_0020_0026_003E(ptr, func, &id, &enable_interactive, &handles_to_enable);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public virtual void SetInteractiveModel(int id, [MarshalAs(UnmanagedType.U1)] bool enable_interactive)
	{
		SetInteractiveModel(id, enable_interactive, 7);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool GetInteractiveModel(int id)
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b8 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BKI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		bool result;
		try
		{
			result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020_0026_003E(ptr, func, &id);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual int GetEnabledHandlesForModel(int id)
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bC func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BLA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		int result;
		try
		{
			result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cint_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020_0026_003E(ptr, func, &id);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void DeleteNode(int id)
	{
		//IL_0008: Expected I8, but got I
		//IL_00ae: Expected I, but got I8
		//IL_0074: Expected I, but got I8
		//IL_0081: Expected I, but got I8
		//IL_0024: Expected I8, but got I
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out br func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BLI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029_002Cint_0020_0026_003E(ptr, func, &id);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr2) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr3 = ptr2;
					throw new ArgumentException(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr3 + 8)))((nint)ptr3)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
		if (!nodes_.Remove(id))
		{
			throw new ArgumentException("Id does not exist, no node deleted");
		}
	}

	public unsafe virtual int[] GetNodeIds()
	{
		//IL_001b: Expected I8, but got I
		//IL_0093: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZB func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BMA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Avector_003Cint_002Cclass_0020std_003A_003Aallocator_003Cint_003E_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		int[] array;
		try
		{
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
			long num = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) - *(long*)(&obj2) >> 2;
			array = new int[(int)num];
			ulong num2 = 0uL;
			if (0uL < (ulong)num)
			{
				do
				{
					int* ptr2 = (int*)(num2 * 4 + (ulong)(*(long*)(&obj2)));
					array[(uint)num2] = *ptr2;
					num2++;
				}
				while (num2 < (ulong)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) - *(long*)(&obj2) >> 2));
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Tidy(&obj2);
		return array;
	}

	public unsafe virtual void Clear()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bs func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BMI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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
		nodes_.Clear();
	}

	public unsafe void Render()
	{
		//IL_0008: Expected I8, but got I
		//IL_00e8: Expected I, but got I8
		//IL_00ae: Expected I, but got I8
		//IL_00bb: Expected I, but got I8
		//IL_0024: Expected I8, but got I
		//IL_0056: Expected I8, but got I
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr3);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out b1 func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BEA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEvents_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bl func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9PBuffer_0040tako_0040egl_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj2);
			Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr2 = pbuffer_native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003A_003A_002A_0029_0028void_0029_003E(ptr2, func2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D(&obj2);
			Chrono.Toc();
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 8, &ptr3) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr4 = ptr3;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr4 + 8)))((nint)ptr4)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool RenderIfUpdated()
	{
		//IL_0008: Expected I8, but got I
		//IL_00f1: Expected I, but got I8
		//IL_00b7: Expected I, but got I8
		//IL_00c4: Expected I, but got I8
		//IL_0024: Expected I8, but got I
		//IL_0057: Expected I8, but got I
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr3);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bq func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BEI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			bool flag;
			try
			{
				flag = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEvents_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bl func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9PBuffer_0040tako_0040egl_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj2);
			Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr2 = pbuffer_native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003A_003A_002A_0029_0028void_0029_003E(ptr2, func2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D(&obj2);
			if (flag)
			{
				Chrono.Toc();
			}
			return flag;
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 8, &ptr3) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr4 = ptr3;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr4 + 8)))((nint)ptr4)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
		return false;
	}

	public unsafe void RecreateSurface(int width, int height)
	{
		//IL_0008: Expected I8, but got I
		//IL_00b0: Expected I, but got I8
		//IL_0076: Expected I, but got I8
		//IL_0083: Expected I, but got I8
		//IL_0024: Expected I8, but got I
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bv func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9PBuffer_0040tako_0040egl_0040cognex_0040_0040_0024_0024F_0024BBA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj);
			Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr = pbuffer_native(&obj);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003A_003A_002A_0029_0028int_002Cint_0029_002Cint_0020_0026_002Cint_0020_0026_003E(ptr, func, &width, &height);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D(&obj);
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr2) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr3 = ptr2;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr3 + 8)))((nint)ptr3)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	public unsafe IntPtr QuerySurfacePointer()
	{
		//IL_0008: Expected I8, but got I
		//IL_00ba: Expected I, but got I8
		//IL_0080: Expected I, but got I8
		//IL_008d: Expected I, but got I8
		//IL_0024: Expected I8, but got I
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bJ func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9PBuffer_0040tako_0040egl_0040cognex_0040_0040_0024_0024F_0024BA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj);
			Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr = pbuffer_native(&obj);
			IntPtr intPtr;
			try
			{
				intPtr = (IntPtr)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Emethod_003Cvoid_0020_002A_0020_0028__cdecl_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
				IntPtr intPtr2 = intPtr;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D(&obj);
			return intPtr;
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr2) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr3 = ptr2;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr3 + 8)))((nint)ptr3)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr result);
				return result;
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	public unsafe virtual void FitView()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bs func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BPA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void ResetView(Vector3D dir, Vector3D up)
	{
		//IL_0065: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
		*(float*)(&obj) = (float)up.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)up.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)up.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
		*(float*)(&obj2) = (float)dir.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (float)dir.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) = (float)dir.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bY func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BPI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<bY, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj3);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj3);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(ptr, func, &obj2, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		try
		{
			GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8))));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
			throw;
		}
		_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
	}

	public unsafe virtual void ResetView(Vector3D dir)
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
		*(float*)(&obj) = (float)dir.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)dir.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)dir.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bd func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBAA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<bd, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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

	public unsafe virtual void ResetView()
	{
		//IL_0037: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
		*(float*)(&obj) = 0f;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = 0f;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = -1f;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bd func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBAA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<bd, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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

	public unsafe virtual void SetView(Point3D eye, Point3D target, Vector3D up)
	{
		//IL_008a: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj);
		*(float*)(&obj) = (float)eye.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (float)eye.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) = (float)eye.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj2);
		*(float*)(&obj2) = (float)target.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (float)target.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) = (float)target.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C3_003E obj3);
		*(float*)(&obj3) = (float)up.X;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 4)) = (float)up.Y;
		System.Runtime.CompilerServices.Unsafe.As<array_003Cfloat_002C3_003E, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) = (float)up.Z;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bh func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj4);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj4);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0026_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020_0026_003E(ptr, func, &obj, &obj2, &obj3);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj4);
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

	public unsafe virtual void SaveImage(string filename, int width, int height)
	{
		//IL_000d: Expected I8, but got I
		//IL_00ed: Expected I, but got I8
		//IL_00b2: Expected I, but got I8
		//IL_014d: Expected I, but got I8
		//IL_0113: Expected I, but got I8
		//IL_00c0: Expected I, but got I8
		//IL_0120: Expected I, but got I8
		//IL_0045: Expected I8, but got I
		B b10 = null;
		string text = null;
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out fg* ptr3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr5);
		try
		{
			B b11 = new B();
			try
			{
				b10 = b11;
				text = filename;
				char* ptr = global::u.B.internal_marshaler_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&text, b10.B);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out b6 func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBAI_0040AA;
				System.Runtime.CompilerServices.Unsafe.As<b6, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
				Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028wchar_t_0020const_0020_002A_002Cint_002Cint_0029_002Cwchar_t_0020const_0020_002A_0020_0026_002Cint_0020_0026_002Cint_0020_0026_003E(ptr2, func, &ptr, &width, &height);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
			}
			catch
			{
				//try-fault
				((IDisposable)b10).Dispose();
				throw;
			}
			((IDisposable)b10).Dispose();
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVinvalid_argument_0040std_0040_0040_00408), 8, &ptr3) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					fg* ptr4 = ptr3;
					throw new ArgumentException(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr4 + 8)))((nint)ptr4)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 8, &ptr5) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr6 = ptr5;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr6 + 8)))((nint)ptr6)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	public unsafe virtual void SaveImage(string filename)
	{
		//IL_000d: Expected I8, but got I
		//IL_00e5: Expected I, but got I8
		//IL_00ab: Expected I, but got I8
		//IL_00b8: Expected I, but got I8
		//IL_0045: Expected I8, but got I
		B b10 = null;
		string text = null;
		long num = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr3);
		try
		{
			B b11 = new B();
			try
			{
				b10 = b11;
				text = filename;
				char* ptr = global::u.B.internal_marshaler_003Cwchar_t_0020const_0020_002A_002CSystem_003A_003AString_0020_005E_002C1_003E.u(&text, b10.B);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out b9 func);
				*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBBA_0040AA;
				System.Runtime.CompilerServices.Unsafe.As<b9, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
				Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj);
				try
				{
					_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028wchar_t_0020const_0020_002A_0029_002Cwchar_t_0020const_0020_002A_0020_0026_003E(ptr2, func, &ptr);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D(&obj);
			}
			catch
			{
				//try-fault
				((IDisposable)b10).Dispose();
				throw;
			}
			((IDisposable)b10).Dispose();
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 8, &ptr3) != 0)
		{
			uint num2 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					Zv* ptr4 = ptr3;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr4 + 8)))((nint)ptr4)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	public virtual Node GetNode(int id)
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		if (nodes_.ContainsKey(id))
		{
			return nodes_[id];
		}
		throw new ArgumentException("No Node with the specified ID");
	}

	public unsafe virtual BitmapSource ReadPixels(int width, int height)
	{
		//IL_0008: Expected I8, but got I
		//IL_0089: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zn func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBKA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<Zn, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028int_002Cint_0029_002Cint_0020_0026_002Cint_0020_0026_003E(ptr, &obj2, func, &width, &height);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		BitmapSource result;
		try
		{
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
			result = BitmapSourceFromRGBAImage(&obj2);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
		return result;
	}

	public unsafe virtual BitmapSource ReadPixels()
	{
		//IL_0008: Expected I8, but got I
		//IL_0085: Expected I, but got I8
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZW func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBKI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<ZW, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref func, 8)) = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003AImage_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028void_0029_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		BitmapSource result;
		try
		{
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
			result = BitmapSourceFromRGBAImage(&obj2);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
		return result;
	}

	public unsafe virtual string GetRenderer()
	{
		//IL_001b: Expected I8, but got I
		//IL_0043: Expected I, but got I8
		//IL_003e->IL003e: Incompatible stack types: I vs I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zu func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBII_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		string result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Abasic_string_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
			try
			{
				result = new string((sbyte*)((16uL <= (ulong)(*(long*)((ulong)(nint)ptr2 + 24uL))) ? (*(ulong*)ptr2) : ((ulong)(nint)ptr2)));
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_Tidy(&obj2, true, 0uL);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E*, void>)(&_003CModule_003E.std_002E_String_alloc_003Cstd_003A_003A_String_base_types_003Cchar_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void SetHeightColor(DirectionalHeightColor height_color, float height_color_weight)
	{
		//IL_001b: Expected I8, but got I
		//IL_009b: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zf zf);
		*(long*)(&zf) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCA_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<Zf, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref zf, 8)) = 0;
		Zf func = zf;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = height_color.native_shared(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_0020const_0020_0026_002Cfloat_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002Cfloat_0020_0026_003E(ptr2, func, ptr, &height_color_weight);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
	}

	public unsafe virtual void SetHeightColor(DirectionalHeightColor height_color)
	{
		//IL_001b: Expected I8, but got I
		//IL_0099: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZZ zZ);
		*(long*)(&zZ) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.As<ZZ, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref zZ, 8)) = 0;
		ZZ func = zZ;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj);
		shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr = height_color.native_shared(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj2);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEngine_003A_003A_002A_0029_0028class_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_0020const_0020_0026_0029_002Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_0020_003E(ptr2, func, ptr);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)));
		}
	}

	public unsafe virtual void ClearHeightColor()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bs func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BDI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual DirectionalHeightColor GetHeightColor()
	{
		//IL_001b: Expected I8, but got I
		//IL_00bc: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZS func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		DirectionalHeightColor result;
		try
		{
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
			if ((byte)((*(long*)(&obj2) != 0) ? 1 : 0) != 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E obj3);
				created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E* ptr2 = &obj3;
				*(long*)(&obj3) = 0L;
				System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) = 0L;
				_003CModule_003E.std_002E_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_Reset_003Cclass_0020cognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E((_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)(&obj3), (_Ptr_base_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*)(&obj2));
				result = new DirectionalHeightColor(&obj3);
			}
			else
			{
				result = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
		{
			_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ADirectionalHeightColor_0020const_0020_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
		}
		return result;
	}

	public unsafe virtual TrackingTarget GetMouseTracking()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bG func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCDI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		TrackingTarget result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pe pe);
			result = new TrackingTarget((IntPtr)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020cognex_003A_003Atako_003A_003ATrackingTarget_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &pe, func));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void SetMouseTracking(TrackingTarget target)
	{
		//IL_001b: Expected I8, but got I
		//IL_0030: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bI func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCDA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003ATrackingTarget_003E* ptr = target.native(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj2);
			try
			{
				Pe* ptr3 = (Pe*)(*(ulong*)ptr);
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020cognex_003A_003Atako_003A_003ATrackingTarget_0020const_0020_0026_0029_002Cclass_0020cognex_003A_003Atako_003A_003ATrackingTarget_0020const_0020_0026_003E(ptr2, func, ptr3);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
	}

	public unsafe virtual Transform GetProjectionMatrix()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bt func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BFI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		Transform result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out array_003Cfloat_002C16_003E obj2);
			result = Transform.to_ManagedTransform(*_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Aarray_003Cfloat_002C16_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe void Next()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b1 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Events_0040tako_0040cognex_0040_0040_0024_0024F_0024BFA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AEvents_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual CameraSettings GetCameraSettings()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZU func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCBA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		CameraSettings result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out P3 p);
			result = new CameraSettings(_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &p, func));
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void SetCameraSettings(CameraSettings settings)
	{
		//IL_001b: Expected I8, but got I
		//IL_0030: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Z2 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E* ptr = settings.native(&obj);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj2);
			try
			{
				P3* ptr3 = (P3*)(*(ulong*)ptr);
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003ACameraSettings_0020const_0020_0026_0029_002Cstruct_0020cognex_003A_003Atako_003A_003ACameraSettings_0020const_0020_0026_003E(ptr2, func, ptr3);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003ACameraSettings_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void SetCreatorEnabled(CreatorMode mode)
	{
		//IL_001d: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		Bm bm2 = (Bm)mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZE func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCEA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028enum_0020cognex_003A_003Atako_003A_003ACreatorMode_0029_002Cenum_0020cognex_003A_003Atako_003A_003ACreatorMode_003E(ptr, func, &bm2);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public unsafe virtual void SetCreatorDisabled()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bs func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCEI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool GetCreatorIsEnabled()
	{
		//IL_001b: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZP func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCFA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		bool result;
		try
		{
			result = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cbool_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
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

	public static void Shutdown()
	{
		_003CModule_003E.cognex_002Etako_002EShutdown();
	}

	public unsafe Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* pbuffer_native(Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* P_0)
	{
		uint num = 0u;
		_003CModule_003E.Cognex_002ETako_002ENativeRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Elock((NativeRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)pbuffer_, P_0, this);
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
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	public unsafe Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* native(Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* P_0)
	{
		//IL_000a: Expected I8, but got I
		//IL_001c: Expected I8, but got I
		//IL_0035: Expected I8, but got I
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b7 func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9PBuffer_0040tako_0040egl_0040cognex_0040_0040_0024_0024F_0024BBI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj);
		Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr = pbuffer_native(&obj);
		try
		{
			try
			{
				*(long*)P_0 = (nint)_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002Emethod_003Cclass_0020cognex_003A_003Atako_003A_003AEngine_0020_002A_0020_0028__cdecl_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003A_003A_002A_0029_0028void_0029_003E(ptr, func);
				*(long*)((ulong)(nint)P_0 + 8uL) = (nint)((IntPtr)GCHandle.Alloc(this)).ToPointer();
				num = 1u;
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj);
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
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	protected unsafe static BitmapSource BitmapSourceFromRGBAImage(shared_ptr_003Ccognex_003A_003Atako_003A_003AImage_003E* img)
	{
		//IL_0018: Expected I, but got I8
		//IL_0018: Expected I, but got I8
		//IL_0026: Expected I, but got I8
		//IL_0026: Expected I, but got I8
		//IL_0057: Expected I, but got I8
		//IL_0057: Expected I, but got I8
		//IL_0065: Expected I, but got I8
		//IL_0065: Expected I, but got I8
		//IL_0083: Expected I, but got I8
		//IL_0083: Expected I, but got I8
		//IL_0091: Expected I, but got I8
		//IL_0091: Expected I, but got I8
		//IL_00a0: Expected I, but got I8
		//IL_00a0: Expected I, but got I8
		//IL_0123: Expected I, but got I8
		//IL_0123: Expected I, but got I8
		//IL_0131: Expected I, but got I8
		//IL_0131: Expected I, but got I8
		//IL_014c: Expected I, but got I8
		//IL_014c: Expected I, but got I8
		//IL_00b1: Expected I, but got I8
		//IL_00c4: Expected I8, but got I
		//IL_00fd: Expected I, but got I8
		PixelFormat bgra = PixelFormats.Bgra32;
		long num = *(long*)img;
		WriteableBitmap writeableBitmap = new WriteableBitmap(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num + 8)))((nint)num), ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num + 16)))((nint)num), 100.0, 100.0, bgra, null);
		long num2 = *(long*)img;
		long num3 = num2;
		byte[] array = new byte[((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num2 + 8)))((nint)num2) * ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num3 + 16)))((nint)num3) * 4];
		long num4 = *(long*)img;
		long num5 = num4;
		int num6 = ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num4 + 8)))((nint)num4) * ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num5 + 16)))((nint)num5);
		long num7 = *(long*)img;
		byte* ptr = (byte*)((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, void*>)(*(ulong*)(*(long*)num7 + 32)))((nint)num7);
		long num8 = num6;
		if (0 < num8)
		{
			byte* ptr2 = (byte*)((ulong)(nint)ptr + 1uL);
			int num9 = 2;
			byte* ptr3 = ptr2;
			long num10 = (long)(nint)(ptr - (nuint)ptr2) + 2L;
			long num11 = (nint)(ptr - (nuint)ptr2);
			long num12 = (long)(nint)(ptr - (nuint)ptr2) + 3L;
			ulong num13 = (ulong)num8;
			do
			{
				array[num9 - 2] = *(byte*)(num10 + (nint)ptr3);
				array[num9 - 1] = *ptr3;
				array[num9] = *(byte*)(num11 + (nint)ptr3);
				array[num9 + 1] = *(byte*)(num12 + (nint)ptr3);
				num9 += 4;
				ptr3 = (byte*)((ulong)(nint)ptr3 + 4uL);
				num13--;
			}
			while (num13 != 0);
		}
		long num14 = *(long*)img;
		long num15 = num14;
		Int32Rect sourceRect = new Int32Rect(0, 0, ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num15 + 8)))((nint)num15), ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num14 + 16)))((nint)num14));
		long num16 = *(long*)img;
		writeableBitmap.WritePixels(sourceRect, array, ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, int>)(*(ulong*)(*(long*)num16 + 8)))((nint)num16) * 4, 0);
		return writeableBitmap;
	}

	protected unsafe void SetSelectionChangedCallback()
	{
		//IL_0064: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<int*, int*, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<int*, int*, void>)Marshal.GetFunctionPointerForDelegate(selection_changed_cb_ = updateSelection).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E obj2);
		System.Runtime.CompilerServices.Unsafe.As<function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _2k obj3);
			_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_Reset_alloc_003Cvoid_0020_0028__cdecl_002A_0029_0028int_0020const_0020_0026_002Cint_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aallocator_003Cint_003E_0020_003E((_Func_class_003Cvoid_002Cint_002Cint_003E*)(&obj2), &obj, &obj3);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Func_class_003Cvoid_002Cint_002Cint_003E*, void>)(&_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bk func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCII_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj4);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj4);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E_0020_0026_003E(ptr, func, &obj2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj4);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<function_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E*, void>)(&_003CModule_003E.std_002Efunction_003Cvoid_0020__cdecl_0028int_002Cint_0029_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Cint_002Cint_003E_002E_Tidy((_Func_class_003Cvoid_002Cint_002Cint_003E*)(&obj2));
	}

	protected unsafe void updateSelection(int* current, int* last)
	{
		raise_SelectionChanged(this, new SelectionChangedEventArgs(*current, *last));
	}

	protected unsafe void SetCreateCallback()
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<int*, Bm, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<int*, Bm, void>)Marshal.GetFunctionPointerForDelegate(create_cb_ = notifyCreated).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zi func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCHI_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_002Cenum_0020cognex_003A_003Atako_003A_003ACreatorMode_0029_003E_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0020const_0020_0026_002Cenum_0020cognex_003A_003Atako_003A_003ACreatorMode_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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

	protected unsafe void notifyCreated(int* id, Bm mode)
	{
		B(id, (CreatorMode)mode);
		raise_OnCreated(this, new CreatorEventArgs(*id, (CreatorMode)mode));
	}

	protected unsafe void SetMousePosChangedCallback()
	{
		//IL_0064: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<Bk*, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<Bk*, void>)Marshal.GetFunctionPointerForDelegate(mouse_pos_changed_cb_ = updateMousePos).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out function_003Cvoid_0020__cdecl_0028cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E obj2);
		System.Runtime.CompilerServices.Unsafe.As<function_003Cvoid_0020__cdecl_0028cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 56)) = 0L;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _2k obj3);
			_003CModule_003E.std_002E_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E_002E_Reset_alloc_003Cvoid_0020_0028__cdecl_002A_0029_0028struct_0020cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_002Cclass_0020std_003A_003Aallocator_003Cint_003E_0020_003E((_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E*)(&obj2), &obj, &obj3);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E*, void>)(&_003CModule_003E.std_002E_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bz func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCIA_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj4);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj4);
			try
			{
				_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028struct_0020cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E_0029_002Cclass_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028struct_0020cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E_0020_0026_003E(ptr, func, &obj2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj4);
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
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<function_003Cvoid_0020__cdecl_0028cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E*, void>)(&_003CModule_003E.std_002Efunction_003Cvoid_0020__cdecl_0028cognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_0029_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002E_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E_002E_Tidy((_Func_class_003Cvoid_002Ccognex_003A_003Atako_003A_003AViewMousePos_0020const_0020_0026_003E*)(&obj2));
	}

	protected unsafe void updateMousePos(Bk* pos)
	{
		Bk bk2 = *pos;
		MousePos current = new MousePos(*(int*)(&bk2), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bk2, 4)), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bk2, 8)), System.Runtime.CompilerServices.Unsafe.As<Bk, float>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref bk2, 12)));
		raise_MousePosChanged(this, new MousePosChangedEventArgs(current));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool notifyEventDrag(int id, BL ev, array_003Cfloat_002C3_003E* p)
	{
		//IL_0019: Expected I, but got I8
		float[] array = new float[3];
		int num = 0;
		array_003Cfloat_002C3_003E* ptr = p;
		do
		{
			array[num] = *(float*)ptr;
			num++;
			ptr = (array_003Cfloat_002C3_003E*)((ulong)(nint)ptr + 4uL);
		}
		while (num < 3);
		Scene.DragEventArgs e = new Scene.DragEventArgs(id, (int)ev, array);
		raise_OnDrag(this, e);
		return e.Handled;
	}

	protected void riseCursorChange(int handleId)
	{
		raise_OnChangeCursor(this, new DragEventArgs(handleId));
	}

	protected unsafe void SetViewerDragCallback()
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<int, BL, array_003Cfloat_002C3_003E*, byte> obj = (delegate* unmanaged[Cdecl, Cdecl]<int, BL, array_003Cfloat_002C3_003E*, byte>)Marshal.GetFunctionPointerForDelegate(viewer_drag_cb_ = notifyEventDrag).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zc func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCJA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cbool_0020__cdecl_0028int_002Cenum_0020cognex_003A_003Atako_003A_003ADragEvent_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_003E_0029_002Cbool_0020_0028__cdecl_002A_0029_0028int_002Cenum_0020cognex_003A_003Atako_003A_003ADragEvent_002Cclass_0020std_003A_003Aarray_003Cfloat_002C3_003E_0020const_0020_0026_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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

	protected unsafe void SetChangeCursorCallback()
	{
		//IL_0040: Expected I8, but got I
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		delegate* unmanaged[Cdecl, Cdecl]<int, void> obj = (delegate* unmanaged[Cdecl, Cdecl]<int, void>)Marshal.GetFunctionPointerForDelegate(cursor_change_cb_ = riseCursorChange).ToPointer();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zj func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BCOA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj2);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cvoid_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028class_0020std_003A_003Afunction_003Cvoid_0020__cdecl_0028int_0029_003E_0020const_0020_0026_0029_002Cvoid_0020_0028__cdecl_002A_0029_0028int_0029_003E(ptr, func, &obj);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj2);
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

	protected void DisposedCheck()
	{
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
	}

	protected unsafe void CheckNodeKeys()
	{
		//IL_0008: Expected I8, but got I
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ZB func);
		*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BMA_0040AA;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
		Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj2);
		try
		{
			_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Avector_003Cint_002Cclass_0020std_003A_003Aallocator_003Cint_003E_0020_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028void_0029const_0020_003E(ptr, &obj2, func);
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
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
			if ((int)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) - *(long*)(&obj2) >> 2) != nodes_.Count)
			{
				throw new Error("There is a mismatch between the managed / unmanaged node list. Lenghts are different");
			}
			int num = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_const_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cint_003E_0020_003E_0020_003E obj3);
			_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Eend(&obj2, &obj3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_const_iterator_003Cstd_003A_003A_Vector_val_003Cstd_003A_003A_Simple_types_003Cint_003E_0020_003E_0020_003E obj4);
			_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Ebegin(&obj2, &obj4);
			while (*(long*)(&obj4) != *(long*)(&obj3))
			{
				int key = *(int*)(*(ulong*)(&obj4));
				num++;
				if (nodes_.ContainsKey(key))
				{
					*(long*)(&obj4) += 4L;
					continue;
				}
				throw new Error("There is a mismatch between the managed / unmanaged node list");
			}
			if (num != (int)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) - *(long*)(&obj2) >> 2))
			{
				throw new Error("There is a mismatch between the managed / unmanaged node list");
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Tidy(&obj2);
		try
		{
			return;
		}
		catch
		{
			//try-fault
			_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
	}

	private unsafe void n(bM* P_0)
	{
		//IL_000b: Expected I8, but got I
		//IL_00a6: Expected I, but got I8
		//IL_02b1: Expected I, but got I8
		//IL_024d: Expected I, but got I8
		//IL_026e: Expected I, but got I8
		//IL_00fe: Expected I, but got I8
		//IL_0276: Expected I, but got I8
		//IL_0283: Expected I, but got I8
		//IL_003a: Expected I, but got I8
		//IL_006f: Expected I, but got I8
		//IL_007a: Expected I, but got I8
		//IL_019f: Expected I, but got I8
		//IL_01d8: Expected I, but got I8
		//IL_0206: Expected I, but got I8
		//IL_020b: Expected I, but got I8
		//IL_0210: Expected I, but got I8
		//IL_0221: Expected I, but got I8
		//IL_0221: Expected I, but got I8
		uint num = 0u;
		long num2 = (nint)stackalloc byte[_003CModule_003E.__CxxQueryExceptionSize()];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Zv* ptr14);
		try
		{
			NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr = (NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)_003CModule_003E.@new(24uL);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E obj3);
			NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr8;
			try
			{
				if (ptr != null)
				{
					unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E* ptr2 = _003CModule_003E.u_002ESK_002Ecreate(&obj, P_0, 2, 2);
					unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E* ptr3 = ptr2;
					try
					{
						num = 1u;
						*(long*)(&obj2) = 0L;
						System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) = 0L;
						SK* px = (SK*)(*(ulong*)ptr2);
						*(long*)ptr2 = 0L;
						_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_Resetp_003Cclass_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstruct_0020std_003A_003Adefault_delete_003Cclass_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E(&obj2, px, *(default_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)ptr2);
						try
						{
							num = 3u;
							*(long*)(&obj3) = 0L;
							System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) = 0L;
							_003CModule_003E.std_002E_Ptr_base_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_Reset_003Cclass_0020cognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E((_Ptr_base_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)(&obj3), (_Ptr_base_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)(&obj2));
							created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr4 = &obj3;
							try
							{
								num = 7u;
								SK* ptr5 = (SK*)(*(ulong*)(&obj3));
								*(long*)ptr = *(long*)(&obj3);
								NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr6 = (NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)((ulong)(nint)ptr + 8uL);
								shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr7 = (shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)ptr6;
								*(long*)ptr7 = 0L;
								*(long*)((ulong)(nint)ptr7 + 8uL) = 0L;
								try
								{
									_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_003D((shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)ptr6, (shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*)(&obj3));
								}
								catch
								{
									//try-fault
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), (void*)((ulong)(nint)ptr + 8uL));
									throw;
								}
								ptr8 = ptr;
							}
							catch
							{
								//try-fault
								if ((num & 4) != 0)
								{
									num &= 0xFFFFFFFBu;
									_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj3);
								}
								throw;
							}
						}
						catch
						{
							//try-fault
							if ((num & 2) != 0)
							{
								num &= 0xFFFFFFFDu;
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj2);
							}
							throw;
						}
					}
					catch
					{
						//try-fault
						if ((num & 1) != 0)
						{
							num &= 0xFFFFFFFEu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E_002E_007Bdtor_007D), &obj);
						}
						throw;
					}
				}
				else
				{
					ptr8 = null;
				}
				try
				{
					try
					{
						try
						{
							NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr9 = ptr8;
						}
						catch
						{
							//try-fault
							if ((num & 4) != 0)
							{
								num &= 0xFFFFFFFBu;
								_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj3);
							}
							throw;
						}
					}
					catch
					{
						//try-fault
						if ((num & 2) != 0)
						{
							num &= 0xFFFFFFFDu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj2);
						}
						throw;
					}
				}
				catch
				{
					//try-fault
					if ((num & 1) != 0)
					{
						num &= 0xFFFFFFFEu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
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
				try
				{
					try
					{
						pbuffer_ = ptr8;
					}
					catch
					{
						//try-fault
						if ((num & 4) != 0)
						{
							num &= 0xFFFFFFFBu;
							_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002Ecreated_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj3);
						}
						throw;
					}
					if ((num & 4) != 0)
					{
						num &= 0xFFFFFFFBu;
						if (System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) != 0L)
						{
							_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<created_shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
						}
					}
				}
				catch
				{
					//try-fault
					if ((num & 2) != 0)
					{
						num &= 0xFFFFFFFDu;
						_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E_007Bdtor_007D), &obj2);
					}
					throw;
				}
				if ((num & 2) != 0)
				{
					num &= 0xFFFFFFFDu;
					if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
					}
				}
			}
			catch
			{
				//try-fault
				if ((num & 1) != 0)
				{
					num &= 0xFFFFFFFEu;
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<unique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E*, void>)(&_003CModule_003E.std_002Eunique_ptr_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_002Cstd_003A_003Adefault_delete_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_0020_003E_002E_007Bdtor_007D), &obj);
				}
				throw;
			}
			if ((num & 1) != 0)
			{
				num &= 0xFFFFFFFEu;
				if (*(long*)(&obj) != 0L)
				{
					SK* ptr10 = (SK*)(*(ulong*)(&obj));
					SK* ptr11 = (SK*)(*(ulong*)(&obj));
					SK* ptr12 = (SK*)(*(ulong*)(&obj));
					void* ptr13 = ((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, uint, void*>)(*(ulong*)(*(long*)(*(ulong*)(&obj)) + 8)))((nint)(*(long*)(&obj)), 1u);
				}
			}
		}
		catch when (_003CModule_003E.__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_R0_003FAVexception_0040std_0040_0040_00408), 9, &ptr14) != 0)
		{
			uint num3 = 0u;
			_003CModule_003E.__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num2);
			try
			{
				try
				{
					NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr15 = pbuffer_;
					NativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E* ptr16 = ptr15;
					if (ptr15 != null)
					{
						void* ptr17 = _003CModule_003E.Cognex_002ETako_002ENativeSharedRef_003Ccognex_003A_003Aegl_003A_003Atako_003A_003APBuffer_003E_002E__delDtor(ptr15, 1u);
					}
					else
					{
						void* ptr17 = null;
					}
					pbuffer_ = null;
					Zv* ptr18 = ptr14;
					throw new Error(_003CModule_003E.msclr_002Einterop_002Emarshal_as_003Cclass_0020System_003A_003AString_0020_005E_003E(((delegate* unmanaged[Cdecl, Cdecl]<IntPtr, sbyte*>)(*(ulong*)(*(long*)ptr18 + 8)))((nint)ptr18)));
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num3 = (uint)_003CModule_003E.__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num3 != 0;
				}).Invoke())
				{
				}
				if (num3 != 0)
				{
					throw;
				}
			}
			finally
			{
				_003CModule_003E.__CxxUnregisterExceptionObject((void*)num2, (int)num3);
			}
		}
	}

	private unsafe void B(int* P_0, CreatorMode P_1)
	{
		//IL_002a: Expected I8, but got I
		//IL_010d: Expected I8, but got I
		//IL_01f1: Expected I8, but got I
		//IL_02d5: Expected I8, but got I
		//IL_006e: Expected I, but got I8
		//IL_0151: Expected I, but got I8
		//IL_0235: Expected I, but got I8
		//IL_0314: Expected I, but got I8
		//IL_00fa: Expected I, but got I8
		//IL_01dd: Expected I, but got I8
		//IL_02c1: Expected I, but got I8
		//IL_039b: Expected I, but got I8
		if (_is_disposed)
		{
			throw new ObjectDisposedException("Engine already disposed");
		}
		if (*P_0 == -1)
		{
			return;
		}
		switch (P_1)
		{
		case CreatorMode.Box:
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bF func3);
			*(long*)(&func3) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BJI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj7);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr3 = native(&obj7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E obj9);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj8);
				shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* other3 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020const_0020_0026_003E(ptr3, &obj8, func3, P_0);
				try
				{
					_003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003ABox_002Cclass_0020cognex_003A_003Atako_003A_003ANode_003E(&obj9, other3);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj8);
					throw;
				}
				try
				{
					if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj8, 8)));
					}
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E_002E_007Bdtor_007D), &obj9);
					throw;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj7);
				throw;
			}
			try
			{
				try
				{
					GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 8))));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 8)));
					throw;
				}
				_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 8)));
				IntPtr ptrToShared3 = (IntPtr)(&obj9);
				nodes_[*P_0] = new Box(ptrToShared3);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E_002E_007Bdtor_007D), &obj9);
				throw;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ABox_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 8)));
			}
			break;
		}
		case CreatorMode.AnnularCylinder:
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bF func4);
			*(long*)(&func4) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BJI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj10);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr4 = native(&obj10);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E obj12);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj11);
				shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* other4 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020const_0020_0026_003E(ptr4, &obj11, func4, P_0);
				try
				{
					_003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003AAnnularCylinder_002Cclass_0020cognex_003A_003Atako_003A_003ANode_003E(&obj12, other4);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj11);
					throw;
				}
				try
				{
					if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj11, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj11, 8)));
					}
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E_002E_007Bdtor_007D), &obj12);
					throw;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj10);
				throw;
			}
			try
			{
				try
				{
					GC.KeepAlive(_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_002EPE_0024AAVObject_0040System_0040_0040((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj10, 8))));
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<gcroot_003CSystem_003A_003AObject_0020_005E_003E*, void>)(&_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj10, 8)));
					throw;
				}
				_003CModule_003E.gcroot_003CSystem_003A_003AObject_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AObject_0020_005E_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj10, 8)));
				IntPtr ptrToShared4 = (IntPtr)(&obj12);
				nodes_[*P_0] = new AnnularCylinder(ptrToShared4);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E_002E_007Bdtor_007D), &obj12);
				throw;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AAnnularCylinder_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj12, 8)));
			}
			break;
		}
		case CreatorMode.ExtrudedInSightRegion:
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bF func2);
			*(long*)(&func2) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BJI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj4);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr2 = native(&obj4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E obj6);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj5);
				shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* other2 = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020const_0020_0026_003E(ptr2, &obj5, func2, P_0);
				try
				{
					_003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003AExtrudedInSightRegion_002Cclass_0020cognex_003A_003Atako_003A_003ANode_003E(&obj6, other2);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj5);
					throw;
				}
				try
				{
					if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)));
					}
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj6);
					throw;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			try
			{
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
				IntPtr ptrToShared2 = (IntPtr)(&obj6);
				nodes_[*P_0] = new ExtrudedInSightRegion(ptrToShared2);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E_002E_007Bdtor_007D), &obj6);
				throw;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003AExtrudedInSightRegion_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 8)));
			}
			break;
		}
		case CreatorMode.Rectangle:
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bF func);
			*(long*)(&func) = (nint)_003CModule_003E.__unep_0040_003F_003F_9Scene_0040tako_0040cognex_0040_0040_0024_0024F_0024BJI_0040AA;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E obj);
			Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E* ptr = native(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E obj3);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E obj2);
				shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E* other = _003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002Emethod_003Cclass_0020std_003A_003Ashared_ptr_003Cclass_0020cognex_003A_003Atako_003A_003ANode_003E_0020_0028__cdecl_0020cognex_003A_003Atako_003A_003AScene_003A_003A_002A_0029_0028int_0029const_0020_002Cint_0020const_0020_0026_003E(ptr, &obj2, func, P_0);
				try
				{
					_003CModule_003E.std_002Edynamic_pointer_cast_003Cclass_0020cognex_003A_003Atako_003A_003ARectangle_002Cclass_0020cognex_003A_003Atako_003A_003ANode_003E(&obj3, other);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				try
				{
					if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)) != 0L)
					{
						_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ANode_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)));
					}
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Locker_003Ccognex_003A_003Atako_003A_003AEngine_003E*, void>)(&_003CModule_003E.Cognex_002ETako_002ELocker_003Ccognex_003A_003Atako_003A_003AEngine_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			try
			{
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
				IntPtr ptrToShared = (IntPtr)(&obj3);
				nodes_[*P_0] = new Rectangle(ptrToShared);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<shared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E*, void>)(&_003CModule_003E.std_002Eshared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			if (System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E, long>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)) != 0L)
			{
				_003CModule_003E.u_002Efi_002E_Decref((fi*)System.Runtime.CompilerServices.Unsafe.As<shared_ptr_003Ccognex_003A_003Atako_003A_003ARectangle_003E, ulong>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)));
			}
			break;
		}
		default:
			throw new ArgumentException("CreatorMode not valid");
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

	~Engine()
	{
		Dispose(A_0: false);
	}
}
