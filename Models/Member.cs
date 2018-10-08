using System;
using System.ComponentModel.DataAnnotations;

namespace CodingClubTest.Models
{
    public class Member
    {
        public string ID{get;set;}
        [Required]
        //[RegularExpression( @"@(buffs.wtamu|wtamu)\.edu$", ErrorMessage = "Invalid domain in email address. The domain must be a buff e-mail")]
        public string Email{get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        [StringLength(10,MinimumLength = 9, ErrorMessage = "Invalid Buff ID")]
        public string buffID {get;set;}
        [Required]
        public string Classification {get;set;}
        
    }
}