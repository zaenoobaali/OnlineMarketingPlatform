using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project2.Model.Entities
{
    public class CustomersAgent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int customerId { get; set; }
        public int marketerId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("marketerId")]
        public Marketer Marketer { get; set; }

        [ForeignKey("customerId")]
        public Customer Customer { get; set; }
    }
}
