using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

internal abstract class CvsColorToolCustomProtocolCommand
{
	internal enum CustomProtocolRequest
	{
		ExtractorGetGroupList = 0,
		ExtractorGetGroupData = 1,
		ExtractorGetModelData = 2,
		ExtractorSortModelList = 3,
		ExtractorMarkGroups = 4,
		ExtractorMarkModels = 5,
		ExtractorBeginTrainingSession = 6,
		ExtractorSetTrainingRegion = 7,
		ExtractorTrain = 8,
		ExtractorEndTrainingSession = 9,
		ExtractorGetColorSamples = 10,
		ExtractorGetEnabledGroups = 11,
		ExtractorGetLibraryName = 12,
		MatchGetModelList = 100,
		MatchGetModelData = 101,
		MatchGetEnabledModelList = 102,
		MatchGetColorSamples = 103,
		MatchSetTrainingPolygon = 104,
		MatchGetLibraryName = 105
	}

	public abstract CustomProtocolRequest RequestID { get; }

	public abstract int RequestDataLength { get; }

	public abstract bool WaitForColorDataMsg { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsColorToolCustomProtocolCommand()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ejkAyNIuoABUQL2tPgm();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ejkAyNIuoABUQL2tPgm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B2Ay1sIldG79l1f1sF9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BD7TyYIeMTGLHRd6yZ5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
