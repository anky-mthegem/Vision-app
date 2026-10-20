namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public enum CaliperScoringMethodType
{
	None,
	EdgePairSizeDifference,
	EdgePairSize,
	PositionNormalized,
	Position,
	Straddle,
	Contrast,
	FullRegionPositionNormalized,
	FullRegionPosition,
	EdgePairSizeDifferenceAsymmetric
}
