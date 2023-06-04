using System;

namespace SauceDemoTraining
{

    public class UserData
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string UserPassword { get; set; }
        public string IncorrectUserPassword { get; set; }
        public UserData()
        {
            UserName = "standard_user";
            FirstName = "Jan";
            LastName = "Kowalski";
            PostalCode = "00-120";
            UserPassword = "secret_sauce";
            IncorrectUserPassword = "111";
        }
    }
}