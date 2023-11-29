using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class CustOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}