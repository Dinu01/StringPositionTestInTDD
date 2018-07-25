using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringPositionTestInTdd;

namespace CheckStringTest
{
    [TestClass]
    public class CheckStringTest
    {
        [TestMethod]
        public void TestTheNullValueCheck()
        {
            var checkString = new CheckStringPosition().CheckPosition("");
            Assert.IsNull(checkString);
        }
        [TestMethod]
        public void CheckFirstPosition()
        {
            var checkString = new CheckStringPosition().CheckPosition("this is string");
            Assert.AreEqual("Hi", checkString);
        }

        [TestMethod]
        public void CheckMiddlePosition()
        {
            var checkString = new CheckStringPosition().CheckPosition("is this string");
            Assert.AreEqual("test pass", checkString);
        }

        [TestMethod]
        public void CheckLastPosition()
        {
            var checkString = new CheckStringPosition().CheckPosition("string is this");
            Assert.AreEqual("Valid", checkString);
        }
    }
}
