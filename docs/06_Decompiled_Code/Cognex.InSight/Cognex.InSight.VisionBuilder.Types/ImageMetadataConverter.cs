using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cognex.InSight.VisionBuilder.Types;

public static class ImageMetadataConverter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ImageAttributes[] ConvertImageMetadataToAttributes(IEnumerable<ImageMetadata> metadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return metadata.Select([MethodImpl(MethodImplOptions.NoInlining)] (ImageMetadata m) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new ImageAttributes(m);
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Element[] ConvertImageMetadataToElements(IEnumerable<ImageMetadata> metadata)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return metadata.Select([MethodImpl(MethodImplOptions.NoInlining)] (ImageMetadata m) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new Element(m);
		}).ToArray();
	}
}
