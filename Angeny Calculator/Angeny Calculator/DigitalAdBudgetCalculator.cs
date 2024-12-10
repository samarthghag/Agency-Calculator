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
    public partial class DigitalAdBudgetCalculator : Form
    {
        private double totalAdBudget = 0;
        private List<string> platformDetails = new List<string>();

        public DigitalAdBudgetCalculator()
        {
            InitializeComponent();
        }

        private void btnAddPlatform_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                string platformName = txtPlatformName.Text;
                double budgetAmount = double.Parse(txtBudgetAmount.Text);
                double budgetPercentage = double.Parse(txtBudgetPercentage.Text);

                // Validate budget percentage
                if (budgetPercentage < 0 || budgetPercentage > 100)
                {
                    MessageBox.Show("Please enter a percentage between 0 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate component allocation
                double allocatedAmount = (budgetAmount * budgetPercentage) / 100;

                // Add platform details to the list
                string platformDetail = "{platformName}: ₹{budgetAmount} with {budgetPercentage}% = ₹{allocatedAmount}";
                platformDetails.Add(platformDetail);
                lstPlatformDetails.Items.Add(platformDetail);

                // Update total budget
                totalAdBudget += budgetAmount;

                // Clear inputs
                txtPlatformName.Clear();
                txtBudgetAmount.Clear();
                txtBudgetPercentage.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Budget Amount and Budget Percentage.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display total advertising budget
            lblTotalAdBudget.Text = "Total Advertising Budget: ₹" + totalAdBudget.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset all fields and variables
            totalAdBudget = 0;
            platformDetails.Clear();
            lstPlatformDetails.Items.Clear();
            txtPlatformName.Clear();
            txtBudgetAmount.Clear();
            txtBudgetPercentage.Clear();
            lblTotalAdBudget.Text = "Total Advertising Budget: $0.00";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
