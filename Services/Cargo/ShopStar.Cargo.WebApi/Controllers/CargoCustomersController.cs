using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Cargo.BuinessLayer.Abstract;
using ShopStar.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using ShopStar.Cargo.EntityLayer.Concreate;

namespace ShopStar.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _customerService;

        public CargoCustomersController(ICargoCustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetCargoCustomerList()
        {
            var value = _customerService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                
                Name= createCargoCustomerDto.Name,
                Surename = createCargoCustomerDto.Surename,
                City = createCargoCustomerDto.City,
                Address = createCargoCustomerDto.Address,
                District=createCargoCustomerDto.District,
                Email=createCargoCustomerDto.Email,
                Phone=createCargoCustomerDto.Phone
            };
            _customerService.TInsert(cargoCustomer);
            return Ok("Create Successfull");
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoCustomerById(int id)
        {
            var value = _customerService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteCargoCustomer(int id)
        {
            _customerService.TDelete(id);
            return Ok("Delete Successfull");
        }
        [HttpPut]
        public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Name = updateCargoCustomerDto.Name,
                Surename = updateCargoCustomerDto.Surename,
                City = updateCargoCustomerDto.City,
                Address = updateCargoCustomerDto.Address,
                District = updateCargoCustomerDto.District,
                Email = updateCargoCustomerDto.Email,
                Phone = updateCargoCustomerDto.Phone,
                CargoCustomerId=updateCargoCustomerDto.CargoCustomerId
            };
            _customerService.TUpdate(cargoCustomer);
            return Ok("Update Successfull");
        }
    }
}
