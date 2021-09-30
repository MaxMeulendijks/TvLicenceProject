using System;

namespace TvLicenceProject.Data
{
    public class UserInfo
    {
        public string CourtDivision {get; set;}
        public string AccountNumber {get; set;}
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
