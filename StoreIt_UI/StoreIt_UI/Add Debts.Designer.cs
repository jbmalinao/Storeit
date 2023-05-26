namespace StoreIt_UI
{
    partial class Add_Debts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Debts));
            pictureBox3 = new PictureBox();
            StoreItLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            customerNameTextBox = new TextBox();
            productNameTextBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            productCostTextBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // StoreItLabel
            // 
            StoreItLabel.AutoSize = true;
            StoreItLabel.BackColor = Color.Transparent;
            StoreItLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            StoreItLabel.ForeColor = Color.SteelBlue;
            StoreItLabel.Location = new Point(289, 18);
            StoreItLabel.Name = "StoreItLabel";
            StoreItLabel.Size = new Size(223, 54);
            StoreItLabel.TabIndex = 19;
            StoreItLabel.Text = "Add Debts";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(518, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(221, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(228, 351);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 30;
            label4.Text = "Reset";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.verified;
            pictureBox2.Location = new Point(611, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(613, 351);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 32;
            label5.Text = "Confirm";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(340, 141);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.PlaceholderText = "Enter customer name";
            customerNameTextBox.Size = new Size(235, 23);
            customerNameTextBox.TabIndex = 33;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(340, 183);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.PlaceholderText = "Enter product name";
            productNameTextBox.Size = new Size(235, 23);
            productNameTextBox.TabIndex = 34;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(340, 264);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(235, 23);
            numericUpDown1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(251, 139);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 36;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(264, 183);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 37;
            label2.Text = "Product";
            // 
            // productCostTextBox
            // 
            productCostTextBox.Location = new Point(340, 224);
            productCostTextBox.Name = "productCostTextBox";
            productCostTextBox.PlaceholderText = "Enter cost";
            productCostTextBox.Size = new Size(235, 23);
            productCostTextBox.TabIndex = 38;
            productCostTextBox.TextChanged += productCostTextBox_TextChanged;
            productCostTextBox.KeyPress += productCostTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(291, 226);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 39;
            label3.Text = "Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(257, 261);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 40;
            label6.Text = "Quantity";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(716, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Add_Debts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(productCostTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(productNameTextBox);
            Controls.Add(customerNameTextBox);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(StoreItLabel);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Debts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Debts";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label StoreItLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox customerNameTextBox;
        private TextBox productNameTextBox;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private TextBox productCostTextBox;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox5;
    }
}