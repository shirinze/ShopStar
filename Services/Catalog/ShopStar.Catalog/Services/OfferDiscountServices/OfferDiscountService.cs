using AutoMapper;
using MongoDB.Driver;
using ShopStar.Catalog.Dtos.OfferDiscountDtos;
using ShopStar.Catalog.Entities;
using ShopStar.Catalog.Settings;

namespace ShopStar.Catalog.Services.OfferDiscountServices
{
    public class OfferDiscountService : IOfferDiscountService
    {
        private readonly IMongoCollection<OfferDiscount> _offerDisountCollection;
        private readonly IMapper _mapper;

        public OfferDiscountService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _offerDisountCollection = database.GetCollection<OfferDiscount>(_databaseSettings.OfferDiscountCollectionName);
            _mapper = mapper;
        }

        public async Task CreateOfferDiscountAsync(CreateOfferDiscountDto createOfferDiscount)
        {
            var value = _mapper.Map<OfferDiscount>(createOfferDiscount);
            await _offerDisountCollection.InsertOneAsync(value);
        }

        public async Task DeleteOfferDiscountAsync(string id)
        {
            await _offerDisountCollection.DeleteOneAsync(x => x.OfferDiscountId == id);
        }

        public async Task<GetByIdOfferDiscountDto> GetByIdOfferDiscountAsync(string id)
        {
            var value = await _offerDisountCollection.Find<OfferDiscount>(x => x.OfferDiscountId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdOfferDiscountDto>(value);
        }

        public async Task<List<ResultOfferDiscountDto>> GetOfferDiscountListAsync()
        {
            var values = await _offerDisountCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultOfferDiscountDto>>(values);
        }

        public async Task UpdateOfferDiscountAsync(UpdateOfferDiscountDto updateOfferDiscount)
        {
            var value = _mapper.Map<OfferDiscount>(updateOfferDiscount);
            await _offerDisountCollection.FindOneAndReplaceAsync(x => x.OfferDiscountId == updateOfferDiscount.OfferDiscountId, value);
        }
    }
}
