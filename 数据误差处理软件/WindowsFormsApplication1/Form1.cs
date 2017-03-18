using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 数据分析软件12212028张子晗;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        float i0 = 0.00f;
        float i1 = 0.00f;
        float i2 = 0.00f;
        float i3 = 0.00f;
        float i4 = 0.00f;
        float i5 = 0.00f;
        float i6 = 0.00f;
        float i7 = 0.00f;
        float v0 = 0.00f;
        float v1 = 0.00f;
        float v2 = 0.00f;
        float v3 = 0.00f;
        float v4 = 0.00f;
        float v5 = 0.00f;
        float v6 = 0.00f;
        float g = 0.00f;
        float U = 0.00f;
        float biaozhuncha = 0.00f;
        float biaozhunpiancha = 0.00f;
        float M = 0.00f;
        float left = 0.00f;
        float right = 0.00f;
        float t = 0.00f;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i0 = Convert.ToSingle(textBox1.Text);
            i1 = Convert.ToSingle(textBox2.Text);
            i2 = Convert.ToSingle(textBox3.Text);
            i3 = Convert.ToSingle(textBox4.Text);
            i4 = Convert.ToSingle(textBox5.Text);
            i5 = Convert.ToSingle(textBox6.Text);
            i6 = Convert.ToSingle(textBox7.Text);
            i7 = Convert.ToSingle(textBox8.Text);
            U =(i0+ i1 + i2 + i3 + i4 + i5 + i6 + i7) / 8;
            biaozhuncha =(float) Math.Sqrt((i0 * i0 + i1 * i1 + i2 * i2 + i3 * i3 + i4 * i4 + i5 * i5 + i6 * i6 + i7 * i7 - 8 * U * U) / 7);
            textBox9.Text = Convert.ToString(U);
            textBox10.Text = Convert.ToString(biaozhuncha);
            if (Math.Abs(i0 - U) > g * biaozhuncha) { richTextBox1.Text = "i0为坏值"; }
            if (Math.Abs(i1 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text+"i1为坏值"; }
            if (Math.Abs(i2 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i2为坏值"; }
            if (Math.Abs(i3 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i3为坏值"; }
            if (Math.Abs(i4 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i4为坏值"; }
            if (Math.Abs(i5 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i5为坏值"; }
            if (Math.Abs(i6 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i6为坏值"; }
            if (Math.Abs(i7 - U) > g * biaozhuncha) { richTextBox1.Text = richTextBox1.Text + "i7为坏值"; }
            biaozhunpiancha = biaozhuncha / Math.Abs(8);
            textBox14.Text = Convert.ToString(biaozhunpiancha);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已剔除异常数据?", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            i0 = Convert.ToSingle(textBox1.Text);
            i1 = Convert.ToSingle(textBox2.Text);
            i2 = Convert.ToSingle(textBox3.Text);
            i3 = Convert.ToSingle(textBox4.Text);
            i4 = Convert.ToSingle(textBox5.Text);
            i5 = Convert.ToSingle(textBox6.Text);
            U =(i0+ i1 + i2 + i3 + i4 + i5) / 6;
            v0 = i0 - U;
            v1 = i1 - U;
            v2 = i2 - U;
            v3 = i3 - U;
            v4 = i4 - U;
            v5 = i5 - U;
            t=Convert.ToSingle(textBox16.Text);
            M = Math.Abs(v0 + v1 + v2 - v3 - v4 - v5);
            biaozhuncha =(float) Math.Sqrt((i0 * i0 + i1 * i1 + i2 * i2 + i3 * i3 + i4 * i4 + i5 * i5 + - 6 * U * U) / 5);
            if ((2 * M < Math.Abs(i0 - U)) & (2 * M < Math.Abs(i1 - U)) & (2 * M < Math.Abs(i2 - U)) & (2 * M < Math.Abs(i3 - U)) & (2 * M < Math.Abs(i4 - U)) & (2 * M < Math.Abs(i5 - U)))
            { textBox12.Text = "无"; }
            else
            { textBox12.Text = "有"; }
            if (Math.Abs(v0 * v1 + v1 * v2 + v2 * v3 + v3 * v4 + v4 * v5) > (Math.Sqrt(6) * biaozhuncha * biaozhuncha))
            { textBox13.Text = "有"; }
            else
            { textBox13.Text = "无"; }
            biaozhunpiancha = biaozhuncha / Math.Abs(6);
            left = U - t * biaozhunpiancha;
            right = U + t * biaozhunpiancha;
            textBox17.Text = Convert.ToString(left);
            textBox18.Text = Convert.ToString(right);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已剔除异常数据?", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            i0 = Convert.ToSingle(textBox1.Text);
            i1 = Convert.ToSingle(textBox2.Text);
            i2 = Convert.ToSingle(textBox3.Text);
            i3 = Convert.ToSingle(textBox4.Text);
            i4 = Convert.ToSingle(textBox5.Text);
            i5 = Convert.ToSingle(textBox6.Text);
            i6 = Convert.ToSingle(textBox7.Text);
            U = (i0 + i1 + i2 + i3 + i4 + i5+i6) / 7;
            v0 = i0 - U;
            v1 = i1 - U;
            v2 = i2 - U;
            v3 = i3 - U;
            v4 = i4 - U;
            v5 = i5 - U;
            v6 = i6 - U;
            t = Convert.ToSingle(textBox16.Text);
            M = Math.Abs(v0 + v1 + v2 - v3 - v4 - v5-v6);
            biaozhuncha = (float)Math.Sqrt((i0 * i0 + i1 * i1 + i2 * i2 + i3 * i3 + i4 * i4 + i5 * i5 +i6*i6 -7 * U * U) / 6);
            if ((2 * M < Math.Abs(i0 - U)) & (2 * M < Math.Abs(i1 - U)) & (2 * M < Math.Abs(i2 - U)) & (2 * M < Math.Abs(i3 - U)) & (2 * M < Math.Abs(i4 - U)) & (2 * M < Math.Abs(i5 - U)) & (2 * M < Math.Abs(i6 - U)))
            { textBox12.Text = "无"; }
            else
            { textBox12.Text = "有"; }
            if (Math.Abs(v0 * v1 + v1 * v2 + v2 * v3 + v3 * v4 + v4 * v5+v5*v6) > (Math.Sqrt(6) * biaozhuncha * biaozhuncha))
            { textBox13.Text = "有"; }
            else
            { textBox13.Text = "无"; }
            biaozhunpiancha = biaozhuncha / Math.Abs(7);
            left = U - t * biaozhunpiancha;
            right = U + t * biaozhunpiancha;
            textBox17.Text = Convert.ToString(left);
            textBox18.Text = Convert.ToString(right);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
