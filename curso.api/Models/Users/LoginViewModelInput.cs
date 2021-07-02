using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Users
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage ="Login cannot be null")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Password cannot be null")]
        public string Password { get; set; }
    }
}
