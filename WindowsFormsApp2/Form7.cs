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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text = label1.Text;
            using (FileStream fstream = new FileStream(@"D:\SomeDir\note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
            int a;
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            a = a * a;
            label1.Text = Convert.ToString(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:/SomeDir";
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            string text = label1.Text;
            using (FileStream fstream = new FileStream(@"D:\SomeDir\note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
            int a;
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            double c = Math.Sqrt(a);
            label1.Text = Convert.ToString(c);
        }
    }
}
