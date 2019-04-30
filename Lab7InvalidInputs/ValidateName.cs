using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class ValidateName
    {
        public static void ValidateUserName()
        {
            string userName;
            bool regexVariable;

            Console.WriteLine("Enter a valid Name in First Middle Last format ");
            userName = Console.ReadLine();

            regexVariable = Regex.IsMatch(userName, @"(([A-Z][a-z]{0,30})\s([A-Z][a-z]{0,30})\s([A-Z][a-z]{0,30}))");

            if (regexVariable)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                throw new Exception("Invalid Name");
            }

        }
    }
}
