
using System.Text.RegularExpressions;


namespace User
{
    public class UserRegistration
    {
        public void ValidPasswordRule3()
        {
            Console.WriteLine("Please Enter Password Rule 3 :");
            string data = Console.ReadLine();

            string pattern = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 3 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 3 Invalid");
                Console.ResetColor();
            }
        }
    }
}
