using ShopStar.DtosLayer.Dtos.CatalogDtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.DtosLayer.Dtos.CatalogDtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDecription { get; set; }
        public ResultCategoryDto Category { get; set; }

    }
}
