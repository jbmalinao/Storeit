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
    public partial class Add_Debts : Form
    {
        public Add_Debts()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Clear();
            productNameTextBox.Clear();
            productCostTextBox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void productCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
 }
