using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreIt_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
