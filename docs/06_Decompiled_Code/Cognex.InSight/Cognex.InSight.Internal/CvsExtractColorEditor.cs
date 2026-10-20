using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsExtractColorEditor : CvsColorToolEditorBase
{
	public class CvsColorGroup
	{
		private string cOkmlmJ4fB;

		private bool mJvmgOBfHo;

		private readonly int u4HmqEE7JA;

		private readonly CvsExtractColorEditor XuImTBepvk;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return cOkmlmJ4fB;
			}
		}

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return u4HmqEE7JA;
			}
		}

		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return mJvmgOBfHo;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 1;
				int num = (GQZfmks1f4D4dbNQ7VHy() ? 2 : 4);
				while (true)
				{
					switch (num)
					{
					case 3:
						mJvmgOBfHo = value;
						num = 5;
						if (!L29o4Os1k7Q9qHkIhAcq())
						{
							return;
						}
						break;
					case 1:
						return;
					case 2:
						return;
					default:
						num = 3;
						break;
					case 0:
					case 4:
						if (mJvmgOBfHo == value)
						{
							return;
						}
						XuImTBepvk.ziaANwaiN0(this, value);
						goto case 3;
					case 5:
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorGroup(CvsExtractColorEditor editor, int id, bool enabled, string name)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!GQZfmks1f4D4dbNQ7VHy())
			{
				num = 5;
				if (!L29o4Os1k7Q9qHkIhAcq())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_0088;
			IL_002a:
			cOkmlmJ4fB = name;
			num = 8;
			goto IL_0088;
			IL_0088:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 2:
				case 6:
					XuImTBepvk = editor;
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 7;
				case 7:
					mJvmgOBfHo = enabled;
					num = 3;
					continue;
				case 0:
				case 5:
					ArEnyVs1FS1xjGT7pp6d();
					num = 1;
					continue;
				case 4:
					u4HmqEE7JA = id;
					goto case 7;
				default:
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					cDuHU9s1m2s1ehlAXowK(this);
					goto case 2;
				case 8:
					return;
				}
				break;
			}
			goto IL_002a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Update(string name, bool enabled)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cOkmlmJ4fB = name;
			mJvmgOBfHo = enabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ArEnyVs1FS1xjGT7pp6d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cDuHU9s1m2s1ehlAXowK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L29o4Os1k7Q9qHkIhAcq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GQZfmks1f4D4dbNQ7VHy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class fgmqsxW1tsJJM3vHnf : CvsColorToolCustomProtocolCommand
	{
		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetEnabledGroups;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 0;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public fgmqsxW1tsJJM3vHnf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rp41s8s1y2ZGDixUmmTx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w84jDvs1gwqIv7mF0i2j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int INVALID_ID = -1;

	private bool O1lAuYQDQ6;

	private CvsColorGroup[] lwlAGPJZ9i;

	public CvsColorGroup[] ColorGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (E4XAiRBFpr())
			{
				GTpAQ8gHJi();
			}
			return lwlAGPJZ9i;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InvalidateData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		O1lAuYQDQ6 = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool E4XAiRBFpr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return O1lAuYQDQ6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorGroup VHPAEmPSNQ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsColorGroup[] array = default;
		int num2 = default;
		CvsColorGroup cvsColorGroup = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				array = lwlAGPJZ9i;
				gnRERcIsv6jg6N1fOEE();
				if (!CDZrM9IhaviFj7vuPoA())
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto case 4;
			case 2:
			case 5:
			case 7:
				if (num2 < array.Length)
				{
					cvsColorGroup = array[num2];
					num = 4;
				}
				else
				{
					num = 8;
				}
				break;
			case 1:
			case 6:
				num2 = 0;
				goto case 2;
			case 4:
				if (cvsColorGroup.Id == P_0)
				{
					goto case 0;
				}
				num2++;
				num = 7;
				break;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				return cvsColorGroup;
			case 8:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GTpAQ8gHJi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new fgmqsxW1tsJJM3vHnf());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ziaANwaiN0(CvsColorGroup P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X8jAoFIEtiBH1hpl4kM(OyuZU9IL8k3aeBZ5bEc(), SSvsXFI9r4NEprgaafK(38474), CellLocation.ToString(), Nps06jISxJG9yQ2KaRC(P_0), P_1 ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsExtractColorEditor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gnRERcIsv6jg6N1fOEE();
		int num;
		if (!CDZrM9IhaviFj7vuPoA())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (CDZrM9IhaviFj7vuPoA())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				lwlAGPJZ9i = new CvsColorGroup[0];
				break;
			default:
				num = 2;
				continue;
			case 1:
			case 4:
				O1lAuYQDQ6 = true;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
				break;
			case 0:
			case 5:
				qpHDI4IvvnauZtV6euO();
				goto case 1;
			case 6:
				return;
			}
			base._002Ector();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gnRERcIsv6jg6N1fOEE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CDZrM9IhaviFj7vuPoA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OyuZU9IL8k3aeBZ5bEc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SSvsXFI9r4NEprgaafK(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Nps06jISxJG9yQ2KaRC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorGroup)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X8jAoFIEtiBH1hpl4kM(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qpHDI4IvvnauZtV6euO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
