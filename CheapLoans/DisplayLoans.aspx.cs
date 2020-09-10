using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace CheapLoans
{
    public partial class DisplayLoans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        double montlyPayment = Financial.Pmt(annualInt, numPayments, loanAmt);
    }
}