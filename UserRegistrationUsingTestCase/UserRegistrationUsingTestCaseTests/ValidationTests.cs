
using UserRegistrationUsingTestCase;
using NUnit.Framework;
using System.Net.Mail;



namespace UserRegistrationUsingTestCase.Tests
{
    
    public class ValidationTests
    {
        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string expected = validation.ValidateFirstName("Viraj");
            Assert.AreEqual(expected, "Viraj");
        }

        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Jadhav");
            Assert.AreEqual(actual, "Jadhav");
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("viraj.jad@BL.co.in");
            Assert.AreEqual(actual, "viraj.jad@BL.co.in");
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 9195273264");
            Assert.AreEqual(actual, "+91 9195273264");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("VirajJad");
            Assert.AreEqual(actual, "VirajJad");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword2()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword1("Virajjad");
            Assert.AreEqual(actual, "Virajjad");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword3()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword2("Virajjad1");
            Assert.AreEqual(actual, "Virajjad1");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword4()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword3("Virajjad1$");
            Assert.AreEqual(actual, "Virajjad1$");
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail1()
        {
            Validation validation = new Validation();
            string actual = validation.EmailSample("jadhavviraj0@gmail.com");
            Assert.AreEqual(actual, "jadhavviraj0@gmail.com");
        }

        [Test]
        [TestCase("Viraj@gmail.com")]
        [TestCase("Viraj+jadhav@welcome.com")]
        [TestCase("virajJadhav@gmail.com.in")]
        [TestCase("Viraj+123@welcome.com")]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmailParamerizedTest(string mailAddress)
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmailParametrized(mailAddress);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(actual, mailAddress);

        }

    }
}