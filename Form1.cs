using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonShneyder04._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form4 = new Form4();
            Form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form6 = new Form6();
            Form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form10 = new Form10();
            Form10.Show();
        }
    }
}
