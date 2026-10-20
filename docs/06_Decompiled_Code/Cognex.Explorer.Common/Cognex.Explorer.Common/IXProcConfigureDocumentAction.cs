namespace Cognex.Explorer.Common;

public interface IXProcConfigureDocumentAction : ITargetAction
{
	string EntryPoint { get; }

	bool Is32Bit { get; }

	string ConfigurationId { get; }

	string DocumentName { get; }
}
