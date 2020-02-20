using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form fm = new Form2();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm2 = new Form3();
            fm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fm3 = new Form4();
            fm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)       {
            Form fm4 = new Form5();
            fm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form fm5 = new Form6();
            fm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form fm6 = new Form7();
            fm6.Show();
        }
    }
}
