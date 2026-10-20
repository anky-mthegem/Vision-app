namespace Cognex.Explorer.Common;

public interface IXProcDocumentAction : ITargetAction
{
	string EntryPoint { get; }

	bool Is32Bit { get; }
}
