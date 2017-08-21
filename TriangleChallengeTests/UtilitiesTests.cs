using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChallenge.Tests
{
    [TestClass()]
    public class UtilitiesTests
    {
        [TestMethod()]
        public void isNumericTest()
        {
            Assert.IsTrue(Utilities.isNumeric("10.5"),
                            "isNumeric (10.5) didn't return True");
            Assert.IsFalse(Utilities.isNumeric("Test"),
                            "isNumeric (Test) didn't return False");
            Assert.IsFalse(Utilities.isNumeric(""),
                            "isNumeric () didn't return False");
            Assert.IsFalse(Utilities.isNumeric(null),
                            "isNumeric (Null) didn't return False");
        }

        [TestMethod()]
        public void getExeptionMessageTest()
        {
            Exception exTest = new Exception("This is a Exception test",new Exception ("Inner Exception 1",new Exception ("Inner Exception 2")));
            StringBuilder testText = new StringBuilder();
            testText.AppendLine("This is a Exception test");
            testText.AppendLine("Inner Exception 1");
            testText.AppendLine("Inner Exception 2");
            Assert.AreEqual(testText.ToString(),Utilities.getExeptionMessage(exTest));
        }
    }
}