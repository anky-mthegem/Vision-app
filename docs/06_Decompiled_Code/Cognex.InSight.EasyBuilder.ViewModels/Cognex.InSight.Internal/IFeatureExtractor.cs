using System.Collections.Generic;
using Cognex.InSight.Controls.Display.Internal;

namespace Cognex.InSight.Internal;

public interface IFeatureExtractor
{
	List<CvsEditableDisplayGraphic> FindLines(CvsImage image);

	List<CvsEditableDisplayGraphic> FindCircles(CvsImage image);
}
