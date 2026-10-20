namespace Cognex.Explorer.Adapters;

public interface IDirectoryProvider
{
	string[] GetAdapterDirectories();

	string[] GetEmulatorDirectories();
}
