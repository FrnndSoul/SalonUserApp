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

namespace SalonUserApp.User_Controls
{
    public partial class SigninPage : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public SigninPage()
        {
            InitializeComponent();
            PasswordBox.PasswordChar = '*';
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
            }
        }

        private async void SigninBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input username and password", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ReadUserData.LoginUser(username, password, this);
        }

        private void CreateAccountBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ID = GenerateID();
            IDBox.Text = ID.ToString();
            CreatePanel.BringToFront();
            ClearFields();
        }
        public static int GenerateID()
        {
            Random random = new Random();
            int Ref;
            do
            {
                Ref = random.Next(10000, 100000);
            } while (DuplicateChecker(Ref.ToString(), "AccountID", "accounts"));
            return Ref;
        }

        public void ClearFields()
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            UsernameBoxcrt.Text = string.Empty;
            Password1Box.Text = string.Empty;
            Password2Box.Text = string.Empty;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
            SigninPanel.BringToFront();
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBoxcrt.Text;
            string pass1 = Password1Box.Text;
            string pass2 = Password2Box.Text;
            string id = IDBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DuplicateChecker(username, "Username", "accounts"))
            {
                MessageBox.Show("Username already taken.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await ReadUserData.Registeruser(username, pass1, id);
                MessageBox.Show("Account created successfully.", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackBtn_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool DuplicateChecker(string Data, string Column, string Table)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM {Table} WHERE {Column} = @data";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@data", Data);
                        int count = Convert.ToInt32(querycmd.ExecuteScalar());
                        return count != 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"SQL ERROR in DuplicateChecker(): {e.Message}", "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                Password1Box.PasswordChar = '\0';
                Password2Box.PasswordChar = '\0';
            }
            else
            {
                Password1Box.PasswordChar = '*';
                Password2Box.PasswordChar = '*';
            }
        }
    }
}
