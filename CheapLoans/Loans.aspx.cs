using System;
using System.Collections.Generic;
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
            double loanAmt = Convert.ToDouble(LoanAmtTB.Text);
            double annualInt = Convert.ToDouble(AnnualIntTB.Text);
            double numPayments = Convert.ToDouble(NumPaymentsTB.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CheapLoans;Integrated Security=True;";

            String insertQuery = 

         }
    }
}