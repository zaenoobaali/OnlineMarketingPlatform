using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class ReactionOnPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int postId { get; set; }
        public int userId { get; set; }

        [ForeignKey("postId")]
        public Post Post { get; set; }

        [ForeignKey("userId")]
        public User User { get; set; }

    }
}
