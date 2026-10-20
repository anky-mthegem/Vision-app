namespace Cognex.Explorer.Common;

public interface IExecutableTargetAction : ITargetAction
{
	string ExecutablePathFormat { get; }

	string ArgumentFormat { get; }
}
