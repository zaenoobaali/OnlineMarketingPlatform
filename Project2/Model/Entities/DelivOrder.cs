using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class DelivOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int DeliverId { get; set; }
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("DeliverId")]
        public Deliver Deliver { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}