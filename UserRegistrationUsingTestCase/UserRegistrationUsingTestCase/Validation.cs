using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingTestCase
{
    public class Validation
    {
        public const string NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string ValidateFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, NAME_REGEX))
            {
                Console.WriteLine("First Name Matches");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
            return firstname;
        }
        public string ValidateLastName(string lastname)
        {
            if (Regex.IsMatch(lastname, NAME_REGEX))
            {
                Console.WriteLine("Last Name Matches");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
            return lastname;
        }
    }
}
