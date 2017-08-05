using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HWAssignment.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
      
        [Required(ErrorMessage ="You must enter a First Name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a Last Name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter an Address!")]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage = "You must enter a City!")]
        public string City { get; set; }

        [Required(ErrorMessage = "You must enter a State!")]
        public string State { get; set; }

        [Required(ErrorMessage = "You must enter a Zip Code!")]
        public int Zip { get; set; }
        [Required(ErrorMessage = "You must enter a Country! Please enter US")]
        public string Country { get; set; }

        [Required(ErrorMessage = "You must enter a valid e-mail address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }


    }
}