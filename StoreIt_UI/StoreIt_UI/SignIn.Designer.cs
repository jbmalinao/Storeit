namespace StoreIt_UI
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            passwordTextBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            LogInButton = new Button();
            clearAll = new Button();
            showPassword2 = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            usernameTextBox2 = new TextBox();
            signIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // passwordTextBox2
            // 
            passwordTextBox2.BackColor = Color.White;
            passwordTextBox2.BorderStyle = BorderStyle.None;
            passwordTextBox2.Location = new Point(274, 221);
            passwordTextBox2.Name = "passwordTextBox2";
            passwordTextBox2.PlaceholderText = "Enter your password";
            passwordTextBox2.Size = new Size(213, 16);
            passwordTextBox2.TabIndex = 10;
            passwordTextBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.profile;
            pictureBox2.Location = new Point(229, 154);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
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
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(331, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.SteelBlue;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(293, 297);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(141, 34);
            LogInButton.TabIndex = 14;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // clearAll
            // 
            clearAll.BackColor = Color.Transparent;
            clearAll.FlatAppearance.BorderSize = 0;
            clearAll.FlatStyle = FlatStyle.Flat;
            clearAll.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            clearAll.Location = new Point(235, 254);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(75, 23);
            clearAll.TabIndex = 15;
            clearAll.Text = "Clear all";
            clearAll.UseVisualStyleBackColor = false;
            clearAll.Click += clearAll_Click;
            // 
            // showPassword2
            // 
            showPassword2.AutoSize = true;
            showPassword2.BackColor = Color.Transparent;
            showPassword2.Location = new Point(444, 258);
            showPassword2.Name = "showPassword2";
            showPassword2.Size = new Size(108, 19);
            showPassword2.TabIndex = 16;
            showPassword2.Text = "Show Password";
            showPassword2.UseVisualStyleBackColor = false;
            showPassword2.CheckedChanged += showPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(37, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
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
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // usernameTextBox2
            // 
            usernameTextBox2.BackColor = Color.White;
            usernameTextBox2.BorderStyle = BorderStyle.None;
            usernameTextBox2.Location = new Point(274, 173);
            usernameTextBox2.Name = "usernameTextBox2";
            usernameTextBox2.PlaceholderText = "Enter your username";
            usernameTextBox2.Size = new Size(213, 16);
            usernameTextBox2.TabIndex = 19;
            // 
            // signIn
            // 
            signIn.AutoSize = true;
            signIn.BackColor = Color.Transparent;
            signIn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            signIn.ForeColor = Color.SteelBlue;
            signIn.Location = new Point(331, 9);
            signIn.Name = "signIn";
            signIn.Size = new Size(104, 37);
            signIn.TabIndex = 20;
            signIn.Text = "Sign in";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradient;
            ClientSize = new Size(800, 450);
            Controls.Add(signIn);
            Controls.Add(usernameTextBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(showPassword2);
            Controls.Add(clearAll);
            Controls.Add(LogInButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(passwordTextBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordTextBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button LogInButton;
        private Button clearAll;
        private CheckBox showPassword2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox usernameTextBox2;
        private Label signIn;
    }
}