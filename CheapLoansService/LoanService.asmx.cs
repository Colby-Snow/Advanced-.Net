using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace CheapLoansService
{
    /// <summary>
    /// Summary description for LoanService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoanService : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetAllLoans()
        {
            using (LoansDatabaseEntities entities = new LoansDatabaseEntities())
            {
                var loansList = (from f in entities.Loans
                                   select f).ToList<Loan>();


                if (loansList.Count > 0)
                {
                    return JsonConvert.SerializeObject(loansList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }
            }
        }
        
        [WebMethod]
        public string GetLoanByCustomer(string customerName)
        {
            using (LoansDatabaseEntities entities = new LoansDatabaseEntities())
            {
                var loansList = entities.Loans.Where(x => x.CustName.Contains(customerName)).ToList();

                if (loansList.Count > 0)
                {
                    return JsonConvert.SerializeObject(loansList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }
            }
        }
    }
}
