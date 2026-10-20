using System.Drawing;
using System.Threading.Tasks;

namespace Cognex.InSight.Services;

public interface IViDiFixtureService
{
	Task<bool> Fixture(CvsCellLocation loc, string filter);

	void FixtureSingle(CvsCellLocation loc, string path, Bitmap bmp);

	void ProcessSingle(CvsCellLocation loc, string path);

	string GetFixtureCellLocation(CvsCellLocation loc);
}
