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
    public partial class Form5 : Form
    {
        public Form5()
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
            int a, b, c;
            b = Convert.ToInt32(textBox1.Text);
            c = Convert.ToInt32(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            a = (b / 100 * c);
            label1.Text = Convert.ToString(a);
        }
    }
}
