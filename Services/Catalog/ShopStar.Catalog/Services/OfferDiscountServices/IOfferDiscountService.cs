using ShopStar.Catalog.Dtos.CategoryDtos;
using ShopStar.Catalog.Dtos.OfferDiscountDtos;

namespace ShopStar.Catalog.Services.OfferDiscountServices
{
    public interface IOfferDiscountService
    {
        Task<List<ResultOfferDiscountDto>> GetOfferDiscountListAsync();
        Task CreateOfferDiscountAsync(CreateOfferDiscountDto createOfferDiscount);
        Task UpdateOfferDiscountAsync(UpdateOfferDiscountDto updateOfferDiscount);
        Task DeleteOfferDiscountAsync(string id);
        Task<GetByIdOfferDiscountDto> GetByIdOfferDiscountAsync(string id);
    }
}
