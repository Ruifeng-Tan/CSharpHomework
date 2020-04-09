using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n;
        double th1;
        double th2;
        double per1;
        double per2;
        double leng;
        string pencolor;
        public Form1()
        {
            InitializeComponent();
        }

        private void drawbutton_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(this.BackColor);
            if (graphics == null) graphics=this.panel1.CreateGraphics();
            try
            {
             n=int.Parse(txtdepthofrecursion.Text);//递归深度
            per2 = Convert.ToDouble(trackBarforperl2.Value)/10;//左分支长度
            per1 = Convert.ToDouble(trackBarforperl1.Value)/10;//右分支长度
            leng = double.Parse(txtleng.Text);//主干长度
            th2 = double.Parse(txt_th2.Text);//左分支角度
            th1 = double.Parse(txt_th1.Text);//右分支角度
            
            }
            catch (FormatException)
            {
                MessageBox.Show("请确保输入都是数字");
            }
            catch (OverflowException)
            {
                MessageBox.Show("你输入的数字过大或过小");
            }
            try
            {
                pencolor = cmbPenColor.SelectedItem.ToString();//画笔颜色
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("请选择画笔颜色");
            }

            drawCayleyTree(n,200,310,leng,-Math.PI/2);
        }


        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
       
            switch (pencolor) {
                case ("蓝色"):
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case ("黑色"):
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case ("红色"):
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
