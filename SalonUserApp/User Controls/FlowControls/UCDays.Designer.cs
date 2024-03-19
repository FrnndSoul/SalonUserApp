namespace SalonUserApp.User_Controls.Appointment_Folder
{
    partial class UCDays
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
            this.DaysLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DaysLbl
            // 
            this.DaysLbl.AutoSize = true;
            this.DaysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLbl.Location = new System.Drawing.Point(13, 20);
            this.DaysLbl.Name = "DaysLbl";
            this.DaysLbl.Size = new System.Drawing.Size(47, 33);
            this.DaysLbl.TabIndex = 0;
            this.DaysLbl.Text = "00";
            this.DaysLbl.Click += new System.EventHandler(this.DaysLbl_Click);
            // 
            // UCDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DaysLbl);
            this.Name = "UCDays";
            this.Size = new System.Drawing.Size(72, 72);
            this.Click += new System.EventHandler(this.UCDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DaysLbl;
    }
}
