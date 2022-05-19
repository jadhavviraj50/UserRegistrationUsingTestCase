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
    }
}