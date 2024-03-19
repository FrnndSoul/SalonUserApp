using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Tls;
using SalonUserApp.User_Controls;
using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        public static DateTime appointDate;
        public static int ReferenceNumber;

        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static void Appointment()
        {

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
            // Parse the month name to its corresponding numerical value
            int monthValue = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            int yearValue = int.Parse(year);

            // Set the appointDate's month and year
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
            int minuteValue = int.Parse(parts[1]);

            appointDate = appointDate.AddHours(hourValue - appointDate.Hour);
        }


        public static int AppointNumber() 
        {
            Random random = new Random();

            int number = random.Next(10000000, 99999999); // Generates a number between 10000000 and 99999999

            return number;
        }
    }
}
