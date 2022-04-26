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
        //list of the sample emails
        private List<string> sampleMails = new List<string>()
        {
           "abc@yahoo.com",
           "abc-100@yahoo.com",
           "abc.100@yahoo.com",
           "abc111@abc.com",
           "abc-100@abc.net",
           "abc.100@abc.com.au",
           "abc@1.com",
           "abc@gmail.com.com",
           "abc+100@gmail.com"

        };

        private static string Regex_FIRSTNAME = "^[A-Z][a-z]{2}$";
        private static string Regex_LASTNAME = "^[A-Z][a-z]{2}$";
        private static string Regex_EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        private static string Regex_MOBILENUMBER = "^[1-9]{1,3}[][1-9][0-9]{9}$";
        // private static string Regex_PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        // private static string Regex_PASSWORD = "^(?=.*[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$";//should have at least one upper case
        //private static string Regex_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$";//should have one numaric number
        private static string Regex_PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$";// should have one special charector
        private static string Regex_Email2 = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";//for sample emails

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
        //method to validate password 
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_PASSWORD);

        }
        //method to test sample emails
        public bool ValidateEmail2(string email)
        {
            return Regex.IsMatch(email, Regex_Email2);

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
        //method to get the list
        public List<string>GetList()
        {
            return sampleMails;
        }
    }
}
