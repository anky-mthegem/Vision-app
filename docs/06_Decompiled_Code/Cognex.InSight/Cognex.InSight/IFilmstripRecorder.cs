using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Cognex.InSight.Common;

namespace Cognex.InSight;

public interface IFilmstripRecorder
{
	public enum AcquisitionType
	{
		Images,
		PointClouds
	}

	bool IsConnected { get; }

	string SheetId { get; }

	event EventHandler ResultsChanged;

	string GetPrimaryImageUrl();

	string GetPrimaryPointCloudUrl();

	Bitmap GetImage(string imageUrl, CogSocketImageFormat imageFormat);

	Task<Stream> GetPointCloudDataAsync(string url);

	Task<byte[]> GetPointCloudThumbDataAsync(string url);

	Task<(double?, double?)> GetZRange(string url);
}
