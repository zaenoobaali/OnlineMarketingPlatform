using System.ComponentModel.DataAnnotations;

namespace Project2.DTOs.EmailDTOs
{
    public class PasswordResetRequest
    {
        [Required , EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
