using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angeny_Calculator
{
    public partial class Hourly_Rate_Calculator_Form : Form
    {
        public Hourly_Rate_Calculator_Form()
        {
            InitializeComponent();
        }

        private void Cal_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Input values
                double hoursWorked = double.Parse(HourWorktextBox.Text);
                double hourlyRate = double.Parse(HRsratetextBox.Text);

                // Calculate total payment
                double totalPayment = hoursWorked * hourlyRate;

                // Display the result
                lblTotalPayment.Text = "Total Payment: ₹" + totalPayment.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Hours Worked and Hourly Rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            // Close the current form and return to the main form
            this.Close();
        }
    }
}
