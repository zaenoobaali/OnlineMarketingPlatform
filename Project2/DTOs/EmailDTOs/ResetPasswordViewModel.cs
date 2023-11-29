using System.ComponentModel.DataAnnotations;

namespace Project2.DTOs.EmailDTOs
{
    public class ResetPasswordViewModel
    {
        [Required, MinLength(8, ErrorMessage = "")]
        public string NewPassword { get; set; } = string.Empty;
        [Required, Compare("NewPassword")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
