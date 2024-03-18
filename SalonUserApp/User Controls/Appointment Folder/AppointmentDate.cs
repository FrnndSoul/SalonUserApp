using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class AppointmentDate : UserControl
    {
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        static int maxMonth = currentMonth + 2 > 12 ? (currentMonth + 2) % 12 : currentMonth + 2;
        public MainForm mainFormInstance;

        public AppointmentDate(MainForm mainForm)
        {
            InitializeComponent();
            this.mainFormInstance = mainForm;
            DisplayDays();
        }

        public AppointmentDate()
        {
        }

        private void DisplayDays()
        {
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            MosYrLbl.Text = monthname + " " + currentYear;

            DateTime monthstart = new DateTime(currentYear, currentMonth, 1);
            int days = DateTime.DaysInMonth(currentYear, currentMonth);
            int weekdays = Convert.ToInt32(monthstart.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekdays; i++)
            {
                UCBlankDays uCBlankDays = new UCBlankDays();
                CalendarFLP.Controls.Add(uCBlankDays);
            }

            for (int i = 1; i <= days; i++)
            {
                UCDays ucdays = new UCDays();
                ucdays.days(i, currentMonth, currentYear);
                CalendarFLP.Controls.Add(ucdays);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentMonth == maxMonth)
            {
                return;
            }

            CalendarFLP.Controls.Clear();
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            DisplayDays();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentMonth == currentDT.Month && currentYear == currentDT.Year)
            {
                return;
            }

            CalendarFLP.Controls.Clear();
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            DisplayDays();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            foreach (Control control in MainForm.mainFormInstance.Controls)
            {
                if (control is Information)
                {
                    control.Visible = true;
                    break;
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }
    }
}
