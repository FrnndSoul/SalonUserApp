using SalonUserApp.Class_Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class AppointmentDate : UserControl
    {
        static readonly DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;
        static readonly int maxMonth = currentMonth + 2 > 12 ? (currentMonth + 2) % 12 : currentMonth + 2;
        DateTime daychecker;

        public AppointmentDate()
        {
            InitializeComponent();
            DisplayDays();
            DisplayAvailableTimeSlots();
        }

        private void DisplayDays()
        {
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth);
            MosYrLbl.Text = monthname + " " + currentYear;

            // Initialize daychecker with the start date of the current month
            daychecker = new DateTime(currentYear, currentMonth, 1);

            int days = DateTime.DaysInMonth(currentYear, currentMonth);
            int weekdays = Convert.ToInt32(daychecker.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekdays; i++)
            {
                UCBlankDays uCBlankDays = new UCBlankDays();
                CalendarFLP.Controls.Add(uCBlankDays);
            }

            for (int i = 1; i <= days; i++)
            {
                UCDays ucdays = new UCDays();
                ucdays.days(i, currentMonth, currentYear);

                if (daychecker.AddDays(i) < DateTime.Today || daychecker.AddDays(i) < DateTime.Today.AddDays(1))
                {
                    ucdays.Enabled = false;
                }

                // Check if the day is a weekend
                if (IsWeekendDay(currentYear, currentMonth, i))
                {
                    // If it's a weekend, disable the user control
                    ucdays.Enabled = false;
                }

                CalendarFLP.Controls.Add(ucdays);
            }
        }

        private bool IsWeekendDay(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        private void DisplayAvailableTimeSlots()
        {
            TimeFLP.Controls.Clear();

            // Define time range
            TimeSpan startTime = new TimeSpan(11, 0, 0); // 11:00 AM
            TimeSpan endTime = new TimeSpan(20, 0, 0);   // 08:00 PM

            TimeSpan slotDuration = new TimeSpan(1, 0, 0); // 1 hour slot
            TimeSpan currentTime = startTime;
            while (currentTime < endTime)
            {
                // Create a TimeUC control
                TimeUC timeControl = new TimeUC();

                // Set the text of the Timelbl label directly with the custom time format
                timeControl.Timelbl.Text = FormatTime(currentTime);

                // Add the TimeUC control to the TimeFLP
                TimeFLP.Controls.Add(timeControl);

                currentTime += slotDuration;
            }
        }

        private string FormatTime(TimeSpan time)
        {
            int hour = time.Hours;
            int minute = time.Minutes;

            string formattedTime = $"{hour:D2}:{minute:D2}";

            return formattedTime;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentMonth == maxMonth)
            {
                return;
            }

            foreach (Control control in TimeFLP.Controls)
            {
                if (control is TimeUC uC)
                {
                    uC.TimeNull();
                }
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

            foreach (Control control in TimeFLP.Controls)
            {
                if (control is TimeUC uC)
                {
                    uC.TimeNull();
                }
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
            this.Parent.Controls.Remove(this);
            foreach (Control control in MainForm.mainFormInstance.Controls)
            {
                if (control is Information || control is ChangeAppointInfo)
                {
                    control.Visible = true;
                    break;
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string[] mosYr = MosYrLbl.Text.Split(' ');
            string month = mosYr[0];
            string year = mosYr[1];

            foreach (Control dayControl in CalendarFLP.Controls)
            {
                if (dayControl.BackColor == Color.LightGray && dayControl is UCDays)
                {
                    Appoint.SetAppointYearMonth(month, year);

                    foreach (Control control in MainForm.mainFormInstance.Controls)
                    {
                        if (control is Information)
                        {
                            if (control.Visible == false)
                            {
                                Appoint.Appointment();
                                break;
                            }

                        }
                        else if (control is ChangeAppointInfo)
                        {
                            if (control.Visible == false)
                            {
                                Appoint.EditAppointment();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CalendarFLP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
