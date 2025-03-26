using AutoMapper;
using MongoDB.Driver;
using ShopStar.Catalog.Dtos.AboutDtos;
using ShopStar.Catalog.Entities;
using ShopStar.Catalog.Settings;

namespace ShopStar.Catalog.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IMongoCollection<About> _aboutCollection;
        private readonly IMapper _mapper;

        public AboutService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _aboutCollection = database.GetCollection<About>(_databaseSettings.AboutCollectionName);
            _mapper = mapper;
        }

        public async Task CreateAboutAsync(CreateAboutDto aboutDto)
        {
            var value = _mapper.Map<About>(aboutDto);
            await _aboutCollection.InsertOneAsync(value);
        }

        public async Task DeleteAboutAsync(string id)
        {
            await _aboutCollection.DeleteOneAsync(x => x.AboutId == id);
        }

        public async Task<List<ResultAboutDto>> GetAllAboutAsync()
        {
            var values =await _aboutCollection.Find(x => true).ToListAsync();
            return  _mapper.Map<List<ResultAboutDto>>(values);
        }

        public async Task<GetByIdAboutDto> GetByIdAboutAsync(string id)
        {
            var value = await _aboutCollection.Find<About>(x => x.AboutId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdAboutDto>(value);
        }

        public async Task UpdateAboutAsync(UpdateAboutDto aboutDto)
        {
            var value=_mapper.Map<About>(aboutDto);
            await _aboutCollection.FindOneAndReplaceAsync(x => x.AboutId == aboutDto.AboutId, value);
        }
    }
}
