using ShopStar.Catalog.Dtos.ContactDtos;

namespace ShopStar.Catalog.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetContactListAsync();
        Task<GetByIdContactDto> GetByIdContactAsync(string id);
        Task CreateContactAsync(CreateContactDto createContactDto);
        Task UpdateContactAsync(UpdateContactDto updateContactDto);
        Task DeleteContactAsync(string id);
    }
}
