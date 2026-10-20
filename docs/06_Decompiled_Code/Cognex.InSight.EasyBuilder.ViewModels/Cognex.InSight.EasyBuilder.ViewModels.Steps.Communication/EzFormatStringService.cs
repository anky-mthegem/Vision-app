using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels.PropertySheet.FormatString;
using Cognex.InSight.Sensor;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class EzFormatStringService : IFormatStringCellService
{
	private CvsInSight rRmiDFdgdl;

	private string OmRi305Q8Y;

	private int JrIiIkqJGe;

	private int guyiffMkUh;

	private int cIDiEFwPyF;

	private CvsCellLocation O3UibuWYM7;

	public string HostName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OmRi305Q8Y;
		}
	}

	public int Rows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JrIiIkqJGe;
		}
	}

	public int Columns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return guyiffMkUh;
		}
	}

	public int MaxExpressionLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cIDiEFwPyF;
		}
	}

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yFZ2HkcwGWKMybrvPdX(rRmiDFdgdl) == CvsInSightState.Connected;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EzFormatStringService(CvsInSight insight, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 4:
				guyiffMkUh = M1ZZEHcKgXCAxqiWm7j(pc6WQpcL2aYtKlqJuUS(insight));
				LYdEcQ2cDBjXF5LuJG6();
				if (!sFvDMV21PpBQYSgn32L())
				{
					num = 9;
					continue;
				}
				num = 5;
				if (LYdEcQ2cDBjXF5LuJG6())
				{
					continue;
				}
				break;
			case 3:
				NpS2BY2hf2Wp9nIa3lB(this);
				num = 1;
				continue;
			case 5:
			case 7:
				O3UibuWYM7 = location;
				num = 10;
				continue;
			case 1:
				rRmiDFdgdl = insight;
				num = 8;
				continue;
			case 2:
				G8lG2O2ud73SNVowkB9();
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				JrIiIkqJGe = ((CvsProcessorConstants)pc6WQpcL2aYtKlqJuUS(insight)).SpreadsheetRows;
				goto case 4;
			default:
				num = 4;
				continue;
			case 6:
			case 9:
				cIDiEFwPyF = T25oSOc5EiHl0USId3R(pc6WQpcL2aYtKlqJuUS(insight));
				goto case 5;
			case 8:
				break;
			case 10:
				return;
			}
			OmRi305Q8Y = (string)VSRJVy2zQSnlQqRYpjW(VwSq7A2tUZgLIbYGmun(insight));
			num = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> SetExpressionAsync(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCell cvsCell = rRmiDFdgdl.Results.Cells[O3UibuWYM7];
		if (cvsCell != null && !cvsCell.Expression.Equals(expression))
		{
			rRmiDFdgdl.CogSocket.Sheet.PutCellExpressionAndRunSheet(O3UibuWYM7, expression);
		}
		string result = CdQUGaROfy7He9T0foW.KbIzwHEDLa(29514);
		cvsCell = rRmiDFdgdl.Results.Cells[O3UibuWYM7];
		if (cvsCell != null && cvsCell.CellValue is string text)
		{
			result = text;
		}
		return Task.FromResult(result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G8lG2O2ud73SNVowkB9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NpS2BY2hf2Wp9nIa3lB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VwSq7A2tUZgLIbYGmun(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Sensor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VSRJVy2zQSnlQqRYpjW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSensor)P_0).HostName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pc6WQpcL2aYtKlqJuUS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int M1ZZEHcKgXCAxqiWm7j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).SpreadsheetColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int T25oSOc5EiHl0USId3R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).MaxExpressionLength;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LYdEcQ2cDBjXF5LuJG6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sFvDMV21PpBQYSgn32L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightState yFZ2HkcwGWKMybrvPdX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).State;
	}
}
