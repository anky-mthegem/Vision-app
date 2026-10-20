using System.Linq;

namespace Cognex.Platform;

public static class StringExtensions
{
	public static string JustTheNumber(this string text)
	{
		text = text ?? string.Empty;
		return new string(text.Where((char p) => char.IsDigit(p)).ToArray());
	}
}
