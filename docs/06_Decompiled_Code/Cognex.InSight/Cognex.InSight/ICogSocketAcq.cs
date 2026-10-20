using System;
using System.Drawing;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Remoting.CogSocket;

namespace Cognex.InSight;

public interface ICogSocketAcq : ICogSocketAcqProperties
{
	string AcqPath { get; }

	bool IsLiveAcquisition { get; set; }

	string LatestAcqImageUrl { get; set; }

	event EventHandler ImageReady;

	event EventHandler<CogSocketEventArgs> SettingChanged;

	event EventHandler<CogSocketEventArgs> PropertyDescriptorsChanged;

	event EventHandler<CogSocketEventArgs> AcquisitionErrorReceived;

	Task AddListenersAsync();

	Task RemoveListenersAsync();

	Task ResetToDefaults();

	Task EnableTrigger();

	Task DisableTrigger();

	Task<object[]> PrivateAcquisition(string format, string clientId = "");

	Task CancelAllAcquisitions();

	Task ManualTriggerAsync();

	void ManualTrigger(bool block = true);

	CvsCogAcqSettings GetAcqSettings();

	Task<T> GetAcqSetting<T>(string propertyName);

	Task PutAcqSetting<T>(string propertyName, T propertyValue);

	Task PutFocusRegionSetting(CvsCogRegion region);

	Task<CvsCogRegion> GetFocusRegionBounds();

	Task<double> GetAcqFocusPositionResolution();

	bool GetAcqFocusAttached();

	bool GetAcqIlluminationDetected();

	Task<bool> GetAcqWhiteBalanceSupported();

	Task<bool> AcceptsPointCloudsAsync();

	Task<bool> Is2DLineScanAsync();

	CvsCogAcqProperties GetAcqProperties();

	Task<CvsCogImage> GetAcqImageProperties();

	CvsCogIlluminationObject GetAcqIlluminationObject();

	Task<CvsCogAcquisitionStatus> GetAcqStatus();

	Task<CvsCogRef> GetLastImageRef();

	void DoAutofocus();

	void DoAutoWhiteBalance();

	Task DoAutoExposure();

	Task DoAutoROI();

	Task PutWhiteBalanceRegionSetting(CvsCogRegion region);

	Task<string> CreateImageAsync(Bitmap bmp);

	void PostImageByHTTP(Bitmap bmp);

	Task Execute(CogSocketActionPath action);

	Task<string> GetSettingsId();
}
