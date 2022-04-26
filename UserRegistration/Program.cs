using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");

            //object created
            UserRegistrationValidation validate = new UserRegistrationValidation();
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            bool fNameResult = validate.ValidateFirstName(firstName);
            validate.PrintResult(fNameResult);

            Console.WriteLine("--------------");

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            bool lNameResult = validate.ValidateLasttName(lastName);
            validate.PrintResult(lNameResult);

            Console.WriteLine("--------------");

            Console.WriteLine("Enter Email id:");
            string email = Console.ReadLine();
            bool emailResult = validate.ValidateEmail(email);
            validate.PrintResult(emailResult);

            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }
}
