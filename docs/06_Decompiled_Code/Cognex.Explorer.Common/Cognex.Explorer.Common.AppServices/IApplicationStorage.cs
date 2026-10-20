namespace Cognex.Explorer.Common.AppServices;

public interface IApplicationStorage : IHostService
{
	bool Exists(string key);

	void Set(string key, string value);

	string Get(string key);

	void Remove(string key);
}
