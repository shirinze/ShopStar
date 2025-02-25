using ShopStar.Basket.Dtos;

namespace ShopStar.Basket.Services
{
    public interface IBaskerService
    {
        Task<BasketTotalDto> GetBasket(string userId);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string userId);
    }
}
