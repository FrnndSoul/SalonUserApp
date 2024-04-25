using SalonUserApp.User_Controls.Appointment_Folder;
using SalonUserApp.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonUserApp.Class_Components;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace SalonUserApp
{
    public partial class AppointmentDetailsForm : Form
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string dbDateFiled, dbAppointDate, dbUsername, dbName, dbPhoneNumber, dbAge,
            dbServicelD, dbServiceName, dbServiceAmount, dbDP, dbDPRef, dbServiceTypelD, dbServiceVariationlD, dbIsCancelled;
        public static int ReferenceNumber;

        public AppointmentDetailsForm()
        {
            InitializeComponent();
        }

        private void AppointmentDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private async void CancelBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to cancel this appointment?\nReference number: {RefBox.Text}",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            foreach (Control control in MainForm.mainFormInstance.Controls)
            {
                if (control is HomePage homepage)
                {
                    foreach (Control cont in homepage.Controls)
                    {
                        if (cont is CheckAppointmentStatus checkAppointmentStatus)
                        {
                            checkAppointmentStatus.CancelAppointment(RefBox.Text);
                        }
                        break;
                    }
                }
                break;
            }
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            MainForm.ShowAppointEdit();
            await Appoint.ReadAppointData(RefBox.Text);
            this.Close();
        }

        public async void loadRefnum(string refNumber)
        {
            RefBox.Text = refNumber;
            await DataLoad();
            UpdateUI();
        }

        public async Task DataLoad()
        {
            await Task.Run(() =>
            {
                string query = @"SELECT * FROM `Appointments` WHERE `ReferenceNumber` = @dbReferenceNumber";

                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dbReferenceNumber", RefBox.Text);
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
                                    dbServiceName = reader["ServiceName"].ToString();
                                    dbServiceAmount = reader["ServiceAmount"].ToString();
                                    dbDP = reader["Downpayment"].ToString();
                                    dbDPRef = reader["DPRefNumber"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error.");
                        }
                    }
                }
            });
        }

        private void UpdateUI()
        {
            FiledBox.Text = dbDateFiled;
            DateBox.Text = dbAppointDate;
            NameBox.Text = dbName;
            PhoneBox.Text = dbPhoneNumber;
            ServiceBox.Text = dbServiceName;
            AmountBox.Text = dbServiceAmount;
            DPBox.Text = dbDP;
            DPRef.Text = dbDPRef;
        }
    }
}
