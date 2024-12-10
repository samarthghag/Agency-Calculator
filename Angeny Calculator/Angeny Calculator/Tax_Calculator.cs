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
    public partial class Tax_Calculator : Form
    {
        public Tax_Calculator()
        {
            InitializeComponent();
        }

        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                double baseAmount = double.Parse(txtBaseAmount.Text);
                double taxPercentage = double.Parse(txtTaxPercentage.Text);

                // Validate tax percentage
                if (taxPercentage < 0)
                {
                    MessageBox.Show("Tax percentage cannot be negative.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate tax and total amount
                double taxAmount = (baseAmount * taxPercentage) / 100;
                double totalAmount = baseAmount + taxAmount;

                // Display results
                lblTaxAmount.Text = "Tax Amount: ₹" + taxAmount.ToString("0.00");
                lblTotalAmount.Text = "Total Amount: ₹" + totalAmount.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Base Amount and Tax Percentage.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields and reset labels
            txtBaseAmount.Clear();
            txtTaxPercentage.Clear();
            lblTaxAmount.Text = "Tax Amount: ₹0.00";
            lblTotalAmount.Text = "Total Amount: ₹0.00";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form and return to the main form
            this.Close();
        }
    }
}
