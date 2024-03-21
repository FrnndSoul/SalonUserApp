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
            this.Cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Reschedulebtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Animated = true;
            this.Cancelbtn.AutoRoundedCorners = true;
            this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.BorderRadius = 21;
            this.Cancelbtn.BorderThickness = 1;
            this.Cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancelbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Cancelbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.Black;
            this.Cancelbtn.Location = new System.Drawing.Point(565, 51);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(210, 45);
            this.Cancelbtn.TabIndex = 0;
            this.Cancelbtn.Text = "Cancel";
            // 
            // Reschedulebtn
            // 
            this.Reschedulebtn.Animated = true;
            this.Reschedulebtn.AutoRoundedCorners = true;
            this.Reschedulebtn.BackColor = System.Drawing.Color.Transparent;
            this.Reschedulebtn.BorderRadius = 21;
            this.Reschedulebtn.BorderThickness = 1;
            this.Reschedulebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reschedulebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reschedulebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reschedulebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reschedulebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Reschedulebtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reschedulebtn.ForeColor = System.Drawing.Color.Black;
            this.Reschedulebtn.Location = new System.Drawing.Point(565, 102);
            this.Reschedulebtn.Name = "Reschedulebtn";
            this.Reschedulebtn.Size = new System.Drawing.Size(210, 45);
            this.Reschedulebtn.TabIndex = 1;
            this.Reschedulebtn.Text = "Reschedule";
            // 
            // AppointInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Reschedulebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Name = "AppointInfo";
            this.Size = new System.Drawing.Size(800, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Cancelbtn;
        private Guna.UI2.WinForms.Guna2Button Reschedulebtn;
    }
}
