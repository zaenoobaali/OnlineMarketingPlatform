using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; } 
        public string UserName { get; set; } 
        public long phoneNumber { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string? photo { get; set; }
        public int? Point { get; set; }
        public int userId { get; set; }
        public string city { get; set; }
        public string zone { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public bool IsAgent { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
        public ICollection<OrderBag> OrderBags { get; set; } = new List<OrderBag>();
        public ICollection<CustOrder>? CustOrders { get; set; } = new List<CustOrder>();
        public ICollection<CustPost>? CustPosts { get; set; } = new List<CustPost>();
        public ICollection<Cust_Auction>? CustAuctions { get; set; } = new List<Cust_Auction>();
        public ICollection<Tender>? Tenders { get; set; } = new List<Tender>();
        public ICollection<Friend>? Friends { get; set; } = new List<Friend>();
        public ICollection<AuctionComm>? AuctionComms { get; set; } = new List<AuctionComm>();
    }
}
