using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Search
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int userId { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("userId")]
        public User User { get; set; }
    }
}
