using System;

namespace Cognex.Tako;

public class CreatorEventArgs : EventArgs
{
	public int Id;

	public CreatorMode Mode;

	public CreatorEventArgs(int id, CreatorMode mode)
	{
		Id = id;
		Mode = mode;
	}
}
