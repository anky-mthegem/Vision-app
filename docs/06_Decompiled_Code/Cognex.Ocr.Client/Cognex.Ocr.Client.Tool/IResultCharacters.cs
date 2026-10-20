using System.Collections.Generic;

namespace Cognex.Ocr.Client.Tool;

public interface IResultCharacters
{
	string Id { get; }

	ICollection<Character> Characters { get; }
}
