using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace Cognex.InSight;

public interface IFilmstripPlayer
{
	bool CanPlay { get; }

	Task PlayImageAsync(Bitmap bmp, string imageName = null);

	Task PlayPointCloudAsync(Stream rawData);
}
