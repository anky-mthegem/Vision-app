namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public enum CvsOcrMaxResultCharacterStatus
{
	Failed,
	Passed,
	Ignored,
	Confused,
	Mismatch,
	ConfusedMismatch,
	NoRead,
	FailedValidation
}
