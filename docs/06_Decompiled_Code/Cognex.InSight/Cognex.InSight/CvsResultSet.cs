using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.Cnx.ComponentModel;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Graphic;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Sensor;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsResultSet : IDisposable, IServiceProvider
{
	private class pMOd7ea3RUZotWvFuM : ICnxReferenceCount, IDisposable
	{
		private readonly CvsResultSet ag971jifAX;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public pMOd7ea3RUZotWvFuM(CvsResultSet P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rpuo5RsLxnr7PK36iBZ6();
			int num = (BuwX2isL1QsotQ9ZalLM() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					opWtSGsL3rdWV8x8c8OX(this);
					goto case 2;
				default:
					num = 2;
					if (BuwX2isL1QsotQ9ZalLM())
					{
					}
					break;
				case 2:
					ag971jifAX = P_0;
					num = 5;
					if (rpuo5RsLxnr7PK36iBZ6())
					{
						break;
					}
					goto case 0;
				case 0:
				case 4:
					vhdYNFsLraMXHU8sLV8c();
					goto case 1;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int AddReference()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mGgnL6sLO0BoIKgYtaOA(ag971jifAX);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gEmnvAsLMtcy4TxuhJlJ(ag971jifAX);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vhdYNFsLraMXHU8sLV8c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void opWtSGsL3rdWV8x8c8OX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rpuo5RsLxnr7PK36iBZ6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BuwX2isL1QsotQ9ZalLM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int mGgnL6sLO0BoIKgYtaOA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).AddReference();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gEmnvAsLMtcy4TxuhJlJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsResultSet)P_0).Dispose();
		}
	}

	private readonly long W9aF92bor3;

	private readonly bool C1fFUoojf0;

	private readonly string CUMF0nrQ05;

	private readonly CvsCellCollection GMyFwDghyn;

	private long gAoFRpkB1X;

	private readonly CvsGraphicCollection Y3UFsHVJAo;

	private readonly CvsSheetInfo F0OF6jjgLd;

	private readonly CvsProcessorConstants pHeFHHrPOo;

	private readonly CvsCell dHvFK792Ci;

	private OrderedDictionary eOsFEHVePX;

	private CvsCogSheetResult UxMFQ1T6BS;

	private bool HWLFNIaIc2;

	private string LjSFirrAPv;

	private string cghFdyPXr2;

	private int mwxFu3WFvH;

	public long Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return W9aF92bor3;
		}
	}

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C1fFUoojf0;
		}
	}

	public string ResultsUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CUMF0nrQ05;
		}
	}

	public CvsCellCollection Cells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GMyFwDghyn;
		}
	}

	public long CellRequestId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gAoFRpkB1X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gAoFRpkB1X = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ResultsFromQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HWLFNIaIc2;
		}
	}

	public CvsGraphicCollection Graphics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y3UFsHVJAo;
		}
	}

	public OrderedDictionary Outputs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eOsFEHVePX;
		}
	}

	public string DefaultImageView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 13;
			CvsCogView cvsCogView = default;
			IDictionaryEnumerator enumerator = default;
			while (true)
			{
				object obj2;
				switch (num)
				{
				case 7:
					if (!string.IsNullOrEmpty(LjSFirrAPv))
					{
						break;
					}
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					if (cvsCogView != null)
					{
						num = 6;
						if (BqZGFFV79j36lyObCpE())
						{
						}
						continue;
					}
					goto case 3;
				case 9:
					enumerator = eOsFEHVePX.GetEnumerator();
					PLDLAqVWjrJ4aUXCE4t();
					if (!BqZGFFV79j36lyObCpE())
					{
						num = 10;
						continue;
					}
					num = 4;
					if (PLDLAqVWjrJ4aUXCE4t())
					{
						continue;
					}
					goto case 1;
				case 13:
					if (eOsFEHVePX != null)
					{
						num = 7;
						continue;
					}
					break;
				case 0:
					LjSFirrAPv = XyMQGZVYxD8Vxr3HVIx(enumerator) as string;
					num = 12;
					if (!BqZGFFV79j36lyObCpE())
					{
						continue;
					}
					goto case 4;
				case 4:
				case 8:
					obj2 = yUo4iAV3n62dBnJrOvH(cvsCogView);
					if (obj2 == null)
					{
						num = 1;
						continue;
					}
					goto IL_01a0;
				case 6:
				{
					object obj = TcRgQvVx0Vmc9Bx9P2F(cvsCogView);
					if (obj != null && ((IEnumerable)UIDUTtV1ieO6BevPUpJ(obj)).OfType<CvsCogImageLayer>().Any())
					{
						if (!nCCKWiVrq42PDusHcGw(LjSFirrAPv))
						{
							goto case 4;
						}
						goto case 11;
					}
					goto case 3;
				}
				default:
					num = 11;
					continue;
				case 11:
					LjSFirrAPv = XyMQGZVYxD8Vxr3HVIx(enumerator) as string;
					goto case 4;
				case 1:
					obj2 = "";
					goto IL_01a0;
				case 2:
					LjSFirrAPv = XyMQGZVYxD8Vxr3HVIx(enumerator) as string;
					break;
				case 3:
				case 10:
					if (jBcNmFVPTLWPu7rvTLr(enumerator))
					{
						if (enumerator.Value is CvsCogImageLayer)
						{
							num = 2;
							continue;
						}
						cvsCogView = SC0NdAVNiQ9yWgZTkYl(enumerator) as CvsCogView;
						num = 5;
					}
					else
					{
						num = 14;
					}
					continue;
				case 12:
				case 14:
					break;
					IL_01a0:
					if (tCRJOSVOhM6wadbN9VL(obj2).IsPrimaryViewGenerator())
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					}
					goto case 3;
				}
				break;
			}
			return LjSFirrAPv;
		}
	}

	public string DefaultPointCloudView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 11;
			if (!BqZGFFV79j36lyObCpE())
			{
				IDictionaryEnumerator enumerator = default;
				CvsCogView cvsCogView = default;
				bool? flag = default;
				bool? flag2 = default;
				bool flag3 = default;
				while (true)
				{
					bool? flag4;
					switch (num)
					{
					case 9:
						if (!enumerator.MoveNext())
						{
							num = 13;
							continue;
						}
						cvsCogView = enumerator.Value as CvsCogView;
						num = 4;
						continue;
					case 2:
						enumerator = eOsFEHVePX.GetEnumerator();
						num = 9;
						continue;
					case 10:
					{
						object obj = TcRgQvVx0Vmc9Bx9P2F(cvsCogView);
						if (obj == null)
						{
							goto default;
						}
						object obj2 = UIDUTtV1ieO6BevPUpJ(obj);
						if (obj2 == null)
						{
							num = 12;
							if (true)
							{
								continue;
							}
							goto case 12;
						}
						flag4 = ((IEnumerable)obj2).OfType<CvsCogImage3DLayer>().Any();
						goto IL_01a4;
					}
					default:
						PLDLAqVWjrJ4aUXCE4t();
						if (!BqZGFFV79j36lyObCpE())
						{
							num = 3;
							if (PLDLAqVWjrJ4aUXCE4t())
							{
								continue;
							}
							goto case 11;
						}
						num = 1;
						continue;
					case 11:
						if (eOsFEHVePX == null)
						{
							break;
						}
						num = 0;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 12:
						flag = null;
						goto case 1;
					case 0:
						if (string.IsNullOrEmpty(cghFdyPXr2))
						{
							num = 2;
							continue;
						}
						break;
					case 7:
						if (flag2 != flag3)
						{
							goto case 3;
						}
						goto IL_0173;
					case 3:
					case 6:
						if (!(SC0NdAVNiQ9yWgZTkYl(enumerator) is CvsCogImage3DLayer))
						{
							goto case 9;
						}
						goto IL_0173;
					case 1:
					case 8:
						flag4 = flag;
						goto IL_01a4;
					case 4:
						if (cvsCogView != null)
						{
							num = 10;
							continue;
						}
						goto case 3;
					case 5:
					case 13:
						break;
						IL_0173:
						cghFdyPXr2 = enumerator.Key as string;
						num = 5;
						continue;
						IL_01a4:
						flag2 = flag4;
						flag3 = true;
						num = 7;
						continue;
					}
					break;
				}
			}
			return cghFdyPXr2;
		}
	}

	public bool IsValidImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetInputImageLayer(DefaultImageView) != null;
		}
	}

	public bool IsValidImage3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetInputImage3DLayer(DefaultPointCloudView) != null;
		}
	}

	public CvsProcessorConstants ProcessorConstants
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pHeFHHrPOo;
		}
	}

	public CvsSheetInfo SheetInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return F0OF6jjgLd;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsCell PropertySheetCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dHvFK792Ci;
		}
	}

	public double ExecutionTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UxMFQ1T6BS?.Time ?? 0.0;
		}
	}

	public string[] Views
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BqZGFFV79j36lyObCpE();
			int num;
			if (PLDLAqVWjrJ4aUXCE4t())
			{
				num = 3;
				if (BqZGFFV79j36lyObCpE())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0046;
				}
			}
			goto IL_0084;
			IL_0067:
			IEnumerator enumerator = default;
			if (eOsFEHVePX != null)
			{
				enumerator = (IEnumerator)x3QWEKVKemEyDpqFHHi(AdowZjVMsylTRn78SBl(eOsFEHVePX));
				num = 5;
				goto IL_0084;
			}
			goto IL_0046;
			IL_0046:
			return Array.Empty<string>();
			IL_002e:
			List<string> list = new List<string>();
			goto IL_0067;
			IL_0084:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 4:
					goto IL_0046;
				case 1:
				case 2:
					goto IL_0067;
				default:
					num = 4;
					continue;
				case 5:
					try
					{
						while (enumerator.MoveNext())
						{
							CvsCogView cvsCogView = hZU77PV5rVdfjgtbulJ(enumerator) as CvsCogView;
							_ = 1;
							int num2 = (BqZGFFV79j36lyObCpE() ? 2 : 3);
							while (true)
							{
								switch (num2)
								{
								case 0:
								case 3:
									if (cvsCogView != null)
									{
										goto IL_0113;
									}
									break;
								default:
									goto IL_0113;
								case 4:
									break;
								}
								break;
								IL_0113:
								list.Add((string)mMfCOJVQhUYmo0oAnmA(cvsCogView));
								num2 = 4;
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable disposable)
						{
							xeXpPBVokfi545Y9QKE(disposable);
						}
					}
					return (string[])a8Wn3vVlhkBJLhAnaFM(list);
				}
				break;
			}
			goto IL_002e;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsResultSet()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!PLDLAqVWjrJ4aUXCE4t()) ? 9 : 4);
		do
		{
			IL_009a:
			switch (num)
			{
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				if (0 == 0)
				{
					goto IL_009a;
				}
				goto case 1;
			case 1:
				C1fFUoojf0 = true;
				num = 11;
				goto IL_009a;
			case 3:
				LjSFirrAPv = string.Empty;
				num = 6;
				goto IL_009a;
			case 8:
				gAoFRpkB1X = -1L;
				num = 3;
				goto IL_009a;
			case 7:
			case 9:
				eOsFEHVePX = new OrderedDictionary();
				num = 1;
				goto IL_009a;
			case 5:
				BD7B4qVt77AewbGXQLs(this);
				goto case 2;
			default:
				num = 2;
				goto IL_009a;
			case 10:
				Y3UFsHVJAo = new CvsGraphicCollection();
				goto case 7;
			case 2:
				GMyFwDghyn = new CvsCellCollection();
				num = 10;
				if (true)
				{
					goto IL_009a;
				}
				break;
			case 6:
				break;
			case 11:
				return;
			}
			cghFdyPXr2 = string.Empty;
			num = 5;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsResultSet(long id, string resultsUrl, CvsCellCollection cells, CvsProcessorConstants processorConstants, CvsSheetInfo sheetInfo, CvsCell propertySheetCell, OrderedDictionary outputs, CvsCogSheetResult sheetResult)
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
			case 14:
				cells = new CvsCellCollection();
				num = 13;
				break;
			case 2:
				cghFdyPXr2 = string.Empty;
				num = 6;
				break;
			case 9:
				pHeFHHrPOo = processorConstants;
				num = 5;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					break;
				}
				goto case 10;
			case 10:
				UxMFQ1T6BS = sheetResult;
				num = 16;
				break;
			case 12:
				W9aF92bor3 = id;
				goto case 0;
			default:
				num = 0;
				break;
			case 13:
				Y3UFsHVJAo = new CvsGraphicCollection();
				num = 12;
				if (!BqZGFFV79j36lyObCpE())
				{
					break;
				}
				goto case 3;
			case 3:
				GMyFwDghyn = cells;
				num = 9;
				break;
			case 6:
				base._002Ector();
				goto case 4;
			case 1:
			case 15:
				gAoFRpkB1X = -1L;
				LjSFirrAPv = string.Empty;
				num = 2;
				break;
			case 0:
				CUMF0nrQ05 = resultsUrl;
				num = 3;
				break;
			case 11:
				HWLFNIaIc2 = false;
				eOsFEHVePX = outputs;
				num = 10;
				break;
			case 7:
				WPgMC3VCFdGC4uOnBIW();
				_ = 1;
				if (BqZGFFV79j36lyObCpE())
				{
					num = 8;
					if (PLDLAqVWjrJ4aUXCE4t())
					{
						break;
					}
					goto case 1;
				}
				num = 15;
				break;
			case 5:
				F0OF6jjgLd = sheetInfo;
				dHvFK792Ci = propertySheetCell;
				num = 11;
				break;
			case 4:
			case 8:
				if (cells == null)
				{
					num = 14;
					break;
				}
				goto case 13;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int AddReference()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ++mwxFu3WFvH;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!PLDLAqVWjrJ4aUXCE4t())
		{
			goto IL_001e;
		}
		goto IL_0077;
		IL_001e:
		xSeFnSljRK(_0020: true);
		num = 5;
		if (false)
		{
			goto IL_0031;
		}
		goto IL_0077;
		IL_0077:
		switch (num)
		{
		case 4:
			goto IL_0031;
		case 1:
		case 3:
			if (mwxFu3WFvH < 1)
			{
				break;
			}
			return;
		case 5:
			return;
		}
		goto IL_001e;
		IL_0031:
		mwxFu3WFvH--;
		BqZGFFV79j36lyObCpE();
		num = (PLDLAqVWjrJ4aUXCE4t() ? 3 : 0);
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xSeFnSljRK(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PLDLAqVWjrJ4aUXCE4t();
		int num = (BqZGFFV79j36lyObCpE() ? 2 : 3);
		IEnumerator enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				if (P_0)
				{
					goto case 1;
				}
				return;
			case 4:
				enumerator = (IEnumerator)x3QWEKVKemEyDpqFHHi(Y3UFsHVJAo);
				num = 5;
				break;
			case 1:
			case 2:
				if (Y3UFsHVJAo != null)
				{
					goto case 4;
				}
				return;
			default:
				num = 4;
				break;
			case 5:
				try
				{
					while (jBcNmFVPTLWPu7rvTLr(enumerator))
					{
						CvsGraphic cvsGraphic = (CvsGraphic)hZU77PV5rVdfjgtbulJ(enumerator);
						BqZGFFV79j36lyObCpE();
						int num2;
						if (PLDLAqVWjrJ4aUXCE4t())
						{
							num2 = 3;
						}
						else
						{
							num2 = 2;
							if (BqZGFFV79j36lyObCpE())
							{
							}
						}
						while (true)
						{
							switch (num2)
							{
							default:
								goto IL_00c3;
							case 0:
							case 3:
								if (cvsGraphic is IDisposable)
								{
									goto IL_00c3;
								}
								break;
							case 4:
								break;
							}
							break;
							IL_00c3:
							xeXpPBVokfi545Y9QKE((IDisposable)cvsGraphic);
							num2 = 4;
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						xeXpPBVokfi545Y9QKE(disposable);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetResultsFromQueue(bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HWLFNIaIc2 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogImageLayer GetInputImageLayer(string imageView = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCogView cvsCogView = default;
		object value = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				if (cvsCogView != null)
				{
					num = 8;
					continue;
				}
				return value as CvsCogImageLayer;
			case 1:
				if (eOsFEHVePX == null)
				{
					break;
				}
				_ = 1;
				if (!BqZGFFV79j36lyObCpE())
				{
					num = 4;
					continue;
				}
				num = 6;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					continue;
				}
				goto case 8;
			case 3:
			case 4:
				if (!eOsFEHVePX.TryGetValue(imageView, out value))
				{
					break;
				}
				goto case 0;
			default:
				num = 0;
				continue;
			case 7:
				imageView = DefaultImageView;
				num = 1;
				continue;
			case 2:
				if (!nCCKWiVrq42PDusHcGw(imageView))
				{
					goto case 1;
				}
				num = 7;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					continue;
				}
				goto case 0;
			case 0:
				cvsCogView = value as CvsCogView;
				goto case 5;
			case 8:
				return (CvsCogImageLayer)((object[])jJE80PVeitZGtKhYDRn(TcRgQvVx0Vmc9Bx9P2F(cvsCogView))).Find([MethodImpl(MethodImplOptions.NoInlining)] (object x) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return x is CvsCogImageLayer;
				});
			}
			break;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogImage3DLayer GetInputImage3DLayer(string imageView = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogView cvsCogView = default;
		object value = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (cvsCogView != null)
				{
					num = 8;
					continue;
				}
				return value as CvsCogImage3DLayer;
			case 3:
				if (!eOsFEHVePX.TryGetValue(imageView, out value))
				{
					break;
				}
				goto default;
			case 2:
				if (eOsFEHVePX == null)
				{
					break;
				}
				num = 3;
				if (!BqZGFFV79j36lyObCpE())
				{
					continue;
				}
				goto case 0;
			case 0:
				if (nCCKWiVrq42PDusHcGw(imageView))
				{
					_ = 0;
					if (PLDLAqVWjrJ4aUXCE4t())
					{
						num = 6;
						continue;
					}
					num = 5;
					if (PLDLAqVWjrJ4aUXCE4t())
					{
						continue;
					}
				}
				goto case 2;
			default:
				cvsCogView = value as CvsCogView;
				num = 7;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 6:
				imageView = DefaultPointCloudView;
				num = 2;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					continue;
				}
				goto case 8;
			case 8:
				return (CvsCogImage3DLayer)((object[])jJE80PVeitZGtKhYDRn(TcRgQvVx0Vmc9Bx9P2F(cvsCogView))).Find([MethodImpl(MethodImplOptions.NoInlining)] (object x) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return x is CvsCogImage3DLayer;
				});
			}
			break;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPrimaryImageUrl(string imageView = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (PLDLAqVWjrJ4aUXCE4t())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_005b;
		IL_0026:
		if (eOsFEHVePX != null)
		{
			goto IL_009a;
		}
		goto IL_00c8;
		IL_00c8:
		return string.Empty;
		IL_009a:
		if (string.IsNullOrEmpty(imageView))
		{
			num = 4;
			goto IL_005b;
		}
		goto IL_00af;
		IL_005b:
		CvsCogImageLayer inputImageLayer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				break;
			case 4:
				imageView = DefaultImageView;
				goto IL_00af;
			default:
				num = 2;
				continue;
			case 3:
				goto IL_008a;
			case 1:
			case 5:
				goto IL_009a;
			case 2:
				goto IL_00af;
			case 7:
				return (string)zEsknQVujVxLZSacgy1(inputImageLayer);
			}
			break;
			IL_008a:
			if (inputImageLayer != null)
			{
				num = 7;
				continue;
			}
			goto IL_00c8;
		}
		goto IL_0026;
		IL_00af:
		inputImageLayer = GetInputImageLayer(imageView);
		num = 3;
		goto IL_005b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetPrimaryImageRectangle(string imageView = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCogImageLayer inputImageLayer = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				if (!nCCKWiVrq42PDusHcGw(imageView))
				{
					goto case 6;
				}
				goto case 0;
			case 6:
				inputImageLayer = GetInputImageLayer(imageView);
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				if (eOsFEHVePX != null)
				{
					PLDLAqVWjrJ4aUXCE4t();
					num = ((!BqZGFFV79j36lyObCpE()) ? 5 : 0);
					continue;
				}
				break;
			case 0:
			case 2:
				imageView = DefaultImageView;
				goto case 6;
			default:
				num = 6;
				continue;
			case 4:
				if (inputImageLayer == null)
				{
					break;
				}
				num = 7;
				if (!BqZGFFV79j36lyObCpE())
				{
					continue;
				}
				goto case 7;
			case 7:
				return new Rectangle(0, 0, ebJ6QGVIDfsBwItu58s(inputImageLayer), z65HiOVRVHnF8k0MxjF(inputImageLayer));
			}
			break;
		}
		return Rectangle.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsView(string imageView)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (eOsFEHVePX != null)
		{
			return WHQVHvVa51CKaYDAayg(eOsFEHVePX, imageView);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Size GetViewportSize(string imageView = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsCogView cvsCogView = default;
		object value = default;
		CvsCogImageLayer cvsCogImageLayer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 7:
				return new Size(((CvsCogViewPort)h28EuwVnbNxxUkRHr10(TcRgQvVx0Vmc9Bx9P2F(cvsCogView))).Width, ((CvsCogViewPort)h28EuwVnbNxxUkRHr10(TcRgQvVx0Vmc9Bx9P2F(cvsCogView))).Height);
			case 6:
				imageView = DefaultImageView;
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				if (!(value is CvsCogView))
				{
					if (!(value is CvsCogImageLayer))
					{
						break;
					}
					goto case 2;
				}
				num = 9;
				continue;
			case 3:
				eOsFEHVePX.TryGetValue(imageView, out value);
				goto case 5;
			default:
				num = 5;
				continue;
			case 4:
				value = null;
				num = 10;
				if (PLDLAqVWjrJ4aUXCE4t())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 8:
				cvsCogImageLayer = (CvsCogImageLayer)value;
				num = 11;
				continue;
			case 9:
				cvsCogView = (CvsCogView)value;
				_ = 0;
				if (!PLDLAqVWjrJ4aUXCE4t())
				{
					num = 2;
					continue;
				}
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 10;
			case 10:
				if (eOsFEHVePX != null)
				{
					num = 3;
					continue;
				}
				break;
			case 1:
				if (string.IsNullOrEmpty(imageView))
				{
					num = 6;
					continue;
				}
				goto case 4;
			case 11:
				return new Size(ebJ6QGVIDfsBwItu58s(cvsCogImageLayer), z65HiOVRVHnF8k0MxjF(cvsCogImageLayer));
			}
			break;
		}
		return Size.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	object IServiceProvider.GetService(Type serviceType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (GhIjHCVGN7iDYWKrjGb(serviceType, typeof(ICnxReferenceCount)))
		{
			return new pMOd7ea3RUZotWvFuM(this);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BD7B4qVt77AewbGXQLs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PLDLAqVWjrJ4aUXCE4t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BqZGFFV79j36lyObCpE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WPgMC3VCFdGC4uOnBIW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x3QWEKVKemEyDpqFHHi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hZU77PV5rVdfjgtbulJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xeXpPBVokfi545Y9QKE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jBcNmFVPTLWPu7rvTLr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XyMQGZVYxD8Vxr3HVIx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IDictionaryEnumerator)P_0).Key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SC0NdAVNiQ9yWgZTkYl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IDictionaryEnumerator)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TcRgQvVx0Vmc9Bx9P2F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogView)P_0).Record;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UIDUTtV1ieO6BevPUpJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogViewRecord)P_0).Layers;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nCCKWiVrq42PDusHcGw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yUo4iAV3n62dBnJrOvH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogView)P_0).Source;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation tCRJOSVOhM6wadbN9VL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AdowZjVMsylTRn78SBl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OrderedDictionary)P_0).Values;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mMfCOJVQhUYmo0oAnmA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogView)P_0).Title;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a8Wn3vVlhkBJLhAnaFM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<string>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jJE80PVeitZGtKhYDRn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogViewRecord)P_0).Layers;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zEsknQVujVxLZSacgy1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ebJ6QGVIDfsBwItu58s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int z65HiOVRVHnF8k0MxjF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImageLayer)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WHQVHvVa51CKaYDAayg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OrderedDictionary)P_0).Contains(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object h28EuwVnbNxxUkRHr10(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogViewRecord)P_0).Viewport;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GhIjHCVGN7iDYWKrjGb(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}
}
