namespace Cognex.Explorer.Common.AppServices;

public interface IApplicationUserFolders : IHostService
{
	string GetPublicUserDataFolder();

	string GetPrivateUserDataFolder(bool versionSpecific);

	string GetCommonAppDataFolder(bool versionSpecific);
}
