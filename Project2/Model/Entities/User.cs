using Microsoft.AspNetCore.Identity;
using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2.Model.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; } 
        public string Email { get; set; }
        public string password { get; set; }
        public long? Billfold { get; set; }
        public string? ResetCode { get; set; } 
        public string? ResetPassToken { get; set; } 
        public UserType? userType { get; set; }
        public AccountStatus status { get; set; } = AccountStatus.Active;
        public Customer Customer { get; set; }
        public Marketer Marketer { get; set; }
        public Deliver Deliver { get; set; }
        public ICollection<Search> Searches { get; set; } = new List<Search>();
        public ICollection<Complaint>? Complaints { get; set; } = new List<Complaint>();
        public ICollection<FollowingPage>? FollowingPages { get; set; } = new List<FollowingPage>();
        public ICollection<Friend>? Friends { get; set; } = new List<Friend>();


    }
}
