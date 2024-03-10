namespace SalonUserApp.User_Controls
{
    partial class SigninPage
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
            this.UsernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SigninBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CreateAccountBtn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            this.UsernameBox.Location = new System.Drawing.Point(73, 186);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.Size = new System.Drawing.Size(353, 49);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Animated = true;
            this.PasswordBox.AutoRoundedCorners = true;
            this.PasswordBox.BorderColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderRadius = 23;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.DefaultText = "";
            this.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.PasswordBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordBox.Location = new System.Drawing.Point(73, 241);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.Size = new System.Drawing.Size(353, 49);
            this.PasswordBox.TabIndex = 1;
            // 
            // SigninBtn
            // 
            this.SigninBtn.Animated = true;
            this.SigninBtn.AutoRoundedCorners = true;
            this.SigninBtn.BackColor = System.Drawing.Color.Transparent;
            this.SigninBtn.BorderRadius = 21;
            this.SigninBtn.BorderThickness = 1;
            this.SigninBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SigninBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SigninBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SigninBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SigninBtn.Font = new System.Drawing.Font("Chinacat", 18F);
            this.SigninBtn.ForeColor = System.Drawing.Color.White;
            this.SigninBtn.Location = new System.Drawing.Point(73, 382);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(180, 45);
            this.SigninBtn.TabIndex = 2;
            this.SigninBtn.Text = "Sign in";
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.ShowPass.CheckedState.BorderRadius = 0;
            this.ShowPass.CheckedState.BorderThickness = 1;
            this.ShowPass.CheckedState.FillColor = System.Drawing.Color.White;
            this.ShowPass.CheckMarkColor = System.Drawing.Color.DarkRed;
            this.ShowPass.Font = new System.Drawing.Font("Chinacat", 15.75F);
            this.ShowPass.Location = new System.Drawing.Point(73, 296);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(196, 29);
            this.ShowPass.TabIndex = 3;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.ShowPass.UncheckedState.BorderRadius = 0;
            this.ShowPass.UncheckedState.BorderThickness = 1;
            this.ShowPass.UncheckedState.FillColor = System.Drawing.Color.White;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.ActiveLinkColor = System.Drawing.Color.Pink;
            this.CreateAccountBtn.AutoSize = true;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Chinacat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountBtn.Location = new System.Drawing.Point(167, 532);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(165, 19);
            this.CreateAccountBtn.TabIndex = 4;
            this.CreateAccountBtn.TabStop = true;
            this.CreateAccountBtn.Text = "Create an Account";
            this.CreateAccountBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountBtn_LinkClicked);
            // 
            // SigninPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Name = "SigninPage";
            this.Size = new System.Drawing.Size(1080, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UsernameBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordBox;
        private Guna.UI2.WinForms.Guna2Button SigninBtn;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPass;
        private System.Windows.Forms.LinkLabel CreateAccountBtn;
    }
}
