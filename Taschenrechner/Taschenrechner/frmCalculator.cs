using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
           tbxCalcString.Focus();
        }

        #region Number and Operand Buttons
        private void btnZero_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "9";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += ".";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text = "";
            tbxSolution.Text = "";
        }

        #endregion

        private void tbxCalcString_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
