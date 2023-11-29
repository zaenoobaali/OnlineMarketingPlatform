using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class Complaint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Discretion { get; set; }
        [ForeignKey("Complainer")]
        public int ComplainerId { get; set; }
        [ForeignKey("Post")]
        public int postId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Complainer { get; set; }
        public Post Post { get; set; }

    }
}
