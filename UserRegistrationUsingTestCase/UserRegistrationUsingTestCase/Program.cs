// See https://aka.ms/new-console-template for more information
using UserRegistrationUsingTestCase;

Console.WriteLine("Welcome To User Registration Problem Using Test Case");

Validation valid = new Validation();
string result = valid.ValidateFirstName("Viraj");
Console.WriteLine(result);

Validation valid1 = new Validation();
string result1 = valid1.ValidateLastName("Jadhav");
Console.WriteLine(result1);

Validation valid2 = new Validation();
string result2 = valid2.ValidateEmail("viraj.jad@BL.co.in");
Console.WriteLine(result2);

Validation valid3 = new Validation();
string result3 = valid3.ValidateMobileNumber("+91 9195273264");
Console.WriteLine(result3);

Validation valid4 = new Validation();
string result4 = valid4.ValidatePassword("virajjad");
Console.WriteLine(result4);

Validation valid5 = new Validation();
string result5 = valid5.ValidatePassword1("Virajjad");
Console.WriteLine(result5);

Validation valid6 = new Validation();
string result6 = valid6.ValidatePassword2("Virajjad1");
Console.WriteLine(result6);

Validation valid7 = new Validation();
string result7 = valid7.ValidatePassword3("Virajjad1$");
Console.WriteLine(result7);
