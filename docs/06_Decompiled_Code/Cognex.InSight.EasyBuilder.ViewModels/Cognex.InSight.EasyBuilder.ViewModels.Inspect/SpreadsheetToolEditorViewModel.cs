using System;
using System.Runtime.CompilerServices;
using System.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Inspect;

public class SpreadsheetToolEditorViewModel : BaseViewModel
{
	private bool iuHUlFABWI;

	[CompilerGenerated]
	private readonly DelegateCommand<CellRenameArgs> AGwUTdtOq0;

	[CompilerGenerated]
	private EventHandler AwXUWD4w87;

	private CvsInSight zFOUjeEo3i;

	public DelegateCommand<CellRenameArgs> UpdateCellNameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AGwUTdtOq0;
		}
	}

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zFOUjeEo3i;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 7:
					zFOUjeEo3i = value;
					goto case 1;
				case 1:
				case 3:
					if (zFOUjeEo3i != null)
					{
						goto case 4;
					}
					return;
				default:
					num = 4;
					break;
				case 4:
					C8AiGmeewxNhCHQn149(zFOUjeEo3i, new CvsStateChangedEventHandler(kkxUMglIQ4));
					num = 0;
					break;
				case 0:
					xmVURM5pBu();
					num = 8;
					if (RGiepyeKOMadW7MbdE2())
					{
						break;
					}
					goto case 6;
				case 6:
					if (zFOUjeEo3i != null)
					{
						num = 5;
						break;
					}
					goto case 2;
				case 5:
					s0dChfeao6VoballDNy(zFOUjeEo3i, new CvsStateChangedEventHandler(kkxUMglIQ4));
					_ = 1;
					if (Rdyf7Qe5pUFmgaB9kWs())
					{
						num = 1;
						break;
					}
					num = 7;
					if (Rdyf7Qe5pUFmgaB9kWs())
					{
					}
					break;
				case 8:
					return;
				}
			}
		}
	}

	public bool RunMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iuHUlFABWI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!SetField(ref iuHUlFABWI, value, (string)qH2J0jeDDsEspKQO9rc(2106)))
			{
				return;
			}
			try
			{
				if (RunMode)
				{
					return;
				}
				_ = 0;
				int num;
				if (RGiepyeKOMadW7MbdE2())
				{
					num = 3;
				}
				else
				{
					num = 2;
					if (1 == 0)
					{
						goto IL_0093;
					}
				}
				goto IL_0068;
				IL_0068:
				switch (num)
				{
				case 0:
				case 3:
					if (InSight != null)
					{
						break;
					}
					return;
				case 4:
					mj1622eVI6LhBopxrW0(ekwJo0enmiK1xD9YlZy(T8uIlweiTVyXoCT6bxp(InSight)));
					return;
				}
				goto IL_0093;
				IL_0093:
				if (jQK393eO7ZZpgyu6FuR(InSight) == CvsInSightState.Connected)
				{
					num = 4;
					goto IL_0068;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public event EventHandler DisplayFocusChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Rdyf7Qe5pUFmgaB9kWs();
			int num = ((!RGiepyeKOMadW7MbdE2()) ? 5 : 2);
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					eventHandler = Interlocked.CompareExchange(ref AwXUWD4w87, value2, eventHandler2);
					num = 6;
					break;
				case 0:
				case 2:
					eventHandler = AwXUWD4w87;
					num = 1;
					break;
				case 1:
					eventHandler2 = eventHandler;
					num = 4;
					break;
				case 4:
					value2 = (EventHandler)KNtUNZeJ6ryTqCrFXtp(eventHandler2, value);
					goto default;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (Rdyf7Qe5pUFmgaB9kWs())
						{
							return;
						}
						break;
					}
					goto case 1;
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
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_004a;
			IL_001a:
			EventHandler eventHandler = AwXUWD4w87;
			num = 1;
			goto IL_004a;
			IL_004a:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					goto default;
				default:
					RGiepyeKOMadW7MbdE2();
					num = (Rdyf7Qe5pUFmgaB9kWs() ? 6 : 2);
					continue;
				case 2:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref AwXUWD4w87, value2, eventHandler2);
					goto case 4;
				case 1:
					eventHandler2 = eventHandler;
					num = 0;
					continue;
				case 4:
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpreadsheetToolEditorViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Rdyf7Qe5pUFmgaB9kWs();
		int num;
		if (RGiepyeKOMadW7MbdE2())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0084;
			}
		}
		goto IL_0040;
		IL_0040:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				F91PUnewVB2TgXeM0wG(this);
				break;
			default:
				num = 4;
				if (!Rdyf7Qe5pUFmgaB9kWs())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_0084;
		IL_0084:
		AGwUTdtOq0 = new DelegateCommand<CellRenameArgs>(SsVU4f5fPV, [MethodImpl(MethodImplOptions.NoInlining)] (CellRenameArgs _) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		});
		num = 5;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kkxUMglIQ4(object P_0, CvsStateChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xmVURM5pBu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xmVURM5pBu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (RGiepyeKOMadW7MbdE2())
		{
			num = 4;
			if (!RGiepyeKOMadW7MbdE2())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_006e;
		IL_002a:
		j70qeveIo9rd3H9hDx8(InSight, false, true);
		num = 5;
		if (Rdyf7Qe5pUFmgaB9kWs())
		{
		}
		goto IL_006e;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
			case 3:
				if (jQK393eO7ZZpgyu6FuR(InSight) == CvsInSightState.Connected)
				{
					break;
				}
				return;
			default:
				num = 2;
				if (Rdyf7Qe5pUFmgaB9kWs())
				{
				}
				continue;
			case 0:
			case 4:
				if (InSight != null)
				{
					goto case 1;
				}
				return;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SsVU4f5fPV(CellRenameArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 7:
				return;
			case 8:
				gNokBlerxmMnUuHdM2G(ekwJo0enmiK1xD9YlZy(InSight.CogSocket), P_0.Location, KFuqiZevktvhY51MdxQ(P_0));
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 2:
				if (naqYUMeghLE2GKDZIke(cvsCell))
				{
					num = 9;
					break;
				}
				return;
			case 10:
				if (Ms9w9OesuNJMtZM0O5Z(cvsCell) == null)
				{
					num = 8;
					if (!RGiepyeKOMadW7MbdE2())
					{
						return;
					}
					break;
				}
				if (htKlDteZImhfhQTmGW9(cvsCell.Name, P_0.NewName))
				{
					num = 0;
					if (!Rdyf7Qe5pUFmgaB9kWs())
					{
						break;
					}
					goto case 0;
				}
				return;
			case 6:
				return;
			case 0:
				gNokBlerxmMnUuHdM2G(ekwJo0enmiK1xD9YlZy(T8uIlweiTVyXoCT6bxp(InSight)), P_0.Location, P_0.NewName);
				num = 11;
				break;
			case 3:
				cvsCell = (CvsCell)wDIP4welTo68UnVb0e7(((CvsResultSet)sn32VLefZcirkHI3elV(InSight)).Cells, SVNFfled6Qlpn15JmgA(P_0));
				Rdyf7Qe5pUFmgaB9kWs();
				num = (RGiepyeKOMadW7MbdE2() ? 2 : 6);
				break;
			case 5:
			{
				EventHandler eventHandler = AwXUWD4w87;
				if (eventHandler != null)
				{
					jOaxS6eP8r6VskEZkGk(eventHandler, this, EventArgs.Empty);
					return;
				}
				num = 4;
				break;
			}
			case 9:
				if (!CvsCell.IsNullOrEmpty(cvsCell))
				{
					num = 10;
					break;
				}
				goto case 8;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F91PUnewVB2TgXeM0wG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RGiepyeKOMadW7MbdE2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rdyf7Qe5pUFmgaB9kWs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KNtUNZeJ6ryTqCrFXtp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s0dChfeao6VoballDNy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).StateChanged -= (CvsStateChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C8AiGmeewxNhCHQn149(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).StateChanged += (CvsStateChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightState jQK393eO7ZZpgyu6FuR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j70qeveIo9rd3H9hDx8(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qH2J0jeDDsEspKQO9rc(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T8uIlweiTVyXoCT6bxp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ekwJo0enmiK1xD9YlZy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mj1622eVI6LhBopxrW0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetLatestSheetResult();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sn32VLefZcirkHI3elV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation SVNFfled6Qlpn15JmgA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellRenameArgs)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wDIP4welTo68UnVb0e7(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool naqYUMeghLE2GKDZIke(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).IsPublishable();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ms9w9OesuNJMtZM0O5Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KFuqiZevktvhY51MdxQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellRenameArgs)P_0).NewName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gNokBlerxmMnUuHdM2G(object P_0, CvsCellLocation P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocketSheet)P_0).PutCellNameAndRunSheet(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jOaxS6eP8r6VskEZkGk(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool htKlDteZImhfhQTmGW9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}
}
