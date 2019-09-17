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

        }
        //Buttons
        #region Number and Operand Buttons

            //Number Buttons

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

            //Operand Buttons

        private void btnComma_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += ",";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text = "";
            tbxSolution.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "*";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            tbxCalcString.Text += "-";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            splitCalcString(tbxCalcString.Text);
        }
        #endregion


        private string[] splitCalcString(string calcString)
        {
            string[] calcArray = calcString.Split('+', '*', '-', '/');
            //Debug
            string debug = "";
            for(int i=0;i < calcString.Length;i++)
            {
                debug += calcString[i];
                debug += "|";
            }
            MessageBox.Show(debug);
            return calcArray;
        }

        private void tbxCalcString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                splitCalcString(tbxCalcString.Text);
            }
        }
    }

}
