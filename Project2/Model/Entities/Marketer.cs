using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2.Model.Entities
{
    public class Marketer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long phoneNumber { get; set; }
        public long mobileNumber { get; set; }
        public string? photo { get; set; }
        public int? Point { get; set; }
        public int userId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string city { get; set; }
        public string zone { get; set; }

        [ForeignKey("userId")]
        public User User { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Customer> CustomersAgents { get; set; } = new List<Customer>();
        public ICollection<Popularization> Popularizations { get; set; } = new List<Popularization>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Deliver> Delivers { get; set; } = new List<Deliver>();
        public ICollection<Auction> Auctions { get; set; }
        public ICollection<Mark_Tender> MarketerTenders { get; set; } = new List<Mark_Tender>();
        public ICollection<TenderComm> TenderComments { get; set; } = new List<TenderComm>();
        public ICollection<FollowingPage> FollowingPages { get; set; } = new List<FollowingPage>();

    }
}
