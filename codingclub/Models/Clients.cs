using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClubTest.Models
{
    public class Clients
    {
        public string ID{get;set;}
        [Required]

        [Display(Name="E-Mail Adress")]
        public string Email{get;set;}
        [Required]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        [Required]
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]
        [Display(Name="Client ID")]
        
        public string Classification {get;set;}
        
    }
}