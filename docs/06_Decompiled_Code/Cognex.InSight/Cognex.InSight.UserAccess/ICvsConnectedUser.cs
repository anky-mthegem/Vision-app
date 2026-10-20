using System.ComponentModel;

namespace Cognex.InSight.UserAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface ICvsConnectedUser
{
	bool HasAnyModifyPermissions { get; }

	bool HasModifyPermission(string permission);

	bool HasVisiblePermission(string permission);
}
