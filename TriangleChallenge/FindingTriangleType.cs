using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleChallenge
{
    public partial class findingTriangleType : Form
    {
        public findingTriangleType()
        {
            InitializeComponent();
        }

        //Inputs validating
        #region Validation Region
        private void fSideInp_Validating(object sender, CancelEventArgs e)
        {
            ValidationManagment.inputsValidator(fSideInp, toolTipError, resultTxtBox);
        }
        private void sSideInp_Validating(object sender, CancelEventArgs e)
        {
            ValidationManagment.inputsValidator(sSideInp, toolTipError, resultTxtBox);
        }
        private void tSideInp_Validating(object sender, CancelEventArgs e)
        {
            ValidationManagment.inputsValidator(tSideInp, toolTipError, resultTxtBox);
        }
        #endregion

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fSideInp.Text = string.Empty;
            sSideInp.Text = string.Empty;
            tSideInp.Text = string.Empty;
            resultTxtBox.Text = string.Empty;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidationManagment.inputsValidator(fSideInp, toolTipError, resultTxtBox) ||
                    !ValidationManagment.inputsValidator(sSideInp, toolTipError, resultTxtBox) ||
                    !ValidationManagment.inputsValidator(tSideInp, toolTipError, resultTxtBox))
                    return;

                decimal[] inputs = new decimal[]
                   {
                    decimal.Parse(fSideInp.Text),
                    decimal.Parse(sSideInp.Text),
                    decimal.Parse(tSideInp.Text)
                   };

                InputControl newInp = new InputControl();
                TypeControl newType = new TypeControl();
                Result outPut = new Result();

                //Controlling the lengths and showing results:
                if (newInp.triangleControl(inputs))
                {
                    outPut.showResult(newType.triangleType(inputs).ToString(), true, resultTxtBox);
                }
                else
                {
                    outPut.showResult("", false, resultTxtBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilities.getExeptionMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

