using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_advanced
{
    public partial class Form1 : Form
    {

        bool cal_dot_check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Operator(string op)
        {
            if (cal_result.Text.Length == 0)
            {
                cal_alert.Text = "입력에 오류가 있습니다.";
            }
            else if (Char.IsNumber(cal_result.Text[cal_result.Text.Length - 1]))
            {
                cal_result.Text += op;
                cal_dot_check = false;
            }
            else
            {
                cal_result.Text = cal_result.Text.Substring(0, cal_result.Text.Length - 1);
                cal_result.Text += op;
                cal_dot_check = false;
            }
        }
        private void SetNum(string num)
        {
            cal_result.Text += num;
            cal_alert.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }
        private void num2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }
        private void num3_Click(object sender, EventArgs e)
        {
            SetNum("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            SetNum("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            SetNum("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            SetNum("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            SetNum("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            SetNum("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            SetNum("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            SetNum("0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cal_dot_Click(object sender, EventArgs e)
        {
            if (cal_result.Text.Length == 0)
            {
                cal_alert.Text = "입력에 오류가 있습니다.";
            }

            else if (cal_result.Text[cal_result.Text.Length - 1] == '+' ||
                cal_result.Text[cal_result.Text.Length - 1] == '-' ||
                cal_result.Text[cal_result.Text.Length - 1] == '*' ||
                cal_result.Text[cal_result.Text.Length - 1] == '/' ||
                cal_result.Text[cal_result.Text.Length - 1] == '.' ||
                cal_dot_check == true)
            {
                cal_alert.Text = "입력에 오류가 있습니다.";
            }
            else if (cal_dot_check == false)
            {
                cal_result.Text += ".";
                cal_alert.Text = null;
                cal_dot_check = true;
            }
        }

        private void cal_add_Click(object sender, EventArgs e)
        {
            Operator("+");
        }

        private void cal_sub_Click(object sender, EventArgs e)
        {
            Operator("-");
        }

        private void cal_mul_Click(object sender, EventArgs e)
        {
            Operator("*");
        }

        private void cal_div_Click(object sender, EventArgs e)
        {
            Operator("/");
        }

        private void cal_sigma_Click(object sender, EventArgs e)
        {
            Operator("Σ");
        }

        private void cal_back_Click(object sender, EventArgs e)
        {
            cal_alert.Text = null;
            if (cal_result.Text == null || cal_result.Text == "")
            {
                cal_alert.Text = "지울것이 없습니다.";
            }
            else
            {
                if (cal_result.Text[cal_result.Text.Length - 1] == '.')
                    cal_dot_check = false;
                cal_result.Text = cal_result.Text.Substring(0, cal_result.Text.Length - 1);
            }
        }

        private void cal_equal_Click(object sender, EventArgs e)
        {
            string fomular = cal_result.Text;
            double finalResult = 0;

            string[] fomularCheck = new string[100];
            Strcheck(fomularCheck, fomular);

            for (int i = 0; i < fomularCheck.Length; i++)
            {
                switch (fomularCheck[i])
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "Σ":
                        finalResult = CalculatorResult(fomularCheck, i, fomularCheck[i]);
                        fomularCheck[i - 1] = finalResult.ToString();
                        for (int j = i; j < fomularCheck.Length - 2; j++)
                            fomularCheck[j] = fomularCheck[j + 2];
                        i = 0;
                        break;
                    default:
                        break;
                }
            }
            cal_result.Text = finalResult.ToString();
        }
        private void Strcheck(string[] fomularCheck, string fomular)
        {
            int saveLocation = 0;
            int checkLocation = 0;
            string tmp = null;
            for (int i = 0; i < fomular.Length; i++)
            {
                switch (fomular[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case 'Σ':
                        for (int j = checkLocation; j < i; j++)
                        {
                            tmp += fomular[j];
                        }
                        fomularCheck[saveLocation + 1] = fomular[i].ToString();
                        if (tmp != null)
                        {
                            fomularCheck[saveLocation] = tmp;
                            saveLocation += 2;
                        }
                        else
                            saveLocation += 1;
                        checkLocation = i + 1;
                        tmp = null;
                        break;
                    default:
                        if (char.IsNumber(fomular[fomular.Length - 1]))
                        {
                            for (int j = checkLocation; j < i + 1; j++)
                            {
                                tmp += fomular[j];
                            }
                            fomularCheck[saveLocation] = tmp;
                            tmp = null;
                        }
                        break;
                }
            }
        }
        private double CalculatorResult(string[] formularCheck, int loc, string op)
        {
            double finalResult = 0;
            double num1 = double.Parse(formularCheck[loc - 1]);
            double num2 = double.Parse(formularCheck[loc + 1]);
            string result = null;
            switch (op)
            {
                case "+":
                    finalResult = num1 + num2;
                    result = finalResult.ToString();
                    return finalResult;
                case "-":
                    finalResult = num1 - num2;
                    result = finalResult.ToString();
                    return finalResult;
                case "*":
                    finalResult = num1 * num2;
                    result = finalResult.ToString();
                    return finalResult;
                case "/":
                    finalResult = num1 / num2;
                    result = finalResult.ToString();
                    return finalResult;
                case "Σ":
                    for (int i = (int)num1; i < (int)num2 + 1; i++)
                        finalResult += i;
                    result = finalResult.ToString();
                    return finalResult;

                default:
                    return finalResult;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cal_result.Clear();
            cal_alert.Text = null;
            cal_dot_check = false;
        }
    }
}
