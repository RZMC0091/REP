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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text1 = label1.Text;
            string text2 = label4.Text;
            string text3 = label7.Text;
            string text4 = label2.Text;
            string text5 = label5.Text;
            string text6 = label8.Text;
            string text7 = label3.Text;
            string text8 = label6.Text;
            string text9 = label9.Text;
            text1 = " " + text1;
            text2 = " " + text2;
            text3 = " " + text3 + "\n";
            text4 = " " + text4;
            text5 = " " + text5;
            text6 = " " + text6 + "\n";
            text7 = " " + text7;
            text8 = " " + text8;
            text9 = " " + text9 + "\n";
            using (FileStream fstream = new FileStream(@"D:\SomeDir\note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text2);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text3);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text4);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text5);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text6);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text7);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text8);
                fstream.Write(array, 0, array.Length);
                array = System.Text.Encoding.Default.GetBytes(text9);
                fstream.Write(array, 0, array.Length);

            }
            int a, b, c, q, w, p, r, t, y, aa, bb, cc, qq, ww, pp, rr, tt, yy;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            q = Convert.ToInt32(textBox4.Text);
            w = Convert.ToInt32(textBox5.Text);
            p = Convert.ToInt32(textBox6.Text);
            r = Convert.ToInt32(textBox7.Text);
            t = Convert.ToInt32(textBox8.Text);
            y = Convert.ToInt32(textBox9.Text);
            aa = Convert.ToInt32(textBox10.Text);
            bb = Convert.ToInt32(textBox11.Text);
            cc = Convert.ToInt32(textBox12.Text);
            qq = Convert.ToInt32(textBox13.Text);
            ww = Convert.ToInt32(textBox14.Text);
            pp = Convert.ToInt32(textBox15.Text);
            rr = Convert.ToInt32(textBox16.Text);
            tt = Convert.ToInt32(textBox17.Text);
            yy = Convert.ToInt32(textBox18.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            a = a + aa;
            b = b + bb;
            c = c + cc;
            q = q + qq;
            w = w + ww;
            p = p + pp;
            r = r + rr;
            t = t + tt;
            y = y + yy;
            label1.Text = Convert.ToString(a);
            label2.Text = Convert.ToString(b);
            label3.Text = Convert.ToString(c);
            label4.Text = Convert.ToString(q);
            label5.Text = Convert.ToString(w);
            label6.Text = Convert.ToString(p);
            label7.Text = Convert.ToString(r);
            label8.Text = Convert.ToString(t);
            label9.Text = Convert.ToString(y);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, q, w, p, r, t, y, aa, bb, cc, qq, ww, pp, rr, tt, yy, z, x, v, n, m, l, k, j, g;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            q = Convert.ToInt32(textBox4.Text);
            w = Convert.ToInt32(textBox5.Text);
            p = Convert.ToInt32(textBox6.Text);
            r = Convert.ToInt32(textBox7.Text);
            t = Convert.ToInt32(textBox8.Text);
            y = Convert.ToInt32(textBox9.Text);
            aa = Convert.ToInt32(textBox10.Text);
            bb = Convert.ToInt32(textBox11.Text);
            cc = Convert.ToInt32(textBox12.Text);
            qq = Convert.ToInt32(textBox13.Text);
            ww = Convert.ToInt32(textBox14.Text);
            pp = Convert.ToInt32(textBox15.Text);
            rr = Convert.ToInt32(textBox16.Text);
            tt = Convert.ToInt32(textBox17.Text);
            yy = Convert.ToInt32(textBox18.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            z = a * aa + q * bb + r * cc;
            x = b * aa + w * bb + t * cc;
            v = c * aa + p * bb + y * cc;
            n = a * qq + q * ww + r * pp;
            m = b * qq + w * ww + t * pp;
            l = c * qq + p * ww + y * pp;
            k = a * rr + q * tt + r * yy;
            j = b * rr + w * tt + t * yy;
            g = c * rr + p * tt + y * yy;
            label1.Text = Convert.ToString(z);
            label2.Text = Convert.ToString(x);
            label3.Text = Convert.ToString(v);
            label4.Text = Convert.ToString(n);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(l);
            label7.Text = Convert.ToString(k);
            label8.Text = Convert.ToString(j);
            label9.Text = Convert.ToString(g);
        }
    }
}
