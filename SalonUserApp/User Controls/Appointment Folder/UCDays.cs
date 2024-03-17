using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class UCDays : UserControl
    {
        private DateTime date;
        public UCDays()
        {
            InitializeComponent();
        }

        public void days(int numday, int month, int year)
        {
            DaysLbl.Text = numday + "";
            date = new DateTime(year, month, numday);

        }

        private void UCDays_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The date is: " + date.ToString("0M/dd/yyyy"));
        }

        private void DaysLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The date is: " + date.ToString("0M/dd/yyyy"));
        }
    }
}
