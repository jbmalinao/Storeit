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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void showPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword2.Checked)
            {
                passwordTextBox2.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword2.Checked)
            {
                passwordTextBox2.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            usernameTextBox2.Clear();
            passwordTextBox2.Clear();
        }
    }
}
