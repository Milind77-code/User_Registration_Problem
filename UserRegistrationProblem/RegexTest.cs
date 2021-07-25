using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    class RegexTest
    {
        public string firstName = "^[A-Z]{1}[a-zA-z]{2,}";
        public string lastName = "^[A-Z]{1}[a-zA-z]{2,10}";


        /// <summary>
        /// Method to test First Name
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool TestFirstName(string fName)
        {
            Console.Write("First Name is Valid (True/False) :- ");
            return Regex.IsMatch(fName, firstName);
        }
        /// <summary>
        /// Method to test Last Name
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public bool TestLastName(string lName)
        {
            Console.Write("Last Name is Valid (True/False) :- ");
            return Regex.IsMatch(lName, lastName);
        }
    }
}
