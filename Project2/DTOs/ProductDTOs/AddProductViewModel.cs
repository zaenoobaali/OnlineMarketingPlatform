using Project2.Data.Enum;
using Project2.Model.Entities;

namespace Project2.DTOs.ProductDTOs
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public string productType { get; set; }
        public int Price { get; set; }
        public int? point { get; set; }
        public string photo { get; set; }
        public List<string> colors { get; set; }
        public List<string> sizes { get; set; }
        public string productstatus { get; set; }
    }
}
