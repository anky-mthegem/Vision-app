using System;
using JK709E3DnFfvLewQUh;
using NXRr4J0uHSUowNMpIG;

namespace Cognex.Explorer.XProc;

public class XProcEventHandler<T> : MarshalByRefObject, IDisposable
{
	private Action<T> evNQZwX2g;

	internal static object XnR5ZC2Ztfy5fuYKbZ;

	public XProcEventHandler(Action<T> callback)
	{
		P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
		base._002Ector();
		if (callback == null)
		{
			throw new ArgumentNullException(Ey4DP8Q8YupTAlWZrx.ra7GaQ663(258));
		}
		evNQZwX2g = callback;
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}

	public void Callback(T value)
	{
		evNQZwX2g(value);
	}

	public void Dispose()
	{
		evNQZwX2g = null;
	}

	internal static bool hIN2BTnDisChEI7uOQ()
	{
		return XnR5ZC2Ztfy5fuYKbZ == null;
	}

	internal static object vCelIgiIXCH2Xl4ICK()
	{
		return XnR5ZC2Ztfy5fuYKbZ;
	}
}
public class XProcEventHandler<T1, T2> : MarshalByRefObject, IDisposable
{
	private Action<T1, T2> amP0fuQDK;

	internal static object D31AMr7NQwv08Us6VV;

	public XProcEventHandler(Action<T1, T2> callback)
	{
		P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
		base._002Ector();
		if (callback == null)
		{
			throw new ArgumentNullException(Ey4DP8Q8YupTAlWZrx.ra7GaQ663(258));
		}
		amP0fuQDK = callback;
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}

	public void Callback(T1 t1, T2 t2)
	{
		amP0fuQDK(t1, t2);
	}

	public void Dispose()
	{
		amP0fuQDK = null;
	}

	internal static bool SSPCypYtsHoZnTgG4U()
	{
		return D31AMr7NQwv08Us6VV == null;
	}

	internal static object EPdYm3KbCb5RyuivJw()
	{
		return D31AMr7NQwv08Us6VV;
	}
}
public class XProcEventHandler : MarshalByRefObject, IDisposable
{
	private Action Bf4qE5xYA;

	private static XProcEventHandler LKnU1DkoqjJ2WZCrxM;

	public XProcEventHandler(Action callback)
	{
		P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
		base._002Ector();
		int num = 1;
		if (0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Bf4qE5xYA = callback;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				if (callback == null)
				{
					throw new ArgumentNullException(Ey4DP8Q8YupTAlWZrx.ra7GaQ663(258));
				}
				num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override object InitializeLifetimeService()
	{
		return null;
	}

	public void Callback()
	{
		GMJ6MfWALQownWn7As(Bf4qE5xYA);
	}

	public void Dispose()
	{
		Bf4qE5xYA = null;
	}

	internal static bool N2gQvHfBNumnBEbJE9()
	{
		return LKnU1DkoqjJ2WZCrxM == null;
	}

	internal static XProcEventHandler sQwqMGQ3SWmpj3Lvhn()
	{
		return LKnU1DkoqjJ2WZCrxM;
	}

	internal static void GMJ6MfWALQownWn7As(object P_0)
	{
		P_0();
	}
}
