using System.Windows.Forms;

namespace Monthly_Payment_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List to hold results.
        List <string> list = new List <string>();
        private void calculateBtn_Click(object sender, EventArgs e) {
            // Get Loan Amount from method
            double loanAmount = GetLoanAmount();
            // Get Interest Rate from method
            double interestRate = GetInterestRate();
            // Get Loan Months from method
            int loanMonths = GetLoanMonths();

            // Get EMI and Total from method
            (double EMI, double total) calc = Calculate(loanAmount, interestRate, loanMonths);

            // Get results from method
            string results = FormatResults(loanAmount, interestRate, loanMonths, calc.EMI, calc.total);

            // Add items to list and listbox
            AddItems(results, calc.EMI);

        }


        private double GetLoanAmount() {
            double loanAmount;      // Variable to hold Loan Amount
            // See in input value is number and greater than zero
            if (double.TryParse(loanAmountTxtBox.Text, out loanAmount) && loanAmount > 0) {
            } else if (loanAmount < 0) {
                // Message display if Loan Amount less than zero
                MessageBox.Show("Loan Amount must be greater than 0.");
            } else {
                // Message display if Loan Amount is not a number
                MessageBox.Show("Loan Amount must be a valid numerical value.");
            }
            return loanAmount;
        }

        private double GetInterestRate() {
            double interestRate;    // Variable to hold Interest Rate
            // See in input value is number and greater than zero
            if (double.TryParse(interestRateTxtBox.Text, out interestRate) && interestRate > 0) {
            } else if (interestRate < 0) {
                // Message display if Interest Rate less than zero
                MessageBox.Show("Interest Rate must be greater than 0.");
            } else {
                // Message display if Interest Rate is not a number
                MessageBox.Show("Interest Rate must be a valid numerical value.");
            }
            return interestRate;
        }

        private int GetLoanMonths() {
            int loanMonths;     // Variable to hold Loan Months
            // See in input value is number and greater than zero
            if (int.TryParse(loanMonthsTxtBox.Text, out loanMonths) && loanMonths > 0) {
            } else if (loanMonths < 0) {
                // Message display if Loan Months less than zero
                MessageBox.Show("Loan Months must be greater than 0.");
            } else {
                // Message display if Loan Months is not a number
                MessageBox.Show("Loan Months must be a valid numerical whole value.");
            }
            return loanMonths;
        }

        private static (double EMI, double total) Calculate(double loanAmount, double interestRate, int loanMonths) {
            // Divide interst rate by months in year * 100 to get monthly interest rate as percent
            interestRate = interestRate / 1200;
            // Formula to calculate monthly loan payment: EMI = P x R x (1+R)^N / [(1+R)^N-1]
            double EMI = loanAmount * interestRate * Math.Pow(1 + interestRate, loanMonths) / (Math.Pow(1 + interestRate, loanMonths) - 1);
            // Montly payments totaled
            double total = EMI * loanMonths;
            return (EMI, total);
        }

        private string FormatResults(double loanAmount, double interestRate, int loanMonths, double EMI, double total) {
            // Variable to hold formatted results
            string results = "Results:" + " " +
                             "Loan Amount: " + loanAmount.ToString("c2") + "   " +
                             "Interest Rate: " + (interestRate / 100).ToString("p2") + "   " +
                             "Loan Months: " + loanMonths.ToString() + "   " +
                             "Monthly Loan Payment: " + EMI.ToString("c2") + "   " +
                             "Loan Payment Total: " + total.ToString("c2");
            return results;
        }

        private void AddItems(string results, double EMI) {
            // See if value was calculated
            if (EMI > 0) {
                // variable to count
                int i = 0;
                // Add items to list array and list box
                list.Add(results);
                outputListBox.Items.Add(results);
                i++;

                // Enable buttons
                deleteItemBtn.Enabled = true;
                clearCLBtn.Enabled = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e) {
            // Clear text box values
            loanAmountTxtBox.Text = string.Empty;
            interestRateTxtBox.Text = string.Empty;
            loanMonthsTxtBox.Text = string.Empty;
        }

        private void deleteItemBtn_Click(object sender, EventArgs e) {
            // Deletes selected index in list box and list array
            for (int i = outputListBox.SelectedIndices.Count - 1; i >= 0; i--) {
                outputListBox.Items.RemoveAt(outputListBox.SelectedIndices[i]);
                list.Remove(outputListBox.SelectedIndex.ToString());
            }
        }

        private void clearCLBtn_Click(object sender, EventArgs e) {
            // Clear list box and list array
            outputListBox.Items.Clear();
            list.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            // Close the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Gives text boxes default values
            loanAmountTxtBox.Text = "10000";
            interestRateTxtBox.Text = "10";
            loanMonthsTxtBox.Text = "60";

            // Disable buttons
            deleteItemBtn.Enabled = false;
            clearCLBtn.Enabled = false;
        }
    }
}