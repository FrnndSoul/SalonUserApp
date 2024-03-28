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
using ZstdSharp;
using System.Security.Cryptography;

namespace SalonUserApp.User_Controls
{
    public partial class ChangeUserPassword : UserControl
    {
        public static string ID, Username, Password;

        public ChangeUserPassword()
        {
            InitializeComponent();
            ReadUserData.LoadEditProfile();
            textLoad();
        }

        private async void textLoad()
        {
            await Task.Delay(1000);
            IDBox.Text = ID;
            UsernameBox.Text = Username;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string confirmOld, new1, new2;
            string newPass = null;
            confirmOld = PasswordHashing(OldBox.Text);

            if (string.Equals(confirmOld, Password, StringComparison.OrdinalIgnoreCase))
            {
                if (guna2ToggleSwitch1.Checked == true)
                {
                    new1 = Password1Box.Text;
                    new2 = Password2Box.Text;

                    if (Password1Box.Text == null)
                    {
                        MessageBox.Show("Input new password!", "Warning");
                        return;
                    }

                    if (string.Equals(new1, new2))
                    {
                        newPass = PasswordHashing(new1);
                    }
                    else
                    {
                        MessageBox.Show("New password do not match", "Warning");
                        return;
                    }
                }
                ReadUserData.EditUserProfile(ID, UsernameBox.Text, newPass);
                
            }
            else
            {
                MessageBox.Show("Old password did not match", "Warning");
            }
        }

        private void ChangePass_VisibleChanged(object sender, EventArgs e)
        {
            Password1Box.Text = "";
            Password2Box.Text = "";
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked != true)
            {
                changePass.Visible = false;
            } else
            {
                changePass.Visible = true;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public static void GetStrings(string id, string username, string password)
        {
            ID = id;
            Username = username;
            Password = password;
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

    }
}
