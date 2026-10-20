namespace Cognex.CogNamer.Client;

public enum CogNamerErrorCode
{
	Success = 0,
	Failed = 1,
	ErrorUnsupportedCommand = 2,
	ErrorInvalidUsername = 3,
	ErrorInvalidPassword = 4,
	ErrorInsufficientPrivilege = 5,
	ErrorMissingRequiredRecord = 6,
	ErrorInvalidNetworkSettings = 7,
	ErrorOnlySupportedDuringIpRequest = 8,
	ErrorNonExistentRecord = 9,
	ErrorQueryCacheRecordTruncated = 64
}
