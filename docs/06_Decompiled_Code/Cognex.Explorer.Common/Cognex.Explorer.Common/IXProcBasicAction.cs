namespace Cognex.Explorer.Common;

public interface IXProcBasicAction : ITargetAction
{
	string EntryPoint { get; }

	bool Is32Bit { get; }
}
