using MySql.Data.MySqlClient;
using SalonUserApp.User_Controls;
using SalonUserApp.User_Controls.FlowControls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.Class_Components
{
    internal class ReadUserData
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static string Username, Password, HashedPassword,
            dbUsername, dbPassword;
        public static int AccountID, Status;

        public static bool ReadData(string InputUsername)
        {
            Username = InputUsername;
            try
            {
                string query = "SELECT `Password`, `AccountID`, `Status` FROM `accounts` WHERE `Username` = @Username";
                bool userFound = false;

                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", InputUsername);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Password = reader.GetString("Password");
                                    AccountID = reader.GetInt32("AccountID");
                                    Status = reader.GetInt32("Status");
                                }
                                userFound = true;
                            }
                        }
                    }
                }
                return userFound;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ReadData", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void LoadEditProfile()
        {
            ChangeUserPassword.GetStrings(AccountID.ToString(), Username, Password);
        }

        public static void EditUserProfile(string id, string username, string password)
        {
            try
            {
                string query = @"UPDATE accounts SET Username = @Username";

                if (password != null)
                {
                    query += ", Password = @Password";
                }

                query += " WHERE AccountID = @AccountID";

                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        if (password != null)
                        {
                            command.Parameters.AddWithValue("@Password", password);
                        }
                        
                        command.Parameters.AddWithValue("@AccountID", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User profile updated successfully.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("User profile not found.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static void LoginUser(string InputUsername, string InputPassword, Control control)
        {
            if (ReadData(InputUsername))
            {
                HashedPassword = PasswordHashing(InputPassword);

                if (Status <= 3)
                {
                    if (HashedPassword == Password)
                    {
                        ResetStatus(InputUsername);
                        dbUsername = InputUsername;
                        MessageBox.Show("Account Login Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Appoint.SetUsername(InputUsername);
                        control.Parent.Controls.Remove(control);
                        MainForm.ShowHomePage();
                        return;
                    }
                    else
                    {
                        IncrementStatus(InputUsername);
                        MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Account inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                MessageBox.Show("Account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void IncrementStatus(string InputUsername)
        {
            try
            {
                string query = "UPDATE `accounts` SET `Status` = `Status` + 1 WHERE `Username` = @Username";

                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", InputUsername);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IncrementStatus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ResetStatus(string InputUsername)
        {
            try
            {
                string query = "UPDATE `accounts` SET `Status` = 0 WHERE `Username` = @Username";

                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", InputUsername);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ResetStatus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string PasswordHashing(string InputPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(InputPassword);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                string hashedString = BitConverter.ToString(hashBytes).Replace("-", "");
                return hashedString;
            }
        }

        public async static Task Registeruser(string username, string password, string id)
        {
            string query = "INSERT INTO accounts (Username, Password, AccountID, Status) VALUES (@Username, @Password, @AccountID, '0')";
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    await conn.OpenAsync();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", PasswordHashing(password));
                        cmd.Parameters.AddWithValue("@AccountID", id);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Register User");
            }
        }

        public static FlowLayoutPanel LoadAppointmentsFLP(FlowLayoutPanel Flp)
        {
            Flp.Controls.Clear();
            string query = "SELECT `ReferenceNumber`, `AppointDate`, `Name`, `IsCancelled` FROM `Appointments` WHERE `Username` = @inputUsername";
            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@inputUsername", dbUsername);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AppointInfo appointInfo = new AppointInfo();

                                appointInfo.RefTextLabel.Text = reader["ReferenceNumber"].ToString();
                                appointInfo.NameTextLabel.Text = reader["Name"].ToString();
                                string cancel = reader["IsCancelled"].ToString();

                                if (DateTime.TryParse(reader["AppointDate"].ToString(), out DateTime appointDate))
                                {
                                    appointInfo.DateTextLabel.Text = appointDate.ToString("dd/MM/yyyy");
                                    if (appointDate >= DateTime.Today && string.Equals(cancel, "NO", StringComparison.OrdinalIgnoreCase))
                                    {
                                        Flp.Controls.Add(appointInfo);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
            return Flp;
        }

    }
}
