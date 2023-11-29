using Project2.Data.Enum;

namespace Project2.DTOs.ProductDTOs
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string productType { get; set; }
        public int Price { get; set; }
        public string photo { get; set; }
        public ProductStatus ProductStatus { get; set; }
    }
}
