using System;
using System.Runtime.CompilerServices;

namespace Cognex.Cnx.ComponentModel.Implementation;

public struct CnxReferenceHandle<T> where T : class
{
	private T OFutffWAl;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(T obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj != OFutffWAl)
		{
			Attach(obj);
			if (obj is ICnxReferenceCount)
			{
				((ICnxReferenceCount)obj).AddReference();
			}
			else if (obj is IServiceProvider)
			{
				((ICnxReferenceCount)((IServiceProvider)obj).GetService(typeof(ICnxReferenceCount)))?.AddReference();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Get()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OFutffWAl;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Detach()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T oFutffWAl = OFutffWAl;
		OFutffWAl = null;
		return oFutffWAl;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Attach(T obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (OFutffWAl is ICnxReferenceCount)
		{
			((ICnxReferenceCount)OFutffWAl).Dispose();
		}
		else if (OFutffWAl is IServiceProvider)
		{
			((ICnxReferenceCount)((IServiceProvider)OFutffWAl).GetService(typeof(ICnxReferenceCount)))?.Dispose();
		}
		OFutffWAl = obj;
	}
}
