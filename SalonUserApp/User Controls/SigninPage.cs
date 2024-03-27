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
            this.Dispose();
            MainForm.ShowCreateAccount();
        }

        private async void CloseBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            Application.Exit();
        }
    }
}
