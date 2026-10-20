namespace Cognex.Explorer.Common.AppServices;

public interface IHelpItemService : IHostService
{
	HelpGuide[] HelpGuides { get; }

	void Open(string id);
}
