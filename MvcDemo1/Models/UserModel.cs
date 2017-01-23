using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MvcDemo1.Models
{
    public class UserModel
    {
        [Required]
        [HiddenInput]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Display(Name = "Förnamn")]
        [Required(ErrorMessage = "Förnamn måste anges")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Adress")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Födelsedatum")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Lön")]
        [Range(100, 10000)]
        
        public decimal Salary { get; set; }
    }
}