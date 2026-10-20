namespace Cognex.Remoting.CogSocket;

public interface IRemoteSerializer
{
	string Serialize(object value);

	T Deserialize<T>(string text);
}
