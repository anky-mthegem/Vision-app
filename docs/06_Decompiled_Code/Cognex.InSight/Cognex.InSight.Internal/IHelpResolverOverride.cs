using System;

namespace Cognex.InSight.Internal;

public interface IHelpResolverOverride
{
	Func<string, string> ApplyTopicPathRedirect { set; }

	Func<string, string> GetSpreadsheetHelpPath { set; }

	bool ShouldApplyOverride(CvsFunctionTableEntryPath path);

	string GetHelpTopic(CvsFunctionTableEntryPath path);
}
