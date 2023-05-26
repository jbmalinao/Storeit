namespace StoreIt_UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            passwordTextBox = new TextBox();
            createAccountButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            usernameTextBox = new TextBox();
            button1 = new Button();
            showPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(331, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(274, 221);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Create password";
            passwordTextBox.Size = new Size(213, 16);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.SteelBlue;
            createAccountButton.FlatAppearance.BorderSize = 0;
            createAccountButton.FlatStyle = FlatStyle.Flat;
            createAccountButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountButton.ForeColor = Color.White;
            createAccountButton.Location = new Point(293, 297);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(141, 34);
            createAccountButton.TabIndex = 5;
            createAccountButton.Text = "Create account";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(229, 154);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(235, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Location = new Point(274, 173);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Create username";
            usernameTextBox.Size = new Size(213, 16);
            usernameTextBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button1.Location = new Point(235, 254);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Clear all";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.BackColor = Color.Transparent;
            showPassword.Location = new Point(444, 258);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(108, 19);
            showPassword.TabIndex = 10;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = false;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(37, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(716, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(showPassword);
            Controls.Add(button1);
            Controls.Add(usernameTextBox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(createAccountButton);
            Controls.Add(passwordTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox passwordTextBox;
        private Button createAccountButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox usernameTextBox;
        private Button button1;
        private CheckBox showPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}