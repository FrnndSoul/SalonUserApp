namespace SalonUserApp.User_Controls.Appointment_Folder
{
    partial class TimeUC
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
        public void InitializeComponent()
        {
            this.Timelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Timelbl.Location = new System.Drawing.Point(56, 29);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(76, 29);
            this.Timelbl.TabIndex = 0;
            this.Timelbl.Text = "00:00";
            this.Timelbl.Click += new System.EventHandler(this.Timelbl_Click);
            // 
            // TimeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Timelbl);
            this.Name = "TimeUC";
            this.Size = new System.Drawing.Size(190, 90);
            this.Click += new System.EventHandler(this.TimeUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Timelbl;
    }
}
