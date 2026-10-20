using System;

namespace Cognex.Explorer.Common;

[Serializable]
public class HelpGuide
{
	public string Id { get; set; }

	public string Title { get; set; }

	public string Category { get; set; }

	public string Adapter { get; set; }

	public string Version { get; set; }

	public HelpGuide Clone()
	{
		return (HelpGuide)MemberwiseClone();
	}
}
