using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapLoansDisplay
{
    class LoansModel
    {
        public int LoanNum { get; set; }
        public string CustName { get; set; }
        public Nullable<decimal> LoanAmount { get; set; }
        public Nullable<decimal> AnnualIntRate { get; set; }
        public Nullable<int> NumPayments { get; set; }
    }
}
