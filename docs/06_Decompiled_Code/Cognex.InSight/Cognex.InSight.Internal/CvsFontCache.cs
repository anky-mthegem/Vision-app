using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

internal class CvsFontCache
{
	private class JdnqOU0YSI4Kwdalao
	{
		public CvsFont XV3mGlUkUJ;

		public TimeSpan eHOmDx4EOL;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JdnqOU0YSI4Kwdalao()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rfDWWhsMTlrckeqDlPKp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wuAlVOsMdBgaRZZeP2MH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly Func<Font, CvsFont> TOkWEGO72x;

	private readonly TimeSpan IrnWQa24Gy;

	private readonly int wtHWNgLeQj;

	private readonly LinkedList<JdnqOU0YSI4Kwdalao> quSWiP9c0s;

	private readonly Dictionary<Font, LinkedListNode<JdnqOU0YSI4Kwdalao>> VngWd0yADe;

	private readonly Stopwatch N5YWuP55MD;

	private int c07WG1NEHs;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFontCache(Func<Font, CvsFont> creator)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector(creator, TimeSpan.FromSeconds(30.0), 1024);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFontCache(Func<Font, CvsFont> creator, TimeSpan cleanupTimeForUnusedFonts, int maxNumInstances)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		N5YWuP55MD = Stopwatch.StartNew();
		base._002Ector();
		TOkWEGO72x = creator;
		IrnWQa24Gy = cleanupTimeForUnusedFonts;
		wtHWNgLeQj = maxNumInstances;
		quSWiP9c0s = new LinkedList<JdnqOU0YSI4Kwdalao>();
		VngWd0yADe = new Dictionary<Font, LinkedListNode<JdnqOU0YSI4Kwdalao>>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFont GetOrCreate(Font font, bool canDisposeFontIfUnused)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		LinkedListNode<JdnqOU0YSI4Kwdalao> linkedListNode = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				linkedListNode = JZ8WHi54pj(font);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 8:
				A6JWK0JZvF();
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto default;
			default:
				rmifa0nDWsYiMa3MD0l(font);
				num = 2;
				if (LiHajlnH1E5duq9b0Jr())
				{
					break;
				}
				goto case 2;
			case 6:
				linkedListNode.Value.eHOmDx4EOL = N5YWuP55MD.Elapsed;
				_ = 0;
				num = (LiHajlnH1E5duq9b0Jr() ? 1 : 0);
				break;
			case 4:
				if (!canDisposeFontIfUnused)
				{
					c07WG1NEHs++;
					num = 8;
					break;
				}
				goto default;
			case 9:
				quSWiP9c0s.AddLast(linkedListNode);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				if (font != FpNawanA8Oj6Yayx7T4(linkedListNode.Value.XV3mGlUkUJ))
				{
					num = 4;
					break;
				}
				goto case 2;
			case 10:
				return linkedListNode.Value.XV3mGlUkUJ;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private LinkedListNode<JdnqOU0YSI4Kwdalao> JZ8WHi54pj(Font P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (VngWd0yADe.TryGetValue(P_0, out var value))
		{
			quSWiP9c0s.Remove(value);
		}
		else
		{
			value = new LinkedListNode<JdnqOU0YSI4Kwdalao>(new JdnqOU0YSI4Kwdalao
			{
				XV3mGlUkUJ = TOkWEGO72x(P_0)
			});
			VngWd0yADe.Add(P_0, value);
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A6JWK0JZvF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		LinkedListNode<JdnqOU0YSI4Kwdalao> linkedListNode = default;
		TimeSpan timeSpan = default;
		while (true)
		{
			LinkedListNode<JdnqOU0YSI4Kwdalao> next;
			CvsFont xV3mGlUkUJ;
			switch (num)
			{
			case 9:
				if (quSWiP9c0s.Count <= wtHWNgLeQj)
				{
					num = 2;
					break;
				}
				goto IL_00f1;
			case 10:
				linkedListNode = quSWiP9c0s.First;
				num = 3;
				break;
			case 3:
			case 4:
			case 6:
				if (linkedListNode != null)
				{
					goto case 9;
				}
				goto case 7;
			default:
				num = 9;
				break;
			case 0:
				timeSpan = iL6UEknTerVHCIT3DEC(rsG5U8nUY8LOjAjnBfa(N5YWuP55MD), IrnWQa24Gy);
				num = 10;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				c07WG1NEHs++;
				_ = 0;
				num = ((!LiHajlnH1E5duq9b0Jr()) ? 1 : 6);
				break;
			case 2:
				if (!uxiQppnd2fbmgnZXgX7(linkedListNode.Value.eHOmDx4EOL, timeSpan))
				{
					num = 7;
					break;
				}
				goto IL_00f1;
			case 7:
				if (c07WG1NEHs >= 1024)
				{
					GC.Collect();
					goto case 1;
				}
				return;
			case 1:
			case 8:
				c07WG1NEHs = 0;
				num = 11;
				if (1 == 0)
				{
					return;
				}
				break;
			case 11:
				return;
				IL_00f1:
				next = linkedListNode.Next;
				xV3mGlUkUJ = linkedListNode.Value.XV3mGlUkUJ;
				quSWiP9c0s.Remove(linkedListNode);
				VngWd0yADe.Remove((Font)FpNawanA8Oj6Yayx7T4(xV3mGlUkUJ));
				linkedListNode = next;
				num = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FpNawanA8Oj6Yayx7T4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFont)P_0).TextFont;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rmifa0nDWsYiMa3MD0l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Font)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LiHajlnH1E5duq9b0Jr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FlhjHtnV4cm08hb9Zhl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan rsG5U8nUY8LOjAjnBfa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stopwatch)P_0).Elapsed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan iL6UEknTerVHCIT3DEC(TimeSpan P_0, TimeSpan P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 - P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uxiQppnd2fbmgnZXgX7(TimeSpan P_0, TimeSpan P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 < P_1;
	}
}
