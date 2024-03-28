using SalonUserApp.User_Controls;
using SalonUserApp.User_Controls.Appointment_Folder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalonUserApp
{
    public partial class MainForm : Form
    {
        public static MainForm mainFormInstance;

        public MainForm()
        {
            InitializeComponent();
            mainFormInstance = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowSignin();
        }

        public static void ShowSignin()
        {
            if (mainFormInstance != null)
            {
                SigninPage signinPage = new SigninPage
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(signinPage);
                signinPage.BringToFront();
            }
        }

        public static void ShowCreateAccount()
        {
            if (mainFormInstance != null)
            {
                CreateAccountForm createAccountForm = new CreateAccountForm
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(createAccountForm);
                createAccountForm.BringToFront();
            }
        }

        public static void ShowHomePage()
        {
            if (mainFormInstance != null)
            {
                HomePage homePage = new HomePage
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(homePage);
                homePage.BringToFront();
            }
        }

        public static void ShowAppointInfo()
        {
            if (mainFormInstance != null)
            {
                Information information = new Information
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(information);
                information.BringToFront();
            }
        }

        public static void ShowAppointDate()
        {
            if (mainFormInstance != null)
            {
                AppointmentDate appointmentDate = new AppointmentDate
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(appointmentDate);
                appointmentDate.BringToFront();
            }
        }

        public static void ShowAppointEdit()
        {
            if (mainFormInstance != null)
            {
                ChangeAppointInfo ChangeAppointInfo = new ChangeAppointInfo
                {
                    Dock = DockStyle.Fill
                };
                mainFormInstance.Controls.Add(ChangeAppointInfo);
                ChangeAppointInfo.BringToFront();
            }
        }
    }
}
