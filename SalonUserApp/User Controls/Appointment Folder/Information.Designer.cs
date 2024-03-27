namespace SalonUserApp.User_Controls
{
    partial class Information
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NumberBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ServiceSelection = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ServiceFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GroupBox1.SuspendLayout();
            this.ServiceSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label1.Location = new System.Drawing.Point(16, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Age:";
            // 
            // AgeBox
            // 
            this.AgeBox.Animated = true;
            this.AgeBox.AutoRoundedCorners = true;
            this.AgeBox.BackColor = System.Drawing.Color.Transparent;
            this.AgeBox.BorderColor = System.Drawing.Color.Black;
            this.AgeBox.BorderRadius = 23;
            this.AgeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeBox.DefaultText = "";
            this.AgeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.AgeBox.ForeColor = System.Drawing.Color.Black;
            this.AgeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeBox.Location = new System.Drawing.Point(21, 324);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.PasswordChar = '\0';
            this.AgeBox.PlaceholderText = "Age";
            this.AgeBox.SelectedText = "";
            this.AgeBox.Size = new System.Drawing.Size(159, 49);
            this.AgeBox.TabIndex = 19;
            this.AgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AgeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeBox_KeyPress);
            // 
            // BackBtn
            // 
            this.BackBtn.Animated = true;
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 21;
            this.BackBtn.BorderThickness = 1;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(24, 577);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(180, 45);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.NextBtn.Location = new System.Drawing.Point(210, 577);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(180, 45);
            this.NextBtn.TabIndex = 17;
            this.NextBtn.Text = "Next";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Animated = true;
            this.NumberBox.AutoRoundedCorners = true;
            this.NumberBox.BackColor = System.Drawing.Color.Transparent;
            this.NumberBox.BorderColor = System.Drawing.Color.Black;
            this.NumberBox.BorderRadius = 23;
            this.NumberBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberBox.DefaultText = "";
            this.NumberBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NumberBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NumberBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NumberBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.NumberBox.ForeColor = System.Drawing.Color.Black;
            this.NumberBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NumberBox.Location = new System.Drawing.Point(21, 206);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.PasswordChar = '\0';
            this.NumberBox.PlaceholderText = "Phone Number";
            this.NumberBox.SelectedText = "";
            this.NumberBox.Size = new System.Drawing.Size(366, 49);
            this.NumberBox.TabIndex = 15;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Animated = true;
            this.NameBox.AutoRoundedCorners = true;
            this.NameBox.BackColor = System.Drawing.Color.Transparent;
            this.NameBox.BorderColor = System.Drawing.Color.Black;
            this.NameBox.BorderRadius = 23;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.DefaultText = "";
            this.NameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameBox.Location = new System.Drawing.Point(21, 88);
            this.NameBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(366, 49);
            this.NameBox.TabIndex = 14;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.NameBox);
            this.guna2GroupBox1.Controls.Add(this.NumberBox);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.AgeBox);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Chinacat", 18F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(408, 412);
            this.guna2GroupBox1.TabIndex = 25;
            this.guna2GroupBox1.Text = "Customer Information";
            // 
            // ServiceSelection
            // 
            this.ServiceSelection.BorderColor = System.Drawing.Color.Black;
            this.ServiceSelection.Controls.Add(this.ServiceFLP);
            this.ServiceSelection.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ServiceSelection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ServiceSelection.Font = new System.Drawing.Font("Chinacat", 18F);
            this.ServiceSelection.ForeColor = System.Drawing.Color.Black;
            this.ServiceSelection.Location = new System.Drawing.Point(417, 3);
            this.ServiceSelection.Name = "ServiceSelection";
            this.ServiceSelection.Size = new System.Drawing.Size(660, 619);
            this.ServiceSelection.TabIndex = 26;
            this.ServiceSelection.Text = "Choose Service";
            // 
            // ServiceFLP
            // 
            this.ServiceFLP.AutoScroll = true;
            this.ServiceFLP.BackColor = System.Drawing.Color.White;
            this.ServiceFLP.Location = new System.Drawing.Point(22, 58);
            this.ServiceFLP.Name = "ServiceFLP";
            this.ServiceFLP.Size = new System.Drawing.Size(617, 539);
            this.ServiceFLP.TabIndex = 0;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ServiceSelection);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Name = "Information";
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ServiceSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox AgeBox;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        private Guna.UI2.WinForms.Guna2TextBox NumberBox;
        private Guna.UI2.WinForms.Guna2TextBox NameBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox ServiceSelection;
        private System.Windows.Forms.FlowLayoutPanel ServiceFLP;
    }
}
