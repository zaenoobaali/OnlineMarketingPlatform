using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class CustPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PostId { get; set; }
        public int MarketerId { get; set; }
        public int ProductOrderId { get; set; }
        public PostStatus status { get; set; } = PostStatus.Public;
        public int reactioncounter { get; set; } = 0;
        public DateTime CreatedDate { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        [ForeignKey("MarketerId")]
        public Marketer Marketer { get; set; }
        [ForeignKey("ProductOrderId")]
        public ProductOrder ProductOrder { get; set; }

    }
}
