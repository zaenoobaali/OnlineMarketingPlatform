using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int deliverId { get; set; }
        public PayWay? payWay { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }

        
        [ForeignKey("deliverId")]
        public Deliver? Deliver { get; set; }
        public ICollection<OrderBag> OrderBags { get; set; } = new List<OrderBag>(10);
        public ICollection<CustOrder> CustOrders { get; set; }
        public ICollection<DelivOrder> DelivOrders { get; set; }

    }
}
