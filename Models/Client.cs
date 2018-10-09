using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClubTest.Models
{
    public class Client
    {
        public string ID{get;set;}
        [Required]
        [Display(Name="E-Mail Adress")]
        //[RegularExpression( @"@(buffs.wtamu|wtamu)\.edu$", ErrorMessage = "Invalid domain in email address. The domain must be a buff e-mail")]
        public string Email{get;set;}
        [Required]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        [Required]
        [Display(Name="Last Name")]
        public string LastName {get;set;}
        [Required]
        [Display(Name="Job Title")]
        public string Job {get;set;}
        
        
    }
}