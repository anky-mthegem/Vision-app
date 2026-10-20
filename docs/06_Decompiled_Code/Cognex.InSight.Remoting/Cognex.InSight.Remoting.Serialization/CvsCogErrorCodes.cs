namespace Cognex.InSight.Remoting.Serialization;

public static class CvsCogErrorCodes
{
	public const int GenericError = int.MinValue;

	public const int NullParameter = -2147483647;

	public const int InvalidParameter = -2147483646;

	public const int Cancelled = -2147483550;

	public const int RegionContainsReferences = -2147482349;

	public const int OcrMaxTrainStringLengthDoesNotMatchNumberOfSegments = -1610415743;

	public const int OcrMaxAutoTuneTrainStringLengthDoesNotMatchNumberOfSegments = -2147478447;

	public const int MemberNotFound = -2147477839;

	public const int NotConnected = -2147475326;

	public const int NotAvailable = -1610612727;

	public const int AutoTuneFailedAddedAnyways = -1610415744;

	public const int CircularReference = -1610415712;
}
