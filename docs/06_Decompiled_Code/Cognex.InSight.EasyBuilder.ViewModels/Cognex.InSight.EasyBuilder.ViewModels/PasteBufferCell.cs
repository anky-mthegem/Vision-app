using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class PasteBufferCell
{
	private readonly JArray Mo0pJCsyA7;

	public JArray RawCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mo0pJCsyA7;
		}
	}

	public string Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<JToken>)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 0)).Value<string>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 0, AAVjJwJk1tKGvfqrUMt(value));
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
			return ((IEnumerable<JToken>)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 4)).Value<string>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 4, AAVjJwJk1tKGvfqrUMt(value));
		}
	}

	public string State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mo0pJCsyA7[2].Value<string>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 2, AAVjJwJk1tKGvfqrUMt(value));
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
			return ((IEnumerable<JToken>)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 1)).Value<string>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 1, AAVjJwJk1tKGvfqrUMt(value));
		}
	}

	public JToken Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (JToken)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 5);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 5, value);
		}
	}

	public JToken Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (JToken)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 3);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 3, value);
		}
	}

	public JToken Style
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mo0pJCsyA7[6];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 6, value);
		}
	}

	public string Comment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<JToken>)GA2E7iJSJmCbiRjK6g5(Mo0pJCsyA7, 8)).Value<string>();
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rTgc6CJ8MHKGOuyGs0S(Mo0pJCsyA7, 8, AAVjJwJk1tKGvfqrUMt(value));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBufferCell(JArray cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cMEkMmJBldssTLGWcGN();
		int num = (Pa7MGFJblimfYUiMff8() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector();
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 4:
				break;
			case 0:
			case 2:
				onShLqJGIihDT7PiAt1();
				goto case 1;
			case 5:
				return;
			}
			Mo0pJCsyA7 = cell;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBufferCell(CvsCellLocation loc)
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
			default:
				Mo0pJCsyA7 = new JArray(loc.ToString(), "", 1, 0.0, "", null, "", "", "", 0, 0);
				num = 5;
				break;
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				cMEkMmJBldssTLGWcGN();
				if (!Pa7MGFJblimfYUiMff8())
				{
					num = 3;
					break;
				}
				num = 0;
				if (true)
				{
					break;
				}
				return;
			case 1:
			case 3:
				PgLK0OJoQhfFqme3xDt(this);
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(Formatting.None);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(Formatting formatting)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)hRXXJYJqPuEk36RBRa5(Mo0pJCsyA7, formatting, Array.Empty<JsonConverter>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void onShLqJGIihDT7PiAt1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cMEkMmJBldssTLGWcGN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Pa7MGFJblimfYUiMff8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PgLK0OJoQhfFqme3xDt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GA2E7iJSJmCbiRjK6g5(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JArray)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AAVjJwJk1tKGvfqrUMt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rTgc6CJ8MHKGOuyGs0S(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JArray)P_0)[P_1] = (JToken)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hRXXJYJqPuEk36RBRa5(object P_0, Formatting P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JToken)P_0).ToString(P_1, (JsonConverter[])P_2);
	}
}
