using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class ContractedDeliver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int deliverId { get; set; }
        public int marketerId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("marketerId")]
        public Marketer Marketer { get; set; }

        [ForeignKey("deliverId")]
        public Deliver Deliver { get; set; }
    }
}
