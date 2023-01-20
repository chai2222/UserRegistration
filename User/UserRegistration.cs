
using System.Text.RegularExpressions;


namespace User
{
    public class UserRegistration
    {
        public void ValidFistName()
        {
            Console.WriteLine("Please Enter First Name :");
            string data = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{2,10}$";
            //Creating Object of the Regex SuperClass
            Regex regobj = new Regex(pattern);
            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("First Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("First Name Is Invalide");
                Console.ResetColor();
            }
        }
    }
}
