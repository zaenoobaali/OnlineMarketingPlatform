using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class PointRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int marketerId { get; set; }
        public int pointsAmount { get; set; }
        public int pointsPrice { get; set; }
        public PopularizationStatus status { get; set; }

        [ForeignKey("marketerId")]
        public Marketer Marketer { get; set; }
    }
}
