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
using static System.Net.Mime.MediaTypeNames;

namespace SalonUserApp.User_Controls.Appointment_Folder
{
    public partial class DownPaymentUserform : Form
    {
        public DownPaymentUserform()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            string newRef = referenceBox.Text;
            if (string.IsNullOrEmpty(newRef))
            {
                return;
            }
            else
            {
                int length = newRef.Length;
                if (length != 13)
                {
                    return;
                }
                else
                {
                    Appoint.SetPaymentRef(newRef);
                    this.Dispose();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Appoint.SetPaymentRef(null);
            this.Dispose();
        }

        private void ReferenceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = referenceBox.Text;
            int length = text.Length;

            if (char.IsDigit(e.KeyChar))
            {
                if (length >= 13)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
