
using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Email")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}
