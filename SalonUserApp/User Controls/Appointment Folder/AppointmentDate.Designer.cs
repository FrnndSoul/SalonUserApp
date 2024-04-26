namespace SalonUserApp.User_Controls.Appointment_Folder
{
    partial class AppointmentDate
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
            this.nextMon = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.prevMon = new Guna.UI2.WinForms.Guna2Button();
            this.CalendarFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MosYrLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Next = new Guna.UI2.WinForms.Guna2Button();
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.TimeFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // nextMon
            // 
            this.nextMon.AutoRoundedCorners = true;
            this.nextMon.BackColor = System.Drawing.Color.Transparent;
            this.nextMon.BorderRadius = 21;
            this.nextMon.BorderThickness = 1;
            this.nextMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nextMon.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMon.ForeColor = System.Drawing.Color.Black;
            this.nextMon.Location = new System.Drawing.Point(396, 575);
            this.nextMon.Name = "nextMon";
            this.nextMon.Size = new System.Drawing.Size(180, 45);
            this.nextMon.TabIndex = 31;
            this.nextMon.Text = ">>";
            this.nextMon.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Saturday";
            // 
            // prevMon
            // 
            this.prevMon.AutoRoundedCorners = true;
            this.prevMon.BackColor = System.Drawing.Color.Transparent;
            this.prevMon.BorderRadius = 21;
            this.prevMon.BorderThickness = 1;
            this.prevMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.prevMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.prevMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.prevMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.prevMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.prevMon.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevMon.ForeColor = System.Drawing.Color.Black;
            this.prevMon.Location = new System.Drawing.Point(29, 575);
            this.prevMon.Name = "prevMon";
            this.prevMon.Size = new System.Drawing.Size(180, 45);
            this.prevMon.TabIndex = 0;
            this.prevMon.Text = "<<";
            this.prevMon.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CalendarFLP
            // 
            this.CalendarFLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalendarFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalendarFLP.Location = new System.Drawing.Point(29, 97);
            this.CalendarFLP.Name = "CalendarFLP";
            this.CalendarFLP.Size = new System.Drawing.Size(547, 472);
            this.CalendarFLP.TabIndex = 30;
            this.CalendarFLP.Paint += new System.Windows.Forms.PaintEventHandler(this.CalendarFLP_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Friday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sunday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Thursday";
            // 
            // MosYrLbl
            // 
            this.MosYrLbl.AutoSize = true;
            this.MosYrLbl.BackColor = System.Drawing.Color.Transparent;
            this.MosYrLbl.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MosYrLbl.Location = new System.Drawing.Point(238, 33);
            this.MosYrLbl.Name = "MosYrLbl";
            this.MosYrLbl.Size = new System.Drawing.Size(157, 29);
            this.MosYrLbl.TabIndex = 29;
            this.MosYrLbl.Text = "Month Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Wednesday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Monday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Chinacat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tuesday";
            // 
            // Next
            // 
            this.Next.AutoRoundedCorners = true;
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BorderRadius = 21;
            this.Next.BorderThickness = 1;
            this.Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Next.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(858, 575);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(180, 45);
            this.Next.TabIndex = 40;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.AutoRoundedCorners = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BorderRadius = 21;
            this.Back.BorderThickness = 1;
            this.Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Back.Font = new System.Drawing.Font("Chinacat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(645, 575);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(180, 45);
            this.Back.TabIndex = 39;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TimeFLP
            // 
            this.TimeFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TimeFLP.Location = new System.Drawing.Point(645, 78);
            this.TimeFLP.Name = "TimeFLP";
            this.TimeFLP.Size = new System.Drawing.Size(393, 480);
            this.TimeFLP.TabIndex = 41;
            // 
            // AppointmentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.TimeFLP);
            this.Controls.Add(this.CalendarFLP);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.nextMon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prevMon);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MosYrLbl);
            this.Controls.Add(this.label4);
            this.Name = "AppointmentDate";
            this.Size = new System.Drawing.Size(1064, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MosYrLbl;
        private System.Windows.Forms.FlowLayoutPanel CalendarFLP;
        private Guna.UI2.WinForms.Guna2Button prevMon;
        private Guna.UI2.WinForms.Guna2Button nextMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button Next;
        private Guna.UI2.WinForms.Guna2Button Back;
        private System.Windows.Forms.FlowLayoutPanel TimeFLP;
    }
}
