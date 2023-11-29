using Project2.Data.Enum;
using Project2.DTOs.ProductDTOs;

namespace Project2.DTOs.PostDTOs
{
    public class UpdatePostViewModel
    {
        //public string Name { get; set; }
        //public int Price { get; set; }
        //public string photo { get; set; }
        //public ProductType? productType { get; set; }
        public UpdateProductViewModel Product { get; set; }
        public string Description { get; set; }
      
    }
}
