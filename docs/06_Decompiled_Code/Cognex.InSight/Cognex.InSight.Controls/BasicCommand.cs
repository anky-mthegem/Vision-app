using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Controls;

public class BasicCommand : ICommand
{
	[CompilerGenerated]
	private Action<object> Mt2fiI6dZQ;

	private bool ynxfdVSoZQ;

	private EventHandler B11fuSwgZf;

	public Action<object> ExecuteDelegate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Mt2fiI6dZQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Mt2fiI6dZQ = value;
		}
	}

	public bool Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ynxfdVSoZQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			EventHandler b11fuSwgZf = default;
			while (true)
			{
				switch (num)
				{
				default:
					if (b11fuSwgZf != null)
					{
						num = 6;
						break;
					}
					return;
				case 0:
					ynxfdVSoZQ = value;
					_ = 0;
					if (GdGGjLy0IlF6orYj9qW())
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					break;
				case 1:
				case 2:
					b11fuSwgZf = B11fuSwgZf;
					goto default;
				case 5:
					if (ynxfdVSoZQ != value)
					{
						num = 0;
						break;
					}
					return;
				case 6:
					try
					{
						b11fuSwgZf(this, EventArgs.Empty);
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
			}
		}
	}

	event EventHandler ICommand.CanExecuteChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B11fuSwgZf = (EventHandler)xT4YKHykDkAZjbXWfch(B11fuSwgZf, value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B11fuSwgZf = (EventHandler)J9PucJyfVDLKZUnvWVQ(B11fuSwgZf, value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ICommand.CanExecute(object parameter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ICommand.Execute(object parameter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (qPAMTpy4jNYsGGQaay3() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (Enabled)
				{
					goto case 1;
				}
				return;
			case 3:
				ExecuteDelegate(parameter);
				num = 5;
				break;
			case 1:
			case 2:
				if (ExecuteDelegate != null)
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BasicCommand()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				ynxfdVSoZQ = true;
				goto default;
			default:
				SIcqBbym8SdDCS5gFdD(this);
				num = 5;
				break;
			case 3:
				iMMmx3yFSvAcrX9Mmsw();
				_ = 0;
				if (!GdGGjLy0IlF6orYj9qW())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GdGGjLy0IlF6orYj9qW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qPAMTpy4jNYsGGQaay3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xT4YKHykDkAZjbXWfch(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J9PucJyfVDLKZUnvWVQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iMMmx3yFSvAcrX9Mmsw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SIcqBbym8SdDCS5gFdD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
