using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class SnippetLocalizer
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public SnippetLocalizer _003C_003E4__this;

		public PasteBuffer snippet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass18_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			q2MmLXKiokl6IDthcLeY(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CLocalize_003Eb__0(PasteBufferCell cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !_003C_003E4__this.ExcludedCellOffsets.Contains(tGyqI1KiSmG2PpMyskLM(snippet, cell));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void q2MmLXKiokl6IDthcLeY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fe01HdKib49qt0xt1Dvq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TD5ZbeKiGl7BSLKLZ2M6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation tGyqI1KiSmG2PpMyskLM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).GetCellOffset((PasteBufferCell)P_1);
		}
	}

	[CompilerGenerated]
	private bool asDpwpNdtK;

	private CultureInfo UrrpyLSvEB;

	[CompilerGenerated]
	private readonly ISet<CvsCellLocation> TuApxLgJJk;

	[CompilerGenerated]
	private readonly ISet<string> tXmpv9aZvd;

	[CompilerGenerated]
	private readonly ResourceManager molpestOFY;

	public bool AssertOnMissingValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return asDpwpNdtK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			asDpwpNdtK = value;
		}
	}

	public CultureInfo Culture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UrrpyLSvEB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UrrpyLSvEB = value ?? ((Thread)UXsSj0wPeLWiTkfOKX8()).CurrentUICulture;
		}
	}

	public ISet<CvsCellLocation> ExcludedCellOffsets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TuApxLgJJk;
		}
	}

	public ISet<string> ExcludedStrings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tXmpv9aZvd;
		}
	}

	protected ResourceManager ResourceManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return molpestOFY;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetLocalizer(ResourceManager resourceManager)
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
			case 5:
				lkw0d7wsCY4GkaZEXpM();
				_ = 1;
				num = (g6kVhJwgFVfoVVsRrcC() ? 3 : 6);
				break;
			case 2:
				AssertOnMissingValue = true;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				TuApxLgJJk = new HashSet<CvsCellLocation>();
				goto default;
			default:
				tXmpv9aZvd = new HashSet<string>((IEqualityComparer<string>)K6sxGowvidD22WKfGbe());
				num = 0;
				break;
			case 1:
			case 6:
				base._002Ector();
				num = 2;
				break;
			case 0:
				molpestOFY = resourceManager ?? throw new ArgumentNullException((string)M9NK9Cwrd5fsFsk2h51(1416));
				Culture = ((Thread)UXsSj0wPeLWiTkfOKX8()).CurrentUICulture;
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Localize(PasteBuffer snippet, bool localizeEditStrings = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		IEnumerable<PasteBufferCell> enumerable = default;
		_003C_003Ec__DisplayClass18_0 obj = default;
		IEnumerator<PasteBufferCell> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (om8B2TwZ6WqpT1tPyov(ExcludedCellOffsets) > 0)
				{
					_ = 0;
					num = ((!K79tOZwlredKsdrKX6W()) ? 8 : 0);
					break;
				}
				goto case 6;
			case 0:
			case 5:
				enumerable = enumerable.Where(obj._003CLocalize_003Eb__0);
				goto case 6;
			case 2:
				enumerable = obj.snippet.Cells;
				goto case 7;
			default:
				num = 7;
				break;
			case 3:
				obj.snippet = snippet;
				num = 2;
				break;
			case 1:
				obj = new _003C_003Ec__DisplayClass18_0();
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				obj._003C_003E4__this = this;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
			case 8:
				enumerator = enumerable.GetEnumerator();
				num = 9;
				break;
			case 9:
				try
				{
					while (enumerator.MoveNext())
					{
						PasteBufferCell current = enumerator.Current;
						g6kVhJwgFVfoVVsRrcC();
						int num2;
						if (K79tOZwlredKsdrKX6W())
						{
							num2 = 2;
						}
						else
						{
							num2 = 3;
							if (1 == 0)
							{
								continue;
							}
						}
						switch (num2)
						{
						case 0:
						case 2:
							Localize(current, localizeEditStrings);
							break;
						}
					}
					return;
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Localize(PasteBufferCell cell, bool localizeEditStrings = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!K79tOZwlredKsdrKX6W()) ? 7 : 6);
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!bfWVf0wbTfwEdnD28SG(text))
				{
					num = 1;
					break;
				}
				goto case 5;
			case 5:
			case 7:
				LocalizeCellData(cell, localizeEditStrings);
				num = 8;
				break;
			case 2:
				text2 = LocalizeTopLevelExpression(text);
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
				if (!ExcludedCellOffsets.Contains(psd9OpwormBH2LkNmRI(T0FV5OwG5N5WOoaXvlu(cell))))
				{
					num = 2;
					break;
				}
				goto case 5;
			case 0:
			case 6:
				text = (string)EWy4LuwBqoBCK2A3v6J(cell);
				num = 3;
				break;
			case 4:
				O3UUDKwS3aLadk8MHGi(cell, text2);
				goto case 5;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LocalizeCellData(PasteBufferCell cell, bool localizeEditStrings = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		K79tOZwlredKsdrKX6W();
		int num;
		if (!g6kVhJwgFVfoVVsRrcC())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_0096;
			}
		}
		goto IL_0067;
		IL_0067:
		switch (num)
		{
		case 0:
		case 4:
			break;
		case 3:
			if (((string)EWy4LuwBqoBCK2A3v6J(cell)).StartsWith((string)M9NK9Cwrd5fsFsk2h51(1450), StringComparison.Ordinal))
			{
				goto IL_0096;
			}
			return;
		default:
			goto IL_0096;
		case 5:
			return;
		}
		goto IL_002a;
		IL_0096:
		LocalizeEditStringValues(cell);
		num = 5;
		goto IL_0067;
		IL_002a:
		if (localizeEditStrings)
		{
			num = 3;
			goto IL_0067;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LocalizeCellName(string cellName, CvsCellLocation cellOffset, string toolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string item3 = default;
		string item = default;
		bool item2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				return cellName;
			case 5:
				if (toolName.Equals(item3, StringComparison.Ordinal))
				{
					num = 4;
					if (K79tOZwlredKsdrKX6W())
					{
						continue;
					}
					goto case 8;
				}
				goto IL_0133;
			case 8:
				throw new ArgumentException((string)M9NK9Cwrd5fsFsk2h51(1474));
			case 3:
				if (!string.IsNullOrEmpty(toolName))
				{
					goto case 5;
				}
				goto IL_0133;
			default:
				num = 5;
				if (g6kVhJwgFVfoVVsRrcC())
				{
				}
				continue;
			case 1:
			case 6:
				cellName = (string)vqkBnxwqhoS4JIJIg0k(cellName, mPV1wyw8xcOIQHYvqPN(M9NK9Cwrd5fsFsk2h51(1044)));
				num = 9;
				continue;
			case 0:
				if (cellName != null)
				{
					if (!ExcludedCellOffsets.Contains(cellOffset))
					{
						(string snippetName, string propName, bool isInternal) tuple = EzSnippet.SplitCellName(cellName);
						item3 = tuple.snippetName;
						item = tuple.propName;
						item2 = tuple.isInternal;
						num = 3;
						if (true)
						{
							continue;
						}
						goto case 5;
					}
					_ = 0;
					if (K79tOZwlredKsdrKX6W())
					{
						num = 7;
						if (!g6kVhJwgFVfoVVsRrcC())
						{
							continue;
						}
						goto case 3;
					}
					num = 1;
					if (g6kVhJwgFVfoVVsRrcC())
					{
					}
					continue;
				}
				num = 8;
				continue;
			case 4:
				return (string)IqVi9uwkIdEG0SKIRih(this, toolName, item, item2);
			case 9:
				break;
				IL_0133:
				if (!item2)
				{
					break;
				}
				goto case 1;
			}
			break;
		}
		return LocalizeString(cellName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LocalizeToolCellName(string toolName, string shortName, bool isInternal)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippet.AssembleFullCellName(toolName, (string)zOG3NAwEW7Sl8G3NdOC(this, shortName), isInternal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LocalizeEditStringValues(PasteBufferCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (g6kVhJwgFVfoVVsRrcC() ? 1 : 4);
		JToken jToken = default;
		while (true)
		{
			switch (num)
			{
			default:
				((JToken)Tins2uw4GlFROBSJGax(cell))[(object)CdQUGaROfy7He9T0foW.KbIzwHEDLa(1524)] = (string?)zOG3NAwEW7Sl8G3NdOC(this, jToken?.ToString());
				num = 5;
				break;
			case 0:
			case 4:
				cell.Value = (JToken)MGecWjwXevJA3mq9J0L(LocalizeString(OB1xtmwpnEd2S0Ur4SQ(cell).ToString()));
				num = 3;
				break;
			case 3:
				jToken = (JToken)HxCbBaw9Q5dNNmMNGPh(cell.Data, M9NK9Cwrd5fsFsk2h51(1524));
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LocalizeTopLevelExpression(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (HgDRTuw7vZIbL4SVm6E(expr, M9NK9Cwrd5fsFsk2h51(1538), StringComparison.Ordinal))
		{
			return expr;
		}
		return LocalizeExpression(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LocalizeArg(string arg)
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
		goto IL_0042;
		IL_001a:
		if (HgDRTuw7vZIbL4SVm6E(arg, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1544), StringComparison.Ordinal))
		{
			goto IL_006f;
		}
		return LocalizeExpression(arg);
		IL_0042:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				goto IL_006f;
			case 4:
				goto IL_0091;
			case 5:
				return (string)ktCoWpw6wOroPJLfoSL(M9NK9Cwrd5fsFsk2h51(1544), text, M9NK9Cwrd5fsFsk2h51(1544));
			}
			break;
			IL_0091:
			arg = (string)i5JZQXw3E4aFm3Q9ByW(arg);
			_ = 1;
			num = ((!g6kVhJwgFVfoVVsRrcC()) ? 3 : 0);
		}
		goto IL_001a;
		IL_006f:
		text = (string)zOG3NAwEW7Sl8G3NdOC(this, lGObuTwjI0cQvgcluRx(arg, new char[1] { '"' }));
		num = 5;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string LocalizeExpression(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num2 = default;
		string text = default;
		List<string> list = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				num2 = 0;
				K79tOZwlredKsdrKX6W();
				num = ((!g6kVhJwgFVfoVVsRrcC()) ? 1 : 3);
				break;
			case 5:
				if (text != list[num2])
				{
					goto default;
				}
				goto case 7;
			default:
				expr = (string)up3lYHwCNQfI6CctokF(expr, num2, text);
				num = 7;
				break;
			case 7:
				num2++;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				list = CvsParse.FindAllArgs(expr).ToList();
				num = 6;
				break;
			case 1:
			case 2:
			case 8:
				if (num2 < cTPflZwALQ2g2fxSREH(list))
				{
					text = LocalizeArg(list[num2]);
					num = 5;
				}
				else
				{
					num = 9;
				}
				break;
			case 9:
				return expr;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string LocalizeString(string str)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string text2 = default;
		string text;
		while (true)
		{
			switch (num)
			{
			case 5:
				return str;
			case 7:
				if (text2 == null)
				{
					num = 6;
					continue;
				}
				goto case 9;
			case 0:
				if (!bfWVf0wbTfwEdnD28SG(str))
				{
					K79tOZwlredKsdrKX6W();
					num = (g6kVhJwgFVfoVVsRrcC() ? 3 : 8);
					continue;
				}
				goto case 5;
			case 2:
				if (text2 != null)
				{
					goto case 7;
				}
				goto case 3;
			case 3:
			case 4:
				text2 = STipH9LXdU(str);
				goto case 7;
			default:
				num = 7;
				if (!g6kVhJwgFVfoVVsRrcC())
				{
					continue;
				}
				goto case 9;
			case 9:
				text = text2;
				if (text == null)
				{
					num = 10;
					continue;
				}
				break;
			case 6:
				_ = AssertOnMissingValue;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 8:
				if (!ExcludedStrings.Contains(str))
				{
					text2 = (string)BHAOtBwRjRpFo5d8Dus(ResourceManager, str, Culture);
					num = 2;
				}
				else
				{
					num = 5;
				}
				continue;
			case 10:
				text = str;
				break;
			}
			break;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string STipH9LXdU(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bool flag = P_0.All(char.IsLower);
		bool flag2 = P_0.All(char.IsUpper);
		string text = (string)DgkLKxwTiM5NdhDPhRn(BjII2LwWbdnjkd6l98r(P_0, 0).ToString()) + (string)vqkBnxwqhoS4JIJIg0k(P_0, 1);
		if (flag)
		{
			return (string)BHAOtBwRjRpFo5d8Dus(ResourceManager, POPDxjwyOAW3clc2vIC(text, M9NK9Cwrd5fsFsk2h51(1550)), Culture);
		}
		if (flag2)
		{
			return (string)BHAOtBwRjRpFo5d8Dus(ResourceManager, POPDxjwyOAW3clc2vIC(text, M9NK9Cwrd5fsFsk2h51(1574)), Culture);
		}
		return (string)BHAOtBwRjRpFo5d8Dus(ResourceManager, POPDxjwyOAW3clc2vIC(text, M9NK9Cwrd5fsFsk2h51(1598)), Culture);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lkw0d7wsCY4GkaZEXpM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K6sxGowvidD22WKfGbe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return StringComparer.Ordinal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M9NK9Cwrd5fsFsk2h51(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UXsSj0wPeLWiTkfOKX8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Thread.CurrentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K79tOZwlredKsdrKX6W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g6kVhJwgFVfoVVsRrcC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int om8B2TwZ6WqpT1tPyov(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICollection<CvsCellLocation>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EWy4LuwBqoBCK2A3v6J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bfWVf0wbTfwEdnD28SG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T0FV5OwG5N5WOoaXvlu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation psd9OpwormBH2LkNmRI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O3UUDKwS3aLadk8MHGi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IqVi9uwkIdEG0SKIRih(object P_0, object P_1, object P_2, bool isInternal)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetLocalizer)P_0).LocalizeToolCellName((string)P_1, (string)P_2, isInternal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mPV1wyw8xcOIQHYvqPN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vqkBnxwqhoS4JIJIg0k(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zOG3NAwEW7Sl8G3NdOC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SnippetLocalizer)P_0).LocalizeString((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OB1xtmwpnEd2S0Ur4SQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MGecWjwXevJA3mq9J0L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HxCbBaw9Q5dNNmMNGPh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JToken)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tins2uw4GlFROBSJGax(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Data;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HgDRTuw7vZIbL4SVm6E(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i5JZQXw3E4aFm3Q9ByW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lGObuTwjI0cQvgcluRx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ktCoWpw6wOroPJLfoSL(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object up3lYHwCNQfI6CctokF(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cTPflZwALQ2g2fxSREH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<string>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BHAOtBwRjRpFo5d8Dus(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceManager)P_0).GetString((string)P_1, (CultureInfo)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char BjII2LwWbdnjkd6l98r(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DgkLKxwTiM5NdhDPhRn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToUpper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object POPDxjwyOAW3clc2vIC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}
}
