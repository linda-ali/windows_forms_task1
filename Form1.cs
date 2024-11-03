using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x = 0;
        string operation = "";
        bool operationPerformed = false;

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = x .ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            x=Double.Parse(textBox1.Text);
            textBox1.Text=x.ToString(); 
        }

        private void Mp_Click(object sender, EventArgs e)
        {
            x += Double.Parse(textBox1.Text);
            textBox1.Text=x.ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void numberbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((textBox1.Text == "0") || (operationPerformed))
                textBox1.Clear();
            
            operationPerformed = false; 
            textBox1.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            x = Double.Parse(textBox1.Text);
            operation = button.Text;
            operationPerformed = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (x + Double.Parse(textBox1.Text)).ToString(); 
                    break;
                case "-":
                    textBox1.Text = (x - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (x * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (x / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            
            x = Double.Parse(textBox1.Text);
            operation = "";
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            x = Math.Sqrt(n);
            textBox1.Text = x.ToString();
        }

        private void percent_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            x = n / 100;
            textBox1.Text = x.ToString();
        }
    }
}
