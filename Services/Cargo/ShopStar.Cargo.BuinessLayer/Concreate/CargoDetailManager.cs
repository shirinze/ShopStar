using ShopStar.Cargo.BuinessLayer.Abstract;
using ShopStar.Cargo.DataAccessLayer.Abstract;
using ShopStar.Cargo.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Cargo.BuinessLayer.Concreate
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDal _cargoDeatilDal;

        public CargoDetailManager(ICargoDetailDal cargoDeatilDal)
        {
            _cargoDeatilDal = cargoDeatilDal;
        }

        public void TDelete(int id)
        {
            _cargoDeatilDal.Delete(id);
        }

        public List<CargoDetail> TGetAll()
        {
            return _cargoDeatilDal.GetAll();
        }

        public CargoDetail TGetById(int id)
        {
            return _cargoDeatilDal.GetById(id);
        }

        public void TInsert(CargoDetail entity)
        {
            _cargoDeatilDal.Insert(entity);
        }

        public void TUpdate(CargoDetail entity)
        {
            _cargoDeatilDal.Update(entity);
        }
    }
}
