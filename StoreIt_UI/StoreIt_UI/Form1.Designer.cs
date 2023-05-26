namespace StoreIt_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreItLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreItLabel
            // 
            this.StoreItLabel.AutoSize = true;
            this.StoreItLabel.BackColor = System.Drawing.Color.Transparent;
            this.StoreItLabel.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreItLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.StoreItLabel.Location = new System.Drawing.Point(290, 133);
            this.StoreItLabel.Name = "StoreItLabel";
            this.StoreItLabel.Size = new System.Drawing.Size(200, 71);
            this.StoreItLabel.TabIndex = 0;
            this.StoreItLabel.Text = "StoreIt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StoreIt_UI.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(335, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(237, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your sari-sari store buddy monitoring system";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SteelBlue;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(335, 296);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 51);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start Here";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::StoreIt_UI.Properties.Resources.gradient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StoreItLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StoreItLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Button StartButton;
    }
}