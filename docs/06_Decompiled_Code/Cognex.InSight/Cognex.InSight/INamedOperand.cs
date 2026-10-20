namespace Cognex.InSight;

public interface INamedOperand
{
	string Name { get; }

	CvsCellLocation Location { get; }

	string Expression { get; }
}
