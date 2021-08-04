
using NUnit.Framework;
using System.Text.RegularExpressions;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {
        bool firstName;
        bool lastName;
        bool mobile;
        bool email;
        bool password;
        [SetUp]
        public void Setup()
        {
            RegexTest regex = new RegexTest();
            firstName = regex.TestFirstName("Milind");
            lastName = regex.TestLastName("Dhote");
            mobile = regex.TestMobileNumber("91 8719030406");
            email = regex.TestEmail("milinddhote77@gmail.com");
            password = regex.TestPassword("M@Dr77600");
        }

        [Test]
        public void GivenUserDetails_ReturnsValidationResult()
        {
            if (firstName && lastName && mobile && email && password)
                Assert.Pass("Entry SuccessFull");
            else
                Assert.Fail("Entry Failed");
        }
    }
}
   