using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingTestCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingTestCase.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string expected = validation.ValidateFirstName("Viraj");
            Assert.AreEqual(expected, "Viraj");
        }

        [TestMethod()]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Jadhav");
            Assert.AreEqual(actual, "Jadhav");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("viraj.jad@BL.co.in");
            Assert.AreEqual(actual, "viraj.jad@BL.co.in");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 9195273264");
            Assert.AreEqual(actual, "+91 9195273264");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("VirajJad");
            Assert.AreEqual(actual, "VirajJad");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword2()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword1("Virajjad");
            Assert.AreEqual(actual, "Virajjad");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword3()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword2("Virajjad1");
            Assert.AreEqual(actual, "Virajjad1");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword4()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword3("Virajjad1$");
            Assert.AreEqual(actual, "Virajjad1$");
        }
        [TestMethod()]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail1()
        {
            Validation validation = new Validation();
            string actual = validation.EmailSample("jadhavviraj0@gmail.com");
            Assert.AreEqual(actual, "jadhavviraj0@gmail.com");
        }
    }
}