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
        private static string Regex_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        private static string Regex_MOBILENUMBER = "^[1-9]{1,3}[][1-9][0-9]{9}$";
        private static string Regex_PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";


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
        //method to test Emailid
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_EMAIL);

        }
        //method to validate mobilenumber
        public bool ValidateMobileNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, Regex_MOBILENUMBER);

        }
        //method to validate password for minimum 8 char
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_PASSWORD);

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
