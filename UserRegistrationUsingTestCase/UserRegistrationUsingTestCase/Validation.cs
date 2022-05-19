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
        public static string EMAIL_REGEX = "^[a-z]+(.[a-z])+@[A-Za-z]+.[a-z]{2,3}(.[a-z]{2})?$";
        public static string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string PASSWORD_REGEX = "^[a-zA-z]{8,}$";
        public static string PASSWORD_REGEX1 = "^[A-Z]{1}[a-z]{7,}$";
        public static string PASSWORD_REGEX2 = "^(?=.*[0-9A-Z])[0-9a-zA-z]{8,}$";
        public static string PASSWORD_REGEX3 = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
        public static string EMAIL_REGEX1 = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

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
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX))
            {
                Console.WriteLine("Email Matches");
            }
            else
            {
                Console.WriteLine("Verify Email Again");
            }
            return email;
        }
        public string ValidateMobileNumber(string mobilenumber)
        {
            if (Regex.IsMatch(mobilenumber, MOBILENUMBER_REGEX))
            {
                Console.WriteLine("Mobile Number Matches.");
            }
            else
            {
                Console.WriteLine("Verify Mobile Number Again.");
            }
            return mobilenumber;
        }
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
        public string ValidatePassword1(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX1))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
        public string ValidatePassword2(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX2))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
        public string ValidatePassword3(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX3))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
        public string EmailSample(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX1))
            {
                Console.WriteLine("Email Matches");
            }
            else
            {
                Console.WriteLine("Verify Email Again");
            }
            return email;
        }
    }
}
