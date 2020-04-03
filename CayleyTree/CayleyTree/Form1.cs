using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        int n = 0;
        double leng = 0;
        Pen pen;
        private void drawbutton_Click(object sender, EventArgs e)
        {
            int x = panel1.Width / 2;
            if (graphics == null)
                graphics = panel1.CreateGraphics();
            if (depth.Text == "" || length.Text == "" || rightper.Text == "" || leftper.Text == "" || rigthth.Text == "" || leftph.Text == "" || drawingColor.Text == "")
            {
                th1 = 30 * Math.PI / 180;
                th2 = 20 * Math.PI / 180;
                per1 = 0.6;
                per2 = 0.7;
                drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
                MessageBox.Show("输入信息不全！将展示初始图像", "提示");
            }
            else
            {
                if(int.TryParse(depth.Text, out n)&&double.TryParse(length.Text,out leng)&&double.TryParse(rightper.Text, out per1) && double.TryParse(leftper.Text, out per2) && double.TryParse(rigthth.Text, out th1) && double.TryParse(leftph.Text, out th2))
                {
                    graphics.Clear(this.BackColor);
                    switch (drawingColor.Text)
                    {
                        case "红色":
                            pen = Pens.Red;
                            break;
                        case "蓝色":
                            pen = Pens.Blue;
                            break;
                        case "黑色":
                            pen = Pens.Black;
                            break;
                        case "绿色":
                            pen = Pens.Green;
                            break;
                    }
                    th1 = th1 * Math.PI / 180;
                    th2 = th2 * Math.PI / 180;
                    drawCayleyTree(n,x,310,leng, -Math.PI / 2);
                }
                else
                {
                    MessageBox.Show("存在无法处理的数据！请确认！", "提示");
                }
            }
        }
        void drawCayleyTree(int tn,double x0,double y0,double leng,double th)
        {
            if (tn == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1,pen);
            drawCayleyTree(tn - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(tn - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1,Pen color)
        {
            if(color==null)
            {
                graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            else
            {
                graphics.DrawLine(color, (int)x0, (int)y0, (int)x1, (int)y1);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
