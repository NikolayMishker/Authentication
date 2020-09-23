using System.ComponentModel.DataAnnotations;

namespace AuthApp.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Incorrect Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Incorrect Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Wrong Password")] // подтверждение пароля
        public string ConfirmPassword { get; set; }
    }
}
