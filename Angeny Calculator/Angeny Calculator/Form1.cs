namespace Angeny_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Project_Cost_Estimator project_Cost_Estimator = new Project_Cost_Estimator();
            project_Cost_Estimator.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hourly_Rate_Calculator_Form hourly_Rate_Calculator_Form = new Hourly_Rate_Calculator_Form();
            hourly_Rate_Calculator_Form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DigitalAdBudgetCalculator digitalAdBudgetCalculator = new DigitalAdBudgetCalculator();
            digitalAdBudgetCalculator.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tax_Calculator tax_Cal = new Tax_Calculator();
            tax_Cal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Optionally, close the form to go back to the previous one
            this.Close();
        }
    }
}
