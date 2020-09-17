using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheapLoans
{
    public partial class Loans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitForm(object sender, EventArgs e)
        {
            String custName = NameTB.Text;
            double loanAmt = Convert.ToDouble(LoanAmtTB.Text);
            double annualInt = Convert.ToDouble(AnnualIntTB.Text);
            double numPayments = Convert.ToDouble(NumPaymentsTB.Text);
            String insertQuery = "INSERT INTO Loan (CustName, LoanAmount, AnnualIntRate, NumPayments) VALUES (@pName, @pLoanAmt , @pAnnualInt, @pNumPayments)";
            SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["LoansConnectionString"].ConnectionString);
            connectionString.Open();

            SqlCommand cmd = new SqlCommand(insertQuery, connectionString);

            cmd.Parameters.AddWithValue("@pName", custName);
            cmd.Parameters.AddWithValue("@pLoanAmt", loanAmt.ToString());
            cmd.Parameters.AddWithValue("@pAnnualInt", annualInt.ToString());
            cmd.Parameters.AddWithValue("@pNumPayments", numPayments.ToString());

            cmd.ExecuteNonQuery();
            connectionString.Close();
            SuccessLB.Text = "Loan submitted for " + custName + "click display to find your loan";

            double montlyPayment = Math.Round(-Financial.Pmt(annualInt/12, numPayments, loanAmt), 2);

            MonthlyPaymentLB.Text = "Your monthly payment will be $" + montlyPayment.ToString();
        }

        protected void DisplayPage(object sender, EventArgs e)
        {
            Response.Redirect("DisplayLoans.aspx");
        }
    }
}
