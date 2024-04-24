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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.Feebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            this.ServiceSelection.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label3.Location = new System.Drawing.Point(16, 130);
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
            this.label2.Location = new System.Drawing.Point(16, 46);
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
            this.label1.Location = new System.Drawing.Point(16, 214);
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
            this.AgeBox.Location = new System.Drawing.Point(6, 244);
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
            this.BackBtn.Location = new System.Drawing.Point(3, 630);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(175, 45);
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
            this.NextBtn.Location = new System.Drawing.Point(190, 630);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(171, 45);
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
            this.NumberBox.Location = new System.Drawing.Point(6, 160);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.PasswordChar = '\0';
            this.NumberBox.PlaceholderText = "Phone Number";
            this.NumberBox.SelectedText = "";
            this.NumberBox.Size = new System.Drawing.Size(346, 49);
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
            this.NameBox.Location = new System.Drawing.Point(6, 76);
            this.NameBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.PlaceholderText = "Name";
            this.NameBox.SelectedText = "";
            this.NameBox.Size = new System.Drawing.Size(346, 49);
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
            this.guna2GroupBox1.Size = new System.Drawing.Size(358, 300);
            this.guna2GroupBox1.TabIndex = 25;
            this.guna2GroupBox1.Text = "Customer Information";
            // 
            // ServiceSelection
            // 
            this.ServiceSelection.BorderColor = System.Drawing.Color.Black;
            this.ServiceSelection.Controls.Add(this.flowLayoutPanel1);
            this.ServiceSelection.Controls.Add(this.ServiceFLP);
            this.ServiceSelection.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ServiceSelection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ServiceSelection.Font = new System.Drawing.Font("Chinacat", 18F);
            this.ServiceSelection.ForeColor = System.Drawing.Color.Black;
            this.ServiceSelection.Location = new System.Drawing.Point(370, 3);
            this.ServiceSelection.Name = "ServiceSelection";
            this.ServiceSelection.Size = new System.Drawing.Size(691, 675);
            this.ServiceSelection.TabIndex = 26;
            this.ServiceSelection.Text = "Choose Service";
            // 
            // ServiceFLP
            // 
            this.ServiceFLP.AutoScroll = true;
            this.ServiceFLP.BackColor = System.Drawing.Color.Black;
            this.ServiceFLP.Location = new System.Drawing.Point(3, 122);
            this.ServiceFLP.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceFLP.Name = "ServiceFLP";
            this.ServiceFLP.Size = new System.Drawing.Size(685, 550);
            this.ServiceFLP.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 76);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.Feebox);
            this.guna2GroupBox2.Controls.Add(this.FeeLabel);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Chinacat", 18F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 333);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(358, 250);
            this.guna2GroupBox2.TabIndex = 26;
            this.guna2GroupBox2.Text = "Booking Fee";
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeeLabel.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.FeeLabel.Location = new System.Drawing.Point(3, 47);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(350, 175);
            this.FeeLabel.TabIndex = 23;
            this.FeeLabel.Text = "Booking fee will be 20% of the\r\nselected service\'s cost. This will\r\nserve as both" +
    " down payment\r\nand cancellation fee which\r\nwill not be refunded.\r\n\r\nCost will be" +
    ": ";
            // 
            // Feebox
            // 
            this.Feebox.Animated = true;
            this.Feebox.AutoRoundedCorners = true;
            this.Feebox.BackColor = System.Drawing.Color.Transparent;
            this.Feebox.BorderColor = System.Drawing.Color.Black;
            this.Feebox.BorderRadius = 23;
            this.Feebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Feebox.DefaultText = "";
            this.Feebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Feebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Feebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Feebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Feebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Feebox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.Feebox.ForeColor = System.Drawing.Color.Black;
            this.Feebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Feebox.Location = new System.Drawing.Point(145, 189);
            this.Feebox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Feebox.Name = "Feebox";
            this.Feebox.PasswordChar = '\0';
            this.Feebox.PlaceholderText = "Booking Fee";
            this.Feebox.ReadOnly = true;
            this.Feebox.SelectedText = "";
            this.Feebox.Size = new System.Drawing.Size(197, 49);
            this.Feebox.TabIndex = 23;
            this.Feebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.ServiceSelection);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NextBtn);
            this.Name = "Information";
            this.Size = new System.Drawing.Size(1064, 681);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ServiceSelection.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label FeeLabel;
        private Guna.UI2.WinForms.Guna2TextBox Feebox;
    }
}
