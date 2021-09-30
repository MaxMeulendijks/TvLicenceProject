using System;
using System.ComponentModel.DataAnnotations;

namespace TvLicenceProject.Data
{
    public class UserInfo
    {
        [Required]
        [StringLength(8, MinimumLength = 0, ErrorMessage = "Court division should either be {1} characters, or not filled in.")]
        public string CourtDivision {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 0, ErrorMessage = "Account number should either be {1} characters, or not filled in.")]
        public string AccountNumber {get; set;}

        [Required]
        [StringLength(10, ErrorMessage = "Tv Licence number should either be {1} characters long.")]
        public string LicenceNumber {get; set;}
        
        public string UserSurname {get; set;}
        public string UserPostcode {get; set;}

        public int UserFine {get; set;}

        public string CardNumber {get; set;}
        public string ExpiryMonth {get; set;}
        public string ExpiryYear {get; set;}
        public string CardName {get; set;}
        public string CardSecurity {get; set;}
        public string BillingStreet {get; set;}
        public string BillingCity {get; set;}
        public string BillingPostcode {get; set;}
        public string BillingEmail {get; set;}


    }
}