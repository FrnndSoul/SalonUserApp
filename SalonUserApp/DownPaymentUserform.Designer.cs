namespace SalonUserApp.User_Controls.Appointment_Folder
{
    partial class DownPaymentUserform
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
            this.referenceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceBox
            // 
            this.referenceBox.BorderColor = System.Drawing.Color.Black;
            this.referenceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.referenceBox.DefaultText = "";
            this.referenceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.referenceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.referenceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.referenceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.referenceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.referenceBox.Font = new System.Drawing.Font("Chinacat", 18F);
            this.referenceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.referenceBox.Location = new System.Drawing.Point(28, 403);
            this.referenceBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.referenceBox.Name = "referenceBox";
            this.referenceBox.PasswordChar = '\0';
            this.referenceBox.PlaceholderText = "Reference Number";
            this.referenceBox.SelectedText = "";
            this.referenceBox.Size = new System.Drawing.Size(369, 52);
            this.referenceBox.TabIndex = 7;
            this.referenceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReferenceBox_KeyPress);
            // 
            // NextBtn
            // 
            this.NextBtn.Animated = true;
            this.NextBtn.AutoRoundedCorners = true;
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.BorderRadius = 21;
            this.NextBtn.BorderThickness = 1;
            this.NextBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NextBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(226, 461);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(171, 45);
            this.NextBtn.TabIndex = 18;
            this.NextBtn.Text = "Next";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Animated = true;
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 21;
            this.BackBtn.BorderThickness = 1;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(28, 461);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(171, 45);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 50);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please settle the Down\r\nPayment to proceed.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SalonUserApp.Properties.Resources.gcash;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(62, 84);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 300);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // DownPaymentUserform
            // 
            this.AcceptButton = this.NextBtn;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(429, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.referenceBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownPaymentUserform";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownPaymentUserform";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox referenceBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.Label label1;
    }
}