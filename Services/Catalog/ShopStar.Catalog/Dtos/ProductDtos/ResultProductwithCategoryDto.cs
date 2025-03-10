using ShopStar.Catalog.Dtos.CategoryDtos;

namespace ShopStar.Catalog.Dtos.ProductDtos
{
    public class ResultProductwithCategoryDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDecription { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}
