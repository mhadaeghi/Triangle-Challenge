using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleChallenge.Tests
{
    [TestClass()]
    public class ValidationManagmentTests
    {
        [TestMethod()]
        public void inputsValidatorTest()
        {
            TextBox gSideInp = new TextBox();
            TextBox outTxtBox = new TextBox();
            ToolTip tTpError = new ToolTip();
            gSideInp.Text = "11.5";
            Assert.IsTrue (ValidationManagment.inputsValidator(gSideInp, tTpError, outTxtBox),
                "triangleControl '11.5' didn't return True");
            gSideInp.Text = "test";
            Assert.IsFalse  (ValidationManagment.inputsValidator(gSideInp, tTpError, outTxtBox),
                "triangleControl 'Test' didn't return False");
            gSideInp.Text = string.Empty;
            Assert.IsFalse(ValidationManagment.inputsValidator(gSideInp, tTpError, outTxtBox),
                "triangleControl ' ' didn't return False");
            gSideInp.Text = null;
            Assert.IsFalse(ValidationManagment.inputsValidator(gSideInp, tTpError, outTxtBox),
                "triangleControl 'Null' didn't return False");
        }
    }
}