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

            // Creating object
            RegexTest R = new RegexTest();
            Console.WriteLine(R.TestFirstName(firstName));
        }
    }
}
