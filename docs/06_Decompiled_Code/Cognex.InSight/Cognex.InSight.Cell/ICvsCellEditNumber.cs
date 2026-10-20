namespace Cognex.InSight.Cell;

public interface ICvsCellEditNumber<T>
{
	T Value { get; }

	T MinValue { get; }

	T MaxValue { get; }
}
