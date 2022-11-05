using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} must not be empty")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} must not be empty")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "{0} is not valid email")]
        [Required(ErrorMessage = "{0} must not be empty")]
        public string Email { get; set; }

        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
