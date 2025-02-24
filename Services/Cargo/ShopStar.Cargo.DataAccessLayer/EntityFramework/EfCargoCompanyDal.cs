﻿using ShopStar.Cargo.DataAccessLayer.Abstract;
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
    public class EfCargoCompanyDal:GenericRepository<CargoCompany>,ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context):base(context)
        {
            
        }
    }
}
