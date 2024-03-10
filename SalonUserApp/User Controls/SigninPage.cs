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

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            if (ReadUserData.LoginUser(username, password))
            {

            }
        }

        private void CreateAccountBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
