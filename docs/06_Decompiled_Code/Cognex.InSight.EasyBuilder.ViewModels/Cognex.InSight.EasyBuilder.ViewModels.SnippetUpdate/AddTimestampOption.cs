using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class AddTimestampOption : ISnippetUpdate
{
	private readonly SnippetLocalizer My5KsJLWic;

	private readonly CvsCellLocation FjLKKS8wAT;

	private readonly CvsCellLocation S3NKGAv9YL;

	private readonly CvsCellLocation Ib7KBFiyEE;

	private readonly CvsCellLocation muBKZXmcyR;

	private readonly CvsCellLocation jfwKn1odBK;

	private readonly CvsCellLocation RRHKt23PQh;

	private readonly CvsCellLocation MbQKYs30GN;

	private readonly CvsCellLocation A5HK0nrQaT;

	private readonly CvsCellLocation nntKVrfEfo;

	private readonly CvsCellLocation SU7KLO0roo;

	private readonly CvsCellLocation VyDKJhxxCL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTimestampOption(SnippetLocalizer localizer)
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
			case 2:
			case 13:
				S3NKGAv9YL = new CvsCellLocation(4, 6);
				num = 1;
				break;
			case 0:
				muBKZXmcyR = new CvsCellLocation(5, 1);
				num = 10;
				break;
			case 12:
				My5KsJLWic = localizer;
				num = 14;
				break;
			case 4:
				MbQKYs30GN = new CvsCellLocation(5, 5);
				goto case 5;
			case 6:
				base._002Ector();
				num = 12;
				break;
			case 1:
				Ib7KBFiyEE = new CvsCellLocation(5, 0);
				num = 0;
				break;
			case 3:
				SU7KLO0roo = new CvsCellLocation(4, 3);
				VyDKJhxxCL = new CvsCellLocation(5, 4);
				num = 6;
				break;
			case 7:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 11;
				if (AXPKInzGUI48TkKhLuK())
				{
				}
				break;
			case 11:
				FjLKKS8wAT = new CvsCellLocation(4, 4);
				_ = 1;
				if (AXPKInzGUI48TkKhLuK())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 6;
				}
				num = 13;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					break;
				}
				goto case 5;
			case 5:
			case 8:
				A5HK0nrQaT = new CvsCellLocation(5, 6);
				nntKVrfEfo = new CvsCellLocation(4, 1);
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 9:
				RRHKt23PQh = new CvsCellLocation(5, 3);
				goto case 4;
			default:
				num = 4;
				break;
			case 10:
				jfwKn1odBK = new CvsCellLocation(5, 2);
				num = 9;
				if (false)
				{
					return;
				}
				break;
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nj9tPSzbJ2Ev40vkjve();
		int num;
		if (!AXPKInzGUI48TkKhLuK())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_00da;
			}
		}
		goto IL_01a0;
		IL_01a0:
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
			case 8:
				pasteBuffer = new ExpressionEditUpdate(VyDKJhxxCL, MNyKPDgxpv, [MethodImpl(MethodImplOptions.NoInlining)] (string exp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return exp;
				}).Apply(pasteBuffer);
				num = 11;
				continue;
			case 7:
				pasteBuffer = new AddCellUpdate(FjLKKS8wAT, jlAKkEX6jq, My5KsJLWic).Apply(pasteBuffer);
				goto case 6;
			case 1:
				goto IL_00da;
			case 2:
				goto IL_010b;
			case 0:
			case 4:
				pasteBuffer = new AddCellUpdate(Ib7KBFiyEE, doOKy0riWl, My5KsJLWic).Apply(originalSnippet);
				num = 2;
				continue;
			case 3:
				pasteBuffer = new AddCellUpdate(S3NKGAv9YL, HDqK24d5Bn, My5KsJLWic).Apply(pasteBuffer);
				goto case 9;
			default:
				num = 9;
				continue;
			case 10:
				pasteBuffer = new AddCellUpdate(RRHKt23PQh, ljRKeYDjR1, My5KsJLWic).Apply(pasteBuffer);
				num = 3;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					continue;
				}
				goto case 9;
			case 9:
				pasteBuffer = new AddCellUpdate(MbQKYs30GN, qlyKqWFInC, My5KsJLWic).Apply(pasteBuffer);
				num = 1;
				continue;
			case 11:
				return pasteBuffer;
			}
			break;
		}
		goto IL_002a;
		IL_010b:
		pasteBuffer = new AddCellUpdate(muBKZXmcyR, F53KxWjs3Y, My5KsJLWic).Apply(pasteBuffer);
		num = 5;
		goto IL_01a0;
		IL_002a:
		pasteBuffer = new AddCellUpdate(jfwKn1odBK, NbLKvLAY6I, My5KsJLWic).Apply(pasteBuffer);
		num = 10;
		goto IL_01a0;
		IL_00da:
		pasteBuffer = new AddCellUpdate(A5HK0nrQaT, RKLKiJPIjs, My5KsJLWic).Apply(pasteBuffer);
		num = 7;
		if (1 == 0)
		{
			goto IL_010b;
		}
		goto IL_01a0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell doOKy0riWl(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(Ib7KBFiyEE);
		JObject jObject = new JObject();
		x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(1624), iE2tJyzSGt5lI1Tuh3U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344)));
		x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8360), rNFK8Sz8U2hH8kSqwTP(11));
		x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8368), iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(8384)));
		JObject data = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		TmuOfRzqdYqUrs3FLnF(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(18668));
		pasteBufferCell.State = "";
		pasteBufferCell.Name = (string)c5hOQhzo1wn2AyC7w3G(31254);
		i6obc3zpFU8m2gTnVYM(pasteBufferCell, HfoxjCzEtY5Ue2LG6ra(1.0));
		pasteBufferCell.Data = data;
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell F53KxWjs3Y(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cvsCellLocation = default;
		JObject jObject = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				cvsCellLocation = uSZbTKzX9Wns5oC8Xk3(P_0, muBKZXmcyR);
				AXPKInzGUI48TkKhLuK();
				if (nj9tPSzbJ2Ev40vkjve())
				{
					num = 3;
					break;
				}
				num = 4;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					break;
				}
				goto default;
			case 1:
			case 3:
				My5KsJLWic.ExcludedCellOffsets.Add(cvsCellLocation);
				goto default;
			default:
			{
				JObject jObject2 = new JObject { [(string)c5hOQhzo1wn2AyC7w3G(1624)] = (string?)c5hOQhzo1wn2AyC7w3G(8344) };
				x6jVGrzk0HYQP2srSAp(jObject2, c5hOQhzo1wn2AyC7w3G(8360), rNFK8Sz8U2hH8kSqwTP(122));
				x6jVGrzk0HYQP2srSAp(jObject2, c5hOQhzo1wn2AyC7w3G(8368), iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(31808)));
				jObject = jObject2;
				num = 5;
				break;
			}
			case 5:
			{
				PasteBufferCell pasteBufferCell = new PasteBufferCell(cvsCellLocation);
				TmuOfRzqdYqUrs3FLnF(pasteBufferCell, c5hOQhzo1wn2AyC7w3G(32140));
				kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
				WquhKUz4yxCm9wmj6Iq(pasteBufferCell, c5hOQhzo1wn2AyC7w3G(31304));
				i6obc3zpFU8m2gTnVYM(pasteBufferCell, HfoxjCzEtY5Ue2LG6ra(1.0));
				BMPo9rz7JA55wVrO7JV(pasteBufferCell, jObject);
				return pasteBufferCell;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell NbLKvLAY6I(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (AXPKInzGUI48TkKhLuK())
		{
			goto IL_001e;
		}
		goto IL_011f;
		IL_001e:
		CvsCellLocation cvsCellLocation = default;
		My5KsJLWic.ExcludedCellOffsets.Add(cvsCellLocation);
		num = 2;
		goto IL_011f;
		IL_011f:
		CvsCellLocation item = default;
		string text2 = default;
		string text = default;
		JObject jObject2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				item = uSZbTKzX9Wns5oC8Xk3(P_0, muBKZXmcyR);
				num = 0;
				if (AXPKInzGUI48TkKhLuK())
				{
				}
				continue;
			case 5:
			case 7:
				text2 = (string)c45jDRz3Xpwt4B1Y8pa(CdQUGaROfy7He9T0foW.KbIzwHEDLa(32370), text, c5hOQhzo1wn2AyC7w3G(32388));
				goto case 6;
			case 6:
			case 8:
			{
				JObject jObject = new JObject();
				x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(1624), iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(8344)));
				jObject[(string)c5hOQhzo1wn2AyC7w3G(8360)] = (JToken?)rNFK8Sz8U2hH8kSqwTP(122);
				x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8368), iE2tJyzSGt5lI1Tuh3U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(31808)));
				jObject2 = jObject;
				num = 9;
				continue;
			}
			case 4:
				cvsCellLocation = uSZbTKzX9Wns5oC8Xk3(P_0, jfwKn1odBK);
				num = 3;
				continue;
			case 0:
				text = item.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				My5KsJLWic.ExcludedCellOffsets.Add(item);
				AXPKInzGUI48TkKhLuK();
				if (!nj9tPSzbJ2Ev40vkjve())
				{
					num = 8;
					continue;
				}
				num = 7;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					continue;
				}
				goto case 9;
			case 9:
			{
				PasteBufferCell pasteBufferCell = new PasteBufferCell(cvsCellLocation);
				TmuOfRzqdYqUrs3FLnF(pasteBufferCell, text2);
				kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
				WquhKUz4yxCm9wmj6Iq(pasteBufferCell, "");
				pasteBufferCell.Value = (JToken)HfoxjCzEtY5Ue2LG6ra(1.0);
				BMPo9rz7JA55wVrO7JV(pasteBufferCell, jObject2);
				return pasteBufferCell;
			}
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell ljRKeYDjR1(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell pasteBufferCell = new PasteBufferCell(uSZbTKzX9Wns5oC8Xk3(P_0, RRHKt23PQh));
		TmuOfRzqdYqUrs3FLnF(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(32598));
		kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
		WquhKUz4yxCm9wmj6Iq(pasteBufferCell, "");
		i6obc3zpFU8m2gTnVYM(pasteBufferCell, HfoxjCzEtY5Ue2LG6ra(1.0));
		BMPo9rz7JA55wVrO7JV(pasteBufferCell, null);
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell HDqK24d5Bn(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!nj9tPSzbJ2Ev40vkjve())
		{
			goto IL_001e;
		}
		goto IL_003c;
		IL_001e:
		PasteBufferCell pasteBufferCell = default;
		WquhKUz4yxCm9wmj6Iq(pasteBufferCell, "");
		goto IL_0065;
		IL_003c:
		JObject jObject2 = default;
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0065;
			case 3:
			case 5:
				BMPo9rz7JA55wVrO7JV(pasteBufferCell, jObject2);
				num = 8;
				continue;
			case 2:
			case 4:
				pasteBufferCell.Value = (JToken)HfoxjCzEtY5Ue2LG6ra(1.0);
				goto case 3;
			case 7:
				TmuOfRzqdYqUrs3FLnF(pasteBufferCell, bglqDGzjLmnMuNXgD6c(new string[5]
				{
					(string)c5hOQhzo1wn2AyC7w3G(32656),
					text,
					(string)c5hOQhzo1wn2AyC7w3G(5424),
					text2,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970)
				}));
				num = 6;
				continue;
			case 0:
			{
				CvsCellLocation loc = uSZbTKzX9Wns5oC8Xk3(P_0, S3NKGAv9YL);
				text = uSZbTKzX9Wns5oC8Xk3(P_0, RRHKt23PQh).ToString(absoluteRow: true, absoluteColumn: true);
				text2 = uSZbTKzX9Wns5oC8Xk3(P_0, jfwKn1odBK).ToString(absoluteRow: true, absoluteColumn: true);
				JObject jObject = new JObject();
				x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(1624), iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(8344)));
				x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8360), rNFK8Sz8U2hH8kSqwTP(11));
				x6jVGrzk0HYQP2srSAp(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), (JToken)(string?)c5hOQhzo1wn2AyC7w3G(32620));
				jObject2 = jObject;
				pasteBufferCell = new PasteBufferCell(loc);
				num = 7;
				continue;
			}
			case 6:
				pasteBufferCell.State = "";
				num = 1;
				continue;
			case 8:
				return pasteBufferCell;
			}
			break;
		}
		goto IL_001e;
		IL_0065:
		nj9tPSzbJ2Ev40vkjve();
		num = (AXPKInzGUI48TkKhLuK() ? 3 : 2);
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell qlyKqWFInC(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		string text = default;
		string text2 = default;
		string text3 = default;
		JObject jObject = default;
		PasteBufferCell pasteBufferCell = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			{
				CvsCellLocation loc = uSZbTKzX9Wns5oC8Xk3(P_0, MbQKYs30GN);
				text = uSZbTKzX9Wns5oC8Xk3(P_0, nntKVrfEfo).ToString(absoluteRow: true, absoluteColumn: true);
				text2 = uSZbTKzX9Wns5oC8Xk3(P_0, Ib7KBFiyEE).ToString(absoluteRow: true, absoluteColumn: true);
				text3 = P_0.GetLocationFromOrigin(S3NKGAv9YL).ToString(absoluteRow: true, absoluteColumn: true);
				JObject jObject2 = new JObject();
				x6jVGrzk0HYQP2srSAp(jObject2, c5hOQhzo1wn2AyC7w3G(1624), (JToken)(string?)c5hOQhzo1wn2AyC7w3G(8344));
				x6jVGrzk0HYQP2srSAp(jObject2, c5hOQhzo1wn2AyC7w3G(8360), rNFK8Sz8U2hH8kSqwTP(10));
				x6jVGrzk0HYQP2srSAp(jObject2, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), iE2tJyzSGt5lI1Tuh3U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(32678)));
				jObject = jObject2;
				pasteBufferCell = new PasteBufferCell(loc);
				num = 2;
				break;
			}
			case 2:
				pasteBufferCell.Expression = (string)bglqDGzjLmnMuNXgD6c(new string[7]
				{
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(32714),
					text,
					(string)c5hOQhzo1wn2AyC7w3G(32742),
					text2,
					(string)c5hOQhzo1wn2AyC7w3G(5424),
					text3,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(32754)
				});
				num = 1;
				break;
			default:
				i6obc3zpFU8m2gTnVYM(pasteBufferCell, (JToken)1.0);
				num = 6;
				break;
			case 6:
				BMPo9rz7JA55wVrO7JV(pasteBufferCell, jObject);
				num = 8;
				break;
			case 0:
			case 3:
				pasteBufferCell.Name = "";
				goto default;
			case 1:
				do
				{
					kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
					AXPKInzGUI48TkKhLuK();
					if (!nj9tPSzbJ2Ev40vkjve())
					{
						num = 5;
						continue;
					}
					num = 0;
					break;
				}
				while (false);
				break;
			case 8:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell RKLKiJPIjs(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		PasteBufferCell pasteBufferCell = default;
		JObject jObject2 = default;
		string text = default;
		string text2 = default;
		string text3 = default;
		string text4 = default;
		string text5 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				BMPo9rz7JA55wVrO7JV(pasteBufferCell, jObject2);
				num = 8;
				break;
			case 7:
				TmuOfRzqdYqUrs3FLnF(pasteBufferCell, bglqDGzjLmnMuNXgD6c(new string[11]
				{
					(string)c5hOQhzo1wn2AyC7w3G(32714),
					text,
					(string)c5hOQhzo1wn2AyC7w3G(32742),
					text2,
					(string)c5hOQhzo1wn2AyC7w3G(5424),
					text3,
					(string)c5hOQhzo1wn2AyC7w3G(32768),
					text4,
					(string)c5hOQhzo1wn2AyC7w3G(5424),
					text5,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(32754)
				}));
				num = 2;
				break;
			case 2:
				kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
				num = 0;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					break;
				}
				goto case 4;
			case 4:
			case 6:
				pasteBufferCell.Value = (JToken)HfoxjCzEtY5Ue2LG6ra(1.0);
				goto case 1;
			case 3:
			{
				CvsCellLocation loc = uSZbTKzX9Wns5oC8Xk3(P_0, A5HK0nrQaT);
				text = P_0.GetLocationFromOrigin(nntKVrfEfo).ToString(absoluteRow: true, absoluteColumn: true);
				text2 = uSZbTKzX9Wns5oC8Xk3(P_0, Ib7KBFiyEE).ToString(absoluteRow: true, absoluteColumn: true);
				text3 = P_0.GetLocationFromOrigin(S3NKGAv9YL).ToString(absoluteRow: true, absoluteColumn: true);
				text4 = uSZbTKzX9Wns5oC8Xk3(P_0, FjLKKS8wAT).ToString(absoluteRow: true, absoluteColumn: true);
				text5 = uSZbTKzX9Wns5oC8Xk3(P_0, SU7KLO0roo).ToString(absoluteRow: true, absoluteColumn: true);
				JObject jObject = new JObject { [(string)c5hOQhzo1wn2AyC7w3G(1624)] = (JToken?)iE2tJyzSGt5lI1Tuh3U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344)) };
				x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8360), (JToken)10);
				x6jVGrzk0HYQP2srSAp(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368), iE2tJyzSGt5lI1Tuh3U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(32678)));
				jObject2 = jObject;
				pasteBufferCell = new PasteBufferCell(loc);
				num = 7;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					break;
				}
				goto case 0;
			}
			case 0:
				WquhKUz4yxCm9wmj6Iq(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(31366));
				goto default;
			default:
				nj9tPSzbJ2Ev40vkjve();
				num = (AXPKInzGUI48TkKhLuK() ? 1 : 6);
				break;
			case 8:
				return pasteBufferCell;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell jlAKkEX6jq(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation locationFromOrigin = P_0.GetLocationFromOrigin(FjLKKS8wAT);
		JObject jObject = new JObject();
		x6jVGrzk0HYQP2srSAp(jObject, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1624), iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(8344)));
		x6jVGrzk0HYQP2srSAp(jObject, c5hOQhzo1wn2AyC7w3G(8360), rNFK8Sz8U2hH8kSqwTP(11));
		jObject[CdQUGaROfy7He9T0foW.KbIzwHEDLa(8368)] = (JToken?)iE2tJyzSGt5lI1Tuh3U(c5hOQhzo1wn2AyC7w3G(8384));
		JObject data = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(locationFromOrigin);
		TmuOfRzqdYqUrs3FLnF(pasteBufferCell, CdQUGaROfy7He9T0foW.KbIzwHEDLa(18668));
		kdwLYrz9a8kwW7CIFxY(pasteBufferCell, "");
		WquhKUz4yxCm9wmj6Iq(pasteBufferCell, c5hOQhzo1wn2AyC7w3G(30938));
		i6obc3zpFU8m2gTnVYM(pasteBufferCell, (JToken)1.0);
		pasteBufferCell.Data = data;
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string MNyKPDgxpv(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellLocation cvsCellLocation2 = default;
		string text2 = default;
		string text4 = default;
		CvsCellLocation cvsCellLocation3 = default;
		CvsCellLocation cvsCellLocation = default;
		string text3 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				cvsCellLocation2.Column++;
				num = 6;
				continue;
			case 4:
				cvsCellLocation2 = uSZbTKzX9Wns5oC8Xk3(P_0, VyDKJhxxCL);
				num = 5;
				continue;
			case 0:
				text2 = (string)UX4ZWPz6s3Mu9C6F070(text2, 9, text4);
				num = 11;
				continue;
			case 2:
				cvsCellLocation3 = uSZbTKzX9Wns5oC8Xk3(P_0, SU7KLO0roo);
				num = 8;
				continue;
			case 3:
			case 9:
				cvsCellLocation = uSZbTKzX9Wns5oC8Xk3(P_0, FjLKKS8wAT);
				num = 1;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					continue;
				}
				goto case 8;
			case 8:
				text3 = cvsCellLocation3.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 7;
			case 6:
				do
				{
					text2 = (string)UX4ZWPz6s3Mu9C6F070(P_1, 7, cvsCellLocation2.ToString(absoluteRow: true, absoluteColumn: true));
					nj9tPSzbJ2Ev40vkjve();
					if (AXPKInzGUI48TkKhLuK())
					{
						num = 10;
						continue;
					}
					num = 9;
					break;
				}
				while (1 == 0);
				continue;
			case 1:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 2;
			default:
				num = 2;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					continue;
				}
				goto case 7;
			case 7:
			case 10:
				text4 = (string)bglqDGzjLmnMuNXgD6c(new string[5]
				{
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(18546),
					text,
					(string)c5hOQhzo1wn2AyC7w3G(5424),
					text3,
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(32788)
				});
				num = 0;
				if (nj9tPSzbJ2Ev40vkjve())
				{
					continue;
				}
				break;
			case 11:
				break;
			}
			break;
		}
		return text2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nj9tPSzbJ2Ev40vkjve()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AXPKInzGUI48TkKhLuK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c5hOQhzo1wn2AyC7w3G(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iE2tJyzSGt5lI1Tuh3U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x6jVGrzk0HYQP2srSAp(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rNFK8Sz8U2hH8kSqwTP(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TmuOfRzqdYqUrs3FLnF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HfoxjCzEtY5Ue2LG6ra(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i6obc3zpFU8m2gTnVYM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation uSZbTKzX9Wns5oC8Xk3(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kdwLYrz9a8kwW7CIFxY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WquhKUz4yxCm9wmj6Iq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BMPo9rz7JA55wVrO7JV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c45jDRz3Xpwt4B1Y8pa(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bglqDGzjLmnMuNXgD6c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UX4ZWPz6s3Mu9C6F070(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}
}
