using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Controls;

public abstract class CheckBoxTreeItemViewModel : CheckBoxTreeViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public CheckBoxTreeItemViewModel _003C_003E4__this;

		public string filterText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass28_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			K4u9Ro5Zwhag2fD2jvCO(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAreAnyChildNodesInFilter_003Eb__0(CheckBoxTreeItemViewModel child)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!_003C_003E4__this.fys1SpaZLV(filterText, child))
			{
				return _003C_003E4__this.AreAnyChildNodesInFilter(filterText, child);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K4u9Ro5Zwhag2fD2jvCO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LUJf6w5ZKrZ3ebta52Jg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cSEJP65Z514MAhOLKadG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EventHandler Yu613UDhAj;

	public abstract bool? IsChecked { get; set; }

	public abstract string Name { get; }

	public virtual bool? PassFailValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	public bool HasPassFailValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PassFailValue.HasValue;
		}
	}

	public virtual string ImageSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	public bool HasImageSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !SjDZkCKwqWJy0vnYnE9f(yu9IdPKw8xE2CLIKQmQw(this));
		}
	}

	public virtual string Information
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	public string CheckedChildCountText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XxinnLKwSTMssAQTteDF();
			int num;
			if (!tTyNuGKwkTaYRYtxa6dD())
			{
				num = 3;
				if (tTyNuGKwkTaYRYtxa6dD())
				{
				}
			}
			else
			{
				num = 4;
			}
			string text = default;
			while (true)
			{
				IL_0050:
				switch (num)
				{
				case 5:
					if (ChildNodesCheckedCount != 1)
					{
						break;
					}
					goto case 2;
				default:
					num = 2;
					continue;
				case 2:
					text = (string)ywuscgKw9y9hclbQ2O9j();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 4:
					return null;
				case 0:
				case 3:
					while (HasChildNodesChecked)
					{
						text = (string)cjp54SKwX65PPr4REafq();
						num = 5;
						if (true)
						{
							goto IL_0050;
						}
					}
					goto case 1;
				case 6:
					break;
				}
				break;
			}
			return (string)L6SDRZKw4QIIIuRZpadZ(text, ChildNodesCheckedCount);
		}
	}

	public bool HasChildNodesChecked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ChildNodesCheckedCount > 0;
		}
	}

	public int ChildNodesCheckedCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TreeNodes?.Sum([MethodImpl(MethodImplOptions.NoInlining)] (CheckBoxTreeItemViewModel P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				tTyNuGKwkTaYRYtxa6dD();
				int num;
				if (XxinnLKwSTMssAQTteDF())
				{
					num = 4;
					if (1 == 0)
					{
						goto IL_002a;
					}
				}
				else
				{
					num = 3;
				}
				goto IL_007c;
				IL_0068:
				bool flag = true;
				goto IL_0041;
				IL_007c:
				bool flag2 = default;
				while (true)
				{
					switch (num)
					{
					case 0:
					case 4:
						break;
					case 2:
						goto IL_0041;
					case 1:
					case 3:
						goto IL_0068;
					default:
						num = 2;
						continue;
					case 5:
						return qdEYKoKwWfGselubCM5V(P_0) + (flag2 ? 1 : 0);
					}
					break;
				}
				goto IL_002a;
				IL_002a:
				bool? isChecked = P_0.IsChecked;
				goto IL_0068;
				IL_0041:
				flag2 = isChecked == flag;
				num = 5;
				if (tTyNuGKwkTaYRYtxa6dD())
				{
				}
				goto IL_007c;
			}) ?? 0;
		}
	}

	public event EventHandler IsCheckedChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					eventHandler2 = Interlocked.CompareExchange(ref Yu613UDhAj, value2, eventHandler);
					goto case 4;
				case 5:
					eventHandler2 = Yu613UDhAj;
					num = 1;
					continue;
				case 4:
				case 6:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 0:
				case 2:
					value2 = (EventHandler)PcZou1Kw7gI9GonHACLV(eventHandler, value);
					goto case 3;
				default:
					num = 3;
					if (!tTyNuGKwkTaYRYtxa6dD())
					{
						continue;
					}
					break;
				case 1:
					break;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
				_ = 1;
				num = (tTyNuGKwkTaYRYtxa6dD() ? 6 : 0);
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
			_ = 1;
			int num = (tTyNuGKwkTaYRYtxa6dD() ? 2 : 6);
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					eventHandler = Interlocked.CompareExchange(ref Yu613UDhAj, value2, eventHandler2);
					num = 1;
					continue;
				case 4:
					value2 = (EventHandler)YNXRaCKw3n9488BfXCB1(eventHandler2, value);
					goto default;
				case 1:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 5;
				case 5:
					eventHandler2 = eventHandler;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 0:
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler = Yu613UDhAj;
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshNodeInformation()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!tTyNuGKwkTaYRYtxa6dD())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(1188));
				num = 9;
				break;
			case 1:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47634));
				_ = 1;
				if (!tTyNuGKwkTaYRYtxa6dD())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 8;
				}
				num = 0;
				break;
			case 8:
				nSglriKwpTVL7ZM5fKIi(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(47778));
				goto case 0;
			case 4:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47726));
				goto case 7;
			default:
				num = 7;
				break;
			case 5:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47588));
				num = 1;
				break;
			case 7:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47752));
				num = 8;
				break;
			case 2:
			case 3:
				nSglriKwpTVL7ZM5fKIi(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(47682));
				num = 4;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireIsCheckedChangedEvent()
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
			case 0:
				FirePropertyChangedExplicit((string)WqM0nVKwEF6cr6FpCJoM(47778));
				num = 4;
				break;
			case 1:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47588));
				goto case 7;
			default:
				num = 7;
				break;
			case 7:
			{
				EventHandler eventHandler = Yu613UDhAj;
				if (eventHandler == null)
				{
					return;
				}
				r58IuJKwj88NvBof9kAy(eventHandler, this, EventArgs.Empty);
				num = 8;
				if (false)
				{
					return;
				}
				break;
			}
			case 5:
				return;
			case 2:
			case 3:
				nSglriKwpTVL7ZM5fKIi(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(47682));
				num = 1;
				break;
			case 4:
				nSglriKwpTVL7ZM5fKIi(this, WqM0nVKwEF6cr6FpCJoM(47634));
				_ = 0;
				if (!XxinnLKwSTMssAQTteDF())
				{
					num = 6;
					break;
				}
				num = 3;
				if (tTyNuGKwkTaYRYtxa6dD())
				{
					return;
				}
				break;
			case 6:
				return;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void OyD1oiWYro(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		List<CheckBoxTreeItemViewModel> list = default;
		IEnumerator<CheckBoxTreeItemViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				VisibleTreeNodes.AddRange(list);
				num = 7;
				break;
			case 0:
			case 1:
				return;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						CheckBoxTreeItemViewModel current = enumerator.Current;
						tTyNuGKwkTaYRYtxa6dD();
						int num2;
						if (XxinnLKwSTMssAQTteDF())
						{
							num2 = 1;
							if (false)
							{
								goto IL_006d;
							}
						}
						else
						{
							num2 = 3;
						}
						goto IL_0086;
						IL_0086:
						while (true)
						{
							switch (num2)
							{
							case 4:
								break;
							case 0:
							case 1:
								if (fys1SpaZLV(P_0, current))
								{
									num2 = 4;
									continue;
								}
								goto IL_00db;
							default:
								goto IL_00ca;
							case 5:
								goto IL_00db;
							}
							break;
						}
						goto IL_006d;
						IL_006d:
						list.Add(current);
						goto IL_00ca;
						IL_00ca:
						sUeQgCKw6sYvvB32tLEh(current, P_0);
						num2 = 5;
						goto IL_0086;
						IL_00db:;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						GSABjqKwCwGcV1Nv31xA(enumerator);
					}
				}
				xQcUR1KwAWXf1NXs5Aif(VisibleTreeNodes);
				num = 4;
				break;
			case 2:
			case 5:
				enumerator = TreeNodes.GetEnumerator();
				goto case 3;
			default:
				num = 3;
				if (!tTyNuGKwkTaYRYtxa6dD())
				{
					break;
				}
				goto case 6;
			case 6:
				if (VisibleTreeNodes != null)
				{
					list = new List<CheckBoxTreeItemViewModel>();
					goto case 2;
				}
				_ = 1;
				num = (tTyNuGKwkTaYRYtxa6dD() ? 5 : 0);
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool fys1SpaZLV(string P_0, CheckBoxTreeItemViewModel P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		object obj;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				return true;
			default:
				obj = null;
				goto IL_006b;
			case 0:
				if (!string.IsNullOrEmpty(P_0))
				{
					if (P_1 == null)
					{
						goto default;
					}
					obj = P_1.Name;
					goto IL_006b;
				}
				_ = 0;
				num = (XxinnLKwSTMssAQTteDF() ? 3 : 4);
				continue;
			case 5:
				{
					obj = "";
					break;
				}
				IL_006b:
				if (obj != null)
				{
					break;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			}
			break;
		}
		bool flag = ((string)obj).IndexOf(P_0, StringComparison.CurrentCultureIgnoreCase) >= 0;
		bool flag2 = AreAnyChildNodesInFilter(P_0, P_1);
		return flag | flag2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool AreAnyChildNodesInFilter(string filterText, CheckBoxTreeItemViewModel node)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tTyNuGKwkTaYRYtxa6dD();
		int num = ((!XxinnLKwSTMssAQTteDF()) ? 5 : 2);
		object obj;
		_003C_003Ec__DisplayClass28_0 obj2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (node == null)
				{
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				obj = node.TreeNodes;
				break;
			case 1:
			case 5:
				obj2._003C_003E4__this = this;
				num = 3;
				continue;
			case 3:
				obj2.filterText = filterText;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				obj2 = new _003C_003Ec__DisplayClass28_0();
				goto case 1;
			case 6:
				obj = null;
				break;
			}
			break;
		}
		if (obj == null)
		{
			return false;
		}
		return node.TreeNodes.Any(obj2._003CAreAnyChildNodesInFilter_003Eb__0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CheckBoxTreeItemViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TTtZIxKwR9aN4uMWOWUm();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static int rgB1DqTwtt(CheckBoxTreeItemViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tTyNuGKwkTaYRYtxa6dD();
		int num;
		if (XxinnLKwSTMssAQTteDF())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_007c;
		IL_0068:
		bool flag = true;
		goto IL_0041;
		IL_007c:
		bool flag2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				goto IL_0041;
			case 1:
			case 3:
				goto IL_0068;
			default:
				num = 2;
				continue;
			case 5:
				return qdEYKoKwWfGselubCM5V(P_0) + (flag2 ? 1 : 0);
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		bool? isChecked = P_0.IsChecked;
		goto IL_0068;
		IL_0041:
		flag2 = isChecked == flag;
		num = 5;
		if (tTyNuGKwkTaYRYtxa6dD())
		{
		}
		goto IL_007c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XxinnLKwSTMssAQTteDF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tTyNuGKwkTaYRYtxa6dD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yu9IdPKw8xE2CLIKQmQw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CheckBoxTreeItemViewModel)P_0).ImageSource;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SjDZkCKwqWJy0vnYnE9f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WqM0nVKwEF6cr6FpCJoM(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nSglriKwpTVL7ZM5fKIi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cjp54SKwX65PPr4REafq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Aql9mowmmR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ywuscgKw9y9hclbQ2O9j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bPM9hsiuYp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L6SDRZKw4QIIIuRZpadZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PcZou1Kw7gI9GonHACLV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YNXRaCKw3n9488BfXCB1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void r58IuJKwj88NvBof9kAy(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sUeQgCKw6sYvvB32tLEh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CheckBoxTreeItemViewModel)P_0).OyD1oiWYro((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GSABjqKwCwGcV1Nv31xA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xQcUR1KwAWXf1NXs5Aif(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<CheckBoxTreeItemViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TTtZIxKwR9aN4uMWOWUm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int qdEYKoKwWfGselubCM5V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CheckBoxTreeItemViewModel)P_0).ChildNodesCheckedCount;
	}
}
