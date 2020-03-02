using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    result.Text = "请选择运算符";
                }
                else
                {
                    double a = double.Parse(textBox1.Text);
                    double b = double.Parse(textBox2.Text);
                    switch (comboBox1.Text)
                    {
                        case "+":
                            result.Text = $"{ a + b}";
                            break;
                        case "-":
                            result.Text = $"{ a - b}";
                            break;
                        case "*":
                            result.Text = $"{ a * b}";
                            break;
                        case "/":
                            if (b == 0)
                                result.Text = "除数不可为零";
                            else
                                result.Text = $"{ a / b}";
                            break;
                    }
                }
            }
            catch
            {
                result.Text="输入字符无法进行计算";
            }
        }
            
    }
}
