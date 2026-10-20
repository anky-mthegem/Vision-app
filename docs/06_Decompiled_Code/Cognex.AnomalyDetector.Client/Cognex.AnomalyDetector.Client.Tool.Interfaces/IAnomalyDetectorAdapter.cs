using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cognex.AnomalyDetector.Client.Tool.Interfaces;

public interface IAnomalyDetectorAdapter
{
	event EventHandler<NewResultArgs> NewResult;

	event EventHandler<ThresholdUpdatedArgs> ThresholdUpdated;

	event EventHandler<FeatureSizeArgs> FeatureSizeUpdated;

	Task<IAnomalyDetectorStats> GetStats(string toolId);

	Task<IAnomalyDetectorResult> GetResult(string toolId);

	Task Skip(string toolId);

	Task LabelImage(string toolId, string sampleId, AnomalyDetectorLabels label);

	Task<float> GetScaledThreshold(string toolId);

	Task<IAutoThresholdSettings> GetAutoThresholdSettings(string toolId);

	Task SetAutoThresholdSettings(string toolId, IAutoThresholdSettings newSettings);

	Task DeleteSamples(string toolId, ICollection<string> sampleIds);

	Task<IAnomalyDetectorSample> GetSample(string toolId, string sampleId, bool metadataOnly = false);

	Task<ICollection<IAnomalyDetectorSample>> GetSamples(string toolId, int imageSize);

	Task<IFeatureSizeSettings> GetFeatureSizeSettings(string toolId);

	Task SetFeatureSize(string toolId, double newFeatureSize);

	Task OptimizeFeatureSize(string toolId);
}
