using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project2.Data.Enum;

namespace Project2.Model.Entities
{
    public class ProductSize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string size { get; set; }
        public int productId { get; set; }

        [ForeignKey("productId")]
        public Product Product { get; set; }
    }
}
