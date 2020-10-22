using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;

namespace Consume_Public_API_REST_Countries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCountry.Text))
            {
                string url = "https://restcountries.eu/rest/v2/alpha/" + txtCountry.Text;

                //this is to get back data formatted into a list of country objects from JSON data
                List<CountryData> cList = GetFormatted(url);

                foreach (CountryData item in cList)
                {
                    lblData.Text += "Country: " + item.Name + " " + "Capital: " + item.Capital +
                        "  Population: " + item.Population + "\n";
                }

                //this is to get back the raw JSON data
                //lblData.Text = GetRaw(url);

                txtCountry.SelectAll();
                txtCountry.Focus();
            }
            else
            {
                MessageBox.Show("Country is required");
                txtCountry.Focus();
            }
        }


        // this returns JSON data converted into a list of objects
        public List<CountryData> GetFormatted(string url)
        {
            var client = new RestClient(url);

            var response = client.Execute<List<CountryData>>(new RestRequest());
           
            return response.Data;
        }

        //this returns raw JSON data as a string
        public string GetRaw(string url)
        {
            var client = new RestClient(url);
                        
            var response = client.Execute(new RestRequest());

            return response.Content;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblData.Text = " ";
            txtCountry.SelectAll();
            txtCountry.Focus();
        }
    }
}
