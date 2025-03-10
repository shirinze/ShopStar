using ShopStar.Catalog.Dtos.SpecialOfferDtos;

namespace ShopStar.Catalog.Services.SpecialOfferServices
{
    public interface ISpecialOfferService
    {
        Task<List<ResultSpecialOfferDto>> GetSpecialOfferListAsync();
        Task<GetByIdSpecialOfferDto> GetByIdSpecialOfferAsync(string id);
        Task CreateSpecialOfferAsync(CreateSpecialOfferDto createSpecialOfferDto);
        Task UpdateSpecialOfferAsync(UpdateSpecialOfferDto updateSpecialOfferDto);
        Task DeleteSpecialOfferAsync(string id);
    }
}
