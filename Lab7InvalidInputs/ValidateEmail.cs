using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class ValidateEmail
    {
        public static void ValidateUserEmail()
        {
            string userEmail;
            bool regexVariable;

            Console.WriteLine("Enter a valid Email: ");
            userEmail = Console.ReadLine();

            regexVariable = Regex.IsMatch(userEmail, @"([A-Za-z0-9]{5,30}[@][a-zA-Z0-9]{5,10}[.]+(com|gov|co|net|org){1,3}(?!\S))");

            
            if (regexVariable)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                throw new Exception("Invalid Email");
            }

        }
    }
}
