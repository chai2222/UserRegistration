
using System.Text.RegularExpressions;


namespace User
{
    public class UserRegistration
    {
        //UC6

        public void ValidPasswordRule2()
        {
            Console.WriteLine("Please Enter Password Rule 2 :");
            string data = Console.ReadLine();

            string pattern = "^(?=.*[A-Z])[a-zA-Z]{4,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 2 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 2 Invalid");
                Console.ResetColor();
            }
        }
    }
}
