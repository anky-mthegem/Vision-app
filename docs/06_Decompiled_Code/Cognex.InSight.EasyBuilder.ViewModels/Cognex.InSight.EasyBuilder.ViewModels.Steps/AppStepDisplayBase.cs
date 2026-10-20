using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps;

public abstract class AppStepDisplayBase
{
	protected CvsInSightDisplay Display;

	[CompilerGenerated]
	private EventHandler Di9UOR6rju;

	public event EventHandler DisplayChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					eventHandler = Interlocked.CompareExchange(ref Di9UOR6rju, value2, eventHandler2);
					num = 6;
					break;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 2:
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 0;
				default:
					num = 0;
					break;
				case 1:
				case 4:
					eventHandler2 = eventHandler;
					goto case 2;
				case 3:
					eventHandler = Di9UOR6rju;
					VmTUb2e8n8RXqGedB6F();
					if (!LF5Qadek1USgoJheQku())
					{
						num = 5;
						break;
					}
					num = 4;
					if (VmTUb2e8n8RXqGedB6F())
					{
						return;
					}
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 5;
				default:
					eventHandler = Interlocked.CompareExchange(ref Di9UOR6rju, value2, eventHandler2);
					num = 1;
					break;
				case 5:
					eventHandler2 = eventHandler;
					_ = 0;
					if (LF5Qadek1USgoJheQku())
					{
						num = 4;
						if (LF5Qadek1USgoJheQku())
						{
							break;
						}
						goto case 2;
					}
					num = 6;
					break;
				case 2:
				case 4:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto default;
				case 0:
					eventHandler = Di9UOR6rju;
					num = 5;
					if (VmTUb2e8n8RXqGedB6F())
					{
					}
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AppStepDisplayBase(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				sbU5n6eqv7vJ5hNEddO(this);
				break;
			case 0:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 0;
				num = (LF5Qadek1USgoJheQku() ? 4 : 3);
				continue;
			case 5:
				return;
			}
			Display = display;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetDisplay(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (VmTUb2e8n8RXqGedB6F() ? 6 : 7);
		while (true)
		{
			switch (num)
			{
			case 4:
				Display.ShowSplitter = false;
				goto case 3;
			default:
				num = 3;
				break;
			case 2:
				Display.ShowGrid = false;
				num = 4;
				break;
			case 5:
				return;
			case 0:
			case 7:
				Display = display;
				goto case 1;
			case 1:
			case 6:
				GdTaTWeETtxJIKXsfXM(Display, true);
				num = 2;
				break;
			case 3:
			{
				EventHandler eventHandler = Di9UOR6rju;
				if (eventHandler != null)
				{
					QsN1OqepVEhqhnDNrxD(eventHandler, this, EventArgs.Empty);
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 5;
				break;
			}
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual List<CvsEditableDisplayGraphic> GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new List<CvsEditableDisplayGraphic>();
	}

	public abstract void SetDisplayToNormalState();

	public abstract void SetDisplayToStepMode();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LF5Qadek1USgoJheQku()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VmTUb2e8n8RXqGedB6F()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sbU5n6eqv7vJ5hNEddO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GdTaTWeETtxJIKXsfXM(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).IsEasyBuilder = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QsN1OqepVEhqhnDNrxD(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}
}
