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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2;
        string pheptinh;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HienThi.Text = HienThi.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
           HienThi.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(pheptinh == "cong")
            {
                num2=num1 + float.Parse(HienThi.Text);
                HienThi.Text = num2.ToString();
            }
            if (pheptinh == "tru")
            {
                num2 = num1 - float.Parse(HienThi.Text);
                HienThi.Text = num2.ToString();
            }
            if (pheptinh == "nhan")
            {
                num2 = num1 * float.Parse(HienThi.Text);
                HienThi.Text = num2.ToString();
            }
            if (pheptinh == "chia")
            {
                if(float.Parse(HienThi.Text) == 0){
                    HienThi.Text = "khong chia duoc";
                }
                else
                {
                    num2 = num1 / float.Parse(HienThi.Text);
                    HienThi.Text = num2.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            num1 = float.Parse(HienThi.Text);
            HienThi.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            num1 = float.Parse(HienThi.Text);
            HienThi.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            num1 = float.Parse(HienThi.Text);
            HienThi.Clear();
        }

        private void HienThi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            num1 =float.Parse(HienThi.Text);
            HienThi.Clear();
        }
    }
}
