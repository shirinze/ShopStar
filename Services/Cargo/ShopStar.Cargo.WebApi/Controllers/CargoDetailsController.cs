using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopStar.Cargo.BuinessLayer.Abstract;
using ShopStar.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using ShopStar.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using ShopStar.Cargo.EntityLayer.Concreate;

namespace ShopStar.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _detailService;

        public CargoDetailsController(ICargoDetailService detailService)
        {
            _detailService = detailService;
        }

        [HttpGet]
        public IActionResult GetCargoDetailList()
        {
            var value = _detailService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail cargodetail = new CargoDetail()
            {
                SenderCustomer=createCargoDetailDto.SenderCustomer,
                RecieverCustomer=createCargoDetailDto.RecieverCustomer,
                Barcode=createCargoDetailDto.Barcode,
                CargoCompanyId=createCargoDetailDto.CargoCompanyId
            };
            _detailService.TInsert(cargodetail);
            return Ok("Create Successfull");
        }
        [HttpGet("{id}")]
        public IActionResult GetCargoDetailById(int id)
        {
            var value = _detailService.TGetById(id);
            return Ok("GetById Successfull");
        }
        [HttpDelete]
        public IActionResult DeleteCargoDetail(int id)
        {
            _detailService.TDelete(id);
            return Ok("Delete Successfull");
        }
        [HttpPost]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail cargodetail = new CargoDetail()
            {
                SenderCustomer = updateCargoDetailDto.SenderCustomer,
                RecieverCustomer = updateCargoDetailDto.RecieverCustomer,
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId,
                CargoDetailId=updateCargoDetailDto.CargoDetailId
            };
            _detailService.TUpdate(cargodetail);
            return Ok("Update Successfull");
        }
    }
}
