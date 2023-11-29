using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Project2.Data.Enum;

namespace Project2.Model.Entities
{
    public class Tender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string?Discretion { get; set; }
        public int CustomerId { get; set; }
        public int? Value { get; set; }
        public AuctionTenderStatus Status { get; set; } = AuctionTenderStatus.OFF;
        public DateTime CreatedDate { get; set; }
        public DateTime FinalDate { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public ICollection<TenderComm> TenderComments { get; set; }
        public ICollection<Mark_Tender> Mark_Tenders { get; set; }
    }
}
