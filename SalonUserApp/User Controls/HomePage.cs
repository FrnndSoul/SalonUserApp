using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls
{
    public partial class HomePage : UserControl
    {
        CheckAppointmentStatus checkStatusControl;

        public HomePage()
        {
            InitializeComponent();
            checkStatusControl = new CheckAppointmentStatus();
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Dispose();
            MainForm.ShowAppointInfo();
        }

        private async void CheckStatusBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            if (this.Controls.Find("CheckAppointmentStatus", true).Length == 0)
            {
                checkStatusControl.Location = new Point(0, 200);
                this.Controls.Add(checkStatusControl);
                checkStatusControl.BringToFront();
            }
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
        }
    }
}