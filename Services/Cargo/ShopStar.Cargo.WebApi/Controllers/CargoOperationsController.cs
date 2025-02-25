using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Cargo.BuinessLayer.Abstract;
using ShopStar.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using ShopStar.Cargo.EntityLayer.Concreate;

namespace ShopStar.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _operationService;

        public CargoOperationsController(ICargoOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpGet]
        public IActionResult GetCargoOperationList()
        {
            var value = _operationService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
                Barcode = createCargoOperationDto.Barcode,
                Description = createCargoOperationDto.Description,
                OperationDate = createCargoOperationDto.OperationDate

            };
            _operationService.TInsert(cargoOperation);
            return Ok("Create Successfull");
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoOperationById(int id)
        {
            var value = _operationService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete]
        public IActionResult DeleteCargoOperation(int id)
        {
            _operationService.TDelete(id);
            return Ok("Delete Successfull");
        }
        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
               Barcode=updateCargoOperationDto.Barcode,
               CargoOperationId=updateCargoOperationDto.CargoOperationId,
               Description=updateCargoOperationDto.Description,
               OperationDate=updateCargoOperationDto.OperationDate
            };
            _operationService.TUpdate(cargoOperation);
            return Ok("Update Successfull");
        }
    }
}
