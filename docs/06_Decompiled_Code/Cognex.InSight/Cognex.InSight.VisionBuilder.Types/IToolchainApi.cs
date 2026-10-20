using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace Cognex.InSight.VisionBuilder.Types;

public interface IToolchainApi
{
	bool IsToolchainLoaded { get; }

	long NumCollectedImages { get; }

	event EventHandler PropertiesUpdated;

	event EventHandler ToolChainUpdated;

	Task InitializeAsync();

	Task UpdateNumImages();

	Task<ImageMetadata[]> GetImageMetadataAsync();

	Task<Stream> GetImageStreamAsync(string id);

	Task<Bitmap> GetThumbnailImageAsync(string id);

	Task ClearImageAsync(string imageId);

	Task ClearImagesAsync();

	Task CollectCurrentImageAsync();

	Task<InSightTag[]> GetTagsAsync();

	Task<InSightTag> AddTagAsync(string name, string color);

	Task DeleteTagAsync(string tagId);

	Task<InSightTag> UpdateTagAsync(string tagId, string name, string color);

	Task AddElementsToTagAsync(string tagId, string[] elementIds);

	Task RemoveElementsFromTagAsync(string tagId, string[] elementIds);

	Task LoadToolChainAsync(Stream toolchainArchive);

	Task ClearToolChainAsync();

	Task SetProjectInfoAsync(ProjectInfo projectInfo);

	Task<ProjectInfo> GetProjectInfoAsync();

	Task<Server> GetServerAsync();

	Task SetServerAsync(Server server);
}
