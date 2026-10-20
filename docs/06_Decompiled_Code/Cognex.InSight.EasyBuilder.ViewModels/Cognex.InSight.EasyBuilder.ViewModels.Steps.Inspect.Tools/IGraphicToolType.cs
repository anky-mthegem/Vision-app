using System.Drawing;
using System.Threading.Tasks;
using Cognex.InSight.Controls.Display;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public interface IGraphicToolType
{
	PointF Center { get; }

	Task OnGraphicChanged(object sender, CvsEditEventArgs e);
}
