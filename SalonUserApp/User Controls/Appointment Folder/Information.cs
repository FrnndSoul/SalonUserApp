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
    public partial class Information : UserControl
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void AgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (AgeBox.TextLength >= 2)
            {
                e.Handled = true;
                return;
            }
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string currentText = NumberBox.Text;

            int totalLength = currentText.Length + 1;
            if (totalLength > 11)
            {
                e.Handled = true;
                return;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(AgeBox.Text) || string.IsNullOrEmpty(NumberBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NumberBox.TextLength != 11)
            {
                MessageBox.Show("Phone number must be 11 digits long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //proceed to checker if a service is selected
        }
    }
}
