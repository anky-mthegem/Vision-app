using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Data;
using Cognex.InSight.Sensor;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsParse
{
	[Flags]
	public enum ParseFlags
	{
		ALLOW_SINGLE_QUOTE = 1,
		ALLOW_DOUBLE_QUOTE = 2,
		ALLOW_COMMA = 4,
		ALLOW_OPEN_PAREN = 8,
		ALLOW_CLOSE_PAREN = 0x10,
		ALLOW_UNARYOP = 0x20,
		ALLOW_INFIXOP = 0x40,
		ALLOW_NUMBER = 0x80,
		ALLOW_CELL = 0x100,
		ALLOW_FUNC = 0x200,
		ALLOW_BANG = 0x400,
		ALLOW_CELL_POS = 0x10000,
		ALLOW_NULL_CELL = 0x20000,
		ALLOW_STRUCT = 0x40000,
		ALLOW_STRFUNC = 0x80000,
		ALLOW_DIGIT = 0x100000,
		ALLOW_PERIOD = 0x200000,
		ALLOW_CELL_ABS = 0x400000,
		ALLOW_CELL_COL = 0x800000,
		ALLOW_CELL_RANGE = 0x1000000,
		ALLOW_TEXT = 0x2000000,
		ALLOW_TOKEN_MATCH = 0x4000000,
		ALLOW_TOKEN_COMPLETE = 0x8000000,
		ALLOW_OK = 0x10000000,
		ALLOW_SHEET_FUNC = 0x20000000,
		ALLOW_PROP_FUNC = 0x40000000
	}

	[Flags]
	public enum FoundFlags
	{
		FOUND_LABEL = 1,
		FOUND_NUMBER = 2,
		FOUND_STRING = 4,
		FOUND_CELL = 8,
		FOUND_FUNCTION = 0x10,
		FOUND_STRUCTURE = 0x20,
		FOUND_PAREN = 0x40,
		FOUND_OPERATOR = 0x80
	}

	internal class CvsFuncStack
	{
		internal CvsFunction m_FuncDesc;

		internal int m_ArgIndex;

		internal int m_ArgPos;

		internal int m_FunctionPos;

		internal int ArgIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return m_ArgIndex;
			}
		}

		internal CvsFunction FD
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return m_FuncDesc;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				m_FuncDesc = value;
			}
		}

		internal int ArgPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return m_ArgPos;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				m_ArgPos = value;
			}
		}

		internal int FunctionPos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return m_FunctionPos;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				m_FunctionPos = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsFuncStack(CvsFunction fd, int argIndex)
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
				case 4:
					m_ArgPos = -1;
					_ = 1;
					num = (pQjNepsM2Q78oG3KrXPJ() ? 7 : 5);
					break;
				case 2:
				case 5:
					m_FunctionPos = -1;
					goto case 3;
				case 1:
					m_ArgIndex = argIndex;
					num = 8;
					break;
				case 0:
					m_FuncDesc = fd;
					num = 1;
					break;
				case 6:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					num = 4;
					if (!pQjNepsM2Q78oG3KrXPJ())
					{
						break;
					}
					goto case 3;
				case 3:
				case 7:
					uefuABsMWwWd0n8uuigw(this);
					goto case 0;
				default:
					num = 0;
					break;
				case 8:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void nextArg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			m_ArgIndex++;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UaP78LsMcYYGTndaWYf4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pQjNepsM2Q78oG3KrXPJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uefuABsMWwWd0n8uuigw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	internal abstract class CvsToken
	{
		internal abstract int getExprStack();

		internal abstract void parse(CvsParse result);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CvsToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rA1HBVsMCIKqgSg0rWTk();
			GEPgUvsMKHGjVNZNMX4Q(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rA1HBVsMCIKqgSg0rWTk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GEPgUvsMKHGjVNZNMX4Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TmWZ7bsM71xNuo5JAd2e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OJtHtNsMtY4KoGwRtO9X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	internal class CvsUnaryToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!FBW0xPsMocFjU1U0YqrO())
			{
			}
			char c = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (c != '+')
					{
						num = 7;
						break;
					}
					goto case 5;
				case 4:
					if (c == '!')
					{
						goto case 5;
					}
					return;
				case 5:
				case 6:
					result.consume(1, ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 8;
					break;
				case 1:
				case 3:
					c = ((string)Ksfq2usMYH7411950l9x(result))[0];
					num = 2;
					break;
				case 7:
					if (c != '-')
					{
						goto case 4;
					}
					goto case 5;
				default:
					num = 4;
					break;
				case 0:
					if (t7usGhsMP9tlOHUZPAhb(result))
					{
						KPO2DnsM55kfnoRsPoud();
						if (FBW0xPsMocFjU1U0YqrO())
						{
							num = 6;
							if (0 == 0)
							{
								break;
							}
							goto case 5;
						}
						num = 3;
						break;
					}
					return;
				case 8:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsUnaryToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hRxTVpsMN7H7ZOcpCGQS();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t7usGhsMP9tlOHUZPAhb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowUnary;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ksfq2usMYH7411950l9x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KPO2DnsM55kfnoRsPoud()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FBW0xPsMocFjU1U0YqrO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hRxTVpsMN7H7ZOcpCGQS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsLabelToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (i49ai2sMrM4wE2LMgBZW(result))
					{
						num = 7;
						break;
					}
					return;
				case 5:
					text = (string)OZ24N2sMQ3gxGcJHO1jH(result, isv4uIsMMsC39QfGnOQj(text), ParseFlags.ALLOW_TEXT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 0;
					break;
				case 0:
					num = 8;
					break;
				case 2:
				case 6:
					if (suo3FCsM3jhhmIcQl443(text, 0) == '\'')
					{
						goto case 3;
					}
					return;
				case 3:
				case 4:
					jjBLD8sMOUxKFPGgw3E3(result, FoundFlags.FOUND_LABEL);
					goto case 5;
				default:
					num = 5;
					break;
				case 7:
					text = result.QA131nsx2t();
					_ = 1;
					num = ((!o3iKaLsM1pxC6rokNwYd()) ? 6 : 4);
					break;
				case 8:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsLabelToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mkob7usMlt4mZ7FHs2yo();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i49ai2sMrM4wE2LMgBZW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowSingleQuote;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char suo3FCsM3jhhmIcQl443(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jjBLD8sMOUxKFPGgw3E3(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int isv4uIsMMsC39QfGnOQj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OZ24N2sMQ3gxGcJHO1jH(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LLHhTCsMxgh8UQnljfaJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o3iKaLsM1pxC6rokNwYd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Mkob7usMlt4mZ7FHs2yo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsStringToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			ParseFlags parseFlags = default;
			int num2 = default;
			string text = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					if (result.AllowDoubleQuote)
					{
						num = 12;
						break;
					}
					return;
				case 8:
					parseFlags |= ParseFlags.ALLOW_TOKEN_COMPLETE;
					num2++;
					num = 13;
					break;
				case 4:
				case 10:
					if (text == null)
					{
						num = 5;
						break;
					}
					num3 = rrRrExsMGs25VW79UHF2(text);
					num = 2;
					break;
				case 0:
				case 6:
					text = (string)oZeqPfsMnQIXy1Bo7WUV(result, num2, parseFlags);
					num = 18;
					break;
				case 1:
				case 3:
					text = (string)oZeqPfsMnQIXy1Bo7WUV(result, 1, ParseFlags.ALLOW_TEXT | ParseFlags.ALLOW_TOKEN_MATCH);
					goto case 4;
				case 5:
					return;
				case 11:
					parseFlags |= ParseFlags.ALLOW_TEXT;
					num = 0;
					break;
				case 12:
					text = result.QA131nsx2t();
					num = 15;
					break;
				case 16:
					if (num2 >= num3)
					{
						num = 14;
						break;
					}
					goto IL_00e7;
				case 17:
					parseFlags = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_TOKEN_MATCH;
					goto IL_00e7;
				case 15:
					if (BiYCv4sMIfxD9asLDASU(text, 0) == '"')
					{
						chTrFSsMaMNVhbclPpFy(result, r3oHFxsMRoLHxmC3Pr6o(result));
						_ = 1;
						if (rHhy42sMum82m7PaMxkW())
						{
							num = 10;
							break;
						}
						num = 1;
						if (true)
						{
							break;
						}
						goto case 2;
					}
					return;
				case 2:
					num2 = 0;
					num = 17;
					if (true)
					{
						break;
					}
					goto case 13;
				case 13:
				case 14:
					if ((parseFlags & ParseFlags.ALLOW_TOKEN_COMPLETE) != 0)
					{
						tHHAsusMXpognMjXIOZV(result, FoundFlags.FOUND_STRING);
						num = 6;
					}
					else
					{
						num = 11;
					}
					break;
				case 9:
					chTrFSsMaMNVhbclPpFy(result, -1);
					goto case 8;
				default:
					num = 8;
					if (false)
					{
						return;
					}
					break;
				case 18:
					return;
					IL_00e7:
					if (text[num2] == '"')
					{
						num = 9;
						break;
					}
					num2++;
					num = 16;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsStringToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char BiYCv4sMIfxD9asLDASU(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int r3oHFxsMRoLHxmC3Pr6o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).eGy3FUKmsq();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void chTrFSsMaMNVhbclPpFy(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).ga8WVBB6da(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oZeqPfsMnQIXy1Bo7WUV(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rrRrExsMGs25VW79UHF2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tHHAsusMXpognMjXIOZV(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G2MGm4sMeOtHq78I8sED()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rHhy42sMum82m7PaMxkW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	internal class CvsCommaToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 9;
			if (evNDBisM6tkyDy8UQ9Qe())
			{
				goto IL_001e;
			}
			goto IL_0128;
			IL_001e:
			Hs0jLKsMJcGgoHRecPZB(result, 1, JdYGxasMZUXUgKMIgOOi(result) | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
			num = 17;
			goto IL_0128;
			IL_0128:
			CvsFunction cvsFunction2 = default;
			string str = default;
			int num2 = default;
			int num3 = default;
			CvsFunction cvsFunction = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 6:
					if (cvsFunction2 != null)
					{
						num = 2;
						continue;
					}
					break;
				case 12:
					if (dv7lawsM4mTFW1mPKRqI(qvx5OAsM0Eky2aWNZTvg(result), 0) == ',')
					{
						num = 10;
						continue;
					}
					return;
				case 14:
					cvsFunction2 = result.NI43oh5OPs.FindFunction(str, num2);
					goto IL_0080;
				case 15:
					if (LLyX75sMmvBVRImBWQnX(result) > num3)
					{
						num = 3;
						continue;
					}
					break;
				case 2:
					v8tAresMgy2TxevGFQFe(result.ooB3jxBS4K, cvsFunction2);
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
				case 16:
					num3 = gl83YusMFCEgV05G3SXW(cvsFunction) - 1;
					num = 15;
					continue;
				case 8:
					cvsFunction2 = result.NI43oh5OPs.FindFunction(str, num2);
					goto IL_0080;
				case 10:
					zKQbFDsMk4G7talEDtAk(result);
					cvsFunction = (CvsFunction)NN64WAsMfnasp4PdK5AQ(result);
					num = 11;
					continue;
				case 0:
				case 7:
					num2 = 0;
					goto case 8;
				default:
					num = 8;
					continue;
				case 5:
					if (result.ArgIndex > num4)
					{
						num = 13;
						continue;
					}
					goto case 6;
				case 9:
					if (LgagXVsMpWLOK9q9gl0P(result))
					{
						num = 12;
						if (!evNDBisM6tkyDy8UQ9Qe())
						{
							continue;
						}
						goto case 11;
					}
					return;
				case 11:
					if (cvsFunction != null)
					{
						_ = 0;
						num = (vby5ktsMb9fR3mYGqDdU() ? 16 : 0);
						continue;
					}
					break;
				case 13:
					num2++;
					num = 14;
					continue;
				case 3:
					str = (string)wPjYEKsMyI7OKrwipaFY(cvsFunction);
					goto case 0;
				case 17:
					return;
					IL_0080:
					if (cvsFunction2 == null)
					{
						num = 6;
						continue;
					}
					num4 = cvsFunction2.MaxNumberOfArgs - 1;
					num = 5;
					continue;
				}
				break;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsCommaToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ry3T3asM8OayhgLFYLDM();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LgagXVsMpWLOK9q9gl0P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowComma;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qvx5OAsM0Eky2aWNZTvg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char dv7lawsM4mTFW1mPKRqI(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zKQbFDsMk4G7talEDtAk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).nextArg();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NN64WAsMfnasp4PdK5AQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CurrentFunction;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int gl83YusMFCEgV05G3SXW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).MaxNumberOfArgs;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int LLyX75sMmvBVRImBWQnX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).ArgIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wPjYEKsMyI7OKrwipaFY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void v8tAresMgy2TxevGFQFe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsFuncStack)P_0).FD = (CvsFunction)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ParseFlags JdYGxasMZUXUgKMIgOOi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).getArgAllowed();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Hs0jLKsMJcGgoHRecPZB(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vby5ktsMb9fR3mYGqDdU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool evNDBisM6tkyDy8UQ9Qe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ry3T3asM8OayhgLFYLDM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsOpenParenToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!oigsuesQwLZS6f8PFREq())
			{
				num = 2;
				if (!H6pNI7sMzrn3Xd79xQ1g())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0043;
			IL_0089:
			eSNYJisQL0wJc6A8qAPF(result, 1, ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
			JNhuP1sQ9aUdjXx4kYlW(result, result.eGy3FUKmsq());
			num = 6;
			goto IL_0043;
			IL_0043:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 2:
					if (j1nWKQsQsvboxV43PSXb(result))
					{
						goto case 1;
					}
					return;
				case 3:
					goto IL_0089;
				case 1:
				case 5:
					if (pm93N6sQhus0Wql4tJXQ(result.QA131nsx2t(), 0) == '(')
					{
						num = 4;
						if (oigsuesQwLZS6f8PFREq())
						{
						}
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			result.addLevel(null);
			goto IL_0089;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsOpenParenToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			m9rBpXsQSKZl9BV4ZFuv();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j1nWKQsQsvboxV43PSXb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowOpenParen;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char pm93N6sQhus0Wql4tJXQ(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eSNYJisQL0wJc6A8qAPF(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JNhuP1sQ9aUdjXx4kYlW(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).X21WCHZnYb(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H6pNI7sMzrn3Xd79xQ1g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oigsuesQwLZS6f8PFREq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void m9rBpXsQSKZl9BV4ZFuv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsCloseParenToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					DGmy9psQVw4dRRxSb8JJ(result);
					goto default;
				case 4:
					if (WBqZhYsQH7gN45urXrPN(result.QA131nsx2t(), 0) == ')')
					{
						_ = 0;
						if (!MdWRZysQEjxNZex6RZw9())
						{
							num = 0;
							break;
						}
						num = 1;
						if (!ssbhXDsQv2YnHyNfPcT0())
						{
							break;
						}
						goto case 5;
					}
					return;
				case 5:
					if (result.AllowCloseParen)
					{
						num = 4;
						if (MdWRZysQEjxNZex6RZw9())
						{
							break;
						}
						goto default;
					}
					return;
				default:
					ibdEJ7sQAV1fmqJEqfS9(result, 1, ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 6;
					break;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsCloseParenToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oQ6OMUsQDmmaMla5iYT9();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char WBqZhYsQH7gN45urXrPN(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DGmy9psQVw4dRRxSb8JJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).removeLevel();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ibdEJ7sQAV1fmqJEqfS9(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MdWRZysQEjxNZex6RZw9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ssbhXDsQv2YnHyNfPcT0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oQ6OMUsQDmmaMla5iYT9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsNumberToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 15;
			if (false)
			{
				return;
			}
			string text = default;
			bool flag = default;
			int num3 = default;
			bool flag2 = default;
			int num2 = default;
			ParseFlags parseFlags3 = default;
			CvsFunctionArg cvsFunctionArg = default;
			ParseFlags allowed = default;
			ParseFlags parseFlags2 = default;
			int num4 = default;
			int num5 = default;
			ParseFlags parseFlags = default;
			while (true)
			{
				switch (num)
				{
				case 51:
					return;
				case 1:
					if (text == null)
					{
						num = 29;
						break;
					}
					goto IL_0159;
				case 54:
					flag = false;
					goto IL_0051;
				case 27:
					num3 = vjqtOJsQob4KD7EfBK8l(text);
					num = 2;
					break;
				case 55:
					flag2 = false;
					num = 13;
					if (!prhHngsQTq35mwgcdKdM())
					{
						break;
					}
					goto case 17;
				case 17:
					num3 = 15 - num2;
					num = 42;
					break;
				case 23:
					parseFlags3 = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
					num = 4;
					break;
				case 34:
					cvsFunctionArg = null;
					num = 38;
					break;
				case 14:
					if (text == null)
					{
						return;
					}
					goto IL_00bb;
				case 12:
					num2 = MaxDigitsBeforeDecimal;
					num = 47;
					break;
				case 45:
					if (num3 >= MaxDigitsAfterDecimal)
					{
						num = 37;
						break;
					}
					goto case 26;
				case 18:
					return;
				case 56:
					cvsFunctionArg = null;
					num = 7;
					break;
				case 38:
					if (text[0] == '-')
					{
						num = 8;
						break;
					}
					goto IL_001b;
				case 11:
					if (flag && VqgpYnsQPp8PIx7jhtuD(result))
					{
						num = 3;
						break;
					}
					return;
				case 10:
				case 22:
					text = (string)aawUXfsQthcul1AEBcoC(result, 1, allowed);
					num = 14;
					break;
				case 29:
					return;
				case 19:
				case 30:
					num3 = 0;
					num = 55;
					if (0 == 0)
					{
						break;
					}
					goto case 39;
				case 39:
					flag = false;
					num = 53;
					break;
				case 7:
					if (wtZYCZsQqBJibVheE7fM(result) == null)
					{
						goto case 38;
					}
					cvsFunctionArg = (CvsFunctionArg)R1QuV2sQBfxTm2cfBKvR(wtZYCZsQqBJibVheE7fM(result), result.ArgIndex);
					num = 57;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				case 6:
					if (c9YxHrsQc87AhiLRqn7i(cvsFunctionArg) <= ChaXvvsQ2qRVtOArRiA5(cvsFunctionArg))
					{
						num = 34;
						break;
					}
					goto case 38;
				case 26:
					if (num2 + num3 >= 15)
					{
						num = 17;
						break;
					}
					goto case 53;
				case 53:
					VaU2TmsQCkUlDkJUadVX(result, FoundFlags.FOUND_NUMBER);
					text = (string)aawUXfsQthcul1AEBcoC(result, num3, parseFlags2);
					if (text == null)
					{
						return;
					}
					goto IL_0218;
				case 36:
					text = (string)aawUXfsQthcul1AEBcoC(result, num2, parseFlags3);
					if (text == null)
					{
						return;
					}
					goto IL_0242;
				case 8:
					text = result.consume(1, result.veZ3Riw9M7);
					if (text == null)
					{
						num = 51;
						break;
					}
					goto IL_001b;
				case 28:
					if (num4 >= num5)
					{
						num = 44;
						if (!prhHngsQTq35mwgcdKdM())
						{
							break;
						}
						goto case 57;
					}
					goto case 31;
				case 57:
					if (cvsFunctionArg.Type == CvsFunctionArgTypes.Enum)
					{
						goto case 34;
					}
					num = 50;
					if (0 == 0)
					{
						break;
					}
					goto case 44;
				case 44:
					num4 = num5;
					num = 16;
					break;
				case 15:
					if (wweKsosQdZteQXMLPruE(result))
					{
						num = 48;
						break;
					}
					return;
				case 41:
					if (text == null)
					{
						num = 9;
						break;
					}
					VaU2TmsQCkUlDkJUadVX(result, FoundFlags.FOUND_NUMBER);
					text = (string)aawUXfsQthcul1AEBcoC(result, parseHexInt(text), ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 24;
					if (GybY9ssQU4mlpesxjJgB())
					{
						break;
					}
					goto case 49;
				case 5:
					if (H057xxsQ5HR4lcn514sd(result))
					{
						num = 27;
						break;
					}
					goto IL_0218;
				case 16:
					parseFlags &= ~ParseFlags.ALLOW_DIGIT;
					num = 31;
					if (0 == 0)
					{
						break;
					}
					goto case 42;
				case 42:
					parseFlags2 &= ~ParseFlags.ALLOW_DIGIT;
					num = 39;
					break;
				case 25:
					if (D7r9fOsQjOvQ19lvvJIx(cvsFunctionArg) != CvsFunctionArgTypes.Variant)
					{
						num = 6;
						break;
					}
					goto case 34;
				case 24:
					num = 18;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 46:
					if (LqspV9sQ7JW6lYEXCDFm(text, 0) == 'e')
					{
						num = 49;
						if (!prhHngsQTq35mwgcdKdM())
						{
							break;
						}
						goto case 40;
					}
					return;
				case 40:
					parseFlags2 = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
					num = 45;
					break;
				case 2:
					if (num3 > 0)
					{
						num = 40;
						break;
					}
					goto IL_0218;
				case 58:
					if (text == null)
					{
						return;
					}
					if (LqspV9sQ7JW6lYEXCDFm(text, 0) != '+')
					{
						if (LqspV9sQ7JW6lYEXCDFm(text, 0) == '-')
						{
							num = 35;
							break;
						}
						goto IL_0159;
					}
					goto case 35;
				case 21:
					if (num2 <= 0)
					{
						allowed = ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH;
						num = 10;
						break;
					}
					allowed = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
					goto case 10;
				default:
					num = 22;
					if (0 == 0)
					{
						break;
					}
					goto case 47;
				case 47:
					parseFlags3 &= ~(ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD);
					num = 54;
					break;
				case 43:
					if (LqspV9sQ7JW6lYEXCDFm(text, 1) != 'x')
					{
						num = 32;
						if (!prhHngsQTq35mwgcdKdM())
						{
							break;
						}
						goto case 37;
					}
					goto IL_05cb;
				case 37:
					num3 = MaxDigitsAfterDecimal;
					parseFlags2 &= ~ParseFlags.ALLOW_DIGIT;
					num = 33;
					break;
				case 35:
					LqspV9sQ7JW6lYEXCDFm(text, 0);
					num = 20;
					if (!GybY9ssQU4mlpesxjJgB())
					{
						return;
					}
					break;
				case 9:
					return;
				case 49:
					text = result.consume(1, ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH);
					num = 58;
					if (prhHngsQTq35mwgcdKdM())
					{
					}
					break;
				case 13:
					if (num2 <= 0)
					{
						goto IL_0242;
					}
					num = 23;
					if (GybY9ssQU4mlpesxjJgB())
					{
						break;
					}
					goto case 50;
				case 50:
					if (cvsFunctionArg.Type != CvsFunctionArgTypes.Bool)
					{
						num = 25;
						break;
					}
					goto case 34;
				case 32:
					if (LqspV9sQ7JW6lYEXCDFm(text, 1) != 'X')
					{
						goto IL_00f3;
					}
					goto IL_05cb;
				case 4:
					if (num2 < MaxDigitsBeforeDecimal)
					{
						goto IL_0051;
					}
					num = 12;
					if (GybY9ssQU4mlpesxjJgB())
					{
						break;
					}
					goto case 33;
				case 33:
					flag = false;
					num = 26;
					break;
				case 20:
					text = (string)aawUXfsQthcul1AEBcoC(result, 1, ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH);
					num = 1;
					break;
				case 52:
					num2 = parseInt(text);
					GybY9ssQU4mlpesxjJgB();
					num = ((!prhHngsQTq35mwgcdKdM()) ? 30 : 0);
					break;
				case 3:
					if (LqspV9sQ7JW6lYEXCDFm(text, 0) != 'E')
					{
						goto case 0;
					}
					goto case 49;
				case 31:
					text = (string)aawUXfsQthcul1AEBcoC(result, num4, parseFlags);
					num = 59;
					if (0 == 0)
					{
						break;
					}
					goto case 48;
				case 48:
					text = (string)MEamH7sQil7av08EghCk(result);
					num = 56;
					break;
				case 59:
					return;
					IL_0159:
					num4 = parseInt(text);
					num5 = 3;
					parseFlags = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
					num = 28;
					break;
					IL_05cb:
					text = (string)aawUXfsQthcul1AEBcoC(result, 2, ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH);
					num = 41;
					break;
					IL_001b:
					if (dT6oMSsQWDXSlkJxanlL(text) >= 2 && LqspV9sQ7JW6lYEXCDFm(text, 0) == '0')
					{
						num = 43;
						break;
					}
					goto IL_00f3;
					IL_00f3:
					flag = true;
					num = 52;
					if (GybY9ssQU4mlpesxjJgB())
					{
						break;
					}
					goto case 56;
					IL_00bb:
					if (flag2)
					{
						num = 5;
						break;
					}
					goto IL_0218;
					IL_0242:
					if (!i0rlbCsQKnGyS2kED6NM(result) || LqspV9sQ7JW6lYEXCDFm(text, 0) != '.')
					{
						goto IL_00bb;
					}
					flag2 = true;
					num = 21;
					if (true)
					{
						break;
					}
					goto case 8;
					IL_0218:
					if (num2 == 0 && num3 == 0)
					{
						flag = false;
						num = 11;
						break;
					}
					goto case 11;
					IL_0051:
					result.IjgWZKfi8i(FoundFlags.FOUND_NUMBER);
					num = 36;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int parseHexInt(string expr)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			int result = default;
			int num2 = default;
			char c = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					result = dT6oMSsQWDXSlkJxanlL(expr);
					num = 2;
					break;
				case 2:
					num2 = 0;
					goto case 0;
				case 6:
				case 8:
					result = num2;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				case 10:
					if (char.IsDigit(c))
					{
						goto IL_001d;
					}
					num = 9;
					if (GybY9ssQU4mlpesxjJgB())
					{
						break;
					}
					goto case 3;
				case 3:
				case 5:
					if (c <= 'F')
					{
						goto IL_001d;
					}
					goto case 6;
				case 0:
					if (num2 < dT6oMSsQWDXSlkJxanlL(expr))
					{
						c = LqspV9sQ7JW6lYEXCDFm(expr, num2);
						num = 10;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					num = 11;
					break;
				case 9:
					if (c < 'A')
					{
						goto case 6;
					}
					goto default;
				default:
					GybY9ssQU4mlpesxjJgB();
					num = ((!prhHngsQTq35mwgcdKdM()) ? 3 : 8);
					break;
				case 7:
					expr = (string)QjyeHfsQYRQyaaRqmMbb(expr, CultureInfo.InvariantCulture);
					num = 1;
					break;
				case 4:
				case 11:
					{
						return result;
					}
					IL_001d:
					num2++;
					num = 0;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsNumberToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wweKsosQdZteQXMLPruE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowNumber;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MEamH7sQil7av08EghCk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wtZYCZsQqBJibVheE7fM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CurrentFunction;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R1QuV2sQBfxTm2cfBKvR(object P_0, int index)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).GetArg(index);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsFunctionArgTypes D7r9fOsQjOvQ19lvvJIx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionArg)P_0).Type;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double c9YxHrsQc87AhiLRqn7i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionArg)P_0).MaxVal;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double ChaXvvsQ2qRVtOArRiA5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunctionArg)P_0).MinVal;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dT6oMSsQWDXSlkJxanlL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char LqspV9sQ7JW6lYEXCDFm(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aawUXfsQthcul1AEBcoC(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VaU2TmsQCkUlDkJUadVX(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i0rlbCsQKnGyS2kED6NM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowPeriod;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H057xxsQ5HR4lcn514sd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowDigit;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vjqtOJsQob4KD7EfBK8l(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return parseInt((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VqgpYnsQPp8PIx7jhtuD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).hasAdvanced();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GybY9ssQU4mlpesxjJgB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool prhHngsQTq35mwgcdKdM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QjyeHfsQYRQyaaRqmMbb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).ToUpper((CultureInfo)P_1);
		}
	}

	internal class CvsInFixToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0141;
			IL_001a:
			if (J3viVHsQ1jLCYH0F6W0i(result))
			{
				num = 14;
				goto IL_0141;
			}
			return;
			IL_0141:
			char c = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 20:
					if (c != '*')
					{
						num = 10;
						continue;
					}
					goto case 19;
				case 2:
					if (c != '<')
					{
						goto case 4;
					}
					goto case 19;
				case 3:
					do
					{
						JlOXUcsQQfMBHLSsEg10(result, FoundFlags.FOUND_OPERATOR);
						text = (string)eHEe29sQl8O0NFsebTTH(result, 2, ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
						_ = 1;
						if (WvoIUgsQxU4vCu2IDnaS())
						{
							num = 4;
							continue;
						}
						num = 12;
						break;
					}
					while (!T0XVgPsQNaFkwk60tOx9());
					continue;
				case 8:
				case 12:
					return;
				case 14:
					text = (string)Ob2WlDsQrADDWoYNUJXP(result);
					if (uml73GsQ3CUHSZaAi8Ba(text) >= 2)
					{
						num = 17;
						continue;
					}
					goto IL_0090;
				case 4:
				case 16:
					if (c == '>')
					{
						num = 19;
						continue;
					}
					return;
				case 5:
					text = result.consume(1, ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 21;
					if (true)
					{
						continue;
					}
					goto case 9;
				case 9:
					if (c != '+')
					{
						num = 1;
						continue;
					}
					goto case 19;
				case 18:
					if (!dntoaHsQMofhHMmJrqFa(text, x4lxJCsQOnNsodPCUMDe(56898)))
					{
						num = 13;
						if (WvoIUgsQxU4vCu2IDnaS())
						{
						}
						continue;
					}
					goto case 3;
				case 15:
					if (c != '=')
					{
						goto case 9;
					}
					goto case 19;
				default:
					num = 9;
					continue;
				case 10:
					if (c != '/')
					{
						num = 7;
						if (true)
						{
							continue;
						}
					}
					goto case 19;
				case 19:
					JlOXUcsQQfMBHLSsEg10(result, FoundFlags.FOUND_OPERATOR);
					num = 5;
					if (T0XVgPsQNaFkwk60tOx9())
					{
						continue;
					}
					goto case 1;
				case 1:
					if (c == '-')
					{
						goto case 19;
					}
					num = 20;
					if (0 == 0)
					{
						continue;
					}
					goto case 17;
				case 17:
					if (!dntoaHsQMofhHMmJrqFa(text, x4lxJCsQOnNsodPCUMDe(56882)) && !text.StartsWith((string)x4lxJCsQOnNsodPCUMDe(56890)))
					{
						num = 18;
						continue;
					}
					goto case 3;
				case 7:
					if (c != '%')
					{
						num = 2;
						continue;
					}
					goto case 19;
				case 6:
					if (dntoaHsQMofhHMmJrqFa(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(56930)))
					{
						num = 3;
						continue;
					}
					goto IL_0090;
				case 11:
					if (text.StartsWith((string)x4lxJCsQOnNsodPCUMDe(56914)) || dntoaHsQMofhHMmJrqFa(text, x4lxJCsQOnNsodPCUMDe(56922)))
					{
						goto case 3;
					}
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 13;
				case 13:
					if (!dntoaHsQMofhHMmJrqFa(text, x4lxJCsQOnNsodPCUMDe(56906)))
					{
						num = 11;
						if (T0XVgPsQNaFkwk60tOx9())
						{
							continue;
						}
						return;
					}
					goto case 3;
				case 21:
					return;
					IL_0090:
					c = text[0];
					num = 15;
					continue;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsInFixToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fFgS2TsQeWu7Q5SMNuwB();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J3viVHsQ1jLCYH0F6W0i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowInFix;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ob2WlDsQrADDWoYNUJXP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int uml73GsQ3CUHSZaAi8Ba(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x4lxJCsQOnNsodPCUMDe(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dntoaHsQMofhHMmJrqFa(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JlOXUcsQQfMBHLSsEg10(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eHEe29sQl8O0NFsebTTH(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T0XVgPsQNaFkwk60tOx9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WvoIUgsQxU4vCu2IDnaS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fFgS2TsQeWu7Q5SMNuwB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsCellToken : CvsToken
	{
		private int lQBmrdrCHm;

		private int ExWmCSrJkl;

		private int DH6m2BH914;

		private int AJ4myGqmTj;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = Math.Abs(AJ4myGqmTj - ExWmCSrJkl) + 1;
			int num2 = oFscVrsQRD9SrDA6gDPS(DH6m2BH914 - lQBmrdrCHm) + 1;
			return num * num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					return;
				case 2:
				case 4:
					if (HU9TXssQGYtoGyhdIdnI(text, 0) == ':')
					{
						goto case 1;
					}
					return;
				default:
					num = 1;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					text = (string)bEtuaPsQXTJ4uD1H5JMA(result, 1, ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL | ParseFlags.ALLOW_TOKEN_MATCH);
					num = 7;
					break;
				case 3:
				case 6:
					if (V0ni5YsQnlUqZIEajPwS(text) > 0)
					{
						goto case 2;
					}
					return;
				case 8:
					if (result.AllowCellRange)
					{
						num = 9;
						break;
					}
					return;
				case 9:
					text = (string)GVb43KsQaPIXtgTHCowt(result);
					D6eNpAsQIu4L3TeGEHso();
					if (!pEddkbsQuUnFxE2Rmxsg())
					{
						num = 2;
						break;
					}
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					parseCell(result, (ParseFlags)0);
					num = 8;
					if (D6eNpAsQIu4L3TeGEHso())
					{
					}
					break;
				case 7:
					if (text != null)
					{
						parseCell(result, ParseFlags.ALLOW_TOKEN_MATCH);
						num = 10;
					}
					else
					{
						num = 5;
					}
					break;
				case 10:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void parseCell(CvsParse result, ParseFlags match)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 28;
			string text = default;
			if (true)
			{
				int num2 = default;
				bool flag2 = default;
				bool flag = default;
				int num4 = default;
				int num3 = default;
				int numChars = default;
				char c = default;
				int num7 = default;
				int num5 = default;
				ParseFlags parseFlags2 = default;
				ParseFlags parseFlags = default;
				ParseFlags parseFlags3 = default;
				while (true)
				{
					int num6;
					switch (num)
					{
					case 7:
						break;
					case 18:
						AJ4myGqmTj = num2;
						num = 24;
						if (0 == 0)
						{
							continue;
						}
						goto case 11;
					case 11:
						if (V0ni5YsQnlUqZIEajPwS(text) > 0)
						{
							num = 15;
							continue;
						}
						return;
					case 5:
						flag2 = false;
						flag = false;
						num = 14;
						continue;
					case 24:
						DH6m2BH914 = num4;
						num = 29;
						continue;
					case 13:
					{
						num2 = CnxTableLocation.ColumnFromString((string)cbwhnJsQf9ct0HVMGyeO(text, 0, num3), 0, out var _, out numChars);
						num = 23;
						continue;
					}
					case 36:
						return;
					case 20:
						if (c == '0')
						{
							num = 0;
							continue;
						}
						goto IL_002c;
					case 23:
						text = result.consume(numChars, ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_CELL_ABS | match);
						num = 25;
						if (D6eNpAsQIu4L3TeGEHso())
						{
						}
						continue;
					case 0:
						m7OSAdsQ0vDJtXWUaSwp(result, FoundFlags.FOUND_CELL);
						num = 7;
						if (pEddkbsQuUnFxE2Rmxsg())
						{
							continue;
						}
						goto case 4;
					case 4:
					case 39:
						num6 = 0;
						goto IL_011a;
					case 37:
						flag2 = true;
						num = 8;
						continue;
					case 10:
						if (c == '$')
						{
							num = 37;
							if (pEddkbsQuUnFxE2Rmxsg())
							{
								continue;
							}
							return;
						}
						goto IL_00ab;
					case 32:
						return;
					case 12:
						m7OSAdsQ0vDJtXWUaSwp(result, FoundFlags.FOUND_CELL);
						num = 40;
						continue;
					case 14:
						if (pcIL12sQ6ufbH5oWvHQI(result))
						{
							num6 = 16777216;
							goto IL_011a;
						}
						_ = 1;
						num = (D6eNpAsQIu4L3TeGEHso() ? 35 : 39);
						continue;
					case 21:
						return;
					case 38:
						if (zPpMSPsQpKKoYLILvybt(result))
						{
							num = 20;
							continue;
						}
						goto IL_002c;
					case 33:
						if (num2 < 0)
						{
							return;
						}
						if (num2 < num7)
						{
							c = HU9TXssQGYtoGyhdIdnI(text, 0);
							num = 10;
						}
						else
						{
							num = 32;
						}
						continue;
					case 22:
						num5--;
						parseFlags2 &= ~ParseFlags.ALLOW_DIGIT;
						num = 31;
						continue;
					case 17:
						num7 = vQ6u5ysQkGM0S3iMxHm7(result);
						goto case 16;
					case 19:
					case 30:
						text = (string)bEtuaPsQXTJ4uD1H5JMA(result, num5, parseFlags2);
						num = 41;
						if (!D6eNpAsQIu4L3TeGEHso())
						{
							continue;
						}
						goto case 28;
					case 28:
						if (qIAjnCsQbXIeLnWIUAxC(result))
						{
							num = 34;
							continue;
						}
						return;
					case 29:
						Q69hAJsQ8jEN2BGsKmDm(result, num4, num2, bVCnlxsQJBso2NbjExvA(result) + num5, flag2, flag);
						num = 19;
						continue;
					case 15:
						c = HU9TXssQGYtoGyhdIdnI(text, 0);
						num = 38;
						continue;
					case 8:
						text = result.consume(1, ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH);
						if (text != null)
						{
							goto IL_00ab;
						}
						num = 36;
						if (true)
						{
							continue;
						}
						goto case 34;
					case 34:
						parseFlags = match;
						num = 5;
						if (D6eNpAsQIu4L3TeGEHso())
						{
						}
						continue;
					case 16:
					case 35:
						num3 = (num7 + 25) / 26;
						num = 13;
						if (true)
						{
							continue;
						}
						goto case 25;
					case 25:
						if (text == null)
						{
							return;
						}
						goto case 33;
					default:
						num = 33;
						continue;
					case 26:
						AJ4myGqmTj = num2;
						DH6m2BH914 = num4;
						result.AddCellReference(num4, num2, parseFlags3 != 0, result.hit3kXunJ1, bVCnlxsQJBso2NbjExvA(result) + num5, flag2, flag);
						num = 30;
						continue;
					case 27:
						lQBmrdrCHm = num4;
						num = 26;
						continue;
					case 1:
						if (num5 > 0)
						{
							parseFlags2 = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE | parseFlags3;
							num5 = rJMkwDsQmEHyVLZej74b(num5, 3);
							num = 6;
							continue;
						}
						return;
					case 2:
						if (CUr2SvsQ4NhmEuhCi7ef(c))
						{
							num = 3;
							continue;
						}
						return;
					case 9:
						if (c == '$')
						{
							flag = true;
							text = (string)bEtuaPsQXTJ4uD1H5JMA(result, 1, ParseFlags.ALLOW_CELL_COL | match | parseFlags3);
							if (text != null)
							{
								c = HU9TXssQGYtoGyhdIdnI(text, 0);
								num = 2;
							}
							else
							{
								num = 21;
							}
							continue;
						}
						goto case 2;
					case 6:
						num4 = jYDE8WsQgT8Mo9Pw1OsO(cbwhnJsQf9ct0HVMGyeO(text, 0, num5), fLpa1DsQyZYo2IGe4HW3());
						if (num4 >= result.TotalRows)
						{
							num = 22;
							continue;
						}
						goto case 31;
					case 31:
						if (num4 * 10 >= EBVLhXsQZqaWotcTLw36(result))
						{
							parseFlags2 &= ~ParseFlags.ALLOW_DIGIT;
							num = 12;
							continue;
						}
						goto case 12;
					case 3:
						KnemSWWQeT(text);
						num = 17;
						continue;
					case 40:
						if (parseFlags == 0)
						{
							ExWmCSrJkl = num2;
							num = 27;
							continue;
						}
						num = 18;
						if (1 == 0)
						{
							return;
						}
						continue;
					case 41:
						return;
						IL_00ab:
						num5 = a1E4dvsQFsOKxCx74Evy(text);
						num = 1;
						if (true)
						{
							continue;
						}
						goto case 20;
						IL_011a:
						parseFlags3 = (ParseFlags)num6;
						text = (string)GVb43KsQaPIXtgTHCowt(result);
						num = 11;
						continue;
						IL_002c:
						if (result.AllowCellAbs)
						{
							num = 9;
							continue;
						}
						goto case 2;
					}
					break;
				}
			}
			text = (string)bEtuaPsQXTJ4uD1H5JMA(result, 1, ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string bxpme8J7w2(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
				case 4:
					if (num2 >= num3)
					{
						break;
					}
					goto case 5;
				case 7:
					num3 = Math.Min(3, P_0.Length);
					num = 1;
					continue;
				case 3:
					num2 = 0;
					num = 7;
					continue;
				case 0:
					_ = string.Empty;
					num = 3;
					if (!D6eNpAsQIu4L3TeGEHso())
					{
						continue;
					}
					goto case 1;
				default:
					D6eNpAsQIu4L3TeGEHso();
					if (!pEddkbsQuUnFxE2Rmxsg())
					{
						num = 6;
						if (pEddkbsQuUnFxE2Rmxsg())
						{
							continue;
						}
						goto case 7;
					}
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
				case 6:
					if (hVGEpUsQzGdQS9herfMF(HU9TXssQGYtoGyhdIdnI(P_0, num2)))
					{
						num2++;
						goto default;
					}
					num = 8;
					continue;
				case 8:
					break;
				}
				break;
			}
			return (string)cbwhnJsQf9ct0HVMGyeO(P_0, 0, num2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string KnemSWWQeT(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (D6eNpAsQIu4L3TeGEHso() ? 9 : 5);
			int num2 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 8:
					if (num2 >= num3)
					{
						break;
					}
					goto case 1;
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					_ = string.Empty;
					num = 7;
					continue;
				case 7:
					num2 = 0;
					goto case 2;
				case 6:
					if (HU9TXssQGYtoGyhdIdnI(P_0, num2) != '_')
					{
						num = 4;
						if (pEddkbsQuUnFxE2Rmxsg())
						{
							continue;
						}
						goto case 3;
					}
					goto IL_00bf;
				case 2:
				case 9:
					num3 = V0ni5YsQnlUqZIEajPwS(P_0);
					num = 8;
					continue;
				case 4:
					if (HU9TXssQGYtoGyhdIdnI(P_0, num2) != '.')
					{
						num = 10;
						continue;
					}
					goto IL_00bf;
				case 1:
					if (!veFeMXslwFHSZMqI4Xwm(HU9TXssQGYtoGyhdIdnI(P_0, num2)))
					{
						num = 6;
						continue;
					}
					goto IL_00bf;
				case 10:
					break;
					IL_00bf:
					num2++;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				}
				break;
			}
			return (string)cbwhnJsQf9ct0HVMGyeO(P_0, 0, num2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsCellToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			T1X4oQslsQivcJ4fO0mV();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oFscVrsQRD9SrDA6gDPS(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Abs(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pEddkbsQuUnFxE2Rmxsg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D6eNpAsQIu4L3TeGEHso()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GVb43KsQaPIXtgTHCowt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int V0ni5YsQnlUqZIEajPwS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char HU9TXssQGYtoGyhdIdnI(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bEtuaPsQXTJ4uD1H5JMA(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qIAjnCsQbXIeLnWIUAxC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowCellRef;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pcIL12sQ6ufbH5oWvHQI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowCellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zPpMSPsQpKKoYLILvybt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowNullCell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void m7OSAdsQ0vDJtXWUaSwp(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CUr2SvsQ4NhmEuhCi7ef(char ch)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return isAlpha(ch);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vQ6u5ysQkGM0S3iMxHm7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).TotalColumns;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cbwhnJsQf9ct0HVMGyeO(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a1E4dvsQFsOKxCx74Evy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return parseInt((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rJMkwDsQmEHyVLZej74b(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Min(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fLpa1DsQyZYo2IGe4HW3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CultureInfo.InvariantCulture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int jYDE8WsQgT8Mo9Pw1OsO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return int.Parse((string)P_0, (IFormatProvider)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EBVLhXsQZqaWotcTLw36(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).TotalRows;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int bVCnlxsQJBso2NbjExvA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).eGy3FUKmsq();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q69hAJsQ8jEN2BGsKmDm(object P_0, int endRow, int endCol, int textEnd, bool absoluteLastRow, bool absoluteLastColumn)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).UpdateCellReference(endRow, endCol, textEnd, absoluteLastRow, absoluteLastColumn);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hVGEpUsQzGdQS9herfMF(char P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return char.IsLetter(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool veFeMXslwFHSZMqI4Xwm(char P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return char.IsLetterOrDigit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T1X4oQslsQivcJ4fO0mV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	internal class CvsFuncToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			string text2 = default;
			string text = default;
			int num4 = default;
			CvsFunction cvsFunction = default;
			ParseFlags allowed = default;
			FoundFlags foundFlags = default;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 13:
					text2 = (string)LgZlNkslvi2YR966DAZ4(text, 0, num4);
					cvsFunction = (CvsFunction)iyqBBtslHBKWvYZJ26Cw(result, text2);
					num = 22;
					break;
				case 6:
					text = (string)TxPB82slUkU7j63Q66jN(result, 1, MHHZ6gsljeVyio1GgbEA(result) | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE);
					num = 10;
					break;
				case 2:
					text = (string)TxPB82slUkU7j63Q66jN(result, tb7EjWslD7uBafAB1vXE(text2), allowed);
					num = 23;
					break;
				case 20:
					if (!WRVmQVsldm2lKi6p8d7m(cvsFunction))
					{
						num = 0;
						break;
					}
					goto IL_00bb;
				case 17:
					vQwhFqslBBvMyJvino4E(result, cvsFunction);
					num = 6;
					break;
				case 5:
					foundFlags |= FoundFlags.FOUND_STRUCTURE;
					goto IL_00bb;
				case 19:
					if (cvsFunction.MinNumberOfArgs == 0)
					{
						num = 15;
						break;
					}
					goto IL_005d;
				case 26:
					num4 = ParseIdentifier(text);
					num = 11;
					break;
				case 23:
					if (text != null && UV74qJslTtQcRtkWwbtL(text, 0) == '(')
					{
						_ = 0;
						if (uttxGFslhQ4oYUHM9eSh())
						{
							num = 3;
							break;
						}
						num = 1;
						if (uttxGFslhQ4oYUHM9eSh())
						{
							break;
						}
						goto case 16;
					}
					return;
				case 18:
					text = (string)D7NOUeslSn7AiYekqSRK(result);
					num = 4;
					break;
				case 8:
					if (GLaduLsl9Ocqbeuv1wgG(result))
					{
						num = 18;
						break;
					}
					return;
				case 11:
					if (num4 > 0)
					{
						num = 13;
						break;
					}
					return;
				case 14:
					num = 25;
					if (uttxGFslhQ4oYUHM9eSh())
					{
						break;
					}
					goto case 21;
				case 21:
					if (num2 == 0)
					{
						ah8wUOsl2sU8Wwbn9PwT(result, cvsFunction);
						num = 7;
						break;
					}
					goto case 7;
				case 3:
				case 12:
					foundFlags = FoundFlags.FOUND_FUNCTION;
					goto case 20;
				default:
					num = 20;
					if (0 == 0)
					{
						break;
					}
					goto case 22;
				case 22:
					if (cvsFunction != null)
					{
						if (UTmEJYslV13QAAyBwYIO(cvsFunction, result))
						{
							num = 19;
							if (!uttxGFslhQ4oYUHM9eSh())
							{
								return;
							}
							break;
						}
						return;
					}
					num3 = dgNNBLsl7O73ZvtFTFHP(result, text);
					goto case 1;
				case 25:
					return;
				case 16:
					if (!BA43SGslAUUUbZoe0u3a(cvsFunction))
					{
						goto IL_00bb;
					}
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 24:
					if (num3 > 0)
					{
						text = (string)TxPB82slUkU7j63Q66jN(result, num3, ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_STRUCT | ParseFlags.ALLOW_STRFUNC);
						num = 27;
						break;
					}
					return;
				case 0:
					if (iDR9tJslicnl67T0TxGk(cvsFunction))
					{
						num = 16;
						break;
					}
					goto IL_00bb;
				case 9:
					allowed = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
					num = 2;
					break;
				case 10:
					yUroDBslcx9UFAvAAO42(result, num2);
					num = 21;
					break;
				case 4:
					num2 = JUCRSOslERSfcQekPofc(result);
					num = 26;
					if (uttxGFslhQ4oYUHM9eSh())
					{
						break;
					}
					goto case 7;
				case 7:
					MV1Do9slWB2ggEER0KOd(result, JUCRSOslERSfcQekPofc(result));
					num = 14;
					if (0 == 0)
					{
						break;
					}
					goto case 15;
				case 15:
					if (!BA43SGslAUUUbZoe0u3a(cvsFunction))
					{
						num = 9;
						break;
					}
					goto IL_005d;
				case 27:
					return;
					IL_00bb:
					KgfSKJslqPb5BuVecTNE(result, foundFlags);
					num = 17;
					break;
					IL_005d:
					allowed = (result.AllowedFlags | ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_TOKEN_MATCH) & ~ParseFlags.ALLOW_TOKEN_COMPLETE;
					goto case 2;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsFuncToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GLaduLsl9Ocqbeuv1wgG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).AllowAnyFunction;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D7NOUeslSn7AiYekqSRK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int JUCRSOslERSfcQekPofc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).eGy3FUKmsq();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LgZlNkslvi2YR966DAZ4(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iyqBBtslHBKWvYZJ26Cw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).FindFunction((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UTmEJYslV13QAAyBwYIO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsFunctionTable.IsValidFunction((CvsFunction)P_0, (CvsParse)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BA43SGslAUUUbZoe0u3a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).PropertySheetEdit;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int tb7EjWslD7uBafAB1vXE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TxPB82slUkU7j63Q66jN(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char UV74qJslTtQcRtkWwbtL(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WRVmQVsldm2lKi6p8d7m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).StringFunction;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iDR9tJslicnl67T0TxGk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Structure;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KgfSKJslqPb5BuVecTNE(object P_0, FoundFlags P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).IjgWZKfi8i(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vQwhFqslBBvMyJvino4E(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).addLevel((CvsFunction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ParseFlags MHHZ6gsljeVyio1GgbEA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).getArgAllowed();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yUroDBslcx9UFAvAAO42(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).KdLWy4ZJOC(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ah8wUOsl2sU8Wwbn9PwT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).iqkW2rBEoF((CvsFunction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MV1Do9slWB2ggEER0KOd(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).X21WCHZnYb(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dgNNBLsl7O73ZvtFTFHP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).getFunctionMatch((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uttxGFslhQ4oYUHM9eSh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EolpoSslLud7BPgwBPmv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	internal class CvsSymbolicTagToken : CvsToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int getExprStack()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void parse(CvsParse result)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!GsaOA0sltypG7fw5W5DN())
			{
				goto IL_001e;
			}
			goto IL_005a;
			IL_001e:
			string text2 = default;
			int num2 = default;
			string text = (string)XdE8qpslo9K38VmOl5ic(text2, 0, num2);
			num = 11;
			goto IL_005a;
			IL_005a:
			bool flag = default;
			IEnumerator<INamedOperand> enumerator = default;
			ParseFlags allowed2 = default;
			ParseFlags allowed = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
					if (result.Dj93WY83hn != null)
					{
						num = 0;
						continue;
					}
					return;
				case 9:
					flag = false;
					break;
				default:
					num = 4;
					continue;
				case 3:
				case 7:
					qgsZPHsl58VCiEyjAYwg(result);
					num2 = jbEmVUeKqG(text2);
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					enumerator = result.Dj93WY83hn.GetEnumerator();
					num = 12;
					continue;
				case 8:
					if (num2 > 0)
					{
						num = 9;
						continue;
					}
					return;
				case 2:
				case 5:
					text2 = (string)O0pY6uslKbkCMXNBQiSY(result);
					goto case 3;
				case 11:
					enumerator = result.Dj93WY83hn.GetEnumerator();
					num = 10;
					continue;
				case 0:
					if (!result.AllowCellRef)
					{
						return;
					}
					_ = 1;
					if (AfLiVGslCLYRfRJFqJbU())
					{
						num = 7;
						if (AfLiVGslCLYRfRJFqJbU())
						{
						}
					}
					else
					{
						num = 5;
					}
					continue;
				case 10:
					try
					{
						while (enumerator.MoveNext())
						{
							INamedOperand current = enumerator.Current;
							int num4 = 6;
							if (false)
							{
								goto IL_0153;
							}
							goto IL_019c;
							IL_022c:
							text2 = (string)u2rYAdslxCh8b4rkd0Rn(result, num2, allowed2);
							num4 = 3;
							if (false)
							{
								return;
							}
							goto IL_019c;
							IL_019c:
							while (true)
							{
								switch (num4)
								{
								case 0:
									break;
								default:
									num4 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto IL_01d1;
								case 6:
									goto IL_01d1;
								case 1:
								case 5:
									flag = true;
									num4 = 0;
									continue;
								case 7:
									goto IL_0205;
								case 3:
									goto IL_021c;
								case 2:
								case 4:
									goto IL_022c;
								case 8:
									return;
								}
								break;
								IL_021c:
								if (text2 == null)
								{
									num4 = 8;
									continue;
								}
								goto IL_0247;
								IL_01d1:
								if (((string)WVPIS8slPgSkywsPvqec(current)).Equals(text))
								{
									_ = 0;
									num4 = ((!GsaOA0sltypG7fw5W5DN()) ? 2 : 5);
									continue;
								}
								goto IL_0247;
							}
							goto IL_0153;
							IL_0153:
							c0cxvlslNVEDgDR6YXmW(result, FvHxn6slYrbZS5UhDB24(current).Row, FvHxn6slYrbZS5UhDB24(current).Column, false, result.hit3kXunJ1, result.eGy3FUKmsq() + num2, true, true);
							goto IL_0205;
							IL_0205:
							allowed2 = ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_INFIXOP | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TEXT | ParseFlags.ALLOW_TOKEN_MATCH | ParseFlags.ALLOW_TOKEN_COMPLETE;
							goto IL_022c;
							IL_0247:;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							XTtMDYsl18SfLGIyqrY2(enumerator);
						}
					}
					if (!flag)
					{
						num = 6;
						continue;
					}
					return;
				case 12:
					try
					{
						while (enumerator.MoveNext())
						{
							if (!tkI78HslrgloJNDKWN2G(enumerator.Current.Name, text))
							{
								continue;
							}
							_ = 0;
							int num3;
							if (GsaOA0sltypG7fw5W5DN())
							{
								num3 = 3;
							}
							else
							{
								num3 = 2;
								if (false)
								{
									goto IL_02d2;
								}
							}
							goto IL_02ee;
							IL_02a9:
							if (text2 != null)
							{
								continue;
							}
							num3 = 5;
							goto IL_02ee;
							IL_02ee:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 0:
								case 3:
									allowed = ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_TEXT;
									goto IL_02d2;
								case 1:
								case 2:
									goto IL_02d2;
								default:
									num3 = 4;
									continue;
								case 5:
									return;
								}
								break;
							}
							goto IL_02a9;
							IL_02d2:
							text2 = (string)u2rYAdslxCh8b4rkd0Rn(result, num2, allowed);
							goto IL_02a9;
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							XTtMDYsl18SfLGIyqrY2(enumerator);
						}
					}
				}
				break;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int jbEmVUeKqG(string P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AfLiVGslCLYRfRJFqJbU();
			int num = ((!GsaOA0sltypG7fw5W5DN()) ? 6 : 7);
			char c = default;
			int num2 = default;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 8:
					if (c == '_')
					{
						goto IL_002d;
					}
					goto case 10;
				default:
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
				case 6:
					if (num2 < QIiX07sl3AcZxYI7K5b1(P_0))
					{
						c = K3ND5pslOUHESInHqh2x(P_0, num2);
						num = 9;
						break;
					}
					num = 11;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					num2 = 0;
					goto case 2;
				case 0:
				case 7:
					result = QIiX07sl3AcZxYI7K5b1(P_0);
					num = 3;
					if (true)
					{
						break;
					}
					goto case 9;
				case 9:
					if (!bH62MmslMecAbvYgMI9j(c))
					{
						num = 8;
						break;
					}
					goto IL_002d;
				case 1:
					result = num2;
					num = 5;
					break;
				case 10:
					if (c != '.')
					{
						num = 1;
						break;
					}
					goto IL_002d;
				case 5:
				case 11:
					{
						return result;
					}
					IL_002d:
					num2++;
					num = 4;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsSymbolicTagToken()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sFeVUnslQ2MelLKAm8ND();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O0pY6uslKbkCMXNBQiSY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).QA131nsx2t();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int qgsZPHsl58VCiEyjAYwg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).eGy3FUKmsq();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XdE8qpslo9K38VmOl5ic(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WVPIS8slPgSkywsPvqec(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((INamedOperand)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation FvHxn6slYrbZS5UhDB24(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((INamedOperand)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c0cxvlslNVEDgDR6YXmW(object P_0, int startRow, int startCol, bool rangeAllowed, int textStart, int textEnd, bool absoluteRow, bool absoluteColumn)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsParse)P_0).AddCellReference(startRow, startCol, rangeAllowed, textStart, textEnd, absoluteRow, absoluteColumn);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u2rYAdslxCh8b4rkd0Rn(object P_0, int chars, ParseFlags allowed)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).consume(chars, allowed);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XTtMDYsl18SfLGIyqrY2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tkI78HslrgloJNDKWN2G(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GsaOA0sltypG7fw5W5DN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AfLiVGslCLYRfRJFqJbU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int QIiX07sl3AcZxYI7K5b1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char K3ND5pslOUHESInHqh2x(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bH62MmslMecAbvYgMI9j(char P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return char.IsLetterOrDigit(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sFeVUnslQ2MelLKAm8ND()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public string expression;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass187_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zpJlCDsluORThZmlSJpN();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CFindAllArgs_003Eb__0(int argIndex)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)X39ggwslITeYlvJkRaKy(expression, argIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zpJlCDsluORThZmlSJpN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PpupxJsllu8Gn1raC8gP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UplkXLslelJOAUUZkwRI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X39ggwslITeYlvJkRaKy(object P_0, int argIndex)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FindArg((string)P_0, argIndex);
		}
	}

	private static CvsLabelToken RXN3a4sKdE;

	private static CvsUnaryToken SKl3OgNylN;

	private static CvsNumberToken sU53pYMEee;

	private static CvsInFixToken sIY3hu1wMd;

	private static CvsOpenParenToken QNC34XJoFR;

	private static CvsCloseParenToken Nxv3l1CHmh;

	private static CvsCommaToken eSP3gCPkmR;

	private static CvsFuncToken pbs3qTds1e;

	private static CvsStringToken PST3TDTQMS;

	private static CvsSymbolicTagToken Pes3BLBbHx;

	private static CvsCellToken LrF3J5jGw0;

	private CvsToken[] jQa3MCWNES;

	private readonly CvsFunctionTable NI43oh5OPs;

	private readonly IExpressionConstants d4b3AREpns;

	private int cB03t1fGnm;

	private readonly INamedOperandCollection Dj93WY83hn;

	private readonly Func<CvsFunction, bool> wAG33tCtTE;

	private int m4l3LBx5HQ;

	private int hit3kXunJ1;

	private int MVY3XSvFxL;

	private Stack tye3fZ0uCy;

	private CvsFuncStack ooB3jxBS4K;

	private int yFh3c0yZpL;

	private ParseFlags CUc35y2ksU;

	private CvsFunction EVZ3Y9a2rZ;

	private int g5m37racF0;

	private ParseFlags R8D3mytdDp;

	private CvsFunction Ntg3nboq0q;

	private int lNA39TfmtN;

	private readonly bool pZ63UIFmxq;

	private bool Tgu30mRa3S;

	private FoundFlags wyN3wyUnrU;

	private ParseFlags veZ3Riw9M7;

	private ParseFlags jLo3sy2FjS;

	private CvsFunction D9H36EsejS;

	private readonly List<CellRefRange> L7X3HNC5AD;

	private readonly string y6Z3KFGCJI;

	private readonly string tcM3EMNmDc;

	private CellRefRange[] Dn63QHMwSe;

	private int d2f3NcWNm2;

	[CompilerGenerated]
	private CvsParseTokenRange[] KMR3iYTLx3;

	public static readonly int MaxDigitsBeforeDecimal;

	public static readonly int MaxDigitsAfterDecimal;

	public CellRefRange[] CellReferences
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dn63QHMwSe;
		}
	}

	public CvsParseTokenRange[] TokenRanges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KMR3iYTLx3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KMR3iYTLx3 = value;
		}
	}

	public INamedOperandCollection SymbolicTags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dj93WY83hn;
		}
	}

	public int CursorPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cB03t1fGnm;
		}
	}

	public ParseFlags AllowedFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return veZ3Riw9M7;
		}
	}

	internal CvsToken[] Tokens
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jQa3MCWNES;
		}
	}

	internal int TotalRows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M7IP0an37gKLI5XQEaZ(d4b3AREpns);
		}
	}

	internal int TotalColumns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bvwbymnOs88dHSdR1wY(d4b3AREpns);
		}
	}

	internal bool TokenMatch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_TOKEN_MATCH) != 0;
		}
	}

	public string FinishedExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (!Tgu30mRa3S)
					{
						break;
					}
					goto default;
				default:
					text = (string)mnNk9LnMMhW0yeIJdCl(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(17520));
					num = 5;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto case 3;
				case 3:
					text = Expression;
					_ = 1;
					num = (pqodTQnP9l2borBA1Fb() ? 4 : 0);
					continue;
				case 5:
					break;
				}
				break;
			}
			return text;
		}
	}

	public string Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tcM3EMNmDc;
		}
	}

	public CvsFunction Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D9H36EsejS;
		}
	}

	public string CursorExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y6Z3KFGCJI;
		}
	}

	public string CompareString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)CJ3tyCnQCgOgNxL0Hu9(Ii5qRLnrFNcaqlnw03G(y6Z3KFGCJI, hit3kXunJ1));
		}
	}

	public CvsFunction CurrentFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!pqodTQnP9l2borBA1Fb())
			{
				num = 4;
				if (pqodTQnP9l2borBA1Fb())
				{
				}
			}
			else
			{
				num = 1;
			}
			CvsFunction result = default;
			while (true)
			{
				switch (num)
				{
				default:
					result = (CvsFunction)scaE2KnloIaxWgMdkxl(ooB3jxBS4K);
					num = 5;
					continue;
				case 0:
				case 4:
					result = null;
					num = 3;
					continue;
				case 3:
					if (ooB3jxBS4K == null)
					{
						break;
					}
					goto default;
				case 5:
					break;
				}
				break;
			}
			return result;
		}
	}

	public int ArgIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					result = -1;
					y1KmIwnodLGC18Cx0pt();
					if (!pqodTQnP9l2borBA1Fb())
					{
						num = 0;
						continue;
					}
					num = 3;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto default;
				case 0:
				case 1:
					if (ooB3jxBS4K == null)
					{
						break;
					}
					goto default;
				default:
					result = ooB3jxBS4K.ArgIndex;
					num = 5;
					if (pqodTQnP9l2borBA1Fb())
					{
					}
					continue;
				case 5:
					break;
				}
				break;
			}
			return result;
		}
	}

	public bool TooComplex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return getExprStack() >= d4b3AREpns.MaxExpressionStack;
		}
	}

	public bool AllowSheetFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_SHEET_FUNC) != 0;
		}
	}

	public bool AllowPropertyFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_PROP_FUNC) != 0;
		}
	}

	public bool AllowOK
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_OK) != 0;
		}
	}

	public bool AllowNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_NUMBER) != 0;
		}
	}

	public bool AllowText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_TEXT) != 0;
		}
	}

	public bool AllowDigit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_DIGIT) != 0;
		}
	}

	public bool AllowPeriod
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_PERIOD) != 0;
		}
	}

	public bool AllowUnary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_UNARYOP) != 0;
		}
	}

	public bool AllowSingleQuote
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_SINGLE_QUOTE) != 0;
		}
	}

	public bool AllowDoubleQuote
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_DOUBLE_QUOTE) != 0;
		}
	}

	public bool AllowInFix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_INFIXOP) != 0;
		}
	}

	public bool AllowNextToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_TOKEN_COMPLETE) != 0;
		}
	}

	public bool AllowCellRef
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & (ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL)) != 0;
		}
	}

	public bool AllowCellPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_CELL_POS) != 0;
		}
	}

	public bool AllowNullCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_NULL_CELL) != 0;
		}
	}

	public bool AllowCellRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_CELL_RANGE) != 0;
		}
	}

	public bool AllowCellAbs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_CELL_ABS) != 0;
		}
	}

	public bool AllowComma
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_COMMA) != 0;
		}
	}

	public bool AllowOpenParen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_OPEN_PAREN) != 0;
		}
	}

	public bool AllowCloseParen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_CLOSE_PAREN) != 0;
		}
	}

	public bool AllowAnyFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & (ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_STRFUNC)) != 0;
		}
	}

	public bool AllowFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_FUNC) != 0;
		}
	}

	public bool AllowStructure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_STRUCT) != 0;
		}
	}

	public bool AllowStringFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (veZ3Riw9M7 & ParseFlags.ALLOW_STRFUNC) != 0;
		}
	}

	public int FunctionPos
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!pqodTQnP9l2borBA1Fb())
			{
				num = 4;
				if (!y1KmIwnodLGC18Cx0pt())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0047;
			IL_0082:
			int result = Csc6Utna26bCEprD0RS(ooB3jxBS4K);
			num = 5;
			goto IL_0047;
			IL_0098:
			return result;
			IL_002a:
			if (ooB3jxBS4K != null)
			{
				goto IL_0082;
			}
			goto IL_0098;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 4:
					result = -1;
					num = 3;
					if (true)
					{
						continue;
					}
					goto IL_0082;
				default:
					goto IL_0082;
				case 5:
					goto IL_0098;
				}
				break;
			}
			goto IL_002a;
		}
	}

	public bool IsWellFormed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = Ys6rClneL0jToh4e8RT(Expression);
			if (num != 0)
			{
				return LastValidPosition == num;
			}
			return false;
		}
	}

	public int LastValidPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d2f3NcWNm2;
		}
	}

	public ExpressionTypes ExpressionType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 11;
			ExpressionTypes result = default;
			FoundFlags foundFlags = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					result = ExpressionTypes.ConstantString;
					break;
				case 9:
					result = ExpressionTypes.ConstantNumber;
					break;
				default:
					num = 2;
					continue;
				case 7:
					if (foundFlags == FoundFlags.FOUND_LABEL)
					{
						goto case 3;
					}
					switch (foundFlags)
					{
					default:
						num = 0;
						continue;
					case FoundFlags.FOUND_NUMBER:
						break;
					case FoundFlags.FOUND_STRING:
						num = 3;
						continue;
					}
					goto case 9;
				case 1:
				case 5:
					foundFlags = getFoundFlags();
					num = 7;
					continue;
				case 12:
					result = ExpressionTypes.SpreadsheetFunction;
					num = 4;
					continue;
				case 0:
					switch (foundFlags)
					{
					case FoundFlags.FOUND_CELL:
						num = 6;
						continue;
					case FoundFlags.FOUND_NUMBER | FoundFlags.FOUND_OPERATOR:
						num = 9;
						continue;
					}
					if ((foundFlags & (FoundFlags.FOUND_FUNCTION | FoundFlags.FOUND_STRUCTURE)) == (FoundFlags.FOUND_FUNCTION | FoundFlags.FOUND_STRUCTURE))
					{
						num = 12;
						continue;
					}
					result = ExpressionTypes.Expression;
					num = 13;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					break;
				case 6:
					result = ExpressionTypes.CellReference;
					break;
				case 11:
					result = ExpressionTypes.Empty;
					_ = 1;
					num = ((!pqodTQnP9l2borBA1Fb()) ? 5 : 10);
					continue;
				case 2:
				case 4:
				case 8:
				case 10:
				case 13:
					break;
				}
				break;
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AxjWSIRddy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (Nxv3l1CHmh == null)
				{
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 16;
				}
				goto case 0;
			case 16:
				sIY3hu1wMd = new CvsInFixToken();
				num = 9;
				continue;
			case 14:
				eSP3gCPkmR = new CvsCommaToken();
				goto IL_004c;
			case 8:
				pbs3qTds1e = new CvsFuncToken();
				num = 13;
				continue;
			case 0:
				if (eSP3gCPkmR == null)
				{
					num = 14;
					continue;
				}
				goto IL_004c;
			case 3:
				QNC34XJoFR = new CvsOpenParenToken();
				num = 6;
				if (pqodTQnP9l2borBA1Fb())
				{
				}
				continue;
			case 9:
				LrF3J5jGw0 = new CvsCellToken();
				if (QNC34XJoFR == null)
				{
					num = 3;
					continue;
				}
				goto case 6;
			case 7:
				sU53pYMEee = new CvsNumberToken();
				pqodTQnP9l2borBA1Fb();
				if (y1KmIwnodLGC18Cx0pt())
				{
					num = 18;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					goto case 5;
				}
				num = 15;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				if (Pes3BLBbHx == null)
				{
					num = 10;
					continue;
				}
				goto case 11;
			case 10:
				Pes3BLBbHx = new CvsSymbolicTagToken();
				num = 11;
				continue;
			case 19:
				SKl3OgNylN = new CvsUnaryToken();
				goto IL_0120;
			case 1:
				if (RXN3a4sKdE == null)
				{
					num = 12;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					goto case 12;
				}
				goto IL_0158;
			case 12:
				RXN3a4sKdE = new CvsLabelToken();
				goto IL_0158;
			case 13:
				if (PST3TDTQMS == null)
				{
					PST3TDTQMS = new CvsStringToken();
					num = 5;
					continue;
				}
				goto case 5;
			case 2:
				Nxv3l1CHmh = new CvsCloseParenToken();
				goto case 0;
			default:
				num = 0;
				continue;
			case 4:
			case 18:
				if (sIY3hu1wMd == null)
				{
					num = 16;
					continue;
				}
				goto case 9;
			case 11:
				jQa3MCWNES = new CvsToken[11]
				{
					RXN3a4sKdE, sU53pYMEee, SKl3OgNylN, QNC34XJoFR, eSP3gCPkmR, Pes3BLBbHx, LrF3J5jGw0, sIY3hu1wMd, Nxv3l1CHmh, pbs3qTds1e,
					PST3TDTQMS
				};
				break;
			case 15:
			case 17:
				break;
			case 20:
				return;
				IL_0158:
				if (SKl3OgNylN == null)
				{
					num = 19;
					continue;
				}
				goto IL_0120;
				IL_0120:
				if (sU53pYMEee == null)
				{
					num = 7;
					continue;
				}
				goto case 4;
				IL_004c:
				if (pbs3qTds1e == null)
				{
					num = 8;
					continue;
				}
				goto case 13;
			}
			tye3fZ0uCy = new Stack();
			num = 20;
			if (pqodTQnP9l2borBA1Fb())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddCellReference(int startRow, int startCol, bool rangeAllowed, int textStart, int textEnd, bool absoluteRow, bool absoluteColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CellRefRange item = new CellRefRange(new CvsCellRange(startRow, startCol, 1, 1), n8mLHAnYh2J90hlnV4w(L7X3HNC5AD), rangeAllowed, textStart, textEnd, absoluteRow, absoluteColumn, absoluteRow, absoluteColumn);
		L7X3HNC5AD.Add(item);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void UpdateCellReference(int endRow, int endCol, int textEnd, bool absoluteLastRow, bool absoluteLastColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellLocation[] array = default;
		CvsCellLocation cvsCellLocation = default;
		CellRefRange cellRefRange = default;
		CvsCellRange cvsCellRange = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (n8mLHAnYh2J90hlnV4w(L7X3HNC5AD) > 0)
				{
					y1KmIwnodLGC18Cx0pt();
					num = ((!pqodTQnP9l2borBA1Fb()) ? 8 : 0);
					continue;
				}
				return;
			case 5:
				if (array[1].GetHashCode() >= array[0].GetHashCode())
				{
					break;
				}
				cvsCellLocation = array[0];
				num = 2;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				goto case 9;
			case 9:
				cellRefRange.AbsoluteLastColumn = absoluteLastColumn;
				num = 13;
				continue;
			case 10:
				cvsCellRange = mCstuQnNJKjTjomcNCF(cellRefRange);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				cellRefRange.AbsoluteLastRow = absoluteLastRow;
				num = 9;
				continue;
			case 7:
				array = new CvsCellLocation[2]
				{
					cvsCellRange.Location,
					new CvsCellLocation(endRow, endCol)
				};
				num = 5;
				continue;
			case 1:
			case 8:
				cellRefRange = L7X3HNC5AD[n8mLHAnYh2J90hlnV4w(L7X3HNC5AD) - 1];
				num = 10;
				continue;
			case 12:
				HB8emgn1ydT3efKP6FH(cellRefRange, textEnd);
				num = 11;
				if (pqodTQnP9l2borBA1Fb())
				{
				}
				continue;
			case 2:
				array[0] = array[1];
				goto default;
			default:
				array[1] = cvsCellLocation;
				num = 3;
				continue;
			case 3:
				break;
			case 13:
				return;
			}
			QWXAnZnxys9WxWEpxAv(cellRefRange, new CvsCellRange(array[0], array[1]));
			num = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private string QA131nsx2t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Ii5qRLnrFNcaqlnw03G(y6Z3KFGCJI, m4l3LBx5HQ);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private int eGy3FUKmsq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return m4l3LBx5HQ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsParse(CvsFunctionTable funcTable, IExpressionConstants exprConst, string expr, int cursor, CvsFunction fd, int argIndex, INamedOperandCollection namedOperands, Func<CvsFunction, bool> isValidFunction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		cB03t1fGnm = -1;
		lNA39TfmtN = -1;
		L7X3HNC5AD = new List<CellRefRange>();
		base._002Ector();
		AxjWSIRddy();
		NI43oh5OPs = funcTable;
		d4b3AREpns = exprConst;
		tcM3EMNmDc = expr;
		cB03t1fGnm = Math.Min(expr.Length, cursor);
		y6Z3KFGCJI = expr.Substring(0, cB03t1fGnm);
		pZ63UIFmxq = fd != null;
		Dj93WY83hn = namedOperands;
		wAG33tCtTE = isValidFunction;
		if (fd != null)
		{
			ooB3jxBS4K = new CvsFuncStack(fd, argIndex);
			veZ3Riw9M7 = getArgAllowed();
		}
		else
		{
			veZ3Riw9M7 = ParseFlags.ALLOW_SINGLE_QUOTE | ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_STRUCT | ParseFlags.ALLOW_STRFUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
		}
		veZ3Riw9M7 |= ParseFlags.ALLOW_SHEET_FUNC;
		if (!pZ63UIFmxq)
		{
			veZ3Riw9M7 |= ParseFlags.ALLOW_PROP_FUNC;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsParse Parse(CvsFunctionTable functionTable, IExpressionConstants expressionConstants, string expression, int cursor, CvsFunction function = null, int argIndex = -1, INamedOperandCollection namedOperands = null, Func<CvsFunction, bool> isValidFunction = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsParse cvsParse = n2QWrTtSL6(functionTable, expressionConstants, expression, cursor, function, argIndex, namedOperands, isValidFunction);
		cvsParse.cB03t1fGnm = cursor;
		CvsParse cvsParse2 = ((cursor != expression.Length) ? n2QWrTtSL6(functionTable, expressionConstants, expression, expression.Length, function, argIndex, namedOperands, isValidFunction) : cvsParse);
		cvsParse.HV9Wv4vnjB(cvsParse2.eGy3FUKmsq());
		cvsParse.mW3WzrjKVD(cvsParse2.getExprStack());
		cvsParse.iqkW2rBEoF(cvsParse2.Function);
		cvsParse.Dn63QHMwSe = cvsParse2.L7X3HNC5AD.ToArray();
		cvsParse.wyN3wyUnrU = cvsParse2.wyN3wyUnrU;
		if (cvsParse.LastValidPosition == expression.Length && ((function == null && cvsParse2.ooB3jxBS4K == null) || (function != null && cvsParse2.CurrentFunction == function)) && cvsParse2.tye3fZ0uCy.Count == 0 && cvsParse2.AllowNextToken && !cvsParse2.AllowNumber && !cvsParse2.AllowCellRef)
		{
			cvsParse.veZ3Riw9M7 |= ParseFlags.ALLOW_OK;
		}
		else if (cvsParse.LastValidPosition == expression.Length && cvsParse2.ooB3jxBS4K != null && cvsParse2.tye3fZ0uCy.Count == 0 && cvsParse2.AllowNextToken && cvsParse2.AllowCloseParen)
		{
			cvsParse.veZ3Riw9M7 |= ParseFlags.ALLOW_OK;
			cvsParse.Tgu30mRa3S = true;
		}
		if (cvsParse.TooComplex)
		{
			cvsParse.veZ3Riw9M7 &= ~ParseFlags.ALLOW_OK;
		}
		return cvsParse;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsParse n2QWrTtSL6(CvsFunctionTable P_0, IExpressionConstants P_1, string P_2, int P_3, CvsFunction P_4, int P_5, INamedOperandCollection P_6, Func<CvsFunction, bool> P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsParse cvsParse = new CvsParse(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7);
		int length = cvsParse.CursorExpression.Length;
		CvsToken[] tokens = cvsParse.Tokens;
		bool flag = false;
		List<CvsParseTokenRange> list = new List<CvsParseTokenRange>();
		bool flag2;
		do
		{
			cvsParse.trim();
			cvsParse.saveState();
			flag2 = false;
			int i;
			for (i = 0; i < tokens.Length; i++)
			{
				if (cvsParse.eGy3FUKmsq() >= length)
				{
					break;
				}
				if (flag)
				{
					break;
				}
				CvsToken cvsToken = tokens[i];
				cvsToken.parse(cvsParse);
				if (cvsParse.hasAdvanced())
				{
					flag2 = true;
					if (cvsParse.TokenMatch)
					{
						int num = cvsParse.yFh3c0yZpL;
						int num2 = cvsParse.m4l3LBx5HQ;
						list.Add(new CvsParseTokenRange
						{
							Type = cvsToken.GetType().Name,
							Start = num,
							End = num2,
							Text = cvsParse.Expression.Substring(num, num2 - num)
						});
						cvsParse.nh2W8Adxfb(cvsToken.getExprStack());
						cvsParse.s5p3PwOvve();
						break;
					}
					cvsParse.keepLooking();
				}
			}
			if (i == tokens.Length)
			{
				cvsParse.getBest();
			}
		}
		while ((!flag & flag2) && cvsParse.AllowNextToken);
		cvsParse.TokenRanges = list.ToArray();
		return cvsParse;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void trim()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!pqodTQnP9l2borBA1Fb())
		{
			num = 2;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_00b0;
		IL_0057:
		int num2 = default;
		m4l3LBx5HQ += num2;
		num = 8;
		goto IL_00b0;
		IL_00b0:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 6:
				goto IL_0057;
			case 0:
			case 2:
				text = QA131nsx2t();
				goto case 1;
			case 1:
			case 7:
				num2 = 0;
				num = 5;
				continue;
			case 3:
			case 5:
				goto IL_0092;
			default:
				num = 4;
				if (pqodTQnP9l2borBA1Fb())
				{
				}
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		if (kJugVVnuZfgO16gN3nE(text, num2) != ' ')
		{
			num = 6;
			if (pqodTQnP9l2borBA1Fb())
			{
				goto IL_0092;
			}
		}
		else
		{
			num2++;
			num = 3;
		}
		goto IL_00b0;
		IL_0092:
		if (num2 < Ys6rClneL0jToh4e8RT(text))
		{
			goto IL_0026;
		}
		goto IL_0057;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void saveState()
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
				g5m37racF0 = -1;
				_ = 0;
				num = ((!y1KmIwnodLGC18Cx0pt()) ? 4 : 3);
				break;
			default:
				yFh3c0yZpL = m4l3LBx5HQ;
				num = 5;
				break;
			case 1:
			case 3:
				CUc35y2ksU = veZ3Riw9M7;
				goto default;
			case 5:
				EVZ3Y9a2rZ = ooB3jxBS4K?.FD;
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void keepLooking()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (pqodTQnP9l2borBA1Fb() ? 9 : 8);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 8:
				if (m4l3LBx5HQ > g5m37racF0)
				{
					num = 10;
					break;
				}
				if (m4l3LBx5HQ == g5m37racF0)
				{
					num = 4;
					break;
				}
				goto case 7;
			case 1:
				if (ooB3jxBS4K != null)
				{
					num = 5;
					break;
				}
				return;
			case 7:
				m4l3LBx5HQ = yFh3c0yZpL;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				sYS0VPnIRDGD0YsQM9a(ooB3jxBS4K, EVZ3Y9a2rZ);
				num = 11;
				break;
			case 3:
				veZ3Riw9M7 = CUc35y2ksU;
				if (EVZ3Y9a2rZ != null)
				{
					num = 1;
					break;
				}
				return;
			case 6:
				Ntg3nboq0q = ooB3jxBS4K?.FD;
				goto case 7;
			case 4:
				R8D3mytdDp |= veZ3Riw9M7;
				goto case 7;
			default:
				num = 7;
				break;
			case 2:
			case 9:
				R8D3mytdDp = veZ3Riw9M7;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 10;
			case 10:
				g5m37racF0 = m4l3LBx5HQ;
				goto case 2;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void getBest()
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
			case 0:
			case 5:
				if (AllowAnyFunction)
				{
					num = 1;
					break;
				}
				return;
			case 6:
				if (g5m37racF0 > -1)
				{
					num = 2;
					break;
				}
				return;
			case 7:
			case 9:
				if (!pZ63UIFmxq)
				{
					num = 8;
					break;
				}
				return;
			case 8:
				veZ3Riw9M7 |= ParseFlags.ALLOW_PROP_FUNC;
				num = 11;
				break;
			case 4:
				veZ3Riw9M7 = R8D3mytdDp;
				goto default;
			default:
				pqodTQnP9l2borBA1Fb();
				if (y1KmIwnodLGC18Cx0pt())
				{
					num = 0;
					if (y1KmIwnodLGC18Cx0pt())
					{
						break;
					}
					goto case 3;
				}
				num = 9;
				break;
			case 3:
				if (ooB3jxBS4K != null)
				{
					num = 10;
					break;
				}
				goto case 4;
			case 10:
				ooB3jxBS4K.FD = Ntg3nboq0q;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				veZ3Riw9M7 |= ParseFlags.ALLOW_SHEET_FUNC;
				goto case 7;
			case 2:
				m4l3LBx5HQ = g5m37racF0;
				num = 3;
				if (pqodTQnP9l2borBA1Fb())
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool hasAdvanced()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return m4l3LBx5HQ > yFh3c0yZpL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int getArgPos()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (y1KmIwnodLGC18Cx0pt())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (pqodTQnP9l2borBA1Fb())
			{
				goto IL_003c;
			}
		}
		goto IL_0059;
		IL_0098:
		int result = default;
		return result;
		IL_0080:
		result = P6hUBUnRKaGwoZ99S0H(ooB3jxBS4K);
		num = 5;
		if (0 == 0)
		{
			goto IL_0059;
		}
		goto IL_0098;
		IL_0059:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				result = -1;
				break;
			case 1:
			case 3:
				break;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_0080;
			case 5:
				goto IL_0098;
			}
			break;
		}
		goto IL_003c;
		IL_003c:
		if (ooB3jxBS4K != null)
		{
			goto IL_0080;
		}
		goto IL_0098;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X21WCHZnYb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ooB3jxBS4K != null)
		{
			ooB3jxBS4K.ArgPos = P_0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iqkW2rBEoF(CvsFunction P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (D9H36EsejS == null)
		{
			D9H36EsejS = P_0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KdLWy4ZJOC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ooB3jxBS4K != null)
		{
			spQ7kEnn3o158s3snXK(ooB3jxBS4K, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int getStringPos()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return lNA39TfmtN;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ga8WVBB6da(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lNA39TfmtN = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HV9Wv4vnjB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		d2f3NcWNm2 = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal FoundFlags getFoundFlags()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wyN3wyUnrU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IjgWZKfi8i(FoundFlags P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 8:
				if (CJ5XqmnG4XXwBdcVUvf(tye3fZ0uCy) == 0)
				{
					goto case 0;
				}
				goto case 3;
			case 7:
				if (ooB3jxBS4K != null)
				{
					pqodTQnP9l2borBA1Fb();
					num = (y1KmIwnodLGC18Cx0pt() ? 6 : 0);
					break;
				}
				goto case 0;
			case 1:
			case 6:
				if (ooB3jxBS4K.FD != null)
				{
					num = 9;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				goto case 0;
			case 5:
				wyN3wyUnrU |= FoundFlags.FOUND_PAREN;
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				if (scaE2KnloIaxWgMdkxl(ooB3jxBS4K) == null)
				{
					num = 5;
					break;
				}
				return;
			case 0:
			case 4:
				wyN3wyUnrU |= P_0;
				goto case 3;
			default:
				num = 3;
				break;
			case 9:
				if (pZ63UIFmxq)
				{
					num = 8;
					if (true)
					{
						break;
					}
				}
				goto case 3;
			case 3:
				if (ooB3jxBS4K != null)
				{
					num = 2;
					break;
				}
				return;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal string consume(int chars, ParseFlags allowed)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 31;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_003f;
		IL_001a:
		CvsFunction cvsFunction = default;
		if (cvsFunction != null)
		{
			num = 9;
		}
		else if (ooB3jxBS4K == null)
		{
			allowed &= ~(ParseFlags.ALLOW_COMMA | ParseFlags.ALLOW_CLOSE_PAREN);
			num = 30;
		}
		else
		{
			num = 28;
		}
		goto IL_003f;
		IL_003f:
		int num2 = default;
		bool flag2 = default;
		bool flag = default;
		CvsFunctionArg arg = default;
		string result = default;
		string str = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 14:
				break;
			case 24:
				num2 = 0;
				goto case 35;
			default:
				num = 35;
				continue;
			case 19:
				if ((allowed & ParseFlags.ALLOW_TOKEN_COMPLETE) != 0)
				{
					num = 22;
					continue;
				}
				goto case 12;
			case 20:
				if (chars > 0)
				{
					num = 8;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto case 5;
				}
				goto IL_02c4;
			case 25:
				if (ArgIndex < KBaBUCn01ZCHucHRJ6q(cvsFunction) - 1)
				{
					num = 34;
					continue;
				}
				goto case 32;
			case 28:
				allowed &= ~ParseFlags.ALLOW_COMMA;
				num = 5;
				continue;
			case 32:
				if (!T1Q2RLnpWey6cJWHpF3(cvsFunction) && ArgIndex >= KlPZ4Un4j7C3lUvDFoJ(cvsFunction) - 1)
				{
					allowed &= ~ParseFlags.ALLOW_COMMA;
				}
				goto case 5;
			case 8:
				m4l3LBx5HQ = aCSLjinXIhYg64LXhTk(m4l3LBx5HQ + chars, y6Z3KFGCJI.Length);
				num = 19;
				continue;
			case 4:
				allowed |= ParseFlags.ALLOW_SHEET_FUNC;
				if (!pZ63UIFmxq)
				{
					num = 27;
					if (0 == 0)
					{
						continue;
					}
				}
				goto case 29;
			case 29:
				allowed &= ~jLo3sy2FjS;
				num = 13;
				continue;
			case 5:
			case 16:
			case 30:
				if ((allowed & (ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_STRFUNC)) != 0)
				{
					num = 4;
					continue;
				}
				goto case 29;
			case 2:
			case 11:
				allowed &= ~ParseFlags.ALLOW_INFIXOP;
				goto IL_0204;
			case 12:
				cvsFunction = CurrentFunction;
				_ = 1;
				num = (pqodTQnP9l2borBA1Fb() ? 2 : 14);
				continue;
			case 21:
				flag2 = false;
				num = 1;
				continue;
			case 9:
				if ((getArgAllowed() & ParseFlags.ALLOW_CELL_POS) != 0)
				{
					num = 18;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					goto case 15;
				}
				goto IL_032d;
			case 15:
				if (!flag)
				{
					num = 10;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto case 33;
				}
				goto case 7;
			case 33:
				if (Xj59Y6nbS9RRjMkGpS6(arg) == CvsFunctionArgTypes.String)
				{
					goto case 2;
				}
				goto IL_0204;
			case 3:
				if (cvsFunction == null)
				{
					num = 15;
					continue;
				}
				goto case 1;
			case 13:
				veZ3Riw9M7 = allowed;
				goto IL_02c4;
			case 34:
				allowed &= ~ParseFlags.ALLOW_CLOSE_PAREN;
				num = 32;
				continue;
			case 0:
				if (arg == null)
				{
					goto IL_0204;
				}
				num = 33;
				if (true)
				{
					continue;
				}
				goto case 35;
			case 35:
				flag = false;
				num = 21;
				if (true)
				{
					continue;
				}
				goto case 18;
			case 18:
				allowed &= ~ParseFlags.ALLOW_INFIXOP;
				goto IL_032d;
			case 7:
				if (!flag2)
				{
					num = 23;
					continue;
				}
				goto case 5;
			case 31:
				result = null;
				num = 20;
				continue;
			case 26:
				if (!h8xNoGn64qvVITB4hya(cvsFunction))
				{
					num = 17;
					continue;
				}
				goto case 25;
			case 23:
				allowed &= ~ParseFlags.ALLOW_CLOSE_PAREN;
				num = 16;
				continue;
			case 10:
				allowed &= ~ParseFlags.ALLOW_COMMA;
				num = 7;
				continue;
			case 17:
				if (!T1Q2RLnpWey6cJWHpF3(cvsFunction))
				{
					str = (string)KBVPqenkTD434uFZIG2(cvsFunction);
					num = 24;
				}
				else
				{
					num = 25;
				}
				continue;
			case 27:
				allowed |= ParseFlags.ALLOW_PROP_FUNC;
				num = 29;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				goto case 22;
			case 22:
				hit3kXunJ1 = m4l3LBx5HQ;
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (ArgIndex >= KBaBUCn01ZCHucHRJ6q(cvsFunction) - 1)
				{
					flag2 = true;
				}
				else
				{
					flag = true;
				}
				cvsFunction = NI43oh5OPs.FindFunction(str, ++num2);
				num = 3;
				continue;
			case 36:
				{
					return result;
				}
				IL_032d:
				arg = cvsFunction.GetArg(ArgIndex);
				num = 0;
				continue;
				IL_0204:
				if (pZ63UIFmxq && CJ5XqmnG4XXwBdcVUvf(tye3fZ0uCy) == 0)
				{
					allowed &= ~ParseFlags.ALLOW_COMMA;
					num = 26;
					continue;
				}
				goto case 26;
				IL_02c4:
				if (m4l3LBx5HQ < Ys6rClneL0jToh4e8RT(y6Z3KFGCJI))
				{
					result = y6Z3KFGCJI.Substring(m4l3LBx5HQ);
					num = 36;
					continue;
				}
				goto case 36;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ParseFlags getArgAllowed()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return getArgAllowed(CurrentFunction, ArgIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ParseFlags getArgAllowed(CvsFunction fd, int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		ParseFlags parseFlags = default;
		if (!pqodTQnP9l2borBA1Fb())
		{
			CvsFuncStack cvsFuncStack2 = default;
			CvsFunctionArg arg = default;
			CvsFuncStack cvsFuncStack = default;
			CvsFunctionArgTypes type = default;
			while (true)
			{
				switch (num)
				{
				case 34:
					if (!oLft1WngEQEWhILR72q(sfZiEGn811JvCsUeqtH(cvsFuncStack2.FD, waoUUanmYjgOWF2umlC(cvsFuncStack2))))
					{
						break;
					}
					num = 29;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
					parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
					num = 14;
					continue;
				case 32:
					parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
					num = 4;
					continue;
				case 5:
					if (!oLft1WngEQEWhILR72q(arg))
					{
						break;
					}
					num = 26;
					if (0 == 0)
					{
						continue;
					}
					goto case 27;
				case 27:
					parseFlags = (ParseFlags)0;
					num = 22;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto case 33;
				case 33:
					if (arg.AllowCellRange)
					{
						num = 0;
						continue;
					}
					break;
				case 7:
					if (cvsFuncStack.FD.GetArg(waoUUanmYjgOWF2umlC(cvsFuncStack)).AllowCellRange)
					{
						num = 19;
						continue;
					}
					break;
				case 35:
					parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
					num = 6;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					break;
				case 2:
				case 25:
					arg = fd.GetArg(argIndex);
					num = 3;
					if (pqodTQnP9l2borBA1Fb())
					{
					}
					continue;
				case 17:
					if (KBaBUCn01ZCHucHRJ6q(fd) != 0)
					{
						num = 27;
						continue;
					}
					goto case 22;
				case 30:
					goto IL_0207;
				case 29:
					parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
					num = 13;
					if (pqodTQnP9l2borBA1Fb())
					{
					}
					continue;
				case 22:
					type = arg.Type;
					num = 24;
					if (true)
					{
						continue;
					}
					goto case 24;
				case 24:
					switch (type)
					{
					case CvsFunctionArgTypes.Variant:
						break;
					case CvsFunctionArgTypes.Float:
					case CvsFunctionArgTypes.Slider:
						goto IL_0087;
					case CvsFunctionArgTypes.CellPos:
					case CvsFunctionArgTypes.PosRef:
						goto IL_0114;
					case CvsFunctionArgTypes.StrFloat:
						goto IL_0156;
					case CvsFunctionArgTypes.String:
						goto IL_01ca;
					case CvsFunctionArgTypes.Model:
					case CvsFunctionArgTypes.Expr:
						goto IL_0207;
					case CvsFunctionArgTypes.Cell:
					case CvsFunctionArgTypes.Image:
						goto IL_023a;
					default:
						goto IL_02a3;
					case CvsFunctionArgTypes.Int:
					case CvsFunctionArgTypes.Bool:
					case CvsFunctionArgTypes.Enum:
					case CvsFunctionArgTypes.Light:
						goto IL_044f;
					}
					parseFlags |= ParseFlags.ALLOW_DOUBLE_QUOTE | ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					num = 36;
					continue;
				case 21:
					if (argIndex == 0)
					{
						num = 17;
						continue;
					}
					goto case 27;
				case 10:
					if (CJ5XqmnG4XXwBdcVUvf(tye3fZ0uCy) > 0)
					{
						cvsFuncStack2 = (CvsFuncStack)j4httjnJ3xQWkhj5hik(tye3fZ0uCy);
						if (scaE2KnloIaxWgMdkxl(cvsFuncStack2) != null)
						{
							num = 34;
							continue;
						}
					}
					break;
				case 31:
					if (arg.AllowCellRange)
					{
						if (fd.ErrFree)
						{
							num = 28;
							continue;
						}
						parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
						num = 11;
						continue;
					}
					break;
				case 3:
					if (arg != null)
					{
						num = 21;
						continue;
					}
					break;
				case 28:
					if (CJ5XqmnG4XXwBdcVUvf(tye3fZ0uCy) <= 0)
					{
						break;
					}
					cvsFuncStack = (CvsFuncStack)tye3fZ0uCy.Peek();
					if (cvsFuncStack.FD == null)
					{
						break;
					}
					goto case 7;
				default:
					num = 7;
					continue;
				case 8:
					parseFlags = ParseFlags.ALLOW_CLOSE_PAREN | ParseFlags.ALLOW_TOKEN_COMPLETE;
					num = 23;
					continue;
				case 9:
					if (SmCUtgnFnnW8x0JIQ0E(arg))
					{
						num = 18;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					goto case 33;
				case 36:
					if (arg.AllowCellRange)
					{
						num = 35;
						continue;
					}
					break;
				case 26:
					if (!H4yyD3nZUtj0Y9LV6aH(fd))
					{
						parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
						num = 16;
					}
					else
					{
						num = 10;
					}
					continue;
				case 18:
					parseFlags |= ParseFlags.ALLOW_STRFUNC;
					num = 33;
					if (true)
					{
						continue;
					}
					goto case 19;
				case 19:
					parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
					break;
				case 23:
					if (fd == null)
					{
						break;
					}
					_ = 1;
					if (pqodTQnP9l2borBA1Fb())
					{
						num = 1;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					num = 25;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 4:
				case 6:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 20:
				case 37:
					break;
					IL_02a3:
					num = 30;
					continue;
					IL_023a:
					parseFlags |= ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_CELL_POS | ParseFlags.ALLOW_NULL_CELL | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					num = 31;
					if (true)
					{
						continue;
					}
					goto case 22;
					IL_0207:
					parseFlags |= ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					num = 37;
					continue;
					IL_01ca:
					parseFlags = (ParseFlags)((int)parseFlags | ((!fd.Structure || vxyojynfkYEWd2GpuPL(fd)) ? 524288 : 0));
					parseFlags |= ParseFlags.ALLOW_DOUBLE_QUOTE | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
					IL_0156:
					parseFlags |= ParseFlags.ALLOW_DOUBLE_QUOTE | ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_STRFUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					break;
					IL_0114:
					parseFlags |= ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_CELL_POS | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					if (tQfYiOnyXgapSNcV68Z(arg))
					{
						parseFlags |= ParseFlags.ALLOW_NULL_CELL;
						num = 5;
						continue;
					}
					goto case 5;
					IL_0087:
					parseFlags |= ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
					if (oLft1WngEQEWhILR72q(arg))
					{
						parseFlags |= ParseFlags.ALLOW_CELL_RANGE;
						num = 20;
						continue;
					}
					break;
					IL_044f:
					if (!eSDsTnnzYrhNYXyfrcj(arg))
					{
						parseFlags |= ParseFlags.ALLOW_OPEN_PAREN | ParseFlags.ALLOW_UNARYOP | ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_CELL | ParseFlags.ALLOW_FUNC | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD | ParseFlags.ALLOW_CELL_ABS | ParseFlags.ALLOW_CELL_COL;
						if (!arg.AllowCellRange)
						{
							break;
						}
						num = 32;
						if (0 == 0)
						{
							continue;
						}
						goto IL_0207;
					}
					parseFlags |= ParseFlags.ALLOW_NUMBER | ParseFlags.ALLOW_DIGIT | ParseFlags.ALLOW_PERIOD;
					num = 12;
					continue;
				}
				break;
			}
		}
		return parseFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void nextArg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ooB3jxBS4K != null)
		{
			oXQUAHGweBtuF88SJQd(ooB3jxBS4K);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void addLevel(CvsFunction fd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				XSZdVYGsqxNm5Lafjga(tye3fZ0uCy, ooB3jxBS4K);
				break;
			case 4:
				if (ooB3jxBS4K != null)
				{
					y1KmIwnodLGC18Cx0pt();
					num = (pqodTQnP9l2borBA1Fb() ? 3 : 0);
					continue;
				}
				break;
			case 5:
				return;
			}
			ooB3jxBS4K = new CvsFuncStack(fd, 0);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunction removeLevel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsFunction currentFunction = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				jLo3sy2FjS = ~(ParseFlags.ALLOW_TOKEN_COMPLETE | ParseFlags.ALLOW_OK);
				goto case 8;
			default:
				num = 8;
				continue;
			case 1:
				currentFunction = CurrentFunction;
				num = 6;
				continue;
			case 8:
				if (CJ5XqmnG4XXwBdcVUvf(tye3fZ0uCy) > 0)
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				}
				ooB3jxBS4K = null;
				num = 10;
				continue;
			case 2:
			case 5:
				if (currentFunction.Structure)
				{
					num = 4;
					continue;
				}
				goto case 8;
			case 6:
				if (currentFunction == null)
				{
					goto case 8;
				}
				_ = 0;
				if (y1KmIwnodLGC18Cx0pt())
				{
					num = 5;
					continue;
				}
				num = 9;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				goto case 4;
			case 0:
				ooB3jxBS4K = (CvsFuncStack)dhRu9EGhSUKDaHP4sYf(tye3fZ0uCy);
				break;
			case 4:
				if (!vxyojynfkYEWd2GpuPL(currentFunction))
				{
					num = 3;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					break;
				}
				goto case 8;
			case 7:
			case 9:
			case 10:
				break;
			}
			break;
		}
		return CurrentFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nh2W8Adxfb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MVY3XSvFxL += P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mW3WzrjKVD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MVY3XSvFxL = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int getExprStack()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MVY3XSvFxL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int getFunctionMatch(string str)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return NI43oh5OPs.GetFunctionMatch(str, wAG33tCtTE);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunction FindFunction(string identifier)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return NI43oh5OPs.FindFunction(identifier, 0, wAG33tCtTE);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s5p3PwOvve()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		veZ3Riw9M7 &= ~ParseFlags.ALLOW_TOKEN_MATCH;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int parseInt(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (pqodTQnP9l2borBA1Fb() ? 8 : 7);
		char c = default;
		int result = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (char.IsDigit(c))
				{
					num = 4;
					continue;
				}
				goto default;
			default:
				result = num2;
				num = 1;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				break;
			case 3:
			case 9:
				if (num2 >= Ys6rClneL0jToh4e8RT(expr))
				{
					num = 10;
					continue;
				}
				c = kJugVVnuZfgO16gN3nE(expr, num2);
				num = 6;
				continue;
			case 4:
				if (c <= '\u007f')
				{
					num2++;
					num = 3;
					if (y1KmIwnodLGC18Cx0pt())
					{
						continue;
					}
					goto case 3;
				}
				goto default;
			case 0:
			case 7:
				result = Ys6rClneL0jToh4e8RT(expr);
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 2:
				num2 = 0;
				num = 9;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				break;
			case 1:
			case 10:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int parseInt(string expr, bool negative, CvsFunctionArg arg, out bool argLimit)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		double num5 = default;
		int result = default;
		int num4 = default;
		char c = default;
		double num2 = default;
		while (true)
		{
			double num3;
			switch (num)
			{
			case 7:
			case 8:
				if (!negative)
				{
					num = 9;
					continue;
				}
				num3 = 0.0 - num5;
				goto IL_01ab;
			case 14:
				num5 = 0.0;
				num = 16;
				continue;
			case 13:
				result = num4;
				goto case 12;
			case 6:
				argLimit = false;
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				num4 = 0;
				num = 10;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				if (arg == null)
				{
					goto IL_00b3;
				}
				goto default;
			default:
				y1KmIwnodLGC18Cx0pt();
				num = ((!pqodTQnP9l2borBA1Fb()) ? 7 : 15);
				continue;
			case 2:
				if (c <= '\u007f')
				{
					num5 = num5 * 10.0 + (double)(c - 48);
					num = 0;
					continue;
				}
				goto IL_014a;
			case 10:
			case 11:
				if (num4 < expr.Length)
				{
					c = expr[num4];
					if (lqHvdwGLaCstRRfkETW(c))
					{
						num = 2;
						continue;
					}
					goto IL_014a;
				}
				num = 17;
				continue;
			case 1:
				if (num2 < vM7q0cG9JGi3XwnecWs(arg))
				{
					num = 13;
					continue;
				}
				goto IL_00b3;
			case 16:
				result = Ys6rClneL0jToh4e8RT(expr);
				num = 3;
				continue;
			case 12:
			case 15:
				argLimit = true;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				num3 = num5;
				goto IL_01ab;
			case 4:
			case 5:
			case 17:
				break;
				IL_01ab:
				num2 = num3;
				if (num2 > vM7q0cG9JGi3XwnecWs(arg))
				{
					goto case 13;
				}
				if (negative)
				{
					num = 1;
					continue;
				}
				goto IL_00b3;
				IL_00b3:
				num4++;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
				IL_014a:
				result = num4;
				num = 4;
				continue;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FindIdentifier(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = a6foxTGSlgxwRyYPhnt(expr);
		return (string)NPcwxjGE9k3IMrWU9WW(expr, 0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int ParseIdentifier(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (pqodTQnP9l2borBA1Fb())
		{
			goto IL_001e;
		}
		goto IL_0065;
		IL_0065:
		char c = default;
		int result = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 5:
				if (c != '!')
				{
					goto case 6;
				}
				goto IL_00c8;
			case 4:
			case 9:
				if (c != '_')
				{
					goto case 5;
				}
				goto IL_00c8;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
			case 8:
				result = num2;
				num = 0;
				continue;
			case 2:
				result = Ys6rClneL0jToh4e8RT(expr);
				num = 7;
				continue;
			case 10:
				goto IL_00dc;
			case 7:
				goto IL_00f8;
			case 1:
				if (lqHvdwGLaCstRRfkETW(c))
				{
					goto IL_00c8;
				}
				y1KmIwnodLGC18Cx0pt();
				if (pqodTQnP9l2borBA1Fb())
				{
					num = 8;
					continue;
				}
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 11:
				return result;
			}
			break;
		}
		goto IL_001e;
		IL_00f8:
		num2 = 0;
		goto IL_00dc;
		IL_00c8:
		num2++;
		num = 10;
		if (y1KmIwnodLGC18Cx0pt())
		{
			goto IL_0065;
		}
		goto IL_00dc;
		IL_001e:
		if (!isRa0VGvdOAWsE7QAVl(c))
		{
			num = 1;
			goto IL_0065;
		}
		goto IL_00c8;
		IL_00dc:
		if (num2 >= expr.Length)
		{
			num = 11;
			if (!y1KmIwnodLGC18Cx0pt())
			{
				goto IL_00f8;
			}
		}
		else
		{
			c = expr[num2];
			num = 3;
		}
		goto IL_0065;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool isAlpha(char ch)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_007b;
		IL_001a:
		bool result = true;
		num = 7;
		goto IL_007b;
		IL_007b:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 3:
			case 6:
				if (ch <= 'Z')
				{
					break;
				}
				goto case 7;
			case 2:
				ch = MRpDUlGVcBJFX8jTdCo(ch, MZS3hHGHs4RIlAQAlEC());
				num = 5;
				continue;
			case 0:
				result = false;
				num = 2;
				continue;
			case 5:
				if (ch >= 'A')
				{
					goto default;
				}
				goto case 7;
			default:
				pqodTQnP9l2borBA1Fb();
				if (!y1KmIwnodLGC18Cx0pt())
				{
					num = 1;
					continue;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				return result;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int findFunctionStartIndex(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num2 = default;
		int num4 = default;
		char c = default;
		int result = default;
		bool flag = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 17:
				if (num2 == 0)
				{
					num = 2;
					continue;
				}
				goto case 0;
			case 4:
			case 10:
				if (num4 < expr.Length)
				{
					c = kJugVVnuZfgO16gN3nE(expr, num4);
					num = 12;
				}
				else
				{
					num = 18;
				}
				continue;
			case 0:
			case 8:
			case 15:
				num4++;
				num = 10;
				continue;
			case 9:
				num2 = 0;
				goto case 5;
			case 1:
				result = -1;
				num = 6;
				continue;
			case 16:
				if (c == '"')
				{
					flag = false;
				}
				goto case 0;
			default:
				num = 15;
				continue;
			case 14:
				if (num3 == -1)
				{
					break;
				}
				pqodTQnP9l2borBA1Fb();
				if (!y1KmIwnodLGC18Cx0pt())
				{
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				num = 13;
				continue;
			case 12:
				if (flag)
				{
					num = 16;
					continue;
				}
				if (c != '(')
				{
					if (c == ')')
					{
						num = 7;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					if (c == '"')
					{
						flag = true;
						num = 8;
						continue;
					}
					goto case 0;
				}
				num2++;
				num = 0;
				continue;
			case 6:
				num3 = expr.IndexOf(kgbOBx7BanbFa22Hp9.ol99ukmDA(7598));
				num = 14;
				continue;
			case 7:
				num2--;
				num = 17;
				continue;
			case 5:
			case 11:
				num4 = num3;
				num = 4;
				continue;
			case 3:
			case 13:
				flag = false;
				num = 9;
				continue;
			case 2:
				result = num4;
				break;
			case 18:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int[] findArgPos(string expr, int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 23;
		int num3 = default;
		int num4 = default;
		int num6 = default;
		int[] array = default;
		int num5 = default;
		int num2 = default;
		int num7 = default;
		char c = default;
		bool flag = default;
		while (true)
		{
			switch (num)
			{
			case 13:
			case 26:
				num3 = num4 + 1;
				num = 30;
				if (0 == 0)
				{
					continue;
				}
				goto case 14;
			case 14:
			case 25:
				if (num3 == -1)
				{
					break;
				}
				num = 28;
				if (!pqodTQnP9l2borBA1Fb())
				{
					continue;
				}
				goto case 17;
			case 17:
				num3 = -1;
				num6 = -1;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				array[1] = num6;
				num = 31;
				continue;
			case 16:
				num6 = num4;
				goto case 14;
			case 11:
				if (num5 == 0)
				{
					num = 22;
					continue;
				}
				goto case 18;
			case 2:
				num6 = num4;
				num = 25;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				num2 = 0;
				num = 17;
				continue;
			case 4:
				num4 = num7;
				num = 19;
				continue;
			default:
				num = 11;
				continue;
			case 15:
				if (num5 == 1)
				{
					num = 24;
					if (!pqodTQnP9l2borBA1Fb())
					{
						continue;
					}
					goto case 14;
				}
				goto case 18;
			case 6:
				array[0] = num3;
				num = 9;
				continue;
			case 28:
				if (num6 != -1)
				{
					array = new int[2];
					num = 6;
					continue;
				}
				break;
			case 10:
				num3 = num4 + 1;
				num = 29;
				if (0 == 0)
				{
					continue;
				}
				goto case 27;
			case 27:
				if (num5 == 1)
				{
					if (num2 == argIndex)
					{
						num = 16;
						if (pqodTQnP9l2borBA1Fb())
						{
						}
						continue;
					}
					num2++;
					if (num2 == argIndex)
					{
						num = 10;
						continue;
					}
				}
				goto case 18;
			case 3:
				if (c == '"')
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				goto case 18;
			case 1:
			case 21:
				num7 = FjKgQlGD4x0MwuKiW8L(expr, GYmM4DGAYuaNhbvACji(7598));
				if (num7 != -1)
				{
					num = 5;
					continue;
				}
				break;
			case 24:
				if (num2 == argIndex)
				{
					goto case 13;
				}
				goto case 18;
			case 20:
				flag = true;
				goto case 18;
			case 18:
			case 29:
			case 30:
				num4++;
				num = 12;
				continue;
			case 7:
				flag = false;
				num = 18;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				num5++;
				num = 15;
				continue;
			case 5:
				flag = false;
				num5 = 0;
				num = 0;
				continue;
			case 23:
				array = null;
				_ = 0;
				num = (y1KmIwnodLGC18Cx0pt() ? 21 : 26);
				continue;
			case 12:
			case 19:
				if (num4 < expr.Length)
				{
					c = expr[num4];
					if (!flag)
					{
						if (c != '(')
						{
							if (c == ')')
							{
								num5--;
								goto case 11;
							}
							if (c != ',')
							{
								if (c == '"')
								{
									num = 20;
									if (y1KmIwnodLGC18Cx0pt())
									{
										continue;
									}
									goto case 16;
								}
								goto case 18;
							}
							num = 27;
							continue;
						}
						num = 8;
						continue;
					}
					num = 3;
					continue;
				}
				num = 14;
				continue;
			case 22:
				if (num2 == argIndex)
				{
					num = 2;
					continue;
				}
				goto case 18;
			case 31:
				break;
			}
			break;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FindArg(string expr, int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)BS97G0GUl5nh4IN7grl(expr, argIndex, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> FindAllArgs(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass187_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass187_0();
		CS_0024_003C_003E8__locals2.expression = expression;
		return Enumerable.Range(0, int.MaxValue).Select([MethodImpl(MethodImplOptions.NoInlining)] (int argIndex) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec__DisplayClass187_0.X39ggwslITeYlvJkRaKy(CS_0024_003C_003E8__locals2.expression, argIndex);
		}).TakeWhile([MethodImpl(MethodImplOptions.NoInlining)] (string arg) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return arg != null;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string FindArg(string expr, CvsFunctionArg argDesc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)BS97G0GUl5nh4IN7grl(expr, oh7xDoGTlEifLkQHUUv(argDesc), argDesc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string findArg(string expr, int argidx, CvsFunctionArg argDesc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0094;
		IL_001a:
		int[] array = findArgPos(expr, argidx);
		num = 2;
		goto IL_0094;
		IL_0094:
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				break;
			case 4:
				result = null;
				_ = 0;
				num = ((!y1KmIwnodLGC18Cx0pt()) ? 3 : 6);
				continue;
			case 2:
				if (array == null)
				{
					if (argDesc != null)
					{
						goto case 3;
					}
					goto case 0;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				result = (string)NPcwxjGE9k3IMrWU9WW(expr, array[0], array[1] - array[0]);
				goto case 0;
			default:
				num = 0;
				continue;
			case 3:
			case 5:
				result = vjSC99Gd7EMRXXFqQm2(argDesc).ToString();
				num = 8;
				continue;
			case 0:
			case 8:
				return result;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReplaceArg(string expr, int argidx, string newarg)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int[] array = (int[])N4MBTbGiDvGjsAY98vh(expr, argidx);
		if (array == null)
		{
			return null;
		}
		object obj = NPcwxjGE9k3IMrWU9WW(expr, 0, array[0]);
		string text = (string)Ii5qRLnrFNcaqlnw03G(expr, array[1]);
		return (string)he8beuGqoHHHGI2AEDd(obj, newarg, text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Point parseReference(string cellref)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!pqodTQnP9l2borBA1Fb())
		{
			num = 13;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
			if (pqodTQnP9l2borBA1Fb())
			{
				goto IL_0156;
			}
		}
		goto IL_00ef;
		IL_0026:
		string text = default;
		if (Ys6rClneL0jToh4e8RT(text) != 0)
		{
			goto IL_00a1;
		}
		num = 17;
		goto IL_00ef;
		IL_00a1:
		int num2 = kyfZWhGjjgBWpG6mWwL(text);
		num = 8;
		goto IL_00ef;
		IL_0156:
		char c = kJugVVnuZfgO16gN3nE(text, 0);
		num = 5;
		if (y1KmIwnodLGC18Cx0pt())
		{
			goto IL_00ef;
		}
		goto IL_016f;
		IL_016f:
		Point result = default;
		if (Ys6rClneL0jToh4e8RT(text) == 0)
		{
			return result;
		}
		c = kJugVVnuZfgO16gN3nE(text, 0);
		num = 7;
		goto IL_00ef;
		IL_00ef:
		int x = default;
		int y = default;
		while (true)
		{
			switch (num)
			{
			case 14:
				break;
			case 2:
				result = new Point(x, y);
				num = 18;
				continue;
			case 5:
				if (c == '$')
				{
					text = text.Substring(1);
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				goto case 7;
			case 3:
				x = uCgeNuGBdDoqlsVcckZ(GYmM4DGAYuaNhbvACji(41932), MRpDUlGVcBJFX8jTdCo(c, MZS3hHGHs4RIlAQAlEC()));
				text = (string)Ii5qRLnrFNcaqlnw03G(text, 1);
				num = 16;
				if (!pqodTQnP9l2borBA1Fb())
				{
					continue;
				}
				goto case 17;
			case 17:
				return result;
			case 7:
				if (isRa0VGvdOAWsE7QAVl(c))
				{
					num = 3;
					continue;
				}
				goto case 18;
			case 15:
				return result;
			case 12:
				goto IL_0156;
			case 1:
				goto IL_016f;
			case 0:
			case 13:
				result = new Point(-1, -1);
				num = 11;
				continue;
			case 4:
				num2 = Math.Min(num2, 3);
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				if (num2 > 0)
				{
					num = 4;
					continue;
				}
				goto case 18;
			case 10:
				y = Woh8nIGc8FAua1w4aDJ(NPcwxjGE9k3IMrWU9WW(text, 0, num2), MZS3hHGHs4RIlAQAlEC());
				num = 2;
				continue;
			default:
				goto IL_01e8;
			case 11:
				text = cellref;
				num = 12;
				continue;
			case 16:
				goto IL_0206;
			case 18:
				return result;
			}
			break;
			IL_0206:
			if (Ys6rClneL0jToh4e8RT(text) != 0)
			{
				c = kJugVVnuZfgO16gN3nE(text, 0);
				if (c != '$')
				{
					goto IL_00a1;
				}
				goto IL_01e8;
			}
			num = 15;
			if (pqodTQnP9l2borBA1Fb())
			{
			}
			continue;
			IL_01e8:
			text = (string)Ii5qRLnrFNcaqlnw03G(text, 1);
			num = 14;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ExpressionTypes GetExprType(CvsFunctionTable funcTable, CvsProcessorConstants procConst, string expr, CvsFunction fd, int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		ExpressionTypes result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (expr.Length <= 0)
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				result = Parse(funcTable, procConst, expr, Ys6rClneL0jToh4e8RT(expr), fd, argIndex).ExpressionType;
				num = 6;
				continue;
			case 3:
				result = ExpressionTypes.Empty;
				_ = 0;
				if (y1KmIwnodLGC18Cx0pt())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (y1KmIwnodLGC18Cx0pt())
				{
					continue;
				}
				break;
			case 1:
			case 4:
				if (expr == null)
				{
					break;
				}
				goto case 0;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (y1KmIwnodLGC18Cx0pt())
		{
			num = 3;
			if (!y1KmIwnodLGC18Cx0pt())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0041;
			}
		}
		goto IL_006a;
		IL_0051:
		MaxDigitsBeforeDecimal = 15;
		goto IL_0041;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 4:
				goto IL_0041;
			case 1:
			case 2:
				goto IL_0051;
			default:
				num = 4;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		coSYcNG2AlJ3v5gEaYU();
		goto IL_0051;
		IL_0041:
		MaxDigitsAfterDecimal = 6;
		num = 5;
		goto IL_006a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y1KmIwnodLGC18Cx0pt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pqodTQnP9l2borBA1Fb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int n8mLHAnYh2J90hlnV4w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CellRefRange>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange mCstuQnNJKjTjomcNCF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsReferenceRange)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QWXAnZnxys9WxWEpxAv(object P_0, CvsCellRange value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsReferenceRange)P_0).Range = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HB8emgn1ydT3efKP6FH(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellRefRange)P_0).TextEnd = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ii5qRLnrFNcaqlnw03G(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int M7IP0an37gKLI5XQEaZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IExpressionConstants)P_0).SpreadsheetTotalRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bvwbymnOs88dHSdR1wY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IExpressionConstants)P_0).SpreadsheetColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mnNk9LnMMhW0yeIJdCl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CJ3tyCnQCgOgNxL0Hu9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object scaE2KnloIaxWgMdkxl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFuncStack)P_0).FD;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ys6rClneL0jToh4e8RT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char kJugVVnuZfgO16gN3nE(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sYS0VPnIRDGD0YsQM9a(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsFuncStack)P_0).FD = (CvsFunction)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int P6hUBUnRKaGwoZ99S0H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFuncStack)P_0).ArgPos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Csc6Utna26bCEprD0RS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFuncStack)P_0).FunctionPos;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void spQ7kEnn3o158s3snXK(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsFuncStack)P_0).FunctionPos = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CJ5XqmnG4XXwBdcVUvf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stack)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int aCSLjinXIhYg64LXhTk(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsFunctionArgTypes Xj59Y6nbS9RRjMkGpS6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h8xNoGn64qvVITB4hya(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).HasOptionalArguments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T1Q2RLnpWey6cJWHpF3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).HasVariableArguments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KBaBUCn01ZCHucHRJ6q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MinNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KlPZ4Un4j7C3lUvDFoJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MaxNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KBVPqenkTD434uFZIG2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vxyojynfkYEWd2GpuPL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).StringFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SmCUtgnFnnW8x0JIQ0E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).AllowStringFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int waoUUanmYjgOWF2umlC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFuncStack)P_0).ArgIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tQfYiOnyXgapSNcV68Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).AllowZero;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oLft1WngEQEWhILR72q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).AllowCellRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H4yyD3nZUtj0Y9LV6aH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).ErrFree;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j4httjnJ3xQWkhj5hik(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stack)P_0).Peek();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sfZiEGn811JvCsUeqtH(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).GetArg(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eSDsTnnzYrhNYXyfrcj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Constant;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oXQUAHGweBtuF88SJQd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsFuncStack)P_0).nextArg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XSZdVYGsqxNm5Lafjga(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stack)P_0).Push(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dhRu9EGhSUKDaHP4sYf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stack)P_0).Pop();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lqHvdwGLaCstRRfkETW(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.IsDigit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vM7q0cG9JGi3XwnecWs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).MaxVal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int a6foxTGSlgxwRyYPhnt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ParseIdentifier((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NPcwxjGE9k3IMrWU9WW(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool isRa0VGvdOAWsE7QAVl(char ch)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return isAlpha(ch);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MZS3hHGHs4RIlAQAlEC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char MRpDUlGVcBJFX8jTdCo(char P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.ToUpper(P_0, (CultureInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GYmM4DGAYuaNhbvACji(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int FjKgQlGD4x0MwuKiW8L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BS97G0GUl5nh4IN7grl(object P_0, int argidx, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return findArg((string)P_0, argidx, (CvsFunctionArg)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oh7xDoGTlEifLkQHUUv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vjSC99Gd7EMRXXFqQm2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).GetDefaultValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N4MBTbGiDvGjsAY98vh(object P_0, int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return findArgPos((string)P_0, argIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object he8beuGqoHHHGI2AEDd(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uCgeNuGBdDoqlsVcckZ(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kyfZWhGjjgBWpG6mWwL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return parseInt((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Woh8nIGc8FAua1w4aDJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return int.Parse((string)P_0, (IFormatProvider)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coSYcNG2AlJ3v5gEaYU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
