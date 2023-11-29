using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2.Model.Entities
{
    public class TenderComm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("Marketer")]
        public int MarketerId { get; set; }
        [ForeignKey("Tender")]
        public int TenderId { get; set; }
        public DateTime CreatedDate { get; set; }

        public Tender Tender { get; set; }
        public Marketer Marketer { get; set; }

    }
}
