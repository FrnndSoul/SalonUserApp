using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Tls;
using SalonUserApp.User_Controls;
using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalonUserApp.Class_Components
{
    internal class Appoint
    {
        public static string cUsername, cName, cNumber, cAge,
            serviceID, serviceName, serviceAmount, serviceTypeID, serviceVariationID;
        public static string dbDateFiled, dbAppointDate, dbUsername, dbName, dbPhoneNumber, dbAge,
            dbServicelD, dbServiceName, dbServiceAmount, dbServiceTypelD, dbServiceVariationlD, dbIsCancelled;
        public static DateTime appointDate;
        public static int ReferenceNumber;

        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static void Appointment()
        {
            DateTime today = DateTime.Today;
            DateTime appointmentDate = appointDate.Date;

            if (appointmentDate.Month < today.Month || (appointmentDate.Month == today.Month && appointmentDate.Day <= today.Day))
            {
                MessageBox.Show("Please select a valid Date.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (appointDate.Hour < 11 || appointDate.Hour >= 19)
            {
                MessageBox.Show("Please select a valid time between 11:00 and 19:00.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show
                ("Please confirm the following details:\n\n" +
                $"Appointment Date and Time: {appointDate}\n\n" +
                "Customer Information\n" +
                $"   Name: {cName}\n" +
                $"   Username: {cUsername}\n" +
                $"   Phone Number: {cNumber}\n" +
                $"   Age: {cAge}\n\n" +
                "Service Information\n" +
                $"   Service: {serviceName}\n" +
                $"   ServiceID: {serviceID}\n" +
                $"   Amount: {serviceAmount}\n\n" +
                $"Confirm appointment?", "Confirmation", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    string query = "INSERT INTO Appointments (ReferenceNumber, AppointDate, Username, Name, PhoneNumber, Age, ServiceID, ServiceName, ServiceAmount, ServiceTypeID, ServiceVariationID) VALUES " +
                                                "(@ReferenceNumber, @AppointDate, @Username, @Name, @PhoneNumber, @Age, @ServiceID, @ServiceName, @ServiceAmount, @ServiceTypeID, @ServiceVariationID)";
                    
                    using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            ReferenceNumber = AppointNumber();
                            command.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber);
                            command.Parameters.AddWithValue("@AppointDate", appointDate);
                            command.Parameters.AddWithValue("@Username", cUsername);
                            command.Parameters.AddWithValue("@Name", cName);
                            command.Parameters.AddWithValue("@PhoneNumber", cNumber);
                            command.Parameters.AddWithValue("@Age", cAge);
                            command.Parameters.AddWithValue("@ServiceID", serviceID);
                            command.Parameters.AddWithValue("@ServiceName", serviceName);
                            command.Parameters.AddWithValue("@ServiceAmount", serviceAmount);
                            command.Parameters.AddWithValue("@ServiceTypeID", serviceTypeID);
                            command.Parameters.AddWithValue("@ServiceVariationID", serviceVariationID);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Appointment booked!\n\nHere is your reference number: {ReferenceNumber}", "Thank you!");

                                foreach (Control control in MainForm.mainFormInstance.Controls)
                                {
                                    if (control is Information || control is AppointmentDate)
                                    {
                                        control.Dispose();
                                    }
                                }

                                MainForm.ShowHomePage();
                            }
                            else
                            {
                                MessageBox.Show("Failed to book appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void SetUserInfo(string name, string number, string age)
        {
            cName = name;
            cNumber = number;
            cAge = age;
        }

        public static void SetUsername(string username)
        {
            cUsername = username;
        }

        public static void SetServiceInfo(string sID, string sName, string sAmount, string sTypeID, string sVariationID)
        {
            serviceID = sID;
            serviceName = sName;
            serviceAmount = sAmount;
            serviceTypeID = sTypeID;
            serviceVariationID = sVariationID;
        }

        public static void SetAppointYearMonth(string month, string year)
        {
            int monthValue = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            int yearValue = int.Parse(year);

            appointDate = appointDate.AddMonths(monthValue - appointDate.Month);
            appointDate = appointDate.AddYears(yearValue - appointDate.Year);
        }

        public static void SetAppointDay(string day)
        {
            int dayValue = int.Parse(day);
            appointDate = appointDate.AddDays(dayValue - appointDate.Day);
        }

        public static void SetAppointHour(string hour)
        {
            string[] parts = hour.Split(':');
            int hourValue = int.Parse(parts[0]);
            appointDate = appointDate.AddHours(hourValue - appointDate.Hour);
        }

        public static int AppointNumber() 
        {
            Random random = new Random();

            int number = random.Next(10000000, 99999999); // Generates a number between 10000000 and 99999999
            return number;
        }

        public static async Task ReadAppointData(string refNumber)
        {
            await Task.Run(() =>
            {
                ReferenceNumber = Convert.ToInt32(refNumber);
                string query = @"SELECT `ReferenceNumber`, `DateFiled`, `AppointDate`, `Username`, `Name`, 
                        `PhoneNumber`, `Age`, `ServiceID`, `ServiceName`, `ServiceAmount`,  
                        `ServiceTypeID`, `ServiceVariationID`, `IsCancelled` 
                        FROM `Appointments` WHERE `ReferenceNumber` = @dbReferenceNumber";

                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dbReferenceNumber", refNumber);
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

                                    MainForm.mainFormInstance.Invoke((MethodInvoker)(() =>
                                    {
                                        foreach (Control control in MainForm.mainFormInstance.Controls)
                                        {
                                            if (!(control is ChangeAppointInfo))
                                            {
                                                continue;
                                            }
                                            ChangeAppointInfo appointInfoControl = (ChangeAppointInfo)control;
                                            appointInfoControl.SetStrings(refNumber, dbDateFiled, dbAppointDate, dbUsername, dbName, dbPhoneNumber, dbAge, dbServicelD, dbServiceName, dbServiceAmount, dbServiceTypelD, dbServiceVariationlD, dbIsCancelled);
                                        }
                                    }));
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

        public static async void EditAppointment()
        {
            DateTime today = DateTime.Today;
            DateTime appointmentDate = appointDate.Date; 

            if (appointmentDate.Month < today.Month || (appointmentDate.Month == today.Month && appointmentDate.Day <= today.Day))
            {
                MessageBox.Show("Please select a valid Date.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (appointDate.Hour < 11 || appointDate.Hour >= 19)
            {
                MessageBox.Show("Please select a valid time between 11:00 and 19:00.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show
                ("Please confirm the following details with changes:\n\n" +
                $"Appointment Date and Time: {appointDate}\n\n" +
                "Customer Information\n" +
                $"   Name: {cName}\n" +
                $"   Username: {cUsername}\n" +
                $"   Phone Number: {cNumber}\n" +
                $"   Age: {cAge}\n\n" +
                "Service Information\n" +
                $"   Service: {serviceName}\n" +
                $"   ServiceID: {serviceID}\n" +
                $"   Amount: {serviceAmount}\n\n" +
                $"Confirm appointment?", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                try
                {
                    string query = "UPDATE Appointments SET AppointDate = @AppointDate, Username = @Username, Name = @Name, PhoneNumber = @PhoneNumber, Age = @Age, " +
                                   "ServiceID = @ServiceID, ServiceName = @ServiceName, ServiceAmount = @ServiceAmount, ServiceTypeID = @ServiceTypeID, " +
                                   "ServiceVariationID = @ServiceVariationID WHERE ReferenceNumber = @ReferenceNumber";

                    using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                    {
                        await connection.OpenAsync();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@AppointDate", appointDate);
                            command.Parameters.AddWithValue("@Username", cUsername);
                            command.Parameters.AddWithValue("@Name", cName);
                            command.Parameters.AddWithValue("@PhoneNumber", cNumber);
                            command.Parameters.AddWithValue("@Age", cAge);
                            command.Parameters.AddWithValue("@ServiceID", serviceID);
                            command.Parameters.AddWithValue("@ServiceName", serviceName);
                            command.Parameters.AddWithValue("@ServiceAmount", serviceAmount);
                            command.Parameters.AddWithValue("@ServiceTypeID", serviceTypeID);
                            command.Parameters.AddWithValue("@ServiceVariationID", serviceVariationID);
                            command.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber);

                            int rowsAffected = await command.ExecuteNonQueryAsync();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Appointment edited!\n\nSame Reference Number: {ReferenceNumber}", "Thank you!");
                                SetUserInfo(null, null, null);
                                SetServiceInfo(null, null, null, null, null);
                                foreach (Control control in MainForm.mainFormInstance.Controls)
                                {
                                    if (control is Information || control is AppointmentDate)
                                    {
                                        control.Dispose();
                                    }
                                }

                                MainForm.ShowHomePage();
                            }
                            else
                            {
                                MessageBox.Show("Failed to edit appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void EditAppointRefnum(string refNumber)
        {
            ReferenceNumber = Convert.ToInt32(refNumber);
        }

        public static void ViewAppointmentDetails()
        {
            MessageBox.Show
                ($"Reference Number:{ReferenceNumber}\n\n" +
                $"Appointment Date and Time: {appointDate}\n\n" +
                "Customer Information\n" +
                $"   Name: {cName}\n" +
                $"   Username: {cUsername}\n" +
                $"   Phone Number: {cNumber}\n" +
                $"   Age: {cAge}\n\n" +
                "Service Information\n" +
                $"   Service: {serviceName}\n" +
                $"   ServiceID: {serviceID}\n" +
                $"   Amount: {serviceAmount}\n\n" , "View Appointment Details"
               );
        }
    }
}
