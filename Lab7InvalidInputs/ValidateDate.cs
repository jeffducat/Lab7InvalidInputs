using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class ValidateDate
    {
        public static void ValidateUserDate()
        {
            string userDate;
            bool regexVariable;

            Console.WriteLine("Enter a valid Date in DD/MM/YYYY format ");
            userDate = Console.ReadLine();

            regexVariable = Regex.IsMatch(userDate, @"(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)[0-9]{2}");

            if (regexVariable)
            {
                Console.WriteLine("Valid Date");
            }
            else
            {
                throw new Exception("Invalid Date");
            }
        }
    }
}
