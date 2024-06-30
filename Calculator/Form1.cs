using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char action;
        public Form1()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '1';
            else
                textBox.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '2';
            else
                textBox.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '3';
            else
                textBox.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '6';
            else
                textBox.Text = "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '5';
            else
                textBox.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '4';
            else
                textBox.Text = "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '9';
            else
                textBox.Text = "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '8';
            else
                textBox.Text = "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
                textBox.Text = textBox.Text + '7';
            else
                textBox.Text = "7";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "0")
                textBox.Text = textBox.Text + '0';
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                textAddon.Text = textBox.Text + "+";
                textBox.Text = "";
                action = '+';
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                textAddon.Text = textBox.Text + "-";
                textBox.Text = "";
                action = '-';
            }
            else if (textBox.Text == "-")
                textBox.Text = "";
            else
                textBox.Text = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                textAddon.Text = textBox.Text + "*";
                textBox.Text = "";
                action = '*';
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                textAddon.Text = textBox.Text + "/";
                textBox.Text = "";
                action = '/';
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
                textBox.Text = textBox.Text + ',';
        }

        private void buttonAbsolute_Click(object sender, EventArgs e)
        {
            textBox.Text = System.Convert.ToString(Math.Abs(System.Convert.ToDouble(textBox.Text)));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = ""; textAddon.Text = "";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != "-")
            {
                textAddon.Text = textBox.Text + "^";
                textBox.Text = "";
                action = '^';
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (textBox.Text[0] != '-')
                textBox.Text = System.Convert.ToString(Math.Sqrt(System.Convert.ToDouble(textBox.Text)));
            else
                MessageBox.Show("Can't take the root from negative");
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string firstText = textAddon.Text;
            firstText = (firstText.Remove(firstText.Length - 1));
            double firstOperand = System.Convert.ToDouble(firstText);

            string secondText = textBox.Text;
            double secondOperand = System.Convert.ToDouble(secondText);
            switch (action)
            {
                case '+':
                    textBox.Text = System.Convert.ToString(firstOperand + secondOperand);
                    break;
                case '-':
                    textBox.Text = System.Convert.ToString(firstOperand - secondOperand);
                    break;
                case '/':
                    if (secondOperand == 0)
                    {
                        MessageBox.Show("Can't divide by zero");
                        break;
                    }
                    else
                    {
                        textBox.Text = System.Convert.ToString(firstOperand / secondOperand);
                        break;
                    }
                case '*':
                    textBox.Text = System.Convert.ToString(firstOperand * secondOperand);
                    break;
                case '^':
                    textBox.Text = System.Convert.ToString(Math.Pow(firstOperand,secondOperand));
                    break;

            }
            action = ' ';
            textAddon.Text = "";
        }
    }
}
