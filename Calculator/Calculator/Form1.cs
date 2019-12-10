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
        public Form1()
        {
            InitializeComponent();
        }

        private bool numClicked = false;        //czy rozpoczęto wprowadzanie liczby 
        private bool actClicked = false;

        private string action = null;
        private double temp;
        


        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button;

            button = sender as Button; 

            if(numClicked == true)
            {
                textBox1.Text += button.Text;
            }
            else
            {
                textBox1.Text = button.Text;
                numClicked = true;
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
            numClicked = false;
            action = null;
            actClicked = false;
        }

        private void ActionButtonClick(object sender, EventArgs e)
        {
            Button button;

            button = sender as Button;

            numClicked = false;

            if(actClicked == true)
            {
                Action();
            }
            else
            {
                actClicked = true;

                temp = Convert.ToDouble(textBox1.Text);

                action = button.Text;

            }

            
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {

            Action();

            actClicked = false;
            textBox1.Text = Convert.ToString(temp);
            
            
        } 
        private void Action()
        {
            switch (action)
            {
                case "+":
                    temp = temp + Convert.ToDouble(textBox1.Text);
                    break;
                case "-":
                    temp = temp - Convert.ToDouble(textBox1.Text);
                    break;
                case "*":
                    temp = temp * Convert.ToDouble(textBox1.Text);
                    break;
                case "/":
                    temp = temp / Convert.ToDouble(textBox1.Text);
                    break;
            }
        }
    }
}
