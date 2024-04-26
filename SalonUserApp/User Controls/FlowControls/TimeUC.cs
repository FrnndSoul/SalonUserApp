using SalonUserApp.Class_Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class TimeUC : UserControl
    {
        private static TimeUC previousClicked = null;

        public TimeUC()
        {
            InitializeComponent();
        }

        private void TimeUC_Click(object sender, EventArgs e)
        {
            HighlightControl();
            Appoint.SetAppointHour(Timelbl.Text);
        }

        private void Timelbl_Click(object sender, EventArgs e)
        {
            HighlightControl();
            Appoint.SetAppointHour(Timelbl.Text);
        }

        private void HighlightControl()
        {
            if (previousClicked != null)
            {
                previousClicked.BackColor = Color.White;
            }

            this.BackColor = Color.LightGray;
            previousClicked = this;
        }

        public void TimeNull()
        {
            if (previousClicked != null)
            {
                previousClicked.BackColor = Color.White;
            }

            previousClicked = null;
        }

        private void TimeUC_Load(object sender, EventArgs e)
        {

        }
    }
}
