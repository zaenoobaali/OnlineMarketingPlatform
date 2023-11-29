using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class ProductOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }
        public string productType { get; set; }
        public string photo {get; set;}
        public string size { get; set; }
        public string color { get; set; }
        public int quantity { get; set; }
        public int prouductId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("prouductId")]
        public Product Product { get; set; }

        public ICollection<OrderBag> OrderBags { get; set; } 
    }
}
