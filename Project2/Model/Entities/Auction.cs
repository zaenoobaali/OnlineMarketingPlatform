using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Auction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Discretion { get; set; }
        public int MarketerId { get; set; }
        public int Value { get; set; }
        public AuctionTenderStatus Status { get; set; } = AuctionTenderStatus.OFF;
        public DateTime CreatedDate { get; set; }
        public DateTime FinalDate { get; set; }

        public ICollection<Cust_Auction> CustAuctions { get; set; }
        public ICollection<AuctionComm> AuctionComments { get; set; }

        [ForeignKey("MarketerId")]
        public Marketer Marketer { get; set; }
    }
}
