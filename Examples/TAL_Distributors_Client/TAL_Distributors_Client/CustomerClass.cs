using System;
using Newtonsoft.Json;

namespace TAL_Distributors_Client
{
    public class CustomerClass
    {       
        public string CUSTOMER_NUM { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string STREET { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string POSTAL_CODE { get; set; }
        public Nullable<decimal> BALANCE { get; set; }
        public Nullable<decimal> CREDIT_LIMIT { get; set; }
        public string REP_NUM { get; set; }
        
    }
}
