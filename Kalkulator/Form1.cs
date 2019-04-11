using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double Value = 0;
        string Operation = "";
        bool Operation_Pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0")||Operation_Pressed)
                Result.Clear();
            Operation_Pressed = false;
            Button b = (Button)sender;

                if (b.Text == ",")
                {
                    if (!Result.Text.Contains(","))
                        Result.Text = Result.Text + b.Text;
                }
                else
                    Result.Text = Result.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Value != 0)
            {
                equal.PerformClick();
                Operation_Pressed = true;
                Operation = b.Text;
                equation.Text = Value + " " + Operation;
            }
            else
            {
                Operation = b.Text;
                Value = Double.Parse(Result.Text);
                Operation_Pressed = true;
                equation.Text = Value + " " + Operation;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(Operation)
            {
                case "+":
                    {
                        Result.Text = (Value + Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        Result.Text = (Value - Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        Result.Text = (Value * Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        Result.Text = (Value / Double.Parse(Result.Text)).ToString();
                        break;
                    }
                default: break;
            }
            Value = Double.Parse(Result.Text);
            Operation = "";
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            Value = 0;
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
