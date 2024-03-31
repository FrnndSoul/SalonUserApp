using MySql.Data.MySqlClient;
using SalonUserApp.Class_Components;
using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SalonUserApp.User_Controls.FlowControls
{
    public partial class AppointInfo : UserControl
    {
        public static string dbReferenceNumber, dbDateFiled, dbAppointDate, dbUsername, dbName, dbPhoneNumber, dbAge,
            dbServicelD, dbServiceName, dbServiceAmount, dbServiceTypelD, dbServiceVariationlD, dbIsCancelled;
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public AppointInfo()
        {
            InitializeComponent();
        }

        private async void CheckStatusBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            ShowInputDialog(RefTextLabel.Text);
        }

        private async void ShowInputDialog(string refNumber)
        {
            await Task.Delay(500);
            Form promptForm = new Form()
            {
                Width = 300,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Choose an Action",
                StartPosition = FormStartPosition.CenterScreen
            };

            Font font = new Font("Chinacat", 10);

            Label textLabel = new Label() { 
                Left = 20, 
                Top = 20,
                Height = 50,
                Width = 260,
                Text = $"Reference number:\n{refNumber}", 
                Font = font, 
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button view = new Button() {
                Text = "View",
                Left = 20, 
                Width = 260, 
                Top = 70, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button change = new Button() { 
                Text = "Change", 
                Left = 20,
                Width = 260,
                Top = 105, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button cancel = new Button() { 
                Text = "Cancel", 
                Left = 20,
                Width = 260,
                Top = 140, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button none = new Button() { 
                Text = "None", 
                Left = 20,
                Width = 260,
                Top = 175, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter
            };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(view);
            promptForm.Controls.Add(change);
            promptForm.Controls.Add(cancel);
            promptForm.Controls.Add(none);

            view.Click += async (sender, e) =>
            {
                await Task.Delay(500);
                promptForm.Close(); 
                await Appoint.ReadAppointData(RefTextLabel.Text);
                Appoint.ViewAppointmentDetails();

            };

            change.Click += async (sender, e) => 
            {
                DateTime.TryParse(DateTextLabel.Text, out DateTime appointDate);
                if (appointDate <= DateTime.Now.AddDays(7))
                {
                    MessageBox.Show("You cannot make changes with the appointment.\n" +
                        "The Appointment is in 7 days grace period for\n" +
                        "changes and cancellation", "Warning");
                }
                else
                {
                    await Task.Delay(500);
                    promptForm.Close();
                    MainForm.ShowAppointEdit();
                    Appoint.ReadAppointData(RefTextLabel.Text);
                    this.Parent.Controls.Remove(this);
                }
            };

            cancel.Click += async (sender, e) =>
            {
                DateTime.TryParse(DateTextLabel.Text, out DateTime appointDate);
                if (appointDate <= DateTime.Now.AddDays(7))
                {
                    MessageBox.Show("You cannot make changes with the appointment.\n" +
                        "The Appointment is in 7 days grace period for\n" +
                        "changes and cancellation", "Warning");
                } else
                {
                    await Task.Delay(500);
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to cancel this appointment?\nReference number: {RefTextLabel.Text}",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        );

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }

                    foreach (Control control in MainForm.mainFormInstance.Controls)
                    {
                        if (control is CheckAppointmentStatus)
                        {
                            CheckAppointmentStatus checkAppointmentStatus = (CheckAppointmentStatus)control;
                            checkAppointmentStatus.CancelAppointment(RefTextLabel.Text);
                        }
                    }

                    promptForm.Close();
                }
            };

            none.Click += (sender, e) =>
            {
                promptForm.Close();
            };
            promptForm.ShowDialog();
        }
    }
}
