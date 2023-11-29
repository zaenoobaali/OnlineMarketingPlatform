using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Name { get; set; }
        public string productType { get; set; }
        public int Price { get; set; }
        public string photo { get; set; }
        public int? point { get; set; }
        public DateTime CreatedDate { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public ICollection<ProductSize> sizes { get; set; }
        public ICollection<ProductColor> colors { get; set; }
        // public ICollection<Post> Posts { get; set; }
    }
}
