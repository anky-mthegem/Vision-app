using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Cognex.Explorer.Common;

public interface ITargetAction
{
	string Name { get; }

	string DisplayName { get; }

	string Description { get; }

	string UniqueId { get; }

	bool IsEnabled { get; }

	bool IsDefault { get; }

	TargetAccessMode AccessMode { get; }

	BitmapSource Icon { get; }

	MultiTargetMode MultiTargetMode { get; }

	Dictionary<string, object> Arguments { get; }
}
