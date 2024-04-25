namespace SalonUserApp.User_Controls.FlowControls
{
    partial class AppointInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTextLabel = new System.Windows.Forms.Label();
            this.CheckStatusBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NameTextLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RefLabel = new System.Windows.Forms.Label();
            this.RefTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTextLabel
            // 
            this.DateTextLabel.AutoSize = true;
            this.DateTextLabel.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextLabel.Location = new System.Drawing.Point(597, 46);
            this.DateTextLabel.Name = "DateTextLabel";
            this.DateTextLabel.Size = new System.Drawing.Size(182, 32);
            this.DateTextLabel.TabIndex = 5;
            this.DateTextLabel.Text = "MM/dd/YYYY";
            // 
            // CheckStatusBtn
            // 
            this.CheckStatusBtn.Animated = true;
            this.CheckStatusBtn.AutoRoundedCorners = true;
            this.CheckStatusBtn.BorderRadius = 21;
            this.CheckStatusBtn.BorderThickness = 1;
            this.CheckStatusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckStatusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckStatusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckStatusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckStatusBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckStatusBtn.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.CheckStatusBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckStatusBtn.Location = new System.Drawing.Point(854, 24);
            this.CheckStatusBtn.Name = "CheckStatusBtn";
            this.CheckStatusBtn.Size = new System.Drawing.Size(180, 45);
            this.CheckStatusBtn.TabIndex = 1;
            this.CheckStatusBtn.Text = "View";
            this.CheckStatusBtn.Click += new System.EventHandler(this.CheckStatusBtn_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.DateLabel.Location = new System.Drawing.Point(598, 13);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(210, 25);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Appointment Date";
            // 
            // NameTextLabel
            // 
            this.NameTextLabel.AutoSize = true;
            this.NameTextLabel.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextLabel.Location = new System.Drawing.Point(268, 46);
            this.NameTextLabel.Name = "NameTextLabel";
            this.NameTextLabel.Size = new System.Drawing.Size(158, 32);
            this.NameTextLabel.TabIndex = 3;
            this.NameTextLabel.Text = "00000000";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.NameLabel.Location = new System.Drawing.Point(269, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(71, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // RefLabel
            // 
            this.RefLabel.AutoSize = true;
            this.RefLabel.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.RefLabel.Location = new System.Drawing.Point(21, 13);
            this.RefLabel.Name = "RefLabel";
            this.RefLabel.Size = new System.Drawing.Size(198, 25);
            this.RefLabel.TabIndex = 1;
            this.RefLabel.Text = "Refrence Number";
            // 
            // RefTextLabel
            // 
            this.RefTextLabel.AutoSize = true;
            this.RefTextLabel.Font = new System.Drawing.Font("Chinacat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefTextLabel.Location = new System.Drawing.Point(20, 46);
            this.RefTextLabel.Name = "RefTextLabel";
            this.RefTextLabel.Size = new System.Drawing.Size(158, 32);
            this.RefTextLabel.TabIndex = 0;
            this.RefTextLabel.Text = "00000000";
            // 
            // AppointInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.DateTextLabel);
            this.Controls.Add(this.CheckStatusBtn);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.RefTextLabel);
            this.Controls.Add(this.NameTextLabel);
            this.Controls.Add(this.RefLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AppointInfo";
            this.Size = new System.Drawing.Size(1052, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label DateTextLabel;
        public Guna.UI2.WinForms.Guna2Button CheckStatusBtn;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label NameTextLabel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label RefLabel;
        public System.Windows.Forms.Label RefTextLabel;
    }
}
