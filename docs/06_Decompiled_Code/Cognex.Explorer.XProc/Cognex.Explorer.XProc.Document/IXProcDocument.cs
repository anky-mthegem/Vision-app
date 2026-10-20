using System.AddIn.Contract;
using Cognex.Explorer.Common;

namespace Cognex.Explorer.XProc.Document;

public interface IXProcDocument : IXProc
{
	string Title { get; }

	string ToolTip { get; }

	string BusyMessage { get; }

	XImage Icon { get; }

	bool IsRequestingAttention { get; }

	bool IsActive { get; set; }

	bool HasChanges { get; }

	event PropertyChangedDelegate InfoChanged;

	void SaveChanges();

	INativeHandleContract GetDocument();
}
