using System.Windows;

namespace Cognex.Explorer.Common;

public interface IDocument
{
	string Title { get; }

	string ToolTip { get; }

	XImage Icon { get; }

	bool IsRequestingAttention { get; }

	string BusyMessage { get; }

	bool IsActive { get; set; }

	bool HasChanges { get; }

	FrameworkElement HostedContent { get; }

	event PropertyChangedDelegate PropertyChanged;

	void SaveChanges();
}
