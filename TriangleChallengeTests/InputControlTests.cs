using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TriangleChallenge.Tests
{
    [TestClass()]
    public class InputControlTests
    {
        [TestMethod()]
        public void triangleControlTest()
        {
            InputControl inp = new InputControl();
            decimal[] triConTest = {10.5m,11.5m,12.5m};
            Assert.IsTrue (inp.triangleControl(triConTest),
                "triangleControl {10.5,11.5,12.5} didn't return True");
            triConTest = new decimal [] { 10.5m, 11, 21.5m };
            Assert.IsFalse(inp.triangleControl(triConTest),
                "triangleControl {10.5,11,21.5} didn't return False");
            triConTest = new decimal[] { 10.5m, 11, 21.5m };
            Assert.IsFalse(inp.triangleControl(triConTest),
                "triangleControl {10.5,11.5,23} didn't return False");
        }
    }
}