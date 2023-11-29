using Project2.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Project2.DTOs.UserDTOs
{
    public class AddUserViewModel
    {
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(8, ErrorMessage = "Please enter at least 8 characters")]
        public string password { get; set; } = string.Empty;
        [Required, Compare("password")]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
