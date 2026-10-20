using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cognex.Segmenter.Client.Tool.Interfaces;

public interface ISegmenterToolAdapter
{
	event EventHandler<NewResultArgs> NewResult;

	event EventHandler<ClassesUpdatedArgs> ClassesUpdated;

	Task<ISegmenterStats> GetStats(string toolId);

	Task<ISegmenterResult> GetCurrentResult(string toolId);

	Task<ICollection<ISegmenterSample>> GetSamples(string toolId, int imageSize);

	Task LabelImage(string toolId, string sampleId, IMaskBitmap labelImage);

	Task Skip(string toolId);

	Task DeleteSamples(string toolId, ICollection<string> sampleIds);

	Task<ISegmenterSample> GetSample(string toolId, string sampleId);

	Task<ICollection<ISegmenterClass>> GetClasses(string toolId);

	Task<int> AddClass(string toolId, ISegmenterClass classData);

	Task UpdateClasses(string toolId, ICollection<ISegmenterClass> editedClasses, ICollection<int> deletedClassIDs);
}
