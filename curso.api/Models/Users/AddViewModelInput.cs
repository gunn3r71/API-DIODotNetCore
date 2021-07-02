using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Users
{
    public class AddViewModelInput
    {
        [StringLength(16,ErrorMessage ="The username must be have {0} minimum and {1} maximum length",MinimumLength = 2)]
        [Required(ErrorMessage = "Username cannot be null")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Please, insert a valid email")]
        [Required(ErrorMessage = "Email cannot be null")]
        public string Email { get; set; }
        [DataType(DataType.Password, ErrorMessage ="Please, verify and insert a valid password")]
        [Required(ErrorMessage = "Password cannot be null")]
        public string Password { get; set; }
    }
}
