using Cognex.Cnx.Imaging;

namespace Cognex.InSight;

public interface ICvsImageConfigurationSource
{
	CnxPixelFormat ImageRenderFormat { get; set; }

	CnxPixelFormat ImageUIFormat { get; set; }

	CnxPixelFormat ImageConvertFormat { get; set; }
}
