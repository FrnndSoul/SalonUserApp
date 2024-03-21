﻿using MySql.Data.MySqlClient;
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


        public static void LoginUser(string InputUsername, string InputPassword)
        {
            if (ReadData(InputUsername))
            {
                HashedPassword = PasswordHashing(InputPassword);

                if (Status <= 3)
                {
                    if (HashedPassword == Password)
                    {
                        ResetStatus(InputUsername);
                        MessageBox.Show("Account Login Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Appoint.SetUsername(InputUsername);
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

        public static void Registeruser(string username, string password, string id)
        {
            try
            {
                string query = "INSERT INTO accounts (Username, Password, AccountID) VALUES (@Username, @Password, @AccountID)";
                using (SqlConnection connection = new SqlConnection(mysqlcon))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", PasswordHashing(password));
                        command.Parameters.AddWithValue("@AccountID", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registeruser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
