using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class FixTransWorldCalibratePtp : ISnippetUpdate
{
	private static readonly CvsCellLocation GNkjFEBXAH;

	private static readonly CvsCellLocation YPmjXGcGp3;

	private static readonly CvsCellLocation K4Tjo7V9Bi;

	private static readonly CvsCellLocation GdWjS4yBwN;

	private static readonly CvsCellLocation bFOjD27QDP;

	private static readonly CvsCellLocation UUQj3uiek4;

	private static readonly CvsCellLocation UeRjIqkTBu;

	private readonly AddCellUpdate bhcjfSqYwp;

	private readonly LocationUpdate RTLjEYUgXV;

	private readonly LocationUpdate OQPjbTRnf4;

	private readonly LocationUpdate ma3jcIsDqi;

	private readonly LocationUpdate bUZjQDiMyG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixTransWorldCalibratePtp(SnippetLocalizer localizer, CvsFunctionTable table, IExpressionConstants constants)
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
			case 6:
				V2RAdiAymeaaoAlP3RB();
				num = 8;
				continue;
			default:
				OQPjbTRnf4 = new LocationUpdate(K4Tjo7V9Bi, GNkjFEBXAH, SnippetUpdateHelper.GetAbsRefLocationOfCell, GdWjS4yBwN, table, constants);
				num = 3;
				continue;
			case 1:
				RTLjEYUgXV = new LocationUpdate(YPmjXGcGp3, GNkjFEBXAH, SnippetUpdateHelper.GetAbsRefLocationOfCell, GdWjS4yBwN, table, constants);
				goto default;
			case 0:
			case 2:
				bhcjfSqYwp = new AddCellUpdate(GdWjS4yBwN, YKYju6bhyX, localizer);
				num = 1;
				continue;
			case 8:
				YQPg8IA0G6mcdBQ7neG(this);
				_ = 1;
				num = (R6GvevATewC6kTwnlkj() ? 7 : 0);
				continue;
			case 3:
				ma3jcIsDqi = new LocationUpdate(UUQj3uiek4, bFOjD27QDP, SnippetUpdateHelper.GetAbsRefLocationOfCell, GdWjS4yBwN, table, constants);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 5:
				break;
			case 9:
				return;
			}
			bUZjQDiMyG = new LocationUpdate(UeRjIqkTBu, bFOjD27QDP, SnippetUpdateHelper.GetAbsRefLocationOfCell, GdWjS4yBwN, table, constants);
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				pasteBuffer = (PasteBuffer)sdp98jAFkTwv169gRMx(originalSnippet);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				pasteBuffer = (PasteBuffer)oRmVllAYZtf5ZiesXb3(RTLjEYUgXV, pasteBuffer);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				pasteBuffer = (PasteBuffer)w1DDqMAMdL2itS5ZQAW(bhcjfSqYwp, pasteBuffer);
				_ = 1;
				num = ((!R6GvevATewC6kTwnlkj()) ? 1 : 3);
				continue;
			case 7:
				pasteBuffer = (PasteBuffer)oRmVllAYZtf5ZiesXb3(OQPjbTRnf4, pasteBuffer);
				goto default;
			default:
				pasteBuffer = (PasteBuffer)oRmVllAYZtf5ZiesXb3(ma3jcIsDqi, pasteBuffer);
				num = 6;
				if (YbGjZaAWDo4hwVBn8RE())
				{
					continue;
				}
				goto case 6;
			case 6:
				pasteBuffer = (PasteBuffer)oRmVllAYZtf5ZiesXb3(bUZjQDiMyG, pasteBuffer);
				num = 8;
				if (YbGjZaAWDo4hwVBn8RE())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell YKYju6bhyX(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = VVRBJTAUfn35UqI1KEu(P_0, GdWjS4yBwN);
		string text = (string)imuUmBAHqHptt9Xy0a7(P_0, bFOjD27QDP);
		string text2 = (string)imuUmBAHqHptt9Xy0a7(P_0, GNkjFEBXAH);
		string expression = (string)DAr8yKAmd8RZUg5NmvX(Im6hhZAxg3OJIiDUw2s(26910), text, text2);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = expression
		};
		U5fh12AQC3blOEJcIxW(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FixTransWorldCalibratePtp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0038;
		IL_0079:
		UUQj3uiek4 = new CvsCellLocation(8, 1);
		num = 3;
		if (true)
		{
			goto IL_0038;
		}
		goto IL_0091;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 7:
				break;
			default:
				num = 1;
				if (!R6GvevATewC6kTwnlkj())
				{
					continue;
				}
				goto IL_0079;
			case 6:
			case 9:
				goto IL_0079;
			case 5:
				goto IL_0091;
			case 0:
				GNkjFEBXAH = new CvsCellLocation(1, 1);
				num = 8;
				continue;
			case 1:
				goto IL_00b6;
			case 8:
				YPmjXGcGp3 = new CvsCellLocation(3, 3);
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				K4Tjo7V9Bi = new CvsCellLocation(3, 4);
				_ = 0;
				if (!YbGjZaAWDo4hwVBn8RE())
				{
					num = 9;
					continue;
				}
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				UeRjIqkTBu = new CvsCellLocation(8, 2);
				num = 10;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_0091:
		V2RAdiAymeaaoAlP3RB();
		num = 0;
		goto IL_0038;
		IL_001a:
		GdWjS4yBwN = new CvsCellLocation(4, 7);
		goto IL_00b6;
		IL_00b6:
		bFOjD27QDP = new CvsCellLocation(8, 0);
		goto IL_0079;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V2RAdiAymeaaoAlP3RB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YQPg8IA0G6mcdBQ7neG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YbGjZaAWDo4hwVBn8RE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R6GvevATewC6kTwnlkj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sdp98jAFkTwv169gRMx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w1DDqMAMdL2itS5ZQAW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oRmVllAYZtf5ZiesXb3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LocationUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation VVRBJTAUfn35UqI1KEu(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object imuUmBAHqHptt9Xy0a7(object P_0, CvsCellLocation cellOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.GetAbsRefLocationOfCell((PasteBuffer)P_0, cellOffset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Im6hhZAxg3OJIiDUw2s(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DAr8yKAmd8RZUg5NmvX(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void U5fh12AQC3blOEJcIxW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}
}
