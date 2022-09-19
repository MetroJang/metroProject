using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventform
{
    public partial class Form1 : Form
    {
        class Box
        {
            private int width;

            public int Width
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해 주세요"); }
                }
            }

            private int height;

            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해 주세요"); }
                }
            }
            public Box(int width,int height)
            {
                Width = width;
                Height = height;
            }

            public int Area() { return this.width * this.height; }
        }

        public Form1()
        {
            InitializeComponent();

            myButton.Text = "코드에서 변경!";
            myButton.Width = 100;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(13, 13 + (23 + 3) * i);
                button.Text = "동적생성" + i + "번째";
                button.Width = 100;
            }

            List<Box> box = new List<Box>();
            box.Add(new Box(10, 10));
            box.Add(new Box(10, 500));
            box.Add(new Box(10, 400));
            box.Add(new Box(30, 10));
            box.Add(new Box(10, 10));
            box.Add(new Box(10, 500));
            box.Add(new Box(10, 400));
            box.Add(new Box(30, 10));

            foreach(var item in box)
            {
                int hNum = item.Height;
                int wNum = item.Width;
                string result = wNum.ToString() + " " + hNum.ToString() + "\r\n";

                textBox2.Text += result;
            }

            button1.Click += Button1_Click;
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Button1_Click(object sender,EventArgs e)
        {
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다!";
            textBox1.Text += "+";
            label1.Text += "+";
        }

        private int elapsedTime = 0;

        private void timer1_Tick(object sender,EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            label1.Text = elapsedTime + "초 경과";
        }
    }
}
