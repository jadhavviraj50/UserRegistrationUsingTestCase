﻿// See https://aka.ms/new-console-template for more information
using UserRegistrationUsingTestCase;

Console.WriteLine("Welcome To User Registration Problem Using Test Case");

Validation valid = new Validation();
string result = valid.ValidateFirstName("Viraj");
Console.WriteLine(result);

Validation valid1 = new Validation();
string result1 = valid1.ValidateLastName("Jadhav");
Console.WriteLine(result1);
