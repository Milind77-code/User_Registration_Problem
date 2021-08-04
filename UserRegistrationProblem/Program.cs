using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<--------Welcome to User Registration Problem--------->");
            Console.WriteLine("-------------------------------------------------------");

            Console.Write("Enter First Name :- ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name :- ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email ID :- ");
            string email = Console.ReadLine();
            Console.Write("Enter Mobile Number :- ");
            string mobile = Console.ReadLine();
            Console.Write("Enter Password :- ");
            string password = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");

            // Creating object
            RegexTest R = new RegexTest();
            Console.WriteLine(R.TestFirstName(firstName));
            Console.WriteLine(R.TestLastName(lastName));
            Console.WriteLine(R.TestEmail(email));
            Console.WriteLine(R.TestMobileNumber(mobile));
            Console.WriteLine(R.TestPassword(password));
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
