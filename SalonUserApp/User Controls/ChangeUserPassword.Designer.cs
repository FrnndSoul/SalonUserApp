namespace SalonUserApp.User_Controls
{
    partial class ChangeUserPassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Password2Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password1Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OldBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.changePass = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label4.Location = new System.Drawing.Point(605, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirm New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label3.Location = new System.Drawing.Point(272, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label2.Location = new System.Drawing.Point(675, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label1.Location = new System.Drawing.Point(310, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "USER ID";
            // 
            // IDBox
            // 
            this.IDBox.Animated = true;
            this.IDBox.AutoRoundedCorners = true;
            this.IDBox.BorderColor = System.Drawing.Color.Black;
            this.IDBox.BorderRadius = 23;
            this.IDBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDBox.DefaultText = "";
            this.IDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.IDBox.ForeColor = System.Drawing.Color.Black;
            this.IDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDBox.Location = new System.Drawing.Point(172, 69);
            this.IDBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.IDBox.Name = "IDBox";
            this.IDBox.PasswordChar = '\0';
            this.IDBox.PlaceholderText = "99999";
            this.IDBox.ReadOnly = true;
            this.IDBox.SelectedText = "";
            this.IDBox.Size = new System.Drawing.Size(366, 49);
            this.IDBox.TabIndex = 19;
            this.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Animated = true;
            this.CreateBtn.AutoRoundedCorners = true;
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.BorderRadius = 21;
            this.CreateBtn.BorderThickness = 1;
            this.CreateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CreateBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(299, 424);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(239, 45);
            this.CreateBtn.TabIndex = 18;
            this.CreateBtn.Text = "Save Changes";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(550, 424);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(239, 45);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Discard Changes";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Password2Box
            // 
            this.Password2Box.Animated = true;
            this.Password2Box.AutoRoundedCorners = true;
            this.Password2Box.BorderColor = System.Drawing.Color.Black;
            this.Password2Box.BorderRadius = 23;
            this.Password2Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password2Box.DefaultText = "";
            this.Password2Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password2Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password2Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password2Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password2Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password2Box.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.Password2Box.ForeColor = System.Drawing.Color.Black;
            this.Password2Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password2Box.Location = new System.Drawing.Point(550, 187);
            this.Password2Box.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Password2Box.Name = "Password2Box";
            this.Password2Box.PasswordChar = '\0';
            this.Password2Box.PlaceholderText = "Confirm Password";
            this.Password2Box.SelectedText = "";
            this.Password2Box.Size = new System.Drawing.Size(366, 49);
            this.Password2Box.TabIndex = 16;
            // 
            // Password1Box
            // 
            this.Password1Box.Animated = true;
            this.Password1Box.AutoRoundedCorners = true;
            this.Password1Box.BorderColor = System.Drawing.Color.Black;
            this.Password1Box.BorderRadius = 23;
            this.Password1Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password1Box.DefaultText = "";
            this.Password1Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password1Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password1Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password1Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password1Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password1Box.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.Password1Box.ForeColor = System.Drawing.Color.Black;
            this.Password1Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password1Box.Location = new System.Drawing.Point(172, 187);
            this.Password1Box.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Password1Box.Name = "Password1Box";
            this.Password1Box.PasswordChar = '\0';
            this.Password1Box.PlaceholderText = "Password";
            this.Password1Box.SelectedText = "";
            this.Password1Box.Size = new System.Drawing.Size(366, 49);
            this.Password1Box.TabIndex = 15;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Animated = true;
            this.UsernameBox.AutoRoundedCorners = true;
            this.UsernameBox.BorderColor = System.Drawing.Color.Black;
            this.UsernameBox.BorderRadius = 23;
            this.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameBox.DefaultText = "";
            this.UsernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.UsernameBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameBox.Location = new System.Drawing.Point(550, 69);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.Size = new System.Drawing.Size(366, 49);
            this.UsernameBox.TabIndex = 14;
            // 
            // OldBox
            // 
            this.OldBox.Animated = true;
            this.OldBox.AutoRoundedCorners = true;
            this.OldBox.BorderColor = System.Drawing.Color.Black;
            this.OldBox.BorderRadius = 23;
            this.OldBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldBox.DefaultText = "";
            this.OldBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OldBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OldBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.OldBox.ForeColor = System.Drawing.Color.Black;
            this.OldBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldBox.Location = new System.Drawing.Point(172, 305);
            this.OldBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.OldBox.Name = "OldBox";
            this.OldBox.PasswordChar = '\0';
            this.OldBox.PlaceholderText = "Confirm Password";
            this.OldBox.SelectedText = "";
            this.OldBox.Size = new System.Drawing.Size(366, 49);
            this.OldBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label5.Location = new System.Drawing.Point(253, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Confirm Password";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(571, 314);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(77, 35);
            this.guna2ToggleSwitch1.TabIndex = 28;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.label6.Location = new System.Drawing.Point(654, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Change Password";
            // 
            // changePass
            // 
            this.changePass.Location = new System.Drawing.Point(134, 126);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(819, 146);
            this.changePass.TabIndex = 30;
            this.changePass.Visible = false;
            this.changePass.VisibleChanged += new System.EventHandler(this.ChangePass_VisibleChanged);
            // 
            // ChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OldBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password2Box);
            this.Controls.Add(this.Password1Box);
            this.Controls.Add(this.changePass);
            this.Name = "ChangeUserPassword";
            this.Size = new System.Drawing.Size(1064, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox IDBox;
        private Guna.UI2.WinForms.Guna2Button CreateBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2TextBox Password2Box;
        private Guna.UI2.WinForms.Guna2TextBox Password1Box;
        private Guna.UI2.WinForms.Guna2TextBox UsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox OldBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel changePass;
    }
}
