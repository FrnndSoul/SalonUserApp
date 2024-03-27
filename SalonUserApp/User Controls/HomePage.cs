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
        private const int Y = 200;
        readonly CheckAppointmentStatus checkStatusControl;

        public HomePage()
        {
            InitializeComponent();
            checkStatusControl = new CheckAppointmentStatus();
        }

        private async void Guna2Button4_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Parent.Controls.Remove(this);
            MainForm.ShowAppointInfo();
        }

        private async void CheckStatusBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            if (this.Controls.Find("CheckAppointmentStatus", true).Length == 0)
            {
                checkStatusControl.Location = new Point(0, Y);
                this.Controls.Add(checkStatusControl);
                checkStatusControl.BringToFront();
            }
        }

        private async void Guna2Button3_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
        }

        private async void LogoutBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Parent.Controls.Remove(this);
            MainForm.ShowSignin();
        }
    }
}