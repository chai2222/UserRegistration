using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User
{
    internal class UserRegistration
    {
        public void ValidSampleEmail()
        {
            Console.WriteLine("Please Enter Sample Email :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-Z0-9]+([#$%+_-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sample Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sample Email is Invalid");
                Console.ResetColor();
            }
        }
    }
}
