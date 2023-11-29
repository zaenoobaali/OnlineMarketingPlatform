using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2.Model.Entities
{
    public class Mark_Tender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MarketerId { get; set; }
        public int TenderId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("TenderId")]
        public Tender Tender { get; set; }
        [ForeignKey("MarketerId")]
        public Marketer Marketer { get; set; }
    }
}
