using System;

namespace Cognex.Tako;

public class SelectionChangedEventArgs : EventArgs
{
	public int CurrentSelected;

	public int LastSelected;

	public SelectionChangedEventArgs(int current, int last)
	{
		CurrentSelected = current;
		LastSelected = last;
	}
}
