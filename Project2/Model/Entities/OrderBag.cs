using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class OrderBag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductOrderId { get; set; }
        public int customerId { get; set; }
        public int marketerId { get; set; }
        public int OrderId { get; set; }

        [ForeignKey("ProductOrderId")]
        public ProductOrder ProductOrder { get; set; }

        [ForeignKey("customerId")]
        public Customer Customer { get; set; }

        [ForeignKey("marketerId")]
        public Marketer Marketer { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }


    }
}
