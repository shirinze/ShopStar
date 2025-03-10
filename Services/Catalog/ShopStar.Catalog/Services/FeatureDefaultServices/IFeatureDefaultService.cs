using ShopStar.Catalog.Dtos.FeatureDefaultDtos;
using ShopStar.Catalog.Dtos.FeatureSliderDtos;

namespace ShopStar.Catalog.Services.FeatureDefaultServices
{
    public interface IFeatureDefaultService
    {
        Task<List<ResultFeatureDefaultDto>> GetAllFeatureDefaultAsync();
        Task CreateFeatureDefaultAsync(CreateFeatureDefaultDto featureDefaultDto);
        Task UpdateFeatureDefaultAsync(UpdateFeatureDefaultDto featureDefaultDto);
        Task DeleteFeatureDefaultAsync(string id);
        Task<GetByIdFeatureDefaultDto> GetByIdFeatureDefaultAsync(string id);
        
    }
}
