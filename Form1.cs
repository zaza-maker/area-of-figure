using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 面积计算器
{
    public partial class Form1 : Form
    {
        double k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CGraph cgraph = new CGraph();
            if (tabControl1.SelectedIndex == 0 && textBox1.Text.Trim() != " ")
            {
                double r = double.Parse(textBox1.Text);
                label5.Text = "边长为 " + r + " 的正方形的面积是：" + cgraph.calculate(r, r) * k * k + "cm^2";
               
            }
            else if (tabControl1.SelectedIndex == 1 && textBox2.Text.Trim() != " " && textBox3.Text.Trim() != " ")
            {
                double r = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                label5.Text = "长为 " + r + " 宽为 " + c + " 的长方形的面积是：" + cgraph.calculate(r, c) * k * k + "cm^2";
            }
            else if (tabControl1.SelectedIndex == 2 && textBox4.Text.Trim() != " " && textBox5.Text.Trim() != " " && textBox6.Text.Trim() != " ")
            {
                double r = double.Parse(textBox4.Text);
                double c = double.Parse(textBox5.Text);
                double v = double.Parse(textBox6.Text);
                if (r + c > v && r + v > c && c + v > r)
                {
                    label5.Text = "边长为 " + r + "，" + c + "，" + v + "，" + " 的三角形的面积是：" + cgraph.calculate(r, c, v) * k * k + "cm^2";

                }
                else
                {
                    MessageBox.Show("输入的三边数据构不成三角形");
                }
            }
            else if (tabControl1.SelectedIndex == 3 && textBox7.Text.Trim() != " " )
            {
                double r = double.Parse(textBox7.Text);
                label5.Text = "半径为 " + r + " 的圆的面积是：" + cgraph.calculate(r) * k * k + "cm^2";
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                textBox1.Text = " ";
                label5.Text = " ";
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                textBox2.Text = " ";
                textBox3.Text = " ";
                label5.Text = " ";

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                label5.Text = " ";

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                textBox7.Text = " ";
                label5.Text = " ";

            }

        }
        public class CGraph
        {
            public CGraph()
            {

            }
            public double calculate(double a)
            {
                double area = Math.PI * a * a;
                return Math.Round(area, 2);
            }

            public double calculate(double a, double b)
            {
                double area = a * b;
                return Math.Round(area, 2);
            }
            public double calculate(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return Math.Round( area,2);
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "单位是：厘米")
            {
                btn3.Text = "单位是：英寸";
                k = 2.54 ;
            }

            else
            {
                btn3.Text = "单位是：厘米";
                k = 1;
            }

        }
    }
}
