using System.Windows;

namespace Cognex.Explorer.Common;

public interface IXProcDialogAction : ITargetAction
{
	DialogType DialogType { get; }

	string EntryPoint { get; }

	bool Is32Bit { get; }

	int WindowWidth { get; }

	int WindowHeight { get; }

	ResizeMode ResizeMode { get; }
}
