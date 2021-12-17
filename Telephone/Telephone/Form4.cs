using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telephone
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Phone;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First Name")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select First, Last, Mobile, Email, Catagory FROM Mobiles WHERE First LIKE '" + textBox1.Text + "%'", conn);
                DataTable data = new DataTable();
                sd.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Last Name")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select First, Last, Mobile, Email, Catagory FROM Mobiles WHERE Last LIKE '" + textBox1.Text + "%'", conn);
                DataTable data = new DataTable();
                sd.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Mobile")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select First, Last, Mobile, Email, Catagory FROM Mobiles WHERE Mobile LIKE '" + textBox1.Text + "%'", conn);
                DataTable data = new DataTable();
                sd.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Email")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select First, Last, Mobile, Email, Catagory FROM Mobiles WHERE Email LIKE '" + textBox1.Text + "%'", conn);
                DataTable data = new DataTable();
                sd.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Catagory")
            {
                SqlDataAdapter sd = new SqlDataAdapter("Select First, Last, Mobile, Email, Catagory FROM Mobiles WHERE Catagory LIKE '" + textBox1.Text + "%'", conn);
                DataTable data = new DataTable();
                sd.Fill(data);
                dataGridView1.DataSource = data;
            }
        }
    }
}
