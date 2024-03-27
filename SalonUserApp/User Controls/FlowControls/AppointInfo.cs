using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace SalonUserApp.User_Controls.FlowControls
{
    public partial class AppointInfo : UserControl
    {
        public static string dbReferenceNumber, dbDateFiled, dbAppointDate, dbUsername, dbName, dbPhoneNumber, dbAge,
            dbServicelD, dbServiceName, dbServiceAmount, dbServiceTypelD, dbServiceVariationlD, dbIsCancelled;

        public AppointInfo()
        {
            InitializeComponent();
        }

        private void CheckStatusBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
