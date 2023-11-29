using System.ComponentModel.DataAnnotations;

namespace Project2.DTOs.UserDTOs
{
    public class UserPasswordViewModel
    {
        [Required, MinLength(8, ErrorMessage = "Please enter at least 8 characters")]
        public string password { get; set; } = string.Empty;
        [Required, Compare("password")]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
