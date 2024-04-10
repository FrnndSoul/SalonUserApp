using MySql.Data.MySqlClient;
using SalonUserApp.Class_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls
{
    public partial class CreateAccountForm : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public CreateAccountForm()
        {
            InitializeComponent();
            Password1Box.PasswordChar = '*';
            Password2Box.PasswordChar = '*';
        }

        private async Task CreateBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string pass1 = Password1Box.Text;
            string pass2 = Password2Box.Text;
            string id = IDBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (await DuplicateChecker(username, "Username", "accounts"))
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm.ShowSignin();
        }

        private async void CreateAccountForm_Load(object sender, EventArgs e)
        {
            IDBox.Text = (await GenerateID()).ToString();
        }

        public static async Task<int> GenerateID()
        {
            Random random = new Random();
            int Ref;
            do
            {
                Ref = random.Next(10000, 100000);
            } while (await DuplicateChecker(Ref.ToString(), "AccountID", "accounts"));
            return Ref;
        }

        public static async Task<bool> DuplicateChecker(string Data, string Column, string Table)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    await connection.OpenAsync();
                    string query = $"SELECT COUNT(*) FROM {Table} WHERE {Column} = @data";
                    using (MySqlCommand querycmd = new MySqlCommand(query, connection))
                    {
                        querycmd.Parameters.AddWithValue("@data", Data);
                        int count = Convert.ToInt32(await querycmd.ExecuteScalarAsync());
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

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
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
