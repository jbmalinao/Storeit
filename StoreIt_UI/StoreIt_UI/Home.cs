﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            new ManageSales().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManageExpenses().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ManageDebts().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ViewSummary().Show();
            this.Hide();
        }
    }
}
