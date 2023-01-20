﻿namespace User
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");
        Start:
            Console.WriteLine("Select Options Please :\n" +
                "1)Enter First Name\n" +
                "2)Enter Last Name\n" +
                "3)Enter E-Mail Address\n" +
                "4)Enter Phone Number\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::::");
                    user.ValidFirstName();
                    break;

                case 2:

                    UserRegistration user1 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::::");
                    user1.ValidLastName();
                    break;

                case 3:
                    UserRegistration user2 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user2.ValidEmail();
                    break;

                case 4:

                    UserRegistration user3 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user3.ValidPhNumber();
                    break;


                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
            goto Start;
        }
    }
}
