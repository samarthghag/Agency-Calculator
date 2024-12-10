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
    public partial class Project_Cost_Estimator : Form
    {
        private double totalCost = 0;
        private List<string> taskDetails = new List<string>();
        public Project_Cost_Estimator()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                string taskName = txtTaskName.Text;
                double taskRate = double.Parse(txtTaskRate.Text);
                int numberOfTasks = int.Parse(txtNumberOfTasks.Text);

                // Calculate task cost
                double taskCost = taskRate * numberOfTasks;

                // Add task details to the list
                string taskDetail = $"{taskName} - {numberOfTasks} tasks @ ₹{taskRate}/task = ₹{taskCost}";
                taskDetails.Add(taskDetail);
                lstTasks.Items.Add(taskDetail);

                // Update total cost
                totalCost += taskCost;

                // Clear inputs
                txtTaskName.Clear();
                txtTaskRate.Clear();
                txtNumberOfTasks.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Task Rate and Number of Tasks.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get additional costs
                double additionalCosts = double.Parse(txtAdditionalCosts.Text);

                // Update total cost
                totalCost += additionalCosts;

                // Display total cost
                lblTotalCost.Text = "Total Cost: ₹" + totalCost.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Additional Costs.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset all fields and variables
            totalCost = 0;
            taskDetails.Clear();
            lstTasks.Items.Clear();
            txtTaskName.Clear();
            txtTaskRate.Clear();
            txtNumberOfTasks.Clear();
            txtAdditionalCosts.Clear();
            lblTotalCost.Text = "Total Cost: ₹0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form and return to the main form
            this.Close();
        }
    }
}
