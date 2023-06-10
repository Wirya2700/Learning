using Microsoft.VisualStudio.TestTools.UnitTesting;
using Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Tests
{
    [TestClass()]
    public class RegularExpressionTests
    {
        [TestMethod()]
        public void IsEmailTest_ValidEmail()
        {
            string email = "test1@gmail.com";

            var result = RegularExpression.IsEmail(email);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsEmailTest_InvalidEmail()
        {
            string email = "test1gmail.com";

            var result = RegularExpression.IsEmail(email);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsPhoneTest_ValidNumber()
        {
            string phoneNumber = "+62 (123) 456-7890";

            var result = RegularExpression.IsPhone(phoneNumber);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPhoneTest_InvalidNumber()
        {
            string phoneNumber = "+621 (123) 456-789012";

            var result = RegularExpression.IsPhone(phoneNumber);

            Assert.IsFalse(result);
        }
    }
}