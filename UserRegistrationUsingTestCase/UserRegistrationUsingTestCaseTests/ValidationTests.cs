
using UserRegistrationUsingTestCase;
using NUnit.Framework;
using System.Net.Mail;



namespace UserRegistrationUsingTestCase
{
    
    public class ValidationTests
    {
        /*
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

        */

        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            try
            {
                Validation validation = new Validation("INVALID_FIRSTNAME");
                bool firstName = validation.ValidateFirstName("Viraj");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "First Name Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            try
            {
                Validation validation = new Validation("INVALID_LASTNAME");
                bool lastName = validation.ValidateFirstName("Jadhav");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Last Name Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            try
            {
                Validation validation = new Validation("INVALID_EMAIL");
                bool email1 = validation.ValidateEmail("viraj.jadhav0@gmail.co.in");
                bool email2 = validation.ValidateEmail("abc@yahoo.com");
                bool email3 = validation.ValidateEmail("abc-100@yahoo.com");
                bool email4 = validation.ValidateEmail("abc.100@yahoo.com");
                bool email5 = validation.ValidateEmail("abc111@abc.com");
                bool email6 = validation.ValidateEmail("abc-100@abc.net");
                bool email7 = validation.ValidateEmail("abc.100@abc.com.au");
                bool email8 = validation.ValidateEmail("abc@1.com");
                bool email9 = validation.ValidateEmail("abc@gmail.com.com");
                bool email10 = validation.ValidateEmail("abc+100@gmail.com");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Email Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            try
            {
                Validation validation = new Validation("INVALID_MOBILENUMBER");
                bool mobileNumber = validation.ValidateMobileNumber("9195273264");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Mobile Number Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            try
            {
                Validation validation = new Validation("INVALID_PASSWORD");
                bool password = validation.ValidatePassword("VirajJa2@");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Password Is Invalid");
            }
        }
        [Test]
        [TestCase("Hello@welcome.com")]
        [TestCase("Hello+plus@welcome.com")]
        [TestCase("VirajJadhav@gmail.com.in")]
        [TestCase("Hello+123@welcome.com")]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmailParamerizedTest(string mailAddress)
        {
            try
            {
                Validation validation = new Validation("INVALID_EMAIL");
                bool password = validation.ValidatePassword("mailAddress");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Email Is Invalid");
            }

        }

    }
}