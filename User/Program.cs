namespace User
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");

            Console.WriteLine("Select Options Please :\n" +
                "1)Enter First Name\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user = new UserRegistration();
                    user.ValidFistName();
                    break;

                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
        }
    }
}
