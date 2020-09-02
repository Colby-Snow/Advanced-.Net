using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquarium_Csharp_With_Database
{
    public partial class display_answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double l, w, h, v, g;

            //get the data from the form (stored in the session object)
            Double.TryParse(Session["length"].ToString(), out l);
            Double.TryParse(Session["width"].ToString(), out w);
            Double.TryParse(Session["height"].ToString(), out h);

            //calculate and display gallons
            v = l * w * h;
            g = v / 231;
            gallonsLabel.Text = g.ToString("N1");
        }

        protected void totInvButton_Click(object sender, EventArgs e)
        {
            //create a DataView object from the rows returned from the SQL query
            DataView dv = new DataView();
            dv = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

            //Only 1 row with 2 columns (total cost and total number) is returned from the query
            totCostLabel.Text = dv.Table.Rows[0].Field<Decimal>(0).ToString();  //total cost
            totNumberLabel.Text = dv.Table.Rows[0].Field<int>(1).ToString();    //total number

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("display_single_fish.aspx");
        }

        protected void addFishButton_Click(object sender, EventArgs e)
        {

        }
    }
}