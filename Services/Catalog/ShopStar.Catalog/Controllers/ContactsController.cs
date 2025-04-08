using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Catalog.Dtos.ContactDtos;
using ShopStar.Catalog.Services.ContactServices;
using System.Runtime.CompilerServices;

namespace ShopStar.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public async Task<IActionResult> GetContactList()
        {
            var value = await _contactService.GetContactListAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            await _contactService.CreateContactAsync(createContactDto);
            return Ok("Create Success");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(string id)
        {
            await _contactService.DeleteContactAsync(id);
            return Ok("Delete Success");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdContact(string id)
        {
            var value = await _contactService.GetByIdContactAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            await _contactService.UpdateContactAsync(updateContactDto);
            return Ok("UpdateSuccess");
        }
    }
}
