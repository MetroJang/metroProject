using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _10Jucha_guaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           using(FileStream fs=new FileStream("../../Binary.bin",FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, tbText.Text);
                MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("../../Binary.bin", FileMode.Open))
            {
                tbText.Text = "";
                string result;

                BinaryFormatter bf = new BinaryFormatter();
                result = (string)bf.Deserialize(fs);
                tbText.Text = result;
                MessageBox.Show("바이너리를 모두 읽어왔습니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName.Contains(".txt"))
            {
                using(StreamWriter sw=new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(tbText.Text);
                }
            }
            else if(saveFileDialog.FileName.Contains(".bin"))
            {
                using(FileStream fs=new FileStream(saveFileDialog.FileName,FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, tbText.Text);
                }
            }
            else
            {
                MessageBox.Show("형식을 정해주세요");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();

            try
            {
                if (openFileDialog.FileName != "")
                {
                    if (openFileDialog.FileName.Contains(".txt"))
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            tbText.Text = sr.ReadToEnd();
                        }
                    }
                    else if (openFileDialog.FileName.Contains(".bin"))
                    {
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            tbText.Text = "";
                            string result;

                            BinaryFormatter bf = new BinaryFormatter();
                            result = (string)bf.Deserialize(fs);
                            tbText.Text = result;
                        }
                    }
                    else
                    {
                        MessageBox.Show("이형식을 읽을수 없습니다.");
                        throw new Exception();
                    }
                }
            }
            catch (Exception exception)
            {
               
                MessageBox.Show(exception.GetType().ToString() + "\n" + exception.Message + "\n" + exception.StackTrace);
                

                using (FileStream fs = new FileStream("../../error.log", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize (fs, exception.GetType().ToString()+ exception.Message + exception.StackTrace);

                    MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
                }

            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw =new StreamWriter("../../fs.txt"))
            {
                sw.Write(tbText.Text);
                MessageBox.Show("텍스트가 파일에 저장되었습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("../../fs.txt"))
            {
                tbText.Text = sr.ReadToEnd();
                MessageBox.Show("텍스트를 불러왔습니다.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                using (StreamWriter sw = new StreamWriter("../../fs.txt"))
                {
                    sw.Write(tbText.Text);
                    MessageBox.Show("텍스트가 파일에 저장되었습니다.");
                }
            }
            if(checkBox2.Checked==true)
            {
                using (FileStream fs = new FileStream("../../Binary.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, tbText.Text);
                    MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
                }
            }
            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("아무것도 선택 되지 않았습니다.");
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                using (StreamReader sr = new StreamReader("../../fs.txt"))
                {
                    tbText.Text = sr.ReadToEnd();
                    MessageBox.Show("텍스트를 불러왔습니다.");
                }
            }
            if(radioButton2.Checked==true)
            {
                using (FileStream fs = new FileStream("../../Binary.bin", FileMode.Open))
                {
                    tbText.Text = "";
                    string result;

                    BinaryFormatter bf = new BinaryFormatter();
                    result = (string)bf.Deserialize(fs);
                    tbText.Text = result;
                    MessageBox.Show("바이너리를 모두 읽어왔습니다.");
                }
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("아무것도 선택 되지 않았습니다.");
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
