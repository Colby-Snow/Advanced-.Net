using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using Microsoft.VisualBasic;
using System.Windows.Navigation;
using System.Windows.Controls;

namespace CheapLoansWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SubmitLoans : Page
    {
        public SubmitLoans()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            DisplayLoans DisplayPage = new DisplayLoans();
            this.NavigationService.Navigate(DisplayPage);
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            String custName = NameTB.Text;
            double loanAmt = Convert.ToDouble(LoanAmtTB.Text);
            double annualInt = Convert.ToDouble(AnnualIntTB.Text);
            double numPayments = Convert.ToDouble(NumPaymentsTB.Text);

            SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["LoansConnectionString"].ConnectionString);
            connectionString.Open();

            SqlCommand cmd = new SqlCommand("InsertProcedure", connectionString) { CommandType = System.Data.CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@pName", custName);
            cmd.Parameters.AddWithValue("@pLoanAmt", loanAmt.ToString());
            cmd.Parameters.AddWithValue("@pAnnualInt", annualInt.ToString());
            cmd.Parameters.AddWithValue("@pNumPayments", numPayments.ToString());

            cmd.ExecuteNonQuery();
            connectionString.Close();
            SuccessLB.Content = "Loan submitted for " + custName + " click display to find your loan";

            double montlyPayment = Math.Round(-Financial.Pmt(annualInt / 12, numPayments, loanAmt), 2);

            MonthlyPaymentLB.Content = "Your monthly payment will be $" + montlyPayment.ToString();
        }
    }
}
