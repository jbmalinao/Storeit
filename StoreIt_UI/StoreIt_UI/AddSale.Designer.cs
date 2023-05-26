namespace StoreIt_UI
{
    partial class AddSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSale));
            StoreItLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            productNameTextBox = new TextBox();
            productCostTextBox = new TextBox();
            productQuantityTextBox = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productQuantityTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // StoreItLabel
            // 
            StoreItLabel.AutoSize = true;
            StoreItLabel.BackColor = Color.Transparent;
            StoreItLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            StoreItLabel.ForeColor = Color.SteelBlue;
            StoreItLabel.Location = new Point(290, 18);
            StoreItLabel.Name = "StoreItLabel";
            StoreItLabel.Size = new Size(207, 54);
            StoreItLabel.TabIndex = 14;
            StoreItLabel.Text = "Add Sales";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(515, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(340, 141);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.PlaceholderText = "Enter product name";
            productNameTextBox.Size = new Size(235, 23);
            productNameTextBox.TabIndex = 17;
            // 
            // productCostTextBox
            // 
            productCostTextBox.Location = new Point(340, 198);
            productCostTextBox.Name = "productCostTextBox";
            productCostTextBox.PlaceholderText = "Enter amount";
            productCostTextBox.Size = new Size(235, 23);
            productCostTextBox.TabIndex = 18;
            productCostTextBox.TextChanged += productCostTextBox_TextChanged;
            productCostTextBox.KeyPress += productCostTextBox_KeyPress;
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(340, 247);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(235, 23);
            productQuantityTextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(217, 143);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 20;
            label1.Text = "Product name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(257, 198);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 21;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(257, 247);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 22;
            label3.Text = "Quantity";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.verified;
            pictureBox2.Location = new Point(611, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(221, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
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
            label4.TabIndex = 25;
            label4.Text = "Reset";
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
            label5.TabIndex = 26;
            label5.Text = "Confirm";
            label5.Click += label5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(716, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // AddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productQuantityTextBox);
            Controls.Add(productCostTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(StoreItLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSale";
            Load += AddSale_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)productQuantityTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StoreItLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox productNameTextBox;
        private TextBox productCostTextBox;
        private NumericUpDown productQuantityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
    }
}