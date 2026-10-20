namespace Cognex.CogNamer.Client;

public interface IDecrypt
{
	string Decrypt(string src);

	string Decrypt(byte[] src);
}
