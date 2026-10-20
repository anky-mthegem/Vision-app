using System.Collections.Generic;

namespace Cognex.Ocr.Client.Tool;

public interface ISample
{
	string Id { get; }

	Image Image { get; }

	ICollection<Character> Characters { get; }
}
