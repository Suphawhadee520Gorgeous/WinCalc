using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class frmWinClac : Form
    {
        private string number1 = "", number2 = "",answer = "";

        private void AddToDisplay(string numberSymbol)
        {
            if(this.txtDisplay.Text == "0")
            {
                //this.txtDisplay.Text = numberSymbol;

                if(numberSymbol == ".")
                {
                    this.txtDisplay.Text += numberSymbol;
                }
            }
            else
            {
                this.txtDisplay.Text += numberSymbol;
            }
        }
        public frmWinClac()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.AddToDisplay(".");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 = this.answer = "0";
            this.txtDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("7");
        }

        private void btnEighty_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("9");
        }
    }
}
