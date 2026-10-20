using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public abstract class CvsCell : ICloneable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public string dataTypeString;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass72_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YNonabseR5aDKaSM0kQd();
			jTPyVBseayIGH6beTP2s(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetDataType_003Eb__0(KeyValuePair<Type, string> x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x.Value == dataTypeString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YNonabseR5aDKaSM0kQd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jTPyVBseayIGH6beTP2s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ReHdE6seuQNA6bkkVfjT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IWvPDWseILNmXKCRuMdv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation pQofqnBag6;

	private CvsCogCellResult WrPfTF6q7i;

	private CvsCellFlags z7JfBIwlHp;

	private static Dictionary<Type, string> HEwfJ18B6s;

	private static readonly string[] Q0yfMNVGL9;

	public bool IsInputImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iEifgmLQRl((string)To86gifqQMMj2hNjBFx(46510));
		}
	}

	public bool IsProfile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iEifgmLQRl((string)To86gifqQMMj2hNjBFx(46534));
		}
	}

	public bool IsViewable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!wcSWaPfEQbhL4uWFLFd()) ? 1 : 6);
			while (true)
			{
				switch (num)
				{
				default:
					if (IsGetGreyScale)
					{
						break;
					}
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					if (IsInputImage)
					{
						break;
					}
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					if (!IsProfile)
					{
						num = 5;
						continue;
					}
					break;
				case 5:
					if (IsInputPointCloud)
					{
						break;
					}
					goto default;
				case 0:
				case 1:
					if (!iEifgmLQRl((string)To86gifqQMMj2hNjBFx(46558)))
					{
						num = 2;
						continue;
					}
					break;
				case 7:
					return IsAcquireImage;
				}
				break;
			}
			return true;
		}
	}

	public bool IsInputPointCloud
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iEifgmLQRl((string)To86gifqQMMj2hNjBFx(46624));
		}
	}

	public bool IsGetGreyScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Expression.ToLowerInvariant().StartsWith((string)To86gifqQMMj2hNjBFx(46658));
		}
	}

	public bool IsAcquireImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iEifgmLQRl(kgbOBx7BanbFa22Hp9.ol99ukmDA(42518));
		}
	}

	public bool IsViDi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					if (text.StartsWith((string)To86gifqQMMj2hNjBFx(46700)))
					{
						break;
					}
					goto case 0;
				default:
					num = 0;
					continue;
				case 1:
					if (zfSmjMf5iWudS4n39H9(text, To86gifqQMMj2hNjBFx(46686)))
					{
						break;
					}
					_ = 0;
					if (CWxLjqfSWB7d4Ox37as())
					{
						num = 3;
						if (wcSWaPfEQbhL4uWFLFd())
						{
						}
						continue;
					}
					num = 6;
					if (CWxLjqfSWB7d4Ox37as())
					{
						continue;
					}
					goto case 7;
				case 5:
					text = Expression.ToLowerInvariant();
					num = 1;
					continue;
				case 4:
				case 6:
					if (!text.StartsWith((string)To86gifqQMMj2hNjBFx(46746)))
					{
						num = 7;
						continue;
					}
					break;
				case 0:
					if (zfSmjMf5iWudS4n39H9(text, To86gifqQMMj2hNjBFx(46722)))
					{
						break;
					}
					goto case 4;
				case 7:
					return zfSmjMf5iWudS4n39H9(text, To86gifqQMMj2hNjBFx(46772));
				}
				break;
			}
			return true;
		}
	}

	public string ErrorString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!(o1TEk2fWgDWEpA4jkK1(WrPfTF6q7i) is CvsCogError))
			{
				return string.Empty;
			}
			return (string)aTbooPfoa2REnpCvWbj((CvsCogError)o1TEk2fWgDWEpA4jkK1(WrPfTF6q7i));
		}
	}

	public bool Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (z7JfBIwlHp & CvsCellFlags.Error) != 0;
		}
	}

	public bool Hidden
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
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
			return (z7JfBIwlHp & CvsCellFlags.Disabled) == 0;
		}
	}

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pQofqnBag6;
		}
	}

	public bool HasComment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i9HZqmfYx34edcolHsU(WrPfTF6q7i);
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (tUg5YufxBKwIP3ilaMQ(aq4UrufNoSJPGrYHC8h(WrPfTF6q7i)))
			{
				return null;
			}
			return (string)aq4UrufNoSJPGrYHC8h(WrPfTF6q7i);
		}
	}

	public bool Input
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return myFrivf1NYNpuFtTl3p(WrPfTF6q7i);
		}
	}

	public bool Output
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oRHcIYfrumW4W3CbARr(WrPfTF6q7i);
		}
	}

	public bool IpProtected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WrPfTF6q7i.IpProtected;
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
			if (!Hidden)
			{
				return GetExpression();
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(46802);
		}
	}

	public virtual string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Empty;
		}
	}

	public virtual object CellValue
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

	public string CellStateReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
					if (!tON3YmfMphUVuBNjwAC(WrPfTF6q7i.Condition, To86gifqQMMj2hNjBFx(41870)))
					{
						goto default;
					}
					goto case 5;
				default:
					if (tON3YmfMphUVuBNjwAC(tyNdvafOvoUHgCUGkOJ(WrPfTF6q7i), string.Empty))
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					return (string)tyNdvafOvoUHgCUGkOJ(WrPfTF6q7i);
				case 4:
					if (!tON3YmfMphUVuBNjwAC(tyNdvafOvoUHgCUGkOJ(WrPfTF6q7i), To86gifqQMMj2hNjBFx(34482)))
					{
						_ = 1;
						if (wcSWaPfEQbhL4uWFLFd())
						{
							num = 3;
							if (true)
							{
								break;
							}
							goto default;
						}
						num = 0;
						if (0 == 0)
						{
							break;
						}
					}
					goto case 5;
				case 5:
					return null;
				}
			}
		}
	}

	public bool HasStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (tUg5YufxBKwIP3ilaMQ(rB0pWSfQcPUb8KRdiv1(WrPfTF6q7i)))
			{
				return !string.IsNullOrEmpty((string)oiDmfqflgnxTv07sB38(WrPfTF6q7i));
			}
			return true;
		}
	}

	public CvsCogCellResult CellResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WrPfTF6q7i;
		}
	}

	public virtual bool IsEditCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual bool SupportsAuthorization
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual Type DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return typeof(object);
		}
	}

	public string DataTypeString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)q09J10fuFvwmUldFcbK(FZiGJGfe8trDOb7asxn(this));
		}
	}

	public virtual bool IsEditPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	internal string CellState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!string.IsNullOrEmpty((string)tyNdvafOvoUHgCUGkOJ(WrPfTF6q7i)))
			{
				return (string)tyNdvafOvoUHgCUGkOJ(WrPfTF6q7i);
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(41870);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCell()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0081;
		IL_0124:
		HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(double).TypeHandle), (string)p0qSGpfAKeh462spyqP());
		num = 1;
		if (CWxLjqfSWB7d4Ox37as())
		{
			goto IL_0081;
		}
		goto IL_014d;
		IL_0081:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				break;
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				if (true)
				{
					continue;
				}
				goto IL_0056;
			case 0:
			case 4:
				goto IL_0056;
			default:
				num = 8;
				continue;
			case 5:
				HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(CvsCellButton).TypeHandle), Resources.Action);
				num = 10;
				if (wcSWaPfEQbhL4uWFLFd())
				{
				}
				continue;
			case 7:
				HEwfJ18B6s = new Dictionary<Type, string>();
				num = 6;
				continue;
			case 10:
				HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(CvsCellOcrMaxAutoTune).TypeHandle), (string)GBxWk2fDmE2aTsf3Jsn());
				num = 11;
				continue;
			case 8:
				goto IL_0124;
			case 1:
				goto IL_014d;
			case 6:
				Q0yfMNVGL9 = new string[0];
				wcSWaPfEQbhL4uWFLFd();
				if (!CWxLjqfSWB7d4Ox37as())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				}
				num = 2;
				if (true)
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_014d:
		HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(string).TypeHandle), Resources.String);
		num = 5;
		goto IL_0081;
		IL_001a:
		HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(bool).TypeHandle), (string)J1WaCufHdXypu8kRKfE());
		goto IL_0056;
		IL_0056:
		HEwfJ18B6s.Add(NhpjYcfvLblPUaYk9Ao(typeof(int).TypeHandle), (string)EyFAYpfVPLkXKkaZdcp());
		goto IL_0124;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCell CreateNewCell(CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCellLocation cvsCellLocation = default;
		object obj = default;
		CvsCogProfileViewResult cvsCogProfileViewResult = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				return new CvsCellString(cvsCellLocation, cellResult);
			case 19:
				return new CvsCellEditString(cvsCellLocation, cellResult);
			case 7:
				ybyRrRfdZwQRelCS9sY(cellResult, To86gifqQMMj2hNjBFx(46486));
				return new CvsCellString(cvsCellLocation, cellResult);
			case 20:
				if (!(obj is CvsCogError))
				{
					if (obj is object[])
					{
						num = 0;
						break;
					}
					cvsCogProfileViewResult = obj as CvsCogProfileViewResult;
					num = 12;
				}
				else
				{
					num = 7;
				}
				break;
			case 18:
				ybyRrRfdZwQRelCS9sY(cellResult, string.Empty);
				num = 9;
				break;
			case 8:
			case 14:
				return new CvsCellFloat(cvsCellLocation, cellResult);
			case 15:
				if (!(obj is double))
				{
					num = 16;
					break;
				}
				goto case 8;
			case 9:
				jtByiTfiw0CknU152k9(cellResult, string.Empty);
				_ = 1;
				num = (wcSWaPfEQbhL4uWFLFd() ? 14 : 10);
				break;
			case 16:
				if (!(obj is long))
				{
					if (obj is string)
					{
						num = 1;
						break;
					}
					if (obj is CvsCogEditIntResult)
					{
						return new CvsCellEditInt(cvsCellLocation, cellResult);
					}
					if (obj is CvsCogEditFloatResult)
					{
						num = 22;
						break;
					}
					if (!(obj is CvsCogEditStringResult))
					{
						if (obj is CvsCogCheckBoxResult)
						{
							num = 3;
							break;
						}
						if (obj is CvsCogListBoxResult)
						{
							num = 17;
							if (CWxLjqfSWB7d4Ox37as())
							{
								break;
							}
							goto case 2;
						}
						if (obj is CvsCogButtonResult)
						{
							return new CvsCellButton(cvsCellLocation, cellResult);
						}
						if (obj is CvsCogMultiStatusResult)
						{
							return new CvsCellMultiStatus(cvsCellLocation, cellResult);
						}
						if (!(obj is CvsCogStatusResult))
						{
							if (obj is CvsCogColorLabelResult)
							{
								return new CvsCellColorLabel(cvsCellLocation, cellResult);
							}
							if (obj is int)
							{
								return null;
							}
							num = 20;
						}
						else
						{
							num = 21;
						}
						break;
					}
					goto case 19;
				}
				goto case 8;
			case 0:
				return new CvsCellString(cvsCellLocation, cellResult);
			case 12:
				if (cvsCogProfileViewResult == null)
				{
					if (!(obj is CvsCogJumpResult))
					{
						return new CvsCellString(cvsCellLocation, cellResult);
					}
					num = 23;
				}
				else
				{
					num = 11;
				}
				break;
			case 21:
				return new CvsCellStatusLight(cvsCellLocation, cellResult);
			case 3:
				return new CvsCellCheckBox(cvsCellLocation, cellResult);
			case 2:
				cvsCellLocation = new CvsCellLocation((string)jI3TOafU0KwPHh9htjU(cellResult));
				num = 4;
				if (wcSWaPfEQbhL4uWFLFd())
				{
				}
				break;
			case 17:
				return new CvsCellListBox(cvsCellLocation, cellResult);
			case 1:
				return new CvsCellString(cvsCellLocation, cellResult);
			case 5:
			case 10:
				obj = SAE4JPfT4HprRj8jRSN(cellResult);
				num = 15;
				break;
			case 22:
				return new CvsCellEditFloat(cvsCellLocation, cellResult);
			default:
				num = 19;
				break;
			case 6:
				ybyRrRfdZwQRelCS9sY(cellResult, cellResult.Value);
				if (SAE4JPfT4HprRj8jRSN(cellResult) == null)
				{
					num = 18;
					break;
				}
				goto case 5;
			case 11:
				cellResult.Face = pjePgPfBGaLR8rSRcnE(cvsCogProfileViewResult);
				num = 13;
				break;
			case 4:
				if (SAE4JPfT4HprRj8jRSN(cellResult) == null)
				{
					num = 6;
					break;
				}
				goto case 5;
			case 23:
				return new CvsCellJump(cvsCellLocation, cellResult);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCell()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wcSWaPfEQbhL4uWFLFd();
		int num = ((!CWxLjqfSWB7d4Ox37as()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				p04Zy6fc4vPPlhwlOZD(this);
				num = 5;
				break;
			case 3:
				pQofqnBag6 = CvsCellLocation.PropertySheet;
				goto default;
			case 0:
			case 4:
				eNvhNefje2d2uI9yR40();
				num = 3;
				if (wcSWaPfEQbhL4uWFLFd())
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCell(CvsCell cell)
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
			case 6:
				z7JfBIwlHp = cell.z7JfBIwlHp;
				num = 5;
				break;
			case 5:
				WrPfTF6q7i = cell.WrPfTF6q7i;
				num = 9;
				break;
			case 1:
			case 3:
				if (cell == null)
				{
					goto case 0;
				}
				pQofqnBag6 = cell.pQofqnBag6;
				num = 6;
				break;
			default:
				num = 0;
				break;
			case 8:
				pQofqnBag6 = CvsCellLocation.PropertySheet;
				_ = 1;
				num = (wcSWaPfEQbhL4uWFLFd() ? 1 : 4);
				break;
			case 7:
				eNvhNefje2d2uI9yR40();
				num = 8;
				if (!wcSWaPfEQbhL4uWFLFd())
				{
					break;
				}
				goto case 0;
			case 0:
				throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(46498));
			case 2:
			case 4:
				p04Zy6fc4vPPlhwlOZD(this);
				goto case 1;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCell(CvsCellLocation cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!CWxLjqfSWB7d4Ox37as()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				pQofqnBag6 = CvsCellLocation.PropertySheet;
				num = 6;
				break;
			case 0:
			case 3:
				eNvhNefje2d2uI9yR40();
				goto case 1;
			case 5:
				pQofqnBag6 = cell;
				num = 2;
				break;
			case 6:
				p04Zy6fc4vPPlhwlOZD(this);
				goto case 5;
			default:
				num = 5;
				if (wcSWaPfEQbhL4uWFLFd())
				{
				}
				break;
			case 2:
				WrPfTF6q7i = new CvsCogCellResult();
				num = 7;
				if (false)
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
	internal CvsCell(CvsCellLocation location, CvsCogCellResult cogCellResult)
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
			case 10:
				p04Zy6fc4vPPlhwlOZD(this);
				num = 2;
				if (CWxLjqfSWB7d4Ox37as())
				{
					break;
				}
				goto case 8;
			case 8:
				pQofqnBag6 = CvsCellLocation.PropertySheet;
				num = 10;
				break;
			case 9:
				return;
			case 5:
			case 11:
				if (kOJwRHf2hrbSS9bp4Qi(cogCellResult))
				{
					goto case 4;
				}
				z7JfBIwlHp &= (CvsCellFlags)short.MaxValue;
				num = 0;
				if (CWxLjqfSWB7d4Ox37as())
				{
					break;
				}
				goto case 0;
			default:
				num = 4;
				break;
			case 4:
				z7JfBIwlHp |= CvsCellFlags.Disabled;
				goto case 0;
			case 1:
				eNvhNefje2d2uI9yR40();
				num = 8;
				break;
			case 0:
			case 6:
			case 7:
				if (!(o1TEk2fWgDWEpA4jkK1(cogCellResult) is CvsCogError))
				{
					z7JfBIwlHp &= ~CvsCellFlags.Error;
					num = 12;
				}
				else
				{
					z7JfBIwlHp |= CvsCellFlags.Error;
					num = 9;
				}
				break;
			case 3:
				WrPfTF6q7i = cogCellResult;
				_ = 1;
				num = ((!wcSWaPfEQbhL4uWFLFd()) ? 11 : 6);
				break;
			case 2:
				pQofqnBag6 = location;
				num = 3;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	object ICloneable.Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return emmgcOf7hIjUEsQTis8(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool iEifgmLQRl(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sswLcMfKvYgfk2xWpf6(EKOFtrftQhyLX10ugTl(Expression), P_0, true, G7ISkUfCPjv3wCoGOCE()) == 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellComment GetComment()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCellComment)tZkxAafP8YLJ4WLflRV(WrPfTF6q7i);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal string GetExpression()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)(GuH2HFf3Dncd7nPHsFy(WrPfTF6q7i) ?? "");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEmpty()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tUg5YufxBKwIP3ilaMQ(Expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetDataTypeString(Type dataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!wcSWaPfEQbhL4uWFLFd())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0048;
		IL_008c:
		string result = HEwfJ18B6s[dataType];
		num = 5;
		goto IL_0048;
		IL_00a2:
		return result;
		IL_0026:
		if (HEwfJ18B6s.ContainsKey(dataType))
		{
			goto IL_008c;
		}
		goto IL_00a2;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 3:
				result = (string)To86gifqQMMj2hNjBFx(46812);
				num = 1;
				if (true)
				{
					continue;
				}
				goto IL_008c;
			default:
				goto IL_008c;
			case 5:
				goto IL_00a2;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type GetDataType(string dataTypeString)
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
		goto IL_0091;
		IL_00c4:
		_003C_003Ec__DisplayClass72_0 obj = default;
		KeyValuePair<Type, string> keyValuePair = HEwfJ18B6s.FirstOrDefault(obj._003CGetDataType_003Eb__0);
		num = 7;
		goto IL_0091;
		IL_00fd:
		Type result = default;
		return result;
		IL_0091:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				break;
			case 4:
				obj = new _003C_003Ec__DisplayClass72_0();
				num = 6;
				continue;
			case 6:
				obj.dataTypeString = dataTypeString;
				CWxLjqfSWB7d4Ox37as();
				if (wcSWaPfEQbhL4uWFLFd())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto IL_006a;
			case 1:
			case 3:
				goto IL_006a;
			default:
				num = 0;
				continue;
			case 0:
				goto IL_00c4;
			case 7:
				result = keyValuePair.Key;
				num = 8;
				if (!wcSWaPfEQbhL4uWFLFd())
				{
					continue;
				}
				goto IL_00fd;
			case 8:
				goto IL_00fd;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		result = typeof(object);
		goto IL_006a;
		IL_006a:
		if (HEwfJ18B6s.ContainsValue(obj.dataTypeString))
		{
			goto IL_00c4;
		}
		goto IL_00fd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfo GetCellInfo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellInfo(pQofqnBag6, (string)aq4UrufNoSJPGrYHC8h(WrPfTF6q7i), myFrivf1NYNpuFtTl3p(WrPfTF6q7i), oRHcIYfrumW4W3CbARr(WrPfTF6q7i));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCellInfo(CvsCellInfo info)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		do
		{
			IL_0068:
			switch (num)
			{
			case 3:
				WrPfTF6q7i.Name = (string)vqOrSAfIdxiiTErvDMD(info);
				wcSWaPfEQbhL4uWFLFd();
				if (CWxLjqfSWB7d4Ox37as())
				{
					num = 4;
					if (0 == 0)
					{
						goto IL_0068;
					}
					goto case 1;
				}
				num = 0;
				goto IL_0068;
			case 1:
			case 4:
				rlb90efREDTJFO3lusZ(WrPfTF6q7i, info.Input);
				break;
			case 5:
				return;
			}
			QTVtAgfaNnKhCVl4nkZ(WrPfTF6q7i, info.Output);
			num = 5;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return pQofqnBag6.GetHashCode();
	}

	internal abstract object InternalClone();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ValidateCellName(CvsCellLocation cell, string name, CvsCellCollection cellCollection, CvsSensor sensor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num3 = default;
		IEnumerator<INamedOperand> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (sensor == null)
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 7;
				}
				NY9lmafn1ehjVZHflfx(sensor, name);
				num = 7;
				break;
			case 7:
				if (cellCollection != null)
				{
					num = 8;
					break;
				}
				goto IL_0116;
			case 0:
			case 4:
			case 5:
				if (num3 >= Q0yfMNVGL9.Length)
				{
					num = 10;
					break;
				}
				if (name.Equals(Q0yfMNVGL9[num3], StringComparison.InvariantCultureIgnoreCase))
				{
					goto case 6;
				}
				num3++;
				num = 4;
				if (1 == 0)
				{
					return;
				}
				break;
			case 3:
				try
				{
					while (mReJGQf67CM6lT5cY1G(enumerator))
					{
						CvsCellInfo cvsCellInfo = (CvsCellInfo)enumerator.Current;
						wcSWaPfEQbhL4uWFLFd();
						int num2 = ((!CWxLjqfSWB7d4Ox37as()) ? 3 : 2);
						while (true)
						{
							switch (num2)
							{
							default:
								if (!tON3YmfMphUVuBNjwAC(name, vqOrSAfIdxiiTErvDMD(cvsCellInfo)))
								{
									break;
								}
								num2 = 4;
								if (CWxLjqfSWB7d4Ox37as())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 2:
								if (!QNgibSfbtwJYGIECe4E(cell, MSKl6OfXyVCJld5vLJ3(cvsCellInfo)))
								{
									break;
								}
								goto default;
							case 4:
								throw new ArgumentException((string)To86gifqQMMj2hNjBFx(46860));
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				goto IL_0116;
			default:
				_ = 0;
				if (CWxLjqfSWB7d4Ox37as())
				{
					num = 0;
					if (wcSWaPfEQbhL4uWFLFd())
					{
					}
				}
				else
				{
					num = 9;
				}
				break;
			case 2:
				throw new ArgumentException((string)To86gifqQMMj2hNjBFx(46828));
			case 8:
				enumerator = ((IEnumerable<INamedOperand>)vWFJm2fGRjJv4hjVVks(cellCollection)).GetEnumerator();
				num = 3;
				break;
			case 6:
			case 9:
				throw new ArgumentException((string)To86gifqQMMj2hNjBFx(46914));
			case 10:
				return;
				IL_0116:
				num3 = 0;
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNullOrEmpty(CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty(cell?.Expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type NhpjYcfvLblPUaYk9Ao(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J1WaCufHdXypu8kRKfE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Boolean;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EyFAYpfVPLkXKkaZdcp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Integer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p0qSGpfAKeh462spyqP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FloatingPoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GBxWk2fDmE2aTsf3Jsn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Action;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CWxLjqfSWB7d4Ox37as()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wcSWaPfEQbhL4uWFLFd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jI3TOafU0KwPHh9htjU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SAE4JPfT4HprRj8jRSN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ybyRrRfdZwQRelCS9sY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Face = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jtByiTfiw0CknU152k9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Value = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object To86gifqQMMj2hNjBFx(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pjePgPfBGaLR8rSRcnE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogProfileViewResult)P_0).Display;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNvhNefje2d2uI9yR40()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p04Zy6fc4vPPlhwlOZD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kOJwRHf2hrbSS9bp4Qi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Disabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o1TEk2fWgDWEpA4jkK1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object emmgcOf7hIjUEsQTis8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).InternalClone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EKOFtrftQhyLX10ugTl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.FindIdentifier((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G7ISkUfCPjv3wCoGOCE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sswLcMfKvYgfk2xWpf6(object P_0, object P_1, bool P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Compare((string)P_0, (string)P_1, P_2, (CultureInfo)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zfSmjMf5iWudS4n39H9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aTbooPfoa2REnpCvWbj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogError)P_0).Message;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tZkxAafP8YLJ4WLflRV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GetComment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i9HZqmfYx34edcolHsU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).HasComment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aq4UrufNoSJPGrYHC8h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tUg5YufxBKwIP3ilaMQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool myFrivf1NYNpuFtTl3p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Input;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oRHcIYfrumW4W3CbARr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Output;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GuH2HFf3Dncd7nPHsFy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tyNdvafOvoUHgCUGkOJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Condition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tON3YmfMphUVuBNjwAC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rB0pWSfQcPUb8KRdiv1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).CellStyle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oiDmfqflgnxTv07sB38(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GraphicsStyle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type FZiGJGfe8trDOb7asxn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q09J10fuFvwmUldFcbK(Type dataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetDataTypeString(dataType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vqOrSAfIdxiiTErvDMD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rlb90efREDTJFO3lusZ(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Input = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QTVtAgfaNnKhCVl4nkZ(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Output = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NY9lmafn1ehjVZHflfx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsSensor)P_0).ValidateCellName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vWFJm2fGRjJv4hjVVks(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).CreateCellInfoCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation MSKl6OfXyVCJld5vLJ3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QNgibSfbtwJYGIECe4E(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left != right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mReJGQf67CM6lT5cY1G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}
}
