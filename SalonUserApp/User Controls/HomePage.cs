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
        readonly CheckAppointmentStatus checkAppointment;
        readonly ChangeUserPassword changeUserPassword;

        public HomePage()
        {
            InitializeComponent();

            checkAppointment = new CheckAppointmentStatus();
            changeUserPassword = new ChangeUserPassword();
        }

        private async void Guna2Button4_Click(object sender, EventArgs e) //sched an appoint
        {
            await Task.Delay(500);
            foreach (Control control in Controls)
            {
                if (control is ChangeUserPassword)
                {
                    changeUserPassword.Parent.Controls.Remove(changeUserPassword);
                    break;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is CheckAppointmentStatus)
                {
                    checkAppointment.Parent.Controls.Remove(changeUserPassword);
                    break;
                }
            }
            MainForm.ShowAppointInfo();
        }

        private async void CheckStatusBtn_Click(object sender, EventArgs e) //check status
        {
            await Task.Delay(500);
            foreach (Control control in Controls)
            {
                if (control is ChangeUserPassword)
                {
                    changeUserPassword.Parent.Controls.Remove(changeUserPassword);
                    break;
                }
            }
            this.Controls.Add(checkAppointment);
            checkAppointment.Location = new Point(0, 200);
            checkAppointment.BringToFront();
        }


        private async void Guna2Button3_Click(object sender, EventArgs e) //change pass
        {
            await Task.Delay(500);
            foreach (Control control in Controls)
            {
                if (control is CheckAppointmentStatus)
                {
                    checkAppointment.Parent.Controls.Remove(checkAppointment);
                    break;
                }
            }
            this.Controls.Add(changeUserPassword);
            changeUserPassword.Location = new Point(0, 200);
            changeUserPassword.BringToFront();
        }

        private async void LogoutBtn_Click(object sender, EventArgs e) //logout
        {
            await Task.Delay(500);
            foreach (Control control in Controls)
            {
                if (control is ChangeUserPassword)
                {
                    changeUserPassword.Parent.Controls.Remove(changeUserPassword);
                    break;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is CheckAppointmentStatus)
                {
                    checkAppointment.Parent.Controls.Remove(changeUserPassword);
                    break;
                }
            }
            MainForm.ShowSignin();
        }
    }
}