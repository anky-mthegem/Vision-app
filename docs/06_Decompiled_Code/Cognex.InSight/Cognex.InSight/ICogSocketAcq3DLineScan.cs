using System;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight;

public interface ICogSocketAcq3DLineScan : ICogSocketAcq, ICogSocketAcqProperties
{
	event EventHandler PointCloudReady;

	Task<CvsCogFieldCalStatus> GetFieldCalStatusAsync();

	Task<CvsCogWorkingSection> GetWorkingSectionAsync();

	Task ImportFieldCalAsync(CvsCogByteArray data);

	Task<CvsCogByteArray> ExportFieldCalAsync();

	Task<double> GetRoiRowFromZ(double z, bool binning);

	Task<double> GetRoiZFromRow(double row, bool binning);

	Task ResetEncoderCounter();

	Task<uint> GetEncoderCount();
}
