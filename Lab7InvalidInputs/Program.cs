using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7InvalidInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateName.ValidateUserName();
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.Message);
            }


            try
            {
                ValidateEmail.ValidateUserEmail();
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.Message);
            }


            try
            {
                ValidatePhoneNumber.ValidateUserPhoneNumber();
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.Message);
            }


            try
            {
                ValidateDate.ValidateUserDate();
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.Message);
            }
        }



    }
}
