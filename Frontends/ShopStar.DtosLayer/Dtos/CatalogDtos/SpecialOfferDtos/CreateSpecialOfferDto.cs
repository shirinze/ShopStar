using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.DtosLayer.Dtos.CatalogDtos.SpecialOfferDtos
{
    public class CreateSpecialOfferDto
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string SubTitle { get; set; }
    }
}
