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
    }
}