using ShopStar.Cargo.DataAccessLayer.Abstract;
using ShopStar.Cargo.DataAccessLayer.Context;
using ShopStar.Cargo.DataAccessLayer.Repositories;
using ShopStar.Cargo.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCustomerDal:GenericRepository<CargoCustomer>,ICargoCustomerDal
    {
        public EfCargoCustomerDal(CargoContext context):base(context)
        {
            
        }
    }
}
