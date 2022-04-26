using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
     class UserRegistrationValidation
    {
        private static string Regex_FIRSTNAME = "^[A-Z][a-z]{2}$";
        private static string Regex_LASTNAME = "^[A-Z][a-z]{2}$";
        //method to test Firstname
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FIRSTNAME);

        }
        //method to test LastNmae
        public bool ValidateLasttName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LASTNAME);

        }
        //to print result
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
