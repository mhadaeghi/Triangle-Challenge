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
    public class TypeControlTests
    {
        [TestMethod()]
        public void triangleTypeTest()
        {
            TypeControl type = new TypeControl();
            decimal[] test = { 10.5m, 10.5m, 10.5m };
            Assert.AreEqual(triType.Equilateral, type.triangleType(test),
                            "triangleType(10.5, 10.5, 10.5) didn't return Equilateral");
            test = new [] { 15.5m, 10.5m, 10.5m };
            Assert.AreEqual(triType.Isosceles, type.triangleType(test),
                            "triangleType(15.5, 10.5, 10.5) didn't return Isosceles");
            test = new[] { 10.5m, 15.5m, 20 };
            Assert.AreEqual(triType.Scalene, type.triangleType(test),
                            "triangleType(10.5, 15.5, 20) didn't return Scalene");
        }
    }
}