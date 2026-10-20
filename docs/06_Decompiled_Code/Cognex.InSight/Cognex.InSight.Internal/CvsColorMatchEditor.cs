using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsColorMatchEditor : CvsColorToolEditorBase
{
	public class CvsColorModel
	{
		private string UDgmwKjIUi;

		private Color LXdmREHvp0;

		private bool rNDmsL3UmP;

		private readonly int cD0m6BLYaN;

		private readonly CvsColorMatchEditor I5LmH4ebKA;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return UDgmwKjIUi;
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
				return cD0m6BLYaN;
			}
		}

		public Color ModelColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return LXdmREHvp0;
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
				return rNDmsL3UmP;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 0;
				int num;
				if (frVVNVsrPhtpis8cN9Hh())
				{
					num = 4;
					if (false)
					{
						goto IL_0026;
					}
				}
				else
				{
					num = 3;
					if (false)
					{
						return;
					}
				}
				goto IL_0071;
				IL_0039:
				if (rNDmsL3UmP == value)
				{
					num = 1;
					if (false)
					{
						return;
					}
					goto IL_0071;
				}
				I5LmH4ebKA.LLNtqYmcQJ(this, value);
				goto IL_0026;
				IL_0071:
				switch (num)
				{
				case 0:
				case 4:
					goto IL_0039;
				case 1:
					return;
				case 5:
					return;
				}
				goto IL_0026;
				IL_0026:
				rNDmsL3UmP = value;
				num = 5;
				if (1 == 0)
				{
					goto IL_0039;
				}
				goto IL_0071;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorModel(CvsColorMatchEditor editor, int id, bool enabled, Color color, string name)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0086;
			IL_001a:
			UDgmwKjIUi = name;
			num = 6;
			goto IL_0086;
			IL_0086:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 4:
					JUB0dDsrxle5S7LXTXZP(this);
					goto case 2;
				case 6:
					LXdmREHvp0 = color;
					num = 9;
					continue;
				case 7:
					rNDmsL3UmP = enabled;
					num = 5;
					if (frVVNVsrPhtpis8cN9Hh())
					{
						continue;
					}
					goto case 0;
				case 0:
					cD0m6BLYaN = id;
					goto case 7;
				default:
					num = 7;
					continue;
				case 2:
				case 8:
					I5LmH4ebKA = editor;
					num = 0;
					continue;
				case 3:
					WT7smUsrN1JI46RkhxjF();
					_ = 1;
					if (YjuKyksrYg8EAakPU3cK())
					{
						num = 8;
						if (0 == 0)
						{
							continue;
						}
						goto case 6;
					}
					num = 4;
					continue;
				case 9:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Update(string name, bool enabled, Color color)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (frVVNVsrPhtpis8cN9Hh())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!frVVNVsrPhtpis8cN9Hh())
				{
					goto IL_008b;
				}
			}
			goto IL_0058;
			IL_0058:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					UDgmwKjIUi = name;
					num = 3;
					if (YjuKyksrYg8EAakPU3cK())
					{
					}
					continue;
				case 3:
					rNDmsL3UmP = enabled;
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_008b;
			IL_008b:
			LXdmREHvp0 = color;
			num = 5;
			goto IL_0058;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WT7smUsrN1JI46RkhxjF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JUB0dDsrxle5S7LXTXZP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool frVVNVsrPhtpis8cN9Hh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YjuKyksrYg8EAakPU3cK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class BRlacZpJg8lGnOD64x : CvsColorToolCustomProtocolCommand
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
				return CustomProtocolRequest.MatchGetEnabledModelList;
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
		public BRlacZpJg8lGnOD64x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ESfVOHsr3XxxOw4fiQKw();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ESfVOHsr3XxxOw4fiQKw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zQxbUwsr1fnCFqMjDnTV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kNiHrQsrrKL4nNDdyk8V()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int INVALID_ID = -1;

	private bool YvEtJO0pF2;

	private CvsColorModel[] ay6tMkEORF;

	public CvsColorModel[] ColorModels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (sV6tT6Kl2S())
			{
				efItgG5XXc();
			}
			return ay6tMkEORF;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InvalidateData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YvEtJO0pF2 = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool sV6tT6Kl2S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YvEtJO0pF2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorModel Tv4tlTOUDq(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CvsColorModel cvsColorModel = default;
		int num2 = default;
		CvsColorModel[] array = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (cvsColorModel.Id == P_0)
				{
					goto default;
				}
				num2++;
				num = 0;
				break;
			case 7:
				array = ay6tMkEORF;
				num = 5;
				break;
			case 0:
			case 2:
			case 6:
				if (num2 >= array.Length)
				{
					num = 8;
					break;
				}
				cvsColorModel = array[num2];
				num = 3;
				if (YDrxXWI3JeiQawfbcrx())
				{
				}
				break;
			case 5:
				num2 = 0;
				_ = 0;
				num = ((!SO6TK3IrNR7E6XlbqQQ()) ? 1 : 6);
				break;
			default:
				return cvsColorModel;
			case 8:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void efItgG5XXc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new BRlacZpJg8lGnOD64x());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LLNtqYmcQJ(CvsColorModel P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Od3Cl2IQBNrBPXQntjQ(CX9l0gIONmJDiijdDky(), kgbOBx7BanbFa22Hp9.ol99ukmDA(40278), CellLocation.ToString(), o1DolYIMhqVuIoItD9A(P_0), P_1 ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsColorMatchEditor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YDrxXWI3JeiQawfbcrx();
		int num;
		if (SO6TK3IrNR7E6XlbqQQ())
		{
			num = 4;
			if (!SO6TK3IrNR7E6XlbqQQ())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0062;
		IL_0062:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 5:
				goto IL_0044;
			default:
				num = 2;
				continue;
			case 1:
			case 3:
				YvEtJO0pF2 = true;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_0044:
		ay6tMkEORF = new CvsColorModel[0];
		goto IL_002e;
		IL_002e:
		base._002Ector();
		num = 6;
		if (!SO6TK3IrNR7E6XlbqQQ())
		{
			goto IL_0044;
		}
		goto IL_0062;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SO6TK3IrNR7E6XlbqQQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YDrxXWI3JeiQawfbcrx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CX9l0gIONmJDiijdDky()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int o1DolYIMhqVuIoItD9A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorModel)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Od3Cl2IQBNrBPXQntjQ(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3, P_4);
	}
}
