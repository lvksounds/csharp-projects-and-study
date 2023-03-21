using System.ComponentModel.DataAnnotations;

namespace formteste.Models
{
    public class PersonModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
