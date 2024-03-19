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
            MessageBox.Show(Timelbl.Text);
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
                previousClicked.BackColor = Color.Transparent;
            }

            this.BackColor = Color.LightGray;
            previousClicked = this;
        }

        public void TimeNull()
        {
            previousClicked = null;
            previousClicked.BackColor = Color.Transparent;
        }
    }
}
