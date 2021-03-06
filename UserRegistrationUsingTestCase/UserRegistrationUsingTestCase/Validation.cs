using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingTestCase

{   
    /*
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

        public string ValidateEmailParametrized(string email)
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
    


     //UC12- Refactor the code to throw custom exception in case of invalid user details

    public class Validation
    {                                                                                                       
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string PASSWORD_REGEX = "^[#@%!]{1}+[a-zA-z0-9]{8,}$";
        private string message;

        public Validation(string message)
        {
            this.message = message;
        }
        public bool ValidateFirstName(string firstname)
        {
            try
            {
                if (FIRSTNAME_REGEX != firstname)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_FIRSTNAME, "First Name Is Invalid");
                }
                return Regex.IsMatch(firstname, FIRSTNAME_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "First Name Is Invalid";
            }
        }
        public bool ValidateLastName(string lastname)
        {
            try
            {
                if (LASTNAME_REGEX != lastname)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_LASTNAME, "Last Name Is Invalid");
                }
                return Regex.IsMatch(lastname, LASTNAME_REGEX);
            }
            catch(ExceptionUserRegistration ex)
            {
                return ex.Message == "Last Name Is Invalid";
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (EMAIL_REGEX != email)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
                }
                return Regex.IsMatch(email, EMAIL_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Email Is Invalid";
            }
        }
        public bool ValidateMobileNumber(string mobilenumber)
        {
            try
            {
                if (MOBILENUMBER_REGEX != mobilenumber)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_MOBILENUMBER, "Mobile Number Is Invalid");
                }
                return Regex.IsMatch(mobilenumber, MOBILENUMBER_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Mobile Number Is Invalid";
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (PASSWORD_REGEX != password)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_PASSWORD, "Passowrd Is Invalid");
                }
                return Regex.IsMatch(password, PASSWORD_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Password Is Invalid";
            }
        }
        public bool ValidateEmailParametrized(string email)
        {
            try
            {
                if (EMAIL_REGEX != email)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
                }
                return Regex.IsMatch(email, EMAIL_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Email Is Invalid";
            }
        }
    }
    */

    //UC13- Refactor the code to use lambda function to validate user entry
    public class Validation
    
    {                                                                                                       
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string PASSWORD_REGEX = "^[#@%!]{1}+[a-zA-z0-9]{8,}$";
        private string message;

        public Validation(string message)
        {
            this.message = message;
        }
        public bool ValidateFirstName(string firstname) => Regex.IsMatch(firstname, FIRSTNAME_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_FIRSTNAME, "First Name Is Invalid");
        public bool ValidateLastName(string lastname) => Regex.IsMatch(lastname, LASTNAME_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_LASTNAME, "Last Name Is Invalid");
        public bool ValidateEmail(string email) => Regex.IsMatch(email, EMAIL_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
        public bool ValidateMobileNumber(string mobileNumber) => Regex.IsMatch(mobileNumber, MOBILENUMBER_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_MOBILENUMBER, "Mobile Number Is Invalid");
        public bool ValidatePassword(string password) => Regex.IsMatch(password, PASSWORD_REGEX) ? true : throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_PASSWORD, "Password Is Invalid");

    }
}


