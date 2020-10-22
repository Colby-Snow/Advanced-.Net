using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TAL_Distributors_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string jsonData;

            //instantiate a proxy object in order to expose methods
            localhost.TALWebService myService = new localhost.TALWebService();

            if (String.IsNullOrEmpty(txtNum.Text))
            {
                jsonData = myService.GetCustomers();               
            }
            else
            {
               jsonData = myService.GetSingleCustomer(txtNum.Text);
            }

            //clear data grid
            dataGridView1.DataSource = null;

            //make sure json data had customers before attempting to build data grid
            if (!jsonData.Contains("No such customer") && !jsonData.Contains("Table empty"))
            {
                //convert Json formatted data so it can be displayed in data grid,
                //then assign to data grid
                var result = JsonConvert.DeserializeObject<List<CustomerClass>>(jsonData);
                dataGridView1.DataSource = result;
            }
            

            txtData.Text = jsonData;
            txtNum.SelectAll();
            txtNum.Focus();

        }
    }
}
