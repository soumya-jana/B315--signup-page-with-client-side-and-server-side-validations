using B315_01_MVC6_SignUp_ClientSide_ServerSide.Attributes;
using System.ComponentModel.DataAnnotations;

namespace B315_01_MVC6_SignUp_ClientSide_ServerSide.Models
{
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password.")]
        [Compare("Password", ErrorMessage = "Confirm password does’t match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


        //[RegularExpression("^[6789]\\d{9}", ErrorMessage = "Please enter correct contact number.")]
        //[RegularExpression("^\\+?\\d{0,2}\\s?\\[0-9]d{5}\\s?\\[0-9]d{5}", ErrorMessage = "Please enter correct contact number.")]
        [RegularExpression("\\+[0-9]{2}\\s+[0-9]{5}\\s+[0-9]{5}", ErrorMessage = "Please enter correct contact number.")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please select country.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please select city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please choose gender.")]
        public string Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [ValidateCheckBox(ErrorMessage = "Please accept terms.")]
        public bool Terms { get; set; }

    }
}
