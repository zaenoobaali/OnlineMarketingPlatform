using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Project2.Data.Enum;
//using System.Data.Entity;

namespace Project2.Model.Entities
{
    public class Popularization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        [ForeignKey("Marketer")]
        public int marketerId { get; set; }
        [ForeignKey("Product")]
        public int productId { get; set; }
        public string targetGender { get; set; }
        public string targetzone { get; set; }
        public int fromAge { get; set; }
        public int toAge { get; set; }
        public PopularizationStatus status { get; set; } = PopularizationStatus.None;
        public DateTime CreatedDate { get; set; }
        public Marketer Marketer { get; set; }
        public Product Product { get; set; }
    }
}
