using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClubTest.Models
{
    public class Organization
    {
        public string ID {get; set;}
        [Required]
        [Display(Name = "E-Mail Address")]
        public string Email{get; set;}
        [Required]
        [Display(Name = "Organization Name")]
        public string OrganizationName {get; set;}
         
    }
}