using System;
using Cognex.Cnx.Imaging;

namespace Cognex.InSight.Internal;

public interface ICvsImageData
{
	int Width { get; }

	int Height { get; }

	CnxPixelFormat PixelFormat { get; }

	IntPtr Scan0 { get; }

	int Stride { get; }
}
