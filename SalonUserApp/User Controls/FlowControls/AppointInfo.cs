using MySql.Data.MySqlClient;
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
            ReadAppointData();
            ShowInputDialog(dbReferenceNumber);
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
                TextAlign = ContentAlignment.MiddleCenter,
                DialogResult = DialogResult.OK
            };

            Button change = new Button() { 
                Text = "Change", 
                Left = 20,
                Width = 260,
                Top = 105, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter,
                DialogResult = DialogResult.OK
            };

            Button cancel = new Button() { 
                Text = "Cancel", 
                Left = 20,
                Width = 260,
                Top = 140, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter,
                DialogResult = DialogResult.OK
            };

            Button none = new Button() { 
                Text = "None", 
                Left = 20,
                Width = 260,
                Top = 175, 
                Height = 30, 
                Font = font,
                TextAlign = ContentAlignment.MiddleCenter,
                DialogResult = DialogResult.OK
            };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(view);
            promptForm.Controls.Add(change);
            promptForm.Controls.Add(cancel);
            promptForm.Controls.Add(none);

            view.Click += (sender, e) =>
            {
                promptForm.Close();
            };

            change.Click += (sender, e) => 
            { 
                promptForm.Close(); 
            };

            cancel.Click += (sender, e) =>
            {
                promptForm.Close();
            };

            none.Click += (sender, e) =>
            {
                promptForm.Close();
            };

            promptForm.ShowDialog();
        }

        private void ReadAppointData()
        {
            dbReferenceNumber = RefTextLabel.Text;

            string query = @"SELECT `ReferenceNumber`, `DateFiled`, `AppointDate`, `Username`, `Name`, 
                            `PhoneNumber`, `Age`, `ServiceID`, `ServiceName`, `ServiceAmount`,  
                            `ServiceTypeID`, `ServiceVariationID`, `IsCancelled` 
                            FROM `Appointments` WHERE `ReferenceNumber` = @dbReferenceNumber";

            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dbReferenceNumber", dbReferenceNumber);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (DateTime.TryParse(reader["DateFiled"].ToString(), out DateTime dateFiled))
                                {
                                    dbDateFiled = dateFiled.ToString("dd/MM/yyyy");
                                }

                                if (DateTime.TryParse(reader["AppointDate"].ToString(), out DateTime appointDate))
                                {
                                    dbAppointDate = appointDate.ToString("dd/MM/yyyy");
                                }

                                dbUsername = reader["Username"].ToString();
                                dbName = reader["Name"].ToString();
                                dbPhoneNumber = reader["PhoneNumber"].ToString();
                                dbAge = reader["Age"].ToString();
                                dbServicelD = reader["ServiceID"].ToString();
                                dbServiceName = reader["ServiceName"].ToString();
                                dbServiceAmount = reader["ServiceAmount"].ToString();
                                dbServiceTypelD = reader["ServiceTypeID"].ToString();
                                dbServiceVariationlD = reader["ServiceVariationID"].ToString();
                                dbIsCancelled = reader["IsCancelled"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.");
                    }
                }
            }
        }
    }
}
