namespace Cognex.Platform;

internal class Message
{
	public string Url { get; set; }

	public string Data { get; set; }

	public Message(string url)
	{
		Url = url;
	}
}
