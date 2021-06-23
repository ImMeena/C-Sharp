using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    // main form
    public partial class Calculator : Form
    {
        double num1;
        string op;
        public Calculator()
        {           
            InitializeComponent();
        }
        // first button click operation 
               
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // second button click operation 
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        //  button 3 click operation 
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        //  button 4 click operation 
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        //  button 5 click operation 
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        //  button 6 click operation 
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        //  button 7 click operation 
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        //  button 8 click operation 
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        //  button 9 click operation 
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        //  button 10 click operation value is 0 
        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        // when button is clicked it will clear the text box value and save the
        // entered value in num1 and save the + operator in variabe op
        private void button11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "+";
        }
        // when button is clicked it will clear the text box value and save the
        // entered value in num1 and save the - operator in variabe op
        private void bsub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "-";

        }
        // when button is clicked it will clear the text box value and save the
        // entered value in num1 and save the * operator in variabe op
        private void bmult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "*";
        }
        // when button is clicked it will clear the text box value and save the
        // entered value in num1 and save the / operator in variabe op
        private void bdiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
        }
        // it will clear the value of text box
        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        // to add dot in number to make it decimal
        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        // operation performed when = (equal) button is clicked
        private void beq_Click(object sender, EventArgs e)
        {
            double num2= Convert.ToDouble(textBox1.Text);
            double res;
            if(op == "+")
            {
                res = num1 + num2;
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            else if(op == "-")
            {
                res = num1 - num2;
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            else if(op == "*")
            {
                res = num1 * num2;
                textBox1.Text = Convert.ToString(res);
                num1 = res;
            }
            else if(op == "/")
            {
                res = num1 / num2;
                textBox1.Text = Convert.ToString(res);
                num1 = res;

            }           

        }
    }
}
