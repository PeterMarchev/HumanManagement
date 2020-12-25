using System.ComponentModel.DataAnnotations;

namespace HumanManagement.Models.ViewModels.Account
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
