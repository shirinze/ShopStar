using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Cargo.BuinessLayer.Abstract;
using ShopStar.Cargo.BuinessLayer.Concreate;
using ShopStar.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using ShopStar.Cargo.EntityLayer.Concreate;

namespace ShopStar.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _companyService;

        public CargoCompaniesController(ICargoCompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetCargoCompanyList()
        {
            var value = _companyService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
        {
            CargoCompany cargocompany = new CargoCompany()
            { 
                CargoCompanyName=createCargoCompanyDto.CargoCompanyName
            };
            _companyService.TInsert(cargocompany);
            return Ok("Create Successfull");
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoCompanyById(int id)
        {
            var value = _companyService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteCargoCompany(int id)
        {
            _companyService.TDelete(id);
            return Ok("Delete Successfull");
        }
        [HttpPut]
        public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            CargoCompany cargocompany = new CargoCompany() 
            {
                CargoCompanyName=updateCargoCompanyDto.CargoCompanyName,
                CargoCompanyId=updateCargoCompanyDto.CargoCompanyId
            };
            _companyService.TUpdate(cargocompany);
            return Ok("Update Successfull");
        }

    }
}
