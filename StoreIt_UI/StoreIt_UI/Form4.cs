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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
