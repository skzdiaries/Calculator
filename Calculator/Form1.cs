using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        string num1 = "";
        string num2 = "";
        char function;
        double answer = 0.0;
        string userinput = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn2_Click(object sender, EventArgs e)
        {
            
            lblCalcDisplay.Text = ""; // erases input
            userinput += "2";
            lblCalcDisplay.Text += userinput;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            function = '+';
            num1 = userinput;
            userinput = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            function = '*';
            num1 = userinput;
            userinput = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            num1 = userinput;
            userinput = "";


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
            num1 = userinput;
            userinput = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = userinput;
            double firstNum, secondNum;
            bool isNum1Valid = double.TryParse(num1, out firstNum);
            bool isNum2Valid = double.TryParse(num2, out secondNum);
            //firstNum = Convert.ToDouble(num1);
            //secondNum = Convert.ToDouble(num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                lblCalcDisplay.Text = "Error!";
                userinput = "";
                num1 = "";
                return;
            }
            if (function == '+') // plus
            {
                answer = firstNum + secondNum;
                lblCalcDisplay.Text = answer.ToString();
            }
            else if (function == '-') // subtract
            {
                answer = firstNum - secondNum;
                lblCalcDisplay.Text = answer.ToString();
            }
            else if (function == '*') // multiply
            {
                answer = firstNum * secondNum;
                lblCalcDisplay.Text = answer.ToString();
            }
            else if (function == '/') // divide
            {

                if (secondNum == '0')
                {
                    lblCalcDisplay.Text = "Undefined";
                }
                else
                {
                    answer = firstNum / secondNum;
                    lblCalcDisplay.Text = answer.ToString();
                }
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += ".";
            lblCalcDisplay.Text += userinput;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            
            num1 = "";
            num2 = "";
            userinput = "";
            answer = 0.0;
            lblCalcDisplay.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "1";
            lblCalcDisplay.Text += userinput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "3";
            lblCalcDisplay.Text += userinput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "4";
            lblCalcDisplay.Text += userinput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "5";
            lblCalcDisplay.Text += userinput;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "6";
            lblCalcDisplay.Text += userinput;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "7";
            lblCalcDisplay.Text += userinput;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "8";
            lblCalcDisplay.Text += userinput;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "9";
            lblCalcDisplay.Text += userinput;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblCalcDisplay.Text = ""; // erases input
            userinput += "0";
            lblCalcDisplay.Text += userinput;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
