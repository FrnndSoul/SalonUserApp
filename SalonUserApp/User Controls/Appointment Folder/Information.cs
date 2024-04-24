using MySql.Data.MySqlClient;
using Npgsql.Internal.Postgres;
using SalonUserApp.Class_Components;
using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls
{
    public partial class Information : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string serviceID, serviceName, serviceAmount, serviceTypeID, serviceVariationID;
        private Panel currentlyHighlightedPanel = null;

        public Information()
        {
            InitializeComponent();
            GetServiceData();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

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

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }

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

        public bool IsPhoneNumberValid()
        {
            string number = NumberBox.Text;
            if (number[0] == '0' && number[1] == '9' && number.Length == 11)
            {
                return true;
            }
            return false;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {











            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(AgeBox.Text) || string.IsNullOrEmpty(NumberBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPhoneNumberValid())
            {
                MessageBox.Show("Phone number must be valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentlyHighlightedPanel == null)
            {
                MessageBox.Show("Select a service first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Appoint.SetUserInfo(NameBox.Text, NumberBox.Text, AgeBox.Text);
            Appoint.SetServiceInfo(serviceID, serviceName, serviceAmount, serviceTypeID, serviceVariationID);
            this.Visible = false;
            MainForm.ShowAppointDate();
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
                                    double amountInDouble = double.Parse(labelTitle1.Text);
                                    double downpayment = amountInDouble * 0.2;
                                    downpayment = Math.Round(downpayment, 2);
                                    Feebox.Text = "PHP" + downpayment.ToString("0.00");
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

        private async void BackBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            Appoint.SetUserInfo(null, null, null);
            Appoint.SetServiceInfo(null, null, null, null, null);
            ServiceSelection.Visible = false;
            guna2GroupBox1.Visible = false;
            BackBtn.Visible = false;
            NextBtn.Visible = false;
            this.Parent.Controls.Remove(this);
            MainForm.ShowHomePage();
        }
    }
}
