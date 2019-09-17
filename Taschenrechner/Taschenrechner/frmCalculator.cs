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

        #endregion

        private void tbxCalcString_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private bool CheckCalcArray(string[] arr)
        {
            //wenn nicht alle elemente zahlen der operatoren sind, wird false zurück gegeben
            if (!arr.Any(x => IsNumber(x) || IsOperator(x)))
                return false;

            List<string> l = new List<string>(arr);

            //doppelte Minus und plus Entfernen oder austauschen
            for(int i = 0; i < l.Count; i++)
            {
                if(l[i] == "-")
                {
                    if (i < l.Count - 1)
                    {
                        if(l[i+1] == "-")
                        {
                            if (IsOperator(l[i - 1]))
                            {
                                l.RemoveAt(i);
                                l.RemoveAt(i);
                            }
                            else
                            {
                                l.RemoveAt(i);
                                l[i] = "+";
                            }
                        }
                    }
                }

                if(l[i] == "+" && i > 0)
                {
                    if (IsOperator(l[i - 1]))
                    {
                        l.RemoveAt(i);
                    }

                }
            }

            if(l.First() == "-")
            {
                l.RemoveAt(0);
                l[0] = "-" + l[0];
            }

            if (IsOperator(l.Last()))
                return false;

            //wenn nicht alle elemente zahlen der operatoren sind, wird false zurück gegeben
            if (!arr.Any(x => IsNumber(x) || IsOperator(x)))
                return false;

            for (int i = 1; i < l.Count; i++)
            {
                if (IsOperator(l[i - 1]))
                {
                    if (IsOperator(l[i]))
                    {

                    }
                }
            }
        }

        private bool IsOperator(string s)
        {
            string[] ops = new string[] { "+", "-", "*", "/" };
            return ops.Contains(s);
        }

        private bool IsNumber(string s)
        {
            return double.TryParse(s, out double d);
        }
    }

}
