using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using SalonUserApp.Class_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class ChangeAppointInfo : UserControl
    {
        public ChangeAppointInfo()
        {
            InitializeComponent();
            Appoint.SetUserInfo(null, null, null);
            Appoint.SetServiceInfo(null, null, null, null, null, null);
        }

        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        private Panel currentlyHighlightedPanel = null;

        public static string FullName, Username, PhoneNumber, Age, serviceID, serviceName, serviceAmount, serviceTypeID, serviceVariationID;

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = NumberBox.Text;
            int length = text.Length;

            if (char.IsDigit(e.KeyChar))
            {
                if (length >= 11)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void AgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = AgeBox.Text;
            int length = text.Length;

            if (char.IsDigit(e.KeyChar))
            {
                if (length >= 2)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public static string cRefNumber, cDateFiled, cAppointDate, cUsername, cName, cPhoneNumber, cAge, cServicelD, cServiceName, cServiceAmount, cDownPayment, ServiceTypelD, cServiceVariationlD, cIsCancelled;

        private void ChangeDateBtn_Click(object sender, EventArgs e)
        {
            Appoint.EditAppointRefnum(cRefNumber);
            Appoint.SetUserInfo(NameBox.Text, NumberBox.Text, AgeBox.Text);
            Appoint.SetServiceInfo(cServicelD, cServiceName, cServiceAmount, cDownPayment,ServiceTypelD, cServiceVariationlD);
            this.Visible = false;
            MainForm.ShowAppointDate();
        }

        public bool IsPhoneNumberValid()
        {
            string number = NumberBox.Text;
            if (number[0] == '0' && number[1] == '9' && number.Length == 11)
            {
                return true;
            }
            return false;
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(AgeBox.Text) || string.IsNullOrEmpty(NumberBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsPhoneNumberValid())
            {
                MessageBox.Show("Phone number must be valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await Task.Delay(1000);
            DialogResult result = MessageBox.Show
                ("Please confirm the following details with changes:\n\n" +
                "Customer Information\n" +
                $"   Name: {NameBox.Text}\n" +
                $"   Phone Number: {NumberBox.Text}\n" + 
                $"   Age: {AgeBox.Text}\n\n" +
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
                    string query = "UPDATE Appointments SET " +
                           "Name = @Name, " +
                           "PhoneNumber = @PhoneNumber, " +
                           "Age = @Age, " +
                           "ServiceID = @ServiceID, " +
                           "ServiceName = @ServiceName, " +
                           "ServiceAmount = @ServiceAmount, " +
                           "ServiceTypeID = @ServiceTypeID, " +
                           "ServiceVariationID = @ServiceVariationID " +
                           "WHERE ReferenceNumber = @ReferenceNumber";


                    using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", NameBox.Text);
                            command.Parameters.AddWithValue("@PhoneNumber", NumberBox.Text);
                            command.Parameters.AddWithValue("@Age", AgeBox.Text);
                            command.Parameters.AddWithValue("@ServiceID", serviceID);
                            command.Parameters.AddWithValue("@ServiceName", serviceName);
                            command.Parameters.AddWithValue("@ServiceAmount", serviceAmount);
                            command.Parameters.AddWithValue("@ServiceTypeID", serviceTypeID);
                            command.Parameters.AddWithValue("@ServiceVariationID", serviceVariationID);
                            command.Parameters.AddWithValue("@ReferenceNumber", cRefNumber);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Appointment edited!\n\nSame Reference Number: {cRefNumber}", "Thank you!");
                                Appoint.SetUserInfo(null, null, null);
                                Appoint.SetServiceInfo(null, null, null, null, null, null);
                                foreach (Control control in MainForm.mainFormInstance.Controls)
                                {
                                    if (control is Information || control is AppointmentDate)
                                    {
                                        control.Parent.Controls.Remove(control);
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

        private void DiscardBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            MainForm.ShowHomePage();
        }

        public void SetStrings(string refnum, string fdate, string adate, string user, string name, string num, string age, string servid, string servname, string servamount, string servtid, string servvid, string cancelled)
        {
            cRefNumber = refnum;
            cDateFiled = fdate;
            cAppointDate = adate;
            cUsername = user;
            cName = name;
            cPhoneNumber = num;
            cAge = age;
            cServicelD = servid;
            cServiceName = servname;
            cServiceAmount = servamount;
            ServiceTypelD = servtid;
            cServiceVariationlD = servvid;
            cIsCancelled = cancelled;

            ReferenceBox.Text = refnum;
            NameBox.Text = name;
            NumberBox.Text = num;
            AgeBox.Text = age;
            AppointDateBox.Text = adate;
            GetServiceData();
        }

        public void GetServiceData()
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceName, ServiceImage, ServiceAmount, ServiceTypeID, ServiceVariationID FROM salon_services"; //database table

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 210,
                                    Height = 250,
                                    BackColor = Color.White,
                                    Tag = reader["ServiceTypeID"].ToString(),
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceName"].ToString(),
                                    Location = new Point(10, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 12, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle1 = new Label
                                {
                                    Text = reader["ServiceAmount"].ToString(),
                                    Location = new Point(10, labelTitle.Bottom + 25),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                PictureBox picBox = new PictureBox
                                {
                                    Width = 185,
                                    Height = 150,
                                    Location = new Point(10, 10),
                                    BackgroundImage = servicetypeImage,
                                    BackgroundImageLayout = ImageLayout.Stretch,
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle2 = new Label
                                {
                                    Text = reader["ServiceTypeID"].ToString(),
                                    Location = new Point(190, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                Label labelTitle3 = new Label
                                {
                                    Text = reader["ServiceVariationID"].ToString(),
                                    Location = new Point(280, 160),
                                    ForeColor = Color.Black,
                                    AutoSize = true,
                                    Font = new Font("Stanberry", 16, FontStyle.Regular),
                                    Tag = reader["ServiceTypeID"].ToString()
                                };

                                void clickHandler(object sender, EventArgs e)
                                {
                                    serviceID = ((Control)sender).Tag.ToString();
                                    serviceName = labelTitle.Text;
                                    serviceAmount = labelTitle1.Text;
                                    serviceTypeID = labelTitle2.Text;
                                    serviceVariationID = labelTitle3.Text;

                                    if (currentlyHighlightedPanel != null)
                                    {
                                        currentlyHighlightedPanel.BackColor = Color.White;
                                    }
                                    panel.BackColor = Color.LightGray;
                                    currentlyHighlightedPanel = panel;
                                }

                                panel.Click += clickHandler;
                                picBox.Click += clickHandler;
                                panel.Controls.Add(picBox);
                                panel.Controls.Add(labelTitle);
                                panel.Controls.Add(labelTitle1);
                                ServiceFLP.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }
    }
}
