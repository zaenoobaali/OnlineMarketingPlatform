using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2.Model.Entities
{
    public class Deliver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long mobileNumber { get; set; }
        public long phoneNumber { get; set; }
        public string? photo { get; set; }
        public int userId { get; set; }
        public string city { get; set; }
        public string zone { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<DelivOrder> DelivOrders { get; set; } = new List<DelivOrder>();  
    }
}
