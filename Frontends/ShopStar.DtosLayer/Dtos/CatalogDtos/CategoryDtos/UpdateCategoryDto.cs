﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.DtosLayer.Dtos.CatalogDtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

    }
}
