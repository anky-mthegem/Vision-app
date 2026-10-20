using System.Drawing;
using System.Threading.Tasks;

namespace Cognex.InSight.Undo;

public interface IExternalCellDataHandler
{
	IExternalCellData SaveState(CvsInSight inSight, CvsCellLocation cellLocation, string sheetName = null);

	IExternalCellData SaveState(ResourceNode resourceNode);

	Task Synchronize(CvsInSight inSight, CvsCellLocation cellLocation);

	void Export(CvsInSight inSight, CvsCellLocation cellLocation, string fileName);

	Task<bool> Fixture(CvsInSight inSight, CvsCellLocation cellLocation, string filter);

	void FixtureSingle(CvsInSight inSight, CvsCellLocation cellLocation, string path, Bitmap bmp);

	void ProcessSingle(CvsInSight inSight, CvsCellLocation cellLocation, string path);

	void CloseEditors();
}
