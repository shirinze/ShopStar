using AutoMapper;
using MongoDB.Driver;
using ShopStar.Catalog.Dtos.FeatureDefaultDtos;
using ShopStar.Catalog.Entities;
using ShopStar.Catalog.Settings;

namespace ShopStar.Catalog.Services.FeatureDefaultServices
{
    public class FeatureDefaultService : IFeatureDefaultService
    {
        private readonly IMongoCollection<FeatureDefault> _featureDefaultCollection;
        private readonly IMapper _mapper;

        public FeatureDefaultService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _featureDefaultCollection = database.GetCollection<FeatureDefault>(_databaseSettings.FeatureDefaultCollectionName);
            _mapper = mapper;
        }

        public async Task CreateFeatureDefaultAsync(CreateFeatureDefaultDto featureDefaultDto)
        {
            var value = _mapper.Map<FeatureDefault>(featureDefaultDto);
            await _featureDefaultCollection.InsertOneAsync(value);
        }

        public async Task DeleteFeatureDefaultAsync(string id)
        {
            await _featureDefaultCollection.DeleteOneAsync(x => x.FeatureDefaultId == id);
        }

        public async Task<List<ResultFeatureDefaultDto>> GetAllFeatureDefaultAsync()
        {
            var value =await _featureDefaultCollection.Find(x => true).ToListAsync();
            return  _mapper.Map<List<ResultFeatureDefaultDto>>(value);
        }

        public async Task<GetByIdFeatureDefaultDto> GetByIdFeatureDefaultAsync(string id)
        {
            var value = await _featureDefaultCollection.Find<FeatureDefault>(x => x.FeatureDefaultId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdFeatureDefaultDto>(value);
        }

        public async Task UpdateFeatureDefaultAsync(UpdateFeatureDefaultDto featureDefaultDto)
        {
            var value = _mapper.Map<FeatureDefault>(featureDefaultDto);
            await _featureDefaultCollection.FindOneAndReplaceAsync(x => x.FeatureDefaultId == featureDefaultDto.FeatureDefaultId, value);
        }
    }
}
