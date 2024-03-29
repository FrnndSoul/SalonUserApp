using MySql.Data.MySqlClient;
using SalonUserApp.Class_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class CheckAppointmentStatus : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public CheckAppointmentStatus()
        {
            InitializeComponent();
            ReadUserData.LoadAppointmentsFLP(AppointFLP);
        }


        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void CancelAppointment(string refNumber)
        {
            string query = "UPDATE Appointments SET IsCancelled = 'YES' WHERE ReferenceNumber = @ReferenceNumber";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferenceNumber", refNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment canceled");
                            ReadUserData.LoadAppointmentsFLP(AppointFLP);
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
