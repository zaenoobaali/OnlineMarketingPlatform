using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project2.Model.Entities
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; } 
        public int marketerId { get; set; }
        public int productId { get; set; }
        public int counter { get; set; } = 0;
        public int reactioncount { get; set; } = 0;
        public PostStatus status { get; set; } = PostStatus.Public;
        public DateTime CreatedDate { get; set; }

        [ForeignKey("marketerId")]
        public Marketer Marketer { get; set; }

        [ForeignKey("productId")]
        public Product Product { get; set; } 

       // public ICollection<Order> Orders { get; set; }
        public ICollection<OrderBag> OrderBags { get; set; }
        public ICollection<CustPost> CustPosts { get; set; } 
        //public ICollection<Interaction> Interactions { get; set; } 

    }
}
