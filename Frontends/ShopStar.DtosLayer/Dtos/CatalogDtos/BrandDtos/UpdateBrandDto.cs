﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.DtosLayer.Dtos.CatalogDtos.BrandDtos
{
    public class UpdateBrandDto
    {
        public string BrandID { get; set; }
        public string BrandName { get; set; }
        public string ImageUrl { get; set; }
    }
}
