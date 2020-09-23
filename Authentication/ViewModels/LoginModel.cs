using System.ComponentModel.DataAnnotations;

namespace AuthApp.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Incorrect Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Incorrect Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
