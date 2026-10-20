namespace Cognex.Platform;

internal static class PlatformModeMethods
{
	public static bool Is3D(this PlatformMode platformMode)
	{
		if (platformMode < PlatformMode.ISL38033 || platformMode > PlatformMode.ISL38500)
		{
			return platformMode == PlatformMode.IS6900_L38;
		}
		return true;
	}
}
