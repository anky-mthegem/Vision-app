using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Cognex.Platform;

public static class ChildProcessTracker
{
	private static readonly IntPtr s_jobHandle;

	public static void AddProcess(Process process)
	{
		if (s_jobHandle != IntPtr.Zero && !AssignProcessToJobObject(s_jobHandle, process.Handle) && !process.HasExited)
		{
			throw new Win32Exception();
		}
	}

	static ChildProcessTracker()
	{
		if (Environment.OSVersion.Version < new Version(6, 2))
		{
			return;
		}
		string name = "ChildProcessTracker" + Process.GetCurrentProcess().Id;
		s_jobHandle = CreateJobObject(IntPtr.Zero, name);
		JOBOBJECT_BASIC_LIMIT_INFORMATION basicLimitInformation = new JOBOBJECT_BASIC_LIMIT_INFORMATION
		{
			LimitFlags = JOBOBJECTLIMIT.JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE
		};
		JOBOBJECT_EXTENDED_LIMIT_INFORMATION structure = new JOBOBJECT_EXTENDED_LIMIT_INFORMATION
		{
			BasicLimitInformation = basicLimitInformation
		};
		int num = Marshal.SizeOf(typeof(JOBOBJECT_EXTENDED_LIMIT_INFORMATION));
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			if (!SetInformationJobObject(s_jobHandle, JobObjectInfoType.ExtendedLimitInformation, intPtr, (uint)num))
			{
				throw new Win32Exception();
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr CreateJobObject(IntPtr lpJobAttributes, string name);

	[DllImport("kernel32.dll")]
	private static extern bool SetInformationJobObject(IntPtr job, JobObjectInfoType infoType, IntPtr lpJobObjectInfo, uint cbJobObjectInfoLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool AssignProcessToJobObject(IntPtr job, IntPtr process);
}
