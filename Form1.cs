using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void adBt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(enterArea.Text);
            enterArea.Text = "";
            Operation = "+";
        }

        private void subBt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(enterArea.Text);
            enterArea.Text = "";
            Operation = "-";
        }

        private void mulBt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(enterArea.Text);
            enterArea.Text = "";
            Operation = "*";
        }

        private void devBt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(enterArea.Text);
            enterArea.Text = "";
            Operation = "/";
        }

        private void eqBt_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(enterArea.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                enterArea.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                enterArea.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                enterArea.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    enterArea.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    enterArea.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            enterArea.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "0";
            }
            else
            {
                enterArea.Text = enterArea.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "1";
            }
            else
            {
                enterArea.Text = enterArea.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "2";
            }
            else
            {
                enterArea.Text = enterArea.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "3";
            }
            else
            {
                enterArea.Text = enterArea.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "4";
            }
            else
            {
                enterArea.Text = enterArea.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "5";
            }
            else
            {
                enterArea.Text = enterArea.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "6";
            }
            else
            {
                enterArea.Text = enterArea.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "7";
            }
            else
            {
                enterArea.Text = enterArea.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "8";
            }
            else
            {
                enterArea.Text = enterArea.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (enterArea.Text == "0" && enterArea.Text != null)
            {
                enterArea.Text = "9";
            }
            else
            {
                enterArea.Text = enterArea.Text + "9";
            }
        }

        private void dotBt_Click(object sender, EventArgs e)
        {
            enterArea.Text = enterArea.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterArea.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BloddyRose");
        }
    }
}
