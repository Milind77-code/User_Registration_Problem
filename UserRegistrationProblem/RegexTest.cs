using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    class RegexTest
    {
        public string firstName = "^[A-Z]{1}[a-zA-z]{2,}";

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
    }
}
