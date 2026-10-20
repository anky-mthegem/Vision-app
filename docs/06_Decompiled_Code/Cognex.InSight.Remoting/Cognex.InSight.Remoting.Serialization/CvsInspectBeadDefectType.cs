namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public enum CvsInspectBeadDefectType
{
	Multiple = -1,
	All,
	UnderFill,
	OverFill,
	TooThin,
	TooWide,
	StepChange,
	MissingBothEdges,
	MissingFirstEdge,
	MissingSecondEdge,
	NoBeadFound
}
