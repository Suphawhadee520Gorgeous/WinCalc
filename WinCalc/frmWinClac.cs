using System;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class frmWinClac : Form
    {
        private string number1 = "", number2 = "", answer = "";
        private bool dotStatus = false;
        private char symbol = '0';

        private void AddToDisplay(string numberSymbol)
        {
            if (numberSymbol == ".")
                this.dotStatus = true;

            if (this.txtDisplay.Text == "0" && numberSymbol == ".")
            {
                this.txtDisplay.Text += numberSymbol;
            }
            else if (this.txtDisplay.Text == "0")
            {
                this.txtDisplay.Text = numberSymbol;
            }
            else if(this.txtDisplay.Text != "0")
            {
                this.txtDisplay.Text += numberSymbol;
            }
           
        }

        private string calculating(string num1, string num2, char _symbol)
        {
            double numFirst = double.Parse(num1);
            double numSecond = double.Parse(num2);
            double numAnswer = 0.0f;

            switch (_symbol) 
            {
            case '+': numAnswer = numFirst + numSecond; break;
            case '-': numAnswer = numFirst - numSecond; break;
            case '*': numAnswer = numFirst * numSecond; break;
            case '/': numAnswer = numFirst / numSecond; break;
            }
            return numAnswer.ToString();
        }

        private void setNumber1(char _symbol)
        {
            this.symbol = _symbol;
            this.number1 = this.txtDisplay.Text;
            this.txtDisplay.Text = "0";
            this.dotStatus = false;
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
            if (this.dotStatus)
                this.AddToDisplay(".");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.number2 = this.txtDisplay.Text;
            this.txtDisplay.Text =
            this.calculating(this.number1, number2, this.symbol);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.setNumber1('/');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.setNumber1('*');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.setNumber1('-');
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.setNumber1('+');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 = this.answer = "0";
            this.txtDisplay.Text = "0";
            this.symbol = '0';
            this.dotStatus  = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.txtDisplay.Text.Length > 0)
                this.txtDisplay.Text =
                    this.txtDisplay.Text.Remove(this.txtDisplay.Text.Length - 1);

            if ((this.txtDisplay.Text.Length == 0) || (this.txtDisplay.Text == ""))
            this.txtDisplay.Text += "0";

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

        private void mnuClearItem_Click(object sender, EventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout objAbout = new frmAbout();
            objAbout.ShowDialog();
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
