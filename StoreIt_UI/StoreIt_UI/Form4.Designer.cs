namespace StoreIt_UI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            StoreItLabel = new Label();
            pictureBox1 = new PictureBox();
            createAccountButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // StoreItLabel
            // 
            StoreItLabel.AutoSize = true;
            StoreItLabel.BackColor = Color.Transparent;
            StoreItLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            StoreItLabel.ForeColor = Color.SteelBlue;
            StoreItLabel.Location = new Point(211, 23);
            StoreItLabel.Name = "StoreItLabel";
            StoreItLabel.Size = new Size(317, 54);
            StoreItLabel.TabIndex = 1;
            StoreItLabel.Text = "Welcome, User!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(534, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.SteelBlue;
            createAccountButton.FlatAppearance.BorderSize = 0;
            createAccountButton.FlatStyle = FlatStyle.Flat;
            createAccountButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountButton.ForeColor = Color.White;
            createAccountButton.Location = new Point(276, 136);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(200, 34);
            createAccountButton.TabIndex = 6;
            createAccountButton.Text = "Manage Sales";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(276, 186);
            button1.Name = "button1";
            button1.Size = new Size(200, 34);
            button1.TabIndex = 7;
            button1.Text = "Manage Expenses";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(276, 240);
            button2.Name = "button2";
            button2.Size = new Size(200, 34);
            button2.TabIndex = 8;
            button2.Text = "Manage Debts";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(276, 295);
            button3.Name = "button3";
            button3.Size = new Size(200, 34);
            button3.TabIndex = 9;
            button3.Text = "View Summary";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(749, 389);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(258, 77);
            label1.Name = "label1";
            label1.Size = new Size(232, 21);
            label1.TabIndex = 12;
            label1.Text = "Decide what do you want to do";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(716, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(createAccountButton);
            Controls.Add(pictureBox1);
            Controls.Add(StoreItLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StoreItLabel;
        private PictureBox pictureBox1;
        private Button createAccountButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox5;
    }
}