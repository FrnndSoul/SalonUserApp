namespace SalonUserApp.User_Controls.Appointment_Folder
{
    partial class CheckAppointmentStatus
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
            this.AppointFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AppointFLP
            // 
            this.AppointFLP.AutoScroll = true;
            this.AppointFLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AppointFLP.Location = new System.Drawing.Point(3, 3);
            this.AppointFLP.Name = "AppointFLP";
            this.AppointFLP.Size = new System.Drawing.Size(1058, 475);
            this.AppointFLP.TabIndex = 0;
            // 
            // CheckAppointmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.AppointFLP);
            this.Name = "CheckAppointmentStatus";
            this.Size = new System.Drawing.Size(1064, 481);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AppointFLP;
    }
}
