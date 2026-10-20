using Cognex.InSight.VisionBuilder.Types;

namespace Cognex.InSight.VisionBuilder;

public interface IUserSessionCache
{
	Server LastLoggedInServer { get; }

	bool IsLoggedInFor(Server server);

	string GetAccessTokenFor(Server server);

	string GetUserNameFor(Server server);

	void StoreSession(UserSession userSession);

	void ClearSession();
}
