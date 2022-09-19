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

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            float result_Float = 0.0F;

            result_Float = float.Parse(num1) + float.Parse(num2);

            string result = "";

            result = result_Float.ToString();
            if (result.Contains(".") == true && int.Parse(result.Split('.')[1]) == 0)
                label3.Text = result.Split('.')[0].ToString();
            else
                label3.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            double result_double = 0.0;

            result_double = Math.Round(double.Parse(num1) - double.Parse(num2), 10);

            string result = "";

            result = result_double.ToString();
            if (result.Contains(".") == true && int.Parse(result.Split('.')[1]) == 0)
                label3.Text = result.Split('.')[0].ToString();
            else
                label3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            float result_Float = 0.0F;

            result_Float = float.Parse(num1) * float.Parse(num2);

            string result = "";

            result = result_Float.ToString();
            if (result.Contains(".") == true && int.Parse(result.Split('.')[1]) == 0)
                label3.Text = result.Split('.')[0].ToString();
            else
                label3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            double result_double = 0.0;

            result_double = double.Parse(num1) / double.Parse(num2);

            label3.Text = result_double.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            double result_double = 0.0;

            result_double = double.Parse(num1) % double.Parse(num2);

            label3.Text = result_double.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;

            if (double.Parse(num1) > double.Parse(num2))
                label3.Text = num1 + "이 (가)크다.";
            else if (double.Parse(num1) < double.Parse(num2))
                label3.Text = num2 + "이 (가)크다.";
            else
                label3.Text = num1 + "와" + num2 + "는 (은)같다.";

        }
    }
}
