namespace User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to REGEX User Registration Problem");
        Start:
            Console.WriteLine("Select Options Please :\n" +
                "1)Enter Sample Emails\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user8 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user8.ValidSampleEmail();
                    break;



                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
            goto Start;
        }
    }
}
