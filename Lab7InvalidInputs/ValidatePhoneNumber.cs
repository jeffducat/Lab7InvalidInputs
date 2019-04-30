using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class ValidatePhoneNumber
    {
        public static void ValidateUserPhoneNumber()
        {
            string userPhoneNumber;
            bool regexVariable;

            Console.WriteLine("Enter a valid Phone Number in 999-999-9999 format ");
            userPhoneNumber = Console.ReadLine();
            
            regexVariable = Regex.IsMatch(userPhoneNumber, "[0-9]{3}-[0-9]{3}-[0-9]{4}");

            if (regexVariable)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                throw new Exception("Invalid Phone Number");
            }
        }
    }
}
