
using System.Text.RegularExpressions;


namespace User
{
    public  class UserRegistration
    {
        public void ValidPasswordRule1()
        {
            Console.WriteLine("Please Enter Password Rule 1 :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-Z]{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 1 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 1 Invalid");
                Console.ResetColor();
            }
        }
    }
}
