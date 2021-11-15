using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MarathonShneyder04._10
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Xiaomi\source\repos\MarathonShneyder04.10\MarathonShneyder04.10\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();


            this.Hide();
            Form Form3 = new Form3(label14.Text);


            Form3.Show();

          

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text) + 50;
            textBox1.Text = Convert.ToString(a);
            label14.Text = "$" + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            if (b > 50) {
                a = a - 50;
                textBox1.Text = Convert.ToString(a);
                label14.Text = "$" + textBox1.Text;
            } 
            else
            {
                b = 50;
                textBox1.Text = Convert.ToString(b);
                label14.Text = "$" + textBox1.Text;
            }
             
           
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.Mask = null;
            maskedTextBox2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
