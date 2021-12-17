using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter user name!!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Password!!");
            }
            else
            {
                if (textBox1.Text == "daffodil")
                {
                    if (textBox2.Text == "123")
                    {
                        Form3 f = new Form3();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!!!Try again...");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username!!!Try again...");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "daffodil")
            {
                if (textBox2.Text == "123")
                {
                    MessageBox.Show("Logging out...Thank you!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Log-in first!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
